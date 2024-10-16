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
    let segment2 = Template.html $"<div style=\"color:red;\">{count}</div>"

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
          <div style="color:red;">1</div>
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
    let segment4 i = SSRTemplate.html $"<div>{count + i}</div>"

    let result =
        context.RenderNode(
            SSRTemplate.html $"""
                <div class="{classes}">
                    {segment1}
                    {segment2}
                    {segment3}
                </div>
                {[for i in 1..10 -> segment4 i]}
            """
        )

    result.MarkupMatches(
        """
        <div class="c1 c2">
          <h1>static</h1>
          <div>1</div>
          <div>1</div>
        </div>
        <div>2</div>
        <div>3</div>
        <div>4</div>
        <div>5</div>
        <div>6</div>
        <div>7</div>
        <div>8</div>
        <div>9</div>
        <div>10</div>
        <div>11</div>
        """
    )
