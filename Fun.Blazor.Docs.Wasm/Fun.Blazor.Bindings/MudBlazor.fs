namespace rec MudBlazor.DslInternals

open FSharp.Data.Adaptive
open Fun.Blazor
open Fun.Blazor.Operators
open MudBlazor.DslInternals


type MudComponentBaseBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAttrBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Classes")>] member inline _.Classes (render: AttrRenderFragment, x: string list) = render ==> html.classes x
    [<CustomOperation("Styles")>] member inline _.Styles (render: AttrRenderFragment, x: (string * string) list) = render ==> html.styles x
    [<CustomOperation("Tag")>] member inline _.Tag (render: AttrRenderFragment, x: System.Object) = render ==> ("Tag" => x)
    [<CustomOperation("UserAttributes")>] member inline _.UserAttributes (render: AttrRenderFragment, x: System.Collections.Generic.Dictionary<System.String, System.Object>) = render ==> ("UserAttributes" => x)
                

type MudBaseButtonBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("HtmlTag")>] member inline _.HtmlTag (render: AttrRenderFragment, x: System.String) = render ==> ("HtmlTag" => x)
    [<CustomOperation("ButtonType")>] member inline _.ButtonType (render: AttrRenderFragment, x: MudBlazor.ButtonType) = render ==> ("ButtonType" => x)
    [<CustomOperation("Link")>] member inline _.Link (render: AttrRenderFragment, x: System.String) = render ==> ("Link" => x)
    [<CustomOperation("Target")>] member inline _.Target (render: AttrRenderFragment, x: System.String) = render ==> ("Target" => x)
    [<CustomOperation("Disabled")>] member inline _.Disabled (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Disabled" => x)
    [<CustomOperation("DisableElevation")>] member inline _.DisableElevation (render: AttrRenderFragment, x: System.Boolean) = render ==> ("DisableElevation" => x)
    [<CustomOperation("DisableRipple")>] member inline _.DisableRipple (render: AttrRenderFragment, x: System.Boolean) = render ==> ("DisableRipple" => x)
    [<CustomOperation("Command")>] member inline _.Command (render: AttrRenderFragment, x: System.Windows.Input.ICommand) = render ==> ("Command" => x)
    [<CustomOperation("CommandParameter")>] member inline _.CommandParameter (render: AttrRenderFragment, x: System.Object) = render ==> ("CommandParameter" => x)
    [<CustomOperation("OnClick")>] member inline _.OnClick (render: AttrRenderFragment, fn) = render ==> html.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>("OnClick", fn)
                

type MudButtonBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudBaseButtonBuilder<'FunBlazorGeneric>()
    [<CustomOperation("StartIcon")>] member inline _.StartIcon (render: AttrRenderFragment, x: System.String) = render ==> ("StartIcon" => x)
    [<CustomOperation("EndIcon")>] member inline _.EndIcon (render: AttrRenderFragment, x: System.String) = render ==> ("EndIcon" => x)
    [<CustomOperation("IconColor")>] member inline _.IconColor (render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("IconColor" => x)
    [<CustomOperation("IconClass")>] member inline _.IconClass (render: AttrRenderFragment, x: System.String) = render ==> ("IconClass" => x)
    [<CustomOperation("Color")>] member inline _.Color (render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("Color" => x)
    [<CustomOperation("Size")>] member inline _.Size (render: AttrRenderFragment, x: MudBlazor.Size) = render ==> ("Size" => x)
    [<CustomOperation("Variant")>] member inline _.Variant (render: AttrRenderFragment, x: MudBlazor.Variant) = render ==> ("Variant" => x)
    [<CustomOperation("FullWidth")>] member inline _.FullWidth (render: AttrRenderFragment, x: System.Boolean) = render ==> ("FullWidth" => x)
                

type MudFabBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudBaseButtonBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Color")>] member inline _.Color (render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("Color" => x)
    [<CustomOperation("Size")>] member inline _.Size (render: AttrRenderFragment, x: MudBlazor.Size) = render ==> ("Size" => x)
    [<CustomOperation("Icon")>] member inline _.Icon (render: AttrRenderFragment, x: System.String) = render ==> ("Icon" => x)
    [<CustomOperation("StartIcon")>] member inline _.StartIcon (render: AttrRenderFragment, x: System.String) = render ==> ("StartIcon" => x)
    [<CustomOperation("EndIcon")>] member inline _.EndIcon (render: AttrRenderFragment, x: System.String) = render ==> ("EndIcon" => x)
    [<CustomOperation("IconColor")>] member inline _.IconColor (render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("IconColor" => x)
    [<CustomOperation("IconSize")>] member inline _.IconSize (render: AttrRenderFragment, x: MudBlazor.Size) = render ==> ("IconSize" => x)
    [<CustomOperation("Label")>] member inline _.Label (render: AttrRenderFragment, x: System.String) = render ==> ("Label" => x)
                

type MudIconButtonBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudBaseButtonBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Icon")>] member inline _.Icon (render: AttrRenderFragment, x: System.String) = render ==> ("Icon" => x)
    [<CustomOperation("Title")>] member inline _.Title (render: AttrRenderFragment, x: System.String) = render ==> ("Title" => x)
    [<CustomOperation("Color")>] member inline _.Color (render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("Color" => x)
    [<CustomOperation("Size")>] member inline _.Size (render: AttrRenderFragment, x: MudBlazor.Size) = render ==> ("Size" => x)
    [<CustomOperation("Edge")>] member inline _.Edge (render: AttrRenderFragment, x: MudBlazor.Edge) = render ==> ("Edge" => x)
    [<CustomOperation("Variant")>] member inline _.Variant (render: AttrRenderFragment, x: MudBlazor.Variant) = render ==> ("Variant" => x)
                

type MudFileUploaderBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudBaseButtonBuilder<'FunBlazorGeneric>()

                

type MudDrawerContainerBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()

                

type MudLayoutBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudDrawerContainerBuilder<'FunBlazorGeneric>()

                

type MudBaseSelectItemBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Disabled")>] member inline _.Disabled (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Disabled" => x)
    [<CustomOperation("DisableRipple")>] member inline _.DisableRipple (render: AttrRenderFragment, x: System.Boolean) = render ==> ("DisableRipple" => x)
    [<CustomOperation("Href")>] member inline _.Href (render: AttrRenderFragment, x: System.String) = render ==> ("Href" => x)
    [<CustomOperation("ForceLoad")>] member inline _.ForceLoad (render: AttrRenderFragment, x: System.Boolean) = render ==> ("ForceLoad" => x)
    [<CustomOperation("CommandParameter")>] member inline _.CommandParameter (render: AttrRenderFragment, x: System.Object) = render ==> ("CommandParameter" => x)
    [<CustomOperation("Command")>] member inline _.Command (render: AttrRenderFragment, x: System.Windows.Input.ICommand) = render ==> ("Command" => x)
    [<CustomOperation("OnClick")>] member inline _.OnClick (render: AttrRenderFragment, fn) = render ==> html.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>("OnClick", fn)
                

type MudNavLinkBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudBaseSelectItemBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Icon")>] member inline _.Icon (render: AttrRenderFragment, x: System.String) = render ==> ("Icon" => x)
    [<CustomOperation("IconColor")>] member inline _.IconColor (render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("IconColor" => x)
    [<CustomOperation("Match")>] member inline _.Match (render: AttrRenderFragment, x: Microsoft.AspNetCore.Components.Routing.NavLinkMatch) = render ==> ("Match" => x)
    [<CustomOperation("Target")>] member inline _.Target (render: AttrRenderFragment, x: System.String) = render ==> ("Target" => x)
                

type MudSelectItemBuilder<'FunBlazorGeneric, 'T when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudBaseSelectItemBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Value")>] member inline _.Value (render: AttrRenderFragment, x: 'T) = render ==> ("Value" => x)
                

type MudTableBaseBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("IsEditRowSwitchingBlocked")>] member inline _.IsEditRowSwitchingBlocked (render: AttrRenderFragment, x: System.Boolean) = render ==> ("IsEditRowSwitchingBlocked" => x)
    [<CustomOperation("Elevation")>] member inline _.Elevation (render: AttrRenderFragment, x: System.Int32) = render ==> ("Elevation" => x)
    [<CustomOperation("Square")>] member inline _.Square (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Square" => x)
    [<CustomOperation("Outlined")>] member inline _.Outlined (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Outlined" => x)
    [<CustomOperation("Bordered")>] member inline _.Bordered (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Bordered" => x)
    [<CustomOperation("Dense")>] member inline _.Dense (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Dense" => x)
    [<CustomOperation("Hover")>] member inline _.Hover (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Hover" => x)
    [<CustomOperation("Striped")>] member inline _.Striped (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Striped" => x)
    [<CustomOperation("Breakpoint")>] member inline _.Breakpoint (render: AttrRenderFragment, x: MudBlazor.Breakpoint) = render ==> ("Breakpoint" => x)
    [<CustomOperation("FixedHeader")>] member inline _.FixedHeader (render: AttrRenderFragment, x: System.Boolean) = render ==> ("FixedHeader" => x)
    [<CustomOperation("FixedFooter")>] member inline _.FixedFooter (render: AttrRenderFragment, x: System.Boolean) = render ==> ("FixedFooter" => x)
    [<CustomOperation("Height")>] member inline _.Height (render: AttrRenderFragment, x: System.String) = render ==> ("Height" => x)
    [<CustomOperation("SortLabel")>] member inline _.SortLabel (render: AttrRenderFragment, x: System.String) = render ==> ("SortLabel" => x)
    [<CustomOperation("AllowUnsorted")>] member inline _.AllowUnsorted (render: AttrRenderFragment, x: System.Boolean) = render ==> ("AllowUnsorted" => x)
    [<CustomOperation("RowsPerPage")>] member inline _.RowsPerPage (render: AttrRenderFragment, x: System.Int32) = render ==> ("RowsPerPage" => x)
    [<CustomOperation("RowsPerPage'")>] member inline _.RowsPerPage' (render: AttrRenderFragment, value: IStore<System.Int32>) = render ==> html.bind("RowsPerPage", value)
    [<CustomOperation("RowsPerPage'")>] member inline _.RowsPerPage' (render: AttrRenderFragment, value: cval<System.Int32>) = render ==> html.bind("RowsPerPage", value)
    [<CustomOperation("RowsPerPage'")>] member inline _.RowsPerPage' (render: AttrRenderFragment, valueFn: System.Int32 * (System.Int32 -> unit)) = render ==> html.bind("RowsPerPage", valueFn)
    [<CustomOperation("RowsPerPageChanged")>] member inline _.RowsPerPageChanged (render: AttrRenderFragment, fn) = render ==> html.callback<System.Int32>("RowsPerPageChanged", fn)
    [<CustomOperation("CurrentPage")>] member inline _.CurrentPage (render: AttrRenderFragment, x: System.Int32) = render ==> ("CurrentPage" => x)
    [<CustomOperation("MultiSelection")>] member inline _.MultiSelection (render: AttrRenderFragment, x: System.Boolean) = render ==> ("MultiSelection" => x)
    [<CustomOperation("ToolBarContent")>] member inline _.ToolBarContent (render: AttrRenderFragment, fragment) = render ==> html.renderFragment("ToolBarContent", fragment)
    [<CustomOperation("ToolBarContent")>] member inline _.ToolBarContent (render: AttrRenderFragment, x: string) = render ==> html.renderFragment("ToolBarContent", html.text x)
    [<CustomOperation("ToolBarContent")>] member inline _.ToolBarContent (render: AttrRenderFragment, x: int) = render ==> html.renderFragment("ToolBarContent", html.text x)
    [<CustomOperation("ToolBarContent")>] member inline _.ToolBarContent (render: AttrRenderFragment, x: float) = render ==> html.renderFragment("ToolBarContent", html.text x)
    [<CustomOperation("Loading")>] member inline _.Loading (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Loading" => x)
    [<CustomOperation("LoadingProgressColor")>] member inline _.LoadingProgressColor (render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("LoadingProgressColor" => x)
    [<CustomOperation("HeaderContent")>] member inline _.HeaderContent (render: AttrRenderFragment, fragment) = render ==> html.renderFragment("HeaderContent", fragment)
    [<CustomOperation("HeaderContent")>] member inline _.HeaderContent (render: AttrRenderFragment, x: string) = render ==> html.renderFragment("HeaderContent", html.text x)
    [<CustomOperation("HeaderContent")>] member inline _.HeaderContent (render: AttrRenderFragment, x: int) = render ==> html.renderFragment("HeaderContent", html.text x)
    [<CustomOperation("HeaderContent")>] member inline _.HeaderContent (render: AttrRenderFragment, x: float) = render ==> html.renderFragment("HeaderContent", html.text x)
    [<CustomOperation("CustomHeader")>] member inline _.CustomHeader (render: AttrRenderFragment, x: System.Boolean) = render ==> ("CustomHeader" => x)
    [<CustomOperation("HeaderClass")>] member inline _.HeaderClass (render: AttrRenderFragment, x: System.String) = render ==> ("HeaderClass" => x)
    [<CustomOperation("FooterContent")>] member inline _.FooterContent (render: AttrRenderFragment, fragment) = render ==> html.renderFragment("FooterContent", fragment)
    [<CustomOperation("FooterContent")>] member inline _.FooterContent (render: AttrRenderFragment, x: string) = render ==> html.renderFragment("FooterContent", html.text x)
    [<CustomOperation("FooterContent")>] member inline _.FooterContent (render: AttrRenderFragment, x: int) = render ==> html.renderFragment("FooterContent", html.text x)
    [<CustomOperation("FooterContent")>] member inline _.FooterContent (render: AttrRenderFragment, x: float) = render ==> html.renderFragment("FooterContent", html.text x)
    [<CustomOperation("CustomFooter")>] member inline _.CustomFooter (render: AttrRenderFragment, x: System.Boolean) = render ==> ("CustomFooter" => x)
    [<CustomOperation("FooterClass")>] member inline _.FooterClass (render: AttrRenderFragment, x: System.String) = render ==> ("FooterClass" => x)
    [<CustomOperation("ColGroup")>] member inline _.ColGroup (render: AttrRenderFragment, fragment) = render ==> html.renderFragment("ColGroup", fragment)
    [<CustomOperation("ColGroup")>] member inline _.ColGroup (render: AttrRenderFragment, x: string) = render ==> html.renderFragment("ColGroup", html.text x)
    [<CustomOperation("ColGroup")>] member inline _.ColGroup (render: AttrRenderFragment, x: int) = render ==> html.renderFragment("ColGroup", html.text x)
    [<CustomOperation("ColGroup")>] member inline _.ColGroup (render: AttrRenderFragment, x: float) = render ==> html.renderFragment("ColGroup", html.text x)
    [<CustomOperation("PagerContent")>] member inline _.PagerContent (render: AttrRenderFragment, fragment) = render ==> html.renderFragment("PagerContent", fragment)
    [<CustomOperation("PagerContent")>] member inline _.PagerContent (render: AttrRenderFragment, x: string) = render ==> html.renderFragment("PagerContent", html.text x)
    [<CustomOperation("PagerContent")>] member inline _.PagerContent (render: AttrRenderFragment, x: int) = render ==> html.renderFragment("PagerContent", html.text x)
    [<CustomOperation("PagerContent")>] member inline _.PagerContent (render: AttrRenderFragment, x: float) = render ==> html.renderFragment("PagerContent", html.text x)
    [<CustomOperation("ReadOnly")>] member inline _.ReadOnly (render: AttrRenderFragment, x: System.Boolean) = render ==> ("ReadOnly" => x)
    [<CustomOperation("OnCommitEditClick")>] member inline _.OnCommitEditClick (render: AttrRenderFragment, fn) = render ==> html.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>("OnCommitEditClick", fn)
    [<CustomOperation("OnCancelEditClick")>] member inline _.OnCancelEditClick (render: AttrRenderFragment, fn) = render ==> html.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>("OnCancelEditClick", fn)
    [<CustomOperation("OnPreviewEditClick")>] member inline _.OnPreviewEditClick (render: AttrRenderFragment, fn) = render ==> html.callback<System.Object>("OnPreviewEditClick", fn)
    [<CustomOperation("CommitEditCommand")>] member inline _.CommitEditCommand (render: AttrRenderFragment, x: System.Windows.Input.ICommand) = render ==> ("CommitEditCommand" => x)
    [<CustomOperation("CommitEditCommandParameter")>] member inline _.CommitEditCommandParameter (render: AttrRenderFragment, x: System.Object) = render ==> ("CommitEditCommandParameter" => x)
    [<CustomOperation("CommitEditTooltip")>] member inline _.CommitEditTooltip (render: AttrRenderFragment, x: System.String) = render ==> ("CommitEditTooltip" => x)
    [<CustomOperation("CancelEditTooltip")>] member inline _.CancelEditTooltip (render: AttrRenderFragment, x: System.String) = render ==> ("CancelEditTooltip" => x)
    [<CustomOperation("CommitEditIcon")>] member inline _.CommitEditIcon (render: AttrRenderFragment, x: System.String) = render ==> ("CommitEditIcon" => x)
    [<CustomOperation("CancelEditIcon")>] member inline _.CancelEditIcon (render: AttrRenderFragment, x: System.String) = render ==> ("CancelEditIcon" => x)
    [<CustomOperation("CanCancelEdit")>] member inline _.CanCancelEdit (render: AttrRenderFragment, x: System.Boolean) = render ==> ("CanCancelEdit" => x)
    [<CustomOperation("RowEditPreview")>] member inline _.RowEditPreview (render: AttrRenderFragment, fn) = render ==> ("RowEditPreview" => (System.Action<System.Object>fn))
    [<CustomOperation("RowEditCommit")>] member inline _.RowEditCommit (render: AttrRenderFragment, fn) = render ==> ("RowEditCommit" => (System.Action<System.Object>fn))
    [<CustomOperation("RowEditCancel")>] member inline _.RowEditCancel (render: AttrRenderFragment, fn) = render ==> ("RowEditCancel" => (System.Action<System.Object>fn))
    [<CustomOperation("TotalItems")>] member inline _.TotalItems (render: AttrRenderFragment, x: System.Int32) = render ==> ("TotalItems" => x)
    [<CustomOperation("RowClass")>] member inline _.RowClass (render: AttrRenderFragment, x: System.String) = render ==> ("RowClass" => x)
    [<CustomOperation("RowStyle")>] member inline _.RowStyle (render: AttrRenderFragment, x: System.String) = render ==> ("RowStyle" => x)
    [<CustomOperation("Virtualize")>] member inline _.Virtualize (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Virtualize" => x)
                

type MudTableBuilder<'FunBlazorGeneric, 'T when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudTableBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("RowTemplate")>] member inline _.RowTemplate (render: AttrRenderFragment, fn: 'T -> NodeRenderFragment) = render ==> html.renderFragment("RowTemplate", fn)
    [<CustomOperation("ChildRowContent")>] member inline _.ChildRowContent (render: AttrRenderFragment, fn: 'T -> NodeRenderFragment) = render ==> html.renderFragment("ChildRowContent", fn)
    [<CustomOperation("RowEditingTemplate")>] member inline _.RowEditingTemplate (render: AttrRenderFragment, fn: 'T -> NodeRenderFragment) = render ==> html.renderFragment("RowEditingTemplate", fn)
    [<CustomOperation("Columns")>] member inline _.Columns (render: AttrRenderFragment, fn: 'T -> NodeRenderFragment) = render ==> html.renderFragment("Columns", fn)
    [<CustomOperation("QuickColumns")>] member inline _.QuickColumns (render: AttrRenderFragment, x: System.String) = render ==> ("QuickColumns" => x)
    [<CustomOperation("NoRecordsContent")>] member inline _.NoRecordsContent (render: AttrRenderFragment, fragment) = render ==> html.renderFragment("NoRecordsContent", fragment)
    [<CustomOperation("NoRecordsContent")>] member inline _.NoRecordsContent (render: AttrRenderFragment, x: string) = render ==> html.renderFragment("NoRecordsContent", html.text x)
    [<CustomOperation("NoRecordsContent")>] member inline _.NoRecordsContent (render: AttrRenderFragment, x: int) = render ==> html.renderFragment("NoRecordsContent", html.text x)
    [<CustomOperation("NoRecordsContent")>] member inline _.NoRecordsContent (render: AttrRenderFragment, x: float) = render ==> html.renderFragment("NoRecordsContent", html.text x)
    [<CustomOperation("LoadingContent")>] member inline _.LoadingContent (render: AttrRenderFragment, fragment) = render ==> html.renderFragment("LoadingContent", fragment)
    [<CustomOperation("LoadingContent")>] member inline _.LoadingContent (render: AttrRenderFragment, x: string) = render ==> html.renderFragment("LoadingContent", html.text x)
    [<CustomOperation("LoadingContent")>] member inline _.LoadingContent (render: AttrRenderFragment, x: int) = render ==> html.renderFragment("LoadingContent", html.text x)
    [<CustomOperation("LoadingContent")>] member inline _.LoadingContent (render: AttrRenderFragment, x: float) = render ==> html.renderFragment("LoadingContent", html.text x)
    [<CustomOperation("HorizontalScrollbar")>] member inline _.HorizontalScrollbar (render: AttrRenderFragment, x: System.Boolean) = render ==> ("HorizontalScrollbar" => x)
    [<CustomOperation("Items")>] member inline _.Items (render: AttrRenderFragment, x: System.Collections.Generic.IEnumerable<'T>) = render ==> ("Items" => x)
    [<CustomOperation("Filter")>] member inline _.Filter (render: AttrRenderFragment, fn) = render ==> ("Filter" => (System.Func<'T, System.Boolean>fn))
    [<CustomOperation("OnRowClick")>] member inline _.OnRowClick (render: AttrRenderFragment, fn) = render ==> html.callback<MudBlazor.TableRowClickEventArgs<'T>>("OnRowClick", fn)
    [<CustomOperation("RowClassFunc")>] member inline _.RowClassFunc (render: AttrRenderFragment, fn) = render ==> ("RowClassFunc" => (System.Func<'T, System.Int32, System.String>fn))
    [<CustomOperation("RowStyleFunc")>] member inline _.RowStyleFunc (render: AttrRenderFragment, fn) = render ==> ("RowStyleFunc" => (System.Func<'T, System.Int32, System.String>fn))
    [<CustomOperation("SelectedItem")>] member inline _.SelectedItem (render: AttrRenderFragment, x: 'T) = render ==> ("SelectedItem" => x)
    [<CustomOperation("SelectedItem'")>] member inline _.SelectedItem' (render: AttrRenderFragment, value: IStore<'T>) = render ==> html.bind("SelectedItem", value)
    [<CustomOperation("SelectedItem'")>] member inline _.SelectedItem' (render: AttrRenderFragment, value: cval<'T>) = render ==> html.bind("SelectedItem", value)
    [<CustomOperation("SelectedItem'")>] member inline _.SelectedItem' (render: AttrRenderFragment, valueFn: 'T * ('T -> unit)) = render ==> html.bind("SelectedItem", valueFn)
    [<CustomOperation("SelectedItemChanged")>] member inline _.SelectedItemChanged (render: AttrRenderFragment, fn) = render ==> html.callback<'T>("SelectedItemChanged", fn)
    [<CustomOperation("SelectedItems")>] member inline _.SelectedItems (render: AttrRenderFragment, x: System.Collections.Generic.HashSet<'T>) = render ==> ("SelectedItems" => x)
    [<CustomOperation("SelectedItems'")>] member inline _.SelectedItems' (render: AttrRenderFragment, value: IStore<System.Collections.Generic.HashSet<'T>>) = render ==> html.bind("SelectedItems", value)
    [<CustomOperation("SelectedItems'")>] member inline _.SelectedItems' (render: AttrRenderFragment, value: cval<System.Collections.Generic.HashSet<'T>>) = render ==> html.bind("SelectedItems", value)
    [<CustomOperation("SelectedItems'")>] member inline _.SelectedItems' (render: AttrRenderFragment, valueFn: System.Collections.Generic.HashSet<'T> * (System.Collections.Generic.HashSet<'T> -> unit)) = render ==> html.bind("SelectedItems", valueFn)
    [<CustomOperation("SelectedItemsChanged")>] member inline _.SelectedItemsChanged (render: AttrRenderFragment, fn) = render ==> html.callback<System.Collections.Generic.HashSet<'T>>("SelectedItemsChanged", fn)
    [<CustomOperation("GroupBy")>] member inline _.GroupBy (render: AttrRenderFragment, x: MudBlazor.TableGroupDefinition<'T>) = render ==> ("GroupBy" => x)
    [<CustomOperation("GroupHeaderTemplate")>] member inline _.GroupHeaderTemplate (render: AttrRenderFragment, fn: MudBlazor.TableGroupData<System.Object, 'T> -> NodeRenderFragment) = render ==> html.renderFragment("GroupHeaderTemplate", fn)
    [<CustomOperation("GroupHeaderClass")>] member inline _.GroupHeaderClass (render: AttrRenderFragment, x: System.String) = render ==> ("GroupHeaderClass" => x)
    [<CustomOperation("GroupHeaderStyle")>] member inline _.GroupHeaderStyle (render: AttrRenderFragment, x: System.String) = render ==> ("GroupHeaderStyle" => x)
    [<CustomOperation("GroupFooterClass")>] member inline _.GroupFooterClass (render: AttrRenderFragment, x: System.String) = render ==> ("GroupFooterClass" => x)
    [<CustomOperation("GroupFooterStyle")>] member inline _.GroupFooterStyle (render: AttrRenderFragment, x: System.String) = render ==> ("GroupFooterStyle" => x)
    [<CustomOperation("GroupFooterTemplate")>] member inline _.GroupFooterTemplate (render: AttrRenderFragment, fn: MudBlazor.TableGroupData<System.Object, 'T> -> NodeRenderFragment) = render ==> html.renderFragment("GroupFooterTemplate", fn)
    [<CustomOperation("ServerData")>] member inline _.ServerData (render: AttrRenderFragment, fn) = render ==> ("ServerData" => (System.Func<MudBlazor.TableState, System.Threading.Tasks.Task<MudBlazor.TableData<'T>>>fn))
                

type MudTabsBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("KeepPanelsAlive")>] member inline _.KeepPanelsAlive (render: AttrRenderFragment, x: System.Boolean) = render ==> ("KeepPanelsAlive" => x)
    [<CustomOperation("Rounded")>] member inline _.Rounded (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Rounded" => x)
    [<CustomOperation("Border")>] member inline _.Border (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Border" => x)
    [<CustomOperation("Outlined")>] member inline _.Outlined (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Outlined" => x)
    [<CustomOperation("Centered")>] member inline _.Centered (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Centered" => x)
    [<CustomOperation("HideSlider")>] member inline _.HideSlider (render: AttrRenderFragment, x: System.Boolean) = render ==> ("HideSlider" => x)
    [<CustomOperation("PrevIcon")>] member inline _.PrevIcon (render: AttrRenderFragment, x: System.String) = render ==> ("PrevIcon" => x)
    [<CustomOperation("NextIcon")>] member inline _.NextIcon (render: AttrRenderFragment, x: System.String) = render ==> ("NextIcon" => x)
    [<CustomOperation("AlwaysShowScrollButtons")>] member inline _.AlwaysShowScrollButtons (render: AttrRenderFragment, x: System.Boolean) = render ==> ("AlwaysShowScrollButtons" => x)
    [<CustomOperation("MaxHeight")>] member inline _.MaxHeight (render: AttrRenderFragment, x: System.Nullable<System.Int32>) = render ==> ("MaxHeight" => x)
    [<CustomOperation("Position")>] member inline _.Position (render: AttrRenderFragment, x: MudBlazor.Position) = render ==> ("Position" => x)
    [<CustomOperation("Color")>] member inline _.Color (render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("Color" => x)
    [<CustomOperation("SliderColor")>] member inline _.SliderColor (render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("SliderColor" => x)
    [<CustomOperation("IconColor")>] member inline _.IconColor (render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("IconColor" => x)
    [<CustomOperation("ScrollIconColor")>] member inline _.ScrollIconColor (render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("ScrollIconColor" => x)
    [<CustomOperation("Elevation")>] member inline _.Elevation (render: AttrRenderFragment, x: System.Int32) = render ==> ("Elevation" => x)
    [<CustomOperation("ApplyEffectsToContainer")>] member inline _.ApplyEffectsToContainer (render: AttrRenderFragment, x: System.Boolean) = render ==> ("ApplyEffectsToContainer" => x)
    [<CustomOperation("DisableRipple")>] member inline _.DisableRipple (render: AttrRenderFragment, x: System.Boolean) = render ==> ("DisableRipple" => x)
    [<CustomOperation("DisableSliderAnimation")>] member inline _.DisableSliderAnimation (render: AttrRenderFragment, x: System.Boolean) = render ==> ("DisableSliderAnimation" => x)
    [<CustomOperation("PrePanelContent")>] member inline _.PrePanelContent (render: AttrRenderFragment, fn: MudBlazor.MudTabPanel -> NodeRenderFragment) = render ==> html.renderFragment("PrePanelContent", fn)
    [<CustomOperation("TabPanelClass")>] member inline _.TabPanelClass (render: AttrRenderFragment, x: System.String) = render ==> ("TabPanelClass" => x)
    [<CustomOperation("PanelClass")>] member inline _.PanelClass (render: AttrRenderFragment, x: System.String) = render ==> ("PanelClass" => x)
    [<CustomOperation("ActivePanelIndex")>] member inline _.ActivePanelIndex (render: AttrRenderFragment, x: System.Int32) = render ==> ("ActivePanelIndex" => x)
    [<CustomOperation("ActivePanelIndex'")>] member inline _.ActivePanelIndex' (render: AttrRenderFragment, value: IStore<System.Int32>) = render ==> html.bind("ActivePanelIndex", value)
    [<CustomOperation("ActivePanelIndex'")>] member inline _.ActivePanelIndex' (render: AttrRenderFragment, value: cval<System.Int32>) = render ==> html.bind("ActivePanelIndex", value)
    [<CustomOperation("ActivePanelIndex'")>] member inline _.ActivePanelIndex' (render: AttrRenderFragment, valueFn: System.Int32 * (System.Int32 -> unit)) = render ==> html.bind("ActivePanelIndex", valueFn)
    [<CustomOperation("ActivePanelIndexChanged")>] member inline _.ActivePanelIndexChanged (render: AttrRenderFragment, fn) = render ==> html.callback<System.Int32>("ActivePanelIndexChanged", fn)
    [<CustomOperation("Header")>] member inline _.Header (render: AttrRenderFragment, fn: MudBlazor.MudTabs -> NodeRenderFragment) = render ==> html.renderFragment("Header", fn)
    [<CustomOperation("HeaderPosition")>] member inline _.HeaderPosition (render: AttrRenderFragment, x: MudBlazor.TabHeaderPosition) = render ==> ("HeaderPosition" => x)
    [<CustomOperation("TabPanelHeader")>] member inline _.TabPanelHeader (render: AttrRenderFragment, fn: MudBlazor.MudTabPanel -> NodeRenderFragment) = render ==> html.renderFragment("TabPanelHeader", fn)
    [<CustomOperation("TabPanelHeaderPosition")>] member inline _.TabPanelHeaderPosition (render: AttrRenderFragment, x: MudBlazor.TabHeaderPosition) = render ==> ("TabPanelHeaderPosition" => x)
                

type MudDynamicTabsBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudTabsBuilder<'FunBlazorGeneric>()
    [<CustomOperation("AddTabIcon")>] member inline _.AddTabIcon (render: AttrRenderFragment, x: System.String) = render ==> ("AddTabIcon" => x)
    [<CustomOperation("CloseTabIcon")>] member inline _.CloseTabIcon (render: AttrRenderFragment, x: System.String) = render ==> ("CloseTabIcon" => x)
    [<CustomOperation("AddTab")>] member inline _.AddTab (render: AttrRenderFragment, fn) = render ==> html.callback<unit>("AddTab", fn)
    [<CustomOperation("CloseTab")>] member inline _.CloseTab (render: AttrRenderFragment, fn) = render ==> html.callback<MudBlazor.MudTabPanel>("CloseTab", fn)
    [<CustomOperation("AddIconClass")>] member inline _.AddIconClass (render: AttrRenderFragment, x: System.String) = render ==> ("AddIconClass" => x)
    [<CustomOperation("AddIconStyle")>] member inline _.AddIconStyle (render: AttrRenderFragment, x: System.String) = render ==> ("AddIconStyle" => x)
    [<CustomOperation("CloseIconClass")>] member inline _.CloseIconClass (render: AttrRenderFragment, x: System.String) = render ==> ("CloseIconClass" => x)
    [<CustomOperation("CloseIconStyle")>] member inline _.CloseIconStyle (render: AttrRenderFragment, x: System.String) = render ==> ("CloseIconStyle" => x)
    [<CustomOperation("AddIconToolTip")>] member inline _.AddIconToolTip (render: AttrRenderFragment, x: System.String) = render ==> ("AddIconToolTip" => x)
    [<CustomOperation("CloseIconToolTip")>] member inline _.CloseIconToolTip (render: AttrRenderFragment, x: System.String) = render ==> ("CloseIconToolTip" => x)
                

type MudChartBaseBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("InputData")>] member inline _.InputData (render: AttrRenderFragment, x: System.Double[]) = render ==> ("InputData" => x)
    [<CustomOperation("InputLabels")>] member inline _.InputLabels (render: AttrRenderFragment, x: System.String[]) = render ==> ("InputLabels" => x)
    [<CustomOperation("XAxisLabels")>] member inline _.XAxisLabels (render: AttrRenderFragment, x: System.String[]) = render ==> ("XAxisLabels" => x)
    [<CustomOperation("ChartSeries")>] member inline _.ChartSeries (render: AttrRenderFragment, x: System.Collections.Generic.List<MudBlazor.ChartSeries>) = render ==> ("ChartSeries" => x)
    [<CustomOperation("ChartOptions")>] member inline _.ChartOptions (render: AttrRenderFragment, x: MudBlazor.ChartOptions) = render ==> ("ChartOptions" => x)
    [<CustomOperation("CustomGraphics")>] member inline _.CustomGraphics (render: AttrRenderFragment, fragment) = render ==> html.renderFragment("CustomGraphics", fragment)
    [<CustomOperation("CustomGraphics")>] member inline _.CustomGraphics (render: AttrRenderFragment, x: string) = render ==> html.renderFragment("CustomGraphics", html.text x)
    [<CustomOperation("CustomGraphics")>] member inline _.CustomGraphics (render: AttrRenderFragment, x: int) = render ==> html.renderFragment("CustomGraphics", html.text x)
    [<CustomOperation("CustomGraphics")>] member inline _.CustomGraphics (render: AttrRenderFragment, x: float) = render ==> html.renderFragment("CustomGraphics", html.text x)
    [<CustomOperation("ChartType")>] member inline _.ChartType (render: AttrRenderFragment, x: MudBlazor.ChartType) = render ==> ("ChartType" => x)
    [<CustomOperation("Width")>] member inline _.Width (render: AttrRenderFragment, x: System.String) = render ==> ("Width" => x)
    [<CustomOperation("Height")>] member inline _.Height (render: AttrRenderFragment, x: System.String) = render ==> ("Height" => x)
    [<CustomOperation("LegendPosition")>] member inline _.LegendPosition (render: AttrRenderFragment, x: MudBlazor.Position) = render ==> ("LegendPosition" => x)
    [<CustomOperation("SelectedIndex")>] member inline _.SelectedIndex (render: AttrRenderFragment, x: System.Int32) = render ==> ("SelectedIndex" => x)
    [<CustomOperation("SelectedIndex'")>] member inline _.SelectedIndex' (render: AttrRenderFragment, value: IStore<System.Int32>) = render ==> html.bind("SelectedIndex", value)
    [<CustomOperation("SelectedIndex'")>] member inline _.SelectedIndex' (render: AttrRenderFragment, value: cval<System.Int32>) = render ==> html.bind("SelectedIndex", value)
    [<CustomOperation("SelectedIndex'")>] member inline _.SelectedIndex' (render: AttrRenderFragment, valueFn: System.Int32 * (System.Int32 -> unit)) = render ==> html.bind("SelectedIndex", valueFn)
    [<CustomOperation("SelectedIndexChanged")>] member inline _.SelectedIndexChanged (render: AttrRenderFragment, fn) = render ==> html.callback<System.Int32>("SelectedIndexChanged", fn)
                

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
    [<CustomOperation("Data")>] member inline _.Data (render: AttrRenderFragment, x: System.Collections.Generic.List<MudBlazor.Charts.SVG.Models.SvgLegend>) = render ==> ("Data" => x)
                
            
namespace rec MudBlazor.DslInternals

open FSharp.Data.Adaptive
open Fun.Blazor
open Fun.Blazor.Operators
open MudBlazor.DslInternals


type MudBaseItemsControlBuilder<'FunBlazorGeneric, 'TChildComponent when 'TChildComponent :> MudBlazor.MudComponentBase and 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("SelectedIndex")>] member inline _.SelectedIndex (render: AttrRenderFragment, x: System.Int32) = render ==> ("SelectedIndex" => x)
    [<CustomOperation("SelectedIndex'")>] member inline _.SelectedIndex' (render: AttrRenderFragment, value: IStore<System.Int32>) = render ==> html.bind("SelectedIndex", value)
    [<CustomOperation("SelectedIndex'")>] member inline _.SelectedIndex' (render: AttrRenderFragment, value: cval<System.Int32>) = render ==> html.bind("SelectedIndex", value)
    [<CustomOperation("SelectedIndex'")>] member inline _.SelectedIndex' (render: AttrRenderFragment, valueFn: System.Int32 * (System.Int32 -> unit)) = render ==> html.bind("SelectedIndex", valueFn)
    [<CustomOperation("SelectedIndexChanged")>] member inline _.SelectedIndexChanged (render: AttrRenderFragment, fn) = render ==> html.callback<System.Int32>("SelectedIndexChanged", fn)
                

type MudBaseBindableItemsControlBuilder<'FunBlazorGeneric, 'TChildComponent, 'TData when 'TChildComponent :> MudBlazor.MudComponentBase and 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudBaseItemsControlBuilder<'FunBlazorGeneric, 'TChildComponent>()
    [<CustomOperation("ItemsSource")>] member inline _.ItemsSource (render: AttrRenderFragment, x: System.Collections.Generic.IEnumerable<'TData>) = render ==> ("ItemsSource" => x)
    [<CustomOperation("ItemTemplate")>] member inline _.ItemTemplate (render: AttrRenderFragment, fn: 'TData -> NodeRenderFragment) = render ==> html.renderFragment("ItemTemplate", fn)
                

type MudCarouselBuilder<'FunBlazorGeneric, 'TData when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudBaseBindableItemsControlBuilder<'FunBlazorGeneric, MudBlazor.MudCarouselItem, 'TData>()
    [<CustomOperation("ShowArrows")>] member inline _.ShowArrows (render: AttrRenderFragment, x: System.Boolean) = render ==> ("ShowArrows" => x)
    [<CustomOperation("ArrowsPosition")>] member inline _.ArrowsPosition (render: AttrRenderFragment, x: MudBlazor.Position) = render ==> ("ArrowsPosition" => x)
    [<CustomOperation("ShowBullets")>] member inline _.ShowBullets (render: AttrRenderFragment, x: System.Boolean) = render ==> ("ShowBullets" => x)
    [<CustomOperation("BulletsPosition")>] member inline _.BulletsPosition (render: AttrRenderFragment, x: MudBlazor.Position) = render ==> ("BulletsPosition" => x)
    [<CustomOperation("BulletsColor")>] member inline _.BulletsColor (render: AttrRenderFragment, x: System.Nullable<MudBlazor.Color>) = render ==> ("BulletsColor" => x)
    [<CustomOperation("ShowDelimiters")>] member inline _.ShowDelimiters (render: AttrRenderFragment, x: System.Boolean) = render ==> ("ShowDelimiters" => x)
    [<CustomOperation("DelimitersColor")>] member inline _.DelimitersColor (render: AttrRenderFragment, x: System.Nullable<MudBlazor.Color>) = render ==> ("DelimitersColor" => x)
    [<CustomOperation("AutoCycle")>] member inline _.AutoCycle (render: AttrRenderFragment, x: System.Boolean) = render ==> ("AutoCycle" => x)
    [<CustomOperation("AutoCycleTime")>] member inline _.AutoCycleTime (render: AttrRenderFragment, x: System.TimeSpan) = render ==> ("AutoCycleTime" => x)
    [<CustomOperation("NavigationButtonsClass")>] member inline _.NavigationButtonsClass (render: AttrRenderFragment, x: System.String) = render ==> ("NavigationButtonsClass" => x)
    [<CustomOperation("BulletsClass")>] member inline _.BulletsClass (render: AttrRenderFragment, x: System.String) = render ==> ("BulletsClass" => x)
    [<CustomOperation("DelimitersClass")>] member inline _.DelimitersClass (render: AttrRenderFragment, x: System.String) = render ==> ("DelimitersClass" => x)
    [<CustomOperation("PreviousIcon")>] member inline _.PreviousIcon (render: AttrRenderFragment, x: System.String) = render ==> ("PreviousIcon" => x)
    [<CustomOperation("CheckedIcon")>] member inline _.CheckedIcon (render: AttrRenderFragment, x: System.String) = render ==> ("CheckedIcon" => x)
    [<CustomOperation("UncheckedIcon")>] member inline _.UncheckedIcon (render: AttrRenderFragment, x: System.String) = render ==> ("UncheckedIcon" => x)
    [<CustomOperation("NextIcon")>] member inline _.NextIcon (render: AttrRenderFragment, x: System.String) = render ==> ("NextIcon" => x)
    [<CustomOperation("NextButtonTemplate")>] member inline _.NextButtonTemplate (render: AttrRenderFragment, fragment) = render ==> html.renderFragment("NextButtonTemplate", fragment)
    [<CustomOperation("NextButtonTemplate")>] member inline _.NextButtonTemplate (render: AttrRenderFragment, x: string) = render ==> html.renderFragment("NextButtonTemplate", html.text x)
    [<CustomOperation("NextButtonTemplate")>] member inline _.NextButtonTemplate (render: AttrRenderFragment, x: int) = render ==> html.renderFragment("NextButtonTemplate", html.text x)
    [<CustomOperation("NextButtonTemplate")>] member inline _.NextButtonTemplate (render: AttrRenderFragment, x: float) = render ==> html.renderFragment("NextButtonTemplate", html.text x)
    [<CustomOperation("PreviousButtonTemplate")>] member inline _.PreviousButtonTemplate (render: AttrRenderFragment, fragment) = render ==> html.renderFragment("PreviousButtonTemplate", fragment)
    [<CustomOperation("PreviousButtonTemplate")>] member inline _.PreviousButtonTemplate (render: AttrRenderFragment, x: string) = render ==> html.renderFragment("PreviousButtonTemplate", html.text x)
    [<CustomOperation("PreviousButtonTemplate")>] member inline _.PreviousButtonTemplate (render: AttrRenderFragment, x: int) = render ==> html.renderFragment("PreviousButtonTemplate", html.text x)
    [<CustomOperation("PreviousButtonTemplate")>] member inline _.PreviousButtonTemplate (render: AttrRenderFragment, x: float) = render ==> html.renderFragment("PreviousButtonTemplate", html.text x)
    [<CustomOperation("BulletTemplate")>] member inline _.BulletTemplate (render: AttrRenderFragment, fn: System.Boolean -> NodeRenderFragment) = render ==> html.renderFragment("BulletTemplate", fn)
    [<CustomOperation("DelimiterTemplate")>] member inline _.DelimiterTemplate (render: AttrRenderFragment, fn: System.Boolean -> NodeRenderFragment) = render ==> html.renderFragment("DelimiterTemplate", fn)
                

type MudTimelineBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudBaseItemsControlBuilder<'FunBlazorGeneric, MudBlazor.MudTimelineItem>()
    [<CustomOperation("TimelineOrientation")>] member inline _.TimelineOrientation (render: AttrRenderFragment, x: MudBlazor.TimelineOrientation) = render ==> ("TimelineOrientation" => x)
    [<CustomOperation("TimelinePosition")>] member inline _.TimelinePosition (render: AttrRenderFragment, x: MudBlazor.TimelinePosition) = render ==> ("TimelinePosition" => x)
    [<CustomOperation("TimelineAlign")>] member inline _.TimelineAlign (render: AttrRenderFragment, x: MudBlazor.TimelineAlign) = render ==> ("TimelineAlign" => x)
    [<CustomOperation("Reverse")>] member inline _.Reverse (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Reverse" => x)
    [<CustomOperation("DisableModifiers")>] member inline _.DisableModifiers (render: AttrRenderFragment, x: System.Boolean) = render ==> ("DisableModifiers" => x)
                

type MudFormComponentBuilder<'FunBlazorGeneric, 'T, 'U when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Required")>] member inline _.Required (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Required" => x)
    [<CustomOperation("RequiredError")>] member inline _.RequiredError (render: AttrRenderFragment, x: System.String) = render ==> ("RequiredError" => x)
    [<CustomOperation("ErrorText")>] member inline _.ErrorText (render: AttrRenderFragment, x: System.String) = render ==> ("ErrorText" => x)
    [<CustomOperation("Error")>] member inline _.Error (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Error" => x)
    [<CustomOperation("Converter")>] member inline _.Converter (render: AttrRenderFragment, x: MudBlazor.Converter<'T, 'U>) = render ==> ("Converter" => x)
    [<CustomOperation("Culture")>] member inline _.Culture (render: AttrRenderFragment, x: System.Globalization.CultureInfo) = render ==> ("Culture" => x)
    [<CustomOperation("Validation")>] member inline _.Validation (render: AttrRenderFragment, x: System.Object) = render ==> ("Validation" => x)
    [<CustomOperation("For'")>] member inline _.For' (render: AttrRenderFragment, x: System.Linq.Expressions.Expression<System.Func<'T>>) = render ==> ("For" => x)
                

type MudBaseInputBuilder<'FunBlazorGeneric, 'T when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudFormComponentBuilder<'FunBlazorGeneric, 'T, System.String>()
    [<CustomOperation("Disabled")>] member inline _.Disabled (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Disabled" => x)
    [<CustomOperation("ReadOnly")>] member inline _.ReadOnly (render: AttrRenderFragment, x: System.Boolean) = render ==> ("ReadOnly" => x)
    [<CustomOperation("FullWidth")>] member inline _.FullWidth (render: AttrRenderFragment, x: System.Boolean) = render ==> ("FullWidth" => x)
    [<CustomOperation("Immediate")>] member inline _.Immediate (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Immediate" => x)
    [<CustomOperation("DisableUnderLine")>] member inline _.DisableUnderLine (render: AttrRenderFragment, x: System.Boolean) = render ==> ("DisableUnderLine" => x)
    [<CustomOperation("HelperText")>] member inline _.HelperText (render: AttrRenderFragment, x: System.String) = render ==> ("HelperText" => x)
    [<CustomOperation("HelperTextOnFocus")>] member inline _.HelperTextOnFocus (render: AttrRenderFragment, x: System.Boolean) = render ==> ("HelperTextOnFocus" => x)
    [<CustomOperation("AdornmentIcon")>] member inline _.AdornmentIcon (render: AttrRenderFragment, x: System.String) = render ==> ("AdornmentIcon" => x)
    [<CustomOperation("AdornmentText")>] member inline _.AdornmentText (render: AttrRenderFragment, x: System.String) = render ==> ("AdornmentText" => x)
    [<CustomOperation("Adornment")>] member inline _.Adornment (render: AttrRenderFragment, x: MudBlazor.Adornment) = render ==> ("Adornment" => x)
    [<CustomOperation("AdornmentColor")>] member inline _.AdornmentColor (render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("AdornmentColor" => x)
    [<CustomOperation("IconSize")>] member inline _.IconSize (render: AttrRenderFragment, x: MudBlazor.Size) = render ==> ("IconSize" => x)
    [<CustomOperation("OnAdornmentClick")>] member inline _.OnAdornmentClick (render: AttrRenderFragment, fn) = render ==> html.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>("OnAdornmentClick", fn)
    [<CustomOperation("Variant")>] member inline _.Variant (render: AttrRenderFragment, x: MudBlazor.Variant) = render ==> ("Variant" => x)
    [<CustomOperation("Margin")>] member inline _.Margin (render: AttrRenderFragment, x: MudBlazor.Margin) = render ==> ("Margin" => x)
    [<CustomOperation("Placeholder")>] member inline _.Placeholder (render: AttrRenderFragment, x: System.String) = render ==> ("Placeholder" => x)
    [<CustomOperation("Counter")>] member inline _.Counter (render: AttrRenderFragment, x: System.Nullable<System.Int32>) = render ==> ("Counter" => x)
    [<CustomOperation("MaxLength")>] member inline _.MaxLength (render: AttrRenderFragment, x: System.Int32) = render ==> ("MaxLength" => x)
    [<CustomOperation("Label")>] member inline _.Label (render: AttrRenderFragment, x: System.String) = render ==> ("Label" => x)
    [<CustomOperation("AutoFocus")>] member inline _.AutoFocus (render: AttrRenderFragment, x: System.Boolean) = render ==> ("AutoFocus" => x)
    [<CustomOperation("Lines")>] member inline _.Lines (render: AttrRenderFragment, x: System.Int32) = render ==> ("Lines" => x)
    [<CustomOperation("Text")>] member inline _.Text (render: AttrRenderFragment, x: System.String) = render ==> ("Text" => x)
    [<CustomOperation("Text'")>] member inline _.Text' (render: AttrRenderFragment, value: IStore<System.String>) = render ==> html.bind("Text", value)
    [<CustomOperation("Text'")>] member inline _.Text' (render: AttrRenderFragment, value: cval<System.String>) = render ==> html.bind("Text", value)
    [<CustomOperation("Text'")>] member inline _.Text' (render: AttrRenderFragment, valueFn: System.String * (System.String -> unit)) = render ==> html.bind("Text", valueFn)
    [<CustomOperation("TextUpdateSuppression")>] member inline _.TextUpdateSuppression (render: AttrRenderFragment, x: System.Boolean) = render ==> ("TextUpdateSuppression" => x)
    [<CustomOperation("InputMode")>] member inline _.InputMode (render: AttrRenderFragment, x: MudBlazor.InputMode) = render ==> ("InputMode" => x)
    [<CustomOperation("Pattern")>] member inline _.Pattern (render: AttrRenderFragment, x: System.String) = render ==> ("Pattern" => x)
    [<CustomOperation("TextChanged")>] member inline _.TextChanged (render: AttrRenderFragment, fn) = render ==> html.callback<System.String>("TextChanged", fn)
    [<CustomOperation("OnBlur")>] member inline _.OnBlur (render: AttrRenderFragment, fn) = render ==> html.callback<Microsoft.AspNetCore.Components.Web.FocusEventArgs>("OnBlur", fn)
    [<CustomOperation("OnInternalInputChanged")>] member inline _.OnInternalInputChanged (render: AttrRenderFragment, fn) = render ==> html.callback<Microsoft.AspNetCore.Components.ChangeEventArgs>("OnInternalInputChanged", fn)
    [<CustomOperation("OnKeyDown")>] member inline _.OnKeyDown (render: AttrRenderFragment, fn) = render ==> html.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs>("OnKeyDown", fn)
    [<CustomOperation("KeyDownPreventDefault")>] member inline _.KeyDownPreventDefault (render: AttrRenderFragment, x: System.Boolean) = render ==> ("KeyDownPreventDefault" => x)
    [<CustomOperation("OnKeyPress")>] member inline _.OnKeyPress (render: AttrRenderFragment, fn) = render ==> html.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs>("OnKeyPress", fn)
    [<CustomOperation("KeyPressPreventDefault")>] member inline _.KeyPressPreventDefault (render: AttrRenderFragment, x: System.Boolean) = render ==> ("KeyPressPreventDefault" => x)
    [<CustomOperation("OnKeyUp")>] member inline _.OnKeyUp (render: AttrRenderFragment, fn) = render ==> html.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs>("OnKeyUp", fn)
    [<CustomOperation("KeyUpPreventDefault")>] member inline _.KeyUpPreventDefault (render: AttrRenderFragment, x: System.Boolean) = render ==> ("KeyUpPreventDefault" => x)
    [<CustomOperation("ValueChanged")>] member inline _.ValueChanged (render: AttrRenderFragment, fn) = render ==> html.callback<'T>("ValueChanged", fn)
    [<CustomOperation("Value")>] member inline _.Value (render: AttrRenderFragment, x: 'T) = render ==> ("Value" => x)
    [<CustomOperation("Value'")>] member inline _.Value' (render: AttrRenderFragment, value: IStore<'T>) = render ==> html.bind("Value", value)
    [<CustomOperation("Value'")>] member inline _.Value' (render: AttrRenderFragment, value: cval<'T>) = render ==> html.bind("Value", value)
    [<CustomOperation("Value'")>] member inline _.Value' (render: AttrRenderFragment, valueFn: 'T * ('T -> unit)) = render ==> html.bind("Value", valueFn)
    [<CustomOperation("Format")>] member inline _.Format (render: AttrRenderFragment, x: System.String) = render ==> ("Format" => x)
                

type MudAutocompleteBuilder<'FunBlazorGeneric, 'T when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudBaseInputBuilder<'FunBlazorGeneric, 'T>()
    [<CustomOperation("PopoverClass")>] member inline _.PopoverClass (render: AttrRenderFragment, x: System.String) = render ==> ("PopoverClass" => x)
    [<CustomOperation("AnchorOrigin")>] member inline _.AnchorOrigin (render: AttrRenderFragment, x: MudBlazor.Origin) = render ==> ("AnchorOrigin" => x)
    [<CustomOperation("TransformOrigin")>] member inline _.TransformOrigin (render: AttrRenderFragment, x: MudBlazor.Origin) = render ==> ("TransformOrigin" => x)
    [<CustomOperation("Dense")>] member inline _.Dense (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Dense" => x)
    [<CustomOperation("OpenIcon")>] member inline _.OpenIcon (render: AttrRenderFragment, x: System.String) = render ==> ("OpenIcon" => x)
    [<CustomOperation("CloseIcon")>] member inline _.CloseIcon (render: AttrRenderFragment, x: System.String) = render ==> ("CloseIcon" => x)
    [<CustomOperation("MaxHeight")>] member inline _.MaxHeight (render: AttrRenderFragment, x: System.Int32) = render ==> ("MaxHeight" => x)
    [<CustomOperation("ToStringFunc")>] member inline _.ToStringFunc (render: AttrRenderFragment, fn) = render ==> ("ToStringFunc" => (System.Func<'T, System.String>fn))
    [<CustomOperation("SearchFunc")>] member inline _.SearchFunc (render: AttrRenderFragment, fn) = render ==> ("SearchFunc" => (System.Func<System.String, System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<'T>>>fn))
    [<CustomOperation("MaxItems")>] member inline _.MaxItems (render: AttrRenderFragment, x: System.Nullable<System.Int32>) = render ==> ("MaxItems" => x)
    [<CustomOperation("MinCharacters")>] member inline _.MinCharacters (render: AttrRenderFragment, x: System.Int32) = render ==> ("MinCharacters" => x)
    [<CustomOperation("ResetValueOnEmptyText")>] member inline _.ResetValueOnEmptyText (render: AttrRenderFragment, x: System.Boolean) = render ==> ("ResetValueOnEmptyText" => x)
    [<CustomOperation("DebounceInterval")>] member inline _.DebounceInterval (render: AttrRenderFragment, x: System.Int32) = render ==> ("DebounceInterval" => x)
    [<CustomOperation("ItemTemplate")>] member inline _.ItemTemplate (render: AttrRenderFragment, fn: 'T -> NodeRenderFragment) = render ==> html.renderFragment("ItemTemplate", fn)
    [<CustomOperation("ItemSelectedTemplate")>] member inline _.ItemSelectedTemplate (render: AttrRenderFragment, fn: 'T -> NodeRenderFragment) = render ==> html.renderFragment("ItemSelectedTemplate", fn)
    [<CustomOperation("ItemDisabledTemplate")>] member inline _.ItemDisabledTemplate (render: AttrRenderFragment, fn: 'T -> NodeRenderFragment) = render ==> html.renderFragment("ItemDisabledTemplate", fn)
    [<CustomOperation("CoerceText")>] member inline _.CoerceText (render: AttrRenderFragment, x: System.Boolean) = render ==> ("CoerceText" => x)
    [<CustomOperation("CoerceValue")>] member inline _.CoerceValue (render: AttrRenderFragment, x: System.Boolean) = render ==> ("CoerceValue" => x)
    [<CustomOperation("ItemDisabledFunc")>] member inline _.ItemDisabledFunc (render: AttrRenderFragment, fn) = render ==> ("ItemDisabledFunc" => (System.Func<'T, System.Boolean>fn))
    [<CustomOperation("IsOpenChanged")>] member inline _.IsOpenChanged (render: AttrRenderFragment, fn) = render ==> html.callback<System.Boolean>("IsOpenChanged", fn)
    [<CustomOperation("SelectValueOnTab")>] member inline _.SelectValueOnTab (render: AttrRenderFragment, x: System.Boolean) = render ==> ("SelectValueOnTab" => x)
    [<CustomOperation("Clearable")>] member inline _.Clearable (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Clearable" => x)
    [<CustomOperation("OnClearButtonClick")>] member inline _.OnClearButtonClick (render: AttrRenderFragment, fn) = render ==> html.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>("OnClearButtonClick", fn)
                

type MudDebouncedInputBuilder<'FunBlazorGeneric, 'T when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudBaseInputBuilder<'FunBlazorGeneric, 'T>()
    [<CustomOperation("DebounceInterval")>] member inline _.DebounceInterval (render: AttrRenderFragment, x: System.Double) = render ==> ("DebounceInterval" => x)
    [<CustomOperation("OnDebounceIntervalElapsed")>] member inline _.OnDebounceIntervalElapsed (render: AttrRenderFragment, fn) = render ==> html.callback<System.String>("OnDebounceIntervalElapsed", fn)
                

type MudNumericFieldBuilder<'FunBlazorGeneric, 'T when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudDebouncedInputBuilder<'FunBlazorGeneric, 'T>()
    [<CustomOperation("Clearable")>] member inline _.Clearable (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Clearable" => x)
    [<CustomOperation("InvertMouseWheel")>] member inline _.InvertMouseWheel (render: AttrRenderFragment, x: System.Boolean) = render ==> ("InvertMouseWheel" => x)
    [<CustomOperation("Min")>] member inline _.Min (render: AttrRenderFragment, x: 'T) = render ==> ("Min" => x)
    [<CustomOperation("Max")>] member inline _.Max (render: AttrRenderFragment, x: 'T) = render ==> ("Max" => x)
    [<CustomOperation("Step")>] member inline _.Step (render: AttrRenderFragment, x: 'T) = render ==> ("Step" => x)
    [<CustomOperation("HideSpinButtons")>] member inline _.HideSpinButtons (render: AttrRenderFragment, x: System.Boolean) = render ==> ("HideSpinButtons" => x)
    [<CustomOperation("InputMode")>] member inline _.InputMode (render: AttrRenderFragment, x: MudBlazor.InputMode) = render ==> ("InputMode" => x)
    [<CustomOperation("Pattern")>] member inline _.Pattern (render: AttrRenderFragment, x: System.String) = render ==> ("Pattern" => x)
                

type MudTextFieldBuilder<'FunBlazorGeneric, 'T when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudDebouncedInputBuilder<'FunBlazorGeneric, 'T>()
    [<CustomOperation("InputType")>] member inline _.InputType (render: AttrRenderFragment, x: MudBlazor.InputType) = render ==> ("InputType" => x)
    [<CustomOperation("Clearable")>] member inline _.Clearable (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Clearable" => x)
    [<CustomOperation("OnClearButtonClick")>] member inline _.OnClearButtonClick (render: AttrRenderFragment, fn) = render ==> html.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>("OnClearButtonClick", fn)
                

type MudInputBuilder<'FunBlazorGeneric, 'T when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudBaseInputBuilder<'FunBlazorGeneric, 'T>()
    [<CustomOperation("InputType")>] member inline _.InputType (render: AttrRenderFragment, x: MudBlazor.InputType) = render ==> ("InputType" => x)
    [<CustomOperation("OnIncrement")>] member inline _.OnIncrement (render: AttrRenderFragment, fn) = render ==> html.callback<unit>("OnIncrement", fn)
    [<CustomOperation("OnDecrement")>] member inline _.OnDecrement (render: AttrRenderFragment, fn) = render ==> html.callback<unit>("OnDecrement", fn)
    [<CustomOperation("HideSpinButtons")>] member inline _.HideSpinButtons (render: AttrRenderFragment, x: System.Boolean) = render ==> ("HideSpinButtons" => x)
    [<CustomOperation("Clearable")>] member inline _.Clearable (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Clearable" => x)
    [<CustomOperation("OnClearButtonClick")>] member inline _.OnClearButtonClick (render: AttrRenderFragment, fn) = render ==> html.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>("OnClearButtonClick", fn)
    [<CustomOperation("OnMouseWheel")>] member inline _.OnMouseWheel (render: AttrRenderFragment, fn) = render ==> html.callback<Microsoft.AspNetCore.Components.Web.WheelEventArgs>("OnMouseWheel", fn)
    [<CustomOperation("ClearIcon")>] member inline _.ClearIcon (render: AttrRenderFragment, x: System.String) = render ==> ("ClearIcon" => x)
    [<CustomOperation("NumericUpIcon")>] member inline _.NumericUpIcon (render: AttrRenderFragment, x: System.String) = render ==> ("NumericUpIcon" => x)
    [<CustomOperation("NumericDownIcon")>] member inline _.NumericDownIcon (render: AttrRenderFragment, x: System.String) = render ==> ("NumericDownIcon" => x)
                

type MudInputStringBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudInputBuilder<'FunBlazorGeneric, System.String>()

                

type MudRangeInputBuilder<'FunBlazorGeneric, 'T when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudBaseInputBuilder<'FunBlazorGeneric, MudBlazor.Range<'T>>()
    [<CustomOperation("InputType")>] member inline _.InputType (render: AttrRenderFragment, x: MudBlazor.InputType) = render ==> ("InputType" => x)
    [<CustomOperation("PlaceholderStart")>] member inline _.PlaceholderStart (render: AttrRenderFragment, x: System.String) = render ==> ("PlaceholderStart" => x)
    [<CustomOperation("PlaceholderEnd")>] member inline _.PlaceholderEnd (render: AttrRenderFragment, x: System.String) = render ==> ("PlaceholderEnd" => x)
    [<CustomOperation("SeparatorIcon")>] member inline _.SeparatorIcon (render: AttrRenderFragment, x: System.String) = render ==> ("SeparatorIcon" => x)
                

type MudSelectBuilder<'FunBlazorGeneric, 'T when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudBaseInputBuilder<'FunBlazorGeneric, 'T>()
    [<CustomOperation("PopoverClass")>] member inline _.PopoverClass (render: AttrRenderFragment, x: System.String) = render ==> ("PopoverClass" => x)
    [<CustomOperation("Dense")>] member inline _.Dense (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Dense" => x)
    [<CustomOperation("OpenIcon")>] member inline _.OpenIcon (render: AttrRenderFragment, x: System.String) = render ==> ("OpenIcon" => x)
    [<CustomOperation("CloseIcon")>] member inline _.CloseIcon (render: AttrRenderFragment, x: System.String) = render ==> ("CloseIcon" => x)
    [<CustomOperation("SelectAll")>] member inline _.SelectAll (render: AttrRenderFragment, x: System.Boolean) = render ==> ("SelectAll" => x)
    [<CustomOperation("SelectAllText")>] member inline _.SelectAllText (render: AttrRenderFragment, x: System.String) = render ==> ("SelectAllText" => x)
    [<CustomOperation("SelectedValuesChanged")>] member inline _.SelectedValuesChanged (render: AttrRenderFragment, fn) = render ==> html.callback<System.Collections.Generic.IEnumerable<'T>>("SelectedValuesChanged", fn)
    [<CustomOperation("MultiSelectionTextFunc")>] member inline _.MultiSelectionTextFunc (render: AttrRenderFragment, fn) = render ==> ("MultiSelectionTextFunc" => (System.Func<System.Collections.Generic.List<System.String>, System.String>fn))
    [<CustomOperation("Delimiter")>] member inline _.Delimiter (render: AttrRenderFragment, x: System.String) = render ==> ("Delimiter" => x)
    [<CustomOperation("SelectedValues")>] member inline _.SelectedValues (render: AttrRenderFragment, x: System.Collections.Generic.IEnumerable<'T>) = render ==> ("SelectedValues" => x)
    [<CustomOperation("SelectedValues'")>] member inline _.SelectedValues' (render: AttrRenderFragment, value: IStore<System.Collections.Generic.IEnumerable<'T>>) = render ==> html.bind("SelectedValues", value)
    [<CustomOperation("SelectedValues'")>] member inline _.SelectedValues' (render: AttrRenderFragment, value: cval<System.Collections.Generic.IEnumerable<'T>>) = render ==> html.bind("SelectedValues", value)
    [<CustomOperation("SelectedValues'")>] member inline _.SelectedValues' (render: AttrRenderFragment, valueFn: System.Collections.Generic.IEnumerable<'T> * (System.Collections.Generic.IEnumerable<'T> -> unit)) = render ==> html.bind("SelectedValues", valueFn)
    [<CustomOperation("Comparer")>] member inline _.Comparer (render: AttrRenderFragment, x: System.Collections.Generic.IEqualityComparer<'T>) = render ==> ("Comparer" => x)
    [<CustomOperation("ToStringFunc")>] member inline _.ToStringFunc (render: AttrRenderFragment, fn) = render ==> ("ToStringFunc" => (System.Func<'T, System.String>fn))
    [<CustomOperation("MultiSelection")>] member inline _.MultiSelection (render: AttrRenderFragment, x: System.Boolean) = render ==> ("MultiSelection" => x)
    [<CustomOperation("MaxHeight")>] member inline _.MaxHeight (render: AttrRenderFragment, x: System.Int32) = render ==> ("MaxHeight" => x)
    [<CustomOperation("AnchorOrigin")>] member inline _.AnchorOrigin (render: AttrRenderFragment, x: MudBlazor.Origin) = render ==> ("AnchorOrigin" => x)
    [<CustomOperation("TransformOrigin")>] member inline _.TransformOrigin (render: AttrRenderFragment, x: MudBlazor.Origin) = render ==> ("TransformOrigin" => x)
    [<CustomOperation("Strict")>] member inline _.Strict (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Strict" => x)
    [<CustomOperation("Clearable")>] member inline _.Clearable (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Clearable" => x)
    [<CustomOperation("LockScroll")>] member inline _.LockScroll (render: AttrRenderFragment, x: System.Boolean) = render ==> ("LockScroll" => x)
    [<CustomOperation("OnClearButtonClick")>] member inline _.OnClearButtonClick (render: AttrRenderFragment, fn) = render ==> html.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>("OnClearButtonClick", fn)
    [<CustomOperation("CheckedIcon")>] member inline _.CheckedIcon (render: AttrRenderFragment, x: System.String) = render ==> ("CheckedIcon" => x)
    [<CustomOperation("UncheckedIcon")>] member inline _.UncheckedIcon (render: AttrRenderFragment, x: System.String) = render ==> ("UncheckedIcon" => x)
    [<CustomOperation("IndeterminateIcon")>] member inline _.IndeterminateIcon (render: AttrRenderFragment, x: System.String) = render ==> ("IndeterminateIcon" => x)
                

type MudBooleanInputBuilder<'FunBlazorGeneric, 'T when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudFormComponentBuilder<'FunBlazorGeneric, 'T, System.Nullable<System.Boolean>>()
    [<CustomOperation("Disabled")>] member inline _.Disabled (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Disabled" => x)
    [<CustomOperation("ReadOnly")>] member inline _.ReadOnly (render: AttrRenderFragment, x: System.Boolean) = render ==> ("ReadOnly" => x)
    [<CustomOperation("Checked")>] member inline _.Checked (render: AttrRenderFragment, x: 'T) = render ==> ("Checked" => x)
    [<CustomOperation("Checked'")>] member inline _.Checked' (render: AttrRenderFragment, value: IStore<'T>) = render ==> html.bind("Checked", value)
    [<CustomOperation("Checked'")>] member inline _.Checked' (render: AttrRenderFragment, value: cval<'T>) = render ==> html.bind("Checked", value)
    [<CustomOperation("Checked'")>] member inline _.Checked' (render: AttrRenderFragment, valueFn: 'T * ('T -> unit)) = render ==> html.bind("Checked", valueFn)
    [<CustomOperation("StopClickPropagation")>] member inline _.StopClickPropagation (render: AttrRenderFragment, x: System.Boolean) = render ==> ("StopClickPropagation" => x)
    [<CustomOperation("CheckedChanged")>] member inline _.CheckedChanged (render: AttrRenderFragment, fn) = render ==> html.callback<'T>("CheckedChanged", fn)
                

type MudCheckBoxBuilder<'FunBlazorGeneric, 'T when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudBooleanInputBuilder<'FunBlazorGeneric, 'T>()
    [<CustomOperation("Color")>] member inline _.Color (render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("Color" => x)
    [<CustomOperation("Label")>] member inline _.Label (render: AttrRenderFragment, x: System.String) = render ==> ("Label" => x)
    [<CustomOperation("DisableRipple")>] member inline _.DisableRipple (render: AttrRenderFragment, x: System.Boolean) = render ==> ("DisableRipple" => x)
    [<CustomOperation("Dense")>] member inline _.Dense (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Dense" => x)
    [<CustomOperation("Size")>] member inline _.Size (render: AttrRenderFragment, x: MudBlazor.Size) = render ==> ("Size" => x)
    [<CustomOperation("CheckedIcon")>] member inline _.CheckedIcon (render: AttrRenderFragment, x: System.String) = render ==> ("CheckedIcon" => x)
    [<CustomOperation("UncheckedIcon")>] member inline _.UncheckedIcon (render: AttrRenderFragment, x: System.String) = render ==> ("UncheckedIcon" => x)
    [<CustomOperation("IndeterminateIcon")>] member inline _.IndeterminateIcon (render: AttrRenderFragment, x: System.String) = render ==> ("IndeterminateIcon" => x)
    [<CustomOperation("TriState")>] member inline _.TriState (render: AttrRenderFragment, x: System.Boolean) = render ==> ("TriState" => x)
                

type MudSwitchBuilder<'FunBlazorGeneric, 'T when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudBooleanInputBuilder<'FunBlazorGeneric, 'T>()
    [<CustomOperation("Color")>] member inline _.Color (render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("Color" => x)
    [<CustomOperation("Label")>] member inline _.Label (render: AttrRenderFragment, x: System.String) = render ==> ("Label" => x)
    [<CustomOperation("ThumbIcon")>] member inline _.ThumbIcon (render: AttrRenderFragment, x: System.String) = render ==> ("ThumbIcon" => x)
    [<CustomOperation("ThumbIconColor")>] member inline _.ThumbIconColor (render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("ThumbIconColor" => x)
    [<CustomOperation("DisableRipple")>] member inline _.DisableRipple (render: AttrRenderFragment, x: System.Boolean) = render ==> ("DisableRipple" => x)
                

type MudPickerBuilder<'FunBlazorGeneric, 'T when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudFormComponentBuilder<'FunBlazorGeneric, 'T, System.String>()
    [<CustomOperation("AdornmentColor")>] member inline _.AdornmentColor (render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("AdornmentColor" => x)
    [<CustomOperation("AdornmentIcon")>] member inline _.AdornmentIcon (render: AttrRenderFragment, x: System.String) = render ==> ("AdornmentIcon" => x)
    [<CustomOperation("Placeholder")>] member inline _.Placeholder (render: AttrRenderFragment, x: System.String) = render ==> ("Placeholder" => x)
    [<CustomOperation("PickerOpened")>] member inline _.PickerOpened (render: AttrRenderFragment, fn) = render ==> html.callback<unit>("PickerOpened", fn)
    [<CustomOperation("PickerClosed")>] member inline _.PickerClosed (render: AttrRenderFragment, fn) = render ==> html.callback<unit>("PickerClosed", fn)
    [<CustomOperation("Elevation")>] member inline _.Elevation (render: AttrRenderFragment, x: System.Int32) = render ==> ("Elevation" => x)
    [<CustomOperation("Square")>] member inline _.Square (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Square" => x)
    [<CustomOperation("ReadOnly")>] member inline _.ReadOnly (render: AttrRenderFragment, x: System.Boolean) = render ==> ("ReadOnly" => x)
    [<CustomOperation("Rounded")>] member inline _.Rounded (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Rounded" => x)
    [<CustomOperation("HelperText")>] member inline _.HelperText (render: AttrRenderFragment, x: System.String) = render ==> ("HelperText" => x)
    [<CustomOperation("HelperTextOnFocus")>] member inline _.HelperTextOnFocus (render: AttrRenderFragment, x: System.Boolean) = render ==> ("HelperTextOnFocus" => x)
    [<CustomOperation("Label")>] member inline _.Label (render: AttrRenderFragment, x: System.String) = render ==> ("Label" => x)
    [<CustomOperation("Disabled")>] member inline _.Disabled (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Disabled" => x)
    [<CustomOperation("Editable")>] member inline _.Editable (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Editable" => x)
    [<CustomOperation("DisableToolbar")>] member inline _.DisableToolbar (render: AttrRenderFragment, x: System.Boolean) = render ==> ("DisableToolbar" => x)
    [<CustomOperation("ToolBarClass")>] member inline _.ToolBarClass (render: AttrRenderFragment, x: System.String) = render ==> ("ToolBarClass" => x)
    [<CustomOperation("PickerVariant")>] member inline _.PickerVariant (render: AttrRenderFragment, x: MudBlazor.PickerVariant) = render ==> ("PickerVariant" => x)
    [<CustomOperation("Variant")>] member inline _.Variant (render: AttrRenderFragment, x: MudBlazor.Variant) = render ==> ("Variant" => x)
    [<CustomOperation("Adornment")>] member inline _.Adornment (render: AttrRenderFragment, x: MudBlazor.Adornment) = render ==> ("Adornment" => x)
    [<CustomOperation("Orientation")>] member inline _.Orientation (render: AttrRenderFragment, x: MudBlazor.Orientation) = render ==> ("Orientation" => x)
    [<CustomOperation("IconSize")>] member inline _.IconSize (render: AttrRenderFragment, x: MudBlazor.Size) = render ==> ("IconSize" => x)
    [<CustomOperation("Color")>] member inline _.Color (render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("Color" => x)
    [<CustomOperation("AllowKeyboardInput")>] member inline _.AllowKeyboardInput (render: AttrRenderFragment, x: System.Boolean) = render ==> ("AllowKeyboardInput" => x)
    [<CustomOperation("TextChanged")>] member inline _.TextChanged (render: AttrRenderFragment, fn) = render ==> html.callback<System.String>("TextChanged", fn)
    [<CustomOperation("Text")>] member inline _.Text (render: AttrRenderFragment, x: System.String) = render ==> ("Text" => x)
    [<CustomOperation("Text'")>] member inline _.Text' (render: AttrRenderFragment, value: IStore<System.String>) = render ==> html.bind("Text", value)
    [<CustomOperation("Text'")>] member inline _.Text' (render: AttrRenderFragment, value: cval<System.String>) = render ==> html.bind("Text", value)
    [<CustomOperation("Text'")>] member inline _.Text' (render: AttrRenderFragment, valueFn: System.String * (System.String -> unit)) = render ==> html.bind("Text", valueFn)
    [<CustomOperation("ClassActions")>] member inline _.ClassActions (render: AttrRenderFragment, x: System.String) = render ==> ("ClassActions" => x)
    [<CustomOperation("PickerActions")>] member inline _.PickerActions (render: AttrRenderFragment, fragment) = render ==> html.renderFragment("PickerActions", fragment)
    [<CustomOperation("PickerActions")>] member inline _.PickerActions (render: AttrRenderFragment, x: string) = render ==> html.renderFragment("PickerActions", html.text x)
    [<CustomOperation("PickerActions")>] member inline _.PickerActions (render: AttrRenderFragment, x: int) = render ==> html.renderFragment("PickerActions", html.text x)
    [<CustomOperation("PickerActions")>] member inline _.PickerActions (render: AttrRenderFragment, x: float) = render ==> html.renderFragment("PickerActions", html.text x)
    [<CustomOperation("Margin")>] member inline _.Margin (render: AttrRenderFragment, x: MudBlazor.Margin) = render ==> ("Margin" => x)
                

type MudBaseDatePickerBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudPickerBuilder<'FunBlazorGeneric, System.Nullable<System.DateTime>>()
    [<CustomOperation("MaxDate")>] member inline _.MaxDate (render: AttrRenderFragment, x: System.Nullable<System.DateTime>) = render ==> ("MaxDate" => x)
    [<CustomOperation("MinDate")>] member inline _.MinDate (render: AttrRenderFragment, x: System.Nullable<System.DateTime>) = render ==> ("MinDate" => x)
    [<CustomOperation("OpenTo")>] member inline _.OpenTo (render: AttrRenderFragment, x: MudBlazor.OpenTo) = render ==> ("OpenTo" => x)
    [<CustomOperation("DateFormat")>] member inline _.DateFormat (render: AttrRenderFragment, x: System.String) = render ==> ("DateFormat" => x)
    [<CustomOperation("FirstDayOfWeek")>] member inline _.FirstDayOfWeek (render: AttrRenderFragment, x: System.Nullable<System.DayOfWeek>) = render ==> ("FirstDayOfWeek" => x)
    [<CustomOperation("PickerMonth")>] member inline _.PickerMonth (render: AttrRenderFragment, x: System.Nullable<System.DateTime>) = render ==> ("PickerMonth" => x)
    [<CustomOperation("PickerMonth'")>] member inline _.PickerMonth' (render: AttrRenderFragment, value: IStore<System.Nullable<System.DateTime>>) = render ==> html.bind("PickerMonth", value)
    [<CustomOperation("PickerMonth'")>] member inline _.PickerMonth' (render: AttrRenderFragment, value: cval<System.Nullable<System.DateTime>>) = render ==> html.bind("PickerMonth", value)
    [<CustomOperation("PickerMonth'")>] member inline _.PickerMonth' (render: AttrRenderFragment, valueFn: System.Nullable<System.DateTime> * (System.Nullable<System.DateTime> -> unit)) = render ==> html.bind("PickerMonth", valueFn)
    [<CustomOperation("PickerMonthChanged")>] member inline _.PickerMonthChanged (render: AttrRenderFragment, fn) = render ==> html.callback<System.Nullable<System.DateTime>>("PickerMonthChanged", fn)
    [<CustomOperation("ClosingDelay")>] member inline _.ClosingDelay (render: AttrRenderFragment, x: System.Int32) = render ==> ("ClosingDelay" => x)
    [<CustomOperation("DisplayMonths")>] member inline _.DisplayMonths (render: AttrRenderFragment, x: System.Int32) = render ==> ("DisplayMonths" => x)
    [<CustomOperation("MaxMonthColumns")>] member inline _.MaxMonthColumns (render: AttrRenderFragment, x: System.Nullable<System.Int32>) = render ==> ("MaxMonthColumns" => x)
    [<CustomOperation("StartMonth")>] member inline _.StartMonth (render: AttrRenderFragment, x: System.Nullable<System.DateTime>) = render ==> ("StartMonth" => x)
    [<CustomOperation("ShowWeekNumbers")>] member inline _.ShowWeekNumbers (render: AttrRenderFragment, x: System.Boolean) = render ==> ("ShowWeekNumbers" => x)
    [<CustomOperation("TitleDateFormat")>] member inline _.TitleDateFormat (render: AttrRenderFragment, x: System.String) = render ==> ("TitleDateFormat" => x)
    [<CustomOperation("IsDateDisabledFunc")>] member inline _.IsDateDisabledFunc (render: AttrRenderFragment, fn) = render ==> ("IsDateDisabledFunc" => (System.Func<System.DateTime, System.Boolean>fn))
    [<CustomOperation("PreviousIcon")>] member inline _.PreviousIcon (render: AttrRenderFragment, x: System.String) = render ==> ("PreviousIcon" => x)
    [<CustomOperation("NextIcon")>] member inline _.NextIcon (render: AttrRenderFragment, x: System.String) = render ==> ("NextIcon" => x)
    [<CustomOperation("FixYear")>] member inline _.FixYear (render: AttrRenderFragment, x: System.Nullable<System.Int32>) = render ==> ("FixYear" => x)
    [<CustomOperation("FixMonth")>] member inline _.FixMonth (render: AttrRenderFragment, x: System.Nullable<System.Int32>) = render ==> ("FixMonth" => x)
    [<CustomOperation("FixDay")>] member inline _.FixDay (render: AttrRenderFragment, x: System.Nullable<System.Int32>) = render ==> ("FixDay" => x)
                

type MudDatePickerBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudBaseDatePickerBuilder<'FunBlazorGeneric>()
    [<CustomOperation("DateChanged")>] member inline _.DateChanged (render: AttrRenderFragment, fn) = render ==> html.callback<System.Nullable<System.DateTime>>("DateChanged", fn)
    [<CustomOperation("Date")>] member inline _.Date (render: AttrRenderFragment, x: System.Nullable<System.DateTime>) = render ==> ("Date" => x)
    [<CustomOperation("Date'")>] member inline _.Date' (render: AttrRenderFragment, value: IStore<System.Nullable<System.DateTime>>) = render ==> html.bind("Date", value)
    [<CustomOperation("Date'")>] member inline _.Date' (render: AttrRenderFragment, value: cval<System.Nullable<System.DateTime>>) = render ==> html.bind("Date", value)
    [<CustomOperation("Date'")>] member inline _.Date' (render: AttrRenderFragment, valueFn: System.Nullable<System.DateTime> * (System.Nullable<System.DateTime> -> unit)) = render ==> html.bind("Date", valueFn)
    [<CustomOperation("AutoClose")>] member inline _.AutoClose (render: AttrRenderFragment, x: System.Boolean) = render ==> ("AutoClose" => x)
                

type MudDateRangePickerBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudBaseDatePickerBuilder<'FunBlazorGeneric>()
    [<CustomOperation("DateRangeChanged")>] member inline _.DateRangeChanged (render: AttrRenderFragment, fn) = render ==> html.callback<MudBlazor.DateRange>("DateRangeChanged", fn)
    [<CustomOperation("DateRange")>] member inline _.DateRange (render: AttrRenderFragment, x: MudBlazor.DateRange) = render ==> ("DateRange" => x)
    [<CustomOperation("DateRange'")>] member inline _.DateRange' (render: AttrRenderFragment, value: IStore<MudBlazor.DateRange>) = render ==> html.bind("DateRange", value)
    [<CustomOperation("DateRange'")>] member inline _.DateRange' (render: AttrRenderFragment, value: cval<MudBlazor.DateRange>) = render ==> html.bind("DateRange", value)
    [<CustomOperation("DateRange'")>] member inline _.DateRange' (render: AttrRenderFragment, valueFn: MudBlazor.DateRange * (MudBlazor.DateRange -> unit)) = render ==> html.bind("DateRange", valueFn)
                

type MudColorPickerBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudPickerBuilder<'FunBlazorGeneric, MudBlazor.Utilities.MudColor>()
    [<CustomOperation("DisableAlpha")>] member inline _.DisableAlpha (render: AttrRenderFragment, x: System.Boolean) = render ==> ("DisableAlpha" => x)
    [<CustomOperation("DisableColorField")>] member inline _.DisableColorField (render: AttrRenderFragment, x: System.Boolean) = render ==> ("DisableColorField" => x)
    [<CustomOperation("DisableModeSwitch")>] member inline _.DisableModeSwitch (render: AttrRenderFragment, x: System.Boolean) = render ==> ("DisableModeSwitch" => x)
    [<CustomOperation("DisableInputs")>] member inline _.DisableInputs (render: AttrRenderFragment, x: System.Boolean) = render ==> ("DisableInputs" => x)
    [<CustomOperation("DisableSliders")>] member inline _.DisableSliders (render: AttrRenderFragment, x: System.Boolean) = render ==> ("DisableSliders" => x)
    [<CustomOperation("DisablePreview")>] member inline _.DisablePreview (render: AttrRenderFragment, x: System.Boolean) = render ==> ("DisablePreview" => x)
    [<CustomOperation("ColorPickerMode")>] member inline _.ColorPickerMode (render: AttrRenderFragment, x: MudBlazor.ColorPickerMode) = render ==> ("ColorPickerMode" => x)
    [<CustomOperation("ColorPickerView")>] member inline _.ColorPickerView (render: AttrRenderFragment, x: MudBlazor.ColorPickerView) = render ==> ("ColorPickerView" => x)
    [<CustomOperation("UpdateBindingIfOnlyHSLChanged")>] member inline _.UpdateBindingIfOnlyHSLChanged (render: AttrRenderFragment, x: System.Boolean) = render ==> ("UpdateBindingIfOnlyHSLChanged" => x)
    [<CustomOperation("Value")>] member inline _.Value (render: AttrRenderFragment, x: MudBlazor.Utilities.MudColor) = render ==> ("Value" => x)
    [<CustomOperation("Value'")>] member inline _.Value' (render: AttrRenderFragment, value: IStore<MudBlazor.Utilities.MudColor>) = render ==> html.bind("Value", value)
    [<CustomOperation("Value'")>] member inline _.Value' (render: AttrRenderFragment, value: cval<MudBlazor.Utilities.MudColor>) = render ==> html.bind("Value", value)
    [<CustomOperation("Value'")>] member inline _.Value' (render: AttrRenderFragment, valueFn: MudBlazor.Utilities.MudColor * (MudBlazor.Utilities.MudColor -> unit)) = render ==> html.bind("Value", valueFn)
    [<CustomOperation("ValueChanged")>] member inline _.ValueChanged (render: AttrRenderFragment, fn) = render ==> html.callback<MudBlazor.Utilities.MudColor>("ValueChanged", fn)
    [<CustomOperation("Palette")>] member inline _.Palette (render: AttrRenderFragment, x: System.Collections.Generic.IEnumerable<MudBlazor.Utilities.MudColor>) = render ==> ("Palette" => x)
    [<CustomOperation("DisableDragEffect")>] member inline _.DisableDragEffect (render: AttrRenderFragment, x: System.Boolean) = render ==> ("DisableDragEffect" => x)
    [<CustomOperation("CloseIcon")>] member inline _.CloseIcon (render: AttrRenderFragment, x: System.String) = render ==> ("CloseIcon" => x)
    [<CustomOperation("SpectrumIcon")>] member inline _.SpectrumIcon (render: AttrRenderFragment, x: System.String) = render ==> ("SpectrumIcon" => x)
    [<CustomOperation("GridIcon")>] member inline _.GridIcon (render: AttrRenderFragment, x: System.String) = render ==> ("GridIcon" => x)
    [<CustomOperation("PaletteIcon")>] member inline _.PaletteIcon (render: AttrRenderFragment, x: System.String) = render ==> ("PaletteIcon" => x)
    [<CustomOperation("ImportExportIcon")>] member inline _.ImportExportIcon (render: AttrRenderFragment, x: System.String) = render ==> ("ImportExportIcon" => x)
                

type MudTimePickerBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudPickerBuilder<'FunBlazorGeneric, System.Nullable<System.TimeSpan>>()
    [<CustomOperation("OpenTo")>] member inline _.OpenTo (render: AttrRenderFragment, x: MudBlazor.OpenTo) = render ==> ("OpenTo" => x)
    [<CustomOperation("TimeEditMode")>] member inline _.TimeEditMode (render: AttrRenderFragment, x: MudBlazor.TimeEditMode) = render ==> ("TimeEditMode" => x)
    [<CustomOperation("ClosingDelay")>] member inline _.ClosingDelay (render: AttrRenderFragment, x: System.Int32) = render ==> ("ClosingDelay" => x)
    [<CustomOperation("AutoClose")>] member inline _.AutoClose (render: AttrRenderFragment, x: System.Boolean) = render ==> ("AutoClose" => x)
    [<CustomOperation("AmPm")>] member inline _.AmPm (render: AttrRenderFragment, x: System.Boolean) = render ==> ("AmPm" => x)
    [<CustomOperation("TimeFormat")>] member inline _.TimeFormat (render: AttrRenderFragment, x: System.String) = render ==> ("TimeFormat" => x)
    [<CustomOperation("Time")>] member inline _.Time (render: AttrRenderFragment, x: System.Nullable<System.TimeSpan>) = render ==> ("Time" => x)
    [<CustomOperation("Time'")>] member inline _.Time' (render: AttrRenderFragment, value: IStore<System.Nullable<System.TimeSpan>>) = render ==> html.bind("Time", value)
    [<CustomOperation("Time'")>] member inline _.Time' (render: AttrRenderFragment, value: cval<System.Nullable<System.TimeSpan>>) = render ==> html.bind("Time", value)
    [<CustomOperation("Time'")>] member inline _.Time' (render: AttrRenderFragment, valueFn: System.Nullable<System.TimeSpan> * (System.Nullable<System.TimeSpan> -> unit)) = render ==> html.bind("Time", valueFn)
    [<CustomOperation("TimeChanged")>] member inline _.TimeChanged (render: AttrRenderFragment, fn) = render ==> html.callback<System.Nullable<System.TimeSpan>>("TimeChanged", fn)
                

type MudRadioGroupBuilder<'FunBlazorGeneric, 'T when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudFormComponentBuilder<'FunBlazorGeneric, 'T, 'T>()
    [<CustomOperation("Name")>] member inline _.Name (render: AttrRenderFragment, x: System.String) = render ==> ("Name" => x)
    [<CustomOperation("SelectedOption")>] member inline _.SelectedOption (render: AttrRenderFragment, x: 'T) = render ==> ("SelectedOption" => x)
    [<CustomOperation("SelectedOption'")>] member inline _.SelectedOption' (render: AttrRenderFragment, value: IStore<'T>) = render ==> html.bind("SelectedOption", value)
    [<CustomOperation("SelectedOption'")>] member inline _.SelectedOption' (render: AttrRenderFragment, value: cval<'T>) = render ==> html.bind("SelectedOption", value)
    [<CustomOperation("SelectedOption'")>] member inline _.SelectedOption' (render: AttrRenderFragment, valueFn: 'T * ('T -> unit)) = render ==> html.bind("SelectedOption", valueFn)
    [<CustomOperation("SelectedOptionChanged")>] member inline _.SelectedOptionChanged (render: AttrRenderFragment, fn) = render ==> html.callback<'T>("SelectedOptionChanged", fn)
                

type MudAlertBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("ContentAlignment")>] member inline _.ContentAlignment (render: AttrRenderFragment, x: MudBlazor.HorizontalAlignment) = render ==> ("ContentAlignment" => x)
    [<CustomOperation("CloseIconClicked")>] member inline _.CloseIconClicked (render: AttrRenderFragment, fn) = render ==> html.callback<MudBlazor.MudAlert>("CloseIconClicked", fn)
    [<CustomOperation("CloseIcon")>] member inline _.CloseIcon (render: AttrRenderFragment, x: System.String) = render ==> ("CloseIcon" => x)
    [<CustomOperation("ShowCloseIcon")>] member inline _.ShowCloseIcon (render: AttrRenderFragment, x: System.Boolean) = render ==> ("ShowCloseIcon" => x)
    [<CustomOperation("Elevation")>] member inline _.Elevation (render: AttrRenderFragment, x: System.Int32) = render ==> ("Elevation" => x)
    [<CustomOperation("Square")>] member inline _.Square (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Square" => x)
    [<CustomOperation("Dense")>] member inline _.Dense (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Dense" => x)
    [<CustomOperation("NoIcon")>] member inline _.NoIcon (render: AttrRenderFragment, x: System.Boolean) = render ==> ("NoIcon" => x)
    [<CustomOperation("Severity")>] member inline _.Severity (render: AttrRenderFragment, x: MudBlazor.Severity) = render ==> ("Severity" => x)
    [<CustomOperation("Variant")>] member inline _.Variant (render: AttrRenderFragment, x: MudBlazor.Variant) = render ==> ("Variant" => x)
    [<CustomOperation("Icon")>] member inline _.Icon (render: AttrRenderFragment, x: System.String) = render ==> ("Icon" => x)
    [<CustomOperation("OnClick")>] member inline _.OnClick (render: AttrRenderFragment, fn) = render ==> html.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>("OnClick", fn)
                

type MudAppBarBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Bottom")>] member inline _.Bottom (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Bottom" => x)
    [<CustomOperation("Elevation")>] member inline _.Elevation (render: AttrRenderFragment, x: System.Int32) = render ==> ("Elevation" => x)
    [<CustomOperation("Dense")>] member inline _.Dense (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Dense" => x)
    [<CustomOperation("DisableGutters")>] member inline _.DisableGutters (render: AttrRenderFragment, x: System.Boolean) = render ==> ("DisableGutters" => x)
    [<CustomOperation("Color")>] member inline _.Color (render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("Color" => x)
    [<CustomOperation("Fixed")>] member inline _.Fixed (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Fixed" => x)
    [<CustomOperation("ToolBarClass")>] member inline _.ToolBarClass (render: AttrRenderFragment, x: System.String) = render ==> ("ToolBarClass" => x)
                

type MudAvatarBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Elevation")>] member inline _.Elevation (render: AttrRenderFragment, x: System.Int32) = render ==> ("Elevation" => x)
    [<CustomOperation("Square")>] member inline _.Square (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Square" => x)
    [<CustomOperation("Rounded")>] member inline _.Rounded (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Rounded" => x)
    [<CustomOperation("Image")>] member inline _.Image (render: AttrRenderFragment, x: System.String) = render ==> ("Image" => x)
    [<CustomOperation("Alt")>] member inline _.Alt (render: AttrRenderFragment, x: System.String) = render ==> ("Alt" => x)
    [<CustomOperation("Color")>] member inline _.Color (render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("Color" => x)
    [<CustomOperation("Size")>] member inline _.Size (render: AttrRenderFragment, x: MudBlazor.Size) = render ==> ("Size" => x)
    [<CustomOperation("Variant")>] member inline _.Variant (render: AttrRenderFragment, x: MudBlazor.Variant) = render ==> ("Variant" => x)
                

type MudAvatarGroupBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Spacing")>] member inline _.Spacing (render: AttrRenderFragment, x: System.Int32) = render ==> ("Spacing" => x)
    [<CustomOperation("Outlined")>] member inline _.Outlined (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Outlined" => x)
    [<CustomOperation("OutlineColor")>] member inline _.OutlineColor (render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("OutlineColor" => x)
    [<CustomOperation("MaxElevation")>] member inline _.MaxElevation (render: AttrRenderFragment, x: System.Int32) = render ==> ("MaxElevation" => x)
    [<CustomOperation("MaxSquare")>] member inline _.MaxSquare (render: AttrRenderFragment, x: System.Boolean) = render ==> ("MaxSquare" => x)
    [<CustomOperation("MaxRounded")>] member inline _.MaxRounded (render: AttrRenderFragment, x: System.Boolean) = render ==> ("MaxRounded" => x)
    [<CustomOperation("MaxColor")>] member inline _.MaxColor (render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("MaxColor" => x)
    [<CustomOperation("MaxSize")>] member inline _.MaxSize (render: AttrRenderFragment, x: MudBlazor.Size) = render ==> ("MaxSize" => x)
    [<CustomOperation("MaxVariant")>] member inline _.MaxVariant (render: AttrRenderFragment, x: MudBlazor.Variant) = render ==> ("MaxVariant" => x)
    [<CustomOperation("Max")>] member inline _.Max (render: AttrRenderFragment, x: System.Int32) = render ==> ("Max" => x)
    [<CustomOperation("MaxAvatarClass")>] member inline _.MaxAvatarClass (render: AttrRenderFragment, x: System.String) = render ==> ("MaxAvatarClass" => x)
                

type MudBadgeBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Origin")>] member inline _.Origin (render: AttrRenderFragment, x: MudBlazor.Origin) = render ==> ("Origin" => x)
    [<CustomOperation("Elevation")>] member inline _.Elevation (render: AttrRenderFragment, x: System.Int32) = render ==> ("Elevation" => x)
    [<CustomOperation("Visible")>] member inline _.Visible (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Visible" => x)
    [<CustomOperation("Color")>] member inline _.Color (render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("Color" => x)
    [<CustomOperation("Dot")>] member inline _.Dot (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Dot" => x)
    [<CustomOperation("Overlap")>] member inline _.Overlap (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Overlap" => x)
    [<CustomOperation("Bordered")>] member inline _.Bordered (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Bordered" => x)
    [<CustomOperation("Icon")>] member inline _.Icon (render: AttrRenderFragment, x: System.String) = render ==> ("Icon" => x)
    [<CustomOperation("Max")>] member inline _.Max (render: AttrRenderFragment, x: System.Int32) = render ==> ("Max" => x)
    [<CustomOperation("Content")>] member inline _.Content (render: AttrRenderFragment, x: System.Object) = render ==> ("Content" => x)
    [<CustomOperation("BadgeClass")>] member inline _.BadgeClass (render: AttrRenderFragment, x: System.String) = render ==> ("BadgeClass" => x)
    [<CustomOperation("OnClick")>] member inline _.OnClick (render: AttrRenderFragment, fn) = render ==> html.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>("OnClick", fn)
                

type MudBreadcrumbsBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Items")>] member inline _.Items (render: AttrRenderFragment, x: System.Collections.Generic.List<MudBlazor.BreadcrumbItem>) = render ==> ("Items" => x)
    [<CustomOperation("Separator")>] member inline _.Separator (render: AttrRenderFragment, x: System.String) = render ==> ("Separator" => x)
    [<CustomOperation("SeparatorTemplate")>] member inline _.SeparatorTemplate (render: AttrRenderFragment, fragment) = render ==> html.renderFragment("SeparatorTemplate", fragment)
    [<CustomOperation("SeparatorTemplate")>] member inline _.SeparatorTemplate (render: AttrRenderFragment, x: string) = render ==> html.renderFragment("SeparatorTemplate", html.text x)
    [<CustomOperation("SeparatorTemplate")>] member inline _.SeparatorTemplate (render: AttrRenderFragment, x: int) = render ==> html.renderFragment("SeparatorTemplate", html.text x)
    [<CustomOperation("SeparatorTemplate")>] member inline _.SeparatorTemplate (render: AttrRenderFragment, x: float) = render ==> html.renderFragment("SeparatorTemplate", html.text x)
    [<CustomOperation("ItemTemplate")>] member inline _.ItemTemplate (render: AttrRenderFragment, fn: MudBlazor.BreadcrumbItem -> NodeRenderFragment) = render ==> html.renderFragment("ItemTemplate", fn)
    [<CustomOperation("MaxItems")>] member inline _.MaxItems (render: AttrRenderFragment, x: System.Nullable<System.Byte>) = render ==> ("MaxItems" => x)
    [<CustomOperation("ExpanderIcon")>] member inline _.ExpanderIcon (render: AttrRenderFragment, x: System.String) = render ==> ("ExpanderIcon" => x)
                

type MudBreakpointProviderBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("OnBreakpointChanged")>] member inline _.OnBreakpointChanged (render: AttrRenderFragment, fn) = render ==> html.callback<MudBlazor.Breakpoint>("OnBreakpointChanged", fn)
                

type MudButtonGroupBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("OverrideStyles")>] member inline _.OverrideStyles (render: AttrRenderFragment, x: System.Boolean) = render ==> ("OverrideStyles" => x)
    [<CustomOperation("VerticalAlign")>] member inline _.VerticalAlign (render: AttrRenderFragment, x: System.Boolean) = render ==> ("VerticalAlign" => x)
    [<CustomOperation("DisableElevation")>] member inline _.DisableElevation (render: AttrRenderFragment, x: System.Boolean) = render ==> ("DisableElevation" => x)
    [<CustomOperation("Color")>] member inline _.Color (render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("Color" => x)
    [<CustomOperation("Size")>] member inline _.Size (render: AttrRenderFragment, x: MudBlazor.Size) = render ==> ("Size" => x)
    [<CustomOperation("Variant")>] member inline _.Variant (render: AttrRenderFragment, x: MudBlazor.Variant) = render ==> ("Variant" => x)
                

type MudToggleIconButtonBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Toggled")>] member inline _.Toggled (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Toggled" => x)
    [<CustomOperation("Toggled'")>] member inline _.Toggled' (render: AttrRenderFragment, value: IStore<System.Boolean>) = render ==> html.bind("Toggled", value)
    [<CustomOperation("Toggled'")>] member inline _.Toggled' (render: AttrRenderFragment, value: cval<System.Boolean>) = render ==> html.bind("Toggled", value)
    [<CustomOperation("Toggled'")>] member inline _.Toggled' (render: AttrRenderFragment, valueFn: System.Boolean * (System.Boolean -> unit)) = render ==> html.bind("Toggled", valueFn)
    [<CustomOperation("ToggledChanged")>] member inline _.ToggledChanged (render: AttrRenderFragment, fn) = render ==> html.callback<System.Boolean>("ToggledChanged", fn)
    [<CustomOperation("Icon")>] member inline _.Icon (render: AttrRenderFragment, x: System.String) = render ==> ("Icon" => x)
    [<CustomOperation("ToggledIcon")>] member inline _.ToggledIcon (render: AttrRenderFragment, x: System.String) = render ==> ("ToggledIcon" => x)
    [<CustomOperation("Title")>] member inline _.Title (render: AttrRenderFragment, x: System.String) = render ==> ("Title" => x)
    [<CustomOperation("ToggledTitle")>] member inline _.ToggledTitle (render: AttrRenderFragment, x: System.String) = render ==> ("ToggledTitle" => x)
    [<CustomOperation("Color")>] member inline _.Color (render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("Color" => x)
    [<CustomOperation("ToggledColor")>] member inline _.ToggledColor (render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("ToggledColor" => x)
    [<CustomOperation("Size")>] member inline _.Size (render: AttrRenderFragment, x: MudBlazor.Size) = render ==> ("Size" => x)
    [<CustomOperation("ToggledSize")>] member inline _.ToggledSize (render: AttrRenderFragment, x: MudBlazor.Size) = render ==> ("ToggledSize" => x)
    [<CustomOperation("Edge")>] member inline _.Edge (render: AttrRenderFragment, x: MudBlazor.Edge) = render ==> ("Edge" => x)
    [<CustomOperation("DisableRipple")>] member inline _.DisableRipple (render: AttrRenderFragment, x: System.Boolean) = render ==> ("DisableRipple" => x)
    [<CustomOperation("Disabled")>] member inline _.Disabled (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Disabled" => x)
    [<CustomOperation("Variant")>] member inline _.Variant (render: AttrRenderFragment, x: MudBlazor.Variant) = render ==> ("Variant" => x)
                

type MudCardBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Elevation")>] member inline _.Elevation (render: AttrRenderFragment, x: System.Int32) = render ==> ("Elevation" => x)
    [<CustomOperation("Square")>] member inline _.Square (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Square" => x)
    [<CustomOperation("Outlined")>] member inline _.Outlined (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Outlined" => x)
                

type MudCardActionsBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()

                

type MudCardContentBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()

                

type MudCardHeaderBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("CardHeaderAvatar")>] member inline _.CardHeaderAvatar (render: AttrRenderFragment, fragment) = render ==> html.renderFragment("CardHeaderAvatar", fragment)
    [<CustomOperation("CardHeaderAvatar")>] member inline _.CardHeaderAvatar (render: AttrRenderFragment, x: string) = render ==> html.renderFragment("CardHeaderAvatar", html.text x)
    [<CustomOperation("CardHeaderAvatar")>] member inline _.CardHeaderAvatar (render: AttrRenderFragment, x: int) = render ==> html.renderFragment("CardHeaderAvatar", html.text x)
    [<CustomOperation("CardHeaderAvatar")>] member inline _.CardHeaderAvatar (render: AttrRenderFragment, x: float) = render ==> html.renderFragment("CardHeaderAvatar", html.text x)
    [<CustomOperation("CardHeaderContent")>] member inline _.CardHeaderContent (render: AttrRenderFragment, fragment) = render ==> html.renderFragment("CardHeaderContent", fragment)
    [<CustomOperation("CardHeaderContent")>] member inline _.CardHeaderContent (render: AttrRenderFragment, x: string) = render ==> html.renderFragment("CardHeaderContent", html.text x)
    [<CustomOperation("CardHeaderContent")>] member inline _.CardHeaderContent (render: AttrRenderFragment, x: int) = render ==> html.renderFragment("CardHeaderContent", html.text x)
    [<CustomOperation("CardHeaderContent")>] member inline _.CardHeaderContent (render: AttrRenderFragment, x: float) = render ==> html.renderFragment("CardHeaderContent", html.text x)
    [<CustomOperation("CardHeaderActions")>] member inline _.CardHeaderActions (render: AttrRenderFragment, fragment) = render ==> html.renderFragment("CardHeaderActions", fragment)
    [<CustomOperation("CardHeaderActions")>] member inline _.CardHeaderActions (render: AttrRenderFragment, x: string) = render ==> html.renderFragment("CardHeaderActions", html.text x)
    [<CustomOperation("CardHeaderActions")>] member inline _.CardHeaderActions (render: AttrRenderFragment, x: int) = render ==> html.renderFragment("CardHeaderActions", html.text x)
    [<CustomOperation("CardHeaderActions")>] member inline _.CardHeaderActions (render: AttrRenderFragment, x: float) = render ==> html.renderFragment("CardHeaderActions", html.text x)
                

type MudCardMediaBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Title")>] member inline _.Title (render: AttrRenderFragment, x: System.String) = render ==> ("Title" => x)
    [<CustomOperation("Image")>] member inline _.Image (render: AttrRenderFragment, x: System.String) = render ==> ("Image" => x)
    [<CustomOperation("Height")>] member inline _.Height (render: AttrRenderFragment, x: System.Int32) = render ==> ("Height" => x)
                

type MudCarouselItemBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Color")>] member inline _.Color (render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("Color" => x)
    [<CustomOperation("Transition")>] member inline _.Transition (render: AttrRenderFragment, x: MudBlazor.Transition) = render ==> ("Transition" => x)
    [<CustomOperation("CustomTransitionEnter")>] member inline _.CustomTransitionEnter (render: AttrRenderFragment, x: System.String) = render ==> ("CustomTransitionEnter" => x)
    [<CustomOperation("CustomTransitionExit")>] member inline _.CustomTransitionExit (render: AttrRenderFragment, x: System.String) = render ==> ("CustomTransitionExit" => x)
                

type MudChipSetBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("MultiSelection")>] member inline _.MultiSelection (render: AttrRenderFragment, x: System.Boolean) = render ==> ("MultiSelection" => x)
    [<CustomOperation("Mandatory")>] member inline _.Mandatory (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Mandatory" => x)
    [<CustomOperation("AllClosable")>] member inline _.AllClosable (render: AttrRenderFragment, x: System.Boolean) = render ==> ("AllClosable" => x)
    [<CustomOperation("Filter")>] member inline _.Filter (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Filter" => x)
    [<CustomOperation("ReadOnly")>] member inline _.ReadOnly (render: AttrRenderFragment, x: System.Boolean) = render ==> ("ReadOnly" => x)
    [<CustomOperation("SelectedChip")>] member inline _.SelectedChip (render: AttrRenderFragment, x: MudBlazor.MudChip) = render ==> ("SelectedChip" => x)
    [<CustomOperation("SelectedChip'")>] member inline _.SelectedChip' (render: AttrRenderFragment, value: IStore<MudBlazor.MudChip>) = render ==> html.bind("SelectedChip", value)
    [<CustomOperation("SelectedChip'")>] member inline _.SelectedChip' (render: AttrRenderFragment, value: cval<MudBlazor.MudChip>) = render ==> html.bind("SelectedChip", value)
    [<CustomOperation("SelectedChip'")>] member inline _.SelectedChip' (render: AttrRenderFragment, valueFn: MudBlazor.MudChip * (MudBlazor.MudChip -> unit)) = render ==> html.bind("SelectedChip", valueFn)
    [<CustomOperation("SelectedChipChanged")>] member inline _.SelectedChipChanged (render: AttrRenderFragment, fn) = render ==> html.callback<MudBlazor.MudChip>("SelectedChipChanged", fn)
    [<CustomOperation("SelectedChips")>] member inline _.SelectedChips (render: AttrRenderFragment, x: MudBlazor.MudChip[]) = render ==> ("SelectedChips" => x)
    [<CustomOperation("SelectedChips'")>] member inline _.SelectedChips' (render: AttrRenderFragment, value: IStore<MudBlazor.MudChip[]>) = render ==> html.bind("SelectedChips", value)
    [<CustomOperation("SelectedChips'")>] member inline _.SelectedChips' (render: AttrRenderFragment, value: cval<MudBlazor.MudChip[]>) = render ==> html.bind("SelectedChips", value)
    [<CustomOperation("SelectedChips'")>] member inline _.SelectedChips' (render: AttrRenderFragment, valueFn: MudBlazor.MudChip[] * (MudBlazor.MudChip[] -> unit)) = render ==> html.bind("SelectedChips", valueFn)
    [<CustomOperation("Comparer")>] member inline _.Comparer (render: AttrRenderFragment, x: System.Collections.Generic.IEqualityComparer<System.Object>) = render ==> ("Comparer" => x)
    [<CustomOperation("SelectedChipsChanged")>] member inline _.SelectedChipsChanged (render: AttrRenderFragment, fn) = render ==> html.callback<MudBlazor.MudChip[]>("SelectedChipsChanged", fn)
    [<CustomOperation("SelectedValues")>] member inline _.SelectedValues (render: AttrRenderFragment, x: System.Collections.Generic.ICollection<System.Object>) = render ==> ("SelectedValues" => x)
    [<CustomOperation("SelectedValues'")>] member inline _.SelectedValues' (render: AttrRenderFragment, value: IStore<System.Collections.Generic.ICollection<System.Object>>) = render ==> html.bind("SelectedValues", value)
    [<CustomOperation("SelectedValues'")>] member inline _.SelectedValues' (render: AttrRenderFragment, value: cval<System.Collections.Generic.ICollection<System.Object>>) = render ==> html.bind("SelectedValues", value)
    [<CustomOperation("SelectedValues'")>] member inline _.SelectedValues' (render: AttrRenderFragment, valueFn: System.Collections.Generic.ICollection<System.Object> * (System.Collections.Generic.ICollection<System.Object> -> unit)) = render ==> html.bind("SelectedValues", valueFn)
    [<CustomOperation("SelectedValuesChanged")>] member inline _.SelectedValuesChanged (render: AttrRenderFragment, fn) = render ==> html.callback<System.Collections.Generic.ICollection<System.Object>>("SelectedValuesChanged", fn)
    [<CustomOperation("OnClose")>] member inline _.OnClose (render: AttrRenderFragment, fn) = render ==> html.callback<MudBlazor.MudChip>("OnClose", fn)
                

type MudChipBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Color")>] member inline _.Color (render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("Color" => x)
    [<CustomOperation("Size")>] member inline _.Size (render: AttrRenderFragment, x: MudBlazor.Size) = render ==> ("Size" => x)
    [<CustomOperation("Variant")>] member inline _.Variant (render: AttrRenderFragment, x: MudBlazor.Variant) = render ==> ("Variant" => x)
    [<CustomOperation("SelectedColor")>] member inline _.SelectedColor (render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("SelectedColor" => x)
    [<CustomOperation("Avatar")>] member inline _.Avatar (render: AttrRenderFragment, x: System.String) = render ==> ("Avatar" => x)
    [<CustomOperation("AvatarClass")>] member inline _.AvatarClass (render: AttrRenderFragment, x: System.String) = render ==> ("AvatarClass" => x)
    [<CustomOperation("Label")>] member inline _.Label (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Label" => x)
    [<CustomOperation("Disabled")>] member inline _.Disabled (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Disabled" => x)
    [<CustomOperation("Icon")>] member inline _.Icon (render: AttrRenderFragment, x: System.String) = render ==> ("Icon" => x)
    [<CustomOperation("CheckedIcon")>] member inline _.CheckedIcon (render: AttrRenderFragment, x: System.String) = render ==> ("CheckedIcon" => x)
    [<CustomOperation("IconColor")>] member inline _.IconColor (render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("IconColor" => x)
    [<CustomOperation("CloseIcon")>] member inline _.CloseIcon (render: AttrRenderFragment, x: System.String) = render ==> ("CloseIcon" => x)
    [<CustomOperation("DisableRipple")>] member inline _.DisableRipple (render: AttrRenderFragment, x: System.Boolean) = render ==> ("DisableRipple" => x)
    [<CustomOperation("Link")>] member inline _.Link (render: AttrRenderFragment, x: System.String) = render ==> ("Link" => x)
    [<CustomOperation("Target")>] member inline _.Target (render: AttrRenderFragment, x: System.String) = render ==> ("Target" => x)
    [<CustomOperation("Text")>] member inline _.Text (render: AttrRenderFragment, x: System.String) = render ==> ("Text" => x)
    [<CustomOperation("Value")>] member inline _.Value (render: AttrRenderFragment, x: System.Object) = render ==> ("Value" => x)
    [<CustomOperation("ForceLoad")>] member inline _.ForceLoad (render: AttrRenderFragment, x: System.Boolean) = render ==> ("ForceLoad" => x)
    [<CustomOperation("Default")>] member inline _.Default (render: AttrRenderFragment, x: System.Nullable<System.Boolean>) = render ==> ("Default" => x)
    [<CustomOperation("Command")>] member inline _.Command (render: AttrRenderFragment, x: System.Windows.Input.ICommand) = render ==> ("Command" => x)
    [<CustomOperation("CommandParameter")>] member inline _.CommandParameter (render: AttrRenderFragment, x: System.Object) = render ==> ("CommandParameter" => x)
    [<CustomOperation("OnClick")>] member inline _.OnClick (render: AttrRenderFragment, fn) = render ==> html.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>("OnClick", fn)
    [<CustomOperation("OnClose")>] member inline _.OnClose (render: AttrRenderFragment, fn) = render ==> html.callback<MudBlazor.MudChip>("OnClose", fn)
                

type MudCollapseBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Expanded")>] member inline _.Expanded (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Expanded" => x)
    [<CustomOperation("Expanded'")>] member inline _.Expanded' (render: AttrRenderFragment, value: IStore<System.Boolean>) = render ==> html.bind("Expanded", value)
    [<CustomOperation("Expanded'")>] member inline _.Expanded' (render: AttrRenderFragment, value: cval<System.Boolean>) = render ==> html.bind("Expanded", value)
    [<CustomOperation("Expanded'")>] member inline _.Expanded' (render: AttrRenderFragment, valueFn: System.Boolean * (System.Boolean -> unit)) = render ==> html.bind("Expanded", valueFn)
    [<CustomOperation("MaxHeight")>] member inline _.MaxHeight (render: AttrRenderFragment, x: System.Nullable<System.Int32>) = render ==> ("MaxHeight" => x)
    [<CustomOperation("OnAnimationEnd")>] member inline _.OnAnimationEnd (render: AttrRenderFragment, fn) = render ==> html.callback<unit>("OnAnimationEnd", fn)
    [<CustomOperation("ExpandedChanged")>] member inline _.ExpandedChanged (render: AttrRenderFragment, fn) = render ==> html.callback<System.Boolean>("ExpandedChanged", fn)
                

type CellBuilder<'FunBlazorGeneric, 'T when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Item")>] member inline _.Item (render: AttrRenderFragment, x: 'T) = render ==> ("Item" => x)
    [<CustomOperation("Title")>] member inline _.Title (render: AttrRenderFragment, x: System.String) = render ==> ("Title" => x)
    [<CustomOperation("Field")>] member inline _.Field (render: AttrRenderFragment, x: System.String) = render ==> ("Field" => x)
    [<CustomOperation("CellTemplate")>] member inline _.CellTemplate (render: AttrRenderFragment, fn: 'T -> NodeRenderFragment) = render ==> html.renderFragment("CellTemplate", fn)
    [<CustomOperation("EditTemplate")>] member inline _.EditTemplate (render: AttrRenderFragment, fn: 'T -> NodeRenderFragment) = render ==> html.renderFragment("EditTemplate", fn)
    [<CustomOperation("ColumnType")>] member inline _.ColumnType (render: AttrRenderFragment, x: MudBlazor.ColumnType) = render ==> ("ColumnType" => x)
    [<CustomOperation("IsEditable")>] member inline _.IsEditable (render: AttrRenderFragment, x: System.Boolean) = render ==> ("IsEditable" => x)
    [<CustomOperation("CellClass")>] member inline _.CellClass (render: AttrRenderFragment, x: System.String) = render ==> ("CellClass" => x)
    [<CustomOperation("CellStyle")>] member inline _.CellStyle (render: AttrRenderFragment, x: System.String) = render ==> ("CellStyle" => x)
    [<CustomOperation("CellClassFunc")>] member inline _.CellClassFunc (render: AttrRenderFragment, fn) = render ==> ("CellClassFunc" => (System.Func<'T, System.String>fn))
    [<CustomOperation("CellStyleFunc")>] member inline _.CellStyleFunc (render: AttrRenderFragment, fn) = render ==> ("CellStyleFunc" => (System.Func<'T, System.String>fn))
                

type ColumnBuilder<'FunBlazorGeneric, 'T when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Value")>] member inline _.Value (render: AttrRenderFragment, x: 'T) = render ==> ("Value" => x)
    [<CustomOperation("Value'")>] member inline _.Value' (render: AttrRenderFragment, value: IStore<'T>) = render ==> html.bind("Value", value)
    [<CustomOperation("Value'")>] member inline _.Value' (render: AttrRenderFragment, value: cval<'T>) = render ==> html.bind("Value", value)
    [<CustomOperation("Value'")>] member inline _.Value' (render: AttrRenderFragment, valueFn: 'T * ('T -> unit)) = render ==> html.bind("Value", valueFn)
    [<CustomOperation("ValueChanged")>] member inline _.ValueChanged (render: AttrRenderFragment, fn) = render ==> html.callback<'T>("ValueChanged", fn)
    [<CustomOperation("Visible")>] member inline _.Visible (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Visible" => x)
    [<CustomOperation("Field")>] member inline _.Field (render: AttrRenderFragment, x: System.String) = render ==> ("Field" => x)
    [<CustomOperation("Title")>] member inline _.Title (render: AttrRenderFragment, x: System.String) = render ==> ("Title" => x)
    [<CustomOperation("HideSmall")>] member inline _.HideSmall (render: AttrRenderFragment, x: System.Boolean) = render ==> ("HideSmall" => x)
    [<CustomOperation("FooterColSpan")>] member inline _.FooterColSpan (render: AttrRenderFragment, x: System.Int32) = render ==> ("FooterColSpan" => x)
    [<CustomOperation("HeaderColSpan")>] member inline _.HeaderColSpan (render: AttrRenderFragment, x: System.Int32) = render ==> ("HeaderColSpan" => x)
    [<CustomOperation("Type")>] member inline _.Type (render: AttrRenderFragment, x: MudBlazor.ColumnType) = render ==> ("Type" => x)
    [<CustomOperation("HeaderTemplate")>] member inline _.HeaderTemplate (render: AttrRenderFragment, fragment) = render ==> html.renderFragment("HeaderTemplate", fragment)
    [<CustomOperation("HeaderTemplate")>] member inline _.HeaderTemplate (render: AttrRenderFragment, x: string) = render ==> html.renderFragment("HeaderTemplate", html.text x)
    [<CustomOperation("HeaderTemplate")>] member inline _.HeaderTemplate (render: AttrRenderFragment, x: int) = render ==> html.renderFragment("HeaderTemplate", html.text x)
    [<CustomOperation("HeaderTemplate")>] member inline _.HeaderTemplate (render: AttrRenderFragment, x: float) = render ==> html.renderFragment("HeaderTemplate", html.text x)
    [<CustomOperation("CellTemplate")>] member inline _.CellTemplate (render: AttrRenderFragment, fn: 'T -> NodeRenderFragment) = render ==> html.renderFragment("CellTemplate", fn)
    [<CustomOperation("FooterTemplate")>] member inline _.FooterTemplate (render: AttrRenderFragment, fragment) = render ==> html.renderFragment("FooterTemplate", fragment)
    [<CustomOperation("FooterTemplate")>] member inline _.FooterTemplate (render: AttrRenderFragment, x: string) = render ==> html.renderFragment("FooterTemplate", html.text x)
    [<CustomOperation("FooterTemplate")>] member inline _.FooterTemplate (render: AttrRenderFragment, x: int) = render ==> html.renderFragment("FooterTemplate", html.text x)
    [<CustomOperation("FooterTemplate")>] member inline _.FooterTemplate (render: AttrRenderFragment, x: float) = render ==> html.renderFragment("FooterTemplate", html.text x)
    [<CustomOperation("HeaderClass")>] member inline _.HeaderClass (render: AttrRenderFragment, x: System.String) = render ==> ("HeaderClass" => x)
    [<CustomOperation("HeaderClassFunc")>] member inline _.HeaderClassFunc (render: AttrRenderFragment, fn) = render ==> ("HeaderClassFunc" => (System.Func<'T, System.String>fn))
    [<CustomOperation("HeaderStyle")>] member inline _.HeaderStyle (render: AttrRenderFragment, x: System.String) = render ==> ("HeaderStyle" => x)
    [<CustomOperation("HeaderStyleFunc")>] member inline _.HeaderStyleFunc (render: AttrRenderFragment, fn) = render ==> ("HeaderStyleFunc" => (System.Func<'T, System.String>fn))
    [<CustomOperation("Sortable")>] member inline _.Sortable (render: AttrRenderFragment, x: System.Nullable<System.Boolean>) = render ==> ("Sortable" => x)
    [<CustomOperation("Filterable")>] member inline _.Filterable (render: AttrRenderFragment, x: System.Nullable<System.Boolean>) = render ==> ("Filterable" => x)
    [<CustomOperation("ShowColumnOptions")>] member inline _.ShowColumnOptions (render: AttrRenderFragment, x: System.Nullable<System.Boolean>) = render ==> ("ShowColumnOptions" => x)
    [<CustomOperation("SortBy")>] member inline _.SortBy (render: AttrRenderFragment, fn) = render ==> ("SortBy" => (System.Func<'T, System.Object>fn))
    [<CustomOperation("InitialDirection")>] member inline _.InitialDirection (render: AttrRenderFragment, x: MudBlazor.SortDirection) = render ==> ("InitialDirection" => x)
    [<CustomOperation("SortIcon")>] member inline _.SortIcon (render: AttrRenderFragment, x: System.String) = render ==> ("SortIcon" => x)
    [<CustomOperation("CellClass")>] member inline _.CellClass (render: AttrRenderFragment, x: System.String) = render ==> ("CellClass" => x)
    [<CustomOperation("CellClassFunc")>] member inline _.CellClassFunc (render: AttrRenderFragment, fn) = render ==> ("CellClassFunc" => (System.Func<'T, System.String>fn))
    [<CustomOperation("CellStyle")>] member inline _.CellStyle (render: AttrRenderFragment, x: System.String) = render ==> ("CellStyle" => x)
    [<CustomOperation("CellStyleFunc")>] member inline _.CellStyleFunc (render: AttrRenderFragment, fn) = render ==> ("CellStyleFunc" => (System.Func<'T, System.String>fn))
    [<CustomOperation("IsEditable")>] member inline _.IsEditable (render: AttrRenderFragment, x: System.Nullable<System.Boolean>) = render ==> ("IsEditable" => x)
    [<CustomOperation("EditTemplate")>] member inline _.EditTemplate (render: AttrRenderFragment, fn: 'T -> NodeRenderFragment) = render ==> html.renderFragment("EditTemplate", fn)
    [<CustomOperation("FooterClass")>] member inline _.FooterClass (render: AttrRenderFragment, x: System.String) = render ==> ("FooterClass" => x)
    [<CustomOperation("FooterClassFunc")>] member inline _.FooterClassFunc (render: AttrRenderFragment, fn) = render ==> ("FooterClassFunc" => (System.Func<'T, System.String>fn))
    [<CustomOperation("FooterStyle")>] member inline _.FooterStyle (render: AttrRenderFragment, x: System.String) = render ==> ("FooterStyle" => x)
    [<CustomOperation("FooterStyleFunc")>] member inline _.FooterStyleFunc (render: AttrRenderFragment, fn) = render ==> ("FooterStyleFunc" => (System.Func<'T, System.String>fn))
    [<CustomOperation("EnableFooterSelection")>] member inline _.EnableFooterSelection (render: AttrRenderFragment, x: System.Boolean) = render ==> ("EnableFooterSelection" => x)
                

type FooterCellBuilder<'FunBlazorGeneric, 'T when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("ColSpan")>] member inline _.ColSpan (render: AttrRenderFragment, x: System.Int32) = render ==> ("ColSpan" => x)
    [<CustomOperation("ColumnType")>] member inline _.ColumnType (render: AttrRenderFragment, x: MudBlazor.ColumnType) = render ==> ("ColumnType" => x)
    [<CustomOperation("FooterTemplate")>] member inline _.FooterTemplate (render: AttrRenderFragment, fragment) = render ==> html.renderFragment("FooterTemplate", fragment)
    [<CustomOperation("FooterTemplate")>] member inline _.FooterTemplate (render: AttrRenderFragment, x: string) = render ==> html.renderFragment("FooterTemplate", html.text x)
    [<CustomOperation("FooterTemplate")>] member inline _.FooterTemplate (render: AttrRenderFragment, x: int) = render ==> html.renderFragment("FooterTemplate", html.text x)
    [<CustomOperation("FooterTemplate")>] member inline _.FooterTemplate (render: AttrRenderFragment, x: float) = render ==> html.renderFragment("FooterTemplate", html.text x)
    [<CustomOperation("FooterClass")>] member inline _.FooterClass (render: AttrRenderFragment, x: System.String) = render ==> ("FooterClass" => x)
    [<CustomOperation("FooterStyle")>] member inline _.FooterStyle (render: AttrRenderFragment, x: System.String) = render ==> ("FooterStyle" => x)
                

type HeaderCellBuilder<'FunBlazorGeneric, 'T when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Title")>] member inline _.Title (render: AttrRenderFragment, x: System.String) = render ==> ("Title" => x)
    [<CustomOperation("Field")>] member inline _.Field (render: AttrRenderFragment, x: System.String) = render ==> ("Field" => x)
    [<CustomOperation("HeaderTemplate")>] member inline _.HeaderTemplate (render: AttrRenderFragment, fragment) = render ==> html.renderFragment("HeaderTemplate", fragment)
    [<CustomOperation("HeaderTemplate")>] member inline _.HeaderTemplate (render: AttrRenderFragment, x: string) = render ==> html.renderFragment("HeaderTemplate", html.text x)
    [<CustomOperation("HeaderTemplate")>] member inline _.HeaderTemplate (render: AttrRenderFragment, x: int) = render ==> html.renderFragment("HeaderTemplate", html.text x)
    [<CustomOperation("HeaderTemplate")>] member inline _.HeaderTemplate (render: AttrRenderFragment, x: float) = render ==> html.renderFragment("HeaderTemplate", html.text x)
    [<CustomOperation("ColSpan")>] member inline _.ColSpan (render: AttrRenderFragment, x: System.Int32) = render ==> ("ColSpan" => x)
    [<CustomOperation("ColumnType")>] member inline _.ColumnType (render: AttrRenderFragment, x: MudBlazor.ColumnType) = render ==> ("ColumnType" => x)
    [<CustomOperation("SortBy")>] member inline _.SortBy (render: AttrRenderFragment, fn) = render ==> ("SortBy" => (System.Func<'T, System.Object>fn))
    [<CustomOperation("SortIcon")>] member inline _.SortIcon (render: AttrRenderFragment, x: System.String) = render ==> ("SortIcon" => x)
    [<CustomOperation("InitialDirection")>] member inline _.InitialDirection (render: AttrRenderFragment, x: MudBlazor.SortDirection) = render ==> ("InitialDirection" => x)
    [<CustomOperation("Sortable")>] member inline _.Sortable (render: AttrRenderFragment, x: System.Nullable<System.Boolean>) = render ==> ("Sortable" => x)
    [<CustomOperation("Filterable")>] member inline _.Filterable (render: AttrRenderFragment, x: System.Nullable<System.Boolean>) = render ==> ("Filterable" => x)
    [<CustomOperation("ShowColumnOptions")>] member inline _.ShowColumnOptions (render: AttrRenderFragment, x: System.Nullable<System.Boolean>) = render ==> ("ShowColumnOptions" => x)
    [<CustomOperation("HeaderClass")>] member inline _.HeaderClass (render: AttrRenderFragment, x: System.String) = render ==> ("HeaderClass" => x)
    [<CustomOperation("HeaderStyle")>] member inline _.HeaderStyle (render: AttrRenderFragment, x: System.String) = render ==> ("HeaderStyle" => x)
                

type MudDataGridBuilder<'FunBlazorGeneric, 'T when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("SelectedItemChanged")>] member inline _.SelectedItemChanged (render: AttrRenderFragment, fn) = render ==> html.callback<'T>("SelectedItemChanged", fn)
    [<CustomOperation("SelectedItemsChanged")>] member inline _.SelectedItemsChanged (render: AttrRenderFragment, fn) = render ==> html.callback<System.Collections.Generic.HashSet<'T>>("SelectedItemsChanged", fn)
    [<CustomOperation("RowClick")>] member inline _.RowClick (render: AttrRenderFragment, fn) = render ==> html.callback<MudBlazor.DataGridRowClickEventArgs<'T>>("RowClick", fn)
    [<CustomOperation("StartedEditingItem")>] member inline _.StartedEditingItem (render: AttrRenderFragment, fn) = render ==> html.callback<'T>("StartedEditingItem", fn)
    [<CustomOperation("EditingItemCancelled")>] member inline _.EditingItemCancelled (render: AttrRenderFragment, fn) = render ==> html.callback<'T>("EditingItemCancelled", fn)
    [<CustomOperation("StartedCommittingItemChanges")>] member inline _.StartedCommittingItemChanges (render: AttrRenderFragment, fn) = render ==> html.callback<'T>("StartedCommittingItemChanges", fn)
    [<CustomOperation("Sortable")>] member inline _.Sortable (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Sortable" => x)
    [<CustomOperation("Filterable")>] member inline _.Filterable (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Filterable" => x)
    [<CustomOperation("ShowColumnOptions")>] member inline _.ShowColumnOptions (render: AttrRenderFragment, x: System.Boolean) = render ==> ("ShowColumnOptions" => x)
    [<CustomOperation("Breakpoint")>] member inline _.Breakpoint (render: AttrRenderFragment, x: MudBlazor.Breakpoint) = render ==> ("Breakpoint" => x)
    [<CustomOperation("Elevation")>] member inline _.Elevation (render: AttrRenderFragment, x: System.Int32) = render ==> ("Elevation" => x)
    [<CustomOperation("Square")>] member inline _.Square (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Square" => x)
    [<CustomOperation("Outlined")>] member inline _.Outlined (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Outlined" => x)
    [<CustomOperation("Bordered")>] member inline _.Bordered (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Bordered" => x)
    [<CustomOperation("ColGroup")>] member inline _.ColGroup (render: AttrRenderFragment, fragment) = render ==> html.renderFragment("ColGroup", fragment)
    [<CustomOperation("ColGroup")>] member inline _.ColGroup (render: AttrRenderFragment, x: string) = render ==> html.renderFragment("ColGroup", html.text x)
    [<CustomOperation("ColGroup")>] member inline _.ColGroup (render: AttrRenderFragment, x: int) = render ==> html.renderFragment("ColGroup", html.text x)
    [<CustomOperation("ColGroup")>] member inline _.ColGroup (render: AttrRenderFragment, x: float) = render ==> html.renderFragment("ColGroup", html.text x)
    [<CustomOperation("Dense")>] member inline _.Dense (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Dense" => x)
    [<CustomOperation("Hover")>] member inline _.Hover (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Hover" => x)
    [<CustomOperation("Striped")>] member inline _.Striped (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Striped" => x)
    [<CustomOperation("FixedHeader")>] member inline _.FixedHeader (render: AttrRenderFragment, x: System.Boolean) = render ==> ("FixedHeader" => x)
    [<CustomOperation("FixedFooter")>] member inline _.FixedFooter (render: AttrRenderFragment, x: System.Boolean) = render ==> ("FixedFooter" => x)
    [<CustomOperation("FilterDefinitions")>] member inline _.FilterDefinitions (render: AttrRenderFragment, x: System.Collections.Generic.List<MudBlazor.FilterDefinition<'T>>) = render ==> ("FilterDefinitions" => x)
    [<CustomOperation("Virtualize")>] member inline _.Virtualize (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Virtualize" => x)
    [<CustomOperation("RowClass")>] member inline _.RowClass (render: AttrRenderFragment, x: System.String) = render ==> ("RowClass" => x)
    [<CustomOperation("RowStyle")>] member inline _.RowStyle (render: AttrRenderFragment, x: System.String) = render ==> ("RowStyle" => x)
    [<CustomOperation("RowClassFunc")>] member inline _.RowClassFunc (render: AttrRenderFragment, fn) = render ==> ("RowClassFunc" => (System.Func<'T, System.Int32, System.String>fn))
    [<CustomOperation("RowStyleFunc")>] member inline _.RowStyleFunc (render: AttrRenderFragment, fn) = render ==> ("RowStyleFunc" => (System.Func<'T, System.Int32, System.String>fn))
    [<CustomOperation("MultiSelection")>] member inline _.MultiSelection (render: AttrRenderFragment, x: System.Boolean) = render ==> ("MultiSelection" => x)
    [<CustomOperation("EditMode")>] member inline _.EditMode (render: AttrRenderFragment, x: System.Nullable<MudBlazor.DataGridEditMode>) = render ==> ("EditMode" => x)
    [<CustomOperation("Items")>] member inline _.Items (render: AttrRenderFragment, x: System.Collections.Generic.IEnumerable<'T>) = render ==> ("Items" => x)
    [<CustomOperation("Loading")>] member inline _.Loading (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Loading" => x)
    [<CustomOperation("CanCancelEdit")>] member inline _.CanCancelEdit (render: AttrRenderFragment, x: System.Boolean) = render ==> ("CanCancelEdit" => x)
    [<CustomOperation("LoadingProgressColor")>] member inline _.LoadingProgressColor (render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("LoadingProgressColor" => x)
    [<CustomOperation("ToolBarContent")>] member inline _.ToolBarContent (render: AttrRenderFragment, fragment) = render ==> html.renderFragment("ToolBarContent", fragment)
    [<CustomOperation("ToolBarContent")>] member inline _.ToolBarContent (render: AttrRenderFragment, x: string) = render ==> html.renderFragment("ToolBarContent", html.text x)
    [<CustomOperation("ToolBarContent")>] member inline _.ToolBarContent (render: AttrRenderFragment, x: int) = render ==> html.renderFragment("ToolBarContent", html.text x)
    [<CustomOperation("ToolBarContent")>] member inline _.ToolBarContent (render: AttrRenderFragment, x: float) = render ==> html.renderFragment("ToolBarContent", html.text x)
    [<CustomOperation("HorizontalScrollbar")>] member inline _.HorizontalScrollbar (render: AttrRenderFragment, x: System.Boolean) = render ==> ("HorizontalScrollbar" => x)
    [<CustomOperation("HeaderClass")>] member inline _.HeaderClass (render: AttrRenderFragment, x: System.String) = render ==> ("HeaderClass" => x)
    [<CustomOperation("Height")>] member inline _.Height (render: AttrRenderFragment, x: System.String) = render ==> ("Height" => x)
    [<CustomOperation("FooterClass")>] member inline _.FooterClass (render: AttrRenderFragment, x: System.String) = render ==> ("FooterClass" => x)
    [<CustomOperation("QuickFilter")>] member inline _.QuickFilter (render: AttrRenderFragment, fn) = render ==> ("QuickFilter" => (System.Func<'T, System.Boolean>fn))
    [<CustomOperation("Header")>] member inline _.Header (render: AttrRenderFragment, fragment) = render ==> html.renderFragment("Header", fragment)
    [<CustomOperation("Header")>] member inline _.Header (render: AttrRenderFragment, x: string) = render ==> html.renderFragment("Header", html.text x)
    [<CustomOperation("Header")>] member inline _.Header (render: AttrRenderFragment, x: int) = render ==> html.renderFragment("Header", html.text x)
    [<CustomOperation("Header")>] member inline _.Header (render: AttrRenderFragment, x: float) = render ==> html.renderFragment("Header", html.text x)
    [<CustomOperation("Columns")>] member inline _.Columns (render: AttrRenderFragment, fragment) = render ==> html.renderFragment("Columns", fragment)
    [<CustomOperation("Columns")>] member inline _.Columns (render: AttrRenderFragment, x: string) = render ==> html.renderFragment("Columns", html.text x)
    [<CustomOperation("Columns")>] member inline _.Columns (render: AttrRenderFragment, x: int) = render ==> html.renderFragment("Columns", html.text x)
    [<CustomOperation("Columns")>] member inline _.Columns (render: AttrRenderFragment, x: float) = render ==> html.renderFragment("Columns", html.text x)
    [<CustomOperation("Footer")>] member inline _.Footer (render: AttrRenderFragment, fragment) = render ==> html.renderFragment("Footer", fragment)
    [<CustomOperation("Footer")>] member inline _.Footer (render: AttrRenderFragment, x: string) = render ==> html.renderFragment("Footer", html.text x)
    [<CustomOperation("Footer")>] member inline _.Footer (render: AttrRenderFragment, x: int) = render ==> html.renderFragment("Footer", html.text x)
    [<CustomOperation("Footer")>] member inline _.Footer (render: AttrRenderFragment, x: float) = render ==> html.renderFragment("Footer", html.text x)
    [<CustomOperation("ChildRowContent")>] member inline _.ChildRowContent (render: AttrRenderFragment, fn: 'T -> NodeRenderFragment) = render ==> html.renderFragment("ChildRowContent", fn)
    [<CustomOperation("NoRecordsContent")>] member inline _.NoRecordsContent (render: AttrRenderFragment, fragment) = render ==> html.renderFragment("NoRecordsContent", fragment)
    [<CustomOperation("NoRecordsContent")>] member inline _.NoRecordsContent (render: AttrRenderFragment, x: string) = render ==> html.renderFragment("NoRecordsContent", html.text x)
    [<CustomOperation("NoRecordsContent")>] member inline _.NoRecordsContent (render: AttrRenderFragment, x: int) = render ==> html.renderFragment("NoRecordsContent", html.text x)
    [<CustomOperation("NoRecordsContent")>] member inline _.NoRecordsContent (render: AttrRenderFragment, x: float) = render ==> html.renderFragment("NoRecordsContent", html.text x)
    [<CustomOperation("LoadingContent")>] member inline _.LoadingContent (render: AttrRenderFragment, fragment) = render ==> html.renderFragment("LoadingContent", fragment)
    [<CustomOperation("LoadingContent")>] member inline _.LoadingContent (render: AttrRenderFragment, x: string) = render ==> html.renderFragment("LoadingContent", html.text x)
    [<CustomOperation("LoadingContent")>] member inline _.LoadingContent (render: AttrRenderFragment, x: int) = render ==> html.renderFragment("LoadingContent", html.text x)
    [<CustomOperation("LoadingContent")>] member inline _.LoadingContent (render: AttrRenderFragment, x: float) = render ==> html.renderFragment("LoadingContent", html.text x)
    [<CustomOperation("PagerContent")>] member inline _.PagerContent (render: AttrRenderFragment, fragment) = render ==> html.renderFragment("PagerContent", fragment)
    [<CustomOperation("PagerContent")>] member inline _.PagerContent (render: AttrRenderFragment, x: string) = render ==> html.renderFragment("PagerContent", html.text x)
    [<CustomOperation("PagerContent")>] member inline _.PagerContent (render: AttrRenderFragment, x: int) = render ==> html.renderFragment("PagerContent", html.text x)
    [<CustomOperation("PagerContent")>] member inline _.PagerContent (render: AttrRenderFragment, x: float) = render ==> html.renderFragment("PagerContent", html.text x)
    [<CustomOperation("ServerData")>] member inline _.ServerData (render: AttrRenderFragment, fn) = render ==> ("ServerData" => (System.Func<MudBlazor.GridState<'T>, System.Threading.Tasks.Task<MudBlazor.GridData<'T>>>fn))
    [<CustomOperation("RowsPerPage")>] member inline _.RowsPerPage (render: AttrRenderFragment, x: System.Int32) = render ==> ("RowsPerPage" => x)
    [<CustomOperation("CurrentPage")>] member inline _.CurrentPage (render: AttrRenderFragment, x: System.Int32) = render ==> ("CurrentPage" => x)
    [<CustomOperation("ReadOnly")>] member inline _.ReadOnly (render: AttrRenderFragment, x: System.Boolean) = render ==> ("ReadOnly" => x)
    [<CustomOperation("SelectedItems")>] member inline _.SelectedItems (render: AttrRenderFragment, x: System.Collections.Generic.HashSet<'T>) = render ==> ("SelectedItems" => x)
    [<CustomOperation("SelectedItems'")>] member inline _.SelectedItems' (render: AttrRenderFragment, value: IStore<System.Collections.Generic.HashSet<'T>>) = render ==> html.bind("SelectedItems", value)
    [<CustomOperation("SelectedItems'")>] member inline _.SelectedItems' (render: AttrRenderFragment, value: cval<System.Collections.Generic.HashSet<'T>>) = render ==> html.bind("SelectedItems", value)
    [<CustomOperation("SelectedItems'")>] member inline _.SelectedItems' (render: AttrRenderFragment, valueFn: System.Collections.Generic.HashSet<'T> * (System.Collections.Generic.HashSet<'T> -> unit)) = render ==> html.bind("SelectedItems", valueFn)
    [<CustomOperation("SelectedItem")>] member inline _.SelectedItem (render: AttrRenderFragment, x: 'T) = render ==> ("SelectedItem" => x)
    [<CustomOperation("SelectedItem'")>] member inline _.SelectedItem' (render: AttrRenderFragment, value: IStore<'T>) = render ==> html.bind("SelectedItem", value)
    [<CustomOperation("SelectedItem'")>] member inline _.SelectedItem' (render: AttrRenderFragment, value: cval<'T>) = render ==> html.bind("SelectedItem", value)
    [<CustomOperation("SelectedItem'")>] member inline _.SelectedItem' (render: AttrRenderFragment, valueFn: 'T * ('T -> unit)) = render ==> html.bind("SelectedItem", valueFn)
                

type MudDataGridPagerBuilder<'FunBlazorGeneric, 'T when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("DisableRowsPerPage")>] member inline _.DisableRowsPerPage (render: AttrRenderFragment, x: System.Boolean) = render ==> ("DisableRowsPerPage" => x)
    [<CustomOperation("PageSizeOptions")>] member inline _.PageSizeOptions (render: AttrRenderFragment, x: System.Int32[]) = render ==> ("PageSizeOptions" => x)
    [<CustomOperation("InfoFormat")>] member inline _.InfoFormat (render: AttrRenderFragment, x: System.String) = render ==> ("InfoFormat" => x)
    [<CustomOperation("RowsPerPageString")>] member inline _.RowsPerPageString (render: AttrRenderFragment, x: System.String) = render ==> ("RowsPerPageString" => x)
                

type RowBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()

                

type MudDialogBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("TitleContent")>] member inline _.TitleContent (render: AttrRenderFragment, fragment) = render ==> html.renderFragment("TitleContent", fragment)
    [<CustomOperation("TitleContent")>] member inline _.TitleContent (render: AttrRenderFragment, x: string) = render ==> html.renderFragment("TitleContent", html.text x)
    [<CustomOperation("TitleContent")>] member inline _.TitleContent (render: AttrRenderFragment, x: int) = render ==> html.renderFragment("TitleContent", html.text x)
    [<CustomOperation("TitleContent")>] member inline _.TitleContent (render: AttrRenderFragment, x: float) = render ==> html.renderFragment("TitleContent", html.text x)
    [<CustomOperation("DialogContent")>] member inline _.DialogContent (render: AttrRenderFragment, fragment) = render ==> html.renderFragment("DialogContent", fragment)
    [<CustomOperation("DialogContent")>] member inline _.DialogContent (render: AttrRenderFragment, x: string) = render ==> html.renderFragment("DialogContent", html.text x)
    [<CustomOperation("DialogContent")>] member inline _.DialogContent (render: AttrRenderFragment, x: int) = render ==> html.renderFragment("DialogContent", html.text x)
    [<CustomOperation("DialogContent")>] member inline _.DialogContent (render: AttrRenderFragment, x: float) = render ==> html.renderFragment("DialogContent", html.text x)
    [<CustomOperation("DialogActions")>] member inline _.DialogActions (render: AttrRenderFragment, fragment) = render ==> html.renderFragment("DialogActions", fragment)
    [<CustomOperation("DialogActions")>] member inline _.DialogActions (render: AttrRenderFragment, x: string) = render ==> html.renderFragment("DialogActions", html.text x)
    [<CustomOperation("DialogActions")>] member inline _.DialogActions (render: AttrRenderFragment, x: int) = render ==> html.renderFragment("DialogActions", html.text x)
    [<CustomOperation("DialogActions")>] member inline _.DialogActions (render: AttrRenderFragment, x: float) = render ==> html.renderFragment("DialogActions", html.text x)
    [<CustomOperation("Options")>] member inline _.Options (render: AttrRenderFragment, x: MudBlazor.DialogOptions) = render ==> ("Options" => x)
    [<CustomOperation("DisableSidePadding")>] member inline _.DisableSidePadding (render: AttrRenderFragment, x: System.Boolean) = render ==> ("DisableSidePadding" => x)
    [<CustomOperation("ClassContent")>] member inline _.ClassContent (render: AttrRenderFragment, x: System.String) = render ==> ("ClassContent" => x)
    [<CustomOperation("ClassActions")>] member inline _.ClassActions (render: AttrRenderFragment, x: System.String) = render ==> ("ClassActions" => x)
    [<CustomOperation("ContentStyle")>] member inline _.ContentStyle (render: AttrRenderFragment, x: System.String) = render ==> ("ContentStyle" => x)
    [<CustomOperation("IsVisible")>] member inline _.IsVisible (render: AttrRenderFragment, x: System.Boolean) = render ==> ("IsVisible" => x)
    [<CustomOperation("IsVisible'")>] member inline _.IsVisible' (render: AttrRenderFragment, value: IStore<System.Boolean>) = render ==> html.bind("IsVisible", value)
    [<CustomOperation("IsVisible'")>] member inline _.IsVisible' (render: AttrRenderFragment, value: cval<System.Boolean>) = render ==> html.bind("IsVisible", value)
    [<CustomOperation("IsVisible'")>] member inline _.IsVisible' (render: AttrRenderFragment, valueFn: System.Boolean * (System.Boolean -> unit)) = render ==> html.bind("IsVisible", valueFn)
    [<CustomOperation("IsVisibleChanged")>] member inline _.IsVisibleChanged (render: AttrRenderFragment, fn) = render ==> html.callback<System.Boolean>("IsVisibleChanged", fn)
                

type MudDialogInstanceBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Options")>] member inline _.Options (render: AttrRenderFragment, x: MudBlazor.DialogOptions) = render ==> ("Options" => x)
    [<CustomOperation("Title")>] member inline _.Title (render: AttrRenderFragment, x: System.String) = render ==> ("Title" => x)
    [<CustomOperation("TitleContent")>] member inline _.TitleContent (render: AttrRenderFragment, fragment) = render ==> html.renderFragment("TitleContent", fragment)
    [<CustomOperation("TitleContent")>] member inline _.TitleContent (render: AttrRenderFragment, x: string) = render ==> html.renderFragment("TitleContent", html.text x)
    [<CustomOperation("TitleContent")>] member inline _.TitleContent (render: AttrRenderFragment, x: int) = render ==> html.renderFragment("TitleContent", html.text x)
    [<CustomOperation("TitleContent")>] member inline _.TitleContent (render: AttrRenderFragment, x: float) = render ==> html.renderFragment("TitleContent", html.text x)
    [<CustomOperation("Content")>] member inline _.Content (render: AttrRenderFragment, fragment) = render ==> html.renderFragment("Content", fragment)
    [<CustomOperation("Content")>] member inline _.Content (render: AttrRenderFragment, x: string) = render ==> html.renderFragment("Content", html.text x)
    [<CustomOperation("Content")>] member inline _.Content (render: AttrRenderFragment, x: int) = render ==> html.renderFragment("Content", html.text x)
    [<CustomOperation("Content")>] member inline _.Content (render: AttrRenderFragment, x: float) = render ==> html.renderFragment("Content", html.text x)
    [<CustomOperation("Id")>] member inline _.Id (render: AttrRenderFragment, x: System.Guid) = render ==> ("Id" => x)
    [<CustomOperation("CloseIcon")>] member inline _.CloseIcon (render: AttrRenderFragment, x: System.String) = render ==> ("CloseIcon" => x)
                

type MudDrawerBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Fixed")>] member inline _.Fixed (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Fixed" => x)
    [<CustomOperation("Elevation")>] member inline _.Elevation (render: AttrRenderFragment, x: System.Int32) = render ==> ("Elevation" => x)
    [<CustomOperation("Anchor")>] member inline _.Anchor (render: AttrRenderFragment, x: MudBlazor.Anchor) = render ==> ("Anchor" => x)
    [<CustomOperation("Color")>] member inline _.Color (render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("Color" => x)
    [<CustomOperation("Variant")>] member inline _.Variant (render: AttrRenderFragment, x: MudBlazor.DrawerVariant) = render ==> ("Variant" => x)
    [<CustomOperation("DisableOverlay")>] member inline _.DisableOverlay (render: AttrRenderFragment, x: System.Boolean) = render ==> ("DisableOverlay" => x)
    [<CustomOperation("PreserveOpenState")>] member inline _.PreserveOpenState (render: AttrRenderFragment, x: System.Boolean) = render ==> ("PreserveOpenState" => x)
    [<CustomOperation("OpenMiniOnHover")>] member inline _.OpenMiniOnHover (render: AttrRenderFragment, x: System.Boolean) = render ==> ("OpenMiniOnHover" => x)
    [<CustomOperation("Breakpoint")>] member inline _.Breakpoint (render: AttrRenderFragment, x: MudBlazor.Breakpoint) = render ==> ("Breakpoint" => x)
    [<CustomOperation("Open")>] member inline _.Open (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Open" => x)
    [<CustomOperation("Open'")>] member inline _.Open' (render: AttrRenderFragment, value: IStore<System.Boolean>) = render ==> html.bind("Open", value)
    [<CustomOperation("Open'")>] member inline _.Open' (render: AttrRenderFragment, value: cval<System.Boolean>) = render ==> html.bind("Open", value)
    [<CustomOperation("Open'")>] member inline _.Open' (render: AttrRenderFragment, valueFn: System.Boolean * (System.Boolean -> unit)) = render ==> html.bind("Open", valueFn)
    [<CustomOperation("OpenChanged")>] member inline _.OpenChanged (render: AttrRenderFragment, fn) = render ==> html.callback<System.Boolean>("OpenChanged", fn)
    [<CustomOperation("Width")>] member inline _.Width (render: AttrRenderFragment, x: System.String) = render ==> ("Width" => x)
    [<CustomOperation("MiniWidth")>] member inline _.MiniWidth (render: AttrRenderFragment, x: System.String) = render ==> ("MiniWidth" => x)
    [<CustomOperation("Height")>] member inline _.Height (render: AttrRenderFragment, x: System.String) = render ==> ("Height" => x)
    [<CustomOperation("ClipMode")>] member inline _.ClipMode (render: AttrRenderFragment, x: MudBlazor.DrawerClipMode) = render ==> ("ClipMode" => x)
                

type MudElementBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("HtmlTag")>] member inline _.HtmlTag (render: AttrRenderFragment, x: System.String) = render ==> ("HtmlTag" => x)
    [<CustomOperation("Ref")>] member inline _.Ref (render: AttrRenderFragment, x: System.Nullable<Microsoft.AspNetCore.Components.ElementReference>) = render ==> ("Ref" => x)
    [<CustomOperation("Ref'")>] member inline _.Ref' (render: AttrRenderFragment, value: IStore<System.Nullable<Microsoft.AspNetCore.Components.ElementReference>>) = render ==> html.bind("Ref", value)
    [<CustomOperation("Ref'")>] member inline _.Ref' (render: AttrRenderFragment, value: cval<System.Nullable<Microsoft.AspNetCore.Components.ElementReference>>) = render ==> html.bind("Ref", value)
    [<CustomOperation("Ref'")>] member inline _.Ref' (render: AttrRenderFragment, valueFn: System.Nullable<Microsoft.AspNetCore.Components.ElementReference> * (System.Nullable<Microsoft.AspNetCore.Components.ElementReference> -> unit)) = render ==> html.bind("Ref", valueFn)
    [<CustomOperation("RefChanged")>] member inline _.RefChanged (render: AttrRenderFragment, fn) = render ==> html.callback<Microsoft.AspNetCore.Components.ElementReference>("RefChanged", fn)
                

type MudExpansionPanelBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("MaxHeight")>] member inline _.MaxHeight (render: AttrRenderFragment, x: System.Nullable<System.Int32>) = render ==> ("MaxHeight" => x)
    [<CustomOperation("TitleContent")>] member inline _.TitleContent (render: AttrRenderFragment, fragment) = render ==> html.renderFragment("TitleContent", fragment)
    [<CustomOperation("TitleContent")>] member inline _.TitleContent (render: AttrRenderFragment, x: string) = render ==> html.renderFragment("TitleContent", html.text x)
    [<CustomOperation("TitleContent")>] member inline _.TitleContent (render: AttrRenderFragment, x: int) = render ==> html.renderFragment("TitleContent", html.text x)
    [<CustomOperation("TitleContent")>] member inline _.TitleContent (render: AttrRenderFragment, x: float) = render ==> html.renderFragment("TitleContent", html.text x)
    [<CustomOperation("Text")>] member inline _.Text (render: AttrRenderFragment, x: System.String) = render ==> ("Text" => x)
    [<CustomOperation("HideIcon")>] member inline _.HideIcon (render: AttrRenderFragment, x: System.Boolean) = render ==> ("HideIcon" => x)
    [<CustomOperation("Icon")>] member inline _.Icon (render: AttrRenderFragment, x: System.String) = render ==> ("Icon" => x)
    [<CustomOperation("Dense")>] member inline _.Dense (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Dense" => x)
    [<CustomOperation("DisableGutters")>] member inline _.DisableGutters (render: AttrRenderFragment, x: System.Boolean) = render ==> ("DisableGutters" => x)
    [<CustomOperation("IsExpandedChanged")>] member inline _.IsExpandedChanged (render: AttrRenderFragment, fn) = render ==> html.callback<System.Boolean>("IsExpandedChanged", fn)
    [<CustomOperation("IsExpanded")>] member inline _.IsExpanded (render: AttrRenderFragment, x: System.Boolean) = render ==> ("IsExpanded" => x)
    [<CustomOperation("IsExpanded'")>] member inline _.IsExpanded' (render: AttrRenderFragment, value: IStore<System.Boolean>) = render ==> html.bind("IsExpanded", value)
    [<CustomOperation("IsExpanded'")>] member inline _.IsExpanded' (render: AttrRenderFragment, value: cval<System.Boolean>) = render ==> html.bind("IsExpanded", value)
    [<CustomOperation("IsExpanded'")>] member inline _.IsExpanded' (render: AttrRenderFragment, valueFn: System.Boolean * (System.Boolean -> unit)) = render ==> html.bind("IsExpanded", valueFn)
    [<CustomOperation("IsInitiallyExpanded")>] member inline _.IsInitiallyExpanded (render: AttrRenderFragment, x: System.Boolean) = render ==> ("IsInitiallyExpanded" => x)
    [<CustomOperation("Disabled")>] member inline _.Disabled (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Disabled" => x)
                

type MudExpansionPanelsBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Square")>] member inline _.Square (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Square" => x)
    [<CustomOperation("MultiExpansion")>] member inline _.MultiExpansion (render: AttrRenderFragment, x: System.Boolean) = render ==> ("MultiExpansion" => x)
    [<CustomOperation("Elevation")>] member inline _.Elevation (render: AttrRenderFragment, x: System.Int32) = render ==> ("Elevation" => x)
    [<CustomOperation("Dense")>] member inline _.Dense (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Dense" => x)
    [<CustomOperation("DisableGutters")>] member inline _.DisableGutters (render: AttrRenderFragment, x: System.Boolean) = render ==> ("DisableGutters" => x)
    [<CustomOperation("DisableBorders")>] member inline _.DisableBorders (render: AttrRenderFragment, x: System.Boolean) = render ==> ("DisableBorders" => x)
                

type MudFieldBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Margin")>] member inline _.Margin (render: AttrRenderFragment, x: MudBlazor.Margin) = render ==> ("Margin" => x)
    [<CustomOperation("Error")>] member inline _.Error (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Error" => x)
    [<CustomOperation("ErrorText")>] member inline _.ErrorText (render: AttrRenderFragment, x: System.String) = render ==> ("ErrorText" => x)
    [<CustomOperation("HelperText")>] member inline _.HelperText (render: AttrRenderFragment, x: System.String) = render ==> ("HelperText" => x)
    [<CustomOperation("FullWidth")>] member inline _.FullWidth (render: AttrRenderFragment, x: System.Boolean) = render ==> ("FullWidth" => x)
    [<CustomOperation("Label")>] member inline _.Label (render: AttrRenderFragment, x: System.String) = render ==> ("Label" => x)
    [<CustomOperation("Variant")>] member inline _.Variant (render: AttrRenderFragment, x: MudBlazor.Variant) = render ==> ("Variant" => x)
    [<CustomOperation("Disabled")>] member inline _.Disabled (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Disabled" => x)
    [<CustomOperation("AdornmentIcon")>] member inline _.AdornmentIcon (render: AttrRenderFragment, x: System.String) = render ==> ("AdornmentIcon" => x)
    [<CustomOperation("AdornmentText")>] member inline _.AdornmentText (render: AttrRenderFragment, x: System.String) = render ==> ("AdornmentText" => x)
    [<CustomOperation("Adornment")>] member inline _.Adornment (render: AttrRenderFragment, x: MudBlazor.Adornment) = render ==> ("Adornment" => x)
    [<CustomOperation("AdornmentColor")>] member inline _.AdornmentColor (render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("AdornmentColor" => x)
    [<CustomOperation("IconSize")>] member inline _.IconSize (render: AttrRenderFragment, x: MudBlazor.Size) = render ==> ("IconSize" => x)
    [<CustomOperation("OnAdornmentClick")>] member inline _.OnAdornmentClick (render: AttrRenderFragment, fn) = render ==> html.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>("OnAdornmentClick", fn)
    [<CustomOperation("InnerPadding")>] member inline _.InnerPadding (render: AttrRenderFragment, x: System.Boolean) = render ==> ("InnerPadding" => x)
    [<CustomOperation("DisableUnderLine")>] member inline _.DisableUnderLine (render: AttrRenderFragment, x: System.Boolean) = render ==> ("DisableUnderLine" => x)
                

type MudFocusTrapBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Disabled")>] member inline _.Disabled (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Disabled" => x)
    [<CustomOperation("DefaultFocus")>] member inline _.DefaultFocus (render: AttrRenderFragment, x: MudBlazor.DefaultFocus) = render ==> ("DefaultFocus" => x)
                

type MudFormBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("IsValid")>] member inline _.IsValid (render: AttrRenderFragment, x: System.Boolean) = render ==> ("IsValid" => x)
    [<CustomOperation("IsValid'")>] member inline _.IsValid' (render: AttrRenderFragment, value: IStore<System.Boolean>) = render ==> html.bind("IsValid", value)
    [<CustomOperation("IsValid'")>] member inline _.IsValid' (render: AttrRenderFragment, value: cval<System.Boolean>) = render ==> html.bind("IsValid", value)
    [<CustomOperation("IsValid'")>] member inline _.IsValid' (render: AttrRenderFragment, valueFn: System.Boolean * (System.Boolean -> unit)) = render ==> html.bind("IsValid", valueFn)
    [<CustomOperation("IsTouched")>] member inline _.IsTouched (render: AttrRenderFragment, x: System.Boolean) = render ==> ("IsTouched" => x)
    [<CustomOperation("IsTouched'")>] member inline _.IsTouched' (render: AttrRenderFragment, value: IStore<System.Boolean>) = render ==> html.bind("IsTouched", value)
    [<CustomOperation("IsTouched'")>] member inline _.IsTouched' (render: AttrRenderFragment, value: cval<System.Boolean>) = render ==> html.bind("IsTouched", value)
    [<CustomOperation("IsTouched'")>] member inline _.IsTouched' (render: AttrRenderFragment, valueFn: System.Boolean * (System.Boolean -> unit)) = render ==> html.bind("IsTouched", valueFn)
    [<CustomOperation("ValidationDelay")>] member inline _.ValidationDelay (render: AttrRenderFragment, x: System.Int32) = render ==> ("ValidationDelay" => x)
    [<CustomOperation("SuppressRenderingOnValidation")>] member inline _.SuppressRenderingOnValidation (render: AttrRenderFragment, x: System.Boolean) = render ==> ("SuppressRenderingOnValidation" => x)
    [<CustomOperation("SuppressImplicitSubmission")>] member inline _.SuppressImplicitSubmission (render: AttrRenderFragment, x: System.Boolean) = render ==> ("SuppressImplicitSubmission" => x)
    [<CustomOperation("IsValidChanged")>] member inline _.IsValidChanged (render: AttrRenderFragment, fn) = render ==> html.callback<System.Boolean>("IsValidChanged", fn)
    [<CustomOperation("IsTouchedChanged")>] member inline _.IsTouchedChanged (render: AttrRenderFragment, fn) = render ==> html.callback<System.Boolean>("IsTouchedChanged", fn)
    [<CustomOperation("Errors")>] member inline _.Errors (render: AttrRenderFragment, x: System.String[]) = render ==> ("Errors" => x)
    [<CustomOperation("Errors'")>] member inline _.Errors' (render: AttrRenderFragment, value: IStore<System.String[]>) = render ==> html.bind("Errors", value)
    [<CustomOperation("Errors'")>] member inline _.Errors' (render: AttrRenderFragment, value: cval<System.String[]>) = render ==> html.bind("Errors", value)
    [<CustomOperation("Errors'")>] member inline _.Errors' (render: AttrRenderFragment, valueFn: System.String[] * (System.String[] -> unit)) = render ==> html.bind("Errors", valueFn)
    [<CustomOperation("ErrorsChanged")>] member inline _.ErrorsChanged (render: AttrRenderFragment, fn) = render ==> html.callback<System.String[]>("ErrorsChanged", fn)
    [<CustomOperation("Model")>] member inline _.Model (render: AttrRenderFragment, x: System.Object) = render ==> ("Model" => x)
                

type MudHiddenBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Breakpoint")>] member inline _.Breakpoint (render: AttrRenderFragment, x: MudBlazor.Breakpoint) = render ==> ("Breakpoint" => x)
    [<CustomOperation("Invert")>] member inline _.Invert (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Invert" => x)
    [<CustomOperation("IsHidden")>] member inline _.IsHidden (render: AttrRenderFragment, x: System.Boolean) = render ==> ("IsHidden" => x)
    [<CustomOperation("IsHidden'")>] member inline _.IsHidden' (render: AttrRenderFragment, value: IStore<System.Boolean>) = render ==> html.bind("IsHidden", value)
    [<CustomOperation("IsHidden'")>] member inline _.IsHidden' (render: AttrRenderFragment, value: cval<System.Boolean>) = render ==> html.bind("IsHidden", value)
    [<CustomOperation("IsHidden'")>] member inline _.IsHidden' (render: AttrRenderFragment, valueFn: System.Boolean * (System.Boolean -> unit)) = render ==> html.bind("IsHidden", valueFn)
    [<CustomOperation("IsHiddenChanged")>] member inline _.IsHiddenChanged (render: AttrRenderFragment, fn) = render ==> html.callback<System.Boolean>("IsHiddenChanged", fn)
                

type MudIconBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Icon")>] member inline _.Icon (render: AttrRenderFragment, x: System.String) = render ==> ("Icon" => x)
    [<CustomOperation("Title")>] member inline _.Title (render: AttrRenderFragment, x: System.String) = render ==> ("Title" => x)
    [<CustomOperation("Size")>] member inline _.Size (render: AttrRenderFragment, x: MudBlazor.Size) = render ==> ("Size" => x)
    [<CustomOperation("Color")>] member inline _.Color (render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("Color" => x)
    [<CustomOperation("ViewBox")>] member inline _.ViewBox (render: AttrRenderFragment, x: System.String) = render ==> ("ViewBox" => x)
                

type MudInputControlBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("InputContent")>] member inline _.InputContent (render: AttrRenderFragment, fragment) = render ==> html.renderFragment("InputContent", fragment)
    [<CustomOperation("InputContent")>] member inline _.InputContent (render: AttrRenderFragment, x: string) = render ==> html.renderFragment("InputContent", html.text x)
    [<CustomOperation("InputContent")>] member inline _.InputContent (render: AttrRenderFragment, x: int) = render ==> html.renderFragment("InputContent", html.text x)
    [<CustomOperation("InputContent")>] member inline _.InputContent (render: AttrRenderFragment, x: float) = render ==> html.renderFragment("InputContent", html.text x)
    [<CustomOperation("Margin")>] member inline _.Margin (render: AttrRenderFragment, x: MudBlazor.Margin) = render ==> ("Margin" => x)
    [<CustomOperation("Required")>] member inline _.Required (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Required" => x)
    [<CustomOperation("Error")>] member inline _.Error (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Error" => x)
    [<CustomOperation("ErrorText")>] member inline _.ErrorText (render: AttrRenderFragment, x: System.String) = render ==> ("ErrorText" => x)
    [<CustomOperation("HelperText")>] member inline _.HelperText (render: AttrRenderFragment, x: System.String) = render ==> ("HelperText" => x)
    [<CustomOperation("HelperTextOnFocus")>] member inline _.HelperTextOnFocus (render: AttrRenderFragment, x: System.Boolean) = render ==> ("HelperTextOnFocus" => x)
    [<CustomOperation("CounterText")>] member inline _.CounterText (render: AttrRenderFragment, x: System.String) = render ==> ("CounterText" => x)
    [<CustomOperation("FullWidth")>] member inline _.FullWidth (render: AttrRenderFragment, x: System.Boolean) = render ==> ("FullWidth" => x)
    [<CustomOperation("Label")>] member inline _.Label (render: AttrRenderFragment, x: System.String) = render ==> ("Label" => x)
    [<CustomOperation("Variant")>] member inline _.Variant (render: AttrRenderFragment, x: MudBlazor.Variant) = render ==> ("Variant" => x)
    [<CustomOperation("Disabled")>] member inline _.Disabled (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Disabled" => x)
                

type MudInputLabelBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Disabled")>] member inline _.Disabled (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Disabled" => x)
    [<CustomOperation("Error")>] member inline _.Error (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Error" => x)
    [<CustomOperation("Variant")>] member inline _.Variant (render: AttrRenderFragment, x: MudBlazor.Variant) = render ==> ("Variant" => x)
    [<CustomOperation("Margin")>] member inline _.Margin (render: AttrRenderFragment, x: MudBlazor.Margin) = render ==> ("Margin" => x)
                

type MudLinkBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Color")>] member inline _.Color (render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("Color" => x)
    [<CustomOperation("Typo")>] member inline _.Typo (render: AttrRenderFragment, x: MudBlazor.Typo) = render ==> ("Typo" => x)
    [<CustomOperation("Underline")>] member inline _.Underline (render: AttrRenderFragment, x: MudBlazor.Underline) = render ==> ("Underline" => x)
    [<CustomOperation("Href")>] member inline _.Href (render: AttrRenderFragment, x: System.String) = render ==> ("Href" => x)
    [<CustomOperation("Target")>] member inline _.Target (render: AttrRenderFragment, x: System.String) = render ==> ("Target" => x)
    [<CustomOperation("Disabled")>] member inline _.Disabled (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Disabled" => x)
                

type MudListBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Clickable")>] member inline _.Clickable (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Clickable" => x)
    [<CustomOperation("DisablePadding")>] member inline _.DisablePadding (render: AttrRenderFragment, x: System.Boolean) = render ==> ("DisablePadding" => x)
    [<CustomOperation("Dense")>] member inline _.Dense (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Dense" => x)
    [<CustomOperation("DisableGutters")>] member inline _.DisableGutters (render: AttrRenderFragment, x: System.Boolean) = render ==> ("DisableGutters" => x)
    [<CustomOperation("Disabled")>] member inline _.Disabled (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Disabled" => x)
    [<CustomOperation("SelectedItem")>] member inline _.SelectedItem (render: AttrRenderFragment, x: MudBlazor.MudListItem) = render ==> ("SelectedItem" => x)
    [<CustomOperation("SelectedItem'")>] member inline _.SelectedItem' (render: AttrRenderFragment, value: IStore<MudBlazor.MudListItem>) = render ==> html.bind("SelectedItem", value)
    [<CustomOperation("SelectedItem'")>] member inline _.SelectedItem' (render: AttrRenderFragment, value: cval<MudBlazor.MudListItem>) = render ==> html.bind("SelectedItem", value)
    [<CustomOperation("SelectedItem'")>] member inline _.SelectedItem' (render: AttrRenderFragment, valueFn: MudBlazor.MudListItem * (MudBlazor.MudListItem -> unit)) = render ==> html.bind("SelectedItem", valueFn)
    [<CustomOperation("SelectedItemChanged")>] member inline _.SelectedItemChanged (render: AttrRenderFragment, fn) = render ==> html.callback<MudBlazor.MudListItem>("SelectedItemChanged", fn)
    [<CustomOperation("SelectedValue")>] member inline _.SelectedValue (render: AttrRenderFragment, x: System.Object) = render ==> ("SelectedValue" => x)
    [<CustomOperation("SelectedValue'")>] member inline _.SelectedValue' (render: AttrRenderFragment, value: IStore<System.Object>) = render ==> html.bind("SelectedValue", value)
    [<CustomOperation("SelectedValue'")>] member inline _.SelectedValue' (render: AttrRenderFragment, value: cval<System.Object>) = render ==> html.bind("SelectedValue", value)
    [<CustomOperation("SelectedValue'")>] member inline _.SelectedValue' (render: AttrRenderFragment, valueFn: System.Object * (System.Object -> unit)) = render ==> html.bind("SelectedValue", valueFn)
    [<CustomOperation("SelectedValueChanged")>] member inline _.SelectedValueChanged (render: AttrRenderFragment, fn) = render ==> html.callback<System.Object>("SelectedValueChanged", fn)
                

type MudListItemBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Text")>] member inline _.Text (render: AttrRenderFragment, x: System.String) = render ==> ("Text" => x)
    [<CustomOperation("Value")>] member inline _.Value (render: AttrRenderFragment, x: System.Object) = render ==> ("Value" => x)
    [<CustomOperation("Avatar")>] member inline _.Avatar (render: AttrRenderFragment, x: System.String) = render ==> ("Avatar" => x)
    [<CustomOperation("Href")>] member inline _.Href (render: AttrRenderFragment, x: System.String) = render ==> ("Href" => x)
    [<CustomOperation("ForceLoad")>] member inline _.ForceLoad (render: AttrRenderFragment, x: System.Boolean) = render ==> ("ForceLoad" => x)
    [<CustomOperation("AvatarClass")>] member inline _.AvatarClass (render: AttrRenderFragment, x: System.String) = render ==> ("AvatarClass" => x)
    [<CustomOperation("Disabled")>] member inline _.Disabled (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Disabled" => x)
    [<CustomOperation("DisableRipple")>] member inline _.DisableRipple (render: AttrRenderFragment, x: System.Boolean) = render ==> ("DisableRipple" => x)
    [<CustomOperation("Icon")>] member inline _.Icon (render: AttrRenderFragment, x: System.String) = render ==> ("Icon" => x)
    [<CustomOperation("IconColor")>] member inline _.IconColor (render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("IconColor" => x)
    [<CustomOperation("IconSize")>] member inline _.IconSize (render: AttrRenderFragment, x: MudBlazor.Size) = render ==> ("IconSize" => x)
    [<CustomOperation("AdornmentColor")>] member inline _.AdornmentColor (render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("AdornmentColor" => x)
    [<CustomOperation("ExpandLessIcon")>] member inline _.ExpandLessIcon (render: AttrRenderFragment, x: System.String) = render ==> ("ExpandLessIcon" => x)
    [<CustomOperation("ExpandMoreIcon")>] member inline _.ExpandMoreIcon (render: AttrRenderFragment, x: System.String) = render ==> ("ExpandMoreIcon" => x)
    [<CustomOperation("Inset")>] member inline _.Inset (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Inset" => x)
    [<CustomOperation("Dense")>] member inline _.Dense (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Dense" => x)
    [<CustomOperation("DisableGutters")>] member inline _.DisableGutters (render: AttrRenderFragment, x: System.Boolean) = render ==> ("DisableGutters" => x)
    [<CustomOperation("Expanded")>] member inline _.Expanded (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Expanded" => x)
    [<CustomOperation("Expanded'")>] member inline _.Expanded' (render: AttrRenderFragment, value: IStore<System.Boolean>) = render ==> html.bind("Expanded", value)
    [<CustomOperation("Expanded'")>] member inline _.Expanded' (render: AttrRenderFragment, value: cval<System.Boolean>) = render ==> html.bind("Expanded", value)
    [<CustomOperation("Expanded'")>] member inline _.Expanded' (render: AttrRenderFragment, valueFn: System.Boolean * (System.Boolean -> unit)) = render ==> html.bind("Expanded", valueFn)
    [<CustomOperation("ExpandedChanged")>] member inline _.ExpandedChanged (render: AttrRenderFragment, fn) = render ==> html.callback<System.Boolean>("ExpandedChanged", fn)
    [<CustomOperation("InitiallyExpanded")>] member inline _.InitiallyExpanded (render: AttrRenderFragment, x: System.Boolean) = render ==> ("InitiallyExpanded" => x)
    [<CustomOperation("CommandParameter")>] member inline _.CommandParameter (render: AttrRenderFragment, x: System.Object) = render ==> ("CommandParameter" => x)
    [<CustomOperation("Command")>] member inline _.Command (render: AttrRenderFragment, x: System.Windows.Input.ICommand) = render ==> ("Command" => x)
    [<CustomOperation("NestedList")>] member inline _.NestedList (render: AttrRenderFragment, fragment) = render ==> html.renderFragment("NestedList", fragment)
    [<CustomOperation("NestedList")>] member inline _.NestedList (render: AttrRenderFragment, x: string) = render ==> html.renderFragment("NestedList", html.text x)
    [<CustomOperation("NestedList")>] member inline _.NestedList (render: AttrRenderFragment, x: int) = render ==> html.renderFragment("NestedList", html.text x)
    [<CustomOperation("NestedList")>] member inline _.NestedList (render: AttrRenderFragment, x: float) = render ==> html.renderFragment("NestedList", html.text x)
    [<CustomOperation("OnClick")>] member inline _.OnClick (render: AttrRenderFragment, fn) = render ==> html.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>("OnClick", fn)
                

type MudListSubheaderBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("DisableGutters")>] member inline _.DisableGutters (render: AttrRenderFragment, x: System.Boolean) = render ==> ("DisableGutters" => x)
    [<CustomOperation("Inset")>] member inline _.Inset (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Inset" => x)
                

type MudMenuBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Label")>] member inline _.Label (render: AttrRenderFragment, x: System.String) = render ==> ("Label" => x)
    [<CustomOperation("ListClass")>] member inline _.ListClass (render: AttrRenderFragment, x: System.String) = render ==> ("ListClass" => x)
    [<CustomOperation("PopoverClass")>] member inline _.PopoverClass (render: AttrRenderFragment, x: System.String) = render ==> ("PopoverClass" => x)
    [<CustomOperation("Icon")>] member inline _.Icon (render: AttrRenderFragment, x: System.String) = render ==> ("Icon" => x)
    [<CustomOperation("IconColor")>] member inline _.IconColor (render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("IconColor" => x)
    [<CustomOperation("StartIcon")>] member inline _.StartIcon (render: AttrRenderFragment, x: System.String) = render ==> ("StartIcon" => x)
    [<CustomOperation("EndIcon")>] member inline _.EndIcon (render: AttrRenderFragment, x: System.String) = render ==> ("EndIcon" => x)
    [<CustomOperation("Color")>] member inline _.Color (render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("Color" => x)
    [<CustomOperation("Size")>] member inline _.Size (render: AttrRenderFragment, x: MudBlazor.Size) = render ==> ("Size" => x)
    [<CustomOperation("Variant")>] member inline _.Variant (render: AttrRenderFragment, x: MudBlazor.Variant) = render ==> ("Variant" => x)
    [<CustomOperation("Dense")>] member inline _.Dense (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Dense" => x)
    [<CustomOperation("FullWidth")>] member inline _.FullWidth (render: AttrRenderFragment, x: System.Boolean) = render ==> ("FullWidth" => x)
    [<CustomOperation("MaxHeight")>] member inline _.MaxHeight (render: AttrRenderFragment, x: System.Nullable<System.Int32>) = render ==> ("MaxHeight" => x)
    [<CustomOperation("PositionAtCursor")>] member inline _.PositionAtCursor (render: AttrRenderFragment, x: System.Boolean) = render ==> ("PositionAtCursor" => x)
    [<CustomOperation("ActivatorContent")>] member inline _.ActivatorContent (render: AttrRenderFragment, fragment) = render ==> html.renderFragment("ActivatorContent", fragment)
    [<CustomOperation("ActivatorContent")>] member inline _.ActivatorContent (render: AttrRenderFragment, x: string) = render ==> html.renderFragment("ActivatorContent", html.text x)
    [<CustomOperation("ActivatorContent")>] member inline _.ActivatorContent (render: AttrRenderFragment, x: int) = render ==> html.renderFragment("ActivatorContent", html.text x)
    [<CustomOperation("ActivatorContent")>] member inline _.ActivatorContent (render: AttrRenderFragment, x: float) = render ==> html.renderFragment("ActivatorContent", html.text x)
    [<CustomOperation("ActivationEvent")>] member inline _.ActivationEvent (render: AttrRenderFragment, x: MudBlazor.MouseEvent) = render ==> ("ActivationEvent" => x)
    [<CustomOperation("AnchorOrigin")>] member inline _.AnchorOrigin (render: AttrRenderFragment, x: MudBlazor.Origin) = render ==> ("AnchorOrigin" => x)
    [<CustomOperation("TransformOrigin")>] member inline _.TransformOrigin (render: AttrRenderFragment, x: MudBlazor.Origin) = render ==> ("TransformOrigin" => x)
    [<CustomOperation("LockScroll")>] member inline _.LockScroll (render: AttrRenderFragment, x: System.Boolean) = render ==> ("LockScroll" => x)
    [<CustomOperation("Disabled")>] member inline _.Disabled (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Disabled" => x)
    [<CustomOperation("DisableRipple")>] member inline _.DisableRipple (render: AttrRenderFragment, x: System.Boolean) = render ==> ("DisableRipple" => x)
    [<CustomOperation("DisableElevation")>] member inline _.DisableElevation (render: AttrRenderFragment, x: System.Boolean) = render ==> ("DisableElevation" => x)
                

type MudMenuItemBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Disabled")>] member inline _.Disabled (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Disabled" => x)
    [<CustomOperation("Link")>] member inline _.Link (render: AttrRenderFragment, x: System.String) = render ==> ("Link" => x)
    [<CustomOperation("Target")>] member inline _.Target (render: AttrRenderFragment, x: System.String) = render ==> ("Target" => x)
    [<CustomOperation("ForceLoad")>] member inline _.ForceLoad (render: AttrRenderFragment, x: System.Boolean) = render ==> ("ForceLoad" => x)
    [<CustomOperation("Command")>] member inline _.Command (render: AttrRenderFragment, x: System.Windows.Input.ICommand) = render ==> ("Command" => x)
    [<CustomOperation("CommandParameter")>] member inline _.CommandParameter (render: AttrRenderFragment, x: System.Object) = render ==> ("CommandParameter" => x)
    [<CustomOperation("OnClick")>] member inline _.OnClick (render: AttrRenderFragment, fn) = render ==> html.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>("OnClick", fn)
                

type MudMessageBoxBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Title")>] member inline _.Title (render: AttrRenderFragment, x: System.String) = render ==> ("Title" => x)
    [<CustomOperation("TitleContent")>] member inline _.TitleContent (render: AttrRenderFragment, fragment) = render ==> html.renderFragment("TitleContent", fragment)
    [<CustomOperation("TitleContent")>] member inline _.TitleContent (render: AttrRenderFragment, x: string) = render ==> html.renderFragment("TitleContent", html.text x)
    [<CustomOperation("TitleContent")>] member inline _.TitleContent (render: AttrRenderFragment, x: int) = render ==> html.renderFragment("TitleContent", html.text x)
    [<CustomOperation("TitleContent")>] member inline _.TitleContent (render: AttrRenderFragment, x: float) = render ==> html.renderFragment("TitleContent", html.text x)
    [<CustomOperation("Message")>] member inline _.Message (render: AttrRenderFragment, x: System.String) = render ==> ("Message" => x)
    [<CustomOperation("MessageContent")>] member inline _.MessageContent (render: AttrRenderFragment, fragment) = render ==> html.renderFragment("MessageContent", fragment)
    [<CustomOperation("MessageContent")>] member inline _.MessageContent (render: AttrRenderFragment, x: string) = render ==> html.renderFragment("MessageContent", html.text x)
    [<CustomOperation("MessageContent")>] member inline _.MessageContent (render: AttrRenderFragment, x: int) = render ==> html.renderFragment("MessageContent", html.text x)
    [<CustomOperation("MessageContent")>] member inline _.MessageContent (render: AttrRenderFragment, x: float) = render ==> html.renderFragment("MessageContent", html.text x)
    [<CustomOperation("CancelText")>] member inline _.CancelText (render: AttrRenderFragment, x: System.String) = render ==> ("CancelText" => x)
    [<CustomOperation("CancelButton")>] member inline _.CancelButton (render: AttrRenderFragment, fragment) = render ==> html.renderFragment("CancelButton", fragment)
    [<CustomOperation("CancelButton")>] member inline _.CancelButton (render: AttrRenderFragment, x: string) = render ==> html.renderFragment("CancelButton", html.text x)
    [<CustomOperation("CancelButton")>] member inline _.CancelButton (render: AttrRenderFragment, x: int) = render ==> html.renderFragment("CancelButton", html.text x)
    [<CustomOperation("CancelButton")>] member inline _.CancelButton (render: AttrRenderFragment, x: float) = render ==> html.renderFragment("CancelButton", html.text x)
    [<CustomOperation("NoText")>] member inline _.NoText (render: AttrRenderFragment, x: System.String) = render ==> ("NoText" => x)
    [<CustomOperation("NoButton")>] member inline _.NoButton (render: AttrRenderFragment, fragment) = render ==> html.renderFragment("NoButton", fragment)
    [<CustomOperation("NoButton")>] member inline _.NoButton (render: AttrRenderFragment, x: string) = render ==> html.renderFragment("NoButton", html.text x)
    [<CustomOperation("NoButton")>] member inline _.NoButton (render: AttrRenderFragment, x: int) = render ==> html.renderFragment("NoButton", html.text x)
    [<CustomOperation("NoButton")>] member inline _.NoButton (render: AttrRenderFragment, x: float) = render ==> html.renderFragment("NoButton", html.text x)
    [<CustomOperation("YesText")>] member inline _.YesText (render: AttrRenderFragment, x: System.String) = render ==> ("YesText" => x)
    [<CustomOperation("YesButton")>] member inline _.YesButton (render: AttrRenderFragment, fragment) = render ==> html.renderFragment("YesButton", fragment)
    [<CustomOperation("YesButton")>] member inline _.YesButton (render: AttrRenderFragment, x: string) = render ==> html.renderFragment("YesButton", html.text x)
    [<CustomOperation("YesButton")>] member inline _.YesButton (render: AttrRenderFragment, x: int) = render ==> html.renderFragment("YesButton", html.text x)
    [<CustomOperation("YesButton")>] member inline _.YesButton (render: AttrRenderFragment, x: float) = render ==> html.renderFragment("YesButton", html.text x)
    [<CustomOperation("OnYes")>] member inline _.OnYes (render: AttrRenderFragment, fn) = render ==> html.callback<System.Boolean>("OnYes", fn)
    [<CustomOperation("OnNo")>] member inline _.OnNo (render: AttrRenderFragment, fn) = render ==> html.callback<System.Boolean>("OnNo", fn)
    [<CustomOperation("OnCancel")>] member inline _.OnCancel (render: AttrRenderFragment, fn) = render ==> html.callback<System.Boolean>("OnCancel", fn)
    [<CustomOperation("IsVisible")>] member inline _.IsVisible (render: AttrRenderFragment, x: System.Boolean) = render ==> ("IsVisible" => x)
    [<CustomOperation("IsVisible'")>] member inline _.IsVisible' (render: AttrRenderFragment, value: IStore<System.Boolean>) = render ==> html.bind("IsVisible", value)
    [<CustomOperation("IsVisible'")>] member inline _.IsVisible' (render: AttrRenderFragment, value: cval<System.Boolean>) = render ==> html.bind("IsVisible", value)
    [<CustomOperation("IsVisible'")>] member inline _.IsVisible' (render: AttrRenderFragment, valueFn: System.Boolean * (System.Boolean -> unit)) = render ==> html.bind("IsVisible", valueFn)
    [<CustomOperation("IsVisibleChanged")>] member inline _.IsVisibleChanged (render: AttrRenderFragment, fn) = render ==> html.callback<System.Boolean>("IsVisibleChanged", fn)
                

type MudNavGroupBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Title")>] member inline _.Title (render: AttrRenderFragment, x: System.String) = render ==> ("Title" => x)
    [<CustomOperation("Icon")>] member inline _.Icon (render: AttrRenderFragment, x: System.String) = render ==> ("Icon" => x)
    [<CustomOperation("IconColor")>] member inline _.IconColor (render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("IconColor" => x)
    [<CustomOperation("Disabled")>] member inline _.Disabled (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Disabled" => x)
    [<CustomOperation("DisableRipple")>] member inline _.DisableRipple (render: AttrRenderFragment, x: System.Boolean) = render ==> ("DisableRipple" => x)
    [<CustomOperation("Expanded")>] member inline _.Expanded (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Expanded" => x)
    [<CustomOperation("Expanded'")>] member inline _.Expanded' (render: AttrRenderFragment, value: IStore<System.Boolean>) = render ==> html.bind("Expanded", value)
    [<CustomOperation("Expanded'")>] member inline _.Expanded' (render: AttrRenderFragment, value: cval<System.Boolean>) = render ==> html.bind("Expanded", value)
    [<CustomOperation("Expanded'")>] member inline _.Expanded' (render: AttrRenderFragment, valueFn: System.Boolean * (System.Boolean -> unit)) = render ==> html.bind("Expanded", valueFn)
    [<CustomOperation("ExpandedChanged")>] member inline _.ExpandedChanged (render: AttrRenderFragment, fn) = render ==> html.callback<System.Boolean>("ExpandedChanged", fn)
    [<CustomOperation("HideExpandIcon")>] member inline _.HideExpandIcon (render: AttrRenderFragment, x: System.Boolean) = render ==> ("HideExpandIcon" => x)
    [<CustomOperation("MaxHeight")>] member inline _.MaxHeight (render: AttrRenderFragment, x: System.Nullable<System.Int32>) = render ==> ("MaxHeight" => x)
    [<CustomOperation("ExpandIcon")>] member inline _.ExpandIcon (render: AttrRenderFragment, x: System.String) = render ==> ("ExpandIcon" => x)
                

type MudNavMenuBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Color")>] member inline _.Color (render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("Color" => x)
    [<CustomOperation("Bordered")>] member inline _.Bordered (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Bordered" => x)
    [<CustomOperation("Rounded")>] member inline _.Rounded (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Rounded" => x)
    [<CustomOperation("Margin")>] member inline _.Margin (render: AttrRenderFragment, x: MudBlazor.Margin) = render ==> ("Margin" => x)
    [<CustomOperation("Dense")>] member inline _.Dense (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Dense" => x)
                

type MudOverlayBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("VisibleChanged")>] member inline _.VisibleChanged (render: AttrRenderFragment, fn) = render ==> html.callback<System.Boolean>("VisibleChanged", fn)
    [<CustomOperation("Visible")>] member inline _.Visible (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Visible" => x)
    [<CustomOperation("Visible'")>] member inline _.Visible' (render: AttrRenderFragment, value: IStore<System.Boolean>) = render ==> html.bind("Visible", value)
    [<CustomOperation("Visible'")>] member inline _.Visible' (render: AttrRenderFragment, value: cval<System.Boolean>) = render ==> html.bind("Visible", value)
    [<CustomOperation("Visible'")>] member inline _.Visible' (render: AttrRenderFragment, valueFn: System.Boolean * (System.Boolean -> unit)) = render ==> html.bind("Visible", valueFn)
    [<CustomOperation("AutoClose")>] member inline _.AutoClose (render: AttrRenderFragment, x: System.Boolean) = render ==> ("AutoClose" => x)
    [<CustomOperation("LockScroll")>] member inline _.LockScroll (render: AttrRenderFragment, x: System.Boolean) = render ==> ("LockScroll" => x)
    [<CustomOperation("LockScrollClass")>] member inline _.LockScrollClass (render: AttrRenderFragment, x: System.String) = render ==> ("LockScrollClass" => x)
    [<CustomOperation("DarkBackground")>] member inline _.DarkBackground (render: AttrRenderFragment, x: System.Boolean) = render ==> ("DarkBackground" => x)
    [<CustomOperation("LightBackground")>] member inline _.LightBackground (render: AttrRenderFragment, x: System.Boolean) = render ==> ("LightBackground" => x)
    [<CustomOperation("Absolute")>] member inline _.Absolute (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Absolute" => x)
    [<CustomOperation("ZIndex")>] member inline _.ZIndex (render: AttrRenderFragment, x: System.Int32) = render ==> ("ZIndex" => x)
    [<CustomOperation("CommandParameter")>] member inline _.CommandParameter (render: AttrRenderFragment, x: System.Object) = render ==> ("CommandParameter" => x)
    [<CustomOperation("Command")>] member inline _.Command (render: AttrRenderFragment, x: System.Windows.Input.ICommand) = render ==> ("Command" => x)
    [<CustomOperation("OnClick")>] member inline _.OnClick (render: AttrRenderFragment, fn) = render ==> html.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>("OnClick", fn)
                

type MudPageContentNavigationBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Headline")>] member inline _.Headline (render: AttrRenderFragment, x: System.String) = render ==> ("Headline" => x)
    [<CustomOperation("SectionClassSelector")>] member inline _.SectionClassSelector (render: AttrRenderFragment, x: System.String) = render ==> ("SectionClassSelector" => x)
    [<CustomOperation("ActivateFirstSectionAsDefault")>] member inline _.ActivateFirstSectionAsDefault (render: AttrRenderFragment, x: System.Boolean) = render ==> ("ActivateFirstSectionAsDefault" => x)
                

type MudPaginationBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Count")>] member inline _.Count (render: AttrRenderFragment, x: System.Int32) = render ==> ("Count" => x)
    [<CustomOperation("BoundaryCount")>] member inline _.BoundaryCount (render: AttrRenderFragment, x: System.Int32) = render ==> ("BoundaryCount" => x)
    [<CustomOperation("MiddleCount")>] member inline _.MiddleCount (render: AttrRenderFragment, x: System.Int32) = render ==> ("MiddleCount" => x)
    [<CustomOperation("Selected")>] member inline _.Selected (render: AttrRenderFragment, x: System.Int32) = render ==> ("Selected" => x)
    [<CustomOperation("Selected'")>] member inline _.Selected' (render: AttrRenderFragment, value: IStore<System.Int32>) = render ==> html.bind("Selected", value)
    [<CustomOperation("Selected'")>] member inline _.Selected' (render: AttrRenderFragment, value: cval<System.Int32>) = render ==> html.bind("Selected", value)
    [<CustomOperation("Selected'")>] member inline _.Selected' (render: AttrRenderFragment, valueFn: System.Int32 * (System.Int32 -> unit)) = render ==> html.bind("Selected", valueFn)
    [<CustomOperation("Variant")>] member inline _.Variant (render: AttrRenderFragment, x: MudBlazor.Variant) = render ==> ("Variant" => x)
    [<CustomOperation("Color")>] member inline _.Color (render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("Color" => x)
    [<CustomOperation("Rectangular")>] member inline _.Rectangular (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Rectangular" => x)
    [<CustomOperation("Size")>] member inline _.Size (render: AttrRenderFragment, x: MudBlazor.Size) = render ==> ("Size" => x)
    [<CustomOperation("DisableElevation")>] member inline _.DisableElevation (render: AttrRenderFragment, x: System.Boolean) = render ==> ("DisableElevation" => x)
    [<CustomOperation("Disabled")>] member inline _.Disabled (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Disabled" => x)
    [<CustomOperation("ShowFirstButton")>] member inline _.ShowFirstButton (render: AttrRenderFragment, x: System.Boolean) = render ==> ("ShowFirstButton" => x)
    [<CustomOperation("ShowLastButton")>] member inline _.ShowLastButton (render: AttrRenderFragment, x: System.Boolean) = render ==> ("ShowLastButton" => x)
    [<CustomOperation("ShowPreviousButton")>] member inline _.ShowPreviousButton (render: AttrRenderFragment, x: System.Boolean) = render ==> ("ShowPreviousButton" => x)
    [<CustomOperation("ShowNextButton")>] member inline _.ShowNextButton (render: AttrRenderFragment, x: System.Boolean) = render ==> ("ShowNextButton" => x)
    [<CustomOperation("ControlButtonClicked")>] member inline _.ControlButtonClicked (render: AttrRenderFragment, fn) = render ==> html.callback<MudBlazor.Page>("ControlButtonClicked", fn)
    [<CustomOperation("SelectedChanged")>] member inline _.SelectedChanged (render: AttrRenderFragment, fn) = render ==> html.callback<System.Int32>("SelectedChanged", fn)
    [<CustomOperation("FirstIcon")>] member inline _.FirstIcon (render: AttrRenderFragment, x: System.String) = render ==> ("FirstIcon" => x)
    [<CustomOperation("BeforeIcon")>] member inline _.BeforeIcon (render: AttrRenderFragment, x: System.String) = render ==> ("BeforeIcon" => x)
    [<CustomOperation("NextIcon")>] member inline _.NextIcon (render: AttrRenderFragment, x: System.String) = render ==> ("NextIcon" => x)
    [<CustomOperation("LastIcon")>] member inline _.LastIcon (render: AttrRenderFragment, x: System.String) = render ==> ("LastIcon" => x)
                

type MudPopoverBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("MaxHeight")>] member inline _.MaxHeight (render: AttrRenderFragment, x: System.Nullable<System.Int32>) = render ==> ("MaxHeight" => x)
    [<CustomOperation("Paper")>] member inline _.Paper (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Paper" => x)
    [<CustomOperation("Elevation")>] member inline _.Elevation (render: AttrRenderFragment, x: System.Int32) = render ==> ("Elevation" => x)
    [<CustomOperation("Square")>] member inline _.Square (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Square" => x)
    [<CustomOperation("Open")>] member inline _.Open (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Open" => x)
    [<CustomOperation("Fixed")>] member inline _.Fixed (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Fixed" => x)
    [<CustomOperation("Duration")>] member inline _.Duration (render: AttrRenderFragment, x: System.Double) = render ==> ("Duration" => x)
    [<CustomOperation("Delay'")>] member inline _.Delay' (render: AttrRenderFragment, x: System.Double) = render ==> ("Delay" => x)
    [<CustomOperation("AnchorOrigin")>] member inline _.AnchorOrigin (render: AttrRenderFragment, x: MudBlazor.Origin) = render ==> ("AnchorOrigin" => x)
    [<CustomOperation("TransformOrigin")>] member inline _.TransformOrigin (render: AttrRenderFragment, x: MudBlazor.Origin) = render ==> ("TransformOrigin" => x)
    [<CustomOperation("OverflowBehavior")>] member inline _.OverflowBehavior (render: AttrRenderFragment, x: MudBlazor.OverflowBehavior) = render ==> ("OverflowBehavior" => x)
    [<CustomOperation("RelativeWidth")>] member inline _.RelativeWidth (render: AttrRenderFragment, x: System.Boolean) = render ==> ("RelativeWidth" => x)
                

type MudProgressCircularBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Color")>] member inline _.Color (render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("Color" => x)
    [<CustomOperation("Size")>] member inline _.Size (render: AttrRenderFragment, x: MudBlazor.Size) = render ==> ("Size" => x)
    [<CustomOperation("Indeterminate")>] member inline _.Indeterminate (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Indeterminate" => x)
    [<CustomOperation("Min")>] member inline _.Min (render: AttrRenderFragment, x: System.Double) = render ==> ("Min" => x)
    [<CustomOperation("Max")>] member inline _.Max (render: AttrRenderFragment, x: System.Double) = render ==> ("Max" => x)
    [<CustomOperation("Value")>] member inline _.Value (render: AttrRenderFragment, x: System.Double) = render ==> ("Value" => x)
    [<CustomOperation("StrokeWidth")>] member inline _.StrokeWidth (render: AttrRenderFragment, x: System.Int32) = render ==> ("StrokeWidth" => x)
                

type MudProgressLinearBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Color")>] member inline _.Color (render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("Color" => x)
    [<CustomOperation("Size")>] member inline _.Size (render: AttrRenderFragment, x: MudBlazor.Size) = render ==> ("Size" => x)
    [<CustomOperation("Indeterminate")>] member inline _.Indeterminate (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Indeterminate" => x)
    [<CustomOperation("Buffer")>] member inline _.Buffer (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Buffer" => x)
    [<CustomOperation("Rounded")>] member inline _.Rounded (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Rounded" => x)
    [<CustomOperation("Striped")>] member inline _.Striped (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Striped" => x)
    [<CustomOperation("Vertical")>] member inline _.Vertical (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Vertical" => x)
    [<CustomOperation("Min")>] member inline _.Min (render: AttrRenderFragment, x: System.Double) = render ==> ("Min" => x)
    [<CustomOperation("Max")>] member inline _.Max (render: AttrRenderFragment, x: System.Double) = render ==> ("Max" => x)
    [<CustomOperation("Value")>] member inline _.Value (render: AttrRenderFragment, x: System.Double) = render ==> ("Value" => x)
    [<CustomOperation("BufferValue")>] member inline _.BufferValue (render: AttrRenderFragment, x: System.Double) = render ==> ("BufferValue" => x)
                

type MudRadioBuilder<'FunBlazorGeneric, 'T when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Color")>] member inline _.Color (render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("Color" => x)
    [<CustomOperation("Placement")>] member inline _.Placement (render: AttrRenderFragment, x: MudBlazor.Placement) = render ==> ("Placement" => x)
    [<CustomOperation("Option")>] member inline _.Option (render: AttrRenderFragment, x: 'T) = render ==> ("Option" => x)
    [<CustomOperation("Dense")>] member inline _.Dense (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Dense" => x)
    [<CustomOperation("Size")>] member inline _.Size (render: AttrRenderFragment, x: MudBlazor.Size) = render ==> ("Size" => x)
    [<CustomOperation("DisableRipple")>] member inline _.DisableRipple (render: AttrRenderFragment, x: System.Boolean) = render ==> ("DisableRipple" => x)
    [<CustomOperation("Disabled")>] member inline _.Disabled (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Disabled" => x)
                

type MudRatingBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("RatingItemsClass")>] member inline _.RatingItemsClass (render: AttrRenderFragment, x: System.String) = render ==> ("RatingItemsClass" => x)
    [<CustomOperation("RatingItemsStyle")>] member inline _.RatingItemsStyle (render: AttrRenderFragment, x: System.String) = render ==> ("RatingItemsStyle" => x)
    [<CustomOperation("Name")>] member inline _.Name (render: AttrRenderFragment, x: System.String) = render ==> ("Name" => x)
    [<CustomOperation("MaxValue")>] member inline _.MaxValue (render: AttrRenderFragment, x: System.Int32) = render ==> ("MaxValue" => x)
    [<CustomOperation("FullIcon")>] member inline _.FullIcon (render: AttrRenderFragment, x: System.String) = render ==> ("FullIcon" => x)
    [<CustomOperation("EmptyIcon")>] member inline _.EmptyIcon (render: AttrRenderFragment, x: System.String) = render ==> ("EmptyIcon" => x)
    [<CustomOperation("Color")>] member inline _.Color (render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("Color" => x)
    [<CustomOperation("Size")>] member inline _.Size (render: AttrRenderFragment, x: MudBlazor.Size) = render ==> ("Size" => x)
    [<CustomOperation("DisableRipple")>] member inline _.DisableRipple (render: AttrRenderFragment, x: System.Boolean) = render ==> ("DisableRipple" => x)
    [<CustomOperation("Disabled")>] member inline _.Disabled (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Disabled" => x)
    [<CustomOperation("ReadOnly")>] member inline _.ReadOnly (render: AttrRenderFragment, x: System.Boolean) = render ==> ("ReadOnly" => x)
    [<CustomOperation("SelectedValueChanged")>] member inline _.SelectedValueChanged (render: AttrRenderFragment, fn) = render ==> html.callback<System.Int32>("SelectedValueChanged", fn)
    [<CustomOperation("SelectedValue")>] member inline _.SelectedValue (render: AttrRenderFragment, x: System.Int32) = render ==> ("SelectedValue" => x)
    [<CustomOperation("SelectedValue'")>] member inline _.SelectedValue' (render: AttrRenderFragment, value: IStore<System.Int32>) = render ==> html.bind("SelectedValue", value)
    [<CustomOperation("SelectedValue'")>] member inline _.SelectedValue' (render: AttrRenderFragment, value: cval<System.Int32>) = render ==> html.bind("SelectedValue", value)
    [<CustomOperation("SelectedValue'")>] member inline _.SelectedValue' (render: AttrRenderFragment, valueFn: System.Int32 * (System.Int32 -> unit)) = render ==> html.bind("SelectedValue", valueFn)
    [<CustomOperation("HoveredValueChanged")>] member inline _.HoveredValueChanged (render: AttrRenderFragment, fn) = render ==> html.callback<System.Nullable<System.Int32>>("HoveredValueChanged", fn)
                

type MudRatingItemBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("ItemValue")>] member inline _.ItemValue (render: AttrRenderFragment, x: System.Int32) = render ==> ("ItemValue" => x)
    [<CustomOperation("Size")>] member inline _.Size (render: AttrRenderFragment, x: MudBlazor.Size) = render ==> ("Size" => x)
    [<CustomOperation("Color")>] member inline _.Color (render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("Color" => x)
    [<CustomOperation("DisableRipple")>] member inline _.DisableRipple (render: AttrRenderFragment, x: System.Boolean) = render ==> ("DisableRipple" => x)
    [<CustomOperation("Disabled")>] member inline _.Disabled (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Disabled" => x)
    [<CustomOperation("ReadOnly")>] member inline _.ReadOnly (render: AttrRenderFragment, x: System.Boolean) = render ==> ("ReadOnly" => x)
    [<CustomOperation("ItemClicked")>] member inline _.ItemClicked (render: AttrRenderFragment, fn) = render ==> html.callback<System.Int32>("ItemClicked", fn)
    [<CustomOperation("ItemHovered")>] member inline _.ItemHovered (render: AttrRenderFragment, fn) = render ==> html.callback<System.Nullable<System.Int32>>("ItemHovered", fn)
                

type MudRTLProviderBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("RightToLeft")>] member inline _.RightToLeft (render: AttrRenderFragment, x: System.Boolean) = render ==> ("RightToLeft" => x)
                

type MudScrollToTopBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Selector")>] member inline _.Selector (render: AttrRenderFragment, x: System.String) = render ==> ("Selector" => x)
    [<CustomOperation("Visible")>] member inline _.Visible (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Visible" => x)
    [<CustomOperation("VisibleCssClass")>] member inline _.VisibleCssClass (render: AttrRenderFragment, x: System.String) = render ==> ("VisibleCssClass" => x)
    [<CustomOperation("HiddenCssClass")>] member inline _.HiddenCssClass (render: AttrRenderFragment, x: System.String) = render ==> ("HiddenCssClass" => x)
    [<CustomOperation("TopOffset")>] member inline _.TopOffset (render: AttrRenderFragment, x: System.Int32) = render ==> ("TopOffset" => x)
    [<CustomOperation("ScrollBehavior")>] member inline _.ScrollBehavior (render: AttrRenderFragment, x: MudBlazor.ScrollBehavior) = render ==> ("ScrollBehavior" => x)
    [<CustomOperation("OnScroll")>] member inline _.OnScroll (render: AttrRenderFragment, fn) = render ==> html.callback<MudBlazor.ScrollEventArgs>("OnScroll", fn)
                

type MudSkeletonBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Width")>] member inline _.Width (render: AttrRenderFragment, x: System.String) = render ==> ("Width" => x)
    [<CustomOperation("Height")>] member inline _.Height (render: AttrRenderFragment, x: System.String) = render ==> ("Height" => x)
    [<CustomOperation("SkeletonType")>] member inline _.SkeletonType (render: AttrRenderFragment, x: MudBlazor.SkeletonType) = render ==> ("SkeletonType" => x)
    [<CustomOperation("Animation")>] member inline _.Animation (render: AttrRenderFragment, x: MudBlazor.Animation) = render ==> ("Animation" => x)
                

type MudSliderBuilder<'FunBlazorGeneric, 'T when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Min")>] member inline _.Min (render: AttrRenderFragment, x: 'T) = render ==> ("Min" => x)
    [<CustomOperation("Max")>] member inline _.Max (render: AttrRenderFragment, x: 'T) = render ==> ("Max" => x)
    [<CustomOperation("Step")>] member inline _.Step (render: AttrRenderFragment, x: 'T) = render ==> ("Step" => x)
    [<CustomOperation("Disabled")>] member inline _.Disabled (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Disabled" => x)
    [<CustomOperation("Converter")>] member inline _.Converter (render: AttrRenderFragment, x: MudBlazor.Converter<'T>) = render ==> ("Converter" => x)
    [<CustomOperation("ValueChanged")>] member inline _.ValueChanged (render: AttrRenderFragment, fn) = render ==> html.callback<'T>("ValueChanged", fn)
    [<CustomOperation("Value")>] member inline _.Value (render: AttrRenderFragment, x: 'T) = render ==> ("Value" => x)
    [<CustomOperation("Value'")>] member inline _.Value' (render: AttrRenderFragment, value: IStore<'T>) = render ==> html.bind("Value", value)
    [<CustomOperation("Value'")>] member inline _.Value' (render: AttrRenderFragment, value: cval<'T>) = render ==> html.bind("Value", value)
    [<CustomOperation("Value'")>] member inline _.Value' (render: AttrRenderFragment, valueFn: 'T * ('T -> unit)) = render ==> html.bind("Value", valueFn)
    [<CustomOperation("Color")>] member inline _.Color (render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("Color" => x)
    [<CustomOperation("Immediate")>] member inline _.Immediate (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Immediate" => x)
                

type MudSnackbarElementBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Snackbar")>] member inline _.Snackbar (render: AttrRenderFragment, x: MudBlazor.Snackbar) = render ==> ("Snackbar" => x)
    [<CustomOperation("CloseIcon")>] member inline _.CloseIcon (render: AttrRenderFragment, x: System.String) = render ==> ("CloseIcon" => x)
                

type MudSnackbarProviderBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()

                

type MudSwipeAreaBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("OnSwipe")>] member inline _.OnSwipe (render: AttrRenderFragment, fn) = render ==> ("OnSwipe" => (System.Action<MudBlazor.SwipeDirection>fn))
                

type MudSimpleTableBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Elevation")>] member inline _.Elevation (render: AttrRenderFragment, x: System.Int32) = render ==> ("Elevation" => x)
    [<CustomOperation("Hover")>] member inline _.Hover (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Hover" => x)
    [<CustomOperation("Square")>] member inline _.Square (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Square" => x)
    [<CustomOperation("Dense")>] member inline _.Dense (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Dense" => x)
    [<CustomOperation("Outlined")>] member inline _.Outlined (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Outlined" => x)
    [<CustomOperation("Bordered")>] member inline _.Bordered (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Bordered" => x)
    [<CustomOperation("Striped")>] member inline _.Striped (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Striped" => x)
    [<CustomOperation("FixedHeader")>] member inline _.FixedHeader (render: AttrRenderFragment, x: System.Boolean) = render ==> ("FixedHeader" => x)
                

type MudTableGroupRowBuilder<'FunBlazorGeneric, 'T when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("GroupDefinition")>] member inline _.GroupDefinition (render: AttrRenderFragment, x: MudBlazor.TableGroupDefinition<'T>) = render ==> ("GroupDefinition" => x)
    [<CustomOperation("Items")>] member inline _.Items (render: AttrRenderFragment, x: System.Linq.IGrouping<System.Object, 'T>) = render ==> ("Items" => x)
    [<CustomOperation("HeaderTemplate")>] member inline _.HeaderTemplate (render: AttrRenderFragment, fn: MudBlazor.TableGroupData<System.Object, 'T> -> NodeRenderFragment) = render ==> html.renderFragment("HeaderTemplate", fn)
    [<CustomOperation("FooterTemplate")>] member inline _.FooterTemplate (render: AttrRenderFragment, fn: MudBlazor.TableGroupData<System.Object, 'T> -> NodeRenderFragment) = render ==> html.renderFragment("FooterTemplate", fn)
    [<CustomOperation("IsCheckable")>] member inline _.IsCheckable (render: AttrRenderFragment, x: System.Boolean) = render ==> ("IsCheckable" => x)
    [<CustomOperation("HeaderClass")>] member inline _.HeaderClass (render: AttrRenderFragment, x: System.String) = render ==> ("HeaderClass" => x)
    [<CustomOperation("FooterClass")>] member inline _.FooterClass (render: AttrRenderFragment, x: System.String) = render ==> ("FooterClass" => x)
    [<CustomOperation("HeaderStyle")>] member inline _.HeaderStyle (render: AttrRenderFragment, x: System.String) = render ==> ("HeaderStyle" => x)
    [<CustomOperation("FooterStyle")>] member inline _.FooterStyle (render: AttrRenderFragment, x: System.String) = render ==> ("FooterStyle" => x)
    [<CustomOperation("ExpandIcon")>] member inline _.ExpandIcon (render: AttrRenderFragment, x: System.String) = render ==> ("ExpandIcon" => x)
    [<CustomOperation("CollapseIcon")>] member inline _.CollapseIcon (render: AttrRenderFragment, x: System.String) = render ==> ("CollapseIcon" => x)
    [<CustomOperation("OnRowClick")>] member inline _.OnRowClick (render: AttrRenderFragment, fn) = render ==> html.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>("OnRowClick", fn)
                

type MudTablePagerBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("HideRowsPerPage")>] member inline _.HideRowsPerPage (render: AttrRenderFragment, x: System.Boolean) = render ==> ("HideRowsPerPage" => x)
    [<CustomOperation("HidePageNumber")>] member inline _.HidePageNumber (render: AttrRenderFragment, x: System.Boolean) = render ==> ("HidePageNumber" => x)
    [<CustomOperation("HidePagination")>] member inline _.HidePagination (render: AttrRenderFragment, x: System.Boolean) = render ==> ("HidePagination" => x)
    [<CustomOperation("HorizontalAlignment")>] member inline _.HorizontalAlignment (render: AttrRenderFragment, x: MudBlazor.HorizontalAlignment) = render ==> ("HorizontalAlignment" => x)
    [<CustomOperation("PageSizeOptions")>] member inline _.PageSizeOptions (render: AttrRenderFragment, x: System.Int32[]) = render ==> ("PageSizeOptions" => x)
    [<CustomOperation("InfoFormat")>] member inline _.InfoFormat (render: AttrRenderFragment, x: System.String) = render ==> ("InfoFormat" => x)
    [<CustomOperation("RowsPerPageString")>] member inline _.RowsPerPageString (render: AttrRenderFragment, x: System.String) = render ==> ("RowsPerPageString" => x)
    [<CustomOperation("FirstIcon")>] member inline _.FirstIcon (render: AttrRenderFragment, x: System.String) = render ==> ("FirstIcon" => x)
    [<CustomOperation("BeforeIcon")>] member inline _.BeforeIcon (render: AttrRenderFragment, x: System.String) = render ==> ("BeforeIcon" => x)
    [<CustomOperation("NextIcon")>] member inline _.NextIcon (render: AttrRenderFragment, x: System.String) = render ==> ("NextIcon" => x)
    [<CustomOperation("LastIcon")>] member inline _.LastIcon (render: AttrRenderFragment, x: System.String) = render ==> ("LastIcon" => x)
                

type MudTableSortLabelBuilder<'FunBlazorGeneric, 'T when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("InitialDirection")>] member inline _.InitialDirection (render: AttrRenderFragment, x: MudBlazor.SortDirection) = render ==> ("InitialDirection" => x)
    [<CustomOperation("Enabled")>] member inline _.Enabled (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Enabled" => x)
    [<CustomOperation("SortIcon")>] member inline _.SortIcon (render: AttrRenderFragment, x: System.String) = render ==> ("SortIcon" => x)
    [<CustomOperation("AppendIcon")>] member inline _.AppendIcon (render: AttrRenderFragment, x: System.Boolean) = render ==> ("AppendIcon" => x)
    [<CustomOperation("SortDirection")>] member inline _.SortDirection (render: AttrRenderFragment, x: MudBlazor.SortDirection) = render ==> ("SortDirection" => x)
    [<CustomOperation("SortDirection'")>] member inline _.SortDirection' (render: AttrRenderFragment, value: IStore<MudBlazor.SortDirection>) = render ==> html.bind("SortDirection", value)
    [<CustomOperation("SortDirection'")>] member inline _.SortDirection' (render: AttrRenderFragment, value: cval<MudBlazor.SortDirection>) = render ==> html.bind("SortDirection", value)
    [<CustomOperation("SortDirection'")>] member inline _.SortDirection' (render: AttrRenderFragment, valueFn: MudBlazor.SortDirection * (MudBlazor.SortDirection -> unit)) = render ==> html.bind("SortDirection", valueFn)
    [<CustomOperation("SortDirectionChanged")>] member inline _.SortDirectionChanged (render: AttrRenderFragment, fn) = render ==> html.callback<MudBlazor.SortDirection>("SortDirectionChanged", fn)
    [<CustomOperation("SortBy")>] member inline _.SortBy (render: AttrRenderFragment, fn) = render ==> ("SortBy" => (System.Func<'T, System.Object>fn))
    [<CustomOperation("SortLabel")>] member inline _.SortLabel (render: AttrRenderFragment, x: System.String) = render ==> ("SortLabel" => x)
                

type MudTdBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("DataLabel")>] member inline _.DataLabel (render: AttrRenderFragment, x: System.String) = render ==> ("DataLabel" => x)
    [<CustomOperation("HideSmall")>] member inline _.HideSmall (render: AttrRenderFragment, x: System.Boolean) = render ==> ("HideSmall" => x)
                

type MudTFootRowBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("IsCheckable")>] member inline _.IsCheckable (render: AttrRenderFragment, x: System.Boolean) = render ==> ("IsCheckable" => x)
    [<CustomOperation("IgnoreCheckbox")>] member inline _.IgnoreCheckbox (render: AttrRenderFragment, x: System.Boolean) = render ==> ("IgnoreCheckbox" => x)
    [<CustomOperation("IgnoreEditable")>] member inline _.IgnoreEditable (render: AttrRenderFragment, x: System.Boolean) = render ==> ("IgnoreEditable" => x)
    [<CustomOperation("IsExpandable")>] member inline _.IsExpandable (render: AttrRenderFragment, x: System.Boolean) = render ==> ("IsExpandable" => x)
    [<CustomOperation("OnRowClick")>] member inline _.OnRowClick (render: AttrRenderFragment, fn) = render ==> html.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>("OnRowClick", fn)
                

type MudThBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()

                

type MudTHeadRowBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("IsCheckable")>] member inline _.IsCheckable (render: AttrRenderFragment, x: System.Boolean) = render ==> ("IsCheckable" => x)
    [<CustomOperation("IgnoreCheckbox")>] member inline _.IgnoreCheckbox (render: AttrRenderFragment, x: System.Boolean) = render ==> ("IgnoreCheckbox" => x)
    [<CustomOperation("IgnoreEditable")>] member inline _.IgnoreEditable (render: AttrRenderFragment, x: System.Boolean) = render ==> ("IgnoreEditable" => x)
    [<CustomOperation("IsExpandable")>] member inline _.IsExpandable (render: AttrRenderFragment, x: System.Boolean) = render ==> ("IsExpandable" => x)
    [<CustomOperation("OnRowClick")>] member inline _.OnRowClick (render: AttrRenderFragment, fn) = render ==> html.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>("OnRowClick", fn)
                

type MudTrBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Item")>] member inline _.Item (render: AttrRenderFragment, x: System.Object) = render ==> ("Item" => x)
    [<CustomOperation("IsCheckable")>] member inline _.IsCheckable (render: AttrRenderFragment, x: System.Boolean) = render ==> ("IsCheckable" => x)
    [<CustomOperation("IsEditable")>] member inline _.IsEditable (render: AttrRenderFragment, x: System.Boolean) = render ==> ("IsEditable" => x)
    [<CustomOperation("IsEditing")>] member inline _.IsEditing (render: AttrRenderFragment, x: System.Boolean) = render ==> ("IsEditing" => x)
    [<CustomOperation("IsEditSwitchBlocked")>] member inline _.IsEditSwitchBlocked (render: AttrRenderFragment, x: System.Boolean) = render ==> ("IsEditSwitchBlocked" => x)
    [<CustomOperation("IsExpandable")>] member inline _.IsExpandable (render: AttrRenderFragment, x: System.Boolean) = render ==> ("IsExpandable" => x)
    [<CustomOperation("IsHeader")>] member inline _.IsHeader (render: AttrRenderFragment, x: System.Boolean) = render ==> ("IsHeader" => x)
    [<CustomOperation("IsFooter")>] member inline _.IsFooter (render: AttrRenderFragment, x: System.Boolean) = render ==> ("IsFooter" => x)
    [<CustomOperation("IsCheckedChanged")>] member inline _.IsCheckedChanged (render: AttrRenderFragment, fn) = render ==> html.callback<System.Boolean>("IsCheckedChanged", fn)
    [<CustomOperation("IsChecked")>] member inline _.IsChecked (render: AttrRenderFragment, x: System.Boolean) = render ==> ("IsChecked" => x)
    [<CustomOperation("IsChecked'")>] member inline _.IsChecked' (render: AttrRenderFragment, value: IStore<System.Boolean>) = render ==> html.bind("IsChecked", value)
    [<CustomOperation("IsChecked'")>] member inline _.IsChecked' (render: AttrRenderFragment, value: cval<System.Boolean>) = render ==> html.bind("IsChecked", value)
    [<CustomOperation("IsChecked'")>] member inline _.IsChecked' (render: AttrRenderFragment, valueFn: System.Boolean * (System.Boolean -> unit)) = render ==> html.bind("IsChecked", valueFn)
                

type MudTimelineItemBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Icon")>] member inline _.Icon (render: AttrRenderFragment, x: System.String) = render ==> ("Icon" => x)
    [<CustomOperation("Variant")>] member inline _.Variant (render: AttrRenderFragment, x: MudBlazor.Variant) = render ==> ("Variant" => x)
    [<CustomOperation("Color")>] member inline _.Color (render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("Color" => x)
    [<CustomOperation("Size")>] member inline _.Size (render: AttrRenderFragment, x: MudBlazor.Size) = render ==> ("Size" => x)
    [<CustomOperation("Elevation")>] member inline _.Elevation (render: AttrRenderFragment, x: System.Int32) = render ==> ("Elevation" => x)
    [<CustomOperation("TimelineAlign")>] member inline _.TimelineAlign (render: AttrRenderFragment, x: MudBlazor.TimelineAlign) = render ==> ("TimelineAlign" => x)
    [<CustomOperation("HideDot")>] member inline _.HideDot (render: AttrRenderFragment, x: System.Boolean) = render ==> ("HideDot" => x)
    [<CustomOperation("ItemOpposite")>] member inline _.ItemOpposite (render: AttrRenderFragment, fragment) = render ==> html.renderFragment("ItemOpposite", fragment)
    [<CustomOperation("ItemOpposite")>] member inline _.ItemOpposite (render: AttrRenderFragment, x: string) = render ==> html.renderFragment("ItemOpposite", html.text x)
    [<CustomOperation("ItemOpposite")>] member inline _.ItemOpposite (render: AttrRenderFragment, x: int) = render ==> html.renderFragment("ItemOpposite", html.text x)
    [<CustomOperation("ItemOpposite")>] member inline _.ItemOpposite (render: AttrRenderFragment, x: float) = render ==> html.renderFragment("ItemOpposite", html.text x)
    [<CustomOperation("ItemContent")>] member inline _.ItemContent (render: AttrRenderFragment, fragment) = render ==> html.renderFragment("ItemContent", fragment)
    [<CustomOperation("ItemContent")>] member inline _.ItemContent (render: AttrRenderFragment, x: string) = render ==> html.renderFragment("ItemContent", html.text x)
    [<CustomOperation("ItemContent")>] member inline _.ItemContent (render: AttrRenderFragment, x: int) = render ==> html.renderFragment("ItemContent", html.text x)
    [<CustomOperation("ItemContent")>] member inline _.ItemContent (render: AttrRenderFragment, x: float) = render ==> html.renderFragment("ItemContent", html.text x)
    [<CustomOperation("ItemDot")>] member inline _.ItemDot (render: AttrRenderFragment, fragment) = render ==> html.renderFragment("ItemDot", fragment)
    [<CustomOperation("ItemDot")>] member inline _.ItemDot (render: AttrRenderFragment, x: string) = render ==> html.renderFragment("ItemDot", html.text x)
    [<CustomOperation("ItemDot")>] member inline _.ItemDot (render: AttrRenderFragment, x: int) = render ==> html.renderFragment("ItemDot", html.text x)
    [<CustomOperation("ItemDot")>] member inline _.ItemDot (render: AttrRenderFragment, x: float) = render ==> html.renderFragment("ItemDot", html.text x)
                

type MudTooltipBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Color")>] member inline _.Color (render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("Color" => x)
    [<CustomOperation("Text")>] member inline _.Text (render: AttrRenderFragment, x: System.String) = render ==> ("Text" => x)
    [<CustomOperation("Arrow")>] member inline _.Arrow (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Arrow" => x)
    [<CustomOperation("Duration")>] member inline _.Duration (render: AttrRenderFragment, x: System.Double) = render ==> ("Duration" => x)
    [<CustomOperation("Delay'")>] member inline _.Delay' (render: AttrRenderFragment, x: System.Double) = render ==> ("Delay" => x)
    [<CustomOperation("Placement")>] member inline _.Placement (render: AttrRenderFragment, x: MudBlazor.Placement) = render ==> ("Placement" => x)
    [<CustomOperation("TooltipContent")>] member inline _.TooltipContent (render: AttrRenderFragment, fragment) = render ==> html.renderFragment("TooltipContent", fragment)
    [<CustomOperation("TooltipContent")>] member inline _.TooltipContent (render: AttrRenderFragment, x: string) = render ==> html.renderFragment("TooltipContent", html.text x)
    [<CustomOperation("TooltipContent")>] member inline _.TooltipContent (render: AttrRenderFragment, x: int) = render ==> html.renderFragment("TooltipContent", html.text x)
    [<CustomOperation("TooltipContent")>] member inline _.TooltipContent (render: AttrRenderFragment, x: float) = render ==> html.renderFragment("TooltipContent", html.text x)
    [<CustomOperation("Inline")>] member inline _.Inline (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Inline" => x)
    [<CustomOperation("IsVisible")>] member inline _.IsVisible (render: AttrRenderFragment, x: System.Boolean) = render ==> ("IsVisible" => x)
    [<CustomOperation("IsVisible'")>] member inline _.IsVisible' (render: AttrRenderFragment, value: IStore<System.Boolean>) = render ==> html.bind("IsVisible", value)
    [<CustomOperation("IsVisible'")>] member inline _.IsVisible' (render: AttrRenderFragment, value: cval<System.Boolean>) = render ==> html.bind("IsVisible", value)
    [<CustomOperation("IsVisible'")>] member inline _.IsVisible' (render: AttrRenderFragment, valueFn: System.Boolean * (System.Boolean -> unit)) = render ==> html.bind("IsVisible", valueFn)
    [<CustomOperation("IsVisibleChanged")>] member inline _.IsVisibleChanged (render: AttrRenderFragment, fn) = render ==> html.callback<System.Boolean>("IsVisibleChanged", fn)
                

type MudTreeViewBuilder<'FunBlazorGeneric, 'T when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Color")>] member inline _.Color (render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("Color" => x)
    [<CustomOperation("CheckBoxColor")>] member inline _.CheckBoxColor (render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("CheckBoxColor" => x)
    [<CustomOperation("MultiSelection")>] member inline _.MultiSelection (render: AttrRenderFragment, x: System.Boolean) = render ==> ("MultiSelection" => x)
    [<CustomOperation("ExpandOnClick")>] member inline _.ExpandOnClick (render: AttrRenderFragment, x: System.Boolean) = render ==> ("ExpandOnClick" => x)
    [<CustomOperation("Hover")>] member inline _.Hover (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Hover" => x)
    [<CustomOperation("Dense")>] member inline _.Dense (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Dense" => x)
    [<CustomOperation("Height")>] member inline _.Height (render: AttrRenderFragment, x: System.String) = render ==> ("Height" => x)
    [<CustomOperation("MaxHeight")>] member inline _.MaxHeight (render: AttrRenderFragment, x: System.String) = render ==> ("MaxHeight" => x)
    [<CustomOperation("Width")>] member inline _.Width (render: AttrRenderFragment, x: System.String) = render ==> ("Width" => x)
    [<CustomOperation("Disabled")>] member inline _.Disabled (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Disabled" => x)
    [<CustomOperation("Items")>] member inline _.Items (render: AttrRenderFragment, x: System.Collections.Generic.HashSet<'T>) = render ==> ("Items" => x)
    [<CustomOperation("SelectedValueChanged")>] member inline _.SelectedValueChanged (render: AttrRenderFragment, fn) = render ==> html.callback<'T>("SelectedValueChanged", fn)
    [<CustomOperation("SelectedValuesChanged")>] member inline _.SelectedValuesChanged (render: AttrRenderFragment, fn) = render ==> html.callback<System.Collections.Generic.HashSet<'T>>("SelectedValuesChanged", fn)
    [<CustomOperation("ItemTemplate")>] member inline _.ItemTemplate (render: AttrRenderFragment, fn: 'T -> NodeRenderFragment) = render ==> html.renderFragment("ItemTemplate", fn)
    [<CustomOperation("ServerData")>] member inline _.ServerData (render: AttrRenderFragment, fn) = render ==> ("ServerData" => (System.Func<'T, System.Threading.Tasks.Task<System.Collections.Generic.HashSet<'T>>>fn))
                

type MudTreeViewItemBuilder<'FunBlazorGeneric, 'T when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("CheckedIcon")>] member inline _.CheckedIcon (render: AttrRenderFragment, x: System.String) = render ==> ("CheckedIcon" => x)
    [<CustomOperation("UncheckedIcon")>] member inline _.UncheckedIcon (render: AttrRenderFragment, x: System.String) = render ==> ("UncheckedIcon" => x)
    [<CustomOperation("Value")>] member inline _.Value (render: AttrRenderFragment, x: 'T) = render ==> ("Value" => x)
    [<CustomOperation("Culture")>] member inline _.Culture (render: AttrRenderFragment, x: System.Globalization.CultureInfo) = render ==> ("Culture" => x)
    [<CustomOperation("Text")>] member inline _.Text (render: AttrRenderFragment, x: System.String) = render ==> ("Text" => x)
    [<CustomOperation("TextTypo")>] member inline _.TextTypo (render: AttrRenderFragment, x: MudBlazor.Typo) = render ==> ("TextTypo" => x)
    [<CustomOperation("TextClass")>] member inline _.TextClass (render: AttrRenderFragment, x: System.String) = render ==> ("TextClass" => x)
    [<CustomOperation("EndText")>] member inline _.EndText (render: AttrRenderFragment, x: System.String) = render ==> ("EndText" => x)
    [<CustomOperation("EndTextTypo")>] member inline _.EndTextTypo (render: AttrRenderFragment, x: MudBlazor.Typo) = render ==> ("EndTextTypo" => x)
    [<CustomOperation("EndTextClass")>] member inline _.EndTextClass (render: AttrRenderFragment, x: System.String) = render ==> ("EndTextClass" => x)
    [<CustomOperation("Disabled")>] member inline _.Disabled (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Disabled" => x)
    [<CustomOperation("Content")>] member inline _.Content (render: AttrRenderFragment, fragment) = render ==> html.renderFragment("Content", fragment)
    [<CustomOperation("Content")>] member inline _.Content (render: AttrRenderFragment, x: string) = render ==> html.renderFragment("Content", html.text x)
    [<CustomOperation("Content")>] member inline _.Content (render: AttrRenderFragment, x: int) = render ==> html.renderFragment("Content", html.text x)
    [<CustomOperation("Content")>] member inline _.Content (render: AttrRenderFragment, x: float) = render ==> html.renderFragment("Content", html.text x)
    [<CustomOperation("Items")>] member inline _.Items (render: AttrRenderFragment, x: System.Collections.Generic.HashSet<'T>) = render ==> ("Items" => x)
    [<CustomOperation("Command")>] member inline _.Command (render: AttrRenderFragment, x: System.Windows.Input.ICommand) = render ==> ("Command" => x)
    [<CustomOperation("Expanded")>] member inline _.Expanded (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Expanded" => x)
    [<CustomOperation("Expanded'")>] member inline _.Expanded' (render: AttrRenderFragment, value: IStore<System.Boolean>) = render ==> html.bind("Expanded", value)
    [<CustomOperation("Expanded'")>] member inline _.Expanded' (render: AttrRenderFragment, value: cval<System.Boolean>) = render ==> html.bind("Expanded", value)
    [<CustomOperation("Expanded'")>] member inline _.Expanded' (render: AttrRenderFragment, valueFn: System.Boolean * (System.Boolean -> unit)) = render ==> html.bind("Expanded", valueFn)
    [<CustomOperation("ExpandedChanged")>] member inline _.ExpandedChanged (render: AttrRenderFragment, fn) = render ==> html.callback<System.Boolean>("ExpandedChanged", fn)
    [<CustomOperation("Activated")>] member inline _.Activated (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Activated" => x)
    [<CustomOperation("Activated'")>] member inline _.Activated' (render: AttrRenderFragment, value: IStore<System.Boolean>) = render ==> html.bind("Activated", value)
    [<CustomOperation("Activated'")>] member inline _.Activated' (render: AttrRenderFragment, value: cval<System.Boolean>) = render ==> html.bind("Activated", value)
    [<CustomOperation("Activated'")>] member inline _.Activated' (render: AttrRenderFragment, valueFn: System.Boolean * (System.Boolean -> unit)) = render ==> html.bind("Activated", valueFn)
    [<CustomOperation("Selected")>] member inline _.Selected (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Selected" => x)
    [<CustomOperation("Selected'")>] member inline _.Selected' (render: AttrRenderFragment, value: IStore<System.Boolean>) = render ==> html.bind("Selected", value)
    [<CustomOperation("Selected'")>] member inline _.Selected' (render: AttrRenderFragment, value: cval<System.Boolean>) = render ==> html.bind("Selected", value)
    [<CustomOperation("Selected'")>] member inline _.Selected' (render: AttrRenderFragment, valueFn: System.Boolean * (System.Boolean -> unit)) = render ==> html.bind("Selected", valueFn)
    [<CustomOperation("Icon")>] member inline _.Icon (render: AttrRenderFragment, x: System.String) = render ==> ("Icon" => x)
    [<CustomOperation("IconColor")>] member inline _.IconColor (render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("IconColor" => x)
    [<CustomOperation("EndIcon")>] member inline _.EndIcon (render: AttrRenderFragment, x: System.String) = render ==> ("EndIcon" => x)
    [<CustomOperation("EndIconColor")>] member inline _.EndIconColor (render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("EndIconColor" => x)
    [<CustomOperation("ExpandedIcon")>] member inline _.ExpandedIcon (render: AttrRenderFragment, x: System.String) = render ==> ("ExpandedIcon" => x)
    [<CustomOperation("ExpandedIconColor")>] member inline _.ExpandedIconColor (render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("ExpandedIconColor" => x)
    [<CustomOperation("LoadingIcon")>] member inline _.LoadingIcon (render: AttrRenderFragment, x: System.String) = render ==> ("LoadingIcon" => x)
    [<CustomOperation("LoadingIconColor")>] member inline _.LoadingIconColor (render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("LoadingIconColor" => x)
    [<CustomOperation("ActivatedChanged")>] member inline _.ActivatedChanged (render: AttrRenderFragment, fn) = render ==> html.callback<System.Boolean>("ActivatedChanged", fn)
    [<CustomOperation("SelectedChanged")>] member inline _.SelectedChanged (render: AttrRenderFragment, fn) = render ==> html.callback<System.Boolean>("SelectedChanged", fn)
    [<CustomOperation("OnClick")>] member inline _.OnClick (render: AttrRenderFragment, fn) = render ==> html.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>("OnClick", fn)
                

type MudTextBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Typo")>] member inline _.Typo (render: AttrRenderFragment, x: MudBlazor.Typo) = render ==> ("Typo" => x)
    [<CustomOperation("Align")>] member inline _.Align (render: AttrRenderFragment, x: MudBlazor.Align) = render ==> ("Align" => x)
    [<CustomOperation("Color")>] member inline _.Color (render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("Color" => x)
    [<CustomOperation("GutterBottom")>] member inline _.GutterBottom (render: AttrRenderFragment, x: System.Boolean) = render ==> ("GutterBottom" => x)
    [<CustomOperation("Inline")>] member inline _.Inline (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Inline" => x)
                

type MudContainerBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Fixed")>] member inline _.Fixed (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Fixed" => x)
    [<CustomOperation("MaxWidth")>] member inline _.MaxWidth (render: AttrRenderFragment, x: MudBlazor.MaxWidth) = render ==> ("MaxWidth" => x)
                

type MudDividerBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Absolute")>] member inline _.Absolute (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Absolute" => x)
    [<CustomOperation("FlexItem")>] member inline _.FlexItem (render: AttrRenderFragment, x: System.Boolean) = render ==> ("FlexItem" => x)
    [<CustomOperation("Light")>] member inline _.Light (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Light" => x)
    [<CustomOperation("Vertical")>] member inline _.Vertical (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Vertical" => x)
    [<CustomOperation("DividerType")>] member inline _.DividerType (render: AttrRenderFragment, x: MudBlazor.DividerType) = render ==> ("DividerType" => x)
                

type MudDrawerHeaderBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Dense")>] member inline _.Dense (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Dense" => x)
    [<CustomOperation("LinkToIndex")>] member inline _.LinkToIndex (render: AttrRenderFragment, x: System.Boolean) = render ==> ("LinkToIndex" => x)
                

type MudGridBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Spacing")>] member inline _.Spacing (render: AttrRenderFragment, x: System.Int32) = render ==> ("Spacing" => x)
    [<CustomOperation("Justify")>] member inline _.Justify (render: AttrRenderFragment, x: MudBlazor.Justify) = render ==> ("Justify" => x)
                

type MudItemBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("xs")>] member inline _.xs (render: AttrRenderFragment, x: System.Int32) = render ==> ("xs" => x)
    [<CustomOperation("sm")>] member inline _.sm (render: AttrRenderFragment, x: System.Int32) = render ==> ("sm" => x)
    [<CustomOperation("md")>] member inline _.md (render: AttrRenderFragment, x: System.Int32) = render ==> ("md" => x)
    [<CustomOperation("lg")>] member inline _.lg (render: AttrRenderFragment, x: System.Int32) = render ==> ("lg" => x)
    [<CustomOperation("xl")>] member inline _.xl (render: AttrRenderFragment, x: System.Int32) = render ==> ("xl" => x)
    [<CustomOperation("xxl")>] member inline _.xxl (render: AttrRenderFragment, x: System.Int32) = render ==> ("xxl" => x)
                

type MudHighlighterBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Text")>] member inline _.Text (render: AttrRenderFragment, x: System.String) = render ==> ("Text" => x)
    [<CustomOperation("HighlightedText")>] member inline _.HighlightedText (render: AttrRenderFragment, x: System.String) = render ==> ("HighlightedText" => x)
    [<CustomOperation("CaseSensitive")>] member inline _.CaseSensitive (render: AttrRenderFragment, x: System.Boolean) = render ==> ("CaseSensitive" => x)
    [<CustomOperation("UntilNextBoundary")>] member inline _.UntilNextBoundary (render: AttrRenderFragment, x: System.Boolean) = render ==> ("UntilNextBoundary" => x)
                

type MudMainContentBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()

                

type MudPaperBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Elevation")>] member inline _.Elevation (render: AttrRenderFragment, x: System.Int32) = render ==> ("Elevation" => x)
    [<CustomOperation("Square")>] member inline _.Square (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Square" => x)
    [<CustomOperation("Outlined")>] member inline _.Outlined (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Outlined" => x)
    [<CustomOperation("Height")>] member inline _.Height (render: AttrRenderFragment, x: System.String) = render ==> ("Height" => x)
    [<CustomOperation("Width")>] member inline _.Width (render: AttrRenderFragment, x: System.String) = render ==> ("Width" => x)
    [<CustomOperation("MaxHeight")>] member inline _.MaxHeight (render: AttrRenderFragment, x: System.String) = render ==> ("MaxHeight" => x)
    [<CustomOperation("MaxWidth")>] member inline _.MaxWidth (render: AttrRenderFragment, x: System.String) = render ==> ("MaxWidth" => x)
    [<CustomOperation("MinHeight")>] member inline _.MinHeight (render: AttrRenderFragment, x: System.String) = render ==> ("MinHeight" => x)
    [<CustomOperation("MinWidth")>] member inline _.MinWidth (render: AttrRenderFragment, x: System.String) = render ==> ("MinWidth" => x)
                

type MudSparkLineBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("StrokeWidth")>] member inline _.StrokeWidth (render: AttrRenderFragment, x: System.Int32) = render ==> ("StrokeWidth" => x)
                

type MudTabPanelBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Text")>] member inline _.Text (render: AttrRenderFragment, x: System.String) = render ==> ("Text" => x)
    [<CustomOperation("Icon")>] member inline _.Icon (render: AttrRenderFragment, x: System.String) = render ==> ("Icon" => x)
    [<CustomOperation("Disabled")>] member inline _.Disabled (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Disabled" => x)
    [<CustomOperation("BadgeData")>] member inline _.BadgeData (render: AttrRenderFragment, x: System.Object) = render ==> ("BadgeData" => x)
    [<CustomOperation("BadgeDot")>] member inline _.BadgeDot (render: AttrRenderFragment, x: System.Boolean) = render ==> ("BadgeDot" => x)
    [<CustomOperation("BadgeColor")>] member inline _.BadgeColor (render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("BadgeColor" => x)
    [<CustomOperation("ID")>] member inline _.ID (render: AttrRenderFragment, x: System.Object) = render ==> ("ID" => x)
    [<CustomOperation("OnClick")>] member inline _.OnClick (render: AttrRenderFragment, fn) = render ==> html.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>("OnClick", fn)
    [<CustomOperation("ToolTip")>] member inline _.ToolTip (render: AttrRenderFragment, x: System.String) = render ==> ("ToolTip" => x)
                

type MudToolBarBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Dense")>] member inline _.Dense (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Dense" => x)
    [<CustomOperation("DisableGutters")>] member inline _.DisableGutters (render: AttrRenderFragment, x: System.Boolean) = render ==> ("DisableGutters" => x)
                

type MudBaseColumnBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Visible")>] member inline _.Visible (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Visible" => x)
    [<CustomOperation("HeaderText")>] member inline _.HeaderText (render: AttrRenderFragment, x: System.String) = render ==> ("HeaderText" => x)
                

type MudColumnBuilder<'FunBlazorGeneric, 'T when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudBaseColumnBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Value")>] member inline _.Value (render: AttrRenderFragment, x: 'T) = render ==> ("Value" => x)
    [<CustomOperation("Value'")>] member inline _.Value' (render: AttrRenderFragment, value: IStore<'T>) = render ==> html.bind("Value", value)
    [<CustomOperation("Value'")>] member inline _.Value' (render: AttrRenderFragment, value: cval<'T>) = render ==> html.bind("Value", value)
    [<CustomOperation("Value'")>] member inline _.Value' (render: AttrRenderFragment, valueFn: 'T * ('T -> unit)) = render ==> html.bind("Value", valueFn)
    [<CustomOperation("ValueChanged")>] member inline _.ValueChanged (render: AttrRenderFragment, fn) = render ==> html.callback<'T>("ValueChanged", fn)
    [<CustomOperation("FooterValue")>] member inline _.FooterValue (render: AttrRenderFragment, x: 'T) = render ==> ("FooterValue" => x)
    [<CustomOperation("FooterText")>] member inline _.FooterText (render: AttrRenderFragment, x: System.String) = render ==> ("FooterText" => x)
    [<CustomOperation("DataFormatString")>] member inline _.DataFormatString (render: AttrRenderFragment, x: System.String) = render ==> ("DataFormatString" => x)
    [<CustomOperation("ReadOnly")>] member inline _.ReadOnly (render: AttrRenderFragment, x: System.Boolean) = render ==> ("ReadOnly" => x)
                

type MudSortableColumnBuilder<'FunBlazorGeneric, 'T, 'ModelType when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudBaseColumnBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Value")>] member inline _.Value (render: AttrRenderFragment, x: 'T) = render ==> ("Value" => x)
    [<CustomOperation("Value'")>] member inline _.Value' (render: AttrRenderFragment, value: IStore<'T>) = render ==> html.bind("Value", value)
    [<CustomOperation("Value'")>] member inline _.Value' (render: AttrRenderFragment, value: cval<'T>) = render ==> html.bind("Value", value)
    [<CustomOperation("Value'")>] member inline _.Value' (render: AttrRenderFragment, valueFn: 'T * ('T -> unit)) = render ==> html.bind("Value", valueFn)
    [<CustomOperation("ValueChanged")>] member inline _.ValueChanged (render: AttrRenderFragment, fn) = render ==> html.callback<'T>("ValueChanged", fn)
    [<CustomOperation("FooterValue")>] member inline _.FooterValue (render: AttrRenderFragment, x: 'T) = render ==> ("FooterValue" => x)
    [<CustomOperation("FooterText")>] member inline _.FooterText (render: AttrRenderFragment, x: System.String) = render ==> ("FooterText" => x)
    [<CustomOperation("DataFormatString")>] member inline _.DataFormatString (render: AttrRenderFragment, x: System.String) = render ==> ("DataFormatString" => x)
    [<CustomOperation("ReadOnly")>] member inline _.ReadOnly (render: AttrRenderFragment, x: System.Boolean) = render ==> ("ReadOnly" => x)
    [<CustomOperation("SortLabel")>] member inline _.SortLabel (render: AttrRenderFragment, x: System.String) = render ==> ("SortLabel" => x)
    [<CustomOperation("SortBy")>] member inline _.SortBy (render: AttrRenderFragment, fn) = render ==> ("SortBy" => (System.Func<'ModelType, System.Object>fn))
                

type MudAvatarColumnBuilder<'FunBlazorGeneric, 'T when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudBaseColumnBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Value")>] member inline _.Value (render: AttrRenderFragment, x: 'T) = render ==> ("Value" => x)
                

type MudTemplateColumnBuilder<'FunBlazorGeneric, 'T when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudBaseColumnBuilder<'FunBlazorGeneric>()
    [<CustomOperation("DataContext")>] member inline _.DataContext (render: AttrRenderFragment, x: 'T) = render ==> ("DataContext" => x)
    [<CustomOperation("Header")>] member inline _.Header (render: AttrRenderFragment, fn: 'T -> NodeRenderFragment) = render ==> html.renderFragment("Header", fn)
    [<CustomOperation("Row")>] member inline _.Row (render: AttrRenderFragment, fn: 'T -> NodeRenderFragment) = render ==> html.renderFragment("Row", fn)
    [<CustomOperation("Edit")>] member inline _.Edit (render: AttrRenderFragment, fn: 'T -> NodeRenderFragment) = render ==> html.renderFragment("Edit", fn)
    [<CustomOperation("Footer")>] member inline _.Footer (render: AttrRenderFragment, fn: 'T -> NodeRenderFragment) = render ==> html.renderFragment("Footer", fn)
                

type BaseMudThemeProviderBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Theme")>] member inline _.Theme (render: AttrRenderFragment, x: MudBlazor.MudTheme) = render ==> ("Theme" => x)
    [<CustomOperation("DefaultScrollbar")>] member inline _.DefaultScrollbar (render: AttrRenderFragment, x: System.Boolean) = render ==> ("DefaultScrollbar" => x)
    [<CustomOperation("IsDarkMode")>] member inline _.IsDarkMode (render: AttrRenderFragment, x: System.Boolean) = render ==> ("IsDarkMode" => x)
    [<CustomOperation("IsDarkMode'")>] member inline _.IsDarkMode' (render: AttrRenderFragment, value: IStore<System.Boolean>) = render ==> html.bind("IsDarkMode", value)
    [<CustomOperation("IsDarkMode'")>] member inline _.IsDarkMode' (render: AttrRenderFragment, value: cval<System.Boolean>) = render ==> html.bind("IsDarkMode", value)
    [<CustomOperation("IsDarkMode'")>] member inline _.IsDarkMode' (render: AttrRenderFragment, valueFn: System.Boolean * (System.Boolean -> unit)) = render ==> html.bind("IsDarkMode", valueFn)
    [<CustomOperation("IsDarkModeChanged")>] member inline _.IsDarkModeChanged (render: AttrRenderFragment, fn) = render ==> html.callback<System.Boolean>("IsDarkModeChanged", fn)
                

type MudThemeProviderBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit BaseMudThemeProviderBuilder<'FunBlazorGeneric>()

                

type FilterBuilder<'FunBlazorGeneric, 'T when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Id")>] member inline _.Id (render: AttrRenderFragment, x: System.Guid) = render ==> ("Id" => x)
    [<CustomOperation("Field")>] member inline _.Field (render: AttrRenderFragment, x: System.String) = render ==> ("Field" => x)
    [<CustomOperation("Field'")>] member inline _.Field' (render: AttrRenderFragment, value: IStore<System.String>) = render ==> html.bind("Field", value)
    [<CustomOperation("Field'")>] member inline _.Field' (render: AttrRenderFragment, value: cval<System.String>) = render ==> html.bind("Field", value)
    [<CustomOperation("Field'")>] member inline _.Field' (render: AttrRenderFragment, valueFn: System.String * (System.String -> unit)) = render ==> html.bind("Field", valueFn)
    [<CustomOperation("Operator")>] member inline _.Operator (render: AttrRenderFragment, x: System.String) = render ==> ("Operator" => x)
    [<CustomOperation("Operator'")>] member inline _.Operator' (render: AttrRenderFragment, value: IStore<System.String>) = render ==> html.bind("Operator", value)
    [<CustomOperation("Operator'")>] member inline _.Operator' (render: AttrRenderFragment, value: cval<System.String>) = render ==> html.bind("Operator", value)
    [<CustomOperation("Operator'")>] member inline _.Operator' (render: AttrRenderFragment, valueFn: System.String * (System.String -> unit)) = render ==> html.bind("Operator", valueFn)
    [<CustomOperation("Value")>] member inline _.Value (render: AttrRenderFragment, x: System.Object) = render ==> ("Value" => x)
    [<CustomOperation("Value'")>] member inline _.Value' (render: AttrRenderFragment, value: IStore<System.Object>) = render ==> html.bind("Value", value)
    [<CustomOperation("Value'")>] member inline _.Value' (render: AttrRenderFragment, value: cval<System.Object>) = render ==> html.bind("Value", value)
    [<CustomOperation("Value'")>] member inline _.Value' (render: AttrRenderFragment, valueFn: System.Object * (System.Object -> unit)) = render ==> html.bind("Value", valueFn)
    [<CustomOperation("FieldChanged")>] member inline _.FieldChanged (render: AttrRenderFragment, fn) = render ==> html.callback<System.String>("FieldChanged", fn)
    [<CustomOperation("OperatorChanged")>] member inline _.OperatorChanged (render: AttrRenderFragment, fn) = render ==> html.callback<System.String>("OperatorChanged", fn)
    [<CustomOperation("ValueChanged")>] member inline _.ValueChanged (render: AttrRenderFragment, fn) = render ==> html.callback<System.Object>("ValueChanged", fn)
                

type MudDialogProviderBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentBuilder<'FunBlazorGeneric>()
    [<CustomOperation("NoHeader")>] member inline _.NoHeader (render: AttrRenderFragment, x: System.Nullable<System.Boolean>) = render ==> ("NoHeader" => x)
    [<CustomOperation("CloseButton")>] member inline _.CloseButton (render: AttrRenderFragment, x: System.Nullable<System.Boolean>) = render ==> ("CloseButton" => x)
    [<CustomOperation("DisableBackdropClick")>] member inline _.DisableBackdropClick (render: AttrRenderFragment, x: System.Nullable<System.Boolean>) = render ==> ("DisableBackdropClick" => x)
    [<CustomOperation("CloseOnEscapeKey")>] member inline _.CloseOnEscapeKey (render: AttrRenderFragment, x: System.Nullable<System.Boolean>) = render ==> ("CloseOnEscapeKey" => x)
    [<CustomOperation("FullWidth")>] member inline _.FullWidth (render: AttrRenderFragment, x: System.Nullable<System.Boolean>) = render ==> ("FullWidth" => x)
    [<CustomOperation("Position")>] member inline _.Position (render: AttrRenderFragment, x: System.Nullable<MudBlazor.DialogPosition>) = render ==> ("Position" => x)
    [<CustomOperation("MaxWidth")>] member inline _.MaxWidth (render: AttrRenderFragment, x: System.Nullable<MudBlazor.MaxWidth>) = render ==> ("MaxWidth" => x)
                

type MudPopoverProviderBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentBuilder<'FunBlazorGeneric>()

                

type MudVirtualizeBuilder<'FunBlazorGeneric, 'T when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentBuilder<'FunBlazorGeneric>()
    [<CustomOperation("IsEnabled")>] member inline _.IsEnabled (render: AttrRenderFragment, x: System.Boolean) = render ==> ("IsEnabled" => x)
    [<CustomOperation("ChildContent")>] member inline _.ChildContent (render: AttrRenderFragment, fn: 'T -> NodeRenderFragment) = render ==> html.renderFragment("ChildContent", fn)
    [<CustomOperation("Items")>] member inline _.Items (render: AttrRenderFragment, x: System.Collections.Generic.ICollection<'T>) = render ==> ("Items" => x)
                

type BreadcrumbLinkBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Item")>] member inline _.Item (render: AttrRenderFragment, x: MudBlazor.BreadcrumbItem) = render ==> ("Item" => x)
                

type BreadcrumbSeparatorBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentBuilder<'FunBlazorGeneric>()

                

type MudPickerContentBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Classes")>] member inline _.Classes (render: AttrRenderFragment, x: string list) = render ==> html.classes x
    [<CustomOperation("childContent")>] member inline _.childContent (render: AttrRenderFragment, fragment) = render ==> html.renderFragment("ChildContent", fragment)
    [<CustomOperation("childContent")>] member inline _.childContent (render: AttrRenderFragment, x: string) = render ==> html.renderFragment("ChildContent", html.text x)
    [<CustomOperation("childContent")>] member inline _.childContent (render: AttrRenderFragment, x: int) = render ==> html.renderFragment("ChildContent", html.text x)
    [<CustomOperation("childContent")>] member inline _.childContent (render: AttrRenderFragment, x: float) = render ==> html.renderFragment("ChildContent", html.text x)
                

type MudPickerToolbarBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Classes")>] member inline _.Classes (render: AttrRenderFragment, x: string list) = render ==> html.classes x
    [<CustomOperation("Styles")>] member inline _.Styles (render: AttrRenderFragment, x: (string * string) list) = render ==> html.styles x
    [<CustomOperation("DisableToolbar")>] member inline _.DisableToolbar (render: AttrRenderFragment, x: System.Boolean) = render ==> ("DisableToolbar" => x)
    [<CustomOperation("Orientation")>] member inline _.Orientation (render: AttrRenderFragment, x: MudBlazor.Orientation) = render ==> ("Orientation" => x)
    [<CustomOperation("Color")>] member inline _.Color (render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("Color" => x)
    [<CustomOperation("childContent")>] member inline _.childContent (render: AttrRenderFragment, fragment) = render ==> html.renderFragment("ChildContent", fragment)
    [<CustomOperation("childContent")>] member inline _.childContent (render: AttrRenderFragment, x: string) = render ==> html.renderFragment("ChildContent", html.text x)
    [<CustomOperation("childContent")>] member inline _.childContent (render: AttrRenderFragment, x: int) = render ==> html.renderFragment("ChildContent", html.text x)
    [<CustomOperation("childContent")>] member inline _.childContent (render: AttrRenderFragment, x: float) = render ==> html.renderFragment("ChildContent", html.text x)
                

type MudSpacerBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentBuilder<'FunBlazorGeneric>()

                

type MudTreeViewItemToggleButtonBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Visible")>] member inline _.Visible (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Visible" => x)
    [<CustomOperation("Expanded")>] member inline _.Expanded (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Expanded" => x)
    [<CustomOperation("Expanded'")>] member inline _.Expanded' (render: AttrRenderFragment, value: IStore<System.Boolean>) = render ==> html.bind("Expanded", value)
    [<CustomOperation("Expanded'")>] member inline _.Expanded' (render: AttrRenderFragment, value: cval<System.Boolean>) = render ==> html.bind("Expanded", value)
    [<CustomOperation("Expanded'")>] member inline _.Expanded' (render: AttrRenderFragment, valueFn: System.Boolean * (System.Boolean -> unit)) = render ==> html.bind("Expanded", valueFn)
    [<CustomOperation("Loading")>] member inline _.Loading (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Loading" => x)
    [<CustomOperation("ExpandedChanged")>] member inline _.ExpandedChanged (render: AttrRenderFragment, fn) = render ==> html.callback<System.Boolean>("ExpandedChanged", fn)
    [<CustomOperation("LoadingIcon")>] member inline _.LoadingIcon (render: AttrRenderFragment, x: System.String) = render ==> ("LoadingIcon" => x)
    [<CustomOperation("LoadingIconColor")>] member inline _.LoadingIconColor (render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("LoadingIconColor" => x)
    [<CustomOperation("ExpandedIcon")>] member inline _.ExpandedIcon (render: AttrRenderFragment, x: System.String) = render ==> ("ExpandedIcon" => x)
    [<CustomOperation("ExpandedIconColor")>] member inline _.ExpandedIconColor (render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("ExpandedIconColor" => x)
                

type _ImportsBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentBuilder<'FunBlazorGeneric>()

                
            
namespace rec MudBlazor.DslInternals.Internal

open FSharp.Data.Adaptive
open Fun.Blazor
open Fun.Blazor.Operators
open MudBlazor.DslInternals


type MudInputAdornmentBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Classes")>] member inline _.Classes (render: AttrRenderFragment, x: string list) = render ==> html.classes x
    [<CustomOperation("Text")>] member inline _.Text (render: AttrRenderFragment, x: System.String) = render ==> ("Text" => x)
    [<CustomOperation("Icon")>] member inline _.Icon (render: AttrRenderFragment, x: System.String) = render ==> ("Icon" => x)
    [<CustomOperation("Edge")>] member inline _.Edge (render: AttrRenderFragment, x: MudBlazor.Edge) = render ==> ("Edge" => x)
    [<CustomOperation("Size")>] member inline _.Size (render: AttrRenderFragment, x: MudBlazor.Size) = render ==> ("Size" => x)
    [<CustomOperation("Color")>] member inline _.Color (render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("Color" => x)
    [<CustomOperation("AdornmentClick")>] member inline _.AdornmentClick (render: AttrRenderFragment, fn) = render ==> html.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>("AdornmentClick", fn)
                
            
namespace rec MudBlazor.DslInternals.Charts

open FSharp.Data.Adaptive
open Fun.Blazor
open Fun.Blazor.Operators
open MudBlazor.DslInternals


type FiltersBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentBuilder<'FunBlazorGeneric>()

                
            

// =======================================================================================================================

namespace MudBlazor

[<AutoOpen>]
module DslCE =

    open MudBlazor.DslInternals

    let MudComponentBase' = MudComponentBaseBuilder<MudBlazor.MudComponentBase>()
    let MudBaseButton' = MudBaseButtonBuilder<MudBlazor.MudBaseButton>()
    let MudButton' = MudButtonBuilder<MudBlazor.MudButton>()
    let MudFab' = MudFabBuilder<MudBlazor.MudFab>()
    let MudIconButton' = MudIconButtonBuilder<MudBlazor.MudIconButton>()
    let MudFileUploader' = MudFileUploaderBuilder<MudBlazor.MudFileUploader>()
    let MudDrawerContainer' = MudDrawerContainerBuilder<MudBlazor.MudDrawerContainer>()
    let MudLayout' = MudLayoutBuilder<MudBlazor.MudLayout>()
    let MudBaseSelectItem' = MudBaseSelectItemBuilder<MudBlazor.MudBaseSelectItem>()
    let MudNavLink' = MudNavLinkBuilder<MudBlazor.MudNavLink>()
    let MudSelectItem'<'T> = MudSelectItemBuilder<MudBlazor.MudSelectItem<'T>, 'T>()
    let MudTableBase' = MudTableBaseBuilder<MudBlazor.MudTableBase>()
    let MudTable'<'T> = MudTableBuilder<MudBlazor.MudTable<'T>, 'T>()
    let MudTabs' = MudTabsBuilder<MudBlazor.MudTabs>()
    let MudDynamicTabs' = MudDynamicTabsBuilder<MudBlazor.MudDynamicTabs>()
    let MudChartBase' = MudChartBaseBuilder<MudBlazor.MudChartBase>()
    let MudChart' = MudChartBuilder<MudBlazor.MudChart>()
    let MudBaseItemsControl'<'TChildComponent when 'TChildComponent :> MudBlazor.MudComponentBase> = MudBaseItemsControlBuilder<MudBlazor.MudBaseItemsControl<'TChildComponent>, 'TChildComponent>()
    let MudBaseBindableItemsControl'<'TChildComponent, 'TData when 'TChildComponent :> MudBlazor.MudComponentBase> = MudBaseBindableItemsControlBuilder<MudBlazor.MudBaseBindableItemsControl<'TChildComponent, 'TData>, 'TChildComponent, 'TData>()
    let MudCarousel'<'TData> = MudCarouselBuilder<MudBlazor.MudCarousel<'TData>, 'TData>()
    let MudTimeline' = MudTimelineBuilder<MudBlazor.MudTimeline>()
    let MudFormComponent'<'T, 'U> = MudFormComponentBuilder<MudBlazor.MudFormComponent<'T, 'U>, 'T, 'U>()
    let MudBaseInput'<'T> = MudBaseInputBuilder<MudBlazor.MudBaseInput<'T>, 'T>()
    let MudAutocomplete'<'T> = MudAutocompleteBuilder<MudBlazor.MudAutocomplete<'T>, 'T>()
    let MudDebouncedInput'<'T> = MudDebouncedInputBuilder<MudBlazor.MudDebouncedInput<'T>, 'T>()
    let MudNumericField'<'T> = MudNumericFieldBuilder<MudBlazor.MudNumericField<'T>, 'T>()
    let MudTextField'<'T> = MudTextFieldBuilder<MudBlazor.MudTextField<'T>, 'T>()
    let MudInput'<'T> = MudInputBuilder<MudBlazor.MudInput<'T>, 'T>()
    let MudInputString' = MudInputStringBuilder<MudBlazor.MudInputString>()
    let MudRangeInput'<'T> = MudRangeInputBuilder<MudBlazor.MudRangeInput<'T>, 'T>()
    let MudSelect'<'T> = MudSelectBuilder<MudBlazor.MudSelect<'T>, 'T>()
    let MudBooleanInput'<'T> = MudBooleanInputBuilder<MudBlazor.MudBooleanInput<'T>, 'T>()
    let MudCheckBox'<'T> = MudCheckBoxBuilder<MudBlazor.MudCheckBox<'T>, 'T>()
    let MudSwitch'<'T> = MudSwitchBuilder<MudBlazor.MudSwitch<'T>, 'T>()
    let MudPicker'<'T> = MudPickerBuilder<MudBlazor.MudPicker<'T>, 'T>()
    let MudBaseDatePicker' = MudBaseDatePickerBuilder<MudBlazor.MudBaseDatePicker>()
    let MudDatePicker' = MudDatePickerBuilder<MudBlazor.MudDatePicker>()
    let MudDateRangePicker' = MudDateRangePickerBuilder<MudBlazor.MudDateRangePicker>()
    let MudColorPicker' = MudColorPickerBuilder<MudBlazor.MudColorPicker>()
    let MudTimePicker' = MudTimePickerBuilder<MudBlazor.MudTimePicker>()
    let MudRadioGroup'<'T> = MudRadioGroupBuilder<MudBlazor.MudRadioGroup<'T>, 'T>()
    let MudAlert' = MudAlertBuilder<MudBlazor.MudAlert>()
    let MudAppBar' = MudAppBarBuilder<MudBlazor.MudAppBar>()
    let MudAvatar' = MudAvatarBuilder<MudBlazor.MudAvatar>()
    let MudAvatarGroup' = MudAvatarGroupBuilder<MudBlazor.MudAvatarGroup>()
    let MudBadge' = MudBadgeBuilder<MudBlazor.MudBadge>()
    let MudBreadcrumbs' = MudBreadcrumbsBuilder<MudBlazor.MudBreadcrumbs>()
    let MudBreakpointProvider' = MudBreakpointProviderBuilder<MudBlazor.MudBreakpointProvider>()
    let MudButtonGroup' = MudButtonGroupBuilder<MudBlazor.MudButtonGroup>()
    let MudToggleIconButton' = MudToggleIconButtonBuilder<MudBlazor.MudToggleIconButton>()
    let MudCard' = MudCardBuilder<MudBlazor.MudCard>()
    let MudCardActions' = MudCardActionsBuilder<MudBlazor.MudCardActions>()
    let MudCardContent' = MudCardContentBuilder<MudBlazor.MudCardContent>()
    let MudCardHeader' = MudCardHeaderBuilder<MudBlazor.MudCardHeader>()
    let MudCardMedia' = MudCardMediaBuilder<MudBlazor.MudCardMedia>()
    let MudCarouselItem' = MudCarouselItemBuilder<MudBlazor.MudCarouselItem>()
    let MudChipSet' = MudChipSetBuilder<MudBlazor.MudChipSet>()
    let MudChip' = MudChipBuilder<MudBlazor.MudChip>()
    let MudCollapse' = MudCollapseBuilder<MudBlazor.MudCollapse>()
    let Cell'<'T> = CellBuilder<MudBlazor.Cell<'T>, 'T>()
    let Column'<'T> = ColumnBuilder<MudBlazor.Column<'T>, 'T>()
    let FooterCell'<'T> = FooterCellBuilder<MudBlazor.FooterCell<'T>, 'T>()
    let HeaderCell'<'T> = HeaderCellBuilder<MudBlazor.HeaderCell<'T>, 'T>()
    let MudDataGrid'<'T> = MudDataGridBuilder<MudBlazor.MudDataGrid<'T>, 'T>()
    let MudDataGridPager'<'T> = MudDataGridPagerBuilder<MudBlazor.MudDataGridPager<'T>, 'T>()
    let Row' = RowBuilder<MudBlazor.Row>()
    let MudDialog' = MudDialogBuilder<MudBlazor.MudDialog>()
    let MudDialogInstance' = MudDialogInstanceBuilder<MudBlazor.MudDialogInstance>()
    let MudDrawer' = MudDrawerBuilder<MudBlazor.MudDrawer>()
    let MudElement' = MudElementBuilder<MudBlazor.MudElement>()
    let MudExpansionPanel' = MudExpansionPanelBuilder<MudBlazor.MudExpansionPanel>()
    let MudExpansionPanels' = MudExpansionPanelsBuilder<MudBlazor.MudExpansionPanels>()
    let MudField' = MudFieldBuilder<MudBlazor.MudField>()
    let MudFocusTrap' = MudFocusTrapBuilder<MudBlazor.MudFocusTrap>()
    let MudForm' = MudFormBuilder<MudBlazor.MudForm>()
    let MudHidden' = MudHiddenBuilder<MudBlazor.MudHidden>()
    let MudIcon' = MudIconBuilder<MudBlazor.MudIcon>()
    let MudInputControl' = MudInputControlBuilder<MudBlazor.MudInputControl>()
    let MudInputLabel' = MudInputLabelBuilder<MudBlazor.MudInputLabel>()
    let MudLink' = MudLinkBuilder<MudBlazor.MudLink>()
    let MudList' = MudListBuilder<MudBlazor.MudList>()
    let MudListItem' = MudListItemBuilder<MudBlazor.MudListItem>()
    let MudListSubheader' = MudListSubheaderBuilder<MudBlazor.MudListSubheader>()
    let MudMenu' = MudMenuBuilder<MudBlazor.MudMenu>()
    let MudMenuItem' = MudMenuItemBuilder<MudBlazor.MudMenuItem>()
    let MudMessageBox' = MudMessageBoxBuilder<MudBlazor.MudMessageBox>()
    let MudNavGroup' = MudNavGroupBuilder<MudBlazor.MudNavGroup>()
    let MudNavMenu' = MudNavMenuBuilder<MudBlazor.MudNavMenu>()
    let MudOverlay' = MudOverlayBuilder<MudBlazor.MudOverlay>()
    let MudPageContentNavigation' = MudPageContentNavigationBuilder<MudBlazor.MudPageContentNavigation>()
    let MudPagination' = MudPaginationBuilder<MudBlazor.MudPagination>()
    let MudPopover' = MudPopoverBuilder<MudBlazor.MudPopover>()
    let MudProgressCircular' = MudProgressCircularBuilder<MudBlazor.MudProgressCircular>()
    let MudProgressLinear' = MudProgressLinearBuilder<MudBlazor.MudProgressLinear>()
    let MudRadio'<'T> = MudRadioBuilder<MudBlazor.MudRadio<'T>, 'T>()
    let MudRating' = MudRatingBuilder<MudBlazor.MudRating>()
    let MudRatingItem' = MudRatingItemBuilder<MudBlazor.MudRatingItem>()
    let MudRTLProvider' = MudRTLProviderBuilder<MudBlazor.MudRTLProvider>()
    let MudScrollToTop' = MudScrollToTopBuilder<MudBlazor.MudScrollToTop>()
    let MudSkeleton' = MudSkeletonBuilder<MudBlazor.MudSkeleton>()
    let MudSlider'<'T> = MudSliderBuilder<MudBlazor.MudSlider<'T>, 'T>()
    let MudSnackbarElement' = MudSnackbarElementBuilder<MudBlazor.MudSnackbarElement>()
    let MudSnackbarProvider' = MudSnackbarProviderBuilder<MudBlazor.MudSnackbarProvider>()
    let MudSwipeArea' = MudSwipeAreaBuilder<MudBlazor.MudSwipeArea>()
    let MudSimpleTable' = MudSimpleTableBuilder<MudBlazor.MudSimpleTable>()
    let MudTableGroupRow'<'T> = MudTableGroupRowBuilder<MudBlazor.MudTableGroupRow<'T>, 'T>()
    let MudTablePager' = MudTablePagerBuilder<MudBlazor.MudTablePager>()
    let MudTableSortLabel'<'T> = MudTableSortLabelBuilder<MudBlazor.MudTableSortLabel<'T>, 'T>()
    let MudTd' = MudTdBuilder<MudBlazor.MudTd>()
    let MudTFootRow' = MudTFootRowBuilder<MudBlazor.MudTFootRow>()
    let MudTh' = MudThBuilder<MudBlazor.MudTh>()
    let MudTHeadRow' = MudTHeadRowBuilder<MudBlazor.MudTHeadRow>()
    let MudTr' = MudTrBuilder<MudBlazor.MudTr>()
    let MudTimelineItem' = MudTimelineItemBuilder<MudBlazor.MudTimelineItem>()
    let MudTooltip' = MudTooltipBuilder<MudBlazor.MudTooltip>()
    let MudTreeView'<'T> = MudTreeViewBuilder<MudBlazor.MudTreeView<'T>, 'T>()
    let MudTreeViewItem'<'T> = MudTreeViewItemBuilder<MudBlazor.MudTreeViewItem<'T>, 'T>()
    let MudText' = MudTextBuilder<MudBlazor.MudText>()
    let MudContainer' = MudContainerBuilder<MudBlazor.MudContainer>()
    let MudDivider' = MudDividerBuilder<MudBlazor.MudDivider>()
    let MudDrawerHeader' = MudDrawerHeaderBuilder<MudBlazor.MudDrawerHeader>()
    let MudGrid' = MudGridBuilder<MudBlazor.MudGrid>()
    let MudItem' = MudItemBuilder<MudBlazor.MudItem>()
    let MudHighlighter' = MudHighlighterBuilder<MudBlazor.MudHighlighter>()
    let MudMainContent' = MudMainContentBuilder<MudBlazor.MudMainContent>()
    let MudPaper' = MudPaperBuilder<MudBlazor.MudPaper>()
    let MudSparkLine' = MudSparkLineBuilder<MudBlazor.MudSparkLine>()
    let MudTabPanel' = MudTabPanelBuilder<MudBlazor.MudTabPanel>()
    let MudToolBar' = MudToolBarBuilder<MudBlazor.MudToolBar>()
    let MudBaseColumn' = MudBaseColumnBuilder<MudBlazor.MudBaseColumn>()
    let MudColumn'<'T> = MudColumnBuilder<MudBlazor.MudColumn<'T>, 'T>()
    let MudSortableColumn'<'T, 'ModelType> = MudSortableColumnBuilder<MudBlazor.MudSortableColumn<'T, 'ModelType>, 'T, 'ModelType>()
    let MudAvatarColumn'<'T> = MudAvatarColumnBuilder<MudBlazor.MudAvatarColumn<'T>, 'T>()
    let MudTemplateColumn'<'T> = MudTemplateColumnBuilder<MudBlazor.MudTemplateColumn<'T>, 'T>()
    let BaseMudThemeProvider' = BaseMudThemeProviderBuilder<MudBlazor.BaseMudThemeProvider>()
    let MudThemeProvider' = MudThemeProviderBuilder<MudBlazor.MudThemeProvider>()
    let Filter'<'T> = FilterBuilder<MudBlazor.Filter<'T>, 'T>()
    let MudDialogProvider' = MudDialogProviderBuilder<MudBlazor.MudDialogProvider>()
    let MudPopoverProvider' = MudPopoverProviderBuilder<MudBlazor.MudPopoverProvider>()
    let MudVirtualize'<'T> = MudVirtualizeBuilder<MudBlazor.MudVirtualize<'T>, 'T>()
    let BreadcrumbLink' = BreadcrumbLinkBuilder<MudBlazor.BreadcrumbLink>()
    let BreadcrumbSeparator' = BreadcrumbSeparatorBuilder<MudBlazor.BreadcrumbSeparator>()
    let MudPickerContent' = MudPickerContentBuilder<MudBlazor.MudPickerContent>()
    let MudPickerToolbar' = MudPickerToolbarBuilder<MudBlazor.MudPickerToolbar>()
    let MudSpacer' = MudSpacerBuilder<MudBlazor.MudSpacer>()
    let MudTreeViewItemToggleButton' = MudTreeViewItemToggleButtonBuilder<MudBlazor.MudTreeViewItemToggleButton>()
    let _Imports' = _ImportsBuilder<MudBlazor._Imports>()
            
namespace MudBlazor.Charts

[<AutoOpen>]
module DslCE =

    open MudBlazor.DslInternals.Charts

    let Bar' = BarBuilder<MudBlazor.Charts.Bar>()
    let Donut' = DonutBuilder<MudBlazor.Charts.Donut>()
    let Line' = LineBuilder<MudBlazor.Charts.Line>()
    let Pie' = PieBuilder<MudBlazor.Charts.Pie>()
    let Legend' = LegendBuilder<MudBlazor.Charts.Legend>()
    let Filters' = FiltersBuilder<MudBlazor.Charts.Filters>()
            
namespace MudBlazor.Internal

[<AutoOpen>]
module DslCE =

    open MudBlazor.DslInternals.Internal

    let MudInputAdornment' = MudInputAdornmentBuilder<MudBlazor.Internal.MudInputAdornment>()
            