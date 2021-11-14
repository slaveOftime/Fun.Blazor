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
    let customOperation name = $"[<CustomOperation(\"{name}\")>]"
    let memberStart = "member this."
    let contextArg = $"_: FunBlazorContext<{funBlazorGeneric}>"

    let rawProps = ty.GetProperties()
    let filteredProps = getValidBlazorProps ty rawProps

    let props = 
        filteredProps
        |> Seq.map (fun prop ->
            let name = prop.Name
            let name =
                if fsharpKeywords@["Bind"; "Delay"; "Return"; "ReturnFrom"; "Run"; "Combine"; "For"; "TryFinally"; "TryWith"; "Using"; "While"; "Yield"; "YieldFrom"; "Zero"; "Quote"]
                   |> List.contains name 
                then $"{name}'"
                else name

            let _addProp = "|> this.AddProp"
            let _boleroAddProp = $"|> {nameof BoleroAttr} {_addProp}"

            let createBindableProps (propTypeName: string) =
                if isBindable prop filteredProps then
                    let bindName = name + "'"
                    [
                        $"    {customOperation bindName} {memberStart}{bindName} ({contextArg}, value: IStore<{propTypeName}>) = this.AddProp(\"{prop.Name}\", value)"
                        $"    {customOperation bindName} {memberStart}{bindName} ({contextArg}, value: cval<{propTypeName}>) = this.AddProp(\"{prop.Name}\", value)"
                    ]
                else
                    []
            
            if prop.PropertyType.IsGenericType then
                if prop.PropertyType.Name.StartsWith "EventCallback" ||
                   prop.PropertyType.Name.StartsWith "Microsoft.AspNetCore.Components.EventCallback"
                then
                    [ $"    {customOperation name} {memberStart}{name} ({contextArg}, fn) = (Bolero.Html.attr.callback<{getTypeName prop.PropertyType.GenericTypeArguments.[0]}> \"{prop.Name}\" (fun e -> fn e)) {_boleroAddProp}" ]
                elif prop.PropertyType.Name.StartsWith "RenderFragment`" then
                    [ $"    {customOperation name} {memberStart}{name} ({contextArg}, render: {getTypeName prop.PropertyType.GenericTypeArguments.[0]} -> {nameof IFunBlazorNode}) = Bolero.Html.attr.fragmentWith \"{prop.Name}\" (fun x -> render x |> html.toBolero) {_boleroAddProp}" ]
                elif prop.PropertyType.Namespace = "System"
                     && (prop.PropertyType.Name.StartsWith "Func`" 
                        || prop.PropertyType.Name.StartsWith "Action`") 
                then
                    [ $"    {customOperation name} {memberStart}{name} ({contextArg}, fn) = \"{prop.Name}\" => ({getTypeName prop.PropertyType}fn) {_boleroAddProp}" ]
                elif prop.PropertyType.Namespace = "System" && prop.PropertyType.Name.StartsWith "Func`" then
                    let returnType = prop.PropertyType.GenericTypeArguments |> Seq.last
                    if returnType = typeof<Microsoft.AspNetCore.Components.RenderFragment> then
                        let paramCount = prop.PropertyType.Name.Substring("Func`".Length) |> int
                        let parameters = [for i in 1..paramCount-1 do $"x{i}"] |> String.concat " "
                        [ $"    {customOperation name} {memberStart}{name} ({contextArg}, fn) = Bolero.FragmentAttr (\"{prop.Name}\", fun render -> box ({getTypeName prop.PropertyType}(fun {parameters} -> Microsoft.AspNetCore.Components.RenderFragment(fun rt -> render rt (html.toBolero(fn {parameters})))))) {_boleroAddProp}"  ]
                    else
                        [ $"    {customOperation name} {memberStart}{name} ({contextArg}, fn) = \"{prop.Name}\" => ({getTypeName prop.PropertyType}fn) {_boleroAddProp}" ]
                elif prop.PropertyType.Namespace = "System" && prop.PropertyType.Name.StartsWith "Action`" then
                    [ $"    {customOperation name} {memberStart}{name} ({contextArg}, fn) = \"{prop.Name}\" => ({getTypeName prop.PropertyType}fn) {_boleroAddProp}" ]
                else
                    let propTypeName = getTypeName prop.PropertyType
                    [
                        $"    {customOperation name} {memberStart}{name} ({contextArg}, x: {propTypeName}) = \"{prop.Name}\" => x {_boleroAddProp}"
                        yield! createBindableProps propTypeName
                    ]

            elif prop.PropertyType.Name.StartsWith "EventCallback" ||
                 prop.PropertyType.Name.StartsWith "Microsoft.AspNetCore.Components.EventCallback"
                then
                [ $"    {customOperation name} {memberStart}{name} ({contextArg}, fn) = evt.{nameof evt.callbackOfUnit} \"{prop.Name}\" fn {_addProp}" ]

            elif prop.PropertyType = typeof<RenderFragment> then
                let name = if name = "ChildContent" then lowerFirstCase name else name
                [
                    $"    {customOperation name} {memberStart}{name} ({contextArg}, nodes) = Bolero.Html.attr.fragment \"{prop.Name}\" (nodes |> html.fragment |> html.toBolero) {_boleroAddProp}"
                    $"    {customOperation name} {memberStart}{name} ({contextArg}, x: string) = Bolero.Html.attr.fragment \"{prop.Name}\" (html.text x |> html.toBolero) {_boleroAddProp}"
                    $"    {customOperation name} {memberStart}{name} ({contextArg}, x: int) = Bolero.Html.attr.fragment \"{prop.Name}\" (html.text x |> html.toBolero) {_boleroAddProp}"
                    $"    {customOperation name} {memberStart}{name} ({contextArg}, x: float) = Bolero.Html.attr.fragment \"{prop.Name}\" (html.text x |> html.toBolero) {_boleroAddProp}"
                ]

            elif prop.Name = "Class" && prop.PropertyType = typeof<string> then
                [ $"    [<CustomOperation(\"Classes\")>] {memberStart}Classes ({contextArg}, x: string list) = attr.classes x {_addProp}" ]

            elif prop.Name = "Style" && prop.PropertyType = typeof<string> then
                [ $"    [<CustomOperation(\"Styles\")>] {memberStart}Styles ({contextArg}, x: (string * string) list) = attr.styles x {_addProp}" ]
            
            else
                let propTypeName = getTypeName prop.PropertyType
                [
                    $"    {customOperation name} {memberStart}{name} ({contextArg}, x: {propTypeName}) = \"{prop.Name}\" => x {_boleroAddProp}"
                    yield! createBindableProps propTypeName
                ])

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

    {| ty = ty; generics = generics; inheritInfo = inheritInfo; props = props; hasChildren = hasChildren; addBasicDomAttrs = addBasicDomAttrs |}



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
    
    let builderNames = Dictionary<string, Dictionary<string, int>>()

    let makeBuilderName (ty: Type) =
        let info = ty.GetTypeInfo()

        let shortName = getTypeShortName ty
        let uniqueName = $"{shortName}-{info.GenericTypeArguments.Length + info.GenericTypeParameters.Length}"
        let builderName = $"{shortName}Builder"
        let key = $"{ty.Namespace}-{shortName}"

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
                    let funBlazorGenericConstraint = $"{funBlazorGeneric} :> Microsoft.AspNetCore.Components.IComponent"
                    let builderGenerics = funBlazorGeneric::(getTypeNames meta.generics) |> createGenerics |> closeGenerics
                    let builderGenericsWithContraints = funBlazorGeneric::(getTypeNames meta.generics) |> createGenerics |> appendStr (createConstraint meta.generics |> appendConstraint funBlazorGenericConstraint) |> closeGenerics

                    let inheirit' = 
                        //$"inherit {if meta.addBasicDomAttrs then nameof FunBlazorContextWithAttrs else nameof FunBlazorContext}<{funBlazorGeneric}>()"
                        match meta.inheritInfo with
                        | None -> 
                            $"inherit {if meta.addBasicDomAttrs then nameof FunBlazorContextWithAttrs else nameof FunBlazorContext}<{funBlazorGeneric}>()"
                        | Some (baseTy, generics) ->
                            $"inherit {baseTy.Namespace |> trimNamespace |> appendStrIfNotEmpty (string '.')}{makeBuilderName meta.ty.BaseType}{funBlazorGeneric::(getTypeNames generics) |> createGenerics |> closeGenerics}()"

                    let news =
                        if meta.hasChildren then
                            let makeChild x = $"Bolero.Html.attr.fragment \"ChildContent\" ({x} |> html.toBolero) |> BoleroAttr |> this.AddProp"
                            let makeChildWithText = makeChild "x |> html.text"
                            let makeChildWithNodes = makeChild "x |> html.fragment"
                            $"    new (x: string) as this = {meta.ty |> getTypeShortName}Builder{builderGenerics}() then {makeChildWithText} |> ignore"
                            + "\n"+
                            $"    new (x: {nameof IFunBlazorNode} list) as this = {meta.ty |> getTypeShortName}Builder{builderGenerics}() then {makeChildWithNodes} |> ignore"
                            + "\n"+
                            $"    static member create (x: string) = {builderName}{builderGenerics}(x) :> {nameof IFunBlazorNode}"
                            + "\n"+
                            $"    static member create (x: {nameof IFunBlazorNode} list) = {builderName}{builderGenerics}(x) :> {nameof IFunBlazorNode}"
                        else
                            $"    static member create () = {builderName}{builderGenerics}() :> {nameof IFunBlazorNode}"

                    $"""
type {builderName}{builderGenericsWithContraints}() =
    {inheirit'}
{news}
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
                    let builderGenerics = originalTypeWithGenerics::(getTypeNames meta.generics) |> createGenerics |> closeGenerics
                    

                    $"""    type {meta.ty |> getTypeShortName}'{meta.generics |> getTypeNames |> createGenerics |> appendStr (createConstraint meta.generics) |> closeGenerics} = {builderName}{builderGenerics}""")
                |> String.concat "\n"

            $"""namespace {targetNamespace}{ns |> trimNamespace |> addStrIfNotEmpty "."}

[<AutoOpen>]
module DslCE =

    open {targetNamespace}.{internalSegment}{ns |> trimNamespace |> addStrIfNotEmpty "."}

{ code }
            """)
        |> String.concat "\n"

    {| internalCode= internalCode; dslCode = dslCode |}
