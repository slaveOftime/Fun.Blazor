# DOM DSL

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
        asAttrRenderFragment
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
