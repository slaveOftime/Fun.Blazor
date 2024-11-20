module Fun.Blazor.Tests.HtmxTests

open Xunit
open Fun.Htmx
open Fun.Blazor
open FSharp.Control
open Bunit
open Microsoft.AspNetCore.Components


[<Fact>]
let ``TriggerBuilder should work`` () =
    let context = new TestContext()

    let result =
        context.RenderNode(
            html.fragment [|
                div {
                    hxGet "/test"
                    hxTrigger (
                        HxTrigger(
                            hxEvt.load,
                            sse = true,
                            filter = "ctlKey",
                            once = true,
                            changed = true,
                            delayMs = 100,
                            throttleMs = 200,
                            from = "#from",
                            target = "#target",
                            consume = true,
                            queue = HxQueue.First,
                            root = "#root",
                            threshold = 0.2
                        )
                            .AddTrigger(hxEvt.mouse.click)
                    )
                }
                div {
                    hxTrigger'(hxEvt.mouse.dblclick, once = true)
                        .AddTrigger(hxEvt.mouse.click)
                        .AddTrigger(hxEvt.mouse.mousemove)
                        .AddTrigger(hxEvt.mouse.mouseover)
                    "TEST"
                }
                div {
                    hxTrigger hxEvt.revealed
                    hxSwap_beforebegin'().Swap(1).Settle(2).FocusScroll(true).ScrollTop("#target").ShowTop()
                }
                div {
                    hxPost "/test2"
                    hxTarget_find "#find"
                    hxSwap_afterend'(OOB).FocusScroll(true)
                }
                div { hxSwap_delete }
                div { hxSwap_delete OOB }
            |]
        )

    result.MarkupMatches(
        """
        <div hx-get="/test" hx-trigger="sse:load[ctlKey] once changed delay:100ms throttle:200ms from:#from target:#target consume queue:first, click"></div>
        <div hx-trigger="dblclick once, click, mousemove, mouseover">TEST</div>
        <div hx-trigger="revealed" hx-swap="beforebegin swap:1 settle:2 focus-scroll:true scroll:#target:top show:top"></div>
        <div hx-post="/test2" hx-target="find #find" hx-swap-oob="afterend focus-scroll:true"></div>
        <div hx-swap="delete"></div>
        <div hx-swap-oob="delete"></div>
        """
    )


type DemoComp() =
    inherit FunComponent()

    [<Parameter>]
    member val Count = 0 with get, set

    override _.Render() = html.none

type LiverCounter() as this =
    inherit HxSseComponent()

    [<Parameter>]
    member val Initial = 0 with get, set

    override _.GetNodes() = taskSeq {
        for count in this.Initial .. (this.Initial + 3) do
            div {
                "count="
                count
            }
            do! Async.Sleep 1000
    }


[<Fact>]
let ``hxRequestxxx should work`` () =
    let context = new TestContext()

    let result =
        context.RenderNode(
            fragment {
                div { hxRequestBlazorSSR (QueryBuilder<DemoComp>().Add((fun x -> x.Count), 1)) }
                div { hxRequestBlazorSSR "post" (QueryBuilder<DemoComp>().Add((fun x -> x.Count), 2)) }
                div { hxRequestBlazorSSR typeof<DemoComp> [ "Count", box 3 ] }
                div { hxRequestBlazorSSR typeof<DemoComp> [ "Count", box 4 ] "post" }
                div { hxRequestCustomElement (QueryBuilder<DemoComp>().Add((fun x -> x.Count), 1)) }
                div { hxRequestCustomElement "post" (QueryBuilder<DemoComp>().Add((fun x -> x.Count), 2)) }
                div { hxRequestCustomElement typeof<DemoComp> [ "Count", box 3 ] }
                div { hxRequestCustomElement typeof<DemoComp> [ "Count", box 4 ] "post" }
                div {
                    hxRequestCustomElement (QueryBuilder<DemoComp>().Add((fun x -> x.Count), 2).Add((fun x -> x.Count), 3).Add(DemoComp(Count = 4)))
                }
                div {
                    hxRequestCustomElement (QueryBuilder<DemoComp>().Add((fun x -> x.Count), 2).Add((fun x -> x.Count), 3, append = true))
                    html.createHiddenInputs (DemoComp(Count = 1))
                }
                div {
                    hxSseConnectComp (QueryBuilder<LiverCounter>())
                    hxSseSwapOnComp
                    hxSseCloseOnComp
                }
                html.sse<LiverCounter> (
                    tag = "section",
                    attrs = domAttr { hxSwap_beforeend },
                    setCompAttrs = (fun builder -> builder.Add((fun x -> x.Initial), 10))
                )
            }
        )

    result.MarkupMatches(
        """
        <div hx-get="/fun-blazor-server-side-render-components/Fun.Blazor.Tests.HtmxTests+DemoComp?Count=1"></div>
        <div hx-post="/fun-blazor-server-side-render-components/Fun.Blazor.Tests.HtmxTests+DemoComp?Count=2"></div>
        <div hx-get="/fun-blazor-server-side-render-components/Fun.Blazor.Tests.HtmxTests+DemoComp?Count=3"></div>
        <div hx-post="/fun-blazor-server-side-render-components/Fun.Blazor.Tests.HtmxTests+DemoComp?Count=4"></div>
        <div hx-get="/fun-blazor-custom-elements/Fun.Blazor.Tests.HtmxTests+DemoComp?Count=1"></div>
        <div hx-post="/fun-blazor-custom-elements/Fun.Blazor.Tests.HtmxTests+DemoComp?Count=2"></div>
        <div hx-get="/fun-blazor-custom-elements/Fun.Blazor.Tests.HtmxTests+DemoComp?Count=3"></div>
        <div hx-post="/fun-blazor-custom-elements/Fun.Blazor.Tests.HtmxTests+DemoComp?Count=4"></div>
        <div hx-get="/fun-blazor-custom-elements/Fun.Blazor.Tests.HtmxTests+DemoComp?Count=4"></div>
        <div hx-get="/fun-blazor-custom-elements/Fun.Blazor.Tests.HtmxTests+DemoComp?Count=2&amp;Count=3">
            <input type="hidden" name="Count" value="1">
        </div>
        <div hx-ext="sse" sse-connect="/fun-blazor-server-side-render-components/Fun.Blazor.Tests.HtmxTests+LiverCounter?IsStreaming=True" sse-swap="NewNode" sse-close="CloseSse"></div>
        <section hx-swap="beforeend" hx-ext="sse" sse-connect="/fun-blazor-server-side-render-components/Fun.Blazor.Tests.HtmxTests+LiverCounter?IsStreaming=True&amp;Initial=10" sse-swap="NewNode" sse-close="CloseSse"></section>
        """
    )
