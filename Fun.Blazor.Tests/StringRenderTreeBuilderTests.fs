module Fun.Blazor.Tests.StringRenderTreeBuilderTests

open System.Text
open Fun.Blazor
open Xunit


[<Fact>]
let ``Render basic element tree should work`` () =
    let sb = StringBuilder()

    let node = div {
        style { color "red" }
        p { "Hi, world" }
        section.create ()
        div {
            class' "cool-class"
            123
            h1 { "This is simple" }
        }
    }

    node.Invoke(null, StringRenderTreeBuilder(sb), 0) |> ignore

    Assert.Equal(
        """<div style="color: red; ">
    <p>
        Hi, world
    </p>
    <section>
    </section>
    <div class="cool-class">
        123
        <h1>
            This is simple
        </h1>
    </div>
</div>
""",
        sb.ToString()
    )
