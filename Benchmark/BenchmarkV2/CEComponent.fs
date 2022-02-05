namespace Fun.Blazor.Benchmark

open FSharp.Data.Adaptive
open Microsoft.AspNetCore.Components.Rendering
open Fun.Blazor


type CEComponent() =
    inherit FunBlazorComponent()


    member this.Build() =
        use builder = new RenderTreeBuilder()
        this.BuildRenderTree(builder)


    override _.Render() =
        div {
            class' "class"
            css "color: red;"
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
                adaptiview () {
                    let! count, setCount = cval(1).WithSetter()
                    p {
                        class' "class"
                        $"Count = {count}"
                    }
                    button {
                        onclick (fun _ -> setCount (count + 1))
                        "Increase"
                    }
                }
            }
        }
