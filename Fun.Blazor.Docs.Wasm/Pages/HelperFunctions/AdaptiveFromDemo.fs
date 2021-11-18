[<AutoOpen>]
module Fun.Blazor.Docs.Wasm.Pages.HelperFunctions.AdaptiveFromDemo

open System
open FSharp.Data.Adaptive
open MudBlazor
open Fun.Blazor
open Fun.Blazor.Validators
open Fun.Blazor.Docs.Wasm.Components


type Model = {
    Name: string
    Password: string
    Age: int
    Birthday: DateTime
} with
    static member DefaultValue() = {
        Name = ""
        Password = ""
        Age = 0
        Birthday = DateTime.Now
    }

type ModelErrors =
    | NameIsTooShort of int
    | NameIsTooLong of int
    | PasswordIsRequired
    | PasswordCannotEqualName
    | PasswordIsTooLong of int
    | PasswordCannotBe of string
    | AgeIsTooSmall of int
    | BirthdayIsTooEarly of DateTime
    | BirthdayIsTooOld of DateTime


let adaptiveFromDemo = html.inject <| fun (hook: IComponentHook) ->
    let modelForm = new AdaptiveForm<Model, ModelErrors>(Model.DefaultValue())
    
    modelForm
        .AddAalidators((fun x -> x.Name), false, [
            minLength 2 NameIsTooShort
            maxLength 10 NameIsTooLong
        ])
        .AddAalidators((fun x -> x.Password), true, [
            required PasswordIsRequired
            maxLength 15 PasswordIsTooLong
            notEqual "123456" PasswordCannotBe
            fun ctx value ->
                let name = ctx.GetFieldValue(fun x -> x.Name)
                if name = value then [ PasswordCannotEqualName ]
                else []
        ])
        .AddAalidators((fun x -> x.Age), false, [
            minValue 18 AgeIsTooSmall
        ])
        .AddAalidators((fun x -> x.Birthday), true, [
            minValue (DateTime.Parse("2000/1/1")) BirthdayIsTooOld
            maxValue (DateTime.Now.AddDays(1.)) BirthdayIsTooEarly
        ])
        |> ignore

    hook.AddDisposes [ modelForm ]



    let simplifyErrors = List.map string >> String.concat ", "

    let errorView es =
        match es with
        | [] -> html.none
        | _ ->
            MudAlert'(){
                Severity Severity.Error
                childContent (simplifyErrors es)
            }


    MudPaper'(){
        Elevation 10
        Styles [ style.padding 10 ]
        childContent [
            MudForm'(){
                childContent [
                    adaptiview(){
                        let! binding, errors = modelForm.UseFieldWithErrors(fun x -> x.Name)
                        MudTextField'(){
                            key "name"
                            Label "Name"
                            Value' binding
                            //Error (not errors.IsEmpty)
                            //ErrorText (simplifyErrors errors)
                            // There is a bug related to MudBlazor: error will disapre after blur
                            Immediate true
                        }
                        errorView errors
                    }
                    adaptiview(){
                        let! binding, errors = modelForm.UseFieldWithErrors(fun x -> x.Password)
                        MudTextField'(){
                            Label "Password"
                            Value' binding
                            Immediate true
                            InputType InputType.Password
                        }
                        errorView errors
                    }
                    adaptiview(){
                        let! binding, errors = modelForm.UseFieldWithErrors(fun x -> x.Age)
                        MudTextField'(){
                            Label "Age"
                            Value' binding
                            Immediate true
                            InputType InputType.Number
                        }
                        errorView errors
                    }
                    adaptiview(){
                        let! (value', setValue), errors = modelForm.UseFieldWithErrors(fun x -> x.Birthday)
                        MudDatePicker'(){
                            Label "Birthday"
                            Date (Nullable value')
                            DateChanged (Option.ofNullable >> Option.iter setValue)
                            Error (not errors.IsEmpty)
                            ErrorText (simplifyErrors errors)
                        }
                    }
                ]
            }
            spaceV4
            adaptiview(){
                let! errors = modelForm.UseErrors()
                MudAlert'(){
                    Severity Severity.Info
                    childContent $"Total errors is {errors.Length}"
                }
            }
        ]
    }
