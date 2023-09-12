namespace rec Fun.Blazor

open System
open System.Linq
open System.Collections.Generic
open System.Linq.Expressions
open System.Runtime.CompilerServices
open FSharp.Data.Adaptive


type Validator<'T, 'Prop, 'Error> = AdaptiveForm<'T, 'Error> -> 'Prop -> 'Error list


/// For internal use only
type internal IAdaptiveForm =
    abstract member SetValueObj: value: obj -> unit
    abstract member GetValueObj: unit -> obj


type AdaptiveForm<'T, 'Error>(defaultValue: 'T) as this =
    let ty = typeof<'T>

    let props =
        if FSharp.Reflection.FSharpType.IsRecord ty then
            FSharp.Reflection.FSharpType.GetRecordFields(ty) |> Seq.ofArray
        else
            ty.GetProperties().Where(fun x -> not (x.GetAccessors(true).Any(fun x -> x.IsStatic)))


    let hasChanges = cval false
    let disposes = List<IDisposable>()
    let mutable fields = Dictionary<string, cval<obj>>()
    let mutable errors = Dictionary<string, cval<'Error list>>()
    let mutable loaders = Dictionary<string, cval<bool>>()

    let subForms = Dictionary<string, obj>()

    let rec getExpressionName (exp: Expression) =
        match exp.NodeType with
        | ExpressionType.MemberAccess -> (exp :?> MemberExpression).Member.Name
        | ExpressionType.Lambda -> ((exp :?> LambdaExpression).Body :?> MemberExpression).Member.Name
        | ExpressionType.Convert -> getExpressionName (exp :?> UnaryExpression).Operand
        | _ -> failwith "Unsupported expression"


    do
        fields <-
            props
            |> Seq.map (fun p ->
                let v = cval (p.GetValue defaultValue)
                v.AddLazyCallback(fun _ -> hasChanges.Publish true) |> disposes.Add
                KeyValuePair(p.Name, v)
            )
            |> Dictionary

        errors <- props |> Seq.map (fun x -> KeyValuePair(x.Name, cval [])) |> Dictionary
        loaders <- props |> Seq.map (fun x -> KeyValuePair(x.Name, cval false)) |> Dictionary


    member _.SetValue(value: 'T) = (this :> IAdaptiveForm).SetValueObj(value)

    member _.GetValue() = (this :> IAdaptiveForm).GetValueObj() |> unbox<'T>


    member _.AddValidators(prop: Expression<Func<'T, 'Prop>>, checkAll, validators': Validator<'T, 'Prop, 'Error> list) =
        let name = getExpressionName prop
        let field = fields.[name]

        let validate value =
            if checkAll then
                validators' |> List.map (fun fn -> fn this value) |> List.concat |> errors.[name].Publish
            else
                validators'
                |> List.tryPick (fun fn ->
                    match fn this value with
                    | [] -> None
                    | x -> Some x
                )
                |> Option.defaultValue []
                |> errors.[name].Publish

        field.AddCallback(unbox<'Prop> >> validate) |> disposes.Add

        this


    member _.UseHasChanges() = hasChanges :> aval<bool>

    member _.UseFieldValue(propSelector: Expression<Func<'T, 'Prop>>) = fields.[getExpressionName propSelector] |> AVal.map unbox<'Prop>

    member _.UseFieldSetter(propSelector: Expression<Func<'T, 'Prop>>) = fun (v: 'Prop) -> fields.[getExpressionName propSelector].Publish(v)

    member _.UseField(propSelector: Expression<Func<'T, 'Prop>>) =
        let field = fields.[getExpressionName propSelector]
        let setter (x: 'Prop) = field.Publish x
        field |> AVal.map (fun x -> unbox<'Prop> x, setter)

    member _.UseFieldWithErrors(propSelector: Expression<Func<'T, 'Prop>>) =
        let propName = getExpressionName propSelector
        let field = fields.[propName]
        let setter (x: 'Prop) = field.Publish x

        adaptive {
            let! value = field
            let! errors = errors.[propName]
            return (unbox<'Prop> value, setter), errors
        }


    member _.UseLoaderValue(propSelector: Expression<Func<'T, 'Prop>>) = loaders.[getExpressionName propSelector]

    member _.UseLoaderSetter(propSelector: Expression<Func<'T, 'Prop>>) = fun (v: bool) -> loaders.[getExpressionName propSelector].Publish(v)

    member _.UseLoader(propSelector: Expression<Func<'T, 'Prop>>) =
        let loader = loaders.[getExpressionName propSelector]
        let setter (x: bool) = loader.Publish x
        loader |> AVal.map (fun x -> x, setter)


    member _.UseFieldErrors(propSelector: Expression<Func<'T, 'Prop>>) =
        let errors = errors.[getExpressionName propSelector]
        let setter (x: 'Error list) = errors.Publish x
        errors |> AVal.map (fun x -> x, setter)

    member _.UseFieldErrorsSetter(propSelector: Expression<Func<'T, 'Prop>>) =
        fun (v: 'Error list) -> errors.[getExpressionName propSelector].Publish(v)

    member _.UseErrors() =
        errors
        |> Seq.map (
            function
            | KeyValue(_, v) -> v
        )
        |> Seq.fold
            (fun state errors -> adaptive {
                let! statedErrors = state
                let! errors = errors
                return statedErrors @ errors
            })
            (AVal.constant [])


    member _.GetFieldValue propSelector = this.UseFieldValue propSelector |> AVal.force
    member _.GetFieldErrors propSelector = this.UseFieldErrors propSelector |> AVal.map fst |> AVal.force
    member _.GetErrors() = this.UseErrors() |> AVal.force


    member _.UseIsLoading() =
        loaders
        |> Seq.map (fun x -> x.Value)
        |> Seq.fold
            (fun s x -> adaptive {
                let! s' = s
                let! x' = x
                return s' || x'
            })
            (AVal.constant false)


    /// Use this to create a sub form for complex type. The loading/errors/changes will sync to the root form. And all the resource will be cleaned together with root form.
    /// When you use this you should not call UseFieldXXX for the same property, because the sub form is intend to be lazy instead of updating the field every time the sub fields are changed.
    /// Once you called this, the sub form will be the single truth of the source for this field.
    member _.GetSubForm(propSelector: Expression<Func<'T, 'Prop>>, ?mapError: 'SubError -> 'Error) =
        let mapError = defaultArg mapError unbox<'Error>

        let fieldName = getExpressionName propSelector
        let field = fields[fieldName]

        if subForms.ContainsKey fieldName |> not then
            let subForm = new AdaptiveForm<'Prop, 'SubError>(unbox<'Prop> field.Value)

            disposes.AddRange [
                subForm :> IDisposable
                subForm.UseErrors().AddLazyCallback(List.map mapError >> errors[fieldName].Publish)
                subForm.UseHasChanges().AddInstantCallback(fun x -> hasChanges.Publish(fun oldX -> oldX || x))
                subForm.UseIsLoading().AddInstantCallback(fun x -> loaders[fieldName].Publish(fun oldX -> oldX || x))
            ]

            subForms[fieldName] <- subForm
            subForm

        else
            subForms[fieldName] |> unbox


    interface IAdaptiveForm with

        member _.SetValueObj(value) =
            transact (fun _ ->
                // No need to clean errors, because if the we will set value below, if the value is changed then the error will be re-calculated, if it is not changed then the error should not be touched.
                //for KeyValue(_, error) in errors do
                //    error.Value <- []
                for prop in props do
                    let field = prop.GetValue value
                    fields.[prop.Name].Value <- field
                    if subForms.ContainsKey prop.Name then
                        (subForms[prop.Name] :?> IAdaptiveForm).SetValueObj(field)
            )
            hasChanges.Publish false

        member _.GetValueObj() =
            let fields =
                fields
                |> Seq.map (
                    function
                    | KeyValue(k, x) ->
                        if subForms.ContainsKey k then
                            (subForms[k] :?> IAdaptiveForm).GetValueObj()
                        else
                            x.Value
                )
                |> Seq.toArray

            if FSharp.Reflection.FSharpType.IsRecord ty then
                FSharp.Reflection.FSharpValue.MakeRecord(ty, fields)
            else
                Activator.CreateInstance(ty, fields)


    interface IDisposable with
        member _.Dispose() = disposes |> Seq.iter (fun d -> d.Dispose())


[<Extension>]
type AdaptiveFormExtensions =
    [<Extension>]
    static member UseAdaptiveForm<'T, 'Error>(this: IComponentHook, defaultValue) =
        let form = new AdaptiveForm<'T, 'Error>(defaultValue)
        this.AddDispose form
        form


module Validators =
    let required error : Validator<'T, _, 'Error> = fun _ value -> if String.IsNullOrEmpty value then [ error ] else []

    let notEqual target error : Validator<'T, _, 'Error> = fun _ value -> if target = value then [ error value ] else []


    let maxLength max error : Validator<'T, _, 'Error> =
        fun _ value ->
            if not (String.IsNullOrEmpty value) && value.Length > max then
                [ error max ]
            else
                []

    let minLength min error : Validator<'T, _, 'Error> =
        fun _ value ->
            if not (String.IsNullOrEmpty value) && value.Length < min then
                [ error min ]
            else
                []


    let maxValue max error : Validator<'T, _, 'Error> = fun _ value -> if value > max then [ error max ] else []

    let minValue min error : Validator<'T, _, 'Error> = fun _ value -> if value < min then [ error min ] else []

    let seqMinLen min error : Validator<'T, _, 'Error> = fun _ value -> if value |> Seq.length < min then [ error min ] else []

    let seqMaxLen max error : Validator<'T, _, 'Error> = fun _ value -> if value |> Seq.length > max then [ error max ] else []
