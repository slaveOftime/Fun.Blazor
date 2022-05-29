module Fun.Blazor.Tests.DomTests

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


[<Fact>]
let ``Yield key value attributes`` () =
    let context = createTestContext ()

    let demo =
        html.comp (fun (hook: IComponentHook) ->
            hook.SetDisableEventTriggerStateHasChanged false

            let mutable count = 0

            div {
                "style", "color: red"
                "width", 10
                "height", 100.1
                "hidden1", true
                "hidden2", false
                "onclick", (fun () -> task { count <- count + 1 })
                "onchange", (fun () -> count <- count + 1)
                $"count={count}"
            }
        )

    task {
        let result = context.RenderNode demo
        result.MarkupMatches("""<div style="color: red" width="10" height="100.1" hidden1="" >count=0</div>""")

        do! result.Find("div").ClickAsync(null)
        result.MarkupMatches("""<div style="color: red" width="10" height="100.1" hidden1="" >count=1</div>""")

        result.Find("div").Change(null)
        result.MarkupMatches("""<div style="color: red" width="10" height="100.1" hidden1="" >count=2</div>""")
    }


[<Fact>]
let ``DOM events simple`` () =
    let context = createTestContext ()

    let demo =
        html.comp (fun (hook: IComponentHook) ->
            hook.SetDisableEventTriggerStateHasChanged false

            let mutable count = 0

            div {
                onclick (fun _ -> task { count <- count + 1 })
                onchange (fun _ -> count <- count + 1)
                $"count={count}"
            }
        )

    task {
        let result = context.RenderNode demo
        result.MarkupMatches("""<div>count=0</div>""")

        do! result.Find("div").ClickAsync(null)
        result.MarkupMatches("""<div>count=1</div>""")

        do! result.Find("div").ChangeAsync(null)
        result.MarkupMatches("""<div>count=2</div>""")

        result.Find("div").Change(null)
        result.MarkupMatches("""<div>count=3</div>""")
    }
