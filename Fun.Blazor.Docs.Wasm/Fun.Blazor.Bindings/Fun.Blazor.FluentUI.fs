namespace rec Fun.Blazor.FluentUI.DslInternals

open Bolero.Html
open Fun.Blazor
open Fun.Blazor.Web.DslInternals
open Fun.Blazor.FluentUI.DslInternals


type fluentDesignSystemProvider<'FunBlazorGeneric> =
    
    static member create () = [] |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentDesignSystemProvider>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentDesignSystemProvider>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentDesignSystemProvider>
    static member create (node: FunBlazorNode) = [ node ] |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentDesignSystemProvider>
    static member inline childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline additionalAttributes (x: System.Collections.Generic.IReadOnlyDictionary<System.String, System.Object>) = "AdditionalAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type fluentInputBase<'FunBlazorGeneric, 'TValue> =
    
    static member create () = [] |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentInputBase<'TValue>>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentInputBase<'TValue>>

    static member inline additionalAttributes (x: System.Collections.Generic.IReadOnlyDictionary<System.String, System.Object>) = "AdditionalAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline value (x: 'TValue) = "Value" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valueChanged fn = (Bolero.Html.attr.callback<'TValue> "ValueChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valueExpression (x: System.Linq.Expressions.Expression<System.Func<'TValue>>) = "ValueExpression" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline displayName (x: System.String) = "DisplayName" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type fluentCheckbox<'FunBlazorGeneric> =
    inherit fluentInputBase<'FunBlazorGeneric, System.Boolean>
    static member create () = [] |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentCheckbox>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentCheckbox>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentCheckbox>
    static member create (node: FunBlazorNode) = [ node ] |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentCheckbox>
    static member inline href (x: System.String) = "Href" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabled (x: System.Nullable<System.Boolean>) = "Disabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline required (x: System.Nullable<System.Boolean>) = "Required" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline additionalAttributes (x: System.Collections.Generic.IReadOnlyDictionary<System.String, System.Object>) = "AdditionalAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline value (x: System.Boolean) = "Value" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valueChanged fn = (Bolero.Html.attr.callback<System.Boolean> "ValueChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valueExpression (x: System.Linq.Expressions.Expression<System.Func<System.Boolean>>) = "ValueExpression" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline displayName (x: System.String) = "DisplayName" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type fluentCombobox<'FunBlazorGeneric> =
    inherit fluentInputBase<'FunBlazorGeneric, System.String>
    static member create () = [] |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentCombobox>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentCombobox>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentCombobox>
    static member create (node: FunBlazorNode) = [ node ] |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentCombobox>
    static member inline filled (x: System.Nullable<System.Boolean>) = "Filled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabled (x: System.Nullable<System.Boolean>) = "Disabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline autocomplete (x: System.Nullable<Microsoft.Fast.Components.FluentUI.Autocomplete>) = "Autocomplete" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline position (x: System.Nullable<Microsoft.Fast.Components.FluentUI.Position>) = "Position" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline additionalAttributes (x: System.Collections.Generic.IReadOnlyDictionary<System.String, System.Object>) = "AdditionalAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline value (x: System.String) = "Value" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valueChanged fn = (Bolero.Html.attr.callback<System.String> "ValueChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valueExpression (x: System.Linq.Expressions.Expression<System.Func<System.String>>) = "ValueExpression" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline displayName (x: System.String) = "DisplayName" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type fluentRadioGroup<'FunBlazorGeneric> =
    inherit fluentInputBase<'FunBlazorGeneric, System.String>
    static member create () = [] |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentRadioGroup>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentRadioGroup>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentRadioGroup>
    static member create (node: FunBlazorNode) = [ node ] |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentRadioGroup>
    static member inline name (x: System.String) = "Name" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline required (x: System.Nullable<System.Boolean>) = "Required" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline orientation (x: System.Nullable<Microsoft.Fast.Components.FluentUI.Orientation>) = "Orientation" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline additionalAttributes (x: System.Collections.Generic.IReadOnlyDictionary<System.String, System.Object>) = "AdditionalAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline value (x: System.String) = "Value" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valueChanged fn = (Bolero.Html.attr.callback<System.String> "ValueChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valueExpression (x: System.Linq.Expressions.Expression<System.Func<System.String>>) = "ValueExpression" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline displayName (x: System.String) = "DisplayName" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type fluentSelect<'FunBlazorGeneric> =
    inherit fluentInputBase<'FunBlazorGeneric, System.String>
    static member create () = [] |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentSelect>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentSelect>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentSelect>
    static member create (node: FunBlazorNode) = [ node ] |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentSelect>
    static member inline disabled (x: System.Nullable<System.Boolean>) = "Disabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline filled (x: System.Nullable<System.Boolean>) = "Filled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline name (x: System.String) = "Name" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline position (x: System.Nullable<Microsoft.Fast.Components.FluentUI.Position>) = "Position" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline additionalAttributes (x: System.Collections.Generic.IReadOnlyDictionary<System.String, System.Object>) = "AdditionalAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline value (x: System.String) = "Value" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valueChanged fn = (Bolero.Html.attr.callback<System.String> "ValueChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valueExpression (x: System.Linq.Expressions.Expression<System.Func<System.String>>) = "ValueExpression" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline displayName (x: System.String) = "DisplayName" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type fluentSlider<'FunBlazorGeneric> =
    inherit fluentInputBase<'FunBlazorGeneric, System.Int32>
    static member create () = [] |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentSlider>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentSlider>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentSlider>
    static member create (node: FunBlazorNode) = [ node ] |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentSlider>
    static member inline orientation (x: System.Nullable<Microsoft.Fast.Components.FluentUI.Orientation>) = "Orientation" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline min (x: System.Nullable<System.Int32>) = "Min" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline max (x: System.Nullable<System.Int32>) = "Max" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline step (x: System.Nullable<System.Int32>) = "Step" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabled (x: System.Nullable<System.Boolean>) = "Disabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline readonly (x: System.Nullable<System.Boolean>) = "Readonly" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline additionalAttributes (x: System.Collections.Generic.IReadOnlyDictionary<System.String, System.Object>) = "AdditionalAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline value (x: System.Int32) = "Value" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valueChanged fn = (Bolero.Html.attr.callback<System.Int32> "ValueChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valueExpression (x: System.Linq.Expressions.Expression<System.Func<System.Int32>>) = "ValueExpression" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline displayName (x: System.String) = "DisplayName" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type fluentTextArea<'FunBlazorGeneric> =
    inherit fluentInputBase<'FunBlazorGeneric, System.String>
    static member create () = [] |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentTextArea>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentTextArea>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentTextArea>
    static member create (node: FunBlazorNode) = [ node ] |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentTextArea>
    static member inline disabled (x: System.Nullable<System.Boolean>) = "Disabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline readonly (x: System.Nullable<System.Boolean>) = "Readonly" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline required (x: System.Nullable<System.Boolean>) = "Required" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline autofocus (x: System.Nullable<System.Boolean>) = "Autofocus" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline resize (x: System.Nullable<Microsoft.Fast.Components.FluentUI.Resize>) = "Resize" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline appearance (x: System.Nullable<Microsoft.Fast.Components.FluentUI.Appearance>) = "Appearance" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline placeholder (x: System.String) = "Placeholder" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline additionalAttributes (x: System.Collections.Generic.IReadOnlyDictionary<System.String, System.Object>) = "AdditionalAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline value (x: System.String) = "Value" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valueChanged fn = (Bolero.Html.attr.callback<System.String> "ValueChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valueExpression (x: System.Linq.Expressions.Expression<System.Func<System.String>>) = "ValueExpression" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline displayName (x: System.String) = "DisplayName" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type fluentTextField<'FunBlazorGeneric> =
    inherit fluentInputBase<'FunBlazorGeneric, System.String>
    static member create () = [] |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentTextField>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentTextField>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentTextField>
    static member create (node: FunBlazorNode) = [ node ] |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentTextField>
    static member inline disabled (x: System.Nullable<System.Boolean>) = "Disabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline readonly (x: System.Nullable<System.Boolean>) = "Readonly" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline required (x: System.Nullable<System.Boolean>) = "Required" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline autofocus (x: System.Nullable<System.Boolean>) = "Autofocus" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline resize (x: System.Nullable<Microsoft.Fast.Components.FluentUI.Resize>) = "Resize" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline appearance (x: System.Nullable<Microsoft.Fast.Components.FluentUI.Appearance>) = "Appearance" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline placeholder (x: System.String) = "Placeholder" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline additionalAttributes (x: System.Collections.Generic.IReadOnlyDictionary<System.String, System.Object>) = "AdditionalAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline value (x: System.String) = "Value" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valueChanged fn = (Bolero.Html.attr.callback<System.String> "ValueChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valueExpression (x: System.Linq.Expressions.Expression<System.Func<System.String>>) = "ValueExpression" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline displayName (x: System.String) = "DisplayName" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type fluentAccordion<'FunBlazorGeneric> =
    
    static member create () = [] |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentAccordion>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentAccordion>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentAccordion>
    static member create (node: FunBlazorNode) = [ node ] |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentAccordion>
    static member inline childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline expandMode (x: System.Nullable<Microsoft.Fast.Components.FluentUI.ExpandMode>) = "ExpandMode" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline additionalAttributes (x: System.Collections.Generic.IDictionary<System.String, System.Object>) = "AdditionalAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type fluentAccordionItem<'FunBlazorGeneric> =
    
    static member create () = [] |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentAccordionItem>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentAccordionItem>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentAccordionItem>
    static member create (node: FunBlazorNode) = [ node ] |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentAccordionItem>
    static member inline childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline expanded (x: System.Nullable<System.Boolean>) = "Expanded" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline additionalAttributes (x: System.Collections.Generic.IDictionary<System.String, System.Object>) = "AdditionalAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type fluentAnchor<'FunBlazorGeneric> =
    
    static member create () = [] |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentAnchor>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentAnchor>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentAnchor>
    static member create (node: FunBlazorNode) = [ node ] |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentAnchor>
    static member inline href (x: System.String) = "Href" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline appearance (x: System.Nullable<Microsoft.Fast.Components.FluentUI.Appearance>) = "Appearance" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline additionalAttributes (x: System.Collections.Generic.IDictionary<System.String, System.Object>) = "AdditionalAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type fluentBadge<'FunBlazorGeneric> =
    
    static member create () = [] |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentBadge>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentBadge>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentBadge>
    static member create (node: FunBlazorNode) = [ node ] |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentBadge>
    static member inline color (x: System.Nullable<Microsoft.Fast.Components.FluentUI.Color>) = "Color" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline fill (x: System.Nullable<Microsoft.Fast.Components.FluentUI.Fill>) = "Fill" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline appearance (x: System.Nullable<Microsoft.Fast.Components.FluentUI.Appearance>) = "Appearance" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline additionalAttributes (x: System.Collections.Generic.IDictionary<System.String, System.Object>) = "AdditionalAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type fluentBreadcrumb<'FunBlazorGeneric> =
    
    static member create () = [] |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentBreadcrumb>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentBreadcrumb>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentBreadcrumb>
    static member create (node: FunBlazorNode) = [ node ] |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentBreadcrumb>
    static member inline childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline additionalAttributes (x: System.Collections.Generic.IDictionary<System.String, System.Object>) = "AdditionalAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type fluentBreadcrumbItem<'FunBlazorGeneric> =
    
    static member create () = [] |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentBreadcrumbItem>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentBreadcrumbItem>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentBreadcrumbItem>
    static member create (node: FunBlazorNode) = [ node ] |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentBreadcrumbItem>
    static member inline href (x: System.String) = "Href" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline additionalAttributes (x: System.Collections.Generic.IDictionary<System.String, System.Object>) = "AdditionalAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type fluentButton<'FunBlazorGeneric> =
    
    static member create () = [] |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentButton>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentButton>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentButton>
    static member create (node: FunBlazorNode) = [ node ] |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentButton>
    static member inline appearance (x: System.Nullable<Microsoft.Fast.Components.FluentUI.Appearance>) = "Appearance" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabled (x: System.Nullable<System.Boolean>) = "Disabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline autofocus (x: System.Nullable<System.Boolean>) = "Autofocus" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline additionalAttributes (x: System.Collections.Generic.IDictionary<System.String, System.Object>) = "AdditionalAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type fluentCard<'FunBlazorGeneric> =
    
    static member create () = [] |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentCard>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentCard>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentCard>
    static member create (node: FunBlazorNode) = [ node ] |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentCard>
    static member inline childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline additionalAttributes (x: System.Collections.Generic.IDictionary<System.String, System.Object>) = "AdditionalAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type fluentDialog<'FunBlazorGeneric> =
    
    static member create () = [] |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentDialog>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentDialog>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentDialog>
    static member create (node: FunBlazorNode) = [ node ] |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentDialog>
    static member inline modal (x: System.Nullable<System.Boolean>) = "Modal" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline additionalAttributes (x: System.Collections.Generic.IDictionary<System.String, System.Object>) = "AdditionalAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type fluentDivider<'FunBlazorGeneric> =
    
    static member create () = [] |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentDivider>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentDivider>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentDivider>
    static member create (node: FunBlazorNode) = [ node ] |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentDivider>
    static member inline childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline additionalAttributes (x: System.Collections.Generic.IDictionary<System.String, System.Object>) = "AdditionalAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type fluentFlipper<'FunBlazorGeneric> =
    
    static member create () = [] |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentFlipper>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentFlipper>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentFlipper>
    static member create (node: FunBlazorNode) = [ node ] |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentFlipper>
    static member inline disabled (x: System.Nullable<System.Boolean>) = "Disabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline direction (x: System.Nullable<Microsoft.Fast.Components.FluentUI.Direction>) = "Direction" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline additionalAttributes (x: System.Collections.Generic.IDictionary<System.String, System.Object>) = "AdditionalAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type fluentListbox<'FunBlazorGeneric> =
    
    static member create () = [] |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentListbox>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentListbox>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentListbox>
    static member create (node: FunBlazorNode) = [ node ] |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentListbox>
    static member inline childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline additionalAttributes (x: System.Collections.Generic.IDictionary<System.String, System.Object>) = "AdditionalAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type fluentMenu<'FunBlazorGeneric> =
    
    static member create () = [] |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentMenu>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentMenu>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentMenu>
    static member create (node: FunBlazorNode) = [ node ] |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentMenu>
    static member inline childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline additionalAttributes (x: System.Collections.Generic.IDictionary<System.String, System.Object>) = "AdditionalAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type fluentMenuItem<'FunBlazorGeneric> =
    
    static member create () = [] |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentMenuItem>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentMenuItem>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentMenuItem>
    static member create (node: FunBlazorNode) = [ node ] |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentMenuItem>
    static member inline disabled (x: System.Nullable<System.Boolean>) = "Disabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline checked' (x: System.Nullable<System.Boolean>) = "Checked" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline additionalAttributes (x: System.Collections.Generic.IDictionary<System.String, System.Object>) = "AdditionalAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type fluentOption<'FunBlazorGeneric> =
    
    static member create () = [] |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentOption>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentOption>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentOption>
    static member create (node: FunBlazorNode) = [ node ] |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentOption>
    static member inline disabled (x: System.Nullable<System.Boolean>) = "Disabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline value (x: System.String) = "Value" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline selected (x: System.Nullable<System.Boolean>) = "Selected" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline additionalAttributes (x: System.Collections.Generic.IDictionary<System.String, System.Object>) = "AdditionalAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type fluentProgress<'FunBlazorGeneric> =
    
    static member create () = [] |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentProgress>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentProgress>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentProgress>
    static member create (node: FunBlazorNode) = [ node ] |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentProgress>
    static member inline min (x: System.Nullable<System.Int32>) = "Min" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline max (x: System.Nullable<System.Int32>) = "Max" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline value (x: System.String) = "Value" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline paused (x: System.Nullable<System.Boolean>) = "Paused" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline additionalAttributes (x: System.Collections.Generic.IDictionary<System.String, System.Object>) = "AdditionalAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type fluentProgressRing<'FunBlazorGeneric> =
    
    static member create () = [] |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentProgressRing>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentProgressRing>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentProgressRing>
    static member create (node: FunBlazorNode) = [ node ] |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentProgressRing>
    static member inline min (x: System.Nullable<System.Int32>) = "Min" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline max (x: System.Nullable<System.Int32>) = "Max" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline value (x: System.String) = "Value" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline paused (x: System.Nullable<System.Boolean>) = "Paused" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline additionalAttributes (x: System.Collections.Generic.IDictionary<System.String, System.Object>) = "AdditionalAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type fluentRadio<'FunBlazorGeneric> =
    
    static member create () = [] |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentRadio>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentRadio>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentRadio>
    static member create (node: FunBlazorNode) = [ node ] |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentRadio>
    static member inline value (x: System.String) = "Value" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline required (x: System.Nullable<System.Boolean>) = "Required" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabled (x: System.Nullable<System.Boolean>) = "Disabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline checked' (x: System.Nullable<System.Boolean>) = "Checked" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline additionalAttributes (x: System.Collections.Generic.IDictionary<System.String, System.Object>) = "AdditionalAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type fluentSkeleton<'FunBlazorGeneric> =
    
    static member create () = [] |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentSkeleton>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentSkeleton>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentSkeleton>
    static member create (node: FunBlazorNode) = [ node ] |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentSkeleton>
    static member inline shape (x: System.Nullable<Microsoft.Fast.Components.FluentUI.Shape>) = "Shape" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline shimmer (x: System.Nullable<System.Boolean>) = "Shimmer" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline pattern (x: System.String) = "Pattern" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline additionalAttributes (x: System.Collections.Generic.IDictionary<System.String, System.Object>) = "AdditionalAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type fluentSliderLabel<'FunBlazorGeneric> =
    
    static member create () = [] |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentSliderLabel>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentSliderLabel>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentSliderLabel>
    static member create (node: FunBlazorNode) = [ node ] |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentSliderLabel>
    static member inline childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline position (x: System.Nullable<System.Int32>) = "Position" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline hideMark (x: System.Nullable<System.Boolean>) = "HideMark" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline additionalAttributes (x: System.Collections.Generic.IDictionary<System.String, System.Object>) = "AdditionalAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type fluentSwitch<'FunBlazorGeneric> =
    
    static member create () = [] |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentSwitch>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentSwitch>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentSwitch>
    static member create (node: FunBlazorNode) = [ node ] |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentSwitch>
    static member inline disabled (x: System.Nullable<System.Boolean>) = "Disabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline checked' (x: System.Nullable<System.Boolean>) = "Checked" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline required (x: System.Nullable<System.Boolean>) = "Required" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline additionalAttributes (x: System.Collections.Generic.IDictionary<System.String, System.Object>) = "AdditionalAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type fluentTab<'FunBlazorGeneric> =
    
    static member create () = [] |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentTab>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentTab>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentTab>
    static member create (node: FunBlazorNode) = [ node ] |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentTab>
    static member inline childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline additionalAttributes (x: System.Collections.Generic.IDictionary<System.String, System.Object>) = "AdditionalAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type fluentTabPanel<'FunBlazorGeneric> =
    
    static member create () = [] |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentTabPanel>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentTabPanel>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentTabPanel>
    static member create (node: FunBlazorNode) = [ node ] |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentTabPanel>
    static member inline childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline additionalAttributes (x: System.Collections.Generic.IDictionary<System.String, System.Object>) = "AdditionalAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type fluentTabs<'FunBlazorGeneric> =
    
    static member create () = [] |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentTabs>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentTabs>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentTabs>
    static member create (node: FunBlazorNode) = [ node ] |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentTabs>
    static member inline activeIndicator (x: System.Nullable<System.Boolean>) = "ActiveIndicator" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline orientation (x: System.Nullable<Microsoft.Fast.Components.FluentUI.Orientation>) = "Orientation" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline additionalAttributes (x: System.Collections.Generic.IDictionary<System.String, System.Object>) = "AdditionalAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type fluentTreeItem<'FunBlazorGeneric> =
    
    static member create () = [] |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentTreeItem>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentTreeItem>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentTreeItem>
    static member create (node: FunBlazorNode) = [ node ] |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentTreeItem>
    static member inline childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabled (x: System.Nullable<System.Boolean>) = "Disabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline selected (x: System.Nullable<System.Boolean>) = "Selected" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline expanded (x: System.Nullable<System.Boolean>) = "Expanded" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline additionalAttributes (x: System.Collections.Generic.IDictionary<System.String, System.Object>) = "AdditionalAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type fluentTreeView<'FunBlazorGeneric> =
    
    static member create () = [] |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentTreeView>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentTreeView>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentTreeView>
    static member create (node: FunBlazorNode) = [ node ] |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentTreeView>
    static member inline childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline renderCollapsedNodes (x: System.Nullable<System.Boolean>) = "RenderCollapsedNodes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline additionalAttributes (x: System.Collections.Generic.IDictionary<System.String, System.Object>) = "AdditionalAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    
            

// =======================================================================================================================

namespace Fun.Blazor.FluentUI

open Fun.Blazor.FluentUI.DslInternals


type IFluentDesignSystemProviderNode = interface end
type fluentDesignSystemProvider =
    class
        inherit fluentDesignSystemProvider<IFluentDesignSystemProviderNode>
    end
                    

type IFluentInputBaseNode<'TValue> = interface end
type fluentInputBase<'TValue> =
    class
        inherit fluentInputBase<IFluentInputBaseNode<'TValue>, 'TValue>
    end
                    

type IFluentCheckboxNode = interface end
type fluentCheckbox =
    class
        inherit fluentCheckbox<IFluentCheckboxNode>
    end
                    

type IFluentComboboxNode = interface end
type fluentCombobox =
    class
        inherit fluentCombobox<IFluentComboboxNode>
    end
                    

type IFluentRadioGroupNode = interface end
type fluentRadioGroup =
    class
        inherit fluentRadioGroup<IFluentRadioGroupNode>
    end
                    

type IFluentSelectNode = interface end
type fluentSelect =
    class
        inherit fluentSelect<IFluentSelectNode>
    end
                    

type IFluentSliderNode = interface end
type fluentSlider =
    class
        inherit fluentSlider<IFluentSliderNode>
    end
                    

type IFluentTextAreaNode = interface end
type fluentTextArea =
    class
        inherit fluentTextArea<IFluentTextAreaNode>
    end
                    

type IFluentTextFieldNode = interface end
type fluentTextField =
    class
        inherit fluentTextField<IFluentTextFieldNode>
    end
                    

type IFluentAccordionNode = interface end
type fluentAccordion =
    class
        inherit fluentAccordion<IFluentAccordionNode>
    end
                    

type IFluentAccordionItemNode = interface end
type fluentAccordionItem =
    class
        inherit fluentAccordionItem<IFluentAccordionItemNode>
    end
                    

type IFluentAnchorNode = interface end
type fluentAnchor =
    class
        inherit fluentAnchor<IFluentAnchorNode>
    end
                    

type IFluentBadgeNode = interface end
type fluentBadge =
    class
        inherit fluentBadge<IFluentBadgeNode>
    end
                    

type IFluentBreadcrumbNode = interface end
type fluentBreadcrumb =
    class
        inherit fluentBreadcrumb<IFluentBreadcrumbNode>
    end
                    

type IFluentBreadcrumbItemNode = interface end
type fluentBreadcrumbItem =
    class
        inherit fluentBreadcrumbItem<IFluentBreadcrumbItemNode>
    end
                    

type IFluentButtonNode = interface end
type fluentButton =
    class
        inherit fluentButton<IFluentButtonNode>
    end
                    

type IFluentCardNode = interface end
type fluentCard =
    class
        inherit fluentCard<IFluentCardNode>
    end
                    

type IFluentDialogNode = interface end
type fluentDialog =
    class
        inherit fluentDialog<IFluentDialogNode>
    end
                    

type IFluentDividerNode = interface end
type fluentDivider =
    class
        inherit fluentDivider<IFluentDividerNode>
    end
                    

type IFluentFlipperNode = interface end
type fluentFlipper =
    class
        inherit fluentFlipper<IFluentFlipperNode>
    end
                    

type IFluentListboxNode = interface end
type fluentListbox =
    class
        inherit fluentListbox<IFluentListboxNode>
    end
                    

type IFluentMenuNode = interface end
type fluentMenu =
    class
        inherit fluentMenu<IFluentMenuNode>
    end
                    

type IFluentMenuItemNode = interface end
type fluentMenuItem =
    class
        inherit fluentMenuItem<IFluentMenuItemNode>
    end
                    

type IFluentOptionNode = interface end
type fluentOption =
    class
        inherit fluentOption<IFluentOptionNode>
    end
                    

type IFluentProgressNode = interface end
type fluentProgress =
    class
        inherit fluentProgress<IFluentProgressNode>
    end
                    

type IFluentProgressRingNode = interface end
type fluentProgressRing =
    class
        inherit fluentProgressRing<IFluentProgressRingNode>
    end
                    

type IFluentRadioNode = interface end
type fluentRadio =
    class
        inherit fluentRadio<IFluentRadioNode>
    end
                    

type IFluentSkeletonNode = interface end
type fluentSkeleton =
    class
        inherit fluentSkeleton<IFluentSkeletonNode>
    end
                    

type IFluentSliderLabelNode = interface end
type fluentSliderLabel =
    class
        inherit fluentSliderLabel<IFluentSliderLabelNode>
    end
                    

type IFluentSwitchNode = interface end
type fluentSwitch =
    class
        inherit fluentSwitch<IFluentSwitchNode>
    end
                    

type IFluentTabNode = interface end
type fluentTab =
    class
        inherit fluentTab<IFluentTabNode>
    end
                    

type IFluentTabPanelNode = interface end
type fluentTabPanel =
    class
        inherit fluentTabPanel<IFluentTabPanelNode>
    end
                    

type IFluentTabsNode = interface end
type fluentTabs =
    class
        inherit fluentTabs<IFluentTabsNode>
    end
                    

type IFluentTreeItemNode = interface end
type fluentTreeItem =
    class
        inherit fluentTreeItem<IFluentTreeItemNode>
    end
                    

type IFluentTreeViewNode = interface end
type fluentTreeView =
    class
        inherit fluentTreeView<IFluentTreeViewNode>
    end
                    
            