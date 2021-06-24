namespace rec Fun.Blazor.AntDesign.DslInternals

open Bolero.Html
open Fun.Blazor
open Fun.Blazor.Web.DslInternals
open Fun.Blazor.AntDesign.DslInternals


type antComponentBase<'FunBlazorGeneric> =
    
    static member inline create () = [] |> html.blazor<AntDesign.AntComponentBase>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.AntComponentBase>

    static member inline ref x = attr.ref x
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type configProvider<'FunBlazorGeneric> =
    inherit antComponentBase<'FunBlazorGeneric>
    static member inline create () = [] |> html.blazor<AntDesign.ConfigProvider>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.ConfigProvider>
    static member inline create (nodes: FunBlazorNode list) = nodes |> html.blazor<AntDesign.ConfigProvider>
    static member inline create (node: FunBlazorNode) = [ node ] |> html.blazor<AntDesign.ConfigProvider>
    static member inline ref x = attr.ref x
    static member inline direction (x: System.String) = "Direction" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type antDomComponentBase<'FunBlazorGeneric> =
    inherit antComponentBase<'FunBlazorGeneric>
    static member inline create () = [] |> html.blazor<AntDesign.AntDomComponentBase>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.AntDomComponentBase>

    static member inline ref x = attr.ref x
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type affix<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = [] |> html.blazor<AntDesign.Affix>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.Affix>
    static member inline create (nodes: FunBlazorNode list) = nodes |> html.blazor<AntDesign.Affix>
    static member inline create (node: FunBlazorNode) = [ node ] |> html.blazor<AntDesign.Affix>
    static member inline ref x = attr.ref x
    static member inline offsetBottom (x: System.Int32) = "OffsetBottom" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline offsetTop (x: System.Int32) = "OffsetTop" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline targetSelector (x: System.String) = "TargetSelector" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onChange fn = (Bolero.Html.attr.callback<System.Boolean> "OnChange" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type alert<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = [] |> html.blazor<AntDesign.Alert>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.Alert>
    static member inline create (nodes: FunBlazorNode list) = nodes |> html.blazor<AntDesign.Alert>
    static member inline create (node: FunBlazorNode) = [ node ] |> html.blazor<AntDesign.Alert>
    static member inline ref x = attr.ref x
    static member inline afterClose fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "AfterClose" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline banner (x: System.Boolean) = "Banner" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline closable (x: System.Boolean) = "Closable" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline closeText (x: System.String) = "CloseText" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline description (x: System.String) = "Description" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline icon (x: string) = Bolero.Html.attr.fragment "Icon" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline icon (node) = Bolero.Html.attr.fragment "Icon" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline icon (nodes) = Bolero.Html.attr.fragment "Icon" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline message (x: System.String) = "Message" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline messageTemplate (x: string) = Bolero.Html.attr.fragment "MessageTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline messageTemplate (node) = Bolero.Html.attr.fragment "MessageTemplate" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline messageTemplate (nodes) = Bolero.Html.attr.fragment "MessageTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline showIcon (x: System.Nullable<System.Boolean>) = "ShowIcon" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline type' (x: System.String) = "Type" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onClose fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnClose" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type anchor<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = [] |> html.blazor<AntDesign.Anchor>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.Anchor>
    static member inline create (nodes: FunBlazorNode list) = nodes |> html.blazor<AntDesign.Anchor>
    static member inline create (node: FunBlazorNode) = [ node ] |> html.blazor<AntDesign.Anchor>
    static member inline ref x = attr.ref x
    static member inline key (x: System.String) = "Key" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline affix (x: System.Boolean) = "Affix" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline bounds (x: System.Int32) = "Bounds" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline getContainer (x: System.Func<System.String>) = "GetContainer" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline offsetBottom (x: System.Nullable<System.Int32>) = "OffsetBottom" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline offsetTop (x: System.Nullable<System.Int32>) = "OffsetTop" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline showInkInFixed (x: System.Boolean) = "ShowInkInFixed" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onClick fn = (Bolero.Html.attr.callback<System.Tuple<Microsoft.AspNetCore.Components.Web.MouseEventArgs, AntDesign.AnchorLink>> "OnClick" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline getCurrentAnchor (x: System.Func<System.String>) = "GetCurrentAnchor" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline targetOffset (x: System.Nullable<System.Int32>) = "TargetOffset" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onChange fn = (Bolero.Html.attr.callback<System.String> "OnChange" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type anchorLink<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = [] |> html.blazor<AntDesign.AnchorLink>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.AnchorLink>
    static member inline create (nodes: FunBlazorNode list) = nodes |> html.blazor<AntDesign.AnchorLink>
    static member inline create (node: FunBlazorNode) = [ node ] |> html.blazor<AntDesign.AnchorLink>
    static member inline ref x = attr.ref x
    static member inline childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline href (x: System.String) = "Href" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline title (x: System.String) = "Title" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline target (x: System.String) = "Target" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type autoCompleteOptGroup<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = [] |> html.blazor<AntDesign.AutoCompleteOptGroup>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.AutoCompleteOptGroup>
    static member inline create (nodes: FunBlazorNode list) = nodes |> html.blazor<AntDesign.AutoCompleteOptGroup>
    static member inline create (node: FunBlazorNode) = [ node ] |> html.blazor<AntDesign.AutoCompleteOptGroup>
    static member inline ref x = attr.ref x
    static member inline label (x: System.String) = "Label" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline labelFragment (x: string) = Bolero.Html.attr.fragment "LabelFragment" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline labelFragment (node) = Bolero.Html.attr.fragment "LabelFragment" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline labelFragment (nodes) = Bolero.Html.attr.fragment "LabelFragment" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type autoCompleteOption<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = [] |> html.blazor<AntDesign.AutoCompleteOption>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.AutoCompleteOption>
    static member inline create (nodes: FunBlazorNode list) = nodes |> html.blazor<AntDesign.AutoCompleteOption>
    static member inline create (node: FunBlazorNode) = [ node ] |> html.blazor<AntDesign.AutoCompleteOption>
    static member inline ref x = attr.ref x
    static member inline childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline value (x: System.Object) = "Value" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline label (x: System.String) = "Label" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabled (x: System.Boolean) = "Disabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline autoComplete (x: AntDesign.IAutoCompleteRef) = "AutoComplete" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type avatar<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = [] |> html.blazor<AntDesign.Avatar>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.Avatar>
    static member inline create (nodes: FunBlazorNode list) = nodes |> html.blazor<AntDesign.Avatar>
    static member inline create (node: FunBlazorNode) = [ node ] |> html.blazor<AntDesign.Avatar>
    static member inline ref x = attr.ref x
    static member inline childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline shape (x: System.String) = "Shape" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline size (x: System.String) = "Size" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline text (x: System.String) = "Text" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline src (x: System.String) = "Src" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline srcSet (x: System.String) = "SrcSet" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline alt (x: System.String) = "Alt" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline icon (x: System.String) = "Icon" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onError fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.ErrorEventArgs> "OnError" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type avatarGroup<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = [] |> html.blazor<AntDesign.AvatarGroup>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.AvatarGroup>
    static member inline create (nodes: FunBlazorNode list) = nodes |> html.blazor<AntDesign.AvatarGroup>
    static member inline create (node: FunBlazorNode) = [ node ] |> html.blazor<AntDesign.AvatarGroup>
    static member inline ref x = attr.ref x
    static member inline childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline maxCount (x: System.Int32) = "MaxCount" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline maxStyle (x: System.String) = "MaxStyle" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline maxPopoverPlacement (x: AntDesign.PlacementType) = "MaxPopoverPlacement" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type backTop<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = [] |> html.blazor<AntDesign.BackTop>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.BackTop>
    static member inline create (nodes: FunBlazorNode list) = nodes |> html.blazor<AntDesign.BackTop>
    static member inline create (node: FunBlazorNode) = [ node ] |> html.blazor<AntDesign.BackTop>
    static member inline ref x = attr.ref x
    static member inline icon (x: System.String) = "Icon" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline visibilityHeight (x: System.Double) = "VisibilityHeight" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline targetSelector (x: System.String) = "TargetSelector" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onClick (x: Microsoft.AspNetCore.Components.EventCallback) = "OnClick" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type badge<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = [] |> html.blazor<AntDesign.Badge>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.Badge>
    static member inline create (nodes: FunBlazorNode list) = nodes |> html.blazor<AntDesign.Badge>
    static member inline create (node: FunBlazorNode) = [ node ] |> html.blazor<AntDesign.Badge>
    static member inline ref x = attr.ref x
    static member inline color (x: System.String) = "Color" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline count (x: System.Nullable<System.Int32>) = "Count" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline countTemplate (x: string) = Bolero.Html.attr.fragment "CountTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline countTemplate (node) = Bolero.Html.attr.fragment "CountTemplate" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline countTemplate (nodes) = Bolero.Html.attr.fragment "CountTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline dot (x: System.Boolean) = "Dot" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline offset (x: System.ValueTuple<System.Int32, System.Int32>) = "Offset" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline overflowCount (x: System.Int32) = "OverflowCount" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline showZero (x: System.Boolean) = "ShowZero" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline status (x: System.String) = "Status" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline text (x: System.String) = "Text" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline title (x: System.String) = "Title" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline size (x: System.String) = "Size" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type badgeRibbon<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = [] |> html.blazor<AntDesign.BadgeRibbon>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.BadgeRibbon>
    static member inline create (nodes: FunBlazorNode list) = nodes |> html.blazor<AntDesign.BadgeRibbon>
    static member inline create (node: FunBlazorNode) = [ node ] |> html.blazor<AntDesign.BadgeRibbon>
    static member inline ref x = attr.ref x
    static member inline color (x: System.String) = "Color" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline text (x: System.String) = "Text" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline textTemplate (x: string) = Bolero.Html.attr.fragment "TextTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline textTemplate (node) = Bolero.Html.attr.fragment "TextTemplate" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline textTemplate (nodes) = Bolero.Html.attr.fragment "TextTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline placement (x: System.String) = "Placement" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type breadcrumb<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = [] |> html.blazor<AntDesign.Breadcrumb>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.Breadcrumb>
    static member inline create (nodes: FunBlazorNode list) = nodes |> html.blazor<AntDesign.Breadcrumb>
    static member inline create (node: FunBlazorNode) = [ node ] |> html.blazor<AntDesign.Breadcrumb>
    static member inline ref x = attr.ref x
    static member inline childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline autoGenerate (x: System.Boolean) = "AutoGenerate" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline separator (x: System.String) = "Separator" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline routeLabel (x: System.String) = "RouteLabel" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type button<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = [] |> html.blazor<AntDesign.Button>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.Button>
    static member inline create (nodes: FunBlazorNode list) = nodes |> html.blazor<AntDesign.Button>
    static member inline create (node: FunBlazorNode) = [ node ] |> html.blazor<AntDesign.Button>
    static member inline ref x = attr.ref x
    static member inline block (x: System.Boolean) = "Block" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline danger (x: System.Boolean) = "Danger" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabled (x: System.Boolean) = "Disabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline ghost (x: System.Boolean) = "Ghost" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline htmlType (x: System.String) = "HtmlType" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline icon (x: System.String) = "Icon" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline loading (x: System.Boolean) = "Loading" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onClick fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnClick" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onClickStopPropagation (x: System.Boolean) = "OnClickStopPropagation" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline shape (x: System.String) = "Shape" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline size (x: System.String) = "Size" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline type' (x: System.String) = "Type" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type buttonGroup<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = [] |> html.blazor<AntDesign.ButtonGroup>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.ButtonGroup>
    static member inline create (nodes: FunBlazorNode list) = nodes |> html.blazor<AntDesign.ButtonGroup>
    static member inline create (node: FunBlazorNode) = [ node ] |> html.blazor<AntDesign.ButtonGroup>
    static member inline ref x = attr.ref x
    static member inline childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline size (x: System.String) = "Size" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type calendar<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = [] |> html.blazor<AntDesign.Calendar>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.Calendar>

    static member inline ref x = attr.ref x
    static member inline value (x: System.DateTime) = "Value" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline defaultValue (x: System.DateTime) = "DefaultValue" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline validRange (x: System.DateTime[]) = "ValidRange" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline mode (x: System.String) = "Mode" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline fullScreen (x: System.Boolean) = "FullScreen" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onSelect fn = (Bolero.Html.attr.callback<System.DateTime> "OnSelect" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onChange fn = (Bolero.Html.attr.callback<System.DateTime> "OnChange" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline headerRender (x: System.Func<AntDesign.CalendarHeaderRenderArgs, Microsoft.AspNetCore.Components.RenderFragment>) = "HeaderRender" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline dateCellRender (x: System.Func<System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "DateCellRender" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline dateFullCellRender (x: System.Func<System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "DateFullCellRender" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline monthCellRender (x: System.Func<System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "MonthCellRender" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline monthFullCellRender (x: System.Func<System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "MonthFullCellRender" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onPanelChange (x: System.Action<System.DateTime, System.String>) = "OnPanelChange" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabledDate (x: System.Func<System.DateTime, System.Boolean>) = "DisabledDate" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline locale (x: AntDesign.DatePickerLocale) = "Locale" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline cultureInfo (x: System.Globalization.CultureInfo) = "CultureInfo" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type card<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = [] |> html.blazor<AntDesign.Card>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.Card>
    static member inline create (nodes: FunBlazorNode list) = nodes |> html.blazor<AntDesign.Card>
    static member inline create (node: FunBlazorNode) = [ node ] |> html.blazor<AntDesign.Card>
    static member inline ref x = attr.ref x
    static member inline childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline body (x: string) = Bolero.Html.attr.fragment "Body" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline body (node) = Bolero.Html.attr.fragment "Body" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline body (nodes) = Bolero.Html.attr.fragment "Body" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline actionTemplate (x: string) = Bolero.Html.attr.fragment "ActionTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline actionTemplate (node) = Bolero.Html.attr.fragment "ActionTemplate" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline actionTemplate (nodes) = Bolero.Html.attr.fragment "ActionTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline bordered (x: System.Boolean) = "Bordered" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline hoverable (x: System.Boolean) = "Hoverable" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline loading (x: System.Boolean) = "Loading" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline bodyStyle (x: System.String) = "BodyStyle" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline cover (x: string) = Bolero.Html.attr.fragment "Cover" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline cover (node) = Bolero.Html.attr.fragment "Cover" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline cover (nodes) = Bolero.Html.attr.fragment "Cover" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline actions (x: System.Collections.Generic.IList<Microsoft.AspNetCore.Components.RenderFragment>) = "Actions" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline type' (x: System.String) = "Type" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline size (x: System.String) = "Size" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline title (x: System.String) = "Title" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline titleTemplate (x: string) = Bolero.Html.attr.fragment "TitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline titleTemplate (node) = Bolero.Html.attr.fragment "TitleTemplate" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline titleTemplate (nodes) = Bolero.Html.attr.fragment "TitleTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline extra (x: string) = Bolero.Html.attr.fragment "Extra" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline extra (node) = Bolero.Html.attr.fragment "Extra" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline extra (nodes) = Bolero.Html.attr.fragment "Extra" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline cardTabs (x: string) = Bolero.Html.attr.fragment "CardTabs" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline cardTabs (node) = Bolero.Html.attr.fragment "CardTabs" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline cardTabs (nodes) = Bolero.Html.attr.fragment "CardTabs" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type cardAction<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = [] |> html.blazor<AntDesign.CardAction>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.CardAction>
    static member inline create (nodes: FunBlazorNode list) = nodes |> html.blazor<AntDesign.CardAction>
    static member inline create (node: FunBlazorNode) = [ node ] |> html.blazor<AntDesign.CardAction>
    static member inline ref x = attr.ref x
    static member inline childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type cardGrid<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = [] |> html.blazor<AntDesign.CardGrid>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.CardGrid>
    static member inline create (nodes: FunBlazorNode list) = nodes |> html.blazor<AntDesign.CardGrid>
    static member inline create (node: FunBlazorNode) = [ node ] |> html.blazor<AntDesign.CardGrid>
    static member inline ref x = attr.ref x
    static member inline childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline hoverable (x: System.Boolean) = "Hoverable" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type carousel<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = [] |> html.blazor<AntDesign.Carousel>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.Carousel>
    static member inline create (nodes: FunBlazorNode list) = nodes |> html.blazor<AntDesign.Carousel>
    static member inline create (node: FunBlazorNode) = [ node ] |> html.blazor<AntDesign.Carousel>
    static member inline ref x = attr.ref x
    static member inline childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline dotPosition (x: System.String) = "DotPosition" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline autoplay (x: System.TimeSpan) = "Autoplay" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline effect (x: System.String) = "Effect" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type carouselSlick<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = [] |> html.blazor<AntDesign.CarouselSlick>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.CarouselSlick>
    static member inline create (nodes: FunBlazorNode list) = nodes |> html.blazor<AntDesign.CarouselSlick>
    static member inline create (node: FunBlazorNode) = [ node ] |> html.blazor<AntDesign.CarouselSlick>
    static member inline ref x = attr.ref x
    static member inline childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type collapse<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = [] |> html.blazor<AntDesign.Collapse>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.Collapse>
    static member inline create (nodes: FunBlazorNode list) = nodes |> html.blazor<AntDesign.Collapse>
    static member inline create (node: FunBlazorNode) = [ node ] |> html.blazor<AntDesign.Collapse>
    static member inline ref x = attr.ref x
    static member inline accordion (x: System.Boolean) = "Accordion" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline bordered (x: System.Boolean) = "Bordered" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline expandIconPosition (x: System.String) = "ExpandIconPosition" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline defaultActiveKey (x: System.String[]) = "DefaultActiveKey" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onChange fn = (Bolero.Html.attr.callback<System.String[]> "OnChange" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline expandIcon (x: System.String) = "ExpandIcon" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline expandIconTemplate (render: System.Boolean -> FunBlazorNode) = Bolero.Html.attr.fragmentWith "ExpandIconTemplate" (fun x -> render x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type panel<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = [] |> html.blazor<AntDesign.Panel>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.Panel>
    static member inline create (nodes: FunBlazorNode list) = nodes |> html.blazor<AntDesign.Panel>
    static member inline create (node: FunBlazorNode) = [ node ] |> html.blazor<AntDesign.Panel>
    static member inline ref x = attr.ref x
    static member inline active (x: System.Boolean) = "Active" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline key (x: System.String) = "Key" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabled (x: System.Boolean) = "Disabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline showArrow (x: System.Boolean) = "ShowArrow" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline extra (x: System.String) = "Extra" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline extraTemplate (x: string) = Bolero.Html.attr.fragment "ExtraTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline extraTemplate (node) = Bolero.Html.attr.fragment "ExtraTemplate" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline extraTemplate (nodes) = Bolero.Html.attr.fragment "ExtraTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline header (x: System.String) = "Header" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline headerTemplate (x: string) = Bolero.Html.attr.fragment "HeaderTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline headerTemplate (node) = Bolero.Html.attr.fragment "HeaderTemplate" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline headerTemplate (nodes) = Bolero.Html.attr.fragment "HeaderTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onActiveChange fn = (Bolero.Html.attr.callback<System.Boolean> "OnActiveChange" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type comment<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = [] |> html.blazor<AntDesign.Comment>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.Comment>
    static member inline create (nodes: FunBlazorNode list) = nodes |> html.blazor<AntDesign.Comment>
    static member inline create (node: FunBlazorNode) = [ node ] |> html.blazor<AntDesign.Comment>
    static member inline ref x = attr.ref x
    static member inline author (x: System.String) = "Author" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline authorTemplate (x: string) = Bolero.Html.attr.fragment "AuthorTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline authorTemplate (node) = Bolero.Html.attr.fragment "AuthorTemplate" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline authorTemplate (nodes) = Bolero.Html.attr.fragment "AuthorTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline avatar (x: System.String) = "Avatar" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline avatarTemplate (x: string) = Bolero.Html.attr.fragment "AvatarTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline avatarTemplate (node) = Bolero.Html.attr.fragment "AvatarTemplate" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline avatarTemplate (nodes) = Bolero.Html.attr.fragment "AvatarTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline content (x: System.String) = "Content" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline contentTemplate (x: string) = Bolero.Html.attr.fragment "ContentTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline contentTemplate (node) = Bolero.Html.attr.fragment "ContentTemplate" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline contentTemplate (nodes) = Bolero.Html.attr.fragment "ContentTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline datetime (x: System.String) = "Datetime" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline datetimeTemplate (x: string) = Bolero.Html.attr.fragment "DatetimeTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline datetimeTemplate (node) = Bolero.Html.attr.fragment "DatetimeTemplate" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline datetimeTemplate (nodes) = Bolero.Html.attr.fragment "DatetimeTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline actions (x: System.Collections.Generic.IList<Microsoft.AspNetCore.Components.RenderFragment>) = "Actions" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type antContainerComponentBase<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = [] |> html.blazor<AntDesign.AntContainerComponentBase>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.AntContainerComponentBase>
    static member inline create (nodes: FunBlazorNode list) = nodes |> html.blazor<AntDesign.AntContainerComponentBase>
    static member inline create (node: FunBlazorNode) = [ node ] |> html.blazor<AntDesign.AntContainerComponentBase>
    static member inline ref x = attr.ref x
    static member inline childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline tag (x: System.String) = "Tag" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type antInputComponentBase<'FunBlazorGeneric, 'TValue> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = [] |> html.blazor<AntDesign.AntInputComponentBase<'TValue>>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.AntInputComponentBase<'TValue>>

    static member inline ref x = attr.ref x
    static member inline additionalAttributes (x: System.Collections.Generic.IReadOnlyDictionary<System.String, System.Object>) = "AdditionalAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline value (x: 'TValue) = "Value" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valueChanged fn = (Bolero.Html.attr.callback<'TValue> "ValueChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valueExpression (x: System.Linq.Expressions.Expression<System.Func<'TValue>>) = "ValueExpression" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valuesExpression (x: System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.IEnumerable<'TValue>>>) = "ValuesExpression" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline size (x: System.String) = "Size" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline cultureInfo (x: System.Globalization.CultureInfo) = "CultureInfo" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type autoComplete<'FunBlazorGeneric, 'TOption> =
    inherit antInputComponentBase<'FunBlazorGeneric, System.String>
    static member inline create () = [] |> html.blazor<AntDesign.AutoComplete<'TOption>>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.AutoComplete<'TOption>>
    static member inline create (nodes: FunBlazorNode list) = nodes |> html.blazor<AntDesign.AutoComplete<'TOption>>
    static member inline create (node: FunBlazorNode) = [ node ] |> html.blazor<AntDesign.AutoComplete<'TOption>>
    static member inline ref x = attr.ref x
    static member inline placeholder (x: System.String) = "Placeholder" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabled (x: System.Boolean) = "Disabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline defaultActiveFirstOption (x: System.Boolean) = "DefaultActiveFirstOption" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline backfill (x: System.Boolean) = "Backfill" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline options (x: System.Collections.Generic.IEnumerable<'TOption>) = "Options" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline optionDataItems (x: System.Collections.Generic.IEnumerable<AntDesign.AutoCompleteDataItem<'TOption>>) = "OptionDataItems" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onSelectionChange fn = (Bolero.Html.attr.callback<AntDesign.AutoCompleteOption> "OnSelectionChange" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onActiveChange fn = (Bolero.Html.attr.callback<AntDesign.AutoCompleteOption> "OnActiveChange" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onInput fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.ChangeEventArgs> "OnInput" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onPanelVisibleChange fn = (Bolero.Html.attr.callback<System.Boolean> "OnPanelVisibleChange" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline optionTemplate (render: AntDesign.AutoCompleteDataItem<'TOption> -> FunBlazorNode) = Bolero.Html.attr.fragmentWith "OptionTemplate" (fun x -> render x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline optionFormat (x: System.Func<AntDesign.AutoCompleteDataItem<'TOption>, System.String>) = "OptionFormat" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline overlayTemplate (x: string) = Bolero.Html.attr.fragment "OverlayTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline overlayTemplate (node) = Bolero.Html.attr.fragment "OverlayTemplate" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline overlayTemplate (nodes) = Bolero.Html.attr.fragment "OverlayTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline compareWith (x: System.Func<System.Object, System.Object, System.Boolean>) = "CompareWith" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline filterExpression (x: System.Func<AntDesign.AutoCompleteDataItem<'TOption>, System.String, System.Boolean>) = "FilterExpression" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline allowFilter (x: System.Boolean) = "AllowFilter" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline width (x: OneOf.OneOf<System.Nullable<System.Int32>, System.String>) = "Width" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline overlayClassName (x: System.String) = "OverlayClassName" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline overlayStyle (x: System.String) = "OverlayStyle" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline popupContainerSelector (x: System.String) = "PopupContainerSelector" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline selectedItem (x: AntDesign.AutoCompleteOption) = "SelectedItem" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline showPanel (x: System.Boolean) = "ShowPanel" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline additionalAttributes (x: System.Collections.Generic.IReadOnlyDictionary<System.String, System.Object>) = "AdditionalAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline value (x: System.String) = "Value" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valueChanged fn = (Bolero.Html.attr.callback<System.String> "ValueChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valueExpression (x: System.Linq.Expressions.Expression<System.Func<System.String>>) = "ValueExpression" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valuesExpression (x: System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.IEnumerable<System.String>>>) = "ValuesExpression" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline size (x: System.String) = "Size" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline cultureInfo (x: System.Globalization.CultureInfo) = "CultureInfo" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type cascader<'FunBlazorGeneric> =
    inherit antInputComponentBase<'FunBlazorGeneric, System.String>
    static member inline create () = [] |> html.blazor<AntDesign.Cascader>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.Cascader>

    static member inline ref x = attr.ref x
    static member inline allowClear (x: System.Boolean) = "AllowClear" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline changeOnSelect (x: System.Boolean) = "ChangeOnSelect" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline defaultValue (x: System.String) = "DefaultValue" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline expandTrigger (x: System.String) = "ExpandTrigger" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline notFoundContent (x: System.String) = "NotFoundContent" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline placeholder (x: System.String) = "Placeholder" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline popupContainerSelector (x: System.String) = "PopupContainerSelector" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline showSearch (x: System.Boolean) = "ShowSearch" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onChange (x: System.Action<System.Collections.Generic.List<AntDesign.CascaderNode>, System.String, System.String>) = "OnChange" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline selectedNodesChanged fn = (Bolero.Html.attr.callback<AntDesign.CascaderNode[]> "SelectedNodesChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline options (x: System.Collections.Generic.IEnumerable<AntDesign.CascaderNode>) = "Options" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline additionalAttributes (x: System.Collections.Generic.IReadOnlyDictionary<System.String, System.Object>) = "AdditionalAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline value (x: System.String) = "Value" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valueChanged fn = (Bolero.Html.attr.callback<System.String> "ValueChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valueExpression (x: System.Linq.Expressions.Expression<System.Func<System.String>>) = "ValueExpression" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valuesExpression (x: System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.IEnumerable<System.String>>>) = "ValuesExpression" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline size (x: System.String) = "Size" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline cultureInfo (x: System.Globalization.CultureInfo) = "CultureInfo" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type checkboxGroup<'FunBlazorGeneric> =
    inherit antInputComponentBase<'FunBlazorGeneric, System.String[]>
    static member inline create () = [] |> html.blazor<AntDesign.CheckboxGroup>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.CheckboxGroup>
    static member inline create (nodes: FunBlazorNode list) = nodes |> html.blazor<AntDesign.CheckboxGroup>
    static member inline create (node: FunBlazorNode) = [ node ] |> html.blazor<AntDesign.CheckboxGroup>
    static member inline ref x = attr.ref x
    static member inline childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline options (x: OneOf.OneOf<AntDesign.CheckboxOption[], System.String[]>) = "Options" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline mixedMode (x: AntDesign.CheckboxGroupMixedMode) = "MixedMode" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onChange fn = (Bolero.Html.attr.callback<System.String[]> "OnChange" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabled (x: System.Boolean) = "Disabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline additionalAttributes (x: System.Collections.Generic.IReadOnlyDictionary<System.String, System.Object>) = "AdditionalAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline value (x: System.String[]) = "Value" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valueChanged fn = (Bolero.Html.attr.callback<System.String[]> "ValueChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valueExpression (x: System.Linq.Expressions.Expression<System.Func<System.String[]>>) = "ValueExpression" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valuesExpression (x: System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.IEnumerable<System.String[]>>>) = "ValuesExpression" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline size (x: System.String) = "Size" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline cultureInfo (x: System.Globalization.CultureInfo) = "CultureInfo" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type antInputBoolComponentBase<'FunBlazorGeneric> =
    inherit antInputComponentBase<'FunBlazorGeneric, System.Boolean>
    static member inline create () = [] |> html.blazor<AntDesign.AntInputBoolComponentBase>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.AntInputBoolComponentBase>

    static member inline ref x = attr.ref x
    static member inline autoFocus (x: System.Boolean) = "AutoFocus" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline checked' (x: System.Boolean) = "Checked" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onChange fn = (Bolero.Html.attr.callback<System.Boolean> "OnChange" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline checkedChanged fn = (Bolero.Html.attr.callback<System.Boolean> "CheckedChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabled (x: System.Boolean) = "Disabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline additionalAttributes (x: System.Collections.Generic.IReadOnlyDictionary<System.String, System.Object>) = "AdditionalAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline value (x: System.Boolean) = "Value" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valueChanged fn = (Bolero.Html.attr.callback<System.Boolean> "ValueChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valueExpression (x: System.Linq.Expressions.Expression<System.Func<System.Boolean>>) = "ValueExpression" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valuesExpression (x: System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.IEnumerable<System.Boolean>>>) = "ValuesExpression" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline size (x: System.String) = "Size" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline cultureInfo (x: System.Globalization.CultureInfo) = "CultureInfo" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type checkbox<'FunBlazorGeneric> =
    inherit antInputBoolComponentBase<'FunBlazorGeneric>
    static member inline create () = [] |> html.blazor<AntDesign.Checkbox>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.Checkbox>
    static member inline create (nodes: FunBlazorNode list) = nodes |> html.blazor<AntDesign.Checkbox>
    static member inline create (node: FunBlazorNode) = [ node ] |> html.blazor<AntDesign.Checkbox>
    static member inline ref x = attr.ref x
    static member inline childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline checkedChange fn = (Bolero.Html.attr.callback<System.Boolean> "CheckedChange" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline checkedExpression (x: System.Linq.Expressions.Expression<System.Func<System.Boolean>>) = "CheckedExpression" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline indeterminate (x: System.Boolean) = "Indeterminate" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline label (x: System.String) = "Label" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline autoFocus (x: System.Boolean) = "AutoFocus" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline checked' (x: System.Boolean) = "Checked" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onChange fn = (Bolero.Html.attr.callback<System.Boolean> "OnChange" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline checkedChanged fn = (Bolero.Html.attr.callback<System.Boolean> "CheckedChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabled (x: System.Boolean) = "Disabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline additionalAttributes (x: System.Collections.Generic.IReadOnlyDictionary<System.String, System.Object>) = "AdditionalAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline value (x: System.Boolean) = "Value" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valueChanged fn = (Bolero.Html.attr.callback<System.Boolean> "ValueChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valueExpression (x: System.Linq.Expressions.Expression<System.Func<System.Boolean>>) = "ValueExpression" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valuesExpression (x: System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.IEnumerable<System.Boolean>>>) = "ValuesExpression" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline size (x: System.String) = "Size" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline cultureInfo (x: System.Globalization.CultureInfo) = "CultureInfo" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type switch<'FunBlazorGeneric> =
    inherit antInputBoolComponentBase<'FunBlazorGeneric>
    static member inline create () = [] |> html.blazor<AntDesign.Switch>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.Switch>

    static member inline ref x = attr.ref x
    static member inline loading (x: System.Boolean) = "Loading" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline checkedChildren (x: System.String) = "CheckedChildren" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline checkedChildrenTemplate (x: string) = Bolero.Html.attr.fragment "CheckedChildrenTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline checkedChildrenTemplate (node) = Bolero.Html.attr.fragment "CheckedChildrenTemplate" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline checkedChildrenTemplate (nodes) = Bolero.Html.attr.fragment "CheckedChildrenTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline control (x: System.Boolean) = "Control" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onClick (x: Microsoft.AspNetCore.Components.EventCallback) = "OnClick" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline unCheckedChildren (x: System.String) = "UnCheckedChildren" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline unCheckedChildrenTemplate (x: string) = Bolero.Html.attr.fragment "UnCheckedChildrenTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline unCheckedChildrenTemplate (node) = Bolero.Html.attr.fragment "UnCheckedChildrenTemplate" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline unCheckedChildrenTemplate (nodes) = Bolero.Html.attr.fragment "UnCheckedChildrenTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline autoFocus (x: System.Boolean) = "AutoFocus" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline checked' (x: System.Boolean) = "Checked" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onChange fn = (Bolero.Html.attr.callback<System.Boolean> "OnChange" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline checkedChanged fn = (Bolero.Html.attr.callback<System.Boolean> "CheckedChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabled (x: System.Boolean) = "Disabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline additionalAttributes (x: System.Collections.Generic.IReadOnlyDictionary<System.String, System.Object>) = "AdditionalAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline value (x: System.Boolean) = "Value" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valueChanged fn = (Bolero.Html.attr.callback<System.Boolean> "ValueChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valueExpression (x: System.Linq.Expressions.Expression<System.Func<System.Boolean>>) = "ValueExpression" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valuesExpression (x: System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.IEnumerable<System.Boolean>>>) = "ValuesExpression" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline size (x: System.String) = "Size" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline cultureInfo (x: System.Globalization.CultureInfo) = "CultureInfo" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type datePickerBase<'FunBlazorGeneric, 'TValue> =
    inherit antInputComponentBase<'FunBlazorGeneric, 'TValue>
    static member inline create () = [] |> html.blazor<AntDesign.DatePickerBase<'TValue>>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.DatePickerBase<'TValue>>

    static member inline ref x = attr.ref x
    static member inline prefixCls (x: System.String) = "PrefixCls" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline picker (x: System.String) = "Picker" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline popupContainerSelector (x: System.String) = "PopupContainerSelector" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabled (x: System.Boolean) = "Disabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline bordered (x: System.Boolean) = "Bordered" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline autoFocus (x: System.Boolean) = "AutoFocus" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline open' (x: System.Boolean) = "Open" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline inputReadOnly (x: System.Boolean) = "InputReadOnly" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline showToday (x: System.Boolean) = "ShowToday" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline locale (x: AntDesign.DatePickerLocale) = "Locale" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline cultureInfo (x: System.Globalization.CultureInfo) = "CultureInfo" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline showTime (x: OneOf.OneOf<System.Boolean, System.String>) = "ShowTime" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline allowClear (x: System.Boolean) = "AllowClear" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline placeholder (x: OneOf.OneOf<System.String, System.String[]>) = "Placeholder" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline popupStyle (x: System.String) = "PopupStyle" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline className (x: System.String) = "ClassName" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline dropdownClassName (x: System.String) = "DropdownClassName" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline format (x: System.String) = "Format" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline defaultValue (x: 'TValue) = "DefaultValue" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline defaultPickerValue (x: 'TValue) = "DefaultPickerValue" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline suffixIcon (x: string) = Bolero.Html.attr.fragment "SuffixIcon" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline suffixIcon (node) = Bolero.Html.attr.fragment "SuffixIcon" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline suffixIcon (nodes) = Bolero.Html.attr.fragment "SuffixIcon" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline renderExtraFooter (x: string) = Bolero.Html.attr.fragment "RenderExtraFooter" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline renderExtraFooter (node) = Bolero.Html.attr.fragment "RenderExtraFooter" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline renderExtraFooter (nodes) = Bolero.Html.attr.fragment "RenderExtraFooter" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onClearClick (x: Microsoft.AspNetCore.Components.EventCallback) = "OnClearClick" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onOpenChange fn = (Bolero.Html.attr.callback<System.Boolean> "OnOpenChange" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onPanelChange fn = (Bolero.Html.attr.callback<AntDesign.DateTimeChangedEventArgs> "OnPanelChange" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabledDate (x: System.Func<System.DateTime, System.Boolean>) = "DisabledDate" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabledHours (x: System.Func<System.DateTime, System.Int32[]>) = "DisabledHours" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabledMinutes (x: System.Func<System.DateTime, System.Int32[]>) = "DisabledMinutes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabledSeconds (x: System.Func<System.DateTime, System.Int32[]>) = "DisabledSeconds" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabledTime (x: System.Func<System.DateTime, AntDesign.DatePickerDisabledTime>) = "DisabledTime" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline dateRender (x: System.Func<System.DateTime, System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "DateRender" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline monthCellRender (x: System.Func<System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "MonthCellRender" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline additionalAttributes (x: System.Collections.Generic.IReadOnlyDictionary<System.String, System.Object>) = "AdditionalAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline value (x: 'TValue) = "Value" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valueChanged fn = (Bolero.Html.attr.callback<'TValue> "ValueChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valueExpression (x: System.Linq.Expressions.Expression<System.Func<'TValue>>) = "ValueExpression" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valuesExpression (x: System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.IEnumerable<'TValue>>>) = "ValuesExpression" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline size (x: System.String) = "Size" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type datePicker<'FunBlazorGeneric, 'TValue> =
    inherit datePickerBase<'FunBlazorGeneric, 'TValue>
    static member inline create () = [] |> html.blazor<AntDesign.DatePicker<'TValue>>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.DatePicker<'TValue>>

    static member inline ref x = attr.ref x
    static member inline onChange fn = (Bolero.Html.attr.callback<AntDesign.DateTimeChangedEventArgs> "OnChange" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline prefixCls (x: System.String) = "PrefixCls" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline picker (x: System.String) = "Picker" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline popupContainerSelector (x: System.String) = "PopupContainerSelector" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabled (x: System.Boolean) = "Disabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline bordered (x: System.Boolean) = "Bordered" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline autoFocus (x: System.Boolean) = "AutoFocus" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline open' (x: System.Boolean) = "Open" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline inputReadOnly (x: System.Boolean) = "InputReadOnly" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline showToday (x: System.Boolean) = "ShowToday" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline locale (x: AntDesign.DatePickerLocale) = "Locale" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline cultureInfo (x: System.Globalization.CultureInfo) = "CultureInfo" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline showTime (x: OneOf.OneOf<System.Boolean, System.String>) = "ShowTime" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline allowClear (x: System.Boolean) = "AllowClear" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline placeholder (x: OneOf.OneOf<System.String, System.String[]>) = "Placeholder" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline popupStyle (x: System.String) = "PopupStyle" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline className (x: System.String) = "ClassName" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline dropdownClassName (x: System.String) = "DropdownClassName" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline format (x: System.String) = "Format" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline defaultValue (x: 'TValue) = "DefaultValue" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline defaultPickerValue (x: 'TValue) = "DefaultPickerValue" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline suffixIcon (x: string) = Bolero.Html.attr.fragment "SuffixIcon" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline suffixIcon (node) = Bolero.Html.attr.fragment "SuffixIcon" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline suffixIcon (nodes) = Bolero.Html.attr.fragment "SuffixIcon" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline renderExtraFooter (x: string) = Bolero.Html.attr.fragment "RenderExtraFooter" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline renderExtraFooter (node) = Bolero.Html.attr.fragment "RenderExtraFooter" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline renderExtraFooter (nodes) = Bolero.Html.attr.fragment "RenderExtraFooter" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onClearClick (x: Microsoft.AspNetCore.Components.EventCallback) = "OnClearClick" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onOpenChange fn = (Bolero.Html.attr.callback<System.Boolean> "OnOpenChange" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onPanelChange fn = (Bolero.Html.attr.callback<AntDesign.DateTimeChangedEventArgs> "OnPanelChange" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabledDate (x: System.Func<System.DateTime, System.Boolean>) = "DisabledDate" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabledHours (x: System.Func<System.DateTime, System.Int32[]>) = "DisabledHours" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabledMinutes (x: System.Func<System.DateTime, System.Int32[]>) = "DisabledMinutes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabledSeconds (x: System.Func<System.DateTime, System.Int32[]>) = "DisabledSeconds" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabledTime (x: System.Func<System.DateTime, AntDesign.DatePickerDisabledTime>) = "DisabledTime" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline dateRender (x: System.Func<System.DateTime, System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "DateRender" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline monthCellRender (x: System.Func<System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "MonthCellRender" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline additionalAttributes (x: System.Collections.Generic.IReadOnlyDictionary<System.String, System.Object>) = "AdditionalAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline value (x: 'TValue) = "Value" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valueChanged fn = (Bolero.Html.attr.callback<'TValue> "ValueChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valueExpression (x: System.Linq.Expressions.Expression<System.Func<'TValue>>) = "ValueExpression" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valuesExpression (x: System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.IEnumerable<'TValue>>>) = "ValuesExpression" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline size (x: System.String) = "Size" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type monthPicker<'FunBlazorGeneric, 'TValue> =
    inherit datePicker<'FunBlazorGeneric, 'TValue>
    static member inline create () = [] |> html.blazor<AntDesign.MonthPicker<'TValue>>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.MonthPicker<'TValue>>

    static member inline ref x = attr.ref x
    static member inline onChange fn = (Bolero.Html.attr.callback<AntDesign.DateTimeChangedEventArgs> "OnChange" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline prefixCls (x: System.String) = "PrefixCls" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline picker (x: System.String) = "Picker" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline popupContainerSelector (x: System.String) = "PopupContainerSelector" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabled (x: System.Boolean) = "Disabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline bordered (x: System.Boolean) = "Bordered" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline autoFocus (x: System.Boolean) = "AutoFocus" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline open' (x: System.Boolean) = "Open" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline inputReadOnly (x: System.Boolean) = "InputReadOnly" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline showToday (x: System.Boolean) = "ShowToday" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline locale (x: AntDesign.DatePickerLocale) = "Locale" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline cultureInfo (x: System.Globalization.CultureInfo) = "CultureInfo" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline showTime (x: OneOf.OneOf<System.Boolean, System.String>) = "ShowTime" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline allowClear (x: System.Boolean) = "AllowClear" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline placeholder (x: OneOf.OneOf<System.String, System.String[]>) = "Placeholder" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline popupStyle (x: System.String) = "PopupStyle" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline className (x: System.String) = "ClassName" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline dropdownClassName (x: System.String) = "DropdownClassName" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline format (x: System.String) = "Format" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline defaultValue (x: 'TValue) = "DefaultValue" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline defaultPickerValue (x: 'TValue) = "DefaultPickerValue" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline suffixIcon (x: string) = Bolero.Html.attr.fragment "SuffixIcon" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline suffixIcon (node) = Bolero.Html.attr.fragment "SuffixIcon" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline suffixIcon (nodes) = Bolero.Html.attr.fragment "SuffixIcon" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline renderExtraFooter (x: string) = Bolero.Html.attr.fragment "RenderExtraFooter" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline renderExtraFooter (node) = Bolero.Html.attr.fragment "RenderExtraFooter" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline renderExtraFooter (nodes) = Bolero.Html.attr.fragment "RenderExtraFooter" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onClearClick (x: Microsoft.AspNetCore.Components.EventCallback) = "OnClearClick" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onOpenChange fn = (Bolero.Html.attr.callback<System.Boolean> "OnOpenChange" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onPanelChange fn = (Bolero.Html.attr.callback<AntDesign.DateTimeChangedEventArgs> "OnPanelChange" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabledDate (x: System.Func<System.DateTime, System.Boolean>) = "DisabledDate" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabledHours (x: System.Func<System.DateTime, System.Int32[]>) = "DisabledHours" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabledMinutes (x: System.Func<System.DateTime, System.Int32[]>) = "DisabledMinutes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabledSeconds (x: System.Func<System.DateTime, System.Int32[]>) = "DisabledSeconds" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabledTime (x: System.Func<System.DateTime, AntDesign.DatePickerDisabledTime>) = "DisabledTime" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline dateRender (x: System.Func<System.DateTime, System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "DateRender" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline monthCellRender (x: System.Func<System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "MonthCellRender" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline additionalAttributes (x: System.Collections.Generic.IReadOnlyDictionary<System.String, System.Object>) = "AdditionalAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline value (x: 'TValue) = "Value" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valueChanged fn = (Bolero.Html.attr.callback<'TValue> "ValueChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valueExpression (x: System.Linq.Expressions.Expression<System.Func<'TValue>>) = "ValueExpression" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valuesExpression (x: System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.IEnumerable<'TValue>>>) = "ValuesExpression" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline size (x: System.String) = "Size" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type quarterPicker<'FunBlazorGeneric, 'TValue> =
    inherit datePicker<'FunBlazorGeneric, 'TValue>
    static member inline create () = [] |> html.blazor<AntDesign.QuarterPicker<'TValue>>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.QuarterPicker<'TValue>>

    static member inline ref x = attr.ref x
    static member inline onChange fn = (Bolero.Html.attr.callback<AntDesign.DateTimeChangedEventArgs> "OnChange" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline prefixCls (x: System.String) = "PrefixCls" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline picker (x: System.String) = "Picker" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline popupContainerSelector (x: System.String) = "PopupContainerSelector" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabled (x: System.Boolean) = "Disabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline bordered (x: System.Boolean) = "Bordered" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline autoFocus (x: System.Boolean) = "AutoFocus" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline open' (x: System.Boolean) = "Open" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline inputReadOnly (x: System.Boolean) = "InputReadOnly" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline showToday (x: System.Boolean) = "ShowToday" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline locale (x: AntDesign.DatePickerLocale) = "Locale" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline cultureInfo (x: System.Globalization.CultureInfo) = "CultureInfo" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline showTime (x: OneOf.OneOf<System.Boolean, System.String>) = "ShowTime" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline allowClear (x: System.Boolean) = "AllowClear" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline placeholder (x: OneOf.OneOf<System.String, System.String[]>) = "Placeholder" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline popupStyle (x: System.String) = "PopupStyle" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline className (x: System.String) = "ClassName" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline dropdownClassName (x: System.String) = "DropdownClassName" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline format (x: System.String) = "Format" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline defaultValue (x: 'TValue) = "DefaultValue" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline defaultPickerValue (x: 'TValue) = "DefaultPickerValue" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline suffixIcon (x: string) = Bolero.Html.attr.fragment "SuffixIcon" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline suffixIcon (node) = Bolero.Html.attr.fragment "SuffixIcon" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline suffixIcon (nodes) = Bolero.Html.attr.fragment "SuffixIcon" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline renderExtraFooter (x: string) = Bolero.Html.attr.fragment "RenderExtraFooter" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline renderExtraFooter (node) = Bolero.Html.attr.fragment "RenderExtraFooter" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline renderExtraFooter (nodes) = Bolero.Html.attr.fragment "RenderExtraFooter" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onClearClick (x: Microsoft.AspNetCore.Components.EventCallback) = "OnClearClick" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onOpenChange fn = (Bolero.Html.attr.callback<System.Boolean> "OnOpenChange" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onPanelChange fn = (Bolero.Html.attr.callback<AntDesign.DateTimeChangedEventArgs> "OnPanelChange" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabledDate (x: System.Func<System.DateTime, System.Boolean>) = "DisabledDate" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabledHours (x: System.Func<System.DateTime, System.Int32[]>) = "DisabledHours" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabledMinutes (x: System.Func<System.DateTime, System.Int32[]>) = "DisabledMinutes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabledSeconds (x: System.Func<System.DateTime, System.Int32[]>) = "DisabledSeconds" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabledTime (x: System.Func<System.DateTime, AntDesign.DatePickerDisabledTime>) = "DisabledTime" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline dateRender (x: System.Func<System.DateTime, System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "DateRender" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline monthCellRender (x: System.Func<System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "MonthCellRender" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline additionalAttributes (x: System.Collections.Generic.IReadOnlyDictionary<System.String, System.Object>) = "AdditionalAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline value (x: 'TValue) = "Value" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valueChanged fn = (Bolero.Html.attr.callback<'TValue> "ValueChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valueExpression (x: System.Linq.Expressions.Expression<System.Func<'TValue>>) = "ValueExpression" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valuesExpression (x: System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.IEnumerable<'TValue>>>) = "ValuesExpression" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline size (x: System.String) = "Size" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type weekPicker<'FunBlazorGeneric, 'TValue> =
    inherit datePicker<'FunBlazorGeneric, 'TValue>
    static member inline create () = [] |> html.blazor<AntDesign.WeekPicker<'TValue>>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.WeekPicker<'TValue>>

    static member inline ref x = attr.ref x
    static member inline onChange fn = (Bolero.Html.attr.callback<AntDesign.DateTimeChangedEventArgs> "OnChange" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline prefixCls (x: System.String) = "PrefixCls" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline picker (x: System.String) = "Picker" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline popupContainerSelector (x: System.String) = "PopupContainerSelector" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabled (x: System.Boolean) = "Disabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline bordered (x: System.Boolean) = "Bordered" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline autoFocus (x: System.Boolean) = "AutoFocus" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline open' (x: System.Boolean) = "Open" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline inputReadOnly (x: System.Boolean) = "InputReadOnly" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline showToday (x: System.Boolean) = "ShowToday" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline locale (x: AntDesign.DatePickerLocale) = "Locale" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline cultureInfo (x: System.Globalization.CultureInfo) = "CultureInfo" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline showTime (x: OneOf.OneOf<System.Boolean, System.String>) = "ShowTime" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline allowClear (x: System.Boolean) = "AllowClear" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline placeholder (x: OneOf.OneOf<System.String, System.String[]>) = "Placeholder" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline popupStyle (x: System.String) = "PopupStyle" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline className (x: System.String) = "ClassName" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline dropdownClassName (x: System.String) = "DropdownClassName" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline format (x: System.String) = "Format" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline defaultValue (x: 'TValue) = "DefaultValue" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline defaultPickerValue (x: 'TValue) = "DefaultPickerValue" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline suffixIcon (x: string) = Bolero.Html.attr.fragment "SuffixIcon" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline suffixIcon (node) = Bolero.Html.attr.fragment "SuffixIcon" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline suffixIcon (nodes) = Bolero.Html.attr.fragment "SuffixIcon" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline renderExtraFooter (x: string) = Bolero.Html.attr.fragment "RenderExtraFooter" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline renderExtraFooter (node) = Bolero.Html.attr.fragment "RenderExtraFooter" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline renderExtraFooter (nodes) = Bolero.Html.attr.fragment "RenderExtraFooter" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onClearClick (x: Microsoft.AspNetCore.Components.EventCallback) = "OnClearClick" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onOpenChange fn = (Bolero.Html.attr.callback<System.Boolean> "OnOpenChange" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onPanelChange fn = (Bolero.Html.attr.callback<AntDesign.DateTimeChangedEventArgs> "OnPanelChange" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabledDate (x: System.Func<System.DateTime, System.Boolean>) = "DisabledDate" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabledHours (x: System.Func<System.DateTime, System.Int32[]>) = "DisabledHours" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabledMinutes (x: System.Func<System.DateTime, System.Int32[]>) = "DisabledMinutes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabledSeconds (x: System.Func<System.DateTime, System.Int32[]>) = "DisabledSeconds" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabledTime (x: System.Func<System.DateTime, AntDesign.DatePickerDisabledTime>) = "DisabledTime" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline dateRender (x: System.Func<System.DateTime, System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "DateRender" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline monthCellRender (x: System.Func<System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "MonthCellRender" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline additionalAttributes (x: System.Collections.Generic.IReadOnlyDictionary<System.String, System.Object>) = "AdditionalAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline value (x: 'TValue) = "Value" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valueChanged fn = (Bolero.Html.attr.callback<'TValue> "ValueChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valueExpression (x: System.Linq.Expressions.Expression<System.Func<'TValue>>) = "ValueExpression" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valuesExpression (x: System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.IEnumerable<'TValue>>>) = "ValuesExpression" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline size (x: System.String) = "Size" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type yearPicker<'FunBlazorGeneric, 'TValue> =
    inherit datePicker<'FunBlazorGeneric, 'TValue>
    static member inline create () = [] |> html.blazor<AntDesign.YearPicker<'TValue>>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.YearPicker<'TValue>>

    static member inline ref x = attr.ref x
    static member inline onChange fn = (Bolero.Html.attr.callback<AntDesign.DateTimeChangedEventArgs> "OnChange" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline prefixCls (x: System.String) = "PrefixCls" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline picker (x: System.String) = "Picker" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline popupContainerSelector (x: System.String) = "PopupContainerSelector" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabled (x: System.Boolean) = "Disabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline bordered (x: System.Boolean) = "Bordered" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline autoFocus (x: System.Boolean) = "AutoFocus" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline open' (x: System.Boolean) = "Open" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline inputReadOnly (x: System.Boolean) = "InputReadOnly" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline showToday (x: System.Boolean) = "ShowToday" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline locale (x: AntDesign.DatePickerLocale) = "Locale" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline cultureInfo (x: System.Globalization.CultureInfo) = "CultureInfo" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline showTime (x: OneOf.OneOf<System.Boolean, System.String>) = "ShowTime" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline allowClear (x: System.Boolean) = "AllowClear" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline placeholder (x: OneOf.OneOf<System.String, System.String[]>) = "Placeholder" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline popupStyle (x: System.String) = "PopupStyle" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline className (x: System.String) = "ClassName" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline dropdownClassName (x: System.String) = "DropdownClassName" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline format (x: System.String) = "Format" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline defaultValue (x: 'TValue) = "DefaultValue" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline defaultPickerValue (x: 'TValue) = "DefaultPickerValue" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline suffixIcon (x: string) = Bolero.Html.attr.fragment "SuffixIcon" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline suffixIcon (node) = Bolero.Html.attr.fragment "SuffixIcon" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline suffixIcon (nodes) = Bolero.Html.attr.fragment "SuffixIcon" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline renderExtraFooter (x: string) = Bolero.Html.attr.fragment "RenderExtraFooter" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline renderExtraFooter (node) = Bolero.Html.attr.fragment "RenderExtraFooter" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline renderExtraFooter (nodes) = Bolero.Html.attr.fragment "RenderExtraFooter" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onClearClick (x: Microsoft.AspNetCore.Components.EventCallback) = "OnClearClick" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onOpenChange fn = (Bolero.Html.attr.callback<System.Boolean> "OnOpenChange" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onPanelChange fn = (Bolero.Html.attr.callback<AntDesign.DateTimeChangedEventArgs> "OnPanelChange" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabledDate (x: System.Func<System.DateTime, System.Boolean>) = "DisabledDate" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabledHours (x: System.Func<System.DateTime, System.Int32[]>) = "DisabledHours" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabledMinutes (x: System.Func<System.DateTime, System.Int32[]>) = "DisabledMinutes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabledSeconds (x: System.Func<System.DateTime, System.Int32[]>) = "DisabledSeconds" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabledTime (x: System.Func<System.DateTime, AntDesign.DatePickerDisabledTime>) = "DisabledTime" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline dateRender (x: System.Func<System.DateTime, System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "DateRender" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline monthCellRender (x: System.Func<System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "MonthCellRender" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline additionalAttributes (x: System.Collections.Generic.IReadOnlyDictionary<System.String, System.Object>) = "AdditionalAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline value (x: 'TValue) = "Value" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valueChanged fn = (Bolero.Html.attr.callback<'TValue> "ValueChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valueExpression (x: System.Linq.Expressions.Expression<System.Func<'TValue>>) = "ValueExpression" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valuesExpression (x: System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.IEnumerable<'TValue>>>) = "ValuesExpression" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline size (x: System.String) = "Size" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type timePicker<'FunBlazorGeneric, 'TValue> =
    inherit datePicker<'FunBlazorGeneric, 'TValue>
    static member inline create () = [] |> html.blazor<AntDesign.TimePicker<'TValue>>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.TimePicker<'TValue>>

    static member inline ref x = attr.ref x
    static member inline onChange fn = (Bolero.Html.attr.callback<AntDesign.DateTimeChangedEventArgs> "OnChange" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline prefixCls (x: System.String) = "PrefixCls" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline picker (x: System.String) = "Picker" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline popupContainerSelector (x: System.String) = "PopupContainerSelector" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabled (x: System.Boolean) = "Disabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline bordered (x: System.Boolean) = "Bordered" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline autoFocus (x: System.Boolean) = "AutoFocus" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline open' (x: System.Boolean) = "Open" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline inputReadOnly (x: System.Boolean) = "InputReadOnly" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline showToday (x: System.Boolean) = "ShowToday" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline locale (x: AntDesign.DatePickerLocale) = "Locale" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline cultureInfo (x: System.Globalization.CultureInfo) = "CultureInfo" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline showTime (x: OneOf.OneOf<System.Boolean, System.String>) = "ShowTime" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline allowClear (x: System.Boolean) = "AllowClear" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline placeholder (x: OneOf.OneOf<System.String, System.String[]>) = "Placeholder" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline popupStyle (x: System.String) = "PopupStyle" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline className (x: System.String) = "ClassName" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline dropdownClassName (x: System.String) = "DropdownClassName" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline format (x: System.String) = "Format" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline defaultValue (x: 'TValue) = "DefaultValue" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline defaultPickerValue (x: 'TValue) = "DefaultPickerValue" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline suffixIcon (x: string) = Bolero.Html.attr.fragment "SuffixIcon" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline suffixIcon (node) = Bolero.Html.attr.fragment "SuffixIcon" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline suffixIcon (nodes) = Bolero.Html.attr.fragment "SuffixIcon" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline renderExtraFooter (x: string) = Bolero.Html.attr.fragment "RenderExtraFooter" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline renderExtraFooter (node) = Bolero.Html.attr.fragment "RenderExtraFooter" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline renderExtraFooter (nodes) = Bolero.Html.attr.fragment "RenderExtraFooter" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onClearClick (x: Microsoft.AspNetCore.Components.EventCallback) = "OnClearClick" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onOpenChange fn = (Bolero.Html.attr.callback<System.Boolean> "OnOpenChange" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onPanelChange fn = (Bolero.Html.attr.callback<AntDesign.DateTimeChangedEventArgs> "OnPanelChange" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabledDate (x: System.Func<System.DateTime, System.Boolean>) = "DisabledDate" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabledHours (x: System.Func<System.DateTime, System.Int32[]>) = "DisabledHours" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabledMinutes (x: System.Func<System.DateTime, System.Int32[]>) = "DisabledMinutes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabledSeconds (x: System.Func<System.DateTime, System.Int32[]>) = "DisabledSeconds" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabledTime (x: System.Func<System.DateTime, AntDesign.DatePickerDisabledTime>) = "DisabledTime" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline dateRender (x: System.Func<System.DateTime, System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "DateRender" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline monthCellRender (x: System.Func<System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "MonthCellRender" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline additionalAttributes (x: System.Collections.Generic.IReadOnlyDictionary<System.String, System.Object>) = "AdditionalAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline value (x: 'TValue) = "Value" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valueChanged fn = (Bolero.Html.attr.callback<'TValue> "ValueChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valueExpression (x: System.Linq.Expressions.Expression<System.Func<'TValue>>) = "ValueExpression" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valuesExpression (x: System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.IEnumerable<'TValue>>>) = "ValuesExpression" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline size (x: System.String) = "Size" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type rangePicker<'FunBlazorGeneric, 'TValue> =
    inherit datePickerBase<'FunBlazorGeneric, 'TValue>
    static member inline create () = [] |> html.blazor<AntDesign.RangePicker<'TValue>>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.RangePicker<'TValue>>

    static member inline ref x = attr.ref x
    static member inline value (x: 'TValue) = "Value" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onChange fn = (Bolero.Html.attr.callback<AntDesign.DateRangeChangedEventArgs> "OnChange" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline prefixCls (x: System.String) = "PrefixCls" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline picker (x: System.String) = "Picker" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline popupContainerSelector (x: System.String) = "PopupContainerSelector" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabled (x: System.Boolean) = "Disabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline bordered (x: System.Boolean) = "Bordered" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline autoFocus (x: System.Boolean) = "AutoFocus" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline open' (x: System.Boolean) = "Open" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline inputReadOnly (x: System.Boolean) = "InputReadOnly" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline showToday (x: System.Boolean) = "ShowToday" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline locale (x: AntDesign.DatePickerLocale) = "Locale" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline cultureInfo (x: System.Globalization.CultureInfo) = "CultureInfo" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline showTime (x: OneOf.OneOf<System.Boolean, System.String>) = "ShowTime" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline allowClear (x: System.Boolean) = "AllowClear" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline placeholder (x: OneOf.OneOf<System.String, System.String[]>) = "Placeholder" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline popupStyle (x: System.String) = "PopupStyle" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline className (x: System.String) = "ClassName" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline dropdownClassName (x: System.String) = "DropdownClassName" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline format (x: System.String) = "Format" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline defaultValue (x: 'TValue) = "DefaultValue" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline defaultPickerValue (x: 'TValue) = "DefaultPickerValue" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline suffixIcon (x: string) = Bolero.Html.attr.fragment "SuffixIcon" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline suffixIcon (node) = Bolero.Html.attr.fragment "SuffixIcon" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline suffixIcon (nodes) = Bolero.Html.attr.fragment "SuffixIcon" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline renderExtraFooter (x: string) = Bolero.Html.attr.fragment "RenderExtraFooter" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline renderExtraFooter (node) = Bolero.Html.attr.fragment "RenderExtraFooter" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline renderExtraFooter (nodes) = Bolero.Html.attr.fragment "RenderExtraFooter" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onClearClick (x: Microsoft.AspNetCore.Components.EventCallback) = "OnClearClick" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onOpenChange fn = (Bolero.Html.attr.callback<System.Boolean> "OnOpenChange" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onPanelChange fn = (Bolero.Html.attr.callback<AntDesign.DateTimeChangedEventArgs> "OnPanelChange" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabledDate (x: System.Func<System.DateTime, System.Boolean>) = "DisabledDate" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabledHours (x: System.Func<System.DateTime, System.Int32[]>) = "DisabledHours" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabledMinutes (x: System.Func<System.DateTime, System.Int32[]>) = "DisabledMinutes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabledSeconds (x: System.Func<System.DateTime, System.Int32[]>) = "DisabledSeconds" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabledTime (x: System.Func<System.DateTime, AntDesign.DatePickerDisabledTime>) = "DisabledTime" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline dateRender (x: System.Func<System.DateTime, System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "DateRender" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline monthCellRender (x: System.Func<System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "MonthCellRender" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline additionalAttributes (x: System.Collections.Generic.IReadOnlyDictionary<System.String, System.Object>) = "AdditionalAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valueChanged fn = (Bolero.Html.attr.callback<'TValue> "ValueChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valueExpression (x: System.Linq.Expressions.Expression<System.Func<'TValue>>) = "ValueExpression" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valuesExpression (x: System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.IEnumerable<'TValue>>>) = "ValuesExpression" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline size (x: System.String) = "Size" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type inputNumber<'FunBlazorGeneric, 'TValue> =
    inherit antInputComponentBase<'FunBlazorGeneric, 'TValue>
    static member inline create () = [] |> html.blazor<AntDesign.InputNumber<'TValue>>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.InputNumber<'TValue>>

    static member inline ref x = attr.ref x
    static member inline formatter (x: System.Func<'TValue, System.String>) = "Formatter" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline parser (x: System.Func<System.String, System.String>) = "Parser" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline step (x: 'TValue) = "Step" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline defaultValue (x: 'TValue) = "DefaultValue" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline max (x: 'TValue) = "Max" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline min (x: 'TValue) = "Min" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabled (x: System.Boolean) = "Disabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onChange fn = (Bolero.Html.attr.callback<'TValue> "OnChange" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline additionalAttributes (x: System.Collections.Generic.IReadOnlyDictionary<System.String, System.Object>) = "AdditionalAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline value (x: 'TValue) = "Value" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valueChanged fn = (Bolero.Html.attr.callback<'TValue> "ValueChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valueExpression (x: System.Linq.Expressions.Expression<System.Func<'TValue>>) = "ValueExpression" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valuesExpression (x: System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.IEnumerable<'TValue>>>) = "ValuesExpression" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline size (x: System.String) = "Size" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline cultureInfo (x: System.Globalization.CultureInfo) = "CultureInfo" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type input<'FunBlazorGeneric, 'TValue> =
    inherit antInputComponentBase<'FunBlazorGeneric, 'TValue>
    static member inline create () = [] |> html.blazor<AntDesign.Input<'TValue>>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.Input<'TValue>>

    static member inline ref x = attr.ref x
    static member inline addOnBefore (x: string) = Bolero.Html.attr.fragment "AddOnBefore" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline addOnBefore (node) = Bolero.Html.attr.fragment "AddOnBefore" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline addOnBefore (nodes) = Bolero.Html.attr.fragment "AddOnBefore" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline addOnAfter (x: string) = Bolero.Html.attr.fragment "AddOnAfter" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline addOnAfter (node) = Bolero.Html.attr.fragment "AddOnAfter" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline addOnAfter (nodes) = Bolero.Html.attr.fragment "AddOnAfter" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline allowClear (x: System.Boolean) = "AllowClear" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline autoFocus (x: System.Boolean) = "AutoFocus" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline bordered (x: System.Boolean) = "Bordered" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline debounceMilliseconds (x: System.Int32) = "DebounceMilliseconds" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline defaultValue (x: 'TValue) = "DefaultValue" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabled (x: System.Boolean) = "Disabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline inputElementSuffixClass (x: System.String) = "InputElementSuffixClass" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline maxLength (x: System.Int32) = "MaxLength" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onBlur fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.FocusEventArgs> "OnBlur" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onChange fn = (Bolero.Html.attr.callback<'TValue> "OnChange" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onFocus fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.FocusEventArgs> "OnFocus" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onInput fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.ChangeEventArgs> "OnInput" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onkeyDown fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs> "OnkeyDown" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onkeyUp fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs> "OnkeyUp" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onMouseUp fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnMouseUp" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onPressEnter fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs> "OnPressEnter" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline placeholder (x: System.String) = "Placeholder" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline prefix (x: string) = Bolero.Html.attr.fragment "Prefix" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline prefix (node) = Bolero.Html.attr.fragment "Prefix" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline prefix (nodes) = Bolero.Html.attr.fragment "Prefix" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline readOnly (x: System.Boolean) = "ReadOnly" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline suffix (x: string) = Bolero.Html.attr.fragment "Suffix" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline suffix (node) = Bolero.Html.attr.fragment "Suffix" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline suffix (nodes) = Bolero.Html.attr.fragment "Suffix" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline type' (x: System.String) = "Type" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline wrapperStyle (x: System.String) = "WrapperStyle" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline additionalAttributes (x: System.Collections.Generic.IReadOnlyDictionary<System.String, System.Object>) = "AdditionalAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline value (x: 'TValue) = "Value" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valueChanged fn = (Bolero.Html.attr.callback<'TValue> "ValueChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valueExpression (x: System.Linq.Expressions.Expression<System.Func<'TValue>>) = "ValueExpression" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valuesExpression (x: System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.IEnumerable<'TValue>>>) = "ValuesExpression" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline size (x: System.String) = "Size" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline cultureInfo (x: System.Globalization.CultureInfo) = "CultureInfo" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type autoCompleteInput<'FunBlazorGeneric, 'TValue> =
    inherit input<'FunBlazorGeneric, 'TValue>
    static member inline create () = [] |> html.blazor<AntDesign.AutoCompleteInput<'TValue>>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.AutoCompleteInput<'TValue>>

    static member inline ref x = attr.ref x
    static member inline addOnBefore (x: string) = Bolero.Html.attr.fragment "AddOnBefore" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline addOnBefore (node) = Bolero.Html.attr.fragment "AddOnBefore" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline addOnBefore (nodes) = Bolero.Html.attr.fragment "AddOnBefore" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline addOnAfter (x: string) = Bolero.Html.attr.fragment "AddOnAfter" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline addOnAfter (node) = Bolero.Html.attr.fragment "AddOnAfter" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline addOnAfter (nodes) = Bolero.Html.attr.fragment "AddOnAfter" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline allowClear (x: System.Boolean) = "AllowClear" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline autoFocus (x: System.Boolean) = "AutoFocus" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline bordered (x: System.Boolean) = "Bordered" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline debounceMilliseconds (x: System.Int32) = "DebounceMilliseconds" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline defaultValue (x: 'TValue) = "DefaultValue" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabled (x: System.Boolean) = "Disabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline inputElementSuffixClass (x: System.String) = "InputElementSuffixClass" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline maxLength (x: System.Int32) = "MaxLength" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onBlur fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.FocusEventArgs> "OnBlur" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onChange fn = (Bolero.Html.attr.callback<'TValue> "OnChange" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onFocus fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.FocusEventArgs> "OnFocus" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onInput fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.ChangeEventArgs> "OnInput" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onkeyDown fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs> "OnkeyDown" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onkeyUp fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs> "OnkeyUp" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onMouseUp fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnMouseUp" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onPressEnter fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs> "OnPressEnter" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline placeholder (x: System.String) = "Placeholder" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline prefix (x: string) = Bolero.Html.attr.fragment "Prefix" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline prefix (node) = Bolero.Html.attr.fragment "Prefix" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline prefix (nodes) = Bolero.Html.attr.fragment "Prefix" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline readOnly (x: System.Boolean) = "ReadOnly" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline suffix (x: string) = Bolero.Html.attr.fragment "Suffix" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline suffix (node) = Bolero.Html.attr.fragment "Suffix" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline suffix (nodes) = Bolero.Html.attr.fragment "Suffix" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline type' (x: System.String) = "Type" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline wrapperStyle (x: System.String) = "WrapperStyle" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline additionalAttributes (x: System.Collections.Generic.IReadOnlyDictionary<System.String, System.Object>) = "AdditionalAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline value (x: 'TValue) = "Value" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valueChanged fn = (Bolero.Html.attr.callback<'TValue> "ValueChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valueExpression (x: System.Linq.Expressions.Expression<System.Func<'TValue>>) = "ValueExpression" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valuesExpression (x: System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.IEnumerable<'TValue>>>) = "ValuesExpression" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline size (x: System.String) = "Size" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline cultureInfo (x: System.Globalization.CultureInfo) = "CultureInfo" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type inputPassword<'FunBlazorGeneric> =
    inherit input<'FunBlazorGeneric, System.String>
    static member inline create () = [] |> html.blazor<AntDesign.InputPassword>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.InputPassword>

    static member inline ref x = attr.ref x
    static member inline iconRender (x: string) = Bolero.Html.attr.fragment "IconRender" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline iconRender (node) = Bolero.Html.attr.fragment "IconRender" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline iconRender (nodes) = Bolero.Html.attr.fragment "IconRender" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline showPassword (x: System.Boolean) = "ShowPassword" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline visibilityToggle (x: System.Boolean) = "VisibilityToggle" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline addOnBefore (x: string) = Bolero.Html.attr.fragment "AddOnBefore" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline addOnBefore (node) = Bolero.Html.attr.fragment "AddOnBefore" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline addOnBefore (nodes) = Bolero.Html.attr.fragment "AddOnBefore" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline addOnAfter (x: string) = Bolero.Html.attr.fragment "AddOnAfter" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline addOnAfter (node) = Bolero.Html.attr.fragment "AddOnAfter" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline addOnAfter (nodes) = Bolero.Html.attr.fragment "AddOnAfter" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline allowClear (x: System.Boolean) = "AllowClear" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline autoFocus (x: System.Boolean) = "AutoFocus" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline bordered (x: System.Boolean) = "Bordered" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline debounceMilliseconds (x: System.Int32) = "DebounceMilliseconds" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline defaultValue (x: System.String) = "DefaultValue" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabled (x: System.Boolean) = "Disabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline inputElementSuffixClass (x: System.String) = "InputElementSuffixClass" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline maxLength (x: System.Int32) = "MaxLength" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onBlur fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.FocusEventArgs> "OnBlur" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onChange fn = (Bolero.Html.attr.callback<System.String> "OnChange" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onFocus fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.FocusEventArgs> "OnFocus" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onInput fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.ChangeEventArgs> "OnInput" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onkeyDown fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs> "OnkeyDown" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onkeyUp fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs> "OnkeyUp" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onMouseUp fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnMouseUp" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onPressEnter fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs> "OnPressEnter" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline placeholder (x: System.String) = "Placeholder" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline prefix (x: string) = Bolero.Html.attr.fragment "Prefix" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline prefix (node) = Bolero.Html.attr.fragment "Prefix" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline prefix (nodes) = Bolero.Html.attr.fragment "Prefix" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline readOnly (x: System.Boolean) = "ReadOnly" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline suffix (x: string) = Bolero.Html.attr.fragment "Suffix" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline suffix (node) = Bolero.Html.attr.fragment "Suffix" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline suffix (nodes) = Bolero.Html.attr.fragment "Suffix" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline type' (x: System.String) = "Type" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline wrapperStyle (x: System.String) = "WrapperStyle" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline additionalAttributes (x: System.Collections.Generic.IReadOnlyDictionary<System.String, System.Object>) = "AdditionalAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline value (x: System.String) = "Value" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valueChanged fn = (Bolero.Html.attr.callback<System.String> "ValueChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valueExpression (x: System.Linq.Expressions.Expression<System.Func<System.String>>) = "ValueExpression" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valuesExpression (x: System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.IEnumerable<System.String>>>) = "ValuesExpression" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline size (x: System.String) = "Size" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline cultureInfo (x: System.Globalization.CultureInfo) = "CultureInfo" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type search<'FunBlazorGeneric> =
    inherit input<'FunBlazorGeneric, System.String>
    static member inline create () = [] |> html.blazor<AntDesign.Search>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.Search>

    static member inline ref x = attr.ref x
    static member inline classicSearchIcon (x: System.Boolean) = "ClassicSearchIcon" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline enterButton (x: OneOf.OneOf<System.Boolean, System.String>) = "EnterButton" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline loading (x: System.Boolean) = "Loading" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onSearch fn = (Bolero.Html.attr.callback<System.String> "OnSearch" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline addOnBefore (x: string) = Bolero.Html.attr.fragment "AddOnBefore" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline addOnBefore (node) = Bolero.Html.attr.fragment "AddOnBefore" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline addOnBefore (nodes) = Bolero.Html.attr.fragment "AddOnBefore" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline addOnAfter (x: string) = Bolero.Html.attr.fragment "AddOnAfter" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline addOnAfter (node) = Bolero.Html.attr.fragment "AddOnAfter" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline addOnAfter (nodes) = Bolero.Html.attr.fragment "AddOnAfter" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline allowClear (x: System.Boolean) = "AllowClear" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline autoFocus (x: System.Boolean) = "AutoFocus" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline bordered (x: System.Boolean) = "Bordered" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline debounceMilliseconds (x: System.Int32) = "DebounceMilliseconds" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline defaultValue (x: System.String) = "DefaultValue" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabled (x: System.Boolean) = "Disabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline inputElementSuffixClass (x: System.String) = "InputElementSuffixClass" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline maxLength (x: System.Int32) = "MaxLength" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onBlur fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.FocusEventArgs> "OnBlur" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onChange fn = (Bolero.Html.attr.callback<System.String> "OnChange" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onFocus fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.FocusEventArgs> "OnFocus" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onInput fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.ChangeEventArgs> "OnInput" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onkeyDown fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs> "OnkeyDown" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onkeyUp fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs> "OnkeyUp" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onMouseUp fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnMouseUp" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onPressEnter fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs> "OnPressEnter" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline placeholder (x: System.String) = "Placeholder" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline prefix (x: string) = Bolero.Html.attr.fragment "Prefix" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline prefix (node) = Bolero.Html.attr.fragment "Prefix" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline prefix (nodes) = Bolero.Html.attr.fragment "Prefix" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline readOnly (x: System.Boolean) = "ReadOnly" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline suffix (x: string) = Bolero.Html.attr.fragment "Suffix" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline suffix (node) = Bolero.Html.attr.fragment "Suffix" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline suffix (nodes) = Bolero.Html.attr.fragment "Suffix" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline type' (x: System.String) = "Type" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline wrapperStyle (x: System.String) = "WrapperStyle" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline additionalAttributes (x: System.Collections.Generic.IReadOnlyDictionary<System.String, System.Object>) = "AdditionalAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline value (x: System.String) = "Value" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valueChanged fn = (Bolero.Html.attr.callback<System.String> "ValueChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valueExpression (x: System.Linq.Expressions.Expression<System.Func<System.String>>) = "ValueExpression" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valuesExpression (x: System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.IEnumerable<System.String>>>) = "ValuesExpression" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline size (x: System.String) = "Size" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline cultureInfo (x: System.Globalization.CultureInfo) = "CultureInfo" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type autoCompleteSearch<'FunBlazorGeneric> =
    inherit search<'FunBlazorGeneric>
    static member inline create () = [] |> html.blazor<AntDesign.AutoCompleteSearch>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.AutoCompleteSearch>

    static member inline ref x = attr.ref x
    static member inline classicSearchIcon (x: System.Boolean) = "ClassicSearchIcon" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline enterButton (x: OneOf.OneOf<System.Boolean, System.String>) = "EnterButton" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline loading (x: System.Boolean) = "Loading" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onSearch fn = (Bolero.Html.attr.callback<System.String> "OnSearch" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline addOnBefore (x: string) = Bolero.Html.attr.fragment "AddOnBefore" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline addOnBefore (node) = Bolero.Html.attr.fragment "AddOnBefore" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline addOnBefore (nodes) = Bolero.Html.attr.fragment "AddOnBefore" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline addOnAfter (x: string) = Bolero.Html.attr.fragment "AddOnAfter" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline addOnAfter (node) = Bolero.Html.attr.fragment "AddOnAfter" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline addOnAfter (nodes) = Bolero.Html.attr.fragment "AddOnAfter" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline allowClear (x: System.Boolean) = "AllowClear" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline autoFocus (x: System.Boolean) = "AutoFocus" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline bordered (x: System.Boolean) = "Bordered" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline debounceMilliseconds (x: System.Int32) = "DebounceMilliseconds" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline defaultValue (x: System.String) = "DefaultValue" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabled (x: System.Boolean) = "Disabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline inputElementSuffixClass (x: System.String) = "InputElementSuffixClass" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline maxLength (x: System.Int32) = "MaxLength" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onBlur fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.FocusEventArgs> "OnBlur" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onChange fn = (Bolero.Html.attr.callback<System.String> "OnChange" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onFocus fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.FocusEventArgs> "OnFocus" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onInput fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.ChangeEventArgs> "OnInput" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onkeyDown fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs> "OnkeyDown" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onkeyUp fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs> "OnkeyUp" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onMouseUp fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnMouseUp" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onPressEnter fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs> "OnPressEnter" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline placeholder (x: System.String) = "Placeholder" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline prefix (x: string) = Bolero.Html.attr.fragment "Prefix" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline prefix (node) = Bolero.Html.attr.fragment "Prefix" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline prefix (nodes) = Bolero.Html.attr.fragment "Prefix" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline readOnly (x: System.Boolean) = "ReadOnly" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline suffix (x: string) = Bolero.Html.attr.fragment "Suffix" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline suffix (node) = Bolero.Html.attr.fragment "Suffix" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline suffix (nodes) = Bolero.Html.attr.fragment "Suffix" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline type' (x: System.String) = "Type" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline wrapperStyle (x: System.String) = "WrapperStyle" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline additionalAttributes (x: System.Collections.Generic.IReadOnlyDictionary<System.String, System.Object>) = "AdditionalAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline value (x: System.String) = "Value" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valueChanged fn = (Bolero.Html.attr.callback<System.String> "ValueChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valueExpression (x: System.Linq.Expressions.Expression<System.Func<System.String>>) = "ValueExpression" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valuesExpression (x: System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.IEnumerable<System.String>>>) = "ValuesExpression" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline size (x: System.String) = "Size" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline cultureInfo (x: System.Globalization.CultureInfo) = "CultureInfo" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type textArea<'FunBlazorGeneric> =
    inherit input<'FunBlazorGeneric, System.String>
    static member inline create () = [] |> html.blazor<AntDesign.TextArea>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.TextArea>

    static member inline ref x = attr.ref x
    static member inline autoSize (x: System.Boolean) = "AutoSize" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline defaultToEmptyString (x: System.Boolean) = "DefaultToEmptyString" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline maxRows (x: System.UInt32) = "MaxRows" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline minRows (x: System.UInt32) = "MinRows" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onResize fn = (Bolero.Html.attr.callback<AntDesign.OnResizeEventArgs> "OnResize" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline showCount (x: System.Boolean) = "ShowCount" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline addOnBefore (x: string) = Bolero.Html.attr.fragment "AddOnBefore" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline addOnBefore (node) = Bolero.Html.attr.fragment "AddOnBefore" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline addOnBefore (nodes) = Bolero.Html.attr.fragment "AddOnBefore" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline addOnAfter (x: string) = Bolero.Html.attr.fragment "AddOnAfter" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline addOnAfter (node) = Bolero.Html.attr.fragment "AddOnAfter" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline addOnAfter (nodes) = Bolero.Html.attr.fragment "AddOnAfter" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline allowClear (x: System.Boolean) = "AllowClear" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline autoFocus (x: System.Boolean) = "AutoFocus" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline bordered (x: System.Boolean) = "Bordered" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline debounceMilliseconds (x: System.Int32) = "DebounceMilliseconds" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline defaultValue (x: System.String) = "DefaultValue" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabled (x: System.Boolean) = "Disabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline inputElementSuffixClass (x: System.String) = "InputElementSuffixClass" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline maxLength (x: System.Int32) = "MaxLength" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onBlur fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.FocusEventArgs> "OnBlur" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onChange fn = (Bolero.Html.attr.callback<System.String> "OnChange" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onFocus fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.FocusEventArgs> "OnFocus" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onInput fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.ChangeEventArgs> "OnInput" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onkeyDown fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs> "OnkeyDown" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onkeyUp fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs> "OnkeyUp" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onMouseUp fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnMouseUp" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onPressEnter fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs> "OnPressEnter" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline placeholder (x: System.String) = "Placeholder" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline prefix (x: string) = Bolero.Html.attr.fragment "Prefix" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline prefix (node) = Bolero.Html.attr.fragment "Prefix" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline prefix (nodes) = Bolero.Html.attr.fragment "Prefix" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline readOnly (x: System.Boolean) = "ReadOnly" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline suffix (x: string) = Bolero.Html.attr.fragment "Suffix" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline suffix (node) = Bolero.Html.attr.fragment "Suffix" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline suffix (nodes) = Bolero.Html.attr.fragment "Suffix" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline type' (x: System.String) = "Type" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline wrapperStyle (x: System.String) = "WrapperStyle" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline additionalAttributes (x: System.Collections.Generic.IReadOnlyDictionary<System.String, System.Object>) = "AdditionalAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline value (x: System.String) = "Value" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valueChanged fn = (Bolero.Html.attr.callback<System.String> "ValueChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valueExpression (x: System.Linq.Expressions.Expression<System.Func<System.String>>) = "ValueExpression" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valuesExpression (x: System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.IEnumerable<System.String>>>) = "ValuesExpression" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline size (x: System.String) = "Size" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline cultureInfo (x: System.Globalization.CultureInfo) = "CultureInfo" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type radioGroup<'FunBlazorGeneric, 'TValue> =
    inherit antInputComponentBase<'FunBlazorGeneric, 'TValue>
    static member inline create () = [] |> html.blazor<AntDesign.RadioGroup<'TValue>>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.RadioGroup<'TValue>>
    static member inline create (nodes: FunBlazorNode list) = nodes |> html.blazor<AntDesign.RadioGroup<'TValue>>
    static member inline create (node: FunBlazorNode) = [ node ] |> html.blazor<AntDesign.RadioGroup<'TValue>>
    static member inline ref x = attr.ref x
    static member inline childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabled (x: System.Boolean) = "Disabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline buttonStyle (x: System.String) = "ButtonStyle" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline name (x: System.String) = "Name" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline defaultValue (x: 'TValue) = "DefaultValue" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onChange fn = (Bolero.Html.attr.callback<'TValue> "OnChange" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline additionalAttributes (x: System.Collections.Generic.IReadOnlyDictionary<System.String, System.Object>) = "AdditionalAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline value (x: 'TValue) = "Value" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valueChanged fn = (Bolero.Html.attr.callback<'TValue> "ValueChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valueExpression (x: System.Linq.Expressions.Expression<System.Func<'TValue>>) = "ValueExpression" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valuesExpression (x: System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.IEnumerable<'TValue>>>) = "ValuesExpression" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline size (x: System.String) = "Size" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline cultureInfo (x: System.Globalization.CultureInfo) = "CultureInfo" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type select<'FunBlazorGeneric, 'TItemValue, 'TItem> =
    inherit antInputComponentBase<'FunBlazorGeneric, 'TItemValue>
    static member inline create () = [] |> html.blazor<AntDesign.Select<'TItemValue, 'TItem>>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.Select<'TItemValue, 'TItem>>

    static member inline ref x = attr.ref x
    static member inline allowClear (x: System.Boolean) = "AllowClear" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline autoClearSearchValue (x: System.Boolean) = "AutoClearSearchValue" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline bordered (x: System.Boolean) = "Bordered" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onCreateCustomTag (x: System.Action<System.String>) = "OnCreateCustomTag" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline defaultActiveFirstOption (x: System.Boolean) = "DefaultActiveFirstOption" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabled (x: System.Boolean) = "Disabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabledName (x: System.String) = "DisabledName" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline dropdownRender (x: System.Func<Microsoft.AspNetCore.Components.RenderFragment, Microsoft.AspNetCore.Components.RenderFragment>) = "DropdownRender" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline enableSearch (x: System.Boolean) = "EnableSearch" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline groupName (x: System.String) = "GroupName" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline hideSelected (x: System.Boolean) = "HideSelected" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline ignoreItemChanges (x: System.Boolean) = "IgnoreItemChanges" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline itemTemplate (render: 'TItem -> FunBlazorNode) = Bolero.Html.attr.fragmentWith "ItemTemplate" (fun x -> render x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline labelInValue (x: System.Boolean) = "LabelInValue" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline labelName (x: System.String) = "LabelName" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline labelTemplate (render: 'TItem -> FunBlazorNode) = Bolero.Html.attr.fragmentWith "LabelTemplate" (fun x -> render x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline loading (x: System.Boolean) = "Loading" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline maxTagTextLength (x: System.Int32) = "MaxTagTextLength" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline maxTagCount (x: OneOf.OneOf<System.Int32, AntDesign.Select.ResponsiveTag>) = "MaxTagCount" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline maxTagPlaceholder (render: System.Collections.Generic.IEnumerable<'TItem> -> FunBlazorNode) = Bolero.Html.attr.fragmentWith "MaxTagPlaceholder" (fun x -> render x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline mode (x: System.String) = "Mode" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline notFoundContent (x: string) = Bolero.Html.attr.fragment "NotFoundContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline notFoundContent (node) = Bolero.Html.attr.fragment "NotFoundContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline notFoundContent (nodes) = Bolero.Html.attr.fragment "NotFoundContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onBlur (x: System.Action) = "OnBlur" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onClearSelected (x: System.Action) = "OnClearSelected" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onDataSourceChanged (x: System.Action) = "OnDataSourceChanged" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onDropdownVisibleChange (x: System.Action<System.Boolean>) = "OnDropdownVisibleChange" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onFocus (x: System.Action) = "OnFocus" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onMouseEnter (x: System.Action) = "OnMouseEnter" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onMouseLeave (x: System.Action) = "OnMouseLeave" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onSearch (x: System.Action<System.String>) = "OnSearch" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onSelectedItemChanged (x: System.Action<'TItem>) = "OnSelectedItemChanged" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onSelectedItemsChanged (x: System.Action<System.Collections.Generic.IEnumerable<'TItem>>) = "OnSelectedItemsChanged" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline open' (x: System.Boolean) = "Open" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline placeholder (x: System.String) = "Placeholder" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline popupContainerMaxHeight (x: System.String) = "PopupContainerMaxHeight" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline popupContainerSelector (x: System.String) = "PopupContainerSelector" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline dropdownMatchSelectWidth (x: OneOf.OneOf<System.Boolean, System.String>) = "DropdownMatchSelectWidth" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline dropdownMaxWidth (x: System.String) = "DropdownMaxWidth" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline showArrowIcon (x: System.Boolean) = "ShowArrowIcon" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline showSearchIcon (x: System.Boolean) = "ShowSearchIcon" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline sortByGroup (x: AntDesign.SortDirection) = "SortByGroup" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline sortByLabel (x: AntDesign.SortDirection) = "SortByLabel" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline suffixIcon (x: string) = Bolero.Html.attr.fragment "SuffixIcon" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline suffixIcon (node) = Bolero.Html.attr.fragment "SuffixIcon" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline suffixIcon (nodes) = Bolero.Html.attr.fragment "SuffixIcon" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline prefixIcon (x: string) = Bolero.Html.attr.fragment "PrefixIcon" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline prefixIcon (node) = Bolero.Html.attr.fragment "PrefixIcon" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline prefixIcon (nodes) = Bolero.Html.attr.fragment "PrefixIcon" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline tokenSeparators (x: System.Char[]) = "TokenSeparators" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valueChanged fn = (Bolero.Html.attr.callback<'TItemValue> "ValueChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valueName (x: System.String) = "ValueName" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valuesChanged fn = (Bolero.Html.attr.callback<System.Collections.Generic.IEnumerable<'TItemValue>> "ValuesChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline customTagLabelToValue (x: System.Func<System.String, 'TItemValue>) = "CustomTagLabelToValue" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline dataSource (x: System.Collections.Generic.IEnumerable<'TItem>) = "DataSource" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline value (x: 'TItemValue) = "Value" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline defaultValue (x: 'TItemValue) = "DefaultValue" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline values (x: System.Collections.Generic.IEnumerable<'TItemValue>) = "Values" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline defaultValues (x: System.Collections.Generic.IEnumerable<'TItemValue>) = "DefaultValues" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline selectOptions (x: string) = Bolero.Html.attr.fragment "SelectOptions" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline selectOptions (node) = Bolero.Html.attr.fragment "SelectOptions" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline selectOptions (nodes) = Bolero.Html.attr.fragment "SelectOptions" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline additionalAttributes (x: System.Collections.Generic.IReadOnlyDictionary<System.String, System.Object>) = "AdditionalAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valueExpression (x: System.Linq.Expressions.Expression<System.Func<'TItemValue>>) = "ValueExpression" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valuesExpression (x: System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.IEnumerable<'TItemValue>>>) = "ValuesExpression" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline size (x: System.String) = "Size" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline cultureInfo (x: System.Globalization.CultureInfo) = "CultureInfo" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type simpleSelect<'FunBlazorGeneric> =
    inherit select<'FunBlazorGeneric, System.String, System.String>
    static member inline create () = [] |> html.blazor<AntDesign.SimpleSelect>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.SimpleSelect>

    static member inline ref x = attr.ref x
    static member inline allowClear (x: System.Boolean) = "AllowClear" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline autoClearSearchValue (x: System.Boolean) = "AutoClearSearchValue" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline bordered (x: System.Boolean) = "Bordered" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onCreateCustomTag (x: System.Action<System.String>) = "OnCreateCustomTag" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline defaultActiveFirstOption (x: System.Boolean) = "DefaultActiveFirstOption" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabled (x: System.Boolean) = "Disabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabledName (x: System.String) = "DisabledName" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline dropdownRender (x: System.Func<Microsoft.AspNetCore.Components.RenderFragment, Microsoft.AspNetCore.Components.RenderFragment>) = "DropdownRender" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline enableSearch (x: System.Boolean) = "EnableSearch" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline groupName (x: System.String) = "GroupName" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline hideSelected (x: System.Boolean) = "HideSelected" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline ignoreItemChanges (x: System.Boolean) = "IgnoreItemChanges" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline itemTemplate (render: System.String -> FunBlazorNode) = Bolero.Html.attr.fragmentWith "ItemTemplate" (fun x -> render x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline labelInValue (x: System.Boolean) = "LabelInValue" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline labelName (x: System.String) = "LabelName" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline labelTemplate (render: System.String -> FunBlazorNode) = Bolero.Html.attr.fragmentWith "LabelTemplate" (fun x -> render x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline loading (x: System.Boolean) = "Loading" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline maxTagTextLength (x: System.Int32) = "MaxTagTextLength" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline maxTagCount (x: OneOf.OneOf<System.Int32, AntDesign.Select.ResponsiveTag>) = "MaxTagCount" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline maxTagPlaceholder (render: System.Collections.Generic.IEnumerable<System.String> -> FunBlazorNode) = Bolero.Html.attr.fragmentWith "MaxTagPlaceholder" (fun x -> render x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline mode (x: System.String) = "Mode" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline notFoundContent (x: string) = Bolero.Html.attr.fragment "NotFoundContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline notFoundContent (node) = Bolero.Html.attr.fragment "NotFoundContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline notFoundContent (nodes) = Bolero.Html.attr.fragment "NotFoundContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onBlur (x: System.Action) = "OnBlur" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onClearSelected (x: System.Action) = "OnClearSelected" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onDataSourceChanged (x: System.Action) = "OnDataSourceChanged" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onDropdownVisibleChange (x: System.Action<System.Boolean>) = "OnDropdownVisibleChange" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onFocus (x: System.Action) = "OnFocus" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onMouseEnter (x: System.Action) = "OnMouseEnter" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onMouseLeave (x: System.Action) = "OnMouseLeave" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onSearch (x: System.Action<System.String>) = "OnSearch" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onSelectedItemChanged (x: System.Action<System.String>) = "OnSelectedItemChanged" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onSelectedItemsChanged (x: System.Action<System.Collections.Generic.IEnumerable<System.String>>) = "OnSelectedItemsChanged" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline open' (x: System.Boolean) = "Open" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline placeholder (x: System.String) = "Placeholder" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline popupContainerMaxHeight (x: System.String) = "PopupContainerMaxHeight" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline popupContainerSelector (x: System.String) = "PopupContainerSelector" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline dropdownMatchSelectWidth (x: OneOf.OneOf<System.Boolean, System.String>) = "DropdownMatchSelectWidth" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline dropdownMaxWidth (x: System.String) = "DropdownMaxWidth" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline showArrowIcon (x: System.Boolean) = "ShowArrowIcon" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline showSearchIcon (x: System.Boolean) = "ShowSearchIcon" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline sortByGroup (x: AntDesign.SortDirection) = "SortByGroup" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline sortByLabel (x: AntDesign.SortDirection) = "SortByLabel" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline suffixIcon (x: string) = Bolero.Html.attr.fragment "SuffixIcon" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline suffixIcon (node) = Bolero.Html.attr.fragment "SuffixIcon" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline suffixIcon (nodes) = Bolero.Html.attr.fragment "SuffixIcon" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline prefixIcon (x: string) = Bolero.Html.attr.fragment "PrefixIcon" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline prefixIcon (node) = Bolero.Html.attr.fragment "PrefixIcon" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline prefixIcon (nodes) = Bolero.Html.attr.fragment "PrefixIcon" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline tokenSeparators (x: System.Char[]) = "TokenSeparators" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valueChanged fn = (Bolero.Html.attr.callback<System.String> "ValueChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valueName (x: System.String) = "ValueName" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valuesChanged fn = (Bolero.Html.attr.callback<System.Collections.Generic.IEnumerable<System.String>> "ValuesChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline customTagLabelToValue (x: System.Func<System.String, System.String>) = "CustomTagLabelToValue" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline dataSource (x: System.Collections.Generic.IEnumerable<System.String>) = "DataSource" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline value (x: System.String) = "Value" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline defaultValue (x: System.String) = "DefaultValue" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline values (x: System.Collections.Generic.IEnumerable<System.String>) = "Values" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline defaultValues (x: System.Collections.Generic.IEnumerable<System.String>) = "DefaultValues" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline selectOptions (x: string) = Bolero.Html.attr.fragment "SelectOptions" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline selectOptions (node) = Bolero.Html.attr.fragment "SelectOptions" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline selectOptions (nodes) = Bolero.Html.attr.fragment "SelectOptions" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline additionalAttributes (x: System.Collections.Generic.IReadOnlyDictionary<System.String, System.Object>) = "AdditionalAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valueExpression (x: System.Linq.Expressions.Expression<System.Func<System.String>>) = "ValueExpression" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valuesExpression (x: System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.IEnumerable<System.String>>>) = "ValuesExpression" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline size (x: System.String) = "Size" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline cultureInfo (x: System.Globalization.CultureInfo) = "CultureInfo" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type slider<'FunBlazorGeneric, 'TValue> =
    inherit antInputComponentBase<'FunBlazorGeneric, 'TValue>
    static member inline create () = [] |> html.blazor<AntDesign.Slider<'TValue>>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.Slider<'TValue>>

    static member inline ref x = attr.ref x
    static member inline defaultValue (x: 'TValue) = "DefaultValue" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabled (x: System.Boolean) = "Disabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline dots (x: System.Boolean) = "Dots" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline included (x: System.Boolean) = "Included" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline marks (x: AntDesign.SliderMark[]) = "Marks" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline max (x: System.Double) = "Max" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline min (x: System.Double) = "Min" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline reverse (x: System.Boolean) = "Reverse" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline step (x: System.Nullable<System.Double>) = "Step" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline vertical (x: System.Boolean) = "Vertical" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onAfterChange (x: System.Action<'TValue>) = "OnAfterChange" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onChange (x: System.Action<'TValue>) = "OnChange" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline hasTooltip (x: System.Boolean) = "HasTooltip" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline tipFormatter (x: System.Func<System.Double, System.String>) = "TipFormatter" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline tooltipPlacement (x: AntDesign.PlacementType) = "TooltipPlacement" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline tooltipVisible (x: System.Boolean) = "TooltipVisible" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline getTooltipPopupContainer (x: System.Object) = "GetTooltipPopupContainer" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline value (x: 'TValue) = "Value" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline additionalAttributes (x: System.Collections.Generic.IReadOnlyDictionary<System.String, System.Object>) = "AdditionalAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valueChanged fn = (Bolero.Html.attr.callback<'TValue> "ValueChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valueExpression (x: System.Linq.Expressions.Expression<System.Func<'TValue>>) = "ValueExpression" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valuesExpression (x: System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.IEnumerable<'TValue>>>) = "ValuesExpression" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline size (x: System.String) = "Size" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline cultureInfo (x: System.Globalization.CultureInfo) = "CultureInfo" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type descriptions<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = [] |> html.blazor<AntDesign.Descriptions>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.Descriptions>
    static member inline create (nodes: FunBlazorNode list) = nodes |> html.blazor<AntDesign.Descriptions>
    static member inline create (node: FunBlazorNode) = [ node ] |> html.blazor<AntDesign.Descriptions>
    static member inline ref x = attr.ref x
    static member inline bordered (x: System.Boolean) = "Bordered" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline layout (x: System.String) = "Layout" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline column (x: OneOf.OneOf<System.Int32, System.Collections.Generic.Dictionary<System.String, System.Int32>>) = "Column" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline size (x: System.String) = "Size" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline title (x: System.String) = "Title" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline titleTemplate (x: string) = Bolero.Html.attr.fragment "TitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline titleTemplate (node) = Bolero.Html.attr.fragment "TitleTemplate" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline titleTemplate (nodes) = Bolero.Html.attr.fragment "TitleTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline colon (x: System.Boolean) = "Colon" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type descriptionsItem<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = [] |> html.blazor<AntDesign.DescriptionsItem>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.DescriptionsItem>
    static member inline create (nodes: FunBlazorNode list) = nodes |> html.blazor<AntDesign.DescriptionsItem>
    static member inline create (node: FunBlazorNode) = [ node ] |> html.blazor<AntDesign.DescriptionsItem>
    static member inline ref x = attr.ref x
    static member inline title (x: System.String) = "Title" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline titleTemplate (x: string) = Bolero.Html.attr.fragment "TitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline titleTemplate (node) = Bolero.Html.attr.fragment "TitleTemplate" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline titleTemplate (nodes) = Bolero.Html.attr.fragment "TitleTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline span (x: System.Int32) = "Span" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type divider<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = [] |> html.blazor<AntDesign.Divider>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.Divider>
    static member inline create (nodes: FunBlazorNode list) = nodes |> html.blazor<AntDesign.Divider>
    static member inline create (node: FunBlazorNode) = [ node ] |> html.blazor<AntDesign.Divider>
    static member inline ref x = attr.ref x
    static member inline childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline text (x: System.String) = "Text" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline plain (x: System.Boolean) = "Plain" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline type' (x: AntDesign.DirectionVHType) = "Type" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline orientation (x: System.String) = "Orientation" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline dashed (x: System.Boolean) = "Dashed" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type drawer<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = [] |> html.blazor<AntDesign.Drawer>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.Drawer>
    static member inline create (nodes: FunBlazorNode list) = nodes |> html.blazor<AntDesign.Drawer>
    static member inline create (node: FunBlazorNode) = [ node ] |> html.blazor<AntDesign.Drawer>
    static member inline ref x = attr.ref x
    static member inline childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline content (x: OneOf.OneOf<Microsoft.AspNetCore.Components.RenderFragment, System.String>) = "Content" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline closable (x: System.Boolean) = "Closable" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline maskClosable (x: System.Boolean) = "MaskClosable" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline mask (x: System.Boolean) = "Mask" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline noAnimation (x: System.Boolean) = "NoAnimation" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline keyboard (x: System.Boolean) = "Keyboard" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline title (x: OneOf.OneOf<Microsoft.AspNetCore.Components.RenderFragment, System.String>) = "Title" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline placement (x: System.String) = "Placement" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline maskStyle (x: System.String) = "MaskStyle" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline bodyStyle (x: System.String) = "BodyStyle" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline wrapClassName (x: System.String) = "WrapClassName" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline width (x: System.Int32) = "Width" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline height (x: System.Int32) = "Height" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline zIndex (x: System.Int32) = "ZIndex" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline offsetX (x: System.Int32) = "OffsetX" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline offsetY (x: System.Int32) = "OffsetY" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline visible (x: System.Boolean) = "Visible" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onClose (x: Microsoft.AspNetCore.Components.EventCallback) = "OnClose" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline handler (x: string) = Bolero.Html.attr.fragment "Handler" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline handler (node) = Bolero.Html.attr.fragment "Handler" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline handler (nodes) = Bolero.Html.attr.fragment "Handler" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type drawerContainer<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = [] |> html.blazor<AntDesign.DrawerContainer>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.DrawerContainer>

    static member inline ref x = attr.ref x
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type empty<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = [] |> html.blazor<AntDesign.Empty>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.Empty>
    static member inline create (nodes: FunBlazorNode list) = nodes |> html.blazor<AntDesign.Empty>
    static member inline create (node: FunBlazorNode) = [ node ] |> html.blazor<AntDesign.Empty>
    static member inline ref x = attr.ref x
    static member inline prefixCls (x: System.String) = "PrefixCls" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline imageStyle (x: System.String) = "ImageStyle" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline small (x: System.Boolean) = "Small" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline simple (x: System.Boolean) = "Simple" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline description (x: OneOf.OneOf<System.String, System.Nullable<System.Boolean>>) = "Description" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline descriptionTemplate (x: string) = Bolero.Html.attr.fragment "DescriptionTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline descriptionTemplate (node) = Bolero.Html.attr.fragment "DescriptionTemplate" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline descriptionTemplate (nodes) = Bolero.Html.attr.fragment "DescriptionTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline image (x: System.String) = "Image" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline imageTemplate (x: string) = Bolero.Html.attr.fragment "ImageTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline imageTemplate (node) = Bolero.Html.attr.fragment "ImageTemplate" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline imageTemplate (nodes) = Bolero.Html.attr.fragment "ImageTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type form<'FunBlazorGeneric, 'TModel> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = [] |> html.blazor<AntDesign.Form<'TModel>>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.Form<'TModel>>
    static member inline create (nodes: FunBlazorNode list) = nodes |> html.blazor<AntDesign.Form<'TModel>>
    static member inline create (node: FunBlazorNode) = [ node ] |> html.blazor<AntDesign.Form<'TModel>>
    static member inline ref x = attr.ref x
    static member inline layout (x: System.String) = "Layout" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (render: 'TModel -> FunBlazorNode) = Bolero.Html.attr.fragmentWith "ChildContent" (fun x -> render x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline labelCol (x: AntDesign.ColLayoutParam) = "LabelCol" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline labelAlign (x: System.Nullable<AntDesign.AntLabelAlignType>) = "LabelAlign" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline labelColSpan (x: OneOf.OneOf<System.String, System.Int32>) = "LabelColSpan" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline labelColOffset (x: OneOf.OneOf<System.String, System.Int32>) = "LabelColOffset" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline wrapperCol (x: AntDesign.ColLayoutParam) = "WrapperCol" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline wrapperColSpan (x: OneOf.OneOf<System.String, System.Int32>) = "WrapperColSpan" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline wrapperColOffset (x: OneOf.OneOf<System.String, System.Int32>) = "WrapperColOffset" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline size (x: System.String) = "Size" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline name (x: System.String) = "Name" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline model (x: 'TModel) = "Model" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline loading (x: System.Boolean) = "Loading" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onFinish fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Forms.EditContext> "OnFinish" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onFinishFailed fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Forms.EditContext> "OnFinishFailed" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline validator (x: string) = Bolero.Html.attr.fragment "Validator" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline validator (node) = Bolero.Html.attr.fragment "Validator" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline validator (nodes) = Bolero.Html.attr.fragment "Validator" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline validateOnChange (x: System.Boolean) = "ValidateOnChange" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type formItem<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = [] |> html.blazor<AntDesign.FormItem>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.FormItem>
    static member inline create (nodes: FunBlazorNode list) = nodes |> html.blazor<AntDesign.FormItem>
    static member inline create (node: FunBlazorNode) = [ node ] |> html.blazor<AntDesign.FormItem>
    static member inline ref x = attr.ref x
    static member inline childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline label (x: System.String) = "Label" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline labelTemplate (x: string) = Bolero.Html.attr.fragment "LabelTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline labelTemplate (node) = Bolero.Html.attr.fragment "LabelTemplate" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline labelTemplate (nodes) = Bolero.Html.attr.fragment "LabelTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline labelCol (x: AntDesign.ColLayoutParam) = "LabelCol" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline labelAlign (x: System.Nullable<AntDesign.AntLabelAlignType>) = "LabelAlign" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline labelColSpan (x: OneOf.OneOf<System.String, System.Int32>) = "LabelColSpan" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline labelColOffset (x: OneOf.OneOf<System.String, System.Int32>) = "LabelColOffset" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline wrapperCol (x: AntDesign.ColLayoutParam) = "WrapperCol" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline wrapperColSpan (x: OneOf.OneOf<System.String, System.Int32>) = "WrapperColSpan" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline wrapperColOffset (x: OneOf.OneOf<System.String, System.Int32>) = "WrapperColOffset" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline noStyle (x: System.Boolean) = "NoStyle" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline required (x: System.Boolean) = "Required" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type col<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = [] |> html.blazor<AntDesign.Col>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.Col>
    static member inline create (nodes: FunBlazorNode list) = nodes |> html.blazor<AntDesign.Col>
    static member inline create (node: FunBlazorNode) = [ node ] |> html.blazor<AntDesign.Col>
    static member inline ref x = attr.ref x
    static member inline childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline flex (x: OneOf.OneOf<System.String, System.Int32>) = "Flex" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline span (x: OneOf.OneOf<System.String, System.Int32>) = "Span" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline order (x: OneOf.OneOf<System.String, System.Int32>) = "Order" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline offset (x: OneOf.OneOf<System.String, System.Int32>) = "Offset" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline push (x: OneOf.OneOf<System.String, System.Int32>) = "Push" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline pull (x: OneOf.OneOf<System.String, System.Int32>) = "Pull" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline xs (x: OneOf.OneOf<System.Int32, AntDesign.EmbeddedProperty>) = "Xs" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline sm (x: OneOf.OneOf<System.Int32, AntDesign.EmbeddedProperty>) = "Sm" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline md (x: OneOf.OneOf<System.Int32, AntDesign.EmbeddedProperty>) = "Md" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline lg (x: OneOf.OneOf<System.Int32, AntDesign.EmbeddedProperty>) = "Lg" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline xl (x: OneOf.OneOf<System.Int32, AntDesign.EmbeddedProperty>) = "Xl" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline xxl (x: OneOf.OneOf<System.Int32, AntDesign.EmbeddedProperty>) = "Xxl" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type gridCol<'FunBlazorGeneric> =
    inherit col<'FunBlazorGeneric>
    static member inline create () = [] |> html.blazor<AntDesign.GridCol>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.GridCol>
    static member inline create (nodes: FunBlazorNode list) = nodes |> html.blazor<AntDesign.GridCol>
    static member inline create (node: FunBlazorNode) = [ node ] |> html.blazor<AntDesign.GridCol>
    static member inline ref x = attr.ref x
    static member inline childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline flex (x: OneOf.OneOf<System.String, System.Int32>) = "Flex" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline span (x: OneOf.OneOf<System.String, System.Int32>) = "Span" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline order (x: OneOf.OneOf<System.String, System.Int32>) = "Order" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline offset (x: OneOf.OneOf<System.String, System.Int32>) = "Offset" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline push (x: OneOf.OneOf<System.String, System.Int32>) = "Push" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline pull (x: OneOf.OneOf<System.String, System.Int32>) = "Pull" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline xs (x: OneOf.OneOf<System.Int32, AntDesign.EmbeddedProperty>) = "Xs" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline sm (x: OneOf.OneOf<System.Int32, AntDesign.EmbeddedProperty>) = "Sm" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline md (x: OneOf.OneOf<System.Int32, AntDesign.EmbeddedProperty>) = "Md" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline lg (x: OneOf.OneOf<System.Int32, AntDesign.EmbeddedProperty>) = "Lg" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline xl (x: OneOf.OneOf<System.Int32, AntDesign.EmbeddedProperty>) = "Xl" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline xxl (x: OneOf.OneOf<System.Int32, AntDesign.EmbeddedProperty>) = "Xxl" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type row<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = [] |> html.blazor<AntDesign.Row>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.Row>
    static member inline create (nodes: FunBlazorNode list) = nodes |> html.blazor<AntDesign.Row>
    static member inline create (node: FunBlazorNode) = [ node ] |> html.blazor<AntDesign.Row>
    static member inline ref x = attr.ref x
    static member inline childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline type' (x: System.String) = "Type" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline align (x: System.String) = "Align" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline justify (x: System.String) = "Justify" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline wrap (x: System.Boolean) = "Wrap" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline gutter (x: OneOf.OneOf<System.Int32, System.Collections.Generic.Dictionary<System.String, System.Int32>, System.ValueTuple<System.Int32, System.Int32>, System.ValueTuple<System.Collections.Generic.Dictionary<System.String, System.Int32>, System.Int32>, System.ValueTuple<System.Int32, System.Collections.Generic.Dictionary<System.String, System.Int32>>, System.ValueTuple<System.Collections.Generic.Dictionary<System.String, System.Int32>, System.Collections.Generic.Dictionary<System.String, System.Int32>>>) = "Gutter" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onBreakpoint fn = (Bolero.Html.attr.callback<AntDesign.BreakpointType> "OnBreakpoint" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline defaultBreakpoint (x: AntDesign.BreakpointType) = "DefaultBreakpoint" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type icon<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = [] |> html.blazor<AntDesign.Icon>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.Icon>

    static member inline ref x = attr.ref x
    static member inline spin (x: System.Boolean) = "Spin" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline rotate (x: System.Int32) = "Rotate" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline type' (x: System.String) = "Type" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline theme (x: System.String) = "Theme" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline twotoneColor (x: System.String) = "TwotoneColor" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline iconFont (x: System.String) = "IconFont" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline width (x: System.String) = "Width" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline height (x: System.String) = "Height" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline fill (x: System.String) = "Fill" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline tabIndex (x: System.String) = "TabIndex" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline stopPropagation (x: System.Boolean) = "StopPropagation" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onClick fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnClick" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline component' (x: string) = Bolero.Html.attr.fragment "Component" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline component' (node) = Bolero.Html.attr.fragment "Component" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline component' (nodes) = Bolero.Html.attr.fragment "Component" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type iconFont<'FunBlazorGeneric> =
    inherit icon<'FunBlazorGeneric>
    static member inline create () = [] |> html.blazor<AntDesign.IconFont>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.IconFont>

    static member inline ref x = attr.ref x
    static member inline spin (x: System.Boolean) = "Spin" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline rotate (x: System.Int32) = "Rotate" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline type' (x: System.String) = "Type" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline theme (x: System.String) = "Theme" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline twotoneColor (x: System.String) = "TwotoneColor" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline iconFont (x: System.String) = "IconFont" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline width (x: System.String) = "Width" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline height (x: System.String) = "Height" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline fill (x: System.String) = "Fill" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline tabIndex (x: System.String) = "TabIndex" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline stopPropagation (x: System.Boolean) = "StopPropagation" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onClick fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnClick" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline component' (x: string) = Bolero.Html.attr.fragment "Component" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline component' (node) = Bolero.Html.attr.fragment "Component" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline component' (nodes) = Bolero.Html.attr.fragment "Component" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type image<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = [] |> html.blazor<AntDesign.Image>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.Image>

    static member inline ref x = attr.ref x
    static member inline alt (x: System.String) = "Alt" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline fallback (x: System.String) = "Fallback" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline height (x: System.String) = "Height" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline width (x: System.String) = "Width" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline placeholder (x: string) = Bolero.Html.attr.fragment "Placeholder" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline placeholder (node) = Bolero.Html.attr.fragment "Placeholder" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline placeholder (nodes) = Bolero.Html.attr.fragment "Placeholder" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline preview (x: System.Boolean) = "Preview" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline src (x: System.String) = "Src" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline previewSrc (x: System.String) = "PreviewSrc" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline locale (x: AntDesign.ImageLocale) = "Locale" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type imagePreviewContainer<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = [] |> html.blazor<AntDesign.ImagePreviewContainer>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.ImagePreviewContainer>

    static member inline ref x = attr.ref x
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type inputGroup<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = [] |> html.blazor<AntDesign.InputGroup>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.InputGroup>
    static member inline create (nodes: FunBlazorNode list) = nodes |> html.blazor<AntDesign.InputGroup>
    static member inline create (node: FunBlazorNode) = [ node ] |> html.blazor<AntDesign.InputGroup>
    static member inline ref x = attr.ref x
    static member inline childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline compact (x: System.Boolean) = "Compact" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline size (x: System.String) = "Size" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type sider<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = [] |> html.blazor<AntDesign.Sider>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.Sider>
    static member inline create (nodes: FunBlazorNode list) = nodes |> html.blazor<AntDesign.Sider>
    static member inline create (node: FunBlazorNode) = [ node ] |> html.blazor<AntDesign.Sider>
    static member inline ref x = attr.ref x
    static member inline collapsible (x: System.Boolean) = "Collapsible" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline trigger (x: string) = Bolero.Html.attr.fragment "Trigger" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline trigger (node) = Bolero.Html.attr.fragment "Trigger" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline trigger (nodes) = Bolero.Html.attr.fragment "Trigger" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline noTrigger (x: System.Boolean) = "NoTrigger" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline breakpoint (x: AntDesign.BreakpointType) = "Breakpoint" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline theme (x: AntDesign.SiderTheme) = "Theme" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline width (x: System.Int32) = "Width" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline collapsedWidth (x: System.Int32) = "CollapsedWidth" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline collapsed (x: System.Boolean) = "Collapsed" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onCollapse fn = (Bolero.Html.attr.callback<System.Boolean> "OnCollapse" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onBreakpoint fn = (Bolero.Html.attr.callback<System.Boolean> "OnBreakpoint" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type antList<'FunBlazorGeneric, 'TItem> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = [] |> html.blazor<AntDesign.AntList<'TItem>>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.AntList<'TItem>>
    static member inline create (nodes: FunBlazorNode list) = nodes |> html.blazor<AntDesign.AntList<'TItem>>
    static member inline create (node: FunBlazorNode) = [ node ] |> html.blazor<AntDesign.AntList<'TItem>>
    static member inline ref x = attr.ref x
    static member inline dataSource (x: System.Collections.Generic.IEnumerable<'TItem>) = "DataSource" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline bordered (x: System.Boolean) = "Bordered" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline header (x: string) = Bolero.Html.attr.fragment "Header" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline header (node) = Bolero.Html.attr.fragment "Header" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline header (nodes) = Bolero.Html.attr.fragment "Header" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline footer (x: string) = Bolero.Html.attr.fragment "Footer" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline footer (node) = Bolero.Html.attr.fragment "Footer" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline footer (nodes) = Bolero.Html.attr.fragment "Footer" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline loadMore (x: string) = Bolero.Html.attr.fragment "LoadMore" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline loadMore (node) = Bolero.Html.attr.fragment "LoadMore" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline loadMore (nodes) = Bolero.Html.attr.fragment "LoadMore" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline itemLayout (x: AntDesign.ListItemLayout) = "ItemLayout" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline loading (x: System.Boolean) = "Loading" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline noResult (x: System.String) = "NoResult" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline size (x: System.String) = "Size" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline split (x: System.Boolean) = "Split" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onItemClick fn = (Bolero.Html.attr.callback<'TItem> "OnItemClick" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline grid (x: AntDesign.ListGridType) = "Grid" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline pagination (x: AntDesign.PaginationOptions) = "Pagination" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (render: 'TItem -> FunBlazorNode) = Bolero.Html.attr.fragmentWith "ChildContent" (fun x -> render x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type listItem<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = [] |> html.blazor<AntDesign.ListItem>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.ListItem>
    static member inline create (nodes: FunBlazorNode list) = nodes |> html.blazor<AntDesign.ListItem>
    static member inline create (node: FunBlazorNode) = [ node ] |> html.blazor<AntDesign.ListItem>
    static member inline ref x = attr.ref x
    static member inline content (x: System.String) = "Content" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline extra (x: string) = Bolero.Html.attr.fragment "Extra" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline extra (node) = Bolero.Html.attr.fragment "Extra" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline extra (nodes) = Bolero.Html.attr.fragment "Extra" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline actions (x: Microsoft.AspNetCore.Components.RenderFragment[]) = "Actions" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline grid (x: AntDesign.ListGridType) = "Grid" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline colStyle (x: System.String) = "ColStyle" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline itemCount (x: System.Int32) = "ItemCount" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onClick (x: Microsoft.AspNetCore.Components.EventCallback) = "OnClick" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline noFlex (x: System.Boolean) = "NoFlex" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type listItemMeta<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = [] |> html.blazor<AntDesign.ListItemMeta>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.ListItemMeta>

    static member inline ref x = attr.ref x
    static member inline title (x: System.String) = "Title" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline titleTemplate (x: string) = Bolero.Html.attr.fragment "TitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline titleTemplate (node) = Bolero.Html.attr.fragment "TitleTemplate" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline titleTemplate (nodes) = Bolero.Html.attr.fragment "TitleTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline avatar (x: System.String) = "Avatar" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline avatarTemplate (x: string) = Bolero.Html.attr.fragment "AvatarTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline avatarTemplate (node) = Bolero.Html.attr.fragment "AvatarTemplate" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline avatarTemplate (nodes) = Bolero.Html.attr.fragment "AvatarTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline description (x: System.String) = "Description" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline descriptionTemplate (x: string) = Bolero.Html.attr.fragment "DescriptionTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline descriptionTemplate (node) = Bolero.Html.attr.fragment "DescriptionTemplate" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline descriptionTemplate (nodes) = Bolero.Html.attr.fragment "DescriptionTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type mentions<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = [] |> html.blazor<AntDesign.Mentions>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.Mentions>
    static member inline create (nodes: FunBlazorNode list) = nodes |> html.blazor<AntDesign.Mentions>
    static member inline create (node: FunBlazorNode) = [ node ] |> html.blazor<AntDesign.Mentions>
    static member inline ref x = attr.ref x
    static member inline autoFocus (x: System.Boolean) = "AutoFocus" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disable (x: System.Boolean) = "Disable" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline readonly (x: System.Boolean) = "Readonly" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline prefix (x: System.String) = "Prefix" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline split (x: System.String) = "Split" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline defaultValue (x: System.String) = "DefaultValue" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline placeholder (x: System.String) = "Placeholder" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline value (x: System.String) = "Value" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline placement (x: System.String) = "Placement" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline rows (x: System.Int32) = "Rows" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline loading (x: System.Boolean) = "Loading" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valueChange fn = (Bolero.Html.attr.callback<System.String> "ValueChange" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onFocus fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.FocusEventArgs> "OnFocus" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onBlur fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.FocusEventArgs> "OnBlur" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onSearch fn = (Bolero.Html.attr.callback<System.EventArgs> "OnSearch" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline noFoundContent (x: string) = Bolero.Html.attr.fragment "NoFoundContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline noFoundContent (node) = Bolero.Html.attr.fragment "NoFoundContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline noFoundContent (nodes) = Bolero.Html.attr.fragment "NoFoundContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type mentionsOption<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = [] |> html.blazor<AntDesign.MentionsOption>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.MentionsOption>
    static member inline create (nodes: FunBlazorNode list) = nodes |> html.blazor<AntDesign.MentionsOption>
    static member inline create (node: FunBlazorNode) = [ node ] |> html.blazor<AntDesign.MentionsOption>
    static member inline ref x = attr.ref x
    static member inline value (x: System.String) = "Value" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disable (x: System.Boolean) = "Disable" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type menu<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = [] |> html.blazor<AntDesign.Menu>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.Menu>
    static member inline create (nodes: FunBlazorNode list) = nodes |> html.blazor<AntDesign.Menu>
    static member inline create (node: FunBlazorNode) = [ node ] |> html.blazor<AntDesign.Menu>
    static member inline ref x = attr.ref x
    static member inline theme (x: AntDesign.MenuTheme) = "Theme" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline mode (x: AntDesign.MenuMode) = "Mode" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onSubmenuClicked fn = (Bolero.Html.attr.callback<AntDesign.SubMenu> "OnSubmenuClicked" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onMenuItemClicked fn = (Bolero.Html.attr.callback<AntDesign.MenuItem> "OnMenuItemClicked" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline accordion (x: System.Boolean) = "Accordion" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline selectable (x: System.Boolean) = "Selectable" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline multiple (x: System.Boolean) = "Multiple" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline inlineCollapsed (x: System.Boolean) = "InlineCollapsed" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline inlineIndent (x: System.Int32) = "InlineIndent" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline autoCloseDropdown (x: System.Boolean) = "AutoCloseDropdown" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline defaultSelectedKeys (x: System.Collections.Generic.IEnumerable<System.String>) = "DefaultSelectedKeys" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline defaultOpenKeys (x: System.Collections.Generic.IEnumerable<System.String>) = "DefaultOpenKeys" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline openKeys (x: System.String[]) = "OpenKeys" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline openKeysChanged fn = (Bolero.Html.attr.callback<System.String[]> "OpenKeysChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onOpenChange fn = (Bolero.Html.attr.callback<System.String[]> "OnOpenChange" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline selectedKeys (x: System.String[]) = "SelectedKeys" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline selectedKeysChanged fn = (Bolero.Html.attr.callback<System.String[]> "SelectedKeysChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline triggerSubMenuAction (x: AntDesign.TriggerType) = "TriggerSubMenuAction" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type menuItem<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = [] |> html.blazor<AntDesign.MenuItem>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.MenuItem>
    static member inline create (nodes: FunBlazorNode list) = nodes |> html.blazor<AntDesign.MenuItem>
    static member inline create (node: FunBlazorNode) = [ node ] |> html.blazor<AntDesign.MenuItem>
    static member inline ref x = attr.ref x
    static member inline childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline key (x: System.String) = "Key" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabled (x: System.Boolean) = "Disabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onClick fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnClick" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline routerLink (x: System.String) = "RouterLink" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline routerMatch (x: Microsoft.AspNetCore.Components.Routing.NavLinkMatch) = "RouterMatch" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline title (x: System.String) = "Title" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline icon (x: System.String) = "Icon" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type menuItemGroup<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = [] |> html.blazor<AntDesign.MenuItemGroup>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.MenuItemGroup>
    static member inline create (nodes: FunBlazorNode list) = nodes |> html.blazor<AntDesign.MenuItemGroup>
    static member inline create (node: FunBlazorNode) = [ node ] |> html.blazor<AntDesign.MenuItemGroup>
    static member inline ref x = attr.ref x
    static member inline title (x: System.String) = "Title" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline titleTemplate (x: string) = Bolero.Html.attr.fragment "TitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline titleTemplate (node) = Bolero.Html.attr.fragment "TitleTemplate" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline titleTemplate (nodes) = Bolero.Html.attr.fragment "TitleTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline key (x: System.String) = "Key" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type menuLink<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = [] |> html.blazor<AntDesign.MenuLink>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.MenuLink>
    static member inline create (nodes: FunBlazorNode list) = nodes |> html.blazor<AntDesign.MenuLink>
    static member inline create (node: FunBlazorNode) = [ node ] |> html.blazor<AntDesign.MenuLink>
    static member inline ref x = attr.ref x
    static member inline activeClass (x: System.String) = "ActiveClass" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline href (x: System.String) = "Href" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline attributes (x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "Attributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline match' (x: Microsoft.AspNetCore.Components.Routing.NavLinkMatch) = "Match" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type subMenu<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = [] |> html.blazor<AntDesign.SubMenu>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.SubMenu>
    static member inline create (nodes: FunBlazorNode list) = nodes |> html.blazor<AntDesign.SubMenu>
    static member inline create (node: FunBlazorNode) = [ node ] |> html.blazor<AntDesign.SubMenu>
    static member inline ref x = attr.ref x
    static member inline placement (x: AntDesign.PlacementType) = "Placement" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline title (x: System.String) = "Title" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline titleTemplate (x: string) = Bolero.Html.attr.fragment "TitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline titleTemplate (node) = Bolero.Html.attr.fragment "TitleTemplate" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline titleTemplate (nodes) = Bolero.Html.attr.fragment "TitleTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline key (x: System.String) = "Key" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabled (x: System.Boolean) = "Disabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline isOpen (x: System.Boolean) = "IsOpen" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onTitleClick fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnTitleClick" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type message<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = [] |> html.blazor<AntDesign.Message>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.Message>

    static member inline ref x = attr.ref x
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type messageItem<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = [] |> html.blazor<AntDesign.MessageItem>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.MessageItem>

    static member inline ref x = attr.ref x
    static member inline config (x: AntDesign.MessageConfig) = "Config" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type comfirmContainer<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = [] |> html.blazor<AntDesign.ComfirmContainer>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.ComfirmContainer>

    static member inline ref x = attr.ref x
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type confirm<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = [] |> html.blazor<AntDesign.Confirm>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.Confirm>

    static member inline ref x = attr.ref x
    static member inline config (x: AntDesign.ConfirmOptions) = "Config" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline confirmRef (x: AntDesign.ConfirmRef) = "ConfirmRef" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onRemove fn = (Bolero.Html.attr.callback<AntDesign.ConfirmRef> "OnRemove" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type dialog<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = [] |> html.blazor<AntDesign.Dialog>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.Dialog>
    static member inline create (nodes: FunBlazorNode list) = nodes |> html.blazor<AntDesign.Dialog>
    static member inline create (node: FunBlazorNode) = [ node ] |> html.blazor<AntDesign.Dialog>
    static member inline ref x = attr.ref x
    static member inline config (x: AntDesign.DialogOptions) = "Config" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline visible (x: System.Boolean) = "Visible" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type dialogWrapper<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = [] |> html.blazor<AntDesign.DialogWrapper>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.DialogWrapper>
    static member inline create (nodes: FunBlazorNode list) = nodes |> html.blazor<AntDesign.DialogWrapper>
    static member inline create (node: FunBlazorNode) = [ node ] |> html.blazor<AntDesign.DialogWrapper>
    static member inline ref x = attr.ref x
    static member inline config (x: AntDesign.DialogOptions) = "Config" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline destroyOnClose (x: System.Boolean) = "DestroyOnClose" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline visible (x: System.Boolean) = "Visible" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onBeforeDestroy fn = (Bolero.Html.attr.callback<System.ComponentModel.CancelEventArgs> "OnBeforeDestroy" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onAfterShow (x: Microsoft.AspNetCore.Components.EventCallback) = "OnAfterShow" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onAfterHide (x: Microsoft.AspNetCore.Components.EventCallback) = "OnAfterHide" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type modal<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = [] |> html.blazor<AntDesign.Modal>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.Modal>
    static member inline create (nodes: FunBlazorNode list) = nodes |> html.blazor<AntDesign.Modal>
    static member inline create (node: FunBlazorNode) = [ node ] |> html.blazor<AntDesign.Modal>
    static member inline ref x = attr.ref x
    static member inline modalRef (x: AntDesign.ModalRef) = "ModalRef" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline afterClose (x: System.Func<System.Threading.Tasks.Task>) = "AfterClose" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline bodyStyle (x: System.String) = "BodyStyle" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline cancelText (x: System.Nullable<OneOf.OneOf<System.String, Microsoft.AspNetCore.Components.RenderFragment>>) = "CancelText" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline centered (x: System.Boolean) = "Centered" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline closable (x: System.Boolean) = "Closable" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline draggable (x: System.Boolean) = "Draggable" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline dragInViewport (x: System.Boolean) = "DragInViewport" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline closeIcon (x: string) = Bolero.Html.attr.fragment "CloseIcon" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline closeIcon (node) = Bolero.Html.attr.fragment "CloseIcon" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline closeIcon (nodes) = Bolero.Html.attr.fragment "CloseIcon" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline confirmLoading (x: System.Boolean) = "ConfirmLoading" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline destroyOnClose (x: System.Boolean) = "DestroyOnClose" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline footer (x: System.Nullable<OneOf.OneOf<System.String, Microsoft.AspNetCore.Components.RenderFragment>>) = "Footer" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline getContainer (x: System.Nullable<Microsoft.AspNetCore.Components.ElementReference>) = "GetContainer" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline keyboard (x: System.Boolean) = "Keyboard" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline mask (x: System.Boolean) = "Mask" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline maskClosable (x: System.Boolean) = "MaskClosable" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline maskStyle (x: System.String) = "MaskStyle" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline okText (x: System.Nullable<OneOf.OneOf<System.String, Microsoft.AspNetCore.Components.RenderFragment>>) = "OkText" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline okType (x: System.String) = "OkType" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline title (x: System.String) = "Title" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline titleTemplate (x: string) = Bolero.Html.attr.fragment "TitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline titleTemplate (node) = Bolero.Html.attr.fragment "TitleTemplate" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline titleTemplate (nodes) = Bolero.Html.attr.fragment "TitleTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline visible (x: System.Boolean) = "Visible" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline width (x: OneOf.OneOf<System.String, System.Double>) = "Width" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline wrapClassName (x: System.String) = "WrapClassName" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline zIndex (x: System.Int32) = "ZIndex" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onCancel fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnCancel" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onOk fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnOk" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline okButtonProps (x: AntDesign.ButtonProps) = "OkButtonProps" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline cancelButtonProps (x: AntDesign.ButtonProps) = "CancelButtonProps" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline locale (x: AntDesign.ModalLocale) = "Locale" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type modalContainer<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = [] |> html.blazor<AntDesign.ModalContainer>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.ModalContainer>

    static member inline ref x = attr.ref x
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type modalFooter<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = [] |> html.blazor<AntDesign.ModalFooter>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.ModalFooter>

    static member inline ref x = attr.ref x
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type notificationBase<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = [] |> html.blazor<AntDesign.NotificationBase>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.NotificationBase>

    static member inline ref x = attr.ref x
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type notification<'FunBlazorGeneric> =
    inherit notificationBase<'FunBlazorGeneric>
    static member inline create () = [] |> html.blazor<AntDesign.Notification>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.Notification>

    static member inline ref x = attr.ref x
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type notificationItem<'FunBlazorGeneric> =
    inherit notificationBase<'FunBlazorGeneric>
    static member inline create () = [] |> html.blazor<AntDesign.NotificationItem>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.NotificationItem>

    static member inline ref x = attr.ref x
    static member inline config (x: AntDesign.NotificationConfig) = "Config" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onClose (x: System.Func<AntDesign.NotificationConfig, System.Threading.Tasks.Task>) = "OnClose" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type pageHeader<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = [] |> html.blazor<AntDesign.PageHeader>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.PageHeader>

    static member inline ref x = attr.ref x
    static member inline ghost (x: System.Boolean) = "Ghost" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline backIcon (x: OneOf.OneOf<System.Nullable<System.Boolean>, System.String>) = "BackIcon" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline backIconTemplate (x: string) = Bolero.Html.attr.fragment "BackIconTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline backIconTemplate (node) = Bolero.Html.attr.fragment "BackIconTemplate" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline backIconTemplate (nodes) = Bolero.Html.attr.fragment "BackIconTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline title (x: System.String) = "Title" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline titleTemplate (x: string) = Bolero.Html.attr.fragment "TitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline titleTemplate (node) = Bolero.Html.attr.fragment "TitleTemplate" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline titleTemplate (nodes) = Bolero.Html.attr.fragment "TitleTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline subtitle (x: System.String) = "Subtitle" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline subtitleTemplate (x: string) = Bolero.Html.attr.fragment "SubtitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline subtitleTemplate (node) = Bolero.Html.attr.fragment "SubtitleTemplate" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline subtitleTemplate (nodes) = Bolero.Html.attr.fragment "SubtitleTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onBack (x: Microsoft.AspNetCore.Components.EventCallback) = "OnBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline pageHeaderContent (x: string) = Bolero.Html.attr.fragment "PageHeaderContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline pageHeaderContent (node) = Bolero.Html.attr.fragment "PageHeaderContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline pageHeaderContent (nodes) = Bolero.Html.attr.fragment "PageHeaderContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline pageHeaderFooter (x: string) = Bolero.Html.attr.fragment "PageHeaderFooter" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline pageHeaderFooter (node) = Bolero.Html.attr.fragment "PageHeaderFooter" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline pageHeaderFooter (nodes) = Bolero.Html.attr.fragment "PageHeaderFooter" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline pageHeaderBreadcrumb (x: string) = Bolero.Html.attr.fragment "PageHeaderBreadcrumb" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline pageHeaderBreadcrumb (node) = Bolero.Html.attr.fragment "PageHeaderBreadcrumb" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline pageHeaderBreadcrumb (nodes) = Bolero.Html.attr.fragment "PageHeaderBreadcrumb" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline pageHeaderAvatar (x: string) = Bolero.Html.attr.fragment "PageHeaderAvatar" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline pageHeaderAvatar (node) = Bolero.Html.attr.fragment "PageHeaderAvatar" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline pageHeaderAvatar (nodes) = Bolero.Html.attr.fragment "PageHeaderAvatar" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline pageHeaderTitle (x: string) = Bolero.Html.attr.fragment "PageHeaderTitle" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline pageHeaderTitle (node) = Bolero.Html.attr.fragment "PageHeaderTitle" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline pageHeaderTitle (nodes) = Bolero.Html.attr.fragment "PageHeaderTitle" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline pageHeaderSubtitle (x: string) = Bolero.Html.attr.fragment "PageHeaderSubtitle" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline pageHeaderSubtitle (node) = Bolero.Html.attr.fragment "PageHeaderSubtitle" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline pageHeaderSubtitle (nodes) = Bolero.Html.attr.fragment "PageHeaderSubtitle" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline pageHeaderTags (x: string) = Bolero.Html.attr.fragment "PageHeaderTags" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline pageHeaderTags (node) = Bolero.Html.attr.fragment "PageHeaderTags" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline pageHeaderTags (nodes) = Bolero.Html.attr.fragment "PageHeaderTags" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline pageHeaderExtra (x: string) = Bolero.Html.attr.fragment "PageHeaderExtra" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline pageHeaderExtra (node) = Bolero.Html.attr.fragment "PageHeaderExtra" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline pageHeaderExtra (nodes) = Bolero.Html.attr.fragment "PageHeaderExtra" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type pagination<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = [] |> html.blazor<AntDesign.Pagination>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.Pagination>

    static member inline ref x = attr.ref x
    static member inline total (x: System.Int32) = "Total" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline defaultCurrent (x: System.Int32) = "DefaultCurrent" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabled (x: System.Boolean) = "Disabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline current (x: System.Int32) = "Current" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline defaultPageSize (x: System.Int32) = "DefaultPageSize" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline pageSize (x: System.Int32) = "PageSize" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onChange fn = (Bolero.Html.attr.callback<AntDesign.PaginationEventArgs> "OnChange" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline hideOnSinglePage (x: System.Boolean) = "HideOnSinglePage" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline showSizeChanger (x: System.Boolean) = "ShowSizeChanger" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline pageSizeOptions (x: System.Int32[]) = "PageSizeOptions" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onShowSizeChange fn = (Bolero.Html.attr.callback<AntDesign.PaginationEventArgs> "OnShowSizeChange" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline showQuickJumper (x: System.Boolean) = "ShowQuickJumper" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline goButton (x: string) = Bolero.Html.attr.fragment "GoButton" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline goButton (node) = Bolero.Html.attr.fragment "GoButton" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline goButton (nodes) = Bolero.Html.attr.fragment "GoButton" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline showTitle (x: System.Boolean) = "ShowTitle" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline showTotal (x: System.Nullable<OneOf.OneOf<System.Func<AntDesign.PaginationTotalContext, System.String>, Microsoft.AspNetCore.Components.RenderFragment<AntDesign.PaginationTotalContext>>>) = "ShowTotal" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline size (x: System.String) = "Size" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline responsive (x: System.Boolean) = "Responsive" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline simple (x: System.Boolean) = "Simple" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline locale (x: AntDesign.PaginationLocale) = "Locale" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline itemRender (render: AntDesign.PaginationItemRenderContext -> FunBlazorNode) = Bolero.Html.attr.fragmentWith "ItemRender" (fun x -> render x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline showLessItems (x: System.Boolean) = "ShowLessItems" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline showPrevNextJumpers (x: System.Boolean) = "ShowPrevNextJumpers" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline direction (x: System.String) = "Direction" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline prevIcon (render: AntDesign.PaginationItemRenderContext -> FunBlazorNode) = Bolero.Html.attr.fragmentWith "PrevIcon" (fun x -> render x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline nextIcon (render: AntDesign.PaginationItemRenderContext -> FunBlazorNode) = Bolero.Html.attr.fragmentWith "NextIcon" (fun x -> render x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline jumpPrevIcon (render: AntDesign.PaginationItemRenderContext -> FunBlazorNode) = Bolero.Html.attr.fragmentWith "JumpPrevIcon" (fun x -> render x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline jumpNextIcon (render: AntDesign.PaginationItemRenderContext -> FunBlazorNode) = Bolero.Html.attr.fragmentWith "JumpNextIcon" (fun x -> render x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline totalBoundaryShowSizeChanger (x: System.Int32) = "TotalBoundaryShowSizeChanger" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline unmatchedAttributes (x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UnmatchedAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type paginationOptions<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = [] |> html.blazor<AntDesign.PaginationOptions>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.PaginationOptions>

    static member inline ref x = attr.ref x
    static member inline isSmall (x: System.Boolean) = "IsSmall" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabled (x: System.Boolean) = "Disabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline rootPrefixCls (x: System.String) = "RootPrefixCls" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline changeSize fn = (Bolero.Html.attr.callback<System.Int32> "ChangeSize" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline current (x: System.Int32) = "Current" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline pageSize (x: System.Int32) = "PageSize" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline pageSizeOptions (x: System.Int32[]) = "PageSizeOptions" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline quickGo fn = (Bolero.Html.attr.callback<System.Int32> "QuickGo" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline goButton (x: System.Nullable<OneOf.OneOf<System.Boolean, Microsoft.AspNetCore.Components.RenderFragment>>) = "GoButton" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type progress<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = [] |> html.blazor<AntDesign.Progress>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.Progress>

    static member inline ref x = attr.ref x
    static member inline size (x: AntDesign.ProgressSize) = "Size" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline type' (x: AntDesign.ProgressType) = "Type" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline format (x: System.Func<System.Double, System.String>) = "Format" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline percent (x: System.Double) = "Percent" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline showInfo (x: System.Boolean) = "ShowInfo" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline status (x: AntDesign.ProgressStatus) = "Status" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline strokeLinecap (x: AntDesign.ProgressStrokeLinecap) = "StrokeLinecap" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline successPercent (x: System.Double) = "SuccessPercent" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline trailColor (x: System.String) = "TrailColor" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline strokeWidth (x: System.Int32) = "StrokeWidth" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline strokeColor (x: OneOf.OneOf<System.String, System.Collections.Generic.Dictionary<System.String, System.String>>) = "StrokeColor" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline steps (x: System.Int32) = "Steps" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline width (x: System.Int32) = "Width" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline gapDegree (x: System.Int32) = "GapDegree" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline gapPosition (x: AntDesign.ProgressGapPosition) = "GapPosition" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type radio<'FunBlazorGeneric, 'TValue> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = [] |> html.blazor<AntDesign.Radio<'TValue>>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.Radio<'TValue>>
    static member inline create (nodes: FunBlazorNode list) = nodes |> html.blazor<AntDesign.Radio<'TValue>>
    static member inline create (node: FunBlazorNode) = [ node ] |> html.blazor<AntDesign.Radio<'TValue>>
    static member inline ref x = attr.ref x
    static member inline childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline value (x: 'TValue) = "Value" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline autoFocus (x: System.Boolean) = "AutoFocus" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline radioButton (x: System.Boolean) = "RadioButton" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline checked' (x: System.Boolean) = "Checked" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline defaultChecked (x: System.Boolean) = "DefaultChecked" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline checkedChanged fn = (Bolero.Html.attr.callback<System.Boolean> "CheckedChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabled (x: System.Boolean) = "Disabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline checkedChange fn = (Bolero.Html.attr.callback<System.Boolean> "CheckedChange" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type rate<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = [] |> html.blazor<AntDesign.Rate>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.Rate>
    static member inline create (nodes: FunBlazorNode list) = nodes |> html.blazor<AntDesign.Rate>
    static member inline create (node: FunBlazorNode) = [ node ] |> html.blazor<AntDesign.Rate>
    static member inline ref x = attr.ref x
    static member inline childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline allowClear (x: System.Boolean) = "AllowClear" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline allowHalf (x: System.Boolean) = "AllowHalf" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabled (x: System.Boolean) = "Disabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline autoFocus (x: System.Boolean) = "AutoFocus" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline character (render: AntDesign.RateItemRenderContext -> FunBlazorNode) = Bolero.Html.attr.fragmentWith "Character" (fun x -> render x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline count (x: System.Int32) = "Count" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline value (x: System.Decimal) = "Value" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valueChanged fn = (Bolero.Html.attr.callback<System.Decimal> "ValueChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline defaultValue (x: System.Decimal) = "DefaultValue" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline tooltips (x: System.String[]) = "Tooltips" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onBlur fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.FocusEventArgs> "OnBlur" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onFocus fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.FocusEventArgs> "OnFocus" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type rateItem<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = [] |> html.blazor<AntDesign.RateItem>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.RateItem>

    static member inline ref x = attr.ref x
    static member inline allowHalf (x: System.Boolean) = "AllowHalf" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onItemHover fn = (Bolero.Html.attr.callback<System.Boolean> "OnItemHover" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onItemClick fn = (Bolero.Html.attr.callback<System.Boolean> "OnItemClick" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline tooltip (x: System.String) = "Tooltip" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline indexOfGroup (x: System.Int32) = "IndexOfGroup" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline hoverValue (x: System.Int32) = "HoverValue" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline hasHalf (x: System.Boolean) = "HasHalf" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline isFocused (x: System.Boolean) = "IsFocused" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type result<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = [] |> html.blazor<AntDesign.Result>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.Result>
    static member inline create (nodes: FunBlazorNode list) = nodes |> html.blazor<AntDesign.Result>
    static member inline create (node: FunBlazorNode) = [ node ] |> html.blazor<AntDesign.Result>
    static member inline ref x = attr.ref x
    static member inline title (x: System.String) = "Title" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline titleTemplate (x: string) = Bolero.Html.attr.fragment "TitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline titleTemplate (node) = Bolero.Html.attr.fragment "TitleTemplate" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline titleTemplate (nodes) = Bolero.Html.attr.fragment "TitleTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline subTitle (x: System.String) = "SubTitle" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline subTitleTemplate (x: string) = Bolero.Html.attr.fragment "SubTitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline subTitleTemplate (node) = Bolero.Html.attr.fragment "SubTitleTemplate" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline subTitleTemplate (nodes) = Bolero.Html.attr.fragment "SubTitleTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline extra (x: string) = Bolero.Html.attr.fragment "Extra" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline extra (node) = Bolero.Html.attr.fragment "Extra" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline extra (nodes) = Bolero.Html.attr.fragment "Extra" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline status (x: System.String) = "Status" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline icon (x: System.String) = "Icon" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline isShowIcon (x: System.Boolean) = "IsShowIcon" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type selectOption<'FunBlazorGeneric, 'TItemValue, 'TItem> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = [] |> html.blazor<AntDesign.SelectOption<'TItemValue, 'TItem>>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.SelectOption<'TItemValue, 'TItem>>

    static member inline ref x = attr.ref x
    static member inline value (x: 'TItemValue) = "Value" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline label (x: System.String) = "Label" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabled (x: System.Boolean) = "Disabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type simpleSelectOption<'FunBlazorGeneric> =
    inherit selectOption<'FunBlazorGeneric, System.String, System.String>
    static member inline create () = [] |> html.blazor<AntDesign.SimpleSelectOption>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.SimpleSelectOption>

    static member inline ref x = attr.ref x
    static member inline value (x: System.String) = "Value" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline label (x: System.String) = "Label" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabled (x: System.Boolean) = "Disabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type skeleton<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = [] |> html.blazor<AntDesign.Skeleton>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.Skeleton>
    static member inline create (nodes: FunBlazorNode list) = nodes |> html.blazor<AntDesign.Skeleton>
    static member inline create (node: FunBlazorNode) = [ node ] |> html.blazor<AntDesign.Skeleton>
    static member inline ref x = attr.ref x
    static member inline active (x: System.Boolean) = "Active" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline loading (x: System.Boolean) = "Loading" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline title (x: System.Boolean) = "Title" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline titleWidth (x: OneOf.OneOf<System.Nullable<System.Int32>, System.String>) = "TitleWidth" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline avatar (x: System.Boolean) = "Avatar" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline avatarSize (x: OneOf.OneOf<System.Nullable<System.Int32>, System.String>) = "AvatarSize" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline avatarShape (x: System.String) = "AvatarShape" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline paragraph (x: System.Boolean) = "Paragraph" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline paragraphRows (x: System.Nullable<System.Int32>) = "ParagraphRows" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline paragraphWidth (x: OneOf.OneOf<System.Nullable<System.Int32>, System.String, System.Collections.Generic.IList<OneOf.OneOf<System.Nullable<System.Int32>, System.String>>>) = "ParagraphWidth" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type skeletonElement<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = [] |> html.blazor<AntDesign.SkeletonElement>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.SkeletonElement>

    static member inline ref x = attr.ref x
    static member inline active (x: System.Boolean) = "Active" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline type' (x: System.String) = "Type" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline size (x: OneOf.OneOf<System.Nullable<System.Int32>, System.String>) = "Size" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline shape (x: System.String) = "Shape" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type space<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = [] |> html.blazor<AntDesign.Space>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.Space>
    static member inline create (nodes: FunBlazorNode list) = nodes |> html.blazor<AntDesign.Space>
    static member inline create (node: FunBlazorNode) = [ node ] |> html.blazor<AntDesign.Space>
    static member inline ref x = attr.ref x
    static member inline align (x: System.String) = "Align" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline direction (x: AntDesign.DirectionVHType) = "Direction" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline size (x: OneOf.OneOf<System.String, System.ValueTuple<System.String, System.String>>) = "Size" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline wrap (x: System.Boolean) = "Wrap" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline split (x: string) = Bolero.Html.attr.fragment "Split" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline split (node) = Bolero.Html.attr.fragment "Split" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline split (nodes) = Bolero.Html.attr.fragment "Split" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type spaceItem<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = [] |> html.blazor<AntDesign.SpaceItem>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.SpaceItem>
    static member inline create (nodes: FunBlazorNode list) = nodes |> html.blazor<AntDesign.SpaceItem>
    static member inline create (node: FunBlazorNode) = [ node ] |> html.blazor<AntDesign.SpaceItem>
    static member inline ref x = attr.ref x
    static member inline childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type spin<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = [] |> html.blazor<AntDesign.Spin>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.Spin>
    static member inline create (nodes: FunBlazorNode list) = nodes |> html.blazor<AntDesign.Spin>
    static member inline create (node: FunBlazorNode) = [ node ] |> html.blazor<AntDesign.Spin>
    static member inline ref x = attr.ref x
    static member inline size (x: System.String) = "Size" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline tip (x: System.String) = "Tip" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline delay (x: System.Int32) = "Delay" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline spinning (x: System.Boolean) = "Spinning" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline wrapperClassName (x: System.String) = "WrapperClassName" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline indicator (x: string) = Bolero.Html.attr.fragment "Indicator" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline indicator (node) = Bolero.Html.attr.fragment "Indicator" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline indicator (nodes) = Bolero.Html.attr.fragment "Indicator" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type statisticComponentBase<'FunBlazorGeneric, 'T> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = [] |> html.blazor<AntDesign.StatisticComponentBase<'T>>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.StatisticComponentBase<'T>>
    static member inline create (nodes: FunBlazorNode list) = nodes |> html.blazor<AntDesign.StatisticComponentBase<'T>>
    static member inline create (node: FunBlazorNode) = [ node ] |> html.blazor<AntDesign.StatisticComponentBase<'T>>
    static member inline ref x = attr.ref x
    static member inline prefix (x: System.String) = "Prefix" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline prefixTemplate (x: string) = Bolero.Html.attr.fragment "PrefixTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline prefixTemplate (node) = Bolero.Html.attr.fragment "PrefixTemplate" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline prefixTemplate (nodes) = Bolero.Html.attr.fragment "PrefixTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline suffix (x: System.String) = "Suffix" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline suffixTemplate (x: string) = Bolero.Html.attr.fragment "SuffixTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline suffixTemplate (node) = Bolero.Html.attr.fragment "SuffixTemplate" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline suffixTemplate (nodes) = Bolero.Html.attr.fragment "SuffixTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline title (x: System.String) = "Title" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline titleTemplate (x: string) = Bolero.Html.attr.fragment "TitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline titleTemplate (node) = Bolero.Html.attr.fragment "TitleTemplate" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline titleTemplate (nodes) = Bolero.Html.attr.fragment "TitleTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline value (x: 'T) = "Value" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valueStyle (x: System.String) = "ValueStyle" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type countDown<'FunBlazorGeneric> =
    inherit statisticComponentBase<'FunBlazorGeneric, System.DateTime>
    static member inline create () = [] |> html.blazor<AntDesign.CountDown>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.CountDown>
    static member inline create (nodes: FunBlazorNode list) = nodes |> html.blazor<AntDesign.CountDown>
    static member inline create (node: FunBlazorNode) = [ node ] |> html.blazor<AntDesign.CountDown>
    static member inline ref x = attr.ref x
    static member inline format (x: System.String) = "Format" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onFinish (x: Microsoft.AspNetCore.Components.EventCallback) = "OnFinish" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline prefix (x: System.String) = "Prefix" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline prefixTemplate (x: string) = Bolero.Html.attr.fragment "PrefixTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline prefixTemplate (node) = Bolero.Html.attr.fragment "PrefixTemplate" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline prefixTemplate (nodes) = Bolero.Html.attr.fragment "PrefixTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline suffix (x: System.String) = "Suffix" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline suffixTemplate (x: string) = Bolero.Html.attr.fragment "SuffixTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline suffixTemplate (node) = Bolero.Html.attr.fragment "SuffixTemplate" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline suffixTemplate (nodes) = Bolero.Html.attr.fragment "SuffixTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline title (x: System.String) = "Title" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline titleTemplate (x: string) = Bolero.Html.attr.fragment "TitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline titleTemplate (node) = Bolero.Html.attr.fragment "TitleTemplate" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline titleTemplate (nodes) = Bolero.Html.attr.fragment "TitleTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline value (x: System.DateTime) = "Value" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valueStyle (x: System.String) = "ValueStyle" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type statistic<'FunBlazorGeneric, 'TValue> =
    inherit statisticComponentBase<'FunBlazorGeneric, 'TValue>
    static member inline create () = [] |> html.blazor<AntDesign.Statistic<'TValue>>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.Statistic<'TValue>>
    static member inline create (nodes: FunBlazorNode list) = nodes |> html.blazor<AntDesign.Statistic<'TValue>>
    static member inline create (node: FunBlazorNode) = [ node ] |> html.blazor<AntDesign.Statistic<'TValue>>
    static member inline ref x = attr.ref x
    static member inline decimalSeparator (x: System.String) = "DecimalSeparator" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline groupSeparator (x: System.String) = "GroupSeparator" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline precision (x: System.Int32) = "Precision" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline prefix (x: System.String) = "Prefix" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline prefixTemplate (x: string) = Bolero.Html.attr.fragment "PrefixTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline prefixTemplate (node) = Bolero.Html.attr.fragment "PrefixTemplate" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline prefixTemplate (nodes) = Bolero.Html.attr.fragment "PrefixTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline suffix (x: System.String) = "Suffix" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline suffixTemplate (x: string) = Bolero.Html.attr.fragment "SuffixTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline suffixTemplate (node) = Bolero.Html.attr.fragment "SuffixTemplate" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline suffixTemplate (nodes) = Bolero.Html.attr.fragment "SuffixTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline title (x: System.String) = "Title" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline titleTemplate (x: string) = Bolero.Html.attr.fragment "TitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline titleTemplate (node) = Bolero.Html.attr.fragment "TitleTemplate" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline titleTemplate (nodes) = Bolero.Html.attr.fragment "TitleTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline value (x: 'TValue) = "Value" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline valueStyle (x: System.String) = "ValueStyle" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type step<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = [] |> html.blazor<AntDesign.Step>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.Step>

    static member inline ref x = attr.ref x
    static member inline icon (x: System.String) = "Icon" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline status (x: System.String) = "Status" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline title (x: System.String) = "Title" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline titleTemplate (x: string) = Bolero.Html.attr.fragment "TitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline titleTemplate (node) = Bolero.Html.attr.fragment "TitleTemplate" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline titleTemplate (nodes) = Bolero.Html.attr.fragment "TitleTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline subtitle (x: System.String) = "Subtitle" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline subtitleTemplate (x: string) = Bolero.Html.attr.fragment "SubtitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline subtitleTemplate (node) = Bolero.Html.attr.fragment "SubtitleTemplate" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline subtitleTemplate (nodes) = Bolero.Html.attr.fragment "SubtitleTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline description (x: System.String) = "Description" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline descriptionTemplate (x: string) = Bolero.Html.attr.fragment "DescriptionTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline descriptionTemplate (node) = Bolero.Html.attr.fragment "DescriptionTemplate" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline descriptionTemplate (nodes) = Bolero.Html.attr.fragment "DescriptionTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onClick fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnClick" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabled (x: System.Boolean) = "Disabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type steps<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = [] |> html.blazor<AntDesign.Steps>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.Steps>
    static member inline create (nodes: FunBlazorNode list) = nodes |> html.blazor<AntDesign.Steps>
    static member inline create (node: FunBlazorNode) = [ node ] |> html.blazor<AntDesign.Steps>
    static member inline ref x = attr.ref x
    static member inline current (x: System.Int32) = "Current" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline percent (x: System.Nullable<System.Double>) = "Percent" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline progressDot (x: string) = Bolero.Html.attr.fragment "ProgressDot" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline progressDot (node) = Bolero.Html.attr.fragment "ProgressDot" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline progressDot (nodes) = Bolero.Html.attr.fragment "ProgressDot" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline showProgressDot (x: System.Boolean) = "ShowProgressDot" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline direction (x: System.String) = "Direction" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline labelPlacement (x: System.String) = "LabelPlacement" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline type' (x: System.String) = "Type" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline size (x: System.String) = "Size" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline startIndex (x: System.Int32) = "StartIndex" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline status (x: System.String) = "Status" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onChange fn = (Bolero.Html.attr.callback<System.Int32> "OnChange" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type columnBase<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = [] |> html.blazor<AntDesign.ColumnBase>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.ColumnBase>
    static member inline create (nodes: FunBlazorNode list) = nodes |> html.blazor<AntDesign.ColumnBase>
    static member inline create (node: FunBlazorNode) = [ node ] |> html.blazor<AntDesign.ColumnBase>
    static member inline ref x = attr.ref x
    static member inline title (x: System.String) = "Title" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline titleTemplate (x: string) = Bolero.Html.attr.fragment "TitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline titleTemplate (node) = Bolero.Html.attr.fragment "TitleTemplate" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline titleTemplate (nodes) = Bolero.Html.attr.fragment "TitleTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline width (x: System.String) = "Width" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline headerStyle (x: System.String) = "HeaderStyle" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline rowSpan (x: System.Int32) = "RowSpan" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline colSpan (x: System.Int32) = "ColSpan" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline headerColSpan (x: System.Int32) = "HeaderColSpan" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline fixed' (x: System.String) = "Fixed" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline ellipsis (x: System.Boolean) = "Ellipsis" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type actionColumn<'FunBlazorGeneric> =
    inherit columnBase<'FunBlazorGeneric>
    static member inline create () = [] |> html.blazor<AntDesign.ActionColumn>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.ActionColumn>
    static member inline create (nodes: FunBlazorNode list) = nodes |> html.blazor<AntDesign.ActionColumn>
    static member inline create (node: FunBlazorNode) = [ node ] |> html.blazor<AntDesign.ActionColumn>
    static member inline ref x = attr.ref x
    static member inline title (x: System.String) = "Title" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline titleTemplate (x: string) = Bolero.Html.attr.fragment "TitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline titleTemplate (node) = Bolero.Html.attr.fragment "TitleTemplate" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline titleTemplate (nodes) = Bolero.Html.attr.fragment "TitleTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline width (x: System.String) = "Width" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline headerStyle (x: System.String) = "HeaderStyle" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline rowSpan (x: System.Int32) = "RowSpan" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline colSpan (x: System.Int32) = "ColSpan" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline headerColSpan (x: System.Int32) = "HeaderColSpan" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline fixed' (x: System.String) = "Fixed" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline ellipsis (x: System.Boolean) = "Ellipsis" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type column<'FunBlazorGeneric, 'TData> =
    inherit columnBase<'FunBlazorGeneric>
    static member inline create () = [] |> html.blazor<AntDesign.Column<'TData>>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.Column<'TData>>
    static member inline create (nodes: FunBlazorNode list) = nodes |> html.blazor<AntDesign.Column<'TData>>
    static member inline create (node: FunBlazorNode) = [ node ] |> html.blazor<AntDesign.Column<'TData>>
    static member inline ref x = attr.ref x
    static member inline fieldChanged fn = (Bolero.Html.attr.callback<'TData> "FieldChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline fieldExpression (x: System.Linq.Expressions.Expression<System.Func<'TData>>) = "FieldExpression" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline cellRender (render: 'TData -> FunBlazorNode) = Bolero.Html.attr.fragmentWith "CellRender" (fun x -> render x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline field (x: 'TData) = "Field" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline dataIndex (x: System.String) = "DataIndex" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline format (x: System.String) = "Format" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline sortable (x: System.Boolean) = "Sortable" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline sorterCompare (x: System.Func<'TData, 'TData, System.Int32>) = "SorterCompare" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline sorterMultiple (x: System.Int32) = "SorterMultiple" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline showSorterTooltip (x: System.Boolean) = "ShowSorterTooltip" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline sortDirections (x: AntDesign.SortDirection[]) = "SortDirections" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline defaultSortOrder (x: AntDesign.SortDirection) = "DefaultSortOrder" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onCell (x: System.Func<AntDesign.TableModels.RowData, System.Collections.Generic.Dictionary<System.String, System.Object>>) = "OnCell" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onHeaderCell (x: System.Func<System.Collections.Generic.Dictionary<System.String, System.Object>>) = "OnHeaderCell" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline filterable (x: System.Boolean) = "Filterable" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline filters (x: System.Collections.Generic.IEnumerable<AntDesign.TableFilter<'TData>>) = "Filters" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline filterMultiple (x: System.Boolean) = "FilterMultiple" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onFilter (x: System.Linq.Expressions.Expression<System.Func<'TData, 'TData, System.Boolean>>) = "OnFilter" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline title (x: System.String) = "Title" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline titleTemplate (x: string) = Bolero.Html.attr.fragment "TitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline titleTemplate (node) = Bolero.Html.attr.fragment "TitleTemplate" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline titleTemplate (nodes) = Bolero.Html.attr.fragment "TitleTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline width (x: System.String) = "Width" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline headerStyle (x: System.String) = "HeaderStyle" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline rowSpan (x: System.Int32) = "RowSpan" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline colSpan (x: System.Int32) = "ColSpan" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline headerColSpan (x: System.Int32) = "HeaderColSpan" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline fixed' (x: System.String) = "Fixed" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline ellipsis (x: System.Boolean) = "Ellipsis" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type selection<'FunBlazorGeneric> =
    inherit columnBase<'FunBlazorGeneric>
    static member inline create () = [] |> html.blazor<AntDesign.Selection>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.Selection>
    static member inline create (nodes: FunBlazorNode list) = nodes |> html.blazor<AntDesign.Selection>
    static member inline create (node: FunBlazorNode) = [ node ] |> html.blazor<AntDesign.Selection>
    static member inline ref x = attr.ref x
    static member inline type' (x: System.String) = "Type" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabled (x: System.Boolean) = "Disabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline key (x: System.String) = "Key" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline checkStrictly (x: System.Boolean) = "CheckStrictly" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline title (x: System.String) = "Title" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline titleTemplate (x: string) = Bolero.Html.attr.fragment "TitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline titleTemplate (node) = Bolero.Html.attr.fragment "TitleTemplate" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline titleTemplate (nodes) = Bolero.Html.attr.fragment "TitleTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline width (x: System.String) = "Width" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline headerStyle (x: System.String) = "HeaderStyle" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline rowSpan (x: System.Int32) = "RowSpan" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline colSpan (x: System.Int32) = "ColSpan" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline headerColSpan (x: System.Int32) = "HeaderColSpan" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline fixed' (x: System.String) = "Fixed" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline ellipsis (x: System.Boolean) = "Ellipsis" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type summaryCell<'FunBlazorGeneric> =
    inherit columnBase<'FunBlazorGeneric>
    static member inline create () = [] |> html.blazor<AntDesign.SummaryCell>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.SummaryCell>
    static member inline create (nodes: FunBlazorNode list) = nodes |> html.blazor<AntDesign.SummaryCell>
    static member inline create (node: FunBlazorNode) = [ node ] |> html.blazor<AntDesign.SummaryCell>
    static member inline ref x = attr.ref x
    static member inline title (x: System.String) = "Title" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline titleTemplate (x: string) = Bolero.Html.attr.fragment "TitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline titleTemplate (node) = Bolero.Html.attr.fragment "TitleTemplate" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline titleTemplate (nodes) = Bolero.Html.attr.fragment "TitleTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline width (x: System.String) = "Width" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline headerStyle (x: System.String) = "HeaderStyle" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline rowSpan (x: System.Int32) = "RowSpan" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline colSpan (x: System.Int32) = "ColSpan" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline headerColSpan (x: System.Int32) = "HeaderColSpan" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline fixed' (x: System.String) = "Fixed" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline ellipsis (x: System.Boolean) = "Ellipsis" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type table<'FunBlazorGeneric, 'TItem> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = [] |> html.blazor<AntDesign.Table<'TItem>>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.Table<'TItem>>
    static member inline create (nodes: FunBlazorNode list) = nodes |> html.blazor<AntDesign.Table<'TItem>>
    static member inline create (node: FunBlazorNode) = [ node ] |> html.blazor<AntDesign.Table<'TItem>>
    static member inline ref x = attr.ref x
    static member inline renderMode (x: AntDesign.RenderMode) = "RenderMode" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline dataSource (x: System.Collections.Generic.IEnumerable<'TItem>) = "DataSource" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (render: 'TItem -> FunBlazorNode) = Bolero.Html.attr.fragmentWith "ChildContent" (fun x -> render x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline rowTemplate (render: 'TItem -> FunBlazorNode) = Bolero.Html.attr.fragmentWith "RowTemplate" (fun x -> render x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline expandTemplate (render: AntDesign.TableModels.RowData<'TItem> -> FunBlazorNode) = Bolero.Html.attr.fragmentWith "ExpandTemplate" (fun x -> render x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline rowExpandable (x: System.Func<AntDesign.TableModels.RowData<'TItem>, System.Boolean>) = "RowExpandable" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline treeChildren (x: System.Func<'TItem, System.Collections.Generic.IEnumerable<'TItem>>) = "TreeChildren" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onChange fn = (Bolero.Html.attr.callback<AntDesign.TableModels.QueryModel<'TItem>> "OnChange" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onRow (x: System.Func<AntDesign.TableModels.RowData<'TItem>, System.Collections.Generic.Dictionary<System.String, System.Object>>) = "OnRow" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onHeaderRow (x: System.Func<System.Collections.Generic.Dictionary<System.String, System.Object>>) = "OnHeaderRow" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline loading (x: System.Boolean) = "Loading" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline title (x: System.String) = "Title" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline titleTemplate (x: string) = Bolero.Html.attr.fragment "TitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline titleTemplate (node) = Bolero.Html.attr.fragment "TitleTemplate" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline titleTemplate (nodes) = Bolero.Html.attr.fragment "TitleTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline footer (x: System.String) = "Footer" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline footerTemplate (x: string) = Bolero.Html.attr.fragment "FooterTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline footerTemplate (node) = Bolero.Html.attr.fragment "FooterTemplate" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline footerTemplate (nodes) = Bolero.Html.attr.fragment "FooterTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline size (x: AntDesign.TableSize) = "Size" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline locale (x: AntDesign.TableLocale) = "Locale" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline bordered (x: System.Boolean) = "Bordered" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline scrollX (x: System.String) = "ScrollX" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline scrollY (x: System.String) = "ScrollY" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline scrollBarWidth (x: System.Int32) = "ScrollBarWidth" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline indentSize (x: System.Int32) = "IndentSize" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline expandIconColumnIndex (x: System.Int32) = "ExpandIconColumnIndex" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline rowClassName (x: System.Func<AntDesign.TableModels.RowData<'TItem>, System.String>) = "RowClassName" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline expandedRowClassName (x: System.Func<AntDesign.TableModels.RowData<'TItem>, System.String>) = "ExpandedRowClassName" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onExpand fn = (Bolero.Html.attr.callback<AntDesign.TableModels.RowData<'TItem>> "OnExpand" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline sortDirections (x: AntDesign.SortDirection[]) = "SortDirections" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline tableLayout (x: System.String) = "TableLayout" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onRowClick fn = (Bolero.Html.attr.callback<AntDesign.TableModels.RowData<'TItem>> "OnRowClick" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline hidePagination (x: System.Boolean) = "HidePagination" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline paginationPosition (x: System.String) = "PaginationPosition" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline total (x: System.Int32) = "Total" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline totalChanged fn = (Bolero.Html.attr.callback<System.Int32> "TotalChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline pageIndex (x: System.Int32) = "PageIndex" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline pageIndexChanged fn = (Bolero.Html.attr.callback<System.Int32> "PageIndexChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline pageSize (x: System.Int32) = "PageSize" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline pageSizeChanged fn = (Bolero.Html.attr.callback<System.Int32> "PageSizeChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onPageIndexChange fn = (Bolero.Html.attr.callback<AntDesign.PaginationEventArgs> "OnPageIndexChange" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onPageSizeChange fn = (Bolero.Html.attr.callback<AntDesign.PaginationEventArgs> "OnPageSizeChange" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline selectedRows (x: System.Collections.Generic.IEnumerable<'TItem>) = "SelectedRows" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline selectedRowsChanged fn = (Bolero.Html.attr.callback<System.Collections.Generic.IEnumerable<'TItem>> "SelectedRowsChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type tabPane<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = [] |> html.blazor<AntDesign.TabPane>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.TabPane>
    static member inline create (nodes: FunBlazorNode list) = nodes |> html.blazor<AntDesign.TabPane>
    static member inline create (node: FunBlazorNode) = [ node ] |> html.blazor<AntDesign.TabPane>
    static member inline ref x = attr.ref x
    static member inline forceRender (x: System.Boolean) = "ForceRender" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline key (x: System.String) = "Key" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline tab (x: string) = Bolero.Html.attr.fragment "Tab" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline tab (node) = Bolero.Html.attr.fragment "Tab" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline tab (nodes) = Bolero.Html.attr.fragment "Tab" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabled (x: System.Boolean) = "Disabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline closable (x: System.Boolean) = "Closable" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type tabs<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = [] |> html.blazor<AntDesign.Tabs>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.Tabs>
    static member inline create (nodes: FunBlazorNode list) = nodes |> html.blazor<AntDesign.Tabs>
    static member inline create (node: FunBlazorNode) = [ node ] |> html.blazor<AntDesign.Tabs>
    static member inline ref x = attr.ref x
    static member inline childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline activeKey (x: System.String) = "ActiveKey" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline activeKeyChanged fn = (Bolero.Html.attr.callback<System.String> "ActiveKeyChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline animated (x: System.Boolean) = "Animated" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline renderTabBar (x: System.Object) = "RenderTabBar" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline defaultActiveKey (x: System.String) = "DefaultActiveKey" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline hideAdd (x: System.Boolean) = "HideAdd" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline size (x: System.String) = "Size" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline tabBarExtraContent (x: string) = Bolero.Html.attr.fragment "TabBarExtraContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline tabBarExtraContent (node) = Bolero.Html.attr.fragment "TabBarExtraContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline tabBarExtraContent (nodes) = Bolero.Html.attr.fragment "TabBarExtraContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline tabBarGutter (x: System.Int32) = "TabBarGutter" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline tabBarStyle (x: System.String) = "TabBarStyle" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline tabPosition (x: System.String) = "TabPosition" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline type' (x: System.String) = "Type" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onChange fn = (Bolero.Html.attr.callback<System.String> "OnChange" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onEdit (x: System.Func<System.String, System.String, System.Threading.Tasks.Task<System.Boolean>>) = "OnEdit" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onAddClick (x: Microsoft.AspNetCore.Components.EventCallback) = "OnAddClick" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline afterTabCreated fn = (Bolero.Html.attr.callback<System.String> "AfterTabCreated" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onNextClick (x: Microsoft.AspNetCore.Components.EventCallback) = "OnNextClick" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onPrevClick (x: Microsoft.AspNetCore.Components.EventCallback) = "OnPrevClick" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onTabClick fn = (Bolero.Html.attr.callback<System.String> "OnTabClick" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline keyboard (x: System.Boolean) = "Keyboard" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline draggable (x: System.Boolean) = "Draggable" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type tag<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = [] |> html.blazor<AntDesign.Tag>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.Tag>
    static member inline create (nodes: FunBlazorNode list) = nodes |> html.blazor<AntDesign.Tag>
    static member inline create (node: FunBlazorNode) = [ node ] |> html.blazor<AntDesign.Tag>
    static member inline ref x = attr.ref x
    static member inline childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline closable (x: System.Boolean) = "Closable" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline checkable (x: System.Boolean) = "Checkable" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline checked' (x: System.Boolean) = "Checked" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline checkedChange fn = (Bolero.Html.attr.callback<System.Boolean> "CheckedChange" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline color (x: System.String) = "Color" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline icon (x: System.String) = "Icon" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onClose fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnClose" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onClosing fn = (Bolero.Html.attr.callback<AntDesign.CloseEventArgs<Microsoft.AspNetCore.Components.Web.MouseEventArgs>> "OnClosing" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onClick (x: Microsoft.AspNetCore.Components.EventCallback) = "OnClick" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline visible (x: System.Boolean) = "Visible" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type timeline<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = [] |> html.blazor<AntDesign.Timeline>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.Timeline>
    static member inline create (nodes: FunBlazorNode list) = nodes |> html.blazor<AntDesign.Timeline>
    static member inline create (node: FunBlazorNode) = [ node ] |> html.blazor<AntDesign.Timeline>
    static member inline ref x = attr.ref x
    static member inline mode (x: System.String) = "Mode" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline reverse (x: System.Boolean) = "Reverse" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline pending (x: OneOf.OneOf<System.String, Microsoft.AspNetCore.Components.RenderFragment>) = "Pending" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline pendingDot (x: string) = Bolero.Html.attr.fragment "PendingDot" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline pendingDot (node) = Bolero.Html.attr.fragment "PendingDot" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline pendingDot (nodes) = Bolero.Html.attr.fragment "PendingDot" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type timelineItem<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = [] |> html.blazor<AntDesign.TimelineItem>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.TimelineItem>
    static member inline create (nodes: FunBlazorNode list) = nodes |> html.blazor<AntDesign.TimelineItem>
    static member inline create (node: FunBlazorNode) = [ node ] |> html.blazor<AntDesign.TimelineItem>
    static member inline ref x = attr.ref x
    static member inline childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline dot (x: string) = Bolero.Html.attr.fragment "Dot" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline dot (node) = Bolero.Html.attr.fragment "Dot" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline dot (nodes) = Bolero.Html.attr.fragment "Dot" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline color (x: System.String) = "Color" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type transfer<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = [] |> html.blazor<AntDesign.Transfer>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.Transfer>
    static member inline create (nodes: FunBlazorNode list) = nodes |> html.blazor<AntDesign.Transfer>
    static member inline create (node: FunBlazorNode) = [ node ] |> html.blazor<AntDesign.Transfer>
    static member inline ref x = attr.ref x
    static member inline dataSource (x: System.Collections.Generic.IList<AntDesign.TransferItem>) = "DataSource" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline titles (x: System.String[]) = "Titles" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline operations (x: System.String[]) = "Operations" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabled (x: System.Boolean) = "Disabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline showSearch (x: System.Boolean) = "ShowSearch" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline showSelectAll (x: System.Boolean) = "ShowSelectAll" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline targetKeys (x: System.String[]) = "TargetKeys" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline selectedKeys (x: System.String[]) = "SelectedKeys" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onChange fn = (Bolero.Html.attr.callback<AntDesign.TransferChangeArgs> "OnChange" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onScroll fn = (Bolero.Html.attr.callback<AntDesign.TransferScrollArgs> "OnScroll" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onSearch fn = (Bolero.Html.attr.callback<AntDesign.TransferSearchArgs> "OnSearch" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onSelectChange fn = (Bolero.Html.attr.callback<AntDesign.TransferSelectChangeArgs> "OnSelectChange" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline render (x: System.Func<AntDesign.TransferItem, OneOf.OneOf<System.String, Microsoft.AspNetCore.Components.RenderFragment>>) = "Render" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline locale (x: AntDesign.TransferLocale) = "Locale" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline footer (x: System.String) = "Footer" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline footerTemplate (x: string) = Bolero.Html.attr.fragment "FooterTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline footerTemplate (node) = Bolero.Html.attr.fragment "FooterTemplate" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline footerTemplate (nodes) = Bolero.Html.attr.fragment "FooterTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type tree<'FunBlazorGeneric, 'TItem> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = [] |> html.blazor<AntDesign.Tree<'TItem>>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.Tree<'TItem>>

    static member inline ref x = attr.ref x
    static member inline showExpand (x: System.Boolean) = "ShowExpand" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline showLine (x: System.Boolean) = "ShowLine" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline showIcon (x: System.Boolean) = "ShowIcon" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline blockNode (x: System.Boolean) = "BlockNode" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline draggable (x: System.Boolean) = "Draggable" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline nodes (x: string) = Bolero.Html.attr.fragment "Nodes" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline nodes (node) = Bolero.Html.attr.fragment "Nodes" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline nodes (nodes) = Bolero.Html.attr.fragment "Nodes" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childNodes (x: System.Collections.Generic.List<AntDesign.TreeNode<'TItem>>) = "ChildNodes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline multiple (x: System.Boolean) = "Multiple" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline selectedKey (x: System.String) = "SelectedKey" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline selectedKeyChanged fn = (Bolero.Html.attr.callback<System.String> "SelectedKeyChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline selectedNode (x: AntDesign.TreeNode<'TItem>) = "SelectedNode" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline selectedNodeChanged fn = (Bolero.Html.attr.callback<AntDesign.TreeNode<'TItem>> "SelectedNodeChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline selectedData (x: 'TItem) = "SelectedData" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline selectedDataChanged fn = (Bolero.Html.attr.callback<'TItem> "SelectedDataChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline selectedKeys (x: System.String[]) = "SelectedKeys" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline selectedKeysChanged fn = (Bolero.Html.attr.callback<System.String[]> "SelectedKeysChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline selectedNodes (x: AntDesign.TreeNode<'TItem>[]) = "SelectedNodes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline selectedDatas (x: 'TItem[]) = "SelectedDatas" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline checkable (x: System.Boolean) = "Checkable" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline searchValue (x: System.String) = "SearchValue" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline searchExpression (x: System.Func<AntDesign.TreeNode<'TItem>, System.Boolean>) = "SearchExpression" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline dataSource (x: System.Collections.Generic.IList<'TItem>) = "DataSource" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline titleExpression (x: System.Func<AntDesign.TreeNode<'TItem>, System.String>) = "TitleExpression" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline keyExpression (x: System.Func<AntDesign.TreeNode<'TItem>, System.String>) = "KeyExpression" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline iconExpression (x: System.Func<AntDesign.TreeNode<'TItem>, System.String>) = "IconExpression" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline isLeafExpression (x: System.Func<AntDesign.TreeNode<'TItem>, System.Boolean>) = "IsLeafExpression" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childrenExpression (x: System.Func<AntDesign.TreeNode<'TItem>, System.Collections.Generic.IList<'TItem>>) = "ChildrenExpression" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onNodeLoadDelayAsync fn = (Bolero.Html.attr.callback<AntDesign.TreeEventArgs<'TItem>> "OnNodeLoadDelayAsync" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onClick fn = (Bolero.Html.attr.callback<AntDesign.TreeEventArgs<'TItem>> "OnClick" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onDblClick fn = (Bolero.Html.attr.callback<AntDesign.TreeEventArgs<'TItem>> "OnDblClick" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onContextMenu fn = (Bolero.Html.attr.callback<AntDesign.TreeEventArgs<'TItem>> "OnContextMenu" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onCheckBoxChanged fn = (Bolero.Html.attr.callback<AntDesign.TreeEventArgs<'TItem>> "OnCheckBoxChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onExpandChanged fn = (Bolero.Html.attr.callback<AntDesign.TreeEventArgs<'TItem>> "OnExpandChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onSearchValueChanged fn = (Bolero.Html.attr.callback<AntDesign.TreeEventArgs<'TItem>> "OnSearchValueChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline indentTemplate (render: AntDesign.TreeNode<'TItem> -> FunBlazorNode) = Bolero.Html.attr.fragmentWith "IndentTemplate" (fun x -> render x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline titleTemplate (render: AntDesign.TreeNode<'TItem> -> FunBlazorNode) = Bolero.Html.attr.fragmentWith "TitleTemplate" (fun x -> render x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline titleIconTemplate (render: AntDesign.TreeNode<'TItem> -> FunBlazorNode) = Bolero.Html.attr.fragmentWith "TitleIconTemplate" (fun x -> render x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline switcherIconTemplate (render: AntDesign.TreeNode<'TItem> -> FunBlazorNode) = Bolero.Html.attr.fragmentWith "SwitcherIconTemplate" (fun x -> render x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type treeNode<'FunBlazorGeneric, 'TItem> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = [] |> html.blazor<AntDesign.TreeNode<'TItem>>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.TreeNode<'TItem>>

    static member inline ref x = attr.ref x
    static member inline nodes (x: string) = Bolero.Html.attr.fragment "Nodes" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline nodes (node) = Bolero.Html.attr.fragment "Nodes" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline nodes (nodes) = Bolero.Html.attr.fragment "Nodes" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline key (x: System.String) = "Key" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabled (x: System.Boolean) = "Disabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline selected (x: System.Boolean) = "Selected" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline loading (x: System.Boolean) = "Loading" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline isLeaf (x: System.Boolean) = "IsLeaf" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline expanded (x: System.Boolean) = "Expanded" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline checked' (x: System.Boolean) = "Checked" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline indeterminate (x: System.Boolean) = "Indeterminate" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disableCheckbox (x: System.Boolean) = "DisableCheckbox" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline draggable (x: System.Boolean) = "Draggable" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline icon (x: System.String) = "Icon" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline title (x: System.String) = "Title" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline dataItem (x: 'TItem) = "DataItem" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type typographyBase<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = [] |> html.blazor<AntDesign.TypographyBase>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.TypographyBase>
    static member inline create (nodes: FunBlazorNode list) = nodes |> html.blazor<AntDesign.TypographyBase>
    static member inline create (node: FunBlazorNode) = [ node ] |> html.blazor<AntDesign.TypographyBase>
    static member inline ref x = attr.ref x
    static member inline copyable (x: System.Boolean) = "Copyable" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline copyConfig (x: AntDesign.TypographyCopyableConfig) = "CopyConfig" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline delete (x: System.Boolean) = "Delete" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabled (x: System.Boolean) = "Disabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline editable (x: System.Boolean) = "Editable" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline editConfig (x: AntDesign.TypographyEditableConfig) = "EditConfig" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline ellipsis (x: System.Boolean) = "Ellipsis" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline ellipsisConfig (x: AntDesign.TypographyEllipsisConfig) = "EllipsisConfig" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline mark (x: System.Boolean) = "Mark" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline underline (x: System.Boolean) = "Underline" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline strong (x: System.Boolean) = "Strong" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onChange (x: System.Action) = "OnChange" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline type' (x: System.String) = "Type" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type link<'FunBlazorGeneric> =
    inherit typographyBase<'FunBlazorGeneric>
    static member inline create () = [] |> html.blazor<AntDesign.Link>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.Link>
    static member inline create (nodes: FunBlazorNode list) = nodes |> html.blazor<AntDesign.Link>
    static member inline create (node: FunBlazorNode) = [ node ] |> html.blazor<AntDesign.Link>
    static member inline ref x = attr.ref x
    static member inline code (x: System.Boolean) = "Code" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline keyboard (x: System.Boolean) = "Keyboard" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline copyable (x: System.Boolean) = "Copyable" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline copyConfig (x: AntDesign.TypographyCopyableConfig) = "CopyConfig" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline delete (x: System.Boolean) = "Delete" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabled (x: System.Boolean) = "Disabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline editable (x: System.Boolean) = "Editable" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline editConfig (x: AntDesign.TypographyEditableConfig) = "EditConfig" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline ellipsis (x: System.Boolean) = "Ellipsis" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline ellipsisConfig (x: AntDesign.TypographyEllipsisConfig) = "EllipsisConfig" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline mark (x: System.Boolean) = "Mark" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline underline (x: System.Boolean) = "Underline" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline strong (x: System.Boolean) = "Strong" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onChange (x: System.Action) = "OnChange" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline type' (x: System.String) = "Type" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type paragraph<'FunBlazorGeneric> =
    inherit typographyBase<'FunBlazorGeneric>
    static member inline create () = [] |> html.blazor<AntDesign.Paragraph>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.Paragraph>
    static member inline create (nodes: FunBlazorNode list) = nodes |> html.blazor<AntDesign.Paragraph>
    static member inline create (node: FunBlazorNode) = [ node ] |> html.blazor<AntDesign.Paragraph>
    static member inline ref x = attr.ref x
    static member inline code (x: System.Boolean) = "Code" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline keyboard (x: System.Boolean) = "Keyboard" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline copyable (x: System.Boolean) = "Copyable" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline copyConfig (x: AntDesign.TypographyCopyableConfig) = "CopyConfig" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline delete (x: System.Boolean) = "Delete" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabled (x: System.Boolean) = "Disabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline editable (x: System.Boolean) = "Editable" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline editConfig (x: AntDesign.TypographyEditableConfig) = "EditConfig" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline ellipsis (x: System.Boolean) = "Ellipsis" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline ellipsisConfig (x: AntDesign.TypographyEllipsisConfig) = "EllipsisConfig" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline mark (x: System.Boolean) = "Mark" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline underline (x: System.Boolean) = "Underline" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline strong (x: System.Boolean) = "Strong" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onChange (x: System.Action) = "OnChange" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline type' (x: System.String) = "Type" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type text<'FunBlazorGeneric> =
    inherit typographyBase<'FunBlazorGeneric>
    static member inline create () = [] |> html.blazor<AntDesign.Text>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.Text>
    static member inline create (nodes: FunBlazorNode list) = nodes |> html.blazor<AntDesign.Text>
    static member inline create (node: FunBlazorNode) = [ node ] |> html.blazor<AntDesign.Text>
    static member inline ref x = attr.ref x
    static member inline code (x: System.Boolean) = "Code" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline keyboard (x: System.Boolean) = "Keyboard" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline copyable (x: System.Boolean) = "Copyable" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline copyConfig (x: AntDesign.TypographyCopyableConfig) = "CopyConfig" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline delete (x: System.Boolean) = "Delete" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabled (x: System.Boolean) = "Disabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline editable (x: System.Boolean) = "Editable" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline editConfig (x: AntDesign.TypographyEditableConfig) = "EditConfig" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline ellipsis (x: System.Boolean) = "Ellipsis" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline ellipsisConfig (x: AntDesign.TypographyEllipsisConfig) = "EllipsisConfig" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline mark (x: System.Boolean) = "Mark" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline underline (x: System.Boolean) = "Underline" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline strong (x: System.Boolean) = "Strong" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onChange (x: System.Action) = "OnChange" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline type' (x: System.String) = "Type" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type title<'FunBlazorGeneric> =
    inherit typographyBase<'FunBlazorGeneric>
    static member inline create () = [] |> html.blazor<AntDesign.Title>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.Title>
    static member inline create (nodes: FunBlazorNode list) = nodes |> html.blazor<AntDesign.Title>
    static member inline create (node: FunBlazorNode) = [ node ] |> html.blazor<AntDesign.Title>
    static member inline ref x = attr.ref x
    static member inline level (x: System.Int32) = "Level" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline copyable (x: System.Boolean) = "Copyable" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline copyConfig (x: AntDesign.TypographyCopyableConfig) = "CopyConfig" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline delete (x: System.Boolean) = "Delete" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabled (x: System.Boolean) = "Disabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline editable (x: System.Boolean) = "Editable" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline editConfig (x: AntDesign.TypographyEditableConfig) = "EditConfig" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline ellipsis (x: System.Boolean) = "Ellipsis" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline ellipsisConfig (x: AntDesign.TypographyEllipsisConfig) = "EllipsisConfig" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline mark (x: System.Boolean) = "Mark" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline underline (x: System.Boolean) = "Underline" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline strong (x: System.Boolean) = "Strong" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onChange (x: System.Action) = "OnChange" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline type' (x: System.String) = "Type" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type upload<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = [] |> html.blazor<AntDesign.Upload>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.Upload>
    static member inline create (nodes: FunBlazorNode list) = nodes |> html.blazor<AntDesign.Upload>
    static member inline create (node: FunBlazorNode) = [ node ] |> html.blazor<AntDesign.Upload>
    static member inline ref x = attr.ref x
    static member inline beforeUpload (x: System.Func<AntDesign.UploadFileItem, System.Boolean>) = "BeforeUpload" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline beforeAllUploadAsync (x: System.Func<System.Collections.Generic.List<AntDesign.UploadFileItem>, System.Threading.Tasks.Task<System.Boolean>>) = "BeforeAllUploadAsync" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline beforeAllUpload (x: System.Func<System.Collections.Generic.List<AntDesign.UploadFileItem>, System.Boolean>) = "BeforeAllUpload" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline name (x: System.String) = "Name" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline action (x: System.String) = "Action" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabled (x: System.Boolean) = "Disabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline data (x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "Data" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline listType (x: System.String) = "ListType" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline directory (x: System.Boolean) = "Directory" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline multiple (x: System.Boolean) = "Multiple" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline accept (x: System.String) = "Accept" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline showUploadList (x: System.Boolean) = "ShowUploadList" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline fileList (x: System.Collections.Generic.List<AntDesign.UploadFileItem>) = "FileList" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline locale (x: AntDesign.UploadLocale) = "Locale" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline fileListChanged fn = (Bolero.Html.attr.callback<System.Collections.Generic.List<AntDesign.UploadFileItem>> "FileListChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline defaultFileList (x: System.Collections.Generic.List<AntDesign.UploadFileItem>) = "DefaultFileList" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline headers (x: System.Collections.Generic.Dictionary<System.String, System.String>) = "Headers" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onSingleCompleted fn = (Bolero.Html.attr.callback<AntDesign.UploadInfo> "OnSingleCompleted" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onCompleted fn = (Bolero.Html.attr.callback<AntDesign.UploadInfo> "OnCompleted" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onChange fn = (Bolero.Html.attr.callback<AntDesign.UploadInfo> "OnChange" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onRemove (x: System.Func<AntDesign.UploadFileItem, System.Threading.Tasks.Task<System.Boolean>>) = "OnRemove" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onPreview fn = (Bolero.Html.attr.callback<AntDesign.UploadFileItem> "OnPreview" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onDownload fn = (Bolero.Html.attr.callback<AntDesign.UploadFileItem> "OnDownload" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline showButton (x: System.Boolean) = "ShowButton" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type breadcrumbItem<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = [] |> html.blazor<AntDesign.BreadcrumbItem>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.BreadcrumbItem>
    static member inline create (nodes: FunBlazorNode list) = nodes |> html.blazor<AntDesign.BreadcrumbItem>
    static member inline create (node: FunBlazorNode) = [ node ] |> html.blazor<AntDesign.BreadcrumbItem>
    static member inline ref x = attr.ref x
    static member inline childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline overlay (x: System.Object) = "Overlay" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type calendarHeader<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = [] |> html.blazor<AntDesign.CalendarHeader>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.CalendarHeader>

    static member inline ref x = attr.ref x
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type cardMeta<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = [] |> html.blazor<AntDesign.CardMeta>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.CardMeta>

    static member inline ref x = attr.ref x
    static member inline title (x: System.String) = "Title" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline titleTemplate (x: string) = Bolero.Html.attr.fragment "TitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline titleTemplate (node) = Bolero.Html.attr.fragment "TitleTemplate" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline titleTemplate (nodes) = Bolero.Html.attr.fragment "TitleTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline description (x: System.String) = "Description" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline descriptionTemplate (x: string) = Bolero.Html.attr.fragment "DescriptionTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline descriptionTemplate (node) = Bolero.Html.attr.fragment "DescriptionTemplate" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline descriptionTemplate (nodes) = Bolero.Html.attr.fragment "DescriptionTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline avatar (x: System.String) = "Avatar" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline avatarTemplate (x: string) = Bolero.Html.attr.fragment "AvatarTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline avatarTemplate (node) = Bolero.Html.attr.fragment "AvatarTemplate" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline avatarTemplate (nodes) = Bolero.Html.attr.fragment "AvatarTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type antContainer<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = [] |> html.blazor<AntDesign.AntContainer>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.AntContainer>

    static member inline ref x = attr.ref x
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type template<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = [] |> html.blazor<AntDesign.Template>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.Template>
    static member inline create (nodes: FunBlazorNode list) = nodes |> html.blazor<AntDesign.Template>
    static member inline create (node: FunBlazorNode) = [ node ] |> html.blazor<AntDesign.Template>
    static member inline ref x = attr.ref x
    static member inline childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline if' (x: System.Func<System.Boolean>) = "If" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type emptyDefaultImg<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = [] |> html.blazor<AntDesign.EmptyDefaultImg>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.EmptyDefaultImg>

    static member inline ref x = attr.ref x
    static member inline prefixCls (x: System.String) = "PrefixCls" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type emptySimpleImg<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = [] |> html.blazor<AntDesign.EmptySimpleImg>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.EmptySimpleImg>

    static member inline ref x = attr.ref x
    static member inline prefixCls (x: System.String) = "PrefixCls" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type content<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = [] |> html.blazor<AntDesign.Content>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.Content>
    static member inline create (nodes: FunBlazorNode list) = nodes |> html.blazor<AntDesign.Content>
    static member inline create (node: FunBlazorNode) = [ node ] |> html.blazor<AntDesign.Content>
    static member inline ref x = attr.ref x
    static member inline childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type footer<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = [] |> html.blazor<AntDesign.Footer>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.Footer>
    static member inline create (nodes: FunBlazorNode list) = nodes |> html.blazor<AntDesign.Footer>
    static member inline create (node: FunBlazorNode) = [ node ] |> html.blazor<AntDesign.Footer>
    static member inline ref x = attr.ref x
    static member inline childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type header<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = [] |> html.blazor<AntDesign.Header>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.Header>
    static member inline create (nodes: FunBlazorNode list) = nodes |> html.blazor<AntDesign.Header>
    static member inline create (node: FunBlazorNode) = [ node ] |> html.blazor<AntDesign.Header>
    static member inline ref x = attr.ref x
    static member inline childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type layout<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = [] |> html.blazor<AntDesign.Layout>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.Layout>
    static member inline create (nodes: FunBlazorNode list) = nodes |> html.blazor<AntDesign.Layout>
    static member inline create (node: FunBlazorNode) = [ node ] |> html.blazor<AntDesign.Layout>
    static member inline ref x = attr.ref x
    static member inline childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type menuDivider<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = [] |> html.blazor<AntDesign.MenuDivider>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.MenuDivider>

    static member inline ref x = attr.ref x
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type paginationPager<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = [] |> html.blazor<AntDesign.PaginationPager>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.PaginationPager>

    static member inline ref x = attr.ref x
    static member inline showTitle (x: System.Boolean) = "ShowTitle" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline page (x: System.Int32) = "Page" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline rootPrefixCls (x: System.String) = "RootPrefixCls" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline active (x: System.Boolean) = "Active" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabled (x: System.Boolean) = "Disabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onClick fn = (Bolero.Html.attr.callback<System.Int32> "OnClick" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onKeyPress fn = (Bolero.Html.attr.callback<System.ValueTuple<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs, System.Action>> "OnKeyPress" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline itemRender (render: AntDesign.PaginationItemRenderContext -> FunBlazorNode) = Bolero.Html.attr.fragmentWith "ItemRender" (fun x -> render x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline unmatchedAttributes (x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UnmatchedAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    
            
namespace rec Fun.Blazor.AntDesign.DslInternals.Select.Internal

open Bolero.Html
open Fun.Blazor
open Fun.Blazor.Web.DslInternals
open Fun.Blazor.AntDesign.DslInternals


type selectOptionGroup<'FunBlazorGeneric, 'TItemValue, 'TItem> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = [] |> html.blazor<AntDesign.Select.Internal.SelectOptionGroup<'TItemValue, 'TItem>>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.Select.Internal.SelectOptionGroup<'TItemValue, 'TItem>>

    static member inline ref x = attr.ref x
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    
            
namespace rec Fun.Blazor.AntDesign.DslInternals.Internal

open Bolero.Html
open Fun.Blazor
open Fun.Blazor.Web.DslInternals
open Fun.Blazor.AntDesign.DslInternals


type calendarPanelChooser<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = [] |> html.blazor<AntDesign.Internal.CalendarPanelChooser>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.Internal.CalendarPanelChooser>

    static member inline ref x = attr.ref x
    static member inline calendar (x: AntDesign.Calendar) = "Calendar" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onSelect (x: System.Action<System.DateTime, System.Int32>) = "OnSelect" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline pickerIndex (x: System.Int32) = "PickerIndex" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type element<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = [] |> html.blazor<AntDesign.Internal.Element>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.Internal.Element>
    static member inline create (nodes: FunBlazorNode list) = nodes |> html.blazor<AntDesign.Internal.Element>
    static member inline create (node: FunBlazorNode) = [ node ] |> html.blazor<AntDesign.Internal.Element>
    static member inline ref x = attr.ref x
    static member inline htmlTag (x: System.String) = "HtmlTag" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refChanged fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.ElementReference> "RefChanged" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline attributes (x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "Attributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type overlay<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = [] |> html.blazor<AntDesign.Internal.Overlay>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.Internal.Overlay>
    static member inline create (nodes: FunBlazorNode list) = nodes |> html.blazor<AntDesign.Internal.Overlay>
    static member inline create (node: FunBlazorNode) = [ node ] |> html.blazor<AntDesign.Internal.Overlay>
    static member inline ref x = attr.ref x
    static member inline overlayChildPrefixCls (x: System.String) = "OverlayChildPrefixCls" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onOverlayMouseEnter (x: Microsoft.AspNetCore.Components.EventCallback) = "OnOverlayMouseEnter" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onOverlayMouseLeave (x: Microsoft.AspNetCore.Components.EventCallback) = "OnOverlayMouseLeave" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onShow (x: System.Action) = "OnShow" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onHide (x: System.Action) = "OnHide" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline hideMillisecondsDelay (x: System.Int32) = "HideMillisecondsDelay" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline waitForHideAnimMilliseconds (x: System.Int32) = "WaitForHideAnimMilliseconds" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline verticalOffset (x: System.Int32) = "VerticalOffset" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline horizontalOffset (x: System.Int32) = "HorizontalOffset" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline hiddenMode (x: System.Boolean) = "HiddenMode" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type overlayTrigger<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = [] |> html.blazor<AntDesign.Internal.OverlayTrigger>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.Internal.OverlayTrigger>
    static member inline create (nodes: FunBlazorNode list) = nodes |> html.blazor<AntDesign.Internal.OverlayTrigger>
    static member inline create (node: FunBlazorNode) = [ node ] |> html.blazor<AntDesign.Internal.OverlayTrigger>
    static member inline ref x = attr.ref x
    static member inline boundaryAdjustMode (x: AntDesign.TriggerBoundaryAdjustMode) = "BoundaryAdjustMode" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline complexAutoCloseAndVisible (x: System.Boolean) = "ComplexAutoCloseAndVisible" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabled (x: System.Boolean) = "Disabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline hiddenMode (x: System.Boolean) = "HiddenMode" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline inlineFlexMode (x: System.Boolean) = "InlineFlexMode" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline isButton (x: System.Boolean) = "IsButton" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onClick fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnClick" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onMaskClick (x: Microsoft.AspNetCore.Components.EventCallback) = "OnMaskClick" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onMouseEnter (x: System.Action) = "OnMouseEnter" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onMouseLeave (x: System.Action) = "OnMouseLeave" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onOverlayHiding fn = (Bolero.Html.attr.callback<System.Boolean> "OnOverlayHiding" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onVisibleChange fn = (Bolero.Html.attr.callback<System.Boolean> "OnVisibleChange" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline overlay (x: string) = Bolero.Html.attr.fragment "Overlay" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline overlay (node) = Bolero.Html.attr.fragment "Overlay" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline overlay (nodes) = Bolero.Html.attr.fragment "Overlay" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline overlayClassName (x: System.String) = "OverlayClassName" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline overlayEnterCls (x: System.String) = "OverlayEnterCls" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline overlayHiddenCls (x: System.String) = "OverlayHiddenCls" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline overlayLeaveCls (x: System.String) = "OverlayLeaveCls" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline overlayStyle (x: System.String) = "OverlayStyle" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline placement (x: AntDesign.PlacementType) = "Placement" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline placementCls (x: System.String) = "PlacementCls" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline popupContainerSelector (x: System.String) = "PopupContainerSelector" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline trigger (x: AntDesign.TriggerType[]) = "Trigger" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline triggerReference (x: Microsoft.AspNetCore.Components.ElementReference) = "TriggerReference" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline unbound (render: AntDesign.ForwardRef -> FunBlazorNode) = Bolero.Html.attr.fragmentWith "Unbound" (fun x -> render x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline visible (x: System.Boolean) = "Visible" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    
            
namespace rec Fun.Blazor.AntDesign.DslInternals

open Bolero.Html
open Fun.Blazor
open Fun.Blazor.Web.DslInternals
open Fun.Blazor.AntDesign.DslInternals


type dropdown<'FunBlazorGeneric> =
    inherit Internal.overlayTrigger<'FunBlazorGeneric>
    static member inline create () = [] |> html.blazor<AntDesign.Dropdown>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.Dropdown>
    static member inline create (nodes: FunBlazorNode list) = nodes |> html.blazor<AntDesign.Dropdown>
    static member inline create (node: FunBlazorNode) = [ node ] |> html.blazor<AntDesign.Dropdown>
    static member inline ref x = attr.ref x
    static member inline boundaryAdjustMode (x: AntDesign.TriggerBoundaryAdjustMode) = "BoundaryAdjustMode" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline complexAutoCloseAndVisible (x: System.Boolean) = "ComplexAutoCloseAndVisible" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabled (x: System.Boolean) = "Disabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline hiddenMode (x: System.Boolean) = "HiddenMode" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline inlineFlexMode (x: System.Boolean) = "InlineFlexMode" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline isButton (x: System.Boolean) = "IsButton" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onClick fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnClick" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onMaskClick (x: Microsoft.AspNetCore.Components.EventCallback) = "OnMaskClick" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onMouseEnter (x: System.Action) = "OnMouseEnter" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onMouseLeave (x: System.Action) = "OnMouseLeave" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onOverlayHiding fn = (Bolero.Html.attr.callback<System.Boolean> "OnOverlayHiding" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onVisibleChange fn = (Bolero.Html.attr.callback<System.Boolean> "OnVisibleChange" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline overlay (x: string) = Bolero.Html.attr.fragment "Overlay" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline overlay (node) = Bolero.Html.attr.fragment "Overlay" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline overlay (nodes) = Bolero.Html.attr.fragment "Overlay" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline overlayClassName (x: System.String) = "OverlayClassName" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline overlayEnterCls (x: System.String) = "OverlayEnterCls" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline overlayHiddenCls (x: System.String) = "OverlayHiddenCls" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline overlayLeaveCls (x: System.String) = "OverlayLeaveCls" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline overlayStyle (x: System.String) = "OverlayStyle" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline placement (x: AntDesign.PlacementType) = "Placement" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline placementCls (x: System.String) = "PlacementCls" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline popupContainerSelector (x: System.String) = "PopupContainerSelector" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline trigger (x: AntDesign.TriggerType[]) = "Trigger" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline triggerReference (x: Microsoft.AspNetCore.Components.ElementReference) = "TriggerReference" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline unbound (render: AntDesign.ForwardRef -> FunBlazorNode) = Bolero.Html.attr.fragmentWith "Unbound" (fun x -> render x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline visible (x: System.Boolean) = "Visible" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type dropdownButton<'FunBlazorGeneric> =
    inherit dropdown<'FunBlazorGeneric>
    static member inline create () = [] |> html.blazor<AntDesign.DropdownButton>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.DropdownButton>
    static member inline create (nodes: FunBlazorNode list) = nodes |> html.blazor<AntDesign.DropdownButton>
    static member inline create (node: FunBlazorNode) = [ node ] |> html.blazor<AntDesign.DropdownButton>
    static member inline ref x = attr.ref x
    static member inline block (x: System.Boolean) = "Block" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline buttonsRender (x: System.Func<Microsoft.AspNetCore.Components.RenderFragment, Microsoft.AspNetCore.Components.RenderFragment, Microsoft.AspNetCore.Components.RenderFragment>) = "ButtonsRender" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline danger (x: System.Boolean) = "Danger" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline ghost (x: System.Boolean) = "Ghost" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline icon (x: System.String) = "Icon" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline loading (x: System.Boolean) = "Loading" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline size (x: System.String) = "Size" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline type' (x: System.ValueTuple<System.String, System.String>) = "Type" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline boundaryAdjustMode (x: AntDesign.TriggerBoundaryAdjustMode) = "BoundaryAdjustMode" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline complexAutoCloseAndVisible (x: System.Boolean) = "ComplexAutoCloseAndVisible" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabled (x: System.Boolean) = "Disabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline hiddenMode (x: System.Boolean) = "HiddenMode" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline inlineFlexMode (x: System.Boolean) = "InlineFlexMode" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline isButton (x: System.Boolean) = "IsButton" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onClick fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnClick" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onMaskClick (x: Microsoft.AspNetCore.Components.EventCallback) = "OnMaskClick" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onMouseEnter (x: System.Action) = "OnMouseEnter" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onMouseLeave (x: System.Action) = "OnMouseLeave" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onOverlayHiding fn = (Bolero.Html.attr.callback<System.Boolean> "OnOverlayHiding" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onVisibleChange fn = (Bolero.Html.attr.callback<System.Boolean> "OnVisibleChange" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline overlay (x: string) = Bolero.Html.attr.fragment "Overlay" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline overlay (node) = Bolero.Html.attr.fragment "Overlay" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline overlay (nodes) = Bolero.Html.attr.fragment "Overlay" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline overlayClassName (x: System.String) = "OverlayClassName" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline overlayEnterCls (x: System.String) = "OverlayEnterCls" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline overlayHiddenCls (x: System.String) = "OverlayHiddenCls" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline overlayLeaveCls (x: System.String) = "OverlayLeaveCls" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline overlayStyle (x: System.String) = "OverlayStyle" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline placement (x: AntDesign.PlacementType) = "Placement" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline placementCls (x: System.String) = "PlacementCls" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline popupContainerSelector (x: System.String) = "PopupContainerSelector" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline trigger (x: AntDesign.TriggerType[]) = "Trigger" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline triggerReference (x: Microsoft.AspNetCore.Components.ElementReference) = "TriggerReference" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline unbound (render: AntDesign.ForwardRef -> FunBlazorNode) = Bolero.Html.attr.fragmentWith "Unbound" (fun x -> render x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline visible (x: System.Boolean) = "Visible" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type popconfirm<'FunBlazorGeneric> =
    inherit Internal.overlayTrigger<'FunBlazorGeneric>
    static member inline create () = [] |> html.blazor<AntDesign.Popconfirm>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.Popconfirm>
    static member inline create (nodes: FunBlazorNode list) = nodes |> html.blazor<AntDesign.Popconfirm>
    static member inline create (node: FunBlazorNode) = [ node ] |> html.blazor<AntDesign.Popconfirm>
    static member inline ref x = attr.ref x
    static member inline title (x: System.String) = "Title" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline titleTemplate (x: string) = Bolero.Html.attr.fragment "TitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline titleTemplate (node) = Bolero.Html.attr.fragment "TitleTemplate" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline titleTemplate (nodes) = Bolero.Html.attr.fragment "TitleTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline cancelText (x: System.String) = "CancelText" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline okText (x: System.String) = "OkText" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline okType (x: System.String) = "OkType" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline okButtonProps (x: AntDesign.ButtonProps) = "OkButtonProps" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline cancelButtonProps (x: AntDesign.ButtonProps) = "CancelButtonProps" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline icon (x: System.String) = "Icon" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline iconTemplate (x: string) = Bolero.Html.attr.fragment "IconTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline iconTemplate (node) = Bolero.Html.attr.fragment "IconTemplate" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline iconTemplate (nodes) = Bolero.Html.attr.fragment "IconTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onCancel fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnCancel" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onConfirm fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnConfirm" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline arrowPointAtCenter (x: System.Boolean) = "ArrowPointAtCenter" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline mouseEnterDelay (x: System.Double) = "MouseEnterDelay" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline mouseLeaveDelay (x: System.Double) = "MouseLeaveDelay" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline boundaryAdjustMode (x: AntDesign.TriggerBoundaryAdjustMode) = "BoundaryAdjustMode" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline complexAutoCloseAndVisible (x: System.Boolean) = "ComplexAutoCloseAndVisible" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabled (x: System.Boolean) = "Disabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline hiddenMode (x: System.Boolean) = "HiddenMode" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline inlineFlexMode (x: System.Boolean) = "InlineFlexMode" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline isButton (x: System.Boolean) = "IsButton" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onClick fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnClick" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onMaskClick (x: Microsoft.AspNetCore.Components.EventCallback) = "OnMaskClick" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onMouseEnter (x: System.Action) = "OnMouseEnter" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onMouseLeave (x: System.Action) = "OnMouseLeave" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onOverlayHiding fn = (Bolero.Html.attr.callback<System.Boolean> "OnOverlayHiding" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onVisibleChange fn = (Bolero.Html.attr.callback<System.Boolean> "OnVisibleChange" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline overlay (x: string) = Bolero.Html.attr.fragment "Overlay" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline overlay (node) = Bolero.Html.attr.fragment "Overlay" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline overlay (nodes) = Bolero.Html.attr.fragment "Overlay" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline overlayClassName (x: System.String) = "OverlayClassName" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline overlayEnterCls (x: System.String) = "OverlayEnterCls" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline overlayHiddenCls (x: System.String) = "OverlayHiddenCls" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline overlayLeaveCls (x: System.String) = "OverlayLeaveCls" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline overlayStyle (x: System.String) = "OverlayStyle" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline placement (x: AntDesign.PlacementType) = "Placement" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline placementCls (x: System.String) = "PlacementCls" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline popupContainerSelector (x: System.String) = "PopupContainerSelector" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline trigger (x: AntDesign.TriggerType[]) = "Trigger" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline triggerReference (x: Microsoft.AspNetCore.Components.ElementReference) = "TriggerReference" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline unbound (render: AntDesign.ForwardRef -> FunBlazorNode) = Bolero.Html.attr.fragmentWith "Unbound" (fun x -> render x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline visible (x: System.Boolean) = "Visible" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type popover<'FunBlazorGeneric> =
    inherit Internal.overlayTrigger<'FunBlazorGeneric>
    static member inline create () = [] |> html.blazor<AntDesign.Popover>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.Popover>
    static member inline create (nodes: FunBlazorNode list) = nodes |> html.blazor<AntDesign.Popover>
    static member inline create (node: FunBlazorNode) = [ node ] |> html.blazor<AntDesign.Popover>
    static member inline ref x = attr.ref x
    static member inline title (x: System.String) = "Title" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline titleTemplate (x: string) = Bolero.Html.attr.fragment "TitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline titleTemplate (node) = Bolero.Html.attr.fragment "TitleTemplate" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline titleTemplate (nodes) = Bolero.Html.attr.fragment "TitleTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline content (x: System.String) = "Content" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline contentTemplate (x: string) = Bolero.Html.attr.fragment "ContentTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline contentTemplate (node) = Bolero.Html.attr.fragment "ContentTemplate" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline contentTemplate (nodes) = Bolero.Html.attr.fragment "ContentTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline arrowPointAtCenter (x: System.Boolean) = "ArrowPointAtCenter" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline mouseEnterDelay (x: System.Double) = "MouseEnterDelay" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline mouseLeaveDelay (x: System.Double) = "MouseLeaveDelay" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline boundaryAdjustMode (x: AntDesign.TriggerBoundaryAdjustMode) = "BoundaryAdjustMode" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline complexAutoCloseAndVisible (x: System.Boolean) = "ComplexAutoCloseAndVisible" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabled (x: System.Boolean) = "Disabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline hiddenMode (x: System.Boolean) = "HiddenMode" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline inlineFlexMode (x: System.Boolean) = "InlineFlexMode" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline isButton (x: System.Boolean) = "IsButton" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onClick fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnClick" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onMaskClick (x: Microsoft.AspNetCore.Components.EventCallback) = "OnMaskClick" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onMouseEnter (x: System.Action) = "OnMouseEnter" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onMouseLeave (x: System.Action) = "OnMouseLeave" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onOverlayHiding fn = (Bolero.Html.attr.callback<System.Boolean> "OnOverlayHiding" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onVisibleChange fn = (Bolero.Html.attr.callback<System.Boolean> "OnVisibleChange" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline overlay (x: string) = Bolero.Html.attr.fragment "Overlay" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline overlay (node) = Bolero.Html.attr.fragment "Overlay" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline overlay (nodes) = Bolero.Html.attr.fragment "Overlay" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline overlayClassName (x: System.String) = "OverlayClassName" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline overlayEnterCls (x: System.String) = "OverlayEnterCls" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline overlayHiddenCls (x: System.String) = "OverlayHiddenCls" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline overlayLeaveCls (x: System.String) = "OverlayLeaveCls" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline overlayStyle (x: System.String) = "OverlayStyle" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline placement (x: AntDesign.PlacementType) = "Placement" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline placementCls (x: System.String) = "PlacementCls" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline popupContainerSelector (x: System.String) = "PopupContainerSelector" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline trigger (x: AntDesign.TriggerType[]) = "Trigger" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline triggerReference (x: Microsoft.AspNetCore.Components.ElementReference) = "TriggerReference" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline unbound (render: AntDesign.ForwardRef -> FunBlazorNode) = Bolero.Html.attr.fragmentWith "Unbound" (fun x -> render x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline visible (x: System.Boolean) = "Visible" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type tooltip<'FunBlazorGeneric> =
    inherit Internal.overlayTrigger<'FunBlazorGeneric>
    static member inline create () = [] |> html.blazor<AntDesign.Tooltip>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.Tooltip>
    static member inline create (nodes: FunBlazorNode list) = nodes |> html.blazor<AntDesign.Tooltip>
    static member inline create (node: FunBlazorNode) = [ node ] |> html.blazor<AntDesign.Tooltip>
    static member inline ref x = attr.ref x
    static member inline title (x: OneOf.OneOf<System.String, Microsoft.AspNetCore.Components.RenderFragment, Microsoft.AspNetCore.Components.MarkupString>) = "Title" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline arrowPointAtCenter (x: System.Boolean) = "ArrowPointAtCenter" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline mouseEnterDelay (x: System.Double) = "MouseEnterDelay" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline mouseLeaveDelay (x: System.Double) = "MouseLeaveDelay" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline boundaryAdjustMode (x: AntDesign.TriggerBoundaryAdjustMode) = "BoundaryAdjustMode" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline complexAutoCloseAndVisible (x: System.Boolean) = "ComplexAutoCloseAndVisible" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabled (x: System.Boolean) = "Disabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline hiddenMode (x: System.Boolean) = "HiddenMode" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline inlineFlexMode (x: System.Boolean) = "InlineFlexMode" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline isButton (x: System.Boolean) = "IsButton" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onClick fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnClick" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onMaskClick (x: Microsoft.AspNetCore.Components.EventCallback) = "OnMaskClick" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onMouseEnter (x: System.Action) = "OnMouseEnter" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onMouseLeave (x: System.Action) = "OnMouseLeave" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onOverlayHiding fn = (Bolero.Html.attr.callback<System.Boolean> "OnOverlayHiding" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onVisibleChange fn = (Bolero.Html.attr.callback<System.Boolean> "OnVisibleChange" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline overlay (x: string) = Bolero.Html.attr.fragment "Overlay" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline overlay (node) = Bolero.Html.attr.fragment "Overlay" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline overlay (nodes) = Bolero.Html.attr.fragment "Overlay" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline overlayClassName (x: System.String) = "OverlayClassName" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline overlayEnterCls (x: System.String) = "OverlayEnterCls" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline overlayHiddenCls (x: System.String) = "OverlayHiddenCls" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline overlayLeaveCls (x: System.String) = "OverlayLeaveCls" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline overlayStyle (x: System.String) = "OverlayStyle" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline placement (x: AntDesign.PlacementType) = "Placement" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline placementCls (x: System.String) = "PlacementCls" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline popupContainerSelector (x: System.String) = "PopupContainerSelector" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline trigger (x: AntDesign.TriggerType[]) = "Trigger" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline triggerReference (x: Microsoft.AspNetCore.Components.ElementReference) = "TriggerReference" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline unbound (render: AntDesign.ForwardRef -> FunBlazorNode) = Bolero.Html.attr.fragmentWith "Unbound" (fun x -> render x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline visible (x: System.Boolean) = "Visible" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    
            
namespace rec Fun.Blazor.AntDesign.DslInternals.Internal

open Bolero.Html
open Fun.Blazor
open Fun.Blazor.Web.DslInternals
open Fun.Blazor.AntDesign.DslInternals


type subMenuTrigger<'FunBlazorGeneric> =
    inherit Internal.overlayTrigger<'FunBlazorGeneric>
    static member inline create () = [] |> html.blazor<AntDesign.Internal.SubMenuTrigger>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.Internal.SubMenuTrigger>
    static member inline create (nodes: FunBlazorNode list) = nodes |> html.blazor<AntDesign.Internal.SubMenuTrigger>
    static member inline create (node: FunBlazorNode) = [ node ] |> html.blazor<AntDesign.Internal.SubMenuTrigger>
    static member inline ref x = attr.ref x
    static member inline triggerClass (x: System.String) = "TriggerClass" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline boundaryAdjustMode (x: AntDesign.TriggerBoundaryAdjustMode) = "BoundaryAdjustMode" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline complexAutoCloseAndVisible (x: System.Boolean) = "ComplexAutoCloseAndVisible" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabled (x: System.Boolean) = "Disabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline hiddenMode (x: System.Boolean) = "HiddenMode" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline inlineFlexMode (x: System.Boolean) = "InlineFlexMode" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline isButton (x: System.Boolean) = "IsButton" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onClick fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnClick" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onMaskClick (x: Microsoft.AspNetCore.Components.EventCallback) = "OnMaskClick" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onMouseEnter (x: System.Action) = "OnMouseEnter" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onMouseLeave (x: System.Action) = "OnMouseLeave" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onOverlayHiding fn = (Bolero.Html.attr.callback<System.Boolean> "OnOverlayHiding" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onVisibleChange fn = (Bolero.Html.attr.callback<System.Boolean> "OnVisibleChange" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline overlay (x: string) = Bolero.Html.attr.fragment "Overlay" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline overlay (node) = Bolero.Html.attr.fragment "Overlay" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline overlay (nodes) = Bolero.Html.attr.fragment "Overlay" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline overlayClassName (x: System.String) = "OverlayClassName" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline overlayEnterCls (x: System.String) = "OverlayEnterCls" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline overlayHiddenCls (x: System.String) = "OverlayHiddenCls" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline overlayLeaveCls (x: System.String) = "OverlayLeaveCls" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline overlayStyle (x: System.String) = "OverlayStyle" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline placement (x: AntDesign.PlacementType) = "Placement" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline placementCls (x: System.String) = "PlacementCls" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline popupContainerSelector (x: System.String) = "PopupContainerSelector" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline trigger (x: AntDesign.TriggerType[]) = "Trigger" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline triggerReference (x: Microsoft.AspNetCore.Components.ElementReference) = "TriggerReference" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline unbound (render: AntDesign.ForwardRef -> FunBlazorNode) = Bolero.Html.attr.fragmentWith "Unbound" (fun x -> render x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline visible (x: System.Boolean) = "Visible" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type datePickerPanelChooser<'FunBlazorGeneric, 'TValue> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = [] |> html.blazor<AntDesign.Internal.DatePickerPanelChooser<'TValue>>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.Internal.DatePickerPanelChooser<'TValue>>

    static member inline ref x = attr.ref x
    static member inline datePicker (x: AntDesign.DatePickerBase<'TValue>) = "DatePicker" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onSelect (x: System.Action<System.DateTime, System.Int32>) = "OnSelect" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline pickerIndex (x: System.Int32) = "PickerIndex" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type pickerPanelBase<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = [] |> html.blazor<AntDesign.Internal.PickerPanelBase>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.Internal.PickerPanelBase>

    static member inline ref x = attr.ref x
    static member inline onSelect (x: System.Action<System.DateTime, System.Int32>) = "OnSelect" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline pickerIndex (x: System.Int32) = "PickerIndex" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    
            
namespace rec Fun.Blazor.AntDesign.DslInternals

open Bolero.Html
open Fun.Blazor
open Fun.Blazor.Web.DslInternals
open Fun.Blazor.AntDesign.DslInternals


type datePickerPanelBase<'FunBlazorGeneric, 'TValue> =
    inherit Internal.pickerPanelBase<'FunBlazorGeneric>
    static member inline create () = [] |> html.blazor<AntDesign.DatePickerPanelBase<'TValue>>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.DatePickerPanelBase<'TValue>>

    static member inline ref x = attr.ref x
    static member inline prefixCls (x: System.String) = "PrefixCls" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline picker (x: System.String) = "Picker" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline isRange (x: System.Boolean) = "IsRange" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline isCalendar (x: System.Boolean) = "IsCalendar" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline isShowHeader (x: System.Boolean) = "IsShowHeader" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline locale (x: AntDesign.DatePickerLocale) = "Locale" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline cultureInfo (x: System.Globalization.CultureInfo) = "CultureInfo" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline closePanel (x: System.Action) = "ClosePanel" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline changePickerValue (x: System.Action<System.DateTime, System.Nullable<System.Int32>>) = "ChangePickerValue" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline changeValue (x: System.Action<System.DateTime, System.Int32>) = "ChangeValue" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline changePickerType (x: System.Action<System.String, System.Int32>) = "ChangePickerType" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline getIndexPickerValue (x: System.Func<System.Int32, System.DateTime>) = "GetIndexPickerValue" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline getIndexValue (x: System.Func<System.Int32, System.Nullable<System.DateTime>>) = "GetIndexValue" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabledDate (x: System.Func<System.DateTime, System.Boolean>) = "DisabledDate" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline dateRender (x: System.Func<System.DateTime, System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "DateRender" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline monthCellRender (x: System.Func<System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "MonthCellRender" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline calendarDateRender (x: System.Func<System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "CalendarDateRender" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline calendarMonthCellRender (x: System.Func<System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "CalendarMonthCellRender" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline renderExtraFooter (x: string) = Bolero.Html.attr.fragment "RenderExtraFooter" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline renderExtraFooter (node) = Bolero.Html.attr.fragment "RenderExtraFooter" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline renderExtraFooter (nodes) = Bolero.Html.attr.fragment "RenderExtraFooter" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onSelect (x: System.Action<System.DateTime, System.Int32>) = "OnSelect" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline pickerIndex (x: System.Int32) = "PickerIndex" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    
            
namespace rec Fun.Blazor.AntDesign.DslInternals.Internal

open Bolero.Html
open Fun.Blazor
open Fun.Blazor.Web.DslInternals
open Fun.Blazor.AntDesign.DslInternals


type datePickerDatetimePanel<'FunBlazorGeneric, 'TValue> =
    inherit datePickerPanelBase<'FunBlazorGeneric, 'TValue>
    static member inline create () = [] |> html.blazor<AntDesign.Internal.DatePickerDatetimePanel<'TValue>>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.Internal.DatePickerDatetimePanel<'TValue>>

    static member inline ref x = attr.ref x
    static member inline showToday (x: System.Boolean) = "ShowToday" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline isShowTime (x: System.Boolean) = "IsShowTime" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline showTimeFormat (x: System.String) = "ShowTimeFormat" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline format (x: System.String) = "Format" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabledHours (x: System.Func<System.DateTime, System.Int32[]>) = "DisabledHours" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabledMinutes (x: System.Func<System.DateTime, System.Int32[]>) = "DisabledMinutes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabledSeconds (x: System.Func<System.DateTime, System.Int32[]>) = "DisabledSeconds" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabledTime (x: System.Func<System.DateTime, AntDesign.DatePickerDisabledTime>) = "DisabledTime" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline prefixCls (x: System.String) = "PrefixCls" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline picker (x: System.String) = "Picker" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline isRange (x: System.Boolean) = "IsRange" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline isCalendar (x: System.Boolean) = "IsCalendar" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline isShowHeader (x: System.Boolean) = "IsShowHeader" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline locale (x: AntDesign.DatePickerLocale) = "Locale" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline cultureInfo (x: System.Globalization.CultureInfo) = "CultureInfo" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline closePanel (x: System.Action) = "ClosePanel" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline changePickerValue (x: System.Action<System.DateTime, System.Nullable<System.Int32>>) = "ChangePickerValue" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline changeValue (x: System.Action<System.DateTime, System.Int32>) = "ChangeValue" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline changePickerType (x: System.Action<System.String, System.Int32>) = "ChangePickerType" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline getIndexPickerValue (x: System.Func<System.Int32, System.DateTime>) = "GetIndexPickerValue" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline getIndexValue (x: System.Func<System.Int32, System.Nullable<System.DateTime>>) = "GetIndexValue" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabledDate (x: System.Func<System.DateTime, System.Boolean>) = "DisabledDate" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline dateRender (x: System.Func<System.DateTime, System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "DateRender" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline monthCellRender (x: System.Func<System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "MonthCellRender" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline calendarDateRender (x: System.Func<System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "CalendarDateRender" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline calendarMonthCellRender (x: System.Func<System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "CalendarMonthCellRender" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline renderExtraFooter (x: string) = Bolero.Html.attr.fragment "RenderExtraFooter" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline renderExtraFooter (node) = Bolero.Html.attr.fragment "RenderExtraFooter" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline renderExtraFooter (nodes) = Bolero.Html.attr.fragment "RenderExtraFooter" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onSelect (x: System.Action<System.DateTime, System.Int32>) = "OnSelect" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline pickerIndex (x: System.Int32) = "PickerIndex" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type datePickerTemplate<'FunBlazorGeneric, 'TValue> =
    inherit datePickerPanelBase<'FunBlazorGeneric, 'TValue>
    static member inline create () = [] |> html.blazor<AntDesign.Internal.DatePickerTemplate<'TValue>>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.Internal.DatePickerTemplate<'TValue>>

    static member inline ref x = attr.ref x
    static member inline renderPickerHeader (x: string) = Bolero.Html.attr.fragment "RenderPickerHeader" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline renderPickerHeader (node) = Bolero.Html.attr.fragment "RenderPickerHeader" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline renderPickerHeader (nodes) = Bolero.Html.attr.fragment "RenderPickerHeader" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline renderTableHeader (x: string) = Bolero.Html.attr.fragment "RenderTableHeader" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline renderTableHeader (node) = Bolero.Html.attr.fragment "RenderTableHeader" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline renderTableHeader (nodes) = Bolero.Html.attr.fragment "RenderTableHeader" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline renderFirstCol (render: System.DateTime -> FunBlazorNode) = Bolero.Html.attr.fragmentWith "RenderFirstCol" (fun x -> render x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline renderColValue (render: System.DateTime -> FunBlazorNode) = Bolero.Html.attr.fragmentWith "RenderColValue" (fun x -> render x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline renderLastCol (render: System.DateTime -> FunBlazorNode) = Bolero.Html.attr.fragmentWith "RenderLastCol" (fun x -> render x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline viewStartDate (x: System.DateTime) = "ViewStartDate" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline getColTitle (x: System.Func<System.DateTime, System.String>) = "GetColTitle" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline getRowClass (x: System.Func<System.DateTime, System.String>) = "GetRowClass" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline getNextColValue (x: System.Func<System.DateTime, System.DateTime>) = "GetNextColValue" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline isInView (x: System.Func<System.DateTime, System.Boolean>) = "IsInView" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline isToday (x: System.Func<System.DateTime, System.Boolean>) = "IsToday" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline isSelected (x: System.Func<System.DateTime, System.Boolean>) = "IsSelected" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onRowSelect (x: System.Action<System.DateTime>) = "OnRowSelect" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onValueSelect (x: System.Action<System.DateTime>) = "OnValueSelect" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline showFooter (x: System.Boolean) = "ShowFooter" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline maxRow (x: System.Int32) = "MaxRow" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline maxCol (x: System.Int32) = "MaxCol" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline prefixCls (x: System.String) = "PrefixCls" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline picker (x: System.String) = "Picker" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline isRange (x: System.Boolean) = "IsRange" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline isCalendar (x: System.Boolean) = "IsCalendar" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline isShowHeader (x: System.Boolean) = "IsShowHeader" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline locale (x: AntDesign.DatePickerLocale) = "Locale" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline cultureInfo (x: System.Globalization.CultureInfo) = "CultureInfo" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline closePanel (x: System.Action) = "ClosePanel" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline changePickerValue (x: System.Action<System.DateTime, System.Nullable<System.Int32>>) = "ChangePickerValue" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline changeValue (x: System.Action<System.DateTime, System.Int32>) = "ChangeValue" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline changePickerType (x: System.Action<System.String, System.Int32>) = "ChangePickerType" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline getIndexPickerValue (x: System.Func<System.Int32, System.DateTime>) = "GetIndexPickerValue" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline getIndexValue (x: System.Func<System.Int32, System.Nullable<System.DateTime>>) = "GetIndexValue" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabledDate (x: System.Func<System.DateTime, System.Boolean>) = "DisabledDate" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline dateRender (x: System.Func<System.DateTime, System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "DateRender" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline monthCellRender (x: System.Func<System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "MonthCellRender" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline calendarDateRender (x: System.Func<System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "CalendarDateRender" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline calendarMonthCellRender (x: System.Func<System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "CalendarMonthCellRender" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline renderExtraFooter (x: string) = Bolero.Html.attr.fragment "RenderExtraFooter" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline renderExtraFooter (node) = Bolero.Html.attr.fragment "RenderExtraFooter" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline renderExtraFooter (nodes) = Bolero.Html.attr.fragment "RenderExtraFooter" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onSelect (x: System.Action<System.DateTime, System.Int32>) = "OnSelect" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline pickerIndex (x: System.Int32) = "PickerIndex" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type datePickerDatePanel<'FunBlazorGeneric, 'TValue> =
    inherit datePickerPanelBase<'FunBlazorGeneric, 'TValue>
    static member inline create () = [] |> html.blazor<AntDesign.Internal.DatePickerDatePanel<'TValue>>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.Internal.DatePickerDatePanel<'TValue>>

    static member inline ref x = attr.ref x
    static member inline isWeek (x: System.Boolean) = "IsWeek" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline showToday (x: System.Boolean) = "ShowToday" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline prefixCls (x: System.String) = "PrefixCls" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline picker (x: System.String) = "Picker" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline isRange (x: System.Boolean) = "IsRange" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline isCalendar (x: System.Boolean) = "IsCalendar" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline isShowHeader (x: System.Boolean) = "IsShowHeader" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline locale (x: AntDesign.DatePickerLocale) = "Locale" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline cultureInfo (x: System.Globalization.CultureInfo) = "CultureInfo" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline closePanel (x: System.Action) = "ClosePanel" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline changePickerValue (x: System.Action<System.DateTime, System.Nullable<System.Int32>>) = "ChangePickerValue" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline changeValue (x: System.Action<System.DateTime, System.Int32>) = "ChangeValue" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline changePickerType (x: System.Action<System.String, System.Int32>) = "ChangePickerType" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline getIndexPickerValue (x: System.Func<System.Int32, System.DateTime>) = "GetIndexPickerValue" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline getIndexValue (x: System.Func<System.Int32, System.Nullable<System.DateTime>>) = "GetIndexValue" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabledDate (x: System.Func<System.DateTime, System.Boolean>) = "DisabledDate" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline dateRender (x: System.Func<System.DateTime, System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "DateRender" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline monthCellRender (x: System.Func<System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "MonthCellRender" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline calendarDateRender (x: System.Func<System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "CalendarDateRender" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline calendarMonthCellRender (x: System.Func<System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "CalendarMonthCellRender" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline renderExtraFooter (x: string) = Bolero.Html.attr.fragment "RenderExtraFooter" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline renderExtraFooter (node) = Bolero.Html.attr.fragment "RenderExtraFooter" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline renderExtraFooter (nodes) = Bolero.Html.attr.fragment "RenderExtraFooter" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onSelect (x: System.Action<System.DateTime, System.Int32>) = "OnSelect" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline pickerIndex (x: System.Int32) = "PickerIndex" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type datePickerDecadePanel<'FunBlazorGeneric, 'TValue> =
    inherit datePickerPanelBase<'FunBlazorGeneric, 'TValue>
    static member inline create () = [] |> html.blazor<AntDesign.Internal.DatePickerDecadePanel<'TValue>>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.Internal.DatePickerDecadePanel<'TValue>>

    static member inline ref x = attr.ref x
    static member inline prefixCls (x: System.String) = "PrefixCls" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline picker (x: System.String) = "Picker" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline isRange (x: System.Boolean) = "IsRange" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline isCalendar (x: System.Boolean) = "IsCalendar" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline isShowHeader (x: System.Boolean) = "IsShowHeader" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline locale (x: AntDesign.DatePickerLocale) = "Locale" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline cultureInfo (x: System.Globalization.CultureInfo) = "CultureInfo" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline closePanel (x: System.Action) = "ClosePanel" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline changePickerValue (x: System.Action<System.DateTime, System.Nullable<System.Int32>>) = "ChangePickerValue" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline changeValue (x: System.Action<System.DateTime, System.Int32>) = "ChangeValue" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline changePickerType (x: System.Action<System.String, System.Int32>) = "ChangePickerType" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline getIndexPickerValue (x: System.Func<System.Int32, System.DateTime>) = "GetIndexPickerValue" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline getIndexValue (x: System.Func<System.Int32, System.Nullable<System.DateTime>>) = "GetIndexValue" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabledDate (x: System.Func<System.DateTime, System.Boolean>) = "DisabledDate" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline dateRender (x: System.Func<System.DateTime, System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "DateRender" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline monthCellRender (x: System.Func<System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "MonthCellRender" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline calendarDateRender (x: System.Func<System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "CalendarDateRender" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline calendarMonthCellRender (x: System.Func<System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "CalendarMonthCellRender" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline renderExtraFooter (x: string) = Bolero.Html.attr.fragment "RenderExtraFooter" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline renderExtraFooter (node) = Bolero.Html.attr.fragment "RenderExtraFooter" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline renderExtraFooter (nodes) = Bolero.Html.attr.fragment "RenderExtraFooter" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onSelect (x: System.Action<System.DateTime, System.Int32>) = "OnSelect" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline pickerIndex (x: System.Int32) = "PickerIndex" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type datePickerFooter<'FunBlazorGeneric, 'TValue> =
    inherit datePickerPanelBase<'FunBlazorGeneric, 'TValue>
    static member inline create () = [] |> html.blazor<AntDesign.Internal.DatePickerFooter<'TValue>>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.Internal.DatePickerFooter<'TValue>>

    static member inline ref x = attr.ref x
    static member inline prefixCls (x: System.String) = "PrefixCls" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline picker (x: System.String) = "Picker" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline isRange (x: System.Boolean) = "IsRange" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline isCalendar (x: System.Boolean) = "IsCalendar" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline isShowHeader (x: System.Boolean) = "IsShowHeader" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline locale (x: AntDesign.DatePickerLocale) = "Locale" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline cultureInfo (x: System.Globalization.CultureInfo) = "CultureInfo" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline closePanel (x: System.Action) = "ClosePanel" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline changePickerValue (x: System.Action<System.DateTime, System.Nullable<System.Int32>>) = "ChangePickerValue" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline changeValue (x: System.Action<System.DateTime, System.Int32>) = "ChangeValue" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline changePickerType (x: System.Action<System.String, System.Int32>) = "ChangePickerType" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline getIndexPickerValue (x: System.Func<System.Int32, System.DateTime>) = "GetIndexPickerValue" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline getIndexValue (x: System.Func<System.Int32, System.Nullable<System.DateTime>>) = "GetIndexValue" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabledDate (x: System.Func<System.DateTime, System.Boolean>) = "DisabledDate" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline dateRender (x: System.Func<System.DateTime, System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "DateRender" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline monthCellRender (x: System.Func<System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "MonthCellRender" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline calendarDateRender (x: System.Func<System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "CalendarDateRender" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline calendarMonthCellRender (x: System.Func<System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "CalendarMonthCellRender" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline renderExtraFooter (x: string) = Bolero.Html.attr.fragment "RenderExtraFooter" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline renderExtraFooter (node) = Bolero.Html.attr.fragment "RenderExtraFooter" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline renderExtraFooter (nodes) = Bolero.Html.attr.fragment "RenderExtraFooter" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onSelect (x: System.Action<System.DateTime, System.Int32>) = "OnSelect" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline pickerIndex (x: System.Int32) = "PickerIndex" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type datePickerHeader<'FunBlazorGeneric, 'TValue> =
    inherit datePickerPanelBase<'FunBlazorGeneric, 'TValue>
    static member inline create () = [] |> html.blazor<AntDesign.Internal.DatePickerHeader<'TValue>>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.Internal.DatePickerHeader<'TValue>>

    static member inline ref x = attr.ref x
    static member inline superChangeDateInterval (x: System.Int32) = "SuperChangeDateInterval" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline changeDateInterval (x: System.Int32) = "ChangeDateInterval" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline showSuperPreChange (x: System.Boolean) = "ShowSuperPreChange" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline showPreChange (x: System.Boolean) = "ShowPreChange" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline showNextChange (x: System.Boolean) = "ShowNextChange" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline showSuperNextChange (x: System.Boolean) = "ShowSuperNextChange" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline prefixCls (x: System.String) = "PrefixCls" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline picker (x: System.String) = "Picker" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline isRange (x: System.Boolean) = "IsRange" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline isCalendar (x: System.Boolean) = "IsCalendar" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline isShowHeader (x: System.Boolean) = "IsShowHeader" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline locale (x: AntDesign.DatePickerLocale) = "Locale" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline cultureInfo (x: System.Globalization.CultureInfo) = "CultureInfo" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline closePanel (x: System.Action) = "ClosePanel" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline changePickerValue (x: System.Action<System.DateTime, System.Nullable<System.Int32>>) = "ChangePickerValue" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline changeValue (x: System.Action<System.DateTime, System.Int32>) = "ChangeValue" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline changePickerType (x: System.Action<System.String, System.Int32>) = "ChangePickerType" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline getIndexPickerValue (x: System.Func<System.Int32, System.DateTime>) = "GetIndexPickerValue" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline getIndexValue (x: System.Func<System.Int32, System.Nullable<System.DateTime>>) = "GetIndexValue" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabledDate (x: System.Func<System.DateTime, System.Boolean>) = "DisabledDate" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline dateRender (x: System.Func<System.DateTime, System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "DateRender" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline monthCellRender (x: System.Func<System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "MonthCellRender" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline calendarDateRender (x: System.Func<System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "CalendarDateRender" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline calendarMonthCellRender (x: System.Func<System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "CalendarMonthCellRender" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline renderExtraFooter (x: string) = Bolero.Html.attr.fragment "RenderExtraFooter" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline renderExtraFooter (node) = Bolero.Html.attr.fragment "RenderExtraFooter" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline renderExtraFooter (nodes) = Bolero.Html.attr.fragment "RenderExtraFooter" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onSelect (x: System.Action<System.DateTime, System.Int32>) = "OnSelect" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline pickerIndex (x: System.Int32) = "PickerIndex" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type datePickerMonthPanel<'FunBlazorGeneric, 'TValue> =
    inherit datePickerPanelBase<'FunBlazorGeneric, 'TValue>
    static member inline create () = [] |> html.blazor<AntDesign.Internal.DatePickerMonthPanel<'TValue>>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.Internal.DatePickerMonthPanel<'TValue>>

    static member inline ref x = attr.ref x
    static member inline prefixCls (x: System.String) = "PrefixCls" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline picker (x: System.String) = "Picker" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline isRange (x: System.Boolean) = "IsRange" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline isCalendar (x: System.Boolean) = "IsCalendar" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline isShowHeader (x: System.Boolean) = "IsShowHeader" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline locale (x: AntDesign.DatePickerLocale) = "Locale" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline cultureInfo (x: System.Globalization.CultureInfo) = "CultureInfo" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline closePanel (x: System.Action) = "ClosePanel" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline changePickerValue (x: System.Action<System.DateTime, System.Nullable<System.Int32>>) = "ChangePickerValue" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline changeValue (x: System.Action<System.DateTime, System.Int32>) = "ChangeValue" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline changePickerType (x: System.Action<System.String, System.Int32>) = "ChangePickerType" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline getIndexPickerValue (x: System.Func<System.Int32, System.DateTime>) = "GetIndexPickerValue" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline getIndexValue (x: System.Func<System.Int32, System.Nullable<System.DateTime>>) = "GetIndexValue" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabledDate (x: System.Func<System.DateTime, System.Boolean>) = "DisabledDate" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline dateRender (x: System.Func<System.DateTime, System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "DateRender" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline monthCellRender (x: System.Func<System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "MonthCellRender" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline calendarDateRender (x: System.Func<System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "CalendarDateRender" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline calendarMonthCellRender (x: System.Func<System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "CalendarMonthCellRender" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline renderExtraFooter (x: string) = Bolero.Html.attr.fragment "RenderExtraFooter" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline renderExtraFooter (node) = Bolero.Html.attr.fragment "RenderExtraFooter" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline renderExtraFooter (nodes) = Bolero.Html.attr.fragment "RenderExtraFooter" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onSelect (x: System.Action<System.DateTime, System.Int32>) = "OnSelect" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline pickerIndex (x: System.Int32) = "PickerIndex" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type datePickerQuarterPanel<'FunBlazorGeneric, 'TValue> =
    inherit datePickerPanelBase<'FunBlazorGeneric, 'TValue>
    static member inline create () = [] |> html.blazor<AntDesign.Internal.DatePickerQuarterPanel<'TValue>>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.Internal.DatePickerQuarterPanel<'TValue>>

    static member inline ref x = attr.ref x
    static member inline prefixCls (x: System.String) = "PrefixCls" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline picker (x: System.String) = "Picker" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline isRange (x: System.Boolean) = "IsRange" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline isCalendar (x: System.Boolean) = "IsCalendar" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline isShowHeader (x: System.Boolean) = "IsShowHeader" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline locale (x: AntDesign.DatePickerLocale) = "Locale" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline cultureInfo (x: System.Globalization.CultureInfo) = "CultureInfo" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline closePanel (x: System.Action) = "ClosePanel" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline changePickerValue (x: System.Action<System.DateTime, System.Nullable<System.Int32>>) = "ChangePickerValue" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline changeValue (x: System.Action<System.DateTime, System.Int32>) = "ChangeValue" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline changePickerType (x: System.Action<System.String, System.Int32>) = "ChangePickerType" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline getIndexPickerValue (x: System.Func<System.Int32, System.DateTime>) = "GetIndexPickerValue" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline getIndexValue (x: System.Func<System.Int32, System.Nullable<System.DateTime>>) = "GetIndexValue" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabledDate (x: System.Func<System.DateTime, System.Boolean>) = "DisabledDate" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline dateRender (x: System.Func<System.DateTime, System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "DateRender" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline monthCellRender (x: System.Func<System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "MonthCellRender" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline calendarDateRender (x: System.Func<System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "CalendarDateRender" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline calendarMonthCellRender (x: System.Func<System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "CalendarMonthCellRender" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline renderExtraFooter (x: string) = Bolero.Html.attr.fragment "RenderExtraFooter" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline renderExtraFooter (node) = Bolero.Html.attr.fragment "RenderExtraFooter" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline renderExtraFooter (nodes) = Bolero.Html.attr.fragment "RenderExtraFooter" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onSelect (x: System.Action<System.DateTime, System.Int32>) = "OnSelect" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline pickerIndex (x: System.Int32) = "PickerIndex" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type datePickerYearPanel<'FunBlazorGeneric, 'TValue> =
    inherit datePickerPanelBase<'FunBlazorGeneric, 'TValue>
    static member inline create () = [] |> html.blazor<AntDesign.Internal.DatePickerYearPanel<'TValue>>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.Internal.DatePickerYearPanel<'TValue>>

    static member inline ref x = attr.ref x
    static member inline prefixCls (x: System.String) = "PrefixCls" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline picker (x: System.String) = "Picker" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline isRange (x: System.Boolean) = "IsRange" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline isCalendar (x: System.Boolean) = "IsCalendar" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline isShowHeader (x: System.Boolean) = "IsShowHeader" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline locale (x: AntDesign.DatePickerLocale) = "Locale" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline cultureInfo (x: System.Globalization.CultureInfo) = "CultureInfo" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline closePanel (x: System.Action) = "ClosePanel" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline changePickerValue (x: System.Action<System.DateTime, System.Nullable<System.Int32>>) = "ChangePickerValue" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline changeValue (x: System.Action<System.DateTime, System.Int32>) = "ChangeValue" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline changePickerType (x: System.Action<System.String, System.Int32>) = "ChangePickerType" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline getIndexPickerValue (x: System.Func<System.Int32, System.DateTime>) = "GetIndexPickerValue" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline getIndexValue (x: System.Func<System.Int32, System.Nullable<System.DateTime>>) = "GetIndexValue" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabledDate (x: System.Func<System.DateTime, System.Boolean>) = "DisabledDate" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline dateRender (x: System.Func<System.DateTime, System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "DateRender" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline monthCellRender (x: System.Func<System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "MonthCellRender" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline calendarDateRender (x: System.Func<System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "CalendarDateRender" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline calendarMonthCellRender (x: System.Func<System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "CalendarMonthCellRender" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline renderExtraFooter (x: string) = Bolero.Html.attr.fragment "RenderExtraFooter" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline renderExtraFooter (node) = Bolero.Html.attr.fragment "RenderExtraFooter" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline renderExtraFooter (nodes) = Bolero.Html.attr.fragment "RenderExtraFooter" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onSelect (x: System.Action<System.DateTime, System.Int32>) = "OnSelect" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline pickerIndex (x: System.Int32) = "PickerIndex" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type datePickerInput<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = [] |> html.blazor<AntDesign.Internal.DatePickerInput>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.Internal.DatePickerInput>

    static member inline ref x = attr.ref x
    static member inline prefixCls (x: System.String) = "PrefixCls" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline size (x: System.String) = "Size" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline value (x: System.String) = "Value" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline placeholder (x: System.String) = "Placeholder" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline readOnly (x: System.Boolean) = "ReadOnly" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline isRange (x: System.Boolean) = "IsRange" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabled (x: System.Boolean) = "Disabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline autoFocus (x: System.Boolean) = "AutoFocus" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline showSuffixIcon (x: System.Boolean) = "ShowSuffixIcon" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline showTime (x: System.Boolean) = "ShowTime" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline suffixIcon (x: string) = Bolero.Html.attr.fragment "SuffixIcon" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline suffixIcon (node) = Bolero.Html.attr.fragment "SuffixIcon" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline suffixIcon (nodes) = Bolero.Html.attr.fragment "SuffixIcon" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onClick (x: Microsoft.AspNetCore.Components.EventCallback) = "OnClick" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onfocus (x: Microsoft.AspNetCore.Components.EventCallback) = "Onfocus" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onBlur (x: Microsoft.AspNetCore.Components.EventCallback) = "OnBlur" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onfocusout (x: Microsoft.AspNetCore.Components.EventCallback) = "Onfocusout" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onKeyUp fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs> "OnKeyUp" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onKeyDown fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs> "OnKeyDown" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onInput fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.ChangeEventArgs> "OnInput" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline allowClear (x: System.Boolean) = "AllowClear" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onClickClear (x: Microsoft.AspNetCore.Components.EventCallback) = "OnClickClear" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type dropdownGroupButton<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = [] |> html.blazor<AntDesign.Internal.DropdownGroupButton>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.Internal.DropdownGroupButton>

    static member inline ref x = attr.ref x
    static member inline leftButton (x: string) = Bolero.Html.attr.fragment "LeftButton" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline leftButton (node) = Bolero.Html.attr.fragment "LeftButton" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline leftButton (nodes) = Bolero.Html.attr.fragment "LeftButton" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline rightButton (x: string) = Bolero.Html.attr.fragment "RightButton" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline rightButton (node) = Bolero.Html.attr.fragment "RightButton" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline rightButton (nodes) = Bolero.Html.attr.fragment "RightButton" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline id (x: System.String) = "Id" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    
            
namespace rec Fun.Blazor.AntDesign.DslInternals

open Bolero.Html
open Fun.Blazor
open Fun.Blazor.Web.DslInternals
open Fun.Blazor.AntDesign.DslInternals


type templateComponentBase<'FunBlazorGeneric, 'TComponentOptions> =
    inherit antComponentBase<'FunBlazorGeneric>
    static member inline create () = [] |> html.blazor<AntDesign.TemplateComponentBase<'TComponentOptions>>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.TemplateComponentBase<'TComponentOptions>>

    static member inline ref x = attr.ref x
    static member inline options (x: 'TComponentOptions) = "Options" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type feedbackComponent<'FunBlazorGeneric, 'TComponentOptions> =
    inherit templateComponentBase<'FunBlazorGeneric, 'TComponentOptions>
    static member inline create () = [] |> html.blazor<AntDesign.FeedbackComponent<'TComponentOptions>>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.FeedbackComponent<'TComponentOptions>>

    static member inline ref x = attr.ref x
    static member inline feedbackRef (x: AntDesign.IFeedbackRef) = "FeedbackRef" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline options (x: 'TComponentOptions) = "Options" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type feedbackComponent<'FunBlazorGeneric, 'TComponentOptions, 'TResult> =
    inherit feedbackComponent<'FunBlazorGeneric, 'TComponentOptions>
    static member inline create () = [] |> html.blazor<AntDesign.FeedbackComponent<'TComponentOptions, 'TResult>>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.FeedbackComponent<'TComponentOptions, 'TResult>>

    static member inline ref x = attr.ref x
    static member inline feedbackRef (x: AntDesign.IFeedbackRef) = "FeedbackRef" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline options (x: 'TComponentOptions) = "Options" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type formProvider<'FunBlazorGeneric> =
    inherit antComponentBase<'FunBlazorGeneric>
    static member inline create () = [] |> html.blazor<AntDesign.FormProvider>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.FormProvider>
    static member inline create (nodes: FunBlazorNode list) = nodes |> html.blazor<AntDesign.FormProvider>
    static member inline create (node: FunBlazorNode) = [ node ] |> html.blazor<AntDesign.FormProvider>
    static member inline ref x = attr.ref x
    static member inline onFormFinish fn = (Bolero.Html.attr.callback<AntDesign.FormProviderFinishEventArgs> "OnFormFinish" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    
            
namespace rec Fun.Blazor.AntDesign.DslInternals.Internal

open Bolero.Html
open Fun.Blazor
open Fun.Blazor.Web.DslInternals
open Fun.Blazor.AntDesign.DslInternals


type uploadButton<'FunBlazorGeneric> =
    inherit antComponentBase<'FunBlazorGeneric>
    static member inline create () = [] |> html.blazor<AntDesign.Internal.UploadButton>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.Internal.UploadButton>
    static member inline create (nodes: FunBlazorNode list) = nodes |> html.blazor<AntDesign.Internal.UploadButton>
    static member inline create (node: FunBlazorNode) = [ node ] |> html.blazor<AntDesign.Internal.UploadButton>
    static member inline ref x = attr.ref x
    static member inline childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline listType (x: System.String) = "ListType" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline showButton (x: System.Boolean) = "ShowButton" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline name (x: System.String) = "Name" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline directory (x: System.Boolean) = "Directory" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline multiple (x: System.Boolean) = "Multiple" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline accept (x: System.String) = "Accept" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline data (x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "Data" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline headers (x: System.Collections.Generic.Dictionary<System.String, System.String>) = "Headers" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline action (x: System.String) = "Action" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline disabled (x: System.Boolean) = "Disabled" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    
            
namespace rec Fun.Blazor.AntDesign.DslInternals

open Bolero.Html
open Fun.Blazor
open Fun.Blazor.Web.DslInternals
open Fun.Blazor.AntDesign.DslInternals


type formValidationMessage<'FunBlazorGeneric, 'TValue> =
    
    static member inline create () = [] |> html.blazor<AntDesign.FormValidationMessage<'TValue>>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.FormValidationMessage<'TValue>>

    static member inline ref x = attr.ref x
    static member inline additionalAttributes (x: System.Collections.Generic.IReadOnlyDictionary<System.String, System.Object>) = "AdditionalAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline control (x: AntDesign.AntInputComponentBase<'TValue>) = "Control" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type formValidationMessageItem<'FunBlazorGeneric> =
    
    static member inline create () = [] |> html.blazor<AntDesign.FormValidationMessageItem>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.FormValidationMessageItem>

    static member inline ref x = attr.ref x
    static member inline message (x: System.String) = "Message" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline additionalAttributes (x: System.Collections.Generic.IReadOnlyDictionary<System.String, System.Object>) = "AdditionalAttributes" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type imagePreview<'FunBlazorGeneric> =
    
    static member inline create () = [] |> html.blazor<AntDesign.ImagePreview>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.ImagePreview>

    static member inline ref x = attr.ref x
    static member inline imageRef (x: AntDesign.ImageRef) = "ImageRef" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type imagePreviewGroup<'FunBlazorGeneric> =
    
    static member inline create () = [] |> html.blazor<AntDesign.ImagePreviewGroup>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.ImagePreviewGroup>
    static member inline create (nodes: FunBlazorNode list) = nodes |> html.blazor<AntDesign.ImagePreviewGroup>
    static member inline create (node: FunBlazorNode) = [ node ] |> html.blazor<AntDesign.ImagePreviewGroup>
    static member inline ref x = attr.ref x
    static member inline childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type treeIndent<'FunBlazorGeneric, 'TItem> =
    
    static member inline create () = [] |> html.blazor<AntDesign.TreeIndent<'TItem>>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.TreeIndent<'TItem>>

    static member inline ref x = attr.ref x
    static member inline treeLevel (x: System.Int32) = "TreeLevel" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type treeNodeCheckbox<'FunBlazorGeneric, 'TItem> =
    
    static member inline create () = [] |> html.blazor<AntDesign.TreeNodeCheckbox<'TItem>>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.TreeNodeCheckbox<'TItem>>

    static member inline ref x = attr.ref x
    static member inline onCheckBoxClick fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnCheckBoxClick" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type treeNodeSwitcher<'FunBlazorGeneric, 'TItem> =
    
    static member inline create () = [] |> html.blazor<AntDesign.TreeNodeSwitcher<'TItem>>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.TreeNodeSwitcher<'TItem>>

    static member inline ref x = attr.ref x
    static member inline onSwitcherClick fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnSwitcherClick" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type treeNodeTitle<'FunBlazorGeneric, 'TItem> =
    
    static member inline create () = [] |> html.blazor<AntDesign.TreeNodeTitle<'TItem>>


    static member inline ref x = attr.ref x

                    

type cardLoading<'FunBlazorGeneric> =
    
    static member inline create () = [] |> html.blazor<AntDesign.CardLoading>


    static member inline ref x = attr.ref x

                    

type summaryRow<'FunBlazorGeneric> =
    
    static member inline create () = [] |> html.blazor<AntDesign.SummaryRow>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.SummaryRow>
    static member inline create (nodes: FunBlazorNode list) = nodes |> html.blazor<AntDesign.SummaryRow>
    static member inline create (node: FunBlazorNode) = [ node ] |> html.blazor<AntDesign.SummaryRow>
    static member inline ref x = attr.ref x
    static member inline childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    
            
namespace rec Fun.Blazor.AntDesign.DslInternals.statistic

open Bolero.Html
open Fun.Blazor
open Fun.Blazor.Web.DslInternals
open Fun.Blazor.AntDesign.DslInternals


type statisticComponentBase<'FunBlazorGeneric, 'T> =
    
    static member inline create () = [] |> html.blazor<AntDesign.statistic.StatisticComponentBase<'T>>


    static member inline ref x = attr.ref x

                    
            
namespace rec Fun.Blazor.AntDesign.DslInternals.Select

open Bolero.Html
open Fun.Blazor
open Fun.Blazor.Web.DslInternals
open Fun.Blazor.AntDesign.DslInternals


type labelTemplateItem<'FunBlazorGeneric, 'TItemValue, 'TItem> =
    
    static member inline create () = [] |> html.blazor<AntDesign.Select.LabelTemplateItem<'TItemValue, 'TItem>>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.Select.LabelTemplateItem<'TItemValue, 'TItem>>

    static member inline ref x = attr.ref x
    static member inline labelTemplateItemContent (render: 'TItem -> FunBlazorNode) = Bolero.Html.attr.fragmentWith "LabelTemplateItemContent" (fun x -> render x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline styles (x: (string * string) list) = attr.styles x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline classes (x: string list) = attr.classes x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline contentStyle (x: System.String) = "ContentStyle" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline contentClass (x: System.String) = "ContentClass" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline removeIconStyle (x: System.String) = "RemoveIconStyle" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline removeIconClass (x: System.String) = "RemoveIconClass" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    
            
namespace rec Fun.Blazor.AntDesign.DslInternals.Select.Internal

open Bolero.Html
open Fun.Blazor
open Fun.Blazor.Web.DslInternals
open Fun.Blazor.AntDesign.DslInternals


type selectContent<'FunBlazorGeneric, 'TItemValue, 'TItem> =
    
    static member inline create () = [] |> html.blazor<AntDesign.Select.Internal.SelectContent<'TItemValue, 'TItem>>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.Select.Internal.SelectContent<'TItemValue, 'TItem>>

    static member inline ref x = attr.ref x
    static member inline prefix (x: System.String) = "Prefix" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline placeholder (x: System.String) = "Placeholder" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline isOverlayShow (x: System.Boolean) = "IsOverlayShow" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline showPlaceholder (x: System.Boolean) = "ShowPlaceholder" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onInput fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.ChangeEventArgs> "OnInput" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onKeyUp fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs> "OnKeyUp" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onKeyDown fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs> "OnKeyDown" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onFocus fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.FocusEventArgs> "OnFocus" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onBlur fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.FocusEventArgs> "OnBlur" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onClearClick fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnClearClick" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onRemoveSelected fn = (Bolero.Html.attr.callback<AntDesign.Select.Internal.SelectOptionItem<'TItemValue, 'TItem>> "OnRemoveSelected" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline searchValue (x: System.String) = "SearchValue" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    
            

// =======================================================================================================================

namespace Fun.Blazor.AntDesign

open Fun.Blazor.AntDesign.DslInternals


type IAntComponentBaseNode = interface end
type antComponentBase =
    class
        inherit antComponentBase<IAntComponentBaseNode>
    end
                    

type IConfigProviderNode = interface end
type configProvider =
    class
        inherit configProvider<IConfigProviderNode>
    end
                    

type IAntDomComponentBaseNode = interface end
type antDomComponentBase =
    class
        inherit antDomComponentBase<IAntDomComponentBaseNode>
    end
                    

type IAffixNode = interface end
type affix =
    class
        inherit affix<IAffixNode>
    end
                    

type IAlertNode = interface end
type alert =
    class
        inherit alert<IAlertNode>
    end
                    

type IAnchorNode = interface end
type anchor =
    class
        inherit anchor<IAnchorNode>
    end
                    

type IAnchorLinkNode = interface end
type anchorLink =
    class
        inherit anchorLink<IAnchorLinkNode>
    end
                    

type IAutoCompleteOptGroupNode = interface end
type autoCompleteOptGroup =
    class
        inherit autoCompleteOptGroup<IAutoCompleteOptGroupNode>
    end
                    

type IAutoCompleteOptionNode = interface end
type autoCompleteOption =
    class
        inherit autoCompleteOption<IAutoCompleteOptionNode>
    end
                    

type IAvatarNode = interface end
type avatar =
    class
        inherit avatar<IAvatarNode>
    end
                    

type IAvatarGroupNode = interface end
type avatarGroup =
    class
        inherit avatarGroup<IAvatarGroupNode>
    end
                    

type IBackTopNode = interface end
type backTop =
    class
        inherit backTop<IBackTopNode>
    end
                    

type IBadgeNode = interface end
type badge =
    class
        inherit badge<IBadgeNode>
    end
                    

type IBadgeRibbonNode = interface end
type badgeRibbon =
    class
        inherit badgeRibbon<IBadgeRibbonNode>
    end
                    

type IBreadcrumbNode = interface end
type breadcrumb =
    class
        inherit breadcrumb<IBreadcrumbNode>
    end
                    

type IButtonNode = interface end
type button =
    class
        inherit button<IButtonNode>
    end
                    

type IButtonGroupNode = interface end
type buttonGroup =
    class
        inherit buttonGroup<IButtonGroupNode>
    end
                    

type ICalendarNode = interface end
type calendar =
    class
        inherit calendar<ICalendarNode>
    end
                    

type ICardNode = interface end
type card =
    class
        inherit card<ICardNode>
    end
                    

type ICardActionNode = interface end
type cardAction =
    class
        inherit cardAction<ICardActionNode>
    end
                    

type ICardGridNode = interface end
type cardGrid =
    class
        inherit cardGrid<ICardGridNode>
    end
                    

type ICarouselNode = interface end
type carousel =
    class
        inherit carousel<ICarouselNode>
    end
                    

type ICarouselSlickNode = interface end
type carouselSlick =
    class
        inherit carouselSlick<ICarouselSlickNode>
    end
                    

type ICollapseNode = interface end
type collapse =
    class
        inherit collapse<ICollapseNode>
    end
                    

type IPanelNode = interface end
type panel =
    class
        inherit panel<IPanelNode>
    end
                    

type ICommentNode = interface end
type comment =
    class
        inherit comment<ICommentNode>
    end
                    

type IAntContainerComponentBaseNode = interface end
type antContainerComponentBase =
    class
        inherit antContainerComponentBase<IAntContainerComponentBaseNode>
    end
                    

type IAntInputComponentBaseNode<'TValue> = interface end
type antInputComponentBase<'TValue> =
    class
        inherit antInputComponentBase<IAntInputComponentBaseNode<'TValue>, 'TValue>
    end
                    

type IAutoCompleteNode<'TOption> = interface end
type autoComplete<'TOption> =
    class
        inherit autoComplete<IAutoCompleteNode<'TOption>, 'TOption>
    end
                    

type ICascaderNode = interface end
type cascader =
    class
        inherit cascader<ICascaderNode>
    end
                    

type ICheckboxGroupNode = interface end
type checkboxGroup =
    class
        inherit checkboxGroup<ICheckboxGroupNode>
    end
                    

type IAntInputBoolComponentBaseNode = interface end
type antInputBoolComponentBase =
    class
        inherit antInputBoolComponentBase<IAntInputBoolComponentBaseNode>
    end
                    

type ICheckboxNode = interface end
type checkbox =
    class
        inherit checkbox<ICheckboxNode>
    end
                    

type ISwitchNode = interface end
type switch =
    class
        inherit switch<ISwitchNode>
    end
                    

type IDatePickerBaseNode<'TValue> = interface end
type datePickerBase<'TValue> =
    class
        inherit datePickerBase<IDatePickerBaseNode<'TValue>, 'TValue>
    end
                    

type IDatePickerNode<'TValue> = interface end
type datePicker<'TValue> =
    class
        inherit datePicker<IDatePickerNode<'TValue>, 'TValue>
    end
                    

type IMonthPickerNode<'TValue> = interface end
type monthPicker<'TValue> =
    class
        inherit monthPicker<IMonthPickerNode<'TValue>, 'TValue>
    end
                    

type IQuarterPickerNode<'TValue> = interface end
type quarterPicker<'TValue> =
    class
        inherit quarterPicker<IQuarterPickerNode<'TValue>, 'TValue>
    end
                    

type IWeekPickerNode<'TValue> = interface end
type weekPicker<'TValue> =
    class
        inherit weekPicker<IWeekPickerNode<'TValue>, 'TValue>
    end
                    

type IYearPickerNode<'TValue> = interface end
type yearPicker<'TValue> =
    class
        inherit yearPicker<IYearPickerNode<'TValue>, 'TValue>
    end
                    

type ITimePickerNode<'TValue> = interface end
type timePicker<'TValue> =
    class
        inherit timePicker<ITimePickerNode<'TValue>, 'TValue>
    end
                    

type IRangePickerNode<'TValue> = interface end
type rangePicker<'TValue> =
    class
        inherit rangePicker<IRangePickerNode<'TValue>, 'TValue>
    end
                    

type IInputNumberNode<'TValue> = interface end
type inputNumber<'TValue> =
    class
        inherit inputNumber<IInputNumberNode<'TValue>, 'TValue>
    end
                    

type IInputNode<'TValue> = interface end
type input<'TValue> =
    class
        inherit input<IInputNode<'TValue>, 'TValue>
    end
                    

type IAutoCompleteInputNode<'TValue> = interface end
type autoCompleteInput<'TValue> =
    class
        inherit autoCompleteInput<IAutoCompleteInputNode<'TValue>, 'TValue>
    end
                    

type IInputPasswordNode = interface end
type inputPassword =
    class
        inherit inputPassword<IInputPasswordNode>
    end
                    

type ISearchNode = interface end
type search =
    class
        inherit search<ISearchNode>
    end
                    

type IAutoCompleteSearchNode = interface end
type autoCompleteSearch =
    class
        inherit autoCompleteSearch<IAutoCompleteSearchNode>
    end
                    

type ITextAreaNode = interface end
type textArea =
    class
        inherit textArea<ITextAreaNode>
    end
                    

type IRadioGroupNode<'TValue> = interface end
type radioGroup<'TValue> =
    class
        inherit radioGroup<IRadioGroupNode<'TValue>, 'TValue>
    end
                    

type ISelectNode<'TItemValue, 'TItem> = interface end
type select<'TItemValue, 'TItem> =
    class
        inherit select<ISelectNode<'TItemValue, 'TItem>, 'TItemValue, 'TItem>
    end
                    

type ISimpleSelectNode = interface end
type simpleSelect =
    class
        inherit simpleSelect<ISimpleSelectNode>
    end
                    

type ISliderNode<'TValue> = interface end
type slider<'TValue> =
    class
        inherit slider<ISliderNode<'TValue>, 'TValue>
    end
                    

type IDescriptionsNode = interface end
type descriptions =
    class
        inherit descriptions<IDescriptionsNode>
    end
                    

type IDescriptionsItemNode = interface end
type descriptionsItem =
    class
        inherit descriptionsItem<IDescriptionsItemNode>
    end
                    

type IDividerNode = interface end
type divider =
    class
        inherit divider<IDividerNode>
    end
                    

type IDrawerNode = interface end
type drawer =
    class
        inherit drawer<IDrawerNode>
    end
                    

type IDrawerContainerNode = interface end
type drawerContainer =
    class
        inherit drawerContainer<IDrawerContainerNode>
    end
                    

type IEmptyNode = interface end
type empty =
    class
        inherit empty<IEmptyNode>
    end
                    

type IFormNode<'TModel> = interface end
type form<'TModel> =
    class
        inherit form<IFormNode<'TModel>, 'TModel>
    end
                    

type IFormItemNode = interface end
type formItem =
    class
        inherit formItem<IFormItemNode>
    end
                    

type IColNode = interface end
type col =
    class
        inherit col<IColNode>
    end
                    

type IGridColNode = interface end
type gridCol =
    class
        inherit gridCol<IGridColNode>
    end
                    

type IRowNode = interface end
type row =
    class
        inherit row<IRowNode>
    end
                    

type IIconNode = interface end
type icon =
    class
        inherit icon<IIconNode>
    end
                    

type IIconFontNode = interface end
type iconFont =
    class
        inherit iconFont<IIconFontNode>
    end
                    

type IImageNode = interface end
type image =
    class
        inherit image<IImageNode>
    end
                    

type IImagePreviewContainerNode = interface end
type imagePreviewContainer =
    class
        inherit imagePreviewContainer<IImagePreviewContainerNode>
    end
                    

type IInputGroupNode = interface end
type inputGroup =
    class
        inherit inputGroup<IInputGroupNode>
    end
                    

type ISiderNode = interface end
type sider =
    class
        inherit sider<ISiderNode>
    end
                    

type IAntListNode<'TItem> = interface end
type antList<'TItem> =
    class
        inherit antList<IAntListNode<'TItem>, 'TItem>
    end
                    

type IListItemNode = interface end
type listItem =
    class
        inherit listItem<IListItemNode>
    end
                    

type IListItemMetaNode = interface end
type listItemMeta =
    class
        inherit listItemMeta<IListItemMetaNode>
    end
                    

type IMentionsNode = interface end
type mentions =
    class
        inherit mentions<IMentionsNode>
    end
                    

type IMentionsOptionNode = interface end
type mentionsOption =
    class
        inherit mentionsOption<IMentionsOptionNode>
    end
                    

type IMenuNode = interface end
type menu =
    class
        inherit menu<IMenuNode>
    end
                    

type IMenuItemNode = interface end
type menuItem =
    class
        inherit menuItem<IMenuItemNode>
    end
                    

type IMenuItemGroupNode = interface end
type menuItemGroup =
    class
        inherit menuItemGroup<IMenuItemGroupNode>
    end
                    

type IMenuLinkNode = interface end
type menuLink =
    class
        inherit menuLink<IMenuLinkNode>
    end
                    

type ISubMenuNode = interface end
type subMenu =
    class
        inherit subMenu<ISubMenuNode>
    end
                    

type IMessageNode = interface end
type message =
    class
        inherit message<IMessageNode>
    end
                    

type IMessageItemNode = interface end
type messageItem =
    class
        inherit messageItem<IMessageItemNode>
    end
                    

type IComfirmContainerNode = interface end
type comfirmContainer =
    class
        inherit comfirmContainer<IComfirmContainerNode>
    end
                    

type IConfirmNode = interface end
type confirm =
    class
        inherit confirm<IConfirmNode>
    end
                    

type IDialogNode = interface end
type dialog =
    class
        inherit dialog<IDialogNode>
    end
                    

type IDialogWrapperNode = interface end
type dialogWrapper =
    class
        inherit dialogWrapper<IDialogWrapperNode>
    end
                    

type IModalNode = interface end
type modal =
    class
        inherit modal<IModalNode>
    end
                    

type IModalContainerNode = interface end
type modalContainer =
    class
        inherit modalContainer<IModalContainerNode>
    end
                    

type IModalFooterNode = interface end
type modalFooter =
    class
        inherit modalFooter<IModalFooterNode>
    end
                    

type INotificationBaseNode = interface end
type notificationBase =
    class
        inherit notificationBase<INotificationBaseNode>
    end
                    

type INotificationNode = interface end
type notification =
    class
        inherit notification<INotificationNode>
    end
                    

type INotificationItemNode = interface end
type notificationItem =
    class
        inherit notificationItem<INotificationItemNode>
    end
                    

type IPageHeaderNode = interface end
type pageHeader =
    class
        inherit pageHeader<IPageHeaderNode>
    end
                    

type IPaginationNode = interface end
type pagination =
    class
        inherit pagination<IPaginationNode>
    end
                    

type IPaginationOptionsNode = interface end
type paginationOptions =
    class
        inherit paginationOptions<IPaginationOptionsNode>
    end
                    

type IProgressNode = interface end
type progress =
    class
        inherit progress<IProgressNode>
    end
                    

type IRadioNode<'TValue> = interface end
type radio<'TValue> =
    class
        inherit radio<IRadioNode<'TValue>, 'TValue>
    end
                    

type IRateNode = interface end
type rate =
    class
        inherit rate<IRateNode>
    end
                    

type IRateItemNode = interface end
type rateItem =
    class
        inherit rateItem<IRateItemNode>
    end
                    

type IResultNode = interface end
type result =
    class
        inherit result<IResultNode>
    end
                    

type ISelectOptionNode<'TItemValue, 'TItem> = interface end
type selectOption<'TItemValue, 'TItem> =
    class
        inherit selectOption<ISelectOptionNode<'TItemValue, 'TItem>, 'TItemValue, 'TItem>
    end
                    

type ISimpleSelectOptionNode = interface end
type simpleSelectOption =
    class
        inherit simpleSelectOption<ISimpleSelectOptionNode>
    end
                    

type ISkeletonNode = interface end
type skeleton =
    class
        inherit skeleton<ISkeletonNode>
    end
                    

type ISkeletonElementNode = interface end
type skeletonElement =
    class
        inherit skeletonElement<ISkeletonElementNode>
    end
                    

type ISpaceNode = interface end
type space =
    class
        inherit space<ISpaceNode>
    end
                    

type ISpaceItemNode = interface end
type spaceItem =
    class
        inherit spaceItem<ISpaceItemNode>
    end
                    

type ISpinNode = interface end
type spin =
    class
        inherit spin<ISpinNode>
    end
                    

type IStatisticComponentBaseNode<'T> = interface end
type statisticComponentBase<'T> =
    class
        inherit statisticComponentBase<IStatisticComponentBaseNode<'T>, 'T>
    end
                    

type ICountDownNode = interface end
type countDown =
    class
        inherit countDown<ICountDownNode>
    end
                    

type IStatisticNode<'TValue> = interface end
type statistic<'TValue> =
    class
        inherit statistic<IStatisticNode<'TValue>, 'TValue>
    end
                    

type IStepNode = interface end
type step =
    class
        inherit step<IStepNode>
    end
                    

type IStepsNode = interface end
type steps =
    class
        inherit steps<IStepsNode>
    end
                    

type IColumnBaseNode = interface end
type columnBase =
    class
        inherit columnBase<IColumnBaseNode>
    end
                    

type IActionColumnNode = interface end
type actionColumn =
    class
        inherit actionColumn<IActionColumnNode>
    end
                    

type IColumnNode<'TData> = interface end
type column<'TData> =
    class
        inherit column<IColumnNode<'TData>, 'TData>
    end
                    

type ISelectionNode = interface end
type selection =
    class
        inherit selection<ISelectionNode>
    end
                    

type ISummaryCellNode = interface end
type summaryCell =
    class
        inherit summaryCell<ISummaryCellNode>
    end
                    

type ITableNode<'TItem> = interface end
type table<'TItem> =
    class
        inherit table<ITableNode<'TItem>, 'TItem>
    end
                    

type ITabPaneNode = interface end
type tabPane =
    class
        inherit tabPane<ITabPaneNode>
    end
                    

type ITabsNode = interface end
type tabs =
    class
        inherit tabs<ITabsNode>
    end
                    

type ITagNode = interface end
type tag =
    class
        inherit tag<ITagNode>
    end
                    

type ITimelineNode = interface end
type timeline =
    class
        inherit timeline<ITimelineNode>
    end
                    

type ITimelineItemNode = interface end
type timelineItem =
    class
        inherit timelineItem<ITimelineItemNode>
    end
                    

type ITransferNode = interface end
type transfer =
    class
        inherit transfer<ITransferNode>
    end
                    

type ITreeNode<'TItem> = interface end
type tree<'TItem> =
    class
        inherit tree<ITreeNode<'TItem>, 'TItem>
    end
                    

type ITreeNodeNode<'TItem> = interface end
type treeNode<'TItem> =
    class
        inherit treeNode<ITreeNodeNode<'TItem>, 'TItem>
    end
                    

type ITypographyBaseNode = interface end
type typographyBase =
    class
        inherit typographyBase<ITypographyBaseNode>
    end
                    

type ILinkNode = interface end
type link =
    class
        inherit link<ILinkNode>
    end
                    

type IParagraphNode = interface end
type paragraph =
    class
        inherit paragraph<IParagraphNode>
    end
                    

type ITextNode = interface end
type text =
    class
        inherit text<ITextNode>
    end
                    

type ITitleNode = interface end
type title =
    class
        inherit title<ITitleNode>
    end
                    

type IUploadNode = interface end
type upload =
    class
        inherit upload<IUploadNode>
    end
                    

type IBreadcrumbItemNode = interface end
type breadcrumbItem =
    class
        inherit breadcrumbItem<IBreadcrumbItemNode>
    end
                    

type ICalendarHeaderNode = interface end
type calendarHeader =
    class
        inherit calendarHeader<ICalendarHeaderNode>
    end
                    

type ICardMetaNode = interface end
type cardMeta =
    class
        inherit cardMeta<ICardMetaNode>
    end
                    

type IAntContainerNode = interface end
type antContainer =
    class
        inherit antContainer<IAntContainerNode>
    end
                    

type ITemplateNode = interface end
type template =
    class
        inherit template<ITemplateNode>
    end
                    

type IEmptyDefaultImgNode = interface end
type emptyDefaultImg =
    class
        inherit emptyDefaultImg<IEmptyDefaultImgNode>
    end
                    

type IEmptySimpleImgNode = interface end
type emptySimpleImg =
    class
        inherit emptySimpleImg<IEmptySimpleImgNode>
    end
                    

type IContentNode = interface end
type content =
    class
        inherit content<IContentNode>
    end
                    

type IFooterNode = interface end
type footer =
    class
        inherit footer<IFooterNode>
    end
                    

type IHeaderNode = interface end
type header =
    class
        inherit header<IHeaderNode>
    end
                    

type ILayoutNode = interface end
type layout =
    class
        inherit layout<ILayoutNode>
    end
                    

type IMenuDividerNode = interface end
type menuDivider =
    class
        inherit menuDivider<IMenuDividerNode>
    end
                    

type IPaginationPagerNode = interface end
type paginationPager =
    class
        inherit paginationPager<IPaginationPagerNode>
    end
                    
            
namespace Fun.Blazor.AntDesign.Select.Internal

open Fun.Blazor.AntDesign.DslInternals


type ISelectOptionGroupNode<'TItemValue, 'TItem> = interface end
type selectOptionGroup<'TItemValue, 'TItem> =
    class
        inherit Select.Internal.selectOptionGroup<ISelectOptionGroupNode<'TItemValue, 'TItem>, 'TItemValue, 'TItem>
    end
                    
            
namespace Fun.Blazor.AntDesign.Internal

open Fun.Blazor.AntDesign.DslInternals


type ICalendarPanelChooserNode = interface end
type calendarPanelChooser =
    class
        inherit Internal.calendarPanelChooser<ICalendarPanelChooserNode>
    end
                    

type IElementNode = interface end
type element =
    class
        inherit Internal.element<IElementNode>
    end
                    

type IOverlayNode = interface end
type overlay =
    class
        inherit Internal.overlay<IOverlayNode>
    end
                    

type IOverlayTriggerNode = interface end
type overlayTrigger =
    class
        inherit Internal.overlayTrigger<IOverlayTriggerNode>
    end
                    
            
namespace Fun.Blazor.AntDesign

open Fun.Blazor.AntDesign.DslInternals


type IDropdownNode = interface end
type dropdown =
    class
        inherit dropdown<IDropdownNode>
    end
                    

type IDropdownButtonNode = interface end
type dropdownButton =
    class
        inherit dropdownButton<IDropdownButtonNode>
    end
                    

type IPopconfirmNode = interface end
type popconfirm =
    class
        inherit popconfirm<IPopconfirmNode>
    end
                    

type IPopoverNode = interface end
type popover =
    class
        inherit popover<IPopoverNode>
    end
                    

type ITooltipNode = interface end
type tooltip =
    class
        inherit tooltip<ITooltipNode>
    end
                    
            
namespace Fun.Blazor.AntDesign.Internal

open Fun.Blazor.AntDesign.DslInternals


type ISubMenuTriggerNode = interface end
type subMenuTrigger =
    class
        inherit Internal.subMenuTrigger<ISubMenuTriggerNode>
    end
                    

type IDatePickerPanelChooserNode<'TValue> = interface end
type datePickerPanelChooser<'TValue> =
    class
        inherit Internal.datePickerPanelChooser<IDatePickerPanelChooserNode<'TValue>, 'TValue>
    end
                    

type IPickerPanelBaseNode = interface end
type pickerPanelBase =
    class
        inherit Internal.pickerPanelBase<IPickerPanelBaseNode>
    end
                    
            
namespace Fun.Blazor.AntDesign

open Fun.Blazor.AntDesign.DslInternals


type IDatePickerPanelBaseNode<'TValue> = interface end
type datePickerPanelBase<'TValue> =
    class
        inherit datePickerPanelBase<IDatePickerPanelBaseNode<'TValue>, 'TValue>
    end
                    
            
namespace Fun.Blazor.AntDesign.Internal

open Fun.Blazor.AntDesign.DslInternals


type IDatePickerDatetimePanelNode<'TValue> = interface end
type datePickerDatetimePanel<'TValue> =
    class
        inherit Internal.datePickerDatetimePanel<IDatePickerDatetimePanelNode<'TValue>, 'TValue>
    end
                    

type IDatePickerTemplateNode<'TValue> = interface end
type datePickerTemplate<'TValue> =
    class
        inherit Internal.datePickerTemplate<IDatePickerTemplateNode<'TValue>, 'TValue>
    end
                    

type IDatePickerDatePanelNode<'TValue> = interface end
type datePickerDatePanel<'TValue> =
    class
        inherit Internal.datePickerDatePanel<IDatePickerDatePanelNode<'TValue>, 'TValue>
    end
                    

type IDatePickerDecadePanelNode<'TValue> = interface end
type datePickerDecadePanel<'TValue> =
    class
        inherit Internal.datePickerDecadePanel<IDatePickerDecadePanelNode<'TValue>, 'TValue>
    end
                    

type IDatePickerFooterNode<'TValue> = interface end
type datePickerFooter<'TValue> =
    class
        inherit Internal.datePickerFooter<IDatePickerFooterNode<'TValue>, 'TValue>
    end
                    

type IDatePickerHeaderNode<'TValue> = interface end
type datePickerHeader<'TValue> =
    class
        inherit Internal.datePickerHeader<IDatePickerHeaderNode<'TValue>, 'TValue>
    end
                    

type IDatePickerMonthPanelNode<'TValue> = interface end
type datePickerMonthPanel<'TValue> =
    class
        inherit Internal.datePickerMonthPanel<IDatePickerMonthPanelNode<'TValue>, 'TValue>
    end
                    

type IDatePickerQuarterPanelNode<'TValue> = interface end
type datePickerQuarterPanel<'TValue> =
    class
        inherit Internal.datePickerQuarterPanel<IDatePickerQuarterPanelNode<'TValue>, 'TValue>
    end
                    

type IDatePickerYearPanelNode<'TValue> = interface end
type datePickerYearPanel<'TValue> =
    class
        inherit Internal.datePickerYearPanel<IDatePickerYearPanelNode<'TValue>, 'TValue>
    end
                    

type IDatePickerInputNode = interface end
type datePickerInput =
    class
        inherit Internal.datePickerInput<IDatePickerInputNode>
    end
                    

type IDropdownGroupButtonNode = interface end
type dropdownGroupButton =
    class
        inherit Internal.dropdownGroupButton<IDropdownGroupButtonNode>
    end
                    
            
namespace Fun.Blazor.AntDesign

open Fun.Blazor.AntDesign.DslInternals


type ITemplateComponentBaseNode<'TComponentOptions> = interface end
type templateComponentBase<'TComponentOptions> =
    class
        inherit templateComponentBase<ITemplateComponentBaseNode<'TComponentOptions>, 'TComponentOptions>
    end
                    

type IFeedbackComponentNode<'TComponentOptions> = interface end
type feedbackComponent<'TComponentOptions> =
    class
        inherit feedbackComponent<IFeedbackComponentNode<'TComponentOptions>, 'TComponentOptions>
    end
                    

type IFeedbackComponentNode<'TComponentOptions, 'TResult> = interface end
type feedbackComponent<'TComponentOptions, 'TResult> =
    class
        inherit feedbackComponent<IFeedbackComponentNode<'TComponentOptions, 'TResult>, 'TComponentOptions, 'TResult>
    end
                    

type IFormProviderNode = interface end
type formProvider =
    class
        inherit formProvider<IFormProviderNode>
    end
                    
            
namespace Fun.Blazor.AntDesign.Internal

open Fun.Blazor.AntDesign.DslInternals


type IUploadButtonNode = interface end
type uploadButton =
    class
        inherit Internal.uploadButton<IUploadButtonNode>
    end
                    
            
namespace Fun.Blazor.AntDesign

open Fun.Blazor.AntDesign.DslInternals


type IFormValidationMessageNode<'TValue> = interface end
type formValidationMessage<'TValue> =
    class
        inherit formValidationMessage<IFormValidationMessageNode<'TValue>, 'TValue>
    end
                    

type IFormValidationMessageItemNode = interface end
type formValidationMessageItem =
    class
        inherit formValidationMessageItem<IFormValidationMessageItemNode>
    end
                    

type IImagePreviewNode = interface end
type imagePreview =
    class
        inherit imagePreview<IImagePreviewNode>
    end
                    

type IImagePreviewGroupNode = interface end
type imagePreviewGroup =
    class
        inherit imagePreviewGroup<IImagePreviewGroupNode>
    end
                    

type ITreeIndentNode<'TItem> = interface end
type treeIndent<'TItem> =
    class
        inherit treeIndent<ITreeIndentNode<'TItem>, 'TItem>
    end
                    

type ITreeNodeCheckboxNode<'TItem> = interface end
type treeNodeCheckbox<'TItem> =
    class
        inherit treeNodeCheckbox<ITreeNodeCheckboxNode<'TItem>, 'TItem>
    end
                    

type ITreeNodeSwitcherNode<'TItem> = interface end
type treeNodeSwitcher<'TItem> =
    class
        inherit treeNodeSwitcher<ITreeNodeSwitcherNode<'TItem>, 'TItem>
    end
                    

type ITreeNodeTitleNode<'TItem> = interface end
type treeNodeTitle<'TItem> =
    class
        inherit treeNodeTitle<ITreeNodeTitleNode<'TItem>, 'TItem>
    end
                    

type ICardLoadingNode = interface end
type cardLoading =
    class
        inherit cardLoading<ICardLoadingNode>
    end
                    

type ISummaryRowNode = interface end
type summaryRow =
    class
        inherit summaryRow<ISummaryRowNode>
    end
                    
            
namespace Fun.Blazor.AntDesign.statistic

open Fun.Blazor.AntDesign.DslInternals


type IStatisticComponentBaseNode<'T> = interface end
type statisticComponentBase<'T> =
    class
        inherit statistic.statisticComponentBase<IStatisticComponentBaseNode<'T>, 'T>
    end
                    
            
namespace Fun.Blazor.AntDesign.Select

open Fun.Blazor.AntDesign.DslInternals


type ILabelTemplateItemNode<'TItemValue, 'TItem> = interface end
type labelTemplateItem<'TItemValue, 'TItem> =
    class
        inherit Select.labelTemplateItem<ILabelTemplateItemNode<'TItemValue, 'TItem>, 'TItemValue, 'TItem>
    end
                    
            
namespace Fun.Blazor.AntDesign.Select.Internal

open Fun.Blazor.AntDesign.DslInternals


type ISelectContentNode<'TItemValue, 'TItem> = interface end
type selectContent<'TItemValue, 'TItem> =
    class
        inherit Select.Internal.selectContent<ISelectContentNode<'TItemValue, 'TItem>, 'TItemValue, 'TItem>
    end
                    
            