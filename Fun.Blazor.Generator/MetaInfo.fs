module Fun.Blazor.Generator.MetaInfo

open System
open Microsoft.AspNetCore.Components
open Utils


type private TypeTree = | Node of Type * TypeTree list

let rec private getTypeTree (baseType: Type) (tys: Type list) : TypeTree list =
    let baseTypeName = baseType.Namespace + "." + baseType.Name
    tys
    |> Seq.filter (fun x ->
        if baseType.IsGenericType && x.BaseType <> null then
            baseTypeName = x.BaseType.Namespace + "." + x.BaseType.Name
        else
            x.BaseType = baseType
    )
    |> Seq.map (fun ty -> Node(ty, getTypeTree ty tys))
    |> Seq.toList


let create (buildMetaInfo: Type -> Namespace * 'T) (types: Type seq) =
    let rec getNamespaces tree =
        tree
        |> Seq.map (fun (Node (ty, childTys)) -> ty.Namespace :: (getNamespaces childTys |> Seq.toList))
        |> Seq.concat

    let rec getTypesInNamespace tree ns =
        tree
        |> Seq.map (fun (Node (ty, childTys)) ->
            [
                if ty.Namespace = ns then
                    ty
                    yield! getTypesInNamespace childTys ns
            ]
        )
        |> Seq.concat

    let rec getRootNamespaces (nss: string list) =
        match nss with
        | [] -> []
        | [ ns ] -> [ ns ]
        | ns :: rest ->
            let _, p2 = rest |> List.partition (fun x -> x.StartsWith ns)
            ns :: getRootNamespaces p2

    let rec getOrderedTypes tree =
        tree |> Seq.map (fun (Node (ty, childTys)) -> [ ty; yield! getOrderedTypes childTys ]) |> Seq.concat

    let rootType = typedefof<ComponentBase>

    let validTypes =
        types
        |> Seq.filter (fun x ->
            x.IsAssignableTo rootType && x.IsPublic && not (isObsoleted (x.GetCustomAttributes(false)))
        )
        |> Seq.toList

    let baseTypes = validTypes |> Seq.map (fun x -> x.BaseType) |> Seq.filter ((<>) rootType)

    let deeperBaseTypes = System.Collections.Generic.List()

    let rec seekMoreBaseTypes (tys: Type seq) =
        for ty in tys do
            if ty.BaseType <> rootType then
                if not ty.BaseType.IsConstructedGenericType then deeperBaseTypes.Add ty.BaseType
                seekMoreBaseTypes [ ty.BaseType ]

    seekMoreBaseTypes baseTypes

    let tree =
        validTypes
        |> Seq.append baseTypes
        |> Seq.append deeperBaseTypes
        |> Seq.distinct
        |> Seq.filter (fun x -> not x.IsConstructedGenericType)
        |> Seq.toList
        |> getTypeTree rootType
        |> Seq.toList

    let namespaces = getNamespaces tree |> Seq.toList
    let metaGroups = System.Collections.Generic.List<_>()

    tree
    |> getOrderedTypes
    |> Seq.map buildMetaInfo
    |> Seq.iter (fun (metaTyNamespace, meta) ->
        if metaGroups.Count = 0 then
            metaGroups.Add(metaTyNamespace, [ meta ])
        else
            let ns, metas = metaGroups |> Seq.last
            if ns = metaTyNamespace then
                metaGroups.[metaGroups.Count - 1] <- (ns, metas @ [ meta ])
            else
                metaGroups.Add(metaTyNamespace, [ meta ])
    )

    {|
        rootNamespaces = getRootNamespaces namespaces
        metas = metaGroups |> Seq.toList
    |}
