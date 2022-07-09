# DOM

The most important thing for **Fun.Blazor** is the DSL to build the DOM. 
Even before V2, computation expression style DSL is already supported.

It is very easy to build and compose dom:

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

Also you can build a shared attributes/style fragment to compose:

```fsharp
let commonStyle =
    css {
        cursorPointer
        color "green"
    }

let commonAttr =
    domAttr {
        data 123
    }

let sharedButtonAttrs =
    button {
        style {
            commonStyle
            color "red" // css priority/override is controlled by browser. For "color", "red" will be used.
        }
        data 456
        commonAttr  // attribute priority is controlled by blazor core. Currently only the first added attribute will be used when you are trying to add same attribute. That is why I put commonAttr lower than "data 456", so the 456 will be used even in commonAttr "data" is 123.
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

You can also create extension operation method to create something to reuse.

For css you can do:

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
        div { "header" }
        div {
            style { strench; backgroundColor "green" }
        }
    }        
```

For DOM element/component, you can do:

```fsharp
type MudTable'<'T> with

    [<CustomOperation("HeaderAndRow")>]
    member this.HeaderAndRow(render: AttrRenderFragment, mappers: (NodeRenderFragment * ('T -> NodeRenderFragment)) seq) =
        let headers = mappers |> Seq.map fst
        let render = this.HeaderContent(render, html.fragment headers)
        this.RowTemplate(render, (fun row -> html.inject (row, (fun () -> mappers |> Seq.map (snd >> fun fn -> fn row) |> html.fragment))))

let demo =
    MudTable'() {
        Height "100%"
        FixedHeader true
        HorizontalScrollbar true
        Breakpoint Breakpoint.None
        Items items
        Hover true
        HeaderAndRow [
            MudTh'() { "Name" },
            fun item -> MudTd'() { item.Name }

            MudTh'() { "Age" },
            fun item -> MudTd'() { item.Age }
        ]
    }
```
