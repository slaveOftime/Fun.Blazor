Create any unit tests project, in this demo I use xUnit.

For the full tests example, please go to the source code to check project Fun.Blazor.Tests.

You need to define a simple test wraper component, or you can just copy below one:

```fsharp
[<Extension>]
type FunBlazorTestComponent() =
    inherit Component()

    [<Parameter>]
    member val Node = Unchecked.defaultof<FunBlazorNode> with get, set

    override this.Render () = this.Node.ToBolero()

    [<Extension>]
    static member RenderNode(ctx: TestContext, node: FunBlazorNode) =
        ctx.RenderComponent(fun (parameters: ComponentParameterCollectionBuilder<FunBlazorTestComponent>) -> 
            parameters.Add((fun p -> p.Node), node) |> ignore)
```

Create a bUnit test context

```fsharp
let createTestContext () =
    let textContext = new TestContext()
    
    textContext.Services
        .AddScoped<INavigationInterception>(fun _ -> Mock.Of<INavigationInterception>())
        |> ignore

    textContext
```

Then you are good to go:

```fsharp
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

        fun _ -> failwith "No route matched"
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
```