module Fun.Blazor.Generator.CEGenerator

open System
open System.Reflection
open System.Collections.Generic
open Microsoft.AspNetCore.Components
open Fun.Blazor

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
            Some (getTypeMeta ty.BaseType)
        else
            None

    let name, generics, inheritInfo =
        match getTypeMeta ty, inherits with
        | (ty, generics), Some (baseTy, baseGenerics) -> 
            let generics = List.append baseGenerics generics |> List.distinctBy (fun x -> x.Name) |> List.filter (fun x -> (getTypeName x).StartsWith "'")
            ty, generics, Some (baseTy, baseGenerics)

        | (name, generics), None ->
            name, generics, None

    let originalGenerics = generics |> getTypeNames |> createGenerics |> closeGenerics
    let originalTypeWithGenerics = $"{ty.Namespace}.{getTypeShortName ty}{originalGenerics}"
    let contextArg = $"_: FunBlazorContext<{originalTypeWithGenerics}>"

    let rec getNestedProps (ty: Type) =
        [
            yield! ty.GetProperties()
            if ty.BaseType <> null && ty.BaseType <> typeof<ComponentBase> then
                yield! getNestedProps ty.BaseType
        ]

    let props = 
        getNestedProps ty
        |> Seq.distinctBy (fun x -> x.Name)
        |> Seq.choose (fun prop ->
            if prop.CustomAttributes
                |> Seq.exists (fun x -> x.AttributeType = typeof<ParameterAttribute>)
                |> not
            then None
            else
                let name = lowerFirstCase prop.Name
                let name =
                    if fsharpKeywords@["shape"; "style"; "min"; "max"] |> List.contains name then $"{name}'"
                    else name
                if prop.PropertyType.IsGenericType then
                    if prop.PropertyType.Name.StartsWith "EventCallback" ||
                       prop.PropertyType.Name.StartsWith "Microsoft.AspNetCore.Components.EventCallback"
                    then
                        Some [ $"    [<CustomOperation(\"{name}\")>] member this.{name} ({contextArg}, fn) = (Bolero.Html.attr.callback<{getTypeName prop.PropertyType.GenericTypeArguments.[0]}> \"{prop.Name}\" (fun e -> fn e)) |> {nameof BoleroAttr}" ]
                    elif prop.PropertyType.Name.StartsWith "RenderFragment`" then
                        Some [ $"    [<CustomOperation(\"{name}\")>] member this.{name} ({contextArg}, render: {getTypeName prop.PropertyType.GenericTypeArguments.[0]} -> {nameof IFunBlazorNode}) = Bolero.Html.attr.fragmentWith \"{prop.Name}\" (fun x -> render x |> html.toBolero) |> {nameof BoleroAttr}" ]
                    else
                        Some [ $"    [<CustomOperation(\"{name}\")>] member this.{name} ({contextArg}, x: {getTypeName prop.PropertyType}) = \"{prop.Name}\" => x |> {nameof BoleroAttr}" ]

                elif prop.PropertyType = typeof<RenderFragment> then
                    Some [
                        $"    [<CustomOperation(\"{name}\")>] member this.{name} ({contextArg}, nodes) = Bolero.Html.attr.fragment \"{prop.Name}\" (nodes |> html.fragment |> html.toBolero) |> {nameof BoleroAttr}"
                        $"    [<CustomOperation(\"{name}Str\")>] member this.{name}Str ({contextArg}, x: string) = Bolero.Html.attr.fragment \"{prop.Name}\" (html.text x |> html.toBolero) |> {nameof BoleroAttr}"
                    ]

                elif prop.Name = "Class" && prop.PropertyType = typeof<string> then
                    Some [ $"    [<CustomOperation(\"classes\")>] member this.classes ({contextArg}, x: string list) = attr.classes x" ]

                elif prop.Name = "Style" && prop.PropertyType = typeof<string> then
                    Some [ $"    [<CustomOperation(\"styles\")>] member this.styles ({contextArg}, x: (string * string) list) = attr.styles x" ]
                else
                    Some [ $"    [<CustomOperation(\"{name}\")>] member this.{name} ({contextArg}, x: {getTypeName prop.PropertyType}) = \"{prop.Name}\" => x |> {nameof BoleroAttr}" ])

        |> Seq.concat
        |> Seq.map (fun x -> $"{x} |> this.AddProp")
        


    let hasChildren = props |> Seq.exists (fun x -> x.Contains "member this.childContent")
    let addBasicDomAttrs = props |> Seq.exists (fun x -> x.Contains "member this.additionalAttributes")

    let props =
        if addBasicDomAttrs then 
            props 
            |> Seq.filter (fun x -> x.Contains "member this.childContent" |> not && x.Contains "member this.additionalAttributes" |> not)
        else 
            props
        |> String.concat "\n" 

    {| ty = ty; generics = generics; inheritInfo = inheritInfo; props = props; hasChildren = hasChildren; addBasicDomAttrs = addBasicDomAttrs; contextArg = contextArg |}



type private TypeTree =
    | Node of Type * TypeTree seq

let rec private getTypeTree (baseType: Type) (tys: Type seq): TypeTree seq =
    let baseTypeName = baseType.Namespace + "." + baseType.Name
    tys
    |> Seq.filter (fun x ->
        if baseType.IsGenericType && x.BaseType <> null then
             baseTypeName = x.BaseType.Namespace + "." + x.BaseType.Name
        else
            x.BaseType = baseType)
    |> Seq.map (fun ty -> Node (ty, getTypeTree ty tys))


let private getMetaInfos (tys: Type seq) =
    let rec getNamespaces tree =
        tree 
        |> Seq.map (fun (Node (ty, childTys)) -> ty.Namespace::(getNamespaces childTys |> Seq.toList))
        |> Seq.concat

    let rec getTypesInNamespace tree ns =
        tree
        |> Seq.map (fun (Node (ty, childTys)) ->
            [
                if ty.Namespace = ns then ty
                yield! getTypesInNamespace childTys ns
            ])
        |> Seq.concat

    let rec getRootNamespaces (nss: string list) =
        match nss with
        | [] -> []
        | [ns] -> [ns]
        | ns::rest ->
            let _, p2 = rest |> List.partition (fun x -> x.StartsWith ns)
            ns::getRootNamespaces p2

    let rec getOrderedTypes tree =
        tree
        |> Seq.map (fun (Node (ty, childTys)) ->
            [
                ty
                yield! getOrderedTypes childTys
            ])
        |> Seq.concat

    let tree = tys |> Seq.filter (fun x -> x.IsAssignableTo typeof<ComponentBase> && x.IsPublic) |> getTypeTree typeof<ComponentBase>
    let namespaces = getNamespaces tree |> Seq.toList
    let metaGroups = System.Collections.Generic.List<_>()
    
    tree
    |> getOrderedTypes
    |> Seq.map getMetaInfo
    |> Seq.iter (fun meta ->
        if metaGroups.Count = 0 then
            metaGroups.Add(meta.ty.Namespace, [meta])
        else
            let ns, metas = metaGroups |> Seq.last
            if ns = meta.ty.Namespace then metaGroups.[metaGroups.Count-1] <- (ns, metas@[meta])
            else metaGroups.Add(meta.ty.Namespace, [meta]))

    {| 
        rootNamespaces = getRootNamespaces namespaces
        metas = metaGroups
    |}


let generateCode (targetNamespace: string) (opens: string) (tys: Type seq) =
    let metaInfos = getMetaInfos tys

    let trimNamespace (ns: string) =
        metaInfos.rootNamespaces
        |> Seq.pick (fun x ->
            if ns.StartsWith x then
                if ns.Length = x.Length then Some ""
                else ns.Substring(x.Length + 1) |> Some
            else
                None)
    
    let internalSegment = "DslInternals"

    let builderNames = Dictionary<string, Dictionary<string, int>>()

    let makeBuilderName (ty: Type) =
        let meta = getMetaInfo ty
        let info = ty.GetTypeInfo()

        let shortName = getTypeShortName ty
        let uniqueName = $"{shortName}-{info.GenericTypeArguments.Length + info.GenericTypeParameters.Length}"
        let builderName = $"{shortName}Builder"
        let key = $"{meta.ty.Namespace}-{shortName}"

        if builderNames.ContainsKey key then
            if builderNames.[key].ContainsKey uniqueName then ()
            else
                let count = builderNames.[key].Count
                builderNames.[key].Add(uniqueName, count + 1)
            if builderNames.[key].[uniqueName] = 1 then builderName
            else $"{builderName}{builderNames.[key].[uniqueName]}"
        else
            builderNames.Add(key, Dictionary([ KeyValuePair (uniqueName, 1) ]))
            builderName
            

    let internalCode =
        metaInfos.metas
        |> Seq.map (fun (ns, metas) ->
            let code =
                metas
                |> Seq.map (fun meta ->
                    let originalGenerics = meta.generics |> getTypeNames |> createGenerics |> closeGenerics
                    let originalTypeWithGenerics = $"{meta.ty.Namespace}.{getTypeShortName meta.ty}{originalGenerics}"
                    let builderName = makeBuilderName meta.ty

                    let ref = $"    [<CustomOperation(\"ref'\")>] member this.ref' ({meta.contextArg}, x) = attr.ref<{originalTypeWithGenerics}> x |> this.AddProp"
                    
                    let inheirit' =  $"inherit {if meta.addBasicDomAttrs then nameof FunBlazorContextWithAttrs else nameof FunBlazorContext}<{funBlazorGeneric}>()"
                        //match meta.inheritInfo with
                        //| None -> $"inherit {if meta.addBasicDomAttrs then nameof FunBlazorContextWithAttrs else nameof FunBlazorContext}<{funBlazorGeneric}>()"
                        //| Some (baseTy, _) -> $"inherit {baseTy.Namespace |> trimNamespace |> appendStrIfNotEmpty (string '.')}{makeBuilderName meta.ty.BaseType}<{funBlazorGeneric}>()"

                    let news =
                        if meta.hasChildren then
                            let makeChild x = $"Bolero.Html.attr.fragment \"ChildContent\" ({x} |> html.toBolero) |> BoleroAttr |> this.AddProp"
                            let makeChildWithText = makeChild "x |> html.text"
                            let makeChildWithNodes = makeChild "x |> html.fragment"
                            $"    new (x: string) as this = {meta.ty |> getTypeShortName}Builder<{funBlazorGeneric}>() then {makeChildWithText} |> ignore"
                            + "\n"+
                            $"    new (x: {nameof IFunBlazorNode} list) as this = {meta.ty |> getTypeShortName}Builder<{funBlazorGeneric}>() then {makeChildWithNodes} |> ignore"
                        else
                            ""

                    $"""
type {builderName}<{funBlazorGeneric} when {funBlazorGeneric} :> Microsoft.AspNetCore.Components.IComponent> () =
    {inheirit'}
{news}
    
    member this.Yield _ = {builderName}<{funBlazorGeneric}>()

{ref}
{meta.props}
                """)
                |> String.concat "\n"
            
            $"""namespace rec {targetNamespace}.{internalSegment}{ns |> trimNamespace |> addStrIfNotEmpty "."}

{opens}

{code}
            """)
        |> String.concat "\n"

    let dslCode =
        metaInfos.metas
        |> Seq.groupBy fst
        |> Seq.map (fun (ns, group) ->
            let metas = group |> Seq.map snd |> Seq.concat
            let code =
                metas
                |> Seq.map (fun meta ->
                    let originalGenerics = meta.generics |> getTypeNames |> createGenerics |> closeGenerics
                    let originalTypeWithGenerics = $"{meta.ty.Namespace}.{getTypeShortName meta.ty}{originalGenerics}"
                    let builderName = makeBuilderName meta.ty

                    $"""    type {meta.ty |> getTypeShortName |> lowerFirstCase}{meta.generics |> getTypeNames |> createGenerics |> appendStr (createConstraint meta.generics) |> closeGenerics} = {builderName}<{originalTypeWithGenerics}>""")
                |> String.concat "\n"

            $"""namespace {targetNamespace}{ns |> trimNamespace |> addStrIfNotEmpty "."}

[<AutoOpen>]
module DslCE =

    open {targetNamespace}.{internalSegment}{ns |> trimNamespace |> addStrIfNotEmpty "."}

{ code }
            """)
        |> String.concat "\n"

    {| internalCode= internalCode; dslCode = dslCode |}
