namespace rec Fun.Blazor.MatBlazor.Internal

open Bolero
open Bolero.Html
open Fun.Blazor
open Fun.Blazor.Web.Internal


type baseMatComponent<'FunBlazorGeneric> =
    
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MatBlazor.BaseMatComponent>
    
    static member inline refBack (x: MatBlazor.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type baseMatContainerComponent<'FunBlazorGeneric> =
    inherit baseMatDomComponent<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MatBlazor.BaseMatContainerComponent>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<MatBlazor.BaseMatContainerComponent>
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline tag (x: System.String) = "Tag" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline attributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "Attributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: MatBlazor.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type baseMatDomComponent<'FunBlazorGeneric> =
    inherit baseMatComponent<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MatBlazor.BaseMatDomComponent>
    
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline attributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "Attributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: MatBlazor.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type baseMatInputComponent<'FunBlazorGeneric, 'T> =
    inherit baseMatDomComponent<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MatBlazor.BaseMatInputComponent<'T>>
    
    static member inline validationDisabled (x: System.Boolean) = "ValidationDisabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline value (x: 'T) = "Value" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valueChanged fn = (Bolero.Html.attr.callback<'T> "ValueChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valueExpression (x: System.Linq.Expressions.Expression<System.Func<'T>>) = "ValueExpression" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline attributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "Attributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: MatBlazor.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type baseMatInputElementComponent<'FunBlazorGeneric, 'T> =
    inherit baseMatInputComponent<'FunBlazorGeneric, 'T>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MatBlazor.BaseMatInputElementComponent<'T>>
    
    static member inline inputAttributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "InputAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline validationDisabled (x: System.Boolean) = "ValidationDisabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline value (x: 'T) = "Value" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valueChanged fn = (Bolero.Html.attr.callback<'T> "ValueChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valueExpression (x: System.Linq.Expressions.Expression<System.Func<'T>>) = "ValueExpression" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline attributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "Attributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: MatBlazor.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type baseMatInputTextElementComponent<'FunBlazorGeneric, 'T> =
    inherit baseMatInputElementComponent<'FunBlazorGeneric, 'T>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MatBlazor.BaseMatInputTextElementComponent<'T>>
    
    static member inline format (x: System.String) = "Format" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline inputAttributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "InputAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline validationDisabled (x: System.Boolean) = "ValidationDisabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline value (x: 'T) = "Value" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valueChanged fn = (Bolero.Html.attr.callback<'T> "ValueChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valueExpression (x: System.Linq.Expressions.Expression<System.Func<'T>>) = "ValueExpression" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline attributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "Attributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: MatBlazor.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type matComponentHost<'FunBlazorGeneric> =
    
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MatBlazor.MatComponentHost>
    
    static member inline ``type`` (x: System.Type) = "Type" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline attributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "Attributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type matAccordion<'FunBlazorGeneric> =
    inherit baseMatDomComponent<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MatBlazor.MatAccordion>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<MatBlazor.MatAccordion>
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline multi (x: System.Boolean) = "Multi" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline hideToggle (x: System.Boolean) = "HideToggle" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline lazyRendering (x: System.Boolean) = "LazyRendering" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline attributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "Attributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: MatBlazor.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type matExpansionPanel<'FunBlazorGeneric> =
    inherit baseMatDomComponent<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MatBlazor.MatExpansionPanel>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<MatBlazor.MatExpansionPanel>
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline expanded (x: System.Boolean) = "Expanded" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline hideToggle (x: System.Boolean) = "HideToggle" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline lazyRendering (x: System.Boolean) = "LazyRendering" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline expandedChanged fn = (Bolero.Html.attr.callback<System.Boolean> "ExpandedChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline attributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "Attributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: MatBlazor.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type matExpansionPanelDetails<'FunBlazorGeneric> =
    inherit baseMatDomComponent<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MatBlazor.MatExpansionPanelDetails>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<MatBlazor.MatExpansionPanelDetails>
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline attributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "Attributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: MatBlazor.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type matExpansionPanelHeader<'FunBlazorGeneric> =
    inherit baseMatDomComponent<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MatBlazor.MatExpansionPanelHeader>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<MatBlazor.MatExpansionPanelHeader>
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline attributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "Attributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: MatBlazor.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type matExpansionPanelSubHeader<'FunBlazorGeneric> =
    inherit baseMatDomComponent<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MatBlazor.MatExpansionPanelSubHeader>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<MatBlazor.MatExpansionPanelSubHeader>
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline attributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "Attributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: MatBlazor.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type matExpansionPanelSummary<'FunBlazorGeneric> =
    inherit baseMatDomComponent<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MatBlazor.MatExpansionPanelSummary>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<MatBlazor.MatExpansionPanelSummary>
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline attributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "Attributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: MatBlazor.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type matAnchorContainer<'FunBlazorGeneric> =
    inherit baseMatDomComponent<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MatBlazor.MatAnchorContainer>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<MatBlazor.MatAnchorContainer>
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline anchor (x: System.String) = "Anchor" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline attributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "Attributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: MatBlazor.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type matAnchorLink<'FunBlazorGeneric> =
    inherit baseMatDomComponent<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MatBlazor.MatAnchorLink>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<MatBlazor.MatAnchorLink>
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline attributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "Attributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: MatBlazor.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type matAnchorUtils<'FunBlazorGeneric> =
    
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MatBlazor.MatAnchorUtils>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<MatBlazor.MatAnchorUtils>
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type matAppBar<'FunBlazorGeneric> =
    inherit baseMatDomComponent<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MatBlazor.MatAppBar>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<MatBlazor.MatAppBar>
    static member inline short (x: System.Boolean) = "Short" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline ``fixed`` (x: System.Boolean) = "Fixed" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline attributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "Attributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: MatBlazor.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type matAppBarAction<'FunBlazorGeneric> =
    inherit baseMatDomComponent<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MatBlazor.MatAppBarAction>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<MatBlazor.MatAppBarAction>
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onClick fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnClick" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline icon (x: System.String) = "Icon" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline label (x: System.String) = "Label" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline attributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "Attributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: MatBlazor.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type matAppBarAdjust<'FunBlazorGeneric> =
    inherit baseMatDomComponent<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MatBlazor.MatAppBarAdjust>
    
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline attributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "Attributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: MatBlazor.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type matAppBarContainer<'FunBlazorGeneric> =
    inherit baseMatDomComponent<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MatBlazor.MatAppBarContainer>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<MatBlazor.MatAppBarContainer>
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline attributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "Attributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: MatBlazor.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type matAppBarContent<'FunBlazorGeneric> =
    inherit baseMatDomComponent<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MatBlazor.MatAppBarContent>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<MatBlazor.MatAppBarContent>
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline attributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "Attributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: MatBlazor.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type matAppBarNavigationIcon<'FunBlazorGeneric> =
    inherit baseMatDomComponent<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MatBlazor.MatAppBarNavigationIcon>
    
    static member inline onClick fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnClick" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline attributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "Attributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: MatBlazor.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type matAppBarRow<'FunBlazorGeneric> =
    inherit baseMatDomComponent<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MatBlazor.MatAppBarRow>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<MatBlazor.MatAppBarRow>
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline attributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "Attributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: MatBlazor.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type matAppBarSection<'FunBlazorGeneric> =
    inherit baseMatDomComponent<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MatBlazor.MatAppBarSection>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<MatBlazor.MatAppBarSection>
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline align (x: MatBlazor.MatAppBarSectionAlign) = "Align" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline attributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "Attributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: MatBlazor.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type matAppBarTitle<'FunBlazorGeneric> =
    inherit baseMatDomComponent<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MatBlazor.MatAppBarTitle>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<MatBlazor.MatAppBarTitle>
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline attributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "Attributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: MatBlazor.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type baseMatAutocompleteList<'FunBlazorGeneric, 'TItem> =
    inherit baseMatDomComponent<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MatBlazor.BaseMatAutocompleteList<'TItem>>
    
    static member inline numberOfElementsInPopup (x: System.Nullable<System.Int32>) = "NumberOfElementsInPopup" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline label (x: System.String) = "Label" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline icon (x: System.String) = "Icon" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline stringValue (x: System.String) = "StringValue" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline value (x: 'TItem) = "Value" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valueChanged fn = (Bolero.Html.attr.callback<'TItem> "ValueChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline itemTemplate (x: Microsoft.AspNetCore.Components.RenderFragment<'TItem>) = "ItemTemplate" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline customStringSelector (x: System.Func<'TItem, System.String>) = "CustomStringSelector" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline items (x: System.Collections.Generic.IEnumerable<'TItem>) = "Items" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline outlined (x: System.Boolean) = "Outlined" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onOpenedChanged fn = (Bolero.Html.attr.callback<System.Boolean> "OnOpenedChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onTextChanged fn = (Bolero.Html.attr.callback<System.String> "OnTextChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline showClearButton (x: System.Boolean) = "ShowClearButton" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline fullWidth (x: System.Boolean) = "FullWidth" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline attributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "Attributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: MatBlazor.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type baseMatAutocomplete<'FunBlazorGeneric, 'TValue, 'TItem> =
    inherit matInputTextComponent<'FunBlazorGeneric, 'TValue>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MatBlazor.BaseMatAutocomplete<'TValue, 'TItem>>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<MatBlazor.BaseMatAutocomplete<'TValue, 'TItem>>
    static member inline items (x: System.Collections.Generic.IEnumerable<'TItem>) = "Items" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline itemValueSelector (x: System.Func<'TItem, 'TValue>) = "ItemValueSelector" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline numberOfElementsInPopup (x: System.Nullable<System.Int32>) = "NumberOfElementsInPopup" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline itemTemplate (x: Microsoft.AspNetCore.Components.RenderFragment<'TItem>) = "ItemTemplate" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline iconOnClick fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "IconOnClick" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onFocus fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.FocusEventArgs> "OnFocus" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onFocusOut fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.FocusEventArgs> "OnFocusOut" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onKeyPress fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs> "OnKeyPress" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onKeyDown fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs> "OnKeyDown" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onKeyUp fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs> "OnKeyUp" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onInput fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.ChangeEventArgs> "OnInput" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline label (x: System.String) = "Label" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline icon (x: System.String) = "Icon" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline iconTrailing (x: System.Boolean) = "IconTrailing" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline box (x: System.Boolean) = "Box" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline textArea (x: System.Boolean) = "TextArea" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline dense (x: System.Boolean) = "Dense" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline outlined (x: System.Boolean) = "Outlined" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabled (x: System.Boolean) = "Disabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline readOnly (x: System.Boolean) = "ReadOnly" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline fullWidth (x: System.Boolean) = "FullWidth" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline required (x: System.Boolean) = "Required" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline helperText (x: System.String) = "HelperText" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline helperTextPersistent (x: System.Boolean) = "HelperTextPersistent" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline helperTextValidation (x: System.Boolean) = "HelperTextValidation" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline placeHolder (x: System.String) = "PlaceHolder" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline hideClearButton (x: System.Boolean) = "HideClearButton" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline ``type`` (x: System.String) = "Type" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline inputClass (x: System.String) = "InputClass" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline inputStyle (x: System.String) = "InputStyle" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline format (x: System.String) = "Format" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline inputAttributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "InputAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline validationDisabled (x: System.Boolean) = "ValidationDisabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline value (x: 'TValue) = "Value" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valueChanged fn = (Bolero.Html.attr.callback<'TValue> "ValueChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valueExpression (x: System.Linq.Expressions.Expression<System.Func<'TValue>>) = "ValueExpression" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline attributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "Attributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: MatBlazor.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type baseMatButtonLink<'FunBlazorGeneric> =
    inherit baseMatDomComponent<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MatBlazor.BaseMatButtonLink>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<MatBlazor.BaseMatButtonLink>
    static member inline onClick fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnClick" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onClickStopPropagation (x: System.Boolean) = "OnClickStopPropagation" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline command (x: System.Windows.Input.ICommand) = "Command" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline commandParameter (x: System.Object) = "CommandParameter" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline href (x: System.String) = "Href" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline forceLoad (x: System.Boolean) = "ForceLoad" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline target (x: System.String) = "Target" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline raised (x: System.Boolean) = "Raised" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline unelevated (x: System.Boolean) = "Unelevated" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline outlined (x: System.Boolean) = "Outlined" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline dense (x: System.Boolean) = "Dense" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabled (x: System.Boolean) = "Disabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline icon (x: System.String) = "Icon" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline trailingIcon (x: System.String) = "TrailingIcon" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline attributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "Attributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: MatBlazor.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type matButton<'FunBlazorGeneric> =
    inherit baseMatDomComponent<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MatBlazor.MatButton>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<MatBlazor.MatButton>
    static member inline onClick fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnClick" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onClickStopPropagation (x: System.Boolean) = "OnClickStopPropagation" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline command (x: System.Windows.Input.ICommand) = "Command" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline ``type`` (x: System.String) = "Type" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline name (x: System.String) = "Name" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline value (x: System.String) = "Value" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline commandParameter (x: System.Object) = "CommandParameter" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline link (x: System.String) = "Link" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline forceLoad (x: System.Boolean) = "ForceLoad" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline target (x: System.String) = "Target" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline raised (x: System.Boolean) = "Raised" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline unelevated (x: System.Boolean) = "Unelevated" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline outlined (x: System.Boolean) = "Outlined" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline dense (x: System.Boolean) = "Dense" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabled (x: System.Boolean) = "Disabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline icon (x: System.String) = "Icon" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline trailingIcon (x: System.String) = "TrailingIcon" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline label (x: System.String) = "Label" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline attributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "Attributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: MatBlazor.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type matCard<'FunBlazorGeneric> =
    inherit baseMatDomComponent<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MatBlazor.MatCard>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<MatBlazor.MatCard>
    static member inline stroke (x: System.Boolean) = "Stroke" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline attributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "Attributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: MatBlazor.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type matCardActionButtons<'FunBlazorGeneric> =
    inherit baseMatContainerComponent<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MatBlazor.MatCardActionButtons>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<MatBlazor.MatCardActionButtons>
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline tag (x: System.String) = "Tag" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline attributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "Attributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: MatBlazor.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type matCardActionIcons<'FunBlazorGeneric> =
    inherit baseMatContainerComponent<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MatBlazor.MatCardActionIcons>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<MatBlazor.MatCardActionIcons>
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline tag (x: System.String) = "Tag" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline attributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "Attributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: MatBlazor.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type matCardActions<'FunBlazorGeneric> =
    inherit baseMatDomComponent<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MatBlazor.MatCardActions>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<MatBlazor.MatCardActions>
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline attributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "Attributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: MatBlazor.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type matCardContent<'FunBlazorGeneric> =
    inherit baseMatDomComponent<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MatBlazor.MatCardContent>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<MatBlazor.MatCardContent>
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline unbounded (x: System.Boolean) = "Unbounded" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline attributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "Attributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: MatBlazor.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type matCardMedia<'FunBlazorGeneric> =
    inherit baseMatDomComponent<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MatBlazor.MatCardMedia>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<MatBlazor.MatCardMedia>
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline square (x: System.Boolean) = "Square" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline wide (x: System.Boolean) = "Wide" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline contentClass (x: System.String) = "ContentClass" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline imageUrl (x: System.String) = "ImageUrl" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline attributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "Attributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: MatBlazor.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type baseMatCheckboxInternal<'FunBlazorGeneric, 'TValue> =
    inherit baseMatInputElementComponent<'FunBlazorGeneric, 'TValue>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MatBlazor.BaseMatCheckboxInternal<'TValue>>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<MatBlazor.BaseMatCheckboxInternal<'TValue>>
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline label (x: System.String) = "Label" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline indeterminate (x: System.Boolean) = "Indeterminate" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabled (x: System.Boolean) = "Disabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline inputValue (x: System.String) = "InputValue" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline inputAttributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "InputAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline validationDisabled (x: System.Boolean) = "ValidationDisabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline value (x: 'TValue) = "Value" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valueChanged fn = (Bolero.Html.attr.callback<'TValue> "ValueChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valueExpression (x: System.Linq.Expressions.Expression<System.Func<'TValue>>) = "ValueExpression" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline attributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "Attributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: MatBlazor.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type matCheckbox<'FunBlazorGeneric, 'TValue> =
    inherit matCheckboxInternal<'FunBlazorGeneric, 'TValue>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MatBlazor.MatCheckbox<'TValue>>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<MatBlazor.MatCheckbox<'TValue>>
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline label (x: System.String) = "Label" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline indeterminate (x: System.Boolean) = "Indeterminate" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabled (x: System.Boolean) = "Disabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline inputValue (x: System.String) = "InputValue" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline inputAttributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "InputAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline validationDisabled (x: System.Boolean) = "ValidationDisabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline value (x: 'TValue) = "Value" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valueChanged fn = (Bolero.Html.attr.callback<'TValue> "ValueChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valueExpression (x: System.Linq.Expressions.Expression<System.Func<'TValue>>) = "ValueExpression" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline attributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "Attributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: MatBlazor.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type matChipSet<'FunBlazorGeneric> =
    inherit baseMatDomComponent<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MatBlazor.MatChipSet>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<MatBlazor.MatChipSet>
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline choice (x: System.Boolean) = "Choice" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline filter (x: System.Boolean) = "Filter" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline selectedChip (x: MatBlazor.MatChip) = "SelectedChip" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline selectedChipChanged fn = (Bolero.Html.attr.callback<MatBlazor.MatChip> "SelectedChipChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline selectedChips (x: System.Collections.Generic.IEnumerable<MatBlazor.MatChip>) = "SelectedChips" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline selectedChipsChanged fn = (Bolero.Html.attr.callback<System.Collections.Generic.IEnumerable<MatBlazor.MatChip>> "SelectedChipsChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline attributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "Attributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: MatBlazor.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type matChip<'FunBlazorGeneric> =
    inherit baseMatDomComponent<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MatBlazor.MatChip>
    
    static member inline leadingIcon (x: System.String) = "LeadingIcon" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline trailingIcon (x: System.String) = "TrailingIcon" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline trailingIconClick fn = (Bolero.Html.attr.callback<MatBlazor.MatChip> "TrailingIconClick" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline label (x: System.String) = "Label" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline value (x: System.Object) = "Value" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline isSelected (x: System.Boolean) = "IsSelected" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline isSelectedChanged fn = (Bolero.Html.attr.callback<System.Boolean> "IsSelectedChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline isCheckable (x: System.Boolean) = "IsCheckable" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline attributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "Attributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: MatBlazor.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type baseMatDataTableColumnOld<'FunBlazorGeneric, 'TItem> =
    
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MatBlazor.BaseMatDataTableColumnOld<'TItem>>
    
    static member inline template (x: Microsoft.AspNetCore.Components.RenderFragment<'TItem>) = "Template" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline header (x: System.String) = "Header" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline headerTemplate (x: Microsoft.AspNetCore.Components.RenderFragment) = "HeaderTemplate" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline value (x: System.Func<'TItem, System.Object>) = "Value" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline sort (x: System.Boolean) = "Sort" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type baseMatDataTableOld<'FunBlazorGeneric, 'TItem> =
    inherit baseMatDomComponent<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MatBlazor.BaseMatDataTableOld<'TItem>>
    
    static member inline items (x: System.Collections.Generic.IEnumerable<'TItem>) = "Items" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline columns (x: Microsoft.AspNetCore.Components.RenderFragment) = "Columns" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline stickyHeader (x: System.Boolean) = "StickyHeader" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline virtualScroll (x: System.Boolean) = "VirtualScroll" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline paginator (x: System.Boolean) = "Paginator" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline pageSizeOptions (x: System.Collections.Generic.IEnumerable<MatBlazor.MatPageSizeOption>) = "PageSizeOptions" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline pageSize (x: System.Int32) = "PageSize" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline pageIndex (x: System.Int32) = "PageIndex" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline pageLabel (x: System.String) = "PageLabel" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline attributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "Attributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: MatBlazor.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type matDataTable<'FunBlazorGeneric> =
    inherit baseMatDomComponent<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MatBlazor.MatDataTable>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<MatBlazor.MatDataTable>
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline attributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "Attributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: MatBlazor.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type matDataTableColumn<'FunBlazorGeneric> =
    
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MatBlazor.MatDataTableColumn>
    
    static member inline value (x: System.Object) = "Value" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline header (x: System.String) = "Header" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type matDataTableContent<'FunBlazorGeneric, 'TItem> =
    inherit baseMatDomComponent<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MatBlazor.MatDataTableContent<'TItem>>
    
    static member inline items (x: System.Collections.Generic.IEnumerable<'TItem>) = "Items" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (x: Microsoft.AspNetCore.Components.RenderFragment<'TItem>) = "ChildContent" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline attributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "Attributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: MatBlazor.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type baseMatDatePickerInternal<'FunBlazorGeneric, 'TValue> =
    inherit matInputTextComponent<'FunBlazorGeneric, 'TValue>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MatBlazor.BaseMatDatePickerInternal<'TValue>>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<MatBlazor.BaseMatDatePickerInternal<'TValue>>
    static member inline enableTime (x: System.Boolean) = "EnableTime" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline enableSeconds (x: System.Boolean) = "EnableSeconds" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline maximum (x: System.Nullable<System.DateTime>) = "Maximum" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline minimum (x: System.Nullable<System.DateTime>) = "Minimum" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disableCalendar (x: System.Boolean) = "DisableCalendar" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline enable24hours (x: System.Boolean) = "Enable24hours" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline enableWeekNumbers (x: System.Boolean) = "EnableWeekNumbers" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline allowInput (x: System.Boolean) = "AllowInput" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disableMobile (x: System.Boolean) = "DisableMobile" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline position (x: MatBlazor.MatDatePickerPosition) = "Position" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline locale (x: System.String) = "Locale" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline iconOnClick fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "IconOnClick" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onFocus fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.FocusEventArgs> "OnFocus" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onFocusOut fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.FocusEventArgs> "OnFocusOut" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onKeyPress fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs> "OnKeyPress" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onKeyDown fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs> "OnKeyDown" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onKeyUp fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs> "OnKeyUp" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onInput fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.ChangeEventArgs> "OnInput" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline label (x: System.String) = "Label" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline icon (x: System.String) = "Icon" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline iconTrailing (x: System.Boolean) = "IconTrailing" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline box (x: System.Boolean) = "Box" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline textArea (x: System.Boolean) = "TextArea" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline dense (x: System.Boolean) = "Dense" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline outlined (x: System.Boolean) = "Outlined" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabled (x: System.Boolean) = "Disabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline readOnly (x: System.Boolean) = "ReadOnly" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline fullWidth (x: System.Boolean) = "FullWidth" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline required (x: System.Boolean) = "Required" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline helperText (x: System.String) = "HelperText" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline helperTextPersistent (x: System.Boolean) = "HelperTextPersistent" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline helperTextValidation (x: System.Boolean) = "HelperTextValidation" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline placeHolder (x: System.String) = "PlaceHolder" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline hideClearButton (x: System.Boolean) = "HideClearButton" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline ``type`` (x: System.String) = "Type" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline inputClass (x: System.String) = "InputClass" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline inputStyle (x: System.String) = "InputStyle" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline format (x: System.String) = "Format" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline inputAttributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "InputAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline validationDisabled (x: System.Boolean) = "ValidationDisabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline value (x: 'TValue) = "Value" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valueChanged fn = (Bolero.Html.attr.callback<'TValue> "ValueChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valueExpression (x: System.Linq.Expressions.Expression<System.Func<'TValue>>) = "ValueExpression" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline attributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "Attributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: MatBlazor.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type matDatePicker<'FunBlazorGeneric, 'TValue> =
    inherit matDatePickerInternal<'FunBlazorGeneric, 'TValue>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MatBlazor.MatDatePicker<'TValue>>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<MatBlazor.MatDatePicker<'TValue>>
    static member inline enableTime (x: System.Boolean) = "EnableTime" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline enableSeconds (x: System.Boolean) = "EnableSeconds" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline maximum (x: System.Nullable<System.DateTime>) = "Maximum" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline minimum (x: System.Nullable<System.DateTime>) = "Minimum" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disableCalendar (x: System.Boolean) = "DisableCalendar" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline enable24hours (x: System.Boolean) = "Enable24hours" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline enableWeekNumbers (x: System.Boolean) = "EnableWeekNumbers" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline allowInput (x: System.Boolean) = "AllowInput" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disableMobile (x: System.Boolean) = "DisableMobile" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline position (x: MatBlazor.MatDatePickerPosition) = "Position" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline locale (x: System.String) = "Locale" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline iconOnClick fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "IconOnClick" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onFocus fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.FocusEventArgs> "OnFocus" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onFocusOut fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.FocusEventArgs> "OnFocusOut" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onKeyPress fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs> "OnKeyPress" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onKeyDown fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs> "OnKeyDown" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onKeyUp fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs> "OnKeyUp" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onInput fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.ChangeEventArgs> "OnInput" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline label (x: System.String) = "Label" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline icon (x: System.String) = "Icon" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline iconTrailing (x: System.Boolean) = "IconTrailing" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline box (x: System.Boolean) = "Box" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline textArea (x: System.Boolean) = "TextArea" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline dense (x: System.Boolean) = "Dense" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline outlined (x: System.Boolean) = "Outlined" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabled (x: System.Boolean) = "Disabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline readOnly (x: System.Boolean) = "ReadOnly" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline fullWidth (x: System.Boolean) = "FullWidth" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline required (x: System.Boolean) = "Required" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline helperText (x: System.String) = "HelperText" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline helperTextPersistent (x: System.Boolean) = "HelperTextPersistent" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline helperTextValidation (x: System.Boolean) = "HelperTextValidation" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline placeHolder (x: System.String) = "PlaceHolder" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline hideClearButton (x: System.Boolean) = "HideClearButton" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline ``type`` (x: System.String) = "Type" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline inputClass (x: System.String) = "InputClass" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline inputStyle (x: System.String) = "InputStyle" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline format (x: System.String) = "Format" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline inputAttributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "InputAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline validationDisabled (x: System.Boolean) = "ValidationDisabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline value (x: 'TValue) = "Value" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valueChanged fn = (Bolero.Html.attr.callback<'TValue> "ValueChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valueExpression (x: System.Linq.Expressions.Expression<System.Func<'TValue>>) = "ValueExpression" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline attributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "Attributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: MatBlazor.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type baseMatDialog<'FunBlazorGeneric> =
    inherit baseMatDomComponent<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MatBlazor.BaseMatDialog>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<MatBlazor.BaseMatDialog>
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline isOpen (x: System.Boolean) = "IsOpen" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline isOpenChanged fn = (Bolero.Html.attr.callback<System.Boolean> "IsOpenChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline canBeClosed (x: System.Boolean) = "CanBeClosed" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline surfaceClass (x: System.String) = "SurfaceClass" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline surfaceStyle (x: System.String) = "SurfaceStyle" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline attributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "Attributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: MatBlazor.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type matDivider<'FunBlazorGeneric> =
    inherit baseMatDomComponent<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MatBlazor.MatDivider>
    
    static member inline inset (x: System.Boolean) = "Inset" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline padded (x: System.Boolean) = "Padded" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline attributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "Attributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: MatBlazor.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type baseMatDrawerContainer<'FunBlazorGeneric> =
    inherit baseMatDomComponent<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MatBlazor.BaseMatDrawerContainer>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<MatBlazor.BaseMatDrawerContainer>
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline drawerWidth (x: System.String) = "DrawerWidth" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline attributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "Attributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: MatBlazor.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type baseMatDrawerContent<'FunBlazorGeneric> =
    inherit baseMatDomComponent<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MatBlazor.BaseMatDrawerContent>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<MatBlazor.BaseMatDrawerContent>
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline attributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "Attributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: MatBlazor.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type baseMatDrawer<'FunBlazorGeneric> =
    inherit baseMatDomComponent<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MatBlazor.BaseMatDrawer>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<MatBlazor.BaseMatDrawer>
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline mode (x: MatBlazor.MatDrawerMode) = "Mode" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline contentTabIndex (x: System.Int32) = "ContentTabIndex" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline opened (x: System.Boolean) = "Opened" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline openedChanged fn = (Bolero.Html.attr.callback<System.Boolean> "OpenedChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline attributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "Attributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: MatBlazor.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type baseMatFAB<'FunBlazorGeneric> =
    inherit baseMatDomComponent<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MatBlazor.BaseMatFAB>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<MatBlazor.BaseMatFAB>
    static member inline icon (x: System.String) = "Icon" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline label (x: System.String) = "Label" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline mini (x: System.Boolean) = "Mini" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onClick fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnClick" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline attributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "Attributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: MatBlazor.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type baseMatFileUpload<'FunBlazorGeneric> =
    inherit baseMatDomComponent<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MatBlazor.BaseMatFileUpload>
    
    static member inline onChange fn = (Bolero.Html.attr.callback<System.Collections.Generic.IEnumerable<MatBlazor.IMatFileUploadEntry>> "OnChange" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline allowMultiple (x: System.Boolean) = "AllowMultiple" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline label (x: System.String) = "Label" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline maxMessageSize (x: System.Int32) = "MaxMessageSize" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline maxMessageLength (x: System.Int32) = "MaxMessageLength" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline attributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "Attributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: MatBlazor.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type baseMatHelperText<'FunBlazorGeneric> =
    inherit baseMatDomComponent<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MatBlazor.BaseMatHelperText>
    
    static member inline helperText (x: System.String) = "HelperText" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline helperTextPersistent (x: System.Boolean) = "HelperTextPersistent" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline helperTextValidation (x: System.Boolean) = "HelperTextValidation" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline characterCount (x: System.String) = "CharacterCount" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline attributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "Attributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: MatBlazor.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type baseMatHidden<'FunBlazorGeneric> =
    inherit baseMatComponent<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MatBlazor.BaseMatHidden>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<MatBlazor.BaseMatHidden>
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline elseContent (x: Microsoft.AspNetCore.Components.RenderFragment) = "ElseContent" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline initContent (x: Microsoft.AspNetCore.Components.RenderFragment) = "InitContent" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline breakpoint (x: MatBlazor.MatBreakpoint) = "Breakpoint" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline direction (x: MatBlazor.MatHiddenDirection) = "Direction" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline hiddenChanged fn = (Bolero.Html.attr.callback<System.Boolean> "HiddenChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: MatBlazor.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type baseMatIconButton<'FunBlazorGeneric> =
    inherit baseMatDomComponent<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MatBlazor.BaseMatIconButton>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<MatBlazor.BaseMatIconButton>
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline icon (x: System.String) = "Icon" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline target (x: System.String) = "Target" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline toggleIcon (x: System.String) = "ToggleIcon" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline toggled (x: System.Boolean) = "Toggled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline toggledChanged fn = (Bolero.Html.attr.callback<System.Boolean> "ToggledChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline link (x: System.String) = "Link" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline forceLoad (x: System.Boolean) = "ForceLoad" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabled (x: System.Boolean) = "Disabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline command (x: System.Windows.Input.ICommand) = "Command" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline commandParameter (x: System.Object) = "CommandParameter" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onClick fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnClick" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onClickStopPropagation (x: System.Boolean) = "OnClickStopPropagation" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onMouseDown fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnMouseDown" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline attributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "Attributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: MatBlazor.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type baseMatIcon<'FunBlazorGeneric> =
    inherit baseMatDomComponent<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MatBlazor.BaseMatIcon>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<MatBlazor.BaseMatIcon>
    static member inline icon (x: System.String) = "Icon" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline attributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "Attributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: MatBlazor.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type baseMatListGroup<'FunBlazorGeneric> =
    inherit baseMatDomComponent<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MatBlazor.BaseMatListGroup>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<MatBlazor.BaseMatListGroup>
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline attributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "Attributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: MatBlazor.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type baseMatList<'FunBlazorGeneric> =
    inherit baseMatDomComponent<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MatBlazor.BaseMatList>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<MatBlazor.BaseMatList>
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline singleSelection (x: System.Boolean) = "SingleSelection" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline twoLine (x: System.Boolean) = "TwoLine" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline attributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "Attributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: MatBlazor.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type baseMatListItem<'FunBlazorGeneric> =
    inherit baseMatDomComponent<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MatBlazor.BaseMatListItem>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<MatBlazor.BaseMatListItem>
    static member inline onMouseDown fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnMouseDown" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onClick fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnClick" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline href (x: System.String) = "Href" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabled (x: System.Boolean) = "Disabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline attributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "Attributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: MatBlazor.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type baseMatMenu<'FunBlazorGeneric> =
    inherit baseMatDomComponent<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MatBlazor.BaseMatMenu>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<MatBlazor.BaseMatMenu>
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline targetForwardRef (x: MatBlazor.ForwardRef) = "TargetForwardRef" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline attributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "Attributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: MatBlazor.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type baseMatNavItem<'FunBlazorGeneric> =
    inherit baseMatListItem<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MatBlazor.BaseMatNavItem>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<MatBlazor.BaseMatNavItem>
    static member inline command (x: System.Windows.Input.ICommand) = "Command" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline forceLoad (x: System.Boolean) = "ForceLoad" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline commandParameter (x: System.Object) = "CommandParameter" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline selected (x: System.Boolean) = "Selected" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline target (x: System.String) = "Target" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline title (x: System.String) = "Title" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline navLinkMatch (x: Microsoft.AspNetCore.Components.Routing.NavLinkMatch) = "NavLinkMatch" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline allowSelection (x: System.Boolean) = "AllowSelection" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline selectedChanged fn = (Bolero.Html.attr.callback<System.Boolean> "SelectedChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onMouseDown fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnMouseDown" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onClick fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnClick" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline href (x: System.String) = "Href" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabled (x: System.Boolean) = "Disabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline attributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "Attributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: MatBlazor.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type baseMatNavMenu<'FunBlazorGeneric> =
    inherit baseMatDomComponent<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MatBlazor.BaseMatNavMenu>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<MatBlazor.BaseMatNavMenu>
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline multi (x: System.Boolean) = "Multi" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline attributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "Attributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: MatBlazor.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type baseMatNavSubMenu<'FunBlazorGeneric> =
    inherit baseMatDomComponent<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MatBlazor.BaseMatNavSubMenu>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<MatBlazor.BaseMatNavSubMenu>
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline expanded (x: System.Boolean) = "Expanded" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline selected (x: System.Boolean) = "Selected" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline selectedChanged fn = (Bolero.Html.attr.callback<System.Boolean> "SelectedChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline expandedChanged fn = (Bolero.Html.attr.callback<System.Boolean> "ExpandedChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline attributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "Attributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: MatBlazor.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type baseMatNumericUpDownFieldInternal<'FunBlazorGeneric, 'TValue> =
    inherit matInputTextComponent<'FunBlazorGeneric, 'TValue>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MatBlazor.BaseMatNumericUpDownFieldInternal<'TValue>>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<MatBlazor.BaseMatNumericUpDownFieldInternal<'TValue>>
    static member inline allowInput (x: System.Boolean) = "AllowInput" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline maximum (x: 'TValue) = "Maximum" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline minimum (x: 'TValue) = "Minimum" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline decimalPlaces (x: System.Int32) = "DecimalPlaces" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline step (x: 'TValue) = "Step" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline fieldType (x: MatBlazor.MatNumericUpDownFieldType) = "FieldType" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline iconOnClick fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "IconOnClick" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onFocus fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.FocusEventArgs> "OnFocus" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onFocusOut fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.FocusEventArgs> "OnFocusOut" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onKeyPress fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs> "OnKeyPress" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onKeyDown fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs> "OnKeyDown" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onKeyUp fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs> "OnKeyUp" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onInput fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.ChangeEventArgs> "OnInput" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline label (x: System.String) = "Label" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline icon (x: System.String) = "Icon" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline iconTrailing (x: System.Boolean) = "IconTrailing" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline box (x: System.Boolean) = "Box" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline textArea (x: System.Boolean) = "TextArea" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline dense (x: System.Boolean) = "Dense" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline outlined (x: System.Boolean) = "Outlined" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabled (x: System.Boolean) = "Disabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline readOnly (x: System.Boolean) = "ReadOnly" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline fullWidth (x: System.Boolean) = "FullWidth" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline required (x: System.Boolean) = "Required" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline helperText (x: System.String) = "HelperText" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline helperTextPersistent (x: System.Boolean) = "HelperTextPersistent" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline helperTextValidation (x: System.Boolean) = "HelperTextValidation" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline placeHolder (x: System.String) = "PlaceHolder" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline hideClearButton (x: System.Boolean) = "HideClearButton" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline ``type`` (x: System.String) = "Type" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline inputClass (x: System.String) = "InputClass" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline inputStyle (x: System.String) = "InputStyle" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline format (x: System.String) = "Format" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline inputAttributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "InputAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline validationDisabled (x: System.Boolean) = "ValidationDisabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline value (x: 'TValue) = "Value" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valueChanged fn = (Bolero.Html.attr.callback<'TValue> "ValueChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valueExpression (x: System.Linq.Expressions.Expression<System.Func<'TValue>>) = "ValueExpression" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline attributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "Attributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: MatBlazor.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type matNumericUpDownField<'FunBlazorGeneric, 'TValue> =
    inherit matNumericUpDownFieldInternal<'FunBlazorGeneric, 'TValue>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MatBlazor.MatNumericUpDownField<'TValue>>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<MatBlazor.MatNumericUpDownField<'TValue>>
    static member inline allowInput (x: System.Boolean) = "AllowInput" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline maximum (x: 'TValue) = "Maximum" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline minimum (x: 'TValue) = "Minimum" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline decimalPlaces (x: System.Int32) = "DecimalPlaces" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline step (x: 'TValue) = "Step" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline fieldType (x: MatBlazor.MatNumericUpDownFieldType) = "FieldType" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline iconOnClick fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "IconOnClick" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onFocus fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.FocusEventArgs> "OnFocus" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onFocusOut fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.FocusEventArgs> "OnFocusOut" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onKeyPress fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs> "OnKeyPress" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onKeyDown fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs> "OnKeyDown" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onKeyUp fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs> "OnKeyUp" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onInput fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.ChangeEventArgs> "OnInput" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline label (x: System.String) = "Label" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline icon (x: System.String) = "Icon" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline iconTrailing (x: System.Boolean) = "IconTrailing" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline box (x: System.Boolean) = "Box" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline textArea (x: System.Boolean) = "TextArea" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline dense (x: System.Boolean) = "Dense" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline outlined (x: System.Boolean) = "Outlined" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabled (x: System.Boolean) = "Disabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline readOnly (x: System.Boolean) = "ReadOnly" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline fullWidth (x: System.Boolean) = "FullWidth" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline required (x: System.Boolean) = "Required" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline helperText (x: System.String) = "HelperText" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline helperTextPersistent (x: System.Boolean) = "HelperTextPersistent" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline helperTextValidation (x: System.Boolean) = "HelperTextValidation" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline placeHolder (x: System.String) = "PlaceHolder" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline hideClearButton (x: System.Boolean) = "HideClearButton" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline ``type`` (x: System.String) = "Type" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline inputClass (x: System.String) = "InputClass" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline inputStyle (x: System.String) = "InputStyle" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline format (x: System.String) = "Format" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline inputAttributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "InputAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline validationDisabled (x: System.Boolean) = "ValidationDisabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline value (x: 'TValue) = "Value" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valueChanged fn = (Bolero.Html.attr.callback<'TValue> "ValueChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valueExpression (x: System.Linq.Expressions.Expression<System.Func<'TValue>>) = "ValueExpression" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline attributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "Attributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: MatBlazor.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type baseMatPaginator<'FunBlazorGeneric> =
    inherit baseMatDomComponent<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MatBlazor.BaseMatPaginator>
    
    static member inline page fn = (Bolero.Html.attr.callback<MatBlazor.MatPaginatorPageEvent> "Page" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline label (x: System.String) = "Label" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline pageLabel (x: System.String) = "PageLabel" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline pageSize (x: System.Int32) = "PageSize" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline length (x: System.Int32) = "Length" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline pageIndexChanged fn = (Bolero.Html.attr.callback<System.Int32> "PageIndexChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline pageSizeOptions (x: System.Collections.Generic.IEnumerable<MatBlazor.MatPageSizeOption>) = "PageSizeOptions" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline attributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "Attributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: MatBlazor.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type baseMatPaper<'FunBlazorGeneric> =
    inherit baseMatDomComponent<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MatBlazor.BaseMatPaper>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<MatBlazor.BaseMatPaper>
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline elevation (x: System.Int32) = "Elevation" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline outlined (x: System.Boolean) = "Outlined" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline rounded (x: System.Boolean) = "Rounded" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline attributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "Attributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: MatBlazor.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type baseMatProgressBar<'FunBlazorGeneric> =
    inherit baseMatDomComponent<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MatBlazor.BaseMatProgressBar>
    
    static member inline indeterminate (x: System.Boolean) = "Indeterminate" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline reversed (x: System.Boolean) = "Reversed" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline closed (x: System.Boolean) = "Closed" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline progress (x: System.Double) = "Progress" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline buffer (x: System.Double) = "Buffer" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline attributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "Attributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: MatBlazor.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type baseMatProgressCircle<'FunBlazorGeneric> =
    inherit baseMatDomComponent<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MatBlazor.BaseMatProgressCircle>
    
    static member inline indeterminate (x: System.Boolean) = "Indeterminate" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline closed (x: System.Boolean) = "Closed" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline size (x: MatBlazor.MatProgressCircleSize) = "Size" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline progress (x: System.Double) = "Progress" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline fourColored (x: System.Boolean) = "FourColored" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline attributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "Attributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: MatBlazor.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type baseMatRadioButtonInternal<'FunBlazorGeneric, 'TValue> =
    inherit baseMatDomComponent<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MatBlazor.BaseMatRadioButtonInternal<'TValue>>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<MatBlazor.BaseMatRadioButtonInternal<'TValue>>
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabled (x: System.Boolean) = "Disabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline value (x: 'TValue) = "Value" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline label (x: System.String) = "Label" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline attributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "Attributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: MatBlazor.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type baseMatRadioGroupInternal<'FunBlazorGeneric, 'TValue> =
    inherit baseMatInputComponent<'FunBlazorGeneric, 'TValue>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MatBlazor.BaseMatRadioGroupInternal<'TValue>>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<MatBlazor.BaseMatRadioGroupInternal<'TValue>>
    static member inline itemTemplate (x: Microsoft.AspNetCore.Components.RenderFragment<'TValue>) = "ItemTemplate" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline items (x: System.Collections.Generic.IEnumerable<'TValue>) = "Items" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline validationDisabled (x: System.Boolean) = "ValidationDisabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline value (x: 'TValue) = "Value" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valueChanged fn = (Bolero.Html.attr.callback<'TValue> "ValueChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valueExpression (x: System.Linq.Expressions.Expression<System.Func<'TValue>>) = "ValueExpression" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline attributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "Attributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: MatBlazor.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type matRadioButton<'FunBlazorGeneric, 'TValue> =
    inherit matRadioButtonInternal<'FunBlazorGeneric, 'TValue>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MatBlazor.MatRadioButton<'TValue>>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<MatBlazor.MatRadioButton<'TValue>>
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabled (x: System.Boolean) = "Disabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline value (x: 'TValue) = "Value" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline label (x: System.String) = "Label" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline attributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "Attributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: MatBlazor.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type matRadioGroup<'FunBlazorGeneric, 'TValue> =
    inherit matRadioGroupInternal<'FunBlazorGeneric, 'TValue>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MatBlazor.MatRadioGroup<'TValue>>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<MatBlazor.MatRadioGroup<'TValue>>
    static member inline itemTemplate (x: Microsoft.AspNetCore.Components.RenderFragment<'TValue>) = "ItemTemplate" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline items (x: System.Collections.Generic.IEnumerable<'TValue>) = "Items" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline validationDisabled (x: System.Boolean) = "ValidationDisabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline value (x: 'TValue) = "Value" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valueChanged fn = (Bolero.Html.attr.callback<'TValue> "ValueChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valueExpression (x: System.Linq.Expressions.Expression<System.Func<'TValue>>) = "ValueExpression" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline attributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "Attributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: MatBlazor.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type baseMatRipple<'FunBlazorGeneric> =
    inherit baseMatDomComponent<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MatBlazor.BaseMatRipple>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<MatBlazor.BaseMatRipple>
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline color (x: MatBlazor.MatRippleColor) = "Color" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline attributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "Attributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: MatBlazor.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type baseCoreMatOption<'FunBlazorGeneric, 'TValue> =
    inherit baseMatDomComponent<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MatBlazor.BaseCoreMatOption<'TValue>>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<MatBlazor.BaseCoreMatOption<'TValue>>
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabled (x: System.Boolean) = "Disabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline value (x: 'TValue) = "Value" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline attributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "Attributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: MatBlazor.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type baseCoreMatSelect<'FunBlazorGeneric, 'TValue, 'TKey> =
    inherit baseMatInputComponent<'FunBlazorGeneric, 'TValue>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MatBlazor.BaseCoreMatSelect<'TValue, 'TKey>>
    
    static member inline enhanced (x: System.Boolean) = "Enhanced" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline outlined (x: System.Boolean) = "Outlined" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabled (x: System.Boolean) = "Disabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline label (x: System.String) = "Label" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline icon (x: System.String) = "Icon" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline helperText (x: System.String) = "HelperText" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline helperTextPersistent (x: System.Boolean) = "HelperTextPersistent" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline helperTextValidation (x: System.Boolean) = "HelperTextValidation" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline hideDropDownIcon (x: System.Boolean) = "HideDropDownIcon" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline fullWidth (x: System.Boolean) = "FullWidth" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline iconOnClick fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "IconOnClick" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline validationDisabled (x: System.Boolean) = "ValidationDisabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline value (x: 'TValue) = "Value" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valueChanged fn = (Bolero.Html.attr.callback<'TValue> "ValueChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valueExpression (x: System.Linq.Expressions.Expression<System.Func<'TValue>>) = "ValueExpression" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline attributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "Attributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: MatBlazor.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type baseCoreMatSelectValue<'FunBlazorGeneric, 'TValue, 'TItem> =
    inherit coreMatSelect<'FunBlazorGeneric, 'TValue, System.Int32>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MatBlazor.BaseCoreMatSelectValue<'TValue, 'TItem>>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<MatBlazor.BaseCoreMatSelectValue<'TValue, 'TItem>>
    static member inline items (x: System.Collections.Generic.IEnumerable<'TItem>) = "Items" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline itemTemplate (x: Microsoft.AspNetCore.Components.RenderFragment<'TItem>) = "ItemTemplate" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline enhanced (x: System.Boolean) = "Enhanced" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline outlined (x: System.Boolean) = "Outlined" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabled (x: System.Boolean) = "Disabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline label (x: System.String) = "Label" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline icon (x: System.String) = "Icon" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline helperText (x: System.String) = "HelperText" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline helperTextPersistent (x: System.Boolean) = "HelperTextPersistent" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline helperTextValidation (x: System.Boolean) = "HelperTextValidation" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline hideDropDownIcon (x: System.Boolean) = "HideDropDownIcon" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline fullWidth (x: System.Boolean) = "FullWidth" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline iconOnClick fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "IconOnClick" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline validationDisabled (x: System.Boolean) = "ValidationDisabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline value (x: 'TValue) = "Value" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valueChanged fn = (Bolero.Html.attr.callback<'TValue> "ValueChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valueExpression (x: System.Linq.Expressions.Expression<System.Func<'TValue>>) = "ValueExpression" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline attributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "Attributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: MatBlazor.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type baseMatOption<'FunBlazorGeneric, 'TValue> =
    inherit coreMatOption<'FunBlazorGeneric, 'TValue>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MatBlazor.BaseMatOption<'TValue>>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<MatBlazor.BaseMatOption<'TValue>>
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabled (x: System.Boolean) = "Disabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline value (x: 'TValue) = "Value" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline attributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "Attributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: MatBlazor.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type baseMatSelect<'FunBlazorGeneric, 'TValue> =
    inherit coreMatSelect<'FunBlazorGeneric, 'TValue, 'TValue>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MatBlazor.BaseMatSelect<'TValue>>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<MatBlazor.BaseMatSelect<'TValue>>
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline enhanced (x: System.Boolean) = "Enhanced" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline outlined (x: System.Boolean) = "Outlined" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabled (x: System.Boolean) = "Disabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline label (x: System.String) = "Label" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline icon (x: System.String) = "Icon" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline helperText (x: System.String) = "HelperText" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline helperTextPersistent (x: System.Boolean) = "HelperTextPersistent" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline helperTextValidation (x: System.Boolean) = "HelperTextValidation" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline hideDropDownIcon (x: System.Boolean) = "HideDropDownIcon" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline fullWidth (x: System.Boolean) = "FullWidth" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline iconOnClick fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "IconOnClick" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline validationDisabled (x: System.Boolean) = "ValidationDisabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline value (x: 'TValue) = "Value" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valueChanged fn = (Bolero.Html.attr.callback<'TValue> "ValueChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valueExpression (x: System.Linq.Expressions.Expression<System.Func<'TValue>>) = "ValueExpression" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline attributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "Attributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: MatBlazor.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type baseMatSelectItem<'FunBlazorGeneric, 'TValue> =
    inherit coreMatSelectValue<'FunBlazorGeneric, 'TValue, 'TValue>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MatBlazor.BaseMatSelectItem<'TValue>>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<MatBlazor.BaseMatSelectItem<'TValue>>
    static member inline items (x: System.Collections.Generic.IEnumerable<'TValue>) = "Items" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline itemTemplate (x: Microsoft.AspNetCore.Components.RenderFragment<'TValue>) = "ItemTemplate" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline enhanced (x: System.Boolean) = "Enhanced" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline outlined (x: System.Boolean) = "Outlined" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabled (x: System.Boolean) = "Disabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline label (x: System.String) = "Label" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline icon (x: System.String) = "Icon" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline helperText (x: System.String) = "HelperText" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline helperTextPersistent (x: System.Boolean) = "HelperTextPersistent" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline helperTextValidation (x: System.Boolean) = "HelperTextValidation" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline hideDropDownIcon (x: System.Boolean) = "HideDropDownIcon" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline fullWidth (x: System.Boolean) = "FullWidth" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline iconOnClick fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "IconOnClick" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline validationDisabled (x: System.Boolean) = "ValidationDisabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline value (x: 'TValue) = "Value" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valueChanged fn = (Bolero.Html.attr.callback<'TValue> "ValueChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valueExpression (x: System.Linq.Expressions.Expression<System.Func<'TValue>>) = "ValueExpression" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline attributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "Attributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: MatBlazor.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type baseMatSelectValue<'FunBlazorGeneric, 'TValue, 'TItem> =
    inherit coreMatSelectValue<'FunBlazorGeneric, 'TValue, 'TItem>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MatBlazor.BaseMatSelectValue<'TValue, 'TItem>>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<MatBlazor.BaseMatSelectValue<'TValue, 'TItem>>
    static member inline valueSelector (x: System.Func<'TItem, 'TValue>) = "ValueSelector" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline items (x: System.Collections.Generic.IEnumerable<'TItem>) = "Items" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline itemTemplate (x: Microsoft.AspNetCore.Components.RenderFragment<'TItem>) = "ItemTemplate" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline enhanced (x: System.Boolean) = "Enhanced" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline outlined (x: System.Boolean) = "Outlined" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabled (x: System.Boolean) = "Disabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline label (x: System.String) = "Label" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline icon (x: System.String) = "Icon" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline helperText (x: System.String) = "HelperText" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline helperTextPersistent (x: System.Boolean) = "HelperTextPersistent" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline helperTextValidation (x: System.Boolean) = "HelperTextValidation" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline hideDropDownIcon (x: System.Boolean) = "HideDropDownIcon" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline fullWidth (x: System.Boolean) = "FullWidth" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline iconOnClick fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "IconOnClick" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline validationDisabled (x: System.Boolean) = "ValidationDisabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline value (x: 'TValue) = "Value" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valueChanged fn = (Bolero.Html.attr.callback<'TValue> "ValueChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valueExpression (x: System.Linq.Expressions.Expression<System.Func<'TValue>>) = "ValueExpression" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline attributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "Attributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: MatBlazor.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type matOption<'FunBlazorGeneric, 'TValue> =
    inherit baseMatOption<'FunBlazorGeneric, 'TValue>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MatBlazor.MatOption<'TValue>>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<MatBlazor.MatOption<'TValue>>
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabled (x: System.Boolean) = "Disabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline value (x: 'TValue) = "Value" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline attributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "Attributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: MatBlazor.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type matOptionString<'FunBlazorGeneric> =
    inherit matOption<'FunBlazorGeneric, System.String>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MatBlazor.MatOptionString>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<MatBlazor.MatOptionString>
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabled (x: System.Boolean) = "Disabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline value (x: System.String) = "Value" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline attributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "Attributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: MatBlazor.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type baseMatSlider<'FunBlazorGeneric, 'TValue> =
    inherit baseMatInputComponent<'FunBlazorGeneric, 'TValue>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MatBlazor.BaseMatSlider<'TValue>>
    
    static member inline valueMin (x: 'TValue) = "ValueMin" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valueMax (x: 'TValue) = "ValueMax" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline discrete (x: System.Boolean) = "Discrete" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline label (x: System.String) = "Label" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline markers (x: System.Boolean) = "Markers" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline pin (x: System.Boolean) = "Pin" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline step (x: 'TValue) = "Step" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline enableStep (x: System.Boolean) = "EnableStep" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabled (x: System.Boolean) = "Disabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline immediate (x: System.Boolean) = "Immediate" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline validationDisabled (x: System.Boolean) = "ValidationDisabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline value (x: 'TValue) = "Value" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valueChanged fn = (Bolero.Html.attr.callback<'TValue> "ValueChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valueExpression (x: System.Linq.Expressions.Expression<System.Func<'TValue>>) = "ValueExpression" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline attributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "Attributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: MatBlazor.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type baseMatSlideToggle<'FunBlazorGeneric, 'TValue> =
    inherit baseMatInputElementComponent<'FunBlazorGeneric, 'TValue>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MatBlazor.BaseMatSlideToggle<'TValue>>
    
    static member inline label (x: System.String) = "Label" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabled (x: System.Boolean) = "Disabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline inputAttributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "InputAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline validationDisabled (x: System.Boolean) = "ValidationDisabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline value (x: 'TValue) = "Value" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valueChanged fn = (Bolero.Html.attr.callback<'TValue> "ValueChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valueExpression (x: System.Linq.Expressions.Expression<System.Func<'TValue>>) = "ValueExpression" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline attributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "Attributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: MatBlazor.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type baseMatSnackbar<'FunBlazorGeneric> =
    inherit baseMatDomComponent<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MatBlazor.BaseMatSnackbar>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<MatBlazor.BaseMatSnackbar>
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline stacked (x: System.Boolean) = "Stacked" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline leading (x: System.Boolean) = "Leading" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline isOpen (x: System.Boolean) = "IsOpen" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline timeout (x: System.Int32) = "Timeout" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline isOpenChanged fn = (Bolero.Html.attr.callback<System.Boolean> "IsOpenChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline attributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "Attributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: MatBlazor.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type baseMatSortHeader<'FunBlazorGeneric> =
    inherit baseMatDomComponent<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MatBlazor.BaseMatSortHeader>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<MatBlazor.BaseMatSortHeader>
    static member inline sortId (x: System.String) = "SortId" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline attributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "Attributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: MatBlazor.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type baseMatSortHeaderRow<'FunBlazorGeneric> =
    inherit baseMatDomComponent<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MatBlazor.BaseMatSortHeaderRow>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<MatBlazor.BaseMatSortHeaderRow>
    static member inline sortId (x: System.String) = "SortId" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline sortIdChanged fn = (Bolero.Html.attr.callback<System.String> "SortIdChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline direction (x: MatBlazor.MatSortDirection) = "Direction" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline directionChanged fn = (Bolero.Html.attr.callback<MatBlazor.MatSortDirection> "DirectionChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline sortChanged fn = (Bolero.Html.attr.callback<MatBlazor.MatSortChangedEvent> "SortChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline attributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "Attributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: MatBlazor.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type baseMatTabBar<'FunBlazorGeneric> =
    inherit baseMatDomComponent<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MatBlazor.BaseMatTabBar>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<MatBlazor.BaseMatTabBar>
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline active (x: MatBlazor.BaseMatTabLabel) = "Active" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline activeIndex (x: System.Int32) = "ActiveIndex" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline activeChanged fn = (Bolero.Html.attr.callback<MatBlazor.BaseMatTabLabel> "ActiveChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline activeIndexChanged fn = (Bolero.Html.attr.callback<System.Int32> "ActiveIndexChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline attributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "Attributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: MatBlazor.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type baseMatTabLabel<'FunBlazorGeneric> =
    inherit baseMatDomComponent<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MatBlazor.BaseMatTabLabel>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<MatBlazor.BaseMatTabLabel>
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline attributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "Attributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: MatBlazor.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type baseMatTable<'FunBlazorGeneric> =
    inherit baseMatDomComponent<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MatBlazor.BaseMatTable>
    
    static member inline pageParamName (x: System.String) = "PageParamName" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline pageSizeParamName (x: System.String) = "PageSizeParamName" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline descending (x: System.Boolean) = "Descending" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline descendingParamName (x: System.String) = "DescendingParamName" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline sortBy (x: System.String) = "SortBy" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline sortByParamName (x: System.String) = "SortByParamName" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline pageLabel (x: System.String) = "PageLabel" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline pageRecordCountLabel (x: System.String) = "PageRecordCountLabel" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline pagingDataPropertyName (x: System.String) = "PagingDataPropertyName" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline pagingRecordsCountPropertyName (x: System.String) = "PagingRecordsCountPropertyName" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline searchTermParamName (x: System.String) = "SearchTermParamName" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline selectionChanged (x: System.Action<System.Object>) = "SelectionChanged" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline headerRowClass (x: System.String) = "HeaderRowClass" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline rowClass (x: System.String) = "RowClass" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline allowSelection (x: System.Boolean) = "AllowSelection" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline requestApiOnlyOnce (x: System.Boolean) = "RequestApiOnlyOnce" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline debounceMilliseconds (x: System.Int32) = "DebounceMilliseconds" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline filterByColumnName (x: System.String) = "FilterByColumnName" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline searchTermFieldLabel (x: System.String) = "SearchTermFieldLabel" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline searchTermFieldPlaceHolder (x: System.String) = "SearchTermFieldPlaceHolder" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline loadInitialData (x: System.Boolean) = "LoadInitialData" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline apiUrl (x: System.String) = "ApiUrl" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline showPaging (x: System.Boolean) = "ShowPaging" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline showFooter (x: System.Boolean) = "ShowFooter" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline striped (x: System.Boolean) = "Striped" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline pageSize (x: System.Int32) = "PageSize" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onRowDbClick fn = (Bolero.Html.attr.callback<System.Object> "OnRowDbClick" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline attributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "Attributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: MatBlazor.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type baseTableRow<'FunBlazorGeneric> =
    inherit baseMatDomComponent<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MatBlazor.BaseTableRow>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<MatBlazor.BaseTableRow>
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline selected (x: System.Boolean) = "Selected" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline allowSelection (x: System.Boolean) = "AllowSelection" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline rowItem (x: System.Object) = "RowItem" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline selectedChanged fn = (Bolero.Html.attr.callback<System.Boolean> "SelectedChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline attributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "Attributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: MatBlazor.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type baseMatTab<'FunBlazorGeneric> =
    inherit baseMatDomComponent<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MatBlazor.BaseMatTab>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<MatBlazor.BaseMatTab>
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline labelContent (x: Microsoft.AspNetCore.Components.RenderFragment) = "LabelContent" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline label (x: System.String) = "Label" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline attributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "Attributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: MatBlazor.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type baseMatTabGroup<'FunBlazorGeneric> =
    inherit baseMatDomComponent<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MatBlazor.BaseMatTabGroup>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<MatBlazor.BaseMatTabGroup>
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline activeIndex (x: System.Int32) = "ActiveIndex" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline activeIndexChanged fn = (Bolero.Html.attr.callback<System.Int32> "ActiveIndexChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline attributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "Attributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: MatBlazor.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type baseMatInputTextComponent<'FunBlazorGeneric, 'TValue> =
    inherit baseMatInputTextElementComponent<'FunBlazorGeneric, 'TValue>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MatBlazor.BaseMatInputTextComponent<'TValue>>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<MatBlazor.BaseMatInputTextComponent<'TValue>>
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline iconOnClick fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "IconOnClick" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onFocus fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.FocusEventArgs> "OnFocus" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onFocusOut fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.FocusEventArgs> "OnFocusOut" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onKeyPress fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs> "OnKeyPress" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onKeyDown fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs> "OnKeyDown" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onKeyUp fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs> "OnKeyUp" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onInput fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.ChangeEventArgs> "OnInput" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline label (x: System.String) = "Label" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline icon (x: System.String) = "Icon" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline iconTrailing (x: System.Boolean) = "IconTrailing" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline box (x: System.Boolean) = "Box" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline textArea (x: System.Boolean) = "TextArea" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline dense (x: System.Boolean) = "Dense" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline outlined (x: System.Boolean) = "Outlined" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabled (x: System.Boolean) = "Disabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline readOnly (x: System.Boolean) = "ReadOnly" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline fullWidth (x: System.Boolean) = "FullWidth" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline required (x: System.Boolean) = "Required" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline helperText (x: System.String) = "HelperText" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline helperTextPersistent (x: System.Boolean) = "HelperTextPersistent" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline helperTextValidation (x: System.Boolean) = "HelperTextValidation" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline placeHolder (x: System.String) = "PlaceHolder" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline hideClearButton (x: System.Boolean) = "HideClearButton" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline ``type`` (x: System.String) = "Type" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline inputClass (x: System.String) = "InputClass" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline inputStyle (x: System.String) = "InputStyle" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline format (x: System.String) = "Format" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline inputAttributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "InputAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline validationDisabled (x: System.Boolean) = "ValidationDisabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline value (x: 'TValue) = "Value" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valueChanged fn = (Bolero.Html.attr.callback<'TValue> "ValueChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valueExpression (x: System.Linq.Expressions.Expression<System.Func<'TValue>>) = "ValueExpression" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline attributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "Attributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: MatBlazor.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type matStringField<'FunBlazorGeneric> =
    inherit matTextField<'FunBlazorGeneric, System.String>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MatBlazor.MatStringField>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<MatBlazor.MatStringField>
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline iconOnClick fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "IconOnClick" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onFocus fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.FocusEventArgs> "OnFocus" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onFocusOut fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.FocusEventArgs> "OnFocusOut" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onKeyPress fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs> "OnKeyPress" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onKeyDown fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs> "OnKeyDown" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onKeyUp fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs> "OnKeyUp" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onInput fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.ChangeEventArgs> "OnInput" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline label (x: System.String) = "Label" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline icon (x: System.String) = "Icon" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline iconTrailing (x: System.Boolean) = "IconTrailing" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline box (x: System.Boolean) = "Box" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline textArea (x: System.Boolean) = "TextArea" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline dense (x: System.Boolean) = "Dense" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline outlined (x: System.Boolean) = "Outlined" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabled (x: System.Boolean) = "Disabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline readOnly (x: System.Boolean) = "ReadOnly" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline fullWidth (x: System.Boolean) = "FullWidth" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline required (x: System.Boolean) = "Required" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline helperText (x: System.String) = "HelperText" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline helperTextPersistent (x: System.Boolean) = "HelperTextPersistent" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline helperTextValidation (x: System.Boolean) = "HelperTextValidation" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline placeHolder (x: System.String) = "PlaceHolder" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline hideClearButton (x: System.Boolean) = "HideClearButton" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline ``type`` (x: System.String) = "Type" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline inputClass (x: System.String) = "InputClass" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline inputStyle (x: System.String) = "InputStyle" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline format (x: System.String) = "Format" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline inputAttributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "InputAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline validationDisabled (x: System.Boolean) = "ValidationDisabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline value (x: System.String) = "Value" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valueChanged fn = (Bolero.Html.attr.callback<System.String> "ValueChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valueExpression (x: System.Linq.Expressions.Expression<System.Func<System.String>>) = "ValueExpression" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline attributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "Attributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: MatBlazor.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type matTextField<'FunBlazorGeneric, 'TValue> =
    inherit matInputTextComponent<'FunBlazorGeneric, 'TValue>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MatBlazor.MatTextField<'TValue>>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<MatBlazor.MatTextField<'TValue>>
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline iconOnClick fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "IconOnClick" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onFocus fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.FocusEventArgs> "OnFocus" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onFocusOut fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.FocusEventArgs> "OnFocusOut" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onKeyPress fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs> "OnKeyPress" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onKeyDown fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs> "OnKeyDown" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onKeyUp fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs> "OnKeyUp" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onInput fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.ChangeEventArgs> "OnInput" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline label (x: System.String) = "Label" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline icon (x: System.String) = "Icon" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline iconTrailing (x: System.Boolean) = "IconTrailing" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline box (x: System.Boolean) = "Box" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline textArea (x: System.Boolean) = "TextArea" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline dense (x: System.Boolean) = "Dense" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline outlined (x: System.Boolean) = "Outlined" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabled (x: System.Boolean) = "Disabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline readOnly (x: System.Boolean) = "ReadOnly" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline fullWidth (x: System.Boolean) = "FullWidth" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline required (x: System.Boolean) = "Required" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline helperText (x: System.String) = "HelperText" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline helperTextPersistent (x: System.Boolean) = "HelperTextPersistent" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline helperTextValidation (x: System.Boolean) = "HelperTextValidation" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline placeHolder (x: System.String) = "PlaceHolder" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline hideClearButton (x: System.Boolean) = "HideClearButton" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline ``type`` (x: System.String) = "Type" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline inputClass (x: System.String) = "InputClass" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline inputStyle (x: System.String) = "InputStyle" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline format (x: System.String) = "Format" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline inputAttributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "InputAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline validationDisabled (x: System.Boolean) = "ValidationDisabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline value (x: 'TValue) = "Value" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valueChanged fn = (Bolero.Html.attr.callback<'TValue> "ValueChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valueExpression (x: System.Linq.Expressions.Expression<System.Func<'TValue>>) = "ValueExpression" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline attributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "Attributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: MatBlazor.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type baseMatThemeProvider<'FunBlazorGeneric> =
    
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MatBlazor.BaseMatThemeProvider>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<MatBlazor.BaseMatThemeProvider>
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline theme (x: MatBlazor.MatTheme) = "Theme" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type baseMatToastContainer<'FunBlazorGeneric> =
    inherit baseMatDomComponent<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MatBlazor.BaseMatToastContainer>
    
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline attributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "Attributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: MatBlazor.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type baseMatToastItem<'FunBlazorGeneric> =
    inherit baseMatDomComponent<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MatBlazor.BaseMatToastItem>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<MatBlazor.BaseMatToastItem>
    static member inline toast (x: MatBlazor.MatToast) = "Toast" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline icon (x: System.String) = "Icon" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline ``type`` (x: MatBlazor.MatToastType) = "Type" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline attributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "Attributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: MatBlazor.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type baseMatTooltip<'FunBlazorGeneric> =
    inherit baseMatDomComponent<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MatBlazor.BaseMatTooltip>
    
    static member inline childContent (x: Microsoft.AspNetCore.Components.RenderFragment<MatBlazor.ForwardRef>) = "ChildContent" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline tooltipContent (x: Microsoft.AspNetCore.Components.RenderFragment) = "TooltipContent" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline tooltip (x: System.String) = "Tooltip" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline targetId (x: System.String) = "TargetId" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline wrap (x: System.Boolean) = "Wrap" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline position (x: MatBlazor.MatTooltipPosition) = "Position" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline targetForwardRef (x: MatBlazor.ForwardRef) = "TargetForwardRef" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline attributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "Attributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: MatBlazor.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type matTreeNode<'FunBlazorGeneric, 'TNode when 'TNode : not struct> =
    
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MatBlazor.MatTreeNode<'TNode>>
    
    static member inline node (x: 'TNode) = "Node" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline isSelected (x: System.Boolean) = "IsSelected" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type matTreeView<'FunBlazorGeneric, 'TNode when 'TNode : not struct> =
    
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MatBlazor.MatTreeView<'TNode>>
    
    static member inline rootNode (x: 'TNode) = "RootNode" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline rootNodes (x: System.Collections.Generic.IEnumerable<'TNode>) = "RootNodes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline selectedNode (x: 'TNode) = "SelectedNode" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline nodeTemplate (x: Microsoft.AspNetCore.Components.RenderFragment<'TNode>) = "NodeTemplate" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline getChildNodesCallback (x: MatBlazor.GetChildNodesDelegate<'TNode>) = "GetChildNodesCallback" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline loadChildNodesCallback (x: MatBlazor.LoadChildNodesDelegate<'TNode>) = "LoadChildNodesCallback" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline isNodeExpandedCallback (x: MatBlazor.IsNodeExpandedDelegate<'TNode>) = "IsNodeExpandedCallback" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline expandStateChanged fn = (Bolero.Html.attr.callback<MatBlazor.ExpandedStateChangedArgs<'TNode>> "ExpandStateChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline selectedNodeChanged fn = (Bolero.Html.attr.callback<'TNode> "SelectedNodeChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type baseMatTypography<'FunBlazorGeneric> =
    inherit baseMatContainerComponent<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MatBlazor.BaseMatTypography>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<MatBlazor.BaseMatTypography>
    static member inline anchor (x: System.Boolean) = "Anchor" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline anchorId (x: System.String) = "AnchorId" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline tag (x: System.String) = "Tag" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline attributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "Attributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: MatBlazor.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type matHeadline1<'FunBlazorGeneric> =
    inherit baseMatTypography<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MatBlazor.MatHeadline1>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<MatBlazor.MatHeadline1>
    static member inline anchor (x: System.Boolean) = "Anchor" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline anchorId (x: System.String) = "AnchorId" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline tag (x: System.String) = "Tag" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline attributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "Attributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: MatBlazor.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type matHeadline2<'FunBlazorGeneric> =
    inherit baseMatTypography<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MatBlazor.MatHeadline2>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<MatBlazor.MatHeadline2>
    static member inline anchor (x: System.Boolean) = "Anchor" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline anchorId (x: System.String) = "AnchorId" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline tag (x: System.String) = "Tag" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline attributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "Attributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: MatBlazor.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type matHeadline3<'FunBlazorGeneric> =
    inherit baseMatTypography<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MatBlazor.MatHeadline3>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<MatBlazor.MatHeadline3>
    static member inline anchor (x: System.Boolean) = "Anchor" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline anchorId (x: System.String) = "AnchorId" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline tag (x: System.String) = "Tag" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline attributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "Attributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: MatBlazor.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type matHeadline4<'FunBlazorGeneric> =
    inherit baseMatTypography<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MatBlazor.MatHeadline4>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<MatBlazor.MatHeadline4>
    static member inline anchor (x: System.Boolean) = "Anchor" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline anchorId (x: System.String) = "AnchorId" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline tag (x: System.String) = "Tag" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline attributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "Attributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: MatBlazor.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type matHeadline5<'FunBlazorGeneric> =
    inherit baseMatTypography<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MatBlazor.MatHeadline5>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<MatBlazor.MatHeadline5>
    static member inline anchor (x: System.Boolean) = "Anchor" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline anchorId (x: System.String) = "AnchorId" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline tag (x: System.String) = "Tag" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline attributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "Attributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: MatBlazor.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type matHeadline6<'FunBlazorGeneric> =
    inherit baseMatTypography<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MatBlazor.MatHeadline6>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<MatBlazor.MatHeadline6>
    static member inline anchor (x: System.Boolean) = "Anchor" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline anchorId (x: System.String) = "AnchorId" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline tag (x: System.String) = "Tag" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline attributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "Attributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: MatBlazor.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type matH1<'FunBlazorGeneric> =
    inherit matHeadline1<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MatBlazor.MatH1>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<MatBlazor.MatH1>
    static member inline anchor (x: System.Boolean) = "Anchor" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline anchorId (x: System.String) = "AnchorId" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline tag (x: System.String) = "Tag" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline attributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "Attributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: MatBlazor.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type matH2<'FunBlazorGeneric> =
    inherit matHeadline2<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MatBlazor.MatH2>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<MatBlazor.MatH2>
    static member inline anchor (x: System.Boolean) = "Anchor" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline anchorId (x: System.String) = "AnchorId" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline tag (x: System.String) = "Tag" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline attributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "Attributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: MatBlazor.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type matH3<'FunBlazorGeneric> =
    inherit matHeadline3<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MatBlazor.MatH3>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<MatBlazor.MatH3>
    static member inline anchor (x: System.Boolean) = "Anchor" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline anchorId (x: System.String) = "AnchorId" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline tag (x: System.String) = "Tag" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline attributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "Attributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: MatBlazor.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type matH4<'FunBlazorGeneric> =
    inherit matHeadline4<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MatBlazor.MatH4>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<MatBlazor.MatH4>
    static member inline anchor (x: System.Boolean) = "Anchor" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline anchorId (x: System.String) = "AnchorId" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline tag (x: System.String) = "Tag" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline attributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "Attributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: MatBlazor.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type matH5<'FunBlazorGeneric> =
    inherit matHeadline5<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MatBlazor.MatH5>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<MatBlazor.MatH5>
    static member inline anchor (x: System.Boolean) = "Anchor" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline anchorId (x: System.String) = "AnchorId" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline tag (x: System.String) = "Tag" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline attributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "Attributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: MatBlazor.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type matH6<'FunBlazorGeneric> =
    inherit matHeadline6<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MatBlazor.MatH6>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<MatBlazor.MatH6>
    static member inline anchor (x: System.Boolean) = "Anchor" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline anchorId (x: System.String) = "AnchorId" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline tag (x: System.String) = "Tag" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline attributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "Attributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: MatBlazor.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type matSubtitle1<'FunBlazorGeneric> =
    inherit baseMatTypography<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MatBlazor.MatSubtitle1>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<MatBlazor.MatSubtitle1>
    static member inline anchor (x: System.Boolean) = "Anchor" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline anchorId (x: System.String) = "AnchorId" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline tag (x: System.String) = "Tag" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline attributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "Attributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: MatBlazor.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type matSubtitle2<'FunBlazorGeneric> =
    inherit baseMatTypography<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MatBlazor.MatSubtitle2>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<MatBlazor.MatSubtitle2>
    static member inline anchor (x: System.Boolean) = "Anchor" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline anchorId (x: System.String) = "AnchorId" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline tag (x: System.String) = "Tag" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline attributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "Attributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: MatBlazor.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type matBody1<'FunBlazorGeneric> =
    inherit baseMatTypography<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MatBlazor.MatBody1>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<MatBlazor.MatBody1>
    static member inline anchor (x: System.Boolean) = "Anchor" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline anchorId (x: System.String) = "AnchorId" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline tag (x: System.String) = "Tag" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline attributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "Attributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: MatBlazor.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type matBody2<'FunBlazorGeneric> =
    inherit baseMatTypography<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MatBlazor.MatBody2>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<MatBlazor.MatBody2>
    static member inline anchor (x: System.Boolean) = "Anchor" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline anchorId (x: System.String) = "AnchorId" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline tag (x: System.String) = "Tag" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline attributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "Attributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: MatBlazor.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type matCaption<'FunBlazorGeneric> =
    inherit baseMatTypography<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MatBlazor.MatCaption>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<MatBlazor.MatCaption>
    static member inline anchor (x: System.Boolean) = "Anchor" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline anchorId (x: System.String) = "AnchorId" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline tag (x: System.String) = "Tag" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline attributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "Attributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: MatBlazor.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type matOverline<'FunBlazorGeneric> =
    inherit baseMatTypography<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MatBlazor.MatOverline>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<MatBlazor.MatOverline>
    static member inline anchor (x: System.Boolean) = "Anchor" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline anchorId (x: System.String) = "AnchorId" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline tag (x: System.String) = "Tag" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline attributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "Attributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: MatBlazor.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type baseMatVirtualScroll<'FunBlazorGeneric, 'TItem> =
    inherit baseMatDomComponent<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MatBlazor.BaseMatVirtualScroll<'TItem>>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<MatBlazor.BaseMatVirtualScroll<'TItem>>
    static member inline itemHeight (x: System.Int32) = "ItemHeight" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabled (x: System.Boolean) = "Disabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline itemTemplate (x: Microsoft.AspNetCore.Components.RenderFragment<'TItem>) = "ItemTemplate" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline items (x: System.Collections.Generic.IEnumerable<'TItem>) = "Items" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline attributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "Attributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: MatBlazor.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type matViewChildren<'FunBlazorGeneric, 'TSelect when 'TSelect :> Microsoft.AspNetCore.Components.IComponent> =
    
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MatBlazor.MatViewChildren<'TSelect>>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<MatBlazor.MatViewChildren<'TSelect>>
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type forwardRefContext<'FunBlazorGeneric, 'TRef> =
    
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MatBlazor.ForwardRefContext<'TRef>>
    
    static member inline childContent (x: Microsoft.AspNetCore.Components.RenderFragment<MatBlazor.ForwardRef<'TRef>>) = "ChildContent" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type matContentWrapper<'FunBlazorGeneric> =
    
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MatBlazor.MatContentWrapper>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<MatBlazor.MatContentWrapper>
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type matItemsControl<'FunBlazorGeneric, 'T> =
    
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MatBlazor.MatItemsControl<'T>>
    
    static member inline defaultItemTemplate (x: Microsoft.AspNetCore.Components.RenderFragment<'T>) = "DefaultItemTemplate" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline itemTemplate (x: Microsoft.AspNetCore.Components.RenderFragment<'T>) = "ItemTemplate" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline items (x: System.Collections.Generic.IEnumerable<'T>) = "Items" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type matAutocompleteList<'FunBlazorGeneric, 'TItem> =
    inherit baseMatAutocompleteList<'FunBlazorGeneric, 'TItem>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MatBlazor.MatAutocompleteList<'TItem>>
    
    static member inline numberOfElementsInPopup (x: System.Nullable<System.Int32>) = "NumberOfElementsInPopup" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline label (x: System.String) = "Label" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline icon (x: System.String) = "Icon" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline stringValue (x: System.String) = "StringValue" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline value (x: 'TItem) = "Value" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valueChanged fn = (Bolero.Html.attr.callback<'TItem> "ValueChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline itemTemplate (x: Microsoft.AspNetCore.Components.RenderFragment<'TItem>) = "ItemTemplate" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline customStringSelector (x: System.Func<'TItem, System.String>) = "CustomStringSelector" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline items (x: System.Collections.Generic.IEnumerable<'TItem>) = "Items" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline outlined (x: System.Boolean) = "Outlined" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onOpenedChanged fn = (Bolero.Html.attr.callback<System.Boolean> "OnOpenedChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onTextChanged fn = (Bolero.Html.attr.callback<System.String> "OnTextChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline showClearButton (x: System.Boolean) = "ShowClearButton" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline fullWidth (x: System.Boolean) = "FullWidth" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline attributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "Attributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: MatBlazor.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type matAutocomplete<'FunBlazorGeneric, 'TValue, 'TItem> =
    inherit baseMatAutocomplete<'FunBlazorGeneric, 'TValue, 'TItem>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MatBlazor.MatAutocomplete<'TValue, 'TItem>>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<MatBlazor.MatAutocomplete<'TValue, 'TItem>>
    static member inline items (x: System.Collections.Generic.IEnumerable<'TItem>) = "Items" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline itemValueSelector (x: System.Func<'TItem, 'TValue>) = "ItemValueSelector" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline numberOfElementsInPopup (x: System.Nullable<System.Int32>) = "NumberOfElementsInPopup" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline itemTemplate (x: Microsoft.AspNetCore.Components.RenderFragment<'TItem>) = "ItemTemplate" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline iconOnClick fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "IconOnClick" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onFocus fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.FocusEventArgs> "OnFocus" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onFocusOut fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.FocusEventArgs> "OnFocusOut" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onKeyPress fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs> "OnKeyPress" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onKeyDown fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs> "OnKeyDown" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onKeyUp fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs> "OnKeyUp" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onInput fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.ChangeEventArgs> "OnInput" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline label (x: System.String) = "Label" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline icon (x: System.String) = "Icon" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline iconTrailing (x: System.Boolean) = "IconTrailing" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline box (x: System.Boolean) = "Box" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline textArea (x: System.Boolean) = "TextArea" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline dense (x: System.Boolean) = "Dense" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline outlined (x: System.Boolean) = "Outlined" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabled (x: System.Boolean) = "Disabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline readOnly (x: System.Boolean) = "ReadOnly" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline fullWidth (x: System.Boolean) = "FullWidth" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline required (x: System.Boolean) = "Required" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline helperText (x: System.String) = "HelperText" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline helperTextPersistent (x: System.Boolean) = "HelperTextPersistent" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline helperTextValidation (x: System.Boolean) = "HelperTextValidation" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline placeHolder (x: System.String) = "PlaceHolder" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline hideClearButton (x: System.Boolean) = "HideClearButton" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline ``type`` (x: System.String) = "Type" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline inputClass (x: System.String) = "InputClass" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline inputStyle (x: System.String) = "InputStyle" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline format (x: System.String) = "Format" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline inputAttributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "InputAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline validationDisabled (x: System.Boolean) = "ValidationDisabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline value (x: 'TValue) = "Value" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valueChanged fn = (Bolero.Html.attr.callback<'TValue> "ValueChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valueExpression (x: System.Linq.Expressions.Expression<System.Func<'TValue>>) = "ValueExpression" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline attributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "Attributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: MatBlazor.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type matButtonLink<'FunBlazorGeneric> =
    inherit baseMatButtonLink<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MatBlazor.MatButtonLink>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<MatBlazor.MatButtonLink>
    static member inline onClick fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnClick" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onClickStopPropagation (x: System.Boolean) = "OnClickStopPropagation" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline command (x: System.Windows.Input.ICommand) = "Command" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline commandParameter (x: System.Object) = "CommandParameter" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline href (x: System.String) = "Href" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline forceLoad (x: System.Boolean) = "ForceLoad" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline target (x: System.String) = "Target" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline raised (x: System.Boolean) = "Raised" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline unelevated (x: System.Boolean) = "Unelevated" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline outlined (x: System.Boolean) = "Outlined" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline dense (x: System.Boolean) = "Dense" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabled (x: System.Boolean) = "Disabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline icon (x: System.String) = "Icon" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline trailingIcon (x: System.String) = "TrailingIcon" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline attributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "Attributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: MatBlazor.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type matCheckboxInternal<'FunBlazorGeneric, 'TValue> =
    inherit baseMatCheckboxInternal<'FunBlazorGeneric, 'TValue>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MatBlazor.MatCheckboxInternal<'TValue>>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<MatBlazor.MatCheckboxInternal<'TValue>>
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline label (x: System.String) = "Label" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline indeterminate (x: System.Boolean) = "Indeterminate" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabled (x: System.Boolean) = "Disabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline inputValue (x: System.String) = "InputValue" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline inputAttributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "InputAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline validationDisabled (x: System.Boolean) = "ValidationDisabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline value (x: 'TValue) = "Value" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valueChanged fn = (Bolero.Html.attr.callback<'TValue> "ValueChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valueExpression (x: System.Linq.Expressions.Expression<System.Func<'TValue>>) = "ValueExpression" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline attributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "Attributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: MatBlazor.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type matDataTableCellOld<'FunBlazorGeneric> =
    inherit baseMatDomComponent<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MatBlazor.MatDataTableCellOld>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<MatBlazor.MatDataTableCellOld>
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline numeric (x: System.Boolean) = "Numeric" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline attributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "Attributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: MatBlazor.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type matDataTableColumnOld<'FunBlazorGeneric, 'TItem> =
    inherit baseMatDataTableColumnOld<'FunBlazorGeneric, 'TItem>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MatBlazor.MatDataTableColumnOld<'TItem>>
    
    static member inline template (x: Microsoft.AspNetCore.Components.RenderFragment<'TItem>) = "Template" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline header (x: System.String) = "Header" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline headerTemplate (x: Microsoft.AspNetCore.Components.RenderFragment) = "HeaderTemplate" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline value (x: System.Func<'TItem, System.Object>) = "Value" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline sort (x: System.Boolean) = "Sort" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type matDataTableContentOld<'FunBlazorGeneric> =
    inherit baseMatDomComponent<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MatBlazor.MatDataTableContentOld>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<MatBlazor.MatDataTableContentOld>
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline attributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "Attributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: MatBlazor.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type matDataTableHeaderCellOld<'FunBlazorGeneric> =
    inherit baseMatDomComponent<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MatBlazor.MatDataTableHeaderCellOld>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<MatBlazor.MatDataTableHeaderCellOld>
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline numeric (x: System.Boolean) = "Numeric" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline attributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "Attributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: MatBlazor.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type matDataTableHeaderOld<'FunBlazorGeneric> =
    inherit baseMatDomComponent<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MatBlazor.MatDataTableHeaderOld>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<MatBlazor.MatDataTableHeaderOld>
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline attributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "Attributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: MatBlazor.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type matDataTableOld<'FunBlazorGeneric, 'TItem> =
    inherit baseMatDataTableOld<'FunBlazorGeneric, 'TItem>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MatBlazor.MatDataTableOld<'TItem>>
    
    static member inline items (x: System.Collections.Generic.IEnumerable<'TItem>) = "Items" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline columns (x: Microsoft.AspNetCore.Components.RenderFragment) = "Columns" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline stickyHeader (x: System.Boolean) = "StickyHeader" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline virtualScroll (x: System.Boolean) = "VirtualScroll" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline paginator (x: System.Boolean) = "Paginator" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline pageSizeOptions (x: System.Collections.Generic.IEnumerable<MatBlazor.MatPageSizeOption>) = "PageSizeOptions" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline pageSize (x: System.Int32) = "PageSize" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline pageIndex (x: System.Int32) = "PageIndex" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline pageLabel (x: System.String) = "PageLabel" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline attributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "Attributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: MatBlazor.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type matDataTableRowOld<'FunBlazorGeneric> =
    inherit baseMatDomComponent<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MatBlazor.MatDataTableRowOld>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<MatBlazor.MatDataTableRowOld>
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline attributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "Attributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: MatBlazor.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type matDatePickerInternal<'FunBlazorGeneric, 'TValue> =
    inherit baseMatDatePickerInternal<'FunBlazorGeneric, 'TValue>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MatBlazor.MatDatePickerInternal<'TValue>>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<MatBlazor.MatDatePickerInternal<'TValue>>
    static member inline enableTime (x: System.Boolean) = "EnableTime" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline enableSeconds (x: System.Boolean) = "EnableSeconds" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline maximum (x: System.Nullable<System.DateTime>) = "Maximum" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline minimum (x: System.Nullable<System.DateTime>) = "Minimum" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disableCalendar (x: System.Boolean) = "DisableCalendar" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline enable24hours (x: System.Boolean) = "Enable24hours" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline enableWeekNumbers (x: System.Boolean) = "EnableWeekNumbers" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline allowInput (x: System.Boolean) = "AllowInput" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disableMobile (x: System.Boolean) = "DisableMobile" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline position (x: MatBlazor.MatDatePickerPosition) = "Position" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline locale (x: System.String) = "Locale" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline iconOnClick fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "IconOnClick" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onFocus fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.FocusEventArgs> "OnFocus" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onFocusOut fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.FocusEventArgs> "OnFocusOut" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onKeyPress fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs> "OnKeyPress" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onKeyDown fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs> "OnKeyDown" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onKeyUp fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs> "OnKeyUp" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onInput fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.ChangeEventArgs> "OnInput" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline label (x: System.String) = "Label" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline icon (x: System.String) = "Icon" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline iconTrailing (x: System.Boolean) = "IconTrailing" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline box (x: System.Boolean) = "Box" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline textArea (x: System.Boolean) = "TextArea" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline dense (x: System.Boolean) = "Dense" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline outlined (x: System.Boolean) = "Outlined" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabled (x: System.Boolean) = "Disabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline readOnly (x: System.Boolean) = "ReadOnly" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline fullWidth (x: System.Boolean) = "FullWidth" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline required (x: System.Boolean) = "Required" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline helperText (x: System.String) = "HelperText" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline helperTextPersistent (x: System.Boolean) = "HelperTextPersistent" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline helperTextValidation (x: System.Boolean) = "HelperTextValidation" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline placeHolder (x: System.String) = "PlaceHolder" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline hideClearButton (x: System.Boolean) = "HideClearButton" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline ``type`` (x: System.String) = "Type" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline inputClass (x: System.String) = "InputClass" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline inputStyle (x: System.String) = "InputStyle" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline format (x: System.String) = "Format" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline inputAttributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "InputAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline validationDisabled (x: System.Boolean) = "ValidationDisabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline value (x: 'TValue) = "Value" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valueChanged fn = (Bolero.Html.attr.callback<'TValue> "ValueChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valueExpression (x: System.Linq.Expressions.Expression<System.Func<'TValue>>) = "ValueExpression" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline attributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "Attributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: MatBlazor.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type matDialogAlert<'FunBlazorGeneric> =
    
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MatBlazor.MatDialogAlert>
    
    static member inline message (x: System.String) = "Message" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type matDialogAsk<'FunBlazorGeneric> =
    
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MatBlazor.MatDialogAsk>
    
    static member inline message (x: System.String) = "Message" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline answers (x: System.Collections.Generic.IEnumerable<System.Object>) = "Answers" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type matDialogConfirm<'FunBlazorGeneric> =
    
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MatBlazor.MatDialogConfirm>
    
    static member inline message (x: System.String) = "Message" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type matDialogPrompt<'FunBlazorGeneric> =
    
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MatBlazor.MatDialogPrompt>
    
    static member inline message (x: System.String) = "Message" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline value (x: System.String) = "Value" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type matDialogServiceItem<'FunBlazorGeneric> =
    
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MatBlazor.MatDialogServiceItem>
    
    static member inline dialogReference (x: MatBlazor.MatDialogReference) = "DialogReference" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type matDialog<'FunBlazorGeneric> =
    inherit baseMatDialog<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MatBlazor.MatDialog>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<MatBlazor.MatDialog>
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline isOpen (x: System.Boolean) = "IsOpen" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline isOpenChanged fn = (Bolero.Html.attr.callback<System.Boolean> "IsOpenChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline canBeClosed (x: System.Boolean) = "CanBeClosed" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline surfaceClass (x: System.String) = "SurfaceClass" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline surfaceStyle (x: System.String) = "SurfaceStyle" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline attributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "Attributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: MatBlazor.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type matDialogActions<'FunBlazorGeneric> =
    inherit baseMatDomComponent<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MatBlazor.MatDialogActions>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<MatBlazor.MatDialogActions>
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline attributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "Attributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: MatBlazor.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type matDialogContent<'FunBlazorGeneric> =
    inherit baseMatDomComponent<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MatBlazor.MatDialogContent>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<MatBlazor.MatDialogContent>
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline attributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "Attributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: MatBlazor.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type matDialogTitle<'FunBlazorGeneric> =
    inherit baseMatDomComponent<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MatBlazor.MatDialogTitle>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<MatBlazor.MatDialogTitle>
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline attributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "Attributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: MatBlazor.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type matDrawerContainer<'FunBlazorGeneric> =
    inherit baseMatDrawerContainer<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MatBlazor.MatDrawerContainer>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<MatBlazor.MatDrawerContainer>
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline drawerWidth (x: System.String) = "DrawerWidth" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline attributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "Attributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: MatBlazor.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type matDrawerContent<'FunBlazorGeneric> =
    inherit baseMatDrawerContent<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MatBlazor.MatDrawerContent>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<MatBlazor.MatDrawerContent>
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline attributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "Attributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: MatBlazor.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type matDrawer<'FunBlazorGeneric> =
    inherit baseMatDrawer<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MatBlazor.MatDrawer>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<MatBlazor.MatDrawer>
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline mode (x: MatBlazor.MatDrawerMode) = "Mode" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline contentTabIndex (x: System.Int32) = "ContentTabIndex" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline opened (x: System.Boolean) = "Opened" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline openedChanged fn = (Bolero.Html.attr.callback<System.Boolean> "OpenedChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline attributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "Attributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: MatBlazor.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type matFAB<'FunBlazorGeneric> =
    inherit baseMatFAB<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MatBlazor.MatFAB>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<MatBlazor.MatFAB>
    static member inline icon (x: System.String) = "Icon" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline label (x: System.String) = "Label" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline mini (x: System.Boolean) = "Mini" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onClick fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnClick" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline attributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "Attributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: MatBlazor.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type matFileUpload<'FunBlazorGeneric> =
    inherit baseMatFileUpload<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MatBlazor.MatFileUpload>
    
    static member inline onChange fn = (Bolero.Html.attr.callback<System.Collections.Generic.IEnumerable<MatBlazor.IMatFileUploadEntry>> "OnChange" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline allowMultiple (x: System.Boolean) = "AllowMultiple" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline label (x: System.String) = "Label" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline maxMessageSize (x: System.Int32) = "MaxMessageSize" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline maxMessageLength (x: System.Int32) = "MaxMessageLength" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline attributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "Attributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: MatBlazor.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type matHelperText<'FunBlazorGeneric> =
    inherit baseMatHelperText<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MatBlazor.MatHelperText>
    
    static member inline helperText (x: System.String) = "HelperText" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline helperTextPersistent (x: System.Boolean) = "HelperTextPersistent" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline helperTextValidation (x: System.Boolean) = "HelperTextValidation" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline characterCount (x: System.String) = "CharacterCount" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline attributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "Attributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: MatBlazor.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type matHidden<'FunBlazorGeneric> =
    inherit baseMatHidden<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MatBlazor.MatHidden>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<MatBlazor.MatHidden>
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline elseContent (x: Microsoft.AspNetCore.Components.RenderFragment) = "ElseContent" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline initContent (x: Microsoft.AspNetCore.Components.RenderFragment) = "InitContent" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline breakpoint (x: MatBlazor.MatBreakpoint) = "Breakpoint" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline direction (x: MatBlazor.MatHiddenDirection) = "Direction" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline hiddenChanged fn = (Bolero.Html.attr.callback<System.Boolean> "HiddenChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: MatBlazor.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type matIconButton<'FunBlazorGeneric> =
    inherit baseMatIconButton<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MatBlazor.MatIconButton>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<MatBlazor.MatIconButton>
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline icon (x: System.String) = "Icon" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline target (x: System.String) = "Target" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline toggleIcon (x: System.String) = "ToggleIcon" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline toggled (x: System.Boolean) = "Toggled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline toggledChanged fn = (Bolero.Html.attr.callback<System.Boolean> "ToggledChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline link (x: System.String) = "Link" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline forceLoad (x: System.Boolean) = "ForceLoad" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabled (x: System.Boolean) = "Disabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline command (x: System.Windows.Input.ICommand) = "Command" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline commandParameter (x: System.Object) = "CommandParameter" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onClick fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnClick" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onClickStopPropagation (x: System.Boolean) = "OnClickStopPropagation" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onMouseDown fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnMouseDown" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline attributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "Attributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: MatBlazor.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type matIcon<'FunBlazorGeneric> =
    inherit baseMatIcon<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MatBlazor.MatIcon>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<MatBlazor.MatIcon>
    static member inline icon (x: System.String) = "Icon" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline attributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "Attributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: MatBlazor.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type matListGroup<'FunBlazorGeneric> =
    inherit baseMatListGroup<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MatBlazor.MatListGroup>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<MatBlazor.MatListGroup>
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline attributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "Attributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: MatBlazor.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type matListGroupSubHeader<'FunBlazorGeneric> =
    inherit baseMatDomComponent<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MatBlazor.MatListGroupSubHeader>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<MatBlazor.MatListGroupSubHeader>
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline attributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "Attributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: MatBlazor.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type matList<'FunBlazorGeneric> =
    inherit baseMatList<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MatBlazor.MatList>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<MatBlazor.MatList>
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline singleSelection (x: System.Boolean) = "SingleSelection" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline twoLine (x: System.Boolean) = "TwoLine" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline attributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "Attributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: MatBlazor.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type matListDivider<'FunBlazorGeneric> =
    inherit baseMatDomComponent<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MatBlazor.MatListDivider>
    
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline attributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "Attributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: MatBlazor.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type matListItem<'FunBlazorGeneric> =
    inherit baseMatListItem<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MatBlazor.MatListItem>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<MatBlazor.MatListItem>
    static member inline onMouseDown fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnMouseDown" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onClick fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnClick" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline href (x: System.String) = "Href" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabled (x: System.Boolean) = "Disabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline attributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "Attributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: MatBlazor.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type matListItemPrimaryText<'FunBlazorGeneric> =
    inherit baseMatDomComponent<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MatBlazor.MatListItemPrimaryText>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<MatBlazor.MatListItemPrimaryText>
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline attributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "Attributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: MatBlazor.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type matListItemSecondaryText<'FunBlazorGeneric> =
    inherit baseMatDomComponent<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MatBlazor.MatListItemSecondaryText>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<MatBlazor.MatListItemSecondaryText>
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline attributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "Attributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: MatBlazor.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type matListItemText<'FunBlazorGeneric> =
    inherit baseMatDomComponent<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MatBlazor.MatListItemText>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<MatBlazor.MatListItemText>
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline attributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "Attributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: MatBlazor.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type matMenu<'FunBlazorGeneric> =
    inherit baseMatMenu<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MatBlazor.MatMenu>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<MatBlazor.MatMenu>
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline targetForwardRef (x: MatBlazor.ForwardRef) = "TargetForwardRef" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline attributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "Attributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: MatBlazor.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type matNavItem<'FunBlazorGeneric> =
    inherit baseMatNavItem<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MatBlazor.MatNavItem>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<MatBlazor.MatNavItem>
    static member inline command (x: System.Windows.Input.ICommand) = "Command" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline forceLoad (x: System.Boolean) = "ForceLoad" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline commandParameter (x: System.Object) = "CommandParameter" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline selected (x: System.Boolean) = "Selected" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline target (x: System.String) = "Target" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline title (x: System.String) = "Title" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline navLinkMatch (x: Microsoft.AspNetCore.Components.Routing.NavLinkMatch) = "NavLinkMatch" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline allowSelection (x: System.Boolean) = "AllowSelection" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline selectedChanged fn = (Bolero.Html.attr.callback<System.Boolean> "SelectedChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onMouseDown fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnMouseDown" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onClick fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnClick" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline href (x: System.String) = "Href" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabled (x: System.Boolean) = "Disabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline attributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "Attributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: MatBlazor.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type matNavMenu<'FunBlazorGeneric> =
    inherit baseMatNavMenu<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MatBlazor.MatNavMenu>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<MatBlazor.MatNavMenu>
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline multi (x: System.Boolean) = "Multi" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline attributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "Attributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: MatBlazor.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type matNavSubMenu<'FunBlazorGeneric> =
    inherit baseMatNavSubMenu<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MatBlazor.MatNavSubMenu>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<MatBlazor.MatNavSubMenu>
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline expanded (x: System.Boolean) = "Expanded" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline selected (x: System.Boolean) = "Selected" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline selectedChanged fn = (Bolero.Html.attr.callback<System.Boolean> "SelectedChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline expandedChanged fn = (Bolero.Html.attr.callback<System.Boolean> "ExpandedChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline attributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "Attributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: MatBlazor.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type matNavSubMenuHeader<'FunBlazorGeneric> =
    inherit baseMatDomComponent<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MatBlazor.MatNavSubMenuHeader>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<MatBlazor.MatNavSubMenuHeader>
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline title (x: System.String) = "Title" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline attributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "Attributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: MatBlazor.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type matNavSubMenuList<'FunBlazorGeneric> =
    inherit baseMatDomComponent<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MatBlazor.MatNavSubMenuList>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<MatBlazor.MatNavSubMenuList>
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline attributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "Attributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: MatBlazor.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type matNumericUpDownFieldInternal<'FunBlazorGeneric, 'TValue> =
    inherit baseMatNumericUpDownFieldInternal<'FunBlazorGeneric, 'TValue>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MatBlazor.MatNumericUpDownFieldInternal<'TValue>>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<MatBlazor.MatNumericUpDownFieldInternal<'TValue>>
    static member inline allowInput (x: System.Boolean) = "AllowInput" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline maximum (x: 'TValue) = "Maximum" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline minimum (x: 'TValue) = "Minimum" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline decimalPlaces (x: System.Int32) = "DecimalPlaces" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline step (x: 'TValue) = "Step" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline fieldType (x: MatBlazor.MatNumericUpDownFieldType) = "FieldType" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline iconOnClick fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "IconOnClick" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onFocus fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.FocusEventArgs> "OnFocus" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onFocusOut fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.FocusEventArgs> "OnFocusOut" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onKeyPress fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs> "OnKeyPress" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onKeyDown fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs> "OnKeyDown" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onKeyUp fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs> "OnKeyUp" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onInput fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.ChangeEventArgs> "OnInput" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline label (x: System.String) = "Label" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline icon (x: System.String) = "Icon" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline iconTrailing (x: System.Boolean) = "IconTrailing" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline box (x: System.Boolean) = "Box" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline textArea (x: System.Boolean) = "TextArea" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline dense (x: System.Boolean) = "Dense" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline outlined (x: System.Boolean) = "Outlined" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabled (x: System.Boolean) = "Disabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline readOnly (x: System.Boolean) = "ReadOnly" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline fullWidth (x: System.Boolean) = "FullWidth" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline required (x: System.Boolean) = "Required" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline helperText (x: System.String) = "HelperText" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline helperTextPersistent (x: System.Boolean) = "HelperTextPersistent" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline helperTextValidation (x: System.Boolean) = "HelperTextValidation" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline placeHolder (x: System.String) = "PlaceHolder" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline hideClearButton (x: System.Boolean) = "HideClearButton" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline ``type`` (x: System.String) = "Type" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline inputClass (x: System.String) = "InputClass" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline inputStyle (x: System.String) = "InputStyle" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline format (x: System.String) = "Format" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline inputAttributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "InputAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline validationDisabled (x: System.Boolean) = "ValidationDisabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline value (x: 'TValue) = "Value" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valueChanged fn = (Bolero.Html.attr.callback<'TValue> "ValueChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valueExpression (x: System.Linq.Expressions.Expression<System.Func<'TValue>>) = "ValueExpression" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline attributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "Attributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: MatBlazor.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type matPaginator<'FunBlazorGeneric> =
    inherit baseMatPaginator<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MatBlazor.MatPaginator>
    
    static member inline page fn = (Bolero.Html.attr.callback<MatBlazor.MatPaginatorPageEvent> "Page" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline label (x: System.String) = "Label" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline pageLabel (x: System.String) = "PageLabel" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline pageSize (x: System.Int32) = "PageSize" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline length (x: System.Int32) = "Length" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline pageIndexChanged fn = (Bolero.Html.attr.callback<System.Int32> "PageIndexChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline pageSizeOptions (x: System.Collections.Generic.IEnumerable<MatBlazor.MatPageSizeOption>) = "PageSizeOptions" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline attributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "Attributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: MatBlazor.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type matPaper<'FunBlazorGeneric> =
    inherit baseMatPaper<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MatBlazor.MatPaper>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<MatBlazor.MatPaper>
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline elevation (x: System.Int32) = "Elevation" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline outlined (x: System.Boolean) = "Outlined" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline rounded (x: System.Boolean) = "Rounded" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline attributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "Attributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: MatBlazor.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type matProgressBar<'FunBlazorGeneric> =
    inherit baseMatProgressBar<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MatBlazor.MatProgressBar>
    
    static member inline indeterminate (x: System.Boolean) = "Indeterminate" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline reversed (x: System.Boolean) = "Reversed" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline closed (x: System.Boolean) = "Closed" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline progress (x: System.Double) = "Progress" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline buffer (x: System.Double) = "Buffer" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline attributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "Attributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: MatBlazor.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type matProgressCircle<'FunBlazorGeneric> =
    inherit baseMatProgressCircle<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MatBlazor.MatProgressCircle>
    
    static member inline indeterminate (x: System.Boolean) = "Indeterminate" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline closed (x: System.Boolean) = "Closed" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline size (x: MatBlazor.MatProgressCircleSize) = "Size" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline progress (x: System.Double) = "Progress" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline fourColored (x: System.Boolean) = "FourColored" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline attributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "Attributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: MatBlazor.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type matRadioButtonInternal<'FunBlazorGeneric, 'TValue> =
    inherit baseMatRadioButtonInternal<'FunBlazorGeneric, 'TValue>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MatBlazor.MatRadioButtonInternal<'TValue>>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<MatBlazor.MatRadioButtonInternal<'TValue>>
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabled (x: System.Boolean) = "Disabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline value (x: 'TValue) = "Value" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline label (x: System.String) = "Label" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline attributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "Attributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: MatBlazor.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type matRadioGroupInternal<'FunBlazorGeneric, 'TValue> =
    inherit baseMatRadioGroupInternal<'FunBlazorGeneric, 'TValue>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MatBlazor.MatRadioGroupInternal<'TValue>>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<MatBlazor.MatRadioGroupInternal<'TValue>>
    static member inline itemTemplate (x: Microsoft.AspNetCore.Components.RenderFragment<'TValue>) = "ItemTemplate" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline items (x: System.Collections.Generic.IEnumerable<'TValue>) = "Items" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline validationDisabled (x: System.Boolean) = "ValidationDisabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline value (x: 'TValue) = "Value" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valueChanged fn = (Bolero.Html.attr.callback<'TValue> "ValueChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valueExpression (x: System.Linq.Expressions.Expression<System.Func<'TValue>>) = "ValueExpression" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline attributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "Attributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: MatBlazor.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type matRipple<'FunBlazorGeneric> =
    inherit baseMatRipple<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MatBlazor.MatRipple>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<MatBlazor.MatRipple>
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline color (x: MatBlazor.MatRippleColor) = "Color" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline attributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "Attributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: MatBlazor.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type coreMatOption<'FunBlazorGeneric, 'TValue> =
    inherit baseCoreMatOption<'FunBlazorGeneric, 'TValue>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MatBlazor.CoreMatOption<'TValue>>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<MatBlazor.CoreMatOption<'TValue>>
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabled (x: System.Boolean) = "Disabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline value (x: 'TValue) = "Value" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline attributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "Attributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: MatBlazor.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type coreMatSelect<'FunBlazorGeneric, 'TValue, 'TKey> =
    inherit baseCoreMatSelect<'FunBlazorGeneric, 'TValue, 'TKey>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MatBlazor.CoreMatSelect<'TValue, 'TKey>>
    
    static member inline enhanced (x: System.Boolean) = "Enhanced" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline outlined (x: System.Boolean) = "Outlined" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabled (x: System.Boolean) = "Disabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline label (x: System.String) = "Label" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline icon (x: System.String) = "Icon" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline helperText (x: System.String) = "HelperText" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline helperTextPersistent (x: System.Boolean) = "HelperTextPersistent" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline helperTextValidation (x: System.Boolean) = "HelperTextValidation" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline hideDropDownIcon (x: System.Boolean) = "HideDropDownIcon" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline fullWidth (x: System.Boolean) = "FullWidth" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline iconOnClick fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "IconOnClick" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline validationDisabled (x: System.Boolean) = "ValidationDisabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline value (x: 'TValue) = "Value" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valueChanged fn = (Bolero.Html.attr.callback<'TValue> "ValueChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valueExpression (x: System.Linq.Expressions.Expression<System.Func<'TValue>>) = "ValueExpression" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline attributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "Attributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: MatBlazor.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type coreMatSelectValue<'FunBlazorGeneric, 'TValue, 'TItem> =
    inherit baseCoreMatSelectValue<'FunBlazorGeneric, 'TValue, 'TItem>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MatBlazor.CoreMatSelectValue<'TValue, 'TItem>>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<MatBlazor.CoreMatSelectValue<'TValue, 'TItem>>
    static member inline items (x: System.Collections.Generic.IEnumerable<'TItem>) = "Items" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline itemTemplate (x: Microsoft.AspNetCore.Components.RenderFragment<'TItem>) = "ItemTemplate" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline enhanced (x: System.Boolean) = "Enhanced" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline outlined (x: System.Boolean) = "Outlined" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabled (x: System.Boolean) = "Disabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline label (x: System.String) = "Label" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline icon (x: System.String) = "Icon" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline helperText (x: System.String) = "HelperText" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline helperTextPersistent (x: System.Boolean) = "HelperTextPersistent" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline helperTextValidation (x: System.Boolean) = "HelperTextValidation" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline hideDropDownIcon (x: System.Boolean) = "HideDropDownIcon" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline fullWidth (x: System.Boolean) = "FullWidth" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline iconOnClick fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "IconOnClick" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline validationDisabled (x: System.Boolean) = "ValidationDisabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline value (x: 'TValue) = "Value" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valueChanged fn = (Bolero.Html.attr.callback<'TValue> "ValueChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valueExpression (x: System.Linq.Expressions.Expression<System.Func<'TValue>>) = "ValueExpression" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline attributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "Attributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: MatBlazor.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type matSelect<'FunBlazorGeneric, 'TValue> =
    inherit baseMatSelect<'FunBlazorGeneric, 'TValue>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MatBlazor.MatSelect<'TValue>>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<MatBlazor.MatSelect<'TValue>>
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline enhanced (x: System.Boolean) = "Enhanced" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline outlined (x: System.Boolean) = "Outlined" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabled (x: System.Boolean) = "Disabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline label (x: System.String) = "Label" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline icon (x: System.String) = "Icon" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline helperText (x: System.String) = "HelperText" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline helperTextPersistent (x: System.Boolean) = "HelperTextPersistent" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline helperTextValidation (x: System.Boolean) = "HelperTextValidation" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline hideDropDownIcon (x: System.Boolean) = "HideDropDownIcon" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline fullWidth (x: System.Boolean) = "FullWidth" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline iconOnClick fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "IconOnClick" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline validationDisabled (x: System.Boolean) = "ValidationDisabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline value (x: 'TValue) = "Value" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valueChanged fn = (Bolero.Html.attr.callback<'TValue> "ValueChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valueExpression (x: System.Linq.Expressions.Expression<System.Func<'TValue>>) = "ValueExpression" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline attributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "Attributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: MatBlazor.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type matSelectItem<'FunBlazorGeneric, 'TValue> =
    inherit baseMatSelectItem<'FunBlazorGeneric, 'TValue>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MatBlazor.MatSelectItem<'TValue>>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<MatBlazor.MatSelectItem<'TValue>>
    static member inline items (x: System.Collections.Generic.IEnumerable<'TValue>) = "Items" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline itemTemplate (x: Microsoft.AspNetCore.Components.RenderFragment<'TValue>) = "ItemTemplate" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline enhanced (x: System.Boolean) = "Enhanced" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline outlined (x: System.Boolean) = "Outlined" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabled (x: System.Boolean) = "Disabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline label (x: System.String) = "Label" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline icon (x: System.String) = "Icon" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline helperText (x: System.String) = "HelperText" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline helperTextPersistent (x: System.Boolean) = "HelperTextPersistent" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline helperTextValidation (x: System.Boolean) = "HelperTextValidation" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline hideDropDownIcon (x: System.Boolean) = "HideDropDownIcon" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline fullWidth (x: System.Boolean) = "FullWidth" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline iconOnClick fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "IconOnClick" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline validationDisabled (x: System.Boolean) = "ValidationDisabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline value (x: 'TValue) = "Value" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valueChanged fn = (Bolero.Html.attr.callback<'TValue> "ValueChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valueExpression (x: System.Linq.Expressions.Expression<System.Func<'TValue>>) = "ValueExpression" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline attributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "Attributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: MatBlazor.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type matSelectValue<'FunBlazorGeneric, 'TValue, 'TItem> =
    inherit baseMatSelectValue<'FunBlazorGeneric, 'TValue, 'TItem>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MatBlazor.MatSelectValue<'TValue, 'TItem>>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<MatBlazor.MatSelectValue<'TValue, 'TItem>>
    static member inline valueSelector (x: System.Func<'TItem, 'TValue>) = "ValueSelector" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline items (x: System.Collections.Generic.IEnumerable<'TItem>) = "Items" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline itemTemplate (x: Microsoft.AspNetCore.Components.RenderFragment<'TItem>) = "ItemTemplate" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline enhanced (x: System.Boolean) = "Enhanced" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline outlined (x: System.Boolean) = "Outlined" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabled (x: System.Boolean) = "Disabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline label (x: System.String) = "Label" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline icon (x: System.String) = "Icon" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline helperText (x: System.String) = "HelperText" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline helperTextPersistent (x: System.Boolean) = "HelperTextPersistent" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline helperTextValidation (x: System.Boolean) = "HelperTextValidation" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline hideDropDownIcon (x: System.Boolean) = "HideDropDownIcon" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline fullWidth (x: System.Boolean) = "FullWidth" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline iconOnClick fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "IconOnClick" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline validationDisabled (x: System.Boolean) = "ValidationDisabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline value (x: 'TValue) = "Value" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valueChanged fn = (Bolero.Html.attr.callback<'TValue> "ValueChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valueExpression (x: System.Linq.Expressions.Expression<System.Func<'TValue>>) = "ValueExpression" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline attributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "Attributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: MatBlazor.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type matSlider<'FunBlazorGeneric, 'TValue> =
    inherit baseMatSlider<'FunBlazorGeneric, 'TValue>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MatBlazor.MatSlider<'TValue>>
    
    static member inline valueMin (x: 'TValue) = "ValueMin" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valueMax (x: 'TValue) = "ValueMax" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline discrete (x: System.Boolean) = "Discrete" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline label (x: System.String) = "Label" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline markers (x: System.Boolean) = "Markers" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline pin (x: System.Boolean) = "Pin" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline step (x: 'TValue) = "Step" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline enableStep (x: System.Boolean) = "EnableStep" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabled (x: System.Boolean) = "Disabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline immediate (x: System.Boolean) = "Immediate" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline validationDisabled (x: System.Boolean) = "ValidationDisabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline value (x: 'TValue) = "Value" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valueChanged fn = (Bolero.Html.attr.callback<'TValue> "ValueChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valueExpression (x: System.Linq.Expressions.Expression<System.Func<'TValue>>) = "ValueExpression" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline attributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "Attributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: MatBlazor.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type matSlideToggle<'FunBlazorGeneric, 'TValue> =
    inherit baseMatSlideToggle<'FunBlazorGeneric, 'TValue>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MatBlazor.MatSlideToggle<'TValue>>
    
    static member inline label (x: System.String) = "Label" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabled (x: System.Boolean) = "Disabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline inputAttributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "InputAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline validationDisabled (x: System.Boolean) = "ValidationDisabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline value (x: 'TValue) = "Value" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valueChanged fn = (Bolero.Html.attr.callback<'TValue> "ValueChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valueExpression (x: System.Linq.Expressions.Expression<System.Func<'TValue>>) = "ValueExpression" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline attributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "Attributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: MatBlazor.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type matSnackbar<'FunBlazorGeneric> =
    inherit baseMatSnackbar<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MatBlazor.MatSnackbar>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<MatBlazor.MatSnackbar>
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline stacked (x: System.Boolean) = "Stacked" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline leading (x: System.Boolean) = "Leading" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline isOpen (x: System.Boolean) = "IsOpen" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline timeout (x: System.Int32) = "Timeout" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline isOpenChanged fn = (Bolero.Html.attr.callback<System.Boolean> "IsOpenChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline attributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "Attributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: MatBlazor.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type matSnackbarActions<'FunBlazorGeneric> =
    inherit baseMatDomComponent<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MatBlazor.MatSnackbarActions>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<MatBlazor.MatSnackbarActions>
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline attributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "Attributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: MatBlazor.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type matSnackbarContent<'FunBlazorGeneric> =
    inherit baseMatDomComponent<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MatBlazor.MatSnackbarContent>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<MatBlazor.MatSnackbarContent>
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline attributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "Attributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: MatBlazor.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type matSortHeader<'FunBlazorGeneric> =
    inherit baseMatSortHeader<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MatBlazor.MatSortHeader>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<MatBlazor.MatSortHeader>
    static member inline sortId (x: System.String) = "SortId" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline attributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "Attributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: MatBlazor.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type matSortHeaderRow<'FunBlazorGeneric> =
    inherit baseMatSortHeaderRow<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MatBlazor.MatSortHeaderRow>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<MatBlazor.MatSortHeaderRow>
    static member inline sortId (x: System.String) = "SortId" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline sortIdChanged fn = (Bolero.Html.attr.callback<System.String> "SortIdChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline direction (x: MatBlazor.MatSortDirection) = "Direction" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline directionChanged fn = (Bolero.Html.attr.callback<MatBlazor.MatSortDirection> "DirectionChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline sortChanged fn = (Bolero.Html.attr.callback<MatBlazor.MatSortChangedEvent> "SortChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline attributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "Attributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: MatBlazor.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type matTabBar<'FunBlazorGeneric> =
    inherit baseMatTabBar<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MatBlazor.MatTabBar>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<MatBlazor.MatTabBar>
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline active (x: MatBlazor.BaseMatTabLabel) = "Active" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline activeIndex (x: System.Int32) = "ActiveIndex" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline activeChanged fn = (Bolero.Html.attr.callback<MatBlazor.BaseMatTabLabel> "ActiveChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline activeIndexChanged fn = (Bolero.Html.attr.callback<System.Int32> "ActiveIndexChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline attributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "Attributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: MatBlazor.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type matTabLabel<'FunBlazorGeneric> =
    inherit baseMatTabLabel<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MatBlazor.MatTabLabel>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<MatBlazor.MatTabLabel>
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline attributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "Attributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: MatBlazor.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type matTable<'FunBlazorGeneric, 'TableItem> =
    inherit baseMatTable<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MatBlazor.MatTable<'TableItem>>
    
    static member inline matTableHeader (x: Microsoft.AspNetCore.Components.RenderFragment) = "MatTableHeader" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline useSortHeaderRow (x: System.Boolean) = "UseSortHeaderRow" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline matTableRow (x: Microsoft.AspNetCore.Components.RenderFragment<'TableItem>) = "MatTableRow" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline pageSizes (x: System.Collections.Generic.IEnumerable<MatBlazor.BaseMatTable.PageSizeStructure>) = "PageSizes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline items (x: System.Collections.Generic.IEnumerable<'TableItem>) = "Items" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline pageParamName (x: System.String) = "PageParamName" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline pageSizeParamName (x: System.String) = "PageSizeParamName" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline descending (x: System.Boolean) = "Descending" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline descendingParamName (x: System.String) = "DescendingParamName" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline sortBy (x: System.String) = "SortBy" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline sortByParamName (x: System.String) = "SortByParamName" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline pageLabel (x: System.String) = "PageLabel" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline pageRecordCountLabel (x: System.String) = "PageRecordCountLabel" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline pagingDataPropertyName (x: System.String) = "PagingDataPropertyName" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline pagingRecordsCountPropertyName (x: System.String) = "PagingRecordsCountPropertyName" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline searchTermParamName (x: System.String) = "SearchTermParamName" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline selectionChanged (x: System.Action<System.Object>) = "SelectionChanged" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline headerRowClass (x: System.String) = "HeaderRowClass" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline rowClass (x: System.String) = "RowClass" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline allowSelection (x: System.Boolean) = "AllowSelection" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline requestApiOnlyOnce (x: System.Boolean) = "RequestApiOnlyOnce" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline debounceMilliseconds (x: System.Int32) = "DebounceMilliseconds" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline filterByColumnName (x: System.String) = "FilterByColumnName" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline searchTermFieldLabel (x: System.String) = "SearchTermFieldLabel" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline searchTermFieldPlaceHolder (x: System.String) = "SearchTermFieldPlaceHolder" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline loadInitialData (x: System.Boolean) = "LoadInitialData" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline apiUrl (x: System.String) = "ApiUrl" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline showPaging (x: System.Boolean) = "ShowPaging" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline showFooter (x: System.Boolean) = "ShowFooter" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline striped (x: System.Boolean) = "Striped" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline pageSize (x: System.Int32) = "PageSize" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onRowDbClick fn = (Bolero.Html.attr.callback<System.Object> "OnRowDbClick" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline attributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "Attributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: MatBlazor.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type tableRow<'FunBlazorGeneric> =
    inherit baseTableRow<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MatBlazor.TableRow>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<MatBlazor.TableRow>
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline selected (x: System.Boolean) = "Selected" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline allowSelection (x: System.Boolean) = "AllowSelection" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline rowItem (x: System.Object) = "RowItem" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline selectedChanged fn = (Bolero.Html.attr.callback<System.Boolean> "SelectedChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline attributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "Attributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: MatBlazor.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type matTab<'FunBlazorGeneric> =
    inherit baseMatTab<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MatBlazor.MatTab>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<MatBlazor.MatTab>
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline labelContent (x: Microsoft.AspNetCore.Components.RenderFragment) = "LabelContent" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline label (x: System.String) = "Label" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline attributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "Attributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: MatBlazor.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type matTabGroup<'FunBlazorGeneric> =
    inherit baseMatTabGroup<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MatBlazor.MatTabGroup>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<MatBlazor.MatTabGroup>
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline activeIndex (x: System.Int32) = "ActiveIndex" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline activeIndexChanged fn = (Bolero.Html.attr.callback<System.Int32> "ActiveIndexChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline attributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "Attributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: MatBlazor.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type matInputTextComponent<'FunBlazorGeneric, 'T> =
    inherit baseMatInputTextComponent<'FunBlazorGeneric, 'T>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MatBlazor.MatInputTextComponent<'T>>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<MatBlazor.MatInputTextComponent<'T>>
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline iconOnClick fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "IconOnClick" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onFocus fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.FocusEventArgs> "OnFocus" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onFocusOut fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.FocusEventArgs> "OnFocusOut" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onKeyPress fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs> "OnKeyPress" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onKeyDown fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs> "OnKeyDown" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onKeyUp fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs> "OnKeyUp" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onInput fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.ChangeEventArgs> "OnInput" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline label (x: System.String) = "Label" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline icon (x: System.String) = "Icon" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline iconTrailing (x: System.Boolean) = "IconTrailing" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline box (x: System.Boolean) = "Box" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline textArea (x: System.Boolean) = "TextArea" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline dense (x: System.Boolean) = "Dense" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline outlined (x: System.Boolean) = "Outlined" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabled (x: System.Boolean) = "Disabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline readOnly (x: System.Boolean) = "ReadOnly" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline fullWidth (x: System.Boolean) = "FullWidth" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline required (x: System.Boolean) = "Required" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline helperText (x: System.String) = "HelperText" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline helperTextPersistent (x: System.Boolean) = "HelperTextPersistent" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline helperTextValidation (x: System.Boolean) = "HelperTextValidation" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline placeHolder (x: System.String) = "PlaceHolder" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline hideClearButton (x: System.Boolean) = "HideClearButton" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline ``type`` (x: System.String) = "Type" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline inputClass (x: System.String) = "InputClass" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline inputStyle (x: System.String) = "InputStyle" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline format (x: System.String) = "Format" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline inputAttributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "InputAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline validationDisabled (x: System.Boolean) = "ValidationDisabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline value (x: 'T) = "Value" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valueChanged fn = (Bolero.Html.attr.callback<'T> "ValueChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valueExpression (x: System.Linq.Expressions.Expression<System.Func<'T>>) = "ValueExpression" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline attributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "Attributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: MatBlazor.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type matThemeProvider<'FunBlazorGeneric> =
    inherit baseMatThemeProvider<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MatBlazor.MatThemeProvider>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<MatBlazor.MatThemeProvider>
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline theme (x: MatBlazor.MatTheme) = "Theme" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type matToastContainer<'FunBlazorGeneric> =
    inherit baseMatToastContainer<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MatBlazor.MatToastContainer>
    
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline attributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "Attributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: MatBlazor.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type matToastItem<'FunBlazorGeneric> =
    inherit baseMatToastItem<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MatBlazor.MatToastItem>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<MatBlazor.MatToastItem>
    static member inline toast (x: MatBlazor.MatToast) = "Toast" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline icon (x: System.String) = "Icon" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline ``type`` (x: MatBlazor.MatToastType) = "Type" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline attributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "Attributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: MatBlazor.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type matTooltip<'FunBlazorGeneric> =
    inherit baseMatTooltip<'FunBlazorGeneric>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MatBlazor.MatTooltip>
    
    static member inline childContent (x: Microsoft.AspNetCore.Components.RenderFragment<MatBlazor.ForwardRef>) = "ChildContent" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline tooltipContent (x: Microsoft.AspNetCore.Components.RenderFragment) = "TooltipContent" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline tooltip (x: System.String) = "Tooltip" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline targetId (x: System.String) = "TargetId" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline wrap (x: System.Boolean) = "Wrap" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline position (x: MatBlazor.MatTooltipPosition) = "Position" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline targetForwardRef (x: MatBlazor.ForwardRef) = "TargetForwardRef" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline attributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "Attributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: MatBlazor.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        

type matVirtualScroll<'FunBlazorGeneric, 'ItemType> =
    inherit baseMatVirtualScroll<'FunBlazorGeneric, 'ItemType>
    static member create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<MatBlazor.MatVirtualScroll<'ItemType>>
    static member create (nodes: FunBlazorNode list) = nodes |> html.blazor<MatBlazor.MatVirtualScroll<'ItemType>>
    static member inline itemHeight (x: System.Int32) = "ItemHeight" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabled (x: System.Boolean) = "Disabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (nodes: FunBlazorNode list) = attr.children nodes |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline children (text: string) = attr.children text |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline itemTemplate (x: Microsoft.AspNetCore.Components.RenderFragment<'ItemType>) = "ItemTemplate" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline items (x: System.Collections.Generic.IEnumerable<'ItemType>) = "Items" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline attributes (x: System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>) = "Attributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: MatBlazor.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
        


namespace rec Fun.Blazor.MatBlazor


type IBaseMatComponentNode = interface end

type baseMatComponent =
    class
        inherit Internal.baseMatComponent<IBaseMatComponentNode>
    end

type IBaseMatContainerComponentNode = interface end

type baseMatContainerComponent =
    class
        inherit Internal.baseMatContainerComponent<IBaseMatContainerComponentNode>
    end

type IBaseMatDomComponentNode = interface end

type baseMatDomComponent =
    class
        inherit Internal.baseMatDomComponent<IBaseMatDomComponentNode>
    end

type IBaseMatInputComponentNode<'T> = interface end

type baseMatInputComponent<'T> =
    class
        inherit Internal.baseMatInputComponent<IBaseMatInputComponentNode<'T>, 'T>
    end

type IBaseMatInputElementComponentNode<'T> = interface end

type baseMatInputElementComponent<'T> =
    class
        inherit Internal.baseMatInputElementComponent<IBaseMatInputElementComponentNode<'T>, 'T>
    end

type IBaseMatInputTextElementComponentNode<'T> = interface end

type baseMatInputTextElementComponent<'T> =
    class
        inherit Internal.baseMatInputTextElementComponent<IBaseMatInputTextElementComponentNode<'T>, 'T>
    end

type IMatComponentHostNode = interface end

type matComponentHost =
    class
        inherit Internal.matComponentHost<IMatComponentHostNode>
    end

type IMatAccordionNode = interface end

type matAccordion =
    class
        inherit Internal.matAccordion<IMatAccordionNode>
    end

type IMatExpansionPanelNode = interface end

type matExpansionPanel =
    class
        inherit Internal.matExpansionPanel<IMatExpansionPanelNode>
    end

type IMatExpansionPanelDetailsNode = interface end

type matExpansionPanelDetails =
    class
        inherit Internal.matExpansionPanelDetails<IMatExpansionPanelDetailsNode>
    end

type IMatExpansionPanelHeaderNode = interface end

type matExpansionPanelHeader =
    class
        inherit Internal.matExpansionPanelHeader<IMatExpansionPanelHeaderNode>
    end

type IMatExpansionPanelSubHeaderNode = interface end

type matExpansionPanelSubHeader =
    class
        inherit Internal.matExpansionPanelSubHeader<IMatExpansionPanelSubHeaderNode>
    end

type IMatExpansionPanelSummaryNode = interface end

type matExpansionPanelSummary =
    class
        inherit Internal.matExpansionPanelSummary<IMatExpansionPanelSummaryNode>
    end

type IMatAnchorContainerNode = interface end

type matAnchorContainer =
    class
        inherit Internal.matAnchorContainer<IMatAnchorContainerNode>
    end

type IMatAnchorLinkNode = interface end

type matAnchorLink =
    class
        inherit Internal.matAnchorLink<IMatAnchorLinkNode>
    end

type IMatAnchorUtilsNode = interface end

type matAnchorUtils =
    class
        inherit Internal.matAnchorUtils<IMatAnchorUtilsNode>
    end

type IMatAppBarNode = interface end

type matAppBar =
    class
        inherit Internal.matAppBar<IMatAppBarNode>
    end

type IMatAppBarActionNode = interface end

type matAppBarAction =
    class
        inherit Internal.matAppBarAction<IMatAppBarActionNode>
    end

type IMatAppBarAdjustNode = interface end

type matAppBarAdjust =
    class
        inherit Internal.matAppBarAdjust<IMatAppBarAdjustNode>
    end

type IMatAppBarContainerNode = interface end

type matAppBarContainer =
    class
        inherit Internal.matAppBarContainer<IMatAppBarContainerNode>
    end

type IMatAppBarContentNode = interface end

type matAppBarContent =
    class
        inherit Internal.matAppBarContent<IMatAppBarContentNode>
    end

type IMatAppBarNavigationIconNode = interface end

type matAppBarNavigationIcon =
    class
        inherit Internal.matAppBarNavigationIcon<IMatAppBarNavigationIconNode>
    end

type IMatAppBarRowNode = interface end

type matAppBarRow =
    class
        inherit Internal.matAppBarRow<IMatAppBarRowNode>
    end

type IMatAppBarSectionNode = interface end

type matAppBarSection =
    class
        inherit Internal.matAppBarSection<IMatAppBarSectionNode>
    end

type IMatAppBarTitleNode = interface end

type matAppBarTitle =
    class
        inherit Internal.matAppBarTitle<IMatAppBarTitleNode>
    end

type IBaseMatAutocompleteListNode<'TItem> = interface end

type baseMatAutocompleteList<'TItem> =
    class
        inherit Internal.baseMatAutocompleteList<IBaseMatAutocompleteListNode<'TItem>, 'TItem>
    end

type IBaseMatAutocompleteNode<'TValue, 'TItem> = interface end

type baseMatAutocomplete<'TValue, 'TItem> =
    class
        inherit Internal.baseMatAutocomplete<IBaseMatAutocompleteNode<'TValue, 'TItem>, 'TValue, 'TItem>
    end

type IBaseMatButtonLinkNode = interface end

type baseMatButtonLink =
    class
        inherit Internal.baseMatButtonLink<IBaseMatButtonLinkNode>
    end

type IMatButtonNode = interface end

type matButton =
    class
        inherit Internal.matButton<IMatButtonNode>
    end

type IMatCardNode = interface end

type matCard =
    class
        inherit Internal.matCard<IMatCardNode>
    end

type IMatCardActionButtonsNode = interface end

type matCardActionButtons =
    class
        inherit Internal.matCardActionButtons<IMatCardActionButtonsNode>
    end

type IMatCardActionIconsNode = interface end

type matCardActionIcons =
    class
        inherit Internal.matCardActionIcons<IMatCardActionIconsNode>
    end

type IMatCardActionsNode = interface end

type matCardActions =
    class
        inherit Internal.matCardActions<IMatCardActionsNode>
    end

type IMatCardContentNode = interface end

type matCardContent =
    class
        inherit Internal.matCardContent<IMatCardContentNode>
    end

type IMatCardMediaNode = interface end

type matCardMedia =
    class
        inherit Internal.matCardMedia<IMatCardMediaNode>
    end

type IBaseMatCheckboxInternalNode<'TValue> = interface end

type baseMatCheckboxInternal<'TValue> =
    class
        inherit Internal.baseMatCheckboxInternal<IBaseMatCheckboxInternalNode<'TValue>, 'TValue>
    end

type IMatCheckboxNode<'TValue> = interface end

type matCheckbox<'TValue> =
    class
        inherit Internal.matCheckbox<IMatCheckboxNode<'TValue>, 'TValue>
    end

type IMatChipSetNode = interface end

type matChipSet =
    class
        inherit Internal.matChipSet<IMatChipSetNode>
    end

type IMatChipNode = interface end

type matChip =
    class
        inherit Internal.matChip<IMatChipNode>
    end

type IBaseMatDataTableColumnOldNode<'TItem> = interface end

type baseMatDataTableColumnOld<'TItem> =
    class
        inherit Internal.baseMatDataTableColumnOld<IBaseMatDataTableColumnOldNode<'TItem>, 'TItem>
    end

type IBaseMatDataTableOldNode<'TItem> = interface end

type baseMatDataTableOld<'TItem> =
    class
        inherit Internal.baseMatDataTableOld<IBaseMatDataTableOldNode<'TItem>, 'TItem>
    end

type IMatDataTableNode = interface end

type matDataTable =
    class
        inherit Internal.matDataTable<IMatDataTableNode>
    end

type IMatDataTableColumnNode = interface end

type matDataTableColumn =
    class
        inherit Internal.matDataTableColumn<IMatDataTableColumnNode>
    end

type IMatDataTableContentNode<'TItem> = interface end

type matDataTableContent<'TItem> =
    class
        inherit Internal.matDataTableContent<IMatDataTableContentNode<'TItem>, 'TItem>
    end

type IBaseMatDatePickerInternalNode<'TValue> = interface end

type baseMatDatePickerInternal<'TValue> =
    class
        inherit Internal.baseMatDatePickerInternal<IBaseMatDatePickerInternalNode<'TValue>, 'TValue>
    end

type IMatDatePickerNode<'TValue> = interface end

type matDatePicker<'TValue> =
    class
        inherit Internal.matDatePicker<IMatDatePickerNode<'TValue>, 'TValue>
    end

type IBaseMatDialogNode = interface end

type baseMatDialog =
    class
        inherit Internal.baseMatDialog<IBaseMatDialogNode>
    end

type IMatDividerNode = interface end

type matDivider =
    class
        inherit Internal.matDivider<IMatDividerNode>
    end

type IBaseMatDrawerContainerNode = interface end

type baseMatDrawerContainer =
    class
        inherit Internal.baseMatDrawerContainer<IBaseMatDrawerContainerNode>
    end

type IBaseMatDrawerContentNode = interface end

type baseMatDrawerContent =
    class
        inherit Internal.baseMatDrawerContent<IBaseMatDrawerContentNode>
    end

type IBaseMatDrawerNode = interface end

type baseMatDrawer =
    class
        inherit Internal.baseMatDrawer<IBaseMatDrawerNode>
    end

type IBaseMatFABNode = interface end

type baseMatFAB =
    class
        inherit Internal.baseMatFAB<IBaseMatFABNode>
    end

type IBaseMatFileUploadNode = interface end

type baseMatFileUpload =
    class
        inherit Internal.baseMatFileUpload<IBaseMatFileUploadNode>
    end

type IBaseMatHelperTextNode = interface end

type baseMatHelperText =
    class
        inherit Internal.baseMatHelperText<IBaseMatHelperTextNode>
    end

type IBaseMatHiddenNode = interface end

type baseMatHidden =
    class
        inherit Internal.baseMatHidden<IBaseMatHiddenNode>
    end

type IBaseMatIconButtonNode = interface end

type baseMatIconButton =
    class
        inherit Internal.baseMatIconButton<IBaseMatIconButtonNode>
    end

type IBaseMatIconNode = interface end

type baseMatIcon =
    class
        inherit Internal.baseMatIcon<IBaseMatIconNode>
    end

type IBaseMatListGroupNode = interface end

type baseMatListGroup =
    class
        inherit Internal.baseMatListGroup<IBaseMatListGroupNode>
    end

type IBaseMatListNode = interface end

type baseMatList =
    class
        inherit Internal.baseMatList<IBaseMatListNode>
    end

type IBaseMatListItemNode = interface end

type baseMatListItem =
    class
        inherit Internal.baseMatListItem<IBaseMatListItemNode>
    end

type IBaseMatMenuNode = interface end

type baseMatMenu =
    class
        inherit Internal.baseMatMenu<IBaseMatMenuNode>
    end

type IBaseMatNavItemNode = interface end

type baseMatNavItem =
    class
        inherit Internal.baseMatNavItem<IBaseMatNavItemNode>
    end

type IBaseMatNavMenuNode = interface end

type baseMatNavMenu =
    class
        inherit Internal.baseMatNavMenu<IBaseMatNavMenuNode>
    end

type IBaseMatNavSubMenuNode = interface end

type baseMatNavSubMenu =
    class
        inherit Internal.baseMatNavSubMenu<IBaseMatNavSubMenuNode>
    end

type IBaseMatNumericUpDownFieldInternalNode<'TValue> = interface end

type baseMatNumericUpDownFieldInternal<'TValue> =
    class
        inherit Internal.baseMatNumericUpDownFieldInternal<IBaseMatNumericUpDownFieldInternalNode<'TValue>, 'TValue>
    end

type IMatNumericUpDownFieldNode<'TValue> = interface end

type matNumericUpDownField<'TValue> =
    class
        inherit Internal.matNumericUpDownField<IMatNumericUpDownFieldNode<'TValue>, 'TValue>
    end

type IBaseMatPaginatorNode = interface end

type baseMatPaginator =
    class
        inherit Internal.baseMatPaginator<IBaseMatPaginatorNode>
    end

type IBaseMatPaperNode = interface end

type baseMatPaper =
    class
        inherit Internal.baseMatPaper<IBaseMatPaperNode>
    end

type IBaseMatProgressBarNode = interface end

type baseMatProgressBar =
    class
        inherit Internal.baseMatProgressBar<IBaseMatProgressBarNode>
    end

type IBaseMatProgressCircleNode = interface end

type baseMatProgressCircle =
    class
        inherit Internal.baseMatProgressCircle<IBaseMatProgressCircleNode>
    end

type IBaseMatRadioButtonInternalNode<'TValue> = interface end

type baseMatRadioButtonInternal<'TValue> =
    class
        inherit Internal.baseMatRadioButtonInternal<IBaseMatRadioButtonInternalNode<'TValue>, 'TValue>
    end

type IBaseMatRadioGroupInternalNode<'TValue> = interface end

type baseMatRadioGroupInternal<'TValue> =
    class
        inherit Internal.baseMatRadioGroupInternal<IBaseMatRadioGroupInternalNode<'TValue>, 'TValue>
    end

type IMatRadioButtonNode<'TValue> = interface end

type matRadioButton<'TValue> =
    class
        inherit Internal.matRadioButton<IMatRadioButtonNode<'TValue>, 'TValue>
    end

type IMatRadioGroupNode<'TValue> = interface end

type matRadioGroup<'TValue> =
    class
        inherit Internal.matRadioGroup<IMatRadioGroupNode<'TValue>, 'TValue>
    end

type IBaseMatRippleNode = interface end

type baseMatRipple =
    class
        inherit Internal.baseMatRipple<IBaseMatRippleNode>
    end

type IBaseCoreMatOptionNode<'TValue> = interface end

type baseCoreMatOption<'TValue> =
    class
        inherit Internal.baseCoreMatOption<IBaseCoreMatOptionNode<'TValue>, 'TValue>
    end

type IBaseCoreMatSelectNode<'TValue, 'TKey> = interface end

type baseCoreMatSelect<'TValue, 'TKey> =
    class
        inherit Internal.baseCoreMatSelect<IBaseCoreMatSelectNode<'TValue, 'TKey>, 'TValue, 'TKey>
    end

type IBaseCoreMatSelectValueNode<'TValue, 'TItem> = interface end

type baseCoreMatSelectValue<'TValue, 'TItem> =
    class
        inherit Internal.baseCoreMatSelectValue<IBaseCoreMatSelectValueNode<'TValue, 'TItem>, 'TValue, 'TItem>
    end

type IBaseMatOptionNode<'TValue> = interface end

type baseMatOption<'TValue> =
    class
        inherit Internal.baseMatOption<IBaseMatOptionNode<'TValue>, 'TValue>
    end

type IBaseMatSelectNode<'TValue> = interface end

type baseMatSelect<'TValue> =
    class
        inherit Internal.baseMatSelect<IBaseMatSelectNode<'TValue>, 'TValue>
    end

type IBaseMatSelectItemNode<'TValue> = interface end

type baseMatSelectItem<'TValue> =
    class
        inherit Internal.baseMatSelectItem<IBaseMatSelectItemNode<'TValue>, 'TValue>
    end

type IBaseMatSelectValueNode<'TValue, 'TItem> = interface end

type baseMatSelectValue<'TValue, 'TItem> =
    class
        inherit Internal.baseMatSelectValue<IBaseMatSelectValueNode<'TValue, 'TItem>, 'TValue, 'TItem>
    end

type IMatOptionNode<'TValue> = interface end

type matOption<'TValue> =
    class
        inherit Internal.matOption<IMatOptionNode<'TValue>, 'TValue>
    end

type IMatOptionStringNode = interface end

type matOptionString =
    class
        inherit Internal.matOptionString<IMatOptionStringNode>
    end

type IBaseMatSliderNode<'TValue> = interface end

type baseMatSlider<'TValue> =
    class
        inherit Internal.baseMatSlider<IBaseMatSliderNode<'TValue>, 'TValue>
    end

type IBaseMatSlideToggleNode<'TValue> = interface end

type baseMatSlideToggle<'TValue> =
    class
        inherit Internal.baseMatSlideToggle<IBaseMatSlideToggleNode<'TValue>, 'TValue>
    end

type IBaseMatSnackbarNode = interface end

type baseMatSnackbar =
    class
        inherit Internal.baseMatSnackbar<IBaseMatSnackbarNode>
    end

type IBaseMatSortHeaderNode = interface end

type baseMatSortHeader =
    class
        inherit Internal.baseMatSortHeader<IBaseMatSortHeaderNode>
    end

type IBaseMatSortHeaderRowNode = interface end

type baseMatSortHeaderRow =
    class
        inherit Internal.baseMatSortHeaderRow<IBaseMatSortHeaderRowNode>
    end

type IBaseMatTabBarNode = interface end

type baseMatTabBar =
    class
        inherit Internal.baseMatTabBar<IBaseMatTabBarNode>
    end

type IBaseMatTabLabelNode = interface end

type baseMatTabLabel =
    class
        inherit Internal.baseMatTabLabel<IBaseMatTabLabelNode>
    end

type IBaseMatTableNode = interface end

type baseMatTable =
    class
        inherit Internal.baseMatTable<IBaseMatTableNode>
    end

type IBaseTableRowNode = interface end

type baseTableRow =
    class
        inherit Internal.baseTableRow<IBaseTableRowNode>
    end

type IBaseMatTabNode = interface end

type baseMatTab =
    class
        inherit Internal.baseMatTab<IBaseMatTabNode>
    end

type IBaseMatTabGroupNode = interface end

type baseMatTabGroup =
    class
        inherit Internal.baseMatTabGroup<IBaseMatTabGroupNode>
    end

type IBaseMatInputTextComponentNode<'TValue> = interface end

type baseMatInputTextComponent<'TValue> =
    class
        inherit Internal.baseMatInputTextComponent<IBaseMatInputTextComponentNode<'TValue>, 'TValue>
    end

type IMatStringFieldNode = interface end

type matStringField =
    class
        inherit Internal.matStringField<IMatStringFieldNode>
    end

type IMatTextFieldNode<'TValue> = interface end

type matTextField<'TValue> =
    class
        inherit Internal.matTextField<IMatTextFieldNode<'TValue>, 'TValue>
    end

type IBaseMatThemeProviderNode = interface end

type baseMatThemeProvider =
    class
        inherit Internal.baseMatThemeProvider<IBaseMatThemeProviderNode>
    end

type IBaseMatToastContainerNode = interface end

type baseMatToastContainer =
    class
        inherit Internal.baseMatToastContainer<IBaseMatToastContainerNode>
    end

type IBaseMatToastItemNode = interface end

type baseMatToastItem =
    class
        inherit Internal.baseMatToastItem<IBaseMatToastItemNode>
    end

type IBaseMatTooltipNode = interface end

type baseMatTooltip =
    class
        inherit Internal.baseMatTooltip<IBaseMatTooltipNode>
    end

type IMatTreeNodeNode<'TNode> = interface end

type matTreeNode<'TNode when 'TNode : not struct> =
    class
        inherit Internal.matTreeNode<IMatTreeNodeNode<'TNode>, 'TNode>
    end

type IMatTreeViewNode<'TNode> = interface end

type matTreeView<'TNode when 'TNode : not struct> =
    class
        inherit Internal.matTreeView<IMatTreeViewNode<'TNode>, 'TNode>
    end

type IBaseMatTypographyNode = interface end

type baseMatTypography =
    class
        inherit Internal.baseMatTypography<IBaseMatTypographyNode>
    end

type IMatHeadline1Node = interface end

type matHeadline1 =
    class
        inherit Internal.matHeadline1<IMatHeadline1Node>
    end

type IMatHeadline2Node = interface end

type matHeadline2 =
    class
        inherit Internal.matHeadline2<IMatHeadline2Node>
    end

type IMatHeadline3Node = interface end

type matHeadline3 =
    class
        inherit Internal.matHeadline3<IMatHeadline3Node>
    end

type IMatHeadline4Node = interface end

type matHeadline4 =
    class
        inherit Internal.matHeadline4<IMatHeadline4Node>
    end

type IMatHeadline5Node = interface end

type matHeadline5 =
    class
        inherit Internal.matHeadline5<IMatHeadline5Node>
    end

type IMatHeadline6Node = interface end

type matHeadline6 =
    class
        inherit Internal.matHeadline6<IMatHeadline6Node>
    end

type IMatH1Node = interface end

type matH1 =
    class
        inherit Internal.matH1<IMatH1Node>
    end

type IMatH2Node = interface end

type matH2 =
    class
        inherit Internal.matH2<IMatH2Node>
    end

type IMatH3Node = interface end

type matH3 =
    class
        inherit Internal.matH3<IMatH3Node>
    end

type IMatH4Node = interface end

type matH4 =
    class
        inherit Internal.matH4<IMatH4Node>
    end

type IMatH5Node = interface end

type matH5 =
    class
        inherit Internal.matH5<IMatH5Node>
    end

type IMatH6Node = interface end

type matH6 =
    class
        inherit Internal.matH6<IMatH6Node>
    end

type IMatSubtitle1Node = interface end

type matSubtitle1 =
    class
        inherit Internal.matSubtitle1<IMatSubtitle1Node>
    end

type IMatSubtitle2Node = interface end

type matSubtitle2 =
    class
        inherit Internal.matSubtitle2<IMatSubtitle2Node>
    end

type IMatBody1Node = interface end

type matBody1 =
    class
        inherit Internal.matBody1<IMatBody1Node>
    end

type IMatBody2Node = interface end

type matBody2 =
    class
        inherit Internal.matBody2<IMatBody2Node>
    end

type IMatCaptionNode = interface end

type matCaption =
    class
        inherit Internal.matCaption<IMatCaptionNode>
    end

type IMatOverlineNode = interface end

type matOverline =
    class
        inherit Internal.matOverline<IMatOverlineNode>
    end

type IBaseMatVirtualScrollNode<'TItem> = interface end

type baseMatVirtualScroll<'TItem> =
    class
        inherit Internal.baseMatVirtualScroll<IBaseMatVirtualScrollNode<'TItem>, 'TItem>
    end

type IMatViewChildrenNode<'TSelect> = interface end

type matViewChildren<'TSelect when 'TSelect :> Microsoft.AspNetCore.Components.IComponent> =
    class
        inherit Internal.matViewChildren<IMatViewChildrenNode<'TSelect>, 'TSelect>
    end

type IForwardRefContextNode<'TRef> = interface end

type forwardRefContext<'TRef> =
    class
        inherit Internal.forwardRefContext<IForwardRefContextNode<'TRef>, 'TRef>
    end

type IMatContentWrapperNode = interface end

type matContentWrapper =
    class
        inherit Internal.matContentWrapper<IMatContentWrapperNode>
    end

type IMatItemsControlNode<'T> = interface end

type matItemsControl<'T> =
    class
        inherit Internal.matItemsControl<IMatItemsControlNode<'T>, 'T>
    end

type IMatAutocompleteListNode<'TItem> = interface end

type matAutocompleteList<'TItem> =
    class
        inherit Internal.matAutocompleteList<IMatAutocompleteListNode<'TItem>, 'TItem>
    end

type IMatAutocompleteNode<'TValue, 'TItem> = interface end

type matAutocomplete<'TValue, 'TItem> =
    class
        inherit Internal.matAutocomplete<IMatAutocompleteNode<'TValue, 'TItem>, 'TValue, 'TItem>
    end

type IMatButtonLinkNode = interface end

type matButtonLink =
    class
        inherit Internal.matButtonLink<IMatButtonLinkNode>
    end

type IMatCheckboxInternalNode<'TValue> = interface end

type matCheckboxInternal<'TValue> =
    class
        inherit Internal.matCheckboxInternal<IMatCheckboxInternalNode<'TValue>, 'TValue>
    end

type IMatDataTableCellOldNode = interface end

type matDataTableCellOld =
    class
        inherit Internal.matDataTableCellOld<IMatDataTableCellOldNode>
    end

type IMatDataTableColumnOldNode<'TItem> = interface end

type matDataTableColumnOld<'TItem> =
    class
        inherit Internal.matDataTableColumnOld<IMatDataTableColumnOldNode<'TItem>, 'TItem>
    end

type IMatDataTableContentOldNode = interface end

type matDataTableContentOld =
    class
        inherit Internal.matDataTableContentOld<IMatDataTableContentOldNode>
    end

type IMatDataTableHeaderCellOldNode = interface end

type matDataTableHeaderCellOld =
    class
        inherit Internal.matDataTableHeaderCellOld<IMatDataTableHeaderCellOldNode>
    end

type IMatDataTableHeaderOldNode = interface end

type matDataTableHeaderOld =
    class
        inherit Internal.matDataTableHeaderOld<IMatDataTableHeaderOldNode>
    end

type IMatDataTableOldNode<'TItem> = interface end

type matDataTableOld<'TItem> =
    class
        inherit Internal.matDataTableOld<IMatDataTableOldNode<'TItem>, 'TItem>
    end

type IMatDataTableRowOldNode = interface end

type matDataTableRowOld =
    class
        inherit Internal.matDataTableRowOld<IMatDataTableRowOldNode>
    end

type IMatDatePickerInternalNode<'TValue> = interface end

type matDatePickerInternal<'TValue> =
    class
        inherit Internal.matDatePickerInternal<IMatDatePickerInternalNode<'TValue>, 'TValue>
    end

type IMatDialogAlertNode = interface end

type matDialogAlert =
    class
        inherit Internal.matDialogAlert<IMatDialogAlertNode>
    end

type IMatDialogAskNode = interface end

type matDialogAsk =
    class
        inherit Internal.matDialogAsk<IMatDialogAskNode>
    end

type IMatDialogConfirmNode = interface end

type matDialogConfirm =
    class
        inherit Internal.matDialogConfirm<IMatDialogConfirmNode>
    end

type IMatDialogPromptNode = interface end

type matDialogPrompt =
    class
        inherit Internal.matDialogPrompt<IMatDialogPromptNode>
    end

type IMatDialogServiceItemNode = interface end

type matDialogServiceItem =
    class
        inherit Internal.matDialogServiceItem<IMatDialogServiceItemNode>
    end

type IMatDialogNode = interface end

type matDialog =
    class
        inherit Internal.matDialog<IMatDialogNode>
    end

type IMatDialogActionsNode = interface end

type matDialogActions =
    class
        inherit Internal.matDialogActions<IMatDialogActionsNode>
    end

type IMatDialogContentNode = interface end

type matDialogContent =
    class
        inherit Internal.matDialogContent<IMatDialogContentNode>
    end

type IMatDialogTitleNode = interface end

type matDialogTitle =
    class
        inherit Internal.matDialogTitle<IMatDialogTitleNode>
    end

type IMatDrawerContainerNode = interface end

type matDrawerContainer =
    class
        inherit Internal.matDrawerContainer<IMatDrawerContainerNode>
    end

type IMatDrawerContentNode = interface end

type matDrawerContent =
    class
        inherit Internal.matDrawerContent<IMatDrawerContentNode>
    end

type IMatDrawerNode = interface end

type matDrawer =
    class
        inherit Internal.matDrawer<IMatDrawerNode>
    end

type IMatFABNode = interface end

type matFAB =
    class
        inherit Internal.matFAB<IMatFABNode>
    end

type IMatFileUploadNode = interface end

type matFileUpload =
    class
        inherit Internal.matFileUpload<IMatFileUploadNode>
    end

type IMatHelperTextNode = interface end

type matHelperText =
    class
        inherit Internal.matHelperText<IMatHelperTextNode>
    end

type IMatHiddenNode = interface end

type matHidden =
    class
        inherit Internal.matHidden<IMatHiddenNode>
    end

type IMatIconButtonNode = interface end

type matIconButton =
    class
        inherit Internal.matIconButton<IMatIconButtonNode>
    end

type IMatIconNode = interface end

type matIcon =
    class
        inherit Internal.matIcon<IMatIconNode>
    end

type IMatListGroupNode = interface end

type matListGroup =
    class
        inherit Internal.matListGroup<IMatListGroupNode>
    end

type IMatListGroupSubHeaderNode = interface end

type matListGroupSubHeader =
    class
        inherit Internal.matListGroupSubHeader<IMatListGroupSubHeaderNode>
    end

type IMatListNode = interface end

type matList =
    class
        inherit Internal.matList<IMatListNode>
    end

type IMatListDividerNode = interface end

type matListDivider =
    class
        inherit Internal.matListDivider<IMatListDividerNode>
    end

type IMatListItemNode = interface end

type matListItem =
    class
        inherit Internal.matListItem<IMatListItemNode>
    end

type IMatListItemPrimaryTextNode = interface end

type matListItemPrimaryText =
    class
        inherit Internal.matListItemPrimaryText<IMatListItemPrimaryTextNode>
    end

type IMatListItemSecondaryTextNode = interface end

type matListItemSecondaryText =
    class
        inherit Internal.matListItemSecondaryText<IMatListItemSecondaryTextNode>
    end

type IMatListItemTextNode = interface end

type matListItemText =
    class
        inherit Internal.matListItemText<IMatListItemTextNode>
    end

type IMatMenuNode = interface end

type matMenu =
    class
        inherit Internal.matMenu<IMatMenuNode>
    end

type IMatNavItemNode = interface end

type matNavItem =
    class
        inherit Internal.matNavItem<IMatNavItemNode>
    end

type IMatNavMenuNode = interface end

type matNavMenu =
    class
        inherit Internal.matNavMenu<IMatNavMenuNode>
    end

type IMatNavSubMenuNode = interface end

type matNavSubMenu =
    class
        inherit Internal.matNavSubMenu<IMatNavSubMenuNode>
    end

type IMatNavSubMenuHeaderNode = interface end

type matNavSubMenuHeader =
    class
        inherit Internal.matNavSubMenuHeader<IMatNavSubMenuHeaderNode>
    end

type IMatNavSubMenuListNode = interface end

type matNavSubMenuList =
    class
        inherit Internal.matNavSubMenuList<IMatNavSubMenuListNode>
    end

type IMatNumericUpDownFieldInternalNode<'TValue> = interface end

type matNumericUpDownFieldInternal<'TValue> =
    class
        inherit Internal.matNumericUpDownFieldInternal<IMatNumericUpDownFieldInternalNode<'TValue>, 'TValue>
    end

type IMatPaginatorNode = interface end

type matPaginator =
    class
        inherit Internal.matPaginator<IMatPaginatorNode>
    end

type IMatPaperNode = interface end

type matPaper =
    class
        inherit Internal.matPaper<IMatPaperNode>
    end

type IMatProgressBarNode = interface end

type matProgressBar =
    class
        inherit Internal.matProgressBar<IMatProgressBarNode>
    end

type IMatProgressCircleNode = interface end

type matProgressCircle =
    class
        inherit Internal.matProgressCircle<IMatProgressCircleNode>
    end

type IMatRadioButtonInternalNode<'TValue> = interface end

type matRadioButtonInternal<'TValue> =
    class
        inherit Internal.matRadioButtonInternal<IMatRadioButtonInternalNode<'TValue>, 'TValue>
    end

type IMatRadioGroupInternalNode<'TValue> = interface end

type matRadioGroupInternal<'TValue> =
    class
        inherit Internal.matRadioGroupInternal<IMatRadioGroupInternalNode<'TValue>, 'TValue>
    end

type IMatRippleNode = interface end

type matRipple =
    class
        inherit Internal.matRipple<IMatRippleNode>
    end

type ICoreMatOptionNode<'TValue> = interface end

type coreMatOption<'TValue> =
    class
        inherit Internal.coreMatOption<ICoreMatOptionNode<'TValue>, 'TValue>
    end

type ICoreMatSelectNode<'TValue, 'TKey> = interface end

type coreMatSelect<'TValue, 'TKey> =
    class
        inherit Internal.coreMatSelect<ICoreMatSelectNode<'TValue, 'TKey>, 'TValue, 'TKey>
    end

type ICoreMatSelectValueNode<'TValue, 'TItem> = interface end

type coreMatSelectValue<'TValue, 'TItem> =
    class
        inherit Internal.coreMatSelectValue<ICoreMatSelectValueNode<'TValue, 'TItem>, 'TValue, 'TItem>
    end

type IMatSelectNode<'TValue> = interface end

type matSelect<'TValue> =
    class
        inherit Internal.matSelect<IMatSelectNode<'TValue>, 'TValue>
    end

type IMatSelectItemNode<'TValue> = interface end

type matSelectItem<'TValue> =
    class
        inherit Internal.matSelectItem<IMatSelectItemNode<'TValue>, 'TValue>
    end

type IMatSelectValueNode<'TValue, 'TItem> = interface end

type matSelectValue<'TValue, 'TItem> =
    class
        inherit Internal.matSelectValue<IMatSelectValueNode<'TValue, 'TItem>, 'TValue, 'TItem>
    end

type IMatSliderNode<'TValue> = interface end

type matSlider<'TValue> =
    class
        inherit Internal.matSlider<IMatSliderNode<'TValue>, 'TValue>
    end

type IMatSlideToggleNode<'TValue> = interface end

type matSlideToggle<'TValue> =
    class
        inherit Internal.matSlideToggle<IMatSlideToggleNode<'TValue>, 'TValue>
    end

type IMatSnackbarNode = interface end

type matSnackbar =
    class
        inherit Internal.matSnackbar<IMatSnackbarNode>
    end

type IMatSnackbarActionsNode = interface end

type matSnackbarActions =
    class
        inherit Internal.matSnackbarActions<IMatSnackbarActionsNode>
    end

type IMatSnackbarContentNode = interface end

type matSnackbarContent =
    class
        inherit Internal.matSnackbarContent<IMatSnackbarContentNode>
    end

type IMatSortHeaderNode = interface end

type matSortHeader =
    class
        inherit Internal.matSortHeader<IMatSortHeaderNode>
    end

type IMatSortHeaderRowNode = interface end

type matSortHeaderRow =
    class
        inherit Internal.matSortHeaderRow<IMatSortHeaderRowNode>
    end

type IMatTabBarNode = interface end

type matTabBar =
    class
        inherit Internal.matTabBar<IMatTabBarNode>
    end

type IMatTabLabelNode = interface end

type matTabLabel =
    class
        inherit Internal.matTabLabel<IMatTabLabelNode>
    end

type IMatTableNode<'TableItem> = interface end

type matTable<'TableItem> =
    class
        inherit Internal.matTable<IMatTableNode<'TableItem>, 'TableItem>
    end

type ITableRowNode = interface end

type tableRow =
    class
        inherit Internal.tableRow<ITableRowNode>
    end

type IMatTabNode = interface end

type matTab =
    class
        inherit Internal.matTab<IMatTabNode>
    end

type IMatTabGroupNode = interface end

type matTabGroup =
    class
        inherit Internal.matTabGroup<IMatTabGroupNode>
    end

type IMatInputTextComponentNode<'T> = interface end

type matInputTextComponent<'T> =
    class
        inherit Internal.matInputTextComponent<IMatInputTextComponentNode<'T>, 'T>
    end

type IMatThemeProviderNode = interface end

type matThemeProvider =
    class
        inherit Internal.matThemeProvider<IMatThemeProviderNode>
    end

type IMatToastContainerNode = interface end

type matToastContainer =
    class
        inherit Internal.matToastContainer<IMatToastContainerNode>
    end

type IMatToastItemNode = interface end

type matToastItem =
    class
        inherit Internal.matToastItem<IMatToastItemNode>
    end

type IMatTooltipNode = interface end

type matTooltip =
    class
        inherit Internal.matTooltip<IMatTooltipNode>
    end

type IMatVirtualScrollNode<'ItemType> = interface end

type matVirtualScroll<'ItemType> =
    class
        inherit Internal.matVirtualScroll<IMatVirtualScrollNode<'ItemType>, 'ItemType>
    end