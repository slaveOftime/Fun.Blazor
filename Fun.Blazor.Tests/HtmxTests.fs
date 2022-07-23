module Fun.Blazor.Tests.HtmxTests

open Xunit
open Fun.Htmx
open Fun.Blazor
open Bunit


[<Fact>]
let ``TriggerBuilder should work`` () =
    let context = new TestContext()

    let result =
        context.RenderNode(
            fragment {
                div {
                    hxGet "/test"
                    hxTrigger (
                        TriggerBuilder()
                            .AddTrigger(
                                hxEvt.load,
                                sse = true,
                                filter = "ctlKey",
                                once = true,
                                changed = true,
                                delay = 100,
                                throttle = 200,
                                from = "#from",
                                target = "#target",
                                consume = true,
                                queue = HxQueue.First,
                                root = "#root",
                                threshold = 0.2
                            )
                    )
                }
                div {
                    hxTrigger hxEvt.revealed
                    hxSwap_beforebegin
                }
            }
        )

    result.MarkupMatches(
        """
        <div hx-get="/test" hx-trigger="sse:load[ctlKey] once changed delay:100ms throttle:200ms from:#from target:#target consume queue:first"></div>
        <div hx-trigger="revealed" hx-swap="beforebegin"></div>
        """
    )
