[<AutoOpen>]
module Fun.Blazor.Docs.Wasm.Pages.Tests.Tests

open Fun.Blazor.Docs.Wasm.Components


let tests =
    simplePage
        ""
        "Test with bUnit"
        "bUnit made testing so simple, but with Fun.Blazor it is even simpler"
        ""
        (sourceSection "Pages/Tests/TestsDemo")
