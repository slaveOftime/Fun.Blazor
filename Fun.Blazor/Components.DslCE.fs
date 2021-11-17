namespace rec Microsoft.AspNetCore.Components.DslInternals

// ===========================================================================================



// ===========================================================================================
// ===========================================================================================
    
namespace rec Microsoft.AspNetCore.Components.Web.DslInternals

open Bolero.Html
open FSharp.Data.Adaptive
open Fun.Blazor


type VirtualizeBuilder<'FunBlazorGeneric, 'TItem when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    static member create () = VirtualizeBuilder<'FunBlazorGeneric, 'TItem>() :> IFunBlazorNode
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<'FunBlazorGeneric>, render: 'TItem -> IFunBlazorNode) = Bolero.Html.attr.fragmentWith "ChildContent" (fun x -> render x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ItemContent")>] member this.ItemContent (_: FunBlazorContext<'FunBlazorGeneric>, render: 'TItem -> IFunBlazorNode) = Bolero.Html.attr.fragmentWith "ItemContent" (fun x -> render x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Placeholder")>] member this.Placeholder (_: FunBlazorContext<'FunBlazorGeneric>, render: Microsoft.AspNetCore.Components.Web.Virtualization.PlaceholderContext -> IFunBlazorNode) = Bolero.Html.attr.fragmentWith "Placeholder" (fun x -> render x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ItemSize")>] member this.ItemSize (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Single) = "ItemSize" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ItemsProvider")>] member this.ItemsProvider (_: FunBlazorContext<'FunBlazorGeneric>, x: Microsoft.AspNetCore.Components.Web.Virtualization.ItemsProviderDelegate<'TItem>) = "ItemsProvider" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Items")>] member this.Items (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Collections.Generic.ICollection<'TItem>) = "Items" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OverscanCount")>] member this.OverscanCount (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Int32) = "OverscanCount" => x |> BoleroAttr |> this.AddProp
                
            
namespace rec Microsoft.AspNetCore.Components.Web.DslInternals

open Bolero.Html
open FSharp.Data.Adaptive
open Fun.Blazor


type NavLinkBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FunBlazorContextWithAttrs<'FunBlazorGeneric>()
    new (x: string) as this = NavLinkBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = NavLinkBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = NavLinkBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = NavLinkBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    [<CustomOperation("ActiveClass")>] member this.ActiveClass (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "ActiveClass" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("AdditionalAttributes")>] member this.AdditionalAttributes (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Collections.Generic.IReadOnlyDictionary<System.String, System.Object>) = "AdditionalAttributes" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Match")>] member this.Match (_: FunBlazorContext<'FunBlazorGeneric>, x: Microsoft.AspNetCore.Components.Routing.NavLinkMatch) = "Match" => x |> BoleroAttr |> this.AddProp
                
            
namespace rec Microsoft.AspNetCore.Components.Web.DslInternals

open Bolero.Html
open FSharp.Data.Adaptive
open Fun.Blazor


type EditFormBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FunBlazorContextWithAttrs<'FunBlazorGeneric>()
    static member create () = EditFormBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    [<CustomOperation("AdditionalAttributes")>] member this.AdditionalAttributes (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Collections.Generic.IReadOnlyDictionary<System.String, System.Object>) = "AdditionalAttributes" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("EditContext")>] member this.EditContext (_: FunBlazorContext<'FunBlazorGeneric>, x: Microsoft.AspNetCore.Components.Forms.EditContext) = "EditContext" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Model")>] member this.Model (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Object) = "Model" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<'FunBlazorGeneric>, render: Microsoft.AspNetCore.Components.Forms.EditContext -> IFunBlazorNode) = Bolero.Html.attr.fragmentWith "ChildContent" (fun x -> render x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnSubmit")>] member this.OnSubmit (_: FunBlazorContext<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Forms.EditContext> "OnSubmit" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnValidSubmit")>] member this.OnValidSubmit (_: FunBlazorContext<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Forms.EditContext> "OnValidSubmit" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnInvalidSubmit")>] member this.OnInvalidSubmit (_: FunBlazorContext<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Forms.EditContext> "OnInvalidSubmit" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
                

type InputBaseBuilder<'FunBlazorGeneric, 'TValue when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FunBlazorContextWithAttrs<'FunBlazorGeneric>()
    static member create () = InputBaseBuilder<'FunBlazorGeneric, 'TValue>() :> IFunBlazorNode
    [<CustomOperation("AdditionalAttributes")>] member this.AdditionalAttributes (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Collections.Generic.IReadOnlyDictionary<System.String, System.Object>) = "AdditionalAttributes" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Value")>] member this.Value (_: FunBlazorContext<'FunBlazorGeneric>, x: 'TValue) = "Value" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Value'")>] member this.Value' (_: FunBlazorContext<'FunBlazorGeneric>, value: IStore<'TValue>) = this.AddProp("Value", value)
    [<CustomOperation("Value'")>] member this.Value' (_: FunBlazorContext<'FunBlazorGeneric>, value: cval<'TValue>) = this.AddProp("Value", value)
    [<CustomOperation("Value'")>] member this.Value' (_: FunBlazorContext<'FunBlazorGeneric>, valueFn: 'TValue * ('TValue -> unit)) = this.AddProp("Value", valueFn)
    [<CustomOperation("ValueChanged")>] member this.ValueChanged (_: FunBlazorContext<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<'TValue> "ValueChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ValueExpression")>] member this.ValueExpression (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Linq.Expressions.Expression<System.Func<'TValue>>) = "ValueExpression" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DisplayName")>] member this.DisplayName (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "DisplayName" => x |> BoleroAttr |> this.AddProp
                

type InputCheckboxBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit InputBaseBuilder<'FunBlazorGeneric, System.Boolean>()
    static member create () = InputCheckboxBuilder<'FunBlazorGeneric>() :> IFunBlazorNode

                

type InputDateBuilder<'FunBlazorGeneric, 'TValue when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit InputBaseBuilder<'FunBlazorGeneric, 'TValue>()
    static member create () = InputDateBuilder<'FunBlazorGeneric, 'TValue>() :> IFunBlazorNode
    [<CustomOperation("ParsingErrorMessage")>] member this.ParsingErrorMessage (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "ParsingErrorMessage" => x |> BoleroAttr |> this.AddProp
                

type InputNumberBuilder<'FunBlazorGeneric, 'TValue when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit InputBaseBuilder<'FunBlazorGeneric, 'TValue>()
    static member create () = InputNumberBuilder<'FunBlazorGeneric, 'TValue>() :> IFunBlazorNode
    [<CustomOperation("ParsingErrorMessage")>] member this.ParsingErrorMessage (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "ParsingErrorMessage" => x |> BoleroAttr |> this.AddProp
                

type InputRadioGroupBuilder<'FunBlazorGeneric, 'TValue when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit InputBaseBuilder<'FunBlazorGeneric, 'TValue>()
    new (x: string) as this = InputRadioGroupBuilder<'FunBlazorGeneric, 'TValue>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = InputRadioGroupBuilder<'FunBlazorGeneric, 'TValue>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = InputRadioGroupBuilder<'FunBlazorGeneric, 'TValue>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = InputRadioGroupBuilder<'FunBlazorGeneric, 'TValue>(x) :> IFunBlazorNode
    [<CustomOperation("Name")>] member this.Name (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Name" => x |> BoleroAttr |> this.AddProp
                

type InputSelectBuilder<'FunBlazorGeneric, 'TValue when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit InputBaseBuilder<'FunBlazorGeneric, 'TValue>()
    new (x: string) as this = InputSelectBuilder<'FunBlazorGeneric, 'TValue>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = InputSelectBuilder<'FunBlazorGeneric, 'TValue>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = InputSelectBuilder<'FunBlazorGeneric, 'TValue>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = InputSelectBuilder<'FunBlazorGeneric, 'TValue>(x) :> IFunBlazorNode

                

type InputTextBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit InputBaseBuilder<'FunBlazorGeneric, System.String>()
    static member create () = InputTextBuilder<'FunBlazorGeneric>() :> IFunBlazorNode

                

type InputTextAreaBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit InputBaseBuilder<'FunBlazorGeneric, System.String>()
    static member create () = InputTextAreaBuilder<'FunBlazorGeneric>() :> IFunBlazorNode

                

type InputFileBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FunBlazorContextWithAttrs<'FunBlazorGeneric>()
    static member create () = InputFileBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    [<CustomOperation("OnChange")>] member this.OnChange (_: FunBlazorContext<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Forms.InputFileChangeEventArgs> "OnChange" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("AdditionalAttributes")>] member this.AdditionalAttributes (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Collections.Generic.IDictionary<System.String, System.Object>) = "AdditionalAttributes" => x |> BoleroAttr |> this.AddProp
                

type InputRadioBuilder<'FunBlazorGeneric, 'TValue when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FunBlazorContextWithAttrs<'FunBlazorGeneric>()
    static member create () = InputRadioBuilder<'FunBlazorGeneric, 'TValue>() :> IFunBlazorNode
    [<CustomOperation("AdditionalAttributes")>] member this.AdditionalAttributes (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Collections.Generic.IReadOnlyDictionary<System.String, System.Object>) = "AdditionalAttributes" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Value")>] member this.Value (_: FunBlazorContext<'FunBlazorGeneric>, x: 'TValue) = "Value" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Name")>] member this.Name (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Name" => x |> BoleroAttr |> this.AddProp
                

type ValidationMessageBuilder<'FunBlazorGeneric, 'TValue when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FunBlazorContextWithAttrs<'FunBlazorGeneric>()
    static member create () = ValidationMessageBuilder<'FunBlazorGeneric, 'TValue>() :> IFunBlazorNode
    [<CustomOperation("AdditionalAttributes")>] member this.AdditionalAttributes (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Collections.Generic.IReadOnlyDictionary<System.String, System.Object>) = "AdditionalAttributes" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("For'")>] member this.For' (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Linq.Expressions.Expression<System.Func<'TValue>>) = "For" => x |> BoleroAttr |> this.AddProp
                

type ValidationSummaryBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FunBlazorContextWithAttrs<'FunBlazorGeneric>()
    static member create () = ValidationSummaryBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    [<CustomOperation("Model")>] member this.Model (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Object) = "Model" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("AdditionalAttributes")>] member this.AdditionalAttributes (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Collections.Generic.IReadOnlyDictionary<System.String, System.Object>) = "AdditionalAttributes" => x |> BoleroAttr |> this.AddProp
                
            
// ===========================================================================================
    
namespace Microsoft.AspNetCore.Components.Web

[<AutoOpen>]
module DslCE =

    open Microsoft.AspNetCore.Components.Web.DslInternals

    type Virtualize'<'TItem> = VirtualizeBuilder<Microsoft.AspNetCore.Components.Web.Virtualization.Virtualize<'TItem>, 'TItem>
    type NavLink' = NavLinkBuilder<Microsoft.AspNetCore.Components.Routing.NavLink>
    type EditForm' = EditFormBuilder<Microsoft.AspNetCore.Components.Forms.EditForm>
    type InputBase'<'TValue> = InputBaseBuilder<Microsoft.AspNetCore.Components.Forms.InputBase<'TValue>, 'TValue>
    type InputCheckbox' = InputCheckboxBuilder<Microsoft.AspNetCore.Components.Forms.InputCheckbox>
    type InputDate'<'TValue> = InputDateBuilder<Microsoft.AspNetCore.Components.Forms.InputDate<'TValue>, 'TValue>
    type InputNumber'<'TValue> = InputNumberBuilder<Microsoft.AspNetCore.Components.Forms.InputNumber<'TValue>, 'TValue>
    type InputRadioGroup'<'TValue> = InputRadioGroupBuilder<Microsoft.AspNetCore.Components.Forms.InputRadioGroup<'TValue>, 'TValue>
    type InputSelect'<'TValue> = InputSelectBuilder<Microsoft.AspNetCore.Components.Forms.InputSelect<'TValue>, 'TValue>
    type InputText' = InputTextBuilder<Microsoft.AspNetCore.Components.Forms.InputText>
    type InputTextArea' = InputTextAreaBuilder<Microsoft.AspNetCore.Components.Forms.InputTextArea>
    type InputFile' = InputFileBuilder<Microsoft.AspNetCore.Components.Forms.InputFile>
    type InputRadio'<'TValue> = InputRadioBuilder<Microsoft.AspNetCore.Components.Forms.InputRadio<'TValue>, 'TValue>
    type ValidationMessage'<'TValue> = ValidationMessageBuilder<Microsoft.AspNetCore.Components.Forms.ValidationMessage<'TValue>, 'TValue>
    type ValidationSummary' = ValidationSummaryBuilder<Microsoft.AspNetCore.Components.Forms.ValidationSummary>
            
    