

// ===========================================================================================



// ===========================================================================================
// ===========================================================================================

namespace rec Microsoft.AspNetCore.Components.Web.DslInternals

open Bolero.Html
open FSharp.Data.Adaptive
open Fun.Blazor
open Microsoft.AspNetCore.Components.Web.DslInternals


type virtualize<'FunBlazorGeneric, 'TItem> =
    
    static member create () = [] |> html.blazor<Microsoft.AspNetCore.Components.Web.Virtualization.Virtualize<'TItem>>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<Microsoft.AspNetCore.Components.Web.Virtualization.Virtualize<'TItem>>
    static member create (nodes: IFunBlazorNode list) = nodes |> html.blazor<Microsoft.AspNetCore.Components.Web.Virtualization.Virtualize<'TItem>>
    static member create (node: IFunBlazorNode) = [ node ] |> html.blazor<Microsoft.AspNetCore.Components.Web.Virtualization.Virtualize<'TItem>>
    static member create (x: string) = [ html.text x ] |> html.blazor<Microsoft.AspNetCore.Components.Web.Virtualization.Virtualize<'TItem>>
    static member ref x = attr.ref<Microsoft.AspNetCore.Components.Web.Virtualization.Virtualize<'TItem>> x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member childContent (render: 'TItem -> IFunBlazorNode) = Bolero.Html.attr.fragmentWith "ChildContent" (fun x -> render x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member itemContent (render: 'TItem -> IFunBlazorNode) = Bolero.Html.attr.fragmentWith "ItemContent" (fun x -> render x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member placeholder (render: Microsoft.AspNetCore.Components.Web.Virtualization.PlaceholderContext -> IFunBlazorNode) = Bolero.Html.attr.fragmentWith "Placeholder" (fun x -> render x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member itemSize (x: System.Single) = "ItemSize" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member itemsProvider (x: Microsoft.AspNetCore.Components.Web.Virtualization.ItemsProviderDelegate<'TItem>) = "ItemsProvider" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member items (x: System.Collections.Generic.ICollection<'TItem>) = "Items" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member overscanCount (x: System.Int32) = "OverscanCount" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    
            
namespace rec Microsoft.AspNetCore.Components.Web.DslInternals

open Bolero.Html
open FSharp.Data.Adaptive
open Fun.Blazor
open Microsoft.AspNetCore.Components.Web.DslInternals


type navLink<'FunBlazorGeneric> =
    
    static member create () = [] |> html.blazor<Microsoft.AspNetCore.Components.Routing.NavLink>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<Microsoft.AspNetCore.Components.Routing.NavLink>
    static member create (nodes: IFunBlazorNode list) = nodes |> html.blazor<Microsoft.AspNetCore.Components.Routing.NavLink>
    static member create (node: IFunBlazorNode) = [ node ] |> html.blazor<Microsoft.AspNetCore.Components.Routing.NavLink>
    static member create (x: string) = [ html.text x ] |> html.blazor<Microsoft.AspNetCore.Components.Routing.NavLink>
    static member ref x = attr.ref<Microsoft.AspNetCore.Components.Routing.NavLink> x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member activeClass (x: System.String) = "ActiveClass" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member additionalAttributes (x: System.Collections.Generic.IReadOnlyDictionary<System.String, System.Object>) = "AdditionalAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member match' (x: Microsoft.AspNetCore.Components.Routing.NavLinkMatch) = "Match" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    
            
namespace rec Microsoft.AspNetCore.Components.Web.DslInternals

open Bolero.Html
open FSharp.Data.Adaptive
open Fun.Blazor
open Microsoft.AspNetCore.Components.Web.DslInternals


type editForm<'FunBlazorGeneric> =
    
    static member create () = [] |> html.blazor<Microsoft.AspNetCore.Components.Forms.EditForm>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<Microsoft.AspNetCore.Components.Forms.EditForm>
    static member create (nodes: IFunBlazorNode list) = nodes |> html.blazor<Microsoft.AspNetCore.Components.Forms.EditForm>
    static member create (node: IFunBlazorNode) = [ node ] |> html.blazor<Microsoft.AspNetCore.Components.Forms.EditForm>
    static member create (x: string) = [ html.text x ] |> html.blazor<Microsoft.AspNetCore.Components.Forms.EditForm>
    static member ref x = attr.ref<Microsoft.AspNetCore.Components.Forms.EditForm> x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member additionalAttributes (x: System.Collections.Generic.IReadOnlyDictionary<System.String, System.Object>) = "AdditionalAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member editContext (x: Microsoft.AspNetCore.Components.Forms.EditContext) = "EditContext" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member model (x: System.Object) = "Model" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member childContent (render: Microsoft.AspNetCore.Components.Forms.EditContext -> IFunBlazorNode) = Bolero.Html.attr.fragmentWith "ChildContent" (fun x -> render x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member onSubmit fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Forms.EditContext> "OnSubmit" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member onValidSubmit fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Forms.EditContext> "OnValidSubmit" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member onInvalidSubmit fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Forms.EditContext> "OnInvalidSubmit" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type inputBase<'FunBlazorGeneric, 'TValue> =
    
    static member create () = [] |> html.blazor<Microsoft.AspNetCore.Components.Forms.InputBase<'TValue>>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<Microsoft.AspNetCore.Components.Forms.InputBase<'TValue>>

    static member ref x = attr.ref<Microsoft.AspNetCore.Components.Forms.InputBase<'TValue>> x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member additionalAttributes (x: System.Collections.Generic.IReadOnlyDictionary<System.String, System.Object>) = "AdditionalAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member value (x: 'TValue) = "Value" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member value' (value: IStore<'TValue>) = GenericFunBlazorNode<'FunBlazorGeneric>.create("Value", value)
    static member value' (value: cval<'TValue>) = GenericFunBlazorNode<'FunBlazorGeneric>.create("Value", value)
    static member valueChanged fn = (Bolero.Html.attr.callback<'TValue> "ValueChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member valueExpression (x: System.Linq.Expressions.Expression<System.Func<'TValue>>) = "ValueExpression" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member displayName (x: System.String) = "DisplayName" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type inputCheckbox<'FunBlazorGeneric> =
    inherit inputBase<'FunBlazorGeneric, System.Boolean>
    static member create () = [] |> html.blazor<Microsoft.AspNetCore.Components.Forms.InputCheckbox>


    static member ref x = attr.ref<Microsoft.AspNetCore.Components.Forms.InputCheckbox> x |> GenericFunBlazorNode<'FunBlazorGeneric>.create

                    

type inputDate<'FunBlazorGeneric, 'TValue> =
    inherit inputBase<'FunBlazorGeneric, 'TValue>
    static member create () = [] |> html.blazor<Microsoft.AspNetCore.Components.Forms.InputDate<'TValue>>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<Microsoft.AspNetCore.Components.Forms.InputDate<'TValue>>

    static member ref x = attr.ref<Microsoft.AspNetCore.Components.Forms.InputDate<'TValue>> x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member parsingErrorMessage (x: System.String) = "ParsingErrorMessage" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type inputNumber<'FunBlazorGeneric, 'TValue> =
    inherit inputBase<'FunBlazorGeneric, 'TValue>
    static member create () = [] |> html.blazor<Microsoft.AspNetCore.Components.Forms.InputNumber<'TValue>>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<Microsoft.AspNetCore.Components.Forms.InputNumber<'TValue>>

    static member ref x = attr.ref<Microsoft.AspNetCore.Components.Forms.InputNumber<'TValue>> x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member parsingErrorMessage (x: System.String) = "ParsingErrorMessage" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type inputRadioGroup<'FunBlazorGeneric, 'TValue> =
    inherit inputBase<'FunBlazorGeneric, 'TValue>
    static member create () = [] |> html.blazor<Microsoft.AspNetCore.Components.Forms.InputRadioGroup<'TValue>>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<Microsoft.AspNetCore.Components.Forms.InputRadioGroup<'TValue>>
    static member create (nodes: IFunBlazorNode list) = nodes |> html.blazor<Microsoft.AspNetCore.Components.Forms.InputRadioGroup<'TValue>>
    static member create (node: IFunBlazorNode) = [ node ] |> html.blazor<Microsoft.AspNetCore.Components.Forms.InputRadioGroup<'TValue>>
    static member create (x: string) = [ html.text x ] |> html.blazor<Microsoft.AspNetCore.Components.Forms.InputRadioGroup<'TValue>>
    static member ref x = attr.ref<Microsoft.AspNetCore.Components.Forms.InputRadioGroup<'TValue>> x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member name (x: System.String) = "Name" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type inputSelect<'FunBlazorGeneric, 'TValue> =
    inherit inputBase<'FunBlazorGeneric, 'TValue>
    static member create () = [] |> html.blazor<Microsoft.AspNetCore.Components.Forms.InputSelect<'TValue>>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<Microsoft.AspNetCore.Components.Forms.InputSelect<'TValue>>
    static member create (nodes: IFunBlazorNode list) = nodes |> html.blazor<Microsoft.AspNetCore.Components.Forms.InputSelect<'TValue>>
    static member create (node: IFunBlazorNode) = [ node ] |> html.blazor<Microsoft.AspNetCore.Components.Forms.InputSelect<'TValue>>
    static member create (x: string) = [ html.text x ] |> html.blazor<Microsoft.AspNetCore.Components.Forms.InputSelect<'TValue>>
    static member ref x = attr.ref<Microsoft.AspNetCore.Components.Forms.InputSelect<'TValue>> x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type inputText<'FunBlazorGeneric> =
    inherit inputBase<'FunBlazorGeneric, System.String>
    static member create () = [] |> html.blazor<Microsoft.AspNetCore.Components.Forms.InputText>


    static member ref x = attr.ref<Microsoft.AspNetCore.Components.Forms.InputText> x |> GenericFunBlazorNode<'FunBlazorGeneric>.create

                    

type inputTextArea<'FunBlazorGeneric> =
    inherit inputBase<'FunBlazorGeneric, System.String>
    static member create () = [] |> html.blazor<Microsoft.AspNetCore.Components.Forms.InputTextArea>


    static member ref x = attr.ref<Microsoft.AspNetCore.Components.Forms.InputTextArea> x |> GenericFunBlazorNode<'FunBlazorGeneric>.create

                    

type inputFile<'FunBlazorGeneric> =
    
    static member create () = [] |> html.blazor<Microsoft.AspNetCore.Components.Forms.InputFile>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<Microsoft.AspNetCore.Components.Forms.InputFile>

    static member ref x = attr.ref<Microsoft.AspNetCore.Components.Forms.InputFile> x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member onChange fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Forms.InputFileChangeEventArgs> "OnChange" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member additionalAttributes (x: System.Collections.Generic.IDictionary<System.String, System.Object>) = "AdditionalAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type inputRadio<'FunBlazorGeneric, 'TValue> =
    
    static member create () = [] |> html.blazor<Microsoft.AspNetCore.Components.Forms.InputRadio<'TValue>>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<Microsoft.AspNetCore.Components.Forms.InputRadio<'TValue>>

    static member ref x = attr.ref<Microsoft.AspNetCore.Components.Forms.InputRadio<'TValue>> x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member additionalAttributes (x: System.Collections.Generic.IReadOnlyDictionary<System.String, System.Object>) = "AdditionalAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member value (x: 'TValue) = "Value" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member name (x: System.String) = "Name" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type validationMessage<'FunBlazorGeneric, 'TValue> =
    
    static member create () = [] |> html.blazor<Microsoft.AspNetCore.Components.Forms.ValidationMessage<'TValue>>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<Microsoft.AspNetCore.Components.Forms.ValidationMessage<'TValue>>

    static member ref x = attr.ref<Microsoft.AspNetCore.Components.Forms.ValidationMessage<'TValue>> x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member additionalAttributes (x: System.Collections.Generic.IReadOnlyDictionary<System.String, System.Object>) = "AdditionalAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member for' (x: System.Linq.Expressions.Expression<System.Func<'TValue>>) = "For" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type validationSummary<'FunBlazorGeneric> =
    
    static member create () = [] |> html.blazor<Microsoft.AspNetCore.Components.Forms.ValidationSummary>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<Microsoft.AspNetCore.Components.Forms.ValidationSummary>

    static member ref x = attr.ref<Microsoft.AspNetCore.Components.Forms.ValidationSummary> x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member model (x: System.Object) = "Model" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member additionalAttributes (x: System.Collections.Generic.IReadOnlyDictionary<System.String, System.Object>) = "AdditionalAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    
            

// ===========================================================================================

namespace Microsoft.AspNetCore.Components.Web

open Microsoft.AspNetCore.Components.Web.DslInternals


type IVirtualizeNode<'TItem> = interface end
type virtualize<'TItem> =
    class
        inherit virtualize<IVirtualizeNode<'TItem>, 'TItem>
    end
                    
            
namespace Microsoft.AspNetCore.Components.Web

open Microsoft.AspNetCore.Components.Web.DslInternals


type INavLinkNode = interface end
type navLink =
    class
        inherit navLink<INavLinkNode>
    end
                    
            
namespace Microsoft.AspNetCore.Components.Web

open Microsoft.AspNetCore.Components.Web.DslInternals


type IEditFormNode = interface end
type editForm =
    class
        inherit editForm<IEditFormNode>
    end
                    

type IInputBaseNode<'TValue> = interface end
type inputBase<'TValue> =
    class
        inherit inputBase<IInputBaseNode<'TValue>, 'TValue>
    end
                    

type IInputCheckboxNode = interface end
type inputCheckbox =
    class
        inherit inputCheckbox<IInputCheckboxNode>
    end
                    

type IInputDateNode<'TValue> = interface end
type inputDate<'TValue> =
    class
        inherit inputDate<IInputDateNode<'TValue>, 'TValue>
    end
                    

type IInputNumberNode<'TValue> = interface end
type inputNumber<'TValue> =
    class
        inherit inputNumber<IInputNumberNode<'TValue>, 'TValue>
    end
                    

type IInputRadioGroupNode<'TValue> = interface end
type inputRadioGroup<'TValue> =
    class
        inherit inputRadioGroup<IInputRadioGroupNode<'TValue>, 'TValue>
    end
                    

type IInputSelectNode<'TValue> = interface end
type inputSelect<'TValue> =
    class
        inherit inputSelect<IInputSelectNode<'TValue>, 'TValue>
    end
                    

type IInputTextNode = interface end
type inputText =
    class
        inherit inputText<IInputTextNode>
    end
                    

type IInputTextAreaNode = interface end
type inputTextArea =
    class
        inherit inputTextArea<IInputTextAreaNode>
    end
                    

type IInputFileNode = interface end
type inputFile =
    class
        inherit inputFile<IInputFileNode>
    end
                    

type IInputRadioNode<'TValue> = interface end
type inputRadio<'TValue> =
    class
        inherit inputRadio<IInputRadioNode<'TValue>, 'TValue>
    end
                    

type IValidationMessageNode<'TValue> = interface end
type validationMessage<'TValue> =
    class
        inherit validationMessage<IValidationMessageNode<'TValue>, 'TValue>
    end
                    

type IValidationSummaryNode = interface end
type validationSummary =
    class
        inherit validationSummary<IValidationSummaryNode>
    end
                    
            
    