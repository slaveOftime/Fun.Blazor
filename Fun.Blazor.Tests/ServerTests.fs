namespace Fun.Blazor.Tests

open System
open System.Net.Http
open System.Threading.Tasks
open Microsoft.AspNetCore.Hosting
open Microsoft.AspNetCore.Builder
open Microsoft.AspNetCore.TestHost
open Microsoft.AspNetCore.Routing
open Microsoft.AspNetCore.Components
open Microsoft.Extensions.Configuration
open Microsoft.Extensions.DependencyInjection
open Fun.Blazor
open Xunit
open System.Collections.Generic


[<FunBlazorCustomElement>]
type ServerDemoCounter() as this =
    inherit FunComponent()

    [<Parameter>]
    member val count = 0 with get, set

    [<Parameter>]
    member val count2 = Nullable(0) with get, set

    [<Parameter>]
    member val query = "" with get, set

    [<Parameter>]
    member val is_loading = false with get, set

    [<Parameter>]
    member val guid = Guid.Empty with get, set

    override _.Render() = div {
        p { $"{nameof this.count} = {this.count}" }
        p { $"{nameof this.query} = {this.query}" }
        p { $"{nameof this.is_loading} = {this.is_loading}" }
        p { $"{nameof this.guid} = {this.guid}" }
    }


module ServerTests =
    let makeTestServer (setRoute: IEndpointRouteBuilder -> unit) =
        let builder =
            WebHostBuilder()
                .UseSetting("test", "123")
                .ConfigureServices(fun services ->
                    services.AddRouting() |> ignore

                    services.AddServerSideBlazor(fun options ->
                        options.RootComponents.RegisterCustomElementForFunBlazor(typeof<ServerDemoCounter>.Assembly)
                    )
                    |> ignore

                    services.AddRazorComponents() |> ignore
                    services.AddFunBlazorServer() |> ignore
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
                route
                    .MapGet(
                        "/test",
                        Func<_, _>(fun (config: IConfiguration) -> task {
                            do! Task.Delay 100
                            return div { config.GetValue<string>("test") }
                        })
                    )
                    .AddFunBlazor()
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
                route.MapPost("/Post1", Func<_>(fun () -> testNode)) |> ignore
                route.MapPut("/Put1", Func<_>(fun () -> testNode)) |> ignore
                route.MapPatch("/Patch1", Func<_>(fun () -> testNode)) |> ignore
                route.MapDelete("/Delete1", Func<_>(fun () -> testNode)) |> ignore
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


    [<Fact>]
    let ``MapBlazorSSRComponents and MapFunBlazorCustomElements should work with`` () = task {
        let notFoundNode = div { "not found" }

        use server =
            makeTestServer (fun route ->
                route.MapRazorComponents() |> ignore
                route.MapBlazorSSRComponents(typeof<ServerDemoCounter>.Assembly, notFoundNode) |> ignore
                route.MapFunBlazorCustomElements(typeof<ServerDemoCounter>.Assembly, notFoundNode) |> ignore
            )

        use http = server.CreateClient()
        use formContent = new FormUrlEncodedContent([ KeyValuePair("count", "-2"); KeyValuePair("count", "2") ])

        let query =
            QueryBuilder<ServerDemoCounter>()
                .Add((fun x -> x.count), 1)
                .Add((fun x -> x.query), "hi")
                .Add((fun x -> x.is_loading), true)
                .Add((fun x -> x.guid), Guid.Parse("8da005a9-4b2c-4308-b026-707fbb02f7c6"))
                .ToString()

        let! actual = http.GetStringAsync($"/fun-blazor-custom-elements/{typeof<ServerDemoCounter>.FullName}?{query}")
        Assert.StartsWith(
            """<server-demo-counter count="1" guid="8da005a9-4b2c-4308-b026-707fbb02f7c6" is_loading query="hi"></server-demo-counter>""",
            actual
        )

        let! response = http.PostAsync($"/fun-blazor-custom-elements/{typeof<ServerDemoCounter>.FullName}?{query}", formContent)
        let! actual = response.Content.ReadAsStringAsync()
        Assert.StartsWith(
            """<server-demo-counter count="2" guid="8da005a9-4b2c-4308-b026-707fbb02f7c6" is_loading query="hi"></server-demo-counter>""",
            actual
        )

        let! actual = http.GetStringAsync($"/fun-blazor-server-side-render-components/{typeof<ServerDemoCounter>.FullName}?{query}")
        Assert.Equal(
            """<div><p>count = 1</p><p>query = hi</p><p>is_loading = True</p><p>guid = 8da005a9-4b2c-4308-b026-707fbb02f7c6</p></div>""",
            actual
        )

        let! response = http.PostAsync($"/fun-blazor-server-side-render-components/{typeof<ServerDemoCounter>.FullName}?{query}", formContent)
        let! actual = response.Content.ReadAsStringAsync()
        Assert.Equal(
            """<div><p>count = 2</p><p>query = hi</p><p>is_loading = True</p><p>guid = 8da005a9-4b2c-4308-b026-707fbb02f7c6</p></div>""",
            actual
        )

        let query =
            QueryBuilder<ServerDemoCounter>()
                .Add((fun x -> x.count), 1)
                .Add((fun x -> x.count), 2)
                .ToString()

        let! actual = http.GetStringAsync($"/fun-blazor-custom-elements/{typeof<ServerDemoCounter>.FullName}?{query}")
        Assert.StartsWith(
            """<server-demo-counter count="2"></server-demo-counter>""",
            actual
        )

        let query =
            QueryBuilder<ServerDemoCounter>()
                .Add((fun x -> x.count), 1)
                .Add(ServerDemoCounter(count = 2))
                .Add((fun x -> x.count), 3)
                .Add((fun x -> x.count2), Nullable 5)
                .Add((fun x -> x.count2), Nullable 4, append = true)
                .ToString()

        let! actual = http.GetStringAsync($"/fun-blazor-custom-elements/{typeof<ServerDemoCounter>.FullName}?{query}")
        Assert.StartsWith(
            """<server-demo-counter count="3" count2="4" guid="00000000-0000-0000-0000-000000000000" query=""></server-demo-counter>""",
            actual
        )
    }
