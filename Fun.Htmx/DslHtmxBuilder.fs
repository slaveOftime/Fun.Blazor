[<AutoOpen>]
module Fun.Htmx.DslHtmxBuilder

open System.Text
open Fun.Result
open Fun.Blazor
open Fun.Blazor.Operators


type DomAttrBuilder with

    [<CustomOperation "hxGet">]
    member inline _.hxGet([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> ("hx-get" => x)

    [<CustomOperation "hxPut">]
    member inline _.hxPut([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> ("hx-put" => x)

    [<CustomOperation "hxPost">]
    member inline _.hxPost([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> ("hx-post" => x)

    [<CustomOperation "hxDelete">]
    member inline _.hxDelete([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> ("hx-delete" => x)

    [<CustomOperation "hxPatch">]
    member inline _.hxPatch([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> ("hx-patch" => x)


    /// If you want the response to be loaded into a different element other than the one that made the request
    [<CustomOperation "hxTarget">]
    member inline _.hxTarget([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> ("hx-target" => x)


    /// By default, AJAX requests are triggered by the "natural" event of an element
    ///
    /// - input, textarea & select are triggered on the change event.
    /// - form is triggered on the submit event.
    /// - everything else is triggered by the click event.
    ///
    /// If you want different behavior you can use the hx-trigger attribute to specify which event will cause the request.
    [<CustomOperation "hxTrigger">]
    member inline _.hxTrigger([<InlineIfLambda>] render: AttrRenderFragment, x: TriggerBuilder) = render ==> ("hx-trigger" => x.ToString())

    /// By default, AJAX requests are triggered by the "natural" event of an element
    ///
    /// - input, textarea & select are triggered on the change event.
    /// - form is triggered on the submit event.
    /// - everything else is triggered by the click event.
    ///
    /// If you want different behavior you can use the hx-trigger attribute to specify which event will cause the request.
    [<CustomOperation "hxTrigger">]
    member inline _.hxTrigger
        (
            [<InlineIfLambda>] render: AttrRenderFragment,
            event: string,
            ?sse,
            ?once,
            ?filter,
            ?changed,
            ?delay,
            ?throttle,
            ?from,
            ?target,
            ?consume,
            ?queue,
            ?root,
            ?threshold
        )
        =
        let triggerStr =
            TriggerBuilder()
                .AddTrigger(
                    event,
                    sse = defaultArg sse false,
                    once = defaultArg once false,
                    filter = defaultArg filter "",
                    changed = defaultArg changed false,
                    delay = defaultArg delay 0,
                    throttle = defaultArg throttle 0,
                    from = defaultArg from "",
                    target = defaultArg target "",
                    consume = defaultArg consume false,
                    queue = defaultArg queue HxQueue.None,
                    root = defaultArg root "",
                    threshold = defaultArg threshold 0.
                )
                .ToString()

        render ==> ("hx-trigger" => triggerStr)


    [<CustomOperation "hxTriggerPolling">]
    member inline _.hxTriggerPolling([<InlineIfLambda>] render: AttrRenderFragment, time: int, ?filter: string) =
        let sb = new StringBuilder()
        sb.Append("every ").Append(time).Append("ms") |> ignore

        match filter with
        | Some (SafeString f) -> sb.Append(" [").Append(f).Append("]") |> ignore
        | _ -> ()

        render ==> ("hx-trigger" => sb.ToString())


    [<CustomOperation "hxSwap">]
    member inline _.hxSwap([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> ("hx-swap" => x)

    [<CustomOperation "hxSwap_innerHTML">]
    member inline _.hxSwap_innerHTML([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("hx-swap" => "innerHTML")

    [<CustomOperation "hxSwap_outerHTML">]
    member inline _.hxSwap_outerHTML([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("hx-swap" => "outerHTML")

    [<CustomOperation "hxSwap_afterbegin">]
    member inline _.hxSwap_afterbegin([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("hx-swap" => "afterbegin")

    [<CustomOperation "hxSwap_beforebegin">]
    member inline _.hxSwap_beforebegin([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("hx-swap" => "beforebegin")

    [<CustomOperation "hxSwap_beforeend">]
    member inline _.hxSwap_beforeend([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("hx-swap" => "beforeend")

    [<CustomOperation "hxSwap_afterend">]
    member inline _.hxSwap_afterend([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("hx-swap" => "afterend")

    [<CustomOperation "hxSwap_none">]
    member inline _.hxSwap_none([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("hx-swap" => "none")

    /// If you want to swap content from a response directly into the DOM by using the id attribute
    [<CustomOperation "hxSwap_oob">]
    member inline _.hxSwap_oob([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("hx-swap-oob" => if x then "true" else "false")


    /// Allows you to select the content you want swapped from a response
    [<CustomOperation "hxSelect">]
    member inline _.hxSelect([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> ("hx-select" => x)


    /// If you wish to include the values of other elements, you can use the hx-include attribute with a CSS selector of all the elements whose values you want to include in the request.
    [<CustomOperation "hxInclude">]
    member inline _.hxInclude([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> ("hx-include" => x)


    /// If you want the htmx-request class added to a different element, you can use the hx-indicator attribute with a CSS selector to do so.
    [<CustomOperation "hxIndicator">]
    member inline _.hxIndicator([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> ("hx-indicator" => x)


    /// Often you want to coordinate the requests between two elements. For example, you may want a request from one element to supersede the request of another element, or to wait until the other elements request has finished.
    [<CustomOperation "hxSync">]
    member inline _.hxSync([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> ("hx-sync" => x)


    /// The hx-vals attribute allows you to add to the parameters that will be submitted with an AJAX request.
    [<CustomOperation "hxVals">]
    member inline _.hxVals([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> ("hx-vals" => x)

    [<CustomOperation "hxValsJs">]
    member inline this.hxValsJs([<InlineIfLambda>] render: AttrRenderFragment, x: string) = this.hxVals (render, "js:" + x)


    /// Allows you to confirm an action using a simple javascript dialog
    [<CustomOperation "hxConfirm">]
    member inline _.hxConfirm([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> ("hx-confirm" => x)


    /// This attribute will convert all anchor tags and forms into AJAX requests that, by default, target the body of the page.
    [<CustomOperation "hxBoost">]
    member inline _.hxBoost([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("hx-boost" => if x then "true" else "false")


    /// If you want a given element to push its request URL into the browser navigation bar and add the current state of the page to the browser's history
    [<CustomOperation "hxPushUrl">]
    member inline _.hxPushUrl([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("hx-push-url" => if x then "true" else "false")


    /// For security, if you don't want a particular part of the DOM to allow for htmx functionality, you can place this on the enclosing element of that area.
    [<CustomOperation "hxDisable">]
    member inline _.hxDisable([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("hx-disable" => if x then "true" else "false")

    /// For security, if you don't want a particular part of the DOM to allow for htmx functionality, you can place this on the enclosing element of that area.
    [<CustomOperation "hxDataDisable">]
    member inline _.hxDataDisable([<InlineIfLambda>] render: AttrRenderFragment, x: bool) =
        render ==> ("data-hx-disable" => if x then "true" else "false")


    [<CustomOperation "hxWS">]
    member inline _.hxWS([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> ("hx-ws" => x)

    [<CustomOperation "hxWS_connect_ws">]
    member inline _.hxWS_connect_ws([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> ("hx-ws" => "connect:ws:" + x)

    [<CustomOperation "hxWS_connect_wss">]
    member inline _.hxWS_connect_wss([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> ("hx-ws" => "connect:wss:" + x)

    [<CustomOperation "hxWS_send">]
    member inline _.hxWS_send([<InlineIfLambda>] render: AttrRenderFragment, ?x: string) =
        let modifier =
            match x with
            | Some (SafeString x) -> ":" + x
            | _ -> ""

        render ==> ("hx-ws" => "send" + modifier)


    [<CustomOperation "hxSSE">]
    member inline _.hxSSE([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> ("hx-sse" => x)

    [<CustomOperation "hxSSE_connect">]
    member inline this.hxSSE_connect([<InlineIfLambda>] render: AttrRenderFragment, x: string) = this.hxSSE (render, "connect:" + x)

    [<CustomOperation "hxSSE_swap">]
    member inline this.hxSSE_swap([<InlineIfLambda>] render: AttrRenderFragment, x: string) = this.hxSSE (render, "swap:" + x)
