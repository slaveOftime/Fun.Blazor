﻿namespace Microsoft.Extensions.DependencyInjection

open System
open System.IO
open System.Collections.Generic
open System.Threading.Tasks
open System.Text.Encodings.Web
open System.Reflection
open System.Runtime.CompilerServices
open Microsoft.Net.Http.Headers
open Microsoft.AspNetCore.Http
open Microsoft.AspNetCore.Builder
open Microsoft.AspNetCore.Routing
open Microsoft.AspNetCore.Mvc.Rendering
open Microsoft.AspNetCore.Antiforgery
open Microsoft.AspNetCore.Components
#if !NET6_0
open Microsoft.AspNetCore.Http.HttpResults
open Microsoft.AspNetCore.Components.Endpoints
#endif
open Microsoft.AspNetCore.Mvc.ViewFeatures
open Microsoft.Extensions.DependencyInjection
open Fun.Result
open Fun.Blazor
open Fun.Blazor.Operators


#if !NET6_0
type FunBlazorEndpointFilter(preventStreamingRendering: bool, statusCode: int) =
    interface IEndpointFilter with
        member _.InvokeAsync(ctx, next) =
            task {
                match! next.Invoke(ctx) with
                | :? NodeRenderFragment as node ->
                    let result =
                        RazorComponentResult<FunFragmentComponent>(dict [ "Fragment", box node ])
                    result.PreventStreamingRendering <- preventStreamingRendering
                    result.StatusCode <- statusCode
                    return result :> obj
                | x -> return x
            }
            |> ValueTask<obj>
#endif

module internal Utils =
    let mutable isRazorComponentsForSSRMapped = false
    let razorComponentsForSSRTypes =
        lazy
            (System.Collections.Generic.Dictionary<string, {|
                Type: Type
                CreateAttr: HttpContext -> AttrRenderFragment
            |}>
                ())

    let mutable isFunBlazorCustomElementsForSSRMapped = false
    let funBlazorCustomElementsForSSRTypes =
        lazy
            (System.Collections.Generic.Dictionary<string, {|
                Type: Type
                CreateAttr: HttpContext -> AttrRenderFragment
            |}>
                ())

#if !NET6_0
type internal RequiresAntiforgeryMetadata(?requires) =
    interface IAntiforgeryMetadata with
        member _.RequiresValidation = defaultArg requires true
#endif


[<Extension>]
type FunBlazorServerExtensions =

    [<Extension>]
    static member AddFunBlazorServer(this: IServiceCollection) =
        this
            .AddHttpContextAccessor()
            .AddScoped<IShareStore, ShareStore>()
            .AddScoped<IScopedCssRules, ScopedCssRules>()
            .AddSingleton<IGlobalStore, GlobalStore>()


#if !NET6_0
    static member internal MapRenderMode(renderMode) =
        match renderMode with
        | RenderMode.Static -> null :> IComponentRenderMode
        | RenderMode.Server -> Web.InteractiveServerRenderMode(prerender = false)
        | RenderMode.ServerPrerendered -> Web.InteractiveServerRenderMode(prerender = true)
        | RenderMode.WebAssembly -> Web.InteractiveWebAssemblyRenderMode(prerender = false)
        | RenderMode.WebAssemblyPrerendered -> Web.InteractiveWebAssemblyRenderMode(prerender = true)
        | _ -> failwith $"Unsupported render mode {renderMode}"
#endif


    static member internal MakeRequestDelegate<'Services>(render: 'Services -> Task<NodeRenderFragment>, ?renderMode) =
        let renderMode = defaultArg renderMode RenderMode.Static
        RequestDelegate(fun ctx -> task {
            let! node = render (ctx.RequestServices.GetMultipleServices<'Services>())
            do! ctx.WriteFunDom(node, renderMode)
        })


    /// Render razor component to a TextWriter
    [<Extension>]
    static member internal RenderFragment
        (
            ctx: HttpContext,
            componentType: Type,
            targetStream: TextWriter,
            ?parameters: IDictionary<string, obj>,
            ?renderMode
        )
        : Task
        =
        task {
            let renderMode = defaultArg renderMode RenderMode.Static
            let parameters = defaultArg parameters null

            let htmlHelper = ctx.RequestServices.GetService<IHtmlHelper>()
            let viewContext = ViewContext(HttpContext = ctx)

            (htmlHelper :?> IViewContextAware).Contextualize(viewContext)

#if !NET6_0
            let componentPrerenderer = ctx.RequestServices.GetService<IComponentPrerenderer>()
            let renderMode = FunBlazorServerExtensions.MapRenderMode renderMode
            let parameters =
                match parameters with
                | null -> ParameterView.Empty
                | x -> ParameterView.FromDictionary x
            let! result = componentPrerenderer.PrerenderComponentAsync(ctx, componentType, renderMode, parameters)
            do! result.WriteToAsync(targetStream)

#else
            let! result = htmlHelper.RenderComponentAsync(componentType, renderMode, parameters)
            result.WriteTo(targetStream, HtmlEncoder.Default)
#endif
        }


    /// Render razor component to string
    [<Extension>]
    static member RenderFragment(ctx: HttpContext, ty: Type, ?renderMode: RenderMode, ?parameters: IDictionary<string, obj>) = task {
        let parameters = defaultArg parameters null
        use stream = new StringWriter()
        do! ctx.RenderFragment(ty, stream, parameters, defaultArg renderMode RenderMode.Static)
        do! stream.FlushAsync()
        return stream.ToString()
    }


    /// Build DOM string and write to response
    [<Extension>]
    static member WriteFunDom(ctx: HttpContext, node: NodeRenderFragment, ?renderMode) : Task = task {
        let renderMode = defaultArg renderMode RenderMode.Static
        let parameters = dict [ "Fragment", box node ]
        let componentType = typeof<FunFragmentComponent>

        use stream = new StreamWriter(ctx.Response.BodyWriter.AsStream(true))

        ctx.Response.ContentType <- "text/html; charset=UTF-8"
        do! ctx.RenderFragment(componentType, stream, parameters, renderMode)
    }


#if !NET6_0
    /// So we can handle NodeRenderFragment which returned from pipeline result
    [<Extension>]
    static member AddFunBlazor<'TBuilder when 'TBuilder :> IEndpointConventionBuilder>
        (
            builder: 'TBuilder,
            ?preventStreamingRendering: bool,
            ?statusCode: int
        )
        =
        builder.AddEndpointFilter(FunBlazorEndpointFilter(defaultArg preventStreamingRendering false, defaultArg statusCode 200))
#endif

    static member private MakeCreateAttrFn(ty: Type, ?forCustomElement) =
        let forCustomElement = defaultArg forCustomElement false

        let componentResponseCache =
            ty.GetCustomAttribute<ComponentResponseCacheAttribute>()

        let paramsInfo =
            ty.GetProperties(BindingFlags.Instance ||| BindingFlags.Public)
            |> Seq.choose (fun p ->
                let attr = p.GetCustomAttribute<ParameterAttribute>()
                if isNull attr then
                    None
                else
                    if forCustomElement && p.Name <> "FunBlazorDebugKey" && (p.Name |> Seq.exists Char.IsUpper) then
                        failwith
                            $"Parameter name ({p.Name}) for custom element component {ty.FullName} must be lowercase name with low dash for multiple words, like xxx or xxx_xxx"
                    Some(p.Name, p.PropertyType)
            )
            |> Map.ofSeq

        let parseValue (name: string) (v: string) (ty: Type) =
            if ty = typeof<string> then
                box v
            else if ty.Name.StartsWith("Nullable`") && String.IsNullOrEmpty v then
                box null
            else
                let ty = if ty.Name.StartsWith("Nullable`") then ty.GetGenericArguments()[0] else ty
                ty.GetMethods(BindingFlags.Public ||| BindingFlags.Static)
                |> Seq.tryFind (fun x ->
                    let ps = x.GetParameters()
                    x.Name = "Parse" && ps.Length = 1 && ps[0].ParameterType = typeof<string>
                )
                |> function
                    | Some x -> x.Invoke(null, [| v |])
                    | None -> failwith $"Parameter {name} should has a static Parse method for string"

        fun (ctx: HttpContext) ->
            if box componentResponseCache <> null then
                if String.IsNullOrEmpty componentResponseCache.Vary |> not then
                    ctx.Response.Headers.Remove(HeaderNames.Vary) |> ignore
                    ctx.Response.Headers.Vary <- componentResponseCache.Vary
                if String.IsNullOrEmpty componentResponseCache.Pragma |> not then
                    ctx.Response.Headers.Remove(HeaderNames.Pragma) |> ignore
                    ctx.Response.Headers.Pragma <- componentResponseCache.Pragma
                if String.IsNullOrEmpty componentResponseCache.CacheControl |> not then
                    ctx.Response.Headers.Remove(HeaderNames.CacheControl) |> ignore
                    ctx.Response.Headers.CacheControl <- componentResponseCache.CacheControl

            paramsInfo
            |> Seq.choose (fun p ->
                let matchQuery () =
                    match ctx.Request.Query.TryGetValue p.Key with
                    | true, v when v.Count > 0 -> Some(p.Key => parseValue p.Key (v.Item(v.Count - 1).ToString()) p.Value)
                    | _ -> None
                if ctx.Request.Method.Equals(HttpMethods.Post, StringComparison.OrdinalIgnoreCase) then
                    match ctx.Request.Form.TryGetValue(p.Key) with
                    | true, v when v.Count > 0 -> Some(p.Key => parseValue p.Key (v.Item(v.Count - 1).ToString()) p.Value)
                    | _ -> matchQuery ()
                else
                    matchQuery ()
            )
            |> Seq.fold (==>) html.emptyAttr


    /// This will serve all the razor components (implement IComponent interface) for server side rendering,
    /// route pattern: /fun-blazor-server-side-render-components/{componentType}
    [<Extension>]
    static member MapRazorComponentsForSSR
        (
            builder: IEndpointRouteBuilder,
            types: Type seq,
            ?notFoundNode: NodeRenderFragment
#if !NET6_0
            , ?enableAntiforgery: bool
#endif
        )
        =
#if !NET6_0
        let enableAntiforgery = defaultArg enableAntiforgery false
#endif

        types
        |> Seq.iter (fun x ->
            Utils.razorComponentsForSSRTypes.Value[x.FullName] <-
                {|
                    Type = x
                    CreateAttr = FunBlazorServerExtensions.MakeCreateAttrFn x
                |}
        )

        let builder =
#if !NET6_0
            builder
                .Map(
                    "/fun-blazor-server-side-render-components/{componentType}",
                    Func<_, _, _>(fun (componentType: string) (ctx: HttpContext) ->
                        match Utils.razorComponentsForSSRTypes.Value.TryGetValue(componentType) with
                        | true, comp -> html.blazor (comp.Type, attr = comp.CreateAttr ctx)
                        | _ -> defaultArg notFoundNode html.none
                    )
                )
                .AddFunBlazor()
#else
            builder.Map(
                "/fun-blazor-server-side-render-components/{componentType}",
                Func<_, _, _>(fun (componentType: string) (ctx: HttpContext) ->
                    match Utils.razorComponentsForSSRTypes.Value.TryGetValue(componentType) with
                    | true, comp -> ctx.WriteFunDom(html.blazor (comp.Type, attr = comp.CreateAttr ctx), renderMode = RenderMode.Static)
                    | _ -> ctx.WriteFunDom(defaultArg notFoundNode html.none, RenderMode.Static)
                )
            )
#endif

#if !NET6_0
        if enableAntiforgery then
            builder.WithMetadata(RequiresAntiforgeryMetadata()) |> ignore
#else
        ()
#endif

    /// This will serve all blazor components (inherit from ComponentBase) in the target assembly for server side rendering
    /// route pattern: /fun-blazor-server-side-render-components/{componentType}.
    /// Value can be passed by query or form for component property, form will have higher priority. Only the last value will be take when found same keys.
    [<Extension>]
    static member MapRazorComponentsForSSR
        (
            builder: IEndpointRouteBuilder,
            assembly: Assembly,
            ?notFoundNode: NodeRenderFragment
#if !NET6_0
            ,?enableAntiforgery: bool
#endif
        )
        =
        builder.MapRazorComponentsForSSR(
            assembly.GetTypes() |> Seq.filter (fun x -> x.IsAssignableTo(typeof<IComponent>)),
            defaultArg notFoundNode html.none
#if !NET6_0
            ,defaultArg enableAntiforgery false
#endif
        )


#if !NET6_0
    /// This will serve all components for server side rendering with custom element enabled.
    /// You should use it with: services.AddServerSideBlazor(fun options -> options.RootComponents.RegisterCustomElementForFunBlazor<YourComponent>()),
    /// route pattern: /fun-blazor-custom-elements/{componentType}
    [<Extension>]
    static member MapCustomElementsForSSR(builder: IEndpointRouteBuilder, types: Type seq, ?notFoundNode: NodeRenderFragment, ?enableAntiforgery) =
        let enableAntiforgery = defaultArg enableAntiforgery false

        types
        |> Seq.iter (fun ty ->
            Utils.funBlazorCustomElementsForSSRTypes.Value[ty.FullName] <-
                {|
                    Type = ty
                    CreateAttr = FunBlazorServerExtensions.MakeCreateAttrFn(ty, forCustomElement = true)
                |}
        )

        let builder =
            builder
                .Map(
                    "/fun-blazor-custom-elements/{componentType}",
                    Func<_, _, _>(fun (componentType: string) (ctx: HttpContext) ->
                        match Utils.funBlazorCustomElementsForSSRTypes.Value.TryGetValue(componentType) with
                        | true, comp ->
                            let attrs = comp.CreateAttr ctx
                            html.customElement (comp.Type, attrs = attrs)
                        | _ -> defaultArg notFoundNode html.none
                    )
                )
                .AddFunBlazor()

        if enableAntiforgery then
            builder.WithMetadata(RequiresAntiforgeryMetadata()) |> ignore

    /// This will serve all components which is marked as FunBlazorCustomElementAttribute in the target assembly for server side rendering with custom element enabled,
    /// You should use it with: services.AddServerSideBlazor(fun options -> options.RootComponents.RegisterCustomElementForFunBlazor<YourComponent>()),
    /// route pattern: /fun-blazor-custom-elements/{componentType}
    [<Extension>]
    static member MapCustomElementsForSSR
        (
            builder: IEndpointRouteBuilder,
            assembly: Assembly,
            ?notFoundNode: NodeRenderFragment,
            ?enableAntiforgery: bool
        )
        =
        let types =
            assembly.GetTypes()
            |> Seq.filter (fun ty -> ty.GetCustomAttribute<FunBlazorCustomElementAttribute>() |> box |> isNull |> not)
        builder.MapCustomElementsForSSR(types, defaultArg notFoundNode html.none, defaultArg enableAntiforgery false)
#endif


    /// This will use MapFallback under the hood to capture all the routes for Fun.Blazor to use
    [<Extension>]
    static member MapFunBlazor(builder: IEndpointRouteBuilder, createFragment: HttpContext -> NodeRenderFragment, ?pattern) =
#if !NET6_0
        match pattern with
        | Some x -> builder.MapFallback(x, Func<_, _>(createFragment)).AddFunBlazor()
        | None -> builder.MapFallback(Func<_, _>(createFragment)).AddFunBlazor()
#else
        match pattern with
        | Some x -> builder.MapFallback(x, RequestDelegate(fun ctx -> ctx.WriteFunDom(createFragment ctx)))
        | None -> builder.MapFallback(RequestDelegate(fun ctx -> ctx.WriteFunDom(createFragment ctx)))
#endif

    /// This will use MapFallback under the hood to capture all the routes for Fun.Blazor to use
    [<Extension>]
    static member MapFunBlazor(builder: IEndpointRouteBuilder, pattern: string, createFragment: HttpContext -> NodeRenderFragment) =
        builder.MapFunBlazor(createFragment, pattern)
