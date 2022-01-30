namespace Microsoft.Extensions.DependencyInjection

open System
open System.IO
open System.Text.Encodings.Web
open System.Runtime.CompilerServices
open Microsoft.AspNetCore.Http
open Microsoft.AspNetCore.Builder
open Microsoft.AspNetCore.Routing
open Microsoft.AspNetCore.Components
open Microsoft.AspNetCore.Mvc.Rendering
open Microsoft.AspNetCore.Mvc.ViewFeatures
open Microsoft.Extensions.DependencyInjection
open Fun.Blazor


[<Extension>]
type HttpContextExtensions =

    [<Extension>]
    static member RenderFragment(ctx: HttpContext, ty: Type, ?renderMode, ?parameters) =
        task {
            let htmlHelper = ctx.RequestServices.GetService<IHtmlHelper>()
            (htmlHelper :?> IViewContextAware).Contextualize(ViewContext(HttpContext = ctx))

            let! result =
                htmlHelper.RenderComponentAsync(ty, defaultArg renderMode RenderMode.Static, defaultArg parameters null)

            use sw = new StringWriter()
            result.WriteTo(sw, HtmlEncoder.Default)
            do! sw.FlushAsync()
            return sw.ToString()
        }


    [<Extension>]
    static member MapFunBlazor(builder: IEndpointRouteBuilder, fragment, ?pattern) =
        let requestDeletegate =
            Microsoft.AspNetCore.Http.RequestDelegate(fun ctx ->
                task {
                    if isNull ctx.Response.ContentType then
                        ctx.Response.ContentType <- "text/html; charset=UTF-8"

                    let! result =
                        ctx.RenderFragment(
                            typeof<FunFragmentComponent>,
                            RenderMode.Static,
                            dict [ "Fragment", box fragment ]
                        )

                    let body = System.Text.Encoding.UTF8.GetBytes result
                    return! ctx.Response.Body.WriteAsync(ReadOnlyMemory body)
                }
            )

        match pattern with
        | Some x -> builder.MapFallback(x, requestDeletegate)
        | None -> builder.MapFallback(requestDeletegate)
