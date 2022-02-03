module Fun.Blazor.Generator.CEGenerator

open System
open System.Reflection
open System.Collections.Generic
open Microsoft.AspNetCore.Components
open Fun.Blazor
open Fun.Result

open Utils


let private getMetaInfo (ty: Type) =
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
        | (ty, generics), Some (baseTy, baseGenerics) ->
            let generics =
                List.append baseGenerics generics
                |> List.distinctBy (fun x -> x.Name)
                |> List.filter (fun x -> (getTypeName x).StartsWith "'")
            ty, generics, Some(baseTy, baseGenerics)

        | (name, generics), None -> name, generics, None

    let originalGenerics = generics |> getTypeNames |> createGenerics |> closeGenerics
    let originalTypeWithGenerics = $"{ty.Namespace}.{getTypeShortName ty}{originalGenerics}"
    let customOperation name = $"[<CustomOperation(\"{name}\")>]"
    let memberStart = "member _."
    let contextArg = $"render: AttrRenderFragment"

    let rawProps = ty.GetProperties()
    let filteredProps = getValidBlazorProps ty rawProps

    let props =
        filteredProps
        |> Seq.map (fun prop ->
            let name = prop.Name
            let name =
                if fsharpKeywords
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
                   |> List.contains name then
                    $"{name}'"
                else
                    name

            let createBindableProps (propTypeName: string) =
                if isBindable prop filteredProps then
                    let bindName = name + "'"
                    [
                        $"    {customOperation bindName} {memberStart}{bindName} ({contextArg}, value: IStore<{propTypeName}>) = render ==> html.bind(\"{prop.Name}\", value)"
                        $"    {customOperation bindName} {memberStart}{bindName} ({contextArg}, value: cval<{propTypeName}>) = render ==> html.bind(\"{prop.Name}\", value)"
                        $"    {customOperation bindName} {memberStart}{bindName} ({contextArg}, valueFn: {propTypeName} * ({propTypeName} -> unit)) = render ==> html.bind(\"{prop.Name}\", valueFn)"
                    ]
                else
                    []

            if prop.PropertyType.IsGenericType then
                if prop.PropertyType.Name.StartsWith "EventCallback"
                   || prop.PropertyType.Name.StartsWith "Microsoft.AspNetCore.Components.EventCallback" then
                    [
                        $"    {customOperation name} {memberStart}{name} ({contextArg}, fn) = render ==> html.callback<{getTypeName prop.PropertyType.GenericTypeArguments.[0]}>(\"{prop.Name}\", fn)"
                    ]
                elif prop.PropertyType.Name.StartsWith "RenderFragment`" then
                    [
                        $"    {customOperation name} {memberStart}{name} ({contextArg}, fn: {getTypeName prop.PropertyType.GenericTypeArguments.[0]} -> {nameof NodeRenderFragment}) = render ==> html.renderFragment(\"{prop.Name}\", fn)"
                    ]
                elif prop.PropertyType.Namespace = "System"
                     && (prop.PropertyType.Name.StartsWith "Func`" || prop.PropertyType.Name.StartsWith "Action`") then
                    [
                        $"    {customOperation name} {memberStart}{name} ({contextArg}, fn) = render ==> (\"{prop.Name}\" => ({getTypeName prop.PropertyType}fn))"
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
                            $"    {customOperation name} {memberStart}{name} ({contextArg}, fn) = render ==> AttrRenderFragment(fun comp builder index -> builder.AddAttribute(index, \"{prop.Name}\", box ({getTypeName prop.PropertyType}(fun {parameters} -> Microsoft.AspNetCore.Components.RenderFragment(fun tb -> (fn {parameters}).Invoke(comp, tb, 0) |> ignore)))); index + 1)"
                        ]
                    else
                        [
                            $"    {customOperation name} {memberStart}{name} ({contextArg}, fn) = render ==> (\"{prop.Name}\" => ({getTypeName prop.PropertyType}fn))"
                        ]
                elif prop.PropertyType.Namespace = "System" && prop.PropertyType.Name.StartsWith "Action`" then
                    [
                        $"    {customOperation name} {memberStart}{name} ({contextArg}, fn) = render ==> (\"{prop.Name}\" => ({getTypeName prop.PropertyType}fn))"
                    ]
                else
                    let propTypeName = getTypeName prop.PropertyType
                    [
                        $"    {customOperation name} {memberStart}{name} ({contextArg}, x: {propTypeName}) = render ==> (\"{prop.Name}\" => x)"
                        yield! createBindableProps propTypeName
                    ]

            elif prop.PropertyType.Name.StartsWith "EventCallback"
                 || prop.PropertyType.Name.StartsWith "Microsoft.AspNetCore.Components.EventCallback" then
                [
                    $"    {customOperation name} {memberStart}{name} ({contextArg}, fn) = render ==> html.callback<unit>(\"{prop.Name}\", fn)"
                ]

            elif prop.PropertyType = typeof<RenderFragment> then
                let name = if prop.Name = "ChildContent" then lowerFirstCase name else name
                [
                    $"    {customOperation name} {memberStart}{name} ({contextArg}, fragment) = render ==> html.renderFragment(\"{prop.Name}\", fragment)"
                    $"    {customOperation name} {memberStart}{name} ({contextArg}, fragments) = render ==> html.renderFragment(\"{prop.Name}\", fragment {{ yield! fragments }})"
                    $"    {customOperation name} {memberStart}{name} ({contextArg}, x: string) = render ==> html.renderFragment(\"{prop.Name}\", html.text x)"
                    $"    {customOperation name} {memberStart}{name} ({contextArg}, x: int) = render ==> html.renderFragment(\"{prop.Name}\", html.text x)"
                    $"    {customOperation name} {memberStart}{name} ({contextArg}, x: float) = render ==> html.renderFragment(\"{prop.Name}\", html.text x)"
                ]

            elif prop.Name = "Class" && prop.PropertyType = typeof<string> then
                [
                    $"    [<CustomOperation(\"Classes\")>] {memberStart}Classes ({contextArg}, x: string list) = render ==> html.classes x"
                ]

            elif prop.Name = "Style" && prop.PropertyType = typeof<string> then
                [
                    $"    [<CustomOperation(\"Styles\")>] {memberStart}Styles ({contextArg}, x: (string * string) list) = render ==> html.styles x"
                ]

            else
                let propTypeName = getTypeName prop.PropertyType
                [
                    $"    {customOperation name} {memberStart}{name} ({contextArg}, x: {propTypeName}) = render ==> (\"{prop.Name}\" => x)"
                    yield! createBindableProps propTypeName
                ]
        )

        |> Seq.concat


    let hasChildren = props |> Seq.exists (fun x -> x.Contains $"{memberStart}childContent")

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


let generateCode (targetNamespace: string) (opens: string) (tys: Type seq) =
    let metaInfos = tys |> MetaInfo.create (getMetaInfo >> fun x -> Namespace x.ty.Namespace, x)

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


    let internalCode =
        metaInfos.metas
        |> Seq.map (fun (Namespace ns, metas) ->
            let code =
                metas
                |> Seq.map (fun meta ->
                    let originalGenerics = meta.generics |> getTypeNames |> createGenerics |> closeGenerics
                    let originalTypeWithGenerics = $"{meta.ty.Namespace}.{getTypeShortName meta.ty}{originalGenerics}"
                    let builderName = makeBuilderName meta.ty
                    let funBlazorGenericConstraint = $"{funBlazorGeneric} :> Microsoft.AspNetCore.Components.IComponent"
                    let builderGenerics =
                        funBlazorGeneric :: (getTypeNames meta.generics) |> createGenerics |> closeGenerics
                    let builderGenericsWithContraints =
                        funBlazorGeneric :: (getTypeNames meta.generics)
                        |> createGenerics
                        |> appendStr (createConstraint meta.generics |> appendConstraint funBlazorGenericConstraint)
                        |> closeGenerics

                    let inheirit' =
                        //$"inherit {if meta.addBasicDomAttrs then nameof FunBlazorContextWithAttrs else nameof FunBlazorContext}<{funBlazorGeneric}>()"
                        match meta.inheritInfo with
                        | None ->
                            // Use ComponentWithDomAndChildAttrBuilder because we cannot do multi inheritance and will endup of a lot of duplication
                            //$"inherit {match meta.hasChildren, meta.addBasicDomAttrs with
                            //           | true, false -> nameof ComponentWithChildBuilder
                            //           | true, true -> nameof ComponentWithDomAndChildAttrBuilder
                            //           | false, false -> nameof ComponentBuilder
                            //           | false, true -> nameof ComponentWithDomAttrBuilder}<{funBlazorGeneric}>()"
                            $"inherit {nameof ComponentWithDomAndChildAttrBuilder}<{funBlazorGeneric}>()"
                        | Some (baseTy, generics) ->
                            $"inherit {baseTy.Namespace |> trimNamespace |> appendStrIfNotEmpty (string '.')}{makeBuilderName meta.ty.BaseType}{funBlazorGeneric :: (getTypeNames generics) |> createGenerics |> closeGenerics}()"

                    let news =
                        if meta.hasChildren then
                            $"    static member inline create (x: string) = {builderName}{builderGenerics}(){{ x }}"
                            + "\n"
                            + $"    static member inline create (x: {nameof NodeRenderFragment} seq) = {builderName}{builderGenerics}(){{ yield! x }}"
                        else
                            $"    static member inline create () = html.fromBuilder({builderName}{builderGenerics}())"

                    $"""
type {builderName}{builderGenericsWithContraints}() =
    {inheirit'}
{news}
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
        |> Seq.groupBy fst
        |> Seq.map (fun (Namespace ns, group) ->
            let metas = group |> Seq.map snd |> Seq.concat
            let code =
                metas
                |> Seq.map (fun meta ->
                    let originalGenerics = meta.generics |> getTypeNames |> createGenerics |> closeGenerics
                    let originalTypeWithGenerics = $"{meta.ty.Namespace}.{getTypeShortName meta.ty}{originalGenerics}"
                    let builderName = makeBuilderName meta.ty
                    let builderGenerics =
                        originalTypeWithGenerics :: (getTypeNames meta.generics) |> createGenerics |> closeGenerics


                    $"""    type {meta.ty |> getTypeShortName}'{meta.generics
                                                                |> getTypeNames
                                                                |> createGenerics
                                                                |> appendStr (createConstraint meta.generics)
                                                                |> closeGenerics}() = inherit {builderName}{builderGenerics}()"""
                )
                |> String.concat "\n"

            $"""namespace {targetNamespace}{ns |> trimNamespace |> addStrIfNotEmpty "."}

[<AutoOpen>]
module DslCE =

    open {targetNamespace}.{internalSegment}{ns |> trimNamespace |> addStrIfNotEmpty "."}

{code}
            """
        )
        |> String.concat "\n"

    {| internalCode = internalCode; dslCode = dslCode |}
