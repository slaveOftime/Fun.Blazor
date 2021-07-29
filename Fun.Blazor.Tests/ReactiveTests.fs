module Fun.Blazor.Tests.ReactiveTests

open Microsoft.AspNetCore.Components.Routing
open Microsoft.Extensions.DependencyInjection
open Moq
open Xunit
open Bunit
open Fun.Blazor


let private createTestContext () =
    let textContext = new TestContext()
    
    textContext.Services
        .AddScoped<INavigationInterception>(fun _ -> Mock.Of<INavigationInterception>())
        |> ignore

    textContext


[<Fact>]
let ``html watch tests`` () =
    let context = createTestContext()
    
    use store = new Store<_>(1)

    let comp1 = html.watch(store, sprintf "data=%d" >> html.text)

    let result1 = context.RenderNode comp1
    result1.MarkupMatches("data=1")
