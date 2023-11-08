module Fun.Blazor.Tests.ServerTests

open System
open System.Net.Http
open System.Threading
open System.Threading.Tasks
open Microsoft.AspNetCore.Hosting
open Microsoft.AspNetCore.Builder
open Microsoft.AspNetCore.TestHost
open Microsoft.AspNetCore.Routing
open Microsoft.Extensions.Configuration
open Microsoft.Extensions.DependencyInjection
open Fun.Blazor
open Xunit


let makeTestServer (setRoute: IEndpointRouteBuilder -> unit) =
    let builder =
        WebHostBuilder()
            .UseSetting("test", "123")
            .ConfigureServices(fun services ->
                services.AddControllersWithViews() |> ignore
                services.AddRouting() |> ignore
            )
            .Configure(fun builder -> builder.UseRouting().UseEndpoints(setRoute) |> ignore)

    new TestServer(builder)


let testNode = div {
    style { color "red" }
    "test"
}

let expectedResponse = """<div style="color: red; ">test</div>"""



[<Fact>]
let ``MapGet should work with DI`` () = task {
    use server =
        makeTestServer (fun route ->
            route.MapGet(
                "/test",
                Func<_, _>(fun (config: IConfiguration) -> task {
                    do! Task.Delay 100
                    return div { config.GetValue<string>("test") }
                })
            ).AddFunBlazor()
            |> ignore
        )

    use http = server.CreateClient()

    let! actual = http.GetStringAsync("/test")
    Assert.Equal("<div>123</div>", actual)
}


[<Fact>]
let ``MapXxx should work`` () = task {
    use server =
        makeTestServer (fun route ->
            let route = route.MapGroup("").AddFunBlazor()
            route.MapGet("/Get1", Func<_>(fun () -> testNode)) |> ignore
            route.MapPost("/Post1",  Func<_>(fun () -> testNode)) |> ignore
            route.MapPut("/Put1",  Func<_>(fun () -> testNode)) |> ignore
            route.MapPatch("/Patch1",  Func<_>(fun () -> testNode)) |> ignore
            route.MapDelete("/Delete1",  Func<_>(fun () -> testNode)) |> ignore
        )

    use http = server.CreateClient()


    let! actual = http.GetStringAsync("/Get1")
    Assert.Equal(expectedResponse, actual)


    let! resp = http.PostAsync("/Post1", new StringContent(""))
    let! actual = resp.Content.ReadAsStringAsync()
    Assert.Equal(expectedResponse, actual)


    let! resp = http.PutAsync("/Put1", new StringContent(""))
    let! actual = resp.Content.ReadAsStringAsync()
    Assert.Equal(expectedResponse, actual)


    let! resp = http.PatchAsync("/Patch1", new StringContent(""))
    let! actual = resp.Content.ReadAsStringAsync()
    Assert.Equal(expectedResponse, actual)


    let! resp = http.DeleteAsync("/Delete1")
    let! actual = resp.Content.ReadAsStringAsync()
    Assert.Equal(expectedResponse, actual)
}
