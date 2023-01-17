module Fun.Blazor.Tests.AdaptiveFormTests

open Xunit
open Fun.Blazor

type DemoForm = { Name: string; Age: int }    

[<Fact>]
let ``adaptive form state tests`` () =
    let data = { Name = "n1"; Age = 20 }
    use form = new AdaptiveForm<DemoForm, string>(data)
    
    form.UseFieldSetter(fun x -> x.Age)(21)
    Assert.Equal(21, form.GetFieldValue(fun x -> x.Age))
    Assert.Equal(true, form.UseHasChanges().Value)

    form.SetValue(data)
    Assert.Equal(data, form.GetValue())
    Assert.Equal(false, form.UseHasChanges().Value)
    