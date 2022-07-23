module Fun.Blazor.Tests.ServerTests

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
                fun (config: IConfiguration) -> task {
                    do! Task.Delay 100
                    return div { config.GetValue<string>("test") }
                }
            )
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
            route.MapGet("/Get1", (fun () -> testNode)) |> ignore
            route.MapGet("/Get2", testNode) |> ignore
            route.MapPost("/Post1", (fun () -> testNode)) |> ignore
            route.MapPost("/Post2", testNode) |> ignore
            route.MapPut("/Put1", (fun () -> testNode)) |> ignore
            route.MapPut("/Put2", testNode) |> ignore
            route.MapPatch("/Patch1", (fun () -> testNode)) |> ignore
            route.MapPatch("/Patch2", testNode) |> ignore
            route.MapDelete("/Delete1", (fun () -> testNode)) |> ignore
            route.MapDelete("/Delete2", testNode) |> ignore
        )

    use http = server.CreateClient()


    let! actual = http.GetStringAsync("/Get1")
    Assert.Equal(expectedResponse, actual)

    let! actual = http.GetStringAsync("/Get2")
    Assert.Equal(expectedResponse, actual)


    let! resp = http.PostAsync("/Post1", new StringContent(""))
    let! actual = resp.Content.ReadAsStringAsync()
    Assert.Equal(expectedResponse, actual)

    let! resp = http.PostAsync("/Post2", new StringContent(""))
    let! actual = resp.Content.ReadAsStringAsync()
    Assert.Equal(expectedResponse, actual)


    let! resp = http.PutAsync("/Put1", new StringContent(""))
    let! actual = resp.Content.ReadAsStringAsync()
    Assert.Equal(expectedResponse, actual)

    let! resp = http.PutAsync("/Put2", new StringContent(""))
    let! actual = resp.Content.ReadAsStringAsync()
    Assert.Equal(expectedResponse, actual)


    let! resp = http.PatchAsync("/Patch1", new StringContent(""))
    let! actual = resp.Content.ReadAsStringAsync()
    Assert.Equal(expectedResponse, actual)

    let! resp = http.PatchAsync("/Patch2", new StringContent(""))
    let! actual = resp.Content.ReadAsStringAsync()
    Assert.Equal(expectedResponse, actual)


    let! resp = http.DeleteAsync("/Delete1")
    let! actual = resp.Content.ReadAsStringAsync()
    Assert.Equal(expectedResponse, actual)

    let! resp = http.DeleteAsync("/Delete2")
    let! actual = resp.Content.ReadAsStringAsync()
    Assert.Equal(expectedResponse, actual)
}
