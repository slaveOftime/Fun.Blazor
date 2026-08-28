module Fun.Blazor.Tests.QueryBuilderTests

open System
open FsUnit.Xunit
open Microsoft.AspNetCore.Components
open Xunit
open Fun.Blazor


type QueryDemo = { Age: int; Name: string; Page: Nullable<int> }

type QueryComponent() =
    inherit ComponentBase()

    [<Parameter>]
    member val Included = "" with get, set

    member val Ignored = "" with get, set


[<Fact>]
let ``Adding an object ignores null properties`` () =
    QueryBuilder<QueryDemo>().Add({ Age = 1; Name = "foo"; Page = Nullable() }).ToString()
    |> should equal "Age=1&Name=foo"

[<Fact>]
let ``Adding values replaces or appends existing values`` () =
    QueryBuilder<QueryDemo>()
        .Add({ Age = 1; Name = "foo"; Page = Nullable(2) })
        .Add((fun x -> x.Age), 2)
        .Add((fun x -> x.Name), "bar", append = true)
        .ToString()
    |> should equal "Age=2&Name=foo&Name=bar&Page=2"

[<Fact>]
let ``Adding null removes an existing value unless appending`` () =
    QueryBuilder<QueryDemo>().Add({ Age = 1; Name = "foo"; Page = Nullable(2) }).Add((fun x -> x.Page), Nullable()).ToString()
    |> should equal "Age=1&Name=foo"

    QueryBuilder<QueryDemo>().Add({ Age = 1; Name = "foo"; Page = Nullable(2) }).Add((fun x -> x.Page), Nullable(), append = true).ToString()
    |> should equal "Age=1&Name=foo&Page=2"

[<Fact>]
let ``Removing values supports expressions and keys`` () =
    QueryBuilder<QueryDemo>().Add({ Age = 1; Name = "foo"; Page = Nullable(2) }).Remove(fun x -> x.Age).Remove("Page").ToString()
    |> should equal "Name=foo"

[<Fact>]
let ``Adding untyped values handles nullable and empty values`` () =
    QueryBuilder()
        .Add({| Age = 1; Name = "foo"; Page = Nullable() |})
        .Remove("Age")
        .Add("year", Nullable<int>())
        .Add("year", Nullable 2021)
        .Add("year", 2022, append = true)
        .Add("empty", "")
        .ToString()
    |> should equal "Name=foo&year=2021&year=2022"

[<Fact>]
let ``Adding sequences appends every value`` () =
    QueryBuilder().Add((fun (x: QueryDemo) -> x.Age), [ 1; 2; 3 ]).Add("year", [ 2021; 2022 ]).ToString()
    |> should equal "Age=1&Age=2&Age=3&year=2021&year=2022"

[<Fact>]
let ``Adding a component includes parameter properties only`` () =
    let queryComponent = QueryComponent(Included = "yes", Ignored = "no")

    QueryBuilder<QueryComponent>().Add(queryComponent).ToString() |> should equal "Included=yes"
