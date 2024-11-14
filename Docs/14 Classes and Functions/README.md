# Classes vs Functions

[Interactive Nodes]: ./Interactive-Nodes
[Hooks]: ./Advanced-features/Hook
[Dependency Injection]: ./Advanced-features/Dependency-injection-(DI)

Fun.Blazor is very flexible and allows you to choose between classes and functions as you need.

For the most part you can use functions as much as you'd like but there are situations wher classes may come in handy (like writing blazor components for other teams).

## Functions

Functions are executed once and they are not re-executed unless the parent re-renders

```fsharp
let staticGreeting name =
    p { $"Hello there, {name}!" }
```

This function given the same parameter will always output the same p tag with the same content and it will never change again, the same goes for functions that enclose mutable values, for example the following function will not re-render

```fsharp
let staticGreeting()=
    let mutable counter = 0

    button {
        onclick (fun _ -> counter <- counter + 1)
        $"Click Me: {counter}"
    }
```

This is because the change detection mechanics happen at the component level, that means class inheriting ComponentBase which in the case of Fun.Blazor is `FunComponent`.
However If change the declaration from a function (`let staticGreeting () =`) to a let bound value (`let staticGreeting =`) , and use it in a context which its parent component has re-render triggers (like event handlers in `FunComponent`s, see the below section on classes.), the count will increase and updated.

However if you want to work with dynamic data in your functions, you can use `Adaptive` values, `Stores`, or `Observables` which you can read further in [Interactive Nodes]. A brief example with adaptive values would be:

```fsharp

let staticChild name (currentName: string cval) =
    button {
        // trigger currentName changes
        onclick(fun _ -> currentname.Publish name)
        $"Click {name}!"
    }

let staticParent () =
    let currentName = cval("Nobody")
    fragment {
        // doesn't re-render
        h1 { $"Initial Name: {currentName.Value}" }

        // render on currentName changes
        adapt {
            let! currentName = currentName
            h1 { $"Hello, {currentName}!" }
        }

        staticChild "Peter" currentName
        staticChild "Frank" currentName
    }
```

This reduces the need to have classes for most of the codebase, you can combine dynamic data with Fun.Blazor's DSL to go as functional as you need.

### Benefits and drawbacks

The benefits are:

- Simpler to test
- Easier to reason about
- Composable

They are often the preferred way to go for most F# users.

The downsides are:

- Don't have access to aspnet's default DI container
- Don't play well raw blazor
- They need to be wrapped in components in order for C# consumers to use

In short the closer you want to get to Blazor, the least functions work nicely with it.

However, most of the time a function is the simple yet correct choice.

## Classes

Blazor by default re-renders in certain conditions like after an event handler is executed, changing parameters/cascading parameters and when calling `this.StateHasChanged()` so it plays well with mutable values even in F#.

A simple counter example would be the following:

```fsharp
type Counter() =
    inherit FunComponent()

    let mutable counter = 0

    [<Inject>]
    member val Logger: ILogger<Counter> = Unchecked.defaultof<_> with get, set

    override this.Render() =
        fragment {
            h1 { $"Count: {counter}" }

            button {
                onclick (fun _ ->
                    let newCount = counter + 1
                    this.Logger.LogDebug("Old Value: {count} - New Value: {newCount}", counter, newCount)
                    counter <- newCount
                )
                "Increment"
            }
        }
```

In this case we didn't add any dynamic values like Adaptive data, Stores or Observables and our counter is re-rendered and works as expected, blazor applies a diffing algorithm to know that it only needs to re-render the `h1` tag. you can also however use dynamic data if required.

### Using adaptive data

If you would like to avoid re-rendering your components at event handlers, you can opt out of it by using `FunBlazorComponent` this base class turns off re-renders for event triggers.

```fsharp
type Demo() =
    // Note this is not the same as *inherit FunComponent()*
    inherit FunBlazorComponent()

    let data = cval 0

    override _.Render() = fragment {
        h1 { "Static text" }
        adapt {
            let! data = data
            // only this part will need to be used for computate for diff when data is changed
            p { $"x = {data}" }
        }
        button {
            onclick (fun _ -> data.Publish(fun value -> value + 1))
            "Increase"
        }
    }
```

This has the added benefit that updates are more localized and you don't accidentally re-render on event handlers, most of the time it should not be an issue, but if you require to have more control of it, then this is the ideal way to do it.

### Benefits and drawbacks

In general classes are good to use within Fun.Blazor and are a safe choice if your project needs them.

The benefits are:

- Offer full decorator support `Parameter`, `Cascading Parameter`, `Route`, `Inject`
- Has direct access to the DI container in aspnet
- Consumption is transparent for C# consumers
- Plays well with the blazor framework under the hood.

The drawbacks are:

- They require manual bindings to play well with the Fun.Blazor DSL
- Verbose

In general, classes can be used to orchestrate dependency injection, to use plain blazor features seamlessly, and to keep as close as blazor as possible.

Functions most of the time can overcome the benefits of classes when you use `html.inject` which you can read more about in [Hooks] and [Dependency Injection].
