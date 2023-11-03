namespace Benchmark.BasicBenchmark

open Microsoft.AspNetCore.Components.Rendering
open Fun.Blazor


type SSRTemplateComponent() =
    inherit FunComponent()
    
    let mutable count = 0

    let increase () = count <- count + 1


    member this.Build() =
        use builder = new RenderTreeBuilder()
        this.BuildRenderTree(builder)
        
    
    override _.Render() =
        SSRTemplate.html $"""
            <div class="class" style="color: red;">
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
                <section>
                    <p class="class">
                        p
                    </p>
                    <p class="class">
                        Count = {count}
                    </p>
                    <button onclick={fun _ -> increase()}>
                        Increase
                    </button>
                </section>
            </div>
        """
