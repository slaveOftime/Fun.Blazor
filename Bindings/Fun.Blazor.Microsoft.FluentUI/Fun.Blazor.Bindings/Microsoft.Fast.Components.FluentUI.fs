namespace rec Microsoft.Fast.Components.FluentUI.DslInternals

open FSharp.Data.Adaptive
open Fun.Blazor
open Fun.Blazor.Operators
open Microsoft.Fast.Components.FluentUI.DslInternals

type FluentComponentBaseBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAndChildAttrBuilder<'FunBlazorGeneric>()
    /// Unique identifier. If not provided, a random value will be generated.
    /// The value will be used as the HTML global id attribute.
    [<CustomOperation("Id")>] member inline _.Id ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Id" => x)
    /// Optional CSS class names. If given, these will be included in the class attribute of the component.
    [<CustomOperation("Classes")>] member inline _.Classes ([<InlineIfLambda>] render: AttrRenderFragment, x: string list) = render ==> html.classes x
    /// Optional in-line styles. If given, these will be included in the style attribute of the component.
    [<CustomOperation("Styles")>] member inline _.Styles ([<InlineIfLambda>] render: AttrRenderFragment, x: (string * string) list) = render ==> html.styles x
    /// Used to attach any user data object to the component.
    [<CustomOperation("Data")>] member inline _.Data ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Object) = render ==> ("Data" => x)
    /// A reference to the enclosing component.
    [<CustomOperation("ParentReference")>] member inline _.ParentReference ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.Fast.Components.FluentUI.DesignTokens.Reference) = render ==> ("ParentReference" => x)
    /// Gets or sets a collection of additional attributes that will be applied to the created element.
    [<CustomOperation("AdditionalAttributes")>] member inline _.AdditionalAttributes ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.IReadOnlyDictionary<System.String, System.Object>) = render ==> ("AdditionalAttributes" => x)

type FluentCalendarBaseBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentComponentBaseBuilder<'FunBlazorGeneric>()
    /// Gets or sets if the calendar is readonly 
    [<CustomOperation("ReadOnly")>] member inline _.ReadOnly ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("ReadOnly" => x)
    /// The culture of the component.
    /// By default CurrentCulture to display using the OS culture.
    [<CustomOperation("Culture")>] member inline _.Culture ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Globalization.CultureInfo) = render ==> ("Culture" => x)
    /// Function to know if a specific day must be disabled.
    [<CustomOperation("DisabledDateFunc")>] member inline _.DisabledDateFunc ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("DisabledDateFunc" => (System.Func<System.DateTime, System.Boolean>fn))
    /// Apply the disabled style to the DisabledDateFunc days.
    /// If this is not the case, the days are displayed like the others, but cannot be selected.
    [<CustomOperation("DisabledSelectable")>] member inline _.DisabledSelectable ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("DisabledSelectable" => x)
    /// Type style for the day (numeric or 2-digits).
    [<CustomOperation("DayFormat")>] member inline _.DayFormat ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<Microsoft.Fast.Components.FluentUI.DayFormat>) = render ==> ("DayFormat" => x)
    /// Selected date (two-way bindable).
    [<CustomOperation("Value")>] member inline _.Value ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.DateTime>) = render ==> ("Value" => x)
    /// Selected date (two-way bindable).
    [<CustomOperation("Value'")>] member inline _.Value' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.Nullable<System.DateTime> * (System.Nullable<System.DateTime> -> unit)) = render ==> html.bind("Value", valueFn)
    /// Fired when the display month changes.
    [<CustomOperation("ValueChanged")>] member inline _.ValueChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callback<System.Nullable<System.DateTime>>("ValueChanged", fn)
    /// Fired when the display month changes.
    [<CustomOperation("ValueChanged")>] member inline _.ValueChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callbackTask<System.Nullable<System.DateTime>>("ValueChanged", fn)

/// Fluent Calendar based on
/// https://github.com/microsoft/fluentui/blob/master/packages/web-components/src/calendar/.
type FluentCalendarBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentCalendarBaseBuilder<'FunBlazorGeneric>()
    /// The current month of the date picker (two-way bindable).
    /// This changes when the user browses through the calendar.
    /// The month is represented as a DateTime which is always the first day of that month.
    /// You can also set this to determine which month is displayed first.
    /// If not set, the current month is displayed.
    [<CustomOperation("PickerMonth")>] member inline _.PickerMonth ([<InlineIfLambda>] render: AttrRenderFragment, x: System.DateTime) = render ==> ("PickerMonth" => x)
    /// The current month of the date picker (two-way bindable).
    /// This changes when the user browses through the calendar.
    /// The month is represented as a DateTime which is always the first day of that month.
    /// You can also set this to determine which month is displayed first.
    /// If not set, the current month is displayed.
    [<CustomOperation("PickerMonth'")>] member inline _.PickerMonth' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.DateTime * (System.DateTime -> unit)) = render ==> html.bind("PickerMonth", valueFn)
    /// Fired when the display month changes.
    [<CustomOperation("PickerMonthChanged")>] member inline _.PickerMonthChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callback<System.DateTime>("PickerMonthChanged", fn)
    /// Fired when the display month changes.
    [<CustomOperation("PickerMonthChanged")>] member inline _.PickerMonthChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callbackTask<System.DateTime>("PickerMonthChanged", fn)
    /// Defines the appearance of a Day cell.
    [<CustomOperation("DaysTemplate")>] member inline _.DaysTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fn: Microsoft.Fast.Components.FluentUI.FluentCalendarDay -> NodeRenderFragment) = render ==> html.renderFragment("DaysTemplate", fn)

type FluentDatePickerBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentCalendarBaseBuilder<'FunBlazorGeneric>()
    /// Text displayed just above the component
    [<CustomOperation("Label")>] member inline _.Label ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Label" => x)
    /// Content displayed just above the component
    [<CustomOperation("LabelTemplate")>] member inline _.LabelTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragment) = render ==> html.renderFragment("LabelTemplate", fragment)
    /// Content displayed just above the component
    [<CustomOperation("LabelTemplate")>] member inline _.LabelTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragments) = render ==> html.renderFragment("LabelTemplate", fragment { yield! fragments })
    /// Content displayed just above the component
    [<CustomOperation("LabelTemplate")>] member inline _.LabelTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("LabelTemplate", html.text x)
    /// Content displayed just above the component
    [<CustomOperation("LabelTemplate")>] member inline _.LabelTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("LabelTemplate", html.text x)
    /// Content displayed just above the component
    [<CustomOperation("LabelTemplate")>] member inline _.LabelTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("LabelTemplate", html.text x)
    /// Text used on aria-label attribute.
    [<CustomOperation("AriaLabel")>] member inline _.AriaLabel ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("AriaLabel" => x)
    /// Gets or sets the design of this input.
    [<CustomOperation("Appearance")>] member inline _.Appearance ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.Fast.Components.FluentUI.FluentInputAppearance) = render ==> ("Appearance" => x)
    /// Disables the form control, ensuring it doesn't participate in form submission.
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("Disabled" => x)
    /// The name of the element.Allows access by name from the associated form.
    [<CustomOperation("Name")>] member inline _.Name ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Name" => x)
    /// Whether the element needs to have a value
    [<CustomOperation("Required")>] member inline _.Required ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("Required" => x)
    /// Determines if the element should receive document focus on page load.
    [<CustomOperation("Autofocus")>] member inline _.Autofocus ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("Autofocus" => x)
    /// The short hint displayed in the input before the user enters a value.
    [<CustomOperation("Placeholder")>] member inline _.Placeholder ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Placeholder" => x)
    [<CustomOperation("OnCalendarOpen")>] member inline _.OnCalendarOpen ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callback<System.Boolean>("OnCalendarOpen", fn)
    [<CustomOperation("OnCalendarOpen")>] member inline _.OnCalendarOpen ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callbackTask<System.Boolean>("OnCalendarOpen", fn)

/// Base class for FluentNavMenuGroup and FluentNavMenuItemBase.
type FluentNavMenuItemBaseBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentComponentBaseBuilder<'FunBlazorGeneric>()
    /// Gets or sets whether the link is disabled.
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("Disabled" => x)
    /// Gets or sets the destination of the link.
    [<CustomOperation("Href")>] member inline _.Href ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Href" => x)
    /// Gets or sets the icon to display with the link
    /// Use a constant value from the FluentIcon`1 class 
    [<CustomOperation("Icon")>] member inline _.Icon ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.Fast.Components.FluentUI.Icon) = render ==> ("Icon" => x)
    /// Called when the user attempts to execute the default action of a menu item.
    [<CustomOperation("OnAction")>] member inline _.OnAction ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callback<Microsoft.Fast.Components.FluentUI.NavMenuActionArgs>("OnAction", fn)
    /// Called when the user attempts to execute the default action of a menu item.
    [<CustomOperation("OnAction")>] member inline _.OnAction ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callbackTask<Microsoft.Fast.Components.FluentUI.NavMenuActionArgs>("OnAction", fn)
    /// Gets or sets if the item is selected.
    [<CustomOperation("Selected")>] member inline _.Selected ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("Selected" => x)
    /// Gets or sets if the item is selected.
    [<CustomOperation("Selected'")>] member inline _.Selected' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.Boolean * (System.Boolean -> unit)) = render ==> html.bind("Selected", valueFn)
    /// Event callback for when Selected changes.
    [<CustomOperation("SelectedChanged")>] member inline _.SelectedChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callback<System.Boolean>("SelectedChanged", fn)
    /// Event callback for when Selected changes.
    [<CustomOperation("SelectedChanged")>] member inline _.SelectedChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callbackTask<System.Boolean>("SelectedChanged", fn)
    /// Gets or sets the text of the link.
    [<CustomOperation("Text")>] member inline _.Text ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Text" => x)
    /// Gets or sets the width of the link (in pixels).
    [<CustomOperation("Width")>] member inline _.Width ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Int32>) = render ==> ("Width" => x)

type FluentNavMenuGroupBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentNavMenuItemBaseBuilder<'FunBlazorGeneric>()
    /// Returns true if the group is expanded,
    /// and false if collapsed.
    [<CustomOperation("Expanded")>] member inline _.Expanded ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("Expanded" => x)
    /// Returns true if the group is expanded,
    /// and false if collapsed.
    [<CustomOperation("Expanded'")>] member inline _.Expanded' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.Boolean * (System.Boolean -> unit)) = render ==> html.bind("Expanded", valueFn)
    /// Gets or sets a callback that is triggered whenever Expanded changes.
    [<CustomOperation("ExpandedChanged")>] member inline _.ExpandedChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callback<System.Boolean>("ExpandedChanged", fn)
    /// Gets or sets a callback that is triggered whenever Expanded changes.
    [<CustomOperation("ExpandedChanged")>] member inline _.ExpandedChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callbackTask<System.Boolean>("ExpandedChanged", fn)
    /// If set to true then the tree will
    /// expand when it is created.
    [<CustomOperation("InitiallyExpanded")>] member inline _.InitiallyExpanded ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("InitiallyExpanded" => x)

type FluentNavMenuLinkBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentNavMenuItemBaseBuilder<'FunBlazorGeneric>()


/// Base class for FluentNavGroup and FluentNavLink.
type FluentNavBaseBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentComponentBaseBuilder<'FunBlazorGeneric>()
    /// URL for the group.
    [<CustomOperation("Href")>] member inline _.Href ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Href" => x)
    /// The target attribute specifies where to open the group, if Href is specified. 
    /// Possible values: _blank | _self | _parent | _top.
    [<CustomOperation("Target")>] member inline _.Target ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Target" => x)
    /// Icon to use if set.
    [<CustomOperation("Icon")>] member inline _.Icon ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.Fast.Components.FluentUI.Icon) = render ==> ("Icon" => x)
    /// The color of the icon. It supports the theme colors, default value uses the themes drawer icon color.
    [<CustomOperation("IconColor")>] member inline _.IconColor ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.Fast.Components.FluentUI.Color) = render ==> ("IconColor" => x)
    /// If true, the button will be disabled.
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("Disabled" => x)
    /// Class names to use to indicate the item is active, separated by space.
    [<CustomOperation("ActiveClass")>] member inline _.ActiveClass ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("ActiveClass" => x)
    /// Gets or sets how the link should be matched. Defaults to Prefix.
    [<CustomOperation("Match")>] member inline _.Match ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.AspNetCore.Components.Routing.NavLinkMatch) = render ==> ("Match" => x)
    /// The callback to invoke when the item is clicked.
    [<CustomOperation("OnClick")>] member inline _.OnClick ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>("OnClick", fn)
    /// The callback to invoke when the item is clicked.
    [<CustomOperation("OnClick")>] member inline _.OnClick ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callbackTask<Microsoft.AspNetCore.Components.Web.MouseEventArgs>("OnClick", fn)
    /// If true, force browser to redirect outside component router-space.
    [<CustomOperation("ForceLoad")>] member inline _.ForceLoad ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("ForceLoad" => x)

type FluentNavGroupBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentNavBaseBuilder<'FunBlazorGeneric>()
    /// The text to display for the group.
    [<CustomOperation("Title")>] member inline _.Title ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Title" => x)
    /// If true, expands the nav group, otherwise collapse it. 
    /// Two-way bindable
    [<CustomOperation("Expanded")>] member inline _.Expanded ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("Expanded" => x)
    /// If true, expands the nav group, otherwise collapse it. 
    /// Two-way bindable
    [<CustomOperation("Expanded'")>] member inline _.Expanded' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.Boolean * (System.Boolean -> unit)) = render ==> html.bind("Expanded", valueFn)
    /// If true, hides expand button at the end of the NavGroup.
    [<CustomOperation("HideExpander")>] member inline _.HideExpander ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("HideExpander" => x)
    /// Explicitly sets the height for the Collapse element to override the css default.
    [<CustomOperation("MaxHeight")>] member inline _.MaxHeight ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("MaxHeight" => x)
    /// Defines the vertical spacing between the NavGroup and adjecent items. 
    /// Needs to be a valid CSS value.
    [<CustomOperation("Gap")>] member inline _.Gap ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Gap" => x)
    /// If set, overrides the default expand icon.
    [<CustomOperation("ExpandIcon")>] member inline _.ExpandIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.Fast.Components.FluentUI.Icon) = render ==> ("ExpandIcon" => x)
    /// Allows for specific markup and styling to be applied for the group title 
    /// When using this, the containded FluentNavLinks and FluentNavGroups need to be placed in a ChildContent tag.
    /// When specifying both Title and TitleTemplate, both will be rendered.
    [<CustomOperation("TitleTemplate")>] member inline _.TitleTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragment) = render ==> html.renderFragment("TitleTemplate", fragment)
    /// Allows for specific markup and styling to be applied for the group title 
    /// When using this, the containded FluentNavLinks and FluentNavGroups need to be placed in a ChildContent tag.
    /// When specifying both Title and TitleTemplate, both will be rendered.
    [<CustomOperation("TitleTemplate")>] member inline _.TitleTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragments) = render ==> html.renderFragment("TitleTemplate", fragment { yield! fragments })
    /// Allows for specific markup and styling to be applied for the group title 
    /// When using this, the containded FluentNavLinks and FluentNavGroups need to be placed in a ChildContent tag.
    /// When specifying both Title and TitleTemplate, both will be rendered.
    [<CustomOperation("TitleTemplate")>] member inline _.TitleTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("TitleTemplate", html.text x)
    /// Allows for specific markup and styling to be applied for the group title 
    /// When using this, the containded FluentNavLinks and FluentNavGroups need to be placed in a ChildContent tag.
    /// When specifying both Title and TitleTemplate, both will be rendered.
    [<CustomOperation("TitleTemplate")>] member inline _.TitleTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("TitleTemplate", html.text x)
    /// Allows for specific markup and styling to be applied for the group title 
    /// When using this, the containded FluentNavLinks and FluentNavGroups need to be placed in a ChildContent tag.
    /// When specifying both Title and TitleTemplate, both will be rendered.
    [<CustomOperation("TitleTemplate")>] member inline _.TitleTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("TitleTemplate", html.text x)
    /// Gets or sets a callback that is triggered whenever Expanded changes.
    [<CustomOperation("ExpandedChanged")>] member inline _.ExpandedChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callback<System.Boolean>("ExpandedChanged", fn)
    /// Gets or sets a callback that is triggered whenever Expanded changes.
    [<CustomOperation("ExpandedChanged")>] member inline _.ExpandedChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callbackTask<System.Boolean>("ExpandedChanged", fn)

type FluentNavLinkBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentNavBaseBuilder<'FunBlazorGeneric>()


type FluentAccordionBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentComponentBaseBuilder<'FunBlazorGeneric>()
    /// Controls the expand mode of the Accordion, either allowing
    /// single or multiple item expansion. .
    [<CustomOperation("ExpandMode")>] member inline _.ExpandMode ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<Microsoft.Fast.Components.FluentUI.AccordionExpandMode>) = render ==> ("ExpandMode" => x)
    /// Gets or sets the id of the active accordion item
    [<CustomOperation("ActiveId")>] member inline _.ActiveId ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("ActiveId" => x)
    /// Gets or sets the id of the active accordion item
    [<CustomOperation("ActiveId'")>] member inline _.ActiveId' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.String * (System.String -> unit)) = render ==> html.bind("ActiveId", valueFn)
    /// Gets or sets a callback that updates the bound value.
    [<CustomOperation("ActiveIdChanged")>] member inline _.ActiveIdChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callback<System.String>("ActiveIdChanged", fn)
    /// Gets or sets a callback that updates the bound value.
    [<CustomOperation("ActiveIdChanged")>] member inline _.ActiveIdChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callbackTask<System.String>("ActiveIdChanged", fn)
    /// Gets or sets a callback when a accordion item is changed .
    [<CustomOperation("OnAccordionItemChange")>] member inline _.OnAccordionItemChange ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callback<Microsoft.Fast.Components.FluentUI.FluentAccordionItem>("OnAccordionItemChange", fn)
    /// Gets or sets a callback when a accordion item is changed .
    [<CustomOperation("OnAccordionItemChange")>] member inline _.OnAccordionItemChange ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callbackTask<Microsoft.Fast.Components.FluentUI.FluentAccordionItem>("OnAccordionItemChange", fn)

type FluentAccordionItemBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentComponentBaseBuilder<'FunBlazorGeneric>()
    /// Gets or sets the heading of the accordion item.
    [<CustomOperation("Heading")>] member inline _.Heading ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Heading" => x)
    /// Expands or collapses the item.
    [<CustomOperation("Expanded")>] member inline _.Expanded ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Boolean>) = render ==> ("Expanded" => x)
    /// Configures the level of the
    /// heading element.
    /// Possible values: 1 | 2 | 3 | 4 | 5 | 6
    [<CustomOperation("HeadingLevel")>] member inline _.HeadingLevel ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("HeadingLevel" => x)

type FluentAnchoredRegionBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentComponentBaseBuilder<'FunBlazorGeneric>()
    /// The HTML ID of the anchor element this region is positioned relative to
    /// This must be set for the component positioning logic to be active.
    [<CustomOperation("Anchor")>] member inline _.Anchor ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Anchor" => x)
    /// The HTML ID of the viewport element this region is positioned relative to
    /// If unset the parent element of the anchored region is used.
    [<CustomOperation("Viewport")>] member inline _.Viewport ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Viewport" => x)
    /// Sets what logic the component uses to determine horizontal placement.
    /// Locktodefault forces the default position
    /// Dynamic decides placement based on available space
    /// Uncontrolled (default) does not control placement on the horizontal axis
    /// See 
    [<CustomOperation("HorizontalPositioningMode")>] member inline _.HorizontalPositioningMode ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<Microsoft.Fast.Components.FluentUI.AxisPositioningMode>) = render ==> ("HorizontalPositioningMode" => x)
    /// The default horizontal position of the region relative to the anchor element
    /// Default is unset. See 
    [<CustomOperation("HorizontalDefaultPosition")>] member inline _.HorizontalDefaultPosition ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<Microsoft.Fast.Components.FluentUI.HorizontalPosition>) = render ==> ("HorizontalDefaultPosition" => x)
    /// Whether the region remains in the viewport (ie. detaches from the anchor) on the horizontal axis
    [<CustomOperation("HorizontalViewportLock")>] member inline _.HorizontalViewportLock ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("HorizontalViewportLock" => x)
    /// Whether the region overlaps the anchor on the horizontal axis. Default is false which places the region adjacent to the anchor element.
    [<CustomOperation("HorizontalInset")>] member inline _.HorizontalInset ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("HorizontalInset" => x)
    /// How narrow the space allocated to the default position has to be before the widest area
    /// is selected for layout
    [<CustomOperation("HorizontalThreshold")>] member inline _.HorizontalThreshold ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("HorizontalThreshold" => x)
    /// Defines how the width of the region is calculated
    /// Default is "Content". See 
    [<CustomOperation("HorizontalScaling")>] member inline _.HorizontalScaling ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<Microsoft.Fast.Components.FluentUI.AxisScalingMode>) = render ==> ("HorizontalScaling" => x)
    /// Sets what logic the component uses to determine vertical placement.
    /// Locktodefault forces the default position
    /// Dynamic decides placement based on available space
    /// Uncontrolled (default) does not control placement on the vertical axis
    /// See 
    [<CustomOperation("VerticalPositioningMode")>] member inline _.VerticalPositioningMode ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<Microsoft.Fast.Components.FluentUI.AxisPositioningMode>) = render ==> ("VerticalPositioningMode" => x)
    /// The default vertical position of the region relative to the anchor element
    /// Default is "Unset".See 
    [<CustomOperation("VerticalDefaultPosition")>] member inline _.VerticalDefaultPosition ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<Microsoft.Fast.Components.FluentUI.VerticalPosition>) = render ==> ("VerticalDefaultPosition" => x)
    /// Whether the region remains in the viewport (ie. detaches from the anchor) on the vertical axis
    [<CustomOperation("VerticalViewportLock")>] member inline _.VerticalViewportLock ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Boolean>) = render ==> ("VerticalViewportLock" => x)
    /// Whether the region overlaps the anchor on the vertical axis
    ///  
    [<CustomOperation("VerticalInset")>] member inline _.VerticalInset ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("VerticalInset" => x)
    /// How short the space allocated to the default position has to be before the tallest area
    /// is selected for layout
    [<CustomOperation("VerticalThreshold")>] member inline _.VerticalThreshold ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("VerticalThreshold" => x)
    /// Defines how the height of the region is calculated
    /// Default is "Content". See 
    [<CustomOperation("VerticalScaling")>] member inline _.VerticalScaling ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<Microsoft.Fast.Components.FluentUI.AxisScalingMode>) = render ==> ("VerticalScaling" => x)
    /// Whether the region is positioned using css "position: fixed".
    /// Otherwise the region uses "position: absolute".
    /// Fixed placement allows the region to break out of parent containers,
    [<CustomOperation("FixedPlacement")>] member inline _.FixedPlacement ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Boolean>) = render ==> ("FixedPlacement" => x)
    /// Defines what triggers the anchored region to revaluate positioning
    /// Default is "Anchor". In 'anchor' mode only anchor resizes and attribute changes will provoke an update. In 'auto' mode the component also updates because of - any scroll event on the document, window resizes and viewport resizes. See 
    [<CustomOperation("AutoUpdateMode")>] member inline _.AutoUpdateMode ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<Microsoft.Fast.Components.FluentUI.AutoUpdateMode>) = render ==> ("AutoUpdateMode" => x)
    [<CustomOperation("Shadow")>] member inline _.Shadow ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.Fast.Components.FluentUI.ElevationShadow) = render ==> ("Shadow" => x)

type FluentAnchorBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentComponentBaseBuilder<'FunBlazorGeneric>()
    /// Prompts the user to save the linked URL. See a element for more information.
    [<CustomOperation("Download")>] member inline _.Download ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Download" => x)
    /// The URL the hyperlink references. See a element for more information.
    /// Use Target parameter to specify where.
    [<CustomOperation("Href")>] member inline _.Href ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Href" => x)
    /// Hints at the language of the referenced resource. See a element for more information.
    [<CustomOperation("Hreflang")>] member inline _.Hreflang ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Hreflang" => x)
    /// See a element for more information.
    [<CustomOperation("Ping")>] member inline _.Ping ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Ping" => x)
    /// See a element for more information.
    [<CustomOperation("Referrerpolicy")>] member inline _.Referrerpolicy ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Referrerpolicy" => x)
    /// See a element for more information.
    [<CustomOperation("Rel")>] member inline _.Rel ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Rel" => x)
    /// The target attribute specifies where to open the link, if Href is specified. 
    /// Possible values: _blank | _self | _parent | _top.
    [<CustomOperation("Target")>] member inline _.Target ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Target" => x)
    /// See a element for more information.
    [<CustomOperation("Type")>] member inline _.Type ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Type" => x)
    /// Gets or sets the visual appearance. See 
    /// Defaults to 
    [<CustomOperation("Appearance")>] member inline _.Appearance ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<Microsoft.Fast.Components.FluentUI.Appearance>) = render ==> ("Appearance" => x)
    /// Icon displayed at the start of anchor content.
    [<CustomOperation("IconStart")>] member inline _.IconStart ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.Fast.Components.FluentUI.Icon) = render ==> ("IconStart" => x)
    /// Icon displayed at the end of anchor content.
    [<CustomOperation("IconEnd")>] member inline _.IconEnd ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.Fast.Components.FluentUI.Icon) = render ==> ("IconEnd" => x)

type FluentBadgeBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentComponentBaseBuilder<'FunBlazorGeneric>()
    /// Gets or sets the color
    [<CustomOperation("Color")>] member inline _.Color ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Color" => x)
    /// Gets or sets the background color
    [<CustomOperation("BackgroundColor")>] member inline _.BackgroundColor ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("BackgroundColor" => x)
    /// Gets or sets the background color based on fill value
    [<CustomOperation("Fill")>] member inline _.Fill ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Fill" => x)
    /// Gets or sets if the badge is rendered circular
    [<CustomOperation("Circular")>] member inline _.Circular ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("Circular" => x)
    /// Gets or sets the visual appearance. See 
    /// Possible values are Accent, Neutral (default) or Lightweight
    [<CustomOperation("Appearance")>] member inline _.Appearance ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<Microsoft.Fast.Components.FluentUI.Appearance>) = render ==> ("Appearance" => x)
    /// Gets or sets the width of the component.
    [<CustomOperation("Width")>] member inline _.Width ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Width" => x)
    /// Gets or sets the height of the component.
    [<CustomOperation("Height")>] member inline _.Height ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Height" => x)
    /// Gets or sets the tooltip to display when hovering over the DismissIcon icon.
    [<CustomOperation("DismissTitle")>] member inline _.DismissTitle ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("DismissTitle" => x)
    /// Gets or sets the icon to be displayed when the badge is cancellable.
    /// By default, a small cross icon is displayed.
    [<CustomOperation("DismissIcon")>] member inline _.DismissIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.Fast.Components.FluentUI.Icon) = render ==> ("DismissIcon" => x)
    /// Event callback for when the badge is clicked.
    [<CustomOperation("OnClick")>] member inline _.OnClick ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>("OnClick", fn)
    /// Event callback for when the badge is clicked.
    [<CustomOperation("OnClick")>] member inline _.OnClick ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callbackTask<Microsoft.AspNetCore.Components.Web.MouseEventArgs>("OnClick", fn)
    /// Event callback for when the badge DismissIcon icon is clicked.
    [<CustomOperation("OnDismissClick")>] member inline _.OnDismissClick ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>("OnDismissClick", fn)
    /// Event callback for when the badge DismissIcon icon is clicked.
    [<CustomOperation("OnDismissClick")>] member inline _.OnDismissClick ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callbackTask<Microsoft.AspNetCore.Components.Web.MouseEventArgs>("OnDismissClick", fn)

/// A base class for fluent ui form input components. This base class automatically
/// integrates with an EditContext, which must be supplied
/// as a cascading parameter.
type FluentInputBaseBuilder<'FunBlazorGeneric, 'TValue when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentComponentBaseBuilder<'FunBlazorGeneric>()
    /// When true, the control will be immutable by user interaction. readonly HTML attribute for more information.
    [<CustomOperation("ReadOnly")>] member inline _.ReadOnly ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("ReadOnly" => x)
    /// Disables the form control, ensuring it doesn't participate in form submission.
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("Disabled" => x)
    /// The name of the element.Allows access by name from the associated form.
    [<CustomOperation("Name")>] member inline _.Name ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Name" => x)
    /// Text displayed just above the component
    [<CustomOperation("Label")>] member inline _.Label ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Label" => x)
    /// Content displayed just above the component
    [<CustomOperation("LabelTemplate")>] member inline _.LabelTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragment) = render ==> html.renderFragment("LabelTemplate", fragment)
    /// Content displayed just above the component
    [<CustomOperation("LabelTemplate")>] member inline _.LabelTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragments) = render ==> html.renderFragment("LabelTemplate", fragment { yield! fragments })
    /// Content displayed just above the component
    [<CustomOperation("LabelTemplate")>] member inline _.LabelTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("LabelTemplate", html.text x)
    /// Content displayed just above the component
    [<CustomOperation("LabelTemplate")>] member inline _.LabelTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("LabelTemplate", html.text x)
    /// Content displayed just above the component
    [<CustomOperation("LabelTemplate")>] member inline _.LabelTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("LabelTemplate", html.text x)
    /// Text used on aria-label attribute.
    [<CustomOperation("AriaLabel")>] member inline _.AriaLabel ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("AriaLabel" => x)
    /// Whether the element needs to have a value
    [<CustomOperation("Required")>] member inline _.Required ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("Required" => x)
    /// Gets or sets the value of the input. This should be used with two-way binding.
    [<CustomOperation("Value")>] member inline _.Value ([<InlineIfLambda>] render: AttrRenderFragment, x: 'TValue) = render ==> ("Value" => x)
    /// Gets or sets the value of the input. This should be used with two-way binding.
    [<CustomOperation("Value'")>] member inline _.Value' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: 'TValue * ('TValue -> unit)) = render ==> html.bind("Value", valueFn)
    /// Gets or sets a callback that updates the bound value.
    [<CustomOperation("ValueChanged")>] member inline _.ValueChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callback<'TValue>("ValueChanged", fn)
    /// Gets or sets a callback that updates the bound value.
    [<CustomOperation("ValueChanged")>] member inline _.ValueChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callbackTask<'TValue>("ValueChanged", fn)
    /// Gets or sets an expression that identifies the bound value.
    [<CustomOperation("ValueExpression")>] member inline _.ValueExpression ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Linq.Expressions.Expression<System.Func<'TValue>>) = render ==> ("ValueExpression" => x)
    /// Gets or sets the display name for this field.
    /// This value is used when generating error messages when the input value fails to parse correctly.
    [<CustomOperation("DisplayName")>] member inline _.DisplayName ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("DisplayName" => x)
    /// Determines if the element should receive document focus on page load.
    [<CustomOperation("Autofocus")>] member inline _.Autofocus ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("Autofocus" => x)
    /// An event that is called after the Value property has been changed
    /// through data binding. This is equivalent to @bind-Value:after which is supported
    /// from .Net 7, but not available in .Net 6.
    [<CustomOperation("AfterBindValue")>] member inline _.AfterBindValue ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callback<'TValue>("AfterBindValue", fn)
    /// An event that is called after the Value property has been changed
    /// through data binding. This is equivalent to @bind-Value:after which is supported
    /// from .Net 7, but not available in .Net 6.
    [<CustomOperation("AfterBindValue")>] member inline _.AfterBindValue ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callbackTask<'TValue>("AfterBindValue", fn)
    /// The short hint displayed in the input before the user enters a value.
    [<CustomOperation("Placeholder")>] member inline _.Placeholder ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Placeholder" => x)
    /// Change the content of this input field when the user write text (based on 'OnInput' HTML event).
    [<CustomOperation("Immediate")>] member inline _.Immediate ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("Immediate" => x)
    /// Delay, in milliseconds, before to raise the ValueChanged event.
    [<CustomOperation("ImmediateDelay")>] member inline _.ImmediateDelay ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("ImmediateDelay" => x)

type FluentCheckboxBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentInputBaseBuilder<'FunBlazorGeneric, System.Boolean>()


type FluentTimePickerBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentInputBaseBuilder<'FunBlazorGeneric, System.Nullable<System.DateTime>>()
    /// Gets or sets the design of this input.
    [<CustomOperation("Appearance")>] member inline _.Appearance ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.Fast.Components.FluentUI.FluentInputAppearance) = render ==> ("Appearance" => x)

type FluentNumberFieldBuilder<'FunBlazorGeneric, 'TValue when 'TValue : (new : unit -> 'TValue) and 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentInputBaseBuilder<'FunBlazorGeneric, 'TValue>()
    /// When true, spin buttons will not be rendered
    [<CustomOperation("HideStep")>] member inline _.HideStep ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("HideStep" => x)
    /// Allows associating a datalist to the element by id.
    [<CustomOperation("DataList")>] member inline _.DataList ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("DataList" => x)
    /// Gets or sets the maximum length
    [<CustomOperation("MaxLength")>] member inline _.MaxLength ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("MaxLength" => x)
    /// Gets or sets the minimum length
    [<CustomOperation("MinLength")>] member inline _.MinLength ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("MinLength" => x)
    /// Gets or sets the size
    [<CustomOperation("Size")>] member inline _.Size ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("Size" => x)
    /// Gets or sets the amount to increase/decrease the number with. Only use whole number when TValue is int or long. 
    [<CustomOperation("Step")>] member inline _.Step ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Step" => x)
    /// Gets or sets the maximum value
    [<CustomOperation("Max")>] member inline _.Max ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Max" => x)
    /// Gets or sets the minimum value
    [<CustomOperation("Min")>] member inline _.Min ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Min" => x)
    /// Gets or sets the Appearance
    [<CustomOperation("Appearance")>] member inline _.Appearance ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.Fast.Components.FluentUI.FluentInputAppearance) = render ==> ("Appearance" => x)
    /// Gets or sets the error message to show when the field can not be parsed
    [<CustomOperation("ParsingErrorMessage")>] member inline _.ParsingErrorMessage ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("ParsingErrorMessage" => x)

/// Groups child FluentRadio`1 components. 
type FluentRadioGroupBuilder<'FunBlazorGeneric, 'TValue when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentInputBaseBuilder<'FunBlazorGeneric, 'TValue>()
    /// Gets or sets the orientation of the group. See Orientation
    [<CustomOperation("Orientation")>] member inline _.Orientation ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<Microsoft.Fast.Components.FluentUI.Orientation>) = render ==> ("Orientation" => x)

type FluentSearchBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentInputBaseBuilder<'FunBlazorGeneric, System.String>()
    /// Allows associating a datalist to the element by id.
    [<CustomOperation("DataList")>] member inline _.DataList ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("DataList" => x)
    /// The maximum number of characters a user can enter.
    [<CustomOperation("Maxlength")>] member inline _.Maxlength ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Int32>) = render ==> ("Maxlength" => x)
    /// The minimum number of characters a user can enter.
    [<CustomOperation("Minlength")>] member inline _.Minlength ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Int32>) = render ==> ("Minlength" => x)
    /// A regular expression that the value must match to pass validation.
    [<CustomOperation("Pattern")>] member inline _.Pattern ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Pattern" => x)
    /// Gets or sets the size of the text field
    [<CustomOperation("Size")>] member inline _.Size ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Int32>) = render ==> ("Size" => x)
    /// Gets or sets the if spellcheck should be used
    [<CustomOperation("Spellcheck")>] member inline _.Spellcheck ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Boolean>) = render ==> ("Spellcheck" => x)
    /// Gets or sets the visual appearance. See Appearance
    [<CustomOperation("Appearance")>] member inline _.Appearance ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.Fast.Components.FluentUI.FluentInputAppearance) = render ==> ("Appearance" => x)

type FluentSliderBuilder<'FunBlazorGeneric, 'TValue when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentInputBaseBuilder<'FunBlazorGeneric, 'TValue>()
    /// Gets or sets the slider's minimal value
    [<CustomOperation("Min")>] member inline _.Min ([<InlineIfLambda>] render: AttrRenderFragment, x: 'TValue) = render ==> ("Min" => x)
    /// Gets or sets the slider's maximum value
    [<CustomOperation("Max")>] member inline _.Max ([<InlineIfLambda>] render: AttrRenderFragment, x: 'TValue) = render ==> ("Max" => x)
    /// Gets or sets the slider's step value
    [<CustomOperation("Step")>] member inline _.Step ([<InlineIfLambda>] render: AttrRenderFragment, x: 'TValue) = render ==> ("Step" => x)
    /// Gets or sets the orentation of the slider. See Orientation
    [<CustomOperation("Orientation")>] member inline _.Orientation ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<Microsoft.Fast.Components.FluentUI.Orientation>) = render ==> ("Orientation" => x)
    /// The selection mode.
    [<CustomOperation("Mode")>] member inline _.Mode ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<Microsoft.Fast.Components.FluentUI.SliderMode>) = render ==> ("Mode" => x)

type FluentSwitchBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentInputBaseBuilder<'FunBlazorGeneric, System.Boolean>()
    /// Gets or sets the checked message
    [<CustomOperation("CheckedMessage")>] member inline _.CheckedMessage ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("CheckedMessage" => x)
    /// Gets or sets the unchecked message
    [<CustomOperation("UncheckedMessage")>] member inline _.UncheckedMessage ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("UncheckedMessage" => x)

type FluentTextAreaBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentInputBaseBuilder<'FunBlazorGeneric, System.String>()
    /// Gets or sets if the text area is resizeable. See TextAreaResize
    [<CustomOperation("Resize")>] member inline _.Resize ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<Microsoft.Fast.Components.FluentUI.TextAreaResize>) = render ==> ("Resize" => x)
    /// The id the form the element is associated to
    [<CustomOperation("Form")>] member inline _.Form ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Form" => x)
    /// Allows associating a datalist to the element by id.
    [<CustomOperation("DataList")>] member inline _.DataList ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("DataList" => x)
    /// The maximum number of characters a user can enter.
    [<CustomOperation("Maxlength")>] member inline _.Maxlength ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Int32>) = render ==> ("Maxlength" => x)
    /// The minimum number of characters a user can enter.
    [<CustomOperation("Minlength")>] member inline _.Minlength ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Int32>) = render ==> ("Minlength" => x)
    /// Sizes the element horizontally by a number of character columns.
    [<CustomOperation("Cols")>] member inline _.Cols ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Int32>) = render ==> ("Cols" => x)
    /// Sizes the element vertically by a number of character rows.
    [<CustomOperation("Rows")>] member inline _.Rows ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Int32>) = render ==> ("Rows" => x)
    /// Sets if the element is eligible for spell checking
    /// but the UA.
    [<CustomOperation("Spellcheck")>] member inline _.Spellcheck ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Boolean>) = render ==> ("Spellcheck" => x)
    /// Gets or sets the visual appearance. See FluentInputAppearance
    [<CustomOperation("Appearance")>] member inline _.Appearance ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.Fast.Components.FluentUI.FluentInputAppearance) = render ==> ("Appearance" => x)

type FluentTextFieldBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentInputBaseBuilder<'FunBlazorGeneric, System.String>()
    /// Gets or sets the text filed type. See TextFieldType
    [<CustomOperation("TextFieldType")>] member inline _.TextFieldType ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<Microsoft.Fast.Components.FluentUI.TextFieldType>) = render ==> ("TextFieldType" => x)
    /// Allows associating a datalist to the element by id.
    [<CustomOperation("DataList")>] member inline _.DataList ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("DataList" => x)
    /// Gets or sets the maximum length
    [<CustomOperation("Maxlength")>] member inline _.Maxlength ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Int32>) = render ==> ("Maxlength" => x)
    /// Gets or sets the minimum length
    [<CustomOperation("Minlength")>] member inline _.Minlength ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Int32>) = render ==> ("Minlength" => x)
    /// A regular expression that the value must match to pass validation.
    [<CustomOperation("Pattern")>] member inline _.Pattern ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Pattern" => x)
    /// Gets or sets the size of the text field
    [<CustomOperation("Size")>] member inline _.Size ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Int32>) = render ==> ("Size" => x)
    /// Gets or sets the if spellcheck should be used
    [<CustomOperation("Spellcheck")>] member inline _.Spellcheck ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Boolean>) = render ==> ("Spellcheck" => x)
    /// Gets or sets the visual appearance. See FluentInputAppearance
    [<CustomOperation("Appearance")>] member inline _.Appearance ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.Fast.Components.FluentUI.FluentInputAppearance) = render ==> ("Appearance" => x)
    /// Specifies whether a form or an input field should have autocomplete "on" or "off" or another value.
    /// An Id value must be set to use this property.
    [<CustomOperation("AutoComplete")>] member inline _.AutoComplete ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("AutoComplete" => x)

type FluentBodyContentBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentComponentBaseBuilder<'FunBlazorGeneric>()


type FluentBreadcrumbBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentComponentBaseBuilder<'FunBlazorGeneric>()


type FluentBreadcrumbItemBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentComponentBaseBuilder<'FunBlazorGeneric>()
    /// Prompts the user to save the linked URL. See a element for more information.
    [<CustomOperation("Download")>] member inline _.Download ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Download" => x)
    /// The URL the hyperlink references. See a element for more information.
    /// Use Target parameter to specify where.
    [<CustomOperation("Href")>] member inline _.Href ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Href" => x)
    /// Hints at the language of the referenced resource. See a element for more information.
    [<CustomOperation("Hreflang")>] member inline _.Hreflang ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Hreflang" => x)
    /// See a element for more information.
    [<CustomOperation("Ping")>] member inline _.Ping ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Ping" => x)
    /// See a element for more information.
    [<CustomOperation("Referrerpolicy")>] member inline _.Referrerpolicy ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Referrerpolicy" => x)
    /// See a element for more information.
    [<CustomOperation("Rel")>] member inline _.Rel ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Rel" => x)
    /// The target attribute specifies where to open the link, if Href is specified. 
    /// See a element for more information.
    /// Possible values: _blank | _self | _parent | _top.
    [<CustomOperation("Target")>] member inline _.Target ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Target" => x)
    /// See a element for more information.
    [<CustomOperation("Type")>] member inline _.Type ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Type" => x)
    /// Gets or sets the visual appearance. See 
    [<CustomOperation("Appearance")>] member inline _.Appearance ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<Microsoft.Fast.Components.FluentUI.Appearance>) = render ==> ("Appearance" => x)

type FluentButtonBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentComponentBaseBuilder<'FunBlazorGeneric>()
    /// Determines if the element should receive document focus on page load.
    [<CustomOperation("Autofocus")>] member inline _.Autofocus ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Boolean>) = render ==> ("Autofocus" => x)
    /// The id of a form to associate the element to.
    [<CustomOperation("FormId")>] member inline _.FormId ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("FormId" => x)
    /// See button element for more details.
    [<CustomOperation("Action")>] member inline _.Action ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Action" => x)
    /// See button element for more details.
    [<CustomOperation("Enctype")>] member inline _.Enctype ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Enctype" => x)
    /// See button element for more details.
    [<CustomOperation("Method")>] member inline _.Method ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Method" => x)
    /// See button element for more details.
    [<CustomOperation("NoValidate")>] member inline _.NoValidate ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Boolean>) = render ==> ("NoValidate" => x)
    /// See button element for more details.
    /// Possible values: "_self" | "_blank" | "_parent" | "_top"
    [<CustomOperation("Target")>] member inline _.Target ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Target" => x)
    /// The button type. See ButtonType for more details.
    /// Default is ButtonType.Button"
    [<CustomOperation("Type")>] member inline _.Type ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<Microsoft.Fast.Components.FluentUI.ButtonType>) = render ==> ("Type" => x)
    /// The value of the element
    [<CustomOperation("Value")>] member inline _.Value ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Value" => x)
    /// The element's current value 
    [<CustomOperation("CurrentValue")>] member inline _.CurrentValue ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("CurrentValue" => x)
    /// Disables the form control, ensuring it doesn't participate in form submission
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("Disabled" => x)
    /// The name of the element.Allows access by name from the associated form.
    [<CustomOperation("Name")>] member inline _.Name ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Name" => x)
    /// The element needs to have a value
    [<CustomOperation("Required")>] member inline _.Required ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("Required" => x)
    /// Gets or sets the visual appearance. See 
    /// Defaults to 
    [<CustomOperation("Appearance")>] member inline _.Appearance ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<Microsoft.Fast.Components.FluentUI.Appearance>) = render ==> ("Appearance" => x)
    /// Background color of this button (overrides the Appearance property).
    /// Set the value "rgba(0, 0, 0, 0)" to display a transparent button.
    [<CustomOperation("BackgroundColor")>] member inline _.BackgroundColor ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("BackgroundColor" => x)
    /// Color of the font (overrides the Appearance property).
    [<CustomOperation("Color")>] member inline _.Color ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Color" => x)
    /// Display a progress ring and disable the button.
    [<CustomOperation("Loading")>] member inline _.Loading ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("Loading" => x)
    /// Icon displayed at the start of button content.
    [<CustomOperation("IconStart")>] member inline _.IconStart ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.Fast.Components.FluentUI.Icon) = render ==> ("IconStart" => x)
    /// Icon displayed at the end of button content.
    [<CustomOperation("IconEnd")>] member inline _.IconEnd ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.Fast.Components.FluentUI.Icon) = render ==> ("IconEnd" => x)
    /// Title of the button: the text usually displayed in a 'tooltip' popup when the mouse is over the button.
    [<CustomOperation("Title")>] member inline _.Title ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Title" => x)
    /// Command executed when the user clicks on the button.
    [<CustomOperation("OnClick")>] member inline _.OnClick ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>("OnClick", fn)
    /// Command executed when the user clicks on the button.
    [<CustomOperation("OnClick")>] member inline _.OnClick ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callbackTask<Microsoft.AspNetCore.Components.Web.MouseEventArgs>("OnClick", fn)

type FluentCardBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentComponentBaseBuilder<'FunBlazorGeneric>()
    /// By default, content in the card is restricted to the area of the card itself. 
    /// If you want content to be able to overflow the card, set this property to false.
    [<CustomOperation("AreaRestricted")>] member inline _.AreaRestricted ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("AreaRestricted" => x)
    /// Specifies the width of the card. Must be a valid CSS measurement.
    [<CustomOperation("Width")>] member inline _.Width ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Width" => x)
    /// Specifies the height of the card. Must be a valid CSS measurement.
    [<CustomOperation("Height")>] member inline _.Height ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Height" => x)

type FluentCodeEditorBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentComponentBaseBuilder<'FunBlazorGeneric>()
    /// Language used by the editor: csharp, javascript, ...
    [<CustomOperation("Language")>] member inline _.Language ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Language" => x)
    /// Height of this component.
    [<CustomOperation("Height")>] member inline _.Height ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Height" => x)
    /// Width of this component.
    [<CustomOperation("Width")>] member inline _.Width ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Width" => x)
    /// Theme of the editor (Light or Dark).
    [<CustomOperation("IsDarkMode")>] member inline _.IsDarkMode ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("IsDarkMode" => x)
    /// Gets or sets the value of the input. This should be used with two-way binding.
    [<CustomOperation("Value")>] member inline _.Value ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Value" => x)
    /// Gets or sets the value of the input. This should be used with two-way binding.
    [<CustomOperation("Value'")>] member inline _.Value' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.String * (System.String -> unit)) = render ==> html.bind("Value", valueFn)
    /// Gets or sets a callback that updates the bound value.
    [<CustomOperation("ValueChanged")>] member inline _.ValueChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callback<System.String>("ValueChanged", fn)
    /// Gets or sets a callback that updates the bound value.
    [<CustomOperation("ValueChanged")>] member inline _.ValueChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callbackTask<System.String>("ValueChanged", fn)

type FluentCollapsibleRegionBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentComponentBaseBuilder<'FunBlazorGeneric>()
    /// If true, the region is expaned, otherwise it is collapsed.
    [<CustomOperation("Expanded")>] member inline _.Expanded ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("Expanded" => x)
    /// If true, the region is expaned, otherwise it is collapsed.
    [<CustomOperation("Expanded'")>] member inline _.Expanded' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.Boolean * (System.Boolean -> unit)) = render ==> html.bind("Expanded", valueFn)
    /// Explicitly sets the height for the Collapse element to override the css default.
    [<CustomOperation("MaxHeight")>] member inline _.MaxHeight ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("MaxHeight" => x)
    /// Callback for when the Expanded property changes.
    [<CustomOperation("ExpandedChanged")>] member inline _.ExpandedChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callback<System.Boolean>("ExpandedChanged", fn)
    /// Callback for when the Expanded property changes.
    [<CustomOperation("ExpandedChanged")>] member inline _.ExpandedChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callbackTask<System.Boolean>("ExpandedChanged", fn)

type FluentCounterBadgeBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentComponentBaseBuilder<'FunBlazorGeneric>()
    /// Number displayed inside the badge.
    /// Can be enriched with a plus sign with ShowOverflow
    [<CustomOperation("Count")>] member inline _.Count ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Int32>) = render ==> ("Count" => x)
    /// Content you want inside the badge, to customize the badge content.
    [<CustomOperation("BadgeContent")>] member inline _.BadgeContent ([<InlineIfLambda>] render: AttrRenderFragment, fragment) = render ==> html.renderFragment("BadgeContent", fragment)
    /// Content you want inside the badge, to customize the badge content.
    [<CustomOperation("BadgeContent")>] member inline _.BadgeContent ([<InlineIfLambda>] render: AttrRenderFragment, fragments) = render ==> html.renderFragment("BadgeContent", fragment { yield! fragments })
    /// Content you want inside the badge, to customize the badge content.
    [<CustomOperation("BadgeContent")>] member inline _.BadgeContent ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("BadgeContent", html.text x)
    /// Content you want inside the badge, to customize the badge content.
    [<CustomOperation("BadgeContent")>] member inline _.BadgeContent ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("BadgeContent", html.text x)
    /// Content you want inside the badge, to customize the badge content.
    [<CustomOperation("BadgeContent")>] member inline _.BadgeContent ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("BadgeContent", html.text x)
    /// Max number that can be displayed inside the badge.
    /// Default is 99.
    [<CustomOperation("Max")>] member inline _.Max ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Int32>) = render ==> ("Max" => x)
    /// Left position of the badge in percentage.
    /// By default, this value is 50 to center the badge.
    [<CustomOperation("HorizontalPosition")>] member inline _.HorizontalPosition ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Int32>) = render ==> ("HorizontalPosition" => x)
    /// Bottom position of the badge in percentage.
    /// By default, this value is 50 to center the badge.
    [<CustomOperation("BottomPosition")>] member inline _.BottomPosition ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Int32>) = render ==> ("BottomPosition" => x)
    /// Default design of this badge using colors from theme.
    [<CustomOperation("Appearance")>] member inline _.Appearance ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<Microsoft.Fast.Components.FluentUI.Appearance>) = render ==> ("Appearance" => x)
    /// Background color to replace the color inferred from property.
    [<CustomOperation("BackgroundColor")>] member inline _.BackgroundColor ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<Microsoft.Fast.Components.FluentUI.Color>) = render ==> ("BackgroundColor" => x)
    /// Font color to replace the color inferred from property.
    [<CustomOperation("Color")>] member inline _.Color ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<Microsoft.Fast.Components.FluentUI.Color>) = render ==> ("Color" => x)
    /// If the counter badge should be displayed when the count is zero.
    /// Defaults to false.
    ///             
    [<CustomOperation("ShowZero")>] member inline _.ShowZero ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("ShowZero" => x)
    /// If an plus sign should be displayed when the Count is greater than Max.
    /// Defaults to true.
    ///             
    [<CustomOperation("ShowOverflow")>] member inline _.ShowOverflow ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("ShowOverflow" => x)

/// A component that displays a grid.
type FluentDataGridBuilder<'FunBlazorGeneric, 'TGridItem when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentComponentBaseBuilder<'FunBlazorGeneric>()
    /// A queryable source of data for the grid.
    ///             
    /// This could be in-memory data converted to queryable using the
    /// AsQueryable extension method,
    /// or an EntityFramework DataSet or an IQueryable derived from it.
    ///             
    /// You should supply either Items or ItemsProvider, but not both.
    [<CustomOperation("Items")>] member inline _.Items ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Linq.IQueryable<'TGridItem>) = render ==> ("Items" => x)
    /// A callback that supplies data for the rid.
    ///             
    /// You should supply either Items or ItemsProvider, but not both.
    [<CustomOperation("ItemsProvider")>] member inline _.ItemsProvider ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.Fast.Components.FluentUI.GridItemsProvider<'TGridItem>) = render ==> ("ItemsProvider" => x)
    /// If true, the grid will be rendered with virtualization. This is normally used in conjunction with
    /// scrolling and causes the grid to fetch and render only the data around the current scroll viewport.
    /// This can greatly improve the performance when scrolling through large data sets.
    ///             
    /// If you use Virtualize, you should supply a value for ItemSize and must
    /// ensure that every row renders with the same constant height.
    ///             
    /// Generally it's preferable not to use Virtualize if the amount of data being rendered
    /// is small or if you are using pagination.
    [<CustomOperation("Virtualize")>] member inline _.Virtualize ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("Virtualize" => x)
    /// This is applicable only when using Virtualize. It defines an expected height in pixels for
    /// each row, allowing the virtualization mechanism to fetch the correct number of items to match the display
    /// size and to ensure accurate scrolling.
    [<CustomOperation("ItemSize")>] member inline _.ItemSize ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Single) = render ==> ("ItemSize" => x)
    /// If true, renders draggable handles around the column headers, allowing the user to resize the columns
    /// manually. Size changes are not persisted.
    [<CustomOperation("ResizableColumns")>] member inline _.ResizableColumns ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("ResizableColumns" => x)
    /// Optionally defines a value for @key on each rendered row. Typically this should be used to specify a
    /// unique identifier, such as a primary key value, for each data item.
    ///             
    /// This allows the grid to preserve the association between row elements and data items based on their
    /// unique identifiers, even when the  instances are replaced by new copies (for
    /// example, after a new query against the underlying data store).
    ///             
    /// If not set, the @key will be the  instance itself.
    [<CustomOperation("ItemKey")>] member inline _.ItemKey ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("ItemKey" => (System.Func<'TGridItem, System.Object>fn))
    /// Optionally links this FluentDataGrid`1 instance with a PaginationState model,
    /// causing the grid to fetch and render only the current page of data.
    ///             
    /// This is normally used in conjunction with a FluentPaginator component or some other UI logic
    /// that displays and updates the supplied PaginationState instance.
    [<CustomOperation("Pagination")>] member inline _.Pagination ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.Fast.Components.FluentUI.PaginationState) = render ==> ("Pagination" => x)
    /// When true the component will not add itself to the tab queue. Default is false.
    [<CustomOperation("NoTabbing")>] member inline _.NoTabbing ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("NoTabbing" => x)
    /// Whether the grid should automatically generate a header row and its type
    /// See GenerateHeaderOption
    [<CustomOperation("GenerateHeader")>] member inline _.GenerateHeader ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<Microsoft.Fast.Components.FluentUI.GenerateHeaderOption>) = render ==> ("GenerateHeader" => x)
    /// Gets or sets the value that gets applied to the css gridTemplateColumns attribute of child rows
    [<CustomOperation("GridTemplateColumns")>] member inline _.GridTemplateColumns ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("GridTemplateColumns" => x)
    /// Gets or sets a callback when a row is focused
    [<CustomOperation("OnRowFocus")>] member inline _.OnRowFocus ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callback<Microsoft.Fast.Components.FluentUI.FluentDataGridRow<'TGridItem>>("OnRowFocus", fn)
    /// Gets or sets a callback when a row is focused
    [<CustomOperation("OnRowFocus")>] member inline _.OnRowFocus ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callbackTask<Microsoft.Fast.Components.FluentUI.FluentDataGridRow<'TGridItem>>("OnRowFocus", fn)
    /// Gets or sets a callback when a row is focused
    [<CustomOperation("OnCellFocus")>] member inline _.OnCellFocus ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callback<Microsoft.Fast.Components.FluentUI.FluentDataGridCell<'TGridItem>>("OnCellFocus", fn)
    /// Gets or sets a callback when a row is focused
    [<CustomOperation("OnCellFocus")>] member inline _.OnCellFocus ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callbackTask<Microsoft.Fast.Components.FluentUI.FluentDataGridCell<'TGridItem>>("OnCellFocus", fn)
    /// Optionally defines a class to be applied to a rendered row. 
    [<CustomOperation("RowClass")>] member inline _.RowClass ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("RowClass" => (System.Func<'TGridItem, System.String>fn))
    /// Optionally defines a style to be applied to a rendered row. 
    [<CustomOperation("RowStyle")>] member inline _.RowStyle ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("RowStyle" => (System.Func<'TGridItem, System.String>fn))
    /// If specified, grids render this fragment when there is no content.
    [<CustomOperation("EmptyContent")>] member inline _.EmptyContent ([<InlineIfLambda>] render: AttrRenderFragment, fragment) = render ==> html.renderFragment("EmptyContent", fragment)
    /// If specified, grids render this fragment when there is no content.
    [<CustomOperation("EmptyContent")>] member inline _.EmptyContent ([<InlineIfLambda>] render: AttrRenderFragment, fragments) = render ==> html.renderFragment("EmptyContent", fragment { yield! fragments })
    /// If specified, grids render this fragment when there is no content.
    [<CustomOperation("EmptyContent")>] member inline _.EmptyContent ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("EmptyContent", html.text x)
    /// If specified, grids render this fragment when there is no content.
    [<CustomOperation("EmptyContent")>] member inline _.EmptyContent ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("EmptyContent", html.text x)
    /// If specified, grids render this fragment when there is no content.
    [<CustomOperation("EmptyContent")>] member inline _.EmptyContent ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("EmptyContent", html.text x)

type FluentDataGridCellBuilder<'FunBlazorGeneric, 'TGridItem when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentComponentBaseBuilder<'FunBlazorGeneric>()
    /// Gets or sets the reference to the item that holds this cell's values
    [<CustomOperation("Item")>] member inline _.Item ([<InlineIfLambda>] render: AttrRenderFragment, x: 'TGridItem) = render ==> ("Item" => x)
    /// Gets or sets the cell type. See DataGridCellType
    [<CustomOperation("CellType")>] member inline _.CellType ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<Microsoft.Fast.Components.FluentUI.DataGridCellType>) = render ==> ("CellType" => x)
    /// The column index of the cell.
    /// This will be applied to the css grid-column-index value
    /// applied to the cell
    [<CustomOperation("GridColumn")>] member inline _.GridColumn ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("GridColumn" => x)

type FluentDataGridRowBuilder<'FunBlazorGeneric, 'TGridItem when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentComponentBaseBuilder<'FunBlazorGeneric>()
    /// Gets or sets the reference to the item that holds this row's values
    [<CustomOperation("Item")>] member inline _.Item ([<InlineIfLambda>] render: AttrRenderFragment, x: 'TGridItem) = render ==> ("Item" => x)
    /// Gets or sets the index of this row
    /// When FluentDataGrid is virtualized, this value is not used
    [<CustomOperation("RowIndex")>] member inline _.RowIndex ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Int32>) = render ==> ("RowIndex" => x)
    /// String that gets applied to the css gridTemplateColumns attribute for the row
    [<CustomOperation("GridTemplateColumns")>] member inline _.GridTemplateColumns ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("GridTemplateColumns" => x)
    /// Gets or sets the type of row. See DataGridRowType
    [<CustomOperation("RowType")>] member inline _.RowType ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<Microsoft.Fast.Components.FluentUI.DataGridRowType>) = render ==> ("RowType" => x)
    [<CustomOperation("OnCellFocus")>] member inline _.OnCellFocus ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callback<Microsoft.Fast.Components.FluentUI.FluentDataGridCell<'TGridItem>>("OnCellFocus", fn)
    [<CustomOperation("OnCellFocus")>] member inline _.OnCellFocus ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callbackTask<Microsoft.Fast.Components.FluentUI.FluentDataGridCell<'TGridItem>>("OnCellFocus", fn)

type FluentDesignSystemProviderBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("NoPaint")>] member inline _.NoPaint ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Boolean>) = render ==> ("NoPaint" => x)
    [<CustomOperation("FillColor")>] member inline _.FillColor ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("FillColor" => x)
    [<CustomOperation("AccentBaseColor")>] member inline _.AccentBaseColor ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("AccentBaseColor" => x)
    [<CustomOperation("NeutralBaseColor")>] member inline _.NeutralBaseColor ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("NeutralBaseColor" => x)
    [<CustomOperation("Density")>] member inline _.Density ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Int32>) = render ==> ("Density" => x)
    [<CustomOperation("DesignUnit")>] member inline _.DesignUnit ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Int32>) = render ==> ("DesignUnit" => x)
    [<CustomOperation("Direction")>] member inline _.Direction ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<Microsoft.Fast.Components.FluentUI.LocalizationDirection>) = render ==> ("Direction" => x)
    [<CustomOperation("BaseHeightMultiplier")>] member inline _.BaseHeightMultiplier ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Int32>) = render ==> ("BaseHeightMultiplier" => x)
    [<CustomOperation("BaseHorizontalSpacingMultiplier")>] member inline _.BaseHorizontalSpacingMultiplier ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Int32>) = render ==> ("BaseHorizontalSpacingMultiplier" => x)
    [<CustomOperation("ControlCornerRadius")>] member inline _.ControlCornerRadius ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Int32>) = render ==> ("ControlCornerRadius" => x)
    [<CustomOperation("LayerCornerRadius")>] member inline _.LayerCornerRadius ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Int32>) = render ==> ("LayerCornerRadius" => x)
    [<CustomOperation("StrokeWidth")>] member inline _.StrokeWidth ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Int32>) = render ==> ("StrokeWidth" => x)
    [<CustomOperation("FocusStrokeWidth")>] member inline _.FocusStrokeWidth ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Int32>) = render ==> ("FocusStrokeWidth" => x)
    [<CustomOperation("DisabledOpacity")>] member inline _.DisabledOpacity ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Single>) = render ==> ("DisabledOpacity" => x)
    [<CustomOperation("TypeRampMinus2FontSize")>] member inline _.TypeRampMinus2FontSize ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("TypeRampMinus2FontSize" => x)
    [<CustomOperation("TypeRampMinus2LineHeight")>] member inline _.TypeRampMinus2LineHeight ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("TypeRampMinus2LineHeight" => x)
    [<CustomOperation("TypeRampMinus1FontSize")>] member inline _.TypeRampMinus1FontSize ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("TypeRampMinus1FontSize" => x)
    [<CustomOperation("TypeRampMinus1LineHeight")>] member inline _.TypeRampMinus1LineHeight ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("TypeRampMinus1LineHeight" => x)
    [<CustomOperation("TypeRampBaseFontSize")>] member inline _.TypeRampBaseFontSize ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("TypeRampBaseFontSize" => x)
    [<CustomOperation("TypeRampBaseLineHeight")>] member inline _.TypeRampBaseLineHeight ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("TypeRampBaseLineHeight" => x)
    [<CustomOperation("TypeRampPlus1FontSize")>] member inline _.TypeRampPlus1FontSize ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("TypeRampPlus1FontSize" => x)
    [<CustomOperation("TypeRampPlus1LineHeight")>] member inline _.TypeRampPlus1LineHeight ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("TypeRampPlus1LineHeight" => x)
    [<CustomOperation("TypeRampPlus2FontSize")>] member inline _.TypeRampPlus2FontSize ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("TypeRampPlus2FontSize" => x)
    [<CustomOperation("TypeRampPlus2LineHeight")>] member inline _.TypeRampPlus2LineHeight ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("TypeRampPlus2LineHeight" => x)
    [<CustomOperation("TypeRampPlus3FontSize")>] member inline _.TypeRampPlus3FontSize ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("TypeRampPlus3FontSize" => x)
    [<CustomOperation("TypeRampPlus3LineHeight")>] member inline _.TypeRampPlus3LineHeight ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("TypeRampPlus3LineHeight" => x)
    [<CustomOperation("TypeRampPlus4FontSize")>] member inline _.TypeRampPlus4FontSize ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("TypeRampPlus4FontSize" => x)
    [<CustomOperation("TypeRampPlus4LineHeight")>] member inline _.TypeRampPlus4LineHeight ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("TypeRampPlus4LineHeight" => x)
    [<CustomOperation("TypeRampPlus5FontSize")>] member inline _.TypeRampPlus5FontSize ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("TypeRampPlus5FontSize" => x)
    [<CustomOperation("TypeRampPlus5LineHeight")>] member inline _.TypeRampPlus5LineHeight ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("TypeRampPlus5LineHeight" => x)
    [<CustomOperation("TypeRampPlus6FontSize")>] member inline _.TypeRampPlus6FontSize ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("TypeRampPlus6FontSize" => x)
    [<CustomOperation("TypeRampPlus6LineHeight")>] member inline _.TypeRampPlus6LineHeight ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("TypeRampPlus6LineHeight" => x)
    [<CustomOperation("AccentFillRestDelta")>] member inline _.AccentFillRestDelta ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Int32>) = render ==> ("AccentFillRestDelta" => x)
    [<CustomOperation("AccentFillHoverDelta")>] member inline _.AccentFillHoverDelta ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Int32>) = render ==> ("AccentFillHoverDelta" => x)
    [<CustomOperation("AccentFillActiveDelta")>] member inline _.AccentFillActiveDelta ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Int32>) = render ==> ("AccentFillActiveDelta" => x)
    [<CustomOperation("AccentFillFocusDelta")>] member inline _.AccentFillFocusDelta ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Int32>) = render ==> ("AccentFillFocusDelta" => x)
    [<CustomOperation("AccentForegroundRestDelta")>] member inline _.AccentForegroundRestDelta ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Int32>) = render ==> ("AccentForegroundRestDelta" => x)
    [<CustomOperation("AccentForegroundHoverDelta")>] member inline _.AccentForegroundHoverDelta ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Int32>) = render ==> ("AccentForegroundHoverDelta" => x)
    [<CustomOperation("AccentForegroundActiveDelta")>] member inline _.AccentForegroundActiveDelta ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Int32>) = render ==> ("AccentForegroundActiveDelta" => x)
    [<CustomOperation("AccentForegroundFocusDelta")>] member inline _.AccentForegroundFocusDelta ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Int32>) = render ==> ("AccentForegroundFocusDelta" => x)
    [<CustomOperation("NeutralFillRestDelta")>] member inline _.NeutralFillRestDelta ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Int32>) = render ==> ("NeutralFillRestDelta" => x)
    [<CustomOperation("NeutralFillHoverDelta")>] member inline _.NeutralFillHoverDelta ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Int32>) = render ==> ("NeutralFillHoverDelta" => x)
    [<CustomOperation("NeutralFillActiveDelta")>] member inline _.NeutralFillActiveDelta ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Int32>) = render ==> ("NeutralFillActiveDelta" => x)
    [<CustomOperation("NeutralFillFocusDelta")>] member inline _.NeutralFillFocusDelta ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Int32>) = render ==> ("NeutralFillFocusDelta" => x)
    [<CustomOperation("NeutralFillInputRestDelta")>] member inline _.NeutralFillInputRestDelta ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Int32>) = render ==> ("NeutralFillInputRestDelta" => x)
    [<CustomOperation("NeutralFillInputHoverDelta")>] member inline _.NeutralFillInputHoverDelta ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Int32>) = render ==> ("NeutralFillInputHoverDelta" => x)
    [<CustomOperation("NeutralFillInputActiveDelta")>] member inline _.NeutralFillInputActiveDelta ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Int32>) = render ==> ("NeutralFillInputActiveDelta" => x)
    [<CustomOperation("NeutralFillInputFocusDelta")>] member inline _.NeutralFillInputFocusDelta ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Int32>) = render ==> ("NeutralFillInputFocusDelta" => x)
    [<CustomOperation("NeutralFillLayerRestDelta")>] member inline _.NeutralFillLayerRestDelta ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Int32>) = render ==> ("NeutralFillLayerRestDelta" => x)
    [<CustomOperation("NeutralFillStealthRestDelta")>] member inline _.NeutralFillStealthRestDelta ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Int32>) = render ==> ("NeutralFillStealthRestDelta" => x)
    [<CustomOperation("NeutralFillStealthHoverDelta")>] member inline _.NeutralFillStealthHoverDelta ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Int32>) = render ==> ("NeutralFillStealthHoverDelta" => x)
    [<CustomOperation("NeutralFillStealthActiveDelta")>] member inline _.NeutralFillStealthActiveDelta ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Int32>) = render ==> ("NeutralFillStealthActiveDelta" => x)
    [<CustomOperation("NeutralFillStealthFocusDelta")>] member inline _.NeutralFillStealthFocusDelta ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Int32>) = render ==> ("NeutralFillStealthFocusDelta" => x)
    [<CustomOperation("NeutralFillStrongHoverDelta")>] member inline _.NeutralFillStrongHoverDelta ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Int32>) = render ==> ("NeutralFillStrongHoverDelta" => x)
    [<CustomOperation("NeutralFillStrongActiveDelta")>] member inline _.NeutralFillStrongActiveDelta ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Int32>) = render ==> ("NeutralFillStrongActiveDelta" => x)
    [<CustomOperation("NeutralFillStrongFocusDelta")>] member inline _.NeutralFillStrongFocusDelta ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Int32>) = render ==> ("NeutralFillStrongFocusDelta" => x)
    [<CustomOperation("NeutralStrokeDividerRestDelta")>] member inline _.NeutralStrokeDividerRestDelta ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Int32>) = render ==> ("NeutralStrokeDividerRestDelta" => x)
    [<CustomOperation("NeutralStrokeRestDelta")>] member inline _.NeutralStrokeRestDelta ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Int32>) = render ==> ("NeutralStrokeRestDelta" => x)
    [<CustomOperation("NeutralStrokeHoverDelta")>] member inline _.NeutralStrokeHoverDelta ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Int32>) = render ==> ("NeutralStrokeHoverDelta" => x)
    [<CustomOperation("NeutralStrokeActiveDelta")>] member inline _.NeutralStrokeActiveDelta ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Int32>) = render ==> ("NeutralStrokeActiveDelta" => x)
    [<CustomOperation("NeutralStrokeFocusDelta")>] member inline _.NeutralStrokeFocusDelta ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Int32>) = render ==> ("NeutralStrokeFocusDelta" => x)
    [<CustomOperation("BaseLayerLuminance")>] member inline _.BaseLayerLuminance ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Single>) = render ==> ("BaseLayerLuminance" => x)

type FluentDialogBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentComponentBaseBuilder<'FunBlazorGeneric>()
    /// Prevents scrolling outside of the dialog while it is shown.
    [<CustomOperation("PreventScroll")>] member inline _.PreventScroll ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("PreventScroll" => x)
    /// Indicates the element is modal. When modal, user mouse interaction will be limited to the contents of the element by a modal
    /// overlay.  Clicks on the overlay will cause the dialog to emit a "dismiss" event.
    [<CustomOperation("Modal")>] member inline _.Modal ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Boolean>) = render ==> ("Modal" => x)
    /// Gets or sets if the dialog is hidden
    [<CustomOperation("Hidden")>] member inline _.Hidden ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("Hidden" => x)
    /// Gets or sets if the dialog is hidden
    [<CustomOperation("Hidden'")>] member inline _.Hidden' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.Boolean * (System.Boolean -> unit)) = render ==> html.bind("Hidden", valueFn)
    /// The event callback invoked when Hidden change.
    [<CustomOperation("HiddenChanged")>] member inline _.HiddenChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callback<System.Boolean>("HiddenChanged", fn)
    /// The event callback invoked when Hidden change.
    [<CustomOperation("HiddenChanged")>] member inline _.HiddenChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callbackTask<System.Boolean>("HiddenChanged", fn)
    /// Indicates that the dialog should trap focus.
    [<CustomOperation("TrapFocus")>] member inline _.TrapFocus ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Boolean>) = render ==> ("TrapFocus" => x)
    /// The id of the element describing the dialog.
    [<CustomOperation("AriaDescribedby")>] member inline _.AriaDescribedby ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("AriaDescribedby" => x)
    /// The id of the element labeling the dialog.
    [<CustomOperation("AriaLabelledby")>] member inline _.AriaLabelledby ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("AriaLabelledby" => x)
    /// The label surfaced to assistive technologies.
    [<CustomOperation("AriaLabel")>] member inline _.AriaLabel ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("AriaLabel" => x)
    /// The instance containing the programmatic API for the dialog.
    [<CustomOperation("Instance")>] member inline _.Instance ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.Fast.Components.FluentUI.DialogInstance) = render ==> ("Instance" => x)
    /// The event callback invoked to return the dialog result.
    [<CustomOperation("OnDialogResult")>] member inline _.OnDialogResult ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callback<Microsoft.Fast.Components.FluentUI.DialogResult>("OnDialogResult", fn)
    /// The event callback invoked to return the dialog result.
    [<CustomOperation("OnDialogResult")>] member inline _.OnDialogResult ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callbackTask<Microsoft.Fast.Components.FluentUI.DialogResult>("OnDialogResult", fn)

type FluentDialogBodyBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentComponentBaseBuilder<'FunBlazorGeneric>()


type FluentDialogFooterBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentComponentBaseBuilder<'FunBlazorGeneric>()
    /// When true, the footer is visible.
    /// Default is True.
    [<CustomOperation("Visible")>] member inline _.Visible ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("Visible" => x)

type FluentDialogHeaderBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentComponentBaseBuilder<'FunBlazorGeneric>()
    /// When true, the header is visible.
    /// Default is True.
    [<CustomOperation("Visible")>] member inline _.Visible ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("Visible" => x)
    /// When true, shows the dismiss button in the header.
    /// If defined, this value will replace the one defined in the DialogParameters.
    [<CustomOperation("ShowDismiss")>] member inline _.ShowDismiss ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Boolean>) = render ==> ("ShowDismiss" => x)

type FluentDividerBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentComponentBaseBuilder<'FunBlazorGeneric>()
    /// The role of the element.
    [<CustomOperation("Role")>] member inline _.Role ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<Microsoft.Fast.Components.FluentUI.DividerRole>) = render ==> ("Role" => x)
    /// The orientation of the divider.
    [<CustomOperation("Orientation")>] member inline _.Orientation ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<Microsoft.Fast.Components.FluentUI.Orientation>) = render ==> ("Orientation" => x)

type FluentDragContainerBuilder<'FunBlazorGeneric, 'TItem when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentComponentBaseBuilder<'FunBlazorGeneric>()
    /// This event is fired when the user starts dragging an element.
    [<CustomOperation("OnDragStart")>] member inline _.OnDragStart ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("OnDragStart" => (System.Action<Microsoft.Fast.Components.FluentUI.FluentDragEventArgs<'TItem>>fn))
    /// This event is fired when a dragged element enters a valid drop target.
    [<CustomOperation("OnDragEnter")>] member inline _.OnDragEnter ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("OnDragEnter" => (System.Action<Microsoft.Fast.Components.FluentUI.FluentDragEventArgs<'TItem>>fn))
    /// This event is fired when an element is being dragged over a valid drop target.
    [<CustomOperation("OnDragOver")>] member inline _.OnDragOver ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("OnDragOver" => (System.Action<Microsoft.Fast.Components.FluentUI.FluentDragEventArgs<'TItem>>fn))
    /// This event is fired when a dragged element leaves a valid drop target.
    [<CustomOperation("OnDragLeave")>] member inline _.OnDragLeave ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("OnDragLeave" => (System.Action<Microsoft.Fast.Components.FluentUI.FluentDragEventArgs<'TItem>>fn))
    /// This event is fired when an element is dropped on a valid drop target.
    [<CustomOperation("OnDropEnd")>] member inline _.OnDropEnd ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("OnDropEnd" => (System.Action<Microsoft.Fast.Components.FluentUI.FluentDragEventArgs<'TItem>>fn))

type FluentDropZoneBuilder<'FunBlazorGeneric, 'TItem when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentComponentBaseBuilder<'FunBlazorGeneric>()
    /// Item to identify a draggable zone.
    [<CustomOperation("Item")>] member inline _.Item ([<InlineIfLambda>] render: AttrRenderFragment, x: 'TItem) = render ==> ("Item" => x)
    /// Indicates whether the element can receive a dragged item.
    [<CustomOperation("Droppable")>] member inline _.Droppable ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("Droppable" => x)
    /// Indicates whether the element can be dragged.
    [<CustomOperation("Draggable")>] member inline _.Draggable ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("Draggable" => x)
    /// This event is fired when the user starts dragging an element.
    [<CustomOperation("OnDragStart")>] member inline _.OnDragStart ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("OnDragStart" => (System.Action<Microsoft.Fast.Components.FluentUI.FluentDragEventArgs<'TItem>>fn))
    /// This event is fired when a dragged element enters a valid drop target.
    [<CustomOperation("OnDragEnter")>] member inline _.OnDragEnter ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("OnDragEnter" => (System.Action<Microsoft.Fast.Components.FluentUI.FluentDragEventArgs<'TItem>>fn))
    /// This event is fired when an element is being dragged over a valid drop target.
    [<CustomOperation("OnDragOver")>] member inline _.OnDragOver ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("OnDragOver" => (System.Action<Microsoft.Fast.Components.FluentUI.FluentDragEventArgs<'TItem>>fn))
    /// This event is fired when a dragged element leaves a valid drop target.
    [<CustomOperation("OnDragLeave")>] member inline _.OnDragLeave ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("OnDragLeave" => (System.Action<Microsoft.Fast.Components.FluentUI.FluentDragEventArgs<'TItem>>fn))
    /// This event is fired when an element is dropped on a valid drop target.
    [<CustomOperation("OnDropEnd")>] member inline _.OnDropEnd ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("OnDropEnd" => (System.Action<Microsoft.Fast.Components.FluentUI.FluentDragEventArgs<'TItem>>fn))

/// FluentEmoji is a component that renders an emoji from the Microsoft FluentUI emoji set.
type FluentEmojiBuilder<'FunBlazorGeneric, 'Emoji when 'Emoji : (new : unit -> 'Emoji) and 'Emoji :> Microsoft.Fast.Components.FluentUI.Emoji and 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentComponentBaseBuilder<'FunBlazorGeneric>()
    /// Gets or sets the slot where the emoji is displayed in
    [<CustomOperation("Slot")>] member inline _.Slot ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Slot" => x)
    /// Gets or sets the title for the emoji
    [<CustomOperation("Title")>] member inline _.Title ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Title" => x)
    /// Gets or sets the emoji width.
    /// If not set, the emoji size will be used.
    [<CustomOperation("Width")>] member inline _.Width ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Width" => x)
    /// Gets or sets the Emoji object to render.
    [<CustomOperation("Value")>] member inline _.Value ([<InlineIfLambda>] render: AttrRenderFragment, x: 'Emoji) = render ==> ("Value" => x)
    /// Allows for capturing a mouse click on an emoji
    [<CustomOperation("OnClick")>] member inline _.OnClick ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>("OnClick", fn)
    /// Allows for capturing a mouse click on an emoji
    [<CustomOperation("OnClick")>] member inline _.OnClick ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callbackTask<Microsoft.AspNetCore.Components.Web.MouseEventArgs>("OnClick", fn)

type FluentFlipperBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentComponentBaseBuilder<'FunBlazorGeneric>()
    /// Gets or set if the element is disabled
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Boolean>) = render ==> ("Disabled" => x)
    /// Indicates the flipper should be hidden from assistive technology. Because flippers are often supplementary navigation, they are often hidden from assistive technology.
    [<CustomOperation("AriaHidden")>] member inline _.AriaHidden ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Boolean>) = render ==> ("AriaHidden" => x)
    /// Gets or sets the direction. See FlipperDirection
    [<CustomOperation("Direction")>] member inline _.Direction ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<Microsoft.Fast.Components.FluentUI.FlipperDirection>) = render ==> ("Direction" => x)

type FluentFooterBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentComponentBaseBuilder<'FunBlazorGeneric>()


/// The grid component helps keeping layout consistent across various screen resolutions and sizes.
/// PowerGrid comes with a 12-point grid system and contains 5 types of breakpoints
/// that are used for specific screen sizes.
type FluentGridBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentComponentBaseBuilder<'FunBlazorGeneric>()
    /// Distance between flexbox items, using a multiple of 4px.
    /// Only values from 0 to 10 are possible.
    [<CustomOperation("Spacing")>] member inline _.Spacing ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("Spacing" => x)
    /// Defines how the browser distributes space between and around content items.
    [<CustomOperation("Justify")>] member inline _.Justify ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.Fast.Components.FluentUI.JustifyContent) = render ==> ("Justify" => x)

type FluentGridItemBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("xs")>] member inline _.xs ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Int32>) = render ==> ("xs" => x)
    [<CustomOperation("sm")>] member inline _.sm ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Int32>) = render ==> ("sm" => x)
    [<CustomOperation("md")>] member inline _.md ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Int32>) = render ==> ("md" => x)
    [<CustomOperation("lg")>] member inline _.lg ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Int32>) = render ==> ("lg" => x)
    [<CustomOperation("xl")>] member inline _.xl ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Int32>) = render ==> ("xl" => x)
    [<CustomOperation("xxl")>] member inline _.xxl ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Int32>) = render ==> ("xxl" => x)
    /// Defines how the browser distributes space between and around content items.
    [<CustomOperation("Justify")>] member inline _.Justify ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<Microsoft.Fast.Components.FluentUI.JustifyContent>) = render ==> ("Justify" => x)
    /// Defines the gaps (gutters) between rows and columns.
    /// See https://developer.mozilla.org/en-US/docs/Web/CSS/gap
    [<CustomOperation("Gap")>] member inline _.Gap ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Gap" => x)

type FluentHeaderBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentComponentBaseBuilder<'FunBlazorGeneric>()
    /// Gets or sets the height of the header (in pixels).
    [<CustomOperation("Height")>] member inline _.Height ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Int32>) = render ==> ("Height" => x)

type FluentHighlighterBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentComponentBaseBuilder<'FunBlazorGeneric>()
    /// Whether or not the highlighted text is case sensitive
    [<CustomOperation("CaseSensitive")>] member inline _.CaseSensitive ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("CaseSensitive" => x)
    /// The fragment of text to be highlighted
    [<CustomOperation("HighlightedText")>] member inline _.HighlightedText ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("HighlightedText" => x)
    /// The whole text in which a fragment will be highlighted
    [<CustomOperation("Text")>] member inline _.Text ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Text" => x)
    /// List of delimiters chars. Example: " ,;".
    [<CustomOperation("Delimiters")>] member inline _.Delimiters ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Delimiters" => x)
    /// If true, highlights the text until the next regex boundary
    [<CustomOperation("UntilNextBoundary")>] member inline _.UntilNextBoundary ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("UntilNextBoundary" => x)

type FluentHorizontalScrollBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentComponentBaseBuilder<'FunBlazorGeneric>()
    /// Description: Scroll speed in pixels per second
    [<CustomOperation("Speed")>] member inline _.Speed ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("Speed" => x)
    /// The CSS time value for the scroll transition duration. Overrides the `speed` attribute.
    [<CustomOperation("Duration")>] member inline _.Duration ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Duration" => x)
    /// Attribute used for easing, defaults to ease-in-out
    [<CustomOperation("Easing")>] member inline _.Easing ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<Microsoft.Fast.Components.FluentUI.ScrollEasing>) = render ==> ("Easing" => x)
    /// Attribute to hide flippers from assistive technology
    [<CustomOperation("FlippersHiddenFromAt")>] member inline _.FlippersHiddenFromAt ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Boolean>) = render ==> ("FlippersHiddenFromAt" => x)
    /// View: default | mobile
    [<CustomOperation("View")>] member inline _.View ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<Microsoft.Fast.Components.FluentUI.HorizontalScrollView>) = render ==> ("View" => x)

/// FluentIcon is a component that renders an icon from the Fluent System icon set.
type FluentIconBuilder<'FunBlazorGeneric, 'Icon when 'Icon : (new : unit -> 'Icon) and 'Icon :> Microsoft.Fast.Components.FluentUI.Icon and 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentComponentBaseBuilder<'FunBlazorGeneric>()
    /// Gets or sets the slot where the icon is displayed in
    [<CustomOperation("Slot")>] member inline _.Slot ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Slot" => x)
    /// Gets or sets the title for the icon
    [<CustomOperation("Title")>] member inline _.Title ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Title" => x)
    /// Gets or sets the icon drawing and fill color. 
    /// Value comes from the Color enumeration. Defaults to Accent.
    [<CustomOperation("Color")>] member inline _.Color ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<Microsoft.Fast.Components.FluentUI.Color>) = render ==> ("Color" => x)
    /// Gets or sets the icon drawing and fill color to a custom value.
    /// Needs to be formatted as an HTML hex color string (#rrggbb or #rgb) or CSS variable.
    /// ⚠️ Only available when Color is set to Color.Custom.
    [<CustomOperation("CustomColor")>] member inline _.CustomColor ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("CustomColor" => x)
    /// Gets or sets the icon width.
    /// If not set, the icon size will be used.
    [<CustomOperation("Width")>] member inline _.Width ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Width" => x)
    /// Gets or sets the Icon object to render.
    [<CustomOperation("Value")>] member inline _.Value ([<InlineIfLambda>] render: AttrRenderFragment, x: 'Icon) = render ==> ("Value" => x)
    /// Allows for capturing a mouse click on an icon
    [<CustomOperation("OnClick")>] member inline _.OnClick ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>("OnClick", fn)
    /// Allows for capturing a mouse click on an icon
    [<CustomOperation("OnClick")>] member inline _.OnClick ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callbackTask<Microsoft.AspNetCore.Components.Web.MouseEventArgs>("OnClick", fn)

type FluentInputFileBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentComponentBaseBuilder<'FunBlazorGeneric>()
    /// To enable multiple file selection and upload, set the Multiple property to true.
    /// Set MaximumFileCount to change the number of allowed files.
    [<CustomOperation("Multiple")>] member inline _.Multiple ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("Multiple" => x)
    /// To select multiple files, set the maximum number of files allowed to be uploaded.
    /// Default value is 10
    [<CustomOperation("MaximumFileCount")>] member inline _.MaximumFileCount ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("MaximumFileCount" => x)
    /// Maximum size of a file to be uploaded (in bytes).
    /// Default value is 10 MB.
    [<CustomOperation("MaximumFileSize")>] member inline _.MaximumFileSize ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int64) = render ==> ("MaximumFileSize" => x)
    /// Size of buffer to read bytes from uploaded file (in bytes).
    /// Default value is 10 KB.
    [<CustomOperation("BufferSize")>] member inline _.BufferSize ([<InlineIfLambda>] render: AttrRenderFragment, x: System.UInt32) = render ==> ("BufferSize" => x)
    /// Filter for what file types the user can pick from the file input dialog box.
    /// Example: ".gif, .jpg, .png, .doc", "audio/*", "video/*", "image/*"
    /// See https://developer.mozilla.org/en-US/docs/Web/HTML/Attributes/accept
    /// for more information.
    [<CustomOperation("Accept")>] member inline _.Accept ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Accept" => x)
    /// Type of file reading.
    /// For SaveToTemporaryFolder, use LocalFile to retrieve the file.
    /// For Buffer, use Buffer to retrieve bytes.
    [<CustomOperation("Mode")>] member inline _.Mode ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.Fast.Components.FluentUI.InputFileMode) = render ==> ("Mode" => x)
    /// Drag/Drop zone visible or not. Default is true.
    /// You can.
    [<CustomOperation("DragDropZoneVisible")>] member inline _.DragDropZoneVisible ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("DragDropZoneVisible" => x)
    /// Use the native event raised by the InputFile component.
    /// If you use this event, the OnFileUploaded will never be raised.
    [<CustomOperation("OnInputFileChange")>] member inline _.OnInputFileChange ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callback<Microsoft.AspNetCore.Components.Forms.InputFileChangeEventArgs>("OnInputFileChange", fn)
    /// Use the native event raised by the InputFile component.
    /// If you use this event, the OnFileUploaded will never be raised.
    [<CustomOperation("OnInputFileChange")>] member inline _.OnInputFileChange ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callbackTask<Microsoft.AspNetCore.Components.Forms.InputFileChangeEventArgs>("OnInputFileChange", fn)
    /// Raise when a file is completely uploaded.
    [<CustomOperation("OnFileUploaded")>] member inline _.OnFileUploaded ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callback<Microsoft.Fast.Components.FluentUI.FluentInputFileEventArgs>("OnFileUploaded", fn)
    /// Raise when a file is completely uploaded.
    [<CustomOperation("OnFileUploaded")>] member inline _.OnFileUploaded ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callbackTask<Microsoft.Fast.Components.FluentUI.FluentInputFileEventArgs>("OnFileUploaded", fn)
    /// Raise when a progression step is updated.
    /// You can use ProgressPercent and ProgressTitle to have more detail on the progression.
    [<CustomOperation("OnProgressChange")>] member inline _.OnProgressChange ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callback<Microsoft.Fast.Components.FluentUI.FluentInputFileEventArgs>("OnProgressChange", fn)
    /// Raise when a progression step is updated.
    /// You can use ProgressPercent and ProgressTitle to have more detail on the progression.
    [<CustomOperation("OnProgressChange")>] member inline _.OnProgressChange ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callbackTask<Microsoft.Fast.Components.FluentUI.FluentInputFileEventArgs>("OnProgressChange", fn)
    /// Raise when a file raised an error.
    [<CustomOperation("OnFileError")>] member inline _.OnFileError ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callback<Microsoft.Fast.Components.FluentUI.FluentInputFileEventArgs>("OnFileError", fn)
    /// Raise when a file raised an error.
    [<CustomOperation("OnFileError")>] member inline _.OnFileError ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callbackTask<Microsoft.Fast.Components.FluentUI.FluentInputFileEventArgs>("OnFileError", fn)
    /// Raise when all files are completely uploaded.
    [<CustomOperation("OnCompleted")>] member inline _.OnCompleted ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callback<System.Collections.Generic.IEnumerable<Microsoft.Fast.Components.FluentUI.FluentInputFileEventArgs>>("OnCompleted", fn)
    /// Raise when all files are completely uploaded.
    [<CustomOperation("OnCompleted")>] member inline _.OnCompleted ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callbackTask<System.Collections.Generic.IEnumerable<Microsoft.Fast.Components.FluentUI.FluentInputFileEventArgs>>("OnCompleted", fn)
    /// Identifier of the source component clickable by the end user.
    [<CustomOperation("AnchorId")>] member inline _.AnchorId ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("AnchorId" => x)

type FluentLabelBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentComponentBaseBuilder<'FunBlazorGeneric>()
    /// Applies the theme typography styles.
    [<CustomOperation("Typo")>] member inline _.Typo ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.Fast.Components.FluentUI.Typography) = render ==> ("Typo" => x)
    /// Activates or deactivates the component (changes the color).
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("Disabled" => x)
    /// Set the text-align on the component.
    [<CustomOperation("Alignment")>] member inline _.Alignment ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<Microsoft.Fast.Components.FluentUI.HorizontalAlignment>) = render ==> ("Alignment" => x)
    /// The color of the component. It supports the theme colors.
    [<CustomOperation("Color")>] member inline _.Color ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<Microsoft.Fast.Components.FluentUI.Color>) = render ==> ("Color" => x)
    /// 7
    ///             The front weight of the component:
    ///             Normal (400), Bold (600) or Bolder (800).
    ///             
    [<CustomOperation("Weight")>] member inline _.Weight ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.Fast.Components.FluentUI.FontWeight) = render ==> ("Weight" => x)
    /// "default" to use the margin-block prefefined by browser.
    /// If not set, the MarginBlock will be 0px.
    [<CustomOperation("MarginBlock")>] member inline _.MarginBlock ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("MarginBlock" => x)

type FluentLayoutBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentComponentBaseBuilder<'FunBlazorGeneric>()


type FluentOptionBuilder<'FunBlazorGeneric, 'TOption when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentComponentBaseBuilder<'FunBlazorGeneric>()
    /// Gets or sets if the element is disabled
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("Disabled" => x)
    /// Gets or sets the value of this option.
    [<CustomOperation("Value")>] member inline _.Value ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Value" => x)
    /// Gets or sets if the element is selected
    [<CustomOperation("Selected")>] member inline _.Selected ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("Selected" => x)
    /// Gets or sets if the element is selected
    [<CustomOperation("Selected'")>] member inline _.Selected' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.Boolean * (System.Boolean -> unit)) = render ==> html.bind("Selected", valueFn)
    /// Called whenever the selection changed.
    [<CustomOperation("SelectedChanged")>] member inline _.SelectedChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callback<System.Boolean>("SelectedChanged", fn)
    /// Called whenever the selection changed.
    [<CustomOperation("SelectedChanged")>] member inline _.SelectedChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callbackTask<System.Boolean>("SelectedChanged", fn)
    /// Called whenever the selection changed.
    [<CustomOperation("OnSelect")>] member inline _.OnSelect ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callback<System.String>("OnSelect", fn)
    /// Called whenever the selection changed.
    [<CustomOperation("OnSelect")>] member inline _.OnSelect ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callbackTask<System.String>("OnSelect", fn)

/// People picker option component.
type FluentPersonaBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentComponentBaseBuilder<'FunBlazorGeneric>()
    /// Gets or sets the initials to display if no image is provided.
    /// Byt default, the first letters of the Name is used.
    [<CustomOperation("Initials")>] member inline _.Initials ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Initials" => x)
    /// Gets or sets the name to display.
    [<CustomOperation("Name")>] member inline _.Name ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Name" => x)
    /// Gets or sets the image to display, in replacement of the initials.
    [<CustomOperation("Image")>] member inline _.Image ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Image" => x)
    /// Gets or sets the size of the image.
    [<CustomOperation("ImageSize")>] member inline _.ImageSize ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("ImageSize" => x)
    /// The status to show. See PresenceStatus for options.
    [<CustomOperation("Status")>] member inline _.Status ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<Microsoft.Fast.Components.FluentUI.PresenceStatus>) = render ==> ("Status" => x)
    /// The title to show on hover. If not provided, the status will be used.
    [<CustomOperation("StatusTitle")>] member inline _.StatusTitle ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("StatusTitle" => x)
    /// Gets or sets the Status size to use.
    /// Default is ExtraSmall.
    [<CustomOperation("StatusSize")>] member inline _.StatusSize ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.Fast.Components.FluentUI.PresenceBadgeSize) = render ==> ("StatusSize" => x)
    /// Gets or sets the event raised when the user clicks on the dismiss button.
    [<CustomOperation("OnDismissClick")>] member inline _.OnDismissClick ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callback("OnDismissClick", fn)
    /// Gets or sets the event raised when the user clicks on the dismiss button.
    [<CustomOperation("OnDismissClick")>] member inline _.OnDismissClick ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callbackTask("OnDismissClick", fn)
    /// Gets or sets the title of the dismiss button.
    [<CustomOperation("DismissTitle")>] member inline _.DismissTitle ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("DismissTitle" => x)

/// Component that provides a list of options.
type ListComponentBaseBuilder<'FunBlazorGeneric, 'TOption when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentComponentBaseBuilder<'FunBlazorGeneric>()
    /// Width of the component.
    [<CustomOperation("Width")>] member inline _.Width ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Width" => x)
    /// Height of the component or of the popup panel.
    [<CustomOperation("Height")>] member inline _.Height ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Height" => x)
    /// Text displayed just above the component
    [<CustomOperation("Label")>] member inline _.Label ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Label" => x)
    /// Content displayed just above the component
    [<CustomOperation("LabelTemplate")>] member inline _.LabelTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragment) = render ==> html.renderFragment("LabelTemplate", fragment)
    /// Content displayed just above the component
    [<CustomOperation("LabelTemplate")>] member inline _.LabelTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragments) = render ==> html.renderFragment("LabelTemplate", fragment { yield! fragments })
    /// Content displayed just above the component
    [<CustomOperation("LabelTemplate")>] member inline _.LabelTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("LabelTemplate", html.text x)
    /// Content displayed just above the component
    [<CustomOperation("LabelTemplate")>] member inline _.LabelTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("LabelTemplate", html.text x)
    /// Content displayed just above the component
    [<CustomOperation("LabelTemplate")>] member inline _.LabelTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("LabelTemplate", html.text x)
    /// Text used on aria-label attribute.
    [<CustomOperation("AriaLabel")>] member inline _.AriaLabel ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("AriaLabel" => x)
    /// Text used on aria-label attribute.
    [<CustomOperation("Title")>] member inline _.Title ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Title" => x)
    /// If true, will disable the list of items.
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("Disabled" => x)
    /// Function used to determine which text to display for each option.
    [<CustomOperation("OptionText")>] member inline _.OptionText ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("OptionText" => (System.Func<'TOption, System.String>fn))
    /// Function used to determine which value to return for the selected item.
    /// Only for FluentListbox`1 and FluentSelect`1 components.
    [<CustomOperation("OptionValue")>] member inline _.OptionValue ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("OptionValue" => (System.Func<'TOption, System.String>fn))
    /// Function used to determine if an option is disabled.
    [<CustomOperation("OptionDisabled")>] member inline _.OptionDisabled ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("OptionDisabled" => (System.Func<'TOption, System.Boolean>fn))
    /// Function used to determine if an option is initially selected.
    [<CustomOperation("OptionSelected")>] member inline _.OptionSelected ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("OptionSelected" => (System.Func<'TOption, System.Boolean>fn))
    /// Content source of all items to display in this list.
    [<CustomOperation("Items")>] member inline _.Items ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.IEnumerable<'TOption>) = render ==> ("Items" => x)
    /// Gets or sets the selected item.
    /// ⚠️ Only available when Multiple = false.
    [<CustomOperation("SelectedOption")>] member inline _.SelectedOption ([<InlineIfLambda>] render: AttrRenderFragment, x: 'TOption) = render ==> ("SelectedOption" => x)
    /// Gets or sets the selected item.
    /// ⚠️ Only available when Multiple = false.
    [<CustomOperation("SelectedOption'")>] member inline _.SelectedOption' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: 'TOption * ('TOption -> unit)) = render ==> html.bind("SelectedOption", valueFn)
    /// Called whenever the selection changed.
    /// ⚠️ Only available when Multiple = false.
    [<CustomOperation("SelectedOptionChanged")>] member inline _.SelectedOptionChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callback<'TOption>("SelectedOptionChanged", fn)
    /// Called whenever the selection changed.
    /// ⚠️ Only available when Multiple = false.
    [<CustomOperation("SelectedOptionChanged")>] member inline _.SelectedOptionChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callbackTask<'TOption>("SelectedOptionChanged", fn)
    /// Gets or sets the selected value.
    /// When Multiple = true this only reflects the first selected option value.
    [<CustomOperation("Value")>] member inline _.Value ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Value" => x)
    /// Gets or sets the selected value.
    /// When Multiple = true this only reflects the first selected option value.
    [<CustomOperation("Value'")>] member inline _.Value' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.String * (System.String -> unit)) = render ==> html.bind("Value", valueFn)
    /// Called whenever the selection changed.
    /// ⚠️ Only available when Multiple = false.
    [<CustomOperation("ValueChanged")>] member inline _.ValueChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callback<System.String>("ValueChanged", fn)
    /// Called whenever the selection changed.
    /// ⚠️ Only available when Multiple = false.
    [<CustomOperation("ValueChanged")>] member inline _.ValueChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callbackTask<System.String>("ValueChanged", fn)
    /// If true, the user can select multiple elements.
    /// ⚠️ Only available for the FluentSelect and FluentListbox components.
    [<CustomOperation("Multiple")>] member inline _.Multiple ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("Multiple" => x)
    /// Gets or sets all selected items.
    /// ⚠️ Only available when Multiple = true.
    [<CustomOperation("SelectedOptions")>] member inline _.SelectedOptions ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.IEnumerable<'TOption>) = render ==> ("SelectedOptions" => x)
    /// Gets or sets all selected items.
    /// ⚠️ Only available when Multiple = true.
    [<CustomOperation("SelectedOptions'")>] member inline _.SelectedOptions' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.Collections.Generic.IEnumerable<'TOption> * (System.Collections.Generic.IEnumerable<'TOption> -> unit)) = render ==> html.bind("SelectedOptions", valueFn)
    /// Called whenever the selection changed.
    /// ⚠️ Only available when Multiple = true.
    [<CustomOperation("SelectedOptionsChanged")>] member inline _.SelectedOptionsChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callback<System.Collections.Generic.IEnumerable<'TOption>>("SelectedOptionsChanged", fn)
    /// Called whenever the selection changed.
    /// ⚠️ Only available when Multiple = true.
    [<CustomOperation("SelectedOptionsChanged")>] member inline _.SelectedOptionsChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callbackTask<System.Collections.Generic.IEnumerable<'TOption>>("SelectedOptionsChanged", fn)

type FluentAutocompleteBuilder<'FunBlazorGeneric, 'TOption when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ListComponentBaseBuilder<'FunBlazorGeneric, 'TOption>()
    /// Sets the placeholder value of the element, generally used to provide a hint to the user.
    [<CustomOperation("Placeholder")>] member inline _.Placeholder ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Placeholder" => x)
    /// Gets or sets the visual appearance. See 
    [<CustomOperation("Appearance")>] member inline _.Appearance ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<Microsoft.Fast.Components.FluentUI.Appearance>) = render ==> ("Appearance" => x)
    /// Filter the list of options (items), using the text encoded by the user.
    [<CustomOperation("OnOptionsSearch")>] member inline _.OnOptionsSearch ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callback<Microsoft.Fast.Components.FluentUI.OptionsSearchEventArgs<'TOption>>("OnOptionsSearch", fn)
    /// Filter the list of options (items), using the text encoded by the user.
    [<CustomOperation("OnOptionsSearch")>] member inline _.OnOptionsSearch ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callbackTask<Microsoft.Fast.Components.FluentUI.OptionsSearchEventArgs<'TOption>>("OnOptionsSearch", fn)
    /// Gets or sets the style applied to all FluentOption`1 of the component.
    [<CustomOperation("OptionStyle")>] member inline _.OptionStyle ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("OptionStyle" => x)
    /// Gets or sets the css class applied to all FluentOption`1 of the component.
    [<CustomOperation("OptionClass")>] member inline _.OptionClass ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("OptionClass" => x)
    /// Gets or sets the number of maximum options (items) returned by OnOptionsSearch.
    /// Default value is 9.
    [<CustomOperation("MaximumOptionsSearch")>] member inline _.MaximumOptionsSearch ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("MaximumOptionsSearch" => x)
    /// Gets or sets the maximum number of options (items) selected.
    /// Exceeding this value requires the user to delete some elements in order to select new ones.
    /// See the MaximumSelectedOptionsMessage.
    [<CustomOperation("MaximumSelectedOptions")>] member inline _.MaximumSelectedOptions ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Int32>) = render ==> ("MaximumSelectedOptions" => x)
    /// Gets or sets the message displayed when the MaximumSelectedOptions is reached.
    [<CustomOperation("MaximumSelectedOptionsMessage")>] member inline _.MaximumSelectedOptionsMessage ([<InlineIfLambda>] render: AttrRenderFragment, fragment) = render ==> html.renderFragment("MaximumSelectedOptionsMessage", fragment)
    /// Gets or sets the message displayed when the MaximumSelectedOptions is reached.
    [<CustomOperation("MaximumSelectedOptionsMessage")>] member inline _.MaximumSelectedOptionsMessage ([<InlineIfLambda>] render: AttrRenderFragment, fragments) = render ==> html.renderFragment("MaximumSelectedOptionsMessage", fragment { yield! fragments })
    /// Gets or sets the message displayed when the MaximumSelectedOptions is reached.
    [<CustomOperation("MaximumSelectedOptionsMessage")>] member inline _.MaximumSelectedOptionsMessage ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("MaximumSelectedOptionsMessage", html.text x)
    /// Gets or sets the message displayed when the MaximumSelectedOptions is reached.
    [<CustomOperation("MaximumSelectedOptionsMessage")>] member inline _.MaximumSelectedOptionsMessage ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("MaximumSelectedOptionsMessage", html.text x)
    /// Gets or sets the message displayed when the MaximumSelectedOptions is reached.
    [<CustomOperation("MaximumSelectedOptionsMessage")>] member inline _.MaximumSelectedOptionsMessage ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("MaximumSelectedOptionsMessage", html.text x)
    /// Template for the Items items.
    [<CustomOperation("OptionTemplate")>] member inline _.OptionTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fn: 'TOption -> NodeRenderFragment) = render ==> html.renderFragment("OptionTemplate", fn)
    /// Template for the SelectedOptions items.
    [<CustomOperation("SelectedOptionTemplate")>] member inline _.SelectedOptionTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fn: 'TOption -> NodeRenderFragment) = render ==> html.renderFragment("SelectedOptionTemplate", fn)
    /// Header content, placed at the top of the popup panel.
    [<CustomOperation("HeaderContent")>] member inline _.HeaderContent ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.Collections.Generic.IEnumerable<'TOption> -> NodeRenderFragment) = render ==> html.renderFragment("HeaderContent", fn)
    /// Footer content, placed at the bottom of the popup panel.
    [<CustomOperation("FooterContent")>] member inline _.FooterContent ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.Collections.Generic.IEnumerable<'TOption> -> NodeRenderFragment) = render ==> html.renderFragment("FooterContent", fn)
    /// Title and Aria-Label for the Scroll to previous button.
    [<CustomOperation("TitleScrollToPrevious")>] member inline _.TitleScrollToPrevious ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("TitleScrollToPrevious" => x)
    /// Title and Aria-Label for the Scroll to next button.
    [<CustomOperation("TitleScrollToNext")>] member inline _.TitleScrollToNext ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("TitleScrollToNext" => x)

type FluentComboboxBuilder<'FunBlazorGeneric, 'TOption when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ListComponentBaseBuilder<'FunBlazorGeneric, 'TOption>()
    /// Gets or sets if the element is auto completes. See 
    [<CustomOperation("Autocomplete")>] member inline _.Autocomplete ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<Microsoft.Fast.Components.FluentUI.ComboboxAutocomplete>) = render ==> ("Autocomplete" => x)
    /// The open attribute.
    [<CustomOperation("Open")>] member inline _.Open ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Boolean>) = render ==> ("Open" => x)
    /// Sets the placeholder value of the element, generally used to provide a hint to the user.
    [<CustomOperation("Placeholder")>] member inline _.Placeholder ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Placeholder" => x)
    /// The placement for the listbox when the combobox is open.
    /// See 
    [<CustomOperation("Position")>] member inline _.Position ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<Microsoft.Fast.Components.FluentUI.SelectPosition>) = render ==> ("Position" => x)
    /// Gets or sets the visual appearance. See 
    [<CustomOperation("Appearance")>] member inline _.Appearance ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<Microsoft.Fast.Components.FluentUI.Appearance>) = render ==> ("Appearance" => x)

type FluentListboxBuilder<'FunBlazorGeneric, 'TOption when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ListComponentBaseBuilder<'FunBlazorGeneric, 'TOption>()
    /// The maximum number of options that should be visible in the listbox scroll area.
    [<CustomOperation("Size")>] member inline _.Size ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("Size" => x)

type FluentSelectBuilder<'FunBlazorGeneric, 'TOption when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ListComponentBaseBuilder<'FunBlazorGeneric, 'TOption>()
    /// The open attribute.
    [<CustomOperation("Open")>] member inline _.Open ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Boolean>) = render ==> ("Open" => x)
    /// Reflects the placement for the listbox when the select is open.
    /// See SelectPosition
    [<CustomOperation("Position")>] member inline _.Position ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<Microsoft.Fast.Components.FluentUI.SelectPosition>) = render ==> ("Position" => x)
    /// Gets or sets the visual appearance. See 
    [<CustomOperation("Appearance")>] member inline _.Appearance ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<Microsoft.Fast.Components.FluentUI.Appearance>) = render ==> ("Appearance" => x)

type FluentMainLayoutBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentComponentBaseBuilder<'FunBlazorGeneric>()
    /// Gets or sets the header content.
    [<CustomOperation("Header")>] member inline _.Header ([<InlineIfLambda>] render: AttrRenderFragment, fragment) = render ==> html.renderFragment("Header", fragment)
    /// Gets or sets the header content.
    [<CustomOperation("Header")>] member inline _.Header ([<InlineIfLambda>] render: AttrRenderFragment, fragments) = render ==> html.renderFragment("Header", fragment { yield! fragments })
    /// Gets or sets the header content.
    [<CustomOperation("Header")>] member inline _.Header ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("Header", html.text x)
    /// Gets or sets the header content.
    [<CustomOperation("Header")>] member inline _.Header ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("Header", html.text x)
    /// Gets or sets the header content.
    [<CustomOperation("Header")>] member inline _.Header ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("Header", html.text x)
    /// Gets or sets the subheader content.
    [<CustomOperation("SubHeader")>] member inline _.SubHeader ([<InlineIfLambda>] render: AttrRenderFragment, fragment) = render ==> html.renderFragment("SubHeader", fragment)
    /// Gets or sets the subheader content.
    [<CustomOperation("SubHeader")>] member inline _.SubHeader ([<InlineIfLambda>] render: AttrRenderFragment, fragments) = render ==> html.renderFragment("SubHeader", fragment { yield! fragments })
    /// Gets or sets the subheader content.
    [<CustomOperation("SubHeader")>] member inline _.SubHeader ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("SubHeader", html.text x)
    /// Gets or sets the subheader content.
    [<CustomOperation("SubHeader")>] member inline _.SubHeader ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("SubHeader", html.text x)
    /// Gets or sets the subheader content.
    [<CustomOperation("SubHeader")>] member inline _.SubHeader ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("SubHeader", html.text x)
    /// Gets or sets the height of the header (in pixels).
    [<CustomOperation("HeaderHeight")>] member inline _.HeaderHeight ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Int32>) = render ==> ("HeaderHeight" => x)
    /// Gets or set the tite of the navigation menu
    [<CustomOperation("NavMenuTitle")>] member inline _.NavMenuTitle ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("NavMenuTitle" => x)
    /// Gets or sets the content of the navigation menu
    [<CustomOperation("NavMenuContent")>] member inline _.NavMenuContent ([<InlineIfLambda>] render: AttrRenderFragment, fragment) = render ==> html.renderFragment("NavMenuContent", fragment)
    /// Gets or sets the content of the navigation menu
    [<CustomOperation("NavMenuContent")>] member inline _.NavMenuContent ([<InlineIfLambda>] render: AttrRenderFragment, fragments) = render ==> html.renderFragment("NavMenuContent", fragment { yield! fragments })
    /// Gets or sets the content of the navigation menu
    [<CustomOperation("NavMenuContent")>] member inline _.NavMenuContent ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("NavMenuContent", html.text x)
    /// Gets or sets the content of the navigation menu
    [<CustomOperation("NavMenuContent")>] member inline _.NavMenuContent ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("NavMenuContent", html.text x)
    /// Gets or sets the content of the navigation menu
    [<CustomOperation("NavMenuContent")>] member inline _.NavMenuContent ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("NavMenuContent", html.text x)
    /// Gets or sets the content of the body
    [<CustomOperation("Body")>] member inline _.Body ([<InlineIfLambda>] render: AttrRenderFragment, fragment) = render ==> html.renderFragment("Body", fragment)
    /// Gets or sets the content of the body
    [<CustomOperation("Body")>] member inline _.Body ([<InlineIfLambda>] render: AttrRenderFragment, fragments) = render ==> html.renderFragment("Body", fragment { yield! fragments })
    /// Gets or sets the content of the body
    [<CustomOperation("Body")>] member inline _.Body ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("Body", html.text x)
    /// Gets or sets the content of the body
    [<CustomOperation("Body")>] member inline _.Body ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("Body", html.text x)
    /// Gets or sets the content of the body
    [<CustomOperation("Body")>] member inline _.Body ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("Body", html.text x)

type FluentMainBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentComponentBaseBuilder<'FunBlazorGeneric>()
    /// Gets or sets the height of the header (in pixels).
    [<CustomOperation("Height")>] member inline _.Height ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Int32>) = render ==> ("Height" => x)

type FluentMenuButtonBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Button")>] member inline _.Button ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.Fast.Components.FluentUI.FluentButton) = render ==> ("Button" => x)
    [<CustomOperation("Menu")>] member inline _.Menu ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.Fast.Components.FluentUI.FluentMenu) = render ==> ("Menu" => x)
    [<CustomOperation("Text")>] member inline _.Text ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Text" => x)
    [<CustomOperation("ButtonStyle")>] member inline _.ButtonStyle ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("ButtonStyle" => x)
    [<CustomOperation("MenuStyle")>] member inline _.MenuStyle ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("MenuStyle" => x)
    [<CustomOperation("Items")>] member inline _.Items ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.Dictionary<System.String, System.String>) = render ==> ("Items" => x)
    [<CustomOperation("OnMenuChanged")>] member inline _.OnMenuChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callback<Microsoft.Fast.Components.FluentUI.MenuChangeEventArgs>("OnMenuChanged", fn)
    [<CustomOperation("OnMenuChanged")>] member inline _.OnMenuChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callbackTask<Microsoft.Fast.Components.FluentUI.MenuChangeEventArgs>("OnMenuChanged", fn)

type FluentMenuBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentComponentBaseBuilder<'FunBlazorGeneric>()
    /// Identifier of the source component clickable by the end user.
    [<CustomOperation("Anchor")>] member inline _.Anchor ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Anchor" => x)
    /// Gets or sets the automatic trigger. See 
    /// Possible values are None (default), Left, Middle, Right, Back, Forward 
    [<CustomOperation("Trigger")>] member inline _.Trigger ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.Fast.Components.FluentUI.MouseButton) = render ==> ("Trigger" => x)
    /// Gets or sets the Menu status.
    [<CustomOperation("Open")>] member inline _.Open ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("Open" => x)
    /// Gets or sets the Menu status.
    [<CustomOperation("Open'")>] member inline _.Open' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.Boolean * (System.Boolean -> unit)) = render ==> html.bind("Open", valueFn)
    /// Menu position (left or right).
    [<CustomOperation("HorizontalPosition")>] member inline _.HorizontalPosition ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.Fast.Components.FluentUI.HorizontalPosition) = render ==> ("HorizontalPosition" => x)
    /// Width of this menu.
    [<CustomOperation("Width")>] member inline _.Width ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Width" => x)
    /// Raised when the Open property changed.
    [<CustomOperation("OpenChanged")>] member inline _.OpenChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callback<System.Boolean>("OpenChanged", fn)
    /// Raised when the Open property changed.
    [<CustomOperation("OpenChanged")>] member inline _.OpenChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callbackTask<System.Boolean>("OpenChanged", fn)
    /// Draw the menu below the component clicked (true) or
    /// using the mouse coordinates (false).
    [<CustomOperation("Anchored")>] member inline _.Anchored ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("Anchored" => x)

type FluentMenuItemBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentComponentBaseBuilder<'FunBlazorGeneric>()
    /// Gets or sets the menu item label.
    [<CustomOperation("Label")>] member inline _.Label ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Label" => x)
    /// Gets or sets if the element is disabled.
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("Disabled" => x)
    /// The expanded state of the element.
    [<CustomOperation("Expanded")>] member inline _.Expanded ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("Expanded" => x)
    /// The role of the element.
    [<CustomOperation("Role")>] member inline _.Role ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<Microsoft.Fast.Components.FluentUI.MenuItemRole>) = render ==> ("Role" => x)
    /// Gets or sets if the element is checked.
    [<CustomOperation("Checked")>] member inline _.Checked ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("Checked" => x)
    /// List of sub-menu items.
    [<CustomOperation("MenuItems")>] member inline _.MenuItems ([<InlineIfLambda>] render: AttrRenderFragment, fragment) = render ==> html.renderFragment("MenuItems", fragment)
    /// List of sub-menu items.
    [<CustomOperation("MenuItems")>] member inline _.MenuItems ([<InlineIfLambda>] render: AttrRenderFragment, fragments) = render ==> html.renderFragment("MenuItems", fragment { yield! fragments })
    /// List of sub-menu items.
    [<CustomOperation("MenuItems")>] member inline _.MenuItems ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("MenuItems", html.text x)
    /// List of sub-menu items.
    [<CustomOperation("MenuItems")>] member inline _.MenuItems ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("MenuItems", html.text x)
    /// List of sub-menu items.
    [<CustomOperation("MenuItems")>] member inline _.MenuItems ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("MenuItems", html.text x)
    /// Event raised when the user click on this item.
    [<CustomOperation("OnClick")>] member inline _.OnClick ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callback("OnClick", fn)
    /// Event raised when the user click on this item.
    [<CustomOperation("OnClick")>] member inline _.OnClick ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callbackTask("OnClick", fn)

type FluentMessageBarBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentComponentBaseBuilder<'FunBlazorGeneric>()
    /// The type of message bar. Default is MessageType.MessageBar. See MessageType for more details.
    [<CustomOperation("Type")>] member inline _.Type ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.Fast.Components.FluentUI.MessageType) = render ==> ("Type" => x)
    /// The actual message instance shown in the message bar.
    [<CustomOperation("Content")>] member inline _.Content ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.Fast.Components.FluentUI.Message) = render ==> ("Content" => x)
    /// Intent of the message bar. Default is MessageIntent.Info. See MessageIntent for more details.
    [<CustomOperation("Intent")>] member inline _.Intent ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<Microsoft.Fast.Components.FluentUI.MessageIntent>) = render ==> ("Intent" => x)
    /// Icon to show in the message bar based on the intent of the message. See Icon for more details.
    [<CustomOperation("Icon")>] member inline _.Icon ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.Fast.Components.FluentUI.Icon) = render ==> ("Icon" => x)
    /// Visibility of the message bar. Default is true.
    [<CustomOperation("Visible")>] member inline _.Visible ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("Visible" => x)
    /// Most important info to be shown in the message bar.
    [<CustomOperation("Title")>] member inline _.Title ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Title" => x)
    /// Time on which the message was created. Default is DateTime.Now. Onlu used when MessageType is Notification.
    [<CustomOperation("Timestamp")>] member inline _.Timestamp ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.DateTime>) = render ==> ("Timestamp" => x)
    /// The color of the icon. Only applied when intent is MessageBarIntent.Custom
    /// Default is Color.Accent
    [<CustomOperation("IconColor")>] member inline _.IconColor ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<Microsoft.Fast.Components.FluentUI.Color>) = render ==> ("IconColor" => x)

type FluentMessageBarContainerBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentComponentBaseBuilder<'FunBlazorGeneric>()
    /// Display only messages for this section.
    [<CustomOperation("Section")>] member inline _.Section ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Section" => x)
    /// Displays messages as a single line (with the message only)
    /// or as a card (with the detailed message).
    [<CustomOperation("Type")>] member inline _.Type ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.Fast.Components.FluentUI.MessageType) = render ==> ("Type" => x)
    /// Maximum number of messages displayed. Rest is stored in memory to be displayed when an shown message is closed.
    /// Default value is 5
    /// Set a value equal to or less than zero, to display all messages for this Section (or all categories if not set).
    [<CustomOperation("MaxMessageCount")>] member inline _.MaxMessageCount ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Int32>) = render ==> ("MaxMessageCount" => x)
    /// Display the newest messages on top (true) or on bottom (false).
    [<CustomOperation("NewestOnTop")>] member inline _.NewestOnTop ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("NewestOnTop" => x)
    /// Clear all (shown and stored) messages when the user navigates to a new page.
    [<CustomOperation("ClearAfterNavigation")>] member inline _.ClearAfterNavigation ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("ClearAfterNavigation" => x)

type FluentNavMenuTreeBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentComponentBaseBuilder<'FunBlazorGeneric>()
    /// Gets or sets the content to be rendered for the expander icon
    /// when the menu is collapsible.  The default icon will be used if
    /// this is not specified.
    [<CustomOperation("ExpanderContent")>] member inline _.ExpanderContent ([<InlineIfLambda>] render: AttrRenderFragment, fragment) = render ==> html.renderFragment("ExpanderContent", fragment)
    /// Gets or sets the content to be rendered for the expander icon
    /// when the menu is collapsible.  The default icon will be used if
    /// this is not specified.
    [<CustomOperation("ExpanderContent")>] member inline _.ExpanderContent ([<InlineIfLambda>] render: AttrRenderFragment, fragments) = render ==> html.renderFragment("ExpanderContent", fragment { yield! fragments })
    /// Gets or sets the content to be rendered for the expander icon
    /// when the menu is collapsible.  The default icon will be used if
    /// this is not specified.
    [<CustomOperation("ExpanderContent")>] member inline _.ExpanderContent ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("ExpanderContent", html.text x)
    /// Gets or sets the content to be rendered for the expander icon
    /// when the menu is collapsible.  The default icon will be used if
    /// this is not specified.
    [<CustomOperation("ExpanderContent")>] member inline _.ExpanderContent ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("ExpanderContent", html.text x)
    /// Gets or sets the content to be rendered for the expander icon
    /// when the menu is collapsible.  The default icon will be used if
    /// this is not specified.
    [<CustomOperation("ExpanderContent")>] member inline _.ExpanderContent ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("ExpanderContent", html.text x)
    /// Gets or sets the title of the navigation menu
    /// Default to "Navigation menu"
    [<CustomOperation("Title")>] member inline _.Title ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Title" => x)
    /// Gets or sets the width of the menu (in pixels).
    [<CustomOperation("Width")>] member inline _.Width ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Int32>) = render ==> ("Width" => x)
    /// Gets or sets whether or not the menu can be collapsed.
    [<CustomOperation("Collapsible")>] member inline _.Collapsible ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("Collapsible" => x)
    /// Returns true if the implementing component
    /// is expanded, and false if collapsed.
    [<CustomOperation("Expanded")>] member inline _.Expanded ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("Expanded" => x)
    /// Returns true if the implementing component
    /// is expanded, and false if collapsed.
    [<CustomOperation("Expanded'")>] member inline _.Expanded' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.Boolean * (System.Boolean -> unit)) = render ==> html.bind("Expanded", valueFn)
    /// Event callback for when the Expanded property changes.
    [<CustomOperation("ExpandedChanged")>] member inline _.ExpandedChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callback<System.Boolean>("ExpandedChanged", fn)
    /// Event callback for when the Expanded property changes.
    [<CustomOperation("ExpandedChanged")>] member inline _.ExpandedChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callbackTask<System.Boolean>("ExpandedChanged", fn)
    /// Called when the user attempts to execute the default action of a menu item.
    [<CustomOperation("OnAction")>] member inline _.OnAction ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callback<Microsoft.Fast.Components.FluentUI.NavMenuActionArgs>("OnAction", fn)
    /// Called when the user attempts to execute the default action of a menu item.
    [<CustomOperation("OnAction")>] member inline _.OnAction ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callbackTask<Microsoft.Fast.Components.FluentUI.NavMenuActionArgs>("OnAction", fn)
    /// If set to true then the tree will
    /// expand when it is created.
    [<CustomOperation("InitiallyExpanded")>] member inline _.InitiallyExpanded ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("InitiallyExpanded" => x)
    /// If true, the menu will re-navigate to the current page when the user clicks on the currently selected menu item.
    [<CustomOperation("ReNavigate")>] member inline _.ReNavigate ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("ReNavigate" => x)

type FluentNavMenuBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentComponentBaseBuilder<'FunBlazorGeneric>()
    /// Gets or sets the content to be rendered for the collapse icon
    /// when the menu is collapsible. The default icon will be used if
    /// this is not specified.
    [<CustomOperation("ExpanderContent")>] member inline _.ExpanderContent ([<InlineIfLambda>] render: AttrRenderFragment, fragment) = render ==> html.renderFragment("ExpanderContent", fragment)
    /// Gets or sets the content to be rendered for the collapse icon
    /// when the menu is collapsible. The default icon will be used if
    /// this is not specified.
    [<CustomOperation("ExpanderContent")>] member inline _.ExpanderContent ([<InlineIfLambda>] render: AttrRenderFragment, fragments) = render ==> html.renderFragment("ExpanderContent", fragment { yield! fragments })
    /// Gets or sets the content to be rendered for the collapse icon
    /// when the menu is collapsible. The default icon will be used if
    /// this is not specified.
    [<CustomOperation("ExpanderContent")>] member inline _.ExpanderContent ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("ExpanderContent", html.text x)
    /// Gets or sets the content to be rendered for the collapse icon
    /// when the menu is collapsible. The default icon will be used if
    /// this is not specified.
    [<CustomOperation("ExpanderContent")>] member inline _.ExpanderContent ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("ExpanderContent", html.text x)
    /// Gets or sets the content to be rendered for the collapse icon
    /// when the menu is collapsible. The default icon will be used if
    /// this is not specified.
    [<CustomOperation("ExpanderContent")>] member inline _.ExpanderContent ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("ExpanderContent", html.text x)
    /// Gets or sets the title of the navigation menu using the aria-label attribute.
    /// Defaults to "Navigation menu"
    [<CustomOperation("Title")>] member inline _.Title ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Title" => x)
    /// Gets or sets the width of the menu (in pixels).
    [<CustomOperation("Width")>] member inline _.Width ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Int32>) = render ==> ("Width" => x)
    /// Gets or sets whether or not the menu can be collapsed.
    [<CustomOperation("Collapsible")>] member inline _.Collapsible ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("Collapsible" => x)
    [<CustomOperation("Expanded")>] member inline _.Expanded ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("Expanded" => x)
    [<CustomOperation("Expanded'")>] member inline _.Expanded' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.Boolean * (System.Boolean -> unit)) = render ==> html.bind("Expanded", valueFn)
    /// Event callback for when the Expanded property changes.
    [<CustomOperation("ExpandedChanged")>] member inline _.ExpandedChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callback<System.Boolean>("ExpandedChanged", fn)
    /// Event callback for when the Expanded property changes.
    [<CustomOperation("ExpandedChanged")>] member inline _.ExpandedChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callbackTask<System.Boolean>("ExpandedChanged", fn)
    /// Adjust the vertical spacing between navlinks.
    ///             
    [<CustomOperation("Margin")>] member inline _.Margin ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Margin" => x)

type FluentOverflowBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentComponentBaseBuilder<'FunBlazorGeneric>()
    /// Template to display ItemsOverflow elements.
    [<CustomOperation("OverflowTemplate")>] member inline _.OverflowTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fn: Microsoft.Fast.Components.FluentUI.FluentOverflow -> NodeRenderFragment) = render ==> html.renderFragment("OverflowTemplate", fn)
    /// Template to display the More button.
    [<CustomOperation("MoreButtonTemplate")>] member inline _.MoreButtonTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fn: Microsoft.Fast.Components.FluentUI.FluentOverflow -> NodeRenderFragment) = render ==> html.renderFragment("MoreButtonTemplate", fn)
    /// Gets or sets the orientation of the items flow.
    [<CustomOperation("Orientation")>] member inline _.Orientation ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.Fast.Components.FluentUI.Orientation) = render ==> ("Orientation" => x)
    /// Event raised when a FluentOverflowItem enter or leave the current panel.
    [<CustomOperation("OnOverflowRaised")>] member inline _.OnOverflowRaised ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callback<System.Collections.Generic.IEnumerable<Microsoft.Fast.Components.FluentUI.FluentOverflowItem>>("OnOverflowRaised", fn)
    /// Event raised when a FluentOverflowItem enter or leave the current panel.
    [<CustomOperation("OnOverflowRaised")>] member inline _.OnOverflowRaised ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callbackTask<System.Collections.Generic.IEnumerable<Microsoft.Fast.Components.FluentUI.FluentOverflowItem>>("OnOverflowRaised", fn)

type FluentOverflowItemBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentComponentBaseBuilder<'FunBlazorGeneric>()


/// A component that provides a user interface for PaginationState.
type FluentPaginatorBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("CurrentPageIndexChanged")>] member inline _.CurrentPageIndexChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callback<System.Int32>("CurrentPageIndexChanged", fn)
    [<CustomOperation("CurrentPageIndexChanged")>] member inline _.CurrentPageIndexChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callbackTask<System.Int32>("CurrentPageIndexChanged", fn)
    /// Specifies the associated PaginationState. This parameter is required.
    [<CustomOperation("State")>] member inline _.State ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.Fast.Components.FluentUI.PaginationState) = render ==> ("State" => x)
    /// Optionally supplies a template for rendering the page count summary.
    [<CustomOperation("SummaryTemplate")>] member inline _.SummaryTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragment) = render ==> html.renderFragment("SummaryTemplate", fragment)
    /// Optionally supplies a template for rendering the page count summary.
    [<CustomOperation("SummaryTemplate")>] member inline _.SummaryTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragments) = render ==> html.renderFragment("SummaryTemplate", fragment { yield! fragments })
    /// Optionally supplies a template for rendering the page count summary.
    [<CustomOperation("SummaryTemplate")>] member inline _.SummaryTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("SummaryTemplate", html.text x)
    /// Optionally supplies a template for rendering the page count summary.
    [<CustomOperation("SummaryTemplate")>] member inline _.SummaryTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("SummaryTemplate", html.text x)
    /// Optionally supplies a template for rendering the page count summary.
    [<CustomOperation("SummaryTemplate")>] member inline _.SummaryTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("SummaryTemplate", html.text x)

type FluentPopoverBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentComponentBaseBuilder<'FunBlazorGeneric>()
    /// Gets or sets the id of the component the popover is positioned relative to
    [<CustomOperation("AnchorId")>] member inline _.AnchorId ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("AnchorId" => x)
    /// The default horizontal position of the region relative to the anchor element
    /// Default is unset. See 
    [<CustomOperation("HorizontalPosition")>] member inline _.HorizontalPosition ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<Microsoft.Fast.Components.FluentUI.HorizontalPosition>) = render ==> ("HorizontalPosition" => x)
    /// Gets or sets popover opened state
    [<CustomOperation("Open")>] member inline _.Open ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("Open" => x)
    /// Gets or sets popover opened state
    [<CustomOperation("Open'")>] member inline _.Open' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.Boolean * (System.Boolean -> unit)) = render ==> html.bind("Open", valueFn)
    /// Callback for when open state changes
    [<CustomOperation("OpenChanged")>] member inline _.OpenChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callback<System.Boolean>("OpenChanged", fn)
    /// Callback for when open state changes
    [<CustomOperation("OpenChanged")>] member inline _.OpenChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callbackTask<System.Boolean>("OpenChanged", fn)
    /// Contents of the header part of the popover
    [<CustomOperation("Header")>] member inline _.Header ([<InlineIfLambda>] render: AttrRenderFragment, fragment) = render ==> html.renderFragment("Header", fragment)
    /// Contents of the header part of the popover
    [<CustomOperation("Header")>] member inline _.Header ([<InlineIfLambda>] render: AttrRenderFragment, fragments) = render ==> html.renderFragment("Header", fragment { yield! fragments })
    /// Contents of the header part of the popover
    [<CustomOperation("Header")>] member inline _.Header ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("Header", html.text x)
    /// Contents of the header part of the popover
    [<CustomOperation("Header")>] member inline _.Header ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("Header", html.text x)
    /// Contents of the header part of the popover
    [<CustomOperation("Header")>] member inline _.Header ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("Header", html.text x)
    /// Contents of the body part of the popover
    [<CustomOperation("Body")>] member inline _.Body ([<InlineIfLambda>] render: AttrRenderFragment, fragment) = render ==> html.renderFragment("Body", fragment)
    /// Contents of the body part of the popover
    [<CustomOperation("Body")>] member inline _.Body ([<InlineIfLambda>] render: AttrRenderFragment, fragments) = render ==> html.renderFragment("Body", fragment { yield! fragments })
    /// Contents of the body part of the popover
    [<CustomOperation("Body")>] member inline _.Body ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("Body", html.text x)
    /// Contents of the body part of the popover
    [<CustomOperation("Body")>] member inline _.Body ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("Body", html.text x)
    /// Contents of the body part of the popover
    [<CustomOperation("Body")>] member inline _.Body ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("Body", html.text x)
    /// Contents of the footer part of the popover
    [<CustomOperation("Footer")>] member inline _.Footer ([<InlineIfLambda>] render: AttrRenderFragment, fragment) = render ==> html.renderFragment("Footer", fragment)
    /// Contents of the footer part of the popover
    [<CustomOperation("Footer")>] member inline _.Footer ([<InlineIfLambda>] render: AttrRenderFragment, fragments) = render ==> html.renderFragment("Footer", fragment { yield! fragments })
    /// Contents of the footer part of the popover
    [<CustomOperation("Footer")>] member inline _.Footer ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("Footer", html.text x)
    /// Contents of the footer part of the popover
    [<CustomOperation("Footer")>] member inline _.Footer ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("Footer", html.text x)
    /// Contents of the footer part of the popover
    [<CustomOperation("Footer")>] member inline _.Footer ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("Footer", html.text x)

/// A presence badge is a badge that displays a status indicator such as available, away, or busy.
type FluentPresenceBadgeBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentComponentBaseBuilder<'FunBlazorGeneric>()
    /// The title to show on hover the component.
    /// If not provided, the StatusTitle will be used.
    [<CustomOperation("Title")>] member inline _.Title ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Title" => x)
    /// The status to show. See PresenceStatus for options.
    [<CustomOperation("Status")>] member inline _.Status ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<Microsoft.Fast.Components.FluentUI.PresenceStatus>) = render ==> ("Status" => x)
    /// The title to show on hover the status. If not provided, the status will be used.
    [<CustomOperation("StatusTitle")>] member inline _.StatusTitle ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("StatusTitle" => x)
    /// Modifies the display to indicate that the user is out of office. 
    /// This can be combined with any status to display an out-of-office version of that status.
    [<CustomOperation("OutOfOffice")>] member inline _.OutOfOffice ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("OutOfOffice" => x)
    /// Gets or sets the Status size to use.
    /// Default is Small.
    [<CustomOperation("Size")>] member inline _.Size ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.Fast.Components.FluentUI.PresenceBadgeSize) = render ==> ("Size" => x)

type FluentProgressBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentComponentBaseBuilder<'FunBlazorGeneric>()
    /// Gets or sets the minimum value 
    [<CustomOperation("Min")>] member inline _.Min ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Int32>) = render ==> ("Min" => x)
    /// Gets or sets the maximum value 
    [<CustomOperation("Max")>] member inline _.Max ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Int32>) = render ==> ("Max" => x)
    /// Gets or sets the current value 
    [<CustomOperation("Value")>] member inline _.Value ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Int32>) = render ==> ("Value" => x)
    [<CustomOperation("Visible")>] member inline _.Visible ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("Visible" => x)
    /// Gets or sets if the progress element is paused
    [<CustomOperation("Paused")>] member inline _.Paused ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Boolean>) = render ==> ("Paused" => x)

type FluentProgressRingBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentComponentBaseBuilder<'FunBlazorGeneric>()
    /// Gets or sets the minimum value 
    [<CustomOperation("Min")>] member inline _.Min ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Int32>) = render ==> ("Min" => x)
    /// Gets or sets the maximum value 
    [<CustomOperation("Max")>] member inline _.Max ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Int32>) = render ==> ("Max" => x)
    /// Gets or sets the current value 
    [<CustomOperation("Value")>] member inline _.Value ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Int32>) = render ==> ("Value" => x)
    [<CustomOperation("Visible")>] member inline _.Visible ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("Visible" => x)
    /// Gets or sets if the progress element is paused
    [<CustomOperation("Paused")>] member inline _.Paused ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Boolean>) = render ==> ("Paused" => x)

type FluentRadioBuilder<'FunBlazorGeneric, 'TValue when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentComponentBaseBuilder<'FunBlazorGeneric>()
    /// Gets or sets if the element is readonly
    [<CustomOperation("ReadOnly")>] member inline _.ReadOnly ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("ReadOnly" => x)
    /// Text displayed just above the component
    [<CustomOperation("Label")>] member inline _.Label ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Label" => x)
    /// Content displayed just above the component
    [<CustomOperation("LabelTemplate")>] member inline _.LabelTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragment) = render ==> html.renderFragment("LabelTemplate", fragment)
    /// Content displayed just above the component
    [<CustomOperation("LabelTemplate")>] member inline _.LabelTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragments) = render ==> html.renderFragment("LabelTemplate", fragment { yield! fragments })
    /// Content displayed just above the component
    [<CustomOperation("LabelTemplate")>] member inline _.LabelTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("LabelTemplate", html.text x)
    /// Content displayed just above the component
    [<CustomOperation("LabelTemplate")>] member inline _.LabelTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("LabelTemplate", html.text x)
    /// Content displayed just above the component
    [<CustomOperation("LabelTemplate")>] member inline _.LabelTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("LabelTemplate", html.text x)
    /// Text used on aria-label attribute.
    [<CustomOperation("AriaLabel")>] member inline _.AriaLabel ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("AriaLabel" => x)
    /// The value of the element
    [<CustomOperation("Value")>] member inline _.Value ([<InlineIfLambda>] render: AttrRenderFragment, x: 'TValue) = render ==> ("Value" => x)
    /// Disables the form control, ensuring it doesn't participate in form submission
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("Disabled" => x)
    /// Gets or sets the name of the parent fluent radio group.
    [<CustomOperation("Name")>] member inline _.Name ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Name" => x)
    /// The element needs to have a value
    [<CustomOperation("Required")>] member inline _.Required ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("Required" => x)
    /// Gets or sets if the element is checked
    [<CustomOperation("Checked")>] member inline _.Checked ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Boolean>) = render ==> ("Checked" => x)

type FluentSkeletonBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentComponentBaseBuilder<'FunBlazorGeneric>()
    /// Indicates the Skeleton should have a filled style.
    [<CustomOperation("Fill")>] member inline _.Fill ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Fill" => x)
    /// Gets or sets the shape of the skeleton. See SkeletonShape
    [<CustomOperation("Shape")>] member inline _.Shape ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<Microsoft.Fast.Components.FluentUI.SkeletonShape>) = render ==> ("Shape" => x)
    /// Gets or sets the skeleton pattern
    [<CustomOperation("Pattern")>] member inline _.Pattern ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Pattern" => x)
    /// Gets or sets if the skeleton is shimmered
    [<CustomOperation("Shimmer")>] member inline _.Shimmer ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Boolean>) = render ==> ("Shimmer" => x)
    /// Gets or sets the width of the skeleton
    [<CustomOperation("Width")>] member inline _.Width ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Width" => x)
    /// Gets or sets the height of the skeleton
    [<CustomOperation("Height")>] member inline _.Height ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Height" => x)
    /// Gets or sets whether the skeleton is visible
    [<CustomOperation("Visible")>] member inline _.Visible ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("Visible" => x)

type FluentSliderLabelBuilder<'FunBlazorGeneric, 'TValue when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentComponentBaseBuilder<'FunBlazorGeneric>()
    /// Gets or sets the value for this slider position.
    [<CustomOperation("Position")>] member inline _.Position ([<InlineIfLambda>] render: AttrRenderFragment, x: 'TValue) = render ==> ("Position" => x)
    /// Gets or sets if marks are hidden
    [<CustomOperation("HideMark")>] member inline _.HideMark ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Boolean>) = render ==> ("HideMark" => x)
    /// The disabled state of the label. This is generally controlled by the parent .
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Boolean>) = render ==> ("Disabled" => x)

type FluentSplitterBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentComponentBaseBuilder<'FunBlazorGeneric>()
    /// Gets or sets the orientation.
    /// Default is horizontal (i.e a vertical splitter bar)
    [<CustomOperation("Orientation")>] member inline _.Orientation ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.Fast.Components.FluentUI.Orientation) = render ==> ("Orientation" => x)
    /// Content for the top/left panel
    [<CustomOperation("Panel1")>] member inline _.Panel1 ([<InlineIfLambda>] render: AttrRenderFragment, fragment) = render ==> html.renderFragment("Panel1", fragment)
    /// Content for the top/left panel
    [<CustomOperation("Panel1")>] member inline _.Panel1 ([<InlineIfLambda>] render: AttrRenderFragment, fragments) = render ==> html.renderFragment("Panel1", fragment { yield! fragments })
    /// Content for the top/left panel
    [<CustomOperation("Panel1")>] member inline _.Panel1 ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("Panel1", html.text x)
    /// Content for the top/left panel
    [<CustomOperation("Panel1")>] member inline _.Panel1 ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("Panel1", html.text x)
    /// Content for the top/left panel
    [<CustomOperation("Panel1")>] member inline _.Panel1 ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("Panel1", html.text x)
    /// Content for the bottom/right panel
    [<CustomOperation("Panel2")>] member inline _.Panel2 ([<InlineIfLambda>] render: AttrRenderFragment, fragment) = render ==> html.renderFragment("Panel2", fragment)
    /// Content for the bottom/right panel
    [<CustomOperation("Panel2")>] member inline _.Panel2 ([<InlineIfLambda>] render: AttrRenderFragment, fragments) = render ==> html.renderFragment("Panel2", fragment { yield! fragments })
    /// Content for the bottom/right panel
    [<CustomOperation("Panel2")>] member inline _.Panel2 ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("Panel2", html.text x)
    /// Content for the bottom/right panel
    [<CustomOperation("Panel2")>] member inline _.Panel2 ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("Panel2", html.text x)
    /// Content for the bottom/right panel
    [<CustomOperation("Panel2")>] member inline _.Panel2 ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("Panel2", html.text x)
    /// Size for the left/top panel. 
    /// Needs to be a valid css size like '50%' or '250px'
    [<CustomOperation("Panel1Size")>] member inline _.Panel1Size ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Panel1Size" => x)
    /// Size for the right/bottom panel. Needs to be a valid css size like '50%' or '250px'
    /// Uses grid-template-rows/columns with max-content to determine end width. 
    /// See mdn web docs for more information 
    [<CustomOperation("Panel2Size")>] member inline _.Panel2Size ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Panel2Size" => x)

type FluentStackBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentComponentBaseBuilder<'FunBlazorGeneric>()
    /// The horizontal alignment of the components in the stack. 
    [<CustomOperation("HorizontalAlignment")>] member inline _.HorizontalAlignment ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.Fast.Components.FluentUI.HorizontalAlignment) = render ==> ("HorizontalAlignment" => x)
    /// The vertical alignment of the components in the stack.
    [<CustomOperation("VerticalAlignment")>] member inline _.VerticalAlignment ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.Fast.Components.FluentUI.VerticalAlignment) = render ==> ("VerticalAlignment" => x)
    /// Gets or set the orientation of the stacked components. 
    [<CustomOperation("Orientation")>] member inline _.Orientation ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.Fast.Components.FluentUI.Orientation) = render ==> ("Orientation" => x)
    /// The width of the stack as a percentage string (default = 100%).
    [<CustomOperation("Width")>] member inline _.Width ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Width" => x)
    /// Gets or sets if the stack wraps.
    [<CustomOperation("Wrap")>] member inline _.Wrap ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("Wrap" => x)
    /// Gets or sets the gap between horizontally stacked components (in pixels).
    /// Default is 10 pixels.
    [<CustomOperation("HorizontalGap")>] member inline _.HorizontalGap ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Int32>) = render ==> ("HorizontalGap" => x)
    /// Gets or sets the gap between vertically stacked components (in pixels).
    /// Default is 10 pixels
    [<CustomOperation("VerticalGap")>] member inline _.VerticalGap ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Int32>) = render ==> ("VerticalGap" => x)

type FluentTabBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentComponentBaseBuilder<'FunBlazorGeneric>()
    /// When true, the control will be immutable by user interaction. See disabled HTML attribute for more information.
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("Disabled" => x)
    /// Gets or sets the label of the tab
    [<CustomOperation("Label")>] member inline _.Label ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Label" => x)
    /// Gets or sets the label of the tab
    [<CustomOperation("Label'")>] member inline _.Label' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.String * (System.String -> unit)) = render ==> html.bind("Label", valueFn)
    /// Callback to invoke when the label changes.
    [<CustomOperation("LabelChanged")>] member inline _.LabelChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callback<System.String>("LabelChanged", fn)
    /// Callback to invoke when the label changes.
    [<CustomOperation("LabelChanged")>] member inline _.LabelChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callbackTask<System.String>("LabelChanged", fn)
    /// User styles, applied to the Label Tab Item.
    [<CustomOperation("LabelClass")>] member inline _.LabelClass ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("LabelClass" => x)
    /// User styles, applied to the Label Tab Item.
    [<CustomOperation("LabelStyle")>] member inline _.LabelStyle ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("LabelStyle" => x)
    /// Customized content of the header.
    [<CustomOperation("Header")>] member inline _.Header ([<InlineIfLambda>] render: AttrRenderFragment, fragment) = render ==> html.renderFragment("Header", fragment)
    /// Customized content of the header.
    [<CustomOperation("Header")>] member inline _.Header ([<InlineIfLambda>] render: AttrRenderFragment, fragments) = render ==> html.renderFragment("Header", fragment { yield! fragments })
    /// Customized content of the header.
    [<CustomOperation("Header")>] member inline _.Header ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("Header", html.text x)
    /// Customized content of the header.
    [<CustomOperation("Header")>] member inline _.Header ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("Header", html.text x)
    /// Customized content of the header.
    [<CustomOperation("Header")>] member inline _.Header ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("Header", html.text x)
    /// Gets or sets the icon to display in front of the tab
    [<CustomOperation("Icon")>] member inline _.Icon ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.Fast.Components.FluentUI.Icon) = render ==> ("Icon" => x)
    /// True to let the user edit the Label property.
    [<CustomOperation("LabelEditable")>] member inline _.LabelEditable ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("LabelEditable" => x)
    /// Render the tab content only when the tab is selected.
    [<CustomOperation("DeferredLoading")>] member inline _.DeferredLoading ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("DeferredLoading" => x)
    /// Customized content of this tab panel.
    [<CustomOperation("Content")>] member inline _.Content ([<InlineIfLambda>] render: AttrRenderFragment, fragment) = render ==> html.renderFragment("Content", fragment)
    /// Customized content of this tab panel.
    [<CustomOperation("Content")>] member inline _.Content ([<InlineIfLambda>] render: AttrRenderFragment, fragments) = render ==> html.renderFragment("Content", fragment { yield! fragments })
    /// Customized content of this tab panel.
    [<CustomOperation("Content")>] member inline _.Content ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("Content", html.text x)
    /// Customized content of this tab panel.
    [<CustomOperation("Content")>] member inline _.Content ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("Content", html.text x)
    /// Customized content of this tab panel.
    [<CustomOperation("Content")>] member inline _.Content ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("Content", html.text x)

type FluentTabsBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentComponentBaseBuilder<'FunBlazorGeneric>()
    /// Gets or sets the tab's orentation. See Orientation
    [<CustomOperation("Orientation")>] member inline _.Orientation ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.Fast.Components.FluentUI.Orientation) = render ==> ("Orientation" => x)
    /// Raised when a tab is selected.
    [<CustomOperation("OnTabSelect")>] member inline _.OnTabSelect ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callback<Microsoft.Fast.Components.FluentUI.FluentTab>("OnTabSelect", fn)
    /// Raised when a tab is selected.
    [<CustomOperation("OnTabSelect")>] member inline _.OnTabSelect ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callbackTask<Microsoft.Fast.Components.FluentUI.FluentTab>("OnTabSelect", fn)
    /// Raised when a tab is closed.
    [<CustomOperation("OnTabClose")>] member inline _.OnTabClose ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callback<Microsoft.Fast.Components.FluentUI.FluentTab>("OnTabClose", fn)
    /// Raised when a tab is closed.
    [<CustomOperation("OnTabClose")>] member inline _.OnTabClose ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callbackTask<Microsoft.Fast.Components.FluentUI.FluentTab>("OnTabClose", fn)
    /// Determines if a dismiss icon is shown.
    /// When clicked the OnTabClose event is raised to remove this tab from the list.
    [<CustomOperation("ShowClose")>] member inline _.ShowClose ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("ShowClose" => x)
    /// Width of the tab items.
    [<CustomOperation("Size")>] member inline _.Size ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<Microsoft.Fast.Components.FluentUI.TabSize>) = render ==> ("Size" => x)
    /// Width of the tabs component.
    /// Needs to be a valid CSS value (e.g. 100px, 50%).
    [<CustomOperation("Width")>] member inline _.Width ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Width" => x)
    /// Height of the tabs component.
    /// Needs to be a valid CSS value (e.g. 100px, 50%).
    [<CustomOperation("Height")>] member inline _.Height ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Height" => x)
    [<CustomOperation("ActiveTabId")>] member inline _.ActiveTabId ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("ActiveTabId" => x)
    [<CustomOperation("ActiveTabId'")>] member inline _.ActiveTabId' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.String * (System.String -> unit)) = render ==> html.bind("ActiveTabId", valueFn)
    /// Gets or sets a callback when the bound value is changed.
    [<CustomOperation("ActiveTabIdChanged")>] member inline _.ActiveTabIdChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callback<System.String>("ActiveTabIdChanged", fn)
    /// Gets or sets a callback when the bound value is changed.
    [<CustomOperation("ActiveTabIdChanged")>] member inline _.ActiveTabIdChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callbackTask<System.String>("ActiveTabIdChanged", fn)
    /// Whether or not to show the active indicator 
    [<CustomOperation("ShowActiveIndicator")>] member inline _.ShowActiveIndicator ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("ShowActiveIndicator" => x)
    /// Gets or sets a callback when a tab is changed .
    [<CustomOperation("OnTabChange")>] member inline _.OnTabChange ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callback<Microsoft.Fast.Components.FluentUI.FluentTab>("OnTabChange", fn)
    /// Gets or sets a callback when a tab is changed .
    [<CustomOperation("OnTabChange")>] member inline _.OnTabChange ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callbackTask<Microsoft.Fast.Components.FluentUI.FluentTab>("OnTabChange", fn)

type FluentToastBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentComponentBaseBuilder<'FunBlazorGeneric>()
    /// The instance containing the programmatic API for the toast.
    [<CustomOperation("Instance")>] member inline _.Instance ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.Fast.Components.FluentUI.ToastInstance) = render ==> ("Instance" => x)

type FluentToolbarBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentComponentBaseBuilder<'FunBlazorGeneric>()
    /// Gets or sets the toolbar's orentation. See Orientation
    [<CustomOperation("Orientation")>] member inline _.Orientation ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<Microsoft.Fast.Components.FluentUI.Orientation>) = render ==> ("Orientation" => x)

type FluentTooltipBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentComponentBaseBuilder<'FunBlazorGeneric>()
    /// Use ITooltipService to create the tooltip, if this service was injected.
    /// If the ChildContent is dynamic, set this to false.
    /// Default, true.
    [<CustomOperation("UseTooltipService")>] member inline _.UseTooltipService ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("UseTooltipService" => x)
    /// Gets or sets if the tooltip is visible
    [<CustomOperation("Visible")>] member inline _.Visible ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("Visible" => x)
    /// Required. Gets or sets the control identifier associated with the tooltip.
    [<CustomOperation("Anchor")>] member inline _.Anchor ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Anchor" => x)
    /// Gets or sets the delay (in milliseconds). Default is 300.
    [<CustomOperation("Delay'")>] member inline _.Delay' ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Int32>) = render ==> ("Delay" => x)
    /// Gets or sets the tooltip's position. See TooltipPosition.
    /// Don't set this if you want the tooltip to use the best position.
    [<CustomOperation("Position")>] member inline _.Position ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<Microsoft.Fast.Components.FluentUI.TooltipPosition>) = render ==> ("Position" => x)
    /// Gets or sets the maximum width of tooltip panel.
    [<CustomOperation("MaxWidth")>] member inline _.MaxWidth ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("MaxWidth" => x)
    /// Controls when the tooltip updates its position, default is anchor which only updates when
    /// the anchor is resized.  auto will update on scroll/resize events.
    /// Corresponds to anchored-region auto-update-mode.
    [<CustomOperation("AutoUpdateMode")>] member inline _.AutoUpdateMode ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<Microsoft.Fast.Components.FluentUI.AutoUpdateMode>) = render ==> ("AutoUpdateMode" => x)
    /// Gets or sets whether the horizontal viewport is locked
    [<CustomOperation("HorizontalViewportLock")>] member inline _.HorizontalViewportLock ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("HorizontalViewportLock" => x)
    /// Gets or sets whether the vertical viewport is locked
    [<CustomOperation("VerticalViewportLock")>] member inline _.VerticalViewportLock ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("VerticalViewportLock" => x)
    /// Callback for when the tooltip is dismissed
    [<CustomOperation("OnDismissed")>] member inline _.OnDismissed ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callback<System.EventArgs>("OnDismissed", fn)
    /// Callback for when the tooltip is dismissed
    [<CustomOperation("OnDismissed")>] member inline _.OnDismissed ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callbackTask<System.EventArgs>("OnDismissed", fn)

type FluentTooltipProviderBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentComponentBaseBuilder<'FunBlazorGeneric>()


type FluentTreeItemBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentComponentBaseBuilder<'FunBlazorGeneric>()
    /// Gets or sets the text of the tree item
    [<CustomOperation("Text")>] member inline _.Text ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Text" => x)
    /// Returns true if the tree item is expanded,
    /// and false if collapsed.
    [<CustomOperation("Expanded")>] member inline _.Expanded ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("Expanded" => x)
    /// Returns true if the tree item is expanded,
    /// and false if collapsed.
    [<CustomOperation("Expanded'")>] member inline _.Expanded' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.Boolean * (System.Boolean -> unit)) = render ==> html.bind("Expanded", valueFn)
    /// Called whenever Expanded changes.
    [<CustomOperation("ExpandedChanged")>] member inline _.ExpandedChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callback<System.Boolean>("ExpandedChanged", fn)
    /// Called whenever Expanded changes.
    [<CustomOperation("ExpandedChanged")>] member inline _.ExpandedChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callbackTask<System.Boolean>("ExpandedChanged", fn)
    /// When true, the control will appear selected by user interaction.
    [<CustomOperation("Selected")>] member inline _.Selected ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("Selected" => x)
    /// When true, the control will appear selected by user interaction.
    [<CustomOperation("Selected'")>] member inline _.Selected' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.Boolean * (System.Boolean -> unit)) = render ==> html.bind("Selected", valueFn)
    /// Called whenever Selected changes.
    [<CustomOperation("SelectedChanged")>] member inline _.SelectedChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callback<System.Boolean>("SelectedChanged", fn)
    /// Called whenever Selected changes.
    [<CustomOperation("SelectedChanged")>] member inline _.SelectedChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callbackTask<System.Boolean>("SelectedChanged", fn)
    /// When true, the control will be immutable by user interaction. See disabled HTML attribute for more information.
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("Disabled" => x)
    /// If set to true then the tree item will
    /// be expanded when it is created.
    [<CustomOperation("InitiallyExpanded")>] member inline _.InitiallyExpanded ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("InitiallyExpanded" => x)
    /// If set to true then the tree item will
    /// be selected when it is created.
    [<CustomOperation("InitiallySelected")>] member inline _.InitiallySelected ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("InitiallySelected" => x)

type FluentTreeViewBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentComponentBaseBuilder<'FunBlazorGeneric>()
    /// Gets or sets whether the tree should render nodes under collapsed items
    /// Defaults to false
    [<CustomOperation("RenderCollapsedNodes")>] member inline _.RenderCollapsedNodes ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("RenderCollapsedNodes" => x)
    /// Gets or sets the currently selected tree item
    [<CustomOperation("CurrentSelected")>] member inline _.CurrentSelected ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.Fast.Components.FluentUI.FluentTreeItem) = render ==> ("CurrentSelected" => x)
    /// Gets or sets the currently selected tree item
    [<CustomOperation("CurrentSelected'")>] member inline _.CurrentSelected' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: Microsoft.Fast.Components.FluentUI.FluentTreeItem * (Microsoft.Fast.Components.FluentUI.FluentTreeItem -> unit)) = render ==> html.bind("CurrentSelected", valueFn)
    /// Called when CurrentSelected changes.
    [<CustomOperation("CurrentSelectedChanged")>] member inline _.CurrentSelectedChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callback<Microsoft.Fast.Components.FluentUI.FluentTreeItem>("CurrentSelectedChanged", fn)
    /// Called when CurrentSelected changes.
    [<CustomOperation("CurrentSelectedChanged")>] member inline _.CurrentSelectedChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callbackTask<Microsoft.Fast.Components.FluentUI.FluentTreeItem>("CurrentSelectedChanged", fn)
    /// Called whenever Selected changes on an
    /// item within the tree.
    [<CustomOperation("OnSelectedChange")>] member inline _.OnSelectedChange ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callback<Microsoft.Fast.Components.FluentUI.FluentTreeItem>("OnSelectedChange", fn)
    /// Called whenever Selected changes on an
    /// item within the tree.
    [<CustomOperation("OnSelectedChange")>] member inline _.OnSelectedChange ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callbackTask<Microsoft.Fast.Components.FluentUI.FluentTreeItem>("OnSelectedChange", fn)
    /// Called whenever Expanded changes on an
    /// item within the tree.
    [<CustomOperation("OnExpandedChange")>] member inline _.OnExpandedChange ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callback<Microsoft.Fast.Components.FluentUI.FluentTreeItem>("OnExpandedChange", fn)
    /// Called whenever Expanded changes on an
    /// item within the tree.
    [<CustomOperation("OnExpandedChange")>] member inline _.OnExpandedChange ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callbackTask<Microsoft.Fast.Components.FluentUI.FluentTreeItem>("OnExpandedChange", fn)

            
namespace rec Microsoft.Fast.Components.FluentUI.DslInternals

open FSharp.Data.Adaptive
open Fun.Blazor
open Fun.Blazor.Operators
open Microsoft.Fast.Components.FluentUI.DslInternals

/// Displays a list of validation messages from a cascaded EditContext.
type ValidationSummaryBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAndChildAttrBuilder<'FunBlazorGeneric>()
    /// Gets or sets the model to produce the list of validation messages for.
    /// When specified, this lists all errors that are associated with the model instance.
    [<CustomOperation("Model")>] member inline _.Model ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Object) = render ==> ("Model" => x)
    /// Gets or sets a collection of additional attributes that will be applied to the created ul element.
    [<CustomOperation("AdditionalAttributes")>] member inline _.AdditionalAttributes ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.IReadOnlyDictionary<System.String, System.Object>) = render ==> ("AdditionalAttributes" => x)

            
namespace rec Microsoft.Fast.Components.FluentUI.DslInternals

open FSharp.Data.Adaptive
open Fun.Blazor
open Fun.Blazor.Operators
open Microsoft.Fast.Components.FluentUI.DslInternals

type FluentValidationSummaryBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ValidationSummaryBuilder<'FunBlazorGeneric>()


/// An abstract base class for columns in a FluentDataGrid`1.
type ColumnBaseBuilder<'FunBlazorGeneric, 'TGridItem when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAndChildAttrBuilder<'FunBlazorGeneric>()
    /// Title text for the column. This is rendered automatically if HeaderCellItemTemplate is not used.
    [<CustomOperation("Title")>] member inline _.Title ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Title" => x)
    /// An optional CSS class name. If specified, this is included in the class attribute of header and grid cells
    /// for this column.
    [<CustomOperation("Classes")>] member inline _.Classes ([<InlineIfLambda>] render: AttrRenderFragment, x: string list) = render ==> html.classes x
    /// An optional CSS style specification. If specified, this is included in the style attribute of header and grid cells
    /// for this column.
    [<CustomOperation("Styles")>] member inline _.Styles ([<InlineIfLambda>] render: AttrRenderFragment, x: (string * string) list) = render ==> html.styles x
    /// If specified, controls the justification of header and grid cells for this column.
    [<CustomOperation("Align")>] member inline _.Align ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.Fast.Components.FluentUI.Align) = render ==> ("Align" => x)
    /// If true, generate a title and aria-label attribute for the cell contents
    [<CustomOperation("Tooltip")>] member inline _.Tooltip ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("Tooltip" => x)
    /// Defines the value to be used as the tooltip and aria-label in this column's cells
    [<CustomOperation("TooltipText")>] member inline _.TooltipText ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Linq.Expressions.Expression<System.Func<'TGridItem, System.String>>) = render ==> ("TooltipText" => x)
    /// An optional template for this column's header cell. If not specified, the default header template
    /// includes the Title along with any applicable sort indicators and options buttons.
    [<CustomOperation("HeaderCellItemTemplate")>] member inline _.HeaderCellItemTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fn: Microsoft.Fast.Components.FluentUI.ColumnBase<'TGridItem> -> NodeRenderFragment) = render ==> html.renderFragment("HeaderCellItemTemplate", fn)
    /// If specified, indicates that this column has this associated options UI. A button to display this
    /// UI will be included in the header cell by default.
    ///             
    /// If HeaderCellItemTemplate is used, it is left up to that template to render any relevant
    /// "show options" UI and invoke the grid's ShowColumnOptionsAsync).
    [<CustomOperation("ColumnOptions")>] member inline _.ColumnOptions ([<InlineIfLambda>] render: AttrRenderFragment, fragment) = render ==> html.renderFragment("ColumnOptions", fragment)
    /// If specified, indicates that this column has this associated options UI. A button to display this
    /// UI will be included in the header cell by default.
    ///             
    /// If HeaderCellItemTemplate is used, it is left up to that template to render any relevant
    /// "show options" UI and invoke the grid's ShowColumnOptionsAsync).
    [<CustomOperation("ColumnOptions")>] member inline _.ColumnOptions ([<InlineIfLambda>] render: AttrRenderFragment, fragments) = render ==> html.renderFragment("ColumnOptions", fragment { yield! fragments })
    /// If specified, indicates that this column has this associated options UI. A button to display this
    /// UI will be included in the header cell by default.
    ///             
    /// If HeaderCellItemTemplate is used, it is left up to that template to render any relevant
    /// "show options" UI and invoke the grid's ShowColumnOptionsAsync).
    [<CustomOperation("ColumnOptions")>] member inline _.ColumnOptions ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("ColumnOptions", html.text x)
    /// If specified, indicates that this column has this associated options UI. A button to display this
    /// UI will be included in the header cell by default.
    ///             
    /// If HeaderCellItemTemplate is used, it is left up to that template to render any relevant
    /// "show options" UI and invoke the grid's ShowColumnOptionsAsync).
    [<CustomOperation("ColumnOptions")>] member inline _.ColumnOptions ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("ColumnOptions", html.text x)
    /// If specified, indicates that this column has this associated options UI. A button to display this
    /// UI will be included in the header cell by default.
    ///             
    /// If HeaderCellItemTemplate is used, it is left up to that template to render any relevant
    /// "show options" UI and invoke the grid's ShowColumnOptionsAsync).
    [<CustomOperation("ColumnOptions")>] member inline _.ColumnOptions ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("ColumnOptions", html.text x)
    /// Indicates whether the data should be sortable by this column.
    ///             
    /// The default value may vary according to the column type (for example, a TemplateColumn`1
    /// is sortable by default if any SortBy parameter is specified).
    [<CustomOperation("Sortable")>] member inline _.Sortable ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Boolean>) = render ==> ("Sortable" => x)
    /// Indicates which direction to sort in
    /// if IsDefaultSortColumn is true.
    [<CustomOperation("InitialSortDirection")>] member inline _.InitialSortDirection ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.Fast.Components.FluentUI.SortDirection) = render ==> ("InitialSortDirection" => x)
    /// Indicates whether this column should be sorted by default.
    [<CustomOperation("IsDefaultSortColumn")>] member inline _.IsDefaultSortColumn ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("IsDefaultSortColumn" => x)
    /// If specified, virtualized grids will use this template to render cells whose data has not yet been loaded.
    [<CustomOperation("PlaceholderTemplate")>] member inline _.PlaceholderTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fn: Microsoft.AspNetCore.Components.Web.Virtualization.PlaceholderContext -> NodeRenderFragment) = render ==> html.renderFragment("PlaceholderTemplate", fn)

/// Represents a FluentDataGrid`1 column whose cells display a single value.
type PropertyColumnBuilder<'FunBlazorGeneric, 'TGridItem, 'TProp when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ColumnBaseBuilder<'FunBlazorGeneric, 'TGridItem>()
    /// Defines the value to be displayed in this column's cells.
    [<CustomOperation("Property")>] member inline _.Property ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Linq.Expressions.Expression<System.Func<'TGridItem, 'TProp>>) = render ==> ("Property" => x)
    /// Optionally specifies a format string for the value.
    ///             
    /// Using this requires the  type to implement IFormattable.
    [<CustomOperation("Format")>] member inline _.Format ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Format" => x)
    /// Optionally specifies how to compare values in this column when sorting.
    /// 
    /// Using this requires the  type to implement IComparable`1.
    [<CustomOperation("Comparer")>] member inline _.Comparer ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.IComparer<'TProp>) = render ==> ("Comparer" => x)

/// Represents a FluentDataGrid`1 column whose cells render a supplied template.
type TemplateColumnBuilder<'FunBlazorGeneric, 'TGridItem when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ColumnBaseBuilder<'FunBlazorGeneric, 'TGridItem>()
    /// Specifies the content to be rendered for each row in the table.
    [<CustomOperation("ChildContent")>] member inline _.ChildContent ([<InlineIfLambda>] render: AttrRenderFragment, fn: 'TGridItem -> NodeRenderFragment) = render ==> html.renderFragment("ChildContent", fn)
    [<CustomOperation("SortBy")>] member inline _.SortBy ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.Fast.Components.FluentUI.GridSort<'TGridItem>) = render ==> ("SortBy" => x)

type FluentSplashScreenBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAndChildAttrBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Content")>] member inline _.Content ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.Fast.Components.FluentUI.SplashScreenContent) = render ==> ("Content" => x)

type MessageBoxBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAndChildAttrBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Content")>] member inline _.Content ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.Fast.Components.FluentUI.MessageBoxContent) = render ==> ("Content" => x)

type FluentDialogProviderBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAndChildAttrBuilder<'FunBlazorGeneric>()


type FluentInputLabelBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAndChildAttrBuilder<'FunBlazorGeneric>()
    /// Gets or sets the HTML label `for` attribute.
    /// See https://developer.mozilla.org/en-US/docs/Web/HTML/Attributes/for
    [<CustomOperation("ForId")>] member inline _.ForId ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("ForId" => x)
    /// Gets or sets the text to be displayed as a label, just above the component.
    [<CustomOperation("Label")>] member inline _.Label ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Label" => x)
    /// Gets or sets the text to be used as the `aria-label` attribute of the input.
    /// If not set, the Label will be used.
    [<CustomOperation("AriaLabel")>] member inline _.AriaLabel ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("AriaLabel" => x)
    /// Gets or sets a collection of additional attributes that will be applied to the created element.
    [<CustomOperation("AdditionalAttributes")>] member inline _.AdditionalAttributes ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.IReadOnlyDictionary<System.String, System.Object>) = render ==> ("AdditionalAttributes" => x)

type FluentOverlayBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAndChildAttrBuilder<'FunBlazorGeneric>()
    /// Gets or sets if the overlay is visible.
    [<CustomOperation("Visible")>] member inline _.Visible ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("Visible" => x)
    /// Gets or sets if the overlay is visible.
    [<CustomOperation("Visible'")>] member inline _.Visible' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.Boolean * (System.Boolean -> unit)) = render ==> html.bind("Visible", valueFn)
    /// Callback for when overlay visisbility changes
    [<CustomOperation("VisibleChanged")>] member inline _.VisibleChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callback<System.Boolean>("VisibleChanged", fn)
    /// Callback for when overlay visisbility changes
    [<CustomOperation("VisibleChanged")>] member inline _.VisibleChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callbackTask<System.Boolean>("VisibleChanged", fn)
    /// Callback for when the overlay is closed.
    [<CustomOperation("OnClose")>] member inline _.OnClose ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>("OnClose", fn)
    /// Callback for when the overlay is closed.
    [<CustomOperation("OnClose")>] member inline _.OnClose ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callbackTask<Microsoft.AspNetCore.Components.Web.MouseEventArgs>("OnClose", fn)
    /// Gets or set if the overlay is transparent.
    [<CustomOperation("Transparent")>] member inline _.Transparent ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("Transparent" => x)
    /// Gets or sets the opacity of the overlay.
    [<CustomOperation("Opacity")>] member inline _.Opacity ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Double>) = render ==> ("Opacity" => x)
    /// Gets or sets the alignment of the content to a Align value.
    /// Defaults to Align.Center.
    [<CustomOperation("Alignment")>] member inline _.Alignment ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.Fast.Components.FluentUI.Align) = render ==> ("Alignment" => x)
    /// Gets or sets the justification of the content to a JustifyContent value.
    /// Defaults to JustifyContent.Center.
    [<CustomOperation("Justification")>] member inline _.Justification ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.Fast.Components.FluentUI.JustifyContent) = render ==> ("Justification" => x)
    /// Gets or sets if the overlay is shown full screen or bound to the containing element.
    [<CustomOperation("FullScreen")>] member inline _.FullScreen ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("FullScreen" => x)
    [<CustomOperation("Dismissable")>] member inline _.Dismissable ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("Dismissable" => x)
    /// Gets or sets background color. 
    /// Needs to be formatted as an HTML hex color string (#rrggbb or #rgb)
    /// Default is '#ffffff'
    [<CustomOperation("BackgroundColor")>] member inline _.BackgroundColor ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("BackgroundColor" => x)
    [<CustomOperation("PreventScroll")>] member inline _.PreventScroll ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("PreventScroll" => x)

type FluentSpacerBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAndChildAttrBuilder<'FunBlazorGeneric>()
    /// Gets or sets the width of the spacer (in pixels)
    [<CustomOperation("Width")>] member inline _.Width ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Int32>) = render ==> ("Width" => x)

type CommunicationToastBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAndChildAttrBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Content")>] member inline _.Content ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.Fast.Components.FluentUI.CommunicationToastContent) = render ==> ("Content" => x)

type ProgressToastBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAndChildAttrBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Content")>] member inline _.Content ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.Fast.Components.FluentUI.ProgressToastContent) = render ==> ("Content" => x)

type FluentToastContainerBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAndChildAttrBuilder<'FunBlazorGeneric>()
    /// Gets or sets the position on screen where the toasts are shown. See ToastPosition
    /// Default is ToastPosition.TopRight
    [<CustomOperation("Position")>] member inline _.Position ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.Fast.Components.FluentUI.ToastPosition) = render ==> ("Position" => x)
    /// Gets or sets the number of seconds a toast remains visible. Default is 7 seconds.
    [<CustomOperation("Timeout")>] member inline _.Timeout ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("Timeout" => x)
    /// Gets or sets the maximum number of toasts that can be shown at once. Default is 4.
    [<CustomOperation("MaxToastCount")>] member inline _.MaxToastCount ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("MaxToastCount" => x)
    /// Gets or sets whether to remove toasts when the user navigates to a new page. Default is true.
    [<CustomOperation("RemoveToastsOnNavigation")>] member inline _.RemoveToastsOnNavigation ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("RemoveToastsOnNavigation" => x)
    /// Gets or sets whether to show a close button on a toast. Default is true.
    [<CustomOperation("ShowCloseButton")>] member inline _.ShowCloseButton ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("ShowCloseButton" => x)

type ConfirmationToastBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAndChildAttrBuilder<'FunBlazorGeneric>()


type _ImportsBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAndChildAttrBuilder<'FunBlazorGeneric>()


            
namespace rec Microsoft.Fast.Components.FluentUI.DslInternals.DesignTokens

open FSharp.Data.Adaptive
open Fun.Blazor
open Fun.Blazor.Operators
open Microsoft.Fast.Components.FluentUI.DslInternals

type DesignTokenBuilder<'FunBlazorGeneric, 'T when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAndChildAttrBuilder<'FunBlazorGeneric>()
    /// Gets or sets the value of the design token
    [<CustomOperation("Value")>] member inline _.Value ([<InlineIfLambda>] render: AttrRenderFragment, x: 'T) = render ==> ("Value" => x)
    /// Gets or sets the content to apply this design token on
    [<CustomOperation("ChildContent")>] member inline _.ChildContent ([<InlineIfLambda>] render: AttrRenderFragment, fn: Microsoft.Fast.Components.FluentUI.DesignTokens.Reference -> NodeRenderFragment) = render ==> html.renderFragment("ChildContent", fn)

/// The Direction design token
type DirectionBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, System.String>()


/// The DisabledOpacity design token
type DisabledOpacityBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, System.Nullable<System.Single>>()


/// The BaseHeightMultiplier design token
type BaseHeightMultiplierBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, System.Nullable<System.Single>>()


/// The BaseHorizontalSpacingMultiplier design token
type BaseHorizontalSpacingMultiplierBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, System.Nullable<System.Single>>()


/// The Density design token
type DensityBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, System.Nullable<System.Int32>>()


/// The DesignUnit design token
type DesignUnitBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, System.Nullable<System.Int32>>()


/// The ControlCornerRadius design token
type ControlCornerRadiusBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, System.Nullable<System.Int32>>()


/// The LayerCornerRadius design token
type LayerCornerRadiusBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, System.Nullable<System.Int32>>()


/// The StrokeWidth design token
type StrokeWidthBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, System.Nullable<System.Single>>()


/// The FocusStrokeWidth design token
type FocusStrokeWidthBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, System.Nullable<System.Single>>()


/// The BodyFont design token
type BodyFontBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, System.String>()


/// The TypeRampBaseFontSize design token
type TypeRampBaseFontSizeBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, System.String>()


/// The TypeRampBaseLineHeight design token
type TypeRampBaseLineHeightBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, System.String>()


/// The TypeRampMinus1FontSize design token
type TypeRampMinus1FontSizeBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, System.String>()


/// The TypeRampMinus1LineHeight design token
type TypeRampMinus1LineHeightBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, System.String>()


/// The TypeRampMinus2FontSize design token
type TypeRampMinus2FontSizeBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, System.String>()


/// The TypeRampMinus2LineHeight design token
type TypeRampMinus2LineHeightBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, System.String>()


/// The TypeRampPlus1FontSize design token
type TypeRampPlus1FontSizeBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, System.String>()


/// The TypeRampPlus1LineHeight design token
type TypeRampPlus1LineHeightBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, System.String>()


/// The TypeRampPlus2FontSize design token
type TypeRampPlus2FontSizeBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, System.String>()


/// The TypeRampPlus2LineHeight design token
type TypeRampPlus2LineHeightBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, System.String>()


/// The TypeRampPlus3FontSize design token
type TypeRampPlus3FontSizeBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, System.String>()


/// The TypeRampPlus3LineHeight design token
type TypeRampPlus3LineHeightBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, System.String>()


/// The TypeRampPlus4FontSize design token
type TypeRampPlus4FontSizeBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, System.String>()


/// The TypeRampPlus4LineHeight design token
type TypeRampPlus4LineHeightBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, System.String>()


/// The TypeRampPlus5FontSize design token
type TypeRampPlus5FontSizeBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, System.String>()


/// The TypeRampPlus5LineHeight design token
type TypeRampPlus5LineHeightBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, System.String>()


/// The TypeRampPlus6FontSize design token
type TypeRampPlus6FontSizeBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, System.String>()


/// The TypeRampPlus6LineHeight design token
type TypeRampPlus6LineHeightBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, System.String>()


/// The BaseLayerLuminance design token
type BaseLayerLuminanceBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, System.Nullable<System.Single>>()


/// The AccentFillRestDelta design token
type AccentFillRestDeltaBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, System.Nullable<System.Int32>>()


/// The AccentFillHoverDelta design token
type AccentFillHoverDeltaBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, System.Nullable<System.Int32>>()


/// The AccentFillActiveDelta design token
type AccentFillActiveDeltaBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, System.Nullable<System.Int32>>()


/// The AccentFillFocusDelta design token
type AccentFillFocusDeltaBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, System.Nullable<System.Int32>>()


/// The AccentForegroundRestDelta design token
type AccentForegroundRestDeltaBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, System.Nullable<System.Int32>>()


/// The AccentForegroundHoverDelta design token
type AccentForegroundHoverDeltaBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, System.Nullable<System.Int32>>()


/// The AccentForegroundActiveDelta design token
type AccentForegroundActiveDeltaBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, System.Nullable<System.Int32>>()


/// The AccentForegroundFocusDelta design token
type AccentForegroundFocusDeltaBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, System.Nullable<System.Int32>>()


/// The NeutralFillRestDelta design token
type NeutralFillRestDeltaBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, System.Nullable<System.Int32>>()


/// The NeutralFillHoverDelta design token
type NeutralFillHoverDeltaBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, System.Nullable<System.Int32>>()


/// The NeutralFillActiveDelta design token
type NeutralFillActiveDeltaBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, System.Nullable<System.Int32>>()


/// The NeutralFillFocusDelta design token
type NeutralFillFocusDeltaBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, System.Nullable<System.Int32>>()


/// The NeutralFillInputRestDelta design token
type NeutralFillInputRestDeltaBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, System.Nullable<System.Int32>>()


/// The NeutralFillInputHoverDelta design token
type NeutralFillInputHoverDeltaBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, System.Nullable<System.Int32>>()


/// The NeutralFillInputActiveDelta design token
type NeutralFillInputActiveDeltaBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, System.Nullable<System.Int32>>()


/// The NeutralFillInputFocusDelta design token
type NeutralFillInputFocusDeltaBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, System.Nullable<System.Int32>>()


/// The NeutralFillInputAltRestDelta design token
type NeutralFillInputAltRestDeltaBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, System.Nullable<System.Int32>>()


/// The NeutralFillInputAltHoverDelta design token
type NeutralFillInputAltHoverDeltaBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, System.Nullable<System.Int32>>()


/// The NeutralFillInputAltActiveDelta design token
type NeutralFillInputAltActiveDeltaBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, System.Nullable<System.Int32>>()


/// The NeutralFillInputAltFocusDelta design token
type NeutralFillInputAltFocusDeltaBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, System.Nullable<System.Int32>>()


/// The NeutralFillLayerRestDelta design token
type NeutralFillLayerRestDeltaBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, System.Nullable<System.Int32>>()


/// The NeutralFillLayerHoverDelta design token
type NeutralFillLayerHoverDeltaBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, System.Nullable<System.Int32>>()


/// The NeutralFillLayerActiveDelta design token
type NeutralFillLayerActiveDeltaBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, System.Nullable<System.Int32>>()


/// The NeutralFillLayerAltRestDelta design token
type NeutralFillLayerAltRestDeltaBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, System.Nullable<System.Int32>>()


/// The NeutralFillSecondaryRestDelta design token
type NeutralFillSecondaryRestDeltaBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, System.Nullable<System.Int32>>()


/// The NeutralFillSecondaryHoverDelta design token
type NeutralFillSecondaryHoverDeltaBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, System.Nullable<System.Int32>>()


/// The NeutralFillSecondaryActiveDelta design token
type NeutralFillSecondaryActiveDeltaBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, System.Nullable<System.Int32>>()


/// The NeutralFillSecondaryFocusDelta design token
type NeutralFillSecondaryFocusDeltaBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, System.Nullable<System.Int32>>()


/// The NeutralFillStealthRestDelta design token
type NeutralFillStealthRestDeltaBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, System.Nullable<System.Int32>>()


/// The NeutralFillStealthHoverDelta design token
type NeutralFillStealthHoverDeltaBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, System.Nullable<System.Int32>>()


/// The NeutralFillStealthActiveDelta design token
type NeutralFillStealthActiveDeltaBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, System.Nullable<System.Int32>>()


/// The NeutralFillStealthFocusDelta design token
type NeutralFillStealthFocusDeltaBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, System.Nullable<System.Int32>>()


/// The NeutralFillStrongRestDelta design token
type NeutralFillStrongRestDeltaBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, System.Nullable<System.Int32>>()


/// The NeutralFillStrongHoverDelta design token
type NeutralFillStrongHoverDeltaBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, System.Nullable<System.Int32>>()


/// The NeutralFillStrongActiveDelta design token
type NeutralFillStrongActiveDeltaBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, System.Nullable<System.Int32>>()


/// The NeutralFillStrongFocusDelta design token
type NeutralFillStrongFocusDeltaBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, System.Nullable<System.Int32>>()


/// The NeutralStrokeRestDelta design token
type NeutralStrokeRestDeltaBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, System.Nullable<System.Int32>>()


/// The NeutralStrokeHoverDelta design token
type NeutralStrokeHoverDeltaBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, System.Nullable<System.Int32>>()


/// The NeutralStrokeActiveDelta design token
type NeutralStrokeActiveDeltaBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, System.Nullable<System.Int32>>()


/// The NeutralStrokeFocusDelta design token
type NeutralStrokeFocusDeltaBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, System.Nullable<System.Int32>>()


/// The NeutralStrokeControlRestDelta design token
type NeutralStrokeControlRestDeltaBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, System.Nullable<System.Int32>>()


/// The NeutralStrokeControlHoverDelta design token
type NeutralStrokeControlHoverDeltaBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, System.Nullable<System.Int32>>()


/// The NeutralStrokeControlActiveDelta design token
type NeutralStrokeControlActiveDeltaBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, System.Nullable<System.Int32>>()


/// The NeutralStrokeControlFocusDelta design token
type NeutralStrokeControlFocusDeltaBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, System.Nullable<System.Int32>>()


/// The NeutralStrokeDividerRestDelta design token
type NeutralStrokeDividerRestDeltaBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, System.Nullable<System.Int32>>()


/// The NeutralStrokeLayerRestDelta design token
type NeutralStrokeLayerRestDeltaBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, System.Nullable<System.Int32>>()


/// The NeutralStrokeLayerHoverDelta design token
type NeutralStrokeLayerHoverDeltaBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, System.Nullable<System.Int32>>()


/// The NeutralStrokeLayerActiveDelta design token
type NeutralStrokeLayerActiveDeltaBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, System.Nullable<System.Int32>>()


/// The NeutralStrokeStrongHoverDelta design token
type NeutralStrokeStrongHoverDeltaBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, System.Nullable<System.Int32>>()


/// The NeutralStrokeStrongActiveDelta design token
type NeutralStrokeStrongActiveDeltaBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, System.Nullable<System.Int32>>()


/// The NeutralStrokeStrongFocusDelta design token
type NeutralStrokeStrongFocusDeltaBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, System.Nullable<System.Int32>>()


/// The NeutralBaseColor design token
type NeutralBaseColorBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, Microsoft.Fast.Components.FluentUI.DesignTokens.Swatch>()


/// The AccentBaseColor design token
type AccentBaseColorBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, Microsoft.Fast.Components.FluentUI.DesignTokens.Swatch>()


/// The NeutralLayerCardContainer design token
type NeutralLayerCardContainerBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, Microsoft.Fast.Components.FluentUI.DesignTokens.Swatch>()


/// The NeutralLayerFloating design token
type NeutralLayerFloatingBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, Microsoft.Fast.Components.FluentUI.DesignTokens.Swatch>()


/// The NeutralLayer1 design token
type NeutralLayer1Builder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, Microsoft.Fast.Components.FluentUI.DesignTokens.Swatch>()


/// The NeutralLayer2 design token
type NeutralLayer2Builder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, Microsoft.Fast.Components.FluentUI.DesignTokens.Swatch>()


/// The NeutralLayer3 design token
type NeutralLayer3Builder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, Microsoft.Fast.Components.FluentUI.DesignTokens.Swatch>()


/// The NeutralLayer4 design token
type NeutralLayer4Builder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, Microsoft.Fast.Components.FluentUI.DesignTokens.Swatch>()


/// The FillColor design token
type FillColorBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, Microsoft.Fast.Components.FluentUI.DesignTokens.Swatch>()


/// The AccentFillRest design token
type AccentFillRestBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, Microsoft.Fast.Components.FluentUI.DesignTokens.Swatch>()


/// The AccentFillHover design token
type AccentFillHoverBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, Microsoft.Fast.Components.FluentUI.DesignTokens.Swatch>()


/// The AccentFillActive design token
type AccentFillActiveBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, Microsoft.Fast.Components.FluentUI.DesignTokens.Swatch>()


/// The AccentFillFocus design token
type AccentFillFocusBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, Microsoft.Fast.Components.FluentUI.DesignTokens.Swatch>()


/// The ForegroundOnAccentRest design token
type ForegroundOnAccentRestBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, Microsoft.Fast.Components.FluentUI.DesignTokens.Swatch>()


/// The ForegroundOnAccentHover design token
type ForegroundOnAccentHoverBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, Microsoft.Fast.Components.FluentUI.DesignTokens.Swatch>()


/// The ForegroundOnAccentActive design token
type ForegroundOnAccentActiveBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, Microsoft.Fast.Components.FluentUI.DesignTokens.Swatch>()


/// The ForegroundOnAccentFocus design token
type ForegroundOnAccentFocusBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, Microsoft.Fast.Components.FluentUI.DesignTokens.Swatch>()


/// The AccentForegroundRest design token
type AccentForegroundRestBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, Microsoft.Fast.Components.FluentUI.DesignTokens.Swatch>()


/// The AccentForegroundHover design token
type AccentForegroundHoverBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, Microsoft.Fast.Components.FluentUI.DesignTokens.Swatch>()


/// The AccentForegroundActive design token
type AccentForegroundActiveBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, Microsoft.Fast.Components.FluentUI.DesignTokens.Swatch>()


/// The AccentForegroundFocus design token
type AccentForegroundFocusBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, Microsoft.Fast.Components.FluentUI.DesignTokens.Swatch>()


/// The AccentStrokeControlRest design token
type AccentStrokeControlRestBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, Microsoft.Fast.Components.FluentUI.DesignTokens.Swatch>()


/// The AccentStrokeControlHover design token
type AccentStrokeControlHoverBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, Microsoft.Fast.Components.FluentUI.DesignTokens.Swatch>()


/// The AccentStrokeControlActive design token
type AccentStrokeControlActiveBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, Microsoft.Fast.Components.FluentUI.DesignTokens.Swatch>()


/// The AccentStrokeControlFocus design token
type AccentStrokeControlFocusBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, Microsoft.Fast.Components.FluentUI.DesignTokens.Swatch>()


/// The NeutralFillRest design token
type NeutralFillRestBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, Microsoft.Fast.Components.FluentUI.DesignTokens.Swatch>()


/// The NeutralFillHover design token
type NeutralFillHoverBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, Microsoft.Fast.Components.FluentUI.DesignTokens.Swatch>()


/// The NeutralFillActive design token
type NeutralFillActiveBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, Microsoft.Fast.Components.FluentUI.DesignTokens.Swatch>()


/// The NeutralFillFocus design token
type NeutralFillFocusBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, Microsoft.Fast.Components.FluentUI.DesignTokens.Swatch>()


/// The NeutralFillInputRest design token
type NeutralFillInputRestBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, Microsoft.Fast.Components.FluentUI.DesignTokens.Swatch>()


/// The NeutralFillInputHover design token
type NeutralFillInputHoverBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, Microsoft.Fast.Components.FluentUI.DesignTokens.Swatch>()


/// The NeutralFillInputActive design token
type NeutralFillInputActiveBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, Microsoft.Fast.Components.FluentUI.DesignTokens.Swatch>()


/// The NeutralFillInputFocus design token
type NeutralFillInputFocusBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, Microsoft.Fast.Components.FluentUI.DesignTokens.Swatch>()


/// The NeutralFillInputAltRest design token
type NeutralFillInputAltRestBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, Microsoft.Fast.Components.FluentUI.DesignTokens.Swatch>()


/// The NeutralFillInputAltHover design token
type NeutralFillInputAltHoverBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, Microsoft.Fast.Components.FluentUI.DesignTokens.Swatch>()


/// The NeutralFillInputAltActive design token
type NeutralFillInputAltActiveBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, Microsoft.Fast.Components.FluentUI.DesignTokens.Swatch>()


/// The NeutralFillInputAltFocus design token
type NeutralFillInputAltFocusBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, Microsoft.Fast.Components.FluentUI.DesignTokens.Swatch>()


/// The NeutralFillLayerRest design token
type NeutralFillLayerRestBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, Microsoft.Fast.Components.FluentUI.DesignTokens.Swatch>()


/// The NeutralFillLayerHover design token
type NeutralFillLayerHoverBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, Microsoft.Fast.Components.FluentUI.DesignTokens.Swatch>()


/// The NeutralFillLayerActive design token
type NeutralFillLayerActiveBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, Microsoft.Fast.Components.FluentUI.DesignTokens.Swatch>()


/// The NeutralFillLayerAltRest design token
type NeutralFillLayerAltRestBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, Microsoft.Fast.Components.FluentUI.DesignTokens.Swatch>()


/// The NeutralFillSecondaryRest design token
type NeutralFillSecondaryRestBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, Microsoft.Fast.Components.FluentUI.DesignTokens.Swatch>()


/// The NeutralFillSecondaryHover design token
type NeutralFillSecondaryHoverBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, Microsoft.Fast.Components.FluentUI.DesignTokens.Swatch>()


/// The NeutralFillSecondaryActive design token
type NeutralFillSecondaryActiveBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, Microsoft.Fast.Components.FluentUI.DesignTokens.Swatch>()


/// The NeutralFillSecondaryFocus design token
type NeutralFillSecondaryFocusBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, Microsoft.Fast.Components.FluentUI.DesignTokens.Swatch>()


/// The NeutralFillStealthRest design token
type NeutralFillStealthRestBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, Microsoft.Fast.Components.FluentUI.DesignTokens.Swatch>()


/// The NeutralFillStealthHover design token
type NeutralFillStealthHoverBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, Microsoft.Fast.Components.FluentUI.DesignTokens.Swatch>()


/// The NeutralFillStealthActive design token
type NeutralFillStealthActiveBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, Microsoft.Fast.Components.FluentUI.DesignTokens.Swatch>()


/// The NeutralFillStealthFocus design token
type NeutralFillStealthFocusBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, Microsoft.Fast.Components.FluentUI.DesignTokens.Swatch>()


/// The NeutralFillStrongRest design token
type NeutralFillStrongRestBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, Microsoft.Fast.Components.FluentUI.DesignTokens.Swatch>()


/// The NeutralFillStrongHover design token
type NeutralFillStrongHoverBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, Microsoft.Fast.Components.FluentUI.DesignTokens.Swatch>()


/// The NeutralFillStrongActive design token
type NeutralFillStrongActiveBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, Microsoft.Fast.Components.FluentUI.DesignTokens.Swatch>()


/// The NeutralFillStrongFocus design token
type NeutralFillStrongFocusBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, Microsoft.Fast.Components.FluentUI.DesignTokens.Swatch>()


/// The NeutralForegroundRest design token
type NeutralForegroundRestBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, Microsoft.Fast.Components.FluentUI.DesignTokens.Swatch>()


/// The NeutralForegroundHover design token
type NeutralForegroundHoverBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, Microsoft.Fast.Components.FluentUI.DesignTokens.Swatch>()


/// The NeutralForegroundActive design token
type NeutralForegroundActiveBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, Microsoft.Fast.Components.FluentUI.DesignTokens.Swatch>()


/// The NeutralForegroundFocus design token
type NeutralForegroundFocusBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, Microsoft.Fast.Components.FluentUI.DesignTokens.Swatch>()


/// The NeutralForegroundHint design token
type NeutralForegroundHintBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, Microsoft.Fast.Components.FluentUI.DesignTokens.Swatch>()


/// The NeutralStrokeRest design token
type NeutralStrokeRestBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, Microsoft.Fast.Components.FluentUI.DesignTokens.Swatch>()


/// The NeutralStrokeHover design token
type NeutralStrokeHoverBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, Microsoft.Fast.Components.FluentUI.DesignTokens.Swatch>()


/// The NeutralStrokeActive design token
type NeutralStrokeActiveBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, Microsoft.Fast.Components.FluentUI.DesignTokens.Swatch>()


/// The NeutralStrokeFocus design token
type NeutralStrokeFocusBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, Microsoft.Fast.Components.FluentUI.DesignTokens.Swatch>()


/// The NeutralStrokeControlRest design token
type NeutralStrokeControlRestBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, Microsoft.Fast.Components.FluentUI.DesignTokens.Swatch>()


/// The NeutralStrokeControlHover design token
type NeutralStrokeControlHoverBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, Microsoft.Fast.Components.FluentUI.DesignTokens.Swatch>()


/// The NeutralStrokeControlActive design token
type NeutralStrokeControlActiveBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, Microsoft.Fast.Components.FluentUI.DesignTokens.Swatch>()


/// The NeutralStrokeControlFocus design token
type NeutralStrokeControlFocusBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, Microsoft.Fast.Components.FluentUI.DesignTokens.Swatch>()


/// The NeutralStrokeDividerRest design token
type NeutralStrokeDividerRestBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, Microsoft.Fast.Components.FluentUI.DesignTokens.Swatch>()


/// The NeutralStrokeInputRest design token
type NeutralStrokeInputRestBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, Microsoft.Fast.Components.FluentUI.DesignTokens.Swatch>()


/// The NeutralStrokeInputHover design token
type NeutralStrokeInputHoverBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, Microsoft.Fast.Components.FluentUI.DesignTokens.Swatch>()


/// The NeutralStrokeInputActive design token
type NeutralStrokeInputActiveBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, Microsoft.Fast.Components.FluentUI.DesignTokens.Swatch>()


/// The NeutralStrokeInputFocus design token
type NeutralStrokeInputFocusBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, Microsoft.Fast.Components.FluentUI.DesignTokens.Swatch>()


/// The NeutralStrokeLayerRest design token
type NeutralStrokeLayerRestBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, Microsoft.Fast.Components.FluentUI.DesignTokens.Swatch>()


/// The NeutralStrokeLayerHover design token
type NeutralStrokeLayerHoverBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, Microsoft.Fast.Components.FluentUI.DesignTokens.Swatch>()


/// The NeutralStrokeLayerActive design token
type NeutralStrokeLayerActiveBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, Microsoft.Fast.Components.FluentUI.DesignTokens.Swatch>()


/// The NeutralStrokeStrongRest design token
type NeutralStrokeStrongRestBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, Microsoft.Fast.Components.FluentUI.DesignTokens.Swatch>()


/// The NeutralStrokeStrongHover design token
type NeutralStrokeStrongHoverBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, Microsoft.Fast.Components.FluentUI.DesignTokens.Swatch>()


/// The NeutralStrokeStrongActive design token
type NeutralStrokeStrongActiveBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, Microsoft.Fast.Components.FluentUI.DesignTokens.Swatch>()


/// The NeutralStrokeStrongFocus design token
type NeutralStrokeStrongFocusBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, Microsoft.Fast.Components.FluentUI.DesignTokens.Swatch>()


/// The FocusStrokeOuter design token
type FocusStrokeOuterBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, Microsoft.Fast.Components.FluentUI.DesignTokens.Swatch>()


/// The FocusStrokeInner design token
type FocusStrokeInnerBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, Microsoft.Fast.Components.FluentUI.DesignTokens.Swatch>()


            
namespace rec Microsoft.Fast.Components.FluentUI.DslInternals.DataGrid.Infrastructure

open FSharp.Data.Adaptive
open Fun.Blazor
open Fun.Blazor.Operators
open Microsoft.Fast.Components.FluentUI.DslInternals

/// For internal use only. Do not use.
type DeferBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAndChildAttrBuilder<'FunBlazorGeneric>()


            

// =======================================================================================================================

namespace Microsoft.Fast.Components.FluentUI

[<AutoOpen>]
module DslCE =
  
    open System.Diagnostics.CodeAnalysis
    open Microsoft.Fast.Components.FluentUI.DslInternals

    type FluentComponentBase' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.FluentComponentBase>)>] () = inherit FluentComponentBaseBuilder<Microsoft.Fast.Components.FluentUI.FluentComponentBase>()
    type FluentCalendarBase' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.FluentCalendarBase>)>] () = inherit FluentCalendarBaseBuilder<Microsoft.Fast.Components.FluentUI.FluentCalendarBase>()

    /// Fluent Calendar based on
    /// https://github.com/microsoft/fluentui/blob/master/packages/web-components/src/calendar/.
    type FluentCalendar' 
        /// Fluent Calendar based on
        /// https://github.com/microsoft/fluentui/blob/master/packages/web-components/src/calendar/.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.FluentCalendar>)>] () = inherit FluentCalendarBuilder<Microsoft.Fast.Components.FluentUI.FluentCalendar>()
    type FluentDatePicker' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.FluentDatePicker>)>] () = inherit FluentDatePickerBuilder<Microsoft.Fast.Components.FluentUI.FluentDatePicker>()

    /// Base class for FluentNavMenuGroup and FluentNavMenuItemBase.
    type FluentNavMenuItemBase' 
        /// Base class for FluentNavMenuGroup and FluentNavMenuItemBase.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.FluentNavMenuItemBase>)>] () = inherit FluentNavMenuItemBaseBuilder<Microsoft.Fast.Components.FluentUI.FluentNavMenuItemBase>()
    type FluentNavMenuGroup' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.FluentNavMenuGroup>)>] () = inherit FluentNavMenuGroupBuilder<Microsoft.Fast.Components.FluentUI.FluentNavMenuGroup>()
    type FluentNavMenuLink' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.FluentNavMenuLink>)>] () = inherit FluentNavMenuLinkBuilder<Microsoft.Fast.Components.FluentUI.FluentNavMenuLink>()

    /// Base class for FluentNavGroup and FluentNavLink.
    type FluentNavBase' 
        /// Base class for FluentNavGroup and FluentNavLink.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.FluentNavBase>)>] () = inherit FluentNavBaseBuilder<Microsoft.Fast.Components.FluentUI.FluentNavBase>()
    type FluentNavGroup' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.FluentNavGroup>)>] () = inherit FluentNavGroupBuilder<Microsoft.Fast.Components.FluentUI.FluentNavGroup>()
    type FluentNavLink' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.FluentNavLink>)>] () = inherit FluentNavLinkBuilder<Microsoft.Fast.Components.FluentUI.FluentNavLink>()
    type FluentAccordion' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.FluentAccordion>)>] () = inherit FluentAccordionBuilder<Microsoft.Fast.Components.FluentUI.FluentAccordion>()
    type FluentAccordionItem' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.FluentAccordionItem>)>] () = inherit FluentAccordionItemBuilder<Microsoft.Fast.Components.FluentUI.FluentAccordionItem>()
    type FluentAnchoredRegion' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.FluentAnchoredRegion>)>] () = inherit FluentAnchoredRegionBuilder<Microsoft.Fast.Components.FluentUI.FluentAnchoredRegion>()
    type FluentAnchor' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.FluentAnchor>)>] () = inherit FluentAnchorBuilder<Microsoft.Fast.Components.FluentUI.FluentAnchor>()
    type FluentBadge' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.FluentBadge>)>] () = inherit FluentBadgeBuilder<Microsoft.Fast.Components.FluentUI.FluentBadge>()

    /// A base class for fluent ui form input components. This base class automatically
    /// integrates with an EditContext, which must be supplied
    /// as a cascading parameter.
    type FluentInputBase'<'TValue> 
        /// A base class for fluent ui form input components. This base class automatically
        /// integrates with an EditContext, which must be supplied
        /// as a cascading parameter.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.FluentInputBase<_>>)>] () = inherit FluentInputBaseBuilder<Microsoft.Fast.Components.FluentUI.FluentInputBase<'TValue>, 'TValue>()
    type FluentCheckbox' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.FluentCheckbox>)>] () = inherit FluentCheckboxBuilder<Microsoft.Fast.Components.FluentUI.FluentCheckbox>()
    type FluentTimePicker' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.FluentTimePicker>)>] () = inherit FluentTimePickerBuilder<Microsoft.Fast.Components.FluentUI.FluentTimePicker>()
    type FluentNumberField'<'TValue when 'TValue : (new : unit -> 'TValue)> [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.FluentNumberField<_>>)>] () = inherit FluentNumberFieldBuilder<Microsoft.Fast.Components.FluentUI.FluentNumberField<'TValue>, 'TValue>()

    /// Groups child FluentRadio`1 components. 
    type FluentRadioGroup'<'TValue> 
        /// Groups child FluentRadio`1 components. 
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.FluentRadioGroup<_>>)>] () = inherit FluentRadioGroupBuilder<Microsoft.Fast.Components.FluentUI.FluentRadioGroup<'TValue>, 'TValue>()
    type FluentSearch' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.FluentSearch>)>] () = inherit FluentSearchBuilder<Microsoft.Fast.Components.FluentUI.FluentSearch>()
    type FluentSliderInt' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.FluentSlider<int>>)>] () = inherit FluentSliderBuilder<Microsoft.Fast.Components.FluentUI.FluentSlider<int>, int>()
    type FluentSliderFloat' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.FluentSlider<float>>)>] () = inherit FluentSliderBuilder<Microsoft.Fast.Components.FluentUI.FluentSlider<float>, float>()
    type FluentSwitch' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.FluentSwitch>)>] () = inherit FluentSwitchBuilder<Microsoft.Fast.Components.FluentUI.FluentSwitch>()
    type FluentTextArea' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.FluentTextArea>)>] () = inherit FluentTextAreaBuilder<Microsoft.Fast.Components.FluentUI.FluentTextArea>()
    type FluentTextField' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.FluentTextField>)>] () = inherit FluentTextFieldBuilder<Microsoft.Fast.Components.FluentUI.FluentTextField>()
    type FluentBodyContent' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.FluentBodyContent>)>] () = inherit FluentBodyContentBuilder<Microsoft.Fast.Components.FluentUI.FluentBodyContent>()
    type FluentBreadcrumb' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.FluentBreadcrumb>)>] () = inherit FluentBreadcrumbBuilder<Microsoft.Fast.Components.FluentUI.FluentBreadcrumb>()
    type FluentBreadcrumbItem' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.FluentBreadcrumbItem>)>] () = inherit FluentBreadcrumbItemBuilder<Microsoft.Fast.Components.FluentUI.FluentBreadcrumbItem>()
    type FluentButton' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.FluentButton>)>] () = inherit FluentButtonBuilder<Microsoft.Fast.Components.FluentUI.FluentButton>()
    type FluentCard' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.FluentCard>)>] () = inherit FluentCardBuilder<Microsoft.Fast.Components.FluentUI.FluentCard>()
    type FluentCodeEditor' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.FluentCodeEditor>)>] () = inherit FluentCodeEditorBuilder<Microsoft.Fast.Components.FluentUI.FluentCodeEditor>()
    type FluentCollapsibleRegion' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.FluentCollapsibleRegion>)>] () = inherit FluentCollapsibleRegionBuilder<Microsoft.Fast.Components.FluentUI.FluentCollapsibleRegion>()
    type FluentCounterBadge' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.FluentCounterBadge>)>] () = inherit FluentCounterBadgeBuilder<Microsoft.Fast.Components.FluentUI.FluentCounterBadge>()

    /// A component that displays a grid.
    type FluentDataGrid'<'TGridItem> 
        /// A component that displays a grid.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.FluentDataGrid<_>>)>] () = inherit FluentDataGridBuilder<Microsoft.Fast.Components.FluentUI.FluentDataGrid<'TGridItem>, 'TGridItem>()
    type FluentDataGridCell'<'TGridItem> [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.FluentDataGridCell<_>>)>] () = inherit FluentDataGridCellBuilder<Microsoft.Fast.Components.FluentUI.FluentDataGridCell<'TGridItem>, 'TGridItem>()
    type FluentDataGridRow'<'TGridItem> [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.FluentDataGridRow<_>>)>] () = inherit FluentDataGridRowBuilder<Microsoft.Fast.Components.FluentUI.FluentDataGridRow<'TGridItem>, 'TGridItem>()
    type FluentDesignSystemProvider' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.FluentDesignSystemProvider>)>] () = inherit FluentDesignSystemProviderBuilder<Microsoft.Fast.Components.FluentUI.FluentDesignSystemProvider>()
    type FluentDialog' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.FluentDialog>)>] () = inherit FluentDialogBuilder<Microsoft.Fast.Components.FluentUI.FluentDialog>()
    type FluentDialogBody' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.FluentDialogBody>)>] () = inherit FluentDialogBodyBuilder<Microsoft.Fast.Components.FluentUI.FluentDialogBody>()
    type FluentDialogFooter' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.FluentDialogFooter>)>] () = inherit FluentDialogFooterBuilder<Microsoft.Fast.Components.FluentUI.FluentDialogFooter>()
    type FluentDialogHeader' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.FluentDialogHeader>)>] () = inherit FluentDialogHeaderBuilder<Microsoft.Fast.Components.FluentUI.FluentDialogHeader>()
    type FluentDivider' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.FluentDivider>)>] () = inherit FluentDividerBuilder<Microsoft.Fast.Components.FluentUI.FluentDivider>()
    type FluentDragContainer'<'TItem> [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.FluentDragContainer<_>>)>] () = inherit FluentDragContainerBuilder<Microsoft.Fast.Components.FluentUI.FluentDragContainer<'TItem>, 'TItem>()
    type FluentDropZone'<'TItem> [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.FluentDropZone<_>>)>] () = inherit FluentDropZoneBuilder<Microsoft.Fast.Components.FluentUI.FluentDropZone<'TItem>, 'TItem>()

    /// FluentEmoji is a component that renders an emoji from the Microsoft FluentUI emoji set.
    type FluentEmoji'<'Emoji when 'Emoji : (new : unit -> 'Emoji) and 'Emoji :> Microsoft.Fast.Components.FluentUI.Emoji> 
        /// FluentEmoji is a component that renders an emoji from the Microsoft FluentUI emoji set.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.FluentEmoji<_>>)>] () = inherit FluentEmojiBuilder<Microsoft.Fast.Components.FluentUI.FluentEmoji<'Emoji>, 'Emoji>()
    type FluentFlipper' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.FluentFlipper>)>] () = inherit FluentFlipperBuilder<Microsoft.Fast.Components.FluentUI.FluentFlipper>()
    type FluentFooter' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.FluentFooter>)>] () = inherit FluentFooterBuilder<Microsoft.Fast.Components.FluentUI.FluentFooter>()

    /// The grid component helps keeping layout consistent across various screen resolutions and sizes.
    /// PowerGrid comes with a 12-point grid system and contains 5 types of breakpoints
    /// that are used for specific screen sizes.
    type FluentGrid' 
        /// The grid component helps keeping layout consistent across various screen resolutions and sizes.
        /// PowerGrid comes with a 12-point grid system and contains 5 types of breakpoints
        /// that are used for specific screen sizes.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.FluentGrid>)>] () = inherit FluentGridBuilder<Microsoft.Fast.Components.FluentUI.FluentGrid>()
    type FluentGridItem' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.FluentGridItem>)>] () = inherit FluentGridItemBuilder<Microsoft.Fast.Components.FluentUI.FluentGridItem>()
    type FluentHeader' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.FluentHeader>)>] () = inherit FluentHeaderBuilder<Microsoft.Fast.Components.FluentUI.FluentHeader>()
    type FluentHighlighter' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.FluentHighlighter>)>] () = inherit FluentHighlighterBuilder<Microsoft.Fast.Components.FluentUI.FluentHighlighter>()
    type FluentHorizontalScroll' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.FluentHorizontalScroll>)>] () = inherit FluentHorizontalScrollBuilder<Microsoft.Fast.Components.FluentUI.FluentHorizontalScroll>()

    /// FluentIcon is a component that renders an icon from the Fluent System icon set.
    type FluentIcon'<'Icon when 'Icon : (new : unit -> 'Icon) and 'Icon :> Microsoft.Fast.Components.FluentUI.Icon> 
        /// FluentIcon is a component that renders an icon from the Fluent System icon set.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.FluentIcon<_>>)>] () = inherit FluentIconBuilder<Microsoft.Fast.Components.FluentUI.FluentIcon<'Icon>, 'Icon>()
    type FluentInputFile' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.FluentInputFile>)>] () = inherit FluentInputFileBuilder<Microsoft.Fast.Components.FluentUI.FluentInputFile>()
    type FluentLabel' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.FluentLabel>)>] () = inherit FluentLabelBuilder<Microsoft.Fast.Components.FluentUI.FluentLabel>()
    type FluentLayout' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.FluentLayout>)>] () = inherit FluentLayoutBuilder<Microsoft.Fast.Components.FluentUI.FluentLayout>()
    type FluentOption'<'TOption> [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.FluentOption<_>>)>] () = inherit FluentOptionBuilder<Microsoft.Fast.Components.FluentUI.FluentOption<'TOption>, 'TOption>()

    /// People picker option component.
    type FluentPersona' 
        /// People picker option component.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.FluentPersona>)>] () = inherit FluentPersonaBuilder<Microsoft.Fast.Components.FluentUI.FluentPersona>()

    /// Component that provides a list of options.
    type ListComponentBase'<'TOption> 
        /// Component that provides a list of options.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.ListComponentBase<_>>)>] () = inherit ListComponentBaseBuilder<Microsoft.Fast.Components.FluentUI.ListComponentBase<'TOption>, 'TOption>()
    type FluentAutocomplete'<'TOption> [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.FluentAutocomplete<_>>)>] () = inherit FluentAutocompleteBuilder<Microsoft.Fast.Components.FluentUI.FluentAutocomplete<'TOption>, 'TOption>()
    type FluentCombobox'<'TOption> [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.FluentCombobox<_>>)>] () = inherit FluentComboboxBuilder<Microsoft.Fast.Components.FluentUI.FluentCombobox<'TOption>, 'TOption>()
    type FluentListbox'<'TOption> [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.FluentListbox<_>>)>] () = inherit FluentListboxBuilder<Microsoft.Fast.Components.FluentUI.FluentListbox<'TOption>, 'TOption>()
    type FluentSelect'<'TOption> [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.FluentSelect<_>>)>] () = inherit FluentSelectBuilder<Microsoft.Fast.Components.FluentUI.FluentSelect<'TOption>, 'TOption>()
    type FluentMainLayout' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.FluentMainLayout>)>] () = inherit FluentMainLayoutBuilder<Microsoft.Fast.Components.FluentUI.FluentMainLayout>()
    type FluentMain' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.FluentMain>)>] () = inherit FluentMainBuilder<Microsoft.Fast.Components.FluentUI.FluentMain>()
    type FluentMenuButton' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.FluentMenuButton>)>] () = inherit FluentMenuButtonBuilder<Microsoft.Fast.Components.FluentUI.FluentMenuButton>()
    type FluentMenu' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.FluentMenu>)>] () = inherit FluentMenuBuilder<Microsoft.Fast.Components.FluentUI.FluentMenu>()
    type FluentMenuItem' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.FluentMenuItem>)>] () = inherit FluentMenuItemBuilder<Microsoft.Fast.Components.FluentUI.FluentMenuItem>()
    type FluentMessageBar' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.FluentMessageBar>)>] () = inherit FluentMessageBarBuilder<Microsoft.Fast.Components.FluentUI.FluentMessageBar>()
    type FluentMessageBarContainer' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.FluentMessageBarContainer>)>] () = inherit FluentMessageBarContainerBuilder<Microsoft.Fast.Components.FluentUI.FluentMessageBarContainer>()
    type FluentNavMenuTree' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.FluentNavMenuTree>)>] () = inherit FluentNavMenuTreeBuilder<Microsoft.Fast.Components.FluentUI.FluentNavMenuTree>()
    type FluentNavMenu' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.FluentNavMenu>)>] () = inherit FluentNavMenuBuilder<Microsoft.Fast.Components.FluentUI.FluentNavMenu>()
    type FluentOverflow' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.FluentOverflow>)>] () = inherit FluentOverflowBuilder<Microsoft.Fast.Components.FluentUI.FluentOverflow>()
    type FluentOverflowItem' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.FluentOverflowItem>)>] () = inherit FluentOverflowItemBuilder<Microsoft.Fast.Components.FluentUI.FluentOverflowItem>()

    /// A component that provides a user interface for PaginationState.
    type FluentPaginator' 
        /// A component that provides a user interface for PaginationState.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.FluentPaginator>)>] () = inherit FluentPaginatorBuilder<Microsoft.Fast.Components.FluentUI.FluentPaginator>()
    type FluentPopover' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.FluentPopover>)>] () = inherit FluentPopoverBuilder<Microsoft.Fast.Components.FluentUI.FluentPopover>()

    /// A presence badge is a badge that displays a status indicator such as available, away, or busy.
    type FluentPresenceBadge' 
        /// A presence badge is a badge that displays a status indicator such as available, away, or busy.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.FluentPresenceBadge>)>] () = inherit FluentPresenceBadgeBuilder<Microsoft.Fast.Components.FluentUI.FluentPresenceBadge>()
    type FluentProgress' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.FluentProgress>)>] () = inherit FluentProgressBuilder<Microsoft.Fast.Components.FluentUI.FluentProgress>()
    type FluentProgressRing' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.FluentProgressRing>)>] () = inherit FluentProgressRingBuilder<Microsoft.Fast.Components.FluentUI.FluentProgressRing>()
    type FluentRadio'<'TValue> [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.FluentRadio<_>>)>] () = inherit FluentRadioBuilder<Microsoft.Fast.Components.FluentUI.FluentRadio<'TValue>, 'TValue>()
    type FluentSkeleton' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.FluentSkeleton>)>] () = inherit FluentSkeletonBuilder<Microsoft.Fast.Components.FluentUI.FluentSkeleton>()
    type FluentSliderLabel'<'TValue> [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.FluentSliderLabel<_>>)>] () = inherit FluentSliderLabelBuilder<Microsoft.Fast.Components.FluentUI.FluentSliderLabel<'TValue>, 'TValue>()
    type FluentSplitter' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.FluentSplitter>)>] () = inherit FluentSplitterBuilder<Microsoft.Fast.Components.FluentUI.FluentSplitter>()
    type FluentStack' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.FluentStack>)>] () = inherit FluentStackBuilder<Microsoft.Fast.Components.FluentUI.FluentStack>()
    type FluentTab' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.FluentTab>)>] () = inherit FluentTabBuilder<Microsoft.Fast.Components.FluentUI.FluentTab>()
    type FluentTabs' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.FluentTabs>)>] () = inherit FluentTabsBuilder<Microsoft.Fast.Components.FluentUI.FluentTabs>()
    type FluentToast' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.FluentToast>)>] () = inherit FluentToastBuilder<Microsoft.Fast.Components.FluentUI.FluentToast>()
    type FluentToolbar' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.FluentToolbar>)>] () = inherit FluentToolbarBuilder<Microsoft.Fast.Components.FluentUI.FluentToolbar>()
    type FluentTooltip' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.FluentTooltip>)>] () = inherit FluentTooltipBuilder<Microsoft.Fast.Components.FluentUI.FluentTooltip>()
    type FluentTooltipProvider' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.FluentTooltipProvider>)>] () = inherit FluentTooltipProviderBuilder<Microsoft.Fast.Components.FluentUI.FluentTooltipProvider>()
    type FluentTreeItem' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.FluentTreeItem>)>] () = inherit FluentTreeItemBuilder<Microsoft.Fast.Components.FluentUI.FluentTreeItem>()
    type FluentTreeView' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.FluentTreeView>)>] () = inherit FluentTreeViewBuilder<Microsoft.Fast.Components.FluentUI.FluentTreeView>()

    /// Displays a list of validation messages from a cascaded EditContext.
    type ValidationSummary' 
        /// Displays a list of validation messages from a cascaded EditContext.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.AspNetCore.Components.Forms.ValidationSummary>)>] () = inherit ValidationSummaryBuilder<Microsoft.AspNetCore.Components.Forms.ValidationSummary>()
    type FluentValidationSummary' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.FluentValidationSummary>)>] () = inherit FluentValidationSummaryBuilder<Microsoft.Fast.Components.FluentUI.FluentValidationSummary>()

    /// An abstract base class for columns in a FluentDataGrid`1.
    type ColumnBase'<'TGridItem> 
        /// An abstract base class for columns in a FluentDataGrid`1.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.ColumnBase<_>>)>] () = inherit ColumnBaseBuilder<Microsoft.Fast.Components.FluentUI.ColumnBase<'TGridItem>, 'TGridItem>()

    /// Represents a FluentDataGrid`1 column whose cells display a single value.
    type PropertyColumn'<'TGridItem, 'TProp> 
        /// Represents a FluentDataGrid`1 column whose cells display a single value.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.PropertyColumn<_, _>>)>] () = inherit PropertyColumnBuilder<Microsoft.Fast.Components.FluentUI.PropertyColumn<'TGridItem, 'TProp>, 'TGridItem, 'TProp>()

    /// Represents a FluentDataGrid`1 column whose cells render a supplied template.
    type TemplateColumn'<'TGridItem> 
        /// Represents a FluentDataGrid`1 column whose cells render a supplied template.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.TemplateColumn<_>>)>] () = inherit TemplateColumnBuilder<Microsoft.Fast.Components.FluentUI.TemplateColumn<'TGridItem>, 'TGridItem>()
    type FluentSplashScreen' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.FluentSplashScreen>)>] () = inherit FluentSplashScreenBuilder<Microsoft.Fast.Components.FluentUI.FluentSplashScreen>()
    type MessageBox' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.MessageBox>)>] () = inherit MessageBoxBuilder<Microsoft.Fast.Components.FluentUI.MessageBox>()
    type FluentDialogProvider' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.FluentDialogProvider>)>] () = inherit FluentDialogProviderBuilder<Microsoft.Fast.Components.FluentUI.FluentDialogProvider>()
    type FluentInputLabel' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.FluentInputLabel>)>] () = inherit FluentInputLabelBuilder<Microsoft.Fast.Components.FluentUI.FluentInputLabel>()
    type FluentOverlay' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.FluentOverlay>)>] () = inherit FluentOverlayBuilder<Microsoft.Fast.Components.FluentUI.FluentOverlay>()
    type FluentSpacer' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.FluentSpacer>)>] () = inherit FluentSpacerBuilder<Microsoft.Fast.Components.FluentUI.FluentSpacer>()
    type CommunicationToast' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.CommunicationToast>)>] () = inherit CommunicationToastBuilder<Microsoft.Fast.Components.FluentUI.CommunicationToast>()
    type ProgressToast' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.ProgressToast>)>] () = inherit ProgressToastBuilder<Microsoft.Fast.Components.FluentUI.ProgressToast>()
    type FluentToastContainer' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.FluentToastContainer>)>] () = inherit FluentToastContainerBuilder<Microsoft.Fast.Components.FluentUI.FluentToastContainer>()
    type ConfirmationToast' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.ConfirmationToast>)>] () = inherit ConfirmationToastBuilder<Microsoft.Fast.Components.FluentUI.ConfirmationToast>()
    type _Imports' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI._Imports>)>] () = inherit _ImportsBuilder<Microsoft.Fast.Components.FluentUI._Imports>()
            
namespace Microsoft.Fast.Components.FluentUI.DesignTokens

[<AutoOpen>]
module DslCE =
  
    open System.Diagnostics.CodeAnalysis
    open Microsoft.Fast.Components.FluentUI.DslInternals.DesignTokens

    type DesignToken'<'T> [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.DesignTokens.DesignToken<_>>)>] () = inherit DesignTokenBuilder<Microsoft.Fast.Components.FluentUI.DesignTokens.DesignToken<'T>, 'T>()

    /// The Direction design token
    type Direction' 
        /// The Direction design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.DesignTokens.Direction>)>] () = inherit DirectionBuilder<Microsoft.Fast.Components.FluentUI.DesignTokens.Direction>()

    /// The DisabledOpacity design token
    type DisabledOpacity' 
        /// The DisabledOpacity design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.DesignTokens.DisabledOpacity>)>] () = inherit DisabledOpacityBuilder<Microsoft.Fast.Components.FluentUI.DesignTokens.DisabledOpacity>()

    /// The BaseHeightMultiplier design token
    type BaseHeightMultiplier' 
        /// The BaseHeightMultiplier design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.DesignTokens.BaseHeightMultiplier>)>] () = inherit BaseHeightMultiplierBuilder<Microsoft.Fast.Components.FluentUI.DesignTokens.BaseHeightMultiplier>()

    /// The BaseHorizontalSpacingMultiplier design token
    type BaseHorizontalSpacingMultiplier' 
        /// The BaseHorizontalSpacingMultiplier design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.DesignTokens.BaseHorizontalSpacingMultiplier>)>] () = inherit BaseHorizontalSpacingMultiplierBuilder<Microsoft.Fast.Components.FluentUI.DesignTokens.BaseHorizontalSpacingMultiplier>()

    /// The Density design token
    type Density' 
        /// The Density design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.DesignTokens.Density>)>] () = inherit DensityBuilder<Microsoft.Fast.Components.FluentUI.DesignTokens.Density>()

    /// The DesignUnit design token
    type DesignUnit' 
        /// The DesignUnit design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.DesignTokens.DesignUnit>)>] () = inherit DesignUnitBuilder<Microsoft.Fast.Components.FluentUI.DesignTokens.DesignUnit>()

    /// The ControlCornerRadius design token
    type ControlCornerRadius' 
        /// The ControlCornerRadius design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.DesignTokens.ControlCornerRadius>)>] () = inherit ControlCornerRadiusBuilder<Microsoft.Fast.Components.FluentUI.DesignTokens.ControlCornerRadius>()

    /// The LayerCornerRadius design token
    type LayerCornerRadius' 
        /// The LayerCornerRadius design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.DesignTokens.LayerCornerRadius>)>] () = inherit LayerCornerRadiusBuilder<Microsoft.Fast.Components.FluentUI.DesignTokens.LayerCornerRadius>()

    /// The StrokeWidth design token
    type StrokeWidth' 
        /// The StrokeWidth design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.DesignTokens.StrokeWidth>)>] () = inherit StrokeWidthBuilder<Microsoft.Fast.Components.FluentUI.DesignTokens.StrokeWidth>()

    /// The FocusStrokeWidth design token
    type FocusStrokeWidth' 
        /// The FocusStrokeWidth design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.DesignTokens.FocusStrokeWidth>)>] () = inherit FocusStrokeWidthBuilder<Microsoft.Fast.Components.FluentUI.DesignTokens.FocusStrokeWidth>()

    /// The BodyFont design token
    type BodyFont' 
        /// The BodyFont design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.DesignTokens.BodyFont>)>] () = inherit BodyFontBuilder<Microsoft.Fast.Components.FluentUI.DesignTokens.BodyFont>()

    /// The TypeRampBaseFontSize design token
    type TypeRampBaseFontSize' 
        /// The TypeRampBaseFontSize design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.DesignTokens.TypeRampBaseFontSize>)>] () = inherit TypeRampBaseFontSizeBuilder<Microsoft.Fast.Components.FluentUI.DesignTokens.TypeRampBaseFontSize>()

    /// The TypeRampBaseLineHeight design token
    type TypeRampBaseLineHeight' 
        /// The TypeRampBaseLineHeight design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.DesignTokens.TypeRampBaseLineHeight>)>] () = inherit TypeRampBaseLineHeightBuilder<Microsoft.Fast.Components.FluentUI.DesignTokens.TypeRampBaseLineHeight>()

    /// The TypeRampMinus1FontSize design token
    type TypeRampMinus1FontSize' 
        /// The TypeRampMinus1FontSize design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.DesignTokens.TypeRampMinus1FontSize>)>] () = inherit TypeRampMinus1FontSizeBuilder<Microsoft.Fast.Components.FluentUI.DesignTokens.TypeRampMinus1FontSize>()

    /// The TypeRampMinus1LineHeight design token
    type TypeRampMinus1LineHeight' 
        /// The TypeRampMinus1LineHeight design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.DesignTokens.TypeRampMinus1LineHeight>)>] () = inherit TypeRampMinus1LineHeightBuilder<Microsoft.Fast.Components.FluentUI.DesignTokens.TypeRampMinus1LineHeight>()

    /// The TypeRampMinus2FontSize design token
    type TypeRampMinus2FontSize' 
        /// The TypeRampMinus2FontSize design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.DesignTokens.TypeRampMinus2FontSize>)>] () = inherit TypeRampMinus2FontSizeBuilder<Microsoft.Fast.Components.FluentUI.DesignTokens.TypeRampMinus2FontSize>()

    /// The TypeRampMinus2LineHeight design token
    type TypeRampMinus2LineHeight' 
        /// The TypeRampMinus2LineHeight design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.DesignTokens.TypeRampMinus2LineHeight>)>] () = inherit TypeRampMinus2LineHeightBuilder<Microsoft.Fast.Components.FluentUI.DesignTokens.TypeRampMinus2LineHeight>()

    /// The TypeRampPlus1FontSize design token
    type TypeRampPlus1FontSize' 
        /// The TypeRampPlus1FontSize design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.DesignTokens.TypeRampPlus1FontSize>)>] () = inherit TypeRampPlus1FontSizeBuilder<Microsoft.Fast.Components.FluentUI.DesignTokens.TypeRampPlus1FontSize>()

    /// The TypeRampPlus1LineHeight design token
    type TypeRampPlus1LineHeight' 
        /// The TypeRampPlus1LineHeight design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.DesignTokens.TypeRampPlus1LineHeight>)>] () = inherit TypeRampPlus1LineHeightBuilder<Microsoft.Fast.Components.FluentUI.DesignTokens.TypeRampPlus1LineHeight>()

    /// The TypeRampPlus2FontSize design token
    type TypeRampPlus2FontSize' 
        /// The TypeRampPlus2FontSize design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.DesignTokens.TypeRampPlus2FontSize>)>] () = inherit TypeRampPlus2FontSizeBuilder<Microsoft.Fast.Components.FluentUI.DesignTokens.TypeRampPlus2FontSize>()

    /// The TypeRampPlus2LineHeight design token
    type TypeRampPlus2LineHeight' 
        /// The TypeRampPlus2LineHeight design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.DesignTokens.TypeRampPlus2LineHeight>)>] () = inherit TypeRampPlus2LineHeightBuilder<Microsoft.Fast.Components.FluentUI.DesignTokens.TypeRampPlus2LineHeight>()

    /// The TypeRampPlus3FontSize design token
    type TypeRampPlus3FontSize' 
        /// The TypeRampPlus3FontSize design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.DesignTokens.TypeRampPlus3FontSize>)>] () = inherit TypeRampPlus3FontSizeBuilder<Microsoft.Fast.Components.FluentUI.DesignTokens.TypeRampPlus3FontSize>()

    /// The TypeRampPlus3LineHeight design token
    type TypeRampPlus3LineHeight' 
        /// The TypeRampPlus3LineHeight design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.DesignTokens.TypeRampPlus3LineHeight>)>] () = inherit TypeRampPlus3LineHeightBuilder<Microsoft.Fast.Components.FluentUI.DesignTokens.TypeRampPlus3LineHeight>()

    /// The TypeRampPlus4FontSize design token
    type TypeRampPlus4FontSize' 
        /// The TypeRampPlus4FontSize design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.DesignTokens.TypeRampPlus4FontSize>)>] () = inherit TypeRampPlus4FontSizeBuilder<Microsoft.Fast.Components.FluentUI.DesignTokens.TypeRampPlus4FontSize>()

    /// The TypeRampPlus4LineHeight design token
    type TypeRampPlus4LineHeight' 
        /// The TypeRampPlus4LineHeight design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.DesignTokens.TypeRampPlus4LineHeight>)>] () = inherit TypeRampPlus4LineHeightBuilder<Microsoft.Fast.Components.FluentUI.DesignTokens.TypeRampPlus4LineHeight>()

    /// The TypeRampPlus5FontSize design token
    type TypeRampPlus5FontSize' 
        /// The TypeRampPlus5FontSize design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.DesignTokens.TypeRampPlus5FontSize>)>] () = inherit TypeRampPlus5FontSizeBuilder<Microsoft.Fast.Components.FluentUI.DesignTokens.TypeRampPlus5FontSize>()

    /// The TypeRampPlus5LineHeight design token
    type TypeRampPlus5LineHeight' 
        /// The TypeRampPlus5LineHeight design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.DesignTokens.TypeRampPlus5LineHeight>)>] () = inherit TypeRampPlus5LineHeightBuilder<Microsoft.Fast.Components.FluentUI.DesignTokens.TypeRampPlus5LineHeight>()

    /// The TypeRampPlus6FontSize design token
    type TypeRampPlus6FontSize' 
        /// The TypeRampPlus6FontSize design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.DesignTokens.TypeRampPlus6FontSize>)>] () = inherit TypeRampPlus6FontSizeBuilder<Microsoft.Fast.Components.FluentUI.DesignTokens.TypeRampPlus6FontSize>()

    /// The TypeRampPlus6LineHeight design token
    type TypeRampPlus6LineHeight' 
        /// The TypeRampPlus6LineHeight design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.DesignTokens.TypeRampPlus6LineHeight>)>] () = inherit TypeRampPlus6LineHeightBuilder<Microsoft.Fast.Components.FluentUI.DesignTokens.TypeRampPlus6LineHeight>()

    /// The BaseLayerLuminance design token
    type BaseLayerLuminance' 
        /// The BaseLayerLuminance design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.DesignTokens.BaseLayerLuminance>)>] () = inherit BaseLayerLuminanceBuilder<Microsoft.Fast.Components.FluentUI.DesignTokens.BaseLayerLuminance>()

    /// The AccentFillRestDelta design token
    type AccentFillRestDelta' 
        /// The AccentFillRestDelta design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.DesignTokens.AccentFillRestDelta>)>] () = inherit AccentFillRestDeltaBuilder<Microsoft.Fast.Components.FluentUI.DesignTokens.AccentFillRestDelta>()

    /// The AccentFillHoverDelta design token
    type AccentFillHoverDelta' 
        /// The AccentFillHoverDelta design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.DesignTokens.AccentFillHoverDelta>)>] () = inherit AccentFillHoverDeltaBuilder<Microsoft.Fast.Components.FluentUI.DesignTokens.AccentFillHoverDelta>()

    /// The AccentFillActiveDelta design token
    type AccentFillActiveDelta' 
        /// The AccentFillActiveDelta design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.DesignTokens.AccentFillActiveDelta>)>] () = inherit AccentFillActiveDeltaBuilder<Microsoft.Fast.Components.FluentUI.DesignTokens.AccentFillActiveDelta>()

    /// The AccentFillFocusDelta design token
    type AccentFillFocusDelta' 
        /// The AccentFillFocusDelta design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.DesignTokens.AccentFillFocusDelta>)>] () = inherit AccentFillFocusDeltaBuilder<Microsoft.Fast.Components.FluentUI.DesignTokens.AccentFillFocusDelta>()

    /// The AccentForegroundRestDelta design token
    type AccentForegroundRestDelta' 
        /// The AccentForegroundRestDelta design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.DesignTokens.AccentForegroundRestDelta>)>] () = inherit AccentForegroundRestDeltaBuilder<Microsoft.Fast.Components.FluentUI.DesignTokens.AccentForegroundRestDelta>()

    /// The AccentForegroundHoverDelta design token
    type AccentForegroundHoverDelta' 
        /// The AccentForegroundHoverDelta design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.DesignTokens.AccentForegroundHoverDelta>)>] () = inherit AccentForegroundHoverDeltaBuilder<Microsoft.Fast.Components.FluentUI.DesignTokens.AccentForegroundHoverDelta>()

    /// The AccentForegroundActiveDelta design token
    type AccentForegroundActiveDelta' 
        /// The AccentForegroundActiveDelta design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.DesignTokens.AccentForegroundActiveDelta>)>] () = inherit AccentForegroundActiveDeltaBuilder<Microsoft.Fast.Components.FluentUI.DesignTokens.AccentForegroundActiveDelta>()

    /// The AccentForegroundFocusDelta design token
    type AccentForegroundFocusDelta' 
        /// The AccentForegroundFocusDelta design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.DesignTokens.AccentForegroundFocusDelta>)>] () = inherit AccentForegroundFocusDeltaBuilder<Microsoft.Fast.Components.FluentUI.DesignTokens.AccentForegroundFocusDelta>()

    /// The NeutralFillRestDelta design token
    type NeutralFillRestDelta' 
        /// The NeutralFillRestDelta design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.DesignTokens.NeutralFillRestDelta>)>] () = inherit NeutralFillRestDeltaBuilder<Microsoft.Fast.Components.FluentUI.DesignTokens.NeutralFillRestDelta>()

    /// The NeutralFillHoverDelta design token
    type NeutralFillHoverDelta' 
        /// The NeutralFillHoverDelta design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.DesignTokens.NeutralFillHoverDelta>)>] () = inherit NeutralFillHoverDeltaBuilder<Microsoft.Fast.Components.FluentUI.DesignTokens.NeutralFillHoverDelta>()

    /// The NeutralFillActiveDelta design token
    type NeutralFillActiveDelta' 
        /// The NeutralFillActiveDelta design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.DesignTokens.NeutralFillActiveDelta>)>] () = inherit NeutralFillActiveDeltaBuilder<Microsoft.Fast.Components.FluentUI.DesignTokens.NeutralFillActiveDelta>()

    /// The NeutralFillFocusDelta design token
    type NeutralFillFocusDelta' 
        /// The NeutralFillFocusDelta design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.DesignTokens.NeutralFillFocusDelta>)>] () = inherit NeutralFillFocusDeltaBuilder<Microsoft.Fast.Components.FluentUI.DesignTokens.NeutralFillFocusDelta>()

    /// The NeutralFillInputRestDelta design token
    type NeutralFillInputRestDelta' 
        /// The NeutralFillInputRestDelta design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.DesignTokens.NeutralFillInputRestDelta>)>] () = inherit NeutralFillInputRestDeltaBuilder<Microsoft.Fast.Components.FluentUI.DesignTokens.NeutralFillInputRestDelta>()

    /// The NeutralFillInputHoverDelta design token
    type NeutralFillInputHoverDelta' 
        /// The NeutralFillInputHoverDelta design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.DesignTokens.NeutralFillInputHoverDelta>)>] () = inherit NeutralFillInputHoverDeltaBuilder<Microsoft.Fast.Components.FluentUI.DesignTokens.NeutralFillInputHoverDelta>()

    /// The NeutralFillInputActiveDelta design token
    type NeutralFillInputActiveDelta' 
        /// The NeutralFillInputActiveDelta design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.DesignTokens.NeutralFillInputActiveDelta>)>] () = inherit NeutralFillInputActiveDeltaBuilder<Microsoft.Fast.Components.FluentUI.DesignTokens.NeutralFillInputActiveDelta>()

    /// The NeutralFillInputFocusDelta design token
    type NeutralFillInputFocusDelta' 
        /// The NeutralFillInputFocusDelta design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.DesignTokens.NeutralFillInputFocusDelta>)>] () = inherit NeutralFillInputFocusDeltaBuilder<Microsoft.Fast.Components.FluentUI.DesignTokens.NeutralFillInputFocusDelta>()

    /// The NeutralFillInputAltRestDelta design token
    type NeutralFillInputAltRestDelta' 
        /// The NeutralFillInputAltRestDelta design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.DesignTokens.NeutralFillInputAltRestDelta>)>] () = inherit NeutralFillInputAltRestDeltaBuilder<Microsoft.Fast.Components.FluentUI.DesignTokens.NeutralFillInputAltRestDelta>()

    /// The NeutralFillInputAltHoverDelta design token
    type NeutralFillInputAltHoverDelta' 
        /// The NeutralFillInputAltHoverDelta design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.DesignTokens.NeutralFillInputAltHoverDelta>)>] () = inherit NeutralFillInputAltHoverDeltaBuilder<Microsoft.Fast.Components.FluentUI.DesignTokens.NeutralFillInputAltHoverDelta>()

    /// The NeutralFillInputAltActiveDelta design token
    type NeutralFillInputAltActiveDelta' 
        /// The NeutralFillInputAltActiveDelta design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.DesignTokens.NeutralFillInputAltActiveDelta>)>] () = inherit NeutralFillInputAltActiveDeltaBuilder<Microsoft.Fast.Components.FluentUI.DesignTokens.NeutralFillInputAltActiveDelta>()

    /// The NeutralFillInputAltFocusDelta design token
    type NeutralFillInputAltFocusDelta' 
        /// The NeutralFillInputAltFocusDelta design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.DesignTokens.NeutralFillInputAltFocusDelta>)>] () = inherit NeutralFillInputAltFocusDeltaBuilder<Microsoft.Fast.Components.FluentUI.DesignTokens.NeutralFillInputAltFocusDelta>()

    /// The NeutralFillLayerRestDelta design token
    type NeutralFillLayerRestDelta' 
        /// The NeutralFillLayerRestDelta design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.DesignTokens.NeutralFillLayerRestDelta>)>] () = inherit NeutralFillLayerRestDeltaBuilder<Microsoft.Fast.Components.FluentUI.DesignTokens.NeutralFillLayerRestDelta>()

    /// The NeutralFillLayerHoverDelta design token
    type NeutralFillLayerHoverDelta' 
        /// The NeutralFillLayerHoverDelta design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.DesignTokens.NeutralFillLayerHoverDelta>)>] () = inherit NeutralFillLayerHoverDeltaBuilder<Microsoft.Fast.Components.FluentUI.DesignTokens.NeutralFillLayerHoverDelta>()

    /// The NeutralFillLayerActiveDelta design token
    type NeutralFillLayerActiveDelta' 
        /// The NeutralFillLayerActiveDelta design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.DesignTokens.NeutralFillLayerActiveDelta>)>] () = inherit NeutralFillLayerActiveDeltaBuilder<Microsoft.Fast.Components.FluentUI.DesignTokens.NeutralFillLayerActiveDelta>()

    /// The NeutralFillLayerAltRestDelta design token
    type NeutralFillLayerAltRestDelta' 
        /// The NeutralFillLayerAltRestDelta design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.DesignTokens.NeutralFillLayerAltRestDelta>)>] () = inherit NeutralFillLayerAltRestDeltaBuilder<Microsoft.Fast.Components.FluentUI.DesignTokens.NeutralFillLayerAltRestDelta>()

    /// The NeutralFillSecondaryRestDelta design token
    type NeutralFillSecondaryRestDelta' 
        /// The NeutralFillSecondaryRestDelta design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.DesignTokens.NeutralFillSecondaryRestDelta>)>] () = inherit NeutralFillSecondaryRestDeltaBuilder<Microsoft.Fast.Components.FluentUI.DesignTokens.NeutralFillSecondaryRestDelta>()

    /// The NeutralFillSecondaryHoverDelta design token
    type NeutralFillSecondaryHoverDelta' 
        /// The NeutralFillSecondaryHoverDelta design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.DesignTokens.NeutralFillSecondaryHoverDelta>)>] () = inherit NeutralFillSecondaryHoverDeltaBuilder<Microsoft.Fast.Components.FluentUI.DesignTokens.NeutralFillSecondaryHoverDelta>()

    /// The NeutralFillSecondaryActiveDelta design token
    type NeutralFillSecondaryActiveDelta' 
        /// The NeutralFillSecondaryActiveDelta design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.DesignTokens.NeutralFillSecondaryActiveDelta>)>] () = inherit NeutralFillSecondaryActiveDeltaBuilder<Microsoft.Fast.Components.FluentUI.DesignTokens.NeutralFillSecondaryActiveDelta>()

    /// The NeutralFillSecondaryFocusDelta design token
    type NeutralFillSecondaryFocusDelta' 
        /// The NeutralFillSecondaryFocusDelta design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.DesignTokens.NeutralFillSecondaryFocusDelta>)>] () = inherit NeutralFillSecondaryFocusDeltaBuilder<Microsoft.Fast.Components.FluentUI.DesignTokens.NeutralFillSecondaryFocusDelta>()

    /// The NeutralFillStealthRestDelta design token
    type NeutralFillStealthRestDelta' 
        /// The NeutralFillStealthRestDelta design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.DesignTokens.NeutralFillStealthRestDelta>)>] () = inherit NeutralFillStealthRestDeltaBuilder<Microsoft.Fast.Components.FluentUI.DesignTokens.NeutralFillStealthRestDelta>()

    /// The NeutralFillStealthHoverDelta design token
    type NeutralFillStealthHoverDelta' 
        /// The NeutralFillStealthHoverDelta design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.DesignTokens.NeutralFillStealthHoverDelta>)>] () = inherit NeutralFillStealthHoverDeltaBuilder<Microsoft.Fast.Components.FluentUI.DesignTokens.NeutralFillStealthHoverDelta>()

    /// The NeutralFillStealthActiveDelta design token
    type NeutralFillStealthActiveDelta' 
        /// The NeutralFillStealthActiveDelta design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.DesignTokens.NeutralFillStealthActiveDelta>)>] () = inherit NeutralFillStealthActiveDeltaBuilder<Microsoft.Fast.Components.FluentUI.DesignTokens.NeutralFillStealthActiveDelta>()

    /// The NeutralFillStealthFocusDelta design token
    type NeutralFillStealthFocusDelta' 
        /// The NeutralFillStealthFocusDelta design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.DesignTokens.NeutralFillStealthFocusDelta>)>] () = inherit NeutralFillStealthFocusDeltaBuilder<Microsoft.Fast.Components.FluentUI.DesignTokens.NeutralFillStealthFocusDelta>()

    /// The NeutralFillStrongRestDelta design token
    type NeutralFillStrongRestDelta' 
        /// The NeutralFillStrongRestDelta design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.DesignTokens.NeutralFillStrongRestDelta>)>] () = inherit NeutralFillStrongRestDeltaBuilder<Microsoft.Fast.Components.FluentUI.DesignTokens.NeutralFillStrongRestDelta>()

    /// The NeutralFillStrongHoverDelta design token
    type NeutralFillStrongHoverDelta' 
        /// The NeutralFillStrongHoverDelta design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.DesignTokens.NeutralFillStrongHoverDelta>)>] () = inherit NeutralFillStrongHoverDeltaBuilder<Microsoft.Fast.Components.FluentUI.DesignTokens.NeutralFillStrongHoverDelta>()

    /// The NeutralFillStrongActiveDelta design token
    type NeutralFillStrongActiveDelta' 
        /// The NeutralFillStrongActiveDelta design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.DesignTokens.NeutralFillStrongActiveDelta>)>] () = inherit NeutralFillStrongActiveDeltaBuilder<Microsoft.Fast.Components.FluentUI.DesignTokens.NeutralFillStrongActiveDelta>()

    /// The NeutralFillStrongFocusDelta design token
    type NeutralFillStrongFocusDelta' 
        /// The NeutralFillStrongFocusDelta design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.DesignTokens.NeutralFillStrongFocusDelta>)>] () = inherit NeutralFillStrongFocusDeltaBuilder<Microsoft.Fast.Components.FluentUI.DesignTokens.NeutralFillStrongFocusDelta>()

    /// The NeutralStrokeRestDelta design token
    type NeutralStrokeRestDelta' 
        /// The NeutralStrokeRestDelta design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.DesignTokens.NeutralStrokeRestDelta>)>] () = inherit NeutralStrokeRestDeltaBuilder<Microsoft.Fast.Components.FluentUI.DesignTokens.NeutralStrokeRestDelta>()

    /// The NeutralStrokeHoverDelta design token
    type NeutralStrokeHoverDelta' 
        /// The NeutralStrokeHoverDelta design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.DesignTokens.NeutralStrokeHoverDelta>)>] () = inherit NeutralStrokeHoverDeltaBuilder<Microsoft.Fast.Components.FluentUI.DesignTokens.NeutralStrokeHoverDelta>()

    /// The NeutralStrokeActiveDelta design token
    type NeutralStrokeActiveDelta' 
        /// The NeutralStrokeActiveDelta design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.DesignTokens.NeutralStrokeActiveDelta>)>] () = inherit NeutralStrokeActiveDeltaBuilder<Microsoft.Fast.Components.FluentUI.DesignTokens.NeutralStrokeActiveDelta>()

    /// The NeutralStrokeFocusDelta design token
    type NeutralStrokeFocusDelta' 
        /// The NeutralStrokeFocusDelta design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.DesignTokens.NeutralStrokeFocusDelta>)>] () = inherit NeutralStrokeFocusDeltaBuilder<Microsoft.Fast.Components.FluentUI.DesignTokens.NeutralStrokeFocusDelta>()

    /// The NeutralStrokeControlRestDelta design token
    type NeutralStrokeControlRestDelta' 
        /// The NeutralStrokeControlRestDelta design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.DesignTokens.NeutralStrokeControlRestDelta>)>] () = inherit NeutralStrokeControlRestDeltaBuilder<Microsoft.Fast.Components.FluentUI.DesignTokens.NeutralStrokeControlRestDelta>()

    /// The NeutralStrokeControlHoverDelta design token
    type NeutralStrokeControlHoverDelta' 
        /// The NeutralStrokeControlHoverDelta design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.DesignTokens.NeutralStrokeControlHoverDelta>)>] () = inherit NeutralStrokeControlHoverDeltaBuilder<Microsoft.Fast.Components.FluentUI.DesignTokens.NeutralStrokeControlHoverDelta>()

    /// The NeutralStrokeControlActiveDelta design token
    type NeutralStrokeControlActiveDelta' 
        /// The NeutralStrokeControlActiveDelta design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.DesignTokens.NeutralStrokeControlActiveDelta>)>] () = inherit NeutralStrokeControlActiveDeltaBuilder<Microsoft.Fast.Components.FluentUI.DesignTokens.NeutralStrokeControlActiveDelta>()

    /// The NeutralStrokeControlFocusDelta design token
    type NeutralStrokeControlFocusDelta' 
        /// The NeutralStrokeControlFocusDelta design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.DesignTokens.NeutralStrokeControlFocusDelta>)>] () = inherit NeutralStrokeControlFocusDeltaBuilder<Microsoft.Fast.Components.FluentUI.DesignTokens.NeutralStrokeControlFocusDelta>()

    /// The NeutralStrokeDividerRestDelta design token
    type NeutralStrokeDividerRestDelta' 
        /// The NeutralStrokeDividerRestDelta design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.DesignTokens.NeutralStrokeDividerRestDelta>)>] () = inherit NeutralStrokeDividerRestDeltaBuilder<Microsoft.Fast.Components.FluentUI.DesignTokens.NeutralStrokeDividerRestDelta>()

    /// The NeutralStrokeLayerRestDelta design token
    type NeutralStrokeLayerRestDelta' 
        /// The NeutralStrokeLayerRestDelta design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.DesignTokens.NeutralStrokeLayerRestDelta>)>] () = inherit NeutralStrokeLayerRestDeltaBuilder<Microsoft.Fast.Components.FluentUI.DesignTokens.NeutralStrokeLayerRestDelta>()

    /// The NeutralStrokeLayerHoverDelta design token
    type NeutralStrokeLayerHoverDelta' 
        /// The NeutralStrokeLayerHoverDelta design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.DesignTokens.NeutralStrokeLayerHoverDelta>)>] () = inherit NeutralStrokeLayerHoverDeltaBuilder<Microsoft.Fast.Components.FluentUI.DesignTokens.NeutralStrokeLayerHoverDelta>()

    /// The NeutralStrokeLayerActiveDelta design token
    type NeutralStrokeLayerActiveDelta' 
        /// The NeutralStrokeLayerActiveDelta design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.DesignTokens.NeutralStrokeLayerActiveDelta>)>] () = inherit NeutralStrokeLayerActiveDeltaBuilder<Microsoft.Fast.Components.FluentUI.DesignTokens.NeutralStrokeLayerActiveDelta>()

    /// The NeutralStrokeStrongHoverDelta design token
    type NeutralStrokeStrongHoverDelta' 
        /// The NeutralStrokeStrongHoverDelta design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.DesignTokens.NeutralStrokeStrongHoverDelta>)>] () = inherit NeutralStrokeStrongHoverDeltaBuilder<Microsoft.Fast.Components.FluentUI.DesignTokens.NeutralStrokeStrongHoverDelta>()

    /// The NeutralStrokeStrongActiveDelta design token
    type NeutralStrokeStrongActiveDelta' 
        /// The NeutralStrokeStrongActiveDelta design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.DesignTokens.NeutralStrokeStrongActiveDelta>)>] () = inherit NeutralStrokeStrongActiveDeltaBuilder<Microsoft.Fast.Components.FluentUI.DesignTokens.NeutralStrokeStrongActiveDelta>()

    /// The NeutralStrokeStrongFocusDelta design token
    type NeutralStrokeStrongFocusDelta' 
        /// The NeutralStrokeStrongFocusDelta design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.DesignTokens.NeutralStrokeStrongFocusDelta>)>] () = inherit NeutralStrokeStrongFocusDeltaBuilder<Microsoft.Fast.Components.FluentUI.DesignTokens.NeutralStrokeStrongFocusDelta>()

    /// The NeutralBaseColor design token
    type NeutralBaseColor' 
        /// The NeutralBaseColor design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.DesignTokens.NeutralBaseColor>)>] () = inherit NeutralBaseColorBuilder<Microsoft.Fast.Components.FluentUI.DesignTokens.NeutralBaseColor>()

    /// The AccentBaseColor design token
    type AccentBaseColor' 
        /// The AccentBaseColor design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.DesignTokens.AccentBaseColor>)>] () = inherit AccentBaseColorBuilder<Microsoft.Fast.Components.FluentUI.DesignTokens.AccentBaseColor>()

    /// The NeutralLayerCardContainer design token
    type NeutralLayerCardContainer' 
        /// The NeutralLayerCardContainer design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.DesignTokens.NeutralLayerCardContainer>)>] () = inherit NeutralLayerCardContainerBuilder<Microsoft.Fast.Components.FluentUI.DesignTokens.NeutralLayerCardContainer>()

    /// The NeutralLayerFloating design token
    type NeutralLayerFloating' 
        /// The NeutralLayerFloating design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.DesignTokens.NeutralLayerFloating>)>] () = inherit NeutralLayerFloatingBuilder<Microsoft.Fast.Components.FluentUI.DesignTokens.NeutralLayerFloating>()

    /// The NeutralLayer1 design token
    type NeutralLayer1' 
        /// The NeutralLayer1 design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.DesignTokens.NeutralLayer1>)>] () = inherit NeutralLayer1Builder<Microsoft.Fast.Components.FluentUI.DesignTokens.NeutralLayer1>()

    /// The NeutralLayer2 design token
    type NeutralLayer2' 
        /// The NeutralLayer2 design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.DesignTokens.NeutralLayer2>)>] () = inherit NeutralLayer2Builder<Microsoft.Fast.Components.FluentUI.DesignTokens.NeutralLayer2>()

    /// The NeutralLayer3 design token
    type NeutralLayer3' 
        /// The NeutralLayer3 design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.DesignTokens.NeutralLayer3>)>] () = inherit NeutralLayer3Builder<Microsoft.Fast.Components.FluentUI.DesignTokens.NeutralLayer3>()

    /// The NeutralLayer4 design token
    type NeutralLayer4' 
        /// The NeutralLayer4 design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.DesignTokens.NeutralLayer4>)>] () = inherit NeutralLayer4Builder<Microsoft.Fast.Components.FluentUI.DesignTokens.NeutralLayer4>()

    /// The FillColor design token
    type FillColor' 
        /// The FillColor design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.DesignTokens.FillColor>)>] () = inherit FillColorBuilder<Microsoft.Fast.Components.FluentUI.DesignTokens.FillColor>()

    /// The AccentFillRest design token
    type AccentFillRest' 
        /// The AccentFillRest design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.DesignTokens.AccentFillRest>)>] () = inherit AccentFillRestBuilder<Microsoft.Fast.Components.FluentUI.DesignTokens.AccentFillRest>()

    /// The AccentFillHover design token
    type AccentFillHover' 
        /// The AccentFillHover design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.DesignTokens.AccentFillHover>)>] () = inherit AccentFillHoverBuilder<Microsoft.Fast.Components.FluentUI.DesignTokens.AccentFillHover>()

    /// The AccentFillActive design token
    type AccentFillActive' 
        /// The AccentFillActive design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.DesignTokens.AccentFillActive>)>] () = inherit AccentFillActiveBuilder<Microsoft.Fast.Components.FluentUI.DesignTokens.AccentFillActive>()

    /// The AccentFillFocus design token
    type AccentFillFocus' 
        /// The AccentFillFocus design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.DesignTokens.AccentFillFocus>)>] () = inherit AccentFillFocusBuilder<Microsoft.Fast.Components.FluentUI.DesignTokens.AccentFillFocus>()

    /// The ForegroundOnAccentRest design token
    type ForegroundOnAccentRest' 
        /// The ForegroundOnAccentRest design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.DesignTokens.ForegroundOnAccentRest>)>] () = inherit ForegroundOnAccentRestBuilder<Microsoft.Fast.Components.FluentUI.DesignTokens.ForegroundOnAccentRest>()

    /// The ForegroundOnAccentHover design token
    type ForegroundOnAccentHover' 
        /// The ForegroundOnAccentHover design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.DesignTokens.ForegroundOnAccentHover>)>] () = inherit ForegroundOnAccentHoverBuilder<Microsoft.Fast.Components.FluentUI.DesignTokens.ForegroundOnAccentHover>()

    /// The ForegroundOnAccentActive design token
    type ForegroundOnAccentActive' 
        /// The ForegroundOnAccentActive design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.DesignTokens.ForegroundOnAccentActive>)>] () = inherit ForegroundOnAccentActiveBuilder<Microsoft.Fast.Components.FluentUI.DesignTokens.ForegroundOnAccentActive>()

    /// The ForegroundOnAccentFocus design token
    type ForegroundOnAccentFocus' 
        /// The ForegroundOnAccentFocus design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.DesignTokens.ForegroundOnAccentFocus>)>] () = inherit ForegroundOnAccentFocusBuilder<Microsoft.Fast.Components.FluentUI.DesignTokens.ForegroundOnAccentFocus>()

    /// The AccentForegroundRest design token
    type AccentForegroundRest' 
        /// The AccentForegroundRest design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.DesignTokens.AccentForegroundRest>)>] () = inherit AccentForegroundRestBuilder<Microsoft.Fast.Components.FluentUI.DesignTokens.AccentForegroundRest>()

    /// The AccentForegroundHover design token
    type AccentForegroundHover' 
        /// The AccentForegroundHover design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.DesignTokens.AccentForegroundHover>)>] () = inherit AccentForegroundHoverBuilder<Microsoft.Fast.Components.FluentUI.DesignTokens.AccentForegroundHover>()

    /// The AccentForegroundActive design token
    type AccentForegroundActive' 
        /// The AccentForegroundActive design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.DesignTokens.AccentForegroundActive>)>] () = inherit AccentForegroundActiveBuilder<Microsoft.Fast.Components.FluentUI.DesignTokens.AccentForegroundActive>()

    /// The AccentForegroundFocus design token
    type AccentForegroundFocus' 
        /// The AccentForegroundFocus design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.DesignTokens.AccentForegroundFocus>)>] () = inherit AccentForegroundFocusBuilder<Microsoft.Fast.Components.FluentUI.DesignTokens.AccentForegroundFocus>()

    /// The AccentStrokeControlRest design token
    type AccentStrokeControlRest' 
        /// The AccentStrokeControlRest design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.DesignTokens.AccentStrokeControlRest>)>] () = inherit AccentStrokeControlRestBuilder<Microsoft.Fast.Components.FluentUI.DesignTokens.AccentStrokeControlRest>()

    /// The AccentStrokeControlHover design token
    type AccentStrokeControlHover' 
        /// The AccentStrokeControlHover design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.DesignTokens.AccentStrokeControlHover>)>] () = inherit AccentStrokeControlHoverBuilder<Microsoft.Fast.Components.FluentUI.DesignTokens.AccentStrokeControlHover>()

    /// The AccentStrokeControlActive design token
    type AccentStrokeControlActive' 
        /// The AccentStrokeControlActive design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.DesignTokens.AccentStrokeControlActive>)>] () = inherit AccentStrokeControlActiveBuilder<Microsoft.Fast.Components.FluentUI.DesignTokens.AccentStrokeControlActive>()

    /// The AccentStrokeControlFocus design token
    type AccentStrokeControlFocus' 
        /// The AccentStrokeControlFocus design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.DesignTokens.AccentStrokeControlFocus>)>] () = inherit AccentStrokeControlFocusBuilder<Microsoft.Fast.Components.FluentUI.DesignTokens.AccentStrokeControlFocus>()

    /// The NeutralFillRest design token
    type NeutralFillRest' 
        /// The NeutralFillRest design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.DesignTokens.NeutralFillRest>)>] () = inherit NeutralFillRestBuilder<Microsoft.Fast.Components.FluentUI.DesignTokens.NeutralFillRest>()

    /// The NeutralFillHover design token
    type NeutralFillHover' 
        /// The NeutralFillHover design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.DesignTokens.NeutralFillHover>)>] () = inherit NeutralFillHoverBuilder<Microsoft.Fast.Components.FluentUI.DesignTokens.NeutralFillHover>()

    /// The NeutralFillActive design token
    type NeutralFillActive' 
        /// The NeutralFillActive design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.DesignTokens.NeutralFillActive>)>] () = inherit NeutralFillActiveBuilder<Microsoft.Fast.Components.FluentUI.DesignTokens.NeutralFillActive>()

    /// The NeutralFillFocus design token
    type NeutralFillFocus' 
        /// The NeutralFillFocus design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.DesignTokens.NeutralFillFocus>)>] () = inherit NeutralFillFocusBuilder<Microsoft.Fast.Components.FluentUI.DesignTokens.NeutralFillFocus>()

    /// The NeutralFillInputRest design token
    type NeutralFillInputRest' 
        /// The NeutralFillInputRest design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.DesignTokens.NeutralFillInputRest>)>] () = inherit NeutralFillInputRestBuilder<Microsoft.Fast.Components.FluentUI.DesignTokens.NeutralFillInputRest>()

    /// The NeutralFillInputHover design token
    type NeutralFillInputHover' 
        /// The NeutralFillInputHover design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.DesignTokens.NeutralFillInputHover>)>] () = inherit NeutralFillInputHoverBuilder<Microsoft.Fast.Components.FluentUI.DesignTokens.NeutralFillInputHover>()

    /// The NeutralFillInputActive design token
    type NeutralFillInputActive' 
        /// The NeutralFillInputActive design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.DesignTokens.NeutralFillInputActive>)>] () = inherit NeutralFillInputActiveBuilder<Microsoft.Fast.Components.FluentUI.DesignTokens.NeutralFillInputActive>()

    /// The NeutralFillInputFocus design token
    type NeutralFillInputFocus' 
        /// The NeutralFillInputFocus design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.DesignTokens.NeutralFillInputFocus>)>] () = inherit NeutralFillInputFocusBuilder<Microsoft.Fast.Components.FluentUI.DesignTokens.NeutralFillInputFocus>()

    /// The NeutralFillInputAltRest design token
    type NeutralFillInputAltRest' 
        /// The NeutralFillInputAltRest design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.DesignTokens.NeutralFillInputAltRest>)>] () = inherit NeutralFillInputAltRestBuilder<Microsoft.Fast.Components.FluentUI.DesignTokens.NeutralFillInputAltRest>()

    /// The NeutralFillInputAltHover design token
    type NeutralFillInputAltHover' 
        /// The NeutralFillInputAltHover design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.DesignTokens.NeutralFillInputAltHover>)>] () = inherit NeutralFillInputAltHoverBuilder<Microsoft.Fast.Components.FluentUI.DesignTokens.NeutralFillInputAltHover>()

    /// The NeutralFillInputAltActive design token
    type NeutralFillInputAltActive' 
        /// The NeutralFillInputAltActive design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.DesignTokens.NeutralFillInputAltActive>)>] () = inherit NeutralFillInputAltActiveBuilder<Microsoft.Fast.Components.FluentUI.DesignTokens.NeutralFillInputAltActive>()

    /// The NeutralFillInputAltFocus design token
    type NeutralFillInputAltFocus' 
        /// The NeutralFillInputAltFocus design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.DesignTokens.NeutralFillInputAltFocus>)>] () = inherit NeutralFillInputAltFocusBuilder<Microsoft.Fast.Components.FluentUI.DesignTokens.NeutralFillInputAltFocus>()

    /// The NeutralFillLayerRest design token
    type NeutralFillLayerRest' 
        /// The NeutralFillLayerRest design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.DesignTokens.NeutralFillLayerRest>)>] () = inherit NeutralFillLayerRestBuilder<Microsoft.Fast.Components.FluentUI.DesignTokens.NeutralFillLayerRest>()

    /// The NeutralFillLayerHover design token
    type NeutralFillLayerHover' 
        /// The NeutralFillLayerHover design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.DesignTokens.NeutralFillLayerHover>)>] () = inherit NeutralFillLayerHoverBuilder<Microsoft.Fast.Components.FluentUI.DesignTokens.NeutralFillLayerHover>()

    /// The NeutralFillLayerActive design token
    type NeutralFillLayerActive' 
        /// The NeutralFillLayerActive design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.DesignTokens.NeutralFillLayerActive>)>] () = inherit NeutralFillLayerActiveBuilder<Microsoft.Fast.Components.FluentUI.DesignTokens.NeutralFillLayerActive>()

    /// The NeutralFillLayerAltRest design token
    type NeutralFillLayerAltRest' 
        /// The NeutralFillLayerAltRest design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.DesignTokens.NeutralFillLayerAltRest>)>] () = inherit NeutralFillLayerAltRestBuilder<Microsoft.Fast.Components.FluentUI.DesignTokens.NeutralFillLayerAltRest>()

    /// The NeutralFillSecondaryRest design token
    type NeutralFillSecondaryRest' 
        /// The NeutralFillSecondaryRest design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.DesignTokens.NeutralFillSecondaryRest>)>] () = inherit NeutralFillSecondaryRestBuilder<Microsoft.Fast.Components.FluentUI.DesignTokens.NeutralFillSecondaryRest>()

    /// The NeutralFillSecondaryHover design token
    type NeutralFillSecondaryHover' 
        /// The NeutralFillSecondaryHover design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.DesignTokens.NeutralFillSecondaryHover>)>] () = inherit NeutralFillSecondaryHoverBuilder<Microsoft.Fast.Components.FluentUI.DesignTokens.NeutralFillSecondaryHover>()

    /// The NeutralFillSecondaryActive design token
    type NeutralFillSecondaryActive' 
        /// The NeutralFillSecondaryActive design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.DesignTokens.NeutralFillSecondaryActive>)>] () = inherit NeutralFillSecondaryActiveBuilder<Microsoft.Fast.Components.FluentUI.DesignTokens.NeutralFillSecondaryActive>()

    /// The NeutralFillSecondaryFocus design token
    type NeutralFillSecondaryFocus' 
        /// The NeutralFillSecondaryFocus design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.DesignTokens.NeutralFillSecondaryFocus>)>] () = inherit NeutralFillSecondaryFocusBuilder<Microsoft.Fast.Components.FluentUI.DesignTokens.NeutralFillSecondaryFocus>()

    /// The NeutralFillStealthRest design token
    type NeutralFillStealthRest' 
        /// The NeutralFillStealthRest design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.DesignTokens.NeutralFillStealthRest>)>] () = inherit NeutralFillStealthRestBuilder<Microsoft.Fast.Components.FluentUI.DesignTokens.NeutralFillStealthRest>()

    /// The NeutralFillStealthHover design token
    type NeutralFillStealthHover' 
        /// The NeutralFillStealthHover design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.DesignTokens.NeutralFillStealthHover>)>] () = inherit NeutralFillStealthHoverBuilder<Microsoft.Fast.Components.FluentUI.DesignTokens.NeutralFillStealthHover>()

    /// The NeutralFillStealthActive design token
    type NeutralFillStealthActive' 
        /// The NeutralFillStealthActive design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.DesignTokens.NeutralFillStealthActive>)>] () = inherit NeutralFillStealthActiveBuilder<Microsoft.Fast.Components.FluentUI.DesignTokens.NeutralFillStealthActive>()

    /// The NeutralFillStealthFocus design token
    type NeutralFillStealthFocus' 
        /// The NeutralFillStealthFocus design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.DesignTokens.NeutralFillStealthFocus>)>] () = inherit NeutralFillStealthFocusBuilder<Microsoft.Fast.Components.FluentUI.DesignTokens.NeutralFillStealthFocus>()

    /// The NeutralFillStrongRest design token
    type NeutralFillStrongRest' 
        /// The NeutralFillStrongRest design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.DesignTokens.NeutralFillStrongRest>)>] () = inherit NeutralFillStrongRestBuilder<Microsoft.Fast.Components.FluentUI.DesignTokens.NeutralFillStrongRest>()

    /// The NeutralFillStrongHover design token
    type NeutralFillStrongHover' 
        /// The NeutralFillStrongHover design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.DesignTokens.NeutralFillStrongHover>)>] () = inherit NeutralFillStrongHoverBuilder<Microsoft.Fast.Components.FluentUI.DesignTokens.NeutralFillStrongHover>()

    /// The NeutralFillStrongActive design token
    type NeutralFillStrongActive' 
        /// The NeutralFillStrongActive design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.DesignTokens.NeutralFillStrongActive>)>] () = inherit NeutralFillStrongActiveBuilder<Microsoft.Fast.Components.FluentUI.DesignTokens.NeutralFillStrongActive>()

    /// The NeutralFillStrongFocus design token
    type NeutralFillStrongFocus' 
        /// The NeutralFillStrongFocus design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.DesignTokens.NeutralFillStrongFocus>)>] () = inherit NeutralFillStrongFocusBuilder<Microsoft.Fast.Components.FluentUI.DesignTokens.NeutralFillStrongFocus>()

    /// The NeutralForegroundRest design token
    type NeutralForegroundRest' 
        /// The NeutralForegroundRest design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.DesignTokens.NeutralForegroundRest>)>] () = inherit NeutralForegroundRestBuilder<Microsoft.Fast.Components.FluentUI.DesignTokens.NeutralForegroundRest>()

    /// The NeutralForegroundHover design token
    type NeutralForegroundHover' 
        /// The NeutralForegroundHover design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.DesignTokens.NeutralForegroundHover>)>] () = inherit NeutralForegroundHoverBuilder<Microsoft.Fast.Components.FluentUI.DesignTokens.NeutralForegroundHover>()

    /// The NeutralForegroundActive design token
    type NeutralForegroundActive' 
        /// The NeutralForegroundActive design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.DesignTokens.NeutralForegroundActive>)>] () = inherit NeutralForegroundActiveBuilder<Microsoft.Fast.Components.FluentUI.DesignTokens.NeutralForegroundActive>()

    /// The NeutralForegroundFocus design token
    type NeutralForegroundFocus' 
        /// The NeutralForegroundFocus design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.DesignTokens.NeutralForegroundFocus>)>] () = inherit NeutralForegroundFocusBuilder<Microsoft.Fast.Components.FluentUI.DesignTokens.NeutralForegroundFocus>()

    /// The NeutralForegroundHint design token
    type NeutralForegroundHint' 
        /// The NeutralForegroundHint design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.DesignTokens.NeutralForegroundHint>)>] () = inherit NeutralForegroundHintBuilder<Microsoft.Fast.Components.FluentUI.DesignTokens.NeutralForegroundHint>()

    /// The NeutralStrokeRest design token
    type NeutralStrokeRest' 
        /// The NeutralStrokeRest design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.DesignTokens.NeutralStrokeRest>)>] () = inherit NeutralStrokeRestBuilder<Microsoft.Fast.Components.FluentUI.DesignTokens.NeutralStrokeRest>()

    /// The NeutralStrokeHover design token
    type NeutralStrokeHover' 
        /// The NeutralStrokeHover design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.DesignTokens.NeutralStrokeHover>)>] () = inherit NeutralStrokeHoverBuilder<Microsoft.Fast.Components.FluentUI.DesignTokens.NeutralStrokeHover>()

    /// The NeutralStrokeActive design token
    type NeutralStrokeActive' 
        /// The NeutralStrokeActive design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.DesignTokens.NeutralStrokeActive>)>] () = inherit NeutralStrokeActiveBuilder<Microsoft.Fast.Components.FluentUI.DesignTokens.NeutralStrokeActive>()

    /// The NeutralStrokeFocus design token
    type NeutralStrokeFocus' 
        /// The NeutralStrokeFocus design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.DesignTokens.NeutralStrokeFocus>)>] () = inherit NeutralStrokeFocusBuilder<Microsoft.Fast.Components.FluentUI.DesignTokens.NeutralStrokeFocus>()

    /// The NeutralStrokeControlRest design token
    type NeutralStrokeControlRest' 
        /// The NeutralStrokeControlRest design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.DesignTokens.NeutralStrokeControlRest>)>] () = inherit NeutralStrokeControlRestBuilder<Microsoft.Fast.Components.FluentUI.DesignTokens.NeutralStrokeControlRest>()

    /// The NeutralStrokeControlHover design token
    type NeutralStrokeControlHover' 
        /// The NeutralStrokeControlHover design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.DesignTokens.NeutralStrokeControlHover>)>] () = inherit NeutralStrokeControlHoverBuilder<Microsoft.Fast.Components.FluentUI.DesignTokens.NeutralStrokeControlHover>()

    /// The NeutralStrokeControlActive design token
    type NeutralStrokeControlActive' 
        /// The NeutralStrokeControlActive design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.DesignTokens.NeutralStrokeControlActive>)>] () = inherit NeutralStrokeControlActiveBuilder<Microsoft.Fast.Components.FluentUI.DesignTokens.NeutralStrokeControlActive>()

    /// The NeutralStrokeControlFocus design token
    type NeutralStrokeControlFocus' 
        /// The NeutralStrokeControlFocus design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.DesignTokens.NeutralStrokeControlFocus>)>] () = inherit NeutralStrokeControlFocusBuilder<Microsoft.Fast.Components.FluentUI.DesignTokens.NeutralStrokeControlFocus>()

    /// The NeutralStrokeDividerRest design token
    type NeutralStrokeDividerRest' 
        /// The NeutralStrokeDividerRest design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.DesignTokens.NeutralStrokeDividerRest>)>] () = inherit NeutralStrokeDividerRestBuilder<Microsoft.Fast.Components.FluentUI.DesignTokens.NeutralStrokeDividerRest>()

    /// The NeutralStrokeInputRest design token
    type NeutralStrokeInputRest' 
        /// The NeutralStrokeInputRest design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.DesignTokens.NeutralStrokeInputRest>)>] () = inherit NeutralStrokeInputRestBuilder<Microsoft.Fast.Components.FluentUI.DesignTokens.NeutralStrokeInputRest>()

    /// The NeutralStrokeInputHover design token
    type NeutralStrokeInputHover' 
        /// The NeutralStrokeInputHover design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.DesignTokens.NeutralStrokeInputHover>)>] () = inherit NeutralStrokeInputHoverBuilder<Microsoft.Fast.Components.FluentUI.DesignTokens.NeutralStrokeInputHover>()

    /// The NeutralStrokeInputActive design token
    type NeutralStrokeInputActive' 
        /// The NeutralStrokeInputActive design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.DesignTokens.NeutralStrokeInputActive>)>] () = inherit NeutralStrokeInputActiveBuilder<Microsoft.Fast.Components.FluentUI.DesignTokens.NeutralStrokeInputActive>()

    /// The NeutralStrokeInputFocus design token
    type NeutralStrokeInputFocus' 
        /// The NeutralStrokeInputFocus design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.DesignTokens.NeutralStrokeInputFocus>)>] () = inherit NeutralStrokeInputFocusBuilder<Microsoft.Fast.Components.FluentUI.DesignTokens.NeutralStrokeInputFocus>()

    /// The NeutralStrokeLayerRest design token
    type NeutralStrokeLayerRest' 
        /// The NeutralStrokeLayerRest design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.DesignTokens.NeutralStrokeLayerRest>)>] () = inherit NeutralStrokeLayerRestBuilder<Microsoft.Fast.Components.FluentUI.DesignTokens.NeutralStrokeLayerRest>()

    /// The NeutralStrokeLayerHover design token
    type NeutralStrokeLayerHover' 
        /// The NeutralStrokeLayerHover design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.DesignTokens.NeutralStrokeLayerHover>)>] () = inherit NeutralStrokeLayerHoverBuilder<Microsoft.Fast.Components.FluentUI.DesignTokens.NeutralStrokeLayerHover>()

    /// The NeutralStrokeLayerActive design token
    type NeutralStrokeLayerActive' 
        /// The NeutralStrokeLayerActive design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.DesignTokens.NeutralStrokeLayerActive>)>] () = inherit NeutralStrokeLayerActiveBuilder<Microsoft.Fast.Components.FluentUI.DesignTokens.NeutralStrokeLayerActive>()

    /// The NeutralStrokeStrongRest design token
    type NeutralStrokeStrongRest' 
        /// The NeutralStrokeStrongRest design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.DesignTokens.NeutralStrokeStrongRest>)>] () = inherit NeutralStrokeStrongRestBuilder<Microsoft.Fast.Components.FluentUI.DesignTokens.NeutralStrokeStrongRest>()

    /// The NeutralStrokeStrongHover design token
    type NeutralStrokeStrongHover' 
        /// The NeutralStrokeStrongHover design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.DesignTokens.NeutralStrokeStrongHover>)>] () = inherit NeutralStrokeStrongHoverBuilder<Microsoft.Fast.Components.FluentUI.DesignTokens.NeutralStrokeStrongHover>()

    /// The NeutralStrokeStrongActive design token
    type NeutralStrokeStrongActive' 
        /// The NeutralStrokeStrongActive design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.DesignTokens.NeutralStrokeStrongActive>)>] () = inherit NeutralStrokeStrongActiveBuilder<Microsoft.Fast.Components.FluentUI.DesignTokens.NeutralStrokeStrongActive>()

    /// The NeutralStrokeStrongFocus design token
    type NeutralStrokeStrongFocus' 
        /// The NeutralStrokeStrongFocus design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.DesignTokens.NeutralStrokeStrongFocus>)>] () = inherit NeutralStrokeStrongFocusBuilder<Microsoft.Fast.Components.FluentUI.DesignTokens.NeutralStrokeStrongFocus>()

    /// The FocusStrokeOuter design token
    type FocusStrokeOuter' 
        /// The FocusStrokeOuter design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.DesignTokens.FocusStrokeOuter>)>] () = inherit FocusStrokeOuterBuilder<Microsoft.Fast.Components.FluentUI.DesignTokens.FocusStrokeOuter>()

    /// The FocusStrokeInner design token
    type FocusStrokeInner' 
        /// The FocusStrokeInner design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.DesignTokens.FocusStrokeInner>)>] () = inherit FocusStrokeInnerBuilder<Microsoft.Fast.Components.FluentUI.DesignTokens.FocusStrokeInner>()
            
namespace Microsoft.Fast.Components.FluentUI.DataGrid.Infrastructure

[<AutoOpen>]
module DslCE =
  
    open System.Diagnostics.CodeAnalysis
    open Microsoft.Fast.Components.FluentUI.DslInternals.DataGrid.Infrastructure


    /// For internal use only. Do not use.
    type Defer' 
        /// For internal use only. Do not use.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.Fast.Components.FluentUI.DataGrid.Infrastructure.Defer>)>] () = inherit DeferBuilder<Microsoft.Fast.Components.FluentUI.DataGrid.Infrastructure.Defer>()
            