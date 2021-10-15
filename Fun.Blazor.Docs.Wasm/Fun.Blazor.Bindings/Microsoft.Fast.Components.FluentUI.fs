namespace rec Microsoft.Fast.Components.FluentUI.DslInternals

open Bolero.Html
open Fun.Blazor
open Microsoft.AspNetCore.Components.DslInternals
open Microsoft.AspNetCore.Components.Web.DslInternals
open Microsoft.Fast.Components.FluentUI.DslInternals
open Microsoft.Fast.Components.FluentUI.DslInternals


type fluentInputBase<'FunBlazorGeneric, 'TValue> =
    
    static member create () = [] |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentInputBase<'TValue>>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentInputBase<'TValue>>

    static member ref x = attr.ref<Microsoft.Fast.Components.FluentUI.FluentInputBase<'TValue>> x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member additionalAttributes (x: System.Collections.Generic.IReadOnlyDictionary<System.String, System.Object>) = "AdditionalAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member value (x: 'TValue) = "Value" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member valueChanged fn = (Bolero.Html.attr.callback<'TValue> "ValueChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member valueExpression (x: System.Linq.Expressions.Expression<System.Func<'TValue>>) = "ValueExpression" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member displayName (x: System.String) = "DisplayName" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type fluentCheckbox<'FunBlazorGeneric> =
    inherit fluentInputBase<'FunBlazorGeneric, System.Boolean>
    static member create () = [] |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentCheckbox>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentCheckbox>
    static member create (nodes: IFunBlazorNode list) = nodes |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentCheckbox>
    static member create (node: IFunBlazorNode) = [ node ] |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentCheckbox>
    static member create (x: string) = [ html.text x ] |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentCheckbox>
    static member ref x = attr.ref<Microsoft.Fast.Components.FluentUI.FluentCheckbox> x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member href (x: System.String) = "Href" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member disabled (x: System.Nullable<System.Boolean>) = "Disabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member required (x: System.Nullable<System.Boolean>) = "Required" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type fluentCombobox<'FunBlazorGeneric> =
    inherit fluentInputBase<'FunBlazorGeneric, System.String>
    static member create () = [] |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentCombobox>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentCombobox>
    static member create (nodes: IFunBlazorNode list) = nodes |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentCombobox>
    static member create (node: IFunBlazorNode) = [ node ] |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentCombobox>
    static member create (x: string) = [ html.text x ] |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentCombobox>
    static member ref x = attr.ref<Microsoft.Fast.Components.FluentUI.FluentCombobox> x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member filled (x: System.Nullable<System.Boolean>) = "Filled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member disabled (x: System.Nullable<System.Boolean>) = "Disabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member autocomplete (x: System.Nullable<Microsoft.Fast.Components.FluentUI.Autocomplete>) = "Autocomplete" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member position (x: System.Nullable<Microsoft.Fast.Components.FluentUI.Position>) = "Position" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type fluentNumberField<'FunBlazorGeneric, 'TValue> =
    inherit fluentInputBase<'FunBlazorGeneric, 'TValue>
    static member create () = [] |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentNumberField<'TValue>>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentNumberField<'TValue>>
    static member create (nodes: IFunBlazorNode list) = nodes |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentNumberField<'TValue>>
    static member create (node: IFunBlazorNode) = [ node ] |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentNumberField<'TValue>>
    static member create (x: string) = [ html.text x ] |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentNumberField<'TValue>>
    static member ref x = attr.ref<Microsoft.Fast.Components.FluentUI.FluentNumberField<'TValue>> x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member disabled (x: System.Nullable<System.Boolean>) = "Disabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member readonly (x: System.Nullable<System.Boolean>) = "Readonly" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member required (x: System.Nullable<System.Boolean>) = "Required" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member autofocus (x: System.Nullable<System.Boolean>) = "Autofocus" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member size (x: System.Int32) = "Size" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member appearance (x: System.Nullable<Microsoft.Fast.Components.FluentUI.Appearance>) = "Appearance" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member placeholder (x: System.String) = "Placeholder" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member parsingErrorMessage (x: System.String) = "ParsingErrorMessage" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member min (x: System.String) = "Min" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member max (x: System.String) = "Max" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member minLength (x: System.Int32) = "MinLength" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member maxLength (x: System.Int32) = "MaxLength" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member step (x: System.Int32) = "Step" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type fluentRadioGroup<'FunBlazorGeneric> =
    inherit fluentInputBase<'FunBlazorGeneric, System.String>
    static member create () = [] |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentRadioGroup>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentRadioGroup>
    static member create (nodes: IFunBlazorNode list) = nodes |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentRadioGroup>
    static member create (node: IFunBlazorNode) = [ node ] |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentRadioGroup>
    static member create (x: string) = [ html.text x ] |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentRadioGroup>
    static member ref x = attr.ref<Microsoft.Fast.Components.FluentUI.FluentRadioGroup> x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member name (x: System.String) = "Name" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member required (x: System.Nullable<System.Boolean>) = "Required" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member orientation (x: System.Nullable<Microsoft.Fast.Components.FluentUI.Orientation>) = "Orientation" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type fluentSelect<'FunBlazorGeneric> =
    inherit fluentInputBase<'FunBlazorGeneric, System.String>
    static member create () = [] |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentSelect>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentSelect>
    static member create (nodes: IFunBlazorNode list) = nodes |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentSelect>
    static member create (node: IFunBlazorNode) = [ node ] |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentSelect>
    static member create (x: string) = [ html.text x ] |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentSelect>
    static member ref x = attr.ref<Microsoft.Fast.Components.FluentUI.FluentSelect> x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member disabled (x: System.Nullable<System.Boolean>) = "Disabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member filled (x: System.Nullable<System.Boolean>) = "Filled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member name (x: System.String) = "Name" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member position (x: System.Nullable<Microsoft.Fast.Components.FluentUI.Position>) = "Position" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type fluentSlider<'FunBlazorGeneric> =
    inherit fluentInputBase<'FunBlazorGeneric, System.Int32>
    static member create () = [] |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentSlider>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentSlider>
    static member create (nodes: IFunBlazorNode list) = nodes |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentSlider>
    static member create (node: IFunBlazorNode) = [ node ] |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentSlider>
    static member create (x: string) = [ html.text x ] |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentSlider>
    static member ref x = attr.ref<Microsoft.Fast.Components.FluentUI.FluentSlider> x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member orientation (x: System.Nullable<Microsoft.Fast.Components.FluentUI.Orientation>) = "Orientation" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member min (x: System.Nullable<System.Int32>) = "Min" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member max (x: System.Nullable<System.Int32>) = "Max" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member step (x: System.Nullable<System.Int32>) = "Step" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member disabled (x: System.Nullable<System.Boolean>) = "Disabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member readonly (x: System.Nullable<System.Boolean>) = "Readonly" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type fluentTextArea<'FunBlazorGeneric> =
    inherit fluentInputBase<'FunBlazorGeneric, System.String>
    static member create () = [] |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentTextArea>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentTextArea>
    static member create (nodes: IFunBlazorNode list) = nodes |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentTextArea>
    static member create (node: IFunBlazorNode) = [ node ] |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentTextArea>
    static member create (x: string) = [ html.text x ] |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentTextArea>
    static member ref x = attr.ref<Microsoft.Fast.Components.FluentUI.FluentTextArea> x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member disabled (x: System.Nullable<System.Boolean>) = "Disabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member readonly (x: System.Nullable<System.Boolean>) = "Readonly" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member required (x: System.Nullable<System.Boolean>) = "Required" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member autofocus (x: System.Nullable<System.Boolean>) = "Autofocus" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member resize (x: System.Nullable<Microsoft.Fast.Components.FluentUI.Resize>) = "Resize" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member appearance (x: System.Nullable<Microsoft.Fast.Components.FluentUI.Appearance>) = "Appearance" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member placeholder (x: System.String) = "Placeholder" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type fluentTextField<'FunBlazorGeneric> =
    inherit fluentInputBase<'FunBlazorGeneric, System.String>
    static member create () = [] |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentTextField>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentTextField>
    static member create (nodes: IFunBlazorNode list) = nodes |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentTextField>
    static member create (node: IFunBlazorNode) = [ node ] |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentTextField>
    static member create (x: string) = [ html.text x ] |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentTextField>
    static member ref x = attr.ref<Microsoft.Fast.Components.FluentUI.FluentTextField> x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member disabled (x: System.Nullable<System.Boolean>) = "Disabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member readonly (x: System.Nullable<System.Boolean>) = "Readonly" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member required (x: System.Nullable<System.Boolean>) = "Required" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member autofocus (x: System.Nullable<System.Boolean>) = "Autofocus" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member size (x: System.Nullable<System.Int32>) = "Size" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member appearance (x: System.Nullable<Microsoft.Fast.Components.FluentUI.Appearance>) = "Appearance" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member textFieldType (x: System.Nullable<Microsoft.Fast.Components.FluentUI.TextFieldType>) = "TextFieldType" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member placeholder (x: System.String) = "Placeholder" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member minLength (x: System.Nullable<System.Int32>) = "MinLength" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member maxLength (x: System.Nullable<System.Int32>) = "MaxLength" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member spellcheck (x: System.Nullable<System.Boolean>) = "Spellcheck" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type fluentAccordion<'FunBlazorGeneric> =
    
    static member create () = [] |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentAccordion>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentAccordion>
    static member create (nodes: IFunBlazorNode list) = nodes |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentAccordion>
    static member create (node: IFunBlazorNode) = [ node ] |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentAccordion>
    static member create (x: string) = [ html.text x ] |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentAccordion>
    static member ref x = attr.ref<Microsoft.Fast.Components.FluentUI.FluentAccordion> x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member expandMode (x: System.Nullable<Microsoft.Fast.Components.FluentUI.ExpandMode>) = "ExpandMode" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member additionalAttributes (x: System.Collections.Generic.IDictionary<System.String, System.Object>) = "AdditionalAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type fluentAccordionItem<'FunBlazorGeneric> =
    
    static member create () = [] |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentAccordionItem>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentAccordionItem>
    static member create (nodes: IFunBlazorNode list) = nodes |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentAccordionItem>
    static member create (node: IFunBlazorNode) = [ node ] |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentAccordionItem>
    static member create (x: string) = [ html.text x ] |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentAccordionItem>
    static member ref x = attr.ref<Microsoft.Fast.Components.FluentUI.FluentAccordionItem> x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member expanded (x: System.Nullable<System.Boolean>) = "Expanded" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member additionalAttributes (x: System.Collections.Generic.IDictionary<System.String, System.Object>) = "AdditionalAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type fluentAnchor<'FunBlazorGeneric> =
    
    static member create () = [] |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentAnchor>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentAnchor>
    static member create (nodes: IFunBlazorNode list) = nodes |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentAnchor>
    static member create (node: IFunBlazorNode) = [ node ] |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentAnchor>
    static member create (x: string) = [ html.text x ] |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentAnchor>
    static member ref x = attr.ref<Microsoft.Fast.Components.FluentUI.FluentAnchor> x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member href (x: System.String) = "Href" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member appearance (x: System.Nullable<Microsoft.Fast.Components.FluentUI.Appearance>) = "Appearance" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member additionalAttributes (x: System.Collections.Generic.IDictionary<System.String, System.Object>) = "AdditionalAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type fluentAnchoredRegion<'FunBlazorGeneric> =
    
    static member create () = [] |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentAnchoredRegion>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentAnchoredRegion>
    static member create (nodes: IFunBlazorNode list) = nodes |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentAnchoredRegion>
    static member create (node: IFunBlazorNode) = [ node ] |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentAnchoredRegion>
    static member create (x: string) = [ html.text x ] |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentAnchoredRegion>
    static member ref x = attr.ref<Microsoft.Fast.Components.FluentUI.FluentAnchoredRegion> x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member anchor (x: System.String) = "Anchor" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member viewport (x: System.String) = "Viewport" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member horizontalPositioningMode (x: System.Nullable<Microsoft.Fast.Components.FluentUI.Positioning>) = "HorizontalPositioningMode" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member horizontalDefaultPosition (x: System.Nullable<Microsoft.Fast.Components.FluentUI.HorizontalPosition>) = "HorizontalDefaultPosition" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member horizontalInset (x: System.Boolean) = "HorizontalInset" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member horizontalThreshold (x: System.Int32) = "HorizontalThreshold" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member horizontalScaling (x: System.Nullable<Microsoft.Fast.Components.FluentUI.Scaling>) = "HorizontalScaling" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member verticalPositioningMode (x: System.Nullable<Microsoft.Fast.Components.FluentUI.Positioning>) = "VerticalPositioningMode" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member verticalDefaultPosition (x: System.Nullable<Microsoft.Fast.Components.FluentUI.VerticalPosition>) = "VerticalDefaultPosition" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member verticalInset (x: System.Boolean) = "VerticalInset" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member verticalThreshold (x: System.Int32) = "VerticalThreshold" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member verticalScaling (x: System.Nullable<Microsoft.Fast.Components.FluentUI.Scaling>) = "VerticalScaling" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member autoUpdateMode (x: System.Nullable<Microsoft.Fast.Components.FluentUI.UpdateMode>) = "AutoUpdateMode" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member additionalAttributes (x: System.Collections.Generic.IDictionary<System.String, System.Object>) = "AdditionalAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type fluentBadge<'FunBlazorGeneric> =
    
    static member create () = [] |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentBadge>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentBadge>
    static member create (nodes: IFunBlazorNode list) = nodes |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentBadge>
    static member create (node: IFunBlazorNode) = [ node ] |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentBadge>
    static member create (x: string) = [ html.text x ] |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentBadge>
    static member ref x = attr.ref<Microsoft.Fast.Components.FluentUI.FluentBadge> x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member color (x: System.Nullable<Microsoft.Fast.Components.FluentUI.Color>) = "Color" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member fill (x: System.Nullable<Microsoft.Fast.Components.FluentUI.Fill>) = "Fill" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member appearance (x: System.Nullable<Microsoft.Fast.Components.FluentUI.Appearance>) = "Appearance" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member additionalAttributes (x: System.Collections.Generic.IDictionary<System.String, System.Object>) = "AdditionalAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type fluentBreadcrumb<'FunBlazorGeneric> =
    
    static member create () = [] |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentBreadcrumb>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentBreadcrumb>
    static member create (nodes: IFunBlazorNode list) = nodes |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentBreadcrumb>
    static member create (node: IFunBlazorNode) = [ node ] |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentBreadcrumb>
    static member create (x: string) = [ html.text x ] |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentBreadcrumb>
    static member ref x = attr.ref<Microsoft.Fast.Components.FluentUI.FluentBreadcrumb> x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member additionalAttributes (x: System.Collections.Generic.IDictionary<System.String, System.Object>) = "AdditionalAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type fluentBreadcrumbItem<'FunBlazorGeneric> =
    
    static member create () = [] |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentBreadcrumbItem>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentBreadcrumbItem>
    static member create (nodes: IFunBlazorNode list) = nodes |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentBreadcrumbItem>
    static member create (node: IFunBlazorNode) = [ node ] |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentBreadcrumbItem>
    static member create (x: string) = [ html.text x ] |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentBreadcrumbItem>
    static member ref x = attr.ref<Microsoft.Fast.Components.FluentUI.FluentBreadcrumbItem> x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member href (x: System.String) = "Href" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member additionalAttributes (x: System.Collections.Generic.IDictionary<System.String, System.Object>) = "AdditionalAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type fluentButton<'FunBlazorGeneric> =
    
    static member create () = [] |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentButton>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentButton>
    static member create (nodes: IFunBlazorNode list) = nodes |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentButton>
    static member create (node: IFunBlazorNode) = [ node ] |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentButton>
    static member create (x: string) = [ html.text x ] |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentButton>
    static member ref x = attr.ref<Microsoft.Fast.Components.FluentUI.FluentButton> x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member appearance (x: System.Nullable<Microsoft.Fast.Components.FluentUI.Appearance>) = "Appearance" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member disabled (x: System.Nullable<System.Boolean>) = "Disabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member autofocus (x: System.Nullable<System.Boolean>) = "Autofocus" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member additionalAttributes (x: System.Collections.Generic.IDictionary<System.String, System.Object>) = "AdditionalAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type fluentCard<'FunBlazorGeneric> =
    
    static member create () = [] |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentCard>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentCard>
    static member create (nodes: IFunBlazorNode list) = nodes |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentCard>
    static member create (node: IFunBlazorNode) = [ node ] |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentCard>
    static member create (x: string) = [ html.text x ] |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentCard>
    static member ref x = attr.ref<Microsoft.Fast.Components.FluentUI.FluentCard> x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member additionalAttributes (x: System.Collections.Generic.IDictionary<System.String, System.Object>) = "AdditionalAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type fluentDataGrid<'FunBlazorGeneric, 'TItem> =
    
    static member create () = [] |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentDataGrid<'TItem>>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentDataGrid<'TItem>>
    static member create (nodes: IFunBlazorNode list) = nodes |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentDataGrid<'TItem>>
    static member create (node: IFunBlazorNode) = [ node ] |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentDataGrid<'TItem>>
    static member create (x: string) = [ html.text x ] |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentDataGrid<'TItem>>
    static member ref x = attr.ref<Microsoft.Fast.Components.FluentUI.FluentDataGrid<'TItem>> x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member generateHeader (x: System.Nullable<Microsoft.Fast.Components.FluentUI.GenerateHeaderOptions>) = "GenerateHeader" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member gridTemplateColumns (x: System.String) = "GridTemplateColumns" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member rowsData (x: System.Collections.Generic.List<'TItem>) = "RowsData" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member columnDefinitions (x: System.Collections.Generic.IEnumerable<Microsoft.Fast.Components.FluentUI.ColumnDefinition<'TItem>>) = "ColumnDefinitions" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member headerCellTemplate (render: Microsoft.Fast.Components.FluentUI.ColumnDefinition<'TItem> -> IFunBlazorNode) = Bolero.Html.attr.fragmentWith "HeaderCellTemplate" (fun x -> render x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member rowItemTemplate (render: 'TItem -> IFunBlazorNode) = Bolero.Html.attr.fragmentWith "RowItemTemplate" (fun x -> render x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member additionalAttributes (x: System.Collections.Generic.IDictionary<System.String, System.Object>) = "AdditionalAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type fluentDataGridCell<'FunBlazorGeneric> =
    
    static member create () = [] |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentDataGridCell>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentDataGridCell>
    static member create (nodes: IFunBlazorNode list) = nodes |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentDataGridCell>
    static member create (node: IFunBlazorNode) = [ node ] |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentDataGridCell>
    static member create (x: string) = [ html.text x ] |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentDataGridCell>
    static member ref x = attr.ref<Microsoft.Fast.Components.FluentUI.FluentDataGridCell> x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member cellType (x: System.Nullable<Microsoft.Fast.Components.FluentUI.DataGridCellType>) = "CellType" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member gridColumn (x: System.Int32) = "GridColumn" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member additionalAttributes (x: System.Collections.Generic.IDictionary<System.String, System.Object>) = "AdditionalAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type fluentDataGridRow<'FunBlazorGeneric, 'TItem> =
    
    static member create () = [] |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentDataGridRow<'TItem>>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentDataGridRow<'TItem>>
    static member create (nodes: IFunBlazorNode list) = nodes |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentDataGridRow<'TItem>>
    static member create (node: IFunBlazorNode) = [ node ] |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentDataGridRow<'TItem>>
    static member create (x: string) = [ html.text x ] |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentDataGridRow<'TItem>>
    static member ref x = attr.ref<Microsoft.Fast.Components.FluentUI.FluentDataGridRow<'TItem>> x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member rowIndex (x: System.Nullable<System.Int32>) = "RowIndex" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member gridTemplateColumns (x: System.String) = "GridTemplateColumns" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member rowType (x: System.Nullable<Microsoft.Fast.Components.FluentUI.DataGridRowType>) = "RowType" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member rowData (x: 'TItem) = "RowData" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member columnDefinitions (x: System.Collections.Generic.IEnumerable<Microsoft.Fast.Components.FluentUI.ColumnDefinition<'TItem>>) = "ColumnDefinitions" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member additionalAttributes (x: System.Collections.Generic.IDictionary<System.String, System.Object>) = "AdditionalAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type fluentDesignSystemProvider<'FunBlazorGeneric> =
    
    static member create () = [] |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentDesignSystemProvider>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentDesignSystemProvider>
    static member create (nodes: IFunBlazorNode list) = nodes |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentDesignSystemProvider>
    static member create (node: IFunBlazorNode) = [ node ] |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentDesignSystemProvider>
    static member create (x: string) = [ html.text x ] |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentDesignSystemProvider>
    static member ref x = attr.ref<Microsoft.Fast.Components.FluentUI.FluentDesignSystemProvider> x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member noPaint (x: System.Nullable<System.Boolean>) = "NoPaint" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member fillColor (x: System.String) = "FillColor" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member accentBaseColor (x: System.String) = "AccentBaseColor" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member neutralBaseColor (x: System.String) = "NeutralBaseColor" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member density (x: System.Nullable<System.Int32>) = "Density" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member designUnit (x: System.Nullable<System.Int32>) = "DesignUnit" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member direction (x: System.Nullable<Microsoft.Fast.Components.FluentUI.LocalizationDirection>) = "Direction" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member baseHeightMultiplier (x: System.Nullable<System.Int32>) = "BaseHeightMultiplier" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member baseHorizontalSpacingMultiplier (x: System.Nullable<System.Int32>) = "BaseHorizontalSpacingMultiplier" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member controlCornerRadius (x: System.Nullable<System.Int32>) = "ControlCornerRadius" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member strokeWidth (x: System.Nullable<System.Int32>) = "StrokeWidth" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member focusStrokeWidth (x: System.Nullable<System.Int32>) = "FocusStrokeWidth" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member disabledOpacity (x: System.Nullable<System.Single>) = "DisabledOpacity" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member typeRampMinus2FontSize (x: System.Nullable<System.Single>) = "TypeRampMinus2FontSize" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member typeRampMinus2LineHeight (x: System.Nullable<System.Single>) = "TypeRampMinus2LineHeight" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member typeRampMinus1FontSize (x: System.Nullable<System.Single>) = "TypeRampMinus1FontSize" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member typeRampMinus1LineHeight (x: System.Nullable<System.Single>) = "TypeRampMinus1LineHeight" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member typeRampBaseFontSize (x: System.Nullable<System.Single>) = "TypeRampBaseFontSize" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member typeRampBaseLineHeight (x: System.Nullable<System.Single>) = "TypeRampBaseLineHeight" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member typeRampPlus1FontSize (x: System.Nullable<System.Single>) = "TypeRampPlus1FontSize" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member typeRampPlus1LineHeight (x: System.Nullable<System.Single>) = "TypeRampPlus1LineHeight" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member typeRampPlus2FontSize (x: System.Nullable<System.Single>) = "TypeRampPlus2FontSize" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member typeRampPlus2LineHeight (x: System.Nullable<System.Single>) = "TypeRampPlus2LineHeight" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member typeRampPlus3FontSize (x: System.Nullable<System.Single>) = "TypeRampPlus3FontSize" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member typeRampPlus3LineHeight (x: System.Nullable<System.Single>) = "TypeRampPlus3LineHeight" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member typeRampPlus4FontSize (x: System.Nullable<System.Single>) = "TypeRampPlus4FontSize" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member typeRampPlus4LineHeight (x: System.Nullable<System.Single>) = "TypeRampPlus4LineHeight" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member typeRampPlus5FontSize (x: System.Nullable<System.Single>) = "TypeRampPlus5FontSize" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member typeRampPlus5LineHeight (x: System.Nullable<System.Single>) = "TypeRampPlus5LineHeight" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member typeRampPlus6FontSize (x: System.Nullable<System.Single>) = "TypeRampPlus6FontSize" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member typeRampPlus6LineHeight (x: System.Nullable<System.Single>) = "TypeRampPlus6LineHeight" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member accentFillRestDelta (x: System.Nullable<System.Int32>) = "AccentFillRestDelta" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member accentFillHoverDelta (x: System.Nullable<System.Int32>) = "AccentFillHoverDelta" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member accentFillActiveDelta (x: System.Nullable<System.Int32>) = "AccentFillActiveDelta" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member accentFillFocusDelta (x: System.Nullable<System.Int32>) = "AccentFillFocusDelta" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member accentForegroundRestDelta (x: System.Nullable<System.Int32>) = "AccentForegroundRestDelta" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member accentForegroundHoverDelta (x: System.Nullable<System.Int32>) = "AccentForegroundHoverDelta" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member accentForegroundActiveDelta (x: System.Nullable<System.Int32>) = "AccentForegroundActiveDelta" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member accentForegroundFocusDelta (x: System.Nullable<System.Int32>) = "AccentForegroundFocusDelta" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member neutralFillRestDelta (x: System.Nullable<System.Int32>) = "NeutralFillRestDelta" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member neutralFillHoverDelta (x: System.Nullable<System.Int32>) = "NeutralFillHoverDelta" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member neutralFillActiveDelta (x: System.Nullable<System.Int32>) = "NeutralFillActiveDelta" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member neutralFillFocusDelta (x: System.Nullable<System.Int32>) = "NeutralFillFocusDelta" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member neutralFillInputRestDelta (x: System.Nullable<System.Int32>) = "NeutralFillInputRestDelta" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member neutralFillInputHoverDelta (x: System.Nullable<System.Int32>) = "NeutralFillInputHoverDelta" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member neutralFillInputActiveDelta (x: System.Nullable<System.Int32>) = "NeutralFillInputActiveDelta" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member neutralFillInputFocusDelta (x: System.Nullable<System.Int32>) = "NeutralFillInputFocusDelta" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member neutralFillLayerRestDelta (x: System.Nullable<System.Int32>) = "NeutralFillLayerRestDelta" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member neutralFillStealthRestDelta (x: System.Nullable<System.Int32>) = "NeutralFillStealthRestDelta" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member neutralFillStealthHoverDelta (x: System.Nullable<System.Int32>) = "NeutralFillStealthHoverDelta" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member neutralFillStealthActiveDelta (x: System.Nullable<System.Int32>) = "NeutralFillStealthActiveDelta" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member neutralFillStealthFocusDelta (x: System.Nullable<System.Int32>) = "NeutralFillStealthFocusDelta" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member neutralFillStrongHoverDelta (x: System.Nullable<System.Int32>) = "NeutralFillStrongHoverDelta" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member neutralFillStrongActiveDelta (x: System.Nullable<System.Int32>) = "NeutralFillStrongActiveDelta" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member neutralFillStrongFocusDelta (x: System.Nullable<System.Int32>) = "NeutralFillStrongFocusDelta" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member neutralStrokeDividerRestDelta (x: System.Nullable<System.Int32>) = "NeutralStrokeDividerRestDelta" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member neutralStrokeRestDelta (x: System.Nullable<System.Int32>) = "NeutralStrokeRestDelta" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member neutralStrokeHoverDelta (x: System.Nullable<System.Int32>) = "NeutralStrokeHoverDelta" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member neutralStrokeActiveDelta (x: System.Nullable<System.Int32>) = "NeutralStrokeActiveDelta" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member neutralStrokeFocusDelta (x: System.Nullable<System.Int32>) = "NeutralStrokeFocusDelta" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member baseLayerLuminance (x: System.Nullable<System.Single>) = "BaseLayerLuminance" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member additionalAttributes (x: System.Collections.Generic.IDictionary<System.String, System.Object>) = "AdditionalAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type fluentDialog<'FunBlazorGeneric> =
    
    static member create () = [] |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentDialog>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentDialog>
    static member create (nodes: IFunBlazorNode list) = nodes |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentDialog>
    static member create (node: IFunBlazorNode) = [ node ] |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentDialog>
    static member create (x: string) = [ html.text x ] |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentDialog>
    static member ref x = attr.ref<Microsoft.Fast.Components.FluentUI.FluentDialog> x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member modal (x: System.Nullable<System.Boolean>) = "Modal" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member additionalAttributes (x: System.Collections.Generic.IDictionary<System.String, System.Object>) = "AdditionalAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member hidden (x: System.Boolean) = "Hidden" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type fluentDivider<'FunBlazorGeneric> =
    
    static member create () = [] |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentDivider>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentDivider>
    static member create (nodes: IFunBlazorNode list) = nodes |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentDivider>
    static member create (node: IFunBlazorNode) = [ node ] |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentDivider>
    static member create (x: string) = [ html.text x ] |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentDivider>
    static member ref x = attr.ref<Microsoft.Fast.Components.FluentUI.FluentDivider> x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member additionalAttributes (x: System.Collections.Generic.IDictionary<System.String, System.Object>) = "AdditionalAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type fluentFlipper<'FunBlazorGeneric> =
    
    static member create () = [] |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentFlipper>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentFlipper>
    static member create (nodes: IFunBlazorNode list) = nodes |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentFlipper>
    static member create (node: IFunBlazorNode) = [ node ] |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentFlipper>
    static member create (x: string) = [ html.text x ] |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentFlipper>
    static member ref x = attr.ref<Microsoft.Fast.Components.FluentUI.FluentFlipper> x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member disabled (x: System.Nullable<System.Boolean>) = "Disabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member direction (x: System.Nullable<Microsoft.Fast.Components.FluentUI.Direction>) = "Direction" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member additionalAttributes (x: System.Collections.Generic.IDictionary<System.String, System.Object>) = "AdditionalAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type fluentHorizontalScroll<'FunBlazorGeneric> =
    
    static member create () = [] |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentHorizontalScroll>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentHorizontalScroll>
    static member create (nodes: IFunBlazorNode list) = nodes |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentHorizontalScroll>
    static member create (node: IFunBlazorNode) = [ node ] |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentHorizontalScroll>
    static member create (x: string) = [ html.text x ] |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentHorizontalScroll>
    static member ref x = attr.ref<Microsoft.Fast.Components.FluentUI.FluentHorizontalScroll> x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member speed (x: System.Int32) = "Speed" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member easing (x: System.String) = "Easing" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member additionalAttributes (x: System.Collections.Generic.IDictionary<System.String, System.Object>) = "AdditionalAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type fluentListbox<'FunBlazorGeneric> =
    
    static member create () = [] |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentListbox>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentListbox>
    static member create (nodes: IFunBlazorNode list) = nodes |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentListbox>
    static member create (node: IFunBlazorNode) = [ node ] |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentListbox>
    static member create (x: string) = [ html.text x ] |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentListbox>
    static member ref x = attr.ref<Microsoft.Fast.Components.FluentUI.FluentListbox> x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member additionalAttributes (x: System.Collections.Generic.IDictionary<System.String, System.Object>) = "AdditionalAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type fluentMenu<'FunBlazorGeneric> =
    
    static member create () = [] |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentMenu>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentMenu>
    static member create (nodes: IFunBlazorNode list) = nodes |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentMenu>
    static member create (node: IFunBlazorNode) = [ node ] |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentMenu>
    static member create (x: string) = [ html.text x ] |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentMenu>
    static member ref x = attr.ref<Microsoft.Fast.Components.FluentUI.FluentMenu> x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member additionalAttributes (x: System.Collections.Generic.IDictionary<System.String, System.Object>) = "AdditionalAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type fluentMenuItem<'FunBlazorGeneric> =
    
    static member create () = [] |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentMenuItem>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentMenuItem>
    static member create (nodes: IFunBlazorNode list) = nodes |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentMenuItem>
    static member create (node: IFunBlazorNode) = [ node ] |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentMenuItem>
    static member create (x: string) = [ html.text x ] |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentMenuItem>
    static member ref x = attr.ref<Microsoft.Fast.Components.FluentUI.FluentMenuItem> x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member disabled (x: System.Nullable<System.Boolean>) = "Disabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member checked' (x: System.Nullable<System.Boolean>) = "Checked" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member additionalAttributes (x: System.Collections.Generic.IDictionary<System.String, System.Object>) = "AdditionalAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type fluentOption<'FunBlazorGeneric> =
    
    static member create () = [] |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentOption>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentOption>
    static member create (nodes: IFunBlazorNode list) = nodes |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentOption>
    static member create (node: IFunBlazorNode) = [ node ] |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentOption>
    static member create (x: string) = [ html.text x ] |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentOption>
    static member ref x = attr.ref<Microsoft.Fast.Components.FluentUI.FluentOption> x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member disabled (x: System.Nullable<System.Boolean>) = "Disabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member value (x: System.String) = "Value" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member selected (x: System.Nullable<System.Boolean>) = "Selected" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member additionalAttributes (x: System.Collections.Generic.IDictionary<System.String, System.Object>) = "AdditionalAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type fluentProgress<'FunBlazorGeneric> =
    
    static member create () = [] |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentProgress>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentProgress>
    static member create (nodes: IFunBlazorNode list) = nodes |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentProgress>
    static member create (node: IFunBlazorNode) = [ node ] |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentProgress>
    static member create (x: string) = [ html.text x ] |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentProgress>
    static member ref x = attr.ref<Microsoft.Fast.Components.FluentUI.FluentProgress> x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member min (x: System.Nullable<System.Int32>) = "Min" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member max (x: System.Nullable<System.Int32>) = "Max" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member value (x: System.String) = "Value" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member paused (x: System.Nullable<System.Boolean>) = "Paused" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member additionalAttributes (x: System.Collections.Generic.IDictionary<System.String, System.Object>) = "AdditionalAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type fluentProgressRing<'FunBlazorGeneric> =
    
    static member create () = [] |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentProgressRing>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentProgressRing>
    static member create (nodes: IFunBlazorNode list) = nodes |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentProgressRing>
    static member create (node: IFunBlazorNode) = [ node ] |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentProgressRing>
    static member create (x: string) = [ html.text x ] |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentProgressRing>
    static member ref x = attr.ref<Microsoft.Fast.Components.FluentUI.FluentProgressRing> x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member min (x: System.Nullable<System.Int32>) = "Min" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member max (x: System.Nullable<System.Int32>) = "Max" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member value (x: System.String) = "Value" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member paused (x: System.Nullable<System.Boolean>) = "Paused" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member additionalAttributes (x: System.Collections.Generic.IDictionary<System.String, System.Object>) = "AdditionalAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type fluentRadio<'FunBlazorGeneric> =
    
    static member create () = [] |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentRadio>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentRadio>
    static member create (nodes: IFunBlazorNode list) = nodes |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentRadio>
    static member create (node: IFunBlazorNode) = [ node ] |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentRadio>
    static member create (x: string) = [ html.text x ] |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentRadio>
    static member ref x = attr.ref<Microsoft.Fast.Components.FluentUI.FluentRadio> x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member value (x: System.String) = "Value" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member required (x: System.Nullable<System.Boolean>) = "Required" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member disabled (x: System.Nullable<System.Boolean>) = "Disabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member checked' (x: System.Nullable<System.Boolean>) = "Checked" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member additionalAttributes (x: System.Collections.Generic.IDictionary<System.String, System.Object>) = "AdditionalAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type fluentSkeleton<'FunBlazorGeneric> =
    
    static member create () = [] |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentSkeleton>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentSkeleton>
    static member create (nodes: IFunBlazorNode list) = nodes |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentSkeleton>
    static member create (node: IFunBlazorNode) = [ node ] |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentSkeleton>
    static member create (x: string) = [ html.text x ] |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentSkeleton>
    static member ref x = attr.ref<Microsoft.Fast.Components.FluentUI.FluentSkeleton> x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member shape (x: System.Nullable<Microsoft.Fast.Components.FluentUI.Shape>) = "Shape" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member shimmer (x: System.Nullable<System.Boolean>) = "Shimmer" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member pattern (x: System.String) = "Pattern" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member additionalAttributes (x: System.Collections.Generic.IDictionary<System.String, System.Object>) = "AdditionalAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type fluentSliderLabel<'FunBlazorGeneric> =
    
    static member create () = [] |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentSliderLabel>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentSliderLabel>
    static member create (nodes: IFunBlazorNode list) = nodes |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentSliderLabel>
    static member create (node: IFunBlazorNode) = [ node ] |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentSliderLabel>
    static member create (x: string) = [ html.text x ] |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentSliderLabel>
    static member ref x = attr.ref<Microsoft.Fast.Components.FluentUI.FluentSliderLabel> x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member position (x: System.Nullable<System.Int32>) = "Position" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member hideMark (x: System.Nullable<System.Boolean>) = "HideMark" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member additionalAttributes (x: System.Collections.Generic.IDictionary<System.String, System.Object>) = "AdditionalAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type fluentSwitch<'FunBlazorGeneric> =
    
    static member create () = [] |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentSwitch>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentSwitch>
    static member create (nodes: IFunBlazorNode list) = nodes |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentSwitch>
    static member create (node: IFunBlazorNode) = [ node ] |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentSwitch>
    static member create (x: string) = [ html.text x ] |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentSwitch>
    static member ref x = attr.ref<Microsoft.Fast.Components.FluentUI.FluentSwitch> x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member disabled (x: System.Nullable<System.Boolean>) = "Disabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member checked' (x: System.Nullable<System.Boolean>) = "Checked" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member required (x: System.Nullable<System.Boolean>) = "Required" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member additionalAttributes (x: System.Collections.Generic.IDictionary<System.String, System.Object>) = "AdditionalAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type fluentTab<'FunBlazorGeneric> =
    
    static member create () = [] |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentTab>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentTab>
    static member create (nodes: IFunBlazorNode list) = nodes |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentTab>
    static member create (node: IFunBlazorNode) = [ node ] |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentTab>
    static member create (x: string) = [ html.text x ] |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentTab>
    static member ref x = attr.ref<Microsoft.Fast.Components.FluentUI.FluentTab> x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member additionalAttributes (x: System.Collections.Generic.IDictionary<System.String, System.Object>) = "AdditionalAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type fluentTabPanel<'FunBlazorGeneric> =
    
    static member create () = [] |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentTabPanel>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentTabPanel>
    static member create (nodes: IFunBlazorNode list) = nodes |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentTabPanel>
    static member create (node: IFunBlazorNode) = [ node ] |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentTabPanel>
    static member create (x: string) = [ html.text x ] |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentTabPanel>
    static member ref x = attr.ref<Microsoft.Fast.Components.FluentUI.FluentTabPanel> x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member additionalAttributes (x: System.Collections.Generic.IDictionary<System.String, System.Object>) = "AdditionalAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type fluentTabs<'FunBlazorGeneric> =
    
    static member create () = [] |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentTabs>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentTabs>
    static member create (nodes: IFunBlazorNode list) = nodes |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentTabs>
    static member create (node: IFunBlazorNode) = [ node ] |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentTabs>
    static member create (x: string) = [ html.text x ] |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentTabs>
    static member ref x = attr.ref<Microsoft.Fast.Components.FluentUI.FluentTabs> x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member activeIndicator (x: System.Nullable<System.Boolean>) = "ActiveIndicator" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member orientation (x: System.Nullable<Microsoft.Fast.Components.FluentUI.Orientation>) = "Orientation" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member additionalAttributes (x: System.Collections.Generic.IDictionary<System.String, System.Object>) = "AdditionalAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type fluentToolbar<'FunBlazorGeneric> =
    
    static member create () = [] |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentToolbar>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentToolbar>
    static member create (nodes: IFunBlazorNode list) = nodes |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentToolbar>
    static member create (node: IFunBlazorNode) = [ node ] |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentToolbar>
    static member create (x: string) = [ html.text x ] |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentToolbar>
    static member ref x = attr.ref<Microsoft.Fast.Components.FluentUI.FluentToolbar> x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member orientation (x: System.Nullable<Microsoft.Fast.Components.FluentUI.Orientation>) = "Orientation" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member additionalAttributes (x: System.Collections.Generic.IDictionary<System.String, System.Object>) = "AdditionalAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type fluentTooltip<'FunBlazorGeneric> =
    
    static member create () = [] |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentTooltip>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentTooltip>
    static member create (nodes: IFunBlazorNode list) = nodes |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentTooltip>
    static member create (node: IFunBlazorNode) = [ node ] |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentTooltip>
    static member create (x: string) = [ html.text x ] |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentTooltip>
    static member ref x = attr.ref<Microsoft.Fast.Components.FluentUI.FluentTooltip> x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member anchor (x: System.String) = "Anchor" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member position (x: System.Nullable<Microsoft.Fast.Components.FluentUI.TooltipPosition>) = "Position" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member delay (x: System.Nullable<System.Int32>) = "Delay" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member visible (x: System.Nullable<System.Boolean>) = "Visible" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member horizontalViewportLock (x: System.Nullable<System.Boolean>) = "HorizontalViewportLock" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member verticalViewportLock (x: System.Nullable<System.Boolean>) = "VerticalViewportLock" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member additionalAttributes (x: System.Collections.Generic.IDictionary<System.String, System.Object>) = "AdditionalAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type fluentTreeItem<'FunBlazorGeneric> =
    
    static member create () = [] |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentTreeItem>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentTreeItem>
    static member create (nodes: IFunBlazorNode list) = nodes |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentTreeItem>
    static member create (node: IFunBlazorNode) = [ node ] |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentTreeItem>
    static member create (x: string) = [ html.text x ] |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentTreeItem>
    static member ref x = attr.ref<Microsoft.Fast.Components.FluentUI.FluentTreeItem> x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member disabled (x: System.Nullable<System.Boolean>) = "Disabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member selected (x: System.Nullable<System.Boolean>) = "Selected" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member expanded (x: System.Nullable<System.Boolean>) = "Expanded" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member additionalAttributes (x: System.Collections.Generic.IDictionary<System.String, System.Object>) = "AdditionalAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type fluentTreeView<'FunBlazorGeneric> =
    
    static member create () = [] |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentTreeView>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentTreeView>
    static member create (nodes: IFunBlazorNode list) = nodes |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentTreeView>
    static member create (node: IFunBlazorNode) = [ node ] |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentTreeView>
    static member create (x: string) = [ html.text x ] |> html.blazor<Microsoft.Fast.Components.FluentUI.FluentTreeView>
    static member ref x = attr.ref<Microsoft.Fast.Components.FluentUI.FluentTreeView> x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member renderCollapsedNodes (x: System.Nullable<System.Boolean>) = "RenderCollapsedNodes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member additionalAttributes (x: System.Collections.Generic.IDictionary<System.String, System.Object>) = "AdditionalAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    
            

// =======================================================================================================================

namespace Microsoft.Fast.Components.FluentUI

open Microsoft.Fast.Components.FluentUI.DslInternals


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
                    

type IFluentNumberFieldNode<'TValue> = interface end
type fluentNumberField<'TValue> =
    class
        inherit fluentNumberField<IFluentNumberFieldNode<'TValue>, 'TValue>
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
                    

type IFluentAnchoredRegionNode = interface end
type fluentAnchoredRegion =
    class
        inherit fluentAnchoredRegion<IFluentAnchoredRegionNode>
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
                    

type IFluentDataGridNode<'TItem> = interface end
type fluentDataGrid<'TItem> =
    class
        inherit fluentDataGrid<IFluentDataGridNode<'TItem>, 'TItem>
    end
                    

type IFluentDataGridCellNode = interface end
type fluentDataGridCell =
    class
        inherit fluentDataGridCell<IFluentDataGridCellNode>
    end
                    

type IFluentDataGridRowNode<'TItem> = interface end
type fluentDataGridRow<'TItem> =
    class
        inherit fluentDataGridRow<IFluentDataGridRowNode<'TItem>, 'TItem>
    end
                    

type IFluentDesignSystemProviderNode = interface end
type fluentDesignSystemProvider =
    class
        inherit fluentDesignSystemProvider<IFluentDesignSystemProviderNode>
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
                    

type IFluentHorizontalScrollNode = interface end
type fluentHorizontalScroll =
    class
        inherit fluentHorizontalScroll<IFluentHorizontalScrollNode>
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
                    

type IFluentToolbarNode = interface end
type fluentToolbar =
    class
        inherit fluentToolbar<IFluentToolbarNode>
    end
                    

type IFluentTooltipNode = interface end
type fluentTooltip =
    class
        inherit fluentTooltip<IFluentTooltipNode>
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
                    
            