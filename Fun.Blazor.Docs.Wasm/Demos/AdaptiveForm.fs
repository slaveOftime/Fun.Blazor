module Fun.Blazor.Docs.Wasm.Demos.AdaptiveForm

open System
open FSharp.Data.Adaptive
open MudBlazor
open Fun.Blazor
open Fun.Blazor.Validators
open Fun.Blazor.Docs.Controls
open Fun.Blazor.Docs.Wasm


type Model =
    {
        Name: string
        Password: string
        Age: int
        Birthday: DateTime
    }

    static member DefaultValue =
        {
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


let private simplifyErrors es = es |> Seq.map string |> String.concat ", "


let entry =
    html.inject (fun (hook: IComponentHook) ->
        let modelForm =
            hook
                .UseAdaptiveForm<Model, ModelErrors>(Model.DefaultValue)
                .AddValidators((fun x -> x.Name), false, [ minLength 2 NameIsTooShort; maxLength 10 NameIsTooLong ])
                .AddValidators(
                    (fun x -> x.Password),
                    true,
                    [
                        required PasswordIsRequired
                        maxLength 15 PasswordIsTooLong
                        notEqual "123456" PasswordCannotBe
                        fun ctx value ->
                            let name = ctx.GetFieldValue(fun x -> x.Name)
                            if name = value then [ PasswordCannotEqualName ] else []
                    ]
                )
                .AddValidators((fun x -> x.Age), false, [ minValue 18 AgeIsTooSmall ])
                .AddValidators(
                    (fun x -> x.Birthday),
                    true,
                    [
                        minValue (DateTime.Parse("2000/1/1")) BirthdayIsTooOld
                        maxValue (DateTime.Now.AddDays(1.)) BirthdayIsTooEarly
                    ]
                )

        MudPaper'() {
            Elevation 10
            style { padding 10 }
            childContent [
                MudForm'.create [
                    adaptiview () {
                        let! binding, errors = modelForm.UseFieldWithErrors(fun x -> x.Name)
                        MudTextField'() {
                            key errors
                            Label "Name"
                            Value' binding
                            Error(not errors.IsEmpty)
                            ErrorText(simplifyErrors errors)
                            Immediate true
                        }
                    }
                    adaptiview () {
                        let! binding, errors = modelForm.UseFieldWithErrors(fun x -> x.Password)
                        MudTextField'() {
                            key errors
                            Label "Password"
                            Value' binding
                            Immediate true
                            InputType InputType.Password
                            Error(not errors.IsEmpty)
                            ErrorText(simplifyErrors errors)
                        }
                    }
                    adaptiview () {
                        let! binding, errors = modelForm.UseFieldWithErrors(fun x -> x.Age)
                        MudTextField'() {
                            key errors
                            Label "Age"
                            Value' binding
                            Immediate true
                            InputType InputType.Number
                            Error(not errors.IsEmpty)
                            ErrorText(simplifyErrors errors)
                        }
                    }
                    adaptiview () {
                        let! (value', setValue), errors = modelForm.UseFieldWithErrors(fun x -> x.Birthday)
                        MudDatePicker'() {
                            Label "Birthday"
                            Date(Nullable value')
                            DateChanged(Option.ofNullable >> Option.iter setValue)
                            Error(not errors.IsEmpty)
                            ErrorText(simplifyErrors errors)
                        }
                    }
                ]
                spaceV4
                adaptiview () {
                    let! errors = modelForm.UseErrors()
                    MudAlert'() {
                        Severity Severity.Info
                        childContent $"Total errors is {errors.Length}"
                    }
                }
                spaceV4
                adaptiview () {
                    let! hasChanges = modelForm.UseHasChanges()
                    if hasChanges then
                        MudAlert'() {
                            Severity Severity.Info
                            childContent "There are some changes"
                        }
                    MudButton'() {
                        OnClick(fun _ -> modelForm.SetValue(Model.DefaultValue))
                        childContent "Reset"
                    }
                    MudButton'() {
                        OnClick(fun _ -> modelForm.UseFieldSetter (fun x -> x.Age) (24))
                        childContent "Set age to 24"
                    }
                }
            ]
        }
    )
