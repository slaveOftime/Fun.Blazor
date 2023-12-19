[<AutoOpen>]
module Fun.Htmx.DslHtmxBuilder

open System
open System.Text
open Microsoft.AspNetCore.Http
open Fun.Result
open Fun.Blazor
open Fun.Blazor.Operators


[<AutoOpen>]
module Utils =
    let (<|>) (name: string) (oob: OOB option) = match oob with Some OOB -> name + "-oob" | _ -> name


type DomAttrBuilder with

    member inline _.Yield(x: HxTrigger) =
        AttrRenderFragment(fun _ builder index ->
            builder.AddAttribute(index, "hx-trigger", x.ToString())
            index + 1
        )

    member inline _.Yield(swap: HxSwapAndModifier) =
        AttrRenderFragment(fun _ builder index ->
            builder.AddAttribute(index, ("hx-swap" <|> swap.OOB), swap.ToString())
            index + 1
        )

#if !NET6_0
    /// Issues a request to get the blazor component and reader as static dom
    [<CustomOperation "hxRequestBlazorSSR">]
    member inline _.hxRequestBlazorSSR([<InlineIfLambda>] render: AttrRenderFragment, compTy: System.Type, ?queries: (string * obj) seq, ?method: string) =
        let method = defaultArg method "get"
        let query = System.Web.HttpUtility.ParseQueryString("")
        queries |> Option.iter (Seq.iter (fun (k, v) -> query.Add(k, if isNull v then "" else string v)))
        render ==> ("hx-" + method.ToLower() => $"/fun-blazor-server-side-render-components/{compTy.FullName}?{query.ToString()}")

    /// Issues a request to get the blazor component and reader as static dom
    [<CustomOperation "hxRequestBlazorSSR">]
    member inline _.hxRequestBlazorSSR<'T>([<InlineIfLambda>] render: AttrRenderFragment, method: string, queryBuilder: QueryBuilder<'T>) =
        render ==> ("hx-" + method.ToLower() => $"/fun-blazor-server-side-render-components/{typeof<'T>.FullName}?{queryBuilder.ToString()}")

    /// Issues a request to get the blazor component and reader as static dom
    [<CustomOperation "hxRequestBlazorSSR">]
    member inline _.hxRequestBlazorSSR<'T>([<InlineIfLambda>] render: AttrRenderFragment, queryBuilder: QueryBuilder<'T>) =
        render ==> ("hx-get" => $"/fun-blazor-server-side-render-components/{typeof<'T>.FullName}?{queryBuilder.ToString()}")

    /// Issues a get request to get the blazor component and reader as static dom
    [<CustomOperation "hxGetComponent">]
    member inline this.hxGetComponent([<InlineIfLambda>] render: AttrRenderFragment, compType: Type) =
        this.hxRequestBlazorSSR(render, compType, method = HttpMethods.Get)

    /// Issues a get request to get the blazor component and reader as static dom
    [<CustomOperation "hxGetComponent">]
    member inline this.hxGetComponent<'T>([<InlineIfLambda>] render: AttrRenderFragment, queryBuilder: QueryBuilder<'T>) =
        this.hxRequestBlazorSSR(render, HttpMethods.Get, queryBuilder)
    
    /// Issues a post request to get the blazor component and reader as static dom
    [<CustomOperation "hxPostComponent">]
    member inline this.hxPostComponent([<InlineIfLambda>] render: AttrRenderFragment, compType: Type) =
        this.hxRequestBlazorSSR(render, compType, method = HttpMethods.Post)

    /// Issues a post request to get the blazor component and reader as static dom
    [<CustomOperation "hxPostComponent">]
    member inline this.hxPostComponent<'T>([<InlineIfLambda>] render: AttrRenderFragment, queryBuilder: QueryBuilder<'T>) =
        this.hxRequestBlazorSSR(render, HttpMethods.Post, queryBuilder)


    /// Issues a request to get the blazor custom element as the return dom, 
    /// and it will open a websocket for the component's interactivity
    [<CustomOperation "hxRequestCustomElement">]
    member inline _.hxRequestCustomElement([<InlineIfLambda>] render: AttrRenderFragment, compTy: System.Type, ?queries: (string * obj) seq, ?method: string) =
        let method = defaultArg method "get"
        let query = System.Web.HttpUtility.ParseQueryString("")
        queries |> Option.iter (Seq.iter (fun (k, v) -> query.Add(k, if isNull v then "" else string v)))
        render ==> ("hx-" + method.ToLower() => $"/fun-blazor-custom-elements/{compTy.FullName}?{query.ToString()}")

    /// Issues a request to get the blazor custom element as the return dom, 
    /// and it will open a websocket for the component's interactivity
    [<CustomOperation "hxRequestCustomElement">]
    member inline _.hxRequestCustomElement<'T>([<InlineIfLambda>] render: AttrRenderFragment, method: string, queryBuilder: QueryBuilder<'T>) =
        render ==> ("hx-" + method.ToLower() => $"/fun-blazor-custom-elements/{typeof<'T>.FullName}?{queryBuilder.ToString()}")

    /// Issues a request to get the blazor custom element as the return dom, 
    /// and it will open a websocket for the component's interactivity
    [<CustomOperation "hxRequestCustomElement">]
    member inline _.hxRequestCustomElement<'T>([<InlineIfLambda>] render: AttrRenderFragment, queryBuilder: QueryBuilder<'T>) =
        render ==> ("hx-get" => $"/fun-blazor-custom-elements/{typeof<'T>.FullName}?{queryBuilder.ToString()}")
        
    /// Issues a get request to get the blazor custom element as the return dom, 
    /// and it will open a websocket for the component's interactivity
    [<CustomOperation "hxGetCustomElement">]
    member inline this.hxGetCustomElement([<InlineIfLambda>] render: AttrRenderFragment, compType: Type) =
        this.hxRequestCustomElement(render, compType, method = HttpMethods.Get)

    /// Issues a get request to get the blazor custom element as the return dom, 
    /// and it will open a websocket for the component's interactivity
    [<CustomOperation "hxGetCustomElement">]
    member inline this.hxGetCustomElement<'T>([<InlineIfLambda>] render: AttrRenderFragment, queryBuilder: QueryBuilder<'T>) =
        this.hxRequestCustomElement(render, HttpMethods.Get, queryBuilder)

    /// Issues a post request to get the blazor custom element as the return dom, 
    /// and it will open a websocket for the component's interactivity
    [<CustomOperation "hxPostCustomElement">]
    member inline this.hxPostCustomElement([<InlineIfLambda>] render: AttrRenderFragment, compType: Type) =
        this.hxRequestCustomElement(render, compType, method =  HttpMethods.Post)

    /// Issues a post request to get the blazor custom element as the return dom, 
    /// and it will open a websocket for the component's interactivity
    [<CustomOperation "hxPostCustomElement">]
    member inline this.hxPostCustomElement<'T>([<InlineIfLambda>] render: AttrRenderFragment, queryBuilder: QueryBuilder<'T>) =
        this.hxRequestCustomElement(render, HttpMethods.Post, queryBuilder)
#endif


    /// Issues a GET request to the given URL
    [<CustomOperation "hxGet">]
    member inline _.hxGet([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> ("hx-get" => x)

    /// Issues a PUT request to the given URL
    [<CustomOperation "hxPut">]
    member inline _.hxPut([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> ("hx-put" => x)

    /// Issues a POST request to the given URL
    [<CustomOperation "hxPost">]
    member inline _.hxPost([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> ("hx-post" => x)

    /// Issues a DELETE request to the given URL
    [<CustomOperation "hxDelete">]
    member inline _.hxDelete([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> ("hx-delete" => x)

    /// Issues a PATCH request to the given URL
    [<CustomOperation "hxPatch">]
    member inline _.hxPatch([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> ("hx-patch" => x)


    /// If you want the response to be loaded into a different element other than the one that made the request
    [<CustomOperation "hxTarget">]
    member inline _.hxTarget([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> ("hx-target" => x)

    /// Indicates that the element that the hx-target attribute is on is the target.
    [<CustomOperation "hxTarget_this">]
    member inline _.hxTarget_this([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("hx-target" => "this")

    /// find the closest parent ancestor that matches the given CSS selector. (e.g. closest tr will target the closest table row to the element).
    [<CustomOperation "hxTarget_closest">]
    member inline _.hxTarget_closest([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> ("hx-target" => "closest " + x)

    /// Find the first child descendant element that matches the given CSS selector. (e.g find tr will target the first child descendant row to the element)
    [<CustomOperation "hxTarget_find">]
    member inline _.hxTarget_find([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> ("hx-target" => "find " + x)


    /// By default, AJAX requests are triggered by the "natural" event of an element
    ///
    /// - input, textarea & select are triggered on the change event.
    /// - form is triggered on the submit event.
    /// - everything else is triggered by the click event.
    ///
    /// If you want different behavior you can use the hx-trigger attribute to specify which event will cause the request.
    [<CustomOperation "hxTrigger">]
    member inline _.hxTrigger([<InlineIfLambda>] render: AttrRenderFragment, x: HxTrigger) = render ==> ("hx-trigger" => x.ToString())

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
            ?delayMs,
            ?throttleMs,
            ?from,
            ?target,
            ?consume,
            ?queue,
            ?root,
            ?threshold
        )
        =
        let trigger =
            HxTrigger(
                event,
                sse = defaultArg sse false,
                once = defaultArg once false,
                filter = defaultArg filter "",
                changed = defaultArg changed false,
                delayMs = defaultArg delayMs 0,
                throttleMs = defaultArg throttleMs 0,
                from = defaultArg from "",
                target = defaultArg target "",
                consume = defaultArg consume false,
                queue = defaultArg queue HxQueue.None,
                root = defaultArg root "",
                threshold = defaultArg threshold 0.
            )

        render ==> ("hx-trigger" => trigger.ToString())


    /// If you want an element to poll the given URL rather than wait for an event, you can use the every syntax with the hx-trigger attribute.
    /// If you want to stop polling from a server response you can respond with the HTTP response code 286 and the element will cancel the polling.
    [<CustomOperation "hxTriggerPolling">]
    member inline _.hxTriggerPolling([<InlineIfLambda>] render: AttrRenderFragment, timeMs: int, ?filter: string) =
        let sb = new StringBuilder()
        sb.Append("every ").Append(timeMs).Append("ms") |> ignore

        match filter with
        | Some (SafeString f) -> sb.Append(" [").Append(f).Append("]") |> ignore
        | _ -> ()

        render ==> ("hx-trigger" => sb.ToString())

    /// The hx-swap attribute allows you to specify how the response will be swapped in relative to the target of an AJAX request.
    [<CustomOperation "hxSwap">]
    member inline _.hxSwap([<InlineIfLambda>] render: AttrRenderFragment, x: string, ?oob: OOB) = render ==> ("hx-swap" <|> oob => x)
    
    /// You can use it like: hxSwap (hxSwap_innerHTML'().Swap(100)). Or create HxSwapAndModifier by your self. 
    /// The hx-swap attribute allows you to specify how the response will be swapped in relative to the target of an AJAX request.
    [<CustomOperation "hxSwap">]
    member inline _.hxSwap([<InlineIfLambda>] render: AttrRenderFragment, x: HxSwapAndModifier) = render ==> ("hx-swap" <|> x.OOB => x.ToString())

    /// The default, replace the inner html of the target element. 
    /// The hx-swap attribute allows you to specify how the response will be swapped in relative to the target of an AJAX request.
    [<CustomOperation "hxSwap_innerHTML">]
    member inline _.hxSwap_innerHTML([<InlineIfLambda>] render: AttrRenderFragment, ?oob: OOB) = render ==> ("hx-swap" <|> oob => "innerHTML")

    /// Replace the entire target element with the response. 
    /// The hx-swap attribute allows you to specify how the response will be swapped in relative to the target of an AJAX request.
    [<CustomOperation "hxSwap_outerHTML">]
    member inline _.hxSwap_outerHTML([<InlineIfLambda>] render: AttrRenderFragment, ?oob: OOB) = render ==> ("hx-swap" <|> oob => "outerHTML")

    /// Insert the response before the first child of the target element. 
    /// The hx-swap attribute allows you to specify how the response will be swapped in relative to the target of an AJAX request.
    [<CustomOperation "hxSwap_afterbegin">]
    member inline _.hxSwap_afterbegin([<InlineIfLambda>] render: AttrRenderFragment, ?oob: OOB) = render ==> ("hx-swap" <|> oob => "afterbegin")

    /// Insert the response before the target element. 
    /// The hx-swap attribute allows you to specify how the response will be swapped in relative to the target of an AJAX request.
    [<CustomOperation "hxSwap_beforebegin">]
    member inline _.hxSwap_beforebegin([<InlineIfLambda>] render: AttrRenderFragment, ?oob: OOB) = render ==> ("hx-swap" <|> oob => "beforebegin")

    /// Insert the response after the last child of the target element. 
    /// The hx-swap attribute allows you to specify how the response will be swapped in relative to the target of an AJAX request.
    [<CustomOperation "hxSwap_beforeend">]
    member inline _.hxSwap_beforeend([<InlineIfLambda>] render: AttrRenderFragment, ?oob: OOB) = render ==> ("hx-swap" <|> oob => "beforeend")

    /// Insert the response after the last child of the target element. 
    /// The hx-swap attribute allows you to specify how the response will be swapped in relative to the target of an AJAX request.
    [<CustomOperation "hxSwap_afterend">]
    member inline _.hxSwap_afterend([<InlineIfLambda>] render: AttrRenderFragment, ?oob: OOB) = render ==> ("hx-swap" <|> oob => "afterend")

    /// Deletes the target element regardless of the response. 
    /// The hx-swap attribute allows you to specify how the response will be swapped in relative to the target of an AJAX request.
    [<CustomOperation "hxSwap_delete">]
    member inline _.hxSwap_delete([<InlineIfLambda>] render: AttrRenderFragment, ?oob: OOB) = render ==> ("hx-swap" <|> oob => "delete")

    /// Does not append content from response (out of band items will still be processed). 
    /// The hx-swap attribute allows you to specify how the response will be swapped in relative to the target of an AJAX request.
    [<CustomOperation "hxSwap_none">]
    member inline _.hxSwap_none([<InlineIfLambda>] render: AttrRenderFragment, ?oob: OOB) = render ==> ("hx-swap" <|> oob => "none")


    /// Allows you to filter the parameters that will be submitted with an AJAX request.
    [<CustomOperation "hxParams">]
    member inline _.hxParams([<InlineIfLambda>] render: AttrRenderFragment, x: string) =
        let ps =
            match x with
            | SafeString x -> x
            | _ -> "*"
        render ==> ("hx-params" => ps)

    /// Include no parameters
    [<CustomOperation "hxParams_none">]
    member inline _.hxParams_none([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("hx-params" => "none")

    /// Include all except the comma separated list of parameter names
    [<CustomOperation "hxParams_not">]
    member inline _.hxParams_none([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> ("hx-params" => "not " + x)


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

    /// Set the hx-history attribute to false on any element in the current document, or any html fragment loaded into the current document by htmx, to prevent sensitive data being saved to the localStorage cache when htmx takes a snapshot of the page state.
    /// History navigation will work as expected, but on restoration the URL will be requested from the server instead of the history cache.
    /// 
    /// Note: hx-history="false" can be present anywhere in the document to embargo the current page state from the history cache (i.e. even outside the element specified for the history snapshot hx-history-elt).
    [<CustomOperation "hxHistory">]
    member inline _.hxHistory([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("hx-history" => if x then "true" else "false")

    /// The hx-history-elt attribute allows you to specify the element that will be used to snapshot and restore page state during navigation. By default, the body tag is used. This is typically good enough for most setups, but you may want to narrow it down to a child element. Just make sure that the element is always visible in your application, or htmx will not be able to restore history navigation properly.
    /// 
    /// Notes: hx-history-elt is not inherited, In most cases we don’t recommend narrowing the history snapshot
    [<CustomOperation "hxHistoryElt">]
    member inline _.hxHistoryElt([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("hx-history-elt" =>>> true)


    /// If you want a given element to push its request URL into the browser navigation bar and add the current state of the page to the browser's history
    [<CustomOperation "hxPushUrl">]
    member inline _.hxPushUrl([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("hx-push-url" => if x then "true" else "false")

    /// A URL to be pushed into the location bar. This may be relative or absolute, as per history.pushState()
    [<CustomOperation "hxPushUrl">]
    member inline _.hxPushUrl([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> ("hx-push-url" => x)

    /// For security, if you don't want a particular part of the DOM to allow for htmx functionality, you can place this on the enclosing element of that area.
    [<CustomOperation "hxDisable">]
    member inline _.hxDisable([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("hx-disable" => if x then "true" else "false")

    /// The hx-disabled-elt attribute allows you to specify elements that will have the disabled attribute added to them for the duration of the request.
    /// 
    /// The value of this attribute is a CSS query selector of the element or elements to apply the class to, or the keyword closest, followed by a CSS selector, which will find the closest ancestor element or itself, that matches the given CSS selector (e.g. closest tr), or the keyword this
    ///
    /// When a request is in flight, this will cause the button to be marked with the disabled attribute, which will prevent further clicks from occurring.
    [<CustomOperation "hxDisableElt">]
    member inline _.hxDisableElt([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> ("hx-disable-elt" => x)

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


    /// The hx-on attribute allows you to embed scripts inline to respond to events directly on an element; similar to the onevent properties found in HTML, such as onClick.
    /// 
    /// hx-on improves upon onevent by enabling the handling of any event for enhanced Locality of Behaviour (LoB). This also enables you to handle any htmx event.
    ///
    /// Notes: hx-on is not inherited, however due to event bubbling, hx-on attributes on parent elements will typically be triggered by events on child elements
    [<CustomOperation "hxOn">]
    member inline _.hxOn([<InlineIfLambda>] render: AttrRenderFragment, event: string, script: string) = render ==> ("hx-on:" + event => script)

    /// This enables you to handle any htmx event.
    /// 
    /// The hx-on attribute allows you to embed scripts inline to respond to events directly on an element; similar to the onevent properties found in HTML, such as onClick.
    ///
    /// Notes: hx-on is not inherited, however due to event bubbling, hx-on attributes on parent elements will typically be triggered by events on child elements
    [<CustomOperation "hxOnHtmx">]
    member inline _.hxOnHtmx([<InlineIfLambda>] render: AttrRenderFragment, event: string, script: string) = render ==> ("hx-on::" + event => script)


    /// This will use hx-on for configRequest event, and add or overwrite parameters with browser's current query parameters
    [<CustomOperation "hxAddQueriesToHtmxParams">]
    member inline this.hxAddQueriesToHtmxParams([<InlineIfLambda>] render: AttrRenderFragment, ?overwrite: bool) = 
        this.hxOnHtmx(render, hxEvt.configRequest, Js.AddQueriesToHtmxParams(overwrite = defaultArg overwrite false))
