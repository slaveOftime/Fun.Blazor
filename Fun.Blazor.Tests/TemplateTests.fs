module Fun.Blazor.Tests.TemplateTests

open Xunit
open Fun.Blazor
open Bunit


[<Fact>]
let ``Template should work`` () =
    let context = new TestContext()

    let count = 1
    let classes = "c1 c2"

    let segment1 = Static.html "<h1>static</h1>"
    let segment2 = Template.html $"<div>{count}</div>"

    let result =
        context.RenderNode(
            Template.html $"""
                <div class="{classes}">
                    {segment1}
                    {segment2}
                </div>
            """
        )

    result.MarkupMatches(
        """
        <div class="c1 c2">
          <h1>static</h1>
          <div>1</div>
        </div>
        """
    )


[<Fact>]
let ``SSRTemplate should work`` () =
    let context = new TestContext()

    let count = 1
    let classes = "c1 c2"

    let segment1 = Static.html "<h1>static</h1>"
    let segment2 = Template.html $"<div>{count}</div>"
    let segment3 = SSRTemplate.html $"<div>{count}</div>"

    let result =
        context.RenderNode(
            SSRTemplate.html $"""
                <div class="{classes}">
                    {segment1}
                    {segment2}
                    {segment3}
                </div>
            """
        )

    result.MarkupMatches(
        """
        <div class="c1 c2">
          <h1>static</h1>
          <div>1</div>
          <div>1</div>
        </div>
        """
    )
