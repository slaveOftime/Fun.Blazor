namespace rec MudBlazor.DslInternals

open FSharp.Data.Adaptive
open Fun.Blazor
open Fun.Blazor.Operators
open MudBlazor.DslInternals


type MudComponentBaseBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAndChildAttrBuilder<'FunBlazorGeneric>()
    static member inline create () = html.fromBuilder(MudComponentBaseBuilder<'FunBlazorGeneric>())
    [<CustomOperation("Classes")>] member _.Classes (render: AttrRenderFragment, x: string list) = render ==> html.classes x
    [<CustomOperation("Styles")>] member _.Styles (render: AttrRenderFragment, x: (string * string) list) = render ==> html.styles x
    [<CustomOperation("Tag")>] member _.Tag (render: AttrRenderFragment, x: System.Object) = render ==> ("Tag" => x)
    [<CustomOperation("UserAttributes")>] member _.UserAttributes (render: AttrRenderFragment, x: System.Collections.Generic.Dictionary<System.String, System.Object>) = render ==> ("UserAttributes" => x)
                

type MudBaseButtonBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    static member inline create () = html.fromBuilder(MudBaseButtonBuilder<'FunBlazorGeneric>())
    [<CustomOperation("HtmlTag")>] member _.HtmlTag (render: AttrRenderFragment, x: System.String) = render ==> ("HtmlTag" => x)
    [<CustomOperation("ButtonType")>] member _.ButtonType (render: AttrRenderFragment, x: MudBlazor.ButtonType) = render ==> ("ButtonType" => x)
    [<CustomOperation("Link")>] member _.Link (render: AttrRenderFragment, x: System.String) = render ==> ("Link" => x)
    [<CustomOperation("Target")>] member _.Target (render: AttrRenderFragment, x: System.String) = render ==> ("Target" => x)
    [<CustomOperation("Disabled")>] member _.Disabled (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Disabled" => x)
    [<CustomOperation("DisableElevation")>] member _.DisableElevation (render: AttrRenderFragment, x: System.Boolean) = render ==> ("DisableElevation" => x)
    [<CustomOperation("DisableRipple")>] member _.DisableRipple (render: AttrRenderFragment, x: System.Boolean) = render ==> ("DisableRipple" => x)
    [<CustomOperation("Command")>] member _.Command (render: AttrRenderFragment, x: System.Windows.Input.ICommand) = render ==> ("Command" => x)
    [<CustomOperation("CommandParameter")>] member _.CommandParameter (render: AttrRenderFragment, x: System.Object) = render ==> ("CommandParameter" => x)
    [<CustomOperation("OnClick")>] member _.OnClick (render: AttrRenderFragment, fn) = render ==> html.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>("OnClick", fn)
                

type MudButtonBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudBaseButtonBuilder<'FunBlazorGeneric>()
    static member inline create (x: string) = MudButtonBuilder<'FunBlazorGeneric>(){ x }
    static member inline create (x: NodeRenderFragment seq) = MudButtonBuilder<'FunBlazorGeneric>(){ yield! x }
    [<CustomOperation("StartIcon")>] member _.StartIcon (render: AttrRenderFragment, x: System.String) = render ==> ("StartIcon" => x)
    [<CustomOperation("EndIcon")>] member _.EndIcon (render: AttrRenderFragment, x: System.String) = render ==> ("EndIcon" => x)
    [<CustomOperation("IconColor")>] member _.IconColor (render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("IconColor" => x)
    [<CustomOperation("IconClass")>] member _.IconClass (render: AttrRenderFragment, x: System.String) = render ==> ("IconClass" => x)
    [<CustomOperation("Color")>] member _.Color (render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("Color" => x)
    [<CustomOperation("Size")>] member _.Size (render: AttrRenderFragment, x: MudBlazor.Size) = render ==> ("Size" => x)
    [<CustomOperation("Variant")>] member _.Variant (render: AttrRenderFragment, x: MudBlazor.Variant) = render ==> ("Variant" => x)
    [<CustomOperation("FullWidth")>] member _.FullWidth (render: AttrRenderFragment, x: System.Boolean) = render ==> ("FullWidth" => x)
                

type MudFabBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudBaseButtonBuilder<'FunBlazorGeneric>()
    static member inline create () = html.fromBuilder(MudFabBuilder<'FunBlazorGeneric>())
    [<CustomOperation("Color")>] member _.Color (render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("Color" => x)
    [<CustomOperation("Size")>] member _.Size (render: AttrRenderFragment, x: MudBlazor.Size) = render ==> ("Size" => x)
    [<CustomOperation("Icon")>] member _.Icon (render: AttrRenderFragment, x: System.String) = render ==> ("Icon" => x)
    [<CustomOperation("StartIcon")>] member _.StartIcon (render: AttrRenderFragment, x: System.String) = render ==> ("StartIcon" => x)
    [<CustomOperation("EndIcon")>] member _.EndIcon (render: AttrRenderFragment, x: System.String) = render ==> ("EndIcon" => x)
    [<CustomOperation("IconColor")>] member _.IconColor (render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("IconColor" => x)
    [<CustomOperation("IconSize")>] member _.IconSize (render: AttrRenderFragment, x: MudBlazor.Size) = render ==> ("IconSize" => x)
    [<CustomOperation("Label")>] member _.Label (render: AttrRenderFragment, x: System.String) = render ==> ("Label" => x)
                

type MudIconButtonBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudBaseButtonBuilder<'FunBlazorGeneric>()
    static member inline create (x: string) = MudIconButtonBuilder<'FunBlazorGeneric>(){ x }
    static member inline create (x: NodeRenderFragment seq) = MudIconButtonBuilder<'FunBlazorGeneric>(){ yield! x }
    [<CustomOperation("Icon")>] member _.Icon (render: AttrRenderFragment, x: System.String) = render ==> ("Icon" => x)
    [<CustomOperation("Title")>] member _.Title (render: AttrRenderFragment, x: System.String) = render ==> ("Title" => x)
    [<CustomOperation("Color")>] member _.Color (render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("Color" => x)
    [<CustomOperation("Size")>] member _.Size (render: AttrRenderFragment, x: MudBlazor.Size) = render ==> ("Size" => x)
    [<CustomOperation("Edge")>] member _.Edge (render: AttrRenderFragment, x: MudBlazor.Edge) = render ==> ("Edge" => x)
    [<CustomOperation("Variant")>] member _.Variant (render: AttrRenderFragment, x: MudBlazor.Variant) = render ==> ("Variant" => x)
                

type MudFileUploaderBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudBaseButtonBuilder<'FunBlazorGeneric>()
    static member inline create () = html.fromBuilder(MudFileUploaderBuilder<'FunBlazorGeneric>())

                

type MudDrawerContainerBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    static member inline create (x: string) = MudDrawerContainerBuilder<'FunBlazorGeneric>(){ x }
    static member inline create (x: NodeRenderFragment seq) = MudDrawerContainerBuilder<'FunBlazorGeneric>(){ yield! x }

                

type MudLayoutBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudDrawerContainerBuilder<'FunBlazorGeneric>()
    static member inline create () = html.fromBuilder(MudLayoutBuilder<'FunBlazorGeneric>())

                

type MudBaseSelectItemBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    static member inline create (x: string) = MudBaseSelectItemBuilder<'FunBlazorGeneric>(){ x }
    static member inline create (x: NodeRenderFragment seq) = MudBaseSelectItemBuilder<'FunBlazorGeneric>(){ yield! x }
    [<CustomOperation("Disabled")>] member _.Disabled (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Disabled" => x)
    [<CustomOperation("DisableRipple")>] member _.DisableRipple (render: AttrRenderFragment, x: System.Boolean) = render ==> ("DisableRipple" => x)
    [<CustomOperation("Href")>] member _.Href (render: AttrRenderFragment, x: System.String) = render ==> ("Href" => x)
    [<CustomOperation("ForceLoad")>] member _.ForceLoad (render: AttrRenderFragment, x: System.Boolean) = render ==> ("ForceLoad" => x)
    [<CustomOperation("CommandParameter")>] member _.CommandParameter (render: AttrRenderFragment, x: System.Object) = render ==> ("CommandParameter" => x)
    [<CustomOperation("Command")>] member _.Command (render: AttrRenderFragment, x: System.Windows.Input.ICommand) = render ==> ("Command" => x)
    [<CustomOperation("OnClick")>] member _.OnClick (render: AttrRenderFragment, fn) = render ==> html.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>("OnClick", fn)
                

type MudNavLinkBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudBaseSelectItemBuilder<'FunBlazorGeneric>()
    static member inline create () = html.fromBuilder(MudNavLinkBuilder<'FunBlazorGeneric>())
    [<CustomOperation("Icon")>] member _.Icon (render: AttrRenderFragment, x: System.String) = render ==> ("Icon" => x)
    [<CustomOperation("IconColor")>] member _.IconColor (render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("IconColor" => x)
    [<CustomOperation("Match")>] member _.Match (render: AttrRenderFragment, x: Microsoft.AspNetCore.Components.Routing.NavLinkMatch) = render ==> ("Match" => x)
    [<CustomOperation("Target")>] member _.Target (render: AttrRenderFragment, x: System.String) = render ==> ("Target" => x)
                

type MudSelectItemBuilder<'FunBlazorGeneric, 'T when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudBaseSelectItemBuilder<'FunBlazorGeneric>()
    static member inline create () = html.fromBuilder(MudSelectItemBuilder<'FunBlazorGeneric, 'T>())
    [<CustomOperation("Value")>] member _.Value (render: AttrRenderFragment, x: 'T) = render ==> ("Value" => x)
                

type MudTableBaseBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    static member inline create () = html.fromBuilder(MudTableBaseBuilder<'FunBlazorGeneric>())
    [<CustomOperation("IsEditRowSwitchingBlocked")>] member _.IsEditRowSwitchingBlocked (render: AttrRenderFragment, x: System.Boolean) = render ==> ("IsEditRowSwitchingBlocked" => x)
    [<CustomOperation("Elevation")>] member _.Elevation (render: AttrRenderFragment, x: System.Int32) = render ==> ("Elevation" => x)
    [<CustomOperation("Square")>] member _.Square (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Square" => x)
    [<CustomOperation("Outlined")>] member _.Outlined (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Outlined" => x)
    [<CustomOperation("Bordered")>] member _.Bordered (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Bordered" => x)
    [<CustomOperation("Dense")>] member _.Dense (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Dense" => x)
    [<CustomOperation("Hover")>] member _.Hover (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Hover" => x)
    [<CustomOperation("Striped")>] member _.Striped (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Striped" => x)
    [<CustomOperation("Breakpoint")>] member _.Breakpoint (render: AttrRenderFragment, x: MudBlazor.Breakpoint) = render ==> ("Breakpoint" => x)
    [<CustomOperation("FixedHeader")>] member _.FixedHeader (render: AttrRenderFragment, x: System.Boolean) = render ==> ("FixedHeader" => x)
    [<CustomOperation("FixedFooter")>] member _.FixedFooter (render: AttrRenderFragment, x: System.Boolean) = render ==> ("FixedFooter" => x)
    [<CustomOperation("Height")>] member _.Height (render: AttrRenderFragment, x: System.String) = render ==> ("Height" => x)
    [<CustomOperation("SortLabel")>] member _.SortLabel (render: AttrRenderFragment, x: System.String) = render ==> ("SortLabel" => x)
    [<CustomOperation("AllowUnsorted")>] member _.AllowUnsorted (render: AttrRenderFragment, x: System.Boolean) = render ==> ("AllowUnsorted" => x)
    [<CustomOperation("RowsPerPage")>] member _.RowsPerPage (render: AttrRenderFragment, x: System.Int32) = render ==> ("RowsPerPage" => x)
    [<CustomOperation("RowsPerPage'")>] member _.RowsPerPage' (render: AttrRenderFragment, value: IStore<System.Int32>) = render ==> html.bind("RowsPerPage", value)
    [<CustomOperation("RowsPerPage'")>] member _.RowsPerPage' (render: AttrRenderFragment, value: cval<System.Int32>) = render ==> html.bind("RowsPerPage", value)
    [<CustomOperation("RowsPerPage'")>] member _.RowsPerPage' (render: AttrRenderFragment, valueFn: System.Int32 * (System.Int32 -> unit)) = render ==> html.bind("RowsPerPage", valueFn)
    [<CustomOperation("RowsPerPageChanged")>] member _.RowsPerPageChanged (render: AttrRenderFragment, fn) = render ==> html.callback<System.Int32>("RowsPerPageChanged", fn)
    [<CustomOperation("CurrentPage")>] member _.CurrentPage (render: AttrRenderFragment, x: System.Int32) = render ==> ("CurrentPage" => x)
    [<CustomOperation("MultiSelection")>] member _.MultiSelection (render: AttrRenderFragment, x: System.Boolean) = render ==> ("MultiSelection" => x)
    [<CustomOperation("ToolBarContent")>] member _.ToolBarContent (render: AttrRenderFragment, fragment) = render ==> html.renderFragment("ToolBarContent", fragment)
    [<CustomOperation("ToolBarContent")>] member _.ToolBarContent (render: AttrRenderFragment, fragments) = render ==> html.renderFragment("ToolBarContent", fragment { yield! fragments })
    [<CustomOperation("ToolBarContent")>] member _.ToolBarContent (render: AttrRenderFragment, x: string) = render ==> html.renderFragment("ToolBarContent", html.text x)
    [<CustomOperation("ToolBarContent")>] member _.ToolBarContent (render: AttrRenderFragment, x: int) = render ==> html.renderFragment("ToolBarContent", html.text x)
    [<CustomOperation("ToolBarContent")>] member _.ToolBarContent (render: AttrRenderFragment, x: float) = render ==> html.renderFragment("ToolBarContent", html.text x)
    [<CustomOperation("Loading")>] member _.Loading (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Loading" => x)
    [<CustomOperation("LoadingProgressColor")>] member _.LoadingProgressColor (render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("LoadingProgressColor" => x)
    [<CustomOperation("HeaderContent")>] member _.HeaderContent (render: AttrRenderFragment, fragment) = render ==> html.renderFragment("HeaderContent", fragment)
    [<CustomOperation("HeaderContent")>] member _.HeaderContent (render: AttrRenderFragment, fragments) = render ==> html.renderFragment("HeaderContent", fragment { yield! fragments })
    [<CustomOperation("HeaderContent")>] member _.HeaderContent (render: AttrRenderFragment, x: string) = render ==> html.renderFragment("HeaderContent", html.text x)
    [<CustomOperation("HeaderContent")>] member _.HeaderContent (render: AttrRenderFragment, x: int) = render ==> html.renderFragment("HeaderContent", html.text x)
    [<CustomOperation("HeaderContent")>] member _.HeaderContent (render: AttrRenderFragment, x: float) = render ==> html.renderFragment("HeaderContent", html.text x)
    [<CustomOperation("CustomHeader")>] member _.CustomHeader (render: AttrRenderFragment, x: System.Boolean) = render ==> ("CustomHeader" => x)
    [<CustomOperation("HeaderClass")>] member _.HeaderClass (render: AttrRenderFragment, x: System.String) = render ==> ("HeaderClass" => x)
    [<CustomOperation("FooterContent")>] member _.FooterContent (render: AttrRenderFragment, fragment) = render ==> html.renderFragment("FooterContent", fragment)
    [<CustomOperation("FooterContent")>] member _.FooterContent (render: AttrRenderFragment, fragments) = render ==> html.renderFragment("FooterContent", fragment { yield! fragments })
    [<CustomOperation("FooterContent")>] member _.FooterContent (render: AttrRenderFragment, x: string) = render ==> html.renderFragment("FooterContent", html.text x)
    [<CustomOperation("FooterContent")>] member _.FooterContent (render: AttrRenderFragment, x: int) = render ==> html.renderFragment("FooterContent", html.text x)
    [<CustomOperation("FooterContent")>] member _.FooterContent (render: AttrRenderFragment, x: float) = render ==> html.renderFragment("FooterContent", html.text x)
    [<CustomOperation("CustomFooter")>] member _.CustomFooter (render: AttrRenderFragment, x: System.Boolean) = render ==> ("CustomFooter" => x)
    [<CustomOperation("FooterClass")>] member _.FooterClass (render: AttrRenderFragment, x: System.String) = render ==> ("FooterClass" => x)
    [<CustomOperation("ColGroup")>] member _.ColGroup (render: AttrRenderFragment, fragment) = render ==> html.renderFragment("ColGroup", fragment)
    [<CustomOperation("ColGroup")>] member _.ColGroup (render: AttrRenderFragment, fragments) = render ==> html.renderFragment("ColGroup", fragment { yield! fragments })
    [<CustomOperation("ColGroup")>] member _.ColGroup (render: AttrRenderFragment, x: string) = render ==> html.renderFragment("ColGroup", html.text x)
    [<CustomOperation("ColGroup")>] member _.ColGroup (render: AttrRenderFragment, x: int) = render ==> html.renderFragment("ColGroup", html.text x)
    [<CustomOperation("ColGroup")>] member _.ColGroup (render: AttrRenderFragment, x: float) = render ==> html.renderFragment("ColGroup", html.text x)
    [<CustomOperation("PagerContent")>] member _.PagerContent (render: AttrRenderFragment, fragment) = render ==> html.renderFragment("PagerContent", fragment)
    [<CustomOperation("PagerContent")>] member _.PagerContent (render: AttrRenderFragment, fragments) = render ==> html.renderFragment("PagerContent", fragment { yield! fragments })
    [<CustomOperation("PagerContent")>] member _.PagerContent (render: AttrRenderFragment, x: string) = render ==> html.renderFragment("PagerContent", html.text x)
    [<CustomOperation("PagerContent")>] member _.PagerContent (render: AttrRenderFragment, x: int) = render ==> html.renderFragment("PagerContent", html.text x)
    [<CustomOperation("PagerContent")>] member _.PagerContent (render: AttrRenderFragment, x: float) = render ==> html.renderFragment("PagerContent", html.text x)
    [<CustomOperation("ReadOnly")>] member _.ReadOnly (render: AttrRenderFragment, x: System.Boolean) = render ==> ("ReadOnly" => x)
    [<CustomOperation("OnCommitEditClick")>] member _.OnCommitEditClick (render: AttrRenderFragment, fn) = render ==> html.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>("OnCommitEditClick", fn)
    [<CustomOperation("OnCancelEditClick")>] member _.OnCancelEditClick (render: AttrRenderFragment, fn) = render ==> html.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>("OnCancelEditClick", fn)
    [<CustomOperation("OnPreviewEditClick")>] member _.OnPreviewEditClick (render: AttrRenderFragment, fn) = render ==> html.callback<System.Object>("OnPreviewEditClick", fn)
    [<CustomOperation("CommitEditCommand")>] member _.CommitEditCommand (render: AttrRenderFragment, x: System.Windows.Input.ICommand) = render ==> ("CommitEditCommand" => x)
    [<CustomOperation("CommitEditCommandParameter")>] member _.CommitEditCommandParameter (render: AttrRenderFragment, x: System.Object) = render ==> ("CommitEditCommandParameter" => x)
    [<CustomOperation("CommitEditTooltip")>] member _.CommitEditTooltip (render: AttrRenderFragment, x: System.String) = render ==> ("CommitEditTooltip" => x)
    [<CustomOperation("CancelEditTooltip")>] member _.CancelEditTooltip (render: AttrRenderFragment, x: System.String) = render ==> ("CancelEditTooltip" => x)
    [<CustomOperation("CommitEditIcon")>] member _.CommitEditIcon (render: AttrRenderFragment, x: System.String) = render ==> ("CommitEditIcon" => x)
    [<CustomOperation("CancelEditIcon")>] member _.CancelEditIcon (render: AttrRenderFragment, x: System.String) = render ==> ("CancelEditIcon" => x)
    [<CustomOperation("CanCancelEdit")>] member _.CanCancelEdit (render: AttrRenderFragment, x: System.Boolean) = render ==> ("CanCancelEdit" => x)
    [<CustomOperation("RowEditPreview")>] member _.RowEditPreview (render: AttrRenderFragment, fn) = render ==> ("RowEditPreview" => (System.Action<System.Object>fn))
    [<CustomOperation("RowEditCommit")>] member _.RowEditCommit (render: AttrRenderFragment, fn) = render ==> ("RowEditCommit" => (System.Action<System.Object>fn))
    [<CustomOperation("RowEditCancel")>] member _.RowEditCancel (render: AttrRenderFragment, fn) = render ==> ("RowEditCancel" => (System.Action<System.Object>fn))
    [<CustomOperation("TotalItems")>] member _.TotalItems (render: AttrRenderFragment, x: System.Int32) = render ==> ("TotalItems" => x)
    [<CustomOperation("RowClass")>] member _.RowClass (render: AttrRenderFragment, x: System.String) = render ==> ("RowClass" => x)
    [<CustomOperation("RowStyle")>] member _.RowStyle (render: AttrRenderFragment, x: System.String) = render ==> ("RowStyle" => x)
    [<CustomOperation("Virtualize")>] member _.Virtualize (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Virtualize" => x)
                

type MudTableBuilder<'FunBlazorGeneric, 'T when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudTableBaseBuilder<'FunBlazorGeneric>()
    static member inline create () = html.fromBuilder(MudTableBuilder<'FunBlazorGeneric, 'T>())
    [<CustomOperation("RowTemplate")>] member _.RowTemplate (render: AttrRenderFragment, fn: 'T -> NodeRenderFragment) = render ==> html.renderFragment("RowTemplate", fn)
    [<CustomOperation("ChildRowContent")>] member _.ChildRowContent (render: AttrRenderFragment, fn: 'T -> NodeRenderFragment) = render ==> html.renderFragment("ChildRowContent", fn)
    [<CustomOperation("RowEditingTemplate")>] member _.RowEditingTemplate (render: AttrRenderFragment, fn: 'T -> NodeRenderFragment) = render ==> html.renderFragment("RowEditingTemplate", fn)
    [<CustomOperation("Columns")>] member _.Columns (render: AttrRenderFragment, fn: 'T -> NodeRenderFragment) = render ==> html.renderFragment("Columns", fn)
    [<CustomOperation("QuickColumns")>] member _.QuickColumns (render: AttrRenderFragment, x: System.String) = render ==> ("QuickColumns" => x)
    [<CustomOperation("NoRecordsContent")>] member _.NoRecordsContent (render: AttrRenderFragment, fragment) = render ==> html.renderFragment("NoRecordsContent", fragment)
    [<CustomOperation("NoRecordsContent")>] member _.NoRecordsContent (render: AttrRenderFragment, fragments) = render ==> html.renderFragment("NoRecordsContent", fragment { yield! fragments })
    [<CustomOperation("NoRecordsContent")>] member _.NoRecordsContent (render: AttrRenderFragment, x: string) = render ==> html.renderFragment("NoRecordsContent", html.text x)
    [<CustomOperation("NoRecordsContent")>] member _.NoRecordsContent (render: AttrRenderFragment, x: int) = render ==> html.renderFragment("NoRecordsContent", html.text x)
    [<CustomOperation("NoRecordsContent")>] member _.NoRecordsContent (render: AttrRenderFragment, x: float) = render ==> html.renderFragment("NoRecordsContent", html.text x)
    [<CustomOperation("LoadingContent")>] member _.LoadingContent (render: AttrRenderFragment, fragment) = render ==> html.renderFragment("LoadingContent", fragment)
    [<CustomOperation("LoadingContent")>] member _.LoadingContent (render: AttrRenderFragment, fragments) = render ==> html.renderFragment("LoadingContent", fragment { yield! fragments })
    [<CustomOperation("LoadingContent")>] member _.LoadingContent (render: AttrRenderFragment, x: string) = render ==> html.renderFragment("LoadingContent", html.text x)
    [<CustomOperation("LoadingContent")>] member _.LoadingContent (render: AttrRenderFragment, x: int) = render ==> html.renderFragment("LoadingContent", html.text x)
    [<CustomOperation("LoadingContent")>] member _.LoadingContent (render: AttrRenderFragment, x: float) = render ==> html.renderFragment("LoadingContent", html.text x)
    [<CustomOperation("HorizontalScrollbar")>] member _.HorizontalScrollbar (render: AttrRenderFragment, x: System.Boolean) = render ==> ("HorizontalScrollbar" => x)
    [<CustomOperation("Items")>] member _.Items (render: AttrRenderFragment, x: System.Collections.Generic.IEnumerable<'T>) = render ==> ("Items" => x)
    [<CustomOperation("Filter")>] member _.Filter (render: AttrRenderFragment, fn) = render ==> ("Filter" => (System.Func<'T, System.Boolean>fn))
    [<CustomOperation("OnRowClick")>] member _.OnRowClick (render: AttrRenderFragment, fn) = render ==> html.callback<MudBlazor.TableRowClickEventArgs<'T>>("OnRowClick", fn)
    [<CustomOperation("RowClassFunc")>] member _.RowClassFunc (render: AttrRenderFragment, fn) = render ==> ("RowClassFunc" => (System.Func<'T, System.Int32, System.String>fn))
    [<CustomOperation("RowStyleFunc")>] member _.RowStyleFunc (render: AttrRenderFragment, fn) = render ==> ("RowStyleFunc" => (System.Func<'T, System.Int32, System.String>fn))
    [<CustomOperation("SelectedItem")>] member _.SelectedItem (render: AttrRenderFragment, x: 'T) = render ==> ("SelectedItem" => x)
    [<CustomOperation("SelectedItem'")>] member _.SelectedItem' (render: AttrRenderFragment, value: IStore<'T>) = render ==> html.bind("SelectedItem", value)
    [<CustomOperation("SelectedItem'")>] member _.SelectedItem' (render: AttrRenderFragment, value: cval<'T>) = render ==> html.bind("SelectedItem", value)
    [<CustomOperation("SelectedItem'")>] member _.SelectedItem' (render: AttrRenderFragment, valueFn: 'T * ('T -> unit)) = render ==> html.bind("SelectedItem", valueFn)
    [<CustomOperation("SelectedItemChanged")>] member _.SelectedItemChanged (render: AttrRenderFragment, fn) = render ==> html.callback<'T>("SelectedItemChanged", fn)
    [<CustomOperation("SelectedItems")>] member _.SelectedItems (render: AttrRenderFragment, x: System.Collections.Generic.HashSet<'T>) = render ==> ("SelectedItems" => x)
    [<CustomOperation("SelectedItems'")>] member _.SelectedItems' (render: AttrRenderFragment, value: IStore<System.Collections.Generic.HashSet<'T>>) = render ==> html.bind("SelectedItems", value)
    [<CustomOperation("SelectedItems'")>] member _.SelectedItems' (render: AttrRenderFragment, value: cval<System.Collections.Generic.HashSet<'T>>) = render ==> html.bind("SelectedItems", value)
    [<CustomOperation("SelectedItems'")>] member _.SelectedItems' (render: AttrRenderFragment, valueFn: System.Collections.Generic.HashSet<'T> * (System.Collections.Generic.HashSet<'T> -> unit)) = render ==> html.bind("SelectedItems", valueFn)
    [<CustomOperation("SelectedItemsChanged")>] member _.SelectedItemsChanged (render: AttrRenderFragment, fn) = render ==> html.callback<System.Collections.Generic.HashSet<'T>>("SelectedItemsChanged", fn)
    [<CustomOperation("GroupBy")>] member _.GroupBy (render: AttrRenderFragment, x: MudBlazor.TableGroupDefinition<'T>) = render ==> ("GroupBy" => x)
    [<CustomOperation("GroupHeaderTemplate")>] member _.GroupHeaderTemplate (render: AttrRenderFragment, fn: MudBlazor.TableGroupData<System.Object, 'T> -> NodeRenderFragment) = render ==> html.renderFragment("GroupHeaderTemplate", fn)
    [<CustomOperation("GroupHeaderClass")>] member _.GroupHeaderClass (render: AttrRenderFragment, x: System.String) = render ==> ("GroupHeaderClass" => x)
    [<CustomOperation("GroupHeaderStyle")>] member _.GroupHeaderStyle (render: AttrRenderFragment, x: System.String) = render ==> ("GroupHeaderStyle" => x)
    [<CustomOperation("GroupFooterClass")>] member _.GroupFooterClass (render: AttrRenderFragment, x: System.String) = render ==> ("GroupFooterClass" => x)
    [<CustomOperation("GroupFooterStyle")>] member _.GroupFooterStyle (render: AttrRenderFragment, x: System.String) = render ==> ("GroupFooterStyle" => x)
    [<CustomOperation("GroupFooterTemplate")>] member _.GroupFooterTemplate (render: AttrRenderFragment, fn: MudBlazor.TableGroupData<System.Object, 'T> -> NodeRenderFragment) = render ==> html.renderFragment("GroupFooterTemplate", fn)
    [<CustomOperation("ServerData")>] member _.ServerData (render: AttrRenderFragment, fn) = render ==> ("ServerData" => (System.Func<MudBlazor.TableState, System.Threading.Tasks.Task<MudBlazor.TableData<'T>>>fn))
                

type MudTabsBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    static member inline create (x: string) = MudTabsBuilder<'FunBlazorGeneric>(){ x }
    static member inline create (x: NodeRenderFragment seq) = MudTabsBuilder<'FunBlazorGeneric>(){ yield! x }
    [<CustomOperation("KeepPanelsAlive")>] member _.KeepPanelsAlive (render: AttrRenderFragment, x: System.Boolean) = render ==> ("KeepPanelsAlive" => x)
    [<CustomOperation("Rounded")>] member _.Rounded (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Rounded" => x)
    [<CustomOperation("Border")>] member _.Border (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Border" => x)
    [<CustomOperation("Outlined")>] member _.Outlined (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Outlined" => x)
    [<CustomOperation("Centered")>] member _.Centered (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Centered" => x)
    [<CustomOperation("HideSlider")>] member _.HideSlider (render: AttrRenderFragment, x: System.Boolean) = render ==> ("HideSlider" => x)
    [<CustomOperation("PrevIcon")>] member _.PrevIcon (render: AttrRenderFragment, x: System.String) = render ==> ("PrevIcon" => x)
    [<CustomOperation("NextIcon")>] member _.NextIcon (render: AttrRenderFragment, x: System.String) = render ==> ("NextIcon" => x)
    [<CustomOperation("AlwaysShowScrollButtons")>] member _.AlwaysShowScrollButtons (render: AttrRenderFragment, x: System.Boolean) = render ==> ("AlwaysShowScrollButtons" => x)
    [<CustomOperation("MaxHeight")>] member _.MaxHeight (render: AttrRenderFragment, x: System.Nullable<System.Int32>) = render ==> ("MaxHeight" => x)
    [<CustomOperation("Position")>] member _.Position (render: AttrRenderFragment, x: MudBlazor.Position) = render ==> ("Position" => x)
    [<CustomOperation("Color")>] member _.Color (render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("Color" => x)
    [<CustomOperation("SliderColor")>] member _.SliderColor (render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("SliderColor" => x)
    [<CustomOperation("IconColor")>] member _.IconColor (render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("IconColor" => x)
    [<CustomOperation("ScrollIconColor")>] member _.ScrollIconColor (render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("ScrollIconColor" => x)
    [<CustomOperation("Elevation")>] member _.Elevation (render: AttrRenderFragment, x: System.Int32) = render ==> ("Elevation" => x)
    [<CustomOperation("ApplyEffectsToContainer")>] member _.ApplyEffectsToContainer (render: AttrRenderFragment, x: System.Boolean) = render ==> ("ApplyEffectsToContainer" => x)
    [<CustomOperation("DisableRipple")>] member _.DisableRipple (render: AttrRenderFragment, x: System.Boolean) = render ==> ("DisableRipple" => x)
    [<CustomOperation("DisableSliderAnimation")>] member _.DisableSliderAnimation (render: AttrRenderFragment, x: System.Boolean) = render ==> ("DisableSliderAnimation" => x)
    [<CustomOperation("PrePanelContent")>] member _.PrePanelContent (render: AttrRenderFragment, fn: MudBlazor.MudTabPanel -> NodeRenderFragment) = render ==> html.renderFragment("PrePanelContent", fn)
    [<CustomOperation("TabPanelClass")>] member _.TabPanelClass (render: AttrRenderFragment, x: System.String) = render ==> ("TabPanelClass" => x)
    [<CustomOperation("PanelClass")>] member _.PanelClass (render: AttrRenderFragment, x: System.String) = render ==> ("PanelClass" => x)
    [<CustomOperation("ActivePanelIndex")>] member _.ActivePanelIndex (render: AttrRenderFragment, x: System.Int32) = render ==> ("ActivePanelIndex" => x)
    [<CustomOperation("ActivePanelIndex'")>] member _.ActivePanelIndex' (render: AttrRenderFragment, value: IStore<System.Int32>) = render ==> html.bind("ActivePanelIndex", value)
    [<CustomOperation("ActivePanelIndex'")>] member _.ActivePanelIndex' (render: AttrRenderFragment, value: cval<System.Int32>) = render ==> html.bind("ActivePanelIndex", value)
    [<CustomOperation("ActivePanelIndex'")>] member _.ActivePanelIndex' (render: AttrRenderFragment, valueFn: System.Int32 * (System.Int32 -> unit)) = render ==> html.bind("ActivePanelIndex", valueFn)
    [<CustomOperation("ActivePanelIndexChanged")>] member _.ActivePanelIndexChanged (render: AttrRenderFragment, fn) = render ==> html.callback<System.Int32>("ActivePanelIndexChanged", fn)
    [<CustomOperation("Header")>] member _.Header (render: AttrRenderFragment, fn: MudBlazor.MudTabs -> NodeRenderFragment) = render ==> html.renderFragment("Header", fn)
    [<CustomOperation("HeaderPosition")>] member _.HeaderPosition (render: AttrRenderFragment, x: MudBlazor.TabHeaderPosition) = render ==> ("HeaderPosition" => x)
    [<CustomOperation("TabPanelHeader")>] member _.TabPanelHeader (render: AttrRenderFragment, fn: MudBlazor.MudTabPanel -> NodeRenderFragment) = render ==> html.renderFragment("TabPanelHeader", fn)
    [<CustomOperation("TabPanelHeaderPosition")>] member _.TabPanelHeaderPosition (render: AttrRenderFragment, x: MudBlazor.TabHeaderPosition) = render ==> ("TabPanelHeaderPosition" => x)
                

type MudDynamicTabsBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudTabsBuilder<'FunBlazorGeneric>()
    static member inline create () = html.fromBuilder(MudDynamicTabsBuilder<'FunBlazorGeneric>())
    [<CustomOperation("AddTabIcon")>] member _.AddTabIcon (render: AttrRenderFragment, x: System.String) = render ==> ("AddTabIcon" => x)
    [<CustomOperation("CloseTabIcon")>] member _.CloseTabIcon (render: AttrRenderFragment, x: System.String) = render ==> ("CloseTabIcon" => x)
    [<CustomOperation("AddTab")>] member _.AddTab (render: AttrRenderFragment, fn) = render ==> html.callback<unit>("AddTab", fn)
    [<CustomOperation("CloseTab")>] member _.CloseTab (render: AttrRenderFragment, fn) = render ==> html.callback<MudBlazor.MudTabPanel>("CloseTab", fn)
    [<CustomOperation("AddIconClass")>] member _.AddIconClass (render: AttrRenderFragment, x: System.String) = render ==> ("AddIconClass" => x)
    [<CustomOperation("AddIconStyle")>] member _.AddIconStyle (render: AttrRenderFragment, x: System.String) = render ==> ("AddIconStyle" => x)
    [<CustomOperation("CloseIconClass")>] member _.CloseIconClass (render: AttrRenderFragment, x: System.String) = render ==> ("CloseIconClass" => x)
    [<CustomOperation("CloseIconStyle")>] member _.CloseIconStyle (render: AttrRenderFragment, x: System.String) = render ==> ("CloseIconStyle" => x)
    [<CustomOperation("AddIconToolTip")>] member _.AddIconToolTip (render: AttrRenderFragment, x: System.String) = render ==> ("AddIconToolTip" => x)
    [<CustomOperation("CloseIconToolTip")>] member _.CloseIconToolTip (render: AttrRenderFragment, x: System.String) = render ==> ("CloseIconToolTip" => x)
                

type MudChartBaseBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    static member inline create () = html.fromBuilder(MudChartBaseBuilder<'FunBlazorGeneric>())
    [<CustomOperation("InputData")>] member _.InputData (render: AttrRenderFragment, x: System.Double[]) = render ==> ("InputData" => x)
    [<CustomOperation("InputLabels")>] member _.InputLabels (render: AttrRenderFragment, x: System.String[]) = render ==> ("InputLabels" => x)
    [<CustomOperation("XAxisLabels")>] member _.XAxisLabels (render: AttrRenderFragment, x: System.String[]) = render ==> ("XAxisLabels" => x)
    [<CustomOperation("ChartSeries")>] member _.ChartSeries (render: AttrRenderFragment, x: System.Collections.Generic.List<MudBlazor.ChartSeries>) = render ==> ("ChartSeries" => x)
    [<CustomOperation("ChartOptions")>] member _.ChartOptions (render: AttrRenderFragment, x: MudBlazor.ChartOptions) = render ==> ("ChartOptions" => x)
    [<CustomOperation("CustomGraphics")>] member _.CustomGraphics (render: AttrRenderFragment, fragment) = render ==> html.renderFragment("CustomGraphics", fragment)
    [<CustomOperation("CustomGraphics")>] member _.CustomGraphics (render: AttrRenderFragment, fragments) = render ==> html.renderFragment("CustomGraphics", fragment { yield! fragments })
    [<CustomOperation("CustomGraphics")>] member _.CustomGraphics (render: AttrRenderFragment, x: string) = render ==> html.renderFragment("CustomGraphics", html.text x)
    [<CustomOperation("CustomGraphics")>] member _.CustomGraphics (render: AttrRenderFragment, x: int) = render ==> html.renderFragment("CustomGraphics", html.text x)
    [<CustomOperation("CustomGraphics")>] member _.CustomGraphics (render: AttrRenderFragment, x: float) = render ==> html.renderFragment("CustomGraphics", html.text x)
    [<CustomOperation("ChartType")>] member _.ChartType (render: AttrRenderFragment, x: MudBlazor.ChartType) = render ==> ("ChartType" => x)
    [<CustomOperation("Width")>] member _.Width (render: AttrRenderFragment, x: System.String) = render ==> ("Width" => x)
    [<CustomOperation("Height")>] member _.Height (render: AttrRenderFragment, x: System.String) = render ==> ("Height" => x)
    [<CustomOperation("LegendPosition")>] member _.LegendPosition (render: AttrRenderFragment, x: MudBlazor.Position) = render ==> ("LegendPosition" => x)
    [<CustomOperation("SelectedIndex")>] member _.SelectedIndex (render: AttrRenderFragment, x: System.Int32) = render ==> ("SelectedIndex" => x)
    [<CustomOperation("SelectedIndex'")>] member _.SelectedIndex' (render: AttrRenderFragment, value: IStore<System.Int32>) = render ==> html.bind("SelectedIndex", value)
    [<CustomOperation("SelectedIndex'")>] member _.SelectedIndex' (render: AttrRenderFragment, value: cval<System.Int32>) = render ==> html.bind("SelectedIndex", value)
    [<CustomOperation("SelectedIndex'")>] member _.SelectedIndex' (render: AttrRenderFragment, valueFn: System.Int32 * (System.Int32 -> unit)) = render ==> html.bind("SelectedIndex", valueFn)
    [<CustomOperation("SelectedIndexChanged")>] member _.SelectedIndexChanged (render: AttrRenderFragment, fn) = render ==> html.callback<System.Int32>("SelectedIndexChanged", fn)
                

type MudChartBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudChartBaseBuilder<'FunBlazorGeneric>()
    static member inline create () = html.fromBuilder(MudChartBuilder<'FunBlazorGeneric>())

                
            
namespace rec MudBlazor.DslInternals.Charts

open FSharp.Data.Adaptive
open Fun.Blazor
open Fun.Blazor.Operators
open MudBlazor.DslInternals


type BarBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudChartBaseBuilder<'FunBlazorGeneric>()
    static member inline create () = html.fromBuilder(BarBuilder<'FunBlazorGeneric>())

                

type DonutBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudChartBaseBuilder<'FunBlazorGeneric>()
    static member inline create () = html.fromBuilder(DonutBuilder<'FunBlazorGeneric>())

                

type LineBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudChartBaseBuilder<'FunBlazorGeneric>()
    static member inline create () = html.fromBuilder(LineBuilder<'FunBlazorGeneric>())

                

type PieBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudChartBaseBuilder<'FunBlazorGeneric>()
    static member inline create () = html.fromBuilder(PieBuilder<'FunBlazorGeneric>())

                

type LegendBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudChartBaseBuilder<'FunBlazorGeneric>()
    static member inline create () = html.fromBuilder(LegendBuilder<'FunBlazorGeneric>())
    [<CustomOperation("Data")>] member _.Data (render: AttrRenderFragment, x: System.Collections.Generic.List<MudBlazor.Charts.SVG.Models.SvgLegend>) = render ==> ("Data" => x)
                
            
namespace rec MudBlazor.DslInternals

open FSharp.Data.Adaptive
open Fun.Blazor
open Fun.Blazor.Operators
open MudBlazor.DslInternals


type MudBaseItemsControlBuilder<'FunBlazorGeneric, 'TChildComponent when 'TChildComponent :> MudBlazor.MudComponentBase and 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    static member inline create (x: string) = MudBaseItemsControlBuilder<'FunBlazorGeneric, 'TChildComponent>(){ x }
    static member inline create (x: NodeRenderFragment seq) = MudBaseItemsControlBuilder<'FunBlazorGeneric, 'TChildComponent>(){ yield! x }
    [<CustomOperation("SelectedIndex")>] member _.SelectedIndex (render: AttrRenderFragment, x: System.Int32) = render ==> ("SelectedIndex" => x)
    [<CustomOperation("SelectedIndex'")>] member _.SelectedIndex' (render: AttrRenderFragment, value: IStore<System.Int32>) = render ==> html.bind("SelectedIndex", value)
    [<CustomOperation("SelectedIndex'")>] member _.SelectedIndex' (render: AttrRenderFragment, value: cval<System.Int32>) = render ==> html.bind("SelectedIndex", value)
    [<CustomOperation("SelectedIndex'")>] member _.SelectedIndex' (render: AttrRenderFragment, valueFn: System.Int32 * (System.Int32 -> unit)) = render ==> html.bind("SelectedIndex", valueFn)
    [<CustomOperation("SelectedIndexChanged")>] member _.SelectedIndexChanged (render: AttrRenderFragment, fn) = render ==> html.callback<System.Int32>("SelectedIndexChanged", fn)
                

type MudBaseBindableItemsControlBuilder<'FunBlazorGeneric, 'TChildComponent, 'TData when 'TChildComponent :> MudBlazor.MudComponentBase and 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudBaseItemsControlBuilder<'FunBlazorGeneric, 'TChildComponent>()
    static member inline create () = html.fromBuilder(MudBaseBindableItemsControlBuilder<'FunBlazorGeneric, 'TChildComponent, 'TData>())
    [<CustomOperation("ItemsSource")>] member _.ItemsSource (render: AttrRenderFragment, x: System.Collections.Generic.IEnumerable<'TData>) = render ==> ("ItemsSource" => x)
    [<CustomOperation("ItemTemplate")>] member _.ItemTemplate (render: AttrRenderFragment, fn: 'TData -> NodeRenderFragment) = render ==> html.renderFragment("ItemTemplate", fn)
                

type MudCarouselBuilder<'FunBlazorGeneric, 'TData when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudBaseBindableItemsControlBuilder<'FunBlazorGeneric, MudBlazor.MudCarouselItem, 'TData>()
    static member inline create () = html.fromBuilder(MudCarouselBuilder<'FunBlazorGeneric, 'TData>())
    [<CustomOperation("ShowArrows")>] member _.ShowArrows (render: AttrRenderFragment, x: System.Boolean) = render ==> ("ShowArrows" => x)
    [<CustomOperation("ArrowsPosition")>] member _.ArrowsPosition (render: AttrRenderFragment, x: MudBlazor.Position) = render ==> ("ArrowsPosition" => x)
    [<CustomOperation("ShowBullets")>] member _.ShowBullets (render: AttrRenderFragment, x: System.Boolean) = render ==> ("ShowBullets" => x)
    [<CustomOperation("BulletsPosition")>] member _.BulletsPosition (render: AttrRenderFragment, x: MudBlazor.Position) = render ==> ("BulletsPosition" => x)
    [<CustomOperation("BulletsColor")>] member _.BulletsColor (render: AttrRenderFragment, x: System.Nullable<MudBlazor.Color>) = render ==> ("BulletsColor" => x)
    [<CustomOperation("ShowDelimiters")>] member _.ShowDelimiters (render: AttrRenderFragment, x: System.Boolean) = render ==> ("ShowDelimiters" => x)
    [<CustomOperation("DelimitersColor")>] member _.DelimitersColor (render: AttrRenderFragment, x: System.Nullable<MudBlazor.Color>) = render ==> ("DelimitersColor" => x)
    [<CustomOperation("AutoCycle")>] member _.AutoCycle (render: AttrRenderFragment, x: System.Boolean) = render ==> ("AutoCycle" => x)
    [<CustomOperation("AutoCycleTime")>] member _.AutoCycleTime (render: AttrRenderFragment, x: System.TimeSpan) = render ==> ("AutoCycleTime" => x)
    [<CustomOperation("NavigationButtonsClass")>] member _.NavigationButtonsClass (render: AttrRenderFragment, x: System.String) = render ==> ("NavigationButtonsClass" => x)
    [<CustomOperation("BulletsClass")>] member _.BulletsClass (render: AttrRenderFragment, x: System.String) = render ==> ("BulletsClass" => x)
    [<CustomOperation("DelimitersClass")>] member _.DelimitersClass (render: AttrRenderFragment, x: System.String) = render ==> ("DelimitersClass" => x)
    [<CustomOperation("PreviousIcon")>] member _.PreviousIcon (render: AttrRenderFragment, x: System.String) = render ==> ("PreviousIcon" => x)
    [<CustomOperation("CheckedIcon")>] member _.CheckedIcon (render: AttrRenderFragment, x: System.String) = render ==> ("CheckedIcon" => x)
    [<CustomOperation("UncheckedIcon")>] member _.UncheckedIcon (render: AttrRenderFragment, x: System.String) = render ==> ("UncheckedIcon" => x)
    [<CustomOperation("NextIcon")>] member _.NextIcon (render: AttrRenderFragment, x: System.String) = render ==> ("NextIcon" => x)
    [<CustomOperation("NextButtonTemplate")>] member _.NextButtonTemplate (render: AttrRenderFragment, fragment) = render ==> html.renderFragment("NextButtonTemplate", fragment)
    [<CustomOperation("NextButtonTemplate")>] member _.NextButtonTemplate (render: AttrRenderFragment, fragments) = render ==> html.renderFragment("NextButtonTemplate", fragment { yield! fragments })
    [<CustomOperation("NextButtonTemplate")>] member _.NextButtonTemplate (render: AttrRenderFragment, x: string) = render ==> html.renderFragment("NextButtonTemplate", html.text x)
    [<CustomOperation("NextButtonTemplate")>] member _.NextButtonTemplate (render: AttrRenderFragment, x: int) = render ==> html.renderFragment("NextButtonTemplate", html.text x)
    [<CustomOperation("NextButtonTemplate")>] member _.NextButtonTemplate (render: AttrRenderFragment, x: float) = render ==> html.renderFragment("NextButtonTemplate", html.text x)
    [<CustomOperation("PreviousButtonTemplate")>] member _.PreviousButtonTemplate (render: AttrRenderFragment, fragment) = render ==> html.renderFragment("PreviousButtonTemplate", fragment)
    [<CustomOperation("PreviousButtonTemplate")>] member _.PreviousButtonTemplate (render: AttrRenderFragment, fragments) = render ==> html.renderFragment("PreviousButtonTemplate", fragment { yield! fragments })
    [<CustomOperation("PreviousButtonTemplate")>] member _.PreviousButtonTemplate (render: AttrRenderFragment, x: string) = render ==> html.renderFragment("PreviousButtonTemplate", html.text x)
    [<CustomOperation("PreviousButtonTemplate")>] member _.PreviousButtonTemplate (render: AttrRenderFragment, x: int) = render ==> html.renderFragment("PreviousButtonTemplate", html.text x)
    [<CustomOperation("PreviousButtonTemplate")>] member _.PreviousButtonTemplate (render: AttrRenderFragment, x: float) = render ==> html.renderFragment("PreviousButtonTemplate", html.text x)
    [<CustomOperation("BulletTemplate")>] member _.BulletTemplate (render: AttrRenderFragment, fn: System.Boolean -> NodeRenderFragment) = render ==> html.renderFragment("BulletTemplate", fn)
    [<CustomOperation("DelimiterTemplate")>] member _.DelimiterTemplate (render: AttrRenderFragment, fn: System.Boolean -> NodeRenderFragment) = render ==> html.renderFragment("DelimiterTemplate", fn)
                

type MudTimelineBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudBaseItemsControlBuilder<'FunBlazorGeneric, MudBlazor.MudTimelineItem>()
    static member inline create () = html.fromBuilder(MudTimelineBuilder<'FunBlazorGeneric>())
    [<CustomOperation("TimelineOrientation")>] member _.TimelineOrientation (render: AttrRenderFragment, x: MudBlazor.TimelineOrientation) = render ==> ("TimelineOrientation" => x)
    [<CustomOperation("TimelinePosition")>] member _.TimelinePosition (render: AttrRenderFragment, x: MudBlazor.TimelinePosition) = render ==> ("TimelinePosition" => x)
    [<CustomOperation("TimelineAlign")>] member _.TimelineAlign (render: AttrRenderFragment, x: MudBlazor.TimelineAlign) = render ==> ("TimelineAlign" => x)
    [<CustomOperation("Reverse")>] member _.Reverse (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Reverse" => x)
    [<CustomOperation("DisableModifiers")>] member _.DisableModifiers (render: AttrRenderFragment, x: System.Boolean) = render ==> ("DisableModifiers" => x)
                

type MudFormComponentBuilder<'FunBlazorGeneric, 'T, 'U when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    static member inline create () = html.fromBuilder(MudFormComponentBuilder<'FunBlazorGeneric, 'T, 'U>())
    [<CustomOperation("Required")>] member _.Required (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Required" => x)
    [<CustomOperation("RequiredError")>] member _.RequiredError (render: AttrRenderFragment, x: System.String) = render ==> ("RequiredError" => x)
    [<CustomOperation("ErrorText")>] member _.ErrorText (render: AttrRenderFragment, x: System.String) = render ==> ("ErrorText" => x)
    [<CustomOperation("Error")>] member _.Error (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Error" => x)
    [<CustomOperation("Converter")>] member _.Converter (render: AttrRenderFragment, x: MudBlazor.Converter<'T, 'U>) = render ==> ("Converter" => x)
    [<CustomOperation("Culture")>] member _.Culture (render: AttrRenderFragment, x: System.Globalization.CultureInfo) = render ==> ("Culture" => x)
    [<CustomOperation("Validation")>] member _.Validation (render: AttrRenderFragment, x: System.Object) = render ==> ("Validation" => x)
    [<CustomOperation("For'")>] member _.For' (render: AttrRenderFragment, x: System.Linq.Expressions.Expression<System.Func<'T>>) = render ==> ("For" => x)
                

type MudBaseInputBuilder<'FunBlazorGeneric, 'T when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudFormComponentBuilder<'FunBlazorGeneric, 'T, System.String>()
    static member inline create () = html.fromBuilder(MudBaseInputBuilder<'FunBlazorGeneric, 'T>())
    [<CustomOperation("Disabled")>] member _.Disabled (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Disabled" => x)
    [<CustomOperation("ReadOnly")>] member _.ReadOnly (render: AttrRenderFragment, x: System.Boolean) = render ==> ("ReadOnly" => x)
    [<CustomOperation("FullWidth")>] member _.FullWidth (render: AttrRenderFragment, x: System.Boolean) = render ==> ("FullWidth" => x)
    [<CustomOperation("Immediate")>] member _.Immediate (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Immediate" => x)
    [<CustomOperation("DisableUnderLine")>] member _.DisableUnderLine (render: AttrRenderFragment, x: System.Boolean) = render ==> ("DisableUnderLine" => x)
    [<CustomOperation("HelperText")>] member _.HelperText (render: AttrRenderFragment, x: System.String) = render ==> ("HelperText" => x)
    [<CustomOperation("HelperTextOnFocus")>] member _.HelperTextOnFocus (render: AttrRenderFragment, x: System.Boolean) = render ==> ("HelperTextOnFocus" => x)
    [<CustomOperation("AdornmentIcon")>] member _.AdornmentIcon (render: AttrRenderFragment, x: System.String) = render ==> ("AdornmentIcon" => x)
    [<CustomOperation("AdornmentText")>] member _.AdornmentText (render: AttrRenderFragment, x: System.String) = render ==> ("AdornmentText" => x)
    [<CustomOperation("Adornment")>] member _.Adornment (render: AttrRenderFragment, x: MudBlazor.Adornment) = render ==> ("Adornment" => x)
    [<CustomOperation("AdornmentColor")>] member _.AdornmentColor (render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("AdornmentColor" => x)
    [<CustomOperation("IconSize")>] member _.IconSize (render: AttrRenderFragment, x: MudBlazor.Size) = render ==> ("IconSize" => x)
    [<CustomOperation("OnAdornmentClick")>] member _.OnAdornmentClick (render: AttrRenderFragment, fn) = render ==> html.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>("OnAdornmentClick", fn)
    [<CustomOperation("Variant")>] member _.Variant (render: AttrRenderFragment, x: MudBlazor.Variant) = render ==> ("Variant" => x)
    [<CustomOperation("Margin")>] member _.Margin (render: AttrRenderFragment, x: MudBlazor.Margin) = render ==> ("Margin" => x)
    [<CustomOperation("Placeholder")>] member _.Placeholder (render: AttrRenderFragment, x: System.String) = render ==> ("Placeholder" => x)
    [<CustomOperation("Counter")>] member _.Counter (render: AttrRenderFragment, x: System.Nullable<System.Int32>) = render ==> ("Counter" => x)
    [<CustomOperation("MaxLength")>] member _.MaxLength (render: AttrRenderFragment, x: System.Int32) = render ==> ("MaxLength" => x)
    [<CustomOperation("Label")>] member _.Label (render: AttrRenderFragment, x: System.String) = render ==> ("Label" => x)
    [<CustomOperation("AutoFocus")>] member _.AutoFocus (render: AttrRenderFragment, x: System.Boolean) = render ==> ("AutoFocus" => x)
    [<CustomOperation("Lines")>] member _.Lines (render: AttrRenderFragment, x: System.Int32) = render ==> ("Lines" => x)
    [<CustomOperation("Text")>] member _.Text (render: AttrRenderFragment, x: System.String) = render ==> ("Text" => x)
    [<CustomOperation("Text'")>] member _.Text' (render: AttrRenderFragment, value: IStore<System.String>) = render ==> html.bind("Text", value)
    [<CustomOperation("Text'")>] member _.Text' (render: AttrRenderFragment, value: cval<System.String>) = render ==> html.bind("Text", value)
    [<CustomOperation("Text'")>] member _.Text' (render: AttrRenderFragment, valueFn: System.String * (System.String -> unit)) = render ==> html.bind("Text", valueFn)
    [<CustomOperation("TextUpdateSuppression")>] member _.TextUpdateSuppression (render: AttrRenderFragment, x: System.Boolean) = render ==> ("TextUpdateSuppression" => x)
    [<CustomOperation("InputMode")>] member _.InputMode (render: AttrRenderFragment, x: MudBlazor.InputMode) = render ==> ("InputMode" => x)
    [<CustomOperation("Pattern")>] member _.Pattern (render: AttrRenderFragment, x: System.String) = render ==> ("Pattern" => x)
    [<CustomOperation("TextChanged")>] member _.TextChanged (render: AttrRenderFragment, fn) = render ==> html.callback<System.String>("TextChanged", fn)
    [<CustomOperation("OnBlur")>] member _.OnBlur (render: AttrRenderFragment, fn) = render ==> html.callback<Microsoft.AspNetCore.Components.Web.FocusEventArgs>("OnBlur", fn)
    [<CustomOperation("OnInternalInputChanged")>] member _.OnInternalInputChanged (render: AttrRenderFragment, fn) = render ==> html.callback<Microsoft.AspNetCore.Components.ChangeEventArgs>("OnInternalInputChanged", fn)
    [<CustomOperation("OnKeyDown")>] member _.OnKeyDown (render: AttrRenderFragment, fn) = render ==> html.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs>("OnKeyDown", fn)
    [<CustomOperation("KeyDownPreventDefault")>] member _.KeyDownPreventDefault (render: AttrRenderFragment, x: System.Boolean) = render ==> ("KeyDownPreventDefault" => x)
    [<CustomOperation("OnKeyPress")>] member _.OnKeyPress (render: AttrRenderFragment, fn) = render ==> html.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs>("OnKeyPress", fn)
    [<CustomOperation("KeyPressPreventDefault")>] member _.KeyPressPreventDefault (render: AttrRenderFragment, x: System.Boolean) = render ==> ("KeyPressPreventDefault" => x)
    [<CustomOperation("OnKeyUp")>] member _.OnKeyUp (render: AttrRenderFragment, fn) = render ==> html.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs>("OnKeyUp", fn)
    [<CustomOperation("KeyUpPreventDefault")>] member _.KeyUpPreventDefault (render: AttrRenderFragment, x: System.Boolean) = render ==> ("KeyUpPreventDefault" => x)
    [<CustomOperation("ValueChanged")>] member _.ValueChanged (render: AttrRenderFragment, fn) = render ==> html.callback<'T>("ValueChanged", fn)
    [<CustomOperation("Value")>] member _.Value (render: AttrRenderFragment, x: 'T) = render ==> ("Value" => x)
    [<CustomOperation("Value'")>] member _.Value' (render: AttrRenderFragment, value: IStore<'T>) = render ==> html.bind("Value", value)
    [<CustomOperation("Value'")>] member _.Value' (render: AttrRenderFragment, value: cval<'T>) = render ==> html.bind("Value", value)
    [<CustomOperation("Value'")>] member _.Value' (render: AttrRenderFragment, valueFn: 'T * ('T -> unit)) = render ==> html.bind("Value", valueFn)
    [<CustomOperation("Format")>] member _.Format (render: AttrRenderFragment, x: System.String) = render ==> ("Format" => x)
                

type MudAutocompleteBuilder<'FunBlazorGeneric, 'T when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudBaseInputBuilder<'FunBlazorGeneric, 'T>()
    static member inline create () = html.fromBuilder(MudAutocompleteBuilder<'FunBlazorGeneric, 'T>())
    [<CustomOperation("PopoverClass")>] member _.PopoverClass (render: AttrRenderFragment, x: System.String) = render ==> ("PopoverClass" => x)
    [<CustomOperation("AnchorOrigin")>] member _.AnchorOrigin (render: AttrRenderFragment, x: MudBlazor.Origin) = render ==> ("AnchorOrigin" => x)
    [<CustomOperation("TransformOrigin")>] member _.TransformOrigin (render: AttrRenderFragment, x: MudBlazor.Origin) = render ==> ("TransformOrigin" => x)
    [<CustomOperation("Dense")>] member _.Dense (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Dense" => x)
    [<CustomOperation("OpenIcon")>] member _.OpenIcon (render: AttrRenderFragment, x: System.String) = render ==> ("OpenIcon" => x)
    [<CustomOperation("CloseIcon")>] member _.CloseIcon (render: AttrRenderFragment, x: System.String) = render ==> ("CloseIcon" => x)
    [<CustomOperation("MaxHeight")>] member _.MaxHeight (render: AttrRenderFragment, x: System.Int32) = render ==> ("MaxHeight" => x)
    [<CustomOperation("ToStringFunc")>] member _.ToStringFunc (render: AttrRenderFragment, fn) = render ==> ("ToStringFunc" => (System.Func<'T, System.String>fn))
    [<CustomOperation("SearchFunc")>] member _.SearchFunc (render: AttrRenderFragment, fn) = render ==> ("SearchFunc" => (System.Func<System.String, System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<'T>>>fn))
    [<CustomOperation("MaxItems")>] member _.MaxItems (render: AttrRenderFragment, x: System.Nullable<System.Int32>) = render ==> ("MaxItems" => x)
    [<CustomOperation("MinCharacters")>] member _.MinCharacters (render: AttrRenderFragment, x: System.Int32) = render ==> ("MinCharacters" => x)
    [<CustomOperation("ResetValueOnEmptyText")>] member _.ResetValueOnEmptyText (render: AttrRenderFragment, x: System.Boolean) = render ==> ("ResetValueOnEmptyText" => x)
    [<CustomOperation("DebounceInterval")>] member _.DebounceInterval (render: AttrRenderFragment, x: System.Int32) = render ==> ("DebounceInterval" => x)
    [<CustomOperation("ItemTemplate")>] member _.ItemTemplate (render: AttrRenderFragment, fn: 'T -> NodeRenderFragment) = render ==> html.renderFragment("ItemTemplate", fn)
    [<CustomOperation("ItemSelectedTemplate")>] member _.ItemSelectedTemplate (render: AttrRenderFragment, fn: 'T -> NodeRenderFragment) = render ==> html.renderFragment("ItemSelectedTemplate", fn)
    [<CustomOperation("ItemDisabledTemplate")>] member _.ItemDisabledTemplate (render: AttrRenderFragment, fn: 'T -> NodeRenderFragment) = render ==> html.renderFragment("ItemDisabledTemplate", fn)
    [<CustomOperation("CoerceText")>] member _.CoerceText (render: AttrRenderFragment, x: System.Boolean) = render ==> ("CoerceText" => x)
    [<CustomOperation("CoerceValue")>] member _.CoerceValue (render: AttrRenderFragment, x: System.Boolean) = render ==> ("CoerceValue" => x)
    [<CustomOperation("ItemDisabledFunc")>] member _.ItemDisabledFunc (render: AttrRenderFragment, fn) = render ==> ("ItemDisabledFunc" => (System.Func<'T, System.Boolean>fn))
    [<CustomOperation("IsOpenChanged")>] member _.IsOpenChanged (render: AttrRenderFragment, fn) = render ==> html.callback<System.Boolean>("IsOpenChanged", fn)
    [<CustomOperation("SelectValueOnTab")>] member _.SelectValueOnTab (render: AttrRenderFragment, x: System.Boolean) = render ==> ("SelectValueOnTab" => x)
    [<CustomOperation("Clearable")>] member _.Clearable (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Clearable" => x)
    [<CustomOperation("OnClearButtonClick")>] member _.OnClearButtonClick (render: AttrRenderFragment, fn) = render ==> html.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>("OnClearButtonClick", fn)
                

type MudDebouncedInputBuilder<'FunBlazorGeneric, 'T when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudBaseInputBuilder<'FunBlazorGeneric, 'T>()
    static member inline create () = html.fromBuilder(MudDebouncedInputBuilder<'FunBlazorGeneric, 'T>())
    [<CustomOperation("DebounceInterval")>] member _.DebounceInterval (render: AttrRenderFragment, x: System.Double) = render ==> ("DebounceInterval" => x)
    [<CustomOperation("OnDebounceIntervalElapsed")>] member _.OnDebounceIntervalElapsed (render: AttrRenderFragment, fn) = render ==> html.callback<System.String>("OnDebounceIntervalElapsed", fn)
                

type MudNumericFieldBuilder<'FunBlazorGeneric, 'T when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudDebouncedInputBuilder<'FunBlazorGeneric, 'T>()
    static member inline create () = html.fromBuilder(MudNumericFieldBuilder<'FunBlazorGeneric, 'T>())
    [<CustomOperation("Clearable")>] member _.Clearable (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Clearable" => x)
    [<CustomOperation("InvertMouseWheel")>] member _.InvertMouseWheel (render: AttrRenderFragment, x: System.Boolean) = render ==> ("InvertMouseWheel" => x)
    [<CustomOperation("Min")>] member _.Min (render: AttrRenderFragment, x: 'T) = render ==> ("Min" => x)
    [<CustomOperation("Max")>] member _.Max (render: AttrRenderFragment, x: 'T) = render ==> ("Max" => x)
    [<CustomOperation("Step")>] member _.Step (render: AttrRenderFragment, x: 'T) = render ==> ("Step" => x)
    [<CustomOperation("HideSpinButtons")>] member _.HideSpinButtons (render: AttrRenderFragment, x: System.Boolean) = render ==> ("HideSpinButtons" => x)
    [<CustomOperation("InputMode")>] member _.InputMode (render: AttrRenderFragment, x: MudBlazor.InputMode) = render ==> ("InputMode" => x)
    [<CustomOperation("Pattern")>] member _.Pattern (render: AttrRenderFragment, x: System.String) = render ==> ("Pattern" => x)
                

type MudTextFieldBuilder<'FunBlazorGeneric, 'T when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudDebouncedInputBuilder<'FunBlazorGeneric, 'T>()
    static member inline create () = html.fromBuilder(MudTextFieldBuilder<'FunBlazorGeneric, 'T>())
    [<CustomOperation("InputType")>] member _.InputType (render: AttrRenderFragment, x: MudBlazor.InputType) = render ==> ("InputType" => x)
    [<CustomOperation("Clearable")>] member _.Clearable (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Clearable" => x)
    [<CustomOperation("OnClearButtonClick")>] member _.OnClearButtonClick (render: AttrRenderFragment, fn) = render ==> html.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>("OnClearButtonClick", fn)
                

type MudInputBuilder<'FunBlazorGeneric, 'T when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudBaseInputBuilder<'FunBlazorGeneric, 'T>()
    static member inline create (x: string) = MudInputBuilder<'FunBlazorGeneric, 'T>(){ x }
    static member inline create (x: NodeRenderFragment seq) = MudInputBuilder<'FunBlazorGeneric, 'T>(){ yield! x }
    [<CustomOperation("InputType")>] member _.InputType (render: AttrRenderFragment, x: MudBlazor.InputType) = render ==> ("InputType" => x)
    [<CustomOperation("OnIncrement")>] member _.OnIncrement (render: AttrRenderFragment, fn) = render ==> html.callback<unit>("OnIncrement", fn)
    [<CustomOperation("OnDecrement")>] member _.OnDecrement (render: AttrRenderFragment, fn) = render ==> html.callback<unit>("OnDecrement", fn)
    [<CustomOperation("HideSpinButtons")>] member _.HideSpinButtons (render: AttrRenderFragment, x: System.Boolean) = render ==> ("HideSpinButtons" => x)
    [<CustomOperation("Clearable")>] member _.Clearable (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Clearable" => x)
    [<CustomOperation("OnClearButtonClick")>] member _.OnClearButtonClick (render: AttrRenderFragment, fn) = render ==> html.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>("OnClearButtonClick", fn)
    [<CustomOperation("OnMouseWheel")>] member _.OnMouseWheel (render: AttrRenderFragment, fn) = render ==> html.callback<Microsoft.AspNetCore.Components.Web.WheelEventArgs>("OnMouseWheel", fn)
    [<CustomOperation("ClearIcon")>] member _.ClearIcon (render: AttrRenderFragment, x: System.String) = render ==> ("ClearIcon" => x)
    [<CustomOperation("NumericUpIcon")>] member _.NumericUpIcon (render: AttrRenderFragment, x: System.String) = render ==> ("NumericUpIcon" => x)
    [<CustomOperation("NumericDownIcon")>] member _.NumericDownIcon (render: AttrRenderFragment, x: System.String) = render ==> ("NumericDownIcon" => x)
                

type MudInputStringBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudInputBuilder<'FunBlazorGeneric, System.String>()
    static member inline create () = html.fromBuilder(MudInputStringBuilder<'FunBlazorGeneric>())

                

type MudRangeInputBuilder<'FunBlazorGeneric, 'T when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudBaseInputBuilder<'FunBlazorGeneric, MudBlazor.Range<'T>>()
    static member inline create (x: string) = MudRangeInputBuilder<'FunBlazorGeneric, 'T>(){ x }
    static member inline create (x: NodeRenderFragment seq) = MudRangeInputBuilder<'FunBlazorGeneric, 'T>(){ yield! x }
    [<CustomOperation("InputType")>] member _.InputType (render: AttrRenderFragment, x: MudBlazor.InputType) = render ==> ("InputType" => x)
    [<CustomOperation("PlaceholderStart")>] member _.PlaceholderStart (render: AttrRenderFragment, x: System.String) = render ==> ("PlaceholderStart" => x)
    [<CustomOperation("PlaceholderEnd")>] member _.PlaceholderEnd (render: AttrRenderFragment, x: System.String) = render ==> ("PlaceholderEnd" => x)
    [<CustomOperation("SeparatorIcon")>] member _.SeparatorIcon (render: AttrRenderFragment, x: System.String) = render ==> ("SeparatorIcon" => x)
                

type MudSelectBuilder<'FunBlazorGeneric, 'T when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudBaseInputBuilder<'FunBlazorGeneric, 'T>()
    static member inline create (x: string) = MudSelectBuilder<'FunBlazorGeneric, 'T>(){ x }
    static member inline create (x: NodeRenderFragment seq) = MudSelectBuilder<'FunBlazorGeneric, 'T>(){ yield! x }
    [<CustomOperation("PopoverClass")>] member _.PopoverClass (render: AttrRenderFragment, x: System.String) = render ==> ("PopoverClass" => x)
    [<CustomOperation("Dense")>] member _.Dense (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Dense" => x)
    [<CustomOperation("OpenIcon")>] member _.OpenIcon (render: AttrRenderFragment, x: System.String) = render ==> ("OpenIcon" => x)
    [<CustomOperation("CloseIcon")>] member _.CloseIcon (render: AttrRenderFragment, x: System.String) = render ==> ("CloseIcon" => x)
    [<CustomOperation("SelectAll")>] member _.SelectAll (render: AttrRenderFragment, x: System.Boolean) = render ==> ("SelectAll" => x)
    [<CustomOperation("SelectAllText")>] member _.SelectAllText (render: AttrRenderFragment, x: System.String) = render ==> ("SelectAllText" => x)
    [<CustomOperation("SelectedValuesChanged")>] member _.SelectedValuesChanged (render: AttrRenderFragment, fn) = render ==> html.callback<System.Collections.Generic.IEnumerable<'T>>("SelectedValuesChanged", fn)
    [<CustomOperation("MultiSelectionTextFunc")>] member _.MultiSelectionTextFunc (render: AttrRenderFragment, fn) = render ==> ("MultiSelectionTextFunc" => (System.Func<System.Collections.Generic.List<System.String>, System.String>fn))
    [<CustomOperation("Delimiter")>] member _.Delimiter (render: AttrRenderFragment, x: System.String) = render ==> ("Delimiter" => x)
    [<CustomOperation("SelectedValues")>] member _.SelectedValues (render: AttrRenderFragment, x: System.Collections.Generic.IEnumerable<'T>) = render ==> ("SelectedValues" => x)
    [<CustomOperation("SelectedValues'")>] member _.SelectedValues' (render: AttrRenderFragment, value: IStore<System.Collections.Generic.IEnumerable<'T>>) = render ==> html.bind("SelectedValues", value)
    [<CustomOperation("SelectedValues'")>] member _.SelectedValues' (render: AttrRenderFragment, value: cval<System.Collections.Generic.IEnumerable<'T>>) = render ==> html.bind("SelectedValues", value)
    [<CustomOperation("SelectedValues'")>] member _.SelectedValues' (render: AttrRenderFragment, valueFn: System.Collections.Generic.IEnumerable<'T> * (System.Collections.Generic.IEnumerable<'T> -> unit)) = render ==> html.bind("SelectedValues", valueFn)
    [<CustomOperation("Comparer")>] member _.Comparer (render: AttrRenderFragment, x: System.Collections.Generic.IEqualityComparer<'T>) = render ==> ("Comparer" => x)
    [<CustomOperation("ToStringFunc")>] member _.ToStringFunc (render: AttrRenderFragment, fn) = render ==> ("ToStringFunc" => (System.Func<'T, System.String>fn))
    [<CustomOperation("MultiSelection")>] member _.MultiSelection (render: AttrRenderFragment, x: System.Boolean) = render ==> ("MultiSelection" => x)
    [<CustomOperation("MaxHeight")>] member _.MaxHeight (render: AttrRenderFragment, x: System.Int32) = render ==> ("MaxHeight" => x)
    [<CustomOperation("AnchorOrigin")>] member _.AnchorOrigin (render: AttrRenderFragment, x: MudBlazor.Origin) = render ==> ("AnchorOrigin" => x)
    [<CustomOperation("TransformOrigin")>] member _.TransformOrigin (render: AttrRenderFragment, x: MudBlazor.Origin) = render ==> ("TransformOrigin" => x)
    [<CustomOperation("Strict")>] member _.Strict (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Strict" => x)
    [<CustomOperation("Clearable")>] member _.Clearable (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Clearable" => x)
    [<CustomOperation("LockScroll")>] member _.LockScroll (render: AttrRenderFragment, x: System.Boolean) = render ==> ("LockScroll" => x)
    [<CustomOperation("OnClearButtonClick")>] member _.OnClearButtonClick (render: AttrRenderFragment, fn) = render ==> html.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>("OnClearButtonClick", fn)
    [<CustomOperation("CheckedIcon")>] member _.CheckedIcon (render: AttrRenderFragment, x: System.String) = render ==> ("CheckedIcon" => x)
    [<CustomOperation("UncheckedIcon")>] member _.UncheckedIcon (render: AttrRenderFragment, x: System.String) = render ==> ("UncheckedIcon" => x)
    [<CustomOperation("IndeterminateIcon")>] member _.IndeterminateIcon (render: AttrRenderFragment, x: System.String) = render ==> ("IndeterminateIcon" => x)
                

type MudBooleanInputBuilder<'FunBlazorGeneric, 'T when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudFormComponentBuilder<'FunBlazorGeneric, 'T, System.Nullable<System.Boolean>>()
    static member inline create () = html.fromBuilder(MudBooleanInputBuilder<'FunBlazorGeneric, 'T>())
    [<CustomOperation("Disabled")>] member _.Disabled (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Disabled" => x)
    [<CustomOperation("ReadOnly")>] member _.ReadOnly (render: AttrRenderFragment, x: System.Boolean) = render ==> ("ReadOnly" => x)
    [<CustomOperation("Checked")>] member _.Checked (render: AttrRenderFragment, x: 'T) = render ==> ("Checked" => x)
    [<CustomOperation("Checked'")>] member _.Checked' (render: AttrRenderFragment, value: IStore<'T>) = render ==> html.bind("Checked", value)
    [<CustomOperation("Checked'")>] member _.Checked' (render: AttrRenderFragment, value: cval<'T>) = render ==> html.bind("Checked", value)
    [<CustomOperation("Checked'")>] member _.Checked' (render: AttrRenderFragment, valueFn: 'T * ('T -> unit)) = render ==> html.bind("Checked", valueFn)
    [<CustomOperation("StopClickPropagation")>] member _.StopClickPropagation (render: AttrRenderFragment, x: System.Boolean) = render ==> ("StopClickPropagation" => x)
    [<CustomOperation("CheckedChanged")>] member _.CheckedChanged (render: AttrRenderFragment, fn) = render ==> html.callback<'T>("CheckedChanged", fn)
                

type MudCheckBoxBuilder<'FunBlazorGeneric, 'T when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudBooleanInputBuilder<'FunBlazorGeneric, 'T>()
    static member inline create (x: string) = MudCheckBoxBuilder<'FunBlazorGeneric, 'T>(){ x }
    static member inline create (x: NodeRenderFragment seq) = MudCheckBoxBuilder<'FunBlazorGeneric, 'T>(){ yield! x }
    [<CustomOperation("Color")>] member _.Color (render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("Color" => x)
    [<CustomOperation("Label")>] member _.Label (render: AttrRenderFragment, x: System.String) = render ==> ("Label" => x)
    [<CustomOperation("DisableRipple")>] member _.DisableRipple (render: AttrRenderFragment, x: System.Boolean) = render ==> ("DisableRipple" => x)
    [<CustomOperation("Dense")>] member _.Dense (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Dense" => x)
    [<CustomOperation("Size")>] member _.Size (render: AttrRenderFragment, x: MudBlazor.Size) = render ==> ("Size" => x)
    [<CustomOperation("CheckedIcon")>] member _.CheckedIcon (render: AttrRenderFragment, x: System.String) = render ==> ("CheckedIcon" => x)
    [<CustomOperation("UncheckedIcon")>] member _.UncheckedIcon (render: AttrRenderFragment, x: System.String) = render ==> ("UncheckedIcon" => x)
    [<CustomOperation("IndeterminateIcon")>] member _.IndeterminateIcon (render: AttrRenderFragment, x: System.String) = render ==> ("IndeterminateIcon" => x)
    [<CustomOperation("TriState")>] member _.TriState (render: AttrRenderFragment, x: System.Boolean) = render ==> ("TriState" => x)
                

type MudSwitchBuilder<'FunBlazorGeneric, 'T when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudBooleanInputBuilder<'FunBlazorGeneric, 'T>()
    static member inline create (x: string) = MudSwitchBuilder<'FunBlazorGeneric, 'T>(){ x }
    static member inline create (x: NodeRenderFragment seq) = MudSwitchBuilder<'FunBlazorGeneric, 'T>(){ yield! x }
    [<CustomOperation("Color")>] member _.Color (render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("Color" => x)
    [<CustomOperation("Label")>] member _.Label (render: AttrRenderFragment, x: System.String) = render ==> ("Label" => x)
    [<CustomOperation("ThumbIcon")>] member _.ThumbIcon (render: AttrRenderFragment, x: System.String) = render ==> ("ThumbIcon" => x)
    [<CustomOperation("ThumbIconColor")>] member _.ThumbIconColor (render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("ThumbIconColor" => x)
    [<CustomOperation("DisableRipple")>] member _.DisableRipple (render: AttrRenderFragment, x: System.Boolean) = render ==> ("DisableRipple" => x)
                

type MudPickerBuilder<'FunBlazorGeneric, 'T when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudFormComponentBuilder<'FunBlazorGeneric, 'T, System.String>()
    static member inline create () = html.fromBuilder(MudPickerBuilder<'FunBlazorGeneric, 'T>())
    [<CustomOperation("AdornmentColor")>] member _.AdornmentColor (render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("AdornmentColor" => x)
    [<CustomOperation("AdornmentIcon")>] member _.AdornmentIcon (render: AttrRenderFragment, x: System.String) = render ==> ("AdornmentIcon" => x)
    [<CustomOperation("Placeholder")>] member _.Placeholder (render: AttrRenderFragment, x: System.String) = render ==> ("Placeholder" => x)
    [<CustomOperation("PickerOpened")>] member _.PickerOpened (render: AttrRenderFragment, fn) = render ==> html.callback<unit>("PickerOpened", fn)
    [<CustomOperation("PickerClosed")>] member _.PickerClosed (render: AttrRenderFragment, fn) = render ==> html.callback<unit>("PickerClosed", fn)
    [<CustomOperation("Elevation")>] member _.Elevation (render: AttrRenderFragment, x: System.Int32) = render ==> ("Elevation" => x)
    [<CustomOperation("Square")>] member _.Square (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Square" => x)
    [<CustomOperation("ReadOnly")>] member _.ReadOnly (render: AttrRenderFragment, x: System.Boolean) = render ==> ("ReadOnly" => x)
    [<CustomOperation("Rounded")>] member _.Rounded (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Rounded" => x)
    [<CustomOperation("HelperText")>] member _.HelperText (render: AttrRenderFragment, x: System.String) = render ==> ("HelperText" => x)
    [<CustomOperation("HelperTextOnFocus")>] member _.HelperTextOnFocus (render: AttrRenderFragment, x: System.Boolean) = render ==> ("HelperTextOnFocus" => x)
    [<CustomOperation("Label")>] member _.Label (render: AttrRenderFragment, x: System.String) = render ==> ("Label" => x)
    [<CustomOperation("Disabled")>] member _.Disabled (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Disabled" => x)
    [<CustomOperation("Editable")>] member _.Editable (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Editable" => x)
    [<CustomOperation("DisableToolbar")>] member _.DisableToolbar (render: AttrRenderFragment, x: System.Boolean) = render ==> ("DisableToolbar" => x)
    [<CustomOperation("ToolBarClass")>] member _.ToolBarClass (render: AttrRenderFragment, x: System.String) = render ==> ("ToolBarClass" => x)
    [<CustomOperation("PickerVariant")>] member _.PickerVariant (render: AttrRenderFragment, x: MudBlazor.PickerVariant) = render ==> ("PickerVariant" => x)
    [<CustomOperation("Variant")>] member _.Variant (render: AttrRenderFragment, x: MudBlazor.Variant) = render ==> ("Variant" => x)
    [<CustomOperation("Adornment")>] member _.Adornment (render: AttrRenderFragment, x: MudBlazor.Adornment) = render ==> ("Adornment" => x)
    [<CustomOperation("Orientation")>] member _.Orientation (render: AttrRenderFragment, x: MudBlazor.Orientation) = render ==> ("Orientation" => x)
    [<CustomOperation("IconSize")>] member _.IconSize (render: AttrRenderFragment, x: MudBlazor.Size) = render ==> ("IconSize" => x)
    [<CustomOperation("Color")>] member _.Color (render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("Color" => x)
    [<CustomOperation("AllowKeyboardInput")>] member _.AllowKeyboardInput (render: AttrRenderFragment, x: System.Boolean) = render ==> ("AllowKeyboardInput" => x)
    [<CustomOperation("TextChanged")>] member _.TextChanged (render: AttrRenderFragment, fn) = render ==> html.callback<System.String>("TextChanged", fn)
    [<CustomOperation("Text")>] member _.Text (render: AttrRenderFragment, x: System.String) = render ==> ("Text" => x)
    [<CustomOperation("Text'")>] member _.Text' (render: AttrRenderFragment, value: IStore<System.String>) = render ==> html.bind("Text", value)
    [<CustomOperation("Text'")>] member _.Text' (render: AttrRenderFragment, value: cval<System.String>) = render ==> html.bind("Text", value)
    [<CustomOperation("Text'")>] member _.Text' (render: AttrRenderFragment, valueFn: System.String * (System.String -> unit)) = render ==> html.bind("Text", valueFn)
    [<CustomOperation("ClassActions")>] member _.ClassActions (render: AttrRenderFragment, x: System.String) = render ==> ("ClassActions" => x)
    [<CustomOperation("PickerActions")>] member _.PickerActions (render: AttrRenderFragment, fragment) = render ==> html.renderFragment("PickerActions", fragment)
    [<CustomOperation("PickerActions")>] member _.PickerActions (render: AttrRenderFragment, fragments) = render ==> html.renderFragment("PickerActions", fragment { yield! fragments })
    [<CustomOperation("PickerActions")>] member _.PickerActions (render: AttrRenderFragment, x: string) = render ==> html.renderFragment("PickerActions", html.text x)
    [<CustomOperation("PickerActions")>] member _.PickerActions (render: AttrRenderFragment, x: int) = render ==> html.renderFragment("PickerActions", html.text x)
    [<CustomOperation("PickerActions")>] member _.PickerActions (render: AttrRenderFragment, x: float) = render ==> html.renderFragment("PickerActions", html.text x)
    [<CustomOperation("Margin")>] member _.Margin (render: AttrRenderFragment, x: MudBlazor.Margin) = render ==> ("Margin" => x)
                

type MudBaseDatePickerBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudPickerBuilder<'FunBlazorGeneric, System.Nullable<System.DateTime>>()
    static member inline create () = html.fromBuilder(MudBaseDatePickerBuilder<'FunBlazorGeneric>())
    [<CustomOperation("MaxDate")>] member _.MaxDate (render: AttrRenderFragment, x: System.Nullable<System.DateTime>) = render ==> ("MaxDate" => x)
    [<CustomOperation("MinDate")>] member _.MinDate (render: AttrRenderFragment, x: System.Nullable<System.DateTime>) = render ==> ("MinDate" => x)
    [<CustomOperation("OpenTo")>] member _.OpenTo (render: AttrRenderFragment, x: MudBlazor.OpenTo) = render ==> ("OpenTo" => x)
    [<CustomOperation("DateFormat")>] member _.DateFormat (render: AttrRenderFragment, x: System.String) = render ==> ("DateFormat" => x)
    [<CustomOperation("FirstDayOfWeek")>] member _.FirstDayOfWeek (render: AttrRenderFragment, x: System.Nullable<System.DayOfWeek>) = render ==> ("FirstDayOfWeek" => x)
    [<CustomOperation("PickerMonth")>] member _.PickerMonth (render: AttrRenderFragment, x: System.Nullable<System.DateTime>) = render ==> ("PickerMonth" => x)
    [<CustomOperation("PickerMonth'")>] member _.PickerMonth' (render: AttrRenderFragment, value: IStore<System.Nullable<System.DateTime>>) = render ==> html.bind("PickerMonth", value)
    [<CustomOperation("PickerMonth'")>] member _.PickerMonth' (render: AttrRenderFragment, value: cval<System.Nullable<System.DateTime>>) = render ==> html.bind("PickerMonth", value)
    [<CustomOperation("PickerMonth'")>] member _.PickerMonth' (render: AttrRenderFragment, valueFn: System.Nullable<System.DateTime> * (System.Nullable<System.DateTime> -> unit)) = render ==> html.bind("PickerMonth", valueFn)
    [<CustomOperation("PickerMonthChanged")>] member _.PickerMonthChanged (render: AttrRenderFragment, fn) = render ==> html.callback<System.Nullable<System.DateTime>>("PickerMonthChanged", fn)
    [<CustomOperation("ClosingDelay")>] member _.ClosingDelay (render: AttrRenderFragment, x: System.Int32) = render ==> ("ClosingDelay" => x)
    [<CustomOperation("DisplayMonths")>] member _.DisplayMonths (render: AttrRenderFragment, x: System.Int32) = render ==> ("DisplayMonths" => x)
    [<CustomOperation("MaxMonthColumns")>] member _.MaxMonthColumns (render: AttrRenderFragment, x: System.Nullable<System.Int32>) = render ==> ("MaxMonthColumns" => x)
    [<CustomOperation("StartMonth")>] member _.StartMonth (render: AttrRenderFragment, x: System.Nullable<System.DateTime>) = render ==> ("StartMonth" => x)
    [<CustomOperation("ShowWeekNumbers")>] member _.ShowWeekNumbers (render: AttrRenderFragment, x: System.Boolean) = render ==> ("ShowWeekNumbers" => x)
    [<CustomOperation("TitleDateFormat")>] member _.TitleDateFormat (render: AttrRenderFragment, x: System.String) = render ==> ("TitleDateFormat" => x)
    [<CustomOperation("IsDateDisabledFunc")>] member _.IsDateDisabledFunc (render: AttrRenderFragment, fn) = render ==> ("IsDateDisabledFunc" => (System.Func<System.DateTime, System.Boolean>fn))
    [<CustomOperation("PreviousIcon")>] member _.PreviousIcon (render: AttrRenderFragment, x: System.String) = render ==> ("PreviousIcon" => x)
    [<CustomOperation("NextIcon")>] member _.NextIcon (render: AttrRenderFragment, x: System.String) = render ==> ("NextIcon" => x)
    [<CustomOperation("FixYear")>] member _.FixYear (render: AttrRenderFragment, x: System.Nullable<System.Int32>) = render ==> ("FixYear" => x)
    [<CustomOperation("FixMonth")>] member _.FixMonth (render: AttrRenderFragment, x: System.Nullable<System.Int32>) = render ==> ("FixMonth" => x)
    [<CustomOperation("FixDay")>] member _.FixDay (render: AttrRenderFragment, x: System.Nullable<System.Int32>) = render ==> ("FixDay" => x)
                

type MudDatePickerBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudBaseDatePickerBuilder<'FunBlazorGeneric>()
    static member inline create () = html.fromBuilder(MudDatePickerBuilder<'FunBlazorGeneric>())
    [<CustomOperation("DateChanged")>] member _.DateChanged (render: AttrRenderFragment, fn) = render ==> html.callback<System.Nullable<System.DateTime>>("DateChanged", fn)
    [<CustomOperation("Date")>] member _.Date (render: AttrRenderFragment, x: System.Nullable<System.DateTime>) = render ==> ("Date" => x)
    [<CustomOperation("Date'")>] member _.Date' (render: AttrRenderFragment, value: IStore<System.Nullable<System.DateTime>>) = render ==> html.bind("Date", value)
    [<CustomOperation("Date'")>] member _.Date' (render: AttrRenderFragment, value: cval<System.Nullable<System.DateTime>>) = render ==> html.bind("Date", value)
    [<CustomOperation("Date'")>] member _.Date' (render: AttrRenderFragment, valueFn: System.Nullable<System.DateTime> * (System.Nullable<System.DateTime> -> unit)) = render ==> html.bind("Date", valueFn)
    [<CustomOperation("AutoClose")>] member _.AutoClose (render: AttrRenderFragment, x: System.Boolean) = render ==> ("AutoClose" => x)
                

type MudDateRangePickerBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudBaseDatePickerBuilder<'FunBlazorGeneric>()
    static member inline create () = html.fromBuilder(MudDateRangePickerBuilder<'FunBlazorGeneric>())
    [<CustomOperation("DateRangeChanged")>] member _.DateRangeChanged (render: AttrRenderFragment, fn) = render ==> html.callback<MudBlazor.DateRange>("DateRangeChanged", fn)
    [<CustomOperation("DateRange")>] member _.DateRange (render: AttrRenderFragment, x: MudBlazor.DateRange) = render ==> ("DateRange" => x)
    [<CustomOperation("DateRange'")>] member _.DateRange' (render: AttrRenderFragment, value: IStore<MudBlazor.DateRange>) = render ==> html.bind("DateRange", value)
    [<CustomOperation("DateRange'")>] member _.DateRange' (render: AttrRenderFragment, value: cval<MudBlazor.DateRange>) = render ==> html.bind("DateRange", value)
    [<CustomOperation("DateRange'")>] member _.DateRange' (render: AttrRenderFragment, valueFn: MudBlazor.DateRange * (MudBlazor.DateRange -> unit)) = render ==> html.bind("DateRange", valueFn)
                

type MudColorPickerBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudPickerBuilder<'FunBlazorGeneric, MudBlazor.Utilities.MudColor>()
    static member inline create () = html.fromBuilder(MudColorPickerBuilder<'FunBlazorGeneric>())
    [<CustomOperation("DisableAlpha")>] member _.DisableAlpha (render: AttrRenderFragment, x: System.Boolean) = render ==> ("DisableAlpha" => x)
    [<CustomOperation("DisableColorField")>] member _.DisableColorField (render: AttrRenderFragment, x: System.Boolean) = render ==> ("DisableColorField" => x)
    [<CustomOperation("DisableModeSwitch")>] member _.DisableModeSwitch (render: AttrRenderFragment, x: System.Boolean) = render ==> ("DisableModeSwitch" => x)
    [<CustomOperation("DisableInputs")>] member _.DisableInputs (render: AttrRenderFragment, x: System.Boolean) = render ==> ("DisableInputs" => x)
    [<CustomOperation("DisableSliders")>] member _.DisableSliders (render: AttrRenderFragment, x: System.Boolean) = render ==> ("DisableSliders" => x)
    [<CustomOperation("DisablePreview")>] member _.DisablePreview (render: AttrRenderFragment, x: System.Boolean) = render ==> ("DisablePreview" => x)
    [<CustomOperation("ColorPickerMode")>] member _.ColorPickerMode (render: AttrRenderFragment, x: MudBlazor.ColorPickerMode) = render ==> ("ColorPickerMode" => x)
    [<CustomOperation("ColorPickerView")>] member _.ColorPickerView (render: AttrRenderFragment, x: MudBlazor.ColorPickerView) = render ==> ("ColorPickerView" => x)
    [<CustomOperation("UpdateBindingIfOnlyHSLChanged")>] member _.UpdateBindingIfOnlyHSLChanged (render: AttrRenderFragment, x: System.Boolean) = render ==> ("UpdateBindingIfOnlyHSLChanged" => x)
    [<CustomOperation("Value")>] member _.Value (render: AttrRenderFragment, x: MudBlazor.Utilities.MudColor) = render ==> ("Value" => x)
    [<CustomOperation("Value'")>] member _.Value' (render: AttrRenderFragment, value: IStore<MudBlazor.Utilities.MudColor>) = render ==> html.bind("Value", value)
    [<CustomOperation("Value'")>] member _.Value' (render: AttrRenderFragment, value: cval<MudBlazor.Utilities.MudColor>) = render ==> html.bind("Value", value)
    [<CustomOperation("Value'")>] member _.Value' (render: AttrRenderFragment, valueFn: MudBlazor.Utilities.MudColor * (MudBlazor.Utilities.MudColor -> unit)) = render ==> html.bind("Value", valueFn)
    [<CustomOperation("ValueChanged")>] member _.ValueChanged (render: AttrRenderFragment, fn) = render ==> html.callback<MudBlazor.Utilities.MudColor>("ValueChanged", fn)
    [<CustomOperation("Palette")>] member _.Palette (render: AttrRenderFragment, x: System.Collections.Generic.IEnumerable<MudBlazor.Utilities.MudColor>) = render ==> ("Palette" => x)
    [<CustomOperation("DisableDragEffect")>] member _.DisableDragEffect (render: AttrRenderFragment, x: System.Boolean) = render ==> ("DisableDragEffect" => x)
    [<CustomOperation("CloseIcon")>] member _.CloseIcon (render: AttrRenderFragment, x: System.String) = render ==> ("CloseIcon" => x)
    [<CustomOperation("SpectrumIcon")>] member _.SpectrumIcon (render: AttrRenderFragment, x: System.String) = render ==> ("SpectrumIcon" => x)
    [<CustomOperation("GridIcon")>] member _.GridIcon (render: AttrRenderFragment, x: System.String) = render ==> ("GridIcon" => x)
    [<CustomOperation("PaletteIcon")>] member _.PaletteIcon (render: AttrRenderFragment, x: System.String) = render ==> ("PaletteIcon" => x)
    [<CustomOperation("ImportExportIcon")>] member _.ImportExportIcon (render: AttrRenderFragment, x: System.String) = render ==> ("ImportExportIcon" => x)
                

type MudTimePickerBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudPickerBuilder<'FunBlazorGeneric, System.Nullable<System.TimeSpan>>()
    static member inline create () = html.fromBuilder(MudTimePickerBuilder<'FunBlazorGeneric>())
    [<CustomOperation("OpenTo")>] member _.OpenTo (render: AttrRenderFragment, x: MudBlazor.OpenTo) = render ==> ("OpenTo" => x)
    [<CustomOperation("TimeEditMode")>] member _.TimeEditMode (render: AttrRenderFragment, x: MudBlazor.TimeEditMode) = render ==> ("TimeEditMode" => x)
    [<CustomOperation("ClosingDelay")>] member _.ClosingDelay (render: AttrRenderFragment, x: System.Int32) = render ==> ("ClosingDelay" => x)
    [<CustomOperation("AutoClose")>] member _.AutoClose (render: AttrRenderFragment, x: System.Boolean) = render ==> ("AutoClose" => x)
    [<CustomOperation("AmPm")>] member _.AmPm (render: AttrRenderFragment, x: System.Boolean) = render ==> ("AmPm" => x)
    [<CustomOperation("TimeFormat")>] member _.TimeFormat (render: AttrRenderFragment, x: System.String) = render ==> ("TimeFormat" => x)
    [<CustomOperation("Time")>] member _.Time (render: AttrRenderFragment, x: System.Nullable<System.TimeSpan>) = render ==> ("Time" => x)
    [<CustomOperation("Time'")>] member _.Time' (render: AttrRenderFragment, value: IStore<System.Nullable<System.TimeSpan>>) = render ==> html.bind("Time", value)
    [<CustomOperation("Time'")>] member _.Time' (render: AttrRenderFragment, value: cval<System.Nullable<System.TimeSpan>>) = render ==> html.bind("Time", value)
    [<CustomOperation("Time'")>] member _.Time' (render: AttrRenderFragment, valueFn: System.Nullable<System.TimeSpan> * (System.Nullable<System.TimeSpan> -> unit)) = render ==> html.bind("Time", valueFn)
    [<CustomOperation("TimeChanged")>] member _.TimeChanged (render: AttrRenderFragment, fn) = render ==> html.callback<System.Nullable<System.TimeSpan>>("TimeChanged", fn)
                

type MudRadioGroupBuilder<'FunBlazorGeneric, 'T when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudFormComponentBuilder<'FunBlazorGeneric, 'T, 'T>()
    static member inline create (x: string) = MudRadioGroupBuilder<'FunBlazorGeneric, 'T>(){ x }
    static member inline create (x: NodeRenderFragment seq) = MudRadioGroupBuilder<'FunBlazorGeneric, 'T>(){ yield! x }
    [<CustomOperation("Name")>] member _.Name (render: AttrRenderFragment, x: System.String) = render ==> ("Name" => x)
    [<CustomOperation("SelectedOption")>] member _.SelectedOption (render: AttrRenderFragment, x: 'T) = render ==> ("SelectedOption" => x)
    [<CustomOperation("SelectedOption'")>] member _.SelectedOption' (render: AttrRenderFragment, value: IStore<'T>) = render ==> html.bind("SelectedOption", value)
    [<CustomOperation("SelectedOption'")>] member _.SelectedOption' (render: AttrRenderFragment, value: cval<'T>) = render ==> html.bind("SelectedOption", value)
    [<CustomOperation("SelectedOption'")>] member _.SelectedOption' (render: AttrRenderFragment, valueFn: 'T * ('T -> unit)) = render ==> html.bind("SelectedOption", valueFn)
    [<CustomOperation("SelectedOptionChanged")>] member _.SelectedOptionChanged (render: AttrRenderFragment, fn) = render ==> html.callback<'T>("SelectedOptionChanged", fn)
                

type MudAlertBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    static member inline create (x: string) = MudAlertBuilder<'FunBlazorGeneric>(){ x }
    static member inline create (x: NodeRenderFragment seq) = MudAlertBuilder<'FunBlazorGeneric>(){ yield! x }
    [<CustomOperation("ContentAlignment")>] member _.ContentAlignment (render: AttrRenderFragment, x: MudBlazor.HorizontalAlignment) = render ==> ("ContentAlignment" => x)
    [<CustomOperation("CloseIconClicked")>] member _.CloseIconClicked (render: AttrRenderFragment, fn) = render ==> html.callback<MudBlazor.MudAlert>("CloseIconClicked", fn)
    [<CustomOperation("CloseIcon")>] member _.CloseIcon (render: AttrRenderFragment, x: System.String) = render ==> ("CloseIcon" => x)
    [<CustomOperation("ShowCloseIcon")>] member _.ShowCloseIcon (render: AttrRenderFragment, x: System.Boolean) = render ==> ("ShowCloseIcon" => x)
    [<CustomOperation("Elevation")>] member _.Elevation (render: AttrRenderFragment, x: System.Int32) = render ==> ("Elevation" => x)
    [<CustomOperation("Square")>] member _.Square (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Square" => x)
    [<CustomOperation("Dense")>] member _.Dense (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Dense" => x)
    [<CustomOperation("NoIcon")>] member _.NoIcon (render: AttrRenderFragment, x: System.Boolean) = render ==> ("NoIcon" => x)
    [<CustomOperation("Severity")>] member _.Severity (render: AttrRenderFragment, x: MudBlazor.Severity) = render ==> ("Severity" => x)
    [<CustomOperation("Variant")>] member _.Variant (render: AttrRenderFragment, x: MudBlazor.Variant) = render ==> ("Variant" => x)
    [<CustomOperation("Icon")>] member _.Icon (render: AttrRenderFragment, x: System.String) = render ==> ("Icon" => x)
    [<CustomOperation("OnClick")>] member _.OnClick (render: AttrRenderFragment, fn) = render ==> html.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>("OnClick", fn)
                

type MudAppBarBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    static member inline create (x: string) = MudAppBarBuilder<'FunBlazorGeneric>(){ x }
    static member inline create (x: NodeRenderFragment seq) = MudAppBarBuilder<'FunBlazorGeneric>(){ yield! x }
    [<CustomOperation("Bottom")>] member _.Bottom (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Bottom" => x)
    [<CustomOperation("Elevation")>] member _.Elevation (render: AttrRenderFragment, x: System.Int32) = render ==> ("Elevation" => x)
    [<CustomOperation("Dense")>] member _.Dense (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Dense" => x)
    [<CustomOperation("DisableGutters")>] member _.DisableGutters (render: AttrRenderFragment, x: System.Boolean) = render ==> ("DisableGutters" => x)
    [<CustomOperation("Color")>] member _.Color (render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("Color" => x)
    [<CustomOperation("Fixed")>] member _.Fixed (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Fixed" => x)
    [<CustomOperation("ToolBarClass")>] member _.ToolBarClass (render: AttrRenderFragment, x: System.String) = render ==> ("ToolBarClass" => x)
                

type MudAvatarBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    static member inline create (x: string) = MudAvatarBuilder<'FunBlazorGeneric>(){ x }
    static member inline create (x: NodeRenderFragment seq) = MudAvatarBuilder<'FunBlazorGeneric>(){ yield! x }
    [<CustomOperation("Elevation")>] member _.Elevation (render: AttrRenderFragment, x: System.Int32) = render ==> ("Elevation" => x)
    [<CustomOperation("Square")>] member _.Square (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Square" => x)
    [<CustomOperation("Rounded")>] member _.Rounded (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Rounded" => x)
    [<CustomOperation("Image")>] member _.Image (render: AttrRenderFragment, x: System.String) = render ==> ("Image" => x)
    [<CustomOperation("Alt")>] member _.Alt (render: AttrRenderFragment, x: System.String) = render ==> ("Alt" => x)
    [<CustomOperation("Color")>] member _.Color (render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("Color" => x)
    [<CustomOperation("Size")>] member _.Size (render: AttrRenderFragment, x: MudBlazor.Size) = render ==> ("Size" => x)
    [<CustomOperation("Variant")>] member _.Variant (render: AttrRenderFragment, x: MudBlazor.Variant) = render ==> ("Variant" => x)
                

type MudAvatarGroupBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    static member inline create (x: string) = MudAvatarGroupBuilder<'FunBlazorGeneric>(){ x }
    static member inline create (x: NodeRenderFragment seq) = MudAvatarGroupBuilder<'FunBlazorGeneric>(){ yield! x }
    [<CustomOperation("Spacing")>] member _.Spacing (render: AttrRenderFragment, x: System.Int32) = render ==> ("Spacing" => x)
    [<CustomOperation("Outlined")>] member _.Outlined (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Outlined" => x)
    [<CustomOperation("OutlineColor")>] member _.OutlineColor (render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("OutlineColor" => x)
    [<CustomOperation("MaxElevation")>] member _.MaxElevation (render: AttrRenderFragment, x: System.Int32) = render ==> ("MaxElevation" => x)
    [<CustomOperation("MaxSquare")>] member _.MaxSquare (render: AttrRenderFragment, x: System.Boolean) = render ==> ("MaxSquare" => x)
    [<CustomOperation("MaxRounded")>] member _.MaxRounded (render: AttrRenderFragment, x: System.Boolean) = render ==> ("MaxRounded" => x)
    [<CustomOperation("MaxColor")>] member _.MaxColor (render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("MaxColor" => x)
    [<CustomOperation("MaxSize")>] member _.MaxSize (render: AttrRenderFragment, x: MudBlazor.Size) = render ==> ("MaxSize" => x)
    [<CustomOperation("MaxVariant")>] member _.MaxVariant (render: AttrRenderFragment, x: MudBlazor.Variant) = render ==> ("MaxVariant" => x)
    [<CustomOperation("Max")>] member _.Max (render: AttrRenderFragment, x: System.Int32) = render ==> ("Max" => x)
    [<CustomOperation("MaxAvatarClass")>] member _.MaxAvatarClass (render: AttrRenderFragment, x: System.String) = render ==> ("MaxAvatarClass" => x)
                

type MudBadgeBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    static member inline create (x: string) = MudBadgeBuilder<'FunBlazorGeneric>(){ x }
    static member inline create (x: NodeRenderFragment seq) = MudBadgeBuilder<'FunBlazorGeneric>(){ yield! x }
    [<CustomOperation("Origin")>] member _.Origin (render: AttrRenderFragment, x: MudBlazor.Origin) = render ==> ("Origin" => x)
    [<CustomOperation("Elevation")>] member _.Elevation (render: AttrRenderFragment, x: System.Int32) = render ==> ("Elevation" => x)
    [<CustomOperation("Visible")>] member _.Visible (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Visible" => x)
    [<CustomOperation("Color")>] member _.Color (render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("Color" => x)
    [<CustomOperation("Dot")>] member _.Dot (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Dot" => x)
    [<CustomOperation("Overlap")>] member _.Overlap (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Overlap" => x)
    [<CustomOperation("Bordered")>] member _.Bordered (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Bordered" => x)
    [<CustomOperation("Icon")>] member _.Icon (render: AttrRenderFragment, x: System.String) = render ==> ("Icon" => x)
    [<CustomOperation("Max")>] member _.Max (render: AttrRenderFragment, x: System.Int32) = render ==> ("Max" => x)
    [<CustomOperation("Content")>] member _.Content (render: AttrRenderFragment, x: System.Object) = render ==> ("Content" => x)
    [<CustomOperation("BadgeClass")>] member _.BadgeClass (render: AttrRenderFragment, x: System.String) = render ==> ("BadgeClass" => x)
    [<CustomOperation("OnClick")>] member _.OnClick (render: AttrRenderFragment, fn) = render ==> html.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>("OnClick", fn)
                

type MudBreadcrumbsBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    static member inline create () = html.fromBuilder(MudBreadcrumbsBuilder<'FunBlazorGeneric>())
    [<CustomOperation("Items")>] member _.Items (render: AttrRenderFragment, x: System.Collections.Generic.List<MudBlazor.BreadcrumbItem>) = render ==> ("Items" => x)
    [<CustomOperation("Separator")>] member _.Separator (render: AttrRenderFragment, x: System.String) = render ==> ("Separator" => x)
    [<CustomOperation("SeparatorTemplate")>] member _.SeparatorTemplate (render: AttrRenderFragment, fragment) = render ==> html.renderFragment("SeparatorTemplate", fragment)
    [<CustomOperation("SeparatorTemplate")>] member _.SeparatorTemplate (render: AttrRenderFragment, fragments) = render ==> html.renderFragment("SeparatorTemplate", fragment { yield! fragments })
    [<CustomOperation("SeparatorTemplate")>] member _.SeparatorTemplate (render: AttrRenderFragment, x: string) = render ==> html.renderFragment("SeparatorTemplate", html.text x)
    [<CustomOperation("SeparatorTemplate")>] member _.SeparatorTemplate (render: AttrRenderFragment, x: int) = render ==> html.renderFragment("SeparatorTemplate", html.text x)
    [<CustomOperation("SeparatorTemplate")>] member _.SeparatorTemplate (render: AttrRenderFragment, x: float) = render ==> html.renderFragment("SeparatorTemplate", html.text x)
    [<CustomOperation("ItemTemplate")>] member _.ItemTemplate (render: AttrRenderFragment, fn: MudBlazor.BreadcrumbItem -> NodeRenderFragment) = render ==> html.renderFragment("ItemTemplate", fn)
    [<CustomOperation("MaxItems")>] member _.MaxItems (render: AttrRenderFragment, x: System.Nullable<System.Byte>) = render ==> ("MaxItems" => x)
    [<CustomOperation("ExpanderIcon")>] member _.ExpanderIcon (render: AttrRenderFragment, x: System.String) = render ==> ("ExpanderIcon" => x)
                

type MudBreakpointProviderBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    static member inline create (x: string) = MudBreakpointProviderBuilder<'FunBlazorGeneric>(){ x }
    static member inline create (x: NodeRenderFragment seq) = MudBreakpointProviderBuilder<'FunBlazorGeneric>(){ yield! x }
    [<CustomOperation("OnBreakpointChanged")>] member _.OnBreakpointChanged (render: AttrRenderFragment, fn) = render ==> html.callback<MudBlazor.Breakpoint>("OnBreakpointChanged", fn)
                

type MudButtonGroupBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    static member inline create (x: string) = MudButtonGroupBuilder<'FunBlazorGeneric>(){ x }
    static member inline create (x: NodeRenderFragment seq) = MudButtonGroupBuilder<'FunBlazorGeneric>(){ yield! x }
    [<CustomOperation("OverrideStyles")>] member _.OverrideStyles (render: AttrRenderFragment, x: System.Boolean) = render ==> ("OverrideStyles" => x)
    [<CustomOperation("VerticalAlign")>] member _.VerticalAlign (render: AttrRenderFragment, x: System.Boolean) = render ==> ("VerticalAlign" => x)
    [<CustomOperation("DisableElevation")>] member _.DisableElevation (render: AttrRenderFragment, x: System.Boolean) = render ==> ("DisableElevation" => x)
    [<CustomOperation("Color")>] member _.Color (render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("Color" => x)
    [<CustomOperation("Size")>] member _.Size (render: AttrRenderFragment, x: MudBlazor.Size) = render ==> ("Size" => x)
    [<CustomOperation("Variant")>] member _.Variant (render: AttrRenderFragment, x: MudBlazor.Variant) = render ==> ("Variant" => x)
                

type MudToggleIconButtonBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    static member inline create () = html.fromBuilder(MudToggleIconButtonBuilder<'FunBlazorGeneric>())
    [<CustomOperation("Toggled")>] member _.Toggled (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Toggled" => x)
    [<CustomOperation("Toggled'")>] member _.Toggled' (render: AttrRenderFragment, value: IStore<System.Boolean>) = render ==> html.bind("Toggled", value)
    [<CustomOperation("Toggled'")>] member _.Toggled' (render: AttrRenderFragment, value: cval<System.Boolean>) = render ==> html.bind("Toggled", value)
    [<CustomOperation("Toggled'")>] member _.Toggled' (render: AttrRenderFragment, valueFn: System.Boolean * (System.Boolean -> unit)) = render ==> html.bind("Toggled", valueFn)
    [<CustomOperation("ToggledChanged")>] member _.ToggledChanged (render: AttrRenderFragment, fn) = render ==> html.callback<System.Boolean>("ToggledChanged", fn)
    [<CustomOperation("Icon")>] member _.Icon (render: AttrRenderFragment, x: System.String) = render ==> ("Icon" => x)
    [<CustomOperation("ToggledIcon")>] member _.ToggledIcon (render: AttrRenderFragment, x: System.String) = render ==> ("ToggledIcon" => x)
    [<CustomOperation("Title")>] member _.Title (render: AttrRenderFragment, x: System.String) = render ==> ("Title" => x)
    [<CustomOperation("ToggledTitle")>] member _.ToggledTitle (render: AttrRenderFragment, x: System.String) = render ==> ("ToggledTitle" => x)
    [<CustomOperation("Color")>] member _.Color (render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("Color" => x)
    [<CustomOperation("ToggledColor")>] member _.ToggledColor (render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("ToggledColor" => x)
    [<CustomOperation("Size")>] member _.Size (render: AttrRenderFragment, x: MudBlazor.Size) = render ==> ("Size" => x)
    [<CustomOperation("ToggledSize")>] member _.ToggledSize (render: AttrRenderFragment, x: MudBlazor.Size) = render ==> ("ToggledSize" => x)
    [<CustomOperation("Edge")>] member _.Edge (render: AttrRenderFragment, x: MudBlazor.Edge) = render ==> ("Edge" => x)
    [<CustomOperation("DisableRipple")>] member _.DisableRipple (render: AttrRenderFragment, x: System.Boolean) = render ==> ("DisableRipple" => x)
    [<CustomOperation("Disabled")>] member _.Disabled (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Disabled" => x)
    [<CustomOperation("Variant")>] member _.Variant (render: AttrRenderFragment, x: MudBlazor.Variant) = render ==> ("Variant" => x)
                

type MudCardBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    static member inline create (x: string) = MudCardBuilder<'FunBlazorGeneric>(){ x }
    static member inline create (x: NodeRenderFragment seq) = MudCardBuilder<'FunBlazorGeneric>(){ yield! x }
    [<CustomOperation("Elevation")>] member _.Elevation (render: AttrRenderFragment, x: System.Int32) = render ==> ("Elevation" => x)
    [<CustomOperation("Square")>] member _.Square (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Square" => x)
    [<CustomOperation("Outlined")>] member _.Outlined (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Outlined" => x)
                

type MudCardActionsBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    static member inline create (x: string) = MudCardActionsBuilder<'FunBlazorGeneric>(){ x }
    static member inline create (x: NodeRenderFragment seq) = MudCardActionsBuilder<'FunBlazorGeneric>(){ yield! x }

                

type MudCardContentBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    static member inline create (x: string) = MudCardContentBuilder<'FunBlazorGeneric>(){ x }
    static member inline create (x: NodeRenderFragment seq) = MudCardContentBuilder<'FunBlazorGeneric>(){ yield! x }

                

type MudCardHeaderBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    static member inline create (x: string) = MudCardHeaderBuilder<'FunBlazorGeneric>(){ x }
    static member inline create (x: NodeRenderFragment seq) = MudCardHeaderBuilder<'FunBlazorGeneric>(){ yield! x }
    [<CustomOperation("CardHeaderAvatar")>] member _.CardHeaderAvatar (render: AttrRenderFragment, fragment) = render ==> html.renderFragment("CardHeaderAvatar", fragment)
    [<CustomOperation("CardHeaderAvatar")>] member _.CardHeaderAvatar (render: AttrRenderFragment, fragments) = render ==> html.renderFragment("CardHeaderAvatar", fragment { yield! fragments })
    [<CustomOperation("CardHeaderAvatar")>] member _.CardHeaderAvatar (render: AttrRenderFragment, x: string) = render ==> html.renderFragment("CardHeaderAvatar", html.text x)
    [<CustomOperation("CardHeaderAvatar")>] member _.CardHeaderAvatar (render: AttrRenderFragment, x: int) = render ==> html.renderFragment("CardHeaderAvatar", html.text x)
    [<CustomOperation("CardHeaderAvatar")>] member _.CardHeaderAvatar (render: AttrRenderFragment, x: float) = render ==> html.renderFragment("CardHeaderAvatar", html.text x)
    [<CustomOperation("CardHeaderContent")>] member _.CardHeaderContent (render: AttrRenderFragment, fragment) = render ==> html.renderFragment("CardHeaderContent", fragment)
    [<CustomOperation("CardHeaderContent")>] member _.CardHeaderContent (render: AttrRenderFragment, fragments) = render ==> html.renderFragment("CardHeaderContent", fragment { yield! fragments })
    [<CustomOperation("CardHeaderContent")>] member _.CardHeaderContent (render: AttrRenderFragment, x: string) = render ==> html.renderFragment("CardHeaderContent", html.text x)
    [<CustomOperation("CardHeaderContent")>] member _.CardHeaderContent (render: AttrRenderFragment, x: int) = render ==> html.renderFragment("CardHeaderContent", html.text x)
    [<CustomOperation("CardHeaderContent")>] member _.CardHeaderContent (render: AttrRenderFragment, x: float) = render ==> html.renderFragment("CardHeaderContent", html.text x)
    [<CustomOperation("CardHeaderActions")>] member _.CardHeaderActions (render: AttrRenderFragment, fragment) = render ==> html.renderFragment("CardHeaderActions", fragment)
    [<CustomOperation("CardHeaderActions")>] member _.CardHeaderActions (render: AttrRenderFragment, fragments) = render ==> html.renderFragment("CardHeaderActions", fragment { yield! fragments })
    [<CustomOperation("CardHeaderActions")>] member _.CardHeaderActions (render: AttrRenderFragment, x: string) = render ==> html.renderFragment("CardHeaderActions", html.text x)
    [<CustomOperation("CardHeaderActions")>] member _.CardHeaderActions (render: AttrRenderFragment, x: int) = render ==> html.renderFragment("CardHeaderActions", html.text x)
    [<CustomOperation("CardHeaderActions")>] member _.CardHeaderActions (render: AttrRenderFragment, x: float) = render ==> html.renderFragment("CardHeaderActions", html.text x)
                

type MudCardMediaBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    static member inline create () = html.fromBuilder(MudCardMediaBuilder<'FunBlazorGeneric>())
    [<CustomOperation("Title")>] member _.Title (render: AttrRenderFragment, x: System.String) = render ==> ("Title" => x)
    [<CustomOperation("Image")>] member _.Image (render: AttrRenderFragment, x: System.String) = render ==> ("Image" => x)
    [<CustomOperation("Height")>] member _.Height (render: AttrRenderFragment, x: System.Int32) = render ==> ("Height" => x)
                

type MudCarouselItemBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    static member inline create (x: string) = MudCarouselItemBuilder<'FunBlazorGeneric>(){ x }
    static member inline create (x: NodeRenderFragment seq) = MudCarouselItemBuilder<'FunBlazorGeneric>(){ yield! x }
    [<CustomOperation("Color")>] member _.Color (render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("Color" => x)
    [<CustomOperation("Transition")>] member _.Transition (render: AttrRenderFragment, x: MudBlazor.Transition) = render ==> ("Transition" => x)
    [<CustomOperation("CustomTransitionEnter")>] member _.CustomTransitionEnter (render: AttrRenderFragment, x: System.String) = render ==> ("CustomTransitionEnter" => x)
    [<CustomOperation("CustomTransitionExit")>] member _.CustomTransitionExit (render: AttrRenderFragment, x: System.String) = render ==> ("CustomTransitionExit" => x)
                

type MudChipSetBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    static member inline create (x: string) = MudChipSetBuilder<'FunBlazorGeneric>(){ x }
    static member inline create (x: NodeRenderFragment seq) = MudChipSetBuilder<'FunBlazorGeneric>(){ yield! x }
    [<CustomOperation("MultiSelection")>] member _.MultiSelection (render: AttrRenderFragment, x: System.Boolean) = render ==> ("MultiSelection" => x)
    [<CustomOperation("Mandatory")>] member _.Mandatory (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Mandatory" => x)
    [<CustomOperation("AllClosable")>] member _.AllClosable (render: AttrRenderFragment, x: System.Boolean) = render ==> ("AllClosable" => x)
    [<CustomOperation("Filter")>] member _.Filter (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Filter" => x)
    [<CustomOperation("ReadOnly")>] member _.ReadOnly (render: AttrRenderFragment, x: System.Boolean) = render ==> ("ReadOnly" => x)
    [<CustomOperation("SelectedChip")>] member _.SelectedChip (render: AttrRenderFragment, x: MudBlazor.MudChip) = render ==> ("SelectedChip" => x)
    [<CustomOperation("SelectedChip'")>] member _.SelectedChip' (render: AttrRenderFragment, value: IStore<MudBlazor.MudChip>) = render ==> html.bind("SelectedChip", value)
    [<CustomOperation("SelectedChip'")>] member _.SelectedChip' (render: AttrRenderFragment, value: cval<MudBlazor.MudChip>) = render ==> html.bind("SelectedChip", value)
    [<CustomOperation("SelectedChip'")>] member _.SelectedChip' (render: AttrRenderFragment, valueFn: MudBlazor.MudChip * (MudBlazor.MudChip -> unit)) = render ==> html.bind("SelectedChip", valueFn)
    [<CustomOperation("SelectedChipChanged")>] member _.SelectedChipChanged (render: AttrRenderFragment, fn) = render ==> html.callback<MudBlazor.MudChip>("SelectedChipChanged", fn)
    [<CustomOperation("SelectedChips")>] member _.SelectedChips (render: AttrRenderFragment, x: MudBlazor.MudChip[]) = render ==> ("SelectedChips" => x)
    [<CustomOperation("SelectedChips'")>] member _.SelectedChips' (render: AttrRenderFragment, value: IStore<MudBlazor.MudChip[]>) = render ==> html.bind("SelectedChips", value)
    [<CustomOperation("SelectedChips'")>] member _.SelectedChips' (render: AttrRenderFragment, value: cval<MudBlazor.MudChip[]>) = render ==> html.bind("SelectedChips", value)
    [<CustomOperation("SelectedChips'")>] member _.SelectedChips' (render: AttrRenderFragment, valueFn: MudBlazor.MudChip[] * (MudBlazor.MudChip[] -> unit)) = render ==> html.bind("SelectedChips", valueFn)
    [<CustomOperation("Comparer")>] member _.Comparer (render: AttrRenderFragment, x: System.Collections.Generic.IEqualityComparer<System.Object>) = render ==> ("Comparer" => x)
    [<CustomOperation("SelectedChipsChanged")>] member _.SelectedChipsChanged (render: AttrRenderFragment, fn) = render ==> html.callback<MudBlazor.MudChip[]>("SelectedChipsChanged", fn)
    [<CustomOperation("SelectedValues")>] member _.SelectedValues (render: AttrRenderFragment, x: System.Collections.Generic.ICollection<System.Object>) = render ==> ("SelectedValues" => x)
    [<CustomOperation("SelectedValues'")>] member _.SelectedValues' (render: AttrRenderFragment, value: IStore<System.Collections.Generic.ICollection<System.Object>>) = render ==> html.bind("SelectedValues", value)
    [<CustomOperation("SelectedValues'")>] member _.SelectedValues' (render: AttrRenderFragment, value: cval<System.Collections.Generic.ICollection<System.Object>>) = render ==> html.bind("SelectedValues", value)
    [<CustomOperation("SelectedValues'")>] member _.SelectedValues' (render: AttrRenderFragment, valueFn: System.Collections.Generic.ICollection<System.Object> * (System.Collections.Generic.ICollection<System.Object> -> unit)) = render ==> html.bind("SelectedValues", valueFn)
    [<CustomOperation("SelectedValuesChanged")>] member _.SelectedValuesChanged (render: AttrRenderFragment, fn) = render ==> html.callback<System.Collections.Generic.ICollection<System.Object>>("SelectedValuesChanged", fn)
    [<CustomOperation("OnClose")>] member _.OnClose (render: AttrRenderFragment, fn) = render ==> html.callback<MudBlazor.MudChip>("OnClose", fn)
                

type MudChipBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    static member inline create (x: string) = MudChipBuilder<'FunBlazorGeneric>(){ x }
    static member inline create (x: NodeRenderFragment seq) = MudChipBuilder<'FunBlazorGeneric>(){ yield! x }
    [<CustomOperation("Color")>] member _.Color (render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("Color" => x)
    [<CustomOperation("Size")>] member _.Size (render: AttrRenderFragment, x: MudBlazor.Size) = render ==> ("Size" => x)
    [<CustomOperation("Variant")>] member _.Variant (render: AttrRenderFragment, x: MudBlazor.Variant) = render ==> ("Variant" => x)
    [<CustomOperation("SelectedColor")>] member _.SelectedColor (render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("SelectedColor" => x)
    [<CustomOperation("Avatar")>] member _.Avatar (render: AttrRenderFragment, x: System.String) = render ==> ("Avatar" => x)
    [<CustomOperation("AvatarClass")>] member _.AvatarClass (render: AttrRenderFragment, x: System.String) = render ==> ("AvatarClass" => x)
    [<CustomOperation("Label")>] member _.Label (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Label" => x)
    [<CustomOperation("Disabled")>] member _.Disabled (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Disabled" => x)
    [<CustomOperation("Icon")>] member _.Icon (render: AttrRenderFragment, x: System.String) = render ==> ("Icon" => x)
    [<CustomOperation("CheckedIcon")>] member _.CheckedIcon (render: AttrRenderFragment, x: System.String) = render ==> ("CheckedIcon" => x)
    [<CustomOperation("IconColor")>] member _.IconColor (render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("IconColor" => x)
    [<CustomOperation("CloseIcon")>] member _.CloseIcon (render: AttrRenderFragment, x: System.String) = render ==> ("CloseIcon" => x)
    [<CustomOperation("DisableRipple")>] member _.DisableRipple (render: AttrRenderFragment, x: System.Boolean) = render ==> ("DisableRipple" => x)
    [<CustomOperation("Link")>] member _.Link (render: AttrRenderFragment, x: System.String) = render ==> ("Link" => x)
    [<CustomOperation("Target")>] member _.Target (render: AttrRenderFragment, x: System.String) = render ==> ("Target" => x)
    [<CustomOperation("Text")>] member _.Text (render: AttrRenderFragment, x: System.String) = render ==> ("Text" => x)
    [<CustomOperation("Value")>] member _.Value (render: AttrRenderFragment, x: System.Object) = render ==> ("Value" => x)
    [<CustomOperation("ForceLoad")>] member _.ForceLoad (render: AttrRenderFragment, x: System.Boolean) = render ==> ("ForceLoad" => x)
    [<CustomOperation("Default")>] member _.Default (render: AttrRenderFragment, x: System.Nullable<System.Boolean>) = render ==> ("Default" => x)
    [<CustomOperation("Command")>] member _.Command (render: AttrRenderFragment, x: System.Windows.Input.ICommand) = render ==> ("Command" => x)
    [<CustomOperation("CommandParameter")>] member _.CommandParameter (render: AttrRenderFragment, x: System.Object) = render ==> ("CommandParameter" => x)
    [<CustomOperation("OnClick")>] member _.OnClick (render: AttrRenderFragment, fn) = render ==> html.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>("OnClick", fn)
    [<CustomOperation("OnClose")>] member _.OnClose (render: AttrRenderFragment, fn) = render ==> html.callback<MudBlazor.MudChip>("OnClose", fn)
                

type MudCollapseBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    static member inline create (x: string) = MudCollapseBuilder<'FunBlazorGeneric>(){ x }
    static member inline create (x: NodeRenderFragment seq) = MudCollapseBuilder<'FunBlazorGeneric>(){ yield! x }
    [<CustomOperation("Expanded")>] member _.Expanded (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Expanded" => x)
    [<CustomOperation("Expanded'")>] member _.Expanded' (render: AttrRenderFragment, value: IStore<System.Boolean>) = render ==> html.bind("Expanded", value)
    [<CustomOperation("Expanded'")>] member _.Expanded' (render: AttrRenderFragment, value: cval<System.Boolean>) = render ==> html.bind("Expanded", value)
    [<CustomOperation("Expanded'")>] member _.Expanded' (render: AttrRenderFragment, valueFn: System.Boolean * (System.Boolean -> unit)) = render ==> html.bind("Expanded", valueFn)
    [<CustomOperation("MaxHeight")>] member _.MaxHeight (render: AttrRenderFragment, x: System.Nullable<System.Int32>) = render ==> ("MaxHeight" => x)
    [<CustomOperation("OnAnimationEnd")>] member _.OnAnimationEnd (render: AttrRenderFragment, fn) = render ==> html.callback<unit>("OnAnimationEnd", fn)
    [<CustomOperation("ExpandedChanged")>] member _.ExpandedChanged (render: AttrRenderFragment, fn) = render ==> html.callback<System.Boolean>("ExpandedChanged", fn)
                

type CellBuilder<'FunBlazorGeneric, 'T when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    static member inline create () = html.fromBuilder(CellBuilder<'FunBlazorGeneric, 'T>())
    [<CustomOperation("Item")>] member _.Item (render: AttrRenderFragment, x: 'T) = render ==> ("Item" => x)
    [<CustomOperation("Title")>] member _.Title (render: AttrRenderFragment, x: System.String) = render ==> ("Title" => x)
    [<CustomOperation("Field")>] member _.Field (render: AttrRenderFragment, x: System.String) = render ==> ("Field" => x)
    [<CustomOperation("CellTemplate")>] member _.CellTemplate (render: AttrRenderFragment, fn: 'T -> NodeRenderFragment) = render ==> html.renderFragment("CellTemplate", fn)
    [<CustomOperation("EditTemplate")>] member _.EditTemplate (render: AttrRenderFragment, fn: 'T -> NodeRenderFragment) = render ==> html.renderFragment("EditTemplate", fn)
    [<CustomOperation("ColumnType")>] member _.ColumnType (render: AttrRenderFragment, x: MudBlazor.ColumnType) = render ==> ("ColumnType" => x)
    [<CustomOperation("IsEditable")>] member _.IsEditable (render: AttrRenderFragment, x: System.Boolean) = render ==> ("IsEditable" => x)
    [<CustomOperation("CellClass")>] member _.CellClass (render: AttrRenderFragment, x: System.String) = render ==> ("CellClass" => x)
    [<CustomOperation("CellStyle")>] member _.CellStyle (render: AttrRenderFragment, x: System.String) = render ==> ("CellStyle" => x)
    [<CustomOperation("CellClassFunc")>] member _.CellClassFunc (render: AttrRenderFragment, fn) = render ==> ("CellClassFunc" => (System.Func<'T, System.String>fn))
    [<CustomOperation("CellStyleFunc")>] member _.CellStyleFunc (render: AttrRenderFragment, fn) = render ==> ("CellStyleFunc" => (System.Func<'T, System.String>fn))
                

type ColumnBuilder<'FunBlazorGeneric, 'T when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    static member inline create (x: string) = ColumnBuilder<'FunBlazorGeneric, 'T>(){ x }
    static member inline create (x: NodeRenderFragment seq) = ColumnBuilder<'FunBlazorGeneric, 'T>(){ yield! x }
    [<CustomOperation("Value")>] member _.Value (render: AttrRenderFragment, x: 'T) = render ==> ("Value" => x)
    [<CustomOperation("Value'")>] member _.Value' (render: AttrRenderFragment, value: IStore<'T>) = render ==> html.bind("Value", value)
    [<CustomOperation("Value'")>] member _.Value' (render: AttrRenderFragment, value: cval<'T>) = render ==> html.bind("Value", value)
    [<CustomOperation("Value'")>] member _.Value' (render: AttrRenderFragment, valueFn: 'T * ('T -> unit)) = render ==> html.bind("Value", valueFn)
    [<CustomOperation("ValueChanged")>] member _.ValueChanged (render: AttrRenderFragment, fn) = render ==> html.callback<'T>("ValueChanged", fn)
    [<CustomOperation("Visible")>] member _.Visible (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Visible" => x)
    [<CustomOperation("Field")>] member _.Field (render: AttrRenderFragment, x: System.String) = render ==> ("Field" => x)
    [<CustomOperation("Title")>] member _.Title (render: AttrRenderFragment, x: System.String) = render ==> ("Title" => x)
    [<CustomOperation("HideSmall")>] member _.HideSmall (render: AttrRenderFragment, x: System.Boolean) = render ==> ("HideSmall" => x)
    [<CustomOperation("FooterColSpan")>] member _.FooterColSpan (render: AttrRenderFragment, x: System.Int32) = render ==> ("FooterColSpan" => x)
    [<CustomOperation("HeaderColSpan")>] member _.HeaderColSpan (render: AttrRenderFragment, x: System.Int32) = render ==> ("HeaderColSpan" => x)
    [<CustomOperation("Type")>] member _.Type (render: AttrRenderFragment, x: MudBlazor.ColumnType) = render ==> ("Type" => x)
    [<CustomOperation("HeaderTemplate")>] member _.HeaderTemplate (render: AttrRenderFragment, fragment) = render ==> html.renderFragment("HeaderTemplate", fragment)
    [<CustomOperation("HeaderTemplate")>] member _.HeaderTemplate (render: AttrRenderFragment, fragments) = render ==> html.renderFragment("HeaderTemplate", fragment { yield! fragments })
    [<CustomOperation("HeaderTemplate")>] member _.HeaderTemplate (render: AttrRenderFragment, x: string) = render ==> html.renderFragment("HeaderTemplate", html.text x)
    [<CustomOperation("HeaderTemplate")>] member _.HeaderTemplate (render: AttrRenderFragment, x: int) = render ==> html.renderFragment("HeaderTemplate", html.text x)
    [<CustomOperation("HeaderTemplate")>] member _.HeaderTemplate (render: AttrRenderFragment, x: float) = render ==> html.renderFragment("HeaderTemplate", html.text x)
    [<CustomOperation("CellTemplate")>] member _.CellTemplate (render: AttrRenderFragment, fn: 'T -> NodeRenderFragment) = render ==> html.renderFragment("CellTemplate", fn)
    [<CustomOperation("FooterTemplate")>] member _.FooterTemplate (render: AttrRenderFragment, fragment) = render ==> html.renderFragment("FooterTemplate", fragment)
    [<CustomOperation("FooterTemplate")>] member _.FooterTemplate (render: AttrRenderFragment, fragments) = render ==> html.renderFragment("FooterTemplate", fragment { yield! fragments })
    [<CustomOperation("FooterTemplate")>] member _.FooterTemplate (render: AttrRenderFragment, x: string) = render ==> html.renderFragment("FooterTemplate", html.text x)
    [<CustomOperation("FooterTemplate")>] member _.FooterTemplate (render: AttrRenderFragment, x: int) = render ==> html.renderFragment("FooterTemplate", html.text x)
    [<CustomOperation("FooterTemplate")>] member _.FooterTemplate (render: AttrRenderFragment, x: float) = render ==> html.renderFragment("FooterTemplate", html.text x)
    [<CustomOperation("HeaderClass")>] member _.HeaderClass (render: AttrRenderFragment, x: System.String) = render ==> ("HeaderClass" => x)
    [<CustomOperation("HeaderClassFunc")>] member _.HeaderClassFunc (render: AttrRenderFragment, fn) = render ==> ("HeaderClassFunc" => (System.Func<'T, System.String>fn))
    [<CustomOperation("HeaderStyle")>] member _.HeaderStyle (render: AttrRenderFragment, x: System.String) = render ==> ("HeaderStyle" => x)
    [<CustomOperation("HeaderStyleFunc")>] member _.HeaderStyleFunc (render: AttrRenderFragment, fn) = render ==> ("HeaderStyleFunc" => (System.Func<'T, System.String>fn))
    [<CustomOperation("Sortable")>] member _.Sortable (render: AttrRenderFragment, x: System.Nullable<System.Boolean>) = render ==> ("Sortable" => x)
    [<CustomOperation("Filterable")>] member _.Filterable (render: AttrRenderFragment, x: System.Nullable<System.Boolean>) = render ==> ("Filterable" => x)
    [<CustomOperation("ShowColumnOptions")>] member _.ShowColumnOptions (render: AttrRenderFragment, x: System.Nullable<System.Boolean>) = render ==> ("ShowColumnOptions" => x)
    [<CustomOperation("SortBy")>] member _.SortBy (render: AttrRenderFragment, fn) = render ==> ("SortBy" => (System.Func<'T, System.Object>fn))
    [<CustomOperation("InitialDirection")>] member _.InitialDirection (render: AttrRenderFragment, x: MudBlazor.SortDirection) = render ==> ("InitialDirection" => x)
    [<CustomOperation("SortIcon")>] member _.SortIcon (render: AttrRenderFragment, x: System.String) = render ==> ("SortIcon" => x)
    [<CustomOperation("CellClass")>] member _.CellClass (render: AttrRenderFragment, x: System.String) = render ==> ("CellClass" => x)
    [<CustomOperation("CellClassFunc")>] member _.CellClassFunc (render: AttrRenderFragment, fn) = render ==> ("CellClassFunc" => (System.Func<'T, System.String>fn))
    [<CustomOperation("CellStyle")>] member _.CellStyle (render: AttrRenderFragment, x: System.String) = render ==> ("CellStyle" => x)
    [<CustomOperation("CellStyleFunc")>] member _.CellStyleFunc (render: AttrRenderFragment, fn) = render ==> ("CellStyleFunc" => (System.Func<'T, System.String>fn))
    [<CustomOperation("IsEditable")>] member _.IsEditable (render: AttrRenderFragment, x: System.Nullable<System.Boolean>) = render ==> ("IsEditable" => x)
    [<CustomOperation("EditTemplate")>] member _.EditTemplate (render: AttrRenderFragment, fn: 'T -> NodeRenderFragment) = render ==> html.renderFragment("EditTemplate", fn)
    [<CustomOperation("FooterClass")>] member _.FooterClass (render: AttrRenderFragment, x: System.String) = render ==> ("FooterClass" => x)
    [<CustomOperation("FooterClassFunc")>] member _.FooterClassFunc (render: AttrRenderFragment, fn) = render ==> ("FooterClassFunc" => (System.Func<'T, System.String>fn))
    [<CustomOperation("FooterStyle")>] member _.FooterStyle (render: AttrRenderFragment, x: System.String) = render ==> ("FooterStyle" => x)
    [<CustomOperation("FooterStyleFunc")>] member _.FooterStyleFunc (render: AttrRenderFragment, fn) = render ==> ("FooterStyleFunc" => (System.Func<'T, System.String>fn))
    [<CustomOperation("EnableFooterSelection")>] member _.EnableFooterSelection (render: AttrRenderFragment, x: System.Boolean) = render ==> ("EnableFooterSelection" => x)
                

type FooterCellBuilder<'FunBlazorGeneric, 'T when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    static member inline create (x: string) = FooterCellBuilder<'FunBlazorGeneric, 'T>(){ x }
    static member inline create (x: NodeRenderFragment seq) = FooterCellBuilder<'FunBlazorGeneric, 'T>(){ yield! x }
    [<CustomOperation("ColSpan")>] member _.ColSpan (render: AttrRenderFragment, x: System.Int32) = render ==> ("ColSpan" => x)
    [<CustomOperation("ColumnType")>] member _.ColumnType (render: AttrRenderFragment, x: MudBlazor.ColumnType) = render ==> ("ColumnType" => x)
    [<CustomOperation("FooterTemplate")>] member _.FooterTemplate (render: AttrRenderFragment, fragment) = render ==> html.renderFragment("FooterTemplate", fragment)
    [<CustomOperation("FooterTemplate")>] member _.FooterTemplate (render: AttrRenderFragment, fragments) = render ==> html.renderFragment("FooterTemplate", fragment { yield! fragments })
    [<CustomOperation("FooterTemplate")>] member _.FooterTemplate (render: AttrRenderFragment, x: string) = render ==> html.renderFragment("FooterTemplate", html.text x)
    [<CustomOperation("FooterTemplate")>] member _.FooterTemplate (render: AttrRenderFragment, x: int) = render ==> html.renderFragment("FooterTemplate", html.text x)
    [<CustomOperation("FooterTemplate")>] member _.FooterTemplate (render: AttrRenderFragment, x: float) = render ==> html.renderFragment("FooterTemplate", html.text x)
    [<CustomOperation("FooterClass")>] member _.FooterClass (render: AttrRenderFragment, x: System.String) = render ==> ("FooterClass" => x)
    [<CustomOperation("FooterStyle")>] member _.FooterStyle (render: AttrRenderFragment, x: System.String) = render ==> ("FooterStyle" => x)
                

type HeaderCellBuilder<'FunBlazorGeneric, 'T when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    static member inline create (x: string) = HeaderCellBuilder<'FunBlazorGeneric, 'T>(){ x }
    static member inline create (x: NodeRenderFragment seq) = HeaderCellBuilder<'FunBlazorGeneric, 'T>(){ yield! x }
    [<CustomOperation("Title")>] member _.Title (render: AttrRenderFragment, x: System.String) = render ==> ("Title" => x)
    [<CustomOperation("Field")>] member _.Field (render: AttrRenderFragment, x: System.String) = render ==> ("Field" => x)
    [<CustomOperation("HeaderTemplate")>] member _.HeaderTemplate (render: AttrRenderFragment, fragment) = render ==> html.renderFragment("HeaderTemplate", fragment)
    [<CustomOperation("HeaderTemplate")>] member _.HeaderTemplate (render: AttrRenderFragment, fragments) = render ==> html.renderFragment("HeaderTemplate", fragment { yield! fragments })
    [<CustomOperation("HeaderTemplate")>] member _.HeaderTemplate (render: AttrRenderFragment, x: string) = render ==> html.renderFragment("HeaderTemplate", html.text x)
    [<CustomOperation("HeaderTemplate")>] member _.HeaderTemplate (render: AttrRenderFragment, x: int) = render ==> html.renderFragment("HeaderTemplate", html.text x)
    [<CustomOperation("HeaderTemplate")>] member _.HeaderTemplate (render: AttrRenderFragment, x: float) = render ==> html.renderFragment("HeaderTemplate", html.text x)
    [<CustomOperation("ColSpan")>] member _.ColSpan (render: AttrRenderFragment, x: System.Int32) = render ==> ("ColSpan" => x)
    [<CustomOperation("ColumnType")>] member _.ColumnType (render: AttrRenderFragment, x: MudBlazor.ColumnType) = render ==> ("ColumnType" => x)
    [<CustomOperation("SortBy")>] member _.SortBy (render: AttrRenderFragment, fn) = render ==> ("SortBy" => (System.Func<'T, System.Object>fn))
    [<CustomOperation("SortIcon")>] member _.SortIcon (render: AttrRenderFragment, x: System.String) = render ==> ("SortIcon" => x)
    [<CustomOperation("InitialDirection")>] member _.InitialDirection (render: AttrRenderFragment, x: MudBlazor.SortDirection) = render ==> ("InitialDirection" => x)
    [<CustomOperation("Sortable")>] member _.Sortable (render: AttrRenderFragment, x: System.Nullable<System.Boolean>) = render ==> ("Sortable" => x)
    [<CustomOperation("Filterable")>] member _.Filterable (render: AttrRenderFragment, x: System.Nullable<System.Boolean>) = render ==> ("Filterable" => x)
    [<CustomOperation("ShowColumnOptions")>] member _.ShowColumnOptions (render: AttrRenderFragment, x: System.Nullable<System.Boolean>) = render ==> ("ShowColumnOptions" => x)
    [<CustomOperation("HeaderClass")>] member _.HeaderClass (render: AttrRenderFragment, x: System.String) = render ==> ("HeaderClass" => x)
    [<CustomOperation("HeaderStyle")>] member _.HeaderStyle (render: AttrRenderFragment, x: System.String) = render ==> ("HeaderStyle" => x)
                

type MudDataGridBuilder<'FunBlazorGeneric, 'T when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    static member inline create () = html.fromBuilder(MudDataGridBuilder<'FunBlazorGeneric, 'T>())
    [<CustomOperation("SelectedItemChanged")>] member _.SelectedItemChanged (render: AttrRenderFragment, fn) = render ==> html.callback<'T>("SelectedItemChanged", fn)
    [<CustomOperation("SelectedItemsChanged")>] member _.SelectedItemsChanged (render: AttrRenderFragment, fn) = render ==> html.callback<System.Collections.Generic.HashSet<'T>>("SelectedItemsChanged", fn)
    [<CustomOperation("RowClick")>] member _.RowClick (render: AttrRenderFragment, fn) = render ==> html.callback<MudBlazor.DataGridRowClickEventArgs<'T>>("RowClick", fn)
    [<CustomOperation("StartedEditingItem")>] member _.StartedEditingItem (render: AttrRenderFragment, fn) = render ==> html.callback<'T>("StartedEditingItem", fn)
    [<CustomOperation("EditingItemCancelled")>] member _.EditingItemCancelled (render: AttrRenderFragment, fn) = render ==> html.callback<'T>("EditingItemCancelled", fn)
    [<CustomOperation("StartedCommittingItemChanges")>] member _.StartedCommittingItemChanges (render: AttrRenderFragment, fn) = render ==> html.callback<'T>("StartedCommittingItemChanges", fn)
    [<CustomOperation("Sortable")>] member _.Sortable (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Sortable" => x)
    [<CustomOperation("Filterable")>] member _.Filterable (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Filterable" => x)
    [<CustomOperation("ShowColumnOptions")>] member _.ShowColumnOptions (render: AttrRenderFragment, x: System.Boolean) = render ==> ("ShowColumnOptions" => x)
    [<CustomOperation("Breakpoint")>] member _.Breakpoint (render: AttrRenderFragment, x: MudBlazor.Breakpoint) = render ==> ("Breakpoint" => x)
    [<CustomOperation("Elevation")>] member _.Elevation (render: AttrRenderFragment, x: System.Int32) = render ==> ("Elevation" => x)
    [<CustomOperation("Square")>] member _.Square (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Square" => x)
    [<CustomOperation("Outlined")>] member _.Outlined (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Outlined" => x)
    [<CustomOperation("Bordered")>] member _.Bordered (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Bordered" => x)
    [<CustomOperation("ColGroup")>] member _.ColGroup (render: AttrRenderFragment, fragment) = render ==> html.renderFragment("ColGroup", fragment)
    [<CustomOperation("ColGroup")>] member _.ColGroup (render: AttrRenderFragment, fragments) = render ==> html.renderFragment("ColGroup", fragment { yield! fragments })
    [<CustomOperation("ColGroup")>] member _.ColGroup (render: AttrRenderFragment, x: string) = render ==> html.renderFragment("ColGroup", html.text x)
    [<CustomOperation("ColGroup")>] member _.ColGroup (render: AttrRenderFragment, x: int) = render ==> html.renderFragment("ColGroup", html.text x)
    [<CustomOperation("ColGroup")>] member _.ColGroup (render: AttrRenderFragment, x: float) = render ==> html.renderFragment("ColGroup", html.text x)
    [<CustomOperation("Dense")>] member _.Dense (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Dense" => x)
    [<CustomOperation("Hover")>] member _.Hover (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Hover" => x)
    [<CustomOperation("Striped")>] member _.Striped (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Striped" => x)
    [<CustomOperation("FixedHeader")>] member _.FixedHeader (render: AttrRenderFragment, x: System.Boolean) = render ==> ("FixedHeader" => x)
    [<CustomOperation("FixedFooter")>] member _.FixedFooter (render: AttrRenderFragment, x: System.Boolean) = render ==> ("FixedFooter" => x)
    [<CustomOperation("FilterDefinitions")>] member _.FilterDefinitions (render: AttrRenderFragment, x: System.Collections.Generic.List<MudBlazor.FilterDefinition<'T>>) = render ==> ("FilterDefinitions" => x)
    [<CustomOperation("Virtualize")>] member _.Virtualize (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Virtualize" => x)
    [<CustomOperation("RowClass")>] member _.RowClass (render: AttrRenderFragment, x: System.String) = render ==> ("RowClass" => x)
    [<CustomOperation("RowStyle")>] member _.RowStyle (render: AttrRenderFragment, x: System.String) = render ==> ("RowStyle" => x)
    [<CustomOperation("RowClassFunc")>] member _.RowClassFunc (render: AttrRenderFragment, fn) = render ==> ("RowClassFunc" => (System.Func<'T, System.Int32, System.String>fn))
    [<CustomOperation("RowStyleFunc")>] member _.RowStyleFunc (render: AttrRenderFragment, fn) = render ==> ("RowStyleFunc" => (System.Func<'T, System.Int32, System.String>fn))
    [<CustomOperation("MultiSelection")>] member _.MultiSelection (render: AttrRenderFragment, x: System.Boolean) = render ==> ("MultiSelection" => x)
    [<CustomOperation("EditMode")>] member _.EditMode (render: AttrRenderFragment, x: System.Nullable<MudBlazor.DataGridEditMode>) = render ==> ("EditMode" => x)
    [<CustomOperation("Items")>] member _.Items (render: AttrRenderFragment, x: System.Collections.Generic.IEnumerable<'T>) = render ==> ("Items" => x)
    [<CustomOperation("Loading")>] member _.Loading (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Loading" => x)
    [<CustomOperation("CanCancelEdit")>] member _.CanCancelEdit (render: AttrRenderFragment, x: System.Boolean) = render ==> ("CanCancelEdit" => x)
    [<CustomOperation("LoadingProgressColor")>] member _.LoadingProgressColor (render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("LoadingProgressColor" => x)
    [<CustomOperation("ToolBarContent")>] member _.ToolBarContent (render: AttrRenderFragment, fragment) = render ==> html.renderFragment("ToolBarContent", fragment)
    [<CustomOperation("ToolBarContent")>] member _.ToolBarContent (render: AttrRenderFragment, fragments) = render ==> html.renderFragment("ToolBarContent", fragment { yield! fragments })
    [<CustomOperation("ToolBarContent")>] member _.ToolBarContent (render: AttrRenderFragment, x: string) = render ==> html.renderFragment("ToolBarContent", html.text x)
    [<CustomOperation("ToolBarContent")>] member _.ToolBarContent (render: AttrRenderFragment, x: int) = render ==> html.renderFragment("ToolBarContent", html.text x)
    [<CustomOperation("ToolBarContent")>] member _.ToolBarContent (render: AttrRenderFragment, x: float) = render ==> html.renderFragment("ToolBarContent", html.text x)
    [<CustomOperation("HorizontalScrollbar")>] member _.HorizontalScrollbar (render: AttrRenderFragment, x: System.Boolean) = render ==> ("HorizontalScrollbar" => x)
    [<CustomOperation("HeaderClass")>] member _.HeaderClass (render: AttrRenderFragment, x: System.String) = render ==> ("HeaderClass" => x)
    [<CustomOperation("Height")>] member _.Height (render: AttrRenderFragment, x: System.String) = render ==> ("Height" => x)
    [<CustomOperation("FooterClass")>] member _.FooterClass (render: AttrRenderFragment, x: System.String) = render ==> ("FooterClass" => x)
    [<CustomOperation("QuickFilter")>] member _.QuickFilter (render: AttrRenderFragment, fn) = render ==> ("QuickFilter" => (System.Func<'T, System.Boolean>fn))
    [<CustomOperation("Header")>] member _.Header (render: AttrRenderFragment, fragment) = render ==> html.renderFragment("Header", fragment)
    [<CustomOperation("Header")>] member _.Header (render: AttrRenderFragment, fragments) = render ==> html.renderFragment("Header", fragment { yield! fragments })
    [<CustomOperation("Header")>] member _.Header (render: AttrRenderFragment, x: string) = render ==> html.renderFragment("Header", html.text x)
    [<CustomOperation("Header")>] member _.Header (render: AttrRenderFragment, x: int) = render ==> html.renderFragment("Header", html.text x)
    [<CustomOperation("Header")>] member _.Header (render: AttrRenderFragment, x: float) = render ==> html.renderFragment("Header", html.text x)
    [<CustomOperation("Columns")>] member _.Columns (render: AttrRenderFragment, fragment) = render ==> html.renderFragment("Columns", fragment)
    [<CustomOperation("Columns")>] member _.Columns (render: AttrRenderFragment, fragments) = render ==> html.renderFragment("Columns", fragment { yield! fragments })
    [<CustomOperation("Columns")>] member _.Columns (render: AttrRenderFragment, x: string) = render ==> html.renderFragment("Columns", html.text x)
    [<CustomOperation("Columns")>] member _.Columns (render: AttrRenderFragment, x: int) = render ==> html.renderFragment("Columns", html.text x)
    [<CustomOperation("Columns")>] member _.Columns (render: AttrRenderFragment, x: float) = render ==> html.renderFragment("Columns", html.text x)
    [<CustomOperation("Footer")>] member _.Footer (render: AttrRenderFragment, fragment) = render ==> html.renderFragment("Footer", fragment)
    [<CustomOperation("Footer")>] member _.Footer (render: AttrRenderFragment, fragments) = render ==> html.renderFragment("Footer", fragment { yield! fragments })
    [<CustomOperation("Footer")>] member _.Footer (render: AttrRenderFragment, x: string) = render ==> html.renderFragment("Footer", html.text x)
    [<CustomOperation("Footer")>] member _.Footer (render: AttrRenderFragment, x: int) = render ==> html.renderFragment("Footer", html.text x)
    [<CustomOperation("Footer")>] member _.Footer (render: AttrRenderFragment, x: float) = render ==> html.renderFragment("Footer", html.text x)
    [<CustomOperation("ChildRowContent")>] member _.ChildRowContent (render: AttrRenderFragment, fn: 'T -> NodeRenderFragment) = render ==> html.renderFragment("ChildRowContent", fn)
    [<CustomOperation("NoRecordsContent")>] member _.NoRecordsContent (render: AttrRenderFragment, fragment) = render ==> html.renderFragment("NoRecordsContent", fragment)
    [<CustomOperation("NoRecordsContent")>] member _.NoRecordsContent (render: AttrRenderFragment, fragments) = render ==> html.renderFragment("NoRecordsContent", fragment { yield! fragments })
    [<CustomOperation("NoRecordsContent")>] member _.NoRecordsContent (render: AttrRenderFragment, x: string) = render ==> html.renderFragment("NoRecordsContent", html.text x)
    [<CustomOperation("NoRecordsContent")>] member _.NoRecordsContent (render: AttrRenderFragment, x: int) = render ==> html.renderFragment("NoRecordsContent", html.text x)
    [<CustomOperation("NoRecordsContent")>] member _.NoRecordsContent (render: AttrRenderFragment, x: float) = render ==> html.renderFragment("NoRecordsContent", html.text x)
    [<CustomOperation("LoadingContent")>] member _.LoadingContent (render: AttrRenderFragment, fragment) = render ==> html.renderFragment("LoadingContent", fragment)
    [<CustomOperation("LoadingContent")>] member _.LoadingContent (render: AttrRenderFragment, fragments) = render ==> html.renderFragment("LoadingContent", fragment { yield! fragments })
    [<CustomOperation("LoadingContent")>] member _.LoadingContent (render: AttrRenderFragment, x: string) = render ==> html.renderFragment("LoadingContent", html.text x)
    [<CustomOperation("LoadingContent")>] member _.LoadingContent (render: AttrRenderFragment, x: int) = render ==> html.renderFragment("LoadingContent", html.text x)
    [<CustomOperation("LoadingContent")>] member _.LoadingContent (render: AttrRenderFragment, x: float) = render ==> html.renderFragment("LoadingContent", html.text x)
    [<CustomOperation("PagerContent")>] member _.PagerContent (render: AttrRenderFragment, fragment) = render ==> html.renderFragment("PagerContent", fragment)
    [<CustomOperation("PagerContent")>] member _.PagerContent (render: AttrRenderFragment, fragments) = render ==> html.renderFragment("PagerContent", fragment { yield! fragments })
    [<CustomOperation("PagerContent")>] member _.PagerContent (render: AttrRenderFragment, x: string) = render ==> html.renderFragment("PagerContent", html.text x)
    [<CustomOperation("PagerContent")>] member _.PagerContent (render: AttrRenderFragment, x: int) = render ==> html.renderFragment("PagerContent", html.text x)
    [<CustomOperation("PagerContent")>] member _.PagerContent (render: AttrRenderFragment, x: float) = render ==> html.renderFragment("PagerContent", html.text x)
    [<CustomOperation("ServerData")>] member _.ServerData (render: AttrRenderFragment, fn) = render ==> ("ServerData" => (System.Func<MudBlazor.GridState<'T>, System.Threading.Tasks.Task<MudBlazor.GridData<'T>>>fn))
    [<CustomOperation("RowsPerPage")>] member _.RowsPerPage (render: AttrRenderFragment, x: System.Int32) = render ==> ("RowsPerPage" => x)
    [<CustomOperation("CurrentPage")>] member _.CurrentPage (render: AttrRenderFragment, x: System.Int32) = render ==> ("CurrentPage" => x)
    [<CustomOperation("ReadOnly")>] member _.ReadOnly (render: AttrRenderFragment, x: System.Boolean) = render ==> ("ReadOnly" => x)
    [<CustomOperation("SelectedItems")>] member _.SelectedItems (render: AttrRenderFragment, x: System.Collections.Generic.HashSet<'T>) = render ==> ("SelectedItems" => x)
    [<CustomOperation("SelectedItems'")>] member _.SelectedItems' (render: AttrRenderFragment, value: IStore<System.Collections.Generic.HashSet<'T>>) = render ==> html.bind("SelectedItems", value)
    [<CustomOperation("SelectedItems'")>] member _.SelectedItems' (render: AttrRenderFragment, value: cval<System.Collections.Generic.HashSet<'T>>) = render ==> html.bind("SelectedItems", value)
    [<CustomOperation("SelectedItems'")>] member _.SelectedItems' (render: AttrRenderFragment, valueFn: System.Collections.Generic.HashSet<'T> * (System.Collections.Generic.HashSet<'T> -> unit)) = render ==> html.bind("SelectedItems", valueFn)
    [<CustomOperation("SelectedItem")>] member _.SelectedItem (render: AttrRenderFragment, x: 'T) = render ==> ("SelectedItem" => x)
    [<CustomOperation("SelectedItem'")>] member _.SelectedItem' (render: AttrRenderFragment, value: IStore<'T>) = render ==> html.bind("SelectedItem", value)
    [<CustomOperation("SelectedItem'")>] member _.SelectedItem' (render: AttrRenderFragment, value: cval<'T>) = render ==> html.bind("SelectedItem", value)
    [<CustomOperation("SelectedItem'")>] member _.SelectedItem' (render: AttrRenderFragment, valueFn: 'T * ('T -> unit)) = render ==> html.bind("SelectedItem", valueFn)
                

type MudDataGridPagerBuilder<'FunBlazorGeneric, 'T when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    static member inline create () = html.fromBuilder(MudDataGridPagerBuilder<'FunBlazorGeneric, 'T>())
    [<CustomOperation("DisableRowsPerPage")>] member _.DisableRowsPerPage (render: AttrRenderFragment, x: System.Boolean) = render ==> ("DisableRowsPerPage" => x)
    [<CustomOperation("PageSizeOptions")>] member _.PageSizeOptions (render: AttrRenderFragment, x: System.Int32[]) = render ==> ("PageSizeOptions" => x)
    [<CustomOperation("InfoFormat")>] member _.InfoFormat (render: AttrRenderFragment, x: System.String) = render ==> ("InfoFormat" => x)
    [<CustomOperation("RowsPerPageString")>] member _.RowsPerPageString (render: AttrRenderFragment, x: System.String) = render ==> ("RowsPerPageString" => x)
                

type RowBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    static member inline create (x: string) = RowBuilder<'FunBlazorGeneric>(){ x }
    static member inline create (x: NodeRenderFragment seq) = RowBuilder<'FunBlazorGeneric>(){ yield! x }

                

type MudDialogBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    static member inline create () = html.fromBuilder(MudDialogBuilder<'FunBlazorGeneric>())
    [<CustomOperation("TitleContent")>] member _.TitleContent (render: AttrRenderFragment, fragment) = render ==> html.renderFragment("TitleContent", fragment)
    [<CustomOperation("TitleContent")>] member _.TitleContent (render: AttrRenderFragment, fragments) = render ==> html.renderFragment("TitleContent", fragment { yield! fragments })
    [<CustomOperation("TitleContent")>] member _.TitleContent (render: AttrRenderFragment, x: string) = render ==> html.renderFragment("TitleContent", html.text x)
    [<CustomOperation("TitleContent")>] member _.TitleContent (render: AttrRenderFragment, x: int) = render ==> html.renderFragment("TitleContent", html.text x)
    [<CustomOperation("TitleContent")>] member _.TitleContent (render: AttrRenderFragment, x: float) = render ==> html.renderFragment("TitleContent", html.text x)
    [<CustomOperation("DialogContent")>] member _.DialogContent (render: AttrRenderFragment, fragment) = render ==> html.renderFragment("DialogContent", fragment)
    [<CustomOperation("DialogContent")>] member _.DialogContent (render: AttrRenderFragment, fragments) = render ==> html.renderFragment("DialogContent", fragment { yield! fragments })
    [<CustomOperation("DialogContent")>] member _.DialogContent (render: AttrRenderFragment, x: string) = render ==> html.renderFragment("DialogContent", html.text x)
    [<CustomOperation("DialogContent")>] member _.DialogContent (render: AttrRenderFragment, x: int) = render ==> html.renderFragment("DialogContent", html.text x)
    [<CustomOperation("DialogContent")>] member _.DialogContent (render: AttrRenderFragment, x: float) = render ==> html.renderFragment("DialogContent", html.text x)
    [<CustomOperation("DialogActions")>] member _.DialogActions (render: AttrRenderFragment, fragment) = render ==> html.renderFragment("DialogActions", fragment)
    [<CustomOperation("DialogActions")>] member _.DialogActions (render: AttrRenderFragment, fragments) = render ==> html.renderFragment("DialogActions", fragment { yield! fragments })
    [<CustomOperation("DialogActions")>] member _.DialogActions (render: AttrRenderFragment, x: string) = render ==> html.renderFragment("DialogActions", html.text x)
    [<CustomOperation("DialogActions")>] member _.DialogActions (render: AttrRenderFragment, x: int) = render ==> html.renderFragment("DialogActions", html.text x)
    [<CustomOperation("DialogActions")>] member _.DialogActions (render: AttrRenderFragment, x: float) = render ==> html.renderFragment("DialogActions", html.text x)
    [<CustomOperation("Options")>] member _.Options (render: AttrRenderFragment, x: MudBlazor.DialogOptions) = render ==> ("Options" => x)
    [<CustomOperation("DisableSidePadding")>] member _.DisableSidePadding (render: AttrRenderFragment, x: System.Boolean) = render ==> ("DisableSidePadding" => x)
    [<CustomOperation("ClassContent")>] member _.ClassContent (render: AttrRenderFragment, x: System.String) = render ==> ("ClassContent" => x)
    [<CustomOperation("ClassActions")>] member _.ClassActions (render: AttrRenderFragment, x: System.String) = render ==> ("ClassActions" => x)
    [<CustomOperation("ContentStyle")>] member _.ContentStyle (render: AttrRenderFragment, x: System.String) = render ==> ("ContentStyle" => x)
    [<CustomOperation("IsVisible")>] member _.IsVisible (render: AttrRenderFragment, x: System.Boolean) = render ==> ("IsVisible" => x)
    [<CustomOperation("IsVisible'")>] member _.IsVisible' (render: AttrRenderFragment, value: IStore<System.Boolean>) = render ==> html.bind("IsVisible", value)
    [<CustomOperation("IsVisible'")>] member _.IsVisible' (render: AttrRenderFragment, value: cval<System.Boolean>) = render ==> html.bind("IsVisible", value)
    [<CustomOperation("IsVisible'")>] member _.IsVisible' (render: AttrRenderFragment, valueFn: System.Boolean * (System.Boolean -> unit)) = render ==> html.bind("IsVisible", valueFn)
    [<CustomOperation("IsVisibleChanged")>] member _.IsVisibleChanged (render: AttrRenderFragment, fn) = render ==> html.callback<System.Boolean>("IsVisibleChanged", fn)
                

type MudDialogInstanceBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    static member inline create () = html.fromBuilder(MudDialogInstanceBuilder<'FunBlazorGeneric>())
    [<CustomOperation("Options")>] member _.Options (render: AttrRenderFragment, x: MudBlazor.DialogOptions) = render ==> ("Options" => x)
    [<CustomOperation("Title")>] member _.Title (render: AttrRenderFragment, x: System.String) = render ==> ("Title" => x)
    [<CustomOperation("TitleContent")>] member _.TitleContent (render: AttrRenderFragment, fragment) = render ==> html.renderFragment("TitleContent", fragment)
    [<CustomOperation("TitleContent")>] member _.TitleContent (render: AttrRenderFragment, fragments) = render ==> html.renderFragment("TitleContent", fragment { yield! fragments })
    [<CustomOperation("TitleContent")>] member _.TitleContent (render: AttrRenderFragment, x: string) = render ==> html.renderFragment("TitleContent", html.text x)
    [<CustomOperation("TitleContent")>] member _.TitleContent (render: AttrRenderFragment, x: int) = render ==> html.renderFragment("TitleContent", html.text x)
    [<CustomOperation("TitleContent")>] member _.TitleContent (render: AttrRenderFragment, x: float) = render ==> html.renderFragment("TitleContent", html.text x)
    [<CustomOperation("Content")>] member _.Content (render: AttrRenderFragment, fragment) = render ==> html.renderFragment("Content", fragment)
    [<CustomOperation("Content")>] member _.Content (render: AttrRenderFragment, fragments) = render ==> html.renderFragment("Content", fragment { yield! fragments })
    [<CustomOperation("Content")>] member _.Content (render: AttrRenderFragment, x: string) = render ==> html.renderFragment("Content", html.text x)
    [<CustomOperation("Content")>] member _.Content (render: AttrRenderFragment, x: int) = render ==> html.renderFragment("Content", html.text x)
    [<CustomOperation("Content")>] member _.Content (render: AttrRenderFragment, x: float) = render ==> html.renderFragment("Content", html.text x)
    [<CustomOperation("Id")>] member _.Id (render: AttrRenderFragment, x: System.Guid) = render ==> ("Id" => x)
    [<CustomOperation("CloseIcon")>] member _.CloseIcon (render: AttrRenderFragment, x: System.String) = render ==> ("CloseIcon" => x)
                

type MudDrawerBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    static member inline create (x: string) = MudDrawerBuilder<'FunBlazorGeneric>(){ x }
    static member inline create (x: NodeRenderFragment seq) = MudDrawerBuilder<'FunBlazorGeneric>(){ yield! x }
    [<CustomOperation("Fixed")>] member _.Fixed (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Fixed" => x)
    [<CustomOperation("Elevation")>] member _.Elevation (render: AttrRenderFragment, x: System.Int32) = render ==> ("Elevation" => x)
    [<CustomOperation("Anchor")>] member _.Anchor (render: AttrRenderFragment, x: MudBlazor.Anchor) = render ==> ("Anchor" => x)
    [<CustomOperation("Color")>] member _.Color (render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("Color" => x)
    [<CustomOperation("Variant")>] member _.Variant (render: AttrRenderFragment, x: MudBlazor.DrawerVariant) = render ==> ("Variant" => x)
    [<CustomOperation("DisableOverlay")>] member _.DisableOverlay (render: AttrRenderFragment, x: System.Boolean) = render ==> ("DisableOverlay" => x)
    [<CustomOperation("PreserveOpenState")>] member _.PreserveOpenState (render: AttrRenderFragment, x: System.Boolean) = render ==> ("PreserveOpenState" => x)
    [<CustomOperation("OpenMiniOnHover")>] member _.OpenMiniOnHover (render: AttrRenderFragment, x: System.Boolean) = render ==> ("OpenMiniOnHover" => x)
    [<CustomOperation("Breakpoint")>] member _.Breakpoint (render: AttrRenderFragment, x: MudBlazor.Breakpoint) = render ==> ("Breakpoint" => x)
    [<CustomOperation("Open")>] member _.Open (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Open" => x)
    [<CustomOperation("Open'")>] member _.Open' (render: AttrRenderFragment, value: IStore<System.Boolean>) = render ==> html.bind("Open", value)
    [<CustomOperation("Open'")>] member _.Open' (render: AttrRenderFragment, value: cval<System.Boolean>) = render ==> html.bind("Open", value)
    [<CustomOperation("Open'")>] member _.Open' (render: AttrRenderFragment, valueFn: System.Boolean * (System.Boolean -> unit)) = render ==> html.bind("Open", valueFn)
    [<CustomOperation("OpenChanged")>] member _.OpenChanged (render: AttrRenderFragment, fn) = render ==> html.callback<System.Boolean>("OpenChanged", fn)
    [<CustomOperation("Width")>] member _.Width (render: AttrRenderFragment, x: System.String) = render ==> ("Width" => x)
    [<CustomOperation("MiniWidth")>] member _.MiniWidth (render: AttrRenderFragment, x: System.String) = render ==> ("MiniWidth" => x)
    [<CustomOperation("Height")>] member _.Height (render: AttrRenderFragment, x: System.String) = render ==> ("Height" => x)
    [<CustomOperation("ClipMode")>] member _.ClipMode (render: AttrRenderFragment, x: MudBlazor.DrawerClipMode) = render ==> ("ClipMode" => x)
                

type MudElementBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    static member inline create (x: string) = MudElementBuilder<'FunBlazorGeneric>(){ x }
    static member inline create (x: NodeRenderFragment seq) = MudElementBuilder<'FunBlazorGeneric>(){ yield! x }
    [<CustomOperation("HtmlTag")>] member _.HtmlTag (render: AttrRenderFragment, x: System.String) = render ==> ("HtmlTag" => x)
    [<CustomOperation("Ref")>] member _.Ref (render: AttrRenderFragment, x: System.Nullable<Microsoft.AspNetCore.Components.ElementReference>) = render ==> ("Ref" => x)
    [<CustomOperation("Ref'")>] member _.Ref' (render: AttrRenderFragment, value: IStore<System.Nullable<Microsoft.AspNetCore.Components.ElementReference>>) = render ==> html.bind("Ref", value)
    [<CustomOperation("Ref'")>] member _.Ref' (render: AttrRenderFragment, value: cval<System.Nullable<Microsoft.AspNetCore.Components.ElementReference>>) = render ==> html.bind("Ref", value)
    [<CustomOperation("Ref'")>] member _.Ref' (render: AttrRenderFragment, valueFn: System.Nullable<Microsoft.AspNetCore.Components.ElementReference> * (System.Nullable<Microsoft.AspNetCore.Components.ElementReference> -> unit)) = render ==> html.bind("Ref", valueFn)
    [<CustomOperation("RefChanged")>] member _.RefChanged (render: AttrRenderFragment, fn) = render ==> html.callback<Microsoft.AspNetCore.Components.ElementReference>("RefChanged", fn)
                

type MudExpansionPanelBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    static member inline create (x: string) = MudExpansionPanelBuilder<'FunBlazorGeneric>(){ x }
    static member inline create (x: NodeRenderFragment seq) = MudExpansionPanelBuilder<'FunBlazorGeneric>(){ yield! x }
    [<CustomOperation("MaxHeight")>] member _.MaxHeight (render: AttrRenderFragment, x: System.Nullable<System.Int32>) = render ==> ("MaxHeight" => x)
    [<CustomOperation("TitleContent")>] member _.TitleContent (render: AttrRenderFragment, fragment) = render ==> html.renderFragment("TitleContent", fragment)
    [<CustomOperation("TitleContent")>] member _.TitleContent (render: AttrRenderFragment, fragments) = render ==> html.renderFragment("TitleContent", fragment { yield! fragments })
    [<CustomOperation("TitleContent")>] member _.TitleContent (render: AttrRenderFragment, x: string) = render ==> html.renderFragment("TitleContent", html.text x)
    [<CustomOperation("TitleContent")>] member _.TitleContent (render: AttrRenderFragment, x: int) = render ==> html.renderFragment("TitleContent", html.text x)
    [<CustomOperation("TitleContent")>] member _.TitleContent (render: AttrRenderFragment, x: float) = render ==> html.renderFragment("TitleContent", html.text x)
    [<CustomOperation("Text")>] member _.Text (render: AttrRenderFragment, x: System.String) = render ==> ("Text" => x)
    [<CustomOperation("HideIcon")>] member _.HideIcon (render: AttrRenderFragment, x: System.Boolean) = render ==> ("HideIcon" => x)
    [<CustomOperation("Icon")>] member _.Icon (render: AttrRenderFragment, x: System.String) = render ==> ("Icon" => x)
    [<CustomOperation("Dense")>] member _.Dense (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Dense" => x)
    [<CustomOperation("DisableGutters")>] member _.DisableGutters (render: AttrRenderFragment, x: System.Boolean) = render ==> ("DisableGutters" => x)
    [<CustomOperation("IsExpandedChanged")>] member _.IsExpandedChanged (render: AttrRenderFragment, fn) = render ==> html.callback<System.Boolean>("IsExpandedChanged", fn)
    [<CustomOperation("IsExpanded")>] member _.IsExpanded (render: AttrRenderFragment, x: System.Boolean) = render ==> ("IsExpanded" => x)
    [<CustomOperation("IsExpanded'")>] member _.IsExpanded' (render: AttrRenderFragment, value: IStore<System.Boolean>) = render ==> html.bind("IsExpanded", value)
    [<CustomOperation("IsExpanded'")>] member _.IsExpanded' (render: AttrRenderFragment, value: cval<System.Boolean>) = render ==> html.bind("IsExpanded", value)
    [<CustomOperation("IsExpanded'")>] member _.IsExpanded' (render: AttrRenderFragment, valueFn: System.Boolean * (System.Boolean -> unit)) = render ==> html.bind("IsExpanded", valueFn)
    [<CustomOperation("IsInitiallyExpanded")>] member _.IsInitiallyExpanded (render: AttrRenderFragment, x: System.Boolean) = render ==> ("IsInitiallyExpanded" => x)
    [<CustomOperation("Disabled")>] member _.Disabled (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Disabled" => x)
                

type MudExpansionPanelsBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    static member inline create (x: string) = MudExpansionPanelsBuilder<'FunBlazorGeneric>(){ x }
    static member inline create (x: NodeRenderFragment seq) = MudExpansionPanelsBuilder<'FunBlazorGeneric>(){ yield! x }
    [<CustomOperation("Square")>] member _.Square (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Square" => x)
    [<CustomOperation("MultiExpansion")>] member _.MultiExpansion (render: AttrRenderFragment, x: System.Boolean) = render ==> ("MultiExpansion" => x)
    [<CustomOperation("Elevation")>] member _.Elevation (render: AttrRenderFragment, x: System.Int32) = render ==> ("Elevation" => x)
    [<CustomOperation("Dense")>] member _.Dense (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Dense" => x)
    [<CustomOperation("DisableGutters")>] member _.DisableGutters (render: AttrRenderFragment, x: System.Boolean) = render ==> ("DisableGutters" => x)
    [<CustomOperation("DisableBorders")>] member _.DisableBorders (render: AttrRenderFragment, x: System.Boolean) = render ==> ("DisableBorders" => x)
                

type MudFieldBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    static member inline create (x: string) = MudFieldBuilder<'FunBlazorGeneric>(){ x }
    static member inline create (x: NodeRenderFragment seq) = MudFieldBuilder<'FunBlazorGeneric>(){ yield! x }
    [<CustomOperation("Margin")>] member _.Margin (render: AttrRenderFragment, x: MudBlazor.Margin) = render ==> ("Margin" => x)
    [<CustomOperation("Error")>] member _.Error (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Error" => x)
    [<CustomOperation("ErrorText")>] member _.ErrorText (render: AttrRenderFragment, x: System.String) = render ==> ("ErrorText" => x)
    [<CustomOperation("HelperText")>] member _.HelperText (render: AttrRenderFragment, x: System.String) = render ==> ("HelperText" => x)
    [<CustomOperation("FullWidth")>] member _.FullWidth (render: AttrRenderFragment, x: System.Boolean) = render ==> ("FullWidth" => x)
    [<CustomOperation("Label")>] member _.Label (render: AttrRenderFragment, x: System.String) = render ==> ("Label" => x)
    [<CustomOperation("Variant")>] member _.Variant (render: AttrRenderFragment, x: MudBlazor.Variant) = render ==> ("Variant" => x)
    [<CustomOperation("Disabled")>] member _.Disabled (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Disabled" => x)
    [<CustomOperation("AdornmentIcon")>] member _.AdornmentIcon (render: AttrRenderFragment, x: System.String) = render ==> ("AdornmentIcon" => x)
    [<CustomOperation("AdornmentText")>] member _.AdornmentText (render: AttrRenderFragment, x: System.String) = render ==> ("AdornmentText" => x)
    [<CustomOperation("Adornment")>] member _.Adornment (render: AttrRenderFragment, x: MudBlazor.Adornment) = render ==> ("Adornment" => x)
    [<CustomOperation("AdornmentColor")>] member _.AdornmentColor (render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("AdornmentColor" => x)
    [<CustomOperation("IconSize")>] member _.IconSize (render: AttrRenderFragment, x: MudBlazor.Size) = render ==> ("IconSize" => x)
    [<CustomOperation("OnAdornmentClick")>] member _.OnAdornmentClick (render: AttrRenderFragment, fn) = render ==> html.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>("OnAdornmentClick", fn)
    [<CustomOperation("InnerPadding")>] member _.InnerPadding (render: AttrRenderFragment, x: System.Boolean) = render ==> ("InnerPadding" => x)
    [<CustomOperation("DisableUnderLine")>] member _.DisableUnderLine (render: AttrRenderFragment, x: System.Boolean) = render ==> ("DisableUnderLine" => x)
                

type MudFocusTrapBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    static member inline create (x: string) = MudFocusTrapBuilder<'FunBlazorGeneric>(){ x }
    static member inline create (x: NodeRenderFragment seq) = MudFocusTrapBuilder<'FunBlazorGeneric>(){ yield! x }
    [<CustomOperation("Disabled")>] member _.Disabled (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Disabled" => x)
    [<CustomOperation("DefaultFocus")>] member _.DefaultFocus (render: AttrRenderFragment, x: MudBlazor.DefaultFocus) = render ==> ("DefaultFocus" => x)
                

type MudFormBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    static member inline create (x: string) = MudFormBuilder<'FunBlazorGeneric>(){ x }
    static member inline create (x: NodeRenderFragment seq) = MudFormBuilder<'FunBlazorGeneric>(){ yield! x }
    [<CustomOperation("IsValid")>] member _.IsValid (render: AttrRenderFragment, x: System.Boolean) = render ==> ("IsValid" => x)
    [<CustomOperation("IsValid'")>] member _.IsValid' (render: AttrRenderFragment, value: IStore<System.Boolean>) = render ==> html.bind("IsValid", value)
    [<CustomOperation("IsValid'")>] member _.IsValid' (render: AttrRenderFragment, value: cval<System.Boolean>) = render ==> html.bind("IsValid", value)
    [<CustomOperation("IsValid'")>] member _.IsValid' (render: AttrRenderFragment, valueFn: System.Boolean * (System.Boolean -> unit)) = render ==> html.bind("IsValid", valueFn)
    [<CustomOperation("IsTouched")>] member _.IsTouched (render: AttrRenderFragment, x: System.Boolean) = render ==> ("IsTouched" => x)
    [<CustomOperation("IsTouched'")>] member _.IsTouched' (render: AttrRenderFragment, value: IStore<System.Boolean>) = render ==> html.bind("IsTouched", value)
    [<CustomOperation("IsTouched'")>] member _.IsTouched' (render: AttrRenderFragment, value: cval<System.Boolean>) = render ==> html.bind("IsTouched", value)
    [<CustomOperation("IsTouched'")>] member _.IsTouched' (render: AttrRenderFragment, valueFn: System.Boolean * (System.Boolean -> unit)) = render ==> html.bind("IsTouched", valueFn)
    [<CustomOperation("ValidationDelay")>] member _.ValidationDelay (render: AttrRenderFragment, x: System.Int32) = render ==> ("ValidationDelay" => x)
    [<CustomOperation("SuppressRenderingOnValidation")>] member _.SuppressRenderingOnValidation (render: AttrRenderFragment, x: System.Boolean) = render ==> ("SuppressRenderingOnValidation" => x)
    [<CustomOperation("SuppressImplicitSubmission")>] member _.SuppressImplicitSubmission (render: AttrRenderFragment, x: System.Boolean) = render ==> ("SuppressImplicitSubmission" => x)
    [<CustomOperation("IsValidChanged")>] member _.IsValidChanged (render: AttrRenderFragment, fn) = render ==> html.callback<System.Boolean>("IsValidChanged", fn)
    [<CustomOperation("IsTouchedChanged")>] member _.IsTouchedChanged (render: AttrRenderFragment, fn) = render ==> html.callback<System.Boolean>("IsTouchedChanged", fn)
    [<CustomOperation("Errors")>] member _.Errors (render: AttrRenderFragment, x: System.String[]) = render ==> ("Errors" => x)
    [<CustomOperation("Errors'")>] member _.Errors' (render: AttrRenderFragment, value: IStore<System.String[]>) = render ==> html.bind("Errors", value)
    [<CustomOperation("Errors'")>] member _.Errors' (render: AttrRenderFragment, value: cval<System.String[]>) = render ==> html.bind("Errors", value)
    [<CustomOperation("Errors'")>] member _.Errors' (render: AttrRenderFragment, valueFn: System.String[] * (System.String[] -> unit)) = render ==> html.bind("Errors", valueFn)
    [<CustomOperation("ErrorsChanged")>] member _.ErrorsChanged (render: AttrRenderFragment, fn) = render ==> html.callback<System.String[]>("ErrorsChanged", fn)
    [<CustomOperation("Model")>] member _.Model (render: AttrRenderFragment, x: System.Object) = render ==> ("Model" => x)
                

type MudHiddenBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    static member inline create (x: string) = MudHiddenBuilder<'FunBlazorGeneric>(){ x }
    static member inline create (x: NodeRenderFragment seq) = MudHiddenBuilder<'FunBlazorGeneric>(){ yield! x }
    [<CustomOperation("Breakpoint")>] member _.Breakpoint (render: AttrRenderFragment, x: MudBlazor.Breakpoint) = render ==> ("Breakpoint" => x)
    [<CustomOperation("Invert")>] member _.Invert (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Invert" => x)
    [<CustomOperation("IsHidden")>] member _.IsHidden (render: AttrRenderFragment, x: System.Boolean) = render ==> ("IsHidden" => x)
    [<CustomOperation("IsHidden'")>] member _.IsHidden' (render: AttrRenderFragment, value: IStore<System.Boolean>) = render ==> html.bind("IsHidden", value)
    [<CustomOperation("IsHidden'")>] member _.IsHidden' (render: AttrRenderFragment, value: cval<System.Boolean>) = render ==> html.bind("IsHidden", value)
    [<CustomOperation("IsHidden'")>] member _.IsHidden' (render: AttrRenderFragment, valueFn: System.Boolean * (System.Boolean -> unit)) = render ==> html.bind("IsHidden", valueFn)
    [<CustomOperation("IsHiddenChanged")>] member _.IsHiddenChanged (render: AttrRenderFragment, fn) = render ==> html.callback<System.Boolean>("IsHiddenChanged", fn)
                

type MudIconBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    static member inline create (x: string) = MudIconBuilder<'FunBlazorGeneric>(){ x }
    static member inline create (x: NodeRenderFragment seq) = MudIconBuilder<'FunBlazorGeneric>(){ yield! x }
    [<CustomOperation("Icon")>] member _.Icon (render: AttrRenderFragment, x: System.String) = render ==> ("Icon" => x)
    [<CustomOperation("Title")>] member _.Title (render: AttrRenderFragment, x: System.String) = render ==> ("Title" => x)
    [<CustomOperation("Size")>] member _.Size (render: AttrRenderFragment, x: MudBlazor.Size) = render ==> ("Size" => x)
    [<CustomOperation("Color")>] member _.Color (render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("Color" => x)
    [<CustomOperation("ViewBox")>] member _.ViewBox (render: AttrRenderFragment, x: System.String) = render ==> ("ViewBox" => x)
                

type MudInputControlBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    static member inline create (x: string) = MudInputControlBuilder<'FunBlazorGeneric>(){ x }
    static member inline create (x: NodeRenderFragment seq) = MudInputControlBuilder<'FunBlazorGeneric>(){ yield! x }
    [<CustomOperation("InputContent")>] member _.InputContent (render: AttrRenderFragment, fragment) = render ==> html.renderFragment("InputContent", fragment)
    [<CustomOperation("InputContent")>] member _.InputContent (render: AttrRenderFragment, fragments) = render ==> html.renderFragment("InputContent", fragment { yield! fragments })
    [<CustomOperation("InputContent")>] member _.InputContent (render: AttrRenderFragment, x: string) = render ==> html.renderFragment("InputContent", html.text x)
    [<CustomOperation("InputContent")>] member _.InputContent (render: AttrRenderFragment, x: int) = render ==> html.renderFragment("InputContent", html.text x)
    [<CustomOperation("InputContent")>] member _.InputContent (render: AttrRenderFragment, x: float) = render ==> html.renderFragment("InputContent", html.text x)
    [<CustomOperation("Margin")>] member _.Margin (render: AttrRenderFragment, x: MudBlazor.Margin) = render ==> ("Margin" => x)
    [<CustomOperation("Required")>] member _.Required (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Required" => x)
    [<CustomOperation("Error")>] member _.Error (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Error" => x)
    [<CustomOperation("ErrorText")>] member _.ErrorText (render: AttrRenderFragment, x: System.String) = render ==> ("ErrorText" => x)
    [<CustomOperation("HelperText")>] member _.HelperText (render: AttrRenderFragment, x: System.String) = render ==> ("HelperText" => x)
    [<CustomOperation("HelperTextOnFocus")>] member _.HelperTextOnFocus (render: AttrRenderFragment, x: System.Boolean) = render ==> ("HelperTextOnFocus" => x)
    [<CustomOperation("CounterText")>] member _.CounterText (render: AttrRenderFragment, x: System.String) = render ==> ("CounterText" => x)
    [<CustomOperation("FullWidth")>] member _.FullWidth (render: AttrRenderFragment, x: System.Boolean) = render ==> ("FullWidth" => x)
    [<CustomOperation("Label")>] member _.Label (render: AttrRenderFragment, x: System.String) = render ==> ("Label" => x)
    [<CustomOperation("Variant")>] member _.Variant (render: AttrRenderFragment, x: MudBlazor.Variant) = render ==> ("Variant" => x)
    [<CustomOperation("Disabled")>] member _.Disabled (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Disabled" => x)
                

type MudInputLabelBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    static member inline create (x: string) = MudInputLabelBuilder<'FunBlazorGeneric>(){ x }
    static member inline create (x: NodeRenderFragment seq) = MudInputLabelBuilder<'FunBlazorGeneric>(){ yield! x }
    [<CustomOperation("Disabled")>] member _.Disabled (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Disabled" => x)
    [<CustomOperation("Error")>] member _.Error (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Error" => x)
    [<CustomOperation("Variant")>] member _.Variant (render: AttrRenderFragment, x: MudBlazor.Variant) = render ==> ("Variant" => x)
    [<CustomOperation("Margin")>] member _.Margin (render: AttrRenderFragment, x: MudBlazor.Margin) = render ==> ("Margin" => x)
                

type MudLinkBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    static member inline create (x: string) = MudLinkBuilder<'FunBlazorGeneric>(){ x }
    static member inline create (x: NodeRenderFragment seq) = MudLinkBuilder<'FunBlazorGeneric>(){ yield! x }
    [<CustomOperation("Color")>] member _.Color (render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("Color" => x)
    [<CustomOperation("Typo")>] member _.Typo (render: AttrRenderFragment, x: MudBlazor.Typo) = render ==> ("Typo" => x)
    [<CustomOperation("Underline")>] member _.Underline (render: AttrRenderFragment, x: MudBlazor.Underline) = render ==> ("Underline" => x)
    [<CustomOperation("Href")>] member _.Href (render: AttrRenderFragment, x: System.String) = render ==> ("Href" => x)
    [<CustomOperation("Target")>] member _.Target (render: AttrRenderFragment, x: System.String) = render ==> ("Target" => x)
    [<CustomOperation("Disabled")>] member _.Disabled (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Disabled" => x)
                

type MudListBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    static member inline create (x: string) = MudListBuilder<'FunBlazorGeneric>(){ x }
    static member inline create (x: NodeRenderFragment seq) = MudListBuilder<'FunBlazorGeneric>(){ yield! x }
    [<CustomOperation("Clickable")>] member _.Clickable (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Clickable" => x)
    [<CustomOperation("DisablePadding")>] member _.DisablePadding (render: AttrRenderFragment, x: System.Boolean) = render ==> ("DisablePadding" => x)
    [<CustomOperation("Dense")>] member _.Dense (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Dense" => x)
    [<CustomOperation("DisableGutters")>] member _.DisableGutters (render: AttrRenderFragment, x: System.Boolean) = render ==> ("DisableGutters" => x)
    [<CustomOperation("Disabled")>] member _.Disabled (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Disabled" => x)
    [<CustomOperation("SelectedItem")>] member _.SelectedItem (render: AttrRenderFragment, x: MudBlazor.MudListItem) = render ==> ("SelectedItem" => x)
    [<CustomOperation("SelectedItem'")>] member _.SelectedItem' (render: AttrRenderFragment, value: IStore<MudBlazor.MudListItem>) = render ==> html.bind("SelectedItem", value)
    [<CustomOperation("SelectedItem'")>] member _.SelectedItem' (render: AttrRenderFragment, value: cval<MudBlazor.MudListItem>) = render ==> html.bind("SelectedItem", value)
    [<CustomOperation("SelectedItem'")>] member _.SelectedItem' (render: AttrRenderFragment, valueFn: MudBlazor.MudListItem * (MudBlazor.MudListItem -> unit)) = render ==> html.bind("SelectedItem", valueFn)
    [<CustomOperation("SelectedItemChanged")>] member _.SelectedItemChanged (render: AttrRenderFragment, fn) = render ==> html.callback<MudBlazor.MudListItem>("SelectedItemChanged", fn)
    [<CustomOperation("SelectedValue")>] member _.SelectedValue (render: AttrRenderFragment, x: System.Object) = render ==> ("SelectedValue" => x)
    [<CustomOperation("SelectedValue'")>] member _.SelectedValue' (render: AttrRenderFragment, value: IStore<System.Object>) = render ==> html.bind("SelectedValue", value)
    [<CustomOperation("SelectedValue'")>] member _.SelectedValue' (render: AttrRenderFragment, value: cval<System.Object>) = render ==> html.bind("SelectedValue", value)
    [<CustomOperation("SelectedValue'")>] member _.SelectedValue' (render: AttrRenderFragment, valueFn: System.Object * (System.Object -> unit)) = render ==> html.bind("SelectedValue", valueFn)
    [<CustomOperation("SelectedValueChanged")>] member _.SelectedValueChanged (render: AttrRenderFragment, fn) = render ==> html.callback<System.Object>("SelectedValueChanged", fn)
                

type MudListItemBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    static member inline create (x: string) = MudListItemBuilder<'FunBlazorGeneric>(){ x }
    static member inline create (x: NodeRenderFragment seq) = MudListItemBuilder<'FunBlazorGeneric>(){ yield! x }
    [<CustomOperation("Text")>] member _.Text (render: AttrRenderFragment, x: System.String) = render ==> ("Text" => x)
    [<CustomOperation("Value")>] member _.Value (render: AttrRenderFragment, x: System.Object) = render ==> ("Value" => x)
    [<CustomOperation("Avatar")>] member _.Avatar (render: AttrRenderFragment, x: System.String) = render ==> ("Avatar" => x)
    [<CustomOperation("Href")>] member _.Href (render: AttrRenderFragment, x: System.String) = render ==> ("Href" => x)
    [<CustomOperation("ForceLoad")>] member _.ForceLoad (render: AttrRenderFragment, x: System.Boolean) = render ==> ("ForceLoad" => x)
    [<CustomOperation("AvatarClass")>] member _.AvatarClass (render: AttrRenderFragment, x: System.String) = render ==> ("AvatarClass" => x)
    [<CustomOperation("Disabled")>] member _.Disabled (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Disabled" => x)
    [<CustomOperation("DisableRipple")>] member _.DisableRipple (render: AttrRenderFragment, x: System.Boolean) = render ==> ("DisableRipple" => x)
    [<CustomOperation("Icon")>] member _.Icon (render: AttrRenderFragment, x: System.String) = render ==> ("Icon" => x)
    [<CustomOperation("IconColor")>] member _.IconColor (render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("IconColor" => x)
    [<CustomOperation("IconSize")>] member _.IconSize (render: AttrRenderFragment, x: MudBlazor.Size) = render ==> ("IconSize" => x)
    [<CustomOperation("AdornmentColor")>] member _.AdornmentColor (render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("AdornmentColor" => x)
    [<CustomOperation("ExpandLessIcon")>] member _.ExpandLessIcon (render: AttrRenderFragment, x: System.String) = render ==> ("ExpandLessIcon" => x)
    [<CustomOperation("ExpandMoreIcon")>] member _.ExpandMoreIcon (render: AttrRenderFragment, x: System.String) = render ==> ("ExpandMoreIcon" => x)
    [<CustomOperation("Inset")>] member _.Inset (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Inset" => x)
    [<CustomOperation("Dense")>] member _.Dense (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Dense" => x)
    [<CustomOperation("DisableGutters")>] member _.DisableGutters (render: AttrRenderFragment, x: System.Boolean) = render ==> ("DisableGutters" => x)
    [<CustomOperation("Expanded")>] member _.Expanded (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Expanded" => x)
    [<CustomOperation("Expanded'")>] member _.Expanded' (render: AttrRenderFragment, value: IStore<System.Boolean>) = render ==> html.bind("Expanded", value)
    [<CustomOperation("Expanded'")>] member _.Expanded' (render: AttrRenderFragment, value: cval<System.Boolean>) = render ==> html.bind("Expanded", value)
    [<CustomOperation("Expanded'")>] member _.Expanded' (render: AttrRenderFragment, valueFn: System.Boolean * (System.Boolean -> unit)) = render ==> html.bind("Expanded", valueFn)
    [<CustomOperation("ExpandedChanged")>] member _.ExpandedChanged (render: AttrRenderFragment, fn) = render ==> html.callback<System.Boolean>("ExpandedChanged", fn)
    [<CustomOperation("InitiallyExpanded")>] member _.InitiallyExpanded (render: AttrRenderFragment, x: System.Boolean) = render ==> ("InitiallyExpanded" => x)
    [<CustomOperation("CommandParameter")>] member _.CommandParameter (render: AttrRenderFragment, x: System.Object) = render ==> ("CommandParameter" => x)
    [<CustomOperation("Command")>] member _.Command (render: AttrRenderFragment, x: System.Windows.Input.ICommand) = render ==> ("Command" => x)
    [<CustomOperation("NestedList")>] member _.NestedList (render: AttrRenderFragment, fragment) = render ==> html.renderFragment("NestedList", fragment)
    [<CustomOperation("NestedList")>] member _.NestedList (render: AttrRenderFragment, fragments) = render ==> html.renderFragment("NestedList", fragment { yield! fragments })
    [<CustomOperation("NestedList")>] member _.NestedList (render: AttrRenderFragment, x: string) = render ==> html.renderFragment("NestedList", html.text x)
    [<CustomOperation("NestedList")>] member _.NestedList (render: AttrRenderFragment, x: int) = render ==> html.renderFragment("NestedList", html.text x)
    [<CustomOperation("NestedList")>] member _.NestedList (render: AttrRenderFragment, x: float) = render ==> html.renderFragment("NestedList", html.text x)
    [<CustomOperation("OnClick")>] member _.OnClick (render: AttrRenderFragment, fn) = render ==> html.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>("OnClick", fn)
                

type MudListSubheaderBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    static member inline create (x: string) = MudListSubheaderBuilder<'FunBlazorGeneric>(){ x }
    static member inline create (x: NodeRenderFragment seq) = MudListSubheaderBuilder<'FunBlazorGeneric>(){ yield! x }
    [<CustomOperation("DisableGutters")>] member _.DisableGutters (render: AttrRenderFragment, x: System.Boolean) = render ==> ("DisableGutters" => x)
    [<CustomOperation("Inset")>] member _.Inset (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Inset" => x)
                

type MudMenuBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    static member inline create (x: string) = MudMenuBuilder<'FunBlazorGeneric>(){ x }
    static member inline create (x: NodeRenderFragment seq) = MudMenuBuilder<'FunBlazorGeneric>(){ yield! x }
    [<CustomOperation("Label")>] member _.Label (render: AttrRenderFragment, x: System.String) = render ==> ("Label" => x)
    [<CustomOperation("ListClass")>] member _.ListClass (render: AttrRenderFragment, x: System.String) = render ==> ("ListClass" => x)
    [<CustomOperation("PopoverClass")>] member _.PopoverClass (render: AttrRenderFragment, x: System.String) = render ==> ("PopoverClass" => x)
    [<CustomOperation("Icon")>] member _.Icon (render: AttrRenderFragment, x: System.String) = render ==> ("Icon" => x)
    [<CustomOperation("IconColor")>] member _.IconColor (render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("IconColor" => x)
    [<CustomOperation("StartIcon")>] member _.StartIcon (render: AttrRenderFragment, x: System.String) = render ==> ("StartIcon" => x)
    [<CustomOperation("EndIcon")>] member _.EndIcon (render: AttrRenderFragment, x: System.String) = render ==> ("EndIcon" => x)
    [<CustomOperation("Color")>] member _.Color (render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("Color" => x)
    [<CustomOperation("Size")>] member _.Size (render: AttrRenderFragment, x: MudBlazor.Size) = render ==> ("Size" => x)
    [<CustomOperation("Variant")>] member _.Variant (render: AttrRenderFragment, x: MudBlazor.Variant) = render ==> ("Variant" => x)
    [<CustomOperation("Dense")>] member _.Dense (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Dense" => x)
    [<CustomOperation("FullWidth")>] member _.FullWidth (render: AttrRenderFragment, x: System.Boolean) = render ==> ("FullWidth" => x)
    [<CustomOperation("MaxHeight")>] member _.MaxHeight (render: AttrRenderFragment, x: System.Nullable<System.Int32>) = render ==> ("MaxHeight" => x)
    [<CustomOperation("PositionAtCursor")>] member _.PositionAtCursor (render: AttrRenderFragment, x: System.Boolean) = render ==> ("PositionAtCursor" => x)
    [<CustomOperation("ActivatorContent")>] member _.ActivatorContent (render: AttrRenderFragment, fragment) = render ==> html.renderFragment("ActivatorContent", fragment)
    [<CustomOperation("ActivatorContent")>] member _.ActivatorContent (render: AttrRenderFragment, fragments) = render ==> html.renderFragment("ActivatorContent", fragment { yield! fragments })
    [<CustomOperation("ActivatorContent")>] member _.ActivatorContent (render: AttrRenderFragment, x: string) = render ==> html.renderFragment("ActivatorContent", html.text x)
    [<CustomOperation("ActivatorContent")>] member _.ActivatorContent (render: AttrRenderFragment, x: int) = render ==> html.renderFragment("ActivatorContent", html.text x)
    [<CustomOperation("ActivatorContent")>] member _.ActivatorContent (render: AttrRenderFragment, x: float) = render ==> html.renderFragment("ActivatorContent", html.text x)
    [<CustomOperation("ActivationEvent")>] member _.ActivationEvent (render: AttrRenderFragment, x: MudBlazor.MouseEvent) = render ==> ("ActivationEvent" => x)
    [<CustomOperation("AnchorOrigin")>] member _.AnchorOrigin (render: AttrRenderFragment, x: MudBlazor.Origin) = render ==> ("AnchorOrigin" => x)
    [<CustomOperation("TransformOrigin")>] member _.TransformOrigin (render: AttrRenderFragment, x: MudBlazor.Origin) = render ==> ("TransformOrigin" => x)
    [<CustomOperation("LockScroll")>] member _.LockScroll (render: AttrRenderFragment, x: System.Boolean) = render ==> ("LockScroll" => x)
    [<CustomOperation("Disabled")>] member _.Disabled (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Disabled" => x)
    [<CustomOperation("DisableRipple")>] member _.DisableRipple (render: AttrRenderFragment, x: System.Boolean) = render ==> ("DisableRipple" => x)
    [<CustomOperation("DisableElevation")>] member _.DisableElevation (render: AttrRenderFragment, x: System.Boolean) = render ==> ("DisableElevation" => x)
                

type MudMenuItemBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    static member inline create (x: string) = MudMenuItemBuilder<'FunBlazorGeneric>(){ x }
    static member inline create (x: NodeRenderFragment seq) = MudMenuItemBuilder<'FunBlazorGeneric>(){ yield! x }
    [<CustomOperation("Disabled")>] member _.Disabled (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Disabled" => x)
    [<CustomOperation("Link")>] member _.Link (render: AttrRenderFragment, x: System.String) = render ==> ("Link" => x)
    [<CustomOperation("Target")>] member _.Target (render: AttrRenderFragment, x: System.String) = render ==> ("Target" => x)
    [<CustomOperation("ForceLoad")>] member _.ForceLoad (render: AttrRenderFragment, x: System.Boolean) = render ==> ("ForceLoad" => x)
    [<CustomOperation("Command")>] member _.Command (render: AttrRenderFragment, x: System.Windows.Input.ICommand) = render ==> ("Command" => x)
    [<CustomOperation("CommandParameter")>] member _.CommandParameter (render: AttrRenderFragment, x: System.Object) = render ==> ("CommandParameter" => x)
    [<CustomOperation("OnClick")>] member _.OnClick (render: AttrRenderFragment, fn) = render ==> html.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>("OnClick", fn)
                

type MudMessageBoxBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    static member inline create () = html.fromBuilder(MudMessageBoxBuilder<'FunBlazorGeneric>())
    [<CustomOperation("Title")>] member _.Title (render: AttrRenderFragment, x: System.String) = render ==> ("Title" => x)
    [<CustomOperation("TitleContent")>] member _.TitleContent (render: AttrRenderFragment, fragment) = render ==> html.renderFragment("TitleContent", fragment)
    [<CustomOperation("TitleContent")>] member _.TitleContent (render: AttrRenderFragment, fragments) = render ==> html.renderFragment("TitleContent", fragment { yield! fragments })
    [<CustomOperation("TitleContent")>] member _.TitleContent (render: AttrRenderFragment, x: string) = render ==> html.renderFragment("TitleContent", html.text x)
    [<CustomOperation("TitleContent")>] member _.TitleContent (render: AttrRenderFragment, x: int) = render ==> html.renderFragment("TitleContent", html.text x)
    [<CustomOperation("TitleContent")>] member _.TitleContent (render: AttrRenderFragment, x: float) = render ==> html.renderFragment("TitleContent", html.text x)
    [<CustomOperation("Message")>] member _.Message (render: AttrRenderFragment, x: System.String) = render ==> ("Message" => x)
    [<CustomOperation("MessageContent")>] member _.MessageContent (render: AttrRenderFragment, fragment) = render ==> html.renderFragment("MessageContent", fragment)
    [<CustomOperation("MessageContent")>] member _.MessageContent (render: AttrRenderFragment, fragments) = render ==> html.renderFragment("MessageContent", fragment { yield! fragments })
    [<CustomOperation("MessageContent")>] member _.MessageContent (render: AttrRenderFragment, x: string) = render ==> html.renderFragment("MessageContent", html.text x)
    [<CustomOperation("MessageContent")>] member _.MessageContent (render: AttrRenderFragment, x: int) = render ==> html.renderFragment("MessageContent", html.text x)
    [<CustomOperation("MessageContent")>] member _.MessageContent (render: AttrRenderFragment, x: float) = render ==> html.renderFragment("MessageContent", html.text x)
    [<CustomOperation("CancelText")>] member _.CancelText (render: AttrRenderFragment, x: System.String) = render ==> ("CancelText" => x)
    [<CustomOperation("CancelButton")>] member _.CancelButton (render: AttrRenderFragment, fragment) = render ==> html.renderFragment("CancelButton", fragment)
    [<CustomOperation("CancelButton")>] member _.CancelButton (render: AttrRenderFragment, fragments) = render ==> html.renderFragment("CancelButton", fragment { yield! fragments })
    [<CustomOperation("CancelButton")>] member _.CancelButton (render: AttrRenderFragment, x: string) = render ==> html.renderFragment("CancelButton", html.text x)
    [<CustomOperation("CancelButton")>] member _.CancelButton (render: AttrRenderFragment, x: int) = render ==> html.renderFragment("CancelButton", html.text x)
    [<CustomOperation("CancelButton")>] member _.CancelButton (render: AttrRenderFragment, x: float) = render ==> html.renderFragment("CancelButton", html.text x)
    [<CustomOperation("NoText")>] member _.NoText (render: AttrRenderFragment, x: System.String) = render ==> ("NoText" => x)
    [<CustomOperation("NoButton")>] member _.NoButton (render: AttrRenderFragment, fragment) = render ==> html.renderFragment("NoButton", fragment)
    [<CustomOperation("NoButton")>] member _.NoButton (render: AttrRenderFragment, fragments) = render ==> html.renderFragment("NoButton", fragment { yield! fragments })
    [<CustomOperation("NoButton")>] member _.NoButton (render: AttrRenderFragment, x: string) = render ==> html.renderFragment("NoButton", html.text x)
    [<CustomOperation("NoButton")>] member _.NoButton (render: AttrRenderFragment, x: int) = render ==> html.renderFragment("NoButton", html.text x)
    [<CustomOperation("NoButton")>] member _.NoButton (render: AttrRenderFragment, x: float) = render ==> html.renderFragment("NoButton", html.text x)
    [<CustomOperation("YesText")>] member _.YesText (render: AttrRenderFragment, x: System.String) = render ==> ("YesText" => x)
    [<CustomOperation("YesButton")>] member _.YesButton (render: AttrRenderFragment, fragment) = render ==> html.renderFragment("YesButton", fragment)
    [<CustomOperation("YesButton")>] member _.YesButton (render: AttrRenderFragment, fragments) = render ==> html.renderFragment("YesButton", fragment { yield! fragments })
    [<CustomOperation("YesButton")>] member _.YesButton (render: AttrRenderFragment, x: string) = render ==> html.renderFragment("YesButton", html.text x)
    [<CustomOperation("YesButton")>] member _.YesButton (render: AttrRenderFragment, x: int) = render ==> html.renderFragment("YesButton", html.text x)
    [<CustomOperation("YesButton")>] member _.YesButton (render: AttrRenderFragment, x: float) = render ==> html.renderFragment("YesButton", html.text x)
    [<CustomOperation("OnYes")>] member _.OnYes (render: AttrRenderFragment, fn) = render ==> html.callback<System.Boolean>("OnYes", fn)
    [<CustomOperation("OnNo")>] member _.OnNo (render: AttrRenderFragment, fn) = render ==> html.callback<System.Boolean>("OnNo", fn)
    [<CustomOperation("OnCancel")>] member _.OnCancel (render: AttrRenderFragment, fn) = render ==> html.callback<System.Boolean>("OnCancel", fn)
    [<CustomOperation("IsVisible")>] member _.IsVisible (render: AttrRenderFragment, x: System.Boolean) = render ==> ("IsVisible" => x)
    [<CustomOperation("IsVisible'")>] member _.IsVisible' (render: AttrRenderFragment, value: IStore<System.Boolean>) = render ==> html.bind("IsVisible", value)
    [<CustomOperation("IsVisible'")>] member _.IsVisible' (render: AttrRenderFragment, value: cval<System.Boolean>) = render ==> html.bind("IsVisible", value)
    [<CustomOperation("IsVisible'")>] member _.IsVisible' (render: AttrRenderFragment, valueFn: System.Boolean * (System.Boolean -> unit)) = render ==> html.bind("IsVisible", valueFn)
    [<CustomOperation("IsVisibleChanged")>] member _.IsVisibleChanged (render: AttrRenderFragment, fn) = render ==> html.callback<System.Boolean>("IsVisibleChanged", fn)
                

type MudNavGroupBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    static member inline create (x: string) = MudNavGroupBuilder<'FunBlazorGeneric>(){ x }
    static member inline create (x: NodeRenderFragment seq) = MudNavGroupBuilder<'FunBlazorGeneric>(){ yield! x }
    [<CustomOperation("Title")>] member _.Title (render: AttrRenderFragment, x: System.String) = render ==> ("Title" => x)
    [<CustomOperation("Icon")>] member _.Icon (render: AttrRenderFragment, x: System.String) = render ==> ("Icon" => x)
    [<CustomOperation("IconColor")>] member _.IconColor (render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("IconColor" => x)
    [<CustomOperation("Disabled")>] member _.Disabled (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Disabled" => x)
    [<CustomOperation("DisableRipple")>] member _.DisableRipple (render: AttrRenderFragment, x: System.Boolean) = render ==> ("DisableRipple" => x)
    [<CustomOperation("Expanded")>] member _.Expanded (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Expanded" => x)
    [<CustomOperation("Expanded'")>] member _.Expanded' (render: AttrRenderFragment, value: IStore<System.Boolean>) = render ==> html.bind("Expanded", value)
    [<CustomOperation("Expanded'")>] member _.Expanded' (render: AttrRenderFragment, value: cval<System.Boolean>) = render ==> html.bind("Expanded", value)
    [<CustomOperation("Expanded'")>] member _.Expanded' (render: AttrRenderFragment, valueFn: System.Boolean * (System.Boolean -> unit)) = render ==> html.bind("Expanded", valueFn)
    [<CustomOperation("ExpandedChanged")>] member _.ExpandedChanged (render: AttrRenderFragment, fn) = render ==> html.callback<System.Boolean>("ExpandedChanged", fn)
    [<CustomOperation("HideExpandIcon")>] member _.HideExpandIcon (render: AttrRenderFragment, x: System.Boolean) = render ==> ("HideExpandIcon" => x)
    [<CustomOperation("MaxHeight")>] member _.MaxHeight (render: AttrRenderFragment, x: System.Nullable<System.Int32>) = render ==> ("MaxHeight" => x)
    [<CustomOperation("ExpandIcon")>] member _.ExpandIcon (render: AttrRenderFragment, x: System.String) = render ==> ("ExpandIcon" => x)
                

type MudNavMenuBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    static member inline create (x: string) = MudNavMenuBuilder<'FunBlazorGeneric>(){ x }
    static member inline create (x: NodeRenderFragment seq) = MudNavMenuBuilder<'FunBlazorGeneric>(){ yield! x }
    [<CustomOperation("Color")>] member _.Color (render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("Color" => x)
    [<CustomOperation("Bordered")>] member _.Bordered (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Bordered" => x)
    [<CustomOperation("Rounded")>] member _.Rounded (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Rounded" => x)
    [<CustomOperation("Margin")>] member _.Margin (render: AttrRenderFragment, x: MudBlazor.Margin) = render ==> ("Margin" => x)
    [<CustomOperation("Dense")>] member _.Dense (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Dense" => x)
                

type MudOverlayBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    static member inline create (x: string) = MudOverlayBuilder<'FunBlazorGeneric>(){ x }
    static member inline create (x: NodeRenderFragment seq) = MudOverlayBuilder<'FunBlazorGeneric>(){ yield! x }
    [<CustomOperation("VisibleChanged")>] member _.VisibleChanged (render: AttrRenderFragment, fn) = render ==> html.callback<System.Boolean>("VisibleChanged", fn)
    [<CustomOperation("Visible")>] member _.Visible (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Visible" => x)
    [<CustomOperation("Visible'")>] member _.Visible' (render: AttrRenderFragment, value: IStore<System.Boolean>) = render ==> html.bind("Visible", value)
    [<CustomOperation("Visible'")>] member _.Visible' (render: AttrRenderFragment, value: cval<System.Boolean>) = render ==> html.bind("Visible", value)
    [<CustomOperation("Visible'")>] member _.Visible' (render: AttrRenderFragment, valueFn: System.Boolean * (System.Boolean -> unit)) = render ==> html.bind("Visible", valueFn)
    [<CustomOperation("AutoClose")>] member _.AutoClose (render: AttrRenderFragment, x: System.Boolean) = render ==> ("AutoClose" => x)
    [<CustomOperation("LockScroll")>] member _.LockScroll (render: AttrRenderFragment, x: System.Boolean) = render ==> ("LockScroll" => x)
    [<CustomOperation("LockScrollClass")>] member _.LockScrollClass (render: AttrRenderFragment, x: System.String) = render ==> ("LockScrollClass" => x)
    [<CustomOperation("DarkBackground")>] member _.DarkBackground (render: AttrRenderFragment, x: System.Boolean) = render ==> ("DarkBackground" => x)
    [<CustomOperation("LightBackground")>] member _.LightBackground (render: AttrRenderFragment, x: System.Boolean) = render ==> ("LightBackground" => x)
    [<CustomOperation("Absolute")>] member _.Absolute (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Absolute" => x)
    [<CustomOperation("ZIndex")>] member _.ZIndex (render: AttrRenderFragment, x: System.Int32) = render ==> ("ZIndex" => x)
    [<CustomOperation("CommandParameter")>] member _.CommandParameter (render: AttrRenderFragment, x: System.Object) = render ==> ("CommandParameter" => x)
    [<CustomOperation("Command")>] member _.Command (render: AttrRenderFragment, x: System.Windows.Input.ICommand) = render ==> ("Command" => x)
    [<CustomOperation("OnClick")>] member _.OnClick (render: AttrRenderFragment, fn) = render ==> html.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>("OnClick", fn)
                

type MudPageContentNavigationBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    static member inline create () = html.fromBuilder(MudPageContentNavigationBuilder<'FunBlazorGeneric>())
    [<CustomOperation("Headline")>] member _.Headline (render: AttrRenderFragment, x: System.String) = render ==> ("Headline" => x)
    [<CustomOperation("SectionClassSelector")>] member _.SectionClassSelector (render: AttrRenderFragment, x: System.String) = render ==> ("SectionClassSelector" => x)
    [<CustomOperation("ActivateFirstSectionAsDefault")>] member _.ActivateFirstSectionAsDefault (render: AttrRenderFragment, x: System.Boolean) = render ==> ("ActivateFirstSectionAsDefault" => x)
                

type MudPaginationBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    static member inline create () = html.fromBuilder(MudPaginationBuilder<'FunBlazorGeneric>())
    [<CustomOperation("Count")>] member _.Count (render: AttrRenderFragment, x: System.Int32) = render ==> ("Count" => x)
    [<CustomOperation("BoundaryCount")>] member _.BoundaryCount (render: AttrRenderFragment, x: System.Int32) = render ==> ("BoundaryCount" => x)
    [<CustomOperation("MiddleCount")>] member _.MiddleCount (render: AttrRenderFragment, x: System.Int32) = render ==> ("MiddleCount" => x)
    [<CustomOperation("Selected")>] member _.Selected (render: AttrRenderFragment, x: System.Int32) = render ==> ("Selected" => x)
    [<CustomOperation("Selected'")>] member _.Selected' (render: AttrRenderFragment, value: IStore<System.Int32>) = render ==> html.bind("Selected", value)
    [<CustomOperation("Selected'")>] member _.Selected' (render: AttrRenderFragment, value: cval<System.Int32>) = render ==> html.bind("Selected", value)
    [<CustomOperation("Selected'")>] member _.Selected' (render: AttrRenderFragment, valueFn: System.Int32 * (System.Int32 -> unit)) = render ==> html.bind("Selected", valueFn)
    [<CustomOperation("Variant")>] member _.Variant (render: AttrRenderFragment, x: MudBlazor.Variant) = render ==> ("Variant" => x)
    [<CustomOperation("Color")>] member _.Color (render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("Color" => x)
    [<CustomOperation("Rectangular")>] member _.Rectangular (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Rectangular" => x)
    [<CustomOperation("Size")>] member _.Size (render: AttrRenderFragment, x: MudBlazor.Size) = render ==> ("Size" => x)
    [<CustomOperation("DisableElevation")>] member _.DisableElevation (render: AttrRenderFragment, x: System.Boolean) = render ==> ("DisableElevation" => x)
    [<CustomOperation("Disabled")>] member _.Disabled (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Disabled" => x)
    [<CustomOperation("ShowFirstButton")>] member _.ShowFirstButton (render: AttrRenderFragment, x: System.Boolean) = render ==> ("ShowFirstButton" => x)
    [<CustomOperation("ShowLastButton")>] member _.ShowLastButton (render: AttrRenderFragment, x: System.Boolean) = render ==> ("ShowLastButton" => x)
    [<CustomOperation("ShowPreviousButton")>] member _.ShowPreviousButton (render: AttrRenderFragment, x: System.Boolean) = render ==> ("ShowPreviousButton" => x)
    [<CustomOperation("ShowNextButton")>] member _.ShowNextButton (render: AttrRenderFragment, x: System.Boolean) = render ==> ("ShowNextButton" => x)
    [<CustomOperation("ControlButtonClicked")>] member _.ControlButtonClicked (render: AttrRenderFragment, fn) = render ==> html.callback<MudBlazor.Page>("ControlButtonClicked", fn)
    [<CustomOperation("SelectedChanged")>] member _.SelectedChanged (render: AttrRenderFragment, fn) = render ==> html.callback<System.Int32>("SelectedChanged", fn)
    [<CustomOperation("FirstIcon")>] member _.FirstIcon (render: AttrRenderFragment, x: System.String) = render ==> ("FirstIcon" => x)
    [<CustomOperation("BeforeIcon")>] member _.BeforeIcon (render: AttrRenderFragment, x: System.String) = render ==> ("BeforeIcon" => x)
    [<CustomOperation("NextIcon")>] member _.NextIcon (render: AttrRenderFragment, x: System.String) = render ==> ("NextIcon" => x)
    [<CustomOperation("LastIcon")>] member _.LastIcon (render: AttrRenderFragment, x: System.String) = render ==> ("LastIcon" => x)
                

type MudPopoverBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    static member inline create (x: string) = MudPopoverBuilder<'FunBlazorGeneric>(){ x }
    static member inline create (x: NodeRenderFragment seq) = MudPopoverBuilder<'FunBlazorGeneric>(){ yield! x }
    [<CustomOperation("MaxHeight")>] member _.MaxHeight (render: AttrRenderFragment, x: System.Nullable<System.Int32>) = render ==> ("MaxHeight" => x)
    [<CustomOperation("Paper")>] member _.Paper (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Paper" => x)
    [<CustomOperation("Elevation")>] member _.Elevation (render: AttrRenderFragment, x: System.Int32) = render ==> ("Elevation" => x)
    [<CustomOperation("Square")>] member _.Square (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Square" => x)
    [<CustomOperation("Open")>] member _.Open (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Open" => x)
    [<CustomOperation("Fixed")>] member _.Fixed (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Fixed" => x)
    [<CustomOperation("Duration")>] member _.Duration (render: AttrRenderFragment, x: System.Double) = render ==> ("Duration" => x)
    [<CustomOperation("Delay'")>] member _.Delay' (render: AttrRenderFragment, x: System.Double) = render ==> ("Delay" => x)
    [<CustomOperation("AnchorOrigin")>] member _.AnchorOrigin (render: AttrRenderFragment, x: MudBlazor.Origin) = render ==> ("AnchorOrigin" => x)
    [<CustomOperation("TransformOrigin")>] member _.TransformOrigin (render: AttrRenderFragment, x: MudBlazor.Origin) = render ==> ("TransformOrigin" => x)
    [<CustomOperation("OverflowBehavior")>] member _.OverflowBehavior (render: AttrRenderFragment, x: MudBlazor.OverflowBehavior) = render ==> ("OverflowBehavior" => x)
    [<CustomOperation("RelativeWidth")>] member _.RelativeWidth (render: AttrRenderFragment, x: System.Boolean) = render ==> ("RelativeWidth" => x)
                

type MudProgressCircularBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    static member inline create () = html.fromBuilder(MudProgressCircularBuilder<'FunBlazorGeneric>())
    [<CustomOperation("Color")>] member _.Color (render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("Color" => x)
    [<CustomOperation("Size")>] member _.Size (render: AttrRenderFragment, x: MudBlazor.Size) = render ==> ("Size" => x)
    [<CustomOperation("Indeterminate")>] member _.Indeterminate (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Indeterminate" => x)
    [<CustomOperation("Min")>] member _.Min (render: AttrRenderFragment, x: System.Double) = render ==> ("Min" => x)
    [<CustomOperation("Max")>] member _.Max (render: AttrRenderFragment, x: System.Double) = render ==> ("Max" => x)
    [<CustomOperation("Value")>] member _.Value (render: AttrRenderFragment, x: System.Double) = render ==> ("Value" => x)
    [<CustomOperation("StrokeWidth")>] member _.StrokeWidth (render: AttrRenderFragment, x: System.Int32) = render ==> ("StrokeWidth" => x)
                

type MudProgressLinearBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    static member inline create (x: string) = MudProgressLinearBuilder<'FunBlazorGeneric>(){ x }
    static member inline create (x: NodeRenderFragment seq) = MudProgressLinearBuilder<'FunBlazorGeneric>(){ yield! x }
    [<CustomOperation("Color")>] member _.Color (render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("Color" => x)
    [<CustomOperation("Size")>] member _.Size (render: AttrRenderFragment, x: MudBlazor.Size) = render ==> ("Size" => x)
    [<CustomOperation("Indeterminate")>] member _.Indeterminate (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Indeterminate" => x)
    [<CustomOperation("Buffer")>] member _.Buffer (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Buffer" => x)
    [<CustomOperation("Rounded")>] member _.Rounded (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Rounded" => x)
    [<CustomOperation("Striped")>] member _.Striped (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Striped" => x)
    [<CustomOperation("Vertical")>] member _.Vertical (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Vertical" => x)
    [<CustomOperation("Min")>] member _.Min (render: AttrRenderFragment, x: System.Double) = render ==> ("Min" => x)
    [<CustomOperation("Max")>] member _.Max (render: AttrRenderFragment, x: System.Double) = render ==> ("Max" => x)
    [<CustomOperation("Value")>] member _.Value (render: AttrRenderFragment, x: System.Double) = render ==> ("Value" => x)
    [<CustomOperation("BufferValue")>] member _.BufferValue (render: AttrRenderFragment, x: System.Double) = render ==> ("BufferValue" => x)
                

type MudRadioBuilder<'FunBlazorGeneric, 'T when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    static member inline create (x: string) = MudRadioBuilder<'FunBlazorGeneric, 'T>(){ x }
    static member inline create (x: NodeRenderFragment seq) = MudRadioBuilder<'FunBlazorGeneric, 'T>(){ yield! x }
    [<CustomOperation("Color")>] member _.Color (render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("Color" => x)
    [<CustomOperation("Placement")>] member _.Placement (render: AttrRenderFragment, x: MudBlazor.Placement) = render ==> ("Placement" => x)
    [<CustomOperation("Option")>] member _.Option (render: AttrRenderFragment, x: 'T) = render ==> ("Option" => x)
    [<CustomOperation("Dense")>] member _.Dense (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Dense" => x)
    [<CustomOperation("Size")>] member _.Size (render: AttrRenderFragment, x: MudBlazor.Size) = render ==> ("Size" => x)
    [<CustomOperation("DisableRipple")>] member _.DisableRipple (render: AttrRenderFragment, x: System.Boolean) = render ==> ("DisableRipple" => x)
    [<CustomOperation("Disabled")>] member _.Disabled (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Disabled" => x)
                

type MudRatingBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    static member inline create () = html.fromBuilder(MudRatingBuilder<'FunBlazorGeneric>())
    [<CustomOperation("RatingItemsClass")>] member _.RatingItemsClass (render: AttrRenderFragment, x: System.String) = render ==> ("RatingItemsClass" => x)
    [<CustomOperation("RatingItemsStyle")>] member _.RatingItemsStyle (render: AttrRenderFragment, x: System.String) = render ==> ("RatingItemsStyle" => x)
    [<CustomOperation("Name")>] member _.Name (render: AttrRenderFragment, x: System.String) = render ==> ("Name" => x)
    [<CustomOperation("MaxValue")>] member _.MaxValue (render: AttrRenderFragment, x: System.Int32) = render ==> ("MaxValue" => x)
    [<CustomOperation("FullIcon")>] member _.FullIcon (render: AttrRenderFragment, x: System.String) = render ==> ("FullIcon" => x)
    [<CustomOperation("EmptyIcon")>] member _.EmptyIcon (render: AttrRenderFragment, x: System.String) = render ==> ("EmptyIcon" => x)
    [<CustomOperation("Color")>] member _.Color (render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("Color" => x)
    [<CustomOperation("Size")>] member _.Size (render: AttrRenderFragment, x: MudBlazor.Size) = render ==> ("Size" => x)
    [<CustomOperation("DisableRipple")>] member _.DisableRipple (render: AttrRenderFragment, x: System.Boolean) = render ==> ("DisableRipple" => x)
    [<CustomOperation("Disabled")>] member _.Disabled (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Disabled" => x)
    [<CustomOperation("ReadOnly")>] member _.ReadOnly (render: AttrRenderFragment, x: System.Boolean) = render ==> ("ReadOnly" => x)
    [<CustomOperation("SelectedValueChanged")>] member _.SelectedValueChanged (render: AttrRenderFragment, fn) = render ==> html.callback<System.Int32>("SelectedValueChanged", fn)
    [<CustomOperation("SelectedValue")>] member _.SelectedValue (render: AttrRenderFragment, x: System.Int32) = render ==> ("SelectedValue" => x)
    [<CustomOperation("SelectedValue'")>] member _.SelectedValue' (render: AttrRenderFragment, value: IStore<System.Int32>) = render ==> html.bind("SelectedValue", value)
    [<CustomOperation("SelectedValue'")>] member _.SelectedValue' (render: AttrRenderFragment, value: cval<System.Int32>) = render ==> html.bind("SelectedValue", value)
    [<CustomOperation("SelectedValue'")>] member _.SelectedValue' (render: AttrRenderFragment, valueFn: System.Int32 * (System.Int32 -> unit)) = render ==> html.bind("SelectedValue", valueFn)
    [<CustomOperation("HoveredValueChanged")>] member _.HoveredValueChanged (render: AttrRenderFragment, fn) = render ==> html.callback<System.Nullable<System.Int32>>("HoveredValueChanged", fn)
                

type MudRatingItemBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    static member inline create () = html.fromBuilder(MudRatingItemBuilder<'FunBlazorGeneric>())
    [<CustomOperation("ItemValue")>] member _.ItemValue (render: AttrRenderFragment, x: System.Int32) = render ==> ("ItemValue" => x)
    [<CustomOperation("Size")>] member _.Size (render: AttrRenderFragment, x: MudBlazor.Size) = render ==> ("Size" => x)
    [<CustomOperation("Color")>] member _.Color (render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("Color" => x)
    [<CustomOperation("DisableRipple")>] member _.DisableRipple (render: AttrRenderFragment, x: System.Boolean) = render ==> ("DisableRipple" => x)
    [<CustomOperation("Disabled")>] member _.Disabled (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Disabled" => x)
    [<CustomOperation("ReadOnly")>] member _.ReadOnly (render: AttrRenderFragment, x: System.Boolean) = render ==> ("ReadOnly" => x)
    [<CustomOperation("ItemClicked")>] member _.ItemClicked (render: AttrRenderFragment, fn) = render ==> html.callback<System.Int32>("ItemClicked", fn)
    [<CustomOperation("ItemHovered")>] member _.ItemHovered (render: AttrRenderFragment, fn) = render ==> html.callback<System.Nullable<System.Int32>>("ItemHovered", fn)
                

type MudRTLProviderBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    static member inline create (x: string) = MudRTLProviderBuilder<'FunBlazorGeneric>(){ x }
    static member inline create (x: NodeRenderFragment seq) = MudRTLProviderBuilder<'FunBlazorGeneric>(){ yield! x }
    [<CustomOperation("RightToLeft")>] member _.RightToLeft (render: AttrRenderFragment, x: System.Boolean) = render ==> ("RightToLeft" => x)
                

type MudScrollToTopBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    static member inline create (x: string) = MudScrollToTopBuilder<'FunBlazorGeneric>(){ x }
    static member inline create (x: NodeRenderFragment seq) = MudScrollToTopBuilder<'FunBlazorGeneric>(){ yield! x }
    [<CustomOperation("Selector")>] member _.Selector (render: AttrRenderFragment, x: System.String) = render ==> ("Selector" => x)
    [<CustomOperation("Visible")>] member _.Visible (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Visible" => x)
    [<CustomOperation("VisibleCssClass")>] member _.VisibleCssClass (render: AttrRenderFragment, x: System.String) = render ==> ("VisibleCssClass" => x)
    [<CustomOperation("HiddenCssClass")>] member _.HiddenCssClass (render: AttrRenderFragment, x: System.String) = render ==> ("HiddenCssClass" => x)
    [<CustomOperation("TopOffset")>] member _.TopOffset (render: AttrRenderFragment, x: System.Int32) = render ==> ("TopOffset" => x)
    [<CustomOperation("ScrollBehavior")>] member _.ScrollBehavior (render: AttrRenderFragment, x: MudBlazor.ScrollBehavior) = render ==> ("ScrollBehavior" => x)
    [<CustomOperation("OnScroll")>] member _.OnScroll (render: AttrRenderFragment, fn) = render ==> html.callback<MudBlazor.ScrollEventArgs>("OnScroll", fn)
                

type MudSkeletonBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    static member inline create () = html.fromBuilder(MudSkeletonBuilder<'FunBlazorGeneric>())
    [<CustomOperation("Width")>] member _.Width (render: AttrRenderFragment, x: System.String) = render ==> ("Width" => x)
    [<CustomOperation("Height")>] member _.Height (render: AttrRenderFragment, x: System.String) = render ==> ("Height" => x)
    [<CustomOperation("SkeletonType")>] member _.SkeletonType (render: AttrRenderFragment, x: MudBlazor.SkeletonType) = render ==> ("SkeletonType" => x)
    [<CustomOperation("Animation")>] member _.Animation (render: AttrRenderFragment, x: MudBlazor.Animation) = render ==> ("Animation" => x)
                

type MudSliderBuilder<'FunBlazorGeneric, 'T when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    static member inline create (x: string) = MudSliderBuilder<'FunBlazorGeneric, 'T>(){ x }
    static member inline create (x: NodeRenderFragment seq) = MudSliderBuilder<'FunBlazorGeneric, 'T>(){ yield! x }
    [<CustomOperation("Min")>] member _.Min (render: AttrRenderFragment, x: 'T) = render ==> ("Min" => x)
    [<CustomOperation("Max")>] member _.Max (render: AttrRenderFragment, x: 'T) = render ==> ("Max" => x)
    [<CustomOperation("Step")>] member _.Step (render: AttrRenderFragment, x: 'T) = render ==> ("Step" => x)
    [<CustomOperation("Disabled")>] member _.Disabled (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Disabled" => x)
    [<CustomOperation("Converter")>] member _.Converter (render: AttrRenderFragment, x: MudBlazor.Converter<'T>) = render ==> ("Converter" => x)
    [<CustomOperation("ValueChanged")>] member _.ValueChanged (render: AttrRenderFragment, fn) = render ==> html.callback<'T>("ValueChanged", fn)
    [<CustomOperation("Value")>] member _.Value (render: AttrRenderFragment, x: 'T) = render ==> ("Value" => x)
    [<CustomOperation("Value'")>] member _.Value' (render: AttrRenderFragment, value: IStore<'T>) = render ==> html.bind("Value", value)
    [<CustomOperation("Value'")>] member _.Value' (render: AttrRenderFragment, value: cval<'T>) = render ==> html.bind("Value", value)
    [<CustomOperation("Value'")>] member _.Value' (render: AttrRenderFragment, valueFn: 'T * ('T -> unit)) = render ==> html.bind("Value", valueFn)
    [<CustomOperation("Color")>] member _.Color (render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("Color" => x)
    [<CustomOperation("Immediate")>] member _.Immediate (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Immediate" => x)
                

type MudSnackbarElementBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    static member inline create () = html.fromBuilder(MudSnackbarElementBuilder<'FunBlazorGeneric>())
    [<CustomOperation("Snackbar")>] member _.Snackbar (render: AttrRenderFragment, x: MudBlazor.Snackbar) = render ==> ("Snackbar" => x)
    [<CustomOperation("CloseIcon")>] member _.CloseIcon (render: AttrRenderFragment, x: System.String) = render ==> ("CloseIcon" => x)
                

type MudSnackbarProviderBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    static member inline create () = html.fromBuilder(MudSnackbarProviderBuilder<'FunBlazorGeneric>())

                

type MudSwipeAreaBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    static member inline create (x: string) = MudSwipeAreaBuilder<'FunBlazorGeneric>(){ x }
    static member inline create (x: NodeRenderFragment seq) = MudSwipeAreaBuilder<'FunBlazorGeneric>(){ yield! x }
    [<CustomOperation("OnSwipe")>] member _.OnSwipe (render: AttrRenderFragment, fn) = render ==> ("OnSwipe" => (System.Action<MudBlazor.SwipeDirection>fn))
                

type MudSimpleTableBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    static member inline create (x: string) = MudSimpleTableBuilder<'FunBlazorGeneric>(){ x }
    static member inline create (x: NodeRenderFragment seq) = MudSimpleTableBuilder<'FunBlazorGeneric>(){ yield! x }
    [<CustomOperation("Elevation")>] member _.Elevation (render: AttrRenderFragment, x: System.Int32) = render ==> ("Elevation" => x)
    [<CustomOperation("Hover")>] member _.Hover (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Hover" => x)
    [<CustomOperation("Square")>] member _.Square (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Square" => x)
    [<CustomOperation("Dense")>] member _.Dense (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Dense" => x)
    [<CustomOperation("Outlined")>] member _.Outlined (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Outlined" => x)
    [<CustomOperation("Bordered")>] member _.Bordered (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Bordered" => x)
    [<CustomOperation("Striped")>] member _.Striped (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Striped" => x)
    [<CustomOperation("FixedHeader")>] member _.FixedHeader (render: AttrRenderFragment, x: System.Boolean) = render ==> ("FixedHeader" => x)
                

type MudTableGroupRowBuilder<'FunBlazorGeneric, 'T when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    static member inline create () = html.fromBuilder(MudTableGroupRowBuilder<'FunBlazorGeneric, 'T>())
    [<CustomOperation("GroupDefinition")>] member _.GroupDefinition (render: AttrRenderFragment, x: MudBlazor.TableGroupDefinition<'T>) = render ==> ("GroupDefinition" => x)
    [<CustomOperation("Items")>] member _.Items (render: AttrRenderFragment, x: System.Linq.IGrouping<System.Object, 'T>) = render ==> ("Items" => x)
    [<CustomOperation("HeaderTemplate")>] member _.HeaderTemplate (render: AttrRenderFragment, fn: MudBlazor.TableGroupData<System.Object, 'T> -> NodeRenderFragment) = render ==> html.renderFragment("HeaderTemplate", fn)
    [<CustomOperation("FooterTemplate")>] member _.FooterTemplate (render: AttrRenderFragment, fn: MudBlazor.TableGroupData<System.Object, 'T> -> NodeRenderFragment) = render ==> html.renderFragment("FooterTemplate", fn)
    [<CustomOperation("IsCheckable")>] member _.IsCheckable (render: AttrRenderFragment, x: System.Boolean) = render ==> ("IsCheckable" => x)
    [<CustomOperation("HeaderClass")>] member _.HeaderClass (render: AttrRenderFragment, x: System.String) = render ==> ("HeaderClass" => x)
    [<CustomOperation("FooterClass")>] member _.FooterClass (render: AttrRenderFragment, x: System.String) = render ==> ("FooterClass" => x)
    [<CustomOperation("HeaderStyle")>] member _.HeaderStyle (render: AttrRenderFragment, x: System.String) = render ==> ("HeaderStyle" => x)
    [<CustomOperation("FooterStyle")>] member _.FooterStyle (render: AttrRenderFragment, x: System.String) = render ==> ("FooterStyle" => x)
    [<CustomOperation("ExpandIcon")>] member _.ExpandIcon (render: AttrRenderFragment, x: System.String) = render ==> ("ExpandIcon" => x)
    [<CustomOperation("CollapseIcon")>] member _.CollapseIcon (render: AttrRenderFragment, x: System.String) = render ==> ("CollapseIcon" => x)
    [<CustomOperation("OnRowClick")>] member _.OnRowClick (render: AttrRenderFragment, fn) = render ==> html.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>("OnRowClick", fn)
                

type MudTablePagerBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    static member inline create () = html.fromBuilder(MudTablePagerBuilder<'FunBlazorGeneric>())
    [<CustomOperation("HideRowsPerPage")>] member _.HideRowsPerPage (render: AttrRenderFragment, x: System.Boolean) = render ==> ("HideRowsPerPage" => x)
    [<CustomOperation("HidePageNumber")>] member _.HidePageNumber (render: AttrRenderFragment, x: System.Boolean) = render ==> ("HidePageNumber" => x)
    [<CustomOperation("HidePagination")>] member _.HidePagination (render: AttrRenderFragment, x: System.Boolean) = render ==> ("HidePagination" => x)
    [<CustomOperation("HorizontalAlignment")>] member _.HorizontalAlignment (render: AttrRenderFragment, x: MudBlazor.HorizontalAlignment) = render ==> ("HorizontalAlignment" => x)
    [<CustomOperation("PageSizeOptions")>] member _.PageSizeOptions (render: AttrRenderFragment, x: System.Int32[]) = render ==> ("PageSizeOptions" => x)
    [<CustomOperation("InfoFormat")>] member _.InfoFormat (render: AttrRenderFragment, x: System.String) = render ==> ("InfoFormat" => x)
    [<CustomOperation("RowsPerPageString")>] member _.RowsPerPageString (render: AttrRenderFragment, x: System.String) = render ==> ("RowsPerPageString" => x)
    [<CustomOperation("FirstIcon")>] member _.FirstIcon (render: AttrRenderFragment, x: System.String) = render ==> ("FirstIcon" => x)
    [<CustomOperation("BeforeIcon")>] member _.BeforeIcon (render: AttrRenderFragment, x: System.String) = render ==> ("BeforeIcon" => x)
    [<CustomOperation("NextIcon")>] member _.NextIcon (render: AttrRenderFragment, x: System.String) = render ==> ("NextIcon" => x)
    [<CustomOperation("LastIcon")>] member _.LastIcon (render: AttrRenderFragment, x: System.String) = render ==> ("LastIcon" => x)
                

type MudTableSortLabelBuilder<'FunBlazorGeneric, 'T when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    static member inline create (x: string) = MudTableSortLabelBuilder<'FunBlazorGeneric, 'T>(){ x }
    static member inline create (x: NodeRenderFragment seq) = MudTableSortLabelBuilder<'FunBlazorGeneric, 'T>(){ yield! x }
    [<CustomOperation("InitialDirection")>] member _.InitialDirection (render: AttrRenderFragment, x: MudBlazor.SortDirection) = render ==> ("InitialDirection" => x)
    [<CustomOperation("Enabled")>] member _.Enabled (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Enabled" => x)
    [<CustomOperation("SortIcon")>] member _.SortIcon (render: AttrRenderFragment, x: System.String) = render ==> ("SortIcon" => x)
    [<CustomOperation("AppendIcon")>] member _.AppendIcon (render: AttrRenderFragment, x: System.Boolean) = render ==> ("AppendIcon" => x)
    [<CustomOperation("SortDirection")>] member _.SortDirection (render: AttrRenderFragment, x: MudBlazor.SortDirection) = render ==> ("SortDirection" => x)
    [<CustomOperation("SortDirection'")>] member _.SortDirection' (render: AttrRenderFragment, value: IStore<MudBlazor.SortDirection>) = render ==> html.bind("SortDirection", value)
    [<CustomOperation("SortDirection'")>] member _.SortDirection' (render: AttrRenderFragment, value: cval<MudBlazor.SortDirection>) = render ==> html.bind("SortDirection", value)
    [<CustomOperation("SortDirection'")>] member _.SortDirection' (render: AttrRenderFragment, valueFn: MudBlazor.SortDirection * (MudBlazor.SortDirection -> unit)) = render ==> html.bind("SortDirection", valueFn)
    [<CustomOperation("SortDirectionChanged")>] member _.SortDirectionChanged (render: AttrRenderFragment, fn) = render ==> html.callback<MudBlazor.SortDirection>("SortDirectionChanged", fn)
    [<CustomOperation("SortBy")>] member _.SortBy (render: AttrRenderFragment, fn) = render ==> ("SortBy" => (System.Func<'T, System.Object>fn))
    [<CustomOperation("SortLabel")>] member _.SortLabel (render: AttrRenderFragment, x: System.String) = render ==> ("SortLabel" => x)
                

type MudTdBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    static member inline create (x: string) = MudTdBuilder<'FunBlazorGeneric>(){ x }
    static member inline create (x: NodeRenderFragment seq) = MudTdBuilder<'FunBlazorGeneric>(){ yield! x }
    [<CustomOperation("DataLabel")>] member _.DataLabel (render: AttrRenderFragment, x: System.String) = render ==> ("DataLabel" => x)
    [<CustomOperation("HideSmall")>] member _.HideSmall (render: AttrRenderFragment, x: System.Boolean) = render ==> ("HideSmall" => x)
                

type MudTFootRowBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    static member inline create (x: string) = MudTFootRowBuilder<'FunBlazorGeneric>(){ x }
    static member inline create (x: NodeRenderFragment seq) = MudTFootRowBuilder<'FunBlazorGeneric>(){ yield! x }
    [<CustomOperation("IsCheckable")>] member _.IsCheckable (render: AttrRenderFragment, x: System.Boolean) = render ==> ("IsCheckable" => x)
    [<CustomOperation("IgnoreCheckbox")>] member _.IgnoreCheckbox (render: AttrRenderFragment, x: System.Boolean) = render ==> ("IgnoreCheckbox" => x)
    [<CustomOperation("IgnoreEditable")>] member _.IgnoreEditable (render: AttrRenderFragment, x: System.Boolean) = render ==> ("IgnoreEditable" => x)
    [<CustomOperation("IsExpandable")>] member _.IsExpandable (render: AttrRenderFragment, x: System.Boolean) = render ==> ("IsExpandable" => x)
    [<CustomOperation("OnRowClick")>] member _.OnRowClick (render: AttrRenderFragment, fn) = render ==> html.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>("OnRowClick", fn)
                

type MudThBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    static member inline create (x: string) = MudThBuilder<'FunBlazorGeneric>(){ x }
    static member inline create (x: NodeRenderFragment seq) = MudThBuilder<'FunBlazorGeneric>(){ yield! x }

                

type MudTHeadRowBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    static member inline create (x: string) = MudTHeadRowBuilder<'FunBlazorGeneric>(){ x }
    static member inline create (x: NodeRenderFragment seq) = MudTHeadRowBuilder<'FunBlazorGeneric>(){ yield! x }
    [<CustomOperation("IsCheckable")>] member _.IsCheckable (render: AttrRenderFragment, x: System.Boolean) = render ==> ("IsCheckable" => x)
    [<CustomOperation("IgnoreCheckbox")>] member _.IgnoreCheckbox (render: AttrRenderFragment, x: System.Boolean) = render ==> ("IgnoreCheckbox" => x)
    [<CustomOperation("IgnoreEditable")>] member _.IgnoreEditable (render: AttrRenderFragment, x: System.Boolean) = render ==> ("IgnoreEditable" => x)
    [<CustomOperation("IsExpandable")>] member _.IsExpandable (render: AttrRenderFragment, x: System.Boolean) = render ==> ("IsExpandable" => x)
    [<CustomOperation("OnRowClick")>] member _.OnRowClick (render: AttrRenderFragment, fn) = render ==> html.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>("OnRowClick", fn)
                

type MudTrBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    static member inline create (x: string) = MudTrBuilder<'FunBlazorGeneric>(){ x }
    static member inline create (x: NodeRenderFragment seq) = MudTrBuilder<'FunBlazorGeneric>(){ yield! x }
    [<CustomOperation("Item")>] member _.Item (render: AttrRenderFragment, x: System.Object) = render ==> ("Item" => x)
    [<CustomOperation("IsCheckable")>] member _.IsCheckable (render: AttrRenderFragment, x: System.Boolean) = render ==> ("IsCheckable" => x)
    [<CustomOperation("IsEditable")>] member _.IsEditable (render: AttrRenderFragment, x: System.Boolean) = render ==> ("IsEditable" => x)
    [<CustomOperation("IsEditing")>] member _.IsEditing (render: AttrRenderFragment, x: System.Boolean) = render ==> ("IsEditing" => x)
    [<CustomOperation("IsEditSwitchBlocked")>] member _.IsEditSwitchBlocked (render: AttrRenderFragment, x: System.Boolean) = render ==> ("IsEditSwitchBlocked" => x)
    [<CustomOperation("IsExpandable")>] member _.IsExpandable (render: AttrRenderFragment, x: System.Boolean) = render ==> ("IsExpandable" => x)
    [<CustomOperation("IsHeader")>] member _.IsHeader (render: AttrRenderFragment, x: System.Boolean) = render ==> ("IsHeader" => x)
    [<CustomOperation("IsFooter")>] member _.IsFooter (render: AttrRenderFragment, x: System.Boolean) = render ==> ("IsFooter" => x)
    [<CustomOperation("IsCheckedChanged")>] member _.IsCheckedChanged (render: AttrRenderFragment, fn) = render ==> html.callback<System.Boolean>("IsCheckedChanged", fn)
    [<CustomOperation("IsChecked")>] member _.IsChecked (render: AttrRenderFragment, x: System.Boolean) = render ==> ("IsChecked" => x)
    [<CustomOperation("IsChecked'")>] member _.IsChecked' (render: AttrRenderFragment, value: IStore<System.Boolean>) = render ==> html.bind("IsChecked", value)
    [<CustomOperation("IsChecked'")>] member _.IsChecked' (render: AttrRenderFragment, value: cval<System.Boolean>) = render ==> html.bind("IsChecked", value)
    [<CustomOperation("IsChecked'")>] member _.IsChecked' (render: AttrRenderFragment, valueFn: System.Boolean * (System.Boolean -> unit)) = render ==> html.bind("IsChecked", valueFn)
                

type MudTimelineItemBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    static member inline create (x: string) = MudTimelineItemBuilder<'FunBlazorGeneric>(){ x }
    static member inline create (x: NodeRenderFragment seq) = MudTimelineItemBuilder<'FunBlazorGeneric>(){ yield! x }
    [<CustomOperation("Icon")>] member _.Icon (render: AttrRenderFragment, x: System.String) = render ==> ("Icon" => x)
    [<CustomOperation("Variant")>] member _.Variant (render: AttrRenderFragment, x: MudBlazor.Variant) = render ==> ("Variant" => x)
    [<CustomOperation("Color")>] member _.Color (render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("Color" => x)
    [<CustomOperation("Size")>] member _.Size (render: AttrRenderFragment, x: MudBlazor.Size) = render ==> ("Size" => x)
    [<CustomOperation("Elevation")>] member _.Elevation (render: AttrRenderFragment, x: System.Int32) = render ==> ("Elevation" => x)
    [<CustomOperation("TimelineAlign")>] member _.TimelineAlign (render: AttrRenderFragment, x: MudBlazor.TimelineAlign) = render ==> ("TimelineAlign" => x)
    [<CustomOperation("HideDot")>] member _.HideDot (render: AttrRenderFragment, x: System.Boolean) = render ==> ("HideDot" => x)
    [<CustomOperation("ItemOpposite")>] member _.ItemOpposite (render: AttrRenderFragment, fragment) = render ==> html.renderFragment("ItemOpposite", fragment)
    [<CustomOperation("ItemOpposite")>] member _.ItemOpposite (render: AttrRenderFragment, fragments) = render ==> html.renderFragment("ItemOpposite", fragment { yield! fragments })
    [<CustomOperation("ItemOpposite")>] member _.ItemOpposite (render: AttrRenderFragment, x: string) = render ==> html.renderFragment("ItemOpposite", html.text x)
    [<CustomOperation("ItemOpposite")>] member _.ItemOpposite (render: AttrRenderFragment, x: int) = render ==> html.renderFragment("ItemOpposite", html.text x)
    [<CustomOperation("ItemOpposite")>] member _.ItemOpposite (render: AttrRenderFragment, x: float) = render ==> html.renderFragment("ItemOpposite", html.text x)
    [<CustomOperation("ItemContent")>] member _.ItemContent (render: AttrRenderFragment, fragment) = render ==> html.renderFragment("ItemContent", fragment)
    [<CustomOperation("ItemContent")>] member _.ItemContent (render: AttrRenderFragment, fragments) = render ==> html.renderFragment("ItemContent", fragment { yield! fragments })
    [<CustomOperation("ItemContent")>] member _.ItemContent (render: AttrRenderFragment, x: string) = render ==> html.renderFragment("ItemContent", html.text x)
    [<CustomOperation("ItemContent")>] member _.ItemContent (render: AttrRenderFragment, x: int) = render ==> html.renderFragment("ItemContent", html.text x)
    [<CustomOperation("ItemContent")>] member _.ItemContent (render: AttrRenderFragment, x: float) = render ==> html.renderFragment("ItemContent", html.text x)
    [<CustomOperation("ItemDot")>] member _.ItemDot (render: AttrRenderFragment, fragment) = render ==> html.renderFragment("ItemDot", fragment)
    [<CustomOperation("ItemDot")>] member _.ItemDot (render: AttrRenderFragment, fragments) = render ==> html.renderFragment("ItemDot", fragment { yield! fragments })
    [<CustomOperation("ItemDot")>] member _.ItemDot (render: AttrRenderFragment, x: string) = render ==> html.renderFragment("ItemDot", html.text x)
    [<CustomOperation("ItemDot")>] member _.ItemDot (render: AttrRenderFragment, x: int) = render ==> html.renderFragment("ItemDot", html.text x)
    [<CustomOperation("ItemDot")>] member _.ItemDot (render: AttrRenderFragment, x: float) = render ==> html.renderFragment("ItemDot", html.text x)
                

type MudTooltipBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    static member inline create (x: string) = MudTooltipBuilder<'FunBlazorGeneric>(){ x }
    static member inline create (x: NodeRenderFragment seq) = MudTooltipBuilder<'FunBlazorGeneric>(){ yield! x }
    [<CustomOperation("Color")>] member _.Color (render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("Color" => x)
    [<CustomOperation("Text")>] member _.Text (render: AttrRenderFragment, x: System.String) = render ==> ("Text" => x)
    [<CustomOperation("Arrow")>] member _.Arrow (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Arrow" => x)
    [<CustomOperation("Duration")>] member _.Duration (render: AttrRenderFragment, x: System.Double) = render ==> ("Duration" => x)
    [<CustomOperation("Delay'")>] member _.Delay' (render: AttrRenderFragment, x: System.Double) = render ==> ("Delay" => x)
    [<CustomOperation("Placement")>] member _.Placement (render: AttrRenderFragment, x: MudBlazor.Placement) = render ==> ("Placement" => x)
    [<CustomOperation("TooltipContent")>] member _.TooltipContent (render: AttrRenderFragment, fragment) = render ==> html.renderFragment("TooltipContent", fragment)
    [<CustomOperation("TooltipContent")>] member _.TooltipContent (render: AttrRenderFragment, fragments) = render ==> html.renderFragment("TooltipContent", fragment { yield! fragments })
    [<CustomOperation("TooltipContent")>] member _.TooltipContent (render: AttrRenderFragment, x: string) = render ==> html.renderFragment("TooltipContent", html.text x)
    [<CustomOperation("TooltipContent")>] member _.TooltipContent (render: AttrRenderFragment, x: int) = render ==> html.renderFragment("TooltipContent", html.text x)
    [<CustomOperation("TooltipContent")>] member _.TooltipContent (render: AttrRenderFragment, x: float) = render ==> html.renderFragment("TooltipContent", html.text x)
    [<CustomOperation("Inline")>] member _.Inline (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Inline" => x)
    [<CustomOperation("IsVisible")>] member _.IsVisible (render: AttrRenderFragment, x: System.Boolean) = render ==> ("IsVisible" => x)
    [<CustomOperation("IsVisible'")>] member _.IsVisible' (render: AttrRenderFragment, value: IStore<System.Boolean>) = render ==> html.bind("IsVisible", value)
    [<CustomOperation("IsVisible'")>] member _.IsVisible' (render: AttrRenderFragment, value: cval<System.Boolean>) = render ==> html.bind("IsVisible", value)
    [<CustomOperation("IsVisible'")>] member _.IsVisible' (render: AttrRenderFragment, valueFn: System.Boolean * (System.Boolean -> unit)) = render ==> html.bind("IsVisible", valueFn)
    [<CustomOperation("IsVisibleChanged")>] member _.IsVisibleChanged (render: AttrRenderFragment, fn) = render ==> html.callback<System.Boolean>("IsVisibleChanged", fn)
                

type MudTreeViewBuilder<'FunBlazorGeneric, 'T when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    static member inline create (x: string) = MudTreeViewBuilder<'FunBlazorGeneric, 'T>(){ x }
    static member inline create (x: NodeRenderFragment seq) = MudTreeViewBuilder<'FunBlazorGeneric, 'T>(){ yield! x }
    [<CustomOperation("Color")>] member _.Color (render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("Color" => x)
    [<CustomOperation("CheckBoxColor")>] member _.CheckBoxColor (render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("CheckBoxColor" => x)
    [<CustomOperation("MultiSelection")>] member _.MultiSelection (render: AttrRenderFragment, x: System.Boolean) = render ==> ("MultiSelection" => x)
    [<CustomOperation("ExpandOnClick")>] member _.ExpandOnClick (render: AttrRenderFragment, x: System.Boolean) = render ==> ("ExpandOnClick" => x)
    [<CustomOperation("Hover")>] member _.Hover (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Hover" => x)
    [<CustomOperation("Dense")>] member _.Dense (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Dense" => x)
    [<CustomOperation("Height")>] member _.Height (render: AttrRenderFragment, x: System.String) = render ==> ("Height" => x)
    [<CustomOperation("MaxHeight")>] member _.MaxHeight (render: AttrRenderFragment, x: System.String) = render ==> ("MaxHeight" => x)
    [<CustomOperation("Width")>] member _.Width (render: AttrRenderFragment, x: System.String) = render ==> ("Width" => x)
    [<CustomOperation("Disabled")>] member _.Disabled (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Disabled" => x)
    [<CustomOperation("Items")>] member _.Items (render: AttrRenderFragment, x: System.Collections.Generic.HashSet<'T>) = render ==> ("Items" => x)
    [<CustomOperation("SelectedValueChanged")>] member _.SelectedValueChanged (render: AttrRenderFragment, fn) = render ==> html.callback<'T>("SelectedValueChanged", fn)
    [<CustomOperation("SelectedValuesChanged")>] member _.SelectedValuesChanged (render: AttrRenderFragment, fn) = render ==> html.callback<System.Collections.Generic.HashSet<'T>>("SelectedValuesChanged", fn)
    [<CustomOperation("ItemTemplate")>] member _.ItemTemplate (render: AttrRenderFragment, fn: 'T -> NodeRenderFragment) = render ==> html.renderFragment("ItemTemplate", fn)
    [<CustomOperation("ServerData")>] member _.ServerData (render: AttrRenderFragment, fn) = render ==> ("ServerData" => (System.Func<'T, System.Threading.Tasks.Task<System.Collections.Generic.HashSet<'T>>>fn))
                

type MudTreeViewItemBuilder<'FunBlazorGeneric, 'T when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    static member inline create (x: string) = MudTreeViewItemBuilder<'FunBlazorGeneric, 'T>(){ x }
    static member inline create (x: NodeRenderFragment seq) = MudTreeViewItemBuilder<'FunBlazorGeneric, 'T>(){ yield! x }
    [<CustomOperation("CheckedIcon")>] member _.CheckedIcon (render: AttrRenderFragment, x: System.String) = render ==> ("CheckedIcon" => x)
    [<CustomOperation("UncheckedIcon")>] member _.UncheckedIcon (render: AttrRenderFragment, x: System.String) = render ==> ("UncheckedIcon" => x)
    [<CustomOperation("Value")>] member _.Value (render: AttrRenderFragment, x: 'T) = render ==> ("Value" => x)
    [<CustomOperation("Culture")>] member _.Culture (render: AttrRenderFragment, x: System.Globalization.CultureInfo) = render ==> ("Culture" => x)
    [<CustomOperation("Text")>] member _.Text (render: AttrRenderFragment, x: System.String) = render ==> ("Text" => x)
    [<CustomOperation("TextTypo")>] member _.TextTypo (render: AttrRenderFragment, x: MudBlazor.Typo) = render ==> ("TextTypo" => x)
    [<CustomOperation("TextClass")>] member _.TextClass (render: AttrRenderFragment, x: System.String) = render ==> ("TextClass" => x)
    [<CustomOperation("EndText")>] member _.EndText (render: AttrRenderFragment, x: System.String) = render ==> ("EndText" => x)
    [<CustomOperation("EndTextTypo")>] member _.EndTextTypo (render: AttrRenderFragment, x: MudBlazor.Typo) = render ==> ("EndTextTypo" => x)
    [<CustomOperation("EndTextClass")>] member _.EndTextClass (render: AttrRenderFragment, x: System.String) = render ==> ("EndTextClass" => x)
    [<CustomOperation("Disabled")>] member _.Disabled (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Disabled" => x)
    [<CustomOperation("Content")>] member _.Content (render: AttrRenderFragment, fragment) = render ==> html.renderFragment("Content", fragment)
    [<CustomOperation("Content")>] member _.Content (render: AttrRenderFragment, fragments) = render ==> html.renderFragment("Content", fragment { yield! fragments })
    [<CustomOperation("Content")>] member _.Content (render: AttrRenderFragment, x: string) = render ==> html.renderFragment("Content", html.text x)
    [<CustomOperation("Content")>] member _.Content (render: AttrRenderFragment, x: int) = render ==> html.renderFragment("Content", html.text x)
    [<CustomOperation("Content")>] member _.Content (render: AttrRenderFragment, x: float) = render ==> html.renderFragment("Content", html.text x)
    [<CustomOperation("Items")>] member _.Items (render: AttrRenderFragment, x: System.Collections.Generic.HashSet<'T>) = render ==> ("Items" => x)
    [<CustomOperation("Command")>] member _.Command (render: AttrRenderFragment, x: System.Windows.Input.ICommand) = render ==> ("Command" => x)
    [<CustomOperation("Expanded")>] member _.Expanded (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Expanded" => x)
    [<CustomOperation("Expanded'")>] member _.Expanded' (render: AttrRenderFragment, value: IStore<System.Boolean>) = render ==> html.bind("Expanded", value)
    [<CustomOperation("Expanded'")>] member _.Expanded' (render: AttrRenderFragment, value: cval<System.Boolean>) = render ==> html.bind("Expanded", value)
    [<CustomOperation("Expanded'")>] member _.Expanded' (render: AttrRenderFragment, valueFn: System.Boolean * (System.Boolean -> unit)) = render ==> html.bind("Expanded", valueFn)
    [<CustomOperation("ExpandedChanged")>] member _.ExpandedChanged (render: AttrRenderFragment, fn) = render ==> html.callback<System.Boolean>("ExpandedChanged", fn)
    [<CustomOperation("Activated")>] member _.Activated (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Activated" => x)
    [<CustomOperation("Activated'")>] member _.Activated' (render: AttrRenderFragment, value: IStore<System.Boolean>) = render ==> html.bind("Activated", value)
    [<CustomOperation("Activated'")>] member _.Activated' (render: AttrRenderFragment, value: cval<System.Boolean>) = render ==> html.bind("Activated", value)
    [<CustomOperation("Activated'")>] member _.Activated' (render: AttrRenderFragment, valueFn: System.Boolean * (System.Boolean -> unit)) = render ==> html.bind("Activated", valueFn)
    [<CustomOperation("Selected")>] member _.Selected (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Selected" => x)
    [<CustomOperation("Selected'")>] member _.Selected' (render: AttrRenderFragment, value: IStore<System.Boolean>) = render ==> html.bind("Selected", value)
    [<CustomOperation("Selected'")>] member _.Selected' (render: AttrRenderFragment, value: cval<System.Boolean>) = render ==> html.bind("Selected", value)
    [<CustomOperation("Selected'")>] member _.Selected' (render: AttrRenderFragment, valueFn: System.Boolean * (System.Boolean -> unit)) = render ==> html.bind("Selected", valueFn)
    [<CustomOperation("Icon")>] member _.Icon (render: AttrRenderFragment, x: System.String) = render ==> ("Icon" => x)
    [<CustomOperation("IconColor")>] member _.IconColor (render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("IconColor" => x)
    [<CustomOperation("EndIcon")>] member _.EndIcon (render: AttrRenderFragment, x: System.String) = render ==> ("EndIcon" => x)
    [<CustomOperation("EndIconColor")>] member _.EndIconColor (render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("EndIconColor" => x)
    [<CustomOperation("ExpandedIcon")>] member _.ExpandedIcon (render: AttrRenderFragment, x: System.String) = render ==> ("ExpandedIcon" => x)
    [<CustomOperation("ExpandedIconColor")>] member _.ExpandedIconColor (render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("ExpandedIconColor" => x)
    [<CustomOperation("LoadingIcon")>] member _.LoadingIcon (render: AttrRenderFragment, x: System.String) = render ==> ("LoadingIcon" => x)
    [<CustomOperation("LoadingIconColor")>] member _.LoadingIconColor (render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("LoadingIconColor" => x)
    [<CustomOperation("ActivatedChanged")>] member _.ActivatedChanged (render: AttrRenderFragment, fn) = render ==> html.callback<System.Boolean>("ActivatedChanged", fn)
    [<CustomOperation("SelectedChanged")>] member _.SelectedChanged (render: AttrRenderFragment, fn) = render ==> html.callback<System.Boolean>("SelectedChanged", fn)
    [<CustomOperation("OnClick")>] member _.OnClick (render: AttrRenderFragment, fn) = render ==> html.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>("OnClick", fn)
                

type MudTextBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    static member inline create (x: string) = MudTextBuilder<'FunBlazorGeneric>(){ x }
    static member inline create (x: NodeRenderFragment seq) = MudTextBuilder<'FunBlazorGeneric>(){ yield! x }
    [<CustomOperation("Typo")>] member _.Typo (render: AttrRenderFragment, x: MudBlazor.Typo) = render ==> ("Typo" => x)
    [<CustomOperation("Align")>] member _.Align (render: AttrRenderFragment, x: MudBlazor.Align) = render ==> ("Align" => x)
    [<CustomOperation("Color")>] member _.Color (render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("Color" => x)
    [<CustomOperation("GutterBottom")>] member _.GutterBottom (render: AttrRenderFragment, x: System.Boolean) = render ==> ("GutterBottom" => x)
    [<CustomOperation("Inline")>] member _.Inline (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Inline" => x)
                

type MudContainerBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    static member inline create (x: string) = MudContainerBuilder<'FunBlazorGeneric>(){ x }
    static member inline create (x: NodeRenderFragment seq) = MudContainerBuilder<'FunBlazorGeneric>(){ yield! x }
    [<CustomOperation("Fixed")>] member _.Fixed (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Fixed" => x)
    [<CustomOperation("MaxWidth")>] member _.MaxWidth (render: AttrRenderFragment, x: MudBlazor.MaxWidth) = render ==> ("MaxWidth" => x)
                

type MudDividerBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    static member inline create () = html.fromBuilder(MudDividerBuilder<'FunBlazorGeneric>())
    [<CustomOperation("Absolute")>] member _.Absolute (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Absolute" => x)
    [<CustomOperation("FlexItem")>] member _.FlexItem (render: AttrRenderFragment, x: System.Boolean) = render ==> ("FlexItem" => x)
    [<CustomOperation("Light")>] member _.Light (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Light" => x)
    [<CustomOperation("Vertical")>] member _.Vertical (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Vertical" => x)
    [<CustomOperation("DividerType")>] member _.DividerType (render: AttrRenderFragment, x: MudBlazor.DividerType) = render ==> ("DividerType" => x)
                

type MudDrawerHeaderBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    static member inline create (x: string) = MudDrawerHeaderBuilder<'FunBlazorGeneric>(){ x }
    static member inline create (x: NodeRenderFragment seq) = MudDrawerHeaderBuilder<'FunBlazorGeneric>(){ yield! x }
    [<CustomOperation("Dense")>] member _.Dense (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Dense" => x)
    [<CustomOperation("LinkToIndex")>] member _.LinkToIndex (render: AttrRenderFragment, x: System.Boolean) = render ==> ("LinkToIndex" => x)
                

type MudGridBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    static member inline create (x: string) = MudGridBuilder<'FunBlazorGeneric>(){ x }
    static member inline create (x: NodeRenderFragment seq) = MudGridBuilder<'FunBlazorGeneric>(){ yield! x }
    [<CustomOperation("Spacing")>] member _.Spacing (render: AttrRenderFragment, x: System.Int32) = render ==> ("Spacing" => x)
    [<CustomOperation("Justify")>] member _.Justify (render: AttrRenderFragment, x: MudBlazor.Justify) = render ==> ("Justify" => x)
                

type MudItemBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    static member inline create (x: string) = MudItemBuilder<'FunBlazorGeneric>(){ x }
    static member inline create (x: NodeRenderFragment seq) = MudItemBuilder<'FunBlazorGeneric>(){ yield! x }
    [<CustomOperation("xs")>] member _.xs (render: AttrRenderFragment, x: System.Int32) = render ==> ("xs" => x)
    [<CustomOperation("sm")>] member _.sm (render: AttrRenderFragment, x: System.Int32) = render ==> ("sm" => x)
    [<CustomOperation("md")>] member _.md (render: AttrRenderFragment, x: System.Int32) = render ==> ("md" => x)
    [<CustomOperation("lg")>] member _.lg (render: AttrRenderFragment, x: System.Int32) = render ==> ("lg" => x)
    [<CustomOperation("xl")>] member _.xl (render: AttrRenderFragment, x: System.Int32) = render ==> ("xl" => x)
    [<CustomOperation("xxl")>] member _.xxl (render: AttrRenderFragment, x: System.Int32) = render ==> ("xxl" => x)
                

type MudHighlighterBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    static member inline create () = html.fromBuilder(MudHighlighterBuilder<'FunBlazorGeneric>())
    [<CustomOperation("Text")>] member _.Text (render: AttrRenderFragment, x: System.String) = render ==> ("Text" => x)
    [<CustomOperation("HighlightedText")>] member _.HighlightedText (render: AttrRenderFragment, x: System.String) = render ==> ("HighlightedText" => x)
    [<CustomOperation("CaseSensitive")>] member _.CaseSensitive (render: AttrRenderFragment, x: System.Boolean) = render ==> ("CaseSensitive" => x)
    [<CustomOperation("UntilNextBoundary")>] member _.UntilNextBoundary (render: AttrRenderFragment, x: System.Boolean) = render ==> ("UntilNextBoundary" => x)
                

type MudMainContentBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    static member inline create (x: string) = MudMainContentBuilder<'FunBlazorGeneric>(){ x }
    static member inline create (x: NodeRenderFragment seq) = MudMainContentBuilder<'FunBlazorGeneric>(){ yield! x }

                

type MudPaperBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    static member inline create (x: string) = MudPaperBuilder<'FunBlazorGeneric>(){ x }
    static member inline create (x: NodeRenderFragment seq) = MudPaperBuilder<'FunBlazorGeneric>(){ yield! x }
    [<CustomOperation("Elevation")>] member _.Elevation (render: AttrRenderFragment, x: System.Int32) = render ==> ("Elevation" => x)
    [<CustomOperation("Square")>] member _.Square (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Square" => x)
    [<CustomOperation("Outlined")>] member _.Outlined (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Outlined" => x)
    [<CustomOperation("Height")>] member _.Height (render: AttrRenderFragment, x: System.String) = render ==> ("Height" => x)
    [<CustomOperation("Width")>] member _.Width (render: AttrRenderFragment, x: System.String) = render ==> ("Width" => x)
    [<CustomOperation("MaxHeight")>] member _.MaxHeight (render: AttrRenderFragment, x: System.String) = render ==> ("MaxHeight" => x)
    [<CustomOperation("MaxWidth")>] member _.MaxWidth (render: AttrRenderFragment, x: System.String) = render ==> ("MaxWidth" => x)
    [<CustomOperation("MinHeight")>] member _.MinHeight (render: AttrRenderFragment, x: System.String) = render ==> ("MinHeight" => x)
    [<CustomOperation("MinWidth")>] member _.MinWidth (render: AttrRenderFragment, x: System.String) = render ==> ("MinWidth" => x)
                

type MudSparkLineBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    static member inline create () = html.fromBuilder(MudSparkLineBuilder<'FunBlazorGeneric>())
    [<CustomOperation("StrokeWidth")>] member _.StrokeWidth (render: AttrRenderFragment, x: System.Int32) = render ==> ("StrokeWidth" => x)
                

type MudTabPanelBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    static member inline create (x: string) = MudTabPanelBuilder<'FunBlazorGeneric>(){ x }
    static member inline create (x: NodeRenderFragment seq) = MudTabPanelBuilder<'FunBlazorGeneric>(){ yield! x }
    [<CustomOperation("Text")>] member _.Text (render: AttrRenderFragment, x: System.String) = render ==> ("Text" => x)
    [<CustomOperation("Icon")>] member _.Icon (render: AttrRenderFragment, x: System.String) = render ==> ("Icon" => x)
    [<CustomOperation("Disabled")>] member _.Disabled (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Disabled" => x)
    [<CustomOperation("BadgeData")>] member _.BadgeData (render: AttrRenderFragment, x: System.Object) = render ==> ("BadgeData" => x)
    [<CustomOperation("BadgeDot")>] member _.BadgeDot (render: AttrRenderFragment, x: System.Boolean) = render ==> ("BadgeDot" => x)
    [<CustomOperation("BadgeColor")>] member _.BadgeColor (render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("BadgeColor" => x)
    [<CustomOperation("ID")>] member _.ID (render: AttrRenderFragment, x: System.Object) = render ==> ("ID" => x)
    [<CustomOperation("OnClick")>] member _.OnClick (render: AttrRenderFragment, fn) = render ==> html.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>("OnClick", fn)
    [<CustomOperation("ToolTip")>] member _.ToolTip (render: AttrRenderFragment, x: System.String) = render ==> ("ToolTip" => x)
                

type MudToolBarBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    static member inline create (x: string) = MudToolBarBuilder<'FunBlazorGeneric>(){ x }
    static member inline create (x: NodeRenderFragment seq) = MudToolBarBuilder<'FunBlazorGeneric>(){ yield! x }
    [<CustomOperation("Dense")>] member _.Dense (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Dense" => x)
    [<CustomOperation("DisableGutters")>] member _.DisableGutters (render: AttrRenderFragment, x: System.Boolean) = render ==> ("DisableGutters" => x)
                

type MudBaseColumnBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAndChildAttrBuilder<'FunBlazorGeneric>()
    static member inline create () = html.fromBuilder(MudBaseColumnBuilder<'FunBlazorGeneric>())
    [<CustomOperation("Visible")>] member _.Visible (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Visible" => x)
    [<CustomOperation("HeaderText")>] member _.HeaderText (render: AttrRenderFragment, x: System.String) = render ==> ("HeaderText" => x)
                

type MudColumnBuilder<'FunBlazorGeneric, 'T when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudBaseColumnBuilder<'FunBlazorGeneric>()
    static member inline create () = html.fromBuilder(MudColumnBuilder<'FunBlazorGeneric, 'T>())
    [<CustomOperation("Value")>] member _.Value (render: AttrRenderFragment, x: 'T) = render ==> ("Value" => x)
    [<CustomOperation("Value'")>] member _.Value' (render: AttrRenderFragment, value: IStore<'T>) = render ==> html.bind("Value", value)
    [<CustomOperation("Value'")>] member _.Value' (render: AttrRenderFragment, value: cval<'T>) = render ==> html.bind("Value", value)
    [<CustomOperation("Value'")>] member _.Value' (render: AttrRenderFragment, valueFn: 'T * ('T -> unit)) = render ==> html.bind("Value", valueFn)
    [<CustomOperation("ValueChanged")>] member _.ValueChanged (render: AttrRenderFragment, fn) = render ==> html.callback<'T>("ValueChanged", fn)
    [<CustomOperation("FooterValue")>] member _.FooterValue (render: AttrRenderFragment, x: 'T) = render ==> ("FooterValue" => x)
    [<CustomOperation("FooterText")>] member _.FooterText (render: AttrRenderFragment, x: System.String) = render ==> ("FooterText" => x)
    [<CustomOperation("DataFormatString")>] member _.DataFormatString (render: AttrRenderFragment, x: System.String) = render ==> ("DataFormatString" => x)
    [<CustomOperation("ReadOnly")>] member _.ReadOnly (render: AttrRenderFragment, x: System.Boolean) = render ==> ("ReadOnly" => x)
                

type MudSortableColumnBuilder<'FunBlazorGeneric, 'T, 'ModelType when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudBaseColumnBuilder<'FunBlazorGeneric>()
    static member inline create () = html.fromBuilder(MudSortableColumnBuilder<'FunBlazorGeneric, 'T, 'ModelType>())
    [<CustomOperation("Value")>] member _.Value (render: AttrRenderFragment, x: 'T) = render ==> ("Value" => x)
    [<CustomOperation("Value'")>] member _.Value' (render: AttrRenderFragment, value: IStore<'T>) = render ==> html.bind("Value", value)
    [<CustomOperation("Value'")>] member _.Value' (render: AttrRenderFragment, value: cval<'T>) = render ==> html.bind("Value", value)
    [<CustomOperation("Value'")>] member _.Value' (render: AttrRenderFragment, valueFn: 'T * ('T -> unit)) = render ==> html.bind("Value", valueFn)
    [<CustomOperation("ValueChanged")>] member _.ValueChanged (render: AttrRenderFragment, fn) = render ==> html.callback<'T>("ValueChanged", fn)
    [<CustomOperation("FooterValue")>] member _.FooterValue (render: AttrRenderFragment, x: 'T) = render ==> ("FooterValue" => x)
    [<CustomOperation("FooterText")>] member _.FooterText (render: AttrRenderFragment, x: System.String) = render ==> ("FooterText" => x)
    [<CustomOperation("DataFormatString")>] member _.DataFormatString (render: AttrRenderFragment, x: System.String) = render ==> ("DataFormatString" => x)
    [<CustomOperation("ReadOnly")>] member _.ReadOnly (render: AttrRenderFragment, x: System.Boolean) = render ==> ("ReadOnly" => x)
    [<CustomOperation("SortLabel")>] member _.SortLabel (render: AttrRenderFragment, x: System.String) = render ==> ("SortLabel" => x)
    [<CustomOperation("SortBy")>] member _.SortBy (render: AttrRenderFragment, fn) = render ==> ("SortBy" => (System.Func<'ModelType, System.Object>fn))
                

type MudAvatarColumnBuilder<'FunBlazorGeneric, 'T when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudBaseColumnBuilder<'FunBlazorGeneric>()
    static member inline create () = html.fromBuilder(MudAvatarColumnBuilder<'FunBlazorGeneric, 'T>())
    [<CustomOperation("Value")>] member _.Value (render: AttrRenderFragment, x: 'T) = render ==> ("Value" => x)
                

type MudTemplateColumnBuilder<'FunBlazorGeneric, 'T when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudBaseColumnBuilder<'FunBlazorGeneric>()
    static member inline create () = html.fromBuilder(MudTemplateColumnBuilder<'FunBlazorGeneric, 'T>())
    [<CustomOperation("DataContext")>] member _.DataContext (render: AttrRenderFragment, x: 'T) = render ==> ("DataContext" => x)
    [<CustomOperation("Header")>] member _.Header (render: AttrRenderFragment, fn: 'T -> NodeRenderFragment) = render ==> html.renderFragment("Header", fn)
    [<CustomOperation("Row")>] member _.Row (render: AttrRenderFragment, fn: 'T -> NodeRenderFragment) = render ==> html.renderFragment("Row", fn)
    [<CustomOperation("Edit")>] member _.Edit (render: AttrRenderFragment, fn: 'T -> NodeRenderFragment) = render ==> html.renderFragment("Edit", fn)
    [<CustomOperation("Footer")>] member _.Footer (render: AttrRenderFragment, fn: 'T -> NodeRenderFragment) = render ==> html.renderFragment("Footer", fn)
                

type BaseMudThemeProviderBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAndChildAttrBuilder<'FunBlazorGeneric>()
    static member inline create () = html.fromBuilder(BaseMudThemeProviderBuilder<'FunBlazorGeneric>())
    [<CustomOperation("Theme")>] member _.Theme (render: AttrRenderFragment, x: MudBlazor.MudTheme) = render ==> ("Theme" => x)
    [<CustomOperation("DefaultScrollbar")>] member _.DefaultScrollbar (render: AttrRenderFragment, x: System.Boolean) = render ==> ("DefaultScrollbar" => x)
    [<CustomOperation("IsDarkMode")>] member _.IsDarkMode (render: AttrRenderFragment, x: System.Boolean) = render ==> ("IsDarkMode" => x)
    [<CustomOperation("IsDarkMode'")>] member _.IsDarkMode' (render: AttrRenderFragment, value: IStore<System.Boolean>) = render ==> html.bind("IsDarkMode", value)
    [<CustomOperation("IsDarkMode'")>] member _.IsDarkMode' (render: AttrRenderFragment, value: cval<System.Boolean>) = render ==> html.bind("IsDarkMode", value)
    [<CustomOperation("IsDarkMode'")>] member _.IsDarkMode' (render: AttrRenderFragment, valueFn: System.Boolean * (System.Boolean -> unit)) = render ==> html.bind("IsDarkMode", valueFn)
    [<CustomOperation("IsDarkModeChanged")>] member _.IsDarkModeChanged (render: AttrRenderFragment, fn) = render ==> html.callback<System.Boolean>("IsDarkModeChanged", fn)
                

type MudThemeProviderBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit BaseMudThemeProviderBuilder<'FunBlazorGeneric>()
    static member inline create () = html.fromBuilder(MudThemeProviderBuilder<'FunBlazorGeneric>())

                

type FilterBuilder<'FunBlazorGeneric, 'T when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAndChildAttrBuilder<'FunBlazorGeneric>()
    static member inline create () = html.fromBuilder(FilterBuilder<'FunBlazorGeneric, 'T>())
    [<CustomOperation("Id")>] member _.Id (render: AttrRenderFragment, x: System.Guid) = render ==> ("Id" => x)
    [<CustomOperation("Field")>] member _.Field (render: AttrRenderFragment, x: System.String) = render ==> ("Field" => x)
    [<CustomOperation("Field'")>] member _.Field' (render: AttrRenderFragment, value: IStore<System.String>) = render ==> html.bind("Field", value)
    [<CustomOperation("Field'")>] member _.Field' (render: AttrRenderFragment, value: cval<System.String>) = render ==> html.bind("Field", value)
    [<CustomOperation("Field'")>] member _.Field' (render: AttrRenderFragment, valueFn: System.String * (System.String -> unit)) = render ==> html.bind("Field", valueFn)
    [<CustomOperation("Operator")>] member _.Operator (render: AttrRenderFragment, x: System.String) = render ==> ("Operator" => x)
    [<CustomOperation("Operator'")>] member _.Operator' (render: AttrRenderFragment, value: IStore<System.String>) = render ==> html.bind("Operator", value)
    [<CustomOperation("Operator'")>] member _.Operator' (render: AttrRenderFragment, value: cval<System.String>) = render ==> html.bind("Operator", value)
    [<CustomOperation("Operator'")>] member _.Operator' (render: AttrRenderFragment, valueFn: System.String * (System.String -> unit)) = render ==> html.bind("Operator", valueFn)
    [<CustomOperation("Value")>] member _.Value (render: AttrRenderFragment, x: System.Object) = render ==> ("Value" => x)
    [<CustomOperation("Value'")>] member _.Value' (render: AttrRenderFragment, value: IStore<System.Object>) = render ==> html.bind("Value", value)
    [<CustomOperation("Value'")>] member _.Value' (render: AttrRenderFragment, value: cval<System.Object>) = render ==> html.bind("Value", value)
    [<CustomOperation("Value'")>] member _.Value' (render: AttrRenderFragment, valueFn: System.Object * (System.Object -> unit)) = render ==> html.bind("Value", valueFn)
    [<CustomOperation("FieldChanged")>] member _.FieldChanged (render: AttrRenderFragment, fn) = render ==> html.callback<System.String>("FieldChanged", fn)
    [<CustomOperation("OperatorChanged")>] member _.OperatorChanged (render: AttrRenderFragment, fn) = render ==> html.callback<System.String>("OperatorChanged", fn)
    [<CustomOperation("ValueChanged")>] member _.ValueChanged (render: AttrRenderFragment, fn) = render ==> html.callback<System.Object>("ValueChanged", fn)
                

type MudDialogProviderBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAndChildAttrBuilder<'FunBlazorGeneric>()
    static member inline create () = html.fromBuilder(MudDialogProviderBuilder<'FunBlazorGeneric>())
    [<CustomOperation("NoHeader")>] member _.NoHeader (render: AttrRenderFragment, x: System.Nullable<System.Boolean>) = render ==> ("NoHeader" => x)
    [<CustomOperation("CloseButton")>] member _.CloseButton (render: AttrRenderFragment, x: System.Nullable<System.Boolean>) = render ==> ("CloseButton" => x)
    [<CustomOperation("DisableBackdropClick")>] member _.DisableBackdropClick (render: AttrRenderFragment, x: System.Nullable<System.Boolean>) = render ==> ("DisableBackdropClick" => x)
    [<CustomOperation("CloseOnEscapeKey")>] member _.CloseOnEscapeKey (render: AttrRenderFragment, x: System.Nullable<System.Boolean>) = render ==> ("CloseOnEscapeKey" => x)
    [<CustomOperation("FullWidth")>] member _.FullWidth (render: AttrRenderFragment, x: System.Nullable<System.Boolean>) = render ==> ("FullWidth" => x)
    [<CustomOperation("Position")>] member _.Position (render: AttrRenderFragment, x: System.Nullable<MudBlazor.DialogPosition>) = render ==> ("Position" => x)
    [<CustomOperation("MaxWidth")>] member _.MaxWidth (render: AttrRenderFragment, x: System.Nullable<MudBlazor.MaxWidth>) = render ==> ("MaxWidth" => x)
                

type MudPopoverProviderBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAndChildAttrBuilder<'FunBlazorGeneric>()
    static member inline create () = html.fromBuilder(MudPopoverProviderBuilder<'FunBlazorGeneric>())

                

type MudVirtualizeBuilder<'FunBlazorGeneric, 'T when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAndChildAttrBuilder<'FunBlazorGeneric>()
    static member inline create () = html.fromBuilder(MudVirtualizeBuilder<'FunBlazorGeneric, 'T>())
    [<CustomOperation("IsEnabled")>] member _.IsEnabled (render: AttrRenderFragment, x: System.Boolean) = render ==> ("IsEnabled" => x)
    [<CustomOperation("ChildContent")>] member _.ChildContent (render: AttrRenderFragment, fn: 'T -> NodeRenderFragment) = render ==> html.renderFragment("ChildContent", fn)
    [<CustomOperation("Items")>] member _.Items (render: AttrRenderFragment, x: System.Collections.Generic.ICollection<'T>) = render ==> ("Items" => x)
                

type BreadcrumbLinkBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAndChildAttrBuilder<'FunBlazorGeneric>()
    static member inline create () = html.fromBuilder(BreadcrumbLinkBuilder<'FunBlazorGeneric>())
    [<CustomOperation("Item")>] member _.Item (render: AttrRenderFragment, x: MudBlazor.BreadcrumbItem) = render ==> ("Item" => x)
                

type BreadcrumbSeparatorBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAndChildAttrBuilder<'FunBlazorGeneric>()
    static member inline create () = html.fromBuilder(BreadcrumbSeparatorBuilder<'FunBlazorGeneric>())

                

type MudPickerContentBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAndChildAttrBuilder<'FunBlazorGeneric>()
    static member inline create (x: string) = MudPickerContentBuilder<'FunBlazorGeneric>(){ x }
    static member inline create (x: NodeRenderFragment seq) = MudPickerContentBuilder<'FunBlazorGeneric>(){ yield! x }
    [<CustomOperation("Classes")>] member _.Classes (render: AttrRenderFragment, x: string list) = render ==> html.classes x
    [<CustomOperation("childContent")>] member _.childContent (render: AttrRenderFragment, fragment) = render ==> html.renderFragment("ChildContent", fragment)
    [<CustomOperation("childContent")>] member _.childContent (render: AttrRenderFragment, fragments) = render ==> html.renderFragment("ChildContent", fragment { yield! fragments })
    [<CustomOperation("childContent")>] member _.childContent (render: AttrRenderFragment, x: string) = render ==> html.renderFragment("ChildContent", html.text x)
    [<CustomOperation("childContent")>] member _.childContent (render: AttrRenderFragment, x: int) = render ==> html.renderFragment("ChildContent", html.text x)
    [<CustomOperation("childContent")>] member _.childContent (render: AttrRenderFragment, x: float) = render ==> html.renderFragment("ChildContent", html.text x)
                

type MudPickerToolbarBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAndChildAttrBuilder<'FunBlazorGeneric>()
    static member inline create (x: string) = MudPickerToolbarBuilder<'FunBlazorGeneric>(){ x }
    static member inline create (x: NodeRenderFragment seq) = MudPickerToolbarBuilder<'FunBlazorGeneric>(){ yield! x }
    [<CustomOperation("Classes")>] member _.Classes (render: AttrRenderFragment, x: string list) = render ==> html.classes x
    [<CustomOperation("Styles")>] member _.Styles (render: AttrRenderFragment, x: (string * string) list) = render ==> html.styles x
    [<CustomOperation("DisableToolbar")>] member _.DisableToolbar (render: AttrRenderFragment, x: System.Boolean) = render ==> ("DisableToolbar" => x)
    [<CustomOperation("Orientation")>] member _.Orientation (render: AttrRenderFragment, x: MudBlazor.Orientation) = render ==> ("Orientation" => x)
    [<CustomOperation("Color")>] member _.Color (render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("Color" => x)
    [<CustomOperation("childContent")>] member _.childContent (render: AttrRenderFragment, fragment) = render ==> html.renderFragment("ChildContent", fragment)
    [<CustomOperation("childContent")>] member _.childContent (render: AttrRenderFragment, fragments) = render ==> html.renderFragment("ChildContent", fragment { yield! fragments })
    [<CustomOperation("childContent")>] member _.childContent (render: AttrRenderFragment, x: string) = render ==> html.renderFragment("ChildContent", html.text x)
    [<CustomOperation("childContent")>] member _.childContent (render: AttrRenderFragment, x: int) = render ==> html.renderFragment("ChildContent", html.text x)
    [<CustomOperation("childContent")>] member _.childContent (render: AttrRenderFragment, x: float) = render ==> html.renderFragment("ChildContent", html.text x)
                

type MudSpacerBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAndChildAttrBuilder<'FunBlazorGeneric>()
    static member inline create () = html.fromBuilder(MudSpacerBuilder<'FunBlazorGeneric>())

                

type MudTreeViewItemToggleButtonBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAndChildAttrBuilder<'FunBlazorGeneric>()
    static member inline create () = html.fromBuilder(MudTreeViewItemToggleButtonBuilder<'FunBlazorGeneric>())
    [<CustomOperation("Visible")>] member _.Visible (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Visible" => x)
    [<CustomOperation("Expanded")>] member _.Expanded (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Expanded" => x)
    [<CustomOperation("Expanded'")>] member _.Expanded' (render: AttrRenderFragment, value: IStore<System.Boolean>) = render ==> html.bind("Expanded", value)
    [<CustomOperation("Expanded'")>] member _.Expanded' (render: AttrRenderFragment, value: cval<System.Boolean>) = render ==> html.bind("Expanded", value)
    [<CustomOperation("Expanded'")>] member _.Expanded' (render: AttrRenderFragment, valueFn: System.Boolean * (System.Boolean -> unit)) = render ==> html.bind("Expanded", valueFn)
    [<CustomOperation("Loading")>] member _.Loading (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Loading" => x)
    [<CustomOperation("ExpandedChanged")>] member _.ExpandedChanged (render: AttrRenderFragment, fn) = render ==> html.callback<System.Boolean>("ExpandedChanged", fn)
    [<CustomOperation("LoadingIcon")>] member _.LoadingIcon (render: AttrRenderFragment, x: System.String) = render ==> ("LoadingIcon" => x)
    [<CustomOperation("LoadingIconColor")>] member _.LoadingIconColor (render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("LoadingIconColor" => x)
    [<CustomOperation("ExpandedIcon")>] member _.ExpandedIcon (render: AttrRenderFragment, x: System.String) = render ==> ("ExpandedIcon" => x)
    [<CustomOperation("ExpandedIconColor")>] member _.ExpandedIconColor (render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("ExpandedIconColor" => x)
                

type _ImportsBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAndChildAttrBuilder<'FunBlazorGeneric>()
    static member inline create () = html.fromBuilder(_ImportsBuilder<'FunBlazorGeneric>())

                
            
namespace rec MudBlazor.DslInternals.Internal

open FSharp.Data.Adaptive
open Fun.Blazor
open Fun.Blazor.Operators
open MudBlazor.DslInternals


type MudInputAdornmentBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAndChildAttrBuilder<'FunBlazorGeneric>()
    static member inline create () = html.fromBuilder(MudInputAdornmentBuilder<'FunBlazorGeneric>())
    [<CustomOperation("Classes")>] member _.Classes (render: AttrRenderFragment, x: string list) = render ==> html.classes x
    [<CustomOperation("Text")>] member _.Text (render: AttrRenderFragment, x: System.String) = render ==> ("Text" => x)
    [<CustomOperation("Icon")>] member _.Icon (render: AttrRenderFragment, x: System.String) = render ==> ("Icon" => x)
    [<CustomOperation("Edge")>] member _.Edge (render: AttrRenderFragment, x: MudBlazor.Edge) = render ==> ("Edge" => x)
    [<CustomOperation("Size")>] member _.Size (render: AttrRenderFragment, x: MudBlazor.Size) = render ==> ("Size" => x)
    [<CustomOperation("Color")>] member _.Color (render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("Color" => x)
    [<CustomOperation("AdornmentClick")>] member _.AdornmentClick (render: AttrRenderFragment, fn) = render ==> html.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>("AdornmentClick", fn)
                
            
namespace rec MudBlazor.DslInternals.Charts

open FSharp.Data.Adaptive
open Fun.Blazor
open Fun.Blazor.Operators
open MudBlazor.DslInternals


type FiltersBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAndChildAttrBuilder<'FunBlazorGeneric>()
    static member inline create () = html.fromBuilder(FiltersBuilder<'FunBlazorGeneric>())

                
            

// =======================================================================================================================

namespace MudBlazor

[<AutoOpen>]
module DslCE =

    open MudBlazor.DslInternals

    type MudComponentBase'() = inherit MudComponentBaseBuilder<MudBlazor.MudComponentBase>()
    type MudBaseButton'() = inherit MudBaseButtonBuilder<MudBlazor.MudBaseButton>()
    type MudButton'() = inherit MudButtonBuilder<MudBlazor.MudButton>()
    type MudFab'() = inherit MudFabBuilder<MudBlazor.MudFab>()
    type MudIconButton'() = inherit MudIconButtonBuilder<MudBlazor.MudIconButton>()
    type MudFileUploader'() = inherit MudFileUploaderBuilder<MudBlazor.MudFileUploader>()
    type MudDrawerContainer'() = inherit MudDrawerContainerBuilder<MudBlazor.MudDrawerContainer>()
    type MudLayout'() = inherit MudLayoutBuilder<MudBlazor.MudLayout>()
    type MudBaseSelectItem'() = inherit MudBaseSelectItemBuilder<MudBlazor.MudBaseSelectItem>()
    type MudNavLink'() = inherit MudNavLinkBuilder<MudBlazor.MudNavLink>()
    type MudSelectItem'<'T>() = inherit MudSelectItemBuilder<MudBlazor.MudSelectItem<'T>, 'T>()
    type MudTableBase'() = inherit MudTableBaseBuilder<MudBlazor.MudTableBase>()
    type MudTable'<'T>() = inherit MudTableBuilder<MudBlazor.MudTable<'T>, 'T>()
    type MudTabs'() = inherit MudTabsBuilder<MudBlazor.MudTabs>()
    type MudDynamicTabs'() = inherit MudDynamicTabsBuilder<MudBlazor.MudDynamicTabs>()
    type MudChartBase'() = inherit MudChartBaseBuilder<MudBlazor.MudChartBase>()
    type MudChart'() = inherit MudChartBuilder<MudBlazor.MudChart>()
    type MudBaseItemsControl'<'TChildComponent when 'TChildComponent :> MudBlazor.MudComponentBase>() = inherit MudBaseItemsControlBuilder<MudBlazor.MudBaseItemsControl<'TChildComponent>, 'TChildComponent>()
    type MudBaseBindableItemsControl'<'TChildComponent, 'TData when 'TChildComponent :> MudBlazor.MudComponentBase>() = inherit MudBaseBindableItemsControlBuilder<MudBlazor.MudBaseBindableItemsControl<'TChildComponent, 'TData>, 'TChildComponent, 'TData>()
    type MudCarousel'<'TData>() = inherit MudCarouselBuilder<MudBlazor.MudCarousel<'TData>, 'TData>()
    type MudTimeline'() = inherit MudTimelineBuilder<MudBlazor.MudTimeline>()
    type MudFormComponent'<'T, 'U>() = inherit MudFormComponentBuilder<MudBlazor.MudFormComponent<'T, 'U>, 'T, 'U>()
    type MudBaseInput'<'T>() = inherit MudBaseInputBuilder<MudBlazor.MudBaseInput<'T>, 'T>()
    type MudAutocomplete'<'T>() = inherit MudAutocompleteBuilder<MudBlazor.MudAutocomplete<'T>, 'T>()
    type MudDebouncedInput'<'T>() = inherit MudDebouncedInputBuilder<MudBlazor.MudDebouncedInput<'T>, 'T>()
    type MudNumericField'<'T>() = inherit MudNumericFieldBuilder<MudBlazor.MudNumericField<'T>, 'T>()
    type MudTextField'<'T>() = inherit MudTextFieldBuilder<MudBlazor.MudTextField<'T>, 'T>()
    type MudInput'<'T>() = inherit MudInputBuilder<MudBlazor.MudInput<'T>, 'T>()
    type MudInputString'() = inherit MudInputStringBuilder<MudBlazor.MudInputString>()
    type MudRangeInput'<'T>() = inherit MudRangeInputBuilder<MudBlazor.MudRangeInput<'T>, 'T>()
    type MudSelect'<'T>() = inherit MudSelectBuilder<MudBlazor.MudSelect<'T>, 'T>()
    type MudBooleanInput'<'T>() = inherit MudBooleanInputBuilder<MudBlazor.MudBooleanInput<'T>, 'T>()
    type MudCheckBox'<'T>() = inherit MudCheckBoxBuilder<MudBlazor.MudCheckBox<'T>, 'T>()
    type MudSwitch'<'T>() = inherit MudSwitchBuilder<MudBlazor.MudSwitch<'T>, 'T>()
    type MudPicker'<'T>() = inherit MudPickerBuilder<MudBlazor.MudPicker<'T>, 'T>()
    type MudBaseDatePicker'() = inherit MudBaseDatePickerBuilder<MudBlazor.MudBaseDatePicker>()
    type MudDatePicker'() = inherit MudDatePickerBuilder<MudBlazor.MudDatePicker>()
    type MudDateRangePicker'() = inherit MudDateRangePickerBuilder<MudBlazor.MudDateRangePicker>()
    type MudColorPicker'() = inherit MudColorPickerBuilder<MudBlazor.MudColorPicker>()
    type MudTimePicker'() = inherit MudTimePickerBuilder<MudBlazor.MudTimePicker>()
    type MudRadioGroup'<'T>() = inherit MudRadioGroupBuilder<MudBlazor.MudRadioGroup<'T>, 'T>()
    type MudAlert'() = inherit MudAlertBuilder<MudBlazor.MudAlert>()
    type MudAppBar'() = inherit MudAppBarBuilder<MudBlazor.MudAppBar>()
    type MudAvatar'() = inherit MudAvatarBuilder<MudBlazor.MudAvatar>()
    type MudAvatarGroup'() = inherit MudAvatarGroupBuilder<MudBlazor.MudAvatarGroup>()
    type MudBadge'() = inherit MudBadgeBuilder<MudBlazor.MudBadge>()
    type MudBreadcrumbs'() = inherit MudBreadcrumbsBuilder<MudBlazor.MudBreadcrumbs>()
    type MudBreakpointProvider'() = inherit MudBreakpointProviderBuilder<MudBlazor.MudBreakpointProvider>()
    type MudButtonGroup'() = inherit MudButtonGroupBuilder<MudBlazor.MudButtonGroup>()
    type MudToggleIconButton'() = inherit MudToggleIconButtonBuilder<MudBlazor.MudToggleIconButton>()
    type MudCard'() = inherit MudCardBuilder<MudBlazor.MudCard>()
    type MudCardActions'() = inherit MudCardActionsBuilder<MudBlazor.MudCardActions>()
    type MudCardContent'() = inherit MudCardContentBuilder<MudBlazor.MudCardContent>()
    type MudCardHeader'() = inherit MudCardHeaderBuilder<MudBlazor.MudCardHeader>()
    type MudCardMedia'() = inherit MudCardMediaBuilder<MudBlazor.MudCardMedia>()
    type MudCarouselItem'() = inherit MudCarouselItemBuilder<MudBlazor.MudCarouselItem>()
    type MudChipSet'() = inherit MudChipSetBuilder<MudBlazor.MudChipSet>()
    type MudChip'() = inherit MudChipBuilder<MudBlazor.MudChip>()
    type MudCollapse'() = inherit MudCollapseBuilder<MudBlazor.MudCollapse>()
    type Cell'<'T>() = inherit CellBuilder<MudBlazor.Cell<'T>, 'T>()
    type Column'<'T>() = inherit ColumnBuilder<MudBlazor.Column<'T>, 'T>()
    type FooterCell'<'T>() = inherit FooterCellBuilder<MudBlazor.FooterCell<'T>, 'T>()
    type HeaderCell'<'T>() = inherit HeaderCellBuilder<MudBlazor.HeaderCell<'T>, 'T>()
    type MudDataGrid'<'T>() = inherit MudDataGridBuilder<MudBlazor.MudDataGrid<'T>, 'T>()
    type MudDataGridPager'<'T>() = inherit MudDataGridPagerBuilder<MudBlazor.MudDataGridPager<'T>, 'T>()
    type Row'() = inherit RowBuilder<MudBlazor.Row>()
    type MudDialog'() = inherit MudDialogBuilder<MudBlazor.MudDialog>()
    type MudDialogInstance'() = inherit MudDialogInstanceBuilder<MudBlazor.MudDialogInstance>()
    type MudDrawer'() = inherit MudDrawerBuilder<MudBlazor.MudDrawer>()
    type MudElement'() = inherit MudElementBuilder<MudBlazor.MudElement>()
    type MudExpansionPanel'() = inherit MudExpansionPanelBuilder<MudBlazor.MudExpansionPanel>()
    type MudExpansionPanels'() = inherit MudExpansionPanelsBuilder<MudBlazor.MudExpansionPanels>()
    type MudField'() = inherit MudFieldBuilder<MudBlazor.MudField>()
    type MudFocusTrap'() = inherit MudFocusTrapBuilder<MudBlazor.MudFocusTrap>()
    type MudForm'() = inherit MudFormBuilder<MudBlazor.MudForm>()
    type MudHidden'() = inherit MudHiddenBuilder<MudBlazor.MudHidden>()
    type MudIcon'() = inherit MudIconBuilder<MudBlazor.MudIcon>()
    type MudInputControl'() = inherit MudInputControlBuilder<MudBlazor.MudInputControl>()
    type MudInputLabel'() = inherit MudInputLabelBuilder<MudBlazor.MudInputLabel>()
    type MudLink'() = inherit MudLinkBuilder<MudBlazor.MudLink>()
    type MudList'() = inherit MudListBuilder<MudBlazor.MudList>()
    type MudListItem'() = inherit MudListItemBuilder<MudBlazor.MudListItem>()
    type MudListSubheader'() = inherit MudListSubheaderBuilder<MudBlazor.MudListSubheader>()
    type MudMenu'() = inherit MudMenuBuilder<MudBlazor.MudMenu>()
    type MudMenuItem'() = inherit MudMenuItemBuilder<MudBlazor.MudMenuItem>()
    type MudMessageBox'() = inherit MudMessageBoxBuilder<MudBlazor.MudMessageBox>()
    type MudNavGroup'() = inherit MudNavGroupBuilder<MudBlazor.MudNavGroup>()
    type MudNavMenu'() = inherit MudNavMenuBuilder<MudBlazor.MudNavMenu>()
    type MudOverlay'() = inherit MudOverlayBuilder<MudBlazor.MudOverlay>()
    type MudPageContentNavigation'() = inherit MudPageContentNavigationBuilder<MudBlazor.MudPageContentNavigation>()
    type MudPagination'() = inherit MudPaginationBuilder<MudBlazor.MudPagination>()
    type MudPopover'() = inherit MudPopoverBuilder<MudBlazor.MudPopover>()
    type MudProgressCircular'() = inherit MudProgressCircularBuilder<MudBlazor.MudProgressCircular>()
    type MudProgressLinear'() = inherit MudProgressLinearBuilder<MudBlazor.MudProgressLinear>()
    type MudRadio'<'T>() = inherit MudRadioBuilder<MudBlazor.MudRadio<'T>, 'T>()
    type MudRating'() = inherit MudRatingBuilder<MudBlazor.MudRating>()
    type MudRatingItem'() = inherit MudRatingItemBuilder<MudBlazor.MudRatingItem>()
    type MudRTLProvider'() = inherit MudRTLProviderBuilder<MudBlazor.MudRTLProvider>()
    type MudScrollToTop'() = inherit MudScrollToTopBuilder<MudBlazor.MudScrollToTop>()
    type MudSkeleton'() = inherit MudSkeletonBuilder<MudBlazor.MudSkeleton>()
    type MudSlider'<'T>() = inherit MudSliderBuilder<MudBlazor.MudSlider<'T>, 'T>()
    type MudSnackbarElement'() = inherit MudSnackbarElementBuilder<MudBlazor.MudSnackbarElement>()
    type MudSnackbarProvider'() = inherit MudSnackbarProviderBuilder<MudBlazor.MudSnackbarProvider>()
    type MudSwipeArea'() = inherit MudSwipeAreaBuilder<MudBlazor.MudSwipeArea>()
    type MudSimpleTable'() = inherit MudSimpleTableBuilder<MudBlazor.MudSimpleTable>()
    type MudTableGroupRow'<'T>() = inherit MudTableGroupRowBuilder<MudBlazor.MudTableGroupRow<'T>, 'T>()
    type MudTablePager'() = inherit MudTablePagerBuilder<MudBlazor.MudTablePager>()
    type MudTableSortLabel'<'T>() = inherit MudTableSortLabelBuilder<MudBlazor.MudTableSortLabel<'T>, 'T>()
    type MudTd'() = inherit MudTdBuilder<MudBlazor.MudTd>()
    type MudTFootRow'() = inherit MudTFootRowBuilder<MudBlazor.MudTFootRow>()
    type MudTh'() = inherit MudThBuilder<MudBlazor.MudTh>()
    type MudTHeadRow'() = inherit MudTHeadRowBuilder<MudBlazor.MudTHeadRow>()
    type MudTr'() = inherit MudTrBuilder<MudBlazor.MudTr>()
    type MudTimelineItem'() = inherit MudTimelineItemBuilder<MudBlazor.MudTimelineItem>()
    type MudTooltip'() = inherit MudTooltipBuilder<MudBlazor.MudTooltip>()
    type MudTreeView'<'T>() = inherit MudTreeViewBuilder<MudBlazor.MudTreeView<'T>, 'T>()
    type MudTreeViewItem'<'T>() = inherit MudTreeViewItemBuilder<MudBlazor.MudTreeViewItem<'T>, 'T>()
    type MudText'() = inherit MudTextBuilder<MudBlazor.MudText>()
    type MudContainer'() = inherit MudContainerBuilder<MudBlazor.MudContainer>()
    type MudDivider'() = inherit MudDividerBuilder<MudBlazor.MudDivider>()
    type MudDrawerHeader'() = inherit MudDrawerHeaderBuilder<MudBlazor.MudDrawerHeader>()
    type MudGrid'() = inherit MudGridBuilder<MudBlazor.MudGrid>()
    type MudItem'() = inherit MudItemBuilder<MudBlazor.MudItem>()
    type MudHighlighter'() = inherit MudHighlighterBuilder<MudBlazor.MudHighlighter>()
    type MudMainContent'() = inherit MudMainContentBuilder<MudBlazor.MudMainContent>()
    type MudPaper'() = inherit MudPaperBuilder<MudBlazor.MudPaper>()
    type MudSparkLine'() = inherit MudSparkLineBuilder<MudBlazor.MudSparkLine>()
    type MudTabPanel'() = inherit MudTabPanelBuilder<MudBlazor.MudTabPanel>()
    type MudToolBar'() = inherit MudToolBarBuilder<MudBlazor.MudToolBar>()
    type MudBaseColumn'() = inherit MudBaseColumnBuilder<MudBlazor.MudBaseColumn>()
    type MudColumn'<'T>() = inherit MudColumnBuilder<MudBlazor.MudColumn<'T>, 'T>()
    type MudSortableColumn'<'T, 'ModelType>() = inherit MudSortableColumnBuilder<MudBlazor.MudSortableColumn<'T, 'ModelType>, 'T, 'ModelType>()
    type MudAvatarColumn'<'T>() = inherit MudAvatarColumnBuilder<MudBlazor.MudAvatarColumn<'T>, 'T>()
    type MudTemplateColumn'<'T>() = inherit MudTemplateColumnBuilder<MudBlazor.MudTemplateColumn<'T>, 'T>()
    type BaseMudThemeProvider'() = inherit BaseMudThemeProviderBuilder<MudBlazor.BaseMudThemeProvider>()
    type MudThemeProvider'() = inherit MudThemeProviderBuilder<MudBlazor.MudThemeProvider>()
    type Filter'<'T>() = inherit FilterBuilder<MudBlazor.Filter<'T>, 'T>()
    type MudDialogProvider'() = inherit MudDialogProviderBuilder<MudBlazor.MudDialogProvider>()
    type MudPopoverProvider'() = inherit MudPopoverProviderBuilder<MudBlazor.MudPopoverProvider>()
    type MudVirtualize'<'T>() = inherit MudVirtualizeBuilder<MudBlazor.MudVirtualize<'T>, 'T>()
    type BreadcrumbLink'() = inherit BreadcrumbLinkBuilder<MudBlazor.BreadcrumbLink>()
    type BreadcrumbSeparator'() = inherit BreadcrumbSeparatorBuilder<MudBlazor.BreadcrumbSeparator>()
    type MudPickerContent'() = inherit MudPickerContentBuilder<MudBlazor.MudPickerContent>()
    type MudPickerToolbar'() = inherit MudPickerToolbarBuilder<MudBlazor.MudPickerToolbar>()
    type MudSpacer'() = inherit MudSpacerBuilder<MudBlazor.MudSpacer>()
    type MudTreeViewItemToggleButton'() = inherit MudTreeViewItemToggleButtonBuilder<MudBlazor.MudTreeViewItemToggleButton>()
    type _Imports'() = inherit _ImportsBuilder<MudBlazor._Imports>()
            
namespace MudBlazor.Charts

[<AutoOpen>]
module DslCE =

    open MudBlazor.DslInternals.Charts

    type Bar'() = inherit BarBuilder<MudBlazor.Charts.Bar>()
    type Donut'() = inherit DonutBuilder<MudBlazor.Charts.Donut>()
    type Line'() = inherit LineBuilder<MudBlazor.Charts.Line>()
    type Pie'() = inherit PieBuilder<MudBlazor.Charts.Pie>()
    type Legend'() = inherit LegendBuilder<MudBlazor.Charts.Legend>()
    type Filters'() = inherit FiltersBuilder<MudBlazor.Charts.Filters>()
            
namespace MudBlazor.Internal

[<AutoOpen>]
module DslCE =

    open MudBlazor.DslInternals.Internal

    type MudInputAdornment'() = inherit MudInputAdornmentBuilder<MudBlazor.Internal.MudInputAdornment>()
            