namespace rec Microsoft.FluentUI.AspNetCore.Components.DslInternals

open System.Threading.Tasks
open FSharp.Data.Adaptive
open Fun.Blazor
open Fun.Blazor.Operators
open Microsoft.FluentUI.AspNetCore.Components.DslInternals

/// Base class for FluentUI Blazor components.
type FluentComponentBaseBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAndChildAttrBuilder<'FunBlazorGeneric>()
    /// Gets or sets the unique identifier.
    /// The value will be used as the HTML global id attribute.
    [<CustomOperation("Id")>] member inline _.Id ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Id" => x)
    /// Gets or sets the component CSS margin property.
    [<CustomOperation("Margin")>] member inline _.Margin ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Margin" => x)
    /// Gets or sets the component CSS padding property.
    [<CustomOperation("Padding")>] member inline _.Padding ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Padding" => x)
    /// Gets or sets custom data, to attach any user data object to the component.
    [<CustomOperation("Data")>] member inline _.Data ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Object) = render ==> ("Data" => x)
    /// Gets or sets a collection of additional attributes that will be applied to the created element.
    [<CustomOperation("AdditionalAttributes")>] member inline _.AdditionalAttributes ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.IReadOnlyDictionary<System.String, System.Object>) = render ==> ("AdditionalAttributes" => x)

/// The FluentBadge component is a visual indicator that communicates a status or description of an associated component.
/// It uses short text, color, and icons for quick recognition and is placed near the relevant content.
type FluentBadgeBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentComponentBaseBuilder<'FunBlazorGeneric>()
    /// Gets or sets the text content displayed inside the badge (e.g., Content="New").
    /// For structured content, use ChildContent instead.
    [<CustomOperation("Content")>] member inline _.Content ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Content" => x)
    /// Gets or sets the color of the badge (e.g., Color="BadgeColor.Brand").
    /// When using BackgroundColor, set this to null.
    [<CustomOperation("Color")>] member inline _.Color ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<Microsoft.FluentUI.AspNetCore.Components.BadgeColor>) = render ==> ("Color" => x)
    /// Gets or sets the background color.
    /// Must be a valid CSS color value.
    /// When using BackgroundColor, Color must be explicitly set to null
    [<CustomOperation("BackgroundColor")>] member inline _.BackgroundColor ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("BackgroundColor" => x)
    /// Gets or sets the visual appearance.
    [<CustomOperation("Appearance")>] member inline _.Appearance ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<Microsoft.FluentUI.AspNetCore.Components.BadgeAppearance>) = render ==> ("Appearance" => x)
    /// Gets or sets the shape of the badge.
    [<CustomOperation("Shape")>] member inline _.Shape ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<Microsoft.FluentUI.AspNetCore.Components.BadgeShape>) = render ==> ("Shape" => x)
    /// Gets or sets the size of the badge.
    [<CustomOperation("Size")>] member inline _.Size ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<Microsoft.FluentUI.AspNetCore.Components.BadgeSize>) = render ==> ("Size" => x)
    /// Gets or sets the content to attach the badge to.
    /// When this parameter is set, the badge will be rendered as an anchored badge, using the Positioning parameter.
    /// When this parameter is not set, the badge will be rendered as a standalone badge.
    [<CustomOperation("AnchorContent")>] member inline _.AnchorContent ([<InlineIfLambda>] render: AttrRenderFragment, fragment: NodeRenderFragment) = render ==> html.renderFragment("AnchorContent", fragment)
    /// Gets or sets the content to attach the badge to.
    /// When this parameter is set, the badge will be rendered as an anchored badge, using the Positioning parameter.
    /// When this parameter is not set, the badge will be rendered as a standalone badge.
    [<CustomOperation("AnchorContent")>] member inline _.AnchorContent ([<InlineIfLambda>] render: AttrRenderFragment, fragments: NodeRenderFragment seq) = render ==> html.renderFragment("AnchorContent", fragment { yield! fragments })
    /// Gets or sets the content to attach the badge to.
    /// When this parameter is set, the badge will be rendered as an anchored badge, using the Positioning parameter.
    /// When this parameter is not set, the badge will be rendered as a standalone badge.
    [<CustomOperation("AnchorContent")>] member inline _.AnchorContent ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("AnchorContent", html.text x)
    /// Gets or sets the content to attach the badge to.
    /// When this parameter is set, the badge will be rendered as an anchored badge, using the Positioning parameter.
    /// When this parameter is not set, the badge will be rendered as a standalone badge.
    [<CustomOperation("AnchorContent")>] member inline _.AnchorContent ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("AnchorContent", html.text x)
    /// Gets or sets the content to attach the badge to.
    /// When this parameter is set, the badge will be rendered as an anchored badge, using the Positioning parameter.
    /// When this parameter is not set, the badge will be rendered as a standalone badge.
    [<CustomOperation("AnchorContent")>] member inline _.AnchorContent ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("AnchorContent", html.text x)
    /// Gets or sets the Icon displayed at the start of badge content.
    [<CustomOperation("IconStart")>] member inline _.IconStart ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.FluentUI.AspNetCore.Components.Icon) = render ==> ("IconStart" => x)
    /// Gets or sets the aria-label attribute applied to the icon(s) rendered in the badge
    /// (e.g., IconLabel="New notifications").
    [<CustomOperation("IconLabel")>] member inline _.IconLabel ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("IconLabel" => x)
    /// Gets or sets the Icon displayed at the end of badge content.
    [<CustomOperation("IconEnd")>] member inline _.IconEnd ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.FluentUI.AspNetCore.Components.Icon) = render ==> ("IconEnd" => x)
    /// Gets or sets the badge's positioning relative to the AnchorContent.
    /// The default value is `null`. Internally the component uses AboveEnd as its default value.
    [<CustomOperation("Positioning")>] member inline _.Positioning ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<Microsoft.FluentUI.AspNetCore.Components.Positioning>) = render ==> ("Positioning" => x)
    /// Gets or sets how much the badge overlaps the content it wraps on the x-axis.
    /// Only applied when AnchorContent is not null
    [<CustomOperation("OffsetX")>] member inline _.OffsetX ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.SByte>) = render ==> ("OffsetX" => x)
    /// Gets or sets how much the badge overlaps the content it wraps on the y-axis.
    /// Only applied when AnchorContent is not null
    [<CustomOperation("OffsetY")>] member inline _.OffsetY ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.SByte>) = render ==> ("OffsetY" => x)

/// The FluentCounterBadge component is a visual indicator that communicates a value about an associated component.
/// It uses short postive numbers, color, and icons for quick recognition and is placed near the relevant content.
type FluentCounterBadgeBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentBadgeBuilder<'FunBlazorGeneric>()
    /// Gets or sets whether the badge renders as a small dot without any text content (e.g., Dot="true").
    [<CustomOperation("Dot")>] member inline _.Dot ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Dot" =>>> true)
    /// Gets or sets whether the badge renders as a small dot without any text content (e.g., Dot="true").
    [<CustomOperation("Dot")>] member inline _.Dot ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Dot" =>>> x)
    /// Gets or sets whether the badge is visible when Count is zero (e.g., ShowZero="true").
    [<CustomOperation("ShowZero")>] member inline _.ShowZero ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Boolean>) = render ==> ("ShowZero" => x)
    /// Gets or sets whether to render the badge when there is no meaningful content to display (no count, no dot).
    /// It is overruled by Dot=true or ShowWhen returning true.
    [<CustomOperation("ShowEmpty")>] member inline _.ShowEmpty ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("ShowEmpty" =>>> true)
    /// Gets or sets whether to render the badge when there is no meaningful content to display (no count, no dot).
    /// It is overruled by Dot=true or ShowWhen returning true.
    [<CustomOperation("ShowEmpty")>] member inline _.ShowEmpty ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("ShowEmpty" =>>> x)
    /// Gets or sets if the badge displays the count based on the specified lambda expression.
    /// By default the badge only shows a count when it's greater than 0.
    /// For example, to show the count on the badge when the count greater than 4, use ShowWhen=@(Count => Count > 4)
    [<CustomOperation("ShowWhen")>] member inline _.ShowWhen ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("ShowWhen" => (System.Func<System.Nullable<System.Int32>, System.Boolean>fn))
    /// Gets or sets the badge's count.
    /// The default value is `null`. Internally the component uses 0 as its default value.
    /// With ShowZero being false by default, the default result will be an empty counter badge
    [<CustomOperation("Count")>] member inline _.Count ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Int32>) = render ==> ("Count" => x)
    /// Gets or sets the maximum count value displayed before showing an overflow indicator (e.g., OverflowCount="99").
    /// When Count exceeds this value, the badge displays the overflow count followed by a "+" sign.
    /// The default value is null; the component uses 99 as its internal default.
    [<CustomOperation("OverflowCount")>] member inline _.OverflowCount ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Int32>) = render ==> ("OverflowCount" => x)

/// The FluentButton component allows users to commit a change or trigger an action via a single click or tap and
/// is often found inside forms, dialogs, drawers (panels) or pages.
type FluentButtonBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentComponentBaseBuilder<'FunBlazorGeneric>()
    /// Gets or sets whether the button should be focused when the page is loaded.
    [<CustomOperation("AutoFocus")>] member inline _.AutoFocus ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("AutoFocus" =>>> true)
    /// Gets or sets whether the button should be focused when the page is loaded.
    [<CustomOperation("AutoFocus")>] member inline _.AutoFocus ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("AutoFocus" =>>> x)
    /// Gets or sets the id of a form to associate the element to.
    [<CustomOperation("FormId")>] member inline _.FormId ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("FormId" => x)
    /// Gets or sets the URL that processes the information submitted by the button.
    [<CustomOperation("FormAction")>] member inline _.FormAction ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("FormAction" => x)
    /// Gets or sets how to encode the form data that is submitted
    /// (if the button is a submit button).
    [<CustomOperation("FormEncType")>] member inline _.FormEncType ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("FormEncType" => x)
    /// Gets or sets the HTTP method used to submit the form
    /// (if the button is a submit button).
    [<CustomOperation("FormMethod")>] member inline _.FormMethod ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("FormMethod" => x)
    /// Gets or sets a value indicating whether form validation is bypassed when this button submits the form
    /// (if the button is a submit button). When true, the form's validation constraints are not checked on submission.
    [<CustomOperation("FormNoValidate")>] member inline _.FormNoValidate ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Boolean>) = render ==> ("FormNoValidate" => x)
    /// Gets or sets the author-defined name or standardized, underscore-prefixed keyword indicating where to display the response from submitting the form.
    /// Possible values: `_self` | `_blank` | `_parent` | `_top`.
    [<CustomOperation("FormTarget")>] member inline _.FormTarget ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("FormTarget" => x)
    /// Gets or sets the button type. See ButtonType for more details.
    /// Default is `null`. Internally the component uses  Button as default.
    [<CustomOperation("Type")>] member inline _.Type ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<Microsoft.FluentUI.AspNetCore.Components.ButtonType>) = render ==> ("Type" => x)
    /// Gets or sets the shape of the button.
    /// Default is `null`. Internally the component uses Rounded as default.
    [<CustomOperation("Shape")>] member inline _.Shape ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<Microsoft.FluentUI.AspNetCore.Components.ButtonShape>) = render ==> ("Shape" => x)
    /// Gets or sets the size of the button.
    /// Default is `null`. Internally the component uses Medium as default.
    [<CustomOperation("Size")>] member inline _.Size ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<Microsoft.FluentUI.AspNetCore.Components.ButtonSize>) = render ==> ("Size" => x)
    /// Gets or sets the value associated with the button.
    /// This value is passed to the server in params when the form is submitted using this button.
    [<CustomOperation("Value")>] member inline _.Value ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Value" => x)
    /// Gets or sets the element's disabled state, ensuring it doesn't participate in form submission.
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Disabled" =>>> true)
    /// Gets or sets the element's disabled state, ensuring it doesn't participate in form submission.
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Disabled" =>>> x)
    /// Gets or sets a value indicating whether the button is disabled yet still reachable via keyboard focus.
    /// Unlike Disabled, a focusable-disabled button participates in the tab order and can expose tooltips.
    [<CustomOperation("DisabledFocusable")>] member inline _.DisabledFocusable ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("DisabledFocusable" =>>> true)
    /// Gets or sets a value indicating whether the button is disabled yet still reachable via keyboard focus.
    /// Unlike Disabled, a focusable-disabled button participates in the tab order and can expose tooltips.
    [<CustomOperation("DisabledFocusable")>] member inline _.DisabledFocusable ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("DisabledFocusable" =>>> x)
    /// Gets or sets the name of the element.
    /// Allows access by name from the associated form.
    [<CustomOperation("Name")>] member inline _.Name ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Name" => x)
    /// Gets or sets a value indicating whether the element needs to have a value.
    [<CustomOperation("Required")>] member inline _.Required ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Required" =>>> true)
    /// Gets or sets a value indicating whether the element needs to have a value.
    [<CustomOperation("Required")>] member inline _.Required ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Required" =>>> x)
    /// Gets or sets the visual appearance.
    /// Default is `null'. Internally the component uses Default as default.
    [<CustomOperation("Appearance")>] member inline _.Appearance ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<Microsoft.FluentUI.AspNetCore.Components.ButtonAppearance>) = render ==> ("Appearance" => x)
    /// Gets or sets the background color of this button (overrides the Appearance property).
    /// Set the value `rgba(0, 0, 0, 0)` to display a transparent button.
    [<CustomOperation("BackgroundColor")>] member inline _.BackgroundColor ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("BackgroundColor" => x)
    /// Gets or sets the color of the font (overrides the Appearance property).
    [<CustomOperation("Color")>] member inline _.Color ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Color" => x)
    /// Gets or sets whether to display a progress ring and disable the button.
    [<CustomOperation("Loading")>] member inline _.Loading ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Loading" =>>> true)
    /// Gets or sets whether to display a progress ring and disable the button.
    [<CustomOperation("Loading")>] member inline _.Loading ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Loading" =>>> x)
    /// Gets or sets a value indicating whether the button renders icon-only (no visible text label).
    /// Typically used when IconStart or IconEnd is set and no text label is needed.
    /// When using icon-only mode, provide an accessible name via Title or an aria-label attribute to ensure screen reader accessibility.
    [<CustomOperation("IconOnly")>] member inline _.IconOnly ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("IconOnly" =>>> true)
    /// Gets or sets a value indicating whether the button renders icon-only (no visible text label).
    /// Typically used when IconStart or IconEnd is set and no text label is needed.
    /// When using icon-only mode, provide an accessible name via Title or an aria-label attribute to ensure screen reader accessibility.
    [<CustomOperation("IconOnly")>] member inline _.IconOnly ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("IconOnly" =>>> x)
    /// Gets or sets the Icon displayed at the start of button content.
    [<CustomOperation("IconStart")>] member inline _.IconStart ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.FluentUI.AspNetCore.Components.Icon) = render ==> ("IconStart" => x)
    /// Gets or sets the Icon displayed at the end of button content.
    [<CustomOperation("IconEnd")>] member inline _.IconEnd ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.FluentUI.AspNetCore.Components.Icon) = render ==> ("IconEnd" => x)
    /// Gets or sets the title of the button.
    /// The text usually displayed in a `tooltip` popup on mouse hovering or keyboard focus.
    [<CustomOperation("Title")>] member inline _.Title ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Title" => x)
    /// Gets or sets the plain-text label rendered inside the button (e.g., Label="Submit").
    /// If both Label and ChildContent are set, both are rendered together.
    /// For rich content such as icons or custom markup, use ChildContent instead.
    [<CustomOperation("Label")>] member inline _.Label ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Label" => x)
    /// Gets or sets a way to prevent further propagation of the current event in the capturing and bubbling phases.
    [<CustomOperation("StopPropagation")>] member inline _.StopPropagation ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("StopPropagation" =>>> true)
    /// Gets or sets a way to prevent further propagation of the current event in the capturing and bubbling phases.
    [<CustomOperation("StopPropagation")>] member inline _.StopPropagation ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("StopPropagation" =>>> x)
    /// Command executed when the user clicks on the button.
    [<CustomOperation("OnClick")>] member inline _.OnClick ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.AspNetCore.Components.Web.MouseEventArgs -> unit) = render ==> html.callback("OnClick", fn)
    /// Command executed when the user clicks on the button.
    [<CustomOperation("OnClick")>] member inline _.OnClick ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.AspNetCore.Components.Web.MouseEventArgs -> Task<unit>) = render ==> html.callbackTask("OnClick", fn)
    /// Gets or sets the tooltip text (supports HTML tags).
    /// This parameter requires the presence of a 'FluentTooltipProvider' in your main/layout page.
    [<CustomOperation("Tooltip")>] member inline _.Tooltip ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Tooltip" => x)

/// The FluentToggleButton component allows users to commit a change or trigger a toggle action via a single click or tap and
/// is often found inside forms, dialogs, drawers (panels) and/or pages.
type FluentMenuButtonBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentButtonBuilder<'FunBlazorGeneric>()


/// The FluentToggleButton component allows users to commit a change or trigger a toggle action via a single click or tap and
/// is often found inside forms, dialogs, drawers (panels) and/or pages.
type FluentToggleButtonBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentButtonBuilder<'FunBlazorGeneric>()
    /// Gets or sets the mixed state of the component.
    [<CustomOperation("Mixed")>] member inline _.Mixed ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Mixed" =>>> true)
    /// Gets or sets the mixed state of the component.
    [<CustomOperation("Mixed")>] member inline _.Mixed ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Mixed" =>>> x)
    /// Gets or sets the pressed state of the button.
    [<CustomOperation("Pressed")>] member inline _.Pressed ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Pressed" =>>> true)
    /// Gets or sets the pressed state of the button.
    [<CustomOperation("Pressed")>] member inline _.Pressed ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Pressed" =>>> x)

/// The FluentLabel component is used to display a label for an input component. Normally it is positioned above the component
type FluentLabelBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentComponentBaseBuilder<'FunBlazorGeneric>()
    /// Gets or sets whether the label show a required marking (red star).
    [<CustomOperation("Required")>] member inline _.Required ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Required" =>>> true)
    /// Gets or sets whether the label show a required marking (red star).
    [<CustomOperation("Required")>] member inline _.Required ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Required" =>>> x)
    /// Gets or sets the size of the label.
    [<CustomOperation("Size")>] member inline _.Size ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<Microsoft.FluentUI.AspNetCore.Components.LabelSize>) = render ==> ("Size" => x)
    /// Gets or sets the weight of the label text.
    [<CustomOperation("Weight")>] member inline _.Weight ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<Microsoft.FluentUI.AspNetCore.Components.LabelWeight>) = render ==> ("Weight" => x)
    /// Gets or sets the disabled state of the label.
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Disabled" =>>> true)
    /// Gets or sets the disabled state of the label.
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Disabled" =>>> x)
    /// Gets or sets the tooltip text (supports HTML tags).
    /// This parameter requires the presence of a 'FluentTooltipProvider' in your main/layout page.
    [<CustomOperation("Tooltip")>] member inline _.Tooltip ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Tooltip" => x)

/// The FluentLabelInfo component extends FluentLabel by displaying an
/// informational icon next to the label. When the user clicks the icon, a popover
/// shows additional text, an optional action link, or a custom template.
type FluentLabelInfoBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentLabelBuilder<'FunBlazorGeneric>()
    /// Gets or sets the icon displayed next to the label to indicate that additional
    /// information is available. Defaults to a regular Info icon.
    [<CustomOperation("InfoIcon")>] member inline _.InfoIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.FluentUI.AspNetCore.Components.Icon) = render ==> ("InfoIcon" => x)
    /// Gets or sets the icon displayed when the info popover is hovered or open.
    /// Defaults to a filled Info icon.
    [<CustomOperation("InfoIconActive")>] member inline _.InfoIconActive ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.FluentUI.AspNetCore.Components.Icon) = render ==> ("InfoIconActive" => x)
    /// Gets or sets the informational text displayed inside the popover when the user
    /// clicks the info icon.
    [<CustomOperation("InfoText")>] member inline _.InfoText ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("InfoText" => x)
    /// Gets or sets the maximum width of the info popover. Can be any valid CSS width value, such as "200px" or "50%".
    /// If not set, the popover will size to fit its content (`fit-content`).
    [<CustomOperation("MaxWidth")>] member inline _.MaxWidth ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("MaxWidth" => x)
    /// Gets or sets the URL displayed as a "learn more" link inside the popover.
    [<CustomOperation("InfoActionLink")>] member inline _.InfoActionLink ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("InfoActionLink" => x)
    /// Gets or sets the text displayed as a "learn more" link inside the popover.
    [<CustomOperation("InfoActionText")>] member inline _.InfoActionText ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("InfoActionText" => x)
    /// Gets or sets the target for the "learn more" link inside the popover.
    /// Defaults to Blank to open the link in a new tab.
    [<CustomOperation("InfoActionTarget")>] member inline _.InfoActionTarget ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.FluentUI.AspNetCore.Components.LinkTarget) = render ==> ("InfoActionTarget" => x)
    /// Gets or sets a custom template rendered inside the popover.
    /// When set, InfoText and InfoActionLink are ignored.
    [<CustomOperation("InfoTemplate")>] member inline _.InfoTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragment: NodeRenderFragment) = render ==> html.renderFragment("InfoTemplate", fragment)
    /// Gets or sets a custom template rendered inside the popover.
    /// When set, InfoText and InfoActionLink are ignored.
    [<CustomOperation("InfoTemplate")>] member inline _.InfoTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragments: NodeRenderFragment seq) = render ==> html.renderFragment("InfoTemplate", fragment { yield! fragments })
    /// Gets or sets a custom template rendered inside the popover.
    /// When set, InfoText and InfoActionLink are ignored.
    [<CustomOperation("InfoTemplate")>] member inline _.InfoTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("InfoTemplate", html.text x)
    /// Gets or sets a custom template rendered inside the popover.
    /// When set, InfoText and InfoActionLink are ignored.
    [<CustomOperation("InfoTemplate")>] member inline _.InfoTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("InfoTemplate", html.text x)
    /// Gets or sets a custom template rendered inside the popover.
    /// When set, InfoText and InfoActionLink are ignored.
    [<CustomOperation("InfoTemplate")>] member inline _.InfoTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("InfoTemplate", html.text x)

/// Provides a base class for navigation items.
type FluentNavBaseBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentComponentBaseBuilder<'FunBlazorGeneric>()


/// Represents a group of related navigation items for use in a fluent navigation interface.
type FluentNavCategoryBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentNavBaseBuilder<'FunBlazorGeneric>()
    /// Gets or sets the title of the nav menu group.
    [<CustomOperation("Title")>] member inline _.Title ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Title" => x)
    /// Gets or sets additional class names to style the category item when it is active, separated by space. An active
    /// category item always has the "active" class applied, so this property allows for additional styling.
    [<CustomOperation("ActiveClass")>] member inline _.ActiveClass ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("ActiveClass" => x)
    /// Gets or sets the icon displayed when the category is in its default (resting) state.
    /// Use IconActive to specify the icon shown when the category is hovered, selected, or active.
    [<CustomOperation("IconRest")>] member inline _.IconRest ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.FluentUI.AspNetCore.Components.Icon) = render ==> ("IconRest" => x)
    /// Gets or sets the icon displayed when the category is hovered, selected, or active.
    /// Use IconRest to specify the icon shown in the default (resting) state.
    [<CustomOperation("IconActive")>] member inline _.IconActive ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.FluentUI.AspNetCore.Components.Icon) = render ==> ("IconActive" => x)
    /// Gets or sets the expanded state of the nav menu group.
    [<CustomOperation("Expanded")>] member inline _.Expanded ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Expanded" =>>> true)
    /// Gets or sets the expanded state of the nav menu group.
    [<CustomOperation("Expanded")>] member inline _.Expanded ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Expanded" =>>> x)
    /// Gets or sets the expanded state of the nav menu group.
    [<CustomOperation("Expanded'")>] member inline _.Expanded' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.Boolean * (System.Boolean -> unit)) = render ==> html.bind("Expanded", valueFn)
    /// Gets or sets the callback that is invoked when the expanded state changes.
    [<CustomOperation("ExpandedChanged")>] member inline _.ExpandedChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Boolean -> unit) = render ==> html.callback("ExpandedChanged", fn)
    /// Gets or sets the callback that is invoked when the expanded state changes.
    [<CustomOperation("ExpandedChanged")>] member inline _.ExpandedChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Boolean -> Task<unit>) = render ==> html.callbackTask("ExpandedChanged", fn)
    /// Gets or sets the tooltip to display when the mouse is placed over the item.
    [<CustomOperation("Tooltip")>] member inline _.Tooltip ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Tooltip" => x)

/// Represents a navigation menu item that renders content within a Fluent UI styled navigation link.
type FluentNavItemBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentNavBaseBuilder<'FunBlazorGeneric>()
    /// Gets or sets the icon displayed when the item is in its default (resting) state.
    /// Use IconActive to specify the icon shown when the item is hovered, selected, or active.
    [<CustomOperation("IconRest")>] member inline _.IconRest ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.FluentUI.AspNetCore.Components.Icon) = render ==> ("IconRest" => x)
    /// Gets or sets the icon displayed when the item is hovered, selected, or active.
    /// Use IconRest to specify the icon shown in the default (resting) state.
    [<CustomOperation("IconActive")>] member inline _.IconActive ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.FluentUI.AspNetCore.Components.Icon) = render ==> ("IconActive" => x)
    /// Gets or sets the navigation URL for the item (e.g., Href="/dashboard").
    /// When set, the item renders as an anchor element.
    [<CustomOperation("Href")>] member inline _.Href ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Href" => x)
    /// Gets or sets the callback invoked when the item is clicked.
    [<CustomOperation("OnClick")>] member inline _.OnClick ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.AspNetCore.Components.Web.MouseEventArgs -> unit) = render ==> html.callback("OnClick", fn)
    /// Gets or sets the callback invoked when the item is clicked.
    [<CustomOperation("OnClick")>] member inline _.OnClick ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.AspNetCore.Components.Web.MouseEventArgs -> Task<unit>) = render ==> html.callbackTask("OnClick", fn)
    /// Gets or sets whether the item is disabled.
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Disabled" =>>> true)
    /// Gets or sets whether the item is disabled.
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Disabled" =>>> x)
    /// Gets or sets the target attribute that specifies where to open the link when Href is set
    /// (e.g., Target="LinkTarget.Blank" to open in a new tab).
    [<CustomOperation("Target")>] member inline _.Target ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<Microsoft.FluentUI.AspNetCore.Components.LinkTarget>) = render ==> ("Target" => x)
    /// Gets or sets the class names to use to indicate the item is active, separated by space.
    [<CustomOperation("ActiveClass")>] member inline _.ActiveClass ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("ActiveClass" => x)
    /// Gets or sets how the link should be matched.
    /// Defaults to Prefix.
    [<CustomOperation("Match")>] member inline _.Match ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.AspNetCore.Components.Routing.NavLinkMatch) = render ==> ("Match" => x)
    /// Gets or sets the tooltip to display when the mouse is placed over the item.
    [<CustomOperation("Tooltip")>] member inline _.Tooltip ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Tooltip" => x)

/// Visual representation of content being loaded or processed.
type FluentProgressBarBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentComponentBaseBuilder<'FunBlazorGeneric>()
    /// Gets or sets the minimum value (e.g., Min="0").
    /// See also Max.
    [<CustomOperation("Min")>] member inline _.Min ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Int32>) = render ==> ("Min" => x)
    /// Gets or sets the maximum value (e.g., Max="100").
    /// The progress bar will be full when Value equals this.
    /// See also Min.
    [<CustomOperation("Max")>] member inline _.Max ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Int32>) = render ==> ("Max" => x)
    /// Gets or sets the shape of the progress bar: rounded or square.
    [<CustomOperation("Shape")>] member inline _.Shape ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<Microsoft.FluentUI.AspNetCore.Components.ProgressShape>) = render ==> ("Shape" => x)
    /// Gets or sets the current progress value (e.g., Value="75").
    /// If null (default), the bar displays an indeterminate state.
    /// Must be between Min and Max.
    [<CustomOperation("Value")>] member inline _.Value ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Int32>) = render ==> ("Value" => x)
    /// Gets or sets the visibility of the component.
    /// If `true` (default), the component is visible.
    /// If `false`, the component is hidden.
    /// If `null`, the component is hidden and not rendered.
    [<CustomOperation("Visible")>] member inline _.Visible ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Boolean>) = render ==> ("Visible" => x)
    /// Gets or sets the component width.
    [<CustomOperation("Width")>] member inline _.Width ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Width" => x)
    /// Gets or sets the validation state of the progress bar: Success, Warning or Error.
    [<CustomOperation("State")>] member inline _.State ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<Microsoft.FluentUI.AspNetCore.Components.ProgressState>) = render ==> ("State" => x)
    /// Gets or sets the background color of the progress bar.
    [<CustomOperation("BackgroundColor")>] member inline _.BackgroundColor ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("BackgroundColor" => x)
    /// Gets or sets the color of the progress bar indicator (e.g., Color="#0078d4").
    /// Ignored when State is set.
    [<CustomOperation("Color")>] member inline _.Color ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Color" => x)
    /// Gets or sets the stroke width of the progress bar.
    /// If not set, the default theme stroke width is used.
    [<CustomOperation("Stroke")>] member inline _.Stroke ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<Microsoft.FluentUI.AspNetCore.Components.ProgressStroke>) = render ==> ("Stroke" => x)
    /// Gets or sets the visual thickness of the progress bar track (e.g., Thickness="ProgressThickness.Large").
    /// If not set, the default theme thickness is used.
    [<CustomOperation("Thickness")>] member inline _.Thickness ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<Microsoft.FluentUI.AspNetCore.Components.ProgressThickness>) = render ==> ("Thickness" => x)
    /// Gets or sets the tooltip text (supports HTML tags).
    /// This parameter requires the presence of a 'FluentTooltipProvider' in your main/layout page.
    [<CustomOperation("Tooltip")>] member inline _.Tooltip ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Tooltip" => x)

/// Visual representation of content being loaded or processed.
/// This component is renamed to FluentProgressBar and will be removed in a future release.
type FluentProgressBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentProgressBarBuilder<'FunBlazorGeneric>()


/// A spinner alerts a user that content is being loaded or processed and they should wait for the activity to complete.
type FluentSpinnerBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentComponentBaseBuilder<'FunBlazorGeneric>()
    /// Gets or sets the visibility of the component.
    /// If `true` (default), the component is visible.
    /// If `false`, the component is hidden.
    /// If `null`, the component is hidden and not rendered.
    [<CustomOperation("Visible")>] member inline _.Visible ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Boolean>) = render ==> ("Visible" => x)
    /// Gets or sets a value indicating whether the spinner should be shown in an inverted color scheme
    /// (e.g., AppearanceInverted="true" for a light spinner on a dark background).
    [<CustomOperation("AppearanceInverted")>] member inline _.AppearanceInverted ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("AppearanceInverted" =>>> true)
    /// Gets or sets a value indicating whether the spinner should be shown in an inverted color scheme
    /// (e.g., AppearanceInverted="true" for a light spinner on a dark background).
    [<CustomOperation("AppearanceInverted")>] member inline _.AppearanceInverted ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("AppearanceInverted" =>>> x)
    /// Gets or sets the size of the spinner. Default is Medium.
    [<CustomOperation("Size")>] member inline _.Size ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<Microsoft.FluentUI.AspNetCore.Components.SpinnerSize>) = render ==> ("Size" => x)
    /// Gets or sets the tooltip text (supports HTML tags).
    /// This parameter requires the presence of a 'FluentTooltipProvider' in your main/layout page.
    [<CustomOperation("Tooltip")>] member inline _.Tooltip ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Tooltip" => x)
    /// Gets or sets the stroke width of the progress bar.
    /// If not set, the default theme stroke width is used.
    [<CustomOperation("Stroke")>] member inline _.Stroke ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<Microsoft.FluentUI.AspNetCore.Components.ProgressStroke>) = render ==> ("Stroke" => x)

/// A spinner alerts a user that content is being loaded or processed and they should wait for the activity to complete.
/// This component is renamed to FluentSpinner and will be removed in a future release.
type FluentProgressRingBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentSpinnerBuilder<'FunBlazorGeneric>()


/// The FluentAccordion component allows to toggle the display of content by expanding or collapsing sections.
type FluentAccordionBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentComponentBaseBuilder<'FunBlazorGeneric>()
    /// Controls the expand mode of the Accordion, either allowing
    /// single or multiple item expansion. AccordionExpandMode.
    [<CustomOperation("ExpandMode")>] member inline _.ExpandMode ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<Microsoft.FluentUI.AspNetCore.Components.AccordionExpandMode>) = render ==> ("ExpandMode" => x)
    /// Controls the expand mode of the Accordion, either allowing
    /// single or multiple item expansion. AccordionExpandMode.
    [<CustomOperation("ExpandMode'")>] member inline _.ExpandMode' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.Nullable<Microsoft.FluentUI.AspNetCore.Components.AccordionExpandMode> * (System.Nullable<Microsoft.FluentUI.AspNetCore.Components.AccordionExpandMode> -> unit)) = render ==> html.bind("ExpandMode", valueFn)
    /// Gets or sets a callback when the expand mode is changed.
    [<CustomOperation("ExpandModeChanged")>] member inline _.ExpandModeChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Nullable<Microsoft.FluentUI.AspNetCore.Components.AccordionExpandMode> -> unit) = render ==> html.callback("ExpandModeChanged", fn)
    /// Gets or sets a callback when the expand mode is changed.
    [<CustomOperation("ExpandModeChanged")>] member inline _.ExpandModeChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Nullable<Microsoft.FluentUI.AspNetCore.Components.AccordionExpandMode> -> Task<unit>) = render ==> html.callbackTask("ExpandModeChanged", fn)
    /// Gets or sets the level of the heading element.
    /// Possible values: 1 | 2 | 3 | 4 | 5 | 6
    [<CustomOperation("HeadingLevel")>] member inline _.HeadingLevel ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Int32>) = render ==> ("HeadingLevel" => x)
    /// Gets or sets the size of the accordion item.
    [<CustomOperation("Size")>] member inline _.Size ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<Microsoft.FluentUI.AspNetCore.Components.AccordionItemSize>) = render ==> ("Size" => x)
    /// Gets or sets the position of the expand/collapse marker.
    [<CustomOperation("MarkerPosition")>] member inline _.MarkerPosition ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<Microsoft.FluentUI.AspNetCore.Components.AccordionItemMarkerPosition>) = render ==> ("MarkerPosition" => x)
    /// Gets or sets whether accordion items expand to fill the full available width (block-level display).
    /// When null, the default component behavior applies (items do not expand to fill width).
    [<CustomOperation("Block")>] member inline _.Block ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Boolean>) = render ==> ("Block" => x)
    /// Gets or sets the id of the active accordion item.
    [<CustomOperation("ActiveId")>] member inline _.ActiveId ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("ActiveId" => x)
    /// Gets or sets the id of the active accordion item.
    [<CustomOperation("ActiveId'")>] member inline _.ActiveId' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.String * (System.String -> unit)) = render ==> html.bind("ActiveId", valueFn)
    /// Gets or sets a callback when the active id is changed.
    [<CustomOperation("ActiveIdChanged")>] member inline _.ActiveIdChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.String -> unit) = render ==> html.callback("ActiveIdChanged", fn)
    /// Gets or sets a callback when the active id is changed.
    [<CustomOperation("ActiveIdChanged")>] member inline _.ActiveIdChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.String -> Task<unit>) = render ==> html.callbackTask("ActiveIdChanged", fn)
    /// Gets or sets a callback when an accordion item is changed.
    [<CustomOperation("OnAccordionItemChange")>] member inline _.OnAccordionItemChange ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.FluentUI.AspNetCore.Components.AccordionItemEventArgs -> unit) = render ==> html.callback("OnAccordionItemChange", fn)
    /// Gets or sets a callback when an accordion item is changed.
    [<CustomOperation("OnAccordionItemChange")>] member inline _.OnAccordionItemChange ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.FluentUI.AspNetCore.Components.AccordionItemEventArgs -> Task<unit>) = render ==> html.callbackTask("OnAccordionItemChange", fn)

/// Represents an item in a Fluent Accordion component, allowing for customization of its heading, expanded state, and
/// content. It also manages its registration with the owning FluentTreeView and handles state changes.
///             
type FluentAccordionItemBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentComponentBaseBuilder<'FunBlazorGeneric>()
    /// Gets or sets the plain-text heading of the accordion item (e.g., Header="Section Title").
    /// Use either this or the HeaderTemplate parameter.
    /// If both are set, this parameter takes precedence.
    [<CustomOperation("Header")>] member inline _.Header ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Header" => x)
    /// Gets or sets the heading content of the accordion item.
    /// Use either this or the Header parameter."/>
    /// If both are set, this parameter will not be used.
    [<CustomOperation("HeaderTemplate")>] member inline _.HeaderTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragment: NodeRenderFragment) = render ==> html.renderFragment("HeaderTemplate", fragment)
    /// Gets or sets the heading content of the accordion item.
    /// Use either this or the Header parameter."/>
    /// If both are set, this parameter will not be used.
    [<CustomOperation("HeaderTemplate")>] member inline _.HeaderTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragments: NodeRenderFragment seq) = render ==> html.renderFragment("HeaderTemplate", fragment { yield! fragments })
    /// Gets or sets the heading content of the accordion item.
    /// Use either this or the Header parameter."/>
    /// If both are set, this parameter will not be used.
    [<CustomOperation("HeaderTemplate")>] member inline _.HeaderTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("HeaderTemplate", html.text x)
    /// Gets or sets the heading content of the accordion item.
    /// Use either this or the Header parameter."/>
    /// If both are set, this parameter will not be used.
    [<CustomOperation("HeaderTemplate")>] member inline _.HeaderTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("HeaderTemplate", html.text x)
    /// Gets or sets the heading content of the accordion item.
    /// Use either this or the Header parameter."/>
    /// If both are set, this parameter will not be used.
    [<CustomOperation("HeaderTemplate")>] member inline _.HeaderTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("HeaderTemplate", html.text x)
    /// Gets or sets the heading tooltip of the accordion item.
    [<CustomOperation("HeaderTooltip")>] member inline _.HeaderTooltip ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("HeaderTooltip" => x)
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
    [<CustomOperation("HeadingLevel")>] member inline _.HeadingLevel ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Int32>) = render ==> ("HeadingLevel" => x)
    /// Gets or sets whether the accordion item is disabled.
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Disabled" =>>> true)
    /// Gets or sets whether the accordion item is disabled.
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Disabled" =>>> x)
    /// Gets or sets the size of the accordion item.
    [<CustomOperation("Size")>] member inline _.Size ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<Microsoft.FluentUI.AspNetCore.Components.AccordionItemSize>) = render ==> ("Size" => x)
    /// Gets or sets the position of the expand/collapse marker.
    [<CustomOperation("MarkerPosition")>] member inline _.MarkerPosition ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<Microsoft.FluentUI.AspNetCore.Components.AccordionItemMarkerPosition>) = render ==> ("MarkerPosition" => x)
    /// Gets or sets whether this accordion item expands to fill the full available width (block-level display).
    /// When null, the value is inherited from the parent Block setting.
    [<CustomOperation("Block")>] member inline _.Block ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Boolean>) = render ==> ("Block" => x)

/// The FluentAppBar component is a native Blazor component that allows users to have an app bar like the one in Teams.
/// It is a container for app bar items, which can be either FluentAppBarItem or any other component that implements IAppBarItem.
/// AppBar items can overflow into a popover (with search capabilities) when there is not enough space to display them all.
type FluentAppBarBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentComponentBaseBuilder<'FunBlazorGeneric>()
    /// Gets or sets whether the popover shows a search box to filter overflowed items.
    [<CustomOperation("PopoverShowSearch")>] member inline _.PopoverShowSearch ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("PopoverShowSearch" =>>> true)
    /// Gets or sets whether the popover shows a search box to filter overflowed items.
    [<CustomOperation("PopoverShowSearch")>] member inline _.PopoverShowSearch ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("PopoverShowSearch" =>>> x)
    /// Gets or sets the Orientation of the app bar.
    [<CustomOperation("Orientation")>] member inline _.Orientation ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.FluentUI.AspNetCore.Components.Orientation) = render ==> ("Orientation" => x)
    /// Event to be called when the visibility of the popover changes.
    [<CustomOperation("PopoverVisibilityChanged")>] member inline _.PopoverVisibilityChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Boolean -> unit) = render ==> html.callback("PopoverVisibilityChanged", fn)
    /// Event to be called when the visibility of the popover changes.
    [<CustomOperation("PopoverVisibilityChanged")>] member inline _.PopoverVisibilityChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Boolean -> Task<unit>) = render ==> html.callbackTask("PopoverVisibilityChanged", fn)
    /// Gets or sets the collections of app bar items.
    /// Use either this or ChildContent to define the content of the app bar.
    [<CustomOperation("Items")>] member inline _.Items ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.IEnumerable<Microsoft.FluentUI.AspNetCore.Components.IAppBarItem>) = render ==> ("Items" => x)
    /// Gets or sets whether to hide the active bar on the side/bottom of the active item.
    [<CustomOperation("HideActiveIndicator")>] member inline _.HideActiveIndicator ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Boolean>) = render ==> ("HideActiveIndicator" => x)

/// AppBar item component for use within a FluentAppBar.
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

/// The FluentAvatar component is used to represent a user or entity. It can display an image, initials, or an icon.
type FluentAvatarBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentComponentBaseBuilder<'FunBlazorGeneric>()
    /// Gets or sets whether the avatar displays an active state indicator ring (e.g., Active="true").
    /// Use ActiveAppearance to control the visual style of the active indicator.
    [<CustomOperation("Active")>] member inline _.Active ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Boolean>) = render ==> ("Active" => x)
    /// Gets or sets the styled appearance of the avatar when the avatar is "active".
    [<CustomOperation("ActiveAppearance")>] member inline _.ActiveAppearance ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<Microsoft.FluentUI.AspNetCore.Components.AvatarActiveAppearance>) = render ==> ("ActiveAppearance" => x)
    /// Gets or sets the color of the avatar.
    [<CustomOperation("Color")>] member inline _.Color ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<Microsoft.FluentUI.AspNetCore.Components.AvatarColor>) = render ==> ("Color" => x)
    /// Gets or sets the default icon. The icon will only be shown when there is no image or initials available.
    [<CustomOperation("Icon")>] member inline _.Icon ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.FluentUI.AspNetCore.Components.Icon) = render ==> ("Icon" => x)
    /// Gets or sets the URL of the image displayed in the avatar (e.g., Image="/images/profile.jpg").
    /// The image takes precedence over Initials and Name-generated initials.
    [<CustomOperation("Image")>] member inline _.Image ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Image" => x)
    /// Gets or sets custom initials to display in the avatar (e.g., Initials="JD"),
    /// overriding the initials automatically generated from Name.
    [<CustomOperation("Initials")>] member inline _.Initials ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Initials" => x)
    /// Gets or sets the name of the person or entity represented by this avatar (e.g., Name="Jane Doe").
    /// The name is used to generate initials when no Image is set, and is also provided to accessibility tools.
    [<CustomOperation("Name")>] member inline _.Name ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Name" => x)
    /// Gets or sets the shape of the avatar.
    [<CustomOperation("Shape")>] member inline _.Shape ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<Microsoft.FluentUI.AspNetCore.Components.AvatarShape>) = render ==> ("Shape" => x)
    /// Gets or sets the size of the avatar (e.g., Size="AvatarSize.Size48").
    [<CustomOperation("Size")>] member inline _.Size ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<Microsoft.FluentUI.AspNetCore.Components.AvatarSize>) = render ==> ("Size" => x)
    /// Gets or sets the slot the avatar is displayed in.
    [<CustomOperation("Slot")>] member inline _.Slot ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Slot" => x)
    /// Gets or sets a command executed when the user clicks on the button.
    [<CustomOperation("OnClick")>] member inline _.OnClick ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.AspNetCore.Components.Web.MouseEventArgs -> unit) = render ==> html.callback("OnClick", fn)
    /// Gets or sets a command executed when the user clicks on the button.
    [<CustomOperation("OnClick")>] member inline _.OnClick ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.AspNetCore.Components.Web.MouseEventArgs -> Task<unit>) = render ==> html.callbackTask("OnClick", fn)
    /// Gets or sets the tooltip text (supports HTML tags).
    /// This parameter requires the presence of a 'FluentTooltipProvider' in your main/layout page.
    [<CustomOperation("Tooltip")>] member inline _.Tooltip ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Tooltip" => x)

/// The FluentPresenceBadge component is a visual indicator that communicates a user's presence status.
/// It displays a colored icon overlay typically attached to an avatar or similar element.
type FluentPresenceBadgeBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentComponentBaseBuilder<'FunBlazorGeneric>()
    /// Gets or sets the presence status.
    [<CustomOperation("Status")>] member inline _.Status ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<Microsoft.FluentUI.AspNetCore.Components.PresenceStatus>) = render ==> ("Status" => x)
    /// Gets or sets whether the presence badge indicates an out-of-office state.
    /// When true, adjusts the displayed icon to reflect the out-of-office variant of the current Status.
    [<CustomOperation("OutOfOffice")>] member inline _.OutOfOffice ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("OutOfOffice" =>>> true)
    /// Gets or sets whether the presence badge indicates an out-of-office state.
    /// When true, adjusts the displayed icon to reflect the out-of-office variant of the current Status.
    [<CustomOperation("OutOfOffice")>] member inline _.OutOfOffice ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("OutOfOffice" =>>> x)
    /// Gets or sets the content to attach the badge to.
    /// When this parameter is set, the badge will be rendered as an anchored badge, using the Positioning parameter.
    /// When this parameter is not set, the badge will be rendered as a standalone badge.
    [<CustomOperation("AnchorContent")>] member inline _.AnchorContent ([<InlineIfLambda>] render: AttrRenderFragment, fragment: NodeRenderFragment) = render ==> html.renderFragment("AnchorContent", fragment)
    /// Gets or sets the content to attach the badge to.
    /// When this parameter is set, the badge will be rendered as an anchored badge, using the Positioning parameter.
    /// When this parameter is not set, the badge will be rendered as a standalone badge.
    [<CustomOperation("AnchorContent")>] member inline _.AnchorContent ([<InlineIfLambda>] render: AttrRenderFragment, fragments: NodeRenderFragment seq) = render ==> html.renderFragment("AnchorContent", fragment { yield! fragments })
    /// Gets or sets the content to attach the badge to.
    /// When this parameter is set, the badge will be rendered as an anchored badge, using the Positioning parameter.
    /// When this parameter is not set, the badge will be rendered as a standalone badge.
    [<CustomOperation("AnchorContent")>] member inline _.AnchorContent ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("AnchorContent", html.text x)
    /// Gets or sets the content to attach the badge to.
    /// When this parameter is set, the badge will be rendered as an anchored badge, using the Positioning parameter.
    /// When this parameter is not set, the badge will be rendered as a standalone badge.
    [<CustomOperation("AnchorContent")>] member inline _.AnchorContent ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("AnchorContent", html.text x)
    /// Gets or sets the content to attach the badge to.
    /// When this parameter is set, the badge will be rendered as an anchored badge, using the Positioning parameter.
    /// When this parameter is not set, the badge will be rendered as a standalone badge.
    [<CustomOperation("AnchorContent")>] member inline _.AnchorContent ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("AnchorContent", html.text x)
    /// Gets or sets an icon override for the badge.
    /// By default the icon is automatically chosen based on Status and OutOfOffice.
    [<CustomOperation("Icon")>] member inline _.Icon ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.FluentUI.AspNetCore.Components.Icon) = render ==> ("Icon" => x)
    /// Gets or sets the size of the badge.
    [<CustomOperation("Size")>] member inline _.Size ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<Microsoft.FluentUI.AspNetCore.Components.BadgeSize>) = render ==> ("Size" => x)
    /// Gets or sets the badge's positioning relative to the AnchorContent.
    /// The default value is `null`. Internally the component uses AboveEnd as its default value.
    [<CustomOperation("Positioning")>] member inline _.Positioning ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<Microsoft.FluentUI.AspNetCore.Components.Positioning>) = render ==> ("Positioning" => x)

/// A FluentUI AnchorButton component.
type FluentAnchorButtonBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentComponentBaseBuilder<'FunBlazorGeneric>()
    /// Gets or sets the href of the Anchor.
    [<CustomOperation("Href")>] member inline _.Href ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Href" => x)
    /// Gets or sets the target of the Anchor.
    [<CustomOperation("Target")>] member inline _.Target ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<Microsoft.FluentUI.AspNetCore.Components.LinkTarget>) = render ==> ("Target" => x)
    /// Gets or sets the language of the referenced resource.
    [<CustomOperation("HrefLang")>] member inline _.HrefLang ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("HrefLang" => x)
    /// Gets or sets the rel attribute.
    [<CustomOperation("Rel")>] member inline _.Rel ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Rel" => x)
    /// Gets or sets the referrer policy.
    [<CustomOperation("ReferrerPolicy")>] member inline _.ReferrerPolicy ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("ReferrerPolicy" => x)
    /// Gets or sets the type attribute.
    [<CustomOperation("Type")>] member inline _.Type ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Type" => x)
    /// Gets or sets the shape of the button.
    /// The default value is `null`. Internally the component uses Rounded as its default value.
    [<CustomOperation("Shape")>] member inline _.Shape ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<Microsoft.FluentUI.AspNetCore.Components.ButtonShape>) = render ==> ("Shape" => x)
    /// Gets or sets the size of the button.
    /// The default value is `null`. Internally the component uses Medium as its default value.
    [<CustomOperation("Size")>] member inline _.Size ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<Microsoft.FluentUI.AspNetCore.Components.ButtonSize>) = render ==> ("Size" => x)
    /// Gets or sets the name of the element.
    /// Allows access by name from the associated form.
    [<CustomOperation("Name")>] member inline _.Name ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Name" => x)
    /// Gets or sets the visual appearance.
    /// The default value is `null`. Internally the component uses Outline as its default value.
    [<CustomOperation("Appearance")>] member inline _.Appearance ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<Microsoft.FluentUI.AspNetCore.Components.ButtonAppearance>) = render ==> ("Appearance" => x)
    /// Gets or sets the background color of this button (overrides the Appearance property).
    /// Set the value `rgba(0, 0, 0, 0)` to display a transparent button.
    [<CustomOperation("BackgroundColor")>] member inline _.BackgroundColor ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("BackgroundColor" => x)
    /// Gets or sets the color of the font (overrides the Appearance property).
    [<CustomOperation("Color")>] member inline _.Color ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Color" => x)
    /// Gets or sets a value indicating whether the button renders icon-only (no visible text label).
    /// Typically used when IconStart or IconEnd is set and no text label is needed.
    /// When using icon-only mode, provide an accessible name via Title or an aria-label attribute to ensure screen reader accessibility.
    [<CustomOperation("IconOnly")>] member inline _.IconOnly ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("IconOnly" =>>> true)
    /// Gets or sets a value indicating whether the button renders icon-only (no visible text label).
    /// Typically used when IconStart or IconEnd is set and no text label is needed.
    /// When using icon-only mode, provide an accessible name via Title or an aria-label attribute to ensure screen reader accessibility.
    [<CustomOperation("IconOnly")>] member inline _.IconOnly ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("IconOnly" =>>> x)
    /// Gets or sets the Icon displayed at the start of button content.
    [<CustomOperation("IconStart")>] member inline _.IconStart ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.FluentUI.AspNetCore.Components.Icon) = render ==> ("IconStart" => x)
    /// Gets or sets the Icon displayed at the end of button content.
    [<CustomOperation("IconEnd")>] member inline _.IconEnd ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.FluentUI.AspNetCore.Components.Icon) = render ==> ("IconEnd" => x)
    /// Gets or sets the title of the button.
    /// The text usually displayed in a `tooltip` popup when the mouse is over the button.
    [<CustomOperation("Title")>] member inline _.Title ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Title" => x)
    /// Gets or sets the plain-text label rendered inside the button (e.g., Label="Go").
    /// If both Label and ChildContent are set, both are rendered together.
    /// For rich content such as icons or custom markup, use ChildContent instead.
    [<CustomOperation("Label")>] member inline _.Label ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Label" => x)
    /// Gets or sets the tooltip text (supports HTML tags).
    /// This parameter requires the presence of a 'FluentTooltipProvider' in your main/layout page.
    [<CustomOperation("Tooltip")>] member inline _.Tooltip ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Tooltip" => x)
    /// Gets or sets a value indicating whether the navigation should force a full page load instead of using Blazor's built-in navigation.
    /// Default is false, which uses Blazor's navigation.
    [<CustomOperation("ForceLoad")>] member inline _.ForceLoad ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("ForceLoad" =>>> true)
    /// Gets or sets a value indicating whether the navigation should force a full page load instead of using Blazor's built-in navigation.
    /// Default is false, which uses Blazor's navigation.
    [<CustomOperation("ForceLoad")>] member inline _.ForceLoad ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("ForceLoad" =>>> x)

/// A FluentUI AnchorButton component.
type FluentCompoundButtonBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentComponentBaseBuilder<'FunBlazorGeneric>()
    /// Gets or sets whether the button should be focused when the page is loaded.
    [<CustomOperation("AutoFocus")>] member inline _.AutoFocus ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("AutoFocus" =>>> true)
    /// Gets or sets whether the button should be focused when the page is loaded.
    [<CustomOperation("AutoFocus")>] member inline _.AutoFocus ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("AutoFocus" =>>> x)
    /// Gets or sets the shape of the button.
    /// The default value is `null`. Internally the component uses Rounded as its default value.
    [<CustomOperation("Shape")>] member inline _.Shape ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<Microsoft.FluentUI.AspNetCore.Components.ButtonShape>) = render ==> ("Shape" => x)
    /// Gets or sets the size of the button.
    /// The default value is `null`. Internally the component uses Medium as its default value.
    [<CustomOperation("Size")>] member inline _.Size ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<Microsoft.FluentUI.AspNetCore.Components.ButtonSize>) = render ==> ("Size" => x)
    /// Gets or sets the name of the element.
    /// Allows access by name from the associated form.
    [<CustomOperation("Name")>] member inline _.Name ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Name" => x)
    /// Gets or sets the visual appearance.
    /// The default value is `null`. Internally the component uses Outline as its default value.
    [<CustomOperation("Appearance")>] member inline _.Appearance ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<Microsoft.FluentUI.AspNetCore.Components.ButtonAppearance>) = render ==> ("Appearance" => x)
    /// Gets or sets the background color of this button (overrides the Appearance property).
    /// Set the value `rgba(0, 0, 0, 0)` to display a transparent button.
    [<CustomOperation("BackgroundColor")>] member inline _.BackgroundColor ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("BackgroundColor" => x)
    /// Gets or sets the color of the font (overrides the Appearance property).
    [<CustomOperation("Color")>] member inline _.Color ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Color" => x)
    /// Gets or sets the Icon displayed at the start of button content.
    [<CustomOperation("IconStart")>] member inline _.IconStart ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.FluentUI.AspNetCore.Components.Icon) = render ==> ("IconStart" => x)
    /// Gets or sets the Icon displayed at the end of button content.
    [<CustomOperation("IconEnd")>] member inline _.IconEnd ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.FluentUI.AspNetCore.Components.Icon) = render ==> ("IconEnd" => x)
    /// Gets or sets the title of the button.
    /// The text usually displayed in a `tooltip` popup when the mouse is over the button.
    [<CustomOperation("Title")>] member inline _.Title ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Title" => x)
    /// Gets or sets the element's disabled state, ensuring it doesn't participate in form submission.
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Disabled" =>>> true)
    /// Gets or sets the element's disabled state, ensuring it doesn't participate in form submission.
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Disabled" =>>> x)
    /// Gets or sets the value indicating the button is focusable.
    [<CustomOperation("DisabledFocusable")>] member inline _.DisabledFocusable ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("DisabledFocusable" =>>> true)
    /// Gets or sets the value indicating the button is focusable.
    [<CustomOperation("DisabledFocusable")>] member inline _.DisabledFocusable ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("DisabledFocusable" =>>> x)
    /// Gets or sets a way to prevent further propagation of the current event in the capturing and bubbling phases.
    [<CustomOperation("StopPropagation")>] member inline _.StopPropagation ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("StopPropagation" =>>> true)
    /// Gets or sets a way to prevent further propagation of the current event in the capturing and bubbling phases.
    [<CustomOperation("StopPropagation")>] member inline _.StopPropagation ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("StopPropagation" =>>> x)
    /// Gets or sets a value indicating whether the button renders icon-only (no visible text label).
    /// Typically used when IconStart or IconEnd is set and no text label is needed.
    /// When using icon-only mode, provide an accessible name via Title or an aria-label attribute to ensure screen reader accessibility.
    [<CustomOperation("IconOnly")>] member inline _.IconOnly ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("IconOnly" =>>> true)
    /// Gets or sets a value indicating whether the button renders icon-only (no visible text label).
    /// Typically used when IconStart or IconEnd is set and no text label is needed.
    /// When using icon-only mode, provide an accessible name via Title or an aria-label attribute to ensure screen reader accessibility.
    [<CustomOperation("IconOnly")>] member inline _.IconOnly ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("IconOnly" =>>> x)
    /// Gets or sets the plain-text label rendered as the primary button text (e.g., Label="Open").
    /// If both Label and ChildContent are set, both are rendered together.
    /// For rich content, use ChildContent instead. See also Description for secondary text.
    [<CustomOperation("Label")>] member inline _.Label ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Label" => x)
    /// Gets or sets the secondary description content rendered below the primary label (e.g., a subtitle or hint).
    /// See also Label for the primary button text.
    [<CustomOperation("Description")>] member inline _.Description ([<InlineIfLambda>] render: AttrRenderFragment, fragment: NodeRenderFragment) = render ==> html.renderFragment("Description", fragment)
    /// Gets or sets the secondary description content rendered below the primary label (e.g., a subtitle or hint).
    /// See also Label for the primary button text.
    [<CustomOperation("Description")>] member inline _.Description ([<InlineIfLambda>] render: AttrRenderFragment, fragments: NodeRenderFragment seq) = render ==> html.renderFragment("Description", fragment { yield! fragments })
    /// Gets or sets the secondary description content rendered below the primary label (e.g., a subtitle or hint).
    /// See also Label for the primary button text.
    [<CustomOperation("Description")>] member inline _.Description ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("Description", html.text x)
    /// Gets or sets the secondary description content rendered below the primary label (e.g., a subtitle or hint).
    /// See also Label for the primary button text.
    [<CustomOperation("Description")>] member inline _.Description ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("Description", html.text x)
    /// Gets or sets the secondary description content rendered below the primary label (e.g., a subtitle or hint).
    /// See also Label for the primary button text.
    [<CustomOperation("Description")>] member inline _.Description ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("Description", html.text x)
    /// Command executed when the user clicks on the button.
    [<CustomOperation("OnClick")>] member inline _.OnClick ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.AspNetCore.Components.Web.MouseEventArgs -> unit) = render ==> html.callback("OnClick", fn)
    /// Command executed when the user clicks on the button.
    [<CustomOperation("OnClick")>] member inline _.OnClick ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.AspNetCore.Components.Web.MouseEventArgs -> Task<unit>) = render ==> html.callbackTask("OnClick", fn)
    /// Gets or sets the tooltip text (supports HTML tags).
    /// This parameter requires the presence of a 'FluentTooltipProvider' in your main/layout page.
    [<CustomOperation("Tooltip")>] member inline _.Tooltip ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Tooltip" => x)

/// The FluentSplitButton component allows users to combine a button with a menu where the left part triggers a primary action and the right part opens a menu with secondary actions.
/// is often found inside forms, dialogs, drawers (panels) and/or pages.
type FluentSplitButtonBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentComponentBaseBuilder<'FunBlazorGeneric>()
    /// Gets or sets the shape of the button.
    /// The default value is `null`. Internally the component uses Rounded as its default value.
    [<CustomOperation("Shape")>] member inline _.Shape ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<Microsoft.FluentUI.AspNetCore.Components.ButtonShape>) = render ==> ("Shape" => x)
    /// Gets or sets the size of the button.
    /// The default value is `null`. Internally the component uses Medium as its default value.
    [<CustomOperation("Size")>] member inline _.Size ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<Microsoft.FluentUI.AspNetCore.Components.ButtonSize>) = render ==> ("Size" => x)
    /// Gets or sets the name of the element.
    /// Allows access by name from the associated form.
    [<CustomOperation("Name")>] member inline _.Name ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Name" => x)
    /// Gets or sets the visual appearance.
    /// The default value is `null`. Internally the component uses Outline as its default value.
    [<CustomOperation("Appearance")>] member inline _.Appearance ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<Microsoft.FluentUI.AspNetCore.Components.ButtonAppearance>) = render ==> ("Appearance" => x)
    /// Gets or sets the background color of this button (overrides the Appearance property).
    /// Set the value `rgba(0, 0, 0, 0)` to display a transparent button.
    [<CustomOperation("BackgroundColor")>] member inline _.BackgroundColor ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("BackgroundColor" => x)
    /// Gets or sets the color of the font (overrides the Appearance property).
    [<CustomOperation("Color")>] member inline _.Color ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Color" => x)
    /// Gets or sets a value indicating whether the button renders icon-only (no visible text label).
    /// Typically used when IconStart is set and no text label is needed.
    /// When using icon-only mode, provide an accessible name via Title or an aria-label attribute to ensure screen reader accessibility.
    [<CustomOperation("IconOnly")>] member inline _.IconOnly ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("IconOnly" =>>> true)
    /// Gets or sets a value indicating whether the button renders icon-only (no visible text label).
    /// Typically used when IconStart is set and no text label is needed.
    /// When using icon-only mode, provide an accessible name via Title or an aria-label attribute to ensure screen reader accessibility.
    [<CustomOperation("IconOnly")>] member inline _.IconOnly ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("IconOnly" =>>> x)
    /// Gets or sets the Icon displayed at the start of button content.
    [<CustomOperation("IconStart")>] member inline _.IconStart ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.FluentUI.AspNetCore.Components.Icon) = render ==> ("IconStart" => x)
    /// Gets or sets the title of the button.
    /// The text usually displayed in a `tooltip` popup when the mouse is over the button.
    [<CustomOperation("Title")>] member inline _.Title ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Title" => x)
    /// Gets or sets the plain-text label rendered inside the primary button area (e.g., Label="Save").
    /// If both Label and ChildContent are set, both are rendered together.
    /// For rich content such as icons or custom markup, use ChildContent instead.
    [<CustomOperation("Label")>] member inline _.Label ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Label" => x)
    /// Gets or sets the max height of the menu, e.g. 300px
    [<CustomOperation("Height")>] member inline _.Height ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Height" => x)
    /// Command executed when the user clicks on the button.
    [<CustomOperation("OnClick")>] member inline _.OnClick ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.AspNetCore.Components.Web.MouseEventArgs -> unit) = render ==> html.callback("OnClick", fn)
    /// Command executed when the user clicks on the button.
    [<CustomOperation("OnClick")>] member inline _.OnClick ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.AspNetCore.Components.Web.MouseEventArgs -> Task<unit>) = render ==> html.callbackTask("OnClick", fn)
    /// Raised when a FluentMenuItem is clicked.
    [<CustomOperation("OnMenuClick")>] member inline _.OnMenuClick ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.FluentUI.AspNetCore.Components.MenuItemEventArgs -> unit) = render ==> html.callback("OnMenuClick", fn)
    /// Raised when a FluentMenuItem is clicked.
    [<CustomOperation("OnMenuClick")>] member inline _.OnMenuClick ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.FluentUI.AspNetCore.Components.MenuItemEventArgs -> Task<unit>) = render ==> html.callbackTask("OnMenuClick", fn)
    /// Raised when a FluentMenuItem's Checked state changes.
    [<CustomOperation("OnMenuCheckedChanged")>] member inline _.OnMenuCheckedChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.FluentUI.AspNetCore.Components.MenuItemEventArgs -> unit) = render ==> html.callback("OnMenuCheckedChanged", fn)
    /// Raised when a FluentMenuItem's Checked state changes.
    [<CustomOperation("OnMenuCheckedChanged")>] member inline _.OnMenuCheckedChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.FluentUI.AspNetCore.Components.MenuItemEventArgs -> Task<unit>) = render ==> html.callbackTask("OnMenuCheckedChanged", fn)

/// A FluentCard is a container that holds information and actions related to a single concept or object, like a document or a contact.
type FluentCardBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentComponentBaseBuilder<'FunBlazorGeneric>()
    /// Gets or sets the appearance of the component.
    [<CustomOperation("Appearance")>] member inline _.Appearance ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<Microsoft.FluentUI.AspNetCore.Components.CardAppearance>) = render ==> ("Appearance" => x)
    /// Gets or sets the shadow of the component.
    [<CustomOperation("Shadow")>] member inline _.Shadow ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<Microsoft.FluentUI.AspNetCore.Components.CardShadow>) = render ==> ("Shadow" => x)
    /// Gets or sets the width of the component. 
    [<CustomOperation("Width")>] member inline _.Width ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Width" => x)
    /// Gets or sets the height of the component. 
    [<CustomOperation("Height")>] member inline _.Height ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Height" => x)
    /// Command executed when the user clicks on the card.
    [<CustomOperation("OnClick")>] member inline _.OnClick ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.AspNetCore.Components.Web.MouseEventArgs -> unit) = render ==> html.callback("OnClick", fn)
    /// Command executed when the user clicks on the card.
    [<CustomOperation("OnClick")>] member inline _.OnClick ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.AspNetCore.Components.Web.MouseEventArgs -> Task<unit>) = render ==> html.callbackTask("OnClick", fn)
    /// Gets or sets the role of the card.
    [<CustomOperation("Role")>] member inline _.Role ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Role" => x)

/// The ColorPicker component is used to select a color from a palette.
type FluentColorPickerBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentComponentBaseBuilder<'FunBlazorGeneric>()
    /// Gets or sets the view of the color picker.
    [<CustomOperation("View")>] member inline _.View ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.FluentUI.AspNetCore.Components.ColorPickerView) = render ==> ("View" => x)
    /// Gets or sets the orientation of the color items in the swatch palette view.
    /// Default is Horizontal.
    [<CustomOperation("Orientation")>] member inline _.Orientation ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.FluentUI.AspNetCore.Components.Orientation) = render ==> ("Orientation" => x)
    /// Gets or sets the width of the color picker.
    [<CustomOperation("Width")>] member inline _.Width ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Width" => x)
    /// Gets or sets the height of the color picker.
    [<CustomOperation("Height")>] member inline _.Height ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Height" => x)
    /// Gets or sets the currently selected color.
    [<CustomOperation("SelectedColor")>] member inline _.SelectedColor ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("SelectedColor" => x)
    /// Gets or sets the currently selected color.
    [<CustomOperation("SelectedColor'")>] member inline _.SelectedColor' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.String * (System.String -> unit)) = render ==> html.bind("SelectedColor", valueFn)
    /// Gets or sets the callback that is invoked when the selected color changes.
    [<CustomOperation("SelectedColorChanged")>] member inline _.SelectedColorChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.String -> unit) = render ==> html.callback("SelectedColorChanged", fn)
    /// Gets or sets the callback that is invoked when the selected color changes.
    [<CustomOperation("SelectedColorChanged")>] member inline _.SelectedColorChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.String -> Task<unit>) = render ==> html.callbackTask("SelectedColorChanged", fn)
    /// Gets or sets the custom color palette to display in the Swatch or ColorWheel view.
    /// If not set, the default palette will be used.
    /// The palette should contain hex color strings (e.g. "#FF0000").
    [<CustomOperation("Palette")>] member inline _.Palette ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.IReadOnlyList<System.String>) = render ==> ("Palette" => x)
    /// Gets or sets a value indicating whether to find the closest color in the palette
    /// when the SelectedColor does not exactly match any palette color.
    /// When enabled, the closest matching color will be highlighted in the picker.
    /// Default is true.
    [<CustomOperation("FindClosestColor")>] member inline _.FindClosestColor ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("FindClosestColor" =>>> true)
    /// Gets or sets a value indicating whether to find the closest color in the palette
    /// when the SelectedColor does not exactly match any palette color.
    /// When enabled, the closest matching color will be highlighted in the picker.
    /// Default is true.
    [<CustomOperation("FindClosestColor")>] member inline _.FindClosestColor ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("FindClosestColor" =>>> x)

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
    /// Gets or sets a callback which will be called if there is a change in pagination, ordering or if a RefreshDataAsync is forced.
    ///             
    /// You must supply Items if you use this callback.
    [<CustomOperation("RefreshItems")>] member inline _.RefreshItems ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("RefreshItems" => (System.Func<Microsoft.FluentUI.AspNetCore.Components.GridItemsProviderRequest<'TGridItem>, System.Threading.Tasks.Task>fn))
    /// Gets or sets a callback that supplies data for the grid.
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
    /// This is applicable only when using Virtualize. It defines the maximum number of items
    /// that can be rendered, even when the viewport would otherwise require more items.
    [<CustomOperation("MaxItemCount")>] member inline _.MaxItemCount ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("MaxItemCount" => x)
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
    /// If true, allows unpinned columns to be reordered by drag-and-drop and through the header popup UI.
    [<CustomOperation("ReorderableColumns")>] member inline _.ReorderableColumns ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("ReorderableColumns" =>>> true)
    /// If true, allows unpinned columns to be reordered by drag-and-drop and through the header popup UI.
    [<CustomOperation("ReorderableColumns")>] member inline _.ReorderableColumns ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("ReorderableColumns" =>>> x)
    /// Gets or sets a value indicating whether column resize handles should extend the full height of the grid.
    /// When true, columns can be resized by dragging from any row. When false, columns can only be resized
    /// by dragging from the column header. Default is true.
    [<CustomOperation("ResizeColumnOnAllRows")>] member inline _.ResizeColumnOnAllRows ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("ResizeColumnOnAllRows" =>>> true)
    /// Gets or sets a value indicating whether column resize handles should extend the full height of the grid.
    /// When true, columns can be resized by dragging from any row. When false, columns can only be resized
    /// by dragging from the column header. Default is true.
    [<CustomOperation("ResizeColumnOnAllRows")>] member inline _.ResizeColumnOnAllRows ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("ResizeColumnOnAllRows" =>>> x)
    /// To comply with WCAG 2.2, a one-click option should be offered to change column widths. We provide such an option through the
    /// ColumnOptions UI. This parameter allows you to enable or disable this resize UI.Enable it by setting the type of resize to perform
    /// Discrete: resize by a 10 pixels at a time
    /// Exact: resize to the exact width specified (in pixels)
    /// Note: This does not affect resizing by mouse dragging, just the keyboard driven resize.
    [<CustomOperation("ResizeType")>] member inline _.ResizeType ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<Microsoft.FluentUI.AspNetCore.Components.DataGridResizeType>) = render ==> ("ResizeType" => x)
    /// Settings (icon, icon position) used in the column resize UI.
    /// (aria) labels are controlled through IFluentLocalizer
    [<CustomOperation("ColumnResizeMenuSettings")>] member inline _.ColumnResizeMenuSettings ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.FluentUI.AspNetCore.Components.ColumnMenuSettings) = render ==> ("ColumnResizeMenuSettings" => x)
    /// Settings (icon, icon position) used in the column reorder UI.
    /// (aria) labels are controlled through IFluentLocalizer
    [<CustomOperation("ColumnReorderMenuSettings")>] member inline _.ColumnReorderMenuSettings ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.FluentUI.AspNetCore.Components.ColumnMenuSettings) = render ==> ("ColumnReorderMenuSettings" => x)
    /// Settings (icon, icon position) used in the column sort UI.
    /// (aria) labels are controlled through IFluentLocalizer
    [<CustomOperation("ColumnSortMenuSettings")>] member inline _.ColumnSortMenuSettings ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.FluentUI.AspNetCore.Components.ColumnMenuSettings) = render ==> ("ColumnSortMenuSettings" => x)
    /// Settings (icon, icon position) used in the column options menu. (aria) labels are controlled through
    /// IFluentLocalizer
    [<CustomOperation("ColumnOptionsMenuSettings")>] member inline _.ColumnOptionsMenuSettings ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.FluentUI.AspNetCore.Components.ColumnMenuSettings) = render ==> ("ColumnOptionsMenuSettings" => x)
    /// If true, enables the new style of header cell that includes a button to display all column options through a
    /// menu.
    [<CustomOperation("HeaderCellAsButtonWithMenu")>] member inline _.HeaderCellAsButtonWithMenu ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("HeaderCellAsButtonWithMenu" =>>> true)
    /// If true, enables the new style of header cell that includes a button to display all column options through a
    /// menu.
    [<CustomOperation("HeaderCellAsButtonWithMenu")>] member inline _.HeaderCellAsButtonWithMenu ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("HeaderCellAsButtonWithMenu" =>>> x)
    /// Use IMenuService to create the menu, if this service was injected.
    /// This value must be defined before the component is rendered (you can't change it during the component lifecycle).
    /// Default, true.
    [<CustomOperation("UseMenuService")>] member inline _.UseMenuService ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("UseMenuService" =>>> true)
    /// Use IMenuService to create the menu, if this service was injected.
    /// This value must be defined before the component is rendered (you can't change it during the component lifecycle).
    /// Default, true.
    [<CustomOperation("UseMenuService")>] member inline _.UseMenuService ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("UseMenuService" =>>> x)
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
    /// Gets or sets a value indicating whether the grid should automatically generate a header row and its type.
    /// See DataGridGeneratedHeaderType
    [<CustomOperation("GenerateHeader")>] member inline _.GenerateHeader ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<Microsoft.FluentUI.AspNetCore.Components.DataGridGeneratedHeaderType>) = render ==> ("GenerateHeader" => x)
    /// Gets or sets the value that gets applied to the css gridTemplateColumns attribute of child rows.
    /// Can be specified here or on the column level with the Width parameter but not both.
    /// Needs to be a valid CSS string of space-separated values, such as "auto 1fr 2fr 100px".
    [<CustomOperation("GridTemplateColumns")>] member inline _.GridTemplateColumns ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("GridTemplateColumns" => x)
    /// Gets or sets the persisted display order for the grid columns.
    /// Pinned columns are ignored when applying this order and remain fixed at their respective edges.
    [<CustomOperation("ColumnOrder")>] member inline _.ColumnOrder ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.IReadOnlyList<System.String>) = render ==> ("ColumnOrder" => x)
    /// Gets or sets the persisted display order for the grid columns.
    /// Pinned columns are ignored when applying this order and remain fixed at their respective edges.
    [<CustomOperation("ColumnOrder'")>] member inline _.ColumnOrder' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.Collections.Generic.IReadOnlyList<System.String> * (System.Collections.Generic.IReadOnlyList<System.String> -> unit)) = render ==> html.bind("ColumnOrder", valueFn)
    /// Gets or sets a callback that is invoked when the column order changes.
    [<CustomOperation("ColumnOrderChanged")>] member inline _.ColumnOrderChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Collections.Generic.IReadOnlyList<System.String> -> unit) = render ==> html.callback("ColumnOrderChanged", fn)
    /// Gets or sets a callback that is invoked when the column order changes.
    [<CustomOperation("ColumnOrderChanged")>] member inline _.ColumnOrderChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Collections.Generic.IReadOnlyList<System.String> -> Task<unit>) = render ==> html.callbackTask("ColumnOrderChanged", fn)
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
    /// Event callback for when a hierarchical row is expanded or collapsed.
    [<CustomOperation("OnToggle")>] member inline _.OnToggle ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: 'TGridItem -> unit) = render ==> html.callback("OnToggle", fn)
    /// Event callback for when a hierarchical row is expanded or collapsed.
    [<CustomOperation("OnToggle")>] member inline _.OnToggle ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: 'TGridItem -> Task<unit>) = render ==> html.callbackTask("OnToggle", fn)
    /// Event callback for when all hierarchical rows are expanded.
    [<CustomOperation("OnExpandAll")>] member inline _.OnExpandAll ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: unit -> unit) = render ==> html.callback("OnExpandAll", fn)
    /// Event callback for when all hierarchical rows are expanded.
    [<CustomOperation("OnExpandAll")>] member inline _.OnExpandAll ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: unit -> Task<unit>) = render ==> html.callbackTask("OnExpandAll", fn)
    /// Event callback for when all hierarchical rows are collapsed.
    [<CustomOperation("OnCollapseAll")>] member inline _.OnCollapseAll ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: unit -> unit) = render ==> html.callback("OnCollapseAll", fn)
    /// Event callback for when all hierarchical rows are collapsed.
    [<CustomOperation("OnCollapseAll")>] member inline _.OnCollapseAll ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: unit -> Task<unit>) = render ==> html.callbackTask("OnCollapseAll", fn)
    /// Gets or sets the template that defines the detail content shown when a row is expanded (master/detail view).
    ///             
    /// When set, each row displays an expand/collapse button in its first column. The expanded content is rendered
    /// in an extra row spanning all columns, directly below the master row. The template's context is the row's
    /// , so it can, for example, contain a child FluentDataGrid`1
    /// whose items are filtered by the master row.
    ///             
    /// Cannot be used together with Virtualize.
    [<CustomOperation("RowDetails")>] member inline _.RowDetails ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: 'TGridItem -> NodeRenderFragment) = render ==> html.renderFragment("RowDetails", fn)
    /// Optionally determines, per row, whether that row has RowDetails content to show.
    /// When set, the expand/collapse toggle button is only rendered for rows where this returns
    /// true — other rows keep the same indentation but show no button, so their
    /// content can't be expanded via the UI. If not set, every row gets the toggle button.
    ///             
    /// This only controls the toggle button; it doesn't affect ToggleRowDetailsAsync and the
    /// other programmatic expand/collapse methods, which work regardless.
    [<CustomOperation("HasRowDetails")>] member inline _.HasRowDetails ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("HasRowDetails" => (System.Func<'TGridItem, System.Boolean>fn))
    /// Event callback for when a row's RowDetails content is expanded or collapsed.
    [<CustomOperation("OnRowDetailsToggle")>] member inline _.OnRowDetailsToggle ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: 'TGridItem -> unit) = render ==> html.callback("OnRowDetailsToggle", fn)
    /// Event callback for when a row's RowDetails content is expanded or collapsed.
    [<CustomOperation("OnRowDetailsToggle")>] member inline _.OnRowDetailsToggle ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: 'TGridItem -> Task<unit>) = render ==> html.callbackTask("OnRowDetailsToggle", fn)
    /// Event callback for when the grid's sort order changes.
    [<CustomOperation("OnSortChanged")>] member inline _.OnSortChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.FluentUI.AspNetCore.Components.DataGridSortEventArgs<'TGridItem> -> unit) = render ==> html.callback("OnSortChanged", fn)
    /// Event callback for when the grid's sort order changes.
    [<CustomOperation("OnSortChanged")>] member inline _.OnSortChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.FluentUI.AspNetCore.Components.DataGridSortEventArgs<'TGridItem> -> Task<unit>) = render ==> html.callbackTask("OnSortChanged", fn)
    /// Gets or sets whether the grid can be sorted by more than one column at a time.
    /// The default is Single.
    ///             
    /// With Multiple, Shift+click (Shift+Enter from the keyboard) on a column header
    /// adds that column to the sort, and the column header menu gains items to add a column to the sort, remove it
    /// again and clear the sort. Use HeaderCellAsButtonWithMenu to put those items in the header menu
    /// rather than in the column header options popup.
    [<CustomOperation("SortMode")>] member inline _.SortMode ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.FluentUI.AspNetCore.Components.DataGridSortMode) = render ==> ("SortMode" => x)
    /// Gets or sets whether the column headers offer the multi-column sort actions when SortMode is
    /// Multiple. The default is true.
    ///             
    /// Set this to false to keep the headers as they are in single sort mode; sorting by several
    /// columns is then only possible through Shift+click, Shift+Enter and the grid's sort methods. Note that this
    /// leaves no way to build a multi-column sort by touch, or with a screen reader that does not pass Shift+Enter
    /// through, so only turn it off when your application offers its own UI for it.
    [<CustomOperation("ShowMultiSortActions")>] member inline _.ShowMultiSortActions ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("ShowMultiSortActions" =>>> true)
    /// Gets or sets whether the column headers offer the multi-column sort actions when SortMode is
    /// Multiple. The default is true.
    ///             
    /// Set this to false to keep the headers as they are in single sort mode; sorting by several
    /// columns is then only possible through Shift+click, Shift+Enter and the grid's sort methods. Note that this
    /// leaves no way to build a multi-column sort by touch, or with a screen reader that does not pass Shift+Enter
    /// through, so only turn it off when your application offers its own UI for it.
    [<CustomOperation("ShowMultiSortActions")>] member inline _.ShowMultiSortActions ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("ShowMultiSortActions" =>>> x)
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
    /// Gets or sets the callback that is invoked when the asynchronous loading state of items changes and IAsyncQueryExecutor is used.
    [<CustomOperation("OnItemsLoading")>] member inline _.OnItemsLoading ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Boolean -> unit) = render ==> html.callback("OnItemsLoading", fn)
    /// Gets or sets the callback that is invoked when the asynchronous loading state of items changes and IAsyncQueryExecutor is used.
    [<CustomOperation("OnItemsLoading")>] member inline _.OnItemsLoading ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Boolean -> Task<unit>) = render ==> html.callbackTask("OnItemsLoading", fn)
    /// Gets or sets a delegate that determines whether a given exception should be handled.
    [<CustomOperation("HandleLoadingError")>] member inline _.HandleLoadingError ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("HandleLoadingError" => (System.Func<System.Exception, System.Boolean>fn))
    /// Gets or sets the content to render when an error occurs.
    [<CustomOperation("ErrorContent")>] member inline _.ErrorContent ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Exception -> NodeRenderFragment) = render ==> html.renderFragment("ErrorContent", fn)
    /// Sets GridTemplateColumns to automatically fit the columns to the available width as best it can.
    [<CustomOperation("AutoFit")>] member inline _.AutoFit ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("AutoFit" =>>> true)
    /// Sets GridTemplateColumns to automatically fit the columns to the available width as best it can.
    [<CustomOperation("AutoFit")>] member inline _.AutoFit ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("AutoFit" =>>> x)
    /// Automatically fit the number of items per page to the available height.
    [<CustomOperation("AutoItemsPerPage")>] member inline _.AutoItemsPerPage ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("AutoItemsPerPage" =>>> true)
    /// Automatically fit the number of items per page to the available height.
    [<CustomOperation("AutoItemsPerPage")>] member inline _.AutoItemsPerPage ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("AutoItemsPerPage" =>>> x)
    /// Gets or sets a value that indicates whether rows should be rendered with
    /// alternating "striped" backgrounds. When true, odd and
    /// even rows will use different background styling to improve readability.
    [<CustomOperation("StripedRows")>] member inline _.StripedRows ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("StripedRows" =>>> true)
    /// Gets or sets a value that indicates whether rows should be rendered with
    /// alternating "striped" backgrounds. When true, odd and
    /// even rows will use different background styling to improve readability.
    [<CustomOperation("StripedRows")>] member inline _.StripedRows ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("StripedRows" =>>> x)
    /// Gets or set the DataGridDisplayMode of the grid.
    /// Default is 'Grid'.
    /// When set to Grid, GridTemplateColumns can be used to specify column widths.
    /// When set to Table, widths need to be specified at the column level.
    /// When using Virtualize, it is recommended to use Table.
    [<CustomOperation("DisplayMode")>] member inline _.DisplayMode ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.FluentUI.AspNetCore.Components.DataGridDisplayMode) = render ==> ("DisplayMode" => x)
    /// Gets or sets the size of each row in the grid based on the DataGridRowSize enum.
    [<CustomOperation("RowSize")>] member inline _.RowSize ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.FluentUI.AspNetCore.Components.DataGridRowSize) = render ==> ("RowSize" => x)
    /// Gets or sets a value indicating whether the grid should allow multiple lines of text in cells.
    /// Cannot be used together with Virtualize.
    [<CustomOperation("MultiLine")>] member inline _.MultiLine ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("MultiLine" =>>> true)
    /// Gets or sets a value indicating whether the grid should allow multiple lines of text in cells.
    /// Cannot be used together with Virtualize.
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
    /// Gets or sets a value indicating whether the grid's dataset is not expected to change during its lifetime.
    /// When set to true, reduces automatic refresh checks for better performance with static datasets.
    /// Default is false to maintain backward compatibility.
    [<CustomOperation("IsFixed")>] member inline _.IsFixed ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("IsFixed" =>>> true)
    /// Gets or sets a value indicating whether the grid's dataset is not expected to change during its lifetime.
    /// When set to true, reduces automatic refresh checks for better performance with static datasets.
    /// Default is false to maintain backward compatibility.
    [<CustomOperation("IsFixed")>] member inline _.IsFixed ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("IsFixed" =>>> x)

/// Represents a cell in a FluentDataGrid`1.
type FluentDataGridCellBuilder<'FunBlazorGeneric, 'TGridItem when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentComponentBaseBuilder<'FunBlazorGeneric>()
    /// Gets or sets the reference to the item that holds this cell's values.
    [<CustomOperation("Item")>] member inline _.Item ([<InlineIfLambda>] render: AttrRenderFragment, x: 'TGridItem) = render ==> ("Item" => x)
    /// Gets or sets the cell type. See DataGridCellType.
    [<CustomOperation("CellType")>] member inline _.CellType ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.FluentUI.AspNetCore.Components.DataGridCellType) = render ==> ("CellType" => x)
    /// Gets or sets the column index of the cell.
    /// This will be applied to the css grid-column-index value applied to the cell.
    [<CustomOperation("GridColumn")>] member inline _.GridColumn ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("GridColumn" => x)
    /// Gets or sets the text used for the cell's title and aria-label attributes.
    [<CustomOperation("CellTitle")>] member inline _.CellTitle ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("CellTitle" => x)

/// Represents a row in a FluentDataGrid`1 component, providing functionality for rendering,
/// interaction, and data binding.
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
    [<CustomOperation("RowType")>] member inline _.RowType ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.FluentUI.AspNetCore.Components.DataGridRowType) = render ==> ("RowType" => x)
    /// Gets or sets the semantic row state used for styling and behavior.
    [<CustomOperation("RowState")>] member inline _.RowState ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<Microsoft.FluentUI.AspNetCore.Components.DataGridRowState>) = render ==> ("RowState" => x)
    /// Gets or sets the vertical alignment of a row
    [<CustomOperation("VerticalAlignment")>] member inline _.VerticalAlignment ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.FluentUI.AspNetCore.Components.VerticalAlignment) = render ==> ("VerticalAlignment" => x)

/// The dialog component is a window overlaid on either the primary window or another dialog window.
/// Windows under a modal dialog are inert.
type FluentDialogBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentComponentBaseBuilder<'FunBlazorGeneric>()
    /// Gets or sets the instance used by the DialogService.
    [<CustomOperation("Instance")>] member inline _.Instance ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.FluentUI.AspNetCore.Components.IDialogInstance) = render ==> ("Instance" => x)
    /// Gets or sets the alignment of the dialog (center, left, right).
    [<CustomOperation("Alignment")>] member inline _.Alignment ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.FluentUI.AspNetCore.Components.DialogAlignment) = render ==> ("Alignment" => x)
    /// Gets or sets a value indicating whether this dialog is displayed modally.
    /// By default, the dialog is displayed modally (Modal = true).
    [<CustomOperation("Modal")>] member inline _.Modal ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Modal" =>>> true)
    /// Gets or sets a value indicating whether this dialog is displayed modally.
    /// By default, the dialog is displayed modally (Modal = true).
    [<CustomOperation("Modal")>] member inline _.Modal ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Modal" =>>> x)
    /// Gets or sets a value indicating whether pressing the ESC key should be prevented from closing the dialog.
    /// By default, the ESC key closes the dialog (false).
    /// When using the IDialogService, set PreventDismissOnEscape instead.
    [<CustomOperation("PreventDismissOnEscape")>] member inline _.PreventDismissOnEscape ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("PreventDismissOnEscape" =>>> true)
    /// Gets or sets a value indicating whether pressing the ESC key should be prevented from closing the dialog.
    /// By default, the ESC key closes the dialog (false).
    /// When using the IDialogService, set PreventDismissOnEscape instead.
    [<CustomOperation("PreventDismissOnEscape")>] member inline _.PreventDismissOnEscape ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("PreventDismissOnEscape" =>>> x)
    /// Gets or sets the callback that is invoked when the dialog state changes (e.g., opening or closing).
    [<CustomOperation("OnStateChange")>] member inline _.OnStateChange ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.FluentUI.AspNetCore.Components.DialogEventArgs -> unit) = render ==> html.callback("OnStateChange", fn)
    /// Gets or sets the callback that is invoked when the dialog state changes (e.g., opening or closing).
    [<CustomOperation("OnStateChange")>] member inline _.OnStateChange ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.FluentUI.AspNetCore.Components.DialogEventArgs -> Task<unit>) = render ==> html.callbackTask("OnStateChange", fn)

/// The dialog component is a window overlaid on either the primary window or another dialog window.
/// Windows under a modal dialog are inert. 
type FluentDialogBodyBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentComponentBaseBuilder<'FunBlazorGeneric>()
    /// Gets or sets the content for the title element.
    /// For an action button in the title area, use TitleActionTemplate instead.
    [<CustomOperation("TitleTemplate")>] member inline _.TitleTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragment: NodeRenderFragment) = render ==> html.renderFragment("TitleTemplate", fragment)
    /// Gets or sets the content for the title element.
    /// For an action button in the title area, use TitleActionTemplate instead.
    [<CustomOperation("TitleTemplate")>] member inline _.TitleTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragments: NodeRenderFragment seq) = render ==> html.renderFragment("TitleTemplate", fragment { yield! fragments })
    /// Gets or sets the content for the title element.
    /// For an action button in the title area, use TitleActionTemplate instead.
    [<CustomOperation("TitleTemplate")>] member inline _.TitleTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("TitleTemplate", html.text x)
    /// Gets or sets the content for the title element.
    /// For an action button in the title area, use TitleActionTemplate instead.
    [<CustomOperation("TitleTemplate")>] member inline _.TitleTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("TitleTemplate", html.text x)
    /// Gets or sets the content for the title element.
    /// For an action button in the title area, use TitleActionTemplate instead.
    [<CustomOperation("TitleTemplate")>] member inline _.TitleTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("TitleTemplate", html.text x)
    /// Gets or sets the content for the action button rendered inside the title area.
    /// For the primary title content, use TitleTemplate.
    /// For footer-level actions, use ActionTemplate.
    [<CustomOperation("TitleActionTemplate")>] member inline _.TitleActionTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragment: NodeRenderFragment) = render ==> html.renderFragment("TitleActionTemplate", fragment)
    /// Gets or sets the content for the action button rendered inside the title area.
    /// For the primary title content, use TitleTemplate.
    /// For footer-level actions, use ActionTemplate.
    [<CustomOperation("TitleActionTemplate")>] member inline _.TitleActionTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragments: NodeRenderFragment seq) = render ==> html.renderFragment("TitleActionTemplate", fragment { yield! fragments })
    /// Gets or sets the content for the action button rendered inside the title area.
    /// For the primary title content, use TitleTemplate.
    /// For footer-level actions, use ActionTemplate.
    [<CustomOperation("TitleActionTemplate")>] member inline _.TitleActionTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("TitleActionTemplate", html.text x)
    /// Gets or sets the content for the action button rendered inside the title area.
    /// For the primary title content, use TitleTemplate.
    /// For footer-level actions, use ActionTemplate.
    [<CustomOperation("TitleActionTemplate")>] member inline _.TitleActionTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("TitleActionTemplate", html.text x)
    /// Gets or sets the content for the action button rendered inside the title area.
    /// For the primary title content, use TitleTemplate.
    /// For footer-level actions, use ActionTemplate.
    [<CustomOperation("TitleActionTemplate")>] member inline _.TitleActionTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("TitleActionTemplate", html.text x)
    /// Gets or sets the content for the footer action area (e.g., confirm/cancel buttons).
    /// For an action button inside the title bar, use TitleActionTemplate instead.
    [<CustomOperation("ActionTemplate")>] member inline _.ActionTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragment: NodeRenderFragment) = render ==> html.renderFragment("ActionTemplate", fragment)
    /// Gets or sets the content for the footer action area (e.g., confirm/cancel buttons).
    /// For an action button inside the title bar, use TitleActionTemplate instead.
    [<CustomOperation("ActionTemplate")>] member inline _.ActionTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragments: NodeRenderFragment seq) = render ==> html.renderFragment("ActionTemplate", fragment { yield! fragments })
    /// Gets or sets the content for the footer action area (e.g., confirm/cancel buttons).
    /// For an action button inside the title bar, use TitleActionTemplate instead.
    [<CustomOperation("ActionTemplate")>] member inline _.ActionTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("ActionTemplate", html.text x)
    /// Gets or sets the content for the footer action area (e.g., confirm/cancel buttons).
    /// For an action button inside the title bar, use TitleActionTemplate instead.
    [<CustomOperation("ActionTemplate")>] member inline _.ActionTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("ActionTemplate", html.text x)
    /// Gets or sets the content for the footer action area (e.g., confirm/cancel buttons).
    /// For an action button inside the title bar, use TitleActionTemplate instead.
    [<CustomOperation("ActionTemplate")>] member inline _.ActionTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("ActionTemplate", html.text x)
    /// Gets or sets a value indicating whether the header and footer are fixed.
    /// Only the content will scroll when the content overflows.
    /// Default is true.
    [<CustomOperation("FixedHeaderFooter")>] member inline _.FixedHeaderFooter ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("FixedHeaderFooter" =>>> true)
    /// Gets or sets a value indicating whether the header and footer are fixed.
    /// Only the content will scroll when the content overflows.
    /// Default is true.
    [<CustomOperation("FixedHeaderFooter")>] member inline _.FixedHeaderFooter ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("FixedHeaderFooter" =>>> x)

type FluentDialogProviderBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentComponentBaseBuilder<'FunBlazorGeneric>()


/// A horizontal or vertical rule used to visually separate content.
type FluentDividerBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentComponentBaseBuilder<'FunBlazorGeneric>()
    /// Gets or sets the alignment of any child content within the divider (e.g., AlignContent="DividerAlignContent.Center").
    /// See DividerAlignContent for available values.
    [<CustomOperation("AlignContent")>] member inline _.AlignContent ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<Microsoft.FluentUI.AspNetCore.Components.DividerAlignContent>) = render ==> ("AlignContent" => x)
    /// Gets or sets the visual appearance of the divider (e.g., Appearance="DividerAppearance.Strong").
    /// See DividerAppearance for available values.
    [<CustomOperation("Appearance")>] member inline _.Appearance ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<Microsoft.FluentUI.AspNetCore.Components.DividerAppearance>) = render ==> ("Appearance" => x)
    /// Gets or sets whether padding is added to the beginning and end of the divider (e.g., Inset="true").
    [<CustomOperation("Inset")>] member inline _.Inset ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Boolean>) = render ==> ("Inset" => x)
    /// Gets or sets whether the divider is vertical (true) or horizontal (false, default).
    [<CustomOperation("Vertical")>] member inline _.Vertical ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Boolean>) = render ==> ("Vertical" => x)
    /// Gets or sets the tooltip text (supports HTML tags).
    /// This parameter requires the presence of a 'FluentTooltipProvider' in your main/layout page.
    [<CustomOperation("Tooltip")>] member inline _.Tooltip ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Tooltip" => x)

type FluentDragContainerBuilder<'FunBlazorGeneric, 'TItem when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentComponentBaseBuilder<'FunBlazorGeneric>()
    /// Gets or sets the time (in milliseconds) a touch must be held before a drag starts.
    /// Default is 100.
    [<CustomOperation("TouchDragDelay")>] member inline _.TouchDragDelay ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("TouchDragDelay" => x)
    /// This event is fired when the user starts dragging an element.
    [<CustomOperation("OnDragStart")>] member inline _.OnDragStart ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.FluentUI.AspNetCore.Components.FluentDragEventArgs<'TItem> -> unit) = render ==> html.callback("OnDragStart", fn)
    /// This event is fired when the user starts dragging an element.
    [<CustomOperation("OnDragStart")>] member inline _.OnDragStart ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.FluentUI.AspNetCore.Components.FluentDragEventArgs<'TItem> -> Task<unit>) = render ==> html.callbackTask("OnDragStart", fn)
    /// This event is fired when the drag operation ends (such as releasing a mouse button or hitting the Esc key).
    [<CustomOperation("OnDragEnd")>] member inline _.OnDragEnd ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.FluentUI.AspNetCore.Components.FluentDragEventArgs<'TItem> -> unit) = render ==> html.callback("OnDragEnd", fn)
    /// This event is fired when the drag operation ends (such as releasing a mouse button or hitting the Esc key).
    [<CustomOperation("OnDragEnd")>] member inline _.OnDragEnd ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.FluentUI.AspNetCore.Components.FluentDragEventArgs<'TItem> -> Task<unit>) = render ==> html.callbackTask("OnDragEnd", fn)
    /// This event is fired when a dragged element enters a valid drop target.
    [<CustomOperation("OnDragEnter")>] member inline _.OnDragEnter ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.FluentUI.AspNetCore.Components.FluentDragEventArgs<'TItem> -> unit) = render ==> html.callback("OnDragEnter", fn)
    /// This event is fired when a dragged element enters a valid drop target.
    [<CustomOperation("OnDragEnter")>] member inline _.OnDragEnter ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.FluentUI.AspNetCore.Components.FluentDragEventArgs<'TItem> -> Task<unit>) = render ==> html.callbackTask("OnDragEnter", fn)
    /// This event is fired when an element is being dragged over a valid drop target.
    [<CustomOperation("OnDragOver")>] member inline _.OnDragOver ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.FluentUI.AspNetCore.Components.FluentDragEventArgs<'TItem> -> unit) = render ==> html.callback("OnDragOver", fn)
    /// This event is fired when an element is being dragged over a valid drop target.
    [<CustomOperation("OnDragOver")>] member inline _.OnDragOver ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.FluentUI.AspNetCore.Components.FluentDragEventArgs<'TItem> -> Task<unit>) = render ==> html.callbackTask("OnDragOver", fn)
    /// This event is fired when a dragged element leaves a valid drop target.
    [<CustomOperation("OnDragLeave")>] member inline _.OnDragLeave ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.FluentUI.AspNetCore.Components.FluentDragEventArgs<'TItem> -> unit) = render ==> html.callback("OnDragLeave", fn)
    /// This event is fired when a dragged element leaves a valid drop target.
    [<CustomOperation("OnDragLeave")>] member inline _.OnDragLeave ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.FluentUI.AspNetCore.Components.FluentDragEventArgs<'TItem> -> Task<unit>) = render ==> html.callbackTask("OnDragLeave", fn)
    /// This event is fired when an element is dropped on a valid drop target.
    [<CustomOperation("OnDropEnd")>] member inline _.OnDropEnd ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.FluentUI.AspNetCore.Components.FluentDragEventArgs<'TItem> -> unit) = render ==> html.callback("OnDropEnd", fn)
    /// This event is fired when an element is dropped on a valid drop target.
    [<CustomOperation("OnDropEnd")>] member inline _.OnDropEnd ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.FluentUI.AspNetCore.Components.FluentDragEventArgs<'TItem> -> Task<unit>) = render ==> html.callbackTask("OnDropEnd", fn)

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
    [<CustomOperation("OnDragStart")>] member inline _.OnDragStart ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.FluentUI.AspNetCore.Components.FluentDragEventArgs<'TItem> -> unit) = render ==> html.callback("OnDragStart", fn)
    /// This event is fired when the user starts dragging an element.
    [<CustomOperation("OnDragStart")>] member inline _.OnDragStart ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.FluentUI.AspNetCore.Components.FluentDragEventArgs<'TItem> -> Task<unit>) = render ==> html.callbackTask("OnDragStart", fn)
    /// This event is fired when the drag operation ends (such as releasing a mouse button or hitting the Esc key).
    [<CustomOperation("OnDragEnd")>] member inline _.OnDragEnd ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.FluentUI.AspNetCore.Components.FluentDragEventArgs<'TItem> -> unit) = render ==> html.callback("OnDragEnd", fn)
    /// This event is fired when the drag operation ends (such as releasing a mouse button or hitting the Esc key).
    [<CustomOperation("OnDragEnd")>] member inline _.OnDragEnd ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.FluentUI.AspNetCore.Components.FluentDragEventArgs<'TItem> -> Task<unit>) = render ==> html.callbackTask("OnDragEnd", fn)
    /// This event is fired when a dragged element enters a valid drop target.
    [<CustomOperation("OnDragEnter")>] member inline _.OnDragEnter ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.FluentUI.AspNetCore.Components.FluentDragEventArgs<'TItem> -> unit) = render ==> html.callback("OnDragEnter", fn)
    /// This event is fired when a dragged element enters a valid drop target.
    [<CustomOperation("OnDragEnter")>] member inline _.OnDragEnter ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.FluentUI.AspNetCore.Components.FluentDragEventArgs<'TItem> -> Task<unit>) = render ==> html.callbackTask("OnDragEnter", fn)
    /// This event is fired when an element is being dragged over a valid drop target.
    [<CustomOperation("OnDragOver")>] member inline _.OnDragOver ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.FluentUI.AspNetCore.Components.FluentDragEventArgs<'TItem> -> unit) = render ==> html.callback("OnDragOver", fn)
    /// This event is fired when an element is being dragged over a valid drop target.
    [<CustomOperation("OnDragOver")>] member inline _.OnDragOver ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.FluentUI.AspNetCore.Components.FluentDragEventArgs<'TItem> -> Task<unit>) = render ==> html.callbackTask("OnDragOver", fn)
    /// This event is fired when a dragged element leaves a valid drop target.
    [<CustomOperation("OnDragLeave")>] member inline _.OnDragLeave ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.FluentUI.AspNetCore.Components.FluentDragEventArgs<'TItem> -> unit) = render ==> html.callback("OnDragLeave", fn)
    /// This event is fired when a dragged element leaves a valid drop target.
    [<CustomOperation("OnDragLeave")>] member inline _.OnDragLeave ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.FluentUI.AspNetCore.Components.FluentDragEventArgs<'TItem> -> Task<unit>) = render ==> html.callbackTask("OnDragLeave", fn)
    /// This event is fired when an element is dropped on a valid drop target.
    [<CustomOperation("OnDropEnd")>] member inline _.OnDropEnd ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.FluentUI.AspNetCore.Components.FluentDragEventArgs<'TItem> -> unit) = render ==> html.callback("OnDropEnd", fn)
    /// This event is fired when an element is dropped on a valid drop target.
    [<CustomOperation("OnDropEnd")>] member inline _.OnDropEnd ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.FluentUI.AspNetCore.Components.FluentDragEventArgs<'TItem> -> Task<unit>) = render ==> html.callbackTask("OnDropEnd", fn)
    /// Gets or sets a way to prevent further propagation of the current event in the capturing and bubbling phases.
    [<CustomOperation("StopPropagation")>] member inline _.StopPropagation ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("StopPropagation" =>>> true)
    /// Gets or sets a way to prevent further propagation of the current event in the capturing and bubbling phases.
    [<CustomOperation("StopPropagation")>] member inline _.StopPropagation ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("StopPropagation" =>>> x)

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

/// Provides a mechanism for handling errors in a fluent manner within a specific context.
type FluentErrorBoundaryBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentComponentBaseBuilder<'FunBlazorGeneric>()
    /// Gets or sets a value indicating whether child content should be hidden when an error occurs.
    /// Using False is not recommended, as it may cause performance and security issues:
    /// If the detected error is triggered when the content is displayed, there is a risk of an infinite loop.
    [<CustomOperation("HideChildContentOnError")>] member inline _.HideChildContentOnError ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("HideChildContentOnError" =>>> true)
    /// Gets or sets a value indicating whether child content should be hidden when an error occurs.
    /// Using False is not recommended, as it may cause performance and security issues:
    /// If the detected error is triggered when the content is displayed, there is a risk of an infinite loop.
    [<CustomOperation("HideChildContentOnError")>] member inline _.HideChildContentOnError ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("HideChildContentOnError" =>>> x)
    /// Gets or sets the content to be rendered as the dialog header for error messages.
    ///  This content will be rendered in place of the default dialog header when an error occurs within the boundary.
    [<CustomOperation("ErrorHeader")>] member inline _.ErrorHeader ([<InlineIfLambda>] render: AttrRenderFragment, fragment: NodeRenderFragment) = render ==> html.renderFragment("ErrorHeader", fragment)
    /// Gets or sets the content to be rendered as the dialog header for error messages.
    ///  This content will be rendered in place of the default dialog header when an error occurs within the boundary.
    [<CustomOperation("ErrorHeader")>] member inline _.ErrorHeader ([<InlineIfLambda>] render: AttrRenderFragment, fragments: NodeRenderFragment seq) = render ==> html.renderFragment("ErrorHeader", fragment { yield! fragments })
    /// Gets or sets the content to be rendered as the dialog header for error messages.
    ///  This content will be rendered in place of the default dialog header when an error occurs within the boundary.
    [<CustomOperation("ErrorHeader")>] member inline _.ErrorHeader ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("ErrorHeader", html.text x)
    /// Gets or sets the content to be rendered as the dialog header for error messages.
    ///  This content will be rendered in place of the default dialog header when an error occurs within the boundary.
    [<CustomOperation("ErrorHeader")>] member inline _.ErrorHeader ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("ErrorHeader", html.text x)
    /// Gets or sets the content to be rendered as the dialog header for error messages.
    ///  This content will be rendered in place of the default dialog header when an error occurs within the boundary.
    [<CustomOperation("ErrorHeader")>] member inline _.ErrorHeader ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("ErrorHeader", html.text x)
    /// Gets or sets the content to be displayed when there is an error. This content will be rendered in a dialog box.
    /// This content will be rendered in place of the default error message when an error occurs within the boundary.
    [<CustomOperation("ErrorContent")>] member inline _.ErrorContent ([<InlineIfLambda>] render: AttrRenderFragment, fragment: NodeRenderFragment) = render ==> html.renderFragment("ErrorContent", fragment)
    /// Gets or sets the content to be displayed when there is an error. This content will be rendered in a dialog box.
    /// This content will be rendered in place of the default error message when an error occurs within the boundary.
    [<CustomOperation("ErrorContent")>] member inline _.ErrorContent ([<InlineIfLambda>] render: AttrRenderFragment, fragments: NodeRenderFragment seq) = render ==> html.renderFragment("ErrorContent", fragment { yield! fragments })
    /// Gets or sets the content to be displayed when there is an error. This content will be rendered in a dialog box.
    /// This content will be rendered in place of the default error message when an error occurs within the boundary.
    [<CustomOperation("ErrorContent")>] member inline _.ErrorContent ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("ErrorContent", html.text x)
    /// Gets or sets the content to be displayed when there is an error. This content will be rendered in a dialog box.
    /// This content will be rendered in place of the default error message when an error occurs within the boundary.
    [<CustomOperation("ErrorContent")>] member inline _.ErrorContent ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("ErrorContent", html.text x)
    /// Gets or sets the content to be displayed when there is an error. This content will be rendered in a dialog box.
    /// This content will be rendered in place of the default error message when an error occurs within the boundary.
    [<CustomOperation("ErrorContent")>] member inline _.ErrorContent ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("ErrorContent", html.text x)
    /// Gets or sets the details to display when an error occurs within the error boundary.
    [<CustomOperation("DisplayErrorDetails")>] member inline _.DisplayErrorDetails ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.FluentUI.AspNetCore.Components.ErrorBoundaryDetails) = render ==> ("DisplayErrorDetails" => x)
    /// Gets or sets the maximum number of errors that can be handled. If more errors are received,
    /// they will be treated as fatal. Calling Recover resets the count.
    [<CustomOperation("MaximumErrorCount")>] member inline _.MaximumErrorCount ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("MaximumErrorCount" => x)
    /// Gets or sets the URL to navigate to after an error occurs.
    [<CustomOperation("OnCloseRedirectUrl")>] member inline _.OnCloseRedirectUrl ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("OnCloseRedirectUrl" => x)

/// Field adds a label, validation message, and hint text to a control.
type FluentFieldBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentComponentBaseBuilder<'FunBlazorGeneric>()
    /// Gets or sets an existing FieldInput component to use in the field.
    /// Setting this parameter will define the parameters
    /// Label, LabelTemplate, FieldStartTemplate, FieldEndTemplate, LabelPosition, LabelWidth,
    /// Required, Disabled,
    /// Message, MessageIcon, MessageTemplate, and MessageCondition.
    [<CustomOperation("InputComponent")>] member inline _.InputComponent ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.FluentUI.AspNetCore.Components.IFluentField) = render ==> ("InputComponent" => x)
    /// Gets or sets the field expression for which validation messages should be displayed.
    [<CustomOperation("ValueExpression")>] member inline _.ValueExpression ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Linq.Expressions.LambdaExpression) = render ==> ("ValueExpression" => x)
    /// Gets or sets the ID of the FieldInput component to associate with the field.
    [<CustomOperation("ForId")>] member inline _.ForId ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("ForId" => x)
    /// Gets or sets the text to label the input. This is usually displayed just above the input.
    [<CustomOperation("Label")>] member inline _.Label ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Label" => x)
    /// Gets or sets the content to label the input component.
    /// This is usually displayed just above the input: see LabelPosition 
    [<CustomOperation("LabelTemplate")>] member inline _.LabelTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragment: NodeRenderFragment) = render ==> html.renderFragment("LabelTemplate", fragment)
    /// Gets or sets the content to label the input component.
    /// This is usually displayed just above the input: see LabelPosition 
    [<CustomOperation("LabelTemplate")>] member inline _.LabelTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragments: NodeRenderFragment seq) = render ==> html.renderFragment("LabelTemplate", fragment { yield! fragments })
    /// Gets or sets the content to label the input component.
    /// This is usually displayed just above the input: see LabelPosition 
    [<CustomOperation("LabelTemplate")>] member inline _.LabelTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("LabelTemplate", html.text x)
    /// Gets or sets the content to label the input component.
    /// This is usually displayed just above the input: see LabelPosition 
    [<CustomOperation("LabelTemplate")>] member inline _.LabelTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("LabelTemplate", html.text x)
    /// Gets or sets the content to label the input component.
    /// This is usually displayed just above the input: see LabelPosition 
    [<CustomOperation("LabelTemplate")>] member inline _.LabelTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("LabelTemplate", html.text x)
    /// Gets or sets the content to display before the input component.
    [<CustomOperation("FieldStartTemplate")>] member inline _.FieldStartTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragment: NodeRenderFragment) = render ==> html.renderFragment("FieldStartTemplate", fragment)
    /// Gets or sets the content to display before the input component.
    [<CustomOperation("FieldStartTemplate")>] member inline _.FieldStartTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragments: NodeRenderFragment seq) = render ==> html.renderFragment("FieldStartTemplate", fragment { yield! fragments })
    /// Gets or sets the content to display before the input component.
    [<CustomOperation("FieldStartTemplate")>] member inline _.FieldStartTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("FieldStartTemplate", html.text x)
    /// Gets or sets the content to display before the input component.
    [<CustomOperation("FieldStartTemplate")>] member inline _.FieldStartTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("FieldStartTemplate", html.text x)
    /// Gets or sets the content to display before the input component.
    [<CustomOperation("FieldStartTemplate")>] member inline _.FieldStartTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("FieldStartTemplate", html.text x)
    /// Gets or sets the content to display after the input component.
    [<CustomOperation("FieldEndTemplate")>] member inline _.FieldEndTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragment: NodeRenderFragment) = render ==> html.renderFragment("FieldEndTemplate", fragment)
    /// Gets or sets the content to display after the input component.
    [<CustomOperation("FieldEndTemplate")>] member inline _.FieldEndTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragments: NodeRenderFragment seq) = render ==> html.renderFragment("FieldEndTemplate", fragment { yield! fragments })
    /// Gets or sets the content to display after the input component.
    [<CustomOperation("FieldEndTemplate")>] member inline _.FieldEndTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("FieldEndTemplate", html.text x)
    /// Gets or sets the content to display after the input component.
    [<CustomOperation("FieldEndTemplate")>] member inline _.FieldEndTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("FieldEndTemplate", html.text x)
    /// Gets or sets the content to display after the input component.
    [<CustomOperation("FieldEndTemplate")>] member inline _.FieldEndTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("FieldEndTemplate", html.text x)
    /// Gets or sets the position of the label relative to the input.
    [<CustomOperation("LabelPosition")>] member inline _.LabelPosition ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<Microsoft.FluentUI.AspNetCore.Components.LabelPosition>) = render ==> ("LabelPosition" => x)
    /// Gets or sets the width of the label.
    [<CustomOperation("LabelWidth")>] member inline _.LabelWidth ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("LabelWidth" => x)
    /// Gets or sets a value indicating whether the element needs to have a value.
    [<CustomOperation("Required")>] member inline _.Required ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Boolean>) = render ==> ("Required" => x)
    /// Gets or sets a value indicating whether the form control is disabled and doesn't participate in form submission.
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Boolean>) = render ==> ("Disabled" => x)
    /// Gets or sets a value indicating whether the ChildContent should be rendered in an extra `div slot="input"`.
    [<CustomOperation("IncludeInputSlot")>] member inline _.IncludeInputSlot ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("IncludeInputSlot" =>>> true)
    /// Gets or sets a value indicating whether the ChildContent should be rendered in an extra `div slot="input"`.
    [<CustomOperation("IncludeInputSlot")>] member inline _.IncludeInputSlot ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("IncludeInputSlot" =>>> x)
    /// Gets or sets the message to display below the field.
    [<CustomOperation("Message")>] member inline _.Message ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Message" => x)
    /// Gets or sets the icon to display next to the message.
    /// You can use predefined icons from the FluentStatus class.
    [<CustomOperation("MessageIcon")>] member inline _.MessageIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.FluentUI.AspNetCore.Components.Icon) = render ==> ("MessageIcon" => x)
    /// Gets or sets the template for the message to display below the field.
    [<CustomOperation("MessageTemplate")>] member inline _.MessageTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragment: NodeRenderFragment) = render ==> html.renderFragment("MessageTemplate", fragment)
    /// Gets or sets the template for the message to display below the field.
    [<CustomOperation("MessageTemplate")>] member inline _.MessageTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragments: NodeRenderFragment seq) = render ==> html.renderFragment("MessageTemplate", fragment { yield! fragments })
    /// Gets or sets the template for the message to display below the field.
    [<CustomOperation("MessageTemplate")>] member inline _.MessageTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("MessageTemplate", html.text x)
    /// Gets or sets the template for the message to display below the field.
    [<CustomOperation("MessageTemplate")>] member inline _.MessageTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("MessageTemplate", html.text x)
    /// Gets or sets the template for the message to display below the field.
    [<CustomOperation("MessageTemplate")>] member inline _.MessageTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("MessageTemplate", html.text x)
    /// Gets or sets a value indicating whether the message should be displayed.
    [<CustomOperation("MessageCondition")>] member inline _.MessageCondition ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("MessageCondition" => (System.Func<Microsoft.FluentUI.AspNetCore.Components.IFluentField, System.Boolean>fn))
    /// Gets or sets a value that affects the content
    /// of the Message and the MessageIcon.
    [<CustomOperation("MessageState")>] member inline _.MessageState ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<Microsoft.FluentUI.AspNetCore.Components.MessageState>) = render ==> ("MessageState" => x)
    /// Gets or sets the informational content displayed next to the label
    /// using a FluentLabelInfo component.
    /// When InfoText or InfoActionLink is defined,
    /// an info icon is rendered inside the field label.
    [<CustomOperation("LabelInfo")>] member inline _.LabelInfo ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.FluentUI.AspNetCore.Components.ILabelInfo) = render ==> ("LabelInfo" => x)
    /// Gets or sets the FieldSize of the label in the field.
    [<CustomOperation("Size")>] member inline _.Size ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<Microsoft.FluentUI.AspNetCore.Components.FieldSize>) = render ==> ("Size" => x)

/// Displays validation messages for a specified field within a cascaded EditContext.
type FluentValidationMessageBuilder<'FunBlazorGeneric, 'TValue when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentComponentBaseBuilder<'FunBlazorGeneric>()
    /// Gets or sets the FieldIdentifier for which validation messages should be displayed.
    /// If set, this parameter takes precedence over For.
    [<CustomOperation("Field")>] member inline _.Field ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<Microsoft.AspNetCore.Components.Forms.FieldIdentifier>) = render ==> ("Field" => x)
    /// Gets or sets the field expression for which validation messages should be displayed.
    [<CustomOperation("For'")>] member inline _.For' ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Linq.Expressions.Expression<System.Func<'TValue>>) = render ==> ("For" => x)
    /// Gets or sets the icon displayed next to each validation message.
    [<CustomOperation("Icon")>] member inline _.Icon ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.FluentUI.AspNetCore.Components.Icon) = render ==> ("Icon" => x)

/// The grid component helps keeping layout consistent across various screen resolutions and sizes.
/// PowerGrid comes with a 12-point grid system and contains 5 types of breakpoints
/// that are used for specific screen sizes.
type FluentGridBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentComponentBaseBuilder<'FunBlazorGeneric>()
    /// Gets or sets the distance between flexbox items, using a multiple of 4px.
    /// Only values from 0 to 10 are possible.
    [<CustomOperation("Spacing")>] member inline _.Spacing ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("Spacing" => x)
    /// Gets or sets how the browser distributes space between and around content items.
    [<CustomOperation("Justify")>] member inline _.Justify ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.FluentUI.AspNetCore.Components.JustifyContent) = render ==> ("Justify" => x)
    /// Gets or sets the adaptive rendering, which not render the HTML code when the item is hidden (true) or only hide the item by CSS (false).
    /// Default is false.
    [<CustomOperation("AdaptiveRendering")>] member inline _.AdaptiveRendering ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("AdaptiveRendering" =>>> true)
    /// Gets or sets the adaptive rendering, which not render the HTML code when the item is hidden (true) or only hide the item by CSS (false).
    /// Default is false.
    [<CustomOperation("AdaptiveRendering")>] member inline _.AdaptiveRendering ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("AdaptiveRendering" =>>> x)
    /// Event raised when page size falls within a specific size range (xs, sm, md, lg, xl, xxl).
    [<CustomOperation("OnBreakpointEnter")>] member inline _.OnBreakpointEnter ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.FluentUI.AspNetCore.Components.GridItemSize -> unit) = render ==> html.callback("OnBreakpointEnter", fn)
    /// Event raised when page size falls within a specific size range (xs, sm, md, lg, xl, xxl).
    [<CustomOperation("OnBreakpointEnter")>] member inline _.OnBreakpointEnter ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.FluentUI.AspNetCore.Components.GridItemSize -> Task<unit>) = render ==> html.callbackTask("OnBreakpointEnter", fn)

/// Value placed within a FluentGrid layout using the FluentGridItem component.
type FluentGridItemBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentComponentBaseBuilder<'FunBlazorGeneric>()
    /// Gets or sets the number of columns (1–12) the item spans on Extra Small devices (portrait phones, less than 600px wide).
    /// Use with Sm, Md, Lg, Xl, Xxl for responsive layouts.
    [<CustomOperation("Xs")>] member inline _.Xs ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Int32>) = render ==> ("Xs" => x)
    /// Gets or sets the number of columns (1–12) the item spans on Small devices (landscape phones, less than 960px wide).
    /// Use with Xs, Md, Lg, Xl, Xxl for responsive layouts.
    [<CustomOperation("Sm")>] member inline _.Sm ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Int32>) = render ==> ("Sm" => x)
    /// Gets or sets the number of columns (1–12) the item spans on Medium devices (tablets, less than 1280px wide).
    /// Use with Xs, Sm, Lg, Xl, Xxl for responsive layouts.
    [<CustomOperation("Md")>] member inline _.Md ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Int32>) = render ==> ("Md" => x)
    /// Gets or sets the number of columns (1–12) the item spans on Large devices (desktops, less than 1920px wide).
    /// Use with Xs, Sm, Md, Xl, Xxl for responsive layouts.
    [<CustomOperation("Lg")>] member inline _.Lg ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Int32>) = render ==> ("Lg" => x)
    /// Gets or sets the number of columns (1–12) the item spans on Extra Large devices (large desktops, less than 2560px wide).
    /// Use with Xs, Sm, Md, Lg, Xxl for responsive layouts.
    [<CustomOperation("Xl")>] member inline _.Xl ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Int32>) = render ==> ("Xl" => x)
    /// Gets or sets the number of columns (1–12) the item spans on Extra Extra Large devices (larger desktops, more than 2560px wide).
    /// Use with Xs, Sm, Md, Lg, Xl for responsive layouts.
    [<CustomOperation("Xxl")>] member inline _.Xxl ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Int32>) = render ==> ("Xxl" => x)
    /// Gets or sets the visual order of this item on Extra Small devices (portrait phones, less than 600px wide).
    /// Use -1 for first, a value from 0 to 5, or 6 for last.
    [<CustomOperation("OrderXs")>] member inline _.OrderXs ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Int32>) = render ==> ("OrderXs" => x)
    /// Gets or sets the visual order of this item on Small devices (landscape phones, 600px wide and up).
    /// Use -1 for first, a value from 0 to 5, or 6 for last.
    [<CustomOperation("OrderSm")>] member inline _.OrderSm ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Int32>) = render ==> ("OrderSm" => x)
    /// Gets or sets the visual order of this item on Medium devices (tablets, 960px wide and up).
    /// Use -1 for first, a value from 0 to 5, or 6 for last.
    [<CustomOperation("OrderMd")>] member inline _.OrderMd ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Int32>) = render ==> ("OrderMd" => x)
    /// Gets or sets the visual order of this item on Large devices (desktops, 1280px wide and up).
    /// Use -1 for first, a value from 0 to 5, or 6 for last.
    [<CustomOperation("OrderLg")>] member inline _.OrderLg ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Int32>) = render ==> ("OrderLg" => x)
    /// Gets or sets the visual order of this item on Extra Large devices (large desktops, 1920px wide and up).
    /// Use -1 for first, a value from 0 to 5, or 6 for last.
    [<CustomOperation("OrderXl")>] member inline _.OrderXl ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Int32>) = render ==> ("OrderXl" => x)
    /// Gets or sets the visual order of this item on Extra Extra Large devices (larger desktops, 2560px wide and up).
    /// Use -1 for first, a value from 0 to 5, or 6 for last.
    [<CustomOperation("OrderXxl")>] member inline _.OrderXxl ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Int32>) = render ==> ("OrderXxl" => x)
    /// Gets or sets how the browser distributes space between and around content items within this grid item.
    [<CustomOperation("Justify")>] member inline _.Justify ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<Microsoft.FluentUI.AspNetCore.Components.JustifyContent>) = render ==> ("Justify" => x)
    /// Gets or sets the gaps (gutters) between rows and columns (e.g., Gap="8px").
    /// See CSS gap.
    [<CustomOperation("Gap")>] member inline _.Gap ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Gap" => x)
    /// Gets or sets the adaptive rendering behavior: when true, the HTML is not rendered when the item is hidden;
    /// when false, the item is hidden via CSS only. Default is false.
    [<CustomOperation("AdaptiveRendering")>] member inline _.AdaptiveRendering ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Boolean>) = render ==> ("AdaptiveRendering" => x)
    /// Gets or sets the breakpoint sizes at which this item is hidden (e.g., HiddenWhen="GridItemHidden.Sm | GridItemHidden.Xl").
    /// See GridItemHidden for available values.
    [<CustomOperation("HiddenWhen")>] member inline _.HiddenWhen ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<Microsoft.FluentUI.AspNetCore.Components.GridItemHidden>) = render ==> ("HiddenWhen" => x)

/// A component which highlights words or phrases within text.
type FluentHighlighterBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentComponentBaseBuilder<'FunBlazorGeneric>()
    /// Gets or sets a value indicating whether the highlighted text is case sensitive.
    [<CustomOperation("CaseSensitive")>] member inline _.CaseSensitive ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("CaseSensitive" =>>> true)
    /// Gets or sets a value indicating whether the highlighted text is case sensitive.
    [<CustomOperation("CaseSensitive")>] member inline _.CaseSensitive ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("CaseSensitive" =>>> x)
    /// Gets or sets the search term to highlight within Text (e.g., HighlightedText="blazor").
    /// Use CaseSensitive to control case sensitivity and Delimiters to split the term.
    [<CustomOperation("HighlightedText")>] member inline _.HighlightedText ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("HighlightedText" => x)
    /// Gets or sets the whole text in which a fragment will be highlighted.
    [<CustomOperation("Text")>] member inline _.Text ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Text" => x)
    /// Gets or sets the list of delimiters chars. Example: " ,;".
    [<CustomOperation("Delimiters")>] member inline _.Delimiters ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Delimiters" => x)
    /// Gets or sets whether the HighlightedText match should extend until the next regex word boundary.
    [<CustomOperation("UntilNextBoundary")>] member inline _.UntilNextBoundary ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("UntilNextBoundary" =>>> true)
    /// Gets or sets whether the HighlightedText match should extend until the next regex word boundary.
    [<CustomOperation("UntilNextBoundary")>] member inline _.UntilNextBoundary ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("UntilNextBoundary" =>>> x)

/// FluentIcon is a component that renders an icon from the Fluent System icon set.
type FluentIconBuilder<'FunBlazorGeneric, 'Icon when 'Icon : (new : unit -> 'Icon) and 'Icon :> Microsoft.FluentUI.AspNetCore.Components.Icon and 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentComponentBaseBuilder<'FunBlazorGeneric>()
    /// Gets or sets a reference to the rendered element.
    /// May be null if accessed before the component is rendered.
    [<CustomOperation("Element")>] member inline _.Element ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.AspNetCore.Components.ElementReference) = render ==> ("Element" => x)
    /// Gets or sets the slot where the icon is displayed in.
    [<CustomOperation("Slot")>] member inline _.Slot ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Slot" => x)
    /// Gets or sets the title for the icon.
    [<CustomOperation("Title")>] member inline _.Title ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Title" => x)
    /// Gets or sets the icon drawing and fill color. 
    /// Value comes from the Color enumeration. Defaults to Accent.
    [<CustomOperation("Color")>] member inline _.Color ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<Microsoft.FluentUI.AspNetCore.Components.Color>) = render ==> ("Color" => x)
    /// Gets or sets the icon drawing and fill color to a custom value.
    /// Needs to be formatted as an HTML hex color string (#RRGGBB or #RGB) or CSS variable.
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
    /// Gets or sets whether the click event should stop propagation.
    [<CustomOperation("OnClickStopPropagation")>] member inline _.OnClickStopPropagation ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("OnClickStopPropagation" =>>> true)
    /// Gets or sets whether the click event should stop propagation.
    [<CustomOperation("OnClickStopPropagation")>] member inline _.OnClickStopPropagation ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("OnClickStopPropagation" =>>> x)
    /// Gets or sets whether the click event should prevent the default action.
    [<CustomOperation("OnClickPreventDefault")>] member inline _.OnClickPreventDefault ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("OnClickPreventDefault" =>>> true)
    /// Gets or sets whether the click event should prevent the default action.
    [<CustomOperation("OnClickPreventDefault")>] member inline _.OnClickPreventDefault ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("OnClickPreventDefault" =>>> x)
    /// Gets or sets whether the icon is focusable (adding tab-index="0" and role="button"),
    /// allows the icon to be focused sequentially (generally with the Tab key).
    [<CustomOperation("Focusable")>] member inline _.Focusable ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Focusable" =>>> true)
    /// Gets or sets whether the icon is focusable (adding tab-index="0" and role="button"),
    /// allows the icon to be focused sequentially (generally with the Tab key).
    [<CustomOperation("Focusable")>] member inline _.Focusable ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Focusable" =>>> x)
    /// Gets or sets the tooltip text (supports HTML tags).
    /// This parameter requires the presence of a 'FluentTooltipProvider' in your main/layout page.
    [<CustomOperation("Tooltip")>] member inline _.Tooltip ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Tooltip" => x)

/// The Fluent Image component is used to display an image, providing various options for styling and layout.
type FluentImageBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentComponentBaseBuilder<'FunBlazorGeneric>()
    /// Gets or sets the height of the image (e.g., Height="200px").
    [<CustomOperation("Height")>] member inline _.Height ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Height" => x)
    /// Gets or sets the width of the image (e.g., Width="300px").
    [<CustomOperation("Width")>] member inline _.Width ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Width" => x)
    /// Gets or sets the URL source of the image (e.g., Source="/images/photo.jpg").
    [<CustomOperation("Source")>] member inline _.Source ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Source" => x)
    /// Gets or sets the alternate text for the image.
    [<CustomOperation("AlternateText")>] member inline _.AlternateText ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("AlternateText" => x)
    /// Gets or sets a value indicating whether a border is rendered around the image.
    [<CustomOperation("Bordered")>] member inline _.Bordered ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Bordered" =>>> true)
    /// Gets or sets a value indicating whether a border is rendered around the image.
    [<CustomOperation("Bordered")>] member inline _.Bordered ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Bordered" =>>> x)
    /// Gets or sets whether the image is displayed as a block element, expanding its width to fill the available container space.
    [<CustomOperation("Block")>] member inline _.Block ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Block" =>>> true)
    /// Gets or sets whether the image is displayed as a block element, expanding its width to fill the available container space.
    [<CustomOperation("Block")>] member inline _.Block ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Block" =>>> x)
    /// Gets or sets a box shadow to further separate the image from the background.
    [<CustomOperation("Shadow")>] member inline _.Shadow ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Shadow" =>>> true)
    /// Gets or sets a box shadow to further separate the image from the background.
    [<CustomOperation("Shadow")>] member inline _.Shadow ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Shadow" =>>> x)
    /// Gets or sets the image shape ImageShape
    [<CustomOperation("Shape")>] member inline _.Shape ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<Microsoft.FluentUI.AspNetCore.Components.ImageShape>) = render ==> ("Shape" => x)
    /// Gets or sets the fit of the image, determines how it will be scaled and positioned within its parent container.
    [<CustomOperation("Fit")>] member inline _.Fit ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<Microsoft.FluentUI.AspNetCore.Components.ImageFit>) = render ==> ("Fit" => x)

/// Represents a component for handling file uploads with support for drag-and-drop, progress tracking, and file
/// validation.
type FluentInputFileBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentComponentBaseBuilder<'FunBlazorGeneric>()
    /// Gets or sets the component width.
    [<CustomOperation("Width")>] member inline _.Width ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Width" => x)
    /// Gets or sets the component height.
    [<CustomOperation("Height")>] member inline _.Height ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Height" => x)
    /// Gets or sets a value indicating whether multiple file selection is enabled.
    /// Set MaximumFileCount to change the maximum number of allowed files.
    [<CustomOperation("Multiple")>] member inline _.Multiple ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Multiple" =>>> true)
    /// Gets or sets a value indicating whether multiple file selection is enabled.
    /// Set MaximumFileCount to change the maximum number of allowed files.
    [<CustomOperation("Multiple")>] member inline _.Multiple ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Multiple" =>>> x)
    /// Gets or sets the maximum number of files allowed to be uploaded (e.g., MaximumFileCount="5").
    /// Default value is 10. Requires Multiple to be true.
    [<CustomOperation("MaximumFileCount")>] member inline _.MaximumFileCount ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("MaximumFileCount" => x)
    /// Gets or sets the maximum size of a file to be uploaded (in bytes).
    /// Default value is 10 MiB.
    [<CustomOperation("MaximumFileSize")>] member inline _.MaximumFileSize ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int64) = render ==> ("MaximumFileSize" => x)
    /// Gets or sets the size of the buffer used to read bytes from an uploaded file (in bytes).
    /// Default value is 10 KiB.
    [<CustomOperation("BufferSize")>] member inline _.BufferSize ([<InlineIfLambda>] render: AttrRenderFragment, x: System.UInt32) = render ==> ("BufferSize" => x)
    /// Gets or sets the filter for what file types the user can pick from the file input dialog box.
    /// Example: ".gif, .jpg, .png, .doc", "audio/*", "video/*", "image/*"
    /// See https://developer.mozilla.org/en-US/docs/Web/HTML/Attributes/accept
    /// for more information.
    [<CustomOperation("Accept")>] member inline _.Accept ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Accept" => x)
    /// Gets or sets a value indicating whether the form control is disabled and doesn't participate in form submission.
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Disabled" =>>> true)
    /// Gets or sets a value indicating whether the form control is disabled and doesn't participate in form submission.
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Disabled" =>>> x)
    /// Gets or sets the type of file reading.
    /// For SaveToTemporaryFolder, use LocalFile to retrieve the file.
    /// For Buffer, use Buffer to retrieve bytes.
    /// For Stream, use Stream to have full control over retrieving the file.
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
    /// Raise when a file raised an error.
    [<CustomOperation("OnFileError")>] member inline _.OnFileError ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.FluentUI.AspNetCore.Components.FluentInputFileErrorEventArgs -> unit) = render ==> html.callback("OnFileError", fn)
    /// Raise when a file raised an error.
    [<CustomOperation("OnFileError")>] member inline _.OnFileError ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.FluentUI.AspNetCore.Components.FluentInputFileErrorEventArgs -> Task<unit>) = render ==> html.callbackTask("OnFileError", fn)
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

/// Extends the OnKeyDown blazor event to provide a more fluent way to evaluate the key code.
/// The anchor must refer to the ID of an element (or sub-element) accepting the focus.
type FluentKeyCodeBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentComponentBaseBuilder<'FunBlazorGeneric>()
    /// Gets or sets a reference to the rendered element.
    /// May be null if accessed before the component is rendered.
    [<CustomOperation("Element")>] member inline _.Element ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.AspNetCore.Components.ElementReference) = render ==> ("Element" => x)
    /// Gets or sets whether the KeyCode engine is global (using document DOM element) or not (only for Anchor or ChildContent).
    [<CustomOperation("GlobalDocument")>] member inline _.GlobalDocument ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("GlobalDocument" =>>> true)
    /// Gets or sets whether the KeyCode engine is global (using document DOM element) or not (only for Anchor or ChildContent).
    [<CustomOperation("GlobalDocument")>] member inline _.GlobalDocument ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("GlobalDocument" =>>> x)
    /// Gets or sets the HTML tag name to use when rendering the component.
    /// The default value is "Span".
    [<CustomOperation("TagName")>] member inline _.TagName ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.FluentUI.AspNetCore.Components.FluentKeyCodeTag) = render ==> ("TagName" => x)
    /// Gets or sets the control identifier associated with the KeyCode engine.
    /// If not set, the KeyCode will be applied to the FluentKeyCode content: see ChildContent.
    /// This parameter is ignored when ChildContent is used.
    [<CustomOperation("Anchor")>] member inline _.Anchor ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Anchor" => x)
    /// Event triggered when a KeyDown event is raised.
    [<CustomOperation("OnKeyDown")>] member inline _.OnKeyDown ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.FluentUI.AspNetCore.Components.FluentKeyCodeEventArgs -> unit) = render ==> html.callback("OnKeyDown", fn)
    /// Event triggered when a KeyDown event is raised.
    [<CustomOperation("OnKeyDown")>] member inline _.OnKeyDown ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.FluentUI.AspNetCore.Components.FluentKeyCodeEventArgs -> Task<unit>) = render ==> html.callbackTask("OnKeyDown", fn)
    /// Event triggered when a KeyUp event is raised.
    [<CustomOperation("OnKeyUp")>] member inline _.OnKeyUp ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.FluentUI.AspNetCore.Components.FluentKeyCodeEventArgs -> unit) = render ==> html.callback("OnKeyUp", fn)
    /// Event triggered when a KeyUp event is raised.
    [<CustomOperation("OnKeyUp")>] member inline _.OnKeyUp ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.FluentUI.AspNetCore.Components.FluentKeyCodeEventArgs -> Task<unit>) = render ==> html.callbackTask("OnKeyUp", fn)
    /// Gets or sets whether modifier keys (Shift, Alt, Ctrl, Meta) should be ignored when evaluating the key code.
    [<CustomOperation("IgnoreModifier")>] member inline _.IgnoreModifier ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("IgnoreModifier" =>>> true)
    /// Gets or sets whether modifier keys (Shift, Alt, Ctrl, Meta) should be ignored when evaluating the key code.
    [<CustomOperation("IgnoreModifier")>] member inline _.IgnoreModifier ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("IgnoreModifier" =>>> x)
    /// Gets or sets the list of KeyCode to accept, and only this list, when evaluating the key code.
    [<CustomOperation("Only")>] member inline _.Only ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.FluentUI.AspNetCore.Components.KeyCode[]) = render ==> ("Only" => x)
    /// Gets or sets the list of KeyCode to ignore when evaluating the key code.
    [<CustomOperation("Ignore")>] member inline _.Ignore ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.FluentUI.AspNetCore.Components.KeyCode[]) = render ==> ("Ignore" => x)
    /// Gets or sets a way to prevent further propagation of the current event in the capturing and bubbling phases.
    [<CustomOperation("StopPropagation")>] member inline _.StopPropagation ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("StopPropagation" =>>> true)
    /// Gets or sets a way to prevent further propagation of the current event in the capturing and bubbling phases.
    [<CustomOperation("StopPropagation")>] member inline _.StopPropagation ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("StopPropagation" =>>> x)
    /// Gets or sets whether the default browser action should be prevented for all key events.
    /// Use PreventDefaultOnly to restrict prevention to specific keys.
    [<CustomOperation("PreventDefault")>] member inline _.PreventDefault ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("PreventDefault" =>>> true)
    /// Gets or sets whether the default browser action should be prevented for all key events.
    /// Use PreventDefaultOnly to restrict prevention to specific keys.
    [<CustomOperation("PreventDefault")>] member inline _.PreventDefault ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("PreventDefault" =>>> x)
    /// Gets or sets the list of KeyCode values for which the default browser action should be prevented.
    /// Use PreventDefault to prevent the default action for all key events.
    [<CustomOperation("PreventDefaultOnly")>] member inline _.PreventDefaultOnly ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.FluentUI.AspNetCore.Components.KeyCode[]) = render ==> ("PreventDefaultOnly" => x)
    /// Gets or sets whether the key pressed can be repeated.
    [<CustomOperation("StopRepeat")>] member inline _.StopRepeat ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("StopRepeat" =>>> true)
    /// Gets or sets whether the key pressed can be repeated.
    [<CustomOperation("StopRepeat")>] member inline _.StopRepeat ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("StopRepeat" =>>> x)
    /// Gets or sets whether multiple consecutive KeyDown events (key held down) should be suppressed.
    [<CustomOperation("PreventMultipleKeyDown")>] member inline _.PreventMultipleKeyDown ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("PreventMultipleKeyDown" =>>> true)
    /// Gets or sets whether multiple consecutive KeyDown events (key held down) should be suppressed.
    [<CustomOperation("PreventMultipleKeyDown")>] member inline _.PreventMultipleKeyDown ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("PreventMultipleKeyDown" =>>> x)

/// Component that defines a layout for a page, using a grid composed of a PanelHeader, a Footer and 3 columns: Menu, Value and Aside Pane.
/// For mobile devices (< 768px), the layout is a single column with the Menu, Value and Footer panes stacked vertically.
type FluentLayoutBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentComponentBaseBuilder<'FunBlazorGeneric>()
    /// Gets or sets the vertical scrollbar position:
    /// global to the entire LayoutContainer (true), or inside the content area (false).
    [<CustomOperation("GlobalScrollbar")>] member inline _.GlobalScrollbar ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("GlobalScrollbar" =>>> true)
    /// Gets or sets the vertical scrollbar position:
    /// global to the entire LayoutContainer (true), or inside the content area (false).
    [<CustomOperation("GlobalScrollbar")>] member inline _.GlobalScrollbar ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("GlobalScrollbar" =>>> x)
    /// Gets or sets the width of the layout container (e.g., Width="100%").
    [<CustomOperation("Width")>] member inline _.Width ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Width" => x)
    /// Gets or sets the height of the LayoutContainer.
    [<CustomOperation("Height")>] member inline _.Height ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Height" => x)
    /// Gets or sets the width, in pixels, at which the container switches to a mobile layout.
    /// Default is 768px.
    [<CustomOperation("MobileBreakdownWidth")>] member inline _.MobileBreakdownWidth ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("MobileBreakdownWidth" => x)
    /// Event raised when layout changes to a Native layout (true) or Desktop layout (false).
    [<CustomOperation("OnBreakpointEnter")>] member inline _.OnBreakpointEnter ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Boolean -> unit) = render ==> html.callback("OnBreakpointEnter", fn)
    /// Event raised when layout changes to a Native layout (true) or Desktop layout (false).
    [<CustomOperation("OnBreakpointEnter")>] member inline _.OnBreakpointEnter ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Boolean -> Task<unit>) = render ==> html.callbackTask("OnBreakpointEnter", fn)
    /// Gets or sets whether the Navigation content is rendered only when this area is visible.
    /// To reduce the HTML page size, the FluentLayoutHamburger is not rendered when the layout is in desktop mode.
    /// To use this feature, make sure to enable the Blazor interactive mode.
    [<CustomOperation("NavigationDeferredLoading")>] member inline _.NavigationDeferredLoading ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("NavigationDeferredLoading" =>>> true)
    /// Gets or sets whether the Navigation content is rendered only when this area is visible.
    /// To reduce the HTML page size, the FluentLayoutHamburger is not rendered when the layout is in desktop mode.
    /// To use this feature, make sure to enable the Blazor interactive mode.
    [<CustomOperation("NavigationDeferredLoading")>] member inline _.NavigationDeferredLoading ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("NavigationDeferredLoading" =>>> x)

/// Component to display a hamburger icon that can be used to open and close a menu, on mobile device only.
type FluentLayoutHamburgerBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentComponentBaseBuilder<'FunBlazorGeneric>()
    /// Gets or sets the icon to display.
    /// By default, this icon is a hamburger icon.
    [<CustomOperation("Icon")>] member inline _.Icon ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.FluentUI.AspNetCore.Components.Icon) = render ==> ("Icon" => x)
    /// Gets or sets the title to display when the user hovers over the hamburger icon.
    [<CustomOperation("IconTitle")>] member inline _.IconTitle ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("IconTitle" => x)
    /// Gets or sets the header to display when the hamburger menu is open.
    [<CustomOperation("PanelHeader")>] member inline _.PanelHeader ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("PanelHeader" => x)
    /// Gets or sets the header template to display when the hamburger menu is open.
    [<CustomOperation("PanelHeaderTemplate")>] member inline _.PanelHeaderTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragment: NodeRenderFragment) = render ==> html.renderFragment("PanelHeaderTemplate", fragment)
    /// Gets or sets the header template to display when the hamburger menu is open.
    [<CustomOperation("PanelHeaderTemplate")>] member inline _.PanelHeaderTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragments: NodeRenderFragment seq) = render ==> html.renderFragment("PanelHeaderTemplate", fragment { yield! fragments })
    /// Gets or sets the header template to display when the hamburger menu is open.
    [<CustomOperation("PanelHeaderTemplate")>] member inline _.PanelHeaderTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("PanelHeaderTemplate", html.text x)
    /// Gets or sets the header template to display when the hamburger menu is open.
    [<CustomOperation("PanelHeaderTemplate")>] member inline _.PanelHeaderTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("PanelHeaderTemplate", html.text x)
    /// Gets or sets the header template to display when the hamburger menu is open.
    [<CustomOperation("PanelHeaderTemplate")>] member inline _.PanelHeaderTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("PanelHeaderTemplate", html.text x)
    /// Gets or sets the panel position to display when the hamburger menu is open.
    /// Only Start and End are supported.
    /// The default value is Start.
    [<CustomOperation("PanelPosition")>] member inline _.PanelPosition ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.FluentUI.AspNetCore.Components.DialogAlignment) = render ==> ("PanelPosition" => x)
    /// Gets or sets the size of the panel to display when the hamburger menu is open.
    /// Default value is Medium.
    [<CustomOperation("PanelSize")>] member inline _.PanelSize ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.FluentUI.AspNetCore.Components.DialogSize) = render ==> ("PanelSize" => x)
    /// Event that is triggered when the hamburger menu is opened or closed.
    [<CustomOperation("OnOpened")>] member inline _.OnOpened ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.FluentUI.AspNetCore.Components.LayoutHamburgerEventArgs -> unit) = render ==> html.callback("OnOpened", fn)
    /// Event that is triggered when the hamburger menu is opened or closed.
    [<CustomOperation("OnOpened")>] member inline _.OnOpened ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.FluentUI.AspNetCore.Components.LayoutHamburgerEventArgs -> Task<unit>) = render ==> html.callbackTask("OnOpened", fn)
    /// Gets or sets whether the hamburger menu is visible or not.
    /// Default is null to display the hamburger icon only when the layout is in mobile mode.
    [<CustomOperation("Visible")>] member inline _.Visible ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Boolean>) = render ==> ("Visible" => x)
    /// Gets or sets the display mode for the hamburger menu (e.g., Display="HamburgerDisplay.MobileOnly").
    /// See HamburgerDisplay for available values.
    [<CustomOperation("Display")>] member inline _.Display ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.FluentUI.AspNetCore.Components.HamburgerDisplay) = render ==> ("Display" => x)
    /// Gets or sets the background color of the hamburger menu panel.
    [<CustomOperation("BackgroundColor")>] member inline _.BackgroundColor ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("BackgroundColor" => x)

/// Area of the layout where the item is placed.
type FluentLayoutItemBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentComponentBaseBuilder<'FunBlazorGeneric>()
    /// Gets or sets the type of area where the item is placed.
    [<CustomOperation("Area")>] member inline _.Area ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.FluentUI.AspNetCore.Components.LayoutArea) = render ==> ("Area" => x)
    /// Gets or sets the width of the item (e.g., Width="300px").
    [<CustomOperation("Width")>] member inline _.Width ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Width" => x)
    /// Gets or sets the height of the item.
    [<CustomOperation("Height")>] member inline _.Height ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Height" => x)
    /// Gets or sets whether the item is sticky.
    [<CustomOperation("Sticky")>] member inline _.Sticky ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Sticky" =>>> true)
    /// Gets or sets whether the item is sticky.
    [<CustomOperation("Sticky")>] member inline _.Sticky ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Sticky" =>>> x)

/// The FluentLink component specifies relationships between the current document and an external resource.
type FluentLinkBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentComponentBaseBuilder<'FunBlazorGeneric>()
    /// Gets or sets the callback invoked when the user clicks on the link.
    [<CustomOperation("OnClick")>] member inline _.OnClick ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.AspNetCore.Components.Web.MouseEventArgs -> unit) = render ==> html.callback("OnClick", fn)
    /// Gets or sets the callback invoked when the user clicks on the link.
    [<CustomOperation("OnClick")>] member inline _.OnClick ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.AspNetCore.Components.Web.MouseEventArgs -> Task<unit>) = render ==> html.callbackTask("OnClick", fn)
    /// Gets or sets the URL of the link (e.g., Href="/page" or Href="https://example.com").
    [<CustomOperation("Href")>] member inline _.Href ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Href" => x)
    /// Gets or sets the BCP 47 language code for the language of the linked document (e.g., HrefLang="en"). This is advisory only.
    [<CustomOperation("HrefLang")>] member inline _.HrefLang ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("HrefLang" => x)
    /// Gets or sets the referrer policy controlling how much referrer information is sent when following the link.
    [<CustomOperation("ReferrerPolicy")>] member inline _.ReferrerPolicy ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<Microsoft.FluentUI.AspNetCore.Components.LinkReferrerPolicy>) = render ==> ("ReferrerPolicy" => x)
    /// Gets or sets the relationship of the linked document to the current document.
    [<CustomOperation("Rel")>] member inline _.Rel ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<Microsoft.FluentUI.AspNetCore.Components.LinkRel>) = render ==> ("Rel" => x)
    /// Gets or sets the MIME type of the linked content (e.g., LinkType="application/pdf").
    [<CustomOperation("LinkType")>] member inline _.LinkType ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("LinkType" => x)
    /// Gets or sets the browsing context in which to open Href
    /// (e.g., Target="LinkTarget.Blank" to open in a new tab).
    [<CustomOperation("Target")>] member inline _.Target ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<Microsoft.FluentUI.AspNetCore.Components.LinkTarget>) = render ==> ("Target" => x)
    /// Gets or sets the visual appearance.
    /// Default is Default.
    [<CustomOperation("Appearance")>] member inline _.Appearance ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.FluentUI.AspNetCore.Components.LinkAppearance) = render ==> ("Appearance" => x)
    /// Gets or sets whether the link is rendered inline with surrounding text.
    [<CustomOperation("Inline")>] member inline _.Inline ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Inline" =>>> true)
    /// Gets or sets whether the link is rendered inline with surrounding text.
    [<CustomOperation("Inline")>] member inline _.Inline ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Inline" =>>> x)
    /// Gets or sets the Icon displayed at the start of link content.
    [<CustomOperation("IconStart")>] member inline _.IconStart ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.FluentUI.AspNetCore.Components.Icon) = render ==> ("IconStart" => x)
    /// Gets or sets the Icon displayed at the end of link content.
    [<CustomOperation("IconEnd")>] member inline _.IconEnd ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.FluentUI.AspNetCore.Components.Icon) = render ==> ("IconEnd" => x)
    /// Gets or sets the tooltip text (supports HTML tags).
    /// This parameter requires the presence of a 'FluentTooltipProvider' in your main/layout page.
    [<CustomOperation("Tooltip")>] member inline _.Tooltip ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Tooltip" => x)
    /// Gets or sets a value indicating whether the navigation should force a full page load instead of using Blazor's built-in navigation.
    /// Default is false, which uses Blazor's navigation.
    [<CustomOperation("ForceLoad")>] member inline _.ForceLoad ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("ForceLoad" =>>> true)
    /// Gets or sets a value indicating whether the navigation should force a full page load instead of using Blazor's built-in navigation.
    /// Default is false, which uses Blazor's navigation.
    [<CustomOperation("ForceLoad")>] member inline _.ForceLoad ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("ForceLoad" =>>> x)

/// The Option element is used to define an item contained in a List component.
type FluentOptionBuilder<'FunBlazorGeneric, 'TValue when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentComponentBaseBuilder<'FunBlazorGeneric>()
    /// Gets or sets a value indicating whether the element is disabled.
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Disabled" =>>> true)
    /// Gets or sets a value indicating whether the element is disabled.
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Disabled" =>>> x)
    /// Gets or sets the value of this option.
    [<CustomOperation("Value")>] member inline _.Value ([<InlineIfLambda>] render: AttrRenderFragment, x: 'TValue) = render ==> ("Value" => x)
    /// Gets or sets the name of this option.
    [<CustomOperation("Name")>] member inline _.Name ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Name" => x)
    /// Gets or sets the text to display in the dropdown when the option is selected
    [<CustomOperation("Text")>] member inline _.Text ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Text" => x)
    /// Gets or sets the value indicating whether the element is selected.
    [<CustomOperation("Selected")>] member inline _.Selected ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Selected" =>>> true)
    /// Gets or sets the value indicating whether the element is selected.
    [<CustomOperation("Selected")>] member inline _.Selected ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Selected" =>>> x)
    /// Gets or sets the content to display below the main option text.
    /// This can be used to add additional textual information (no markup) about the option.
    [<CustomOperation("Description")>] member inline _.Description ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Description" => x)

/// The Option element is used to define a `string` item contained in a List component.
/// This is a convenience class so that you don't have to specify the generic type parameter or
/// to have a weird syntax in Razor like `FluentOption TValue="string" Value="@("My value")"`.
type FluentOptionStringBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentOptionBuilder<'FunBlazorGeneric, System.String>()


/// A FreeOptionOutput allows one option to be written in free form.
type FreeOptionOutputBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentComponentBaseBuilder<'FunBlazorGeneric>()


/// A Menu component for handling menus and menu items in a user interface.
type FluentMenuBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentComponentBaseBuilder<'FunBlazorGeneric>()
    /// Gets or sets whether the menu opens on hover.
    [<CustomOperation("OpenOnHover")>] member inline _.OpenOnHover ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Boolean>) = render ==> ("OpenOnHover" => x)
    /// Gets or sets whether the menu opens on right click.
    /// Removes all other menu open interactions.
    [<CustomOperation("OpenOnContext")>] member inline _.OpenOnContext ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Boolean>) = render ==> ("OpenOnContext" => x)
    /// Gets or sets whether the menu closes automatically when the user scrolls outside of it.
    [<CustomOperation("CloseOnScroll")>] member inline _.CloseOnScroll ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Boolean>) = render ==> ("CloseOnScroll" => x)
    /// Gets or sets whether the menu stays open when an item is clicked.
    [<CustomOperation("PersistOnItemClick")>] member inline _.PersistOnItemClick ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Boolean>) = render ==> ("PersistOnItemClick" => x)
    /// Gets or sets the HTML element ID of the trigger element that opens this menu (e.g., Trigger="my-button-id").
    /// When set, clicking the referenced element toggles the menu open or closed.
    [<CustomOperation("Trigger")>] member inline _.Trigger ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Trigger" => x)
    /// Gets or sets the max height of the menu, e.g. 300px
    [<CustomOperation("Height")>] member inline _.Height ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Height" => x)
    /// Raised when a FluentMenuItem is clicked.
    [<CustomOperation("OnClick")>] member inline _.OnClick ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.FluentUI.AspNetCore.Components.MenuItemEventArgs -> unit) = render ==> html.callback("OnClick", fn)
    /// Raised when a FluentMenuItem is clicked.
    [<CustomOperation("OnClick")>] member inline _.OnClick ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.FluentUI.AspNetCore.Components.MenuItemEventArgs -> Task<unit>) = render ==> html.callbackTask("OnClick", fn)
    /// Raised when a FluentMenuItem's Checked state changes.
    [<CustomOperation("OnCheckedChanged")>] member inline _.OnCheckedChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.FluentUI.AspNetCore.Components.MenuItemEventArgs -> unit) = render ==> html.callback("OnCheckedChanged", fn)
    /// Raised when a FluentMenuItem's Checked state changes.
    [<CustomOperation("OnCheckedChanged")>] member inline _.OnCheckedChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.FluentUI.AspNetCore.Components.MenuItemEventArgs -> Task<unit>) = render ==> html.callbackTask("OnCheckedChanged", fn)
    /// Gets or sets the callback that is invoked when the menu's open state changes.
    [<CustomOperation("OpenedChanged")>] member inline _.OpenedChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Boolean -> unit) = render ==> html.callback("OpenedChanged", fn)
    /// Gets or sets the callback that is invoked when the menu's open state changes.
    [<CustomOperation("OpenedChanged")>] member inline _.OpenedChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Boolean -> Task<unit>) = render ==> html.callbackTask("OpenedChanged", fn)
    /// Gets or sets the tooltip text (supports HTML tags).
    /// This parameter requires the presence of a 'FluentTooltipProvider' in your main/layout page.
    [<CustomOperation("Tooltip")>] member inline _.Tooltip ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Tooltip" => x)
    /// Gets or sets the condition that determines whether the menu is rendered.
    [<CustomOperation("RenderWhen")>] member inline _.RenderWhen ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("RenderWhen" => (System.Func<System.Boolean>fn))

/// Menu list item which is displayed in a MenuList component.
type FluentMenuItemBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentComponentBaseBuilder<'FunBlazorGeneric>()
    /// Gets or sets the role of the menu item.
    [<CustomOperation("Role")>] member inline _.Role ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<Microsoft.FluentUI.AspNetCore.Components.MenuItemRole>) = render ==> ("Role" => x)
    /// Gets or sets the checked state of the menu item.
    [<CustomOperation("Checked")>] member inline _.Checked ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Boolean>) = render ==> ("Checked" => x)
    /// Gets or sets the checked state of the menu item.
    [<CustomOperation("Checked'")>] member inline _.Checked' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.Nullable<System.Boolean> * (System.Nullable<System.Boolean> -> unit)) = render ==> html.bind("Checked", valueFn)
    /// Event raised for checkbox and radio menuitems
    [<CustomOperation("CheckedChanged")>] member inline _.CheckedChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Nullable<System.Boolean> -> unit) = render ==> html.callback("CheckedChanged", fn)
    /// Event raised for checkbox and radio menuitems
    [<CustomOperation("CheckedChanged")>] member inline _.CheckedChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Nullable<System.Boolean> -> Task<unit>) = render ==> html.callbackTask("CheckedChanged", fn)
    /// Gets or sets the menu item's disabled state.
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Boolean>) = render ==> ("Disabled" => x)
    /// Gets or sets the Icon displayed at the start (leading side) of the menu item content.
    /// Use IconEnd to add an icon at the end.
    [<CustomOperation("IconStart")>] member inline _.IconStart ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.FluentUI.AspNetCore.Components.Icon) = render ==> ("IconStart" => x)
    /// Gets or sets the Icon displayed at the end (trailing side) of the menu item content.
    /// Use IconStart to add an icon at the start.
    [<CustomOperation("IconEnd")>] member inline _.IconEnd ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.FluentUI.AspNetCore.Components.Icon) = render ==> ("IconEnd" => x)
    /// Gets or sets the Icon displayed as the indication of a submenu.
    [<CustomOperation("IconSubmenu")>] member inline _.IconSubmenu ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.FluentUI.AspNetCore.Components.Icon) = render ==> ("IconSubmenu" => x)
    /// Gets or sets the Icon displayed as the checked indicator for items with Role set to
    /// Checkbox or Radio.
    [<CustomOperation("IconIndicator")>] member inline _.IconIndicator ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.FluentUI.AspNetCore.Components.Icon) = render ==> ("IconIndicator" => x)
    /// Gets or sets the text label of the menu item.
    /// Use as an alternative to ChildContent for simple text; if both are set, both are rendered.
    [<CustomOperation("Label")>] member inline _.Label ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Label" => x)
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
    [<CustomOperation("OnClick")>] member inline _.OnClick ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.FluentUI.AspNetCore.Components.MenuItemEventArgs -> unit) = render ==> html.callback("OnClick", fn)
    /// Event raised when the user click on this item.
    [<CustomOperation("OnClick")>] member inline _.OnClick ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.FluentUI.AspNetCore.Components.MenuItemEventArgs -> Task<unit>) = render ==> html.callbackTask("OnClick", fn)

/// The MenuList displays a list of MenuItem options.
type FluentMenuListBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentComponentBaseBuilder<'FunBlazorGeneric>()
    /// Raised when a FluentMenuItem is clicked.
    [<CustomOperation("OnClick")>] member inline _.OnClick ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.FluentUI.AspNetCore.Components.MenuItemEventArgs -> unit) = render ==> html.callback("OnClick", fn)
    /// Raised when a FluentMenuItem is clicked.
    [<CustomOperation("OnClick")>] member inline _.OnClick ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.FluentUI.AspNetCore.Components.MenuItemEventArgs -> Task<unit>) = render ==> html.callbackTask("OnClick", fn)
    /// Raised when a FluentMenuItem's Checked state changes.
    [<CustomOperation("OnCheckedChanged")>] member inline _.OnCheckedChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.FluentUI.AspNetCore.Components.MenuItemEventArgs -> unit) = render ==> html.callback("OnCheckedChanged", fn)
    /// Raised when a FluentMenuItem's Checked state changes.
    [<CustomOperation("OnCheckedChanged")>] member inline _.OnCheckedChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.FluentUI.AspNetCore.Components.MenuItemEventArgs -> Task<unit>) = render ==> html.callbackTask("OnCheckedChanged", fn)

/// Component to communicate important information about the state of the entire application or surface
type FluentMessageBarBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentComponentBaseBuilder<'FunBlazorGeneric>()
    /// Gets or sets the intent of the message bar.
    /// Default is Info.
    [<CustomOperation("Intent")>] member inline _.Intent ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<Microsoft.FluentUI.AspNetCore.Components.MessageBarIntent>) = render ==> ("Intent" => x)
    /// Gets or sets the layout of the message bar.
    /// Default is SingleLine.
    [<CustomOperation("Layout")>] member inline _.Layout ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<Microsoft.FluentUI.AspNetCore.Components.MessageBarLayout>) = render ==> ("Layout" => x)
    /// Gets or sets the shape of the message bar.
    /// Default is Rounded.
    [<CustomOperation("Shape")>] member inline _.Shape ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<Microsoft.FluentUI.AspNetCore.Components.MessageBarShape>) = render ==> ("Shape" => x)
    /// Gets or sets the fade in animation when the message bar is shown.
    /// Default is none.
    [<CustomOperation("Animation")>] member inline _.Animation ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<Microsoft.FluentUI.AspNetCore.Components.MessageBarAnimation>) = render ==> ("Animation" => x)
    /// Gets or sets the `aria-live` attribute, to inform assistive technologies (like screen readers) about updates to dynamic content.
    [<CustomOperation("AriaLive")>] member inline _.AriaLive ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<Microsoft.FluentUI.AspNetCore.Components.AriaLive>) = render ==> ("AriaLive" => x)
    /// Gets or sets the icon to show in the message bar.
    /// When set, overrides the default icon determined by Intent.
    [<CustomOperation("Icon")>] member inline _.Icon ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.FluentUI.AspNetCore.Components.Icon) = render ==> ("Icon" => x)
    /// Gets or sets the plain-text title displayed in the message bar (e.g., Title="Action required").
    /// For security reasons, the content is sanitized using the configured MarkupSanitized before rendering.
    /// For formatted content with markup, use ChildContent instead.
    [<CustomOperation("Title")>] member inline _.Title ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Title" => x)
    /// Gets or sets the visibility of the message bar. Default is true.
    [<CustomOperation("Visible")>] member inline _.Visible ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Visible" =>>> true)
    /// Gets or sets the visibility of the message bar. Default is true.
    [<CustomOperation("Visible")>] member inline _.Visible ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Visible" =>>> x)
    /// Gets or sets a value indicating whether the message bar can be dismissed by the user. Default is true.
    [<CustomOperation("AllowDismiss")>] member inline _.AllowDismiss ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("AllowDismiss" =>>> true)
    /// Gets or sets a value indicating whether the message bar can be dismissed by the user. Default is true.
    [<CustomOperation("AllowDismiss")>] member inline _.AllowDismiss ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("AllowDismiss" =>>> x)
    /// Gets or sets the content to be displayed inline after the main content.
    [<CustomOperation("ActionsTemplate")>] member inline _.ActionsTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragment: NodeRenderFragment) = render ==> html.renderFragment("ActionsTemplate", fragment)
    /// Gets or sets the content to be displayed inline after the main content.
    [<CustomOperation("ActionsTemplate")>] member inline _.ActionsTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragments: NodeRenderFragment seq) = render ==> html.renderFragment("ActionsTemplate", fragment { yield! fragments })
    /// Gets or sets the content to be displayed inline after the main content.
    [<CustomOperation("ActionsTemplate")>] member inline _.ActionsTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("ActionsTemplate", html.text x)
    /// Gets or sets the content to be displayed inline after the main content.
    [<CustomOperation("ActionsTemplate")>] member inline _.ActionsTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("ActionsTemplate", html.text x)
    /// Gets or sets the content to be displayed inline after the main content.
    [<CustomOperation("ActionsTemplate")>] member inline _.ActionsTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("ActionsTemplate", html.text x)
    /// Gets or sets the timestamp when the message was created.
    /// Only displayed when ActionsTemplate is null.
    [<CustomOperation("TimeStamp")>] member inline _.TimeStamp ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.DateTime>) = render ==> ("TimeStamp" => x)

/// Container component that renders all message bars registered with the INotificationService.
type FluentMessageBarProviderBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentComponentBaseBuilder<'FunBlazorGeneric>()
    /// Gets or sets the section identifier for the message bar provider.
    /// This is used to scope the message bars to a specific section of the page: 
    /// only message bars with the same section identifier will be rendered in this provider.
    [<CustomOperation("Section")>] member inline _.Section ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Section" => x)

/// Represents a navigation menu component that displays a hamburger icon and provides navigation functionality within
/// a Fluent UI application.
type FluentNavBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentComponentBaseBuilder<'FunBlazorGeneric>()
    /// Gets or sets whether to enable using icons in the nav items.
    [<CustomOperation("UseIcons")>] member inline _.UseIcons ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("UseIcons" =>>> true)
    /// Gets or sets whether to enable using icons in the nav items.
    [<CustomOperation("UseIcons")>] member inline _.UseIcons ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("UseIcons" =>>> x)
    /// Gets or sets whether only one FluentNavCategory can be expanded at a time.
    /// When true, expanding one category automatically collapses all others.
    [<CustomOperation("UseSingleExpanded")>] member inline _.UseSingleExpanded ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("UseSingleExpanded" =>>> true)
    /// Gets or sets whether only one FluentNavCategory can be expanded at a time.
    /// When true, expanding one category automatically collapses all others.
    [<CustomOperation("UseSingleExpanded")>] member inline _.UseSingleExpanded ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("UseSingleExpanded" =>>> x)
    /// Gets or sets the density (spacing) of the navigation menu items (e.g., Density="NavDensity.Compact").
    [<CustomOperation("Density")>] member inline _.Density ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<Microsoft.FluentUI.AspNetCore.Components.NavDensity>) = render ==> ("Density" => x)
    /// Gets or sets the background color of the component.
    /// The default value is "var(--colorNeutralBackground4)".
    [<CustomOperation("BackgroundColor")>] member inline _.BackgroundColor ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("BackgroundColor" => x)
    /// Gets or sets the background color of the component when hovered.
    /// The default value is "var(--colorNeutralBackground4Hover)".
    [<CustomOperation("BackgroundColorHover")>] member inline _.BackgroundColorHover ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("BackgroundColorHover" => x)
    /// Gets or sets the callback that is invoked when a nav item is clicked.
    [<CustomOperation("OnItemClick")>] member inline _.OnItemClick ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.FluentUI.AspNetCore.Components.FluentNavItem -> unit) = render ==> html.callback("OnItemClick", fn)
    /// Gets or sets the callback that is invoked when a nav item is clicked.
    [<CustomOperation("OnItemClick")>] member inline _.OnItemClick ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.FluentUI.AspNetCore.Components.FluentNavItem -> Task<unit>) = render ==> html.callbackTask("OnItemClick", fn)
    /// Gets or sets the CSS width value to apply to the component.
    [<CustomOperation("Width")>] member inline _.Width ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Width" => x)

/// A section header for use within a FluentNav
type FluentNavSectionHeaderBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentComponentBaseBuilder<'FunBlazorGeneric>()
    /// Gets or sets the title of the section header.
    [<CustomOperation("Title")>] member inline _.Title ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Title" => x)

type FluentOverflowBuilder<'FunBlazorGeneric, 'TItem when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentComponentBaseBuilder<'FunBlazorGeneric>()
    /// Gets or sets the template to display ItemsOverflow elements.
    [<CustomOperation("OverflowTemplate")>] member inline _.OverflowTemplate ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.FluentUI.AspNetCore.Components.OverflowContext<'TItem> -> NodeRenderFragment) = render ==> html.renderFragment("OverflowTemplate", fn)
    /// Gets or sets whether overflow items are visible immediately on load.
    /// Set to false to hide items until the component is fully loaded,
    /// preventing a flickering effect. Defaults to true.
    [<CustomOperation("VisibleOnLoad")>] member inline _.VisibleOnLoad ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("VisibleOnLoad" =>>> true)
    /// Gets or sets whether overflow items are visible immediately on load.
    /// Set to false to hide items until the component is fully loaded,
    /// preventing a flickering effect. Defaults to true.
    [<CustomOperation("VisibleOnLoad")>] member inline _.VisibleOnLoad ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("VisibleOnLoad" =>>> x)
    /// Gets or sets the template to display the overflow trigger content.
    [<CustomOperation("MoreTemplate")>] member inline _.MoreTemplate ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.FluentUI.AspNetCore.Components.OverflowContext<'TItem> -> NodeRenderFragment) = render ==> html.renderFragment("MoreTemplate", fn)
    /// Gets or sets the callback invoked when the default overflow trigger is activated.
    /// Custom MoreTemplate content handles its own interaction.
    [<CustomOperation("OnMoreClick")>] member inline _.OnMoreClick ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.AspNetCore.Components.Web.MouseEventArgs -> unit) = render ==> html.callback("OnMoreClick", fn)
    /// Gets or sets the callback invoked when the default overflow trigger is activated.
    /// Custom MoreTemplate content handles its own interaction.
    [<CustomOperation("OnMoreClick")>] member inline _.OnMoreClick ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.AspNetCore.Components.Web.MouseEventArgs -> Task<unit>) = render ==> html.callbackTask("OnMoreClick", fn)
    /// Gets or sets the orientation of the items flow.
    [<CustomOperation("Orientation")>] member inline _.Orientation ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.FluentUI.AspNetCore.Components.Orientation) = render ==> ("Orientation" => x)
    /// Gets or sets the source items, in display order.
    [<CustomOperation("Items")>] member inline _.Items ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.IEnumerable<'TItem>) = render ==> ("Items" => x)
    /// Gets or sets the maximum number of source items rendered for measurement when Items is supplied.
    /// Remaining source items are included in the typed overflow context without being rendered.
    /// Values less than or equal to zero are unlimited. Defaults to zero.
    [<CustomOperation("MaxRenderedItems")>] member inline _.MaxRenderedItems ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("MaxRenderedItems" => x)
    /// Gets or sets the CSS selector of direct children to include in overflow.
    /// Applies only when Items is not supplied. Null or empty selects all direct children.
    [<CustomOperation("Selector")>] member inline _.Selector ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Selector" => x)
    /// Gets or sets the item template. Each item must produce exactly one root HTML element.
    /// Used when Items is supplied.
    [<CustomOperation("ItemTemplate")>] member inline _.ItemTemplate ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: 'TItem -> NodeRenderFragment) = render ==> html.renderFragment("ItemTemplate", fn)
    /// Gets or sets the text selector used by the default overflow tooltip.
    /// Defaults to the string representation of each source item.
    [<CustomOperation("ItemText")>] member inline _.ItemText ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("ItemText" => (System.Func<'TItem, System.String>fn))
    /// Gets or sets whether the tooltip is displayed using the TooltipService.
    [<CustomOperation("UseTooltipService")>] member inline _.UseTooltipService ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("UseTooltipService" =>>> true)
    /// Gets or sets whether the tooltip is displayed using the TooltipService.
    [<CustomOperation("UseTooltipService")>] member inline _.UseTooltipService ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("UseTooltipService" =>>> x)
    /// Event raised when overflow items change.
    [<CustomOperation("OnOverflowRaised")>] member inline _.OnOverflowRaised ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Collections.Generic.IEnumerable<Microsoft.FluentUI.AspNetCore.Components.OverflowItem> -> unit) = render ==> html.callback("OnOverflowRaised", fn)
    /// Event raised when overflow items change.
    [<CustomOperation("OnOverflowRaised")>] member inline _.OnOverflowRaised ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Collections.Generic.IEnumerable<Microsoft.FluentUI.AspNetCore.Components.OverflowItem> -> Task<unit>) = render ==> html.callbackTask("OnOverflowRaised", fn)

/// Represents an overlay component that provides visual layering and interaction blocking in Fluent UI applications.
type FluentOverlayBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentComponentBaseBuilder<'FunBlazorGeneric>()
    /// Gets or sets a value indicating whether the component is displayed in full screen mode.
    [<CustomOperation("FullScreen")>] member inline _.FullScreen ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("FullScreen" =>>> true)
    /// Gets or sets a value indicating whether the component is displayed in full screen mode.
    [<CustomOperation("FullScreen")>] member inline _.FullScreen ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("FullScreen" =>>> x)
    /// Gets or sets a value indicating whether the overlay allows interaction with underlying content.
    [<CustomOperation("Interactive")>] member inline _.Interactive ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Interactive" =>>> true)
    /// Gets or sets a value indicating whether the overlay allows interaction with underlying content.
    [<CustomOperation("Interactive")>] member inline _.Interactive ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Interactive" =>>> x)
    /// Gets or sets the background color of the overlay.
    /// Default is `var(--colorBackgroundOverlay)`.
    [<CustomOperation("BackgroundColor")>] member inline _.BackgroundColor ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("BackgroundColor" => x)
    /// Gets or sets the opacity level of the overlay background.
    /// Default is 40%.
    [<CustomOperation("Opacity")>] member inline _.Opacity ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("Opacity" => x)
    /// Gets or sets the mode that determines how the overlay can be closed.
    /// Default is All.
    [<CustomOperation("CloseMode")>] member inline _.CloseMode ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.FluentUI.AspNetCore.Components.OverlayCloseMode) = render ==> ("CloseMode" => x)
    /// Gets or sets a value indicating whether the overlay is visible.
    [<CustomOperation("Visible")>] member inline _.Visible ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Visible" =>>> true)
    /// Gets or sets a value indicating whether the overlay is visible.
    [<CustomOperation("Visible")>] member inline _.Visible ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Visible" =>>> x)
    /// Gets or sets a value indicating whether the overlay is visible.
    [<CustomOperation("Visible'")>] member inline _.Visible' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.Boolean * (System.Boolean -> unit)) = render ==> html.bind("Visible", valueFn)
    /// Gets or sets the callback that is invoked when the visibility state changes.
    [<CustomOperation("VisibleChanged")>] member inline _.VisibleChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Boolean -> unit) = render ==> html.callback("VisibleChanged", fn)
    /// Gets or sets the callback that is invoked when the visibility state changes.
    [<CustomOperation("VisibleChanged")>] member inline _.VisibleChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Boolean -> Task<unit>) = render ==> html.callbackTask("VisibleChanged", fn)

/// A component that provides a user interface for PaginationState.
type FluentPaginatorBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentComponentBaseBuilder<'FunBlazorGeneric>()
    /// Gets or sets the callback that is invoked when the current page index changes.
    [<CustomOperation("CurrentPageIndexChanged")>] member inline _.CurrentPageIndexChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Int32 -> unit) = render ==> html.callback("CurrentPageIndexChanged", fn)
    /// Gets or sets the callback that is invoked when the current page index changes.
    [<CustomOperation("CurrentPageIndexChanged")>] member inline _.CurrentPageIndexChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Int32 -> Task<unit>) = render ==> html.callbackTask("CurrentPageIndexChanged", fn)
    /// Gets or sets whether the pagination buttons are disabled.
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Disabled" =>>> true)
    /// Gets or sets whether the pagination buttons are disabled.
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

/// The FluentPopover component is used to displays content on top of other content.
type FluentPopoverBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentComponentBaseBuilder<'FunBlazorGeneric>()
    /// Gets or sets the id of the component the popover is positioned relative to.
    [<CustomOperation("AnchorId")>] member inline _.AnchorId ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("AnchorId" => x)
    /// Gets or sets the width of the popover component.
    [<CustomOperation("Width")>] member inline _.Width ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Width" => x)
    /// Gets or sets the height of the popover component.
    [<CustomOperation("Height")>] member inline _.Height ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Height" => x)
    /// Gets or sets the vertical offset value (pixels) between the popover and the anchor element.
    [<CustomOperation("OffsetVertical")>] member inline _.OffsetVertical ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("OffsetVertical" => x)
    /// Gets or sets the horizontal offset value (pixels) between the popover and the anchor element.
    [<CustomOperation("OffsetHorizontal")>] member inline _.OffsetHorizontal ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("OffsetHorizontal" => x)
    /// Gets or sets a value indicating whether the component is currently open.
    [<CustomOperation("Opened")>] member inline _.Opened ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Opened" =>>> true)
    /// Gets or sets a value indicating whether the component is currently open.
    [<CustomOperation("Opened")>] member inline _.Opened ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Opened" =>>> x)
    /// Gets or sets a value indicating whether the component is currently open.
    [<CustomOperation("Opened'")>] member inline _.Opened' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.Boolean * (System.Boolean -> unit)) = render ==> html.bind("Opened", valueFn)
    /// Gets or sets the callback that is invoked when the opened state changes.
    [<CustomOperation("OpenedChanged")>] member inline _.OpenedChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Boolean -> unit) = render ==> html.callback("OpenedChanged", fn)
    /// Gets or sets the callback that is invoked when the opened state changes.
    [<CustomOperation("OpenedChanged")>] member inline _.OpenedChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Boolean -> Task<unit>) = render ==> html.callbackTask("OpenedChanged", fn)
    /// Gets or sets a value indicating whether the popover is nested inside another popover.
    [<CustomOperation("Nested")>] member inline _.Nested ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Nested" =>>> true)
    /// Gets or sets a value indicating whether the popover is nested inside another popover.
    [<CustomOperation("Nested")>] member inline _.Nested ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Nested" =>>> x)

type FluentPullToRefreshBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentComponentBaseBuilder<'FunBlazorGeneric>()
    /// Gets or sets the direction to pull the ChildContent.
    /// Defaults to Down."/>
    [<CustomOperation("Direction")>] member inline _.Direction ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.FluentUI.AspNetCore.Components.PullDirection) = render ==> ("Direction" => x)
    /// Gets or sets whether the pull action is disabled.
    /// Defaults to false.
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Disabled" =>>> true)
    /// Gets or sets whether the pull action is disabled.
    /// Defaults to false.
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Disabled" =>>> x)
    /// Gets or sets whether the component should work on non-touch devices (by using an emulation script).
    /// Defaults to true.
    [<CustomOperation("EmulateTouch")>] member inline _.EmulateTouch ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("EmulateTouch" =>>> true)
    /// Gets or sets whether the component should work on non-touch devices (by using an emulation script).
    /// Defaults to true.
    [<CustomOperation("EmulateTouch")>] member inline _.EmulateTouch ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("EmulateTouch" =>>> x)
    /// Gets or sets whether a static tip is shown when ChildContent is not being pulled.
    /// Defaults to true.
    [<CustomOperation("ShowStaticTip")>] member inline _.ShowStaticTip ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("ShowStaticTip" =>>> true)
    /// Gets or sets whether a static tip is shown when ChildContent is not being pulled.
    /// Defaults to true.
    [<CustomOperation("ShowStaticTip")>] member inline _.ShowStaticTip ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("ShowStaticTip" =>>> x)
    /// Gets or sets the async callback invoked when a refresh is triggered.
    /// Return true if more data is available, or false to display the NoDataTemplate.
    [<CustomOperation("OnRefreshAsync")>] member inline _.OnRefreshAsync ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("OnRefreshAsync" => (System.Func<System.Threading.Tasks.Task<System.Boolean>>fn))
    /// Gets or sets the content to indicate the ChildContent can be refreshed by a pull down/up action.
    [<CustomOperation("PullingTemplate")>] member inline _.PullingTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragment: NodeRenderFragment) = render ==> html.renderFragment("PullingTemplate", fragment)
    /// Gets or sets the content to indicate the ChildContent can be refreshed by a pull down/up action.
    [<CustomOperation("PullingTemplate")>] member inline _.PullingTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragments: NodeRenderFragment seq) = render ==> html.renderFragment("PullingTemplate", fragment { yield! fragments })
    /// Gets or sets the content to indicate the ChildContent can be refreshed by a pull down/up action.
    [<CustomOperation("PullingTemplate")>] member inline _.PullingTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("PullingTemplate", html.text x)
    /// Gets or sets the content to indicate the ChildContent can be refreshed by a pull down/up action.
    [<CustomOperation("PullingTemplate")>] member inline _.PullingTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("PullingTemplate", html.text x)
    /// Gets or sets the content to indicate the ChildContent can be refreshed by a pull down/up action.
    [<CustomOperation("PullingTemplate")>] member inline _.PullingTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("PullingTemplate", html.text x)
    /// Gets or sets the content to indicate the pulled ChildContent must be released to start the refresh action.
    [<CustomOperation("ReleaseTemplate")>] member inline _.ReleaseTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragment: NodeRenderFragment) = render ==> html.renderFragment("ReleaseTemplate", fragment)
    /// Gets or sets the content to indicate the pulled ChildContent must be released to start the refresh action.
    [<CustomOperation("ReleaseTemplate")>] member inline _.ReleaseTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragments: NodeRenderFragment seq) = render ==> html.renderFragment("ReleaseTemplate", fragment { yield! fragments })
    /// Gets or sets the content to indicate the pulled ChildContent must be released to start the refresh action.
    [<CustomOperation("ReleaseTemplate")>] member inline _.ReleaseTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("ReleaseTemplate", html.text x)
    /// Gets or sets the content to indicate the pulled ChildContent must be released to start the refresh action.
    [<CustomOperation("ReleaseTemplate")>] member inline _.ReleaseTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("ReleaseTemplate", html.text x)
    /// Gets or sets the content to indicate the pulled ChildContent must be released to start the refresh action.
    [<CustomOperation("ReleaseTemplate")>] member inline _.ReleaseTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("ReleaseTemplate", html.text x)
    /// Gets or sets the content to indicate the ChildContent is being refreshed.
    [<CustomOperation("LoadingTemplate")>] member inline _.LoadingTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragment: NodeRenderFragment) = render ==> html.renderFragment("LoadingTemplate", fragment)
    /// Gets or sets the content to indicate the ChildContent is being refreshed.
    [<CustomOperation("LoadingTemplate")>] member inline _.LoadingTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragments: NodeRenderFragment seq) = render ==> html.renderFragment("LoadingTemplate", fragment { yield! fragments })
    /// Gets or sets the content to indicate the ChildContent is being refreshed.
    [<CustomOperation("LoadingTemplate")>] member inline _.LoadingTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("LoadingTemplate", html.text x)
    /// Gets or sets the content to indicate the ChildContent is being refreshed.
    [<CustomOperation("LoadingTemplate")>] member inline _.LoadingTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("LoadingTemplate", html.text x)
    /// Gets or sets the content to indicate the ChildContent is being refreshed.
    [<CustomOperation("LoadingTemplate")>] member inline _.LoadingTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("LoadingTemplate", html.text x)
    /// Gets or sets the content to indicate the ChildContent has been refreshed.
    [<CustomOperation("CompletedTemplate")>] member inline _.CompletedTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragment: NodeRenderFragment) = render ==> html.renderFragment("CompletedTemplate", fragment)
    /// Gets or sets the content to indicate the ChildContent has been refreshed.
    [<CustomOperation("CompletedTemplate")>] member inline _.CompletedTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragments: NodeRenderFragment seq) = render ==> html.renderFragment("CompletedTemplate", fragment { yield! fragments })
    /// Gets or sets the content to indicate the ChildContent has been refreshed.
    [<CustomOperation("CompletedTemplate")>] member inline _.CompletedTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("CompletedTemplate", html.text x)
    /// Gets or sets the content to indicate the ChildContent has been refreshed.
    [<CustomOperation("CompletedTemplate")>] member inline _.CompletedTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("CompletedTemplate", html.text x)
    /// Gets or sets the content to indicate the ChildContent has been refreshed.
    [<CustomOperation("CompletedTemplate")>] member inline _.CompletedTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("CompletedTemplate", html.text x)
    /// Gets or sets the content to indicate the ChildContent can not be refreshed anymore.
    [<CustomOperation("NoDataTemplate")>] member inline _.NoDataTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragment: NodeRenderFragment) = render ==> html.renderFragment("NoDataTemplate", fragment)
    /// Gets or sets the content to indicate the ChildContent can not be refreshed anymore.
    [<CustomOperation("NoDataTemplate")>] member inline _.NoDataTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragments: NodeRenderFragment seq) = render ==> html.renderFragment("NoDataTemplate", fragment { yield! fragments })
    /// Gets or sets the content to indicate the ChildContent can not be refreshed anymore.
    [<CustomOperation("NoDataTemplate")>] member inline _.NoDataTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("NoDataTemplate", html.text x)
    /// Gets or sets the content to indicate the ChildContent can not be refreshed anymore.
    [<CustomOperation("NoDataTemplate")>] member inline _.NoDataTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("NoDataTemplate", html.text x)
    /// Gets or sets the content to indicate the ChildContent can not be refreshed anymore.
    [<CustomOperation("NoDataTemplate")>] member inline _.NoDataTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("NoDataTemplate", html.text x)
    /// Gets or sets the distance the ChildContent needs to be pulled (in pixels) to initiate a refresh action.
    /// Default is 32px
    [<CustomOperation("DragDistance")>] member inline _.DragDistance ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("DragDistance" => x)
    /// Gets or sets the height of the tip fragment (if shown).
    /// Default is 32px
    [<CustomOperation("TipHeight")>] member inline _.TipHeight ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("TipHeight" => x)
    /// Gets or sets the amount of time (in milliseconds) a status update message will be displayed.
    /// Default is 750
    [<CustomOperation("StatusUpdateMessageTimeout")>] member inline _.StatusUpdateMessageTimeout ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("StatusUpdateMessageTimeout" => x)
    /// Gets or sets the threshold distance the ChildContent needs to be pulled (in pixels) to start the tip pull action.
    [<CustomOperation("DragThreshold")>] member inline _.DragThreshold ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("DragThreshold" => x)

/// A Fluent Radio button component.
type FluentRadioBuilder<'FunBlazorGeneric, 'TValue when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentComponentBaseBuilder<'FunBlazorGeneric>()
    /// Gets or sets a value indicating whether the form control is disabled and doesn't participate in form submission.
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Boolean>) = render ==> ("Disabled" => x)
    /// Gets or sets the text to label the input. This is usually displayed just above the input.
    [<CustomOperation("Label")>] member inline _.Label ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Label" => x)
    /// Gets or sets the content to label the input component.
    /// This is usually displayed just above the input: see LabelPosition 
    [<CustomOperation("LabelTemplate")>] member inline _.LabelTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragment: NodeRenderFragment) = render ==> html.renderFragment("LabelTemplate", fragment)
    /// Gets or sets the content to label the input component.
    /// This is usually displayed just above the input: see LabelPosition 
    [<CustomOperation("LabelTemplate")>] member inline _.LabelTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragments: NodeRenderFragment seq) = render ==> html.renderFragment("LabelTemplate", fragment { yield! fragments })
    /// Gets or sets the content to label the input component.
    /// This is usually displayed just above the input: see LabelPosition 
    [<CustomOperation("LabelTemplate")>] member inline _.LabelTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("LabelTemplate", html.text x)
    /// Gets or sets the content to label the input component.
    /// This is usually displayed just above the input: see LabelPosition 
    [<CustomOperation("LabelTemplate")>] member inline _.LabelTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("LabelTemplate", html.text x)
    /// Gets or sets the content to label the input component.
    /// This is usually displayed just above the input: see LabelPosition 
    [<CustomOperation("LabelTemplate")>] member inline _.LabelTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("LabelTemplate", html.text x)
    /// Gets or sets the width of the label.
    [<CustomOperation("LabelWidth")>] member inline _.LabelWidth ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("LabelWidth" => x)
    /// Gets or sets the value of the radio element.
    [<CustomOperation("Value")>] member inline _.Value ([<InlineIfLambda>] render: AttrRenderFragment, x: 'TValue) = render ==> ("Value" => x)

/// Displays a read-only star rating, such as an average product score or user review summary.
type FluentRatingDisplayBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentComponentBaseBuilder<'FunBlazorGeneric>()
    /// Gets or sets the color of the rating display items.
    [<CustomOperation("Color")>] member inline _.Color ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<Microsoft.FluentUI.AspNetCore.Components.RatingDisplayColor>) = render ==> ("Color" => x)
    /// Gets or sets a value indicating whether compact mode is enabled.
    /// When true, renders a single filled star with the numeric value next to it.
    [<CustomOperation("Compact")>] member inline _.Compact ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Boolean>) = render ==> ("Compact" => x)
    /// Gets or sets the number of ratings represented by the rating value.
    /// This will be formatted with a thousands separator (if applicable) and displayed next to the value.
    [<CustomOperation("Count")>] member inline _.Count ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Double>) = render ==> ("Count" => x)
    /// Gets or sets the maximum number of rating items displayed (e.g., Max="5").
    /// Must be a whole number greater than 1. See also Value.
    [<CustomOperation("Max")>] member inline _.Max ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Byte>) = render ==> ("Max" => x)
    /// Gets or sets the size of the rating items (e.g., Size="RatingSize.Small").
    [<CustomOperation("Size")>] member inline _.Size ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<Microsoft.FluentUI.AspNetCore.Components.RatingSize>) = render ==> ("Size" => x)
    /// Gets or sets the icon used for each rating item.
    /// Defaults to a star icon. Provide any Icon instance to customize the shape.
    [<CustomOperation("Shape")>] member inline _.Shape ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.FluentUI.AspNetCore.Components.Icon) = render ==> ("Shape" => x)
    /// Gets or sets the current rating value (e.g., Value="3.5").
    /// Must be between 0 and Max.
    [<CustomOperation("Value")>] member inline _.Value ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Double>) = render ==> ("Value" => x)
    /// Gets or sets the tooltip text (supports HTML tags).
    /// This parameter requires the presence of a 'FluentTooltipProvider' in your main/layout page.
    [<CustomOperation("Tooltip")>] member inline _.Tooltip ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Tooltip" => x)

/// Represents a skeleton loading component that provides visual placeholders for content while it is being loaded.
type FluentSkeletonBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentComponentBaseBuilder<'FunBlazorGeneric>()
    /// Gets or sets the content to be rendered inside the skeleton component.
    [<CustomOperation("ChildContent")>] member inline _.ChildContent ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.FluentUI.AspNetCore.Components.FluentSkeleton -> NodeRenderFragment) = render ==> html.renderFragment("ChildContent", fn)
    /// Gets or sets a value indicating whether the component is visible.
    [<CustomOperation("Visible")>] member inline _.Visible ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Visible" =>>> true)
    /// Gets or sets a value indicating whether the component is visible.
    [<CustomOperation("Visible")>] member inline _.Visible ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Visible" =>>> x)
    /// Gets or sets a value indicating whether the shimmer animation (loading wave effect) is shown.
    /// Distinct from Visible, which controls component visibility entirely.
    [<CustomOperation("Shimmer")>] member inline _.Shimmer ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Shimmer" =>>> true)
    /// Gets or sets a value indicating whether the shimmer animation (loading wave effect) is shown.
    /// Distinct from Visible, which controls component visibility entirely.
    [<CustomOperation("Shimmer")>] member inline _.Shimmer ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Shimmer" =>>> x)
    /// Gets or sets a value indicating whether the skeleton is displayed as a circle.
    /// When true, the component renders with equal width and height styles to form a circle (the parameter values themselves are not mutated).
    [<CustomOperation("Circular")>] member inline _.Circular ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Circular" =>>> true)
    /// Gets or sets a value indicating whether the skeleton is displayed as a circle.
    /// When true, the component renders with equal width and height styles to form a circle (the parameter values themselves are not mutated).
    [<CustomOperation("Circular")>] member inline _.Circular ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Circular" =>>> x)
    /// Gets or sets the width of the element. Default is "100%".
    [<CustomOperation("Width")>] member inline _.Width ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Width" => x)
    /// Gets or sets the height of the component. Default is "48px".
    [<CustomOperation("Height")>] member inline _.Height ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Height" => x)
    /// Gets or sets the predefined skeleton pattern used to define the structure or layout of the component.
    /// (e.g., Pattern="SkeletonPattern.Article").
    /// For custom layouts, use ChildContent instead.
    [<CustomOperation("Pattern")>] member inline _.Pattern ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<Microsoft.FluentUI.AspNetCore.Components.SkeletonPattern>) = render ==> ("Pattern" => x)

/// A sortable list component that allows users to reorder items via drag-and-drop.
/// The type of the items in the list.
type FluentSortableListBuilder<'FunBlazorGeneric, 'TItem when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentComponentBaseBuilder<'FunBlazorGeneric>()
    /// Gets or sets the text used on `aria-label` attribute.
    [<CustomOperation("AriaLabel")>] member inline _.AriaLabel ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("AriaLabel" => x)
    /// Gets or sets the template to be used to define each sortable item in the list.
    /// Use the @context parameter to access the item and its properties.
    [<CustomOperation("ItemTemplate")>] member inline _.ItemTemplate ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: 'TItem -> NodeRenderFragment) = render ==> html.renderFragment("ItemTemplate", fn)
    /// Gets or sets the list of items to be displayed in a sortable list.
    [<CustomOperation("Items")>] member inline _.Items ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.IEnumerable<'TItem>) = render ==> ("Items" => x)
    /// Gets or sets the list of items to be displayed in a sortable list.
    [<CustomOperation("Items'")>] member inline _.Items' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.Collections.Generic.IEnumerable<'TItem> * (System.Collections.Generic.IEnumerable<'TItem> -> unit)) = render ==> html.bind("Items", valueFn)
    /// Event callback for when the list is updated.
    [<CustomOperation("OnUpdate")>] member inline _.OnUpdate ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.FluentUI.AspNetCore.Components.FluentSortableListEventArgs -> unit) = render ==> html.callback("OnUpdate", fn)
    /// Event callback for when the list is updated.
    [<CustomOperation("OnUpdate")>] member inline _.OnUpdate ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.FluentUI.AspNetCore.Components.FluentSortableListEventArgs -> Task<unit>) = render ==> html.callbackTask("OnUpdate", fn)
    /// Event callback for when an item is removed from the list.
    [<CustomOperation("OnRemove")>] member inline _.OnRemove ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.FluentUI.AspNetCore.Components.FluentSortableListEventArgs -> unit) = render ==> html.callback("OnRemove", fn)
    /// Event callback for when an item is removed from the list.
    [<CustomOperation("OnRemove")>] member inline _.OnRemove ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.FluentUI.AspNetCore.Components.FluentSortableListEventArgs -> Task<unit>) = render ==> html.callbackTask("OnRemove", fn)
    /// Event callback for when an item is added to the list.
    [<CustomOperation("OnAdd")>] member inline _.OnAdd ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.FluentUI.AspNetCore.Components.FluentSortableListEventArgs -> unit) = render ==> html.callback("OnAdd", fn)
    /// Event callback for when an item is added to the list.
    [<CustomOperation("OnAdd")>] member inline _.OnAdd ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.FluentUI.AspNetCore.Components.FluentSortableListEventArgs -> Task<unit>) = render ==> html.callbackTask("OnAdd", fn)
    /// Event callback for when the list of items is updated.
    /// Supports bi-directional binding for the Items parameter.
    [<CustomOperation("ItemsChanged")>] member inline _.ItemsChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Collections.Generic.IEnumerable<'TItem> -> unit) = render ==> html.callback("ItemsChanged", fn)
    /// Event callback for when the list of items is updated.
    /// Supports bi-directional binding for the Items parameter.
    [<CustomOperation("ItemsChanged")>] member inline _.ItemsChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Collections.Generic.IEnumerable<'TItem> -> Task<unit>) = render ==> html.callbackTask("ItemsChanged", fn)
    /// Gets or sets the name of the Group used for dragging between lists. Set the group to the same value on every list to enable.
    [<CustomOperation("Group")>] member inline _.Group ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Group" => x)
    /// Gets or sets whether elements are cloned instead of moved when dragged to another list (e.g., Clone="true").
    /// Requires Group to be set to the same value on both lists.
    [<CustomOperation("Clone")>] member inline _.Clone ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Clone" =>>> true)
    /// Gets or sets whether elements are cloned instead of moved when dragged to another list (e.g., Clone="true").
    /// Requires Group to be set to the same value on both lists.
    [<CustomOperation("Clone")>] member inline _.Clone ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Clone" =>>> x)
    /// Gets or sets whether it is possible to drop items into the current list from another list in the same group.
    /// Set to false to disable dropping from another list onto the current list.
    [<CustomOperation("Drop")>] member inline _.Drop ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Drop" =>>> true)
    /// Gets or sets whether it is possible to drop items into the current list from another list in the same group.
    /// Set to false to disable dropping from another list onto the current list.
    [<CustomOperation("Drop")>] member inline _.Drop ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Drop" =>>> x)
    /// Gets or sets whether sorting within this list is enabled. Default is true.
    /// Set to false to disable reordering within this list while still allowing cross-list drag-and-drop.
    [<CustomOperation("Sort")>] member inline _.Sort ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Sort" =>>> true)
    /// Gets or sets whether sorting within this list is enabled. Default is true.
    /// Set to false to disable reordering within this list while still allowing cross-list drag-and-drop.
    [<CustomOperation("Sort")>] member inline _.Sort ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Sort" =>>> x)
    /// Gets or sets whether drag handles are used instead of dragging the whole item.
    /// When true, only elements with the CSS class sortable-grab can initiate a drag.
    [<CustomOperation("Handle")>] member inline _.Handle ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Handle" =>>> true)
    /// Gets or sets whether drag handles are used instead of dragging the whole item.
    /// When true, only elements with the CSS class sortable-grab can initiate a drag.
    [<CustomOperation("Handle")>] member inline _.Handle ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Handle" =>>> x)
    /// Gets or sets the function to filter out elements that cannot be sorted or moved.
    [<CustomOperation("ItemFilter")>] member inline _.ItemFilter ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("ItemFilter" => (System.Func<'TItem, System.Boolean>fn))
    /// Gets or sets whether to ignore the HTML5 DnD behaviour and force the fallback to kick in.
    [<CustomOperation("Fallback")>] member inline _.Fallback ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Fallback" =>>> true)
    /// Gets or sets whether to ignore the HTML5 DnD behaviour and force the fallback to kick in.
    [<CustomOperation("Fallback")>] member inline _.Fallback ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Fallback" =>>> x)

/// Spacer component, used to create space between elements.
type FluentSpacerBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentComponentBaseBuilder<'FunBlazorGeneric>()
    /// Gets or sets the height of the spacer when the Orientation is Vertical (e.g., Height="16px").
    /// Use Width to set the size for a horizontal spacer.
    [<CustomOperation("Height")>] member inline _.Height ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Height" => x)
    /// Gets or sets the width of the spacer when the Orientation is Horizontal (e.g., Width="16px").
    /// Use Height to set the size for a vertical spacer.
    [<CustomOperation("Width")>] member inline _.Width ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Width" => x)
    /// Gets or sets the orientation of this spacer, which should match the layout direction of the parent container.
    /// Use Horizontal (default) for a horizontal spacer (grows along the horizontal axis), or Vertical for a vertical one.
    [<CustomOperation("Orientation")>] member inline _.Orientation ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.FluentUI.AspNetCore.Components.Orientation) = render ==> ("Orientation" => x)

/// Represents a multi-pane splitter component that allows resizing, collapsing, and expanding of its panes. It supports
/// callbacks for pane events.
type FluentMultiSplitterBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentComponentBaseBuilder<'FunBlazorGeneric>()
    /// Gets or sets a reference to the rendered element.
    /// May be null if accessed before the component is rendered.
    [<CustomOperation("Element")>] member inline _.Element ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.AspNetCore.Components.ElementReference) = render ==> ("Element" => x)
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

/// Represents a pane in a multi-splitter layout, allowing for child content, resizing, and collapsing behavior.
/// It manages its size and state within a splitter.
type FluentMultiSplitterPaneBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentComponentBaseBuilder<'FunBlazorGeneric>()
    /// Gets or sets whether this pane is currently collapsed.
    [<CustomOperation("Collapsed")>] member inline _.Collapsed ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Collapsed" =>>> true)
    /// Gets or sets whether this pane is currently collapsed.
    [<CustomOperation("Collapsed")>] member inline _.Collapsed ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Collapsed" =>>> x)
    /// Gets or sets whether this pane can be collapsed by the user.
    [<CustomOperation("Collapsible")>] member inline _.Collapsible ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Collapsible" =>>> true)
    /// Gets or sets whether this pane can be collapsed by the user.
    [<CustomOperation("Collapsible")>] member inline _.Collapsible ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Collapsible" =>>> x)
    /// Gets or sets the maximum size of the pane as a CSS value (e.g., Max="80%").
    /// An empty string (the default) means no maximum constraint is applied.
    [<CustomOperation("Max")>] member inline _.Max ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Max" => x)
    /// Gets or sets the minimum size of the pane as a CSS value (e.g., Min="100px").
    /// An empty string (the default) means no minimum constraint is applied.
    [<CustomOperation("Min")>] member inline _.Min ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Min" => x)
    /// Gets or sets whether the user can resize this pane by dragging its splitter bar. Default is true.
    [<CustomOperation("Resizable")>] member inline _.Resizable ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Resizable" =>>> true)
    /// Gets or sets whether the user can resize this pane by dragging its splitter bar. Default is true.
    [<CustomOperation("Resizable")>] member inline _.Resizable ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Resizable" =>>> x)
    /// Gets or sets the initial size of the pane as a CSS value (e.g., Size="200px" or Size="30%").
    /// When omitted, remaining space is distributed equally among unsized panes.
    [<CustomOperation("Size")>] member inline _.Size ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Size" => x)

/// A container-type component that can be used to arrange its child components in a horizontal or vertical stack.
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
    /// Gets or sets the height of the stack.
    [<CustomOperation("Height")>] member inline _.Height ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Height" => x)
    /// Gets or sets a value indicating whether the stack wraps.
    [<CustomOperation("Wrap")>] member inline _.Wrap ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Wrap" =>>> true)
    /// Gets or sets a value indicating whether the stack wraps.
    [<CustomOperation("Wrap")>] member inline _.Wrap ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Wrap" =>>> x)
    /// Gets or sets the gap between horizontally stacked components (e.g., HorizontalGap="8px").
    /// Default is undefined. You can define the default value in the DefaultStyles.
    /// Use VerticalGap to set the vertical gap.
    /// See the CSS column-gap property.
    [<CustomOperation("HorizontalGap")>] member inline _.HorizontalGap ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("HorizontalGap" => x)
    /// Gets or sets the gap between vertically stacked components (e.g., VerticalGap="8px").
    /// Default is undefined. You can define the default value in the DefaultStyles.
    /// Use HorizontalGap to set the horizontal gap.
    /// See the CSS row-gap property.
    [<CustomOperation("VerticalGap")>] member inline _.VerticalGap ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("VerticalGap" => x)
    /// Gets or sets a value indicating whether the stack is reversed.
    [<CustomOperation("Reversed")>] member inline _.Reversed ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Boolean>) = render ==> ("Reversed" => x)

/// A FluentTabs allows people to switch between categories of related information without going to different pages
type FluentTabBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentComponentBaseBuilder<'FunBlazorGeneric>()
    /// Gets or sets whether the tab is disabled.
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Disabled" =>>> true)
    /// Gets or sets whether the tab is disabled.
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Disabled" =>>> x)
    /// Gets or sets the text displayed on the tab.
    /// This is the plain-text label shown in the tab strip (e.g., Header="My Tab").
    /// For rich content (icons, custom markup), use HeaderTemplate instead.
    [<CustomOperation("Header")>] member inline _.Header ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Header" => x)
    /// Gets or sets the custom header content of the tab (supports icons and rich markup).
    /// Use this instead of Header when you need more than plain text.
    [<CustomOperation("HeaderTemplate")>] member inline _.HeaderTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragment: NodeRenderFragment) = render ==> html.renderFragment("HeaderTemplate", fragment)
    /// Gets or sets the custom header content of the tab (supports icons and rich markup).
    /// Use this instead of Header when you need more than plain text.
    [<CustomOperation("HeaderTemplate")>] member inline _.HeaderTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragments: NodeRenderFragment seq) = render ==> html.renderFragment("HeaderTemplate", fragment { yield! fragments })
    /// Gets or sets the custom header content of the tab (supports icons and rich markup).
    /// Use this instead of Header when you need more than plain text.
    [<CustomOperation("HeaderTemplate")>] member inline _.HeaderTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("HeaderTemplate", html.text x)
    /// Gets or sets the custom header content of the tab (supports icons and rich markup).
    /// Use this instead of Header when you need more than plain text.
    [<CustomOperation("HeaderTemplate")>] member inline _.HeaderTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("HeaderTemplate", html.text x)
    /// Gets or sets the custom header content of the tab (supports icons and rich markup).
    /// Use this instead of Header when you need more than plain text.
    [<CustomOperation("HeaderTemplate")>] member inline _.HeaderTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("HeaderTemplate", html.text x)
    /// Gets or sets the CSS class name applied to the tab label.
    [<CustomOperation("HeaderClass")>] member inline _.HeaderClass ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("HeaderClass" => x)
    /// Gets or sets the CSS styles applied to the tab label.
    [<CustomOperation("HeaderStyle")>] member inline _.HeaderStyle ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("HeaderStyle" => x)
    /// Gets or sets the icon to be displayed at the start of the tab.
    [<CustomOperation("IconStart")>] member inline _.IconStart ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.FluentUI.AspNetCore.Components.Icon) = render ==> ("IconStart" => x)
    /// Gets or sets the icon color.
    [<CustomOperation("IconColor")>] member inline _.IconColor ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<Microsoft.FluentUI.AspNetCore.Components.Color>) = render ==> ("IconColor" => x)
    /// Gets or sets whether the tab content is rendered only when the tab is selected.
    /// To reduce the HTML page size, the tab content is cleared when the tab is unselected.
    [<CustomOperation("DeferredLoading")>] member inline _.DeferredLoading ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("DeferredLoading" =>>> true)
    /// Gets or sets whether the tab content is rendered only when the tab is selected.
    /// To reduce the HTML page size, the tab content is cleared when the tab is unselected.
    [<CustomOperation("DeferredLoading")>] member inline _.DeferredLoading ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("DeferredLoading" =>>> x)
    /// Gets or sets the customized loading content message when using deferred loading.
    [<CustomOperation("LoadingTemplate")>] member inline _.LoadingTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragment: NodeRenderFragment) = render ==> html.renderFragment("LoadingTemplate", fragment)
    /// Gets or sets the customized loading content message when using deferred loading.
    [<CustomOperation("LoadingTemplate")>] member inline _.LoadingTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragments: NodeRenderFragment seq) = render ==> html.renderFragment("LoadingTemplate", fragment { yield! fragments })
    /// Gets or sets the customized loading content message when using deferred loading.
    [<CustomOperation("LoadingTemplate")>] member inline _.LoadingTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("LoadingTemplate", html.text x)
    /// Gets or sets the customized loading content message when using deferred loading.
    [<CustomOperation("LoadingTemplate")>] member inline _.LoadingTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("LoadingTemplate", html.text x)
    /// Gets or sets the customized loading content message when using deferred loading.
    [<CustomOperation("LoadingTemplate")>] member inline _.LoadingTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("LoadingTemplate", html.text x)
    /// Gets or sets whether the tab is displayed. Default is true.
    [<CustomOperation("Visible")>] member inline _.Visible ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Visible" =>>> true)
    /// Gets or sets whether the tab is displayed. Default is true.
    [<CustomOperation("Visible")>] member inline _.Visible ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Visible" =>>> x)
    /// Gets or sets the tooltip text (supports HTML tags).
    /// This parameter requires the presence of a 'FluentTooltipProvider' in your main/layout page.
    [<CustomOperation("Tooltip")>] member inline _.Tooltip ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Tooltip" => x)

/// Each tab typically contains a text header and often includes an icon.
type FluentTabsBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentComponentBaseBuilder<'FunBlazorGeneric>()
    /// Gets or sets the visual appearance applied to each contained tab (e.g., Appearance="TabsAppearance.Subtle").
    [<CustomOperation("Appearance")>] member inline _.Appearance ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<Microsoft.FluentUI.AspNetCore.Components.TabsAppearance>) = render ==> ("Appearance" => x)
    /// Gets or sets whether the tabs are disabled.
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Disabled" =>>> true)
    /// Gets or sets whether the tabs are disabled.
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Disabled" =>>> x)
    /// Gets or sets the size of the tabs. The default is medium.
    [<CustomOperation("Size")>] member inline _.Size ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<Microsoft.FluentUI.AspNetCore.Components.TabsSize>) = render ==> ("Size" => x)
    /// Gets or sets the orientation of the tabs. The default is horizontal.
    [<CustomOperation("Orientation")>] member inline _.Orientation ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<Microsoft.FluentUI.AspNetCore.Components.Orientation>) = render ==> ("Orientation" => x)
    /// Gets or sets whether tabs that do not fit in the available space are displayed in an overflow menu.
    [<CustomOperation("Overflow")>] member inline _.Overflow ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Overflow" =>>> true)
    /// Gets or sets whether tabs that do not fit in the available space are displayed in an overflow menu.
    [<CustomOperation("Overflow")>] member inline _.Overflow ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Overflow" =>>> x)
    /// Gets or sets the height of the tabs.
    [<CustomOperation("Height")>] member inline _.Height ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Height" => x)
    /// Gets or sets the width of the tabs.
    [<CustomOperation("Width")>] member inline _.Width ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Width" => x)
    /// Gets or sets the ID of the currently active tab. Use @bind-ActiveTabId for two-way binding.
    /// See also ActiveTab to work with the FluentTab instance directly.
    [<CustomOperation("ActiveTabId")>] member inline _.ActiveTabId ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("ActiveTabId" => x)
    /// Gets or sets the ID of the currently active tab. Use @bind-ActiveTabId for two-way binding.
    /// See also ActiveTab to work with the FluentTab instance directly.
    [<CustomOperation("ActiveTabId'")>] member inline _.ActiveTabId' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.String * (System.String -> unit)) = render ==> html.bind("ActiveTabId", valueFn)
    /// Represents a callback for when the active tab id changes. It can handle a nullable FluentTab parameter.
    [<CustomOperation("ActiveTabIdChanged")>] member inline _.ActiveTabIdChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.String -> unit) = render ==> html.callback("ActiveTabIdChanged", fn)
    /// Represents a callback for when the active tab id changes. It can handle a nullable FluentTab parameter.
    [<CustomOperation("ActiveTabIdChanged")>] member inline _.ActiveTabIdChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.String -> Task<unit>) = render ==> html.callbackTask("ActiveTabIdChanged", fn)
    /// Gets or sets the currently active FluentTab instance. Use @bind-ActiveTab for two-way binding.
    /// See also ActiveTabId to work with the tab ID string directly.
    [<CustomOperation("ActiveTab")>] member inline _.ActiveTab ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.FluentUI.AspNetCore.Components.FluentTab) = render ==> ("ActiveTab" => x)
    /// Gets or sets the currently active FluentTab instance. Use @bind-ActiveTab for two-way binding.
    /// See also ActiveTabId to work with the tab ID string directly.
    [<CustomOperation("ActiveTab'")>] member inline _.ActiveTab' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: Microsoft.FluentUI.AspNetCore.Components.FluentTab * (Microsoft.FluentUI.AspNetCore.Components.FluentTab -> unit)) = render ==> html.bind("ActiveTab", valueFn)
    /// Represents a callback for when the active tab changes. It can handle a nullable FluentTab parameter.
    [<CustomOperation("ActiveTabChanged")>] member inline _.ActiveTabChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.FluentUI.AspNetCore.Components.FluentTab -> unit) = render ==> html.callback("ActiveTabChanged", fn)
    /// Represents a callback for when the active tab changes. It can handle a nullable FluentTab parameter.
    [<CustomOperation("ActiveTabChanged")>] member inline _.ActiveTabChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.FluentUI.AspNetCore.Components.FluentTab -> Task<unit>) = render ==> html.callbackTask("ActiveTabChanged", fn)
    /// Gets or sets the content rendered inside the overflow menu trigger.
    [<CustomOperation("MoreTemplate")>] member inline _.MoreTemplate ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.FluentUI.AspNetCore.Components.FluentTabs -> NodeRenderFragment) = render ==> html.renderFragment("MoreTemplate", fn)
    /// Gets or sets the content rendered in place of the default overflow menu.
    [<CustomOperation("OverflowTemplate")>] member inline _.OverflowTemplate ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.FluentUI.AspNetCore.Components.FluentTabs -> NodeRenderFragment) = render ==> html.renderFragment("OverflowTemplate", fn)

/// FluentText component, codifies Fluent's opinions on typography to make them easy to use and standardize across products.
type FluentTextBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentComponentBaseBuilder<'FunBlazorGeneric>()
    /// Gets or sets the tag to surround the ChildContent with to create semantic HTML Default to
    /// null so ChildContent is displayed as provided without any additional wrapping element.
    [<CustomOperation("As")>] member inline _.As ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<Microsoft.FluentUI.AspNetCore.Components.TextTag>) = render ==> ("As" => x)
    /// Gets or sets the size of the text.
    [<CustomOperation("Size")>] member inline _.Size ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<Microsoft.FluentUI.AspNetCore.Components.TextSize>) = render ==> ("Size" => x)
    /// Gets or sets the weight of the text.
    [<CustomOperation("Weight")>] member inline _.Weight ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<Microsoft.FluentUI.AspNetCore.Components.TextWeight>) = render ==> ("Weight" => x)
    /// Gets or sets the alignment of the text.
    [<CustomOperation("Align")>] member inline _.Align ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<Microsoft.FluentUI.AspNetCore.Components.TextAlign>) = render ==> ("Align" => x)
    /// Gets or sets the font family of the text.
    [<CustomOperation("Font")>] member inline _.Font ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<Microsoft.FluentUI.AspNetCore.Components.TextFont>) = render ==> ("Font" => x)
    /// Gets or sets whether the text is set to no-wrap (disables line wrapping).
    [<CustomOperation("Nowrap")>] member inline _.Nowrap ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Nowrap" =>>> true)
    /// Gets or sets whether the text is set to no-wrap (disables line wrapping).
    [<CustomOperation("Nowrap")>] member inline _.Nowrap ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Nowrap" =>>> x)
    /// Gets or sets whether the text should truncate with an ellipsis when it overflows.
    [<CustomOperation("Truncate")>] member inline _.Truncate ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Truncate" =>>> true)
    /// Gets or sets whether the text should truncate with an ellipsis when it overflows.
    [<CustomOperation("Truncate")>] member inline _.Truncate ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Truncate" =>>> x)
    /// Gets or sets whether the text is displayed as a block element.
    [<CustomOperation("Block")>] member inline _.Block ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Block" =>>> true)
    /// Gets or sets whether the text is displayed as a block element.
    [<CustomOperation("Block")>] member inline _.Block ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Block" =>>> x)
    /// Gets or sets whether the text is shown in italic.
    [<CustomOperation("Italic")>] member inline _.Italic ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Italic" =>>> true)
    /// Gets or sets whether the text is shown in italic.
    [<CustomOperation("Italic")>] member inline _.Italic ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Italic" =>>> x)
    /// Gets or sets whether the text is shown with an underline.
    [<CustomOperation("Underline")>] member inline _.Underline ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Underline" =>>> true)
    /// Gets or sets whether the text is shown with an underline.
    [<CustomOperation("Underline")>] member inline _.Underline ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Underline" =>>> x)
    /// Gets or sets whether the text is shown with a strikethrough decoration.
    [<CustomOperation("Strikethrough")>] member inline _.Strikethrough ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Strikethrough" =>>> true)
    /// Gets or sets whether the text is shown with a strikethrough decoration.
    [<CustomOperation("Strikethrough")>] member inline _.Strikethrough ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Strikethrough" =>>> x)
    /// Gets or sets the text drawing color.
    /// Value comes from the Color enumeration. Defaults to Accent.
    [<CustomOperation("Color")>] member inline _.Color ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<Microsoft.FluentUI.AspNetCore.Components.Color>) = render ==> ("Color" => x)
    /// Gets or sets the text drawing color to a custom value.
    /// Needs to be formatted as an HTML hex color string (#RRGGBB or #RGB) or CSS variable.
    /// ⚠️ Only available when Color is set to Color.Custom.
    [<CustomOperation("CustomColor")>] member inline _.CustomColor ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("CustomColor" => x)
    /// Gets or sets the tooltip text (supports HTML tags).
    /// This parameter requires the presence of a 'FluentTooltipProvider' in your main/layout page.
    [<CustomOperation("Tooltip")>] member inline _.Tooltip ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Tooltip" => x)

/// The FluentToast component represents a transient message that appears on the screen to provide feedback or
/// information to the user. It is typically used for displaying notifications, alerts, or status messages in a
/// non-intrusive manner. The FluentToast component can be customized with various options such as position, intent,
/// timeout duration, and actions, allowing developers to create engaging and informative user experiences.
type FluentToastBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentComponentBaseBuilder<'FunBlazorGeneric>()
    /// Gets or sets a value indicating whether the component is currently open.
    [<CustomOperation("Opened")>] member inline _.Opened ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Opened" =>>> true)
    /// Gets or sets a value indicating whether the component is currently open.
    [<CustomOperation("Opened")>] member inline _.Opened ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Opened" =>>> x)
    /// Gets or sets a value indicating whether the component is currently open.
    [<CustomOperation("Opened'")>] member inline _.Opened' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.Boolean * (System.Boolean -> unit)) = render ==> html.bind("Opened", valueFn)
    /// Gets or sets the callback that is invoked when the open state changes.
    [<CustomOperation("OpenedChanged")>] member inline _.OpenedChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Boolean -> unit) = render ==> html.callback("OpenedChanged", fn)
    /// Gets or sets the callback that is invoked when the open state changes.
    [<CustomOperation("OpenedChanged")>] member inline _.OpenedChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Boolean -> Task<unit>) = render ==> html.callbackTask("OpenedChanged", fn)
    /// Gets or sets the lifetime of the toast.
    /// When set to a positive value, the toast is automatically dismissed after this duration elapses, 
    /// triggering the appropriate lifecycle events.
    /// When `null`, the toast stays visible until it is dismissed programmatically or by the user.
    [<CustomOperation("Lifetime")>] member inline _.Lifetime ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.TimeSpan>) = render ==> ("Lifetime" => x)
    /// Gets or sets the ToastPosition on the screen where the toast notification is displayed.
    [<CustomOperation("Position")>] member inline _.Position ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<Microsoft.FluentUI.AspNetCore.Components.ToastPosition>) = render ==> ("Position" => x)
    /// Gets or sets the vertical offset, in pixels, applied to the component's position.
    [<CustomOperation("VerticalOffset")>] member inline _.VerticalOffset ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("VerticalOffset" => x)
    /// Gets or sets the horizontal offset, in pixels, applied to the component's content.
    [<CustomOperation("HorizontalOffset")>] member inline _.HorizontalOffset ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("HorizontalOffset" => x)
    /// Gets or sets a value indicating whether the toast uses inverted colors.
    [<CustomOperation("Inverted")>] member inline _.Inverted ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Inverted" =>>> true)
    /// Gets or sets a value indicating whether the toast uses inverted colors.
    [<CustomOperation("Inverted")>] member inline _.Inverted ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Inverted" =>>> x)
    /// Gets or sets the ToastIntent intent of the toast notification, indicating its purpose or severity.
    [<CustomOperation("Intent")>] member inline _.Intent ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<Microsoft.FluentUI.AspNetCore.Components.ToastIntent>) = render ==> ("Intent" => x)
    /// Gets or sets the level of notification politeness for assistive technologies.
    [<CustomOperation("Politeness")>] member inline _.Politeness ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<Microsoft.FluentUI.AspNetCore.Components.ToastPoliteness>) = render ==> ("Politeness" => x)
    /// Gets or sets a value indicating whether the Lifetime pauses when the user hovers over the component.
    [<CustomOperation("PauseOnHover")>] member inline _.PauseOnHover ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("PauseOnHover" =>>> true)
    /// Gets or sets a value indicating whether the Lifetime pauses when the user hovers over the component.
    [<CustomOperation("PauseOnHover")>] member inline _.PauseOnHover ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("PauseOnHover" =>>> x)
    /// Gets or sets a value indicating whether the Lifetime pauses when the browser window loses focus.
    [<CustomOperation("PauseOnWindowBlur")>] member inline _.PauseOnWindowBlur ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("PauseOnWindowBlur" =>>> true)
    /// Gets or sets a value indicating whether the Lifetime pauses when the browser window loses focus.
    [<CustomOperation("PauseOnWindowBlur")>] member inline _.PauseOnWindowBlur ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("PauseOnWindowBlur" =>>> x)
    /// Gets or sets the callback that is invoked when the toast status changes.
    [<CustomOperation("OnStatusChange")>] member inline _.OnStatusChange ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.FluentUI.AspNetCore.Components.ToastEventArgs -> unit) = render ==> html.callback("OnStatusChange", fn)
    /// Gets or sets the callback that is invoked when the toast status changes.
    [<CustomOperation("OnStatusChange")>] member inline _.OnStatusChange ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.FluentUI.AspNetCore.Components.ToastEventArgs -> Task<unit>) = render ==> html.callbackTask("OnStatusChange", fn)
    /// Gets or sets the icon rendered in the toast header.
    /// When set, this overrides the default icon determined by the Intent
    /// (Warning, Error, Success, Info) of the toast.
    [<CustomOperation("Icon")>] member inline _.Icon ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.FluentUI.AspNetCore.Components.Icon) = render ==> ("Icon" => x)
    /// Gets or sets the title displayed in the toast header.
    /// For security reasons, the content is sanitized using the configured MarkupSanitized before rendering.
    /// For formatted content with markup, use ChildContent instead.    
    [<CustomOperation("Title")>] member inline _.Title ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Title" => x)
    /// Gets or sets the subtitle displayed in the toast, below the ChildContent.
    [<CustomOperation("Subtitle")>] member inline _.Subtitle ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Subtitle" => x)
    /// Gets or sets a value indicating whether the toast can be dismissed by the user. Default is true.
    /// When true, a dismiss button is rendered;
    /// Use DismissAction to customize its label and action.
    [<CustomOperation("AllowDismiss")>] member inline _.AllowDismiss ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("AllowDismiss" =>>> true)
    /// Gets or sets a value indicating whether the toast can be dismissed by the user. Default is true.
    /// When true, a dismiss button is rendered;
    /// Use DismissAction to customize its label and action.
    [<CustomOperation("AllowDismiss")>] member inline _.AllowDismiss ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("AllowDismiss" =>>> x)
    /// Gets or sets the dismiss link and action button (e.g., `DismissLabel="Close"`).
    /// Only relevant when AllowDismiss is true.
    [<CustomOperation("DismissAction")>] member inline _.DismissAction ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.FluentUI.AspNetCore.Components.ToastOptionsAction) = render ==> ("DismissAction" => x)
    /// Gets or sets the content rendered in the toast footer section, typically used for displaying additional information or actions.
    [<CustomOperation("FooterTemplate")>] member inline _.FooterTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragment: NodeRenderFragment) = render ==> html.renderFragment("FooterTemplate", fragment)
    /// Gets or sets the content rendered in the toast footer section, typically used for displaying additional information or actions.
    [<CustomOperation("FooterTemplate")>] member inline _.FooterTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragments: NodeRenderFragment seq) = render ==> html.renderFragment("FooterTemplate", fragment { yield! fragments })
    /// Gets or sets the content rendered in the toast footer section, typically used for displaying additional information or actions.
    [<CustomOperation("FooterTemplate")>] member inline _.FooterTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("FooterTemplate", html.text x)
    /// Gets or sets the content rendered in the toast footer section, typically used for displaying additional information or actions.
    [<CustomOperation("FooterTemplate")>] member inline _.FooterTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("FooterTemplate", html.text x)
    /// Gets or sets the content rendered in the toast footer section, typically used for displaying additional information or actions.
    [<CustomOperation("FooterTemplate")>] member inline _.FooterTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("FooterTemplate", html.text x)
    /// Gets or sets the width of the toast.
    [<CustomOperation("Width")>] member inline _.Width ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Width" => x)

type FluentToastProviderBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentComponentBaseBuilder<'FunBlazorGeneric>()


/// A FluentTooltip displays additional information about another component.
/// The information is displayed above and near the target component.
type FluentTooltipBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentComponentBaseBuilder<'FunBlazorGeneric>()
    /// Gets or sets a value indicating whether the ITooltipService is used to render the tooltip.
    /// This parameter only has an effect when ITooltipService is registered in the DI container; the service is optional and may not be available.
    /// Set this to false when ChildContent is dynamic (e.g., UseTooltipService="false"). Default is true.
    [<CustomOperation("UseTooltipService")>] member inline _.UseTooltipService ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("UseTooltipService" =>>> true)
    /// Gets or sets a value indicating whether the ITooltipService is used to render the tooltip.
    /// This parameter only has an effect when ITooltipService is registered in the DI container; the service is optional and may not be available.
    /// Set this to false when ChildContent is dynamic (e.g., UseTooltipService="false"). Default is true.
    [<CustomOperation("UseTooltipService")>] member inline _.UseTooltipService ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("UseTooltipService" =>>> x)
    /// Gets or sets the component identifier associated with the tooltip (Required).
    [<CustomOperation("Anchor")>] member inline _.Anchor ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Anchor" => x)
    /// Gets or sets number of milliseconds to delay the tooltip from showing/hiding on hover.
    /// The default value is `null`. Internally the component uses 250ms when no value is provided.
    [<CustomOperation("Delay'")>] member inline _.Delay' ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Int32>) = render ==> ("Delay" => x)
    /// Gets or sets the tooltip's position. See Positioning.
    [<CustomOperation("Positioning")>] member inline _.Positioning ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<Microsoft.FluentUI.AspNetCore.Components.Positioning>) = render ==> ("Positioning" => x)
    /// Gets or sets the maximum width of tooltip panel. Default is 240px.
    [<CustomOperation("MaxWidth")>] member inline _.MaxWidth ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("MaxWidth" => x)
    /// Gets or sets the tooltip's horizontal spacing. Default is 4px.
    [<CustomOperation("SpacingHorizontal")>] member inline _.SpacingHorizontal ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("SpacingHorizontal" => x)
    /// Gets or sets the tooltip's vertical spacing. Default is 4px.
    [<CustomOperation("SpacingVertical")>] member inline _.SpacingVertical ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("SpacingVertical" => x)
    /// Callback for when the tooltip is dismissed.
    [<CustomOperation("OnDismissed")>] member inline _.OnDismissed ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.EventArgs -> unit) = render ==> html.callback("OnDismissed", fn)
    /// Callback for when the tooltip is dismissed.
    [<CustomOperation("OnDismissed")>] member inline _.OnDismissed ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.EventArgs -> Task<unit>) = render ==> html.callbackTask("OnDismissed", fn)
    /// Callback for when the tooltip is opened or closed.
    [<CustomOperation("OnToggle")>] member inline _.OnToggle ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.FluentUI.AspNetCore.Components.TooltipEventArgs -> unit) = render ==> html.callback("OnToggle", fn)
    /// Callback for when the tooltip is opened or closed.
    [<CustomOperation("OnToggle")>] member inline _.OnToggle ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.FluentUI.AspNetCore.Components.TooltipEventArgs -> Task<unit>) = render ==> html.callbackTask("OnToggle", fn)

type FluentTooltipProviderBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentComponentBaseBuilder<'FunBlazorGeneric>()


/// Represents a tree item in a FluentTreeView.
type FluentTreeItemBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentComponentBaseBuilder<'FunBlazorGeneric>()
    /// Gets or sets the size of the tree item.
    /// Default is Medium.
    [<CustomOperation("Size")>] member inline _.Size ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<Microsoft.FluentUI.AspNetCore.Components.TreeSize>) = render ==> ("Size" => x)
    /// Gets or sets the height of the tree item.
    [<CustomOperation("Height")>] member inline _.Height ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Height" => x)
    /// Gets or sets the appearance of the tree item.
    /// Default is Subtle.
    [<CustomOperation("Appearance")>] member inline _.Appearance ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<Microsoft.FluentUI.AspNetCore.Components.TreeAppearance>) = render ==> ("Appearance" => x)
    /// Gets or sets the list of sub-items to bind to the tree item
    [<CustomOperation("Items")>] member inline _.Items ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.IEnumerable<Microsoft.FluentUI.AspNetCore.Components.ITreeViewItem>) = render ==> ("Items" => x)
    /// Gets or sets the text of the tree item.
    /// If this text is too long, it will be truncated with ellipsis.
    [<CustomOperation("Text")>] member inline _.Text ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Text" => x)
    /// Gets or sets the Icon displayed at the start of item content.
    /// We recommend using an icon size of 16px.
    [<CustomOperation("IconStart")>] member inline _.IconStart ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.FluentUI.AspNetCore.Components.Icon) = render ==> ("IconStart" => x)
    /// Gets or sets the Icon displayed at the end of item content.
    /// We recommend using an icon size of 16px.
    [<CustomOperation("IconEnd")>] member inline _.IconEnd ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.FluentUI.AspNetCore.Components.Icon) = render ==> ("IconEnd" => x)
    /// Gets or sets the Icon displayed at the "far end" of item content.
    /// We recommend using an icon size of 16px.
    [<CustomOperation("IconAside")>] member inline _.IconAside ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.FluentUI.AspNetCore.Components.Icon) = render ==> ("IconAside" => x)
    /// Gets or sets the Icon displayed to indicate the tree item is collapsed.
    /// If this icon is not set, the IconExpanded will be used.
    /// We recommend using an icon size of 16px.
    [<CustomOperation("IconCollapsed")>] member inline _.IconCollapsed ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.FluentUI.AspNetCore.Components.Icon) = render ==> ("IconCollapsed" => x)
    /// Gets or sets the Icon displayed to indicate the tree item is expanded.
    /// If this icon is not set, the IconCollapsed will be used.
    /// A 90-degree rotation effect is applied to the icon.
    /// Please select an icon that will look correct after rotation.
    /// We recommend using an icon size of 16px.
    [<CustomOperation("IconExpanded")>] member inline _.IconExpanded ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.FluentUI.AspNetCore.Components.Icon) = render ==> ("IconExpanded" => x)
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
    /// Called whenever the selected item changes.
    [<CustomOperation("SelectedChanged")>] member inline _.SelectedChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Boolean -> unit) = render ==> html.callback("SelectedChanged", fn)
    /// Called whenever the selected item changes.
    [<CustomOperation("SelectedChanged")>] member inline _.SelectedChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Boolean -> Task<unit>) = render ==> html.callbackTask("SelectedChanged", fn)

/// Represents a tree view component.
type FluentTreeViewBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentComponentBaseBuilder<'FunBlazorGeneric>()
    /// Gets or sets the size of the tree. Default is Medium.
    [<CustomOperation("Size")>] member inline _.Size ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<Microsoft.FluentUI.AspNetCore.Components.TreeSize>) = render ==> ("Size" => x)
    /// Gets or sets the appearance of the tree. Default is Subtle.
    [<CustomOperation("Appearance")>] member inline _.Appearance ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<Microsoft.FluentUI.AspNetCore.Components.TreeAppearance>) = render ==> ("Appearance" => x)
    /// Gets or sets whether the selection highlight is hidden.
    /// When true, the selected tree item is not visually highlighted.
    [<CustomOperation("HideSelection")>] member inline _.HideSelection ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("HideSelection" =>>> true)
    /// Gets or sets whether the selection highlight is hidden.
    /// When true, the selected tree item is not visually highlighted.
    [<CustomOperation("HideSelection")>] member inline _.HideSelection ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("HideSelection" =>>> x)
    /// Gets or sets the list of items to bind to the tree.
    [<CustomOperation("Items")>] member inline _.Items ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.IEnumerable<Microsoft.FluentUI.AspNetCore.Components.ITreeViewItem>) = render ==> ("Items" => x)
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
    /// Gets or sets the id of the currently selected tree item.
    /// See also SelectedItem (returns the ITreeViewItem data model),
    /// and CurrentSelected (returns the FluentTreeItem component instance).
    [<CustomOperation("SelectedId")>] member inline _.SelectedId ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("SelectedId" => x)
    /// Gets or sets the id of the currently selected tree item.
    /// See also SelectedItem (returns the ITreeViewItem data model),
    /// and CurrentSelected (returns the FluentTreeItem component instance).
    [<CustomOperation("SelectedId'")>] member inline _.SelectedId' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.String * (System.String -> unit)) = render ==> html.bind("SelectedId", valueFn)
    /// Called whenever the selected item changes.
    [<CustomOperation("SelectedIdChanged")>] member inline _.SelectedIdChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.String -> unit) = render ==> html.callback("SelectedIdChanged", fn)
    /// Called whenever the selected item changes.
    [<CustomOperation("SelectedIdChanged")>] member inline _.SelectedIdChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.String -> Task<unit>) = render ==> html.callbackTask("SelectedIdChanged", fn)
    /// Gets or sets the selected FluentTreeItem component instance.
    /// See also SelectedId (returns the item id string),
    /// and SelectedItem (returns the ITreeViewItem data model).
    [<CustomOperation("CurrentSelected")>] member inline _.CurrentSelected ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.FluentUI.AspNetCore.Components.FluentTreeItem) = render ==> ("CurrentSelected" => x)
    /// Gets or sets the selected FluentTreeItem component instance.
    /// See also SelectedId (returns the item id string),
    /// and SelectedItem (returns the ITreeViewItem data model).
    [<CustomOperation("CurrentSelected'")>] member inline _.CurrentSelected' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: Microsoft.FluentUI.AspNetCore.Components.FluentTreeItem * (Microsoft.FluentUI.AspNetCore.Components.FluentTreeItem -> unit)) = render ==> html.bind("CurrentSelected", valueFn)
    /// Called whenever the selected FluentTreeItem changes.
    [<CustomOperation("CurrentSelectedChanged")>] member inline _.CurrentSelectedChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.FluentUI.AspNetCore.Components.FluentTreeItem -> unit) = render ==> html.callback("CurrentSelectedChanged", fn)
    /// Called whenever the selected FluentTreeItem changes.
    [<CustomOperation("CurrentSelectedChanged")>] member inline _.CurrentSelectedChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.FluentUI.AspNetCore.Components.FluentTreeItem -> Task<unit>) = render ==> html.callbackTask("CurrentSelectedChanged", fn)
    /// Gets or sets the selected ITreeViewItem data model item.
    /// See also SelectedId (returns the item id string),
    /// and CurrentSelected (returns the FluentTreeItem component instance).
    [<CustomOperation("SelectedItem")>] member inline _.SelectedItem ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.FluentUI.AspNetCore.Components.ITreeViewItem) = render ==> ("SelectedItem" => x)
    /// Gets or sets the selected ITreeViewItem data model item.
    /// See also SelectedId (returns the item id string),
    /// and CurrentSelected (returns the FluentTreeItem component instance).
    [<CustomOperation("SelectedItem'")>] member inline _.SelectedItem' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: Microsoft.FluentUI.AspNetCore.Components.ITreeViewItem * (Microsoft.FluentUI.AspNetCore.Components.ITreeViewItem -> unit)) = render ==> html.bind("SelectedItem", valueFn)
    /// Called whenever the selected ITreeViewItem changes.
    [<CustomOperation("SelectedItemChanged")>] member inline _.SelectedItemChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.FluentUI.AspNetCore.Components.ITreeViewItem -> unit) = render ==> html.callback("SelectedItemChanged", fn)
    /// Called whenever the selected ITreeViewItem changes.
    [<CustomOperation("SelectedItemChanged")>] member inline _.SelectedItemChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.FluentUI.AspNetCore.Components.ITreeViewItem -> Task<unit>) = render ==> html.callbackTask("SelectedItemChanged", fn)
    /// Gets or sets whether the tree allows multiple selections.
    /// This Multiple Selection feature is only available when the Items parameter is used to generate the tree.
    /// MultipleRecursive uses `TreeViewThreeStateSelection` class
    /// to select or deselect descendants and update ancestor states. All descendant data must be available.
    /// By default, the tree allows only single selection.
    [<CustomOperation("SelectionMode")>] member inline _.SelectionMode ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.FluentUI.AspNetCore.Components.TreeSelectionMode) = render ==> ("SelectionMode" => x)
    /// Gets or sets the visibility of the multi-selection checkbox.
    /// By default all items are visible.
    [<CustomOperation("MultipleSelectionVisibility")>] member inline _.MultipleSelectionVisibility ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("MultipleSelectionVisibility" => (System.Func<Microsoft.FluentUI.AspNetCore.Components.ITreeViewItem, Microsoft.FluentUI.AspNetCore.Components.TreeSelectionVisibility>fn))
    /// Gets or sets a function that determines each checkbox's state:
    /// true (checked), false (unchecked),
    /// or null (indeterminate).
    /// Only applies when Items is used with Multiple.
    /// When omitted, checkbox states are determined by SelectedItems.
    /// Ignored in MultipleRecursive, which calculates checkbox states automatically.
    [<CustomOperation("CheckState")>] member inline _.CheckState ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("CheckState" => (System.Func<Microsoft.FluentUI.AspNetCore.Components.ITreeViewItem, System.Nullable<System.Boolean>>fn))
    /// Gets or sets the multi-selected ITreeViewItem items.
    [<CustomOperation("SelectedItems")>] member inline _.SelectedItems ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.IEnumerable<Microsoft.FluentUI.AspNetCore.Components.ITreeViewItem>) = render ==> ("SelectedItems" => x)
    /// Gets or sets the multi-selected ITreeViewItem items.
    [<CustomOperation("SelectedItems'")>] member inline _.SelectedItems' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.Collections.Generic.IEnumerable<Microsoft.FluentUI.AspNetCore.Components.ITreeViewItem> * (System.Collections.Generic.IEnumerable<Microsoft.FluentUI.AspNetCore.Components.ITreeViewItem> -> unit)) = render ==> html.bind("SelectedItems", valueFn)
    /// Called whenever the multi-selected ITreeViewItem changes.
    [<CustomOperation("SelectedItemsChanged")>] member inline _.SelectedItemsChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Collections.Generic.IEnumerable<Microsoft.FluentUI.AspNetCore.Components.ITreeViewItem> -> unit) = render ==> html.callback("SelectedItemsChanged", fn)
    /// Called whenever the multi-selected ITreeViewItem changes.
    [<CustomOperation("SelectedItemsChanged")>] member inline _.SelectedItemsChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Collections.Generic.IEnumerable<Microsoft.FluentUI.AspNetCore.Components.ITreeViewItem> -> Task<unit>) = render ==> html.callbackTask("SelectedItemsChanged", fn)
    /// Called whenever Expanded changes on an item within the tree.
    /// You cannot update FluentTreeItem properties.
    [<CustomOperation("OnExpandedChanged")>] member inline _.OnExpandedChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.FluentUI.AspNetCore.Components.FluentTreeItem -> unit) = render ==> html.callback("OnExpandedChanged", fn)
    /// Called whenever Expanded changes on an item within the tree.
    /// You cannot update FluentTreeItem properties.
    [<CustomOperation("OnExpandedChanged")>] member inline _.OnExpandedChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.FluentUI.AspNetCore.Components.FluentTreeItem -> Task<unit>) = render ==> html.callbackTask("OnExpandedChanged", fn)
    /// Called whenever the selected item changes.
    /// You cannot update FluentTreeItem properties.
    [<CustomOperation("OnSelectedChanged")>] member inline _.OnSelectedChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.FluentUI.AspNetCore.Components.FluentTreeItem -> unit) = render ==> html.callback("OnSelectedChanged", fn)
    /// Called whenever the selected item changes.
    /// You cannot update FluentTreeItem properties.
    [<CustomOperation("OnSelectedChanged")>] member inline _.OnSelectedChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.FluentUI.AspNetCore.Components.FluentTreeItem -> Task<unit>) = render ==> html.callbackTask("OnSelectedChanged", fn)

/// A wizard component that provides a step-by-step user interface.
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
    /// Gets or sets whether and how a border is displayed around the wizard (e.g., Border="WizardBorder.Outside").
    [<CustomOperation("Border")>] member inline _.Border ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.FluentUI.AspNetCore.Components.WizardBorder) = render ==> ("Border" => x)
    /// Gets or sets when to display a step number on each step icon.
    /// Can be overridden per step via DisplayStepNumber.
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

/// Represents an individual step within a FluentWizard component.
type FluentWizardStepBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentComponentBaseBuilder<'FunBlazorGeneric>()
    /// Gets or sets the template of the step icon.
    [<CustomOperation("StepTemplate")>] member inline _.StepTemplate ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.FluentUI.AspNetCore.Components.FluentWizardStepArgs -> NodeRenderFragment) = render ==> html.renderFragment("StepTemplate", fn)
    /// Gets or sets whether the step is disabled.
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Disabled" =>>> true)
    /// Gets or sets whether the step is disabled.
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Disabled" =>>> x)
    /// Gets or sets whether to render the step content only when the step is active.
    /// Content is cleared when the step is deselected, reducing page size for inactive steps.
    [<CustomOperation("DeferredLoading")>] member inline _.DeferredLoading ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("DeferredLoading" =>>> true)
    /// Gets or sets whether to render the step content only when the step is active.
    /// Content is cleared when the step is deselected, reducing page size for inactive steps.
    [<CustomOperation("DeferredLoading")>] member inline _.DeferredLoading ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("DeferredLoading" =>>> x)
    /// Gets or sets the plain-text label shown in the step indicator (e.g., Label="Step 1").
    /// See also Summary for a short subtitle displayed below the label.
    [<CustomOperation("Label")>] member inline _.Label ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Label" => x)
    /// Display a number on the step icon.
    /// By default, this is the DisplayStepNumber value.
    [<CustomOperation("DisplayStepNumber")>] member inline _.DisplayStepNumber ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Boolean>) = render ==> ("DisplayStepNumber" => x)
    /// The OnChange event fires before the current step has changed.
    /// The EventArgs contains a field of the targeted new step and a field to cancel the built-in action.
    [<CustomOperation("OnChange")>] member inline _.OnChange ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.FluentUI.AspNetCore.Components.FluentWizardStepChangeEventArgs -> unit) = render ==> html.callback("OnChange", fn)
    /// The OnChange event fires before the current step has changed.
    /// The EventArgs contains a field of the targeted new step and a field to cancel the built-in action.
    [<CustomOperation("OnChange")>] member inline _.OnChange ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.FluentUI.AspNetCore.Components.FluentWizardStepChangeEventArgs -> Task<unit>) = render ==> html.callbackTask("OnChange", fn)
    /// Gets or sets a short subtitle displayed below the Label in the step indicator.
    [<CustomOperation("Summary")>] member inline _.Summary ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Summary" => x)
    /// Gets or sets the icon to display for the past/previous step.
    /// By default, it is a checkmark circle.
    [<CustomOperation("IconPrevious")>] member inline _.IconPrevious ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.FluentUI.AspNetCore.Components.Icon) = render ==> ("IconPrevious" => x)
    /// Gets or sets the icon to display for the current/active step.
    /// By default, it is a filled circle.
    [<CustomOperation("IconCurrent")>] member inline _.IconCurrent ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.FluentUI.AspNetCore.Components.Icon) = render ==> ("IconCurrent" => x)
    /// Gets or sets the icon to display for the future/next step.
    /// By default, it is a regular circle.
    [<CustomOperation("IconNext")>] member inline _.IconNext ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.FluentUI.AspNetCore.Components.Icon) = render ==> ("IconNext" => x)

type FluentProvidersBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FluentComponentBaseBuilder<'FunBlazorGeneric>()


            
namespace rec Microsoft.FluentUI.AspNetCore.Components.DslInternals

open System.Threading.Tasks
open FSharp.Data.Adaptive
open Fun.Blazor
open Fun.Blazor.Operators
open Microsoft.FluentUI.AspNetCore.Components.DslInternals

/// Displays a list of validation messages from a cascaded EditContext.
type ValidationSummaryBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAndChildAttrBuilder<'FunBlazorGeneric>()
    /// Gets or sets the model to produce the list of validation messages for.
    /// When specified, this lists all errors that are associated with the model instance.
    [<CustomOperation("Model")>] member inline _.Model ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Object) = render ==> ("Model" => x)
    /// Gets or sets a collection of additional attributes that will be applied to the created ul element.
    [<CustomOperation("AdditionalAttributes")>] member inline _.AdditionalAttributes ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.IReadOnlyDictionary<System.String, System.Object>) = render ==> ("AdditionalAttributes" => x)

            
namespace rec Microsoft.FluentUI.AspNetCore.Components.DslInternals

open System.Threading.Tasks
open FSharp.Data.Adaptive
open Fun.Blazor
open Fun.Blazor.Operators
open Microsoft.FluentUI.AspNetCore.Components.DslInternals

/// Displays a summary of validation messages for a specified model within a cascaded EditContext.
type FluentValidationSummaryBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ValidationSummaryBuilder<'FunBlazorGeneric>()
    /// Gets or sets a value indicating whether error messages are displayed using a distinct error text color.
    [<CustomOperation("UseErrorTextColor")>] member inline _.UseErrorTextColor ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("UseErrorTextColor" =>>> true)
    /// Gets or sets a value indicating whether error messages are displayed using a distinct error text color.
    [<CustomOperation("UseErrorTextColor")>] member inline _.UseErrorTextColor ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("UseErrorTextColor" =>>> x)

/// An abstract base class for columns in a FluentDataGrid`1.
type ColumnBaseBuilder<'FunBlazorGeneric, 'TGridItem when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAndChildAttrBuilder<'FunBlazorGeneric>()
    /// Gets or sets the title text for the column.
    /// This is rendered automatically if HeaderCellItemTemplate is not used.
    [<CustomOperation("Title")>] member inline _.Title ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Title" => x)
    /// Gets or sets the index (1-based) of the column
    [<CustomOperation("Index")>] member inline _.Index ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("Index" => x)
    /// Gets or sets the cell alignment for header and grid cells in this column
    /// (e.g., Align="DataGridCellAlignment.Center").
    [<CustomOperation("Align")>] member inline _.Align ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.FluentUI.AspNetCore.Components.DataGridCellAlignment) = render ==> ("Align" => x)
    /// Gets or sets whether each cell in this column renders a title and aria-label attributes
    /// derived from the cell's content. Use TooltipText to supply a custom tooltip value.
    [<CustomOperation("Tooltip")>] member inline _.Tooltip ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Tooltip" =>>> true)
    /// Gets or sets whether each cell in this column renders a title and aria-label attributes
    /// derived from the cell's content. Use TooltipText to supply a custom tooltip value.
    [<CustomOperation("Tooltip")>] member inline _.Tooltip ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Tooltip" =>>> x)
    /// Gets or sets the function that defines the value to be used as the tooltip and aria-label in this column's cells
    [<CustomOperation("TooltipText")>] member inline _.TooltipText ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("TooltipText" => (System.Func<'TGridItem, System.String>fn))
    /// Gets or sets the tooltip text for the column header.
    [<CustomOperation("HeaderTooltip")>] member inline _.HeaderTooltip ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("HeaderTooltip" => x)
    /// Gets or sets the stable identifier used to persist and restore this column's order.
    /// When omitted, the grid derives an identifier from the bound property, title, or declaration order.
    [<CustomOperation("ColumnId")>] member inline _.ColumnId ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("ColumnId" => x)
    /// Gets or sets an optional template for this column's header cell.
    /// If not specified, the default header template includes the Title along with any applicable sort indicators and options buttons.
    [<CustomOperation("HeaderCellItemTemplate")>] member inline _.HeaderCellItemTemplate ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.FluentUI.AspNetCore.Components.ColumnBase<'TGridItem> -> NodeRenderFragment) = render ==> html.renderFragment("HeaderCellItemTemplate", fn)
    /// Gets or sets a template for the title content of this column's header cell.
    /// If not specified, the default header template includes the Title.
    [<CustomOperation("HeaderCellTitleTemplate")>] member inline _.HeaderCellTitleTemplate ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.FluentUI.AspNetCore.Components.ColumnBase<'TGridItem> -> NodeRenderFragment) = render ==> html.renderFragment("HeaderCellTitleTemplate", fn)
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
    /// Gets or sets the initial sort direction, applied when IsDefaultSortColumn is true.
    [<CustomOperation("InitialSortDirection")>] member inline _.InitialSortDirection ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.FluentUI.AspNetCore.Components.DataGridSortDirection) = render ==> ("InitialSortDirection" => x)
    /// Gets or sets a value indicating whether this column should be sorted by default.
    [<CustomOperation("IsDefaultSortColumn")>] member inline _.IsDefaultSortColumn ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("IsDefaultSortColumn" =>>> true)
    /// Gets or sets a value indicating whether this column should be sorted by default.
    [<CustomOperation("IsDefaultSortColumn")>] member inline _.IsDefaultSortColumn ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("IsDefaultSortColumn" =>>> x)
    /// Gets or sets the template used to render placeholder cells whose data has not yet loaded
    /// (applicable when Virtualize is enabled).
    [<CustomOperation("PlaceholderTemplate")>] member inline _.PlaceholderTemplate ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.AspNetCore.Components.Web.Virtualization.PlaceholderContext -> NodeRenderFragment) = render ==> html.renderFragment("PlaceholderTemplate", fn)
    /// Gets or sets the width of the column.
    /// Use either this or the FluentDataGrid`1 GridTemplateColumns parameter but not both.
    /// Needs to be a valid CSS width value like '100px', '10%' or '0.5fr'.
    [<CustomOperation("Width")>] member inline _.Width ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Width" => x)
    /// Gets or sets whether this column is pinned (frozen) to the start or end edge of the grid,
    /// so it remains visible when the user scrolls horizontally.
    /// Pinned columns require an explicit Width.
    /// Sticky offsets are recomputed from rendered header widths after the grid is rendered.
    /// Start-pinned columns must be contiguous at the start of the column list;
    /// end-pinned columns must be contiguous at the end.
    [<CustomOperation("Pin")>] member inline _.Pin ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.FluentUI.AspNetCore.Components.DataGridColumnPin) = render ==> ("Pin" => x)
    /// Gets or sets the minimal width of the column.
    /// Defaults to 100px for a regular column and 50px for a select column.
    /// When resizing a column, the user will not be able to make it smaller than this value.
    /// Needs to be a valid CSS width value like '100px', '10%' or '0.5fr'.
    [<CustomOperation("MinWidth")>] member inline _.MinWidth ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("MinWidth" => x)
    /// Gets or sets whether this column renders an expand/collapse toggle for hierarchical data.
    /// Requires  to implement IHierarchicalGridItem.
    [<CustomOperation("HierarchicalToggle")>] member inline _.HierarchicalToggle ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("HierarchicalToggle" =>>> true)
    /// Gets or sets whether this column renders an expand/collapse toggle for hierarchical data.
    /// Requires  to implement IHierarchicalGridItem.
    [<CustomOperation("HierarchicalToggle")>] member inline _.HierarchicalToggle ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("HierarchicalToggle" =>>> x)
    /// Gets or sets whether keyboard focus is disabled for cells in this column.
    [<CustomOperation("DisableCellFocus")>] member inline _.DisableCellFocus ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("DisableCellFocus" =>>> true)
    /// Gets or sets whether keyboard focus is disabled for cells in this column.
    [<CustomOperation("DisableCellFocus")>] member inline _.DisableCellFocus ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("DisableCellFocus" =>>> x)

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
    /// Gets or sets the sorting behavior for this column.
    ///             
    [<CustomOperation("SortBy")>] member inline _.SortBy ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.FluentUI.AspNetCore.Components.IGridSort<'TGridItem>) = render ==> ("SortBy" => x)

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
    /// Gets or sets the Icon to be rendered when the row is selected.
    [<CustomOperation("IconChecked")>] member inline _.IconChecked ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.FluentUI.AspNetCore.Components.Icon) = render ==> ("IconChecked" => x)
    /// Gets or sets the Icon to be rendered when the row is non selected.
    [<CustomOperation("IconUnchecked")>] member inline _.IconUnchecked ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.FluentUI.AspNetCore.Components.Icon) = render ==> ("IconUnchecked" => x)
    /// Gets or sets the Icon to be rendered when some but not all rows are selected.
    /// Only when SelectMode is Multiple.
    [<CustomOperation("IconIndeterminate")>] member inline _.IconIndeterminate ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.FluentUI.AspNetCore.Components.Icon) = render ==> ("IconIndeterminate" => x)
    /// Gets or sets the Icon title display as a tooltip and used with Accessibility.
    /// The default text is "Row selected".
    [<CustomOperation("TitleChecked")>] member inline _.TitleChecked ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("TitleChecked" => x)
    /// Gets or sets the Icon title display as a tooltip and used with Accessibility.
    /// The default text is "Row unselected".
    [<CustomOperation("TitleUnchecked")>] member inline _.TitleUnchecked ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("TitleUnchecked" => x)
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
    [<CustomOperation("SortBy")>] member inline _.SortBy ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.FluentUI.AspNetCore.Components.IGridSort<'TGridItem>) = render ==> ("SortBy" => x)
    /// Gets or sets the equality comparer used to determine whether two grid items are equal.
    [<CustomOperation("Comparer")>] member inline _.Comparer ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.IEqualityComparer<'TGridItem>) = render ==> ("Comparer" => x)

/// Represents a FluentDataGrid`1 column that combines hierarchical indentation,
/// expand/collapse toggles, a selection checkbox/radio, and user-defined template content.
type HierarchicalSelectColumnBuilder<'FunBlazorGeneric, 'TGridItem when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit SelectColumnBuilder<'FunBlazorGeneric, 'TGridItem>()
    /// Gets or sets the list of items in an indeterminate state.
    [<CustomOperation("IndeterminateItems")>] member inline _.IndeterminateItems ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.IEnumerable<'TGridItem>) = render ==> ("IndeterminateItems" => x)
    /// Gets or sets the list of items in an indeterminate state.
    [<CustomOperation("IndeterminateItems'")>] member inline _.IndeterminateItems' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.Collections.Generic.IEnumerable<'TGridItem> * (System.Collections.Generic.IEnumerable<'TGridItem> -> unit)) = render ==> html.bind("IndeterminateItems", valueFn)
    /// Gets or sets a callback when list of indeterminate items changed.
    [<CustomOperation("IndeterminateItemsChanged")>] member inline _.IndeterminateItemsChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Collections.Generic.IEnumerable<'TGridItem> -> unit) = render ==> html.callback("IndeterminateItemsChanged", fn)
    /// Gets or sets a callback when list of indeterminate items changed.
    [<CustomOperation("IndeterminateItemsChanged")>] member inline _.IndeterminateItemsChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Collections.Generic.IEnumerable<'TGridItem> -> Task<unit>) = render ==> html.callbackTask("IndeterminateItemsChanged", fn)
    /// Gets or sets the list of items in an unselected state.
    [<CustomOperation("UnselectedItems")>] member inline _.UnselectedItems ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.IEnumerable<'TGridItem>) = render ==> ("UnselectedItems" => x)
    /// Gets or sets the list of items in an unselected state.
    [<CustomOperation("UnselectedItems'")>] member inline _.UnselectedItems' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.Collections.Generic.IEnumerable<'TGridItem> * (System.Collections.Generic.IEnumerable<'TGridItem> -> unit)) = render ==> html.bind("UnselectedItems", valueFn)
    /// Gets or sets a callback when list of unselected items changed.
    [<CustomOperation("UnselectedItemsChanged")>] member inline _.UnselectedItemsChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Collections.Generic.IEnumerable<'TGridItem> -> unit) = render ==> html.callback("UnselectedItemsChanged", fn)
    /// Gets or sets a callback when list of unselected items changed.
    [<CustomOperation("UnselectedItemsChanged")>] member inline _.UnselectedItemsChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Collections.Generic.IEnumerable<'TGridItem> -> Task<unit>) = render ==> html.callbackTask("UnselectedItemsChanged", fn)

/// Represents a FluentDataGrid`1 column whose cells render a supplied template.
type TemplateColumnBuilder<'FunBlazorGeneric, 'TGridItem when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ColumnBaseBuilder<'FunBlazorGeneric, 'TGridItem>()
    /// Gets or sets the content to be rendered for each row in the table.
    [<CustomOperation("ChildContent")>] member inline _.ChildContent ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: 'TGridItem -> NodeRenderFragment) = render ==> html.renderFragment("ChildContent", fn)
    [<CustomOperation("SortBy")>] member inline _.SortBy ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.FluentUI.AspNetCore.Components.IGridSort<'TGridItem>) = render ==> ("SortBy" => x)

/// Provides accessible column reorder actions for a FluentDataGrid`1 column.
type ColumnReorderOptionsBuilder<'FunBlazorGeneric, 'TGridItem when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAttrBuilder<'FunBlazorGeneric>()
    /// Gets the column whose order should be changed.
    [<CustomOperation("Column")>] member inline _.Column ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.FluentUI.AspNetCore.Components.ColumnBase<'TGridItem>) = render ==> ("Column" => x)

/// Provides options for resizing a column in a FluentDataGrid`1.
type ColumnResizeOptionsBuilder<'FunBlazorGeneric, 'TGridItem when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAttrBuilder<'FunBlazorGeneric>()
    /// Gets or sets the index of the Column to act upon
    [<CustomOperation("Column")>] member inline _.Column ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("Column" => x)
    /// Gets or sets the type of resize to perform
    /// Discrete: resize by a 10 pixels at a time
    /// Exact: resize to the exact width specified (in pixels)
    /// The display of this component is dependent on a ResizeType being set
    [<CustomOperation("ResizeType")>] member inline _.ResizeType ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<Microsoft.FluentUI.AspNetCore.Components.DataGridResizeType>) = render ==> ("ResizeType" => x)

/// Renders the multi-column sort actions for one FluentDataGrid`1 column as menu items.
/// Used by the column header menu and by the column header popup, so that both offer the same actions.
type ColumnSortMenuItemsBuilder<'FunBlazorGeneric, 'TGridItem when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAttrBuilder<'FunBlazorGeneric>()
    /// Gets the column these actions apply to.
    [<CustomOperation("Column")>] member inline _.Column ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.FluentUI.AspNetCore.Components.ColumnBase<'TGridItem>) = render ==> ("Column" => x)
    /// Called after an action has been applied, so the menu or popup holding these items can close.
    [<CustomOperation("OnActionApplied")>] member inline _.OnActionApplied ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: unit -> unit) = render ==> html.callback("OnActionApplied", fn)
    /// Called after an action has been applied, so the menu or popup holding these items can close.
    [<CustomOperation("OnActionApplied")>] member inline _.OnActionApplied ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: unit -> Task<unit>) = render ==> html.callbackTask("OnActionApplied", fn)
    /// Gets or sets whether the first item takes focus when these items are rendered. Set by the column header popup,
    /// which has nothing else to move focus into it; the header menu focuses its own items.
    [<CustomOperation("AutofocusFirstItem")>] member inline _.AutofocusFirstItem ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("AutofocusFirstItem" =>>> true)
    /// Gets or sets whether the first item takes focus when these items are rendered. Set by the column header popup,
    /// which has nothing else to move focus into it; the header menu focuses its own items.
    [<CustomOperation("AutofocusFirstItem")>] member inline _.AutofocusFirstItem ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("AutofocusFirstItem" =>>> x)

/// Holds the multi-column sort actions of a FluentDataGrid`1 column in the column header
/// popup, for grids that do not use HeaderCellAsButtonWithMenu and therefore
/// have no header menu to put them in.
type ColumnSortOptionsBuilder<'FunBlazorGeneric, 'TGridItem when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAttrBuilder<'FunBlazorGeneric>()
    /// Gets the column whose sort should be changed.
    [<CustomOperation("Column")>] member inline _.Column ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.FluentUI.AspNetCore.Components.ColumnBase<'TGridItem>) = render ==> ("Column" => x)

type FluentDialogInstanceBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAndChildAttrBuilder<'FunBlazorGeneric>()


type FluentKeyCodeProviderBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAttrBuilder<'FunBlazorGeneric>()
    /// Gets or sets a way to tells the user agent that if the event does not get explicitly handled, its default action should not be taken as it normally would be.
    [<CustomOperation("PreventDefault")>] member inline _.PreventDefault ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("PreventDefault" =>>> true)
    /// Gets or sets a way to tells the user agent that if the event does not get explicitly handled, its default action should not be taken as it normally would be.
    [<CustomOperation("PreventDefault")>] member inline _.PreventDefault ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("PreventDefault" =>>> x)

/// A component that automatically registers an EditContext with a parent FluentWizardStep
/// for validation when navigating between wizard steps.
/// Place this component inside an EditForm within a FluentWizardStep.
type FluentWizardStepValidatorBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAttrBuilder<'FunBlazorGeneric>()


            
namespace rec Microsoft.FluentUI.AspNetCore.Components.DslInternals.Utilities

open System.Threading.Tasks
open FSharp.Data.Adaptive
open Fun.Blazor
open Fun.Blazor.Operators
open Microsoft.FluentUI.AspNetCore.Components.DslInternals

/// Internal component to conditionally render a tag and its content.
type AddTagBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAndChildAttrBuilder<'FunBlazorGeneric>()
    /// Gets or sets the name of the tag.
    [<CustomOperation("Name")>] member inline _.Name ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Name" => x)
    /// Gets or sets the condition to add the tag Name.
    [<CustomOperation("TagWhen")>] member inline _.TagWhen ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("TagWhen" => (System.Func<System.Boolean>fn))
    /// Gets or sets the condition to add the ChildContent.
    [<CustomOperation("ContentWhen")>] member inline _.ContentWhen ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("ContentWhen" => (System.Func<System.Boolean>fn))
    /// Gets or sets a collection of additional attributes that will be applied to the created element.
    [<CustomOperation("AdditionalAttributes")>] member inline _.AdditionalAttributes ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.IReadOnlyDictionary<System.String, System.Object>) = render ==> ("AdditionalAttributes" => x)

            
namespace rec Microsoft.FluentUI.AspNetCore.Components.DslInternals.Dialog.MessageBox

open System.Threading.Tasks
open FSharp.Data.Adaptive
open Fun.Blazor
open Fun.Blazor.Operators
open Microsoft.FluentUI.AspNetCore.Components.DslInternals

/// Represents a message box dialog.
type FluentMessageBoxBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAttrBuilder<'FunBlazorGeneric>()
    /// Gets or sets the content of the message box.
    /// For security reasons, the content is sanitized using the configured MarkupSanitized before rendering.
    [<CustomOperation("Message")>] member inline _.Message ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<Microsoft.FluentUI.AspNetCore.Components.Utilities.MarkupStringSanitized>) = render ==> ("Message" => x)
    /// Gets or sets the icon of the message box.
    [<CustomOperation("Icon")>] member inline _.Icon ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.FluentUI.AspNetCore.Components.Icon) = render ==> ("Icon" => x)
    /// Gets or sets the icon color.
    [<CustomOperation("IconColor")>] member inline _.IconColor ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.FluentUI.AspNetCore.Components.Color) = render ==> ("IconColor" => x)

            
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


    /// Base class for FluentUI Blazor components.
    type FluentComponentBase' 
        /// Base class for FluentUI Blazor components.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, "Microsoft.FluentUI.AspNetCore.Components.FluentComponentBase", "Microsoft.FluentUI.AspNetCore.Components")>] () = inherit FluentComponentBaseBuilder<Microsoft.FluentUI.AspNetCore.Components.FluentComponentBase>()

    /// The FluentBadge component is a visual indicator that communicates a status or description of an associated component.
    /// It uses short text, color, and icons for quick recognition and is placed near the relevant content.
    type FluentBadge' 
        /// The FluentBadge component is a visual indicator that communicates a status or description of an associated component.
        /// It uses short text, color, and icons for quick recognition and is placed near the relevant content.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, "Microsoft.FluentUI.AspNetCore.Components.FluentBadge", "Microsoft.FluentUI.AspNetCore.Components")>] () = inherit FluentBadgeBuilder<Microsoft.FluentUI.AspNetCore.Components.FluentBadge>()

    /// The FluentCounterBadge component is a visual indicator that communicates a value about an associated component.
    /// It uses short postive numbers, color, and icons for quick recognition and is placed near the relevant content.
    type FluentCounterBadge' 
        /// The FluentCounterBadge component is a visual indicator that communicates a value about an associated component.
        /// It uses short postive numbers, color, and icons for quick recognition and is placed near the relevant content.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, "Microsoft.FluentUI.AspNetCore.Components.FluentCounterBadge", "Microsoft.FluentUI.AspNetCore.Components")>] () = inherit FluentCounterBadgeBuilder<Microsoft.FluentUI.AspNetCore.Components.FluentCounterBadge>()

    /// The FluentButton component allows users to commit a change or trigger an action via a single click or tap and
    /// is often found inside forms, dialogs, drawers (panels) or pages.
    type FluentButton' 
        /// The FluentButton component allows users to commit a change or trigger an action via a single click or tap and
        /// is often found inside forms, dialogs, drawers (panels) or pages.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, "Microsoft.FluentUI.AspNetCore.Components.FluentButton", "Microsoft.FluentUI.AspNetCore.Components")>] () = inherit FluentButtonBuilder<Microsoft.FluentUI.AspNetCore.Components.FluentButton>()

    /// The FluentToggleButton component allows users to commit a change or trigger a toggle action via a single click or tap and
    /// is often found inside forms, dialogs, drawers (panels) and/or pages.
    type FluentMenuButton' 
        /// The FluentToggleButton component allows users to commit a change or trigger a toggle action via a single click or tap and
        /// is often found inside forms, dialogs, drawers (panels) and/or pages.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, "Microsoft.FluentUI.AspNetCore.Components.FluentMenuButton", "Microsoft.FluentUI.AspNetCore.Components")>] () = inherit FluentMenuButtonBuilder<Microsoft.FluentUI.AspNetCore.Components.FluentMenuButton>()

    /// The FluentToggleButton component allows users to commit a change or trigger a toggle action via a single click or tap and
    /// is often found inside forms, dialogs, drawers (panels) and/or pages.
    type FluentToggleButton' 
        /// The FluentToggleButton component allows users to commit a change or trigger a toggle action via a single click or tap and
        /// is often found inside forms, dialogs, drawers (panels) and/or pages.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, "Microsoft.FluentUI.AspNetCore.Components.FluentToggleButton", "Microsoft.FluentUI.AspNetCore.Components")>] () = inherit FluentToggleButtonBuilder<Microsoft.FluentUI.AspNetCore.Components.FluentToggleButton>()

    /// The FluentLabel component is used to display a label for an input component. Normally it is positioned above the component
    type FluentLabel' 
        /// The FluentLabel component is used to display a label for an input component. Normally it is positioned above the component
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, "Microsoft.FluentUI.AspNetCore.Components.FluentLabel", "Microsoft.FluentUI.AspNetCore.Components")>] () = inherit FluentLabelBuilder<Microsoft.FluentUI.AspNetCore.Components.FluentLabel>()

    /// The FluentLabelInfo component extends FluentLabel by displaying an
    /// informational icon next to the label. When the user clicks the icon, a popover
    /// shows additional text, an optional action link, or a custom template.
    type FluentLabelInfo' 
        /// The FluentLabelInfo component extends FluentLabel by displaying an
        /// informational icon next to the label. When the user clicks the icon, a popover
        /// shows additional text, an optional action link, or a custom template.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, "Microsoft.FluentUI.AspNetCore.Components.FluentLabelInfo", "Microsoft.FluentUI.AspNetCore.Components")>] () = inherit FluentLabelInfoBuilder<Microsoft.FluentUI.AspNetCore.Components.FluentLabelInfo>()

    /// Provides a base class for navigation items.
    type FluentNavBase' 
        /// Provides a base class for navigation items.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, "Microsoft.FluentUI.AspNetCore.Components.FluentNavBase", "Microsoft.FluentUI.AspNetCore.Components")>] () = inherit FluentNavBaseBuilder<Microsoft.FluentUI.AspNetCore.Components.FluentNavBase>()

    /// Represents a group of related navigation items for use in a fluent navigation interface.
    type FluentNavCategory' 
        /// Represents a group of related navigation items for use in a fluent navigation interface.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, "Microsoft.FluentUI.AspNetCore.Components.FluentNavCategory", "Microsoft.FluentUI.AspNetCore.Components")>] () = inherit FluentNavCategoryBuilder<Microsoft.FluentUI.AspNetCore.Components.FluentNavCategory>()

    /// Represents a navigation menu item that renders content within a Fluent UI styled navigation link.
    type FluentNavItem' 
        /// Represents a navigation menu item that renders content within a Fluent UI styled navigation link.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, "Microsoft.FluentUI.AspNetCore.Components.FluentNavItem", "Microsoft.FluentUI.AspNetCore.Components")>] () = inherit FluentNavItemBuilder<Microsoft.FluentUI.AspNetCore.Components.FluentNavItem>()

    /// Visual representation of content being loaded or processed.
    type FluentProgressBar' 
        /// Visual representation of content being loaded or processed.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, "Microsoft.FluentUI.AspNetCore.Components.FluentProgressBar", "Microsoft.FluentUI.AspNetCore.Components")>] () = inherit FluentProgressBarBuilder<Microsoft.FluentUI.AspNetCore.Components.FluentProgressBar>()

    /// Visual representation of content being loaded or processed.
    /// This component is renamed to FluentProgressBar and will be removed in a future release.
    type FluentProgress' 
        /// Visual representation of content being loaded or processed.
        /// This component is renamed to FluentProgressBar and will be removed in a future release.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, "Microsoft.FluentUI.AspNetCore.Components.FluentProgress", "Microsoft.FluentUI.AspNetCore.Components")>] () = inherit FluentProgressBuilder<Microsoft.FluentUI.AspNetCore.Components.FluentProgress>()

    /// A spinner alerts a user that content is being loaded or processed and they should wait for the activity to complete.
    type FluentSpinner' 
        /// A spinner alerts a user that content is being loaded or processed and they should wait for the activity to complete.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, "Microsoft.FluentUI.AspNetCore.Components.FluentSpinner", "Microsoft.FluentUI.AspNetCore.Components")>] () = inherit FluentSpinnerBuilder<Microsoft.FluentUI.AspNetCore.Components.FluentSpinner>()

    /// A spinner alerts a user that content is being loaded or processed and they should wait for the activity to complete.
    /// This component is renamed to FluentSpinner and will be removed in a future release.
    type FluentProgressRing' 
        /// A spinner alerts a user that content is being loaded or processed and they should wait for the activity to complete.
        /// This component is renamed to FluentSpinner and will be removed in a future release.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, "Microsoft.FluentUI.AspNetCore.Components.FluentProgressRing", "Microsoft.FluentUI.AspNetCore.Components")>] () = inherit FluentProgressRingBuilder<Microsoft.FluentUI.AspNetCore.Components.FluentProgressRing>()

    /// The FluentAccordion component allows to toggle the display of content by expanding or collapsing sections.
    type FluentAccordion' 
        /// The FluentAccordion component allows to toggle the display of content by expanding or collapsing sections.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, "Microsoft.FluentUI.AspNetCore.Components.FluentAccordion", "Microsoft.FluentUI.AspNetCore.Components")>] () = inherit FluentAccordionBuilder<Microsoft.FluentUI.AspNetCore.Components.FluentAccordion>()

    /// Represents an item in a Fluent Accordion component, allowing for customization of its heading, expanded state, and
    /// content. It also manages its registration with the owning FluentTreeView and handles state changes.
    ///             
    type FluentAccordionItem' 
        /// Represents an item in a Fluent Accordion component, allowing for customization of its heading, expanded state, and
        /// content. It also manages its registration with the owning FluentTreeView and handles state changes.
        ///             
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, "Microsoft.FluentUI.AspNetCore.Components.FluentAccordionItem", "Microsoft.FluentUI.AspNetCore.Components")>] () = inherit FluentAccordionItemBuilder<Microsoft.FluentUI.AspNetCore.Components.FluentAccordionItem>()

    /// The FluentAppBar component is a native Blazor component that allows users to have an app bar like the one in Teams.
    /// It is a container for app bar items, which can be either FluentAppBarItem or any other component that implements IAppBarItem.
    /// AppBar items can overflow into a popover (with search capabilities) when there is not enough space to display them all.
    type FluentAppBar' 
        /// The FluentAppBar component is a native Blazor component that allows users to have an app bar like the one in Teams.
        /// It is a container for app bar items, which can be either FluentAppBarItem or any other component that implements IAppBarItem.
        /// AppBar items can overflow into a popover (with search capabilities) when there is not enough space to display them all.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, "Microsoft.FluentUI.AspNetCore.Components.FluentAppBar", "Microsoft.FluentUI.AspNetCore.Components")>] () = inherit FluentAppBarBuilder<Microsoft.FluentUI.AspNetCore.Components.FluentAppBar>()

    /// AppBar item component for use within a FluentAppBar.
    type FluentAppBarItem' 
        /// AppBar item component for use within a FluentAppBar.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, "Microsoft.FluentUI.AspNetCore.Components.FluentAppBarItem", "Microsoft.FluentUI.AspNetCore.Components")>] () = inherit FluentAppBarItemBuilder<Microsoft.FluentUI.AspNetCore.Components.FluentAppBarItem>()

    /// The FluentAvatar component is used to represent a user or entity. It can display an image, initials, or an icon.
    type FluentAvatar' 
        /// The FluentAvatar component is used to represent a user or entity. It can display an image, initials, or an icon.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, "Microsoft.FluentUI.AspNetCore.Components.FluentAvatar", "Microsoft.FluentUI.AspNetCore.Components")>] () = inherit FluentAvatarBuilder<Microsoft.FluentUI.AspNetCore.Components.FluentAvatar>()

    /// The FluentPresenceBadge component is a visual indicator that communicates a user's presence status.
    /// It displays a colored icon overlay typically attached to an avatar or similar element.
    type FluentPresenceBadge' 
        /// The FluentPresenceBadge component is a visual indicator that communicates a user's presence status.
        /// It displays a colored icon overlay typically attached to an avatar or similar element.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, "Microsoft.FluentUI.AspNetCore.Components.FluentPresenceBadge", "Microsoft.FluentUI.AspNetCore.Components")>] () = inherit FluentPresenceBadgeBuilder<Microsoft.FluentUI.AspNetCore.Components.FluentPresenceBadge>()

    /// A FluentUI AnchorButton component.
    type FluentAnchorButton' 
        /// A FluentUI AnchorButton component.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, "Microsoft.FluentUI.AspNetCore.Components.FluentAnchorButton", "Microsoft.FluentUI.AspNetCore.Components")>] () = inherit FluentAnchorButtonBuilder<Microsoft.FluentUI.AspNetCore.Components.FluentAnchorButton>()

    /// A FluentUI AnchorButton component.
    type FluentCompoundButton' 
        /// A FluentUI AnchorButton component.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, "Microsoft.FluentUI.AspNetCore.Components.FluentCompoundButton", "Microsoft.FluentUI.AspNetCore.Components")>] () = inherit FluentCompoundButtonBuilder<Microsoft.FluentUI.AspNetCore.Components.FluentCompoundButton>()

    /// The FluentSplitButton component allows users to combine a button with a menu where the left part triggers a primary action and the right part opens a menu with secondary actions.
    /// is often found inside forms, dialogs, drawers (panels) and/or pages.
    type FluentSplitButton' 
        /// The FluentSplitButton component allows users to combine a button with a menu where the left part triggers a primary action and the right part opens a menu with secondary actions.
        /// is often found inside forms, dialogs, drawers (panels) and/or pages.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, "Microsoft.FluentUI.AspNetCore.Components.FluentSplitButton", "Microsoft.FluentUI.AspNetCore.Components")>] () = inherit FluentSplitButtonBuilder<Microsoft.FluentUI.AspNetCore.Components.FluentSplitButton>()

    /// A FluentCard is a container that holds information and actions related to a single concept or object, like a document or a contact.
    type FluentCard' 
        /// A FluentCard is a container that holds information and actions related to a single concept or object, like a document or a contact.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, "Microsoft.FluentUI.AspNetCore.Components.FluentCard", "Microsoft.FluentUI.AspNetCore.Components")>] () = inherit FluentCardBuilder<Microsoft.FluentUI.AspNetCore.Components.FluentCard>()

    /// The ColorPicker component is used to select a color from a palette.
    type FluentColorPicker' 
        /// The ColorPicker component is used to select a color from a palette.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, "Microsoft.FluentUI.AspNetCore.Components.FluentColorPicker", "Microsoft.FluentUI.AspNetCore.Components")>] () = inherit FluentColorPickerBuilder<Microsoft.FluentUI.AspNetCore.Components.FluentColorPicker>()

    /// A component that displays a grid.
    type FluentDataGrid'<'TGridItem> 
        /// A component that displays a grid.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, "Microsoft.FluentUI.AspNetCore.Components.FluentDataGrid`1", "Microsoft.FluentUI.AspNetCore.Components")>] () = inherit FluentDataGridBuilder<Microsoft.FluentUI.AspNetCore.Components.FluentDataGrid<'TGridItem>, 'TGridItem>()

    /// Represents a cell in a FluentDataGrid`1.
    type FluentDataGridCell'<'TGridItem> 
        /// Represents a cell in a FluentDataGrid`1.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, "Microsoft.FluentUI.AspNetCore.Components.FluentDataGridCell`1", "Microsoft.FluentUI.AspNetCore.Components")>] () = inherit FluentDataGridCellBuilder<Microsoft.FluentUI.AspNetCore.Components.FluentDataGridCell<'TGridItem>, 'TGridItem>()

    /// Represents a row in a FluentDataGrid`1 component, providing functionality for rendering,
    /// interaction, and data binding.
    type FluentDataGridRow'<'TGridItem> 
        /// Represents a row in a FluentDataGrid`1 component, providing functionality for rendering,
        /// interaction, and data binding.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, "Microsoft.FluentUI.AspNetCore.Components.FluentDataGridRow`1", "Microsoft.FluentUI.AspNetCore.Components")>] () = inherit FluentDataGridRowBuilder<Microsoft.FluentUI.AspNetCore.Components.FluentDataGridRow<'TGridItem>, 'TGridItem>()

    /// The dialog component is a window overlaid on either the primary window or another dialog window.
    /// Windows under a modal dialog are inert.
    type FluentDialog' 
        /// The dialog component is a window overlaid on either the primary window or another dialog window.
        /// Windows under a modal dialog are inert.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, "Microsoft.FluentUI.AspNetCore.Components.FluentDialog", "Microsoft.FluentUI.AspNetCore.Components")>] () = inherit FluentDialogBuilder<Microsoft.FluentUI.AspNetCore.Components.FluentDialog>()

    /// The dialog component is a window overlaid on either the primary window or another dialog window.
    /// Windows under a modal dialog are inert. 
    type FluentDialogBody' 
        /// The dialog component is a window overlaid on either the primary window or another dialog window.
        /// Windows under a modal dialog are inert. 
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, "Microsoft.FluentUI.AspNetCore.Components.FluentDialogBody", "Microsoft.FluentUI.AspNetCore.Components")>] () = inherit FluentDialogBodyBuilder<Microsoft.FluentUI.AspNetCore.Components.FluentDialogBody>()
    type FluentDialogProvider' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, "Microsoft.FluentUI.AspNetCore.Components.FluentDialogProvider", "Microsoft.FluentUI.AspNetCore.Components")>] () = inherit FluentDialogProviderBuilder<Microsoft.FluentUI.AspNetCore.Components.FluentDialogProvider>()

    /// A horizontal or vertical rule used to visually separate content.
    type FluentDivider' 
        /// A horizontal or vertical rule used to visually separate content.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, "Microsoft.FluentUI.AspNetCore.Components.FluentDivider", "Microsoft.FluentUI.AspNetCore.Components")>] () = inherit FluentDividerBuilder<Microsoft.FluentUI.AspNetCore.Components.FluentDivider>()
    type FluentDragContainer'<'TItem> [<DynamicDependency(DynamicallyAccessedMemberTypes.All, "Microsoft.FluentUI.AspNetCore.Components.FluentDragContainer`1", "Microsoft.FluentUI.AspNetCore.Components")>] () = inherit FluentDragContainerBuilder<Microsoft.FluentUI.AspNetCore.Components.FluentDragContainer<'TItem>, 'TItem>()
    type FluentDropZone'<'TItem> [<DynamicDependency(DynamicallyAccessedMemberTypes.All, "Microsoft.FluentUI.AspNetCore.Components.FluentDropZone`1", "Microsoft.FluentUI.AspNetCore.Components")>] () = inherit FluentDropZoneBuilder<Microsoft.FluentUI.AspNetCore.Components.FluentDropZone<'TItem>, 'TItem>()

    /// FluentEmoji is a component that renders an emoji from the Microsoft FluentUI emoji set.
    type FluentEmoji'<'Emoji when 'Emoji : (new : unit -> 'Emoji) and 'Emoji :> Microsoft.FluentUI.AspNetCore.Components.Emoji> 
        /// FluentEmoji is a component that renders an emoji from the Microsoft FluentUI emoji set.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, "Microsoft.FluentUI.AspNetCore.Components.FluentEmoji`1", "Microsoft.FluentUI.AspNetCore.Components")>] () = inherit FluentEmojiBuilder<Microsoft.FluentUI.AspNetCore.Components.FluentEmoji<'Emoji>, 'Emoji>()

    /// Provides a mechanism for handling errors in a fluent manner within a specific context.
    type FluentErrorBoundary' 
        /// Provides a mechanism for handling errors in a fluent manner within a specific context.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, "Microsoft.FluentUI.AspNetCore.Components.FluentErrorBoundary", "Microsoft.FluentUI.AspNetCore.Components")>] () = inherit FluentErrorBoundaryBuilder<Microsoft.FluentUI.AspNetCore.Components.FluentErrorBoundary>()

    /// Field adds a label, validation message, and hint text to a control.
    type FluentField' 
        /// Field adds a label, validation message, and hint text to a control.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, "Microsoft.FluentUI.AspNetCore.Components.FluentField", "Microsoft.FluentUI.AspNetCore.Components")>] () = inherit FluentFieldBuilder<Microsoft.FluentUI.AspNetCore.Components.FluentField>()

    /// Displays validation messages for a specified field within a cascaded EditContext.
    type FluentValidationMessage'<'TValue> 
        /// Displays validation messages for a specified field within a cascaded EditContext.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, "Microsoft.FluentUI.AspNetCore.Components.FluentValidationMessage`1", "Microsoft.FluentUI.AspNetCore.Components")>] () = inherit FluentValidationMessageBuilder<Microsoft.FluentUI.AspNetCore.Components.FluentValidationMessage<'TValue>, 'TValue>()

    /// The grid component helps keeping layout consistent across various screen resolutions and sizes.
    /// PowerGrid comes with a 12-point grid system and contains 5 types of breakpoints
    /// that are used for specific screen sizes.
    type FluentGrid' 
        /// The grid component helps keeping layout consistent across various screen resolutions and sizes.
        /// PowerGrid comes with a 12-point grid system and contains 5 types of breakpoints
        /// that are used for specific screen sizes.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, "Microsoft.FluentUI.AspNetCore.Components.FluentGrid", "Microsoft.FluentUI.AspNetCore.Components")>] () = inherit FluentGridBuilder<Microsoft.FluentUI.AspNetCore.Components.FluentGrid>()

    /// Value placed within a FluentGrid layout using the FluentGridItem component.
    type FluentGridItem' 
        /// Value placed within a FluentGrid layout using the FluentGridItem component.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, "Microsoft.FluentUI.AspNetCore.Components.FluentGridItem", "Microsoft.FluentUI.AspNetCore.Components")>] () = inherit FluentGridItemBuilder<Microsoft.FluentUI.AspNetCore.Components.FluentGridItem>()

    /// A component which highlights words or phrases within text.
    type FluentHighlighter' 
        /// A component which highlights words or phrases within text.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, "Microsoft.FluentUI.AspNetCore.Components.FluentHighlighter", "Microsoft.FluentUI.AspNetCore.Components")>] () = inherit FluentHighlighterBuilder<Microsoft.FluentUI.AspNetCore.Components.FluentHighlighter>()

    /// FluentIcon is a component that renders an icon from the Fluent System icon set.
    type FluentIcon'<'Icon when 'Icon : (new : unit -> 'Icon) and 'Icon :> Microsoft.FluentUI.AspNetCore.Components.Icon> 
        /// FluentIcon is a component that renders an icon from the Fluent System icon set.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, "Microsoft.FluentUI.AspNetCore.Components.FluentIcon`1", "Microsoft.FluentUI.AspNetCore.Components")>] () = inherit FluentIconBuilder<Microsoft.FluentUI.AspNetCore.Components.FluentIcon<'Icon>, 'Icon>()

    /// The Fluent Image component is used to display an image, providing various options for styling and layout.
    type FluentImage' 
        /// The Fluent Image component is used to display an image, providing various options for styling and layout.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, "Microsoft.FluentUI.AspNetCore.Components.FluentImage", "Microsoft.FluentUI.AspNetCore.Components")>] () = inherit FluentImageBuilder<Microsoft.FluentUI.AspNetCore.Components.FluentImage>()

    /// Represents a component for handling file uploads with support for drag-and-drop, progress tracking, and file
    /// validation.
    type FluentInputFile' 
        /// Represents a component for handling file uploads with support for drag-and-drop, progress tracking, and file
        /// validation.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, "Microsoft.FluentUI.AspNetCore.Components.FluentInputFile", "Microsoft.FluentUI.AspNetCore.Components")>] () = inherit FluentInputFileBuilder<Microsoft.FluentUI.AspNetCore.Components.FluentInputFile>()

    /// Extends the OnKeyDown blazor event to provide a more fluent way to evaluate the key code.
    /// The anchor must refer to the ID of an element (or sub-element) accepting the focus.
    type FluentKeyCode' 
        /// Extends the OnKeyDown blazor event to provide a more fluent way to evaluate the key code.
        /// The anchor must refer to the ID of an element (or sub-element) accepting the focus.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, "Microsoft.FluentUI.AspNetCore.Components.FluentKeyCode", "Microsoft.FluentUI.AspNetCore.Components")>] () = inherit FluentKeyCodeBuilder<Microsoft.FluentUI.AspNetCore.Components.FluentKeyCode>()

    /// Component that defines a layout for a page, using a grid composed of a PanelHeader, a Footer and 3 columns: Menu, Value and Aside Pane.
    /// For mobile devices (< 768px), the layout is a single column with the Menu, Value and Footer panes stacked vertically.
    type FluentLayout' 
        /// Component that defines a layout for a page, using a grid composed of a PanelHeader, a Footer and 3 columns: Menu, Value and Aside Pane.
        /// For mobile devices (< 768px), the layout is a single column with the Menu, Value and Footer panes stacked vertically.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, "Microsoft.FluentUI.AspNetCore.Components.FluentLayout", "Microsoft.FluentUI.AspNetCore.Components")>] () = inherit FluentLayoutBuilder<Microsoft.FluentUI.AspNetCore.Components.FluentLayout>()

    /// Component to display a hamburger icon that can be used to open and close a menu, on mobile device only.
    type FluentLayoutHamburger' 
        /// Component to display a hamburger icon that can be used to open and close a menu, on mobile device only.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, "Microsoft.FluentUI.AspNetCore.Components.FluentLayoutHamburger", "Microsoft.FluentUI.AspNetCore.Components")>] () = inherit FluentLayoutHamburgerBuilder<Microsoft.FluentUI.AspNetCore.Components.FluentLayoutHamburger>()

    /// Area of the layout where the item is placed.
    type FluentLayoutItem' 
        /// Area of the layout where the item is placed.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, "Microsoft.FluentUI.AspNetCore.Components.FluentLayoutItem", "Microsoft.FluentUI.AspNetCore.Components")>] () = inherit FluentLayoutItemBuilder<Microsoft.FluentUI.AspNetCore.Components.FluentLayoutItem>()

    /// The FluentLink component specifies relationships between the current document and an external resource.
    type FluentLink' 
        /// The FluentLink component specifies relationships between the current document and an external resource.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, "Microsoft.FluentUI.AspNetCore.Components.FluentLink", "Microsoft.FluentUI.AspNetCore.Components")>] () = inherit FluentLinkBuilder<Microsoft.FluentUI.AspNetCore.Components.FluentLink>()

    /// The Option element is used to define an item contained in a List component.
    type FluentOption'<'TValue> 
        /// The Option element is used to define an item contained in a List component.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, "Microsoft.FluentUI.AspNetCore.Components.FluentOption`1", "Microsoft.FluentUI.AspNetCore.Components")>] () = inherit FluentOptionBuilder<Microsoft.FluentUI.AspNetCore.Components.FluentOption<'TValue>, 'TValue>()

    /// The Option element is used to define a `string` item contained in a List component.
    /// This is a convenience class so that you don't have to specify the generic type parameter or
    /// to have a weird syntax in Razor like `FluentOption TValue="string" Value="@("My value")"`.
    type FluentOptionString' 
        /// The Option element is used to define a `string` item contained in a List component.
        /// This is a convenience class so that you don't have to specify the generic type parameter or
        /// to have a weird syntax in Razor like `FluentOption TValue="string" Value="@("My value")"`.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, "Microsoft.FluentUI.AspNetCore.Components.FluentOptionString", "Microsoft.FluentUI.AspNetCore.Components")>] () = inherit FluentOptionStringBuilder<Microsoft.FluentUI.AspNetCore.Components.FluentOptionString>()

    /// A FreeOptionOutput allows one option to be written in free form.
    type FreeOptionOutput' 
        /// A FreeOptionOutput allows one option to be written in free form.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, "Microsoft.FluentUI.AspNetCore.Components.FreeOptionOutput", "Microsoft.FluentUI.AspNetCore.Components")>] () = inherit FreeOptionOutputBuilder<Microsoft.FluentUI.AspNetCore.Components.FreeOptionOutput>()

    /// A Menu component for handling menus and menu items in a user interface.
    type FluentMenu' 
        /// A Menu component for handling menus and menu items in a user interface.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, "Microsoft.FluentUI.AspNetCore.Components.FluentMenu", "Microsoft.FluentUI.AspNetCore.Components")>] () = inherit FluentMenuBuilder<Microsoft.FluentUI.AspNetCore.Components.FluentMenu>()

    /// Menu list item which is displayed in a MenuList component.
    type FluentMenuItem' 
        /// Menu list item which is displayed in a MenuList component.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, "Microsoft.FluentUI.AspNetCore.Components.FluentMenuItem", "Microsoft.FluentUI.AspNetCore.Components")>] () = inherit FluentMenuItemBuilder<Microsoft.FluentUI.AspNetCore.Components.FluentMenuItem>()

    /// The MenuList displays a list of MenuItem options.
    type FluentMenuList' 
        /// The MenuList displays a list of MenuItem options.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, "Microsoft.FluentUI.AspNetCore.Components.FluentMenuList", "Microsoft.FluentUI.AspNetCore.Components")>] () = inherit FluentMenuListBuilder<Microsoft.FluentUI.AspNetCore.Components.FluentMenuList>()

    /// Component to communicate important information about the state of the entire application or surface
    type FluentMessageBar' 
        /// Component to communicate important information about the state of the entire application or surface
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, "Microsoft.FluentUI.AspNetCore.Components.FluentMessageBar", "Microsoft.FluentUI.AspNetCore.Components")>] () = inherit FluentMessageBarBuilder<Microsoft.FluentUI.AspNetCore.Components.FluentMessageBar>()

    /// Container component that renders all message bars registered with the INotificationService.
    type FluentMessageBarProvider' 
        /// Container component that renders all message bars registered with the INotificationService.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, "Microsoft.FluentUI.AspNetCore.Components.FluentMessageBarProvider", "Microsoft.FluentUI.AspNetCore.Components")>] () = inherit FluentMessageBarProviderBuilder<Microsoft.FluentUI.AspNetCore.Components.FluentMessageBarProvider>()

    /// Represents a navigation menu component that displays a hamburger icon and provides navigation functionality within
    /// a Fluent UI application.
    type FluentNav' 
        /// Represents a navigation menu component that displays a hamburger icon and provides navigation functionality within
        /// a Fluent UI application.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, "Microsoft.FluentUI.AspNetCore.Components.FluentNav", "Microsoft.FluentUI.AspNetCore.Components")>] () = inherit FluentNavBuilder<Microsoft.FluentUI.AspNetCore.Components.FluentNav>()

    /// A section header for use within a FluentNav
    type FluentNavSectionHeader' 
        /// A section header for use within a FluentNav
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, "Microsoft.FluentUI.AspNetCore.Components.FluentNavSectionHeader", "Microsoft.FluentUI.AspNetCore.Components")>] () = inherit FluentNavSectionHeaderBuilder<Microsoft.FluentUI.AspNetCore.Components.FluentNavSectionHeader>()
    type FluentOverflow'<'TItem> [<DynamicDependency(DynamicallyAccessedMemberTypes.All, "Microsoft.FluentUI.AspNetCore.Components.FluentOverflow`1", "Microsoft.FluentUI.AspNetCore.Components")>] () = inherit FluentOverflowBuilder<Microsoft.FluentUI.AspNetCore.Components.FluentOverflow<'TItem>, 'TItem>()

    /// Represents an overlay component that provides visual layering and interaction blocking in Fluent UI applications.
    type FluentOverlay' 
        /// Represents an overlay component that provides visual layering and interaction blocking in Fluent UI applications.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, "Microsoft.FluentUI.AspNetCore.Components.FluentOverlay", "Microsoft.FluentUI.AspNetCore.Components")>] () = inherit FluentOverlayBuilder<Microsoft.FluentUI.AspNetCore.Components.FluentOverlay>()

    /// A component that provides a user interface for PaginationState.
    type FluentPaginator' 
        /// A component that provides a user interface for PaginationState.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, "Microsoft.FluentUI.AspNetCore.Components.FluentPaginator", "Microsoft.FluentUI.AspNetCore.Components")>] () = inherit FluentPaginatorBuilder<Microsoft.FluentUI.AspNetCore.Components.FluentPaginator>()

    /// The FluentPopover component is used to displays content on top of other content.
    type FluentPopover' 
        /// The FluentPopover component is used to displays content on top of other content.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, "Microsoft.FluentUI.AspNetCore.Components.FluentPopover", "Microsoft.FluentUI.AspNetCore.Components")>] () = inherit FluentPopoverBuilder<Microsoft.FluentUI.AspNetCore.Components.FluentPopover>()
    type FluentPullToRefresh' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, "Microsoft.FluentUI.AspNetCore.Components.FluentPullToRefresh", "Microsoft.FluentUI.AspNetCore.Components")>] () = inherit FluentPullToRefreshBuilder<Microsoft.FluentUI.AspNetCore.Components.FluentPullToRefresh>()

    /// A Fluent Radio button component.
    type FluentRadio'<'TValue> 
        /// A Fluent Radio button component.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, "Microsoft.FluentUI.AspNetCore.Components.FluentRadio`1", "Microsoft.FluentUI.AspNetCore.Components")>] () = inherit FluentRadioBuilder<Microsoft.FluentUI.AspNetCore.Components.FluentRadio<'TValue>, 'TValue>()

    /// Displays a read-only star rating, such as an average product score or user review summary.
    type FluentRatingDisplay' 
        /// Displays a read-only star rating, such as an average product score or user review summary.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, "Microsoft.FluentUI.AspNetCore.Components.FluentRatingDisplay", "Microsoft.FluentUI.AspNetCore.Components")>] () = inherit FluentRatingDisplayBuilder<Microsoft.FluentUI.AspNetCore.Components.FluentRatingDisplay>()

    /// Represents a skeleton loading component that provides visual placeholders for content while it is being loaded.
    type FluentSkeleton' 
        /// Represents a skeleton loading component that provides visual placeholders for content while it is being loaded.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, "Microsoft.FluentUI.AspNetCore.Components.FluentSkeleton", "Microsoft.FluentUI.AspNetCore.Components")>] () = inherit FluentSkeletonBuilder<Microsoft.FluentUI.AspNetCore.Components.FluentSkeleton>()

    /// A sortable list component that allows users to reorder items via drag-and-drop.
    /// The type of the items in the list.
    type FluentSortableList'<'TItem> 
        /// A sortable list component that allows users to reorder items via drag-and-drop.
        /// The type of the items in the list.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, "Microsoft.FluentUI.AspNetCore.Components.FluentSortableList`1", "Microsoft.FluentUI.AspNetCore.Components")>] () = inherit FluentSortableListBuilder<Microsoft.FluentUI.AspNetCore.Components.FluentSortableList<'TItem>, 'TItem>()

    /// Spacer component, used to create space between elements.
    type FluentSpacer' 
        /// Spacer component, used to create space between elements.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, "Microsoft.FluentUI.AspNetCore.Components.FluentSpacer", "Microsoft.FluentUI.AspNetCore.Components")>] () = inherit FluentSpacerBuilder<Microsoft.FluentUI.AspNetCore.Components.FluentSpacer>()

    /// Represents a multi-pane splitter component that allows resizing, collapsing, and expanding of its panes. It supports
    /// callbacks for pane events.
    type FluentMultiSplitter' 
        /// Represents a multi-pane splitter component that allows resizing, collapsing, and expanding of its panes. It supports
        /// callbacks for pane events.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, "Microsoft.FluentUI.AspNetCore.Components.FluentMultiSplitter", "Microsoft.FluentUI.AspNetCore.Components")>] () = inherit FluentMultiSplitterBuilder<Microsoft.FluentUI.AspNetCore.Components.FluentMultiSplitter>()

    /// Represents a pane in a multi-splitter layout, allowing for child content, resizing, and collapsing behavior.
    /// It manages its size and state within a splitter.
    type FluentMultiSplitterPane' 
        /// Represents a pane in a multi-splitter layout, allowing for child content, resizing, and collapsing behavior.
        /// It manages its size and state within a splitter.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, "Microsoft.FluentUI.AspNetCore.Components.FluentMultiSplitterPane", "Microsoft.FluentUI.AspNetCore.Components")>] () = inherit FluentMultiSplitterPaneBuilder<Microsoft.FluentUI.AspNetCore.Components.FluentMultiSplitterPane>()

    /// A container-type component that can be used to arrange its child components in a horizontal or vertical stack.
    type FluentStack' 
        /// A container-type component that can be used to arrange its child components in a horizontal or vertical stack.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, "Microsoft.FluentUI.AspNetCore.Components.FluentStack", "Microsoft.FluentUI.AspNetCore.Components")>] () = inherit FluentStackBuilder<Microsoft.FluentUI.AspNetCore.Components.FluentStack>()

    /// A FluentTabs allows people to switch between categories of related information without going to different pages
    type FluentTab' 
        /// A FluentTabs allows people to switch between categories of related information without going to different pages
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, "Microsoft.FluentUI.AspNetCore.Components.FluentTab", "Microsoft.FluentUI.AspNetCore.Components")>] () = inherit FluentTabBuilder<Microsoft.FluentUI.AspNetCore.Components.FluentTab>()

    /// Each tab typically contains a text header and often includes an icon.
    type FluentTabs' 
        /// Each tab typically contains a text header and often includes an icon.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, "Microsoft.FluentUI.AspNetCore.Components.FluentTabs", "Microsoft.FluentUI.AspNetCore.Components")>] () = inherit FluentTabsBuilder<Microsoft.FluentUI.AspNetCore.Components.FluentTabs>()

    /// FluentText component, codifies Fluent's opinions on typography to make them easy to use and standardize across products.
    type FluentText' 
        /// FluentText component, codifies Fluent's opinions on typography to make them easy to use and standardize across products.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, "Microsoft.FluentUI.AspNetCore.Components.FluentText", "Microsoft.FluentUI.AspNetCore.Components")>] () = inherit FluentTextBuilder<Microsoft.FluentUI.AspNetCore.Components.FluentText>()

    /// The FluentToast component represents a transient message that appears on the screen to provide feedback or
    /// information to the user. It is typically used for displaying notifications, alerts, or status messages in a
    /// non-intrusive manner. The FluentToast component can be customized with various options such as position, intent,
    /// timeout duration, and actions, allowing developers to create engaging and informative user experiences.
    type FluentToast' 
        /// The FluentToast component represents a transient message that appears on the screen to provide feedback or
        /// information to the user. It is typically used for displaying notifications, alerts, or status messages in a
        /// non-intrusive manner. The FluentToast component can be customized with various options such as position, intent,
        /// timeout duration, and actions, allowing developers to create engaging and informative user experiences.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, "Microsoft.FluentUI.AspNetCore.Components.FluentToast", "Microsoft.FluentUI.AspNetCore.Components")>] () = inherit FluentToastBuilder<Microsoft.FluentUI.AspNetCore.Components.FluentToast>()
    type FluentToastProvider' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, "Microsoft.FluentUI.AspNetCore.Components.FluentToastProvider", "Microsoft.FluentUI.AspNetCore.Components")>] () = inherit FluentToastProviderBuilder<Microsoft.FluentUI.AspNetCore.Components.FluentToastProvider>()

    /// A FluentTooltip displays additional information about another component.
    /// The information is displayed above and near the target component.
    type FluentTooltip' 
        /// A FluentTooltip displays additional information about another component.
        /// The information is displayed above and near the target component.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, "Microsoft.FluentUI.AspNetCore.Components.FluentTooltip", "Microsoft.FluentUI.AspNetCore.Components")>] () = inherit FluentTooltipBuilder<Microsoft.FluentUI.AspNetCore.Components.FluentTooltip>()
    type FluentTooltipProvider' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, "Microsoft.FluentUI.AspNetCore.Components.FluentTooltipProvider", "Microsoft.FluentUI.AspNetCore.Components")>] () = inherit FluentTooltipProviderBuilder<Microsoft.FluentUI.AspNetCore.Components.FluentTooltipProvider>()

    /// Represents a tree item in a FluentTreeView.
    type FluentTreeItem' 
        /// Represents a tree item in a FluentTreeView.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, "Microsoft.FluentUI.AspNetCore.Components.FluentTreeItem", "Microsoft.FluentUI.AspNetCore.Components")>] () = inherit FluentTreeItemBuilder<Microsoft.FluentUI.AspNetCore.Components.FluentTreeItem>()

    /// Represents a tree view component.
    type FluentTreeView' 
        /// Represents a tree view component.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, "Microsoft.FluentUI.AspNetCore.Components.FluentTreeView", "Microsoft.FluentUI.AspNetCore.Components")>] () = inherit FluentTreeViewBuilder<Microsoft.FluentUI.AspNetCore.Components.FluentTreeView>()

    /// A wizard component that provides a step-by-step user interface.
    type FluentWizard' 
        /// A wizard component that provides a step-by-step user interface.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, "Microsoft.FluentUI.AspNetCore.Components.FluentWizard", "Microsoft.FluentUI.AspNetCore.Components")>] () = inherit FluentWizardBuilder<Microsoft.FluentUI.AspNetCore.Components.FluentWizard>()

    /// Represents an individual step within a FluentWizard component.
    type FluentWizardStep' 
        /// Represents an individual step within a FluentWizard component.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, "Microsoft.FluentUI.AspNetCore.Components.FluentWizardStep", "Microsoft.FluentUI.AspNetCore.Components")>] () = inherit FluentWizardStepBuilder<Microsoft.FluentUI.AspNetCore.Components.FluentWizardStep>()
    type FluentProviders' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, "Microsoft.FluentUI.AspNetCore.Components.FluentProviders", "Microsoft.FluentUI.AspNetCore.Components")>] () = inherit FluentProvidersBuilder<Microsoft.FluentUI.AspNetCore.Components.FluentProviders>()

    /// Displays a list of validation messages from a cascaded EditContext.
    type ValidationSummary' 
        /// Displays a list of validation messages from a cascaded EditContext.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, "Microsoft.AspNetCore.Components.Forms.ValidationSummary", "Microsoft.AspNetCore.Components.Web")>] () = inherit ValidationSummaryBuilder<Microsoft.AspNetCore.Components.Forms.ValidationSummary>()

    /// Displays a summary of validation messages for a specified model within a cascaded EditContext.
    type FluentValidationSummary' 
        /// Displays a summary of validation messages for a specified model within a cascaded EditContext.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, "Microsoft.FluentUI.AspNetCore.Components.FluentValidationSummary", "Microsoft.FluentUI.AspNetCore.Components")>] () = inherit FluentValidationSummaryBuilder<Microsoft.FluentUI.AspNetCore.Components.FluentValidationSummary>()

    /// An abstract base class for columns in a FluentDataGrid`1.
    type ColumnBase'<'TGridItem> 
        /// An abstract base class for columns in a FluentDataGrid`1.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, "Microsoft.FluentUI.AspNetCore.Components.ColumnBase`1", "Microsoft.FluentUI.AspNetCore.Components")>] () = inherit ColumnBaseBuilder<Microsoft.FluentUI.AspNetCore.Components.ColumnBase<'TGridItem>, 'TGridItem>()

    /// Represents a FluentDataGrid`1 column whose cells display a single value.
    type PropertyColumn'<'TGridItem, 'TProp> 
        /// Represents a FluentDataGrid`1 column whose cells display a single value.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, "Microsoft.FluentUI.AspNetCore.Components.PropertyColumn`2", "Microsoft.FluentUI.AspNetCore.Components")>] () = inherit PropertyColumnBuilder<Microsoft.FluentUI.AspNetCore.Components.PropertyColumn<'TGridItem, 'TProp>, 'TGridItem, 'TProp>()

    /// Represents a FluentDataGrid`1 column whose cells render a selected checkbox updated when the user click on a row.
    type SelectColumn'<'TGridItem> 
        /// Represents a FluentDataGrid`1 column whose cells render a selected checkbox updated when the user click on a row.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, "Microsoft.FluentUI.AspNetCore.Components.SelectColumn`1", "Microsoft.FluentUI.AspNetCore.Components")>] () = inherit SelectColumnBuilder<Microsoft.FluentUI.AspNetCore.Components.SelectColumn<'TGridItem>, 'TGridItem>()

    /// Represents a FluentDataGrid`1 column that combines hierarchical indentation,
    /// expand/collapse toggles, a selection checkbox/radio, and user-defined template content.
    type HierarchicalSelectColumn'<'TGridItem> 
        /// Represents a FluentDataGrid`1 column that combines hierarchical indentation,
        /// expand/collapse toggles, a selection checkbox/radio, and user-defined template content.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, "Microsoft.FluentUI.AspNetCore.Components.HierarchicalSelectColumn`1", "Microsoft.FluentUI.AspNetCore.Components")>] () = inherit HierarchicalSelectColumnBuilder<Microsoft.FluentUI.AspNetCore.Components.HierarchicalSelectColumn<'TGridItem>, 'TGridItem>()

    /// Represents a FluentDataGrid`1 column whose cells render a supplied template.
    type TemplateColumn'<'TGridItem> 
        /// Represents a FluentDataGrid`1 column whose cells render a supplied template.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, "Microsoft.FluentUI.AspNetCore.Components.TemplateColumn`1", "Microsoft.FluentUI.AspNetCore.Components")>] () = inherit TemplateColumnBuilder<Microsoft.FluentUI.AspNetCore.Components.TemplateColumn<'TGridItem>, 'TGridItem>()

    /// Provides accessible column reorder actions for a FluentDataGrid`1 column.
    type ColumnReorderOptions'<'TGridItem> 
        /// Provides accessible column reorder actions for a FluentDataGrid`1 column.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, "Microsoft.FluentUI.AspNetCore.Components.ColumnReorderOptions`1", "Microsoft.FluentUI.AspNetCore.Components")>] () = inherit ColumnReorderOptionsBuilder<Microsoft.FluentUI.AspNetCore.Components.ColumnReorderOptions<'TGridItem>, 'TGridItem>()

    /// Provides options for resizing a column in a FluentDataGrid`1.
    type ColumnResizeOptions'<'TGridItem> 
        /// Provides options for resizing a column in a FluentDataGrid`1.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, "Microsoft.FluentUI.AspNetCore.Components.ColumnResizeOptions`1", "Microsoft.FluentUI.AspNetCore.Components")>] () = inherit ColumnResizeOptionsBuilder<Microsoft.FluentUI.AspNetCore.Components.ColumnResizeOptions<'TGridItem>, 'TGridItem>()

    /// Renders the multi-column sort actions for one FluentDataGrid`1 column as menu items.
    /// Used by the column header menu and by the column header popup, so that both offer the same actions.
    type ColumnSortMenuItems'<'TGridItem> 
        /// Renders the multi-column sort actions for one FluentDataGrid`1 column as menu items.
        /// Used by the column header menu and by the column header popup, so that both offer the same actions.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, "Microsoft.FluentUI.AspNetCore.Components.ColumnSortMenuItems`1", "Microsoft.FluentUI.AspNetCore.Components")>] () = inherit ColumnSortMenuItemsBuilder<Microsoft.FluentUI.AspNetCore.Components.ColumnSortMenuItems<'TGridItem>, 'TGridItem>()

    /// Holds the multi-column sort actions of a FluentDataGrid`1 column in the column header
    /// popup, for grids that do not use HeaderCellAsButtonWithMenu and therefore
    /// have no header menu to put them in.
    type ColumnSortOptions'<'TGridItem> 
        /// Holds the multi-column sort actions of a FluentDataGrid`1 column in the column header
        /// popup, for grids that do not use HeaderCellAsButtonWithMenu and therefore
        /// have no header menu to put them in.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, "Microsoft.FluentUI.AspNetCore.Components.ColumnSortOptions`1", "Microsoft.FluentUI.AspNetCore.Components")>] () = inherit ColumnSortOptionsBuilder<Microsoft.FluentUI.AspNetCore.Components.ColumnSortOptions<'TGridItem>, 'TGridItem>()
    type FluentDialogInstance' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, "Microsoft.FluentUI.AspNetCore.Components.FluentDialogInstance", "Microsoft.FluentUI.AspNetCore.Components")>] () = inherit FluentDialogInstanceBuilder<Microsoft.FluentUI.AspNetCore.Components.FluentDialogInstance>()
    type FluentKeyCodeProvider' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, "Microsoft.FluentUI.AspNetCore.Components.FluentKeyCodeProvider", "Microsoft.FluentUI.AspNetCore.Components")>] () = inherit FluentKeyCodeProviderBuilder<Microsoft.FluentUI.AspNetCore.Components.FluentKeyCodeProvider>()

    /// A component that automatically registers an EditContext with a parent FluentWizardStep
    /// for validation when navigating between wizard steps.
    /// Place this component inside an EditForm within a FluentWizardStep.
    type FluentWizardStepValidator' 
        /// A component that automatically registers an EditContext with a parent FluentWizardStep
        /// for validation when navigating between wizard steps.
        /// Place this component inside an EditForm within a FluentWizardStep.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, "Microsoft.FluentUI.AspNetCore.Components.FluentWizardStepValidator", "Microsoft.FluentUI.AspNetCore.Components")>] () = inherit FluentWizardStepValidatorBuilder<Microsoft.FluentUI.AspNetCore.Components.FluentWizardStepValidator>()

[<AutoOpen>]
module DslCEInstances =
  
    open System.Diagnostics.CodeAnalysis
    open Microsoft.FluentUI.AspNetCore.Components.DslInternals

    let FluentComponentBase'' = FluentComponentBase'()
    let FluentBadge'' = FluentBadge'()
    let FluentCounterBadge'' = FluentCounterBadge'()
    let FluentButton'' = FluentButton'()
    let FluentMenuButton'' = FluentMenuButton'()
    let FluentToggleButton'' = FluentToggleButton'()
    let FluentLabel'' = FluentLabel'()
    let FluentLabelInfo'' = FluentLabelInfo'()
    let FluentNavBase'' = FluentNavBase'()
    let FluentNavCategory'' = FluentNavCategory'()
    let FluentNavItem'' = FluentNavItem'()
    let FluentProgressBar'' = FluentProgressBar'()
    let FluentProgress'' = FluentProgress'()
    let FluentSpinner'' = FluentSpinner'()
    let FluentProgressRing'' = FluentProgressRing'()
    let FluentAccordion'' = FluentAccordion'()
    let FluentAccordionItem'' = FluentAccordionItem'()
    let FluentAppBar'' = FluentAppBar'()
    let FluentAppBarItem'' = FluentAppBarItem'()
    let FluentAvatar'' = FluentAvatar'()
    let FluentPresenceBadge'' = FluentPresenceBadge'()
    let FluentAnchorButton'' = FluentAnchorButton'()
    let FluentCompoundButton'' = FluentCompoundButton'()
    let FluentSplitButton'' = FluentSplitButton'()
    let FluentCard'' = FluentCard'()
    let FluentColorPicker'' = FluentColorPicker'()
    let FluentDataGrid''<'TGridItem> = FluentDataGrid'<'TGridItem>()
    let FluentDataGridCell''<'TGridItem> = FluentDataGridCell'<'TGridItem>()
    let FluentDataGridRow''<'TGridItem> = FluentDataGridRow'<'TGridItem>()
    let FluentDialog'' = FluentDialog'()
    let FluentDialogBody'' = FluentDialogBody'()
    let FluentDialogProvider'' = FluentDialogProvider'()
    let FluentDivider'' = FluentDivider'()
    let FluentDragContainer''<'TItem> = FluentDragContainer'<'TItem>()
    let FluentDropZone''<'TItem> = FluentDropZone'<'TItem>()
    let FluentEmoji''<'Emoji when 'Emoji : (new : unit -> 'Emoji) and 'Emoji :> Microsoft.FluentUI.AspNetCore.Components.Emoji> = FluentEmoji'<'Emoji>()
    let FluentErrorBoundary'' = FluentErrorBoundary'()
    let FluentField'' = FluentField'()
    let FluentValidationMessage''<'TValue> = FluentValidationMessage'<'TValue>()
    let FluentGrid'' = FluentGrid'()
    let FluentGridItem'' = FluentGridItem'()
    let FluentHighlighter'' = FluentHighlighter'()
    let FluentIcon''<'Icon when 'Icon : (new : unit -> 'Icon) and 'Icon :> Microsoft.FluentUI.AspNetCore.Components.Icon> = FluentIcon'<'Icon>()
    let FluentImage'' = FluentImage'()
    let FluentInputFile'' = FluentInputFile'()
    let FluentKeyCode'' = FluentKeyCode'()
    let FluentLayout'' = FluentLayout'()
    let FluentLayoutHamburger'' = FluentLayoutHamburger'()
    let FluentLayoutItem'' = FluentLayoutItem'()
    let FluentLink'' = FluentLink'()
    let FluentOption''<'TValue> = FluentOption'<'TValue>()
    let FluentOptionString'' = FluentOptionString'()
    let FreeOptionOutput'' = FreeOptionOutput'()
    let FluentMenu'' = FluentMenu'()
    let FluentMenuItem'' = FluentMenuItem'()
    let FluentMenuList'' = FluentMenuList'()
    let FluentMessageBar'' = FluentMessageBar'()
    let FluentMessageBarProvider'' = FluentMessageBarProvider'()
    let FluentNav'' = FluentNav'()
    let FluentNavSectionHeader'' = FluentNavSectionHeader'()
    let FluentOverflow''<'TItem> = FluentOverflow'<'TItem>()
    let FluentOverlay'' = FluentOverlay'()
    let FluentPaginator'' = FluentPaginator'()
    let FluentPopover'' = FluentPopover'()
    let FluentPullToRefresh'' = FluentPullToRefresh'()
    let FluentRadio''<'TValue> = FluentRadio'<'TValue>()
    let FluentRatingDisplay'' = FluentRatingDisplay'()
    let FluentSkeleton'' = FluentSkeleton'()
    let FluentSortableList''<'TItem> = FluentSortableList'<'TItem>()
    let FluentSpacer'' = FluentSpacer'()
    let FluentMultiSplitter'' = FluentMultiSplitter'()
    let FluentMultiSplitterPane'' = FluentMultiSplitterPane'()
    let FluentStack'' = FluentStack'()
    let FluentTab'' = FluentTab'()
    let FluentTabs'' = FluentTabs'()
    let FluentText'' = FluentText'()
    let FluentToast'' = FluentToast'()
    let FluentToastProvider'' = FluentToastProvider'()
    let FluentTooltip'' = FluentTooltip'()
    let FluentTooltipProvider'' = FluentTooltipProvider'()
    let FluentTreeItem'' = FluentTreeItem'()
    let FluentTreeView'' = FluentTreeView'()
    let FluentWizard'' = FluentWizard'()
    let FluentWizardStep'' = FluentWizardStep'()
    let FluentProviders'' = FluentProviders'()
    let ValidationSummary'' = ValidationSummary'()
    let FluentValidationSummary'' = FluentValidationSummary'()
    let ColumnBase''<'TGridItem> = ColumnBase'<'TGridItem>()
    let PropertyColumn''<'TGridItem, 'TProp> = PropertyColumn'<'TGridItem, 'TProp>()
    let SelectColumn''<'TGridItem> = SelectColumn'<'TGridItem>()
    let HierarchicalSelectColumn''<'TGridItem> = HierarchicalSelectColumn'<'TGridItem>()
    let TemplateColumn''<'TGridItem> = TemplateColumn'<'TGridItem>()
    let ColumnReorderOptions''<'TGridItem> = ColumnReorderOptions'<'TGridItem>()
    let ColumnResizeOptions''<'TGridItem> = ColumnResizeOptions'<'TGridItem>()
    let ColumnSortMenuItems''<'TGridItem> = ColumnSortMenuItems'<'TGridItem>()
    let ColumnSortOptions''<'TGridItem> = ColumnSortOptions'<'TGridItem>()
    let FluentDialogInstance'' = FluentDialogInstance'()
    let FluentKeyCodeProvider'' = FluentKeyCodeProvider'()
    let FluentWizardStepValidator'' = FluentWizardStepValidator'()
            
namespace Microsoft.FluentUI.AspNetCore.Components.Utilities

[<AutoOpen>]
module DslCE =
  
    open System.Diagnostics.CodeAnalysis
    open Microsoft.FluentUI.AspNetCore.Components.DslInternals.Utilities


    /// Internal component to conditionally render a tag and its content.
    type AddTag' 
        /// Internal component to conditionally render a tag and its content.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, "Microsoft.FluentUI.AspNetCore.Components.Utilities.AddTag", "Microsoft.FluentUI.AspNetCore.Components")>] () = inherit AddTagBuilder<Microsoft.FluentUI.AspNetCore.Components.Utilities.AddTag>()

[<AutoOpen>]
module DslCEInstances =
  
    open System.Diagnostics.CodeAnalysis
    open Microsoft.FluentUI.AspNetCore.Components.DslInternals.Utilities

    let AddTag'' = AddTag'()
            
namespace Microsoft.FluentUI.AspNetCore.Components.Dialog.MessageBox

[<AutoOpen>]
module DslCE =
  
    open System.Diagnostics.CodeAnalysis
    open Microsoft.FluentUI.AspNetCore.Components.DslInternals.Dialog.MessageBox


    /// Represents a message box dialog.
    type FluentMessageBox' 
        /// Represents a message box dialog.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, "Microsoft.FluentUI.AspNetCore.Components.Dialog.MessageBox.FluentMessageBox", "Microsoft.FluentUI.AspNetCore.Components")>] () = inherit FluentMessageBoxBuilder<Microsoft.FluentUI.AspNetCore.Components.Dialog.MessageBox.FluentMessageBox>()

[<AutoOpen>]
module DslCEInstances =
  
    open System.Diagnostics.CodeAnalysis
    open Microsoft.FluentUI.AspNetCore.Components.DslInternals.Dialog.MessageBox

    let FluentMessageBox'' = FluentMessageBox'()
            
namespace Microsoft.FluentUI.AspNetCore.Components.DataGrid.Infrastructure

[<AutoOpen>]
module DslCE =
  
    open System.Diagnostics.CodeAnalysis
    open Microsoft.FluentUI.AspNetCore.Components.DslInternals.DataGrid.Infrastructure


    /// For internal use only. Do not use.
    type Defer' 
        /// For internal use only. Do not use.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, "Microsoft.FluentUI.AspNetCore.Components.DataGrid.Infrastructure.Defer", "Microsoft.FluentUI.AspNetCore.Components")>] () = inherit DeferBuilder<Microsoft.FluentUI.AspNetCore.Components.DataGrid.Infrastructure.Defer>()

[<AutoOpen>]
module DslCEInstances =
  
    open System.Diagnostics.CodeAnalysis
    open Microsoft.FluentUI.AspNetCore.Components.DslInternals.DataGrid.Infrastructure

    let Defer'' = Defer'()
            