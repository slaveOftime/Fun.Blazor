namespace Microsoft.Extensions.DependencyInjection

open System
open System.IO
open System.Threading.Tasks
open System.Text.Encodings.Web
open System.Runtime.CompilerServices
open Microsoft.AspNetCore.Http
open Microsoft.AspNetCore.Builder
open Microsoft.AspNetCore.Routing
open Microsoft.AspNetCore.Mvc.Rendering
open Microsoft.AspNetCore.Mvc.ViewFeatures
open Microsoft.Extensions.DependencyInjection
open Fun.Blazor


[<Extension>]
type FunBlazorServerExtensions =

    [<Extension>]
    static member AddFunBlazorServer(this: IServiceCollection) =
        this.AddHttpContextAccessor().AddScoped<IShareStore, ShareStore>().AddSingleton<IGlobalStore, GlobalStore>()


    [<Extension>]
    static member RenderFragment(ctx: HttpContext, ty: Type, ?renderMode, ?parameters) = task {
        let htmlHelper = ctx.RequestServices.GetService<IHtmlHelper>()
        (htmlHelper :?> IViewContextAware).Contextualize(ViewContext(HttpContext = ctx))

        let! result = htmlHelper.RenderComponentAsync(ty, defaultArg renderMode RenderMode.Static, defaultArg parameters null)

        use sw = new StringWriter()
        result.WriteTo(sw, HtmlEncoder.Default)
        do! sw.FlushAsync()
        return sw.ToString()
    }


    /// Build DOM string and write to response
    [<Extension>]
    static member WriteFunDom(ctx: HttpContext, node: NodeRenderFragment, ?renderMode) =
        task {
            let htmlHelper = ctx.RequestServices.GetService<IHtmlHelper>()
            (htmlHelper :?> IViewContextAware).Contextualize(ViewContext(HttpContext = ctx))

            let! result =
                htmlHelper.RenderComponentAsync(typeof<FunFragmentComponent>, defaultArg renderMode RenderMode.Static, dict [ "Fragment", box node ])

            ctx.Response.ContentType <- "text/html; charset=UTF-8"

            use sw = new StreamWriter(ctx.Response.BodyWriter.AsStream(true))
            result.WriteTo(sw, HtmlEncoder.Default)
        }
        :> Task


    /// 'Services should be a tuple of registered services or unit
    [<Extension>]
    static member MapGet<'Services>(builder: IEndpointRouteBuilder, pattern: string, render: 'Services -> Task<NodeRenderFragment>, ?renderMode) =
        builder.MapGet(
            pattern,
            RequestDelegate(fun ctx -> task {
                let! node = render (ctx.RequestServices.GetMultipleServices<'Services>())
                do! ctx.WriteFunDom(node, defaultArg renderMode RenderMode.Static)
            })
        )

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
        builder.MapPost(
            pattern,
            RequestDelegate(fun ctx -> task {
                let! node = render (ctx.RequestServices.GetMultipleServices<'Services>())
                do! ctx.WriteFunDom(node, defaultArg renderMode RenderMode.Static)
            })
        )

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
        builder.MapPut(
            pattern,
            RequestDelegate(fun ctx -> task {
                let! node = render (ctx.RequestServices.GetMultipleServices<'Services>())
                do! ctx.WriteFunDom(node, defaultArg renderMode RenderMode.Static)
            })
        )

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
            RequestDelegate(fun ctx -> task {
                let! node = render (ctx.RequestServices.GetMultipleServices<'Services>())
                do! ctx.WriteFunDom(node, defaultArg renderMode RenderMode.Static)
            })
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
        builder.MapDelete(
            pattern,
            RequestDelegate(fun ctx -> task {
                let! node = render (ctx.RequestServices.GetMultipleServices<'Services>())
                do! ctx.WriteFunDom(node, defaultArg renderMode RenderMode.Static)
            })
        )

    /// 'Services should be a tuple of registered services or unit
    [<Extension>]
    static member MapDelete<'Services>(builder: IEndpointRouteBuilder, pattern: string, render: 'Services -> NodeRenderFragment, ?renderMode) =
        builder.MapDelete(pattern, render >> Task.FromResult, renderMode = defaultArg renderMode RenderMode.Static)

    [<Extension>]
    static member MapDelete(builder: IEndpointRouteBuilder, pattern: string, node: NodeRenderFragment, ?renderMode) =
        builder.MapDelete(pattern, (fun () -> node) >> Task.FromResult, renderMode = defaultArg renderMode RenderMode.Static)


    [<Extension>]
    static member MapFunBlazor(builder: IEndpointRouteBuilder, createFragment: HttpContext -> NodeRenderFragment, ?pattern) =
        let requestDeletegate =
            Microsoft.AspNetCore.Http.RequestDelegate(fun ctx -> ctx.WriteFunDom(createFragment ctx))

        match pattern with
        | Some x -> builder.MapFallback(x, requestDeletegate)
        | None -> builder.MapFallback(requestDeletegate)


    [<Extension>]
    static member MapFunBlazor(builder: IEndpointRouteBuilder, pattern: string, createFragment: HttpContext -> NodeRenderFragment) =
        builder.MapFunBlazor(createFragment, pattern)
