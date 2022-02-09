namespace rec Microsoft.AspNetCore.Components.DslInternals


// ===========================================================================================



// ===========================================================================================
// ===========================================================================================
    
namespace rec Microsoft.AspNetCore.Components.Web.DslInternals

open FSharp.Data.Adaptive
open Fun.Blazor
open Fun.Blazor.Operators


type VirtualizeBuilder<'FunBlazorGeneric, 'TItem when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAndChildAttrBuilder<'FunBlazorGeneric>()
    static member inline create () = html.fromBuilder(VirtualizeBuilder<'FunBlazorGeneric, 'TItem>())
    [<CustomOperation("ChildContent")>] member inline _.ChildContent ([<InlineIfLambda>] render: AttrRenderFragment, fn: 'TItem -> NodeRenderFragment) = render ==> html.renderFragment("ChildContent", fn)
    [<CustomOperation("ItemContent")>] member inline _.ItemContent ([<InlineIfLambda>] render: AttrRenderFragment, fn: 'TItem -> NodeRenderFragment) = render ==> html.renderFragment("ItemContent", fn)
    [<CustomOperation("Placeholder")>] member inline _.Placeholder ([<InlineIfLambda>] render: AttrRenderFragment, fn: Microsoft.AspNetCore.Components.Web.Virtualization.PlaceholderContext -> NodeRenderFragment) = render ==> html.renderFragment("Placeholder", fn)
    [<CustomOperation("ItemSize")>] member inline _.ItemSize ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Single) = render ==> ("ItemSize" => x)
    [<CustomOperation("ItemsProvider")>] member inline _.ItemsProvider ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.AspNetCore.Components.Web.Virtualization.ItemsProviderDelegate<'TItem>) = render ==> ("ItemsProvider" => x)
    [<CustomOperation("Items")>] member inline _.Items ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.ICollection<'TItem>) = render ==> ("Items" => x)
    [<CustomOperation("OverscanCount")>] member inline _.OverscanCount ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("OverscanCount" => x)
                
            
namespace rec Microsoft.AspNetCore.Components.Web.DslInternals

open FSharp.Data.Adaptive
open Fun.Blazor
open Fun.Blazor.Operators


type NavLinkBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAndChildAttrBuilder<'FunBlazorGeneric>()
    static member inline create (x: string) = NavLinkBuilder<'FunBlazorGeneric>(){ x }
    static member inline create (x: NodeRenderFragment seq) = NavLinkBuilder<'FunBlazorGeneric>(){ yield! x }
    [<CustomOperation("ActiveClass")>] member inline _.ActiveClass ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("ActiveClass" => x)
    [<CustomOperation("AdditionalAttributes")>] member inline _.AdditionalAttributes ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.IReadOnlyDictionary<System.String, System.Object>) = render ==> ("AdditionalAttributes" => x)
    [<CustomOperation("Match")>] member inline _.Match ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.AspNetCore.Components.Routing.NavLinkMatch) = render ==> ("Match" => x)
                
            
namespace rec Microsoft.AspNetCore.Components.Web.DslInternals

open FSharp.Data.Adaptive
open Fun.Blazor
open Fun.Blazor.Operators


type EditFormBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAndChildAttrBuilder<'FunBlazorGeneric>()
    static member inline create () = html.fromBuilder(EditFormBuilder<'FunBlazorGeneric>())
    [<CustomOperation("AdditionalAttributes")>] member inline _.AdditionalAttributes ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.IReadOnlyDictionary<System.String, System.Object>) = render ==> ("AdditionalAttributes" => x)
    [<CustomOperation("EditContext")>] member inline _.EditContext ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.AspNetCore.Components.Forms.EditContext) = render ==> ("EditContext" => x)
    [<CustomOperation("Model")>] member inline _.Model ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Object) = render ==> ("Model" => x)
    [<CustomOperation("ChildContent")>] member inline _.ChildContent ([<InlineIfLambda>] render: AttrRenderFragment, fn: Microsoft.AspNetCore.Components.Forms.EditContext -> NodeRenderFragment) = render ==> html.renderFragment("ChildContent", fn)
    [<CustomOperation("OnSubmit")>] member inline _.OnSubmit ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callback<Microsoft.AspNetCore.Components.Forms.EditContext>("OnSubmit", fn)
    [<CustomOperation("OnValidSubmit")>] member inline _.OnValidSubmit ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callback<Microsoft.AspNetCore.Components.Forms.EditContext>("OnValidSubmit", fn)
    [<CustomOperation("OnInvalidSubmit")>] member inline _.OnInvalidSubmit ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callback<Microsoft.AspNetCore.Components.Forms.EditContext>("OnInvalidSubmit", fn)
                

type InputBaseBuilder<'FunBlazorGeneric, 'TValue when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAndChildAttrBuilder<'FunBlazorGeneric>()
    static member inline create () = html.fromBuilder(InputBaseBuilder<'FunBlazorGeneric, 'TValue>())
    [<CustomOperation("AdditionalAttributes")>] member inline _.AdditionalAttributes ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.IReadOnlyDictionary<System.String, System.Object>) = render ==> ("AdditionalAttributes" => x)
    [<CustomOperation("Value")>] member inline _.Value ([<InlineIfLambda>] render: AttrRenderFragment, x: 'TValue) = render ==> ("Value" => x)
    [<CustomOperation("Value'")>] member inline _.Value' ([<InlineIfLambda>] render: AttrRenderFragment, value: IStore<'TValue>) = render ==> html.bind("Value", value)
    [<CustomOperation("Value'")>] member inline _.Value' ([<InlineIfLambda>] render: AttrRenderFragment, value: cval<'TValue>) = render ==> html.bind("Value", value)
    [<CustomOperation("Value'")>] member inline _.Value' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: 'TValue * ('TValue -> unit)) = render ==> html.bind("Value", valueFn)
    [<CustomOperation("ValueChanged")>] member inline _.ValueChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callback<'TValue>("ValueChanged", fn)
    [<CustomOperation("ValueExpression")>] member inline _.ValueExpression ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Linq.Expressions.Expression<System.Func<'TValue>>) = render ==> ("ValueExpression" => x)
    [<CustomOperation("DisplayName")>] member inline _.DisplayName ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("DisplayName" => x)
                

type InputCheckboxBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit InputBaseBuilder<'FunBlazorGeneric, System.Boolean>()
    static member inline create () = html.fromBuilder(InputCheckboxBuilder<'FunBlazorGeneric>())

                

type InputDateBuilder<'FunBlazorGeneric, 'TValue when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit InputBaseBuilder<'FunBlazorGeneric, 'TValue>()
    static member inline create () = html.fromBuilder(InputDateBuilder<'FunBlazorGeneric, 'TValue>())
    [<CustomOperation("ParsingErrorMessage")>] member inline _.ParsingErrorMessage ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("ParsingErrorMessage" => x)
                

type InputNumberBuilder<'FunBlazorGeneric, 'TValue when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit InputBaseBuilder<'FunBlazorGeneric, 'TValue>()
    static member inline create () = html.fromBuilder(InputNumberBuilder<'FunBlazorGeneric, 'TValue>())
    [<CustomOperation("ParsingErrorMessage")>] member inline _.ParsingErrorMessage ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("ParsingErrorMessage" => x)
                

type InputRadioGroupBuilder<'FunBlazorGeneric, 'TValue when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit InputBaseBuilder<'FunBlazorGeneric, 'TValue>()
    static member inline create (x: string) = InputRadioGroupBuilder<'FunBlazorGeneric, 'TValue>(){ x }
    static member inline create (x: NodeRenderFragment seq) = InputRadioGroupBuilder<'FunBlazorGeneric, 'TValue>(){ yield! x }
    [<CustomOperation("Name")>] member inline _.Name ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Name" => x)
                

type InputSelectBuilder<'FunBlazorGeneric, 'TValue when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit InputBaseBuilder<'FunBlazorGeneric, 'TValue>()
    static member inline create (x: string) = InputSelectBuilder<'FunBlazorGeneric, 'TValue>(){ x }
    static member inline create (x: NodeRenderFragment seq) = InputSelectBuilder<'FunBlazorGeneric, 'TValue>(){ yield! x }

                

type InputTextBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit InputBaseBuilder<'FunBlazorGeneric, System.String>()
    static member inline create () = html.fromBuilder(InputTextBuilder<'FunBlazorGeneric>())

                

type InputTextAreaBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit InputBaseBuilder<'FunBlazorGeneric, System.String>()
    static member inline create () = html.fromBuilder(InputTextAreaBuilder<'FunBlazorGeneric>())

                

type InputFileBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAndChildAttrBuilder<'FunBlazorGeneric>()
    static member inline create () = html.fromBuilder(InputFileBuilder<'FunBlazorGeneric>())
    [<CustomOperation("OnChange")>] member inline _.OnChange ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callback<Microsoft.AspNetCore.Components.Forms.InputFileChangeEventArgs>("OnChange", fn)
    [<CustomOperation("AdditionalAttributes")>] member inline _.AdditionalAttributes ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.IDictionary<System.String, System.Object>) = render ==> ("AdditionalAttributes" => x)
                

type InputRadioBuilder<'FunBlazorGeneric, 'TValue when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAndChildAttrBuilder<'FunBlazorGeneric>()
    static member inline create () = html.fromBuilder(InputRadioBuilder<'FunBlazorGeneric, 'TValue>())
    [<CustomOperation("AdditionalAttributes")>] member inline _.AdditionalAttributes ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.IReadOnlyDictionary<System.String, System.Object>) = render ==> ("AdditionalAttributes" => x)
    [<CustomOperation("Value")>] member inline _.Value ([<InlineIfLambda>] render: AttrRenderFragment, x: 'TValue) = render ==> ("Value" => x)
    [<CustomOperation("Name")>] member inline _.Name ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Name" => x)
                

type ValidationMessageBuilder<'FunBlazorGeneric, 'TValue when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAndChildAttrBuilder<'FunBlazorGeneric>()
    static member inline create () = html.fromBuilder(ValidationMessageBuilder<'FunBlazorGeneric, 'TValue>())
    [<CustomOperation("AdditionalAttributes")>] member inline _.AdditionalAttributes ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.IReadOnlyDictionary<System.String, System.Object>) = render ==> ("AdditionalAttributes" => x)
    [<CustomOperation("For'")>] member inline _.For' ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Linq.Expressions.Expression<System.Func<'TValue>>) = render ==> ("For" => x)
                

type ValidationSummaryBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAndChildAttrBuilder<'FunBlazorGeneric>()
    static member inline create () = html.fromBuilder(ValidationSummaryBuilder<'FunBlazorGeneric>())
    [<CustomOperation("Model")>] member inline _.Model ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Object) = render ==> ("Model" => x)
    [<CustomOperation("AdditionalAttributes")>] member inline _.AdditionalAttributes ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.IReadOnlyDictionary<System.String, System.Object>) = render ==> ("AdditionalAttributes" => x)
                
            
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
            
    