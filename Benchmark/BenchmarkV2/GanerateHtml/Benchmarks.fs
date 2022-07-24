namespace Benchmark.GenerateHtml

open BenchmarkDotNet.Attributes


module GiraffeDemo =
    open Giraffe.ViewEngine

    let run () =
        html [] [
            body [] [
                h1 [] [ Text "Hello, world" ]
                p [] [ Text "Some text"; a [ _href "url" ] [ Text "Link" ] ]
            ]
        ]
        |> RenderView.AsString.htmlNode


module FunBlazorDemo =
    open Fun.Blazor

    let run () =
        html' {
            body {
                h1 { "Hello, world" }
                p {
                    "Some text"
                    a {
                        href "url"
                        "Link"
                    }
                }
            }
        }
        |> html.renderToString
        

[<MemoryDiagnoser>]
type Benchmarks() =

    [<Benchmark>]
    member _.GiraffeDemo() = GiraffeDemo.run ()

    [<Benchmark>]
    member _.FunBlazorDemo() = FunBlazorDemo.run ()
