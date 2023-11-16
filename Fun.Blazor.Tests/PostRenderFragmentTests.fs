module Fun.Blazor.Tests.PostRenderFragmentTests

open Xunit
open Bunit
open Microsoft.AspNetCore.Components
open Microsoft.AspNetCore.Components.Web
open MudBlazor
open Fun.Blazor
open Fun.Blazor.Operators


let private createTestContext () =  new TestContext()


[<Fact>]
let ``ref should work for element`` () =
    let context = createTestContext ()

    let mutable i = 0

    let demo = div {
        ref (fun _ -> i <- 1)
    }

    let result = context.RenderNode demo
    result.MarkupMatches("""<div></div>""")
    Assert.Equal(1, i)


    let demo = div {
        class' "demo"
        style { color "green" }
        ref (fun _ -> i <- 2)
    }

    let result = context.RenderNode demo
    result.MarkupMatches("""<div class="demo" style="color: green; " ></div>""")
    Assert.Equal(2, i)


    let demo = div {
        class' "demo"
        style { color "green" }
        ref (fun _ -> i <- 3)
        "foo1"
        "foo2"
    }

    let result = context.RenderNode demo
    result.MarkupMatches("""<div class="demo" style="color: green; " >foo1foo2</div>""")
    Assert.Equal(3, i)

    let demo = div {
        class' "demo"
        style { color "green" }
        ref (fun _ -> i <- 4)
        childContent "foo1"
    }

    let result = context.RenderNode demo
    result.MarkupMatches("""<div class="demo" style="color: green; " >foo1</div>""")
    Assert.Equal(4, i)


[<Fact>]
let ``ref should work for component`` () =
    let context = createTestContext ()

    let mutable i = 0


    let demo = MudButton'() {
        ref (fun _ -> i <- 1)
        "click me"
    }

    let result = context.RenderNode demo
    result.MarkupMatches("""
        <button  type="button" class="mud-button-root mud-button mud-button-text mud-button-text-default mud-button-text-size-medium mud-ripple"  >
          <span class="mud-button-label">click me</span>
        </button>
    """)
    Assert.Equal(1, i)


    let demo = MudButton'() {
        ref (fun _ -> i <- 2)
    }

    let result = context.RenderNode demo
    result.MarkupMatches("""
        <button  type="button" class="mud-button-root mud-button mud-button-text mud-button-text-default mud-button-text-size-medium mud-ripple"  >
          <span class="mud-button-label"></span>
        </button>
    """)
    Assert.Equal(2, i)


    let demo = MudButton'() {
        Color Color.Primary
        ref (fun _ -> i <- 3)
    }

    let result = context.RenderNode demo
    result.MarkupMatches("""
        <button  type="button" class="mud-button-root mud-button mud-button-text mud-button-text-primary mud-button-text-size-medium mud-ripple"  >
          <span class="mud-button-label"></span>
        </button>
    """)
    Assert.Equal(3, i)


    let demo = MudButton'() {
        Color Color.Primary
        ref (fun _ -> i <- 4)
        childContent "click me"
    }

    let result = context.RenderNode demo
    result.MarkupMatches("""
        <button  type="button" class="mud-button-root mud-button mud-button-text mud-button-text-primary mud-button-text-size-medium mud-ripple"  >
          <span class="mud-button-label">click me</span>
        </button>
    """)
    Assert.Equal(4, i)


[<Fact>]
let ``ref and renderMode should work for component`` () =
    let context = createTestContext ()

    let mutable i = 0


    let demo = MudButton'() {
        ref (fun _ -> i <- 1)
        interactiveServer
        "click me"
    }

    let result = context.RenderNode demo
    result.MarkupMatches("""
        <button  type="button" class="mud-button-root mud-button mud-button-text mud-button-text-default mud-button-text-size-medium mud-ripple"  >
          <span class="mud-button-label">click me</span>
        </button>
    """)
    Assert.Equal(1, i)


    let demo = MudButton'() {
        interactiveServer
        ref (fun _ -> i <- 2)
    }

    let result = context.RenderNode demo
    result.MarkupMatches("""
        <button  type="button" class="mud-button-root mud-button mud-button-text mud-button-text-default mud-button-text-size-medium mud-ripple"  >
          <span class="mud-button-label"></span>
        </button>
    """)
    Assert.Equal(2, i)


    let demo = MudButton'() {
        Color Color.Primary
        interactiveServer
        ref (fun _ -> i <- 3)
    }

    let result = context.RenderNode demo
    result.MarkupMatches("""
        <button  type="button" class="mud-button-root mud-button mud-button-text mud-button-text-primary mud-button-text-size-medium mud-ripple"  >
          <span class="mud-button-label"></span>
        </button>
    """)
    Assert.Equal(3, i)


    let demo = MudButton'() {
        Color Color.Primary
        ref (fun _ -> i <- 4)
        interactiveServer
        childContent "click me"
    }

    let result = context.RenderNode demo
    result.MarkupMatches("""
        <button  type="button" class="mud-button-root mud-button mud-button-text mud-button-text-primary mud-button-text-size-medium mud-ripple"  >
          <span class="mud-button-label">click me</span>
        </button>
    """)
    Assert.Equal(4, i)



[<Fact>]
let ``renderMode should work for component`` () =
    let context = createTestContext ()

    let demo = MudButton'() {
        interactiveServer
        "click me"
    }

    let result = context.RenderNode demo
    result.MarkupMatches("""
        <button  type="button" class="mud-button-root mud-button mud-button-text mud-button-text-default mud-button-text-size-medium mud-ripple"  >
          <span class="mud-button-label">click me</span>
        </button>
    """)

    let demo = MudButton'() {
        Color Color.Primary
        interactiveServer
    }

    let result = context.RenderNode demo
    result.MarkupMatches("""
        <button  type="button" class="mud-button-root mud-button mud-button-text mud-button-text-primary mud-button-text-size-medium mud-ripple"  >
          <span class="mud-button-label"></span>
        </button>
    """)


    let demo = MudButton'() {
        Color Color.Primary
        interactiveServer
        childContent "click me"
    }

    let result = context.RenderNode demo
    result.MarkupMatches("""
        <button  type="button" class="mud-button-root mud-button mud-button-text mud-button-text-primary mud-button-text-size-medium mud-ripple"  >
          <span class="mud-button-label">click me</span>
        </button>
    """)



[<Fact>]
let ``renderMode should work for component without attrs`` () =
    let context = createTestContext ()

    let demo = CascadingValue'() {
        Value 1
        interactiveServer
    }

    context.RenderNode demo


[<Fact>]
let ``renderMode should work for html blazor`` () =
    let context = createTestContext ()

    let demo = html.blazor<CascadingValue<int>>(RenderMode.InteractiveServer, attr = (nameof(Unchecked.defaultof<CascadingValue<int>>.Value) => 123))

    context.RenderNode demo
