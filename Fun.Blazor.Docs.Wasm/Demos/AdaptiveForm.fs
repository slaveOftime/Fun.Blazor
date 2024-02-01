module Fun.Blazor.Docs.Wasm.Demos.AdaptiveForm

open System
open FSharp.Data.Adaptive
open MudBlazor // We are using this library for our doc site
open Fun.Blazor
open Fun.Blazor.Validators
open Fun.Blazor.Docs.Controls


type Model =
    {
        Name: string
        Password: string
        Age: int
        Birthday: DateTime
        Address: Address
    }

    static member DefaultValue = {
        Name = ""
        Password = ""
        Age = 0
        Birthday = DateTime.Now
        Address = { Zip = ""; Street = "" }
    }

and Address = { Zip: string; Street: string }

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
    | AddressError of AddressError

and AddressError = | ZipCodeCannotBeEmpty


[<AutoOpen>]
module Extensions =
    open Fun.Blazor.Operators
    open MudBlazor.DslInternals

    type MudFormComponentBuilder<'FunBlazorGeneric, 'T, 'U when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> with

        [<CustomOperation "Errors">]
        member inline _.Errors([<InlineIfLambda>] render: AttrRenderFragment, errors: _ seq) =
            render
            ==> MudFormComponent'() {
                Error(errors |> Seq.isEmpty |> not)
                ErrorText(errors |> Seq.map string |> String.concat ", ")
                asAttrRenderFragment
            }


// This is used to demo nest/sub form
let private addressForm (modelForm: AdaptiveForm<Address, AddressError>) =
    html.fragment [|
        adaptiview () {
            let! binding, errors = modelForm.UseFieldWithErrors(fun x -> x.Zip)
            MudTextField'() {
                Label "Zip code"
                Value' binding
                Immediate true
                Errors errors
            }
        }
        adaptiview () {
            let! binding = modelForm.UseField(fun x -> x.Street)
            MudTextField'() {
                Label "Street"
                Value' binding
                Immediate true
            }
        }
    |]


let entry =
    html.inject (fun (hook: IComponentHook) ->
        let modelForm =
            hook
                .UseAdaptiveForm<Model, ModelErrors>(Model.DefaultValue)
                .AddValidators(
                    (fun x -> x.Name),
                    false,
                    [
                        required (NameIsTooShort 0)
                        minLength 2 NameIsTooShort
                        maxLength 10 NameIsTooLong
                    ]
                )
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

        let addressModelForm =
            modelForm
                .GetSubForm((fun x -> x.Address), AddressError)
                .AddValidators((fun x -> x.Zip), true, [ required ZipCodeCannotBeEmpty ])

        MudPaper'() {
            Elevation 10
            style { padding 10 }
            childContent [
                MudForm'.create [
                    adaptiview () {
                        let! binding, errors = modelForm.UseFieldWithErrors(fun x -> x.Name)
                        MudTextField'() {
                            Label "Name"
                            Value' binding
                            Immediate true
                            Required true
                            Errors errors
                        }
                    }
                    adaptiview () {
                        let! binding, errors = modelForm.UseFieldWithErrors(fun x -> x.Password)
                        MudTextField'() {
                            Label "Password"
                            Value' binding
                            Immediate true
                            InputType InputType.Password
                            Required true
                            Errors errors
                        }
                    }
                    adaptiview () {
                        let! binding, errors = modelForm.UseFieldWithErrors(fun x -> x.Age)
                        MudTextField'() {
                            Label "Age"
                            Value' binding
                            Immediate true
                            InputType InputType.Number
                            Errors errors
                        }
                    }
                    adaptiview () {
                        let! (value', setValue), errors = modelForm.UseFieldWithErrors(fun x -> x.Birthday)
                        MudDatePicker'() {
                            Label "Birthday"
                            Date(Nullable value')
                            DateChanged(Option.ofNullable >> Option.iter setValue)
                            Errors errors
                        }
                    }
                    addressForm addressModelForm
                ]
                spaceV4
                adaptiview () {
                    let! errors = modelForm.UseErrors()
                    MudAlert'() {
                        Severity Severity.Info
                        $"Total errors is {errors.Length}"
                    }
                }
                spaceV4
                adaptiview () {
                    let! hasChanges = modelForm.UseHasChanges()
                    if hasChanges then
                        MudAlert'() {
                            Severity Severity.Info
                            "There are some changes"
                        }
                    MudButton'() {
                        OnClick(fun _ -> modelForm.SetValue(Model.DefaultValue))
                        "Reset"
                    }
                    MudButton'() {
                        OnClick(fun _ -> modelForm.UseFieldSetter (fun x -> x.Age) (24))
                        "Set age to 24"
                    }
                }
            ]
        }
    )
