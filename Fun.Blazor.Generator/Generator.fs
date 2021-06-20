module Fun.Blazor.Generator.Generator

open System
open System.Reflection
open Microsoft.AspNetCore.Components
open Fun.Blazor

open Utils


let private fsharpKeywords = [ "component"; "checked"; "abstract"; "and"; "as"; "assert"; "base"; "begin"; "class"; "default"; "delegate"; "do"; "done"; "downcast"; "downto"; "elif"; "else"; "end"; "exception"; "extern"; "false"; "finally"; "fixed"; "for"; "fun"; "function"; "global"; "if"; "in"; "inherit"; "inline"; "interface"; "internal"; "lazy"; "let"; "let!"; "match"; "match!"; "member"; "module"; "mutable"; "namespace"; "new"; "not"; "null"; "of"; "open"; "or"; "override"; "private"; "public"; "rec"; "return"; "return!"; "select"; "static"; "struct"; "then"; "to"; "true"; "try"; "type"; "upcast"; "use"; "use!"; "val"; "void"; "when"; "while"; "with"; "yield"; "yield!"; "const" ]
  

let private getMetaInfo (tys: Type seq) =
    tys
    |> Seq.filter (fun x -> x.IsAssignableTo typeof<ComponentBase>)
    //|> Seq.filter (fun x -> x.Name.Contains "MudBooleanInput")
    |> Seq.choose (fun ty ->
        let props = 
            ty.GetProperties()
            |> Seq.choose (fun prop ->
                if prop.CustomAttributes
                    |> Seq.exists (fun x -> x.AttributeType = typeof<ParameterAttribute>)
                    |> not
                then None
                else
                    let name = lowerFirstCase prop.Name
                    let name =
                        if fsharpKeywords |> List.contains name then $"{name}'"
                        else name
                    if prop.PropertyType.IsGenericType then
                        if prop.PropertyType.Name.StartsWith "EventCallback" ||
                           prop.PropertyType.Name.StartsWith "Microsoft.AspNetCore.Components.EventCallback"
                        then
                            Some [ $"    static member inline {name} fn = (Bolero.Html.attr.callback<{getTypeName prop.PropertyType.GenericTypeArguments.[0]}> \"{prop.Name}\" (fun e -> fn e)) |> {nameof BoleroAttr}" ]
                        else
                            Some [ $"    static member inline {name} (x: {getTypeName prop.PropertyType}) = \"{prop.Name}\" => x |> {nameof BoleroAttr}" ]

                    elif prop.Name = "ChildContent" then
                        Some [ 
                            $"    static member inline children (nodes: {nameof FunBlazorNode} list) = attr.children nodes"
                            $"    static member inline children (text: string) = attr.children text"
                        ]

                    elif prop.Name = "Class" && prop.PropertyType = typeof<string> then
                        Some [ $"    static member inline classes (x: string list) = attr.classes x" ]

                    elif prop.Name = "Style" && prop.PropertyType = typeof<string> then
                        Some [ $"    static member inline styles (x: (string * string) list) = attr.styles x" ]
                    else
                        Some [ $"    static member inline {name} (x: {getTypeName prop.PropertyType}) = \"{prop.Name}\" => x |> {nameof BoleroAttr}" ])

            |> Seq.concat
            |> Seq.map (fun x -> $"{x} |> {nameof GenericFunBlazorNode}<{funBlazorGeneric}>.create")
            |> String.concat "\n"


        let getTypeMeta (ty: Type) =
            if ty.Name.Contains "`" then
                let generics =
                    if ty.GenericTypeArguments.Length = 0 then
                        ty.GetTypeInfo().GenericTypeParameters
                    else
                        ty.GenericTypeArguments
                    |> Seq.toList
                ty.Name.Split("`").[0], generics
            else
                ty.Name, []

        let inherits =
            if ty.BaseType <> typeof<Microsoft.AspNetCore.Components.ComponentBase> then
                Some (getTypeMeta ty.BaseType)
            else
                None

        let name, generics, inheritInfo =
            match getTypeMeta ty, inherits with
            | (name, generics), Some (baseName, generics') -> 
                let generics = List.append generics' generics |> List.distinctBy (fun x -> x.Name) |> List.filter (fun x -> (getTypeName x).StartsWith "'")
                name, generics, Some (baseName, generics')

            | (name, generics), None ->
                name, generics, None

        let hasChildren = props.Contains "static member inline children"
        Some {| ns = ty.Namespace; name = name; generics = generics; inheritInfo = inheritInfo; props = props; hasChildren = hasChildren |})


let generateCode (tys: Type seq) =
    let metaInfos = getMetaInfo tys

    let internalCode =
        metaInfos
        |> Seq.map (fun meta ->
            let inheirit' =
                match meta.inheritInfo with
                | None -> ""
                | Some (ty, generics) -> $"inherit {lowerFirstCase ty}{ funBlazorGeneric::(getTypeNames generics) |> createGenerics |> closeGenerics }"

            let maker2 =
                if meta.hasChildren then
                    $"    static member create (nodes: {nameof FunBlazorNode} list) = nodes |> html.blazor<{meta.ns}.{meta.name}{meta.generics |> getTypeNames |> createGenerics |> closeGenerics}>"
                    + "\n"+
                    $"    static member create (node: {nameof FunBlazorNode}) = [ node ] |> html.blazor<{meta.ns}.{meta.name}{meta.generics |> getTypeNames |> createGenerics |> closeGenerics}>"
                else
                    ""

            sprintf $"""
type { lowerFirstCase meta.name }{ funBlazorGeneric::(getTypeNames meta.generics) |> createGenerics |> appendStr (createConstraint meta.generics) |> closeGenerics } =
    {inheirit'}
    static member create (nodes: {nameof GenericFunBlazorNode}<{funBlazorGeneric}> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<{meta.ns}.{meta.name}{meta.generics |> getTypeNames |> createGenerics |> closeGenerics}>
{maker2}
{meta.props}
        """)

        |> String.concat "\n"

    let dslCode =
        metaInfos
        |> Seq.map (fun meta ->
            let interfaceTy = $"I{ meta.name }Node{ meta.generics |> getTypeNames |> createGenerics |> closeGenerics }"
            sprintf $"""
type { interfaceTy } = interface end

type { lowerFirstCase meta.name }{ meta.generics |> getTypeNames |> createGenerics |> appendStr (createConstraint meta.generics) |> closeGenerics } =
    class
        inherit Internal.{ lowerFirstCase meta.name }{ interfaceTy::(getTypeNames meta.generics) |> createGenerics |> closeGenerics  }
    end""")
        |> String.concat "\n"

    {| internalCode= internalCode; dslCode = dslCode |}
