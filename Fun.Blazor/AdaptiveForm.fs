namespace rec Fun.Blazor

open System
open System.Collections.Generic
open System.Linq.Expressions
open FSharp.Data.Adaptive


type Validator<'T, 'Prop, 'Error> = AdaptiveForm<'T, 'Error> -> 'Prop -> 'Error list


type AdaptiveForm<'T, 'Error> (defaultValue: 'T) as this =
    let ty = typeof<'T>

    let props =
        if FSharp.Reflection.FSharpType.IsRecord ty then
            FSharp.Reflection.FSharpType.GetRecordFields ty
        else
            ty.GetProperties()


    let mutable disposes = List<IDisposable>()
    let mutable fields = Dictionary<string, cval<obj>>()
    let mutable errors = Dictionary<string, cval<'Error list>>()


    let setFieldsAndErrors (value: 'T) =
        fields <-
            props
            |> Seq.map (fun p -> KeyValuePair(p.Name, cval(p.GetValue value)))
            |> Dictionary

        errors <-
            props
            |> Seq.map (fun x -> KeyValuePair(x.Name, cval []))
            |> Dictionary


    let rec getExpressionName (exp: Expression) =
        match exp.NodeType with
        | ExpressionType.MemberAccess -> (exp :?> MemberExpression).Member.Name
        | ExpressionType.Lambda -> ((exp :?> LambdaExpression).Body :?> MemberExpression).Member.Name
        | ExpressionType.Convert -> getExpressionName (exp :?> UnaryExpression).Operand
        | _ -> failwith "Unsupported expression"

    do setFieldsAndErrors defaultValue


    member _.SetValue value = setFieldsAndErrors value

    
    member _.GetValue () =
        let fields = fields |> Seq.map (function KeyValue(_, x) -> x.Value) |> Seq.toArray

        if FSharp.Reflection.FSharpType.IsRecord ty then
            FSharp.Reflection.FSharpValue.MakeRecord(ty, fields)
        else
            Activator.CreateInstance(ty, fields)
        |> unbox<'T>


    member _.AddAalidators (prop: Expression<Func<'T, 'Prop>>, checkAll, validators': Validator<'T, 'Prop, 'Error> list) =
        let name = getExpressionName prop
        let field = fields.[name]

        let validate value =
            if checkAll then
                validators'
                |> List.map (fun fn -> fn this value)
                |> List.concat
                |> errors.[name].Publish
            else
                validators'
                |> List.tryPick (fun fn ->
                    match fn this value with
                    | [] -> None
                    | x -> Some x)
                |> Option.defaultValue []
                |> errors.[name].Publish

        validate (unbox<'Prop> field.Value)
        field.AddCallback (unbox<'Prop> >> validate) |> disposes.Add

        this


    member _.UseFieldValue (propSelector: Expression<Func<'T, 'Prop>>) =
        fields.[getExpressionName propSelector] |> AVal.map unbox<'Prop>

    member _.UseField (propSelector: Expression<Func<'T, 'Prop>>) =
        let field = fields.[getExpressionName propSelector]
        let setter (x: 'Prop) = field.Publish x
        field |> AVal.map (fun x -> unbox<'Prop> x, setter)

    member _.UseFieldWithErrors (propSelector: Expression<Func<'T, 'Prop>>) =
        let propName = getExpressionName propSelector
        let field = fields.[propName]
        let setter (x: 'Prop) = field.Publish x

        adaptive {
            let! value = field
            let! errors = errors.[propName]
            return (unbox<'Prop> value, setter), errors
        }


    member _.UseErrors () =
        errors
        |> Seq.map (function KeyValue(_, v) -> v)
        |> Seq.fold
            (fun state errors ->
                adaptive {
                    let! statedErrors = state
                    let! errors = errors
                    return statedErrors@errors
                })
            (AVal.init [])

    
    member _.GetFieldValue propSelector =
        this.UseFieldValue propSelector |> AVal.force


    interface IDisposable with
        member _.Dispose() =
            disposes |> Seq.iter (fun d -> d.Dispose())


module Validators =
    let required error: Validator<'T, _, 'Error> =
        fun _ value ->
            if String.IsNullOrEmpty value then
                [ error ]
            else
                []
    
    let notEqual target error: Validator<'T, _, 'Error> =
        fun _ value ->
            if target = value then [ error value ]
            else []
    
    
    let maxLength max error: Validator<'T, _, 'Error> =
        fun _ value ->
            if not (String.IsNullOrEmpty value) && value.Length > max
            then [ error max ]
            else []
    
    let minLength min error: Validator<'T, _, 'Error> =
        fun _ value ->
            if not (String.IsNullOrEmpty value) && value.Length < min
            then [ error min ]
            else []
    
    
    let maxValue max error: Validator<'T, _, 'Error> =
        fun _ value ->
            if value > max
            then [ error max ]
            else []
    
    let minValue min error: Validator<'T, _, 'Error> =
        fun _ value ->
            if value < min
            then [ error min ]
            else []
    
    let seqMinLen min error: Validator<'T, _, 'Error> =
        fun _ value ->
            if value |> Seq.length < min
            then [ error min ]
            else []
    
    let seqMaxLen max error: Validator<'T, _, 'Error> =
        fun _ value ->
            if value |> Seq.length > max
            then [ error max ]
            else []
