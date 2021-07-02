namespace rec Microsoft.Fast.Components.FluentUI.DslInternals

open Bolero.Html
open Fun.Blazor
open Fun.Blazor.Web.DslInternals
open Microsoft.Fast.Components.FluentUI.DslInternals


type FluentDesignSystemProviderBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContextWithAttrs<'FunBlazorGeneric>()
    new (x: string) as this = FluentDesignSystemProviderBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = FluentDesignSystemProviderBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    
    member this.Yield _ = FluentDesignSystemProviderBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ref'")>] member this.ref' (_: FunBlazorContext<Microsoft.Fast.Components.FluentUI.FluentDesignSystemProvider>, x) = attr.ref<Microsoft.Fast.Components.FluentUI.FluentDesignSystemProvider> x |> this.AddProp

                

type FluentInputBaseBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContextWithAttrs<'FunBlazorGeneric>()

    
    member this.Yield _ = FluentInputBaseBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ref'")>] member this.ref' (_: FunBlazorContext<Microsoft.Fast.Components.FluentUI.FluentInputBase<'TValue>>, x) = attr.ref<Microsoft.Fast.Components.FluentUI.FluentInputBase<'TValue>> x |> this.AddProp
    [<CustomOperation("value")>] member this.value (_: FunBlazorContext<Microsoft.Fast.Components.FluentUI.FluentInputBase<'TValue>>, x: 'TValue) = "Value" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("valueChanged")>] member this.valueChanged (_: FunBlazorContext<Microsoft.Fast.Components.FluentUI.FluentInputBase<'TValue>>, fn) = (Bolero.Html.attr.callback<'TValue> "ValueChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("valueExpression")>] member this.valueExpression (_: FunBlazorContext<Microsoft.Fast.Components.FluentUI.FluentInputBase<'TValue>>, x: System.Linq.Expressions.Expression<System.Func<'TValue>>) = "ValueExpression" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("displayName")>] member this.displayName (_: FunBlazorContext<Microsoft.Fast.Components.FluentUI.FluentInputBase<'TValue>>, x: System.String) = "DisplayName" => x |> BoleroAttr |> this.AddProp
                

type FluentCheckboxBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContextWithAttrs<'FunBlazorGeneric>()
    new (x: string) as this = FluentCheckboxBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = FluentCheckboxBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    
    member this.Yield _ = FluentCheckboxBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ref'")>] member this.ref' (_: FunBlazorContext<Microsoft.Fast.Components.FluentUI.FluentCheckbox>, x) = attr.ref<Microsoft.Fast.Components.FluentUI.FluentCheckbox> x |> this.AddProp
    [<CustomOperation("href")>] member this.href (_: FunBlazorContext<Microsoft.Fast.Components.FluentUI.FluentCheckbox>, x: System.String) = "Href" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("disabled")>] member this.disabled (_: FunBlazorContext<Microsoft.Fast.Components.FluentUI.FluentCheckbox>, x: System.Nullable<System.Boolean>) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("required")>] member this.required (_: FunBlazorContext<Microsoft.Fast.Components.FluentUI.FluentCheckbox>, x: System.Nullable<System.Boolean>) = "Required" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("value")>] member this.value (_: FunBlazorContext<Microsoft.Fast.Components.FluentUI.FluentCheckbox>, x: System.Boolean) = "Value" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("valueChanged")>] member this.valueChanged (_: FunBlazorContext<Microsoft.Fast.Components.FluentUI.FluentCheckbox>, fn) = (Bolero.Html.attr.callback<System.Boolean> "ValueChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("valueExpression")>] member this.valueExpression (_: FunBlazorContext<Microsoft.Fast.Components.FluentUI.FluentCheckbox>, x: System.Linq.Expressions.Expression<System.Func<System.Boolean>>) = "ValueExpression" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("displayName")>] member this.displayName (_: FunBlazorContext<Microsoft.Fast.Components.FluentUI.FluentCheckbox>, x: System.String) = "DisplayName" => x |> BoleroAttr |> this.AddProp
                

type FluentComboboxBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContextWithAttrs<'FunBlazorGeneric>()
    new (x: string) as this = FluentComboboxBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = FluentComboboxBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    
    member this.Yield _ = FluentComboboxBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ref'")>] member this.ref' (_: FunBlazorContext<Microsoft.Fast.Components.FluentUI.FluentCombobox>, x) = attr.ref<Microsoft.Fast.Components.FluentUI.FluentCombobox> x |> this.AddProp
    [<CustomOperation("filled")>] member this.filled (_: FunBlazorContext<Microsoft.Fast.Components.FluentUI.FluentCombobox>, x: System.Nullable<System.Boolean>) = "Filled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("disabled")>] member this.disabled (_: FunBlazorContext<Microsoft.Fast.Components.FluentUI.FluentCombobox>, x: System.Nullable<System.Boolean>) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("autocomplete")>] member this.autocomplete (_: FunBlazorContext<Microsoft.Fast.Components.FluentUI.FluentCombobox>, x: System.Nullable<Microsoft.Fast.Components.FluentUI.Autocomplete>) = "Autocomplete" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("position")>] member this.position (_: FunBlazorContext<Microsoft.Fast.Components.FluentUI.FluentCombobox>, x: System.Nullable<Microsoft.Fast.Components.FluentUI.Position>) = "Position" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("value")>] member this.value (_: FunBlazorContext<Microsoft.Fast.Components.FluentUI.FluentCombobox>, x: System.String) = "Value" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("valueChanged")>] member this.valueChanged (_: FunBlazorContext<Microsoft.Fast.Components.FluentUI.FluentCombobox>, fn) = (Bolero.Html.attr.callback<System.String> "ValueChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("valueExpression")>] member this.valueExpression (_: FunBlazorContext<Microsoft.Fast.Components.FluentUI.FluentCombobox>, x: System.Linq.Expressions.Expression<System.Func<System.String>>) = "ValueExpression" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("displayName")>] member this.displayName (_: FunBlazorContext<Microsoft.Fast.Components.FluentUI.FluentCombobox>, x: System.String) = "DisplayName" => x |> BoleroAttr |> this.AddProp
                

type FluentRadioGroupBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContextWithAttrs<'FunBlazorGeneric>()
    new (x: string) as this = FluentRadioGroupBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = FluentRadioGroupBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    
    member this.Yield _ = FluentRadioGroupBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ref'")>] member this.ref' (_: FunBlazorContext<Microsoft.Fast.Components.FluentUI.FluentRadioGroup>, x) = attr.ref<Microsoft.Fast.Components.FluentUI.FluentRadioGroup> x |> this.AddProp
    [<CustomOperation("name")>] member this.name (_: FunBlazorContext<Microsoft.Fast.Components.FluentUI.FluentRadioGroup>, x: System.String) = "Name" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("required")>] member this.required (_: FunBlazorContext<Microsoft.Fast.Components.FluentUI.FluentRadioGroup>, x: System.Nullable<System.Boolean>) = "Required" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("orientation")>] member this.orientation (_: FunBlazorContext<Microsoft.Fast.Components.FluentUI.FluentRadioGroup>, x: System.Nullable<Microsoft.Fast.Components.FluentUI.Orientation>) = "Orientation" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("value")>] member this.value (_: FunBlazorContext<Microsoft.Fast.Components.FluentUI.FluentRadioGroup>, x: System.String) = "Value" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("valueChanged")>] member this.valueChanged (_: FunBlazorContext<Microsoft.Fast.Components.FluentUI.FluentRadioGroup>, fn) = (Bolero.Html.attr.callback<System.String> "ValueChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("valueExpression")>] member this.valueExpression (_: FunBlazorContext<Microsoft.Fast.Components.FluentUI.FluentRadioGroup>, x: System.Linq.Expressions.Expression<System.Func<System.String>>) = "ValueExpression" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("displayName")>] member this.displayName (_: FunBlazorContext<Microsoft.Fast.Components.FluentUI.FluentRadioGroup>, x: System.String) = "DisplayName" => x |> BoleroAttr |> this.AddProp
                

type FluentSelectBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContextWithAttrs<'FunBlazorGeneric>()
    new (x: string) as this = FluentSelectBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = FluentSelectBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    
    member this.Yield _ = FluentSelectBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ref'")>] member this.ref' (_: FunBlazorContext<Microsoft.Fast.Components.FluentUI.FluentSelect>, x) = attr.ref<Microsoft.Fast.Components.FluentUI.FluentSelect> x |> this.AddProp
    [<CustomOperation("disabled")>] member this.disabled (_: FunBlazorContext<Microsoft.Fast.Components.FluentUI.FluentSelect>, x: System.Nullable<System.Boolean>) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("filled")>] member this.filled (_: FunBlazorContext<Microsoft.Fast.Components.FluentUI.FluentSelect>, x: System.Nullable<System.Boolean>) = "Filled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("name")>] member this.name (_: FunBlazorContext<Microsoft.Fast.Components.FluentUI.FluentSelect>, x: System.String) = "Name" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("position")>] member this.position (_: FunBlazorContext<Microsoft.Fast.Components.FluentUI.FluentSelect>, x: System.Nullable<Microsoft.Fast.Components.FluentUI.Position>) = "Position" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("value")>] member this.value (_: FunBlazorContext<Microsoft.Fast.Components.FluentUI.FluentSelect>, x: System.String) = "Value" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("valueChanged")>] member this.valueChanged (_: FunBlazorContext<Microsoft.Fast.Components.FluentUI.FluentSelect>, fn) = (Bolero.Html.attr.callback<System.String> "ValueChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("valueExpression")>] member this.valueExpression (_: FunBlazorContext<Microsoft.Fast.Components.FluentUI.FluentSelect>, x: System.Linq.Expressions.Expression<System.Func<System.String>>) = "ValueExpression" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("displayName")>] member this.displayName (_: FunBlazorContext<Microsoft.Fast.Components.FluentUI.FluentSelect>, x: System.String) = "DisplayName" => x |> BoleroAttr |> this.AddProp
                

type FluentSliderBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContextWithAttrs<'FunBlazorGeneric>()
    new (x: string) as this = FluentSliderBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = FluentSliderBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    
    member this.Yield _ = FluentSliderBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ref'")>] member this.ref' (_: FunBlazorContext<Microsoft.Fast.Components.FluentUI.FluentSlider>, x) = attr.ref<Microsoft.Fast.Components.FluentUI.FluentSlider> x |> this.AddProp
    [<CustomOperation("orientation")>] member this.orientation (_: FunBlazorContext<Microsoft.Fast.Components.FluentUI.FluentSlider>, x: System.Nullable<Microsoft.Fast.Components.FluentUI.Orientation>) = "Orientation" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("min'")>] member this.min' (_: FunBlazorContext<Microsoft.Fast.Components.FluentUI.FluentSlider>, x: System.Nullable<System.Int32>) = "Min" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("max'")>] member this.max' (_: FunBlazorContext<Microsoft.Fast.Components.FluentUI.FluentSlider>, x: System.Nullable<System.Int32>) = "Max" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("step")>] member this.step (_: FunBlazorContext<Microsoft.Fast.Components.FluentUI.FluentSlider>, x: System.Nullable<System.Int32>) = "Step" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("disabled")>] member this.disabled (_: FunBlazorContext<Microsoft.Fast.Components.FluentUI.FluentSlider>, x: System.Nullable<System.Boolean>) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("readonly")>] member this.readonly (_: FunBlazorContext<Microsoft.Fast.Components.FluentUI.FluentSlider>, x: System.Nullable<System.Boolean>) = "Readonly" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("value")>] member this.value (_: FunBlazorContext<Microsoft.Fast.Components.FluentUI.FluentSlider>, x: System.Int32) = "Value" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("valueChanged")>] member this.valueChanged (_: FunBlazorContext<Microsoft.Fast.Components.FluentUI.FluentSlider>, fn) = (Bolero.Html.attr.callback<System.Int32> "ValueChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("valueExpression")>] member this.valueExpression (_: FunBlazorContext<Microsoft.Fast.Components.FluentUI.FluentSlider>, x: System.Linq.Expressions.Expression<System.Func<System.Int32>>) = "ValueExpression" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("displayName")>] member this.displayName (_: FunBlazorContext<Microsoft.Fast.Components.FluentUI.FluentSlider>, x: System.String) = "DisplayName" => x |> BoleroAttr |> this.AddProp
                

type FluentTextAreaBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContextWithAttrs<'FunBlazorGeneric>()
    new (x: string) as this = FluentTextAreaBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = FluentTextAreaBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    
    member this.Yield _ = FluentTextAreaBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ref'")>] member this.ref' (_: FunBlazorContext<Microsoft.Fast.Components.FluentUI.FluentTextArea>, x) = attr.ref<Microsoft.Fast.Components.FluentUI.FluentTextArea> x |> this.AddProp
    [<CustomOperation("disabled")>] member this.disabled (_: FunBlazorContext<Microsoft.Fast.Components.FluentUI.FluentTextArea>, x: System.Nullable<System.Boolean>) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("readonly")>] member this.readonly (_: FunBlazorContext<Microsoft.Fast.Components.FluentUI.FluentTextArea>, x: System.Nullable<System.Boolean>) = "Readonly" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("required")>] member this.required (_: FunBlazorContext<Microsoft.Fast.Components.FluentUI.FluentTextArea>, x: System.Nullable<System.Boolean>) = "Required" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("autofocus")>] member this.autofocus (_: FunBlazorContext<Microsoft.Fast.Components.FluentUI.FluentTextArea>, x: System.Nullable<System.Boolean>) = "Autofocus" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("resize")>] member this.resize (_: FunBlazorContext<Microsoft.Fast.Components.FluentUI.FluentTextArea>, x: System.Nullable<Microsoft.Fast.Components.FluentUI.Resize>) = "Resize" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("appearance")>] member this.appearance (_: FunBlazorContext<Microsoft.Fast.Components.FluentUI.FluentTextArea>, x: System.Nullable<Microsoft.Fast.Components.FluentUI.Appearance>) = "Appearance" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("placeholder")>] member this.placeholder (_: FunBlazorContext<Microsoft.Fast.Components.FluentUI.FluentTextArea>, x: System.String) = "Placeholder" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("value")>] member this.value (_: FunBlazorContext<Microsoft.Fast.Components.FluentUI.FluentTextArea>, x: System.String) = "Value" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("valueChanged")>] member this.valueChanged (_: FunBlazorContext<Microsoft.Fast.Components.FluentUI.FluentTextArea>, fn) = (Bolero.Html.attr.callback<System.String> "ValueChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("valueExpression")>] member this.valueExpression (_: FunBlazorContext<Microsoft.Fast.Components.FluentUI.FluentTextArea>, x: System.Linq.Expressions.Expression<System.Func<System.String>>) = "ValueExpression" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("displayName")>] member this.displayName (_: FunBlazorContext<Microsoft.Fast.Components.FluentUI.FluentTextArea>, x: System.String) = "DisplayName" => x |> BoleroAttr |> this.AddProp
                

type FluentTextFieldBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContextWithAttrs<'FunBlazorGeneric>()
    new (x: string) as this = FluentTextFieldBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = FluentTextFieldBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    
    member this.Yield _ = FluentTextFieldBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ref'")>] member this.ref' (_: FunBlazorContext<Microsoft.Fast.Components.FluentUI.FluentTextField>, x) = attr.ref<Microsoft.Fast.Components.FluentUI.FluentTextField> x |> this.AddProp
    [<CustomOperation("disabled")>] member this.disabled (_: FunBlazorContext<Microsoft.Fast.Components.FluentUI.FluentTextField>, x: System.Nullable<System.Boolean>) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("readonly")>] member this.readonly (_: FunBlazorContext<Microsoft.Fast.Components.FluentUI.FluentTextField>, x: System.Nullable<System.Boolean>) = "Readonly" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("required")>] member this.required (_: FunBlazorContext<Microsoft.Fast.Components.FluentUI.FluentTextField>, x: System.Nullable<System.Boolean>) = "Required" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("autofocus")>] member this.autofocus (_: FunBlazorContext<Microsoft.Fast.Components.FluentUI.FluentTextField>, x: System.Nullable<System.Boolean>) = "Autofocus" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("resize")>] member this.resize (_: FunBlazorContext<Microsoft.Fast.Components.FluentUI.FluentTextField>, x: System.Nullable<Microsoft.Fast.Components.FluentUI.Resize>) = "Resize" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("appearance")>] member this.appearance (_: FunBlazorContext<Microsoft.Fast.Components.FluentUI.FluentTextField>, x: System.Nullable<Microsoft.Fast.Components.FluentUI.Appearance>) = "Appearance" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("placeholder")>] member this.placeholder (_: FunBlazorContext<Microsoft.Fast.Components.FluentUI.FluentTextField>, x: System.String) = "Placeholder" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("value")>] member this.value (_: FunBlazorContext<Microsoft.Fast.Components.FluentUI.FluentTextField>, x: System.String) = "Value" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("valueChanged")>] member this.valueChanged (_: FunBlazorContext<Microsoft.Fast.Components.FluentUI.FluentTextField>, fn) = (Bolero.Html.attr.callback<System.String> "ValueChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("valueExpression")>] member this.valueExpression (_: FunBlazorContext<Microsoft.Fast.Components.FluentUI.FluentTextField>, x: System.Linq.Expressions.Expression<System.Func<System.String>>) = "ValueExpression" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("displayName")>] member this.displayName (_: FunBlazorContext<Microsoft.Fast.Components.FluentUI.FluentTextField>, x: System.String) = "DisplayName" => x |> BoleroAttr |> this.AddProp
                

type FluentAccordionBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContextWithAttrs<'FunBlazorGeneric>()
    new (x: string) as this = FluentAccordionBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = FluentAccordionBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    
    member this.Yield _ = FluentAccordionBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ref'")>] member this.ref' (_: FunBlazorContext<Microsoft.Fast.Components.FluentUI.FluentAccordion>, x) = attr.ref<Microsoft.Fast.Components.FluentUI.FluentAccordion> x |> this.AddProp
    [<CustomOperation("expandMode")>] member this.expandMode (_: FunBlazorContext<Microsoft.Fast.Components.FluentUI.FluentAccordion>, x: System.Nullable<Microsoft.Fast.Components.FluentUI.ExpandMode>) = "ExpandMode" => x |> BoleroAttr |> this.AddProp
                

type FluentAccordionItemBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContextWithAttrs<'FunBlazorGeneric>()
    new (x: string) as this = FluentAccordionItemBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = FluentAccordionItemBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    
    member this.Yield _ = FluentAccordionItemBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ref'")>] member this.ref' (_: FunBlazorContext<Microsoft.Fast.Components.FluentUI.FluentAccordionItem>, x) = attr.ref<Microsoft.Fast.Components.FluentUI.FluentAccordionItem> x |> this.AddProp
    [<CustomOperation("expanded")>] member this.expanded (_: FunBlazorContext<Microsoft.Fast.Components.FluentUI.FluentAccordionItem>, x: System.Nullable<System.Boolean>) = "Expanded" => x |> BoleroAttr |> this.AddProp
                

type FluentAnchorBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContextWithAttrs<'FunBlazorGeneric>()
    new (x: string) as this = FluentAnchorBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = FluentAnchorBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    
    member this.Yield _ = FluentAnchorBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ref'")>] member this.ref' (_: FunBlazorContext<Microsoft.Fast.Components.FluentUI.FluentAnchor>, x) = attr.ref<Microsoft.Fast.Components.FluentUI.FluentAnchor> x |> this.AddProp
    [<CustomOperation("href")>] member this.href (_: FunBlazorContext<Microsoft.Fast.Components.FluentUI.FluentAnchor>, x: System.String) = "Href" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("appearance")>] member this.appearance (_: FunBlazorContext<Microsoft.Fast.Components.FluentUI.FluentAnchor>, x: System.Nullable<Microsoft.Fast.Components.FluentUI.Appearance>) = "Appearance" => x |> BoleroAttr |> this.AddProp
                

type FluentBadgeBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContextWithAttrs<'FunBlazorGeneric>()
    new (x: string) as this = FluentBadgeBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = FluentBadgeBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    
    member this.Yield _ = FluentBadgeBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ref'")>] member this.ref' (_: FunBlazorContext<Microsoft.Fast.Components.FluentUI.FluentBadge>, x) = attr.ref<Microsoft.Fast.Components.FluentUI.FluentBadge> x |> this.AddProp
    [<CustomOperation("color")>] member this.color (_: FunBlazorContext<Microsoft.Fast.Components.FluentUI.FluentBadge>, x: System.Nullable<Microsoft.Fast.Components.FluentUI.Color>) = "Color" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("fill")>] member this.fill (_: FunBlazorContext<Microsoft.Fast.Components.FluentUI.FluentBadge>, x: System.Nullable<Microsoft.Fast.Components.FluentUI.Fill>) = "Fill" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("appearance")>] member this.appearance (_: FunBlazorContext<Microsoft.Fast.Components.FluentUI.FluentBadge>, x: System.Nullable<Microsoft.Fast.Components.FluentUI.Appearance>) = "Appearance" => x |> BoleroAttr |> this.AddProp
                

type FluentBreadcrumbBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContextWithAttrs<'FunBlazorGeneric>()
    new (x: string) as this = FluentBreadcrumbBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = FluentBreadcrumbBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    
    member this.Yield _ = FluentBreadcrumbBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ref'")>] member this.ref' (_: FunBlazorContext<Microsoft.Fast.Components.FluentUI.FluentBreadcrumb>, x) = attr.ref<Microsoft.Fast.Components.FluentUI.FluentBreadcrumb> x |> this.AddProp

                

type FluentBreadcrumbItemBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContextWithAttrs<'FunBlazorGeneric>()
    new (x: string) as this = FluentBreadcrumbItemBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = FluentBreadcrumbItemBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    
    member this.Yield _ = FluentBreadcrumbItemBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ref'")>] member this.ref' (_: FunBlazorContext<Microsoft.Fast.Components.FluentUI.FluentBreadcrumbItem>, x) = attr.ref<Microsoft.Fast.Components.FluentUI.FluentBreadcrumbItem> x |> this.AddProp
    [<CustomOperation("href")>] member this.href (_: FunBlazorContext<Microsoft.Fast.Components.FluentUI.FluentBreadcrumbItem>, x: System.String) = "Href" => x |> BoleroAttr |> this.AddProp
                

type FluentButtonBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContextWithAttrs<'FunBlazorGeneric>()
    new (x: string) as this = FluentButtonBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = FluentButtonBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    
    member this.Yield _ = FluentButtonBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ref'")>] member this.ref' (_: FunBlazorContext<Microsoft.Fast.Components.FluentUI.FluentButton>, x) = attr.ref<Microsoft.Fast.Components.FluentUI.FluentButton> x |> this.AddProp
    [<CustomOperation("appearance")>] member this.appearance (_: FunBlazorContext<Microsoft.Fast.Components.FluentUI.FluentButton>, x: System.Nullable<Microsoft.Fast.Components.FluentUI.Appearance>) = "Appearance" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("disabled")>] member this.disabled (_: FunBlazorContext<Microsoft.Fast.Components.FluentUI.FluentButton>, x: System.Nullable<System.Boolean>) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("autofocus")>] member this.autofocus (_: FunBlazorContext<Microsoft.Fast.Components.FluentUI.FluentButton>, x: System.Nullable<System.Boolean>) = "Autofocus" => x |> BoleroAttr |> this.AddProp
                

type FluentCardBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContextWithAttrs<'FunBlazorGeneric>()
    new (x: string) as this = FluentCardBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = FluentCardBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    
    member this.Yield _ = FluentCardBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ref'")>] member this.ref' (_: FunBlazorContext<Microsoft.Fast.Components.FluentUI.FluentCard>, x) = attr.ref<Microsoft.Fast.Components.FluentUI.FluentCard> x |> this.AddProp

                

type FluentDialogBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContextWithAttrs<'FunBlazorGeneric>()
    new (x: string) as this = FluentDialogBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = FluentDialogBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    
    member this.Yield _ = FluentDialogBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ref'")>] member this.ref' (_: FunBlazorContext<Microsoft.Fast.Components.FluentUI.FluentDialog>, x) = attr.ref<Microsoft.Fast.Components.FluentUI.FluentDialog> x |> this.AddProp
    [<CustomOperation("modal")>] member this.modal (_: FunBlazorContext<Microsoft.Fast.Components.FluentUI.FluentDialog>, x: System.Nullable<System.Boolean>) = "Modal" => x |> BoleroAttr |> this.AddProp
                

type FluentDividerBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContextWithAttrs<'FunBlazorGeneric>()
    new (x: string) as this = FluentDividerBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = FluentDividerBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    
    member this.Yield _ = FluentDividerBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ref'")>] member this.ref' (_: FunBlazorContext<Microsoft.Fast.Components.FluentUI.FluentDivider>, x) = attr.ref<Microsoft.Fast.Components.FluentUI.FluentDivider> x |> this.AddProp

                

type FluentFlipperBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContextWithAttrs<'FunBlazorGeneric>()
    new (x: string) as this = FluentFlipperBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = FluentFlipperBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    
    member this.Yield _ = FluentFlipperBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ref'")>] member this.ref' (_: FunBlazorContext<Microsoft.Fast.Components.FluentUI.FluentFlipper>, x) = attr.ref<Microsoft.Fast.Components.FluentUI.FluentFlipper> x |> this.AddProp
    [<CustomOperation("disabled")>] member this.disabled (_: FunBlazorContext<Microsoft.Fast.Components.FluentUI.FluentFlipper>, x: System.Nullable<System.Boolean>) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("direction")>] member this.direction (_: FunBlazorContext<Microsoft.Fast.Components.FluentUI.FluentFlipper>, x: System.Nullable<Microsoft.Fast.Components.FluentUI.Direction>) = "Direction" => x |> BoleroAttr |> this.AddProp
                

type FluentListboxBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContextWithAttrs<'FunBlazorGeneric>()
    new (x: string) as this = FluentListboxBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = FluentListboxBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    
    member this.Yield _ = FluentListboxBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ref'")>] member this.ref' (_: FunBlazorContext<Microsoft.Fast.Components.FluentUI.FluentListbox>, x) = attr.ref<Microsoft.Fast.Components.FluentUI.FluentListbox> x |> this.AddProp

                

type FluentMenuBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContextWithAttrs<'FunBlazorGeneric>()
    new (x: string) as this = FluentMenuBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = FluentMenuBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    
    member this.Yield _ = FluentMenuBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ref'")>] member this.ref' (_: FunBlazorContext<Microsoft.Fast.Components.FluentUI.FluentMenu>, x) = attr.ref<Microsoft.Fast.Components.FluentUI.FluentMenu> x |> this.AddProp

                

type FluentMenuItemBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContextWithAttrs<'FunBlazorGeneric>()
    new (x: string) as this = FluentMenuItemBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = FluentMenuItemBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    
    member this.Yield _ = FluentMenuItemBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ref'")>] member this.ref' (_: FunBlazorContext<Microsoft.Fast.Components.FluentUI.FluentMenuItem>, x) = attr.ref<Microsoft.Fast.Components.FluentUI.FluentMenuItem> x |> this.AddProp
    [<CustomOperation("disabled")>] member this.disabled (_: FunBlazorContext<Microsoft.Fast.Components.FluentUI.FluentMenuItem>, x: System.Nullable<System.Boolean>) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("checked'")>] member this.checked' (_: FunBlazorContext<Microsoft.Fast.Components.FluentUI.FluentMenuItem>, x: System.Nullable<System.Boolean>) = "Checked" => x |> BoleroAttr |> this.AddProp
                

type FluentOptionBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContextWithAttrs<'FunBlazorGeneric>()
    new (x: string) as this = FluentOptionBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = FluentOptionBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    
    member this.Yield _ = FluentOptionBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ref'")>] member this.ref' (_: FunBlazorContext<Microsoft.Fast.Components.FluentUI.FluentOption>, x) = attr.ref<Microsoft.Fast.Components.FluentUI.FluentOption> x |> this.AddProp
    [<CustomOperation("disabled")>] member this.disabled (_: FunBlazorContext<Microsoft.Fast.Components.FluentUI.FluentOption>, x: System.Nullable<System.Boolean>) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("value")>] member this.value (_: FunBlazorContext<Microsoft.Fast.Components.FluentUI.FluentOption>, x: System.String) = "Value" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("selected")>] member this.selected (_: FunBlazorContext<Microsoft.Fast.Components.FluentUI.FluentOption>, x: System.Nullable<System.Boolean>) = "Selected" => x |> BoleroAttr |> this.AddProp
                

type FluentProgressBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContextWithAttrs<'FunBlazorGeneric>()
    new (x: string) as this = FluentProgressBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = FluentProgressBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    
    member this.Yield _ = FluentProgressBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ref'")>] member this.ref' (_: FunBlazorContext<Microsoft.Fast.Components.FluentUI.FluentProgress>, x) = attr.ref<Microsoft.Fast.Components.FluentUI.FluentProgress> x |> this.AddProp
    [<CustomOperation("min'")>] member this.min' (_: FunBlazorContext<Microsoft.Fast.Components.FluentUI.FluentProgress>, x: System.Nullable<System.Int32>) = "Min" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("max'")>] member this.max' (_: FunBlazorContext<Microsoft.Fast.Components.FluentUI.FluentProgress>, x: System.Nullable<System.Int32>) = "Max" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("value")>] member this.value (_: FunBlazorContext<Microsoft.Fast.Components.FluentUI.FluentProgress>, x: System.String) = "Value" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("paused")>] member this.paused (_: FunBlazorContext<Microsoft.Fast.Components.FluentUI.FluentProgress>, x: System.Nullable<System.Boolean>) = "Paused" => x |> BoleroAttr |> this.AddProp
                

type FluentProgressRingBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContextWithAttrs<'FunBlazorGeneric>()
    new (x: string) as this = FluentProgressRingBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = FluentProgressRingBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    
    member this.Yield _ = FluentProgressRingBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ref'")>] member this.ref' (_: FunBlazorContext<Microsoft.Fast.Components.FluentUI.FluentProgressRing>, x) = attr.ref<Microsoft.Fast.Components.FluentUI.FluentProgressRing> x |> this.AddProp
    [<CustomOperation("min'")>] member this.min' (_: FunBlazorContext<Microsoft.Fast.Components.FluentUI.FluentProgressRing>, x: System.Nullable<System.Int32>) = "Min" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("max'")>] member this.max' (_: FunBlazorContext<Microsoft.Fast.Components.FluentUI.FluentProgressRing>, x: System.Nullable<System.Int32>) = "Max" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("value")>] member this.value (_: FunBlazorContext<Microsoft.Fast.Components.FluentUI.FluentProgressRing>, x: System.String) = "Value" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("paused")>] member this.paused (_: FunBlazorContext<Microsoft.Fast.Components.FluentUI.FluentProgressRing>, x: System.Nullable<System.Boolean>) = "Paused" => x |> BoleroAttr |> this.AddProp
                

type FluentRadioBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContextWithAttrs<'FunBlazorGeneric>()
    new (x: string) as this = FluentRadioBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = FluentRadioBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    
    member this.Yield _ = FluentRadioBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ref'")>] member this.ref' (_: FunBlazorContext<Microsoft.Fast.Components.FluentUI.FluentRadio>, x) = attr.ref<Microsoft.Fast.Components.FluentUI.FluentRadio> x |> this.AddProp
    [<CustomOperation("value")>] member this.value (_: FunBlazorContext<Microsoft.Fast.Components.FluentUI.FluentRadio>, x: System.String) = "Value" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("required")>] member this.required (_: FunBlazorContext<Microsoft.Fast.Components.FluentUI.FluentRadio>, x: System.Nullable<System.Boolean>) = "Required" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("disabled")>] member this.disabled (_: FunBlazorContext<Microsoft.Fast.Components.FluentUI.FluentRadio>, x: System.Nullable<System.Boolean>) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("checked'")>] member this.checked' (_: FunBlazorContext<Microsoft.Fast.Components.FluentUI.FluentRadio>, x: System.Nullable<System.Boolean>) = "Checked" => x |> BoleroAttr |> this.AddProp
                

type FluentSkeletonBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContextWithAttrs<'FunBlazorGeneric>()
    new (x: string) as this = FluentSkeletonBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = FluentSkeletonBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    
    member this.Yield _ = FluentSkeletonBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ref'")>] member this.ref' (_: FunBlazorContext<Microsoft.Fast.Components.FluentUI.FluentSkeleton>, x) = attr.ref<Microsoft.Fast.Components.FluentUI.FluentSkeleton> x |> this.AddProp
    [<CustomOperation("shape'")>] member this.shape' (_: FunBlazorContext<Microsoft.Fast.Components.FluentUI.FluentSkeleton>, x: System.Nullable<Microsoft.Fast.Components.FluentUI.Shape>) = "Shape" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("shimmer")>] member this.shimmer (_: FunBlazorContext<Microsoft.Fast.Components.FluentUI.FluentSkeleton>, x: System.Nullable<System.Boolean>) = "Shimmer" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("pattern")>] member this.pattern (_: FunBlazorContext<Microsoft.Fast.Components.FluentUI.FluentSkeleton>, x: System.String) = "Pattern" => x |> BoleroAttr |> this.AddProp
                

type FluentSliderLabelBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContextWithAttrs<'FunBlazorGeneric>()
    new (x: string) as this = FluentSliderLabelBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = FluentSliderLabelBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    
    member this.Yield _ = FluentSliderLabelBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ref'")>] member this.ref' (_: FunBlazorContext<Microsoft.Fast.Components.FluentUI.FluentSliderLabel>, x) = attr.ref<Microsoft.Fast.Components.FluentUI.FluentSliderLabel> x |> this.AddProp
    [<CustomOperation("position")>] member this.position (_: FunBlazorContext<Microsoft.Fast.Components.FluentUI.FluentSliderLabel>, x: System.Nullable<System.Int32>) = "Position" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("hideMark")>] member this.hideMark (_: FunBlazorContext<Microsoft.Fast.Components.FluentUI.FluentSliderLabel>, x: System.Nullable<System.Boolean>) = "HideMark" => x |> BoleroAttr |> this.AddProp
                

type FluentSwitchBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContextWithAttrs<'FunBlazorGeneric>()
    new (x: string) as this = FluentSwitchBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = FluentSwitchBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    
    member this.Yield _ = FluentSwitchBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ref'")>] member this.ref' (_: FunBlazorContext<Microsoft.Fast.Components.FluentUI.FluentSwitch>, x) = attr.ref<Microsoft.Fast.Components.FluentUI.FluentSwitch> x |> this.AddProp
    [<CustomOperation("disabled")>] member this.disabled (_: FunBlazorContext<Microsoft.Fast.Components.FluentUI.FluentSwitch>, x: System.Nullable<System.Boolean>) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("checked'")>] member this.checked' (_: FunBlazorContext<Microsoft.Fast.Components.FluentUI.FluentSwitch>, x: System.Nullable<System.Boolean>) = "Checked" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("required")>] member this.required (_: FunBlazorContext<Microsoft.Fast.Components.FluentUI.FluentSwitch>, x: System.Nullable<System.Boolean>) = "Required" => x |> BoleroAttr |> this.AddProp
                

type FluentTabBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContextWithAttrs<'FunBlazorGeneric>()
    new (x: string) as this = FluentTabBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = FluentTabBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    
    member this.Yield _ = FluentTabBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ref'")>] member this.ref' (_: FunBlazorContext<Microsoft.Fast.Components.FluentUI.FluentTab>, x) = attr.ref<Microsoft.Fast.Components.FluentUI.FluentTab> x |> this.AddProp

                

type FluentTabPanelBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContextWithAttrs<'FunBlazorGeneric>()
    new (x: string) as this = FluentTabPanelBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = FluentTabPanelBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    
    member this.Yield _ = FluentTabPanelBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ref'")>] member this.ref' (_: FunBlazorContext<Microsoft.Fast.Components.FluentUI.FluentTabPanel>, x) = attr.ref<Microsoft.Fast.Components.FluentUI.FluentTabPanel> x |> this.AddProp

                

type FluentTabsBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContextWithAttrs<'FunBlazorGeneric>()
    new (x: string) as this = FluentTabsBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = FluentTabsBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    
    member this.Yield _ = FluentTabsBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ref'")>] member this.ref' (_: FunBlazorContext<Microsoft.Fast.Components.FluentUI.FluentTabs>, x) = attr.ref<Microsoft.Fast.Components.FluentUI.FluentTabs> x |> this.AddProp
    [<CustomOperation("activeIndicator")>] member this.activeIndicator (_: FunBlazorContext<Microsoft.Fast.Components.FluentUI.FluentTabs>, x: System.Nullable<System.Boolean>) = "ActiveIndicator" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("orientation")>] member this.orientation (_: FunBlazorContext<Microsoft.Fast.Components.FluentUI.FluentTabs>, x: System.Nullable<Microsoft.Fast.Components.FluentUI.Orientation>) = "Orientation" => x |> BoleroAttr |> this.AddProp
                

type FluentTreeItemBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContextWithAttrs<'FunBlazorGeneric>()
    new (x: string) as this = FluentTreeItemBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = FluentTreeItemBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    
    member this.Yield _ = FluentTreeItemBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ref'")>] member this.ref' (_: FunBlazorContext<Microsoft.Fast.Components.FluentUI.FluentTreeItem>, x) = attr.ref<Microsoft.Fast.Components.FluentUI.FluentTreeItem> x |> this.AddProp
    [<CustomOperation("disabled")>] member this.disabled (_: FunBlazorContext<Microsoft.Fast.Components.FluentUI.FluentTreeItem>, x: System.Nullable<System.Boolean>) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("selected")>] member this.selected (_: FunBlazorContext<Microsoft.Fast.Components.FluentUI.FluentTreeItem>, x: System.Nullable<System.Boolean>) = "Selected" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("expanded")>] member this.expanded (_: FunBlazorContext<Microsoft.Fast.Components.FluentUI.FluentTreeItem>, x: System.Nullable<System.Boolean>) = "Expanded" => x |> BoleroAttr |> this.AddProp
                

type FluentTreeViewBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContextWithAttrs<'FunBlazorGeneric>()
    new (x: string) as this = FluentTreeViewBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = FluentTreeViewBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    
    member this.Yield _ = FluentTreeViewBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ref'")>] member this.ref' (_: FunBlazorContext<Microsoft.Fast.Components.FluentUI.FluentTreeView>, x) = attr.ref<Microsoft.Fast.Components.FluentUI.FluentTreeView> x |> this.AddProp
    [<CustomOperation("renderCollapsedNodes")>] member this.renderCollapsedNodes (_: FunBlazorContext<Microsoft.Fast.Components.FluentUI.FluentTreeView>, x: System.Nullable<System.Boolean>) = "RenderCollapsedNodes" => x |> BoleroAttr |> this.AddProp
                
            

// =======================================================================================================================

namespace Microsoft.Fast.Components.FluentUI

[<AutoOpen>]
module DslCE =

    open Microsoft.Fast.Components.FluentUI.DslInternals

    type fluentDesignSystemProvider = FluentDesignSystemProviderBuilder<Microsoft.Fast.Components.FluentUI.FluentDesignSystemProvider>
    type fluentInputBase<'TValue> = FluentInputBaseBuilder<Microsoft.Fast.Components.FluentUI.FluentInputBase<'TValue>>
    type fluentCheckbox = FluentCheckboxBuilder<Microsoft.Fast.Components.FluentUI.FluentCheckbox>
    type fluentCombobox = FluentComboboxBuilder<Microsoft.Fast.Components.FluentUI.FluentCombobox>
    type fluentRadioGroup = FluentRadioGroupBuilder<Microsoft.Fast.Components.FluentUI.FluentRadioGroup>
    type fluentSelect = FluentSelectBuilder<Microsoft.Fast.Components.FluentUI.FluentSelect>
    type fluentSlider = FluentSliderBuilder<Microsoft.Fast.Components.FluentUI.FluentSlider>
    type fluentTextArea = FluentTextAreaBuilder<Microsoft.Fast.Components.FluentUI.FluentTextArea>
    type fluentTextField = FluentTextFieldBuilder<Microsoft.Fast.Components.FluentUI.FluentTextField>
    type fluentAccordion = FluentAccordionBuilder<Microsoft.Fast.Components.FluentUI.FluentAccordion>
    type fluentAccordionItem = FluentAccordionItemBuilder<Microsoft.Fast.Components.FluentUI.FluentAccordionItem>
    type fluentAnchor = FluentAnchorBuilder<Microsoft.Fast.Components.FluentUI.FluentAnchor>
    type fluentBadge = FluentBadgeBuilder<Microsoft.Fast.Components.FluentUI.FluentBadge>
    type fluentBreadcrumb = FluentBreadcrumbBuilder<Microsoft.Fast.Components.FluentUI.FluentBreadcrumb>
    type fluentBreadcrumbItem = FluentBreadcrumbItemBuilder<Microsoft.Fast.Components.FluentUI.FluentBreadcrumbItem>
    type fluentButton = FluentButtonBuilder<Microsoft.Fast.Components.FluentUI.FluentButton>
    type fluentCard = FluentCardBuilder<Microsoft.Fast.Components.FluentUI.FluentCard>
    type fluentDialog = FluentDialogBuilder<Microsoft.Fast.Components.FluentUI.FluentDialog>
    type fluentDivider = FluentDividerBuilder<Microsoft.Fast.Components.FluentUI.FluentDivider>
    type fluentFlipper = FluentFlipperBuilder<Microsoft.Fast.Components.FluentUI.FluentFlipper>
    type fluentListbox = FluentListboxBuilder<Microsoft.Fast.Components.FluentUI.FluentListbox>
    type fluentMenu = FluentMenuBuilder<Microsoft.Fast.Components.FluentUI.FluentMenu>
    type fluentMenuItem = FluentMenuItemBuilder<Microsoft.Fast.Components.FluentUI.FluentMenuItem>
    type fluentOption = FluentOptionBuilder<Microsoft.Fast.Components.FluentUI.FluentOption>
    type fluentProgress = FluentProgressBuilder<Microsoft.Fast.Components.FluentUI.FluentProgress>
    type fluentProgressRing = FluentProgressRingBuilder<Microsoft.Fast.Components.FluentUI.FluentProgressRing>
    type fluentRadio = FluentRadioBuilder<Microsoft.Fast.Components.FluentUI.FluentRadio>
    type fluentSkeleton = FluentSkeletonBuilder<Microsoft.Fast.Components.FluentUI.FluentSkeleton>
    type fluentSliderLabel = FluentSliderLabelBuilder<Microsoft.Fast.Components.FluentUI.FluentSliderLabel>
    type fluentSwitch = FluentSwitchBuilder<Microsoft.Fast.Components.FluentUI.FluentSwitch>
    type fluentTab = FluentTabBuilder<Microsoft.Fast.Components.FluentUI.FluentTab>
    type fluentTabPanel = FluentTabPanelBuilder<Microsoft.Fast.Components.FluentUI.FluentTabPanel>
    type fluentTabs = FluentTabsBuilder<Microsoft.Fast.Components.FluentUI.FluentTabs>
    type fluentTreeItem = FluentTreeItemBuilder<Microsoft.Fast.Components.FluentUI.FluentTreeItem>
    type fluentTreeView = FluentTreeViewBuilder<Microsoft.Fast.Components.FluentUI.FluentTreeView>
            