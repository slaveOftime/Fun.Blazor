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
let ``yield key value attributes tests`` () =
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
                "onclick", (fun () -> count <- count + 1)
                $"count={count}"
            }
        )

    let result = context.RenderNode demo
    result.MarkupMatches("""<div style="color: red" width="10" height="100.1" hidden1="" >count=0</div>""")

    result.Find("div").Click()
    result.MarkupMatches("""<div style="color: red" width="10" height="100.1" hidden1="" >count=1</div>""")
