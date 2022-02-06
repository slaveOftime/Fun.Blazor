namespace Benchmark.BasicBenchmark

open FSharp.Data.Adaptive
open Microsoft.AspNetCore.Components.Rendering
open Fun.Blazor


type TemplateComponent() =
    inherit FunBlazorComponent()


    member this.Build() =
        use builder = new RenderTreeBuilder()
        this.BuildRenderTree(builder)
        
    
    override _.Render() =
        let counter =
            adaptiview () {
                let! count, setCount = cval(1).WithSetter()
                Template.html $"""
                    <p class="class">
                        Count = {count}
                    </p>
                    <button onclick={fun _ -> setCount (count + 1)}>
                        Increase
                    </button>
                """
            }

        let staticPart =
            Template.html $"""
                <p class="class">
                    p
                </p>
                <p class="class">
                    p
                </p>
                <p class="class">
                    p
                </p>
                <p class="class">
                    p
                </p>
                <p class="class">
                    p
                </p>
            """

        Template.html $"""
            <div class="class" style="color: red;">
                {staticPart}
                <section>
                    <p class="class">
                        p
                    </p>
                    {counter}
                </section>
            </div>
        """
