# Interactive Nodes

> Note: Blazor by default renders the content as static so if you're rendering from the server you won't have any dynamic behavior, for that you need to set server interactivity for the component or use client side blazor (WASM).
> If your project was created with the `fun-wasm` template then you don't have to do anything else for this to work.
> For server interactivity and more information please check the [Working With Blazor] section.

While much of a website content is static, there are times where you have to match the content based on a value you had previously.

## Adaptive Data

Fun.Blazor's way to deal with this is by using [Adaptive Data] which is included out of the box. Adaptive values behave a lot like excel cells, where a change propagates through the rest of the connected cells.

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

Dynamic views re-render when one of the dependencies change and that means the whole node is rendered so you have to keep in mind that whenver you use `html.watch`, or `adaptiview` any of its dependencies may cause a re-render avoid having large trees of information in those places and stay static when possible for performance.

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

[Adaptive Data]: https://github.com/fsprojects/FSharp.Data.Adaptive
[Working With Blazor]: ./Advanced-features/Working-With-Blazor
[Fun.Blazor.Reactive]: https://github.com/slaveOftime/Fun.Blazor
[FSharp.Control.Reactive]: http://fsprojects.github.io/FSharp.Control.Reactive/index.html
