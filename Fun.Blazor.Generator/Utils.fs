module Fun.Blazor.Generator.Utils

open System
open System.Reflection


let lowerFirstCase (str: string) =
    if String.IsNullOrEmpty str then ""
    elif str.Length = 1 then str.ToLower()
    else str.Substring(0, 1).ToLower() + str.Substring(1, str.Length - 1)


let felizBoleroGeneric = "'FelizBoleroNode"


let createGenerics (strs: string seq) =
    if Seq.length strs = 0 then ""
    else strs |> String.concat ", "
    
let closeGenerics str =
    if String.IsNullOrEmpty str then ""
    else sprintf "<%s>" str


let getTypeName (x: Type) = if x.IsGenericParameter then $"'{x.Name}" else x.FullName
let getTypeNames (tys: Type list) = List.map getTypeName tys


let createConstraint (tys: Type list) =
    tys
    |> List.filter (fun x -> x.IsGenericParameter)
    |> List.map (fun x ->
        let tyConstraints = x.GetGenericParameterConstraints()
        [
            if x.GenericParameterAttributes = GenericParameterAttributes.ReferenceTypeConstraint then
                $"'{x.Name} : not struct"
            yield!
                tyConstraints
                |> Seq.filter (fun x -> String.IsNullOrEmpty x.FullName |> not)
                |> Seq.map (fun ty -> $"'{x.Name} :> {ty.FullName}")
        ])
    |> List.concat
    |> String.concat " and "
    |> fun x ->
        if String.IsNullOrEmpty x then ""
        else $" when {x}"


let appendStr (x: string) (y: string) = y + x


let rec getTypeFullName (ty: Type) =
    let interfaces = ty.GetInterfaces()
    let enumerable = interfaces |> Seq.tryFind (fun x -> x.Name.StartsWith "IEnumerable`" && x.Namespace = "System.Collections.Generic")

    if ty = typeof<string> then "System.String"
    else
        match enumerable with
        | Some e -> getTypeFullName e
        | None ->
            if ty.Name.Contains "`" then
                let generics =
                    ty.GenericTypeArguments
                    |> Seq.map getTypeFullName
                    |> String.concat ", "
                    |> fun x ->
                        if String.IsNullOrEmpty x then ""
                        else $"<{x}>"
                let name = ty.Name.Split('`').[0]
                $"{ty.Namespace}.{name}{generics}"

            elif String.IsNullOrEmpty ty.FullName |> not then 
                if ty.FullName.Contains "+" then $"{ty.ReflectedType.FullName}.{ty.Name}"
                else ty.FullName

            else
                $"'{ty.Name}"

