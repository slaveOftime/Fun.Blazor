module Fun.Blazor.Tests.DomTests

open Microsoft.AspNetCore.Components
open Microsoft.AspNetCore.Components.Web
open Microsoft.AspNetCore.Components.Forms
open Microsoft.AspNetCore.Components.Routing
open Microsoft.Extensions.DependencyInjection
open Moq
open Xunit
open Bunit
open MudBlazor
open Fun.Blazor
open Fun.Blazor.Operators


let private createTestContext () =
    let textContext = new TestContext()

    textContext.Services.AddScoped<INavigationInterception>(fun _ -> Mock.Of<INavigationInterception>())
    |> ignore

    textContext


[<Fact>]
let ``Yield key value attributes`` () =
    let context = createTestContext ()

    let demo =
        html.inject (fun (hook: IComponentHook) ->
            hook.SetDisableEventTriggerStateHasChanged false

            let mutable count = 0

            div {
                data 1
                data "theme" "dark"
                "style", "color: red"
                "width", 10
                "height", 100.1
                "hidden1", true
                "hidden2", false
                "onclick", (fun () -> task { count <- count + 1 })
                "onchange", (fun () -> count <- count + 1)
                childContent [
                    html.text $"count={count}"
                    MudButton'() {
                        "att1", 1
                        "att2", true
                        "Hi"
                    }
                ]
            }
        )

    task {
        let result = context.RenderNode demo
        result.MarkupMatches(
            """
            <div data="1" data-theme="dark" style="color: red" width="10" height="100.1" hidden1=""  >
                count=0
                <button att1="1" att2=""  type="button" class="mud-button-root mud-button mud-button-text mud-button-text-default mud-button-text-size-medium mud-ripple"  >
                    <span class="mud-button-label">Hi</span>
                </button>
            </div>
        """
        )

        do! result.Find("div").ClickAsync(null)
        result.MarkupMatches(
            """
            <div data="1" data-theme="dark" style="color: red" width="10" height="100.1" hidden1=""  >
                count=1
                <button att1="1" att2=""  type="button" class="mud-button-root mud-button mud-button-text mud-button-text-default mud-button-text-size-medium mud-ripple"  >
                    <span class="mud-button-label">Hi</span>
                </button>
            </div>
        """
        )

        result.Find("div").Change(null)
        result.MarkupMatches(
            """
            <div data="1" data-theme="dark" style="color: red" width="10" height="100.1" hidden1=""  >
                count=2
                <button att1="1" att2=""  type="button" class="mud-button-root mud-button mud-button-text mud-button-text-default mud-button-text-size-medium mud-ripple"  >
                    <span class="mud-button-label">Hi</span>
                </button>
            </div>
        """
        )
    }


[<Fact>]
let ``DOM events simple`` () =
    let context = createTestContext ()

    let demo =
        html.inject (fun (hook: IComponentHook) ->
            hook.SetDisableEventTriggerStateHasChanged false

            let mutable count = 0

            div {
                onclick (fun _ -> task { count <- count + 1 })
                onchange (fun _ -> count <- count + 1)
                $"count={count}"
            }
        )

    task {
        let result = context.RenderNode demo
        result.MarkupMatches("""<div>count=0</div>""")

        do! result.Find("div").ClickAsync(null)
        result.MarkupMatches("""<div>count=1</div>""")

        do! result.Find("div").ChangeAsync(null)
        result.MarkupMatches("""<div>count=2</div>""")

        result.Find("div").Change(null)
        result.MarkupMatches("""<div>count=3</div>""")
    }



[<Fact>]
let ``DOM share attrs`` () =
    let context = createTestContext ()

    let sharedImgAttr = input {
        style { width 10 }
        readonly true
        asAttrRenderFragment
    }

    let demo = input {
        src "test"
        sharedImgAttr
    }

    let result = context.RenderNode demo
    result.MarkupMatches("""<input src="test" style="width: 10px; " readonly="">""")


[<Fact>]
let ``DOM CE DSL build check`` () =
    div {
        data 123
        asAttrRenderFragment
    }
    |> ignore

    MudAutocomplete'() {
        Margin Margin.Dense
        Variant Variant.Text
        MaxItems 100
        Clearable true
        Adornment Adornment.Start
        AdornmentIcon Icons.Material.Filled.Search
        IconSize Size.Small
        asAttrRenderFragment
    }
    |> ignore

    CascadingValue'() {
        IsFixed true
        asAttrRenderFragment
    }
    |> ignore


type IFunBlazorBuilder with

    [<CustomOperation("demo")>]
    member inline _.demo([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("demo" => v)

[<Fact>]
let ``DOM CE attribute share check`` () =
    let context = createTestContext ()

    let tempAttr = domAttr {
        demo 123
        asAttrRenderFragment
    }

    MudAlert'() {
        tempAttr
        demo 123
    }
    |> ignore

    let demo = div {
        tempAttr
        title' "t"
        demo 3456
        aria.busy true
        123
    }
    let result = context.RenderNode demo
    result.MarkupMatches("""<div demo="123" title="t" aria-busy="True">123</div>""")
    Assert.Equal("""<div demo="123" title="t" demo="3456" aria-busy="True">123</div>""", result.Markup)


[<Fact>]
let ``Check some attributes`` () =
    let context = createTestContext ()

    let demo = input {
        hidden true
        value true
        type' InputTypes.``datetime-local``
        autocomplete AutoCompleteValues.name.family_name
    }

    let result = context.RenderNode demo
    result.MarkupMatches(
        """
        <input hidden value="True" type="datetime-local" autocomplete="family-name">
        </input>
        """
    )

    let demo = InputFile'() {
        hidden true
        value true
    }

    let result = context.RenderNode demo
    result.MarkupMatches(
        """
        <input hidden value="True" type="file" >
        """
    )


[<Fact>]
let ``script tag should work`` () =
    let context = createTestContext ()

    let demo = script { src "demo" }

    let result = context.RenderNode demo
    result.MarkupMatches(
        """
        <script src="demo"></script>
    """
    )

    let demo = script { "let x = 123;" }

    let result = context.RenderNode demo
    result.MarkupMatches(
        """
        <script>let x = 123;</script>
    """
    )

    let demo = script { "let x = 123;" }

    let result = context.RenderNode demo
    result.MarkupMatches(
        """
        <script>let x = 123;</script>
    """
    )

    let demo = script {
        "let x = 123;"
        "let y = 456;"
    }

    let result = context.RenderNode demo
    result.MarkupMatches(
        """
        <script>let x = 123;let y = 456;</script>
    """
    )


[<Fact>]
let ``Yield RenderFragment directly`` () =
    let context = createTestContext ()

    let demo =
        div.create [|
            div { RenderFragment(fun builder -> builder.AddContent(0, "foo")) }
            div {
                childContent [
                    html.renderFragment (RenderFragment(fun builder -> builder.AddContent(0, "foo2")))
                ]
            }
        |]

    let result = context.RenderNode demo
    result.MarkupMatches("<div><div>foo</div><div>foo2</div></div>")



[<Fact>]
let ``Sections should work`` () =
    let context = createTestContext ()

    let demo =
        div.create [|
            SectionOutlet'() { SectionId "by-id" }
            SectionOutlet'() { SectionName "by-name" }
            div.create [|
                html.text "foo"
                SectionContent'() {
                    SectionId "by-id"
                    div { "id" }
                }
                SectionContent'() {
                    SectionName "by-name"
                    div { "name" }
                }
            |]
        |]

    let result = context.RenderNode demo
    result.MarkupMatches(
        "
        <div>
            <div>id</div>
            <div>name</div>
            <div>foo</div>
        </div>
    "
    )



[<Fact>]
let ``for loop should work for element`` () =
    let context = createTestContext ()

    let demo = div {
        for i in 1..3 do
            if i < 2 then p { i } else span { i }
    }

    let result = context.RenderNode demo
    result.MarkupMatches(
        "
        <div>
            <p>1</p>
            <span>2</span>
            <span>3</span>
        </div>
    "
    )


[<Fact>]
let ``should work for component`` () =
    let context = createTestContext ()

    let demo = MudPaper'() {
        class' "p-2"
        style {
            overflowHidden
            height "100%"
        }
        div { "foo" }
    }

    let result = context.RenderNode demo
    result.MarkupMatches(
        """
        <div class="mud-paper mud-elevation-1 p-2" style="overflow: hidden; height: 100%; ;">
          <div>foo</div>
        </div>
    """
    )


[<Fact>]
let ``for loop should work for component`` () =
    let context = createTestContext ()

    let demo = MudCard'() {
        for i in 1..3 do
            if i < 2 then MudButton'() { i } else span { i }
    }

    let result = context.RenderNode demo
    result.MarkupMatches(
        """
        <div class="mud-paper mud-elevation-1 mud-card" style="">
            <button  type="button" class="mud-button-root mud-button mud-button-text mud-button-text-default mud-button-text-size-medium mud-ripple"  >     
                <span class="mud-button-label">1</span>
            </button>
            <span>2</span>
            <span>3</span>
        </div>
    """
    )


[<Fact>]
let ``bool attribute should work for component`` () =
    let context = createTestContext ()

    let demo = MudButton'' {
        Disabled
        "demo"
    }

    let result = context.RenderNode demo
    result.MarkupMatches(
        """
        <button type="button" disabled="" class="mud-button-root mud-button mud-button-text mud-button-text-default mud-button-text-size-medium mud-ripple">
          <span class="mud-button-label">demo</span>
        </button>
    """
    )

    let demo = MudButton'' {
        Disabled false
        "demo"
    }

    let result = context.RenderNode demo
    result.MarkupMatches(
        """
        <button type="button" class="mud-button-root mud-button mud-button-text mud-button-text-default mud-button-text-size-medium mud-ripple">
          <span class="mud-button-label">demo</span>
        </button>
    """
    )


[<Fact>]
let ``html blazor should work with ComponentAttrBuilder`` () =
    let context = createTestContext ()

    let demo =
        html.blazor (ComponentAttrBuilder<MudPaper>().Add((fun x -> x.Elevation), 10).Add((fun x -> x.Outlined), true))

    let result = context.RenderNode demo
    result.MarkupMatches(
        """
        <div class="mud-paper mud-paper-outlined" style=""></div>
    """
    )


[<Fact>]
let ``support yield seq`` () =
    let context = createTestContext ()

    let demo = div {
        [|
            for i in 1..3 do
                if i < 2 then p { i } else span { i }
        |]
    }

    let result = context.RenderNode demo
    result.MarkupMatches(
        "
        <div>
            <p>1</p>
            <span>2</span>
            <span>3</span>
        </div>
    "
    )

    let demo = MudCard'() {
        [|
            for i in 1..3 do
                if i < 2 then MudButton'() { i } else span { i }
        |]
    }

    let result = context.RenderNode demo
    result.MarkupMatches(
        """
        <div class="mud-paper mud-elevation-1 mud-card" style="">
            <button  type="button" class="mud-button-root mud-button mud-button-text mud-button-text-default mud-button-text-size-medium mud-ripple"  >     
                <span class="mud-button-label">1</span>
            </button>
            <span>2</span>
            <span>3</span>
        </div>
    """
    )


[<Fact>]
let ``renderAsString should work`` () = task {
    let services = ServiceCollection().AddLogging()
    let serviceProvider = services.BuildServiceProvider()
    let! actual = div { "hi" } |> html.renderAsString serviceProvider
    Assert.Equal("<div>hi</div>", actual)
}


[<Fact>]
let ``empty body ce should work`` () =
    let context = createTestContext ()

    let demo = MudButton'' { }

    let result = context.RenderNode demo
    result.MarkupMatches(
        """
        <button  type="button" class="mud-button-root mud-button mud-button-text mud-button-text-default mud-button-text-size-medium mud-ripple"  >
          <span class="mud-button-label"></span>
        </button>
        """
    )


    let demo2 = div {
        div
        div { }
        if true then a { }
        MudSpacer'' { }
    }

    let result = context.RenderNode demo2
    result.MarkupMatches(
        """
        <div>
          <div></div>
          <div></div>
          <a></a>
          <div aria-hidden="true" class="flex-grow-1"></div>
        </div>
        """
    )

    let demo3 = MudContainer'' {
        div
        div { }
        if true then a { }
        MudSpacer'' { }
        if true then
            MudButton'' { if true then MudIcon'' { Icon Icons.Material.Filled.Add } }
        if false then section {}
    }

    let result = context.RenderNode demo3
    result.MarkupMatches(
        """
        <div class="mud-container mud-container-maxwidth-lg mud-container--gutters">
            <div></div>
            <div></div>
            <a></a>
            <div aria-hidden="true" class="flex-grow-1"></div>
            <button  type="button" class="mud-button-root mud-button mud-button-text mud-button-text-default mud-button-text-size-medium mud-ripple"  >
                <span class="mud-button-label">
                    <svg class="mud-icon-root mud-svg-icon mud-icon-size-medium" focusable="false" viewBox="0 0 24 24" aria-hidden="true" role="img">
                    <path d="M0 0h24v24H0z" fill="none"></path>
                    <path d="M19 13h-6v6h-2v-6H5v-2h6V5h2v6h6v2z"></path>
                    </svg>
                </span>
            </button>
        </div>
        """
    )


[<Fact>]
let ``form should work`` () =
    let context = createTestContext ()

    let demo = form {
        dataEnhance true
        formName "demo"
        input { value 1 }
    }

    let result = context.RenderNode demo
    result.MarkupMatches(
        """
        <form data-enhance="true">
          <input value="1">
        </form>
        """
    )
