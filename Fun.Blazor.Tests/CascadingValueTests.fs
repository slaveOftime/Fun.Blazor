module Fun.Blazor.Tests.CascadingValueTests

open Microsoft.AspNetCore.Components
open Microsoft.AspNetCore.Components.Routing
open Microsoft.Extensions.DependencyInjection
open Moq
open Xunit
open Bunit
open Fun.Blazor


let private createTestContext () =
    let textContext = new TestContext()

    textContext.Services.AddScoped<INavigationInterception>(fun _ -> Mock.Of<INavigationInterception>())
    |> ignore

    textContext


type DemoConsumer() =
    inherit FunBlazorComponent()

    [<CascadingParameter(Name = "test")>]
    member val Test = 0 with get, set

    override this.Render() = div { $"{this.Test}" }

type DemoConsumer'() =
    inherit ComponentBuilder<DemoConsumer>()


[<Fact>]
let ``Consume cascading value correctly`` () =
    let context = createTestContext ()

    let demo =
        CascadingValue'() {
            Name "test"
            Value 1
            CascadingValue'() {
                Name "test"
                Value 2
                DemoConsumer'.create ()
            }
        }

    let result = context.RenderNode demo
    result.MarkupMatches("""<div>2</div>""")
