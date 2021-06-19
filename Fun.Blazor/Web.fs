namespace rec Fun.Blazor.Web.Internal
open Bolero
open Bolero.Html
open Fun.Blazor


type virtualize<'FelizBoleroNode, 'TItem> =
    
    static member virtualize (nodes: GenericFelizNode<'FelizBoleroNode> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<Microsoft.AspNetCore.Components.Web.Virtualization.Virtualize<'TItem>>
    
    static member inline childContent (x: Microsoft.AspNetCore.Components.RenderFragment<'TItem>) = "ChildContent" => x |> BoleroAttr |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline itemContent (x: Microsoft.AspNetCore.Components.RenderFragment<'TItem>) = "ItemContent" => x |> BoleroAttr |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline placeholder (x: Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Web.Virtualization.PlaceholderContext>) = "Placeholder" => x |> BoleroAttr |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline itemSize (x: System.Single) = "ItemSize" => x |> BoleroAttr |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline itemsProvider (x: Microsoft.AspNetCore.Components.Web.Virtualization.ItemsProviderDelegate<'TItem>) = "ItemsProvider" => x |> BoleroAttr |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline items (x: System.Collections.Generic.IEnumerable<'TItem>) = "Items" => x |> BoleroAttr |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline overscanCount (x: System.Int32) = "OverscanCount" => x |> BoleroAttr |> GenericFelizNode<'FelizBoleroNode>.create
        

type navLink<'FelizBoleroNode> =
    
    static member navLink (nodes: GenericFelizNode<'FelizBoleroNode> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<Microsoft.AspNetCore.Components.Routing.NavLink>
    static member navLink (nodes: FunBlazorNode list) = nodes |> html.blazor<Microsoft.AspNetCore.Components.Routing.NavLink>
    static member inline activeClass (x: System.String) = "ActiveClass" => x |> BoleroAttr |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline additionalAttributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "AdditionalAttributes" => x |> BoleroAttr |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline children (text: string) = attr.children text |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline ``match`` (x: Microsoft.AspNetCore.Components.Routing.NavLinkMatch) = "Match" => x |> BoleroAttr |> GenericFelizNode<'FelizBoleroNode>.create
        

type editForm<'FelizBoleroNode> =
    
    static member editForm (nodes: GenericFelizNode<'FelizBoleroNode> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<Microsoft.AspNetCore.Components.Forms.EditForm>
    
    static member inline additionalAttributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "AdditionalAttributes" => x |> BoleroAttr |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline editContext (x: Microsoft.AspNetCore.Components.Forms.EditContext) = "EditContext" => x |> BoleroAttr |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline model (x: System.Object) = "Model" => x |> BoleroAttr |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline childContent (x: Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>) = "ChildContent" => x |> BoleroAttr |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline onSubmit fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Forms.EditContext> "OnSubmit" (fun e -> fn e)) |> BoleroAttr |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline onValidSubmit fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Forms.EditContext> "OnValidSubmit" (fun e -> fn e)) |> BoleroAttr |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline onInvalidSubmit fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Forms.EditContext> "OnInvalidSubmit" (fun e -> fn e)) |> BoleroAttr |> GenericFelizNode<'FelizBoleroNode>.create
        

type inputBase<'FelizBoleroNode, 'TValue> =
    
    static member inputBase (nodes: GenericFelizNode<'FelizBoleroNode> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<Microsoft.AspNetCore.Components.Forms.InputBase<'TValue>>
    
    static member inline additionalAttributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "AdditionalAttributes" => x |> BoleroAttr |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline value (x: 'TValue) = "Value" => x |> BoleroAttr |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline valueChanged fn = (Bolero.Html.attr.callback<'TValue> "ValueChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline valueExpression (x: System.Linq.Expressions.Expression<System.Func<'TValue>>) = "ValueExpression" => x |> BoleroAttr |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline displayName (x: System.String) = "DisplayName" => x |> BoleroAttr |> GenericFelizNode<'FelizBoleroNode>.create
        

type inputCheckbox<'FelizBoleroNode> =
    inherit inputBase<'FelizBoleroNode, System.Boolean>
    static member inputCheckbox (nodes: GenericFelizNode<'FelizBoleroNode> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<Microsoft.AspNetCore.Components.Forms.InputCheckbox>
    
    static member inline additionalAttributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "AdditionalAttributes" => x |> BoleroAttr |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline value (x: System.Boolean) = "Value" => x |> BoleroAttr |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline valueChanged fn = (Bolero.Html.attr.callback<System.Boolean> "ValueChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline valueExpression (x: System.Linq.Expressions.Expression<System.Func<System.Boolean>>) = "ValueExpression" => x |> BoleroAttr |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline displayName (x: System.String) = "DisplayName" => x |> BoleroAttr |> GenericFelizNode<'FelizBoleroNode>.create
        

type inputDate<'FelizBoleroNode, 'TValue> =
    inherit inputBase<'FelizBoleroNode, 'TValue>
    static member inputDate (nodes: GenericFelizNode<'FelizBoleroNode> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<Microsoft.AspNetCore.Components.Forms.InputDate<'TValue>>
    
    static member inline parsingErrorMessage (x: System.String) = "ParsingErrorMessage" => x |> BoleroAttr |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline additionalAttributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "AdditionalAttributes" => x |> BoleroAttr |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline value (x: 'TValue) = "Value" => x |> BoleroAttr |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline valueChanged fn = (Bolero.Html.attr.callback<'TValue> "ValueChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline valueExpression (x: System.Linq.Expressions.Expression<System.Func<'TValue>>) = "ValueExpression" => x |> BoleroAttr |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline displayName (x: System.String) = "DisplayName" => x |> BoleroAttr |> GenericFelizNode<'FelizBoleroNode>.create
        

type inputFile<'FelizBoleroNode> =
    
    static member inputFile (nodes: GenericFelizNode<'FelizBoleroNode> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<Microsoft.AspNetCore.Components.Forms.InputFile>
    
    static member inline onChange fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Forms.InputFileChangeEventArgs> "OnChange" (fun e -> fn e)) |> BoleroAttr |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline additionalAttributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "AdditionalAttributes" => x |> BoleroAttr |> GenericFelizNode<'FelizBoleroNode>.create
        

type inputNumber<'FelizBoleroNode, 'TValue> =
    inherit inputBase<'FelizBoleroNode, 'TValue>
    static member inputNumber (nodes: GenericFelizNode<'FelizBoleroNode> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<Microsoft.AspNetCore.Components.Forms.InputNumber<'TValue>>
    
    static member inline parsingErrorMessage (x: System.String) = "ParsingErrorMessage" => x |> BoleroAttr |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline additionalAttributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "AdditionalAttributes" => x |> BoleroAttr |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline value (x: 'TValue) = "Value" => x |> BoleroAttr |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline valueChanged fn = (Bolero.Html.attr.callback<'TValue> "ValueChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline valueExpression (x: System.Linq.Expressions.Expression<System.Func<'TValue>>) = "ValueExpression" => x |> BoleroAttr |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline displayName (x: System.String) = "DisplayName" => x |> BoleroAttr |> GenericFelizNode<'FelizBoleroNode>.create
        

type inputRadio<'FelizBoleroNode, 'TValue> =
    
    static member inputRadio (nodes: GenericFelizNode<'FelizBoleroNode> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<Microsoft.AspNetCore.Components.Forms.InputRadio<'TValue>>
    
    static member inline additionalAttributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "AdditionalAttributes" => x |> BoleroAttr |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline value (x: 'TValue) = "Value" => x |> BoleroAttr |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline name (x: System.String) = "Name" => x |> BoleroAttr |> GenericFelizNode<'FelizBoleroNode>.create
        

type inputRadioGroup<'FelizBoleroNode, 'TValue> =
    inherit inputBase<'FelizBoleroNode, 'TValue>
    static member inputRadioGroup (nodes: GenericFelizNode<'FelizBoleroNode> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<Microsoft.AspNetCore.Components.Forms.InputRadioGroup<'TValue>>
    static member inputRadioGroup (nodes: FunBlazorNode list) = nodes |> html.blazor<Microsoft.AspNetCore.Components.Forms.InputRadioGroup<'TValue>>
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline children (text: string) = attr.children text |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline name (x: System.String) = "Name" => x |> BoleroAttr |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline additionalAttributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "AdditionalAttributes" => x |> BoleroAttr |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline value (x: 'TValue) = "Value" => x |> BoleroAttr |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline valueChanged fn = (Bolero.Html.attr.callback<'TValue> "ValueChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline valueExpression (x: System.Linq.Expressions.Expression<System.Func<'TValue>>) = "ValueExpression" => x |> BoleroAttr |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline displayName (x: System.String) = "DisplayName" => x |> BoleroAttr |> GenericFelizNode<'FelizBoleroNode>.create
        

type inputSelect<'FelizBoleroNode, 'TValue> =
    inherit inputBase<'FelizBoleroNode, 'TValue>
    static member inputSelect (nodes: GenericFelizNode<'FelizBoleroNode> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<Microsoft.AspNetCore.Components.Forms.InputSelect<'TValue>>
    static member inputSelect (nodes: FunBlazorNode list) = nodes |> html.blazor<Microsoft.AspNetCore.Components.Forms.InputSelect<'TValue>>
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline children (text: string) = attr.children text |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline additionalAttributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "AdditionalAttributes" => x |> BoleroAttr |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline value (x: 'TValue) = "Value" => x |> BoleroAttr |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline valueChanged fn = (Bolero.Html.attr.callback<'TValue> "ValueChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline valueExpression (x: System.Linq.Expressions.Expression<System.Func<'TValue>>) = "ValueExpression" => x |> BoleroAttr |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline displayName (x: System.String) = "DisplayName" => x |> BoleroAttr |> GenericFelizNode<'FelizBoleroNode>.create
        

type inputText<'FelizBoleroNode> =
    inherit inputBase<'FelizBoleroNode, System.String>
    static member inputText (nodes: GenericFelizNode<'FelizBoleroNode> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<Microsoft.AspNetCore.Components.Forms.InputText>
    
    static member inline additionalAttributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "AdditionalAttributes" => x |> BoleroAttr |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline value (x: System.String) = "Value" => x |> BoleroAttr |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline valueChanged fn = (Bolero.Html.attr.callback<System.String> "ValueChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline valueExpression (x: System.Linq.Expressions.Expression<System.Func<System.String>>) = "ValueExpression" => x |> BoleroAttr |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline displayName (x: System.String) = "DisplayName" => x |> BoleroAttr |> GenericFelizNode<'FelizBoleroNode>.create
        

type inputTextArea<'FelizBoleroNode> =
    inherit inputBase<'FelizBoleroNode, System.String>
    static member inputTextArea (nodes: GenericFelizNode<'FelizBoleroNode> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<Microsoft.AspNetCore.Components.Forms.InputTextArea>
    
    static member inline additionalAttributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "AdditionalAttributes" => x |> BoleroAttr |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline value (x: System.String) = "Value" => x |> BoleroAttr |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline valueChanged fn = (Bolero.Html.attr.callback<System.String> "ValueChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline valueExpression (x: System.Linq.Expressions.Expression<System.Func<System.String>>) = "ValueExpression" => x |> BoleroAttr |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline displayName (x: System.String) = "DisplayName" => x |> BoleroAttr |> GenericFelizNode<'FelizBoleroNode>.create
        

type validationMessage<'FelizBoleroNode, 'TValue> =
    
    static member validationMessage (nodes: GenericFelizNode<'FelizBoleroNode> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<Microsoft.AspNetCore.Components.Forms.ValidationMessage<'TValue>>
    
    static member inline additionalAttributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "AdditionalAttributes" => x |> BoleroAttr |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline ``for`` (x: System.Linq.Expressions.Expression<System.Func<'TValue>>) = "For" => x |> BoleroAttr |> GenericFelizNode<'FelizBoleroNode>.create
        

type validationSummary<'FelizBoleroNode> =
    
    static member validationSummary (nodes: GenericFelizNode<'FelizBoleroNode> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<Microsoft.AspNetCore.Components.Forms.ValidationSummary>
    
    static member inline model (x: System.Object) = "Model" => x |> BoleroAttr |> GenericFelizNode<'FelizBoleroNode>.create
    static member inline additionalAttributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "AdditionalAttributes" => x |> BoleroAttr |> GenericFelizNode<'FelizBoleroNode>.create
        

namespace rec Fun.Blazor.Web

type IVirtualizeNode<'TItem> = interface end

type virtualize<'TItem> =
    class
        inherit Internal.virtualize<IVirtualizeNode<'TItem>, 'TItem>
    end

type INavLinkNode = interface end

type navLink =
    class
        inherit Internal.navLink<INavLinkNode>
    end

type IEditFormNode = interface end

type editForm =
    class
        inherit Internal.editForm<IEditFormNode>
    end

type IInputBaseNode<'TValue> = interface end

type inputBase<'TValue> =
    class
        inherit Internal.inputBase<IInputBaseNode<'TValue>, 'TValue>
    end

type IInputCheckboxNode = interface end

type inputCheckbox =
    class
        inherit Internal.inputCheckbox<IInputCheckboxNode>
    end

type IInputDateNode<'TValue> = interface end

type inputDate<'TValue> =
    class
        inherit Internal.inputDate<IInputDateNode<'TValue>, 'TValue>
    end

type IInputFileNode = interface end

type inputFile =
    class
        inherit Internal.inputFile<IInputFileNode>
    end

type IInputNumberNode<'TValue> = interface end

type inputNumber<'TValue> =
    class
        inherit Internal.inputNumber<IInputNumberNode<'TValue>, 'TValue>
    end

type IInputRadioNode<'TValue> = interface end

type inputRadio<'TValue> =
    class
        inherit Internal.inputRadio<IInputRadioNode<'TValue>, 'TValue>
    end

type IInputRadioGroupNode<'TValue> = interface end

type inputRadioGroup<'TValue> =
    class
        inherit Internal.inputRadioGroup<IInputRadioGroupNode<'TValue>, 'TValue>
    end

type IInputSelectNode<'TValue> = interface end

type inputSelect<'TValue> =
    class
        inherit Internal.inputSelect<IInputSelectNode<'TValue>, 'TValue>
    end

type IInputTextNode = interface end

type inputText =
    class
        inherit Internal.inputText<IInputTextNode>
    end

type IInputTextAreaNode = interface end

type inputTextArea =
    class
        inherit Internal.inputTextArea<IInputTextAreaNode>
    end

type IValidationMessageNode<'TValue> = interface end

type validationMessage<'TValue> =
    class
        inherit Internal.validationMessage<IValidationMessageNode<'TValue>, 'TValue>
    end

type IValidationSummaryNode = interface end

type validationSummary =
    class
        inherit Internal.validationSummary<IValidationSummaryNode>
    end
