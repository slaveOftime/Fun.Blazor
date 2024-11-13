namespace rec Microsoft.AspNetCore.Components.QuickGrid.DslInternals

open System.Threading.Tasks
open FSharp.Data.Adaptive
open Fun.Blazor
open Fun.Blazor.Operators
open Microsoft.AspNetCore.Components.QuickGrid.DslInternals

/// An abstract base class for columns in a QuickGrid`1.
type ColumnBaseBuilder<'FunBlazorGeneric, 'TGridItem when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAndChildAttrBuilder<'FunBlazorGeneric>()
    /// Title text for the column. This is rendered automatically if HeaderTemplate is not used.
    [<CustomOperation("Title")>] member inline _.Title ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Title" => x)
    /// If specified, controls the justification of table header and body cells for this column.
    [<CustomOperation("Align")>] member inline _.Align ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.AspNetCore.Components.QuickGrid.Align) = render ==> ("Align" => x)
    /// An optional template for this column's header cell. If not specified, the default header template
    /// includes the Title along with any applicable sort indicators and options buttons.
    [<CustomOperation("HeaderTemplate")>] member inline _.HeaderTemplate ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.AspNetCore.Components.QuickGrid.ColumnBase<'TGridItem> -> NodeRenderFragment) = render ==> html.renderFragment("HeaderTemplate", fn)
    /// If specified, indicates that this column has this associated options UI. A button to display this
    /// UI will be included in the header cell by default.
    ///             
    /// If HeaderTemplate is used, it is left up to that template to render any relevant
    /// "show options" UI and invoke the grid's ShowColumnOptionsAsync).
    [<CustomOperation("ColumnOptions")>] member inline _.ColumnOptions ([<InlineIfLambda>] render: AttrRenderFragment, fragment: NodeRenderFragment) = render ==> html.renderFragment("ColumnOptions", fragment)
    /// If specified, indicates that this column has this associated options UI. A button to display this
    /// UI will be included in the header cell by default.
    ///             
    /// If HeaderTemplate is used, it is left up to that template to render any relevant
    /// "show options" UI and invoke the grid's ShowColumnOptionsAsync).
    [<CustomOperation("ColumnOptions")>] member inline _.ColumnOptions ([<InlineIfLambda>] render: AttrRenderFragment, fragments: NodeRenderFragment seq) = render ==> html.renderFragment("ColumnOptions", fragment { yield! fragments })
    /// If specified, indicates that this column has this associated options UI. A button to display this
    /// UI will be included in the header cell by default.
    ///             
    /// If HeaderTemplate is used, it is left up to that template to render any relevant
    /// "show options" UI and invoke the grid's ShowColumnOptionsAsync).
    [<CustomOperation("ColumnOptions")>] member inline _.ColumnOptions ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("ColumnOptions", html.text x)
    /// If specified, indicates that this column has this associated options UI. A button to display this
    /// UI will be included in the header cell by default.
    ///             
    /// If HeaderTemplate is used, it is left up to that template to render any relevant
    /// "show options" UI and invoke the grid's ShowColumnOptionsAsync).
    [<CustomOperation("ColumnOptions")>] member inline _.ColumnOptions ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("ColumnOptions", html.text x)
    /// If specified, indicates that this column has this associated options UI. A button to display this
    /// UI will be included in the header cell by default.
    ///             
    /// If HeaderTemplate is used, it is left up to that template to render any relevant
    /// "show options" UI and invoke the grid's ShowColumnOptionsAsync).
    [<CustomOperation("ColumnOptions")>] member inline _.ColumnOptions ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("ColumnOptions", html.text x)
    /// Indicates whether the data should be sortable by this column.
    ///             
    /// The default value may vary according to the column type (for example, a TemplateColumn`1
    /// is sortable by default if any SortBy parameter is specified).
    [<CustomOperation("Sortable")>] member inline _.Sortable ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Boolean>) = render ==> ("Sortable" => x)
    /// Indicates which direction to sort in
    /// if IsDefaultSortColumn is true.
    [<CustomOperation("InitialSortDirection")>] member inline _.InitialSortDirection ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.AspNetCore.Components.QuickGrid.SortDirection) = render ==> ("InitialSortDirection" => x)
    /// Indicates whether this column should be sorted by default.
    [<CustomOperation("IsDefaultSortColumn")>] member inline _.IsDefaultSortColumn ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("IsDefaultSortColumn" =>>> true)
    /// Indicates whether this column should be sorted by default.
    [<CustomOperation("IsDefaultSortColumn")>] member inline _.IsDefaultSortColumn ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("IsDefaultSortColumn" =>>> x)
    /// If specified, virtualized grids will use this template to render cells whose data has not yet been loaded.
    [<CustomOperation("PlaceholderTemplate")>] member inline _.PlaceholderTemplate ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.AspNetCore.Components.Web.Virtualization.PlaceholderContext -> NodeRenderFragment) = render ==> html.renderFragment("PlaceholderTemplate", fn)

/// Represents a QuickGrid`1 column whose cells display a single value.
type PropertyColumnBuilder<'FunBlazorGeneric, 'TGridItem, 'TProp when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ColumnBaseBuilder<'FunBlazorGeneric, 'TGridItem>()
    /// Defines the value to be displayed in this column's cells.
    [<CustomOperation("Property")>] member inline _.Property ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Linq.Expressions.Expression<System.Func<'TGridItem, 'TProp>>) = render ==> ("Property" => x)
    /// Optionally specifies a format string for the value.
    ///             
    /// Using this requires the  type to implement IFormattable.
    [<CustomOperation("Format")>] member inline _.Format ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Format" => x)

/// Represents a QuickGrid`1 column whose cells render a supplied template.
type TemplateColumnBuilder<'FunBlazorGeneric, 'TGridItem when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ColumnBaseBuilder<'FunBlazorGeneric, 'TGridItem>()
    /// Specifies the content to be rendered for each row in the table.
    [<CustomOperation("ChildContent")>] member inline _.ChildContent ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: 'TGridItem -> NodeRenderFragment) = render ==> html.renderFragment("ChildContent", fn)
    [<CustomOperation("SortBy")>] member inline _.SortBy ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.AspNetCore.Components.QuickGrid.GridSort<'TGridItem>) = render ==> ("SortBy" => x)

/// A component that provides a user interface for PaginationState.
type PaginatorBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAndChildAttrBuilder<'FunBlazorGeneric>()
    /// Specifies the associated PaginationState. This parameter is required.
    [<CustomOperation("State")>] member inline _.State ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.AspNetCore.Components.QuickGrid.PaginationState) = render ==> ("State" => x)
    /// Optionally supplies a template for rendering the page count summary.
    [<CustomOperation("SummaryTemplate")>] member inline _.SummaryTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragment: NodeRenderFragment) = render ==> html.renderFragment("SummaryTemplate", fragment)
    /// Optionally supplies a template for rendering the page count summary.
    [<CustomOperation("SummaryTemplate")>] member inline _.SummaryTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragments: NodeRenderFragment seq) = render ==> html.renderFragment("SummaryTemplate", fragment { yield! fragments })
    /// Optionally supplies a template for rendering the page count summary.
    [<CustomOperation("SummaryTemplate")>] member inline _.SummaryTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("SummaryTemplate", html.text x)
    /// Optionally supplies a template for rendering the page count summary.
    [<CustomOperation("SummaryTemplate")>] member inline _.SummaryTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("SummaryTemplate", html.text x)
    /// Optionally supplies a template for rendering the page count summary.
    [<CustomOperation("SummaryTemplate")>] member inline _.SummaryTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("SummaryTemplate", html.text x)

/// A component that displays a grid.
type QuickGridBuilder<'FunBlazorGeneric, 'TGridItem when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAndChildAttrBuilder<'FunBlazorGeneric>()
    /// A queryable source of data for the grid.
    ///             
    /// This could be in-memory data converted to queryable using the
    /// AsQueryable extension method,
    /// or an EntityFramework DataSet or an IQueryable derived from it.
    ///             
    /// You should supply either Items or ItemsProvider, but not both.
    [<CustomOperation("Items")>] member inline _.Items ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Linq.IQueryable<'TGridItem>) = render ==> ("Items" => x)
    /// A callback that supplies data for the grid.
    ///             
    /// You should supply either Items or ItemsProvider, but not both.
    [<CustomOperation("ItemsProvider")>] member inline _.ItemsProvider ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.AspNetCore.Components.QuickGrid.GridItemsProvider<'TGridItem>) = render ==> ("ItemsProvider" => x)
    /// A theme name, with default value "default". This affects which styling rules match the table.
    [<CustomOperation("Theme")>] member inline _.Theme ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Theme" => x)
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
    /// Optionally defines a value for @key on each rendered row. Typically this should be used to specify a
    /// unique identifier, such as a primary key value, for each data item.
    ///             
    /// This allows the grid to preserve the association between row elements and data items based on their
    /// unique identifiers, even when the TGridItem instances are replaced by new copies (for
    /// example, after a new query against the underlying data store).
    ///             
    /// If not set, the @key will be the TGridItem instance itself.
    [<CustomOperation("ItemKey")>] member inline _.ItemKey ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("ItemKey" => (System.Func<'TGridItem, System.Object>fn))
    /// Optionally links this QuickGrid`1 instance with a PaginationState model,
    /// causing the grid to fetch and render only the current page of data.
    ///             
    /// This is normally used in conjunction with a Paginator component or some other UI logic
    /// that displays and updates the supplied PaginationState instance.
    [<CustomOperation("Pagination")>] member inline _.Pagination ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.AspNetCore.Components.QuickGrid.PaginationState) = render ==> ("Pagination" => x)
    /// Gets or sets a collection of additional attributes that will be applied to the created element.
    [<CustomOperation("AdditionalAttributes")>] member inline _.AdditionalAttributes ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.IReadOnlyDictionary<System.String, System.Object>) = render ==> ("AdditionalAttributes" => x)

            
namespace rec Microsoft.AspNetCore.Components.QuickGrid.DslInternals.Infrastructure

open System.Threading.Tasks
open FSharp.Data.Adaptive
open Fun.Blazor
open Fun.Blazor.Operators
open Microsoft.AspNetCore.Components.QuickGrid.DslInternals

/// For internal use only. Do not use.
type DeferBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAndChildAttrBuilder<'FunBlazorGeneric>()


            

// =======================================================================================================================

namespace Microsoft.AspNetCore.Components.QuickGrid

[<AutoOpen>]
module DslCE =
  
    open System.Diagnostics.CodeAnalysis
    open Microsoft.AspNetCore.Components.QuickGrid.DslInternals


    /// An abstract base class for columns in a QuickGrid`1.
    type ColumnBase'<'TGridItem> 
        /// An abstract base class for columns in a QuickGrid`1.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.AspNetCore.Components.QuickGrid.ColumnBase<_>>)>] () = inherit ColumnBaseBuilder<Microsoft.AspNetCore.Components.QuickGrid.ColumnBase<'TGridItem>, 'TGridItem>()

    /// Represents a QuickGrid`1 column whose cells display a single value.
    type PropertyColumn'<'TGridItem, 'TProp> 
        /// Represents a QuickGrid`1 column whose cells display a single value.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.AspNetCore.Components.QuickGrid.PropertyColumn<_, _>>)>] () = inherit PropertyColumnBuilder<Microsoft.AspNetCore.Components.QuickGrid.PropertyColumn<'TGridItem, 'TProp>, 'TGridItem, 'TProp>()

    /// Represents a QuickGrid`1 column whose cells render a supplied template.
    type TemplateColumn'<'TGridItem> 
        /// Represents a QuickGrid`1 column whose cells render a supplied template.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.AspNetCore.Components.QuickGrid.TemplateColumn<_>>)>] () = inherit TemplateColumnBuilder<Microsoft.AspNetCore.Components.QuickGrid.TemplateColumn<'TGridItem>, 'TGridItem>()

    /// A component that provides a user interface for PaginationState.
    type Paginator' 
        /// A component that provides a user interface for PaginationState.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.AspNetCore.Components.QuickGrid.Paginator>)>] () = inherit PaginatorBuilder<Microsoft.AspNetCore.Components.QuickGrid.Paginator>()

    /// A component that displays a grid.
    type QuickGrid'<'TGridItem> 
        /// A component that displays a grid.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.AspNetCore.Components.QuickGrid.QuickGrid<_>>)>] () = inherit QuickGridBuilder<Microsoft.AspNetCore.Components.QuickGrid.QuickGrid<'TGridItem>, 'TGridItem>()

[<AutoOpen>]
module DslCEInstances =
  
    open System.Diagnostics.CodeAnalysis
    open Microsoft.AspNetCore.Components.QuickGrid.DslInternals

    let ColumnBase''<'TGridItem> = ColumnBase'<'TGridItem>()
    let PropertyColumn''<'TGridItem, 'TProp> = PropertyColumn'<'TGridItem, 'TProp>()
    let TemplateColumn''<'TGridItem> = TemplateColumn'<'TGridItem>()
    let Paginator'' = Paginator'()
    let QuickGrid''<'TGridItem> = QuickGrid'<'TGridItem>()
            
namespace Microsoft.AspNetCore.Components.QuickGrid.Infrastructure

[<AutoOpen>]
module DslCE =
  
    open System.Diagnostics.CodeAnalysis
    open Microsoft.AspNetCore.Components.QuickGrid.DslInternals.Infrastructure


    /// For internal use only. Do not use.
    type Defer' 
        /// For internal use only. Do not use.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.AspNetCore.Components.QuickGrid.Infrastructure.Defer>)>] () = inherit DeferBuilder<Microsoft.AspNetCore.Components.QuickGrid.Infrastructure.Defer>()

[<AutoOpen>]
module DslCEInstances =
  
    open System.Diagnostics.CodeAnalysis
    open Microsoft.AspNetCore.Components.QuickGrid.DslInternals.Infrastructure

    let Defer'' = Defer'()
            