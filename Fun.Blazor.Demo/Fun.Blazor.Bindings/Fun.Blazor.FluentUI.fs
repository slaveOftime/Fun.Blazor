namespace rec Fun.Blazor.FluentUI.Internal

open Bolero
open Bolero.Html
open Fun.Blazor
open Fun.Blazor.Web.Internal


type navLinkFluentAnchor<'FelizBoleroNode> =
    inherit navLink<'FelizBoleroNode>
    static member navLinkFluentAnchor (nodes: GenericFelizNode<'FelizBoleroNode> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<Microsoft.Fast.Components.FluentUI.NavLinkFluentAnchor>
    static member navLinkFluentAnchor (nodes: FunBlazorNode list) = nodes |> html.blazor<Microsoft.Fast.Components.FluentUI.NavLinkFluentAnchor>
    static member inline href (x: System.String) = "Href" => x |> BoleroAttr |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline appearance (x: System.Nullable<Microsoft.Fast.Components.FluentUI.Appearance>) = "Appearance" => x |> BoleroAttr |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline activeClass (x: System.String) = "ActiveClass" => x |> BoleroAttr |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline additionalAttributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "AdditionalAttributes" => x |> BoleroAttr |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline children (text: string) = attr.children text |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline ``match`` (x: Microsoft.AspNetCore.Components.Routing.NavLinkMatch) = "Match" => x |> BoleroAttr |> GenericFelizNode<'FelizBoleroNode>.create
        

type fluentDesignSystemProvider<'FelizBoleroNode> =
    
    static member fluentDesignSystemProvider (nodes: GenericFelizNode<'FelizBoleroNode> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentDesignSystemProvider>
    static member fluentDesignSystemProvider (nodes: FunBlazorNode list) = nodes |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentDesignSystemProvider>
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline children (text: string) = attr.children text |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline additionalAttributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "AdditionalAttributes" => x |> BoleroAttr |> GenericFelizNode<'FelizBoleroNode>.create
        

type fluentInputBase<'FelizBoleroNode, 'TValue> =
    
    static member fluentInputBase (nodes: GenericFelizNode<'FelizBoleroNode> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentInputBase<'TValue>>
    
    static member inline additionalAttributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "AdditionalAttributes" => x |> BoleroAttr |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline value (x: 'TValue) = "Value" => x |> BoleroAttr |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline valueChanged fn = (Bolero.Html.attr.callback<'TValue> "ValueChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline valueExpression (x: System.Linq.Expressions.Expression<System.Func<'TValue>>) = "ValueExpression" => x |> BoleroAttr |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline displayName (x: System.String) = "DisplayName" => x |> BoleroAttr |> GenericFelizNode<'FelizBoleroNode>.create
        

type fluentAccordion<'FelizBoleroNode> =
    
    static member fluentAccordion (nodes: GenericFelizNode<'FelizBoleroNode> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentAccordion>
    static member fluentAccordion (nodes: FunBlazorNode list) = nodes |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentAccordion>
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline children (text: string) = attr.children text |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline expandMode (x: System.Nullable<Microsoft.Fast.Components.FluentUI.ExpandMode>) = "ExpandMode" => x |> BoleroAttr |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline additionalAttributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "AdditionalAttributes" => x |> BoleroAttr |> GenericFelizNode<'FelizBoleroNode>.create
        

type fluentAccordionItem<'FelizBoleroNode> =
    
    static member fluentAccordionItem (nodes: GenericFelizNode<'FelizBoleroNode> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentAccordionItem>
    static member fluentAccordionItem (nodes: FunBlazorNode list) = nodes |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentAccordionItem>
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline children (text: string) = attr.children text |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline expanded (x: System.Nullable<System.Boolean>) = "Expanded" => x |> BoleroAttr |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline additionalAttributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "AdditionalAttributes" => x |> BoleroAttr |> GenericFelizNode<'FelizBoleroNode>.create
        

type fluentAnchor<'FelizBoleroNode> =
    
    static member fluentAnchor (nodes: GenericFelizNode<'FelizBoleroNode> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentAnchor>
    static member fluentAnchor (nodes: FunBlazorNode list) = nodes |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentAnchor>
    static member inline href (x: System.String) = "Href" => x |> BoleroAttr |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline appearance (x: System.Nullable<Microsoft.Fast.Components.FluentUI.Appearance>) = "Appearance" => x |> BoleroAttr |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline children (text: string) = attr.children text |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline additionalAttributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "AdditionalAttributes" => x |> BoleroAttr |> GenericFelizNode<'FelizBoleroNode>.create
        

type fluentBadge<'FelizBoleroNode> =
    
    static member fluentBadge (nodes: GenericFelizNode<'FelizBoleroNode> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentBadge>
    static member fluentBadge (nodes: FunBlazorNode list) = nodes |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentBadge>
    static member inline color (x: System.Nullable<Microsoft.Fast.Components.FluentUI.Color>) = "Color" => x |> BoleroAttr |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline fill (x: System.Nullable<Microsoft.Fast.Components.FluentUI.Fill>) = "Fill" => x |> BoleroAttr |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline appearance (x: System.Nullable<Microsoft.Fast.Components.FluentUI.Appearance>) = "Appearance" => x |> BoleroAttr |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline children (text: string) = attr.children text |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline additionalAttributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "AdditionalAttributes" => x |> BoleroAttr |> GenericFelizNode<'FelizBoleroNode>.create
        

type fluentBreadcrumb<'FelizBoleroNode> =
    
    static member fluentBreadcrumb (nodes: GenericFelizNode<'FelizBoleroNode> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentBreadcrumb>
    static member fluentBreadcrumb (nodes: FunBlazorNode list) = nodes |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentBreadcrumb>
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline children (text: string) = attr.children text |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline additionalAttributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "AdditionalAttributes" => x |> BoleroAttr |> GenericFelizNode<'FelizBoleroNode>.create
        

type fluentBreadcrumbItem<'FelizBoleroNode> =
    
    static member fluentBreadcrumbItem (nodes: GenericFelizNode<'FelizBoleroNode> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentBreadcrumbItem>
    static member fluentBreadcrumbItem (nodes: FunBlazorNode list) = nodes |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentBreadcrumbItem>
    static member inline href (x: System.String) = "Href" => x |> BoleroAttr |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline children (text: string) = attr.children text |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline additionalAttributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "AdditionalAttributes" => x |> BoleroAttr |> GenericFelizNode<'FelizBoleroNode>.create
        

type fluentButton<'FelizBoleroNode> =
    
    static member fluentButton (nodes: GenericFelizNode<'FelizBoleroNode> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentButton>
    static member fluentButton (nodes: FunBlazorNode list) = nodes |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentButton>
    static member inline appearance (x: System.Nullable<Microsoft.Fast.Components.FluentUI.Appearance>) = "Appearance" => x |> BoleroAttr |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline disabled (x: System.Nullable<System.Boolean>) = "Disabled" => x |> BoleroAttr |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline autofocus (x: System.Nullable<System.Boolean>) = "Autofocus" => x |> BoleroAttr |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline children (text: string) = attr.children text |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline additionalAttributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "AdditionalAttributes" => x |> BoleroAttr |> GenericFelizNode<'FelizBoleroNode>.create
        

type fluentCard<'FelizBoleroNode> =
    
    static member fluentCard (nodes: GenericFelizNode<'FelizBoleroNode> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentCard>
    static member fluentCard (nodes: FunBlazorNode list) = nodes |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentCard>
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline children (text: string) = attr.children text |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline additionalAttributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "AdditionalAttributes" => x |> BoleroAttr |> GenericFelizNode<'FelizBoleroNode>.create
        

type fluentCheckbox<'FelizBoleroNode> =
    inherit fluentInputBase<'FelizBoleroNode, System.Boolean>
    static member fluentCheckbox (nodes: GenericFelizNode<'FelizBoleroNode> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentCheckbox>
    static member fluentCheckbox (nodes: FunBlazorNode list) = nodes |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentCheckbox>
    static member inline href (x: System.String) = "Href" => x |> BoleroAttr |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline disabled (x: System.Nullable<System.Boolean>) = "Disabled" => x |> BoleroAttr |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline required (x: System.Nullable<System.Boolean>) = "Required" => x |> BoleroAttr |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline children (text: string) = attr.children text |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline additionalAttributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "AdditionalAttributes" => x |> BoleroAttr |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline value (x: System.Boolean) = "Value" => x |> BoleroAttr |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline valueChanged fn = (Bolero.Html.attr.callback<System.Boolean> "ValueChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline valueExpression (x: System.Linq.Expressions.Expression<System.Func<System.Boolean>>) = "ValueExpression" => x |> BoleroAttr |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline displayName (x: System.String) = "DisplayName" => x |> BoleroAttr |> GenericFelizNode<'FelizBoleroNode>.create
        

type fluentCombobox<'FelizBoleroNode> =
    inherit fluentInputBase<'FelizBoleroNode, System.String>
    static member fluentCombobox (nodes: GenericFelizNode<'FelizBoleroNode> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentCombobox>
    static member fluentCombobox (nodes: FunBlazorNode list) = nodes |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentCombobox>
    static member inline filled (x: System.Nullable<System.Boolean>) = "Filled" => x |> BoleroAttr |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline disabled (x: System.Nullable<System.Boolean>) = "Disabled" => x |> BoleroAttr |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline autocomplete (x: System.Nullable<Microsoft.Fast.Components.FluentUI.Autocomplete>) = "Autocomplete" => x |> BoleroAttr |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline position (x: System.Nullable<Microsoft.Fast.Components.FluentUI.Position>) = "Position" => x |> BoleroAttr |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline children (text: string) = attr.children text |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline additionalAttributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "AdditionalAttributes" => x |> BoleroAttr |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline value (x: System.String) = "Value" => x |> BoleroAttr |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline valueChanged fn = (Bolero.Html.attr.callback<System.String> "ValueChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline valueExpression (x: System.Linq.Expressions.Expression<System.Func<System.String>>) = "ValueExpression" => x |> BoleroAttr |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline displayName (x: System.String) = "DisplayName" => x |> BoleroAttr |> GenericFelizNode<'FelizBoleroNode>.create
        

type fluentDialog<'FelizBoleroNode> =
    
    static member fluentDialog (nodes: GenericFelizNode<'FelizBoleroNode> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentDialog>
    static member fluentDialog (nodes: FunBlazorNode list) = nodes |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentDialog>
    static member inline modal (x: System.Nullable<System.Boolean>) = "Modal" => x |> BoleroAttr |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline children (text: string) = attr.children text |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline additionalAttributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "AdditionalAttributes" => x |> BoleroAttr |> GenericFelizNode<'FelizBoleroNode>.create
        

type fluentDivider<'FelizBoleroNode> =
    
    static member fluentDivider (nodes: GenericFelizNode<'FelizBoleroNode> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentDivider>
    static member fluentDivider (nodes: FunBlazorNode list) = nodes |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentDivider>
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline children (text: string) = attr.children text |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline additionalAttributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "AdditionalAttributes" => x |> BoleroAttr |> GenericFelizNode<'FelizBoleroNode>.create
        

type fluentFlipper<'FelizBoleroNode> =
    
    static member fluentFlipper (nodes: GenericFelizNode<'FelizBoleroNode> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentFlipper>
    static member fluentFlipper (nodes: FunBlazorNode list) = nodes |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentFlipper>
    static member inline disabled (x: System.Nullable<System.Boolean>) = "Disabled" => x |> BoleroAttr |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline direction (x: System.Nullable<Microsoft.Fast.Components.FluentUI.Direction>) = "Direction" => x |> BoleroAttr |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline children (text: string) = attr.children text |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline additionalAttributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "AdditionalAttributes" => x |> BoleroAttr |> GenericFelizNode<'FelizBoleroNode>.create
        

type fluentListbox<'FelizBoleroNode> =
    
    static member fluentListbox (nodes: GenericFelizNode<'FelizBoleroNode> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentListbox>
    static member fluentListbox (nodes: FunBlazorNode list) = nodes |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentListbox>
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline children (text: string) = attr.children text |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline additionalAttributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "AdditionalAttributes" => x |> BoleroAttr |> GenericFelizNode<'FelizBoleroNode>.create
        

type fluentMenu<'FelizBoleroNode> =
    
    static member fluentMenu (nodes: GenericFelizNode<'FelizBoleroNode> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentMenu>
    static member fluentMenu (nodes: FunBlazorNode list) = nodes |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentMenu>
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline children (text: string) = attr.children text |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline additionalAttributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "AdditionalAttributes" => x |> BoleroAttr |> GenericFelizNode<'FelizBoleroNode>.create
        

type fluentMenuItem<'FelizBoleroNode> =
    
    static member fluentMenuItem (nodes: GenericFelizNode<'FelizBoleroNode> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentMenuItem>
    static member fluentMenuItem (nodes: FunBlazorNode list) = nodes |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentMenuItem>
    static member inline disabled (x: System.Nullable<System.Boolean>) = "Disabled" => x |> BoleroAttr |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline ``checked`` (x: System.Nullable<System.Boolean>) = "Checked" => x |> BoleroAttr |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline children (text: string) = attr.children text |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline additionalAttributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "AdditionalAttributes" => x |> BoleroAttr |> GenericFelizNode<'FelizBoleroNode>.create
        

type fluentOption<'FelizBoleroNode> =
    
    static member fluentOption (nodes: GenericFelizNode<'FelizBoleroNode> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentOption>
    static member fluentOption (nodes: FunBlazorNode list) = nodes |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentOption>
    static member inline disabled (x: System.Nullable<System.Boolean>) = "Disabled" => x |> BoleroAttr |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline value (x: System.String) = "Value" => x |> BoleroAttr |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline selected (x: System.Nullable<System.Boolean>) = "Selected" => x |> BoleroAttr |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline additionalAttributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "AdditionalAttributes" => x |> BoleroAttr |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline children (text: string) = attr.children text |> GenericFelizNode<'FelizBoleroNode>.create
        

type fluentProgress<'FelizBoleroNode> =
    
    static member fluentProgress (nodes: GenericFelizNode<'FelizBoleroNode> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentProgress>
    static member fluentProgress (nodes: FunBlazorNode list) = nodes |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentProgress>
    static member inline min (x: System.Nullable<System.Int32>) = "Min" => x |> BoleroAttr |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline max (x: System.Nullable<System.Int32>) = "Max" => x |> BoleroAttr |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline value (x: System.String) = "Value" => x |> BoleroAttr |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline paused (x: System.Nullable<System.Boolean>) = "Paused" => x |> BoleroAttr |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline children (text: string) = attr.children text |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline additionalAttributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "AdditionalAttributes" => x |> BoleroAttr |> GenericFelizNode<'FelizBoleroNode>.create
        

type fluentProgressRing<'FelizBoleroNode> =
    
    static member fluentProgressRing (nodes: GenericFelizNode<'FelizBoleroNode> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentProgressRing>
    static member fluentProgressRing (nodes: FunBlazorNode list) = nodes |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentProgressRing>
    static member inline min (x: System.Nullable<System.Int32>) = "Min" => x |> BoleroAttr |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline max (x: System.Nullable<System.Int32>) = "Max" => x |> BoleroAttr |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline value (x: System.String) = "Value" => x |> BoleroAttr |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline paused (x: System.Nullable<System.Boolean>) = "Paused" => x |> BoleroAttr |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline children (text: string) = attr.children text |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline additionalAttributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "AdditionalAttributes" => x |> BoleroAttr |> GenericFelizNode<'FelizBoleroNode>.create
        

type fluentRadio<'FelizBoleroNode> =
    
    static member fluentRadio (nodes: GenericFelizNode<'FelizBoleroNode> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentRadio>
    static member fluentRadio (nodes: FunBlazorNode list) = nodes |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentRadio>
    static member inline value (x: System.String) = "Value" => x |> BoleroAttr |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline required (x: System.Nullable<System.Boolean>) = "Required" => x |> BoleroAttr |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline disabled (x: System.Nullable<System.Boolean>) = "Disabled" => x |> BoleroAttr |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline ``checked`` (x: System.Nullable<System.Boolean>) = "Checked" => x |> BoleroAttr |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline children (text: string) = attr.children text |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline additionalAttributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "AdditionalAttributes" => x |> BoleroAttr |> GenericFelizNode<'FelizBoleroNode>.create
        

type fluentRadioGroup<'FelizBoleroNode> =
    inherit fluentInputBase<'FelizBoleroNode, System.String>
    static member fluentRadioGroup (nodes: GenericFelizNode<'FelizBoleroNode> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentRadioGroup>
    static member fluentRadioGroup (nodes: FunBlazorNode list) = nodes |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentRadioGroup>
    static member inline name (x: System.String) = "Name" => x |> BoleroAttr |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline required (x: System.Nullable<System.Boolean>) = "Required" => x |> BoleroAttr |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline orientation (x: System.Nullable<Microsoft.Fast.Components.FluentUI.Orientation>) = "Orientation" => x |> BoleroAttr |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline children (text: string) = attr.children text |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline additionalAttributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "AdditionalAttributes" => x |> BoleroAttr |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline value (x: System.String) = "Value" => x |> BoleroAttr |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline valueChanged fn = (Bolero.Html.attr.callback<System.String> "ValueChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline valueExpression (x: System.Linq.Expressions.Expression<System.Func<System.String>>) = "ValueExpression" => x |> BoleroAttr |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline displayName (x: System.String) = "DisplayName" => x |> BoleroAttr |> GenericFelizNode<'FelizBoleroNode>.create
        

type fluentSelect<'FelizBoleroNode> =
    inherit fluentInputBase<'FelizBoleroNode, System.String>
    static member fluentSelect (nodes: GenericFelizNode<'FelizBoleroNode> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentSelect>
    static member fluentSelect (nodes: FunBlazorNode list) = nodes |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentSelect>
    static member inline disabled (x: System.Nullable<System.Boolean>) = "Disabled" => x |> BoleroAttr |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline filled (x: System.Nullable<System.Boolean>) = "Filled" => x |> BoleroAttr |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline name (x: System.String) = "Name" => x |> BoleroAttr |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline position (x: System.Nullable<Microsoft.Fast.Components.FluentUI.Position>) = "Position" => x |> BoleroAttr |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline children (text: string) = attr.children text |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline additionalAttributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "AdditionalAttributes" => x |> BoleroAttr |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline value (x: System.String) = "Value" => x |> BoleroAttr |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline valueChanged fn = (Bolero.Html.attr.callback<System.String> "ValueChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline valueExpression (x: System.Linq.Expressions.Expression<System.Func<System.String>>) = "ValueExpression" => x |> BoleroAttr |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline displayName (x: System.String) = "DisplayName" => x |> BoleroAttr |> GenericFelizNode<'FelizBoleroNode>.create
        

type fluentSkeleton<'FelizBoleroNode> =
    
    static member fluentSkeleton (nodes: GenericFelizNode<'FelizBoleroNode> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentSkeleton>
    static member fluentSkeleton (nodes: FunBlazorNode list) = nodes |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentSkeleton>
    static member inline shape (x: System.Nullable<Microsoft.Fast.Components.FluentUI.Shape>) = "Shape" => x |> BoleroAttr |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline shimmer (x: System.Nullable<System.Boolean>) = "Shimmer" => x |> BoleroAttr |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline pattern (x: System.String) = "Pattern" => x |> BoleroAttr |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline children (text: string) = attr.children text |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline additionalAttributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "AdditionalAttributes" => x |> BoleroAttr |> GenericFelizNode<'FelizBoleroNode>.create
        

type fluentSlider<'FelizBoleroNode> =
    inherit fluentInputBase<'FelizBoleroNode, System.Int32>
    static member fluentSlider (nodes: GenericFelizNode<'FelizBoleroNode> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentSlider>
    static member fluentSlider (nodes: FunBlazorNode list) = nodes |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentSlider>
    static member inline orientation (x: System.Nullable<Microsoft.Fast.Components.FluentUI.Orientation>) = "Orientation" => x |> BoleroAttr |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline min (x: System.Nullable<System.Int32>) = "Min" => x |> BoleroAttr |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline max (x: System.Nullable<System.Int32>) = "Max" => x |> BoleroAttr |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline step (x: System.Nullable<System.Int32>) = "Step" => x |> BoleroAttr |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline disabled (x: System.Nullable<System.Boolean>) = "Disabled" => x |> BoleroAttr |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline readonly (x: System.Nullable<System.Boolean>) = "Readonly" => x |> BoleroAttr |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline children (text: string) = attr.children text |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline additionalAttributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "AdditionalAttributes" => x |> BoleroAttr |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline value (x: System.Int32) = "Value" => x |> BoleroAttr |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline valueChanged fn = (Bolero.Html.attr.callback<System.Int32> "ValueChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline valueExpression (x: System.Linq.Expressions.Expression<System.Func<System.Int32>>) = "ValueExpression" => x |> BoleroAttr |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline displayName (x: System.String) = "DisplayName" => x |> BoleroAttr |> GenericFelizNode<'FelizBoleroNode>.create
        

type fluentSliderLabel<'FelizBoleroNode> =
    
    static member fluentSliderLabel (nodes: GenericFelizNode<'FelizBoleroNode> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentSliderLabel>
    static member fluentSliderLabel (nodes: FunBlazorNode list) = nodes |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentSliderLabel>
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline children (text: string) = attr.children text |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline position (x: System.Nullable<System.Int32>) = "Position" => x |> BoleroAttr |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline hideMark (x: System.Nullable<System.Boolean>) = "HideMark" => x |> BoleroAttr |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline additionalAttributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "AdditionalAttributes" => x |> BoleroAttr |> GenericFelizNode<'FelizBoleroNode>.create
        

type fluentSwitch<'FelizBoleroNode> =
    
    static member fluentSwitch (nodes: GenericFelizNode<'FelizBoleroNode> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentSwitch>
    static member fluentSwitch (nodes: FunBlazorNode list) = nodes |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentSwitch>
    static member inline disabled (x: System.Nullable<System.Boolean>) = "Disabled" => x |> BoleroAttr |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline ``checked`` (x: System.Nullable<System.Boolean>) = "Checked" => x |> BoleroAttr |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline required (x: System.Nullable<System.Boolean>) = "Required" => x |> BoleroAttr |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline children (text: string) = attr.children text |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline additionalAttributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "AdditionalAttributes" => x |> BoleroAttr |> GenericFelizNode<'FelizBoleroNode>.create
        

type fluentTab<'FelizBoleroNode> =
    
    static member fluentTab (nodes: GenericFelizNode<'FelizBoleroNode> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentTab>
    static member fluentTab (nodes: FunBlazorNode list) = nodes |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentTab>
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline children (text: string) = attr.children text |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline additionalAttributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "AdditionalAttributes" => x |> BoleroAttr |> GenericFelizNode<'FelizBoleroNode>.create
        

type fluentTabPanel<'FelizBoleroNode> =
    
    static member fluentTabPanel (nodes: GenericFelizNode<'FelizBoleroNode> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentTabPanel>
    static member fluentTabPanel (nodes: FunBlazorNode list) = nodes |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentTabPanel>
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline children (text: string) = attr.children text |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline additionalAttributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "AdditionalAttributes" => x |> BoleroAttr |> GenericFelizNode<'FelizBoleroNode>.create
        

type fluentTabs<'FelizBoleroNode> =
    
    static member fluentTabs (nodes: GenericFelizNode<'FelizBoleroNode> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentTabs>
    static member fluentTabs (nodes: FunBlazorNode list) = nodes |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentTabs>
    static member inline activeIndicator (x: System.Nullable<System.Boolean>) = "ActiveIndicator" => x |> BoleroAttr |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline orientation (x: System.Nullable<Microsoft.Fast.Components.FluentUI.Orientation>) = "Orientation" => x |> BoleroAttr |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline children (text: string) = attr.children text |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline additionalAttributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "AdditionalAttributes" => x |> BoleroAttr |> GenericFelizNode<'FelizBoleroNode>.create
        

type fluentTextArea<'FelizBoleroNode> =
    inherit fluentInputBase<'FelizBoleroNode, System.String>
    static member fluentTextArea (nodes: GenericFelizNode<'FelizBoleroNode> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentTextArea>
    static member fluentTextArea (nodes: FunBlazorNode list) = nodes |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentTextArea>
    static member inline disabled (x: System.Nullable<System.Boolean>) = "Disabled" => x |> BoleroAttr |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline readonly (x: System.Nullable<System.Boolean>) = "Readonly" => x |> BoleroAttr |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline required (x: System.Nullable<System.Boolean>) = "Required" => x |> BoleroAttr |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline autofocus (x: System.Nullable<System.Boolean>) = "Autofocus" => x |> BoleroAttr |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline resize (x: System.Nullable<Microsoft.Fast.Components.FluentUI.Resize>) = "Resize" => x |> BoleroAttr |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline appearance (x: System.Nullable<Microsoft.Fast.Components.FluentUI.Appearance>) = "Appearance" => x |> BoleroAttr |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline placeholder (x: System.String) = "Placeholder" => x |> BoleroAttr |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline children (text: string) = attr.children text |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline additionalAttributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "AdditionalAttributes" => x |> BoleroAttr |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline value (x: System.String) = "Value" => x |> BoleroAttr |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline valueChanged fn = (Bolero.Html.attr.callback<System.String> "ValueChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline valueExpression (x: System.Linq.Expressions.Expression<System.Func<System.String>>) = "ValueExpression" => x |> BoleroAttr |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline displayName (x: System.String) = "DisplayName" => x |> BoleroAttr |> GenericFelizNode<'FelizBoleroNode>.create
        

type fluentTextField<'FelizBoleroNode> =
    inherit fluentInputBase<'FelizBoleroNode, System.String>
    static member fluentTextField (nodes: GenericFelizNode<'FelizBoleroNode> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentTextField>
    static member fluentTextField (nodes: FunBlazorNode list) = nodes |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentTextField>
    static member inline disabled (x: System.Nullable<System.Boolean>) = "Disabled" => x |> BoleroAttr |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline readonly (x: System.Nullable<System.Boolean>) = "Readonly" => x |> BoleroAttr |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline required (x: System.Nullable<System.Boolean>) = "Required" => x |> BoleroAttr |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline autofocus (x: System.Nullable<System.Boolean>) = "Autofocus" => x |> BoleroAttr |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline resize (x: System.Nullable<Microsoft.Fast.Components.FluentUI.Resize>) = "Resize" => x |> BoleroAttr |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline appearance (x: System.Nullable<Microsoft.Fast.Components.FluentUI.Appearance>) = "Appearance" => x |> BoleroAttr |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline placeholder (x: System.String) = "Placeholder" => x |> BoleroAttr |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline children (text: string) = attr.children text |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline additionalAttributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "AdditionalAttributes" => x |> BoleroAttr |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline value (x: System.String) = "Value" => x |> BoleroAttr |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline valueChanged fn = (Bolero.Html.attr.callback<System.String> "ValueChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline valueExpression (x: System.Linq.Expressions.Expression<System.Func<System.String>>) = "ValueExpression" => x |> BoleroAttr |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline displayName (x: System.String) = "DisplayName" => x |> BoleroAttr |> GenericFelizNode<'FelizBoleroNode>.create
        

type fluentTreeItem<'FelizBoleroNode> =
    
    static member fluentTreeItem (nodes: GenericFelizNode<'FelizBoleroNode> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentTreeItem>
    static member fluentTreeItem (nodes: FunBlazorNode list) = nodes |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentTreeItem>
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline children (text: string) = attr.children text |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline disabled (x: System.Nullable<System.Boolean>) = "Disabled" => x |> BoleroAttr |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline selected (x: System.Nullable<System.Boolean>) = "Selected" => x |> BoleroAttr |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline expanded (x: System.Nullable<System.Boolean>) = "Expanded" => x |> BoleroAttr |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline additionalAttributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "AdditionalAttributes" => x |> BoleroAttr |> GenericFelizNode<'FelizBoleroNode>.create
        

type fluentTreeView<'FelizBoleroNode> =
    
    static member fluentTreeView (nodes: GenericFelizNode<'FelizBoleroNode> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentTreeView>
    static member fluentTreeView (nodes: FunBlazorNode list) = nodes |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentTreeView>
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline children (text: string) = attr.children text |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline renderCollapsedNodes (x: System.Nullable<System.Boolean>) = "RenderCollapsedNodes" => x |> BoleroAttr |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline additionalAttributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "AdditionalAttributes" => x |> BoleroAttr |> GenericFelizNode<'FelizBoleroNode>.create
        


namespace rec Fun.Blazor.FluentUI


type INavLinkFluentAnchorNode = interface end

type navLinkFluentAnchor =
    class
        inherit Internal.navLinkFluentAnchor<INavLinkFluentAnchorNode>
    end

type IFluentDesignSystemProviderNode = interface end

type fluentDesignSystemProvider =
    class
        inherit Internal.fluentDesignSystemProvider<IFluentDesignSystemProviderNode>
    end

type IFluentInputBaseNode<'TValue> = interface end

type fluentInputBase<'TValue> =
    class
        inherit Internal.fluentInputBase<IFluentInputBaseNode<'TValue>, 'TValue>
    end

type IFluentAccordionNode = interface end

type fluentAccordion =
    class
        inherit Internal.fluentAccordion<IFluentAccordionNode>
    end

type IFluentAccordionItemNode = interface end

type fluentAccordionItem =
    class
        inherit Internal.fluentAccordionItem<IFluentAccordionItemNode>
    end

type IFluentAnchorNode = interface end

type fluentAnchor =
    class
        inherit Internal.fluentAnchor<IFluentAnchorNode>
    end

type IFluentBadgeNode = interface end

type fluentBadge =
    class
        inherit Internal.fluentBadge<IFluentBadgeNode>
    end

type IFluentBreadcrumbNode = interface end

type fluentBreadcrumb =
    class
        inherit Internal.fluentBreadcrumb<IFluentBreadcrumbNode>
    end

type IFluentBreadcrumbItemNode = interface end

type fluentBreadcrumbItem =
    class
        inherit Internal.fluentBreadcrumbItem<IFluentBreadcrumbItemNode>
    end

type IFluentButtonNode = interface end

type fluentButton =
    class
        inherit Internal.fluentButton<IFluentButtonNode>
    end

type IFluentCardNode = interface end

type fluentCard =
    class
        inherit Internal.fluentCard<IFluentCardNode>
    end

type IFluentCheckboxNode = interface end

type fluentCheckbox =
    class
        inherit Internal.fluentCheckbox<IFluentCheckboxNode>
    end

type IFluentComboboxNode = interface end

type fluentCombobox =
    class
        inherit Internal.fluentCombobox<IFluentComboboxNode>
    end

type IFluentDialogNode = interface end

type fluentDialog =
    class
        inherit Internal.fluentDialog<IFluentDialogNode>
    end

type IFluentDividerNode = interface end

type fluentDivider =
    class
        inherit Internal.fluentDivider<IFluentDividerNode>
    end

type IFluentFlipperNode = interface end

type fluentFlipper =
    class
        inherit Internal.fluentFlipper<IFluentFlipperNode>
    end

type IFluentListboxNode = interface end

type fluentListbox =
    class
        inherit Internal.fluentListbox<IFluentListboxNode>
    end

type IFluentMenuNode = interface end

type fluentMenu =
    class
        inherit Internal.fluentMenu<IFluentMenuNode>
    end

type IFluentMenuItemNode = interface end

type fluentMenuItem =
    class
        inherit Internal.fluentMenuItem<IFluentMenuItemNode>
    end

type IFluentOptionNode = interface end

type fluentOption =
    class
        inherit Internal.fluentOption<IFluentOptionNode>
    end

type IFluentProgressNode = interface end

type fluentProgress =
    class
        inherit Internal.fluentProgress<IFluentProgressNode>
    end

type IFluentProgressRingNode = interface end

type fluentProgressRing =
    class
        inherit Internal.fluentProgressRing<IFluentProgressRingNode>
    end

type IFluentRadioNode = interface end

type fluentRadio =
    class
        inherit Internal.fluentRadio<IFluentRadioNode>
    end

type IFluentRadioGroupNode = interface end

type fluentRadioGroup =
    class
        inherit Internal.fluentRadioGroup<IFluentRadioGroupNode>
    end

type IFluentSelectNode = interface end

type fluentSelect =
    class
        inherit Internal.fluentSelect<IFluentSelectNode>
    end

type IFluentSkeletonNode = interface end

type fluentSkeleton =
    class
        inherit Internal.fluentSkeleton<IFluentSkeletonNode>
    end

type IFluentSliderNode = interface end

type fluentSlider =
    class
        inherit Internal.fluentSlider<IFluentSliderNode>
    end

type IFluentSliderLabelNode = interface end

type fluentSliderLabel =
    class
        inherit Internal.fluentSliderLabel<IFluentSliderLabelNode>
    end

type IFluentSwitchNode = interface end

type fluentSwitch =
    class
        inherit Internal.fluentSwitch<IFluentSwitchNode>
    end

type IFluentTabNode = interface end

type fluentTab =
    class
        inherit Internal.fluentTab<IFluentTabNode>
    end

type IFluentTabPanelNode = interface end

type fluentTabPanel =
    class
        inherit Internal.fluentTabPanel<IFluentTabPanelNode>
    end

type IFluentTabsNode = interface end

type fluentTabs =
    class
        inherit Internal.fluentTabs<IFluentTabsNode>
    end

type IFluentTextAreaNode = interface end

type fluentTextArea =
    class
        inherit Internal.fluentTextArea<IFluentTextAreaNode>
    end

type IFluentTextFieldNode = interface end

type fluentTextField =
    class
        inherit Internal.fluentTextField<IFluentTextFieldNode>
    end

type IFluentTreeItemNode = interface end

type fluentTreeItem =
    class
        inherit Internal.fluentTreeItem<IFluentTreeItemNode>
    end

type IFluentTreeViewNode = interface end

type fluentTreeView =
    class
        inherit Internal.fluentTreeView<IFluentTreeViewNode>
    end