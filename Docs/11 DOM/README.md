[F# Computation Expressions]: https://learn.microsoft.com/en-us/dotnet/fsharp/language-reference/computation-expressions
[Adaptive Data]: https://github.com/fsprojects/FSharp.Data.Adaptive
[Working With Blazor]: ./Advanced-features/Working-With-Blazor
[Adaptive Forms]: ./Advanced-features/Adaptive/Form

# DOM Elements

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

To render lists you can use `fragment` with any seq-like object, for example you can use list/seq comprehentions to render items.
you can also of course prepare the node fragments beforehand and pass the seq to the html.fragment api.

```fsharp
html.fragment ([
  for item in 0..10 do
    li {
        key item
        $"Item: {item}"
    }
])

html.fragment (seq {
  for item in 0..10 do
    li {
        key item
        $"Item: {item}"
    }
})
```

> Note: Please note that `key` is very useful to preserve list order between re-renders otherwise you might have unexpected changes in the view when you add/remove items from a list.

## Attributes

Fun.Blazor provides out of the box most if not all of the existing HTML attributes in the spec however if you need to set a custom attribute in an element then you can use the `domAttr`` builder that can be used as the following

```fsharp
section {
  domAttr { "my-attribute", "value" }
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

# Dynamic content

> Note: Blazor by default renders the content as static so if you're rendering from the server you won't have any dynamic behavior, for that you need to set server interactivity for the component or use client side blazor (WASM).
> If your project was created with the `fun-wasm` template then you don't have to do anything else for this to work.
> For server interactivity and more information please check the [Working With Blazor] section.

While much of a website content is static, there are times where you have to match the content based on a value you had previously.

## Adaptive Data

Fun.Blazor's way to deal with this is by using [Adaptive Data]. Adaptive values behave a lot like excel cells, where a change propagates through the rest of the connected cells.

This concept has also been used within the javascript ecosystem in recent times often named `signals`.

The `adaptiview` builder will keep track of adaptive values and re-render the component when a change has been detected, this is provides an efficient rendering mechanism while also providing an immutable way to handle state changes in a view.

```fsharp
module DynamicViews =
  open FSharp.Data.Adaptive
  open Fun.Blazor

  let adaptiveNode =
    adaptiview () {
      let! age, setAge = cval(10).WithSetter()

      section {
        $"Age: {age}"
        br

        input {
          type' "number"
          value age
          onchange (fun event -> unbox<string> event.Value |> int |> setAge)
        }
      }
    }
```

## Stores and Observables

> Note: This requires the [Fun.Blazor.Reactive] package

### Observables

> Note: The examples here use the [FSharp.Control.Reactive] package due the functions it provides to help, but it is not required, any `IObservable<T>` works with Fun.Blazor

If you have observable information around it is quite simple to hook it up with Fun.Blazor by using the `html.watch` API

```fsharp
module ReactiveViews =
  open System
  open Fun.Blazor
  open FSharp.Control.Reactive

  let obs = Observable.interval (TimeSpan.FromSeconds(1.))

  article {

    h1 { "My View" }
    p {
      html.watch(obs, (fun num -> fragment { $"Number: {num}" }), 0)
    }
  }
```

### Stores

Another popular way to handle state changes in the frontend ecosystem is the usage of stores which are containers that keep data around for you. they are very similar to observables but they provide a simpler API to work with. Stores are also useful to bind dynamic attributes

```fsharp
module ReactiveViews =
  open Fun.Blazor

  let store: IStore<int> = new Store<int>(initialAge)

  let view() =
    let storeNode =
      html.watch(store, (fun num -> fragment { $"Store: {num}" }))

    article {
      p { storeNode }
    }
```

Both Observables and Stores can be converted into adaptive values to have a uniform data interface to work with

```fsharp

module AdaptiveViews =
  open System
  open Fun.Blazor
  open FSharp.Control.Reactive
  open FSharp.Data.Adaptive

  let observe = Observable.interval (TimeSpan.FromSeconds(1.))
  let store: IStore<int> = new Store<int>(0)

  let adaptiveObs = AVal.ofObservable 0L ignore observe
  let adaptiveStore = AVal.ofObservable 0 ignore store.Observable

  let view() =
    fragment {
      adaptiview () {
        let! fromObs = adaptiveObs
        let! fromStore = adaptiveStore
        fragment { $"Observable: {fromObs} - Store: {fromStore}" }
      }

      button {
        onclick (fun _ -> store.Publish(store.Current + 10))

        "Update Store"
      }
  }
```

## Rendering

Dynamic views re-render when one of the dependencies change and that means the whole node is rendered so you have to keep in mind that whenver you use `html.watch`, `html.bind` or `adaptiview` any of its dependencies may cause a re-render avoid having large trees of information in those places and stay static when possible for performance.

### Adaptive

In the case of adaptive values it is easy to track where something will re-render as it is usually surrounded by `adaptiview` anything inside of `adaptiview` will re-render but the outside world will stay static

```fsharp
// ❌ Avoid
adaptiview() {
  let! content = myAValue

  $"Hello static string" // will re-render
  div { "Hello static node" } // will re-render

  p { // will re-render
    div { // will re-render
      $"Hello dynamic content {content}"// will re-render
    }
  }
}
```

```fsharp
// ✅ Prefer
fragment {
  $"Hello static string" // Stays static
  div { "Hello static node" } // Stays static

  p { // Stays static
    div { // Stays static
      adaptiview() {
        let! content = myAValue
        fragment { $"Hello dynamic content {content}" } // will re-render
      }
    }
  }
}
```

### Stores and Observables

In a similar fashion to adaptive values, whenever you see a `html.watch` call it means that the whole node will re-render when the observable/store value changes.

```fsharp
// ❌ Avoid
html.watch(
  obs,
  (fun value -> fragment {
    $"Hello static string" // will re-render
    div { "Hello static node" } // will re-render

    p { // will re-render
      div { // will re-render
        $"Hello dynamic content {value}"// will re-render
      }
    }
  }),
0)
```

```fsharp
// ✅ Prefer
fragment {
  $"Hello static string" // will stay static
  div { "Hello static node" } // will stay static

  p { // will stay static
    div { // will stay static
      "Hello dynamic content " // will stay static
      html.watch(
        obs,
        (fun value -> fragment { $"{value}" }), //will re-render
        0
      )
    }
  }
}
```
