namespace Fun.Blazor

open System
open System.Collections.Generic
open System.Linq.Expressions
open FSharp.Data.Adaptive


type AdaptiveForm<'T> (defaultValue: 'T) =
    let ty = typeof<'T>

    let props =
        if FSharp.Reflection.FSharpType.IsRecord ty then
            FSharp.Reflection.FSharpType.GetRecordFields ty
        else
            ty.GetProperties()

    let mutable fields = Dictionary<string, cval<obj>>()


    let setFields (value: 'T) =
        fields <-
            props
            |> Seq.fold
                (fun (state: Dictionary<_, _>) p -> state.Add(p.Name, cval(p.GetValue value)); state)
                (Dictionary())

    let getField exp =
        let rec getName (exp: Expression) =
            match exp.NodeType with
            | ExpressionType.MemberAccess -> (exp :?> MemberExpression).Member.Name
            | ExpressionType.Lambda -> ((exp :?> LambdaExpression).Body :?> MemberExpression).Member.Name
            | ExpressionType.Convert -> getName (exp :?> UnaryExpression).Operand
            | _ -> failwith "Unsupported expression"

        fields[getName exp] |> unbox<cval<obj>>


    do setFields defaultValue


    member _.SetFields value = setFields value

    member _.UseFieldValue exp = getField exp |> AVal.map unbox<'Prop>

    member _.UseField (exp: Expression<Func<'T, 'Prop>>) =
        let value = getField exp
        let setter (x: 'Prop) = value.Publish x
        value |> AVal.map (fun x -> unbox<'Prop> x, setter)
        

    member _.GetValue () =
        let fields = fields |> Seq.map (function KeyValue(_, x) -> x.Value) |> Seq.toArray

        if FSharp.Reflection.FSharpType.IsRecord ty then
            FSharp.Reflection.FSharpValue.MakeRecord(ty, fields)
        else
            Activator.CreateInstance(ty, fields)
        |> unbox<'T>
