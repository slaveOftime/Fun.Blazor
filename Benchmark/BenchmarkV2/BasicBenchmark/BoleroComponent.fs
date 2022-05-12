namespace Benchmark.BasicBenchmark

open Microsoft.AspNetCore.Components.Rendering
open Bolero
open Bolero.Html


type BoleroComponent() =
    inherit Component()

    let mutable count = 0

    let increase () = count <- count + 1


    member this.Build() =
        use builder = new RenderTreeBuilder()
        this.BuildRenderTree(builder)


    override _.Render() =
        div {
            attr.``class`` "class"
            attr.style "color: red;"
            p {
                attr.``class`` "class"
                "p1"
            }
            p {
                attr.``class`` "class"
                "p2"
            }
            p {
                attr.``class`` "class"
                "p3"
            }
            p {
                attr.``class`` "class"
                "p4"
            }
            p {
                attr.``class`` "class"
                "p5"
            }
            section {
                p {
                    attr.``class`` "class"
                    "p6"
                }
                p {
                    attr.``class`` "class"
                    $"Count = {count}"
                }
                button {
                    Html.on.click (fun _ -> increase ())
                    text "Increase"
                }
            }
        }
