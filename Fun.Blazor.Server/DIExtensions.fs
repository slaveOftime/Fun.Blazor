namespace Microsoft.Extensions.DependencyInjection

open System
open System.IO
open System.Collections.Generic
open System.Threading.Tasks
open System.Text.Encodings.Web
open System.Reflection
open System.Runtime.CompilerServices
open Microsoft.AspNetCore.Http
open Microsoft.AspNetCore.Builder
open Microsoft.AspNetCore.Routing
open Microsoft.AspNetCore.Mvc.Rendering
#if !NET6_0
open Microsoft.AspNetCore.Antiforgery
open Microsoft.AspNetCore.Http.HttpResults
open Microsoft.AspNetCore.Components
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
                    let result = RazorComponentResult<FunFragmentComponent>(dict [ "Fragment", box node ])
                    result.PreventStreamingRendering <- preventStreamingRendering
                    result.StatusCode <- statusCode
                    return result :> obj
                | x ->
                    return x
            }
            |> ValueTask<obj>


type internal RequiresAntiforgeryMetadata(?requires) =
    interface IAntiforgeryMetadata with
        member _.RequiresValidation = defaultArg requires true
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
    static member AddFunBlazor<'TBuilder when 'TBuilder :> IEndpointConventionBuilder>(builder: 'TBuilder, ?preventStreamingRendering: bool, ?statusCode: int) =
        builder.AddEndpointFilter(FunBlazorEndpointFilter(defaultArg preventStreamingRendering false, defaultArg statusCode 200))


    static member private MakeCreateAttrFn(ty: Type) =
        let paramsInfo =
            ty.GetProperties()
            |> Seq.choose (fun p -> 
                let attr = p.GetCustomAttribute<ParameterAttribute>()
                if isNull attr then None
                else Some (p.Name, p.PropertyType)
            )
            |> Map.ofSeq

        let parseValue (name: string) (v: string) (ty: Type) = 
            if ty = typeof<string> then box v
            else
                let ty =
                    if ty.Name.StartsWith("Nullable`") then ty.GetGenericArguments()[0]
                    else ty
                ty.GetMethods(BindingFlags.Public ||| BindingFlags.Static)
                |> Seq.tryFind (fun x -> 
                    let ps = x.GetParameters()
                    x.Name = "Parse" && ps.Length = 1 && ps[0].ParameterType = typeof<string>
                )
                |> function
                    | Some x -> x.Invoke(null, [| v |])
                    | None -> failwith $"Parameter {name} should has a static Parse method for string"

        fun (ctx: HttpContext) ->
            paramsInfo
            |> Seq.choose (fun p ->
                let matchQuery() =
                    match ctx.Request.Query.TryGetValue p.Key with
                    | true, v -> Some (p.Key => parseValue p.Key (v.ToString()) p.Value)
                    | _ -> None
                if ctx.Request.Method.Equals(HttpMethods.Post, StringComparison.OrdinalIgnoreCase) then
                    match ctx.Request.Form.TryGetValue(p.Key) with
                    | true, v -> Some (p.Key => parseValue p.Key (v.ToString()) p.Value)
                    | _ -> matchQuery()
                else
                    matchQuery()
            )
            |> Seq.fold (==>) html.emptyAttr


    /// This will serve all blazor components (inherit from ComponentBase) in the target assembly for server side rendering
    /// route pattern: /fun-blazor-server-side-render-components/{componentType}
    [<Extension>]
    static member MapBlazorSSRComponents(builder: IEndpointRouteBuilder, assemblies: Assembly seq, ?notFoundNode: NodeRenderFragment, ?enableAntiforgery: bool) =
        let enableAntiforgery = defaultArg enableAntiforgery false
        let components =
            assemblies
            |> Seq.map (fun assembly ->
                assembly.GetTypes()
                |> Seq.filter (fun x -> x.IsAssignableTo(typeof<IComponent>))
                |> Seq.map (fun x -> x.FullName, {| Type = x; CreateAttr = FunBlazorServerExtensions.MakeCreateAttrFn x |})
            )
            |> Seq.concat
            |> Map.ofSeq
        let builder =
            builder
                .Map("/fun-blazor-server-side-render-components/{componentType}", Func<_, _, _>(fun (componentType: string) (ctx: HttpContext) ->
                    match Map.tryFind componentType components with
                    | Some comp -> 
                        let antiforgeryValidationFeature = ctx.Features.Get<IAntiforgeryValidationFeature>()
                        if enableAntiforgery && "post".Equals(ctx.Request.Method, StringComparison.OrdinalIgnoreCase) && antiforgeryValidationFeature <> null && not antiforgeryValidationFeature.IsValid then
                            box (Results.BadRequest("Antiforgery validation failed"))
                        else
                            box (html.blazor(comp.Type, attr = comp.CreateAttr ctx))
                    | None ->
                        box (defaultArg notFoundNode html.none)
                ))
                .AddFunBlazor()
        if enableAntiforgery then
            builder.WithMetadata(RequiresAntiforgeryMetadata())
        else
            builder

    /// This will serve all blazor components (inherit from ComponentBase) in the target assembly for server side rendering
    /// route pattern: /fun-blazor-server-side-render-components/{componentType}
    [<Extension>]
    static member MapBlazorSSRComponents(builder: IEndpointRouteBuilder, assembly: Assembly, ?notFoundNode: NodeRenderFragment, ?enableAntiforgery: bool) =
        builder.MapBlazorSSRComponents([assembly], notFoundNode = defaultArg notFoundNode html.none, enableAntiforgery = defaultArg enableAntiforgery false)

    /// This will serve all components which is marked as FunBlazorCustomElementAttribute in the target assembly, 
    /// route pattern: /fun-blazor-custom-elements/{componentType}
    [<Extension>]
    static member MapFunBlazorCustomElements(builder: IEndpointRouteBuilder, assemblies: Assembly seq, ?notFoundNode: NodeRenderFragment, ?enableAntiforgery: bool) =
        let enableAntiforgery = defaultArg enableAntiforgery false
        let components =
            assemblies
            |> Seq.map (fun assembly -> [
                for ty in assembly.GetTypes() do
                    let attr = ty.GetCustomAttribute<FunBlazorCustomElementAttribute>()
                    if attr |> box |> isNull |> not then
                        let tagName =
                            match attr.TagName with
                            | NullOrEmptyString -> None
                            | SafeString tagName -> Some tagName
                        ty.FullName, {| Type = ty; CreateAttr = FunBlazorServerExtensions.MakeCreateAttrFn ty; TagName = tagName |}
            ])
            |> Seq.concat
            |> Map.ofSeq
        let builder =
            builder
                .Map("/fun-blazor-custom-elements/{componentType}", Func<_, _, _>(fun (componentType: string) (ctx: HttpContext) ->
                    match Map.tryFind componentType components with
                    | Some comp ->
                        let antiforgeryValidationFeature = ctx.Features.Get<IAntiforgeryValidationFeature>()
                        if "post".Equals(ctx.Request.Method, StringComparison.OrdinalIgnoreCase) && antiforgeryValidationFeature <> null && not antiforgeryValidationFeature.IsValid then
                            box (Results.BadRequest("Antiforgery validation failed"))
                        else
                            let attrs = comp.CreateAttr ctx
                            match comp.TagName with
                            | None -> html.customElement(comp.Type, attrs = attrs)
                            | Some tagName -> html.customElement(comp.Type, attrs = attrs, tagName = tagName)
                            |> box
                    | None -> 
                        box (defaultArg notFoundNode html.none)
                ))
                .AddFunBlazor()
        if enableAntiforgery then
            builder.WithMetadata(RequiresAntiforgeryMetadata())
        else
            builder

    /// This will serve all components which is marked as FunBlazorCustomElementAttribute in the target assembly, 
    /// route pattern: /fun-blazor-custom-elements/{componentType}
    [<Extension>]
    static member MapFunBlazorCustomElements(builder: IEndpointRouteBuilder, assembly: Assembly, ?notFoundNode: NodeRenderFragment, ?enableAntiforgery: bool) =
        builder.MapFunBlazorCustomElements([assembly], notFoundNode = defaultArg notFoundNode html.none, enableAntiforgery = defaultArg enableAntiforgery false)
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
