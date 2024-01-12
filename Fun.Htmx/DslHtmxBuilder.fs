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
    let (<|>) (name: string) (oob: OOB option) =
        match oob with
        | Some OOB -> name + "-oob"
        | _ -> name


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


type hx =

#if !NET6_0
    /// Issues a request to get the blazor component and reader as static dom
    static member inline RequestBlazorSSR(compTy: System.Type, ?queries: (string * obj) seq, ?method: string) =
        let method = defaultArg method "get"
        let query = System.Web.HttpUtility.ParseQueryString("")
        queries |> Option.iter (Seq.iter (fun (k, v) -> query.Add(k, (if isNull v then "" else string v))))
        ("hx-" + method.ToLower()
         => $"/fun-blazor-server-side-render-components/{compTy.FullName}?{query.ToString()}")

    /// Issues a request to get the blazor component and reader as static dom
    static member inline RequestBlazorSSR<'T>(method: string, queryBuilder: QueryBuilder<'T>) =
        ("hx-" + method.ToLower()
         => $"/fun-blazor-server-side-render-components/{typeof<'T>.FullName}?{queryBuilder.ToString()}")

    /// Issues a request to get the blazor component and reader as static dom
    static member inline RequestBlazorSSR<'T>(queryBuilder: QueryBuilder<'T>) =
        ("hx-get"
         => $"/fun-blazor-server-side-render-components/{typeof<'T>.FullName}?{queryBuilder.ToString()}")

    /// Issues a get request to get the blazor component and reader as static dom
    static member inline GetComponent(compType: Type) = hx.RequestBlazorSSR(compType, method = HttpMethods.Get)

    /// Issues a get request to get the blazor component and reader as static dom
    static member inline GetComponent<'T>(queryBuilder: QueryBuilder<'T>) = hx.RequestBlazorSSR(HttpMethods.Get, queryBuilder)

    /// Issues a post request to get the blazor component and reader as static dom
    static member inline PostComponent(compType: Type) = hx.RequestBlazorSSR(compType, method = HttpMethods.Post)

    /// Issues a post request to get the blazor component and reader as static dom
    static member inline PostComponent<'T>(queryBuilder: QueryBuilder<'T>) = hx.RequestBlazorSSR(HttpMethods.Post, queryBuilder)


    /// Issues a request to get the blazor custom element as the return dom,
    /// and it will open a websocket for the component's interactivity
    static member RequestCustomElement(compTy: System.Type, ?queries: (string * obj) seq, ?method: string) =
        let method = defaultArg method "get"
        let query = System.Web.HttpUtility.ParseQueryString("")
        queries |> Option.iter (Seq.iter (fun (k, v) -> query.Add(k, (if isNull v then "" else string v))))
        ("hx-" + method.ToLower() => $"/fun-blazor-custom-elements/{compTy.FullName}?{query.ToString()}")

    /// Issues a request to get the blazor custom element as the return dom,
    /// and it will open a websocket for the component's interactivity
    static member inline RequestCustomElement<'T>(method: string, queryBuilder: QueryBuilder<'T>) =
        ("hx-" + method.ToLower()
         => $"/fun-blazor-custom-elements/{typeof<'T>.FullName}?{queryBuilder.ToString()}")

    /// Issues a request to get the blazor custom element as the return dom,
    /// and it will open a websocket for the component's interactivity
    static member inline RequestCustomElement<'T>(queryBuilder: QueryBuilder<'T>) =
        ("hx-get" => $"/fun-blazor-custom-elements/{typeof<'T>.FullName}?{queryBuilder.ToString()}")

    /// Issues a get request to get the blazor custom element as the return dom,
    /// and it will open a websocket for the component's interactivity
    static member inline GetCustomElement(compType: Type) = hx.RequestCustomElement(compType, method = HttpMethods.Get)

    /// Issues a get request to get the blazor custom element as the return dom,
    /// and it will open a websocket for the component's interactivity
    static member inline GetCustomElement<'T>(queryBuilder: QueryBuilder<'T>) = hx.RequestCustomElement(HttpMethods.Get, queryBuilder)

    /// Issues a post request to get the blazor custom element as the return dom,
    /// and it will open a websocket for the component's interactivity
    static member inline PostCustomElement(compType: Type) = hx.RequestCustomElement(compType, method = HttpMethods.Post)

    /// Issues a post request to get the blazor custom element as the return dom,
    /// and it will open a websocket for the component's interactivity
    static member inline PostCustomElement<'T>(queryBuilder: QueryBuilder<'T>) = hx.RequestCustomElement(HttpMethods.Post, queryBuilder)
#endif


    /// Issues a GET request to the given URL
    static member inline Get(x: string) = ("hx-get" => x)

    /// Issues a PUT request to the given URL
    static member inline Put(x: string) = ("hx-put" => x)

    /// Issues a POST request to the given URL
    static member inline Post(x: string) = ("hx-post" => x)

    /// Issues a DELETE request to the given URL
    static member inline Delete(x: string) = ("hx-delete" => x)

    /// Issues a PATCH request to the given URL
    static member inline Patch(x: string) = ("hx-patch" => x)


    /// If you want the response to be loaded into a different element other than the one that made the request
    static member inline Target(x: string) = ("hx-target" => x)

    /// Indicates that the element that the hx-target attribute is on is the target.
    static member inline Target_this() = ("hx-target" => "this")

    /// find the closest parent ancestor that matches the given CSS selector. (e.g. closest tr will target the closest table row to the element).
    static member inline Target_closest(x: string) = ("hx-target" => "closest " + x)

    /// Find the first child descendant element that matches the given CSS selector. (e.g find tr will target the first child descendant row to the element)
    static member inline Target_find(x: string) = ("hx-target" => "find " + x)


    /// By default, AJAX requests are triggered by the "natural" event of an element
    ///
    /// - input, textarea & select are triggered on the change event.
    /// - form is triggered on the submit event.
    /// - everything else is triggered by the click event.
    ///
    /// If you want different behavior you can use the hx-trigger attribute to specify which event will cause the request.
    static member inline Trigger(x: HxTrigger) = ("hx-trigger" => x.ToString())

    /// By default, AJAX requests are triggered by the "natural" event of an element
    ///
    /// - input, textarea & select are triggered on the change event.
    /// - form is triggered on the submit event.
    /// - everything else is triggered by the click event.
    ///
    /// If you want different behavior you can use the hx-trigger attribute to specify which event will cause the request.
    static member inline Trigger
        (
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


    /// If you want an element to poll the given URL rather than wait for an event, you can use the every syntax with the hx-trigger attribute.
    /// If you want to stop polling from a server response you can respond with the HTTP response code 286 and the element will cancel the polling.
    static member inline TriggerPolling(timeMs: int, ?filter: string) =
        let sb = new StringBuilder()
        sb.Append("every ").Append(timeMs).Append("ms") |> ignore

        match filter with
        | Some(SafeString f) -> sb.Append(" [").Append(f).Append("]") |> ignore
        | _ -> ()

        ("hx-trigger" => sb.ToString())

    /// The hx-swap attribute allows you to specify how the response will be swapped in relative to the target of an AJAX request.
    static member inline Swap(x: string, ?oob: OOB) = ("hx-swap" <|> oob => x)

    /// You can use it like: hxSwap (hxSwap_innerHTML'().Swap(100)). Or create HxSwapAndModifier by your self.
    /// The hx-swap attribute allows you to specify how the response will be swapped in relative to the target of an AJAX request.
    static member inline Swap(x: HxSwapAndModifier) = ("hx-swap" <|> x.OOB => x.ToString())

    /// The default, replace the inner html of the target element.
    /// The hx-swap attribute allows you to specify how the response will be swapped in relative to the target of an AJAX request.
    static member inline Swap_innerHTML(?oob: OOB) = HxSwapAndModifier("innerHTML", defaultArg oob NONE_OOB)

    /// Replace the entire target element with the response.
    /// The hx-swap attribute allows you to specify how the response will be swapped in relative to the target of an AJAX request.
    static member inline Swap_outerHTML(?oob: OOB) = HxSwapAndModifier("outerHTML", defaultArg oob NONE_OOB)

    /// Insert the response before the first child of the target element.
    /// The hx-swap attribute allows you to specify how the response will be swapped in relative to the target of an AJAX request.
    static member inline Swap_afterbegin(?oob: OOB) = HxSwapAndModifier("afterbegin", defaultArg oob NONE_OOB)

    /// Insert the response before the target element.
    /// The hx-swap attribute allows you to specify how the response will be swapped in relative to the target of an AJAX request.
    static member inline Swap_beforebegin(?oob: OOB) = HxSwapAndModifier("beforebegin", defaultArg oob NONE_OOB)

    /// Insert the response after the last child of the target element.
    /// The hx-swap attribute allows you to specify how the response will be swapped in relative to the target of an AJAX request.
    static member inline Swap_beforeend(?oob: OOB) = HxSwapAndModifier("beforeend", defaultArg oob NONE_OOB)

    /// Insert the response after the last child of the target element.
    /// The hx-swap attribute allows you to specify how the response will be swapped in relative to the target of an AJAX request.
    static member inline Swap_afterend(?oob: OOB) = HxSwapAndModifier("afterend", defaultArg oob NONE_OOB)

    /// Deletes the target element regardless of the response.
    /// The hx-swap attribute allows you to specify how the response will be swapped in relative to the target of an AJAX request.
    static member inline Swap_delete(?oob: OOB) = HxSwapAndModifier("delete", defaultArg oob NONE_OOB)

    /// Does not append content from response (out of band items will still be processed).
    /// The hx-swap attribute allows you to specify how the response will be swapped in relative to the target of an AJAX request.
    static member inline Swap_none(?oob: OOB) = HxSwapAndModifier("none", defaultArg oob NONE_OOB)


    /// Allows you to filter the parameters that will be submitted with an AJAX request.
    static member inline Params(x: string) =
        let ps =
            match x with
            | SafeString x -> x
            | _ -> "*"
        ("hx-params" => ps)

    /// Include no parameters
    static member inline Params_none() = ("hx-params" => "none")

    /// Include all except the comma separated list of parameter names
    static member inline Params_none(x: string) = ("hx-params" => "not " + x)


    /// Allows you to select the content you want swapped from a response
    static member inline Select(x: string) = ("hx-select" => x)


    /// If you wish to include the values of other elements, you can use the hx-include attribute with a CSS selector of all the elements whose values you want to include in the request.
    static member inline Include(x: string) = ("hx-include" => x)


    /// If you want the htmx-request class added to a different element, you can use the hx-indicator attribute with a CSS selector to do so.
    static member inline Indicator(x: string) = ("hx-indicator" => x)


    /// Often you want to coordinate the requests between two elements. For example, you may want a request from one element to supersede the request of another element, or to wait until the other elements request has finished.
    static member inline Sync(x: string) = ("hx-sync" => x)


    /// The hx-vals attribute allows you to add to the parameters that will be submitted with an AJAX request.
    static member inline Vals(x: string) = ("hx-vals" => x)

    static member inline ValsJs(x: string) = hx.Vals("js:" + x)


    /// Allows you to confirm an action using a simple javascript dialog
    static member inline Confirm(x: string) = ("hx-confirm" => x)


    /// This attribute will convert all anchor tags and forms into AJAX requests that, by default, target the body of the page.
    static member inline Boost(x: bool) = ("hx-boost" => if x then "true" else "false")

    /// Set the hx-history attribute to false on any element in the current document, or any html fragment loaded into the current document by htmx, to prevent sensitive data being saved to the localStorage cache when htmx takes a snapshot of the page state.
    /// History navigation will work as expected, but on restoration the URL will be requested from the server instead of the history cache.
    ///
    /// Note: hx-history="false" can be present anywhere in the document to embargo the current page state from the history cache (i.e. even outside the element specified for the history snapshot hx-history-elt).
    static member inline History(x: bool) = ("hx-history" => if x then "true" else "false")

    /// The hx-history-elt attribute allows you to specify the element that will be used to snapshot and restore page state during navigation. By default, the body tag is used. This is typically good enough for most setups, but you may want to narrow it down to a child element. Just make sure that the element is always visible in your application, or htmx will not be able to restore history navigation properly.
    ///
    /// Notes: hx-history-elt is not inherited, In most cases we don’t recommend narrowing the history snapshot
    static member inline HistoryElt() = ("hx-history-elt" =>>> true)


    /// If you want a given element to push its request URL into the browser navigation bar and add the current state of the page to the browser's history
    static member inline PushUrl(x: bool) = ("hx-push-url" => if x then "true" else "false")

    /// A URL to be pushed into the location bar. This may be relative or absolute, as per history.pushState()
    static member inline PushUrl(x: string) = ("hx-push-url" => x)

    /// For security, if you don't want a particular part of the DOM to allow for htmx functionality, you can place this on the enclosing element of that area.
    static member inline Disable(x: bool) = ("hx-disable" => if x then "true" else "false")

    /// The hx-disabled-elt attribute allows you to specify elements that will have the disabled attribute added to them for the duration of the request.
    ///
    /// The value of this attribute is a CSS query selector of the element or elements to apply the class to, or the keyword closest, followed by a CSS selector, which will find the closest ancestor element or itself, that matches the given CSS selector (e.g. closest tr), or the keyword this
    ///
    /// When a request is in flight, this will cause the button to be marked with the disabled attribute, which will prevent further clicks from occurring.
    static member inline DisableElt(x: string) = ("hx-disable-elt" => x)

    /// For security, if you don't want a particular part of the DOM to allow for htmx functionality, you can place this on the enclosing element of that area.
    static member inline DataDisable(x: bool) = ("data-hx-disable" => if x then "true" else "false")


    static member inline WS(x: string) = ("hx-ws" => x)

    static member inline WS_connect_ws(x: string) = ("hx-ws" => "connect:ws:" + x)

    static member inline WS_connect_wss(x: string) = ("hx-ws" => "connect:wss:" + x)

    static member inline WS_send(?x: string) =
        let modifier =
            match x with
            | Some(SafeString x) -> ":" + x
            | _ -> ""

        ("hx-ws" => "send" + modifier)


    static member inline SSE(x: string) = ("hx-sse" => x)

    static member inline SSE_connect(x: string) = hx.SSE("connect:" + x)

    static member inline SSE_swap(x: string) = hx.SSE("swap:" + x)


    /// The hx-on attribute allows you to embed scripts inline to respond to events directly on an element; similar to the onevent properties found in HTML, such as on.click.
    ///
    /// hx-on improves upon onevent by enabling the handling of any event for enhanced Locality of Behaviour (LoB). This also enables you to handle any htmx event.
    ///
    /// Notes: hx-on is not inherited, however due to event bubbling, hx-on attributes on parent elements will typically be triggered by events on child elements
    static member inline On(event: string, script: string) = ("hx-on:" + event => script)

    /// This enables you to handle any htmx event.
    ///
    /// The hx-on attribute allows you to embed scripts inline to respond to events directly on an element; similar to the onevent properties found in HTML, such as on.click.
    ///
    /// Notes: hx-on is not inherited, however due to event bubbling, hx-on attributes on parent elements will typically be triggered by events on child elements
    static member inline OnHtmx(event: string, script: string) = ("hx-on::" + event => script)


    /// This will use hx-on for configRequest event, and add or overwrite parameters with browser's current query parameters
    static member inline AddQueriesToHtmxParams(?overwrite: bool) =
        hx.OnHtmx(hxEvt.configRequest, NativeJs.AddQueriesToHtmxParams(overwrite = defaultArg overwrite false))
