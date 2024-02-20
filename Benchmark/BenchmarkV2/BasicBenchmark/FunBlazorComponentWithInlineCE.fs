namespace Benchmark.BasicBenchmark

open Microsoft.AspNetCore.Components.Rendering
open Fun.Blazor


type FunBlazorComponentWithInlineCE() =
    inherit FunComponent()

    let mutable count = 0

    let increase () = count <- count + 1


    member this.Build() =
        use builder = new RenderTreeBuilder()
        this.BuildRenderTree(builder)


    override _.Render() =            
        div {
            class' "class"
            style' "color: red;"
            p {
                class' "class"
                "p1"
            }
            p {
                class' "class"
                "p2"
            }
            p {
                class' "class"
                "p3"
            }
            p {
                class' "class"
                "p4"
            }
            p {
                class' "class"
                "p5"
            }
            section {
                p {
                    class' "class"
                    "p6"
                }
                p {
                    class' "class"
                    "Count = "
                    count
                }
                button {
                    onclick (fun _ -> increase ())
                    "Increase"
                }
            }
        }
