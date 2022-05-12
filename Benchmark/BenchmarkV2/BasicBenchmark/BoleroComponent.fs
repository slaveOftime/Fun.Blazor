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
            attr.``class`` "1"
            attr.style "color: red;"
            p {
                attr.``class`` "class"
                text "p"
            }
            p {
                attr.``class`` "class"
                text "p"
            }
            p {
                attr.``class`` "class"
                text "p"
            }
            p {
                attr.``class`` "class"
                text "p"
            }
            p {
                attr.``class`` "class"
                text "p"
            }
            section {
                p {
                    attr.``class`` "class"
                    text "p"
                }
                p {
                    attr.``class`` "class"
                    text $"Count = {count}"
                }
                button {
                    Html.on.click (fun _ -> increase ())
                    text "Increase"
                }
            }
        }
