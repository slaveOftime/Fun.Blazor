module Fun.Blazor.Generator.Generator

open System
open System.Reflection
open Microsoft.AspNetCore.Components
open Fun.Blazor
open Utils

let private getMetaInfo (ty: Type) =
    let rawProps = ty.GetProperties()
    let validProps = getValidBlazorProps ty rawProps

    let props =
        validProps
        |> Seq.map (fun prop ->
            let name = lowerFirstCase prop.Name
            let name = if fsharpKeywords |> List.contains name then $"{name}'" else name

            let _createNode = $"{nameof FelizNode}<{funBlazorGeneric}>.create"


            let createBindableProps (propTypeName: string) =
                if isBindable prop validProps then
                    [
                        $"    static member {name}' (value: IStore<{propTypeName}>) = {_createNode}(\"{prop.Name}\", value)"
                        $"    static member {name}' (value: cval<{propTypeName}>) = {_createNode}(\"{prop.Name}\", value)"
                        $"    static member {name}' (valueFn: {propTypeName} * ({propTypeName} -> unit)) = {_createNode}(\"{prop.Name}\", valueFn)"
                    ]
                else
                    []

            if prop.PropertyType.IsGenericType then
                if prop.PropertyType.Name.StartsWith "EventCallback"
                   || prop.PropertyType.Name.StartsWith "Microsoft.AspNetCore.Components.EventCallback" then
                    [
                        $"    static member {name} fn = (Bolero.Html.attr.callback<{getTypeName prop.PropertyType.GenericTypeArguments.[0]}> \"{prop.Name}\" (fun e -> fn e)) |> {_createNode}"
                    ]
                elif prop.PropertyType.Name.StartsWith "RenderFragment`" then
                    [
                        $"    static member {name} (render: {getTypeName prop.PropertyType.GenericTypeArguments.[0]} -> {boleroNode}) = Bolero.Html.attr.fragmentWith \"{prop.Name}\" (fun x -> render x) |> {_createNode}"
                    ]
                elif prop.PropertyType.Namespace = "System" && prop.PropertyType.Name.StartsWith "Func`" then
                    let returnType = prop.PropertyType.GenericTypeArguments |> Seq.last
                    if returnType = typeof<Microsoft.AspNetCore.Components.RenderFragment> then
                        let paramCount = prop.PropertyType.Name.Substring("Func`".Length) |> int
                        let parameters =
                            [
                                for i in 1 .. paramCount - 1 do
                                    $"x{i}"
                            ]
                            |> String.concat " "
                        [
                            $"    static member {name} (fn) = Bolero.FragmentAttr (\"{prop.Name}\", fun render -> box ({getTypeName prop.PropertyType}(fun {parameters} -> Microsoft.AspNetCore.Components.RenderFragment(fun rt -> render rt (fn {parameters}))))) |> {_createNode}"
                        ]
                    else
                        [
                            $"    static member {name} (fn) = \"{prop.Name}\" => ({getTypeName prop.PropertyType}fn) |> {_createNode}"
                        ]
                elif prop.PropertyType.Namespace = "System" && prop.PropertyType.Name.StartsWith "Action`" then
                    [
                        $"    static member {name} (fn) = \"{prop.Name}\" => ({getTypeName prop.PropertyType}fn) |> {_createNode}"
                    ]
                else
                    let propTypeName = getTypeName prop.PropertyType
                    [
                        $"    static member {name} (x: {propTypeName}) = \"{prop.Name}\" => x |> {_createNode}"
                        yield! createBindableProps propTypeName
                    ]

            elif prop.PropertyType.Name.StartsWith "EventCallback"
                 || prop.PropertyType.Name.StartsWith "Microsoft.AspNetCore.Components.EventCallback" then
                [
                    $"    static member {name} fn = attr.callbackOfUnit(\"{prop.Name}\", fn) |> {_createNode}"
                ]

            elif prop.PropertyType = typeof<RenderFragment> then
                [
                    $"    static member {name} (x: string) = Bolero.Html.attr.fragment \"{prop.Name}\" (html.text x) |> {_createNode}"
                    $"    static member {name} (node) = Bolero.Html.attr.fragment \"{prop.Name}\" (node) |> {_createNode}"
                    $"    static member {name} (nodes) = Bolero.Html.attr.fragment \"{prop.Name}\" (nodes |> html.fragment) |> {_createNode}"
                ]

            elif prop.Name = "Class" && prop.PropertyType = typeof<string> then
                [
                    $"    static member classes (x: string list) = attr.classes x |> {_createNode}"
                ]

            elif prop.Name = "Style" && prop.PropertyType = typeof<string> then
                [
                    $"    static member styles (x: (string * string) list) = attr.styles x |> {_createNode}"
                ]
            else
                let propTypeName = getTypeName prop.PropertyType
                [
                    $"    static member {name} (x: {propTypeName}) = \"{prop.Name}\" => x |> {_createNode}"
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

    let hasChildren = props.Contains "static member childContent"
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

                    let ref = $"    static member ref x = attr.ref<{originalTypeWithGenerics}> x"

                    let create1 = $"    static member create () = [] |> html.blazor<{originalTypeWithGenerics}>"

                    let create2 =
                        $"    static member create (nodes) = {nameof FelizNode}<{funBlazorGeneric}>.concat nodes |> html.blazor<{originalTypeWithGenerics}>"

                    let create3 =
                        if meta.hasChildren then
                            $"    static member create (nodes: {boleroNode} list) = [ attr.childContent nodes ] |> html.blazor<{originalTypeWithGenerics}>"
                            + "\n"
                            + $"    static member create (node: {boleroNode}) = [ attr.childContent [ node ] ] |> html.blazor<{originalTypeWithGenerics}>"
                            + "\n"
                            + $"    static member create (x: string) = [ attr.childContent [ html.text x ] ] |> html.blazor<{originalTypeWithGenerics}>"
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
{ref}
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
