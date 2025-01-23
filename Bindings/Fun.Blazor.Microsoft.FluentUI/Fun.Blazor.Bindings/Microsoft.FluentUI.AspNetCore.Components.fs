namespace rec Microsoft.FluentUI.AspNetCore.Components.DslInternals

open System.Threading.Tasks
open FSharp.Data.Adaptive
open Fun.Blazor
open Fun.Blazor.Operators
open Microsoft.FluentUI.AspNetCore.Components.DslInternals

type FluentComponentBaseBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAndChildAttrBuilder<'FunBlazorGeneric>()
    /// Gets or sets the unique identifier.
    /// The value will be used as the HTML global id attribute.
    [<CustomOperation("Id")>] member inline _.Id ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Id" => x)
    /// Used to attach any user data object to the component.
    [<CustomOperation("Data")>] member inline _.Data ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Object) = render ==> ("Data" => x)
    /// A reference to the enclosing component.
    [<CustomOperation("ParentReference")>] member inline _.ParentReference ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.FluentUI.AspNetCore.Components.DesignTokens.Reference) = render ==> ("ParentReference" => x)
    /// Gets or sets a collection of additional attributes that will be applied to the created element.
    [<CustomOperation("AdditionalAttributes")>] member inline _.AdditionalAttributes ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.IReadOnlyDictionary<System.String, System.Object>) = render ==> ("AdditionalAttributes" => x)

/// Base class for FluentNavMenuGroup and FluentNavMenuItemBase.
type FluentNavMenuItemBaseBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentComponentBaseBuilder<'FunBlazorGeneric>()
    /// Gets or sets whether the link is disabled.
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Disabled" =>>> true)
    /// Gets or sets whether the link is disabled.
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Disabled" =>>> x)
    /// Gets or sets the destination of the link.
    [<CustomOperation("Href")>] member inline _.Href ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Href" => x)
    /// Gets or sets the icon to display with the link
    /// Use a constant value from the FluentIcon`1 class 
    [<CustomOperation("Icon")>] member inline _.Icon ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.FluentUI.AspNetCore.Components.Icon) = render ==> ("Icon" => x)
    /// Called when the user attempts to execute the default action of a menu item.
    [<CustomOperation("OnAction")>] member inline _.OnAction ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.FluentUI.AspNetCore.Components.NavMenuActionArgs -> unit) = render ==> html.callback("OnAction", fn)
    /// Called when the user attempts to execute the default action of a menu item.
    [<CustomOperation("OnAction")>] member inline _.OnAction ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.FluentUI.AspNetCore.Components.NavMenuActionArgs -> Task<unit>) = render ==> html.callbackTask("OnAction", fn)
    /// Gets or sets a value indicating whether the item is selected.
    [<CustomOperation("Selected")>] member inline _.Selected ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Selected" =>>> true)
    /// Gets or sets a value indicating whether the item is selected.
    [<CustomOperation("Selected")>] member inline _.Selected ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Selected" =>>> x)
    /// Gets or sets a value indicating whether the item is selected.
    [<CustomOperation("Selected'")>] member inline _.Selected' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.Boolean * (System.Boolean -> unit)) = render ==> html.bind("Selected", valueFn)
    /// Event callback for when Selected changes.
    [<CustomOperation("SelectedChanged")>] member inline _.SelectedChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Boolean -> unit) = render ==> html.callback("SelectedChanged", fn)
    /// Event callback for when Selected changes.
    [<CustomOperation("SelectedChanged")>] member inline _.SelectedChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Boolean -> Task<unit>) = render ==> html.callbackTask("SelectedChanged", fn)
    /// Gets or sets the text of the link.
    [<CustomOperation("Text")>] member inline _.Text ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Text" => x)
    /// Gets or sets the width of the link (in pixels).
    [<CustomOperation("Width")>] member inline _.Width ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Int32>) = render ==> ("Width" => x)

type FluentNavMenuGroupBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentNavMenuItemBaseBuilder<'FunBlazorGeneric>()
    /// Returns true if the group is expanded,
    /// and false if collapsed.
    [<CustomOperation("Expanded")>] member inline _.Expanded ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Expanded" =>>> true)
    /// Returns true if the group is expanded,
    /// and false if collapsed.
    [<CustomOperation("Expanded")>] member inline _.Expanded ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Expanded" =>>> x)
    /// Returns true if the group is expanded,
    /// and false if collapsed.
    [<CustomOperation("Expanded'")>] member inline _.Expanded' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.Boolean * (System.Boolean -> unit)) = render ==> html.bind("Expanded", valueFn)
    /// Gets or sets a callback that is triggered whenever Expanded changes.
    [<CustomOperation("ExpandedChanged")>] member inline _.ExpandedChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Boolean -> unit) = render ==> html.callback("ExpandedChanged", fn)
    /// Gets or sets a callback that is triggered whenever Expanded changes.
    [<CustomOperation("ExpandedChanged")>] member inline _.ExpandedChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Boolean -> Task<unit>) = render ==> html.callbackTask("ExpandedChanged", fn)
    /// If set to true then the tree will
    /// expand when it is created.
    [<CustomOperation("InitiallyExpanded")>] member inline _.InitiallyExpanded ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("InitiallyExpanded" =>>> true)
    /// If set to true then the tree will
    /// expand when it is created.
    [<CustomOperation("InitiallyExpanded")>] member inline _.InitiallyExpanded ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("InitiallyExpanded" =>>> x)

type FluentNavMenuLinkBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentNavMenuItemBaseBuilder<'FunBlazorGeneric>()


/// Base class for FluentNavGroup and FluentNavLink.
type FluentNavBaseBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentComponentBaseBuilder<'FunBlazorGeneric>()
    /// Gets or sets the URL for the group.
    [<CustomOperation("Href")>] member inline _.Href ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Href" => x)
    /// Gets or sets the target attribute that specifies where to open the group, if Href is specified.
    /// Possible values: _blank | _self | _parent | _top.
    [<CustomOperation("Target")>] member inline _.Target ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Target" => x)
    /// Gets or sets the Icon to use if set.
    [<CustomOperation("Icon")>] member inline _.Icon ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.FluentUI.AspNetCore.Components.Icon) = render ==> ("Icon" => x)
    /// Gets or sets the color of the icon.
    /// It supports the theme colors, default value uses the themes drawer icon color.
    [<CustomOperation("IconColor")>] member inline _.IconColor ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.FluentUI.AspNetCore.Components.Color) = render ==> ("IconColor" => x)
    /// Gets or sets the icon drawing and fill color to a custom value.
    /// Needs to be formatted as an HTML hex color string (#rrggbb or #rgb) or CSS variable.
    /// ⚠️ Only available when Color is set to Color.Custom.
    [<CustomOperation("CustomColor")>] member inline _.CustomColor ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("CustomColor" => x)
    /// If true, the button will be disabled.
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Disabled" =>>> true)
    /// If true, the button will be disabled.
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Disabled" =>>> x)
    /// Gets or sets the class names to use to indicate the item is active, separated by space.
    [<CustomOperation("ActiveClass")>] member inline _.ActiveClass ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("ActiveClass" => x)
    /// Gets or sets how the link should be matched.
    /// Defaults to Prefix.
    [<CustomOperation("Match")>] member inline _.Match ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.AspNetCore.Components.Routing.NavLinkMatch) = render ==> ("Match" => x)
    /// Gets or sets the tooltip to display when the mouse is placed over the item.
    /// For  FluentNavGroup the Title is used as fallback.
    [<CustomOperation("Tooltip")>] member inline _.Tooltip ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Tooltip" => x)
    /// The callback to invoke when the item is clicked.
    [<CustomOperation("OnClick")>] member inline _.OnClick ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.AspNetCore.Components.Web.MouseEventArgs -> unit) = render ==> html.callback("OnClick", fn)
    /// The callback to invoke when the item is clicked.
    [<CustomOperation("OnClick")>] member inline _.OnClick ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.AspNetCore.Components.Web.MouseEventArgs -> Task<unit>) = render ==> html.callbackTask("OnClick", fn)
    /// If true, force browser to redirect outside component router-space.
    [<CustomOperation("ForceLoad")>] member inline _.ForceLoad ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("ForceLoad" =>>> true)
    /// If true, force browser to redirect outside component router-space.
    [<CustomOperation("ForceLoad")>] member inline _.ForceLoad ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("ForceLoad" =>>> x)
    /// Gets or sets the id of the custom toggle element
    /// Defaults to navmenu-toggle
    [<CustomOperation("CustomToggleId")>] member inline _.CustomToggleId ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("CustomToggleId" => x)

type FluentNavGroupBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentNavBaseBuilder<'FunBlazorGeneric>()
    /// Gets or sets the text to display for the group.
    [<CustomOperation("Title")>] member inline _.Title ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Title" => x)
    /// If true, expands the nav group, otherwise collapse it.
    /// Two-way bindable
    [<CustomOperation("Expanded")>] member inline _.Expanded ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Expanded" =>>> true)
    /// If true, expands the nav group, otherwise collapse it.
    /// Two-way bindable
    [<CustomOperation("Expanded")>] member inline _.Expanded ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Expanded" =>>> x)
    /// If true, expands the nav group, otherwise collapse it.
    /// Two-way bindable
    [<CustomOperation("Expanded'")>] member inline _.Expanded' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.Boolean * (System.Boolean -> unit)) = render ==> html.bind("Expanded", valueFn)
    /// If true, hides expand button at the end of the NavGroup.
    [<CustomOperation("HideExpander")>] member inline _.HideExpander ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("HideExpander" =>>> true)
    /// If true, hides expand button at the end of the NavGroup.
    [<CustomOperation("HideExpander")>] member inline _.HideExpander ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("HideExpander" =>>> x)
    /// Explicitly sets the height for the Collapse element to override the css default.
    [<CustomOperation("MaxHeight")>] member inline _.MaxHeight ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("MaxHeight" => x)
    /// Defines the vertical spacing between the NavGroup and adjacent items.
    /// Needs to be a valid CSS value.
    [<CustomOperation("Gap")>] member inline _.Gap ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Gap" => x)
    /// If set, overrides the default expand icon.
    [<CustomOperation("ExpandIcon")>] member inline _.ExpandIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.FluentUI.AspNetCore.Components.Icon) = render ==> ("ExpandIcon" => x)
    /// Allows for specific markup and styling to be applied for the group title
    /// When using this, the contained FluentNavLinks and FluentNavGroups need to be placed in a ChildContent tag.
    /// When specifying both Title and TitleTemplate, both will be rendered.
    [<CustomOperation("TitleTemplate")>] member inline _.TitleTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragment: NodeRenderFragment) = render ==> html.renderFragment("TitleTemplate", fragment)
    /// Allows for specific markup and styling to be applied for the group title
    /// When using this, the contained FluentNavLinks and FluentNavGroups need to be placed in a ChildContent tag.
    /// When specifying both Title and TitleTemplate, both will be rendered.
    [<CustomOperation("TitleTemplate")>] member inline _.TitleTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragments: NodeRenderFragment seq) = render ==> html.renderFragment("TitleTemplate", fragment { yield! fragments })
    /// Allows for specific markup and styling to be applied for the group title
    /// When using this, the contained FluentNavLinks and FluentNavGroups need to be placed in a ChildContent tag.
    /// When specifying both Title and TitleTemplate, both will be rendered.
    [<CustomOperation("TitleTemplate")>] member inline _.TitleTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("TitleTemplate", html.text x)
    /// Allows for specific markup and styling to be applied for the group title
    /// When using this, the contained FluentNavLinks and FluentNavGroups need to be placed in a ChildContent tag.
    /// When specifying both Title and TitleTemplate, both will be rendered.
    [<CustomOperation("TitleTemplate")>] member inline _.TitleTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("TitleTemplate", html.text x)
    /// Allows for specific markup and styling to be applied for the group title
    /// When using this, the contained FluentNavLinks and FluentNavGroups need to be placed in a ChildContent tag.
    /// When specifying both Title and TitleTemplate, both will be rendered.
    [<CustomOperation("TitleTemplate")>] member inline _.TitleTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("TitleTemplate", html.text x)
    /// Gets or sets a callback that is triggered whenever Expanded changes.
    [<CustomOperation("ExpandedChanged")>] member inline _.ExpandedChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Boolean -> unit) = render ==> html.callback("ExpandedChanged", fn)
    /// Gets or sets a callback that is triggered whenever Expanded changes.
    [<CustomOperation("ExpandedChanged")>] member inline _.ExpandedChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Boolean -> Task<unit>) = render ==> html.callbackTask("ExpandedChanged", fn)

type FluentNavLinkBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentNavBaseBuilder<'FunBlazorGeneric>()


type FluentAccordionBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentComponentBaseBuilder<'FunBlazorGeneric>()
    /// Controls the expand mode of the Accordion, either allowing
    /// single or multiple item expansion. .
    [<CustomOperation("ExpandMode")>] member inline _.ExpandMode ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<Microsoft.FluentUI.AspNetCore.Components.AccordionExpandMode>) = render ==> ("ExpandMode" => x)
    /// Gets or sets the id of the active accordion item.
    [<CustomOperation("ActiveId")>] member inline _.ActiveId ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("ActiveId" => x)
    /// Gets or sets the id of the active accordion item.
    [<CustomOperation("ActiveId'")>] member inline _.ActiveId' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.String * (System.String -> unit)) = render ==> html.bind("ActiveId", valueFn)
    /// Gets or sets a callback that updates the bound value.
    [<CustomOperation("ActiveIdChanged")>] member inline _.ActiveIdChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.String -> unit) = render ==> html.callback("ActiveIdChanged", fn)
    /// Gets or sets a callback that updates the bound value.
    [<CustomOperation("ActiveIdChanged")>] member inline _.ActiveIdChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.String -> Task<unit>) = render ==> html.callbackTask("ActiveIdChanged", fn)
    /// Gets or sets a callback when a accordion item is changed.
    [<CustomOperation("OnAccordionItemChange")>] member inline _.OnAccordionItemChange ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.FluentUI.AspNetCore.Components.FluentAccordionItem -> unit) = render ==> html.callback("OnAccordionItemChange", fn)
    /// Gets or sets a callback when a accordion item is changed.
    [<CustomOperation("OnAccordionItemChange")>] member inline _.OnAccordionItemChange ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.FluentUI.AspNetCore.Components.FluentAccordionItem -> Task<unit>) = render ==> html.callbackTask("OnAccordionItemChange", fn)

type FluentAccordionItemBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentComponentBaseBuilder<'FunBlazorGeneric>()
    /// Gets or sets the heading of the accordion item.
    /// Use either this or the HeadingTemplate parameter."/>
    /// If both are set, this parameter will be used.
    [<CustomOperation("Heading")>] member inline _.Heading ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Heading" => x)
    /// Gets or sets the heading content of the accordion item.
    /// Use either this or the Heading parameter."/>
    /// If both are set, this parameter will not be used.
    [<CustomOperation("HeadingTemplate")>] member inline _.HeadingTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragment: NodeRenderFragment) = render ==> html.renderFragment("HeadingTemplate", fragment)
    /// Gets or sets the heading content of the accordion item.
    /// Use either this or the Heading parameter."/>
    /// If both are set, this parameter will not be used.
    [<CustomOperation("HeadingTemplate")>] member inline _.HeadingTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragments: NodeRenderFragment seq) = render ==> html.renderFragment("HeadingTemplate", fragment { yield! fragments })
    /// Gets or sets the heading content of the accordion item.
    /// Use either this or the Heading parameter."/>
    /// If both are set, this parameter will not be used.
    [<CustomOperation("HeadingTemplate")>] member inline _.HeadingTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("HeadingTemplate", html.text x)
    /// Gets or sets the heading content of the accordion item.
    /// Use either this or the Heading parameter."/>
    /// If both are set, this parameter will not be used.
    [<CustomOperation("HeadingTemplate")>] member inline _.HeadingTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("HeadingTemplate", html.text x)
    /// Gets or sets the heading content of the accordion item.
    /// Use either this or the Heading parameter."/>
    /// If both are set, this parameter will not be used.
    [<CustomOperation("HeadingTemplate")>] member inline _.HeadingTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("HeadingTemplate", html.text x)
    /// Gets or sets a value indicating whether the item is expanded or collapsed.
    [<CustomOperation("Expanded")>] member inline _.Expanded ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Expanded" =>>> true)
    /// Gets or sets a value indicating whether the item is expanded or collapsed.
    [<CustomOperation("Expanded")>] member inline _.Expanded ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Expanded" =>>> x)
    /// Gets or sets a value indicating whether the item is expanded or collapsed.
    [<CustomOperation("Expanded'")>] member inline _.Expanded' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.Boolean * (System.Boolean -> unit)) = render ==> html.bind("Expanded", valueFn)
    /// Gets or sets a callback for when the expanded state changes.
    [<CustomOperation("ExpandedChanged")>] member inline _.ExpandedChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Boolean -> unit) = render ==> html.callback("ExpandedChanged", fn)
    /// Gets or sets a callback for when the expanded state changes.
    [<CustomOperation("ExpandedChanged")>] member inline _.ExpandedChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Boolean -> Task<unit>) = render ==> html.callbackTask("ExpandedChanged", fn)
    /// Gets or sets the level of the heading element.
    /// Possible values: 1 | 2 | 3 | 4 | 5 | 6
    [<CustomOperation("HeadingLevel")>] member inline _.HeadingLevel ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("HeadingLevel" => x)

type FluentAnchoredRegionBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentComponentBaseBuilder<'FunBlazorGeneric>()
    /// Gets or sets the HTML ID of the anchor element this region is positioned relative to.
    /// This must be set for the component positioning logic to be active.
    [<CustomOperation("Anchor")>] member inline _.Anchor ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Anchor" => x)
    /// Gets or sets the HTML ID of the viewport element this region is positioned relative to.
    /// If unset the parent element of the anchored region is used.
    [<CustomOperation("Viewport")>] member inline _.Viewport ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Viewport" => x)
    /// Sets what logic the component uses to determine horizontal placement.
    /// Locktodefault forces the default position.
    /// Dynamic decides placement based on available space.
    /// Uncontrolled (default) does not control placement on the horizontal axis.
    /// See 
    [<CustomOperation("HorizontalPositioningMode")>] member inline _.HorizontalPositioningMode ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<Microsoft.FluentUI.AspNetCore.Components.AxisPositioningMode>) = render ==> ("HorizontalPositioningMode" => x)
    /// Gets or sets the default horizontal position of the region relative to the anchor element.
    /// Default is unset. See 
    [<CustomOperation("HorizontalDefaultPosition")>] member inline _.HorizontalDefaultPosition ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<Microsoft.FluentUI.AspNetCore.Components.HorizontalPosition>) = render ==> ("HorizontalDefaultPosition" => x)
    /// Gets or sets a value indicating whether the region remains in the viewport (ie. detaches from the anchor) on the horizontal axis.
    [<CustomOperation("HorizontalViewportLock")>] member inline _.HorizontalViewportLock ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("HorizontalViewportLock" =>>> true)
    /// Gets or sets a value indicating whether the region remains in the viewport (ie. detaches from the anchor) on the horizontal axis.
    [<CustomOperation("HorizontalViewportLock")>] member inline _.HorizontalViewportLock ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("HorizontalViewportLock" =>>> x)
    /// Gets or sets a value indicating whether the region overlaps the anchor on the horizontal axis. 
    /// Default is false which places the region adjacent to the anchor element.
    [<CustomOperation("HorizontalInset")>] member inline _.HorizontalInset ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("HorizontalInset" =>>> true)
    /// Gets or sets a value indicating whether the region overlaps the anchor on the horizontal axis. 
    /// Default is false which places the region adjacent to the anchor element.
    [<CustomOperation("HorizontalInset")>] member inline _.HorizontalInset ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("HorizontalInset" =>>> x)
    /// How narrow the space allocated to the default position has to be before the widest area is selected for layout.
    [<CustomOperation("HorizontalThreshold")>] member inline _.HorizontalThreshold ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("HorizontalThreshold" => x)
    /// Defines how the width of the region is calculated.
    /// Default is "Content". See 
    [<CustomOperation("HorizontalScaling")>] member inline _.HorizontalScaling ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<Microsoft.FluentUI.AspNetCore.Components.AxisScalingMode>) = render ==> ("HorizontalScaling" => x)
    /// Sets what logic the component uses to determine vertical placement.
    /// Locktodefault forces the default position.
    /// Dynamic decides placement based on available space.
    /// Uncontrolled (default) does not control placement on the vertical axis.
    /// See 
    [<CustomOperation("VerticalPositioningMode")>] member inline _.VerticalPositioningMode ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<Microsoft.FluentUI.AspNetCore.Components.AxisPositioningMode>) = render ==> ("VerticalPositioningMode" => x)
    /// Gets or sets the default vertical position of the region relative to the anchor element.
    /// Default is "Unset".See 
    [<CustomOperation("VerticalDefaultPosition")>] member inline _.VerticalDefaultPosition ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<Microsoft.FluentUI.AspNetCore.Components.VerticalPosition>) = render ==> ("VerticalDefaultPosition" => x)
    /// Gets or sets a value indicating whether the region remains in the viewport (ie. detaches from the anchor) on the vertical axis.
    [<CustomOperation("VerticalViewportLock")>] member inline _.VerticalViewportLock ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Boolean>) = render ==> ("VerticalViewportLock" => x)
    /// Gets or sets a value indicating whether the region overlaps the anchor on the vertical axis.
    [<CustomOperation("VerticalInset")>] member inline _.VerticalInset ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("VerticalInset" =>>> true)
    /// Gets or sets a value indicating whether the region overlaps the anchor on the vertical axis.
    [<CustomOperation("VerticalInset")>] member inline _.VerticalInset ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("VerticalInset" =>>> x)
    /// How short the space allocated to the default position has to be before the tallest area
    /// is selected for layout.
    [<CustomOperation("VerticalThreshold")>] member inline _.VerticalThreshold ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("VerticalThreshold" => x)
    /// Defines how the height of the region is calculated.
    /// Default is "Content". See 
    [<CustomOperation("VerticalScaling")>] member inline _.VerticalScaling ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<Microsoft.FluentUI.AspNetCore.Components.AxisScalingMode>) = render ==> ("VerticalScaling" => x)
    /// Gets or sets a value indicating whether the region is positioned using css "position: fixed".
    /// Otherwise the region uses "position: absolute".
    /// Fixed placement allows the region to break out of parent containers.
    [<CustomOperation("FixedPlacement")>] member inline _.FixedPlacement ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Boolean>) = render ==> ("FixedPlacement" => x)
    /// Defines what triggers the anchored region to revaluate positioning.
    /// Default is "Anchor". 
    /// In 'anchor' mode only anchor resizes and attribute changes will provoke an update. 
    /// In 'auto' mode the component also updates because of - any scroll event on the document, window resizes and viewport resizes. See 
    [<CustomOperation("AutoUpdateMode")>] member inline _.AutoUpdateMode ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<Microsoft.FluentUI.AspNetCore.Components.AutoUpdateMode>) = render ==> ("AutoUpdateMode" => x)
    [<CustomOperation("Shadow")>] member inline _.Shadow ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.FluentUI.AspNetCore.Components.ElevationShadow) = render ==> ("Shadow" => x)
    /// Gets or sets whether the element should receive the focus when the component is loaded.
    [<CustomOperation("AutoFocus")>] member inline _.AutoFocus ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("AutoFocus" =>>> true)
    /// Gets or sets whether the element should receive the focus when the component is loaded.
    [<CustomOperation("AutoFocus")>] member inline _.AutoFocus ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("AutoFocus" =>>> x)

type FluentAnchorBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentComponentBaseBuilder<'FunBlazorGeneric>()
    /// Prompts the user to save the linked URL. See a element for more information.
    [<CustomOperation("Download")>] member inline _.Download ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Download" => x)
    /// Gets or sets the URL the hyperlink references. See a element for more information.
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
    /// Gets or sets the target attribute that specifies where to open the link, if Href is specified.
    /// Possible values: _blank | _self | _parent | _top.
    [<CustomOperation("Target")>] member inline _.Target ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Target" => x)
    /// See a element for more information.
    [<CustomOperation("Type")>] member inline _.Type ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Type" => x)
    /// Gets or sets the visual appearance. See 
    /// Defaults to 
    [<CustomOperation("Appearance")>] member inline _.Appearance ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<Microsoft.FluentUI.AspNetCore.Components.Appearance>) = render ==> ("Appearance" => x)
    /// Gets or sets the Icon displayed at the start of anchor content.
    [<CustomOperation("IconStart")>] member inline _.IconStart ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.FluentUI.AspNetCore.Components.Icon) = render ==> ("IconStart" => x)
    /// Gets or sets the Icon displayed at the end of anchor content.
    [<CustomOperation("IconEnd")>] member inline _.IconEnd ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.FluentUI.AspNetCore.Components.Icon) = render ==> ("IconEnd" => x)
    [<CustomOperation("OnClick")>] member inline _.OnClick ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: unit -> unit) = render ==> html.callback("OnClick", fn)
    [<CustomOperation("OnClick")>] member inline _.OnClick ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: unit -> Task<unit>) = render ==> html.callbackTask("OnClick", fn)

type FluentAppBarBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentComponentBaseBuilder<'FunBlazorGeneric>()
    /// Gets or sets if the popover shows the search box.
    [<CustomOperation("PopoverShowSearch")>] member inline _.PopoverShowSearch ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("PopoverShowSearch" =>>> true)
    /// Gets or sets if the popover shows the search box.
    [<CustomOperation("PopoverShowSearch")>] member inline _.PopoverShowSearch ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("PopoverShowSearch" =>>> x)
    /// Gets or sets the Orientation of the app bar.
    [<CustomOperation("Orientation")>] member inline _.Orientation ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.FluentUI.AspNetCore.Components.Orientation) = render ==> ("Orientation" => x)
    /// Event to be called when the visibility of the popover changes.
    [<CustomOperation("PopoverVisibilityChanged")>] member inline _.PopoverVisibilityChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Boolean -> unit) = render ==> html.callback("PopoverVisibilityChanged", fn)
    /// Event to be called when the visibility of the popover changes.
    [<CustomOperation("PopoverVisibilityChanged")>] member inline _.PopoverVisibilityChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Boolean -> Task<unit>) = render ==> html.callbackTask("PopoverVisibilityChanged", fn)
    /// Gets or sets the collections of app bar items.
    /// Use eiter this or ChildContent to define the content of the app bar.
    [<CustomOperation("Items")>] member inline _.Items ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.IEnumerable<Microsoft.FluentUI.AspNetCore.Components.IAppBarItem>) = render ==> ("Items" => x)

type FluentAppBarItemBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentComponentBaseBuilder<'FunBlazorGeneric>()
    /// Gets or sets the URL for this item.
    [<CustomOperation("Href")>] member inline _.Href ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Href" => x)
    /// Gets or sets how the link should be matched.
    /// Defaults to Prefix.
    [<CustomOperation("Match")>] member inline _.Match ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.AspNetCore.Components.Routing.NavLinkMatch) = render ==> ("Match" => x)
    /// Gets or sets the Icon to use when the item is not hovered/selected/active.
    [<CustomOperation("IconRest")>] member inline _.IconRest ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.FluentUI.AspNetCore.Components.Icon) = render ==> ("IconRest" => x)
    /// Gets or sets the Icon to use when the item is hovered/selected/active.
    [<CustomOperation("IconActive")>] member inline _.IconActive ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.FluentUI.AspNetCore.Components.Icon) = render ==> ("IconActive" => x)
    /// Gets or sets the text to show under the icon.
    [<CustomOperation("Text")>] member inline _.Text ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Text" => x)
    /// Gets or sets the tooltip to show when the item is hovered.
    [<CustomOperation("Tooltip")>] member inline _.Tooltip ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Tooltip" => x)
    /// Gets or sets the count to show on the item with a FluentCounterBadge.
    [<CustomOperation("Count")>] member inline _.Count ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Int32>) = render ==> ("Count" => x)
    /// The callback to invoke when the item is clicked.
    [<CustomOperation("OnClick")>] member inline _.OnClick ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.FluentUI.AspNetCore.Components.IAppBarItem -> unit) = render ==> html.callback("OnClick", fn)
    /// The callback to invoke when the item is clicked.
    [<CustomOperation("OnClick")>] member inline _.OnClick ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.FluentUI.AspNetCore.Components.IAppBarItem -> Task<unit>) = render ==> html.callbackTask("OnClick", fn)

type FluentBadgeBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentComponentBaseBuilder<'FunBlazorGeneric>()
    /// Gets or sets the color.
    [<CustomOperation("Color")>] member inline _.Color ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Color" => x)
    /// Gets or sets the background color.
    [<CustomOperation("BackgroundColor")>] member inline _.BackgroundColor ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("BackgroundColor" => x)
    /// Gets or sets the background color based on fill value.
    [<CustomOperation("Fill")>] member inline _.Fill ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Fill" => x)
    /// Gets or sets a value indicating whether the badge is rendered circular.
    [<CustomOperation("Circular")>] member inline _.Circular ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Circular" =>>> true)
    /// Gets or sets a value indicating whether the badge is rendered circular.
    [<CustomOperation("Circular")>] member inline _.Circular ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Circular" =>>> x)
    /// Gets or sets the visual appearance. See 
    /// Possible values are Accent, Neutral (default) or Lightweight
    [<CustomOperation("Appearance")>] member inline _.Appearance ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<Microsoft.FluentUI.AspNetCore.Components.Appearance>) = render ==> ("Appearance" => x)
    /// Gets or sets the width of the component.
    [<CustomOperation("Width")>] member inline _.Width ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Width" => x)
    /// Gets or sets the height of the component.
    [<CustomOperation("Height")>] member inline _.Height ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Height" => x)
    /// Gets or sets the tooltip to display when hovering over the DismissIcon icon.
    [<CustomOperation("DismissTitle")>] member inline _.DismissTitle ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("DismissTitle" => x)
    /// Gets or sets the icon to be displayed when the badge is cancellable.
    /// By default, a small cross icon is displayed.
    [<CustomOperation("DismissIcon")>] member inline _.DismissIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.FluentUI.AspNetCore.Components.Icon) = render ==> ("DismissIcon" => x)
    /// Event callback for when the badge is clicked.
    [<CustomOperation("OnClick")>] member inline _.OnClick ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.AspNetCore.Components.Web.MouseEventArgs -> unit) = render ==> html.callback("OnClick", fn)
    /// Event callback for when the badge is clicked.
    [<CustomOperation("OnClick")>] member inline _.OnClick ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.AspNetCore.Components.Web.MouseEventArgs -> Task<unit>) = render ==> html.callbackTask("OnClick", fn)
    /// Event callback for when the badge DismissIcon icon is clicked.
    [<CustomOperation("OnDismissClick")>] member inline _.OnDismissClick ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.AspNetCore.Components.Web.MouseEventArgs -> unit) = render ==> html.callback("OnDismissClick", fn)
    /// Event callback for when the badge DismissIcon icon is clicked.
    [<CustomOperation("OnDismissClick")>] member inline _.OnDismissClick ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.AspNetCore.Components.Web.MouseEventArgs -> Task<unit>) = render ==> html.callbackTask("OnDismissClick", fn)

/// A base class for fluent ui form input components. This base class automatically
/// integrates with an EditContext, which must be supplied
/// as a cascading parameter.
type FluentInputBaseBuilder<'FunBlazorGeneric, 'TValue when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentComponentBaseBuilder<'FunBlazorGeneric>()
    /// When true, the control will be immutable by user interaction. readonly HTML attribute for more information.
    [<CustomOperation("ReadOnly")>] member inline _.ReadOnly ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("ReadOnly" =>>> true)
    /// When true, the control will be immutable by user interaction. readonly HTML attribute for more information.
    [<CustomOperation("ReadOnly")>] member inline _.ReadOnly ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("ReadOnly" =>>> x)
    /// Disables the form control, ensuring it doesn't participate in form submission.
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Disabled" =>>> true)
    /// Disables the form control, ensuring it doesn't participate in form submission.
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Disabled" =>>> x)
    /// Gets or sets the name of the element.
    /// Allows access by name from the associated form.
    /// ⚠️ This value needs to be set manually for SSR scenarios to work correctly.
    [<CustomOperation("Name")>] member inline _.Name ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Name" => x)
    /// Gets or sets the text to label the input.
    /// This is usually displayed just above the input
    [<CustomOperation("Label")>] member inline _.Label ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Label" => x)
    /// Gets or sets the content to label the input component.
    /// This is usually displayed just above the input
    [<CustomOperation("LabelTemplate")>] member inline _.LabelTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragment: NodeRenderFragment) = render ==> html.renderFragment("LabelTemplate", fragment)
    /// Gets or sets the content to label the input component.
    /// This is usually displayed just above the input
    [<CustomOperation("LabelTemplate")>] member inline _.LabelTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragments: NodeRenderFragment seq) = render ==> html.renderFragment("LabelTemplate", fragment { yield! fragments })
    /// Gets or sets the content to label the input component.
    /// This is usually displayed just above the input
    [<CustomOperation("LabelTemplate")>] member inline _.LabelTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("LabelTemplate", html.text x)
    /// Gets or sets the content to label the input component.
    /// This is usually displayed just above the input
    [<CustomOperation("LabelTemplate")>] member inline _.LabelTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("LabelTemplate", html.text x)
    /// Gets or sets the content to label the input component.
    /// This is usually displayed just above the input
    [<CustomOperation("LabelTemplate")>] member inline _.LabelTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("LabelTemplate", html.text x)
    /// Gets or sets the text used on aria-label attribute.
    [<CustomOperation("AriaLabel")>] member inline _.AriaLabel ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("AriaLabel" => x)
    /// Gets or sets a value indicating whether the element needs to have a value.
    [<CustomOperation("Required")>] member inline _.Required ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Required" =>>> true)
    /// Gets or sets a value indicating whether the element needs to have a value.
    [<CustomOperation("Required")>] member inline _.Required ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Required" =>>> x)
    /// Gets or sets the value of the input. This should be used with two-way binding.
    [<CustomOperation("Value")>] member inline _.Value ([<InlineIfLambda>] render: AttrRenderFragment, x: 'TValue) = render ==> ("Value" => x)
    /// Gets or sets the value of the input. This should be used with two-way binding.
    [<CustomOperation("Value'")>] member inline _.Value' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: 'TValue * ('TValue -> unit)) = render ==> html.bind("Value", valueFn)
    /// Gets or sets a callback that updates the bound value.
    [<CustomOperation("ValueChanged")>] member inline _.ValueChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: 'TValue -> unit) = render ==> html.callback("ValueChanged", fn)
    /// Gets or sets a callback that updates the bound value.
    [<CustomOperation("ValueChanged")>] member inline _.ValueChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: 'TValue -> Task<unit>) = render ==> html.callbackTask("ValueChanged", fn)
    /// Gets or sets an expression that identifies the bound value.
    [<CustomOperation("ValueExpression")>] member inline _.ValueExpression ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Linq.Expressions.Expression<System.Func<'TValue>>) = render ==> ("ValueExpression" => x)
    /// Gets or sets the FieldIdentifier that identifies the bound value.
    /// If set, this parameter takes precedence over ValueExpression.
    [<CustomOperation("Field")>] member inline _.Field ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<Microsoft.AspNetCore.Components.Forms.FieldIdentifier>) = render ==> ("Field" => x)
    /// Gets or sets the display name for this field.
    /// This value is used when generating error messages when the input value fails to parse correctly.
    [<CustomOperation("DisplayName")>] member inline _.DisplayName ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("DisplayName" => x)
    /// Determines if the element should receive document focus on page load.
    [<CustomOperation("Autofocus")>] member inline _.Autofocus ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Autofocus" =>>> true)
    /// Determines if the element should receive document focus on page load.
    [<CustomOperation("Autofocus")>] member inline _.Autofocus ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Autofocus" =>>> x)
    /// Gets or sets the short hint displayed in the input before the user enters a value.
    [<CustomOperation("Placeholder")>] member inline _.Placeholder ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Placeholder" => x)
    /// Gets or sets if the derived component is embedded in another component.
    /// If true, the ClassValue property will not include the EditContext's FieldCssClass.
    [<CustomOperation("Embedded")>] member inline _.Embedded ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Embedded" =>>> true)
    /// Gets or sets if the derived component is embedded in another component.
    /// If true, the ClassValue property will not include the EditContext's FieldCssClass.
    [<CustomOperation("Embedded")>] member inline _.Embedded ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Embedded" =>>> x)
    /// Change the content of this input field when the user write text (based on 'OnInput' HTML event).
    [<CustomOperation("Immediate")>] member inline _.Immediate ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Immediate" =>>> true)
    /// Change the content of this input field when the user write text (based on 'OnInput' HTML event).
    [<CustomOperation("Immediate")>] member inline _.Immediate ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Immediate" =>>> x)
    /// Gets or sets the delay, in milliseconds, before to raise the ValueChanged event.
    [<CustomOperation("ImmediateDelay")>] member inline _.ImmediateDelay ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("ImmediateDelay" => x)

type FluentCalendarBaseBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentInputBaseBuilder<'FunBlazorGeneric, System.Nullable<System.DateTime>>()
    /// Gets or sets the culture of the component.
    /// By default CurrentCulture to display using the OS culture.
    [<CustomOperation("Culture")>] member inline _.Culture ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Globalization.CultureInfo) = render ==> ("Culture" => x)
    /// Function to know if a specific day must be disabled.
    [<CustomOperation("DisabledDateFunc")>] member inline _.DisabledDateFunc ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("DisabledDateFunc" => (System.Func<System.DateTime, System.Boolean>fn))
    /// Apply the disabled style to the DisabledDateFunc days.
    /// If this is not the case, the days are displayed like the others, but cannot be selected.
    [<CustomOperation("DisabledSelectable")>] member inline _.DisabledSelectable ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("DisabledSelectable" =>>> true)
    /// Apply the disabled style to the DisabledDateFunc days.
    /// If this is not the case, the days are displayed like the others, but cannot be selected.
    [<CustomOperation("DisabledSelectable")>] member inline _.DisabledSelectable ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("DisabledSelectable" =>>> x)
    /// Gets or sets the Type style for the day (numeric or 2-digits).
    [<CustomOperation("DayFormat")>] member inline _.DayFormat ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<Microsoft.FluentUI.AspNetCore.Components.DayFormat>) = render ==> ("DayFormat" => x)
    /// Gets or sets the verification to do when the selected value has changed.
    /// By default, ValueChanged is called only if the selected value has changed.
    [<CustomOperation("CheckIfSelectedValueHasChanged")>] member inline _.CheckIfSelectedValueHasChanged ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("CheckIfSelectedValueHasChanged" =>>> true)
    /// Gets or sets the verification to do when the selected value has changed.
    /// By default, ValueChanged is called only if the selected value has changed.
    [<CustomOperation("CheckIfSelectedValueHasChanged")>] member inline _.CheckIfSelectedValueHasChanged ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("CheckIfSelectedValueHasChanged" =>>> x)
    /// Defines the appearance of the FluentCalendar component.
    [<CustomOperation("View")>] member inline _.View ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.FluentUI.AspNetCore.Components.CalendarViews) = render ==> ("View" => x)

/// Fluent Calendar based on
/// https://github.com/microsoft/fluentui/blob/master/packages/web-components/src/calendar/.
type FluentCalendarBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentCalendarBaseBuilder<'FunBlazorGeneric>()
    /// Gets or sets the current month of the date picker (two-way bindable).
    /// This changes when the user browses through the calendar.
    /// The month is represented as a DateTime which is always the first day of that month.
    /// You can also set this to determine which month is displayed first.
    /// If not set, the current month is displayed.
    [<CustomOperation("PickerMonth")>] member inline _.PickerMonth ([<InlineIfLambda>] render: AttrRenderFragment, x: System.DateTime) = render ==> ("PickerMonth" => x)
    /// Gets or sets the current month of the date picker (two-way bindable).
    /// This changes when the user browses through the calendar.
    /// The month is represented as a DateTime which is always the first day of that month.
    /// You can also set this to determine which month is displayed first.
    /// If not set, the current month is displayed.
    [<CustomOperation("PickerMonth'")>] member inline _.PickerMonth' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.DateTime * (System.DateTime -> unit)) = render ==> html.bind("PickerMonth", valueFn)
    /// Fired when the display month changes.
    [<CustomOperation("PickerMonthChanged")>] member inline _.PickerMonthChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.DateTime -> unit) = render ==> html.callback("PickerMonthChanged", fn)
    /// Fired when the display month changes.
    [<CustomOperation("PickerMonthChanged")>] member inline _.PickerMonthChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.DateTime -> Task<unit>) = render ==> html.callbackTask("PickerMonthChanged", fn)
    /// Defines the appearance of a Day cell.
    [<CustomOperation("DaysTemplate")>] member inline _.DaysTemplate ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.FluentUI.AspNetCore.Components.FluentCalendarDay -> NodeRenderFragment) = render ==> html.renderFragment("DaysTemplate", fn)
    /// Gets ot sets if the calendar items are animated during a period change.
    /// By default, the animation is enabled for Months views, but disabled for Days and Years view.
    [<CustomOperation("AnimatePeriodChanges")>] member inline _.AnimatePeriodChanges ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Boolean>) = render ==> ("AnimatePeriodChanges" => x)
    /// Gets or sets the way the user can select one or more dates
    [<CustomOperation("SelectMode")>] member inline _.SelectMode ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.FluentUI.AspNetCore.Components.CalendarSelectMode) = render ==> ("SelectMode" => x)
    /// Gets or sets the list of all selected dates, only when SelectMode is set to Range or Multiple.
    [<CustomOperation("SelectedDates")>] member inline _.SelectedDates ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.IEnumerable<System.DateTime>) = render ==> ("SelectedDates" => x)
    /// Gets or sets the list of all selected dates, only when SelectMode is set to Range or Multiple.
    [<CustomOperation("SelectedDates'")>] member inline _.SelectedDates' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.Collections.Generic.IEnumerable<System.DateTime> * (System.Collections.Generic.IEnumerable<System.DateTime> -> unit)) = render ==> html.bind("SelectedDates", valueFn)
    /// Fired when the selected dates change.
    [<CustomOperation("SelectedDatesChanged")>] member inline _.SelectedDatesChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Collections.Generic.IEnumerable<System.DateTime> -> unit) = render ==> html.callback("SelectedDatesChanged", fn)
    /// Fired when the selected dates change.
    [<CustomOperation("SelectedDatesChanged")>] member inline _.SelectedDatesChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Collections.Generic.IEnumerable<System.DateTime> -> Task<unit>) = render ==> html.callbackTask("SelectedDatesChanged", fn)
    /// Fired when the selected mouse over change, to display the future range of dates.
    [<CustomOperation("SelectDatesHover")>] member inline _.SelectDatesHover ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("SelectDatesHover" => (System.Func<System.DateTime, System.Collections.Generic.IEnumerable<System.DateTime>>fn))

type FluentDatePickerBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentCalendarBaseBuilder<'FunBlazorGeneric>()
    /// Gets or sets the design of this input.
    [<CustomOperation("Appearance")>] member inline _.Appearance ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.FluentUI.AspNetCore.Components.FluentInputAppearance) = render ==> ("Appearance" => x)
    /// raised when calendar popup opened
    [<CustomOperation("OnCalendarOpen")>] member inline _.OnCalendarOpen ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Boolean -> unit) = render ==> html.callback("OnCalendarOpen", fn)
    /// raised when calendar popup opened
    [<CustomOperation("OnCalendarOpen")>] member inline _.OnCalendarOpen ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Boolean -> Task<unit>) = render ==> html.callbackTask("OnCalendarOpen", fn)
    /// Defines the appearance of a Day cell.
    [<CustomOperation("DaysTemplate")>] member inline _.DaysTemplate ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.FluentUI.AspNetCore.Components.FluentCalendarDay -> NodeRenderFragment) = render ==> html.renderFragment("DaysTemplate", fn)
    /// Fired when the display month changes.
    [<CustomOperation("PickerMonthChanged")>] member inline _.PickerMonthChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.DateTime -> unit) = render ==> html.callback("PickerMonthChanged", fn)
    /// Fired when the display month changes.
    [<CustomOperation("PickerMonthChanged")>] member inline _.PickerMonthChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.DateTime -> Task<unit>) = render ==> html.callbackTask("PickerMonthChanged", fn)
    /// Command executed when the user double-clicks on the date picker.
    [<CustomOperation("OnDoubleClick")>] member inline _.OnDoubleClick ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.AspNetCore.Components.Web.MouseEventArgs -> unit) = render ==> html.callback("OnDoubleClick", fn)
    /// Command executed when the user double-clicks on the date picker.
    [<CustomOperation("OnDoubleClick")>] member inline _.OnDoubleClick ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.AspNetCore.Components.Web.MouseEventArgs -> Task<unit>) = render ==> html.callbackTask("OnDoubleClick", fn)
    /// Gets or sets a value which will be set when double-clicking on the text field of date picker.
    [<CustomOperation("DoubleClickToDate")>] member inline _.DoubleClickToDate ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.DateTime>) = render ==> ("DoubleClickToDate" => x)
    /// Gets or sets an HorizontalPosition for the popup displayed when the user open the calendar.
    /// By default, this value is Left or Right, depending of the 'CurrentUICulture.TextInfo.IsRightToLeft' value.
    [<CustomOperation("PopupHorizontalPosition")>] member inline _.PopupHorizontalPosition ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<Microsoft.FluentUI.AspNetCore.Components.HorizontalPosition>) = render ==> ("PopupHorizontalPosition" => x)

type FluentCheckboxBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentInputBaseBuilder<'FunBlazorGeneric, System.Boolean>()
    /// Gets or sets a value indicating whether the CheckBox will allow three check states rather than two.
    [<CustomOperation("ThreeState")>] member inline _.ThreeState ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("ThreeState" =>>> true)
    /// Gets or sets a value indicating whether the CheckBox will allow three check states rather than two.
    [<CustomOperation("ThreeState")>] member inline _.ThreeState ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("ThreeState" =>>> x)
    /// Gets or sets a value indicating the order of the three states of the CheckBox.
    /// False (by default), the order is Unchecked -> Checked -> Intermediate.
    /// True: the order is Unchecked -> Intermediate -> Checked.
    [<CustomOperation("ThreeStateOrderUncheckToIntermediate")>] member inline _.ThreeStateOrderUncheckToIntermediate ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("ThreeStateOrderUncheckToIntermediate" =>>> true)
    /// Gets or sets a value indicating the order of the three states of the CheckBox.
    /// False (by default), the order is Unchecked -> Checked -> Intermediate.
    /// True: the order is Unchecked -> Intermediate -> Checked.
    [<CustomOperation("ThreeStateOrderUncheckToIntermediate")>] member inline _.ThreeStateOrderUncheckToIntermediate ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("ThreeStateOrderUncheckToIntermediate" =>>> x)
    /// Gets or sets a value indicating whether the user can display the indeterminate state by clicking the CheckBox.
    /// If this is not the case, the checkbox can be started in the indeterminate state, but the user cannot activate it with the mouse.
    /// Default is true.
    [<CustomOperation("ShowIndeterminate")>] member inline _.ShowIndeterminate ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("ShowIndeterminate" =>>> true)
    /// Gets or sets a value indicating whether the user can display the indeterminate state by clicking the CheckBox.
    /// If this is not the case, the checkbox can be started in the indeterminate state, but the user cannot activate it with the mouse.
    /// Default is true.
    [<CustomOperation("ShowIndeterminate")>] member inline _.ShowIndeterminate ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("ShowIndeterminate" =>>> x)
    /// Gets or sets the state of the CheckBox: true, false or null.
    [<CustomOperation("CheckState")>] member inline _.CheckState ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Boolean>) = render ==> ("CheckState" => x)
    /// Gets or sets the state of the CheckBox: true, false or null.
    [<CustomOperation("CheckState'")>] member inline _.CheckState' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.Nullable<System.Boolean> * (System.Nullable<System.Boolean> -> unit)) = render ==> html.bind("CheckState", valueFn)
    /// Gets or sets a callback that updates the CheckState.
    [<CustomOperation("CheckStateChanged")>] member inline _.CheckStateChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Nullable<System.Boolean> -> unit) = render ==> html.callback("CheckStateChanged", fn)
    /// Gets or sets a callback that updates the CheckState.
    [<CustomOperation("CheckStateChanged")>] member inline _.CheckStateChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Nullable<System.Boolean> -> Task<unit>) = render ==> html.callbackTask("CheckStateChanged", fn)

type FluentTimePickerBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentInputBaseBuilder<'FunBlazorGeneric, System.Nullable<System.DateTime>>()
    /// Gets or sets the design of this input.
    [<CustomOperation("Appearance")>] member inline _.Appearance ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.FluentUI.AspNetCore.Components.FluentInputAppearance) = render ==> ("Appearance" => x)

/// Component that provides a list of options.
type ListComponentBaseBuilder<'FunBlazorGeneric, 'TOption when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentInputBaseBuilder<'FunBlazorGeneric, System.String>()
    /// Gets or sets the width of the component.
    [<CustomOperation("Width")>] member inline _.Width ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Width" => x)
    /// Gets or sets the height of the component or of the popup panel.
    [<CustomOperation("Height")>] member inline _.Height ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Height" => x)
    /// Gets or sets the text used on aria-label attribute.
    [<CustomOperation("Title")>] member inline _.Title ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Title" => x)
    /// Gets or sets the function used to determine which text to display for each option.
    [<CustomOperation("OptionText")>] member inline _.OptionText ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("OptionText" => (System.Func<'TOption, System.String>fn))
    /// Gets or sets the function used to determine which value to return for the selected item.
    /// Only for FluentListbox`1 and FluentSelect`1 components.
    [<CustomOperation("OptionValue")>] member inline _.OptionValue ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("OptionValue" => (System.Func<'TOption, System.String>fn))
    /// Gets or sets the function used to determine if an option is disabled.
    [<CustomOperation("OptionDisabled")>] member inline _.OptionDisabled ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("OptionDisabled" => (System.Func<'TOption, System.Boolean>fn))
    /// Gets or sets the function used to determine if an option is initially selected.
    [<CustomOperation("OptionSelected")>] member inline _.OptionSelected ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("OptionSelected" => (System.Func<'TOption, System.Boolean>fn))
    /// Gets or sets the content source of all items to display in this list.
    /// Each item must be instantiated (cannot be null).
    [<CustomOperation("Items")>] member inline _.Items ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.IEnumerable<'TOption>) = render ==> ("Items" => x)
    /// Gets or sets the selected item.
    /// ⚠️ Only available when Multiple = false.
    [<CustomOperation("SelectedOption")>] member inline _.SelectedOption ([<InlineIfLambda>] render: AttrRenderFragment, x: 'TOption) = render ==> ("SelectedOption" => x)
    /// Gets or sets the selected item.
    /// ⚠️ Only available when Multiple = false.
    [<CustomOperation("SelectedOption'")>] member inline _.SelectedOption' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: 'TOption * ('TOption -> unit)) = render ==> html.bind("SelectedOption", valueFn)
    /// Called whenever the selection changed.
    /// ⚠️ Only available when Multiple = false.
    [<CustomOperation("SelectedOptionChanged")>] member inline _.SelectedOptionChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: 'TOption -> unit) = render ==> html.callback("SelectedOptionChanged", fn)
    /// Called whenever the selection changed.
    /// ⚠️ Only available when Multiple = false.
    [<CustomOperation("SelectedOptionChanged")>] member inline _.SelectedOptionChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: 'TOption -> Task<unit>) = render ==> html.callbackTask("SelectedOptionChanged", fn)
    /// If true, the user can select multiple elements.
    /// ⚠️ Only available for the FluentSelect and FluentListbox components.
    [<CustomOperation("Multiple")>] member inline _.Multiple ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Multiple" =>>> true)
    /// If true, the user can select multiple elements.
    /// ⚠️ Only available for the FluentSelect and FluentListbox components.
    [<CustomOperation("Multiple")>] member inline _.Multiple ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Multiple" =>>> x)
    /// Gets or sets the template for the Items items.
    [<CustomOperation("OptionTemplate")>] member inline _.OptionTemplate ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: 'TOption -> NodeRenderFragment) = render ==> html.renderFragment("OptionTemplate", fn)
    /// Gets or sets all selected items.
    /// ⚠️ Only available when Multiple = true.
    [<CustomOperation("SelectedOptions")>] member inline _.SelectedOptions ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.IEnumerable<'TOption>) = render ==> ("SelectedOptions" => x)
    /// Gets or sets all selected items.
    /// ⚠️ Only available when Multiple = true.
    [<CustomOperation("SelectedOptions'")>] member inline _.SelectedOptions' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.Collections.Generic.IEnumerable<'TOption> * (System.Collections.Generic.IEnumerable<'TOption> -> unit)) = render ==> html.bind("SelectedOptions", valueFn)
    /// Called whenever the selection changed.
    /// ⚠️ Only available when Multiple = true.
    [<CustomOperation("SelectedOptionsChanged")>] member inline _.SelectedOptionsChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Collections.Generic.IEnumerable<'TOption> -> unit) = render ==> html.callback("SelectedOptionsChanged", fn)
    /// Called whenever the selection changed.
    /// ⚠️ Only available when Multiple = true.
    [<CustomOperation("SelectedOptionsChanged")>] member inline _.SelectedOptionsChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Collections.Generic.IEnumerable<'TOption> -> Task<unit>) = render ==> html.callbackTask("SelectedOptionsChanged", fn)

type FluentAutocompleteBuilder<'FunBlazorGeneric, 'TOption when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ListComponentBaseBuilder<'FunBlazorGeneric, 'TOption>()
    /// Gets or sets the text field value.
    [<CustomOperation("ValueText")>] member inline _.ValueText ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("ValueText" => x)
    /// Gets or sets the text field value.
    [<CustomOperation("ValueText'")>] member inline _.ValueText' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.String * (System.String -> unit)) = render ==> html.bind("ValueText", valueFn)
    /// Gets or sets the callback that is invoked when the text field value changes.
    [<CustomOperation("ValueTextChanged")>] member inline _.ValueTextChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.String -> unit) = render ==> html.callback("ValueTextChanged", fn)
    /// Gets or sets the callback that is invoked when the text field value changes.
    [<CustomOperation("ValueTextChanged")>] member inline _.ValueTextChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.String -> Task<unit>) = render ==> html.callbackTask("ValueTextChanged", fn)
    /// Gets or sets the value of the input. This should be used with two-way binding.
    /// For the FluentAutocomplete component, use the ValueText property instead.
    [<CustomOperation("Value")>] member inline _.Value ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Value" => x)
    /// Gets or sets the visual appearance. See 
    [<CustomOperation("Appearance")>] member inline _.Appearance ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.FluentUI.AspNetCore.Components.FluentInputAppearance) = render ==> ("Appearance" => x)
    /// Specifies whether a form or an input field should have autocomplete "on" or "off" or another value.
    /// An Id value must be set to use this property.
    [<CustomOperation("AutoComplete")>] member inline _.AutoComplete ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("AutoComplete" => x)
    /// Filter the list of options (items), using the text encoded by the user.
    [<CustomOperation("OnOptionsSearch")>] member inline _.OnOptionsSearch ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.FluentUI.AspNetCore.Components.OptionsSearchEventArgs<'TOption> -> unit) = render ==> html.callback("OnOptionsSearch", fn)
    /// Filter the list of options (items), using the text encoded by the user.
    [<CustomOperation("OnOptionsSearch")>] member inline _.OnOptionsSearch ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.FluentUI.AspNetCore.Components.OptionsSearchEventArgs<'TOption> -> Task<unit>) = render ==> html.callbackTask("OnOptionsSearch", fn)
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
    [<CustomOperation("MaximumSelectedOptionsMessage")>] member inline _.MaximumSelectedOptionsMessage ([<InlineIfLambda>] render: AttrRenderFragment, fragment: NodeRenderFragment) = render ==> html.renderFragment("MaximumSelectedOptionsMessage", fragment)
    /// Gets or sets the message displayed when the MaximumSelectedOptions is reached.
    [<CustomOperation("MaximumSelectedOptionsMessage")>] member inline _.MaximumSelectedOptionsMessage ([<InlineIfLambda>] render: AttrRenderFragment, fragments: NodeRenderFragment seq) = render ==> html.renderFragment("MaximumSelectedOptionsMessage", fragment { yield! fragments })
    /// Gets or sets the message displayed when the MaximumSelectedOptions is reached.
    [<CustomOperation("MaximumSelectedOptionsMessage")>] member inline _.MaximumSelectedOptionsMessage ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("MaximumSelectedOptionsMessage", html.text x)
    /// Gets or sets the message displayed when the MaximumSelectedOptions is reached.
    [<CustomOperation("MaximumSelectedOptionsMessage")>] member inline _.MaximumSelectedOptionsMessage ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("MaximumSelectedOptionsMessage", html.text x)
    /// Gets or sets the message displayed when the MaximumSelectedOptions is reached.
    [<CustomOperation("MaximumSelectedOptionsMessage")>] member inline _.MaximumSelectedOptionsMessage ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("MaximumSelectedOptionsMessage", html.text x)
    /// Gets or sets the template for the SelectedOptions items.
    [<CustomOperation("SelectedOptionTemplate")>] member inline _.SelectedOptionTemplate ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: 'TOption -> NodeRenderFragment) = render ==> html.renderFragment("SelectedOptionTemplate", fn)
    /// Gets or sets the header content, placed at the top of the popup panel.
    [<CustomOperation("HeaderContent")>] member inline _.HeaderContent ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Collections.Generic.IEnumerable<'TOption> -> NodeRenderFragment) = render ==> html.renderFragment("HeaderContent", fn)
    /// Gets or sets the footer content, placed at the bottom of the popup panel.
    [<CustomOperation("FooterContent")>] member inline _.FooterContent ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Collections.Generic.IEnumerable<'TOption> -> NodeRenderFragment) = render ==> html.renderFragment("FooterContent", fn)
    /// Gets or sets the title and Aria-Label for the Scroll to previous button.
    [<CustomOperation("TitleScrollToPrevious")>] member inline _.TitleScrollToPrevious ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("TitleScrollToPrevious" => x)
    /// Gets or sets the title and Aria-Label for the Scroll to next button.
    [<CustomOperation("TitleScrollToNext")>] member inline _.TitleScrollToNext ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("TitleScrollToNext" => x)
    /// Gets or sets the icon used for the Clear button. By default: Dismiss icon.
    [<CustomOperation("IconDismiss")>] member inline _.IconDismiss ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.FluentUI.AspNetCore.Components.Icon) = render ==> ("IconDismiss" => x)
    /// Gets or sets the icon used for the Search button. By default: Search icon.
    [<CustomOperation("IconSearch")>] member inline _.IconSearch ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.FluentUI.AspNetCore.Components.Icon) = render ==> ("IconSearch" => x)
    /// Gets or sets whether the dropdown is shown when there are no items.
    [<CustomOperation("ShowOverlayOnEmptyResults")>] member inline _.ShowOverlayOnEmptyResults ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("ShowOverlayOnEmptyResults" =>>> true)
    /// Gets or sets whether the dropdown is shown when there are no items.
    [<CustomOperation("ShowOverlayOnEmptyResults")>] member inline _.ShowOverlayOnEmptyResults ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("ShowOverlayOnEmptyResults" =>>> x)
    /// If true, the options list will be rendered with virtualization. This is normally used in conjunction with
    /// scrolling and causes the option list to fetch and render only the data around the current scroll viewport.
    /// This can greatly improve the performance when scrolling through large data sets.
    ///             
    /// If you use Virtualize, you should supply a value for ItemSize and must
    /// ensure that every row renders with the same constant height.
    ///             
    /// Generally it's preferable not to use Virtualize if the amount of data being rendered is small.
    [<CustomOperation("Virtualize")>] member inline _.Virtualize ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Virtualize" =>>> true)
    /// If true, the options list will be rendered with virtualization. This is normally used in conjunction with
    /// scrolling and causes the option list to fetch and render only the data around the current scroll viewport.
    /// This can greatly improve the performance when scrolling through large data sets.
    ///             
    /// If you use Virtualize, you should supply a value for ItemSize and must
    /// ensure that every row renders with the same constant height.
    ///             
    /// Generally it's preferable not to use Virtualize if the amount of data being rendered is small.
    [<CustomOperation("Virtualize")>] member inline _.Virtualize ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Virtualize" =>>> x)
    /// This is applicable only when using Virtualize. It defines an expected height in pixels for
    /// each row, allowing the virtualization mechanism to fetch the correct number of items to match the display
    /// size and to ensure accurate scrolling.
    [<CustomOperation("ItemSize")>] member inline _.ItemSize ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Single) = render ==> ("ItemSize" => x)
    /// Gets or sets the maximum height of the field to adjust its height in relation to selected elements.
    [<CustomOperation("MaxAutoHeight")>] member inline _.MaxAutoHeight ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("MaxAutoHeight" => x)
    /// Gets or sets whether the currently selected item from the drop-down (if it is open) is selected.
    /// Default is false.
    [<CustomOperation("SelectValueOnTab")>] member inline _.SelectValueOnTab ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("SelectValueOnTab" =>>> true)
    /// Gets or sets whether the currently selected item from the drop-down (if it is open) is selected.
    /// Default is false.
    [<CustomOperation("SelectValueOnTab")>] member inline _.SelectValueOnTab ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("SelectValueOnTab" =>>> x)
    /// Gets or sets whether the drop-down panel stays open after selecting an item,
    /// until the number of selected items reaches the maximum (only using the mouse).
    [<CustomOperation("KeepOpen")>] member inline _.KeepOpen ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("KeepOpen" =>>> true)
    /// Gets or sets whether the drop-down panel stays open after selecting an item,
    /// until the number of selected items reaches the maximum (only using the mouse).
    [<CustomOperation("KeepOpen")>] member inline _.KeepOpen ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("KeepOpen" =>>> x)

type FluentComboboxBuilder<'FunBlazorGeneric, 'TOption when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ListComponentBaseBuilder<'FunBlazorGeneric, 'TOption>()
    /// Gets or sets a value indicating whether the element auto completes. See 
    [<CustomOperation("Autocomplete")>] member inline _.Autocomplete ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<Microsoft.FluentUI.AspNetCore.Components.ComboboxAutocomplete>) = render ==> ("Autocomplete" => x)
    /// Gets or sets the open attribute.
    [<CustomOperation("Open")>] member inline _.Open ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Boolean>) = render ==> ("Open" => x)
    /// Gets or sets the placement for the listbox when the combobox is open.
    /// See 
    [<CustomOperation("Position")>] member inline _.Position ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<Microsoft.FluentUI.AspNetCore.Components.SelectPosition>) = render ==> ("Position" => x)
    /// Gets or sets the visual appearance. See 
    [<CustomOperation("Appearance")>] member inline _.Appearance ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<Microsoft.FluentUI.AspNetCore.Components.Appearance>) = render ==> ("Appearance" => x)

type FluentListboxBuilder<'FunBlazorGeneric, 'TOption when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ListComponentBaseBuilder<'FunBlazorGeneric, 'TOption>()
    /// Gets or sets the maximum number of options that should be visible in the listbox scroll area.
    [<CustomOperation("Size")>] member inline _.Size ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("Size" => x)

type FluentSelectBuilder<'FunBlazorGeneric, 'TOption when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ListComponentBaseBuilder<'FunBlazorGeneric, 'TOption>()
    /// Gets or sets the open attribute.
    [<CustomOperation("Open")>] member inline _.Open ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Boolean>) = render ==> ("Open" => x)
    /// Reflects the placement for the listbox when the select is open.
    /// See SelectPosition
    [<CustomOperation("Position")>] member inline _.Position ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<Microsoft.FluentUI.AspNetCore.Components.SelectPosition>) = render ==> ("Position" => x)
    /// Gets or sets the visual appearance. See 
    [<CustomOperation("Appearance")>] member inline _.Appearance ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<Microsoft.FluentUI.AspNetCore.Components.Appearance>) = render ==> ("Appearance" => x)

type FluentNumberFieldBuilder<'FunBlazorGeneric, 'TValue when 'TValue : (new : unit -> 'TValue) and 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentInputBaseBuilder<'FunBlazorGeneric, 'TValue>()
    /// When true, spin buttons will not be rendered.
    [<CustomOperation("HideStep")>] member inline _.HideStep ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("HideStep" =>>> true)
    /// When true, spin buttons will not be rendered.
    [<CustomOperation("HideStep")>] member inline _.HideStep ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("HideStep" =>>> x)
    /// Allows associating a datalist to the element by id.
    [<CustomOperation("DataList")>] member inline _.DataList ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("DataList" => x)
    /// Gets or sets the maximum length.
    [<CustomOperation("MaxLength")>] member inline _.MaxLength ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("MaxLength" => x)
    /// Gets or sets the minimum length.
    [<CustomOperation("MinLength")>] member inline _.MinLength ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("MinLength" => x)
    /// Gets or sets the size.
    [<CustomOperation("Size")>] member inline _.Size ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("Size" => x)
    /// Gets or sets the amount to increase/decrease the number with. Only use whole number when TValue is int or long.
    [<CustomOperation("Step")>] member inline _.Step ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Step" => x)
    /// Gets or sets the maximum value.
    [<CustomOperation("Max")>] member inline _.Max ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Max" => x)
    /// Gets or sets the minimum value.
    [<CustomOperation("Min")>] member inline _.Min ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Min" => x)
    /// Gets or sets the Appearance.
    [<CustomOperation("Appearance")>] member inline _.Appearance ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.FluentUI.AspNetCore.Components.FluentInputAppearance) = render ==> ("Appearance" => x)
    /// Specifies whether a form or an input field should have autocomplete "on" or "off" or another value.
    /// An Id value must be set to use this property.
    [<CustomOperation("AutoComplete")>] member inline _.AutoComplete ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("AutoComplete" => x)
    /// Gets or sets the error message to show when the field can not be parsed.
    [<CustomOperation("ParsingErrorMessage")>] member inline _.ParsingErrorMessage ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("ParsingErrorMessage" => x)

/// Groups child FluentRadio`1 components.
type FluentRadioGroupBuilder<'FunBlazorGeneric, 'TValue when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentInputBaseBuilder<'FunBlazorGeneric, 'TValue>()
    /// Gets or sets the orientation of the group. See Orientation
    [<CustomOperation("Orientation")>] member inline _.Orientation ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<Microsoft.FluentUI.AspNetCore.Components.Orientation>) = render ==> ("Orientation" => x)

type FluentRatingBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentInputBaseBuilder<'FunBlazorGeneric, System.Int32>()
    /// Gets or sets the number of elements.
    [<CustomOperation("Max")>] member inline _.Max ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("Max" => x)
    /// The icon to display when the rating value is greater than or equal to the item's value.
    [<CustomOperation("IconFilled")>] member inline _.IconFilled ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.FluentUI.AspNetCore.Components.Icon) = render ==> ("IconFilled" => x)
    /// The icon to display when the rating value is less than the item's value.
    [<CustomOperation("IconOutline")>] member inline _.IconOutline ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.FluentUI.AspNetCore.Components.Icon) = render ==> ("IconOutline" => x)
    /// Gets or sets the icon drawing and fill color.
    /// Value comes from the Color enumeration. Defaults to Accent.
    [<CustomOperation("IconColor")>] member inline _.IconColor ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<Microsoft.FluentUI.AspNetCore.Components.Color>) = render ==> ("IconColor" => x)
    /// Gets or sets the icon drawing and fill color to a custom value.
    /// Needs to be formatted as an HTML hex color string (#rrggbb or #rgb) or CSS variable.
    /// ⚠️ Only available when Color is set to Color.Custom.
    [<CustomOperation("IconCustomColor")>] member inline _.IconCustomColor ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("IconCustomColor" => x)
    /// The icon width.
    [<CustomOperation("IconWidth")>] member inline _.IconWidth ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("IconWidth" => x)
    /// Gets or sets a value that whether to allow clear when click again.
    [<CustomOperation("AllowReset")>] member inline _.AllowReset ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("AllowReset" =>>> true)
    /// Gets or sets a value that whether to allow clear when click again.
    [<CustomOperation("AllowReset")>] member inline _.AllowReset ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("AllowReset" =>>> x)
    /// Fires when hovered value changes. Value will be null if no rating item is hovered.
    [<CustomOperation("OnHoverValueChanged")>] member inline _.OnHoverValueChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Nullable<System.Int32> -> unit) = render ==> html.callback("OnHoverValueChanged", fn)
    /// Fires when hovered value changes. Value will be null if no rating item is hovered.
    [<CustomOperation("OnHoverValueChanged")>] member inline _.OnHoverValueChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Nullable<System.Int32> -> Task<unit>) = render ==> html.callbackTask("OnHoverValueChanged", fn)

type FluentSearchBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentInputBaseBuilder<'FunBlazorGeneric, System.String>()
    /// Allows associating a datalist to the element by id.
    [<CustomOperation("DataList")>] member inline _.DataList ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("DataList" => x)
    /// Gets or sets the maximum number of characters a user can enter.
    [<CustomOperation("Maxlength")>] member inline _.Maxlength ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Int32>) = render ==> ("Maxlength" => x)
    /// Gets or sets the minimum number of characters a user can enter.
    [<CustomOperation("Minlength")>] member inline _.Minlength ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Int32>) = render ==> ("Minlength" => x)
    /// Gets or sets a regular expression that the value must match to pass validation.
    [<CustomOperation("Pattern")>] member inline _.Pattern ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Pattern" => x)
    /// Gets or sets the size of the text field.
    [<CustomOperation("Size")>] member inline _.Size ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Int32>) = render ==> ("Size" => x)
    /// Gets or sets the if spellcheck should be used.
    [<CustomOperation("Spellcheck")>] member inline _.Spellcheck ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Boolean>) = render ==> ("Spellcheck" => x)
    /// Gets or sets the visual appearance. See Appearance
    [<CustomOperation("Appearance")>] member inline _.Appearance ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.FluentUI.AspNetCore.Components.FluentInputAppearance) = render ==> ("Appearance" => x)
    /// Gets or sets whether a form or an input field should have autocomplete "on" or "off" or another value.
    [<CustomOperation("AutoComplete")>] member inline _.AutoComplete ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("AutoComplete" => x)

type FluentSliderBuilder<'FunBlazorGeneric, 'TValue when System.Numerics.INumber<'TValue> and 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentInputBaseBuilder<'FunBlazorGeneric, 'TValue>()
    /// Gets or sets the slider's minimal value.
    [<CustomOperation("Min")>] member inline _.Min ([<InlineIfLambda>] render: AttrRenderFragment, x: 'TValue) = render ==> ("Min" => x)
    /// Gets or sets the slider's maximum value.
    [<CustomOperation("Max")>] member inline _.Max ([<InlineIfLambda>] render: AttrRenderFragment, x: 'TValue) = render ==> ("Max" => x)
    /// Gets or sets the slider's step value.
    [<CustomOperation("Step")>] member inline _.Step ([<InlineIfLambda>] render: AttrRenderFragment, x: 'TValue) = render ==> ("Step" => x)
    /// Gets or sets the orientation of the slider. See Orientation
    [<CustomOperation("Orientation")>] member inline _.Orientation ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<Microsoft.FluentUI.AspNetCore.Components.Orientation>) = render ==> ("Orientation" => x)
    /// Gets or sets the selection mode.
    [<CustomOperation("Mode")>] member inline _.Mode ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<Microsoft.FluentUI.AspNetCore.Components.SliderMode>) = render ==> ("Mode" => x)

type FluentSwitchBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentInputBaseBuilder<'FunBlazorGeneric, System.Boolean>()
    /// Gets or sets the checked message
    [<CustomOperation("CheckedMessage")>] member inline _.CheckedMessage ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("CheckedMessage" => x)
    /// Gets or sets the unchecked message
    [<CustomOperation("UncheckedMessage")>] member inline _.UncheckedMessage ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("UncheckedMessage" => x)

type FluentTextAreaBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentInputBaseBuilder<'FunBlazorGeneric, System.String>()
    /// Gets or sets a value indicating whether the text area is resizeable. See TextAreaResize
    [<CustomOperation("Resize")>] member inline _.Resize ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<Microsoft.FluentUI.AspNetCore.Components.TextAreaResize>) = render ==> ("Resize" => x)
    /// Gets or sets the id the form the element is associated to.
    [<CustomOperation("Form")>] member inline _.Form ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Form" => x)
    /// Allows associating a datalist to the element by id.
    [<CustomOperation("DataList")>] member inline _.DataList ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("DataList" => x)
    /// Gets or sets the maximum number of characters a user can enter.
    [<CustomOperation("Maxlength")>] member inline _.Maxlength ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Int32>) = render ==> ("Maxlength" => x)
    /// Gets or sets the minimum number of characters a user can enter.
    [<CustomOperation("Minlength")>] member inline _.Minlength ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Int32>) = render ==> ("Minlength" => x)
    /// Gets or sets the size the element horizontally by a number of character columns.
    [<CustomOperation("Cols")>] member inline _.Cols ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Int32>) = render ==> ("Cols" => x)
    /// Gets or sets the size the element vertically by a number of character rows.
    [<CustomOperation("Rows")>] member inline _.Rows ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Int32>) = render ==> ("Rows" => x)
    /// Gets or sets a value indicating whether the element is eligible for spell checking
    /// but the UA.
    [<CustomOperation("Spellcheck")>] member inline _.Spellcheck ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Boolean>) = render ==> ("Spellcheck" => x)
    /// Gets or sets the visual appearance. See FluentInputAppearance
    [<CustomOperation("Appearance")>] member inline _.Appearance ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.FluentUI.AspNetCore.Components.FluentInputAppearance) = render ==> ("Appearance" => x)

type FluentTextFieldBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentInputBaseBuilder<'FunBlazorGeneric, System.String>()
    /// Gets or sets the text filed type. See TextFieldType
    [<CustomOperation("TextFieldType")>] member inline _.TextFieldType ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<Microsoft.FluentUI.AspNetCore.Components.TextFieldType>) = render ==> ("TextFieldType" => x)
    /// Allows associating a datalist to the element by id.
    [<CustomOperation("DataList")>] member inline _.DataList ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("DataList" => x)
    /// Gets or sets the maximum length.
    [<CustomOperation("Maxlength")>] member inline _.Maxlength ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Int32>) = render ==> ("Maxlength" => x)
    /// Gets or sets the minimum length.
    [<CustomOperation("Minlength")>] member inline _.Minlength ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Int32>) = render ==> ("Minlength" => x)
    /// Gets or sets a regular expression that the value must match to pass validation.
    [<CustomOperation("Pattern")>] member inline _.Pattern ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Pattern" => x)
    /// Gets or sets the size of the text field.
    [<CustomOperation("Size")>] member inline _.Size ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Int32>) = render ==> ("Size" => x)
    /// Gets or sets a value indicating whether spellcheck should be used.
    [<CustomOperation("Spellcheck")>] member inline _.Spellcheck ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Boolean>) = render ==> ("Spellcheck" => x)
    /// Gets or sets the visual appearance. See FluentInputAppearance
    [<CustomOperation("Appearance")>] member inline _.Appearance ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.FluentUI.AspNetCore.Components.FluentInputAppearance) = render ==> ("Appearance" => x)
    /// Specifies whether a form or an input field should have autocomplete "on" or "off" or another value.
    /// An Id value must be set to use this property.
    [<CustomOperation("AutoComplete")>] member inline _.AutoComplete ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("AutoComplete" => x)
    /// Gets or sets the type of data that can be entered by the user when editing the element or its content. This allows a browser to display an appropriate virtual keyboard. Not supported by Safari.
    [<CustomOperation("InputMode")>] member inline _.InputMode ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<Microsoft.FluentUI.AspNetCore.Components.InputMode>) = render ==> ("InputMode" => x)

type FluentBodyContentBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentComponentBaseBuilder<'FunBlazorGeneric>()


type FluentBreadcrumbBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentComponentBaseBuilder<'FunBlazorGeneric>()


type FluentBreadcrumbItemBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentComponentBaseBuilder<'FunBlazorGeneric>()
    /// Prompts the user to save the linked URL. See a element for more information.
    [<CustomOperation("Download")>] member inline _.Download ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Download" => x)
    /// Gets or sets the URL the hyperlink references. See a element for more information.
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
    /// Gets or sets the target attribute that specifies where to open the link, if Href is specified. 
    /// See a element for more information.
    /// Possible values: _blank | _self | _parent | _top.
    [<CustomOperation("Target")>] member inline _.Target ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Target" => x)
    /// See a element for more information.
    [<CustomOperation("Type")>] member inline _.Type ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Type" => x)
    /// Gets or sets the visual appearance. See 
    [<CustomOperation("Appearance")>] member inline _.Appearance ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<Microsoft.FluentUI.AspNetCore.Components.Appearance>) = render ==> ("Appearance" => x)

type FluentButtonBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentComponentBaseBuilder<'FunBlazorGeneric>()
    /// Determines if the element should receive document focus on page load.
    [<CustomOperation("Autofocus")>] member inline _.Autofocus ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Boolean>) = render ==> ("Autofocus" => x)
    /// Gets or sets the id of a form to associate the element to.
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
    /// Gets or sets the button type. See ButtonType for more details.
    /// Default is ButtonType.Button.
    [<CustomOperation("Type")>] member inline _.Type ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<Microsoft.FluentUI.AspNetCore.Components.ButtonType>) = render ==> ("Type" => x)
    /// Gets or sets the value of the element.
    [<CustomOperation("Value")>] member inline _.Value ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Value" => x)
    /// Gets or sets the element's current value.
    [<CustomOperation("CurrentValue")>] member inline _.CurrentValue ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("CurrentValue" => x)
    /// Disables the form control, ensuring it doesn't participate in form submission.
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Disabled" =>>> true)
    /// Disables the form control, ensuring it doesn't participate in form submission.
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Disabled" =>>> x)
    /// Gets or sets the name of the element.
    /// Allows access by name from the associated form.
    [<CustomOperation("Name")>] member inline _.Name ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Name" => x)
    /// Gets or sets a value indicating whether the element needs to have a value.
    [<CustomOperation("Required")>] member inline _.Required ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Required" =>>> true)
    /// Gets or sets a value indicating whether the element needs to have a value.
    [<CustomOperation("Required")>] member inline _.Required ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Required" =>>> x)
    /// Gets or sets the visual appearance. See 
    /// Defaults to 
    [<CustomOperation("Appearance")>] member inline _.Appearance ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<Microsoft.FluentUI.AspNetCore.Components.Appearance>) = render ==> ("Appearance" => x)
    /// Gets or sets the background color of this button (overrides the Appearance property).
    /// Set the value "rgba(0, 0, 0, 0)" to display a transparent button.
    [<CustomOperation("BackgroundColor")>] member inline _.BackgroundColor ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("BackgroundColor" => x)
    /// Gets or sets the color of the font (overrides the Appearance property).
    [<CustomOperation("Color")>] member inline _.Color ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Color" => x)
    /// Display a progress ring and disable the button.
    [<CustomOperation("Loading")>] member inline _.Loading ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Loading" =>>> true)
    /// Display a progress ring and disable the button.
    [<CustomOperation("Loading")>] member inline _.Loading ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Loading" =>>> x)
    /// Gets or sets the Icon displayed at the start of button content.
    [<CustomOperation("IconStart")>] member inline _.IconStart ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.FluentUI.AspNetCore.Components.Icon) = render ==> ("IconStart" => x)
    /// Gets or sets the Icon displayed at the end of button content.
    [<CustomOperation("IconEnd")>] member inline _.IconEnd ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.FluentUI.AspNetCore.Components.Icon) = render ==> ("IconEnd" => x)
    /// Gets or sets the title of the button.
    /// The text usually displayed in a 'tooltip' popup when the mouse is over the button.
    [<CustomOperation("Title")>] member inline _.Title ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Title" => x)
    /// Gets or sets a way to prevent further propagation of the current event in the capturing and bubbling phases.
    [<CustomOperation("StopPropagation")>] member inline _.StopPropagation ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("StopPropagation" =>>> true)
    /// Gets or sets a way to prevent further propagation of the current event in the capturing and bubbling phases.
    [<CustomOperation("StopPropagation")>] member inline _.StopPropagation ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("StopPropagation" =>>> x)
    /// Command executed when the user clicks on the button.
    [<CustomOperation("OnClick")>] member inline _.OnClick ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.AspNetCore.Components.Web.MouseEventArgs -> unit) = render ==> html.callback("OnClick", fn)
    /// Command executed when the user clicks on the button.
    [<CustomOperation("OnClick")>] member inline _.OnClick ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.AspNetCore.Components.Web.MouseEventArgs -> Task<unit>) = render ==> html.callbackTask("OnClick", fn)

type FluentCardBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentComponentBaseBuilder<'FunBlazorGeneric>()
    /// By default, content in the card is restricted to the area of the card itself.
    /// If you want content to be able to overflow the card, set this property to false.
    [<CustomOperation("AreaRestricted")>] member inline _.AreaRestricted ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("AreaRestricted" =>>> true)
    /// By default, content in the card is restricted to the area of the card itself.
    /// If you want content to be able to overflow the card, set this property to false.
    [<CustomOperation("AreaRestricted")>] member inline _.AreaRestricted ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("AreaRestricted" =>>> x)
    /// Gets or sets the width of the card. Must be a valid CSS measurement.
    [<CustomOperation("Width")>] member inline _.Width ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Width" => x)
    /// Gets or sets the height of the card. Must be a valid CSS measurement.
    [<CustomOperation("Height")>] member inline _.Height ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Height" => x)
    [<CustomOperation("MinimalStyle")>] member inline _.MinimalStyle ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("MinimalStyle" =>>> true)
    [<CustomOperation("MinimalStyle")>] member inline _.MinimalStyle ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("MinimalStyle" =>>> x)

type FluentCollapsibleRegionBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentComponentBaseBuilder<'FunBlazorGeneric>()
    /// If true, the region is expaned, otherwise it is collapsed.
    [<CustomOperation("Expanded")>] member inline _.Expanded ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Expanded" =>>> true)
    /// If true, the region is expaned, otherwise it is collapsed.
    [<CustomOperation("Expanded")>] member inline _.Expanded ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Expanded" =>>> x)
    /// If true, the region is expaned, otherwise it is collapsed.
    [<CustomOperation("Expanded'")>] member inline _.Expanded' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.Boolean * (System.Boolean -> unit)) = render ==> html.bind("Expanded", valueFn)
    /// Explicitly sets the height for the Collapse element to override the css default.
    [<CustomOperation("MaxHeight")>] member inline _.MaxHeight ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("MaxHeight" => x)
    /// Callback for when the Expanded property changes.
    [<CustomOperation("ExpandedChanged")>] member inline _.ExpandedChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Boolean -> unit) = render ==> html.callback("ExpandedChanged", fn)
    /// Callback for when the Expanded property changes.
    [<CustomOperation("ExpandedChanged")>] member inline _.ExpandedChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Boolean -> Task<unit>) = render ==> html.callbackTask("ExpandedChanged", fn)

type FluentCounterBadgeBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentComponentBaseBuilder<'FunBlazorGeneric>()
    /// Gets or sets the number displayed inside the badge.
    /// Can be enriched with a plus sign with ShowOverflow
    [<CustomOperation("Count")>] member inline _.Count ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Int32>) = render ==> ("Count" => x)
    /// Gets or sets the content you want inside the badge, to customize the badge content.
    [<CustomOperation("BadgeContent")>] member inline _.BadgeContent ([<InlineIfLambda>] render: AttrRenderFragment, fragment: NodeRenderFragment) = render ==> html.renderFragment("BadgeContent", fragment)
    /// Gets or sets the content you want inside the badge, to customize the badge content.
    [<CustomOperation("BadgeContent")>] member inline _.BadgeContent ([<InlineIfLambda>] render: AttrRenderFragment, fragments: NodeRenderFragment seq) = render ==> html.renderFragment("BadgeContent", fragment { yield! fragments })
    /// Gets or sets the content you want inside the badge, to customize the badge content.
    [<CustomOperation("BadgeContent")>] member inline _.BadgeContent ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("BadgeContent", html.text x)
    /// Gets or sets the content you want inside the badge, to customize the badge content.
    [<CustomOperation("BadgeContent")>] member inline _.BadgeContent ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("BadgeContent", html.text x)
    /// Gets or sets the content you want inside the badge, to customize the badge content.
    [<CustomOperation("BadgeContent")>] member inline _.BadgeContent ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("BadgeContent", html.text x)
    /// Gets or sets the content you want inside the badge, to customize the badge content.
    [<CustomOperation("BadgeTemplate")>] member inline _.BadgeTemplate ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Nullable<System.Int32> -> NodeRenderFragment) = render ==> html.renderFragment("BadgeTemplate", fn)
    /// Gets or sets the maximum number that can be displayed inside the badge.
    /// Default is 99.
    [<CustomOperation("Max")>] member inline _.Max ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Int32>) = render ==> ("Max" => x)
    /// Gets or sets the horizontal position of the badge in percentage in relation to the left of the container (right in RTL).
    /// Default value is 60 (80 when Dot=true).
    [<CustomOperation("HorizontalPosition")>] member inline _.HorizontalPosition ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("HorizontalPosition" => x)
    /// Gets or sets the bottom position of the badge in percentage.
    /// [Obsolete] This parameter will be removed in a future version. Use VerticalPosition instead.
    /// Default value is 60 (80 when Dot=true).
    [<CustomOperation("BottomPosition")>] member inline _.BottomPosition ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("BottomPosition" => x)
    /// Gets or sets the vertical position of the badge in percentage in relation to the bottom of the container.
    /// Default value is 60 (80 when Dot=true).
    [<CustomOperation("VerticalPosition")>] member inline _.VerticalPosition ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("VerticalPosition" => x)
    /// Gets or sets the default design of this badge using colors from theme.
    [<CustomOperation("Appearance")>] member inline _.Appearance ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<Microsoft.FluentUI.AspNetCore.Components.Appearance>) = render ==> ("Appearance" => x)
    /// Gets or sets the background color to replace the color inferred from property.
    [<CustomOperation("BackgroundColor")>] member inline _.BackgroundColor ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<Microsoft.FluentUI.AspNetCore.Components.Color>) = render ==> ("BackgroundColor" => x)
    /// Gets or sets the font color to replace the color inferred from property.
    [<CustomOperation("Color")>] member inline _.Color ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<Microsoft.FluentUI.AspNetCore.Components.Color>) = render ==> ("Color" => x)
    /// Gets or sets if just a dot should be displayed. Count will be ignored if this is set to true.
    /// Defaults to false.
    ///             
    [<CustomOperation("Dot")>] member inline _.Dot ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Dot" =>>> true)
    /// Gets or sets if just a dot should be displayed. Count will be ignored if this is set to true.
    /// Defaults to false.
    ///             
    [<CustomOperation("Dot")>] member inline _.Dot ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Dot" =>>> x)
    /// If the counter badge should be displayed when the count is zero.
    /// Defaults to false.
    /// [Obsolete] This parameter will be removed in a future version. Use ShowWhen with a lambda expression instead
    /// For getting the same behavior as before, you can use ShowWhen="@(Count => Count >= 0)"
    ///             
    [<CustomOperation("ShowZero")>] member inline _.ShowZero ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("ShowZero" =>>> true)
    /// If the counter badge should be displayed when the count is zero.
    /// Defaults to false.
    /// [Obsolete] This parameter will be removed in a future version. Use ShowWhen with a lambda expression instead
    /// For getting the same behavior as before, you can use ShowWhen="@(Count => Count >= 0)"
    ///             
    [<CustomOperation("ShowZero")>] member inline _.ShowZero ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("ShowZero" =>>> x)
    /// Gets or sets if the counter badge is displayed based on the specified lambda expression.
    /// For example to show the badge when the count greater than 4, use ShowWhen=@(Count => Count > 4)
    /// Default the badge shows when the count is greater than 0.
    [<CustomOperation("ShowWhen")>] member inline _.ShowWhen ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("ShowWhen" => (System.Func<System.Nullable<System.Int32>, System.Boolean>fn))
    /// If an plus sign should be displayed when the Count is greater than Max.
    /// Defaults to true.
    ///             
    [<CustomOperation("ShowOverflow")>] member inline _.ShowOverflow ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("ShowOverflow" =>>> true)
    /// If an plus sign should be displayed when the Count is greater than Max.
    /// Defaults to true.
    ///             
    [<CustomOperation("ShowOverflow")>] member inline _.ShowOverflow ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("ShowOverflow" =>>> x)

/// A component that displays a grid.
type FluentDataGridBuilder<'FunBlazorGeneric, 'TGridItem when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentComponentBaseBuilder<'FunBlazorGeneric>()
    /// Gets or sets a queryable source of data for the grid.
    ///             
    /// This could be in-memory data converted to queryable using the
    /// AsQueryable extension method,
    /// or an EntityFramework DataSet or an IQueryable derived from it.
    ///             
    /// You should supply either Items or ItemsProvider, but not both.
    [<CustomOperation("Items")>] member inline _.Items ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Linq.IQueryable<'TGridItem>) = render ==> ("Items" => x)
    /// Gets or sets a callback that supplies data for the rid.
    ///             
    /// You should supply either Items or ItemsProvider, but not both.
    [<CustomOperation("ItemsProvider")>] member inline _.ItemsProvider ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.FluentUI.AspNetCore.Components.GridItemsProvider<'TGridItem>) = render ==> ("ItemsProvider" => x)
    /// If true, the grid will be rendered with virtualization. This is normally used in conjunction with
    /// scrolling and causes the grid to fetch and render only the data around the current scroll viewport.
    /// This can greatly improve the performance when scrolling through large data sets.
    ///             
    /// If you use Virtualize, you should supply a value for ItemSize and must
    /// ensure that every row renders with the same constant height.
    ///             
    /// Generally it's preferable not to use Virtualize if the amount of data being rendered
    /// is small or if you are using pagination.
    [<CustomOperation("Virtualize")>] member inline _.Virtualize ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Virtualize" =>>> true)
    /// If true, the grid will be rendered with virtualization. This is normally used in conjunction with
    /// scrolling and causes the grid to fetch and render only the data around the current scroll viewport.
    /// This can greatly improve the performance when scrolling through large data sets.
    ///             
    /// If you use Virtualize, you should supply a value for ItemSize and must
    /// ensure that every row renders with the same constant height.
    ///             
    /// Generally it's preferable not to use Virtualize if the amount of data being rendered
    /// is small or if you are using pagination.
    [<CustomOperation("Virtualize")>] member inline _.Virtualize ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Virtualize" =>>> x)
    /// This is applicable only when using Virtualize. It defines how many additional items will be rendered
    /// before and after the visible region to reduce rendering frequency during scrolling. While higher values can improve
    /// scroll smoothness by rendering more items off-screen, they can also increase initial load times. Finding a balance
    /// based on your data set size and user experience requirements is recommended. The default value is 3.
    [<CustomOperation("OverscanCount")>] member inline _.OverscanCount ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("OverscanCount" => x)
    /// This is applicable only when using Virtualize. It defines an expected height in pixels for
    /// each row, allowing the virtualization mechanism to fetch the correct number of items to match the display
    /// size and to ensure accurate scrolling.
    [<CustomOperation("ItemSize")>] member inline _.ItemSize ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Single) = render ==> ("ItemSize" => x)
    /// If true, renders draggable handles around the column headers and adds a button to invoke a resize UI.
    /// This allows the user to resize columns manually. Size changes are not persisted.
    [<CustomOperation("ResizableColumns")>] member inline _.ResizableColumns ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("ResizableColumns" =>>> true)
    /// If true, renders draggable handles around the column headers and adds a button to invoke a resize UI.
    /// This allows the user to resize columns manually. Size changes are not persisted.
    [<CustomOperation("ResizableColumns")>] member inline _.ResizableColumns ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("ResizableColumns" =>>> x)
    /// To comply with WCAG 2.2, a one-click option should be offered to change column widths. We provide such an option through the
    /// ColumnOptions UI. This parameter allows you to enable or disable this resize UI.Enable it by setting the type of resize to perform
    /// Discrete: resize by a 10 pixels at a time
    /// Exact: resize to the exact width specified (in pixels)
    /// Note: This does not affect resizing by mouse dragging, just the keyboard driven resize.
    [<CustomOperation("ResizeType")>] member inline _.ResizeType ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<Microsoft.FluentUI.AspNetCore.Components.DataGridResizeType>) = render ==> ("ResizeType" => x)
    /// (Aria) Labels used in the column resize UI.
    [<CustomOperation("ColumnResizeLabels")>] member inline _.ColumnResizeLabels ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.FluentUI.AspNetCore.Components.ColumnResizeLabels) = render ==> ("ColumnResizeLabels" => x)
    /// Labels used in the column sort UI.
    [<CustomOperation("ColumnSortLabels")>] member inline _.ColumnSortLabels ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.FluentUI.AspNetCore.Components.ColumnSortLabels) = render ==> ("ColumnSortLabels" => x)
    /// Labels used in the column options UI.
    [<CustomOperation("ColumnOptionsLabels")>] member inline _.ColumnOptionsLabels ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.FluentUI.AspNetCore.Components.ColumnOptionsLabels) = render ==> ("ColumnOptionsLabels" => x)
    /// If true, enables the new style of header cell that includes a button to display all column options through a menu.
    ///             
    [<CustomOperation("HeaderCellAsButtonWithMenu")>] member inline _.HeaderCellAsButtonWithMenu ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("HeaderCellAsButtonWithMenu" =>>> true)
    /// If true, enables the new style of header cell that includes a button to display all column options through a menu.
    ///             
    [<CustomOperation("HeaderCellAsButtonWithMenu")>] member inline _.HeaderCellAsButtonWithMenu ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("HeaderCellAsButtonWithMenu" =>>> x)
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
    [<CustomOperation("Pagination")>] member inline _.Pagination ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.FluentUI.AspNetCore.Components.PaginationState) = render ==> ("Pagination" => x)
    /// Gets or sets a value indicating whether the component will not add itself to the tab queue.
    /// Default is false.
    [<CustomOperation("NoTabbing")>] member inline _.NoTabbing ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("NoTabbing" =>>> true)
    /// Gets or sets a value indicating whether the component will not add itself to the tab queue.
    /// Default is false.
    [<CustomOperation("NoTabbing")>] member inline _.NoTabbing ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("NoTabbing" =>>> x)
    /// Gets or sets a value indicating whether the grid should automatically generate a header row and its type.
    /// See GenerateHeaderOption
    [<CustomOperation("GenerateHeader")>] member inline _.GenerateHeader ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<Microsoft.FluentUI.AspNetCore.Components.GenerateHeaderOption>) = render ==> ("GenerateHeader" => x)
    /// Gets or sets the value that gets applied to the css gridTemplateColumns attribute of child rows.
    /// Can be specified here or on the column level with the Width parameter but not both.
    /// Needs to be a valid CSS string of space-separated values, such as "auto 1fr 2fr 100px".
    [<CustomOperation("GridTemplateColumns")>] member inline _.GridTemplateColumns ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("GridTemplateColumns" => x)
    /// Gets or sets a callback when a row is focused.
    /// As of 4.11 a row is a tr element with a 'display: contents'. Browsers can not focus such elements currently, but work is underway to fix that.
    [<CustomOperation("OnRowFocus")>] member inline _.OnRowFocus ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.FluentUI.AspNetCore.Components.FluentDataGridRow<'TGridItem> -> unit) = render ==> html.callback("OnRowFocus", fn)
    /// Gets or sets a callback when a row is focused.
    /// As of 4.11 a row is a tr element with a 'display: contents'. Browsers can not focus such elements currently, but work is underway to fix that.
    [<CustomOperation("OnRowFocus")>] member inline _.OnRowFocus ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.FluentUI.AspNetCore.Components.FluentDataGridRow<'TGridItem> -> Task<unit>) = render ==> html.callbackTask("OnRowFocus", fn)
    /// Gets or sets a callback when a row is focused.
    [<CustomOperation("OnCellFocus")>] member inline _.OnCellFocus ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.FluentUI.AspNetCore.Components.FluentDataGridCell<'TGridItem> -> unit) = render ==> html.callback("OnCellFocus", fn)
    /// Gets or sets a callback when a row is focused.
    [<CustomOperation("OnCellFocus")>] member inline _.OnCellFocus ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.FluentUI.AspNetCore.Components.FluentDataGridCell<'TGridItem> -> Task<unit>) = render ==> html.callbackTask("OnCellFocus", fn)
    /// Gets or sets a callback when a cell is clicked.
    [<CustomOperation("OnCellClick")>] member inline _.OnCellClick ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.FluentUI.AspNetCore.Components.FluentDataGridCell<'TGridItem> -> unit) = render ==> html.callback("OnCellClick", fn)
    /// Gets or sets a callback when a cell is clicked.
    [<CustomOperation("OnCellClick")>] member inline _.OnCellClick ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.FluentUI.AspNetCore.Components.FluentDataGridCell<'TGridItem> -> Task<unit>) = render ==> html.callbackTask("OnCellClick", fn)
    /// Gets or sets a callback when a row is clicked.
    [<CustomOperation("OnRowClick")>] member inline _.OnRowClick ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.FluentUI.AspNetCore.Components.FluentDataGridRow<'TGridItem> -> unit) = render ==> html.callback("OnRowClick", fn)
    /// Gets or sets a callback when a row is clicked.
    [<CustomOperation("OnRowClick")>] member inline _.OnRowClick ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.FluentUI.AspNetCore.Components.FluentDataGridRow<'TGridItem> -> Task<unit>) = render ==> html.callbackTask("OnRowClick", fn)
    /// Gets or sets a callback when a row is double-clicked.
    [<CustomOperation("OnRowDoubleClick")>] member inline _.OnRowDoubleClick ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.FluentUI.AspNetCore.Components.FluentDataGridRow<'TGridItem> -> unit) = render ==> html.callback("OnRowDoubleClick", fn)
    /// Gets or sets a callback when a row is double-clicked.
    [<CustomOperation("OnRowDoubleClick")>] member inline _.OnRowDoubleClick ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.FluentUI.AspNetCore.Components.FluentDataGridRow<'TGridItem> -> Task<unit>) = render ==> html.callbackTask("OnRowDoubleClick", fn)
    /// Optionally defines a class to be applied to a rendered row.
    [<CustomOperation("RowClass")>] member inline _.RowClass ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("RowClass" => (System.Func<'TGridItem, System.String>fn))
    /// Optionally defines a style to be applied to a rendered row.
    /// Do not use to dynamically update a row style after rendering as this will interfere with the script that use this attribute. Use RowClass instead.
    [<CustomOperation("RowStyle")>] member inline _.RowStyle ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("RowStyle" => (System.Func<'TGridItem, System.String>fn))
    /// Gets or sets a value indicating whether the grid should show a hover effect on rows.
    [<CustomOperation("ShowHover")>] member inline _.ShowHover ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("ShowHover" =>>> true)
    /// Gets or sets a value indicating whether the grid should show a hover effect on rows.
    [<CustomOperation("ShowHover")>] member inline _.ShowHover ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("ShowHover" =>>> x)
    /// If specified, grids render this fragment when there is no content.
    [<CustomOperation("EmptyContent")>] member inline _.EmptyContent ([<InlineIfLambda>] render: AttrRenderFragment, fragment: NodeRenderFragment) = render ==> html.renderFragment("EmptyContent", fragment)
    /// If specified, grids render this fragment when there is no content.
    [<CustomOperation("EmptyContent")>] member inline _.EmptyContent ([<InlineIfLambda>] render: AttrRenderFragment, fragments: NodeRenderFragment seq) = render ==> html.renderFragment("EmptyContent", fragment { yield! fragments })
    /// If specified, grids render this fragment when there is no content.
    [<CustomOperation("EmptyContent")>] member inline _.EmptyContent ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("EmptyContent", html.text x)
    /// If specified, grids render this fragment when there is no content.
    [<CustomOperation("EmptyContent")>] member inline _.EmptyContent ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("EmptyContent", html.text x)
    /// If specified, grids render this fragment when there is no content.
    [<CustomOperation("EmptyContent")>] member inline _.EmptyContent ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("EmptyContent", html.text x)
    /// Gets or sets a value to indicate the grid loading data state.
    /// If not set and a ItemsProvider is present, the grid will show LoadingContent until the provider's first return.
    [<CustomOperation("Loading")>] member inline _.Loading ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Boolean>) = render ==> ("Loading" => x)
    /// Gets or sets the content to render when Loading is true.
    /// A default fragment is used if loading content is not specified.
    [<CustomOperation("LoadingContent")>] member inline _.LoadingContent ([<InlineIfLambda>] render: AttrRenderFragment, fragment: NodeRenderFragment) = render ==> html.renderFragment("LoadingContent", fragment)
    /// Gets or sets the content to render when Loading is true.
    /// A default fragment is used if loading content is not specified.
    [<CustomOperation("LoadingContent")>] member inline _.LoadingContent ([<InlineIfLambda>] render: AttrRenderFragment, fragments: NodeRenderFragment seq) = render ==> html.renderFragment("LoadingContent", fragment { yield! fragments })
    /// Gets or sets the content to render when Loading is true.
    /// A default fragment is used if loading content is not specified.
    [<CustomOperation("LoadingContent")>] member inline _.LoadingContent ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("LoadingContent", html.text x)
    /// Gets or sets the content to render when Loading is true.
    /// A default fragment is used if loading content is not specified.
    [<CustomOperation("LoadingContent")>] member inline _.LoadingContent ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("LoadingContent", html.text x)
    /// Gets or sets the content to render when Loading is true.
    /// A default fragment is used if loading content is not specified.
    [<CustomOperation("LoadingContent")>] member inline _.LoadingContent ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("LoadingContent", html.text x)
    /// Sets GridTemplateColumns to automatically fit the columns to the available width as best it can.
    [<CustomOperation("AutoFit")>] member inline _.AutoFit ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("AutoFit" =>>> true)
    /// Sets GridTemplateColumns to automatically fit the columns to the available width as best it can.
    [<CustomOperation("AutoFit")>] member inline _.AutoFit ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("AutoFit" =>>> x)
    [<CustomOperation("DisplayMode")>] member inline _.DisplayMode ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.FluentUI.AspNetCore.Components.DataGridDisplayMode) = render ==> ("DisplayMode" => x)
    /// Gets or sets the size of each row in the grid based on the DataGridRowSize enum.
    [<CustomOperation("RowSize")>] member inline _.RowSize ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.FluentUI.AspNetCore.Components.DataGridRowSize) = render ==> ("RowSize" => x)
    /// Gets or sets a value indicating whether the grid should allow multiple lines of text in cells.
    [<CustomOperation("MultiLine")>] member inline _.MultiLine ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("MultiLine" =>>> true)
    /// Gets or sets a value indicating whether the grid should allow multiple lines of text in cells.
    [<CustomOperation("MultiLine")>] member inline _.MultiLine ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("MultiLine" =>>> x)
    /// Gets or sets a value indicating whether the grid should save its paging state in the URL.
    /// This is an experimental feature, which might cause unwanted jumping in the page when you change something in the grid.
    [<CustomOperation("SaveStateInUrl")>] member inline _.SaveStateInUrl ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("SaveStateInUrl" =>>> true)
    /// Gets or sets a value indicating whether the grid should save its paging state in the URL.
    /// This is an experimental feature, which might cause unwanted jumping in the page when you change something in the grid.
    [<CustomOperation("SaveStateInUrl")>] member inline _.SaveStateInUrl ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("SaveStateInUrl" =>>> x)
    /// Gets or sets a prefix to use when saving the grid state in the URL.
    [<CustomOperation("SaveStatePrefix")>] member inline _.SaveStatePrefix ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("SaveStatePrefix" => x)
    /// Gets or sets a value indicating whether the grids' first cell should be focused.
    [<CustomOperation("AutoFocus")>] member inline _.AutoFocus ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("AutoFocus" =>>> true)
    /// Gets or sets a value indicating whether the grids' first cell should be focused.
    [<CustomOperation("AutoFocus")>] member inline _.AutoFocus ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("AutoFocus" =>>> x)

type FluentDataGridCellBuilder<'FunBlazorGeneric, 'TGridItem when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentComponentBaseBuilder<'FunBlazorGeneric>()
    /// Gets or sets the reference to the item that holds this cell's values.
    [<CustomOperation("Item")>] member inline _.Item ([<InlineIfLambda>] render: AttrRenderFragment, x: 'TGridItem) = render ==> ("Item" => x)
    /// Gets or sets the cell type. See DataGridCellType.
    [<CustomOperation("CellType")>] member inline _.CellType ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.FluentUI.AspNetCore.Components.DataGridCellType) = render ==> ("CellType" => x)
    /// Gets or sets the column index of the cell.
    /// This will be applied to the css grid-column-index value applied to the cell.
    [<CustomOperation("GridColumn")>] member inline _.GridColumn ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("GridColumn" => x)

type FluentDataGridRowBuilder<'FunBlazorGeneric, 'TGridItem when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentComponentBaseBuilder<'FunBlazorGeneric>()
    /// Gets or sets the reference to the item that holds this row's values.
    [<CustomOperation("Item")>] member inline _.Item ([<InlineIfLambda>] render: AttrRenderFragment, x: 'TGridItem) = render ==> ("Item" => x)
    /// Gets or sets the index of this row.
    /// When FluentDataGrid is virtualized, this value is not used.
    [<CustomOperation("RowIndex")>] member inline _.RowIndex ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Int32>) = render ==> ("RowIndex" => x)
    /// Gets or sets the string that gets applied to the css gridTemplateColumns attribute for the row.
    [<CustomOperation("GridTemplateColumns")>] member inline _.GridTemplateColumns ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("GridTemplateColumns" => x)
    /// Gets or sets the type of row. See DataGridRowType.
    [<CustomOperation("RowType")>] member inline _.RowType ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<Microsoft.FluentUI.AspNetCore.Components.DataGridRowType>) = render ==> ("RowType" => x)
    [<CustomOperation("VerticalAlignment")>] member inline _.VerticalAlignment ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.FluentUI.AspNetCore.Components.VerticalAlignment) = render ==> ("VerticalAlignment" => x)
    [<CustomOperation("OnCellFocus")>] member inline _.OnCellFocus ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.FluentUI.AspNetCore.Components.FluentDataGridCell<'TGridItem> -> unit) = render ==> html.callback("OnCellFocus", fn)
    [<CustomOperation("OnCellFocus")>] member inline _.OnCellFocus ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.FluentUI.AspNetCore.Components.FluentDataGridCell<'TGridItem> -> Task<unit>) = render ==> html.callbackTask("OnCellFocus", fn)

type FluentDesignSystemProviderBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("NoPaint")>] member inline _.NoPaint ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Boolean>) = render ==> ("NoPaint" => x)
    [<CustomOperation("FillColor")>] member inline _.FillColor ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("FillColor" => x)
    [<CustomOperation("AccentBaseColor")>] member inline _.AccentBaseColor ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("AccentBaseColor" => x)
    [<CustomOperation("NeutralBaseColor")>] member inline _.NeutralBaseColor ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("NeutralBaseColor" => x)
    [<CustomOperation("Density")>] member inline _.Density ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Int32>) = render ==> ("Density" => x)
    [<CustomOperation("DesignUnit")>] member inline _.DesignUnit ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Int32>) = render ==> ("DesignUnit" => x)
    [<CustomOperation("Direction")>] member inline _.Direction ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<Microsoft.FluentUI.AspNetCore.Components.LocalizationDirection>) = render ==> ("Direction" => x)
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
    [<CustomOperation("PreventScroll")>] member inline _.PreventScroll ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("PreventScroll" =>>> true)
    /// Prevents scrolling outside of the dialog while it is shown.
    [<CustomOperation("PreventScroll")>] member inline _.PreventScroll ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("PreventScroll" =>>> x)
    /// Gets or sets a value indicating whether the element is modal. When modal, user mouse interaction will be limited to the contents of the element by a modal
    /// overlay. Clicks on the overlay will cause the dialog to emit a "dismiss" event.
    [<CustomOperation("Modal")>] member inline _.Modal ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Boolean>) = render ==> ("Modal" => x)
    /// Gets or sets a value indicating whether the dialog is hidden.
    [<CustomOperation("Hidden")>] member inline _.Hidden ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Hidden" =>>> true)
    /// Gets or sets a value indicating whether the dialog is hidden.
    [<CustomOperation("Hidden")>] member inline _.Hidden ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Hidden" =>>> x)
    /// Gets or sets a value indicating whether the dialog is hidden.
    [<CustomOperation("Hidden'")>] member inline _.Hidden' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.Boolean * (System.Boolean -> unit)) = render ==> html.bind("Hidden", valueFn)
    /// The event callback invoked when Hidden change.
    [<CustomOperation("HiddenChanged")>] member inline _.HiddenChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Boolean -> unit) = render ==> html.callback("HiddenChanged", fn)
    /// The event callback invoked when Hidden change.
    [<CustomOperation("HiddenChanged")>] member inline _.HiddenChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Boolean -> Task<unit>) = render ==> html.callbackTask("HiddenChanged", fn)
    /// Gets or sets a value indicating whether that the dialog should trap focus.
    [<CustomOperation("TrapFocus")>] member inline _.TrapFocus ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Boolean>) = render ==> ("TrapFocus" => x)
    /// Gets or sets the id of the element describing the dialog.
    [<CustomOperation("AriaDescribedby")>] member inline _.AriaDescribedby ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("AriaDescribedby" => x)
    /// Gets or sets the id of the element labeling the dialog.
    [<CustomOperation("AriaLabelledby")>] member inline _.AriaLabelledby ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("AriaLabelledby" => x)
    /// Gets or sets the label surfaced to assistive technologies.
    [<CustomOperation("AriaLabel")>] member inline _.AriaLabel ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("AriaLabel" => x)
    /// Gets or sets the instance containing the programmatic API for the dialog.
    [<CustomOperation("Instance")>] member inline _.Instance ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.FluentUI.AspNetCore.Components.DialogInstance) = render ==> ("Instance" => x)
    /// The event callback invoked to return the dialog result.
    [<CustomOperation("OnDialogResult")>] member inline _.OnDialogResult ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.FluentUI.AspNetCore.Components.DialogResult -> unit) = render ==> html.callback("OnDialogResult", fn)
    /// The event callback invoked to return the dialog result.
    [<CustomOperation("OnDialogResult")>] member inline _.OnDialogResult ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.FluentUI.AspNetCore.Components.DialogResult -> Task<unit>) = render ==> html.callbackTask("OnDialogResult", fn)

type FluentDialogBodyBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentComponentBaseBuilder<'FunBlazorGeneric>()


type FluentDialogFooterBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentComponentBaseBuilder<'FunBlazorGeneric>()
    /// When true, the footer is visible.
    /// Default is True.
    [<CustomOperation("Visible")>] member inline _.Visible ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Visible" =>>> true)
    /// When true, the footer is visible.
    /// Default is True.
    [<CustomOperation("Visible")>] member inline _.Visible ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Visible" =>>> x)

type FluentDialogHeaderBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentComponentBaseBuilder<'FunBlazorGeneric>()
    /// When true, the header is visible.
    /// Default is True.
    [<CustomOperation("Visible")>] member inline _.Visible ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Visible" =>>> true)
    /// When true, the header is visible.
    /// Default is True.
    [<CustomOperation("Visible")>] member inline _.Visible ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Visible" =>>> x)
    /// When true, shows the dismiss button in the header.
    /// If defined, this value will replace the one defined in the DialogParameters.
    [<CustomOperation("ShowDismiss")>] member inline _.ShowDismiss ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Boolean>) = render ==> ("ShowDismiss" => x)
    /// When true, shows the "Close" button tooltip in the header.
    [<CustomOperation("ShowDismissTooltip")>] member inline _.ShowDismissTooltip ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Boolean>) = render ==> ("ShowDismissTooltip" => x)
    /// Allows developers to make elements sequentially focusable and determine their relative ordering for navigation (usually with the Tab key).
    [<CustomOperation("TabIndex")>] member inline _.TabIndex ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Int32>) = render ==> ("TabIndex" => x)

type FluentDividerBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentComponentBaseBuilder<'FunBlazorGeneric>()
    /// Gets or sets the role of the element.
    [<CustomOperation("Role")>] member inline _.Role ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<Microsoft.FluentUI.AspNetCore.Components.DividerRole>) = render ==> ("Role" => x)
    /// Gets or sets the orientation of the divider.
    [<CustomOperation("Orientation")>] member inline _.Orientation ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<Microsoft.FluentUI.AspNetCore.Components.Orientation>) = render ==> ("Orientation" => x)

type FluentDragContainerBuilder<'FunBlazorGeneric, 'TItem when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentComponentBaseBuilder<'FunBlazorGeneric>()
    /// This event is fired when the user starts dragging an element.
    [<CustomOperation("OnDragStart")>] member inline _.OnDragStart ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("OnDragStart" => (System.Action<Microsoft.FluentUI.AspNetCore.Components.FluentDragEventArgs<'TItem>>fn))
    /// This event is fired when the drag operation ends (such as releasing a mouse button or hitting the Esc key).
    [<CustomOperation("OnDragEnd")>] member inline _.OnDragEnd ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("OnDragEnd" => (System.Action<Microsoft.FluentUI.AspNetCore.Components.FluentDragEventArgs<'TItem>>fn))
    /// This event is fired when a dragged element enters a valid drop target.
    [<CustomOperation("OnDragEnter")>] member inline _.OnDragEnter ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("OnDragEnter" => (System.Action<Microsoft.FluentUI.AspNetCore.Components.FluentDragEventArgs<'TItem>>fn))
    /// This event is fired when an element is being dragged over a valid drop target.
    [<CustomOperation("OnDragOver")>] member inline _.OnDragOver ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("OnDragOver" => (System.Action<Microsoft.FluentUI.AspNetCore.Components.FluentDragEventArgs<'TItem>>fn))
    /// This event is fired when a dragged element leaves a valid drop target.
    [<CustomOperation("OnDragLeave")>] member inline _.OnDragLeave ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("OnDragLeave" => (System.Action<Microsoft.FluentUI.AspNetCore.Components.FluentDragEventArgs<'TItem>>fn))
    /// This event is fired when an element is dropped on a valid drop target.
    [<CustomOperation("OnDropEnd")>] member inline _.OnDropEnd ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("OnDropEnd" => (System.Action<Microsoft.FluentUI.AspNetCore.Components.FluentDragEventArgs<'TItem>>fn))

type FluentDropZoneBuilder<'FunBlazorGeneric, 'TItem when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentComponentBaseBuilder<'FunBlazorGeneric>()
    /// Gets or sets the item to identify a draggable zone.
    [<CustomOperation("Item")>] member inline _.Item ([<InlineIfLambda>] render: AttrRenderFragment, x: 'TItem) = render ==> ("Item" => x)
    /// Gets or sets a value indicating whether the element can receive a dragged item.
    [<CustomOperation("Droppable")>] member inline _.Droppable ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Droppable" =>>> true)
    /// Gets or sets a value indicating whether the element can receive a dragged item.
    [<CustomOperation("Droppable")>] member inline _.Droppable ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Droppable" =>>> x)
    /// Gets or sets a value indicating whether the element can be dragged.
    [<CustomOperation("Draggable")>] member inline _.Draggable ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Draggable" =>>> true)
    /// Gets or sets a value indicating whether the element can be dragged.
    [<CustomOperation("Draggable")>] member inline _.Draggable ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Draggable" =>>> x)
    /// This event is fired when the user starts dragging an element.
    [<CustomOperation("OnDragStart")>] member inline _.OnDragStart ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("OnDragStart" => (System.Action<Microsoft.FluentUI.AspNetCore.Components.FluentDragEventArgs<'TItem>>fn))
    /// This event is fired when the drag operation ends (such as releasing a mouse button or hitting the Esc key).
    [<CustomOperation("OnDragEnd")>] member inline _.OnDragEnd ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("OnDragEnd" => (System.Action<Microsoft.FluentUI.AspNetCore.Components.FluentDragEventArgs<'TItem>>fn))
    /// This event is fired when a dragged element enters a valid drop target.
    [<CustomOperation("OnDragEnter")>] member inline _.OnDragEnter ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("OnDragEnter" => (System.Action<Microsoft.FluentUI.AspNetCore.Components.FluentDragEventArgs<'TItem>>fn))
    /// This event is fired when an element is being dragged over a valid drop target.
    [<CustomOperation("OnDragOver")>] member inline _.OnDragOver ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("OnDragOver" => (System.Action<Microsoft.FluentUI.AspNetCore.Components.FluentDragEventArgs<'TItem>>fn))
    /// This event is fired when a dragged element leaves a valid drop target.
    [<CustomOperation("OnDragLeave")>] member inline _.OnDragLeave ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("OnDragLeave" => (System.Action<Microsoft.FluentUI.AspNetCore.Components.FluentDragEventArgs<'TItem>>fn))
    /// This event is fired when an element is dropped on a valid drop target.
    [<CustomOperation("OnDropEnd")>] member inline _.OnDropEnd ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("OnDropEnd" => (System.Action<Microsoft.FluentUI.AspNetCore.Components.FluentDragEventArgs<'TItem>>fn))

/// FluentEmoji is a component that renders an emoji from the Microsoft FluentUI emoji set.
type FluentEmojiBuilder<'FunBlazorGeneric, 'Emoji when 'Emoji : (new : unit -> 'Emoji) and 'Emoji :> Microsoft.FluentUI.AspNetCore.Components.Emoji and 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
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
    [<CustomOperation("OnClick")>] member inline _.OnClick ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.AspNetCore.Components.Web.MouseEventArgs -> unit) = render ==> html.callback("OnClick", fn)
    /// Allows for capturing a mouse click on an emoji
    [<CustomOperation("OnClick")>] member inline _.OnClick ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.AspNetCore.Components.Web.MouseEventArgs -> Task<unit>) = render ==> html.callbackTask("OnClick", fn)

type FluentFlipperBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentComponentBaseBuilder<'FunBlazorGeneric>()
    /// Gets or sets a value indicating whether the element is disabled.
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Boolean>) = render ==> ("Disabled" => x)
    /// Gets or sets a value indicating whether the flipper should be hidden from assistive technology. Because flippers are often supplementary navigation, they are often hidden from assistive technology.
    [<CustomOperation("AriaHidden")>] member inline _.AriaHidden ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Boolean>) = render ==> ("AriaHidden" => x)
    /// Gets or sets the direction. See FlipperDirection.
    [<CustomOperation("Direction")>] member inline _.Direction ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<Microsoft.FluentUI.AspNetCore.Components.FlipperDirection>) = render ==> ("Direction" => x)

type FluentFooterBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentComponentBaseBuilder<'FunBlazorGeneric>()


/// Displays a list of validation messages for a specified field within a cascaded EditContext.
type FluentValidationMessageBuilder<'FunBlazorGeneric, 'TValue when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentComponentBaseBuilder<'FunBlazorGeneric>()
    /// Gets or sets the FieldIdentifier for which validation messages should be displayed.
    /// If set, this parameter takes precedence over For.
    [<CustomOperation("Field")>] member inline _.Field ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<Microsoft.AspNetCore.Components.Forms.FieldIdentifier>) = render ==> ("Field" => x)
    /// Gets or sets the field for which validation messages should be displayed.
    [<CustomOperation("For'")>] member inline _.For' ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Linq.Expressions.Expression<System.Func<'TValue>>) = render ==> ("For" => x)

/// The grid component helps keeping layout consistent across various screen resolutions and sizes.
/// PowerGrid comes with a 12-point grid system and contains 5 types of breakpoints
/// that are used for specific screen sizes.
type FluentGridBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentComponentBaseBuilder<'FunBlazorGeneric>()
    /// Gets or sets the distance between flexbox items, using a multiple of 4px.
    /// Only values from 0 to 10 are possible.
    [<CustomOperation("Spacing")>] member inline _.Spacing ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("Spacing" => x)
    /// Defines how the browser distributes space between and around content items.
    [<CustomOperation("Justify")>] member inline _.Justify ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.FluentUI.AspNetCore.Components.JustifyContent) = render ==> ("Justify" => x)
    /// Gets or sets the adaptive rendering, which not render the HTML code when the item is hidden (true) or only hide the item by CSS (false).
    /// Default is false.
    [<CustomOperation("AdaptiveRendering")>] member inline _.AdaptiveRendering ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("AdaptiveRendering" =>>> true)
    /// Gets or sets the adaptive rendering, which not render the HTML code when the item is hidden (true) or only hide the item by CSS (false).
    /// Default is false.
    [<CustomOperation("AdaptiveRendering")>] member inline _.AdaptiveRendering ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("AdaptiveRendering" =>>> x)
    /// when page size falls within a specific size range (xs, sm, md, lg, xl, xxl).
    [<CustomOperation("OnBreakpointEnter")>] member inline _.OnBreakpointEnter ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.FluentUI.AspNetCore.Components.GridItemSize -> unit) = render ==> html.callback("OnBreakpointEnter", fn)
    /// when page size falls within a specific size range (xs, sm, md, lg, xl, xxl).
    [<CustomOperation("OnBreakpointEnter")>] member inline _.OnBreakpointEnter ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.FluentUI.AspNetCore.Components.GridItemSize -> Task<unit>) = render ==> html.callbackTask("OnBreakpointEnter", fn)

type FluentGridItemBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentComponentBaseBuilder<'FunBlazorGeneric>()
    /// The number of columns the item should span in the 12-column grid system.
    /// Extra Small (xs) devices (portrait phones, less than 600px wide)
    [<CustomOperation("xs")>] member inline _.xs ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Int32>) = render ==> ("xs" => x)
    /// The number of columns the item should span in the 12-column grid system.
    /// Small (sm) devices (landscape phones, less than 960px wide)
    [<CustomOperation("sm")>] member inline _.sm ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Int32>) = render ==> ("sm" => x)
    /// The number of columns the item should span in the 12-column grid system.
    /// Medium (md) devices (tablets, less than 1280px wide)
    [<CustomOperation("md")>] member inline _.md ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Int32>) = render ==> ("md" => x)
    /// The number of columns the item should span in the 12-column grid system.
    /// Large (lg) devices (desktops, less than 1920px wide)
    [<CustomOperation("lg")>] member inline _.lg ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Int32>) = render ==> ("lg" => x)
    /// The number of columns the item should span in the 12-column grid system.
    /// Extra large (xl) devices (large desktops, less than 2560px wide)
    [<CustomOperation("xl")>] member inline _.xl ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Int32>) = render ==> ("xl" => x)
    /// The number of columns the item should span in the 12-column grid system.
    /// Extra extra large (xxl) devices (larger desktops, more than 2560px wide)
    [<CustomOperation("xxl")>] member inline _.xxl ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Int32>) = render ==> ("xxl" => x)
    /// Defines how the browser distributes space between and around content items.
    [<CustomOperation("Justify")>] member inline _.Justify ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<Microsoft.FluentUI.AspNetCore.Components.JustifyContent>) = render ==> ("Justify" => x)
    /// Gets or sets the gaps (gutters) between rows and columns.
    /// See https://developer.mozilla.org/en-US/docs/Web/CSS/gap
    [<CustomOperation("Gap")>] member inline _.Gap ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Gap" => x)
    /// Gets or sets the adaptive rendering, which not render the HTML code when the item is hidden (true) or only hide the item by CSS (false).
    /// Default is false.
    [<CustomOperation("AdaptiveRendering")>] member inline _.AdaptiveRendering ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Boolean>) = render ==> ("AdaptiveRendering" => x)
    /// Hide the item on the specified sizes (you can combine multiple values: GridItemHidden.Sm | GridItemHidden.Xl).
    [<CustomOperation("HiddenWhen")>] member inline _.HiddenWhen ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<Microsoft.FluentUI.AspNetCore.Components.GridItemHidden>) = render ==> ("HiddenWhen" => x)

type FluentHeaderBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentComponentBaseBuilder<'FunBlazorGeneric>()
    /// Gets or sets the height of the header (in pixels).
    [<CustomOperation("Height")>] member inline _.Height ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Int32>) = render ==> ("Height" => x)

type FluentHighlighterBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentComponentBaseBuilder<'FunBlazorGeneric>()
    /// Gets or sets a value indicating whether the highlighted text is case sensitive.
    [<CustomOperation("CaseSensitive")>] member inline _.CaseSensitive ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("CaseSensitive" =>>> true)
    /// Gets or sets a value indicating whether the highlighted text is case sensitive.
    [<CustomOperation("CaseSensitive")>] member inline _.CaseSensitive ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("CaseSensitive" =>>> x)
    /// Gets or sets the fragment of text to be highlighted.
    [<CustomOperation("HighlightedText")>] member inline _.HighlightedText ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("HighlightedText" => x)
    /// Gets or sets the whole text in which a fragment will be highlighted.
    [<CustomOperation("Text")>] member inline _.Text ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Text" => x)
    /// Gets or sets the list of delimiters chars. Example: " ,;".
    [<CustomOperation("Delimiters")>] member inline _.Delimiters ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Delimiters" => x)
    /// If true, highlights the text until the next regex boundary.
    [<CustomOperation("UntilNextBoundary")>] member inline _.UntilNextBoundary ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("UntilNextBoundary" =>>> true)
    /// If true, highlights the text until the next regex boundary.
    [<CustomOperation("UntilNextBoundary")>] member inline _.UntilNextBoundary ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("UntilNextBoundary" =>>> x)

type FluentHorizontalScrollBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentComponentBaseBuilder<'FunBlazorGeneric>()
    /// Gets or sets the scroll speed in pixels per second.
    [<CustomOperation("Speed")>] member inline _.Speed ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("Speed" => x)
    /// Gets or sets the CSS time value for the scroll transition duration. Overrides the `speed` attribute.
    [<CustomOperation("Duration")>] member inline _.Duration ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Duration" => x)
    /// Gets or sets the attribute used for easing, defaults to ease-in-out.
    [<CustomOperation("Easing")>] member inline _.Easing ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<Microsoft.FluentUI.AspNetCore.Components.ScrollEasing>) = render ==> ("Easing" => x)
    /// Gets or sets the attribute to hide flippers from assistive technology.
    [<CustomOperation("FlippersHiddenFromAt")>] member inline _.FlippersHiddenFromAt ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Boolean>) = render ==> ("FlippersHiddenFromAt" => x)
    /// Gets or sets the view: default | mobile.
    [<CustomOperation("View")>] member inline _.View ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<Microsoft.FluentUI.AspNetCore.Components.HorizontalScrollView>) = render ==> ("View" => x)

/// FluentIcon is a component that renders an icon from the Fluent System icon set.
type FluentIconBuilder<'FunBlazorGeneric, 'Icon when 'Icon : (new : unit -> 'Icon) and 'Icon :> Microsoft.FluentUI.AspNetCore.Components.Icon and 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentComponentBaseBuilder<'FunBlazorGeneric>()
    /// Gets or sets the slot where the icon is displayed in.
    [<CustomOperation("Slot")>] member inline _.Slot ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Slot" => x)
    /// Gets or sets the title for the icon.
    [<CustomOperation("Title")>] member inline _.Title ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Title" => x)
    /// Gets or sets the icon drawing and fill color. 
    /// Value comes from the Color enumeration. Defaults to Accent.
    [<CustomOperation("Color")>] member inline _.Color ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<Microsoft.FluentUI.AspNetCore.Components.Color>) = render ==> ("Color" => x)
    /// Gets or sets the icon drawing and fill color to a custom value.
    /// Needs to be formatted as an HTML hex color string (#rrggbb or #rgb) or CSS variable.
    /// ⚠️ Only available when Color is set to Color.Custom.
    [<CustomOperation("CustomColor")>] member inline _.CustomColor ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("CustomColor" => x)
    /// Gets or sets the icon width.
    /// If not set, the icon size will be used.
    [<CustomOperation("Width")>] member inline _.Width ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Width" => x)
    /// Gets or sets the Icon object to render.
    [<CustomOperation("Value")>] member inline _.Value ([<InlineIfLambda>] render: AttrRenderFragment, x: 'Icon) = render ==> ("Value" => x)
    /// Allows for capturing a mouse click on an icon.
    [<CustomOperation("OnClick")>] member inline _.OnClick ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.AspNetCore.Components.Web.MouseEventArgs -> unit) = render ==> html.callback("OnClick", fn)
    /// Allows for capturing a mouse click on an icon.
    [<CustomOperation("OnClick")>] member inline _.OnClick ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.AspNetCore.Components.Web.MouseEventArgs -> Task<unit>) = render ==> html.callbackTask("OnClick", fn)
    /// Gets or sets whether the icon is focusable (adding tabindex="0" and role="button"),
    /// allows the icon to be focused sequentially (generally with the Tab key).
    [<CustomOperation("Focusable")>] member inline _.Focusable ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Focusable" =>>> true)
    /// Gets or sets whether the icon is focusable (adding tabindex="0" and role="button"),
    /// allows the icon to be focused sequentially (generally with the Tab key).
    [<CustomOperation("Focusable")>] member inline _.Focusable ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Focusable" =>>> x)

type FluentInputFileBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentComponentBaseBuilder<'FunBlazorGeneric>()
    /// To enable multiple file selection and upload, set the Multiple property to true.
    /// Set MaximumFileCount to change the number of allowed files.
    [<CustomOperation("Multiple")>] member inline _.Multiple ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Multiple" =>>> true)
    /// To enable multiple file selection and upload, set the Multiple property to true.
    /// Set MaximumFileCount to change the number of allowed files.
    [<CustomOperation("Multiple")>] member inline _.Multiple ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Multiple" =>>> x)
    /// To select multiple files, set the maximum number of files allowed to be uploaded.
    /// Default value is 10.
    [<CustomOperation("MaximumFileCount")>] member inline _.MaximumFileCount ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("MaximumFileCount" => x)
    /// Gets or sets the maximum size of a file to be uploaded (in bytes).
    /// Default value is 10 MB.
    [<CustomOperation("MaximumFileSize")>] member inline _.MaximumFileSize ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int64) = render ==> ("MaximumFileSize" => x)
    /// Gets or sets the sze of buffer to read bytes from uploaded file (in bytes).
    /// Default value is 10 KB.
    [<CustomOperation("BufferSize")>] member inline _.BufferSize ([<InlineIfLambda>] render: AttrRenderFragment, x: System.UInt32) = render ==> ("BufferSize" => x)
    /// Gets or sets the filter for what file types the user can pick from the file input dialog box.
    /// Example: ".gif, .jpg, .png, .doc", "audio/*", "video/*", "image/*"
    /// See https://developer.mozilla.org/en-US/docs/Web/HTML/Attributes/accept
    /// for more information.
    [<CustomOperation("Accept")>] member inline _.Accept ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Accept" => x)
    /// Disables the form control, ensuring it doesn't participate in form submission.
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Disabled" =>>> true)
    /// Disables the form control, ensuring it doesn't participate in form submission.
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Disabled" =>>> x)
    /// Gets or sets the type of file reading.
    /// For SaveToTemporaryFolder, use LocalFile to retrieve the file.
    /// For Buffer, use Buffer to retrieve bytes.
    [<CustomOperation("Mode")>] member inline _.Mode ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.FluentUI.AspNetCore.Components.InputFileMode) = render ==> ("Mode" => x)
    /// Gets or sets a value indicating whether the Drag/Drop zone is visible.
    /// Default is true.
    [<CustomOperation("DragDropZoneVisible")>] member inline _.DragDropZoneVisible ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("DragDropZoneVisible" =>>> true)
    /// Gets or sets a value indicating whether the Drag/Drop zone is visible.
    /// Default is true.
    [<CustomOperation("DragDropZoneVisible")>] member inline _.DragDropZoneVisible ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("DragDropZoneVisible" =>>> x)
    /// Gets or sets the progress content of the component.
    [<CustomOperation("ProgressTemplate")>] member inline _.ProgressTemplate ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.FluentUI.AspNetCore.Components.ProgressFileDetails -> NodeRenderFragment) = render ==> html.renderFragment("ProgressTemplate", fn)
    /// Use the native event raised by the InputFile component.
    /// If you use this event, the OnFileUploaded will never be raised.
    [<CustomOperation("OnInputFileChange")>] member inline _.OnInputFileChange ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.AspNetCore.Components.Forms.InputFileChangeEventArgs -> unit) = render ==> html.callback("OnInputFileChange", fn)
    /// Use the native event raised by the InputFile component.
    /// If you use this event, the OnFileUploaded will never be raised.
    [<CustomOperation("OnInputFileChange")>] member inline _.OnInputFileChange ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.AspNetCore.Components.Forms.InputFileChangeEventArgs -> Task<unit>) = render ==> html.callbackTask("OnInputFileChange", fn)
    /// Raise when a file is completely uploaded.
    [<CustomOperation("OnFileUploaded")>] member inline _.OnFileUploaded ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.FluentUI.AspNetCore.Components.FluentInputFileEventArgs -> unit) = render ==> html.callback("OnFileUploaded", fn)
    /// Raise when a file is completely uploaded.
    [<CustomOperation("OnFileUploaded")>] member inline _.OnFileUploaded ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.FluentUI.AspNetCore.Components.FluentInputFileEventArgs -> Task<unit>) = render ==> html.callbackTask("OnFileUploaded", fn)
    /// Raise when a progression step is updated.
    /// You can use ProgressPercent and ProgressTitle to have more detail on the progression.
    [<CustomOperation("OnProgressChange")>] member inline _.OnProgressChange ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.FluentUI.AspNetCore.Components.FluentInputFileEventArgs -> unit) = render ==> html.callback("OnProgressChange", fn)
    /// Raise when a progression step is updated.
    /// You can use ProgressPercent and ProgressTitle to have more detail on the progression.
    [<CustomOperation("OnProgressChange")>] member inline _.OnProgressChange ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.FluentUI.AspNetCore.Components.FluentInputFileEventArgs -> Task<unit>) = render ==> html.callbackTask("OnProgressChange", fn)
    /// Raise when a file raised an error. Not yet used.
    [<CustomOperation("OnFileError")>] member inline _.OnFileError ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.FluentUI.AspNetCore.Components.FluentInputFileEventArgs -> unit) = render ==> html.callback("OnFileError", fn)
    /// Raise when a file raised an error. Not yet used.
    [<CustomOperation("OnFileError")>] member inline _.OnFileError ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.FluentUI.AspNetCore.Components.FluentInputFileEventArgs -> Task<unit>) = render ==> html.callbackTask("OnFileError", fn)
    /// Raise when all files are completely uploaded.
    [<CustomOperation("OnCompleted")>] member inline _.OnCompleted ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Collections.Generic.IEnumerable<Microsoft.FluentUI.AspNetCore.Components.FluentInputFileEventArgs> -> unit) = render ==> html.callback("OnCompleted", fn)
    /// Raise when all files are completely uploaded.
    [<CustomOperation("OnCompleted")>] member inline _.OnCompleted ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Collections.Generic.IEnumerable<Microsoft.FluentUI.AspNetCore.Components.FluentInputFileEventArgs> -> Task<unit>) = render ==> html.callbackTask("OnCompleted", fn)
    /// Gets or sets the identifier of the source component clickable by the end user.
    [<CustomOperation("AnchorId")>] member inline _.AnchorId ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("AnchorId" => x)
    /// Gets or sets the current global value of the percentage of a current upload.
    [<CustomOperation("ProgressPercent")>] member inline _.ProgressPercent ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("ProgressPercent" => x)
    /// Gets or sets the current global value of the percentage of a current upload.
    [<CustomOperation("ProgressPercent'")>] member inline _.ProgressPercent' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.Int32 * (System.Int32 -> unit)) = render ==> html.bind("ProgressPercent", valueFn)
    /// Gets or sets a callback that updates the ProgressPercent.
    [<CustomOperation("ProgressPercentChanged")>] member inline _.ProgressPercentChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Int32 -> unit) = render ==> html.callback("ProgressPercentChanged", fn)
    /// Gets or sets a callback that updates the ProgressPercent.
    [<CustomOperation("ProgressPercentChanged")>] member inline _.ProgressPercentChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Int32 -> Task<unit>) = render ==> html.callbackTask("ProgressPercentChanged", fn)

type FluentLabelBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentComponentBaseBuilder<'FunBlazorGeneric>()
    /// Applies the theme typography styles.
    [<CustomOperation("Typo")>] member inline _.Typo ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.FluentUI.AspNetCore.Components.Typography) = render ==> ("Typo" => x)
    /// Activates or deactivates the component (changes the color).
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Disabled" =>>> true)
    /// Activates or deactivates the component (changes the color).
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Disabled" =>>> x)
    /// Gets or sets the text-align on the component.
    [<CustomOperation("Alignment")>] member inline _.Alignment ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<Microsoft.FluentUI.AspNetCore.Components.HorizontalAlignment>) = render ==> ("Alignment" => x)
    /// Gets or sets the color of the component. It supports the theme colors.
    [<CustomOperation("Color")>] member inline _.Color ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<Microsoft.FluentUI.AspNetCore.Components.Color>) = render ==> ("Color" => x)
    /// Gets or sets the color of the label to a custom value.
    /// Needs to be formatted as a valid CSS color value (HTML hex color string (#rrggbb or #rgb), CSS variable or named color).
    /// ⚠️ Only available when Color is set to Color.Custom.
    [<CustomOperation("CustomColor")>] member inline _.CustomColor ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("CustomColor" => x)
    /// Gets or sets the font weight of the component:
    /// Normal (400), Bold (600) or Bolder (800).
    [<CustomOperation("Weight")>] member inline _.Weight ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.FluentUI.AspNetCore.Components.FontWeight) = render ==> ("Weight" => x)
    /// Gets or sets the margin block of the component.
    /// "default" to use the margin-block prefefined by browser.
    /// If not set, the MarginBlock will be 0px.
    [<CustomOperation("MarginBlock")>] member inline _.MarginBlock ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("MarginBlock" => x)

type FluentLayoutBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentComponentBaseBuilder<'FunBlazorGeneric>()
    /// Gets or sets the orientation of the stacked components.
    [<CustomOperation("Orientation")>] member inline _.Orientation ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.FluentUI.AspNetCore.Components.Orientation) = render ==> ("Orientation" => x)

type FluentOptionBuilder<'FunBlazorGeneric, 'TOption when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentComponentBaseBuilder<'FunBlazorGeneric>()
    /// Gets or sets a value indicating whether the element is disabled.
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Disabled" =>>> true)
    /// Gets or sets a value indicating whether the element is disabled.
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Disabled" =>>> x)
    /// Gets or sets the value of this option.
    [<CustomOperation("Value")>] member inline _.Value ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Value" => x)
    /// Gets or sets a value indicating whether the element is selected.
    [<CustomOperation("Selected")>] member inline _.Selected ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Selected" =>>> true)
    /// Gets or sets a value indicating whether the element is selected.
    [<CustomOperation("Selected")>] member inline _.Selected ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Selected" =>>> x)
    /// Gets or sets a value indicating whether the element is selected.
    [<CustomOperation("Selected'")>] member inline _.Selected' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.Boolean * (System.Boolean -> unit)) = render ==> html.bind("Selected", valueFn)
    /// Called whenever the selection changed.
    [<CustomOperation("SelectedChanged")>] member inline _.SelectedChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Boolean -> unit) = render ==> html.callback("SelectedChanged", fn)
    /// Called whenever the selection changed.
    [<CustomOperation("SelectedChanged")>] member inline _.SelectedChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Boolean -> Task<unit>) = render ==> html.callbackTask("SelectedChanged", fn)
    /// Called whenever the selection changed.
    [<CustomOperation("OnSelect")>] member inline _.OnSelect ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.String -> unit) = render ==> html.callback("OnSelect", fn)
    /// Called whenever the selection changed.
    [<CustomOperation("OnSelect")>] member inline _.OnSelect ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.String -> Task<unit>) = render ==> html.callbackTask("OnSelect", fn)

/// People picker option component.
type FluentPersonaBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentComponentBaseBuilder<'FunBlazorGeneric>()
    /// Gets or sets the initials to display if no image is provided.
    /// By default, the first letters of the Name is used.
    [<CustomOperation("Initials")>] member inline _.Initials ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Initials" => x)
    /// Gets or sets the name to display.
    [<CustomOperation("Name")>] member inline _.Name ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Name" => x)
    /// Gets or sets the image to display, in replacement of the initials.
    [<CustomOperation("Image")>] member inline _.Image ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Image" => x)
    /// Gets or sets the size of the image.
    [<CustomOperation("ImageSize")>] member inline _.ImageSize ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("ImageSize" => x)
    /// Gets or sets the TextPosition of the text.
    /// Default is End.
    [<CustomOperation("TextPosition")>] member inline _.TextPosition ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.FluentUI.AspNetCore.Components.TextPosition) = render ==> ("TextPosition" => x)
    /// Gets or sets the status to show. See PresenceStatus for options.
    [<CustomOperation("Status")>] member inline _.Status ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<Microsoft.FluentUI.AspNetCore.Components.PresenceStatus>) = render ==> ("Status" => x)
    /// Gets or sets the title to show on hover. If not provided, the status will be used.
    [<CustomOperation("StatusTitle")>] member inline _.StatusTitle ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("StatusTitle" => x)
    /// Gets or sets the Status size to use.
    /// Default is ExtraSmall.
    [<CustomOperation("StatusSize")>] member inline _.StatusSize ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.FluentUI.AspNetCore.Components.PresenceBadgeSize) = render ==> ("StatusSize" => x)
    /// Gets or sets the event raised when the user clicks on this Persona.
    [<CustomOperation("OnClick")>] member inline _.OnClick ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.AspNetCore.Components.Web.MouseEventArgs -> unit) = render ==> html.callback("OnClick", fn)
    /// Gets or sets the event raised when the user clicks on this Persona.
    [<CustomOperation("OnClick")>] member inline _.OnClick ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.AspNetCore.Components.Web.MouseEventArgs -> Task<unit>) = render ==> html.callbackTask("OnClick", fn)
    /// Gets or sets the event raised when the user clicks on the dismiss button.
    [<CustomOperation("OnDismissClick")>] member inline _.OnDismissClick ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: unit -> unit) = render ==> html.callback("OnDismissClick", fn)
    /// Gets or sets the event raised when the user clicks on the dismiss button.
    [<CustomOperation("OnDismissClick")>] member inline _.OnDismissClick ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: unit -> Task<unit>) = render ==> html.callbackTask("OnDismissClick", fn)
    /// Gets or sets the title of the dismiss button.
    [<CustomOperation("DismissTitle")>] member inline _.DismissTitle ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("DismissTitle" => x)

type FluentMainLayoutBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentComponentBaseBuilder<'FunBlazorGeneric>()
    /// Gets or sets the header content.
    [<CustomOperation("Header")>] member inline _.Header ([<InlineIfLambda>] render: AttrRenderFragment, fragment: NodeRenderFragment) = render ==> html.renderFragment("Header", fragment)
    /// Gets or sets the header content.
    [<CustomOperation("Header")>] member inline _.Header ([<InlineIfLambda>] render: AttrRenderFragment, fragments: NodeRenderFragment seq) = render ==> html.renderFragment("Header", fragment { yield! fragments })
    /// Gets or sets the header content.
    [<CustomOperation("Header")>] member inline _.Header ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("Header", html.text x)
    /// Gets or sets the header content.
    [<CustomOperation("Header")>] member inline _.Header ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("Header", html.text x)
    /// Gets or sets the header content.
    [<CustomOperation("Header")>] member inline _.Header ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("Header", html.text x)
    /// Gets or sets the sub header content.
    [<CustomOperation("SubHeader")>] member inline _.SubHeader ([<InlineIfLambda>] render: AttrRenderFragment, fragment: NodeRenderFragment) = render ==> html.renderFragment("SubHeader", fragment)
    /// Gets or sets the sub header content.
    [<CustomOperation("SubHeader")>] member inline _.SubHeader ([<InlineIfLambda>] render: AttrRenderFragment, fragments: NodeRenderFragment seq) = render ==> html.renderFragment("SubHeader", fragment { yield! fragments })
    /// Gets or sets the sub header content.
    [<CustomOperation("SubHeader")>] member inline _.SubHeader ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("SubHeader", html.text x)
    /// Gets or sets the sub header content.
    [<CustomOperation("SubHeader")>] member inline _.SubHeader ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("SubHeader", html.text x)
    /// Gets or sets the sub header content.
    [<CustomOperation("SubHeader")>] member inline _.SubHeader ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("SubHeader", html.text x)
    /// Gets or sets the height of the header (in pixels).
    [<CustomOperation("HeaderHeight")>] member inline _.HeaderHeight ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Int32>) = render ==> ("HeaderHeight" => x)
    /// Gets or sets the title of the navigation menu.
    [<CustomOperation("NavMenuTitle")>] member inline _.NavMenuTitle ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("NavMenuTitle" => x)
    /// Gets or sets the width of the navigation menu.
    [<CustomOperation("NavMenuWidth")>] member inline _.NavMenuWidth ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("NavMenuWidth" => x)
    /// Gets or sets the content of the navigation menu.
    [<CustomOperation("NavMenuContent")>] member inline _.NavMenuContent ([<InlineIfLambda>] render: AttrRenderFragment, fragment: NodeRenderFragment) = render ==> html.renderFragment("NavMenuContent", fragment)
    /// Gets or sets the content of the navigation menu.
    [<CustomOperation("NavMenuContent")>] member inline _.NavMenuContent ([<InlineIfLambda>] render: AttrRenderFragment, fragments: NodeRenderFragment seq) = render ==> html.renderFragment("NavMenuContent", fragment { yield! fragments })
    /// Gets or sets the content of the navigation menu.
    [<CustomOperation("NavMenuContent")>] member inline _.NavMenuContent ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("NavMenuContent", html.text x)
    /// Gets or sets the content of the navigation menu.
    [<CustomOperation("NavMenuContent")>] member inline _.NavMenuContent ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("NavMenuContent", html.text x)
    /// Gets or sets the content of the navigation menu.
    [<CustomOperation("NavMenuContent")>] member inline _.NavMenuContent ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("NavMenuContent", html.text x)
    /// Gets or sets the content of the body.
    [<CustomOperation("Body")>] member inline _.Body ([<InlineIfLambda>] render: AttrRenderFragment, fragment: NodeRenderFragment) = render ==> html.renderFragment("Body", fragment)
    /// Gets or sets the content of the body.
    [<CustomOperation("Body")>] member inline _.Body ([<InlineIfLambda>] render: AttrRenderFragment, fragments: NodeRenderFragment seq) = render ==> html.renderFragment("Body", fragment { yield! fragments })
    /// Gets or sets the content of the body.
    [<CustomOperation("Body")>] member inline _.Body ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("Body", html.text x)
    /// Gets or sets the content of the body.
    [<CustomOperation("Body")>] member inline _.Body ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("Body", html.text x)
    /// Gets or sets the content of the body.
    [<CustomOperation("Body")>] member inline _.Body ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("Body", html.text x)

type FluentMainBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentComponentBaseBuilder<'FunBlazorGeneric>()
    /// Gets or sets the height of the header (in pixels).
    [<CustomOperation("Height")>] member inline _.Height ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Int32>) = render ==> ("Height" => x)

type FluentMenuButtonBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentComponentBaseBuilder<'FunBlazorGeneric>()
    /// Gets or sets a reference to the button.
    [<CustomOperation("Button")>] member inline _.Button ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.FluentUI.AspNetCore.Components.FluentButton) = render ==> ("Button" => x)
    /// Gets or sets the button appearance.
    [<CustomOperation("ButtonAppearance")>] member inline _.ButtonAppearance ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.FluentUI.AspNetCore.Components.Appearance) = render ==> ("ButtonAppearance" => x)
    /// Gets or sets a reference to the menu.
    [<CustomOperation("Menu")>] member inline _.Menu ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.FluentUI.AspNetCore.Components.FluentMenu) = render ==> ("Menu" => x)
    /// Gets or sets the texts shown on th button.
    [<CustomOperation("Text")>] member inline _.Text ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Text" => x)
    /// Gets or sets the Icon displayed at the start of button content.
    [<CustomOperation("IconStart")>] member inline _.IconStart ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.FluentUI.AspNetCore.Components.Icon) = render ==> ("IconStart" => x)
    /// Gets or sets the button style.
    [<CustomOperation("ButtonStyle")>] member inline _.ButtonStyle ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("ButtonStyle" => x)
    /// Gets or sets the menu style.
    [<CustomOperation("MenuStyle")>] member inline _.MenuStyle ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("MenuStyle" => x)
    /// Gets or sets the items to show in the menu.
    [<CustomOperation("Items")>] member inline _.Items ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.Dictionary<System.String, System.String>) = render ==> ("Items" => x)
    /// The callback to invoke when a menu item is chosen.
    /// Using this event prevents the execution of any OnClick event on an included FluentMenuItem.
    [<CustomOperation("OnMenuChanged")>] member inline _.OnMenuChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.FluentUI.AspNetCore.Components.MenuChangeEventArgs -> unit) = render ==> html.callback("OnMenuChanged", fn)
    /// The callback to invoke when a menu item is chosen.
    /// Using this event prevents the execution of any OnClick event on an included FluentMenuItem.
    [<CustomOperation("OnMenuChanged")>] member inline _.OnMenuChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.FluentUI.AspNetCore.Components.MenuChangeEventArgs -> Task<unit>) = render ==> html.callbackTask("OnMenuChanged", fn)

type FluentMenuBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentComponentBaseBuilder<'FunBlazorGeneric>()
    /// Use IMenuService to create the menu, if this service was injected.
    /// This value must be defined before the component is rendered (you can't change it during the component lifecycle).
    /// Default, true.
    [<CustomOperation("UseMenuService")>] member inline _.UseMenuService ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("UseMenuService" =>>> true)
    /// Use IMenuService to create the menu, if this service was injected.
    /// This value must be defined before the component is rendered (you can't change it during the component lifecycle).
    /// Default, true.
    [<CustomOperation("UseMenuService")>] member inline _.UseMenuService ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("UseMenuService" =>>> x)
    /// Gets or sets the identifier of the source component clickable by the end user.
    [<CustomOperation("Anchor")>] member inline _.Anchor ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Anchor" => x)
    /// Gets or sets the automatic trigger. See 
    /// Possible values are None (default), Left, Middle, Right, Back, Forward
    [<CustomOperation("Trigger")>] member inline _.Trigger ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.FluentUI.AspNetCore.Components.MouseButton) = render ==> ("Trigger" => x)
    /// Gets or sets the Menu status.
    [<CustomOperation("Open")>] member inline _.Open ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Open" =>>> true)
    /// Gets or sets the Menu status.
    [<CustomOperation("Open")>] member inline _.Open ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Open" =>>> x)
    /// Gets or sets the Menu status.
    [<CustomOperation("Open'")>] member inline _.Open' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.Boolean * (System.Boolean -> unit)) = render ==> html.bind("Open", valueFn)
    /// Gets or sets the horizontal menu position.
    [<CustomOperation("HorizontalPosition")>] member inline _.HorizontalPosition ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.FluentUI.AspNetCore.Components.HorizontalPosition) = render ==> ("HorizontalPosition" => x)
    /// Gets or sets a value indicating whether the region overlaps the anchor on the horizontal axis.
    /// Default is false which places the region adjacent to the anchor element.
    [<CustomOperation("HorizontalInset")>] member inline _.HorizontalInset ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("HorizontalInset" =>>> true)
    /// Gets or sets a value indicating whether the region overlaps the anchor on the horizontal axis.
    /// Default is false which places the region adjacent to the anchor element.
    [<CustomOperation("HorizontalInset")>] member inline _.HorizontalInset ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("HorizontalInset" =>>> x)
    /// Gets or sets the vertical menu position.
    [<CustomOperation("VerticalPosition")>] member inline _.VerticalPosition ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.FluentUI.AspNetCore.Components.VerticalPosition) = render ==> ("VerticalPosition" => x)
    /// Gets or sets a value indicating whether the region overlaps the anchor on the vertical axis.
    [<CustomOperation("VerticalInset")>] member inline _.VerticalInset ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("VerticalInset" =>>> true)
    /// Gets or sets a value indicating whether the region overlaps the anchor on the vertical axis.
    [<CustomOperation("VerticalInset")>] member inline _.VerticalInset ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("VerticalInset" =>>> x)
    /// Gets or sets the width of this menu.
    [<CustomOperation("Width")>] member inline _.Width ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Width" => x)
    /// Raised when the Open property changed.
    [<CustomOperation("OpenChanged")>] member inline _.OpenChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Boolean -> unit) = render ==> html.callback("OpenChanged", fn)
    /// Raised when the Open property changed.
    [<CustomOperation("OpenChanged")>] member inline _.OpenChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Boolean -> Task<unit>) = render ==> html.callbackTask("OpenChanged", fn)
    /// Draw the menu below the component clicked (true) or
    /// using the mouse coordinates (false).
    [<CustomOperation("Anchored")>] member inline _.Anchored ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Anchored" =>>> true)
    /// Draw the menu below the component clicked (true) or
    /// using the mouse coordinates (false).
    [<CustomOperation("Anchored")>] member inline _.Anchored ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Anchored" =>>> x)
    /// Gets or sets how short the space allocated to the default position has to be before the tallest area is selected for layout.
    [<CustomOperation("VerticalThreshold")>] member inline _.VerticalThreshold ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("VerticalThreshold" => x)
    /// Gets or sets how narrow the space allocated to the default position has to be before the widest area is selected for layout.
    [<CustomOperation("HorizontalThreshold")>] member inline _.HorizontalThreshold ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("HorizontalThreshold" => x)
    /// Gets or sets the Horizontal viewport lock.
    [<CustomOperation("HorizontalViewportLock")>] member inline _.HorizontalViewportLock ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("HorizontalViewportLock" =>>> true)
    /// Gets or sets the Horizontal viewport lock.
    [<CustomOperation("HorizontalViewportLock")>] member inline _.HorizontalViewportLock ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("HorizontalViewportLock" =>>> x)
    /// Gets or sets the horizontal scaling mode.
    [<CustomOperation("HorizontalScaling")>] member inline _.HorizontalScaling ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<Microsoft.FluentUI.AspNetCore.Components.AxisScalingMode>) = render ==> ("HorizontalScaling" => x)

type FluentMenuItemBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentComponentBaseBuilder<'FunBlazorGeneric>()
    /// Gets or sets the menu item label.
    [<CustomOperation("Label")>] member inline _.Label ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Label" => x)
    /// Gets or sets a value indicating whether the element is disabled.
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Disabled" =>>> true)
    /// Gets or sets a value indicating whether the element is disabled.
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Disabled" =>>> x)
    /// Gets or sets the expanded state of the element.
    [<CustomOperation("Expanded")>] member inline _.Expanded ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Expanded" =>>> true)
    /// Gets or sets the expanded state of the element.
    [<CustomOperation("Expanded")>] member inline _.Expanded ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Expanded" =>>> x)
    /// Gets or sets the role of the element.
    [<CustomOperation("Role")>] member inline _.Role ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<Microsoft.FluentUI.AspNetCore.Components.MenuItemRole>) = render ==> ("Role" => x)
    /// Gets or sets a value indicating whether the element is checked.
    [<CustomOperation("Checked")>] member inline _.Checked ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Checked" =>>> true)
    /// Gets or sets a value indicating whether the element is checked.
    [<CustomOperation("Checked")>] member inline _.Checked ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Checked" =>>> x)
    /// Gets or sets a value indicates whether the FluentMenu should remain open after an action.
    [<CustomOperation("KeepOpen")>] member inline _.KeepOpen ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("KeepOpen" =>>> true)
    /// Gets or sets a value indicates whether the FluentMenu should remain open after an action.
    [<CustomOperation("KeepOpen")>] member inline _.KeepOpen ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("KeepOpen" =>>> x)
    /// Gets or sets the list of sub-menu items.
    [<CustomOperation("MenuItems")>] member inline _.MenuItems ([<InlineIfLambda>] render: AttrRenderFragment, fragment: NodeRenderFragment) = render ==> html.renderFragment("MenuItems", fragment)
    /// Gets or sets the list of sub-menu items.
    [<CustomOperation("MenuItems")>] member inline _.MenuItems ([<InlineIfLambda>] render: AttrRenderFragment, fragments: NodeRenderFragment seq) = render ==> html.renderFragment("MenuItems", fragment { yield! fragments })
    /// Gets or sets the list of sub-menu items.
    [<CustomOperation("MenuItems")>] member inline _.MenuItems ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("MenuItems", html.text x)
    /// Gets or sets the list of sub-menu items.
    [<CustomOperation("MenuItems")>] member inline _.MenuItems ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("MenuItems", html.text x)
    /// Gets or sets the list of sub-menu items.
    [<CustomOperation("MenuItems")>] member inline _.MenuItems ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("MenuItems", html.text x)
    /// Event raised when the user click on this item.
    [<CustomOperation("OnClick")>] member inline _.OnClick ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.AspNetCore.Components.Web.MouseEventArgs -> unit) = render ==> html.callback("OnClick", fn)
    /// Event raised when the user click on this item.
    [<CustomOperation("OnClick")>] member inline _.OnClick ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.AspNetCore.Components.Web.MouseEventArgs -> Task<unit>) = render ==> html.callbackTask("OnClick", fn)

type FluentMenuProviderBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentComponentBaseBuilder<'FunBlazorGeneric>()


type FluentMessageBarBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentComponentBaseBuilder<'FunBlazorGeneric>()
    /// Gets or sets the type of message bar. 
    /// Default is MessageType.MessageBar. See MessageType for more details.
    [<CustomOperation("Type")>] member inline _.Type ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.FluentUI.AspNetCore.Components.MessageType) = render ==> ("Type" => x)
    /// Gets or sets the actual message instance shown in the message bar.
    [<CustomOperation("Content")>] member inline _.Content ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.FluentUI.AspNetCore.Components.Message) = render ==> ("Content" => x)
    /// Gets or sets the intent of the message bar. 
    /// Default is MessageIntent.Info. See MessageIntent for more details.
    [<CustomOperation("Intent")>] member inline _.Intent ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<Microsoft.FluentUI.AspNetCore.Components.MessageIntent>) = render ==> ("Intent" => x)
    /// Gets or sets the icon to show in the message bar based on the intent of the message. See Icon for more details.
    [<CustomOperation("Icon")>] member inline _.Icon ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.FluentUI.AspNetCore.Components.Icon) = render ==> ("Icon" => x)
    /// Gets or sets the visibility of the message bar. 
    /// Default is true.
    [<CustomOperation("Visible")>] member inline _.Visible ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Visible" =>>> true)
    /// Gets or sets the visibility of the message bar. 
    /// Default is true.
    [<CustomOperation("Visible")>] member inline _.Visible ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Visible" =>>> x)
    /// Gets or sets the title. 
    /// Most important info to be shown in the message bar.
    [<CustomOperation("Title")>] member inline _.Title ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Title" => x)
    /// Gets or sets the time on which the message was created. 
    /// Default is DateTime.Now. 
    /// Only used when MessageType is Notification.
    [<CustomOperation("Timestamp")>] member inline _.Timestamp ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.DateTime>) = render ==> ("Timestamp" => x)
    /// Gets or sets the color of the icon. 
    /// Only applied when intent is MessageBarIntent.Custom.
    /// Default is Color.Accent.
    [<CustomOperation("IconColor")>] member inline _.IconColor ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<Microsoft.FluentUI.AspNetCore.Components.Color>) = render ==> ("IconColor" => x)
    /// Gets or sets the ability to dismiss the notification.
    /// Default is true.
    [<CustomOperation("AllowDismiss")>] member inline _.AllowDismiss ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("AllowDismiss" =>>> true)
    /// Gets or sets the ability to dismiss the notification.
    /// Default is true.
    [<CustomOperation("AllowDismiss")>] member inline _.AllowDismiss ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("AllowDismiss" =>>> x)
    /// Gets or sets the fade in animation for the MessageBar.
    /// Default is true.
    [<CustomOperation("FadeIn")>] member inline _.FadeIn ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("FadeIn" =>>> true)
    /// Gets or sets the fade in animation for the MessageBar.
    /// Default is true.
    [<CustomOperation("FadeIn")>] member inline _.FadeIn ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("FadeIn" =>>> x)

type FluentMessageBarProviderBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentComponentBaseBuilder<'FunBlazorGeneric>()
    /// Display only messages for this section.
    [<CustomOperation("Section")>] member inline _.Section ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Section" => x)
    /// Displays messages as a single line (with the message only)
    /// or as a card (with the detailed message).
    [<CustomOperation("Type")>] member inline _.Type ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.FluentUI.AspNetCore.Components.MessageType) = render ==> ("Type" => x)
    /// Maximum number of messages displayed. Rest is stored in memory to be displayed when an shown message is closed.
    /// Default value is 5
    /// Set a value equal to or less than zero, to display all messages for this Section (or all categories if not set).
    [<CustomOperation("MaxMessageCount")>] member inline _.MaxMessageCount ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Int32>) = render ==> ("MaxMessageCount" => x)
    /// Display the newest messages on top (true) or on bottom (false).
    [<CustomOperation("NewestOnTop")>] member inline _.NewestOnTop ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("NewestOnTop" =>>> true)
    /// Display the newest messages on top (true) or on bottom (false).
    [<CustomOperation("NewestOnTop")>] member inline _.NewestOnTop ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("NewestOnTop" =>>> x)
    /// Clear all (shown and stored) messages when the user navigates to a new page.
    [<CustomOperation("ClearAfterNavigation")>] member inline _.ClearAfterNavigation ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("ClearAfterNavigation" =>>> true)
    /// Clear all (shown and stored) messages when the user navigates to a new page.
    [<CustomOperation("ClearAfterNavigation")>] member inline _.ClearAfterNavigation ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("ClearAfterNavigation" =>>> x)

type FluentNavMenuTreeBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentComponentBaseBuilder<'FunBlazorGeneric>()
    /// Gets or sets the content to be rendered for the expander icon when the menu is collapsible. 
    /// The default icon will be used if this is not specified.
    [<CustomOperation("ExpanderContent")>] member inline _.ExpanderContent ([<InlineIfLambda>] render: AttrRenderFragment, fragment: NodeRenderFragment) = render ==> html.renderFragment("ExpanderContent", fragment)
    /// Gets or sets the content to be rendered for the expander icon when the menu is collapsible. 
    /// The default icon will be used if this is not specified.
    [<CustomOperation("ExpanderContent")>] member inline _.ExpanderContent ([<InlineIfLambda>] render: AttrRenderFragment, fragments: NodeRenderFragment seq) = render ==> html.renderFragment("ExpanderContent", fragment { yield! fragments })
    /// Gets or sets the content to be rendered for the expander icon when the menu is collapsible. 
    /// The default icon will be used if this is not specified.
    [<CustomOperation("ExpanderContent")>] member inline _.ExpanderContent ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("ExpanderContent", html.text x)
    /// Gets or sets the content to be rendered for the expander icon when the menu is collapsible. 
    /// The default icon will be used if this is not specified.
    [<CustomOperation("ExpanderContent")>] member inline _.ExpanderContent ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("ExpanderContent", html.text x)
    /// Gets or sets the content to be rendered for the expander icon when the menu is collapsible. 
    /// The default icon will be used if this is not specified.
    [<CustomOperation("ExpanderContent")>] member inline _.ExpanderContent ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("ExpanderContent", html.text x)
    /// Gets or sets the title of the navigation menu.
    /// Default to "Navigation menu".
    [<CustomOperation("Title")>] member inline _.Title ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Title" => x)
    /// Gets or sets the width of the menu (in pixels).
    [<CustomOperation("Width")>] member inline _.Width ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Int32>) = render ==> ("Width" => x)
    /// Gets or sets whether or not the menu can be collapsed.
    [<CustomOperation("Collapsible")>] member inline _.Collapsible ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Collapsible" =>>> true)
    /// Gets or sets whether or not the menu can be collapsed.
    [<CustomOperation("Collapsible")>] member inline _.Collapsible ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Collapsible" =>>> x)
    /// Returns true if the implementing component
    /// is expanded, and false if collapsed.
    [<CustomOperation("Expanded")>] member inline _.Expanded ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Expanded" =>>> true)
    /// Returns true if the implementing component
    /// is expanded, and false if collapsed.
    [<CustomOperation("Expanded")>] member inline _.Expanded ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Expanded" =>>> x)
    /// Returns true if the implementing component
    /// is expanded, and false if collapsed.
    [<CustomOperation("Expanded'")>] member inline _.Expanded' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.Boolean * (System.Boolean -> unit)) = render ==> html.bind("Expanded", valueFn)
    /// Event callback for when the Expanded property changes.
    [<CustomOperation("ExpandedChanged")>] member inline _.ExpandedChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Boolean -> unit) = render ==> html.callback("ExpandedChanged", fn)
    /// Event callback for when the Expanded property changes.
    [<CustomOperation("ExpandedChanged")>] member inline _.ExpandedChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Boolean -> Task<unit>) = render ==> html.callbackTask("ExpandedChanged", fn)
    /// Called when the user attempts to execute the default action of a menu item.
    [<CustomOperation("OnAction")>] member inline _.OnAction ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.FluentUI.AspNetCore.Components.NavMenuActionArgs -> unit) = render ==> html.callback("OnAction", fn)
    /// Called when the user attempts to execute the default action of a menu item.
    [<CustomOperation("OnAction")>] member inline _.OnAction ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.FluentUI.AspNetCore.Components.NavMenuActionArgs -> Task<unit>) = render ==> html.callbackTask("OnAction", fn)
    /// If set to true then the tree will expand when it is created.
    [<CustomOperation("InitiallyExpanded")>] member inline _.InitiallyExpanded ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("InitiallyExpanded" =>>> true)
    /// If set to true then the tree will expand when it is created.
    [<CustomOperation("InitiallyExpanded")>] member inline _.InitiallyExpanded ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("InitiallyExpanded" =>>> x)
    /// If true, the menu will re-navigate to the current page when the user clicks on the currently selected menu item.
    [<CustomOperation("ReNavigate")>] member inline _.ReNavigate ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("ReNavigate" =>>> true)
    /// If true, the menu will re-navigate to the current page when the user clicks on the currently selected menu item.
    [<CustomOperation("ReNavigate")>] member inline _.ReNavigate ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("ReNavigate" =>>> x)

type FluentNavMenuBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentComponentBaseBuilder<'FunBlazorGeneric>()
    /// Gets or sets the content to be rendered for the collapse icon when the menu is collapsible.
    /// The default icon will be used if this is not specified.
    [<CustomOperation("ExpanderContent")>] member inline _.ExpanderContent ([<InlineIfLambda>] render: AttrRenderFragment, fragment: NodeRenderFragment) = render ==> html.renderFragment("ExpanderContent", fragment)
    /// Gets or sets the content to be rendered for the collapse icon when the menu is collapsible.
    /// The default icon will be used if this is not specified.
    [<CustomOperation("ExpanderContent")>] member inline _.ExpanderContent ([<InlineIfLambda>] render: AttrRenderFragment, fragments: NodeRenderFragment seq) = render ==> html.renderFragment("ExpanderContent", fragment { yield! fragments })
    /// Gets or sets the content to be rendered for the collapse icon when the menu is collapsible.
    /// The default icon will be used if this is not specified.
    [<CustomOperation("ExpanderContent")>] member inline _.ExpanderContent ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("ExpanderContent", html.text x)
    /// Gets or sets the content to be rendered for the collapse icon when the menu is collapsible.
    /// The default icon will be used if this is not specified.
    [<CustomOperation("ExpanderContent")>] member inline _.ExpanderContent ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("ExpanderContent", html.text x)
    /// Gets or sets the content to be rendered for the collapse icon when the menu is collapsible.
    /// The default icon will be used if this is not specified.
    [<CustomOperation("ExpanderContent")>] member inline _.ExpanderContent ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("ExpanderContent", html.text x)
    /// Gets or sets the title of the navigation menu using the aria-label attribute.
    /// Defaults to "Navigation menu".
    [<CustomOperation("Title")>] member inline _.Title ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Title" => x)
    /// Gets or sets the width of the menu (in pixels).
    [<CustomOperation("Width")>] member inline _.Width ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Int32>) = render ==> ("Width" => x)
    /// Gets or sets whether or not the menu can be collapsed.
    [<CustomOperation("Collapsible")>] member inline _.Collapsible ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Collapsible" =>>> true)
    /// Gets or sets whether or not the menu can be collapsed.
    [<CustomOperation("Collapsible")>] member inline _.Collapsible ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Collapsible" =>>> x)
    /// Gets or sets whether a menu with all child links is shown for FluentNavGroups when the navigation menu is collapsed.
    [<CustomOperation("CollapsedChildNavigation")>] member inline _.CollapsedChildNavigation ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("CollapsedChildNavigation" =>>> true)
    /// Gets or sets whether a menu with all child links is shown for FluentNavGroups when the navigation menu is collapsed.
    [<CustomOperation("CollapsedChildNavigation")>] member inline _.CollapsedChildNavigation ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("CollapsedChildNavigation" =>>> x)
    [<CustomOperation("Expanded")>] member inline _.Expanded ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Expanded" =>>> true)
    [<CustomOperation("Expanded")>] member inline _.Expanded ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Expanded" =>>> x)
    [<CustomOperation("Expanded'")>] member inline _.Expanded' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.Boolean * (System.Boolean -> unit)) = render ==> html.bind("Expanded", valueFn)
    /// Event callback for when the Expanded property changes.
    [<CustomOperation("ExpandedChanged")>] member inline _.ExpandedChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Boolean -> unit) = render ==> html.callback("ExpandedChanged", fn)
    /// Event callback for when the Expanded property changes.
    [<CustomOperation("ExpandedChanged")>] member inline _.ExpandedChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Boolean -> Task<unit>) = render ==> html.callbackTask("ExpandedChanged", fn)
    /// Adjust the vertical spacing between navlinks.
    [<CustomOperation("Margin")>] member inline _.Margin ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Margin" => x)
    /// Gets or sets if a custom toggle for showing/hiding the menu is used.
    /// This is primarily intended to be used in a mobile view
    [<CustomOperation("CustomToggle")>] member inline _.CustomToggle ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("CustomToggle" =>>> true)
    /// Gets or sets if a custom toggle for showing/hiding the menu is used.
    /// This is primarily intended to be used in a mobile view
    [<CustomOperation("CustomToggle")>] member inline _.CustomToggle ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("CustomToggle" =>>> x)

type FluentOverflowBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentComponentBaseBuilder<'FunBlazorGeneric>()
    /// Gets or sets the template to display ItemsOverflow elements.
    [<CustomOperation("OverflowTemplate")>] member inline _.OverflowTemplate ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.FluentUI.AspNetCore.Components.FluentOverflow -> NodeRenderFragment) = render ==> html.renderFragment("OverflowTemplate", fn)
    /// To prevent a flickering effect, set this property to False to hide the overflow items until the component is fully loaded.
    [<CustomOperation("VisibleOnLoad")>] member inline _.VisibleOnLoad ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("VisibleOnLoad" =>>> true)
    /// To prevent a flickering effect, set this property to False to hide the overflow items until the component is fully loaded.
    [<CustomOperation("VisibleOnLoad")>] member inline _.VisibleOnLoad ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("VisibleOnLoad" =>>> x)
    /// Gets or sets the template to display the More button.
    [<CustomOperation("MoreButtonTemplate")>] member inline _.MoreButtonTemplate ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.FluentUI.AspNetCore.Components.FluentOverflow -> NodeRenderFragment) = render ==> html.renderFragment("MoreButtonTemplate", fn)
    /// Gets or sets the orientation of the items flow.
    [<CustomOperation("Orientation")>] member inline _.Orientation ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.FluentUI.AspNetCore.Components.Orientation) = render ==> ("Orientation" => x)
    /// Gets or sets the CSS selectors of the items to include in the overflow.
    [<CustomOperation("Selectors")>] member inline _.Selectors ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Selectors" => x)
    /// Event raised when a FluentOverflowItem enter or leave the current panel.
    [<CustomOperation("OnOverflowRaised")>] member inline _.OnOverflowRaised ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Collections.Generic.IEnumerable<Microsoft.FluentUI.AspNetCore.Components.FluentOverflowItem> -> unit) = render ==> html.callback("OnOverflowRaised", fn)
    /// Event raised when a FluentOverflowItem enter or leave the current panel.
    [<CustomOperation("OnOverflowRaised")>] member inline _.OnOverflowRaised ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Collections.Generic.IEnumerable<Microsoft.FluentUI.AspNetCore.Components.FluentOverflowItem> -> Task<unit>) = render ==> html.callbackTask("OnOverflowRaised", fn)

type FluentOverflowItemBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentComponentBaseBuilder<'FunBlazorGeneric>()
    /// Gets or sets whether this element does not participate in overflow logic, and will always be visible.
    /// Defaults to false
    [<CustomOperation("Fixed")>] member inline _.Fixed ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.FluentUI.AspNetCore.Components.OverflowItemFixed) = render ==> ("Fixed" => x)

/// A component that provides a user interface for PaginationState.
type FluentPaginatorBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("CurrentPageIndexChanged")>] member inline _.CurrentPageIndexChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Int32 -> unit) = render ==> html.callback("CurrentPageIndexChanged", fn)
    [<CustomOperation("CurrentPageIndexChanged")>] member inline _.CurrentPageIndexChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Int32 -> Task<unit>) = render ==> html.callbackTask("CurrentPageIndexChanged", fn)
    /// Disables the pagination buttons
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Disabled" =>>> true)
    /// Disables the pagination buttons
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Disabled" =>>> x)
    /// Gets or sets the associated PaginationState. This parameter is required.
    [<CustomOperation("State")>] member inline _.State ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.FluentUI.AspNetCore.Components.PaginationState) = render ==> ("State" => x)
    /// Optionally supplies a template for rendering the page count summary.
    /// The following values can be included:
    /// {your State parameter name}.TotalItemCount (for the total number of items)
    [<CustomOperation("SummaryTemplate")>] member inline _.SummaryTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragment: NodeRenderFragment) = render ==> html.renderFragment("SummaryTemplate", fragment)
    /// Optionally supplies a template for rendering the page count summary.
    /// The following values can be included:
    /// {your State parameter name}.TotalItemCount (for the total number of items)
    [<CustomOperation("SummaryTemplate")>] member inline _.SummaryTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragments: NodeRenderFragment seq) = render ==> html.renderFragment("SummaryTemplate", fragment { yield! fragments })
    /// Optionally supplies a template for rendering the page count summary.
    /// The following values can be included:
    /// {your State parameter name}.TotalItemCount (for the total number of items)
    [<CustomOperation("SummaryTemplate")>] member inline _.SummaryTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("SummaryTemplate", html.text x)
    /// Optionally supplies a template for rendering the page count summary.
    /// The following values can be included:
    /// {your State parameter name}.TotalItemCount (for the total number of items)
    [<CustomOperation("SummaryTemplate")>] member inline _.SummaryTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("SummaryTemplate", html.text x)
    /// Optionally supplies a template for rendering the page count summary.
    /// The following values can be included:
    /// {your State parameter name}.TotalItemCount (for the total number of items)
    [<CustomOperation("SummaryTemplate")>] member inline _.SummaryTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("SummaryTemplate", html.text x)
    /// Optionally supplies a template for rendering the pagination summary.
    /// The following values can be included:
    /// {your State parameter name}.CurrentPageIndex (zero-based, so +1 for the current page number)
    /// {your State parameter name}.LastPageIndex (zero-based, so +1 for the total number of pages)
    [<CustomOperation("PaginationTextTemplate")>] member inline _.PaginationTextTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragment: NodeRenderFragment) = render ==> html.renderFragment("PaginationTextTemplate", fragment)
    /// Optionally supplies a template for rendering the pagination summary.
    /// The following values can be included:
    /// {your State parameter name}.CurrentPageIndex (zero-based, so +1 for the current page number)
    /// {your State parameter name}.LastPageIndex (zero-based, so +1 for the total number of pages)
    [<CustomOperation("PaginationTextTemplate")>] member inline _.PaginationTextTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragments: NodeRenderFragment seq) = render ==> html.renderFragment("PaginationTextTemplate", fragment { yield! fragments })
    /// Optionally supplies a template for rendering the pagination summary.
    /// The following values can be included:
    /// {your State parameter name}.CurrentPageIndex (zero-based, so +1 for the current page number)
    /// {your State parameter name}.LastPageIndex (zero-based, so +1 for the total number of pages)
    [<CustomOperation("PaginationTextTemplate")>] member inline _.PaginationTextTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("PaginationTextTemplate", html.text x)
    /// Optionally supplies a template for rendering the pagination summary.
    /// The following values can be included:
    /// {your State parameter name}.CurrentPageIndex (zero-based, so +1 for the current page number)
    /// {your State parameter name}.LastPageIndex (zero-based, so +1 for the total number of pages)
    [<CustomOperation("PaginationTextTemplate")>] member inline _.PaginationTextTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("PaginationTextTemplate", html.text x)
    /// Optionally supplies a template for rendering the pagination summary.
    /// The following values can be included:
    /// {your State parameter name}.CurrentPageIndex (zero-based, so +1 for the current page number)
    /// {your State parameter name}.LastPageIndex (zero-based, so +1 for the total number of pages)
    [<CustomOperation("PaginationTextTemplate")>] member inline _.PaginationTextTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("PaginationTextTemplate", html.text x)

type FluentPopoverBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentComponentBaseBuilder<'FunBlazorGeneric>()
    /// Gets or sets the id of the component the popover is positioned relative to.
    [<CustomOperation("AnchorId")>] member inline _.AnchorId ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("AnchorId" => x)
    /// Gets or sets the default horizontal position of the region relative to the anchor element.
    /// Default is unset. See 
    [<CustomOperation("HorizontalPosition")>] member inline _.HorizontalPosition ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<Microsoft.FluentUI.AspNetCore.Components.HorizontalPosition>) = render ==> ("HorizontalPosition" => x)
    /// Gets or sets a value indicating whether the region overlaps the anchor on the horizontal axis.
    /// Default is true which places the region aligned with the anchor element.
    [<CustomOperation("HorizontalInset")>] member inline _.HorizontalInset ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("HorizontalInset" =>>> true)
    /// Gets or sets a value indicating whether the region overlaps the anchor on the horizontal axis.
    /// Default is true which places the region aligned with the anchor element.
    [<CustomOperation("HorizontalInset")>] member inline _.HorizontalInset ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("HorizontalInset" =>>> x)
    /// Gets or sets the default vertical position of the region relative to the anchor element.
    /// Default is unset. See 
    [<CustomOperation("VerticalPosition")>] member inline _.VerticalPosition ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<Microsoft.FluentUI.AspNetCore.Components.VerticalPosition>) = render ==> ("VerticalPosition" => x)
    /// How short the space allocated to the default position has to be before the tallest area is selected for layout.
    [<CustomOperation("VerticalThreshold")>] member inline _.VerticalThreshold ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("VerticalThreshold" => x)
    /// How narrow the space allocated to the default position has to be before the widest area is selected for layout.
    [<CustomOperation("HorizontalThreshold")>] member inline _.HorizontalThreshold ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("HorizontalThreshold" => x)
    /// Gets or sets a value indicating whether the region is positioned using css "position: fixed".
    /// Otherwise the region uses "position: absolute".
    /// Fixed placement allows the region to break out of parent containers.
    [<CustomOperation("FixedPlacement")>] member inline _.FixedPlacement ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Boolean>) = render ==> ("FixedPlacement" => x)
    /// Gets or sets popover opened state.
    [<CustomOperation("Open")>] member inline _.Open ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Open" =>>> true)
    /// Gets or sets popover opened state.
    [<CustomOperation("Open")>] member inline _.Open ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Open" =>>> x)
    /// Gets or sets popover opened state.
    [<CustomOperation("Open'")>] member inline _.Open' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.Boolean * (System.Boolean -> unit)) = render ==> html.bind("Open", valueFn)
    /// Callback for when open state changes.
    [<CustomOperation("OpenChanged")>] member inline _.OpenChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Boolean -> unit) = render ==> html.callback("OpenChanged", fn)
    /// Callback for when open state changes.
    [<CustomOperation("OpenChanged")>] member inline _.OpenChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Boolean -> Task<unit>) = render ==> html.callbackTask("OpenChanged", fn)
    /// Gets or sets the content of the header part of the popover.
    [<CustomOperation("Header")>] member inline _.Header ([<InlineIfLambda>] render: AttrRenderFragment, fragment: NodeRenderFragment) = render ==> html.renderFragment("Header", fragment)
    /// Gets or sets the content of the header part of the popover.
    [<CustomOperation("Header")>] member inline _.Header ([<InlineIfLambda>] render: AttrRenderFragment, fragments: NodeRenderFragment seq) = render ==> html.renderFragment("Header", fragment { yield! fragments })
    /// Gets or sets the content of the header part of the popover.
    [<CustomOperation("Header")>] member inline _.Header ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("Header", html.text x)
    /// Gets or sets the content of the header part of the popover.
    [<CustomOperation("Header")>] member inline _.Header ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("Header", html.text x)
    /// Gets or sets the content of the header part of the popover.
    [<CustomOperation("Header")>] member inline _.Header ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("Header", html.text x)
    /// Gets or sets the content of the body part of the popover.
    [<CustomOperation("Body")>] member inline _.Body ([<InlineIfLambda>] render: AttrRenderFragment, fragment: NodeRenderFragment) = render ==> html.renderFragment("Body", fragment)
    /// Gets or sets the content of the body part of the popover.
    [<CustomOperation("Body")>] member inline _.Body ([<InlineIfLambda>] render: AttrRenderFragment, fragments: NodeRenderFragment seq) = render ==> html.renderFragment("Body", fragment { yield! fragments })
    /// Gets or sets the content of the body part of the popover.
    [<CustomOperation("Body")>] member inline _.Body ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("Body", html.text x)
    /// Gets or sets the content of the body part of the popover.
    [<CustomOperation("Body")>] member inline _.Body ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("Body", html.text x)
    /// Gets or sets the content of the body part of the popover.
    [<CustomOperation("Body")>] member inline _.Body ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("Body", html.text x)
    /// Gets or sets the content of the footer part of the popover.
    [<CustomOperation("Footer")>] member inline _.Footer ([<InlineIfLambda>] render: AttrRenderFragment, fragment: NodeRenderFragment) = render ==> html.renderFragment("Footer", fragment)
    /// Gets or sets the content of the footer part of the popover.
    [<CustomOperation("Footer")>] member inline _.Footer ([<InlineIfLambda>] render: AttrRenderFragment, fragments: NodeRenderFragment seq) = render ==> html.renderFragment("Footer", fragment { yield! fragments })
    /// Gets or sets the content of the footer part of the popover.
    [<CustomOperation("Footer")>] member inline _.Footer ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("Footer", html.text x)
    /// Gets or sets the content of the footer part of the popover.
    [<CustomOperation("Footer")>] member inline _.Footer ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("Footer", html.text x)
    /// Gets or sets the content of the footer part of the popover.
    [<CustomOperation("Footer")>] member inline _.Footer ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("Footer", html.text x)
    /// Gets or sets whether the element should receive the focus when the component is loaded.
    /// If this is the case, the user cannot navigate to other elements of the page while the Popup is open.
    /// Default is true.
    [<CustomOperation("AutoFocus")>] member inline _.AutoFocus ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("AutoFocus" =>>> true)
    /// Gets or sets whether the element should receive the focus when the component is loaded.
    /// If this is the case, the user cannot navigate to other elements of the page while the Popup is open.
    /// Default is true.
    [<CustomOperation("AutoFocus")>] member inline _.AutoFocus ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("AutoFocus" =>>> x)
    /// Gets or sets the keys that can be used to close the popover.
    /// By default, Escape
    [<CustomOperation("CloseKeys")>] member inline _.CloseKeys ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.FluentUI.AspNetCore.Components.KeyCode[]) = render ==> ("CloseKeys" => x)

/// A presence badge is a badge that displays a status indicator such as available, away, or busy.
type FluentPresenceBadgeBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentComponentBaseBuilder<'FunBlazorGeneric>()
    /// Gets or sets the title to show on hover the component.
    /// If not provided, the StatusTitle will be used.
    [<CustomOperation("Title")>] member inline _.Title ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Title" => x)
    /// Gets or sets the status to show. See PresenceStatus for options.
    [<CustomOperation("Status")>] member inline _.Status ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<Microsoft.FluentUI.AspNetCore.Components.PresenceStatus>) = render ==> ("Status" => x)
    /// Gets or sets the title to show on hover the status. If not provided, the status will be used.
    [<CustomOperation("StatusTitle")>] member inline _.StatusTitle ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("StatusTitle" => x)
    /// Modifies the display to indicate that the user is out of office. 
    /// This can be combined with any status to display an out-of-office version of that status.
    [<CustomOperation("OutOfOffice")>] member inline _.OutOfOffice ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("OutOfOffice" =>>> true)
    /// Modifies the display to indicate that the user is out of office. 
    /// This can be combined with any status to display an out-of-office version of that status.
    [<CustomOperation("OutOfOffice")>] member inline _.OutOfOffice ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("OutOfOffice" =>>> x)
    /// Gets or sets the Status size to use.
    /// Default is Small.
    [<CustomOperation("Size")>] member inline _.Size ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.FluentUI.AspNetCore.Components.PresenceBadgeSize) = render ==> ("Size" => x)

type FluentProfileMenuBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentComponentBaseBuilder<'FunBlazorGeneric>()
    /// Gets or sets the Menu status.
    [<CustomOperation("Open")>] member inline _.Open ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Open" =>>> true)
    /// Gets or sets the Menu status.
    [<CustomOperation("Open")>] member inline _.Open ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Open" =>>> x)
    /// Gets or sets whether popover should be forced to top right or top left (RTL).
    [<CustomOperation("TopCorner")>] member inline _.TopCorner ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("TopCorner" =>>> true)
    /// Gets or sets whether popover should be forced to top right or top left (RTL).
    [<CustomOperation("TopCorner")>] member inline _.TopCorner ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("TopCorner" =>>> x)
    /// Gets or sets the content to be displayed in the header section of the popover.
    /// Using this property will override the HeaderLabel and HeaderButton properties.
    [<CustomOperation("HeaderTemplate")>] member inline _.HeaderTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragment: NodeRenderFragment) = render ==> html.renderFragment("HeaderTemplate", fragment)
    /// Gets or sets the content to be displayed in the header section of the popover.
    /// Using this property will override the HeaderLabel and HeaderButton properties.
    [<CustomOperation("HeaderTemplate")>] member inline _.HeaderTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragments: NodeRenderFragment seq) = render ==> html.renderFragment("HeaderTemplate", fragment { yield! fragments })
    /// Gets or sets the content to be displayed in the header section of the popover.
    /// Using this property will override the HeaderLabel and HeaderButton properties.
    [<CustomOperation("HeaderTemplate")>] member inline _.HeaderTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("HeaderTemplate", html.text x)
    /// Gets or sets the content to be displayed in the header section of the popover.
    /// Using this property will override the HeaderLabel and HeaderButton properties.
    [<CustomOperation("HeaderTemplate")>] member inline _.HeaderTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("HeaderTemplate", html.text x)
    /// Gets or sets the content to be displayed in the header section of the popover.
    /// Using this property will override the HeaderLabel and HeaderButton properties.
    [<CustomOperation("HeaderTemplate")>] member inline _.HeaderTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("HeaderTemplate", html.text x)
    /// Gets or sets the content to be displayed in the footer section of the popover.
    /// Using this property will override the FooterLink property.
    [<CustomOperation("FooterTemplate")>] member inline _.FooterTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragment: NodeRenderFragment) = render ==> html.renderFragment("FooterTemplate", fragment)
    /// Gets or sets the content to be displayed in the footer section of the popover.
    /// Using this property will override the FooterLink property.
    [<CustomOperation("FooterTemplate")>] member inline _.FooterTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragments: NodeRenderFragment seq) = render ==> html.renderFragment("FooterTemplate", fragment { yield! fragments })
    /// Gets or sets the content to be displayed in the footer section of the popover.
    /// Using this property will override the FooterLink property.
    [<CustomOperation("FooterTemplate")>] member inline _.FooterTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("FooterTemplate", html.text x)
    /// Gets or sets the content to be displayed in the footer section of the popover.
    /// Using this property will override the FooterLink property.
    [<CustomOperation("FooterTemplate")>] member inline _.FooterTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("FooterTemplate", html.text x)
    /// Gets or sets the content to be displayed in the footer section of the popover.
    /// Using this property will override the FooterLink property.
    [<CustomOperation("FooterTemplate")>] member inline _.FooterTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("FooterTemplate", html.text x)
    /// Gets or sets the content to be displayed in the start (left) section of the Profile button.
    [<CustomOperation("StartTemplate")>] member inline _.StartTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragment: NodeRenderFragment) = render ==> html.renderFragment("StartTemplate", fragment)
    /// Gets or sets the content to be displayed in the start (left) section of the Profile button.
    [<CustomOperation("StartTemplate")>] member inline _.StartTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragments: NodeRenderFragment seq) = render ==> html.renderFragment("StartTemplate", fragment { yield! fragments })
    /// Gets or sets the content to be displayed in the start (left) section of the Profile button.
    [<CustomOperation("StartTemplate")>] member inline _.StartTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("StartTemplate", html.text x)
    /// Gets or sets the content to be displayed in the start (left) section of the Profile button.
    [<CustomOperation("StartTemplate")>] member inline _.StartTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("StartTemplate", html.text x)
    /// Gets or sets the content to be displayed in the start (left) section of the Profile button.
    [<CustomOperation("StartTemplate")>] member inline _.StartTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("StartTemplate", html.text x)
    /// Gets or sets the content to be displayed in the end (right) section of the Profile button.
    [<CustomOperation("EndTemplate")>] member inline _.EndTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragment: NodeRenderFragment) = render ==> html.renderFragment("EndTemplate", fragment)
    /// Gets or sets the content to be displayed in the end (right) section of the Profile button.
    [<CustomOperation("EndTemplate")>] member inline _.EndTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragments: NodeRenderFragment seq) = render ==> html.renderFragment("EndTemplate", fragment { yield! fragments })
    /// Gets or sets the content to be displayed in the end (right) section of the Profile button.
    [<CustomOperation("EndTemplate")>] member inline _.EndTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("EndTemplate", html.text x)
    /// Gets or sets the content to be displayed in the end (right) section of the Profile button.
    [<CustomOperation("EndTemplate")>] member inline _.EndTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("EndTemplate", html.text x)
    /// Gets or sets the content to be displayed in the end (right) section of the Profile button.
    [<CustomOperation("EndTemplate")>] member inline _.EndTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("EndTemplate", html.text x)
    /// Gets or sets the status to show. See PresenceStatus for options.
    [<CustomOperation("Status")>] member inline _.Status ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<Microsoft.FluentUI.AspNetCore.Components.PresenceStatus>) = render ==> ("Status" => x)
    /// Gets or sets the title to show on hover. If not provided, the status will be used.
    [<CustomOperation("StatusTitle")>] member inline _.StatusTitle ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("StatusTitle" => x)
    /// Gets or sets the Class to apply to the Profile Popup.
    [<CustomOperation("PopoverClass")>] member inline _.PopoverClass ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("PopoverClass" => x)
    /// Gets or sets the Style to apply to the Profile Popup.
    [<CustomOperation("PopoverStyle")>] member inline _.PopoverStyle ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("PopoverStyle" => x)
    /// Gets or sets the initials to display if no image is provided.
    /// By default, the first letters of the FullName is used.
    [<CustomOperation("Initials")>] member inline _.Initials ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Initials" => x)
    /// Gets or sets the name to display.
    [<CustomOperation("FullName")>] member inline _.FullName ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("FullName" => x)
    /// Gets or sets the email to display.
    [<CustomOperation("EMail")>] member inline _.EMail ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("EMail" => x)
    /// Gets or sets the header label (e.g Company Name) to display on the top-left.
    [<CustomOperation("HeaderLabel")>] member inline _.HeaderLabel ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("HeaderLabel" => x)
    /// Gets or sets the image to display, in replacement of the initials.
    [<CustomOperation("Image")>] member inline _.Image ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Image" => x)
    /// Gets or sets the size of the image, in the popover.
    [<CustomOperation("ImageSize")>] member inline _.ImageSize ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("ImageSize" => x)
    /// Gets or sets the size of the main button image (button clickable to display the popover).
    [<CustomOperation("ButtonSize")>] member inline _.ButtonSize ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("ButtonSize" => x)
    /// Gets or sets the Header Button label (e.g. Sign out) on the top-right.
    [<CustomOperation("HeaderButton")>] member inline _.HeaderButton ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("HeaderButton" => x)
    /// Event raised when the user clicks on the Header Button (e.g. Sign out).
    [<CustomOperation("OnHeaderButtonClick")>] member inline _.OnHeaderButtonClick ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: unit -> unit) = render ==> html.callback("OnHeaderButtonClick", fn)
    /// Event raised when the user clicks on the Header Button (e.g. Sign out).
    [<CustomOperation("OnHeaderButtonClick")>] member inline _.OnHeaderButtonClick ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: unit -> Task<unit>) = render ==> html.callbackTask("OnHeaderButtonClick", fn)
    /// Gets or sets the footer label to display on the bottom-left.
    [<CustomOperation("FooterLabel")>] member inline _.FooterLabel ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("FooterLabel" => x)
    /// Gets or sets the Footer hyperlink label (e.g. View account) on the bottom-right.
    [<CustomOperation("FooterLink")>] member inline _.FooterLink ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("FooterLink" => x)
    /// Event raised when the user clicks on the Footer hyperlink (e.g. View account).
    [<CustomOperation("OnFooterLinkClick")>] member inline _.OnFooterLinkClick ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: unit -> unit) = render ==> html.callback("OnFooterLinkClick", fn)
    /// Event raised when the user clicks on the Footer hyperlink (e.g. View account).
    [<CustomOperation("OnFooterLinkClick")>] member inline _.OnFooterLinkClick ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: unit -> Task<unit>) = render ==> html.callbackTask("OnFooterLinkClick", fn)

type FluentProgressBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentComponentBaseBuilder<'FunBlazorGeneric>()
    /// Gets or sets the minimum value.
    [<CustomOperation("Min")>] member inline _.Min ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Int32>) = render ==> ("Min" => x)
    /// Gets or sets the maximum value.
    [<CustomOperation("Max")>] member inline _.Max ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Int32>) = render ==> ("Max" => x)
    /// Gets or sets the current value.
    [<CustomOperation("Value")>] member inline _.Value ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Int32>) = render ==> ("Value" => x)
    /// Gets or sets the visibility of the component
    [<CustomOperation("Visible")>] member inline _.Visible ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Visible" =>>> true)
    /// Gets or sets the visibility of the component
    [<CustomOperation("Visible")>] member inline _.Visible ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Visible" =>>> x)
    /// Gets or sets the component width.
    [<CustomOperation("Width")>] member inline _.Width ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Width" => x)
    /// Gets or sets a value indicating whether the progress element is paused.
    [<CustomOperation("Paused")>] member inline _.Paused ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Boolean>) = render ==> ("Paused" => x)
    /// Gets or sets the stroke width of the progress bar. If not set, the default theme stroke width is used.
    [<CustomOperation("Stroke")>] member inline _.Stroke ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.FluentUI.AspNetCore.Components.ProgressStroke) = render ==> ("Stroke" => x)
    /// Gets or sets the color to be used for the progress bar. If not set, the default theme color is used.
    [<CustomOperation("Color")>] member inline _.Color ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Color" => x)
    /// Gets or sets the color to be used for the background. If not set, the default theme color is used.
    [<CustomOperation("BackgroundColor")>] member inline _.BackgroundColor ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("BackgroundColor" => x)

type FluentProgressRingBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentComponentBaseBuilder<'FunBlazorGeneric>()
    /// Gets or sets the minimum value 
    [<CustomOperation("Min")>] member inline _.Min ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Int32>) = render ==> ("Min" => x)
    /// Gets or sets the maximum value 
    [<CustomOperation("Max")>] member inline _.Max ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Int32>) = render ==> ("Max" => x)
    /// Gets or sets the current value .
    [<CustomOperation("Value")>] member inline _.Value ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Int32>) = render ==> ("Value" => x)
    [<CustomOperation("Visible")>] member inline _.Visible ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Visible" =>>> true)
    [<CustomOperation("Visible")>] member inline _.Visible ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Visible" =>>> x)
    /// Gets or sets a value indicating whether the progress element is paused.
    [<CustomOperation("Paused")>] member inline _.Paused ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Boolean>) = render ==> ("Paused" => x)
    /// Gets or sets the component width and height.
    [<CustomOperation("Width")>] member inline _.Width ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Width" => x)
    /// Gets or sets the stroke width of the progress ring. If not set, the default theme stroke width is used.
    [<CustomOperation("Stroke")>] member inline _.Stroke ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.FluentUI.AspNetCore.Components.ProgressStroke) = render ==> ("Stroke" => x)
    /// Gets or sets the color to be used for the progress ring. If not set, the default theme color is used.
    [<CustomOperation("Color")>] member inline _.Color ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Color" => x)

type FluentPullToRefreshBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentComponentBaseBuilder<'FunBlazorGeneric>()
    /// Gets or sets the direction to pull the ChildContent.
    [<CustomOperation("Direction")>] member inline _.Direction ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.FluentUI.AspNetCore.Components.PullDirection) = render ==> ("Direction" => x)
    /// Gets or sets if the pull action is disabled.
    /// Deaults to false.
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Disabled" =>>> true)
    /// Gets or sets if the pull action is disabled.
    /// Deaults to false.
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Disabled" =>>> x)
    /// Gets or sets if the component should work on non-touch devices (by using an emulation script).
    /// Deaults to true.
    [<CustomOperation("EmulateTouch")>] member inline _.EmulateTouch ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("EmulateTouch" =>>> true)
    /// Gets or sets if the component should work on non-touch devices (by using an emulation script).
    /// Deaults to true.
    [<CustomOperation("EmulateTouch")>] member inline _.EmulateTouch ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("EmulateTouch" =>>> x)
    /// Gets or sets if a tip is shown when ChildContent is not being pulled.
    [<CustomOperation("ShowStaticTip")>] member inline _.ShowStaticTip ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("ShowStaticTip" =>>> true)
    /// Gets or sets if a tip is shown when ChildContent is not being pulled.
    [<CustomOperation("ShowStaticTip")>] member inline _.ShowStaticTip ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("ShowStaticTip" =>>> x)
    /// Returns whether there is more data available.
    [<CustomOperation("OnRefreshAsync")>] member inline _.OnRefreshAsync ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("OnRefreshAsync" => (System.Func<System.Threading.Tasks.Task<System.Boolean>>fn))
    /// Gets or sets the the content to indicate the ChildContent can be refreshed by a pull down/up action.
    [<CustomOperation("PullingTemplate")>] member inline _.PullingTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragment: NodeRenderFragment) = render ==> html.renderFragment("PullingTemplate", fragment)
    /// Gets or sets the the content to indicate the ChildContent can be refreshed by a pull down/up action.
    [<CustomOperation("PullingTemplate")>] member inline _.PullingTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragments: NodeRenderFragment seq) = render ==> html.renderFragment("PullingTemplate", fragment { yield! fragments })
    /// Gets or sets the the content to indicate the ChildContent can be refreshed by a pull down/up action.
    [<CustomOperation("PullingTemplate")>] member inline _.PullingTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("PullingTemplate", html.text x)
    /// Gets or sets the the content to indicate the ChildContent can be refreshed by a pull down/up action.
    [<CustomOperation("PullingTemplate")>] member inline _.PullingTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("PullingTemplate", html.text x)
    /// Gets or sets the the content to indicate the ChildContent can be refreshed by a pull down/up action.
    [<CustomOperation("PullingTemplate")>] member inline _.PullingTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("PullingTemplate", html.text x)
    /// Gets or sets the the content to indicate the pulled ChildContent must be released to start the refresh action.
    [<CustomOperation("ReleaseTemplate")>] member inline _.ReleaseTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragment: NodeRenderFragment) = render ==> html.renderFragment("ReleaseTemplate", fragment)
    /// Gets or sets the the content to indicate the pulled ChildContent must be released to start the refresh action.
    [<CustomOperation("ReleaseTemplate")>] member inline _.ReleaseTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragments: NodeRenderFragment seq) = render ==> html.renderFragment("ReleaseTemplate", fragment { yield! fragments })
    /// Gets or sets the the content to indicate the pulled ChildContent must be released to start the refresh action.
    [<CustomOperation("ReleaseTemplate")>] member inline _.ReleaseTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("ReleaseTemplate", html.text x)
    /// Gets or sets the the content to indicate the pulled ChildContent must be released to start the refresh action.
    [<CustomOperation("ReleaseTemplate")>] member inline _.ReleaseTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("ReleaseTemplate", html.text x)
    /// Gets or sets the the content to indicate the pulled ChildContent must be released to start the refresh action.
    [<CustomOperation("ReleaseTemplate")>] member inline _.ReleaseTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("ReleaseTemplate", html.text x)
    /// Gets or sets the the content to indicate the ChildContent is being refreshed.
    [<CustomOperation("LoadingTemplate")>] member inline _.LoadingTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragment: NodeRenderFragment) = render ==> html.renderFragment("LoadingTemplate", fragment)
    /// Gets or sets the the content to indicate the ChildContent is being refreshed.
    [<CustomOperation("LoadingTemplate")>] member inline _.LoadingTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragments: NodeRenderFragment seq) = render ==> html.renderFragment("LoadingTemplate", fragment { yield! fragments })
    /// Gets or sets the the content to indicate the ChildContent is being refreshed.
    [<CustomOperation("LoadingTemplate")>] member inline _.LoadingTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("LoadingTemplate", html.text x)
    /// Gets or sets the the content to indicate the ChildContent is being refreshed.
    [<CustomOperation("LoadingTemplate")>] member inline _.LoadingTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("LoadingTemplate", html.text x)
    /// Gets or sets the the content to indicate the ChildContent is being refreshed.
    [<CustomOperation("LoadingTemplate")>] member inline _.LoadingTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("LoadingTemplate", html.text x)
    /// Gets or sets the the content to indicate the ChildContent has been refreshed.
    [<CustomOperation("CompletedTemplate")>] member inline _.CompletedTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragment: NodeRenderFragment) = render ==> html.renderFragment("CompletedTemplate", fragment)
    /// Gets or sets the the content to indicate the ChildContent has been refreshed.
    [<CustomOperation("CompletedTemplate")>] member inline _.CompletedTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragments: NodeRenderFragment seq) = render ==> html.renderFragment("CompletedTemplate", fragment { yield! fragments })
    /// Gets or sets the the content to indicate the ChildContent has been refreshed.
    [<CustomOperation("CompletedTemplate")>] member inline _.CompletedTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("CompletedTemplate", html.text x)
    /// Gets or sets the the content to indicate the ChildContent has been refreshed.
    [<CustomOperation("CompletedTemplate")>] member inline _.CompletedTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("CompletedTemplate", html.text x)
    /// Gets or sets the the content to indicate the ChildContent has been refreshed.
    [<CustomOperation("CompletedTemplate")>] member inline _.CompletedTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("CompletedTemplate", html.text x)
    /// Gets or sets the the content to indicate the ChildContent can not be refreshed anymore.
    [<CustomOperation("NoDataTemplate")>] member inline _.NoDataTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragment: NodeRenderFragment) = render ==> html.renderFragment("NoDataTemplate", fragment)
    /// Gets or sets the the content to indicate the ChildContent can not be refreshed anymore.
    [<CustomOperation("NoDataTemplate")>] member inline _.NoDataTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragments: NodeRenderFragment seq) = render ==> html.renderFragment("NoDataTemplate", fragment { yield! fragments })
    /// Gets or sets the the content to indicate the ChildContent can not be refreshed anymore.
    [<CustomOperation("NoDataTemplate")>] member inline _.NoDataTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("NoDataTemplate", html.text x)
    /// Gets or sets the the content to indicate the ChildContent can not be refreshed anymore.
    [<CustomOperation("NoDataTemplate")>] member inline _.NoDataTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("NoDataTemplate", html.text x)
    /// Gets or sets the the content to indicate the ChildContent can not be refreshed anymore.
    [<CustomOperation("NoDataTemplate")>] member inline _.NoDataTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("NoDataTemplate", html.text x)
    /// Gets or sets the distance the ChildContent needs to be pulled (in pixels) to initiate a refresh action.
    [<CustomOperation("DragDistance")>] member inline _.DragDistance ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("DragDistance" => x)
    /// Gets or sets the height (in pixels) of the tip fragment (if shown).
    [<CustomOperation("TipHeight")>] member inline _.TipHeight ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("TipHeight" => x)
    /// Gets or sets the amount of time (in milliseconds) a status update message will be displayed.
    /// Default is 750
    [<CustomOperation("StatusUpdateMessageTimeout")>] member inline _.StatusUpdateMessageTimeout ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("StatusUpdateMessageTimeout" => x)
    /// Gets or sets the threshold distance the ChildContent needs to be pulled (in pixels) to start the tip pull action.
    [<CustomOperation("DragThreshold")>] member inline _.DragThreshold ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("DragThreshold" => x)

type FluentRadioBuilder<'FunBlazorGeneric, 'TValue when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentComponentBaseBuilder<'FunBlazorGeneric>()
    /// Gets or sets a value indicating whether the element is readonly.
    [<CustomOperation("ReadOnly")>] member inline _.ReadOnly ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("ReadOnly" =>>> true)
    /// Gets or sets a value indicating whether the element is readonly.
    [<CustomOperation("ReadOnly")>] member inline _.ReadOnly ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("ReadOnly" =>>> x)
    /// Gets or sets the text displayed just above the component.
    [<CustomOperation("Label")>] member inline _.Label ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Label" => x)
    /// Gets or sets the content displayed just above the component.
    [<CustomOperation("LabelTemplate")>] member inline _.LabelTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragment: NodeRenderFragment) = render ==> html.renderFragment("LabelTemplate", fragment)
    /// Gets or sets the content displayed just above the component.
    [<CustomOperation("LabelTemplate")>] member inline _.LabelTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragments: NodeRenderFragment seq) = render ==> html.renderFragment("LabelTemplate", fragment { yield! fragments })
    /// Gets or sets the content displayed just above the component.
    [<CustomOperation("LabelTemplate")>] member inline _.LabelTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("LabelTemplate", html.text x)
    /// Gets or sets the content displayed just above the component.
    [<CustomOperation("LabelTemplate")>] member inline _.LabelTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("LabelTemplate", html.text x)
    /// Gets or sets the content displayed just above the component.
    [<CustomOperation("LabelTemplate")>] member inline _.LabelTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("LabelTemplate", html.text x)
    /// Gets or sets the text used on aria-label attribute.
    [<CustomOperation("AriaLabel")>] member inline _.AriaLabel ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("AriaLabel" => x)
    /// Gets or sets the value of the element.
    [<CustomOperation("Value")>] member inline _.Value ([<InlineIfLambda>] render: AttrRenderFragment, x: 'TValue) = render ==> ("Value" => x)
    /// Disables the form control, ensuring it doesn't participate in form submission
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Disabled" =>>> true)
    /// Disables the form control, ensuring it doesn't participate in form submission
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Disabled" =>>> x)
    /// Gets or sets the name of the parent fluent radio group.
    [<CustomOperation("Name")>] member inline _.Name ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Name" => x)
    /// Gets or sets a value indicating whether the element needs to have a value.
    [<CustomOperation("Required")>] member inline _.Required ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Required" =>>> true)
    /// Gets or sets a value indicating whether the element needs to have a value.
    [<CustomOperation("Required")>] member inline _.Required ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Required" =>>> x)
    /// Gets or sets a value indicating whether the element is checked.
    [<CustomOperation("Checked")>] member inline _.Checked ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Boolean>) = render ==> ("Checked" => x)

type FluentSkeletonBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentComponentBaseBuilder<'FunBlazorGeneric>()
    /// Indicates the Skeleton should have a filled style.
    [<CustomOperation("Fill")>] member inline _.Fill ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Fill" => x)
    /// Gets or sets the shape of the skeleton. See SkeletonShape
    [<CustomOperation("Shape")>] member inline _.Shape ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<Microsoft.FluentUI.AspNetCore.Components.SkeletonShape>) = render ==> ("Shape" => x)
    /// Gets or sets the skeleton pattern.
    [<CustomOperation("Pattern")>] member inline _.Pattern ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Pattern" => x)
    /// Gets or sets a value indicating whether the skeleton is shimmered.
    [<CustomOperation("Shimmer")>] member inline _.Shimmer ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Boolean>) = render ==> ("Shimmer" => x)
    /// Gets or sets the width of the skeleton.
    [<CustomOperation("Width")>] member inline _.Width ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Width" => x)
    /// Gets or sets the height of the skeleton.
    [<CustomOperation("Height")>] member inline _.Height ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Height" => x)
    /// Gets or sets a value indicating whether the skeleton is visible.
    [<CustomOperation("Visible")>] member inline _.Visible ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Visible" =>>> true)
    /// Gets or sets a value indicating whether the skeleton is visible.
    [<CustomOperation("Visible")>] member inline _.Visible ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Visible" =>>> x)

type FluentSliderLabelBuilder<'FunBlazorGeneric, 'TValue when System.Numerics.INumber<'TValue> and 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentComponentBaseBuilder<'FunBlazorGeneric>()
    /// Gets or sets the value for this slider position.
    [<CustomOperation("Position")>] member inline _.Position ([<InlineIfLambda>] render: AttrRenderFragment, x: 'TValue) = render ==> ("Position" => x)
    /// Gets or sets a value indicating whether marks are hidden.
    [<CustomOperation("HideMark")>] member inline _.HideMark ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Boolean>) = render ==> ("HideMark" => x)
    /// Gets the disabled state of the label. This is controlled by the owning FluentSlider`1.
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Boolean>) = render ==> ("Disabled" => x)

type FluentSortableListBuilder<'FunBlazorGeneric, 'TItem when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentComponentBaseBuilder<'FunBlazorGeneric>()
    /// Gets or sets the template to be used to define each sortable item in the list.
    /// Use the @context parameter to access the item and its properties.
    [<CustomOperation("ItemTemplate")>] member inline _.ItemTemplate ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: 'TItem -> NodeRenderFragment) = render ==> html.renderFragment("ItemTemplate", fn)
    /// Gets or sets the list of items to be displayed in a sortable list.
    [<CustomOperation("Items")>] member inline _.Items ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.IEnumerable<'TItem>) = render ==> ("Items" => x)
    /// Event callback for when the list is updated.
    [<CustomOperation("OnUpdate")>] member inline _.OnUpdate ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.FluentUI.AspNetCore.Components.FluentSortableListEventArgs -> unit) = render ==> html.callback("OnUpdate", fn)
    /// Event callback for when the list is updated.
    [<CustomOperation("OnUpdate")>] member inline _.OnUpdate ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.FluentUI.AspNetCore.Components.FluentSortableListEventArgs -> Task<unit>) = render ==> html.callbackTask("OnUpdate", fn)
    /// Event callback for when an item is removed from the list.
    [<CustomOperation("OnRemove")>] member inline _.OnRemove ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.FluentUI.AspNetCore.Components.FluentSortableListEventArgs -> unit) = render ==> html.callback("OnRemove", fn)
    /// Event callback for when an item is removed from the list.
    [<CustomOperation("OnRemove")>] member inline _.OnRemove ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.FluentUI.AspNetCore.Components.FluentSortableListEventArgs -> Task<unit>) = render ==> html.callbackTask("OnRemove", fn)
    /// Gets or sets the name of the Group used for dragging between lists. Set the group to the same value on both lists to enable.
    /// You can only have 1 group with 2 lists.
    [<CustomOperation("Group")>] member inline _.Group ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Group" => x)
    /// Gets or sets whether elements are cloned instead of moved. Set Pull to "clone" to enable this.
    [<CustomOperation("Clone")>] member inline _.Clone ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Clone" =>>> true)
    /// Gets or sets whether elements are cloned instead of moved. Set Pull to "clone" to enable this.
    [<CustomOperation("Clone")>] member inline _.Clone ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Clone" =>>> x)
    /// Gets or sets wether it is possible to drop items into the current list from another list in the same group.
    /// Set to false to disable dropping from another list onto the current list.
    [<CustomOperation("Drop")>] member inline _.Drop ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Drop" =>>> true)
    /// Gets or sets wether it is possible to drop items into the current list from another list in the same group.
    /// Set to false to disable dropping from another list onto the current list.
    [<CustomOperation("Drop")>] member inline _.Drop ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Drop" =>>> x)
    /// Gets or sets whether the list is sortable.
    /// Default is true
    /// Disable sorting within a list by setting to false.
    [<CustomOperation("Sort")>] member inline _.Sort ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Sort" =>>> true)
    /// Gets or sets whether the list is sortable.
    /// Default is true
    /// Disable sorting within a list by setting to false.
    [<CustomOperation("Sort")>] member inline _.Sort ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Sort" =>>> x)
    /// Gets or sets whether the whole item acts as drag handle.
    /// Set to true to use an element with classname `.sortable-grab` as the handle.
    [<CustomOperation("Handle")>] member inline _.Handle ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Handle" =>>> true)
    /// Gets or sets whether the whole item acts as drag handle.
    /// Set to true to use an element with classname `.sortable-grab` as the handle.
    [<CustomOperation("Handle")>] member inline _.Handle ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Handle" =>>> x)
    /// Gets or sets the function to filter out elements that cannot be sorted or moved.
    [<CustomOperation("ItemFilter")>] member inline _.ItemFilter ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("ItemFilter" => (System.Func<'TItem, System.Boolean>fn))
    /// Gets or sets wether ro ignore the HTML5 DnD behaviour and force the fallback to kick in
    [<CustomOperation("Fallback")>] member inline _.Fallback ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Fallback" =>>> true)
    /// Gets or sets wether ro ignore the HTML5 DnD behaviour and force the fallback to kick in
    [<CustomOperation("Fallback")>] member inline _.Fallback ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Fallback" =>>> x)

type FluentMultiSplitterBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentComponentBaseBuilder<'FunBlazorGeneric>()
    /// Gets or sets the collapse callback.
    [<CustomOperation("OnCollapse")>] member inline _.OnCollapse ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.FluentUI.AspNetCore.Components.FluentMultiSplitterEventArgs -> unit) = render ==> html.callback("OnCollapse", fn)
    /// Gets or sets the collapse callback.
    [<CustomOperation("OnCollapse")>] member inline _.OnCollapse ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.FluentUI.AspNetCore.Components.FluentMultiSplitterEventArgs -> Task<unit>) = render ==> html.callbackTask("OnCollapse", fn)
    /// Gets or sets the expand callback.
    [<CustomOperation("OnExpand")>] member inline _.OnExpand ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.FluentUI.AspNetCore.Components.FluentMultiSplitterEventArgs -> unit) = render ==> html.callback("OnExpand", fn)
    /// Gets or sets the expand callback.
    [<CustomOperation("OnExpand")>] member inline _.OnExpand ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.FluentUI.AspNetCore.Components.FluentMultiSplitterEventArgs -> Task<unit>) = render ==> html.callbackTask("OnExpand", fn)
    /// Gets or sets the resize callback.
    [<CustomOperation("OnResize")>] member inline _.OnResize ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.FluentUI.AspNetCore.Components.FluentMultiSplitterResizeEventArgs -> unit) = render ==> html.callback("OnResize", fn)
    /// Gets or sets the resize callback.
    [<CustomOperation("OnResize")>] member inline _.OnResize ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.FluentUI.AspNetCore.Components.FluentMultiSplitterResizeEventArgs -> Task<unit>) = render ==> html.callbackTask("OnResize", fn)
    /// Gets or sets the size of the splitter bar in pixels. Default is 8
    [<CustomOperation("BarSize")>] member inline _.BarSize ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("BarSize" => x)
    /// Gets or sets the orientation.
    [<CustomOperation("Orientation")>] member inline _.Orientation ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.FluentUI.AspNetCore.Components.Orientation) = render ==> ("Orientation" => x)
    /// Gets or sets the width of the container.
    [<CustomOperation("Width")>] member inline _.Width ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Width" => x)
    /// Gets or sets the height of the container.
    [<CustomOperation("Height")>] member inline _.Height ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Height" => x)

type FluentMultiSplitterPaneBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentComponentBaseBuilder<'FunBlazorGeneric>()
    /// Gets or sets a value indicating whether this FluentMultiSplitterPane is collapsed.
    [<CustomOperation("Collapsed")>] member inline _.Collapsed ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Collapsed" =>>> true)
    /// Gets or sets a value indicating whether this FluentMultiSplitterPane is collapsed.
    [<CustomOperation("Collapsed")>] member inline _.Collapsed ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Collapsed" =>>> x)
    /// Gets or sets a value indicating whether this FluentMultiSplitterPane is collapsible.
    [<CustomOperation("Collapsible")>] member inline _.Collapsible ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Collapsible" =>>> true)
    /// Gets or sets a value indicating whether this FluentMultiSplitterPane is collapsible.
    [<CustomOperation("Collapsible")>] member inline _.Collapsible ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Collapsible" =>>> x)
    /// Determines the maximum value.
    [<CustomOperation("Max")>] member inline _.Max ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Max" => x)
    /// Determines the minimum value.
    [<CustomOperation("Min")>] member inline _.Min ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Min" => x)
    /// Gets or sets a value indicating whether this FluentMultiSplitterPane is resizable.
    [<CustomOperation("Resizable")>] member inline _.Resizable ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Resizable" =>>> true)
    /// Gets or sets a value indicating whether this FluentMultiSplitterPane is resizable.
    [<CustomOperation("Resizable")>] member inline _.Resizable ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Resizable" =>>> x)
    /// Gets or sets the size.
    [<CustomOperation("Size")>] member inline _.Size ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Size" => x)

type FluentSplitterBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentComponentBaseBuilder<'FunBlazorGeneric>()
    /// Gets or sets the orientation.
    /// Default is horizontal (i.e a vertical splitter bar)
    [<CustomOperation("Orientation")>] member inline _.Orientation ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.FluentUI.AspNetCore.Components.Orientation) = render ==> ("Orientation" => x)
    /// Gets or sets the content for the top/left panel.
    [<CustomOperation("Panel1")>] member inline _.Panel1 ([<InlineIfLambda>] render: AttrRenderFragment, fragment: NodeRenderFragment) = render ==> html.renderFragment("Panel1", fragment)
    /// Gets or sets the content for the top/left panel.
    [<CustomOperation("Panel1")>] member inline _.Panel1 ([<InlineIfLambda>] render: AttrRenderFragment, fragments: NodeRenderFragment seq) = render ==> html.renderFragment("Panel1", fragment { yield! fragments })
    /// Gets or sets the content for the top/left panel.
    [<CustomOperation("Panel1")>] member inline _.Panel1 ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("Panel1", html.text x)
    /// Gets or sets the content for the top/left panel.
    [<CustomOperation("Panel1")>] member inline _.Panel1 ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("Panel1", html.text x)
    /// Gets or sets the content for the top/left panel.
    [<CustomOperation("Panel1")>] member inline _.Panel1 ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("Panel1", html.text x)
    /// Gets or sets the content for the bottom/right panel.
    [<CustomOperation("Panel2")>] member inline _.Panel2 ([<InlineIfLambda>] render: AttrRenderFragment, fragment: NodeRenderFragment) = render ==> html.renderFragment("Panel2", fragment)
    /// Gets or sets the content for the bottom/right panel.
    [<CustomOperation("Panel2")>] member inline _.Panel2 ([<InlineIfLambda>] render: AttrRenderFragment, fragments: NodeRenderFragment seq) = render ==> html.renderFragment("Panel2", fragment { yield! fragments })
    /// Gets or sets the content for the bottom/right panel.
    [<CustomOperation("Panel2")>] member inline _.Panel2 ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("Panel2", html.text x)
    /// Gets or sets the content for the bottom/right panel.
    [<CustomOperation("Panel2")>] member inline _.Panel2 ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("Panel2", html.text x)
    /// Gets or sets the content for the bottom/right panel.
    [<CustomOperation("Panel2")>] member inline _.Panel2 ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("Panel2", html.text x)
    /// Gets or sets the size for the left/top panel. 
    /// Needs to be a valid css size like '50%' or '250px'.
    [<CustomOperation("Panel1Size")>] member inline _.Panel1Size ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Panel1Size" => x)
    /// Gets or sets the size for the right/bottom panel. 
    /// Needs to be a valid css size like '50%' or '250px'.
    /// Uses grid-template-rows/columns with max-content to determine end width. 
    /// See mdn web docs for more information 
    [<CustomOperation("Panel2Size")>] member inline _.Panel2Size ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Panel2Size" => x)
    /// Gets or sets the minimum size for the left/top panel.
    /// Needs to be a valid css size like '50%' or '250px'.
    [<CustomOperation("Panel1MinSize")>] member inline _.Panel1MinSize ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Panel1MinSize" => x)
    /// Gets or sets the minimum size for the right/bottom panel.
    /// Needs to be a valid css size like '50%' or '250px'.
    [<CustomOperation("Panel2MinSize")>] member inline _.Panel2MinSize ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Panel2MinSize" => x)
    /// Gets or sets the size of the splitter bar in pixels.
    /// Default is 8.
    [<CustomOperation("BarSize")>] member inline _.BarSize ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("BarSize" => x)
    /// Gets or sets a value indicating whether the splitter bar handle is visible.
    /// Default is true.
    [<CustomOperation("BarHandle")>] member inline _.BarHandle ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("BarHandle" =>>> true)
    /// Gets or sets a value indicating whether the splitter bar handle is visible.
    /// Default is true.
    [<CustomOperation("BarHandle")>] member inline _.BarHandle ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("BarHandle" =>>> x)
    /// Gets or sets a value indicating whether the splitter is collapsed.
    /// If set to true, Panel1 will take up all the space and Panel2 as well as the splitter bar will be hidden.
    [<CustomOperation("Collapsed")>] member inline _.Collapsed ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Collapsed" =>>> true)
    /// Gets or sets a value indicating whether the splitter is collapsed.
    /// If set to true, Panel1 will take up all the space and Panel2 as well as the splitter bar will be hidden.
    [<CustomOperation("Collapsed")>] member inline _.Collapsed ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Collapsed" =>>> x)
    [<CustomOperation("OnCollapsed")>] member inline _.OnCollapsed ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Boolean -> unit) = render ==> html.callback("OnCollapsed", fn)
    [<CustomOperation("OnCollapsed")>] member inline _.OnCollapsed ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Boolean -> Task<unit>) = render ==> html.callbackTask("OnCollapsed", fn)
    [<CustomOperation("OnExpanded")>] member inline _.OnExpanded ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Boolean -> unit) = render ==> html.callback("OnExpanded", fn)
    [<CustomOperation("OnExpanded")>] member inline _.OnExpanded ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Boolean -> Task<unit>) = render ==> html.callbackTask("OnExpanded", fn)
    [<CustomOperation("OnResized")>] member inline _.OnResized ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.FluentUI.AspNetCore.Components.SplitterResizedEventArgs -> unit) = render ==> html.callback("OnResized", fn)
    [<CustomOperation("OnResized")>] member inline _.OnResized ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.FluentUI.AspNetCore.Components.SplitterResizedEventArgs -> Task<unit>) = render ==> html.callbackTask("OnResized", fn)

type FluentStackBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentComponentBaseBuilder<'FunBlazorGeneric>()
    /// Gets or sets the horizontal alignment of the components in the stack.
    /// Default is Left
    [<CustomOperation("HorizontalAlignment")>] member inline _.HorizontalAlignment ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.FluentUI.AspNetCore.Components.HorizontalAlignment) = render ==> ("HorizontalAlignment" => x)
    /// Gets or sets the vertical alignment of the components in the stack.
    /// Default is Top
    [<CustomOperation("VerticalAlignment")>] member inline _.VerticalAlignment ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.FluentUI.AspNetCore.Components.VerticalAlignment) = render ==> ("VerticalAlignment" => x)
    /// Gets or sets the orientation of the stacked components.
    /// Default is Horizontal.
    [<CustomOperation("Orientation")>] member inline _.Orientation ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.FluentUI.AspNetCore.Components.Orientation) = render ==> ("Orientation" => x)
    /// Gets or sets the width of the stack as a percentage string (default = 100%).
    [<CustomOperation("Width")>] member inline _.Width ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Width" => x)
    /// Gets or sets a value indicating whether the stack wraps.
    [<CustomOperation("Wrap")>] member inline _.Wrap ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Wrap" =>>> true)
    /// Gets or sets a value indicating whether the stack wraps.
    [<CustomOperation("Wrap")>] member inline _.Wrap ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Wrap" =>>> x)
    /// Gets or sets the gap between horizontally stacked components (in pixels).
    /// Default is 10 pixels.
    [<CustomOperation("HorizontalGap")>] member inline _.HorizontalGap ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Int32>) = render ==> ("HorizontalGap" => x)
    /// Gets or sets the gap between vertically stacked components (in pixels).
    /// Default is 10 pixels.
    [<CustomOperation("VerticalGap")>] member inline _.VerticalGap ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Int32>) = render ==> ("VerticalGap" => x)

type FluentTabBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentComponentBaseBuilder<'FunBlazorGeneric>()
    /// When true, the control will be immutable by user interaction. See disabled HTML attribute for more information.
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Disabled" =>>> true)
    /// When true, the control will be immutable by user interaction. See disabled HTML attribute for more information.
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Disabled" =>>> x)
    /// Gets or sets the visibility of a tab
    [<CustomOperation("Visible")>] member inline _.Visible ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Visible" =>>> true)
    /// Gets or sets the visibility of a tab
    [<CustomOperation("Visible")>] member inline _.Visible ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Visible" =>>> x)
    /// Gets or sets the label of the tab.
    [<CustomOperation("Label")>] member inline _.Label ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Label" => x)
    /// Gets or sets the label of the tab.
    [<CustomOperation("Label'")>] member inline _.Label' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.String * (System.String -> unit)) = render ==> html.bind("Label", valueFn)
    /// Callback to invoke when the label changes.
    [<CustomOperation("LabelChanged")>] member inline _.LabelChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.String -> unit) = render ==> html.callback("LabelChanged", fn)
    /// Callback to invoke when the label changes.
    [<CustomOperation("LabelChanged")>] member inline _.LabelChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.String -> Task<unit>) = render ==> html.callbackTask("LabelChanged", fn)
    /// Gets or sets the class, applied to the Label Tab Item.
    [<CustomOperation("LabelClass")>] member inline _.LabelClass ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("LabelClass" => x)
    /// Gets or sets the style, applied to the Label Tab Item.
    [<CustomOperation("LabelStyle")>] member inline _.LabelStyle ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("LabelStyle" => x)
    /// Gets or sets the customized content of the header.
    [<CustomOperation("Header")>] member inline _.Header ([<InlineIfLambda>] render: AttrRenderFragment, fragment: NodeRenderFragment) = render ==> html.renderFragment("Header", fragment)
    /// Gets or sets the customized content of the header.
    [<CustomOperation("Header")>] member inline _.Header ([<InlineIfLambda>] render: AttrRenderFragment, fragments: NodeRenderFragment seq) = render ==> html.renderFragment("Header", fragment { yield! fragments })
    /// Gets or sets the customized content of the header.
    [<CustomOperation("Header")>] member inline _.Header ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("Header", html.text x)
    /// Gets or sets the customized content of the header.
    [<CustomOperation("Header")>] member inline _.Header ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("Header", html.text x)
    /// Gets or sets the customized content of the header.
    [<CustomOperation("Header")>] member inline _.Header ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("Header", html.text x)
    /// Gets or sets the icon to display in front of the tab
    [<CustomOperation("Icon")>] member inline _.Icon ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.FluentUI.AspNetCore.Components.Icon) = render ==> ("Icon" => x)
    /// True to let the user edit the Label property.
    [<CustomOperation("LabelEditable")>] member inline _.LabelEditable ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("LabelEditable" =>>> true)
    /// True to let the user edit the Label property.
    [<CustomOperation("LabelEditable")>] member inline _.LabelEditable ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("LabelEditable" =>>> x)
    /// Render the tab content only when the tab is selected.
    [<CustomOperation("DeferredLoading")>] member inline _.DeferredLoading ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("DeferredLoading" =>>> true)
    /// Render the tab content only when the tab is selected.
    [<CustomOperation("DeferredLoading")>] member inline _.DeferredLoading ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("DeferredLoading" =>>> x)
    /// Gets or sets the customized content of this tab panel.
    [<CustomOperation("Content")>] member inline _.Content ([<InlineIfLambda>] render: AttrRenderFragment, fragment: NodeRenderFragment) = render ==> html.renderFragment("Content", fragment)
    /// Gets or sets the customized content of this tab panel.
    [<CustomOperation("Content")>] member inline _.Content ([<InlineIfLambda>] render: AttrRenderFragment, fragments: NodeRenderFragment seq) = render ==> html.renderFragment("Content", fragment { yield! fragments })
    /// Gets or sets the customized content of this tab panel.
    [<CustomOperation("Content")>] member inline _.Content ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("Content", html.text x)
    /// Gets or sets the customized content of this tab panel.
    [<CustomOperation("Content")>] member inline _.Content ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("Content", html.text x)
    /// Gets or sets the customized content of this tab panel.
    [<CustomOperation("Content")>] member inline _.Content ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("Content", html.text x)
    /// Gets or sets the customized loading content message when using deferred loading.
    [<CustomOperation("LoadingContent")>] member inline _.LoadingContent ([<InlineIfLambda>] render: AttrRenderFragment, fragment: NodeRenderFragment) = render ==> html.renderFragment("LoadingContent", fragment)
    /// Gets or sets the customized loading content message when using deferred loading.
    [<CustomOperation("LoadingContent")>] member inline _.LoadingContent ([<InlineIfLambda>] render: AttrRenderFragment, fragments: NodeRenderFragment seq) = render ==> html.renderFragment("LoadingContent", fragment { yield! fragments })
    /// Gets or sets the customized loading content message when using deferred loading.
    [<CustomOperation("LoadingContent")>] member inline _.LoadingContent ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("LoadingContent", html.text x)
    /// Gets or sets the customized loading content message when using deferred loading.
    [<CustomOperation("LoadingContent")>] member inline _.LoadingContent ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("LoadingContent", html.text x)
    /// Gets or sets the customized loading content message when using deferred loading.
    [<CustomOperation("LoadingContent")>] member inline _.LoadingContent ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("LoadingContent", html.text x)

type FluentTabsBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentComponentBaseBuilder<'FunBlazorGeneric>()
    /// Gets or sets the tab's orentation. See Orientation
    [<CustomOperation("Orientation")>] member inline _.Orientation ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.FluentUI.AspNetCore.Components.Orientation) = render ==> ("Orientation" => x)
    /// Raised when a tab is selected.
    [<CustomOperation("OnTabSelect")>] member inline _.OnTabSelect ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.FluentUI.AspNetCore.Components.FluentTab -> unit) = render ==> html.callback("OnTabSelect", fn)
    /// Raised when a tab is selected.
    [<CustomOperation("OnTabSelect")>] member inline _.OnTabSelect ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.FluentUI.AspNetCore.Components.FluentTab -> Task<unit>) = render ==> html.callbackTask("OnTabSelect", fn)
    /// Raised when a tab is closed.
    [<CustomOperation("OnTabClose")>] member inline _.OnTabClose ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.FluentUI.AspNetCore.Components.FluentTab -> unit) = render ==> html.callback("OnTabClose", fn)
    /// Raised when a tab is closed.
    [<CustomOperation("OnTabClose")>] member inline _.OnTabClose ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.FluentUI.AspNetCore.Components.FluentTab -> Task<unit>) = render ==> html.callbackTask("OnTabClose", fn)
    /// Determines if a dismiss icon is shown.
    /// When clicked the OnTabClose event is raised to remove this tab from the list.
    [<CustomOperation("ShowClose")>] member inline _.ShowClose ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("ShowClose" =>>> true)
    /// Determines if a dismiss icon is shown.
    /// When clicked the OnTabClose event is raised to remove this tab from the list.
    [<CustomOperation("ShowClose")>] member inline _.ShowClose ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("ShowClose" =>>> x)
    /// Gets or sets the width of the tab items.
    [<CustomOperation("Size")>] member inline _.Size ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<Microsoft.FluentUI.AspNetCore.Components.TabSize>) = render ==> ("Size" => x)
    /// Gets or sets the width of the tabs component.
    /// Needs to be a valid CSS value (e.g. 100px, 50%).
    [<CustomOperation("Width")>] member inline _.Width ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Width" => x)
    /// Gets or sets the height of the tabs component.
    /// Needs to be a valid CSS value (e.g. 100px, 50%).
    [<CustomOperation("Height")>] member inline _.Height ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Height" => x)
    [<CustomOperation("ActiveTabId")>] member inline _.ActiveTabId ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("ActiveTabId" => x)
    [<CustomOperation("ActiveTabId'")>] member inline _.ActiveTabId' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.String * (System.String -> unit)) = render ==> html.bind("ActiveTabId", valueFn)
    /// Gets or sets a callback when the bound value is changed.
    [<CustomOperation("ActiveTabIdChanged")>] member inline _.ActiveTabIdChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.String -> unit) = render ==> html.callback("ActiveTabIdChanged", fn)
    /// Gets or sets a callback when the bound value is changed.
    [<CustomOperation("ActiveTabIdChanged")>] member inline _.ActiveTabIdChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.String -> Task<unit>) = render ==> html.callbackTask("ActiveTabIdChanged", fn)
    /// Gets or sets a value indicating whether the active indicator is displayed.
    [<CustomOperation("ShowActiveIndicator")>] member inline _.ShowActiveIndicator ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("ShowActiveIndicator" =>>> true)
    /// Gets or sets a value indicating whether the active indicator is displayed.
    [<CustomOperation("ShowActiveIndicator")>] member inline _.ShowActiveIndicator ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("ShowActiveIndicator" =>>> x)
    /// Gets or sets a callback when a tab is changed.
    [<CustomOperation("OnTabChange")>] member inline _.OnTabChange ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.FluentUI.AspNetCore.Components.FluentTab -> unit) = render ==> html.callback("OnTabChange", fn)
    /// Gets or sets a callback when a tab is changed.
    [<CustomOperation("OnTabChange")>] member inline _.OnTabChange ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.FluentUI.AspNetCore.Components.FluentTab -> Task<unit>) = render ==> html.callbackTask("OnTabChange", fn)

type FluentToastBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentComponentBaseBuilder<'FunBlazorGeneric>()
    /// Gets or sets the instance containing the programmatic API for the toast.
    [<CustomOperation("Instance")>] member inline _.Instance ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.FluentUI.AspNetCore.Components.ToastInstance) = render ==> ("Instance" => x)

type FluentToolbarBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentComponentBaseBuilder<'FunBlazorGeneric>()
    /// Gets or sets the toolbar's orentation. See Orientation
    [<CustomOperation("Orientation")>] member inline _.Orientation ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<Microsoft.FluentUI.AspNetCore.Components.Orientation>) = render ==> ("Orientation" => x)

type FluentTooltipBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentComponentBaseBuilder<'FunBlazorGeneric>()
    /// Gets or sets the value indicating whether the library should close the tooltip if the cursor leaves the anchor and the tooltip.
    /// By default, the tooltip closes if the cursor leaves the anchor, but not the tooltip itself.
    /// You can configure this behavior globally using the HideTooltipOnCursorLeave property.
    [<CustomOperation("HideTooltipOnCursorLeave")>] member inline _.HideTooltipOnCursorLeave ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Boolean>) = render ==> ("HideTooltipOnCursorLeave" => x)
    /// Use ITooltipService to create the tooltip, if this service was injected.
    /// If the ChildContent is dynamic, set this to false.
    /// Default, true.
    [<CustomOperation("UseTooltipService")>] member inline _.UseTooltipService ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("UseTooltipService" =>>> true)
    /// Use ITooltipService to create the tooltip, if this service was injected.
    /// If the ChildContent is dynamic, set this to false.
    /// Default, true.
    [<CustomOperation("UseTooltipService")>] member inline _.UseTooltipService ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("UseTooltipService" =>>> x)
    /// Gets or sets a value indicating whether the tooltip is visible.
    [<CustomOperation("Visible")>] member inline _.Visible ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Visible" =>>> true)
    /// Gets or sets a value indicating whether the tooltip is visible.
    [<CustomOperation("Visible")>] member inline _.Visible ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Visible" =>>> x)
    /// Required. Gets or sets the control identifier associated with the tooltip.
    [<CustomOperation("Anchor")>] member inline _.Anchor ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Anchor" => x)
    /// Gets or sets the delay (in milliseconds). 
    /// Default is 300.
    [<CustomOperation("Delay'")>] member inline _.Delay' ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Int32>) = render ==> ("Delay" => x)
    /// Gets or sets the tooltip's position. See TooltipPosition.
    /// Don't set this if you want the tooltip to use the best position.
    [<CustomOperation("Position")>] member inline _.Position ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<Microsoft.FluentUI.AspNetCore.Components.TooltipPosition>) = render ==> ("Position" => x)
    /// Gets or sets the maximum width of tooltip panel.
    [<CustomOperation("MaxWidth")>] member inline _.MaxWidth ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("MaxWidth" => x)
    /// Controls when the tooltip updates its position, default is anchor which only updates when
    /// the anchor is resized. Auto will update on scroll/resize events.
    /// Corresponds to anchored-region auto-update-mode.
    [<CustomOperation("AutoUpdateMode")>] member inline _.AutoUpdateMode ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<Microsoft.FluentUI.AspNetCore.Components.AutoUpdateMode>) = render ==> ("AutoUpdateMode" => x)
    /// Gets or sets whether the horizontal viewport is locked.
    [<CustomOperation("HorizontalViewportLock")>] member inline _.HorizontalViewportLock ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("HorizontalViewportLock" =>>> true)
    /// Gets or sets whether the horizontal viewport is locked.
    [<CustomOperation("HorizontalViewportLock")>] member inline _.HorizontalViewportLock ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("HorizontalViewportLock" =>>> x)
    /// Gets or sets whether the vertical viewport is locked.
    [<CustomOperation("VerticalViewportLock")>] member inline _.VerticalViewportLock ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("VerticalViewportLock" =>>> true)
    /// Gets or sets whether the vertical viewport is locked.
    [<CustomOperation("VerticalViewportLock")>] member inline _.VerticalViewportLock ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("VerticalViewportLock" =>>> x)
    /// Callback for when the tooltip is dismissed.
    [<CustomOperation("OnDismissed")>] member inline _.OnDismissed ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.EventArgs -> unit) = render ==> html.callback("OnDismissed", fn)
    /// Callback for when the tooltip is dismissed.
    [<CustomOperation("OnDismissed")>] member inline _.OnDismissed ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.EventArgs -> Task<unit>) = render ==> html.callbackTask("OnDismissed", fn)

type FluentTooltipProviderBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentComponentBaseBuilder<'FunBlazorGeneric>()


type FluentTreeItemBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentComponentBaseBuilder<'FunBlazorGeneric>()
    /// Gets or sets the list of sub-items to bind to the tree item
    [<CustomOperation("Items")>] member inline _.Items ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.IEnumerable<Microsoft.FluentUI.AspNetCore.Components.ITreeViewItem>) = render ==> ("Items" => x)
    /// Gets or sets the text of the tree item
    [<CustomOperation("Text")>] member inline _.Text ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Text" => x)
    /// Returns true if the tree item is expanded,
    /// and false if collapsed.
    [<CustomOperation("Expanded")>] member inline _.Expanded ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Expanded" =>>> true)
    /// Returns true if the tree item is expanded,
    /// and false if collapsed.
    [<CustomOperation("Expanded")>] member inline _.Expanded ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Expanded" =>>> x)
    /// Returns true if the tree item is expanded,
    /// and false if collapsed.
    [<CustomOperation("Expanded'")>] member inline _.Expanded' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.Boolean * (System.Boolean -> unit)) = render ==> html.bind("Expanded", valueFn)
    /// Called whenever Expanded changes.
    [<CustomOperation("ExpandedChanged")>] member inline _.ExpandedChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Boolean -> unit) = render ==> html.callback("ExpandedChanged", fn)
    /// Called whenever Expanded changes.
    [<CustomOperation("ExpandedChanged")>] member inline _.ExpandedChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Boolean -> Task<unit>) = render ==> html.callbackTask("ExpandedChanged", fn)
    /// When true, the control will appear selected by user interaction.
    [<CustomOperation("Selected")>] member inline _.Selected ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Selected" =>>> true)
    /// When true, the control will appear selected by user interaction.
    [<CustomOperation("Selected")>] member inline _.Selected ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Selected" =>>> x)
    /// When true, the control will appear selected by user interaction.
    [<CustomOperation("Selected'")>] member inline _.Selected' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.Boolean * (System.Boolean -> unit)) = render ==> html.bind("Selected", valueFn)
    /// Called whenever Selected changes.
    [<CustomOperation("SelectedChanged")>] member inline _.SelectedChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Boolean -> unit) = render ==> html.callback("SelectedChanged", fn)
    /// Called whenever Selected changes.
    [<CustomOperation("SelectedChanged")>] member inline _.SelectedChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Boolean -> Task<unit>) = render ==> html.callbackTask("SelectedChanged", fn)
    /// When true, the control will be immutable by user interaction. See disabled HTML attribute for more information.
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Disabled" =>>> true)
    /// When true, the control will be immutable by user interaction. See disabled HTML attribute for more information.
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Disabled" =>>> x)
    /// If set to true then the tree item will
    /// be expanded when it is created.
    [<CustomOperation("InitiallyExpanded")>] member inline _.InitiallyExpanded ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("InitiallyExpanded" =>>> true)
    /// If set to true then the tree item will
    /// be expanded when it is created.
    [<CustomOperation("InitiallyExpanded")>] member inline _.InitiallyExpanded ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("InitiallyExpanded" =>>> x)
    /// If set to true then the tree item will
    /// be selected when it is created.
    [<CustomOperation("InitiallySelected")>] member inline _.InitiallySelected ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("InitiallySelected" =>>> true)
    /// If set to true then the tree item will
    /// be selected when it is created.
    [<CustomOperation("InitiallySelected")>] member inline _.InitiallySelected ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("InitiallySelected" =>>> x)
    /// Gets or sets the Icon displayed at the start of tree item,
    /// when the node is collapsed.
    /// If this icon is not set, the IconExpanded will be used.
    [<CustomOperation("IconCollapsed")>] member inline _.IconCollapsed ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.FluentUI.AspNetCore.Components.Icon) = render ==> ("IconCollapsed" => x)
    /// Gets or sets the Icon displayed at the start of tree item,
    /// when the node is expanded.
    /// If this icon is not set, the IconCollapsed will be used.
    [<CustomOperation("IconExpanded")>] member inline _.IconExpanded ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.FluentUI.AspNetCore.Components.Icon) = render ==> ("IconExpanded" => x)

type FluentTreeViewBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentComponentBaseBuilder<'FunBlazorGeneric>()
    /// Gets or sets the list of items to bind to the tree.
    [<CustomOperation("Items")>] member inline _.Items ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.IEnumerable<Microsoft.FluentUI.AspNetCore.Components.ITreeViewItem>) = render ==> ("Items" => x)
    /// Gets or sets the currently selected tree item.
    /// Only when using the Items property.
    [<CustomOperation("SelectedItem")>] member inline _.SelectedItem ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.FluentUI.AspNetCore.Components.ITreeViewItem) = render ==> ("SelectedItem" => x)
    /// Gets or sets the currently selected tree item.
    /// Only when using the Items property.
    [<CustomOperation("SelectedItem'")>] member inline _.SelectedItem' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: Microsoft.FluentUI.AspNetCore.Components.ITreeViewItem * (Microsoft.FluentUI.AspNetCore.Components.ITreeViewItem -> unit)) = render ==> html.bind("SelectedItem", valueFn)
    /// Called when SelectedItem changes.
    /// Only when using the Items property.
    [<CustomOperation("SelectedItemChanged")>] member inline _.SelectedItemChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.FluentUI.AspNetCore.Components.ITreeViewItem -> unit) = render ==> html.callback("SelectedItemChanged", fn)
    /// Called when SelectedItem changes.
    /// Only when using the Items property.
    [<CustomOperation("SelectedItemChanged")>] member inline _.SelectedItemChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.FluentUI.AspNetCore.Components.ITreeViewItem -> Task<unit>) = render ==> html.callbackTask("SelectedItemChanged", fn)
    /// Gets or sets whether the tree should render nodes under collapsed items
    /// Defaults to false
    [<CustomOperation("RenderCollapsedNodes")>] member inline _.RenderCollapsedNodes ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("RenderCollapsedNodes" =>>> true)
    /// Gets or sets whether the tree should render nodes under collapsed items
    /// Defaults to false
    [<CustomOperation("RenderCollapsedNodes")>] member inline _.RenderCollapsedNodes ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("RenderCollapsedNodes" =>>> x)
    /// Gets or sets the currently selected tree item
    [<CustomOperation("CurrentSelected")>] member inline _.CurrentSelected ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.FluentUI.AspNetCore.Components.FluentTreeItem) = render ==> ("CurrentSelected" => x)
    /// Gets or sets the currently selected tree item
    [<CustomOperation("CurrentSelected'")>] member inline _.CurrentSelected' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: Microsoft.FluentUI.AspNetCore.Components.FluentTreeItem * (Microsoft.FluentUI.AspNetCore.Components.FluentTreeItem -> unit)) = render ==> html.bind("CurrentSelected", valueFn)
    /// Called when CurrentSelected changes.
    /// You cannot update FluentTreeItem properties.
    [<CustomOperation("CurrentSelectedChanged")>] member inline _.CurrentSelectedChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.FluentUI.AspNetCore.Components.FluentTreeItem -> unit) = render ==> html.callback("CurrentSelectedChanged", fn)
    /// Called when CurrentSelected changes.
    /// You cannot update FluentTreeItem properties.
    [<CustomOperation("CurrentSelectedChanged")>] member inline _.CurrentSelectedChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.FluentUI.AspNetCore.Components.FluentTreeItem -> Task<unit>) = render ==> html.callbackTask("CurrentSelectedChanged", fn)
    /// Called whenever Selected changes on an
    /// item within the tree.
    /// You cannot update FluentTreeItem properties.
    [<CustomOperation("OnSelectedChange")>] member inline _.OnSelectedChange ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.FluentUI.AspNetCore.Components.FluentTreeItem -> unit) = render ==> html.callback("OnSelectedChange", fn)
    /// Called whenever Selected changes on an
    /// item within the tree.
    /// You cannot update FluentTreeItem properties.
    [<CustomOperation("OnSelectedChange")>] member inline _.OnSelectedChange ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.FluentUI.AspNetCore.Components.FluentTreeItem -> Task<unit>) = render ==> html.callbackTask("OnSelectedChange", fn)
    /// Called whenever Expanded changes on an
    /// item within the tree.
    /// You cannot update FluentTreeItem properties.
    [<CustomOperation("OnExpandedChange")>] member inline _.OnExpandedChange ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.FluentUI.AspNetCore.Components.FluentTreeItem -> unit) = render ==> html.callback("OnExpandedChange", fn)
    /// Called whenever Expanded changes on an
    /// item within the tree.
    /// You cannot update FluentTreeItem properties.
    [<CustomOperation("OnExpandedChange")>] member inline _.OnExpandedChange ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.FluentUI.AspNetCore.Components.FluentTreeItem -> Task<unit>) = render ==> html.callbackTask("OnExpandedChange", fn)
    /// Gets or sets the template for rendering tree items.
    [<CustomOperation("ItemTemplate")>] member inline _.ItemTemplate ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.FluentUI.AspNetCore.Components.ITreeViewItem -> NodeRenderFragment) = render ==> html.renderFragment("ItemTemplate", fn)
    /// Can only be used when the Items is defined.
    /// Gets or sets whether the tree should use lazy loading when expanding nodes.
    /// If True, the tree will only render the children of a node when it is expanded and will remove them when it is collapsed.
    [<CustomOperation("LazyLoadItems")>] member inline _.LazyLoadItems ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("LazyLoadItems" =>>> true)
    /// Can only be used when the Items is defined.
    /// Gets or sets whether the tree should use lazy loading when expanding nodes.
    /// If True, the tree will only render the children of a node when it is expanded and will remove them when it is collapsed.
    [<CustomOperation("LazyLoadItems")>] member inline _.LazyLoadItems ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("LazyLoadItems" =>>> x)

type FluentWizardBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentComponentBaseBuilder<'FunBlazorGeneric>()
    /// Gets or sets the height of the wizard.
    [<CustomOperation("Height")>] member inline _.Height ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Height" => x)
    /// Gets or sets the width of the wizard.
    [<CustomOperation("Width")>] member inline _.Width ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Width" => x)
    /// Triggers when the done button is clicked.
    [<CustomOperation("OnFinish")>] member inline _.OnFinish ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: unit -> unit) = render ==> html.callback("OnFinish", fn)
    /// Triggers when the done button is clicked.
    [<CustomOperation("OnFinish")>] member inline _.OnFinish ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: unit -> Task<unit>) = render ==> html.callbackTask("OnFinish", fn)
    /// Gets or sets the stepper position in the wizard (Top or Left).
    [<CustomOperation("StepperPosition")>] member inline _.StepperPosition ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.FluentUI.AspNetCore.Components.StepperPosition) = render ==> ("StepperPosition" => x)
    /// Gets or sets the stepper width (if position is Left)
    /// or the stepper height (if position is Top).
    [<CustomOperation("StepperSize")>] member inline _.StepperSize ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("StepperSize" => x)
    /// Gets or sets the space between two bullets (ex. 120px).
    [<CustomOperation("StepperBulletSpace")>] member inline _.StepperBulletSpace ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("StepperBulletSpace" => x)
    /// Display a border of the Wizard.
    [<CustomOperation("Border")>] member inline _.Border ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.FluentUI.AspNetCore.Components.WizardBorder) = render ==> ("Border" => x)
    /// Display a number on each step icon. Can be overridden by the step DisplayStepNumber property.
    [<CustomOperation("DisplayStepNumber")>] member inline _.DisplayStepNumber ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.FluentUI.AspNetCore.Components.WizardStepStatus) = render ==> ("DisplayStepNumber" => x)
    /// Gets or sets the step index of the current step.
    /// This value is bindable.
    [<CustomOperation("Value")>] member inline _.Value ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("Value" => x)
    /// Gets or sets the step index of the current step.
    /// This value is bindable.
    [<CustomOperation("Value'")>] member inline _.Value' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.Int32 * (System.Int32 -> unit)) = render ==> html.bind("Value", valueFn)
    /// Triggers when the value has changed.
    [<CustomOperation("ValueChanged")>] member inline _.ValueChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Int32 -> unit) = render ==> html.callback("ValueChanged", fn)
    /// Triggers when the value has changed.
    [<CustomOperation("ValueChanged")>] member inline _.ValueChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Int32 -> Task<unit>) = render ==> html.callbackTask("ValueChanged", fn)
    /// Gets or sets the buttons section of the wizard.
    /// This configuration overrides the whole rendering of the bottom-right section of the Wizard,
    /// including the built-in buttons and thus provides a full control over it.
    /// Custom Wizard buttons do not trigger the component OnChange and OnFinish events.
    /// The OnChange event can be triggered using the GoToStepAsync method from your code.
    [<CustomOperation("ButtonTemplate")>] member inline _.ButtonTemplate ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Int32 -> NodeRenderFragment) = render ==> html.renderFragment("ButtonTemplate", fn)
    /// Gets or sets the wizard steps. Add WizardStep tags inside this tag.
    [<CustomOperation("Steps")>] member inline _.Steps ([<InlineIfLambda>] render: AttrRenderFragment, fragment: NodeRenderFragment) = render ==> html.renderFragment("Steps", fragment)
    /// Gets or sets the wizard steps. Add WizardStep tags inside this tag.
    [<CustomOperation("Steps")>] member inline _.Steps ([<InlineIfLambda>] render: AttrRenderFragment, fragments: NodeRenderFragment seq) = render ==> html.renderFragment("Steps", fragment { yield! fragments })
    /// Gets or sets the wizard steps. Add WizardStep tags inside this tag.
    [<CustomOperation("Steps")>] member inline _.Steps ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("Steps", html.text x)
    /// Gets or sets the wizard steps. Add WizardStep tags inside this tag.
    [<CustomOperation("Steps")>] member inline _.Steps ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("Steps", html.text x)
    /// Gets or sets the wizard steps. Add WizardStep tags inside this tag.
    [<CustomOperation("Steps")>] member inline _.Steps ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("Steps", html.text x)
    /// Hide step titles and summaries on specified sizes (you can combine several values: GridItemHidden.Sm | GridItemHidden.Xl).
    /// The default value is XsAndDown to adapt to mobile devices.
    [<CustomOperation("StepTitleHiddenWhen")>] member inline _.StepTitleHiddenWhen ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<Microsoft.FluentUI.AspNetCore.Components.GridItemHidden>) = render ==> ("StepTitleHiddenWhen" => x)
    /// Gets or sets the way to navigate in the Wizard Steps.
    /// Default is Linear.
    [<CustomOperation("StepSequence")>] member inline _.StepSequence ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.FluentUI.AspNetCore.Components.WizardStepSequence) = render ==> ("StepSequence" => x)

type FluentWizardStepBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentComponentBaseBuilder<'FunBlazorGeneric>()
    /// Gets or sets the template of the step icon.
    [<CustomOperation("StepTemplate")>] member inline _.StepTemplate ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.FluentUI.AspNetCore.Components.FluentWizardStepArgs -> NodeRenderFragment) = render ==> html.renderFragment("StepTemplate", fn)
    /// Gets or sets whether the step is disabled.
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Disabled" =>>> true)
    /// Gets or sets whether the step is disabled.
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Disabled" =>>> x)
    /// Render the Wizard Step content only when the Step is selected.
    [<CustomOperation("DeferredLoading")>] member inline _.DeferredLoading ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("DeferredLoading" =>>> true)
    /// Render the Wizard Step content only when the Step is selected.
    [<CustomOperation("DeferredLoading")>] member inline _.DeferredLoading ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("DeferredLoading" =>>> x)
    /// Gets or sets the label of the step.
    [<CustomOperation("Label")>] member inline _.Label ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Label" => x)
    /// Display a number the step icon.
    /// By default, this is the DisplayStepNumber value.
    [<CustomOperation("DisplayStepNumber")>] member inline _.DisplayStepNumber ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Boolean>) = render ==> ("DisplayStepNumber" => x)
    /// The OnChange event fires before the current step has changed.
    /// The EventArgs contains a field of the targeted new step and a field to cancel the build-in action.
    [<CustomOperation("OnChange")>] member inline _.OnChange ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.FluentUI.AspNetCore.Components.FluentWizardStepChangeEventArgs -> unit) = render ==> html.callback("OnChange", fn)
    /// The OnChange event fires before the current step has changed.
    /// The EventArgs contains a field of the targeted new step and a field to cancel the build-in action.
    [<CustomOperation("OnChange")>] member inline _.OnChange ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.FluentUI.AspNetCore.Components.FluentWizardStepChangeEventArgs -> Task<unit>) = render ==> html.callbackTask("OnChange", fn)
    /// Gets or sets the summary of the step, to diplay near the label.
    [<CustomOperation("Summary")>] member inline _.Summary ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Summary" => x)
    /// Gets or sets the icon to display for the past/previous step.
    /// By default, it is a checkmark circle.
    [<CustomOperation("IconPrevious")>] member inline _.IconPrevious ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.FluentUI.AspNetCore.Components.Icon) = render ==> ("IconPrevious" => x)
    /// Gets or sets the icon to display for the current/active step.
    /// By default, it is a checkmark circle.
    [<CustomOperation("IconCurrent")>] member inline _.IconCurrent ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.FluentUI.AspNetCore.Components.Icon) = render ==> ("IconCurrent" => x)
    /// Gets or sets the icon to display for the future/next step.
    /// By default, it is a checkmark circle.
    [<CustomOperation("IconNext")>] member inline _.IconNext ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.FluentUI.AspNetCore.Components.Icon) = render ==> ("IconNext" => x)

            
namespace rec Microsoft.FluentUI.AspNetCore.Components.DslInternals

open System.Threading.Tasks
open FSharp.Data.Adaptive
open Fun.Blazor
open Fun.Blazor.Operators
open Microsoft.FluentUI.AspNetCore.Components.DslInternals

type EditFormBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAndChildAttrBuilder<'FunBlazorGeneric>()
    [<CustomOperation("AdditionalAttributes")>] member inline _.AdditionalAttributes ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.IReadOnlyDictionary<System.String, System.Object>) = render ==> ("AdditionalAttributes" => x)
    [<CustomOperation("EditContext")>] member inline _.EditContext ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.AspNetCore.Components.Forms.EditContext) = render ==> ("EditContext" => x)
    [<CustomOperation("Enhance")>] member inline _.Enhance ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Enhance" =>>> true)
    [<CustomOperation("Enhance")>] member inline _.Enhance ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Enhance" =>>> x)
    [<CustomOperation("Model")>] member inline _.Model ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Object) = render ==> ("Model" => x)
    [<CustomOperation("ChildContent")>] member inline _.ChildContent ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.AspNetCore.Components.Forms.EditContext -> NodeRenderFragment) = render ==> html.renderFragment("ChildContent", fn)
    [<CustomOperation("OnSubmit")>] member inline _.OnSubmit ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.AspNetCore.Components.Forms.EditContext -> unit) = render ==> html.callback("OnSubmit", fn)
    [<CustomOperation("OnSubmit")>] member inline _.OnSubmit ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.AspNetCore.Components.Forms.EditContext -> Task<unit>) = render ==> html.callbackTask("OnSubmit", fn)
    [<CustomOperation("OnValidSubmit")>] member inline _.OnValidSubmit ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.AspNetCore.Components.Forms.EditContext -> unit) = render ==> html.callback("OnValidSubmit", fn)
    [<CustomOperation("OnValidSubmit")>] member inline _.OnValidSubmit ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.AspNetCore.Components.Forms.EditContext -> Task<unit>) = render ==> html.callbackTask("OnValidSubmit", fn)
    [<CustomOperation("OnInvalidSubmit")>] member inline _.OnInvalidSubmit ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.AspNetCore.Components.Forms.EditContext -> unit) = render ==> html.callback("OnInvalidSubmit", fn)
    [<CustomOperation("OnInvalidSubmit")>] member inline _.OnInvalidSubmit ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.AspNetCore.Components.Forms.EditContext -> Task<unit>) = render ==> html.callbackTask("OnInvalidSubmit", fn)
    [<CustomOperation("FormName")>] member inline _.FormName ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("FormName" => x)

            
namespace rec Microsoft.FluentUI.AspNetCore.Components.DslInternals

open System.Threading.Tasks
open FSharp.Data.Adaptive
open Fun.Blazor
open Fun.Blazor.Operators
open Microsoft.FluentUI.AspNetCore.Components.DslInternals

type FluentEditFormBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit EditFormBuilder<'FunBlazorGeneric>()


            
namespace rec Microsoft.FluentUI.AspNetCore.Components.DslInternals

open System.Threading.Tasks
open FSharp.Data.Adaptive
open Fun.Blazor
open Fun.Blazor.Operators
open Microsoft.FluentUI.AspNetCore.Components.DslInternals

type ValidationSummaryBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAndChildAttrBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Model")>] member inline _.Model ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Object) = render ==> ("Model" => x)
    [<CustomOperation("AdditionalAttributes")>] member inline _.AdditionalAttributes ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.IReadOnlyDictionary<System.String, System.Object>) = render ==> ("AdditionalAttributes" => x)

            
namespace rec Microsoft.FluentUI.AspNetCore.Components.DslInternals

open System.Threading.Tasks
open FSharp.Data.Adaptive
open Fun.Blazor
open Fun.Blazor.Operators
open Microsoft.FluentUI.AspNetCore.Components.DslInternals

type FluentValidationSummaryBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ValidationSummaryBuilder<'FunBlazorGeneric>()


/// The status message will be read by screen readers.
/// This component must be loaded when the page is rendered (it cannot be displayed or hidden using conditions).
type FluentAccessibilityStatusBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAttrBuilder<'FunBlazorGeneric>()
    /// Gets or sets the status message to be read by screen readers.
    [<CustomOperation("Message")>] member inline _.Message ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Message" => x)
    /// In Debug mode, you can set this to true to display the status message on the page (on right, in yellow).
    [<CustomOperation("DebugDisplay")>] member inline _.DebugDisplay ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("DebugDisplay" =>>> true)
    /// In Debug mode, you can set this to true to display the status message on the page (on right, in yellow).
    [<CustomOperation("DebugDisplay")>] member inline _.DebugDisplay ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("DebugDisplay" =>>> x)

/// An abstract base class for columns in a FluentDataGrid`1.
type ColumnBaseBuilder<'FunBlazorGeneric, 'TGridItem when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAndChildAttrBuilder<'FunBlazorGeneric>()
    /// Gets or sets the title text for the column.
    /// This is rendered automatically if HeaderCellItemTemplate is not used.
    [<CustomOperation("Title")>] member inline _.Title ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Title" => x)
    /// Gets or sets the index (1-based) of the column
    [<CustomOperation("Index")>] member inline _.Index ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("Index" => x)
    /// If specified, controls the justification of header and grid cells for this column.
    [<CustomOperation("Align")>] member inline _.Align ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.FluentUI.AspNetCore.Components.Align) = render ==> ("Align" => x)
    /// If true, generates a title and aria-label attribute for the cell contents
    [<CustomOperation("Tooltip")>] member inline _.Tooltip ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Tooltip" =>>> true)
    /// If true, generates a title and aria-label attribute for the cell contents
    [<CustomOperation("Tooltip")>] member inline _.Tooltip ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Tooltip" =>>> x)
    /// Gets or sets the function that defines the value to be used as the tooltip and aria-label in this column's cells
    [<CustomOperation("TooltipText")>] member inline _.TooltipText ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("TooltipText" => (System.Func<'TGridItem, System.String>fn))
    /// Gets or sets the tooltip text for the column header.
    [<CustomOperation("HeaderTooltip")>] member inline _.HeaderTooltip ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("HeaderTooltip" => x)
    /// Gets or sets an optional template for this column's header cell.
    /// If not specified, the default header template includes the Title along with any applicable sort indicators and options buttons.
    [<CustomOperation("HeaderCellItemTemplate")>] member inline _.HeaderCellItemTemplate ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.FluentUI.AspNetCore.Components.ColumnBase<'TGridItem> -> NodeRenderFragment) = render ==> html.renderFragment("HeaderCellItemTemplate", fn)
    /// If specified, indicates that this column has this associated options UI. A button to display this
    /// UI will be included in the header cell by default.
    ///             
    /// If HeaderCellItemTemplate is used, it is left up to that template to render any relevant
    /// "show options" UI and invoke the grid's ShowColumnOptionsAsync).
    [<CustomOperation("ColumnOptions")>] member inline _.ColumnOptions ([<InlineIfLambda>] render: AttrRenderFragment, fragment: NodeRenderFragment) = render ==> html.renderFragment("ColumnOptions", fragment)
    /// If specified, indicates that this column has this associated options UI. A button to display this
    /// UI will be included in the header cell by default.
    ///             
    /// If HeaderCellItemTemplate is used, it is left up to that template to render any relevant
    /// "show options" UI and invoke the grid's ShowColumnOptionsAsync).
    [<CustomOperation("ColumnOptions")>] member inline _.ColumnOptions ([<InlineIfLambda>] render: AttrRenderFragment, fragments: NodeRenderFragment seq) = render ==> html.renderFragment("ColumnOptions", fragment { yield! fragments })
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
    /// Gets or sets a value indicating whether the data should be sortable by this column.
    ///             
    /// The default value may vary according to the column type (for example, a TemplateColumn`1
    /// or PropertyColumn`2 is sortable by default if anySortBy
    /// or SortBy parameter is specified).
    [<CustomOperation("Sortable")>] member inline _.Sortable ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Boolean>) = render ==> ("Sortable" => x)
    /// Gets or sets a value indicating whether the data is currently filtered by this column.
    ///             
    /// The default value is false.
    [<CustomOperation("Filtered")>] member inline _.Filtered ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Boolean>) = render ==> ("Filtered" => x)
    /// Gets or sets the initial sort direction.
    /// if IsDefaultSortColumn is true.
    [<CustomOperation("InitialSortDirection")>] member inline _.InitialSortDirection ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.FluentUI.AspNetCore.Components.SortDirection) = render ==> ("InitialSortDirection" => x)
    /// Gets or sets a value indicating whether this column should be sorted by default.
    [<CustomOperation("IsDefaultSortColumn")>] member inline _.IsDefaultSortColumn ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("IsDefaultSortColumn" =>>> true)
    /// Gets or sets a value indicating whether this column should be sorted by default.
    [<CustomOperation("IsDefaultSortColumn")>] member inline _.IsDefaultSortColumn ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("IsDefaultSortColumn" =>>> x)
    /// If specified, virtualized grids will use this template to render cells whose data has not yet been loaded.
    [<CustomOperation("PlaceholderTemplate")>] member inline _.PlaceholderTemplate ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.AspNetCore.Components.Web.Virtualization.PlaceholderContext -> NodeRenderFragment) = render ==> html.renderFragment("PlaceholderTemplate", fn)
    /// Gets or sets the width of the column.
    /// Use either this or the FluentDataGrid`1 GridTemplateColumns parameter but not both.
    /// Needs to be a valid CSS width value like '100px', '10%' or '0.5fr'.
    [<CustomOperation("Width")>] member inline _.Width ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Width" => x)

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
    [<CustomOperation("SortBy")>] member inline _.SortBy ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.FluentUI.AspNetCore.Components.GridSort<'TGridItem>) = render ==> ("SortBy" => x)

/// Represents a FluentDataGrid`1 column whose cells render a selected checkbox updated when the user click on a row.
type SelectColumnBuilder<'FunBlazorGeneric, 'TGridItem when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ColumnBaseBuilder<'FunBlazorGeneric, 'TGridItem>()
    /// Gets or sets the content to be rendered for each row in the table.
    [<CustomOperation("ChildContent")>] member inline _.ChildContent ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: 'TGridItem -> NodeRenderFragment) = render ==> html.renderFragment("ChildContent", fn)
    /// Gets or sets whether the [All] checkbox is disabled (not clickable).
    [<CustomOperation("SelectAllDisabled")>] member inline _.SelectAllDisabled ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("SelectAllDisabled" =>>> true)
    /// Gets or sets whether the [All] checkbox is disabled (not clickable).
    [<CustomOperation("SelectAllDisabled")>] member inline _.SelectAllDisabled ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("SelectAllDisabled" =>>> x)
    /// Gets or sets whether the selection of rows is restricted to the SelectColumn (false) or if the whole row can be clicked to toggled the selection (true).
    /// Default is True.
    [<CustomOperation("SelectFromEntireRow")>] member inline _.SelectFromEntireRow ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("SelectFromEntireRow" =>>> true)
    /// Gets or sets whether the selection of rows is restricted to the SelectColumn (false) or if the whole row can be clicked to toggled the selection (true).
    /// Default is True.
    [<CustomOperation("SelectFromEntireRow")>] member inline _.SelectFromEntireRow ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("SelectFromEntireRow" =>>> x)
    /// Gets or sets the template for the [All] checkbox column template.
    [<CustomOperation("SelectAllTemplate")>] member inline _.SelectAllTemplate ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.FluentUI.AspNetCore.Components.SelectAllTemplateArgs -> NodeRenderFragment) = render ==> html.renderFragment("SelectAllTemplate", fn)
    /// Gets or sets the list of selected items.
    [<CustomOperation("SelectedItems")>] member inline _.SelectedItems ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.IEnumerable<'TGridItem>) = render ==> ("SelectedItems" => x)
    /// Gets or sets the list of selected items.
    [<CustomOperation("SelectedItems'")>] member inline _.SelectedItems' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.Collections.Generic.IEnumerable<'TGridItem> * (System.Collections.Generic.IEnumerable<'TGridItem> -> unit)) = render ==> html.bind("SelectedItems", valueFn)
    /// Gets or sets a callback when list of selected items changed.
    [<CustomOperation("SelectedItemsChanged")>] member inline _.SelectedItemsChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Collections.Generic.IEnumerable<'TGridItem> -> unit) = render ==> html.callback("SelectedItemsChanged", fn)
    /// Gets or sets a callback when list of selected items changed.
    [<CustomOperation("SelectedItemsChanged")>] member inline _.SelectedItemsChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Collections.Generic.IEnumerable<'TGridItem> -> Task<unit>) = render ==> html.callbackTask("SelectedItemsChanged", fn)
    /// Gets or sets the selection mode (Single, SingleSticky or Multiple).
    [<CustomOperation("SelectMode")>] member inline _.SelectMode ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.FluentUI.AspNetCore.Components.DataGridSelectMode) = render ==> ("SelectMode" => x)
    /// Gets or sets the Icon to be rendered when the row is non selected.
    [<CustomOperation("IconUnchecked")>] member inline _.IconUnchecked ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.FluentUI.AspNetCore.Components.Icon) = render ==> ("IconUnchecked" => x)
    /// Gets or sets the Icon title display as a tooltip and used with Accessibility.
    /// The default text is "Row unselected".
    [<CustomOperation("TitleUnchecked")>] member inline _.TitleUnchecked ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("TitleUnchecked" => x)
    /// Gets or sets the Icon to be rendered when the row is selected.
    [<CustomOperation("IconChecked")>] member inline _.IconChecked ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.FluentUI.AspNetCore.Components.Icon) = render ==> ("IconChecked" => x)
    /// Gets or sets the Icon title display as a tooltip and used with Accessibility.
    /// The default text is "Row selected".
    [<CustomOperation("TitleChecked")>] member inline _.TitleChecked ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("TitleChecked" => x)
    /// Gets or sets the Icon to be rendered when some but not all rows are selected.
    /// Only when SelectMode is Multiple.
    [<CustomOperation("IconIndeterminate")>] member inline _.IconIndeterminate ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.FluentUI.AspNetCore.Components.Icon) = render ==> ("IconIndeterminate" => x)
    /// Gets or sets the Icon title display as a tooltip and used with Accessibility.
    /// The default text is "All rows are selected.".
    [<CustomOperation("TitleAllChecked")>] member inline _.TitleAllChecked ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("TitleAllChecked" => x)
    /// Gets or sets the Icon title display as a tooltip and used with Accessibility.
    /// The default text is "No rows are selected.".
    [<CustomOperation("TitleAllUnchecked")>] member inline _.TitleAllUnchecked ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("TitleAllUnchecked" => x)
    /// Gets or sets the Icon title display as a tooltip and used with Accessibility.
    /// The default text is "Some rows are selected.".
    [<CustomOperation("TitleAllIndeterminate")>] member inline _.TitleAllIndeterminate ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("TitleAllIndeterminate" => x)
    /// Gets or sets the action to be executed when the row is selected or unselected.
    /// This action is required to update you data model.
    [<CustomOperation("OnSelect")>] member inline _.OnSelect ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.ValueTuple<'TGridItem, System.Boolean> -> unit) = render ==> html.callback("OnSelect", fn)
    /// Gets or sets the action to be executed when the row is selected or unselected.
    /// This action is required to update you data model.
    [<CustomOperation("OnSelect")>] member inline _.OnSelect ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.ValueTuple<'TGridItem, System.Boolean> -> Task<unit>) = render ==> html.callbackTask("OnSelect", fn)
    /// Gets or sets the value indicating whether the [All] checkbox is selected.
    /// Null is undefined.
    [<CustomOperation("SelectAll")>] member inline _.SelectAll ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Boolean>) = render ==> ("SelectAll" => x)
    /// Gets or sets the value indicating whether the [All] checkbox is selected.
    /// Null is undefined.
    [<CustomOperation("SelectAll'")>] member inline _.SelectAll' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.Nullable<System.Boolean> * (System.Nullable<System.Boolean> -> unit)) = render ==> html.bind("SelectAll", valueFn)
    /// Gets or sets the action to be executed when the [All] checkbox is clicked.
    /// When this action is defined, the [All] checkbox is displayed.
    /// This action is required to update you data model.
    [<CustomOperation("SelectAllChanged")>] member inline _.SelectAllChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Nullable<System.Boolean> -> unit) = render ==> html.callback("SelectAllChanged", fn)
    /// Gets or sets the action to be executed when the [All] checkbox is clicked.
    /// When this action is defined, the [All] checkbox is displayed.
    /// This action is required to update you data model.
    [<CustomOperation("SelectAllChanged")>] member inline _.SelectAllChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Nullable<System.Boolean> -> Task<unit>) = render ==> html.callbackTask("SelectAllChanged", fn)
    /// Gets or sets the function executed to determine if the item can be selected.
    [<CustomOperation("Selectable")>] member inline _.Selectable ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("Selectable" => (System.Func<'TGridItem, System.Boolean>fn))
    /// Gets or sets the function to executed to determine checked/unchecked status.
    [<CustomOperation("Property")>] member inline _.Property ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("Property" => (System.Func<'TGridItem, System.Boolean>fn))
    [<CustomOperation("SortBy")>] member inline _.SortBy ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.FluentUI.AspNetCore.Components.GridSort<'TGridItem>) = render ==> ("SortBy" => x)

/// Represents a FluentDataGrid`1 column whose cells render a supplied template.
type TemplateColumnBuilder<'FunBlazorGeneric, 'TGridItem when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ColumnBaseBuilder<'FunBlazorGeneric, 'TGridItem>()
    /// Gets or sets the content to be rendered for each row in the table.
    [<CustomOperation("ChildContent")>] member inline _.ChildContent ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: 'TGridItem -> NodeRenderFragment) = render ==> html.renderFragment("ChildContent", fn)
    [<CustomOperation("SortBy")>] member inline _.SortBy ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.FluentUI.AspNetCore.Components.GridSort<'TGridItem>) = render ==> ("SortBy" => x)

type ColumnResizeOptionsBuilder<'FunBlazorGeneric, 'TGridItem when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAttrBuilder<'FunBlazorGeneric>()
    /// Gets or sets the index of the Column to act upon
    [<CustomOperation("Column")>] member inline _.Column ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("Column" => x)
    /// Gets or sets the type of resize to perform
    /// Discrete: resize by a 10 pixels at a time
    /// Exact: resize to the exact width specified (in pixels)
    /// The display of this component is dependant on a ResizeType being set
    [<CustomOperation("ResizeType")>] member inline _.ResizeType ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<Microsoft.FluentUI.AspNetCore.Components.DataGridResizeType>) = render ==> ("ResizeType" => x)

type FluentDesignThemeBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAndChildAttrBuilder<'FunBlazorGeneric>()
    /// Gets or sets the identifier for the component.
    [<CustomOperation("Id")>] member inline _.Id ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Id" => x)
    /// Gets or sets the Theme mode: Dark, Light, or browser System theme.
    [<CustomOperation("Mode")>] member inline _.Mode ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.FluentUI.AspNetCore.Components.DesignThemeModes) = render ==> ("Mode" => x)
    /// Gets or sets the Theme mode: Dark, Light, or browser System theme.
    [<CustomOperation("Mode'")>] member inline _.Mode' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: Microsoft.FluentUI.AspNetCore.Components.DesignThemeModes * (Microsoft.FluentUI.AspNetCore.Components.DesignThemeModes -> unit)) = render ==> html.bind("Mode", valueFn)
    /// Gets or sets a callback that updates the Mode.
    [<CustomOperation("ModeChanged")>] member inline _.ModeChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.FluentUI.AspNetCore.Components.DesignThemeModes -> unit) = render ==> html.callback("ModeChanged", fn)
    /// Gets or sets a callback that updates the Mode.
    [<CustomOperation("ModeChanged")>] member inline _.ModeChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.FluentUI.AspNetCore.Components.DesignThemeModes -> Task<unit>) = render ==> html.callbackTask("ModeChanged", fn)
    /// Gets or sets the Accent base color.
    [<CustomOperation("CustomColor")>] member inline _.CustomColor ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("CustomColor" => x)
    /// Gets or sets the Accent base color.
    [<CustomOperation("CustomColor'")>] member inline _.CustomColor' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.String * (System.String -> unit)) = render ==> html.bind("CustomColor", valueFn)
    /// Gets or sets a callback that updates the CustomColor.
    [<CustomOperation("CustomColorChanged")>] member inline _.CustomColorChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.String -> unit) = render ==> html.callback("CustomColorChanged", fn)
    /// Gets or sets a callback that updates the CustomColor.
    [<CustomOperation("CustomColorChanged")>] member inline _.CustomColorChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.String -> Task<unit>) = render ==> html.callbackTask("CustomColorChanged", fn)
    /// Gets or sets the application to defined the Accent base color.
    [<CustomOperation("OfficeColor")>] member inline _.OfficeColor ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<Microsoft.FluentUI.AspNetCore.Components.OfficeColor>) = render ==> ("OfficeColor" => x)
    /// Gets or sets the application to defined the Accent base color.
    [<CustomOperation("OfficeColor'")>] member inline _.OfficeColor' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.Nullable<Microsoft.FluentUI.AspNetCore.Components.OfficeColor> * (System.Nullable<Microsoft.FluentUI.AspNetCore.Components.OfficeColor> -> unit)) = render ==> html.bind("OfficeColor", valueFn)
    /// Gets or sets a callback that updates the OfficeColor.
    [<CustomOperation("OfficeColorChanged")>] member inline _.OfficeColorChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Nullable<Microsoft.FluentUI.AspNetCore.Components.OfficeColor> -> unit) = render ==> html.callback("OfficeColorChanged", fn)
    /// Gets or sets a callback that updates the OfficeColor.
    [<CustomOperation("OfficeColorChanged")>] member inline _.OfficeColorChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Nullable<Microsoft.FluentUI.AspNetCore.Components.OfficeColor> -> Task<unit>) = render ==> html.callbackTask("OfficeColorChanged", fn)
    /// Gets or sets the local storage name to save and retrieve the Mode and the OfficeColor / CustomColor.
    [<CustomOperation("StorageName")>] member inline _.StorageName ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("StorageName" => x)
    /// Gets or sets the body.dir value.
    [<CustomOperation("Direction")>] member inline _.Direction ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<Microsoft.FluentUI.AspNetCore.Components.LocalizationDirection>) = render ==> ("Direction" => x)
    /// Callback raised when the Dark/Light luminance changes.
    [<CustomOperation("OnLuminanceChanged")>] member inline _.OnLuminanceChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.FluentUI.AspNetCore.Components.LuminanceChangedEventArgs -> unit) = render ==> html.callback("OnLuminanceChanged", fn)
    /// Callback raised when the Dark/Light luminance changes.
    [<CustomOperation("OnLuminanceChanged")>] member inline _.OnLuminanceChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.FluentUI.AspNetCore.Components.LuminanceChangedEventArgs -> Task<unit>) = render ==> html.callbackTask("OnLuminanceChanged", fn)
    /// Callback raised when the component is rendered for the first time.
    [<CustomOperation("OnLoaded")>] member inline _.OnLoaded ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.FluentUI.AspNetCore.Components.LoadedEventArgs -> unit) = render ==> html.callback("OnLoaded", fn)
    /// Callback raised when the component is rendered for the first time.
    [<CustomOperation("OnLoaded")>] member inline _.OnLoaded ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.FluentUI.AspNetCore.Components.LoadedEventArgs -> Task<unit>) = render ==> html.callbackTask("OnLoaded", fn)

type FluentSplashScreenBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAttrBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Content")>] member inline _.Content ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.FluentUI.AspNetCore.Components.SplashScreenContent) = render ==> ("Content" => x)

type MessageBoxBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAttrBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Content")>] member inline _.Content ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.FluentUI.AspNetCore.Components.MessageBoxContent) = render ==> ("Content" => x)

type FluentDialogProviderBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAttrBuilder<'FunBlazorGeneric>()


/// Extends the OnKeyDown blazor event to provide a more fluent way to evaluate the key code.
/// The anchor must refer to the ID of an element (or sub-element) accepting the focus.
type FluentKeyCodeBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAndChildAttrBuilder<'FunBlazorGeneric>()
    /// Gets or sets whether the KeyCode engine is global (using document DOM element) or not (only for Anchor or ChildContent).
    [<CustomOperation("GlobalDocument")>] member inline _.GlobalDocument ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("GlobalDocument" =>>> true)
    /// Gets or sets whether the KeyCode engine is global (using document DOM element) or not (only for Anchor or ChildContent).
    [<CustomOperation("GlobalDocument")>] member inline _.GlobalDocument ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("GlobalDocument" =>>> x)
    /// Gets or sets the control identifier associated with the KeyCode engine.
    /// If not set, the KeyCode will be applied to the FluentKeyCode content: see ChildContent.
    /// This attribute is ignored when the ChildContent is used..
    [<CustomOperation("Anchor")>] member inline _.Anchor ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Anchor" => x)
    /// Event triggered when a KeyDown event is raised.
    [<CustomOperation("OnKeyDown")>] member inline _.OnKeyDown ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.FluentUI.AspNetCore.Components.FluentKeyCodeEventArgs -> unit) = render ==> html.callback("OnKeyDown", fn)
    /// Event triggered when a KeyDown event is raised.
    [<CustomOperation("OnKeyDown")>] member inline _.OnKeyDown ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.FluentUI.AspNetCore.Components.FluentKeyCodeEventArgs -> Task<unit>) = render ==> html.callbackTask("OnKeyDown", fn)
    /// Event triggered when a KeyUp event is raised.
    [<CustomOperation("OnKeyUp")>] member inline _.OnKeyUp ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.FluentUI.AspNetCore.Components.FluentKeyCodeEventArgs -> unit) = render ==> html.callback("OnKeyUp", fn)
    /// Event triggered when a KeyUp event is raised.
    [<CustomOperation("OnKeyUp")>] member inline _.OnKeyUp ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.FluentUI.AspNetCore.Components.FluentKeyCodeEventArgs -> Task<unit>) = render ==> html.callbackTask("OnKeyUp", fn)
    /// Ignore modifier keys (Shift, Alt, Ctrl, Meta) when evaluating the key code.
    [<CustomOperation("IgnoreModifier")>] member inline _.IgnoreModifier ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("IgnoreModifier" =>>> true)
    /// Ignore modifier keys (Shift, Alt, Ctrl, Meta) when evaluating the key code.
    [<CustomOperation("IgnoreModifier")>] member inline _.IgnoreModifier ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("IgnoreModifier" =>>> x)
    /// Gets or sets the list of KeyCode to accept, and only this list, when evaluating the key code.
    [<CustomOperation("Only")>] member inline _.Only ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.FluentUI.AspNetCore.Components.KeyCode[]) = render ==> ("Only" => x)
    /// Gets or sets the list of KeyCode to ignore when evaluating the key code.
    [<CustomOperation("Ignore")>] member inline _.Ignore ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.FluentUI.AspNetCore.Components.KeyCode[]) = render ==> ("Ignore" => x)
    /// Gets or sets a way to prevent further propagation of the current event in the capturing and bubbling phases.
    [<CustomOperation("StopPropagation")>] member inline _.StopPropagation ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("StopPropagation" =>>> true)
    /// Gets or sets a way to prevent further propagation of the current event in the capturing and bubbling phases.
    [<CustomOperation("StopPropagation")>] member inline _.StopPropagation ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("StopPropagation" =>>> x)
    /// Gets or sets a way to tells the user agent that if the event does not get explicitly handled, its default action should not be taken as it normally would be.
    [<CustomOperation("PreventDefault")>] member inline _.PreventDefault ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("PreventDefault" =>>> true)
    /// Gets or sets a way to tells the user agent that if the event does not get explicitly handled, its default action should not be taken as it normally would be.
    [<CustomOperation("PreventDefault")>] member inline _.PreventDefault ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("PreventDefault" =>>> x)
    /// Gets or sets the list of KeyCode to tells the user agent that if the event does not get explicitly handled,
    /// its default action should not be taken as it normally would be.
    [<CustomOperation("PreventDefaultOnly")>] member inline _.PreventDefaultOnly ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.FluentUI.AspNetCore.Components.KeyCode[]) = render ==> ("PreventDefaultOnly" => x)
    /// Gets or sets whether the key pressed can be repeated.
    [<CustomOperation("StopRepeat")>] member inline _.StopRepeat ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("StopRepeat" =>>> true)
    /// Gets or sets whether the key pressed can be repeated.
    [<CustomOperation("StopRepeat")>] member inline _.StopRepeat ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("StopRepeat" =>>> x)
    /// Gets or sets a collection of additional attributes that will be applied to the created element.
    [<CustomOperation("AdditionalAttributes")>] member inline _.AdditionalAttributes ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.IReadOnlyDictionary<System.String, System.Object>) = render ==> ("AdditionalAttributes" => x)

type FluentKeyCodeProviderBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAttrBuilder<'FunBlazorGeneric>()
    /// Gets or sets a way to tells the user agent that if the event does not get explicitly handled, its default action should not be taken as it normally would be.
    [<CustomOperation("PreventDefault")>] member inline _.PreventDefault ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("PreventDefault" =>>> true)
    /// Gets or sets a way to tells the user agent that if the event does not get explicitly handled, its default action should not be taken as it normally would be.
    [<CustomOperation("PreventDefault")>] member inline _.PreventDefault ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("PreventDefault" =>>> x)

type FluentInputLabelBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAndChildAttrBuilder<'FunBlazorGeneric>()
    /// Gets or sets the HTML label `for` attribute.
    /// See https://developer.mozilla.org/en-US/docs/Web/HTML/Attributes/for
    [<CustomOperation("ForId")>] member inline _.ForId ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("ForId" => x)
    /// Gets or sets the text to label the input.
    /// This is usually displayd just above the component.
    [<CustomOperation("Label")>] member inline _.Label ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Label" => x)
    /// Gets or sets if an indicator is showed that this input is required.
    [<CustomOperation("Required")>] member inline _.Required ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Required" =>>> true)
    /// Gets or sets if an indicator is showed that this input is required.
    [<CustomOperation("Required")>] member inline _.Required ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Required" =>>> x)
    /// Gets or sets the text to be used as the `aria-label` attribute of the input.
    /// If not set, the Label will be used.
    [<CustomOperation("AriaLabel")>] member inline _.AriaLabel ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("AriaLabel" => x)
    /// Gets or sets the orientation of the label with respect to the input.
    /// horizontal: label is displayed to the left of the input.
    /// vertical: label is displayed above the input.
    [<CustomOperation("Orientation")>] member inline _.Orientation ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.FluentUI.AspNetCore.Components.Orientation) = render ==> ("Orientation" => x)
    /// Gets or sets a collection of additional attributes that will be applied to the created element.
    [<CustomOperation("AdditionalAttributes")>] member inline _.AdditionalAttributes ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.IReadOnlyDictionary<System.String, System.Object>) = render ==> ("AdditionalAttributes" => x)

type FluentOverlayBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAndChildAttrBuilder<'FunBlazorGeneric>()
    /// Gets or sets the unique identifier of the overlay.
    [<CustomOperation("Id")>] member inline _.Id ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Id" => x)
    /// Gets or sets a value indicating whether the overlay is visible.
    [<CustomOperation("Visible")>] member inline _.Visible ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Visible" =>>> true)
    /// Gets or sets a value indicating whether the overlay is visible.
    [<CustomOperation("Visible")>] member inline _.Visible ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Visible" =>>> x)
    /// Gets or sets a value indicating whether the overlay is visible.
    [<CustomOperation("Visible'")>] member inline _.Visible' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.Boolean * (System.Boolean -> unit)) = render ==> html.bind("Visible", valueFn)
    /// Callback for when overlay visibility changes.
    [<CustomOperation("VisibleChanged")>] member inline _.VisibleChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Boolean -> unit) = render ==> html.callback("VisibleChanged", fn)
    /// Callback for when overlay visibility changes.
    [<CustomOperation("VisibleChanged")>] member inline _.VisibleChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Boolean -> Task<unit>) = render ==> html.callbackTask("VisibleChanged", fn)
    /// Callback for when the overlay is closed.
    [<CustomOperation("OnClose")>] member inline _.OnClose ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.AspNetCore.Components.Web.MouseEventArgs -> unit) = render ==> html.callback("OnClose", fn)
    /// Callback for when the overlay is closed.
    [<CustomOperation("OnClose")>] member inline _.OnClose ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.AspNetCore.Components.Web.MouseEventArgs -> Task<unit>) = render ==> html.callbackTask("OnClose", fn)
    /// Gets or set if the overlay is transparent.
    [<CustomOperation("Transparent")>] member inline _.Transparent ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Transparent" =>>> true)
    /// Gets or set if the overlay is transparent.
    [<CustomOperation("Transparent")>] member inline _.Transparent ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Transparent" =>>> x)
    /// Gets or sets the opacity of the overlay.
    [<CustomOperation("Opacity")>] member inline _.Opacity ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Double>) = render ==> ("Opacity" => x)
    /// Gets or sets the alignment of the content to a Align value.
    /// Defaults to Align.Center.
    [<CustomOperation("Alignment")>] member inline _.Alignment ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.FluentUI.AspNetCore.Components.Align) = render ==> ("Alignment" => x)
    /// Gets or sets the justification of the content to a JustifyContent value.
    /// Defaults to JustifyContent.Center.
    [<CustomOperation("Justification")>] member inline _.Justification ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.FluentUI.AspNetCore.Components.JustifyContent) = render ==> ("Justification" => x)
    /// Gets or sets a value indicating whether the overlay is shown full screen or bound to the containing element.
    [<CustomOperation("FullScreen")>] member inline _.FullScreen ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("FullScreen" =>>> true)
    /// Gets or sets a value indicating whether the overlay is shown full screen or bound to the containing element.
    [<CustomOperation("FullScreen")>] member inline _.FullScreen ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("FullScreen" =>>> x)
    /// Gets or sets a value indicating whether the overlay is interactive, except for the element with the specified InteractiveExceptId.
    /// In other words, the elements below the overlay remain usable (mouse-over, click) and the overlay will closed when clicked.
    [<CustomOperation("Interactive")>] member inline _.Interactive ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Interactive" =>>> true)
    /// Gets or sets a value indicating whether the overlay is interactive, except for the element with the specified InteractiveExceptId.
    /// In other words, the elements below the overlay remain usable (mouse-over, click) and the overlay will closed when clicked.
    [<CustomOperation("Interactive")>] member inline _.Interactive ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Interactive" =>>> x)
    /// Gets or sets the HTML identifier of the element that is not interactive when the overlay is shown.
    /// This property is ignored if Interactive is false.
    [<CustomOperation("InteractiveExceptId")>] member inline _.InteractiveExceptId ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("InteractiveExceptId" => x)
    /// Gets of sets a value indicating if the overlay can be dismissed by clicking on it.
    /// Default is true.
    [<CustomOperation("Dismissable")>] member inline _.Dismissable ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Dismissable" =>>> true)
    /// Gets of sets a value indicating if the overlay can be dismissed by clicking on it.
    /// Default is true.
    [<CustomOperation("Dismissable")>] member inline _.Dismissable ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Dismissable" =>>> x)
    /// Gets or sets the background color. 
    /// Needs to be formatted as an HTML hex color string (#rrggbb or #rgb).
    /// Default is '#ffffff'.
    [<CustomOperation("BackgroundColor")>] member inline _.BackgroundColor ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("BackgroundColor" => x)
    [<CustomOperation("PreventScroll")>] member inline _.PreventScroll ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("PreventScroll" =>>> true)
    [<CustomOperation("PreventScroll")>] member inline _.PreventScroll ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("PreventScroll" =>>> x)

type FluentSpacerBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAttrBuilder<'FunBlazorGeneric>()
    /// Gets or sets the width of the spacer (in pixels).
    [<CustomOperation("Width")>] member inline _.Width ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Int32>) = render ==> ("Width" => x)

type CommunicationToastBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAttrBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Content")>] member inline _.Content ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.FluentUI.AspNetCore.Components.CommunicationToastContent) = render ==> ("Content" => x)

type ProgressToastBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAttrBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Content")>] member inline _.Content ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.FluentUI.AspNetCore.Components.ProgressToastContent) = render ==> ("Content" => x)

type FluentToastProviderBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAttrBuilder<'FunBlazorGeneric>()
    /// Gets or sets the position on screen where the toasts are shown. See ToastPosition
    /// Default is ToastPosition.TopRight
    [<CustomOperation("Position")>] member inline _.Position ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.FluentUI.AspNetCore.Components.ToastPosition) = render ==> ("Position" => x)
    /// Gets or sets the number of milliseconds a toast remains visible. Default is 7000 (7 seconds).
    [<CustomOperation("Timeout")>] member inline _.Timeout ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("Timeout" => x)
    /// Gets or sets the maximum number of toasts that can be shown at once. Default is 4.
    [<CustomOperation("MaxToastCount")>] member inline _.MaxToastCount ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("MaxToastCount" => x)
    /// Gets or sets whether to remove toasts when the user navigates to a new page. Default is true.
    [<CustomOperation("RemoveToastsOnNavigation")>] member inline _.RemoveToastsOnNavigation ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("RemoveToastsOnNavigation" =>>> true)
    /// Gets or sets whether to remove toasts when the user navigates to a new page. Default is true.
    [<CustomOperation("RemoveToastsOnNavigation")>] member inline _.RemoveToastsOnNavigation ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("RemoveToastsOnNavigation" =>>> x)
    /// Gets or sets whether to show a close button on a toast. Default is true.
    /// [Obsolete("This parameter will be removed in a future version. It is and should not not used.")]
    [<CustomOperation("ShowCloseButton")>] member inline _.ShowCloseButton ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("ShowCloseButton" =>>> true)
    /// Gets or sets whether to show a close button on a toast. Default is true.
    /// [Obsolete("This parameter will be removed in a future version. It is and should not not used.")]
    [<CustomOperation("ShowCloseButton")>] member inline _.ShowCloseButton ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("ShowCloseButton" =>>> x)

type RenderFragmentDialogBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAttrBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Content")>] member inline _.Content ([<InlineIfLambda>] render: AttrRenderFragment, fragment: NodeRenderFragment) = render ==> html.renderFragment("Content", fragment)
    [<CustomOperation("Content")>] member inline _.Content ([<InlineIfLambda>] render: AttrRenderFragment, fragments: NodeRenderFragment seq) = render ==> html.renderFragment("Content", fragment { yield! fragments })
    [<CustomOperation("Content")>] member inline _.Content ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("Content", html.text x)
    [<CustomOperation("Content")>] member inline _.Content ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("Content", html.text x)
    [<CustomOperation("Content")>] member inline _.Content ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("Content", html.text x)

type FluentPageScriptBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAttrBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Src")>] member inline _.Src ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Src" => x)

type ConfirmationToastBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAttrBuilder<'FunBlazorGeneric>()


            
namespace rec Microsoft.FluentUI.AspNetCore.Components.DslInternals.DesignTokens

open System.Threading.Tasks
open FSharp.Data.Adaptive
open Fun.Blazor
open Fun.Blazor.Operators
open Microsoft.FluentUI.AspNetCore.Components.DslInternals

type DesignTokenBuilder<'FunBlazorGeneric, 'T when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAttrBuilder<'FunBlazorGeneric>()
    /// Gets or sets the value of the design token
    [<CustomOperation("Value")>] member inline _.Value ([<InlineIfLambda>] render: AttrRenderFragment, x: 'T) = render ==> ("Value" => x)
    /// Gets or sets the content to apply this design token on
    [<CustomOperation("ChildContent")>] member inline _.ChildContent ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.FluentUI.AspNetCore.Components.DesignTokens.Reference -> NodeRenderFragment) = render ==> html.renderFragment("ChildContent", fn)

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
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, Microsoft.FluentUI.AspNetCore.Components.DesignTokens.Swatch>()


/// The AccentBaseColor design token
type AccentBaseColorBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, Microsoft.FluentUI.AspNetCore.Components.DesignTokens.Swatch>()


/// The NeutralLayerCardContainer design token
type NeutralLayerCardContainerBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, Microsoft.FluentUI.AspNetCore.Components.DesignTokens.Swatch>()


/// The NeutralLayerFloating design token
type NeutralLayerFloatingBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, Microsoft.FluentUI.AspNetCore.Components.DesignTokens.Swatch>()


/// The NeutralLayer1 design token
type NeutralLayer1Builder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, System.String>()


/// The NeutralLayer2 design token
type NeutralLayer2Builder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, System.String>()


/// The NeutralLayer3 design token
type NeutralLayer3Builder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, System.String>()


/// The NeutralLayer4 design token
type NeutralLayer4Builder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, System.String>()


/// The FillColor design token
type FillColorBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, System.String>()


/// The AccentFillRest design token
type AccentFillRestBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, Microsoft.FluentUI.AspNetCore.Components.DesignTokens.Swatch>()


/// The AccentFillHover design token
type AccentFillHoverBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, Microsoft.FluentUI.AspNetCore.Components.DesignTokens.Swatch>()


/// The AccentFillActive design token
type AccentFillActiveBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, Microsoft.FluentUI.AspNetCore.Components.DesignTokens.Swatch>()


/// The AccentFillFocus design token
type AccentFillFocusBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, Microsoft.FluentUI.AspNetCore.Components.DesignTokens.Swatch>()


/// The ForegroundOnAccentRest design token
type ForegroundOnAccentRestBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, Microsoft.FluentUI.AspNetCore.Components.DesignTokens.Swatch>()


/// The ForegroundOnAccentHover design token
type ForegroundOnAccentHoverBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, Microsoft.FluentUI.AspNetCore.Components.DesignTokens.Swatch>()


/// The ForegroundOnAccentActive design token
type ForegroundOnAccentActiveBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, Microsoft.FluentUI.AspNetCore.Components.DesignTokens.Swatch>()


/// The ForegroundOnAccentFocus design token
type ForegroundOnAccentFocusBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, Microsoft.FluentUI.AspNetCore.Components.DesignTokens.Swatch>()


/// The AccentForegroundRest design token
type AccentForegroundRestBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, Microsoft.FluentUI.AspNetCore.Components.DesignTokens.Swatch>()


/// The AccentForegroundHover design token
type AccentForegroundHoverBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, Microsoft.FluentUI.AspNetCore.Components.DesignTokens.Swatch>()


/// The AccentForegroundActive design token
type AccentForegroundActiveBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, Microsoft.FluentUI.AspNetCore.Components.DesignTokens.Swatch>()


/// The AccentForegroundFocus design token
type AccentForegroundFocusBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, Microsoft.FluentUI.AspNetCore.Components.DesignTokens.Swatch>()


/// The AccentStrokeControlRest design token
type AccentStrokeControlRestBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, Microsoft.FluentUI.AspNetCore.Components.DesignTokens.Swatch>()


/// The AccentStrokeControlHover design token
type AccentStrokeControlHoverBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, Microsoft.FluentUI.AspNetCore.Components.DesignTokens.Swatch>()


/// The AccentStrokeControlActive design token
type AccentStrokeControlActiveBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, Microsoft.FluentUI.AspNetCore.Components.DesignTokens.Swatch>()


/// The AccentStrokeControlFocus design token
type AccentStrokeControlFocusBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, Microsoft.FluentUI.AspNetCore.Components.DesignTokens.Swatch>()


/// The NeutralFillRest design token
type NeutralFillRestBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, Microsoft.FluentUI.AspNetCore.Components.DesignTokens.Swatch>()


/// The NeutralFillHover design token
type NeutralFillHoverBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, Microsoft.FluentUI.AspNetCore.Components.DesignTokens.Swatch>()


/// The NeutralFillActive design token
type NeutralFillActiveBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, Microsoft.FluentUI.AspNetCore.Components.DesignTokens.Swatch>()


/// The NeutralFillFocus design token
type NeutralFillFocusBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, Microsoft.FluentUI.AspNetCore.Components.DesignTokens.Swatch>()


/// The NeutralFillInputRest design token
type NeutralFillInputRestBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, Microsoft.FluentUI.AspNetCore.Components.DesignTokens.Swatch>()


/// The NeutralFillInputHover design token
type NeutralFillInputHoverBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, Microsoft.FluentUI.AspNetCore.Components.DesignTokens.Swatch>()


/// The NeutralFillInputActive design token
type NeutralFillInputActiveBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, Microsoft.FluentUI.AspNetCore.Components.DesignTokens.Swatch>()


/// The NeutralFillInputFocus design token
type NeutralFillInputFocusBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, Microsoft.FluentUI.AspNetCore.Components.DesignTokens.Swatch>()


/// The NeutralFillInputAltRest design token
type NeutralFillInputAltRestBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, Microsoft.FluentUI.AspNetCore.Components.DesignTokens.Swatch>()


/// The NeutralFillInputAltHover design token
type NeutralFillInputAltHoverBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, Microsoft.FluentUI.AspNetCore.Components.DesignTokens.Swatch>()


/// The NeutralFillInputAltActive design token
type NeutralFillInputAltActiveBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, Microsoft.FluentUI.AspNetCore.Components.DesignTokens.Swatch>()


/// The NeutralFillInputAltFocus design token
type NeutralFillInputAltFocusBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, Microsoft.FluentUI.AspNetCore.Components.DesignTokens.Swatch>()


/// The NeutralFillLayerRest design token
type NeutralFillLayerRestBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, Microsoft.FluentUI.AspNetCore.Components.DesignTokens.Swatch>()


/// The NeutralFillLayerHover design token
type NeutralFillLayerHoverBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, Microsoft.FluentUI.AspNetCore.Components.DesignTokens.Swatch>()


/// The NeutralFillLayerActive design token
type NeutralFillLayerActiveBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, Microsoft.FluentUI.AspNetCore.Components.DesignTokens.Swatch>()


/// The NeutralFillLayerAltRest design token
type NeutralFillLayerAltRestBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, Microsoft.FluentUI.AspNetCore.Components.DesignTokens.Swatch>()


/// The NeutralFillSecondaryRest design token
type NeutralFillSecondaryRestBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, Microsoft.FluentUI.AspNetCore.Components.DesignTokens.Swatch>()


/// The NeutralFillSecondaryHover design token
type NeutralFillSecondaryHoverBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, Microsoft.FluentUI.AspNetCore.Components.DesignTokens.Swatch>()


/// The NeutralFillSecondaryActive design token
type NeutralFillSecondaryActiveBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, Microsoft.FluentUI.AspNetCore.Components.DesignTokens.Swatch>()


/// The NeutralFillSecondaryFocus design token
type NeutralFillSecondaryFocusBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, Microsoft.FluentUI.AspNetCore.Components.DesignTokens.Swatch>()


/// The NeutralFillStealthRest design token
type NeutralFillStealthRestBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, Microsoft.FluentUI.AspNetCore.Components.DesignTokens.Swatch>()


/// The NeutralFillStealthHover design token
type NeutralFillStealthHoverBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, Microsoft.FluentUI.AspNetCore.Components.DesignTokens.Swatch>()


/// The NeutralFillStealthActive design token
type NeutralFillStealthActiveBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, Microsoft.FluentUI.AspNetCore.Components.DesignTokens.Swatch>()


/// The NeutralFillStealthFocus design token
type NeutralFillStealthFocusBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, Microsoft.FluentUI.AspNetCore.Components.DesignTokens.Swatch>()


/// The NeutralFillStrongRest design token
type NeutralFillStrongRestBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, Microsoft.FluentUI.AspNetCore.Components.DesignTokens.Swatch>()


/// The NeutralFillStrongHover design token
type NeutralFillStrongHoverBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, Microsoft.FluentUI.AspNetCore.Components.DesignTokens.Swatch>()


/// The NeutralFillStrongActive design token
type NeutralFillStrongActiveBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, Microsoft.FluentUI.AspNetCore.Components.DesignTokens.Swatch>()


/// The NeutralFillStrongFocus design token
type NeutralFillStrongFocusBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, Microsoft.FluentUI.AspNetCore.Components.DesignTokens.Swatch>()


/// The NeutralForegroundRest design token
type NeutralForegroundRestBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, Microsoft.FluentUI.AspNetCore.Components.DesignTokens.Swatch>()


/// The NeutralForegroundHover design token
type NeutralForegroundHoverBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, Microsoft.FluentUI.AspNetCore.Components.DesignTokens.Swatch>()


/// The NeutralForegroundActive design token
type NeutralForegroundActiveBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, Microsoft.FluentUI.AspNetCore.Components.DesignTokens.Swatch>()


/// The NeutralForegroundFocus design token
type NeutralForegroundFocusBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, Microsoft.FluentUI.AspNetCore.Components.DesignTokens.Swatch>()


/// The NeutralForegroundHint design token
type NeutralForegroundHintBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, Microsoft.FluentUI.AspNetCore.Components.DesignTokens.Swatch>()


/// The NeutralStrokeRest design token
type NeutralStrokeRestBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, Microsoft.FluentUI.AspNetCore.Components.DesignTokens.Swatch>()


/// The NeutralStrokeHover design token
type NeutralStrokeHoverBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, Microsoft.FluentUI.AspNetCore.Components.DesignTokens.Swatch>()


/// The NeutralStrokeActive design token
type NeutralStrokeActiveBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, Microsoft.FluentUI.AspNetCore.Components.DesignTokens.Swatch>()


/// The NeutralStrokeFocus design token
type NeutralStrokeFocusBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, Microsoft.FluentUI.AspNetCore.Components.DesignTokens.Swatch>()


/// The NeutralStrokeControlRest design token
type NeutralStrokeControlRestBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, Microsoft.FluentUI.AspNetCore.Components.DesignTokens.Swatch>()


/// The NeutralStrokeControlHover design token
type NeutralStrokeControlHoverBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, Microsoft.FluentUI.AspNetCore.Components.DesignTokens.Swatch>()


/// The NeutralStrokeControlActive design token
type NeutralStrokeControlActiveBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, Microsoft.FluentUI.AspNetCore.Components.DesignTokens.Swatch>()


/// The NeutralStrokeControlFocus design token
type NeutralStrokeControlFocusBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, Microsoft.FluentUI.AspNetCore.Components.DesignTokens.Swatch>()


/// The NeutralStrokeDividerRest design token
type NeutralStrokeDividerRestBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, Microsoft.FluentUI.AspNetCore.Components.DesignTokens.Swatch>()


/// The NeutralStrokeInputRest design token
type NeutralStrokeInputRestBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, Microsoft.FluentUI.AspNetCore.Components.DesignTokens.Swatch>()


/// The NeutralStrokeInputHover design token
type NeutralStrokeInputHoverBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, Microsoft.FluentUI.AspNetCore.Components.DesignTokens.Swatch>()


/// The NeutralStrokeInputActive design token
type NeutralStrokeInputActiveBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, Microsoft.FluentUI.AspNetCore.Components.DesignTokens.Swatch>()


/// The NeutralStrokeInputFocus design token
type NeutralStrokeInputFocusBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, Microsoft.FluentUI.AspNetCore.Components.DesignTokens.Swatch>()


/// The NeutralStrokeLayerRest design token
type NeutralStrokeLayerRestBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, Microsoft.FluentUI.AspNetCore.Components.DesignTokens.Swatch>()


/// The NeutralStrokeLayerHover design token
type NeutralStrokeLayerHoverBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, Microsoft.FluentUI.AspNetCore.Components.DesignTokens.Swatch>()


/// The NeutralStrokeLayerActive design token
type NeutralStrokeLayerActiveBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, Microsoft.FluentUI.AspNetCore.Components.DesignTokens.Swatch>()


/// The NeutralStrokeStrongRest design token
type NeutralStrokeStrongRestBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, Microsoft.FluentUI.AspNetCore.Components.DesignTokens.Swatch>()


/// The NeutralStrokeStrongHover design token
type NeutralStrokeStrongHoverBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, Microsoft.FluentUI.AspNetCore.Components.DesignTokens.Swatch>()


/// The NeutralStrokeStrongActive design token
type NeutralStrokeStrongActiveBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, Microsoft.FluentUI.AspNetCore.Components.DesignTokens.Swatch>()


/// The NeutralStrokeStrongFocus design token
type NeutralStrokeStrongFocusBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, Microsoft.FluentUI.AspNetCore.Components.DesignTokens.Swatch>()


/// The FocusStrokeOuter design token
type FocusStrokeOuterBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, Microsoft.FluentUI.AspNetCore.Components.DesignTokens.Swatch>()


/// The FocusStrokeInner design token
type FocusStrokeInnerBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DesignTokens.DesignTokenBuilder<'FunBlazorGeneric, Microsoft.FluentUI.AspNetCore.Components.DesignTokens.Swatch>()


            
namespace rec Microsoft.FluentUI.AspNetCore.Components.DslInternals.DataGrid.Infrastructure

open System.Threading.Tasks
open FSharp.Data.Adaptive
open Fun.Blazor
open Fun.Blazor.Operators
open Microsoft.FluentUI.AspNetCore.Components.DslInternals

/// For internal use only. Do not use.
type DeferBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAndChildAttrBuilder<'FunBlazorGeneric>()


            

// =======================================================================================================================

namespace Microsoft.FluentUI.AspNetCore.Components

[<AutoOpen>]
module DslCE =
  
    open System.Diagnostics.CodeAnalysis
    open Microsoft.FluentUI.AspNetCore.Components.DslInternals

    type FluentComponentBase' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.FluentComponentBase>)>] () = inherit FluentComponentBaseBuilder<Microsoft.FluentUI.AspNetCore.Components.FluentComponentBase>()

    /// Base class for FluentNavMenuGroup and FluentNavMenuItemBase.
    type FluentNavMenuItemBase' 
        /// Base class for FluentNavMenuGroup and FluentNavMenuItemBase.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.FluentNavMenuItemBase>)>] () = inherit FluentNavMenuItemBaseBuilder<Microsoft.FluentUI.AspNetCore.Components.FluentNavMenuItemBase>()
    type FluentNavMenuGroup' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.FluentNavMenuGroup>)>] () = inherit FluentNavMenuGroupBuilder<Microsoft.FluentUI.AspNetCore.Components.FluentNavMenuGroup>()
    type FluentNavMenuLink' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.FluentNavMenuLink>)>] () = inherit FluentNavMenuLinkBuilder<Microsoft.FluentUI.AspNetCore.Components.FluentNavMenuLink>()

    /// Base class for FluentNavGroup and FluentNavLink.
    type FluentNavBase' 
        /// Base class for FluentNavGroup and FluentNavLink.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.FluentNavBase>)>] () = inherit FluentNavBaseBuilder<Microsoft.FluentUI.AspNetCore.Components.FluentNavBase>()
    type FluentNavGroup' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.FluentNavGroup>)>] () = inherit FluentNavGroupBuilder<Microsoft.FluentUI.AspNetCore.Components.FluentNavGroup>()
    type FluentNavLink' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.FluentNavLink>)>] () = inherit FluentNavLinkBuilder<Microsoft.FluentUI.AspNetCore.Components.FluentNavLink>()
    type FluentAccordion' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.FluentAccordion>)>] () = inherit FluentAccordionBuilder<Microsoft.FluentUI.AspNetCore.Components.FluentAccordion>()
    type FluentAccordionItem' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.FluentAccordionItem>)>] () = inherit FluentAccordionItemBuilder<Microsoft.FluentUI.AspNetCore.Components.FluentAccordionItem>()
    type FluentAnchoredRegion' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.FluentAnchoredRegion>)>] () = inherit FluentAnchoredRegionBuilder<Microsoft.FluentUI.AspNetCore.Components.FluentAnchoredRegion>()
    type FluentAnchor' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.FluentAnchor>)>] () = inherit FluentAnchorBuilder<Microsoft.FluentUI.AspNetCore.Components.FluentAnchor>()
    type FluentAppBar' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.FluentAppBar>)>] () = inherit FluentAppBarBuilder<Microsoft.FluentUI.AspNetCore.Components.FluentAppBar>()
    type FluentAppBarItem' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.FluentAppBarItem>)>] () = inherit FluentAppBarItemBuilder<Microsoft.FluentUI.AspNetCore.Components.FluentAppBarItem>()
    type FluentBadge' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.FluentBadge>)>] () = inherit FluentBadgeBuilder<Microsoft.FluentUI.AspNetCore.Components.FluentBadge>()

    /// A base class for fluent ui form input components. This base class automatically
    /// integrates with an EditContext, which must be supplied
    /// as a cascading parameter.
    type FluentInputBase'<'TValue> 
        /// A base class for fluent ui form input components. This base class automatically
        /// integrates with an EditContext, which must be supplied
        /// as a cascading parameter.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.FluentInputBase<_>>)>] () = inherit FluentInputBaseBuilder<Microsoft.FluentUI.AspNetCore.Components.FluentInputBase<'TValue>, 'TValue>()
    type FluentCalendarBase' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.FluentCalendarBase>)>] () = inherit FluentCalendarBaseBuilder<Microsoft.FluentUI.AspNetCore.Components.FluentCalendarBase>()

    /// Fluent Calendar based on
    /// https://github.com/microsoft/fluentui/blob/master/packages/web-components/src/calendar/.
    type FluentCalendar' 
        /// Fluent Calendar based on
        /// https://github.com/microsoft/fluentui/blob/master/packages/web-components/src/calendar/.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.FluentCalendar>)>] () = inherit FluentCalendarBuilder<Microsoft.FluentUI.AspNetCore.Components.FluentCalendar>()
    type FluentDatePicker' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.FluentDatePicker>)>] () = inherit FluentDatePickerBuilder<Microsoft.FluentUI.AspNetCore.Components.FluentDatePicker>()
    type FluentCheckbox' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.FluentCheckbox>)>] () = inherit FluentCheckboxBuilder<Microsoft.FluentUI.AspNetCore.Components.FluentCheckbox>()
    type FluentTimePicker' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.FluentTimePicker>)>] () = inherit FluentTimePickerBuilder<Microsoft.FluentUI.AspNetCore.Components.FluentTimePicker>()

    /// Component that provides a list of options.
    type ListComponentBase'<'TOption> 
        /// Component that provides a list of options.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.ListComponentBase<_>>)>] () = inherit ListComponentBaseBuilder<Microsoft.FluentUI.AspNetCore.Components.ListComponentBase<'TOption>, 'TOption>()
    type FluentAutocomplete'<'TOption> [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.FluentAutocomplete<_>>)>] () = inherit FluentAutocompleteBuilder<Microsoft.FluentUI.AspNetCore.Components.FluentAutocomplete<'TOption>, 'TOption>()
    type FluentCombobox'<'TOption> [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.FluentCombobox<_>>)>] () = inherit FluentComboboxBuilder<Microsoft.FluentUI.AspNetCore.Components.FluentCombobox<'TOption>, 'TOption>()
    type FluentListbox'<'TOption> [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.FluentListbox<_>>)>] () = inherit FluentListboxBuilder<Microsoft.FluentUI.AspNetCore.Components.FluentListbox<'TOption>, 'TOption>()
    type FluentSelect'<'TOption> [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.FluentSelect<_>>)>] () = inherit FluentSelectBuilder<Microsoft.FluentUI.AspNetCore.Components.FluentSelect<'TOption>, 'TOption>()
    type FluentNumberField'<'TValue when 'TValue : (new : unit -> 'TValue)> [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.FluentNumberField<_>>)>] () = inherit FluentNumberFieldBuilder<Microsoft.FluentUI.AspNetCore.Components.FluentNumberField<'TValue>, 'TValue>()

    /// Groups child FluentRadio`1 components.
    type FluentRadioGroup'<'TValue> 
        /// Groups child FluentRadio`1 components.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.FluentRadioGroup<_>>)>] () = inherit FluentRadioGroupBuilder<Microsoft.FluentUI.AspNetCore.Components.FluentRadioGroup<'TValue>, 'TValue>()
    type FluentRating' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.FluentRating>)>] () = inherit FluentRatingBuilder<Microsoft.FluentUI.AspNetCore.Components.FluentRating>()
    type FluentSearch' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.FluentSearch>)>] () = inherit FluentSearchBuilder<Microsoft.FluentUI.AspNetCore.Components.FluentSearch>()
    type FluentSliderInt' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.FluentSlider<int>>)>] () = inherit FluentSliderBuilder<Microsoft.FluentUI.AspNetCore.Components.FluentSlider<int>, int>()
    type FluentSliderFloat' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.FluentSlider<float>>)>] () = inherit FluentSliderBuilder<Microsoft.FluentUI.AspNetCore.Components.FluentSlider<float>, float>()
    type FluentSwitch' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.FluentSwitch>)>] () = inherit FluentSwitchBuilder<Microsoft.FluentUI.AspNetCore.Components.FluentSwitch>()
    type FluentTextArea' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.FluentTextArea>)>] () = inherit FluentTextAreaBuilder<Microsoft.FluentUI.AspNetCore.Components.FluentTextArea>()
    type FluentTextField' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.FluentTextField>)>] () = inherit FluentTextFieldBuilder<Microsoft.FluentUI.AspNetCore.Components.FluentTextField>()
    type FluentBodyContent' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.FluentBodyContent>)>] () = inherit FluentBodyContentBuilder<Microsoft.FluentUI.AspNetCore.Components.FluentBodyContent>()
    type FluentBreadcrumb' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.FluentBreadcrumb>)>] () = inherit FluentBreadcrumbBuilder<Microsoft.FluentUI.AspNetCore.Components.FluentBreadcrumb>()
    type FluentBreadcrumbItem' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.FluentBreadcrumbItem>)>] () = inherit FluentBreadcrumbItemBuilder<Microsoft.FluentUI.AspNetCore.Components.FluentBreadcrumbItem>()
    type FluentButton' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.FluentButton>)>] () = inherit FluentButtonBuilder<Microsoft.FluentUI.AspNetCore.Components.FluentButton>()
    type FluentCard' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.FluentCard>)>] () = inherit FluentCardBuilder<Microsoft.FluentUI.AspNetCore.Components.FluentCard>()
    type FluentCollapsibleRegion' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.FluentCollapsibleRegion>)>] () = inherit FluentCollapsibleRegionBuilder<Microsoft.FluentUI.AspNetCore.Components.FluentCollapsibleRegion>()
    type FluentCounterBadge' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.FluentCounterBadge>)>] () = inherit FluentCounterBadgeBuilder<Microsoft.FluentUI.AspNetCore.Components.FluentCounterBadge>()

    /// A component that displays a grid.
    type FluentDataGrid'<'TGridItem> 
        /// A component that displays a grid.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.FluentDataGrid<_>>)>] () = inherit FluentDataGridBuilder<Microsoft.FluentUI.AspNetCore.Components.FluentDataGrid<'TGridItem>, 'TGridItem>()
    type FluentDataGridCell'<'TGridItem> [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.FluentDataGridCell<_>>)>] () = inherit FluentDataGridCellBuilder<Microsoft.FluentUI.AspNetCore.Components.FluentDataGridCell<'TGridItem>, 'TGridItem>()
    type FluentDataGridRow'<'TGridItem> [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.FluentDataGridRow<_>>)>] () = inherit FluentDataGridRowBuilder<Microsoft.FluentUI.AspNetCore.Components.FluentDataGridRow<'TGridItem>, 'TGridItem>()
    type FluentDesignSystemProvider' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.FluentDesignSystemProvider>)>] () = inherit FluentDesignSystemProviderBuilder<Microsoft.FluentUI.AspNetCore.Components.FluentDesignSystemProvider>()
    type FluentDialog' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.FluentDialog>)>] () = inherit FluentDialogBuilder<Microsoft.FluentUI.AspNetCore.Components.FluentDialog>()
    type FluentDialogBody' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.FluentDialogBody>)>] () = inherit FluentDialogBodyBuilder<Microsoft.FluentUI.AspNetCore.Components.FluentDialogBody>()
    type FluentDialogFooter' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.FluentDialogFooter>)>] () = inherit FluentDialogFooterBuilder<Microsoft.FluentUI.AspNetCore.Components.FluentDialogFooter>()
    type FluentDialogHeader' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.FluentDialogHeader>)>] () = inherit FluentDialogHeaderBuilder<Microsoft.FluentUI.AspNetCore.Components.FluentDialogHeader>()
    type FluentDivider' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.FluentDivider>)>] () = inherit FluentDividerBuilder<Microsoft.FluentUI.AspNetCore.Components.FluentDivider>()
    type FluentDragContainer'<'TItem> [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.FluentDragContainer<_>>)>] () = inherit FluentDragContainerBuilder<Microsoft.FluentUI.AspNetCore.Components.FluentDragContainer<'TItem>, 'TItem>()
    type FluentDropZone'<'TItem> [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.FluentDropZone<_>>)>] () = inherit FluentDropZoneBuilder<Microsoft.FluentUI.AspNetCore.Components.FluentDropZone<'TItem>, 'TItem>()

    /// FluentEmoji is a component that renders an emoji from the Microsoft FluentUI emoji set.
    type FluentEmoji'<'Emoji when 'Emoji : (new : unit -> 'Emoji) and 'Emoji :> Microsoft.FluentUI.AspNetCore.Components.Emoji> 
        /// FluentEmoji is a component that renders an emoji from the Microsoft FluentUI emoji set.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.FluentEmoji<_>>)>] () = inherit FluentEmojiBuilder<Microsoft.FluentUI.AspNetCore.Components.FluentEmoji<'Emoji>, 'Emoji>()
    type FluentFlipper' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.FluentFlipper>)>] () = inherit FluentFlipperBuilder<Microsoft.FluentUI.AspNetCore.Components.FluentFlipper>()
    type FluentFooter' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.FluentFooter>)>] () = inherit FluentFooterBuilder<Microsoft.FluentUI.AspNetCore.Components.FluentFooter>()

    /// Displays a list of validation messages for a specified field within a cascaded EditContext.
    type FluentValidationMessage'<'TValue> 
        /// Displays a list of validation messages for a specified field within a cascaded EditContext.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.FluentValidationMessage<_>>)>] () = inherit FluentValidationMessageBuilder<Microsoft.FluentUI.AspNetCore.Components.FluentValidationMessage<'TValue>, 'TValue>()

    /// The grid component helps keeping layout consistent across various screen resolutions and sizes.
    /// PowerGrid comes with a 12-point grid system and contains 5 types of breakpoints
    /// that are used for specific screen sizes.
    type FluentGrid' 
        /// The grid component helps keeping layout consistent across various screen resolutions and sizes.
        /// PowerGrid comes with a 12-point grid system and contains 5 types of breakpoints
        /// that are used for specific screen sizes.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.FluentGrid>)>] () = inherit FluentGridBuilder<Microsoft.FluentUI.AspNetCore.Components.FluentGrid>()
    type FluentGridItem' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.FluentGridItem>)>] () = inherit FluentGridItemBuilder<Microsoft.FluentUI.AspNetCore.Components.FluentGridItem>()
    type FluentHeader' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.FluentHeader>)>] () = inherit FluentHeaderBuilder<Microsoft.FluentUI.AspNetCore.Components.FluentHeader>()
    type FluentHighlighter' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.FluentHighlighter>)>] () = inherit FluentHighlighterBuilder<Microsoft.FluentUI.AspNetCore.Components.FluentHighlighter>()
    type FluentHorizontalScroll' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.FluentHorizontalScroll>)>] () = inherit FluentHorizontalScrollBuilder<Microsoft.FluentUI.AspNetCore.Components.FluentHorizontalScroll>()

    /// FluentIcon is a component that renders an icon from the Fluent System icon set.
    type FluentIcon'<'Icon when 'Icon : (new : unit -> 'Icon) and 'Icon :> Microsoft.FluentUI.AspNetCore.Components.Icon> 
        /// FluentIcon is a component that renders an icon from the Fluent System icon set.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.FluentIcon<_>>)>] () = inherit FluentIconBuilder<Microsoft.FluentUI.AspNetCore.Components.FluentIcon<'Icon>, 'Icon>()
    type FluentInputFile' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.FluentInputFile>)>] () = inherit FluentInputFileBuilder<Microsoft.FluentUI.AspNetCore.Components.FluentInputFile>()
    type FluentLabel' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.FluentLabel>)>] () = inherit FluentLabelBuilder<Microsoft.FluentUI.AspNetCore.Components.FluentLabel>()
    type FluentLayout' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.FluentLayout>)>] () = inherit FluentLayoutBuilder<Microsoft.FluentUI.AspNetCore.Components.FluentLayout>()
    type FluentOption'<'TOption> [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.FluentOption<_>>)>] () = inherit FluentOptionBuilder<Microsoft.FluentUI.AspNetCore.Components.FluentOption<'TOption>, 'TOption>()

    /// People picker option component.
    type FluentPersona' 
        /// People picker option component.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.FluentPersona>)>] () = inherit FluentPersonaBuilder<Microsoft.FluentUI.AspNetCore.Components.FluentPersona>()
    type FluentMainLayout' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.FluentMainLayout>)>] () = inherit FluentMainLayoutBuilder<Microsoft.FluentUI.AspNetCore.Components.FluentMainLayout>()
    type FluentMain' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.FluentMain>)>] () = inherit FluentMainBuilder<Microsoft.FluentUI.AspNetCore.Components.FluentMain>()
    type FluentMenuButton' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.FluentMenuButton>)>] () = inherit FluentMenuButtonBuilder<Microsoft.FluentUI.AspNetCore.Components.FluentMenuButton>()
    type FluentMenu' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.FluentMenu>)>] () = inherit FluentMenuBuilder<Microsoft.FluentUI.AspNetCore.Components.FluentMenu>()
    type FluentMenuItem' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.FluentMenuItem>)>] () = inherit FluentMenuItemBuilder<Microsoft.FluentUI.AspNetCore.Components.FluentMenuItem>()
    type FluentMenuProvider' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.FluentMenuProvider>)>] () = inherit FluentMenuProviderBuilder<Microsoft.FluentUI.AspNetCore.Components.FluentMenuProvider>()
    type FluentMessageBar' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.FluentMessageBar>)>] () = inherit FluentMessageBarBuilder<Microsoft.FluentUI.AspNetCore.Components.FluentMessageBar>()
    type FluentMessageBarProvider' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.FluentMessageBarProvider>)>] () = inherit FluentMessageBarProviderBuilder<Microsoft.FluentUI.AspNetCore.Components.FluentMessageBarProvider>()
    type FluentNavMenuTree' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.FluentNavMenuTree>)>] () = inherit FluentNavMenuTreeBuilder<Microsoft.FluentUI.AspNetCore.Components.FluentNavMenuTree>()
    type FluentNavMenu' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.FluentNavMenu>)>] () = inherit FluentNavMenuBuilder<Microsoft.FluentUI.AspNetCore.Components.FluentNavMenu>()
    type FluentOverflow' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.FluentOverflow>)>] () = inherit FluentOverflowBuilder<Microsoft.FluentUI.AspNetCore.Components.FluentOverflow>()
    type FluentOverflowItem' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.FluentOverflowItem>)>] () = inherit FluentOverflowItemBuilder<Microsoft.FluentUI.AspNetCore.Components.FluentOverflowItem>()

    /// A component that provides a user interface for PaginationState.
    type FluentPaginator' 
        /// A component that provides a user interface for PaginationState.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.FluentPaginator>)>] () = inherit FluentPaginatorBuilder<Microsoft.FluentUI.AspNetCore.Components.FluentPaginator>()
    type FluentPopover' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.FluentPopover>)>] () = inherit FluentPopoverBuilder<Microsoft.FluentUI.AspNetCore.Components.FluentPopover>()

    /// A presence badge is a badge that displays a status indicator such as available, away, or busy.
    type FluentPresenceBadge' 
        /// A presence badge is a badge that displays a status indicator such as available, away, or busy.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.FluentPresenceBadge>)>] () = inherit FluentPresenceBadgeBuilder<Microsoft.FluentUI.AspNetCore.Components.FluentPresenceBadge>()
    type FluentProfileMenu' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.FluentProfileMenu>)>] () = inherit FluentProfileMenuBuilder<Microsoft.FluentUI.AspNetCore.Components.FluentProfileMenu>()
    type FluentProgress' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.FluentProgress>)>] () = inherit FluentProgressBuilder<Microsoft.FluentUI.AspNetCore.Components.FluentProgress>()
    type FluentProgressRing' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.FluentProgressRing>)>] () = inherit FluentProgressRingBuilder<Microsoft.FluentUI.AspNetCore.Components.FluentProgressRing>()
    type FluentPullToRefresh' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.FluentPullToRefresh>)>] () = inherit FluentPullToRefreshBuilder<Microsoft.FluentUI.AspNetCore.Components.FluentPullToRefresh>()
    type FluentRadio'<'TValue> [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.FluentRadio<_>>)>] () = inherit FluentRadioBuilder<Microsoft.FluentUI.AspNetCore.Components.FluentRadio<'TValue>, 'TValue>()
    type FluentSkeleton' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.FluentSkeleton>)>] () = inherit FluentSkeletonBuilder<Microsoft.FluentUI.AspNetCore.Components.FluentSkeleton>()
    type FluentSliderLabelInt' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.FluentSliderLabel<int>>)>] () = inherit FluentSliderLabelBuilder<Microsoft.FluentUI.AspNetCore.Components.FluentSliderLabel<int>, int>()
    type FluentSliderLabelFloat' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.FluentSliderLabel<float>>)>] () = inherit FluentSliderLabelBuilder<Microsoft.FluentUI.AspNetCore.Components.FluentSliderLabel<float>, float>()
    type FluentSortableList'<'TItem> [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.FluentSortableList<_>>)>] () = inherit FluentSortableListBuilder<Microsoft.FluentUI.AspNetCore.Components.FluentSortableList<'TItem>, 'TItem>()
    type FluentMultiSplitter' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.FluentMultiSplitter>)>] () = inherit FluentMultiSplitterBuilder<Microsoft.FluentUI.AspNetCore.Components.FluentMultiSplitter>()
    type FluentMultiSplitterPane' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.FluentMultiSplitterPane>)>] () = inherit FluentMultiSplitterPaneBuilder<Microsoft.FluentUI.AspNetCore.Components.FluentMultiSplitterPane>()
    type FluentSplitter' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.FluentSplitter>)>] () = inherit FluentSplitterBuilder<Microsoft.FluentUI.AspNetCore.Components.FluentSplitter>()
    type FluentStack' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.FluentStack>)>] () = inherit FluentStackBuilder<Microsoft.FluentUI.AspNetCore.Components.FluentStack>()
    type FluentTab' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.FluentTab>)>] () = inherit FluentTabBuilder<Microsoft.FluentUI.AspNetCore.Components.FluentTab>()
    type FluentTabs' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.FluentTabs>)>] () = inherit FluentTabsBuilder<Microsoft.FluentUI.AspNetCore.Components.FluentTabs>()
    type FluentToast' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.FluentToast>)>] () = inherit FluentToastBuilder<Microsoft.FluentUI.AspNetCore.Components.FluentToast>()
    type FluentToolbar' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.FluentToolbar>)>] () = inherit FluentToolbarBuilder<Microsoft.FluentUI.AspNetCore.Components.FluentToolbar>()
    type FluentTooltip' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.FluentTooltip>)>] () = inherit FluentTooltipBuilder<Microsoft.FluentUI.AspNetCore.Components.FluentTooltip>()
    type FluentTooltipProvider' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.FluentTooltipProvider>)>] () = inherit FluentTooltipProviderBuilder<Microsoft.FluentUI.AspNetCore.Components.FluentTooltipProvider>()
    type FluentTreeItem' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.FluentTreeItem>)>] () = inherit FluentTreeItemBuilder<Microsoft.FluentUI.AspNetCore.Components.FluentTreeItem>()
    type FluentTreeView' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.FluentTreeView>)>] () = inherit FluentTreeViewBuilder<Microsoft.FluentUI.AspNetCore.Components.FluentTreeView>()
    type FluentWizard' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.FluentWizard>)>] () = inherit FluentWizardBuilder<Microsoft.FluentUI.AspNetCore.Components.FluentWizard>()
    type FluentWizardStep' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.FluentWizardStep>)>] () = inherit FluentWizardStepBuilder<Microsoft.FluentUI.AspNetCore.Components.FluentWizardStep>()
    type EditForm' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.AspNetCore.Components.Forms.EditForm>)>] () = inherit EditFormBuilder<Microsoft.AspNetCore.Components.Forms.EditForm>()
    type FluentEditForm' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.FluentEditForm>)>] () = inherit FluentEditFormBuilder<Microsoft.FluentUI.AspNetCore.Components.FluentEditForm>()
    type ValidationSummary' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.AspNetCore.Components.Forms.ValidationSummary>)>] () = inherit ValidationSummaryBuilder<Microsoft.AspNetCore.Components.Forms.ValidationSummary>()
    type FluentValidationSummary' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.FluentValidationSummary>)>] () = inherit FluentValidationSummaryBuilder<Microsoft.FluentUI.AspNetCore.Components.FluentValidationSummary>()

    /// The status message will be read by screen readers.
    /// This component must be loaded when the page is rendered (it cannot be displayed or hidden using conditions).
    type FluentAccessibilityStatus' 
        /// The status message will be read by screen readers.
        /// This component must be loaded when the page is rendered (it cannot be displayed or hidden using conditions).
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.FluentAccessibilityStatus>)>] () = inherit FluentAccessibilityStatusBuilder<Microsoft.FluentUI.AspNetCore.Components.FluentAccessibilityStatus>()

    /// An abstract base class for columns in a FluentDataGrid`1.
    type ColumnBase'<'TGridItem> 
        /// An abstract base class for columns in a FluentDataGrid`1.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.ColumnBase<_>>)>] () = inherit ColumnBaseBuilder<Microsoft.FluentUI.AspNetCore.Components.ColumnBase<'TGridItem>, 'TGridItem>()

    /// Represents a FluentDataGrid`1 column whose cells display a single value.
    type PropertyColumn'<'TGridItem, 'TProp> 
        /// Represents a FluentDataGrid`1 column whose cells display a single value.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.PropertyColumn<_, _>>)>] () = inherit PropertyColumnBuilder<Microsoft.FluentUI.AspNetCore.Components.PropertyColumn<'TGridItem, 'TProp>, 'TGridItem, 'TProp>()

    /// Represents a FluentDataGrid`1 column whose cells render a selected checkbox updated when the user click on a row.
    type SelectColumn'<'TGridItem> 
        /// Represents a FluentDataGrid`1 column whose cells render a selected checkbox updated when the user click on a row.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.SelectColumn<_>>)>] () = inherit SelectColumnBuilder<Microsoft.FluentUI.AspNetCore.Components.SelectColumn<'TGridItem>, 'TGridItem>()

    /// Represents a FluentDataGrid`1 column whose cells render a supplied template.
    type TemplateColumn'<'TGridItem> 
        /// Represents a FluentDataGrid`1 column whose cells render a supplied template.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.TemplateColumn<_>>)>] () = inherit TemplateColumnBuilder<Microsoft.FluentUI.AspNetCore.Components.TemplateColumn<'TGridItem>, 'TGridItem>()
    type ColumnResizeOptions'<'TGridItem> [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.ColumnResizeOptions<_>>)>] () = inherit ColumnResizeOptionsBuilder<Microsoft.FluentUI.AspNetCore.Components.ColumnResizeOptions<'TGridItem>, 'TGridItem>()
    type FluentDesignTheme' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.FluentDesignTheme>)>] () = inherit FluentDesignThemeBuilder<Microsoft.FluentUI.AspNetCore.Components.FluentDesignTheme>()
    type FluentSplashScreen' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.FluentSplashScreen>)>] () = inherit FluentSplashScreenBuilder<Microsoft.FluentUI.AspNetCore.Components.FluentSplashScreen>()
    type MessageBox' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.MessageBox>)>] () = inherit MessageBoxBuilder<Microsoft.FluentUI.AspNetCore.Components.MessageBox>()
    type FluentDialogProvider' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.FluentDialogProvider>)>] () = inherit FluentDialogProviderBuilder<Microsoft.FluentUI.AspNetCore.Components.FluentDialogProvider>()

    /// Extends the OnKeyDown blazor event to provide a more fluent way to evaluate the key code.
    /// The anchor must refer to the ID of an element (or sub-element) accepting the focus.
    type FluentKeyCode' 
        /// Extends the OnKeyDown blazor event to provide a more fluent way to evaluate the key code.
        /// The anchor must refer to the ID of an element (or sub-element) accepting the focus.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.FluentKeyCode>)>] () = inherit FluentKeyCodeBuilder<Microsoft.FluentUI.AspNetCore.Components.FluentKeyCode>()
    type FluentKeyCodeProvider' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.FluentKeyCodeProvider>)>] () = inherit FluentKeyCodeProviderBuilder<Microsoft.FluentUI.AspNetCore.Components.FluentKeyCodeProvider>()
    type FluentInputLabel' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.FluentInputLabel>)>] () = inherit FluentInputLabelBuilder<Microsoft.FluentUI.AspNetCore.Components.FluentInputLabel>()
    type FluentOverlay' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.FluentOverlay>)>] () = inherit FluentOverlayBuilder<Microsoft.FluentUI.AspNetCore.Components.FluentOverlay>()
    type FluentSpacer' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.FluentSpacer>)>] () = inherit FluentSpacerBuilder<Microsoft.FluentUI.AspNetCore.Components.FluentSpacer>()
    type CommunicationToast' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.CommunicationToast>)>] () = inherit CommunicationToastBuilder<Microsoft.FluentUI.AspNetCore.Components.CommunicationToast>()
    type ProgressToast' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.ProgressToast>)>] () = inherit ProgressToastBuilder<Microsoft.FluentUI.AspNetCore.Components.ProgressToast>()
    type FluentToastProvider' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.FluentToastProvider>)>] () = inherit FluentToastProviderBuilder<Microsoft.FluentUI.AspNetCore.Components.FluentToastProvider>()
    type RenderFragmentDialog' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.RenderFragmentDialog>)>] () = inherit RenderFragmentDialogBuilder<Microsoft.FluentUI.AspNetCore.Components.RenderFragmentDialog>()
    type FluentPageScript' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.FluentPageScript>)>] () = inherit FluentPageScriptBuilder<Microsoft.FluentUI.AspNetCore.Components.FluentPageScript>()
    type ConfirmationToast' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.ConfirmationToast>)>] () = inherit ConfirmationToastBuilder<Microsoft.FluentUI.AspNetCore.Components.ConfirmationToast>()

[<AutoOpen>]
module DslCEInstances =
  
    open System.Diagnostics.CodeAnalysis
    open Microsoft.FluentUI.AspNetCore.Components.DslInternals

    let FluentComponentBase'' = FluentComponentBase'()
    let FluentNavMenuItemBase'' = FluentNavMenuItemBase'()
    let FluentNavMenuGroup'' = FluentNavMenuGroup'()
    let FluentNavMenuLink'' = FluentNavMenuLink'()
    let FluentNavBase'' = FluentNavBase'()
    let FluentNavGroup'' = FluentNavGroup'()
    let FluentNavLink'' = FluentNavLink'()
    let FluentAccordion'' = FluentAccordion'()
    let FluentAccordionItem'' = FluentAccordionItem'()
    let FluentAnchoredRegion'' = FluentAnchoredRegion'()
    let FluentAnchor'' = FluentAnchor'()
    let FluentAppBar'' = FluentAppBar'()
    let FluentAppBarItem'' = FluentAppBarItem'()
    let FluentBadge'' = FluentBadge'()
    let FluentInputBase''<'TValue> = FluentInputBase'<'TValue>()
    let FluentCalendarBase'' = FluentCalendarBase'()
    let FluentCalendar'' = FluentCalendar'()
    let FluentDatePicker'' = FluentDatePicker'()
    let FluentCheckbox'' = FluentCheckbox'()
    let FluentTimePicker'' = FluentTimePicker'()
    let ListComponentBase''<'TOption> = ListComponentBase'<'TOption>()
    let FluentAutocomplete''<'TOption> = FluentAutocomplete'<'TOption>()
    let FluentCombobox''<'TOption> = FluentCombobox'<'TOption>()
    let FluentListbox''<'TOption> = FluentListbox'<'TOption>()
    let FluentSelect''<'TOption> = FluentSelect'<'TOption>()
    let FluentNumberField''<'TValue when 'TValue : (new : unit -> 'TValue)> = FluentNumberField'<'TValue>()
    let FluentRadioGroup''<'TValue> = FluentRadioGroup'<'TValue>()
    let FluentRating'' = FluentRating'()
    let FluentSearch'' = FluentSearch'()
    let FluentSliderInt'' = FluentSliderInt'()
    let FluentSliderFloat'' = FluentSliderFloat'()
    let FluentSwitch'' = FluentSwitch'()
    let FluentTextArea'' = FluentTextArea'()
    let FluentTextField'' = FluentTextField'()
    let FluentBodyContent'' = FluentBodyContent'()
    let FluentBreadcrumb'' = FluentBreadcrumb'()
    let FluentBreadcrumbItem'' = FluentBreadcrumbItem'()
    let FluentButton'' = FluentButton'()
    let FluentCard'' = FluentCard'()
    let FluentCollapsibleRegion'' = FluentCollapsibleRegion'()
    let FluentCounterBadge'' = FluentCounterBadge'()
    let FluentDataGrid''<'TGridItem> = FluentDataGrid'<'TGridItem>()
    let FluentDataGridCell''<'TGridItem> = FluentDataGridCell'<'TGridItem>()
    let FluentDataGridRow''<'TGridItem> = FluentDataGridRow'<'TGridItem>()
    let FluentDesignSystemProvider'' = FluentDesignSystemProvider'()
    let FluentDialog'' = FluentDialog'()
    let FluentDialogBody'' = FluentDialogBody'()
    let FluentDialogFooter'' = FluentDialogFooter'()
    let FluentDialogHeader'' = FluentDialogHeader'()
    let FluentDivider'' = FluentDivider'()
    let FluentDragContainer''<'TItem> = FluentDragContainer'<'TItem>()
    let FluentDropZone''<'TItem> = FluentDropZone'<'TItem>()
    let FluentEmoji''<'Emoji when 'Emoji : (new : unit -> 'Emoji) and 'Emoji :> Microsoft.FluentUI.AspNetCore.Components.Emoji> = FluentEmoji'<'Emoji>()
    let FluentFlipper'' = FluentFlipper'()
    let FluentFooter'' = FluentFooter'()
    let FluentValidationMessage''<'TValue> = FluentValidationMessage'<'TValue>()
    let FluentGrid'' = FluentGrid'()
    let FluentGridItem'' = FluentGridItem'()
    let FluentHeader'' = FluentHeader'()
    let FluentHighlighter'' = FluentHighlighter'()
    let FluentHorizontalScroll'' = FluentHorizontalScroll'()
    let FluentIcon''<'Icon when 'Icon : (new : unit -> 'Icon) and 'Icon :> Microsoft.FluentUI.AspNetCore.Components.Icon> = FluentIcon'<'Icon>()
    let FluentInputFile'' = FluentInputFile'()
    let FluentLabel'' = FluentLabel'()
    let FluentLayout'' = FluentLayout'()
    let FluentOption''<'TOption> = FluentOption'<'TOption>()
    let FluentPersona'' = FluentPersona'()
    let FluentMainLayout'' = FluentMainLayout'()
    let FluentMain'' = FluentMain'()
    let FluentMenuButton'' = FluentMenuButton'()
    let FluentMenu'' = FluentMenu'()
    let FluentMenuItem'' = FluentMenuItem'()
    let FluentMenuProvider'' = FluentMenuProvider'()
    let FluentMessageBar'' = FluentMessageBar'()
    let FluentMessageBarProvider'' = FluentMessageBarProvider'()
    let FluentNavMenuTree'' = FluentNavMenuTree'()
    let FluentNavMenu'' = FluentNavMenu'()
    let FluentOverflow'' = FluentOverflow'()
    let FluentOverflowItem'' = FluentOverflowItem'()
    let FluentPaginator'' = FluentPaginator'()
    let FluentPopover'' = FluentPopover'()
    let FluentPresenceBadge'' = FluentPresenceBadge'()
    let FluentProfileMenu'' = FluentProfileMenu'()
    let FluentProgress'' = FluentProgress'()
    let FluentProgressRing'' = FluentProgressRing'()
    let FluentPullToRefresh'' = FluentPullToRefresh'()
    let FluentRadio''<'TValue> = FluentRadio'<'TValue>()
    let FluentSkeleton'' = FluentSkeleton'()
    let FluentSliderLabelInt'' = FluentSliderLabelInt'()
    let FluentSliderLabelFloat'' = FluentSliderLabelFloat'()
    let FluentSortableList''<'TItem> = FluentSortableList'<'TItem>()
    let FluentMultiSplitter'' = FluentMultiSplitter'()
    let FluentMultiSplitterPane'' = FluentMultiSplitterPane'()
    let FluentSplitter'' = FluentSplitter'()
    let FluentStack'' = FluentStack'()
    let FluentTab'' = FluentTab'()
    let FluentTabs'' = FluentTabs'()
    let FluentToast'' = FluentToast'()
    let FluentToolbar'' = FluentToolbar'()
    let FluentTooltip'' = FluentTooltip'()
    let FluentTooltipProvider'' = FluentTooltipProvider'()
    let FluentTreeItem'' = FluentTreeItem'()
    let FluentTreeView'' = FluentTreeView'()
    let FluentWizard'' = FluentWizard'()
    let FluentWizardStep'' = FluentWizardStep'()
    let EditForm'' = EditForm'()
    let FluentEditForm'' = FluentEditForm'()
    let ValidationSummary'' = ValidationSummary'()
    let FluentValidationSummary'' = FluentValidationSummary'()
    let FluentAccessibilityStatus'' = FluentAccessibilityStatus'()
    let ColumnBase''<'TGridItem> = ColumnBase'<'TGridItem>()
    let PropertyColumn''<'TGridItem, 'TProp> = PropertyColumn'<'TGridItem, 'TProp>()
    let SelectColumn''<'TGridItem> = SelectColumn'<'TGridItem>()
    let TemplateColumn''<'TGridItem> = TemplateColumn'<'TGridItem>()
    let ColumnResizeOptions''<'TGridItem> = ColumnResizeOptions'<'TGridItem>()
    let FluentDesignTheme'' = FluentDesignTheme'()
    let FluentSplashScreen'' = FluentSplashScreen'()
    let MessageBox'' = MessageBox'()
    let FluentDialogProvider'' = FluentDialogProvider'()
    let FluentKeyCode'' = FluentKeyCode'()
    let FluentKeyCodeProvider'' = FluentKeyCodeProvider'()
    let FluentInputLabel'' = FluentInputLabel'()
    let FluentOverlay'' = FluentOverlay'()
    let FluentSpacer'' = FluentSpacer'()
    let CommunicationToast'' = CommunicationToast'()
    let ProgressToast'' = ProgressToast'()
    let FluentToastProvider'' = FluentToastProvider'()
    let RenderFragmentDialog'' = RenderFragmentDialog'()
    let FluentPageScript'' = FluentPageScript'()
    let ConfirmationToast'' = ConfirmationToast'()
            
namespace Microsoft.FluentUI.AspNetCore.Components.DesignTokens

[<AutoOpen>]
module DslCE =
  
    open System.Diagnostics.CodeAnalysis
    open Microsoft.FluentUI.AspNetCore.Components.DslInternals.DesignTokens

    type DesignToken'<'T> [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.DesignToken<_>>)>] () = inherit DesignTokenBuilder<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.DesignToken<'T>, 'T>()

    /// The Direction design token
    type Direction' 
        /// The Direction design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.Direction>)>] () = inherit DirectionBuilder<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.Direction>()

    /// The DisabledOpacity design token
    type DisabledOpacity' 
        /// The DisabledOpacity design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.DisabledOpacity>)>] () = inherit DisabledOpacityBuilder<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.DisabledOpacity>()

    /// The BaseHeightMultiplier design token
    type BaseHeightMultiplier' 
        /// The BaseHeightMultiplier design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.BaseHeightMultiplier>)>] () = inherit BaseHeightMultiplierBuilder<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.BaseHeightMultiplier>()

    /// The BaseHorizontalSpacingMultiplier design token
    type BaseHorizontalSpacingMultiplier' 
        /// The BaseHorizontalSpacingMultiplier design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.BaseHorizontalSpacingMultiplier>)>] () = inherit BaseHorizontalSpacingMultiplierBuilder<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.BaseHorizontalSpacingMultiplier>()

    /// The Density design token
    type Density' 
        /// The Density design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.Density>)>] () = inherit DensityBuilder<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.Density>()

    /// The DesignUnit design token
    type DesignUnit' 
        /// The DesignUnit design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.DesignUnit>)>] () = inherit DesignUnitBuilder<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.DesignUnit>()

    /// The ControlCornerRadius design token
    type ControlCornerRadius' 
        /// The ControlCornerRadius design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.ControlCornerRadius>)>] () = inherit ControlCornerRadiusBuilder<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.ControlCornerRadius>()

    /// The LayerCornerRadius design token
    type LayerCornerRadius' 
        /// The LayerCornerRadius design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.LayerCornerRadius>)>] () = inherit LayerCornerRadiusBuilder<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.LayerCornerRadius>()

    /// The StrokeWidth design token
    type StrokeWidth' 
        /// The StrokeWidth design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.StrokeWidth>)>] () = inherit StrokeWidthBuilder<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.StrokeWidth>()

    /// The FocusStrokeWidth design token
    type FocusStrokeWidth' 
        /// The FocusStrokeWidth design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.FocusStrokeWidth>)>] () = inherit FocusStrokeWidthBuilder<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.FocusStrokeWidth>()

    /// The BodyFont design token
    type BodyFont' 
        /// The BodyFont design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.BodyFont>)>] () = inherit BodyFontBuilder<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.BodyFont>()

    /// The TypeRampBaseFontSize design token
    type TypeRampBaseFontSize' 
        /// The TypeRampBaseFontSize design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.TypeRampBaseFontSize>)>] () = inherit TypeRampBaseFontSizeBuilder<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.TypeRampBaseFontSize>()

    /// The TypeRampBaseLineHeight design token
    type TypeRampBaseLineHeight' 
        /// The TypeRampBaseLineHeight design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.TypeRampBaseLineHeight>)>] () = inherit TypeRampBaseLineHeightBuilder<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.TypeRampBaseLineHeight>()

    /// The TypeRampMinus1FontSize design token
    type TypeRampMinus1FontSize' 
        /// The TypeRampMinus1FontSize design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.TypeRampMinus1FontSize>)>] () = inherit TypeRampMinus1FontSizeBuilder<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.TypeRampMinus1FontSize>()

    /// The TypeRampMinus1LineHeight design token
    type TypeRampMinus1LineHeight' 
        /// The TypeRampMinus1LineHeight design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.TypeRampMinus1LineHeight>)>] () = inherit TypeRampMinus1LineHeightBuilder<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.TypeRampMinus1LineHeight>()

    /// The TypeRampMinus2FontSize design token
    type TypeRampMinus2FontSize' 
        /// The TypeRampMinus2FontSize design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.TypeRampMinus2FontSize>)>] () = inherit TypeRampMinus2FontSizeBuilder<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.TypeRampMinus2FontSize>()

    /// The TypeRampMinus2LineHeight design token
    type TypeRampMinus2LineHeight' 
        /// The TypeRampMinus2LineHeight design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.TypeRampMinus2LineHeight>)>] () = inherit TypeRampMinus2LineHeightBuilder<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.TypeRampMinus2LineHeight>()

    /// The TypeRampPlus1FontSize design token
    type TypeRampPlus1FontSize' 
        /// The TypeRampPlus1FontSize design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.TypeRampPlus1FontSize>)>] () = inherit TypeRampPlus1FontSizeBuilder<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.TypeRampPlus1FontSize>()

    /// The TypeRampPlus1LineHeight design token
    type TypeRampPlus1LineHeight' 
        /// The TypeRampPlus1LineHeight design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.TypeRampPlus1LineHeight>)>] () = inherit TypeRampPlus1LineHeightBuilder<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.TypeRampPlus1LineHeight>()

    /// The TypeRampPlus2FontSize design token
    type TypeRampPlus2FontSize' 
        /// The TypeRampPlus2FontSize design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.TypeRampPlus2FontSize>)>] () = inherit TypeRampPlus2FontSizeBuilder<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.TypeRampPlus2FontSize>()

    /// The TypeRampPlus2LineHeight design token
    type TypeRampPlus2LineHeight' 
        /// The TypeRampPlus2LineHeight design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.TypeRampPlus2LineHeight>)>] () = inherit TypeRampPlus2LineHeightBuilder<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.TypeRampPlus2LineHeight>()

    /// The TypeRampPlus3FontSize design token
    type TypeRampPlus3FontSize' 
        /// The TypeRampPlus3FontSize design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.TypeRampPlus3FontSize>)>] () = inherit TypeRampPlus3FontSizeBuilder<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.TypeRampPlus3FontSize>()

    /// The TypeRampPlus3LineHeight design token
    type TypeRampPlus3LineHeight' 
        /// The TypeRampPlus3LineHeight design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.TypeRampPlus3LineHeight>)>] () = inherit TypeRampPlus3LineHeightBuilder<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.TypeRampPlus3LineHeight>()

    /// The TypeRampPlus4FontSize design token
    type TypeRampPlus4FontSize' 
        /// The TypeRampPlus4FontSize design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.TypeRampPlus4FontSize>)>] () = inherit TypeRampPlus4FontSizeBuilder<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.TypeRampPlus4FontSize>()

    /// The TypeRampPlus4LineHeight design token
    type TypeRampPlus4LineHeight' 
        /// The TypeRampPlus4LineHeight design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.TypeRampPlus4LineHeight>)>] () = inherit TypeRampPlus4LineHeightBuilder<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.TypeRampPlus4LineHeight>()

    /// The TypeRampPlus5FontSize design token
    type TypeRampPlus5FontSize' 
        /// The TypeRampPlus5FontSize design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.TypeRampPlus5FontSize>)>] () = inherit TypeRampPlus5FontSizeBuilder<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.TypeRampPlus5FontSize>()

    /// The TypeRampPlus5LineHeight design token
    type TypeRampPlus5LineHeight' 
        /// The TypeRampPlus5LineHeight design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.TypeRampPlus5LineHeight>)>] () = inherit TypeRampPlus5LineHeightBuilder<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.TypeRampPlus5LineHeight>()

    /// The TypeRampPlus6FontSize design token
    type TypeRampPlus6FontSize' 
        /// The TypeRampPlus6FontSize design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.TypeRampPlus6FontSize>)>] () = inherit TypeRampPlus6FontSizeBuilder<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.TypeRampPlus6FontSize>()

    /// The TypeRampPlus6LineHeight design token
    type TypeRampPlus6LineHeight' 
        /// The TypeRampPlus6LineHeight design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.TypeRampPlus6LineHeight>)>] () = inherit TypeRampPlus6LineHeightBuilder<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.TypeRampPlus6LineHeight>()

    /// The BaseLayerLuminance design token
    type BaseLayerLuminance' 
        /// The BaseLayerLuminance design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.BaseLayerLuminance>)>] () = inherit BaseLayerLuminanceBuilder<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.BaseLayerLuminance>()

    /// The AccentFillRestDelta design token
    type AccentFillRestDelta' 
        /// The AccentFillRestDelta design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.AccentFillRestDelta>)>] () = inherit AccentFillRestDeltaBuilder<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.AccentFillRestDelta>()

    /// The AccentFillHoverDelta design token
    type AccentFillHoverDelta' 
        /// The AccentFillHoverDelta design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.AccentFillHoverDelta>)>] () = inherit AccentFillHoverDeltaBuilder<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.AccentFillHoverDelta>()

    /// The AccentFillActiveDelta design token
    type AccentFillActiveDelta' 
        /// The AccentFillActiveDelta design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.AccentFillActiveDelta>)>] () = inherit AccentFillActiveDeltaBuilder<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.AccentFillActiveDelta>()

    /// The AccentFillFocusDelta design token
    type AccentFillFocusDelta' 
        /// The AccentFillFocusDelta design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.AccentFillFocusDelta>)>] () = inherit AccentFillFocusDeltaBuilder<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.AccentFillFocusDelta>()

    /// The AccentForegroundRestDelta design token
    type AccentForegroundRestDelta' 
        /// The AccentForegroundRestDelta design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.AccentForegroundRestDelta>)>] () = inherit AccentForegroundRestDeltaBuilder<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.AccentForegroundRestDelta>()

    /// The AccentForegroundHoverDelta design token
    type AccentForegroundHoverDelta' 
        /// The AccentForegroundHoverDelta design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.AccentForegroundHoverDelta>)>] () = inherit AccentForegroundHoverDeltaBuilder<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.AccentForegroundHoverDelta>()

    /// The AccentForegroundActiveDelta design token
    type AccentForegroundActiveDelta' 
        /// The AccentForegroundActiveDelta design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.AccentForegroundActiveDelta>)>] () = inherit AccentForegroundActiveDeltaBuilder<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.AccentForegroundActiveDelta>()

    /// The AccentForegroundFocusDelta design token
    type AccentForegroundFocusDelta' 
        /// The AccentForegroundFocusDelta design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.AccentForegroundFocusDelta>)>] () = inherit AccentForegroundFocusDeltaBuilder<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.AccentForegroundFocusDelta>()

    /// The NeutralFillRestDelta design token
    type NeutralFillRestDelta' 
        /// The NeutralFillRestDelta design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.NeutralFillRestDelta>)>] () = inherit NeutralFillRestDeltaBuilder<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.NeutralFillRestDelta>()

    /// The NeutralFillHoverDelta design token
    type NeutralFillHoverDelta' 
        /// The NeutralFillHoverDelta design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.NeutralFillHoverDelta>)>] () = inherit NeutralFillHoverDeltaBuilder<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.NeutralFillHoverDelta>()

    /// The NeutralFillActiveDelta design token
    type NeutralFillActiveDelta' 
        /// The NeutralFillActiveDelta design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.NeutralFillActiveDelta>)>] () = inherit NeutralFillActiveDeltaBuilder<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.NeutralFillActiveDelta>()

    /// The NeutralFillFocusDelta design token
    type NeutralFillFocusDelta' 
        /// The NeutralFillFocusDelta design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.NeutralFillFocusDelta>)>] () = inherit NeutralFillFocusDeltaBuilder<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.NeutralFillFocusDelta>()

    /// The NeutralFillInputRestDelta design token
    type NeutralFillInputRestDelta' 
        /// The NeutralFillInputRestDelta design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.NeutralFillInputRestDelta>)>] () = inherit NeutralFillInputRestDeltaBuilder<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.NeutralFillInputRestDelta>()

    /// The NeutralFillInputHoverDelta design token
    type NeutralFillInputHoverDelta' 
        /// The NeutralFillInputHoverDelta design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.NeutralFillInputHoverDelta>)>] () = inherit NeutralFillInputHoverDeltaBuilder<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.NeutralFillInputHoverDelta>()

    /// The NeutralFillInputActiveDelta design token
    type NeutralFillInputActiveDelta' 
        /// The NeutralFillInputActiveDelta design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.NeutralFillInputActiveDelta>)>] () = inherit NeutralFillInputActiveDeltaBuilder<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.NeutralFillInputActiveDelta>()

    /// The NeutralFillInputFocusDelta design token
    type NeutralFillInputFocusDelta' 
        /// The NeutralFillInputFocusDelta design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.NeutralFillInputFocusDelta>)>] () = inherit NeutralFillInputFocusDeltaBuilder<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.NeutralFillInputFocusDelta>()

    /// The NeutralFillInputAltRestDelta design token
    type NeutralFillInputAltRestDelta' 
        /// The NeutralFillInputAltRestDelta design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.NeutralFillInputAltRestDelta>)>] () = inherit NeutralFillInputAltRestDeltaBuilder<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.NeutralFillInputAltRestDelta>()

    /// The NeutralFillInputAltHoverDelta design token
    type NeutralFillInputAltHoverDelta' 
        /// The NeutralFillInputAltHoverDelta design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.NeutralFillInputAltHoverDelta>)>] () = inherit NeutralFillInputAltHoverDeltaBuilder<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.NeutralFillInputAltHoverDelta>()

    /// The NeutralFillInputAltActiveDelta design token
    type NeutralFillInputAltActiveDelta' 
        /// The NeutralFillInputAltActiveDelta design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.NeutralFillInputAltActiveDelta>)>] () = inherit NeutralFillInputAltActiveDeltaBuilder<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.NeutralFillInputAltActiveDelta>()

    /// The NeutralFillInputAltFocusDelta design token
    type NeutralFillInputAltFocusDelta' 
        /// The NeutralFillInputAltFocusDelta design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.NeutralFillInputAltFocusDelta>)>] () = inherit NeutralFillInputAltFocusDeltaBuilder<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.NeutralFillInputAltFocusDelta>()

    /// The NeutralFillLayerRestDelta design token
    type NeutralFillLayerRestDelta' 
        /// The NeutralFillLayerRestDelta design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.NeutralFillLayerRestDelta>)>] () = inherit NeutralFillLayerRestDeltaBuilder<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.NeutralFillLayerRestDelta>()

    /// The NeutralFillLayerHoverDelta design token
    type NeutralFillLayerHoverDelta' 
        /// The NeutralFillLayerHoverDelta design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.NeutralFillLayerHoverDelta>)>] () = inherit NeutralFillLayerHoverDeltaBuilder<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.NeutralFillLayerHoverDelta>()

    /// The NeutralFillLayerActiveDelta design token
    type NeutralFillLayerActiveDelta' 
        /// The NeutralFillLayerActiveDelta design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.NeutralFillLayerActiveDelta>)>] () = inherit NeutralFillLayerActiveDeltaBuilder<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.NeutralFillLayerActiveDelta>()

    /// The NeutralFillLayerAltRestDelta design token
    type NeutralFillLayerAltRestDelta' 
        /// The NeutralFillLayerAltRestDelta design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.NeutralFillLayerAltRestDelta>)>] () = inherit NeutralFillLayerAltRestDeltaBuilder<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.NeutralFillLayerAltRestDelta>()

    /// The NeutralFillSecondaryRestDelta design token
    type NeutralFillSecondaryRestDelta' 
        /// The NeutralFillSecondaryRestDelta design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.NeutralFillSecondaryRestDelta>)>] () = inherit NeutralFillSecondaryRestDeltaBuilder<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.NeutralFillSecondaryRestDelta>()

    /// The NeutralFillSecondaryHoverDelta design token
    type NeutralFillSecondaryHoverDelta' 
        /// The NeutralFillSecondaryHoverDelta design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.NeutralFillSecondaryHoverDelta>)>] () = inherit NeutralFillSecondaryHoverDeltaBuilder<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.NeutralFillSecondaryHoverDelta>()

    /// The NeutralFillSecondaryActiveDelta design token
    type NeutralFillSecondaryActiveDelta' 
        /// The NeutralFillSecondaryActiveDelta design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.NeutralFillSecondaryActiveDelta>)>] () = inherit NeutralFillSecondaryActiveDeltaBuilder<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.NeutralFillSecondaryActiveDelta>()

    /// The NeutralFillSecondaryFocusDelta design token
    type NeutralFillSecondaryFocusDelta' 
        /// The NeutralFillSecondaryFocusDelta design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.NeutralFillSecondaryFocusDelta>)>] () = inherit NeutralFillSecondaryFocusDeltaBuilder<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.NeutralFillSecondaryFocusDelta>()

    /// The NeutralFillStealthRestDelta design token
    type NeutralFillStealthRestDelta' 
        /// The NeutralFillStealthRestDelta design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.NeutralFillStealthRestDelta>)>] () = inherit NeutralFillStealthRestDeltaBuilder<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.NeutralFillStealthRestDelta>()

    /// The NeutralFillStealthHoverDelta design token
    type NeutralFillStealthHoverDelta' 
        /// The NeutralFillStealthHoverDelta design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.NeutralFillStealthHoverDelta>)>] () = inherit NeutralFillStealthHoverDeltaBuilder<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.NeutralFillStealthHoverDelta>()

    /// The NeutralFillStealthActiveDelta design token
    type NeutralFillStealthActiveDelta' 
        /// The NeutralFillStealthActiveDelta design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.NeutralFillStealthActiveDelta>)>] () = inherit NeutralFillStealthActiveDeltaBuilder<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.NeutralFillStealthActiveDelta>()

    /// The NeutralFillStealthFocusDelta design token
    type NeutralFillStealthFocusDelta' 
        /// The NeutralFillStealthFocusDelta design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.NeutralFillStealthFocusDelta>)>] () = inherit NeutralFillStealthFocusDeltaBuilder<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.NeutralFillStealthFocusDelta>()

    /// The NeutralFillStrongRestDelta design token
    type NeutralFillStrongRestDelta' 
        /// The NeutralFillStrongRestDelta design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.NeutralFillStrongRestDelta>)>] () = inherit NeutralFillStrongRestDeltaBuilder<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.NeutralFillStrongRestDelta>()

    /// The NeutralFillStrongHoverDelta design token
    type NeutralFillStrongHoverDelta' 
        /// The NeutralFillStrongHoverDelta design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.NeutralFillStrongHoverDelta>)>] () = inherit NeutralFillStrongHoverDeltaBuilder<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.NeutralFillStrongHoverDelta>()

    /// The NeutralFillStrongActiveDelta design token
    type NeutralFillStrongActiveDelta' 
        /// The NeutralFillStrongActiveDelta design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.NeutralFillStrongActiveDelta>)>] () = inherit NeutralFillStrongActiveDeltaBuilder<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.NeutralFillStrongActiveDelta>()

    /// The NeutralFillStrongFocusDelta design token
    type NeutralFillStrongFocusDelta' 
        /// The NeutralFillStrongFocusDelta design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.NeutralFillStrongFocusDelta>)>] () = inherit NeutralFillStrongFocusDeltaBuilder<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.NeutralFillStrongFocusDelta>()

    /// The NeutralStrokeRestDelta design token
    type NeutralStrokeRestDelta' 
        /// The NeutralStrokeRestDelta design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.NeutralStrokeRestDelta>)>] () = inherit NeutralStrokeRestDeltaBuilder<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.NeutralStrokeRestDelta>()

    /// The NeutralStrokeHoverDelta design token
    type NeutralStrokeHoverDelta' 
        /// The NeutralStrokeHoverDelta design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.NeutralStrokeHoverDelta>)>] () = inherit NeutralStrokeHoverDeltaBuilder<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.NeutralStrokeHoverDelta>()

    /// The NeutralStrokeActiveDelta design token
    type NeutralStrokeActiveDelta' 
        /// The NeutralStrokeActiveDelta design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.NeutralStrokeActiveDelta>)>] () = inherit NeutralStrokeActiveDeltaBuilder<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.NeutralStrokeActiveDelta>()

    /// The NeutralStrokeFocusDelta design token
    type NeutralStrokeFocusDelta' 
        /// The NeutralStrokeFocusDelta design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.NeutralStrokeFocusDelta>)>] () = inherit NeutralStrokeFocusDeltaBuilder<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.NeutralStrokeFocusDelta>()

    /// The NeutralStrokeControlRestDelta design token
    type NeutralStrokeControlRestDelta' 
        /// The NeutralStrokeControlRestDelta design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.NeutralStrokeControlRestDelta>)>] () = inherit NeutralStrokeControlRestDeltaBuilder<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.NeutralStrokeControlRestDelta>()

    /// The NeutralStrokeControlHoverDelta design token
    type NeutralStrokeControlHoverDelta' 
        /// The NeutralStrokeControlHoverDelta design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.NeutralStrokeControlHoverDelta>)>] () = inherit NeutralStrokeControlHoverDeltaBuilder<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.NeutralStrokeControlHoverDelta>()

    /// The NeutralStrokeControlActiveDelta design token
    type NeutralStrokeControlActiveDelta' 
        /// The NeutralStrokeControlActiveDelta design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.NeutralStrokeControlActiveDelta>)>] () = inherit NeutralStrokeControlActiveDeltaBuilder<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.NeutralStrokeControlActiveDelta>()

    /// The NeutralStrokeControlFocusDelta design token
    type NeutralStrokeControlFocusDelta' 
        /// The NeutralStrokeControlFocusDelta design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.NeutralStrokeControlFocusDelta>)>] () = inherit NeutralStrokeControlFocusDeltaBuilder<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.NeutralStrokeControlFocusDelta>()

    /// The NeutralStrokeDividerRestDelta design token
    type NeutralStrokeDividerRestDelta' 
        /// The NeutralStrokeDividerRestDelta design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.NeutralStrokeDividerRestDelta>)>] () = inherit NeutralStrokeDividerRestDeltaBuilder<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.NeutralStrokeDividerRestDelta>()

    /// The NeutralStrokeLayerRestDelta design token
    type NeutralStrokeLayerRestDelta' 
        /// The NeutralStrokeLayerRestDelta design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.NeutralStrokeLayerRestDelta>)>] () = inherit NeutralStrokeLayerRestDeltaBuilder<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.NeutralStrokeLayerRestDelta>()

    /// The NeutralStrokeLayerHoverDelta design token
    type NeutralStrokeLayerHoverDelta' 
        /// The NeutralStrokeLayerHoverDelta design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.NeutralStrokeLayerHoverDelta>)>] () = inherit NeutralStrokeLayerHoverDeltaBuilder<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.NeutralStrokeLayerHoverDelta>()

    /// The NeutralStrokeLayerActiveDelta design token
    type NeutralStrokeLayerActiveDelta' 
        /// The NeutralStrokeLayerActiveDelta design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.NeutralStrokeLayerActiveDelta>)>] () = inherit NeutralStrokeLayerActiveDeltaBuilder<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.NeutralStrokeLayerActiveDelta>()

    /// The NeutralStrokeStrongHoverDelta design token
    type NeutralStrokeStrongHoverDelta' 
        /// The NeutralStrokeStrongHoverDelta design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.NeutralStrokeStrongHoverDelta>)>] () = inherit NeutralStrokeStrongHoverDeltaBuilder<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.NeutralStrokeStrongHoverDelta>()

    /// The NeutralStrokeStrongActiveDelta design token
    type NeutralStrokeStrongActiveDelta' 
        /// The NeutralStrokeStrongActiveDelta design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.NeutralStrokeStrongActiveDelta>)>] () = inherit NeutralStrokeStrongActiveDeltaBuilder<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.NeutralStrokeStrongActiveDelta>()

    /// The NeutralStrokeStrongFocusDelta design token
    type NeutralStrokeStrongFocusDelta' 
        /// The NeutralStrokeStrongFocusDelta design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.NeutralStrokeStrongFocusDelta>)>] () = inherit NeutralStrokeStrongFocusDeltaBuilder<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.NeutralStrokeStrongFocusDelta>()

    /// The NeutralBaseColor design token
    type NeutralBaseColor' 
        /// The NeutralBaseColor design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.NeutralBaseColor>)>] () = inherit NeutralBaseColorBuilder<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.NeutralBaseColor>()

    /// The AccentBaseColor design token
    type AccentBaseColor' 
        /// The AccentBaseColor design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.AccentBaseColor>)>] () = inherit AccentBaseColorBuilder<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.AccentBaseColor>()

    /// The NeutralLayerCardContainer design token
    type NeutralLayerCardContainer' 
        /// The NeutralLayerCardContainer design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.NeutralLayerCardContainer>)>] () = inherit NeutralLayerCardContainerBuilder<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.NeutralLayerCardContainer>()

    /// The NeutralLayerFloating design token
    type NeutralLayerFloating' 
        /// The NeutralLayerFloating design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.NeutralLayerFloating>)>] () = inherit NeutralLayerFloatingBuilder<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.NeutralLayerFloating>()

    /// The NeutralLayer1 design token
    type NeutralLayer1' 
        /// The NeutralLayer1 design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.NeutralLayer1>)>] () = inherit NeutralLayer1Builder<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.NeutralLayer1>()

    /// The NeutralLayer2 design token
    type NeutralLayer2' 
        /// The NeutralLayer2 design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.NeutralLayer2>)>] () = inherit NeutralLayer2Builder<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.NeutralLayer2>()

    /// The NeutralLayer3 design token
    type NeutralLayer3' 
        /// The NeutralLayer3 design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.NeutralLayer3>)>] () = inherit NeutralLayer3Builder<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.NeutralLayer3>()

    /// The NeutralLayer4 design token
    type NeutralLayer4' 
        /// The NeutralLayer4 design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.NeutralLayer4>)>] () = inherit NeutralLayer4Builder<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.NeutralLayer4>()

    /// The FillColor design token
    type FillColor' 
        /// The FillColor design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.FillColor>)>] () = inherit FillColorBuilder<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.FillColor>()

    /// The AccentFillRest design token
    type AccentFillRest' 
        /// The AccentFillRest design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.AccentFillRest>)>] () = inherit AccentFillRestBuilder<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.AccentFillRest>()

    /// The AccentFillHover design token
    type AccentFillHover' 
        /// The AccentFillHover design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.AccentFillHover>)>] () = inherit AccentFillHoverBuilder<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.AccentFillHover>()

    /// The AccentFillActive design token
    type AccentFillActive' 
        /// The AccentFillActive design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.AccentFillActive>)>] () = inherit AccentFillActiveBuilder<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.AccentFillActive>()

    /// The AccentFillFocus design token
    type AccentFillFocus' 
        /// The AccentFillFocus design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.AccentFillFocus>)>] () = inherit AccentFillFocusBuilder<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.AccentFillFocus>()

    /// The ForegroundOnAccentRest design token
    type ForegroundOnAccentRest' 
        /// The ForegroundOnAccentRest design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.ForegroundOnAccentRest>)>] () = inherit ForegroundOnAccentRestBuilder<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.ForegroundOnAccentRest>()

    /// The ForegroundOnAccentHover design token
    type ForegroundOnAccentHover' 
        /// The ForegroundOnAccentHover design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.ForegroundOnAccentHover>)>] () = inherit ForegroundOnAccentHoverBuilder<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.ForegroundOnAccentHover>()

    /// The ForegroundOnAccentActive design token
    type ForegroundOnAccentActive' 
        /// The ForegroundOnAccentActive design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.ForegroundOnAccentActive>)>] () = inherit ForegroundOnAccentActiveBuilder<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.ForegroundOnAccentActive>()

    /// The ForegroundOnAccentFocus design token
    type ForegroundOnAccentFocus' 
        /// The ForegroundOnAccentFocus design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.ForegroundOnAccentFocus>)>] () = inherit ForegroundOnAccentFocusBuilder<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.ForegroundOnAccentFocus>()

    /// The AccentForegroundRest design token
    type AccentForegroundRest' 
        /// The AccentForegroundRest design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.AccentForegroundRest>)>] () = inherit AccentForegroundRestBuilder<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.AccentForegroundRest>()

    /// The AccentForegroundHover design token
    type AccentForegroundHover' 
        /// The AccentForegroundHover design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.AccentForegroundHover>)>] () = inherit AccentForegroundHoverBuilder<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.AccentForegroundHover>()

    /// The AccentForegroundActive design token
    type AccentForegroundActive' 
        /// The AccentForegroundActive design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.AccentForegroundActive>)>] () = inherit AccentForegroundActiveBuilder<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.AccentForegroundActive>()

    /// The AccentForegroundFocus design token
    type AccentForegroundFocus' 
        /// The AccentForegroundFocus design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.AccentForegroundFocus>)>] () = inherit AccentForegroundFocusBuilder<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.AccentForegroundFocus>()

    /// The AccentStrokeControlRest design token
    type AccentStrokeControlRest' 
        /// The AccentStrokeControlRest design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.AccentStrokeControlRest>)>] () = inherit AccentStrokeControlRestBuilder<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.AccentStrokeControlRest>()

    /// The AccentStrokeControlHover design token
    type AccentStrokeControlHover' 
        /// The AccentStrokeControlHover design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.AccentStrokeControlHover>)>] () = inherit AccentStrokeControlHoverBuilder<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.AccentStrokeControlHover>()

    /// The AccentStrokeControlActive design token
    type AccentStrokeControlActive' 
        /// The AccentStrokeControlActive design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.AccentStrokeControlActive>)>] () = inherit AccentStrokeControlActiveBuilder<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.AccentStrokeControlActive>()

    /// The AccentStrokeControlFocus design token
    type AccentStrokeControlFocus' 
        /// The AccentStrokeControlFocus design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.AccentStrokeControlFocus>)>] () = inherit AccentStrokeControlFocusBuilder<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.AccentStrokeControlFocus>()

    /// The NeutralFillRest design token
    type NeutralFillRest' 
        /// The NeutralFillRest design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.NeutralFillRest>)>] () = inherit NeutralFillRestBuilder<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.NeutralFillRest>()

    /// The NeutralFillHover design token
    type NeutralFillHover' 
        /// The NeutralFillHover design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.NeutralFillHover>)>] () = inherit NeutralFillHoverBuilder<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.NeutralFillHover>()

    /// The NeutralFillActive design token
    type NeutralFillActive' 
        /// The NeutralFillActive design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.NeutralFillActive>)>] () = inherit NeutralFillActiveBuilder<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.NeutralFillActive>()

    /// The NeutralFillFocus design token
    type NeutralFillFocus' 
        /// The NeutralFillFocus design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.NeutralFillFocus>)>] () = inherit NeutralFillFocusBuilder<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.NeutralFillFocus>()

    /// The NeutralFillInputRest design token
    type NeutralFillInputRest' 
        /// The NeutralFillInputRest design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.NeutralFillInputRest>)>] () = inherit NeutralFillInputRestBuilder<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.NeutralFillInputRest>()

    /// The NeutralFillInputHover design token
    type NeutralFillInputHover' 
        /// The NeutralFillInputHover design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.NeutralFillInputHover>)>] () = inherit NeutralFillInputHoverBuilder<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.NeutralFillInputHover>()

    /// The NeutralFillInputActive design token
    type NeutralFillInputActive' 
        /// The NeutralFillInputActive design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.NeutralFillInputActive>)>] () = inherit NeutralFillInputActiveBuilder<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.NeutralFillInputActive>()

    /// The NeutralFillInputFocus design token
    type NeutralFillInputFocus' 
        /// The NeutralFillInputFocus design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.NeutralFillInputFocus>)>] () = inherit NeutralFillInputFocusBuilder<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.NeutralFillInputFocus>()

    /// The NeutralFillInputAltRest design token
    type NeutralFillInputAltRest' 
        /// The NeutralFillInputAltRest design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.NeutralFillInputAltRest>)>] () = inherit NeutralFillInputAltRestBuilder<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.NeutralFillInputAltRest>()

    /// The NeutralFillInputAltHover design token
    type NeutralFillInputAltHover' 
        /// The NeutralFillInputAltHover design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.NeutralFillInputAltHover>)>] () = inherit NeutralFillInputAltHoverBuilder<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.NeutralFillInputAltHover>()

    /// The NeutralFillInputAltActive design token
    type NeutralFillInputAltActive' 
        /// The NeutralFillInputAltActive design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.NeutralFillInputAltActive>)>] () = inherit NeutralFillInputAltActiveBuilder<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.NeutralFillInputAltActive>()

    /// The NeutralFillInputAltFocus design token
    type NeutralFillInputAltFocus' 
        /// The NeutralFillInputAltFocus design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.NeutralFillInputAltFocus>)>] () = inherit NeutralFillInputAltFocusBuilder<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.NeutralFillInputAltFocus>()

    /// The NeutralFillLayerRest design token
    type NeutralFillLayerRest' 
        /// The NeutralFillLayerRest design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.NeutralFillLayerRest>)>] () = inherit NeutralFillLayerRestBuilder<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.NeutralFillLayerRest>()

    /// The NeutralFillLayerHover design token
    type NeutralFillLayerHover' 
        /// The NeutralFillLayerHover design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.NeutralFillLayerHover>)>] () = inherit NeutralFillLayerHoverBuilder<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.NeutralFillLayerHover>()

    /// The NeutralFillLayerActive design token
    type NeutralFillLayerActive' 
        /// The NeutralFillLayerActive design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.NeutralFillLayerActive>)>] () = inherit NeutralFillLayerActiveBuilder<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.NeutralFillLayerActive>()

    /// The NeutralFillLayerAltRest design token
    type NeutralFillLayerAltRest' 
        /// The NeutralFillLayerAltRest design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.NeutralFillLayerAltRest>)>] () = inherit NeutralFillLayerAltRestBuilder<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.NeutralFillLayerAltRest>()

    /// The NeutralFillSecondaryRest design token
    type NeutralFillSecondaryRest' 
        /// The NeutralFillSecondaryRest design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.NeutralFillSecondaryRest>)>] () = inherit NeutralFillSecondaryRestBuilder<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.NeutralFillSecondaryRest>()

    /// The NeutralFillSecondaryHover design token
    type NeutralFillSecondaryHover' 
        /// The NeutralFillSecondaryHover design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.NeutralFillSecondaryHover>)>] () = inherit NeutralFillSecondaryHoverBuilder<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.NeutralFillSecondaryHover>()

    /// The NeutralFillSecondaryActive design token
    type NeutralFillSecondaryActive' 
        /// The NeutralFillSecondaryActive design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.NeutralFillSecondaryActive>)>] () = inherit NeutralFillSecondaryActiveBuilder<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.NeutralFillSecondaryActive>()

    /// The NeutralFillSecondaryFocus design token
    type NeutralFillSecondaryFocus' 
        /// The NeutralFillSecondaryFocus design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.NeutralFillSecondaryFocus>)>] () = inherit NeutralFillSecondaryFocusBuilder<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.NeutralFillSecondaryFocus>()

    /// The NeutralFillStealthRest design token
    type NeutralFillStealthRest' 
        /// The NeutralFillStealthRest design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.NeutralFillStealthRest>)>] () = inherit NeutralFillStealthRestBuilder<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.NeutralFillStealthRest>()

    /// The NeutralFillStealthHover design token
    type NeutralFillStealthHover' 
        /// The NeutralFillStealthHover design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.NeutralFillStealthHover>)>] () = inherit NeutralFillStealthHoverBuilder<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.NeutralFillStealthHover>()

    /// The NeutralFillStealthActive design token
    type NeutralFillStealthActive' 
        /// The NeutralFillStealthActive design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.NeutralFillStealthActive>)>] () = inherit NeutralFillStealthActiveBuilder<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.NeutralFillStealthActive>()

    /// The NeutralFillStealthFocus design token
    type NeutralFillStealthFocus' 
        /// The NeutralFillStealthFocus design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.NeutralFillStealthFocus>)>] () = inherit NeutralFillStealthFocusBuilder<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.NeutralFillStealthFocus>()

    /// The NeutralFillStrongRest design token
    type NeutralFillStrongRest' 
        /// The NeutralFillStrongRest design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.NeutralFillStrongRest>)>] () = inherit NeutralFillStrongRestBuilder<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.NeutralFillStrongRest>()

    /// The NeutralFillStrongHover design token
    type NeutralFillStrongHover' 
        /// The NeutralFillStrongHover design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.NeutralFillStrongHover>)>] () = inherit NeutralFillStrongHoverBuilder<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.NeutralFillStrongHover>()

    /// The NeutralFillStrongActive design token
    type NeutralFillStrongActive' 
        /// The NeutralFillStrongActive design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.NeutralFillStrongActive>)>] () = inherit NeutralFillStrongActiveBuilder<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.NeutralFillStrongActive>()

    /// The NeutralFillStrongFocus design token
    type NeutralFillStrongFocus' 
        /// The NeutralFillStrongFocus design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.NeutralFillStrongFocus>)>] () = inherit NeutralFillStrongFocusBuilder<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.NeutralFillStrongFocus>()

    /// The NeutralForegroundRest design token
    type NeutralForegroundRest' 
        /// The NeutralForegroundRest design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.NeutralForegroundRest>)>] () = inherit NeutralForegroundRestBuilder<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.NeutralForegroundRest>()

    /// The NeutralForegroundHover design token
    type NeutralForegroundHover' 
        /// The NeutralForegroundHover design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.NeutralForegroundHover>)>] () = inherit NeutralForegroundHoverBuilder<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.NeutralForegroundHover>()

    /// The NeutralForegroundActive design token
    type NeutralForegroundActive' 
        /// The NeutralForegroundActive design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.NeutralForegroundActive>)>] () = inherit NeutralForegroundActiveBuilder<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.NeutralForegroundActive>()

    /// The NeutralForegroundFocus design token
    type NeutralForegroundFocus' 
        /// The NeutralForegroundFocus design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.NeutralForegroundFocus>)>] () = inherit NeutralForegroundFocusBuilder<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.NeutralForegroundFocus>()

    /// The NeutralForegroundHint design token
    type NeutralForegroundHint' 
        /// The NeutralForegroundHint design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.NeutralForegroundHint>)>] () = inherit NeutralForegroundHintBuilder<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.NeutralForegroundHint>()

    /// The NeutralStrokeRest design token
    type NeutralStrokeRest' 
        /// The NeutralStrokeRest design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.NeutralStrokeRest>)>] () = inherit NeutralStrokeRestBuilder<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.NeutralStrokeRest>()

    /// The NeutralStrokeHover design token
    type NeutralStrokeHover' 
        /// The NeutralStrokeHover design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.NeutralStrokeHover>)>] () = inherit NeutralStrokeHoverBuilder<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.NeutralStrokeHover>()

    /// The NeutralStrokeActive design token
    type NeutralStrokeActive' 
        /// The NeutralStrokeActive design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.NeutralStrokeActive>)>] () = inherit NeutralStrokeActiveBuilder<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.NeutralStrokeActive>()

    /// The NeutralStrokeFocus design token
    type NeutralStrokeFocus' 
        /// The NeutralStrokeFocus design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.NeutralStrokeFocus>)>] () = inherit NeutralStrokeFocusBuilder<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.NeutralStrokeFocus>()

    /// The NeutralStrokeControlRest design token
    type NeutralStrokeControlRest' 
        /// The NeutralStrokeControlRest design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.NeutralStrokeControlRest>)>] () = inherit NeutralStrokeControlRestBuilder<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.NeutralStrokeControlRest>()

    /// The NeutralStrokeControlHover design token
    type NeutralStrokeControlHover' 
        /// The NeutralStrokeControlHover design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.NeutralStrokeControlHover>)>] () = inherit NeutralStrokeControlHoverBuilder<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.NeutralStrokeControlHover>()

    /// The NeutralStrokeControlActive design token
    type NeutralStrokeControlActive' 
        /// The NeutralStrokeControlActive design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.NeutralStrokeControlActive>)>] () = inherit NeutralStrokeControlActiveBuilder<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.NeutralStrokeControlActive>()

    /// The NeutralStrokeControlFocus design token
    type NeutralStrokeControlFocus' 
        /// The NeutralStrokeControlFocus design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.NeutralStrokeControlFocus>)>] () = inherit NeutralStrokeControlFocusBuilder<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.NeutralStrokeControlFocus>()

    /// The NeutralStrokeDividerRest design token
    type NeutralStrokeDividerRest' 
        /// The NeutralStrokeDividerRest design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.NeutralStrokeDividerRest>)>] () = inherit NeutralStrokeDividerRestBuilder<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.NeutralStrokeDividerRest>()

    /// The NeutralStrokeInputRest design token
    type NeutralStrokeInputRest' 
        /// The NeutralStrokeInputRest design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.NeutralStrokeInputRest>)>] () = inherit NeutralStrokeInputRestBuilder<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.NeutralStrokeInputRest>()

    /// The NeutralStrokeInputHover design token
    type NeutralStrokeInputHover' 
        /// The NeutralStrokeInputHover design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.NeutralStrokeInputHover>)>] () = inherit NeutralStrokeInputHoverBuilder<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.NeutralStrokeInputHover>()

    /// The NeutralStrokeInputActive design token
    type NeutralStrokeInputActive' 
        /// The NeutralStrokeInputActive design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.NeutralStrokeInputActive>)>] () = inherit NeutralStrokeInputActiveBuilder<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.NeutralStrokeInputActive>()

    /// The NeutralStrokeInputFocus design token
    type NeutralStrokeInputFocus' 
        /// The NeutralStrokeInputFocus design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.NeutralStrokeInputFocus>)>] () = inherit NeutralStrokeInputFocusBuilder<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.NeutralStrokeInputFocus>()

    /// The NeutralStrokeLayerRest design token
    type NeutralStrokeLayerRest' 
        /// The NeutralStrokeLayerRest design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.NeutralStrokeLayerRest>)>] () = inherit NeutralStrokeLayerRestBuilder<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.NeutralStrokeLayerRest>()

    /// The NeutralStrokeLayerHover design token
    type NeutralStrokeLayerHover' 
        /// The NeutralStrokeLayerHover design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.NeutralStrokeLayerHover>)>] () = inherit NeutralStrokeLayerHoverBuilder<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.NeutralStrokeLayerHover>()

    /// The NeutralStrokeLayerActive design token
    type NeutralStrokeLayerActive' 
        /// The NeutralStrokeLayerActive design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.NeutralStrokeLayerActive>)>] () = inherit NeutralStrokeLayerActiveBuilder<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.NeutralStrokeLayerActive>()

    /// The NeutralStrokeStrongRest design token
    type NeutralStrokeStrongRest' 
        /// The NeutralStrokeStrongRest design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.NeutralStrokeStrongRest>)>] () = inherit NeutralStrokeStrongRestBuilder<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.NeutralStrokeStrongRest>()

    /// The NeutralStrokeStrongHover design token
    type NeutralStrokeStrongHover' 
        /// The NeutralStrokeStrongHover design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.NeutralStrokeStrongHover>)>] () = inherit NeutralStrokeStrongHoverBuilder<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.NeutralStrokeStrongHover>()

    /// The NeutralStrokeStrongActive design token
    type NeutralStrokeStrongActive' 
        /// The NeutralStrokeStrongActive design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.NeutralStrokeStrongActive>)>] () = inherit NeutralStrokeStrongActiveBuilder<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.NeutralStrokeStrongActive>()

    /// The NeutralStrokeStrongFocus design token
    type NeutralStrokeStrongFocus' 
        /// The NeutralStrokeStrongFocus design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.NeutralStrokeStrongFocus>)>] () = inherit NeutralStrokeStrongFocusBuilder<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.NeutralStrokeStrongFocus>()

    /// The FocusStrokeOuter design token
    type FocusStrokeOuter' 
        /// The FocusStrokeOuter design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.FocusStrokeOuter>)>] () = inherit FocusStrokeOuterBuilder<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.FocusStrokeOuter>()

    /// The FocusStrokeInner design token
    type FocusStrokeInner' 
        /// The FocusStrokeInner design token
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.FocusStrokeInner>)>] () = inherit FocusStrokeInnerBuilder<Microsoft.FluentUI.AspNetCore.Components.DesignTokens.FocusStrokeInner>()

[<AutoOpen>]
module DslCEInstances =
  
    open System.Diagnostics.CodeAnalysis
    open Microsoft.FluentUI.AspNetCore.Components.DslInternals.DesignTokens

    let DesignToken''<'T> = DesignToken'<'T>()
    let Direction'' = Direction'()
    let DisabledOpacity'' = DisabledOpacity'()
    let BaseHeightMultiplier'' = BaseHeightMultiplier'()
    let BaseHorizontalSpacingMultiplier'' = BaseHorizontalSpacingMultiplier'()
    let Density'' = Density'()
    let DesignUnit'' = DesignUnit'()
    let ControlCornerRadius'' = ControlCornerRadius'()
    let LayerCornerRadius'' = LayerCornerRadius'()
    let StrokeWidth'' = StrokeWidth'()
    let FocusStrokeWidth'' = FocusStrokeWidth'()
    let BodyFont'' = BodyFont'()
    let TypeRampBaseFontSize'' = TypeRampBaseFontSize'()
    let TypeRampBaseLineHeight'' = TypeRampBaseLineHeight'()
    let TypeRampMinus1FontSize'' = TypeRampMinus1FontSize'()
    let TypeRampMinus1LineHeight'' = TypeRampMinus1LineHeight'()
    let TypeRampMinus2FontSize'' = TypeRampMinus2FontSize'()
    let TypeRampMinus2LineHeight'' = TypeRampMinus2LineHeight'()
    let TypeRampPlus1FontSize'' = TypeRampPlus1FontSize'()
    let TypeRampPlus1LineHeight'' = TypeRampPlus1LineHeight'()
    let TypeRampPlus2FontSize'' = TypeRampPlus2FontSize'()
    let TypeRampPlus2LineHeight'' = TypeRampPlus2LineHeight'()
    let TypeRampPlus3FontSize'' = TypeRampPlus3FontSize'()
    let TypeRampPlus3LineHeight'' = TypeRampPlus3LineHeight'()
    let TypeRampPlus4FontSize'' = TypeRampPlus4FontSize'()
    let TypeRampPlus4LineHeight'' = TypeRampPlus4LineHeight'()
    let TypeRampPlus5FontSize'' = TypeRampPlus5FontSize'()
    let TypeRampPlus5LineHeight'' = TypeRampPlus5LineHeight'()
    let TypeRampPlus6FontSize'' = TypeRampPlus6FontSize'()
    let TypeRampPlus6LineHeight'' = TypeRampPlus6LineHeight'()
    let BaseLayerLuminance'' = BaseLayerLuminance'()
    let AccentFillRestDelta'' = AccentFillRestDelta'()
    let AccentFillHoverDelta'' = AccentFillHoverDelta'()
    let AccentFillActiveDelta'' = AccentFillActiveDelta'()
    let AccentFillFocusDelta'' = AccentFillFocusDelta'()
    let AccentForegroundRestDelta'' = AccentForegroundRestDelta'()
    let AccentForegroundHoverDelta'' = AccentForegroundHoverDelta'()
    let AccentForegroundActiveDelta'' = AccentForegroundActiveDelta'()
    let AccentForegroundFocusDelta'' = AccentForegroundFocusDelta'()
    let NeutralFillRestDelta'' = NeutralFillRestDelta'()
    let NeutralFillHoverDelta'' = NeutralFillHoverDelta'()
    let NeutralFillActiveDelta'' = NeutralFillActiveDelta'()
    let NeutralFillFocusDelta'' = NeutralFillFocusDelta'()
    let NeutralFillInputRestDelta'' = NeutralFillInputRestDelta'()
    let NeutralFillInputHoverDelta'' = NeutralFillInputHoverDelta'()
    let NeutralFillInputActiveDelta'' = NeutralFillInputActiveDelta'()
    let NeutralFillInputFocusDelta'' = NeutralFillInputFocusDelta'()
    let NeutralFillInputAltRestDelta'' = NeutralFillInputAltRestDelta'()
    let NeutralFillInputAltHoverDelta'' = NeutralFillInputAltHoverDelta'()
    let NeutralFillInputAltActiveDelta'' = NeutralFillInputAltActiveDelta'()
    let NeutralFillInputAltFocusDelta'' = NeutralFillInputAltFocusDelta'()
    let NeutralFillLayerRestDelta'' = NeutralFillLayerRestDelta'()
    let NeutralFillLayerHoverDelta'' = NeutralFillLayerHoverDelta'()
    let NeutralFillLayerActiveDelta'' = NeutralFillLayerActiveDelta'()
    let NeutralFillLayerAltRestDelta'' = NeutralFillLayerAltRestDelta'()
    let NeutralFillSecondaryRestDelta'' = NeutralFillSecondaryRestDelta'()
    let NeutralFillSecondaryHoverDelta'' = NeutralFillSecondaryHoverDelta'()
    let NeutralFillSecondaryActiveDelta'' = NeutralFillSecondaryActiveDelta'()
    let NeutralFillSecondaryFocusDelta'' = NeutralFillSecondaryFocusDelta'()
    let NeutralFillStealthRestDelta'' = NeutralFillStealthRestDelta'()
    let NeutralFillStealthHoverDelta'' = NeutralFillStealthHoverDelta'()
    let NeutralFillStealthActiveDelta'' = NeutralFillStealthActiveDelta'()
    let NeutralFillStealthFocusDelta'' = NeutralFillStealthFocusDelta'()
    let NeutralFillStrongRestDelta'' = NeutralFillStrongRestDelta'()
    let NeutralFillStrongHoverDelta'' = NeutralFillStrongHoverDelta'()
    let NeutralFillStrongActiveDelta'' = NeutralFillStrongActiveDelta'()
    let NeutralFillStrongFocusDelta'' = NeutralFillStrongFocusDelta'()
    let NeutralStrokeRestDelta'' = NeutralStrokeRestDelta'()
    let NeutralStrokeHoverDelta'' = NeutralStrokeHoverDelta'()
    let NeutralStrokeActiveDelta'' = NeutralStrokeActiveDelta'()
    let NeutralStrokeFocusDelta'' = NeutralStrokeFocusDelta'()
    let NeutralStrokeControlRestDelta'' = NeutralStrokeControlRestDelta'()
    let NeutralStrokeControlHoverDelta'' = NeutralStrokeControlHoverDelta'()
    let NeutralStrokeControlActiveDelta'' = NeutralStrokeControlActiveDelta'()
    let NeutralStrokeControlFocusDelta'' = NeutralStrokeControlFocusDelta'()
    let NeutralStrokeDividerRestDelta'' = NeutralStrokeDividerRestDelta'()
    let NeutralStrokeLayerRestDelta'' = NeutralStrokeLayerRestDelta'()
    let NeutralStrokeLayerHoverDelta'' = NeutralStrokeLayerHoverDelta'()
    let NeutralStrokeLayerActiveDelta'' = NeutralStrokeLayerActiveDelta'()
    let NeutralStrokeStrongHoverDelta'' = NeutralStrokeStrongHoverDelta'()
    let NeutralStrokeStrongActiveDelta'' = NeutralStrokeStrongActiveDelta'()
    let NeutralStrokeStrongFocusDelta'' = NeutralStrokeStrongFocusDelta'()
    let NeutralBaseColor'' = NeutralBaseColor'()
    let AccentBaseColor'' = AccentBaseColor'()
    let NeutralLayerCardContainer'' = NeutralLayerCardContainer'()
    let NeutralLayerFloating'' = NeutralLayerFloating'()
    let NeutralLayer1'' = NeutralLayer1'()
    let NeutralLayer2'' = NeutralLayer2'()
    let NeutralLayer3'' = NeutralLayer3'()
    let NeutralLayer4'' = NeutralLayer4'()
    let FillColor'' = FillColor'()
    let AccentFillRest'' = AccentFillRest'()
    let AccentFillHover'' = AccentFillHover'()
    let AccentFillActive'' = AccentFillActive'()
    let AccentFillFocus'' = AccentFillFocus'()
    let ForegroundOnAccentRest'' = ForegroundOnAccentRest'()
    let ForegroundOnAccentHover'' = ForegroundOnAccentHover'()
    let ForegroundOnAccentActive'' = ForegroundOnAccentActive'()
    let ForegroundOnAccentFocus'' = ForegroundOnAccentFocus'()
    let AccentForegroundRest'' = AccentForegroundRest'()
    let AccentForegroundHover'' = AccentForegroundHover'()
    let AccentForegroundActive'' = AccentForegroundActive'()
    let AccentForegroundFocus'' = AccentForegroundFocus'()
    let AccentStrokeControlRest'' = AccentStrokeControlRest'()
    let AccentStrokeControlHover'' = AccentStrokeControlHover'()
    let AccentStrokeControlActive'' = AccentStrokeControlActive'()
    let AccentStrokeControlFocus'' = AccentStrokeControlFocus'()
    let NeutralFillRest'' = NeutralFillRest'()
    let NeutralFillHover'' = NeutralFillHover'()
    let NeutralFillActive'' = NeutralFillActive'()
    let NeutralFillFocus'' = NeutralFillFocus'()
    let NeutralFillInputRest'' = NeutralFillInputRest'()
    let NeutralFillInputHover'' = NeutralFillInputHover'()
    let NeutralFillInputActive'' = NeutralFillInputActive'()
    let NeutralFillInputFocus'' = NeutralFillInputFocus'()
    let NeutralFillInputAltRest'' = NeutralFillInputAltRest'()
    let NeutralFillInputAltHover'' = NeutralFillInputAltHover'()
    let NeutralFillInputAltActive'' = NeutralFillInputAltActive'()
    let NeutralFillInputAltFocus'' = NeutralFillInputAltFocus'()
    let NeutralFillLayerRest'' = NeutralFillLayerRest'()
    let NeutralFillLayerHover'' = NeutralFillLayerHover'()
    let NeutralFillLayerActive'' = NeutralFillLayerActive'()
    let NeutralFillLayerAltRest'' = NeutralFillLayerAltRest'()
    let NeutralFillSecondaryRest'' = NeutralFillSecondaryRest'()
    let NeutralFillSecondaryHover'' = NeutralFillSecondaryHover'()
    let NeutralFillSecondaryActive'' = NeutralFillSecondaryActive'()
    let NeutralFillSecondaryFocus'' = NeutralFillSecondaryFocus'()
    let NeutralFillStealthRest'' = NeutralFillStealthRest'()
    let NeutralFillStealthHover'' = NeutralFillStealthHover'()
    let NeutralFillStealthActive'' = NeutralFillStealthActive'()
    let NeutralFillStealthFocus'' = NeutralFillStealthFocus'()
    let NeutralFillStrongRest'' = NeutralFillStrongRest'()
    let NeutralFillStrongHover'' = NeutralFillStrongHover'()
    let NeutralFillStrongActive'' = NeutralFillStrongActive'()
    let NeutralFillStrongFocus'' = NeutralFillStrongFocus'()
    let NeutralForegroundRest'' = NeutralForegroundRest'()
    let NeutralForegroundHover'' = NeutralForegroundHover'()
    let NeutralForegroundActive'' = NeutralForegroundActive'()
    let NeutralForegroundFocus'' = NeutralForegroundFocus'()
    let NeutralForegroundHint'' = NeutralForegroundHint'()
    let NeutralStrokeRest'' = NeutralStrokeRest'()
    let NeutralStrokeHover'' = NeutralStrokeHover'()
    let NeutralStrokeActive'' = NeutralStrokeActive'()
    let NeutralStrokeFocus'' = NeutralStrokeFocus'()
    let NeutralStrokeControlRest'' = NeutralStrokeControlRest'()
    let NeutralStrokeControlHover'' = NeutralStrokeControlHover'()
    let NeutralStrokeControlActive'' = NeutralStrokeControlActive'()
    let NeutralStrokeControlFocus'' = NeutralStrokeControlFocus'()
    let NeutralStrokeDividerRest'' = NeutralStrokeDividerRest'()
    let NeutralStrokeInputRest'' = NeutralStrokeInputRest'()
    let NeutralStrokeInputHover'' = NeutralStrokeInputHover'()
    let NeutralStrokeInputActive'' = NeutralStrokeInputActive'()
    let NeutralStrokeInputFocus'' = NeutralStrokeInputFocus'()
    let NeutralStrokeLayerRest'' = NeutralStrokeLayerRest'()
    let NeutralStrokeLayerHover'' = NeutralStrokeLayerHover'()
    let NeutralStrokeLayerActive'' = NeutralStrokeLayerActive'()
    let NeutralStrokeStrongRest'' = NeutralStrokeStrongRest'()
    let NeutralStrokeStrongHover'' = NeutralStrokeStrongHover'()
    let NeutralStrokeStrongActive'' = NeutralStrokeStrongActive'()
    let NeutralStrokeStrongFocus'' = NeutralStrokeStrongFocus'()
    let FocusStrokeOuter'' = FocusStrokeOuter'()
    let FocusStrokeInner'' = FocusStrokeInner'()
            
namespace Microsoft.FluentUI.AspNetCore.Components.DataGrid.Infrastructure

[<AutoOpen>]
module DslCE =
  
    open System.Diagnostics.CodeAnalysis
    open Microsoft.FluentUI.AspNetCore.Components.DslInternals.DataGrid.Infrastructure


    /// For internal use only. Do not use.
    type Defer' 
        /// For internal use only. Do not use.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.FluentUI.AspNetCore.Components.DataGrid.Infrastructure.Defer>)>] () = inherit DeferBuilder<Microsoft.FluentUI.AspNetCore.Components.DataGrid.Infrastructure.Defer>()

[<AutoOpen>]
module DslCEInstances =
  
    open System.Diagnostics.CodeAnalysis
    open Microsoft.FluentUI.AspNetCore.Components.DslInternals.DataGrid.Infrastructure

    let Defer'' = Defer'()
            