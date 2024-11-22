[<AutoOpen>]
module rec Fun.Htmx.DslSse

#if NET8_0_OR_GREATER

open System
open Microsoft.AspNetCore.Http
open Microsoft.AspNetCore.Components
open FSharp.Control
open Fun.Blazor
open Fun.Blazor.Operators


type DomAttrBuilder with

    /// Install the extension on that HTML element
    [<CustomOperation "hxExtSSE">]
    member inline this.hxExtSSE([<InlineIfLambda>] render: AttrRenderFragment) = this.hxExt (render, "sse")

    /// Install the extension on that HTML element
    [<CustomOperation "hxSseConnect">]
    member inline this.hxSseConnect([<InlineIfLambda>] render: AttrRenderFragment, url: string) =
        render ==> this.hxExt (render, "sse") ==> ("sse-connect" => url)

    /// Add a new attribute sse-connect to the tag that specifies the URL of the Event Stream. This attribute will also include hx-ext="sse" for convineance.
    [<CustomOperation "hxSseConnect">]
    member inline this.hxSseConnect([<InlineIfLambda>] render: AttrRenderFragment, ty: Type) =
        render
        ==> this.hxExt (render, "sse")
        ==> ("sse-connect" => $"/fun-blazor-server-side-render-components/{ty.FullName}")

    /// Add a new attribute sse-connect to the tag that specifies the URL of the Event Stream. This attribute will also include hx-ext="sse" for convineance.
    [<CustomOperation "hxSseConnect">]
    member inline this.hxSseConnect<'T>([<InlineIfLambda>] render: AttrRenderFragment, queryBuilder: QueryBuilder<'T>) =
        render
        ==> this.hxExt (render, "sse")
        ==> ("sse-connect"
             => $"/fun-blazor-server-side-render-components/{typeof<'T>.FullName}?{queryBuilder.ToString()}")

    /// Add a new attribute sse-connect to the tag that specifies the URL of the Event Stream. This attribute will also include hx-ext="sse" for convineance.
    [<CustomOperation "hxSseConnectComp">]
    member inline this.hxSseConnectComp<'T when 'T :> HxSseComponent>([<InlineIfLambda>] render: AttrRenderFragment, queryBuilder: QueryBuilder<'T>) =
        render
        ==> this.hxExt (render, "sse")
        ==> ("sse-connect"
             => $"/fun-blazor-server-side-render-components/{typeof<'T>.FullName}?{queryBuilder.Add((fun x -> x.IsStreaming), true).ToString()}")

    /// Install the extension on that HTML element
    [<CustomOperation "hxSseSwap">]
    member inline _.hxSseSwap([<InlineIfLambda>] render: AttrRenderFragment, eventName: string) = render ==> ("sse-swap" => eventName)

    /// Swap based on the event of component which is inherited from SseComponentBase
    [<CustomOperation "hxSseSwapOnComp">]
    member inline _.hxSseSwapOnComp([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("sse-swap" => HxSseComponent.NewNodeEventName)

    /// To close the EventStream gracefully when that message is received. This might be helpful if you want to send information to a client that will eventually stop
    [<CustomOperation "hxSseClose">]
    member inline _.hxSseClose([<InlineIfLambda>] render: AttrRenderFragment, eventName: string) = render ==> ("sse-close" => eventName)

    /// Close SSE based on the event of component which is inherited from SseComponentBase
    [<CustomOperation "hxSseCloseOnComp">]
    member inline _.hxSseCloseOnComp([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("sse-close" => HxSseComponent.CloseSseEventName)

    /// Override the Tag property of component which is inheirt from SseComponentBase. when use it in: html.blazor<XXXComp>(domAttr { sseComponentTag "demo" })
    [<CustomOperation "hxSseCompTag">]
    member inline _.hxSseCompTag([<InlineIfLambda>] render: AttrRenderFragment, tag: string) = render ==> ("sse-comp-tag" => tag)


type html with

    /// <summary>
    /// Helper function to add a component which inherits from HxSseComponentBase, for streaming its content with server sent events. 
    /// You can use hxSseConnnectComp directly on your target element. This is just s helper function with some default setup.
    /// </summary>
    /// <param name="attrs">attributes of the container element</param>
    static member sse<'T when 'T :> HxSseComponent>(?tag: string, ?attrs: AttrRenderFragment, ?setCompAttrs) =
        let attrs = defaultArg attrs html.emptyAttr

        let query =
            QueryBuilder<'T>().Add((fun x -> x.IsStreaming), true).Remove(fun x -> x.Attributes)

        let query =
            match setCompAttrs with
            | None -> query
            | Some f -> f query

        EltBuilder(defaultArg tag "section") {
            attrs
            hxSseConnect $"/fun-blazor-server-side-render-components/{typeof<'T>.FullName}?{query.ToString()}"
            hxSseSwapOnComp
            hxSseCloseOnComp
            hxSwap_innerHTML
        }


[<AbstractClass>]
type HxSseComponent() as this =
    inherit FunComponent()

    // We use string here to avoid int to string converting when write to response body
    let mutable retry: string | null = null

    static member val NewNodeEventName = "NewNode"
    static member val CloseSseEventName = "CloseSse"

    /// The event ID to set the EventSource object's last event ID value.
    member val EventId: string | null = null with get, set

    /// Get last event id, so we can continue from the last event
    member _.LastEventId: string | null = 
        match this.Context.HttpContext.Request.Headers.TryGetValue("Last-Event-Id") with
        | true, value -> string value
        | _ -> null

    /// A string identifying the type of event described. By default is will be same as HxSseComponent.NewNodeEventName. 
    /// You can set it to different one, so by hxSseSwap, you can listen to the specific names for different domain logic. 
    member val EventName = HxSseComponent.NewNodeEventName with get, set

    /// The reconnection time (ms). If the connection to the server is lost, the browser will wait for the specified time before attempting to reconnect. Default is null.
    member _.Retry with set x = retry <- string x
    

    [<Inject>]
    member val Context: IHttpContextAccessor = Unchecked.defaultof<IHttpContextAccessor> with get, set

    [<Inject>]
    member val ServiceProvider = Unchecked.defaultof<IServiceProvider> with get, set

    [<Parameter>]
    member val IsStreaming = false with get, set


    abstract member Tag: string with get, set

    [<Parameter>]
    default val Tag = "section" with get, set


    abstract Attributes: AttrRenderFragment with get, set

    [<Parameter>]
    default val Attributes = html.emptyAttr with get, set


    abstract member GetNodes: unit -> TaskSeq<NodeRenderFragment>


    override _.OnInitializedAsync() = task {
        if this.IsStreaming then
            this.Context.HttpContext.Response.ContentType <- "text/event-stream"
            this.Context.HttpContext.Response.Headers.CacheControl <- "no-cache"
            this.Context.HttpContext.Response.Headers.Connection <- "keep-alive"

            try
                for node in this.GetNodes() do
                    if this.Context.HttpContext.RequestAborted.IsCancellationRequested then
                        raise (new OperationCanceledException())

                    let! nodeStr = html.renderAsString this.ServiceProvider node

                    match this.EventId with
                    | null -> ()
                    | id ->
                        do! this.Context.HttpContext.Response.WriteAsync("id: ")
                        do! this.Context.HttpContext.Response.WriteAsync(id)
                        do! this.Context.HttpContext.Response.WriteAsync("\n")

                    match retry with
                    | null ->  ()
                    | retry ->
                        do! this.Context.HttpContext.Response.WriteAsync("retry: ")
                        do! this.Context.HttpContext.Response.WriteAsync(retry)
                        do! this.Context.HttpContext.Response.WriteAsync("\n")

                    do! this.Context.HttpContext.Response.WriteAsync("event: ")
                    do! this.Context.HttpContext.Response.WriteAsync(this.EventName)
                    do! this.Context.HttpContext.Response.WriteAsync("\n")

                    let strs = nodeStr.Split('\r', '\n')
                    for str in strs do
                        if String.IsNullOrWhiteSpace str |> not then
                            do! this.Context.HttpContext.Response.WriteAsync("data: ")
                            do! this.Context.HttpContext.Response.WriteAsync(str)
                            do! this.Context.HttpContext.Response.WriteAsync("\n")

                    do! this.Context.HttpContext.Response.WriteAsync("\n")
                    do! this.Context.HttpContext.Response.Body.FlushAsync()

            with :? OperationCanceledException ->
                ()

            do! this.Context.HttpContext.Response.WriteAsync("event: ")
            do! this.Context.HttpContext.Response.WriteAsync(HxSseComponent.CloseSseEventName)
            do! this.Context.HttpContext.Response.WriteAsync("\n")
            do! this.Context.HttpContext.Response.WriteAsync("data: \n\n")
            do! this.Context.HttpContext.Response.Body.FlushAsync()
    }

    override _.Render() =
        if this.IsStreaming then
            html.none
        else
            let query =
                QueryBuilder<HxSseComponent>().Add(this).Add((fun x -> x.IsStreaming), true).Remove(fun x -> x.Attributes).ToString()

            EltBuilder this.Tag {
                this.Attributes
                hxSseConnect $"/fun-blazor-server-side-render-components/{this.GetType().FullName}?{query}"
                hxSseSwapOnComp
                hxSseCloseOnComp
                hxSwap_innerHTML
            }

#endif
