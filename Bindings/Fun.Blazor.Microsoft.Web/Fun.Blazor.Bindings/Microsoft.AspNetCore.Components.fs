namespace rec Microsoft.AspNetCore.Components.DslInternals

open System.Threading.Tasks
open FSharp.Data.Adaptive
open Fun.Blazor
open Fun.Blazor.Operators
open Microsoft.AspNetCore.Components.DslInternals

/// A base class for error boundary components.
type ErrorBoundaryBaseBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAndChildAttrBuilder<'FunBlazorGeneric>()
    /// The content to be displayed when there is an error.
    [<CustomOperation("ErrorContent")>] member inline _.ErrorContent ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Exception -> NodeRenderFragment) = render ==> html.renderFragment("ErrorContent", fn)
    /// The maximum number of errors that can be handled. If more errors are received,
    /// they will be treated as fatal. Calling Recover resets the count.
    [<CustomOperation("MaximumErrorCount")>] member inline _.MaximumErrorCount ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("MaximumErrorCount" => x)

            
namespace rec Microsoft.AspNetCore.Components.DslInternals.Web

open System.Threading.Tasks
open FSharp.Data.Adaptive
open Fun.Blazor
open Fun.Blazor.Operators
open Microsoft.AspNetCore.Components.DslInternals

/// Captures errors thrown from its child content.
type ErrorBoundaryBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ErrorBoundaryBaseBuilder<'FunBlazorGeneric>()


            
namespace rec Microsoft.AspNetCore.Components.DslInternals.Routing

open System.Threading.Tasks
open FSharp.Data.Adaptive
open Fun.Blazor
open Fun.Blazor.Operators
open Microsoft.AspNetCore.Components.DslInternals

/// After navigating from one page to another, sets focus to an element
/// matching a CSS selector. This can be used to build an accessible
/// navigation system compatible with screen readers.
type FocusOnNavigateBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAndChildAttrBuilder<'FunBlazorGeneric>()
    /// Gets or sets the route data. This can be obtained from an enclosing
    /// Router component.
    [<CustomOperation("RouteData")>] member inline _.RouteData ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.AspNetCore.Components.RouteData) = render ==> ("RouteData" => x)
    /// Gets or sets a CSS selector describing the element to be focused after
    /// navigation between pages.
    [<CustomOperation("Selector")>] member inline _.Selector ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Selector" => x)

/// A component that renders an anchor tag, automatically toggling its 'active'
/// class based on whether its 'href' matches the current URI.
type NavLinkBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAndChildAttrBuilder<'FunBlazorGeneric>()
    /// Gets or sets the CSS class name applied to the NavLink when the
    /// current route matches the NavLink href.
    [<CustomOperation("ActiveClass")>] member inline _.ActiveClass ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("ActiveClass" => x)
    /// Gets or sets a collection of additional attributes that will be added to the generated
    /// a element.
    [<CustomOperation("AdditionalAttributes")>] member inline _.AdditionalAttributes ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.IReadOnlyDictionary<System.String, System.Object>) = render ==> ("AdditionalAttributes" => x)
    /// Gets or sets a value representing the URL matching behavior.
    [<CustomOperation("Match")>] member inline _.Match ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.AspNetCore.Components.Routing.NavLinkMatch) = render ==> ("Match" => x)

            
namespace rec Microsoft.AspNetCore.Components.DslInternals.Web

open System.Threading.Tasks
open FSharp.Data.Adaptive
open Fun.Blazor
open Fun.Blazor.Operators
open Microsoft.AspNetCore.Components.DslInternals

/// Provides content to HeadOutlet components.
type HeadContentBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAndChildAttrBuilder<'FunBlazorGeneric>()


/// Renders content provided by HeadContent components.
type HeadOutletBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAndChildAttrBuilder<'FunBlazorGeneric>()


/// Enables rendering an HTML <title> to a HeadOutlet component.
type PageTitleBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAndChildAttrBuilder<'FunBlazorGeneric>()


            
namespace rec Microsoft.AspNetCore.Components.DslInternals.Web.Virtualization

open System.Threading.Tasks
open FSharp.Data.Adaptive
open Fun.Blazor
open Fun.Blazor.Operators
open Microsoft.AspNetCore.Components.DslInternals

/// Provides functionality for rendering a virtualized list of items.
type VirtualizeBuilder<'FunBlazorGeneric, 'TItem when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAttrBuilder<'FunBlazorGeneric>()
    /// Gets or sets the item template for the list.
    [<CustomOperation("ChildContent")>] member inline _.ChildContent ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: 'TItem -> NodeRenderFragment) = render ==> html.renderFragment("ChildContent", fn)
    /// Gets or sets the item template for the list.
    [<CustomOperation("ItemContent")>] member inline _.ItemContent ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: 'TItem -> NodeRenderFragment) = render ==> html.renderFragment("ItemContent", fn)
    /// Gets or sets the template for items that have not yet been loaded in memory.
    [<CustomOperation("Placeholder")>] member inline _.Placeholder ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.AspNetCore.Components.Web.Virtualization.PlaceholderContext -> NodeRenderFragment) = render ==> html.renderFragment("Placeholder", fn)
    /// Gets or sets the content to show when Items is empty
    /// or when the TotalItemCount is zero.
    [<CustomOperation("EmptyContent")>] member inline _.EmptyContent ([<InlineIfLambda>] render: AttrRenderFragment, fragment: NodeRenderFragment) = render ==> html.renderFragment("EmptyContent", fragment)
    /// Gets or sets the content to show when Items is empty
    /// or when the TotalItemCount is zero.
    [<CustomOperation("EmptyContent")>] member inline _.EmptyContent ([<InlineIfLambda>] render: AttrRenderFragment, fragments: NodeRenderFragment seq) = render ==> html.renderFragment("EmptyContent", fragment { yield! fragments })
    /// Gets or sets the content to show when Items is empty
    /// or when the TotalItemCount is zero.
    [<CustomOperation("EmptyContent")>] member inline _.EmptyContent ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("EmptyContent", html.text x)
    /// Gets or sets the content to show when Items is empty
    /// or when the TotalItemCount is zero.
    [<CustomOperation("EmptyContent")>] member inline _.EmptyContent ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("EmptyContent", html.text x)
    /// Gets or sets the content to show when Items is empty
    /// or when the TotalItemCount is zero.
    [<CustomOperation("EmptyContent")>] member inline _.EmptyContent ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("EmptyContent", html.text x)
    /// Gets the size of each item in pixels. Defaults to 50px.
    [<CustomOperation("ItemSize")>] member inline _.ItemSize ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Single) = render ==> ("ItemSize" => x)
    /// Gets or sets the function providing items to the list.
    [<CustomOperation("ItemsProvider")>] member inline _.ItemsProvider ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.AspNetCore.Components.Web.Virtualization.ItemsProviderDelegate<'TItem>) = render ==> ("ItemsProvider" => x)
    /// Gets or sets the fixed item source.
    [<CustomOperation("Items")>] member inline _.Items ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.ICollection<'TItem>) = render ==> ("Items" => x)
    /// Gets or sets a value that determines how many additional items will be rendered
    /// before and after the visible region. This help to reduce the frequency of rendering
    /// during scrolling. However, higher values mean that more elements will be present
    /// in the page.
    [<CustomOperation("OverscanCount")>] member inline _.OverscanCount ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("OverscanCount" => x)
    /// Gets or sets the tag name of the HTML element that will be used as the virtualization spacer.
    /// One such element will be rendered before the visible items, and one more after them, using
    /// an explicit "height" style to control the scroll range.
    ///             
    /// The default value is "div". If you are placing the Virtualize`1 instance inside
    /// an element that requires a specific child tag name, consider setting that here. For example when
    /// rendering inside a "tbody", consider setting SpacerElement to the value "tr".
    [<CustomOperation("SpacerElement")>] member inline _.SpacerElement ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("SpacerElement" => x)
    /// Gets or sets the maximum number of items that will be rendered, even if the client reports
    /// that its viewport is large enough to show more. The default value is 100.
    ///             
    /// This should only be used as a safeguard against excessive memory usage or large data loads.
    /// Do not set this to a smaller number than you expect to fit on a realistic-sized window, because
    /// that will leave a blank gap below and the user may not be able to see the rest of the content.
    [<CustomOperation("MaxItemCount")>] member inline _.MaxItemCount ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("MaxItemCount" => x)

            
namespace rec Microsoft.AspNetCore.Components.DslInternals.Forms

open System.Threading.Tasks
open FSharp.Data.Adaptive
open Fun.Blazor
open Fun.Blazor.Operators
open Microsoft.AspNetCore.Components.DslInternals

/// Renders a form element that cascades an EditContext to descendants.
type EditFormBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAttrBuilder<'FunBlazorGeneric>()
    /// Gets or sets a collection of additional attributes that will be applied to the created form element.
    [<CustomOperation("AdditionalAttributes")>] member inline _.AdditionalAttributes ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.IReadOnlyDictionary<System.String, System.Object>) = render ==> ("AdditionalAttributes" => x)
    /// Supplies the edit context explicitly. If using this parameter, do not
    /// also supply Model, since the model value will be taken
    /// from the Model property.
    [<CustomOperation("EditContext")>] member inline _.EditContext ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.AspNetCore.Components.Forms.EditContext) = render ==> ("EditContext" => x)
    /// If enabled, form submission is performed without fully reloading the page. This is
    /// equivalent to adding data-enhance to the form.
    ///             
    /// This flag is only relevant in server-side rendering (SSR) scenarios. For interactive
    /// rendering, the flag has no effect since there is no full-page reload on submit anyway.
    [<CustomOperation("Enhance")>] member inline _.Enhance ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Enhance" =>>> true)
    /// If enabled, form submission is performed without fully reloading the page. This is
    /// equivalent to adding data-enhance to the form.
    ///             
    /// This flag is only relevant in server-side rendering (SSR) scenarios. For interactive
    /// rendering, the flag has no effect since there is no full-page reload on submit anyway.
    [<CustomOperation("Enhance")>] member inline _.Enhance ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Enhance" =>>> x)
    /// Specifies the top-level model object for the form. An edit context will
    /// be constructed for this model. If using this parameter, do not also supply
    /// a value for EditContext.
    [<CustomOperation("Model")>] member inline _.Model ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Object) = render ==> ("Model" => x)
    /// Specifies the content to be rendered inside this EditForm.
    [<CustomOperation("ChildContent")>] member inline _.ChildContent ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.AspNetCore.Components.Forms.EditContext -> NodeRenderFragment) = render ==> html.renderFragment("ChildContent", fn)
    /// A callback that will be invoked when the form is submitted.
    ///             
    /// If using this parameter, you are responsible for triggering any validation
    /// manually, e.g., by calling Validate.
    [<CustomOperation("OnSubmit")>] member inline _.OnSubmit ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.AspNetCore.Components.Forms.EditContext -> unit) = render ==> html.callback("OnSubmit", fn)
    /// A callback that will be invoked when the form is submitted.
    ///             
    /// If using this parameter, you are responsible for triggering any validation
    /// manually, e.g., by calling Validate.
    [<CustomOperation("OnSubmit")>] member inline _.OnSubmit ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.AspNetCore.Components.Forms.EditContext -> Task<unit>) = render ==> html.callbackTask("OnSubmit", fn)
    /// A callback that will be invoked when the form is submitted and the
    /// EditContext is determined to be valid.
    [<CustomOperation("OnValidSubmit")>] member inline _.OnValidSubmit ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.AspNetCore.Components.Forms.EditContext -> unit) = render ==> html.callback("OnValidSubmit", fn)
    /// A callback that will be invoked when the form is submitted and the
    /// EditContext is determined to be valid.
    [<CustomOperation("OnValidSubmit")>] member inline _.OnValidSubmit ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.AspNetCore.Components.Forms.EditContext -> Task<unit>) = render ==> html.callbackTask("OnValidSubmit", fn)
    /// A callback that will be invoked when the form is submitted and the
    /// EditContext is determined to be invalid.
    [<CustomOperation("OnInvalidSubmit")>] member inline _.OnInvalidSubmit ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.AspNetCore.Components.Forms.EditContext -> unit) = render ==> html.callback("OnInvalidSubmit", fn)
    /// A callback that will be invoked when the form is submitted and the
    /// EditContext is determined to be invalid.
    [<CustomOperation("OnInvalidSubmit")>] member inline _.OnInvalidSubmit ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.AspNetCore.Components.Forms.EditContext -> Task<unit>) = render ==> html.callbackTask("OnInvalidSubmit", fn)
    /// Gets or sets the form handler name. This is required for posting it to a server-side endpoint.
    /// It is not used during interactive rendering.
    [<CustomOperation("FormName")>] member inline _.FormName ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("FormName" => x)

/// A component used for editing a value of type .
type EditorBuilder<'FunBlazorGeneric, 'T when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAndChildAttrBuilder<'FunBlazorGeneric>()
    /// The value for the component.
    [<CustomOperation("Value")>] member inline _.Value ([<InlineIfLambda>] render: AttrRenderFragment, x: 'T) = render ==> ("Value" => x)
    /// The value for the component.
    [<CustomOperation("Value'")>] member inline _.Value' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: 'T * ('T -> unit)) = render ==> html.bind("Value", valueFn)
    /// An expression that represents the value for the component.
    [<CustomOperation("ValueExpression")>] member inline _.ValueExpression ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Linq.Expressions.Expression<System.Func<'T>>) = render ==> ("ValueExpression" => x)
    /// A callback that gets invoked when the value changes.
    [<CustomOperation("ValueChanged")>] member inline _.ValueChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: 'T -> unit) = render ==> html.callback("ValueChanged", fn)
    /// A callback that gets invoked when the value changes.
    [<CustomOperation("ValueChanged")>] member inline _.ValueChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: 'T -> Task<unit>) = render ==> html.callbackTask("ValueChanged", fn)

/// A base class for form input components. This base class automatically
/// integrates with an EditContext, which must be supplied
/// as a cascading parameter.
type InputBaseBuilder<'FunBlazorGeneric, 'TValue when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAndChildAttrBuilder<'FunBlazorGeneric>()
    /// Gets or sets a collection of additional attributes that will be applied to the created element.
    [<CustomOperation("AdditionalAttributes")>] member inline _.AdditionalAttributes ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.IReadOnlyDictionary<System.String, System.Object>) = render ==> ("AdditionalAttributes" => x)
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
    /// Gets or sets the display name for this field.
    /// This value is used when generating error messages when the input value fails to parse correctly.
    [<CustomOperation("DisplayName")>] member inline _.DisplayName ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("DisplayName" => x)

/// An input component for editing Boolean values.
type InputCheckboxBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit Forms.InputBaseBuilder<'FunBlazorGeneric, System.Boolean>()


/// An input component for editing date values.
/// The supported types for the date value are:
type InputDateBuilder<'FunBlazorGeneric, 'TValue when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit Forms.InputBaseBuilder<'FunBlazorGeneric, 'TValue>()
    /// Gets or sets the type of HTML input to be rendered.
    [<CustomOperation("Type")>] member inline _.Type ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.AspNetCore.Components.Forms.InputDateType) = render ==> ("Type" => x)
    /// Gets or sets the error message used when displaying an a parsing error.
    [<CustomOperation("ParsingErrorMessage")>] member inline _.ParsingErrorMessage ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("ParsingErrorMessage" => x)

/// An input component for editing numeric values.
/// Supported numeric types are Int32, Int64, Int16, Single, Double, Decimal.
type InputNumberBuilder<'FunBlazorGeneric, 'TValue when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit Forms.InputBaseBuilder<'FunBlazorGeneric, 'TValue>()
    /// Gets or sets the error message used when displaying an a parsing error.
    [<CustomOperation("ParsingErrorMessage")>] member inline _.ParsingErrorMessage ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("ParsingErrorMessage" => x)

/// Groups child InputRadio`1 components.
type InputRadioGroupBuilder<'FunBlazorGeneric, 'TValue when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit Forms.InputBaseBuilder<'FunBlazorGeneric, 'TValue>()
    /// Gets or sets the name of the group.
    [<CustomOperation("Name")>] member inline _.Name ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Name" => x)

/// A dropdown selection component.
type InputSelectBuilder<'FunBlazorGeneric, 'TValue when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit Forms.InputBaseBuilder<'FunBlazorGeneric, 'TValue>()


/// An input component for editing String values.
type InputTextBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit Forms.InputBaseBuilder<'FunBlazorGeneric, System.String>()


/// A multiline input component for editing String values.
type InputTextAreaBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit Forms.InputBaseBuilder<'FunBlazorGeneric, System.String>()


/// A component that wraps the HTML file input element and supplies a Stream for each file's contents.
type InputFileBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAndChildAttrBuilder<'FunBlazorGeneric>()
    /// Gets or sets the event callback that will be invoked when the collection of selected files changes.
    [<CustomOperation("OnChange")>] member inline _.OnChange ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.AspNetCore.Components.Forms.InputFileChangeEventArgs -> unit) = render ==> html.callback("OnChange", fn)
    /// Gets or sets the event callback that will be invoked when the collection of selected files changes.
    [<CustomOperation("OnChange")>] member inline _.OnChange ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.AspNetCore.Components.Forms.InputFileChangeEventArgs -> Task<unit>) = render ==> html.callbackTask("OnChange", fn)
    /// Gets or sets a collection of additional attributes that will be applied to the input element.
    [<CustomOperation("AdditionalAttributes")>] member inline _.AdditionalAttributes ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.IDictionary<System.String, System.Object>) = render ==> ("AdditionalAttributes" => x)

/// An input component used for selecting a value from a group of choices.
type InputRadioBuilder<'FunBlazorGeneric, 'TValue when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAndChildAttrBuilder<'FunBlazorGeneric>()
    /// Gets or sets a collection of additional attributes that will be applied to the input element.
    [<CustomOperation("AdditionalAttributes")>] member inline _.AdditionalAttributes ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.IReadOnlyDictionary<System.String, System.Object>) = render ==> ("AdditionalAttributes" => x)
    /// Gets or sets the value of this input.
    [<CustomOperation("Value")>] member inline _.Value ([<InlineIfLambda>] render: AttrRenderFragment, x: 'TValue) = render ==> ("Value" => x)
    /// Gets or sets the name of the parent input radio group.
    [<CustomOperation("Name")>] member inline _.Name ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Name" => x)

/// Displays a list of validation messages for a specified field within a cascaded EditContext.
type ValidationMessageBuilder<'FunBlazorGeneric, 'TValue when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAndChildAttrBuilder<'FunBlazorGeneric>()
    /// Gets or sets a collection of additional attributes that will be applied to the created div element.
    [<CustomOperation("AdditionalAttributes")>] member inline _.AdditionalAttributes ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.IReadOnlyDictionary<System.String, System.Object>) = render ==> ("AdditionalAttributes" => x)
    /// Specifies the field for which validation messages should be displayed.
    [<CustomOperation("For'")>] member inline _.For' ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Linq.Expressions.Expression<System.Func<'TValue>>) = render ==> ("For" => x)

/// Displays a list of validation messages from a cascaded EditContext.
type ValidationSummaryBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAndChildAttrBuilder<'FunBlazorGeneric>()
    /// Gets or sets the model to produce the list of validation messages for.
    /// When specified, this lists all errors that are associated with the model instance.
    [<CustomOperation("Model")>] member inline _.Model ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Object) = render ==> ("Model" => x)
    /// Gets or sets a collection of additional attributes that will be applied to the created ul element.
    [<CustomOperation("AdditionalAttributes")>] member inline _.AdditionalAttributes ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.IReadOnlyDictionary<System.String, System.Object>) = render ==> ("AdditionalAttributes" => x)

            

// =======================================================================================================================

namespace Microsoft.AspNetCore.Components

[<AutoOpen>]
module DslCE =
  
    open System.Diagnostics.CodeAnalysis
    open Microsoft.AspNetCore.Components.DslInternals


    /// A base class for error boundary components.
    type ErrorBoundaryBase' 
        /// A base class for error boundary components.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.AspNetCore.Components.ErrorBoundaryBase>)>] () = inherit ErrorBoundaryBaseBuilder<Microsoft.AspNetCore.Components.ErrorBoundaryBase>()

[<AutoOpen>]
module DslCEInstances =
  
    open System.Diagnostics.CodeAnalysis
    open Microsoft.AspNetCore.Components.DslInternals

    let ErrorBoundaryBase'' = ErrorBoundaryBase'()
            
namespace Microsoft.AspNetCore.Components.Web

[<AutoOpen>]
module DslCE =
  
    open System.Diagnostics.CodeAnalysis
    open Microsoft.AspNetCore.Components.DslInternals.Web


    /// Captures errors thrown from its child content.
    type ErrorBoundary' 
        /// Captures errors thrown from its child content.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.AspNetCore.Components.Web.ErrorBoundary>)>] () = inherit ErrorBoundaryBuilder<Microsoft.AspNetCore.Components.Web.ErrorBoundary>()

    /// Provides content to HeadOutlet components.
    type HeadContent' 
        /// Provides content to HeadOutlet components.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.AspNetCore.Components.Web.HeadContent>)>] () = inherit HeadContentBuilder<Microsoft.AspNetCore.Components.Web.HeadContent>()

    /// Renders content provided by HeadContent components.
    type HeadOutlet' 
        /// Renders content provided by HeadContent components.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.AspNetCore.Components.Web.HeadOutlet>)>] () = inherit HeadOutletBuilder<Microsoft.AspNetCore.Components.Web.HeadOutlet>()

    /// Enables rendering an HTML <title> to a HeadOutlet component.
    type PageTitle' 
        /// Enables rendering an HTML <title> to a HeadOutlet component.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.AspNetCore.Components.Web.PageTitle>)>] () = inherit PageTitleBuilder<Microsoft.AspNetCore.Components.Web.PageTitle>()

[<AutoOpen>]
module DslCEInstances =
  
    open System.Diagnostics.CodeAnalysis
    open Microsoft.AspNetCore.Components.DslInternals.Web

    let ErrorBoundary'' = ErrorBoundary'()
    let HeadContent'' = HeadContent'()
    let HeadOutlet'' = HeadOutlet'()
    let PageTitle'' = PageTitle'()
            
namespace Microsoft.AspNetCore.Components.Routing

[<AutoOpen>]
module DslCE =
  
    open System.Diagnostics.CodeAnalysis
    open Microsoft.AspNetCore.Components.DslInternals.Routing


    /// After navigating from one page to another, sets focus to an element
    /// matching a CSS selector. This can be used to build an accessible
    /// navigation system compatible with screen readers.
    type FocusOnNavigate' 
        /// After navigating from one page to another, sets focus to an element
        /// matching a CSS selector. This can be used to build an accessible
        /// navigation system compatible with screen readers.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.AspNetCore.Components.Routing.FocusOnNavigate>)>] () = inherit FocusOnNavigateBuilder<Microsoft.AspNetCore.Components.Routing.FocusOnNavigate>()

    /// A component that renders an anchor tag, automatically toggling its 'active'
    /// class based on whether its 'href' matches the current URI.
    type NavLink' 
        /// A component that renders an anchor tag, automatically toggling its 'active'
        /// class based on whether its 'href' matches the current URI.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.AspNetCore.Components.Routing.NavLink>)>] () = inherit NavLinkBuilder<Microsoft.AspNetCore.Components.Routing.NavLink>()

[<AutoOpen>]
module DslCEInstances =
  
    open System.Diagnostics.CodeAnalysis
    open Microsoft.AspNetCore.Components.DslInternals.Routing

    let FocusOnNavigate'' = FocusOnNavigate'()
    let NavLink'' = NavLink'()
            
namespace Microsoft.AspNetCore.Components.Web.Virtualization

[<AutoOpen>]
module DslCE =
  
    open System.Diagnostics.CodeAnalysis
    open Microsoft.AspNetCore.Components.DslInternals.Web.Virtualization


    /// Provides functionality for rendering a virtualized list of items.
    type Virtualize'<'TItem> 
        /// Provides functionality for rendering a virtualized list of items.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.AspNetCore.Components.Web.Virtualization.Virtualize<_>>)>] () = inherit VirtualizeBuilder<Microsoft.AspNetCore.Components.Web.Virtualization.Virtualize<'TItem>, 'TItem>()

[<AutoOpen>]
module DslCEInstances =
  
    open System.Diagnostics.CodeAnalysis
    open Microsoft.AspNetCore.Components.DslInternals.Web.Virtualization

    let Virtualize''<'TItem> = Virtualize'<'TItem>()
            
namespace Microsoft.AspNetCore.Components.Forms

[<AutoOpen>]
module DslCE =
  
    open System.Diagnostics.CodeAnalysis
    open Microsoft.AspNetCore.Components.DslInternals.Forms


    /// Renders a form element that cascades an EditContext to descendants.
    type EditForm' 
        /// Renders a form element that cascades an EditContext to descendants.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.AspNetCore.Components.Forms.EditForm>)>] () = inherit EditFormBuilder<Microsoft.AspNetCore.Components.Forms.EditForm>()

    /// A component used for editing a value of type .
    type Editor'<'T> 
        /// A component used for editing a value of type .
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.AspNetCore.Components.Forms.Editor<_>>)>] () = inherit EditorBuilder<Microsoft.AspNetCore.Components.Forms.Editor<'T>, 'T>()

    /// A base class for form input components. This base class automatically
    /// integrates with an EditContext, which must be supplied
    /// as a cascading parameter.
    type InputBase'<'TValue> 
        /// A base class for form input components. This base class automatically
        /// integrates with an EditContext, which must be supplied
        /// as a cascading parameter.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.AspNetCore.Components.Forms.InputBase<_>>)>] () = inherit InputBaseBuilder<Microsoft.AspNetCore.Components.Forms.InputBase<'TValue>, 'TValue>()

    /// An input component for editing Boolean values.
    type InputCheckbox' 
        /// An input component for editing Boolean values.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.AspNetCore.Components.Forms.InputCheckbox>)>] () = inherit InputCheckboxBuilder<Microsoft.AspNetCore.Components.Forms.InputCheckbox>()

    /// An input component for editing date values.
    /// The supported types for the date value are:
    type InputDate'<'TValue> 
        /// An input component for editing date values.
        /// The supported types for the date value are:
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.AspNetCore.Components.Forms.InputDate<_>>)>] () = inherit InputDateBuilder<Microsoft.AspNetCore.Components.Forms.InputDate<'TValue>, 'TValue>()

    /// An input component for editing numeric values.
    /// Supported numeric types are Int32, Int64, Int16, Single, Double, Decimal.
    type InputNumber'<'TValue> 
        /// An input component for editing numeric values.
        /// Supported numeric types are Int32, Int64, Int16, Single, Double, Decimal.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.AspNetCore.Components.Forms.InputNumber<_>>)>] () = inherit InputNumberBuilder<Microsoft.AspNetCore.Components.Forms.InputNumber<'TValue>, 'TValue>()

    /// Groups child InputRadio`1 components.
    type InputRadioGroup'<'TValue> 
        /// Groups child InputRadio`1 components.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.AspNetCore.Components.Forms.InputRadioGroup<_>>)>] () = inherit InputRadioGroupBuilder<Microsoft.AspNetCore.Components.Forms.InputRadioGroup<'TValue>, 'TValue>()

    /// A dropdown selection component.
    type InputSelect'<'TValue> 
        /// A dropdown selection component.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.AspNetCore.Components.Forms.InputSelect<_>>)>] () = inherit InputSelectBuilder<Microsoft.AspNetCore.Components.Forms.InputSelect<'TValue>, 'TValue>()

    /// An input component for editing String values.
    type InputText' 
        /// An input component for editing String values.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.AspNetCore.Components.Forms.InputText>)>] () = inherit InputTextBuilder<Microsoft.AspNetCore.Components.Forms.InputText>()

    /// A multiline input component for editing String values.
    type InputTextArea' 
        /// A multiline input component for editing String values.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.AspNetCore.Components.Forms.InputTextArea>)>] () = inherit InputTextAreaBuilder<Microsoft.AspNetCore.Components.Forms.InputTextArea>()

    /// A component that wraps the HTML file input element and supplies a Stream for each file's contents.
    type InputFile' 
        /// A component that wraps the HTML file input element and supplies a Stream for each file's contents.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.AspNetCore.Components.Forms.InputFile>)>] () = inherit InputFileBuilder<Microsoft.AspNetCore.Components.Forms.InputFile>()

    /// An input component used for selecting a value from a group of choices.
    type InputRadio'<'TValue> 
        /// An input component used for selecting a value from a group of choices.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.AspNetCore.Components.Forms.InputRadio<_>>)>] () = inherit InputRadioBuilder<Microsoft.AspNetCore.Components.Forms.InputRadio<'TValue>, 'TValue>()

    /// Displays a list of validation messages for a specified field within a cascaded EditContext.
    type ValidationMessage'<'TValue> 
        /// Displays a list of validation messages for a specified field within a cascaded EditContext.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.AspNetCore.Components.Forms.ValidationMessage<_>>)>] () = inherit ValidationMessageBuilder<Microsoft.AspNetCore.Components.Forms.ValidationMessage<'TValue>, 'TValue>()

    /// Displays a list of validation messages from a cascaded EditContext.
    type ValidationSummary' 
        /// Displays a list of validation messages from a cascaded EditContext.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.AspNetCore.Components.Forms.ValidationSummary>)>] () = inherit ValidationSummaryBuilder<Microsoft.AspNetCore.Components.Forms.ValidationSummary>()

[<AutoOpen>]
module DslCEInstances =
  
    open System.Diagnostics.CodeAnalysis
    open Microsoft.AspNetCore.Components.DslInternals.Forms

    let EditForm'' = EditForm'()
    let Editor''<'T> = Editor'<'T>()
    let InputBase''<'TValue> = InputBase'<'TValue>()
    let InputCheckbox'' = InputCheckbox'()
    let InputDate''<'TValue> = InputDate'<'TValue>()
    let InputNumber''<'TValue> = InputNumber'<'TValue>()
    let InputRadioGroup''<'TValue> = InputRadioGroup'<'TValue>()
    let InputSelect''<'TValue> = InputSelect'<'TValue>()
    let InputText'' = InputText'()
    let InputTextArea'' = InputTextArea'()
    let InputFile'' = InputFile'()
    let InputRadio''<'TValue> = InputRadio'<'TValue>()
    let ValidationMessage''<'TValue> = ValidationMessage'<'TValue>()
    let ValidationSummary'' = ValidationSummary'()
            