namespace Benchmark.BasicBenchmark

open Microsoft.AspNetCore.Components.Rendering
open Fun.Blazor


type CEFelizComponent() =
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
                    attr.className "class"
                    attr.childContent $"Count = {count}"
                }
                button {
                    attr.onclick (fun _ -> increase ())
                    attr.childContent "Increase"
                }
            }

        div {
            attr.className "1"
            attr.style "color: red;"
            p {
                attr.className "class"
                attr.childContent "p"
            }
            p {
                attr.className "class"
                attr.childContent "p"
            }
            p {
                attr.className "class"
                attr.childContent "p"
            }
            p {
                attr.className "class"
                attr.childContent "p"
            }
            p {
                attr.className "class"
                attr.childContent "p"
            }
            section {
                p {
                    attr.className "class"
                    attr.childContent "p"
                }
                counter
            }
        }
