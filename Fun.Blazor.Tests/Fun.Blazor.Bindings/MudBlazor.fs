namespace rec MudBlazor.DslInternals

open FSharp.Data.Adaptive
open Fun.Blazor
open Fun.Blazor.Operators
open MudBlazor.DslInternals

type MudComponentBaseBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAndChildAttrBuilder<'FunBlazorGeneric>()
    /// User class names, separated by space.
    [<CustomOperation("Classes")>] member inline _.Classes ([<InlineIfLambda>] render: AttrRenderFragment, x: string list) = render ==> html.classes x
    /// User styles, applied on top of the component's own classes and styles.
    [<CustomOperation("Styles")>] member inline _.Styles ([<InlineIfLambda>] render: AttrRenderFragment, x: (string * string) list) = render ==> html.styles x
    /// Use Tag to attach any user data object to the component for your convenience.
    [<CustomOperation("Tag")>] member inline _.Tag ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Object) = render ==> ("Tag" => x)
    /// UserAttributes carries all attributes you add to the component that don't match any of its parameters.
    /// They will be splatted onto the underlying HTML tag.
    [<CustomOperation("UserAttributes")>] member inline _.UserAttributes ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.Dictionary<System.String, System.Object>) = render ==> ("UserAttributes" => x)

type MudBaseButtonBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    /// The HTML element that will be rendered in the root by the component
    /// By default, is a button
    [<CustomOperation("HtmlTag")>] member inline _.HtmlTag ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("HtmlTag" => x)
    /// The button Type (Button, Submit, Refresh)
    [<CustomOperation("ButtonType")>] member inline _.ButtonType ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.ButtonType) = render ==> ("ButtonType" => x)
    /// If set to a URL, clicking the button will open the referenced document. Use Target to specify where
    [<CustomOperation("Href")>] member inline _.Href ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Href" => x)
    /// If set to a URL, clicking the button will open the referenced document. Use Target to specify where (Obsolete replaced by Href)
    [<CustomOperation("Link")>] member inline _.Link ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Link" => x)
    /// The target attribute specifies where to open the link, if Link is specified. Possible values: _blank | _self | _parent | _top | framename
    [<CustomOperation("Target")>] member inline _.Target ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Target" => x)
    /// If true, the button will be disabled.
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("Disabled" => x)
    /// If true, no drop-shadow will be used.
    [<CustomOperation("DisableElevation")>] member inline _.DisableElevation ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("DisableElevation" => x)
    /// If true, disables ripple effect.
    [<CustomOperation("DisableRipple")>] member inline _.DisableRipple ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("DisableRipple" => x)
    /// Command executed when the user clicks on an element.
    [<CustomOperation("Command")>] member inline _.Command ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Windows.Input.ICommand) = render ==> ("Command" => x)
    /// Command parameter.
    [<CustomOperation("CommandParameter")>] member inline _.CommandParameter ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Object) = render ==> ("CommandParameter" => x)
    /// Button click event.
    [<CustomOperation("OnClick")>] member inline _.OnClick ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>("OnClick", fn)
    /// Button click event.
    [<CustomOperation("OnClick")>] member inline _.OnClick ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callbackTask<Microsoft.AspNetCore.Components.Web.MouseEventArgs>("OnClick", fn)

type MudButtonBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudBaseButtonBuilder<'FunBlazorGeneric>()
    /// Icon placed before the text if set.
    [<CustomOperation("StartIcon")>] member inline _.StartIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("StartIcon" => x)
    /// Icon placed after the text if set.
    [<CustomOperation("EndIcon")>] member inline _.EndIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("EndIcon" => x)
    /// The color of the icon. It supports the theme colors.
    [<CustomOperation("IconColor")>] member inline _.IconColor ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("IconColor" => x)
    /// The size of the icon. When null, the value of Size is used.
    [<CustomOperation("IconSize")>] member inline _.IconSize ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<MudBlazor.Size>) = render ==> ("IconSize" => x)
    /// Icon class names, separated by space
    [<CustomOperation("IconClass")>] member inline _.IconClass ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("IconClass" => x)
    /// The color of the component. It supports the theme colors.
    [<CustomOperation("Color")>] member inline _.Color ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("Color" => x)
    /// The Size of the component.
    [<CustomOperation("Size")>] member inline _.Size ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Size) = render ==> ("Size" => x)
    /// The variant to use.
    [<CustomOperation("Variant")>] member inline _.Variant ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Variant) = render ==> ("Variant" => x)
    /// If true, the button will take up 100% of available width.
    [<CustomOperation("FullWidth")>] member inline _.FullWidth ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("FullWidth" => x)

type MudFabBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudBaseButtonBuilder<'FunBlazorGeneric>()
    /// The color of the component. It supports the theme colors.
    [<CustomOperation("Color")>] member inline _.Color ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("Color" => x)
    /// The Size of the component.
    [<CustomOperation("Size")>] member inline _.Size ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Size) = render ==> ("Size" => x)
    /// If applied Icon will be added at the start of the component.
    [<CustomOperation("Icon")>] member inline _.Icon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Icon" => x)
    /// If applied Icon will be added at the start of the component.
    [<CustomOperation("StartIcon")>] member inline _.StartIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("StartIcon" => x)
    /// If applied Icon will be added at the end of the component.
    [<CustomOperation("EndIcon")>] member inline _.EndIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("EndIcon" => x)
    /// The color of the icon. It supports the theme colors.
    [<CustomOperation("IconColor")>] member inline _.IconColor ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("IconColor" => x)
    /// The size of the icon.
    [<CustomOperation("IconSize")>] member inline _.IconSize ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Size) = render ==> ("IconSize" => x)
    /// If applied the text will be added to the component.
    [<CustomOperation("Label")>] member inline _.Label ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Label" => x)
    /// Title of the icon used for accessibility.
    [<CustomOperation("Title")>] member inline _.Title ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Title" => x)

type MudIconButtonBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudBaseButtonBuilder<'FunBlazorGeneric>()
    /// The Icon that will be used in the component.
    [<CustomOperation("Icon")>] member inline _.Icon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Icon" => x)
    /// Title of the icon used for accessibility.
    [<CustomOperation("Title")>] member inline _.Title ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Title" => x)
    /// The color of the component. It supports the theme colors.
    [<CustomOperation("Color")>] member inline _.Color ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("Color" => x)
    /// The Size of the component.
    [<CustomOperation("Size")>] member inline _.Size ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Size) = render ==> ("Size" => x)
    /// If set uses a negative margin.
    [<CustomOperation("Edge")>] member inline _.Edge ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Edge) = render ==> ("Edge" => x)
    /// The variant to use.
    [<CustomOperation("Variant")>] member inline _.Variant ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Variant) = render ==> ("Variant" => x)

type MudDrawerContainerBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()


type MudLayoutBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudDrawerContainerBuilder<'FunBlazorGeneric>()


type MudBaseSelectItemBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    /// If true, the input element will be disabled.
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("Disabled" => x)
    /// If true, disables ripple effect.
    [<CustomOperation("DisableRipple")>] member inline _.DisableRipple ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("DisableRipple" => x)
    /// Link to a URL when clicked.
    [<CustomOperation("Href")>] member inline _.Href ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Href" => x)
    /// If true, force browser to redirect outside component router-space.
    [<CustomOperation("ForceLoad")>] member inline _.ForceLoad ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("ForceLoad" => x)
    /// Command parameter.
    [<CustomOperation("CommandParameter")>] member inline _.CommandParameter ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Object) = render ==> ("CommandParameter" => x)
    /// Command executed when the user clicks on an element.
    [<CustomOperation("Command")>] member inline _.Command ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Windows.Input.ICommand) = render ==> ("Command" => x)
    [<CustomOperation("OnClick")>] member inline _.OnClick ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>("OnClick", fn)
    [<CustomOperation("OnClick")>] member inline _.OnClick ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callbackTask<Microsoft.AspNetCore.Components.Web.MouseEventArgs>("OnClick", fn)

type MudNavLinkBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudBaseSelectItemBuilder<'FunBlazorGeneric>()
    /// Icon to use if set.
    [<CustomOperation("Icon")>] member inline _.Icon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Icon" => x)
    /// The color of the icon. It supports the theme colors, default value uses the themes drawer icon color.
    [<CustomOperation("IconColor")>] member inline _.IconColor ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("IconColor" => x)
    [<CustomOperation("Match")>] member inline _.Match ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.AspNetCore.Components.Routing.NavLinkMatch) = render ==> ("Match" => x)
    [<CustomOperation("Target")>] member inline _.Target ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Target" => x)
    /// User class names when active, separated by space.
    [<CustomOperation("ActiveClass")>] member inline _.ActiveClass ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("ActiveClass" => x)

/// Represents an option of a select or multi-select. To be used inside MudSelect.
type MudSelectItemBuilder<'FunBlazorGeneric, 'T when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudBaseSelectItemBuilder<'FunBlazorGeneric>()
    /// A user-defined option that can be selected
    [<CustomOperation("Value")>] member inline _.Value ([<InlineIfLambda>] render: AttrRenderFragment, x: 'T) = render ==> ("Value" => x)

type MudTableBaseBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    /// When editing a row and this is true, the editing row must be saved/canceled before a new row will be selected.
    [<CustomOperation("IsEditRowSwitchingBlocked")>] member inline _.IsEditRowSwitchingBlocked ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("IsEditRowSwitchingBlocked" => x)
    /// The higher the number, the heavier the drop-shadow. 0 for no shadow.
    [<CustomOperation("Elevation")>] member inline _.Elevation ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("Elevation" => x)
    /// Set true to disable rounded corners
    [<CustomOperation("Square")>] member inline _.Square ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("Square" => x)
    /// If true, table will be outlined.
    [<CustomOperation("Outlined")>] member inline _.Outlined ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("Outlined" => x)
    /// If true, table's cells will have left/right borders.
    [<CustomOperation("Bordered")>] member inline _.Bordered ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("Bordered" => x)
    /// Set true for rows with a narrow height
    [<CustomOperation("Dense")>] member inline _.Dense ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("Dense" => x)
    /// Set true to see rows hover on mouse-over.
    [<CustomOperation("Hover")>] member inline _.Hover ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("Hover" => x)
    /// If true, striped table rows will be used.
    [<CustomOperation("Striped")>] member inline _.Striped ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("Striped" => x)
    /// At what breakpoint the table should switch to mobile layout. Takes None, Xs, Sm, Md, Lg and Xl the default behavior is breaking on Xs.
    [<CustomOperation("Breakpoint")>] member inline _.Breakpoint ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Breakpoint) = render ==> ("Breakpoint" => x)
    /// When true, the header will stay in place when the table is scrolled. Note: set Height to make the table scrollable.
    [<CustomOperation("FixedHeader")>] member inline _.FixedHeader ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("FixedHeader" => x)
    /// When true, the footer will be visible is not scrolled to the bottom. Note: set Height to make the table scrollable.
    [<CustomOperation("FixedFooter")>] member inline _.FixedFooter ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("FixedFooter" => x)
    /// Setting a height will allow to scroll the table. If not set, it will try to grow in height. You can set this to any CSS value that the
    /// attribute 'height' accepts, i.e. 500px. 
    [<CustomOperation("Height")>] member inline _.Height ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Height" => x)
    /// If table is in smalldevice mode and uses any kind of sorting the text applied here will be the sort selects label.
    [<CustomOperation("SortLabel")>] member inline _.SortLabel ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("SortLabel" => x)
    /// If true allows table to be in an unsorted state through column clicks (i.e. first click sorts "Ascending", second "Descending", third "None").
    /// If false only "Ascending" and "Descending" states are allowed (i.e. there always should be a column to sort).
    [<CustomOperation("AllowUnsorted")>] member inline _.AllowUnsorted ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("AllowUnsorted" => x)
    /// If the table has more items than this number, it will break the rows into pages of said size.
    /// Note: requires a MudTablePager in PagerContent.
    [<CustomOperation("RowsPerPage")>] member inline _.RowsPerPage ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("RowsPerPage" => x)
    /// If the table has more items than this number, it will break the rows into pages of said size.
    /// Note: requires a MudTablePager in PagerContent.
    [<CustomOperation("RowsPerPage'")>] member inline _.RowsPerPage' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.Int32 * (System.Int32 -> unit)) = render ==> html.bind("RowsPerPage", valueFn)
    /// Rows Per Page two-way bindable parameter
    [<CustomOperation("RowsPerPageChanged")>] member inline _.RowsPerPageChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callback<System.Int32>("RowsPerPageChanged", fn)
    /// Rows Per Page two-way bindable parameter
    [<CustomOperation("RowsPerPageChanged")>] member inline _.RowsPerPageChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callbackTask<System.Int32>("RowsPerPageChanged", fn)
    /// The page index of the currently displayed page (Zero based). Usually called by MudTablePager.
    /// Note: requires a MudTablePager in PagerContent.
    [<CustomOperation("CurrentPage")>] member inline _.CurrentPage ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("CurrentPage" => x)
    /// Set to true to enable selection of multiple rows with check boxes. 
    [<CustomOperation("MultiSelection")>] member inline _.MultiSelection ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("MultiSelection" => x)
    /// When true, a row-click also toggles the checkbox state.
    [<CustomOperation("SelectOnRowClick")>] member inline _.SelectOnRowClick ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("SelectOnRowClick" => x)
    /// Optional. Add any kind of toolbar to this render fragment.
    [<CustomOperation("ToolBarContent")>] member inline _.ToolBarContent ([<InlineIfLambda>] render: AttrRenderFragment, fragment) = render ==> html.renderFragment("ToolBarContent", fragment)
    /// Optional. Add any kind of toolbar to this render fragment.
    [<CustomOperation("ToolBarContent")>] member inline _.ToolBarContent ([<InlineIfLambda>] render: AttrRenderFragment, fragments) = render ==> html.renderFragment("ToolBarContent", fragment { yield! fragments })
    /// Optional. Add any kind of toolbar to this render fragment.
    [<CustomOperation("ToolBarContent")>] member inline _.ToolBarContent ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("ToolBarContent", html.text x)
    /// Optional. Add any kind of toolbar to this render fragment.
    [<CustomOperation("ToolBarContent")>] member inline _.ToolBarContent ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("ToolBarContent", html.text x)
    /// Optional. Add any kind of toolbar to this render fragment.
    [<CustomOperation("ToolBarContent")>] member inline _.ToolBarContent ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("ToolBarContent", html.text x)
    /// Show a loading animation, if true.
    [<CustomOperation("Loading")>] member inline _.Loading ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("Loading" => x)
    /// The color of the loading progress if used. It supports the theme colors.
    [<CustomOperation("LoadingProgressColor")>] member inline _.LoadingProgressColor ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("LoadingProgressColor" => x)
    /// Add MudTh cells here to define the table header. If CustomHeader is set, add one or more MudTHeadRow instead.
    [<CustomOperation("HeaderContent")>] member inline _.HeaderContent ([<InlineIfLambda>] render: AttrRenderFragment, fragment) = render ==> html.renderFragment("HeaderContent", fragment)
    /// Add MudTh cells here to define the table header. If CustomHeader is set, add one or more MudTHeadRow instead.
    [<CustomOperation("HeaderContent")>] member inline _.HeaderContent ([<InlineIfLambda>] render: AttrRenderFragment, fragments) = render ==> html.renderFragment("HeaderContent", fragment { yield! fragments })
    /// Add MudTh cells here to define the table header. If CustomHeader is set, add one or more MudTHeadRow instead.
    [<CustomOperation("HeaderContent")>] member inline _.HeaderContent ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("HeaderContent", html.text x)
    /// Add MudTh cells here to define the table header. If CustomHeader is set, add one or more MudTHeadRow instead.
    [<CustomOperation("HeaderContent")>] member inline _.HeaderContent ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("HeaderContent", html.text x)
    /// Add MudTh cells here to define the table header. If CustomHeader is set, add one or more MudTHeadRow instead.
    [<CustomOperation("HeaderContent")>] member inline _.HeaderContent ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("HeaderContent", html.text x)
    /// Specify if the header has multiple rows. In that case, you need to provide the MudTHeadRow tags.
    [<CustomOperation("CustomHeader")>] member inline _.CustomHeader ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("CustomHeader" => x)
    /// Add a class to the thead tag
    [<CustomOperation("HeaderClass")>] member inline _.HeaderClass ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("HeaderClass" => x)
    /// Add MudTd cells here to define the table footer. IfCustomFooter is set, add one or more MudTFootRow instead.
    [<CustomOperation("FooterContent")>] member inline _.FooterContent ([<InlineIfLambda>] render: AttrRenderFragment, fragment) = render ==> html.renderFragment("FooterContent", fragment)
    /// Add MudTd cells here to define the table footer. IfCustomFooter is set, add one or more MudTFootRow instead.
    [<CustomOperation("FooterContent")>] member inline _.FooterContent ([<InlineIfLambda>] render: AttrRenderFragment, fragments) = render ==> html.renderFragment("FooterContent", fragment { yield! fragments })
    /// Add MudTd cells here to define the table footer. IfCustomFooter is set, add one or more MudTFootRow instead.
    [<CustomOperation("FooterContent")>] member inline _.FooterContent ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("FooterContent", html.text x)
    /// Add MudTd cells here to define the table footer. IfCustomFooter is set, add one or more MudTFootRow instead.
    [<CustomOperation("FooterContent")>] member inline _.FooterContent ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("FooterContent", html.text x)
    /// Add MudTd cells here to define the table footer. IfCustomFooter is set, add one or more MudTFootRow instead.
    [<CustomOperation("FooterContent")>] member inline _.FooterContent ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("FooterContent", html.text x)
    /// Specify if the footer has multiple rows. In that case, you need to provide the MudTFootRow tags.
    [<CustomOperation("CustomFooter")>] member inline _.CustomFooter ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("CustomFooter" => x)
    /// Add a class to the tfoot tag
    [<CustomOperation("FooterClass")>] member inline _.FooterClass ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("FooterClass" => x)
    /// Specifies a group of one or more columns in a table for formatting.
    /// Ex:
    /// table
    ///     colgroup
    ///        col span="2" style="background-color:red"
    ///        col style="background-color:yellow"
    ///      colgroup
    ///      header
    ///      body
    /// table
    [<CustomOperation("ColGroup")>] member inline _.ColGroup ([<InlineIfLambda>] render: AttrRenderFragment, fragment) = render ==> html.renderFragment("ColGroup", fragment)
    /// Specifies a group of one or more columns in a table for formatting.
    /// Ex:
    /// table
    ///     colgroup
    ///        col span="2" style="background-color:red"
    ///        col style="background-color:yellow"
    ///      colgroup
    ///      header
    ///      body
    /// table
    [<CustomOperation("ColGroup")>] member inline _.ColGroup ([<InlineIfLambda>] render: AttrRenderFragment, fragments) = render ==> html.renderFragment("ColGroup", fragment { yield! fragments })
    /// Specifies a group of one or more columns in a table for formatting.
    /// Ex:
    /// table
    ///     colgroup
    ///        col span="2" style="background-color:red"
    ///        col style="background-color:yellow"
    ///      colgroup
    ///      header
    ///      body
    /// table
    [<CustomOperation("ColGroup")>] member inline _.ColGroup ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("ColGroup", html.text x)
    /// Specifies a group of one or more columns in a table for formatting.
    /// Ex:
    /// table
    ///     colgroup
    ///        col span="2" style="background-color:red"
    ///        col style="background-color:yellow"
    ///      colgroup
    ///      header
    ///      body
    /// table
    [<CustomOperation("ColGroup")>] member inline _.ColGroup ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("ColGroup", html.text x)
    /// Specifies a group of one or more columns in a table for formatting.
    /// Ex:
    /// table
    ///     colgroup
    ///        col span="2" style="background-color:red"
    ///        col style="background-color:yellow"
    ///      colgroup
    ///      header
    ///      body
    /// table
    [<CustomOperation("ColGroup")>] member inline _.ColGroup ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("ColGroup", html.text x)
    /// Add MudTablePager here to enable breaking the rows in to multiple pages.
    [<CustomOperation("PagerContent")>] member inline _.PagerContent ([<InlineIfLambda>] render: AttrRenderFragment, fragment) = render ==> html.renderFragment("PagerContent", fragment)
    /// Add MudTablePager here to enable breaking the rows in to multiple pages.
    [<CustomOperation("PagerContent")>] member inline _.PagerContent ([<InlineIfLambda>] render: AttrRenderFragment, fragments) = render ==> html.renderFragment("PagerContent", fragment { yield! fragments })
    /// Add MudTablePager here to enable breaking the rows in to multiple pages.
    [<CustomOperation("PagerContent")>] member inline _.PagerContent ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("PagerContent", html.text x)
    /// Add MudTablePager here to enable breaking the rows in to multiple pages.
    [<CustomOperation("PagerContent")>] member inline _.PagerContent ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("PagerContent", html.text x)
    /// Add MudTablePager here to enable breaking the rows in to multiple pages.
    [<CustomOperation("PagerContent")>] member inline _.PagerContent ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("PagerContent", html.text x)
    /// Locks Inline Edit mode, if true.
    [<CustomOperation("ReadOnly")>] member inline _.ReadOnly ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("ReadOnly" => x)
    /// Button commit edit click event.
    [<CustomOperation("OnCommitEditClick")>] member inline _.OnCommitEditClick ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>("OnCommitEditClick", fn)
    /// Button commit edit click event.
    [<CustomOperation("OnCommitEditClick")>] member inline _.OnCommitEditClick ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callbackTask<Microsoft.AspNetCore.Components.Web.MouseEventArgs>("OnCommitEditClick", fn)
    /// Button cancel edit click event.
    [<CustomOperation("OnCancelEditClick")>] member inline _.OnCancelEditClick ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>("OnCancelEditClick", fn)
    /// Button cancel edit click event.
    [<CustomOperation("OnCancelEditClick")>] member inline _.OnCancelEditClick ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callbackTask<Microsoft.AspNetCore.Components.Web.MouseEventArgs>("OnCancelEditClick", fn)
    /// Event is called before the item is modified in inline editing.
    [<CustomOperation("OnPreviewEditClick")>] member inline _.OnPreviewEditClick ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callback<System.Object>("OnPreviewEditClick", fn)
    /// Event is called before the item is modified in inline editing.
    [<CustomOperation("OnPreviewEditClick")>] member inline _.OnPreviewEditClick ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callbackTask<System.Object>("OnPreviewEditClick", fn)
    /// Command executed when the user clicks on the CommitEdit Button.
    [<CustomOperation("CommitEditCommand")>] member inline _.CommitEditCommand ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Windows.Input.ICommand) = render ==> ("CommitEditCommand" => x)
    /// Command parameter for the CommitEdit Button. By default, will be the row level item model, if you won't set anything else.
    [<CustomOperation("CommitEditCommandParameter")>] member inline _.CommitEditCommandParameter ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Object) = render ==> ("CommitEditCommandParameter" => x)
    /// Tooltip for the CommitEdit Button.
    [<CustomOperation("CommitEditTooltip")>] member inline _.CommitEditTooltip ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("CommitEditTooltip" => x)
    /// Tooltip for the CancelEdit Button.
    [<CustomOperation("CancelEditTooltip")>] member inline _.CancelEditTooltip ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("CancelEditTooltip" => x)
    /// Sets the Icon of the CommitEdit Button.
    [<CustomOperation("CommitEditIcon")>] member inline _.CommitEditIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("CommitEditIcon" => x)
    /// Sets the Icon of the CancelEdit Button.
    [<CustomOperation("CancelEditIcon")>] member inline _.CancelEditIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("CancelEditIcon" => x)
    /// Define if Cancel button is present or not for inline editing.
    [<CustomOperation("CanCancelEdit")>] member inline _.CanCancelEdit ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("CanCancelEdit" => x)
    /// Set the positon of the CommitEdit and CancelEdit button, if IsEditable IsEditable is true. Defaults to the end of the row
    [<CustomOperation("ApplyButtonPosition")>] member inline _.ApplyButtonPosition ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.TableApplyButtonPosition) = render ==> ("ApplyButtonPosition" => x)
    /// Set the positon of the StartEdit button, if IsEditable IsEditable is true. Defaults to the end of the row
    [<CustomOperation("EditButtonPosition")>] member inline _.EditButtonPosition ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.TableEditButtonPosition) = render ==> ("EditButtonPosition" => x)
    /// Defines how a table row edit will be triggered
    [<CustomOperation("EditTrigger")>] member inline _.EditTrigger ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.TableEditTrigger) = render ==> ("EditTrigger" => x)
    /// Defines the edit button that will be rendered when EditTrigger.EditButton
    [<CustomOperation("EditButtonContent")>] member inline _.EditButtonContent ([<InlineIfLambda>] render: AttrRenderFragment, fn: MudBlazorFix.EditButtonContext -> NodeRenderFragment) = render ==> html.renderFragment("EditButtonContent", fn)
    /// The method is called before the item is modified in inline editing.
    [<CustomOperation("RowEditPreview")>] member inline _.RowEditPreview ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("RowEditPreview" => (System.Action<System.Object>fn))
    /// The method is called when the edition of the item has been committed in inline editing.
    [<CustomOperation("RowEditCommit")>] member inline _.RowEditCommit ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("RowEditCommit" => (System.Action<System.Object>fn))
    /// The method is called when the edition of the item has been canceled in inline editing.
    [<CustomOperation("RowEditCancel")>] member inline _.RowEditCancel ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("RowEditCancel" => (System.Action<System.Object>fn))
    /// Number of items. Used only with ServerData="true"
    [<CustomOperation("TotalItems")>] member inline _.TotalItems ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("TotalItems" => x)
    /// CSS class for the table rows. Note, many CSS settings are overridden by MudTd though
    [<CustomOperation("RowClass")>] member inline _.RowClass ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("RowClass" => x)
    /// CSS styles for the table rows. Note, many CSS settings are overridden by MudTd though
    [<CustomOperation("RowStyle")>] member inline _.RowStyle ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("RowStyle" => x)
    /// If true, the results are displayed in a Virtualize component, allowing a boost in rendering speed.
    [<CustomOperation("Virtualize")>] member inline _.Virtualize ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("Virtualize" => x)
    /// Gets or sets a value that determines how many additional items will be rendered
    /// before and after the visible region. This help to reduce the frequency of rendering
    /// during scrolling. However, higher values mean that more elements will be present
    /// in the page.
    [<CustomOperation("OverscanCount")>] member inline _.OverscanCount ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("OverscanCount" => x)

type MudTableBuilder<'FunBlazorGeneric, 'T when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudTableBaseBuilder<'FunBlazorGeneric>()
    /// Defines how a table row looks like. Use MudTd to define the table cells and their content.
    [<CustomOperation("RowTemplate")>] member inline _.RowTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fn: 'T -> NodeRenderFragment) = render ==> html.renderFragment("RowTemplate", fn)
    /// Row Child content of the component.
    [<CustomOperation("ChildRowContent")>] member inline _.ChildRowContent ([<InlineIfLambda>] render: AttrRenderFragment, fn: 'T -> NodeRenderFragment) = render ==> html.renderFragment("ChildRowContent", fn)
    /// Defines how a table row looks like in edit mode (for selected row). Use MudTd to define the table cells and their content.
    [<CustomOperation("RowEditingTemplate")>] member inline _.RowEditingTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fn: 'T -> NodeRenderFragment) = render ==> html.renderFragment("RowEditingTemplate", fn)
    /// Defines how a table column looks like. Columns components should inherit from MudBaseColumn
    [<CustomOperation("Columns")>] member inline _.Columns ([<InlineIfLambda>] render: AttrRenderFragment, fn: 'T -> NodeRenderFragment) = render ==> html.renderFragment("Columns", fn)
    /// Comma separated list of columns to show if there is no templates defined
    [<CustomOperation("QuickColumns")>] member inline _.QuickColumns ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("QuickColumns" => x)
    /// Defines the table body content when there are no matching records found
    [<CustomOperation("NoRecordsContent")>] member inline _.NoRecordsContent ([<InlineIfLambda>] render: AttrRenderFragment, fragment) = render ==> html.renderFragment("NoRecordsContent", fragment)
    /// Defines the table body content when there are no matching records found
    [<CustomOperation("NoRecordsContent")>] member inline _.NoRecordsContent ([<InlineIfLambda>] render: AttrRenderFragment, fragments) = render ==> html.renderFragment("NoRecordsContent", fragment { yield! fragments })
    /// Defines the table body content when there are no matching records found
    [<CustomOperation("NoRecordsContent")>] member inline _.NoRecordsContent ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("NoRecordsContent", html.text x)
    /// Defines the table body content when there are no matching records found
    [<CustomOperation("NoRecordsContent")>] member inline _.NoRecordsContent ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("NoRecordsContent", html.text x)
    /// Defines the table body content when there are no matching records found
    [<CustomOperation("NoRecordsContent")>] member inline _.NoRecordsContent ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("NoRecordsContent", html.text x)
    /// Defines the table body content  the table has no rows and is loading
    [<CustomOperation("LoadingContent")>] member inline _.LoadingContent ([<InlineIfLambda>] render: AttrRenderFragment, fragment) = render ==> html.renderFragment("LoadingContent", fragment)
    /// Defines the table body content  the table has no rows and is loading
    [<CustomOperation("LoadingContent")>] member inline _.LoadingContent ([<InlineIfLambda>] render: AttrRenderFragment, fragments) = render ==> html.renderFragment("LoadingContent", fragment { yield! fragments })
    /// Defines the table body content  the table has no rows and is loading
    [<CustomOperation("LoadingContent")>] member inline _.LoadingContent ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("LoadingContent", html.text x)
    /// Defines the table body content  the table has no rows and is loading
    [<CustomOperation("LoadingContent")>] member inline _.LoadingContent ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("LoadingContent", html.text x)
    /// Defines the table body content  the table has no rows and is loading
    [<CustomOperation("LoadingContent")>] member inline _.LoadingContent ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("LoadingContent", html.text x)
    /// Defines if the table has a horizontal scrollbar.
    [<CustomOperation("HorizontalScrollbar")>] member inline _.HorizontalScrollbar ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("HorizontalScrollbar" => x)
    /// The data to display in the table. MudTable will render one row per item
    [<CustomOperation("Items")>] member inline _.Items ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.IEnumerable<'T>) = render ==> ("Items" => x)
    /// A function that returns whether or not an item should be displayed in the table. You can use this to implement your own search function.
    [<CustomOperation("Filter")>] member inline _.Filter ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("Filter" => (System.Func<'T, System.Boolean>fn))
    /// Row click event.
    [<CustomOperation("OnRowClick")>] member inline _.OnRowClick ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callback<MudBlazor.TableRowClickEventArgs<'T>>("OnRowClick", fn)
    /// Row click event.
    [<CustomOperation("OnRowClick")>] member inline _.OnRowClick ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callbackTask<MudBlazor.TableRowClickEventArgs<'T>>("OnRowClick", fn)
    /// Returns the class that will get joined with RowClass. Takes the current item and row index.
    [<CustomOperation("RowClassFunc")>] member inline _.RowClassFunc ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("RowClassFunc" => (System.Func<'T, System.Int32, System.String>fn))
    /// Returns the style that will get joined with RowStyle. Takes the current item and row index.
    [<CustomOperation("RowStyleFunc")>] member inline _.RowStyleFunc ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("RowStyleFunc" => (System.Func<'T, System.Int32, System.String>fn))
    /// Returns the item which was last clicked on in single selection mode (that is, if MultiSelection is false)
    [<CustomOperation("SelectedItem")>] member inline _.SelectedItem ([<InlineIfLambda>] render: AttrRenderFragment, x: 'T) = render ==> ("SelectedItem" => x)
    /// Returns the item which was last clicked on in single selection mode (that is, if MultiSelection is false)
    [<CustomOperation("SelectedItem'")>] member inline _.SelectedItem' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: 'T * ('T -> unit)) = render ==> html.bind("SelectedItem", valueFn)
    /// Callback is called when a row has been clicked and returns the selected item.
    [<CustomOperation("SelectedItemChanged")>] member inline _.SelectedItemChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callback<'T>("SelectedItemChanged", fn)
    /// Callback is called when a row has been clicked and returns the selected item.
    [<CustomOperation("SelectedItemChanged")>] member inline _.SelectedItemChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callbackTask<'T>("SelectedItemChanged", fn)
    /// If MultiSelection is true, this returns the currently selected items. You can bind this property and the initial content of the HashSet you bind it to will cause these rows to be selected initially.
    [<CustomOperation("SelectedItems")>] member inline _.SelectedItems ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.HashSet<'T>) = render ==> ("SelectedItems" => x)
    /// If MultiSelection is true, this returns the currently selected items. You can bind this property and the initial content of the HashSet you bind it to will cause these rows to be selected initially.
    [<CustomOperation("SelectedItems'")>] member inline _.SelectedItems' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.Collections.Generic.HashSet<'T> * (System.Collections.Generic.HashSet<'T> -> unit)) = render ==> html.bind("SelectedItems", valueFn)
    /// The Comparer to use for comparing selected items internally.
    [<CustomOperation("Comparer")>] member inline _.Comparer ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.IEqualityComparer<'T>) = render ==> ("Comparer" => x)
    /// Callback is called whenever items are selected or deselected in multi selection mode.
    [<CustomOperation("SelectedItemsChanged")>] member inline _.SelectedItemsChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callback<System.Collections.Generic.HashSet<'T>>("SelectedItemsChanged", fn)
    /// Callback is called whenever items are selected or deselected in multi selection mode.
    [<CustomOperation("SelectedItemsChanged")>] member inline _.SelectedItemsChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callbackTask<System.Collections.Generic.HashSet<'T>>("SelectedItemsChanged", fn)
    /// Defines data grouping parameters. It can has N hierarchical levels
    [<CustomOperation("GroupBy")>] member inline _.GroupBy ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.TableGroupDefinition<'T>) = render ==> ("GroupBy" => x)
    /// Defines how a table grouping row header looks like. It works only when GroupBy is not null. Use MudTd to define the table cells and their content.
    [<CustomOperation("GroupHeaderTemplate")>] member inline _.GroupHeaderTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fn: MudBlazor.TableGroupData<System.Object, 'T> -> NodeRenderFragment) = render ==> html.renderFragment("GroupHeaderTemplate", fn)
    /// Defines custom CSS classes for using on Group Header's MudTr.
    [<CustomOperation("GroupHeaderClass")>] member inline _.GroupHeaderClass ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("GroupHeaderClass" => x)
    /// Defines custom styles for using on Group Header's MudTr.
    [<CustomOperation("GroupHeaderStyle")>] member inline _.GroupHeaderStyle ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("GroupHeaderStyle" => x)
    /// Defines custom CSS classes for using on Group Footer's MudTr.
    [<CustomOperation("GroupFooterClass")>] member inline _.GroupFooterClass ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("GroupFooterClass" => x)
    /// Defines custom styles for using on Group Footer's MudTr.
    [<CustomOperation("GroupFooterStyle")>] member inline _.GroupFooterStyle ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("GroupFooterStyle" => x)
    /// Defines how a table grouping row footer looks like. It works only when GroupBy is not null. Use MudTd to define the table cells and their content.
    [<CustomOperation("GroupFooterTemplate")>] member inline _.GroupFooterTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fn: MudBlazor.TableGroupData<System.Object, 'T> -> NodeRenderFragment) = render ==> html.renderFragment("GroupFooterTemplate", fn)
    /// Supply an async function which (re)loads filtered, paginated and sorted data from server.
    /// Table will await this func and update based on the returned TableData.
    /// Used only with ServerData
    [<CustomOperation("ServerData")>] member inline _.ServerData ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("ServerData" => (System.Func<MudBlazor.TableState, System.Threading.Tasks.Task<MudBlazor.TableData<'T>>>fn))

type MudTabsBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    /// If true, render all tabs and hide (display:none) every non-active.
    [<CustomOperation("KeepPanelsAlive")>] member inline _.KeepPanelsAlive ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("KeepPanelsAlive" => x)
    /// If true, sets the border-radius to theme default.
    [<CustomOperation("Rounded")>] member inline _.Rounded ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("Rounded" => x)
    /// If true, sets a border between the content and the toolbar depending on the position.
    [<CustomOperation("Border")>] member inline _.Border ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("Border" => x)
    /// If true, toolbar will be outlined.
    [<CustomOperation("Outlined")>] member inline _.Outlined ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("Outlined" => x)
    /// If true, centers the tabitems.
    [<CustomOperation("Centered")>] member inline _.Centered ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("Centered" => x)
    /// Hides the active tab slider.
    [<CustomOperation("HideSlider")>] member inline _.HideSlider ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("HideSlider" => x)
    /// Icon to use for left pagination.
    [<CustomOperation("PrevIcon")>] member inline _.PrevIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("PrevIcon" => x)
    /// Icon to use for right pagination.
    [<CustomOperation("NextIcon")>] member inline _.NextIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("NextIcon" => x)
    /// If true, always display the scroll buttons even if the tabs are smaller than the required with, buttons will be disabled if there is nothing to scroll.
    [<CustomOperation("AlwaysShowScrollButtons")>] member inline _.AlwaysShowScrollButtons ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("AlwaysShowScrollButtons" => x)
    /// Sets the maxheight the component can have.
    [<CustomOperation("MaxHeight")>] member inline _.MaxHeight ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Int32>) = render ==> ("MaxHeight" => x)
    /// Sets the min-wdth of the tabs. 160px by default.
    [<CustomOperation("MinimumTabWidth")>] member inline _.MinimumTabWidth ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("MinimumTabWidth" => x)
    /// Sets the position of the tabs itself.
    [<CustomOperation("Position")>] member inline _.Position ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Position) = render ==> ("Position" => x)
    /// The color of the component. It supports the theme colors.
    [<CustomOperation("Color")>] member inline _.Color ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("Color" => x)
    /// The color of the tab slider. It supports the theme colors.
    [<CustomOperation("SliderColor")>] member inline _.SliderColor ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("SliderColor" => x)
    /// The color of the icon. It supports the theme colors.
    [<CustomOperation("IconColor")>] member inline _.IconColor ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("IconColor" => x)
    /// The color of the next/prev icons. It supports the theme colors.
    [<CustomOperation("ScrollIconColor")>] member inline _.ScrollIconColor ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("ScrollIconColor" => x)
    /// The higher the number, the heavier the drop-shadow, applies around the whole component.
    [<CustomOperation("Elevation")>] member inline _.Elevation ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("Elevation" => x)
    /// If true, will apply elevation, rounded, outlined effects to the whole tab component instead of just toolbar.
    [<CustomOperation("ApplyEffectsToContainer")>] member inline _.ApplyEffectsToContainer ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("ApplyEffectsToContainer" => x)
    /// If true, disables ripple effect.
    [<CustomOperation("DisableRipple")>] member inline _.DisableRipple ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("DisableRipple" => x)
    /// If true, disables slider animation
    [<CustomOperation("DisableSliderAnimation")>] member inline _.DisableSliderAnimation ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("DisableSliderAnimation" => x)
    /// This fragment is placed between toolbar and panels. 
    /// It can be used to display additional content like an address line in a browser.
    /// The active tab will be the content of this RenderFragement
    [<CustomOperation("PrePanelContent")>] member inline _.PrePanelContent ([<InlineIfLambda>] render: AttrRenderFragment, fn: MudBlazor.MudTabPanel -> NodeRenderFragment) = render ==> html.renderFragment("PrePanelContent", fn)
    /// Custom class/classes for TabPanel
    [<CustomOperation("TabPanelClass")>] member inline _.TabPanelClass ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("TabPanelClass" => x)
    /// Custom class/classes for Selected Content Panel
    [<CustomOperation("PanelClass")>] member inline _.PanelClass ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("PanelClass" => x)
    /// The current active panel index. Also with Bidirectional Binding
    [<CustomOperation("ActivePanelIndex")>] member inline _.ActivePanelIndex ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("ActivePanelIndex" => x)
    /// The current active panel index. Also with Bidirectional Binding
    [<CustomOperation("ActivePanelIndex'")>] member inline _.ActivePanelIndex' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.Int32 * (System.Int32 -> unit)) = render ==> html.bind("ActivePanelIndex", valueFn)
    /// Fired when ActivePanelIndex changes.
    [<CustomOperation("ActivePanelIndexChanged")>] member inline _.ActivePanelIndexChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callback<System.Int32>("ActivePanelIndexChanged", fn)
    /// Fired when ActivePanelIndex changes.
    [<CustomOperation("ActivePanelIndexChanged")>] member inline _.ActivePanelIndexChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callbackTask<System.Int32>("ActivePanelIndexChanged", fn)
    /// A render fragment that is added before or after (based on the value of HeaderPosition) the tabs inside the header panel of the tab control
    [<CustomOperation("Header")>] member inline _.Header ([<InlineIfLambda>] render: AttrRenderFragment, fn: MudBlazor.MudTabs -> NodeRenderFragment) = render ==> html.renderFragment("Header", fn)
    /// Additional content specified by Header is placed either before the tabs, after or not at all
    [<CustomOperation("HeaderPosition")>] member inline _.HeaderPosition ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.TabHeaderPosition) = render ==> ("HeaderPosition" => x)
    /// A render fragment that is added before or after (based on the value of HeaderPosition) inside each tab panel
    [<CustomOperation("TabPanelHeader")>] member inline _.TabPanelHeader ([<InlineIfLambda>] render: AttrRenderFragment, fn: MudBlazor.MudTabPanel -> NodeRenderFragment) = render ==> html.renderFragment("TabPanelHeader", fn)
    /// Additional content specified by Header is placed either before the tabs, after or not at all
    [<CustomOperation("TabPanelHeaderPosition")>] member inline _.TabPanelHeaderPosition ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.TabHeaderPosition) = render ==> ("TabPanelHeaderPosition" => x)
    /// Fired when a panel gets activated. Returned Task will be awaited.
    [<CustomOperation("OnPreviewInteraction")>] member inline _.OnPreviewInteraction ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("OnPreviewInteraction" => (System.Func<MudBlazor.TabInteractionEventArgs, System.Threading.Tasks.Task>fn))

type MudDynamicTabsBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudTabsBuilder<'FunBlazorGeneric>()
    /// The icon used for the add button
    [<CustomOperation("AddTabIcon")>] member inline _.AddTabIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("AddTabIcon" => x)
    /// The icon used for the close button
    [<CustomOperation("CloseTabIcon")>] member inline _.CloseTabIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("CloseTabIcon" => x)
    /// The callback, when the add button has been clicked
    [<CustomOperation("AddTab")>] member inline _.AddTab ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callback("AddTab", fn)
    /// The callback, when the add button has been clicked
    [<CustomOperation("AddTab")>] member inline _.AddTab ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callbackTask("AddTab", fn)
    /// The callback, when the close button has been clicked
    [<CustomOperation("CloseTab")>] member inline _.CloseTab ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callback<MudBlazor.MudTabPanel>("CloseTab", fn)
    /// The callback, when the close button has been clicked
    [<CustomOperation("CloseTab")>] member inline _.CloseTab ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callbackTask<MudBlazor.MudTabPanel>("CloseTab", fn)
    /// Classes that are applied to the icon button of the add button
    [<CustomOperation("AddIconClass")>] member inline _.AddIconClass ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("AddIconClass" => x)
    /// Styles that are applied to the icon button of the add button
    [<CustomOperation("AddIconStyle")>] member inline _.AddIconStyle ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("AddIconStyle" => x)
    /// Classes that are applied to the icon button of the close button
    [<CustomOperation("CloseIconClass")>] member inline _.CloseIconClass ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("CloseIconClass" => x)
    /// Styles that are applied to the icon button of the close button
    [<CustomOperation("CloseIconStyle")>] member inline _.CloseIconStyle ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("CloseIconStyle" => x)
    /// Tooltip that shown when a user hovers of the add button. Empty or null, if no tooltip should be visible
    [<CustomOperation("AddIconToolTip")>] member inline _.AddIconToolTip ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("AddIconToolTip" => x)
    /// Tooltip that shown when a user hovers of the close button. Empty or null, if no tooltip should be visible
    [<CustomOperation("CloseIconToolTip")>] member inline _.CloseIconToolTip ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("CloseIconToolTip" => x)

type MudChartBaseBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("InputData")>] member inline _.InputData ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Double[]) = render ==> ("InputData" => x)
    [<CustomOperation("InputLabels")>] member inline _.InputLabels ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String[]) = render ==> ("InputLabels" => x)
    [<CustomOperation("XAxisLabels")>] member inline _.XAxisLabels ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String[]) = render ==> ("XAxisLabels" => x)
    [<CustomOperation("ChartSeries")>] member inline _.ChartSeries ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.List<MudBlazor.ChartSeries>) = render ==> ("ChartSeries" => x)
    [<CustomOperation("ChartOptions")>] member inline _.ChartOptions ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.ChartOptions) = render ==> ("ChartOptions" => x)
    /// RenderFragment for costumization inside the chart's svg.
    [<CustomOperation("CustomGraphics")>] member inline _.CustomGraphics ([<InlineIfLambda>] render: AttrRenderFragment, fragment) = render ==> html.renderFragment("CustomGraphics", fragment)
    /// RenderFragment for costumization inside the chart's svg.
    [<CustomOperation("CustomGraphics")>] member inline _.CustomGraphics ([<InlineIfLambda>] render: AttrRenderFragment, fragments) = render ==> html.renderFragment("CustomGraphics", fragment { yield! fragments })
    /// RenderFragment for costumization inside the chart's svg.
    [<CustomOperation("CustomGraphics")>] member inline _.CustomGraphics ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("CustomGraphics", html.text x)
    /// RenderFragment for costumization inside the chart's svg.
    [<CustomOperation("CustomGraphics")>] member inline _.CustomGraphics ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("CustomGraphics", html.text x)
    /// RenderFragment for costumization inside the chart's svg.
    [<CustomOperation("CustomGraphics")>] member inline _.CustomGraphics ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("CustomGraphics", html.text x)
    /// The Type of the chart.
    [<CustomOperation("ChartType")>] member inline _.ChartType ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.ChartType) = render ==> ("ChartType" => x)
    /// The Width of the chart, end with % or px.
    [<CustomOperation("Width")>] member inline _.Width ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Width" => x)
    /// The Height of the chart, end with % or px.
    [<CustomOperation("Height")>] member inline _.Height ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Height" => x)
    /// The placement direction of the legend if used.
    [<CustomOperation("LegendPosition")>] member inline _.LegendPosition ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Position) = render ==> ("LegendPosition" => x)
    /// Selected index of a portion of the chart.
    [<CustomOperation("SelectedIndex")>] member inline _.SelectedIndex ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("SelectedIndex" => x)
    /// Selected index of a portion of the chart.
    [<CustomOperation("SelectedIndex'")>] member inline _.SelectedIndex' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.Int32 * (System.Int32 -> unit)) = render ==> html.bind("SelectedIndex", valueFn)
    /// Selected index of a portion of the chart.
    [<CustomOperation("SelectedIndexChanged")>] member inline _.SelectedIndexChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callback<System.Int32>("SelectedIndexChanged", fn)
    /// Selected index of a portion of the chart.
    [<CustomOperation("SelectedIndexChanged")>] member inline _.SelectedIndexChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callbackTask<System.Int32>("SelectedIndexChanged", fn)

type MudChartBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudChartBaseBuilder<'FunBlazorGeneric>()


            
namespace rec MudBlazor.DslInternals.Charts

open FSharp.Data.Adaptive
open Fun.Blazor
open Fun.Blazor.Operators
open MudBlazor.DslInternals

type BarBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudChartBaseBuilder<'FunBlazorGeneric>()


type DonutBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudChartBaseBuilder<'FunBlazorGeneric>()


type LineBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudChartBaseBuilder<'FunBlazorGeneric>()


type PieBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudChartBaseBuilder<'FunBlazorGeneric>()


type LegendBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudChartBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Data")>] member inline _.Data ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.List<MudBlazor.Charts.SVG.Models.SvgLegend>) = render ==> ("Data" => x)

            
namespace rec MudBlazor.DslInternals

open FSharp.Data.Adaptive
open Fun.Blazor
open Fun.Blazor.Operators
open MudBlazor.DslInternals

type MudBaseItemsControlBuilder<'FunBlazorGeneric, 'TChildComponent when 'TChildComponent :> MudBlazor.MudComponentBase and 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    /// Selected Item's index
    [<CustomOperation("SelectedIndex")>] member inline _.SelectedIndex ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("SelectedIndex" => x)
    /// Selected Item's index
    [<CustomOperation("SelectedIndex'")>] member inline _.SelectedIndex' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.Int32 * (System.Int32 -> unit)) = render ==> html.bind("SelectedIndex", valueFn)
    [<CustomOperation("SelectedIndexChanged")>] member inline _.SelectedIndexChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callback<System.Int32>("SelectedIndexChanged", fn)
    [<CustomOperation("SelectedIndexChanged")>] member inline _.SelectedIndexChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callbackTask<System.Int32>("SelectedIndexChanged", fn)

type MudBaseBindableItemsControlBuilder<'FunBlazorGeneric, 'TChildComponent, 'TData when 'TChildComponent :> MudBlazor.MudComponentBase and 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudBaseItemsControlBuilder<'FunBlazorGeneric, 'TChildComponent>()
    /// Items Collection - For databinding usage
    [<CustomOperation("ItemsSource")>] member inline _.ItemsSource ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.IEnumerable<'TData>) = render ==> ("ItemsSource" => x)
    /// Template for each Item in ItemsSource collection
    [<CustomOperation("ItemTemplate")>] member inline _.ItemTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fn: 'TData -> NodeRenderFragment) = render ==> html.renderFragment("ItemTemplate", fn)

type MudCarouselBuilder<'FunBlazorGeneric, 'TData when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudBaseBindableItemsControlBuilder<'FunBlazorGeneric, MudBlazor.MudCarouselItem, 'TData>()
    /// Gets or Sets if 'Next' and 'Previous' arrows must be visible
    [<CustomOperation("ShowArrows")>] member inline _.ShowArrows ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("ShowArrows" => x)
    /// Sets the position of the arrows. By default, the position is the Center position
    [<CustomOperation("ArrowsPosition")>] member inline _.ArrowsPosition ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Position) = render ==> ("ArrowsPosition" => x)
    /// Gets or Sets if bar with Bullets must be visible
    [<CustomOperation("ShowBullets")>] member inline _.ShowBullets ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("ShowBullets" => x)
    /// Sets the position of the bullets. By default, the position is the Bottom position
    [<CustomOperation("BulletsPosition")>] member inline _.BulletsPosition ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Position) = render ==> ("BulletsPosition" => x)
    /// Gets or Sets the Bullets color.
    /// If not set, the color is determined based on the Color property of the active child.
    [<CustomOperation("BulletsColor")>] member inline _.BulletsColor ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<MudBlazor.Color>) = render ==> ("BulletsColor" => x)
    /// Gets or Sets if bottom bar with Delimiters must be visible.
    /// Deprecated, use ShowBullets instead.
    [<CustomOperation("ShowDelimiters")>] member inline _.ShowDelimiters ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("ShowDelimiters" => x)
    /// Gets or Sets the Delimiters color.
    /// If not set, the color is determined based on the Color property of the active child.
    /// Deprecated, use BulletsColor instead.
    [<CustomOperation("DelimitersColor")>] member inline _.DelimitersColor ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<MudBlazor.Color>) = render ==> ("DelimitersColor" => x)
    /// Gets or Sets automatic cycle on item collection.
    [<CustomOperation("AutoCycle")>] member inline _.AutoCycle ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("AutoCycle" => x)
    /// Gets or Sets the Auto Cycle time
    [<CustomOperation("AutoCycleTime")>] member inline _.AutoCycleTime ([<InlineIfLambda>] render: AttrRenderFragment, x: System.TimeSpan) = render ==> ("AutoCycleTime" => x)
    /// Gets or Sets custom class(es) for 'Next' and 'Previous' arrows
    [<CustomOperation("NavigationButtonsClass")>] member inline _.NavigationButtonsClass ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("NavigationButtonsClass" => x)
    /// Gets or Sets custom class(es) for Bullets buttons
    [<CustomOperation("BulletsClass")>] member inline _.BulletsClass ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("BulletsClass" => x)
    /// Gets or Sets custom class(es) for Delimiters buttons.
    /// Deprecated, use BulletsClass instead.
    [<CustomOperation("DelimitersClass")>] member inline _.DelimitersClass ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("DelimitersClass" => x)
    /// Custom previous navigation icon.
    [<CustomOperation("PreviousIcon")>] member inline _.PreviousIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("PreviousIcon" => x)
    /// Custom selected bullet icon.
    [<CustomOperation("CheckedIcon")>] member inline _.CheckedIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("CheckedIcon" => x)
    /// Custom unselected bullet icon.
    [<CustomOperation("UncheckedIcon")>] member inline _.UncheckedIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("UncheckedIcon" => x)
    /// Custom next navigation icon.
    [<CustomOperation("NextIcon")>] member inline _.NextIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("NextIcon" => x)
    /// Gets or Sets the Template for the Left Arrow
    [<CustomOperation("NextButtonTemplate")>] member inline _.NextButtonTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragment) = render ==> html.renderFragment("NextButtonTemplate", fragment)
    /// Gets or Sets the Template for the Left Arrow
    [<CustomOperation("NextButtonTemplate")>] member inline _.NextButtonTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragments) = render ==> html.renderFragment("NextButtonTemplate", fragment { yield! fragments })
    /// Gets or Sets the Template for the Left Arrow
    [<CustomOperation("NextButtonTemplate")>] member inline _.NextButtonTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("NextButtonTemplate", html.text x)
    /// Gets or Sets the Template for the Left Arrow
    [<CustomOperation("NextButtonTemplate")>] member inline _.NextButtonTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("NextButtonTemplate", html.text x)
    /// Gets or Sets the Template for the Left Arrow
    [<CustomOperation("NextButtonTemplate")>] member inline _.NextButtonTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("NextButtonTemplate", html.text x)
    /// Gets or Sets the Template for the Right Arrow
    [<CustomOperation("PreviousButtonTemplate")>] member inline _.PreviousButtonTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragment) = render ==> html.renderFragment("PreviousButtonTemplate", fragment)
    /// Gets or Sets the Template for the Right Arrow
    [<CustomOperation("PreviousButtonTemplate")>] member inline _.PreviousButtonTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragments) = render ==> html.renderFragment("PreviousButtonTemplate", fragment { yield! fragments })
    /// Gets or Sets the Template for the Right Arrow
    [<CustomOperation("PreviousButtonTemplate")>] member inline _.PreviousButtonTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("PreviousButtonTemplate", html.text x)
    /// Gets or Sets the Template for the Right Arrow
    [<CustomOperation("PreviousButtonTemplate")>] member inline _.PreviousButtonTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("PreviousButtonTemplate", html.text x)
    /// Gets or Sets the Template for the Right Arrow
    [<CustomOperation("PreviousButtonTemplate")>] member inline _.PreviousButtonTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("PreviousButtonTemplate", html.text x)
    /// Gets or Sets the Template for Bullets
    [<CustomOperation("BulletTemplate")>] member inline _.BulletTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.Boolean -> NodeRenderFragment) = render ==> html.renderFragment("BulletTemplate", fn)
    /// Gets or Sets if swipe gestures are allowed for touch devices.
    [<CustomOperation("EnableSwipeGesture")>] member inline _.EnableSwipeGesture ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("EnableSwipeGesture" => x)
    /// Gets or Sets the Template for Delimiters.
    /// Deprecated, use BulletsTemplate instead.
    [<CustomOperation("DelimiterTemplate")>] member inline _.DelimiterTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.Boolean -> NodeRenderFragment) = render ==> html.renderFragment("DelimiterTemplate", fn)

type MudTimelineBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudBaseItemsControlBuilder<'FunBlazorGeneric, MudBlazor.MudTimelineItem>()
    /// Sets the orientation of the timeline and its timeline items.
    [<CustomOperation("TimelineOrientation")>] member inline _.TimelineOrientation ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.TimelineOrientation) = render ==> ("TimelineOrientation" => x)
    /// The position the timeline itself and how the timeline items should be displayed.
    [<CustomOperation("TimelinePosition")>] member inline _.TimelinePosition ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.TimelinePosition) = render ==> ("TimelinePosition" => x)
    /// Aligns the dot and any item modifiers is changed, in default mode they are centered to the item.
    [<CustomOperation("TimelineAlign")>] member inline _.TimelineAlign ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.TimelineAlign) = render ==> ("TimelineAlign" => x)
    /// Reverse the order of TimelineItems when TimelinePosition is set to Alternate.
    [<CustomOperation("Reverse")>] member inline _.Reverse ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("Reverse" => x)
    /// If true, disables all TimelineItem modifiers, like adding a caret to a MudCard.
    [<CustomOperation("DisableModifiers")>] member inline _.DisableModifiers ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("DisableModifiers" => x)

type MudFormComponentBuilder<'FunBlazorGeneric, 'T, 'U when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    /// If true, this form input is required to be filled out.
    [<CustomOperation("Required")>] member inline _.Required ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("Required" => x)
    /// The error text that will be displayed if the input is not filled out but required.
    [<CustomOperation("RequiredError")>] member inline _.RequiredError ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("RequiredError" => x)
    /// The ErrorText that will be displayed if Error true.
    [<CustomOperation("ErrorText")>] member inline _.ErrorText ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("ErrorText" => x)
    /// If true, the label will be displayed in an error state.
    [<CustomOperation("Error")>] member inline _.Error ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("Error" => x)
    /// The ErrorId that will be used by aria-describedby if Error true
    [<CustomOperation("ErrorId")>] member inline _.ErrorId ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("ErrorId" => x)
    /// The generic converter of the component.
    [<CustomOperation("Converter")>] member inline _.Converter ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Converter<'T, 'U>) = render ==> ("Converter" => x)
    /// The culture of the component.
    [<CustomOperation("Culture")>] member inline _.Culture ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Globalization.CultureInfo) = render ==> ("Culture" => x)
    /// A validation func or a validation attribute. Supported types are:
    /// Func<T, bool> ... will output the standard error message "Invalid" if false
    /// Func<T, string> ... outputs the result as error message, no error if null 
    /// Func<T, IEnumerable< string >> ... outputs all the returned error messages, no error if empty
    /// Func<object, string, IEnumerable< string >> input Form.Model, Full Path of Member ... outputs all the returned error messages, no error if empty
    /// Func<T, Task< bool >> ... will output the standard error message "Invalid" if false
    /// Func<T, Task< string >> ... outputs the result as error message, no error if null
    /// Func<T, Task<IEnumerable< string >>> ... outputs all the returned error messages, no error if empty
    /// Func<object, string, Task<IEnumerable< string >>> input Form.Model, Full Path of Member ... outputs all the returned error messages, no error if empty
    /// System.ComponentModel.DataAnnotations.ValidationAttribute instances
    [<CustomOperation("Validation")>] member inline _.Validation ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Object) = render ==> ("Validation" => x)
    /// Specify an expression which returns the model's field for which validation messages should be displayed.
    [<CustomOperation("For'")>] member inline _.For' ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Linq.Expressions.Expression<System.Func<'T>>) = render ==> ("For" => x)

type MudBaseInputBuilder<'FunBlazorGeneric, 'T when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudFormComponentBuilder<'FunBlazorGeneric, 'T, System.String>()
    /// If true, the input element will be disabled.
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("Disabled" => x)
    /// If true, the input will be read-only.
    [<CustomOperation("ReadOnly")>] member inline _.ReadOnly ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("ReadOnly" => x)
    /// If true, the input will take up the full width of its container.
    [<CustomOperation("FullWidth")>] member inline _.FullWidth ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("FullWidth" => x)
    /// If true, the input will update the Value immediately on typing.
    /// If false, the Value is updated only on Enter.
    [<CustomOperation("Immediate")>] member inline _.Immediate ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("Immediate" => x)
    /// If true, the input will not have an underline.
    [<CustomOperation("DisableUnderLine")>] member inline _.DisableUnderLine ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("DisableUnderLine" => x)
    /// The HelperText will be displayed below the text field.
    [<CustomOperation("HelperText")>] member inline _.HelperText ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("HelperText" => x)
    /// If true, the helper text will only be visible on focus.
    [<CustomOperation("HelperTextOnFocus")>] member inline _.HelperTextOnFocus ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("HelperTextOnFocus" => x)
    /// Icon that will be used if Adornment is set to Start or End.
    [<CustomOperation("AdornmentIcon")>] member inline _.AdornmentIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("AdornmentIcon" => x)
    /// Text that will be used if Adornment is set to Start or End, the Text overrides Icon.
    [<CustomOperation("AdornmentText")>] member inline _.AdornmentText ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("AdornmentText" => x)
    /// The Adornment if used. By default, it is set to None.
    [<CustomOperation("Adornment")>] member inline _.Adornment ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Adornment) = render ==> ("Adornment" => x)
    /// The validation is only triggered if the user has changed the input value at least once. By default, it is false
    [<CustomOperation("OnlyValidateIfDirty")>] member inline _.OnlyValidateIfDirty ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("OnlyValidateIfDirty" => x)
    /// The color of the adornment if used. It supports the theme colors.
    [<CustomOperation("AdornmentColor")>] member inline _.AdornmentColor ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("AdornmentColor" => x)
    /// The aria-label of the adornment.
    [<CustomOperation("AdornmentAriaLabel")>] member inline _.AdornmentAriaLabel ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("AdornmentAriaLabel" => x)
    /// The Icon Size.
    [<CustomOperation("IconSize")>] member inline _.IconSize ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Size) = render ==> ("IconSize" => x)
    /// Button click event if set and Adornment used.
    [<CustomOperation("OnAdornmentClick")>] member inline _.OnAdornmentClick ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>("OnAdornmentClick", fn)
    /// Button click event if set and Adornment used.
    [<CustomOperation("OnAdornmentClick")>] member inline _.OnAdornmentClick ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callbackTask<Microsoft.AspNetCore.Components.Web.MouseEventArgs>("OnAdornmentClick", fn)
    /// Variant to use.
    [<CustomOperation("Variant")>] member inline _.Variant ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Variant) = render ==> ("Variant" => x)
    /// Will adjust vertical spacing.
    ///             
    [<CustomOperation("Margin")>] member inline _.Margin ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Margin) = render ==> ("Margin" => x)
    /// The short hint displayed in the input before the user enters a value.
    [<CustomOperation("Placeholder")>] member inline _.Placeholder ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Placeholder" => x)
    /// If set, will display the counter, value 0 will display current count but no stop count.
    [<CustomOperation("Counter")>] member inline _.Counter ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Int32>) = render ==> ("Counter" => x)
    /// Maximum number of characters that the input will accept
    [<CustomOperation("MaxLength")>] member inline _.MaxLength ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("MaxLength" => x)
    /// If string has value the label text will be displayed in the input, and scaled down at the top if the input has value.
    [<CustomOperation("Label")>] member inline _.Label ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Label" => x)
    /// If true the input will focus automatically.
    [<CustomOperation("AutoFocus")>] member inline _.AutoFocus ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("AutoFocus" => x)
    /// A multiline input (textarea) will be shown, if set to more than one line.
    ///             
    [<CustomOperation("Lines")>] member inline _.Lines ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("Lines" => x)
    /// The text to be displayed.
    ///             
    [<CustomOperation("Text")>] member inline _.Text ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Text" => x)
    /// The text to be displayed.
    ///             
    [<CustomOperation("Text'")>] member inline _.Text' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.String * (System.String -> unit)) = render ==> html.bind("Text", valueFn)
    /// When TextUpdateSuppression is true (which is default) the text can not be updated by bindings while the component is focused in BSS (not WASM).
    /// This solves issue #1012: Textfield swallowing chars when typing rapidly
    /// If you need to update the input's text while it is focused you can set this parameter to false.
    /// Note: on WASM text update suppression is not active, so this parameter has no effect.
    [<CustomOperation("TextUpdateSuppression")>] member inline _.TextUpdateSuppression ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("TextUpdateSuppression" => x)
    /// Hints at the type of data that might be entered by the user while editing the input
    ///             
    [<CustomOperation("InputMode")>] member inline _.InputMode ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.InputMode) = render ==> ("InputMode" => x)
    /// The pattern attribute, when specified, is a regular expression which the input's value must match in order for the value to pass constraint validation. It must be a valid JavaScript regular expression
    /// Not Supported in multline input
    [<CustomOperation("Pattern")>] member inline _.Pattern ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Pattern" => x)
    /// Fired when the text value changes.
    [<CustomOperation("TextChanged")>] member inline _.TextChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callback<System.String>("TextChanged", fn)
    /// Fired when the text value changes.
    [<CustomOperation("TextChanged")>] member inline _.TextChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callbackTask<System.String>("TextChanged", fn)
    /// Fired when the element loses focus.
    [<CustomOperation("OnBlur")>] member inline _.OnBlur ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callback<Microsoft.AspNetCore.Components.Web.FocusEventArgs>("OnBlur", fn)
    /// Fired when the element loses focus.
    [<CustomOperation("OnBlur")>] member inline _.OnBlur ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callbackTask<Microsoft.AspNetCore.Components.Web.FocusEventArgs>("OnBlur", fn)
    /// Fired when the element changes internally its text value.
    [<CustomOperation("OnInternalInputChanged")>] member inline _.OnInternalInputChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callback<Microsoft.AspNetCore.Components.ChangeEventArgs>("OnInternalInputChanged", fn)
    /// Fired when the element changes internally its text value.
    [<CustomOperation("OnInternalInputChanged")>] member inline _.OnInternalInputChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callbackTask<Microsoft.AspNetCore.Components.ChangeEventArgs>("OnInternalInputChanged", fn)
    /// Fired on the KeyDown event.
    [<CustomOperation("OnKeyDown")>] member inline _.OnKeyDown ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs>("OnKeyDown", fn)
    /// Fired on the KeyDown event.
    [<CustomOperation("OnKeyDown")>] member inline _.OnKeyDown ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callbackTask<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs>("OnKeyDown", fn)
    /// Prevent the default action for the KeyDown event.
    [<CustomOperation("KeyDownPreventDefault")>] member inline _.KeyDownPreventDefault ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("KeyDownPreventDefault" => x)
    /// Fired on the KeyPress event.
    [<CustomOperation("OnKeyPress")>] member inline _.OnKeyPress ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs>("OnKeyPress", fn)
    /// Fired on the KeyPress event.
    [<CustomOperation("OnKeyPress")>] member inline _.OnKeyPress ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callbackTask<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs>("OnKeyPress", fn)
    /// Prevent the default action for the KeyPress event.
    [<CustomOperation("KeyPressPreventDefault")>] member inline _.KeyPressPreventDefault ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("KeyPressPreventDefault" => x)
    /// Fired on the KeyUp event.
    [<CustomOperation("OnKeyUp")>] member inline _.OnKeyUp ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs>("OnKeyUp", fn)
    /// Fired on the KeyUp event.
    [<CustomOperation("OnKeyUp")>] member inline _.OnKeyUp ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callbackTask<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs>("OnKeyUp", fn)
    /// Prevent the default action for the KeyUp event.
    [<CustomOperation("KeyUpPreventDefault")>] member inline _.KeyUpPreventDefault ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("KeyUpPreventDefault" => x)
    /// Fired when the Value property changes.
    [<CustomOperation("ValueChanged")>] member inline _.ValueChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callback<'T>("ValueChanged", fn)
    /// Fired when the Value property changes.
    [<CustomOperation("ValueChanged")>] member inline _.ValueChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callbackTask<'T>("ValueChanged", fn)
    /// The value of this input element.
    [<CustomOperation("Value")>] member inline _.Value ([<InlineIfLambda>] render: AttrRenderFragment, x: 'T) = render ==> ("Value" => x)
    /// The value of this input element.
    [<CustomOperation("Value'")>] member inline _.Value' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: 'T * ('T -> unit)) = render ==> html.bind("Value", valueFn)
    /// Conversion format parameter for ToString(), can be used for formatting primitive types, DateTimes and TimeSpans
    [<CustomOperation("Format")>] member inline _.Format ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Format" => x)

type MudAutocompleteBuilder<'FunBlazorGeneric, 'T when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudBaseInputBuilder<'FunBlazorGeneric, 'T>()
    /// User class names for the popover, separated by space
    [<CustomOperation("PopoverClass")>] member inline _.PopoverClass ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("PopoverClass" => x)
    /// User class names for the internal list, separated by space
    [<CustomOperation("ListClass")>] member inline _.ListClass ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("ListClass" => x)
    /// Set the anchor origin point to determen where the popover will open from.
    [<CustomOperation("AnchorOrigin")>] member inline _.AnchorOrigin ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Origin) = render ==> ("AnchorOrigin" => x)
    /// Sets the transform origin point for the popover.
    [<CustomOperation("TransformOrigin")>] member inline _.TransformOrigin ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Origin) = render ==> ("TransformOrigin" => x)
    /// If true, compact vertical padding will be applied to all Autocomplete items.
    [<CustomOperation("Dense")>] member inline _.Dense ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("Dense" => x)
    /// The Open Autocomplete Icon
    [<CustomOperation("OpenIcon")>] member inline _.OpenIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("OpenIcon" => x)
    /// The Close Autocomplete Icon
    [<CustomOperation("CloseIcon")>] member inline _.CloseIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("CloseIcon" => x)
    /// The maximum height of the Autocomplete when it is open.
    [<CustomOperation("MaxHeight")>] member inline _.MaxHeight ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("MaxHeight" => x)
    /// Defines how values are displayed in the drop-down list
    [<CustomOperation("ToStringFunc")>] member inline _.ToStringFunc ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("ToStringFunc" => (System.Func<'T, System.String>fn))
    /// Whether to show the progress indicator. 
    [<CustomOperation("ShowProgressIndicator")>] member inline _.ShowProgressIndicator ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("ShowProgressIndicator" => x)
    /// The color of the progress indicator. 
    [<CustomOperation("ProgressIndicatorColor")>] member inline _.ProgressIndicatorColor ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("ProgressIndicatorColor" => x)
    /// Func that returns a list of items matching the typed text. Provides a cancellation token that
    /// is marked as cancelled when the user changes the search text or selects a value from the list. 
    /// This can be used to cancel expensive asynchronous work occuring within the SearchFunc itself.
    [<CustomOperation("SearchFuncWithCancel")>] member inline _.SearchFuncWithCancel ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("SearchFuncWithCancel" => (System.Func<System.String, System.Threading.CancellationToken, System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<'T>>>fn))
    /// The SearchFunc returns a list of items matching the typed text
    [<CustomOperation("SearchFunc")>] member inline _.SearchFunc ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("SearchFunc" => (System.Func<System.String, System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<'T>>>fn))
    /// Maximum items to display, defaults to 10.
    /// A null value will display all items.
    [<CustomOperation("MaxItems")>] member inline _.MaxItems ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Int32>) = render ==> ("MaxItems" => x)
    /// Minimum characters to initiate a search
    [<CustomOperation("MinCharacters")>] member inline _.MinCharacters ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("MinCharacters" => x)
    /// Reset value if user deletes the text
    [<CustomOperation("ResetValueOnEmptyText")>] member inline _.ResetValueOnEmptyText ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("ResetValueOnEmptyText" => x)
    /// If true, clicking the text field will select (highlight) its contents.
    [<CustomOperation("SelectOnClick")>] member inline _.SelectOnClick ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("SelectOnClick" => x)
    /// If false, clicking on the Autocomplete after selecting an option will query the Search method again with an empty string. This makes it easier to view and select other options without resetting the Value.
    /// T must either be a record or override GetHashCode and Equals.
    [<CustomOperation("Strict")>] member inline _.Strict ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("Strict" => x)
    /// Debounce interval in milliseconds.
    [<CustomOperation("DebounceInterval")>] member inline _.DebounceInterval ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("DebounceInterval" => x)
    /// Optional presentation template for unselected items
    [<CustomOperation("ItemTemplate")>] member inline _.ItemTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fn: 'T -> NodeRenderFragment) = render ==> html.renderFragment("ItemTemplate", fn)
    /// Optional presentation template for the selected item
    [<CustomOperation("ItemSelectedTemplate")>] member inline _.ItemSelectedTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fn: 'T -> NodeRenderFragment) = render ==> html.renderFragment("ItemSelectedTemplate", fn)
    /// Optional presentation template for disabled item
    [<CustomOperation("ItemDisabledTemplate")>] member inline _.ItemDisabledTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fn: 'T -> NodeRenderFragment) = render ==> html.renderFragment("ItemDisabledTemplate", fn)
    /// Optional presentation template for when more items were returned from the Search function than the MaxItems limit
    [<CustomOperation("MoreItemsTemplate")>] member inline _.MoreItemsTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragment) = render ==> html.renderFragment("MoreItemsTemplate", fragment)
    /// Optional presentation template for when more items were returned from the Search function than the MaxItems limit
    [<CustomOperation("MoreItemsTemplate")>] member inline _.MoreItemsTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragments) = render ==> html.renderFragment("MoreItemsTemplate", fragment { yield! fragments })
    /// Optional presentation template for when more items were returned from the Search function than the MaxItems limit
    [<CustomOperation("MoreItemsTemplate")>] member inline _.MoreItemsTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("MoreItemsTemplate", html.text x)
    /// Optional presentation template for when more items were returned from the Search function than the MaxItems limit
    [<CustomOperation("MoreItemsTemplate")>] member inline _.MoreItemsTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("MoreItemsTemplate", html.text x)
    /// Optional presentation template for when more items were returned from the Search function than the MaxItems limit
    [<CustomOperation("MoreItemsTemplate")>] member inline _.MoreItemsTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("MoreItemsTemplate", html.text x)
    /// Optional presentation template for when no items were returned from the Search function
    [<CustomOperation("NoItemsTemplate")>] member inline _.NoItemsTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragment) = render ==> html.renderFragment("NoItemsTemplate", fragment)
    /// Optional presentation template for when no items were returned from the Search function
    [<CustomOperation("NoItemsTemplate")>] member inline _.NoItemsTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragments) = render ==> html.renderFragment("NoItemsTemplate", fragment { yield! fragments })
    /// Optional presentation template for when no items were returned from the Search function
    [<CustomOperation("NoItemsTemplate")>] member inline _.NoItemsTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("NoItemsTemplate", html.text x)
    /// Optional presentation template for when no items were returned from the Search function
    [<CustomOperation("NoItemsTemplate")>] member inline _.NoItemsTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("NoItemsTemplate", html.text x)
    /// Optional presentation template for when no items were returned from the Search function
    [<CustomOperation("NoItemsTemplate")>] member inline _.NoItemsTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("NoItemsTemplate", html.text x)
    /// Optional template for progress indicator
    [<CustomOperation("ProgressIndicatorTemplate")>] member inline _.ProgressIndicatorTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragment) = render ==> html.renderFragment("ProgressIndicatorTemplate", fragment)
    /// Optional template for progress indicator
    [<CustomOperation("ProgressIndicatorTemplate")>] member inline _.ProgressIndicatorTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragments) = render ==> html.renderFragment("ProgressIndicatorTemplate", fragment { yield! fragments })
    /// Optional template for progress indicator
    [<CustomOperation("ProgressIndicatorTemplate")>] member inline _.ProgressIndicatorTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("ProgressIndicatorTemplate", html.text x)
    /// Optional template for progress indicator
    [<CustomOperation("ProgressIndicatorTemplate")>] member inline _.ProgressIndicatorTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("ProgressIndicatorTemplate", html.text x)
    /// Optional template for progress indicator
    [<CustomOperation("ProgressIndicatorTemplate")>] member inline _.ProgressIndicatorTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("ProgressIndicatorTemplate", html.text x)
    /// Optional template for showing progress indicator inside the popover
    [<CustomOperation("ProgressIndicatorInPopoverTemplate")>] member inline _.ProgressIndicatorInPopoverTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragment) = render ==> html.renderFragment("ProgressIndicatorInPopoverTemplate", fragment)
    /// Optional template for showing progress indicator inside the popover
    [<CustomOperation("ProgressIndicatorInPopoverTemplate")>] member inline _.ProgressIndicatorInPopoverTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragments) = render ==> html.renderFragment("ProgressIndicatorInPopoverTemplate", fragment { yield! fragments })
    /// Optional template for showing progress indicator inside the popover
    [<CustomOperation("ProgressIndicatorInPopoverTemplate")>] member inline _.ProgressIndicatorInPopoverTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("ProgressIndicatorInPopoverTemplate", html.text x)
    /// Optional template for showing progress indicator inside the popover
    [<CustomOperation("ProgressIndicatorInPopoverTemplate")>] member inline _.ProgressIndicatorInPopoverTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("ProgressIndicatorInPopoverTemplate", html.text x)
    /// Optional template for showing progress indicator inside the popover
    [<CustomOperation("ProgressIndicatorInPopoverTemplate")>] member inline _.ProgressIndicatorInPopoverTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("ProgressIndicatorInPopoverTemplate", html.text x)
    /// On drop-down close override Text with selected Value. This makes it clear to the user
    /// which list value is currently selected and disallows incomplete values in Text.
    [<CustomOperation("CoerceText")>] member inline _.CoerceText ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("CoerceText" => x)
    /// If user input is not found by the search func and CoerceValue is set to true the user input
    /// will be applied to the Value which allows to validate it and display an error message.
    [<CustomOperation("CoerceValue")>] member inline _.CoerceValue ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("CoerceValue" => x)
    /// Function to be invoked when checking whether an item should be disabled or not
    [<CustomOperation("ItemDisabledFunc")>] member inline _.ItemDisabledFunc ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("ItemDisabledFunc" => (System.Func<'T, System.Boolean>fn))
    /// An event triggered when the state of IsOpen has changed
    [<CustomOperation("IsOpenChanged")>] member inline _.IsOpenChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callback<System.Boolean>("IsOpenChanged", fn)
    /// An event triggered when the state of IsOpen has changed
    [<CustomOperation("IsOpenChanged")>] member inline _.IsOpenChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callbackTask<System.Boolean>("IsOpenChanged", fn)
    /// If true, the currently selected item from the drop-down (if it is open) is selected.
    [<CustomOperation("SelectValueOnTab")>] member inline _.SelectValueOnTab ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("SelectValueOnTab" => x)
    /// Show clear button.
    [<CustomOperation("Clearable")>] member inline _.Clearable ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("Clearable" => x)
    /// Button click event for clear button. Called after text and value has been cleared.
    [<CustomOperation("OnClearButtonClick")>] member inline _.OnClearButtonClick ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>("OnClearButtonClick", fn)
    /// Button click event for clear button. Called after text and value has been cleared.
    [<CustomOperation("OnClearButtonClick")>] member inline _.OnClearButtonClick ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callbackTask<Microsoft.AspNetCore.Components.Web.MouseEventArgs>("OnClearButtonClick", fn)

type MudDebouncedInputBuilder<'FunBlazorGeneric, 'T when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudBaseInputBuilder<'FunBlazorGeneric, 'T>()
    /// Interval to be awaited in milliseconds before changing the Text value
    [<CustomOperation("DebounceInterval")>] member inline _.DebounceInterval ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Double) = render ==> ("DebounceInterval" => x)
    /// callback to be called when the debounce interval has elapsed
    /// receives the Text as a parameter
    [<CustomOperation("OnDebounceIntervalElapsed")>] member inline _.OnDebounceIntervalElapsed ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callback<System.String>("OnDebounceIntervalElapsed", fn)
    /// callback to be called when the debounce interval has elapsed
    /// receives the Text as a parameter
    [<CustomOperation("OnDebounceIntervalElapsed")>] member inline _.OnDebounceIntervalElapsed ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callbackTask<System.String>("OnDebounceIntervalElapsed", fn)

type MudNumericFieldBuilder<'FunBlazorGeneric, 'T when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudDebouncedInputBuilder<'FunBlazorGeneric, 'T>()
    /// Show clear button.
    [<CustomOperation("Clearable")>] member inline _.Clearable ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("Clearable" => x)
    /// Reverts mouse wheel up and down events, if true.
    [<CustomOperation("InvertMouseWheel")>] member inline _.InvertMouseWheel ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("InvertMouseWheel" => x)
    /// The minimum value for the input.
    [<CustomOperation("Min")>] member inline _.Min ([<InlineIfLambda>] render: AttrRenderFragment, x: 'T) = render ==> ("Min" => x)
    /// The maximum value for the input.
    [<CustomOperation("Max")>] member inline _.Max ([<InlineIfLambda>] render: AttrRenderFragment, x: 'T) = render ==> ("Max" => x)
    /// The increment added/subtracted by the spin buttons.
    [<CustomOperation("Step")>] member inline _.Step ([<InlineIfLambda>] render: AttrRenderFragment, x: 'T) = render ==> ("Step" => x)
    /// Hides the spin buttons, the user can still change value with keyboard arrows and manual update.
    [<CustomOperation("HideSpinButtons")>] member inline _.HideSpinButtons ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("HideSpinButtons" => x)
    /// Hints at the type of data that might be entered by the user while editing the input.
    /// Defaults to numeric
    ///             
    [<CustomOperation("InputMode")>] member inline _.InputMode ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.InputMode) = render ==> ("InputMode" => x)
    /// The pattern attribute, when specified, is a regular expression which the input's value must match in order for the value to pass constraint validation. It must be a valid JavaScript regular expression
    /// Defaults to [0-9,.\-]
    /// To get a numerical keyboard on safari, use the pattern. The default pattern should achieve numerical keyboard.
    ///             
    /// Note: this pattern is also used to prevent all input except numbers and allowed characters. So for instance to allow only numbers, no signs and no commas you might change it to to [0-9.]
    [<CustomOperation("Pattern")>] member inline _.Pattern ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Pattern" => x)

type MudTextFieldBuilder<'FunBlazorGeneric, 'T when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudDebouncedInputBuilder<'FunBlazorGeneric, 'T>()
    /// Type of the input element. It should be a valid HTML5 input type.
    [<CustomOperation("InputType")>] member inline _.InputType ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.InputType) = render ==> ("InputType" => x)
    /// Show clear button.
    [<CustomOperation("Clearable")>] member inline _.Clearable ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("Clearable" => x)
    /// Button click event for clear button. Called after text and value has been cleared.
    [<CustomOperation("OnClearButtonClick")>] member inline _.OnClearButtonClick ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>("OnClearButtonClick", fn)
    /// Button click event for clear button. Called after text and value has been cleared.
    [<CustomOperation("OnClearButtonClick")>] member inline _.OnClearButtonClick ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callbackTask<Microsoft.AspNetCore.Components.Web.MouseEventArgs>("OnClearButtonClick", fn)
    /// Provide a masking object. Built-in masks are PatternMask, MultiMask, RegexMask and BlockMask
    /// Note: when Mask is set, TextField will ignore some properties such as Lines, Pattern or HideSpinButtons, OnKeyDown and OnKeyUp, etc.
    [<CustomOperation("Mask")>] member inline _.Mask ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.IMask) = render ==> ("Mask" => x)

type MudInputBuilder<'FunBlazorGeneric, 'T when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudBaseInputBuilder<'FunBlazorGeneric, 'T>()
    /// Type of the input element. It should be a valid HTML5 input type.
    [<CustomOperation("InputType")>] member inline _.InputType ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.InputType) = render ==> ("InputType" => x)
    /// Invokes the callback when the Up arrow button is clicked when the input is set to Number.
    /// Note: use the optimized control MudNumericField`1 if you need to deal with numbers.
    [<CustomOperation("OnIncrement")>] member inline _.OnIncrement ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callback("OnIncrement", fn)
    /// Invokes the callback when the Up arrow button is clicked when the input is set to Number.
    /// Note: use the optimized control MudNumericField`1 if you need to deal with numbers.
    [<CustomOperation("OnIncrement")>] member inline _.OnIncrement ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callbackTask("OnIncrement", fn)
    /// Invokes the callback when the Down arrow button is clicked when the input is set to Number.
    /// Note: use the optimized control MudNumericField`1 if you need to deal with numbers.
    [<CustomOperation("OnDecrement")>] member inline _.OnDecrement ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callback("OnDecrement", fn)
    /// Invokes the callback when the Down arrow button is clicked when the input is set to Number.
    /// Note: use the optimized control MudNumericField`1 if you need to deal with numbers.
    [<CustomOperation("OnDecrement")>] member inline _.OnDecrement ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callbackTask("OnDecrement", fn)
    /// Hides the spin buttons for MudNumericField`1
    [<CustomOperation("HideSpinButtons")>] member inline _.HideSpinButtons ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("HideSpinButtons" => x)
    /// Show clear button.
    [<CustomOperation("Clearable")>] member inline _.Clearable ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("Clearable" => x)
    /// Button click event for clear button. Called after text and value has been cleared.
    [<CustomOperation("OnClearButtonClick")>] member inline _.OnClearButtonClick ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>("OnClearButtonClick", fn)
    /// Button click event for clear button. Called after text and value has been cleared.
    [<CustomOperation("OnClearButtonClick")>] member inline _.OnClearButtonClick ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callbackTask<Microsoft.AspNetCore.Components.Web.MouseEventArgs>("OnClearButtonClick", fn)
    /// Mouse wheel event for input.
    [<CustomOperation("OnMouseWheel")>] member inline _.OnMouseWheel ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callback<Microsoft.AspNetCore.Components.Web.WheelEventArgs>("OnMouseWheel", fn)
    /// Mouse wheel event for input.
    [<CustomOperation("OnMouseWheel")>] member inline _.OnMouseWheel ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callbackTask<Microsoft.AspNetCore.Components.Web.WheelEventArgs>("OnMouseWheel", fn)
    /// Custom clear icon.
    [<CustomOperation("ClearIcon")>] member inline _.ClearIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("ClearIcon" => x)
    /// Custom numeric up icon.
    [<CustomOperation("NumericUpIcon")>] member inline _.NumericUpIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("NumericUpIcon" => x)
    /// Custom numeric down icon.
    [<CustomOperation("NumericDownIcon")>] member inline _.NumericDownIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("NumericDownIcon" => x)

type MudInputStringBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudInputBuilder<'FunBlazorGeneric, System.String>()


type MudRangeInputBuilder<'FunBlazorGeneric, 'T when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudBaseInputBuilder<'FunBlazorGeneric, MudBlazor.Range<'T>>()
    /// Type of the input element. It should be a valid HTML5 input type.
    [<CustomOperation("InputType")>] member inline _.InputType ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.InputType) = render ==> ("InputType" => x)
    /// The short hint displayed in the start input before the user enters a value.
    [<CustomOperation("PlaceholderStart")>] member inline _.PlaceholderStart ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("PlaceholderStart" => x)
    /// The short hint displayed in the end input before the user enters a value.
    [<CustomOperation("PlaceholderEnd")>] member inline _.PlaceholderEnd ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("PlaceholderEnd" => x)
    /// Custom separator icon, leave null for default.
    [<CustomOperation("SeparatorIcon")>] member inline _.SeparatorIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("SeparatorIcon" => x)

type MudMaskBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudBaseInputBuilder<'FunBlazorGeneric, System.String>()
    /// Provide a masking object. Built-in masks are PatternMask, MultiMask, RegexMask and BlockMask
    [<CustomOperation("Mask")>] member inline _.Mask ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.IMask) = render ==> ("Mask" => x)
    /// Type of the input element. It should be a valid HTML5 input type.
    [<CustomOperation("InputType")>] member inline _.InputType ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.InputType) = render ==> ("InputType" => x)
    /// Show clear button.
    [<CustomOperation("Clearable")>] member inline _.Clearable ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("Clearable" => x)
    /// Button click event for clear button. Called after text and value has been cleared.
    [<CustomOperation("OnClearButtonClick")>] member inline _.OnClearButtonClick ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>("OnClearButtonClick", fn)
    /// Button click event for clear button. Called after text and value has been cleared.
    [<CustomOperation("OnClearButtonClick")>] member inline _.OnClearButtonClick ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callbackTask<Microsoft.AspNetCore.Components.Web.MouseEventArgs>("OnClearButtonClick", fn)
    /// Custom clear icon.
    [<CustomOperation("ClearIcon")>] member inline _.ClearIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("ClearIcon" => x)

type MudSelectBuilder<'FunBlazorGeneric, 'T when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudBaseInputBuilder<'FunBlazorGeneric, 'T>()
    /// Fired when dropdown opens.
    [<CustomOperation("OnOpen")>] member inline _.OnOpen ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callback("OnOpen", fn)
    /// Fired when dropdown opens.
    [<CustomOperation("OnOpen")>] member inline _.OnOpen ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callbackTask("OnOpen", fn)
    /// Fired when dropdown closes.
    [<CustomOperation("OnClose")>] member inline _.OnClose ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callback("OnClose", fn)
    /// Fired when dropdown closes.
    [<CustomOperation("OnClose")>] member inline _.OnClose ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callbackTask("OnClose", fn)
    /// User class names for the popover, separated by space
    [<CustomOperation("PopoverClass")>] member inline _.PopoverClass ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("PopoverClass" => x)
    /// User class names for the internal list, separated by space
    [<CustomOperation("ListClass")>] member inline _.ListClass ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("ListClass" => x)
    /// If true, compact vertical padding will be applied to all Select items.
    [<CustomOperation("Dense")>] member inline _.Dense ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("Dense" => x)
    /// The Open Select Icon
    [<CustomOperation("OpenIcon")>] member inline _.OpenIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("OpenIcon" => x)
    /// The Close Select Icon
    [<CustomOperation("CloseIcon")>] member inline _.CloseIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("CloseIcon" => x)
    /// If set to true and the MultiSelection option is set to true, a "select all" checkbox is added at the top of the list of items.
    [<CustomOperation("SelectAll")>] member inline _.SelectAll ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("SelectAll" => x)
    /// Define the text of the Select All option.
    [<CustomOperation("SelectAllText")>] member inline _.SelectAllText ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("SelectAllText" => x)
    /// Fires when SelectedValues changes.
    [<CustomOperation("SelectedValuesChanged")>] member inline _.SelectedValuesChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callback<System.Collections.Generic.IEnumerable<'T>>("SelectedValuesChanged", fn)
    /// Fires when SelectedValues changes.
    [<CustomOperation("SelectedValuesChanged")>] member inline _.SelectedValuesChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callbackTask<System.Collections.Generic.IEnumerable<'T>>("SelectedValuesChanged", fn)
    /// Function to define a customized multiselection text.
    [<CustomOperation("MultiSelectionTextFunc")>] member inline _.MultiSelectionTextFunc ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("MultiSelectionTextFunc" => (System.Func<System.Collections.Generic.List<System.String>, System.String>fn))
    /// Parameter to define the delimited string separator.
    [<CustomOperation("Delimiter")>] member inline _.Delimiter ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Delimiter" => x)
    /// Set of selected values. If MultiSelection is false it will only ever contain a single value. This property is two-way bindable.
    [<CustomOperation("SelectedValues")>] member inline _.SelectedValues ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.IEnumerable<'T>) = render ==> ("SelectedValues" => x)
    /// Set of selected values. If MultiSelection is false it will only ever contain a single value. This property is two-way bindable.
    [<CustomOperation("SelectedValues'")>] member inline _.SelectedValues' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.Collections.Generic.IEnumerable<'T> * (System.Collections.Generic.IEnumerable<'T> -> unit)) = render ==> html.bind("SelectedValues", valueFn)
    /// The Comparer to use for comparing selected values internally.
    [<CustomOperation("Comparer")>] member inline _.Comparer ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.IEqualityComparer<'T>) = render ==> ("Comparer" => x)
    /// Defines how values are displayed in the drop-down list
    [<CustomOperation("ToStringFunc")>] member inline _.ToStringFunc ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("ToStringFunc" => (System.Func<'T, System.String>fn))
    /// If true, multiple values can be selected via checkboxes which are automatically shown in the dropdown
    [<CustomOperation("MultiSelection")>] member inline _.MultiSelection ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("MultiSelection" => x)
    /// Sets the maxheight the Select can have when open.
    [<CustomOperation("MaxHeight")>] member inline _.MaxHeight ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("MaxHeight" => x)
    /// Set the anchor origin point to determen where the popover will open from.
    [<CustomOperation("AnchorOrigin")>] member inline _.AnchorOrigin ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Origin) = render ==> ("AnchorOrigin" => x)
    /// Sets the transform origin point for the popover.
    [<CustomOperation("TransformOrigin")>] member inline _.TransformOrigin ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Origin) = render ==> ("TransformOrigin" => x)
    /// If true, the Select's input will not show any values that are not defined in the dropdown.
    /// This can be useful if Value is bound to a variable which is initialized to a value which is not in the list
    /// and you want the Select to show the label / placeholder instead.
    [<CustomOperation("Strict")>] member inline _.Strict ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("Strict" => x)
    /// Show clear button.
    [<CustomOperation("Clearable")>] member inline _.Clearable ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("Clearable" => x)
    /// If true, prevent scrolling while dropdown is open.
    [<CustomOperation("LockScroll")>] member inline _.LockScroll ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("LockScroll" => x)
    /// Button click event for clear button. Called after text and value has been cleared.
    [<CustomOperation("OnClearButtonClick")>] member inline _.OnClearButtonClick ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>("OnClearButtonClick", fn)
    /// Button click event for clear button. Called after text and value has been cleared.
    [<CustomOperation("OnClearButtonClick")>] member inline _.OnClearButtonClick ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callbackTask<Microsoft.AspNetCore.Components.Web.MouseEventArgs>("OnClearButtonClick", fn)
    /// Custom checked icon.
    [<CustomOperation("CheckedIcon")>] member inline _.CheckedIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("CheckedIcon" => x)
    /// Custom unchecked icon.
    [<CustomOperation("UncheckedIcon")>] member inline _.UncheckedIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("UncheckedIcon" => x)
    /// Custom indeterminate icon.
    [<CustomOperation("IndeterminateIcon")>] member inline _.IndeterminateIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("IndeterminateIcon" => x)

type MudBooleanInputBuilder<'FunBlazorGeneric, 'T when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudFormComponentBuilder<'FunBlazorGeneric, 'T, System.Nullable<System.Boolean>>()
    /// If true, the input will be disabled.
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("Disabled" => x)
    /// If true, the input will be read-only.
    [<CustomOperation("ReadOnly")>] member inline _.ReadOnly ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("ReadOnly" => x)
    /// The state of the component
    [<CustomOperation("Checked")>] member inline _.Checked ([<InlineIfLambda>] render: AttrRenderFragment, x: 'T) = render ==> ("Checked" => x)
    /// The state of the component
    [<CustomOperation("Checked'")>] member inline _.Checked' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: 'T * ('T -> unit)) = render ==> html.bind("Checked", valueFn)
    /// If true will prevent the click from bubbling up the event tree.
    [<CustomOperation("StopClickPropagation")>] member inline _.StopClickPropagation ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("StopClickPropagation" => x)
    /// Fired when Checked changes.
    [<CustomOperation("CheckedChanged")>] member inline _.CheckedChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callback<'T>("CheckedChanged", fn)
    /// Fired when Checked changes.
    [<CustomOperation("CheckedChanged")>] member inline _.CheckedChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callbackTask<'T>("CheckedChanged", fn)

type MudCheckBoxBuilder<'FunBlazorGeneric, 'T when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudBooleanInputBuilder<'FunBlazorGeneric, 'T>()
    /// The color of the component. It supports the theme colors.
    [<CustomOperation("Color")>] member inline _.Color ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("Color" => x)
    /// The base color of the component in its none active/unchecked state. It supports the theme colors.
    [<CustomOperation("UnCheckedColor")>] member inline _.UnCheckedColor ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<MudBlazor.Color>) = render ==> ("UnCheckedColor" => x)
    /// The text/label will be displayed next to the checkbox if set.
    [<CustomOperation("Label")>] member inline _.Label ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Label" => x)
    /// The position of the text/label.
    [<CustomOperation("LabelPosition")>] member inline _.LabelPosition ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.LabelPosition) = render ==> ("LabelPosition" => x)
    /// If true, the checkbox can be controlled with the keyboard.
    [<CustomOperation("KeyboardEnabled")>] member inline _.KeyboardEnabled ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("KeyboardEnabled" => x)
    /// If true, disables ripple effect.
    [<CustomOperation("DisableRipple")>] member inline _.DisableRipple ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("DisableRipple" => x)
    /// If true, compact padding will be applied.
    [<CustomOperation("Dense")>] member inline _.Dense ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("Dense" => x)
    /// The Size of the component.
    [<CustomOperation("Size")>] member inline _.Size ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Size) = render ==> ("Size" => x)
    /// Custom checked icon, leave null for default.
    [<CustomOperation("CheckedIcon")>] member inline _.CheckedIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("CheckedIcon" => x)
    /// Custom unchecked icon, leave null for default.
    [<CustomOperation("UncheckedIcon")>] member inline _.UncheckedIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("UncheckedIcon" => x)
    /// Custom indeterminate icon, leave null for default.
    [<CustomOperation("IndeterminateIcon")>] member inline _.IndeterminateIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("IndeterminateIcon" => x)
    /// Define if the checkbox can cycle again through indeterminate status.
    [<CustomOperation("TriState")>] member inline _.TriState ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("TriState" => x)

type MudSwitchBuilder<'FunBlazorGeneric, 'T when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudBooleanInputBuilder<'FunBlazorGeneric, 'T>()
    /// The color of the component. It supports the theme colors.
    [<CustomOperation("Color")>] member inline _.Color ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("Color" => x)
    /// The base color of the component in its none active/unchecked state. It supports the theme colors.
    [<CustomOperation("UnCheckedColor")>] member inline _.UnCheckedColor ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("UnCheckedColor" => x)
    /// The text/label will be displayed next to the switch if set.
    [<CustomOperation("Label")>] member inline _.Label ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Label" => x)
    /// The position of the text/label.
    [<CustomOperation("LabelPosition")>] member inline _.LabelPosition ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.LabelPosition) = render ==> ("LabelPosition" => x)
    /// Shows an icon on Switch's thumb.
    [<CustomOperation("ThumbIcon")>] member inline _.ThumbIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("ThumbIcon" => x)
    /// The color of the thumb icon. Supports the theme colors.
    [<CustomOperation("ThumbIconColor")>] member inline _.ThumbIconColor ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("ThumbIconColor" => x)
    /// If true, disables ripple effect.
    [<CustomOperation("DisableRipple")>] member inline _.DisableRipple ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("DisableRipple" => x)
    /// The Size of the switch.
    [<CustomOperation("Size")>] member inline _.Size ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Size) = render ==> ("Size" => x)

type MudFileUploadBuilder<'FunBlazorGeneric, 'T when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudFormComponentBuilder<'FunBlazorGeneric, 'T, System.String>()
    /// The value of the MudFileUpload component.
    /// If T is IBrowserFile, it represents a single file.
    /// If T is IReadOnlyList<IBrowserFile>, it represents multiple files
    [<CustomOperation("Files")>] member inline _.Files ([<InlineIfLambda>] render: AttrRenderFragment, x: 'T) = render ==> ("Files" => x)
    /// The value of the MudFileUpload component.
    /// If T is IBrowserFile, it represents a single file.
    /// If T is IReadOnlyList<IBrowserFile>, it represents multiple files
    [<CustomOperation("Files'")>] member inline _.Files' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: 'T * ('T -> unit)) = render ==> html.bind("Files", valueFn)
    /// Triggered when the internal OnChange event fires
    [<CustomOperation("FilesChanged")>] member inline _.FilesChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callback<'T>("FilesChanged", fn)
    /// Triggered when the internal OnChange event fires
    [<CustomOperation("FilesChanged")>] member inline _.FilesChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callbackTask<'T>("FilesChanged", fn)
    /// Called when the internal files are changed
    [<CustomOperation("OnFilesChanged")>] member inline _.OnFilesChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callback<Microsoft.AspNetCore.Components.Forms.InputFileChangeEventArgs>("OnFilesChanged", fn)
    /// Called when the internal files are changed
    [<CustomOperation("OnFilesChanged")>] member inline _.OnFilesChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callbackTask<Microsoft.AspNetCore.Components.Forms.InputFileChangeEventArgs>("OnFilesChanged", fn)
    /// Renders the button that triggers the input. Required for functioning.
    [<CustomOperation("ButtonTemplate")>] member inline _.ButtonTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.String -> NodeRenderFragment) = render ==> html.renderFragment("ButtonTemplate", fn)
    /// Renders the selected files, if desired.
    [<CustomOperation("SelectedTemplate")>] member inline _.SelectedTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fn: 'T -> NodeRenderFragment) = render ==> html.renderFragment("SelectedTemplate", fn)
    /// If true, OnFilesChanged will not trigger if validation fails
    [<CustomOperation("SuppressOnChangeWhenInvalid")>] member inline _.SuppressOnChangeWhenInvalid ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("SuppressOnChangeWhenInvalid" => x)
    /// Sets the file types this input will accept
    [<CustomOperation("Accept")>] member inline _.Accept ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Accept" => x)
    /// If false, the inner FileInput will be visible
    [<CustomOperation("Hidden")>] member inline _.Hidden ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("Hidden" => x)
    /// Css classes to apply to the internal InputFile
    [<CustomOperation("InputClass")>] member inline _.InputClass ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("InputClass" => x)
    /// Style to apply to the internal InputFile
    [<CustomOperation("InputStyle")>] member inline _.InputStyle ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("InputStyle" => x)
    /// Maximum number of files that can be uploaded
    [<CustomOperation("MaximumFileCount")>] member inline _.MaximumFileCount ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("MaximumFileCount" => x)

type MudPickerBuilder<'FunBlazorGeneric, 'T when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudFormComponentBuilder<'FunBlazorGeneric, 'T, System.String>()
    /// The color of the adornment if used. It supports the theme colors.
    [<CustomOperation("AdornmentColor")>] member inline _.AdornmentColor ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("AdornmentColor" => x)
    /// Sets the icon of the input text field
    [<CustomOperation("AdornmentIcon")>] member inline _.AdornmentIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("AdornmentIcon" => x)
    /// Sets the aria-label of the input text field icon
    [<CustomOperation("AdornmentAriaLabel")>] member inline _.AdornmentAriaLabel ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("AdornmentAriaLabel" => x)
    /// The short hint displayed in the input before the user enters a value.
    [<CustomOperation("Placeholder")>] member inline _.Placeholder ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Placeholder" => x)
    /// Fired when the dropdown / dialog opens
    [<CustomOperation("PickerOpened")>] member inline _.PickerOpened ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callback("PickerOpened", fn)
    /// Fired when the dropdown / dialog opens
    [<CustomOperation("PickerOpened")>] member inline _.PickerOpened ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callbackTask("PickerOpened", fn)
    /// Fired when the dropdown / dialog closes
    [<CustomOperation("PickerClosed")>] member inline _.PickerClosed ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callback("PickerClosed", fn)
    /// Fired when the dropdown / dialog closes
    [<CustomOperation("PickerClosed")>] member inline _.PickerClosed ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callbackTask("PickerClosed", fn)
    /// The higher the number, the heavier the drop-shadow. 0 for no shadow set to 8 by default in inline mode and 0 in static mode.
    [<CustomOperation("Elevation")>] member inline _.Elevation ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("Elevation" => x)
    /// If true, border-radius is set to 0 this is set to true automatically in static mode but can be overridden with Rounded bool.
    [<CustomOperation("Square")>] member inline _.Square ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("Square" => x)
    /// If true, no date or time can be defined.
    [<CustomOperation("ReadOnly")>] member inline _.ReadOnly ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("ReadOnly" => x)
    /// If true, border-radius is set to theme default when in Static Mode.
    [<CustomOperation("Rounded")>] member inline _.Rounded ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("Rounded" => x)
    /// If string has value, HelperText will be applied.
    [<CustomOperation("HelperText")>] member inline _.HelperText ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("HelperText" => x)
    /// If true, the helper text will only be visible on focus.
    [<CustomOperation("HelperTextOnFocus")>] member inline _.HelperTextOnFocus ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("HelperTextOnFocus" => x)
    /// If string has value the label text will be displayed in the input, and scaled down at the top if the input has value.
    [<CustomOperation("Label")>] member inline _.Label ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Label" => x)
    /// Show clear button.
    [<CustomOperation("Clearable")>] member inline _.Clearable ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("Clearable" => x)
    /// If true, the picker will be disabled.
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("Disabled" => x)
    /// If true, the picker will be editable.
    [<CustomOperation("Editable")>] member inline _.Editable ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("Editable" => x)
    /// Hide toolbar and show only date/time views.
    [<CustomOperation("DisableToolbar")>] member inline _.DisableToolbar ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("DisableToolbar" => x)
    /// User class names for picker's ToolBar, separated by space
    [<CustomOperation("ToolBarClass")>] member inline _.ToolBarClass ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("ToolBarClass" => x)
    /// Picker container option
    [<CustomOperation("PickerVariant")>] member inline _.PickerVariant ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.PickerVariant) = render ==> ("PickerVariant" => x)
    /// Variant of the text input
    [<CustomOperation("Variant")>] member inline _.Variant ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Variant) = render ==> ("Variant" => x)
    /// Sets if the icon will be att start or end, set to false to disable.
    [<CustomOperation("Adornment")>] member inline _.Adornment ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Adornment) = render ==> ("Adornment" => x)
    /// What orientation to render in when in PickerVariant Static Mode.
    [<CustomOperation("Orientation")>] member inline _.Orientation ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Orientation) = render ==> ("Orientation" => x)
    /// Sets the Icon Size.
    [<CustomOperation("IconSize")>] member inline _.IconSize ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Size) = render ==> ("IconSize" => x)
    /// The color of the toolbar, selected and active. It supports the theme colors.
    [<CustomOperation("Color")>] member inline _.Color ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("Color" => x)
    /// Changes the cursor appearance.
    [<CustomOperation("AllowKeyboardInput")>] member inline _.AllowKeyboardInput ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("AllowKeyboardInput" => x)
    /// Fired when the text changes.
    [<CustomOperation("TextChanged")>] member inline _.TextChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callback<System.String>("TextChanged", fn)
    /// Fired when the text changes.
    [<CustomOperation("TextChanged")>] member inline _.TextChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callbackTask<System.String>("TextChanged", fn)
    /// The currently selected string value (two-way bindable)
    [<CustomOperation("Text")>] member inline _.Text ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Text" => x)
    /// The currently selected string value (two-way bindable)
    [<CustomOperation("Text'")>] member inline _.Text' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.String * (System.String -> unit)) = render ==> html.bind("Text", valueFn)
    /// CSS class that will be applied to the action buttons container
    [<CustomOperation("ClassActions")>] member inline _.ClassActions ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("ClassActions" => x)
    /// Define the action buttons here
    [<CustomOperation("PickerActions")>] member inline _.PickerActions ([<InlineIfLambda>] render: AttrRenderFragment, fn: MudBlazor.MudPicker<'T> -> NodeRenderFragment) = render ==> html.renderFragment("PickerActions", fn)
    /// Will adjust vertical spacing.
    ///             
    [<CustomOperation("Margin")>] member inline _.Margin ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Margin) = render ==> ("Margin" => x)
    /// A mask for structured input of the date (requires Editable to be true).
    [<CustomOperation("Mask")>] member inline _.Mask ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.IMask) = render ==> ("Mask" => x)
    /// Gets or sets the origin of the popover's anchor. Defaults to TopLeft
    [<CustomOperation("AnchorOrigin")>] member inline _.AnchorOrigin ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Origin) = render ==> ("AnchorOrigin" => x)
    /// Gets or sets the origin of the popover's transform. Defaults to TopLeft
    [<CustomOperation("TransformOrigin")>] member inline _.TransformOrigin ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Origin) = render ==> ("TransformOrigin" => x)

type MudBaseDatePickerBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudPickerBuilder<'FunBlazorGeneric, System.Nullable<System.DateTime>>()
    /// Max selectable date.
    [<CustomOperation("MaxDate")>] member inline _.MaxDate ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.DateTime>) = render ==> ("MaxDate" => x)
    /// Min selectable date.
    [<CustomOperation("MinDate")>] member inline _.MinDate ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.DateTime>) = render ==> ("MinDate" => x)
    /// First view to show in the MudDatePicker.
    [<CustomOperation("OpenTo")>] member inline _.OpenTo ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.OpenTo) = render ==> ("OpenTo" => x)
    /// String Format for selected date view
    [<CustomOperation("DateFormat")>] member inline _.DateFormat ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("DateFormat" => x)
    /// Defines on which day the week starts. Depends on the value of Culture. 
    [<CustomOperation("FirstDayOfWeek")>] member inline _.FirstDayOfWeek ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.DayOfWeek>) = render ==> ("FirstDayOfWeek" => x)
    /// The current month of the date picker (two-way bindable). This changes when the user browses through the calender.
    /// The month is represented as a DateTime which is always the first day of that month. You can also set this to define which month is initially shown. If not set, the current month is shown.
    [<CustomOperation("PickerMonth")>] member inline _.PickerMonth ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.DateTime>) = render ==> ("PickerMonth" => x)
    /// The current month of the date picker (two-way bindable). This changes when the user browses through the calender.
    /// The month is represented as a DateTime which is always the first day of that month. You can also set this to define which month is initially shown. If not set, the current month is shown.
    [<CustomOperation("PickerMonth'")>] member inline _.PickerMonth' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.Nullable<System.DateTime> * (System.Nullable<System.DateTime> -> unit)) = render ==> html.bind("PickerMonth", valueFn)
    /// Fired when the date changes.
    [<CustomOperation("PickerMonthChanged")>] member inline _.PickerMonthChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callback<System.Nullable<System.DateTime>>("PickerMonthChanged", fn)
    /// Fired when the date changes.
    [<CustomOperation("PickerMonthChanged")>] member inline _.PickerMonthChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callbackTask<System.Nullable<System.DateTime>>("PickerMonthChanged", fn)
    /// Sets the amount of time in milliseconds to wait before closing the picker. This helps the user see that the date was selected before the popover disappears.
    [<CustomOperation("ClosingDelay")>] member inline _.ClosingDelay ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("ClosingDelay" => x)
    /// Number of months to display in the calendar
    [<CustomOperation("DisplayMonths")>] member inline _.DisplayMonths ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("DisplayMonths" => x)
    /// Maximum number of months in one row
    [<CustomOperation("MaxMonthColumns")>] member inline _.MaxMonthColumns ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Int32>) = render ==> ("MaxMonthColumns" => x)
    /// Start month when opening the picker. 
    [<CustomOperation("StartMonth")>] member inline _.StartMonth ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.DateTime>) = render ==> ("StartMonth" => x)
    /// Display week numbers according to the Culture parameter. If no culture is defined, CultureInfo.CurrentCulture will be used.
    [<CustomOperation("ShowWeekNumbers")>] member inline _.ShowWeekNumbers ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("ShowWeekNumbers" => x)
    /// Format of the selected date in the title. By default, this is "ddd, dd MMM" which abbreviates day and month names. 
    /// For instance, display the long names like this "dddd, dd. MMMM". 
    [<CustomOperation("TitleDateFormat")>] member inline _.TitleDateFormat ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("TitleDateFormat" => x)
    /// If AutoClose is set to true and PickerActions are defined, selecting a day will close the MudDatePicker.
    [<CustomOperation("AutoClose")>] member inline _.AutoClose ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("AutoClose" => x)
    /// Function to determine whether a date is disabled
    [<CustomOperation("IsDateDisabledFunc")>] member inline _.IsDateDisabledFunc ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("IsDateDisabledFunc" => (System.Func<System.DateTime, System.Boolean>fn))
    /// Function to conditionally apply new classes to specific days
    [<CustomOperation("AdditionalDateClassesFunc")>] member inline _.AdditionalDateClassesFunc ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("AdditionalDateClassesFunc" => (System.Func<System.DateTime, System.String>fn))
    /// Custom previous icon.
    [<CustomOperation("PreviousIcon")>] member inline _.PreviousIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("PreviousIcon" => x)
    /// Custom next icon.
    [<CustomOperation("NextIcon")>] member inline _.NextIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("NextIcon" => x)
    /// Set a predefined fix year - no year can be selected
    [<CustomOperation("FixYear")>] member inline _.FixYear ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Int32>) = render ==> ("FixYear" => x)
    /// Set a predefined fix month - no month can be selected
    [<CustomOperation("FixMonth")>] member inline _.FixMonth ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Int32>) = render ==> ("FixMonth" => x)
    /// Set a predefined fix day - no day can be selected
    [<CustomOperation("FixDay")>] member inline _.FixDay ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Int32>) = render ==> ("FixDay" => x)

type MudDatePickerBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudBaseDatePickerBuilder<'FunBlazorGeneric>()
    /// Fired when the DateFormat changes.
    [<CustomOperation("DateChanged")>] member inline _.DateChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callback<System.Nullable<System.DateTime>>("DateChanged", fn)
    /// Fired when the DateFormat changes.
    [<CustomOperation("DateChanged")>] member inline _.DateChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callbackTask<System.Nullable<System.DateTime>>("DateChanged", fn)
    /// The currently selected date (two-way bindable). If null, then nothing was selected.
    [<CustomOperation("Date")>] member inline _.Date ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.DateTime>) = render ==> ("Date" => x)
    /// The currently selected date (two-way bindable). If null, then nothing was selected.
    [<CustomOperation("Date'")>] member inline _.Date' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.Nullable<System.DateTime> * (System.Nullable<System.DateTime> -> unit)) = render ==> html.bind("Date", valueFn)

type MudDateRangePickerBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudBaseDatePickerBuilder<'FunBlazorGeneric>()
    /// Fired when the DateFormat changes.
    [<CustomOperation("DateRangeChanged")>] member inline _.DateRangeChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callback<MudBlazor.DateRange>("DateRangeChanged", fn)
    /// Fired when the DateFormat changes.
    [<CustomOperation("DateRangeChanged")>] member inline _.DateRangeChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callbackTask<MudBlazor.DateRange>("DateRangeChanged", fn)
    /// The currently selected range (two-way bindable). If null, then nothing was selected.
    [<CustomOperation("DateRange")>] member inline _.DateRange ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.DateRange) = render ==> ("DateRange" => x)
    /// The currently selected range (two-way bindable). If null, then nothing was selected.
    [<CustomOperation("DateRange'")>] member inline _.DateRange' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: MudBlazor.DateRange * (MudBlazor.DateRange -> unit)) = render ==> html.bind("DateRange", valueFn)

type MudColorPickerBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudPickerBuilder<'FunBlazorGeneric, MudBlazor.Utilities.MudColor>()
    /// If true, Alpha options will not be displayed and color output will be RGB, HSL or HEX and not RGBA, HSLA or HEXA.
    [<CustomOperation("DisableAlpha")>] member inline _.DisableAlpha ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("DisableAlpha" => x)
    /// If true, the color field will not be displayed.
    [<CustomOperation("DisableColorField")>] member inline _.DisableColorField ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("DisableColorField" => x)
    /// If true, the switch to change color mode will not be displayed.
    [<CustomOperation("DisableModeSwitch")>] member inline _.DisableModeSwitch ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("DisableModeSwitch" => x)
    /// If true, textfield inputs and color mode switch will not be displayed.
    [<CustomOperation("DisableInputs")>] member inline _.DisableInputs ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("DisableInputs" => x)
    /// If true, hue and alpha sliders will not be displayed.
    [<CustomOperation("DisableSliders")>] member inline _.DisableSliders ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("DisableSliders" => x)
    /// If true, the preview color box will not be displayed, note that the preview color functions as a button as well for collection colors.
    [<CustomOperation("DisablePreview")>] member inline _.DisablePreview ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("DisablePreview" => x)
    /// The initial mode (RGB, HSL or HEX) the picker should open. Defaults to RGB 
    [<CustomOperation("ColorPickerMode")>] member inline _.ColorPickerMode ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.ColorPickerMode) = render ==> ("ColorPickerMode" => x)
    /// The initial view of the picker. Views can be changed if toolbar is enabled. 
    [<CustomOperation("ColorPickerView")>] member inline _.ColorPickerView ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.ColorPickerView) = render ==> ("ColorPickerView" => x)
    /// If true, binding changes occurred also when HSL values changed without a corresponding RGB change 
    [<CustomOperation("UpdateBindingIfOnlyHSLChanged")>] member inline _.UpdateBindingIfOnlyHSLChanged ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("UpdateBindingIfOnlyHSLChanged" => x)
    /// A two-way bindable property representing the selected value. MudColor is a utility class that can be used to get the value as RGB, HSL, hex or other value
    [<CustomOperation("Value")>] member inline _.Value ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Utilities.MudColor) = render ==> ("Value" => x)
    /// A two-way bindable property representing the selected value. MudColor is a utility class that can be used to get the value as RGB, HSL, hex or other value
    [<CustomOperation("Value'")>] member inline _.Value' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: MudBlazor.Utilities.MudColor * (MudBlazor.Utilities.MudColor -> unit)) = render ==> html.bind("Value", valueFn)
    [<CustomOperation("ValueChanged")>] member inline _.ValueChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callback<MudBlazor.Utilities.MudColor>("ValueChanged", fn)
    [<CustomOperation("ValueChanged")>] member inline _.ValueChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callbackTask<MudBlazor.Utilities.MudColor>("ValueChanged", fn)
    /// MudColor list of predefined colors. The first five colors will show up as the quick colors on preview dot click.
    [<CustomOperation("Palette")>] member inline _.Palette ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.IEnumerable<MudBlazor.Utilities.MudColor>) = render ==> ("Palette" => x)
    /// When set to true, no mouse move events in the spectrum mode will be captured, so the selector circle won't fellow the mouse. 
    /// Under some conditions like long latency the visual representation might not reflect the user behaviour anymore. So, it can be disabled 
    /// Enabled by default
    [<CustomOperation("DisableDragEffect")>] member inline _.DisableDragEffect ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("DisableDragEffect" => x)
    /// Custom close icon.
    [<CustomOperation("CloseIcon")>] member inline _.CloseIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("CloseIcon" => x)
    /// Custom spectrum icon.
    [<CustomOperation("SpectrumIcon")>] member inline _.SpectrumIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("SpectrumIcon" => x)
    /// Custom grid icon.
    [<CustomOperation("GridIcon")>] member inline _.GridIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("GridIcon" => x)
    /// Custom palette icon.
    [<CustomOperation("PaletteIcon")>] member inline _.PaletteIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("PaletteIcon" => x)
    /// Custom import/export icont.
    [<CustomOperation("ImportExportIcon")>] member inline _.ImportExportIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("ImportExportIcon" => x)

type MudTimePickerBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudPickerBuilder<'FunBlazorGeneric, System.Nullable<System.TimeSpan>>()
    /// First view to show in the MudDatePicker.
    [<CustomOperation("OpenTo")>] member inline _.OpenTo ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.OpenTo) = render ==> ("OpenTo" => x)
    /// Choose the edition mode. By default, you can edit hours and minutes.
    [<CustomOperation("TimeEditMode")>] member inline _.TimeEditMode ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.TimeEditMode) = render ==> ("TimeEditMode" => x)
    /// Sets the amount of time in milliseconds to wait before closing the picker. This helps the user see that the time was selected before the popover disappears.
    [<CustomOperation("ClosingDelay")>] member inline _.ClosingDelay ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("ClosingDelay" => x)
    /// If AutoClose is set to true and PickerActions are defined, the hour and the minutes can be defined without any action.
    [<CustomOperation("AutoClose")>] member inline _.AutoClose ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("AutoClose" => x)
    /// If true, sets 12 hour selection clock.
    [<CustomOperation("AmPm")>] member inline _.AmPm ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("AmPm" => x)
    /// String Format for selected time view
    [<CustomOperation("TimeFormat")>] member inline _.TimeFormat ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("TimeFormat" => x)
    /// The currently selected time (two-way bindable). If null, then nothing was selected.
    [<CustomOperation("Time")>] member inline _.Time ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.TimeSpan>) = render ==> ("Time" => x)
    /// The currently selected time (two-way bindable). If null, then nothing was selected.
    [<CustomOperation("Time'")>] member inline _.Time' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.Nullable<System.TimeSpan> * (System.Nullable<System.TimeSpan> -> unit)) = render ==> html.bind("Time", valueFn)
    /// Fired when the date changes.
    [<CustomOperation("TimeChanged")>] member inline _.TimeChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callback<System.Nullable<System.TimeSpan>>("TimeChanged", fn)
    /// Fired when the date changes.
    [<CustomOperation("TimeChanged")>] member inline _.TimeChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callbackTask<System.Nullable<System.TimeSpan>>("TimeChanged", fn)

type MudRadioGroupBuilder<'FunBlazorGeneric, 'T when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudFormComponentBuilder<'FunBlazorGeneric, 'T, 'T>()
    /// User class names for the input, separated by space
    [<CustomOperation("InputClass")>] member inline _.InputClass ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("InputClass" => x)
    /// User style definitions for the input
    [<CustomOperation("InputStyle")>] member inline _.InputStyle ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("InputStyle" => x)
    [<CustomOperation("Name")>] member inline _.Name ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Name" => x)
    /// If true, the input will be disabled.
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("Disabled" => x)
    /// If true, the input will be read-only.
    [<CustomOperation("ReadOnly")>] member inline _.ReadOnly ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("ReadOnly" => x)
    [<CustomOperation("SelectedOption")>] member inline _.SelectedOption ([<InlineIfLambda>] render: AttrRenderFragment, x: 'T) = render ==> ("SelectedOption" => x)
    [<CustomOperation("SelectedOption'")>] member inline _.SelectedOption' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: 'T * ('T -> unit)) = render ==> html.bind("SelectedOption", valueFn)
    [<CustomOperation("SelectedOptionChanged")>] member inline _.SelectedOptionChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callback<'T>("SelectedOptionChanged", fn)
    [<CustomOperation("SelectedOptionChanged")>] member inline _.SelectedOptionChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callbackTask<'T>("SelectedOptionChanged", fn)

type MudAlertBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    /// Sets the position of the text to the start (Left in LTR and right in RTL).
    [<CustomOperation("ContentAlignment")>] member inline _.ContentAlignment ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.HorizontalAlignment) = render ==> ("ContentAlignment" => x)
    /// The callback, when the close button has been clicked.
    [<CustomOperation("CloseIconClicked")>] member inline _.CloseIconClicked ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callback<MudBlazor.MudAlert>("CloseIconClicked", fn)
    /// The callback, when the close button has been clicked.
    [<CustomOperation("CloseIconClicked")>] member inline _.CloseIconClicked ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callbackTask<MudBlazor.MudAlert>("CloseIconClicked", fn)
    /// Define the icon used for the close button.
    [<CustomOperation("CloseIcon")>] member inline _.CloseIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("CloseIcon" => x)
    /// Sets if the alert shows a close icon.
    [<CustomOperation("ShowCloseIcon")>] member inline _.ShowCloseIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("ShowCloseIcon" => x)
    /// The higher the number, the heavier the drop-shadow. 0 for no shadow.
    [<CustomOperation("Elevation")>] member inline _.Elevation ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("Elevation" => x)
    /// If true, rounded corners are disabled.
    [<CustomOperation("Square")>] member inline _.Square ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("Square" => x)
    /// If true, compact padding will be used.
    [<CustomOperation("Dense")>] member inline _.Dense ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("Dense" => x)
    /// If true, no alert icon will be used.
    [<CustomOperation("NoIcon")>] member inline _.NoIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("NoIcon" => x)
    /// The severity of the alert. This defines the color and icon used.
    [<CustomOperation("Severity")>] member inline _.Severity ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Severity) = render ==> ("Severity" => x)
    /// The variant to use.
    [<CustomOperation("Variant")>] member inline _.Variant ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Variant) = render ==> ("Variant" => x)
    /// Custom icon, leave unset to use the standard icon which depends on the Severity
    [<CustomOperation("Icon")>] member inline _.Icon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Icon" => x)
    /// Raised when the alert is clicked
    [<CustomOperation("OnClick")>] member inline _.OnClick ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>("OnClick", fn)
    /// Raised when the alert is clicked
    [<CustomOperation("OnClick")>] member inline _.OnClick ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callbackTask<Microsoft.AspNetCore.Components.Web.MouseEventArgs>("OnClick", fn)

type MudAppBarBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    /// If true, Appbar will be placed at the bottom of the screen.
    [<CustomOperation("Bottom")>] member inline _.Bottom ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("Bottom" => x)
    /// The higher the number, the heavier the drop-shadow. 0 for no shadow.
    [<CustomOperation("Elevation")>] member inline _.Elevation ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("Elevation" => x)
    /// If true, compact padding will be used.
    [<CustomOperation("Dense")>] member inline _.Dense ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("Dense" => x)
    /// If true, the left and right padding is removed from from the appbar.
    [<CustomOperation("DisableGutters")>] member inline _.DisableGutters ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("DisableGutters" => x)
    /// The color of the component. It supports the theme colors.
    [<CustomOperation("Color")>] member inline _.Color ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("Color" => x)
    /// If true, appbar will be Fixed.
    [<CustomOperation("Fixed")>] member inline _.Fixed ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("Fixed" => x)
    /// User class names, separated by spaces for the nested toolbar.
    [<CustomOperation("ToolBarClass")>] member inline _.ToolBarClass ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("ToolBarClass" => x)

type MudAvatarBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    /// The higher the number, the heavier the drop-shadow.
    [<CustomOperation("Elevation")>] member inline _.Elevation ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("Elevation" => x)
    /// If true, border-radius is set to 0.
    [<CustomOperation("Square")>] member inline _.Square ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("Square" => x)
    /// If true, border-radius is set to the themes default value.
    [<CustomOperation("Rounded")>] member inline _.Rounded ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("Rounded" => x)
    /// Link to image, if set a image will be displayed instead of text.
    [<CustomOperation("Image")>] member inline _.Image ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Image" => x)
    /// If set (and Image is also set), will add an alt property to the img element
    [<CustomOperation("Alt")>] member inline _.Alt ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Alt" => x)
    /// The color of the component. It supports the theme colors.
    [<CustomOperation("Color")>] member inline _.Color ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("Color" => x)
    /// The Size of the MudAvatar.
    [<CustomOperation("Size")>] member inline _.Size ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Size) = render ==> ("Size" => x)
    /// The variant to use.
    [<CustomOperation("Variant")>] member inline _.Variant ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Variant) = render ==> ("Variant" => x)

type MudAvatarGroupBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    /// Spacing between avatars where 0 is none and 16 max.
    [<CustomOperation("Spacing")>] member inline _.Spacing ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("Spacing" => x)
    /// Outlines the grouped avatars to distinguish them, useful when avatars are the same color or uses images.
    [<CustomOperation("Outlined")>] member inline _.Outlined ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("Outlined" => x)
    /// Sets the color of the outline if its used.
    [<CustomOperation("OutlineColor")>] member inline _.OutlineColor ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("OutlineColor" => x)
    /// Elevation of the MaxAvatar the higher the number, the heavier the drop-shadow.
    [<CustomOperation("MaxElevation")>] member inline _.MaxElevation ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("MaxElevation" => x)
    /// If true, MaxAvatar border-radius is set to 0.
    [<CustomOperation("MaxSquare")>] member inline _.MaxSquare ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("MaxSquare" => x)
    /// If true, MaxAvatar will be rounded.
    [<CustomOperation("MaxRounded")>] member inline _.MaxRounded ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("MaxRounded" => x)
    /// Color for the MaxAvatar.
    [<CustomOperation("MaxColor")>] member inline _.MaxColor ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("MaxColor" => x)
    /// Size of the MaxAvatar.
    [<CustomOperation("MaxSize")>] member inline _.MaxSize ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Size) = render ==> ("MaxSize" => x)
    /// Variant of the MaxAvatar.
    [<CustomOperation("MaxVariant")>] member inline _.MaxVariant ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Variant) = render ==> ("MaxVariant" => x)
    /// Max avatars to show before showing +x avatar, default value 0 has no max.
    [<CustomOperation("Max")>] member inline _.Max ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("Max" => x)
    /// Custom class/classes for MaxAvatar
    [<CustomOperation("MaxAvatarClass")>] member inline _.MaxAvatarClass ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("MaxAvatarClass" => x)

type MudBadgeBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    /// The placement of the badge.
    [<CustomOperation("Origin")>] member inline _.Origin ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Origin) = render ==> ("Origin" => x)
    /// The higher the number, the heavier the drop-shadow.
    [<CustomOperation("Elevation")>] member inline _.Elevation ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("Elevation" => x)
    /// The visibility of the badge.
    [<CustomOperation("Visible")>] member inline _.Visible ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("Visible" => x)
    /// The color of the badge.
    [<CustomOperation("Color")>] member inline _.Color ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("Color" => x)
    /// Reduces the size of the badge and hide any of its content.
    [<CustomOperation("Dot")>] member inline _.Dot ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("Dot" => x)
    /// Overlaps the childcontent on top of the content.
    [<CustomOperation("Overlap")>] member inline _.Overlap ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("Overlap" => x)
    /// Applies a border around the badge.
    [<CustomOperation("Bordered")>] member inline _.Bordered ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("Bordered" => x)
    /// Sets the Icon to use in the badge.
    [<CustomOperation("Icon")>] member inline _.Icon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Icon" => x)
    /// Max value to show when content is integer type.
    [<CustomOperation("Max")>] member inline _.Max ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("Max" => x)
    /// Content you want inside the badge. Supported types are string and integer.
    [<CustomOperation("Content")>] member inline _.Content ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Object) = render ==> ("Content" => x)
    /// Badge class names, separated by space.
    [<CustomOperation("BadgeClass")>] member inline _.BadgeClass ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("BadgeClass" => x)
    /// Button click event if set.
    [<CustomOperation("OnClick")>] member inline _.OnClick ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>("OnClick", fn)
    /// Button click event if set.
    [<CustomOperation("OnClick")>] member inline _.OnClick ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callbackTask<Microsoft.AspNetCore.Components.Web.MouseEventArgs>("OnClick", fn)

type MudBreadcrumbsBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    /// A list of breadcrumb items/links.
    [<CustomOperation("Items")>] member inline _.Items ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.List<MudBlazor.BreadcrumbItem>) = render ==> ("Items" => x)
    /// Specifies the separator between the items.
    [<CustomOperation("Separator")>] member inline _.Separator ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Separator" => x)
    /// Specifies a RenderFragment to use as the separator.
    [<CustomOperation("SeparatorTemplate")>] member inline _.SeparatorTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragment) = render ==> html.renderFragment("SeparatorTemplate", fragment)
    /// Specifies a RenderFragment to use as the separator.
    [<CustomOperation("SeparatorTemplate")>] member inline _.SeparatorTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragments) = render ==> html.renderFragment("SeparatorTemplate", fragment { yield! fragments })
    /// Specifies a RenderFragment to use as the separator.
    [<CustomOperation("SeparatorTemplate")>] member inline _.SeparatorTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("SeparatorTemplate", html.text x)
    /// Specifies a RenderFragment to use as the separator.
    [<CustomOperation("SeparatorTemplate")>] member inline _.SeparatorTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("SeparatorTemplate", html.text x)
    /// Specifies a RenderFragment to use as the separator.
    [<CustomOperation("SeparatorTemplate")>] member inline _.SeparatorTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("SeparatorTemplate", html.text x)
    /// Specifies a RenderFragment to use as the items' contents.
    [<CustomOperation("ItemTemplate")>] member inline _.ItemTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fn: MudBlazor.BreadcrumbItem -> NodeRenderFragment) = render ==> html.renderFragment("ItemTemplate", fn)
    /// Controls when (and if) the breadcrumbs will automatically collapse.
    [<CustomOperation("MaxItems")>] member inline _.MaxItems ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Byte>) = render ==> ("MaxItems" => x)
    /// Custom expander icon.
    [<CustomOperation("ExpanderIcon")>] member inline _.ExpanderIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("ExpanderIcon" => x)

type MudBreakpointProviderBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("OnBreakpointChanged")>] member inline _.OnBreakpointChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callback<MudBlazor.Breakpoint>("OnBreakpointChanged", fn)
    [<CustomOperation("OnBreakpointChanged")>] member inline _.OnBreakpointChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callbackTask<MudBlazor.Breakpoint>("OnBreakpointChanged", fn)

type MudToggleIconButtonBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    /// The toggled value.
    [<CustomOperation("Toggled")>] member inline _.Toggled ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("Toggled" => x)
    /// The toggled value.
    [<CustomOperation("Toggled'")>] member inline _.Toggled' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.Boolean * (System.Boolean -> unit)) = render ==> html.bind("Toggled", valueFn)
    /// Fires whenever toggled is changed. 
    [<CustomOperation("ToggledChanged")>] member inline _.ToggledChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callback<System.Boolean>("ToggledChanged", fn)
    /// Fires whenever toggled is changed. 
    [<CustomOperation("ToggledChanged")>] member inline _.ToggledChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callbackTask<System.Boolean>("ToggledChanged", fn)
    /// The Icon that will be used in the untoggled state.
    [<CustomOperation("Icon")>] member inline _.Icon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Icon" => x)
    /// The Icon that will be used in the toggled state.
    [<CustomOperation("ToggledIcon")>] member inline _.ToggledIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("ToggledIcon" => x)
    /// Title of the icon used for accessibility.
    [<CustomOperation("Title")>] member inline _.Title ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Title" => x)
    /// Title used in toggled state, if different.
    [<CustomOperation("ToggledTitle")>] member inline _.ToggledTitle ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("ToggledTitle" => x)
    /// The color of the icon in the untoggled state. It supports the theme colors.
    [<CustomOperation("Color")>] member inline _.Color ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("Color" => x)
    /// The color of the icon in the toggled state. It supports the theme colors.
    [<CustomOperation("ToggledColor")>] member inline _.ToggledColor ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("ToggledColor" => x)
    /// The Size of the component in the untoggled state.
    [<CustomOperation("Size")>] member inline _.Size ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Size) = render ==> ("Size" => x)
    /// The Size of the component in the toggled state.
    [<CustomOperation("ToggledSize")>] member inline _.ToggledSize ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Size) = render ==> ("ToggledSize" => x)
    /// If set uses a negative margin.
    [<CustomOperation("Edge")>] member inline _.Edge ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Edge) = render ==> ("Edge" => x)
    /// If true, disables ripple effect.
    [<CustomOperation("DisableRipple")>] member inline _.DisableRipple ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("DisableRipple" => x)
    /// If true, the button will be disabled.
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("Disabled" => x)
    /// The variant to use.
    [<CustomOperation("Variant")>] member inline _.Variant ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Variant) = render ==> ("Variant" => x)

type MudButtonGroupBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    /// If true, the button group will override the styles of the individual buttons.
    [<CustomOperation("OverrideStyles")>] member inline _.OverrideStyles ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("OverrideStyles" => x)
    /// If true, the button group will be displayed vertically.
    [<CustomOperation("VerticalAlign")>] member inline _.VerticalAlign ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("VerticalAlign" => x)
    /// If true, no drop-shadow will be used.
    [<CustomOperation("DisableElevation")>] member inline _.DisableElevation ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("DisableElevation" => x)
    /// The color of the component. It supports the theme colors.
    [<CustomOperation("Color")>] member inline _.Color ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("Color" => x)
    /// The size of the component.
    [<CustomOperation("Size")>] member inline _.Size ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Size) = render ==> ("Size" => x)
    /// The variant to use.
    [<CustomOperation("Variant")>] member inline _.Variant ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Variant) = render ==> ("Variant" => x)

type MudCardBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    /// The higher the number, the heavier the drop-shadow. 0 for no shadow.
    [<CustomOperation("Elevation")>] member inline _.Elevation ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("Elevation" => x)
    /// If true, border-radius is set to 0.
    [<CustomOperation("Square")>] member inline _.Square ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("Square" => x)
    /// If true, card will be outlined.
    [<CustomOperation("Outlined")>] member inline _.Outlined ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("Outlined" => x)

type MudCardActionsBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()


type MudCardContentBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()


type MudCardHeaderBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    /// If used renders child content of the CardHeaderAvatar.
    [<CustomOperation("CardHeaderAvatar")>] member inline _.CardHeaderAvatar ([<InlineIfLambda>] render: AttrRenderFragment, fragment) = render ==> html.renderFragment("CardHeaderAvatar", fragment)
    /// If used renders child content of the CardHeaderAvatar.
    [<CustomOperation("CardHeaderAvatar")>] member inline _.CardHeaderAvatar ([<InlineIfLambda>] render: AttrRenderFragment, fragments) = render ==> html.renderFragment("CardHeaderAvatar", fragment { yield! fragments })
    /// If used renders child content of the CardHeaderAvatar.
    [<CustomOperation("CardHeaderAvatar")>] member inline _.CardHeaderAvatar ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("CardHeaderAvatar", html.text x)
    /// If used renders child content of the CardHeaderAvatar.
    [<CustomOperation("CardHeaderAvatar")>] member inline _.CardHeaderAvatar ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("CardHeaderAvatar", html.text x)
    /// If used renders child content of the CardHeaderAvatar.
    [<CustomOperation("CardHeaderAvatar")>] member inline _.CardHeaderAvatar ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("CardHeaderAvatar", html.text x)
    /// If used renders child content of the CardHeaderContent.
    [<CustomOperation("CardHeaderContent")>] member inline _.CardHeaderContent ([<InlineIfLambda>] render: AttrRenderFragment, fragment) = render ==> html.renderFragment("CardHeaderContent", fragment)
    /// If used renders child content of the CardHeaderContent.
    [<CustomOperation("CardHeaderContent")>] member inline _.CardHeaderContent ([<InlineIfLambda>] render: AttrRenderFragment, fragments) = render ==> html.renderFragment("CardHeaderContent", fragment { yield! fragments })
    /// If used renders child content of the CardHeaderContent.
    [<CustomOperation("CardHeaderContent")>] member inline _.CardHeaderContent ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("CardHeaderContent", html.text x)
    /// If used renders child content of the CardHeaderContent.
    [<CustomOperation("CardHeaderContent")>] member inline _.CardHeaderContent ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("CardHeaderContent", html.text x)
    /// If used renders child content of the CardHeaderContent.
    [<CustomOperation("CardHeaderContent")>] member inline _.CardHeaderContent ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("CardHeaderContent", html.text x)
    /// If used renders child content of the CardHeaderActions.
    [<CustomOperation("CardHeaderActions")>] member inline _.CardHeaderActions ([<InlineIfLambda>] render: AttrRenderFragment, fragment) = render ==> html.renderFragment("CardHeaderActions", fragment)
    /// If used renders child content of the CardHeaderActions.
    [<CustomOperation("CardHeaderActions")>] member inline _.CardHeaderActions ([<InlineIfLambda>] render: AttrRenderFragment, fragments) = render ==> html.renderFragment("CardHeaderActions", fragment { yield! fragments })
    /// If used renders child content of the CardHeaderActions.
    [<CustomOperation("CardHeaderActions")>] member inline _.CardHeaderActions ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("CardHeaderActions", html.text x)
    /// If used renders child content of the CardHeaderActions.
    [<CustomOperation("CardHeaderActions")>] member inline _.CardHeaderActions ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("CardHeaderActions", html.text x)
    /// If used renders child content of the CardHeaderActions.
    [<CustomOperation("CardHeaderActions")>] member inline _.CardHeaderActions ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("CardHeaderActions", html.text x)

type MudCardMediaBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    /// Title of the image used for accessibility.
    [<CustomOperation("Title")>] member inline _.Title ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Title" => x)
    /// Specifies the path to the image.
    [<CustomOperation("Image")>] member inline _.Image ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Image" => x)
    /// Specifies the height of the image in px.
    [<CustomOperation("Height")>] member inline _.Height ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("Height" => x)

type MudCarouselItemBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    /// The color of the component. It supports the theme colors.
    [<CustomOperation("Color")>] member inline _.Color ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("Color" => x)
    /// The transition effect of the component.
    [<CustomOperation("Transition")>] member inline _.Transition ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Transition) = render ==> ("Transition" => x)
    /// The name of custom transition on entrance time
    [<CustomOperation("CustomTransitionEnter")>] member inline _.CustomTransitionEnter ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("CustomTransitionEnter" => x)
    /// The name of custom transition on exiting time
    [<CustomOperation("CustomTransitionExit")>] member inline _.CustomTransitionExit ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("CustomTransitionExit" => x)

type MudChipBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    /// The color of the component.
    [<CustomOperation("Color")>] member inline _.Color ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("Color" => x)
    /// The size of the button. small is equivalent to the dense button styling.
    [<CustomOperation("Size")>] member inline _.Size ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Size) = render ==> ("Size" => x)
    /// The variant to use.
    [<CustomOperation("Variant")>] member inline _.Variant ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Variant) = render ==> ("Variant" => x)
    /// The selected color to use when selected, only works together with ChipSet, Color.Inherit for default value.
    [<CustomOperation("SelectedColor")>] member inline _.SelectedColor ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("SelectedColor" => x)
    /// Avatar Icon, Overrides the regular Icon if set.
    [<CustomOperation("Avatar")>] member inline _.Avatar ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Avatar" => x)
    /// Avatar CSS Class, appends to Chips default avatar classes.
    [<CustomOperation("AvatarClass")>] member inline _.AvatarClass ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("AvatarClass" => x)
    /// Removes circle edges and applies theme default.
    [<CustomOperation("Label")>] member inline _.Label ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("Label" => x)
    /// If true, the chip will be displayed in disabled state and no events possible.
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("Disabled" => x)
    /// Sets the Icon to use.
    [<CustomOperation("Icon")>] member inline _.Icon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Icon" => x)
    /// Custom checked icon.
    [<CustomOperation("CheckedIcon")>] member inline _.CheckedIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("CheckedIcon" => x)
    /// The color of the icon.
    [<CustomOperation("IconColor")>] member inline _.IconColor ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("IconColor" => x)
    /// Overrides the default close icon, only shown if OnClose is set.
    [<CustomOperation("CloseIcon")>] member inline _.CloseIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("CloseIcon" => x)
    /// If true, disables ripple effect, ripple effect is only applied to clickable chips.
    [<CustomOperation("DisableRipple")>] member inline _.DisableRipple ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("DisableRipple" => x)
    /// If set to a URL, clicking the button will open the referenced document. Use Target to specify where (Obsolete replaced by Href)
    [<CustomOperation("Link")>] member inline _.Link ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Link" => x)
    /// If set to a URL, clicking the button will open the referenced document. Use Target to specify where
    [<CustomOperation("Href")>] member inline _.Href ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Href" => x)
    /// The target attribute specifies where to open the link, if Href is specified. Possible values: _blank | _self | _parent | _top | framename
    [<CustomOperation("Target")>] member inline _.Target ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Target" => x)
    /// A string you want to associate with the chip. If the ChildContent is not set this will be shown as chip text.
    [<CustomOperation("Text")>] member inline _.Text ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Text" => x)
    /// A value that should be managed in the SelectedValues collection.
    /// Note: do not change the value during the chip's lifetime
    [<CustomOperation("Value")>] member inline _.Value ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Object) = render ==> ("Value" => x)
    /// If true, force browser to redirect outside component router-space.
    [<CustomOperation("ForceLoad")>] member inline _.ForceLoad ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("ForceLoad" => x)
    /// If true, this chip is selected by default if used in a ChipSet.
    [<CustomOperation("Default")>] member inline _.Default ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Boolean>) = render ==> ("Default" => x)
    /// Command executed when the user clicks on an element.
    [<CustomOperation("Command")>] member inline _.Command ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Windows.Input.ICommand) = render ==> ("Command" => x)
    /// Command parameter.
    [<CustomOperation("CommandParameter")>] member inline _.CommandParameter ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Object) = render ==> ("CommandParameter" => x)
    /// Chip click event, if set the chip focus, hover and click effects are applied.
    [<CustomOperation("OnClick")>] member inline _.OnClick ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>("OnClick", fn)
    /// Chip click event, if set the chip focus, hover and click effects are applied.
    [<CustomOperation("OnClick")>] member inline _.OnClick ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callbackTask<Microsoft.AspNetCore.Components.Web.MouseEventArgs>("OnClick", fn)
    /// Chip delete event, if set the delete icon will be visible.
    [<CustomOperation("OnClose")>] member inline _.OnClose ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callback<MudBlazor.MudChip>("OnClose", fn)
    /// Chip delete event, if set the delete icon will be visible.
    [<CustomOperation("OnClose")>] member inline _.OnClose ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callbackTask<MudBlazor.MudChip>("OnClose", fn)

type MudChipSetBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    /// Allows to select more than one chip.
    [<CustomOperation("MultiSelection")>] member inline _.MultiSelection ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("MultiSelection" => x)
    /// Will not allow to deselect the selected chip in single selection mode.
    [<CustomOperation("Mandatory")>] member inline _.Mandatory ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("Mandatory" => x)
    /// Will make all chips closable.
    [<CustomOperation("AllClosable")>] member inline _.AllClosable ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("AllClosable" => x)
    /// Will show a check-mark for the selected components.
    ///             
    [<CustomOperation("Filter")>] member inline _.Filter ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("Filter" => x)
    /// Will make all chips read only.
    ///             
    [<CustomOperation("ReadOnly")>] member inline _.ReadOnly ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("ReadOnly" => x)
    /// The currently selected chip in Choice mode
    [<CustomOperation("SelectedChip")>] member inline _.SelectedChip ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.MudChip) = render ==> ("SelectedChip" => x)
    /// The currently selected chip in Choice mode
    [<CustomOperation("SelectedChip'")>] member inline _.SelectedChip' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: MudBlazor.MudChip * (MudBlazor.MudChip -> unit)) = render ==> html.bind("SelectedChip", valueFn)
    /// Called when the selected chip changes, in Choice mode
    [<CustomOperation("SelectedChipChanged")>] member inline _.SelectedChipChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callback<MudBlazor.MudChip>("SelectedChipChanged", fn)
    /// Called when the selected chip changes, in Choice mode
    [<CustomOperation("SelectedChipChanged")>] member inline _.SelectedChipChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callbackTask<MudBlazor.MudChip>("SelectedChipChanged", fn)
    /// The currently selected chips in Filter mode
    [<CustomOperation("SelectedChips")>] member inline _.SelectedChips ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.MudChip[]) = render ==> ("SelectedChips" => x)
    /// The currently selected chips in Filter mode
    [<CustomOperation("SelectedChips'")>] member inline _.SelectedChips' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: MudBlazor.MudChip[] * (MudBlazor.MudChip[] -> unit)) = render ==> html.bind("SelectedChips", valueFn)
    /// The Comparer to use for comparing selected values internally.
    [<CustomOperation("Comparer")>] member inline _.Comparer ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.IEqualityComparer<System.Object>) = render ==> ("Comparer" => x)
    /// Called when the selection changed, in Filter mode
    [<CustomOperation("SelectedChipsChanged")>] member inline _.SelectedChipsChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callback<MudBlazor.MudChip[]>("SelectedChipsChanged", fn)
    /// Called when the selection changed, in Filter mode
    [<CustomOperation("SelectedChipsChanged")>] member inline _.SelectedChipsChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callbackTask<MudBlazor.MudChip[]>("SelectedChipsChanged", fn)
    /// The current selected value.
    /// Note: make the list Clickable for item selection to work.
    [<CustomOperation("SelectedValues")>] member inline _.SelectedValues ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.ICollection<System.Object>) = render ==> ("SelectedValues" => x)
    /// The current selected value.
    /// Note: make the list Clickable for item selection to work.
    [<CustomOperation("SelectedValues'")>] member inline _.SelectedValues' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.Collections.Generic.ICollection<System.Object> * (System.Collections.Generic.ICollection<System.Object> -> unit)) = render ==> html.bind("SelectedValues", valueFn)
    /// Called whenever the selection changed
    [<CustomOperation("SelectedValuesChanged")>] member inline _.SelectedValuesChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callback<System.Collections.Generic.ICollection<System.Object>>("SelectedValuesChanged", fn)
    /// Called whenever the selection changed
    [<CustomOperation("SelectedValuesChanged")>] member inline _.SelectedValuesChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callbackTask<System.Collections.Generic.ICollection<System.Object>>("SelectedValuesChanged", fn)
    /// Called when a Chip was deleted (by click on the close icon)
    [<CustomOperation("OnClose")>] member inline _.OnClose ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callback<MudBlazor.MudChip>("OnClose", fn)
    /// Called when a Chip was deleted (by click on the close icon)
    [<CustomOperation("OnClose")>] member inline _.OnClose ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callbackTask<MudBlazor.MudChip>("OnClose", fn)

type MudCollapseBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    /// If true, expands the panel, otherwise collapse it. Setting this prop enables control over the panel.
    [<CustomOperation("Expanded")>] member inline _.Expanded ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("Expanded" => x)
    /// If true, expands the panel, otherwise collapse it. Setting this prop enables control over the panel.
    [<CustomOperation("Expanded'")>] member inline _.Expanded' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.Boolean * (System.Boolean -> unit)) = render ==> html.bind("Expanded", valueFn)
    /// Explicitly sets the height for the Collapse element to override the css default.
    [<CustomOperation("MaxHeight")>] member inline _.MaxHeight ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Int32>) = render ==> ("MaxHeight" => x)
    [<CustomOperation("OnAnimationEnd")>] member inline _.OnAnimationEnd ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callback("OnAnimationEnd", fn)
    [<CustomOperation("OnAnimationEnd")>] member inline _.OnAnimationEnd ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callbackTask("OnAnimationEnd", fn)
    [<CustomOperation("ExpandedChanged")>] member inline _.ExpandedChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callback<System.Boolean>("ExpandedChanged", fn)
    [<CustomOperation("ExpandedChanged")>] member inline _.ExpandedChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callbackTask<System.Boolean>("ExpandedChanged", fn)

type ColumnBuilder<'FunBlazorGeneric, 'T when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Value")>] member inline _.Value ([<InlineIfLambda>] render: AttrRenderFragment, x: 'T) = render ==> ("Value" => x)
    [<CustomOperation("Value'")>] member inline _.Value' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: 'T * ('T -> unit)) = render ==> html.bind("Value", valueFn)
    [<CustomOperation("ValueChanged")>] member inline _.ValueChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callback<'T>("ValueChanged", fn)
    [<CustomOperation("ValueChanged")>] member inline _.ValueChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callbackTask<'T>("ValueChanged", fn)
    /// Specifies the name of the object's property bound to the column
    [<CustomOperation("Title")>] member inline _.Title ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Title" => x)
    [<CustomOperation("HideSmall")>] member inline _.HideSmall ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("HideSmall" => x)
    [<CustomOperation("FooterColSpan")>] member inline _.FooterColSpan ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("FooterColSpan" => x)
    [<CustomOperation("HeaderColSpan")>] member inline _.HeaderColSpan ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("HeaderColSpan" => x)
    [<CustomOperation("HeaderTemplate")>] member inline _.HeaderTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fn: MudBlazor.HeaderContext<'T> -> NodeRenderFragment) = render ==> html.renderFragment("HeaderTemplate", fn)
    [<CustomOperation("CellTemplate")>] member inline _.CellTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fn: MudBlazor.CellContext<'T> -> NodeRenderFragment) = render ==> html.renderFragment("CellTemplate", fn)
    [<CustomOperation("FooterTemplate")>] member inline _.FooterTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fn: MudBlazor.FooterContext<'T> -> NodeRenderFragment) = render ==> html.renderFragment("FooterTemplate", fn)
    [<CustomOperation("GroupTemplate")>] member inline _.GroupTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fn: MudBlazor.GroupDefinition<'T> -> NodeRenderFragment) = render ==> html.renderFragment("GroupTemplate", fn)
    [<CustomOperation("GroupBy")>] member inline _.GroupBy ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("GroupBy" => (System.Func<'T, System.Object>fn))
    [<CustomOperation("HeaderClass")>] member inline _.HeaderClass ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("HeaderClass" => x)
    [<CustomOperation("HeaderClassFunc")>] member inline _.HeaderClassFunc ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("HeaderClassFunc" => (System.Func<'T, System.String>fn))
    [<CustomOperation("HeaderStyle")>] member inline _.HeaderStyle ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("HeaderStyle" => x)
    [<CustomOperation("HeaderStyleFunc")>] member inline _.HeaderStyleFunc ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("HeaderStyleFunc" => (System.Func<'T, System.String>fn))
    /// Determines whether this columns data can be sorted. This overrides the Sortable parameter on the DataGrid.
    [<CustomOperation("Sortable")>] member inline _.Sortable ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Boolean>) = render ==> ("Sortable" => x)
    [<CustomOperation("Resizable")>] member inline _.Resizable ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Boolean>) = render ==> ("Resizable" => x)
    /// Determines whether this columns data can be filtered. This overrides the Filterable parameter on the DataGrid.
    [<CustomOperation("Filterable")>] member inline _.Filterable ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Boolean>) = render ==> ("Filterable" => x)
    [<CustomOperation("ShowFilterIcon")>] member inline _.ShowFilterIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Boolean>) = render ==> ("ShowFilterIcon" => x)
    /// Determines whether this column can be hidden. This overrides the Hideable parameter on the DataGrid.
    [<CustomOperation("Hideable")>] member inline _.Hideable ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Boolean>) = render ==> ("Hideable" => x)
    [<CustomOperation("Hidden")>] member inline _.Hidden ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("Hidden" => x)
    [<CustomOperation("Hidden'")>] member inline _.Hidden' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.Boolean * (System.Boolean -> unit)) = render ==> html.bind("Hidden", valueFn)
    [<CustomOperation("HiddenChanged")>] member inline _.HiddenChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callback<System.Boolean>("HiddenChanged", fn)
    [<CustomOperation("HiddenChanged")>] member inline _.HiddenChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callbackTask<System.Boolean>("HiddenChanged", fn)
    /// Determines whether to show or hide column options. This overrides the ShowColumnOptions parameter on the DataGrid.
    [<CustomOperation("ShowColumnOptions")>] member inline _.ShowColumnOptions ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Boolean>) = render ==> ("ShowColumnOptions" => x)
    [<CustomOperation("SortBy")>] member inline _.SortBy ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("SortBy" => (System.Func<'T, System.Object>fn))
    [<CustomOperation("InitialDirection")>] member inline _.InitialDirection ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.SortDirection) = render ==> ("InitialDirection" => x)
    [<CustomOperation("SortIcon")>] member inline _.SortIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("SortIcon" => x)
    /// Specifies whether the column can be grouped.
    [<CustomOperation("Groupable")>] member inline _.Groupable ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Boolean>) = render ==> ("Groupable" => x)
    /// Specifies whether the column is grouped.
    [<CustomOperation("Grouping")>] member inline _.Grouping ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("Grouping" => x)
    /// Specifies whether the column is sticky.
    [<CustomOperation("StickyLeft")>] member inline _.StickyLeft ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("StickyLeft" => x)
    [<CustomOperation("StickyRight")>] member inline _.StickyRight ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("StickyRight" => x)
    [<CustomOperation("FilterTemplate")>] member inline _.FilterTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fn: MudBlazor.FilterContext<'T> -> NodeRenderFragment) = render ==> html.renderFragment("FilterTemplate", fn)
    /// The culture used to represent this column and by the filtering input field.
    [<CustomOperation("Culture")>] member inline _.Culture ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Globalization.CultureInfo) = render ==> ("Culture" => x)
    [<CustomOperation("CellClass")>] member inline _.CellClass ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("CellClass" => x)
    [<CustomOperation("CellClassFunc")>] member inline _.CellClassFunc ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("CellClassFunc" => (System.Func<'T, System.String>fn))
    [<CustomOperation("CellStyle")>] member inline _.CellStyle ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("CellStyle" => x)
    [<CustomOperation("CellStyleFunc")>] member inline _.CellStyleFunc ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("CellStyleFunc" => (System.Func<'T, System.String>fn))
    [<CustomOperation("IsEditable")>] member inline _.IsEditable ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("IsEditable" => x)
    [<CustomOperation("EditTemplate")>] member inline _.EditTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fn: MudBlazor.CellContext<'T> -> NodeRenderFragment) = render ==> html.renderFragment("EditTemplate", fn)
    [<CustomOperation("FooterClass")>] member inline _.FooterClass ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("FooterClass" => x)
    [<CustomOperation("FooterClassFunc")>] member inline _.FooterClassFunc ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("FooterClassFunc" => (System.Func<'T, System.String>fn))
    [<CustomOperation("FooterStyle")>] member inline _.FooterStyle ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("FooterStyle" => x)
    [<CustomOperation("FooterStyleFunc")>] member inline _.FooterStyleFunc ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("FooterStyleFunc" => (System.Func<'T, System.String>fn))
    [<CustomOperation("EnableFooterSelection")>] member inline _.EnableFooterSelection ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("EnableFooterSelection" => x)
    [<CustomOperation("AggregateDefinition")>] member inline _.AggregateDefinition ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.AggregateDefinition<'T>) = render ==> ("AggregateDefinition" => x)

type PropertyColumnBuilder<'FunBlazorGeneric, 'T, 'TProperty when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ColumnBuilder<'FunBlazorGeneric, 'T>()
    [<CustomOperation("Property")>] member inline _.Property ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Linq.Expressions.Expression<System.Func<'T, 'TProperty>>) = render ==> ("Property" => x)
    [<CustomOperation("Format")>] member inline _.Format ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Format" => x)

type TemplateColumnBuilder<'FunBlazorGeneric, 'T when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ColumnBuilder<'FunBlazorGeneric, 'T>()


type FilterHeaderCellBuilder<'FunBlazorGeneric, 'T when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Column")>] member inline _.Column ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Column<'T>) = render ==> ("Column" => x)

type FooterCellBuilder<'FunBlazorGeneric, 'T when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Column")>] member inline _.Column ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Column<'T>) = render ==> ("Column" => x)
    [<CustomOperation("CurrentItems")>] member inline _.CurrentItems ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.IEnumerable<'T>) = render ==> ("CurrentItems" => x)

type HeaderCellBuilder<'FunBlazorGeneric, 'T when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Column")>] member inline _.Column ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Column<'T>) = render ==> ("Column" => x)
    [<CustomOperation("SortDirection")>] member inline _.SortDirection ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.SortDirection) = render ==> ("SortDirection" => x)

type MudDataGridBuilder<'FunBlazorGeneric, 'T when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    /// Callback is called when a row has been clicked and returns the selected item.
    [<CustomOperation("SelectedItemChanged")>] member inline _.SelectedItemChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callback<'T>("SelectedItemChanged", fn)
    /// Callback is called when a row has been clicked and returns the selected item.
    [<CustomOperation("SelectedItemChanged")>] member inline _.SelectedItemChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callbackTask<'T>("SelectedItemChanged", fn)
    /// Callback is called whenever items are selected or deselected in multi selection mode.
    [<CustomOperation("SelectedItemsChanged")>] member inline _.SelectedItemsChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callback<System.Collections.Generic.HashSet<'T>>("SelectedItemsChanged", fn)
    /// Callback is called whenever items are selected or deselected in multi selection mode.
    [<CustomOperation("SelectedItemsChanged")>] member inline _.SelectedItemsChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callbackTask<System.Collections.Generic.HashSet<'T>>("SelectedItemsChanged", fn)
    /// Callback is called whenever a row is clicked.
    [<CustomOperation("RowClick")>] member inline _.RowClick ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callback<MudBlazor.DataGridRowClickEventArgs<'T>>("RowClick", fn)
    /// Callback is called whenever a row is clicked.
    [<CustomOperation("RowClick")>] member inline _.RowClick ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callbackTask<MudBlazor.DataGridRowClickEventArgs<'T>>("RowClick", fn)
    /// Callback is called when an item has begun to be edited. Returns the item being edited.
    [<CustomOperation("StartedEditingItem")>] member inline _.StartedEditingItem ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callback<'T>("StartedEditingItem", fn)
    /// Callback is called when an item has begun to be edited. Returns the item being edited.
    [<CustomOperation("StartedEditingItem")>] member inline _.StartedEditingItem ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callbackTask<'T>("StartedEditingItem", fn)
    /// Callback is called when the process of editing an item has been canceled. Returns the item which was previously in edit mode.
    [<CustomOperation("CanceledEditingItem")>] member inline _.CanceledEditingItem ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callback<'T>("CanceledEditingItem", fn)
    /// Callback is called when the process of editing an item has been canceled. Returns the item which was previously in edit mode.
    [<CustomOperation("CanceledEditingItem")>] member inline _.CanceledEditingItem ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callbackTask<'T>("CanceledEditingItem", fn)
    /// Callback is called when the process of editing an item has been canceled. Returns the item which was previously in edit mode.
    /// NOTE: Obsolete, use CanceledEditingItem instead
    [<CustomOperation("CancelledEditingItem")>] member inline _.CancelledEditingItem ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callback<'T>("CancelledEditingItem", fn)
    /// Callback is called when the process of editing an item has been canceled. Returns the item which was previously in edit mode.
    /// NOTE: Obsolete, use CanceledEditingItem instead
    [<CustomOperation("CancelledEditingItem")>] member inline _.CancelledEditingItem ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callbackTask<'T>("CancelledEditingItem", fn)
    /// Callback is called when the changes to an item are committed. Returns the item whose changes were committed.
    [<CustomOperation("CommittedItemChanges")>] member inline _.CommittedItemChanges ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callback<'T>("CommittedItemChanges", fn)
    /// Callback is called when the changes to an item are committed. Returns the item whose changes were committed.
    [<CustomOperation("CommittedItemChanges")>] member inline _.CommittedItemChanges ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callbackTask<'T>("CommittedItemChanges", fn)
    /// Callback is called when a field changes in the dialog MudForm. Only works in EditMode.Form
    [<CustomOperation("FormFieldChanged")>] member inline _.FormFieldChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callback<MudBlazor.Utilities.FormFieldChangedEventArgs>("FormFieldChanged", fn)
    /// Callback is called when a field changes in the dialog MudForm. Only works in EditMode.Form
    [<CustomOperation("FormFieldChanged")>] member inline _.FormFieldChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callbackTask<MudBlazor.Utilities.FormFieldChangedEventArgs>("FormFieldChanged", fn)
    /// Controls whether data in the DataGrid can be sorted. This is overridable by each column.
    [<CustomOperation("SortMode")>] member inline _.SortMode ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.SortMode) = render ==> ("SortMode" => x)
    /// Controls whether data in the DataGrid can be filtered. This is overridable by each column.
    [<CustomOperation("Filterable")>] member inline _.Filterable ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("Filterable" => x)
    /// Controls whether columns in the DataGrid can be hidden. This is overridable by each column.
    [<CustomOperation("Hideable")>] member inline _.Hideable ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("Hideable" => x)
    /// Controls whether to hide or show the column options. This is overridable by each column.
    [<CustomOperation("ShowColumnOptions")>] member inline _.ShowColumnOptions ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("ShowColumnOptions" => x)
    /// At what breakpoint the table should switch to mobile layout. Takes None, Xs, Sm, Md, Lg and Xl the default behavior is breaking on Xs.
    [<CustomOperation("Breakpoint")>] member inline _.Breakpoint ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Breakpoint) = render ==> ("Breakpoint" => x)
    /// The higher the number, the heavier the drop-shadow. 0 for no shadow.
    [<CustomOperation("Elevation")>] member inline _.Elevation ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("Elevation" => x)
    /// Set true to disable rounded corners
    [<CustomOperation("Square")>] member inline _.Square ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("Square" => x)
    /// If true, table will be outlined.
    [<CustomOperation("Outlined")>] member inline _.Outlined ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("Outlined" => x)
    /// If true, table's cells will have left/right borders.
    [<CustomOperation("Bordered")>] member inline _.Bordered ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("Bordered" => x)
    /// Specifies a group of one or more columns in a table for formatting.
    /// Ex:
    /// table
    ///     colgroup
    ///        col span="2" style="background-color:red"
    ///        col style="background-color:yellow"
    ///      colgroup
    ///      header
    ///      body
    /// table
    [<CustomOperation("ColGroup")>] member inline _.ColGroup ([<InlineIfLambda>] render: AttrRenderFragment, fragment) = render ==> html.renderFragment("ColGroup", fragment)
    /// Specifies a group of one or more columns in a table for formatting.
    /// Ex:
    /// table
    ///     colgroup
    ///        col span="2" style="background-color:red"
    ///        col style="background-color:yellow"
    ///      colgroup
    ///      header
    ///      body
    /// table
    [<CustomOperation("ColGroup")>] member inline _.ColGroup ([<InlineIfLambda>] render: AttrRenderFragment, fragments) = render ==> html.renderFragment("ColGroup", fragment { yield! fragments })
    /// Specifies a group of one or more columns in a table for formatting.
    /// Ex:
    /// table
    ///     colgroup
    ///        col span="2" style="background-color:red"
    ///        col style="background-color:yellow"
    ///      colgroup
    ///      header
    ///      body
    /// table
    [<CustomOperation("ColGroup")>] member inline _.ColGroup ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("ColGroup", html.text x)
    /// Specifies a group of one or more columns in a table for formatting.
    /// Ex:
    /// table
    ///     colgroup
    ///        col span="2" style="background-color:red"
    ///        col style="background-color:yellow"
    ///      colgroup
    ///      header
    ///      body
    /// table
    [<CustomOperation("ColGroup")>] member inline _.ColGroup ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("ColGroup", html.text x)
    /// Specifies a group of one or more columns in a table for formatting.
    /// Ex:
    /// table
    ///     colgroup
    ///        col span="2" style="background-color:red"
    ///        col style="background-color:yellow"
    ///      colgroup
    ///      header
    ///      body
    /// table
    [<CustomOperation("ColGroup")>] member inline _.ColGroup ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("ColGroup", html.text x)
    /// Set true for rows with a narrow height
    [<CustomOperation("Dense")>] member inline _.Dense ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("Dense" => x)
    /// Set true to see rows hover on mouse-over.
    [<CustomOperation("Hover")>] member inline _.Hover ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("Hover" => x)
    /// If true, striped table rows will be used.
    [<CustomOperation("Striped")>] member inline _.Striped ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("Striped" => x)
    /// When true, the header will stay in place when the table is scrolled. Note: set Height to make the table scrollable.
    [<CustomOperation("FixedHeader")>] member inline _.FixedHeader ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("FixedHeader" => x)
    /// When true, the footer will be visible is not scrolled to the bottom. Note: set Height to make the table scrollable.
    [<CustomOperation("FixedFooter")>] member inline _.FixedFooter ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("FixedFooter" => x)
    [<CustomOperation("ShowFilterIcons")>] member inline _.ShowFilterIcons ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("ShowFilterIcons" => x)
    [<CustomOperation("FilterMode")>] member inline _.FilterMode ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.DataGridFilterMode) = render ==> ("FilterMode" => x)
    [<CustomOperation("FilterCaseSensitivity")>] member inline _.FilterCaseSensitivity ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.DataGridFilterCaseSensitivity) = render ==> ("FilterCaseSensitivity" => x)
    [<CustomOperation("FilterTemplate")>] member inline _.FilterTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fn: MudBlazor.MudDataGrid<'T> -> NodeRenderFragment) = render ==> html.renderFragment("FilterTemplate", fn)
    /// The list of FilterDefinitions that have been added to the data grid. FilterDefinitions are managed by the data
    /// grid automatically when using the built in filter UI. You can also programmatically manage these definitions
    /// through this collection.
    [<CustomOperation("FilterDefinitions")>] member inline _.FilterDefinitions ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.List<MudBlazor.FilterDefinition<'T>>) = render ==> ("FilterDefinitions" => x)
    /// The list of SortDefinitions that have been added to the data grid. SortDefinitions are managed by the data
    /// grid automatically when using the built in filter UI. You can also programmatically manage these definitions
    /// through this collection.
    [<CustomOperation("SortDefinitions")>] member inline _.SortDefinitions ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.Dictionary<System.String, MudBlazor.SortDefinition<'T>>) = render ==> ("SortDefinitions" => x)
    /// If true, the results are displayed in a Virtualize component, allowing a boost in rendering speed.
    [<CustomOperation("Virtualize")>] member inline _.Virtualize ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("Virtualize" => x)
    /// Gets or sets a value that determines how many additional items will be rendered
    /// before and after the visible region. This help to reduce the frequency of rendering
    /// during scrolling. However, higher values mean that more elements will be present
    /// in the page.
    /// Only used for virtualization.
    [<CustomOperation("OverscanCount")>] member inline _.OverscanCount ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("OverscanCount" => x)
    /// CSS class for the table rows. Note, many CSS settings are overridden by MudTd though
    [<CustomOperation("RowClass")>] member inline _.RowClass ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("RowClass" => x)
    /// CSS styles for the table rows. Note, many CSS settings are overridden by MudTd though
    [<CustomOperation("RowStyle")>] member inline _.RowStyle ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("RowStyle" => x)
    /// Returns the class that will get joined with RowClass. Takes the current item and row index.
    [<CustomOperation("RowClassFunc")>] member inline _.RowClassFunc ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("RowClassFunc" => (System.Func<'T, System.Int32, System.String>fn))
    /// Returns the class that will get joined with RowClass. Takes the current item and row index.
    [<CustomOperation("RowStyleFunc")>] member inline _.RowStyleFunc ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("RowStyleFunc" => (System.Func<'T, System.Int32, System.String>fn))
    /// Set to true to enable selection of multiple rows.
    [<CustomOperation("MultiSelection")>] member inline _.MultiSelection ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("MultiSelection" => x)
    /// When the grid is not read only, you can specify what type of editing mode to use.
    [<CustomOperation("EditMode")>] member inline _.EditMode ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<MudBlazor.DataGridEditMode>) = render ==> ("EditMode" => x)
    /// Allows you to specify the action that will trigger an edit when the EditMode is Form.
    [<CustomOperation("EditTrigger")>] member inline _.EditTrigger ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<MudBlazor.DataGridEditTrigger>) = render ==> ("EditTrigger" => x)
    /// Fine tune the edit dialog.
    [<CustomOperation("EditDialogOptions")>] member inline _.EditDialogOptions ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.DialogOptions) = render ==> ("EditDialogOptions" => x)
    /// The data to display in the table. MudTable will render one row per item
    [<CustomOperation("Items")>] member inline _.Items ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.IEnumerable<'T>) = render ==> ("Items" => x)
    /// Show a loading animation, if true.
    [<CustomOperation("Loading")>] member inline _.Loading ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("Loading" => x)
    /// Define if Cancel button is present or not for inline editing.
    [<CustomOperation("CanCancelEdit")>] member inline _.CanCancelEdit ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("CanCancelEdit" => x)
    /// The color of the loading progress if used. It supports the theme colors.
    [<CustomOperation("LoadingProgressColor")>] member inline _.LoadingProgressColor ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("LoadingProgressColor" => x)
    /// Optional. Add any kind of toolbar to this render fragment.
    [<CustomOperation("ToolBarContent")>] member inline _.ToolBarContent ([<InlineIfLambda>] render: AttrRenderFragment, fragment) = render ==> html.renderFragment("ToolBarContent", fragment)
    /// Optional. Add any kind of toolbar to this render fragment.
    [<CustomOperation("ToolBarContent")>] member inline _.ToolBarContent ([<InlineIfLambda>] render: AttrRenderFragment, fragments) = render ==> html.renderFragment("ToolBarContent", fragment { yield! fragments })
    /// Optional. Add any kind of toolbar to this render fragment.
    [<CustomOperation("ToolBarContent")>] member inline _.ToolBarContent ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("ToolBarContent", html.text x)
    /// Optional. Add any kind of toolbar to this render fragment.
    [<CustomOperation("ToolBarContent")>] member inline _.ToolBarContent ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("ToolBarContent", html.text x)
    /// Optional. Add any kind of toolbar to this render fragment.
    [<CustomOperation("ToolBarContent")>] member inline _.ToolBarContent ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("ToolBarContent", html.text x)
    /// Defines if the table has a horizontal scrollbar.
    [<CustomOperation("HorizontalScrollbar")>] member inline _.HorizontalScrollbar ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("HorizontalScrollbar" => x)
    /// Defines if columns of the grid can be resized.
    [<CustomOperation("ColumnResizeMode")>] member inline _.ColumnResizeMode ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.ResizeMode) = render ==> ("ColumnResizeMode" => x)
    /// Add a class to the thead tag
    [<CustomOperation("HeaderClass")>] member inline _.HeaderClass ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("HeaderClass" => x)
    /// Setting a height will allow to scroll the table. If not set, it will try to grow in height. You can set this to any CSS value that the
    /// attribute 'height' accepts, i.e. 500px.
    [<CustomOperation("Height")>] member inline _.Height ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Height" => x)
    /// Add a class to the tfoot tag
    [<CustomOperation("FooterClass")>] member inline _.FooterClass ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("FooterClass" => x)
    /// A function that returns whether or not an item should be displayed in the table. You can use this to implement your own search function.
    [<CustomOperation("QuickFilter")>] member inline _.QuickFilter ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("QuickFilter" => (System.Func<'T, System.Boolean>fn))
    /// Allows adding a custom header beyond that specified in the Column component. Add HeaderCell
    /// components to add a custom header.
    [<CustomOperation("Header")>] member inline _.Header ([<InlineIfLambda>] render: AttrRenderFragment, fragment) = render ==> html.renderFragment("Header", fragment)
    /// Allows adding a custom header beyond that specified in the Column component. Add HeaderCell
    /// components to add a custom header.
    [<CustomOperation("Header")>] member inline _.Header ([<InlineIfLambda>] render: AttrRenderFragment, fragments) = render ==> html.renderFragment("Header", fragment { yield! fragments })
    /// Allows adding a custom header beyond that specified in the Column component. Add HeaderCell
    /// components to add a custom header.
    [<CustomOperation("Header")>] member inline _.Header ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("Header", html.text x)
    /// Allows adding a custom header beyond that specified in the Column component. Add HeaderCell
    /// components to add a custom header.
    [<CustomOperation("Header")>] member inline _.Header ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("Header", html.text x)
    /// Allows adding a custom header beyond that specified in the Column component. Add HeaderCell
    /// components to add a custom header.
    [<CustomOperation("Header")>] member inline _.Header ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("Header", html.text x)
    /// The Columns that make up the data grid. Add Column components to this RenderFragment.
    [<CustomOperation("Columns")>] member inline _.Columns ([<InlineIfLambda>] render: AttrRenderFragment, fragment) = render ==> html.renderFragment("Columns", fragment)
    /// The Columns that make up the data grid. Add Column components to this RenderFragment.
    [<CustomOperation("Columns")>] member inline _.Columns ([<InlineIfLambda>] render: AttrRenderFragment, fragments) = render ==> html.renderFragment("Columns", fragment { yield! fragments })
    /// The Columns that make up the data grid. Add Column components to this RenderFragment.
    [<CustomOperation("Columns")>] member inline _.Columns ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("Columns", html.text x)
    /// The Columns that make up the data grid. Add Column components to this RenderFragment.
    [<CustomOperation("Columns")>] member inline _.Columns ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("Columns", html.text x)
    /// The Columns that make up the data grid. Add Column components to this RenderFragment.
    [<CustomOperation("Columns")>] member inline _.Columns ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("Columns", html.text x)
    /// The culture used to represent numeric columns and his filtering input fields.
    /// Each column can override this DataGrid Culture.
    [<CustomOperation("Culture")>] member inline _.Culture ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Globalization.CultureInfo) = render ==> ("Culture" => x)
    /// Row Child content of the component.
    [<CustomOperation("ChildRowContent")>] member inline _.ChildRowContent ([<InlineIfLambda>] render: AttrRenderFragment, fn: MudBlazor.CellContext<'T> -> NodeRenderFragment) = render ==> html.renderFragment("ChildRowContent", fn)
    /// Defines the table body content when there are no matching records found
    [<CustomOperation("NoRecordsContent")>] member inline _.NoRecordsContent ([<InlineIfLambda>] render: AttrRenderFragment, fragment) = render ==> html.renderFragment("NoRecordsContent", fragment)
    /// Defines the table body content when there are no matching records found
    [<CustomOperation("NoRecordsContent")>] member inline _.NoRecordsContent ([<InlineIfLambda>] render: AttrRenderFragment, fragments) = render ==> html.renderFragment("NoRecordsContent", fragment { yield! fragments })
    /// Defines the table body content when there are no matching records found
    [<CustomOperation("NoRecordsContent")>] member inline _.NoRecordsContent ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("NoRecordsContent", html.text x)
    /// Defines the table body content when there are no matching records found
    [<CustomOperation("NoRecordsContent")>] member inline _.NoRecordsContent ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("NoRecordsContent", html.text x)
    /// Defines the table body content when there are no matching records found
    [<CustomOperation("NoRecordsContent")>] member inline _.NoRecordsContent ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("NoRecordsContent", html.text x)
    /// Defines the table body content  the table has no rows and is loading
    [<CustomOperation("LoadingContent")>] member inline _.LoadingContent ([<InlineIfLambda>] render: AttrRenderFragment, fragment) = render ==> html.renderFragment("LoadingContent", fragment)
    /// Defines the table body content  the table has no rows and is loading
    [<CustomOperation("LoadingContent")>] member inline _.LoadingContent ([<InlineIfLambda>] render: AttrRenderFragment, fragments) = render ==> html.renderFragment("LoadingContent", fragment { yield! fragments })
    /// Defines the table body content  the table has no rows and is loading
    [<CustomOperation("LoadingContent")>] member inline _.LoadingContent ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("LoadingContent", html.text x)
    /// Defines the table body content  the table has no rows and is loading
    [<CustomOperation("LoadingContent")>] member inline _.LoadingContent ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("LoadingContent", html.text x)
    /// Defines the table body content  the table has no rows and is loading
    [<CustomOperation("LoadingContent")>] member inline _.LoadingContent ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("LoadingContent", html.text x)
    /// Add MudTablePager here to enable breaking the rows in to multiple pages.
    [<CustomOperation("PagerContent")>] member inline _.PagerContent ([<InlineIfLambda>] render: AttrRenderFragment, fragment) = render ==> html.renderFragment("PagerContent", fragment)
    /// Add MudTablePager here to enable breaking the rows in to multiple pages.
    [<CustomOperation("PagerContent")>] member inline _.PagerContent ([<InlineIfLambda>] render: AttrRenderFragment, fragments) = render ==> html.renderFragment("PagerContent", fragment { yield! fragments })
    /// Add MudTablePager here to enable breaking the rows in to multiple pages.
    [<CustomOperation("PagerContent")>] member inline _.PagerContent ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("PagerContent", html.text x)
    /// Add MudTablePager here to enable breaking the rows in to multiple pages.
    [<CustomOperation("PagerContent")>] member inline _.PagerContent ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("PagerContent", html.text x)
    /// Add MudTablePager here to enable breaking the rows in to multiple pages.
    [<CustomOperation("PagerContent")>] member inline _.PagerContent ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("PagerContent", html.text x)
    /// Supply an async function which (re)loads filtered, paginated and sorted data from server.
    /// Table will await this func and update based on the returned TableData.
    /// Used only with ServerData
    [<CustomOperation("ServerData")>] member inline _.ServerData ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("ServerData" => (System.Func<MudBlazor.GridState<'T>, System.Threading.Tasks.Task<MudBlazor.GridData<'T>>>fn))
    /// If the table has more items than this number, it will break the rows into pages of said size.
    /// Note: requires a MudTablePager in PagerContent.
    [<CustomOperation("RowsPerPage")>] member inline _.RowsPerPage ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("RowsPerPage" => x)
    /// The page index of the currently displayed page (Zero based). Usually called by MudTablePager.
    /// Note: requires a MudTablePager in PagerContent.
    [<CustomOperation("CurrentPage")>] member inline _.CurrentPage ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("CurrentPage" => x)
    /// Locks Inline Edit mode, if true.
    [<CustomOperation("ReadOnly")>] member inline _.ReadOnly ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("ReadOnly" => x)
    /// If MultiSelection is true, this returns the currently selected items. You can bind this property and the initial content of the HashSet you bind it to will cause these rows to be selected initially.
    [<CustomOperation("SelectedItems")>] member inline _.SelectedItems ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.HashSet<'T>) = render ==> ("SelectedItems" => x)
    /// If MultiSelection is true, this returns the currently selected items. You can bind this property and the initial content of the HashSet you bind it to will cause these rows to be selected initially.
    [<CustomOperation("SelectedItems'")>] member inline _.SelectedItems' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.Collections.Generic.HashSet<'T> * (System.Collections.Generic.HashSet<'T> -> unit)) = render ==> html.bind("SelectedItems", valueFn)
    /// Returns the item which was last clicked on in single selection mode (that is, if MultiSelection is false)
    [<CustomOperation("SelectedItem")>] member inline _.SelectedItem ([<InlineIfLambda>] render: AttrRenderFragment, x: 'T) = render ==> ("SelectedItem" => x)
    /// Returns the item which was last clicked on in single selection mode (that is, if MultiSelection is false)
    [<CustomOperation("SelectedItem'")>] member inline _.SelectedItem' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: 'T * ('T -> unit)) = render ==> html.bind("SelectedItem", valueFn)
    /// Determines whether grouping of columns is allowed in the data grid.
    [<CustomOperation("Groupable")>] member inline _.Groupable ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("Groupable" => x)
    /// If set, a grouped column will be expanded by default.
    [<CustomOperation("GroupExpanded")>] member inline _.GroupExpanded ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("GroupExpanded" => x)
    /// CSS class for the groups.
    [<CustomOperation("GroupClass")>] member inline _.GroupClass ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("GroupClass" => x)
    /// CSS styles for the groups.
    [<CustomOperation("GroupStyle")>] member inline _.GroupStyle ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("GroupStyle" => x)
    /// Returns the class that will get joined with GroupClass.
    [<CustomOperation("GroupClassFunc")>] member inline _.GroupClassFunc ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("GroupClassFunc" => (System.Func<MudBlazor.GroupDefinition<'T>, System.String>fn))
    /// Returns the class that will get joined with GroupStyle.
    [<CustomOperation("GroupStyleFunc")>] member inline _.GroupStyleFunc ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("GroupStyleFunc" => (System.Func<MudBlazor.GroupDefinition<'T>, System.String>fn))
    /// When true, displays the built-in menu icon in the header of the data grid.
    [<CustomOperation("ShowMenuIcon")>] member inline _.ShowMenuIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("ShowMenuIcon" => x)

type MudDataGridPagerBuilder<'FunBlazorGeneric, 'T when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    /// Set true to hide the part of the pager which allows to change the page size.
    [<CustomOperation("DisableRowsPerPage")>] member inline _.DisableRowsPerPage ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("DisableRowsPerPage" => x)
    /// Set true to disable user interaction with the backward/forward buttons
    /// and the part of the pager which allows to change the page size.
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("Disabled" => x)
    /// Define a list of available page size options for the user to choose from
    [<CustomOperation("PageSizeOptions")>] member inline _.PageSizeOptions ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32[]) = render ==> ("PageSizeOptions" => x)
    /// Format string for the display of the current page, which you can localize to your language. Available variables are:
    /// {first_item}, {last_item} and {all_items} which will replaced with the indices of the page's first and last item, as well as the total number of items.
    /// Default: "{first_item}-{last_item} of {all_items}" which is transformed into "0-25 of 77". 
    [<CustomOperation("InfoFormat")>] member inline _.InfoFormat ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("InfoFormat" => x)
    /// The localizable "Rows per page:" text.
    [<CustomOperation("RowsPerPageString")>] member inline _.RowsPerPageString ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("RowsPerPageString" => x)

type RowBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()


type MudDialogBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    /// Define the dialog title as a renderfragment (overrides Title)
    [<CustomOperation("TitleContent")>] member inline _.TitleContent ([<InlineIfLambda>] render: AttrRenderFragment, fragment) = render ==> html.renderFragment("TitleContent", fragment)
    /// Define the dialog title as a renderfragment (overrides Title)
    [<CustomOperation("TitleContent")>] member inline _.TitleContent ([<InlineIfLambda>] render: AttrRenderFragment, fragments) = render ==> html.renderFragment("TitleContent", fragment { yield! fragments })
    /// Define the dialog title as a renderfragment (overrides Title)
    [<CustomOperation("TitleContent")>] member inline _.TitleContent ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("TitleContent", html.text x)
    /// Define the dialog title as a renderfragment (overrides Title)
    [<CustomOperation("TitleContent")>] member inline _.TitleContent ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("TitleContent", html.text x)
    /// Define the dialog title as a renderfragment (overrides Title)
    [<CustomOperation("TitleContent")>] member inline _.TitleContent ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("TitleContent", html.text x)
    /// Define the dialog body here
    [<CustomOperation("DialogContent")>] member inline _.DialogContent ([<InlineIfLambda>] render: AttrRenderFragment, fragment) = render ==> html.renderFragment("DialogContent", fragment)
    /// Define the dialog body here
    [<CustomOperation("DialogContent")>] member inline _.DialogContent ([<InlineIfLambda>] render: AttrRenderFragment, fragments) = render ==> html.renderFragment("DialogContent", fragment { yield! fragments })
    /// Define the dialog body here
    [<CustomOperation("DialogContent")>] member inline _.DialogContent ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("DialogContent", html.text x)
    /// Define the dialog body here
    [<CustomOperation("DialogContent")>] member inline _.DialogContent ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("DialogContent", html.text x)
    /// Define the dialog body here
    [<CustomOperation("DialogContent")>] member inline _.DialogContent ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("DialogContent", html.text x)
    /// Define the action buttons here
    [<CustomOperation("DialogActions")>] member inline _.DialogActions ([<InlineIfLambda>] render: AttrRenderFragment, fragment) = render ==> html.renderFragment("DialogActions", fragment)
    /// Define the action buttons here
    [<CustomOperation("DialogActions")>] member inline _.DialogActions ([<InlineIfLambda>] render: AttrRenderFragment, fragments) = render ==> html.renderFragment("DialogActions", fragment { yield! fragments })
    /// Define the action buttons here
    [<CustomOperation("DialogActions")>] member inline _.DialogActions ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("DialogActions", html.text x)
    /// Define the action buttons here
    [<CustomOperation("DialogActions")>] member inline _.DialogActions ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("DialogActions", html.text x)
    /// Define the action buttons here
    [<CustomOperation("DialogActions")>] member inline _.DialogActions ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("DialogActions", html.text x)
    /// Default options to pass to Show(), if none are explicitly provided.
    /// Typically useful on inline dialogs.
    [<CustomOperation("Options")>] member inline _.Options ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.DialogOptions) = render ==> ("Options" => x)
    [<CustomOperation("OnBackdropClick")>] member inline _.OnBackdropClick ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Action) = render ==> ("OnBackdropClick" => x)
    /// No padding at the sides
    [<CustomOperation("DisableSidePadding")>] member inline _.DisableSidePadding ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("DisableSidePadding" => x)
    /// CSS class that will be applied to the dialog content
    [<CustomOperation("ClassContent")>] member inline _.ClassContent ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("ClassContent" => x)
    /// CSS class that will be applied to the action buttons container
    [<CustomOperation("ClassActions")>] member inline _.ClassActions ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("ClassActions" => x)
    /// CSS styles to be applied to the dialog content
    [<CustomOperation("ContentStyle")>] member inline _.ContentStyle ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("ContentStyle" => x)
    /// Bind this two-way to show and close an inlined dialog. Has no effect on opened dialogs
    [<CustomOperation("IsVisible")>] member inline _.IsVisible ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("IsVisible" => x)
    /// Bind this two-way to show and close an inlined dialog. Has no effect on opened dialogs
    [<CustomOperation("IsVisible'")>] member inline _.IsVisible' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.Boolean * (System.Boolean -> unit)) = render ==> html.bind("IsVisible", valueFn)
    /// Raised when the inline dialog's display status changes.
    [<CustomOperation("IsVisibleChanged")>] member inline _.IsVisibleChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callback<System.Boolean>("IsVisibleChanged", fn)
    /// Raised when the inline dialog's display status changes.
    [<CustomOperation("IsVisibleChanged")>] member inline _.IsVisibleChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callbackTask<System.Boolean>("IsVisibleChanged", fn)
    /// Define the dialog title as a renderfragment (overrides Title)
    [<CustomOperation("DefaultFocus")>] member inline _.DefaultFocus ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.DefaultFocus) = render ==> ("DefaultFocus" => x)

type MudDialogInstanceBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Options")>] member inline _.Options ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.DialogOptions) = render ==> ("Options" => x)
    [<CustomOperation("Title")>] member inline _.Title ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Title" => x)
    [<CustomOperation("TitleContent")>] member inline _.TitleContent ([<InlineIfLambda>] render: AttrRenderFragment, fragment) = render ==> html.renderFragment("TitleContent", fragment)
    [<CustomOperation("TitleContent")>] member inline _.TitleContent ([<InlineIfLambda>] render: AttrRenderFragment, fragments) = render ==> html.renderFragment("TitleContent", fragment { yield! fragments })
    [<CustomOperation("TitleContent")>] member inline _.TitleContent ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("TitleContent", html.text x)
    [<CustomOperation("TitleContent")>] member inline _.TitleContent ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("TitleContent", html.text x)
    [<CustomOperation("TitleContent")>] member inline _.TitleContent ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("TitleContent", html.text x)
    [<CustomOperation("Content")>] member inline _.Content ([<InlineIfLambda>] render: AttrRenderFragment, fragment) = render ==> html.renderFragment("Content", fragment)
    [<CustomOperation("Content")>] member inline _.Content ([<InlineIfLambda>] render: AttrRenderFragment, fragments) = render ==> html.renderFragment("Content", fragment { yield! fragments })
    [<CustomOperation("Content")>] member inline _.Content ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("Content", html.text x)
    [<CustomOperation("Content")>] member inline _.Content ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("Content", html.text x)
    [<CustomOperation("Content")>] member inline _.Content ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("Content", html.text x)
    [<CustomOperation("Id")>] member inline _.Id ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Guid) = render ==> ("Id" => x)
    /// Custom close icon.
    [<CustomOperation("CloseIcon")>] member inline _.CloseIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("CloseIcon" => x)

type MudDrawerBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    /// If true, drawer position will be fixed. (CSS position: fixed;)
    [<CustomOperation("Fixed")>] member inline _.Fixed ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("Fixed" => x)
    /// The higher the number, the heavier the drop-shadow. 0 for no shadow.
    [<CustomOperation("Elevation")>] member inline _.Elevation ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("Elevation" => x)
    /// Side from which the drawer will appear.
    [<CustomOperation("Anchor")>] member inline _.Anchor ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Anchor) = render ==> ("Anchor" => x)
    /// The color of the component. It supports the theme colors.
    [<CustomOperation("Color")>] member inline _.Color ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("Color" => x)
    /// Variant of the drawer. It specifies how the drawer will be displayed.
    [<CustomOperation("Variant")>] member inline _.Variant ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.DrawerVariant) = render ==> ("Variant" => x)
    /// Show overlay for responsive and temporary drawers.
    [<CustomOperation("DisableOverlay")>] member inline _.DisableOverlay ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("DisableOverlay" => x)
    /// Preserve open state for responsive drawer when window resized above Breakpoint.
    [<CustomOperation("PreserveOpenState")>] member inline _.PreserveOpenState ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("PreserveOpenState" => x)
    /// Open drawer automatically on mouse enter when Variant parameter is set to Mini.
    [<CustomOperation("OpenMiniOnHover")>] member inline _.OpenMiniOnHover ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("OpenMiniOnHover" => x)
    /// Switching point for responsive drawers
    [<CustomOperation("Breakpoint")>] member inline _.Breakpoint ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Breakpoint) = render ==> ("Breakpoint" => x)
    /// Sets the opened state on the drawer. Can be used with two-way binding to close itself on navigation.
    [<CustomOperation("Open")>] member inline _.Open ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("Open" => x)
    /// Sets the opened state on the drawer. Can be used with two-way binding to close itself on navigation.
    [<CustomOperation("Open'")>] member inline _.Open' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.Boolean * (System.Boolean -> unit)) = render ==> html.bind("Open", valueFn)
    [<CustomOperation("OpenChanged")>] member inline _.OpenChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callback<System.Boolean>("OpenChanged", fn)
    [<CustomOperation("OpenChanged")>] member inline _.OpenChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callbackTask<System.Boolean>("OpenChanged", fn)
    /// Width of left/right drawer. Only for non-fixed drawers.
    [<CustomOperation("Width")>] member inline _.Width ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Width" => x)
    /// Width of left/right drawer. Only for non-fixed drawers.
    [<CustomOperation("MiniWidth")>] member inline _.MiniWidth ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("MiniWidth" => x)
    /// Height of top/bottom temporary drawer
    [<CustomOperation("Height")>] member inline _.Height ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Height" => x)
    /// Specify how the drawer should behave inside a MudLayout. It affects the position relative to MudAppbar
    [<CustomOperation("ClipMode")>] member inline _.ClipMode ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.DrawerClipMode) = render ==> ("ClipMode" => x)

/// The container of a drag and drop zones
type MudDropContainerBuilder<'FunBlazorGeneric, 'T when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    /// The items that can be drag and dropped within the container
    [<CustomOperation("Items")>] member inline _.Items ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.IEnumerable<'T>) = render ==> ("Items" => x)
    /// The render fragment (template) that should be used to render the items within a drop zone
    [<CustomOperation("ItemRenderer")>] member inline _.ItemRenderer ([<InlineIfLambda>] render: AttrRenderFragment, fn: 'T -> NodeRenderFragment) = render ==> html.renderFragment("ItemRenderer", fn)
    /// The method is used to determinate if an item can be dropped within a drop zone
    [<CustomOperation("ItemsSelector")>] member inline _.ItemsSelector ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("ItemsSelector" => (System.Func<'T, System.String, System.Boolean>fn))
    /// Callback that indicates that an item has been dropped on a drop zone. Should be used to update the "status" of the data item
    [<CustomOperation("ItemDropped")>] member inline _.ItemDropped ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callback<MudBlazor.MudItemDropInfo<'T>>("ItemDropped", fn)
    /// Callback that indicates that an item has been dropped on a drop zone. Should be used to update the "status" of the data item
    [<CustomOperation("ItemDropped")>] member inline _.ItemDropped ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callbackTask<MudBlazor.MudItemDropInfo<'T>>("ItemDropped", fn)
    /// The method is used to determinate if an item can be dropped within a drop zone
    [<CustomOperation("CanDrop")>] member inline _.CanDrop ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("CanDrop" => (System.Func<'T, System.String, System.Boolean>fn))
    /// The CSS class(es), that is applied to drop zones that are a valid target for drag and drop transaction
    [<CustomOperation("CanDropClass")>] member inline _.CanDropClass ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("CanDropClass" => x)
    /// The CSS class(es), that is applied to drop zones that are NOT valid target for drag and drop transaction
    [<CustomOperation("NoDropClass")>] member inline _.NoDropClass ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("NoDropClass" => x)
    /// If true, drop classes CanDropClass CanDropClass  or NoDropClass NoDropClass or applied as soon, as a transaction has started
    [<CustomOperation("ApplyDropClassesOnDragStarted")>] member inline _.ApplyDropClassesOnDragStarted ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("ApplyDropClassesOnDragStarted" => x)
    /// The method is used to determinate if an item should be disabled for dragging. Defaults to allow all items
    [<CustomOperation("ItemIsDisabled")>] member inline _.ItemIsDisabled ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("ItemIsDisabled" => (System.Func<'T, System.Boolean>fn))
    /// If a drop item is disabled (determinate by ItemIsDisabled). This class is applied to the element
    [<CustomOperation("DisabledClass")>] member inline _.DisabledClass ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("DisabledClass" => x)
    /// An additional class that is applied to the drop zone where a drag operation started
    [<CustomOperation("DraggingClass")>] member inline _.DraggingClass ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("DraggingClass" => x)
    /// An additional class that is applied to an drop item, when it is dragged
    [<CustomOperation("ItemDraggingClass")>] member inline _.ItemDraggingClass ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("ItemDraggingClass" => x)

type MudDropZoneBuilder<'FunBlazorGeneric, 'T when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    /// The unique identifier of this drop zone. It is used within transaction to 
    [<CustomOperation("Identifier")>] member inline _.Identifier ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Identifier" => x)
    /// The render fragment (template) that should be used to render the items within a drop zone. Overrides value provided by drop container
    [<CustomOperation("ItemRenderer")>] member inline _.ItemRenderer ([<InlineIfLambda>] render: AttrRenderFragment, fn: 'T -> NodeRenderFragment) = render ==> html.renderFragment("ItemRenderer", fn)
    /// The method is used to determinate if an item can be dropped within a drop zone. Overrides value provided by drop container
    [<CustomOperation("ItemsSelector")>] member inline _.ItemsSelector ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("ItemsSelector" => (System.Func<'T, System.Boolean>fn))
    /// The method is used to determinate if an item can be dropped within a drop zone. Overrides value provided by drop container
    [<CustomOperation("CanDrop")>] member inline _.CanDrop ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("CanDrop" => (System.Func<'T, System.Boolean>fn))
    /// The CSS class(es), that is applied to drop zones that are a valid target for drag and drop transaction. Overrides value provided by drop container
    [<CustomOperation("CanDropClass")>] member inline _.CanDropClass ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("CanDropClass" => x)
    /// The CSS class(es), that is applied to drop zones that are NOT valid target for drag and drop transaction. Overrides value provided by drop container
    [<CustomOperation("NoDropClass")>] member inline _.NoDropClass ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("NoDropClass" => x)
    /// If true, drop classes CanDropClass CanDropClass  or NoDropClass NoDropClass or applied as soon, as a transaction has started. Overrides value provided by drop container
    [<CustomOperation("ApplyDropClassesOnDragStarted")>] member inline _.ApplyDropClassesOnDragStarted ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Boolean>) = render ==> ("ApplyDropClassesOnDragStarted" => x)
    /// The method is used to determinate if an item should be disabled for dragging. Defaults to allow all items. Overrides value provided by drop container
    [<CustomOperation("ItemIsDisabled")>] member inline _.ItemIsDisabled ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("ItemIsDisabled" => (System.Func<'T, System.Boolean>fn))
    /// If a drop item is disabled (determinate by ItemIsDisabled). This class is applied to the element. Overrides value provided by drop container
    [<CustomOperation("DisabledClass")>] member inline _.DisabledClass ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("DisabledClass" => x)
    /// An additional class that is applied to the drop zone where a drag operation started
    [<CustomOperation("DraggingClass")>] member inline _.DraggingClass ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("DraggingClass" => x)
    /// An additional class that is applied to an drop item, when it is dragged
    [<CustomOperation("ItemDraggingClass")>] member inline _.ItemDraggingClass ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("ItemDraggingClass" => x)
    [<CustomOperation("AllowReorder")>] member inline _.AllowReorder ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("AllowReorder" => x)
    /// If true, will only act as a dropable zone and not render any items.
    [<CustomOperation("OnlyZone")>] member inline _.OnlyZone ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("OnlyZone" => x)

type MudDynamicDropItemBuilder<'FunBlazorGeneric, 'T when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    /// The zone identifier of the corresponding drop zone
    [<CustomOperation("ZoneIdentifier")>] member inline _.ZoneIdentifier ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("ZoneIdentifier" => x)
    /// the data item that is represneted by this item
    [<CustomOperation("Item")>] member inline _.Item ([<InlineIfLambda>] render: AttrRenderFragment, x: 'T) = render ==> ("Item" => x)
    /// An additional class that is applied to this element when a drag operation is in progress
    [<CustomOperation("DraggingClass")>] member inline _.DraggingClass ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("DraggingClass" => x)
    /// An event callback set fires, when a drag operation has been started
    [<CustomOperation("OnDragStarted")>] member inline _.OnDragStarted ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callback<'T>("OnDragStarted", fn)
    /// An event callback set fires, when a drag operation has been started
    [<CustomOperation("OnDragStarted")>] member inline _.OnDragStarted ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callbackTask<'T>("OnDragStarted", fn)
    /// An event callback set fires, when a drag operation has been eneded. This included also a canceled transaction
    [<CustomOperation("OnDragEnded")>] member inline _.OnDragEnded ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callback<'T>("OnDragEnded", fn)
    /// An event callback set fires, when a drag operation has been eneded. This included also a canceled transaction
    [<CustomOperation("OnDragEnded")>] member inline _.OnDragEnded ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callbackTask<'T>("OnDragEnded", fn)
    /// When true, the item can't be dragged. defaults to false
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("Disabled" => x)
    /// The class that is applied when disabled Disabled is set to true
    [<CustomOperation("DisabledClass")>] member inline _.DisabledClass ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("DisabledClass" => x)
    [<CustomOperation("Index")>] member inline _.Index ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("Index" => x)
    [<CustomOperation("HideContent")>] member inline _.HideContent ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("HideContent" => x)

/// Primitive component which allows rendering any HTML element we want
/// through the HtmlTag property
type MudElementBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    /// The HTML element that will be rendered in the root by the component
    [<CustomOperation("HtmlTag")>] member inline _.HtmlTag ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("HtmlTag" => x)
    /// The ElementReference to bind to.
    /// Use like @bind-Ref="myRef"
    [<CustomOperation("Ref")>] member inline _.Ref ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<Microsoft.AspNetCore.Components.ElementReference>) = render ==> ("Ref" => x)
    /// The ElementReference to bind to.
    /// Use like @bind-Ref="myRef"
    [<CustomOperation("Ref'")>] member inline _.Ref' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.Nullable<Microsoft.AspNetCore.Components.ElementReference> * (System.Nullable<Microsoft.AspNetCore.Components.ElementReference> -> unit)) = render ==> html.bind("Ref", valueFn)
    [<CustomOperation("RefChanged")>] member inline _.RefChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callback<Microsoft.AspNetCore.Components.ElementReference>("RefChanged", fn)
    [<CustomOperation("RefChanged")>] member inline _.RefChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callbackTask<Microsoft.AspNetCore.Components.ElementReference>("RefChanged", fn)

type MudExpansionPanelBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    /// Explicitly sets the height for the Collapse element to override the css default.
    [<CustomOperation("MaxHeight")>] member inline _.MaxHeight ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Int32>) = render ==> ("MaxHeight" => x)
    /// RenderFragment to be displayed in the expansion panel which will override header text if defined.
    [<CustomOperation("TitleContent")>] member inline _.TitleContent ([<InlineIfLambda>] render: AttrRenderFragment, fragment) = render ==> html.renderFragment("TitleContent", fragment)
    /// RenderFragment to be displayed in the expansion panel which will override header text if defined.
    [<CustomOperation("TitleContent")>] member inline _.TitleContent ([<InlineIfLambda>] render: AttrRenderFragment, fragments) = render ==> html.renderFragment("TitleContent", fragment { yield! fragments })
    /// RenderFragment to be displayed in the expansion panel which will override header text if defined.
    [<CustomOperation("TitleContent")>] member inline _.TitleContent ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("TitleContent", html.text x)
    /// RenderFragment to be displayed in the expansion panel which will override header text if defined.
    [<CustomOperation("TitleContent")>] member inline _.TitleContent ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("TitleContent", html.text x)
    /// RenderFragment to be displayed in the expansion panel which will override header text if defined.
    [<CustomOperation("TitleContent")>] member inline _.TitleContent ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("TitleContent", html.text x)
    /// The text to be displayed in the expansion panel.
    [<CustomOperation("Text")>] member inline _.Text ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Text" => x)
    /// If true, expand icon will not show
    [<CustomOperation("HideIcon")>] member inline _.HideIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("HideIcon" => x)
    /// Custom hide icon.
    [<CustomOperation("Icon")>] member inline _.Icon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Icon" => x)
    /// If true, removes vertical padding from childcontent.
    [<CustomOperation("Dense")>] member inline _.Dense ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("Dense" => x)
    /// If true, the left and right padding is removed from childcontent.
    [<CustomOperation("DisableGutters")>] member inline _.DisableGutters ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("DisableGutters" => x)
    /// Raised when IsExpanded changes.
    [<CustomOperation("IsExpandedChanged")>] member inline _.IsExpandedChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callback<System.Boolean>("IsExpandedChanged", fn)
    /// Raised when IsExpanded changes.
    [<CustomOperation("IsExpandedChanged")>] member inline _.IsExpandedChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callbackTask<System.Boolean>("IsExpandedChanged", fn)
    /// Expansion state of the panel (two-way bindable)
    [<CustomOperation("IsExpanded")>] member inline _.IsExpanded ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("IsExpanded" => x)
    /// Expansion state of the panel (two-way bindable)
    [<CustomOperation("IsExpanded'")>] member inline _.IsExpanded' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.Boolean * (System.Boolean -> unit)) = render ==> html.bind("IsExpanded", valueFn)
    /// Sets the initial expansion state. Do not use in combination with IsExpanded.
    /// Combine with MultiExpansion to have more than one panel start open.
    [<CustomOperation("IsInitiallyExpanded")>] member inline _.IsInitiallyExpanded ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("IsInitiallyExpanded" => x)
    /// If true, the component will be disabled.
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("Disabled" => x)

type MudExpansionPanelsBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    /// If true, border-radius is set to 0.
    [<CustomOperation("Square")>] member inline _.Square ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("Square" => x)
    /// If true, multiple panels can be expanded at the same time.
    [<CustomOperation("MultiExpansion")>] member inline _.MultiExpansion ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("MultiExpansion" => x)
    /// The higher the number, the heavier the drop-shadow. 0 for no shadow.
    [<CustomOperation("Elevation")>] member inline _.Elevation ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("Elevation" => x)
    /// If true, removes vertical padding from all panels' childcontent.
    [<CustomOperation("Dense")>] member inline _.Dense ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("Dense" => x)
    /// If true, the left and right padding is removed from all panels' childcontent.
    [<CustomOperation("DisableGutters")>] member inline _.DisableGutters ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("DisableGutters" => x)
    /// If true, the borders around each panel will be removed.
    [<CustomOperation("DisableBorders")>] member inline _.DisableBorders ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("DisableBorders" => x)

type MudFieldBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    /// Will adjust vertical spacing. 
    ///             
    [<CustomOperation("Margin")>] member inline _.Margin ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Margin) = render ==> ("Margin" => x)
    /// If true, the label will be displayed in an error state.
    [<CustomOperation("Error")>] member inline _.Error ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("Error" => x)
    /// The ErrorText that will be displayed if Error true
    [<CustomOperation("ErrorText")>] member inline _.ErrorText ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("ErrorText" => x)
    /// The HelperText will be displayed below the text field.
    [<CustomOperation("HelperText")>] member inline _.HelperText ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("HelperText" => x)
    /// If true, the field will take up the full width of its container.
    [<CustomOperation("FullWidth")>] member inline _.FullWidth ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("FullWidth" => x)
    /// If string has value the label text will be displayed in the input, and scaled down at the top if the field has value.
    [<CustomOperation("Label")>] member inline _.Label ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Label" => x)
    /// Variant can be Text, Filled or Outlined.
    [<CustomOperation("Variant")>] member inline _.Variant ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Variant) = render ==> ("Variant" => x)
    /// If true, the input element will be disabled.
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("Disabled" => x)
    /// Icon that will be used if Adornment is set to Start or End.
    [<CustomOperation("AdornmentIcon")>] member inline _.AdornmentIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("AdornmentIcon" => x)
    /// Text that will be used if Adornment is set to Start or End, the Text overrides Icon.
    [<CustomOperation("AdornmentText")>] member inline _.AdornmentText ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("AdornmentText" => x)
    /// The Adornment if used. By default, it is set to None.
    [<CustomOperation("Adornment")>] member inline _.Adornment ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Adornment) = render ==> ("Adornment" => x)
    /// The color of the adornment if used. It supports the theme colors.
    [<CustomOperation("AdornmentColor")>] member inline _.AdornmentColor ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("AdornmentColor" => x)
    /// Sets the Icon Size.
    [<CustomOperation("IconSize")>] member inline _.IconSize ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Size) = render ==> ("IconSize" => x)
    /// Button click event if set and Adornment used.
    [<CustomOperation("OnAdornmentClick")>] member inline _.OnAdornmentClick ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>("OnAdornmentClick", fn)
    /// Button click event if set and Adornment used.
    [<CustomOperation("OnAdornmentClick")>] member inline _.OnAdornmentClick ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callbackTask<Microsoft.AspNetCore.Components.Web.MouseEventArgs>("OnAdornmentClick", fn)
    /// If true, the inner contents padding is removed.
    [<CustomOperation("InnerPadding")>] member inline _.InnerPadding ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("InnerPadding" => x)
    /// If true, the field will not have an underline.
    [<CustomOperation("DisableUnderLine")>] member inline _.DisableUnderLine ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("DisableUnderLine" => x)

type MudFocusTrapBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    /// If true, the focus will no longer loop inside the component.
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("Disabled" => x)
    /// Defines on which element to set the focus when the component is created or enabled.
    /// When DefaultFocus.Element is used, the focus will be set to the FocusTrap itself, so the user will have to press TAB key once to focus the first tabbable element.
    [<CustomOperation("DefaultFocus")>] member inline _.DefaultFocus ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.DefaultFocus) = render ==> ("DefaultFocus" => x)

type MudFormBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    /// Validation status. True if the form is valid and without errors. This parameter is two-way bindable.
    [<CustomOperation("IsValid")>] member inline _.IsValid ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("IsValid" => x)
    /// Validation status. True if the form is valid and without errors. This parameter is two-way bindable.
    [<CustomOperation("IsValid'")>] member inline _.IsValid' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.Boolean * (System.Boolean -> unit)) = render ==> html.bind("IsValid", valueFn)
    /// True if any field of the field was touched. This parameter is readonly.
    [<CustomOperation("IsTouched")>] member inline _.IsTouched ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("IsTouched" => x)
    /// True if any field of the field was touched. This parameter is readonly.
    [<CustomOperation("IsTouched'")>] member inline _.IsTouched' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.Boolean * (System.Boolean -> unit)) = render ==> html.bind("IsTouched", valueFn)
    /// Validation debounce delay in milliseconds. This can help improve rendering performance of forms with real-time validation of inputs
    /// i.e. when textfields have Immediate="true".
    [<CustomOperation("ValidationDelay")>] member inline _.ValidationDelay ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("ValidationDelay" => x)
    /// When true, the form will not re-render its child contents on validation updates (i.e. when IsValid changes).
    /// This is an optimization which can be necessary especially for larger forms on older devices.
    [<CustomOperation("SuppressRenderingOnValidation")>] member inline _.SuppressRenderingOnValidation ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("SuppressRenderingOnValidation" => x)
    /// When true, will not cause a page refresh on Enter if any input has focus.
    [<CustomOperation("SuppressImplicitSubmission")>] member inline _.SuppressImplicitSubmission ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("SuppressImplicitSubmission" => x)
    /// Raised when IsValid changes.
    [<CustomOperation("IsValidChanged")>] member inline _.IsValidChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callback<System.Boolean>("IsValidChanged", fn)
    /// Raised when IsValid changes.
    [<CustomOperation("IsValidChanged")>] member inline _.IsValidChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callbackTask<System.Boolean>("IsValidChanged", fn)
    /// Raised when IsTouched changes.
    [<CustomOperation("IsTouchedChanged")>] member inline _.IsTouchedChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callback<System.Boolean>("IsTouchedChanged", fn)
    /// Raised when IsTouched changes.
    [<CustomOperation("IsTouchedChanged")>] member inline _.IsTouchedChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callbackTask<System.Boolean>("IsTouchedChanged", fn)
    /// Raised when a contained IFormComponent changes its value
    [<CustomOperation("FieldChanged")>] member inline _.FieldChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callback<MudBlazor.Utilities.FormFieldChangedEventArgs>("FieldChanged", fn)
    /// Raised when a contained IFormComponent changes its value
    [<CustomOperation("FieldChanged")>] member inline _.FieldChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callbackTask<MudBlazor.Utilities.FormFieldChangedEventArgs>("FieldChanged", fn)
    /// A default validation func or a validation attribute to use for form controls that don't have one.
    /// Supported types are:
    /// Func<T, bool> ... will output the standard error message "Invalid" if false
    /// Func<T, string> ... outputs the result as error message, no error if null 
    /// Func<T, IEnumerable< string >> ... outputs all the returned error messages, no error if empty
    /// Func<object, string, IEnumerable< string >> input Form.Model, Full Path of Member ... outputs all the returned error messages, no error if empty
    /// Func<T, Task< bool >> ... will output the standard error message "Invalid" if false
    /// Func<T, Task< string >> ... outputs the result as error message, no error if null
    /// Func<T, Task<IEnumerable< string >>> ... outputs all the returned error messages, no error if empty
    /// Func<object, string, Task<IEnumerable< string >>> input Form.Model, Full Path of Member ... outputs all the returned error messages, no error if empty
    /// System.ComponentModel.DataAnnotations.ValidationAttribute instances
    [<CustomOperation("Validation")>] member inline _.Validation ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Object) = render ==> ("Validation" => x)
    /// If a field already has a validation, override it with Validation.
    [<CustomOperation("OverrideFieldValidation")>] member inline _.OverrideFieldValidation ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Boolean>) = render ==> ("OverrideFieldValidation" => x)
    /// Validation error messages.
    [<CustomOperation("Errors")>] member inline _.Errors ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String[]) = render ==> ("Errors" => x)
    /// Validation error messages.
    [<CustomOperation("Errors'")>] member inline _.Errors' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.String[] * (System.String[] -> unit)) = render ==> html.bind("Errors", valueFn)
    [<CustomOperation("ErrorsChanged")>] member inline _.ErrorsChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callback<System.String[]>("ErrorsChanged", fn)
    [<CustomOperation("ErrorsChanged")>] member inline _.ErrorsChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callbackTask<System.String[]>("ErrorsChanged", fn)
    /// Specifies the top-level model object for the form. Used with Fluent Validation
    [<CustomOperation("Model")>] member inline _.Model ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Object) = render ==> ("Model" => x)

type MudHiddenBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    /// The screen size(s) depending on which the ChildContent should not be rendered (or should be, if Invert is true)
    [<CustomOperation("Breakpoint")>] member inline _.Breakpoint ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Breakpoint) = render ==> ("Breakpoint" => x)
    /// Inverts the Breakpoint, so that the ChildContent is only rendered when the breakpoint matches the screen size.
    [<CustomOperation("Invert")>] member inline _.Invert ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("Invert" => x)
    /// True if the component is not visible (two-way bindable)
    [<CustomOperation("IsHidden")>] member inline _.IsHidden ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("IsHidden" => x)
    /// True if the component is not visible (two-way bindable)
    [<CustomOperation("IsHidden'")>] member inline _.IsHidden' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.Boolean * (System.Boolean -> unit)) = render ==> html.bind("IsHidden", valueFn)
    /// Fires when the breakpoint changes visibility of the component
    [<CustomOperation("IsHiddenChanged")>] member inline _.IsHiddenChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callback<System.Boolean>("IsHiddenChanged", fn)
    /// Fires when the breakpoint changes visibility of the component
    [<CustomOperation("IsHiddenChanged")>] member inline _.IsHiddenChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callbackTask<System.Boolean>("IsHiddenChanged", fn)

type MudHighlighterBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    /// The whole text in which a fragment will be highlighted
    [<CustomOperation("Text")>] member inline _.Text ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Text" => x)
    /// The fragment of text to be highlighted
    [<CustomOperation("HighlightedText")>] member inline _.HighlightedText ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("HighlightedText" => x)
    /// The fragments of text to be highlighted
    [<CustomOperation("HighlightedTexts")>] member inline _.HighlightedTexts ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.IEnumerable<System.String>) = render ==> ("HighlightedTexts" => x)
    /// Whether or not the highlighted text is case sensitive
    [<CustomOperation("CaseSensitive")>] member inline _.CaseSensitive ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("CaseSensitive" => x)
    /// If true, highlights the text until the next regex boundary
    [<CustomOperation("UntilNextBoundary")>] member inline _.UntilNextBoundary ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("UntilNextBoundary" => x)

type MudIconBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    /// Icon to be used can either be svg paths for font icons.
    [<CustomOperation("Icon")>] member inline _.Icon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Icon" => x)
    /// Title of the icon used for accessibility.
    [<CustomOperation("Title")>] member inline _.Title ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Title" => x)
    /// The Size of the icon.
    [<CustomOperation("Size")>] member inline _.Size ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Size) = render ==> ("Size" => x)
    /// The color of the component. It supports the theme colors.
    [<CustomOperation("Color")>] member inline _.Color ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("Color" => x)
    /// The viewbox size of an svg element.
    [<CustomOperation("ViewBox")>] member inline _.ViewBox ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("ViewBox" => x)

type MudImageBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    /// Applies the fluid class so the image scales with the parent width.
    [<CustomOperation("Fluid")>] member inline _.Fluid ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("Fluid" => x)
    /// Specifies the path to the image.
    [<CustomOperation("Src")>] member inline _.Src ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Src" => x)
    /// Specifies an alternate text for the image.
    [<CustomOperation("Alt")>] member inline _.Alt ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Alt" => x)
    /// Specifies the height of the image in px.
    [<CustomOperation("Height")>] member inline _.Height ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Int32>) = render ==> ("Height" => x)
    /// Specifies the width of the image in px.
    [<CustomOperation("Width")>] member inline _.Width ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Int32>) = render ==> ("Width" => x)
    /// The higher the number, the heavier the drop-shadow.
    [<CustomOperation("Elevation")>] member inline _.Elevation ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("Elevation" => x)
    /// Controls how the image should be resized.
    [<CustomOperation("ObjectFit")>] member inline _.ObjectFit ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.ObjectFit) = render ==> ("ObjectFit" => x)
    /// Controls how the image should positioned within its container.
    [<CustomOperation("ObjectPosition")>] member inline _.ObjectPosition ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.ObjectPosition) = render ==> ("ObjectPosition" => x)

type MudInputLabelBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    /// If true, the input element will be disabled.
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("Disabled" => x)
    /// If true, the label will be displayed in an error state.
    [<CustomOperation("Error")>] member inline _.Error ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("Error" => x)
    /// Variant to use.
    [<CustomOperation("Variant")>] member inline _.Variant ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Variant) = render ==> ("Variant" => x)
    /// Will adjust vertical spacing. 
    ///             
    [<CustomOperation("Margin")>] member inline _.Margin ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Margin) = render ==> ("Margin" => x)
    /// Will set the for attribute for WCAG accessiblility
    ///             
    [<CustomOperation("ForId")>] member inline _.ForId ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("ForId" => x)

type MudInputControlBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    /// Should be the Input
    [<CustomOperation("InputContent")>] member inline _.InputContent ([<InlineIfLambda>] render: AttrRenderFragment, fragment) = render ==> html.renderFragment("InputContent", fragment)
    /// Should be the Input
    [<CustomOperation("InputContent")>] member inline _.InputContent ([<InlineIfLambda>] render: AttrRenderFragment, fragments) = render ==> html.renderFragment("InputContent", fragment { yield! fragments })
    /// Should be the Input
    [<CustomOperation("InputContent")>] member inline _.InputContent ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("InputContent", html.text x)
    /// Should be the Input
    [<CustomOperation("InputContent")>] member inline _.InputContent ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("InputContent", html.text x)
    /// Should be the Input
    [<CustomOperation("InputContent")>] member inline _.InputContent ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("InputContent", html.text x)
    /// Will adjust vertical spacing. 
    ///             
    [<CustomOperation("Margin")>] member inline _.Margin ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Margin) = render ==> ("Margin" => x)
    /// If true, will apply mud-input-required class to the output div
    [<CustomOperation("Required")>] member inline _.Required ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("Required" => x)
    /// If true, the label will be displayed in an error state.
    [<CustomOperation("Error")>] member inline _.Error ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("Error" => x)
    /// The ErrorText that will be displayed if Error true
    [<CustomOperation("ErrorText")>] member inline _.ErrorText ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("ErrorText" => x)
    /// The ErrorId that will be used by aria-describedby if Error true
    [<CustomOperation("ErrorId")>] member inline _.ErrorId ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("ErrorId" => x)
    /// The HelperText will be displayed below the text field.
    [<CustomOperation("HelperText")>] member inline _.HelperText ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("HelperText" => x)
    /// If true, the helper text will only be visible on focus.
    [<CustomOperation("HelperTextOnFocus")>] member inline _.HelperTextOnFocus ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("HelperTextOnFocus" => x)
    /// The current character counter, displayed below the text field.
    [<CustomOperation("CounterText")>] member inline _.CounterText ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("CounterText" => x)
    /// If true, the input will take up the full width of its container.
    [<CustomOperation("FullWidth")>] member inline _.FullWidth ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("FullWidth" => x)
    /// If string has value the label text will be displayed in the input, and scaled down at the top if the input has value.
    [<CustomOperation("Label")>] member inline _.Label ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Label" => x)
    /// Variant can be Text, Filled or Outlined.
    [<CustomOperation("Variant")>] member inline _.Variant ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Variant) = render ==> ("Variant" => x)
    /// If true, the input element will be disabled.
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("Disabled" => x)
    /// If string has value the label "for" attribute will be added.
    [<CustomOperation("ForId")>] member inline _.ForId ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("ForId" => x)

type MudLinkBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    /// The color of the component. It supports the theme colors.
    [<CustomOperation("Color")>] member inline _.Color ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("Color" => x)
    /// Typography variant to use.
    [<CustomOperation("Typo")>] member inline _.Typo ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Typo) = render ==> ("Typo" => x)
    /// Controls when the link should have an underline.
    [<CustomOperation("Underline")>] member inline _.Underline ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Underline) = render ==> ("Underline" => x)
    /// The URL, which is the actual link.
    [<CustomOperation("Href")>] member inline _.Href ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Href" => x)
    /// The target attribute specifies where to open the link, if Link is specified. Possible values: _blank | _self | _parent | _top | framename
    [<CustomOperation("Target")>] member inline _.Target ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Target" => x)
    /// Link click event.
    [<CustomOperation("OnClick")>] member inline _.OnClick ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>("OnClick", fn)
    /// Link click event.
    [<CustomOperation("OnClick")>] member inline _.OnClick ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callbackTask<Microsoft.AspNetCore.Components.Web.MouseEventArgs>("OnClick", fn)
    /// If true, the navlink will be disabled.
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("Disabled" => x)

type MudListBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    /// The color of the selected List Item.
    [<CustomOperation("Color")>] member inline _.Color ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("Color" => x)
    /// Set true to make the list items clickable. This is also the precondition for list selection to work.
    [<CustomOperation("Clickable")>] member inline _.Clickable ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("Clickable" => x)
    /// If true, vertical padding will be removed from the list.
    [<CustomOperation("DisablePadding")>] member inline _.DisablePadding ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("DisablePadding" => x)
    /// If true, compact vertical padding will be applied to all list items.
    [<CustomOperation("Dense")>] member inline _.Dense ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("Dense" => x)
    /// If true, the left and right padding is removed on all list items.
    [<CustomOperation("DisableGutters")>] member inline _.DisableGutters ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("DisableGutters" => x)
    /// If true, will disable the list item if it has onclick.
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("Disabled" => x)
    /// The current selected list item.
    /// Note: make the list Clickable for item selection to work.
    [<CustomOperation("SelectedItem")>] member inline _.SelectedItem ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.MudListItem) = render ==> ("SelectedItem" => x)
    /// The current selected list item.
    /// Note: make the list Clickable for item selection to work.
    [<CustomOperation("SelectedItem'")>] member inline _.SelectedItem' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: MudBlazor.MudListItem * (MudBlazor.MudListItem -> unit)) = render ==> html.bind("SelectedItem", valueFn)
    /// Called whenever the selection changed
    [<CustomOperation("SelectedItemChanged")>] member inline _.SelectedItemChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callback<MudBlazor.MudListItem>("SelectedItemChanged", fn)
    /// Called whenever the selection changed
    [<CustomOperation("SelectedItemChanged")>] member inline _.SelectedItemChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callbackTask<MudBlazor.MudListItem>("SelectedItemChanged", fn)
    /// The current selected value.
    /// Note: make the list Clickable for item selection to work.
    [<CustomOperation("SelectedValue")>] member inline _.SelectedValue ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Object) = render ==> ("SelectedValue" => x)
    /// The current selected value.
    /// Note: make the list Clickable for item selection to work.
    [<CustomOperation("SelectedValue'")>] member inline _.SelectedValue' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.Object * (System.Object -> unit)) = render ==> html.bind("SelectedValue", valueFn)
    /// Called whenever the selection changed
    [<CustomOperation("SelectedValueChanged")>] member inline _.SelectedValueChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callback<System.Object>("SelectedValueChanged", fn)
    /// Called whenever the selection changed
    [<CustomOperation("SelectedValueChanged")>] member inline _.SelectedValueChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callbackTask<System.Object>("SelectedValueChanged", fn)

type MudListItemBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    /// The text to display
    [<CustomOperation("Text")>] member inline _.Text ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Text" => x)
    [<CustomOperation("Value")>] member inline _.Value ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Object) = render ==> ("Value" => x)
    /// Avatar to use if set.
    [<CustomOperation("Avatar")>] member inline _.Avatar ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Avatar" => x)
    /// Link to a URL when clicked.
    [<CustomOperation("Href")>] member inline _.Href ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Href" => x)
    /// If true, force browser to redirect outside component router-space.
    [<CustomOperation("ForceLoad")>] member inline _.ForceLoad ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("ForceLoad" => x)
    /// Avatar CSS Class to apply if Avatar is set.
    [<CustomOperation("AvatarClass")>] member inline _.AvatarClass ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("AvatarClass" => x)
    /// If true, will disable the list item if it has onclick.
    /// The value can be overridden by the parent list.
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("Disabled" => x)
    /// If true, disables ripple effect.
    [<CustomOperation("DisableRipple")>] member inline _.DisableRipple ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("DisableRipple" => x)
    /// Icon to use if set.
    [<CustomOperation("Icon")>] member inline _.Icon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Icon" => x)
    /// The color of the icon.
    [<CustomOperation("IconColor")>] member inline _.IconColor ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("IconColor" => x)
    /// Sets the Icon Size.
    [<CustomOperation("IconSize")>] member inline _.IconSize ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Size) = render ==> ("IconSize" => x)
    /// The color of the adornment if used. It supports the theme colors.
    [<CustomOperation("AdornmentColor")>] member inline _.AdornmentColor ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("AdornmentColor" => x)
    /// Custom expand less icon.
    [<CustomOperation("ExpandLessIcon")>] member inline _.ExpandLessIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("ExpandLessIcon" => x)
    /// Custom expand more icon.
    [<CustomOperation("ExpandMoreIcon")>] member inline _.ExpandMoreIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("ExpandMoreIcon" => x)
    /// If true, the List Subheader will be indented.
    [<CustomOperation("Inset")>] member inline _.Inset ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("Inset" => x)
    /// If true, compact vertical padding will be used.
    [<CustomOperation("Dense")>] member inline _.Dense ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Boolean>) = render ==> ("Dense" => x)
    /// If true, the left and right padding is removed.
    [<CustomOperation("DisableGutters")>] member inline _.DisableGutters ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("DisableGutters" => x)
    /// Expand or collapse nested list. Two-way bindable. Note: if you directly set this to
    /// true or false (instead of using two-way binding) it will force the nested list's expansion state.
    [<CustomOperation("Expanded")>] member inline _.Expanded ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("Expanded" => x)
    /// Expand or collapse nested list. Two-way bindable. Note: if you directly set this to
    /// true or false (instead of using two-way binding) it will force the nested list's expansion state.
    [<CustomOperation("Expanded'")>] member inline _.Expanded' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.Boolean * (System.Boolean -> unit)) = render ==> html.bind("Expanded", valueFn)
    [<CustomOperation("ExpandedChanged")>] member inline _.ExpandedChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callback<System.Boolean>("ExpandedChanged", fn)
    [<CustomOperation("ExpandedChanged")>] member inline _.ExpandedChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callbackTask<System.Boolean>("ExpandedChanged", fn)
    /// If true, expands the nested list on first display
    [<CustomOperation("InitiallyExpanded")>] member inline _.InitiallyExpanded ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("InitiallyExpanded" => x)
    /// Command parameter.
    [<CustomOperation("CommandParameter")>] member inline _.CommandParameter ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Object) = render ==> ("CommandParameter" => x)
    /// Command executed when the user clicks on an element.
    [<CustomOperation("Command")>] member inline _.Command ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Windows.Input.ICommand) = render ==> ("Command" => x)
    [<CustomOperation("OnClickHandlerPreventDefault")>] member inline _.OnClickHandlerPreventDefault ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("OnClickHandlerPreventDefault" => x)
    /// Add child list items here to create a nested list.
    [<CustomOperation("NestedList")>] member inline _.NestedList ([<InlineIfLambda>] render: AttrRenderFragment, fragment) = render ==> html.renderFragment("NestedList", fragment)
    /// Add child list items here to create a nested list.
    [<CustomOperation("NestedList")>] member inline _.NestedList ([<InlineIfLambda>] render: AttrRenderFragment, fragments) = render ==> html.renderFragment("NestedList", fragment { yield! fragments })
    /// Add child list items here to create a nested list.
    [<CustomOperation("NestedList")>] member inline _.NestedList ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("NestedList", html.text x)
    /// Add child list items here to create a nested list.
    [<CustomOperation("NestedList")>] member inline _.NestedList ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("NestedList", html.text x)
    /// Add child list items here to create a nested list.
    [<CustomOperation("NestedList")>] member inline _.NestedList ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("NestedList", html.text x)
    /// List click event.
    [<CustomOperation("OnClick")>] member inline _.OnClick ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>("OnClick", fn)
    /// List click event.
    [<CustomOperation("OnClick")>] member inline _.OnClick ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callbackTask<Microsoft.AspNetCore.Components.Web.MouseEventArgs>("OnClick", fn)

type MudListSubheaderBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("DisableGutters")>] member inline _.DisableGutters ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("DisableGutters" => x)
    [<CustomOperation("Inset")>] member inline _.Inset ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("Inset" => x)

type MudMenuBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Label")>] member inline _.Label ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Label" => x)
    /// User class names for the list, separated by space
    [<CustomOperation("ListClass")>] member inline _.ListClass ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("ListClass" => x)
    /// User class names for the popover, separated by space
    [<CustomOperation("PopoverClass")>] member inline _.PopoverClass ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("PopoverClass" => x)
    /// Icon to use if set will turn the button into a MudIconButton.
    [<CustomOperation("Icon")>] member inline _.Icon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Icon" => x)
    /// The color of the icon. It supports the theme colors.
    [<CustomOperation("IconColor")>] member inline _.IconColor ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("IconColor" => x)
    /// Icon placed before the text if set.
    [<CustomOperation("StartIcon")>] member inline _.StartIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("StartIcon" => x)
    /// Icon placed after the text if set.
    [<CustomOperation("EndIcon")>] member inline _.EndIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("EndIcon" => x)
    /// The color of the button. It supports the theme colors.
    [<CustomOperation("Color")>] member inline _.Color ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("Color" => x)
    /// The button Size of the component.
    [<CustomOperation("Size")>] member inline _.Size ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Size) = render ==> ("Size" => x)
    /// The button variant to use.
    [<CustomOperation("Variant")>] member inline _.Variant ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Variant) = render ==> ("Variant" => x)
    /// If true, compact vertical padding will be applied to all menu items.
    [<CustomOperation("Dense")>] member inline _.Dense ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("Dense" => x)
    /// If true, the list menu will be same width as the parent.
    [<CustomOperation("FullWidth")>] member inline _.FullWidth ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("FullWidth" => x)
    /// Sets the maxheight the menu can have when open.
    [<CustomOperation("MaxHeight")>] member inline _.MaxHeight ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Int32>) = render ==> ("MaxHeight" => x)
    /// If true, instead of positioning the menu at the left upper corner, position at the exact cursor location.
    /// This makes sense for larger activators
    [<CustomOperation("PositionAtCursor")>] member inline _.PositionAtCursor ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("PositionAtCursor" => x)
    /// Place a MudButton, a MudIconButton or any other component capable of acting as an activator. This will
    /// override the standard button and all parameters which concern it.
    [<CustomOperation("ActivatorContent")>] member inline _.ActivatorContent ([<InlineIfLambda>] render: AttrRenderFragment, fragment) = render ==> html.renderFragment("ActivatorContent", fragment)
    /// Place a MudButton, a MudIconButton or any other component capable of acting as an activator. This will
    /// override the standard button and all parameters which concern it.
    [<CustomOperation("ActivatorContent")>] member inline _.ActivatorContent ([<InlineIfLambda>] render: AttrRenderFragment, fragments) = render ==> html.renderFragment("ActivatorContent", fragment { yield! fragments })
    /// Place a MudButton, a MudIconButton or any other component capable of acting as an activator. This will
    /// override the standard button and all parameters which concern it.
    [<CustomOperation("ActivatorContent")>] member inline _.ActivatorContent ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("ActivatorContent", html.text x)
    /// Place a MudButton, a MudIconButton or any other component capable of acting as an activator. This will
    /// override the standard button and all parameters which concern it.
    [<CustomOperation("ActivatorContent")>] member inline _.ActivatorContent ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("ActivatorContent", html.text x)
    /// Place a MudButton, a MudIconButton or any other component capable of acting as an activator. This will
    /// override the standard button and all parameters which concern it.
    [<CustomOperation("ActivatorContent")>] member inline _.ActivatorContent ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("ActivatorContent", html.text x)
    /// Specify the activation event when ActivatorContent is set
    [<CustomOperation("ActivationEvent")>] member inline _.ActivationEvent ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.MouseEvent) = render ==> ("ActivationEvent" => x)
    /// Set the anchor origin point to determen where the popover will open from.
    [<CustomOperation("AnchorOrigin")>] member inline _.AnchorOrigin ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Origin) = render ==> ("AnchorOrigin" => x)
    /// Sets the transform origin point for the popover.
    [<CustomOperation("TransformOrigin")>] member inline _.TransformOrigin ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Origin) = render ==> ("TransformOrigin" => x)
    /// Set to true if you want to prevent page from scrolling when the menu is open
    [<CustomOperation("LockScroll")>] member inline _.LockScroll ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("LockScroll" => x)
    /// If true, menu will be disabled.
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("Disabled" => x)
    /// If true, disables ripple effect.
    [<CustomOperation("DisableRipple")>] member inline _.DisableRipple ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("DisableRipple" => x)
    /// If true, no drop-shadow will be used.
    [<CustomOperation("DisableElevation")>] member inline _.DisableElevation ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("DisableElevation" => x)

type MudMenuItemBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("Disabled" => x)
    /// If set to a URL, clicking the button will open the referenced document. Use Target to specify where (Obsolete replaced by Href)
    [<CustomOperation("Link")>] member inline _.Link ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Link" => x)
    /// If set to a URL, clicking the button will open the referenced document. Use Target to specify where
    [<CustomOperation("Href")>] member inline _.Href ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Href" => x)
    /// Icon to be used for this menu entry
    [<CustomOperation("Icon")>] member inline _.Icon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Icon" => x)
    /// The color of the icon. It supports the theme colors.
    [<CustomOperation("IconColor")>] member inline _.IconColor ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("IconColor" => x)
    /// The Icon Size.
    [<CustomOperation("IconSize")>] member inline _.IconSize ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Size) = render ==> ("IconSize" => x)
    [<CustomOperation("Target")>] member inline _.Target ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Target" => x)
    [<CustomOperation("ForceLoad")>] member inline _.ForceLoad ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("ForceLoad" => x)
    [<CustomOperation("Command")>] member inline _.Command ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Windows.Input.ICommand) = render ==> ("Command" => x)
    [<CustomOperation("CommandParameter")>] member inline _.CommandParameter ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Object) = render ==> ("CommandParameter" => x)
    [<CustomOperation("OnClick")>] member inline _.OnClick ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>("OnClick", fn)
    [<CustomOperation("OnClick")>] member inline _.OnClick ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callbackTask<Microsoft.AspNetCore.Components.Web.MouseEventArgs>("OnClick", fn)
    [<CustomOperation("OnTouch")>] member inline _.OnTouch ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callback<Microsoft.AspNetCore.Components.Web.TouchEventArgs>("OnTouch", fn)
    [<CustomOperation("OnTouch")>] member inline _.OnTouch ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callbackTask<Microsoft.AspNetCore.Components.Web.TouchEventArgs>("OnTouch", fn)

type MudMessageBoxBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    /// The message box title. If null or empty, title will be hidden
    [<CustomOperation("Title")>] member inline _.Title ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Title" => x)
    /// Define the message box title as a renderfragment (overrides Title)
    [<CustomOperation("TitleContent")>] member inline _.TitleContent ([<InlineIfLambda>] render: AttrRenderFragment, fragment) = render ==> html.renderFragment("TitleContent", fragment)
    /// Define the message box title as a renderfragment (overrides Title)
    [<CustomOperation("TitleContent")>] member inline _.TitleContent ([<InlineIfLambda>] render: AttrRenderFragment, fragments) = render ==> html.renderFragment("TitleContent", fragment { yield! fragments })
    /// Define the message box title as a renderfragment (overrides Title)
    [<CustomOperation("TitleContent")>] member inline _.TitleContent ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("TitleContent", html.text x)
    /// Define the message box title as a renderfragment (overrides Title)
    [<CustomOperation("TitleContent")>] member inline _.TitleContent ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("TitleContent", html.text x)
    /// Define the message box title as a renderfragment (overrides Title)
    [<CustomOperation("TitleContent")>] member inline _.TitleContent ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("TitleContent", html.text x)
    /// The message box message as string.
    [<CustomOperation("Message")>] member inline _.Message ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Message" => x)
    /// The message box message as markup string.
    [<CustomOperation("MarkupMessage")>] member inline _.MarkupMessage ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.AspNetCore.Components.MarkupString) = render ==> ("MarkupMessage" => x)
    /// Define the message box body as a renderfragment (overrides Message)
    [<CustomOperation("MessageContent")>] member inline _.MessageContent ([<InlineIfLambda>] render: AttrRenderFragment, fragment) = render ==> html.renderFragment("MessageContent", fragment)
    /// Define the message box body as a renderfragment (overrides Message)
    [<CustomOperation("MessageContent")>] member inline _.MessageContent ([<InlineIfLambda>] render: AttrRenderFragment, fragments) = render ==> html.renderFragment("MessageContent", fragment { yield! fragments })
    /// Define the message box body as a renderfragment (overrides Message)
    [<CustomOperation("MessageContent")>] member inline _.MessageContent ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("MessageContent", html.text x)
    /// Define the message box body as a renderfragment (overrides Message)
    [<CustomOperation("MessageContent")>] member inline _.MessageContent ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("MessageContent", html.text x)
    /// Define the message box body as a renderfragment (overrides Message)
    [<CustomOperation("MessageContent")>] member inline _.MessageContent ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("MessageContent", html.text x)
    /// Text of the cancel button. Leave null to hide the button.
    [<CustomOperation("CancelText")>] member inline _.CancelText ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("CancelText" => x)
    /// Define the cancel button as a render fragment (overrides CancelText).
    /// Must be a MudButton
    [<CustomOperation("CancelButton")>] member inline _.CancelButton ([<InlineIfLambda>] render: AttrRenderFragment, fragment) = render ==> html.renderFragment("CancelButton", fragment)
    /// Define the cancel button as a render fragment (overrides CancelText).
    /// Must be a MudButton
    [<CustomOperation("CancelButton")>] member inline _.CancelButton ([<InlineIfLambda>] render: AttrRenderFragment, fragments) = render ==> html.renderFragment("CancelButton", fragment { yield! fragments })
    /// Define the cancel button as a render fragment (overrides CancelText).
    /// Must be a MudButton
    [<CustomOperation("CancelButton")>] member inline _.CancelButton ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("CancelButton", html.text x)
    /// Define the cancel button as a render fragment (overrides CancelText).
    /// Must be a MudButton
    [<CustomOperation("CancelButton")>] member inline _.CancelButton ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("CancelButton", html.text x)
    /// Define the cancel button as a render fragment (overrides CancelText).
    /// Must be a MudButton
    [<CustomOperation("CancelButton")>] member inline _.CancelButton ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("CancelButton", html.text x)
    /// Text of the no button. Leave null to hide the button.
    [<CustomOperation("NoText")>] member inline _.NoText ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("NoText" => x)
    /// Define the no button as a render fragment (overrides CancelText).
    /// Must be a MudButton
    [<CustomOperation("NoButton")>] member inline _.NoButton ([<InlineIfLambda>] render: AttrRenderFragment, fragment) = render ==> html.renderFragment("NoButton", fragment)
    /// Define the no button as a render fragment (overrides CancelText).
    /// Must be a MudButton
    [<CustomOperation("NoButton")>] member inline _.NoButton ([<InlineIfLambda>] render: AttrRenderFragment, fragments) = render ==> html.renderFragment("NoButton", fragment { yield! fragments })
    /// Define the no button as a render fragment (overrides CancelText).
    /// Must be a MudButton
    [<CustomOperation("NoButton")>] member inline _.NoButton ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("NoButton", html.text x)
    /// Define the no button as a render fragment (overrides CancelText).
    /// Must be a MudButton
    [<CustomOperation("NoButton")>] member inline _.NoButton ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("NoButton", html.text x)
    /// Define the no button as a render fragment (overrides CancelText).
    /// Must be a MudButton
    [<CustomOperation("NoButton")>] member inline _.NoButton ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("NoButton", html.text x)
    /// Text of the yes/OK button. Leave null to hide the button.
    [<CustomOperation("YesText")>] member inline _.YesText ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("YesText" => x)
    /// Define the cancel button as a render fragment (overrides CancelText).
    /// Must be a MudButton
    [<CustomOperation("YesButton")>] member inline _.YesButton ([<InlineIfLambda>] render: AttrRenderFragment, fragment) = render ==> html.renderFragment("YesButton", fragment)
    /// Define the cancel button as a render fragment (overrides CancelText).
    /// Must be a MudButton
    [<CustomOperation("YesButton")>] member inline _.YesButton ([<InlineIfLambda>] render: AttrRenderFragment, fragments) = render ==> html.renderFragment("YesButton", fragment { yield! fragments })
    /// Define the cancel button as a render fragment (overrides CancelText).
    /// Must be a MudButton
    [<CustomOperation("YesButton")>] member inline _.YesButton ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("YesButton", html.text x)
    /// Define the cancel button as a render fragment (overrides CancelText).
    /// Must be a MudButton
    [<CustomOperation("YesButton")>] member inline _.YesButton ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("YesButton", html.text x)
    /// Define the cancel button as a render fragment (overrides CancelText).
    /// Must be a MudButton
    [<CustomOperation("YesButton")>] member inline _.YesButton ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("YesButton", html.text x)
    /// Fired when the yes button is clicked
    [<CustomOperation("OnYes")>] member inline _.OnYes ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callback<System.Boolean>("OnYes", fn)
    /// Fired when the yes button is clicked
    [<CustomOperation("OnYes")>] member inline _.OnYes ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callbackTask<System.Boolean>("OnYes", fn)
    /// Fired when the no button is clicked
    [<CustomOperation("OnNo")>] member inline _.OnNo ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callback<System.Boolean>("OnNo", fn)
    /// Fired when the no button is clicked
    [<CustomOperation("OnNo")>] member inline _.OnNo ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callbackTask<System.Boolean>("OnNo", fn)
    /// Fired when the cancel button is clicked or the msg box was closed via the X
    [<CustomOperation("OnCancel")>] member inline _.OnCancel ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callback<System.Boolean>("OnCancel", fn)
    /// Fired when the cancel button is clicked or the msg box was closed via the X
    [<CustomOperation("OnCancel")>] member inline _.OnCancel ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callbackTask<System.Boolean>("OnCancel", fn)
    /// Bind this two-way to show and close an inlined message box. Has no effect on opened msg boxes
    [<CustomOperation("IsVisible")>] member inline _.IsVisible ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("IsVisible" => x)
    /// Bind this two-way to show and close an inlined message box. Has no effect on opened msg boxes
    [<CustomOperation("IsVisible'")>] member inline _.IsVisible' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.Boolean * (System.Boolean -> unit)) = render ==> html.bind("IsVisible", valueFn)
    /// Raised when the inline dialog's display status changes.
    [<CustomOperation("IsVisibleChanged")>] member inline _.IsVisibleChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callback<System.Boolean>("IsVisibleChanged", fn)
    /// Raised when the inline dialog's display status changes.
    [<CustomOperation("IsVisibleChanged")>] member inline _.IsVisibleChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callbackTask<System.Boolean>("IsVisibleChanged", fn)

type MudNavGroupBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Title")>] member inline _.Title ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Title" => x)
    /// Icon to use if set.
    [<CustomOperation("Icon")>] member inline _.Icon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Icon" => x)
    /// The color of the icon. It supports the theme colors, default value uses the themes drawer icon color.
    [<CustomOperation("IconColor")>] member inline _.IconColor ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("IconColor" => x)
    /// If true, the button will be disabled.
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("Disabled" => x)
    /// If true, disables ripple effect.
    [<CustomOperation("DisableRipple")>] member inline _.DisableRipple ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("DisableRipple" => x)
    /// If true, expands the nav group, otherwise collapse it. 
    /// Two-way bindable
    [<CustomOperation("Expanded")>] member inline _.Expanded ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("Expanded" => x)
    /// If true, expands the nav group, otherwise collapse it. 
    /// Two-way bindable
    [<CustomOperation("Expanded'")>] member inline _.Expanded' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.Boolean * (System.Boolean -> unit)) = render ==> html.bind("Expanded", valueFn)
    [<CustomOperation("ExpandedChanged")>] member inline _.ExpandedChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callback<System.Boolean>("ExpandedChanged", fn)
    [<CustomOperation("ExpandedChanged")>] member inline _.ExpandedChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callbackTask<System.Boolean>("ExpandedChanged", fn)
    /// If true, hides expand-icon at the end of the NavGroup.
    [<CustomOperation("HideExpandIcon")>] member inline _.HideExpandIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("HideExpandIcon" => x)
    /// Explicitly sets the height for the Collapse element to override the css default.
    [<CustomOperation("MaxHeight")>] member inline _.MaxHeight ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Int32>) = render ==> ("MaxHeight" => x)
    /// If set, overrides the default expand icon.
    [<CustomOperation("ExpandIcon")>] member inline _.ExpandIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("ExpandIcon" => x)

type MudNavMenuBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    /// The color of the active NavLink.
    [<CustomOperation("Color")>] member inline _.Color ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("Color" => x)
    /// If true, adds a border of the active NavLink, does nothing if variant outlined is used.
    [<CustomOperation("Bordered")>] member inline _.Bordered ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("Bordered" => x)
    /// If true, default theme border-radius will be used on all navlinks.
    [<CustomOperation("Rounded")>] member inline _.Rounded ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("Rounded" => x)
    /// Adjust the vertical spacing between navlinks.
    ///             
    [<CustomOperation("Margin")>] member inline _.Margin ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Margin) = render ==> ("Margin" => x)
    /// If true, compact vertical padding will be applied to all navmenu items.
    [<CustomOperation("Dense")>] member inline _.Dense ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("Dense" => x)

type MudOverlayBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    /// Fires when Visible changes
    [<CustomOperation("VisibleChanged")>] member inline _.VisibleChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callback<System.Boolean>("VisibleChanged", fn)
    /// Fires when Visible changes
    [<CustomOperation("VisibleChanged")>] member inline _.VisibleChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callbackTask<System.Boolean>("VisibleChanged", fn)
    /// If true overlay will be visible. Two-way bindable.
    [<CustomOperation("Visible")>] member inline _.Visible ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("Visible" => x)
    /// If true overlay will be visible. Two-way bindable.
    [<CustomOperation("Visible'")>] member inline _.Visible' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.Boolean * (System.Boolean -> unit)) = render ==> html.bind("Visible", valueFn)
    /// If true overlay will set Visible false on click.
    [<CustomOperation("AutoClose")>] member inline _.AutoClose ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("AutoClose" => x)
    /// If true (default), the Document.body element will not be able to scroll
    [<CustomOperation("LockScroll")>] member inline _.LockScroll ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("LockScroll" => x)
    /// The css class that will be added to body if lockscroll is used.
    [<CustomOperation("LockScrollClass")>] member inline _.LockScrollClass ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("LockScrollClass" => x)
    /// If true applys the themes dark overlay color.
    [<CustomOperation("DarkBackground")>] member inline _.DarkBackground ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("DarkBackground" => x)
    /// If true applys the themes light overlay color.
    [<CustomOperation("LightBackground")>] member inline _.LightBackground ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("LightBackground" => x)
    /// If true, use absolute positioning for the overlay.
    [<CustomOperation("Absolute")>] member inline _.Absolute ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("Absolute" => x)
    /// Sets the z-index of the overlay.
    [<CustomOperation("ZIndex")>] member inline _.ZIndex ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("ZIndex" => x)
    /// Command parameter.
    [<CustomOperation("CommandParameter")>] member inline _.CommandParameter ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Object) = render ==> ("CommandParameter" => x)
    /// Command executed when the user clicks on an element.
    [<CustomOperation("Command")>] member inline _.Command ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Windows.Input.ICommand) = render ==> ("Command" => x)
    /// Fired when the overlay is clicked
    [<CustomOperation("OnClick")>] member inline _.OnClick ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>("OnClick", fn)
    /// Fired when the overlay is clicked
    [<CustomOperation("OnClick")>] member inline _.OnClick ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callbackTask<Microsoft.AspNetCore.Components.Web.MouseEventArgs>("OnClick", fn)

type MudPageContentNavigationBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    /// The text displayed about the section links. Defaults to "Conents"
    [<CustomOperation("Headline")>] member inline _.Headline ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Headline" => x)
    /// The css selector used to identifify the HTML elements that should be observed for viewport changes
    [<CustomOperation("SectionClassSelector")>] member inline _.SectionClassSelector ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("SectionClassSelector" => x)
    /// If there are mutliple levels, this can specified to make a mapping between a level class likw "second-level" and the level in the hierarchy
    [<CustomOperation("HierarchyMapper")>] member inline _.HierarchyMapper ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.IDictionary<System.String, System.Int32>) = render ==> ("HierarchyMapper" => x)
    /// If there are multiple levels, this property controls they visibility of them.
    [<CustomOperation("ExpandBehaviour")>] member inline _.ExpandBehaviour ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.ContentNavigationExpandBehaviour) = render ==> ("ExpandBehaviour" => x)
    /// If this option is true the first added section will become active when there is no other indication of an active session. Default value is false  
    [<CustomOperation("ActivateFirstSectionAsDefault")>] member inline _.ActivateFirstSectionAsDefault ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("ActivateFirstSectionAsDefault" => x)

type MudPaginationBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    /// The number of pages.
    [<CustomOperation("Count")>] member inline _.Count ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("Count" => x)
    /// The number of items at the start and end of the pagination.
    [<CustomOperation("BoundaryCount")>] member inline _.BoundaryCount ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("BoundaryCount" => x)
    /// The number of items in the middle of the pagination.
    [<CustomOperation("MiddleCount")>] member inline _.MiddleCount ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("MiddleCount" => x)
    /// The selected page number.
    [<CustomOperation("Selected")>] member inline _.Selected ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("Selected" => x)
    /// The selected page number.
    [<CustomOperation("Selected'")>] member inline _.Selected' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.Int32 * (System.Int32 -> unit)) = render ==> html.bind("Selected", valueFn)
    /// The variant to use.
    [<CustomOperation("Variant")>] member inline _.Variant ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Variant) = render ==> ("Variant" => x)
    /// The color of the component. It supports the theme colors.
    [<CustomOperation("Color")>] member inline _.Color ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("Color" => x)
    /// If true, the pagination buttons are displayed rectangular.
    [<CustomOperation("Rectangular")>] member inline _.Rectangular ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("Rectangular" => x)
    /// The size of the component..
    [<CustomOperation("Size")>] member inline _.Size ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Size) = render ==> ("Size" => x)
    /// If true, no drop-shadow will be used.
    [<CustomOperation("DisableElevation")>] member inline _.DisableElevation ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("DisableElevation" => x)
    /// If true, the pagination will be disabled.
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("Disabled" => x)
    /// If true, the navigate-to-first-page button is shown.
    [<CustomOperation("ShowFirstButton")>] member inline _.ShowFirstButton ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("ShowFirstButton" => x)
    /// If true, the navigate-to-last-page button is shown.
    [<CustomOperation("ShowLastButton")>] member inline _.ShowLastButton ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("ShowLastButton" => x)
    /// If true, the navigate-to-previous-page button is shown.
    [<CustomOperation("ShowPreviousButton")>] member inline _.ShowPreviousButton ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("ShowPreviousButton" => x)
    /// If true, the navigate-to-next-page button is shown.
    [<CustomOperation("ShowNextButton")>] member inline _.ShowNextButton ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("ShowNextButton" => x)
    /// Invokes the callback when a control button is clicked.
    [<CustomOperation("ControlButtonClicked")>] member inline _.ControlButtonClicked ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callback<MudBlazor.Page>("ControlButtonClicked", fn)
    /// Invokes the callback when a control button is clicked.
    [<CustomOperation("ControlButtonClicked")>] member inline _.ControlButtonClicked ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callbackTask<MudBlazor.Page>("ControlButtonClicked", fn)
    /// Invokes the callback when selected page changes.
    [<CustomOperation("SelectedChanged")>] member inline _.SelectedChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callback<System.Int32>("SelectedChanged", fn)
    /// Invokes the callback when selected page changes.
    [<CustomOperation("SelectedChanged")>] member inline _.SelectedChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callbackTask<System.Int32>("SelectedChanged", fn)
    /// Custom first icon.
    [<CustomOperation("FirstIcon")>] member inline _.FirstIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("FirstIcon" => x)
    /// Custom before icon.
    [<CustomOperation("BeforeIcon")>] member inline _.BeforeIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("BeforeIcon" => x)
    /// Custom next icon.
    [<CustomOperation("NextIcon")>] member inline _.NextIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("NextIcon" => x)
    /// Custom last icon.
    [<CustomOperation("LastIcon")>] member inline _.LastIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("LastIcon" => x)

type MudPaperBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    /// The higher the number, the heavier the drop-shadow.
    [<CustomOperation("Elevation")>] member inline _.Elevation ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("Elevation" => x)
    /// If true, border-radius is set to 0.
    [<CustomOperation("Square")>] member inline _.Square ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("Square" => x)
    /// If true, card will be outlined.
    [<CustomOperation("Outlined")>] member inline _.Outlined ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("Outlined" => x)
    /// Height of the component.
    [<CustomOperation("Height")>] member inline _.Height ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Height" => x)
    /// Width of the component.
    [<CustomOperation("Width")>] member inline _.Width ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Width" => x)
    /// Max-Height of the component.
    [<CustomOperation("MaxHeight")>] member inline _.MaxHeight ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("MaxHeight" => x)
    /// Max-Width of the component.
    [<CustomOperation("MaxWidth")>] member inline _.MaxWidth ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("MaxWidth" => x)
    /// Min-Height of the component.
    [<CustomOperation("MinHeight")>] member inline _.MinHeight ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("MinHeight" => x)
    /// Min-Width of the component.
    [<CustomOperation("MinWidth")>] member inline _.MinWidth ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("MinWidth" => x)

type MudPopoverBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    /// Sets the maxheight the popover can have when open.
    [<CustomOperation("MaxHeight")>] member inline _.MaxHeight ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Int32>) = render ==> ("MaxHeight" => x)
    /// If true, will apply default MudPaper classes.
    [<CustomOperation("Paper")>] member inline _.Paper ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("Paper" => x)
    /// The higher the number, the heavier the drop-shadow.
    [<CustomOperation("Elevation")>] member inline _.Elevation ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("Elevation" => x)
    /// If true, border-radius is set to 0.
    [<CustomOperation("Square")>] member inline _.Square ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("Square" => x)
    /// If true, the popover is visible.
    [<CustomOperation("Open")>] member inline _.Open ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("Open" => x)
    /// If true the popover will be fixed position instead of absolute.
    [<CustomOperation("Fixed")>] member inline _.Fixed ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("Fixed" => x)
    /// Sets the length of time that the opening transition takes to complete.
    [<CustomOperation("Duration")>] member inline _.Duration ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Double) = render ==> ("Duration" => x)
    /// Sets the amount of time in milliseconds to wait from opening the popover before beginning to perform the transition. 
    [<CustomOperation("Delay'")>] member inline _.Delay' ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Double) = render ==> ("Delay" => x)
    /// Set the anchor point on the element of the popover.
    /// The anchor point will determinate where the popover will be placed.
    [<CustomOperation("AnchorOrigin")>] member inline _.AnchorOrigin ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Origin) = render ==> ("AnchorOrigin" => x)
    /// Sets the intersection point if the anchor element. At this point the popover will lay above the popover. 
    /// This property in conjunction with AnchorPlacement determinate where the popover will be placed.
    [<CustomOperation("TransformOrigin")>] member inline _.TransformOrigin ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Origin) = render ==> ("TransformOrigin" => x)
    /// Set the overflow behavior of a popover and controls how the element should react if there is not enough space for the element to be visible
    /// Defaults to none, which doens't apply any overflow logic
    [<CustomOperation("OverflowBehavior")>] member inline _.OverflowBehavior ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.OverflowBehavior) = render ==> ("OverflowBehavior" => x)
    /// If true, the popover will have the same width at its parent element, default to false
    [<CustomOperation("RelativeWidth")>] member inline _.RelativeWidth ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("RelativeWidth" => x)

type MudProgressCircularBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    /// The color of the component. It supports the theme colors.
    [<CustomOperation("Color")>] member inline _.Color ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("Color" => x)
    /// The size of the component.
    [<CustomOperation("Size")>] member inline _.Size ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Size) = render ==> ("Size" => x)
    /// Constantly animates, does not follow any value.
    [<CustomOperation("Indeterminate")>] member inline _.Indeterminate ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("Indeterminate" => x)
    [<CustomOperation("Min")>] member inline _.Min ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Double) = render ==> ("Min" => x)
    [<CustomOperation("Max")>] member inline _.Max ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Double) = render ==> ("Max" => x)
    [<CustomOperation("Value")>] member inline _.Value ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Double) = render ==> ("Value" => x)
    [<CustomOperation("StrokeWidth")>] member inline _.StrokeWidth ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("StrokeWidth" => x)

type MudProgressLinearBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    /// The color of the component. It supports the theme colors.
    [<CustomOperation("Color")>] member inline _.Color ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("Color" => x)
    /// The color of the component. It supports the theme colors.
    [<CustomOperation("Size")>] member inline _.Size ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Size) = render ==> ("Size" => x)
    /// Constantly animates, does not follow any value.
    [<CustomOperation("Indeterminate")>] member inline _.Indeterminate ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("Indeterminate" => x)
    /// If true, the buffer value will be used.
    [<CustomOperation("Buffer")>] member inline _.Buffer ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("Buffer" => x)
    /// If true, border-radius is set to the themes default value.
    [<CustomOperation("Rounded")>] member inline _.Rounded ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("Rounded" => x)
    /// Adds stripes to the filled part of the linear progress.
    [<CustomOperation("Striped")>] member inline _.Striped ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("Striped" => x)
    /// If true, the progress bar  will be displayed vertically.
    [<CustomOperation("Vertical")>] member inline _.Vertical ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("Vertical" => x)
    /// The minimum allowed value of the linear progress. Should not be equal to max.
    [<CustomOperation("Min")>] member inline _.Min ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Double) = render ==> ("Min" => x)
    /// The maximum allowed value of the linear progress. Should not be equal to min.
    [<CustomOperation("Max")>] member inline _.Max ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Double) = render ==> ("Max" => x)
    /// The maximum allowed value of the linear progress. Should not be equal to min.
    [<CustomOperation("Value")>] member inline _.Value ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Double) = render ==> ("Value" => x)
    [<CustomOperation("BufferValue")>] member inline _.BufferValue ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Double) = render ==> ("BufferValue" => x)

type MudRadioBuilder<'FunBlazorGeneric, 'T when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    /// The color of the component. It supports the theme colors.
    [<CustomOperation("Color")>] member inline _.Color ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("Color" => x)
    /// The base color of the component in its none active/unchecked state. It supports the theme colors.
    [<CustomOperation("UnCheckedColor")>] member inline _.UnCheckedColor ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<MudBlazor.Color>) = render ==> ("UnCheckedColor" => x)
    /// The position of the child content.
    [<CustomOperation("Placement")>] member inline _.Placement ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Placement) = render ==> ("Placement" => x)
    /// The value to associate to the button.
    [<CustomOperation("Option")>] member inline _.Option ([<InlineIfLambda>] render: AttrRenderFragment, x: 'T) = render ==> ("Option" => x)
    /// If true, compact padding will be applied.
    [<CustomOperation("Dense")>] member inline _.Dense ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("Dense" => x)
    /// The Size of the component.
    [<CustomOperation("Size")>] member inline _.Size ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Size) = render ==> ("Size" => x)
    /// If true, disables ripple effect.
    [<CustomOperation("DisableRipple")>] member inline _.DisableRipple ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("DisableRipple" => x)
    /// If true, the button will be disabled.
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("Disabled" => x)

type MudRatingBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    /// User class names for RatingItems, separated by space
    [<CustomOperation("RatingItemsClass")>] member inline _.RatingItemsClass ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("RatingItemsClass" => x)
    /// User styles for RatingItems.
    [<CustomOperation("RatingItemsStyle")>] member inline _.RatingItemsStyle ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("RatingItemsStyle" => x)
    /// Input name. If not initialized, name will be random guid.
    [<CustomOperation("Name")>] member inline _.Name ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Name" => x)
    /// Max value and how many elements to click will be generated. Default: 5
    [<CustomOperation("MaxValue")>] member inline _.MaxValue ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("MaxValue" => x)
    /// Selected or hovered icon. Default @Icons.Material.Star
    [<CustomOperation("FullIcon")>] member inline _.FullIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("FullIcon" => x)
    /// Non selected item icon. Default @Icons.Material.StarBorder
    [<CustomOperation("EmptyIcon")>] member inline _.EmptyIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("EmptyIcon" => x)
    /// The color of the component. It supports the theme colors.
    [<CustomOperation("Color")>] member inline _.Color ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("Color" => x)
    /// The Size of the icons.
    [<CustomOperation("Size")>] member inline _.Size ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Size) = render ==> ("Size" => x)
    /// If true, disables ripple effect.
    [<CustomOperation("DisableRipple")>] member inline _.DisableRipple ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("DisableRipple" => x)
    /// If true, the controls will be disabled.
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("Disabled" => x)
    /// If true, the ratings will show without interactions.
    [<CustomOperation("ReadOnly")>] member inline _.ReadOnly ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("ReadOnly" => x)
    /// Fires when SelectedValue changes.
    [<CustomOperation("SelectedValueChanged")>] member inline _.SelectedValueChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callback<System.Int32>("SelectedValueChanged", fn)
    /// Fires when SelectedValue changes.
    [<CustomOperation("SelectedValueChanged")>] member inline _.SelectedValueChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callbackTask<System.Int32>("SelectedValueChanged", fn)
    /// Selected value. This property is two-way bindable.
    [<CustomOperation("SelectedValue")>] member inline _.SelectedValue ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("SelectedValue" => x)
    /// Selected value. This property is two-way bindable.
    [<CustomOperation("SelectedValue'")>] member inline _.SelectedValue' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.Int32 * (System.Int32 -> unit)) = render ==> html.bind("SelectedValue", valueFn)
    /// Fires when hovered value change. Value will be null if no rating item is hovered.
    [<CustomOperation("HoveredValueChanged")>] member inline _.HoveredValueChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callback<System.Nullable<System.Int32>>("HoveredValueChanged", fn)
    /// Fires when hovered value change. Value will be null if no rating item is hovered.
    [<CustomOperation("HoveredValueChanged")>] member inline _.HoveredValueChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callbackTask<System.Nullable<System.Int32>>("HoveredValueChanged", fn)

type MudRatingItemBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    /// This rating item value;
    [<CustomOperation("ItemValue")>] member inline _.ItemValue ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("ItemValue" => x)
    /// The Size of the icon.
    [<CustomOperation("Size")>] member inline _.Size ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Size) = render ==> ("Size" => x)
    /// The color of the component. It supports the theme colors.
    [<CustomOperation("Color")>] member inline _.Color ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("Color" => x)
    /// If true, disables ripple effect.
    [<CustomOperation("DisableRipple")>] member inline _.DisableRipple ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("DisableRipple" => x)
    /// If true, the controls will be disabled.
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("Disabled" => x)
    /// If true, the item will be readonly.
    [<CustomOperation("ReadOnly")>] member inline _.ReadOnly ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("ReadOnly" => x)
    /// Fires when element clicked.
    [<CustomOperation("ItemClicked")>] member inline _.ItemClicked ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callback<System.Int32>("ItemClicked", fn)
    /// Fires when element clicked.
    [<CustomOperation("ItemClicked")>] member inline _.ItemClicked ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callbackTask<System.Int32>("ItemClicked", fn)
    /// Fires when element hovered.
    [<CustomOperation("ItemHovered")>] member inline _.ItemHovered ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callback<System.Nullable<System.Int32>>("ItemHovered", fn)
    /// Fires when element hovered.
    [<CustomOperation("ItemHovered")>] member inline _.ItemHovered ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callbackTask<System.Nullable<System.Int32>>("ItemHovered", fn)

type MudRTLProviderBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    /// If true, changes the layout to RightToLeft.
    [<CustomOperation("RightToLeft")>] member inline _.RightToLeft ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("RightToLeft" => x)

type MudScrollToTopBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    /// The CSS selector to which the scroll event will be attached
    [<CustomOperation("Selector")>] member inline _.Selector ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Selector" => x)
    /// If set to true, it starts Visible. If sets to false, it will become visible when the TopOffset amount of scrolled pixels is reached
    [<CustomOperation("Visible")>] member inline _.Visible ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("Visible" => x)
    /// CSS class for the Visible state. Here, apply some transitions and animations that will happen when the component becomes visible
    [<CustomOperation("VisibleCssClass")>] member inline _.VisibleCssClass ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("VisibleCssClass" => x)
    /// CSS class for the Hidden state. Here, apply some transitions and animations that will happen when the component becomes invisible
    [<CustomOperation("HiddenCssClass")>] member inline _.HiddenCssClass ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("HiddenCssClass" => x)
    /// The distance in pixels scrolled from the top of the selected element from which 
    /// the component becomes visible
    [<CustomOperation("TopOffset")>] member inline _.TopOffset ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("TopOffset" => x)
    /// Smooth or Auto
    [<CustomOperation("ScrollBehavior")>] member inline _.ScrollBehavior ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.ScrollBehavior) = render ==> ("ScrollBehavior" => x)
    /// Called when scroll event is fired
    [<CustomOperation("OnScroll")>] member inline _.OnScroll ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callback<MudBlazor.ScrollEventArgs>("OnScroll", fn)
    /// Called when scroll event is fired
    [<CustomOperation("OnScroll")>] member inline _.OnScroll ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callbackTask<MudBlazor.ScrollEventArgs>("OnScroll", fn)

type MudSkeletonBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    /// With defined in string, needs px or % or equal prefix.
    [<CustomOperation("Width")>] member inline _.Width ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Width" => x)
    /// Height defined in string, needs px or % or equal prefix.
    [<CustomOperation("Height")>] member inline _.Height ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Height" => x)
    /// Shape of the skeleton that will be rendered.
    [<CustomOperation("SkeletonType")>] member inline _.SkeletonType ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.SkeletonType) = render ==> ("SkeletonType" => x)
    /// Animation style, if false it will be disabled.
    [<CustomOperation("Animation")>] member inline _.Animation ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Animation) = render ==> ("Animation" => x)

type MudSliderBuilder<'FunBlazorGeneric, 'T when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    /// The minimum allowed value of the slider. Should not be equal to max.
    [<CustomOperation("Min")>] member inline _.Min ([<InlineIfLambda>] render: AttrRenderFragment, x: 'T) = render ==> ("Min" => x)
    /// The maximum allowed value of the slider. Should not be equal to min.
    [<CustomOperation("Max")>] member inline _.Max ([<InlineIfLambda>] render: AttrRenderFragment, x: 'T) = render ==> ("Max" => x)
    /// How many steps the slider should take on each move.
    [<CustomOperation("Step")>] member inline _.Step ([<InlineIfLambda>] render: AttrRenderFragment, x: 'T) = render ==> ("Step" => x)
    /// If true, the slider will be disabled.
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("Disabled" => x)
    [<CustomOperation("Converter")>] member inline _.Converter ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Converter<'T>) = render ==> ("Converter" => x)
    [<CustomOperation("ValueChanged")>] member inline _.ValueChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callback<'T>("ValueChanged", fn)
    [<CustomOperation("ValueChanged")>] member inline _.ValueChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callbackTask<'T>("ValueChanged", fn)
    [<CustomOperation("Value")>] member inline _.Value ([<InlineIfLambda>] render: AttrRenderFragment, x: 'T) = render ==> ("Value" => x)
    [<CustomOperation("Value'")>] member inline _.Value' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: 'T * ('T -> unit)) = render ==> html.bind("Value", valueFn)
    /// The color of the component. It supports the Primary, Secondary and Tertiary theme colors.
    [<CustomOperation("Color")>] member inline _.Color ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("Color" => x)
    /// If true, the dragging the slider will update the Value immediately.
    /// If false, the Value is updated only on releasing the handle.
    [<CustomOperation("Immediate")>] member inline _.Immediate ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("Immediate" => x)
    /// If true, displays the slider vertical.
    [<CustomOperation("Vertical")>] member inline _.Vertical ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("Vertical" => x)
    /// If true, displays tick marks on the track.
    [<CustomOperation("TickMarks")>] member inline _.TickMarks ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("TickMarks" => x)
    /// Labels for tick marks, will attempt to map the labels to each step in index order.
    [<CustomOperation("TickMarkLabels")>] member inline _.TickMarkLabels ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String[]) = render ==> ("TickMarkLabels" => x)
    /// Labels for tick marks, will attempt to map the labels to each step in index order.
    [<CustomOperation("Size")>] member inline _.Size ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Size) = render ==> ("Size" => x)
    /// The variant to use.
    [<CustomOperation("Variant")>] member inline _.Variant ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Variant) = render ==> ("Variant" => x)
    /// Displays the value over the slider thumb.
    [<CustomOperation("ValueLabel")>] member inline _.ValueLabel ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("ValueLabel" => x)

type MudSnackbarElementBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Snackbar")>] member inline _.Snackbar ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Snackbar) = render ==> ("Snackbar" => x)
    /// Custom close icon.
    [<CustomOperation("CloseIcon")>] member inline _.CloseIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("CloseIcon" => x)

type MudSnackbarProviderBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()


type MudStackBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    /// If true, items will be placed horizontally in a row instead of vertically.
    [<CustomOperation("Row")>] member inline _.Row ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("Row" => x)
    /// Reverses the order of its items.
    [<CustomOperation("Reverse")>] member inline _.Reverse ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("Reverse" => x)
    /// Defines the spacing between its items.
    [<CustomOperation("Spacing")>] member inline _.Spacing ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("Spacing" => x)
    /// Defines the spacing between its items.
    [<CustomOperation("Justify")>] member inline _.Justify ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<MudBlazor.Justify>) = render ==> ("Justify" => x)
    /// Defines the spacing between its items.
    [<CustomOperation("AlignItems")>] member inline _.AlignItems ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<MudBlazor.AlignItems>) = render ==> ("AlignItems" => x)

type MudSwipeAreaBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("OnSwipe")>] member inline _.OnSwipe ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("OnSwipe" => (System.Action<MudBlazor.SwipeDirection>fn))
    /// Swipe threshold in pixels. If SwipeDelta is below Sensitivity then OnSwipe is not called.
    [<CustomOperation("Sensitivity")>] member inline _.Sensitivity ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("Sensitivity" => x)
    /// Prevents default behavior of the browser when swiping.
    /// Usable espacially when swiping up/down - this will prevent the whole page from scrolling up/down.
    [<CustomOperation("PreventDefault")>] member inline _.PreventDefault ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("PreventDefault" => x)

type MudTableGroupRowBuilder<'FunBlazorGeneric, 'T when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    /// The group definition for this grouping level. It's recursive.
    [<CustomOperation("GroupDefinition")>] member inline _.GroupDefinition ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.TableGroupDefinition<'T>) = render ==> ("GroupDefinition" => x)
    /// Inner Items List for the Group
    [<CustomOperation("Items")>] member inline _.Items ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Linq.IGrouping<System.Object, 'T>) = render ==> ("Items" => x)
    /// Defines Group Header Data Template
    [<CustomOperation("HeaderTemplate")>] member inline _.HeaderTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fn: MudBlazor.TableGroupData<System.Object, 'T> -> NodeRenderFragment) = render ==> html.renderFragment("HeaderTemplate", fn)
    /// Defines Group Header Data Template
    [<CustomOperation("FooterTemplate")>] member inline _.FooterTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fn: MudBlazor.TableGroupData<System.Object, 'T> -> NodeRenderFragment) = render ==> html.renderFragment("FooterTemplate", fn)
    /// Add a multi-select checkbox that will select/unselect every item in the table
    [<CustomOperation("IsCheckable")>] member inline _.IsCheckable ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("IsCheckable" => x)
    [<CustomOperation("HeaderClass")>] member inline _.HeaderClass ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("HeaderClass" => x)
    [<CustomOperation("FooterClass")>] member inline _.FooterClass ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("FooterClass" => x)
    [<CustomOperation("HeaderStyle")>] member inline _.HeaderStyle ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("HeaderStyle" => x)
    [<CustomOperation("FooterStyle")>] member inline _.FooterStyle ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("FooterStyle" => x)
    /// Custom expand icon.
    [<CustomOperation("ExpandIcon")>] member inline _.ExpandIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("ExpandIcon" => x)
    /// Custom collapse icon.
    [<CustomOperation("CollapseIcon")>] member inline _.CollapseIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("CollapseIcon" => x)
    /// On click event
    [<CustomOperation("OnRowClick")>] member inline _.OnRowClick ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>("OnRowClick", fn)
    /// On click event
    [<CustomOperation("OnRowClick")>] member inline _.OnRowClick ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callbackTask<Microsoft.AspNetCore.Components.Web.MouseEventArgs>("OnRowClick", fn)

type MudTablePagerBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    /// Set true to hide the part of the pager which allows to change the page size.
    [<CustomOperation("HideRowsPerPage")>] member inline _.HideRowsPerPage ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("HideRowsPerPage" => x)
    /// Set true to hide the number of pages.
    [<CustomOperation("HidePageNumber")>] member inline _.HidePageNumber ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("HidePageNumber" => x)
    /// Set true to hide the pagination.
    [<CustomOperation("HidePagination")>] member inline _.HidePagination ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("HidePagination" => x)
    /// Set the horizontal alignment position.
    [<CustomOperation("HorizontalAlignment")>] member inline _.HorizontalAlignment ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.HorizontalAlignment) = render ==> ("HorizontalAlignment" => x)
    /// Define a list of available page size options for the user to choose from
    [<CustomOperation("PageSizeOptions")>] member inline _.PageSizeOptions ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32[]) = render ==> ("PageSizeOptions" => x)
    /// Format string for the display of the current page, which you can localize to your language. Available variables are:
    /// {first_item}, {last_item} and {all_items} which will replaced with the indices of the page's first and last item, as well as the total number of items.
    /// Default: "{first_item}-{last_item} of {all_items}" which is transformed into "0-25 of 77". 
    [<CustomOperation("InfoFormat")>] member inline _.InfoFormat ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("InfoFormat" => x)
    /// Defines the text shown in the items per page dropdown when a user provides int.MaxValue as an option
    [<CustomOperation("AllItemsText")>] member inline _.AllItemsText ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("AllItemsText" => x)
    /// The localizable "Rows per page:" text.
    [<CustomOperation("RowsPerPageString")>] member inline _.RowsPerPageString ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("RowsPerPageString" => x)
    /// Custom first icon.
    [<CustomOperation("FirstIcon")>] member inline _.FirstIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("FirstIcon" => x)
    /// Custom before icon.
    [<CustomOperation("BeforeIcon")>] member inline _.BeforeIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("BeforeIcon" => x)
    /// Custom next icon.
    [<CustomOperation("NextIcon")>] member inline _.NextIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("NextIcon" => x)
    /// Custom last icon.
    [<CustomOperation("LastIcon")>] member inline _.LastIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("LastIcon" => x)

type MudTableSortLabelBuilder<'FunBlazorGeneric, 'T when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("InitialDirection")>] member inline _.InitialDirection ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.SortDirection) = render ==> ("InitialDirection" => x)
    /// Enable the sorting. Set to true by default.
    [<CustomOperation("Enabled")>] member inline _.Enabled ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("Enabled" => x)
    /// The Icon used to display sortdirection.
    [<CustomOperation("SortIcon")>] member inline _.SortIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("SortIcon" => x)
    /// If true the icon will be placed before the label text.
    [<CustomOperation("AppendIcon")>] member inline _.AppendIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("AppendIcon" => x)
    [<CustomOperation("SortDirection")>] member inline _.SortDirection ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.SortDirection) = render ==> ("SortDirection" => x)
    [<CustomOperation("SortDirection'")>] member inline _.SortDirection' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: MudBlazor.SortDirection * (MudBlazor.SortDirection -> unit)) = render ==> html.bind("SortDirection", valueFn)
    [<CustomOperation("SortDirectionChanged")>] member inline _.SortDirectionChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callback<MudBlazor.SortDirection>("SortDirectionChanged", fn)
    [<CustomOperation("SortDirectionChanged")>] member inline _.SortDirectionChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callbackTask<MudBlazor.SortDirection>("SortDirectionChanged", fn)
    [<CustomOperation("SortBy")>] member inline _.SortBy ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("SortBy" => (System.Func<'T, System.Object>fn))
    [<CustomOperation("SortLabel")>] member inline _.SortLabel ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("SortLabel" => x)

type MudTdBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("DataLabel")>] member inline _.DataLabel ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("DataLabel" => x)
    /// Hide cell when breakpoint is smaller than the defined value in table.
    [<CustomOperation("HideSmall")>] member inline _.HideSmall ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("HideSmall" => x)

type MudTFootRowBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    /// Add a multi-select checkbox that will select/unselect every item in the table
    [<CustomOperation("IsCheckable")>] member inline _.IsCheckable ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("IsCheckable" => x)
    /// Specify behavior in case the table is multi-select mode. If set to true, it won't render an additional empty column.
    [<CustomOperation("IgnoreCheckbox")>] member inline _.IgnoreCheckbox ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("IgnoreCheckbox" => x)
    /// Specify behavior in case the table is editable. If set to true, it won't render an additional empty column.
    [<CustomOperation("IgnoreEditable")>] member inline _.IgnoreEditable ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("IgnoreEditable" => x)
    [<CustomOperation("IsExpandable")>] member inline _.IsExpandable ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("IsExpandable" => x)
    /// On click event
    [<CustomOperation("OnRowClick")>] member inline _.OnRowClick ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>("OnRowClick", fn)
    /// On click event
    [<CustomOperation("OnRowClick")>] member inline _.OnRowClick ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callbackTask<Microsoft.AspNetCore.Components.Web.MouseEventArgs>("OnRowClick", fn)

type MudThBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()


type MudTHeadRowBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    /// Add a multi-select checkbox that will select/unselect every item in the table
    [<CustomOperation("IsCheckable")>] member inline _.IsCheckable ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("IsCheckable" => x)
    /// Specify behavior in case the table is multi-select mode. If set to true, it won't render an additional empty column.
    [<CustomOperation("IgnoreCheckbox")>] member inline _.IgnoreCheckbox ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("IgnoreCheckbox" => x)
    /// Specify behavior in case the table is editable. If set to true, it won't render an additional empty column.
    [<CustomOperation("IgnoreEditable")>] member inline _.IgnoreEditable ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("IgnoreEditable" => x)
    [<CustomOperation("IsExpandable")>] member inline _.IsExpandable ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("IsExpandable" => x)
    /// On click event
    [<CustomOperation("OnRowClick")>] member inline _.OnRowClick ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>("OnRowClick", fn)
    /// On click event
    [<CustomOperation("OnRowClick")>] member inline _.OnRowClick ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callbackTask<Microsoft.AspNetCore.Components.Web.MouseEventArgs>("OnRowClick", fn)

type MudTrBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Item")>] member inline _.Item ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Object) = render ==> ("Item" => x)
    [<CustomOperation("IsCheckable")>] member inline _.IsCheckable ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("IsCheckable" => x)
    [<CustomOperation("IsEditable")>] member inline _.IsEditable ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("IsEditable" => x)
    [<CustomOperation("IsEditing")>] member inline _.IsEditing ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("IsEditing" => x)
    [<CustomOperation("IsEditSwitchBlocked")>] member inline _.IsEditSwitchBlocked ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("IsEditSwitchBlocked" => x)
    [<CustomOperation("IsExpandable")>] member inline _.IsExpandable ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("IsExpandable" => x)
    [<CustomOperation("IsCheckedChanged")>] member inline _.IsCheckedChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callback<System.Boolean>("IsCheckedChanged", fn)
    [<CustomOperation("IsCheckedChanged")>] member inline _.IsCheckedChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callbackTask<System.Boolean>("IsCheckedChanged", fn)
    [<CustomOperation("IsChecked")>] member inline _.IsChecked ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("IsChecked" => x)
    [<CustomOperation("IsChecked'")>] member inline _.IsChecked' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.Boolean * (System.Boolean -> unit)) = render ==> html.bind("IsChecked", valueFn)

type MudSimpleTableBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    /// Child content of component.
    [<CustomOperation("Elevation")>] member inline _.Elevation ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("Elevation" => x)
    /// If true, the table row will shade on hover.
    [<CustomOperation("Hover")>] member inline _.Hover ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("Hover" => x)
    /// If true, border-radius is set to 0.
    [<CustomOperation("Square")>] member inline _.Square ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("Square" => x)
    /// If true, compact padding will be used.
    [<CustomOperation("Dense")>] member inline _.Dense ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("Dense" => x)
    /// If true, table will be outlined.
    [<CustomOperation("Outlined")>] member inline _.Outlined ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("Outlined" => x)
    /// If true, table's cells will have left/right borders.
    [<CustomOperation("Bordered")>] member inline _.Bordered ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("Bordered" => x)
    /// If true, striped table rows will be used.
    [<CustomOperation("Striped")>] member inline _.Striped ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("Striped" => x)
    /// When true, the header will stay in place when the table is scrolled. Note: set Height to make the table scrollable.
    [<CustomOperation("FixedHeader")>] member inline _.FixedHeader ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("FixedHeader" => x)

type MudTimelineItemBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    /// Dot Icon
    [<CustomOperation("Icon")>] member inline _.Icon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Icon" => x)
    /// Variant of the dot.
    [<CustomOperation("Variant")>] member inline _.Variant ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Variant) = render ==> ("Variant" => x)
    /// User styles, applied to the lineItem dot.
    [<CustomOperation("DotStyle")>] member inline _.DotStyle ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("DotStyle" => x)
    /// Color of the dot.
    [<CustomOperation("Color")>] member inline _.Color ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("Color" => x)
    /// Size of the dot.
    [<CustomOperation("Size")>] member inline _.Size ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Size) = render ==> ("Size" => x)
    /// Elevation of the dot. The higher the number, the heavier the drop-shadow.
    [<CustomOperation("Elevation")>] member inline _.Elevation ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("Elevation" => x)
    /// Overrides Timeline Parents default sorting method in Default and Reverse mode.
    [<CustomOperation("TimelineAlign")>] member inline _.TimelineAlign ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.TimelineAlign) = render ==> ("TimelineAlign" => x)
    /// If true, dot will not be displayed.
    [<CustomOperation("HideDot")>] member inline _.HideDot ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("HideDot" => x)
    /// If used renders child content of the ItemOpposite.
    [<CustomOperation("ItemOpposite")>] member inline _.ItemOpposite ([<InlineIfLambda>] render: AttrRenderFragment, fragment) = render ==> html.renderFragment("ItemOpposite", fragment)
    /// If used renders child content of the ItemOpposite.
    [<CustomOperation("ItemOpposite")>] member inline _.ItemOpposite ([<InlineIfLambda>] render: AttrRenderFragment, fragments) = render ==> html.renderFragment("ItemOpposite", fragment { yield! fragments })
    /// If used renders child content of the ItemOpposite.
    [<CustomOperation("ItemOpposite")>] member inline _.ItemOpposite ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("ItemOpposite", html.text x)
    /// If used renders child content of the ItemOpposite.
    [<CustomOperation("ItemOpposite")>] member inline _.ItemOpposite ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("ItemOpposite", html.text x)
    /// If used renders child content of the ItemOpposite.
    [<CustomOperation("ItemOpposite")>] member inline _.ItemOpposite ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("ItemOpposite", html.text x)
    /// If used renders child content of the ItemContent.
    [<CustomOperation("ItemContent")>] member inline _.ItemContent ([<InlineIfLambda>] render: AttrRenderFragment, fragment) = render ==> html.renderFragment("ItemContent", fragment)
    /// If used renders child content of the ItemContent.
    [<CustomOperation("ItemContent")>] member inline _.ItemContent ([<InlineIfLambda>] render: AttrRenderFragment, fragments) = render ==> html.renderFragment("ItemContent", fragment { yield! fragments })
    /// If used renders child content of the ItemContent.
    [<CustomOperation("ItemContent")>] member inline _.ItemContent ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("ItemContent", html.text x)
    /// If used renders child content of the ItemContent.
    [<CustomOperation("ItemContent")>] member inline _.ItemContent ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("ItemContent", html.text x)
    /// If used renders child content of the ItemContent.
    [<CustomOperation("ItemContent")>] member inline _.ItemContent ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("ItemContent", html.text x)
    /// If used renders child content of the ItemDot.
    [<CustomOperation("ItemDot")>] member inline _.ItemDot ([<InlineIfLambda>] render: AttrRenderFragment, fragment) = render ==> html.renderFragment("ItemDot", fragment)
    /// If used renders child content of the ItemDot.
    [<CustomOperation("ItemDot")>] member inline _.ItemDot ([<InlineIfLambda>] render: AttrRenderFragment, fragments) = render ==> html.renderFragment("ItemDot", fragment { yield! fragments })
    /// If used renders child content of the ItemDot.
    [<CustomOperation("ItemDot")>] member inline _.ItemDot ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("ItemDot", html.text x)
    /// If used renders child content of the ItemDot.
    [<CustomOperation("ItemDot")>] member inline _.ItemDot ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("ItemDot", html.text x)
    /// If used renders child content of the ItemDot.
    [<CustomOperation("ItemDot")>] member inline _.ItemDot ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("ItemDot", html.text x)

type MudTooltipBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    /// The color of the component. It supports the theme colors.
    [<CustomOperation("Color")>] member inline _.Color ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("Color" => x)
    /// Sets the text to be displayed inside the tooltip.
    [<CustomOperation("Text")>] member inline _.Text ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Text" => x)
    /// If true, a arrow will be displayed pointing towards the content from the tooltip.
    [<CustomOperation("Arrow")>] member inline _.Arrow ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("Arrow" => x)
    /// Sets the length of time that the opening transition takes to complete.
    [<CustomOperation("Duration")>] member inline _.Duration ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Double) = render ==> ("Duration" => x)
    /// Sets the amount of time in milliseconds to wait from opening the popover before beginning to perform the transition. 
    [<CustomOperation("Delay'")>] member inline _.Delay' ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Double) = render ==> ("Delay" => x)
    /// Tooltip placement.
    [<CustomOperation("Placement")>] member inline _.Placement ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Placement) = render ==> ("Placement" => x)
    /// Tooltip content. May contain any valid html
    [<CustomOperation("TooltipContent")>] member inline _.TooltipContent ([<InlineIfLambda>] render: AttrRenderFragment, fragment) = render ==> html.renderFragment("TooltipContent", fragment)
    /// Tooltip content. May contain any valid html
    [<CustomOperation("TooltipContent")>] member inline _.TooltipContent ([<InlineIfLambda>] render: AttrRenderFragment, fragments) = render ==> html.renderFragment("TooltipContent", fragment { yield! fragments })
    /// Tooltip content. May contain any valid html
    [<CustomOperation("TooltipContent")>] member inline _.TooltipContent ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("TooltipContent", html.text x)
    /// Tooltip content. May contain any valid html
    [<CustomOperation("TooltipContent")>] member inline _.TooltipContent ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("TooltipContent", html.text x)
    /// Tooltip content. May contain any valid html
    [<CustomOperation("TooltipContent")>] member inline _.TooltipContent ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("TooltipContent", html.text x)
    /// Determines if this component should be inline with it's surrounding (default) or if it should behave like a block element.
    [<CustomOperation("Inline")>] member inline _.Inline ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("Inline" => x)
    /// Styles applied directly to root component of the tooltip
    [<CustomOperation("RootStyle")>] member inline _.RootStyle ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("RootStyle" => x)
    [<CustomOperation("RootClass")>] member inline _.RootClass ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("RootClass" => x)
    /// Determines on which events the tooltip will act
    [<CustomOperation("ShowOnHover")>] member inline _.ShowOnHover ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("ShowOnHover" => x)
    /// Determines on which events the tooltip will act
    [<CustomOperation("ShowOnFocus")>] member inline _.ShowOnFocus ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("ShowOnFocus" => x)
    [<CustomOperation("ShowOnClick")>] member inline _.ShowOnClick ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("ShowOnClick" => x)
    /// The visible state of the Tooltip.
    [<CustomOperation("IsVisible")>] member inline _.IsVisible ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("IsVisible" => x)
    /// The visible state of the Tooltip.
    [<CustomOperation("IsVisible'")>] member inline _.IsVisible' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.Boolean * (System.Boolean -> unit)) = render ==> html.bind("IsVisible", valueFn)
    /// An event triggered when the state of IsVisible has changed
    [<CustomOperation("IsVisibleChanged")>] member inline _.IsVisibleChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callback<System.Boolean>("IsVisibleChanged", fn)
    /// An event triggered when the state of IsVisible has changed
    [<CustomOperation("IsVisibleChanged")>] member inline _.IsVisibleChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callbackTask<System.Boolean>("IsVisibleChanged", fn)

type MudTreeViewBuilder<'FunBlazorGeneric, 'T when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    /// The color of the selected treeviewitem.
    [<CustomOperation("Color")>] member inline _.Color ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("Color" => x)
    /// Check box color if multiselection is used.
    [<CustomOperation("CheckBoxColor")>] member inline _.CheckBoxColor ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("CheckBoxColor" => x)
    /// if true, multiple values can be selected via checkboxes which are automatically shown in the tree view.
    [<CustomOperation("MultiSelection")>] member inline _.MultiSelection ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("MultiSelection" => x)
    /// If true, clicking anywhere on the item will expand it, if it has childs.
    [<CustomOperation("ExpandOnClick")>] member inline _.ExpandOnClick ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("ExpandOnClick" => x)
    /// If true, double clicking anywhere on the item will expand it, if it has childs.
    [<CustomOperation("ExpandOnDoubleClick")>] member inline _.ExpandOnDoubleClick ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("ExpandOnDoubleClick" => x)
    /// Hover effect for item's on mouse-over.
    [<CustomOperation("Hover")>] member inline _.Hover ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("Hover" => x)
    /// If true, compact vertical padding will be applied to all treeview items.
    [<CustomOperation("Dense")>] member inline _.Dense ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("Dense" => x)
    /// Setting a height will allow to scroll the treeview. If not set, it will try to grow in height. 
    /// You can set this to any CSS value that the attribute 'height' accepts, i.e. 500px. 
    [<CustomOperation("Height")>] member inline _.Height ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Height" => x)
    /// Setting a maximum height will allow to scroll the treeview. If not set, it will try to grow in height. 
    /// You can set this to any CSS value that the attribute 'height' accepts, i.e. 500px. 
    [<CustomOperation("MaxHeight")>] member inline _.MaxHeight ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("MaxHeight" => x)
    /// Setting a width the treeview. You can set this to any CSS value that the attribute 'height' accepts, i.e. 500px. 
    [<CustomOperation("Width")>] member inline _.Width ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Width" => x)
    /// If true, treeview will be disabled and all its childitems.
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("Disabled" => x)
    [<CustomOperation("Items")>] member inline _.Items ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.HashSet<'T>) = render ==> ("Items" => x)
    /// Called whenever the selected value changed.
    [<CustomOperation("SelectedValueChanged")>] member inline _.SelectedValueChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callback<'T>("SelectedValueChanged", fn)
    /// Called whenever the selected value changed.
    [<CustomOperation("SelectedValueChanged")>] member inline _.SelectedValueChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callbackTask<'T>("SelectedValueChanged", fn)
    /// Called whenever the selectedvalues changed.
    [<CustomOperation("SelectedValuesChanged")>] member inline _.SelectedValuesChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callback<System.Collections.Generic.HashSet<'T>>("SelectedValuesChanged", fn)
    /// Called whenever the selectedvalues changed.
    [<CustomOperation("SelectedValuesChanged")>] member inline _.SelectedValuesChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callbackTask<System.Collections.Generic.HashSet<'T>>("SelectedValuesChanged", fn)
    /// ItemTemplate for rendering children.
    [<CustomOperation("ItemTemplate")>] member inline _.ItemTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fn: 'T -> NodeRenderFragment) = render ==> html.renderFragment("ItemTemplate", fn)
    [<CustomOperation("ServerData")>] member inline _.ServerData ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("ServerData" => (System.Func<'T, System.Threading.Tasks.Task<System.Collections.Generic.HashSet<'T>>>fn))

type MudTreeViewItemBuilder<'FunBlazorGeneric, 'T when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    /// Custom checked icon, leave null for default.
    [<CustomOperation("CheckedIcon")>] member inline _.CheckedIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("CheckedIcon" => x)
    /// Custom unchecked icon, leave null for default.
    [<CustomOperation("UncheckedIcon")>] member inline _.UncheckedIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("UncheckedIcon" => x)
    /// Value of the treeviewitem. Acts as the displayed text if no text is set.
    [<CustomOperation("Value")>] member inline _.Value ([<InlineIfLambda>] render: AttrRenderFragment, x: 'T) = render ==> ("Value" => x)
    [<CustomOperation("Culture")>] member inline _.Culture ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Globalization.CultureInfo) = render ==> ("Culture" => x)
    /// The text to display
    [<CustomOperation("Text")>] member inline _.Text ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Text" => x)
    /// Tyopography for the text.
    [<CustomOperation("TextTypo")>] member inline _.TextTypo ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Typo) = render ==> ("TextTypo" => x)
    /// User class names for the text, separated by space.
    [<CustomOperation("TextClass")>] member inline _.TextClass ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("TextClass" => x)
    /// The text at the end of the item.
    [<CustomOperation("EndText")>] member inline _.EndText ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("EndText" => x)
    /// Tyopography for the endtext.
    [<CustomOperation("EndTextTypo")>] member inline _.EndTextTypo ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Typo) = render ==> ("EndTextTypo" => x)
    /// User class names for the endtext, separated by space.
    [<CustomOperation("EndTextClass")>] member inline _.EndTextClass ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("EndTextClass" => x)
    /// If true, treeviewitem will be disabled.
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("Disabled" => x)
    /// If false, TreeViewItem will not be able to expand.
    [<CustomOperation("CanExpand")>] member inline _.CanExpand ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("CanExpand" => x)
    /// Content of the item, if used completly replaced the default rendering.
    [<CustomOperation("Content")>] member inline _.Content ([<InlineIfLambda>] render: AttrRenderFragment, fragment) = render ==> html.renderFragment("Content", fragment)
    /// Content of the item, if used completly replaced the default rendering.
    [<CustomOperation("Content")>] member inline _.Content ([<InlineIfLambda>] render: AttrRenderFragment, fragments) = render ==> html.renderFragment("Content", fragment { yield! fragments })
    /// Content of the item, if used completly replaced the default rendering.
    [<CustomOperation("Content")>] member inline _.Content ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("Content", html.text x)
    /// Content of the item, if used completly replaced the default rendering.
    [<CustomOperation("Content")>] member inline _.Content ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("Content", html.text x)
    /// Content of the item, if used completly replaced the default rendering.
    [<CustomOperation("Content")>] member inline _.Content ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("Content", html.text x)
    [<CustomOperation("Items")>] member inline _.Items ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.HashSet<'T>) = render ==> ("Items" => x)
    /// Command executed when the user clicks on the CommitEdit Button.
    [<CustomOperation("Command")>] member inline _.Command ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Windows.Input.ICommand) = render ==> ("Command" => x)
    /// Expand or collapse treeview item when it has children. Two-way bindable. Note: if you directly set this to
    /// true or false (instead of using two-way binding) it will force the item's expansion state.
    [<CustomOperation("Expanded")>] member inline _.Expanded ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("Expanded" => x)
    /// Expand or collapse treeview item when it has children. Two-way bindable. Note: if you directly set this to
    /// true or false (instead of using two-way binding) it will force the item's expansion state.
    [<CustomOperation("Expanded'")>] member inline _.Expanded' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.Boolean * (System.Boolean -> unit)) = render ==> html.bind("Expanded", valueFn)
    /// Called whenever expanded changed.
    [<CustomOperation("ExpandedChanged")>] member inline _.ExpandedChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callback<System.Boolean>("ExpandedChanged", fn)
    /// Called whenever expanded changed.
    [<CustomOperation("ExpandedChanged")>] member inline _.ExpandedChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callbackTask<System.Boolean>("ExpandedChanged", fn)
    [<CustomOperation("Activated")>] member inline _.Activated ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("Activated" => x)
    [<CustomOperation("Activated'")>] member inline _.Activated' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.Boolean * (System.Boolean -> unit)) = render ==> html.bind("Activated", valueFn)
    [<CustomOperation("Selected")>] member inline _.Selected ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("Selected" => x)
    [<CustomOperation("Selected'")>] member inline _.Selected' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.Boolean * (System.Boolean -> unit)) = render ==> html.bind("Selected", valueFn)
    /// Icon placed before the text if set.
    [<CustomOperation("Icon")>] member inline _.Icon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Icon" => x)
    /// The color of the icon. It supports the theme colors.
    [<CustomOperation("IconColor")>] member inline _.IconColor ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("IconColor" => x)
    /// Icon placed after the text if set.
    [<CustomOperation("EndIcon")>] member inline _.EndIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("EndIcon" => x)
    /// The color of the icon. It supports the theme colors.
    [<CustomOperation("EndIconColor")>] member inline _.EndIconColor ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("EndIconColor" => x)
    /// The expand/collapse icon.
    [<CustomOperation("ExpandedIcon")>] member inline _.ExpandedIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("ExpandedIcon" => x)
    /// The color of the expand/collapse button. It supports the theme colors.
    [<CustomOperation("ExpandedIconColor")>] member inline _.ExpandedIconColor ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("ExpandedIconColor" => x)
    /// The loading icon.
    [<CustomOperation("LoadingIcon")>] member inline _.LoadingIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("LoadingIcon" => x)
    /// The color of the loading. It supports the theme colors.
    [<CustomOperation("LoadingIconColor")>] member inline _.LoadingIconColor ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("LoadingIconColor" => x)
    /// Called whenever the activated value changed.
    [<CustomOperation("ActivatedChanged")>] member inline _.ActivatedChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callback<System.Boolean>("ActivatedChanged", fn)
    /// Called whenever the activated value changed.
    [<CustomOperation("ActivatedChanged")>] member inline _.ActivatedChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callbackTask<System.Boolean>("ActivatedChanged", fn)
    /// Called whenever the selected value changed.
    [<CustomOperation("SelectedChanged")>] member inline _.SelectedChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callback<System.Boolean>("SelectedChanged", fn)
    /// Called whenever the selected value changed.
    [<CustomOperation("SelectedChanged")>] member inline _.SelectedChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callbackTask<System.Boolean>("SelectedChanged", fn)
    /// Tree item click event.
    [<CustomOperation("OnClick")>] member inline _.OnClick ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>("OnClick", fn)
    /// Tree item click event.
    [<CustomOperation("OnClick")>] member inline _.OnClick ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callbackTask<Microsoft.AspNetCore.Components.Web.MouseEventArgs>("OnClick", fn)
    /// Tree item double click event.
    [<CustomOperation("OnDoubleClick")>] member inline _.OnDoubleClick ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>("OnDoubleClick", fn)
    /// Tree item double click event.
    [<CustomOperation("OnDoubleClick")>] member inline _.OnDoubleClick ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callbackTask<Microsoft.AspNetCore.Components.Web.MouseEventArgs>("OnDoubleClick", fn)

type MudTextBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    /// Applies the theme typography styles.
    [<CustomOperation("Typo")>] member inline _.Typo ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Typo) = render ==> ("Typo" => x)
    /// Set the text-align on the component.
    [<CustomOperation("Align")>] member inline _.Align ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Align) = render ==> ("Align" => x)
    /// The color of the component. It supports the theme colors.
    [<CustomOperation("Color")>] member inline _.Color ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("Color" => x)
    /// If true, the text will have a bottom margin.
    [<CustomOperation("GutterBottom")>] member inline _.GutterBottom ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("GutterBottom" => x)
    /// If true, Sets display inline
    [<CustomOperation("Inline")>] member inline _.Inline ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("Inline" => x)

type MudContainerBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    /// Set the max-width to match the min-width of the current breakpoint. This is useful if you'd prefer to design for a fixed set of sizes instead of trying to accommodate a fully fluid viewport. It's fluid by default.
    [<CustomOperation("Fixed")>] member inline _.Fixed ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("Fixed" => x)
    /// Determine the max-width of the container. The container width grows with the size of the screen. Set to false to disable maxWidth.
    [<CustomOperation("MaxWidth")>] member inline _.MaxWidth ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.MaxWidth) = render ==> ("MaxWidth" => x)

type HierarchyColumnBuilder<'FunBlazorGeneric, 'T when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("ClosedIcon")>] member inline _.ClosedIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("ClosedIcon" => x)
    [<CustomOperation("OpenIcon")>] member inline _.OpenIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("OpenIcon" => x)
    [<CustomOperation("IconSize")>] member inline _.IconSize ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Size) = render ==> ("IconSize" => x)
    [<CustomOperation("ButtonDisabledFunc")>] member inline _.ButtonDisabledFunc ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("ButtonDisabledFunc" => (System.Func<'T, System.Boolean>fn))

type MudDividerBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    /// Sets absolute position to the component.
    [<CustomOperation("Absolute")>] member inline _.Absolute ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("Absolute" => x)
    /// If true, a vertical divider will have the correct height when used in flex container.
    [<CustomOperation("FlexItem")>] member inline _.FlexItem ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("FlexItem" => x)
    /// If true, the divider will have a lighter color.
    [<CustomOperation("Light")>] member inline _.Light ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("Light" => x)
    /// If true, the divider is displayed vertically.
    [<CustomOperation("Vertical")>] member inline _.Vertical ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("Vertical" => x)
    /// The Divider type to use.
    [<CustomOperation("DividerType")>] member inline _.DividerType ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.DividerType) = render ==> ("DividerType" => x)

type MudDrawerHeaderBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    /// If true, compact padding will be used, same as the Appbar.
    [<CustomOperation("Dense")>] member inline _.Dense ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("Dense" => x)
    /// If true, the component will link to index page with an a element instead of div.
    [<CustomOperation("LinkToIndex")>] member inline _.LinkToIndex ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("LinkToIndex" => x)

type MudGridBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Spacing")>] member inline _.Spacing ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("Spacing" => x)
    [<CustomOperation("Justify")>] member inline _.Justify ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Justify) = render ==> ("Justify" => x)

type MudItemBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("xs")>] member inline _.xs ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("xs" => x)
    [<CustomOperation("sm")>] member inline _.sm ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("sm" => x)
    [<CustomOperation("md")>] member inline _.md ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("md" => x)
    [<CustomOperation("lg")>] member inline _.lg ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("lg" => x)
    [<CustomOperation("xl")>] member inline _.xl ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("xl" => x)
    [<CustomOperation("xxl")>] member inline _.xxl ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("xxl" => x)

type MudMainContentBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()


type MudSparkLineBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("StrokeWidth")>] member inline _.StrokeWidth ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("StrokeWidth" => x)

type MudTabPanelBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    /// Text will be displayed in the TabPanel as TabTitle.
    [<CustomOperation("Text")>] member inline _.Text ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Text" => x)
    /// Icon placed before the text if set.
    [<CustomOperation("Icon")>] member inline _.Icon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Icon" => x)
    /// If true, the tabpanel will be disabled.
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("Disabled" => x)
    /// MudDynamicTabs: If true, shows the close icon in the TabPanel.
    [<CustomOperation("ShowCloseIcon")>] member inline _.ShowCloseIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("ShowCloseIcon" => x)
    /// Optional information to be showed into a badge
    [<CustomOperation("BadgeData")>] member inline _.BadgeData ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Object) = render ==> ("BadgeData" => x)
    /// Optional information to show the badge as a dot.
    [<CustomOperation("BadgeDot")>] member inline _.BadgeDot ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("BadgeDot" => x)
    /// The color of the badge.
    [<CustomOperation("BadgeColor")>] member inline _.BadgeColor ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("BadgeColor" => x)
    /// Unique TabPanel ID. Useful for activation when Panels are dynamically generated.
    [<CustomOperation("ID")>] member inline _.ID ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Object) = render ==> ("ID" => x)
    /// Raised when tab is clicked
    [<CustomOperation("OnClick")>] member inline _.OnClick ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>("OnClick", fn)
    /// Raised when tab is clicked
    [<CustomOperation("OnClick")>] member inline _.OnClick ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callbackTask<Microsoft.AspNetCore.Components.Web.MouseEventArgs>("OnClick", fn)
    /// Tab content of component.
    [<CustomOperation("TabContent")>] member inline _.TabContent ([<InlineIfLambda>] render: AttrRenderFragment, fragment) = render ==> html.renderFragment("TabContent", fragment)
    /// Tab content of component.
    [<CustomOperation("TabContent")>] member inline _.TabContent ([<InlineIfLambda>] render: AttrRenderFragment, fragments) = render ==> html.renderFragment("TabContent", fragment { yield! fragments })
    /// Tab content of component.
    [<CustomOperation("TabContent")>] member inline _.TabContent ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("TabContent", html.text x)
    /// Tab content of component.
    [<CustomOperation("TabContent")>] member inline _.TabContent ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("TabContent", html.text x)
    /// Tab content of component.
    [<CustomOperation("TabContent")>] member inline _.TabContent ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("TabContent", html.text x)
    /// Tab content wrapper of component. It is used to wrap the content of a tab heading in a user supplied div or component. 
    /// Use @context in the TabWrapperContent to render the tab header within your custom wrapper. 
    /// This is most useful with tooltips, which must wrap the entire content they refer to.
    [<CustomOperation("TabWrapperContent")>] member inline _.TabWrapperContent ([<InlineIfLambda>] render: AttrRenderFragment, fn: Microsoft.AspNetCore.Components.RenderFragment -> NodeRenderFragment) = render ==> html.renderFragment("TabWrapperContent", fn)
    /// TabPanel Tooltip. It will be ignored if TabContent is provided.
    [<CustomOperation("ToolTip")>] member inline _.ToolTip ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("ToolTip" => x)

type MudToolBarBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    /// If true, compact padding will be used.
    [<CustomOperation("Dense")>] member inline _.Dense ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("Dense" => x)
    /// If true, disables gutter padding.
    [<CustomOperation("DisableGutters")>] member inline _.DisableGutters ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("DisableGutters" => x)

type MudBaseColumnBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAndChildAttrBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Visible")>] member inline _.Visible ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("Visible" => x)
    [<CustomOperation("HeaderText")>] member inline _.HeaderText ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("HeaderText" => x)

/// Binds an object's property to a column by its property name 
type MudColumnBuilder<'FunBlazorGeneric, 'T when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudBaseColumnBuilder<'FunBlazorGeneric>()
    /// Specifies the name of the object's property bound to the column
    [<CustomOperation("Value")>] member inline _.Value ([<InlineIfLambda>] render: AttrRenderFragment, x: 'T) = render ==> ("Value" => x)
    /// Specifies the name of the object's property bound to the column
    [<CustomOperation("Value'")>] member inline _.Value' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: 'T * ('T -> unit)) = render ==> html.bind("Value", valueFn)
    [<CustomOperation("ValueChanged")>] member inline _.ValueChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callback<'T>("ValueChanged", fn)
    [<CustomOperation("ValueChanged")>] member inline _.ValueChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callbackTask<'T>("ValueChanged", fn)
    [<CustomOperation("FooterValue")>] member inline _.FooterValue ([<InlineIfLambda>] render: AttrRenderFragment, x: 'T) = render ==> ("FooterValue" => x)
    /// Used if no FooterValue is available
    [<CustomOperation("FooterText")>] member inline _.FooterText ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("FooterText" => x)
    /// Specifies which string format should be used.
    [<CustomOperation("DataFormatString")>] member inline _.DataFormatString ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("DataFormatString" => x)
    [<CustomOperation("ReadOnly")>] member inline _.ReadOnly ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("ReadOnly" => x)

/// Binds an object's property to a column by its property name 
type MudSortableColumnBuilder<'FunBlazorGeneric, 'T, 'ModelType when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudBaseColumnBuilder<'FunBlazorGeneric>()
    /// Specifies the name of the object's property bound to the column
    [<CustomOperation("Value")>] member inline _.Value ([<InlineIfLambda>] render: AttrRenderFragment, x: 'T) = render ==> ("Value" => x)
    /// Specifies the name of the object's property bound to the column
    [<CustomOperation("Value'")>] member inline _.Value' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: 'T * ('T -> unit)) = render ==> html.bind("Value", valueFn)
    [<CustomOperation("ValueChanged")>] member inline _.ValueChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callback<'T>("ValueChanged", fn)
    [<CustomOperation("ValueChanged")>] member inline _.ValueChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callbackTask<'T>("ValueChanged", fn)
    /// Specifies the name of the object's property bound to the footer
    [<CustomOperation("FooterValue")>] member inline _.FooterValue ([<InlineIfLambda>] render: AttrRenderFragment, x: 'T) = render ==> ("FooterValue" => x)
    /// Used if no FooterValue is available
    [<CustomOperation("FooterText")>] member inline _.FooterText ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("FooterText" => x)
    /// Specifies which string format should be used.
    [<CustomOperation("DataFormatString")>] member inline _.DataFormatString ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("DataFormatString" => x)
    /// Specifies if the column should be readonly even if the DataTable is in editmode.
    [<CustomOperation("ReadOnly")>] member inline _.ReadOnly ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("ReadOnly" => x)
    [<CustomOperation("SortLabel")>] member inline _.SortLabel ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("SortLabel" => x)
    [<CustomOperation("SortBy")>] member inline _.SortBy ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("SortBy" => (System.Func<'ModelType, System.Object>fn))

type MudAvatarColumnBuilder<'FunBlazorGeneric, 'T when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudBaseColumnBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Value")>] member inline _.Value ([<InlineIfLambda>] render: AttrRenderFragment, x: 'T) = render ==> ("Value" => x)

type MudTemplateColumnBuilder<'FunBlazorGeneric, 'T when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudBaseColumnBuilder<'FunBlazorGeneric>()
    [<CustomOperation("DataContext")>] member inline _.DataContext ([<InlineIfLambda>] render: AttrRenderFragment, x: 'T) = render ==> ("DataContext" => x)
    [<CustomOperation("Header")>] member inline _.Header ([<InlineIfLambda>] render: AttrRenderFragment, fn: 'T -> NodeRenderFragment) = render ==> html.renderFragment("Header", fn)
    [<CustomOperation("Row")>] member inline _.Row ([<InlineIfLambda>] render: AttrRenderFragment, fn: 'T -> NodeRenderFragment) = render ==> html.renderFragment("Row", fn)
    [<CustomOperation("Edit")>] member inline _.Edit ([<InlineIfLambda>] render: AttrRenderFragment, fn: 'T -> NodeRenderFragment) = render ==> html.renderFragment("Edit", fn)
    [<CustomOperation("Footer")>] member inline _.Footer ([<InlineIfLambda>] render: AttrRenderFragment, fn: 'T -> NodeRenderFragment) = render ==> html.renderFragment("Footer", fn)

type BaseMudThemeProviderBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAndChildAttrBuilder<'FunBlazorGeneric>()
    /// The theme used by the application.
    [<CustomOperation("Theme")>] member inline _.Theme ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.MudTheme) = render ==> ("Theme" => x)
    /// If true, will not apply MudBlazor styled scrollbar and use browser default. 
    ///             
    [<CustomOperation("DefaultScrollbar")>] member inline _.DefaultScrollbar ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("DefaultScrollbar" => x)
    /// The active palette of the theme.
    [<CustomOperation("IsDarkMode")>] member inline _.IsDarkMode ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("IsDarkMode" => x)
    /// The active palette of the theme.
    [<CustomOperation("IsDarkMode'")>] member inline _.IsDarkMode' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.Boolean * (System.Boolean -> unit)) = render ==> html.bind("IsDarkMode", valueFn)
    /// Invoked when the dark mode changes.
    [<CustomOperation("IsDarkModeChanged")>] member inline _.IsDarkModeChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callback<System.Boolean>("IsDarkModeChanged", fn)
    /// Invoked when the dark mode changes.
    [<CustomOperation("IsDarkModeChanged")>] member inline _.IsDarkModeChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callbackTask<System.Boolean>("IsDarkModeChanged", fn)

type MudThemeProviderBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit BaseMudThemeProviderBuilder<'FunBlazorGeneric>()


type SelectColumnBuilder<'FunBlazorGeneric, 'T when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAndChildAttrBuilder<'FunBlazorGeneric>()
    [<CustomOperation("ShowInHeader")>] member inline _.ShowInHeader ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("ShowInHeader" => x)
    [<CustomOperation("ShowInFooter")>] member inline _.ShowInFooter ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("ShowInFooter" => x)
    [<CustomOperation("Size")>] member inline _.Size ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Size) = render ==> ("Size" => x)

type MudDialogProviderBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAndChildAttrBuilder<'FunBlazorGeneric>()
    [<CustomOperation("NoHeader")>] member inline _.NoHeader ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Boolean>) = render ==> ("NoHeader" => x)
    [<CustomOperation("CloseButton")>] member inline _.CloseButton ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Boolean>) = render ==> ("CloseButton" => x)
    [<CustomOperation("DisableBackdropClick")>] member inline _.DisableBackdropClick ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Boolean>) = render ==> ("DisableBackdropClick" => x)
    [<CustomOperation("CloseOnEscapeKey")>] member inline _.CloseOnEscapeKey ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Boolean>) = render ==> ("CloseOnEscapeKey" => x)
    [<CustomOperation("FullWidth")>] member inline _.FullWidth ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Boolean>) = render ==> ("FullWidth" => x)
    [<CustomOperation("Position")>] member inline _.Position ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<MudBlazor.DialogPosition>) = render ==> ("Position" => x)
    [<CustomOperation("MaxWidth")>] member inline _.MaxWidth ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<MudBlazor.MaxWidth>) = render ==> ("MaxWidth" => x)

type MudPopoverProviderBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAndChildAttrBuilder<'FunBlazorGeneric>()


type MudVirtualizeBuilder<'FunBlazorGeneric, 'T when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAndChildAttrBuilder<'FunBlazorGeneric>()
    /// Set false to turn off virtualization
    [<CustomOperation("IsEnabled")>] member inline _.IsEnabled ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("IsEnabled" => x)
    /// Gets or sets the item template for the list.
    [<CustomOperation("ChildContent")>] member inline _.ChildContent ([<InlineIfLambda>] render: AttrRenderFragment, fn: 'T -> NodeRenderFragment) = render ==> html.renderFragment("ChildContent", fn)
    /// Gets or sets the fixed item source.
    [<CustomOperation("Items")>] member inline _.Items ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.ICollection<'T>) = render ==> ("Items" => x)
    /// Gets or sets a value that determines how many additional items will be rendered
    /// before and after the visible region. This help to reduce the frequency of rendering
    /// during scrolling. However, higher values mean that more elements will be present
    /// in the page.
    [<CustomOperation("OverscanCount")>] member inline _.OverscanCount ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("OverscanCount" => x)

type BreadcrumbLinkBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAndChildAttrBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Item")>] member inline _.Item ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.BreadcrumbItem) = render ==> ("Item" => x)

type BreadcrumbSeparatorBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAndChildAttrBuilder<'FunBlazorGeneric>()


type MudPickerContentBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAndChildAttrBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Classes")>] member inline _.Classes ([<InlineIfLambda>] render: AttrRenderFragment, x: string list) = render ==> html.classes x

type MudPickerToolbarBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAndChildAttrBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Classes")>] member inline _.Classes ([<InlineIfLambda>] render: AttrRenderFragment, x: string list) = render ==> html.classes x
    [<CustomOperation("Styles")>] member inline _.Styles ([<InlineIfLambda>] render: AttrRenderFragment, x: (string * string) list) = render ==> html.styles x
    [<CustomOperation("DisableToolbar")>] member inline _.DisableToolbar ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("DisableToolbar" => x)
    [<CustomOperation("Orientation")>] member inline _.Orientation ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Orientation) = render ==> ("Orientation" => x)
    [<CustomOperation("Color")>] member inline _.Color ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("Color" => x)

type MudRenderBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAndChildAttrBuilder<'FunBlazorGeneric>()


type MudSpacerBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAndChildAttrBuilder<'FunBlazorGeneric>()


type MudTreeViewItemToggleButtonBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAndChildAttrBuilder<'FunBlazorGeneric>()
    /// If true, displays the button.
    [<CustomOperation("Visible")>] member inline _.Visible ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("Visible" => x)
    /// Determens when to flip the expanded icon.
    [<CustomOperation("Expanded")>] member inline _.Expanded ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("Expanded" => x)
    /// Determens when to flip the expanded icon.
    [<CustomOperation("Expanded'")>] member inline _.Expanded' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.Boolean * (System.Boolean -> unit)) = render ==> html.bind("Expanded", valueFn)
    /// If true, displays the loading icon.
    [<CustomOperation("Loading")>] member inline _.Loading ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("Loading" => x)
    /// Called whenever expanded changed.
    [<CustomOperation("ExpandedChanged")>] member inline _.ExpandedChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callback<System.Boolean>("ExpandedChanged", fn)
    /// Called whenever expanded changed.
    [<CustomOperation("ExpandedChanged")>] member inline _.ExpandedChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callbackTask<System.Boolean>("ExpandedChanged", fn)
    /// The loading icon.
    [<CustomOperation("LoadingIcon")>] member inline _.LoadingIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("LoadingIcon" => x)
    /// The color of the loading. It supports the theme colors.
    [<CustomOperation("LoadingIconColor")>] member inline _.LoadingIconColor ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("LoadingIconColor" => x)
    /// The expand/collapse icon.
    [<CustomOperation("ExpandedIcon")>] member inline _.ExpandedIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("ExpandedIcon" => x)
    /// The color of the expand/collapse. It supports the theme colors.
    [<CustomOperation("ExpandedIconColor")>] member inline _.ExpandedIconColor ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("ExpandedIconColor" => x)

type _ImportsBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAndChildAttrBuilder<'FunBlazorGeneric>()


            
namespace rec MudBlazor.DslInternals.Internal

open FSharp.Data.Adaptive
open Fun.Blazor
open Fun.Blazor.Operators
open MudBlazor.DslInternals

type MudInputAdornmentBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAndChildAttrBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Classes")>] member inline _.Classes ([<InlineIfLambda>] render: AttrRenderFragment, x: string list) = render ==> html.classes x
    [<CustomOperation("Text")>] member inline _.Text ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Text" => x)
    [<CustomOperation("Icon")>] member inline _.Icon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Icon" => x)
    [<CustomOperation("Edge")>] member inline _.Edge ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Edge) = render ==> ("Edge" => x)
    [<CustomOperation("Size")>] member inline _.Size ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Size) = render ==> ("Size" => x)
    [<CustomOperation("Color")>] member inline _.Color ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("Color" => x)
    [<CustomOperation("AriaLabel")>] member inline _.AriaLabel ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("AriaLabel" => x)
    [<CustomOperation("AdornmentClick")>] member inline _.AdornmentClick ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>("AdornmentClick", fn)
    [<CustomOperation("AdornmentClick")>] member inline _.AdornmentClick ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callbackTask<Microsoft.AspNetCore.Components.Web.MouseEventArgs>("AdornmentClick", fn)

            
namespace rec MudBlazor.DslInternals.Components.Snackbar.InternalComponents

open FSharp.Data.Adaptive
open Fun.Blazor
open Fun.Blazor.Operators
open MudBlazor.DslInternals

type SnackbarMessageRenderFragmentBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAndChildAttrBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Message")>] member inline _.Message ([<InlineIfLambda>] render: AttrRenderFragment, fragment) = render ==> html.renderFragment("Message", fragment)
    [<CustomOperation("Message")>] member inline _.Message ([<InlineIfLambda>] render: AttrRenderFragment, fragments) = render ==> html.renderFragment("Message", fragment { yield! fragments })
    [<CustomOperation("Message")>] member inline _.Message ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("Message", html.text x)
    [<CustomOperation("Message")>] member inline _.Message ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("Message", html.text x)
    [<CustomOperation("Message")>] member inline _.Message ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("Message", html.text x)

type SnackbarMessageTextBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAndChildAttrBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Message")>] member inline _.Message ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.AspNetCore.Components.MarkupString) = render ==> ("Message" => x)

            
namespace rec MudBlazor.DslInternals.Charts

open FSharp.Data.Adaptive
open Fun.Blazor
open Fun.Blazor.Operators
open MudBlazor.DslInternals

type FiltersBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAndChildAttrBuilder<'FunBlazorGeneric>()


            

// =======================================================================================================================

namespace MudBlazor

[<AutoOpen>]
module DslCE =
  
    open System.Diagnostics.CodeAnalysis
    open MudBlazor.DslInternals

    type MudComponentBase' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudComponentBase>)>] () = inherit MudComponentBaseBuilder<MudBlazor.MudComponentBase>()
    type MudBaseButton' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudBaseButton>)>] () = inherit MudBaseButtonBuilder<MudBlazor.MudBaseButton>()
    type MudButton' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudButton>)>] () = inherit MudButtonBuilder<MudBlazor.MudButton>()
    type MudFab' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudFab>)>] () = inherit MudFabBuilder<MudBlazor.MudFab>()
    type MudIconButton' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudIconButton>)>] () = inherit MudIconButtonBuilder<MudBlazor.MudIconButton>()
    type MudDrawerContainer' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudDrawerContainer>)>] () = inherit MudDrawerContainerBuilder<MudBlazor.MudDrawerContainer>()
    type MudLayout' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudLayout>)>] () = inherit MudLayoutBuilder<MudBlazor.MudLayout>()
    type MudBaseSelectItem' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudBaseSelectItem>)>] () = inherit MudBaseSelectItemBuilder<MudBlazor.MudBaseSelectItem>()
    type MudNavLink' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudNavLink>)>] () = inherit MudNavLinkBuilder<MudBlazor.MudNavLink>()

    /// Represents an option of a select or multi-select. To be used inside MudSelect.
    type MudSelectItem'<'T> 
        /// Represents an option of a select or multi-select. To be used inside MudSelect.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudSelectItem<_>>)>] () = inherit MudSelectItemBuilder<MudBlazor.MudSelectItem<'T>, 'T>()
    type MudTableBase' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudTableBase>)>] () = inherit MudTableBaseBuilder<MudBlazor.MudTableBase>()
    type MudTable'<'T> [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudTable<_>>)>] () = inherit MudTableBuilder<MudBlazor.MudTable<'T>, 'T>()
    type MudTabs' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudTabs>)>] () = inherit MudTabsBuilder<MudBlazor.MudTabs>()
    type MudDynamicTabs' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudDynamicTabs>)>] () = inherit MudDynamicTabsBuilder<MudBlazor.MudDynamicTabs>()
    type MudChartBase' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudChartBase>)>] () = inherit MudChartBaseBuilder<MudBlazor.MudChartBase>()
    type MudChart' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudChart>)>] () = inherit MudChartBuilder<MudBlazor.MudChart>()
    type MudBaseItemsControl'<'TChildComponent when 'TChildComponent :> MudBlazor.MudComponentBase> [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudBaseItemsControl<_>>)>] () = inherit MudBaseItemsControlBuilder<MudBlazor.MudBaseItemsControl<'TChildComponent>, 'TChildComponent>()
    type MudBaseBindableItemsControl'<'TChildComponent, 'TData when 'TChildComponent :> MudBlazor.MudComponentBase> [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudBaseBindableItemsControl<_, _>>)>] () = inherit MudBaseBindableItemsControlBuilder<MudBlazor.MudBaseBindableItemsControl<'TChildComponent, 'TData>, 'TChildComponent, 'TData>()
    type MudCarousel'<'TData> [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudCarousel<_>>)>] () = inherit MudCarouselBuilder<MudBlazor.MudCarousel<'TData>, 'TData>()
    type MudTimeline' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudTimeline>)>] () = inherit MudTimelineBuilder<MudBlazor.MudTimeline>()
    type MudFormComponent'<'T, 'U> [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudFormComponent<_, _>>)>] () = inherit MudFormComponentBuilder<MudBlazor.MudFormComponent<'T, 'U>, 'T, 'U>()
    type MudBaseInput'<'T> [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudBaseInput<_>>)>] () = inherit MudBaseInputBuilder<MudBlazor.MudBaseInput<'T>, 'T>()
    type MudAutocomplete'<'T> [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudAutocomplete<_>>)>] () = inherit MudAutocompleteBuilder<MudBlazor.MudAutocomplete<'T>, 'T>()
    type MudDebouncedInput'<'T> [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudDebouncedInput<_>>)>] () = inherit MudDebouncedInputBuilder<MudBlazor.MudDebouncedInput<'T>, 'T>()
    type MudNumericField'<'T> [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudNumericField<_>>)>] () = inherit MudNumericFieldBuilder<MudBlazor.MudNumericField<'T>, 'T>()
    type MudTextField'<'T> [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudTextField<_>>)>] () = inherit MudTextFieldBuilder<MudBlazor.MudTextField<'T>, 'T>()
    type MudInput'<'T> [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudInput<_>>)>] () = inherit MudInputBuilder<MudBlazor.MudInput<'T>, 'T>()
    type MudInputString' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudInputString>)>] () = inherit MudInputStringBuilder<MudBlazor.MudInputString>()
    type MudRangeInput'<'T> [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudRangeInput<_>>)>] () = inherit MudRangeInputBuilder<MudBlazor.MudRangeInput<'T>, 'T>()
    type MudMask' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudMask>)>] () = inherit MudMaskBuilder<MudBlazor.MudMask>()
    type MudSelect'<'T> [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudSelect<_>>)>] () = inherit MudSelectBuilder<MudBlazor.MudSelect<'T>, 'T>()
    type MudBooleanInput'<'T> [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudBooleanInput<_>>)>] () = inherit MudBooleanInputBuilder<MudBlazor.MudBooleanInput<'T>, 'T>()
    type MudCheckBox'<'T> [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudCheckBox<_>>)>] () = inherit MudCheckBoxBuilder<MudBlazor.MudCheckBox<'T>, 'T>()
    type MudSwitch'<'T> [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudSwitch<_>>)>] () = inherit MudSwitchBuilder<MudBlazor.MudSwitch<'T>, 'T>()
    type MudFileUpload'<'T> [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudFileUpload<_>>)>] () = inherit MudFileUploadBuilder<MudBlazor.MudFileUpload<'T>, 'T>()
    type MudPicker'<'T> [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudPicker<_>>)>] () = inherit MudPickerBuilder<MudBlazor.MudPicker<'T>, 'T>()
    type MudBaseDatePicker' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudBaseDatePicker>)>] () = inherit MudBaseDatePickerBuilder<MudBlazor.MudBaseDatePicker>()
    type MudDatePicker' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudDatePicker>)>] () = inherit MudDatePickerBuilder<MudBlazor.MudDatePicker>()
    type MudDateRangePicker' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudDateRangePicker>)>] () = inherit MudDateRangePickerBuilder<MudBlazor.MudDateRangePicker>()
    type MudColorPicker' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudColorPicker>)>] () = inherit MudColorPickerBuilder<MudBlazor.MudColorPicker>()
    type MudTimePicker' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudTimePicker>)>] () = inherit MudTimePickerBuilder<MudBlazor.MudTimePicker>()
    type MudRadioGroup'<'T> [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudRadioGroup<_>>)>] () = inherit MudRadioGroupBuilder<MudBlazor.MudRadioGroup<'T>, 'T>()
    type MudAlert' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudAlert>)>] () = inherit MudAlertBuilder<MudBlazor.MudAlert>()
    type MudAppBar' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudAppBar>)>] () = inherit MudAppBarBuilder<MudBlazor.MudAppBar>()
    type MudAvatar' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudAvatar>)>] () = inherit MudAvatarBuilder<MudBlazor.MudAvatar>()
    type MudAvatarGroup' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudAvatarGroup>)>] () = inherit MudAvatarGroupBuilder<MudBlazor.MudAvatarGroup>()
    type MudBadge' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudBadge>)>] () = inherit MudBadgeBuilder<MudBlazor.MudBadge>()
    type MudBreadcrumbs' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudBreadcrumbs>)>] () = inherit MudBreadcrumbsBuilder<MudBlazor.MudBreadcrumbs>()
    type MudBreakpointProvider' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudBreakpointProvider>)>] () = inherit MudBreakpointProviderBuilder<MudBlazor.MudBreakpointProvider>()
    type MudToggleIconButton' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudToggleIconButton>)>] () = inherit MudToggleIconButtonBuilder<MudBlazor.MudToggleIconButton>()
    type MudButtonGroup' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudButtonGroup>)>] () = inherit MudButtonGroupBuilder<MudBlazor.MudButtonGroup>()
    type MudCard' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudCard>)>] () = inherit MudCardBuilder<MudBlazor.MudCard>()
    type MudCardActions' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudCardActions>)>] () = inherit MudCardActionsBuilder<MudBlazor.MudCardActions>()
    type MudCardContent' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudCardContent>)>] () = inherit MudCardContentBuilder<MudBlazor.MudCardContent>()
    type MudCardHeader' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudCardHeader>)>] () = inherit MudCardHeaderBuilder<MudBlazor.MudCardHeader>()
    type MudCardMedia' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudCardMedia>)>] () = inherit MudCardMediaBuilder<MudBlazor.MudCardMedia>()
    type MudCarouselItem' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudCarouselItem>)>] () = inherit MudCarouselItemBuilder<MudBlazor.MudCarouselItem>()
    type MudChip' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudChip>)>] () = inherit MudChipBuilder<MudBlazor.MudChip>()
    type MudChipSet' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudChipSet>)>] () = inherit MudChipSetBuilder<MudBlazor.MudChipSet>()
    type MudCollapse' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudCollapse>)>] () = inherit MudCollapseBuilder<MudBlazor.MudCollapse>()
    type Column'<'T> [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.Column<_>>)>] () = inherit ColumnBuilder<MudBlazor.Column<'T>, 'T>()
    type PropertyColumn'<'T, 'TProperty> [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.PropertyColumn<_, _>>)>] () = inherit PropertyColumnBuilder<MudBlazor.PropertyColumn<'T, 'TProperty>, 'T, 'TProperty>()
    type TemplateColumn'<'T> [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.TemplateColumn<_>>)>] () = inherit TemplateColumnBuilder<MudBlazor.TemplateColumn<'T>, 'T>()
    type FilterHeaderCell'<'T> [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.FilterHeaderCell<_>>)>] () = inherit FilterHeaderCellBuilder<MudBlazor.FilterHeaderCell<'T>, 'T>()
    type FooterCell'<'T> [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.FooterCell<_>>)>] () = inherit FooterCellBuilder<MudBlazor.FooterCell<'T>, 'T>()
    type HeaderCell'<'T> [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.HeaderCell<_>>)>] () = inherit HeaderCellBuilder<MudBlazor.HeaderCell<'T>, 'T>()
    type MudDataGrid'<'T> [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudDataGrid<_>>)>] () = inherit MudDataGridBuilder<MudBlazor.MudDataGrid<'T>, 'T>()
    type MudDataGridPager'<'T> [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudDataGridPager<_>>)>] () = inherit MudDataGridPagerBuilder<MudBlazor.MudDataGridPager<'T>, 'T>()
    type Row' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.Row>)>] () = inherit RowBuilder<MudBlazor.Row>()
    type MudDialog' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudDialog>)>] () = inherit MudDialogBuilder<MudBlazor.MudDialog>()
    type MudDialogInstance' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudDialogInstance>)>] () = inherit MudDialogInstanceBuilder<MudBlazor.MudDialogInstance>()
    type MudDrawer' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudDrawer>)>] () = inherit MudDrawerBuilder<MudBlazor.MudDrawer>()

    /// The container of a drag and drop zones
    type MudDropContainer'<'T> 
        /// The container of a drag and drop zones
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudDropContainer<_>>)>] () = inherit MudDropContainerBuilder<MudBlazor.MudDropContainer<'T>, 'T>()
    type MudDropZone'<'T> [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudDropZone<_>>)>] () = inherit MudDropZoneBuilder<MudBlazor.MudDropZone<'T>, 'T>()
    type MudDynamicDropItem'<'T> [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudDynamicDropItem<_>>)>] () = inherit MudDynamicDropItemBuilder<MudBlazor.MudDynamicDropItem<'T>, 'T>()

    /// Primitive component which allows rendering any HTML element we want
    /// through the HtmlTag property
    type MudElement' 
        /// Primitive component which allows rendering any HTML element we want
        /// through the HtmlTag property
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudElement>)>] () = inherit MudElementBuilder<MudBlazor.MudElement>()
    type MudExpansionPanel' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudExpansionPanel>)>] () = inherit MudExpansionPanelBuilder<MudBlazor.MudExpansionPanel>()
    type MudExpansionPanels' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudExpansionPanels>)>] () = inherit MudExpansionPanelsBuilder<MudBlazor.MudExpansionPanels>()
    type MudField' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudField>)>] () = inherit MudFieldBuilder<MudBlazor.MudField>()
    type MudFocusTrap' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudFocusTrap>)>] () = inherit MudFocusTrapBuilder<MudBlazor.MudFocusTrap>()
    type MudForm' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudForm>)>] () = inherit MudFormBuilder<MudBlazor.MudForm>()
    type MudHidden' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudHidden>)>] () = inherit MudHiddenBuilder<MudBlazor.MudHidden>()
    type MudHighlighter' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudHighlighter>)>] () = inherit MudHighlighterBuilder<MudBlazor.MudHighlighter>()
    type MudIcon' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudIcon>)>] () = inherit MudIconBuilder<MudBlazor.MudIcon>()
    type MudImage' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudImage>)>] () = inherit MudImageBuilder<MudBlazor.MudImage>()
    type MudInputLabel' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudInputLabel>)>] () = inherit MudInputLabelBuilder<MudBlazor.MudInputLabel>()
    type MudInputControl' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudInputControl>)>] () = inherit MudInputControlBuilder<MudBlazor.MudInputControl>()
    type MudLink' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudLink>)>] () = inherit MudLinkBuilder<MudBlazor.MudLink>()
    type MudList' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudList>)>] () = inherit MudListBuilder<MudBlazor.MudList>()
    type MudListItem' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudListItem>)>] () = inherit MudListItemBuilder<MudBlazor.MudListItem>()
    type MudListSubheader' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudListSubheader>)>] () = inherit MudListSubheaderBuilder<MudBlazor.MudListSubheader>()
    type MudMenu' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudMenu>)>] () = inherit MudMenuBuilder<MudBlazor.MudMenu>()
    type MudMenuItem' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudMenuItem>)>] () = inherit MudMenuItemBuilder<MudBlazor.MudMenuItem>()
    type MudMessageBox' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudMessageBox>)>] () = inherit MudMessageBoxBuilder<MudBlazor.MudMessageBox>()
    type MudNavGroup' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudNavGroup>)>] () = inherit MudNavGroupBuilder<MudBlazor.MudNavGroup>()
    type MudNavMenu' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudNavMenu>)>] () = inherit MudNavMenuBuilder<MudBlazor.MudNavMenu>()
    type MudOverlay' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudOverlay>)>] () = inherit MudOverlayBuilder<MudBlazor.MudOverlay>()
    type MudPageContentNavigation' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudPageContentNavigation>)>] () = inherit MudPageContentNavigationBuilder<MudBlazor.MudPageContentNavigation>()
    type MudPagination' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudPagination>)>] () = inherit MudPaginationBuilder<MudBlazor.MudPagination>()
    type MudPaper' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudPaper>)>] () = inherit MudPaperBuilder<MudBlazor.MudPaper>()
    type MudPopover' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudPopover>)>] () = inherit MudPopoverBuilder<MudBlazor.MudPopover>()
    type MudProgressCircular' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudProgressCircular>)>] () = inherit MudProgressCircularBuilder<MudBlazor.MudProgressCircular>()
    type MudProgressLinear' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudProgressLinear>)>] () = inherit MudProgressLinearBuilder<MudBlazor.MudProgressLinear>()
    type MudRadio'<'T> [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudRadio<_>>)>] () = inherit MudRadioBuilder<MudBlazor.MudRadio<'T>, 'T>()
    type MudRating' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudRating>)>] () = inherit MudRatingBuilder<MudBlazor.MudRating>()
    type MudRatingItem' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudRatingItem>)>] () = inherit MudRatingItemBuilder<MudBlazor.MudRatingItem>()
    type MudRTLProvider' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudRTLProvider>)>] () = inherit MudRTLProviderBuilder<MudBlazor.MudRTLProvider>()
    type MudScrollToTop' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudScrollToTop>)>] () = inherit MudScrollToTopBuilder<MudBlazor.MudScrollToTop>()
    type MudSkeleton' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudSkeleton>)>] () = inherit MudSkeletonBuilder<MudBlazor.MudSkeleton>()
    type MudSlider'<'T> [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudSlider<_>>)>] () = inherit MudSliderBuilder<MudBlazor.MudSlider<'T>, 'T>()
    type MudSnackbarElement' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudSnackbarElement>)>] () = inherit MudSnackbarElementBuilder<MudBlazor.MudSnackbarElement>()
    type MudSnackbarProvider' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudSnackbarProvider>)>] () = inherit MudSnackbarProviderBuilder<MudBlazor.MudSnackbarProvider>()
    type MudStack' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudStack>)>] () = inherit MudStackBuilder<MudBlazor.MudStack>()
    type MudSwipeArea' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudSwipeArea>)>] () = inherit MudSwipeAreaBuilder<MudBlazor.MudSwipeArea>()
    type MudTableGroupRow'<'T> [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudTableGroupRow<_>>)>] () = inherit MudTableGroupRowBuilder<MudBlazor.MudTableGroupRow<'T>, 'T>()
    type MudTablePager' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudTablePager>)>] () = inherit MudTablePagerBuilder<MudBlazor.MudTablePager>()
    type MudTableSortLabel'<'T> [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudTableSortLabel<_>>)>] () = inherit MudTableSortLabelBuilder<MudBlazor.MudTableSortLabel<'T>, 'T>()
    type MudTd' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudTd>)>] () = inherit MudTdBuilder<MudBlazor.MudTd>()
    type MudTFootRow' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudTFootRow>)>] () = inherit MudTFootRowBuilder<MudBlazor.MudTFootRow>()
    type MudTh' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudTh>)>] () = inherit MudThBuilder<MudBlazor.MudTh>()
    type MudTHeadRow' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudTHeadRow>)>] () = inherit MudTHeadRowBuilder<MudBlazor.MudTHeadRow>()
    type MudTr' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudTr>)>] () = inherit MudTrBuilder<MudBlazor.MudTr>()
    type MudSimpleTable' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudSimpleTable>)>] () = inherit MudSimpleTableBuilder<MudBlazor.MudSimpleTable>()
    type MudTimelineItem' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudTimelineItem>)>] () = inherit MudTimelineItemBuilder<MudBlazor.MudTimelineItem>()
    type MudTooltip' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudTooltip>)>] () = inherit MudTooltipBuilder<MudBlazor.MudTooltip>()
    type MudTreeView'<'T> [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudTreeView<_>>)>] () = inherit MudTreeViewBuilder<MudBlazor.MudTreeView<'T>, 'T>()
    type MudTreeViewItem'<'T> [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudTreeViewItem<_>>)>] () = inherit MudTreeViewItemBuilder<MudBlazor.MudTreeViewItem<'T>, 'T>()
    type MudText' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudText>)>] () = inherit MudTextBuilder<MudBlazor.MudText>()
    type MudContainer' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudContainer>)>] () = inherit MudContainerBuilder<MudBlazor.MudContainer>()
    type HierarchyColumn'<'T> [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.HierarchyColumn<_>>)>] () = inherit HierarchyColumnBuilder<MudBlazor.HierarchyColumn<'T>, 'T>()
    type MudDivider' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudDivider>)>] () = inherit MudDividerBuilder<MudBlazor.MudDivider>()
    type MudDrawerHeader' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudDrawerHeader>)>] () = inherit MudDrawerHeaderBuilder<MudBlazor.MudDrawerHeader>()
    type MudGrid' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudGrid>)>] () = inherit MudGridBuilder<MudBlazor.MudGrid>()
    type MudItem' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudItem>)>] () = inherit MudItemBuilder<MudBlazor.MudItem>()
    type MudMainContent' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudMainContent>)>] () = inherit MudMainContentBuilder<MudBlazor.MudMainContent>()
    type MudSparkLine' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudSparkLine>)>] () = inherit MudSparkLineBuilder<MudBlazor.MudSparkLine>()
    type MudTabPanel' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudTabPanel>)>] () = inherit MudTabPanelBuilder<MudBlazor.MudTabPanel>()
    type MudToolBar' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudToolBar>)>] () = inherit MudToolBarBuilder<MudBlazor.MudToolBar>()
    type MudBaseColumn' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudBaseColumn>)>] () = inherit MudBaseColumnBuilder<MudBlazor.MudBaseColumn>()

    /// Binds an object's property to a column by its property name 
    type MudColumn'<'T> 
        /// Binds an object's property to a column by its property name 
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudColumn<_>>)>] () = inherit MudColumnBuilder<MudBlazor.MudColumn<'T>, 'T>()

    /// Binds an object's property to a column by its property name 
    type MudSortableColumn'<'T, 'ModelType> 
        /// Binds an object's property to a column by its property name 
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudSortableColumn<_, _>>)>] () = inherit MudSortableColumnBuilder<MudBlazor.MudSortableColumn<'T, 'ModelType>, 'T, 'ModelType>()
    type MudAvatarColumn'<'T> [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudAvatarColumn<_>>)>] () = inherit MudAvatarColumnBuilder<MudBlazor.MudAvatarColumn<'T>, 'T>()
    type MudTemplateColumn'<'T> [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudTemplateColumn<_>>)>] () = inherit MudTemplateColumnBuilder<MudBlazor.MudTemplateColumn<'T>, 'T>()
    type BaseMudThemeProvider' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.BaseMudThemeProvider>)>] () = inherit BaseMudThemeProviderBuilder<MudBlazor.BaseMudThemeProvider>()
    type MudThemeProvider' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudThemeProvider>)>] () = inherit MudThemeProviderBuilder<MudBlazor.MudThemeProvider>()
    type SelectColumn'<'T> [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.SelectColumn<_>>)>] () = inherit SelectColumnBuilder<MudBlazor.SelectColumn<'T>, 'T>()
    type MudDialogProvider' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudDialogProvider>)>] () = inherit MudDialogProviderBuilder<MudBlazor.MudDialogProvider>()
    type MudPopoverProvider' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudPopoverProvider>)>] () = inherit MudPopoverProviderBuilder<MudBlazor.MudPopoverProvider>()
    type MudVirtualize'<'T> [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudVirtualize<_>>)>] () = inherit MudVirtualizeBuilder<MudBlazor.MudVirtualize<'T>, 'T>()
    type BreadcrumbLink' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.BreadcrumbLink>)>] () = inherit BreadcrumbLinkBuilder<MudBlazor.BreadcrumbLink>()
    type BreadcrumbSeparator' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.BreadcrumbSeparator>)>] () = inherit BreadcrumbSeparatorBuilder<MudBlazor.BreadcrumbSeparator>()
    type MudPickerContent' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudPickerContent>)>] () = inherit MudPickerContentBuilder<MudBlazor.MudPickerContent>()
    type MudPickerToolbar' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudPickerToolbar>)>] () = inherit MudPickerToolbarBuilder<MudBlazor.MudPickerToolbar>()
    type MudRender' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudRender>)>] () = inherit MudRenderBuilder<MudBlazor.MudRender>()
    type MudSpacer' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudSpacer>)>] () = inherit MudSpacerBuilder<MudBlazor.MudSpacer>()
    type MudTreeViewItemToggleButton' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudTreeViewItemToggleButton>)>] () = inherit MudTreeViewItemToggleButtonBuilder<MudBlazor.MudTreeViewItemToggleButton>()
    type _Imports' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor._Imports>)>] () = inherit _ImportsBuilder<MudBlazor._Imports>()
            
namespace MudBlazor.Charts

[<AutoOpen>]
module DslCE =
  
    open System.Diagnostics.CodeAnalysis
    open MudBlazor.DslInternals.Charts

    type Bar' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.Charts.Bar>)>] () = inherit BarBuilder<MudBlazor.Charts.Bar>()
    type Donut' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.Charts.Donut>)>] () = inherit DonutBuilder<MudBlazor.Charts.Donut>()
    type Line' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.Charts.Line>)>] () = inherit LineBuilder<MudBlazor.Charts.Line>()
    type Pie' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.Charts.Pie>)>] () = inherit PieBuilder<MudBlazor.Charts.Pie>()
    type Legend' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.Charts.Legend>)>] () = inherit LegendBuilder<MudBlazor.Charts.Legend>()
    type Filters' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.Charts.Filters>)>] () = inherit FiltersBuilder<MudBlazor.Charts.Filters>()
            
namespace MudBlazor.Internal

[<AutoOpen>]
module DslCE =
  
    open System.Diagnostics.CodeAnalysis
    open MudBlazor.DslInternals.Internal

    type MudInputAdornment' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.Internal.MudInputAdornment>)>] () = inherit MudInputAdornmentBuilder<MudBlazor.Internal.MudInputAdornment>()
            
namespace MudBlazor.Components.Snackbar.InternalComponents

[<AutoOpen>]
module DslCE =
  
    open System.Diagnostics.CodeAnalysis
    open MudBlazor.DslInternals.Components.Snackbar.InternalComponents

    type SnackbarMessageRenderFragment' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.Components.Snackbar.InternalComponents.SnackbarMessageRenderFragment>)>] () = inherit SnackbarMessageRenderFragmentBuilder<MudBlazor.Components.Snackbar.InternalComponents.SnackbarMessageRenderFragment>()
    type SnackbarMessageText' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.Components.Snackbar.InternalComponents.SnackbarMessageText>)>] () = inherit SnackbarMessageTextBuilder<MudBlazor.Components.Snackbar.InternalComponents.SnackbarMessageText>()
            