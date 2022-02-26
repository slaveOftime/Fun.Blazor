namespace Microsoft.Extensions.DependencyInjection

open System
open System.IO
open System.Text
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
    static member RenderFragment(ctx: HttpContext, ty: Type, ?renderMode, ?parameters) =
        task {
            let htmlHelper = ctx.RequestServices.GetService<IHtmlHelper>()
            (htmlHelper :?> IViewContextAware).Contextualize(ViewContext(HttpContext = ctx))

            let! result = htmlHelper.RenderComponentAsync(ty, defaultArg renderMode RenderMode.Static, defaultArg parameters null)

            use sw = new StringWriter()
            result.WriteTo(sw, HtmlEncoder.Default)
            do! sw.FlushAsync()
            return sw.ToString()
        }


    [<Extension>]
    static member MapFunBlazor(builder: IEndpointRouteBuilder, createFragment: HttpContext -> NodeRenderFragment, ?pattern, ?hotReload) =
        if defaultArg hotReload false then builder.UseFunBlazorHotReload()

        let requestDeletegate =
            Microsoft.AspNetCore.Http.RequestDelegate(fun ctx ->
                task {
                    let! result =
                        ctx.RenderFragment(
                            typeof<FunFragmentComponent>,
                            RenderMode.Static,
                            dict [
                                "Fragment", box (createFragment ctx)
                            ]
                        )

                    if isNull ctx.Response.ContentType then
                        ctx.Response.ContentType <- "text/html; charset=UTF-8"

                    let body = System.Text.Encoding.UTF8.GetBytes result
                    return! ctx.Response.Body.WriteAsync(ReadOnlyMemory body)
                }
            )

        match pattern with
        | Some x -> builder.MapFallback(x, requestDeletegate)
        | None -> builder.MapFallback(requestDeletegate)


    [<Extension>]
    static member MapFunBlazor(builder: IEndpointRouteBuilder, pattern: string, createFragment: HttpContext -> NodeRenderFragment, ?hotReload) =
        if defaultArg hotReload false then builder.UseFunBlazorHotReload()

        builder.MapFunBlazor(createFragment, pattern)


    /// This is only supposed to be used in DEBUG mode
    [<Extension>]
    static member internal UseFunBlazorHotReload(builder: IEndpointRouteBuilder) =
        builder.MapPut(
            "/fun-blazor-hot-reload",
            RequestDelegate(fun ctx ->
                task {
                    let store = ctx.RequestServices.GetService<IGlobalStore>()
                    use data = new MemoryStream()
                    do! ctx.Request.Body.CopyToAsync(data)
                    do! data.FlushAsync()
                    store.CreateCVal(HotReloadComponent.HotReloadStoreName, "[]").Publish(Encoding.UTF8.GetString(data.ToArray()))

                    return "Hot reload server received data."
                }
            )
        )
        |> ignore
