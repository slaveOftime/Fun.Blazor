namespace Fun.Blazor

open System
open System.Reflection
open System.Linq.Expressions
open Microsoft.AspNetCore.Components


/// Create query string builder with type safety
type QueryBuilder<'T>() =
    let query = System.Web.HttpUtility.ParseQueryString("")

    let rec getExpressionName (exp: Expression) =
        match exp.NodeType with
        | ExpressionType.MemberAccess -> (exp :?> MemberExpression).Member.Name
        | ExpressionType.Lambda -> ((exp :?> LambdaExpression).Body :?> MemberExpression).Member.Name
        | ExpressionType.Convert -> getExpressionName (exp :?> UnaryExpression).Operand
        | _ -> failwith "Unsupported expression"

    /// By default will always create or override existing query value
    member this.Add<'Prop>(expression: Expression<Func<'T, 'Prop>>, value: 'Prop, ?append: bool) =
        let key = getExpressionName expression

        match append with
        | Some true when isNull (box value) -> ()
        | Some true -> query.Add(key, value.ToString())
        | _ when isNull (box value) -> query.Remove(key)
        | _ -> query.Set(getExpressionName expression, value.ToString())

        this

    /// By default will always create or override existing query value. When null, query will be removed.
    member this.Add<'Prop when 'Prop: (new: unit -> 'Prop) and 'Prop: struct and 'Prop :> ValueType>
        (
            expression: Expression<Func<'T, 'Prop>>,
            value: Nullable<'Prop>,
            ?append: bool
        )
        =
        if value.HasValue then
            this.Add(expression, value.Value, defaultArg append false) |> ignore
        else
            query.Remove(getExpressionName expression)
        this

    /// Append multiple key value pairs
    member this.Add<'Prop>(expression: Expression<Func<'T, 'Prop>>, values: 'Prop seq) =
        let name = getExpressionName expression
        for value in values do
            query.Add(name, string value)
        this


    /// By default will always create or override existing query value
    member this.Add(key: string, value: obj, ?append: bool) =
        match value with
        | null -> query.Remove(key)
        | _ when value.GetType().FullName.StartsWith("System.Nullable`") -> query.Remove(key)
        | _ ->
            match append with
            | Some true -> query.Add(key, string value)
            | _ -> query.Set(key, string value)
        this

    /// Append multiple key value pairs
    member this.Add<'Prop>(key: string, values: 'Prop seq) =
        for value in values do
            query.Add(key, string value)
        this

    /// Append multiple key value pairs
    member this.Add(key: string, value: string, ?append: bool) =
        if String.IsNullOrEmpty value then
            query.Remove(key)
        else
            match append with
            | Some true -> query.Add(key, value)
            | _ -> query.Set(key, value)
        this


    /// Remove query by key
    member this.Remove(key: string) =
        query.Remove(key)
        this

    /// Remove query by expression name
    member this.Remove(expression: Expression<Func<'T, 'Prop>>) =
        query.Remove(getExpressionName expression)
        this

    /// Null property will be ignored. If typpe is IComponent then only property which is annotated with ParameterAttribute will be taken.
    /// This will override existing query values.
    member this.Add(state: obj) =
        let ty = state.GetType()
        let isComponent = ty.IsAssignableTo(typeof<IComponent>)

        state.GetType().GetProperties(BindingFlags.Instance ||| BindingFlags.Public)
        |> Seq.choose (fun p ->
            if isComponent then
                let attr = p.GetCustomAttribute<ParameterAttribute>()
                if isNull attr then None else Some p
            else
                Some p
        )
        |> Seq.iter (fun p ->
            match p.GetValue state with
            | null -> ()
            | x -> query.Set(p.Name, x.ToString())
        )

        this

    override _.ToString() = query.ToString()
