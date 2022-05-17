module Fun.Blazor.Tests.HookServiceTests

#nowarn "0020"

open FSharp.Data.Adaptive
open Microsoft.Extensions.DependencyInjection
open Moq
open Xunit
open Bunit
open Fun.Blazor


type IDemoHookService =
    abstract DemoData: cval<string>
    abstract InitDemoData: unit -> unit


type DemoHookService(hook: IComponentHook) as this =

    interface IDemoHookService with
        member _.DemoData =
            hook.ServiceProvider.GetService<IShareStore>().CreateCVal("DemoData", "")

        member _.InitDemoData() = hook.OnFirstAfterRender.Add(fun () -> (this :> IDemoHookService).DemoData.Publish "xxx")


[<Fact>]
let ``should be able to test hook service`` () =
    let moq = Mock<IDemoHookService>()
    moq.Setup(fun x -> x.InitDemoData())
    moq.SetupGet(fun x -> x.DemoData).Returns(cval "from test")

    let context = new TestContext()
    context.Services.AddHookService(fun _ -> moq.Object)

    let comp =
        html.inject (fun (hook: IComponentHook) ->
            let demoHook = hook.GetHookService<IDemoHookService>()
            demoHook.InitDemoData()
            adaptiview () {
                let! result = demoHook.DemoData
                html.text result
            }
        )

    let result = context.RenderNode comp
    result.MarkupMatches("from test")

    moq.Verify((fun x -> x.InitDemoData()), Times.Exactly 1)
    moq.VerifyGet((fun x -> x.DemoData), Times.Exactly 1)
