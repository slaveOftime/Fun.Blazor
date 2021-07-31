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

    let comp = html.watch(store, sprintf "data=%d" >> html.text)
    let result = context.RenderNode comp
    
    result.MarkupMatches("data=1")

    (store :> IStore<_>).Publish 2
    result.MarkupMatches("data=2")


[<Fact>]
let ``html watch2 tests`` () =
    let context = createTestContext()
    
    use store1 = new Store<_>(1)
    use store2 = new Store<_>(1)

    let comp = html.watch2(store1, store2, fun s1 s2 -> html.text $"s1={s1};s2={s2}")
    let result = context.RenderNode comp
    
    result.MarkupMatches("s1=1;s2=1")

    (store1 :> IStore<_>).Publish 2
    result.MarkupMatches("s1=2;s2=1")

    (store2 :> IStore<_>).Publish 4
    result.MarkupMatches("s1=2;s2=4")

    (store1 :> IStore<_>).Publish 8
    (store2 :> IStore<_>).Publish 9
    result.MarkupMatches("s1=8;s2=9")



[<Fact>]
let ``html watch Option tests`` () =
    let context = createTestContext()
    
    use store = new Store<_>(None)

    let comp = html.watch(store, function Some s -> html.text $"s={s}" | None -> html.text "None")
    let result = context.RenderNode comp

    result.MarkupMatches "None"

    (store :> IStore<_>).Publish(Some 2)
    result.MarkupMatches "s=2"

