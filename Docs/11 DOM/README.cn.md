# DOM

对于 Fun.Blazor 来说，最重要的是构建 DOM 的 DSL。在 V2 之前，计算表达式（CE）风格的 DSL 已经得到支持。

构建和组合 DOM 非常容易：

```fsharp

let fragment1 = div { "F=ma" }

let composed =
    div {
        style { height 500 }
        p { "This is the way!" }
        if conditionIsTrue then
            fragment1
            p { "E = MCC" }
    }
```

另外，您可以构建共享的属性/样式片段来组合：

```fsharp
let commonStyle =
    css {
        cursorPointer
        color "green"
    }

let commonAttr =
    domAttr {
        data 123
        asAttrRenderFragment
    }

let sharedButtonAttrs =
    button {
        style {
            commonStyle
            // css 优先级/覆盖由浏览器控制。 
            // 对于 "color"，将使用 "red"。
            color "red" 
        }
        data 456
        // 属性优先级由 blazor 核心控制。
        // 目前，只有在尝试添加相同属性时，才会使用第一个添加的属性。
        // 这就是为什么我把 commonAttr 排在 "data 456" 之下的原因，
        commonAttr
        asAttrRenderFragment // Here is the thing to make the magic happen
    }

let demo =
    div {
        p { "Below we will have a cool button" }
        button {
            onclick ignore
            sharedButtonAttrs
            "Cool"
        }
    }
```

你还可以创建扩展方法以便于重用，这种方式也更加类型安全。而至于**asAttrRenderFragment**，更推荐在局部使用。

对于CSS，你可以：

```fsharp
type StyleBuilder with

    [<CustomOperation("stack")>]
    member inline _.stack([<InlineIfLambda>] comb: CombineKeyValue) =
        comb
        &&& css {
            height "100%"
            displayFlex
            flexDirectionColumn
            alignItemsStretch
            overflowHidden
        }

    [<CustomOperation("strench")>]
    member inline _.strench([<InlineIfLambda>] comb: CombineKeyValue) =
        comb
        &&& css {
            flex 1
            height "100%"
            width "100%"
            positionRelative
            overflowXHidden
            overflowYAuto
        }


let demo =
    div {
        style { stack; backgroundColor "blue" }
        div { "Header" }
        div {
            style { strench; backgroundColor "green" }
        }
    }        
```

对于DOM元素/组件，你可以：

```fsharp
open Fun.Blazor
open Fun.Blazor.Operators
open MudBlazor

type MudTable'<'T> with

    [<CustomOperation("HeaderAndRow")>]
    member this.HeaderAndRow(render: AttrRenderFragment, mappers: (NodeRenderFragment * ('T -> NodeRenderFragment)) seq) =
        let headers = mappers |> Seq.map fst
        let render = this.HeaderContent(render, html.fragment headers)
        this.RowTemplate(render, (fun row -> html.inject (row, (fun () -> mappers |> Seq.map (snd >> fun fn -> fn row) |> html.fragment))))

    [<CustomOperation("withDefaultSettings")>]
    member inline _.withDefaultSettings([<InlineIfLambda>] render: AttrRenderFragment) =
        render
        ==> MudTable'() {
            Hover true
            FixedHeader true
            HorizontalScrollbar true
            Breakpoint Breakpoint.None
            asAttrRenderFragment // with this feature we can have a better coding experience
        }

let demo =
    MudTable'() {
        Height "100%"
        Items items
        HeaderAndRow [
            MudTh'() { "Name" },
            fun item -> MudTd'() { item.Name }

            MudTh'() { "Age" },
            fun item -> MudTd'() { item.Age }
        ]
        withDefaultSettings
    }
```
