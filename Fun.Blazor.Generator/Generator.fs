module Fun.Blazor.Generator.Generator

open System
open System.Reflection
open Microsoft.AspNetCore.Components
open Fun.Blazor
open Utils

let private getMetaInfo (ty: Type) =
    let rawProps = ty.GetProperties()
    let validProps = getValidBlazorProps ty rawProps
    let memberStart = "static member inline "

    let props =
        validProps
        |> Seq.map (fun prop ->
            let name = lowerFirstCase prop.Name
            let name = if fsharpKeywords |> List.contains name then $"{name}'" else name

            let createBindableProps (propTypeName: string) =
                if isBindable prop validProps then
                    [
                        $"    {memberStart}{name}' (value: IStore<{propTypeName}>) = html.bind(\"{prop.Name}\", value)"
                        $"    {memberStart}{name}' (value: cval<{propTypeName}>) = html.bind(\"{prop.Name}\", value)"
                        $"    {memberStart}{name}' (valueFn: {propTypeName} * ({propTypeName} -> unit)) = html.bind(\"{prop.Name}\", valueFn)"
                    ]
                else
                    []

            if prop.PropertyType.IsGenericType then
                if prop.PropertyType.Name.StartsWith "EventCallback"
                   || prop.PropertyType.Name.StartsWith "Microsoft.AspNetCore.Components.EventCallback" then
                    [
                        $"    {memberStart}{name} fn = html.callback<{getTypeName prop.PropertyType.GenericTypeArguments.[0]}>(\"{prop.Name}\", fn)"
                    ]
                elif prop.PropertyType.Name.StartsWith "RenderFragment`" then
                    [
                        $"    {memberStart}{name} (render: {getTypeName prop.PropertyType.GenericTypeArguments.[0]} -> {nameof NodeRenderFragment}) = html.renderFragment(\"{prop.Name}\", render)"
                    ]
                elif prop.PropertyType.Namespace = "System" && prop.PropertyType.Name.StartsWith "Func`" then
                    let returnType = prop.PropertyType.GenericTypeArguments |> Seq.last
                    if returnType = typeof<Microsoft.AspNetCore.Components.RenderFragment> then
                        let paramCount = prop.PropertyType.Name.Substring("Func`".Length) |> int
                        let parameters =
                            if paramCount = 1 then "()"
                            else
                                [
                                    for i in 1 .. paramCount - 1 do
                                        $"x{i}"
                                ]
                                |> String.concat " "
                        let fnType =
                            if paramCount = 1 then $"unit -> {nameof NodeRenderFragment}"
                            else
                                [
                                    for _ in 1 .. paramCount - 1 do
                                        $"_"
                                    nameof NodeRenderFragment
                                ]
                                |> String.concat " -> "
                        [
                            $"    {memberStart}{name} (fn: {fnType}) = AttrRenderFragment(fun comp builder index -> builder.AddAttribute(index, \"{prop.Name}\", box ({getTypeName prop.PropertyType}(fun {parameters} -> Microsoft.AspNetCore.Components.RenderFragment(fun tb -> (fn {parameters}).Invoke(comp, tb, 0) |> ignore)))); index + 1)"
                        ]
                    else
                        [
                            $"    {memberStart}{name} (fn) = \"{prop.Name}\" => ({getTypeName prop.PropertyType}fn)"
                        ]
                elif prop.PropertyType.Namespace = "System" && prop.PropertyType.Name.StartsWith "Action`" then
                    [
                        $"    {memberStart}{name} (fn) = \"{prop.Name}\" => ({getTypeName prop.PropertyType}fn)"
                    ]
                else
                    let propTypeName = getTypeName prop.PropertyType
                    [
                        $"    {memberStart}{name} (x: {propTypeName}) = \"{prop.Name}\" => x"
                        yield! createBindableProps propTypeName
                    ]

            elif prop.PropertyType.Name.StartsWith "EventCallback"
                 || prop.PropertyType.Name.StartsWith "Microsoft.AspNetCore.Components.EventCallback" then
                [
                    $"    {memberStart}{name} fn = html.callback<unit>(\"{prop.Name}\", fn)"
                ]

            elif prop.PropertyType = typeof<RenderFragment> then
                [
                    $"    {memberStart}{name} (x: string) = html.renderFragment(\"{prop.Name}\", html.text x)"
                    $"    {memberStart}{name} (node) = html.renderFragment(\"{prop.Name}\", node)"
                    $"    {memberStart}{name} (nodes) = html.renderFragment(\"{prop.Name}\", fragment {{ yield! nodes }})"
                ]

            elif prop.Name = "Class" && prop.PropertyType = typeof<string> then
                [
                    $"    {memberStart}classes (x: string list) = html.classes x"
                ]

            elif prop.Name = "Style" && prop.PropertyType = typeof<string> then
                [
                    $"    {memberStart}styles (x: (string * string) seq) = html.styles x"
                ]
            else
                let propTypeName = getTypeName prop.PropertyType
                [
                    $"    {memberStart}{name} (x: {propTypeName}) = \"{prop.Name}\" => x"
                    yield! createBindableProps propTypeName
                ]
        )

        |> Seq.concat
        |> String.concat "\n"


    let getTypeMeta (ty: Type) =
        if ty.Name.Contains "`" then
            let generics =
                if ty.GenericTypeArguments.Length = 0 then
                    ty.GetTypeInfo().GenericTypeParameters
                else
                    ty.GenericTypeArguments
                |> Seq.toList
            ty, generics
        else
            ty, []

    let inherits =
        if ty.BaseType <> typeof<Microsoft.AspNetCore.Components.ComponentBase> then
            Some(getTypeMeta ty.BaseType)
        else
            None

    let name, generics, inheritInfo =
        match getTypeMeta ty, inherits with
        | (name, generics), Some (baseName, generics') ->
            let generics =
                List.append generics' generics
                |> List.distinctBy (fun x -> x.Name)
                |> List.filter (fun x -> (getTypeName x).StartsWith "'")
            name, generics, Some(baseName, generics')

        | (name, generics), None -> name, generics, None

    let hasChildren = props.Contains $"{memberStart}childContent"
    {|
        ty = ty
        generics = generics
        inheritInfo = inheritInfo
        props = props
        hasChildren = hasChildren
    |}


let generateCode (targetNamespace: string) (opens: string) (tys: Type seq) =
    let metaInfos = tys |> MetaInfo.create (getMetaInfo >> fun x -> Namespace x.ty.Namespace, x)

    let getFinalTypeName = getTypeShortName >> lowerFirstCase >> avoidFsharpKeywords

    let trimNamespace (ns: string) =
        metaInfos.rootNamespaces
        |> Seq.pick (fun x ->
            if ns.StartsWith x then
                if ns.Length = x.Length then Some "" else ns.Substring(x.Length + 1) |> Some
            else
                None
        )

    let internalCode =
        metaInfos.metas
        |> Seq.map (fun (Namespace ns, metas) ->
            let code =
                metas
                |> Seq.map (fun meta ->
                    let originalTypeWithGenerics =
                        $"{meta.ty.Namespace}.{getTypeShortName meta.ty}{meta.generics |> getTypeNames |> createGenerics |> closeGenerics}"

                    let inheirit' =
                        match meta.inheritInfo with
                        | None -> ""
                        | Some (ty, generics) ->
                            $"inherit {ty.Namespace |> trimNamespace |> appendStrIfNotEmpty (string '.')}{getFinalTypeName ty}{funBlazorGeneric :: (getTypeNames generics) |> createGenerics |> closeGenerics}"

                    let create1 = $"    static member inline create () = {nameof ComponentBuilder}<{originalTypeWithGenerics}>()"

                    let create2 =
                        $"    static member inline create (attrs: {nameof AttrRenderFragment} seq) = {nameof ComponentBuilder}<{originalTypeWithGenerics}>() {{ html.mergeAttrs attrs }}"

                    let create3 =
                        if meta.hasChildren then
                            $"    static member inline create (nodes: {nameof NodeRenderFragment} seq) = {nameof ComponentBuilder}<{originalTypeWithGenerics}>() {{ yield! nodes }}"
                            + "\n"
                            + $"    static member inline create (node: {nameof NodeRenderFragment}) = {nameof ComponentBuilder}<{originalTypeWithGenerics}>() {{ node }}"
                            + "\n"
                            + $"    static member inline create (x: string) = {nameof ComponentBuilder}<{originalTypeWithGenerics}>(){{ x }}"
                        else
                            ""

                    $"""
type {getFinalTypeName meta.ty}{funBlazorGeneric :: (getTypeNames meta.generics)
                                |> createGenerics
                                |> appendStr (createConstraint meta.generics)
                                |> closeGenerics} =
    {inheirit'}
{create1}
{create2}
{create3}
{meta.props}
                    """
                )
                |> String.concat "\n"

            $"""namespace rec {targetNamespace}.{internalSegment}{ns |> trimNamespace |> addStrIfNotEmpty "."}

{opens}

{code}
            """
        )
        |> String.concat "\n"


    let dslCode =
        metaInfos.metas
        |> Seq.map (fun (Namespace ns, metas) ->
            let code =
                metas
                |> Seq.map (fun meta ->
                    let interfaceTy =
                        $"I{meta.ty |> getTypeShortName}Node{meta.generics |> getTypeNames |> createGenerics |> closeGenerics}"

                    $"""
type {interfaceTy} = interface end
type {getFinalTypeName meta.ty}{meta.generics
                                |> getTypeNames
                                |> createGenerics
                                |> appendStr (createConstraint meta.generics)
                                |> closeGenerics} =
    class
        inherit {ns |> trimNamespace |> appendStrIfNotEmpty "."}{getFinalTypeName meta.ty}{interfaceTy :: (getTypeNames meta.generics) |> createGenerics |> closeGenerics}
    end
                    """
                )
                |> String.concat "\n"

            $"""namespace {targetNamespace}{ns |> trimNamespace |> addStrIfNotEmpty "."}

open {targetNamespace}.{internalSegment}

{code}
            """
        )
        |> String.concat "\n"

    {| internalCode = internalCode; dslCode = dslCode |}
