namespace Microsoft.Extensions.DependencyInjection

open System
open System.IO
open System.Collections.Generic
open System.Threading.Tasks
open System.Text.Encodings.Web
open System.Runtime.CompilerServices
open Microsoft.AspNetCore.Http
open Microsoft.AspNetCore.Builder
open Microsoft.AspNetCore.Routing
open Microsoft.AspNetCore.Mvc.Rendering
#if !NET6_0
open Microsoft.AspNetCore.Components
open Microsoft.AspNetCore.Components.Endpoints
#endif
open Microsoft.AspNetCore.Mvc.ViewFeatures
open Microsoft.Extensions.DependencyInjection
open Fun.Blazor


#if !NET6_0
type FunBlazorEndpointFilter() =
    interface IEndpointFilter with
        member _.InvokeAsync(ctx, next) =
            task {
                match! next.Invoke(ctx) with
                | :? NodeRenderFragment as node -> return RazorComponentResult<FunFragmentComponent>(dict [ "Fragment", box node ]) :> obj
                | x -> return x
            }
            |> ValueTask<obj>
#endif


[<Extension>]
type FunBlazorServerExtensions =

    [<Extension>]
    static member AddFunBlazorServer(this: IServiceCollection) =
        this.AddHttpContextAccessor().AddScoped<IShareStore, ShareStore>().AddSingleton<IGlobalStore, GlobalStore>()


#if !NET6_0
    static member internal MapRenderMode(renderMode) =
        match renderMode with
        | RenderMode.Static -> null :> IComponentRenderMode
        | RenderMode.Server -> Web.ServerRenderMode(prerender = false)
        | RenderMode.ServerPrerendered -> Web.ServerRenderMode(prerender = true)
        | RenderMode.WebAssembly -> Web.WebAssemblyRenderMode(prerender = false)
        | RenderMode.WebAssemblyPrerendered -> Web.WebAssemblyRenderMode(prerender = true)
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


#if NET6_0
    /// 'Services should be a tuple of registered services or unit
    [<Extension>]
    static member MapGet<'Services>(builder: IEndpointRouteBuilder, pattern: string, render: 'Services -> Task<NodeRenderFragment>, ?renderMode) =
        builder.MapGet(pattern, FunBlazorServerExtensions.MakeRequestDelegate(render, defaultArg renderMode RenderMode.Static))

    /// 'Services should be a tuple of registered services or unit
    [<Extension>]
    static member MapGet<'Services>(builder: IEndpointRouteBuilder, pattern: string, render: 'Services -> NodeRenderFragment, ?renderMode) =
        builder.MapGet(pattern, render >> Task.FromResult, renderMode = defaultArg renderMode RenderMode.Static)

    [<Extension>]
    static member MapGet(builder: IEndpointRouteBuilder, pattern: string, node: NodeRenderFragment, ?renderMode) =
        builder.MapGet(pattern, (fun () -> node) >> Task.FromResult, renderMode = defaultArg renderMode RenderMode.Static)


    /// 'Services should be a tuple of registered services or unit
    [<Extension>]
    static member MapPost<'Services>(builder: IEndpointRouteBuilder, pattern: string, render: 'Services -> Task<NodeRenderFragment>, ?renderMode) =
        builder.MapPost(pattern, FunBlazorServerExtensions.MakeRequestDelegate(render, defaultArg renderMode RenderMode.Static))

    /// 'Services should be a tuple of registered services or unit
    [<Extension>]
    static member MapPost<'Services>(builder: IEndpointRouteBuilder, pattern: string, render: 'Services -> NodeRenderFragment, ?renderMode) =
        builder.MapPost(pattern, render >> Task.FromResult, renderMode = defaultArg renderMode RenderMode.Static)

    [<Extension>]
    static member MapPost(builder: IEndpointRouteBuilder, pattern: string, node: NodeRenderFragment, ?renderMode) =
        builder.MapPost(pattern, (fun () -> node) >> Task.FromResult, renderMode = defaultArg renderMode RenderMode.Static)


    /// 'Services should be a tuple of registered services or unit
    [<Extension>]
    static member MapPut<'Services>(builder: IEndpointRouteBuilder, pattern: string, render: 'Services -> Task<NodeRenderFragment>, ?renderMode) =
        builder.MapPut(pattern, FunBlazorServerExtensions.MakeRequestDelegate(render, defaultArg renderMode RenderMode.Static))

    /// 'Services should be a tuple of registered services or unit
    [<Extension>]
    static member MapPut<'Services>(builder: IEndpointRouteBuilder, pattern: string, render: 'Services -> NodeRenderFragment, ?renderMode) =
        builder.MapPut(pattern, render >> Task.FromResult, renderMode = defaultArg renderMode RenderMode.Static)

    [<Extension>]
    static member MapPut(builder: IEndpointRouteBuilder, pattern: string, node: NodeRenderFragment, ?renderMode) =
        builder.MapPut(pattern, (fun () -> node) >> Task.FromResult, renderMode = defaultArg renderMode RenderMode.Static)


    /// 'Services should be a tuple of registered services or unit
    [<Extension>]
    static member MapPatch<'Services>(builder: IEndpointRouteBuilder, pattern: string, render: 'Services -> Task<NodeRenderFragment>, ?renderMode) =
        builder.MapMethods(
            pattern,
            [ HttpMethods.Patch ],
            FunBlazorServerExtensions.MakeRequestDelegate(render, defaultArg renderMode RenderMode.Static)
        )

    /// 'Services should be a tuple of registered services or unit
    [<Extension>]
    static member MapPatch<'Services>(builder: IEndpointRouteBuilder, pattern: string, render: 'Services -> NodeRenderFragment, ?renderMode) =
        builder.MapPatch(pattern, render >> Task.FromResult, renderMode = defaultArg renderMode RenderMode.Static)

    [<Extension>]
    static member MapPatch(builder: IEndpointRouteBuilder, pattern: string, node: NodeRenderFragment, ?renderMode) =
        builder.MapPatch(pattern, (fun () -> node) >> Task.FromResult, renderMode = defaultArg renderMode RenderMode.Static)


    /// 'Services should be a tuple of registered services or unit
    [<Extension>]
    static member MapDelete<'Services>(builder: IEndpointRouteBuilder, pattern: string, render: 'Services -> Task<NodeRenderFragment>, ?renderMode) =
        builder.MapDelete(pattern, FunBlazorServerExtensions.MakeRequestDelegate(render, defaultArg renderMode RenderMode.Static))

    /// 'Services should be a tuple of registered services or unit
    [<Extension>]
    static member MapDelete<'Services>(builder: IEndpointRouteBuilder, pattern: string, render: 'Services -> NodeRenderFragment, ?renderMode) =
        builder.MapDelete(pattern, render >> Task.FromResult, renderMode = defaultArg renderMode RenderMode.Static)

    [<Extension>]
    static member MapDelete(builder: IEndpointRouteBuilder, pattern: string, node: NodeRenderFragment, ?renderMode) =
        builder.MapDelete(pattern, (fun () -> node) >> Task.FromResult, renderMode = defaultArg renderMode RenderMode.Static)
#endif


#if !NET6_0
    [<Extension>]
    static member AddFunBlazor<'TBuilder when 'TBuilder :> IEndpointConventionBuilder>(builder: 'TBuilder) =
        builder.AddEndpointFilter(FunBlazorEndpointFilter())

    /// This will use MapFallback under the hood to capture all the routes for Fun.Blazor to use
    [<Extension>]
    static member MapFunBlazor<'Component when 'Component :> IComponent>(builder: IEndpointRouteBuilder, ?pattern: string) =
        match pattern with
        | None -> builder.MapFallback(Func<_, _>(fun () -> RazorComponentResult<'Component>()))
        | Some pattern -> builder.MapFallback(pattern, Func<_, _>(fun () -> RazorComponentResult<'Component>()))
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
