[<AutoOpen>]
module Fun.Blazor.Docs.Wasm.Pages.CliUsage.CliUsage

open Fun.Blazor
open Fun.Blazor.Docs.Wasm.Components


let cliUsage =
    simplePage
        ""
        "Fun.Blazor.Cli"
        "Use this to generate third party dsl code"
        ""
        (sourceSection "Pages/CliUsage/CliUsageDemo")