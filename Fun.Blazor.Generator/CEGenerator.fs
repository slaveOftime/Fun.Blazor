module Fun.Blazor.Generator.CEGenerator

open System
open System.Reflection
open System.Collections.Generic
open Microsoft.AspNetCore.Components
open Fun.Blazor
open Fun.Result
open Namotion.Reflection

open Utils

let private makeSummaryDoc indent (doc: string) =
    if String.IsNullOrWhiteSpace doc then
        ""
    else
        let indent = String(' ', indent)
        (doc.Split "\n" |> Array.map (fun i -> $"{indent}/// {i}") |> String.concat "\n") + "\n"

let private getMetaInfo useInline (ty: Type) =
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

    let _, generics, inheritInfo =
        match getTypeMeta ty, inherits with
        | (ty, generics), Some(baseTy, baseGenerics) -> ty, generics, Some(baseTy, baseGenerics)
        | (name, generics), None -> name, generics, None

    let customOperation name = $"[<CustomOperation(\"{name}\")>]"
    let memberStart = if useInline then "member inline _." else "member _."
    let contextArg =
        if useInline then
            "[<InlineIfLambda>] render: AttrRenderFragment"
        else
            "render: AttrRenderFragment"

    let rawProps = ty.GetProperties()
    let filteredProps = getValidBlazorProps ty rawProps

    let props =
        filteredProps
        |> Seq.map (fun prop ->
            let comment = makeSummaryDoc 4 <| prop.GetXmlDocsSummary()
            let name = prop.Name
            let name =
                if
                    fsharpKeywords
                    @ [
                        "Bind"
                        "Delay"
                        "Return"
                        "ReturnFrom"
                        "Run"
                        "Combine"
                        "For"
                        "TryFinally"
                        "TryWith"
                        "Using"
                        "While"
                        "Yield"
                        "YieldFrom"
                        "Zero"
                        "Quote"
                    ]
                    |> List.contains name
                then
                    $"{name}'"
                else
                    name

            let createBindableProps (propTypeName: string) =
                if isBindable prop filteredProps then
                    let bindName = name + "'"
                    [
                        $"{comment}    {customOperation bindName} {memberStart}{bindName} ({contextArg}, valueFn: {propTypeName} * ({propTypeName} -> unit)) = render ==> html.bind(\"{prop.Name}\", valueFn)"
                    ]
                else
                    []

            let memberHead = $"{comment}    {customOperation name} {memberStart}{name}"

            if prop.PropertyType.IsGenericType then
                if
                    prop.PropertyType.Name.StartsWith "EventCallback"
                    || prop.PropertyType.Name.StartsWith "Microsoft.AspNetCore.Components.EventCallback"
                then
                    [
                        $"{memberHead} ({contextArg}, [<InlineIfLambda>] fn: {getTypeName prop.PropertyType.GenericTypeArguments.[0]} -> unit) = render ==> html.callback(\"{prop.Name}\", fn)"
                        $"{memberHead} ({contextArg}, [<InlineIfLambda>] fn: {getTypeName prop.PropertyType.GenericTypeArguments.[0]} -> Task<unit>) = render ==> html.callbackTask(\"{prop.Name}\", fn)"
                    ]
                elif prop.PropertyType.Name.StartsWith "RenderFragment`" then
                    [
                        $"{memberHead} ({contextArg}, [<InlineIfLambda>] fn: {getTypeName prop.PropertyType.GenericTypeArguments.[0]} -> {nameof NodeRenderFragment}) = render ==> html.renderFragment(\"{prop.Name}\", fn)"
                    ]
                elif
                    prop.PropertyType.Namespace = "System"
                    && (prop.PropertyType.Name.StartsWith "Func`" || prop.PropertyType.Name.StartsWith "Action`")
                then
                    [
                        $"{memberHead} ({contextArg}, fn) = render ==> (\"{prop.Name}\" => ({getTypeName prop.PropertyType}fn))"
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
                            $"{memberHead} ({contextArg}, fn) = render ==> AttrRenderFragment(fun comp builder index -> builder.AddAttribute(index, \"{prop.Name}\", box ({getTypeName prop.PropertyType}(fun {parameters} -> Microsoft.AspNetCore.Components.RenderFragment(fun tb -> (fn {parameters}).Invoke(comp, tb, 0) |> ignore)))); index + 1)"
                        ]
                    else
                        [
                            $"{memberHead} ({contextArg}, fn) = render ==> (\"{prop.Name}\" => ({getTypeName prop.PropertyType}fn))"
                        ]
                elif prop.PropertyType.Namespace = "System" && prop.PropertyType.Name.StartsWith "Action`" then
                    [
                        $"{memberHead} ({contextArg}, [<InlineIfLambda>] fn) = render ==> (\"{prop.Name}\" => ({getTypeName prop.PropertyType}fn))"
                    ]
                else
                    let propTypeName = getTypeName prop.PropertyType
                    [
                        $"{memberHead} ({contextArg}, x: {propTypeName}) = render ==> (\"{prop.Name}\" => x)"
                        yield! createBindableProps propTypeName
                    ]

            elif
                prop.PropertyType.Name.StartsWith "EventCallback"
                || prop.PropertyType.Name.StartsWith "Microsoft.AspNetCore.Components.EventCallback"
            then
                [
                    $"{memberHead} ({contextArg}, [<InlineIfLambda>] fn: unit -> unit) = render ==> html.callback(\"{prop.Name}\", fn)"
                    $"{memberHead} ({contextArg}, [<InlineIfLambda>] fn: unit -> Task<unit>) = render ==> html.callbackTask(\"{prop.Name}\", fn)"
                ]

            elif prop.PropertyType = typeof<RenderFragment> then
                [
                    if name <> "ChildContent" then
                        $"{memberHead} ({contextArg}, fragment: NodeRenderFragment) = render ==> html.renderFragment(\"{prop.Name}\", fragment)"
                        $"{memberHead} ({contextArg}, fragments: NodeRenderFragment seq) = render ==> html.renderFragment(\"{prop.Name}\", fragment {{ yield! fragments }})"
                        $"{memberHead} ({contextArg}, x: string) = render ==> html.renderFragment(\"{prop.Name}\", html.text x)"
                        $"{memberHead} ({contextArg}, x: int) = render ==> html.renderFragment(\"{prop.Name}\", html.text x)"
                        $"{memberHead} ({contextArg}, x: float) = render ==> html.renderFragment(\"{prop.Name}\", html.text x)"
                ]

            elif prop.Name = "Class" && prop.PropertyType = typeof<string> then
                []

            elif prop.Name = "Style" && prop.PropertyType = typeof<string> then
                []

            else
                let propTypeName = getTypeName prop.PropertyType
                [
                    if prop.PropertyType = typeof<bool> then
                        $"{memberHead} ({contextArg}) = render ==> (\"{prop.Name}\" =>>> true)"
                        $"{memberHead} ({contextArg}, x: bool) = render ==> (\"{prop.Name}\" =>>> x)"
                    else
                        $"{memberHead} ({contextArg}, x: {propTypeName}) = render ==> (\"{prop.Name}\" => x)"
                    yield! createBindableProps propTypeName
                ]
        )

        |> Seq.concat


    let hasChildren =
        filteredProps |> Seq.exists (fun x -> not x.PropertyType.IsGenericType && x.Name = "ChildContent")

    let isSplatAttributesProp (p: PropertyInfo) =
        option {
            let! attr = p.CustomAttributes |> Seq.tryFind (fun x -> x.AttributeType = typeof<ParameterAttribute>)
            let! arg = attr.NamedArguments |> Seq.tryFind (fun x -> x.MemberName = "CaptureUnmatchedValues")
            return arg.TypedValue.Value = box true
        }
        |> Option.defaultValue false

    let addBasicDomAttrs = rawProps |> Seq.exists isSplatAttributesProp

    let props =
        props
        |> Seq.filter (fun x -> not addBasicDomAttrs || x.Contains $"{memberStart}childContent" |> not)
        |> String.concat "\n"

    {|
        ty = ty
        generics = generics
        inheritInfo = inheritInfo
        props = props
        hasChildren = hasChildren
        addBasicDomAttrs = addBasicDomAttrs
    |}


let generateCode (targetNamespace: string) (opens: string) (tys: Type seq) useInline =
    let metaInfos =
        tys |> MetaInfo.create (getMetaInfo useInline >> fun x -> Namespace x.ty.Namespace, x)

    let trimNamespace (ns: string) =
        metaInfos.rootNamespaces
        |> Seq.pick (fun x ->
            if ns.StartsWith x then
                if ns.Length = x.Length then Some "" else ns.Substring(x.Length + 1) |> Some
            else
                None
        )

    let builderNames = Dictionary<string, Dictionary<string, int>>()

    let makeBuilderName (ty: Type) =
        let info = ty.GetTypeInfo()

        let shortName = getTypeShortName ty
        let uniqueName =
            $"{shortName}-{info.GenericTypeArguments.Length + info.GenericTypeParameters.Length}"
        let builderName = $"{shortName}Builder"
        let key = $"{ty.Namespace}-{shortName}"

        if builderNames.ContainsKey key then
            if builderNames.[key].ContainsKey uniqueName then
                ()
            else
                let count = builderNames.[key].Count
                builderNames.[key].Add(uniqueName, count + 1)
            if builderNames.[key].[uniqueName] = 1 then
                builderName
            else
                $"{builderName}{builderNames.[key].[uniqueName]}"
        else
            builderNames.Add(key, Dictionary([ KeyValuePair(uniqueName, 1) ]))
            builderName

    let hasChildInherit (ty: Type) = tys |> Seq.exists (fun x -> x.InheritsFromTypeName(ty.FullName, TypeNameStyle.FullName))

    let internalCode =
        metaInfos.metas
        |> Seq.map (fun (Namespace ns, metas) ->
            let code =
                metas
                |> Seq.map (fun meta ->
                    let builderName = makeBuilderName meta.ty

                    let funBlazorGenericConstraint =
                        $"{funBlazorGeneric} :> Microsoft.AspNetCore.Components.IComponent"

                    let builderGenericsWithContraints =
                        funBlazorGeneric :: (getTypeNames meta.generics)
                        |> createGenerics
                        |> appendStr (createConstraint meta.generics |> appendConstraint funBlazorGenericConstraint)
                        |> closeGenerics

                    let inheirit' =
                        match meta.inheritInfo with
                        | None when not meta.hasChildren && not (hasChildInherit meta.ty) && not meta.ty.IsAbstract ->
                            $"inherit {nameof ComponentWithDomAttrBuilder}<{funBlazorGeneric}>()"
                        | None ->
                            // Use ComponentWithDomAndChildAttrBuilder because we cannot do multi inheritance and will endup of a lot of duplication
                            //$"inherit {match meta.hasChildren, meta.addBasicDomAttrs with
                            //           | true, false -> nameof ComponentWithChildBuilder
                            //           | true, true -> nameof ComponentWithDomAndChildAttrBuilder
                            //           | false, false -> nameof ComponentBuilder
                            //           | false, true -> nameof ComponentWithDomAttrBuilder}<{funBlazorGeneric}>()"
                            $"inherit {nameof ComponentWithDomAndChildAttrBuilder}<{funBlazorGeneric}>()"
                        | Some(baseTy, generics) ->
                            $"inherit {baseTy.Namespace |> trimNamespace |> appendStrIfNotEmpty (string '.')}{makeBuilderName meta.ty.BaseType}{funBlazorGeneric :: (getTypeNames generics) |> createGenerics |> closeGenerics}()"

                    $"""{makeSummaryDoc 0 <| meta.ty.GetXmlDocsSummary()}type {builderName}{builderGenericsWithContraints}() =
    {inheirit'}
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
        |> Seq.groupBy (fun (Namespace ns, _) -> ns |> trimNamespace |> addStrIfNotEmpty ".")
        |> Seq.map (fun (subNamespace, group) ->
            let metas = group |> Seq.map snd |> Seq.concat
            let codes =
                metas
                |> Seq.map (fun meta ->
                    let originalGenerics =
                        meta.generics |> getTypeNames |> createGenerics |> closeGenerics
                    let originalTypeWithGenerics =
                        $"{meta.ty.Namespace}.{getTypeShortName meta.ty}{originalGenerics}"
                    let builderName = makeBuilderName meta.ty
                    let builderGenerics =
                        originalTypeWithGenerics :: (getTypeNames meta.generics) |> createGenerics |> closeGenerics

                    let typeName = meta.ty |> getTypeShortName
                    let typeFullName = meta.ty |> getTypeName |> (fun x -> x.Split("<")[0])

                    let genericStr = meta.generics |> getTypeNames |> createGenerics

                    let genericStrWithConstraint =
                        genericStr |> appendStr (createConstraint meta.generics) |> closeGenerics

                    let genericStrWithoutConstraint = genericStr |> closeGenerics

                    let linkerGenericStr =
                        if meta.generics.Length > 0 then
                            "<" + (meta.generics |> Seq.map (fun _ -> "_") |> String.concat ", ") + ">"
                        else
                            ""
                    let linkerAttrStr =
                        $"[<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<{typeFullName}{linkerGenericStr}>)>]"

                    let typeComment =
                        meta.ty.GetXmlDocsSummary() |> makeSummaryDoc 4 |> addStrIfNotEmpty "\n"
                    let constructorComment =
                        meta.ty.GetXmlDocsSummary()
                        |> makeSummaryDoc 8
                        |> addStrIfNotEmpty "\n"
                        |> appendStrIfNotEmpty (String(' ', 8))

                    let ceType =
                        $"""{typeComment}    type {typeName}'{genericStrWithConstraint} {constructorComment}{linkerAttrStr} () = inherit {builderName}{builderGenerics}()"""
                    let ceInstance =
                        $"""    let {typeName}''{genericStrWithConstraint} = {typeName}'{genericStrWithoutConstraint}()"""

                    typeName, ceType, ceInstance
                )

            let ceTypesCode = codes |> Seq.map (fun (_, x, _) -> x) |> String.concat "\n"

            let cetInstancesCode =
                codes |> Seq.distinctBy (fun (x, _, _) -> x) |> Seq.map (fun (_, _, x) -> x) |> String.concat "\n"

            $"""namespace {targetNamespace}{subNamespace}

[<AutoOpen>]
module DslCE =
  
    open System.Diagnostics.CodeAnalysis
    open {targetNamespace}.{internalSegment}{subNamespace}

{ceTypesCode}

[<AutoOpen>]
module DslCEInstances =
  
    open System.Diagnostics.CodeAnalysis
    open {targetNamespace}.{internalSegment}{subNamespace}

{cetInstancesCode}
            """
        )
        |> String.concat "\n"

    {| internalCode = internalCode; dslCode = dslCode |}
