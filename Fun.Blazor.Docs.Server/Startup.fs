#nowarn "0020"

open System
open System.Net.Http
open System.Threading.Tasks
open Microsoft.Net.Http.Headers
open Microsoft.AspNetCore.Http
open Microsoft.AspNetCore.Builder
open Microsoft.Extensions.Hosting
open Microsoft.Extensions.DependencyInjection
open MudBlazor.Services
open Fun.Blazor.Docs.Server


let builder = WebApplication.CreateBuilder(Environment.GetCommandLineArgs())
let services = builder.Services

services.AddControllersWithViews()
services.AddServerSideBlazor().Services.AddFunBlazorServer().AddMudServices()
services.AddScoped<Fun.Blazor.Docs.Wasm.Demos.ScopedDemoService>()

services.AddScoped<HttpClient>(fun (sp) ->
    let httpContext = sp.GetService<IHttpContextAccessor>()
    let baseUrl =
        httpContext.HttpContext.Request.Scheme + "://" + httpContext.HttpContext.Request.Host.ToString()
    let http = new HttpClient()
    http.BaseAddress <- Uri baseUrl
    http
)


let app = builder.Build()


app.Use(fun (ctx: HttpContext) (nxt: RequestDelegate) ->
    task {
        ctx.Response.OnStarting(fun () ->
            task {
                if ctx.Response.StatusCode < 400 && ctx.Request.Query.ContainsKey "cacheKey" then
                    let durationInSeconds = 60 * 60 * 24 * 30
                    ctx.Response.Headers[ HeaderNames.CacheControl ] <- $"public,max-age={durationInSeconds}"
            }
        )
        do! nxt.Invoke ctx
    }
    :> Task
)

app.UseStaticFiles()

app.MapBlazorHub()
app.MapFunBlazor(Index.page)

app.Run()
