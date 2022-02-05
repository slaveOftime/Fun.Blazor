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
                "p"
            }
            p {
                class' "class"
                "p"
            }
            p {
                class' "class"
                "p"
            }
            p {
                class' "class"
                "p"
            }
            p {
                class' "class"
                "p"
            }
            section {
                p {
                    class' "class"
                    "p"
                }
                adaptiview () {
                    let! count, setCount = cval(1).WithSetter()
                    p {
                        class' "class"
                        childContent $"Count = {count}"
                    }
                    button {
                        onclick (fun _ -> setCount (count + 1))
                        "Increase"
                    }
                }
            }
        }
