namespace rec Fun.Blazor.Web.DslInternals

open Bolero.Html
open Fun.Blazor
open Fun.Blazor.Web.DslInternals


type virtualize<'FunBlazorGeneric, 'TItem> =
    
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<Microsoft.AspNetCore.Components.Web.Virtualization.Virtualize<'TItem>>    
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<Microsoft.AspNetCore.Components.Web.Virtualization.Virtualize<'TItem>>
    static member create (node: FunBlazorNode) = [ node ] |> html.blazor<Microsoft.AspNetCore.Components.Web.Virtualization.Virtualize<'TItem>>    
    static member inline childContent (render: 'TItem -> FunBlazorNode) = Bolero.Html.attr.fragmentWith "ChildContent" (fun x -> render x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline itemContent (render: 'TItem -> FunBlazorNode) = Bolero.Html.attr.fragmentWith "ItemContent" (fun x -> render x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline placeholder (render: Microsoft.AspNetCore.Components.Web.Virtualization.PlaceholderContext -> FunBlazorNode) = Bolero.Html.attr.fragmentWith "Placeholder" (fun x -> render x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline itemSize (x: System.Single) = "ItemSize" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline itemsProvider (x: Microsoft.AspNetCore.Components.Web.Virtualization.ItemsProviderDelegate<'TItem>) = "ItemsProvider" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline items (x: System.Collections.Generic.ICollection<'TItem>) = "Items" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline overscanCount (x: System.Int32) = "OverscanCount" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    
            
namespace rec Fun.Blazor.Web.DslInternals

open Bolero.Html
open Fun.Blazor
open Fun.Blazor.Web.DslInternals


type navLink<'FunBlazorGeneric> =
    
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<Microsoft.AspNetCore.Components.Routing.NavLink>    
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<Microsoft.AspNetCore.Components.Routing.NavLink>
    static member create (node: FunBlazorNode) = [ node ] |> html.blazor<Microsoft.AspNetCore.Components.Routing.NavLink>    
    static member inline activeClass (x: System.String) = "ActiveClass" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline additionalAttributes (x: System.Collections.Generic.IReadOnlyDictionary<System.String, System.Object>) = "AdditionalAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline match' (x: Microsoft.AspNetCore.Components.Routing.NavLinkMatch) = "Match" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    
            
namespace rec Fun.Blazor.Web.DslInternals

open Bolero.Html
open Fun.Blazor
open Fun.Blazor.Web.DslInternals


type editForm<'FunBlazorGeneric> =
    
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<Microsoft.AspNetCore.Components.Forms.EditForm>    
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<Microsoft.AspNetCore.Components.Forms.EditForm>
    static member create (node: FunBlazorNode) = [ node ] |> html.blazor<Microsoft.AspNetCore.Components.Forms.EditForm>    
    static member inline additionalAttributes (x: System.Collections.Generic.IReadOnlyDictionary<System.String, System.Object>) = "AdditionalAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline editContext (x: Microsoft.AspNetCore.Components.Forms.EditContext) = "EditContext" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline model (x: System.Object) = "Model" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (render: Microsoft.AspNetCore.Components.Forms.EditContext -> FunBlazorNode) = Bolero.Html.attr.fragmentWith "ChildContent" (fun x -> render x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onSubmit fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Forms.EditContext> "OnSubmit" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onValidSubmit fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Forms.EditContext> "OnValidSubmit" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onInvalidSubmit fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Forms.EditContext> "OnInvalidSubmit" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type inputBase<'FunBlazorGeneric, 'TValue> =
    
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<Microsoft.AspNetCore.Components.Forms.InputBase<'TValue>>    
    
    static member inline additionalAttributes (x: System.Collections.Generic.IReadOnlyDictionary<System.String, System.Object>) = "AdditionalAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline value (x: 'TValue) = "Value" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valueChanged fn = (Bolero.Html.attr.callback<'TValue> "ValueChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valueExpression (x: System.Linq.Expressions.Expression<System.Func<'TValue>>) = "ValueExpression" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline displayName (x: System.String) = "DisplayName" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type inputFile<'FunBlazorGeneric> =
    
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<Microsoft.AspNetCore.Components.Forms.InputFile>    
    
    static member inline onChange fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Forms.InputFileChangeEventArgs> "OnChange" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline additionalAttributes (x: System.Collections.Generic.IDictionary<System.String, System.Object>) = "AdditionalAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type inputRadio<'FunBlazorGeneric, 'TValue> =
    
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<Microsoft.AspNetCore.Components.Forms.InputRadio<'TValue>>    
    
    static member inline additionalAttributes (x: System.Collections.Generic.IReadOnlyDictionary<System.String, System.Object>) = "AdditionalAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline value (x: 'TValue) = "Value" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline name (x: System.String) = "Name" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type validationMessage<'FunBlazorGeneric, 'TValue> =
    
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<Microsoft.AspNetCore.Components.Forms.ValidationMessage<'TValue>>    
    
    static member inline additionalAttributes (x: System.Collections.Generic.IReadOnlyDictionary<System.String, System.Object>) = "AdditionalAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline for' (x: System.Linq.Expressions.Expression<System.Func<'TValue>>) = "For" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type validationSummary<'FunBlazorGeneric> =
    
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<Microsoft.AspNetCore.Components.Forms.ValidationSummary>    
    
    static member inline model (x: System.Object) = "Model" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline additionalAttributes (x: System.Collections.Generic.IReadOnlyDictionary<System.String, System.Object>) = "AdditionalAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    
            

// ===========================================================================================

namespace Fun.Blazor.Web

open Fun.Blazor.Web.DslInternals


type IVirtualizeNode<'TItem> = interface end
type virtualize<'TItem> =
    class
        inherit virtualize<IVirtualizeNode<'TItem>, 'TItem>
    end
                    
            
namespace Fun.Blazor.Web

open Fun.Blazor.Web.DslInternals


type INavLinkNode = interface end
type navLink =
    class
        inherit navLink<INavLinkNode>
    end
                    
            
namespace Fun.Blazor.Web

open Fun.Blazor.Web.DslInternals


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
                    
            