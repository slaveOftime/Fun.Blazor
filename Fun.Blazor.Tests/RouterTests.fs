module Fun.Blazor.Tests.RouterTests

open Microsoft.AspNetCore.Components
open Microsoft.AspNetCore.Components.Routing
open Microsoft.Extensions.DependencyInjection
open Moq
open Xunit
open Bunit
open Fun.Blazor
open Fun.Blazor.Router


let private createTestContext () =
    let textContext = new TestContext()
    
    textContext.Services
        .AddScoped<INavigationInterception>(fun _ -> Mock.Of<INavigationInterception>())
        |> ignore

    textContext


[<Fact>]
let ``Giraffe style routes normal cases`` () =
    let formatQueries = Map.toList >> List.sortBy fst >> List.map (fun (k, v) -> $"{k}={v}") >> String.concat "&"

    let route = html.route [
        routeCi     "/r1" (html.text "/r1")
        routeCif    "/r1/%i" (fun x -> html.text $"/r1/{x}")
        routeCif    "/r1/r2/%s" (fun x -> html.text $"/r1/r2/{x}")
        subRouteCi  "/r2" [
            routeCi     "/r3" (html.text "/r2/r3")
            routeCif    "/r3/%i" (fun x -> html.text $"/r2/r3/{x}")
            routeCif    "/r3/r4/%s" (fun x -> html.text $"/r2/r3/r4/{x}")
        ]
        routeCiWithQueries "/r3" (fun x -> html.text $"/r3?{formatQueries x}")
        routeCifWithQueries "/r3/%i" (fun x q -> html.text $"/r3/{x}?{formatQueries q}")

        routeCi "/citest" (html.text "/CiTest")

        routeCi "/application/greate test1" (html.text "/application/greate%20test1")
        routeCif "/application/%s" (fun x -> if x = "greate test2" then html.text "/application/greate%20test2" else html.text "failed")

        fun x -> failwith $"No route matched for {x}"
    ]

    use testContext = createTestContext()

    let testRoute url =
        testContext.Services.GetService<NavigationManager>().NavigateTo(url)
        let result = testContext.RenderNode route
        result.MarkupMatches(url)

    testRoute "/r1"
    testRoute "/r1/1"
    testRoute "/r1/r2/hi"
    testRoute "/r2/r3"
    testRoute "/r2/r3/3"
    testRoute "/r2/r3/r4/hi"
    testRoute "/r3?a=a1&b=123"
    testRoute "/r3/3?a=a1&b=123"
    testRoute "/CiTest"
    testRoute "/application/greate%20test1"
    testRoute "/application/greate%20test2"


[<Fact>]
let ``Feliz style rooutes normal cases`` () =
    let route = html.route (function
        | [ "r1" ] -> html.text "/r1"
        | [ "r1"; Route.Int x ] -> html.text $"/r1/{x}"
        | [ "r1"; "r2"; x ] -> html.text $"/r1/r2/{x}"
        | [ "r3"; Route.Query [ "a", a; "b", b ] ] -> html.text $"/r3?a={a}&b={b}"
        | [ "r3"; Route.Int x; Route.Query [ "a", a; "b", b ] ] -> html.text $"/r3/{x}?a={a}&b={b}"
        | [ "application"; "greate test1" ] -> html.text "/application/greate%20test1"
        | [ "application"; x ] -> if x = "greate test2" then html.text "/application/greate%20test2" else html.text "error"
        | _ -> failwith "No route matched"
    )

    use testContext = createTestContext()

    let testRoute url =
        testContext.Services.GetService<NavigationManager>().NavigateTo(url)
        let result = testContext.RenderNode route
        result.MarkupMatches(url)

    testRoute "/r1"
    testRoute "/r1/1"
    testRoute "/r1/r2/hi"
    testRoute "/r3?a=a1&b=123"
    testRoute "/r3/3?a=a1&b=123"
    testRoute "/application/greate%20test1"
    testRoute "/application/greate%20test2"

