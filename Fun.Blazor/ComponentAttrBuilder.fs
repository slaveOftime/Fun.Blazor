namespace Fun.Blazor

open System
open System.Reflection
open System.Linq.Expressions
open Microsoft.AspNetCore.Components
open Operators

/// Create AttrRenderFragment for compponent with type safety
type ComponentAttrBuilder<'T when 'T :> IComponent>() =
    let mutable attr = Internal.emptyAttr ()

    let rec getExpressionName (exp: Expression) =
        match exp.NodeType with
        | ExpressionType.MemberAccess -> (exp :?> MemberExpression).Member.Name
        | ExpressionType.Lambda -> ((exp :?> LambdaExpression).Body :?> MemberExpression).Member.Name
        | ExpressionType.Convert -> getExpressionName (exp :?> UnaryExpression).Operand
        | _ -> failwith "Unsupported expression"

    /// The last Add will take effect for the final attribute been used
    member this.Add<'Prop>(expression: Expression<Func<'T, 'Prop>>, value: 'Prop) =
        // We should always put the latest added value to first, so blazor can take it as the final attribute
        attr <- (getExpressionName expression => value) ==> attr
        this

    /// The last Add will take effect for the final attribute been used
    /// Take property which has attribute ParameterAttribute
    member this.Add(state: 'T) =
        attr <-
            typeof<'T>.GetProperties(BindingFlags.Instance ||| BindingFlags.Public)
            |> Seq.choose (fun p ->
                let attr = p.GetCustomAttribute<ParameterAttribute>()
                if isNull attr then None else Some p
            )
            |> Seq.map (fun p -> p.Name => p.GetValue(state))
            // We should always put the latest added value to first, so blazor can take it as the final attribute
            |> Seq.fold (fun x y -> y ==> x) attr
        this

    member _.Build() = attr
