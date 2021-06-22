namespace Microsoft.Extensions.DependencyInjection

open System.Runtime.CompilerServices
open Microsoft.AspNetCore.Builder
open Microsoft.AspNetCore.Routing
open Microsoft.Extensions.DependencyInjection
open Bolero.Server
open Fun.Blazor


[<Extension>]
type ServiceCollectionExtensions =
    [<Extension>]
    static member AddFunBlazorServer(this: IServiceCollection, ?isServer, ?isPrerendered) =
        this.AddBoleroHost(defaultArg isServer true, defaultArg isPrerendered true)
            .AddFunBlazor()


[<Extension>]
type EndpointRouteBuilderExtensions =
    [<Extension>]
    static member MapFallbackToFunBlazor (this: IEndpointRouteBuilder, node: FunBlazorNode) =
        this.MapFallback(fun ctx ->
            if isNull ctx.Response.ContentType then
                ctx.Response.ContentType <- "text/html; charset=UTF-8"
            ctx.RenderPage(node.ToBolero()))