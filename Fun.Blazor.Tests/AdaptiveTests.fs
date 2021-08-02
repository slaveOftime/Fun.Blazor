module Fun.Blazor.Tests.AdaptiveTests

open FSharp.Data.Adaptive
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
let ``html adaptive tests`` () =
    let context = createTestContext()
    
    let store1 = cval 1
    let store2 = cval 1
    use store3 = new Store<_>(1)

    let comp = adaptiveComp {
        let! s3 = store3
        let! s1 = store1
        let! s2 = store2
        return html.text $"s1={s1};s2={s2};s3={s3}"
    }

    let result = context.RenderNode comp
    
    result.MarkupMatches("s1=1;s2=1;s3=1")

    store1.Publish 2
    result.MarkupMatches("s1=2;s2=1;s3=1")

    store2.Publish 4
    result.MarkupMatches("s1=2;s2=4;s3=1")

    transact (fun _ ->
        store1.Value <- 8
        store2.Value <- 9)
    result.MarkupMatches("s1=8;s2=9;s3=1")

    (store3 :> IStore<_>).Publish 10
    result.MarkupMatches("s1=8;s2=9;s3=10")
