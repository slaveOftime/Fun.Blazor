module Fun.Blazor.Tests.DITests

open System.Threading.Tasks
open Microsoft.Extensions.DependencyInjection
open Xunit
open Bunit
open Fun.Blazor


type DemoService() =
    member val Count = 1 with get, set


let private createBunitContext () =
    let textContext = new BunitContext()

    textContext.Services.AddScoped<DemoService>() |> ignore

    textContext


[<Fact>]
let ``html adaptive tests`` () =
    let context = createBunitContext ()

    let consumer count =
        html.inject (fun (hook: IComponentHook) ->
            let demoService = hook.ScopedServiceProvider.GetService<DemoService>()

            hook.OnFirstAfterRender.Add(fun _ ->
                demoService.Count <- count
                hook.StateHasChanged()
            )

            div { demoService.Count }
        )

    let demo =
        html.scoped (
            true,
            fragment {
                consumer 1
                html.scoped (consumer 2)
            }
        )

    let result = context.RenderNode demo
    result.MarkupMatches("""<div>1</div><div>2</div>""")


[<Fact>]
let ``html inject async should work`` () = task {
    let context = createBunitContext ()

    let node =
        html.inject (fun () -> task {
            do! Task.Delay 500
            return div { "hi" }
        })

    let result = context.RenderNode node
    result.MarkupMatches("")
    do! Task.Delay 1000
    result.MarkupMatches("""<div>hi</div>""")
}
