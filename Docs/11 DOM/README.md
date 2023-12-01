# DOM

Fun.Blazor provides a friendly way to write HTML for web applications. It uses [F# Computation Expressions] to generate a simple yet performant DSL.

```fsharp
let hello name =
  div {
    id "my-id"
    class' "my-class"
    $"Hello, {name}"
  }

hello "World!"
```

Calling that function would produce a markup like

```html
<div id="my-id" class="my-class">Hello, World!</div>
```

> Some html attributes are reserved keywords in F#, and that's why `'` is added at the end of those names, in this case `class'` instead of `class`

> Note: Attributes must be placed before any other elements, like strings or other nodes

## Control Flow

Since you're using F# for your markup code, you have all of the F# arsenal at your disposal that includes `match`, `if`, `function` and even lists of elements but to avoid having problems with mismatch between content in the element rendering you should use `fragment` or `region` these are containerless builders that isolate blazor's node count which can be useful for performance as well as keeping the content concistent.

### If/Else

```fsharp

let element isVisible =
  div {
    $"The element is: "
    region {
      if isVisible then
        "Visible"
      else
        "Not Visible"
    }
  }
```

### Match

```fsharp

let element kind =
  div {
    $"The element is: "
    region {
      match kind with
      | Fantastic -> "Fantastic"
      | Average -> "Average"
      | WellItsSomething -> "Wel... it is something"
    }
  }
```

### Lists

To render lists you can use `for item in items do`

```fsharp
ul {
  h3 { "Some title." }
  for item in 0..10 do
    li {
        key item
        $"Item: {item}"
    }

}

```

Or also if you have an existing list of nodes you can use the `childContent` operation.

```fsharp
ul {
  childContent listOfNodes
}
```

> Note: Please note that `key` is very useful to preserve list order between re-renders otherwise you might have unexpected changes in the view when you add/remove items from a list.

## Attributes

Fun.Blazor provides out of the box most if not all of the existing HTML attributes in the spec however if you need to set a custom attribute in an element then you can provide the builder with a string tuple.

```fsharp
section {
  "my-attribute", "value"
}
```

### Shared attributes

If you'd like to share attributes between different elements you can use the `domAttr`

```fsharp
module SharedAttrs =
  let classAndData =
    domAttr {
      class' "has-data"
      data("my-data", "123")
    }

let someNode() =
  div {
    SharedAttrs.classAndData
    "Some Node"
  }

let otherNode() =
  div {
    SharedAttrs.classAndData
    "Other Node"
  }

```

## Events

Events conform to the standard HTML event names, so you will find them in any element as usual.
handlers can be async or sync depending on your usage but they're often defined as `EventArgs -> unit` or `EventArgs -> Task<unit>`

```fsharp
button {
  onclick(fun e -> printfn "clicked")
  "Click Me"
}

button {
  onclick(fun e -> task {
    do! Async.Sleep 1000
    printfn "clicked"
  })
  "Click Me Task"
}
```

For inputs remember that events provide values as strings, so you have to unbox them

```fsharp
input {
  placeholder "Write Something"
  oninput(fun e ->
    unbox<string> e.Value |> printfn "New Value: '%s'"
  )
}

input {
  type' "number"
  placeholder "Change Number"
  oninput(fun e ->
    unbox<string> e.Value |> int |> printfn "New Value: '%i'"
  )
}
```

> Note: If you're realing with forms you should check out [Adaptive Forms] instead. They can work with more structured objects like records and provide validation abilities.

[F# Computation Expressions]: https://learn.microsoft.com/en-us/dotnet/fsharp/language-reference/computation-expressions
[Adaptive Data]: https://github.com/fsprojects/FSharp.Data.Adaptive
[Working With Blazor]: ./Advanced-features/Working-With-Blazor
[Adaptive Forms]: ./Advanced-features/Adaptive/Form
