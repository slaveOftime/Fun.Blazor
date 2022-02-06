namespace Benchmark.BasicBenchmark

open Microsoft.AspNetCore.Components.Rendering
open Fun.Blazor


type FelizComponent() =
    inherit FunBlazorComponent()
    
    let mutable count = 0

    let increase () = count <- count + 1


    member this.Build() =
        use builder = new RenderTreeBuilder()
        this.BuildRenderTree(builder)


    override _.Render() =
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
                    html.p [
                        attr.className "class"
                        attr.childContent $"Count = {count}"
                    ]
                    html.button [
                        attr.onclick (fun _ -> increase())
                        attr.childContent "Increase"
                    ]
                ]
            ]
        ]
