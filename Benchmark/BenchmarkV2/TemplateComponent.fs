namespace Fun.Blazor.Benchmark

open FSharp.Data.Adaptive
open Microsoft.AspNetCore.Components.Rendering
open Fun.Blazor


type TemplateComponent() =
    inherit FunBlazorComponent()


    member this.Build() =
        use builder = new RenderTreeBuilder()
        this.BuildRenderTree(builder)
        
    
    override _.Render() =
        let count =
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

        Template.html $"""
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
                    {count}
                </section>
            </div>
        """
