namespace Benchmark.BasicBenchmark

open FSharp.Data.Adaptive
open Microsoft.AspNetCore.Components.Rendering
open Fun.Blazor


type FelizComponent() =
    inherit FunBlazorComponent()


    member this.Build() =
        use builder = new RenderTreeBuilder()
        this.BuildRenderTree(builder)


    override _.Render() =
        let counter =
            adaptiview () {
                let! count, setCount = cval(1).WithSetter()
                html.p [
                    attr.className "class"
                    attr.childContent $"Count = {count}"
                ]
                html.button [
                    attr.onclick (fun _ -> setCount (count + 1))
                    attr.childContent "Increase"
                ]
            }

        html.div [
            attr.className "1"
            attr.style "color: red;"
            attr.childContent [
                html.p [
                    attr.className "class"
                    attr.childContent "p"
                ]
                html.p [
                    attr.className "class"
                    attr.childContent "p"
                ]
                html.p [
                    attr.className "class"
                    attr.childContent "p"
                ]
                html.p [
                    attr.className "class"
                    attr.childContent "p"
                ]
                html.p [
                    attr.className "class"
                    attr.childContent "p"
                ]
                html.section [
                    html.p [
                        attr.className "class"
                        attr.childContent "p"
                    ]
                    counter
                ]
            ]
        ]
