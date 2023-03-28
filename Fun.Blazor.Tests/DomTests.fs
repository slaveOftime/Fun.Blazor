module Fun.Blazor.Tests.DomTests

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
        html.comp (fun (hook: IComponentHook) ->
            hook.SetDisableEventTriggerStateHasChanged false

            let mutable count = 0

            div {
                "style", "color: red"
                "width", 10
                "height", 100.1
                "hidden1", true
                "hidden2", false
                "onclick", (fun () -> task { count <- count + 1 })
                "onchange", (fun () -> count <- count + 1)
                $"count={count}"
            }
        )

    task {
        let result = context.RenderNode demo
        result.MarkupMatches("""<div style="color: red" width="10" height="100.1" hidden1="" >count=0</div>""")

        do! result.Find("div").ClickAsync(null)
        result.MarkupMatches("""<div style="color: red" width="10" height="100.1" hidden1="" >count=1</div>""")

        result.Find("div").Change(null)
        result.MarkupMatches("""<div style="color: red" width="10" height="100.1" hidden1="" >count=2</div>""")
    }


[<Fact>]
let ``DOM events simple`` () =
    let context = createTestContext ()

    let demo =
        html.comp (fun (hook: IComponentHook) ->
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

    let sharedImgAttr = img {
        style { width 10 }
        readonly true
        asAttrRenderFragment
    }

    let demo = img {
        src "test"
        sharedImgAttr
    }

    let result = context.RenderNode demo
    result.MarkupMatches("""<img src="test" style="width: 10px; " readonly=""></img>""")


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

    let tempAttr =
        domAttr {
            demo 123
            asAttrRenderFragment
        }

    MudAlert'() {
        tempAttr
        demo 123
    }
    |> ignore

    let demo =
        div {
            tempAttr
            title' "t"
            demo 3456
        }
    let result = context.RenderNode demo
    result.MarkupMatches("""<div demo="123" title="t"></div>""")
    Assert.Equal("""<div demo="123" title="t" demo="3456"></div>""", result.Markup)


[<Fact>]
let ``Check some attributes`` () =
    let context = createTestContext ()

    let demo =
        div {
            hidden true
            type' InputTypes.``datetime-local``
            autocomplete AutoCompleteValues.name.family_name
        }

    let result = context.RenderNode demo
    result.MarkupMatches("""<div hidden="true" type="datetime-local" autocomplete="family-name"></div>""")
