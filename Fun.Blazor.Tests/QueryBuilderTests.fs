module Fun.Blazor.Tests.QueryBuilderTests

open System
open Xunit
open FsUnit.Xunit
open Fun.Blazor

type QueryDemo = { Age: int; Name: string; Page: Nullable<int> }

[<Fact>]
let ``Should work for adding, appending and removing`` () =

    QueryBuilder<QueryDemo>().Add({ Age = 1; Name = "foo"; Page = Nullable() }).ToString()
    |> should equal "Age=1&Name=foo"

    QueryBuilder<QueryDemo>()
        .Add({ Age = 1; Name = "foo"; Page = Nullable(2) })
        .Add((fun x -> x.Age), 2)
        .Add((fun x -> x.Name), "bar", append = true)
        .ToString()
    |> should equal "Age=2&Name=foo&Name=bar&Page=2"

    QueryBuilder<QueryDemo>()
        .Add({ Age = 1; Name = "foo"; Page = Nullable(2) })
        .Add((fun x -> x.Age), 2)
        .Add((fun x -> x.Age), Nullable())
        .ToString()
    |> should equal "Name=foo&Page=2"

    QueryBuilder<QueryDemo>()
        .Add({ Age = 1; Name = "foo"; Page = Nullable(2) })
        .Add((fun x -> x.Age), 2)
        .Remove((fun x -> x.Age))
        .ToString()
    |> should equal "Name=foo&Page=2"

    QueryBuilder<QueryDemo>()
        .Add({ Age = 1; Name = "foo"; Page = Nullable(2) })
        .Add((fun x -> x.Age), 2)
        .Remove("Age")
        .ToString()
    |> should equal "Name=foo&Page=2"

    QueryBuilder()
        .Add({| Age = 1; Name = "foo"; Page = Nullable() |})
        .Remove("Age")
        .Add("year", Nullable<int>())
        .Add("year", Nullable 2021)
        .Add("year", 2022, append = true)
        .ToString()
    |> should equal "Name=foo&year=2021&year=2022"

    QueryBuilder().Add((fun (x: QueryDemo) -> x.Age), [ 1; 2; 3 ]).Add("year", [ 2021; 2022 ]).ToString()
    |> should equal "Age=1&Age=2&Age=3&year=2021&year=2022"

    QueryBuilder().Add("year", Nullable 2021).Add("year", Nullable<int>()).Add("label", "demo").Add("label2", "").ToString()
    |> should equal "label=demo"

    QueryBuilder<QueryDemo>()
        .Add({ Age = 1; Name = "foo"; Page = Nullable(2) })
        .Add((fun x -> x.Page), Nullable())
        .ToString()
    |> should equal "Age=1&Name=foo"

    QueryBuilder<QueryDemo>()
        .Add({ Age = 1; Name = "foo"; Page = Nullable(2) })
        .Add((fun x -> x.Page), Nullable(), append = true)
        .ToString()
    |> should equal "Age=1&Name=foo&Page=2"
