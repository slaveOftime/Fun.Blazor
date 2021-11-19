module Fun.Blazor.Generator.Utils

open System
open System.Reflection
open Microsoft.AspNetCore.Components


let fsharpKeywords = [ "component"; "checked"; "abstract"; "and"; "as"; "assert"; "base"; "begin"; "class"; "default"; "delegate"; "do"; "done"; "downcast"; "downto"; "elif"; "else"; "end"; "exception"; "extern"; "false"; "finally"; "fixed"; "for"; "fun"; "function"; "global"; "if"; "in"; "inherit"; "inline"; "interface"; "internal"; "lazy"; "let"; "let!"; "match"; "match!"; "member"; "module"; "mutable"; "namespace"; "new"; "not"; "null"; "of"; "open"; "or"; "override"; "private"; "public"; "rec"; "return"; "return!"; "select"; "static"; "struct"; "then"; "to"; "true"; "try"; "type"; "upcast"; "use"; "use!"; "val"; "void"; "when"; "while"; "with"; "yield"; "yield!"; "const" ]
let internalSegment = "DslInternals"
let funBlazorGeneric = "'FunBlazorGeneric"
let boleroNode = "Bolero.Node"
let boleroAttr = "Bolero.Attr"


let lowerFirstCase (str: string) =
    if String.IsNullOrEmpty str then ""
    elif str.Length = 1 then str.ToLower()
    else str.Substring(0, 1).ToLower() + str.Substring(1, str.Length - 1)

let avoidFsharpKeywords str =
    if fsharpKeywords |> List.contains str then str + "'"
    else str

let createGenerics (strs: string seq) =
    if Seq.length strs = 0 then ""
    else strs |> String.concat ", "
    
let closeGenerics str =
    if String.IsNullOrEmpty str then ""
    else sprintf "<%s>" str


let getTypeShortName (ty: Type) =
    if ty.Name.Contains "`" then ty.Name.Split("`").[0]
    else ty.Name

 
let rec getTypeName (ty: Type) =
    let interfaces = ty.GetInterfaces()
    let isIEnumerable, isList, isDictionary = 
        interfaces 
        |> Seq.fold
            (fun (isIEnumerable, isList, isDictionary) x -> 
                if x.Namespace = "System.Collections.Generic" then
                    if x.Name.StartsWith "Dictionary`" then Some x, isList, Some x
                    elif x.Name.StartsWith "List`" then Some x, Some x, isDictionary
                    elif x.Name.StartsWith "IEnumerable`" then Some x, isList, isDictionary
                    else isIEnumerable, isList, isDictionary
                else isIEnumerable, isList, isDictionary)
            (None, None, None)
    
    let getName (ty: Type)  = 
        if ty.Name.Contains "`" then
            let generics =
                if ty.GenericTypeArguments.Length > 0 then
                    ty.GenericTypeArguments
                else
                    ty.GetTypeInfo().GenericTypeParameters
                |> Seq.map getTypeName
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

    if ty = typeof<string> then "System.String"
    else
        if ty.IsArray then
            match isIEnumerable with
            | Some e -> $"{getTypeName e.GenericTypeArguments.[0]}[]"
            | None -> getName ty
        else
            match isList with
            | Some e -> $"System.Collections.Generic.List<{getTypeName e.GenericTypeArguments.[0]}>"
            | None ->
                match isDictionary with
                | Some e -> $"System.Collections.Generic.Dictionary<{getTypeName e.GenericTypeArguments.[0]}>"
                | None -> getName ty


let getTypeNames (tys: Type list) = List.map getTypeName tys


let createConstraint (tys: Type list) =
    tys
    |> List.filter (fun x -> x.IsGenericParameter)
    |> List.map (fun x ->
        let tyConstraints = x.GetGenericParameterConstraints()
        [
            if (x.GenericParameterAttributes &&& GenericParameterAttributes.ReferenceTypeConstraint) = GenericParameterAttributes.ReferenceTypeConstraint then
                $"'{x.Name} : not struct"
            if (x.GenericParameterAttributes &&& GenericParameterAttributes.DefaultConstructorConstraint) = GenericParameterAttributes.DefaultConstructorConstraint then
                $"'{x.Name} : (new : unit -> '{x.Name})"
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


let appendConstraint (constraint': string) (x: string) = if x.Contains "when " then x + $" and {constraint'}" else $" when {constraint'}"

let appendStr (x: string) (y: string) = y + x

let appendStrIfNotEmpty (x: string) (y: string) =
    if String.IsNullOrEmpty y then ""
    else y + x

let addStrIfNotEmpty (x: string) (y: string) =
    if String.IsNullOrEmpty y then ""
    else x + y


let getValidBlazorProps ty =
    Seq.filter (fun (prop: PropertyInfo) ->
        prop.DeclaringType = ty &&
        prop.CustomAttributes |> Seq.exists (fun x -> x.AttributeType = typeof<ParameterAttribute>))


let isBindable (prop: PropertyInfo) = Seq.exists (fun (x: PropertyInfo) -> x.Name = prop.Name + "Changed")
