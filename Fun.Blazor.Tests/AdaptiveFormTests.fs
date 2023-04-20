module Fun.Blazor.Tests.AdaptiveFormTests

open Xunit
open Fun.Blazor

type DemoForm = { Name: string; Age: int }

[<Fact>]
let ``adaptive form state tests`` () =
    let data = { Name = "n1"; Age = 20 }
    use form = new AdaptiveForm<DemoForm, string>(data)

    form.UseFieldSetter (fun x -> x.Age) (21)
    Assert.Equal(21, form.GetFieldValue(fun x -> x.Age))
    Assert.Equal(true, form.UseHasChanges().Value)

    form.UseLoaderSetter (fun x -> x.Age) (true)
    Assert.Equal(true, form.UseLoaderValue(fun x -> x.Age).Value)
    Assert.Equal(false, form.UseLoaderValue(fun x -> x.Name).Value)
    Assert.Equal(true, form.UseIsLoading().Value)

    form.UseLoaderSetter (fun x -> x.Age) (false)
    Assert.Equal(false, form.UseIsLoading().Value)

    form.SetValue(data)
    Assert.Equal(data, form.GetValue())
    Assert.Equal(false, form.UseHasChanges().Value)


type BigForm = { Timeout: int; Demo: DemoForm }

[<Fact>]
let ``adaptive sub form state tests`` () =
    let data = { Timeout = 10; Demo = { Name = "n1"; Age = 20 } }
    use form = new AdaptiveForm<BigForm, string>(data)

    let subForm =
        form
            .GetSubForm(fun x -> x.Demo)
            .AddValidators((fun x -> x.Age), false, [ Validators.maxValue 20 (sprintf "age cannot be bigger than %d") ])


    Assert.Equal<string>([], form.GetErrors())

    subForm.UseFieldSetter (fun x -> x.Age) (21)
    Assert.Equal(21, subForm.GetFieldValue(fun x -> x.Age))
    Assert.Equal(true, subForm.UseHasChanges().Value)
    Assert.Equal<string>([ "age cannot be bigger than 20" ], form.GetErrors())


    Assert.Equal(false, form.UseIsLoading().Value)

    subForm.UseLoaderSetter (fun x -> x.Age) (true)
    Assert.Equal(true, form.UseIsLoading().Value)
    Assert.Equal(true, subForm.UseLoaderValue(fun x -> x.Age).Value)
    Assert.Equal(false, subForm.UseLoaderValue(fun x -> x.Name).Value)
    Assert.Equal(true, subForm.UseIsLoading().Value)


    subForm.UseLoaderSetter (fun x -> x.Age) (true)
    Assert.Equal(true, form.UseIsLoading().Value)


    Assert.Equal({ Timeout = 10; Demo = { Name = "n1"; Age = 21 } }, form.GetValue())

    form.SetValue(data)
    Assert.Equal(data, form.GetValue())
    Assert.Equal(data.Demo, subForm.GetValue())
    Assert.Equal(false, form.UseHasChanges().Value)
