namespace Benchmark.BasicBenchmark

open Microsoft.AspNetCore.Components.Rendering
open Fun.Blazor


type CEComponent() =
    inherit FunBlazorComponent()

    let mutable count = 0

    let increase () = count <- count + 1


    member this.Build() =
        use builder = new RenderTreeBuilder()
        this.BuildRenderTree(builder)


    override _.Render() =
        let counter =
            fragment {
                p {
                    class' "class"
                    $"Count = {count}"
                }
                button {
                    onclick (fun _ -> increase ())
                    "Increase"
                }
            }
            
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
                // Declare a variable help fsharp to have better inline which can save a lot of allocation for delegate
                // In this benchmark it can save 40%
                counter
            }
        }
