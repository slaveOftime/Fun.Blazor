namespace rec Fun.Blazor.AntDesign.Internal

open Bolero
open Bolero.Html
open Fun.Blazor
open Fun.Blazor.Web.Internal


type affix<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.Affix>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<AntDesign.Affix>
    static member inline offsetBottom (x: System.Int32) = "OffsetBottom" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline offsetTop (x: System.Int32) = "OffsetTop" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline targetSelector (x: System.String) = "TargetSelector" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onChange fn = (Bolero.Html.attr.callback<System.Boolean> "OnChange" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type alert<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.Alert>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<AntDesign.Alert>
    static member inline afterClose fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "AfterClose" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline banner (x: System.Boolean) = "Banner" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline closable (x: System.Boolean) = "Closable" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline closeText (x: System.String) = "CloseText" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline description (x: System.String) = "Description" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline icon (x: Microsoft.AspNetCore.Components.RenderFragment) = "Icon" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline message (x: System.String) = "Message" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline messageTemplate (x: Microsoft.AspNetCore.Components.RenderFragment) = "MessageTemplate" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline showIcon (x: System.Nullable<System.Boolean>) = "ShowIcon" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline type' (x: System.String) = "Type" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onClose fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnClose" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type anchor<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.Anchor>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<AntDesign.Anchor>
    static member inline key (x: System.String) = "Key" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline affix (x: System.Boolean) = "Affix" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline bounds (x: System.Int32) = "Bounds" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline getContainer (x: System.Func<System.String>) = "GetContainer" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline offsetBottom (x: System.Nullable<System.Int32>) = "OffsetBottom" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline offsetTop (x: System.Nullable<System.Int32>) = "OffsetTop" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline showInkInFixed (x: System.Boolean) = "ShowInkInFixed" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onClick fn = (Bolero.Html.attr.callback<System.Tuple<Microsoft.AspNetCore.Components.Web.MouseEventArgs, AntDesign.AnchorLink>> "OnClick" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline getCurrentAnchor (x: System.Func<System.String>) = "GetCurrentAnchor" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline targetOffset (x: System.Nullable<System.Int32>) = "TargetOffset" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onChange fn = (Bolero.Html.attr.callback<System.String> "OnChange" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type anchorLink<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.AnchorLink>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<AntDesign.AnchorLink>
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline href (x: System.String) = "Href" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline title (x: System.String) = "Title" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline target (x: System.String) = "Target" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type autoComplete<'FunBlazorGeneric, 'TOption> =
    inherit antInputComponentBase<'FunBlazorGeneric, System.String>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.AutoComplete<'TOption>>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<AntDesign.AutoComplete<'TOption>>
    static member inline placeholder (x: System.String) = "Placeholder" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabled (x: System.Boolean) = "Disabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline defaultActiveFirstOption (x: System.Boolean) = "DefaultActiveFirstOption" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline backfill (x: System.Boolean) = "Backfill" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline options (x: System.Collections.Generic.IEnumerable<'TOption>) = "Options" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline optionDataItems (x: System.Collections.Generic.IEnumerable<AntDesign.AutoCompleteDataItem<'TOption>>) = "OptionDataItems" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onSelectionChange fn = (Bolero.Html.attr.callback<AntDesign.AutoCompleteOption> "OnSelectionChange" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onActiveChange fn = (Bolero.Html.attr.callback<AntDesign.AutoCompleteOption> "OnActiveChange" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onInput fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.ChangeEventArgs> "OnInput" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onPanelVisibleChange fn = (Bolero.Html.attr.callback<System.Boolean> "OnPanelVisibleChange" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline optionTemplate (x: Microsoft.AspNetCore.Components.RenderFragment<AntDesign.AutoCompleteDataItem<'TOption>>) = "OptionTemplate" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline optionFormat (x: System.Func<AntDesign.AutoCompleteDataItem<'TOption>, System.String>) = "OptionFormat" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline overlayTemplate (x: Microsoft.AspNetCore.Components.RenderFragment) = "OverlayTemplate" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline compareWith (x: System.Func<System.Object, System.Object, System.Boolean>) = "CompareWith" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline filterExpression (x: System.Func<AntDesign.AutoCompleteDataItem<'TOption>, System.String, System.Boolean>) = "FilterExpression" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline allowFilter (x: System.Boolean) = "AllowFilter" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline width (x: OneOf.OneOf<System.Nullable<System.Int32>, System.String>) = "Width" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline overlayClassName (x: System.String) = "OverlayClassName" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline overlayStyle (x: System.String) = "OverlayStyle" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline popupContainerSelector (x: System.String) = "PopupContainerSelector" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline selectedItem (x: AntDesign.AutoCompleteOption) = "SelectedItem" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline showPanel (x: System.Boolean) = "ShowPanel" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline additionalAttributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "AdditionalAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline value (x: System.String) = "Value" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valueChanged fn = (Bolero.Html.attr.callback<System.String> "ValueChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valueExpression (x: System.Linq.Expressions.Expression<System.Func<System.String>>) = "ValueExpression" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valuesExpression (x: System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.IEnumerable<System.String>>>) = "ValuesExpression" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline size (x: System.String) = "Size" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline cultureInfo (x: System.Globalization.CultureInfo) = "CultureInfo" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type autoCompleteInput<'FunBlazorGeneric, 'TValue> =
    inherit input<'FunBlazorGeneric, 'TValue>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.AutoCompleteInput<'TValue>>
    
    static member inline addOnBefore (x: Microsoft.AspNetCore.Components.RenderFragment) = "AddOnBefore" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline addOnAfter (x: Microsoft.AspNetCore.Components.RenderFragment) = "AddOnAfter" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline allowClear (x: System.Boolean) = "AllowClear" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline autoFocus (x: System.Boolean) = "AutoFocus" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline bordered (x: System.Boolean) = "Bordered" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline debounceMilliseconds (x: System.Int32) = "DebounceMilliseconds" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline defaultValue (x: 'TValue) = "DefaultValue" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabled (x: System.Boolean) = "Disabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline inputElementSuffixClass (x: System.String) = "InputElementSuffixClass" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline maxLength (x: System.Int32) = "MaxLength" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onBlur fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.FocusEventArgs> "OnBlur" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onChange fn = (Bolero.Html.attr.callback<'TValue> "OnChange" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onFocus fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.FocusEventArgs> "OnFocus" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onInput fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.ChangeEventArgs> "OnInput" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onkeyDown fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs> "OnkeyDown" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onkeyUp fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs> "OnkeyUp" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onMouseUp fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnMouseUp" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onPressEnter fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs> "OnPressEnter" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline placeholder (x: System.String) = "Placeholder" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline prefix (x: Microsoft.AspNetCore.Components.RenderFragment) = "Prefix" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline readOnly (x: System.Boolean) = "ReadOnly" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline suffix (x: Microsoft.AspNetCore.Components.RenderFragment) = "Suffix" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline type' (x: System.String) = "Type" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline wrapperStyle (x: System.String) = "WrapperStyle" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline additionalAttributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "AdditionalAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline value (x: 'TValue) = "Value" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valueChanged fn = (Bolero.Html.attr.callback<'TValue> "ValueChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valueExpression (x: System.Linq.Expressions.Expression<System.Func<'TValue>>) = "ValueExpression" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valuesExpression (x: System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.IEnumerable<'TValue>>>) = "ValuesExpression" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline size (x: System.String) = "Size" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline cultureInfo (x: System.Globalization.CultureInfo) = "CultureInfo" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type autoCompleteOptGroup<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.AutoCompleteOptGroup>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<AntDesign.AutoCompleteOptGroup>
    static member inline label (x: System.String) = "Label" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline labelFragment (x: Microsoft.AspNetCore.Components.RenderFragment) = "LabelFragment" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type autoCompleteOption<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.AutoCompleteOption>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<AntDesign.AutoCompleteOption>
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline value (x: System.Object) = "Value" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline label (x: System.String) = "Label" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabled (x: System.Boolean) = "Disabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline autoComplete (x: AntDesign.IAutoCompleteRef) = "AutoComplete" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type autoCompleteSearch<'FunBlazorGeneric> =
    inherit search<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.AutoCompleteSearch>
    
    static member inline classicSearchIcon (x: System.Boolean) = "ClassicSearchIcon" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline enterButton (x: OneOf.OneOf<System.Boolean, System.String>) = "EnterButton" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline loading (x: System.Boolean) = "Loading" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onSearch fn = (Bolero.Html.attr.callback<System.String> "OnSearch" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline addOnBefore (x: Microsoft.AspNetCore.Components.RenderFragment) = "AddOnBefore" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline addOnAfter (x: Microsoft.AspNetCore.Components.RenderFragment) = "AddOnAfter" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline allowClear (x: System.Boolean) = "AllowClear" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline autoFocus (x: System.Boolean) = "AutoFocus" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline bordered (x: System.Boolean) = "Bordered" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline debounceMilliseconds (x: System.Int32) = "DebounceMilliseconds" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline defaultValue (x: System.String) = "DefaultValue" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabled (x: System.Boolean) = "Disabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline inputElementSuffixClass (x: System.String) = "InputElementSuffixClass" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline maxLength (x: System.Int32) = "MaxLength" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onBlur fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.FocusEventArgs> "OnBlur" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onChange fn = (Bolero.Html.attr.callback<System.String> "OnChange" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onFocus fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.FocusEventArgs> "OnFocus" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onInput fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.ChangeEventArgs> "OnInput" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onkeyDown fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs> "OnkeyDown" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onkeyUp fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs> "OnkeyUp" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onMouseUp fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnMouseUp" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onPressEnter fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs> "OnPressEnter" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline placeholder (x: System.String) = "Placeholder" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline prefix (x: Microsoft.AspNetCore.Components.RenderFragment) = "Prefix" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline readOnly (x: System.Boolean) = "ReadOnly" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline suffix (x: Microsoft.AspNetCore.Components.RenderFragment) = "Suffix" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline type' (x: System.String) = "Type" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline wrapperStyle (x: System.String) = "WrapperStyle" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline additionalAttributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "AdditionalAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline value (x: System.String) = "Value" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valueChanged fn = (Bolero.Html.attr.callback<System.String> "ValueChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valueExpression (x: System.Linq.Expressions.Expression<System.Func<System.String>>) = "ValueExpression" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valuesExpression (x: System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.IEnumerable<System.String>>>) = "ValuesExpression" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline size (x: System.String) = "Size" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline cultureInfo (x: System.Globalization.CultureInfo) = "CultureInfo" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type avatar<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.Avatar>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<AntDesign.Avatar>
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline shape (x: System.String) = "Shape" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline size (x: System.String) = "Size" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline text (x: System.String) = "Text" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline src (x: System.String) = "Src" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline srcSet (x: System.String) = "SrcSet" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline alt (x: System.String) = "Alt" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline icon (x: System.String) = "Icon" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onError fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.ErrorEventArgs> "OnError" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type avatarGroup<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.AvatarGroup>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<AntDesign.AvatarGroup>
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline maxCount (x: System.Int32) = "MaxCount" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline maxStyle (x: System.String) = "MaxStyle" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline maxPopoverPlacement (x: AntDesign.PlacementType) = "MaxPopoverPlacement" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type backTop<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.BackTop>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<AntDesign.BackTop>
    static member inline icon (x: System.String) = "Icon" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline visibilityHeight (x: System.Double) = "VisibilityHeight" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline targetSelector (x: System.String) = "TargetSelector" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onClick (x: Microsoft.AspNetCore.Components.EventCallback) = "OnClick" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type badge<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.Badge>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<AntDesign.Badge>
    static member inline color (x: System.String) = "Color" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline count (x: System.Nullable<System.Int32>) = "Count" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline countTemplate (x: Microsoft.AspNetCore.Components.RenderFragment) = "CountTemplate" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline dot (x: System.Boolean) = "Dot" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline offset (x: System.ValueTuple<System.Int32, System.Int32>) = "Offset" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline overflowCount (x: System.Int32) = "OverflowCount" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline showZero (x: System.Boolean) = "ShowZero" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline status (x: System.String) = "Status" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline text (x: System.String) = "Text" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline title (x: System.String) = "Title" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline size (x: System.String) = "Size" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type badgeRibbon<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.BadgeRibbon>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<AntDesign.BadgeRibbon>
    static member inline color (x: System.String) = "Color" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline text (x: System.String) = "Text" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline textTemplate (x: Microsoft.AspNetCore.Components.RenderFragment) = "TextTemplate" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline placement (x: System.String) = "Placement" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type breadcrumb<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.Breadcrumb>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<AntDesign.Breadcrumb>
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline autoGenerate (x: System.Boolean) = "AutoGenerate" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline separator (x: System.String) = "Separator" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline routeLabel (x: System.String) = "RouteLabel" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type button<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.Button>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<AntDesign.Button>
    static member inline block (x: System.Boolean) = "Block" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline danger (x: System.Boolean) = "Danger" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabled (x: System.Boolean) = "Disabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline ghost (x: System.Boolean) = "Ghost" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline htmlType (x: System.String) = "HtmlType" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline icon (x: System.String) = "Icon" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline loading (x: System.Boolean) = "Loading" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onClick fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnClick" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onClickStopPropagation (x: System.Boolean) = "OnClickStopPropagation" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline shape (x: System.String) = "Shape" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline size (x: System.String) = "Size" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline type' (x: System.String) = "Type" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type buttonGroup<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.ButtonGroup>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<AntDesign.ButtonGroup>
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline size (x: System.String) = "Size" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type calendar<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.Calendar>
    
    static member inline value (x: System.DateTime) = "Value" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline defaultValue (x: System.DateTime) = "DefaultValue" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline validRange (x: System.Collections.Generic.IEnumerable<System.DateTime>) = "ValidRange" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline mode (x: System.String) = "Mode" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline fullScreen (x: System.Boolean) = "FullScreen" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onSelect fn = (Bolero.Html.attr.callback<System.DateTime> "OnSelect" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onChange fn = (Bolero.Html.attr.callback<System.DateTime> "OnChange" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline headerRender (x: System.Func<AntDesign.CalendarHeaderRenderArgs, Microsoft.AspNetCore.Components.RenderFragment>) = "HeaderRender" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline dateCellRender (x: System.Func<System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "DateCellRender" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline dateFullCellRender (x: System.Func<System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "DateFullCellRender" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline monthCellRender (x: System.Func<System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "MonthCellRender" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline monthFullCellRender (x: System.Func<System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "MonthFullCellRender" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onPanelChange (x: System.Action<System.DateTime, System.String>) = "OnPanelChange" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabledDate (x: System.Func<System.DateTime, System.Boolean>) = "DisabledDate" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline locale (x: AntDesign.DatePickerLocale) = "Locale" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline cultureInfo (x: System.Globalization.CultureInfo) = "CultureInfo" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type card<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.Card>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<AntDesign.Card>
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline body (x: Microsoft.AspNetCore.Components.RenderFragment) = "Body" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline actionTemplate (x: Microsoft.AspNetCore.Components.RenderFragment) = "ActionTemplate" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline bordered (x: System.Boolean) = "Bordered" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline hoverable (x: System.Boolean) = "Hoverable" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline loading (x: System.Boolean) = "Loading" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline bodyStyle (x: System.String) = "BodyStyle" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline cover (x: Microsoft.AspNetCore.Components.RenderFragment) = "Cover" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline actions (x: System.Collections.Generic.IEnumerable<Microsoft.AspNetCore.Components.RenderFragment>) = "Actions" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline type' (x: System.String) = "Type" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline size (x: System.String) = "Size" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline title (x: System.String) = "Title" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline titleTemplate (x: Microsoft.AspNetCore.Components.RenderFragment) = "TitleTemplate" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline extra (x: Microsoft.AspNetCore.Components.RenderFragment) = "Extra" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline cardTabs (x: Microsoft.AspNetCore.Components.RenderFragment) = "CardTabs" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type cardAction<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.CardAction>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<AntDesign.CardAction>
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type cardGrid<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.CardGrid>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<AntDesign.CardGrid>
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline hoverable (x: System.Boolean) = "Hoverable" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type carousel<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.Carousel>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<AntDesign.Carousel>
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline dotPosition (x: System.String) = "DotPosition" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline autoplay (x: System.TimeSpan) = "Autoplay" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline effect (x: System.String) = "Effect" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type carouselSlick<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.CarouselSlick>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<AntDesign.CarouselSlick>
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type cascader<'FunBlazorGeneric> =
    inherit antInputComponentBase<'FunBlazorGeneric, System.String>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.Cascader>
    
    static member inline allowClear (x: System.Boolean) = "AllowClear" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline changeOnSelect (x: System.Boolean) = "ChangeOnSelect" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline defaultValue (x: System.String) = "DefaultValue" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline expandTrigger (x: System.String) = "ExpandTrigger" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline notFoundContent (x: System.String) = "NotFoundContent" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline placeholder (x: System.String) = "Placeholder" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline popupContainerSelector (x: System.String) = "PopupContainerSelector" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline showSearch (x: System.Boolean) = "ShowSearch" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onChange (x: System.Action<System.Collections.Generic.IEnumerable<AntDesign.CascaderNode>, System.String, System.String>) = "OnChange" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline selectedNodesChanged fn = (Bolero.Html.attr.callback<System.Collections.Generic.IEnumerable<AntDesign.CascaderNode>> "SelectedNodesChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline options (x: System.Collections.Generic.IEnumerable<AntDesign.CascaderNode>) = "Options" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline additionalAttributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "AdditionalAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline value (x: System.String) = "Value" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valueChanged fn = (Bolero.Html.attr.callback<System.String> "ValueChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valueExpression (x: System.Linq.Expressions.Expression<System.Func<System.String>>) = "ValueExpression" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valuesExpression (x: System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.IEnumerable<System.String>>>) = "ValuesExpression" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline size (x: System.String) = "Size" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline cultureInfo (x: System.Globalization.CultureInfo) = "CultureInfo" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type checkbox<'FunBlazorGeneric> =
    inherit antInputBoolComponentBase<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.Checkbox>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<AntDesign.Checkbox>
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline checkedChange fn = (Bolero.Html.attr.callback<System.Boolean> "CheckedChange" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline checkedExpression (x: System.Linq.Expressions.Expression<System.Func<System.Boolean>>) = "CheckedExpression" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline indeterminate (x: System.Boolean) = "Indeterminate" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline label (x: System.String) = "Label" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline autoFocus (x: System.Boolean) = "AutoFocus" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline checked' (x: System.Boolean) = "Checked" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onChange fn = (Bolero.Html.attr.callback<System.Boolean> "OnChange" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline checkedChanged fn = (Bolero.Html.attr.callback<System.Boolean> "CheckedChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabled (x: System.Boolean) = "Disabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline additionalAttributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "AdditionalAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline value (x: System.Boolean) = "Value" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valueChanged fn = (Bolero.Html.attr.callback<System.Boolean> "ValueChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valueExpression (x: System.Linq.Expressions.Expression<System.Func<System.Boolean>>) = "ValueExpression" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valuesExpression (x: System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.IEnumerable<System.Boolean>>>) = "ValuesExpression" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline size (x: System.String) = "Size" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline cultureInfo (x: System.Globalization.CultureInfo) = "CultureInfo" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type checkboxGroup<'FunBlazorGeneric> =
    inherit antInputComponentBase<'FunBlazorGeneric, System.Collections.Generic.IEnumerable<System.String>>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.CheckboxGroup>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<AntDesign.CheckboxGroup>
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline options (x: OneOf.OneOf<System.Collections.Generic.IEnumerable<AntDesign.CheckboxOption>, System.Collections.Generic.IEnumerable<System.String>>) = "Options" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline mixedMode (x: AntDesign.CheckboxGroupMixedMode) = "MixedMode" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onChange fn = (Bolero.Html.attr.callback<System.Collections.Generic.IEnumerable<System.String>> "OnChange" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabled (x: System.Boolean) = "Disabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline additionalAttributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "AdditionalAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline value (x: System.Collections.Generic.IEnumerable<System.String>) = "Value" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valueChanged fn = (Bolero.Html.attr.callback<System.Collections.Generic.IEnumerable<System.String>> "ValueChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valueExpression (x: System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.IEnumerable<System.String>>>) = "ValueExpression" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valuesExpression (x: System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.IEnumerable<System.Collections.Generic.IEnumerable<System.String>>>>) = "ValuesExpression" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline size (x: System.String) = "Size" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline cultureInfo (x: System.Globalization.CultureInfo) = "CultureInfo" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type collapse<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.Collapse>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<AntDesign.Collapse>
    static member inline accordion (x: System.Boolean) = "Accordion" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline bordered (x: System.Boolean) = "Bordered" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline expandIconPosition (x: System.String) = "ExpandIconPosition" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline defaultActiveKey (x: System.Collections.Generic.IEnumerable<System.String>) = "DefaultActiveKey" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onChange fn = (Bolero.Html.attr.callback<System.Collections.Generic.IEnumerable<System.String>> "OnChange" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline expandIcon (x: System.String) = "ExpandIcon" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline expandIconTemplate (x: Microsoft.AspNetCore.Components.RenderFragment<System.Boolean>) = "ExpandIconTemplate" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type panel<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.Panel>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<AntDesign.Panel>
    static member inline active (x: System.Boolean) = "Active" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline key (x: System.String) = "Key" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabled (x: System.Boolean) = "Disabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline showArrow (x: System.Boolean) = "ShowArrow" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline extra (x: System.String) = "Extra" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline extraTemplate (x: Microsoft.AspNetCore.Components.RenderFragment) = "ExtraTemplate" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline header (x: System.String) = "Header" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline headerTemplate (x: Microsoft.AspNetCore.Components.RenderFragment) = "HeaderTemplate" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onActiveChange fn = (Bolero.Html.attr.callback<System.Boolean> "OnActiveChange" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type comment<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.Comment>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<AntDesign.Comment>
    static member inline author (x: System.String) = "Author" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline authorTemplate (x: Microsoft.AspNetCore.Components.RenderFragment) = "AuthorTemplate" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline avatar (x: System.String) = "Avatar" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline avatarTemplate (x: Microsoft.AspNetCore.Components.RenderFragment) = "AvatarTemplate" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline content (x: System.String) = "Content" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline contentTemplate (x: Microsoft.AspNetCore.Components.RenderFragment) = "ContentTemplate" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline datetime (x: System.String) = "Datetime" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline datetimeTemplate (x: Microsoft.AspNetCore.Components.RenderFragment) = "DatetimeTemplate" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline actions (x: System.Collections.Generic.IEnumerable<Microsoft.AspNetCore.Components.RenderFragment>) = "Actions" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type configProvider<'FunBlazorGeneric> =
    inherit antComponentBase<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.ConfigProvider>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<AntDesign.ConfigProvider>
    static member inline direction (x: System.String) = "Direction" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type antComponentBase<'FunBlazorGeneric> =
    
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.AntComponentBase>
    
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type antContainerComponentBase<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.AntContainerComponentBase>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<AntDesign.AntContainerComponentBase>
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline tag (x: System.String) = "Tag" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type antDomComponentBase<'FunBlazorGeneric> =
    inherit antComponentBase<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.AntDomComponentBase>
    
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type antInputBoolComponentBase<'FunBlazorGeneric> =
    inherit antInputComponentBase<'FunBlazorGeneric, System.Boolean>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.AntInputBoolComponentBase>
    
    static member inline autoFocus (x: System.Boolean) = "AutoFocus" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline checked' (x: System.Boolean) = "Checked" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onChange fn = (Bolero.Html.attr.callback<System.Boolean> "OnChange" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline checkedChanged fn = (Bolero.Html.attr.callback<System.Boolean> "CheckedChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabled (x: System.Boolean) = "Disabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline additionalAttributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "AdditionalAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline value (x: System.Boolean) = "Value" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valueChanged fn = (Bolero.Html.attr.callback<System.Boolean> "ValueChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valueExpression (x: System.Linq.Expressions.Expression<System.Func<System.Boolean>>) = "ValueExpression" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valuesExpression (x: System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.IEnumerable<System.Boolean>>>) = "ValuesExpression" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline size (x: System.String) = "Size" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline cultureInfo (x: System.Globalization.CultureInfo) = "CultureInfo" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type antInputComponentBase<'FunBlazorGeneric, 'TValue> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.AntInputComponentBase<'TValue>>
    
    static member inline additionalAttributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "AdditionalAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline value (x: 'TValue) = "Value" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valueChanged fn = (Bolero.Html.attr.callback<'TValue> "ValueChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valueExpression (x: System.Linq.Expressions.Expression<System.Func<'TValue>>) = "ValueExpression" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valuesExpression (x: System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.IEnumerable<'TValue>>>) = "ValuesExpression" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline size (x: System.String) = "Size" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline cultureInfo (x: System.Globalization.CultureInfo) = "CultureInfo" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type templateComponentBase<'FunBlazorGeneric, 'TComponentOptions> =
    inherit antComponentBase<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.TemplateComponentBase<'TComponentOptions>>
    
    static member inline options (x: 'TComponentOptions) = "Options" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type feedbackComponent<'FunBlazorGeneric, 'TComponentOptions> =
    inherit templateComponentBase<'FunBlazorGeneric, 'TComponentOptions>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.FeedbackComponent<'TComponentOptions>>
    
    static member inline feedbackRef (x: AntDesign.IFeedbackRef) = "FeedbackRef" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline options (x: 'TComponentOptions) = "Options" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type feedbackComponent<'FunBlazorGeneric, 'TComponentOptions, 'TResult> =
    inherit feedbackComponent<'FunBlazorGeneric, 'TComponentOptions>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.FeedbackComponent<'TComponentOptions, 'TResult>>
    
    static member inline feedbackRef (x: AntDesign.IFeedbackRef) = "FeedbackRef" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline options (x: 'TComponentOptions) = "Options" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type datePicker<'FunBlazorGeneric, 'TValue> =
    inherit datePickerBase<'FunBlazorGeneric, 'TValue>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.DatePicker<'TValue>>
    
    static member inline onChange fn = (Bolero.Html.attr.callback<AntDesign.DateTimeChangedEventArgs> "OnChange" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline prefixCls (x: System.String) = "PrefixCls" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline picker (x: System.String) = "Picker" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline popupContainerSelector (x: System.String) = "PopupContainerSelector" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabled (x: System.Boolean) = "Disabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline bordered (x: System.Boolean) = "Bordered" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline autoFocus (x: System.Boolean) = "AutoFocus" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline open' (x: System.Boolean) = "Open" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline inputReadOnly (x: System.Boolean) = "InputReadOnly" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline showToday (x: System.Boolean) = "ShowToday" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline locale (x: AntDesign.DatePickerLocale) = "Locale" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline cultureInfo (x: System.Globalization.CultureInfo) = "CultureInfo" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline showTime (x: OneOf.OneOf<System.Boolean, System.String>) = "ShowTime" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline allowClear (x: System.Boolean) = "AllowClear" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline placeholder (x: OneOf.OneOf<System.String, System.Collections.Generic.IEnumerable<System.String>>) = "Placeholder" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline popupStyle (x: System.String) = "PopupStyle" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline className (x: System.String) = "ClassName" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline dropdownClassName (x: System.String) = "DropdownClassName" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline format (x: System.String) = "Format" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline defaultValue (x: 'TValue) = "DefaultValue" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline defaultPickerValue (x: 'TValue) = "DefaultPickerValue" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline suffixIcon (x: Microsoft.AspNetCore.Components.RenderFragment) = "SuffixIcon" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline renderExtraFooter (x: Microsoft.AspNetCore.Components.RenderFragment) = "RenderExtraFooter" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onClearClick (x: Microsoft.AspNetCore.Components.EventCallback) = "OnClearClick" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onOpenChange fn = (Bolero.Html.attr.callback<System.Boolean> "OnOpenChange" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onPanelChange fn = (Bolero.Html.attr.callback<AntDesign.DateTimeChangedEventArgs> "OnPanelChange" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabledDate (x: System.Func<System.DateTime, System.Boolean>) = "DisabledDate" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabledHours (x: System.Func<System.DateTime, System.Collections.Generic.IEnumerable<System.Int32>>) = "DisabledHours" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabledMinutes (x: System.Func<System.DateTime, System.Collections.Generic.IEnumerable<System.Int32>>) = "DisabledMinutes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabledSeconds (x: System.Func<System.DateTime, System.Collections.Generic.IEnumerable<System.Int32>>) = "DisabledSeconds" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabledTime (x: System.Func<System.DateTime, AntDesign.DatePickerDisabledTime>) = "DisabledTime" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline dateRender (x: System.Func<System.DateTime, System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "DateRender" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline monthCellRender (x: System.Func<System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "MonthCellRender" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline additionalAttributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "AdditionalAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline value (x: 'TValue) = "Value" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valueChanged fn = (Bolero.Html.attr.callback<'TValue> "ValueChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valueExpression (x: System.Linq.Expressions.Expression<System.Func<'TValue>>) = "ValueExpression" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valuesExpression (x: System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.IEnumerable<'TValue>>>) = "ValuesExpression" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline size (x: System.String) = "Size" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type datePickerBase<'FunBlazorGeneric, 'TValue> =
    inherit antInputComponentBase<'FunBlazorGeneric, 'TValue>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.DatePickerBase<'TValue>>
    
    static member inline prefixCls (x: System.String) = "PrefixCls" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline picker (x: System.String) = "Picker" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline popupContainerSelector (x: System.String) = "PopupContainerSelector" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabled (x: System.Boolean) = "Disabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline bordered (x: System.Boolean) = "Bordered" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline autoFocus (x: System.Boolean) = "AutoFocus" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline open' (x: System.Boolean) = "Open" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline inputReadOnly (x: System.Boolean) = "InputReadOnly" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline showToday (x: System.Boolean) = "ShowToday" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline locale (x: AntDesign.DatePickerLocale) = "Locale" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline cultureInfo (x: System.Globalization.CultureInfo) = "CultureInfo" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline showTime (x: OneOf.OneOf<System.Boolean, System.String>) = "ShowTime" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline allowClear (x: System.Boolean) = "AllowClear" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline placeholder (x: OneOf.OneOf<System.String, System.Collections.Generic.IEnumerable<System.String>>) = "Placeholder" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline popupStyle (x: System.String) = "PopupStyle" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline className (x: System.String) = "ClassName" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline dropdownClassName (x: System.String) = "DropdownClassName" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline format (x: System.String) = "Format" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline defaultValue (x: 'TValue) = "DefaultValue" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline defaultPickerValue (x: 'TValue) = "DefaultPickerValue" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline suffixIcon (x: Microsoft.AspNetCore.Components.RenderFragment) = "SuffixIcon" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline renderExtraFooter (x: Microsoft.AspNetCore.Components.RenderFragment) = "RenderExtraFooter" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onClearClick (x: Microsoft.AspNetCore.Components.EventCallback) = "OnClearClick" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onOpenChange fn = (Bolero.Html.attr.callback<System.Boolean> "OnOpenChange" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onPanelChange fn = (Bolero.Html.attr.callback<AntDesign.DateTimeChangedEventArgs> "OnPanelChange" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabledDate (x: System.Func<System.DateTime, System.Boolean>) = "DisabledDate" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabledHours (x: System.Func<System.DateTime, System.Collections.Generic.IEnumerable<System.Int32>>) = "DisabledHours" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabledMinutes (x: System.Func<System.DateTime, System.Collections.Generic.IEnumerable<System.Int32>>) = "DisabledMinutes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabledSeconds (x: System.Func<System.DateTime, System.Collections.Generic.IEnumerable<System.Int32>>) = "DisabledSeconds" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabledTime (x: System.Func<System.DateTime, AntDesign.DatePickerDisabledTime>) = "DisabledTime" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline dateRender (x: System.Func<System.DateTime, System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "DateRender" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline monthCellRender (x: System.Func<System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "MonthCellRender" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline additionalAttributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "AdditionalAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline value (x: 'TValue) = "Value" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valueChanged fn = (Bolero.Html.attr.callback<'TValue> "ValueChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valueExpression (x: System.Linq.Expressions.Expression<System.Func<'TValue>>) = "ValueExpression" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valuesExpression (x: System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.IEnumerable<'TValue>>>) = "ValuesExpression" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline size (x: System.String) = "Size" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type datePickerPanelBase<'FunBlazorGeneric, 'TValue> =
    inherit pickerPanelBase<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.DatePickerPanelBase<'TValue>>
    
    static member inline prefixCls (x: System.String) = "PrefixCls" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline picker (x: System.String) = "Picker" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline isRange (x: System.Boolean) = "IsRange" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline isCalendar (x: System.Boolean) = "IsCalendar" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline isShowHeader (x: System.Boolean) = "IsShowHeader" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline locale (x: AntDesign.DatePickerLocale) = "Locale" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline cultureInfo (x: System.Globalization.CultureInfo) = "CultureInfo" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline closePanel (x: System.Action) = "ClosePanel" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline changePickerValue (x: System.Action<System.DateTime, System.Nullable<System.Int32>>) = "ChangePickerValue" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline changeValue (x: System.Action<System.DateTime, System.Int32>) = "ChangeValue" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline changePickerType (x: System.Action<System.String, System.Int32>) = "ChangePickerType" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline getIndexPickerValue (x: System.Func<System.Int32, System.DateTime>) = "GetIndexPickerValue" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline getIndexValue (x: System.Func<System.Int32, System.Nullable<System.DateTime>>) = "GetIndexValue" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabledDate (x: System.Func<System.DateTime, System.Boolean>) = "DisabledDate" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline dateRender (x: System.Func<System.DateTime, System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "DateRender" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline monthCellRender (x: System.Func<System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "MonthCellRender" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline calendarDateRender (x: System.Func<System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "CalendarDateRender" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline calendarMonthCellRender (x: System.Func<System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "CalendarMonthCellRender" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline renderExtraFooter (x: Microsoft.AspNetCore.Components.RenderFragment) = "RenderExtraFooter" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onSelect (x: System.Action<System.DateTime, System.Int32>) = "OnSelect" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline pickerIndex (x: System.Int32) = "PickerIndex" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type monthPicker<'FunBlazorGeneric, 'TValue> =
    inherit datePicker<'FunBlazorGeneric, 'TValue>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.MonthPicker<'TValue>>
    
    static member inline onChange fn = (Bolero.Html.attr.callback<AntDesign.DateTimeChangedEventArgs> "OnChange" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline prefixCls (x: System.String) = "PrefixCls" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline picker (x: System.String) = "Picker" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline popupContainerSelector (x: System.String) = "PopupContainerSelector" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabled (x: System.Boolean) = "Disabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline bordered (x: System.Boolean) = "Bordered" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline autoFocus (x: System.Boolean) = "AutoFocus" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline open' (x: System.Boolean) = "Open" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline inputReadOnly (x: System.Boolean) = "InputReadOnly" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline showToday (x: System.Boolean) = "ShowToday" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline locale (x: AntDesign.DatePickerLocale) = "Locale" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline cultureInfo (x: System.Globalization.CultureInfo) = "CultureInfo" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline showTime (x: OneOf.OneOf<System.Boolean, System.String>) = "ShowTime" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline allowClear (x: System.Boolean) = "AllowClear" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline placeholder (x: OneOf.OneOf<System.String, System.Collections.Generic.IEnumerable<System.String>>) = "Placeholder" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline popupStyle (x: System.String) = "PopupStyle" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline className (x: System.String) = "ClassName" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline dropdownClassName (x: System.String) = "DropdownClassName" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline format (x: System.String) = "Format" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline defaultValue (x: 'TValue) = "DefaultValue" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline defaultPickerValue (x: 'TValue) = "DefaultPickerValue" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline suffixIcon (x: Microsoft.AspNetCore.Components.RenderFragment) = "SuffixIcon" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline renderExtraFooter (x: Microsoft.AspNetCore.Components.RenderFragment) = "RenderExtraFooter" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onClearClick (x: Microsoft.AspNetCore.Components.EventCallback) = "OnClearClick" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onOpenChange fn = (Bolero.Html.attr.callback<System.Boolean> "OnOpenChange" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onPanelChange fn = (Bolero.Html.attr.callback<AntDesign.DateTimeChangedEventArgs> "OnPanelChange" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabledDate (x: System.Func<System.DateTime, System.Boolean>) = "DisabledDate" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabledHours (x: System.Func<System.DateTime, System.Collections.Generic.IEnumerable<System.Int32>>) = "DisabledHours" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabledMinutes (x: System.Func<System.DateTime, System.Collections.Generic.IEnumerable<System.Int32>>) = "DisabledMinutes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabledSeconds (x: System.Func<System.DateTime, System.Collections.Generic.IEnumerable<System.Int32>>) = "DisabledSeconds" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabledTime (x: System.Func<System.DateTime, AntDesign.DatePickerDisabledTime>) = "DisabledTime" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline dateRender (x: System.Func<System.DateTime, System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "DateRender" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline monthCellRender (x: System.Func<System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "MonthCellRender" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline additionalAttributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "AdditionalAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline value (x: 'TValue) = "Value" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valueChanged fn = (Bolero.Html.attr.callback<'TValue> "ValueChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valueExpression (x: System.Linq.Expressions.Expression<System.Func<'TValue>>) = "ValueExpression" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valuesExpression (x: System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.IEnumerable<'TValue>>>) = "ValuesExpression" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline size (x: System.String) = "Size" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type quarterPicker<'FunBlazorGeneric, 'TValue> =
    inherit datePicker<'FunBlazorGeneric, 'TValue>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.QuarterPicker<'TValue>>
    
    static member inline onChange fn = (Bolero.Html.attr.callback<AntDesign.DateTimeChangedEventArgs> "OnChange" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline prefixCls (x: System.String) = "PrefixCls" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline picker (x: System.String) = "Picker" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline popupContainerSelector (x: System.String) = "PopupContainerSelector" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabled (x: System.Boolean) = "Disabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline bordered (x: System.Boolean) = "Bordered" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline autoFocus (x: System.Boolean) = "AutoFocus" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline open' (x: System.Boolean) = "Open" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline inputReadOnly (x: System.Boolean) = "InputReadOnly" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline showToday (x: System.Boolean) = "ShowToday" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline locale (x: AntDesign.DatePickerLocale) = "Locale" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline cultureInfo (x: System.Globalization.CultureInfo) = "CultureInfo" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline showTime (x: OneOf.OneOf<System.Boolean, System.String>) = "ShowTime" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline allowClear (x: System.Boolean) = "AllowClear" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline placeholder (x: OneOf.OneOf<System.String, System.Collections.Generic.IEnumerable<System.String>>) = "Placeholder" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline popupStyle (x: System.String) = "PopupStyle" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline className (x: System.String) = "ClassName" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline dropdownClassName (x: System.String) = "DropdownClassName" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline format (x: System.String) = "Format" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline defaultValue (x: 'TValue) = "DefaultValue" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline defaultPickerValue (x: 'TValue) = "DefaultPickerValue" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline suffixIcon (x: Microsoft.AspNetCore.Components.RenderFragment) = "SuffixIcon" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline renderExtraFooter (x: Microsoft.AspNetCore.Components.RenderFragment) = "RenderExtraFooter" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onClearClick (x: Microsoft.AspNetCore.Components.EventCallback) = "OnClearClick" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onOpenChange fn = (Bolero.Html.attr.callback<System.Boolean> "OnOpenChange" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onPanelChange fn = (Bolero.Html.attr.callback<AntDesign.DateTimeChangedEventArgs> "OnPanelChange" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabledDate (x: System.Func<System.DateTime, System.Boolean>) = "DisabledDate" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabledHours (x: System.Func<System.DateTime, System.Collections.Generic.IEnumerable<System.Int32>>) = "DisabledHours" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabledMinutes (x: System.Func<System.DateTime, System.Collections.Generic.IEnumerable<System.Int32>>) = "DisabledMinutes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabledSeconds (x: System.Func<System.DateTime, System.Collections.Generic.IEnumerable<System.Int32>>) = "DisabledSeconds" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabledTime (x: System.Func<System.DateTime, AntDesign.DatePickerDisabledTime>) = "DisabledTime" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline dateRender (x: System.Func<System.DateTime, System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "DateRender" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline monthCellRender (x: System.Func<System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "MonthCellRender" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline additionalAttributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "AdditionalAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline value (x: 'TValue) = "Value" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valueChanged fn = (Bolero.Html.attr.callback<'TValue> "ValueChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valueExpression (x: System.Linq.Expressions.Expression<System.Func<'TValue>>) = "ValueExpression" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valuesExpression (x: System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.IEnumerable<'TValue>>>) = "ValuesExpression" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline size (x: System.String) = "Size" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type rangePicker<'FunBlazorGeneric, 'TValue> =
    inherit datePickerBase<'FunBlazorGeneric, 'TValue>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.RangePicker<'TValue>>
    
    static member inline value (x: 'TValue) = "Value" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onChange fn = (Bolero.Html.attr.callback<AntDesign.DateRangeChangedEventArgs> "OnChange" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline prefixCls (x: System.String) = "PrefixCls" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline picker (x: System.String) = "Picker" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline popupContainerSelector (x: System.String) = "PopupContainerSelector" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabled (x: System.Boolean) = "Disabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline bordered (x: System.Boolean) = "Bordered" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline autoFocus (x: System.Boolean) = "AutoFocus" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline open' (x: System.Boolean) = "Open" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline inputReadOnly (x: System.Boolean) = "InputReadOnly" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline showToday (x: System.Boolean) = "ShowToday" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline locale (x: AntDesign.DatePickerLocale) = "Locale" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline cultureInfo (x: System.Globalization.CultureInfo) = "CultureInfo" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline showTime (x: OneOf.OneOf<System.Boolean, System.String>) = "ShowTime" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline allowClear (x: System.Boolean) = "AllowClear" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline placeholder (x: OneOf.OneOf<System.String, System.Collections.Generic.IEnumerable<System.String>>) = "Placeholder" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline popupStyle (x: System.String) = "PopupStyle" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline className (x: System.String) = "ClassName" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline dropdownClassName (x: System.String) = "DropdownClassName" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline format (x: System.String) = "Format" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline defaultValue (x: 'TValue) = "DefaultValue" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline defaultPickerValue (x: 'TValue) = "DefaultPickerValue" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline suffixIcon (x: Microsoft.AspNetCore.Components.RenderFragment) = "SuffixIcon" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline renderExtraFooter (x: Microsoft.AspNetCore.Components.RenderFragment) = "RenderExtraFooter" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onClearClick (x: Microsoft.AspNetCore.Components.EventCallback) = "OnClearClick" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onOpenChange fn = (Bolero.Html.attr.callback<System.Boolean> "OnOpenChange" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onPanelChange fn = (Bolero.Html.attr.callback<AntDesign.DateTimeChangedEventArgs> "OnPanelChange" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabledDate (x: System.Func<System.DateTime, System.Boolean>) = "DisabledDate" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabledHours (x: System.Func<System.DateTime, System.Collections.Generic.IEnumerable<System.Int32>>) = "DisabledHours" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabledMinutes (x: System.Func<System.DateTime, System.Collections.Generic.IEnumerable<System.Int32>>) = "DisabledMinutes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabledSeconds (x: System.Func<System.DateTime, System.Collections.Generic.IEnumerable<System.Int32>>) = "DisabledSeconds" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabledTime (x: System.Func<System.DateTime, AntDesign.DatePickerDisabledTime>) = "DisabledTime" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline dateRender (x: System.Func<System.DateTime, System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "DateRender" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline monthCellRender (x: System.Func<System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "MonthCellRender" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline additionalAttributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "AdditionalAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valueChanged fn = (Bolero.Html.attr.callback<'TValue> "ValueChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valueExpression (x: System.Linq.Expressions.Expression<System.Func<'TValue>>) = "ValueExpression" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valuesExpression (x: System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.IEnumerable<'TValue>>>) = "ValuesExpression" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline size (x: System.String) = "Size" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type weekPicker<'FunBlazorGeneric, 'TValue> =
    inherit datePicker<'FunBlazorGeneric, 'TValue>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.WeekPicker<'TValue>>
    
    static member inline onChange fn = (Bolero.Html.attr.callback<AntDesign.DateTimeChangedEventArgs> "OnChange" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline prefixCls (x: System.String) = "PrefixCls" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline picker (x: System.String) = "Picker" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline popupContainerSelector (x: System.String) = "PopupContainerSelector" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabled (x: System.Boolean) = "Disabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline bordered (x: System.Boolean) = "Bordered" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline autoFocus (x: System.Boolean) = "AutoFocus" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline open' (x: System.Boolean) = "Open" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline inputReadOnly (x: System.Boolean) = "InputReadOnly" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline showToday (x: System.Boolean) = "ShowToday" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline locale (x: AntDesign.DatePickerLocale) = "Locale" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline cultureInfo (x: System.Globalization.CultureInfo) = "CultureInfo" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline showTime (x: OneOf.OneOf<System.Boolean, System.String>) = "ShowTime" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline allowClear (x: System.Boolean) = "AllowClear" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline placeholder (x: OneOf.OneOf<System.String, System.Collections.Generic.IEnumerable<System.String>>) = "Placeholder" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline popupStyle (x: System.String) = "PopupStyle" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline className (x: System.String) = "ClassName" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline dropdownClassName (x: System.String) = "DropdownClassName" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline format (x: System.String) = "Format" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline defaultValue (x: 'TValue) = "DefaultValue" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline defaultPickerValue (x: 'TValue) = "DefaultPickerValue" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline suffixIcon (x: Microsoft.AspNetCore.Components.RenderFragment) = "SuffixIcon" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline renderExtraFooter (x: Microsoft.AspNetCore.Components.RenderFragment) = "RenderExtraFooter" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onClearClick (x: Microsoft.AspNetCore.Components.EventCallback) = "OnClearClick" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onOpenChange fn = (Bolero.Html.attr.callback<System.Boolean> "OnOpenChange" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onPanelChange fn = (Bolero.Html.attr.callback<AntDesign.DateTimeChangedEventArgs> "OnPanelChange" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabledDate (x: System.Func<System.DateTime, System.Boolean>) = "DisabledDate" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabledHours (x: System.Func<System.DateTime, System.Collections.Generic.IEnumerable<System.Int32>>) = "DisabledHours" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabledMinutes (x: System.Func<System.DateTime, System.Collections.Generic.IEnumerable<System.Int32>>) = "DisabledMinutes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabledSeconds (x: System.Func<System.DateTime, System.Collections.Generic.IEnumerable<System.Int32>>) = "DisabledSeconds" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabledTime (x: System.Func<System.DateTime, AntDesign.DatePickerDisabledTime>) = "DisabledTime" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline dateRender (x: System.Func<System.DateTime, System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "DateRender" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline monthCellRender (x: System.Func<System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "MonthCellRender" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline additionalAttributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "AdditionalAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline value (x: 'TValue) = "Value" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valueChanged fn = (Bolero.Html.attr.callback<'TValue> "ValueChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valueExpression (x: System.Linq.Expressions.Expression<System.Func<'TValue>>) = "ValueExpression" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valuesExpression (x: System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.IEnumerable<'TValue>>>) = "ValuesExpression" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline size (x: System.String) = "Size" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type yearPicker<'FunBlazorGeneric, 'TValue> =
    inherit datePicker<'FunBlazorGeneric, 'TValue>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.YearPicker<'TValue>>
    
    static member inline onChange fn = (Bolero.Html.attr.callback<AntDesign.DateTimeChangedEventArgs> "OnChange" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline prefixCls (x: System.String) = "PrefixCls" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline picker (x: System.String) = "Picker" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline popupContainerSelector (x: System.String) = "PopupContainerSelector" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabled (x: System.Boolean) = "Disabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline bordered (x: System.Boolean) = "Bordered" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline autoFocus (x: System.Boolean) = "AutoFocus" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline open' (x: System.Boolean) = "Open" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline inputReadOnly (x: System.Boolean) = "InputReadOnly" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline showToday (x: System.Boolean) = "ShowToday" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline locale (x: AntDesign.DatePickerLocale) = "Locale" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline cultureInfo (x: System.Globalization.CultureInfo) = "CultureInfo" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline showTime (x: OneOf.OneOf<System.Boolean, System.String>) = "ShowTime" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline allowClear (x: System.Boolean) = "AllowClear" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline placeholder (x: OneOf.OneOf<System.String, System.Collections.Generic.IEnumerable<System.String>>) = "Placeholder" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline popupStyle (x: System.String) = "PopupStyle" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline className (x: System.String) = "ClassName" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline dropdownClassName (x: System.String) = "DropdownClassName" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline format (x: System.String) = "Format" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline defaultValue (x: 'TValue) = "DefaultValue" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline defaultPickerValue (x: 'TValue) = "DefaultPickerValue" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline suffixIcon (x: Microsoft.AspNetCore.Components.RenderFragment) = "SuffixIcon" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline renderExtraFooter (x: Microsoft.AspNetCore.Components.RenderFragment) = "RenderExtraFooter" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onClearClick (x: Microsoft.AspNetCore.Components.EventCallback) = "OnClearClick" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onOpenChange fn = (Bolero.Html.attr.callback<System.Boolean> "OnOpenChange" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onPanelChange fn = (Bolero.Html.attr.callback<AntDesign.DateTimeChangedEventArgs> "OnPanelChange" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabledDate (x: System.Func<System.DateTime, System.Boolean>) = "DisabledDate" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabledHours (x: System.Func<System.DateTime, System.Collections.Generic.IEnumerable<System.Int32>>) = "DisabledHours" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabledMinutes (x: System.Func<System.DateTime, System.Collections.Generic.IEnumerable<System.Int32>>) = "DisabledMinutes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabledSeconds (x: System.Func<System.DateTime, System.Collections.Generic.IEnumerable<System.Int32>>) = "DisabledSeconds" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabledTime (x: System.Func<System.DateTime, AntDesign.DatePickerDisabledTime>) = "DisabledTime" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline dateRender (x: System.Func<System.DateTime, System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "DateRender" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline monthCellRender (x: System.Func<System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "MonthCellRender" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline additionalAttributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "AdditionalAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline value (x: 'TValue) = "Value" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valueChanged fn = (Bolero.Html.attr.callback<'TValue> "ValueChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valueExpression (x: System.Linq.Expressions.Expression<System.Func<'TValue>>) = "ValueExpression" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valuesExpression (x: System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.IEnumerable<'TValue>>>) = "ValuesExpression" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline size (x: System.String) = "Size" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type descriptions<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.Descriptions>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<AntDesign.Descriptions>
    static member inline bordered (x: System.Boolean) = "Bordered" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline layout (x: System.String) = "Layout" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline column (x: OneOf.OneOf<System.Int32, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Int32>>>) = "Column" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline size (x: System.String) = "Size" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline title (x: System.String) = "Title" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline titleTemplate (x: Microsoft.AspNetCore.Components.RenderFragment) = "TitleTemplate" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline colon (x: System.Boolean) = "Colon" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type descriptionsItem<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.DescriptionsItem>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<AntDesign.DescriptionsItem>
    static member inline title (x: System.String) = "Title" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline titleTemplate (x: Microsoft.AspNetCore.Components.RenderFragment) = "TitleTemplate" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline span (x: System.Int32) = "Span" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type divider<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.Divider>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<AntDesign.Divider>
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline text (x: System.String) = "Text" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline plain (x: System.Boolean) = "Plain" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline type' (x: AntDesign.DirectionVHType) = "Type" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline orientation (x: System.String) = "Orientation" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline dashed (x: System.Boolean) = "Dashed" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type drawer<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.Drawer>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<AntDesign.Drawer>
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline content (x: OneOf.OneOf<Microsoft.AspNetCore.Components.RenderFragment, System.String>) = "Content" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline closable (x: System.Boolean) = "Closable" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline maskClosable (x: System.Boolean) = "MaskClosable" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline mask (x: System.Boolean) = "Mask" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline noAnimation (x: System.Boolean) = "NoAnimation" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline keyboard (x: System.Boolean) = "Keyboard" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline title (x: OneOf.OneOf<Microsoft.AspNetCore.Components.RenderFragment, System.String>) = "Title" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline placement (x: System.String) = "Placement" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline maskStyle (x: System.String) = "MaskStyle" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline bodyStyle (x: System.String) = "BodyStyle" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline wrapClassName (x: System.String) = "WrapClassName" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline width (x: System.Int32) = "Width" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline height (x: System.Int32) = "Height" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline zIndex (x: System.Int32) = "ZIndex" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline offsetX (x: System.Int32) = "OffsetX" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline offsetY (x: System.Int32) = "OffsetY" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline visible (x: System.Boolean) = "Visible" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onClose (x: Microsoft.AspNetCore.Components.EventCallback) = "OnClose" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline handler (x: Microsoft.AspNetCore.Components.RenderFragment) = "Handler" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type drawerContainer<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.DrawerContainer>
    
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type dropdown<'FunBlazorGeneric> =
    inherit overlayTrigger<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.Dropdown>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<AntDesign.Dropdown>
    static member inline boundaryAdjustMode (x: AntDesign.TriggerBoundaryAdjustMode) = "BoundaryAdjustMode" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline complexAutoCloseAndVisible (x: System.Boolean) = "ComplexAutoCloseAndVisible" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabled (x: System.Boolean) = "Disabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline hiddenMode (x: System.Boolean) = "HiddenMode" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline inlineFlexMode (x: System.Boolean) = "InlineFlexMode" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline isButton (x: System.Boolean) = "IsButton" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onClick fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnClick" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onMaskClick (x: Microsoft.AspNetCore.Components.EventCallback) = "OnMaskClick" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onMouseEnter (x: System.Action) = "OnMouseEnter" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onMouseLeave (x: System.Action) = "OnMouseLeave" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onOverlayHiding fn = (Bolero.Html.attr.callback<System.Boolean> "OnOverlayHiding" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onVisibleChange fn = (Bolero.Html.attr.callback<System.Boolean> "OnVisibleChange" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline overlay (x: Microsoft.AspNetCore.Components.RenderFragment) = "Overlay" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline overlayClassName (x: System.String) = "OverlayClassName" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline overlayEnterCls (x: System.String) = "OverlayEnterCls" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline overlayHiddenCls (x: System.String) = "OverlayHiddenCls" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline overlayLeaveCls (x: System.String) = "OverlayLeaveCls" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline overlayStyle (x: System.String) = "OverlayStyle" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline placement (x: AntDesign.PlacementType) = "Placement" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline placementCls (x: System.String) = "PlacementCls" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline popupContainerSelector (x: System.String) = "PopupContainerSelector" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline trigger (x: System.Collections.Generic.IEnumerable<AntDesign.TriggerType>) = "Trigger" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline triggerReference (x: Microsoft.AspNetCore.Components.ElementReference) = "TriggerReference" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline unbound (x: Microsoft.AspNetCore.Components.RenderFragment<AntDesign.ForwardRef>) = "Unbound" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline visible (x: System.Boolean) = "Visible" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type dropdownButton<'FunBlazorGeneric> =
    inherit dropdown<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.DropdownButton>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<AntDesign.DropdownButton>
    static member inline block (x: System.Boolean) = "Block" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline buttonsRender (x: System.Func<Microsoft.AspNetCore.Components.RenderFragment, Microsoft.AspNetCore.Components.RenderFragment, Microsoft.AspNetCore.Components.RenderFragment>) = "ButtonsRender" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline danger (x: System.Boolean) = "Danger" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline ghost (x: System.Boolean) = "Ghost" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline icon (x: System.String) = "Icon" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline loading (x: System.Boolean) = "Loading" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline size (x: System.String) = "Size" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline type' (x: System.ValueTuple<System.String, System.String>) = "Type" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline boundaryAdjustMode (x: AntDesign.TriggerBoundaryAdjustMode) = "BoundaryAdjustMode" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline complexAutoCloseAndVisible (x: System.Boolean) = "ComplexAutoCloseAndVisible" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabled (x: System.Boolean) = "Disabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline hiddenMode (x: System.Boolean) = "HiddenMode" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline inlineFlexMode (x: System.Boolean) = "InlineFlexMode" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline isButton (x: System.Boolean) = "IsButton" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onClick fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnClick" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onMaskClick (x: Microsoft.AspNetCore.Components.EventCallback) = "OnMaskClick" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onMouseEnter (x: System.Action) = "OnMouseEnter" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onMouseLeave (x: System.Action) = "OnMouseLeave" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onOverlayHiding fn = (Bolero.Html.attr.callback<System.Boolean> "OnOverlayHiding" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onVisibleChange fn = (Bolero.Html.attr.callback<System.Boolean> "OnVisibleChange" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline overlay (x: Microsoft.AspNetCore.Components.RenderFragment) = "Overlay" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline overlayClassName (x: System.String) = "OverlayClassName" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline overlayEnterCls (x: System.String) = "OverlayEnterCls" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline overlayHiddenCls (x: System.String) = "OverlayHiddenCls" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline overlayLeaveCls (x: System.String) = "OverlayLeaveCls" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline overlayStyle (x: System.String) = "OverlayStyle" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline placement (x: AntDesign.PlacementType) = "Placement" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline placementCls (x: System.String) = "PlacementCls" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline popupContainerSelector (x: System.String) = "PopupContainerSelector" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline trigger (x: System.Collections.Generic.IEnumerable<AntDesign.TriggerType>) = "Trigger" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline triggerReference (x: Microsoft.AspNetCore.Components.ElementReference) = "TriggerReference" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline unbound (x: Microsoft.AspNetCore.Components.RenderFragment<AntDesign.ForwardRef>) = "Unbound" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline visible (x: System.Boolean) = "Visible" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type empty<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.Empty>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<AntDesign.Empty>
    static member inline prefixCls (x: System.String) = "PrefixCls" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline imageStyle (x: System.String) = "ImageStyle" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline small (x: System.Boolean) = "Small" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline simple (x: System.Boolean) = "Simple" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline description (x: OneOf.OneOf<System.String, System.Nullable<System.Boolean>>) = "Description" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline descriptionTemplate (x: Microsoft.AspNetCore.Components.RenderFragment) = "DescriptionTemplate" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline image (x: System.String) = "Image" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline imageTemplate (x: Microsoft.AspNetCore.Components.RenderFragment) = "ImageTemplate" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type form<'FunBlazorGeneric, 'TModel> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.Form<'TModel>>
    
    static member inline layout (x: System.String) = "Layout" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (x: Microsoft.AspNetCore.Components.RenderFragment<'TModel>) = "ChildContent" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline labelCol (x: AntDesign.ColLayoutParam) = "LabelCol" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline labelAlign (x: System.Nullable<AntDesign.AntLabelAlignType>) = "LabelAlign" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline labelColSpan (x: OneOf.OneOf<System.String, System.Int32>) = "LabelColSpan" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline labelColOffset (x: OneOf.OneOf<System.String, System.Int32>) = "LabelColOffset" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline wrapperCol (x: AntDesign.ColLayoutParam) = "WrapperCol" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline wrapperColSpan (x: OneOf.OneOf<System.String, System.Int32>) = "WrapperColSpan" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline wrapperColOffset (x: OneOf.OneOf<System.String, System.Int32>) = "WrapperColOffset" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline size (x: System.String) = "Size" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline name (x: System.String) = "Name" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline model (x: 'TModel) = "Model" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline loading (x: System.Boolean) = "Loading" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onFinish fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Forms.EditContext> "OnFinish" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onFinishFailed fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Forms.EditContext> "OnFinishFailed" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline validator (x: Microsoft.AspNetCore.Components.RenderFragment) = "Validator" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline validateOnChange (x: System.Boolean) = "ValidateOnChange" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type formItem<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.FormItem>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<AntDesign.FormItem>
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline label (x: System.String) = "Label" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline labelTemplate (x: Microsoft.AspNetCore.Components.RenderFragment) = "LabelTemplate" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline labelCol (x: AntDesign.ColLayoutParam) = "LabelCol" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline labelAlign (x: System.Nullable<AntDesign.AntLabelAlignType>) = "LabelAlign" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline labelColSpan (x: OneOf.OneOf<System.String, System.Int32>) = "LabelColSpan" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline labelColOffset (x: OneOf.OneOf<System.String, System.Int32>) = "LabelColOffset" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline wrapperCol (x: AntDesign.ColLayoutParam) = "WrapperCol" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline wrapperColSpan (x: OneOf.OneOf<System.String, System.Int32>) = "WrapperColSpan" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline wrapperColOffset (x: OneOf.OneOf<System.String, System.Int32>) = "WrapperColOffset" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline noStyle (x: System.Boolean) = "NoStyle" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline required (x: System.Boolean) = "Required" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type formProvider<'FunBlazorGeneric> =
    inherit antComponentBase<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.FormProvider>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<AntDesign.FormProvider>
    static member inline onFormFinish fn = (Bolero.Html.attr.callback<AntDesign.FormProviderFinishEventArgs> "OnFormFinish" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type formValidationMessage<'FunBlazorGeneric, 'TValue> =
    
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.FormValidationMessage<'TValue>>
    
    static member inline additionalAttributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "AdditionalAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline control (x: AntDesign.AntInputComponentBase<'TValue>) = "Control" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type formValidationMessageItem<'FunBlazorGeneric> =
    
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.FormValidationMessageItem>
    
    static member inline message (x: System.String) = "Message" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline additionalAttributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "AdditionalAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type col<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.Col>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<AntDesign.Col>
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline flex (x: OneOf.OneOf<System.String, System.Int32>) = "Flex" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline span (x: OneOf.OneOf<System.String, System.Int32>) = "Span" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline order (x: OneOf.OneOf<System.String, System.Int32>) = "Order" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline offset (x: OneOf.OneOf<System.String, System.Int32>) = "Offset" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline push (x: OneOf.OneOf<System.String, System.Int32>) = "Push" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline pull (x: OneOf.OneOf<System.String, System.Int32>) = "Pull" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline xs (x: OneOf.OneOf<System.Int32, AntDesign.EmbeddedProperty>) = "Xs" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline sm (x: OneOf.OneOf<System.Int32, AntDesign.EmbeddedProperty>) = "Sm" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline md (x: OneOf.OneOf<System.Int32, AntDesign.EmbeddedProperty>) = "Md" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline lg (x: OneOf.OneOf<System.Int32, AntDesign.EmbeddedProperty>) = "Lg" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline xl (x: OneOf.OneOf<System.Int32, AntDesign.EmbeddedProperty>) = "Xl" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline xxl (x: OneOf.OneOf<System.Int32, AntDesign.EmbeddedProperty>) = "Xxl" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type gridCol<'FunBlazorGeneric> =
    inherit col<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.GridCol>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<AntDesign.GridCol>
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline flex (x: OneOf.OneOf<System.String, System.Int32>) = "Flex" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline span (x: OneOf.OneOf<System.String, System.Int32>) = "Span" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline order (x: OneOf.OneOf<System.String, System.Int32>) = "Order" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline offset (x: OneOf.OneOf<System.String, System.Int32>) = "Offset" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline push (x: OneOf.OneOf<System.String, System.Int32>) = "Push" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline pull (x: OneOf.OneOf<System.String, System.Int32>) = "Pull" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline xs (x: OneOf.OneOf<System.Int32, AntDesign.EmbeddedProperty>) = "Xs" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline sm (x: OneOf.OneOf<System.Int32, AntDesign.EmbeddedProperty>) = "Sm" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline md (x: OneOf.OneOf<System.Int32, AntDesign.EmbeddedProperty>) = "Md" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline lg (x: OneOf.OneOf<System.Int32, AntDesign.EmbeddedProperty>) = "Lg" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline xl (x: OneOf.OneOf<System.Int32, AntDesign.EmbeddedProperty>) = "Xl" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline xxl (x: OneOf.OneOf<System.Int32, AntDesign.EmbeddedProperty>) = "Xxl" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type row<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.Row>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<AntDesign.Row>
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline type' (x: System.String) = "Type" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline align (x: System.String) = "Align" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline justify (x: System.String) = "Justify" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline wrap (x: System.Boolean) = "Wrap" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline gutter (x: OneOf.OneOf<System.Int32, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Int32>>, System.ValueTuple<System.Int32, System.Int32>, System.ValueTuple<System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Int32>>, System.Int32>, System.ValueTuple<System.Int32, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Int32>>>, System.ValueTuple<System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Int32>>, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Int32>>>>) = "Gutter" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onBreakpoint fn = (Bolero.Html.attr.callback<AntDesign.BreakpointType> "OnBreakpoint" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline defaultBreakpoint (x: AntDesign.BreakpointType) = "DefaultBreakpoint" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type icon<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.Icon>
    
    static member inline spin (x: System.Boolean) = "Spin" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline rotate (x: System.Int32) = "Rotate" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline type' (x: System.String) = "Type" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline theme (x: System.String) = "Theme" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline twotoneColor (x: System.String) = "TwotoneColor" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline iconFont (x: System.String) = "IconFont" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline width (x: System.String) = "Width" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline height (x: System.String) = "Height" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline fill (x: System.String) = "Fill" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline tabIndex (x: System.String) = "TabIndex" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline stopPropagation (x: System.Boolean) = "StopPropagation" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onClick fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnClick" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline component' (x: Microsoft.AspNetCore.Components.RenderFragment) = "Component" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type iconFont<'FunBlazorGeneric> =
    inherit icon<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.IconFont>
    
    static member inline spin (x: System.Boolean) = "Spin" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline rotate (x: System.Int32) = "Rotate" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline type' (x: System.String) = "Type" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline theme (x: System.String) = "Theme" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline twotoneColor (x: System.String) = "TwotoneColor" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline iconFont (x: System.String) = "IconFont" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline width (x: System.String) = "Width" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline height (x: System.String) = "Height" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline fill (x: System.String) = "Fill" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline tabIndex (x: System.String) = "TabIndex" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline stopPropagation (x: System.Boolean) = "StopPropagation" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onClick fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnClick" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline component' (x: Microsoft.AspNetCore.Components.RenderFragment) = "Component" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type image<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.Image>
    
    static member inline alt (x: System.String) = "Alt" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline fallback (x: System.String) = "Fallback" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline height (x: System.String) = "Height" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline width (x: System.String) = "Width" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline placeholder (x: Microsoft.AspNetCore.Components.RenderFragment) = "Placeholder" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline preview (x: System.Boolean) = "Preview" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline src (x: System.String) = "Src" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline previewSrc (x: System.String) = "PreviewSrc" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline locale (x: AntDesign.ImageLocale) = "Locale" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type imagePreview<'FunBlazorGeneric> =
    
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.ImagePreview>
    
    static member inline imageRef (x: AntDesign.ImageRef) = "ImageRef" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type imagePreviewContainer<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.ImagePreviewContainer>
    
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type imagePreviewGroup<'FunBlazorGeneric> =
    
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.ImagePreviewGroup>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<AntDesign.ImagePreviewGroup>
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type inputNumber<'FunBlazorGeneric, 'TValue> =
    inherit antInputComponentBase<'FunBlazorGeneric, 'TValue>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.InputNumber<'TValue>>
    
    static member inline formatter (x: System.Func<'TValue, System.String>) = "Formatter" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline parser (x: System.Func<System.String, System.String>) = "Parser" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline step (x: 'TValue) = "Step" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline defaultValue (x: 'TValue) = "DefaultValue" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline max (x: 'TValue) = "Max" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline min (x: 'TValue) = "Min" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabled (x: System.Boolean) = "Disabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onChange fn = (Bolero.Html.attr.callback<'TValue> "OnChange" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline additionalAttributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "AdditionalAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline value (x: 'TValue) = "Value" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valueChanged fn = (Bolero.Html.attr.callback<'TValue> "ValueChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valueExpression (x: System.Linq.Expressions.Expression<System.Func<'TValue>>) = "ValueExpression" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valuesExpression (x: System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.IEnumerable<'TValue>>>) = "ValuesExpression" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline size (x: System.String) = "Size" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline cultureInfo (x: System.Globalization.CultureInfo) = "CultureInfo" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type input<'FunBlazorGeneric, 'TValue> =
    inherit antInputComponentBase<'FunBlazorGeneric, 'TValue>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.Input<'TValue>>
    
    static member inline addOnBefore (x: Microsoft.AspNetCore.Components.RenderFragment) = "AddOnBefore" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline addOnAfter (x: Microsoft.AspNetCore.Components.RenderFragment) = "AddOnAfter" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline allowClear (x: System.Boolean) = "AllowClear" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline autoFocus (x: System.Boolean) = "AutoFocus" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline bordered (x: System.Boolean) = "Bordered" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline debounceMilliseconds (x: System.Int32) = "DebounceMilliseconds" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline defaultValue (x: 'TValue) = "DefaultValue" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabled (x: System.Boolean) = "Disabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline inputElementSuffixClass (x: System.String) = "InputElementSuffixClass" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline maxLength (x: System.Int32) = "MaxLength" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onBlur fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.FocusEventArgs> "OnBlur" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onChange fn = (Bolero.Html.attr.callback<'TValue> "OnChange" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onFocus fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.FocusEventArgs> "OnFocus" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onInput fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.ChangeEventArgs> "OnInput" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onkeyDown fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs> "OnkeyDown" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onkeyUp fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs> "OnkeyUp" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onMouseUp fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnMouseUp" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onPressEnter fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs> "OnPressEnter" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline placeholder (x: System.String) = "Placeholder" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline prefix (x: Microsoft.AspNetCore.Components.RenderFragment) = "Prefix" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline readOnly (x: System.Boolean) = "ReadOnly" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline suffix (x: Microsoft.AspNetCore.Components.RenderFragment) = "Suffix" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline type' (x: System.String) = "Type" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline wrapperStyle (x: System.String) = "WrapperStyle" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline additionalAttributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "AdditionalAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline value (x: 'TValue) = "Value" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valueChanged fn = (Bolero.Html.attr.callback<'TValue> "ValueChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valueExpression (x: System.Linq.Expressions.Expression<System.Func<'TValue>>) = "ValueExpression" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valuesExpression (x: System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.IEnumerable<'TValue>>>) = "ValuesExpression" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline size (x: System.String) = "Size" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline cultureInfo (x: System.Globalization.CultureInfo) = "CultureInfo" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type inputGroup<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.InputGroup>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<AntDesign.InputGroup>
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline compact (x: System.Boolean) = "Compact" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline size (x: System.String) = "Size" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type inputPassword<'FunBlazorGeneric> =
    inherit input<'FunBlazorGeneric, System.String>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.InputPassword>
    
    static member inline iconRender (x: Microsoft.AspNetCore.Components.RenderFragment) = "IconRender" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline showPassword (x: System.Boolean) = "ShowPassword" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline visibilityToggle (x: System.Boolean) = "VisibilityToggle" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline addOnBefore (x: Microsoft.AspNetCore.Components.RenderFragment) = "AddOnBefore" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline addOnAfter (x: Microsoft.AspNetCore.Components.RenderFragment) = "AddOnAfter" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline allowClear (x: System.Boolean) = "AllowClear" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline autoFocus (x: System.Boolean) = "AutoFocus" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline bordered (x: System.Boolean) = "Bordered" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline debounceMilliseconds (x: System.Int32) = "DebounceMilliseconds" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline defaultValue (x: System.String) = "DefaultValue" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabled (x: System.Boolean) = "Disabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline inputElementSuffixClass (x: System.String) = "InputElementSuffixClass" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline maxLength (x: System.Int32) = "MaxLength" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onBlur fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.FocusEventArgs> "OnBlur" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onChange fn = (Bolero.Html.attr.callback<System.String> "OnChange" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onFocus fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.FocusEventArgs> "OnFocus" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onInput fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.ChangeEventArgs> "OnInput" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onkeyDown fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs> "OnkeyDown" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onkeyUp fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs> "OnkeyUp" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onMouseUp fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnMouseUp" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onPressEnter fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs> "OnPressEnter" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline placeholder (x: System.String) = "Placeholder" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline prefix (x: Microsoft.AspNetCore.Components.RenderFragment) = "Prefix" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline readOnly (x: System.Boolean) = "ReadOnly" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline suffix (x: Microsoft.AspNetCore.Components.RenderFragment) = "Suffix" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline type' (x: System.String) = "Type" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline wrapperStyle (x: System.String) = "WrapperStyle" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline additionalAttributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "AdditionalAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline value (x: System.String) = "Value" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valueChanged fn = (Bolero.Html.attr.callback<System.String> "ValueChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valueExpression (x: System.Linq.Expressions.Expression<System.Func<System.String>>) = "ValueExpression" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valuesExpression (x: System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.IEnumerable<System.String>>>) = "ValuesExpression" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline size (x: System.String) = "Size" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline cultureInfo (x: System.Globalization.CultureInfo) = "CultureInfo" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type search<'FunBlazorGeneric> =
    inherit input<'FunBlazorGeneric, System.String>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.Search>
    
    static member inline classicSearchIcon (x: System.Boolean) = "ClassicSearchIcon" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline enterButton (x: OneOf.OneOf<System.Boolean, System.String>) = "EnterButton" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline loading (x: System.Boolean) = "Loading" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onSearch fn = (Bolero.Html.attr.callback<System.String> "OnSearch" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline addOnBefore (x: Microsoft.AspNetCore.Components.RenderFragment) = "AddOnBefore" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline addOnAfter (x: Microsoft.AspNetCore.Components.RenderFragment) = "AddOnAfter" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline allowClear (x: System.Boolean) = "AllowClear" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline autoFocus (x: System.Boolean) = "AutoFocus" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline bordered (x: System.Boolean) = "Bordered" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline debounceMilliseconds (x: System.Int32) = "DebounceMilliseconds" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline defaultValue (x: System.String) = "DefaultValue" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabled (x: System.Boolean) = "Disabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline inputElementSuffixClass (x: System.String) = "InputElementSuffixClass" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline maxLength (x: System.Int32) = "MaxLength" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onBlur fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.FocusEventArgs> "OnBlur" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onChange fn = (Bolero.Html.attr.callback<System.String> "OnChange" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onFocus fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.FocusEventArgs> "OnFocus" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onInput fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.ChangeEventArgs> "OnInput" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onkeyDown fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs> "OnkeyDown" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onkeyUp fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs> "OnkeyUp" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onMouseUp fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnMouseUp" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onPressEnter fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs> "OnPressEnter" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline placeholder (x: System.String) = "Placeholder" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline prefix (x: Microsoft.AspNetCore.Components.RenderFragment) = "Prefix" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline readOnly (x: System.Boolean) = "ReadOnly" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline suffix (x: Microsoft.AspNetCore.Components.RenderFragment) = "Suffix" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline type' (x: System.String) = "Type" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline wrapperStyle (x: System.String) = "WrapperStyle" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline additionalAttributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "AdditionalAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline value (x: System.String) = "Value" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valueChanged fn = (Bolero.Html.attr.callback<System.String> "ValueChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valueExpression (x: System.Linq.Expressions.Expression<System.Func<System.String>>) = "ValueExpression" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valuesExpression (x: System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.IEnumerable<System.String>>>) = "ValuesExpression" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline size (x: System.String) = "Size" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline cultureInfo (x: System.Globalization.CultureInfo) = "CultureInfo" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type textArea<'FunBlazorGeneric> =
    inherit input<'FunBlazorGeneric, System.String>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.TextArea>
    
    static member inline autoSize (x: System.Boolean) = "AutoSize" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline defaultToEmptyString (x: System.Boolean) = "DefaultToEmptyString" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline maxRows (x: System.UInt32) = "MaxRows" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline minRows (x: System.UInt32) = "MinRows" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onResize fn = (Bolero.Html.attr.callback<AntDesign.OnResizeEventArgs> "OnResize" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline showCount (x: System.Boolean) = "ShowCount" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline addOnBefore (x: Microsoft.AspNetCore.Components.RenderFragment) = "AddOnBefore" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline addOnAfter (x: Microsoft.AspNetCore.Components.RenderFragment) = "AddOnAfter" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline allowClear (x: System.Boolean) = "AllowClear" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline autoFocus (x: System.Boolean) = "AutoFocus" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline bordered (x: System.Boolean) = "Bordered" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline debounceMilliseconds (x: System.Int32) = "DebounceMilliseconds" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline defaultValue (x: System.String) = "DefaultValue" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabled (x: System.Boolean) = "Disabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline inputElementSuffixClass (x: System.String) = "InputElementSuffixClass" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline maxLength (x: System.Int32) = "MaxLength" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onBlur fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.FocusEventArgs> "OnBlur" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onChange fn = (Bolero.Html.attr.callback<System.String> "OnChange" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onFocus fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.FocusEventArgs> "OnFocus" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onInput fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.ChangeEventArgs> "OnInput" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onkeyDown fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs> "OnkeyDown" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onkeyUp fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs> "OnkeyUp" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onMouseUp fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnMouseUp" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onPressEnter fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs> "OnPressEnter" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline placeholder (x: System.String) = "Placeholder" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline prefix (x: Microsoft.AspNetCore.Components.RenderFragment) = "Prefix" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline readOnly (x: System.Boolean) = "ReadOnly" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline suffix (x: Microsoft.AspNetCore.Components.RenderFragment) = "Suffix" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline type' (x: System.String) = "Type" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline wrapperStyle (x: System.String) = "WrapperStyle" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline additionalAttributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "AdditionalAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline value (x: System.String) = "Value" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valueChanged fn = (Bolero.Html.attr.callback<System.String> "ValueChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valueExpression (x: System.Linq.Expressions.Expression<System.Func<System.String>>) = "ValueExpression" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valuesExpression (x: System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.IEnumerable<System.String>>>) = "ValuesExpression" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline size (x: System.String) = "Size" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline cultureInfo (x: System.Globalization.CultureInfo) = "CultureInfo" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type sider<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.Sider>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<AntDesign.Sider>
    static member inline collapsible (x: System.Boolean) = "Collapsible" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline trigger (x: Microsoft.AspNetCore.Components.RenderFragment) = "Trigger" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline noTrigger (x: System.Boolean) = "NoTrigger" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline breakpoint (x: AntDesign.BreakpointType) = "Breakpoint" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline theme (x: AntDesign.SiderTheme) = "Theme" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline width (x: System.Int32) = "Width" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline collapsedWidth (x: System.Int32) = "CollapsedWidth" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline collapsed (x: System.Boolean) = "Collapsed" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onCollapse fn = (Bolero.Html.attr.callback<System.Boolean> "OnCollapse" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onBreakpoint fn = (Bolero.Html.attr.callback<System.Boolean> "OnBreakpoint" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type antList<'FunBlazorGeneric, 'TItem> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.AntList<'TItem>>
    
    static member inline dataSource (x: System.Collections.Generic.IEnumerable<'TItem>) = "DataSource" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline bordered (x: System.Boolean) = "Bordered" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline header (x: Microsoft.AspNetCore.Components.RenderFragment) = "Header" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline footer (x: Microsoft.AspNetCore.Components.RenderFragment) = "Footer" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline loadMore (x: Microsoft.AspNetCore.Components.RenderFragment) = "LoadMore" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline itemLayout (x: AntDesign.ListItemLayout) = "ItemLayout" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline loading (x: System.Boolean) = "Loading" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline noResult (x: System.String) = "NoResult" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline size (x: System.String) = "Size" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline split (x: System.Boolean) = "Split" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onItemClick fn = (Bolero.Html.attr.callback<'TItem> "OnItemClick" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline grid (x: AntDesign.ListGridType) = "Grid" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline pagination (x: AntDesign.PaginationOptions) = "Pagination" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (x: Microsoft.AspNetCore.Components.RenderFragment<'TItem>) = "ChildContent" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type listItem<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.ListItem>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<AntDesign.ListItem>
    static member inline content (x: System.String) = "Content" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline extra (x: Microsoft.AspNetCore.Components.RenderFragment) = "Extra" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline actions (x: System.Collections.Generic.IEnumerable<Microsoft.AspNetCore.Components.RenderFragment>) = "Actions" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline grid (x: AntDesign.ListGridType) = "Grid" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline colStyle (x: System.String) = "ColStyle" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline itemCount (x: System.Int32) = "ItemCount" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onClick (x: Microsoft.AspNetCore.Components.EventCallback) = "OnClick" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline noFlex (x: System.Boolean) = "NoFlex" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type listItemMeta<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.ListItemMeta>
    
    static member inline title (x: System.String) = "Title" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline titleTemplate (x: Microsoft.AspNetCore.Components.RenderFragment) = "TitleTemplate" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline avatar (x: System.String) = "Avatar" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline avatarTemplate (x: Microsoft.AspNetCore.Components.RenderFragment) = "AvatarTemplate" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline description (x: System.String) = "Description" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline descriptionTemplate (x: Microsoft.AspNetCore.Components.RenderFragment) = "DescriptionTemplate" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type mentions<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.Mentions>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<AntDesign.Mentions>
    static member inline autoFocus (x: System.Boolean) = "AutoFocus" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disable (x: System.Boolean) = "Disable" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline readonly (x: System.Boolean) = "Readonly" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline prefix (x: System.String) = "Prefix" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline split (x: System.String) = "Split" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline defaultValue (x: System.String) = "DefaultValue" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline placeholder (x: System.String) = "Placeholder" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline value (x: System.String) = "Value" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline placement (x: System.String) = "Placement" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline rows (x: System.Int32) = "Rows" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline loading (x: System.Boolean) = "Loading" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valueChange fn = (Bolero.Html.attr.callback<System.String> "ValueChange" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onFocus fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.FocusEventArgs> "OnFocus" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onBlur fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.FocusEventArgs> "OnBlur" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onSearch fn = (Bolero.Html.attr.callback<System.EventArgs> "OnSearch" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline noFoundContent (x: Microsoft.AspNetCore.Components.RenderFragment) = "NoFoundContent" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type mentionsOption<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.MentionsOption>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<AntDesign.MentionsOption>
    static member inline value (x: System.String) = "Value" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disable (x: System.Boolean) = "Disable" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type menu<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.Menu>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<AntDesign.Menu>
    static member inline theme (x: AntDesign.MenuTheme) = "Theme" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline mode (x: AntDesign.MenuMode) = "Mode" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onSubmenuClicked fn = (Bolero.Html.attr.callback<AntDesign.SubMenu> "OnSubmenuClicked" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onMenuItemClicked fn = (Bolero.Html.attr.callback<AntDesign.MenuItem> "OnMenuItemClicked" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline accordion (x: System.Boolean) = "Accordion" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline selectable (x: System.Boolean) = "Selectable" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline multiple (x: System.Boolean) = "Multiple" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline inlineCollapsed (x: System.Boolean) = "InlineCollapsed" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline inlineIndent (x: System.Int32) = "InlineIndent" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline autoCloseDropdown (x: System.Boolean) = "AutoCloseDropdown" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline defaultSelectedKeys (x: System.Collections.Generic.IEnumerable<System.String>) = "DefaultSelectedKeys" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline defaultOpenKeys (x: System.Collections.Generic.IEnumerable<System.String>) = "DefaultOpenKeys" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline openKeys (x: System.Collections.Generic.IEnumerable<System.String>) = "OpenKeys" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline openKeysChanged fn = (Bolero.Html.attr.callback<System.Collections.Generic.IEnumerable<System.String>> "OpenKeysChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onOpenChange fn = (Bolero.Html.attr.callback<System.Collections.Generic.IEnumerable<System.String>> "OnOpenChange" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline selectedKeys (x: System.Collections.Generic.IEnumerable<System.String>) = "SelectedKeys" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline selectedKeysChanged fn = (Bolero.Html.attr.callback<System.Collections.Generic.IEnumerable<System.String>> "SelectedKeysChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline triggerSubMenuAction (x: AntDesign.TriggerType) = "TriggerSubMenuAction" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type menuItem<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.MenuItem>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<AntDesign.MenuItem>
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline key (x: System.String) = "Key" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabled (x: System.Boolean) = "Disabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onClick fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnClick" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline routerLink (x: System.String) = "RouterLink" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline routerMatch (x: Microsoft.AspNetCore.Components.Routing.NavLinkMatch) = "RouterMatch" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline title (x: System.String) = "Title" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline icon (x: System.String) = "Icon" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type menuItemGroup<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.MenuItemGroup>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<AntDesign.MenuItemGroup>
    static member inline title (x: System.String) = "Title" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline titleTemplate (x: Microsoft.AspNetCore.Components.RenderFragment) = "TitleTemplate" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline key (x: System.String) = "Key" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type menuLink<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.MenuLink>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<AntDesign.MenuLink>
    static member inline activeClass (x: System.String) = "ActiveClass" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline href (x: System.String) = "Href" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline attributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "Attributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline match' (x: Microsoft.AspNetCore.Components.Routing.NavLinkMatch) = "Match" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type subMenu<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.SubMenu>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<AntDesign.SubMenu>
    static member inline placement (x: AntDesign.PlacementType) = "Placement" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline title (x: System.String) = "Title" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline titleTemplate (x: Microsoft.AspNetCore.Components.RenderFragment) = "TitleTemplate" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline key (x: System.String) = "Key" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabled (x: System.Boolean) = "Disabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline isOpen (x: System.Boolean) = "IsOpen" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onTitleClick fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnTitleClick" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type message<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.Message>
    
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type messageItem<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.MessageItem>
    
    static member inline config (x: AntDesign.MessageConfig) = "Config" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type comfirmContainer<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.ComfirmContainer>
    
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type confirm<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.Confirm>
    
    static member inline config (x: AntDesign.ConfirmOptions) = "Config" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline confirmRef (x: AntDesign.ConfirmRef) = "ConfirmRef" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onRemove fn = (Bolero.Html.attr.callback<AntDesign.ConfirmRef> "OnRemove" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type dialog<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.Dialog>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<AntDesign.Dialog>
    static member inline config (x: AntDesign.DialogOptions) = "Config" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline visible (x: System.Boolean) = "Visible" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type dialogWrapper<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.DialogWrapper>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<AntDesign.DialogWrapper>
    static member inline config (x: AntDesign.DialogOptions) = "Config" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline destroyOnClose (x: System.Boolean) = "DestroyOnClose" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline visible (x: System.Boolean) = "Visible" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onBeforeDestroy fn = (Bolero.Html.attr.callback<System.ComponentModel.CancelEventArgs> "OnBeforeDestroy" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onAfterShow (x: Microsoft.AspNetCore.Components.EventCallback) = "OnAfterShow" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onAfterHide (x: Microsoft.AspNetCore.Components.EventCallback) = "OnAfterHide" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type modal<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.Modal>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<AntDesign.Modal>
    static member inline modalRef (x: AntDesign.ModalRef) = "ModalRef" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline afterClose (x: System.Func<System.Threading.Tasks.Task>) = "AfterClose" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline bodyStyle (x: System.String) = "BodyStyle" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline cancelText (x: System.Nullable<OneOf.OneOf<System.String, Microsoft.AspNetCore.Components.RenderFragment>>) = "CancelText" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline centered (x: System.Boolean) = "Centered" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline closable (x: System.Boolean) = "Closable" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline draggable (x: System.Boolean) = "Draggable" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline dragInViewport (x: System.Boolean) = "DragInViewport" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline closeIcon (x: Microsoft.AspNetCore.Components.RenderFragment) = "CloseIcon" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline confirmLoading (x: System.Boolean) = "ConfirmLoading" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline destroyOnClose (x: System.Boolean) = "DestroyOnClose" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline footer (x: System.Nullable<OneOf.OneOf<System.String, Microsoft.AspNetCore.Components.RenderFragment>>) = "Footer" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline getContainer (x: System.Nullable<Microsoft.AspNetCore.Components.ElementReference>) = "GetContainer" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline keyboard (x: System.Boolean) = "Keyboard" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline mask (x: System.Boolean) = "Mask" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline maskClosable (x: System.Boolean) = "MaskClosable" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline maskStyle (x: System.String) = "MaskStyle" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline okText (x: System.Nullable<OneOf.OneOf<System.String, Microsoft.AspNetCore.Components.RenderFragment>>) = "OkText" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline okType (x: System.String) = "OkType" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline title (x: System.String) = "Title" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline titleTemplate (x: Microsoft.AspNetCore.Components.RenderFragment) = "TitleTemplate" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline visible (x: System.Boolean) = "Visible" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline width (x: OneOf.OneOf<System.String, System.Double>) = "Width" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline wrapClassName (x: System.String) = "WrapClassName" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline zIndex (x: System.Int32) = "ZIndex" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onCancel fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnCancel" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onOk fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnOk" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline okButtonProps (x: AntDesign.ButtonProps) = "OkButtonProps" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline cancelButtonProps (x: AntDesign.ButtonProps) = "CancelButtonProps" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline locale (x: AntDesign.ModalLocale) = "Locale" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type modalContainer<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.ModalContainer>
    
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type modalFooter<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.ModalFooter>
    
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type notification<'FunBlazorGeneric> =
    inherit notificationBase<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.Notification>
    
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type notificationBase<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.NotificationBase>
    
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type notificationItem<'FunBlazorGeneric> =
    inherit notificationBase<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.NotificationItem>
    
    static member inline config (x: AntDesign.NotificationConfig) = "Config" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onClose (x: System.Func<AntDesign.NotificationConfig, System.Threading.Tasks.Task>) = "OnClose" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type pageHeader<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.PageHeader>
    
    static member inline ghost (x: System.Boolean) = "Ghost" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline backIcon (x: OneOf.OneOf<System.Nullable<System.Boolean>, System.String>) = "BackIcon" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline backIconTemplate (x: Microsoft.AspNetCore.Components.RenderFragment) = "BackIconTemplate" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline title (x: System.String) = "Title" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline titleTemplate (x: Microsoft.AspNetCore.Components.RenderFragment) = "TitleTemplate" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline subtitle (x: System.String) = "Subtitle" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline subtitleTemplate (x: Microsoft.AspNetCore.Components.RenderFragment) = "SubtitleTemplate" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onBack (x: Microsoft.AspNetCore.Components.EventCallback) = "OnBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline pageHeaderContent (x: Microsoft.AspNetCore.Components.RenderFragment) = "PageHeaderContent" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline pageHeaderFooter (x: Microsoft.AspNetCore.Components.RenderFragment) = "PageHeaderFooter" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline pageHeaderBreadcrumb (x: Microsoft.AspNetCore.Components.RenderFragment) = "PageHeaderBreadcrumb" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline pageHeaderAvatar (x: Microsoft.AspNetCore.Components.RenderFragment) = "PageHeaderAvatar" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline pageHeaderTitle (x: Microsoft.AspNetCore.Components.RenderFragment) = "PageHeaderTitle" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline pageHeaderSubtitle (x: Microsoft.AspNetCore.Components.RenderFragment) = "PageHeaderSubtitle" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline pageHeaderTags (x: Microsoft.AspNetCore.Components.RenderFragment) = "PageHeaderTags" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline pageHeaderExtra (x: Microsoft.AspNetCore.Components.RenderFragment) = "PageHeaderExtra" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type pagination<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.Pagination>
    
    static member inline total (x: System.Int32) = "Total" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline defaultCurrent (x: System.Int32) = "DefaultCurrent" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabled (x: System.Boolean) = "Disabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline current (x: System.Int32) = "Current" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline defaultPageSize (x: System.Int32) = "DefaultPageSize" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline pageSize (x: System.Int32) = "PageSize" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onChange fn = (Bolero.Html.attr.callback<AntDesign.PaginationEventArgs> "OnChange" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline hideOnSinglePage (x: System.Boolean) = "HideOnSinglePage" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline showSizeChanger (x: System.Boolean) = "ShowSizeChanger" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline pageSizeOptions (x: System.Collections.Generic.IEnumerable<System.Int32>) = "PageSizeOptions" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onShowSizeChange fn = (Bolero.Html.attr.callback<AntDesign.PaginationEventArgs> "OnShowSizeChange" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline showQuickJumper (x: System.Boolean) = "ShowQuickJumper" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline goButton (x: Microsoft.AspNetCore.Components.RenderFragment) = "GoButton" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline showTitle (x: System.Boolean) = "ShowTitle" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline showTotal (x: System.Nullable<OneOf.OneOf<System.Func<AntDesign.PaginationTotalContext, System.String>, Microsoft.AspNetCore.Components.RenderFragment<AntDesign.PaginationTotalContext>>>) = "ShowTotal" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline size (x: System.String) = "Size" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline responsive (x: System.Boolean) = "Responsive" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline simple (x: System.Boolean) = "Simple" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline locale (x: AntDesign.PaginationLocale) = "Locale" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline itemRender (x: Microsoft.AspNetCore.Components.RenderFragment<AntDesign.PaginationItemRenderContext>) = "ItemRender" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline showLessItems (x: System.Boolean) = "ShowLessItems" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline showPrevNextJumpers (x: System.Boolean) = "ShowPrevNextJumpers" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline direction (x: System.String) = "Direction" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline prevIcon (x: Microsoft.AspNetCore.Components.RenderFragment<AntDesign.PaginationItemRenderContext>) = "PrevIcon" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline nextIcon (x: Microsoft.AspNetCore.Components.RenderFragment<AntDesign.PaginationItemRenderContext>) = "NextIcon" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline jumpPrevIcon (x: Microsoft.AspNetCore.Components.RenderFragment<AntDesign.PaginationItemRenderContext>) = "JumpPrevIcon" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline jumpNextIcon (x: Microsoft.AspNetCore.Components.RenderFragment<AntDesign.PaginationItemRenderContext>) = "JumpNextIcon" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline totalBoundaryShowSizeChanger (x: System.Int32) = "TotalBoundaryShowSizeChanger" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline unmatchedAttributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "UnmatchedAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type paginationOptions<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.PaginationOptions>
    
    static member inline isSmall (x: System.Boolean) = "IsSmall" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabled (x: System.Boolean) = "Disabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline rootPrefixCls (x: System.String) = "RootPrefixCls" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline changeSize fn = (Bolero.Html.attr.callback<System.Int32> "ChangeSize" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline current (x: System.Int32) = "Current" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline pageSize (x: System.Int32) = "PageSize" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline pageSizeOptions (x: System.Collections.Generic.IEnumerable<System.Int32>) = "PageSizeOptions" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline quickGo fn = (Bolero.Html.attr.callback<System.Int32> "QuickGo" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline goButton (x: System.Nullable<OneOf.OneOf<System.Boolean, Microsoft.AspNetCore.Components.RenderFragment>>) = "GoButton" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type popconfirm<'FunBlazorGeneric> =
    inherit overlayTrigger<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.Popconfirm>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<AntDesign.Popconfirm>
    static member inline title (x: System.String) = "Title" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline titleTemplate (x: Microsoft.AspNetCore.Components.RenderFragment) = "TitleTemplate" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline cancelText (x: System.String) = "CancelText" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline okText (x: System.String) = "OkText" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline okType (x: System.String) = "OkType" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline okButtonProps (x: AntDesign.ButtonProps) = "OkButtonProps" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline cancelButtonProps (x: AntDesign.ButtonProps) = "CancelButtonProps" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline icon (x: System.String) = "Icon" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline iconTemplate (x: Microsoft.AspNetCore.Components.RenderFragment) = "IconTemplate" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onCancel fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnCancel" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onConfirm fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnConfirm" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline arrowPointAtCenter (x: System.Boolean) = "ArrowPointAtCenter" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline mouseEnterDelay (x: System.Double) = "MouseEnterDelay" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline mouseLeaveDelay (x: System.Double) = "MouseLeaveDelay" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline boundaryAdjustMode (x: AntDesign.TriggerBoundaryAdjustMode) = "BoundaryAdjustMode" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline complexAutoCloseAndVisible (x: System.Boolean) = "ComplexAutoCloseAndVisible" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabled (x: System.Boolean) = "Disabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline hiddenMode (x: System.Boolean) = "HiddenMode" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline inlineFlexMode (x: System.Boolean) = "InlineFlexMode" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline isButton (x: System.Boolean) = "IsButton" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onClick fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnClick" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onMaskClick (x: Microsoft.AspNetCore.Components.EventCallback) = "OnMaskClick" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onMouseEnter (x: System.Action) = "OnMouseEnter" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onMouseLeave (x: System.Action) = "OnMouseLeave" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onOverlayHiding fn = (Bolero.Html.attr.callback<System.Boolean> "OnOverlayHiding" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onVisibleChange fn = (Bolero.Html.attr.callback<System.Boolean> "OnVisibleChange" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline overlay (x: Microsoft.AspNetCore.Components.RenderFragment) = "Overlay" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline overlayClassName (x: System.String) = "OverlayClassName" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline overlayEnterCls (x: System.String) = "OverlayEnterCls" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline overlayHiddenCls (x: System.String) = "OverlayHiddenCls" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline overlayLeaveCls (x: System.String) = "OverlayLeaveCls" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline overlayStyle (x: System.String) = "OverlayStyle" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline placement (x: AntDesign.PlacementType) = "Placement" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline placementCls (x: System.String) = "PlacementCls" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline popupContainerSelector (x: System.String) = "PopupContainerSelector" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline trigger (x: System.Collections.Generic.IEnumerable<AntDesign.TriggerType>) = "Trigger" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline triggerReference (x: Microsoft.AspNetCore.Components.ElementReference) = "TriggerReference" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline unbound (x: Microsoft.AspNetCore.Components.RenderFragment<AntDesign.ForwardRef>) = "Unbound" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline visible (x: System.Boolean) = "Visible" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type popover<'FunBlazorGeneric> =
    inherit overlayTrigger<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.Popover>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<AntDesign.Popover>
    static member inline title (x: System.String) = "Title" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline titleTemplate (x: Microsoft.AspNetCore.Components.RenderFragment) = "TitleTemplate" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline content (x: System.String) = "Content" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline contentTemplate (x: Microsoft.AspNetCore.Components.RenderFragment) = "ContentTemplate" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline arrowPointAtCenter (x: System.Boolean) = "ArrowPointAtCenter" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline mouseEnterDelay (x: System.Double) = "MouseEnterDelay" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline mouseLeaveDelay (x: System.Double) = "MouseLeaveDelay" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline boundaryAdjustMode (x: AntDesign.TriggerBoundaryAdjustMode) = "BoundaryAdjustMode" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline complexAutoCloseAndVisible (x: System.Boolean) = "ComplexAutoCloseAndVisible" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabled (x: System.Boolean) = "Disabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline hiddenMode (x: System.Boolean) = "HiddenMode" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline inlineFlexMode (x: System.Boolean) = "InlineFlexMode" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline isButton (x: System.Boolean) = "IsButton" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onClick fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnClick" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onMaskClick (x: Microsoft.AspNetCore.Components.EventCallback) = "OnMaskClick" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onMouseEnter (x: System.Action) = "OnMouseEnter" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onMouseLeave (x: System.Action) = "OnMouseLeave" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onOverlayHiding fn = (Bolero.Html.attr.callback<System.Boolean> "OnOverlayHiding" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onVisibleChange fn = (Bolero.Html.attr.callback<System.Boolean> "OnVisibleChange" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline overlay (x: Microsoft.AspNetCore.Components.RenderFragment) = "Overlay" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline overlayClassName (x: System.String) = "OverlayClassName" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline overlayEnterCls (x: System.String) = "OverlayEnterCls" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline overlayHiddenCls (x: System.String) = "OverlayHiddenCls" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline overlayLeaveCls (x: System.String) = "OverlayLeaveCls" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline overlayStyle (x: System.String) = "OverlayStyle" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline placement (x: AntDesign.PlacementType) = "Placement" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline placementCls (x: System.String) = "PlacementCls" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline popupContainerSelector (x: System.String) = "PopupContainerSelector" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline trigger (x: System.Collections.Generic.IEnumerable<AntDesign.TriggerType>) = "Trigger" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline triggerReference (x: Microsoft.AspNetCore.Components.ElementReference) = "TriggerReference" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline unbound (x: Microsoft.AspNetCore.Components.RenderFragment<AntDesign.ForwardRef>) = "Unbound" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline visible (x: System.Boolean) = "Visible" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type progress<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.Progress>
    
    static member inline size (x: AntDesign.ProgressSize) = "Size" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline type' (x: AntDesign.ProgressType) = "Type" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline format (x: System.Func<System.Double, System.String>) = "Format" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline percent (x: System.Double) = "Percent" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline showInfo (x: System.Boolean) = "ShowInfo" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline status (x: AntDesign.ProgressStatus) = "Status" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline strokeLinecap (x: AntDesign.ProgressStrokeLinecap) = "StrokeLinecap" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline successPercent (x: System.Double) = "SuccessPercent" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline trailColor (x: System.String) = "TrailColor" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline strokeWidth (x: System.Int32) = "StrokeWidth" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline strokeColor (x: OneOf.OneOf<System.String, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.String>>>) = "StrokeColor" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline steps (x: System.Int32) = "Steps" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline width (x: System.Int32) = "Width" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline gapDegree (x: System.Int32) = "GapDegree" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline gapPosition (x: AntDesign.ProgressGapPosition) = "GapPosition" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type radio<'FunBlazorGeneric, 'TValue> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.Radio<'TValue>>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<AntDesign.Radio<'TValue>>
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline value (x: 'TValue) = "Value" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline autoFocus (x: System.Boolean) = "AutoFocus" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline radioButton (x: System.Boolean) = "RadioButton" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline checked' (x: System.Boolean) = "Checked" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline defaultChecked (x: System.Boolean) = "DefaultChecked" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline checkedChanged fn = (Bolero.Html.attr.callback<System.Boolean> "CheckedChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabled (x: System.Boolean) = "Disabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline checkedChange fn = (Bolero.Html.attr.callback<System.Boolean> "CheckedChange" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type radioGroup<'FunBlazorGeneric, 'TValue> =
    inherit antInputComponentBase<'FunBlazorGeneric, 'TValue>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.RadioGroup<'TValue>>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<AntDesign.RadioGroup<'TValue>>
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabled (x: System.Boolean) = "Disabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline buttonStyle (x: System.String) = "ButtonStyle" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline name (x: System.String) = "Name" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline defaultValue (x: 'TValue) = "DefaultValue" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onChange fn = (Bolero.Html.attr.callback<'TValue> "OnChange" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline additionalAttributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "AdditionalAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline value (x: 'TValue) = "Value" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valueChanged fn = (Bolero.Html.attr.callback<'TValue> "ValueChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valueExpression (x: System.Linq.Expressions.Expression<System.Func<'TValue>>) = "ValueExpression" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valuesExpression (x: System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.IEnumerable<'TValue>>>) = "ValuesExpression" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline size (x: System.String) = "Size" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline cultureInfo (x: System.Globalization.CultureInfo) = "CultureInfo" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type rate<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.Rate>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<AntDesign.Rate>
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline allowClear (x: System.Boolean) = "AllowClear" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline allowHalf (x: System.Boolean) = "AllowHalf" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabled (x: System.Boolean) = "Disabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline autoFocus (x: System.Boolean) = "AutoFocus" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline character (x: Microsoft.AspNetCore.Components.RenderFragment<AntDesign.RateItemRenderContext>) = "Character" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline count (x: System.Int32) = "Count" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline value (x: System.Decimal) = "Value" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valueChanged fn = (Bolero.Html.attr.callback<System.Decimal> "ValueChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline defaultValue (x: System.Decimal) = "DefaultValue" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline tooltips (x: System.Collections.Generic.IEnumerable<System.String>) = "Tooltips" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onBlur fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.FocusEventArgs> "OnBlur" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onFocus fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.FocusEventArgs> "OnFocus" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type rateItem<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.RateItem>
    
    static member inline allowHalf (x: System.Boolean) = "AllowHalf" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onItemHover fn = (Bolero.Html.attr.callback<System.Boolean> "OnItemHover" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onItemClick fn = (Bolero.Html.attr.callback<System.Boolean> "OnItemClick" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline tooltip (x: System.String) = "Tooltip" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline indexOfGroup (x: System.Int32) = "IndexOfGroup" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline hoverValue (x: System.Int32) = "HoverValue" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline hasHalf (x: System.Boolean) = "HasHalf" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline isFocused (x: System.Boolean) = "IsFocused" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type result<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.Result>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<AntDesign.Result>
    static member inline title (x: System.String) = "Title" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline titleTemplate (x: Microsoft.AspNetCore.Components.RenderFragment) = "TitleTemplate" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline subTitle (x: System.String) = "SubTitle" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline subTitleTemplate (x: Microsoft.AspNetCore.Components.RenderFragment) = "SubTitleTemplate" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline extra (x: Microsoft.AspNetCore.Components.RenderFragment) = "Extra" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline status (x: System.String) = "Status" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline icon (x: System.String) = "Icon" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline isShowIcon (x: System.Boolean) = "IsShowIcon" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type select<'FunBlazorGeneric, 'TItemValue, 'TItem> =
    inherit antInputComponentBase<'FunBlazorGeneric, 'TItemValue>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.Select<'TItemValue, 'TItem>>
    
    static member inline allowClear (x: System.Boolean) = "AllowClear" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline autoClearSearchValue (x: System.Boolean) = "AutoClearSearchValue" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline bordered (x: System.Boolean) = "Bordered" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onCreateCustomTag (x: System.Action<System.String>) = "OnCreateCustomTag" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline defaultActiveFirstOption (x: System.Boolean) = "DefaultActiveFirstOption" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabled (x: System.Boolean) = "Disabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabledName (x: System.String) = "DisabledName" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline dropdownRender (x: System.Func<Microsoft.AspNetCore.Components.RenderFragment, Microsoft.AspNetCore.Components.RenderFragment>) = "DropdownRender" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline enableSearch (x: System.Boolean) = "EnableSearch" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline groupName (x: System.String) = "GroupName" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline hideSelected (x: System.Boolean) = "HideSelected" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline ignoreItemChanges (x: System.Boolean) = "IgnoreItemChanges" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline itemTemplate (x: Microsoft.AspNetCore.Components.RenderFragment<'TItem>) = "ItemTemplate" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline labelInValue (x: System.Boolean) = "LabelInValue" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline labelName (x: System.String) = "LabelName" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline labelTemplate (x: Microsoft.AspNetCore.Components.RenderFragment<'TItem>) = "LabelTemplate" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline loading (x: System.Boolean) = "Loading" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline maxTagTextLength (x: System.Int32) = "MaxTagTextLength" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline maxTagCount (x: OneOf.OneOf<System.Int32, AntDesign.Select.ResponsiveTag>) = "MaxTagCount" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline maxTagPlaceholder (x: Microsoft.AspNetCore.Components.RenderFragment<System.Collections.Generic.IEnumerable<'TItem>>) = "MaxTagPlaceholder" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline mode (x: System.String) = "Mode" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline notFoundContent (x: Microsoft.AspNetCore.Components.RenderFragment) = "NotFoundContent" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onBlur (x: System.Action) = "OnBlur" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onClearSelected (x: System.Action) = "OnClearSelected" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onDataSourceChanged (x: System.Action) = "OnDataSourceChanged" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onDropdownVisibleChange (x: System.Action<System.Boolean>) = "OnDropdownVisibleChange" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onFocus (x: System.Action) = "OnFocus" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onMouseEnter (x: System.Action) = "OnMouseEnter" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onMouseLeave (x: System.Action) = "OnMouseLeave" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onSearch (x: System.Action<System.String>) = "OnSearch" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onSelectedItemChanged (x: System.Action<'TItem>) = "OnSelectedItemChanged" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onSelectedItemsChanged (x: System.Action<System.Collections.Generic.IEnumerable<'TItem>>) = "OnSelectedItemsChanged" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline open' (x: System.Boolean) = "Open" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline placeholder (x: System.String) = "Placeholder" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline popupContainerMaxHeight (x: System.String) = "PopupContainerMaxHeight" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline popupContainerSelector (x: System.String) = "PopupContainerSelector" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline dropdownMatchSelectWidth (x: OneOf.OneOf<System.Boolean, System.String>) = "DropdownMatchSelectWidth" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline dropdownMaxWidth (x: System.String) = "DropdownMaxWidth" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline showArrowIcon (x: System.Boolean) = "ShowArrowIcon" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline showSearchIcon (x: System.Boolean) = "ShowSearchIcon" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline sortByGroup (x: AntDesign.SortDirection) = "SortByGroup" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline sortByLabel (x: AntDesign.SortDirection) = "SortByLabel" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline suffixIcon (x: Microsoft.AspNetCore.Components.RenderFragment) = "SuffixIcon" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline prefixIcon (x: Microsoft.AspNetCore.Components.RenderFragment) = "PrefixIcon" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline tokenSeparators (x: System.Collections.Generic.IEnumerable<System.Char>) = "TokenSeparators" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valueChanged fn = (Bolero.Html.attr.callback<'TItemValue> "ValueChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valueName (x: System.String) = "ValueName" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valuesChanged fn = (Bolero.Html.attr.callback<System.Collections.Generic.IEnumerable<'TItemValue>> "ValuesChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline customTagLabelToValue (x: System.Func<System.String, 'TItemValue>) = "CustomTagLabelToValue" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline dataSource (x: System.Collections.Generic.IEnumerable<'TItem>) = "DataSource" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline value (x: 'TItemValue) = "Value" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline defaultValue (x: 'TItemValue) = "DefaultValue" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline values (x: System.Collections.Generic.IEnumerable<'TItemValue>) = "Values" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline defaultValues (x: System.Collections.Generic.IEnumerable<'TItemValue>) = "DefaultValues" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline selectOptions (x: Microsoft.AspNetCore.Components.RenderFragment) = "SelectOptions" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline additionalAttributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "AdditionalAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valueExpression (x: System.Linq.Expressions.Expression<System.Func<'TItemValue>>) = "ValueExpression" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valuesExpression (x: System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.IEnumerable<'TItemValue>>>) = "ValuesExpression" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline size (x: System.String) = "Size" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline cultureInfo (x: System.Globalization.CultureInfo) = "CultureInfo" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type selectOption<'FunBlazorGeneric, 'TItemValue, 'TItem> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.SelectOption<'TItemValue, 'TItem>>
    
    static member inline value (x: 'TItemValue) = "Value" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline label (x: System.String) = "Label" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabled (x: System.Boolean) = "Disabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type simpleSelect<'FunBlazorGeneric> =
    inherit select<'FunBlazorGeneric, System.String, System.String>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.SimpleSelect>
    
    static member inline allowClear (x: System.Boolean) = "AllowClear" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline autoClearSearchValue (x: System.Boolean) = "AutoClearSearchValue" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline bordered (x: System.Boolean) = "Bordered" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onCreateCustomTag (x: System.Action<System.String>) = "OnCreateCustomTag" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline defaultActiveFirstOption (x: System.Boolean) = "DefaultActiveFirstOption" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabled (x: System.Boolean) = "Disabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabledName (x: System.String) = "DisabledName" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline dropdownRender (x: System.Func<Microsoft.AspNetCore.Components.RenderFragment, Microsoft.AspNetCore.Components.RenderFragment>) = "DropdownRender" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline enableSearch (x: System.Boolean) = "EnableSearch" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline groupName (x: System.String) = "GroupName" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline hideSelected (x: System.Boolean) = "HideSelected" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline ignoreItemChanges (x: System.Boolean) = "IgnoreItemChanges" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline itemTemplate (x: Microsoft.AspNetCore.Components.RenderFragment<System.String>) = "ItemTemplate" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline labelInValue (x: System.Boolean) = "LabelInValue" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline labelName (x: System.String) = "LabelName" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline labelTemplate (x: Microsoft.AspNetCore.Components.RenderFragment<System.String>) = "LabelTemplate" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline loading (x: System.Boolean) = "Loading" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline maxTagTextLength (x: System.Int32) = "MaxTagTextLength" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline maxTagCount (x: OneOf.OneOf<System.Int32, AntDesign.Select.ResponsiveTag>) = "MaxTagCount" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline maxTagPlaceholder (x: Microsoft.AspNetCore.Components.RenderFragment<System.Collections.Generic.IEnumerable<System.String>>) = "MaxTagPlaceholder" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline mode (x: System.String) = "Mode" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline notFoundContent (x: Microsoft.AspNetCore.Components.RenderFragment) = "NotFoundContent" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onBlur (x: System.Action) = "OnBlur" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onClearSelected (x: System.Action) = "OnClearSelected" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onDataSourceChanged (x: System.Action) = "OnDataSourceChanged" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onDropdownVisibleChange (x: System.Action<System.Boolean>) = "OnDropdownVisibleChange" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onFocus (x: System.Action) = "OnFocus" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onMouseEnter (x: System.Action) = "OnMouseEnter" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onMouseLeave (x: System.Action) = "OnMouseLeave" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onSearch (x: System.Action<System.String>) = "OnSearch" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onSelectedItemChanged (x: System.Action<System.String>) = "OnSelectedItemChanged" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onSelectedItemsChanged (x: System.Action<System.Collections.Generic.IEnumerable<System.String>>) = "OnSelectedItemsChanged" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline open' (x: System.Boolean) = "Open" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline placeholder (x: System.String) = "Placeholder" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline popupContainerMaxHeight (x: System.String) = "PopupContainerMaxHeight" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline popupContainerSelector (x: System.String) = "PopupContainerSelector" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline dropdownMatchSelectWidth (x: OneOf.OneOf<System.Boolean, System.String>) = "DropdownMatchSelectWidth" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline dropdownMaxWidth (x: System.String) = "DropdownMaxWidth" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline showArrowIcon (x: System.Boolean) = "ShowArrowIcon" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline showSearchIcon (x: System.Boolean) = "ShowSearchIcon" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline sortByGroup (x: AntDesign.SortDirection) = "SortByGroup" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline sortByLabel (x: AntDesign.SortDirection) = "SortByLabel" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline suffixIcon (x: Microsoft.AspNetCore.Components.RenderFragment) = "SuffixIcon" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline prefixIcon (x: Microsoft.AspNetCore.Components.RenderFragment) = "PrefixIcon" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline tokenSeparators (x: System.Collections.Generic.IEnumerable<System.Char>) = "TokenSeparators" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valueChanged fn = (Bolero.Html.attr.callback<System.String> "ValueChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valueName (x: System.String) = "ValueName" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valuesChanged fn = (Bolero.Html.attr.callback<System.Collections.Generic.IEnumerable<System.String>> "ValuesChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline customTagLabelToValue (x: System.Func<System.String, System.String>) = "CustomTagLabelToValue" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline dataSource (x: System.Collections.Generic.IEnumerable<System.String>) = "DataSource" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline value (x: System.String) = "Value" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline defaultValue (x: System.String) = "DefaultValue" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline values (x: System.Collections.Generic.IEnumerable<System.String>) = "Values" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline defaultValues (x: System.Collections.Generic.IEnumerable<System.String>) = "DefaultValues" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline selectOptions (x: Microsoft.AspNetCore.Components.RenderFragment) = "SelectOptions" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline additionalAttributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "AdditionalAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valueExpression (x: System.Linq.Expressions.Expression<System.Func<System.String>>) = "ValueExpression" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valuesExpression (x: System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.IEnumerable<System.String>>>) = "ValuesExpression" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline size (x: System.String) = "Size" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline cultureInfo (x: System.Globalization.CultureInfo) = "CultureInfo" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type simpleSelectOption<'FunBlazorGeneric> =
    inherit selectOption<'FunBlazorGeneric, System.String, System.String>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.SimpleSelectOption>
    
    static member inline value (x: System.String) = "Value" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline label (x: System.String) = "Label" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabled (x: System.Boolean) = "Disabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type skeleton<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.Skeleton>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<AntDesign.Skeleton>
    static member inline active (x: System.Boolean) = "Active" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline loading (x: System.Boolean) = "Loading" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline title (x: System.Boolean) = "Title" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline titleWidth (x: OneOf.OneOf<System.Nullable<System.Int32>, System.String>) = "TitleWidth" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline avatar (x: System.Boolean) = "Avatar" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline avatarSize (x: OneOf.OneOf<System.Nullable<System.Int32>, System.String>) = "AvatarSize" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline avatarShape (x: System.String) = "AvatarShape" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline paragraph (x: System.Boolean) = "Paragraph" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline paragraphRows (x: System.Nullable<System.Int32>) = "ParagraphRows" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline paragraphWidth (x: OneOf.OneOf<System.Nullable<System.Int32>, System.String, System.Collections.Generic.IEnumerable<OneOf.OneOf<System.Nullable<System.Int32>, System.String>>>) = "ParagraphWidth" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type skeletonElement<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.SkeletonElement>
    
    static member inline active (x: System.Boolean) = "Active" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline type' (x: System.String) = "Type" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline size (x: OneOf.OneOf<System.Nullable<System.Int32>, System.String>) = "Size" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline shape (x: System.String) = "Shape" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type slider<'FunBlazorGeneric, 'TValue> =
    inherit antInputComponentBase<'FunBlazorGeneric, 'TValue>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.Slider<'TValue>>
    
    static member inline defaultValue (x: 'TValue) = "DefaultValue" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabled (x: System.Boolean) = "Disabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline dots (x: System.Boolean) = "Dots" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline included (x: System.Boolean) = "Included" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline marks (x: System.Collections.Generic.IEnumerable<AntDesign.SliderMark>) = "Marks" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline max (x: System.Double) = "Max" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline min (x: System.Double) = "Min" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline reverse (x: System.Boolean) = "Reverse" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline step (x: System.Nullable<System.Double>) = "Step" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline vertical (x: System.Boolean) = "Vertical" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onAfterChange (x: System.Action<'TValue>) = "OnAfterChange" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onChange (x: System.Action<'TValue>) = "OnChange" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline hasTooltip (x: System.Boolean) = "HasTooltip" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline tipFormatter (x: System.Func<System.Double, System.String>) = "TipFormatter" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline tooltipPlacement (x: AntDesign.PlacementType) = "TooltipPlacement" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline tooltipVisible (x: System.Boolean) = "TooltipVisible" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline getTooltipPopupContainer (x: System.Object) = "GetTooltipPopupContainer" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline value (x: 'TValue) = "Value" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline additionalAttributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "AdditionalAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valueChanged fn = (Bolero.Html.attr.callback<'TValue> "ValueChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valueExpression (x: System.Linq.Expressions.Expression<System.Func<'TValue>>) = "ValueExpression" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valuesExpression (x: System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.IEnumerable<'TValue>>>) = "ValuesExpression" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline size (x: System.String) = "Size" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline cultureInfo (x: System.Globalization.CultureInfo) = "CultureInfo" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type space<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.Space>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<AntDesign.Space>
    static member inline align (x: System.String) = "Align" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline direction (x: AntDesign.DirectionVHType) = "Direction" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline size (x: OneOf.OneOf<System.String, System.ValueTuple<System.String, System.String>>) = "Size" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline wrap (x: System.Boolean) = "Wrap" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline split (x: Microsoft.AspNetCore.Components.RenderFragment) = "Split" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type spaceItem<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.SpaceItem>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<AntDesign.SpaceItem>
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type spin<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.Spin>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<AntDesign.Spin>
    static member inline size (x: System.String) = "Size" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline tip (x: System.String) = "Tip" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline delay (x: System.Int32) = "Delay" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline spinning (x: System.Boolean) = "Spinning" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline wrapperClassName (x: System.String) = "WrapperClassName" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline indicator (x: Microsoft.AspNetCore.Components.RenderFragment) = "Indicator" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type countDown<'FunBlazorGeneric> =
    inherit statisticComponentBase<'FunBlazorGeneric, System.DateTime>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.CountDown>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<AntDesign.CountDown>
    static member inline format (x: System.String) = "Format" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onFinish (x: Microsoft.AspNetCore.Components.EventCallback) = "OnFinish" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline prefix (x: System.String) = "Prefix" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline prefixTemplate (x: Microsoft.AspNetCore.Components.RenderFragment) = "PrefixTemplate" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline suffix (x: System.String) = "Suffix" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline suffixTemplate (x: Microsoft.AspNetCore.Components.RenderFragment) = "SuffixTemplate" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline title (x: System.String) = "Title" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline titleTemplate (x: Microsoft.AspNetCore.Components.RenderFragment) = "TitleTemplate" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline value (x: System.DateTime) = "Value" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valueStyle (x: System.String) = "ValueStyle" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type statistic<'FunBlazorGeneric, 'TValue> =
    inherit statisticComponentBase<'FunBlazorGeneric, 'TValue>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.Statistic<'TValue>>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<AntDesign.Statistic<'TValue>>
    static member inline decimalSeparator (x: System.String) = "DecimalSeparator" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline groupSeparator (x: System.String) = "GroupSeparator" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline precision (x: System.Int32) = "Precision" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline prefix (x: System.String) = "Prefix" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline prefixTemplate (x: Microsoft.AspNetCore.Components.RenderFragment) = "PrefixTemplate" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline suffix (x: System.String) = "Suffix" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline suffixTemplate (x: Microsoft.AspNetCore.Components.RenderFragment) = "SuffixTemplate" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline title (x: System.String) = "Title" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline titleTemplate (x: Microsoft.AspNetCore.Components.RenderFragment) = "TitleTemplate" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline value (x: 'TValue) = "Value" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valueStyle (x: System.String) = "ValueStyle" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type statisticComponentBase<'FunBlazorGeneric, 'T> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.StatisticComponentBase<'T>>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<AntDesign.StatisticComponentBase<'T>>
    static member inline prefix (x: System.String) = "Prefix" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline prefixTemplate (x: Microsoft.AspNetCore.Components.RenderFragment) = "PrefixTemplate" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline suffix (x: System.String) = "Suffix" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline suffixTemplate (x: Microsoft.AspNetCore.Components.RenderFragment) = "SuffixTemplate" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline title (x: System.String) = "Title" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline titleTemplate (x: Microsoft.AspNetCore.Components.RenderFragment) = "TitleTemplate" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline value (x: 'T) = "Value" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valueStyle (x: System.String) = "ValueStyle" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type step<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.Step>
    
    static member inline icon (x: System.String) = "Icon" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline status (x: System.String) = "Status" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline title (x: System.String) = "Title" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline titleTemplate (x: Microsoft.AspNetCore.Components.RenderFragment) = "TitleTemplate" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline subtitle (x: System.String) = "Subtitle" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline subtitleTemplate (x: Microsoft.AspNetCore.Components.RenderFragment) = "SubtitleTemplate" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline description (x: System.String) = "Description" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline descriptionTemplate (x: Microsoft.AspNetCore.Components.RenderFragment) = "DescriptionTemplate" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onClick fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnClick" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabled (x: System.Boolean) = "Disabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type steps<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.Steps>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<AntDesign.Steps>
    static member inline current (x: System.Int32) = "Current" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline percent (x: System.Nullable<System.Double>) = "Percent" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline progressDot (x: Microsoft.AspNetCore.Components.RenderFragment) = "ProgressDot" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline showProgressDot (x: System.Boolean) = "ShowProgressDot" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline direction (x: System.String) = "Direction" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline labelPlacement (x: System.String) = "LabelPlacement" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline type' (x: System.String) = "Type" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline size (x: System.String) = "Size" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline startIndex (x: System.Int32) = "StartIndex" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline status (x: System.String) = "Status" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onChange fn = (Bolero.Html.attr.callback<System.Int32> "OnChange" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type switch<'FunBlazorGeneric> =
    inherit antInputBoolComponentBase<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.Switch>
    
    static member inline loading (x: System.Boolean) = "Loading" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline checkedChildren (x: System.String) = "CheckedChildren" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline checkedChildrenTemplate (x: Microsoft.AspNetCore.Components.RenderFragment) = "CheckedChildrenTemplate" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline control (x: System.Boolean) = "Control" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onClick (x: Microsoft.AspNetCore.Components.EventCallback) = "OnClick" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline unCheckedChildren (x: System.String) = "UnCheckedChildren" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline unCheckedChildrenTemplate (x: Microsoft.AspNetCore.Components.RenderFragment) = "UnCheckedChildrenTemplate" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline autoFocus (x: System.Boolean) = "AutoFocus" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline checked' (x: System.Boolean) = "Checked" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onChange fn = (Bolero.Html.attr.callback<System.Boolean> "OnChange" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline checkedChanged fn = (Bolero.Html.attr.callback<System.Boolean> "CheckedChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabled (x: System.Boolean) = "Disabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline additionalAttributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "AdditionalAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline value (x: System.Boolean) = "Value" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valueChanged fn = (Bolero.Html.attr.callback<System.Boolean> "ValueChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valueExpression (x: System.Linq.Expressions.Expression<System.Func<System.Boolean>>) = "ValueExpression" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valuesExpression (x: System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.IEnumerable<System.Boolean>>>) = "ValuesExpression" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline size (x: System.String) = "Size" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline cultureInfo (x: System.Globalization.CultureInfo) = "CultureInfo" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type actionColumn<'FunBlazorGeneric> =
    inherit columnBase<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.ActionColumn>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<AntDesign.ActionColumn>
    static member inline title (x: System.String) = "Title" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline titleTemplate (x: Microsoft.AspNetCore.Components.RenderFragment) = "TitleTemplate" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline width (x: System.String) = "Width" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline headerStyle (x: System.String) = "HeaderStyle" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline rowSpan (x: System.Int32) = "RowSpan" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline colSpan (x: System.Int32) = "ColSpan" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline headerColSpan (x: System.Int32) = "HeaderColSpan" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline fixed' (x: System.String) = "Fixed" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline ellipsis (x: System.Boolean) = "Ellipsis" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type column<'FunBlazorGeneric, 'TData> =
    inherit columnBase<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.Column<'TData>>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<AntDesign.Column<'TData>>
    static member inline fieldChanged fn = (Bolero.Html.attr.callback<'TData> "FieldChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline fieldExpression (x: System.Linq.Expressions.Expression<System.Func<'TData>>) = "FieldExpression" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline cellRender (x: Microsoft.AspNetCore.Components.RenderFragment<'TData>) = "CellRender" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline field (x: 'TData) = "Field" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline dataIndex (x: System.String) = "DataIndex" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline format (x: System.String) = "Format" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline sortable (x: System.Boolean) = "Sortable" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline sorterCompare (x: System.Func<'TData, 'TData, System.Int32>) = "SorterCompare" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline sorterMultiple (x: System.Int32) = "SorterMultiple" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline showSorterTooltip (x: System.Boolean) = "ShowSorterTooltip" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline sortDirections (x: System.Collections.Generic.IEnumerable<AntDesign.SortDirection>) = "SortDirections" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline defaultSortOrder (x: AntDesign.SortDirection) = "DefaultSortOrder" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onCell (x: System.Func<AntDesign.TableModels.RowData, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>>) = "OnCell" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onHeaderCell (x: System.Func<System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>>) = "OnHeaderCell" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline filterable (x: System.Boolean) = "Filterable" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline filters (x: System.Collections.Generic.IEnumerable<AntDesign.TableFilter<'TData>>) = "Filters" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline filterMultiple (x: System.Boolean) = "FilterMultiple" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onFilter (x: System.Linq.Expressions.Expression<System.Func<'TData, 'TData, System.Boolean>>) = "OnFilter" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline title (x: System.String) = "Title" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline titleTemplate (x: Microsoft.AspNetCore.Components.RenderFragment) = "TitleTemplate" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline width (x: System.String) = "Width" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline headerStyle (x: System.String) = "HeaderStyle" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline rowSpan (x: System.Int32) = "RowSpan" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline colSpan (x: System.Int32) = "ColSpan" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline headerColSpan (x: System.Int32) = "HeaderColSpan" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline fixed' (x: System.String) = "Fixed" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline ellipsis (x: System.Boolean) = "Ellipsis" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type columnBase<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.ColumnBase>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<AntDesign.ColumnBase>
    static member inline title (x: System.String) = "Title" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline titleTemplate (x: Microsoft.AspNetCore.Components.RenderFragment) = "TitleTemplate" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline width (x: System.String) = "Width" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline headerStyle (x: System.String) = "HeaderStyle" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline rowSpan (x: System.Int32) = "RowSpan" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline colSpan (x: System.Int32) = "ColSpan" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline headerColSpan (x: System.Int32) = "HeaderColSpan" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline fixed' (x: System.String) = "Fixed" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline ellipsis (x: System.Boolean) = "Ellipsis" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type selection<'FunBlazorGeneric> =
    inherit columnBase<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.Selection>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<AntDesign.Selection>
    static member inline type' (x: System.String) = "Type" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabled (x: System.Boolean) = "Disabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline key (x: System.String) = "Key" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline checkStrictly (x: System.Boolean) = "CheckStrictly" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline title (x: System.String) = "Title" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline titleTemplate (x: Microsoft.AspNetCore.Components.RenderFragment) = "TitleTemplate" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline width (x: System.String) = "Width" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline headerStyle (x: System.String) = "HeaderStyle" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline rowSpan (x: System.Int32) = "RowSpan" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline colSpan (x: System.Int32) = "ColSpan" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline headerColSpan (x: System.Int32) = "HeaderColSpan" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline fixed' (x: System.String) = "Fixed" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline ellipsis (x: System.Boolean) = "Ellipsis" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type table<'FunBlazorGeneric, 'TItem> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.Table<'TItem>>
    
    static member inline renderMode (x: AntDesign.RenderMode) = "RenderMode" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline dataSource (x: System.Collections.Generic.IEnumerable<'TItem>) = "DataSource" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (x: Microsoft.AspNetCore.Components.RenderFragment<'TItem>) = "ChildContent" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline rowTemplate (x: Microsoft.AspNetCore.Components.RenderFragment<'TItem>) = "RowTemplate" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline expandTemplate (x: Microsoft.AspNetCore.Components.RenderFragment<AntDesign.TableModels.RowData<'TItem>>) = "ExpandTemplate" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline rowExpandable (x: System.Func<AntDesign.TableModels.RowData<'TItem>, System.Boolean>) = "RowExpandable" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline treeChildren (x: System.Func<'TItem, System.Collections.Generic.IEnumerable<'TItem>>) = "TreeChildren" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onChange fn = (Bolero.Html.attr.callback<AntDesign.TableModels.QueryModel<'TItem>> "OnChange" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onRow (x: System.Func<AntDesign.TableModels.RowData<'TItem>, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>>) = "OnRow" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onHeaderRow (x: System.Func<System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>>) = "OnHeaderRow" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline loading (x: System.Boolean) = "Loading" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline title (x: System.String) = "Title" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline titleTemplate (x: Microsoft.AspNetCore.Components.RenderFragment) = "TitleTemplate" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline footer (x: System.String) = "Footer" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline footerTemplate (x: Microsoft.AspNetCore.Components.RenderFragment) = "FooterTemplate" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline size (x: AntDesign.TableSize) = "Size" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline locale (x: AntDesign.TableLocale) = "Locale" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline bordered (x: System.Boolean) = "Bordered" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline scrollX (x: System.String) = "ScrollX" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline scrollY (x: System.String) = "ScrollY" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline scrollBarWidth (x: System.Int32) = "ScrollBarWidth" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline indentSize (x: System.Int32) = "IndentSize" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline expandIconColumnIndex (x: System.Int32) = "ExpandIconColumnIndex" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline rowClassName (x: System.Func<AntDesign.TableModels.RowData<'TItem>, System.String>) = "RowClassName" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline expandedRowClassName (x: System.Func<AntDesign.TableModels.RowData<'TItem>, System.String>) = "ExpandedRowClassName" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onExpand fn = (Bolero.Html.attr.callback<AntDesign.TableModels.RowData<'TItem>> "OnExpand" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline sortDirections (x: System.Collections.Generic.IEnumerable<AntDesign.SortDirection>) = "SortDirections" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline tableLayout (x: System.String) = "TableLayout" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onRowClick fn = (Bolero.Html.attr.callback<AntDesign.TableModels.RowData<'TItem>> "OnRowClick" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline hidePagination (x: System.Boolean) = "HidePagination" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline paginationPosition (x: System.String) = "PaginationPosition" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline total (x: System.Int32) = "Total" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline totalChanged fn = (Bolero.Html.attr.callback<System.Int32> "TotalChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline pageIndex (x: System.Int32) = "PageIndex" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline pageIndexChanged fn = (Bolero.Html.attr.callback<System.Int32> "PageIndexChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline pageSize (x: System.Int32) = "PageSize" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline pageSizeChanged fn = (Bolero.Html.attr.callback<System.Int32> "PageSizeChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onPageIndexChange fn = (Bolero.Html.attr.callback<AntDesign.PaginationEventArgs> "OnPageIndexChange" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onPageSizeChange fn = (Bolero.Html.attr.callback<AntDesign.PaginationEventArgs> "OnPageSizeChange" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline selectedRows (x: System.Collections.Generic.IEnumerable<'TItem>) = "SelectedRows" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline selectedRowsChanged fn = (Bolero.Html.attr.callback<System.Collections.Generic.IEnumerable<'TItem>> "SelectedRowsChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type tabPane<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.TabPane>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<AntDesign.TabPane>
    static member inline forceRender (x: System.Boolean) = "ForceRender" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline key (x: System.String) = "Key" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline tab (x: Microsoft.AspNetCore.Components.RenderFragment) = "Tab" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabled (x: System.Boolean) = "Disabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline closable (x: System.Boolean) = "Closable" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type tabs<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.Tabs>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<AntDesign.Tabs>
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline activeKey (x: System.String) = "ActiveKey" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline activeKeyChanged fn = (Bolero.Html.attr.callback<System.String> "ActiveKeyChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline animated (x: System.Boolean) = "Animated" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline renderTabBar (x: System.Object) = "RenderTabBar" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline defaultActiveKey (x: System.String) = "DefaultActiveKey" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline hideAdd (x: System.Boolean) = "HideAdd" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline size (x: System.String) = "Size" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline tabBarExtraContent (x: Microsoft.AspNetCore.Components.RenderFragment) = "TabBarExtraContent" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline tabBarGutter (x: System.Int32) = "TabBarGutter" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline tabBarStyle (x: System.String) = "TabBarStyle" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline tabPosition (x: System.String) = "TabPosition" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline type' (x: System.String) = "Type" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onChange fn = (Bolero.Html.attr.callback<System.String> "OnChange" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onEdit (x: System.Func<System.String, System.String, System.Threading.Tasks.Task<System.Boolean>>) = "OnEdit" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onAddClick (x: Microsoft.AspNetCore.Components.EventCallback) = "OnAddClick" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline afterTabCreated fn = (Bolero.Html.attr.callback<System.String> "AfterTabCreated" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onNextClick (x: Microsoft.AspNetCore.Components.EventCallback) = "OnNextClick" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onPrevClick (x: Microsoft.AspNetCore.Components.EventCallback) = "OnPrevClick" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onTabClick fn = (Bolero.Html.attr.callback<System.String> "OnTabClick" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline keyboard (x: System.Boolean) = "Keyboard" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline draggable (x: System.Boolean) = "Draggable" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type tag<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.Tag>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<AntDesign.Tag>
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline closable (x: System.Boolean) = "Closable" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline checkable (x: System.Boolean) = "Checkable" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline checked' (x: System.Boolean) = "Checked" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline checkedChange fn = (Bolero.Html.attr.callback<System.Boolean> "CheckedChange" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline color (x: System.String) = "Color" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline icon (x: System.String) = "Icon" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onClose fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnClose" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onClosing fn = (Bolero.Html.attr.callback<AntDesign.CloseEventArgs<Microsoft.AspNetCore.Components.Web.MouseEventArgs>> "OnClosing" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onClick (x: Microsoft.AspNetCore.Components.EventCallback) = "OnClick" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline visible (x: System.Boolean) = "Visible" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type timePicker<'FunBlazorGeneric, 'TValue> =
    inherit datePicker<'FunBlazorGeneric, 'TValue>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.TimePicker<'TValue>>
    
    static member inline onChange fn = (Bolero.Html.attr.callback<AntDesign.DateTimeChangedEventArgs> "OnChange" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline prefixCls (x: System.String) = "PrefixCls" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline picker (x: System.String) = "Picker" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline popupContainerSelector (x: System.String) = "PopupContainerSelector" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabled (x: System.Boolean) = "Disabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline bordered (x: System.Boolean) = "Bordered" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline autoFocus (x: System.Boolean) = "AutoFocus" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline open' (x: System.Boolean) = "Open" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline inputReadOnly (x: System.Boolean) = "InputReadOnly" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline showToday (x: System.Boolean) = "ShowToday" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline locale (x: AntDesign.DatePickerLocale) = "Locale" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline cultureInfo (x: System.Globalization.CultureInfo) = "CultureInfo" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline showTime (x: OneOf.OneOf<System.Boolean, System.String>) = "ShowTime" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline allowClear (x: System.Boolean) = "AllowClear" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline placeholder (x: OneOf.OneOf<System.String, System.Collections.Generic.IEnumerable<System.String>>) = "Placeholder" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline popupStyle (x: System.String) = "PopupStyle" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline className (x: System.String) = "ClassName" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline dropdownClassName (x: System.String) = "DropdownClassName" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline format (x: System.String) = "Format" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline defaultValue (x: 'TValue) = "DefaultValue" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline defaultPickerValue (x: 'TValue) = "DefaultPickerValue" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline suffixIcon (x: Microsoft.AspNetCore.Components.RenderFragment) = "SuffixIcon" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline renderExtraFooter (x: Microsoft.AspNetCore.Components.RenderFragment) = "RenderExtraFooter" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onClearClick (x: Microsoft.AspNetCore.Components.EventCallback) = "OnClearClick" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onOpenChange fn = (Bolero.Html.attr.callback<System.Boolean> "OnOpenChange" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onPanelChange fn = (Bolero.Html.attr.callback<AntDesign.DateTimeChangedEventArgs> "OnPanelChange" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabledDate (x: System.Func<System.DateTime, System.Boolean>) = "DisabledDate" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabledHours (x: System.Func<System.DateTime, System.Collections.Generic.IEnumerable<System.Int32>>) = "DisabledHours" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabledMinutes (x: System.Func<System.DateTime, System.Collections.Generic.IEnumerable<System.Int32>>) = "DisabledMinutes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabledSeconds (x: System.Func<System.DateTime, System.Collections.Generic.IEnumerable<System.Int32>>) = "DisabledSeconds" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabledTime (x: System.Func<System.DateTime, AntDesign.DatePickerDisabledTime>) = "DisabledTime" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline dateRender (x: System.Func<System.DateTime, System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "DateRender" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline monthCellRender (x: System.Func<System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "MonthCellRender" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline additionalAttributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "AdditionalAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline value (x: 'TValue) = "Value" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valueChanged fn = (Bolero.Html.attr.callback<'TValue> "ValueChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valueExpression (x: System.Linq.Expressions.Expression<System.Func<'TValue>>) = "ValueExpression" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valuesExpression (x: System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.IEnumerable<'TValue>>>) = "ValuesExpression" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline size (x: System.String) = "Size" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type timeline<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.Timeline>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<AntDesign.Timeline>
    static member inline mode (x: System.String) = "Mode" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline reverse (x: System.Boolean) = "Reverse" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline pending (x: OneOf.OneOf<System.String, Microsoft.AspNetCore.Components.RenderFragment>) = "Pending" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline pendingDot (x: Microsoft.AspNetCore.Components.RenderFragment) = "PendingDot" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type timelineItem<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.TimelineItem>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<AntDesign.TimelineItem>
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline dot (x: Microsoft.AspNetCore.Components.RenderFragment) = "Dot" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline color (x: System.String) = "Color" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type tooltip<'FunBlazorGeneric> =
    inherit overlayTrigger<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.Tooltip>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<AntDesign.Tooltip>
    static member inline title (x: OneOf.OneOf<System.String, Microsoft.AspNetCore.Components.RenderFragment, Microsoft.AspNetCore.Components.MarkupString>) = "Title" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline arrowPointAtCenter (x: System.Boolean) = "ArrowPointAtCenter" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline mouseEnterDelay (x: System.Double) = "MouseEnterDelay" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline mouseLeaveDelay (x: System.Double) = "MouseLeaveDelay" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline boundaryAdjustMode (x: AntDesign.TriggerBoundaryAdjustMode) = "BoundaryAdjustMode" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline complexAutoCloseAndVisible (x: System.Boolean) = "ComplexAutoCloseAndVisible" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabled (x: System.Boolean) = "Disabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline hiddenMode (x: System.Boolean) = "HiddenMode" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline inlineFlexMode (x: System.Boolean) = "InlineFlexMode" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline isButton (x: System.Boolean) = "IsButton" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onClick fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnClick" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onMaskClick (x: Microsoft.AspNetCore.Components.EventCallback) = "OnMaskClick" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onMouseEnter (x: System.Action) = "OnMouseEnter" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onMouseLeave (x: System.Action) = "OnMouseLeave" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onOverlayHiding fn = (Bolero.Html.attr.callback<System.Boolean> "OnOverlayHiding" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onVisibleChange fn = (Bolero.Html.attr.callback<System.Boolean> "OnVisibleChange" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline overlay (x: Microsoft.AspNetCore.Components.RenderFragment) = "Overlay" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline overlayClassName (x: System.String) = "OverlayClassName" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline overlayEnterCls (x: System.String) = "OverlayEnterCls" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline overlayHiddenCls (x: System.String) = "OverlayHiddenCls" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline overlayLeaveCls (x: System.String) = "OverlayLeaveCls" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline overlayStyle (x: System.String) = "OverlayStyle" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline placement (x: AntDesign.PlacementType) = "Placement" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline placementCls (x: System.String) = "PlacementCls" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline popupContainerSelector (x: System.String) = "PopupContainerSelector" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline trigger (x: System.Collections.Generic.IEnumerable<AntDesign.TriggerType>) = "Trigger" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline triggerReference (x: Microsoft.AspNetCore.Components.ElementReference) = "TriggerReference" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline unbound (x: Microsoft.AspNetCore.Components.RenderFragment<AntDesign.ForwardRef>) = "Unbound" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline visible (x: System.Boolean) = "Visible" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type transfer<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.Transfer>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<AntDesign.Transfer>
    static member inline dataSource (x: System.Collections.Generic.IEnumerable<AntDesign.TransferItem>) = "DataSource" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline titles (x: System.Collections.Generic.IEnumerable<System.String>) = "Titles" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline operations (x: System.Collections.Generic.IEnumerable<System.String>) = "Operations" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabled (x: System.Boolean) = "Disabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline showSearch (x: System.Boolean) = "ShowSearch" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline showSelectAll (x: System.Boolean) = "ShowSelectAll" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline targetKeys (x: System.Collections.Generic.IEnumerable<System.String>) = "TargetKeys" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline selectedKeys (x: System.Collections.Generic.IEnumerable<System.String>) = "SelectedKeys" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onChange fn = (Bolero.Html.attr.callback<AntDesign.TransferChangeArgs> "OnChange" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onScroll fn = (Bolero.Html.attr.callback<AntDesign.TransferScrollArgs> "OnScroll" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onSearch fn = (Bolero.Html.attr.callback<AntDesign.TransferSearchArgs> "OnSearch" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onSelectChange fn = (Bolero.Html.attr.callback<AntDesign.TransferSelectChangeArgs> "OnSelectChange" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline render (x: System.Func<AntDesign.TransferItem, OneOf.OneOf<System.String, Microsoft.AspNetCore.Components.RenderFragment>>) = "Render" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline locale (x: AntDesign.TransferLocale) = "Locale" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline footer (x: System.String) = "Footer" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline footerTemplate (x: Microsoft.AspNetCore.Components.RenderFragment) = "FooterTemplate" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type tree<'FunBlazorGeneric, 'TItem> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.Tree<'TItem>>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<AntDesign.Tree<'TItem>>
    static member inline showExpand (x: System.Boolean) = "ShowExpand" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline showLine (x: System.Boolean) = "ShowLine" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline showIcon (x: System.Boolean) = "ShowIcon" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline blockNode (x: System.Boolean) = "BlockNode" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline draggable (x: System.Boolean) = "Draggable" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline nodes (x: Microsoft.AspNetCore.Components.RenderFragment) = "Nodes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childNodes (x: System.Collections.Generic.IEnumerable<AntDesign.TreeNode<'TItem>>) = "ChildNodes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline multiple (x: System.Boolean) = "Multiple" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline selectedKey (x: System.String) = "SelectedKey" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline selectedKeyChanged fn = (Bolero.Html.attr.callback<System.String> "SelectedKeyChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline selectedNode (x: AntDesign.TreeNode<'TItem>) = "SelectedNode" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline selectedNodeChanged fn = (Bolero.Html.attr.callback<AntDesign.TreeNode<'TItem>> "SelectedNodeChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline selectedData (x: 'TItem) = "SelectedData" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline selectedDataChanged fn = (Bolero.Html.attr.callback<'TItem> "SelectedDataChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline selectedKeys (x: System.Collections.Generic.IEnumerable<System.String>) = "SelectedKeys" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline selectedKeysChanged fn = (Bolero.Html.attr.callback<System.Collections.Generic.IEnumerable<System.String>> "SelectedKeysChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline selectedNodes (x: System.Collections.Generic.IEnumerable<AntDesign.TreeNode<'TItem>>) = "SelectedNodes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline selectedDatas (x: System.Collections.Generic.IEnumerable<'TItem>) = "SelectedDatas" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline checkable (x: System.Boolean) = "Checkable" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline searchValue (x: System.String) = "SearchValue" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline searchExpression (x: System.Func<AntDesign.TreeNode<'TItem>, System.Boolean>) = "SearchExpression" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline dataSource (x: System.Collections.Generic.IEnumerable<'TItem>) = "DataSource" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline titleExpression (x: System.Func<AntDesign.TreeNode<'TItem>, System.String>) = "TitleExpression" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline keyExpression (x: System.Func<AntDesign.TreeNode<'TItem>, System.String>) = "KeyExpression" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline iconExpression (x: System.Func<AntDesign.TreeNode<'TItem>, System.String>) = "IconExpression" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline isLeafExpression (x: System.Func<AntDesign.TreeNode<'TItem>, System.Boolean>) = "IsLeafExpression" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childrenExpression (x: System.Func<AntDesign.TreeNode<'TItem>, System.Collections.Generic.IEnumerable<'TItem>>) = "ChildrenExpression" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onNodeLoadDelayAsync fn = (Bolero.Html.attr.callback<AntDesign.TreeEventArgs<'TItem>> "OnNodeLoadDelayAsync" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onClick fn = (Bolero.Html.attr.callback<AntDesign.TreeEventArgs<'TItem>> "OnClick" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onDblClick fn = (Bolero.Html.attr.callback<AntDesign.TreeEventArgs<'TItem>> "OnDblClick" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onContextMenu fn = (Bolero.Html.attr.callback<AntDesign.TreeEventArgs<'TItem>> "OnContextMenu" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onCheckBoxChanged fn = (Bolero.Html.attr.callback<AntDesign.TreeEventArgs<'TItem>> "OnCheckBoxChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onExpandChanged fn = (Bolero.Html.attr.callback<AntDesign.TreeEventArgs<'TItem>> "OnExpandChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onSearchValueChanged fn = (Bolero.Html.attr.callback<AntDesign.TreeEventArgs<'TItem>> "OnSearchValueChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline indentTemplate (x: Microsoft.AspNetCore.Components.RenderFragment<AntDesign.TreeNode<'TItem>>) = "IndentTemplate" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline titleTemplate (x: Microsoft.AspNetCore.Components.RenderFragment<AntDesign.TreeNode<'TItem>>) = "TitleTemplate" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline titleIconTemplate (x: Microsoft.AspNetCore.Components.RenderFragment<AntDesign.TreeNode<'TItem>>) = "TitleIconTemplate" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline switcherIconTemplate (x: Microsoft.AspNetCore.Components.RenderFragment<AntDesign.TreeNode<'TItem>>) = "SwitcherIconTemplate" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type treeIndent<'FunBlazorGeneric, 'TItem> =
    
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.TreeIndent<'TItem>>
    
    static member inline treeLevel (x: System.Int32) = "TreeLevel" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type treeNode<'FunBlazorGeneric, 'TItem> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.TreeNode<'TItem>>
    
    static member inline nodes (x: Microsoft.AspNetCore.Components.RenderFragment) = "Nodes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline key (x: System.String) = "Key" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabled (x: System.Boolean) = "Disabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline selected (x: System.Boolean) = "Selected" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline loading (x: System.Boolean) = "Loading" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline isLeaf (x: System.Boolean) = "IsLeaf" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline expanded (x: System.Boolean) = "Expanded" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline checked' (x: System.Boolean) = "Checked" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline indeterminate (x: System.Boolean) = "Indeterminate" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disableCheckbox (x: System.Boolean) = "DisableCheckbox" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline draggable (x: System.Boolean) = "Draggable" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline icon (x: System.String) = "Icon" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline title (x: System.String) = "Title" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline dataItem (x: 'TItem) = "DataItem" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type treeNodeCheckbox<'FunBlazorGeneric, 'TItem> =
    
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.TreeNodeCheckbox<'TItem>>
    
    static member inline onCheckBoxClick fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnCheckBoxClick" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type treeNodeSwitcher<'FunBlazorGeneric, 'TItem> =
    
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.TreeNodeSwitcher<'TItem>>
    
    static member inline onSwitcherClick fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnSwitcherClick" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type link<'FunBlazorGeneric> =
    inherit typographyBase<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.Link>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<AntDesign.Link>
    static member inline code (x: System.Boolean) = "Code" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline keyboard (x: System.Boolean) = "Keyboard" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline copyable (x: System.Boolean) = "Copyable" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline copyConfig (x: AntDesign.TypographyCopyableConfig) = "CopyConfig" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline delete (x: System.Boolean) = "Delete" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabled (x: System.Boolean) = "Disabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline editable (x: System.Boolean) = "Editable" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline editConfig (x: AntDesign.TypographyEditableConfig) = "EditConfig" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline ellipsis (x: System.Boolean) = "Ellipsis" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline ellipsisConfig (x: AntDesign.TypographyEllipsisConfig) = "EllipsisConfig" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline mark (x: System.Boolean) = "Mark" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline underline (x: System.Boolean) = "Underline" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline strong (x: System.Boolean) = "Strong" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onChange (x: System.Action) = "OnChange" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline type' (x: System.String) = "Type" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type paragraph<'FunBlazorGeneric> =
    inherit typographyBase<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.Paragraph>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<AntDesign.Paragraph>
    static member inline code (x: System.Boolean) = "Code" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline keyboard (x: System.Boolean) = "Keyboard" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline copyable (x: System.Boolean) = "Copyable" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline copyConfig (x: AntDesign.TypographyCopyableConfig) = "CopyConfig" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline delete (x: System.Boolean) = "Delete" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabled (x: System.Boolean) = "Disabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline editable (x: System.Boolean) = "Editable" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline editConfig (x: AntDesign.TypographyEditableConfig) = "EditConfig" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline ellipsis (x: System.Boolean) = "Ellipsis" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline ellipsisConfig (x: AntDesign.TypographyEllipsisConfig) = "EllipsisConfig" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline mark (x: System.Boolean) = "Mark" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline underline (x: System.Boolean) = "Underline" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline strong (x: System.Boolean) = "Strong" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onChange (x: System.Action) = "OnChange" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline type' (x: System.String) = "Type" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type text<'FunBlazorGeneric> =
    inherit typographyBase<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.Text>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<AntDesign.Text>
    static member inline code (x: System.Boolean) = "Code" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline keyboard (x: System.Boolean) = "Keyboard" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline copyable (x: System.Boolean) = "Copyable" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline copyConfig (x: AntDesign.TypographyCopyableConfig) = "CopyConfig" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline delete (x: System.Boolean) = "Delete" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabled (x: System.Boolean) = "Disabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline editable (x: System.Boolean) = "Editable" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline editConfig (x: AntDesign.TypographyEditableConfig) = "EditConfig" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline ellipsis (x: System.Boolean) = "Ellipsis" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline ellipsisConfig (x: AntDesign.TypographyEllipsisConfig) = "EllipsisConfig" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline mark (x: System.Boolean) = "Mark" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline underline (x: System.Boolean) = "Underline" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline strong (x: System.Boolean) = "Strong" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onChange (x: System.Action) = "OnChange" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline type' (x: System.String) = "Type" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type title<'FunBlazorGeneric> =
    inherit typographyBase<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.Title>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<AntDesign.Title>
    static member inline level (x: System.Int32) = "Level" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline copyable (x: System.Boolean) = "Copyable" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline copyConfig (x: AntDesign.TypographyCopyableConfig) = "CopyConfig" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline delete (x: System.Boolean) = "Delete" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabled (x: System.Boolean) = "Disabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline editable (x: System.Boolean) = "Editable" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline editConfig (x: AntDesign.TypographyEditableConfig) = "EditConfig" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline ellipsis (x: System.Boolean) = "Ellipsis" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline ellipsisConfig (x: AntDesign.TypographyEllipsisConfig) = "EllipsisConfig" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline mark (x: System.Boolean) = "Mark" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline underline (x: System.Boolean) = "Underline" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline strong (x: System.Boolean) = "Strong" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onChange (x: System.Action) = "OnChange" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline type' (x: System.String) = "Type" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type typographyBase<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.TypographyBase>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<AntDesign.TypographyBase>
    static member inline copyable (x: System.Boolean) = "Copyable" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline copyConfig (x: AntDesign.TypographyCopyableConfig) = "CopyConfig" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline delete (x: System.Boolean) = "Delete" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabled (x: System.Boolean) = "Disabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline editable (x: System.Boolean) = "Editable" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline editConfig (x: AntDesign.TypographyEditableConfig) = "EditConfig" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline ellipsis (x: System.Boolean) = "Ellipsis" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline ellipsisConfig (x: AntDesign.TypographyEllipsisConfig) = "EllipsisConfig" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline mark (x: System.Boolean) = "Mark" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline underline (x: System.Boolean) = "Underline" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline strong (x: System.Boolean) = "Strong" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onChange (x: System.Action) = "OnChange" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline type' (x: System.String) = "Type" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type upload<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.Upload>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<AntDesign.Upload>
    static member inline beforeUpload (x: System.Func<AntDesign.UploadFileItem, System.Boolean>) = "BeforeUpload" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline beforeAllUploadAsync (x: System.Func<System.Collections.Generic.IEnumerable<AntDesign.UploadFileItem>, System.Threading.Tasks.Task<System.Boolean>>) = "BeforeAllUploadAsync" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline beforeAllUpload (x: System.Func<System.Collections.Generic.IEnumerable<AntDesign.UploadFileItem>, System.Boolean>) = "BeforeAllUpload" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline name (x: System.String) = "Name" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline action (x: System.String) = "Action" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabled (x: System.Boolean) = "Disabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline data (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "Data" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline listType (x: System.String) = "ListType" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline directory (x: System.Boolean) = "Directory" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline multiple (x: System.Boolean) = "Multiple" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline accept (x: System.String) = "Accept" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline showUploadList (x: System.Boolean) = "ShowUploadList" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline fileList (x: System.Collections.Generic.IEnumerable<AntDesign.UploadFileItem>) = "FileList" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline locale (x: AntDesign.UploadLocale) = "Locale" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline fileListChanged fn = (Bolero.Html.attr.callback<System.Collections.Generic.IEnumerable<AntDesign.UploadFileItem>> "FileListChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline defaultFileList (x: System.Collections.Generic.IEnumerable<AntDesign.UploadFileItem>) = "DefaultFileList" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline headers (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.String>>) = "Headers" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onSingleCompleted fn = (Bolero.Html.attr.callback<AntDesign.UploadInfo> "OnSingleCompleted" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onCompleted fn = (Bolero.Html.attr.callback<AntDesign.UploadInfo> "OnCompleted" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onChange fn = (Bolero.Html.attr.callback<AntDesign.UploadInfo> "OnChange" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onRemove (x: System.Func<AntDesign.UploadFileItem, System.Threading.Tasks.Task<System.Boolean>>) = "OnRemove" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onPreview fn = (Bolero.Html.attr.callback<AntDesign.UploadFileItem> "OnPreview" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onDownload fn = (Bolero.Html.attr.callback<AntDesign.UploadFileItem> "OnDownload" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline showButton (x: System.Boolean) = "ShowButton" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type breadcrumbItem<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.BreadcrumbItem>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<AntDesign.BreadcrumbItem>
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline overlay (x: System.Object) = "Overlay" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type calendarHeader<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.CalendarHeader>
    
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type cardMeta<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.CardMeta>
    
    static member inline title (x: System.String) = "Title" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline titleTemplate (x: Microsoft.AspNetCore.Components.RenderFragment) = "TitleTemplate" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline description (x: System.String) = "Description" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline descriptionTemplate (x: Microsoft.AspNetCore.Components.RenderFragment) = "DescriptionTemplate" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline avatar (x: System.String) = "Avatar" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline avatarTemplate (x: Microsoft.AspNetCore.Components.RenderFragment) = "AvatarTemplate" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type antContainer<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.AntContainer>
    
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type template<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.Template>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<AntDesign.Template>
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline if' (x: System.Func<System.Boolean>) = "If" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type emptyDefaultImg<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.EmptyDefaultImg>
    
    static member inline prefixCls (x: System.String) = "PrefixCls" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type emptySimpleImg<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.EmptySimpleImg>
    
    static member inline prefixCls (x: System.String) = "PrefixCls" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type content<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.Content>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<AntDesign.Content>
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type footer<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.Footer>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<AntDesign.Footer>
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type header<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.Header>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<AntDesign.Header>
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type layout<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.Layout>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<AntDesign.Layout>
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type menuDivider<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.MenuDivider>
    
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type paginationPager<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.PaginationPager>
    
    static member inline showTitle (x: System.Boolean) = "ShowTitle" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline page (x: System.Int32) = "Page" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline rootPrefixCls (x: System.String) = "RootPrefixCls" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline active (x: System.Boolean) = "Active" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabled (x: System.Boolean) = "Disabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onClick fn = (Bolero.Html.attr.callback<System.Int32> "OnClick" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onKeyPress fn = (Bolero.Html.attr.callback<System.ValueTuple<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs, System.Action>> "OnKeyPress" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline itemRender (x: Microsoft.AspNetCore.Components.RenderFragment<AntDesign.PaginationItemRenderContext>) = "ItemRender" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline unmatchedAttributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "UnmatchedAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type summaryCell<'FunBlazorGeneric> =
    inherit columnBase<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.SummaryCell>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<AntDesign.SummaryCell>
    static member inline title (x: System.String) = "Title" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline titleTemplate (x: Microsoft.AspNetCore.Components.RenderFragment) = "TitleTemplate" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline width (x: System.String) = "Width" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline headerStyle (x: System.String) = "HeaderStyle" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline rowSpan (x: System.Int32) = "RowSpan" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline colSpan (x: System.Int32) = "ColSpan" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline headerColSpan (x: System.Int32) = "HeaderColSpan" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline fixed' (x: System.String) = "Fixed" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline ellipsis (x: System.Boolean) = "Ellipsis" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type summaryRow<'FunBlazorGeneric> =
    
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.SummaryRow>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<AntDesign.SummaryRow>
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type labelTemplateItem<'FunBlazorGeneric, 'TItemValue, 'TItem> =
    
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.Select.LabelTemplateItem<'TItemValue, 'TItem>>
    
    static member inline labelTemplateItemContent (x: Microsoft.AspNetCore.Components.RenderFragment<'TItem>) = "LabelTemplateItemContent" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline contentStyle (x: System.String) = "ContentStyle" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline contentClass (x: System.String) = "ContentClass" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline removeIconStyle (x: System.String) = "RemoveIconStyle" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline removeIconClass (x: System.String) = "RemoveIconClass" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type selectContent<'FunBlazorGeneric, 'TItemValue, 'TItem> =
    
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.Select.Internal.SelectContent<'TItemValue, 'TItem>>
    
    static member inline prefix (x: System.String) = "Prefix" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline placeholder (x: System.String) = "Placeholder" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline isOverlayShow (x: System.Boolean) = "IsOverlayShow" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline showPlaceholder (x: System.Boolean) = "ShowPlaceholder" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onInput fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.ChangeEventArgs> "OnInput" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onKeyUp fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs> "OnKeyUp" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onKeyDown fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs> "OnKeyDown" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onFocus fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.FocusEventArgs> "OnFocus" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onBlur fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.FocusEventArgs> "OnBlur" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onClearClick fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnClearClick" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onRemoveSelected fn = (Bolero.Html.attr.callback<AntDesign.Select.Internal.SelectOptionItem<'TItemValue, 'TItem>> "OnRemoveSelected" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline searchValue (x: System.String) = "SearchValue" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type selectOptionGroup<'FunBlazorGeneric, 'TItemValue, 'TItem> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.Select.Internal.SelectOptionGroup<'TItemValue, 'TItem>>
    
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type calendarPanelChooser<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.Internal.CalendarPanelChooser>
    
    static member inline calendar (x: AntDesign.Calendar) = "Calendar" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onSelect (x: System.Action<System.DateTime, System.Int32>) = "OnSelect" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline pickerIndex (x: System.Int32) = "PickerIndex" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type element<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.Internal.Element>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<AntDesign.Internal.Element>
    static member inline htmlTag (x: System.String) = "HtmlTag" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refChanged fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.ElementReference> "RefChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline attributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "Attributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type overlay<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.Internal.Overlay>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<AntDesign.Internal.Overlay>
    static member inline overlayChildPrefixCls (x: System.String) = "OverlayChildPrefixCls" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onOverlayMouseEnter (x: Microsoft.AspNetCore.Components.EventCallback) = "OnOverlayMouseEnter" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onOverlayMouseLeave (x: Microsoft.AspNetCore.Components.EventCallback) = "OnOverlayMouseLeave" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onShow (x: System.Action) = "OnShow" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onHide (x: System.Action) = "OnHide" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline hideMillisecondsDelay (x: System.Int32) = "HideMillisecondsDelay" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline waitForHideAnimMilliseconds (x: System.Int32) = "WaitForHideAnimMilliseconds" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline verticalOffset (x: System.Int32) = "VerticalOffset" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline horizontalOffset (x: System.Int32) = "HorizontalOffset" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline hiddenMode (x: System.Boolean) = "HiddenMode" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type overlayTrigger<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.Internal.OverlayTrigger>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<AntDesign.Internal.OverlayTrigger>
    static member inline boundaryAdjustMode (x: AntDesign.TriggerBoundaryAdjustMode) = "BoundaryAdjustMode" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline complexAutoCloseAndVisible (x: System.Boolean) = "ComplexAutoCloseAndVisible" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabled (x: System.Boolean) = "Disabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline hiddenMode (x: System.Boolean) = "HiddenMode" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline inlineFlexMode (x: System.Boolean) = "InlineFlexMode" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline isButton (x: System.Boolean) = "IsButton" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onClick fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnClick" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onMaskClick (x: Microsoft.AspNetCore.Components.EventCallback) = "OnMaskClick" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onMouseEnter (x: System.Action) = "OnMouseEnter" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onMouseLeave (x: System.Action) = "OnMouseLeave" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onOverlayHiding fn = (Bolero.Html.attr.callback<System.Boolean> "OnOverlayHiding" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onVisibleChange fn = (Bolero.Html.attr.callback<System.Boolean> "OnVisibleChange" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline overlay (x: Microsoft.AspNetCore.Components.RenderFragment) = "Overlay" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline overlayClassName (x: System.String) = "OverlayClassName" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline overlayEnterCls (x: System.String) = "OverlayEnterCls" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline overlayHiddenCls (x: System.String) = "OverlayHiddenCls" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline overlayLeaveCls (x: System.String) = "OverlayLeaveCls" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline overlayStyle (x: System.String) = "OverlayStyle" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline placement (x: AntDesign.PlacementType) = "Placement" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline placementCls (x: System.String) = "PlacementCls" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline popupContainerSelector (x: System.String) = "PopupContainerSelector" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline trigger (x: System.Collections.Generic.IEnumerable<AntDesign.TriggerType>) = "Trigger" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline triggerReference (x: Microsoft.AspNetCore.Components.ElementReference) = "TriggerReference" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline unbound (x: Microsoft.AspNetCore.Components.RenderFragment<AntDesign.ForwardRef>) = "Unbound" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline visible (x: System.Boolean) = "Visible" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type datePickerDatetimePanel<'FunBlazorGeneric, 'TValue> =
    inherit datePickerPanelBase<'FunBlazorGeneric, 'TValue>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.Internal.DatePickerDatetimePanel<'TValue>>
    
    static member inline showToday (x: System.Boolean) = "ShowToday" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline isShowTime (x: System.Boolean) = "IsShowTime" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline showTimeFormat (x: System.String) = "ShowTimeFormat" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline format (x: System.String) = "Format" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabledHours (x: System.Func<System.DateTime, System.Collections.Generic.IEnumerable<System.Int32>>) = "DisabledHours" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabledMinutes (x: System.Func<System.DateTime, System.Collections.Generic.IEnumerable<System.Int32>>) = "DisabledMinutes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabledSeconds (x: System.Func<System.DateTime, System.Collections.Generic.IEnumerable<System.Int32>>) = "DisabledSeconds" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabledTime (x: System.Func<System.DateTime, AntDesign.DatePickerDisabledTime>) = "DisabledTime" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline prefixCls (x: System.String) = "PrefixCls" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline picker (x: System.String) = "Picker" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline isRange (x: System.Boolean) = "IsRange" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline isCalendar (x: System.Boolean) = "IsCalendar" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline isShowHeader (x: System.Boolean) = "IsShowHeader" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline locale (x: AntDesign.DatePickerLocale) = "Locale" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline cultureInfo (x: System.Globalization.CultureInfo) = "CultureInfo" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline closePanel (x: System.Action) = "ClosePanel" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline changePickerValue (x: System.Action<System.DateTime, System.Nullable<System.Int32>>) = "ChangePickerValue" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline changeValue (x: System.Action<System.DateTime, System.Int32>) = "ChangeValue" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline changePickerType (x: System.Action<System.String, System.Int32>) = "ChangePickerType" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline getIndexPickerValue (x: System.Func<System.Int32, System.DateTime>) = "GetIndexPickerValue" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline getIndexValue (x: System.Func<System.Int32, System.Nullable<System.DateTime>>) = "GetIndexValue" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabledDate (x: System.Func<System.DateTime, System.Boolean>) = "DisabledDate" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline dateRender (x: System.Func<System.DateTime, System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "DateRender" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline monthCellRender (x: System.Func<System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "MonthCellRender" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline calendarDateRender (x: System.Func<System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "CalendarDateRender" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline calendarMonthCellRender (x: System.Func<System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "CalendarMonthCellRender" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline renderExtraFooter (x: Microsoft.AspNetCore.Components.RenderFragment) = "RenderExtraFooter" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onSelect (x: System.Action<System.DateTime, System.Int32>) = "OnSelect" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline pickerIndex (x: System.Int32) = "PickerIndex" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type datePickerPanelChooser<'FunBlazorGeneric, 'TValue> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.Internal.DatePickerPanelChooser<'TValue>>
    
    static member inline datePicker (x: AntDesign.DatePickerBase<'TValue>) = "DatePicker" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onSelect (x: System.Action<System.DateTime, System.Int32>) = "OnSelect" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline pickerIndex (x: System.Int32) = "PickerIndex" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type datePickerTemplate<'FunBlazorGeneric, 'TValue> =
    inherit datePickerPanelBase<'FunBlazorGeneric, 'TValue>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.Internal.DatePickerTemplate<'TValue>>
    
    static member inline renderPickerHeader (x: Microsoft.AspNetCore.Components.RenderFragment) = "RenderPickerHeader" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline renderTableHeader (x: Microsoft.AspNetCore.Components.RenderFragment) = "RenderTableHeader" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline renderFirstCol (x: Microsoft.AspNetCore.Components.RenderFragment<System.DateTime>) = "RenderFirstCol" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline renderColValue (x: Microsoft.AspNetCore.Components.RenderFragment<System.DateTime>) = "RenderColValue" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline renderLastCol (x: Microsoft.AspNetCore.Components.RenderFragment<System.DateTime>) = "RenderLastCol" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline viewStartDate (x: System.DateTime) = "ViewStartDate" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline getColTitle (x: System.Func<System.DateTime, System.String>) = "GetColTitle" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline getRowClass (x: System.Func<System.DateTime, System.String>) = "GetRowClass" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline getNextColValue (x: System.Func<System.DateTime, System.DateTime>) = "GetNextColValue" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline isInView (x: System.Func<System.DateTime, System.Boolean>) = "IsInView" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline isToday (x: System.Func<System.DateTime, System.Boolean>) = "IsToday" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline isSelected (x: System.Func<System.DateTime, System.Boolean>) = "IsSelected" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onRowSelect (x: System.Action<System.DateTime>) = "OnRowSelect" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onValueSelect (x: System.Action<System.DateTime>) = "OnValueSelect" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline showFooter (x: System.Boolean) = "ShowFooter" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline maxRow (x: System.Int32) = "MaxRow" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline maxCol (x: System.Int32) = "MaxCol" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline prefixCls (x: System.String) = "PrefixCls" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline picker (x: System.String) = "Picker" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline isRange (x: System.Boolean) = "IsRange" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline isCalendar (x: System.Boolean) = "IsCalendar" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline isShowHeader (x: System.Boolean) = "IsShowHeader" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline locale (x: AntDesign.DatePickerLocale) = "Locale" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline cultureInfo (x: System.Globalization.CultureInfo) = "CultureInfo" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline closePanel (x: System.Action) = "ClosePanel" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline changePickerValue (x: System.Action<System.DateTime, System.Nullable<System.Int32>>) = "ChangePickerValue" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline changeValue (x: System.Action<System.DateTime, System.Int32>) = "ChangeValue" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline changePickerType (x: System.Action<System.String, System.Int32>) = "ChangePickerType" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline getIndexPickerValue (x: System.Func<System.Int32, System.DateTime>) = "GetIndexPickerValue" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline getIndexValue (x: System.Func<System.Int32, System.Nullable<System.DateTime>>) = "GetIndexValue" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabledDate (x: System.Func<System.DateTime, System.Boolean>) = "DisabledDate" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline dateRender (x: System.Func<System.DateTime, System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "DateRender" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline monthCellRender (x: System.Func<System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "MonthCellRender" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline calendarDateRender (x: System.Func<System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "CalendarDateRender" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline calendarMonthCellRender (x: System.Func<System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "CalendarMonthCellRender" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline renderExtraFooter (x: Microsoft.AspNetCore.Components.RenderFragment) = "RenderExtraFooter" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onSelect (x: System.Action<System.DateTime, System.Int32>) = "OnSelect" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline pickerIndex (x: System.Int32) = "PickerIndex" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type pickerPanelBase<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.Internal.PickerPanelBase>
    
    static member inline onSelect (x: System.Action<System.DateTime, System.Int32>) = "OnSelect" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline pickerIndex (x: System.Int32) = "PickerIndex" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type subMenuTrigger<'FunBlazorGeneric> =
    inherit overlayTrigger<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.Internal.SubMenuTrigger>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<AntDesign.Internal.SubMenuTrigger>
    static member inline triggerClass (x: System.String) = "TriggerClass" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline boundaryAdjustMode (x: AntDesign.TriggerBoundaryAdjustMode) = "BoundaryAdjustMode" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline complexAutoCloseAndVisible (x: System.Boolean) = "ComplexAutoCloseAndVisible" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabled (x: System.Boolean) = "Disabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline hiddenMode (x: System.Boolean) = "HiddenMode" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline inlineFlexMode (x: System.Boolean) = "InlineFlexMode" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline isButton (x: System.Boolean) = "IsButton" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onClick fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnClick" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onMaskClick (x: Microsoft.AspNetCore.Components.EventCallback) = "OnMaskClick" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onMouseEnter (x: System.Action) = "OnMouseEnter" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onMouseLeave (x: System.Action) = "OnMouseLeave" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onOverlayHiding fn = (Bolero.Html.attr.callback<System.Boolean> "OnOverlayHiding" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onVisibleChange fn = (Bolero.Html.attr.callback<System.Boolean> "OnVisibleChange" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline overlay (x: Microsoft.AspNetCore.Components.RenderFragment) = "Overlay" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline overlayClassName (x: System.String) = "OverlayClassName" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline overlayEnterCls (x: System.String) = "OverlayEnterCls" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline overlayHiddenCls (x: System.String) = "OverlayHiddenCls" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline overlayLeaveCls (x: System.String) = "OverlayLeaveCls" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline overlayStyle (x: System.String) = "OverlayStyle" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline placement (x: AntDesign.PlacementType) = "Placement" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline placementCls (x: System.String) = "PlacementCls" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline popupContainerSelector (x: System.String) = "PopupContainerSelector" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline trigger (x: System.Collections.Generic.IEnumerable<AntDesign.TriggerType>) = "Trigger" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline triggerReference (x: Microsoft.AspNetCore.Components.ElementReference) = "TriggerReference" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline unbound (x: Microsoft.AspNetCore.Components.RenderFragment<AntDesign.ForwardRef>) = "Unbound" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline visible (x: System.Boolean) = "Visible" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type uploadButton<'FunBlazorGeneric> =
    inherit antComponentBase<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.Internal.UploadButton>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<AntDesign.Internal.UploadButton>
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline listType (x: System.String) = "ListType" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline showButton (x: System.Boolean) = "ShowButton" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline name (x: System.String) = "Name" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline directory (x: System.Boolean) = "Directory" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline multiple (x: System.Boolean) = "Multiple" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline accept (x: System.String) = "Accept" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline data (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "Data" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline headers (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.String>>) = "Headers" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline action (x: System.String) = "Action" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabled (x: System.Boolean) = "Disabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type datePickerDatePanel<'FunBlazorGeneric, 'TValue> =
    inherit datePickerPanelBase<'FunBlazorGeneric, 'TValue>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.Internal.DatePickerDatePanel<'TValue>>
    
    static member inline isWeek (x: System.Boolean) = "IsWeek" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline showToday (x: System.Boolean) = "ShowToday" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline prefixCls (x: System.String) = "PrefixCls" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline picker (x: System.String) = "Picker" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline isRange (x: System.Boolean) = "IsRange" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline isCalendar (x: System.Boolean) = "IsCalendar" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline isShowHeader (x: System.Boolean) = "IsShowHeader" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline locale (x: AntDesign.DatePickerLocale) = "Locale" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline cultureInfo (x: System.Globalization.CultureInfo) = "CultureInfo" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline closePanel (x: System.Action) = "ClosePanel" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline changePickerValue (x: System.Action<System.DateTime, System.Nullable<System.Int32>>) = "ChangePickerValue" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline changeValue (x: System.Action<System.DateTime, System.Int32>) = "ChangeValue" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline changePickerType (x: System.Action<System.String, System.Int32>) = "ChangePickerType" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline getIndexPickerValue (x: System.Func<System.Int32, System.DateTime>) = "GetIndexPickerValue" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline getIndexValue (x: System.Func<System.Int32, System.Nullable<System.DateTime>>) = "GetIndexValue" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabledDate (x: System.Func<System.DateTime, System.Boolean>) = "DisabledDate" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline dateRender (x: System.Func<System.DateTime, System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "DateRender" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline monthCellRender (x: System.Func<System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "MonthCellRender" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline calendarDateRender (x: System.Func<System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "CalendarDateRender" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline calendarMonthCellRender (x: System.Func<System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "CalendarMonthCellRender" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline renderExtraFooter (x: Microsoft.AspNetCore.Components.RenderFragment) = "RenderExtraFooter" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onSelect (x: System.Action<System.DateTime, System.Int32>) = "OnSelect" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline pickerIndex (x: System.Int32) = "PickerIndex" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type datePickerDecadePanel<'FunBlazorGeneric, 'TValue> =
    inherit datePickerPanelBase<'FunBlazorGeneric, 'TValue>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.Internal.DatePickerDecadePanel<'TValue>>
    
    static member inline prefixCls (x: System.String) = "PrefixCls" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline picker (x: System.String) = "Picker" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline isRange (x: System.Boolean) = "IsRange" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline isCalendar (x: System.Boolean) = "IsCalendar" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline isShowHeader (x: System.Boolean) = "IsShowHeader" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline locale (x: AntDesign.DatePickerLocale) = "Locale" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline cultureInfo (x: System.Globalization.CultureInfo) = "CultureInfo" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline closePanel (x: System.Action) = "ClosePanel" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline changePickerValue (x: System.Action<System.DateTime, System.Nullable<System.Int32>>) = "ChangePickerValue" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline changeValue (x: System.Action<System.DateTime, System.Int32>) = "ChangeValue" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline changePickerType (x: System.Action<System.String, System.Int32>) = "ChangePickerType" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline getIndexPickerValue (x: System.Func<System.Int32, System.DateTime>) = "GetIndexPickerValue" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline getIndexValue (x: System.Func<System.Int32, System.Nullable<System.DateTime>>) = "GetIndexValue" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabledDate (x: System.Func<System.DateTime, System.Boolean>) = "DisabledDate" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline dateRender (x: System.Func<System.DateTime, System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "DateRender" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline monthCellRender (x: System.Func<System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "MonthCellRender" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline calendarDateRender (x: System.Func<System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "CalendarDateRender" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline calendarMonthCellRender (x: System.Func<System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "CalendarMonthCellRender" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline renderExtraFooter (x: Microsoft.AspNetCore.Components.RenderFragment) = "RenderExtraFooter" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onSelect (x: System.Action<System.DateTime, System.Int32>) = "OnSelect" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline pickerIndex (x: System.Int32) = "PickerIndex" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type datePickerFooter<'FunBlazorGeneric, 'TValue> =
    inherit datePickerPanelBase<'FunBlazorGeneric, 'TValue>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.Internal.DatePickerFooter<'TValue>>
    
    static member inline prefixCls (x: System.String) = "PrefixCls" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline picker (x: System.String) = "Picker" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline isRange (x: System.Boolean) = "IsRange" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline isCalendar (x: System.Boolean) = "IsCalendar" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline isShowHeader (x: System.Boolean) = "IsShowHeader" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline locale (x: AntDesign.DatePickerLocale) = "Locale" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline cultureInfo (x: System.Globalization.CultureInfo) = "CultureInfo" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline closePanel (x: System.Action) = "ClosePanel" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline changePickerValue (x: System.Action<System.DateTime, System.Nullable<System.Int32>>) = "ChangePickerValue" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline changeValue (x: System.Action<System.DateTime, System.Int32>) = "ChangeValue" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline changePickerType (x: System.Action<System.String, System.Int32>) = "ChangePickerType" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline getIndexPickerValue (x: System.Func<System.Int32, System.DateTime>) = "GetIndexPickerValue" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline getIndexValue (x: System.Func<System.Int32, System.Nullable<System.DateTime>>) = "GetIndexValue" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabledDate (x: System.Func<System.DateTime, System.Boolean>) = "DisabledDate" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline dateRender (x: System.Func<System.DateTime, System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "DateRender" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline monthCellRender (x: System.Func<System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "MonthCellRender" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline calendarDateRender (x: System.Func<System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "CalendarDateRender" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline calendarMonthCellRender (x: System.Func<System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "CalendarMonthCellRender" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline renderExtraFooter (x: Microsoft.AspNetCore.Components.RenderFragment) = "RenderExtraFooter" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onSelect (x: System.Action<System.DateTime, System.Int32>) = "OnSelect" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline pickerIndex (x: System.Int32) = "PickerIndex" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type datePickerHeader<'FunBlazorGeneric, 'TValue> =
    inherit datePickerPanelBase<'FunBlazorGeneric, 'TValue>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.Internal.DatePickerHeader<'TValue>>
    
    static member inline superChangeDateInterval (x: System.Int32) = "SuperChangeDateInterval" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline changeDateInterval (x: System.Int32) = "ChangeDateInterval" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline showSuperPreChange (x: System.Boolean) = "ShowSuperPreChange" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline showPreChange (x: System.Boolean) = "ShowPreChange" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline showNextChange (x: System.Boolean) = "ShowNextChange" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline showSuperNextChange (x: System.Boolean) = "ShowSuperNextChange" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline prefixCls (x: System.String) = "PrefixCls" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline picker (x: System.String) = "Picker" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline isRange (x: System.Boolean) = "IsRange" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline isCalendar (x: System.Boolean) = "IsCalendar" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline isShowHeader (x: System.Boolean) = "IsShowHeader" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline locale (x: AntDesign.DatePickerLocale) = "Locale" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline cultureInfo (x: System.Globalization.CultureInfo) = "CultureInfo" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline closePanel (x: System.Action) = "ClosePanel" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline changePickerValue (x: System.Action<System.DateTime, System.Nullable<System.Int32>>) = "ChangePickerValue" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline changeValue (x: System.Action<System.DateTime, System.Int32>) = "ChangeValue" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline changePickerType (x: System.Action<System.String, System.Int32>) = "ChangePickerType" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline getIndexPickerValue (x: System.Func<System.Int32, System.DateTime>) = "GetIndexPickerValue" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline getIndexValue (x: System.Func<System.Int32, System.Nullable<System.DateTime>>) = "GetIndexValue" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabledDate (x: System.Func<System.DateTime, System.Boolean>) = "DisabledDate" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline dateRender (x: System.Func<System.DateTime, System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "DateRender" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline monthCellRender (x: System.Func<System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "MonthCellRender" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline calendarDateRender (x: System.Func<System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "CalendarDateRender" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline calendarMonthCellRender (x: System.Func<System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "CalendarMonthCellRender" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline renderExtraFooter (x: Microsoft.AspNetCore.Components.RenderFragment) = "RenderExtraFooter" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onSelect (x: System.Action<System.DateTime, System.Int32>) = "OnSelect" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline pickerIndex (x: System.Int32) = "PickerIndex" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type datePickerInput<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.Internal.DatePickerInput>
    
    static member inline prefixCls (x: System.String) = "PrefixCls" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline size (x: System.String) = "Size" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline value (x: System.String) = "Value" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline placeholder (x: System.String) = "Placeholder" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline readOnly (x: System.Boolean) = "ReadOnly" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline isRange (x: System.Boolean) = "IsRange" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabled (x: System.Boolean) = "Disabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline autoFocus (x: System.Boolean) = "AutoFocus" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline showSuffixIcon (x: System.Boolean) = "ShowSuffixIcon" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline showTime (x: System.Boolean) = "ShowTime" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline suffixIcon (x: Microsoft.AspNetCore.Components.RenderFragment) = "SuffixIcon" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onClick (x: Microsoft.AspNetCore.Components.EventCallback) = "OnClick" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onfocus (x: Microsoft.AspNetCore.Components.EventCallback) = "Onfocus" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onBlur (x: Microsoft.AspNetCore.Components.EventCallback) = "OnBlur" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onfocusout (x: Microsoft.AspNetCore.Components.EventCallback) = "Onfocusout" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onKeyUp fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs> "OnKeyUp" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onKeyDown fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs> "OnKeyDown" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onInput fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.ChangeEventArgs> "OnInput" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline allowClear (x: System.Boolean) = "AllowClear" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onClickClear (x: Microsoft.AspNetCore.Components.EventCallback) = "OnClickClear" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type datePickerMonthPanel<'FunBlazorGeneric, 'TValue> =
    inherit datePickerPanelBase<'FunBlazorGeneric, 'TValue>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.Internal.DatePickerMonthPanel<'TValue>>
    
    static member inline prefixCls (x: System.String) = "PrefixCls" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline picker (x: System.String) = "Picker" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline isRange (x: System.Boolean) = "IsRange" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline isCalendar (x: System.Boolean) = "IsCalendar" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline isShowHeader (x: System.Boolean) = "IsShowHeader" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline locale (x: AntDesign.DatePickerLocale) = "Locale" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline cultureInfo (x: System.Globalization.CultureInfo) = "CultureInfo" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline closePanel (x: System.Action) = "ClosePanel" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline changePickerValue (x: System.Action<System.DateTime, System.Nullable<System.Int32>>) = "ChangePickerValue" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline changeValue (x: System.Action<System.DateTime, System.Int32>) = "ChangeValue" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline changePickerType (x: System.Action<System.String, System.Int32>) = "ChangePickerType" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline getIndexPickerValue (x: System.Func<System.Int32, System.DateTime>) = "GetIndexPickerValue" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline getIndexValue (x: System.Func<System.Int32, System.Nullable<System.DateTime>>) = "GetIndexValue" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabledDate (x: System.Func<System.DateTime, System.Boolean>) = "DisabledDate" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline dateRender (x: System.Func<System.DateTime, System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "DateRender" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline monthCellRender (x: System.Func<System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "MonthCellRender" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline calendarDateRender (x: System.Func<System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "CalendarDateRender" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline calendarMonthCellRender (x: System.Func<System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "CalendarMonthCellRender" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline renderExtraFooter (x: Microsoft.AspNetCore.Components.RenderFragment) = "RenderExtraFooter" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onSelect (x: System.Action<System.DateTime, System.Int32>) = "OnSelect" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline pickerIndex (x: System.Int32) = "PickerIndex" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type datePickerQuarterPanel<'FunBlazorGeneric, 'TValue> =
    inherit datePickerPanelBase<'FunBlazorGeneric, 'TValue>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.Internal.DatePickerQuarterPanel<'TValue>>
    
    static member inline prefixCls (x: System.String) = "PrefixCls" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline picker (x: System.String) = "Picker" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline isRange (x: System.Boolean) = "IsRange" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline isCalendar (x: System.Boolean) = "IsCalendar" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline isShowHeader (x: System.Boolean) = "IsShowHeader" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline locale (x: AntDesign.DatePickerLocale) = "Locale" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline cultureInfo (x: System.Globalization.CultureInfo) = "CultureInfo" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline closePanel (x: System.Action) = "ClosePanel" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline changePickerValue (x: System.Action<System.DateTime, System.Nullable<System.Int32>>) = "ChangePickerValue" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline changeValue (x: System.Action<System.DateTime, System.Int32>) = "ChangeValue" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline changePickerType (x: System.Action<System.String, System.Int32>) = "ChangePickerType" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline getIndexPickerValue (x: System.Func<System.Int32, System.DateTime>) = "GetIndexPickerValue" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline getIndexValue (x: System.Func<System.Int32, System.Nullable<System.DateTime>>) = "GetIndexValue" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabledDate (x: System.Func<System.DateTime, System.Boolean>) = "DisabledDate" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline dateRender (x: System.Func<System.DateTime, System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "DateRender" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline monthCellRender (x: System.Func<System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "MonthCellRender" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline calendarDateRender (x: System.Func<System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "CalendarDateRender" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline calendarMonthCellRender (x: System.Func<System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "CalendarMonthCellRender" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline renderExtraFooter (x: Microsoft.AspNetCore.Components.RenderFragment) = "RenderExtraFooter" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onSelect (x: System.Action<System.DateTime, System.Int32>) = "OnSelect" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline pickerIndex (x: System.Int32) = "PickerIndex" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type datePickerYearPanel<'FunBlazorGeneric, 'TValue> =
    inherit datePickerPanelBase<'FunBlazorGeneric, 'TValue>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.Internal.DatePickerYearPanel<'TValue>>
    
    static member inline prefixCls (x: System.String) = "PrefixCls" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline picker (x: System.String) = "Picker" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline isRange (x: System.Boolean) = "IsRange" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline isCalendar (x: System.Boolean) = "IsCalendar" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline isShowHeader (x: System.Boolean) = "IsShowHeader" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline locale (x: AntDesign.DatePickerLocale) = "Locale" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline cultureInfo (x: System.Globalization.CultureInfo) = "CultureInfo" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline closePanel (x: System.Action) = "ClosePanel" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline changePickerValue (x: System.Action<System.DateTime, System.Nullable<System.Int32>>) = "ChangePickerValue" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline changeValue (x: System.Action<System.DateTime, System.Int32>) = "ChangeValue" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline changePickerType (x: System.Action<System.String, System.Int32>) = "ChangePickerType" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline getIndexPickerValue (x: System.Func<System.Int32, System.DateTime>) = "GetIndexPickerValue" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline getIndexValue (x: System.Func<System.Int32, System.Nullable<System.DateTime>>) = "GetIndexValue" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabledDate (x: System.Func<System.DateTime, System.Boolean>) = "DisabledDate" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline dateRender (x: System.Func<System.DateTime, System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "DateRender" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline monthCellRender (x: System.Func<System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "MonthCellRender" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline calendarDateRender (x: System.Func<System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "CalendarDateRender" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline calendarMonthCellRender (x: System.Func<System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "CalendarMonthCellRender" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline renderExtraFooter (x: Microsoft.AspNetCore.Components.RenderFragment) = "RenderExtraFooter" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onSelect (x: System.Action<System.DateTime, System.Int32>) = "OnSelect" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline pickerIndex (x: System.Int32) = "PickerIndex" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type dropdownGroupButton<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.Internal.DropdownGroupButton>
    
    static member inline leftButton (x: Microsoft.AspNetCore.Components.RenderFragment) = "LeftButton" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline rightButton (x: Microsoft.AspNetCore.Components.RenderFragment) = "RightButton" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        


namespace rec Fun.Blazor.AntDesign


type IAffixNode = interface end

type affix =
    class
        inherit Internal.affix<IAffixNode>
    end

type IAlertNode = interface end

type alert =
    class
        inherit Internal.alert<IAlertNode>
    end

type IAnchorNode = interface end

type anchor =
    class
        inherit Internal.anchor<IAnchorNode>
    end

type IAnchorLinkNode = interface end

type anchorLink =
    class
        inherit Internal.anchorLink<IAnchorLinkNode>
    end

type IAutoCompleteNode<'TOption> = interface end

type autoComplete<'TOption> =
    class
        inherit Internal.autoComplete<IAutoCompleteNode<'TOption>, 'TOption>
    end

type IAutoCompleteInputNode<'TValue> = interface end

type autoCompleteInput<'TValue> =
    class
        inherit Internal.autoCompleteInput<IAutoCompleteInputNode<'TValue>, 'TValue>
    end

type IAutoCompleteOptGroupNode = interface end

type autoCompleteOptGroup =
    class
        inherit Internal.autoCompleteOptGroup<IAutoCompleteOptGroupNode>
    end

type IAutoCompleteOptionNode = interface end

type autoCompleteOption =
    class
        inherit Internal.autoCompleteOption<IAutoCompleteOptionNode>
    end

type IAutoCompleteSearchNode = interface end

type autoCompleteSearch =
    class
        inherit Internal.autoCompleteSearch<IAutoCompleteSearchNode>
    end

type IAvatarNode = interface end

type avatar =
    class
        inherit Internal.avatar<IAvatarNode>
    end

type IAvatarGroupNode = interface end

type avatarGroup =
    class
        inherit Internal.avatarGroup<IAvatarGroupNode>
    end

type IBackTopNode = interface end

type backTop =
    class
        inherit Internal.backTop<IBackTopNode>
    end

type IBadgeNode = interface end

type badge =
    class
        inherit Internal.badge<IBadgeNode>
    end

type IBadgeRibbonNode = interface end

type badgeRibbon =
    class
        inherit Internal.badgeRibbon<IBadgeRibbonNode>
    end

type IBreadcrumbNode = interface end

type breadcrumb =
    class
        inherit Internal.breadcrumb<IBreadcrumbNode>
    end

type IButtonNode = interface end

type button =
    class
        inherit Internal.button<IButtonNode>
    end

type IButtonGroupNode = interface end

type buttonGroup =
    class
        inherit Internal.buttonGroup<IButtonGroupNode>
    end

type ICalendarNode = interface end

type calendar =
    class
        inherit Internal.calendar<ICalendarNode>
    end

type ICardNode = interface end

type card =
    class
        inherit Internal.card<ICardNode>
    end

type ICardActionNode = interface end

type cardAction =
    class
        inherit Internal.cardAction<ICardActionNode>
    end

type ICardGridNode = interface end

type cardGrid =
    class
        inherit Internal.cardGrid<ICardGridNode>
    end

type ICarouselNode = interface end

type carousel =
    class
        inherit Internal.carousel<ICarouselNode>
    end

type ICarouselSlickNode = interface end

type carouselSlick =
    class
        inherit Internal.carouselSlick<ICarouselSlickNode>
    end

type ICascaderNode = interface end

type cascader =
    class
        inherit Internal.cascader<ICascaderNode>
    end

type ICheckboxNode = interface end

type checkbox =
    class
        inherit Internal.checkbox<ICheckboxNode>
    end

type ICheckboxGroupNode = interface end

type checkboxGroup =
    class
        inherit Internal.checkboxGroup<ICheckboxGroupNode>
    end

type ICollapseNode = interface end

type collapse =
    class
        inherit Internal.collapse<ICollapseNode>
    end

type IPanelNode = interface end

type panel =
    class
        inherit Internal.panel<IPanelNode>
    end

type ICommentNode = interface end

type comment =
    class
        inherit Internal.comment<ICommentNode>
    end

type IConfigProviderNode = interface end

type configProvider =
    class
        inherit Internal.configProvider<IConfigProviderNode>
    end

type IAntComponentBaseNode = interface end

type antComponentBase =
    class
        inherit Internal.antComponentBase<IAntComponentBaseNode>
    end

type IAntContainerComponentBaseNode = interface end

type antContainerComponentBase =
    class
        inherit Internal.antContainerComponentBase<IAntContainerComponentBaseNode>
    end

type IAntDomComponentBaseNode = interface end

type antDomComponentBase =
    class
        inherit Internal.antDomComponentBase<IAntDomComponentBaseNode>
    end

type IAntInputBoolComponentBaseNode = interface end

type antInputBoolComponentBase =
    class
        inherit Internal.antInputBoolComponentBase<IAntInputBoolComponentBaseNode>
    end

type IAntInputComponentBaseNode<'TValue> = interface end

type antInputComponentBase<'TValue> =
    class
        inherit Internal.antInputComponentBase<IAntInputComponentBaseNode<'TValue>, 'TValue>
    end

type ITemplateComponentBaseNode<'TComponentOptions> = interface end

type templateComponentBase<'TComponentOptions> =
    class
        inherit Internal.templateComponentBase<ITemplateComponentBaseNode<'TComponentOptions>, 'TComponentOptions>
    end

type IFeedbackComponentNode<'TComponentOptions> = interface end

type feedbackComponent<'TComponentOptions> =
    class
        inherit Internal.feedbackComponent<IFeedbackComponentNode<'TComponentOptions>, 'TComponentOptions>
    end

type IFeedbackComponentNode<'TComponentOptions, 'TResult> = interface end

type feedbackComponent<'TComponentOptions, 'TResult> =
    class
        inherit Internal.feedbackComponent<IFeedbackComponentNode<'TComponentOptions, 'TResult>, 'TComponentOptions, 'TResult>
    end

type IDatePickerNode<'TValue> = interface end

type datePicker<'TValue> =
    class
        inherit Internal.datePicker<IDatePickerNode<'TValue>, 'TValue>
    end

type IDatePickerBaseNode<'TValue> = interface end

type datePickerBase<'TValue> =
    class
        inherit Internal.datePickerBase<IDatePickerBaseNode<'TValue>, 'TValue>
    end

type IDatePickerPanelBaseNode<'TValue> = interface end

type datePickerPanelBase<'TValue> =
    class
        inherit Internal.datePickerPanelBase<IDatePickerPanelBaseNode<'TValue>, 'TValue>
    end

type IMonthPickerNode<'TValue> = interface end

type monthPicker<'TValue> =
    class
        inherit Internal.monthPicker<IMonthPickerNode<'TValue>, 'TValue>
    end

type IQuarterPickerNode<'TValue> = interface end

type quarterPicker<'TValue> =
    class
        inherit Internal.quarterPicker<IQuarterPickerNode<'TValue>, 'TValue>
    end

type IRangePickerNode<'TValue> = interface end

type rangePicker<'TValue> =
    class
        inherit Internal.rangePicker<IRangePickerNode<'TValue>, 'TValue>
    end

type IWeekPickerNode<'TValue> = interface end

type weekPicker<'TValue> =
    class
        inherit Internal.weekPicker<IWeekPickerNode<'TValue>, 'TValue>
    end

type IYearPickerNode<'TValue> = interface end

type yearPicker<'TValue> =
    class
        inherit Internal.yearPicker<IYearPickerNode<'TValue>, 'TValue>
    end

type IDescriptionsNode = interface end

type descriptions =
    class
        inherit Internal.descriptions<IDescriptionsNode>
    end

type IDescriptionsItemNode = interface end

type descriptionsItem =
    class
        inherit Internal.descriptionsItem<IDescriptionsItemNode>
    end

type IDividerNode = interface end

type divider =
    class
        inherit Internal.divider<IDividerNode>
    end

type IDrawerNode = interface end

type drawer =
    class
        inherit Internal.drawer<IDrawerNode>
    end

type IDrawerContainerNode = interface end

type drawerContainer =
    class
        inherit Internal.drawerContainer<IDrawerContainerNode>
    end

type IDropdownNode = interface end

type dropdown =
    class
        inherit Internal.dropdown<IDropdownNode>
    end

type IDropdownButtonNode = interface end

type dropdownButton =
    class
        inherit Internal.dropdownButton<IDropdownButtonNode>
    end

type IEmptyNode = interface end

type empty =
    class
        inherit Internal.empty<IEmptyNode>
    end

type IFormNode<'TModel> = interface end

type form<'TModel> =
    class
        inherit Internal.form<IFormNode<'TModel>, 'TModel>
    end

type IFormItemNode = interface end

type formItem =
    class
        inherit Internal.formItem<IFormItemNode>
    end

type IFormProviderNode = interface end

type formProvider =
    class
        inherit Internal.formProvider<IFormProviderNode>
    end

type IFormValidationMessageNode<'TValue> = interface end

type formValidationMessage<'TValue> =
    class
        inherit Internal.formValidationMessage<IFormValidationMessageNode<'TValue>, 'TValue>
    end

type IFormValidationMessageItemNode = interface end

type formValidationMessageItem =
    class
        inherit Internal.formValidationMessageItem<IFormValidationMessageItemNode>
    end

type IColNode = interface end

type col =
    class
        inherit Internal.col<IColNode>
    end

type IGridColNode = interface end

type gridCol =
    class
        inherit Internal.gridCol<IGridColNode>
    end

type IRowNode = interface end

type row =
    class
        inherit Internal.row<IRowNode>
    end

type IIconNode = interface end

type icon =
    class
        inherit Internal.icon<IIconNode>
    end

type IIconFontNode = interface end

type iconFont =
    class
        inherit Internal.iconFont<IIconFontNode>
    end

type IImageNode = interface end

type image =
    class
        inherit Internal.image<IImageNode>
    end

type IImagePreviewNode = interface end

type imagePreview =
    class
        inherit Internal.imagePreview<IImagePreviewNode>
    end

type IImagePreviewContainerNode = interface end

type imagePreviewContainer =
    class
        inherit Internal.imagePreviewContainer<IImagePreviewContainerNode>
    end

type IImagePreviewGroupNode = interface end

type imagePreviewGroup =
    class
        inherit Internal.imagePreviewGroup<IImagePreviewGroupNode>
    end

type IInputNumberNode<'TValue> = interface end

type inputNumber<'TValue> =
    class
        inherit Internal.inputNumber<IInputNumberNode<'TValue>, 'TValue>
    end

type IInputNode<'TValue> = interface end

type input<'TValue> =
    class
        inherit Internal.input<IInputNode<'TValue>, 'TValue>
    end

type IInputGroupNode = interface end

type inputGroup =
    class
        inherit Internal.inputGroup<IInputGroupNode>
    end

type IInputPasswordNode = interface end

type inputPassword =
    class
        inherit Internal.inputPassword<IInputPasswordNode>
    end

type ISearchNode = interface end

type search =
    class
        inherit Internal.search<ISearchNode>
    end

type ITextAreaNode = interface end

type textArea =
    class
        inherit Internal.textArea<ITextAreaNode>
    end

type ISiderNode = interface end

type sider =
    class
        inherit Internal.sider<ISiderNode>
    end

type IAntListNode<'TItem> = interface end

type antList<'TItem> =
    class
        inherit Internal.antList<IAntListNode<'TItem>, 'TItem>
    end

type IListItemNode = interface end

type listItem =
    class
        inherit Internal.listItem<IListItemNode>
    end

type IListItemMetaNode = interface end

type listItemMeta =
    class
        inherit Internal.listItemMeta<IListItemMetaNode>
    end

type IMentionsNode = interface end

type mentions =
    class
        inherit Internal.mentions<IMentionsNode>
    end

type IMentionsOptionNode = interface end

type mentionsOption =
    class
        inherit Internal.mentionsOption<IMentionsOptionNode>
    end

type IMenuNode = interface end

type menu =
    class
        inherit Internal.menu<IMenuNode>
    end

type IMenuItemNode = interface end

type menuItem =
    class
        inherit Internal.menuItem<IMenuItemNode>
    end

type IMenuItemGroupNode = interface end

type menuItemGroup =
    class
        inherit Internal.menuItemGroup<IMenuItemGroupNode>
    end

type IMenuLinkNode = interface end

type menuLink =
    class
        inherit Internal.menuLink<IMenuLinkNode>
    end

type ISubMenuNode = interface end

type subMenu =
    class
        inherit Internal.subMenu<ISubMenuNode>
    end

type IMessageNode = interface end

type message =
    class
        inherit Internal.message<IMessageNode>
    end

type IMessageItemNode = interface end

type messageItem =
    class
        inherit Internal.messageItem<IMessageItemNode>
    end

type IComfirmContainerNode = interface end

type comfirmContainer =
    class
        inherit Internal.comfirmContainer<IComfirmContainerNode>
    end

type IConfirmNode = interface end

type confirm =
    class
        inherit Internal.confirm<IConfirmNode>
    end

type IDialogNode = interface end

type dialog =
    class
        inherit Internal.dialog<IDialogNode>
    end

type IDialogWrapperNode = interface end

type dialogWrapper =
    class
        inherit Internal.dialogWrapper<IDialogWrapperNode>
    end

type IModalNode = interface end

type modal =
    class
        inherit Internal.modal<IModalNode>
    end

type IModalContainerNode = interface end

type modalContainer =
    class
        inherit Internal.modalContainer<IModalContainerNode>
    end

type IModalFooterNode = interface end

type modalFooter =
    class
        inherit Internal.modalFooter<IModalFooterNode>
    end

type INotificationNode = interface end

type notification =
    class
        inherit Internal.notification<INotificationNode>
    end

type INotificationBaseNode = interface end

type notificationBase =
    class
        inherit Internal.notificationBase<INotificationBaseNode>
    end

type INotificationItemNode = interface end

type notificationItem =
    class
        inherit Internal.notificationItem<INotificationItemNode>
    end

type IPageHeaderNode = interface end

type pageHeader =
    class
        inherit Internal.pageHeader<IPageHeaderNode>
    end

type IPaginationNode = interface end

type pagination =
    class
        inherit Internal.pagination<IPaginationNode>
    end

type IPaginationOptionsNode = interface end

type paginationOptions =
    class
        inherit Internal.paginationOptions<IPaginationOptionsNode>
    end

type IPopconfirmNode = interface end

type popconfirm =
    class
        inherit Internal.popconfirm<IPopconfirmNode>
    end

type IPopoverNode = interface end

type popover =
    class
        inherit Internal.popover<IPopoverNode>
    end

type IProgressNode = interface end

type progress =
    class
        inherit Internal.progress<IProgressNode>
    end

type IRadioNode<'TValue> = interface end

type radio<'TValue> =
    class
        inherit Internal.radio<IRadioNode<'TValue>, 'TValue>
    end

type IRadioGroupNode<'TValue> = interface end

type radioGroup<'TValue> =
    class
        inherit Internal.radioGroup<IRadioGroupNode<'TValue>, 'TValue>
    end

type IRateNode = interface end

type rate =
    class
        inherit Internal.rate<IRateNode>
    end

type IRateItemNode = interface end

type rateItem =
    class
        inherit Internal.rateItem<IRateItemNode>
    end

type IResultNode = interface end

type result =
    class
        inherit Internal.result<IResultNode>
    end

type ISelectNode<'TItemValue, 'TItem> = interface end

type select<'TItemValue, 'TItem> =
    class
        inherit Internal.select<ISelectNode<'TItemValue, 'TItem>, 'TItemValue, 'TItem>
    end

type ISelectOptionNode<'TItemValue, 'TItem> = interface end

type selectOption<'TItemValue, 'TItem> =
    class
        inherit Internal.selectOption<ISelectOptionNode<'TItemValue, 'TItem>, 'TItemValue, 'TItem>
    end

type ISimpleSelectNode = interface end

type simpleSelect =
    class
        inherit Internal.simpleSelect<ISimpleSelectNode>
    end

type ISimpleSelectOptionNode = interface end

type simpleSelectOption =
    class
        inherit Internal.simpleSelectOption<ISimpleSelectOptionNode>
    end

type ISkeletonNode = interface end

type skeleton =
    class
        inherit Internal.skeleton<ISkeletonNode>
    end

type ISkeletonElementNode = interface end

type skeletonElement =
    class
        inherit Internal.skeletonElement<ISkeletonElementNode>
    end

type ISliderNode<'TValue> = interface end

type slider<'TValue> =
    class
        inherit Internal.slider<ISliderNode<'TValue>, 'TValue>
    end

type ISpaceNode = interface end

type space =
    class
        inherit Internal.space<ISpaceNode>
    end

type ISpaceItemNode = interface end

type spaceItem =
    class
        inherit Internal.spaceItem<ISpaceItemNode>
    end

type ISpinNode = interface end

type spin =
    class
        inherit Internal.spin<ISpinNode>
    end

type ICountDownNode = interface end

type countDown =
    class
        inherit Internal.countDown<ICountDownNode>
    end

type IStatisticNode<'TValue> = interface end

type statistic<'TValue> =
    class
        inherit Internal.statistic<IStatisticNode<'TValue>, 'TValue>
    end

type IStatisticComponentBaseNode<'T> = interface end

type statisticComponentBase<'T> =
    class
        inherit Internal.statisticComponentBase<IStatisticComponentBaseNode<'T>, 'T>
    end

type IStepNode = interface end

type step =
    class
        inherit Internal.step<IStepNode>
    end

type IStepsNode = interface end

type steps =
    class
        inherit Internal.steps<IStepsNode>
    end

type ISwitchNode = interface end

type switch =
    class
        inherit Internal.switch<ISwitchNode>
    end

type IActionColumnNode = interface end

type actionColumn =
    class
        inherit Internal.actionColumn<IActionColumnNode>
    end

type IColumnNode<'TData> = interface end

type column<'TData> =
    class
        inherit Internal.column<IColumnNode<'TData>, 'TData>
    end

type IColumnBaseNode = interface end

type columnBase =
    class
        inherit Internal.columnBase<IColumnBaseNode>
    end

type ISelectionNode = interface end

type selection =
    class
        inherit Internal.selection<ISelectionNode>
    end

type ITableNode<'TItem> = interface end

type table<'TItem> =
    class
        inherit Internal.table<ITableNode<'TItem>, 'TItem>
    end

type ITabPaneNode = interface end

type tabPane =
    class
        inherit Internal.tabPane<ITabPaneNode>
    end

type ITabsNode = interface end

type tabs =
    class
        inherit Internal.tabs<ITabsNode>
    end

type ITagNode = interface end

type tag =
    class
        inherit Internal.tag<ITagNode>
    end

type ITimePickerNode<'TValue> = interface end

type timePicker<'TValue> =
    class
        inherit Internal.timePicker<ITimePickerNode<'TValue>, 'TValue>
    end

type ITimelineNode = interface end

type timeline =
    class
        inherit Internal.timeline<ITimelineNode>
    end

type ITimelineItemNode = interface end

type timelineItem =
    class
        inherit Internal.timelineItem<ITimelineItemNode>
    end

type ITooltipNode = interface end

type tooltip =
    class
        inherit Internal.tooltip<ITooltipNode>
    end

type ITransferNode = interface end

type transfer =
    class
        inherit Internal.transfer<ITransferNode>
    end

type ITreeNode<'TItem> = interface end

type tree<'TItem> =
    class
        inherit Internal.tree<ITreeNode<'TItem>, 'TItem>
    end

type ITreeIndentNode<'TItem> = interface end

type treeIndent<'TItem> =
    class
        inherit Internal.treeIndent<ITreeIndentNode<'TItem>, 'TItem>
    end

type ITreeNodeNode<'TItem> = interface end

type treeNode<'TItem> =
    class
        inherit Internal.treeNode<ITreeNodeNode<'TItem>, 'TItem>
    end

type ITreeNodeCheckboxNode<'TItem> = interface end

type treeNodeCheckbox<'TItem> =
    class
        inherit Internal.treeNodeCheckbox<ITreeNodeCheckboxNode<'TItem>, 'TItem>
    end

type ITreeNodeSwitcherNode<'TItem> = interface end

type treeNodeSwitcher<'TItem> =
    class
        inherit Internal.treeNodeSwitcher<ITreeNodeSwitcherNode<'TItem>, 'TItem>
    end

type ILinkNode = interface end

type link =
    class
        inherit Internal.link<ILinkNode>
    end

type IParagraphNode = interface end

type paragraph =
    class
        inherit Internal.paragraph<IParagraphNode>
    end

type ITextNode = interface end

type text =
    class
        inherit Internal.text<ITextNode>
    end

type ITitleNode = interface end

type title =
    class
        inherit Internal.title<ITitleNode>
    end

type ITypographyBaseNode = interface end

type typographyBase =
    class
        inherit Internal.typographyBase<ITypographyBaseNode>
    end

type IUploadNode = interface end

type upload =
    class
        inherit Internal.upload<IUploadNode>
    end

type IBreadcrumbItemNode = interface end

type breadcrumbItem =
    class
        inherit Internal.breadcrumbItem<IBreadcrumbItemNode>
    end

type ICalendarHeaderNode = interface end

type calendarHeader =
    class
        inherit Internal.calendarHeader<ICalendarHeaderNode>
    end

type ICardMetaNode = interface end

type cardMeta =
    class
        inherit Internal.cardMeta<ICardMetaNode>
    end

type IAntContainerNode = interface end

type antContainer =
    class
        inherit Internal.antContainer<IAntContainerNode>
    end

type ITemplateNode = interface end

type template =
    class
        inherit Internal.template<ITemplateNode>
    end

type IEmptyDefaultImgNode = interface end

type emptyDefaultImg =
    class
        inherit Internal.emptyDefaultImg<IEmptyDefaultImgNode>
    end

type IEmptySimpleImgNode = interface end

type emptySimpleImg =
    class
        inherit Internal.emptySimpleImg<IEmptySimpleImgNode>
    end

type IContentNode = interface end

type content =
    class
        inherit Internal.content<IContentNode>
    end

type IFooterNode = interface end

type footer =
    class
        inherit Internal.footer<IFooterNode>
    end

type IHeaderNode = interface end

type header =
    class
        inherit Internal.header<IHeaderNode>
    end

type ILayoutNode = interface end

type layout =
    class
        inherit Internal.layout<ILayoutNode>
    end

type IMenuDividerNode = interface end

type menuDivider =
    class
        inherit Internal.menuDivider<IMenuDividerNode>
    end

type IPaginationPagerNode = interface end

type paginationPager =
    class
        inherit Internal.paginationPager<IPaginationPagerNode>
    end

type ISummaryCellNode = interface end

type summaryCell =
    class
        inherit Internal.summaryCell<ISummaryCellNode>
    end

type ISummaryRowNode = interface end

type summaryRow =
    class
        inherit Internal.summaryRow<ISummaryRowNode>
    end

type ILabelTemplateItemNode<'TItemValue, 'TItem> = interface end

type labelTemplateItem<'TItemValue, 'TItem> =
    class
        inherit Internal.labelTemplateItem<ILabelTemplateItemNode<'TItemValue, 'TItem>, 'TItemValue, 'TItem>
    end

type ISelectContentNode<'TItemValue, 'TItem> = interface end

type selectContent<'TItemValue, 'TItem> =
    class
        inherit Internal.selectContent<ISelectContentNode<'TItemValue, 'TItem>, 'TItemValue, 'TItem>
    end

type ISelectOptionGroupNode<'TItemValue, 'TItem> = interface end

type selectOptionGroup<'TItemValue, 'TItem> =
    class
        inherit Internal.selectOptionGroup<ISelectOptionGroupNode<'TItemValue, 'TItem>, 'TItemValue, 'TItem>
    end

type ICalendarPanelChooserNode = interface end

type calendarPanelChooser =
    class
        inherit Internal.calendarPanelChooser<ICalendarPanelChooserNode>
    end

type IElementNode = interface end

type element =
    class
        inherit Internal.element<IElementNode>
    end

type IOverlayNode = interface end

type overlay =
    class
        inherit Internal.overlay<IOverlayNode>
    end

type IOverlayTriggerNode = interface end

type overlayTrigger =
    class
        inherit Internal.overlayTrigger<IOverlayTriggerNode>
    end

type IDatePickerDatetimePanelNode<'TValue> = interface end

type datePickerDatetimePanel<'TValue> =
    class
        inherit Internal.datePickerDatetimePanel<IDatePickerDatetimePanelNode<'TValue>, 'TValue>
    end

type IDatePickerPanelChooserNode<'TValue> = interface end

type datePickerPanelChooser<'TValue> =
    class
        inherit Internal.datePickerPanelChooser<IDatePickerPanelChooserNode<'TValue>, 'TValue>
    end

type IDatePickerTemplateNode<'TValue> = interface end

type datePickerTemplate<'TValue> =
    class
        inherit Internal.datePickerTemplate<IDatePickerTemplateNode<'TValue>, 'TValue>
    end

type IPickerPanelBaseNode = interface end

type pickerPanelBase =
    class
        inherit Internal.pickerPanelBase<IPickerPanelBaseNode>
    end

type ISubMenuTriggerNode = interface end

type subMenuTrigger =
    class
        inherit Internal.subMenuTrigger<ISubMenuTriggerNode>
    end

type IUploadButtonNode = interface end

type uploadButton =
    class
        inherit Internal.uploadButton<IUploadButtonNode>
    end

type IDatePickerDatePanelNode<'TValue> = interface end

type datePickerDatePanel<'TValue> =
    class
        inherit Internal.datePickerDatePanel<IDatePickerDatePanelNode<'TValue>, 'TValue>
    end

type IDatePickerDecadePanelNode<'TValue> = interface end

type datePickerDecadePanel<'TValue> =
    class
        inherit Internal.datePickerDecadePanel<IDatePickerDecadePanelNode<'TValue>, 'TValue>
    end

type IDatePickerFooterNode<'TValue> = interface end

type datePickerFooter<'TValue> =
    class
        inherit Internal.datePickerFooter<IDatePickerFooterNode<'TValue>, 'TValue>
    end

type IDatePickerHeaderNode<'TValue> = interface end

type datePickerHeader<'TValue> =
    class
        inherit Internal.datePickerHeader<IDatePickerHeaderNode<'TValue>, 'TValue>
    end

type IDatePickerInputNode = interface end

type datePickerInput =
    class
        inherit Internal.datePickerInput<IDatePickerInputNode>
    end

type IDatePickerMonthPanelNode<'TValue> = interface end

type datePickerMonthPanel<'TValue> =
    class
        inherit Internal.datePickerMonthPanel<IDatePickerMonthPanelNode<'TValue>, 'TValue>
    end

type IDatePickerQuarterPanelNode<'TValue> = interface end

type datePickerQuarterPanel<'TValue> =
    class
        inherit Internal.datePickerQuarterPanel<IDatePickerQuarterPanelNode<'TValue>, 'TValue>
    end

type IDatePickerYearPanelNode<'TValue> = interface end

type datePickerYearPanel<'TValue> =
    class
        inherit Internal.datePickerYearPanel<IDatePickerYearPanelNode<'TValue>, 'TValue>
    end

type IDropdownGroupButtonNode = interface end

type dropdownGroupButton =
    class
        inherit Internal.dropdownGroupButton<IDropdownGroupButtonNode>
    end