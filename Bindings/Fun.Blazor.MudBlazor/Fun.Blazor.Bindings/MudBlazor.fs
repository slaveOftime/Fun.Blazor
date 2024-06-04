namespace rec MudBlazor.DslInternals

open System.Threading.Tasks
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
    /// The value of rel attribute for web crawlers. Overrides "noopener" set by Target attribute.
    [<CustomOperation("Rel")>] member inline _.Rel ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Rel" => x)
    /// If true, the button will be disabled.
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Disabled" => (defaultArg x true))
    /// If true, the click event bubbles up to the containing/parent component.
    [<CustomOperation("ClickPropagation")>] member inline _.ClickPropagation ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("ClickPropagation" => (defaultArg x true))
    /// If true, no drop-shadow will be used.
    [<CustomOperation("DisableElevation")>] member inline _.DisableElevation ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("DisableElevation" => (defaultArg x true))
    /// If true, disables ripple effect.
    [<CustomOperation("DisableRipple")>] member inline _.DisableRipple ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("DisableRipple" => (defaultArg x true))
    /// Command executed when the user clicks on an element.
    [<CustomOperation("Command")>] member inline _.Command ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Windows.Input.ICommand) = render ==> ("Command" => x)
    /// Command parameter.
    [<CustomOperation("CommandParameter")>] member inline _.CommandParameter ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Object) = render ==> ("CommandParameter" => x)
    /// Button click event.
    [<CustomOperation("OnClick")>] member inline _.OnClick ([<InlineIfLambda>] render: AttrRenderFragment, fn: Microsoft.AspNetCore.Components.Web.MouseEventArgs -> unit) = render ==> html.callback("OnClick", fn)
    /// Button click event.
    [<CustomOperation("OnClick")>] member inline _.OnClick ([<InlineIfLambda>] render: AttrRenderFragment, fn: Microsoft.AspNetCore.Components.Web.MouseEventArgs -> Task<unit>) = render ==> html.callbackTask("OnClick", fn)

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
    [<CustomOperation("FullWidth")>] member inline _.FullWidth ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("FullWidth" => (defaultArg x true))

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
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Disabled" => (defaultArg x true))
    /// If true, disables ripple effect.
    [<CustomOperation("DisableRipple")>] member inline _.DisableRipple ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("DisableRipple" => (defaultArg x true))
    /// Link to a URL when clicked.
    [<CustomOperation("Href")>] member inline _.Href ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Href" => x)
    /// If true, force browser to redirect outside component router-space.
    [<CustomOperation("ForceLoad")>] member inline _.ForceLoad ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("ForceLoad" => (defaultArg x true))
    /// Command parameter.
    [<CustomOperation("CommandParameter")>] member inline _.CommandParameter ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Object) = render ==> ("CommandParameter" => x)
    /// Command executed when the user clicks on an element.
    [<CustomOperation("Command")>] member inline _.Command ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Windows.Input.ICommand) = render ==> ("Command" => x)
    /// Click event. Will not be called if Href is also set.
    [<CustomOperation("OnClick")>] member inline _.OnClick ([<InlineIfLambda>] render: AttrRenderFragment, fn: Microsoft.AspNetCore.Components.Web.MouseEventArgs -> unit) = render ==> html.callback("OnClick", fn)
    /// Click event. Will not be called if Href is also set.
    [<CustomOperation("OnClick")>] member inline _.OnClick ([<InlineIfLambda>] render: AttrRenderFragment, fn: Microsoft.AspNetCore.Components.Web.MouseEventArgs -> Task<unit>) = render ==> html.callbackTask("OnClick", fn)

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

/// Base class for implementing Popover component.
type MudPopoverBaseBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    /// If true, the popover is visible.
    [<CustomOperation("Open")>] member inline _.Open ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Open" => (defaultArg x true))

type MudPopoverBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudPopoverBaseBuilder<'FunBlazorGeneric>()
    /// Sets the maxheight the popover can have when open.
    [<CustomOperation("MaxHeight")>] member inline _.MaxHeight ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Int32>) = render ==> ("MaxHeight" => x)
    /// If true, will apply default MudPaper classes.
    [<CustomOperation("Paper")>] member inline _.Paper ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Paper" => (defaultArg x true))
    /// The higher the number, the heavier the drop-shadow.
    [<CustomOperation("Elevation")>] member inline _.Elevation ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("Elevation" => x)
    /// If true, border-radius is set to 0.
    [<CustomOperation("Square")>] member inline _.Square ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Square" => (defaultArg x true))
    /// If true the popover will be fixed position instead of absolute.
    [<CustomOperation("Fixed")>] member inline _.Fixed ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Fixed" => (defaultArg x true))
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
    [<CustomOperation("RelativeWidth")>] member inline _.RelativeWidth ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("RelativeWidth" => (defaultArg x true))

type MudTableBaseBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    /// When editing a row and this is true, the editing row must be saved/canceled before a new row will be selected.
    [<CustomOperation("IsEditRowSwitchingBlocked")>] member inline _.IsEditRowSwitchingBlocked ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("IsEditRowSwitchingBlocked" => (defaultArg x true))
    /// The higher the number, the heavier the drop-shadow. 0 for no shadow.
    [<CustomOperation("Elevation")>] member inline _.Elevation ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("Elevation" => x)
    /// Set true to disable rounded corners
    [<CustomOperation("Square")>] member inline _.Square ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Square" => (defaultArg x true))
    /// If true, table will be outlined.
    [<CustomOperation("Outlined")>] member inline _.Outlined ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Outlined" => (defaultArg x true))
    /// If true, table's cells will have left/right borders.
    [<CustomOperation("Bordered")>] member inline _.Bordered ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Bordered" => (defaultArg x true))
    /// Set true for rows with a narrow height
    [<CustomOperation("Dense")>] member inline _.Dense ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Dense" => (defaultArg x true))
    /// Set true to see rows hover on mouse-over.
    [<CustomOperation("Hover")>] member inline _.Hover ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Hover" => (defaultArg x true))
    /// If true, striped table rows will be used.
    [<CustomOperation("Striped")>] member inline _.Striped ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Striped" => (defaultArg x true))
    /// At what breakpoint the table should switch to mobile layout. Takes None, Xs, Sm, Md, Lg and Xl the default behavior is breaking on Xs.
    [<CustomOperation("Breakpoint")>] member inline _.Breakpoint ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Breakpoint) = render ==> ("Breakpoint" => x)
    /// When true, the header will stay in place when the table is scrolled. Note: set Height to make the table scrollable.
    [<CustomOperation("FixedHeader")>] member inline _.FixedHeader ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("FixedHeader" => (defaultArg x true))
    /// When true, the footer will be visible is not scrolled to the bottom. Note: set Height to make the table scrollable.
    [<CustomOperation("FixedFooter")>] member inline _.FixedFooter ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("FixedFooter" => (defaultArg x true))
    /// Setting a height will allow to scroll the table. If not set, it will try to grow in height. You can set this to any CSS value that the
    /// attribute 'height' accepts, i.e. 500px. 
    [<CustomOperation("Height")>] member inline _.Height ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Height" => x)
    /// If table is in smalldevice mode and uses any kind of sorting the text applied here will be the sort selects label.
    [<CustomOperation("SortLabel")>] member inline _.SortLabel ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("SortLabel" => x)
    /// If true allows table to be in an unsorted state through column clicks (i.e. first click sorts "Ascending", second "Descending", third "None").
    /// If false only "Ascending" and "Descending" states are allowed (i.e. there always should be a column to sort).
    [<CustomOperation("AllowUnsorted")>] member inline _.AllowUnsorted ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("AllowUnsorted" => (defaultArg x true))
    /// If the table has more items than this number, it will break the rows into pages of said size.
    /// Note: requires a MudTablePager in PagerContent.
    [<CustomOperation("RowsPerPage")>] member inline _.RowsPerPage ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("RowsPerPage" => x)
    /// If the table has more items than this number, it will break the rows into pages of said size.
    /// Note: requires a MudTablePager in PagerContent.
    [<CustomOperation("RowsPerPage'")>] member inline _.RowsPerPage' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.Int32 * (System.Int32 -> unit)) = render ==> html.bind("RowsPerPage", valueFn)
    /// Rows Per Page two-way bindable parameter
    [<CustomOperation("RowsPerPageChanged")>] member inline _.RowsPerPageChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.Int32 -> unit) = render ==> html.callback("RowsPerPageChanged", fn)
    /// Rows Per Page two-way bindable parameter
    [<CustomOperation("RowsPerPageChanged")>] member inline _.RowsPerPageChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.Int32 -> Task<unit>) = render ==> html.callbackTask("RowsPerPageChanged", fn)
    /// The page index of the currently displayed page (Zero based). Usually called by MudTablePager.
    /// Note: requires a MudTablePager in PagerContent.
    [<CustomOperation("CurrentPage")>] member inline _.CurrentPage ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("CurrentPage" => x)
    /// Set to true to enable selection of multiple rows with check boxes. 
    [<CustomOperation("MultiSelection")>] member inline _.MultiSelection ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("MultiSelection" => (defaultArg x true))
    /// When true, a row-click also toggles the checkbox state.
    [<CustomOperation("SelectOnRowClick")>] member inline _.SelectOnRowClick ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("SelectOnRowClick" => (defaultArg x true))
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
    [<CustomOperation("Loading")>] member inline _.Loading ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Loading" => (defaultArg x true))
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
    [<CustomOperation("CustomHeader")>] member inline _.CustomHeader ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("CustomHeader" => (defaultArg x true))
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
    [<CustomOperation("CustomFooter")>] member inline _.CustomFooter ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("CustomFooter" => (defaultArg x true))
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
    [<CustomOperation("ReadOnly")>] member inline _.ReadOnly ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("ReadOnly" => (defaultArg x true))
    /// Button commit edit click event.
    [<CustomOperation("OnCommitEditClick")>] member inline _.OnCommitEditClick ([<InlineIfLambda>] render: AttrRenderFragment, fn: Microsoft.AspNetCore.Components.Web.MouseEventArgs -> unit) = render ==> html.callback("OnCommitEditClick", fn)
    /// Button commit edit click event.
    [<CustomOperation("OnCommitEditClick")>] member inline _.OnCommitEditClick ([<InlineIfLambda>] render: AttrRenderFragment, fn: Microsoft.AspNetCore.Components.Web.MouseEventArgs -> Task<unit>) = render ==> html.callbackTask("OnCommitEditClick", fn)
    /// Button cancel edit click event.
    [<CustomOperation("OnCancelEditClick")>] member inline _.OnCancelEditClick ([<InlineIfLambda>] render: AttrRenderFragment, fn: Microsoft.AspNetCore.Components.Web.MouseEventArgs -> unit) = render ==> html.callback("OnCancelEditClick", fn)
    /// Button cancel edit click event.
    [<CustomOperation("OnCancelEditClick")>] member inline _.OnCancelEditClick ([<InlineIfLambda>] render: AttrRenderFragment, fn: Microsoft.AspNetCore.Components.Web.MouseEventArgs -> Task<unit>) = render ==> html.callbackTask("OnCancelEditClick", fn)
    /// Event is called before the item is modified in inline editing.
    [<CustomOperation("OnPreviewEditClick")>] member inline _.OnPreviewEditClick ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.Object -> unit) = render ==> html.callback("OnPreviewEditClick", fn)
    /// Event is called before the item is modified in inline editing.
    [<CustomOperation("OnPreviewEditClick")>] member inline _.OnPreviewEditClick ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.Object -> Task<unit>) = render ==> html.callbackTask("OnPreviewEditClick", fn)
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
    [<CustomOperation("CanCancelEdit")>] member inline _.CanCancelEdit ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("CanCancelEdit" => (defaultArg x true))
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
    [<CustomOperation("Virtualize")>] member inline _.Virtualize ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Virtualize" => (defaultArg x true))
    /// Gets or sets a value that determines how many additional items will be rendered
    /// before and after the visible region. This help to reduce the frequency of rendering
    /// during scrolling. However, higher values mean that more elements will be present
    /// in the page.
    [<CustomOperation("OverscanCount")>] member inline _.OverscanCount ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("OverscanCount" => x)
    /// Gets the size of each item in pixels. Defaults to 50px.
    [<CustomOperation("ItemSize")>] member inline _.ItemSize ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Single) = render ==> ("ItemSize" => x)

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
    [<CustomOperation("HorizontalScrollbar")>] member inline _.HorizontalScrollbar ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("HorizontalScrollbar" => (defaultArg x true))
    /// The data to display in the table. MudTable will render one row per item
    [<CustomOperation("Items")>] member inline _.Items ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.IEnumerable<'T>) = render ==> ("Items" => x)
    /// A function that returns whether or not an item should be displayed in the table. You can use this to implement your own search function.
    [<CustomOperation("Filter")>] member inline _.Filter ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("Filter" => (System.Func<'T, System.Boolean>fn))
    /// Row click event.
    [<CustomOperation("OnRowClick")>] member inline _.OnRowClick ([<InlineIfLambda>] render: AttrRenderFragment, fn: MudBlazor.TableRowClickEventArgs<'T> -> unit) = render ==> html.callback("OnRowClick", fn)
    /// Row click event.
    [<CustomOperation("OnRowClick")>] member inline _.OnRowClick ([<InlineIfLambda>] render: AttrRenderFragment, fn: MudBlazor.TableRowClickEventArgs<'T> -> Task<unit>) = render ==> html.callbackTask("OnRowClick", fn)
    /// Row hover start event.
    [<CustomOperation("OnRowMouseEnter")>] member inline _.OnRowMouseEnter ([<InlineIfLambda>] render: AttrRenderFragment, fn: MudBlazor.TableRowHoverEventArgs<'T> -> unit) = render ==> html.callback("OnRowMouseEnter", fn)
    /// Row hover start event.
    [<CustomOperation("OnRowMouseEnter")>] member inline _.OnRowMouseEnter ([<InlineIfLambda>] render: AttrRenderFragment, fn: MudBlazor.TableRowHoverEventArgs<'T> -> Task<unit>) = render ==> html.callbackTask("OnRowMouseEnter", fn)
    /// Row hover stop event.
    [<CustomOperation("OnRowMouseLeave")>] member inline _.OnRowMouseLeave ([<InlineIfLambda>] render: AttrRenderFragment, fn: MudBlazor.TableRowHoverEventArgs<'T> -> unit) = render ==> html.callback("OnRowMouseLeave", fn)
    /// Row hover stop event.
    [<CustomOperation("OnRowMouseLeave")>] member inline _.OnRowMouseLeave ([<InlineIfLambda>] render: AttrRenderFragment, fn: MudBlazor.TableRowHoverEventArgs<'T> -> Task<unit>) = render ==> html.callbackTask("OnRowMouseLeave", fn)
    /// Returns the class that will get joined with RowClass. Takes the current item and row index.
    [<CustomOperation("RowClassFunc")>] member inline _.RowClassFunc ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("RowClassFunc" => (System.Func<'T, System.Int32, System.String>fn))
    /// Returns the style that will get joined with RowStyle. Takes the current item and row index.
    [<CustomOperation("RowStyleFunc")>] member inline _.RowStyleFunc ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("RowStyleFunc" => (System.Func<'T, System.Int32, System.String>fn))
    /// Returns the item which was last clicked on in single selection mode (that is, if MultiSelection is false)
    [<CustomOperation("SelectedItem")>] member inline _.SelectedItem ([<InlineIfLambda>] render: AttrRenderFragment, x: 'T) = render ==> ("SelectedItem" => x)
    /// Returns the item which was last clicked on in single selection mode (that is, if MultiSelection is false)
    [<CustomOperation("SelectedItem'")>] member inline _.SelectedItem' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: 'T * ('T -> unit)) = render ==> html.bind("SelectedItem", valueFn)
    /// Callback is called when a row has been clicked and returns the selected item.
    [<CustomOperation("SelectedItemChanged")>] member inline _.SelectedItemChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: 'T -> unit) = render ==> html.callback("SelectedItemChanged", fn)
    /// Callback is called when a row has been clicked and returns the selected item.
    [<CustomOperation("SelectedItemChanged")>] member inline _.SelectedItemChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: 'T -> Task<unit>) = render ==> html.callbackTask("SelectedItemChanged", fn)
    /// If MultiSelection is true, this returns the currently selected items. You can bind this property and the initial content of the HashSet you bind it to will cause these rows to be selected initially.
    [<CustomOperation("SelectedItems")>] member inline _.SelectedItems ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.HashSet<'T>) = render ==> ("SelectedItems" => x)
    /// If MultiSelection is true, this returns the currently selected items. You can bind this property and the initial content of the HashSet you bind it to will cause these rows to be selected initially.
    [<CustomOperation("SelectedItems'")>] member inline _.SelectedItems' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.Collections.Generic.HashSet<'T> * (System.Collections.Generic.HashSet<'T> -> unit)) = render ==> html.bind("SelectedItems", valueFn)
    /// The Comparer to use for comparing selected items internally.
    [<CustomOperation("Comparer")>] member inline _.Comparer ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.IEqualityComparer<'T>) = render ==> ("Comparer" => x)
    /// Callback is called whenever items are selected or deselected in multi selection mode.
    [<CustomOperation("SelectedItemsChanged")>] member inline _.SelectedItemsChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.Collections.Generic.HashSet<'T> -> unit) = render ==> html.callback("SelectedItemsChanged", fn)
    /// Callback is called whenever items are selected or deselected in multi selection mode.
    [<CustomOperation("SelectedItemsChanged")>] member inline _.SelectedItemsChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.Collections.Generic.HashSet<'T> -> Task<unit>) = render ==> html.callbackTask("SelectedItemsChanged", fn)
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
    [<CustomOperation("KeepPanelsAlive")>] member inline _.KeepPanelsAlive ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("KeepPanelsAlive" => (defaultArg x true))
    /// If true, sets the border-radius to theme default.
    [<CustomOperation("Rounded")>] member inline _.Rounded ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Rounded" => (defaultArg x true))
    /// If true, sets a border between the content and the tabHeader depending on the position.
    [<CustomOperation("Border")>] member inline _.Border ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Border" => (defaultArg x true))
    /// If true, tabHeader will be outlined.
    [<CustomOperation("Outlined")>] member inline _.Outlined ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Outlined" => (defaultArg x true))
    /// If true, centers the tabitems.
    [<CustomOperation("Centered")>] member inline _.Centered ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Centered" => (defaultArg x true))
    /// Hides the active tab slider.
    [<CustomOperation("HideSlider")>] member inline _.HideSlider ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("HideSlider" => (defaultArg x true))
    /// Icon to use for left pagination.
    [<CustomOperation("PrevIcon")>] member inline _.PrevIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("PrevIcon" => x)
    /// Icon to use for right pagination.
    [<CustomOperation("NextIcon")>] member inline _.NextIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("NextIcon" => x)
    /// If true, always display the scroll buttons even if the tabs are smaller than the required with, buttons will be disabled if there is nothing to scroll.
    [<CustomOperation("AlwaysShowScrollButtons")>] member inline _.AlwaysShowScrollButtons ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("AlwaysShowScrollButtons" => (defaultArg x true))
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
    /// If true, will apply elevation, rounded, outlined effects to the whole tab component instead of just tabHeader.
    [<CustomOperation("ApplyEffectsToContainer")>] member inline _.ApplyEffectsToContainer ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("ApplyEffectsToContainer" => (defaultArg x true))
    /// If true, disables ripple effect.
    [<CustomOperation("DisableRipple")>] member inline _.DisableRipple ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("DisableRipple" => (defaultArg x true))
    /// If true, disables slider animation
    [<CustomOperation("DisableSliderAnimation")>] member inline _.DisableSliderAnimation ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("DisableSliderAnimation" => (defaultArg x true))
    /// This fragment is placed between tabHeader and panels. 
    /// It can be used to display additional content like an address line in a browser.
    /// The active tab will be the content of this RenderFragement
    [<CustomOperation("PrePanelContent")>] member inline _.PrePanelContent ([<InlineIfLambda>] render: AttrRenderFragment, fn: MudBlazor.MudTabPanel -> NodeRenderFragment) = render ==> html.renderFragment("PrePanelContent", fn)
    /// Custom class/classes for TabPanel
    [<CustomOperation("TabPanelClass")>] member inline _.TabPanelClass ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("TabPanelClass" => x)
    /// Custom class/classes for TabHeader
    [<CustomOperation("TabHeaderClass")>] member inline _.TabHeaderClass ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("TabHeaderClass" => x)
    /// Custom class/classes for Selected Content Panel
    [<CustomOperation("PanelClass")>] member inline _.PanelClass ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("PanelClass" => x)
    /// The current active panel index. Also with Bidirectional Binding
    [<CustomOperation("ActivePanelIndex")>] member inline _.ActivePanelIndex ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("ActivePanelIndex" => x)
    /// The current active panel index. Also with Bidirectional Binding
    [<CustomOperation("ActivePanelIndex'")>] member inline _.ActivePanelIndex' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.Int32 * (System.Int32 -> unit)) = render ==> html.bind("ActivePanelIndex", valueFn)
    /// Fired when ActivePanelIndex changes.
    [<CustomOperation("ActivePanelIndexChanged")>] member inline _.ActivePanelIndexChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.Int32 -> unit) = render ==> html.callback("ActivePanelIndexChanged", fn)
    /// Fired when ActivePanelIndex changes.
    [<CustomOperation("ActivePanelIndexChanged")>] member inline _.ActivePanelIndexChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.Int32 -> Task<unit>) = render ==> html.callbackTask("ActivePanelIndexChanged", fn)
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
    [<CustomOperation("AddTab")>] member inline _.AddTab ([<InlineIfLambda>] render: AttrRenderFragment, fn: unit -> unit) = render ==> html.callback("AddTab", fn)
    /// The callback, when the add button has been clicked
    [<CustomOperation("AddTab")>] member inline _.AddTab ([<InlineIfLambda>] render: AttrRenderFragment, fn: unit -> Task<unit>) = render ==> html.callbackTask("AddTab", fn)
    /// The callback, when the close button has been clicked
    [<CustomOperation("CloseTab")>] member inline _.CloseTab ([<InlineIfLambda>] render: AttrRenderFragment, fn: MudBlazor.MudTabPanel -> unit) = render ==> html.callback("CloseTab", fn)
    /// The callback, when the close button has been clicked
    [<CustomOperation("CloseTab")>] member inline _.CloseTab ([<InlineIfLambda>] render: AttrRenderFragment, fn: MudBlazor.MudTabPanel -> Task<unit>) = render ==> html.callbackTask("CloseTab", fn)
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
    [<CustomOperation("SelectedIndexChanged")>] member inline _.SelectedIndexChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.Int32 -> unit) = render ==> html.callback("SelectedIndexChanged", fn)
    /// Selected index of a portion of the chart.
    [<CustomOperation("SelectedIndexChanged")>] member inline _.SelectedIndexChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.Int32 -> Task<unit>) = render ==> html.callbackTask("SelectedIndexChanged", fn)
    /// Indicates whether lines in a LineChart can be individually hidden by the user. 
    /// When set to true, the chart provides a checkboxes
    /// to toggle the visibility of each line.
    [<CustomOperation("CanHideSeries")>] member inline _.CanHideSeries ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("CanHideSeries" => (defaultArg x true))

type MudChartBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudChartBaseBuilder<'FunBlazorGeneric>()


            
namespace rec MudBlazor.DslInternals.Charts

open System.Threading.Tasks
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


type StackedBarBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudChartBaseBuilder<'FunBlazorGeneric>()


type LegendBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudChartBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Data")>] member inline _.Data ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.List<MudBlazor.Charts.SVG.Models.SvgLegend>) = render ==> ("Data" => x)

            
namespace rec MudBlazor.DslInternals

open System.Threading.Tasks
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
    [<CustomOperation("SelectedIndexChanged")>] member inline _.SelectedIndexChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.Int32 -> unit) = render ==> html.callback("SelectedIndexChanged", fn)
    [<CustomOperation("SelectedIndexChanged")>] member inline _.SelectedIndexChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.Int32 -> Task<unit>) = render ==> html.callbackTask("SelectedIndexChanged", fn)

type MudBaseBindableItemsControlBuilder<'FunBlazorGeneric, 'TChildComponent, 'TData when 'TChildComponent :> MudBlazor.MudComponentBase and 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudBaseItemsControlBuilder<'FunBlazorGeneric, 'TChildComponent>()
    /// Items Collection - For data-binding usage
    [<CustomOperation("ItemsSource")>] member inline _.ItemsSource ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.IEnumerable<'TData>) = render ==> ("ItemsSource" => x)
    /// Template for each Item in ItemsSource collection
    [<CustomOperation("ItemTemplate")>] member inline _.ItemTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fn: 'TData -> NodeRenderFragment) = render ==> html.renderFragment("ItemTemplate", fn)

type MudCarouselBuilder<'FunBlazorGeneric, 'TData when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudBaseBindableItemsControlBuilder<'FunBlazorGeneric, MudBlazor.MudCarouselItem, 'TData>()
    /// Gets or Sets if 'Next' and 'Previous' arrows must be visible
    [<CustomOperation("ShowArrows")>] member inline _.ShowArrows ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("ShowArrows" => (defaultArg x true))
    /// Sets the position of the arrows. By default, the position is the Center position
    [<CustomOperation("ArrowsPosition")>] member inline _.ArrowsPosition ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Position) = render ==> ("ArrowsPosition" => x)
    /// Gets or Sets if bar with Bullets must be visible
    [<CustomOperation("ShowBullets")>] member inline _.ShowBullets ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("ShowBullets" => (defaultArg x true))
    /// Sets the position of the bullets. By default, the position is the Bottom position
    [<CustomOperation("BulletsPosition")>] member inline _.BulletsPosition ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Position) = render ==> ("BulletsPosition" => x)
    /// Gets or Sets the Bullets color.
    /// If not set, the color is determined based on the Color property of the active child.
    [<CustomOperation("BulletsColor")>] member inline _.BulletsColor ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<MudBlazor.Color>) = render ==> ("BulletsColor" => x)
    /// Gets or Sets if bottom bar with Delimiters must be visible.
    /// Deprecated, use ShowBullets instead.
    [<CustomOperation("ShowDelimiters")>] member inline _.ShowDelimiters ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("ShowDelimiters" => (defaultArg x true))
    /// Gets or Sets the Delimiters color.
    /// If not set, the color is determined based on the Color property of the active child.
    /// Deprecated, use BulletsColor instead.
    [<CustomOperation("DelimitersColor")>] member inline _.DelimitersColor ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<MudBlazor.Color>) = render ==> ("DelimitersColor" => x)
    /// Gets or Sets automatic cycle on item collection.
    [<CustomOperation("AutoCycle")>] member inline _.AutoCycle ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("AutoCycle" => (defaultArg x true))
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
    [<CustomOperation("EnableSwipeGesture")>] member inline _.EnableSwipeGesture ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("EnableSwipeGesture" => (defaultArg x true))
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
    [<CustomOperation("Reverse")>] member inline _.Reverse ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Reverse" => (defaultArg x true))
    /// If true, disables all TimelineItem modifiers, like adding a caret to a MudCard.
    [<CustomOperation("DisableModifiers")>] member inline _.DisableModifiers ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("DisableModifiers" => (defaultArg x true))

type MudFormComponentBuilder<'FunBlazorGeneric, 'T, 'U when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    /// If true, this form input is required to be filled out.
    [<CustomOperation("Required")>] member inline _.Required ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Required" => (defaultArg x true))
    /// The error text that will be displayed if the input is not filled out but required.
    [<CustomOperation("RequiredError")>] member inline _.RequiredError ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("RequiredError" => x)
    /// The ErrorText that will be displayed if Error true.
    [<CustomOperation("ErrorText")>] member inline _.ErrorText ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("ErrorText" => x)
    /// If true, the label will be displayed in an error state.
    [<CustomOperation("Error")>] member inline _.Error ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Error" => (defaultArg x true))
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
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Disabled" => (defaultArg x true))
    /// If true, the input will be read-only.
    [<CustomOperation("ReadOnly")>] member inline _.ReadOnly ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("ReadOnly" => (defaultArg x true))
    /// If true, the input will take up the full width of its container.
    [<CustomOperation("FullWidth")>] member inline _.FullWidth ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("FullWidth" => (defaultArg x true))
    /// If true, the input will update the Value immediately on typing.
    /// If false, the Value is updated only on Enter.
    [<CustomOperation("Immediate")>] member inline _.Immediate ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Immediate" => (defaultArg x true))
    /// If true, the input will not have an underline.
    [<CustomOperation("DisableUnderLine")>] member inline _.DisableUnderLine ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("DisableUnderLine" => (defaultArg x true))
    /// The HelperText will be displayed below the text field.
    [<CustomOperation("HelperText")>] member inline _.HelperText ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("HelperText" => x)
    /// If true, the helper text will only be visible on focus.
    [<CustomOperation("HelperTextOnFocus")>] member inline _.HelperTextOnFocus ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("HelperTextOnFocus" => (defaultArg x true))
    /// Icon that will be used if Adornment is set to Start or End.
    [<CustomOperation("AdornmentIcon")>] member inline _.AdornmentIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("AdornmentIcon" => x)
    /// Text that will be used if Adornment is set to Start or End, the Text overrides Icon.
    [<CustomOperation("AdornmentText")>] member inline _.AdornmentText ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("AdornmentText" => x)
    /// The Adornment if used. By default, it is set to None.
    [<CustomOperation("Adornment")>] member inline _.Adornment ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Adornment) = render ==> ("Adornment" => x)
    /// The validation is only triggered if the user has changed the input value at least once. By default, it is false
    [<CustomOperation("OnlyValidateIfDirty")>] member inline _.OnlyValidateIfDirty ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("OnlyValidateIfDirty" => (defaultArg x true))
    /// The color of the adornment if used. It supports the theme colors.
    [<CustomOperation("AdornmentColor")>] member inline _.AdornmentColor ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("AdornmentColor" => x)
    /// The aria-label of the adornment.
    [<CustomOperation("AdornmentAriaLabel")>] member inline _.AdornmentAriaLabel ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("AdornmentAriaLabel" => x)
    /// The Icon Size.
    [<CustomOperation("IconSize")>] member inline _.IconSize ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Size) = render ==> ("IconSize" => x)
    /// Button click event if set and Adornment used.
    [<CustomOperation("OnAdornmentClick")>] member inline _.OnAdornmentClick ([<InlineIfLambda>] render: AttrRenderFragment, fn: Microsoft.AspNetCore.Components.Web.MouseEventArgs -> unit) = render ==> html.callback("OnAdornmentClick", fn)
    /// Button click event if set and Adornment used.
    [<CustomOperation("OnAdornmentClick")>] member inline _.OnAdornmentClick ([<InlineIfLambda>] render: AttrRenderFragment, fn: Microsoft.AspNetCore.Components.Web.MouseEventArgs -> Task<unit>) = render ==> html.callbackTask("OnAdornmentClick", fn)
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
    [<CustomOperation("AutoFocus")>] member inline _.AutoFocus ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("AutoFocus" => (defaultArg x true))
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
    [<CustomOperation("TextUpdateSuppression")>] member inline _.TextUpdateSuppression ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("TextUpdateSuppression" => (defaultArg x true))
    /// Hints at the type of data that might be entered by the user while editing the input
    ///             
    [<CustomOperation("InputMode")>] member inline _.InputMode ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.InputMode) = render ==> ("InputMode" => x)
    /// The pattern attribute, when specified, is a regular expression which the input's value must match in order for the value to pass constraint validation. It must be a valid JavaScript regular expression
    /// Not Supported in multline input
    [<CustomOperation("Pattern")>] member inline _.Pattern ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Pattern" => x)
    /// ShrinkLabel prevents the label from moving down into the field when the field is empty.
    [<CustomOperation("ShrinkLabel")>] member inline _.ShrinkLabel ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("ShrinkLabel" => (defaultArg x true))
    /// Fired when the text value changes.
    [<CustomOperation("TextChanged")>] member inline _.TextChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.String -> unit) = render ==> html.callback("TextChanged", fn)
    /// Fired when the text value changes.
    [<CustomOperation("TextChanged")>] member inline _.TextChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.String -> Task<unit>) = render ==> html.callbackTask("TextChanged", fn)
    /// Fired when the element loses focus.
    [<CustomOperation("OnBlur")>] member inline _.OnBlur ([<InlineIfLambda>] render: AttrRenderFragment, fn: Microsoft.AspNetCore.Components.Web.FocusEventArgs -> unit) = render ==> html.callback("OnBlur", fn)
    /// Fired when the element loses focus.
    [<CustomOperation("OnBlur")>] member inline _.OnBlur ([<InlineIfLambda>] render: AttrRenderFragment, fn: Microsoft.AspNetCore.Components.Web.FocusEventArgs -> Task<unit>) = render ==> html.callbackTask("OnBlur", fn)
    /// Fired when the element changes internally its text value.
    [<CustomOperation("OnInternalInputChanged")>] member inline _.OnInternalInputChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: Microsoft.AspNetCore.Components.ChangeEventArgs -> unit) = render ==> html.callback("OnInternalInputChanged", fn)
    /// Fired when the element changes internally its text value.
    [<CustomOperation("OnInternalInputChanged")>] member inline _.OnInternalInputChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: Microsoft.AspNetCore.Components.ChangeEventArgs -> Task<unit>) = render ==> html.callbackTask("OnInternalInputChanged", fn)
    /// Fired on the KeyDown event.
    [<CustomOperation("OnKeyDown")>] member inline _.OnKeyDown ([<InlineIfLambda>] render: AttrRenderFragment, fn: Microsoft.AspNetCore.Components.Web.KeyboardEventArgs -> unit) = render ==> html.callback("OnKeyDown", fn)
    /// Fired on the KeyDown event.
    [<CustomOperation("OnKeyDown")>] member inline _.OnKeyDown ([<InlineIfLambda>] render: AttrRenderFragment, fn: Microsoft.AspNetCore.Components.Web.KeyboardEventArgs -> Task<unit>) = render ==> html.callbackTask("OnKeyDown", fn)
    /// Prevent the default action for the KeyDown event.
    [<CustomOperation("KeyDownPreventDefault")>] member inline _.KeyDownPreventDefault ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("KeyDownPreventDefault" => (defaultArg x true))
    /// Fired on the KeyPress event.
    [<CustomOperation("OnKeyPress")>] member inline _.OnKeyPress ([<InlineIfLambda>] render: AttrRenderFragment, fn: Microsoft.AspNetCore.Components.Web.KeyboardEventArgs -> unit) = render ==> html.callback("OnKeyPress", fn)
    /// Fired on the KeyPress event.
    [<CustomOperation("OnKeyPress")>] member inline _.OnKeyPress ([<InlineIfLambda>] render: AttrRenderFragment, fn: Microsoft.AspNetCore.Components.Web.KeyboardEventArgs -> Task<unit>) = render ==> html.callbackTask("OnKeyPress", fn)
    /// Prevent the default action for the KeyPress event.
    [<CustomOperation("KeyPressPreventDefault")>] member inline _.KeyPressPreventDefault ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("KeyPressPreventDefault" => (defaultArg x true))
    /// Fired on the KeyUp event.
    [<CustomOperation("OnKeyUp")>] member inline _.OnKeyUp ([<InlineIfLambda>] render: AttrRenderFragment, fn: Microsoft.AspNetCore.Components.Web.KeyboardEventArgs -> unit) = render ==> html.callback("OnKeyUp", fn)
    /// Fired on the KeyUp event.
    [<CustomOperation("OnKeyUp")>] member inline _.OnKeyUp ([<InlineIfLambda>] render: AttrRenderFragment, fn: Microsoft.AspNetCore.Components.Web.KeyboardEventArgs -> Task<unit>) = render ==> html.callbackTask("OnKeyUp", fn)
    /// Prevent the default action for the KeyUp event.
    [<CustomOperation("KeyUpPreventDefault")>] member inline _.KeyUpPreventDefault ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("KeyUpPreventDefault" => (defaultArg x true))
    /// Fired when the Value property changes.
    [<CustomOperation("ValueChanged")>] member inline _.ValueChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: 'T -> unit) = render ==> html.callback("ValueChanged", fn)
    /// Fired when the Value property changes.
    [<CustomOperation("ValueChanged")>] member inline _.ValueChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: 'T -> Task<unit>) = render ==> html.callbackTask("ValueChanged", fn)
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
    /// User class names for the internal list item, separated by space.
    [<CustomOperation("ListItemClass")>] member inline _.ListItemClass ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("ListItemClass" => x)
    /// Set the anchor origin point to determen where the popover will open from.
    [<CustomOperation("AnchorOrigin")>] member inline _.AnchorOrigin ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Origin) = render ==> ("AnchorOrigin" => x)
    /// Sets the transform origin point for the popover.
    [<CustomOperation("TransformOrigin")>] member inline _.TransformOrigin ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Origin) = render ==> ("TransformOrigin" => x)
    /// If true, compact vertical padding will be applied to all Autocomplete items.
    [<CustomOperation("Dense")>] member inline _.Dense ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Dense" => (defaultArg x true))
    /// The Open Autocomplete Icon
    [<CustomOperation("OpenIcon")>] member inline _.OpenIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("OpenIcon" => x)
    /// The Close Autocomplete Icon
    [<CustomOperation("CloseIcon")>] member inline _.CloseIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("CloseIcon" => x)
    /// The maximum height of the Autocomplete when it is open.
    [<CustomOperation("MaxHeight")>] member inline _.MaxHeight ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("MaxHeight" => x)
    /// Defines how values are displayed in the drop-down list
    [<CustomOperation("ToStringFunc")>] member inline _.ToStringFunc ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("ToStringFunc" => (System.Func<'T, System.String>fn))
    /// Whether to show the progress indicator. 
    [<CustomOperation("ShowProgressIndicator")>] member inline _.ShowProgressIndicator ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("ShowProgressIndicator" => (defaultArg x true))
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
    [<CustomOperation("ResetValueOnEmptyText")>] member inline _.ResetValueOnEmptyText ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("ResetValueOnEmptyText" => (defaultArg x true))
    /// If true, clicking the text field will select (highlight) its contents.
    [<CustomOperation("SelectOnClick")>] member inline _.SelectOnClick ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("SelectOnClick" => (defaultArg x true))
    /// If false, clicking on the Autocomplete after selecting an option will query the Search method again with an empty string. This makes it easier to view and select other options without resetting the Value.
    /// T must either be a record or override GetHashCode and Equals.
    [<CustomOperation("Strict")>] member inline _.Strict ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Strict" => (defaultArg x true))
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
    /// Optional presentation template that is shown at the top of the list. If no items are present, the fragment is hidden.
    [<CustomOperation("BeforeItemsTemplate")>] member inline _.BeforeItemsTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragment) = render ==> html.renderFragment("BeforeItemsTemplate", fragment)
    /// Optional presentation template that is shown at the top of the list. If no items are present, the fragment is hidden.
    [<CustomOperation("BeforeItemsTemplate")>] member inline _.BeforeItemsTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragments) = render ==> html.renderFragment("BeforeItemsTemplate", fragment { yield! fragments })
    /// Optional presentation template that is shown at the top of the list. If no items are present, the fragment is hidden.
    [<CustomOperation("BeforeItemsTemplate")>] member inline _.BeforeItemsTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("BeforeItemsTemplate", html.text x)
    /// Optional presentation template that is shown at the top of the list. If no items are present, the fragment is hidden.
    [<CustomOperation("BeforeItemsTemplate")>] member inline _.BeforeItemsTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("BeforeItemsTemplate", html.text x)
    /// Optional presentation template that is shown at the top of the list. If no items are present, the fragment is hidden.
    [<CustomOperation("BeforeItemsTemplate")>] member inline _.BeforeItemsTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("BeforeItemsTemplate", html.text x)
    /// Optional presentation template that is shown at the bottom of the list. If no items are present, the fragment is hidden.
    [<CustomOperation("AfterItemsTemplate")>] member inline _.AfterItemsTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragment) = render ==> html.renderFragment("AfterItemsTemplate", fragment)
    /// Optional presentation template that is shown at the bottom of the list. If no items are present, the fragment is hidden.
    [<CustomOperation("AfterItemsTemplate")>] member inline _.AfterItemsTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragments) = render ==> html.renderFragment("AfterItemsTemplate", fragment { yield! fragments })
    /// Optional presentation template that is shown at the bottom of the list. If no items are present, the fragment is hidden.
    [<CustomOperation("AfterItemsTemplate")>] member inline _.AfterItemsTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("AfterItemsTemplate", html.text x)
    /// Optional presentation template that is shown at the bottom of the list. If no items are present, the fragment is hidden.
    [<CustomOperation("AfterItemsTemplate")>] member inline _.AfterItemsTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("AfterItemsTemplate", html.text x)
    /// Optional presentation template that is shown at the bottom of the list. If no items are present, the fragment is hidden.
    [<CustomOperation("AfterItemsTemplate")>] member inline _.AfterItemsTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("AfterItemsTemplate", html.text x)
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
    [<CustomOperation("CoerceText")>] member inline _.CoerceText ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("CoerceText" => (defaultArg x true))
    /// If user input is not found by the search func and CoerceValue is set to true the user input
    /// will be applied to the Value which allows to validate it and display an error message.
    [<CustomOperation("CoerceValue")>] member inline _.CoerceValue ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("CoerceValue" => (defaultArg x true))
    /// Function to be invoked when checking whether an item should be disabled or not
    [<CustomOperation("ItemDisabledFunc")>] member inline _.ItemDisabledFunc ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("ItemDisabledFunc" => (System.Func<'T, System.Boolean>fn))
    /// An event triggered when the state of IsOpen has changed
    [<CustomOperation("IsOpenChanged")>] member inline _.IsOpenChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.Boolean -> unit) = render ==> html.callback("IsOpenChanged", fn)
    /// An event triggered when the state of IsOpen has changed
    [<CustomOperation("IsOpenChanged")>] member inline _.IsOpenChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.Boolean -> Task<unit>) = render ==> html.callbackTask("IsOpenChanged", fn)
    /// If true, the currently selected item from the drop-down (if it is open) is selected.
    [<CustomOperation("SelectValueOnTab")>] member inline _.SelectValueOnTab ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("SelectValueOnTab" => (defaultArg x true))
    /// Show clear button.
    [<CustomOperation("Clearable")>] member inline _.Clearable ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Clearable" => (defaultArg x true))
    /// Button click event for clear button. Called after text and value has been cleared.
    [<CustomOperation("OnClearButtonClick")>] member inline _.OnClearButtonClick ([<InlineIfLambda>] render: AttrRenderFragment, fn: Microsoft.AspNetCore.Components.Web.MouseEventArgs -> unit) = render ==> html.callback("OnClearButtonClick", fn)
    /// Button click event for clear button. Called after text and value has been cleared.
    [<CustomOperation("OnClearButtonClick")>] member inline _.OnClearButtonClick ([<InlineIfLambda>] render: AttrRenderFragment, fn: Microsoft.AspNetCore.Components.Web.MouseEventArgs -> Task<unit>) = render ==> html.callbackTask("OnClearButtonClick", fn)
    /// An event triggered when the number of items returned by the search query has changed.
    /// 
    /// If the number is 0,  will be shown.
    /// If the number is beyond ,  will be shown.
    [<CustomOperation("ReturnedItemsCountChanged")>] member inline _.ReturnedItemsCountChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.Int32 -> unit) = render ==> html.callback("ReturnedItemsCountChanged", fn)
    /// An event triggered when the number of items returned by the search query has changed.
    /// 
    /// If the number is 0,  will be shown.
    /// If the number is beyond ,  will be shown.
    [<CustomOperation("ReturnedItemsCountChanged")>] member inline _.ReturnedItemsCountChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.Int32 -> Task<unit>) = render ==> html.callbackTask("ReturnedItemsCountChanged", fn)

type MudDebouncedInputBuilder<'FunBlazorGeneric, 'T when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudBaseInputBuilder<'FunBlazorGeneric, 'T>()
    /// Interval to be awaited in milliseconds before changing the Text value
    [<CustomOperation("DebounceInterval")>] member inline _.DebounceInterval ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Double) = render ==> ("DebounceInterval" => x)
    /// callback to be called when the debounce interval has elapsed
    /// receives the Text as a parameter
    [<CustomOperation("OnDebounceIntervalElapsed")>] member inline _.OnDebounceIntervalElapsed ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.String -> unit) = render ==> html.callback("OnDebounceIntervalElapsed", fn)
    /// callback to be called when the debounce interval has elapsed
    /// receives the Text as a parameter
    [<CustomOperation("OnDebounceIntervalElapsed")>] member inline _.OnDebounceIntervalElapsed ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.String -> Task<unit>) = render ==> html.callbackTask("OnDebounceIntervalElapsed", fn)

type MudNumericFieldBuilder<'FunBlazorGeneric, 'T when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudDebouncedInputBuilder<'FunBlazorGeneric, 'T>()
    /// Show clear button.
    [<CustomOperation("Clearable")>] member inline _.Clearable ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Clearable" => (defaultArg x true))
    /// Reverts mouse wheel up and down events, if true.
    [<CustomOperation("InvertMouseWheel")>] member inline _.InvertMouseWheel ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("InvertMouseWheel" => (defaultArg x true))
    /// The minimum value for the input.
    [<CustomOperation("Min")>] member inline _.Min ([<InlineIfLambda>] render: AttrRenderFragment, x: 'T) = render ==> ("Min" => x)
    /// The maximum value for the input.
    [<CustomOperation("Max")>] member inline _.Max ([<InlineIfLambda>] render: AttrRenderFragment, x: 'T) = render ==> ("Max" => x)
    /// The increment added/subtracted by the spin buttons.
    [<CustomOperation("Step")>] member inline _.Step ([<InlineIfLambda>] render: AttrRenderFragment, x: 'T) = render ==> ("Step" => x)
    /// Hides the spin buttons, the user can still change value with keyboard arrows and manual update.
    [<CustomOperation("HideSpinButtons")>] member inline _.HideSpinButtons ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("HideSpinButtons" => (defaultArg x true))
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
    [<CustomOperation("Clearable")>] member inline _.Clearable ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Clearable" => (defaultArg x true))
    /// Button click event for clear button. Called after text and value has been cleared.
    [<CustomOperation("OnClearButtonClick")>] member inline _.OnClearButtonClick ([<InlineIfLambda>] render: AttrRenderFragment, fn: Microsoft.AspNetCore.Components.Web.MouseEventArgs -> unit) = render ==> html.callback("OnClearButtonClick", fn)
    /// Button click event for clear button. Called after text and value has been cleared.
    [<CustomOperation("OnClearButtonClick")>] member inline _.OnClearButtonClick ([<InlineIfLambda>] render: AttrRenderFragment, fn: Microsoft.AspNetCore.Components.Web.MouseEventArgs -> Task<unit>) = render ==> html.callbackTask("OnClearButtonClick", fn)
    /// Provide a masking object. Built-in masks are PatternMask, MultiMask, RegexMask and BlockMask
    /// Note: when Mask is set, TextField will ignore some properties such as Lines, Pattern or HideSpinButtons, OnKeyDown and OnKeyUp, etc.
    [<CustomOperation("Mask")>] member inline _.Mask ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.IMask) = render ==> ("Mask" => x)
    /// If true the input element will grow automatically with the text.
    [<CustomOperation("AutoGrow")>] member inline _.AutoGrow ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("AutoGrow" => (defaultArg x true))
    /// If AutoGrow is set to true, the input element will not grow bigger than MaxLines lines. If MaxLines is set to 0
    /// or less, the property will be ignored.
    [<CustomOperation("MaxLines")>] member inline _.MaxLines ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("MaxLines" => x)

type MudInputBuilder<'FunBlazorGeneric, 'T when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudBaseInputBuilder<'FunBlazorGeneric, 'T>()
    /// Type of the input element. It should be a valid HTML5 input type.
    [<CustomOperation("InputType")>] member inline _.InputType ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.InputType) = render ==> ("InputType" => x)
    /// Invokes the callback when the Up arrow button is clicked when the input is set to Number.
    /// Note: use the optimized control MudNumericField`1 if you need to deal with numbers.
    [<CustomOperation("OnIncrement")>] member inline _.OnIncrement ([<InlineIfLambda>] render: AttrRenderFragment, fn: unit -> unit) = render ==> html.callback("OnIncrement", fn)
    /// Invokes the callback when the Up arrow button is clicked when the input is set to Number.
    /// Note: use the optimized control MudNumericField`1 if you need to deal with numbers.
    [<CustomOperation("OnIncrement")>] member inline _.OnIncrement ([<InlineIfLambda>] render: AttrRenderFragment, fn: unit -> Task<unit>) = render ==> html.callbackTask("OnIncrement", fn)
    /// Invokes the callback when the Down arrow button is clicked when the input is set to Number.
    /// Note: use the optimized control MudNumericField`1 if you need to deal with numbers.
    [<CustomOperation("OnDecrement")>] member inline _.OnDecrement ([<InlineIfLambda>] render: AttrRenderFragment, fn: unit -> unit) = render ==> html.callback("OnDecrement", fn)
    /// Invokes the callback when the Down arrow button is clicked when the input is set to Number.
    /// Note: use the optimized control MudNumericField`1 if you need to deal with numbers.
    [<CustomOperation("OnDecrement")>] member inline _.OnDecrement ([<InlineIfLambda>] render: AttrRenderFragment, fn: unit -> Task<unit>) = render ==> html.callbackTask("OnDecrement", fn)
    /// Hides the spin buttons for MudNumericField`1
    [<CustomOperation("HideSpinButtons")>] member inline _.HideSpinButtons ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("HideSpinButtons" => (defaultArg x true))
    /// Show clear button.
    [<CustomOperation("Clearable")>] member inline _.Clearable ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Clearable" => (defaultArg x true))
    /// Button click event for clear button. Called after text and value has been cleared.
    [<CustomOperation("OnClearButtonClick")>] member inline _.OnClearButtonClick ([<InlineIfLambda>] render: AttrRenderFragment, fn: Microsoft.AspNetCore.Components.Web.MouseEventArgs -> unit) = render ==> html.callback("OnClearButtonClick", fn)
    /// Button click event for clear button. Called after text and value has been cleared.
    [<CustomOperation("OnClearButtonClick")>] member inline _.OnClearButtonClick ([<InlineIfLambda>] render: AttrRenderFragment, fn: Microsoft.AspNetCore.Components.Web.MouseEventArgs -> Task<unit>) = render ==> html.callbackTask("OnClearButtonClick", fn)
    /// Mouse wheel event for input.
    [<CustomOperation("OnMouseWheel")>] member inline _.OnMouseWheel ([<InlineIfLambda>] render: AttrRenderFragment, fn: Microsoft.AspNetCore.Components.Web.WheelEventArgs -> unit) = render ==> html.callback("OnMouseWheel", fn)
    /// Mouse wheel event for input.
    [<CustomOperation("OnMouseWheel")>] member inline _.OnMouseWheel ([<InlineIfLambda>] render: AttrRenderFragment, fn: Microsoft.AspNetCore.Components.Web.WheelEventArgs -> Task<unit>) = render ==> html.callbackTask("OnMouseWheel", fn)
    /// Custom clear icon.
    [<CustomOperation("ClearIcon")>] member inline _.ClearIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("ClearIcon" => x)
    /// Custom numeric up icon.
    [<CustomOperation("NumericUpIcon")>] member inline _.NumericUpIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("NumericUpIcon" => x)
    /// Custom numeric down icon.
    [<CustomOperation("NumericDownIcon")>] member inline _.NumericDownIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("NumericDownIcon" => x)
    /// If true the input element will grow automatically with the text.
    [<CustomOperation("AutoGrow")>] member inline _.AutoGrow ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("AutoGrow" => (defaultArg x true))
    /// If AutoGrow is set to true, the input element will not grow bigger than MaxLines lines. If MaxLines is set to 0
    /// or less, the property will be ignored.
    [<CustomOperation("MaxLines")>] member inline _.MaxLines ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("MaxLines" => x)

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
    /// Button click event for clear button. Called after text and value has been cleared.
    [<CustomOperation("OnClearButtonClick")>] member inline _.OnClearButtonClick ([<InlineIfLambda>] render: AttrRenderFragment, fn: Microsoft.AspNetCore.Components.Web.MouseEventArgs -> unit) = render ==> html.callback("OnClearButtonClick", fn)
    /// Button click event for clear button. Called after text and value has been cleared.
    [<CustomOperation("OnClearButtonClick")>] member inline _.OnClearButtonClick ([<InlineIfLambda>] render: AttrRenderFragment, fn: Microsoft.AspNetCore.Components.Web.MouseEventArgs -> Task<unit>) = render ==> html.callbackTask("OnClearButtonClick", fn)
    /// Show clear button.
    [<CustomOperation("Clearable")>] member inline _.Clearable ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Clearable" => (defaultArg x true))
    /// Custom separator icon, leave null for default.
    [<CustomOperation("SeparatorIcon")>] member inline _.SeparatorIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("SeparatorIcon" => x)

type MudMaskBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudBaseInputBuilder<'FunBlazorGeneric, System.String>()
    /// Provide a masking object. Built-in masks are PatternMask, MultiMask, RegexMask and BlockMask
    [<CustomOperation("Mask")>] member inline _.Mask ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.IMask) = render ==> ("Mask" => x)
    /// Type of the input element. It should be a valid HTML5 input type.
    [<CustomOperation("InputType")>] member inline _.InputType ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.InputType) = render ==> ("InputType" => x)
    /// Show clear button.
    [<CustomOperation("Clearable")>] member inline _.Clearable ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Clearable" => (defaultArg x true))
    /// Button click event for clear button. Called after text and value has been cleared.
    [<CustomOperation("OnClearButtonClick")>] member inline _.OnClearButtonClick ([<InlineIfLambda>] render: AttrRenderFragment, fn: Microsoft.AspNetCore.Components.Web.MouseEventArgs -> unit) = render ==> html.callback("OnClearButtonClick", fn)
    /// Button click event for clear button. Called after text and value has been cleared.
    [<CustomOperation("OnClearButtonClick")>] member inline _.OnClearButtonClick ([<InlineIfLambda>] render: AttrRenderFragment, fn: Microsoft.AspNetCore.Components.Web.MouseEventArgs -> Task<unit>) = render ==> html.callbackTask("OnClearButtonClick", fn)
    /// Custom clear icon.
    [<CustomOperation("ClearIcon")>] member inline _.ClearIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("ClearIcon" => x)

type MudSelectBuilder<'FunBlazorGeneric, 'T when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudBaseInputBuilder<'FunBlazorGeneric, 'T>()
    /// The outer div's classnames, seperated by space.
    [<CustomOperation("OuterClass")>] member inline _.OuterClass ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("OuterClass" => x)
    /// Input's classnames, seperated by space.
    [<CustomOperation("InputClass")>] member inline _.InputClass ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("InputClass" => x)
    /// Fired when dropdown opens.
    [<CustomOperation("OnOpen")>] member inline _.OnOpen ([<InlineIfLambda>] render: AttrRenderFragment, fn: unit -> unit) = render ==> html.callback("OnOpen", fn)
    /// Fired when dropdown opens.
    [<CustomOperation("OnOpen")>] member inline _.OnOpen ([<InlineIfLambda>] render: AttrRenderFragment, fn: unit -> Task<unit>) = render ==> html.callbackTask("OnOpen", fn)
    /// Fired when dropdown closes.
    [<CustomOperation("OnClose")>] member inline _.OnClose ([<InlineIfLambda>] render: AttrRenderFragment, fn: unit -> unit) = render ==> html.callback("OnClose", fn)
    /// Fired when dropdown closes.
    [<CustomOperation("OnClose")>] member inline _.OnClose ([<InlineIfLambda>] render: AttrRenderFragment, fn: unit -> Task<unit>) = render ==> html.callbackTask("OnClose", fn)
    /// User class names for the popover, separated by space
    [<CustomOperation("PopoverClass")>] member inline _.PopoverClass ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("PopoverClass" => x)
    /// User class names for the internal list, separated by space
    [<CustomOperation("ListClass")>] member inline _.ListClass ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("ListClass" => x)
    /// If true, compact vertical padding will be applied to all Select items.
    [<CustomOperation("Dense")>] member inline _.Dense ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Dense" => (defaultArg x true))
    /// The Open Select Icon
    [<CustomOperation("OpenIcon")>] member inline _.OpenIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("OpenIcon" => x)
    /// The Close Select Icon
    [<CustomOperation("CloseIcon")>] member inline _.CloseIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("CloseIcon" => x)
    /// If set to true and the MultiSelection option is set to true, a "select all" checkbox is added at the top of the list of items.
    [<CustomOperation("SelectAll")>] member inline _.SelectAll ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("SelectAll" => (defaultArg x true))
    /// Define the text of the Select All option.
    [<CustomOperation("SelectAllText")>] member inline _.SelectAllText ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("SelectAllText" => x)
    /// Fires when SelectedValues changes.
    [<CustomOperation("SelectedValuesChanged")>] member inline _.SelectedValuesChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.Collections.Generic.IEnumerable<'T> -> unit) = render ==> html.callback("SelectedValuesChanged", fn)
    /// Fires when SelectedValues changes.
    [<CustomOperation("SelectedValuesChanged")>] member inline _.SelectedValuesChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.Collections.Generic.IEnumerable<'T> -> Task<unit>) = render ==> html.callbackTask("SelectedValuesChanged", fn)
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
    [<CustomOperation("MultiSelection")>] member inline _.MultiSelection ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("MultiSelection" => (defaultArg x true))
    /// Sets the maxheight the Select can have when open.
    [<CustomOperation("MaxHeight")>] member inline _.MaxHeight ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("MaxHeight" => x)
    /// Set the anchor origin point to determen where the popover will open from.
    [<CustomOperation("AnchorOrigin")>] member inline _.AnchorOrigin ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Origin) = render ==> ("AnchorOrigin" => x)
    /// Sets the transform origin point for the popover.
    [<CustomOperation("TransformOrigin")>] member inline _.TransformOrigin ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Origin) = render ==> ("TransformOrigin" => x)
    /// If true, the Select's input will not show any values that are not defined in the dropdown.
    /// This can be useful if Value is bound to a variable which is initialized to a value which is not in the list
    /// and you want the Select to show the label / placeholder instead.
    [<CustomOperation("Strict")>] member inline _.Strict ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Strict" => (defaultArg x true))
    /// Show clear button.
    [<CustomOperation("Clearable")>] member inline _.Clearable ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Clearable" => (defaultArg x true))
    /// If true, prevent scrolling while dropdown is open.
    [<CustomOperation("LockScroll")>] member inline _.LockScroll ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("LockScroll" => (defaultArg x true))
    /// Button click event for clear button. Called after text and value has been cleared.
    [<CustomOperation("OnClearButtonClick")>] member inline _.OnClearButtonClick ([<InlineIfLambda>] render: AttrRenderFragment, fn: Microsoft.AspNetCore.Components.Web.MouseEventArgs -> unit) = render ==> html.callback("OnClearButtonClick", fn)
    /// Button click event for clear button. Called after text and value has been cleared.
    [<CustomOperation("OnClearButtonClick")>] member inline _.OnClearButtonClick ([<InlineIfLambda>] render: AttrRenderFragment, fn: Microsoft.AspNetCore.Components.Web.MouseEventArgs -> Task<unit>) = render ==> html.callbackTask("OnClearButtonClick", fn)
    /// Custom checked icon.
    [<CustomOperation("CheckedIcon")>] member inline _.CheckedIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("CheckedIcon" => x)
    /// Custom unchecked icon.
    [<CustomOperation("UncheckedIcon")>] member inline _.UncheckedIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("UncheckedIcon" => x)
    /// Custom indeterminate icon.
    [<CustomOperation("IndeterminateIcon")>] member inline _.IndeterminateIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("IndeterminateIcon" => x)

type MudBooleanInputBuilder<'FunBlazorGeneric, 'T when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudFormComponentBuilder<'FunBlazorGeneric, 'T, System.Nullable<System.Boolean>>()
    /// If true, the input element will be disabled.
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Disabled" => (defaultArg x true))
    /// If true, the input will be read-only.
    [<CustomOperation("ReadOnly")>] member inline _.ReadOnly ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("ReadOnly" => (defaultArg x true))
    /// The state of the component
    [<CustomOperation("Checked")>] member inline _.Checked ([<InlineIfLambda>] render: AttrRenderFragment, x: 'T) = render ==> ("Checked" => x)
    /// The state of the component
    [<CustomOperation("Checked'")>] member inline _.Checked' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: 'T * ('T -> unit)) = render ==> html.bind("Checked", valueFn)
    /// The state of the component
    [<CustomOperation("Value")>] member inline _.Value ([<InlineIfLambda>] render: AttrRenderFragment, x: 'T) = render ==> ("Value" => x)
    /// The state of the component
    [<CustomOperation("Value'")>] member inline _.Value' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: 'T * ('T -> unit)) = render ==> html.bind("Value", valueFn)
    /// If true will prevent the click from bubbling up the event tree.
    [<CustomOperation("StopClickPropagation")>] member inline _.StopClickPropagation ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("StopClickPropagation" => (defaultArg x true))
    /// Fired when Value changes.
    [<CustomOperation("ValueChanged")>] member inline _.ValueChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: 'T -> unit) = render ==> html.callback("ValueChanged", fn)
    /// Fired when Value changes.
    [<CustomOperation("ValueChanged")>] member inline _.ValueChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: 'T -> Task<unit>) = render ==> html.callbackTask("ValueChanged", fn)
    /// Fired when Checked changes.
    [<CustomOperation("CheckedChanged")>] member inline _.CheckedChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: 'T -> unit) = render ==> html.callback("CheckedChanged", fn)
    /// Fired when Checked changes.
    [<CustomOperation("CheckedChanged")>] member inline _.CheckedChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: 'T -> Task<unit>) = render ==> html.callbackTask("CheckedChanged", fn)

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
    [<CustomOperation("KeyboardEnabled")>] member inline _.KeyboardEnabled ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("KeyboardEnabled" => (defaultArg x true))
    /// If true, disables ripple effect.
    [<CustomOperation("DisableRipple")>] member inline _.DisableRipple ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("DisableRipple" => (defaultArg x true))
    /// If true, compact padding will be applied.
    [<CustomOperation("Dense")>] member inline _.Dense ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Dense" => (defaultArg x true))
    /// The Size of the component.
    [<CustomOperation("Size")>] member inline _.Size ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Size) = render ==> ("Size" => x)
    /// Custom checked icon, leave null for default.
    [<CustomOperation("CheckedIcon")>] member inline _.CheckedIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("CheckedIcon" => x)
    /// Custom unchecked icon, leave null for default.
    [<CustomOperation("UncheckedIcon")>] member inline _.UncheckedIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("UncheckedIcon" => x)
    /// Custom indeterminate icon, leave null for default.
    [<CustomOperation("IndeterminateIcon")>] member inline _.IndeterminateIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("IndeterminateIcon" => x)
    /// Define if the checkbox can cycle again through indeterminate status.
    [<CustomOperation("TriState")>] member inline _.TriState ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("TriState" => (defaultArg x true))

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
    [<CustomOperation("DisableRipple")>] member inline _.DisableRipple ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("DisableRipple" => (defaultArg x true))
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
    [<CustomOperation("FilesChanged")>] member inline _.FilesChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: 'T -> unit) = render ==> html.callback("FilesChanged", fn)
    /// Triggered when the internal OnChange event fires
    [<CustomOperation("FilesChanged")>] member inline _.FilesChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: 'T -> Task<unit>) = render ==> html.callbackTask("FilesChanged", fn)
    /// Called when the internal files are changed
    [<CustomOperation("OnFilesChanged")>] member inline _.OnFilesChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: Microsoft.AspNetCore.Components.Forms.InputFileChangeEventArgs -> unit) = render ==> html.callback("OnFilesChanged", fn)
    /// Called when the internal files are changed
    [<CustomOperation("OnFilesChanged")>] member inline _.OnFilesChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: Microsoft.AspNetCore.Components.Forms.InputFileChangeEventArgs -> Task<unit>) = render ==> html.callbackTask("OnFilesChanged", fn)
    /// If true, when T is of type IReadOnlyList, additional files will be appended to the existing list
    [<CustomOperation("AppendMultipleFiles")>] member inline _.AppendMultipleFiles ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("AppendMultipleFiles" => (defaultArg x true))
    /// Renders the button that triggers the input. Required for functioning.
    [<CustomOperation("ButtonTemplate")>] member inline _.ButtonTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fn: MudBlazor.FileUploadButtonTemplateContext<'T> -> NodeRenderFragment) = render ==> html.renderFragment("ButtonTemplate", fn)
    /// Renders the selected files, if desired.
    [<CustomOperation("SelectedTemplate")>] member inline _.SelectedTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fn: 'T -> NodeRenderFragment) = render ==> html.renderFragment("SelectedTemplate", fn)
    /// If true, OnFilesChanged will not trigger if validation fails
    [<CustomOperation("SuppressOnChangeWhenInvalid")>] member inline _.SuppressOnChangeWhenInvalid ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("SuppressOnChangeWhenInvalid" => (defaultArg x true))
    /// Sets the file types this input will accept
    [<CustomOperation("Accept")>] member inline _.Accept ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Accept" => x)
    /// If false, the inner FileInput will be visible
    [<CustomOperation("Hidden")>] member inline _.Hidden ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Hidden" => (defaultArg x true))
    /// Css classes to apply to the internal InputFile
    [<CustomOperation("InputClass")>] member inline _.InputClass ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("InputClass" => x)
    /// Style to apply to the internal InputFile
    [<CustomOperation("InputStyle")>] member inline _.InputStyle ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("InputStyle" => x)
    /// Represents the maximum number of files that can retrieved from the internal call to
    /// InputFileChangeEventArgs.GetMultipleFiles().
    /// It does not limit the total number of uploaded files
    /// when AppendMultipleFiles="true". A limit should be validated manually, for
    /// example in the FilesChanged event callback.
    [<CustomOperation("MaximumFileCount")>] member inline _.MaximumFileCount ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("MaximumFileCount" => x)
    /// Disables the FileUpload
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Disabled" => (defaultArg x true))

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
    [<CustomOperation("PickerOpened")>] member inline _.PickerOpened ([<InlineIfLambda>] render: AttrRenderFragment, fn: unit -> unit) = render ==> html.callback("PickerOpened", fn)
    /// Fired when the dropdown / dialog opens
    [<CustomOperation("PickerOpened")>] member inline _.PickerOpened ([<InlineIfLambda>] render: AttrRenderFragment, fn: unit -> Task<unit>) = render ==> html.callbackTask("PickerOpened", fn)
    /// Fired when the dropdown / dialog closes
    [<CustomOperation("PickerClosed")>] member inline _.PickerClosed ([<InlineIfLambda>] render: AttrRenderFragment, fn: unit -> unit) = render ==> html.callback("PickerClosed", fn)
    /// Fired when the dropdown / dialog closes
    [<CustomOperation("PickerClosed")>] member inline _.PickerClosed ([<InlineIfLambda>] render: AttrRenderFragment, fn: unit -> Task<unit>) = render ==> html.callbackTask("PickerClosed", fn)
    /// The higher the number, the heavier the drop-shadow. 0 for no shadow set to 8 by default in inline mode and 0 in static mode.
    [<CustomOperation("Elevation")>] member inline _.Elevation ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("Elevation" => x)
    /// If true, border-radius is set to 0 this is set to true automatically in static mode but can be overridden with Rounded bool.
    [<CustomOperation("Square")>] member inline _.Square ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Square" => (defaultArg x true))
    /// If true, border-radius is set to theme default when in Static Mode.
    [<CustomOperation("Rounded")>] member inline _.Rounded ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Rounded" => (defaultArg x true))
    /// If string has value, HelperText will be applied.
    [<CustomOperation("HelperText")>] member inline _.HelperText ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("HelperText" => x)
    /// If true, the helper text will only be visible on focus.
    [<CustomOperation("HelperTextOnFocus")>] member inline _.HelperTextOnFocus ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("HelperTextOnFocus" => (defaultArg x true))
    /// If string has value the label text will be displayed in the input, and scaled down at the top if the input has value.
    [<CustomOperation("Label")>] member inline _.Label ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Label" => x)
    /// Show clear button.
    [<CustomOperation("Clearable")>] member inline _.Clearable ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Clearable" => (defaultArg x true))
    /// If true, the picker will be disabled.
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Disabled" => (defaultArg x true))
    /// If true, the input will not have an underline.
    [<CustomOperation("DisableUnderLine")>] member inline _.DisableUnderLine ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("DisableUnderLine" => (defaultArg x true))
    /// If true, no date or time can be defined.
    [<CustomOperation("ReadOnly")>] member inline _.ReadOnly ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("ReadOnly" => (defaultArg x true))
    /// If true, the picker will be editable.
    [<CustomOperation("Editable")>] member inline _.Editable ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Editable" => (defaultArg x true))
    /// Hide toolbar and show only date/time views.
    [<CustomOperation("DisableToolbar")>] member inline _.DisableToolbar ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("DisableToolbar" => (defaultArg x true))
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
    [<CustomOperation("AllowKeyboardInput")>] member inline _.AllowKeyboardInput ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("AllowKeyboardInput" => (defaultArg x true))
    /// Fired when the text changes.
    [<CustomOperation("TextChanged")>] member inline _.TextChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.String -> unit) = render ==> html.callback("TextChanged", fn)
    /// Fired when the text changes.
    [<CustomOperation("TextChanged")>] member inline _.TextChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.String -> Task<unit>) = render ==> html.callbackTask("TextChanged", fn)
    /// If true and Editable is true, update Text immediately on typing.
    /// If false, Text is updated only on Enter or loss of focus.
    [<CustomOperation("ImmediateText")>] member inline _.ImmediateText ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("ImmediateText" => (defaultArg x true))
    /// Fired when the text input is clicked.
    [<CustomOperation("OnClick")>] member inline _.OnClick ([<InlineIfLambda>] render: AttrRenderFragment, fn: Microsoft.AspNetCore.Components.Web.MouseEventArgs -> unit) = render ==> html.callback("OnClick", fn)
    /// Fired when the text input is clicked.
    [<CustomOperation("OnClick")>] member inline _.OnClick ([<InlineIfLambda>] render: AttrRenderFragment, fn: Microsoft.AspNetCore.Components.Web.MouseEventArgs -> Task<unit>) = render ==> html.callbackTask("OnClick", fn)
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
    [<CustomOperation("PickerMonthChanged")>] member inline _.PickerMonthChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.Nullable<System.DateTime> -> unit) = render ==> html.callback("PickerMonthChanged", fn)
    /// Fired when the date changes.
    [<CustomOperation("PickerMonthChanged")>] member inline _.PickerMonthChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.Nullable<System.DateTime> -> Task<unit>) = render ==> html.callbackTask("PickerMonthChanged", fn)
    /// Sets the amount of time in milliseconds to wait before closing the picker. This helps the user see that the date was selected before the popover disappears.
    [<CustomOperation("ClosingDelay")>] member inline _.ClosingDelay ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("ClosingDelay" => x)
    /// Number of months to display in the calendar
    [<CustomOperation("DisplayMonths")>] member inline _.DisplayMonths ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("DisplayMonths" => x)
    /// Maximum number of months in one row
    [<CustomOperation("MaxMonthColumns")>] member inline _.MaxMonthColumns ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Int32>) = render ==> ("MaxMonthColumns" => x)
    /// Start month when opening the picker. 
    [<CustomOperation("StartMonth")>] member inline _.StartMonth ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.DateTime>) = render ==> ("StartMonth" => x)
    /// Display week numbers according to the Culture parameter. If no culture is defined, CultureInfo.CurrentCulture will be used.
    [<CustomOperation("ShowWeekNumbers")>] member inline _.ShowWeekNumbers ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("ShowWeekNumbers" => (defaultArg x true))
    /// Format of the selected date in the title. By default, this is "ddd, dd MMM" which abbreviates day and month names. 
    /// For instance, display the long names like this "dddd, dd. MMMM". 
    [<CustomOperation("TitleDateFormat")>] member inline _.TitleDateFormat ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("TitleDateFormat" => x)
    /// If AutoClose is set to true and PickerActions are defined, selecting a day will close the MudDatePicker.
    [<CustomOperation("AutoClose")>] member inline _.AutoClose ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("AutoClose" => (defaultArg x true))
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
    [<CustomOperation("DateChanged")>] member inline _.DateChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.Nullable<System.DateTime> -> unit) = render ==> html.callback("DateChanged", fn)
    /// Fired when the DateFormat changes.
    [<CustomOperation("DateChanged")>] member inline _.DateChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.Nullable<System.DateTime> -> Task<unit>) = render ==> html.callbackTask("DateChanged", fn)
    /// The currently selected date (two-way bindable). If null, then nothing was selected.
    [<CustomOperation("Date")>] member inline _.Date ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.DateTime>) = render ==> ("Date" => x)
    /// The currently selected date (two-way bindable). If null, then nothing was selected.
    [<CustomOperation("Date'")>] member inline _.Date' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.Nullable<System.DateTime> * (System.Nullable<System.DateTime> -> unit)) = render ==> html.bind("Date", valueFn)

type MudDateRangePickerBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudBaseDatePickerBuilder<'FunBlazorGeneric>()
    /// Fired when the DateFormat changes.
    [<CustomOperation("DateRangeChanged")>] member inline _.DateRangeChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: MudBlazor.DateRange -> unit) = render ==> html.callback("DateRangeChanged", fn)
    /// Fired when the DateFormat changes.
    [<CustomOperation("DateRangeChanged")>] member inline _.DateRangeChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: MudBlazor.DateRange -> Task<unit>) = render ==> html.callbackTask("DateRangeChanged", fn)
    /// The currently selected range (two-way bindable). If null, then nothing was selected.
    [<CustomOperation("DateRange")>] member inline _.DateRange ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.DateRange) = render ==> ("DateRange" => x)
    /// The currently selected range (two-way bindable). If null, then nothing was selected.
    [<CustomOperation("DateRange'")>] member inline _.DateRange' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: MudBlazor.DateRange * (MudBlazor.DateRange -> unit)) = render ==> html.bind("DateRange", valueFn)

type MudColorPickerBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudPickerBuilder<'FunBlazorGeneric, MudBlazor.Utilities.MudColor>()
    /// If true, Alpha options will not be displayed and color output will be RGB, HSL or HEX and not RGBA, HSLA or HEXA.
    [<CustomOperation("DisableAlpha")>] member inline _.DisableAlpha ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("DisableAlpha" => (defaultArg x true))
    /// If true, the color field will not be displayed.
    [<CustomOperation("DisableColorField")>] member inline _.DisableColorField ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("DisableColorField" => (defaultArg x true))
    /// If true, the switch to change color mode will not be displayed.
    [<CustomOperation("DisableModeSwitch")>] member inline _.DisableModeSwitch ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("DisableModeSwitch" => (defaultArg x true))
    /// If true, textfield inputs and color mode switch will not be displayed.
    [<CustomOperation("DisableInputs")>] member inline _.DisableInputs ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("DisableInputs" => (defaultArg x true))
    /// If true, hue and alpha sliders will not be displayed.
    [<CustomOperation("DisableSliders")>] member inline _.DisableSliders ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("DisableSliders" => (defaultArg x true))
    /// If true, the preview color box will not be displayed, note that the preview color functions as a button as well for collection colors.
    [<CustomOperation("DisablePreview")>] member inline _.DisablePreview ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("DisablePreview" => (defaultArg x true))
    /// The initial mode (RGB, HSL or HEX) the picker should open. Defaults to RGB 
    [<CustomOperation("ColorPickerMode")>] member inline _.ColorPickerMode ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.ColorPickerMode) = render ==> ("ColorPickerMode" => x)
    /// The initial view of the picker. Views can be changed if toolbar is enabled. 
    [<CustomOperation("ColorPickerView")>] member inline _.ColorPickerView ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.ColorPickerView) = render ==> ("ColorPickerView" => x)
    /// If true, binding changes occurred also when HSL values changed without a corresponding RGB change 
    [<CustomOperation("UpdateBindingIfOnlyHSLChanged")>] member inline _.UpdateBindingIfOnlyHSLChanged ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("UpdateBindingIfOnlyHSLChanged" => (defaultArg x true))
    /// A two-way bindable property representing the selected value. MudColor is a utility class that can be used to get the value as RGB, HSL, hex or other value
    [<CustomOperation("Value")>] member inline _.Value ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Utilities.MudColor) = render ==> ("Value" => x)
    /// A two-way bindable property representing the selected value. MudColor is a utility class that can be used to get the value as RGB, HSL, hex or other value
    [<CustomOperation("Value'")>] member inline _.Value' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: MudBlazor.Utilities.MudColor * (MudBlazor.Utilities.MudColor -> unit)) = render ==> html.bind("Value", valueFn)
    [<CustomOperation("ValueChanged")>] member inline _.ValueChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: MudBlazor.Utilities.MudColor -> unit) = render ==> html.callback("ValueChanged", fn)
    [<CustomOperation("ValueChanged")>] member inline _.ValueChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: MudBlazor.Utilities.MudColor -> Task<unit>) = render ==> html.callbackTask("ValueChanged", fn)
    /// MudColor list of predefined colors. The first five colors will show up as the quick colors on preview dot click.
    [<CustomOperation("Palette")>] member inline _.Palette ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.IEnumerable<MudBlazor.Utilities.MudColor>) = render ==> ("Palette" => x)
    /// When set to true, no mouse move events in the spectrum mode will be captured, so the selector circle won't fellow the mouse. 
    /// Under some conditions like long latency the visual representation might not reflect the user behaviour anymore. So, it can be disabled 
    /// Enabled by default
    [<CustomOperation("DisableDragEffect")>] member inline _.DisableDragEffect ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("DisableDragEffect" => (defaultArg x true))
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
    [<CustomOperation("AutoClose")>] member inline _.AutoClose ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("AutoClose" => (defaultArg x true))
    /// Sets the number interval for minutes.
    [<CustomOperation("MinuteSelectionStep")>] member inline _.MinuteSelectionStep ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("MinuteSelectionStep" => x)
    /// If true, sets 12 hour selection clock.
    [<CustomOperation("AmPm")>] member inline _.AmPm ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("AmPm" => (defaultArg x true))
    /// String Format for selected time view
    [<CustomOperation("TimeFormat")>] member inline _.TimeFormat ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("TimeFormat" => x)
    /// The currently selected time (two-way bindable). If null, then nothing was selected.
    [<CustomOperation("Time")>] member inline _.Time ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.TimeSpan>) = render ==> ("Time" => x)
    /// The currently selected time (two-way bindable). If null, then nothing was selected.
    [<CustomOperation("Time'")>] member inline _.Time' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.Nullable<System.TimeSpan> * (System.Nullable<System.TimeSpan> -> unit)) = render ==> html.bind("Time", valueFn)
    /// Fired when the date changes.
    [<CustomOperation("TimeChanged")>] member inline _.TimeChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.Nullable<System.TimeSpan> -> unit) = render ==> html.callback("TimeChanged", fn)
    /// Fired when the date changes.
    [<CustomOperation("TimeChanged")>] member inline _.TimeChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.Nullable<System.TimeSpan> -> Task<unit>) = render ==> html.callbackTask("TimeChanged", fn)

type MudRadioGroupBuilder<'FunBlazorGeneric, 'T when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudFormComponentBuilder<'FunBlazorGeneric, 'T, 'T>()
    /// User class names for the input, separated by space
    [<CustomOperation("InputClass")>] member inline _.InputClass ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("InputClass" => x)
    /// User style definitions for the input
    [<CustomOperation("InputStyle")>] member inline _.InputStyle ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("InputStyle" => x)
    [<CustomOperation("Name")>] member inline _.Name ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Name" => x)
    /// If true, the input will be disabled.
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Disabled" => (defaultArg x true))
    /// If true, the input will be read-only.
    [<CustomOperation("ReadOnly")>] member inline _.ReadOnly ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("ReadOnly" => (defaultArg x true))
    [<CustomOperation("Value")>] member inline _.Value ([<InlineIfLambda>] render: AttrRenderFragment, x: 'T) = render ==> ("Value" => x)
    [<CustomOperation("Value'")>] member inline _.Value' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: 'T * ('T -> unit)) = render ==> html.bind("Value", valueFn)
    [<CustomOperation("ValueChanged")>] member inline _.ValueChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: 'T -> unit) = render ==> html.callback("ValueChanged", fn)
    [<CustomOperation("ValueChanged")>] member inline _.ValueChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: 'T -> Task<unit>) = render ==> html.callbackTask("ValueChanged", fn)
    [<CustomOperation("SelectedOption")>] member inline _.SelectedOption ([<InlineIfLambda>] render: AttrRenderFragment, x: 'T) = render ==> ("SelectedOption" => x)
    [<CustomOperation("SelectedOption'")>] member inline _.SelectedOption' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: 'T * ('T -> unit)) = render ==> html.bind("SelectedOption", valueFn)
    [<CustomOperation("SelectedOptionChanged")>] member inline _.SelectedOptionChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: 'T -> unit) = render ==> html.callback("SelectedOptionChanged", fn)
    [<CustomOperation("SelectedOptionChanged")>] member inline _.SelectedOptionChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: 'T -> Task<unit>) = render ==> html.callbackTask("SelectedOptionChanged", fn)

type MudAlertBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    /// Sets the position of the text to the start (Left in LTR and right in RTL).
    [<CustomOperation("ContentAlignment")>] member inline _.ContentAlignment ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.HorizontalAlignment) = render ==> ("ContentAlignment" => x)
    /// The callback, when the close button has been clicked.
    [<CustomOperation("CloseIconClicked")>] member inline _.CloseIconClicked ([<InlineIfLambda>] render: AttrRenderFragment, fn: MudBlazor.MudAlert -> unit) = render ==> html.callback("CloseIconClicked", fn)
    /// The callback, when the close button has been clicked.
    [<CustomOperation("CloseIconClicked")>] member inline _.CloseIconClicked ([<InlineIfLambda>] render: AttrRenderFragment, fn: MudBlazor.MudAlert -> Task<unit>) = render ==> html.callbackTask("CloseIconClicked", fn)
    /// Define the icon used for the close button.
    [<CustomOperation("CloseIcon")>] member inline _.CloseIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("CloseIcon" => x)
    /// Sets if the alert shows a close icon.
    [<CustomOperation("ShowCloseIcon")>] member inline _.ShowCloseIcon ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("ShowCloseIcon" => (defaultArg x true))
    /// The higher the number, the heavier the drop-shadow. 0 for no shadow.
    [<CustomOperation("Elevation")>] member inline _.Elevation ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("Elevation" => x)
    /// If true, rounded corners are disabled.
    [<CustomOperation("Square")>] member inline _.Square ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Square" => (defaultArg x true))
    /// If true, compact padding will be used.
    [<CustomOperation("Dense")>] member inline _.Dense ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Dense" => (defaultArg x true))
    /// If true, no alert icon will be used.
    [<CustomOperation("NoIcon")>] member inline _.NoIcon ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("NoIcon" => (defaultArg x true))
    /// The severity of the alert. This defines the color and icon used.
    [<CustomOperation("Severity")>] member inline _.Severity ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Severity) = render ==> ("Severity" => x)
    /// The variant to use.
    [<CustomOperation("Variant")>] member inline _.Variant ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Variant) = render ==> ("Variant" => x)
    /// Custom icon, leave unset to use the standard icon which depends on the Severity
    [<CustomOperation("Icon")>] member inline _.Icon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Icon" => x)
    /// Raised when the alert is clicked
    [<CustomOperation("OnClick")>] member inline _.OnClick ([<InlineIfLambda>] render: AttrRenderFragment, fn: Microsoft.AspNetCore.Components.Web.MouseEventArgs -> unit) = render ==> html.callback("OnClick", fn)
    /// Raised when the alert is clicked
    [<CustomOperation("OnClick")>] member inline _.OnClick ([<InlineIfLambda>] render: AttrRenderFragment, fn: Microsoft.AspNetCore.Components.Web.MouseEventArgs -> Task<unit>) = render ==> html.callbackTask("OnClick", fn)

type MudAppBarBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    /// If true, Appbar will be placed at the bottom of the screen.
    [<CustomOperation("Bottom")>] member inline _.Bottom ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Bottom" => (defaultArg x true))
    /// The higher the number, the heavier the drop-shadow. 0 for no shadow.
    [<CustomOperation("Elevation")>] member inline _.Elevation ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("Elevation" => x)
    /// If true, compact padding will be used.
    [<CustomOperation("Dense")>] member inline _.Dense ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Dense" => (defaultArg x true))
    /// If true, the left and right padding is removed from from the appbar.
    [<CustomOperation("DisableGutters")>] member inline _.DisableGutters ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("DisableGutters" => (defaultArg x true))
    /// The color of the component. It supports the theme colors.
    [<CustomOperation("Color")>] member inline _.Color ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("Color" => x)
    /// If true, appbar will be Fixed.
    [<CustomOperation("Fixed")>] member inline _.Fixed ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Fixed" => (defaultArg x true))
    /// If true, AppBar is allowed to wrap.
    [<CustomOperation("WrapContent")>] member inline _.WrapContent ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("WrapContent" => (defaultArg x true))
    /// User class names, separated by spaces for the nested toolbar.
    [<CustomOperation("ToolBarClass")>] member inline _.ToolBarClass ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("ToolBarClass" => x)

type MudAvatarBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    /// The higher the number, the heavier the drop-shadow.
    [<CustomOperation("Elevation")>] member inline _.Elevation ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("Elevation" => x)
    /// If true, border-radius is set to 0.
    [<CustomOperation("Square")>] member inline _.Square ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Square" => (defaultArg x true))
    /// If true, border-radius is set to the themes default value.
    [<CustomOperation("Rounded")>] member inline _.Rounded ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Rounded" => (defaultArg x true))
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
    [<CustomOperation("Outlined")>] member inline _.Outlined ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Outlined" => (defaultArg x true))
    /// Sets the color of the outline if its used.
    [<CustomOperation("OutlineColor")>] member inline _.OutlineColor ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("OutlineColor" => x)
    /// Elevation of the MaxAvatar the higher the number, the heavier the drop-shadow.
    [<CustomOperation("MaxElevation")>] member inline _.MaxElevation ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("MaxElevation" => x)
    /// If true, MaxAvatar border-radius is set to 0.
    [<CustomOperation("MaxSquare")>] member inline _.MaxSquare ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("MaxSquare" => (defaultArg x true))
    /// If true, MaxAvatar will be rounded.
    [<CustomOperation("MaxRounded")>] member inline _.MaxRounded ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("MaxRounded" => (defaultArg x true))
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
    /// Template that will be rendered when the number of avatars exceeds the maximum (parameter Max).
    [<CustomOperation("MaxAvatarsTemplate")>] member inline _.MaxAvatarsTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.Int32 -> NodeRenderFragment) = render ==> html.renderFragment("MaxAvatarsTemplate", fn)

type MudBadgeBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    /// The placement of the badge.
    [<CustomOperation("Origin")>] member inline _.Origin ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Origin) = render ==> ("Origin" => x)
    /// The higher the number, the heavier the drop-shadow.
    [<CustomOperation("Elevation")>] member inline _.Elevation ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("Elevation" => x)
    /// The visibility of the badge.
    [<CustomOperation("Visible")>] member inline _.Visible ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Visible" => (defaultArg x true))
    /// The color of the badge.
    [<CustomOperation("Color")>] member inline _.Color ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("Color" => x)
    /// Reduces the size of the badge and hide any of its content.
    [<CustomOperation("Dot")>] member inline _.Dot ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Dot" => (defaultArg x true))
    /// Overlaps the childcontent on top of the content.
    [<CustomOperation("Overlap")>] member inline _.Overlap ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Overlap" => (defaultArg x true))
    /// Applies a border around the badge.
    [<CustomOperation("Bordered")>] member inline _.Bordered ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Bordered" => (defaultArg x true))
    /// Sets the Icon to use in the badge.
    [<CustomOperation("Icon")>] member inline _.Icon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Icon" => x)
    /// Max value to show when content is integer type.
    [<CustomOperation("Max")>] member inline _.Max ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("Max" => x)
    /// Content you want inside the badge. Supported types are string and integer.
    [<CustomOperation("Content")>] member inline _.Content ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Object) = render ==> ("Content" => x)
    /// Badge class names, separated by space.
    [<CustomOperation("BadgeClass")>] member inline _.BadgeClass ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("BadgeClass" => x)
    /// Button click event if set.
    [<CustomOperation("OnClick")>] member inline _.OnClick ([<InlineIfLambda>] render: AttrRenderFragment, fn: Microsoft.AspNetCore.Components.Web.MouseEventArgs -> unit) = render ==> html.callback("OnClick", fn)
    /// Button click event if set.
    [<CustomOperation("OnClick")>] member inline _.OnClick ([<InlineIfLambda>] render: AttrRenderFragment, fn: Microsoft.AspNetCore.Components.Web.MouseEventArgs -> Task<unit>) = render ==> html.callbackTask("OnClick", fn)

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
    [<CustomOperation("OnBreakpointChanged")>] member inline _.OnBreakpointChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: MudBlazor.Breakpoint -> unit) = render ==> html.callback("OnBreakpointChanged", fn)
    [<CustomOperation("OnBreakpointChanged")>] member inline _.OnBreakpointChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: MudBlazor.Breakpoint -> Task<unit>) = render ==> html.callbackTask("OnBreakpointChanged", fn)

type MudToggleIconButtonBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    /// The toggled value.
    [<CustomOperation("Toggled")>] member inline _.Toggled ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Toggled" => (defaultArg x true))
    /// The toggled value.
    [<CustomOperation("Toggled'")>] member inline _.Toggled' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.Boolean * (System.Boolean -> unit)) = render ==> html.bind("Toggled", valueFn)
    /// Fires whenever toggled is changed. 
    [<CustomOperation("ToggledChanged")>] member inline _.ToggledChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.Boolean -> unit) = render ==> html.callback("ToggledChanged", fn)
    /// Fires whenever toggled is changed. 
    [<CustomOperation("ToggledChanged")>] member inline _.ToggledChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.Boolean -> Task<unit>) = render ==> html.callbackTask("ToggledChanged", fn)
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
    [<CustomOperation("DisableRipple")>] member inline _.DisableRipple ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("DisableRipple" => (defaultArg x true))
    /// If true, the button will be disabled.
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Disabled" => (defaultArg x true))
    /// The variant to use.
    [<CustomOperation("Variant")>] member inline _.Variant ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Variant) = render ==> ("Variant" => x)
    /// If true, no drop-shadow will be used.
    [<CustomOperation("DisableElevation")>] member inline _.DisableElevation ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("DisableElevation" => (defaultArg x true))
    /// If true, the click event bubbles up to the containing/parent component.
    [<CustomOperation("ClickPropagation")>] member inline _.ClickPropagation ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("ClickPropagation" => (defaultArg x true))

type MudButtonGroupBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    /// If true, the button group will override the styles of the individual buttons.
    [<CustomOperation("OverrideStyles")>] member inline _.OverrideStyles ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("OverrideStyles" => (defaultArg x true))
    /// If true, the button group will be displayed vertically.
    [<CustomOperation("VerticalAlign")>] member inline _.VerticalAlign ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("VerticalAlign" => (defaultArg x true))
    /// If true, no drop-shadow will be used.
    [<CustomOperation("DisableElevation")>] member inline _.DisableElevation ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("DisableElevation" => (defaultArg x true))
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
    [<CustomOperation("Square")>] member inline _.Square ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Square" => (defaultArg x true))
    /// If true, card will be outlined.
    [<CustomOperation("Outlined")>] member inline _.Outlined ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Outlined" => (defaultArg x true))

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
    [<CustomOperation("AvatarContent")>] member inline _.AvatarContent ([<InlineIfLambda>] render: AttrRenderFragment, fragment) = render ==> html.renderFragment("AvatarContent", fragment)
    [<CustomOperation("AvatarContent")>] member inline _.AvatarContent ([<InlineIfLambda>] render: AttrRenderFragment, fragments) = render ==> html.renderFragment("AvatarContent", fragment { yield! fragments })
    [<CustomOperation("AvatarContent")>] member inline _.AvatarContent ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("AvatarContent", html.text x)
    [<CustomOperation("AvatarContent")>] member inline _.AvatarContent ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("AvatarContent", html.text x)
    [<CustomOperation("AvatarContent")>] member inline _.AvatarContent ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("AvatarContent", html.text x)
    /// Avatar Icon, Overrides the regular Icon if set.
    [<CustomOperation("Avatar")>] member inline _.Avatar ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Avatar" => x)
    /// Avatar CSS Class, appends to Chips default avatar classes.
    [<CustomOperation("AvatarClass")>] member inline _.AvatarClass ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("AvatarClass" => x)
    /// Removes circle edges and applies theme default.
    [<CustomOperation("Label")>] member inline _.Label ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Label" => (defaultArg x true))
    /// If true, the chip will be displayed in disabled state and no events possible.
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Disabled" => (defaultArg x true))
    /// Sets the Icon to use.
    [<CustomOperation("Icon")>] member inline _.Icon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Icon" => x)
    /// Custom checked icon.
    [<CustomOperation("CheckedIcon")>] member inline _.CheckedIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("CheckedIcon" => x)
    /// The color of the icon.
    [<CustomOperation("IconColor")>] member inline _.IconColor ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("IconColor" => x)
    /// Overrides the default close icon, only shown if OnClose is set.
    [<CustomOperation("CloseIcon")>] member inline _.CloseIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("CloseIcon" => x)
    /// If true, disables ripple effect, ripple effect is only applied to clickable chips.
    [<CustomOperation("DisableRipple")>] member inline _.DisableRipple ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("DisableRipple" => (defaultArg x true))
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
    [<CustomOperation("ForceLoad")>] member inline _.ForceLoad ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("ForceLoad" => (defaultArg x true))
    /// If true, this chip is selected by default if used in a ChipSet.
    [<CustomOperation("Default")>] member inline _.Default ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Boolean>) = render ==> ("Default" => x)
    /// Command executed when the user clicks on an element.
    [<CustomOperation("Command")>] member inline _.Command ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Windows.Input.ICommand) = render ==> ("Command" => x)
    /// Command parameter.
    [<CustomOperation("CommandParameter")>] member inline _.CommandParameter ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Object) = render ==> ("CommandParameter" => x)
    /// Chip click event, if set the chip focus, hover and click effects are applied.
    [<CustomOperation("OnClick")>] member inline _.OnClick ([<InlineIfLambda>] render: AttrRenderFragment, fn: Microsoft.AspNetCore.Components.Web.MouseEventArgs -> unit) = render ==> html.callback("OnClick", fn)
    /// Chip click event, if set the chip focus, hover and click effects are applied.
    [<CustomOperation("OnClick")>] member inline _.OnClick ([<InlineIfLambda>] render: AttrRenderFragment, fn: Microsoft.AspNetCore.Components.Web.MouseEventArgs -> Task<unit>) = render ==> html.callbackTask("OnClick", fn)
    /// Chip delete event, if set the delete icon will be visible.
    [<CustomOperation("OnClose")>] member inline _.OnClose ([<InlineIfLambda>] render: AttrRenderFragment, fn: MudBlazor.MudChip -> unit) = render ==> html.callback("OnClose", fn)
    /// Chip delete event, if set the delete icon will be visible.
    [<CustomOperation("OnClose")>] member inline _.OnClose ([<InlineIfLambda>] render: AttrRenderFragment, fn: MudBlazor.MudChip -> Task<unit>) = render ==> html.callbackTask("OnClose", fn)

type MudChipSetBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    /// Allows to select more than one chip.
    [<CustomOperation("MultiSelection")>] member inline _.MultiSelection ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("MultiSelection" => (defaultArg x true))
    /// Will not allow to deselect the selected chip in single selection mode.
    [<CustomOperation("Mandatory")>] member inline _.Mandatory ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Mandatory" => (defaultArg x true))
    /// Will make all chips closable.
    [<CustomOperation("AllClosable")>] member inline _.AllClosable ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("AllClosable" => (defaultArg x true))
    /// Will show a check-mark for the selected components.
    ///             
    [<CustomOperation("Filter")>] member inline _.Filter ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Filter" => (defaultArg x true))
    /// Will make all chips read only.
    ///             
    [<CustomOperation("ReadOnly")>] member inline _.ReadOnly ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("ReadOnly" => (defaultArg x true))
    /// The currently selected chip in Choice mode
    [<CustomOperation("SelectedChip")>] member inline _.SelectedChip ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.MudChip) = render ==> ("SelectedChip" => x)
    /// The currently selected chip in Choice mode
    [<CustomOperation("SelectedChip'")>] member inline _.SelectedChip' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: MudBlazor.MudChip * (MudBlazor.MudChip -> unit)) = render ==> html.bind("SelectedChip", valueFn)
    /// Called when the selected chip changes, in Choice mode
    [<CustomOperation("SelectedChipChanged")>] member inline _.SelectedChipChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: MudBlazor.MudChip -> unit) = render ==> html.callback("SelectedChipChanged", fn)
    /// Called when the selected chip changes, in Choice mode
    [<CustomOperation("SelectedChipChanged")>] member inline _.SelectedChipChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: MudBlazor.MudChip -> Task<unit>) = render ==> html.callbackTask("SelectedChipChanged", fn)
    /// The currently selected chips in Filter mode
    [<CustomOperation("SelectedChips")>] member inline _.SelectedChips ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.MudChip[]) = render ==> ("SelectedChips" => x)
    /// The currently selected chips in Filter mode
    [<CustomOperation("SelectedChips'")>] member inline _.SelectedChips' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: MudBlazor.MudChip[] * (MudBlazor.MudChip[] -> unit)) = render ==> html.bind("SelectedChips", valueFn)
    /// The Comparer to use for comparing selected values internally.
    [<CustomOperation("Comparer")>] member inline _.Comparer ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.IEqualityComparer<System.Object>) = render ==> ("Comparer" => x)
    /// Called when the selection changed, in Filter mode
    [<CustomOperation("SelectedChipsChanged")>] member inline _.SelectedChipsChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: MudBlazor.MudChip[] -> unit) = render ==> html.callback("SelectedChipsChanged", fn)
    /// Called when the selection changed, in Filter mode
    [<CustomOperation("SelectedChipsChanged")>] member inline _.SelectedChipsChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: MudBlazor.MudChip[] -> Task<unit>) = render ==> html.callbackTask("SelectedChipsChanged", fn)
    /// The current selected value.
    /// Note: make the list Clickable for item selection to work.
    [<CustomOperation("SelectedValues")>] member inline _.SelectedValues ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.ICollection<System.Object>) = render ==> ("SelectedValues" => x)
    /// The current selected value.
    /// Note: make the list Clickable for item selection to work.
    [<CustomOperation("SelectedValues'")>] member inline _.SelectedValues' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.Collections.Generic.ICollection<System.Object> * (System.Collections.Generic.ICollection<System.Object> -> unit)) = render ==> html.bind("SelectedValues", valueFn)
    /// Called whenever the selection changed
    [<CustomOperation("SelectedValuesChanged")>] member inline _.SelectedValuesChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.Collections.Generic.ICollection<System.Object> -> unit) = render ==> html.callback("SelectedValuesChanged", fn)
    /// Called whenever the selection changed
    [<CustomOperation("SelectedValuesChanged")>] member inline _.SelectedValuesChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.Collections.Generic.ICollection<System.Object> -> Task<unit>) = render ==> html.callbackTask("SelectedValuesChanged", fn)
    /// Called when a Chip was deleted (by click on the close icon)
    [<CustomOperation("OnClose")>] member inline _.OnClose ([<InlineIfLambda>] render: AttrRenderFragment, fn: MudBlazor.MudChip -> unit) = render ==> html.callback("OnClose", fn)
    /// Called when a Chip was deleted (by click on the close icon)
    [<CustomOperation("OnClose")>] member inline _.OnClose ([<InlineIfLambda>] render: AttrRenderFragment, fn: MudBlazor.MudChip -> Task<unit>) = render ==> html.callbackTask("OnClose", fn)

type MudCollapseBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    /// If true, expands the panel, otherwise collapse it. Setting this prop enables control over the panel.
    [<CustomOperation("Expanded")>] member inline _.Expanded ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Expanded" => (defaultArg x true))
    /// If true, expands the panel, otherwise collapse it. Setting this prop enables control over the panel.
    [<CustomOperation("Expanded'")>] member inline _.Expanded' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.Boolean * (System.Boolean -> unit)) = render ==> html.bind("Expanded", valueFn)
    /// Explicitly sets the height for the Collapse element to override the css default.
    [<CustomOperation("MaxHeight")>] member inline _.MaxHeight ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Int32>) = render ==> ("MaxHeight" => x)
    [<CustomOperation("OnAnimationEnd")>] member inline _.OnAnimationEnd ([<InlineIfLambda>] render: AttrRenderFragment, fn: unit -> unit) = render ==> html.callback("OnAnimationEnd", fn)
    [<CustomOperation("OnAnimationEnd")>] member inline _.OnAnimationEnd ([<InlineIfLambda>] render: AttrRenderFragment, fn: unit -> Task<unit>) = render ==> html.callbackTask("OnAnimationEnd", fn)
    [<CustomOperation("ExpandedChanged")>] member inline _.ExpandedChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.Boolean -> unit) = render ==> html.callback("ExpandedChanged", fn)
    [<CustomOperation("ExpandedChanged")>] member inline _.ExpandedChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.Boolean -> Task<unit>) = render ==> html.callbackTask("ExpandedChanged", fn)

type ColumnBuilder<'FunBlazorGeneric, 'T when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Value")>] member inline _.Value ([<InlineIfLambda>] render: AttrRenderFragment, x: 'T) = render ==> ("Value" => x)
    [<CustomOperation("Value'")>] member inline _.Value' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: 'T * ('T -> unit)) = render ==> html.bind("Value", valueFn)
    [<CustomOperation("ValueChanged")>] member inline _.ValueChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: 'T -> unit) = render ==> html.callback("ValueChanged", fn)
    [<CustomOperation("ValueChanged")>] member inline _.ValueChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: 'T -> Task<unit>) = render ==> html.callbackTask("ValueChanged", fn)
    /// Specifies the name of the object's property bound to the column
    [<CustomOperation("Title")>] member inline _.Title ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Title" => x)
    [<CustomOperation("HideSmall")>] member inline _.HideSmall ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("HideSmall" => (defaultArg x true))
    [<CustomOperation("FooterColSpan")>] member inline _.FooterColSpan ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("FooterColSpan" => x)
    [<CustomOperation("HeaderColSpan")>] member inline _.HeaderColSpan ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("HeaderColSpan" => x)
    [<CustomOperation("HeaderTemplate")>] member inline _.HeaderTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fn: MudBlazor.HeaderContext<'T> -> NodeRenderFragment) = render ==> html.renderFragment("HeaderTemplate", fn)
    [<CustomOperation("CellTemplate")>] member inline _.CellTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fn: MudBlazor.CellContext<'T> -> NodeRenderFragment) = render ==> html.renderFragment("CellTemplate", fn)
    [<CustomOperation("FooterTemplate")>] member inline _.FooterTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fn: MudBlazor.FooterContext<'T> -> NodeRenderFragment) = render ==> html.renderFragment("FooterTemplate", fn)
    [<CustomOperation("GroupTemplate")>] member inline _.GroupTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fn: MudBlazor.GroupDefinition<'T> -> NodeRenderFragment) = render ==> html.renderFragment("GroupTemplate", fn)
    [<CustomOperation("GroupBy")>] member inline _.GroupBy ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("GroupBy" => (System.Func<'T, System.Object>fn))
    [<CustomOperation("Required")>] member inline _.Required ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Required" => (defaultArg x true))
    [<CustomOperation("HeaderClass")>] member inline _.HeaderClass ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("HeaderClass" => x)
    [<CustomOperation("HeaderClassFunc")>] member inline _.HeaderClassFunc ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("HeaderClassFunc" => (System.Func<'T, System.String>fn))
    [<CustomOperation("HeaderStyle")>] member inline _.HeaderStyle ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("HeaderStyle" => x)
    [<CustomOperation("HeaderStyleFunc")>] member inline _.HeaderStyleFunc ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("HeaderStyleFunc" => (System.Func<'T, System.String>fn))
    /// Determines whether this columns data can be sorted. This overrides the SortMode parameter on the DataGrid.
    [<CustomOperation("Sortable")>] member inline _.Sortable ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Boolean>) = render ==> ("Sortable" => x)
    [<CustomOperation("Resizable")>] member inline _.Resizable ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Boolean>) = render ==> ("Resizable" => x)
    /// If set this will override the DragDropColumnReordering parameter of MudDataGrid which applies to all columns.
    /// Set true to enable reordering for this column. Set false to disable it. 
    [<CustomOperation("DragAndDropEnabled")>] member inline _.DragAndDropEnabled ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Boolean>) = render ==> ("DragAndDropEnabled" => x)
    /// Determines whether this columns data can be filtered. This overrides the Filterable parameter on the DataGrid.
    [<CustomOperation("Filterable")>] member inline _.Filterable ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Boolean>) = render ==> ("Filterable" => x)
    [<CustomOperation("ShowFilterIcon")>] member inline _.ShowFilterIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Boolean>) = render ==> ("ShowFilterIcon" => x)
    /// Determines whether this column can be hidden. This overrides the Hideable parameter on the DataGrid.
    [<CustomOperation("Hideable")>] member inline _.Hideable ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Boolean>) = render ==> ("Hideable" => x)
    [<CustomOperation("Hidden")>] member inline _.Hidden ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Hidden" => (defaultArg x true))
    [<CustomOperation("Hidden'")>] member inline _.Hidden' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.Boolean * (System.Boolean -> unit)) = render ==> html.bind("Hidden", valueFn)
    [<CustomOperation("HiddenChanged")>] member inline _.HiddenChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.Boolean -> unit) = render ==> html.callback("HiddenChanged", fn)
    [<CustomOperation("HiddenChanged")>] member inline _.HiddenChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.Boolean -> Task<unit>) = render ==> html.callbackTask("HiddenChanged", fn)
    /// Determines whether to show or hide column options. This overrides the ShowColumnOptions parameter on the DataGrid.
    [<CustomOperation("ShowColumnOptions")>] member inline _.ShowColumnOptions ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Boolean>) = render ==> ("ShowColumnOptions" => x)
    [<CustomOperation("Comparer")>] member inline _.Comparer ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.IComparer<System.Object>) = render ==> ("Comparer" => x)
    [<CustomOperation("SortBy")>] member inline _.SortBy ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("SortBy" => (System.Func<'T, System.Object>fn))
    [<CustomOperation("InitialDirection")>] member inline _.InitialDirection ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.SortDirection) = render ==> ("InitialDirection" => x)
    [<CustomOperation("SortIcon")>] member inline _.SortIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("SortIcon" => x)
    /// Specifies whether the column can be grouped.
    [<CustomOperation("Groupable")>] member inline _.Groupable ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Boolean>) = render ==> ("Groupable" => x)
    /// Specifies whether the column is grouped.
    [<CustomOperation("Grouping")>] member inline _.Grouping ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Grouping" => (defaultArg x true))
    /// Specifies whether the column is grouped.
    [<CustomOperation("Grouping'")>] member inline _.Grouping' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.Boolean * (System.Boolean -> unit)) = render ==> html.bind("Grouping", valueFn)
    [<CustomOperation("GroupingChanged")>] member inline _.GroupingChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.Boolean -> unit) = render ==> html.callback("GroupingChanged", fn)
    [<CustomOperation("GroupingChanged")>] member inline _.GroupingChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.Boolean -> Task<unit>) = render ==> html.callbackTask("GroupingChanged", fn)
    /// Specifies whether the column is sticky.
    [<CustomOperation("StickyLeft")>] member inline _.StickyLeft ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("StickyLeft" => (defaultArg x true))
    [<CustomOperation("StickyRight")>] member inline _.StickyRight ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("StickyRight" => (defaultArg x true))
    [<CustomOperation("FilterTemplate")>] member inline _.FilterTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fn: MudBlazor.FilterContext<'T> -> NodeRenderFragment) = render ==> html.renderFragment("FilterTemplate", fn)
    /// The culture used to represent this column and by the filtering input field.
    [<CustomOperation("Culture")>] member inline _.Culture ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Globalization.CultureInfo) = render ==> ("Culture" => x)
    [<CustomOperation("CellClass")>] member inline _.CellClass ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("CellClass" => x)
    [<CustomOperation("CellClassFunc")>] member inline _.CellClassFunc ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("CellClassFunc" => (System.Func<'T, System.String>fn))
    [<CustomOperation("CellStyle")>] member inline _.CellStyle ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("CellStyle" => x)
    [<CustomOperation("CellStyleFunc")>] member inline _.CellStyleFunc ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("CellStyleFunc" => (System.Func<'T, System.String>fn))
    [<CustomOperation("IsEditable")>] member inline _.IsEditable ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("IsEditable" => (defaultArg x true))
    [<CustomOperation("EditTemplate")>] member inline _.EditTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fn: MudBlazor.CellContext<'T> -> NodeRenderFragment) = render ==> html.renderFragment("EditTemplate", fn)
    [<CustomOperation("FooterClass")>] member inline _.FooterClass ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("FooterClass" => x)
    [<CustomOperation("FooterClassFunc")>] member inline _.FooterClassFunc ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("FooterClassFunc" => (System.Func<'T, System.String>fn))
    [<CustomOperation("FooterStyle")>] member inline _.FooterStyle ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("FooterStyle" => x)
    [<CustomOperation("FooterStyleFunc")>] member inline _.FooterStyleFunc ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("FooterStyleFunc" => (System.Func<'T, System.String>fn))
    [<CustomOperation("EnableFooterSelection")>] member inline _.EnableFooterSelection ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("EnableFooterSelection" => (defaultArg x true))
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
    [<CustomOperation("SelectedItemChanged")>] member inline _.SelectedItemChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: 'T -> unit) = render ==> html.callback("SelectedItemChanged", fn)
    /// Callback is called when a row has been clicked and returns the selected item.
    [<CustomOperation("SelectedItemChanged")>] member inline _.SelectedItemChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: 'T -> Task<unit>) = render ==> html.callbackTask("SelectedItemChanged", fn)
    /// Callback is called whenever items are selected or deselected in multi selection mode.
    [<CustomOperation("SelectedItemsChanged")>] member inline _.SelectedItemsChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.Collections.Generic.HashSet<'T> -> unit) = render ==> html.callback("SelectedItemsChanged", fn)
    /// Callback is called whenever items are selected or deselected in multi selection mode.
    [<CustomOperation("SelectedItemsChanged")>] member inline _.SelectedItemsChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.Collections.Generic.HashSet<'T> -> Task<unit>) = render ==> html.callbackTask("SelectedItemsChanged", fn)
    /// Callback is called whenever a row is clicked.
    [<CustomOperation("RowClick")>] member inline _.RowClick ([<InlineIfLambda>] render: AttrRenderFragment, fn: MudBlazor.DataGridRowClickEventArgs<'T> -> unit) = render ==> html.callback("RowClick", fn)
    /// Callback is called whenever a row is clicked.
    [<CustomOperation("RowClick")>] member inline _.RowClick ([<InlineIfLambda>] render: AttrRenderFragment, fn: MudBlazor.DataGridRowClickEventArgs<'T> -> Task<unit>) = render ==> html.callbackTask("RowClick", fn)
    /// Callback is called whenever a row is right clicked.
    [<CustomOperation("RowContextMenuClick")>] member inline _.RowContextMenuClick ([<InlineIfLambda>] render: AttrRenderFragment, fn: MudBlazor.DataGridRowClickEventArgs<'T> -> unit) = render ==> html.callback("RowContextMenuClick", fn)
    /// Callback is called whenever a row is right clicked.
    [<CustomOperation("RowContextMenuClick")>] member inline _.RowContextMenuClick ([<InlineIfLambda>] render: AttrRenderFragment, fn: MudBlazor.DataGridRowClickEventArgs<'T> -> Task<unit>) = render ==> html.callbackTask("RowContextMenuClick", fn)
    /// Callback is called when an item has begun to be edited. Returns the item being edited.
    [<CustomOperation("StartedEditingItem")>] member inline _.StartedEditingItem ([<InlineIfLambda>] render: AttrRenderFragment, fn: 'T -> unit) = render ==> html.callback("StartedEditingItem", fn)
    /// Callback is called when an item has begun to be edited. Returns the item being edited.
    [<CustomOperation("StartedEditingItem")>] member inline _.StartedEditingItem ([<InlineIfLambda>] render: AttrRenderFragment, fn: 'T -> Task<unit>) = render ==> html.callbackTask("StartedEditingItem", fn)
    /// Callback is called when the process of editing an item has been canceled. Returns the item which was previously in edit mode.
    [<CustomOperation("CanceledEditingItem")>] member inline _.CanceledEditingItem ([<InlineIfLambda>] render: AttrRenderFragment, fn: 'T -> unit) = render ==> html.callback("CanceledEditingItem", fn)
    /// Callback is called when the process of editing an item has been canceled. Returns the item which was previously in edit mode.
    [<CustomOperation("CanceledEditingItem")>] member inline _.CanceledEditingItem ([<InlineIfLambda>] render: AttrRenderFragment, fn: 'T -> Task<unit>) = render ==> html.callbackTask("CanceledEditingItem", fn)
    /// Callback is called when the process of editing an item has been canceled. Returns the item which was previously in edit mode.
    /// NOTE: Obsolete, use CanceledEditingItem instead
    [<CustomOperation("CancelledEditingItem")>] member inline _.CancelledEditingItem ([<InlineIfLambda>] render: AttrRenderFragment, fn: 'T -> unit) = render ==> html.callback("CancelledEditingItem", fn)
    /// Callback is called when the process of editing an item has been canceled. Returns the item which was previously in edit mode.
    /// NOTE: Obsolete, use CanceledEditingItem instead
    [<CustomOperation("CancelledEditingItem")>] member inline _.CancelledEditingItem ([<InlineIfLambda>] render: AttrRenderFragment, fn: 'T -> Task<unit>) = render ==> html.callbackTask("CancelledEditingItem", fn)
    /// Callback is called when the changes to an item are committed. Returns the item whose changes were committed.
    [<CustomOperation("CommittedItemChanges")>] member inline _.CommittedItemChanges ([<InlineIfLambda>] render: AttrRenderFragment, fn: 'T -> unit) = render ==> html.callback("CommittedItemChanges", fn)
    /// Callback is called when the changes to an item are committed. Returns the item whose changes were committed.
    [<CustomOperation("CommittedItemChanges")>] member inline _.CommittedItemChanges ([<InlineIfLambda>] render: AttrRenderFragment, fn: 'T -> Task<unit>) = render ==> html.callbackTask("CommittedItemChanges", fn)
    /// Callback is called when a field changes in the dialog MudForm. Only works in EditMode.Form
    [<CustomOperation("FormFieldChanged")>] member inline _.FormFieldChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: MudBlazor.Utilities.FormFieldChangedEventArgs -> unit) = render ==> html.callback("FormFieldChanged", fn)
    /// Callback is called when a field changes in the dialog MudForm. Only works in EditMode.Form
    [<CustomOperation("FormFieldChanged")>] member inline _.FormFieldChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: MudBlazor.Utilities.FormFieldChangedEventArgs -> Task<unit>) = render ==> html.callbackTask("FormFieldChanged", fn)
    /// If true, the columns in the DataGrid can be reordered via the columns panel.
    [<CustomOperation("ColumnsPanelReordering")>] member inline _.ColumnsPanelReordering ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("ColumnsPanelReordering" => (defaultArg x true))
    /// If true, the columns in the DataGrid can be reordered via drag and drop. This is overridable by each column.
    [<CustomOperation("DragDropColumnReordering")>] member inline _.DragDropColumnReordering ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("DragDropColumnReordering" => (defaultArg x true))
    /// Custom drag indicator icon in the header which shows up on mouse over. 
    [<CustomOperation("DragIndicatorIcon")>] member inline _.DragIndicatorIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("DragIndicatorIcon" => x)
    /// Size of the DragIndicatorIcon.
    [<CustomOperation("DragIndicatorSize")>] member inline _.DragIndicatorSize ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Size) = render ==> ("DragIndicatorSize" => x)
    /// Css class that is applied to column headers while dragging to indicate that the dragged column can be dropped on a column. 
    [<CustomOperation("DropAllowedClass")>] member inline _.DropAllowedClass ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("DropAllowedClass" => x)
    /// Css class that is applied to column headers while dragging to indicate that the dragged column can not be dropped on a column. 
    [<CustomOperation("DropNotAllowedClass")>] member inline _.DropNotAllowedClass ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("DropNotAllowedClass" => x)
    /// When false the drop classes are only applied when dragging a column over another column
    /// When true the drop classes are applied to all column headers and does not require dragging a column over another column.
    [<CustomOperation("ApplyDropClassesOnDragStarted")>] member inline _.ApplyDropClassesOnDragStarted ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("ApplyDropClassesOnDragStarted" => (defaultArg x true))
    /// Controls whether data in the DataGrid can be sorted. This is overridable by each column.
    [<CustomOperation("SortMode")>] member inline _.SortMode ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.SortMode) = render ==> ("SortMode" => x)
    /// Controls whether data in the DataGrid can be filtered. This is overridable by each column.
    [<CustomOperation("Filterable")>] member inline _.Filterable ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Filterable" => (defaultArg x true))
    /// Controls whether columns in the DataGrid can be hidden. This is overridable by each column.
    [<CustomOperation("Hideable")>] member inline _.Hideable ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Hideable" => (defaultArg x true))
    /// Controls whether to hide or show the column options. This is overridable by each column.
    [<CustomOperation("ShowColumnOptions")>] member inline _.ShowColumnOptions ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("ShowColumnOptions" => (defaultArg x true))
    /// At what breakpoint the table should switch to mobile layout. Takes None, Xs, Sm, Md, Lg and Xl the default behavior is breaking on Xs.
    [<CustomOperation("Breakpoint")>] member inline _.Breakpoint ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Breakpoint) = render ==> ("Breakpoint" => x)
    /// The higher the number, the heavier the drop-shadow. 0 for no shadow.
    [<CustomOperation("Elevation")>] member inline _.Elevation ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("Elevation" => x)
    /// Set true to disable rounded corners
    [<CustomOperation("Square")>] member inline _.Square ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Square" => (defaultArg x true))
    /// If true, table will be outlined.
    [<CustomOperation("Outlined")>] member inline _.Outlined ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Outlined" => (defaultArg x true))
    /// If true, table's cells will have left/right borders.
    [<CustomOperation("Bordered")>] member inline _.Bordered ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Bordered" => (defaultArg x true))
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
    [<CustomOperation("Dense")>] member inline _.Dense ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Dense" => (defaultArg x true))
    /// Set true to see rows hover on mouse-over.
    [<CustomOperation("Hover")>] member inline _.Hover ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Hover" => (defaultArg x true))
    /// If true, striped table rows will be used.
    [<CustomOperation("Striped")>] member inline _.Striped ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Striped" => (defaultArg x true))
    /// When true, the header will stay in place when the table is scrolled. Note: set Height to make the table scrollable.
    [<CustomOperation("FixedHeader")>] member inline _.FixedHeader ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("FixedHeader" => (defaultArg x true))
    /// When true, the footer will be visible is not scrolled to the bottom. Note: set Height to make the table scrollable.
    [<CustomOperation("FixedFooter")>] member inline _.FixedFooter ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("FixedFooter" => (defaultArg x true))
    [<CustomOperation("ShowFilterIcons")>] member inline _.ShowFilterIcons ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("ShowFilterIcons" => (defaultArg x true))
    [<CustomOperation("FilterMode")>] member inline _.FilterMode ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.DataGridFilterMode) = render ==> ("FilterMode" => x)
    [<CustomOperation("FilterCaseSensitivity")>] member inline _.FilterCaseSensitivity ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.DataGridFilterCaseSensitivity) = render ==> ("FilterCaseSensitivity" => x)
    [<CustomOperation("FilterTemplate")>] member inline _.FilterTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fn: MudBlazor.MudDataGrid<'T> -> NodeRenderFragment) = render ==> html.renderFragment("FilterTemplate", fn)
    /// The list of FilterDefinitions that have been added to the data grid. FilterDefinitions are managed by the data
    /// grid automatically when using the built in filter UI. You can also programmatically manage these definitions
    /// through this collection.
    [<CustomOperation("FilterDefinitions")>] member inline _.FilterDefinitions ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.List<MudBlazor.IFilterDefinition<'T>>) = render ==> ("FilterDefinitions" => x)
    /// The list of SortDefinitions that have been added to the data grid. SortDefinitions are managed by the data
    /// grid automatically when using the built in filter UI. You can also programmatically manage these definitions
    /// through this collection.
    [<CustomOperation("SortDefinitions")>] member inline _.SortDefinitions ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.Dictionary<System.String, MudBlazor.SortDefinition<'T>>) = render ==> ("SortDefinitions" => x)
    /// If true, the results are displayed in a Virtualize component, allowing a boost in rendering speed.
    [<CustomOperation("Virtualize")>] member inline _.Virtualize ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Virtualize" => (defaultArg x true))
    /// Gets or sets a value that determines how many additional items will be rendered
    /// before and after the visible region. This help to reduce the frequency of rendering
    /// during scrolling. However, higher values mean that more elements will be present
    /// in the page.
    /// Only used for virtualization.
    [<CustomOperation("OverscanCount")>] member inline _.OverscanCount ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("OverscanCount" => x)
    /// Gets the size of each item in pixels. Defaults to 50px.
    [<CustomOperation("ItemSize")>] member inline _.ItemSize ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Single) = render ==> ("ItemSize" => x)
    /// CSS class for the table rows. Note, many CSS settings are overridden by MudTd though
    [<CustomOperation("RowClass")>] member inline _.RowClass ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("RowClass" => x)
    /// CSS styles for the table rows. Note, many CSS settings are overridden by MudTd though
    [<CustomOperation("RowStyle")>] member inline _.RowStyle ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("RowStyle" => x)
    /// Returns the class that will get joined with RowClass. Takes the current item and row index.
    [<CustomOperation("RowClassFunc")>] member inline _.RowClassFunc ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("RowClassFunc" => (System.Func<'T, System.Int32, System.String>fn))
    /// Returns the class that will get joined with RowClass. Takes the current item and row index.
    [<CustomOperation("RowStyleFunc")>] member inline _.RowStyleFunc ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("RowStyleFunc" => (System.Func<'T, System.Int32, System.String>fn))
    /// Set to true to enable selection of multiple rows.
    [<CustomOperation("MultiSelection")>] member inline _.MultiSelection ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("MultiSelection" => (defaultArg x true))
    /// When true, row-click also toggles the checkbox state
    [<CustomOperation("SelectOnRowClick")>] member inline _.SelectOnRowClick ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("SelectOnRowClick" => (defaultArg x true))
    /// When the grid is not read only, you can specify what type of editing mode to use.
    [<CustomOperation("EditMode")>] member inline _.EditMode ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<MudBlazor.DataGridEditMode>) = render ==> ("EditMode" => x)
    /// Allows you to specify the action that will trigger an edit when the EditMode is Form.
    [<CustomOperation("EditTrigger")>] member inline _.EditTrigger ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<MudBlazor.DataGridEditTrigger>) = render ==> ("EditTrigger" => x)
    /// Fine tune the edit dialog.
    [<CustomOperation("EditDialogOptions")>] member inline _.EditDialogOptions ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.DialogOptions) = render ==> ("EditDialogOptions" => x)
    /// The data to display in the table. MudTable will render one row per item
    [<CustomOperation("Items")>] member inline _.Items ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.IEnumerable<'T>) = render ==> ("Items" => x)
    /// Show a loading animation, if true.
    [<CustomOperation("Loading")>] member inline _.Loading ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Loading" => (defaultArg x true))
    /// Define if Cancel button is present or not for inline editing.
    [<CustomOperation("CanCancelEdit")>] member inline _.CanCancelEdit ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("CanCancelEdit" => (defaultArg x true))
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
    [<CustomOperation("HorizontalScrollbar")>] member inline _.HorizontalScrollbar ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("HorizontalScrollbar" => (defaultArg x true))
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
    /// If the table has more items than this number, it will break the rows into pages of said size.
    /// Note: requires a MudTablePager in PagerContent.
    [<CustomOperation("RowsPerPage'")>] member inline _.RowsPerPage' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.Int32 * (System.Int32 -> unit)) = render ==> html.bind("RowsPerPage", valueFn)
    /// Rows Per Page two-way bindable parameter
    [<CustomOperation("RowsPerPageChanged")>] member inline _.RowsPerPageChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.Int32 -> unit) = render ==> html.callback("RowsPerPageChanged", fn)
    /// Rows Per Page two-way bindable parameter
    [<CustomOperation("RowsPerPageChanged")>] member inline _.RowsPerPageChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.Int32 -> Task<unit>) = render ==> html.callbackTask("RowsPerPageChanged", fn)
    /// The page index of the currently displayed page (Zero based). Usually called by MudTablePager.
    /// Note: requires a MudTablePager in PagerContent.
    [<CustomOperation("CurrentPage")>] member inline _.CurrentPage ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("CurrentPage" => x)
    /// Locks Inline Edit mode, if true.
    [<CustomOperation("ReadOnly")>] member inline _.ReadOnly ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("ReadOnly" => (defaultArg x true))
    /// If MultiSelection is true, this returns the currently selected items. You can bind this property and the initial content of the HashSet you bind it to will cause these rows to be selected initially.
    [<CustomOperation("SelectedItems")>] member inline _.SelectedItems ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.HashSet<'T>) = render ==> ("SelectedItems" => x)
    /// If MultiSelection is true, this returns the currently selected items. You can bind this property and the initial content of the HashSet you bind it to will cause these rows to be selected initially.
    [<CustomOperation("SelectedItems'")>] member inline _.SelectedItems' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.Collections.Generic.HashSet<'T> * (System.Collections.Generic.HashSet<'T> -> unit)) = render ==> html.bind("SelectedItems", valueFn)
    /// Returns the item which was last clicked on in single selection mode (that is, if MultiSelection is false)
    [<CustomOperation("SelectedItem")>] member inline _.SelectedItem ([<InlineIfLambda>] render: AttrRenderFragment, x: 'T) = render ==> ("SelectedItem" => x)
    /// Returns the item which was last clicked on in single selection mode (that is, if MultiSelection is false)
    [<CustomOperation("SelectedItem'")>] member inline _.SelectedItem' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: 'T * ('T -> unit)) = render ==> html.bind("SelectedItem", valueFn)
    /// Determines whether grouping of columns is allowed in the data grid.
    [<CustomOperation("Groupable")>] member inline _.Groupable ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Groupable" => (defaultArg x true))
    /// If set, a grouped column will be expanded by default.
    [<CustomOperation("GroupExpanded")>] member inline _.GroupExpanded ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("GroupExpanded" => (defaultArg x true))
    /// CSS class for the groups.
    [<CustomOperation("GroupClass")>] member inline _.GroupClass ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("GroupClass" => x)
    /// CSS styles for the groups.
    [<CustomOperation("GroupStyle")>] member inline _.GroupStyle ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("GroupStyle" => x)
    /// Returns the class that will get joined with GroupClass.
    [<CustomOperation("GroupClassFunc")>] member inline _.GroupClassFunc ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("GroupClassFunc" => (System.Func<MudBlazor.GroupDefinition<'T>, System.String>fn))
    /// Returns the class that will get joined with GroupStyle.
    [<CustomOperation("GroupStyleFunc")>] member inline _.GroupStyleFunc ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("GroupStyleFunc" => (System.Func<MudBlazor.GroupDefinition<'T>, System.String>fn))
    /// When true, displays the built-in menu icon in the header of the data grid.
    [<CustomOperation("ShowMenuIcon")>] member inline _.ShowMenuIcon ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("ShowMenuIcon" => (defaultArg x true))

type MudDataGridPagerBuilder<'FunBlazorGeneric, 'T when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    /// Set true to hide the part of the pager which allows to change the page size.
    [<CustomOperation("DisableRowsPerPage")>] member inline _.DisableRowsPerPage ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("DisableRowsPerPage" => (defaultArg x true))
    /// Set true to disable user interaction with the backward/forward buttons
    /// and the part of the pager which allows to change the page size.
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Disabled" => (defaultArg x true))
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
    /// Defines delegate with custom logic when user clicks overlay behind dialogue.
    /// Is being invoked instead of default "Backdrop Click" logic.
    /// Setting DisableBackdropClick to "true" disables both - OnBackdropClick as well
    /// as the default logic.
    [<CustomOperation("OnBackdropClick")>] member inline _.OnBackdropClick ([<InlineIfLambda>] render: AttrRenderFragment, fn: Microsoft.AspNetCore.Components.Web.MouseEventArgs -> unit) = render ==> html.callback("OnBackdropClick", fn)
    /// Defines delegate with custom logic when user clicks overlay behind dialogue.
    /// Is being invoked instead of default "Backdrop Click" logic.
    /// Setting DisableBackdropClick to "true" disables both - OnBackdropClick as well
    /// as the default logic.
    [<CustomOperation("OnBackdropClick")>] member inline _.OnBackdropClick ([<InlineIfLambda>] render: AttrRenderFragment, fn: Microsoft.AspNetCore.Components.Web.MouseEventArgs -> Task<unit>) = render ==> html.callbackTask("OnBackdropClick", fn)
    /// No padding at the sides
    [<CustomOperation("DisableSidePadding")>] member inline _.DisableSidePadding ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("DisableSidePadding" => (defaultArg x true))
    /// CSS class that will be applied to the dialog title container
    [<CustomOperation("TitleClass")>] member inline _.TitleClass ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("TitleClass" => x)
    /// CSS class that will be applied to the dialog content
    [<CustomOperation("ClassContent")>] member inline _.ClassContent ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("ClassContent" => x)
    /// CSS class that will be applied to the action buttons container
    [<CustomOperation("ClassActions")>] member inline _.ClassActions ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("ClassActions" => x)
    /// CSS styles to be applied to the dialog content
    [<CustomOperation("ContentStyle")>] member inline _.ContentStyle ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("ContentStyle" => x)
    /// Bind this two-way to show and close an inlined dialog. Has no effect on opened dialogs
    [<CustomOperation("IsVisible")>] member inline _.IsVisible ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("IsVisible" => (defaultArg x true))
    /// Bind this two-way to show and close an inlined dialog. Has no effect on opened dialogs
    [<CustomOperation("IsVisible'")>] member inline _.IsVisible' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.Boolean * (System.Boolean -> unit)) = render ==> html.bind("IsVisible", valueFn)
    /// Raised when the inline dialog's display status changes.
    [<CustomOperation("IsVisibleChanged")>] member inline _.IsVisibleChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.Boolean -> unit) = render ==> html.callback("IsVisibleChanged", fn)
    /// Raised when the inline dialog's display status changes.
    [<CustomOperation("IsVisibleChanged")>] member inline _.IsVisibleChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.Boolean -> Task<unit>) = render ==> html.callbackTask("IsVisibleChanged", fn)
    /// Define the element that will receive the focus when the dialog is opened
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
    [<CustomOperation("Fixed")>] member inline _.Fixed ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Fixed" => (defaultArg x true))
    /// The higher the number, the heavier the drop-shadow. 0 for no shadow.
    [<CustomOperation("Elevation")>] member inline _.Elevation ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("Elevation" => x)
    /// Side from which the drawer will appear.
    [<CustomOperation("Anchor")>] member inline _.Anchor ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Anchor) = render ==> ("Anchor" => x)
    /// The color of the component. It supports the theme colors.
    [<CustomOperation("Color")>] member inline _.Color ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("Color" => x)
    /// Variant of the drawer. It specifies how the drawer will be displayed.
    [<CustomOperation("Variant")>] member inline _.Variant ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.DrawerVariant) = render ==> ("Variant" => x)
    /// Show overlay for responsive and temporary drawers.
    [<CustomOperation("DisableOverlay")>] member inline _.DisableOverlay ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("DisableOverlay" => (defaultArg x true))
    /// Preserve open state for responsive drawer when window resized above Breakpoint.
    [<CustomOperation("PreserveOpenState")>] member inline _.PreserveOpenState ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("PreserveOpenState" => (defaultArg x true))
    /// Open drawer automatically on mouse enter when Variant parameter is set to Mini.
    [<CustomOperation("OpenMiniOnHover")>] member inline _.OpenMiniOnHover ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("OpenMiniOnHover" => (defaultArg x true))
    /// Switching point for responsive drawers
    [<CustomOperation("Breakpoint")>] member inline _.Breakpoint ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Breakpoint) = render ==> ("Breakpoint" => x)
    /// Sets the opened state on the drawer. Can be used with two-way binding to close itself on navigation.
    [<CustomOperation("Open")>] member inline _.Open ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Open" => (defaultArg x true))
    /// Sets the opened state on the drawer. Can be used with two-way binding to close itself on navigation.
    [<CustomOperation("Open'")>] member inline _.Open' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.Boolean * (System.Boolean -> unit)) = render ==> html.bind("Open", valueFn)
    [<CustomOperation("OpenChanged")>] member inline _.OpenChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.Boolean -> unit) = render ==> html.callback("OpenChanged", fn)
    [<CustomOperation("OpenChanged")>] member inline _.OpenChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.Boolean -> Task<unit>) = render ==> html.callbackTask("OpenChanged", fn)
    /// Width of left/right drawer. Only for non-fixed drawers.
    [<CustomOperation("Width")>] member inline _.Width ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Width" => x)
    /// Width of left/right drawer. Only for non-fixed drawers.
    [<CustomOperation("MiniWidth")>] member inline _.MiniWidth ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("MiniWidth" => x)
    /// Height of top/bottom temporary drawer
    [<CustomOperation("Height")>] member inline _.Height ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Height" => x)
    /// Specify how the drawer should behave inside a MudLayout. It affects the position relative to MudAppBar.
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
    [<CustomOperation("ItemDropped")>] member inline _.ItemDropped ([<InlineIfLambda>] render: AttrRenderFragment, fn: MudBlazor.MudItemDropInfo<'T> -> unit) = render ==> html.callback("ItemDropped", fn)
    /// Callback that indicates that an item has been dropped on a drop zone. Should be used to update the "status" of the data item
    [<CustomOperation("ItemDropped")>] member inline _.ItemDropped ([<InlineIfLambda>] render: AttrRenderFragment, fn: MudBlazor.MudItemDropInfo<'T> -> Task<unit>) = render ==> html.callbackTask("ItemDropped", fn)
    /// EventHandler that indicates that an item has been picked from a drop zone and transaction has started.
    [<CustomOperation("ItemPicked")>] member inline _.ItemPicked ([<InlineIfLambda>] render: AttrRenderFragment, fn: MudBlazor.MudDragAndDropItemTransaction<'T> -> unit) = render ==> html.callback("ItemPicked", fn)
    /// EventHandler that indicates that an item has been picked from a drop zone and transaction has started.
    [<CustomOperation("ItemPicked")>] member inline _.ItemPicked ([<InlineIfLambda>] render: AttrRenderFragment, fn: MudBlazor.MudDragAndDropItemTransaction<'T> -> Task<unit>) = render ==> html.callbackTask("ItemPicked", fn)
    /// The method is used to determinate if an item can be dropped within a drop zone
    [<CustomOperation("CanDrop")>] member inline _.CanDrop ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("CanDrop" => (System.Func<'T, System.String, System.Boolean>fn))
    /// The CSS class(es), that is applied to drop zones that are a valid target for drag and drop transaction
    [<CustomOperation("CanDropClass")>] member inline _.CanDropClass ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("CanDropClass" => x)
    /// The CSS class(es), that is applied to drop zones that are NOT valid target for drag and drop transaction
    [<CustomOperation("NoDropClass")>] member inline _.NoDropClass ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("NoDropClass" => x)
    /// If true, drop classes CanDropClass CanDropClass  or NoDropClass NoDropClass or applied as soon, as a transaction has started
    [<CustomOperation("ApplyDropClassesOnDragStarted")>] member inline _.ApplyDropClassesOnDragStarted ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("ApplyDropClassesOnDragStarted" => (defaultArg x true))
    /// The method is used to determinate if an item should be disabled for dragging. Defaults to allow all items
    [<CustomOperation("ItemIsDisabled")>] member inline _.ItemIsDisabled ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("ItemIsDisabled" => (System.Func<'T, System.Boolean>fn))
    /// If a drop item is disabled (determinate by ItemIsDisabled). This class is applied to the element
    [<CustomOperation("DisabledClass")>] member inline _.DisabledClass ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("DisabledClass" => x)
    /// An additional class that is applied to the drop zone where a drag operation started
    [<CustomOperation("DraggingClass")>] member inline _.DraggingClass ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("DraggingClass" => x)
    /// An additional class that is applied to an drop item, when it is dragged
    [<CustomOperation("ItemDraggingClass")>] member inline _.ItemDraggingClass ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("ItemDraggingClass" => x)
    [<CustomOperation("ItemsClassSelector")>] member inline _.ItemsClassSelector ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("ItemsClassSelector" => (System.Func<'T, System.String, System.String>fn))

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
    /// The method is used to determinate item class to be rendered in a drop zone.
    [<CustomOperation("ItemsClassSelector")>] member inline _.ItemsClassSelector ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("ItemsClassSelector" => (System.Func<'T, System.String>fn))
    [<CustomOperation("AllowReorder")>] member inline _.AllowReorder ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("AllowReorder" => (defaultArg x true))
    /// If true, will only act as a droppable zone and not render any items.
    [<CustomOperation("OnlyZone")>] member inline _.OnlyZone ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("OnlyZone" => (defaultArg x true))

type MudDynamicDropItemBuilder<'FunBlazorGeneric, 'T when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    /// The zone identifier of the corresponding drop zone
    [<CustomOperation("ZoneIdentifier")>] member inline _.ZoneIdentifier ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("ZoneIdentifier" => x)
    /// the data item that is represented by this item
    [<CustomOperation("Item")>] member inline _.Item ([<InlineIfLambda>] render: AttrRenderFragment, x: 'T) = render ==> ("Item" => x)
    /// An additional class that is applied to this element when a drag operation is in progress
    [<CustomOperation("DraggingClass")>] member inline _.DraggingClass ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("DraggingClass" => x)
    /// An event callback set fires, when a drag operation has been started
    [<CustomOperation("OnDragStarted")>] member inline _.OnDragStarted ([<InlineIfLambda>] render: AttrRenderFragment, fn: 'T -> unit) = render ==> html.callback("OnDragStarted", fn)
    /// An event callback set fires, when a drag operation has been started
    [<CustomOperation("OnDragStarted")>] member inline _.OnDragStarted ([<InlineIfLambda>] render: AttrRenderFragment, fn: 'T -> Task<unit>) = render ==> html.callbackTask("OnDragStarted", fn)
    /// An event callback set fires, when a drag operation has been ended. This included also a canceled transaction
    [<CustomOperation("OnDragEnded")>] member inline _.OnDragEnded ([<InlineIfLambda>] render: AttrRenderFragment, fn: 'T -> unit) = render ==> html.callback("OnDragEnded", fn)
    /// An event callback set fires, when a drag operation has been ended. This included also a canceled transaction
    [<CustomOperation("OnDragEnded")>] member inline _.OnDragEnded ([<InlineIfLambda>] render: AttrRenderFragment, fn: 'T -> Task<unit>) = render ==> html.callbackTask("OnDragEnded", fn)
    /// When true, the item can't be dragged. defaults to false
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Disabled" => (defaultArg x true))
    /// The class that is applied when disabled Disabled is set to true
    [<CustomOperation("DisabledClass")>] member inline _.DisabledClass ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("DisabledClass" => x)
    [<CustomOperation("Index")>] member inline _.Index ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("Index" => x)
    [<CustomOperation("HideContent")>] member inline _.HideContent ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("HideContent" => (defaultArg x true))

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
    [<CustomOperation("RefChanged")>] member inline _.RefChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: Microsoft.AspNetCore.Components.ElementReference -> unit) = render ==> html.callback("RefChanged", fn)
    [<CustomOperation("RefChanged")>] member inline _.RefChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: Microsoft.AspNetCore.Components.ElementReference -> Task<unit>) = render ==> html.callbackTask("RefChanged", fn)
    [<CustomOperation("ClickPropagation")>] member inline _.ClickPropagation ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("ClickPropagation" => (defaultArg x true))

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
    [<CustomOperation("HideIcon")>] member inline _.HideIcon ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("HideIcon" => (defaultArg x true))
    /// Custom hide icon.
    [<CustomOperation("Icon")>] member inline _.Icon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Icon" => x)
    /// If true, removes vertical padding from ChildContent.
    [<CustomOperation("Dense")>] member inline _.Dense ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Dense" => (defaultArg x true))
    /// If true, the left and right padding is removed from ChildContent.
    [<CustomOperation("DisableGutters")>] member inline _.DisableGutters ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("DisableGutters" => (defaultArg x true))
    /// Raised when IsExpanded changes.
    [<CustomOperation("IsExpandedChanged")>] member inline _.IsExpandedChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.Boolean -> unit) = render ==> html.callback("IsExpandedChanged", fn)
    /// Raised when IsExpanded changes.
    [<CustomOperation("IsExpandedChanged")>] member inline _.IsExpandedChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.Boolean -> Task<unit>) = render ==> html.callbackTask("IsExpandedChanged", fn)
    /// Expansion state of the panel (two-way bindable)
    [<CustomOperation("IsExpanded")>] member inline _.IsExpanded ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("IsExpanded" => (defaultArg x true))
    /// Expansion state of the panel (two-way bindable)
    [<CustomOperation("IsExpanded'")>] member inline _.IsExpanded' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.Boolean * (System.Boolean -> unit)) = render ==> html.bind("IsExpanded", valueFn)
    /// Sets the initial expansion state. Do not use in combination with IsExpanded.
    /// Combine with MultiExpansion to have more than one panel start open.
    [<CustomOperation("IsInitiallyExpanded")>] member inline _.IsInitiallyExpanded ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("IsInitiallyExpanded" => (defaultArg x true))
    /// If true, the component will be disabled.
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Disabled" => (defaultArg x true))

type MudExpansionPanelsBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    /// If true, border-radius is set to 0.
    [<CustomOperation("Square")>] member inline _.Square ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Square" => (defaultArg x true))
    /// If true, multiple panels can be expanded at the same time.
    [<CustomOperation("MultiExpansion")>] member inline _.MultiExpansion ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("MultiExpansion" => (defaultArg x true))
    /// The higher the number, the heavier the drop-shadow. 0 for no shadow.
    [<CustomOperation("Elevation")>] member inline _.Elevation ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("Elevation" => x)
    /// If true, removes vertical padding from all panels' ChildContent.
    [<CustomOperation("Dense")>] member inline _.Dense ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Dense" => (defaultArg x true))
    /// If true, the left and right padding is removed from all panels' ChildContent.
    [<CustomOperation("DisableGutters")>] member inline _.DisableGutters ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("DisableGutters" => (defaultArg x true))
    /// If true, the borders around each panel will be removed.
    [<CustomOperation("DisableBorders")>] member inline _.DisableBorders ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("DisableBorders" => (defaultArg x true))

type MudFieldBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    /// Will adjust vertical spacing. 
    ///             
    [<CustomOperation("Margin")>] member inline _.Margin ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Margin) = render ==> ("Margin" => x)
    /// If true, the label will be displayed in an error state.
    [<CustomOperation("Error")>] member inline _.Error ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Error" => (defaultArg x true))
    /// The ErrorText that will be displayed if Error true
    [<CustomOperation("ErrorText")>] member inline _.ErrorText ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("ErrorText" => x)
    /// The HelperText will be displayed below the text field.
    [<CustomOperation("HelperText")>] member inline _.HelperText ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("HelperText" => x)
    /// If true, the field will take up the full width of its container.
    [<CustomOperation("FullWidth")>] member inline _.FullWidth ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("FullWidth" => (defaultArg x true))
    /// If string has value the label text will be displayed in the input, and scaled down at the top if the field has value.
    [<CustomOperation("Label")>] member inline _.Label ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Label" => x)
    /// Variant can be Text, Filled or Outlined.
    [<CustomOperation("Variant")>] member inline _.Variant ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Variant) = render ==> ("Variant" => x)
    /// If true, the input element will be disabled.
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Disabled" => (defaultArg x true))
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
    [<CustomOperation("OnAdornmentClick")>] member inline _.OnAdornmentClick ([<InlineIfLambda>] render: AttrRenderFragment, fn: Microsoft.AspNetCore.Components.Web.MouseEventArgs -> unit) = render ==> html.callback("OnAdornmentClick", fn)
    /// Button click event if set and Adornment used.
    [<CustomOperation("OnAdornmentClick")>] member inline _.OnAdornmentClick ([<InlineIfLambda>] render: AttrRenderFragment, fn: Microsoft.AspNetCore.Components.Web.MouseEventArgs -> Task<unit>) = render ==> html.callbackTask("OnAdornmentClick", fn)
    /// If true, the inner contents padding is removed.
    [<CustomOperation("InnerPadding")>] member inline _.InnerPadding ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("InnerPadding" => (defaultArg x true))
    /// If true, the field will not have an underline.
    [<CustomOperation("DisableUnderLine")>] member inline _.DisableUnderLine ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("DisableUnderLine" => (defaultArg x true))

type MudFocusTrapBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    /// If true, the focus will no longer loop inside the component.
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Disabled" => (defaultArg x true))
    /// Defines on which element to set the focus when the component is created or enabled.
    /// When DefaultFocus.Element is used, the focus will be set to the FocusTrap itself, so the user will have to press TAB key once to focus the first tabbable element.
    [<CustomOperation("DefaultFocus")>] member inline _.DefaultFocus ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.DefaultFocus) = render ==> ("DefaultFocus" => x)

type MudFormBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    /// Validation status. True if the form is valid and without errors. This parameter is two-way bindable.
    [<CustomOperation("IsValid")>] member inline _.IsValid ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("IsValid" => (defaultArg x true))
    /// Validation status. True if the form is valid and without errors. This parameter is two-way bindable.
    [<CustomOperation("IsValid'")>] member inline _.IsValid' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.Boolean * (System.Boolean -> unit)) = render ==> html.bind("IsValid", valueFn)
    /// True if any field of the field was touched. This parameter is readonly.
    [<CustomOperation("IsTouched")>] member inline _.IsTouched ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("IsTouched" => (defaultArg x true))
    /// True if any field of the field was touched. This parameter is readonly.
    [<CustomOperation("IsTouched'")>] member inline _.IsTouched' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.Boolean * (System.Boolean -> unit)) = render ==> html.bind("IsTouched", valueFn)
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Disabled" => (defaultArg x true))
    [<CustomOperation("ReadOnly")>] member inline _.ReadOnly ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("ReadOnly" => (defaultArg x true))
    /// Validation debounce delay in milliseconds. This can help improve rendering performance of forms with real-time validation of inputs
    /// i.e. when textfields have Immediate="true".
    [<CustomOperation("ValidationDelay")>] member inline _.ValidationDelay ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("ValidationDelay" => x)
    /// When true, the form will not re-render its child contents on validation updates (i.e. when IsValid changes).
    /// This is an optimization which can be necessary especially for larger forms on older devices.
    [<CustomOperation("SuppressRenderingOnValidation")>] member inline _.SuppressRenderingOnValidation ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("SuppressRenderingOnValidation" => (defaultArg x true))
    /// When true, will not cause a page refresh on Enter if any input has focus.
    [<CustomOperation("SuppressImplicitSubmission")>] member inline _.SuppressImplicitSubmission ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("SuppressImplicitSubmission" => (defaultArg x true))
    /// Raised when IsValid changes.
    [<CustomOperation("IsValidChanged")>] member inline _.IsValidChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.Boolean -> unit) = render ==> html.callback("IsValidChanged", fn)
    /// Raised when IsValid changes.
    [<CustomOperation("IsValidChanged")>] member inline _.IsValidChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.Boolean -> Task<unit>) = render ==> html.callbackTask("IsValidChanged", fn)
    /// Raised when IsTouched changes.
    [<CustomOperation("IsTouchedChanged")>] member inline _.IsTouchedChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.Boolean -> unit) = render ==> html.callback("IsTouchedChanged", fn)
    /// Raised when IsTouched changes.
    [<CustomOperation("IsTouchedChanged")>] member inline _.IsTouchedChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.Boolean -> Task<unit>) = render ==> html.callbackTask("IsTouchedChanged", fn)
    /// Raised when a contained IFormComponent changes its value
    [<CustomOperation("FieldChanged")>] member inline _.FieldChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: MudBlazor.Utilities.FormFieldChangedEventArgs -> unit) = render ==> html.callback("FieldChanged", fn)
    /// Raised when a contained IFormComponent changes its value
    [<CustomOperation("FieldChanged")>] member inline _.FieldChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: MudBlazor.Utilities.FormFieldChangedEventArgs -> Task<unit>) = render ==> html.callbackTask("FieldChanged", fn)
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
    [<CustomOperation("ErrorsChanged")>] member inline _.ErrorsChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.String[] -> unit) = render ==> html.callback("ErrorsChanged", fn)
    [<CustomOperation("ErrorsChanged")>] member inline _.ErrorsChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.String[] -> Task<unit>) = render ==> html.callbackTask("ErrorsChanged", fn)
    /// Specifies the top-level model object for the form. Used with Fluent Validation
    [<CustomOperation("Model")>] member inline _.Model ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Object) = render ==> ("Model" => x)

type MudHiddenBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    /// The screen size(s) depending on which the ChildContent should not be rendered (or should be, if Invert is true)
    [<CustomOperation("Breakpoint")>] member inline _.Breakpoint ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Breakpoint) = render ==> ("Breakpoint" => x)
    /// Inverts the Breakpoint, so that the ChildContent is only rendered when the breakpoint matches the screen size.
    [<CustomOperation("Invert")>] member inline _.Invert ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Invert" => (defaultArg x true))
    /// True if the component is not visible (two-way bindable)
    [<CustomOperation("IsHidden")>] member inline _.IsHidden ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("IsHidden" => (defaultArg x true))
    /// True if the component is not visible (two-way bindable)
    [<CustomOperation("IsHidden'")>] member inline _.IsHidden' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.Boolean * (System.Boolean -> unit)) = render ==> html.bind("IsHidden", valueFn)
    /// Fires when the breakpoint changes visibility of the component
    [<CustomOperation("IsHiddenChanged")>] member inline _.IsHiddenChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.Boolean -> unit) = render ==> html.callback("IsHiddenChanged", fn)
    /// Fires when the breakpoint changes visibility of the component
    [<CustomOperation("IsHiddenChanged")>] member inline _.IsHiddenChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.Boolean -> Task<unit>) = render ==> html.callbackTask("IsHiddenChanged", fn)

type MudHighlighterBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    /// The whole text in which a fragment will be highlighted
    [<CustomOperation("Text")>] member inline _.Text ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Text" => x)
    /// The fragment of text to be highlighted
    [<CustomOperation("HighlightedText")>] member inline _.HighlightedText ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("HighlightedText" => x)
    /// The fragments of text to be highlighted
    [<CustomOperation("HighlightedTexts")>] member inline _.HighlightedTexts ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.IEnumerable<System.String>) = render ==> ("HighlightedTexts" => x)
    /// Whether or not the highlighted text is case sensitive
    [<CustomOperation("CaseSensitive")>] member inline _.CaseSensitive ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("CaseSensitive" => (defaultArg x true))
    /// If true, highlights the text until the next regex boundary
    [<CustomOperation("UntilNextBoundary")>] member inline _.UntilNextBoundary ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("UntilNextBoundary" => (defaultArg x true))
    /// If true, renders text as a RenderFragment.
    [<CustomOperation("Markup")>] member inline _.Markup ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Markup" => (defaultArg x true))

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
    [<CustomOperation("Fluid")>] member inline _.Fluid ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Fluid" => (defaultArg x true))
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
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Disabled" => (defaultArg x true))
    /// If true, the label will be displayed in an error state.
    [<CustomOperation("Error")>] member inline _.Error ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Error" => (defaultArg x true))
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
    [<CustomOperation("Required")>] member inline _.Required ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Required" => (defaultArg x true))
    /// If true, the label will be displayed in an error state.
    [<CustomOperation("Error")>] member inline _.Error ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Error" => (defaultArg x true))
    /// The ErrorText that will be displayed if Error true
    [<CustomOperation("ErrorText")>] member inline _.ErrorText ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("ErrorText" => x)
    /// The ErrorId that will be used by aria-describedby if Error true
    [<CustomOperation("ErrorId")>] member inline _.ErrorId ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("ErrorId" => x)
    /// The HelperText will be displayed below the text field.
    [<CustomOperation("HelperText")>] member inline _.HelperText ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("HelperText" => x)
    /// If true, the helper text will only be visible on focus.
    [<CustomOperation("HelperTextOnFocus")>] member inline _.HelperTextOnFocus ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("HelperTextOnFocus" => (defaultArg x true))
    /// The current character counter, displayed below the text field.
    [<CustomOperation("CounterText")>] member inline _.CounterText ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("CounterText" => x)
    /// If true, the input will take up the full width of its container.
    [<CustomOperation("FullWidth")>] member inline _.FullWidth ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("FullWidth" => (defaultArg x true))
    /// If string has value the label text will be displayed in the input, and scaled down at the top if the input has value.
    [<CustomOperation("Label")>] member inline _.Label ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Label" => x)
    /// Variant can be Text, Filled or Outlined.
    [<CustomOperation("Variant")>] member inline _.Variant ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Variant) = render ==> ("Variant" => x)
    /// If true, the input element will be disabled.
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Disabled" => (defaultArg x true))
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
    /// If true, the navlink will be disabled.
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Disabled" => (defaultArg x true))
    /// Link click event.
    [<CustomOperation("OnClick")>] member inline _.OnClick ([<InlineIfLambda>] render: AttrRenderFragment, fn: Microsoft.AspNetCore.Components.Web.MouseEventArgs -> unit) = render ==> html.callback("OnClick", fn)
    /// Link click event.
    [<CustomOperation("OnClick")>] member inline _.OnClick ([<InlineIfLambda>] render: AttrRenderFragment, fn: Microsoft.AspNetCore.Components.Web.MouseEventArgs -> Task<unit>) = render ==> html.callbackTask("OnClick", fn)

type MudListBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    /// The color of the selected List Item.
    [<CustomOperation("Color")>] member inline _.Color ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("Color" => x)
    /// Set true to make the list items clickable. This is also the precondition for list selection to work.
    [<CustomOperation("Clickable")>] member inline _.Clickable ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Clickable" => (defaultArg x true))
    /// If true, vertical padding will be removed from the list.
    [<CustomOperation("DisablePadding")>] member inline _.DisablePadding ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("DisablePadding" => (defaultArg x true))
    /// If true, compact vertical padding will be applied to all list items.
    [<CustomOperation("Dense")>] member inline _.Dense ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Dense" => (defaultArg x true))
    /// If true, the left and right padding is removed on all list items.
    [<CustomOperation("DisableGutters")>] member inline _.DisableGutters ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("DisableGutters" => (defaultArg x true))
    /// If true, will disable the list item if it has onclick.
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Disabled" => (defaultArg x true))
    /// The current selected list item.
    /// Note: make the list Clickable for item selection to work.
    [<CustomOperation("SelectedItem")>] member inline _.SelectedItem ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.MudListItem) = render ==> ("SelectedItem" => x)
    /// The current selected list item.
    /// Note: make the list Clickable for item selection to work.
    [<CustomOperation("SelectedItem'")>] member inline _.SelectedItem' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: MudBlazor.MudListItem * (MudBlazor.MudListItem -> unit)) = render ==> html.bind("SelectedItem", valueFn)
    /// Called whenever the selection changed
    [<CustomOperation("SelectedItemChanged")>] member inline _.SelectedItemChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: MudBlazor.MudListItem -> unit) = render ==> html.callback("SelectedItemChanged", fn)
    /// Called whenever the selection changed
    [<CustomOperation("SelectedItemChanged")>] member inline _.SelectedItemChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: MudBlazor.MudListItem -> Task<unit>) = render ==> html.callbackTask("SelectedItemChanged", fn)
    /// The current selected value.
    /// Note: make the list Clickable for item selection to work.
    [<CustomOperation("SelectedValue")>] member inline _.SelectedValue ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Object) = render ==> ("SelectedValue" => x)
    /// The current selected value.
    /// Note: make the list Clickable for item selection to work.
    [<CustomOperation("SelectedValue'")>] member inline _.SelectedValue' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.Object * (System.Object -> unit)) = render ==> html.bind("SelectedValue", valueFn)
    /// Called whenever the selection changed
    [<CustomOperation("SelectedValueChanged")>] member inline _.SelectedValueChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.Object -> unit) = render ==> html.callback("SelectedValueChanged", fn)
    /// Called whenever the selection changed
    [<CustomOperation("SelectedValueChanged")>] member inline _.SelectedValueChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.Object -> Task<unit>) = render ==> html.callbackTask("SelectedValueChanged", fn)

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
    [<CustomOperation("ForceLoad")>] member inline _.ForceLoad ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("ForceLoad" => (defaultArg x true))
    /// Avatar CSS Class to apply if Avatar is set.
    [<CustomOperation("AvatarClass")>] member inline _.AvatarClass ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("AvatarClass" => x)
    /// If true, will disable the list item if it has onclick.
    /// The value can be overridden by the parent list.
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Disabled" => (defaultArg x true))
    /// If true, disables ripple effect.
    [<CustomOperation("DisableRipple")>] member inline _.DisableRipple ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("DisableRipple" => (defaultArg x true))
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
    [<CustomOperation("Inset")>] member inline _.Inset ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Inset" => (defaultArg x true))
    /// If true, compact vertical padding will be used.
    [<CustomOperation("Dense")>] member inline _.Dense ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Boolean>) = render ==> ("Dense" => x)
    /// If true, the left and right padding is removed.
    [<CustomOperation("DisableGutters")>] member inline _.DisableGutters ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("DisableGutters" => (defaultArg x true))
    /// Expand or collapse nested list. Two-way bindable. Note: if you directly set this to
    /// true or false (instead of using two-way binding) it will force the nested list's expansion state.
    [<CustomOperation("Expanded")>] member inline _.Expanded ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Expanded" => (defaultArg x true))
    /// Expand or collapse nested list. Two-way bindable. Note: if you directly set this to
    /// true or false (instead of using two-way binding) it will force the nested list's expansion state.
    [<CustomOperation("Expanded'")>] member inline _.Expanded' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.Boolean * (System.Boolean -> unit)) = render ==> html.bind("Expanded", valueFn)
    [<CustomOperation("ExpandedChanged")>] member inline _.ExpandedChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.Boolean -> unit) = render ==> html.callback("ExpandedChanged", fn)
    [<CustomOperation("ExpandedChanged")>] member inline _.ExpandedChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.Boolean -> Task<unit>) = render ==> html.callbackTask("ExpandedChanged", fn)
    /// If true, expands the nested list on first display
    [<CustomOperation("InitiallyExpanded")>] member inline _.InitiallyExpanded ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("InitiallyExpanded" => (defaultArg x true))
    /// Command parameter.
    [<CustomOperation("CommandParameter")>] member inline _.CommandParameter ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Object) = render ==> ("CommandParameter" => x)
    /// Command executed when the user clicks on an element.
    [<CustomOperation("Command")>] member inline _.Command ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Windows.Input.ICommand) = render ==> ("Command" => x)
    [<CustomOperation("OnClickHandlerPreventDefault")>] member inline _.OnClickHandlerPreventDefault ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("OnClickHandlerPreventDefault" => (defaultArg x true))
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
    [<CustomOperation("OnClick")>] member inline _.OnClick ([<InlineIfLambda>] render: AttrRenderFragment, fn: Microsoft.AspNetCore.Components.Web.MouseEventArgs -> unit) = render ==> html.callback("OnClick", fn)
    /// List click event.
    [<CustomOperation("OnClick")>] member inline _.OnClick ([<InlineIfLambda>] render: AttrRenderFragment, fn: Microsoft.AspNetCore.Components.Web.MouseEventArgs -> Task<unit>) = render ==> html.callbackTask("OnClick", fn)

type MudListSubheaderBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("DisableGutters")>] member inline _.DisableGutters ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("DisableGutters" => (defaultArg x true))
    [<CustomOperation("Inset")>] member inline _.Inset ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Inset" => (defaultArg x true))

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
    [<CustomOperation("Dense")>] member inline _.Dense ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Dense" => (defaultArg x true))
    /// If true, the list menu will be same width as the parent.
    [<CustomOperation("FullWidth")>] member inline _.FullWidth ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("FullWidth" => (defaultArg x true))
    /// Sets the maxheight the menu can have when open.
    [<CustomOperation("MaxHeight")>] member inline _.MaxHeight ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Int32>) = render ==> ("MaxHeight" => x)
    /// If true, instead of positioning the menu at the left upper corner, position at the exact cursor location.
    /// This makes sense for larger activators
    [<CustomOperation("PositionAtCursor")>] member inline _.PositionAtCursor ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("PositionAtCursor" => (defaultArg x true))
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
    [<CustomOperation("LockScroll")>] member inline _.LockScroll ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("LockScroll" => (defaultArg x true))
    /// If true, menu will be disabled.
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Disabled" => (defaultArg x true))
    /// If true, disables ripple effect.
    [<CustomOperation("DisableRipple")>] member inline _.DisableRipple ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("DisableRipple" => (defaultArg x true))
    /// If true, no drop-shadow will be used.
    [<CustomOperation("DisableElevation")>] member inline _.DisableElevation ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("DisableElevation" => (defaultArg x true))
    /// Fired when the menu IsOpen property changes.
    [<CustomOperation("IsOpenChanged")>] member inline _.IsOpenChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.Boolean -> unit) = render ==> html.callback("IsOpenChanged", fn)
    /// Fired when the menu IsOpen property changes.
    [<CustomOperation("IsOpenChanged")>] member inline _.IsOpenChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.Boolean -> Task<unit>) = render ==> html.callbackTask("IsOpenChanged", fn)

type MudMenuItemBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Disabled" => (defaultArg x true))
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
    /// If set to false, clicking the menu item will keep the menu open
    [<CustomOperation("AutoClose")>] member inline _.AutoClose ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("AutoClose" => (defaultArg x true))
    [<CustomOperation("Target")>] member inline _.Target ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Target" => x)
    [<CustomOperation("ForceLoad")>] member inline _.ForceLoad ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("ForceLoad" => (defaultArg x true))
    [<CustomOperation("Command")>] member inline _.Command ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Windows.Input.ICommand) = render ==> ("Command" => x)
    [<CustomOperation("CommandParameter")>] member inline _.CommandParameter ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Object) = render ==> ("CommandParameter" => x)
    [<CustomOperation("OnAction")>] member inline _.OnAction ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.EventArgs -> unit) = render ==> html.callback("OnAction", fn)
    [<CustomOperation("OnAction")>] member inline _.OnAction ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.EventArgs -> Task<unit>) = render ==> html.callbackTask("OnAction", fn)
    [<CustomOperation("OnClick")>] member inline _.OnClick ([<InlineIfLambda>] render: AttrRenderFragment, fn: Microsoft.AspNetCore.Components.Web.MouseEventArgs -> unit) = render ==> html.callback("OnClick", fn)
    [<CustomOperation("OnClick")>] member inline _.OnClick ([<InlineIfLambda>] render: AttrRenderFragment, fn: Microsoft.AspNetCore.Components.Web.MouseEventArgs -> Task<unit>) = render ==> html.callbackTask("OnClick", fn)
    [<CustomOperation("OnTouch")>] member inline _.OnTouch ([<InlineIfLambda>] render: AttrRenderFragment, fn: Microsoft.AspNetCore.Components.Web.TouchEventArgs -> unit) = render ==> html.callback("OnTouch", fn)
    [<CustomOperation("OnTouch")>] member inline _.OnTouch ([<InlineIfLambda>] render: AttrRenderFragment, fn: Microsoft.AspNetCore.Components.Web.TouchEventArgs -> Task<unit>) = render ==> html.callbackTask("OnTouch", fn)

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
    /// Define the no button as a render fragment (overrides NoText).
    /// Must be a MudButton
    [<CustomOperation("NoButton")>] member inline _.NoButton ([<InlineIfLambda>] render: AttrRenderFragment, fragment) = render ==> html.renderFragment("NoButton", fragment)
    /// Define the no button as a render fragment (overrides NoText).
    /// Must be a MudButton
    [<CustomOperation("NoButton")>] member inline _.NoButton ([<InlineIfLambda>] render: AttrRenderFragment, fragments) = render ==> html.renderFragment("NoButton", fragment { yield! fragments })
    /// Define the no button as a render fragment (overrides NoText).
    /// Must be a MudButton
    [<CustomOperation("NoButton")>] member inline _.NoButton ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("NoButton", html.text x)
    /// Define the no button as a render fragment (overrides NoText).
    /// Must be a MudButton
    [<CustomOperation("NoButton")>] member inline _.NoButton ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("NoButton", html.text x)
    /// Define the no button as a render fragment (overrides NoText).
    /// Must be a MudButton
    [<CustomOperation("NoButton")>] member inline _.NoButton ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("NoButton", html.text x)
    /// Text of the yes/OK button. Leave null to hide the button.
    [<CustomOperation("YesText")>] member inline _.YesText ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("YesText" => x)
    /// Define the yes button as a render fragment (overrides YesText).
    /// Must be a MudButton
    [<CustomOperation("YesButton")>] member inline _.YesButton ([<InlineIfLambda>] render: AttrRenderFragment, fragment) = render ==> html.renderFragment("YesButton", fragment)
    /// Define the yes button as a render fragment (overrides YesText).
    /// Must be a MudButton
    [<CustomOperation("YesButton")>] member inline _.YesButton ([<InlineIfLambda>] render: AttrRenderFragment, fragments) = render ==> html.renderFragment("YesButton", fragment { yield! fragments })
    /// Define the yes button as a render fragment (overrides YesText).
    /// Must be a MudButton
    [<CustomOperation("YesButton")>] member inline _.YesButton ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("YesButton", html.text x)
    /// Define the yes button as a render fragment (overrides YesText).
    /// Must be a MudButton
    [<CustomOperation("YesButton")>] member inline _.YesButton ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("YesButton", html.text x)
    /// Define the yes button as a render fragment (overrides YesText).
    /// Must be a MudButton
    [<CustomOperation("YesButton")>] member inline _.YesButton ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("YesButton", html.text x)
    /// Fired when the yes button is clicked
    [<CustomOperation("OnYes")>] member inline _.OnYes ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.Boolean -> unit) = render ==> html.callback("OnYes", fn)
    /// Fired when the yes button is clicked
    [<CustomOperation("OnYes")>] member inline _.OnYes ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.Boolean -> Task<unit>) = render ==> html.callbackTask("OnYes", fn)
    /// Fired when the no button is clicked
    [<CustomOperation("OnNo")>] member inline _.OnNo ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.Boolean -> unit) = render ==> html.callback("OnNo", fn)
    /// Fired when the no button is clicked
    [<CustomOperation("OnNo")>] member inline _.OnNo ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.Boolean -> Task<unit>) = render ==> html.callbackTask("OnNo", fn)
    /// Fired when the cancel button is clicked or the msg box was closed via the X
    [<CustomOperation("OnCancel")>] member inline _.OnCancel ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.Boolean -> unit) = render ==> html.callback("OnCancel", fn)
    /// Fired when the cancel button is clicked or the msg box was closed via the X
    [<CustomOperation("OnCancel")>] member inline _.OnCancel ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.Boolean -> Task<unit>) = render ==> html.callbackTask("OnCancel", fn)
    /// Bind this two-way to show and close an inlined message box. Has no effect on opened msg boxes
    [<CustomOperation("IsVisible")>] member inline _.IsVisible ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("IsVisible" => (defaultArg x true))
    /// Bind this two-way to show and close an inlined message box. Has no effect on opened msg boxes
    [<CustomOperation("IsVisible'")>] member inline _.IsVisible' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.Boolean * (System.Boolean -> unit)) = render ==> html.bind("IsVisible", valueFn)
    /// Raised when the inline dialog's display status changes.
    [<CustomOperation("IsVisibleChanged")>] member inline _.IsVisibleChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.Boolean -> unit) = render ==> html.callback("IsVisibleChanged", fn)
    /// Raised when the inline dialog's display status changes.
    [<CustomOperation("IsVisibleChanged")>] member inline _.IsVisibleChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.Boolean -> Task<unit>) = render ==> html.callbackTask("IsVisibleChanged", fn)

type MudNavGroupBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Title")>] member inline _.Title ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Title" => x)
    /// Icon to use if set.
    [<CustomOperation("Icon")>] member inline _.Icon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Icon" => x)
    /// The color of the icon. It supports the theme colors, default value uses the themes drawer icon color.
    [<CustomOperation("IconColor")>] member inline _.IconColor ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("IconColor" => x)
    /// If true, the button will be disabled.
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Disabled" => (defaultArg x true))
    /// If true, disables ripple effect.
    [<CustomOperation("DisableRipple")>] member inline _.DisableRipple ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("DisableRipple" => (defaultArg x true))
    /// If true, expands the nav group, otherwise collapse it. 
    /// Two-way bindable
    [<CustomOperation("Expanded")>] member inline _.Expanded ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Expanded" => (defaultArg x true))
    /// If true, expands the nav group, otherwise collapse it. 
    /// Two-way bindable
    [<CustomOperation("Expanded'")>] member inline _.Expanded' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.Boolean * (System.Boolean -> unit)) = render ==> html.bind("Expanded", valueFn)
    /// If true, hides expand-icon at the end of the NavGroup.
    [<CustomOperation("HideExpandIcon")>] member inline _.HideExpandIcon ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("HideExpandIcon" => (defaultArg x true))
    /// Explicitly sets the height for the Collapse element to override the css default.
    [<CustomOperation("MaxHeight")>] member inline _.MaxHeight ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Int32>) = render ==> ("MaxHeight" => x)
    /// If set, overrides the default expand icon.
    [<CustomOperation("ExpandIcon")>] member inline _.ExpandIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("ExpandIcon" => x)
    [<CustomOperation("ExpandedChanged")>] member inline _.ExpandedChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.Boolean -> unit) = render ==> html.callback("ExpandedChanged", fn)
    [<CustomOperation("ExpandedChanged")>] member inline _.ExpandedChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.Boolean -> Task<unit>) = render ==> html.callbackTask("ExpandedChanged", fn)

type MudNavMenuBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    /// The color of the active NavLink.
    [<CustomOperation("Color")>] member inline _.Color ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("Color" => x)
    /// If true, adds a border of the active NavLink, does nothing if variant outlined is used.
    [<CustomOperation("Bordered")>] member inline _.Bordered ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Bordered" => (defaultArg x true))
    /// If true, default theme border-radius will be used on all navlinks.
    [<CustomOperation("Rounded")>] member inline _.Rounded ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Rounded" => (defaultArg x true))
    /// Adjust the vertical spacing between navlinks.
    ///             
    [<CustomOperation("Margin")>] member inline _.Margin ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Margin) = render ==> ("Margin" => x)
    /// If true, compact vertical padding will be applied to all navmenu items.
    [<CustomOperation("Dense")>] member inline _.Dense ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Dense" => (defaultArg x true))

type MudOverlayBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    /// Fires when Visible changes
    [<CustomOperation("VisibleChanged")>] member inline _.VisibleChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.Boolean -> unit) = render ==> html.callback("VisibleChanged", fn)
    /// Fires when Visible changes
    [<CustomOperation("VisibleChanged")>] member inline _.VisibleChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.Boolean -> Task<unit>) = render ==> html.callbackTask("VisibleChanged", fn)
    /// If true overlay will be visible. Two-way bindable.
    [<CustomOperation("Visible")>] member inline _.Visible ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Visible" => (defaultArg x true))
    /// If true overlay will be visible. Two-way bindable.
    [<CustomOperation("Visible'")>] member inline _.Visible' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.Boolean * (System.Boolean -> unit)) = render ==> html.bind("Visible", valueFn)
    /// If true overlay will set Visible false on click.
    [<CustomOperation("AutoClose")>] member inline _.AutoClose ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("AutoClose" => (defaultArg x true))
    /// If true (default), the Document.body element will not be able to scroll
    [<CustomOperation("LockScroll")>] member inline _.LockScroll ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("LockScroll" => (defaultArg x true))
    /// The css class that will be added to body if lockscroll is used.
    [<CustomOperation("LockScrollClass")>] member inline _.LockScrollClass ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("LockScrollClass" => x)
    /// If true applies the themes dark overlay color.
    [<CustomOperation("DarkBackground")>] member inline _.DarkBackground ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("DarkBackground" => (defaultArg x true))
    /// If true applies the themes light overlay color.
    [<CustomOperation("LightBackground")>] member inline _.LightBackground ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("LightBackground" => (defaultArg x true))
    /// If true, use absolute positioning for the overlay.
    [<CustomOperation("Absolute")>] member inline _.Absolute ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Absolute" => (defaultArg x true))
    /// Sets the z-index of the overlay.
    [<CustomOperation("ZIndex")>] member inline _.ZIndex ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("ZIndex" => x)
    /// Command parameter.
    [<CustomOperation("CommandParameter")>] member inline _.CommandParameter ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Object) = render ==> ("CommandParameter" => x)
    /// Command executed when the user clicks on an element.
    [<CustomOperation("Command")>] member inline _.Command ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Windows.Input.ICommand) = render ==> ("Command" => x)
    /// Fired when the overlay is clicked
    [<CustomOperation("OnClick")>] member inline _.OnClick ([<InlineIfLambda>] render: AttrRenderFragment, fn: Microsoft.AspNetCore.Components.Web.MouseEventArgs -> unit) = render ==> html.callback("OnClick", fn)
    /// Fired when the overlay is clicked
    [<CustomOperation("OnClick")>] member inline _.OnClick ([<InlineIfLambda>] render: AttrRenderFragment, fn: Microsoft.AspNetCore.Components.Web.MouseEventArgs -> Task<unit>) = render ==> html.callbackTask("OnClick", fn)

type MudPageContentNavigationBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    /// The text displayed about the section links. Defaults to "Contents"
    [<CustomOperation("Headline")>] member inline _.Headline ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Headline" => x)
    /// The css selector used to identify the HTML elements that should be observed for viewport changes
    [<CustomOperation("SectionClassSelector")>] member inline _.SectionClassSelector ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("SectionClassSelector" => x)
    /// If there are multiple levels, this can specified to make a mapping between a level class like "second-level" and the level in the hierarchy
    [<CustomOperation("HierarchyMapper")>] member inline _.HierarchyMapper ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.IDictionary<System.String, System.Int32>) = render ==> ("HierarchyMapper" => x)
    /// If there are multiple levels, this property controls they visibility of them.
    [<CustomOperation("ExpandBehaviour")>] member inline _.ExpandBehaviour ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.ContentNavigationExpandBehaviour) = render ==> ("ExpandBehaviour" => x)
    /// If this option is true the first added section will become active when there is no other indication of an active session. Default value is false  
    [<CustomOperation("ActivateFirstSectionAsDefault")>] member inline _.ActivateFirstSectionAsDefault ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("ActivateFirstSectionAsDefault" => (defaultArg x true))

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
    [<CustomOperation("Rectangular")>] member inline _.Rectangular ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Rectangular" => (defaultArg x true))
    /// The size of the component..
    [<CustomOperation("Size")>] member inline _.Size ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Size) = render ==> ("Size" => x)
    /// If true, no drop-shadow will be used.
    [<CustomOperation("DisableElevation")>] member inline _.DisableElevation ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("DisableElevation" => (defaultArg x true))
    /// If true, the pagination will be disabled.
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Disabled" => (defaultArg x true))
    /// If true, the navigate-to-first-page button is shown.
    [<CustomOperation("ShowFirstButton")>] member inline _.ShowFirstButton ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("ShowFirstButton" => (defaultArg x true))
    /// If true, the navigate-to-last-page button is shown.
    [<CustomOperation("ShowLastButton")>] member inline _.ShowLastButton ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("ShowLastButton" => (defaultArg x true))
    /// If true, the navigate-to-previous-page button is shown.
    [<CustomOperation("ShowPreviousButton")>] member inline _.ShowPreviousButton ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("ShowPreviousButton" => (defaultArg x true))
    /// If true, the navigate-to-next-page button is shown.
    [<CustomOperation("ShowNextButton")>] member inline _.ShowNextButton ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("ShowNextButton" => (defaultArg x true))
    /// Invokes the callback when a control button is clicked.
    [<CustomOperation("ControlButtonClicked")>] member inline _.ControlButtonClicked ([<InlineIfLambda>] render: AttrRenderFragment, fn: MudBlazor.Page -> unit) = render ==> html.callback("ControlButtonClicked", fn)
    /// Invokes the callback when a control button is clicked.
    [<CustomOperation("ControlButtonClicked")>] member inline _.ControlButtonClicked ([<InlineIfLambda>] render: AttrRenderFragment, fn: MudBlazor.Page -> Task<unit>) = render ==> html.callbackTask("ControlButtonClicked", fn)
    /// Invokes the callback when selected page changes.
    [<CustomOperation("SelectedChanged")>] member inline _.SelectedChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.Int32 -> unit) = render ==> html.callback("SelectedChanged", fn)
    /// Invokes the callback when selected page changes.
    [<CustomOperation("SelectedChanged")>] member inline _.SelectedChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.Int32 -> Task<unit>) = render ==> html.callbackTask("SelectedChanged", fn)
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
    [<CustomOperation("Square")>] member inline _.Square ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Square" => (defaultArg x true))
    /// If true, card will be outlined.
    [<CustomOperation("Outlined")>] member inline _.Outlined ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Outlined" => (defaultArg x true))
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

type MudProgressCircularBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    /// The color of the component. It supports the theme colors.
    [<CustomOperation("Color")>] member inline _.Color ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("Color" => x)
    /// The size of the component.
    [<CustomOperation("Size")>] member inline _.Size ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Size) = render ==> ("Size" => x)
    /// Constantly animates, does not follow any value.
    [<CustomOperation("Indeterminate")>] member inline _.Indeterminate ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Indeterminate" => (defaultArg x true))
    [<CustomOperation("Min")>] member inline _.Min ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Double) = render ==> ("Min" => x)
    [<CustomOperation("Max")>] member inline _.Max ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Double) = render ==> ("Max" => x)
    [<CustomOperation("Value")>] member inline _.Value ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Double) = render ==> ("Value" => x)
    [<CustomOperation("StrokeWidth")>] member inline _.StrokeWidth ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("StrokeWidth" => x)

type MudProgressLinearBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    /// The color of the component. It supports the theme colors.
    [<CustomOperation("Color")>] member inline _.Color ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("Color" => x)
    /// The size of the component.
    [<CustomOperation("Size")>] member inline _.Size ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Size) = render ==> ("Size" => x)
    /// Constantly animates, does not follow any value.
    [<CustomOperation("Indeterminate")>] member inline _.Indeterminate ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Indeterminate" => (defaultArg x true))
    /// If true, the buffer value will be used.
    [<CustomOperation("Buffer")>] member inline _.Buffer ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Buffer" => (defaultArg x true))
    /// If true, border-radius is set to the themes default value.
    [<CustomOperation("Rounded")>] member inline _.Rounded ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Rounded" => (defaultArg x true))
    /// Adds stripes to the filled part of the linear progress.
    [<CustomOperation("Striped")>] member inline _.Striped ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Striped" => (defaultArg x true))
    /// If true, the progress bar  will be displayed vertically.
    [<CustomOperation("Vertical")>] member inline _.Vertical ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Vertical" => (defaultArg x true))
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
    [<CustomOperation("Value")>] member inline _.Value ([<InlineIfLambda>] render: AttrRenderFragment, x: 'T) = render ==> ("Value" => x)
    /// The value to associate to the button.
    [<CustomOperation("Option")>] member inline _.Option ([<InlineIfLambda>] render: AttrRenderFragment, x: 'T) = render ==> ("Option" => x)
    /// If true, compact padding will be applied.
    [<CustomOperation("Dense")>] member inline _.Dense ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Dense" => (defaultArg x true))
    /// The Size of the component.
    [<CustomOperation("Size")>] member inline _.Size ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Size) = render ==> ("Size" => x)
    /// If true, disables ripple effect.
    [<CustomOperation("DisableRipple")>] member inline _.DisableRipple ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("DisableRipple" => (defaultArg x true))
    /// If true, the button will be disabled.
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Disabled" => (defaultArg x true))

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
    [<CustomOperation("DisableRipple")>] member inline _.DisableRipple ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("DisableRipple" => (defaultArg x true))
    /// If true, the controls will be disabled.
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Disabled" => (defaultArg x true))
    /// If true, the ratings will show without interactions.
    [<CustomOperation("ReadOnly")>] member inline _.ReadOnly ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("ReadOnly" => (defaultArg x true))
    /// Fires when SelectedValue changes.
    [<CustomOperation("SelectedValueChanged")>] member inline _.SelectedValueChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.Int32 -> unit) = render ==> html.callback("SelectedValueChanged", fn)
    /// Fires when SelectedValue changes.
    [<CustomOperation("SelectedValueChanged")>] member inline _.SelectedValueChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.Int32 -> Task<unit>) = render ==> html.callbackTask("SelectedValueChanged", fn)
    /// Selected value. This property is two-way bindable.
    [<CustomOperation("SelectedValue")>] member inline _.SelectedValue ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("SelectedValue" => x)
    /// Selected value. This property is two-way bindable.
    [<CustomOperation("SelectedValue'")>] member inline _.SelectedValue' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.Int32 * (System.Int32 -> unit)) = render ==> html.bind("SelectedValue", valueFn)
    /// Fires when hovered value change. Value will be null if no rating item is hovered.
    [<CustomOperation("HoveredValueChanged")>] member inline _.HoveredValueChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.Nullable<System.Int32> -> unit) = render ==> html.callback("HoveredValueChanged", fn)
    /// Fires when hovered value change. Value will be null if no rating item is hovered.
    [<CustomOperation("HoveredValueChanged")>] member inline _.HoveredValueChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.Nullable<System.Int32> -> Task<unit>) = render ==> html.callbackTask("HoveredValueChanged", fn)

type MudRatingItemBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    /// This rating item value;
    [<CustomOperation("ItemValue")>] member inline _.ItemValue ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("ItemValue" => x)
    /// The Size of the icon.
    [<CustomOperation("Size")>] member inline _.Size ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Size) = render ==> ("Size" => x)
    /// The color of the component. It supports the theme colors.
    [<CustomOperation("Color")>] member inline _.Color ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("Color" => x)
    /// If true, disables ripple effect.
    [<CustomOperation("DisableRipple")>] member inline _.DisableRipple ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("DisableRipple" => (defaultArg x true))
    /// If true, the controls will be disabled.
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Disabled" => (defaultArg x true))
    /// If true, the item will be readonly.
    [<CustomOperation("ReadOnly")>] member inline _.ReadOnly ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("ReadOnly" => (defaultArg x true))
    /// Fires when element clicked.
    [<CustomOperation("ItemClicked")>] member inline _.ItemClicked ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.Int32 -> unit) = render ==> html.callback("ItemClicked", fn)
    /// Fires when element clicked.
    [<CustomOperation("ItemClicked")>] member inline _.ItemClicked ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.Int32 -> Task<unit>) = render ==> html.callbackTask("ItemClicked", fn)
    /// Fires when element hovered.
    [<CustomOperation("ItemHovered")>] member inline _.ItemHovered ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.Nullable<System.Int32> -> unit) = render ==> html.callback("ItemHovered", fn)
    /// Fires when element hovered.
    [<CustomOperation("ItemHovered")>] member inline _.ItemHovered ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.Nullable<System.Int32> -> Task<unit>) = render ==> html.callbackTask("ItemHovered", fn)

type MudRTLProviderBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    /// If true, changes the layout to RightToLeft.
    [<CustomOperation("RightToLeft")>] member inline _.RightToLeft ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("RightToLeft" => (defaultArg x true))

type MudScrollToTopBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    /// The CSS selector to which the scroll event will be attached
    [<CustomOperation("Selector")>] member inline _.Selector ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Selector" => x)
    /// If set to true, it starts Visible. If sets to false, it will become visible when the TopOffset amount of scrolled pixels is reached
    [<CustomOperation("Visible")>] member inline _.Visible ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Visible" => (defaultArg x true))
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
    [<CustomOperation("OnScroll")>] member inline _.OnScroll ([<InlineIfLambda>] render: AttrRenderFragment, fn: MudBlazor.ScrollEventArgs -> unit) = render ==> html.callback("OnScroll", fn)
    /// Called when scroll event is fired
    [<CustomOperation("OnScroll")>] member inline _.OnScroll ([<InlineIfLambda>] render: AttrRenderFragment, fn: MudBlazor.ScrollEventArgs -> Task<unit>) = render ==> html.callbackTask("OnScroll", fn)
    [<CustomOperation("OnClick")>] member inline _.OnClick ([<InlineIfLambda>] render: AttrRenderFragment, fn: Microsoft.AspNetCore.Components.Web.MouseEventArgs -> unit) = render ==> html.callback("OnClick", fn)
    [<CustomOperation("OnClick")>] member inline _.OnClick ([<InlineIfLambda>] render: AttrRenderFragment, fn: Microsoft.AspNetCore.Components.Web.MouseEventArgs -> Task<unit>) = render ==> html.callbackTask("OnClick", fn)

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
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Disabled" => (defaultArg x true))
    [<CustomOperation("Converter")>] member inline _.Converter ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Converter<'T>) = render ==> ("Converter" => x)
    [<CustomOperation("ValueChanged")>] member inline _.ValueChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: 'T -> unit) = render ==> html.callback("ValueChanged", fn)
    [<CustomOperation("ValueChanged")>] member inline _.ValueChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: 'T -> Task<unit>) = render ==> html.callbackTask("ValueChanged", fn)
    [<CustomOperation("Value")>] member inline _.Value ([<InlineIfLambda>] render: AttrRenderFragment, x: 'T) = render ==> ("Value" => x)
    [<CustomOperation("Value'")>] member inline _.Value' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: 'T * ('T -> unit)) = render ==> html.bind("Value", valueFn)
    /// The color of the component. It supports the Primary, Secondary and Tertiary theme colors.
    [<CustomOperation("Color")>] member inline _.Color ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("Color" => x)
    /// If true, the dragging the slider will update the Value immediately.
    /// If false, the Value is updated only on releasing the handle.
    [<CustomOperation("Immediate")>] member inline _.Immediate ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Immediate" => (defaultArg x true))
    /// If true, displays the slider vertical.
    [<CustomOperation("Vertical")>] member inline _.Vertical ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Vertical" => (defaultArg x true))
    /// If true, displays tick marks on the track.
    [<CustomOperation("TickMarks")>] member inline _.TickMarks ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("TickMarks" => (defaultArg x true))
    /// Labels for tick marks, will attempt to map the labels to each step in index order.
    [<CustomOperation("TickMarkLabels")>] member inline _.TickMarkLabels ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String[]) = render ==> ("TickMarkLabels" => x)
    /// Labels for tick marks, will attempt to map the labels to each step in index order.
    [<CustomOperation("Size")>] member inline _.Size ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Size) = render ==> ("Size" => x)
    /// The variant to use.
    [<CustomOperation("Variant")>] member inline _.Variant ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Variant) = render ==> ("Variant" => x)
    /// Displays the value over the slider thumb.
    [<CustomOperation("ValueLabel")>] member inline _.ValueLabel ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("ValueLabel" => (defaultArg x true))

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
    [<CustomOperation("Row")>] member inline _.Row ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Row" => (defaultArg x true))
    /// Reverses the order of its items.
    [<CustomOperation("Reverse")>] member inline _.Reverse ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Reverse" => (defaultArg x true))
    /// Defines the spacing between its items.
    [<CustomOperation("Spacing")>] member inline _.Spacing ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("Spacing" => x)
    /// Defines the spacing between its items.
    [<CustomOperation("Justify")>] member inline _.Justify ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<MudBlazor.Justify>) = render ==> ("Justify" => x)
    /// Defines the spacing between its items.
    [<CustomOperation("AlignItems")>] member inline _.AlignItems ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<MudBlazor.AlignItems>) = render ==> ("AlignItems" => x)
    /// Defines the flexbox wrapping behavior of its items.
    [<CustomOperation("Wrap")>] member inline _.Wrap ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<MudBlazor.Wrap>) = render ==> ("Wrap" => x)

type MudSwipeAreaBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("OnSwipe")>] member inline _.OnSwipe ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("OnSwipe" => (System.Action<MudBlazor.SwipeDirection>fn))
    [<CustomOperation("OnSwipeEnd")>] member inline _.OnSwipeEnd ([<InlineIfLambda>] render: AttrRenderFragment, fn: MudBlazor.SwipeEventArgs -> unit) = render ==> html.callback("OnSwipeEnd", fn)
    [<CustomOperation("OnSwipeEnd")>] member inline _.OnSwipeEnd ([<InlineIfLambda>] render: AttrRenderFragment, fn: MudBlazor.SwipeEventArgs -> Task<unit>) = render ==> html.callbackTask("OnSwipeEnd", fn)
    /// Swipe threshold in pixels. If SwipeDelta is below Sensitivity then OnSwipe is not called.
    [<CustomOperation("Sensitivity")>] member inline _.Sensitivity ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("Sensitivity" => x)
    /// Prevents default behavior of the browser when swiping.
    /// Usable especially when swiping up/down - this will prevent the whole page from scrolling up/down.
    [<CustomOperation("PreventDefault")>] member inline _.PreventDefault ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("PreventDefault" => (defaultArg x true))

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
    [<CustomOperation("IsCheckable")>] member inline _.IsCheckable ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("IsCheckable" => (defaultArg x true))
    [<CustomOperation("HeaderClass")>] member inline _.HeaderClass ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("HeaderClass" => x)
    [<CustomOperation("FooterClass")>] member inline _.FooterClass ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("FooterClass" => x)
    [<CustomOperation("HeaderStyle")>] member inline _.HeaderStyle ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("HeaderStyle" => x)
    [<CustomOperation("FooterStyle")>] member inline _.FooterStyle ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("FooterStyle" => x)
    /// Custom expand icon.
    [<CustomOperation("ExpandIcon")>] member inline _.ExpandIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("ExpandIcon" => x)
    /// Custom collapse icon.
    [<CustomOperation("CollapseIcon")>] member inline _.CollapseIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("CollapseIcon" => x)
    /// On click event
    [<CustomOperation("OnRowClick")>] member inline _.OnRowClick ([<InlineIfLambda>] render: AttrRenderFragment, fn: Microsoft.AspNetCore.Components.Web.MouseEventArgs -> unit) = render ==> html.callback("OnRowClick", fn)
    /// On click event
    [<CustomOperation("OnRowClick")>] member inline _.OnRowClick ([<InlineIfLambda>] render: AttrRenderFragment, fn: Microsoft.AspNetCore.Components.Web.MouseEventArgs -> Task<unit>) = render ==> html.callbackTask("OnRowClick", fn)

type MudTablePagerBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    /// Set true to hide the part of the pager which allows to change the page size.
    [<CustomOperation("HideRowsPerPage")>] member inline _.HideRowsPerPage ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("HideRowsPerPage" => (defaultArg x true))
    /// Set true to hide the number of pages.
    [<CustomOperation("HidePageNumber")>] member inline _.HidePageNumber ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("HidePageNumber" => (defaultArg x true))
    /// Set true to hide the pagination.
    [<CustomOperation("HidePagination")>] member inline _.HidePagination ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("HidePagination" => (defaultArg x true))
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
    [<CustomOperation("Enabled")>] member inline _.Enabled ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Enabled" => (defaultArg x true))
    /// The Icon used to display sortdirection.
    [<CustomOperation("SortIcon")>] member inline _.SortIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("SortIcon" => x)
    /// If true the icon will be placed before the label text.
    [<CustomOperation("AppendIcon")>] member inline _.AppendIcon ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("AppendIcon" => (defaultArg x true))
    [<CustomOperation("SortDirection")>] member inline _.SortDirection ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.SortDirection) = render ==> ("SortDirection" => x)
    [<CustomOperation("SortDirection'")>] member inline _.SortDirection' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: MudBlazor.SortDirection * (MudBlazor.SortDirection -> unit)) = render ==> html.bind("SortDirection", valueFn)
    [<CustomOperation("SortDirectionChanged")>] member inline _.SortDirectionChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: MudBlazor.SortDirection -> unit) = render ==> html.callback("SortDirectionChanged", fn)
    [<CustomOperation("SortDirectionChanged")>] member inline _.SortDirectionChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: MudBlazor.SortDirection -> Task<unit>) = render ==> html.callbackTask("SortDirectionChanged", fn)
    [<CustomOperation("SortBy")>] member inline _.SortBy ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("SortBy" => (System.Func<'T, System.Object>fn))
    [<CustomOperation("SortLabel")>] member inline _.SortLabel ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("SortLabel" => x)

type MudTdBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("DataLabel")>] member inline _.DataLabel ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("DataLabel" => x)
    /// Hide cell when breakpoint is smaller than the defined value in table.
    [<CustomOperation("HideSmall")>] member inline _.HideSmall ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("HideSmall" => (defaultArg x true))

type MudTFootRowBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    /// Add a multi-select checkbox that will select/unselect every item in the table
    [<CustomOperation("IsCheckable")>] member inline _.IsCheckable ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("IsCheckable" => (defaultArg x true))
    /// Specify behavior in case the table is multi-select mode. If set to true, it won't render an additional empty column.
    [<CustomOperation("IgnoreCheckbox")>] member inline _.IgnoreCheckbox ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("IgnoreCheckbox" => (defaultArg x true))
    /// Specify behavior in case the table is editable. If set to true, it won't render an additional empty column.
    [<CustomOperation("IgnoreEditable")>] member inline _.IgnoreEditable ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("IgnoreEditable" => (defaultArg x true))
    [<CustomOperation("IsExpandable")>] member inline _.IsExpandable ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("IsExpandable" => (defaultArg x true))
    /// On click event
    [<CustomOperation("OnRowClick")>] member inline _.OnRowClick ([<InlineIfLambda>] render: AttrRenderFragment, fn: Microsoft.AspNetCore.Components.Web.MouseEventArgs -> unit) = render ==> html.callback("OnRowClick", fn)
    /// On click event
    [<CustomOperation("OnRowClick")>] member inline _.OnRowClick ([<InlineIfLambda>] render: AttrRenderFragment, fn: Microsoft.AspNetCore.Components.Web.MouseEventArgs -> Task<unit>) = render ==> html.callbackTask("OnRowClick", fn)

type MudThBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()


type MudTHeadRowBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    /// Add a multi-select checkbox that will select/unselect every item in the table
    [<CustomOperation("IsCheckable")>] member inline _.IsCheckable ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("IsCheckable" => (defaultArg x true))
    /// Specify behavior in case the table is multi-select mode. If set to true, it won't render an additional empty column.
    [<CustomOperation("IgnoreCheckbox")>] member inline _.IgnoreCheckbox ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("IgnoreCheckbox" => (defaultArg x true))
    /// Specify behavior in case the table is editable. If set to true, it won't render an additional empty column.
    [<CustomOperation("IgnoreEditable")>] member inline _.IgnoreEditable ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("IgnoreEditable" => (defaultArg x true))
    [<CustomOperation("IsExpandable")>] member inline _.IsExpandable ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("IsExpandable" => (defaultArg x true))
    /// On click event
    [<CustomOperation("OnRowClick")>] member inline _.OnRowClick ([<InlineIfLambda>] render: AttrRenderFragment, fn: Microsoft.AspNetCore.Components.Web.MouseEventArgs -> unit) = render ==> html.callback("OnRowClick", fn)
    /// On click event
    [<CustomOperation("OnRowClick")>] member inline _.OnRowClick ([<InlineIfLambda>] render: AttrRenderFragment, fn: Microsoft.AspNetCore.Components.Web.MouseEventArgs -> Task<unit>) = render ==> html.callbackTask("OnRowClick", fn)

type MudTrBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Item")>] member inline _.Item ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Object) = render ==> ("Item" => x)
    [<CustomOperation("IsCheckable")>] member inline _.IsCheckable ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("IsCheckable" => (defaultArg x true))
    [<CustomOperation("IsEditable")>] member inline _.IsEditable ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("IsEditable" => (defaultArg x true))
    [<CustomOperation("IsEditing")>] member inline _.IsEditing ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("IsEditing" => (defaultArg x true))
    [<CustomOperation("IsEditSwitchBlocked")>] member inline _.IsEditSwitchBlocked ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("IsEditSwitchBlocked" => (defaultArg x true))
    [<CustomOperation("IsExpandable")>] member inline _.IsExpandable ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("IsExpandable" => (defaultArg x true))
    [<CustomOperation("IsCheckedChanged")>] member inline _.IsCheckedChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.Boolean -> unit) = render ==> html.callback("IsCheckedChanged", fn)
    [<CustomOperation("IsCheckedChanged")>] member inline _.IsCheckedChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.Boolean -> Task<unit>) = render ==> html.callbackTask("IsCheckedChanged", fn)
    [<CustomOperation("IsChecked")>] member inline _.IsChecked ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("IsChecked" => (defaultArg x true))
    [<CustomOperation("IsChecked'")>] member inline _.IsChecked' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.Boolean * (System.Boolean -> unit)) = render ==> html.bind("IsChecked", valueFn)

type MudSimpleTableBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    /// Child content of component.
    [<CustomOperation("Elevation")>] member inline _.Elevation ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("Elevation" => x)
    /// If true, the table row will shade on hover.
    [<CustomOperation("Hover")>] member inline _.Hover ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Hover" => (defaultArg x true))
    /// If true, border-radius is set to 0.
    [<CustomOperation("Square")>] member inline _.Square ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Square" => (defaultArg x true))
    /// If true, compact padding will be used.
    [<CustomOperation("Dense")>] member inline _.Dense ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Dense" => (defaultArg x true))
    /// If true, table will be outlined.
    [<CustomOperation("Outlined")>] member inline _.Outlined ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Outlined" => (defaultArg x true))
    /// If true, table's cells will have left/right borders.
    [<CustomOperation("Bordered")>] member inline _.Bordered ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Bordered" => (defaultArg x true))
    /// If true, striped table rows will be used.
    [<CustomOperation("Striped")>] member inline _.Striped ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Striped" => (defaultArg x true))
    /// When true, the header will stay in place when the table is scrolled. Note: set Height to make the table scrollable.
    [<CustomOperation("FixedHeader")>] member inline _.FixedHeader ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("FixedHeader" => (defaultArg x true))

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
    [<CustomOperation("HideDot")>] member inline _.HideDot ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("HideDot" => (defaultArg x true))
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

type MudToggleGroupBuilder<'FunBlazorGeneric, 'T when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    /// The selected value in single- and toggle-selection mode.
    [<CustomOperation("Value")>] member inline _.Value ([<InlineIfLambda>] render: AttrRenderFragment, x: 'T) = render ==> ("Value" => x)
    /// The selected value in single- and toggle-selection mode.
    [<CustomOperation("Value'")>] member inline _.Value' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: 'T * ('T -> unit)) = render ==> html.bind("Value", valueFn)
    /// Fires when Value changes.
    [<CustomOperation("ValueChanged")>] member inline _.ValueChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: 'T -> unit) = render ==> html.callback("ValueChanged", fn)
    /// Fires when Value changes.
    [<CustomOperation("ValueChanged")>] member inline _.ValueChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: 'T -> Task<unit>) = render ==> html.callbackTask("ValueChanged", fn)
    /// The selected values for multi-selection mode.
    [<CustomOperation("Values")>] member inline _.Values ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.IEnumerable<'T>) = render ==> ("Values" => x)
    /// The selected values for multi-selection mode.
    [<CustomOperation("Values'")>] member inline _.Values' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.Collections.Generic.IEnumerable<'T> * (System.Collections.Generic.IEnumerable<'T> -> unit)) = render ==> html.bind("Values", valueFn)
    /// Fires when Values change.
    [<CustomOperation("ValuesChanged")>] member inline _.ValuesChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.Collections.Generic.IEnumerable<'T> -> unit) = render ==> html.callback("ValuesChanged", fn)
    /// Fires when Values change.
    [<CustomOperation("ValuesChanged")>] member inline _.ValuesChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.Collections.Generic.IEnumerable<'T> -> Task<unit>) = render ==> html.callbackTask("ValuesChanged", fn)
    /// Classes (separated by space) to be applied to the selected items only.
    [<CustomOperation("SelectedClass")>] member inline _.SelectedClass ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("SelectedClass" => x)
    /// Classes (separated by space) to be applied to the text of all toggle items.
    [<CustomOperation("TextClass")>] member inline _.TextClass ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("TextClass" => x)
    /// Classes (separated by space) to be applied to SelectedIcon/UnselectedIcon of the items (if CheckMark is true).
    [<CustomOperation("CheckMarkClass")>] member inline _.CheckMarkClass ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("CheckMarkClass" => x)
    /// If true, use vertical layout.
    [<CustomOperation("Vertical")>] member inline _.Vertical ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Vertical" => (defaultArg x true))
    /// If true, the first and last item will be rounded.
    [<CustomOperation("Rounded")>] member inline _.Rounded ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Rounded" => (defaultArg x true))
    /// If true, show an outline border. Default is true.
    [<CustomOperation("Outline")>] member inline _.Outline ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Outline" => (defaultArg x true))
    /// If true, show a line delimiter between items. Default is true.
    [<CustomOperation("Delimiters")>] member inline _.Delimiters ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Delimiters" => (defaultArg x true))
    /// If true, disables the ripple effect.
    [<CustomOperation("DisableRipple")>] member inline _.DisableRipple ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("DisableRipple" => (defaultArg x true))
    /// If true, the component's padding is reduced so it takes up less space.
    [<CustomOperation("Dense")>] member inline _.Dense ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Dense" => (defaultArg x true))
    /// The selection behavior of the group. SingleSelection (the default) is a radio-button like exclusive collection. 
    /// MultiSelection behaves like a group of check boxes. ToggleSelection is an exclusive single selection where
    /// you can also select nothing by toggling off the current choice.
    [<CustomOperation("SelectionMode")>] member inline _.SelectionMode ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.SelectionMode) = render ==> ("SelectionMode" => x)
    /// The color of the component. Affects borders and selection color. Default is Colors.Primary.
    [<CustomOperation("Color")>] member inline _.Color ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("Color" => x)
    /// If true, the items show a check mark next to the text or render fragment. Customize the check mark by setting
    /// SelectedIcon and UnselectedIcon 
    [<CustomOperation("CheckMark")>] member inline _.CheckMark ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("CheckMark" => (defaultArg x true))
    /// If true, the check mark is counter balanced with padding on the right side which makes the content stay always
    /// centered no matter if the check mark is shown or not. 
    [<CustomOperation("FixedContent")>] member inline _.FixedContent ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("FixedContent" => (defaultArg x true))

type MudToggleItemBuilder<'FunBlazorGeneric, 'T when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Value")>] member inline _.Value ([<InlineIfLambda>] render: AttrRenderFragment, x: 'T) = render ==> ("Value" => x)
    /// Icon to show if the item is not selected (if CheckMark is true on the parent group)
    /// Leave null to show no check mark (default).
    [<CustomOperation("UnselectedIcon")>] member inline _.UnselectedIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("UnselectedIcon" => x)
    /// Icon to show if the item is selected (if CheckMark is true on the parent group)
    /// By default this is set to a check mark icon.
    [<CustomOperation("SelectedIcon")>] member inline _.SelectedIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("SelectedIcon" => x)
    /// The text to show. You need to set this only if you want a text that differs from the Value. If null,
    /// show Value?.ToString().
    /// Note: the Text is only shown if you haven't defined your own child content
    [<CustomOperation("Text")>] member inline _.Text ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Text" => x)
    /// Custom child content which overrides the text. The boolean parameter conveys whether or not the item is selected. 
    [<CustomOperation("ChildContent")>] member inline _.ChildContent ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.Boolean -> NodeRenderFragment) = render ==> html.renderFragment("ChildContent", fn)

type MudTooltipBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    /// The color of the component. It supports the theme colors.
    [<CustomOperation("Color")>] member inline _.Color ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("Color" => x)
    /// Sets the text to be displayed inside the tooltip.
    [<CustomOperation("Text")>] member inline _.Text ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Text" => x)
    /// If true, a arrow will be displayed pointing towards the content from the tooltip.
    [<CustomOperation("Arrow")>] member inline _.Arrow ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Arrow" => (defaultArg x true))
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
    [<CustomOperation("Inline")>] member inline _.Inline ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Inline" => (defaultArg x true))
    /// Styles applied directly to root component of the tooltip
    [<CustomOperation("RootStyle")>] member inline _.RootStyle ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("RootStyle" => x)
    [<CustomOperation("RootClass")>] member inline _.RootClass ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("RootClass" => x)
    /// Determines on which events the tooltip will act
    [<CustomOperation("ShowOnHover")>] member inline _.ShowOnHover ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("ShowOnHover" => (defaultArg x true))
    /// Determines on which events the tooltip will act
    [<CustomOperation("ShowOnFocus")>] member inline _.ShowOnFocus ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("ShowOnFocus" => (defaultArg x true))
    [<CustomOperation("ShowOnClick")>] member inline _.ShowOnClick ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("ShowOnClick" => (defaultArg x true))
    /// The visible state of the Tooltip.
    [<CustomOperation("IsVisible")>] member inline _.IsVisible ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("IsVisible" => (defaultArg x true))
    /// The visible state of the Tooltip.
    [<CustomOperation("IsVisible'")>] member inline _.IsVisible' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.Boolean * (System.Boolean -> unit)) = render ==> html.bind("IsVisible", valueFn)
    /// An event triggered when the state of IsVisible has changed
    [<CustomOperation("IsVisibleChanged")>] member inline _.IsVisibleChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.Boolean -> unit) = render ==> html.callback("IsVisibleChanged", fn)
    /// An event triggered when the state of IsVisible has changed
    [<CustomOperation("IsVisibleChanged")>] member inline _.IsVisibleChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.Boolean -> Task<unit>) = render ==> html.callbackTask("IsVisibleChanged", fn)

type MudTreeViewBuilder<'FunBlazorGeneric, 'T when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    /// The color of the selected treeviewitem.
    [<CustomOperation("Color")>] member inline _.Color ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("Color" => x)
    /// Check box color if multiselection is used.
    [<CustomOperation("CheckBoxColor")>] member inline _.CheckBoxColor ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("CheckBoxColor" => x)
    /// if true, multiple values can be selected via checkboxes which are automatically shown in the tree view.
    [<CustomOperation("MultiSelection")>] member inline _.MultiSelection ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("MultiSelection" => (defaultArg x true))
    /// If true, clicking anywhere on the item will expand it, if it has children.
    [<CustomOperation("ExpandOnClick")>] member inline _.ExpandOnClick ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("ExpandOnClick" => (defaultArg x true))
    /// If true, double-clicking anywhere on the item will expand it, if it has children.
    [<CustomOperation("ExpandOnDoubleClick")>] member inline _.ExpandOnDoubleClick ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("ExpandOnDoubleClick" => (defaultArg x true))
    /// Hover effect for item's on mouse-over.
    [<CustomOperation("Hover")>] member inline _.Hover ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Hover" => (defaultArg x true))
    /// If true, compact vertical padding will be applied to all treeview items.
    [<CustomOperation("Dense")>] member inline _.Dense ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Dense" => (defaultArg x true))
    /// Setting a height will allow to scroll the treeview. If not set, it will try to grow in height.
    /// You can set this to any CSS value that the attribute 'height' accepts, i.e. 500px.
    [<CustomOperation("Height")>] member inline _.Height ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Height" => x)
    /// Setting a maximum height will allow to scroll the treeview. If not set, it will try to grow in height.
    /// You can set this to any CSS value that the attribute 'height' accepts, i.e. 500px.
    [<CustomOperation("MaxHeight")>] member inline _.MaxHeight ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("MaxHeight" => x)
    /// Setting a width the treeview. You can set this to any CSS value that the attribute 'height' accepts, i.e. 500px.
    [<CustomOperation("Width")>] member inline _.Width ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Width" => x)
    /// If true, treeview will be disabled and all its childitems.
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Disabled" => (defaultArg x true))
    [<CustomOperation("Items")>] member inline _.Items ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.HashSet<'T>) = render ==> ("Items" => x)
    [<CustomOperation("SelectedValue")>] member inline _.SelectedValue ([<InlineIfLambda>] render: AttrRenderFragment, x: 'T) = render ==> ("SelectedValue" => x)
    [<CustomOperation("SelectedValue'")>] member inline _.SelectedValue' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: 'T * ('T -> unit)) = render ==> html.bind("SelectedValue", valueFn)
    /// Called whenever the selected value changed.
    [<CustomOperation("SelectedValueChanged")>] member inline _.SelectedValueChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: 'T -> unit) = render ==> html.callback("SelectedValueChanged", fn)
    /// Called whenever the selected value changed.
    [<CustomOperation("SelectedValueChanged")>] member inline _.SelectedValueChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: 'T -> Task<unit>) = render ==> html.callbackTask("SelectedValueChanged", fn)
    /// Called whenever the selectedvalues changed.
    [<CustomOperation("SelectedValuesChanged")>] member inline _.SelectedValuesChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.Collections.Generic.HashSet<'T> -> unit) = render ==> html.callback("SelectedValuesChanged", fn)
    /// Called whenever the selectedvalues changed.
    [<CustomOperation("SelectedValuesChanged")>] member inline _.SelectedValuesChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.Collections.Generic.HashSet<'T> -> Task<unit>) = render ==> html.callbackTask("SelectedValuesChanged", fn)
    /// ItemTemplate for rendering children.
    [<CustomOperation("ItemTemplate")>] member inline _.ItemTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fn: 'T -> NodeRenderFragment) = render ==> html.renderFragment("ItemTemplate", fn)
    /// Comparer is used to check if two tree items are equal
    [<CustomOperation("Comparer")>] member inline _.Comparer ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.IEqualityComparer<'T>) = render ==> ("Comparer" => x)
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
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Disabled" => (defaultArg x true))
    /// If false, TreeViewItem will not be able to expand.
    [<CustomOperation("CanExpand")>] member inline _.CanExpand ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("CanExpand" => (defaultArg x true))
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
    /// Content of the item body, if used replaced the text, end text and end icon rendering.
    [<CustomOperation("BodyContent")>] member inline _.BodyContent ([<InlineIfLambda>] render: AttrRenderFragment, fn: MudBlazor.MudTreeViewItem<'T> -> NodeRenderFragment) = render ==> html.renderFragment("BodyContent", fn)
    [<CustomOperation("Items")>] member inline _.Items ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.HashSet<'T>) = render ==> ("Items" => x)
    /// Command executed when the user clicks on the CommitEdit Button.
    [<CustomOperation("Command")>] member inline _.Command ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Windows.Input.ICommand) = render ==> ("Command" => x)
    /// Expand or collapse treeview item when it has children. Two-way bindable. Note: if you directly set this to
    /// true or false (instead of using two-way binding) it will force the item's expansion state.
    [<CustomOperation("Expanded")>] member inline _.Expanded ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Expanded" => (defaultArg x true))
    /// Expand or collapse treeview item when it has children. Two-way bindable. Note: if you directly set this to
    /// true or false (instead of using two-way binding) it will force the item's expansion state.
    [<CustomOperation("Expanded'")>] member inline _.Expanded' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.Boolean * (System.Boolean -> unit)) = render ==> html.bind("Expanded", valueFn)
    /// Called whenever expanded changed.
    [<CustomOperation("ExpandedChanged")>] member inline _.ExpandedChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.Boolean -> unit) = render ==> html.callback("ExpandedChanged", fn)
    /// Called whenever expanded changed.
    [<CustomOperation("ExpandedChanged")>] member inline _.ExpandedChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.Boolean -> Task<unit>) = render ==> html.callbackTask("ExpandedChanged", fn)
    [<CustomOperation("Activated")>] member inline _.Activated ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Activated" => (defaultArg x true))
    [<CustomOperation("Activated'")>] member inline _.Activated' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.Boolean * (System.Boolean -> unit)) = render ==> html.bind("Activated", valueFn)
    [<CustomOperation("Selected")>] member inline _.Selected ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Selected" => (defaultArg x true))
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
    [<CustomOperation("ActivatedChanged")>] member inline _.ActivatedChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.Boolean -> unit) = render ==> html.callback("ActivatedChanged", fn)
    /// Called whenever the activated value changed.
    [<CustomOperation("ActivatedChanged")>] member inline _.ActivatedChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.Boolean -> Task<unit>) = render ==> html.callbackTask("ActivatedChanged", fn)
    /// Called whenever the selected value changed.
    [<CustomOperation("SelectedChanged")>] member inline _.SelectedChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.Boolean -> unit) = render ==> html.callback("SelectedChanged", fn)
    /// Called whenever the selected value changed.
    [<CustomOperation("SelectedChanged")>] member inline _.SelectedChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.Boolean -> Task<unit>) = render ==> html.callbackTask("SelectedChanged", fn)
    /// Tree item click event.
    [<CustomOperation("OnClick")>] member inline _.OnClick ([<InlineIfLambda>] render: AttrRenderFragment, fn: Microsoft.AspNetCore.Components.Web.MouseEventArgs -> unit) = render ==> html.callback("OnClick", fn)
    /// Tree item click event.
    [<CustomOperation("OnClick")>] member inline _.OnClick ([<InlineIfLambda>] render: AttrRenderFragment, fn: Microsoft.AspNetCore.Components.Web.MouseEventArgs -> Task<unit>) = render ==> html.callbackTask("OnClick", fn)
    /// Tree item double click event.
    [<CustomOperation("OnDoubleClick")>] member inline _.OnDoubleClick ([<InlineIfLambda>] render: AttrRenderFragment, fn: Microsoft.AspNetCore.Components.Web.MouseEventArgs -> unit) = render ==> html.callback("OnDoubleClick", fn)
    /// Tree item double click event.
    [<CustomOperation("OnDoubleClick")>] member inline _.OnDoubleClick ([<InlineIfLambda>] render: AttrRenderFragment, fn: Microsoft.AspNetCore.Components.Web.MouseEventArgs -> Task<unit>) = render ==> html.callbackTask("OnDoubleClick", fn)

type MudTextBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    /// Applies the theme typography styles.
    [<CustomOperation("Typo")>] member inline _.Typo ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Typo) = render ==> ("Typo" => x)
    /// Set the text-align on the component.
    [<CustomOperation("Align")>] member inline _.Align ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Align) = render ==> ("Align" => x)
    /// The color of the component. It supports the theme colors.
    [<CustomOperation("Color")>] member inline _.Color ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("Color" => x)
    /// If true, the text will have a bottom margin.
    [<CustomOperation("GutterBottom")>] member inline _.GutterBottom ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("GutterBottom" => (defaultArg x true))
    /// If true, Sets display inline
    [<CustomOperation("Inline")>] member inline _.Inline ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Inline" => (defaultArg x true))

type MudContainerBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    /// Set the max-width to match the min-width of the current breakpoint. This is useful if you'd prefer to design for a fixed set of sizes instead of trying to accommodate a fully fluid viewport. It's fluid by default.
    [<CustomOperation("Fixed")>] member inline _.Fixed ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Fixed" => (defaultArg x true))
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
    [<CustomOperation("Absolute")>] member inline _.Absolute ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Absolute" => (defaultArg x true))
    /// If true, a vertical divider will have the correct height when used in flex container.
    [<CustomOperation("FlexItem")>] member inline _.FlexItem ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("FlexItem" => (defaultArg x true))
    /// If true, the divider will have a lighter color.
    [<CustomOperation("Light")>] member inline _.Light ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Light" => (defaultArg x true))
    /// If true, the divider is displayed vertically.
    [<CustomOperation("Vertical")>] member inline _.Vertical ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Vertical" => (defaultArg x true))
    /// The Divider type to use.
    [<CustomOperation("DividerType")>] member inline _.DividerType ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.DividerType) = render ==> ("DividerType" => x)

type MudDrawerHeaderBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    /// If true, compact padding will be used, same as the Appbar.
    [<CustomOperation("Dense")>] member inline _.Dense ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Dense" => (defaultArg x true))
    /// If true, the component will link to index page with an a element instead of div.
    [<CustomOperation("LinkToIndex")>] member inline _.LinkToIndex ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("LinkToIndex" => (defaultArg x true))

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
    /// Text will be displayed in the TabPanel as TabTitle. Text is no longer rendered
    /// as a MarkupString, so use the TabContent RenderFragment instead for HTML content.
    [<CustomOperation("Text")>] member inline _.Text ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Text" => x)
    /// Icon placed before the text if set.
    [<CustomOperation("Icon")>] member inline _.Icon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Icon" => x)
    /// If true, the tabpanel will be disabled.
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Disabled" => (defaultArg x true))
    /// MudDynamicTabs: If true, shows the close icon in the TabPanel.
    [<CustomOperation("ShowCloseIcon")>] member inline _.ShowCloseIcon ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("ShowCloseIcon" => (defaultArg x true))
    /// Optional information to be showed into a badge
    [<CustomOperation("BadgeData")>] member inline _.BadgeData ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Object) = render ==> ("BadgeData" => x)
    /// Optional information to show the badge as a dot.
    [<CustomOperation("BadgeDot")>] member inline _.BadgeDot ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("BadgeDot" => (defaultArg x true))
    /// The color of the badge.
    [<CustomOperation("BadgeColor")>] member inline _.BadgeColor ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("BadgeColor" => x)
    /// Unique TabPanel ID. Useful for activation when Panels are dynamically generated.
    [<CustomOperation("ID")>] member inline _.ID ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Object) = render ==> ("ID" => x)
    /// Raised when tab is clicked
    [<CustomOperation("OnClick")>] member inline _.OnClick ([<InlineIfLambda>] render: AttrRenderFragment, fn: Microsoft.AspNetCore.Components.Web.MouseEventArgs -> unit) = render ==> html.callback("OnClick", fn)
    /// Raised when tab is clicked
    [<CustomOperation("OnClick")>] member inline _.OnClick ([<InlineIfLambda>] render: AttrRenderFragment, fn: Microsoft.AspNetCore.Components.Web.MouseEventArgs -> Task<unit>) = render ==> html.callbackTask("OnClick", fn)
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
    [<CustomOperation("Dense")>] member inline _.Dense ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Dense" => (defaultArg x true))
    /// If true, disables gutter padding.
    [<CustomOperation("DisableGutters")>] member inline _.DisableGutters ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("DisableGutters" => (defaultArg x true))
    /// If true, ToolBar is allowed to wrap.
    [<CustomOperation("WrapContent")>] member inline _.WrapContent ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("WrapContent" => (defaultArg x true))

type MudBaseColumnBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAndChildAttrBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Visible")>] member inline _.Visible ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Visible" => (defaultArg x true))
    [<CustomOperation("HeaderText")>] member inline _.HeaderText ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("HeaderText" => x)

/// Binds an object's property to a column by its property name 
type MudColumnBuilder<'FunBlazorGeneric, 'T when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudBaseColumnBuilder<'FunBlazorGeneric>()
    /// Specifies the name of the object's property bound to the column
    [<CustomOperation("Value")>] member inline _.Value ([<InlineIfLambda>] render: AttrRenderFragment, x: 'T) = render ==> ("Value" => x)
    /// Specifies the name of the object's property bound to the column
    [<CustomOperation("Value'")>] member inline _.Value' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: 'T * ('T -> unit)) = render ==> html.bind("Value", valueFn)
    [<CustomOperation("ValueChanged")>] member inline _.ValueChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: 'T -> unit) = render ==> html.callback("ValueChanged", fn)
    [<CustomOperation("ValueChanged")>] member inline _.ValueChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: 'T -> Task<unit>) = render ==> html.callbackTask("ValueChanged", fn)
    [<CustomOperation("FooterValue")>] member inline _.FooterValue ([<InlineIfLambda>] render: AttrRenderFragment, x: 'T) = render ==> ("FooterValue" => x)
    /// Used if no FooterValue is available
    [<CustomOperation("FooterText")>] member inline _.FooterText ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("FooterText" => x)
    /// Specifies which string format should be used.
    [<CustomOperation("DataFormatString")>] member inline _.DataFormatString ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("DataFormatString" => x)
    [<CustomOperation("ReadOnly")>] member inline _.ReadOnly ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("ReadOnly" => (defaultArg x true))

/// Binds an object's property to a column by its property name 
type MudSortableColumnBuilder<'FunBlazorGeneric, 'T, 'ModelType when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudBaseColumnBuilder<'FunBlazorGeneric>()
    /// Specifies the name of the object's property bound to the column
    [<CustomOperation("Value")>] member inline _.Value ([<InlineIfLambda>] render: AttrRenderFragment, x: 'T) = render ==> ("Value" => x)
    /// Specifies the name of the object's property bound to the column
    [<CustomOperation("Value'")>] member inline _.Value' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: 'T * ('T -> unit)) = render ==> html.bind("Value", valueFn)
    [<CustomOperation("ValueChanged")>] member inline _.ValueChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: 'T -> unit) = render ==> html.callback("ValueChanged", fn)
    [<CustomOperation("ValueChanged")>] member inline _.ValueChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: 'T -> Task<unit>) = render ==> html.callbackTask("ValueChanged", fn)
    /// Specifies the name of the object's property bound to the footer
    [<CustomOperation("FooterValue")>] member inline _.FooterValue ([<InlineIfLambda>] render: AttrRenderFragment, x: 'T) = render ==> ("FooterValue" => x)
    /// Used if no FooterValue is available
    [<CustomOperation("FooterText")>] member inline _.FooterText ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("FooterText" => x)
    /// Specifies which string format should be used.
    [<CustomOperation("DataFormatString")>] member inline _.DataFormatString ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("DataFormatString" => x)
    /// Specifies if the column should be readonly even if the DataTable is in editmode.
    [<CustomOperation("ReadOnly")>] member inline _.ReadOnly ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("ReadOnly" => (defaultArg x true))
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

type MudThemingProviderBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAndChildAttrBuilder<'FunBlazorGeneric>()
    /// The theme used by the application.
    [<CustomOperation("Theme")>] member inline _.Theme ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.MudTheme) = render ==> ("Theme" => x)
    /// If true, will not apply MudBlazor styled scrollbar and use browser default. 
    ///             
    [<CustomOperation("DefaultScrollbar")>] member inline _.DefaultScrollbar ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("DefaultScrollbar" => (defaultArg x true))
    /// The active palette of the theme.
    [<CustomOperation("IsDarkMode")>] member inline _.IsDarkMode ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("IsDarkMode" => (defaultArg x true))
    /// The active palette of the theme.
    [<CustomOperation("IsDarkMode'")>] member inline _.IsDarkMode' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.Boolean * (System.Boolean -> unit)) = render ==> html.bind("IsDarkMode", valueFn)
    /// Invoked when the dark mode changes.
    [<CustomOperation("IsDarkModeChanged")>] member inline _.IsDarkModeChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.Boolean -> unit) = render ==> html.callback("IsDarkModeChanged", fn)
    /// Invoked when the dark mode changes.
    [<CustomOperation("IsDarkModeChanged")>] member inline _.IsDarkModeChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.Boolean -> Task<unit>) = render ==> html.callbackTask("IsDarkModeChanged", fn)

type MudThemeProviderBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudThemingProviderBuilder<'FunBlazorGeneric>()


type SelectColumnBuilder<'FunBlazorGeneric, 'T when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAndChildAttrBuilder<'FunBlazorGeneric>()
    [<CustomOperation("ShowInHeader")>] member inline _.ShowInHeader ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("ShowInHeader" => (defaultArg x true))
    [<CustomOperation("ShowInFooter")>] member inline _.ShowInFooter ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("ShowInFooter" => (defaultArg x true))
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
    inherit ComponentWithDomAttrBuilder<'FunBlazorGeneric>()
    /// Set false to turn off virtualization
    [<CustomOperation("IsEnabled")>] member inline _.IsEnabled ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("IsEnabled" => (defaultArg x true))
    /// Gets or sets the item template for the list.
    [<CustomOperation("ChildContent")>] member inline _.ChildContent ([<InlineIfLambda>] render: AttrRenderFragment, fn: 'T -> NodeRenderFragment) = render ==> html.renderFragment("ChildContent", fn)
    /// Gets or sets the fixed item source.
    [<CustomOperation("Items")>] member inline _.Items ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.ICollection<'T>) = render ==> ("Items" => x)
    /// Gets or sets a value that determines how many additional items will be rendered
    /// before and after the visible region. This help to reduce the frequency of rendering
    /// during scrolling. However, higher values mean that more elements will be present
    /// in the page.
    [<CustomOperation("OverscanCount")>] member inline _.OverscanCount ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("OverscanCount" => x)
    /// Gets the size of each item in pixels. Defaults to 50px.
    [<CustomOperation("ItemSize")>] member inline _.ItemSize ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Single) = render ==> ("ItemSize" => x)

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
    [<CustomOperation("DisableToolbar")>] member inline _.DisableToolbar ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("DisableToolbar" => (defaultArg x true))
    [<CustomOperation("Orientation")>] member inline _.Orientation ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Orientation) = render ==> ("Orientation" => x)
    [<CustomOperation("PickerVariant")>] member inline _.PickerVariant ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.PickerVariant) = render ==> ("PickerVariant" => x)
    [<CustomOperation("Color")>] member inline _.Color ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("Color" => x)

type MudRenderBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAndChildAttrBuilder<'FunBlazorGeneric>()


type MudSpacerBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAndChildAttrBuilder<'FunBlazorGeneric>()


type MudTreeViewItemToggleButtonBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAndChildAttrBuilder<'FunBlazorGeneric>()
    /// If true, displays the button.
    [<CustomOperation("Visible")>] member inline _.Visible ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Visible" => (defaultArg x true))
    /// Determines when to flip the expanded icon.
    [<CustomOperation("Expanded")>] member inline _.Expanded ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Expanded" => (defaultArg x true))
    /// Determines when to flip the expanded icon.
    [<CustomOperation("Expanded'")>] member inline _.Expanded' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.Boolean * (System.Boolean -> unit)) = render ==> html.bind("Expanded", valueFn)
    /// If true, displays the loading icon.
    [<CustomOperation("Loading")>] member inline _.Loading ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Loading" => (defaultArg x true))
    /// Called whenever expanded changed.
    [<CustomOperation("ExpandedChanged")>] member inline _.ExpandedChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.Boolean -> unit) = render ==> html.callback("ExpandedChanged", fn)
    /// Called whenever expanded changed.
    [<CustomOperation("ExpandedChanged")>] member inline _.ExpandedChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.Boolean -> Task<unit>) = render ==> html.callbackTask("ExpandedChanged", fn)
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

open System.Threading.Tasks
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
    [<CustomOperation("AdornmentClick")>] member inline _.AdornmentClick ([<InlineIfLambda>] render: AttrRenderFragment, fn: Microsoft.AspNetCore.Components.Web.MouseEventArgs -> unit) = render ==> html.callback("AdornmentClick", fn)
    [<CustomOperation("AdornmentClick")>] member inline _.AdornmentClick ([<InlineIfLambda>] render: AttrRenderFragment, fn: Microsoft.AspNetCore.Components.Web.MouseEventArgs -> Task<unit>) = render ==> html.callbackTask("AdornmentClick", fn)

            
namespace rec MudBlazor.DslInternals.Components.Snackbar.InternalComponents

open System.Threading.Tasks
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

open System.Threading.Tasks
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

    /// Base class for implementing Popover component.
    type MudPopoverBase' 
        /// Base class for implementing Popover component.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudPopoverBase>)>] () = inherit MudPopoverBaseBuilder<MudBlazor.MudPopoverBase>()
    type MudPopover' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudPopover>)>] () = inherit MudPopoverBuilder<MudBlazor.MudPopover>()
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
    type MudToggleGroup'<'T> [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudToggleGroup<_>>)>] () = inherit MudToggleGroupBuilder<MudBlazor.MudToggleGroup<'T>, 'T>()
    type MudToggleItem'<'T> [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudToggleItem<_>>)>] () = inherit MudToggleItemBuilder<MudBlazor.MudToggleItem<'T>, 'T>()
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
    type MudThemingProvider' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudThemingProvider>)>] () = inherit MudThemingProviderBuilder<MudBlazor.MudThemingProvider>()
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
    type StackedBar' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.Charts.StackedBar>)>] () = inherit StackedBarBuilder<MudBlazor.Charts.StackedBar>()
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
            