namespace rec Microsoft.AspNetCore.Components.DslCE.DslInternals

// ===========================================================================================



// ===========================================================================================
// ===========================================================================================
    
namespace rec Microsoft.AspNetCore.Components.Web.DslCE.DslInternals

open Bolero.Html
open Fun.Blazor


type VirtualizeBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    new (x: string) as this = VirtualizeBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = VirtualizeBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = VirtualizeBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = VirtualizeBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = VirtualizeBuilder<'FunBlazorGeneric>()

    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<Microsoft.AspNetCore.Components.Web.Virtualization.Virtualize<'TItem>>, render: 'TItem -> IFunBlazorNode) = Bolero.Html.attr.fragmentWith "ChildContent" (fun x -> render x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("itemContent")>] member this.itemContent (_: FunBlazorContext<Microsoft.AspNetCore.Components.Web.Virtualization.Virtualize<'TItem>>, render: 'TItem -> IFunBlazorNode) = Bolero.Html.attr.fragmentWith "ItemContent" (fun x -> render x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("placeholder")>] member this.placeholder (_: FunBlazorContext<Microsoft.AspNetCore.Components.Web.Virtualization.Virtualize<'TItem>>, render: Microsoft.AspNetCore.Components.Web.Virtualization.PlaceholderContext -> IFunBlazorNode) = Bolero.Html.attr.fragmentWith "Placeholder" (fun x -> render x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("itemSize")>] member this.itemSize (_: FunBlazorContext<Microsoft.AspNetCore.Components.Web.Virtualization.Virtualize<'TItem>>, x: System.Single) = "ItemSize" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("itemsProvider")>] member this.itemsProvider (_: FunBlazorContext<Microsoft.AspNetCore.Components.Web.Virtualization.Virtualize<'TItem>>, x: Microsoft.AspNetCore.Components.Web.Virtualization.ItemsProviderDelegate<'TItem>) = "ItemsProvider" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("items")>] member this.items (_: FunBlazorContext<Microsoft.AspNetCore.Components.Web.Virtualization.Virtualize<'TItem>>, x: System.Collections.Generic.ICollection<'TItem>) = "Items" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("overscanCount")>] member this.overscanCount (_: FunBlazorContext<Microsoft.AspNetCore.Components.Web.Virtualization.Virtualize<'TItem>>, x: System.Int32) = "OverscanCount" => x |> BoleroAttr |> this.AddProp
                
           
type NavLinkBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContextWithAttrs<'FunBlazorGeneric>()
    new (x: string) as this = NavLinkBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = NavLinkBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = NavLinkBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = NavLinkBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = NavLinkBuilder<'FunBlazorGeneric>()

    [<CustomOperation("activeClass")>] member this.activeClass (_: FunBlazorContext<Microsoft.AspNetCore.Components.Routing.NavLink>, x: System.String) = "ActiveClass" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("match'")>] member this.match' (_: FunBlazorContext<Microsoft.AspNetCore.Components.Routing.NavLink>, x: Microsoft.AspNetCore.Components.Routing.NavLinkMatch) = "Match" => x |> BoleroAttr |> this.AddProp
                

type EditFormBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContextWithAttrs<'FunBlazorGeneric>()
    new (x: string) as this = EditFormBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = EditFormBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = EditFormBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = EditFormBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = EditFormBuilder<'FunBlazorGeneric>()

    [<CustomOperation("editContext")>] member this.editContext (_: FunBlazorContext<Microsoft.AspNetCore.Components.Forms.EditForm>, x: Microsoft.AspNetCore.Components.Forms.EditContext) = "EditContext" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("model")>] member this.model (_: FunBlazorContext<Microsoft.AspNetCore.Components.Forms.EditForm>, x: System.Object) = "Model" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onSubmit")>] member this.onSubmit (_: FunBlazorContext<Microsoft.AspNetCore.Components.Forms.EditForm>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Forms.EditContext> "OnSubmit" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("onValidSubmit")>] member this.onValidSubmit (_: FunBlazorContext<Microsoft.AspNetCore.Components.Forms.EditForm>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Forms.EditContext> "OnValidSubmit" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("onInvalidSubmit")>] member this.onInvalidSubmit (_: FunBlazorContext<Microsoft.AspNetCore.Components.Forms.EditForm>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Forms.EditContext> "OnInvalidSubmit" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
                

type InputBaseBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContextWithAttrs<'FunBlazorGeneric>()
    static member create () = InputBaseBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = InputBaseBuilder<'FunBlazorGeneric>()

    [<CustomOperation("value")>] member this.value (_: FunBlazorContext<Microsoft.AspNetCore.Components.Forms.InputBase<'TValue>>, x: 'TValue) = "Value" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("valueChanged")>] member this.valueChanged (_: FunBlazorContext<Microsoft.AspNetCore.Components.Forms.InputBase<'TValue>>, fn) = (Bolero.Html.attr.callback<'TValue> "ValueChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("valueExpression")>] member this.valueExpression (_: FunBlazorContext<Microsoft.AspNetCore.Components.Forms.InputBase<'TValue>>, x: System.Linq.Expressions.Expression<System.Func<'TValue>>) = "ValueExpression" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("displayName")>] member this.displayName (_: FunBlazorContext<Microsoft.AspNetCore.Components.Forms.InputBase<'TValue>>, x: System.String) = "DisplayName" => x |> BoleroAttr |> this.AddProp
                

type InputCheckboxBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit InputBaseBuilder<'FunBlazorGeneric>()
    static member create () = InputCheckboxBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = InputCheckboxBuilder<'FunBlazorGeneric>()

    [<CustomOperation("value")>] member this.value (_: FunBlazorContext<Microsoft.AspNetCore.Components.Forms.InputCheckbox>, x: System.Boolean) = "Value" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("valueChanged")>] member this.valueChanged (_: FunBlazorContext<Microsoft.AspNetCore.Components.Forms.InputCheckbox>, fn) = (Bolero.Html.attr.callback<System.Boolean> "ValueChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("valueExpression")>] member this.valueExpression (_: FunBlazorContext<Microsoft.AspNetCore.Components.Forms.InputCheckbox>, x: System.Linq.Expressions.Expression<System.Func<System.Boolean>>) = "ValueExpression" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("displayName")>] member this.displayName (_: FunBlazorContext<Microsoft.AspNetCore.Components.Forms.InputCheckbox>, x: System.String) = "DisplayName" => x |> BoleroAttr |> this.AddProp
                

type InputDateBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit InputBaseBuilder<'FunBlazorGeneric>()
    static member create () = InputDateBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = InputDateBuilder<'FunBlazorGeneric>()

    [<CustomOperation("parsingErrorMessage")>] member this.parsingErrorMessage (_: FunBlazorContext<Microsoft.AspNetCore.Components.Forms.InputDate<'TValue>>, x: System.String) = "ParsingErrorMessage" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("value")>] member this.value (_: FunBlazorContext<Microsoft.AspNetCore.Components.Forms.InputDate<'TValue>>, x: 'TValue) = "Value" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("valueChanged")>] member this.valueChanged (_: FunBlazorContext<Microsoft.AspNetCore.Components.Forms.InputDate<'TValue>>, fn) = (Bolero.Html.attr.callback<'TValue> "ValueChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("valueExpression")>] member this.valueExpression (_: FunBlazorContext<Microsoft.AspNetCore.Components.Forms.InputDate<'TValue>>, x: System.Linq.Expressions.Expression<System.Func<'TValue>>) = "ValueExpression" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("displayName")>] member this.displayName (_: FunBlazorContext<Microsoft.AspNetCore.Components.Forms.InputDate<'TValue>>, x: System.String) = "DisplayName" => x |> BoleroAttr |> this.AddProp
                

type InputNumberBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit InputBaseBuilder<'FunBlazorGeneric>()
    static member create () = InputNumberBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = InputNumberBuilder<'FunBlazorGeneric>()

    [<CustomOperation("parsingErrorMessage")>] member this.parsingErrorMessage (_: FunBlazorContext<Microsoft.AspNetCore.Components.Forms.InputNumber<'TValue>>, x: System.String) = "ParsingErrorMessage" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("value")>] member this.value (_: FunBlazorContext<Microsoft.AspNetCore.Components.Forms.InputNumber<'TValue>>, x: 'TValue) = "Value" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("valueChanged")>] member this.valueChanged (_: FunBlazorContext<Microsoft.AspNetCore.Components.Forms.InputNumber<'TValue>>, fn) = (Bolero.Html.attr.callback<'TValue> "ValueChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("valueExpression")>] member this.valueExpression (_: FunBlazorContext<Microsoft.AspNetCore.Components.Forms.InputNumber<'TValue>>, x: System.Linq.Expressions.Expression<System.Func<'TValue>>) = "ValueExpression" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("displayName")>] member this.displayName (_: FunBlazorContext<Microsoft.AspNetCore.Components.Forms.InputNumber<'TValue>>, x: System.String) = "DisplayName" => x |> BoleroAttr |> this.AddProp
                

type InputRadioGroupBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit InputBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = InputRadioGroupBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = InputRadioGroupBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = InputRadioGroupBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = InputRadioGroupBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = InputRadioGroupBuilder<'FunBlazorGeneric>()

    [<CustomOperation("name")>] member this.name (_: FunBlazorContext<Microsoft.AspNetCore.Components.Forms.InputRadioGroup<'TValue>>, x: System.String) = "Name" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("value")>] member this.value (_: FunBlazorContext<Microsoft.AspNetCore.Components.Forms.InputRadioGroup<'TValue>>, x: 'TValue) = "Value" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("valueChanged")>] member this.valueChanged (_: FunBlazorContext<Microsoft.AspNetCore.Components.Forms.InputRadioGroup<'TValue>>, fn) = (Bolero.Html.attr.callback<'TValue> "ValueChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("valueExpression")>] member this.valueExpression (_: FunBlazorContext<Microsoft.AspNetCore.Components.Forms.InputRadioGroup<'TValue>>, x: System.Linq.Expressions.Expression<System.Func<'TValue>>) = "ValueExpression" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("displayName")>] member this.displayName (_: FunBlazorContext<Microsoft.AspNetCore.Components.Forms.InputRadioGroup<'TValue>>, x: System.String) = "DisplayName" => x |> BoleroAttr |> this.AddProp
                

type InputSelectBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit InputBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = InputSelectBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = InputSelectBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = InputSelectBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = InputSelectBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = InputSelectBuilder<'FunBlazorGeneric>()

    [<CustomOperation("value")>] member this.value (_: FunBlazorContext<Microsoft.AspNetCore.Components.Forms.InputSelect<'TValue>>, x: 'TValue) = "Value" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("valueChanged")>] member this.valueChanged (_: FunBlazorContext<Microsoft.AspNetCore.Components.Forms.InputSelect<'TValue>>, fn) = (Bolero.Html.attr.callback<'TValue> "ValueChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("valueExpression")>] member this.valueExpression (_: FunBlazorContext<Microsoft.AspNetCore.Components.Forms.InputSelect<'TValue>>, x: System.Linq.Expressions.Expression<System.Func<'TValue>>) = "ValueExpression" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("displayName")>] member this.displayName (_: FunBlazorContext<Microsoft.AspNetCore.Components.Forms.InputSelect<'TValue>>, x: System.String) = "DisplayName" => x |> BoleroAttr |> this.AddProp
                

type InputTextBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit InputBaseBuilder<'FunBlazorGeneric>()
    static member create () = InputTextBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = InputTextBuilder<'FunBlazorGeneric>()

    [<CustomOperation("value")>] member this.value (_: FunBlazorContext<Microsoft.AspNetCore.Components.Forms.InputText>, x: System.String) = "Value" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("valueChanged")>] member this.valueChanged (_: FunBlazorContext<Microsoft.AspNetCore.Components.Forms.InputText>, fn) = (Bolero.Html.attr.callback<System.String> "ValueChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("valueExpression")>] member this.valueExpression (_: FunBlazorContext<Microsoft.AspNetCore.Components.Forms.InputText>, x: System.Linq.Expressions.Expression<System.Func<System.String>>) = "ValueExpression" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("displayName")>] member this.displayName (_: FunBlazorContext<Microsoft.AspNetCore.Components.Forms.InputText>, x: System.String) = "DisplayName" => x |> BoleroAttr |> this.AddProp
                

type InputTextAreaBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit InputBaseBuilder<'FunBlazorGeneric>()
    static member create () = InputTextAreaBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = InputTextAreaBuilder<'FunBlazorGeneric>()

    [<CustomOperation("value")>] member this.value (_: FunBlazorContext<Microsoft.AspNetCore.Components.Forms.InputTextArea>, x: System.String) = "Value" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("valueChanged")>] member this.valueChanged (_: FunBlazorContext<Microsoft.AspNetCore.Components.Forms.InputTextArea>, fn) = (Bolero.Html.attr.callback<System.String> "ValueChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("valueExpression")>] member this.valueExpression (_: FunBlazorContext<Microsoft.AspNetCore.Components.Forms.InputTextArea>, x: System.Linq.Expressions.Expression<System.Func<System.String>>) = "ValueExpression" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("displayName")>] member this.displayName (_: FunBlazorContext<Microsoft.AspNetCore.Components.Forms.InputTextArea>, x: System.String) = "DisplayName" => x |> BoleroAttr |> this.AddProp
                

type InputFileBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContextWithAttrs<'FunBlazorGeneric>()
    static member create () = InputFileBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = InputFileBuilder<'FunBlazorGeneric>()

    [<CustomOperation("onChange")>] member this.onChange (_: FunBlazorContext<Microsoft.AspNetCore.Components.Forms.InputFile>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Forms.InputFileChangeEventArgs> "OnChange" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
                

type InputRadioBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContextWithAttrs<'FunBlazorGeneric>()
    static member create () = InputRadioBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = InputRadioBuilder<'FunBlazorGeneric>()

    [<CustomOperation("value")>] member this.value (_: FunBlazorContext<Microsoft.AspNetCore.Components.Forms.InputRadio<'TValue>>, x: 'TValue) = "Value" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("name")>] member this.name (_: FunBlazorContext<Microsoft.AspNetCore.Components.Forms.InputRadio<'TValue>>, x: System.String) = "Name" => x |> BoleroAttr |> this.AddProp
                

type ValidationMessageBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContextWithAttrs<'FunBlazorGeneric>()
    static member create () = ValidationMessageBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = ValidationMessageBuilder<'FunBlazorGeneric>()

    [<CustomOperation("for'")>] member this.for' (_: FunBlazorContext<Microsoft.AspNetCore.Components.Forms.ValidationMessage<'TValue>>, x: System.Linq.Expressions.Expression<System.Func<'TValue>>) = "For" => x |> BoleroAttr |> this.AddProp
                

type ValidationSummaryBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContextWithAttrs<'FunBlazorGeneric>()
    static member create () = ValidationSummaryBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = ValidationSummaryBuilder<'FunBlazorGeneric>()

    [<CustomOperation("model")>] member this.model (_: FunBlazorContext<Microsoft.AspNetCore.Components.Forms.ValidationSummary>, x: System.Object) = "Model" => x |> BoleroAttr |> this.AddProp
                
            
// ===========================================================================================
    
namespace Microsoft.AspNetCore.Components.Web.DslCE

[<AutoOpen>]
module DslCE =

    open Microsoft.AspNetCore.Components.Web.DslCE.DslInternals

    type virtualize<'TItem> = VirtualizeBuilder<Microsoft.AspNetCore.Components.Web.Virtualization.Virtualize<'TItem>>
    type navLink = NavLinkBuilder<Microsoft.AspNetCore.Components.Routing.NavLink>
    type editForm = EditFormBuilder<Microsoft.AspNetCore.Components.Forms.EditForm>
    type inputBase<'TValue> = InputBaseBuilder<Microsoft.AspNetCore.Components.Forms.InputBase<'TValue>>
    type inputCheckbox = InputCheckboxBuilder<Microsoft.AspNetCore.Components.Forms.InputCheckbox>
    type inputDate<'TValue> = InputDateBuilder<Microsoft.AspNetCore.Components.Forms.InputDate<'TValue>>
    type inputNumber<'TValue> = InputNumberBuilder<Microsoft.AspNetCore.Components.Forms.InputNumber<'TValue>>
    type inputRadioGroup<'TValue> = InputRadioGroupBuilder<Microsoft.AspNetCore.Components.Forms.InputRadioGroup<'TValue>>
    type inputSelect<'TValue> = InputSelectBuilder<Microsoft.AspNetCore.Components.Forms.InputSelect<'TValue>>
    type inputText = InputTextBuilder<Microsoft.AspNetCore.Components.Forms.InputText>
    type inputTextArea = InputTextAreaBuilder<Microsoft.AspNetCore.Components.Forms.InputTextArea>
    type inputFile = InputFileBuilder<Microsoft.AspNetCore.Components.Forms.InputFile>
    type inputRadio<'TValue> = InputRadioBuilder<Microsoft.AspNetCore.Components.Forms.InputRadio<'TValue>>
    type validationMessage<'TValue> = ValidationMessageBuilder<Microsoft.AspNetCore.Components.Forms.ValidationMessage<'TValue>>
    type validationSummary = ValidationSummaryBuilder<Microsoft.AspNetCore.Components.Forms.ValidationSummary>
            
    