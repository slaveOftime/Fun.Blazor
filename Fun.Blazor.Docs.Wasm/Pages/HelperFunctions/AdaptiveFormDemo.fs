[<AutoOpen>]
module Fun.Blazor.Docs.Wasm.Pages.HelperFunctions.AdaptiveFormDemo

open System
open FSharp.Data.Adaptive
open MudBlazor
open Fun.Blazor
open Fun.Blazor.Validators
open Fun.Blazor.Docs.Wasm.Components


let private simplifyErrors es = es |> Seq.map string |> String.concat ", "

let private errorView es =
    if Seq.isEmpty es  then html.none
    else
        MudAlert'(){
            Severity Severity.Error
            childContent (simplifyErrors es)
        }


type Model = {
    Name: string
    Password: string
    Age: int
    Birthday: DateTime
} with
    static member DefaultValue = {
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
    | AgeCannotEqual of int
    | BirthdayIsTooEarly of DateTime
    | BirthdayIsTooOld of DateTime


let demo1 = html.inject <| fun (hook: IComponentHook) ->
    let modelForm = new AdaptiveForm<Model, ModelErrors>(Model.DefaultValue)
    
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
            spaceV4
            adaptiview(){
                let! hasChanges = modelForm.UseHasChanges()
                if hasChanges then
                    MudAlert'(){
                        Severity Severity.Info
                        childContent "There are some changes"
                    }
                MudButton'(){
                    OnClick (fun _ -> modelForm.SetValue(Model.DefaultValue))
                    childContent "Reset"
                }
                MudButton'(){
                    OnClick (fun _ -> modelForm.UseFieldSetter(fun x -> x.Age)(24))
                    childContent "Set age to 24"
                }
            }
        ]
    }


let anonymousRecordDemo = 
    html.inject (fun (hook: IComponentHook) ->
        let demoForm =
            hook
                .UseAdaptiveForm<_, _>({|
                    Name = ""
                    Age = 20
                |})
                .AddAalidators((fun x -> x.Name), true, [
                    minLength 2 NameIsTooShort
                ])
                .AddAalidators((fun x -> x.Age), true, [
                    minValue 18 AgeIsTooSmall
                    notEqual 20 AgeCannotEqual
                ])

        div(){
            childContent [
                adaptiview(){ // by this, one field's change will not trigger any calculation or rerender for other fields
                    let! binding, errors = demoForm.UseFieldWithErrors(fun x -> x.Name)
                    MudTextField'(){
                        Label "Name"
                        Value' binding
                    }
                    errorView errors
                }
                adaptiview(){ // by this, one field's change will not trigger any calculation or rerender for other fields
                    let! binding, errors = demoForm.UseFieldWithErrors(fun x -> x.Age)
                    MudTextField'(){
                        Label "Age"
                        Value' binding
                        InputType InputType.Number
                    }
                    errorView errors
                }
            ]
        }
    )


type ClassModel() =
    member val Name = "" with get, set
    member val Age = 0 with get, set

    static member DefaultValue =
        ClassModel(Name = "fun", Age = 20)


let demo3 = html.inject (fun (hook: IComponentHook) ->
    let demoForm =
        hook
            .UseAdaptiveForm<_, _>(ClassModel.DefaultValue)
            .AddAalidators((fun x -> x.Name), true, [
                minLength 2 NameIsTooShort
            ])
            .AddAalidators((fun x -> x.Age), true, [
                minValue 18 AgeIsTooSmall
                notEqual 20 AgeCannotEqual
            ])

    div(){
        childContent [
            adaptiview(){
                let! binding, errors = demoForm.UseFieldWithErrors(fun x -> x.Name)
                MudTextField'(){
                    Label "Name"
                    Value' binding
                }
                errorView errors
            }
            adaptiview(){
                let! binding, errors = demoForm.UseFieldWithErrors(fun x -> x.Age)
                MudTextField'(){
                    Label "Age"
                    Value' binding
                    InputType InputType.Number
                }
                errorView errors
            }
        ]
    }
)


let adaptiveFormDemo =
    div.create [
        demo1
        spaceV4
        anonymousRecordDemo
        spaceV4
        demo3
    ]