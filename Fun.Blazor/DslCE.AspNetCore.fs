namespace rec Microsoft.AspNetCore.Components.DslInternals

// ===========================================================================================



// ===========================================================================================
// ===========================================================================================
    
namespace rec Microsoft.AspNetCore.Components.Web.DslInternals

open Bolero.Html
open FSharp.Data.Adaptive
open Fun.Blazor


type VirtualizeBuilder<'FunBlazorGeneric, 'TItem when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FunBlazorBuilder<'FunBlazorGeneric>()
    static member create () = VirtualizeBuilder<'FunBlazorGeneric, 'TItem>().CreateNode()
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorBuilder<'FunBlazorGeneric>, render: 'TItem -> Bolero.Node) = Bolero.Html.attr.fragmentWith "ChildContent" (fun x -> render x) |> this.AddAttr
    [<CustomOperation("ItemContent")>] member this.ItemContent (_: FunBlazorBuilder<'FunBlazorGeneric>, render: 'TItem -> Bolero.Node) = Bolero.Html.attr.fragmentWith "ItemContent" (fun x -> render x) |> this.AddAttr
    [<CustomOperation("Placeholder")>] member this.Placeholder (_: FunBlazorBuilder<'FunBlazorGeneric>, render: Microsoft.AspNetCore.Components.Web.Virtualization.PlaceholderContext -> Bolero.Node) = Bolero.Html.attr.fragmentWith "Placeholder" (fun x -> render x) |> this.AddAttr
    [<CustomOperation("ItemSize")>] member this.ItemSize (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Single) = "ItemSize" => x |> this.AddAttr
    [<CustomOperation("ItemsProvider")>] member this.ItemsProvider (_: FunBlazorBuilder<'FunBlazorGeneric>, x: Microsoft.AspNetCore.Components.Web.Virtualization.ItemsProviderDelegate<'TItem>) = "ItemsProvider" => x |> this.AddAttr
    [<CustomOperation("Items")>] member this.Items (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Collections.Generic.ICollection<'TItem>) = "Items" => x |> this.AddAttr
    [<CustomOperation("OverscanCount")>] member this.OverscanCount (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Int32) = "OverscanCount" => x |> this.AddAttr
                
            
namespace rec Microsoft.AspNetCore.Components.Web.DslInternals

open Bolero.Html
open FSharp.Data.Adaptive
open Fun.Blazor


type NavLinkBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FunBlazorBuilderWithDomAttrs<'FunBlazorGeneric>()
    new (x: string) as this = NavLinkBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text) |> this.AddAttr |> ignore
    new (x: Bolero.Node list) as this = NavLinkBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment) |> this.AddAttr |> ignore
    static member create (x: string) = NavLinkBuilder<'FunBlazorGeneric>(x).CreateNode()
    static member create (x: Bolero.Node list) = NavLinkBuilder<'FunBlazorGeneric>(x).CreateNode()
    [<CustomOperation("ActiveClass")>] member this.ActiveClass (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "ActiveClass" => x |> this.AddAttr
    [<CustomOperation("AdditionalAttributes")>] member this.AdditionalAttributes (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Collections.Generic.IReadOnlyDictionary<System.String, System.Object>) = "AdditionalAttributes" => x |> this.AddAttr
    [<CustomOperation("Match")>] member this.Match (_: FunBlazorBuilder<'FunBlazorGeneric>, x: Microsoft.AspNetCore.Components.Routing.NavLinkMatch) = "Match" => x |> this.AddAttr
                
            
namespace rec Microsoft.AspNetCore.Components.Web.DslInternals

open Bolero.Html
open FSharp.Data.Adaptive
open Fun.Blazor


type EditFormBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FunBlazorBuilderWithDomAttrs<'FunBlazorGeneric>()
    static member create () = EditFormBuilder<'FunBlazorGeneric>().CreateNode()
    [<CustomOperation("AdditionalAttributes")>] member this.AdditionalAttributes (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Collections.Generic.IReadOnlyDictionary<System.String, System.Object>) = "AdditionalAttributes" => x |> this.AddAttr
    [<CustomOperation("EditContext")>] member this.EditContext (_: FunBlazorBuilder<'FunBlazorGeneric>, x: Microsoft.AspNetCore.Components.Forms.EditContext) = "EditContext" => x |> this.AddAttr
    [<CustomOperation("Model")>] member this.Model (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Object) = "Model" => x |> this.AddAttr
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorBuilder<'FunBlazorGeneric>, render: Microsoft.AspNetCore.Components.Forms.EditContext -> Bolero.Node) = Bolero.Html.attr.fragmentWith "ChildContent" (fun x -> render x) |> this.AddAttr
    [<CustomOperation("OnSubmit")>] member this.OnSubmit (_: FunBlazorBuilder<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Forms.EditContext> "OnSubmit" (fun e -> fn e)) |> this.AddAttr
    [<CustomOperation("OnValidSubmit")>] member this.OnValidSubmit (_: FunBlazorBuilder<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Forms.EditContext> "OnValidSubmit" (fun e -> fn e)) |> this.AddAttr
    [<CustomOperation("OnInvalidSubmit")>] member this.OnInvalidSubmit (_: FunBlazorBuilder<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Forms.EditContext> "OnInvalidSubmit" (fun e -> fn e)) |> this.AddAttr
                

type InputBaseBuilder<'FunBlazorGeneric, 'TValue when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FunBlazorBuilderWithDomAttrs<'FunBlazorGeneric>()
    static member create () = InputBaseBuilder<'FunBlazorGeneric, 'TValue>().CreateNode()
    [<CustomOperation("AdditionalAttributes")>] member this.AdditionalAttributes (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Collections.Generic.IReadOnlyDictionary<System.String, System.Object>) = "AdditionalAttributes" => x |> this.AddAttr
    [<CustomOperation("Value")>] member this.Value (_: FunBlazorBuilder<'FunBlazorGeneric>, x: 'TValue) = "Value" => x |> this.AddAttr
    [<CustomOperation("Value'")>] member this.Value' (_: FunBlazorBuilder<'FunBlazorGeneric>, value: IStore<'TValue>) = this.AddBinding("Value", value)
    [<CustomOperation("Value'")>] member this.Value' (_: FunBlazorBuilder<'FunBlazorGeneric>, value: cval<'TValue>) = this.AddBinding("Value", value)
    [<CustomOperation("Value'")>] member this.Value' (_: FunBlazorBuilder<'FunBlazorGeneric>, valueFn: 'TValue * ('TValue -> unit)) = this.AddBinding("Value", valueFn)
    [<CustomOperation("ValueChanged")>] member this.ValueChanged (_: FunBlazorBuilder<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<'TValue> "ValueChanged" (fun e -> fn e)) |> this.AddAttr
    [<CustomOperation("ValueExpression")>] member this.ValueExpression (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Linq.Expressions.Expression<System.Func<'TValue>>) = "ValueExpression" => x |> this.AddAttr
    [<CustomOperation("DisplayName")>] member this.DisplayName (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "DisplayName" => x |> this.AddAttr
                

type InputCheckboxBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit InputBaseBuilder<'FunBlazorGeneric, System.Boolean>()
    static member create () = InputCheckboxBuilder<'FunBlazorGeneric>().CreateNode()

                

type InputDateBuilder<'FunBlazorGeneric, 'TValue when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit InputBaseBuilder<'FunBlazorGeneric, 'TValue>()
    static member create () = InputDateBuilder<'FunBlazorGeneric, 'TValue>().CreateNode()
    [<CustomOperation("ParsingErrorMessage")>] member this.ParsingErrorMessage (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "ParsingErrorMessage" => x |> this.AddAttr
                

type InputNumberBuilder<'FunBlazorGeneric, 'TValue when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit InputBaseBuilder<'FunBlazorGeneric, 'TValue>()
    static member create () = InputNumberBuilder<'FunBlazorGeneric, 'TValue>().CreateNode()
    [<CustomOperation("ParsingErrorMessage")>] member this.ParsingErrorMessage (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "ParsingErrorMessage" => x |> this.AddAttr
                

type InputRadioGroupBuilder<'FunBlazorGeneric, 'TValue when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit InputBaseBuilder<'FunBlazorGeneric, 'TValue>()
    new (x: string) as this = InputRadioGroupBuilder<'FunBlazorGeneric, 'TValue>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text) |> this.AddAttr |> ignore
    new (x: Bolero.Node list) as this = InputRadioGroupBuilder<'FunBlazorGeneric, 'TValue>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment) |> this.AddAttr |> ignore
    static member create (x: string) = InputRadioGroupBuilder<'FunBlazorGeneric, 'TValue>(x).CreateNode()
    static member create (x: Bolero.Node list) = InputRadioGroupBuilder<'FunBlazorGeneric, 'TValue>(x).CreateNode()
    [<CustomOperation("Name")>] member this.Name (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "Name" => x |> this.AddAttr
                

type InputSelectBuilder<'FunBlazorGeneric, 'TValue when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit InputBaseBuilder<'FunBlazorGeneric, 'TValue>()
    new (x: string) as this = InputSelectBuilder<'FunBlazorGeneric, 'TValue>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text) |> this.AddAttr |> ignore
    new (x: Bolero.Node list) as this = InputSelectBuilder<'FunBlazorGeneric, 'TValue>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment) |> this.AddAttr |> ignore
    static member create (x: string) = InputSelectBuilder<'FunBlazorGeneric, 'TValue>(x).CreateNode()
    static member create (x: Bolero.Node list) = InputSelectBuilder<'FunBlazorGeneric, 'TValue>(x).CreateNode()

                

type InputTextBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit InputBaseBuilder<'FunBlazorGeneric, System.String>()
    static member create () = InputTextBuilder<'FunBlazorGeneric>().CreateNode()

                

type InputTextAreaBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit InputBaseBuilder<'FunBlazorGeneric, System.String>()
    static member create () = InputTextAreaBuilder<'FunBlazorGeneric>().CreateNode()

                

type InputFileBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FunBlazorBuilderWithDomAttrs<'FunBlazorGeneric>()
    static member create () = InputFileBuilder<'FunBlazorGeneric>().CreateNode()
    [<CustomOperation("OnChange")>] member this.OnChange (_: FunBlazorBuilder<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Forms.InputFileChangeEventArgs> "OnChange" (fun e -> fn e)) |> this.AddAttr
    [<CustomOperation("AdditionalAttributes")>] member this.AdditionalAttributes (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Collections.Generic.IDictionary<System.String, System.Object>) = "AdditionalAttributes" => x |> this.AddAttr
                

type InputRadioBuilder<'FunBlazorGeneric, 'TValue when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FunBlazorBuilderWithDomAttrs<'FunBlazorGeneric>()
    static member create () = InputRadioBuilder<'FunBlazorGeneric, 'TValue>().CreateNode()
    [<CustomOperation("AdditionalAttributes")>] member this.AdditionalAttributes (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Collections.Generic.IReadOnlyDictionary<System.String, System.Object>) = "AdditionalAttributes" => x |> this.AddAttr
    [<CustomOperation("Value")>] member this.Value (_: FunBlazorBuilder<'FunBlazorGeneric>, x: 'TValue) = "Value" => x |> this.AddAttr
    [<CustomOperation("Name")>] member this.Name (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "Name" => x |> this.AddAttr
                

type ValidationMessageBuilder<'FunBlazorGeneric, 'TValue when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FunBlazorBuilderWithDomAttrs<'FunBlazorGeneric>()
    static member create () = ValidationMessageBuilder<'FunBlazorGeneric, 'TValue>().CreateNode()
    [<CustomOperation("AdditionalAttributes")>] member this.AdditionalAttributes (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Collections.Generic.IReadOnlyDictionary<System.String, System.Object>) = "AdditionalAttributes" => x |> this.AddAttr
    [<CustomOperation("For'")>] member this.For' (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Linq.Expressions.Expression<System.Func<'TValue>>) = "For" => x |> this.AddAttr
                

type ValidationSummaryBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FunBlazorBuilderWithDomAttrs<'FunBlazorGeneric>()
    static member create () = ValidationSummaryBuilder<'FunBlazorGeneric>().CreateNode()
    [<CustomOperation("Model")>] member this.Model (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Object) = "Model" => x |> this.AddAttr
    [<CustomOperation("AdditionalAttributes")>] member this.AdditionalAttributes (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Collections.Generic.IReadOnlyDictionary<System.String, System.Object>) = "AdditionalAttributes" => x |> this.AddAttr
                
            
// ===========================================================================================
    
namespace Microsoft.AspNetCore.Components.Web

[<AutoOpen>]
module DslCE =

    open Microsoft.AspNetCore.Components.Web.DslInternals

    type Virtualize'<'TItem>() = inherit VirtualizeBuilder<Microsoft.AspNetCore.Components.Web.Virtualization.Virtualize<'TItem>, 'TItem>()
    type NavLink'() = inherit NavLinkBuilder<Microsoft.AspNetCore.Components.Routing.NavLink>()
    type EditForm'() = inherit EditFormBuilder<Microsoft.AspNetCore.Components.Forms.EditForm>()
    type InputBase'<'TValue>() = inherit InputBaseBuilder<Microsoft.AspNetCore.Components.Forms.InputBase<'TValue>, 'TValue>()
    type InputCheckbox'() = inherit InputCheckboxBuilder<Microsoft.AspNetCore.Components.Forms.InputCheckbox>()
    type InputDate'<'TValue>() = inherit InputDateBuilder<Microsoft.AspNetCore.Components.Forms.InputDate<'TValue>, 'TValue>()
    type InputNumber'<'TValue>() = inherit InputNumberBuilder<Microsoft.AspNetCore.Components.Forms.InputNumber<'TValue>, 'TValue>()
    type InputRadioGroup'<'TValue>() = inherit InputRadioGroupBuilder<Microsoft.AspNetCore.Components.Forms.InputRadioGroup<'TValue>, 'TValue>()
    type InputSelect'<'TValue>() = inherit InputSelectBuilder<Microsoft.AspNetCore.Components.Forms.InputSelect<'TValue>, 'TValue>()
    type InputText'() = inherit InputTextBuilder<Microsoft.AspNetCore.Components.Forms.InputText>()
    type InputTextArea'() = inherit InputTextAreaBuilder<Microsoft.AspNetCore.Components.Forms.InputTextArea>()
    type InputFile'() = inherit InputFileBuilder<Microsoft.AspNetCore.Components.Forms.InputFile>()
    type InputRadio'<'TValue>() = inherit InputRadioBuilder<Microsoft.AspNetCore.Components.Forms.InputRadio<'TValue>, 'TValue>()
    type ValidationMessage'<'TValue>() = inherit ValidationMessageBuilder<Microsoft.AspNetCore.Components.Forms.ValidationMessage<'TValue>, 'TValue>()
    type ValidationSummary'() = inherit ValidationSummaryBuilder<Microsoft.AspNetCore.Components.Forms.ValidationSummary>()
            
    