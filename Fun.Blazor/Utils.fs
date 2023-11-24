
[<AutoOpen>]
module Fun.Blazor.Utils

open System
open System.Diagnostics
open System.Threading.Tasks
open System.Reflection
open Microsoft.Extensions.Logging
open Microsoft.AspNetCore.Components
open Microsoft.Extensions.ObjectPool
open System.Linq.Expressions
open Fun.Blazor.Operators


module Internal =
    let inline emptyAttr () = AttrRenderFragment(fun _ _ i -> i + 1)
    let inline emptyNode () = NodeRenderFragment(fun _ _ i -> i + 1)

    [<Literal>]
    let FunBlazorScopedServicesName = "fun-blazor-scoped-services"


    let objectPoolProvider = DefaultObjectPoolProvider()
    let stringBuilderPool = objectPoolProvider.CreateStringBuilderPool()


    let makeStyles (rules: (string * string) seq) =
        let sb = stringBuilderPool.Get()

        for (k, v) in rules do
            sb.Append(k).Append(": ").Append(v).Append("; ") |> ignore

        let result = sb.ToString()
        stringBuilderPool.Return sb
        result

    /// Please do not depend on this type, it maybe renamed in the future
    [<Struct>]
    type AttrRenderFragmentWrapper = | AttrRenderFragmentWrapper of AttrRenderFragment


    type ILogger with

        member inline this.LogDebugForPerf fn =
#if DEBUG
            let sw = Stopwatch.StartNew()
            this.LogDebug($"Function started")
            let result = fn ()
            this.LogDebug($"Function finished in {sw.ElapsedMilliseconds}")
            result
#else
            fn ()
#endif



type IComponent with

    member comp.Render(fragment: NodeRenderFragment) = RenderFragment(fun builder -> fragment.Invoke(comp, builder, 0) |> ignore)

    member comp.Callback<'T>(fn: 'T -> unit) = EventCallback.Factory.Create<'T>(comp, fn)
    member comp.Callback<'T>(fn: 'T -> Task) = EventCallback.Factory.Create<'T>(comp, fn)


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

    member this.Add(state: 'T) =
        attr <-
            typeof<'T>.GetProperties()
            |> Seq.choose (fun p ->
                let attr = p.GetCustomAttribute<ParameterAttribute>()
                if isNull attr then None else Some p
            )
            |> Seq.map (fun p -> p.Name => p.GetValue(state))
            // We should always put the latest added value to first, so blazor can take it as the final attribute
            |> Seq.fold (fun x y -> y ==> x) attr
        this

    member _.Build() = attr


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
        match append with
        | Some true -> query.Add(getExpressionName expression, value.ToString())
        | _ -> query.Set(getExpressionName expression, value.ToString())
        this

    /// Null property will be ignored
    member this.Add(state: obj) =
        let ty = state.GetType()
        state.GetType().GetProperties()
        |> Seq.choose (fun p ->
            if ty = typeof<IComponent> then
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
