namespace rec Microsoft.AspNetCore.Components.DslInternals


// ===========================================================================================



// ===========================================================================================
// ===========================================================================================
    
namespace rec Microsoft.AspNetCore.Components.Web.DslInternals

open FSharp.Data.Adaptive
open Fun.Blazor
open Fun.Blazor.Operators


type VirtualizeBuilder<'FunBlazorGeneric, 'TItem when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentBuilder<'FunBlazorGeneric>()
    [<CustomOperation("ChildContent")>] member inline _.ChildContent (render: AttrRenderFragment, fn: 'TItem -> NodeRenderFragment) = render ==> html.renderFragment("ChildContent", fn)
    [<CustomOperation("ItemContent")>] member inline _.ItemContent (render: AttrRenderFragment, fn: 'TItem -> NodeRenderFragment) = render ==> html.renderFragment("ItemContent", fn)
    [<CustomOperation("Placeholder")>] member inline _.Placeholder (render: AttrRenderFragment, fn: Microsoft.AspNetCore.Components.Web.Virtualization.PlaceholderContext -> NodeRenderFragment) = render ==> html.renderFragment("Placeholder", fn)
    [<CustomOperation("ItemSize")>] member inline _.ItemSize (render: AttrRenderFragment, x: System.Single) = render ==> ("ItemSize" => x)
    [<CustomOperation("ItemsProvider")>] member inline _.ItemsProvider (render: AttrRenderFragment, x: Microsoft.AspNetCore.Components.Web.Virtualization.ItemsProviderDelegate<'TItem>) = render ==> ("ItemsProvider" => x)
    [<CustomOperation("Items")>] member inline _.Items (render: AttrRenderFragment, x: System.Collections.Generic.ICollection<'TItem>) = render ==> ("Items" => x)
    [<CustomOperation("OverscanCount")>] member inline _.OverscanCount (render: AttrRenderFragment, x: System.Int32) = render ==> ("OverscanCount" => x)
                
            
namespace rec Microsoft.AspNetCore.Components.Web.DslInternals

open FSharp.Data.Adaptive
open Fun.Blazor
open Fun.Blazor.Operators


type NavLinkBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAttrBuilder<'FunBlazorGeneric>()
    [<CustomOperation("ActiveClass")>] member inline _.ActiveClass (render: AttrRenderFragment, x: System.String) = render ==> ("ActiveClass" => x)
    [<CustomOperation("AdditionalAttributes")>] member inline _.AdditionalAttributes (render: AttrRenderFragment, x: System.Collections.Generic.IReadOnlyDictionary<System.String, System.Object>) = render ==> ("AdditionalAttributes" => x)
    [<CustomOperation("Match")>] member inline _.Match (render: AttrRenderFragment, x: Microsoft.AspNetCore.Components.Routing.NavLinkMatch) = render ==> ("Match" => x)
                
            
namespace rec Microsoft.AspNetCore.Components.Web.DslInternals

open FSharp.Data.Adaptive
open Fun.Blazor
open Fun.Blazor.Operators


type EditFormBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAttrBuilder<'FunBlazorGeneric>()
    [<CustomOperation("AdditionalAttributes")>] member inline _.AdditionalAttributes (render: AttrRenderFragment, x: System.Collections.Generic.IReadOnlyDictionary<System.String, System.Object>) = render ==> ("AdditionalAttributes" => x)
    [<CustomOperation("EditContext")>] member inline _.EditContext (render: AttrRenderFragment, x: Microsoft.AspNetCore.Components.Forms.EditContext) = render ==> ("EditContext" => x)
    [<CustomOperation("Model")>] member inline _.Model (render: AttrRenderFragment, x: System.Object) = render ==> ("Model" => x)
    [<CustomOperation("ChildContent")>] member inline _.ChildContent (render: AttrRenderFragment, fn: Microsoft.AspNetCore.Components.Forms.EditContext -> NodeRenderFragment) = render ==> html.renderFragment("ChildContent", fn)
    [<CustomOperation("OnSubmit")>] member inline _.OnSubmit (render: AttrRenderFragment, fn) = render ==> html.callback<Microsoft.AspNetCore.Components.Forms.EditContext>("OnSubmit", fn)
    [<CustomOperation("OnValidSubmit")>] member inline _.OnValidSubmit (render: AttrRenderFragment, fn) = render ==> html.callback<Microsoft.AspNetCore.Components.Forms.EditContext>("OnValidSubmit", fn)
    [<CustomOperation("OnInvalidSubmit")>] member inline _.OnInvalidSubmit (render: AttrRenderFragment, fn) = render ==> html.callback<Microsoft.AspNetCore.Components.Forms.EditContext>("OnInvalidSubmit", fn)
                

type InputBaseBuilder<'FunBlazorGeneric, 'TValue when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAttrBuilder<'FunBlazorGeneric>()
    [<CustomOperation("AdditionalAttributes")>] member inline _.AdditionalAttributes (render: AttrRenderFragment, x: System.Collections.Generic.IReadOnlyDictionary<System.String, System.Object>) = render ==> ("AdditionalAttributes" => x)
    [<CustomOperation("Value")>] member inline _.Value (render: AttrRenderFragment, x: 'TValue) = render ==> ("Value" => x)
    [<CustomOperation("Value'")>] member inline _.Value' (render: AttrRenderFragment, value: IStore<'TValue>) = render ==> html.bind("Value", value)
    [<CustomOperation("Value'")>] member inline _.Value' (render: AttrRenderFragment, value: cval<'TValue>) = render ==> html.bind("Value", value)
    [<CustomOperation("Value'")>] member inline _.Value' (render: AttrRenderFragment, valueFn: 'TValue * ('TValue -> unit)) = render ==> html.bind("Value", valueFn)
    [<CustomOperation("ValueChanged")>] member inline _.ValueChanged (render: AttrRenderFragment, fn) = render ==> html.callback<'TValue>("ValueChanged", fn)
    [<CustomOperation("ValueExpression")>] member inline _.ValueExpression (render: AttrRenderFragment, x: System.Linq.Expressions.Expression<System.Func<'TValue>>) = render ==> ("ValueExpression" => x)
    [<CustomOperation("DisplayName")>] member inline _.DisplayName (render: AttrRenderFragment, x: System.String) = render ==> ("DisplayName" => x)
                

type InputCheckboxBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit InputBaseBuilder<'FunBlazorGeneric, System.Boolean>()

                

type InputDateBuilder<'FunBlazorGeneric, 'TValue when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit InputBaseBuilder<'FunBlazorGeneric, 'TValue>()
    [<CustomOperation("ParsingErrorMessage")>] member inline _.ParsingErrorMessage (render: AttrRenderFragment, x: System.String) = render ==> ("ParsingErrorMessage" => x)
                

type InputNumberBuilder<'FunBlazorGeneric, 'TValue when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit InputBaseBuilder<'FunBlazorGeneric, 'TValue>()
    [<CustomOperation("ParsingErrorMessage")>] member inline _.ParsingErrorMessage (render: AttrRenderFragment, x: System.String) = render ==> ("ParsingErrorMessage" => x)
                

type InputRadioGroupBuilder<'FunBlazorGeneric, 'TValue when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit InputBaseBuilder<'FunBlazorGeneric, 'TValue>()
    [<CustomOperation("Name")>] member inline _.Name (render: AttrRenderFragment, x: System.String) = render ==> ("Name" => x)
                

type InputSelectBuilder<'FunBlazorGeneric, 'TValue when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit InputBaseBuilder<'FunBlazorGeneric, 'TValue>()

                

type InputTextBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit InputBaseBuilder<'FunBlazorGeneric, System.String>()

                

type InputTextAreaBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit InputBaseBuilder<'FunBlazorGeneric, System.String>()

                

type InputFileBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAttrBuilder<'FunBlazorGeneric>()
    [<CustomOperation("OnChange")>] member inline _.OnChange (render: AttrRenderFragment, fn) = render ==> html.callback<Microsoft.AspNetCore.Components.Forms.InputFileChangeEventArgs>("OnChange", fn)
    [<CustomOperation("AdditionalAttributes")>] member inline _.AdditionalAttributes (render: AttrRenderFragment, x: System.Collections.Generic.IDictionary<System.String, System.Object>) = render ==> ("AdditionalAttributes" => x)
                

type InputRadioBuilder<'FunBlazorGeneric, 'TValue when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAttrBuilder<'FunBlazorGeneric>()
    [<CustomOperation("AdditionalAttributes")>] member inline _.AdditionalAttributes (render: AttrRenderFragment, x: System.Collections.Generic.IReadOnlyDictionary<System.String, System.Object>) = render ==> ("AdditionalAttributes" => x)
    [<CustomOperation("Value")>] member inline _.Value (render: AttrRenderFragment, x: 'TValue) = render ==> ("Value" => x)
    [<CustomOperation("Name")>] member inline _.Name (render: AttrRenderFragment, x: System.String) = render ==> ("Name" => x)
                

type ValidationMessageBuilder<'FunBlazorGeneric, 'TValue when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAttrBuilder<'FunBlazorGeneric>()
    [<CustomOperation("AdditionalAttributes")>] member inline _.AdditionalAttributes (render: AttrRenderFragment, x: System.Collections.Generic.IReadOnlyDictionary<System.String, System.Object>) = render ==> ("AdditionalAttributes" => x)
    [<CustomOperation("For'")>] member inline _.For' (render: AttrRenderFragment, x: System.Linq.Expressions.Expression<System.Func<'TValue>>) = render ==> ("For" => x)
                

type ValidationSummaryBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAttrBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Model")>] member inline _.Model (render: AttrRenderFragment, x: System.Object) = render ==> ("Model" => x)
    [<CustomOperation("AdditionalAttributes")>] member inline _.AdditionalAttributes (render: AttrRenderFragment, x: System.Collections.Generic.IReadOnlyDictionary<System.String, System.Object>) = render ==> ("AdditionalAttributes" => x)
                
            
// ===========================================================================================
    
namespace Microsoft.AspNetCore.Components.Web

[<AutoOpen>]
module DslCE =

    open Microsoft.AspNetCore.Components.Web.DslInternals

    let Virtualize'<'TItem> = VirtualizeBuilder<Microsoft.AspNetCore.Components.Web.Virtualization.Virtualize<'TItem>, 'TItem>()
    let NavLink' = NavLinkBuilder<Microsoft.AspNetCore.Components.Routing.NavLink>()
    let EditForm' = EditFormBuilder<Microsoft.AspNetCore.Components.Forms.EditForm>()
    let InputBase'<'TValue> = InputBaseBuilder<Microsoft.AspNetCore.Components.Forms.InputBase<'TValue>, 'TValue>()
    let InputCheckbox' = InputCheckboxBuilder<Microsoft.AspNetCore.Components.Forms.InputCheckbox>()
    let InputDate'<'TValue> = InputDateBuilder<Microsoft.AspNetCore.Components.Forms.InputDate<'TValue>, 'TValue>()
    let InputNumber'<'TValue> = InputNumberBuilder<Microsoft.AspNetCore.Components.Forms.InputNumber<'TValue>, 'TValue>()
    let InputRadioGroup'<'TValue> = InputRadioGroupBuilder<Microsoft.AspNetCore.Components.Forms.InputRadioGroup<'TValue>, 'TValue>()
    let InputSelect'<'TValue> = InputSelectBuilder<Microsoft.AspNetCore.Components.Forms.InputSelect<'TValue>, 'TValue>()
    let InputText' = InputTextBuilder<Microsoft.AspNetCore.Components.Forms.InputText>()
    let InputTextArea' = InputTextAreaBuilder<Microsoft.AspNetCore.Components.Forms.InputTextArea>()
    let InputFile' = InputFileBuilder<Microsoft.AspNetCore.Components.Forms.InputFile>()
    let InputRadio'<'TValue> = InputRadioBuilder<Microsoft.AspNetCore.Components.Forms.InputRadio<'TValue>, 'TValue>()
    let ValidationMessage'<'TValue> = ValidationMessageBuilder<Microsoft.AspNetCore.Components.Forms.ValidationMessage<'TValue>, 'TValue>()
    let ValidationSummary' = ValidationSummaryBuilder<Microsoft.AspNetCore.Components.Forms.ValidationSummary>()
            
    